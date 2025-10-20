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
        static public bool IsYourTurn;
        static public bool beenMade;
        static public bool CardSelected;
        static public bool CardPlayed;

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
            MoveRetrievalTimer.Tick += MoveRetrievalTimer_Tick;
            MoveRetrievalTimer.Start();
            DiscardTimer.Tick += DiscardTimer_Tick;
            CardSelected = false;
            this.Disposed += Form3_Disposed;
            CardPlayed = false;
            OpponentHealthTextBox.Text = "10/10";
            PlayerHealthTextBox.Text = "10/10";


            for (int i = 1; i < 3; i++)
            {

                if (i != Form1.instance1.thisPlayer.GetPlayerNumber())
                {
                    SqlCommand command = new SqlCommand($"SELECT playerID, UserName FROM Player, Games WHERE Games.GameID = Player.GameIDfk AND Games.PlayerID{i} = Player.playerID AND Games.GameID = {Form1.instance1.thisPlayer.GetGameID()}", sqlConnection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
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

            if (players[0].GetPlayerNumber() == 1)
            {
                IsYourTurn = true;
                MoveRetrievalTimer.Enabled = false;
                TurnTextBox.Text = $"It is the turn of: {players[0].GetUsername()}";
            }
            else
            {
                IsYourTurn = false;
                TurnTextBox.Text = $"It is the turn of: {players[1].GetUsername()}";
            }
            game = new Game(players);
            game.DealHand(thisPlayer);
            FocusScreen();
        }

        public void FocusScreen()
        {
            foreach (Card card in game.GetPlayer(0).GetHand())
            {
                card.BringToFront();
            }
        }

        public class Card : Button
        {
            protected string cardName;
            protected Game game;
            private int CardID;
            private string[] EffectSymbols;
            private int Damage;
            private int Defense;
            private int Healing;
            private int Draw;
            private int Lightning;
            public Card(int c, Form3.Game game = null, string ds = "", string hs = "", string ls = "", string drs = "")
            {
                this.cardName = cardName;
                Size = new Size(281, 422);
                BackColor = Color.DimGray;
                this.game = game;
                EffectSymbols = [ds, hs, ls, drs];
                Text += $"{ds}, {hs}, {ls}, {drs}";
                TextAlign = ContentAlignment.TopCenter;
                Damage = 0;
                Defense = 0;
                Healing = 0;
                Draw = 0;
                AnalyseSymbols();
                CardID = c;
                Click += Card_Click;
            }
            private void Card_Click(object sender, EventArgs e)
            {
                if (IsYourTurn)
                {
                    if (!CardSelected)
                    {
                        this.Top -= 50;
                        CardSelected = true;
                        game.SelectCard(this);
                    }
                    else
                    {
                        if (game.GetSelectedCard() == sender)
                        {
                            ((Card)sender).Location = new Point(597, 163);
                            CardPlayed = true;
                            game.playCard((Card)sender);
                        }
                        else
                        {
                            CardSelected = false;
                            game.GetSelectedCard().Top += 50;
                            this.PerformClick();
                        }
                    }
                }
            }
            private void AnalyseSymbols()
            {
                foreach (string symbol in EffectSymbols)
                {
                    switch (symbol.ToLower())
                    {
                        case "attack":
                            Damage += 1;
                            break;
                        case "defense":
                            Defense += 1;
                            break;
                        case "healing":
                            Healing += 1;
                            break;
                        case "draw":
                            Draw += 1;
                            break;

                    }
                }
            }

            public string GetCardName()
            {
                return cardName;
            }
            public int DealDamage()
            {
                game.GetPlayer(1).SetHealth(Damage);
                instance3.OpponentHealthTextBox.Text = $"10/{game.GetPlayer(1).GetHealth()}";
                return Damage;
            }

            public int DrawCard()
            {
                for (int i = 0; i < Draw; i++)
                {
                    game.DrawACard(0);
                }
                return Draw;
            }

            public int Heal()
            {
                game.GetPlayer(0).SetHealth(-Healing);
                instance3.OpponentHealthTextBox.Text = $"10/{game.GetPlayer(0).GetHealth()}";
                return Healing;
            }
            public void DoLightning()
            {
                game.GetPlayer(0).LoseActionsPoints(-Lightning);


            }

            public int Defend()
            {
                game.GetPlayer(0).SetDefence(Defense);
                return Defense;
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
            private List<Card> Discard1;
            private List<Card> Deck1;
            private string Deck1Name;
            private List<Card> Discard0;
            private List<Card> Deck0;
            private string Deck0Name;
            private List<List<Card>> ListOfDecks;
            private List<List<Card>> ListOfDiscard;
            private int gameID;
            private int damageThisTurn = 0;
            private int healthThisTurn = 0;
            private int defenseThisTurn = 0;
            private Card SelectedCard;
            public Game(Form1.Player[] p)
            {
                players = p;
                Discard0 = new List<Card>();
                Discard1 = new List<Card>();
                ListOfDiscard = new List<List<Card>>();
                ListOfDiscard.Add(Discard0);
                ListOfDiscard.Add(Discard1);
                Deck1 = new List<Card>();
                Deck0 = new List<Card>();
                ListOfDecks = new List<List<Card>>();
                ListOfDecks.Add(Deck0);
                ListOfDecks.Add(Deck1);
                buildDeck();
                gameID = players[0].GetGameID();
            }

            public int GetgameID()
            {
                return gameID;
            }

            public void Turn()
            {
                DrawACard(0);
                players[0].ResetActionsPoints();
            }

            public void SelectCard(Card card)
            {
                SelectedCard = card;

            }

            public Card GetSelectedCard()
            {
                return SelectedCard;
            }

            public void buildDeck()
            {
                sqlConnection.Open();
                for (int i = 0; i < 1; i++)
                {
                    SqlCommand cmd = new SqlCommand($"SELECT * FROM Cards WHERE Deckfk = '{players[i].GetDeck()}'", sqlConnection);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int j = 0; j < reader.GetInt32(6); j++)
                            {
                                ListOfDecks[i].Add(new Card(reader.GetInt32(0), this, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                            }
                        }
                    }
                }
                sqlConnection.Close();
                ListOfDecks[0].Add(new Card(1, this, "Damage", "Damage"));

            }

            public Form1.Player GetPlayer(int x)
            {
                return players[x];
            }

            public void discardAcard(Card card)
            {
                Discard0.Add(card);
                instance3.DiscardTimer.Enabled = true;
            }

            public void DrawACard(int x)
            {
                Random rnd = new Random();

                if(ListOfDecks[x].Count == 0)
                {
                    ListOfDecks[x] = new List<Card>(ListOfDiscard[x]);
                    ListOfDiscard[x] = new List<Card>();
                }
                int index = rnd.Next(ListOfDecks[x].Count - 1);
                (ListOfDecks[x])[index].Location = new Point(537 + (players[x].GetHand().Count * 30), 620);
                ListOfDiscard[x].Add((ListOfDecks[x])[index]);
                (ListOfDecks[x])[index].BringToFront();
                instance3.Controls.Add((ListOfDecks[x])[index]);
                players[x].AddCardToHand((ListOfDecks[x])[index]);
                ListOfDecks[x].Remove((ListOfDecks[x])[index]);


            }

            public void DealHand(int x, bool y = false)
            {
                for (int i = 0; i < 3; i++)
                {
                    DrawACard(x);
                }
            }

            public virtual void playCard(Card card)
            {
                
                GetPlayer(0).LoseActionsPoints(1);
                damageThisTurn += card.DealDamage();
                healthThisTurn += card.Heal();
                defenseThisTurn = card.Defend();
                card.DoLightning();
                if (GetPlayer(0).GetActionPoints() == 0)
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO Moves VALUES ({GetgameID()}, {damageThisTurn}, {damageThisTurn}, {defenseThisTurn}, {GetPlayer(0).GetplayerID()})", sqlConnection);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    IsYourTurn = false;
                    Form3.instance3.MoveRetrievalTimer.Enabled = true;
                    Form3.instance3.TurnTextBox.Text = "It is the turn of:";
                    Form3.instance3.TurnTextBox.Text += players[1].GetUsername();
                    card.Location = new Point(302, 619);
                    Form3.instance3.DiscardTimer.Enabled = true;
                    Console.WriteLine("card drawn");
                }
                else
                {
                    playCard(card);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }



        private void PlayerDiscardButton_Click(object sender, EventArgs e)
        {
        }


        private void PlayerDeckButton_Click(object sender, EventArgs e)
        {
        }

        private void MoveRetrievalTimer_Tick(object sender, EventArgs e)
        {
            if (!IsYourTurn)
            {
                bool turnChange = false;
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Moves WHERE GameIDfk = {game.GetgameID()} AND PlayerIDfk = {game.GetPlayer(1).GetplayerID()}", sqlConnection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        game.GetPlayer(0).SetDefence(-reader.GetInt32(2));
                        game.GetPlayer(1).SetHealth(-reader.GetInt32(3));
                        game.GetPlayer(1).SetDefence(reader.GetInt32(4));
                        turnChange = true;
                    }
                }
                if (turnChange)
                {
                    SqlCommand cmd2 = new SqlCommand($"DELETE FROM Moves WHERE GameIDfk = {game.GetgameID()}", sqlConnection);
                    cmd2.ExecuteNonQuery();
                    MoveRetrievalTimer.Enabled = false;
                    TurnTextBox.Text = $"It is the turn of: {game.GetPlayer(0).GetUsername()}";
                    IsYourTurn = true;
                    game.Turn();
                }
                sqlConnection.Close();
            }

        }

        private void Form3_Disposed(object sender, EventArgs e)
        {
            Form1.instance1.Dispose();
        }

        private void DiscardTimer_Tick(object sender, EventArgs e)
        {
            game.GetSelectedCard().Dispose();
            DiscardTimer.Enabled = false;
        }
    }
}
