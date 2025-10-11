using Microsoft.Data.SqlClient;
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
using static HereToSlayImplementation.Form3;

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
            Form1.Player[] players = new Form1.Player[2];
            discard = Form3.instance3.PlayerDiscardButton;
            players[0] = Form1.instance1.thisPlayer;
            thisPlayer = 0;


            for (int i = 0; i < 1; i++)
            {

                if (i != Form1.instance1.thisPlayer.GetPlayerNumber())
                {
                    SqlCommand command = new SqlCommand($"SELECT playerID, UserName FROM Player, Games WHERE Games.GameID = Player.GameIDfk AND Games.PlayerID{i} = Player.playerID", sqlConnection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.GetString(1) != null)
                        {
                            players[1] = new Form1.Player(reader.GetString(1), reader.GetInt32(0));
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            sqlConnection.Close();
            game = new Game(players);
            game.DealHand(thisPlayer);

        }

        public class Card : Button
        {
            protected string cardName;
            protected Game game;
            private int CardID;
            private int DamageSymbols;
            private int HealthSymbols;
            private int LightningSymbols;
            private int DrawSymbols;
            public Card(Form3.Game game = null, int ds = 0, int hs = 0, int ls = 0, int drs = 0)
            {
                this.cardName = cardName;
                Size = new Size(281, 422);
                this.game = game;
                DamageSymbols = ds;
                HealthSymbols = hs;
                LightningSymbols = ls;
                DrawSymbols = drs;
            }

            public string GetCardName()
            {
                return cardName;
            }
            public int DealDamage()
            {
                game.GetPlayer(1).SetHealth(HealthSymbols);
                return DamageSymbols;
            }

            public int DrawCard()
            {
                for (int i = 0; i < DrawSymbols; i++)
                {
                    game.DrawACard(0);
                }
                return DrawSymbols;
            }




            public virtual void playCard()
            {

            }

            public void DestroyCard(Card c)
            {
                c.Location = new Point(307, 620);
                game.discardAcard(c);
                c.Hide();
            }
        }

        public class Game
        {
            private Form1.Player[] players;
            private List<Card> Discard;
            private List<Card> Deck1;
            private List<Card> Deck0;
            private List<List<Card>> ListOfDecks;

            public Game(Form1.Player[] p)
            {
                players = p;
                Discard = new List<Card>();
                Deck1 = new List<Card>();
                Deck0 = new List<Card>();
                ListOfDecks = new List<List<Card>>();
                ListOfDecks.Add(Deck0);
                ListOfDecks.Add(Deck1);
                buildDeck();
            }

            public void buildDeck()
            {
                ListOfDecks[0].Add(new Card(this, 2));
            }

            public Form1.Player GetPlayer(int x)
            {
                return players[x];
            }

            public void discardAcard(Card card)
            {
                Discard.Add(card);
            }

            public void DrawACard(int x)
            {
                Random rnd = new Random();

                int index = rnd.Next(ListOfDecks[x].Count - 1);
                (ListOfDecks[x])[index].Location = new Point(537 + (players[x].GetHand().Count * 30), 620);
                (ListOfDecks[x])[index].BringToFront();
                instance3.Controls.Add((ListOfDecks[x])[index]);
                
                players[x].AddCardToHand((ListOfDecks[x])[index]);
                

            }

            public void DealHand(int x, bool y = false)
            {
                for (int i = 0; i < 3; i++)
                {
                    DrawACard(x);
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

        private void PlayerDeckButton_Click(object sender, EventArgs e)
        {
            game.DrawACard(thisPlayer);
        }
    }
}
