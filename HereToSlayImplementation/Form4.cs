using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static HereToSlayImplementation.Form3;

namespace HereToSlayImplementation
{
    public partial class Form4 : Form
    {
        static public SqlConnection sqlConnection;
        public static Form1.Player player;
        public Form4()
        {
            sqlConnection = new SqlConnection(Form1.CONNECT);
            player = GM.GameForm.game.GetPlayer(0);
            if (player.GetWinner() == true)
            {
                WinTextBox.Text = $"congratulations {player.GetUsername()} on winning\n you can either quit or go back to Login and join another game";
            }
            else
            {
                WinTextBox.Text = $"You'll do better next time {player.GetUsername()}\n you can either quit or go back to Login and join another game";
            }
                InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand($"SELECT GameStart FROM Games WHERE GameID = {player.GetGameID()}", sqlConnection);
            SqlCommand cmd2 = null;
            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                if(reader.Read())
                {
                    if(reader.GetInt32(0) == 0)
                    {
                        cmd2 = new SqlCommand($"DELETE FROM Games WHERE GameID = {player.GetGameID()}", sqlConnection);
                    }
                    else
                    {
                        cmd2 = new SqlCommand($"UPDATE Games SET GameStart = 0 WHERE GameID = {player.GetGameID()}", sqlConnection);
                    }
                }
            }
            cmd2.ExecuteNonQuery();
            sqlConnection.Close();

            GM.LoginForm.Show();
            GM.WinForm.Close();
        }
    }
}
