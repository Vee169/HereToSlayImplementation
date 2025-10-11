using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HereToSlayImplementation
{
    public partial class Form3 : Form
    {
        static public Form3 instance3;
        public System.Windows.Forms.Timer timer;
        static public SqlConnection sqlConnection;
        //public static string CONNECT = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\naner\\OneDrive - Esher Sixth Form College\\MyCode\\WinFormsApp1\\WinFormsApp1\\HereToSlayDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
        //public static string CONNECT = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"M:\\Visual Studio 2022\\MyCode\\NeaWork\\HereToSlayImplementation\\HereToSlayImplementation\\obj\\HereToSlayDatabase.mdf\"; Integrated Security=True;Connect Timeout=30";
        Game game;
        int thisPlayer;
        Button selectedButton;
        public Button discard = new Button();
        
        public Form3()
        {
            instance3 = this;

            InitializeComponent();
            sqlConnection = new SqlConnection(Form1.CONNECT);
            sqlConnection.Open();
            Form1.Player[] players = new Form1.Player[6];
            discard = Form3.instance3.PlayerDiscardButton;


            for (int i = 0; i < 6; i++)
            {

                if (i != Form1.instance1.thisPlayer.GetPlayerNumber())
                {
                    SqlCommand command = new SqlCommand($"SELECT playerID, UserName FROM Player, Games WHERE Games.GameID = Player.GameIDfk AND Games.PlayerID{i} = Player.playerID", sqlConnection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.GetString(1) != null)
                        {
                            players[i] = new Form1.Player(reader.GetString(1), reader.GetInt32(0));
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    players[i] = Form1.instance1.thisPlayer;
                    thisPlayer = i;
                }
            }
            sqlConnection.Close();
            game = new Game(players);
            game.DealHand(thisPlayer);

        }

        public enum HeroClass
        {
            wizard,
            thief,
            guardian,
            fighter,
            ranger,
            bard,
            no
        }

        public class Game
        {
            private Form1.Player[] players;
            private List<Form1.Card> Discard;
            private List<Form1.Card> Deck;

            public Game(Form1.Player[] p)
            {
                players = p;
                Discard = new List<Form1.Card>();
                Deck = new List<Form1.Card>();
            }

            public Form1.Player GetPlayer(int x)
            {
                return players[x];
            }

            public void discardAcard(Form1.Card card)
            {
                Discard.Add(card);
            }

            public void DrawACard(int x, bool y = true)
            {
                Random rnd = new Random();
                players[x].AddCardToHand(Deck[rnd.Next(Deck.Count - 1)]);
                if (y)
                {
                    players[x].LoseActionsPoints(1);
                }
            }

            public void DealHand(int x, bool y = false)
            {
                for (int i = 0; i > 5; i++)
                {
                    DrawACard(x, y);
                }
                if (!y)
                {
                    players[x].LoseActionsPoints(3);
                }
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void PlayerDiscardButton_Click(object sender, EventArgs e)
        {

        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {

        }
    }
}
