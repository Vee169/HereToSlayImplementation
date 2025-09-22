using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HereToSlayImplementation
{
    public partial class Form2 : Form
    {
        static public SqlConnection sqlConnection;
        //public static string CONNECT = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\naner\\OneDrive - Esher Sixth Form College\\MyCode\\WinFormsApp1\\WinFormsApp1\\HereToSlayDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
        public static string CONNECT = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"M:\\Visual Studio 2022\\MyCode\\NeaWork\\HereToSlayImplementation\\HereToSlayImplementation\\obj\\HereToSlayDatabase\"; Integrated Security=True;Connect Timeout=30";
        Form2 instance;
        public System.Windows.Forms.Timer timer;
        int Seconds;
        bool StartButtonClicked;
        public Form2()
        {
            InitializeComponent();
            instance = this;

            GameIDLabel.Text = "Game code is:";
            ReadyTimer.Start();
            ReadyTimer.Tick += ReadyTimer_Tick;
            sqlConnection = new SqlConnection(CONNECT);
            Updateplayers();
            GameIDLabel.Text += Form1.instance1.thisPlayer.GetGameID();
            StartButton.Hide();
            Seconds = 5;
            StartButtonClicked = false;
            CountdownLabel.Hide();
        }
        public void Updateplayers()
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand($"SELECT Username FROM Games, Player WHERE Games.GameID = {Form1.instance1.thisPlayer.GetGameID()} AND Games.GameID = Player.GameIDfkp", sqlConnection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!PlayerListBox.Items.Contains(reader.GetString(0)))
                    {
                        PlayerListBox.Items.Add(reader.GetString(0));
                    }
                }
            }
            sqlConnection.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ReadyTimer_Tick(object sender, EventArgs e)
        {
            if (PlayerListBox.Items.Count >= 2)
            {
                ReadyTimer.Enabled = false;
                ReadyTimer.Stop();
                if (Form1.instance1.thisPlayer.GetPlayerNumber() == 1)
                {
                    StartButton.Show();
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT GameStart FROM Games WHERE GameID = {Form1.instance1.thisPlayer.GetGameID()}", sqlConnection);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.GetInt32(0) == 1)
                            {
                                SecondTimer.Enabled = true;
                                SecondTimer.Start();
                                CountdownTimer.Enabled = true;
                                CountdownTimer.Start();
                                CountdownLabel.Show();
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            Updateplayers();
            StartButton.Show();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE Games SET GameStart = 1 WHERE GameID = {Form1.instance1.thisPlayer.GetGameID()}", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            StartButtonClicked = true;
            CountdownTimer.Enabled = true;
            CountdownTimer.Start();
            SecondTimer.Enabled = true;
            SecondTimer.Start();

        }

        private void SecondTimer_Tick(object sender, EventArgs e)
        {
            if (Seconds > 0)
            {
                CountdownLabel.Text = Seconds--.ToString();
            }
            else if (Seconds == 0)
            {
                SecondTimer.Stop();

            }
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            CountdownTimer.Stop();
            this.Close();
            new Form3().ShowDialog();

        }

        private void PlayerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
