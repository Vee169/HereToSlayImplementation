using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Azure.Core;
using System.Security.Cryptography.Xml;
using Microsoft.EntityFrameworkCore;
namespace HereToSlayImplementation

{
    public partial class Form1 : Form
    {
        static public Form1 instance1;
        static public SqlConnection sqlConnection;
        public static string CONNECT = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\naner\\source\\repos\\HereToSlayImplementation\\HereToSlayImplementation\\obj\\HereToSlayDatabase.mdf\"; Integrated Security=True;Connect Timeout=30";
        public bool loggedin = false;
        public Player player;
        public string EncryptedPassword;

        public class Card : Button
        {
            protected string cardName;
            public Card(string cardName = "")
            {
                this.cardName = cardName;
                Size = new Size(281, 422);
            }

            public string GetCardName()
            {
                return cardName;
            }
        }

        public class Player
        {
            private string Username;
            private int playerID;
            private int GameID;
            private Card[] party;
            private bool player1;


            

            public Player(string u, int p, int g = -1, bool player1 = false)
            {
                Username = u;
                playerID = p;
                GameID = g;
                party = new Card[6];
                this.player1 = player1;
            }

            public string GetUsername()
            {
                return Username;
            }

            public int GetplayerID()
            {
                return playerID;
            }

            public int GetGameID()
            {
                return GameID;
            }

            public void SetGameID(int x)
            {
                GameID = x;
            }

            public bool IsPlayer1()
            {
                return player1;
            }

            public void SetPlayer1(bool x)
            {
                player1 = x;
            }

            public Button[] GetParty()
            {
                return party;
            }

            public void SetParty(Card[] x)
            {
                party = x;
            }
        }
        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(CONNECT);
            instance1 = this;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            AccountMessageTextBox.Text = string.Empty;
            UsernameTextBox.Text = UsernameTextBox.Text.Trim();
            PasswordTextBox.Text = PasswordTextBox.Text.Trim();
            EncryptedPassword = PasswordTextBox.Text;
            if (!loggedin)
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand($"SELECT UserName, playerID FROM Player WHERE UserName = '{UsernameTextBox.Text}' AND AccountPassword = '{EncryptedPassword}'", sqlConnection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        loggedin = true;
                        HostButton.Show();
                        JoinButton.Show();
                        JoinTextBox.Show();
                        player = new Player(UsernameTextBox.Text, reader.GetInt32(1));
                        UsernameTextBox.Text = PasswordTextBox.Text = "";

                    }
                    else
                    {
                        loggedin = false;
                        AccountMessageTextBox.Text = "This username password combonation does not exist";
                        UsernameTextBox.Text = PasswordTextBox.Text = "";
                        EncryptedPassword = "";
                    }
                }
                sqlConnection.Close();
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            AccountMessageTextBox.Text = string.Empty;
            UsernameTextBox.Text = UsernameTextBox.Text.Trim();
            PasswordTextBox.Text = PasswordTextBox.Text.Trim();
            EncryptedPassword = PasswordTextBox.Text;
            if (!loggedin)
            {
                if (!(UsernameTextBox.Text.Contains(' ') || PasswordTextBox.Text.Contains(' ')))
                {


                    bool isPlayer = true;
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand($"SELECT UserName FROM Player WHERE UserName = '{UsernameTextBox.Text}'", sqlConnection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            isPlayer = false;

                            loggedin = true;
                            HostButton.Show();
                            JoinButton.Show();
                            JoinTextBox.Show();
                        }
                        else
                        {
                            AccountMessageTextBox.Text = "That Username already exists";
                        }

                    }
                    if (!isPlayer)
                    {
                        SqlCommand command2 = new SqlCommand($"INSERT INTO Player (UserName, AccountPassword) VALUES ('{UsernameTextBox.Text}', '{PasswordTextBox.Text}')", sqlConnection);
                        command2.ExecuteNonQuery();

                        SqlCommand command3 = new SqlCommand($"SELECT UserName, playerID FROM Player WHERE UserName = '{UsernameTextBox.Text}' AND AccountPassword = '{PasswordTextBox.Text}'", sqlConnection);

                        using (SqlDataReader reader = command3.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                player = new Player(UsernameTextBox.Text, reader.GetInt32(1));
                            }
                        }
                    }

                    sqlConnection.Close();
                }
                else
                {
                    AccountMessageTextBox.Text = "no spaces in the username or password";
                }
                UsernameTextBox.Text = PasswordTextBox.Text = "";
            }
        }

        private void HostButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand($"INSERT INTO Games (PlayerID1) VALUES ({player.GetplayerID()})", sqlConnection);
            command.ExecuteNonQuery();

            SqlCommand command2 = new SqlCommand($"SELECT GameID FROM Games WHERE PlayerID1 = {player.GetplayerID()}", sqlConnection);
            using (SqlDataReader reader = command2.ExecuteReader())
            {
                if (reader.Read())
                {
                    player.SetGameID(reader.GetInt32(0));
                }
            }

            SqlCommand command3 = new SqlCommand($"UPDATE Player SET GameIDfkp = {player.GetGameID()} WHERE playerID = {player.GetplayerID()}", sqlConnection);
            command3.ExecuteNonQuery();
            sqlConnection.Close();
            player.SetPlayer1(true);

            this.Close();
            new Form2().ShowDialog();
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            JoinTextBox.Text = JoinTextBox.Text.Trim();
            JoinWarningTextBox.Text = null;
            bool NotInAGame = true;
            if (JoinTextBox.Text == null)
            {
                JoinWarningTextBox.Text = "you need to input a game code if you want to join a game";
            }
            else if (int.TryParse(JoinTextBox.Text, out int value))
            {
                sqlConnection.Open();

                SqlCommand command1 = new SqlCommand($"SELECT GameID, PlayerID1 FROM Games WHERE GameID = {value}", sqlConnection);
                using (SqlDataReader reader = command1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader.GetInt32(1) != player.GetplayerID())
                        {
                            player.SetGameID(value);
                        }
                        else
                        {
                            NotInAGame = false;
                            SqlCommand command = new SqlCommand($"DELETE Games WHERE PlayerID1 = {player.GetplayerID()}", sqlConnection);
                            JoinWarningTextBox.Text = "Youre account was hosting a game, That game has been terminated please try again";
                        }
                    }
                }
                
                SqlCommand command3 = new SqlCommand($"SELECT * FROM Games WHERE GameID = {value}", sqlConnection);
                using(SqlDataReader reader = command3.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        for (int i = 1; i < 6; i++)
                        {
                            if (reader.IsDBNull(i))
                            {
                                SqlCommand command2 = new SqlCommand($"UPDATE Games SET PlayerID{i} = {player.GetplayerID()} WHERE GameID = {player.GetGameID()} \nUPDATE Player SET GameIDfkp = {player.GetGameID()} WHERE playerID = {player.GetplayerID()}", sqlConnection);
                                command2.ExecuteNonQuery();
                                NotInAGame = false;
                                break;
                            }
                        }
                    }
                }
                if (NotInAGame)
                {
                    JoinWarningTextBox.Text = "The game you have tried to join is already full";
                }
                else
                {
                    sqlConnection.Close();
                    this.Close();
                    new Form2().ShowDialog();
                }
            }
        }
    }
}
