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
                    SqlCommand command = new SqlCommand($"SELECT playerID, UserName, DeckID FROM Player, Games WHERE Games.GameID = Player.GameIDfk AND Games.PlayerID{i} = Player.playerID AND Games.GameID = {Form1.instance1.thisPlayer.GetGameID()}", sqlConnection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            players[1] = new Form1.Player(reader.GetString(1), reader.GetInt32(0), reader.GetString(2));
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
        int count = 0;
        public void FocusScreen()
        {
            foreach (Card card in game.GetPlayer(0).GetHand())
            {
                card.BringToFront();
                //card.Location = new Point(418 + (count * 30), 371);
                count++;
            }
        }

        public class Card : Button
        {
            protected string cardName;
            private string Deck;
            protected Game game;
            private int CardID;
            private string[] EffectSymbols;
            private int Damage;
            private int Defense;
            private int Healing;
            private int Draw;
            private int Lightning;
            private int us1;
            private int us2;
            private int us3;
            public Card(int c, string deck, Form3.Game game = null, string ds = "", string hs = "", string ls = "", string drs = "")
            {
                this.cardName = cardName;
                Size = new Size(197, 253);
                BackColor = Color.DimGray;
                this.game = game;
                EffectSymbols = [ds, hs, ls, drs];
                Text += $"{ds}, {hs}, {ls}, {drs}";
                TextAlign = ContentAlignment.TopCenter;
                Damage = 0;
                Defense = 0;
                Healing = 0;
                Draw = 0;
                us1 = 0;
                us2 = 0;
                us3 = 0;
                AnalyseSymbols();
                CardID = c;
                Click += Card_Click;
                Deck = deck;
            }
            private void Card_Click(object sender, EventArgs e)
            {
                if (!CardSelected)
                {
                    this.Top -= 50;
                    CardSelected = true;
                    game.SelectCard(this);
                }
                else if(IsYourTurn)
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
            private void AnalyseSymbols()
            {
                foreach (string symbol in EffectSymbols)
                {
                    switch (symbol.ToLower())
                    {
                        case "damage":
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
                        case "lightning":
                            Lightning += 1;
                            break;
                        case "us1":
                            us1 += 1;
                            break;
                        case "us2":
                            us2 += 1;
                            break;
                        case "us3":
                            us3 += 1;
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

                game.GetPlayer(1).SetDefence(-Damage);

                instance3.OpponentHealthTextBox.Text = $"{game.GetPlayer(1).GetHealth()}/10";
                if (game.GetPlayer(1).GetDefense() >= 0)
                {
                    instance3.OpponentDefenceTextBox.Text = $" + {game.GetPlayer(1).GetDefense()}";
                }
                return Damage;
            }

            public int DrawCard()
            {
                Console.WriteLine("Draw");
                for (int i = 0; i < Draw; i++)
                {
                    game.DrawACard(0);
                }
                return Draw;
            }

            public int Heal()
            {
                game.GetPlayer(0).SetHealth(-Healing);
                instance3.OpponentHealthTextBox.Text = $"{game.GetPlayer(0).GetHealth()}/10";
                if (game.GetPlayer(1).GetDefense() >= 0)
                {
                    instance3.OpponentDefenceTextBox.Text = $" + {game.GetPlayer(1).GetDefense()}";
                }
                return Healing;
            }
            public void DoLightning()
            {
                game.GetPlayer(0).LoseActionsPoints(-Lightning);
                Lightning = 0;

            }

            public int Defend()
            {
                game.GetPlayer(0).SetDefence(Defense);
                if (game.GetPlayer(0).GetDefense() >= 0)
                {
                    instance3.PlayerDefenceTextBox.Text = $" + {game.GetPlayer(0).GetDefense()}";
                }
                return Defense;
            }

            public void uniqueSymbol1()
            {
                for (int i = 0; i < us1; i++)
                {
                    switch (Deck)
                    {
                        case "minsc & boo":
                            int healthStore = game.GetPlayer(1).GetHealth();
                            game.GetPlayer(1).NewHealth(game.GetPlayer(0).GetHealth());
                            game.GetPlayer(0).NewHealth(healthStore);
                            break;
                    }
                }
            }

            public void uniqueSymbol2()
            {
                for (int i = 0; i < us2; i++)
                {
                    switch (Deck)
                    {
                        case "minsc & boo":
                            game.DrawACard(1);
                            break;
                    }
                }
            }

            public void uniqueSymbol3()
            {
                for (int i = 0; i < us3; i++)
                {
                    switch (Deck)
                    {
                        case "minsc & boo":
                            game.SetBonusDamage(1);
                            break;
                    }
                }
            }

            public void DestroyCard(Card c)
            {
                c.Location = new Point(307, 620);
                game.discardAcard(c);
                c.Hide();
            }

            public int GetCardID()
            {
                return CardID;
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
            private int BonusDamage;
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
                BonusDamage = 0;
            }

            public int GetgameID()
            {
                return gameID;
            }

            public List<Card> GetDeck(int x) 
            {
                return ListOfDecks[x]; 
            }

            public void SetBonusDamage(int x)
            {
                BonusDamage += x;
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
                for (int i = 0; i < 2; i++)
                {
                    SqlCommand cmd = new SqlCommand($"SELECT * FROM Cards WHERE Deckfk = '{players[i].GetDeck()}'", sqlConnection);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int j = 0; j < reader.GetInt32(6); j++)
                            {
                                ListOfDecks[i].Add(new Card(reader.GetInt32(0), reader.GetString(5), this, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                            }
                        }
                    }
                }
                sqlConnection.Close();
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

            public void DrawACard(int x, int y = 0)
            {
                Random rnd = new Random();

                if (ListOfDecks[x].Count == 0)
                {
                    ListOfDecks[x] = new List<Card>(ListOfDiscard[x]);
                    ListOfDiscard[x] = new List<Card>();
                }
                int index = rnd.Next(ListOfDecks[x].Count - 1);
                (ListOfDecks[x])[index].Location = new Point(418 + (players[y].GetHand().Count * 30), 371);
                ListOfDiscard[x].Add((ListOfDecks[x])[index]);
                (ListOfDecks[x])[index].BringToFront();
                instance3.Controls.Add((ListOfDecks[x])[index]);
                players[y].AddCardToHand((ListOfDecks[x])[index]);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO Hand VALUES ({players[y].GetplayerID()}, {ListOfDecks[x][index].GetCardID()})", sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
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
                damageThisTurn += (card.DealDamage() + BonusDamage);
                healthThisTurn += card.Heal();
                defenseThisTurn = card.Defend();
                card.DrawCard();
                card.uniqueSymbol1();
                card.uniqueSymbol2();
                card.uniqueSymbol3();
                card.DoLightning();
                if (GetPlayer(0).GetActionPoints() == 0)
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO Moves VALUES ({GetgameID()}, {damageThisTurn}, {damageThisTurn}, {defenseThisTurn}, {GetPlayer(0).GetplayerID()})", sqlConnection);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    Form3.instance3.OpponentHealthTextBox.Text = $"{players[1].GetHealth()}/10";
                    if (players[1].GetDefense() >= 0)
                    {
                        instance3.OpponentDefenceTextBox.Text = $" + {players[1].GetDefense()}";
                    }
                    IsYourTurn = false;
                    Form3.instance3.MoveRetrievalTimer.Enabled = true;
                    Form3.instance3.TurnTextBox.Text = "It is the turn of:";
                    Form3.instance3.TurnTextBox.Text += players[1].GetUsername();
                    BonusDamage = 0;

                }
                else if((GetPlayer(0).GetActionPoints() > 0) && (GetPlayer(0).GetHand().Count == 0))
                {
                    DealHand(0);
                }
                card.Location = new Point(211, 371);
                Form3.instance3.DiscardTimer.Enabled = true;
                Console.WriteLine("card played");
                Form3.instance3.FocusScreen();
                GetPlayer(0).RemoveFromHand(card);
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
                        Form3.instance3.PlayerHealthTextBox.Text = $"10/{game.GetPlayer(0).GetHealth()}";
                        if (game.GetPlayer(0).GetDefense() >= 0)
                        {
                            instance3.OpponentDefenceTextBox.Text = $" + {game.GetPlayer(0).GetDefense()}";
                        }
                        game.GetPlayer(1).SetHealth(-reader.GetInt32(3));
                        game.GetPlayer(1).SetDefence(reader.GetInt32(4));
                        turnChange = true;
                    }
                }
                List<Card> Hand;
                List<Card> Deck1 = game.GetDeck(0);
                List<Card> Deck2 = game.GetDeck(1);
                bool cardAdded = false;
                for (int i = 0; i < 2; i++)
                {
                    Hand = new List<Card>();
                    SqlCommand cmd3 = new SqlCommand($"SELECT * FROM Hand WHERE PlayerIDfk = {game.GetPlayer(i).GetplayerID()}", sqlConnection);
                    using (SqlDataReader reader = cmd3.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            foreach (Card card in Deck2)
                            {
                                if (reader.GetInt32(1) == card.GetCardID())
                                {
                                    Hand.Add(card);
                                    cardAdded = true;
                                    break;
                                }
                            }

                            if (cardAdded)
                            {
                                cardAdded = false;
                            }
                            else
                            {
                                foreach (Card card in Deck1)
                                {
                                    if (reader.GetInt32(1) == card.GetCardID())
                                    {
                                        Hand.Add(card);
                                        break;
                                    }
                                }
                            }

                        }
                    }
                    game.GetPlayer(i).SetHand(Hand);
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
