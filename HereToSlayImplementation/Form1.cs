using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Azure.Core;
using System.Security.Cryptography.Xml;
using Microsoft.EntityFrameworkCore;
using System.CodeDom;
namespace HereToSlayImplementation

{
    public partial class Form1 : Form
    {
        static public Form1 instance1;
        static public SqlConnection sqlConnection;
        //public static string CONNECT = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\naner\\source\\repos\\HereToSlayImplementation\\HereToSlayImplementation\\obj\\DungeonMayhem.mdf\"; Integrated Security=True;Connect Timeout=30";
        public static string CONNECT = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"M:\\Visual Studio 2022\\MyCode\\NeaWork\\HereToSlayImplementation\\HereToSlayImplementation\\obj\\DungoenMayhemDatabase.mdf\"; Integrated Security=True;Connect Timeout=30";
        public bool loggedin = false;
        public Player thisPlayer;
        public string EncryptedPassword;
        public Form3 GameWindow;



        public class Player
        {
            private string Username;
            private int playerID;
            private int GameID;
            private int playerNumber;
            private List<Button> Hand;
            private int Health;
            private int Defense;
            private string deck;
            private int _actionpoints;
            private int actionPoints
            {
                get { return _actionpoints; }
                set
                {
                    if (value < 0)
                    {
                        _actionpoints = 0;
                    }
                    else
                    {
                        _actionpoints = value;
                    }
                }
            }





            public Player(string u, int p, int g = -1, int pn = 0)
            {
                Username = u;
                playerID = p;
                GameID = g;
                this.playerNumber = pn;
                Hand = new List<Button>();
                actionPoints = 1;
                Health = 10;
                Defense = 0;
                
            }

            public string GetDeck()
            {
                return deck;
            }

            public void SetDeck(string x)
            {
                deck = x;
            }

            public List<Button> GetHand()
            {
                return Hand;
            }

            public int GetDefense()
            {
                return Defense;
            }

            public void SetDefence(int x)
            {
                Defense += x;

                if (Defense < 0)
                {
                    Health += Defense;
                    Defense = 0;
                }
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

            public int GetPlayerNumber()
            {
                return playerNumber;
            }

            public void SetPlayerNumber(int x)
            {
                playerNumber = x;
            }

            public int GetActionPoints()
            {
                return actionPoints;
            }

            public void LoseActionsPoints(int x)
            {
                actionPoints -= x;
            }
            public void ResetActionsPoints()
            {
                actionPoints = 1;
            }
            public void AddCardToHand(Button card)
            {
                Hand.Add(card);
            }

            public int GetHealth()
            {
                return Health;
            }

            public void SetHealth(int x)
            {
                Health -= x;
            }
        }
        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(CONNECT);
            instance1 = this;
            HostButton.Hide();
            JoinButton.Hide();
            JoinTextBox.Hide();

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
                        thisPlayer = new Player(UsernameTextBox.Text, reader.GetInt32(1));
                        UsernameTextBox.Text = PasswordTextBox.Text = "";
                        UsernameLabel.Hide();
                        UsernameTextBox.Hide();
                        LoginButton.Hide();
                        PasswordLabel.Hide();
                        PasswordTextBox.Hide();
                        SignUpButton.Hide();

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
                            UsernameLabel.Hide();
                            UsernameTextBox.Hide();
                            LoginButton.Hide();
                            PasswordLabel.Hide();
                            PasswordTextBox.Hide();
                            SignUpButton.Hide();
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
                                thisPlayer = new Player(UsernameTextBox.Text, reader.GetInt32(1));
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
            SqlCommand command = new SqlCommand($"INSERT INTO Games (PlayerID1) VALUES ({thisPlayer.GetplayerID()})", sqlConnection);
            command.ExecuteNonQuery();

            SqlCommand command2 = new SqlCommand($"SELECT GameID FROM Games WHERE PlayerID1 = {thisPlayer.GetplayerID()}", sqlConnection);
            using (SqlDataReader reader = command2.ExecuteReader())
            {
                if (reader.Read())
                {
                    thisPlayer.SetGameID(reader.GetInt32(0));
                }
            }

            SqlCommand command3 = new SqlCommand($"UPDATE Player SET GameIDfk = {thisPlayer.GetGameID()} WHERE playerID = {thisPlayer.GetplayerID()}", sqlConnection);
            command3.ExecuteNonQuery();
            sqlConnection.Close();
            thisPlayer.SetPlayerNumber(1);

            this.Hide();
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
                        if (reader.GetInt32(1) != thisPlayer.GetplayerID())
                        {
                            thisPlayer.SetGameID(value);
                        }
                        else
                        {
                            NotInAGame = false;
                            SqlCommand command = new SqlCommand($"DELETE Games WHERE PlayerID1 = {thisPlayer.GetplayerID()}", sqlConnection);
                            JoinWarningTextBox.Text = "Youre account was hosting a game, That game has been terminated please try again";
                        }
                    }
                }

                SqlCommand command3 = new SqlCommand($"SELECT * FROM Games WHERE GameID = {value}", sqlConnection);
                using (SqlDataReader reader = command3.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        for (int i = 1; i < 6; i++)
                        {
                            if (reader.IsDBNull(i))
                            {
                                SqlCommand command2 = new SqlCommand($"UPDATE Games SET PlayerID{i} = {thisPlayer.GetplayerID()} WHERE GameID = {thisPlayer.GetGameID()} \nUPDATE Player SET GameIDfk = {thisPlayer.GetGameID()} WHERE playerID = {thisPlayer.GetplayerID()}", sqlConnection);
                                command2.ExecuteNonQuery();
                                NotInAGame = false;
                                Form1.instance1.thisPlayer.SetPlayerNumber(i);
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
                    new Form2().Show();
                    this.Hide();
                }
            }
        }

        private void Testbutton_Click(object sender, EventArgs e)
        {
            thisPlayer.SetPlayerNumber(1);
            thisPlayer.SetDeck("minsc & boo");
            GameWindow = new Form3();
            GameWindow.Show();
            this.Hide();
        }
    }
}
