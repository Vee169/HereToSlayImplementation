using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
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
        public static string CONNECT = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"M:\\Visual Studio 2022\\MyCode\\NeaWork\\HereToSlayImplementation\\HereToSlayImplementation\\obj\\HereToSlayDatabase.mdf\"; Integrated Security=True;Connect Timeout=30";
        public Game game;
        public int thisPlayer;
        Button selectedButton;
        //public Point discard = Form3.instance3.DiscardButton.Location;
        public Form3()
        {
            instance3 = this;

            InitializeComponent();
            new Form4().Show();
            sqlConnection = new SqlConnection(CONNECT);
            sqlConnection.Open();
            Form1.Player[] players = new Form1.Player[6];


            for (int i = 1; i < 7; i++)
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

        public bool AttackMonster(MonsterCard mc)
        {
            Form1.Player player = game.GetPlayer(thisPlayer);
            if (mc.GetClassRequirment() == HeroClass.no)
            {
                int count = 0;
                foreach (Form1.Card c in player.GetParty())
                {
                    if (c != null)
                    {
                        count++;
                    }
                }
                if (count >= mc.GetPartySizeRequirment())
                {
                    int roll = game.rollDice();
                    if (roll > mc.GetKillRequirment())
                    {
                        player.KilledMonster(mc);
                    }
                }
            }
            return false;
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
            private List<MonsterCard> MonsterDeck;

            public Game(Form1.Player[] p)
            {
                players = p;
                Discard = new List<Form1.Card>();
                Deck = new List<Form1.Card>();
                MonsterDeck = new List<MonsterCard>();
            }

            public Form1.Player GetPlayer(int x)
            {
                return players[x];
            }

            public MonsterCard GetMonsterCard()
            {
                Random rnd = new Random();
                MonsterCard mc = MonsterDeck[rnd.Next(0, MonsterDeck.Count)];
                MonsterDeck.Remove(mc);
                return mc;
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

            public int rollDice()
            {
                Random rnd = new Random();
                return rnd.Next(1, 6) + rnd.Next(1, 6);
            }
        }

        public class HeroCard : Form1.Card
        {
            private HeroClass Class;
            private int _requiredroll;
            private int RequiredRoll
            {
                get { return _requiredroll; }
                set
                {
                    if (value > 12)
                    {
                        _requiredroll = 12;
                    }
                    else if (value < 0)
                    {
                        _requiredroll = 0;
                    }
                    else
                    {
                        _requiredroll = value;
                    }
                }
            }
            private bool affectsPlayer;
            private bool steal;
            private bool affectsCards;
            private bool affectsDice;
            private int affectedNumber;
            private string otherEffect;

            public HeroCard(string Name, Game g, HeroClass heroClass, int r, bool ap, bool s, bool ac, bool ad, int an, string oe, int c) : base(c, Name, g)
            {
                Class = heroClass;
                RequiredRoll = r;
                affectsPlayer = ap;
                steal = s;
                affectsCards = ac;
                affectsDice = ad;
                affectedNumber = an;
                otherEffect = oe;
                game = g;
            }

            public override void playCard()
            {
                this.Location = Form3.instance3.selectedButton.Location;
                int diceroll = game.rollDice();
                if (diceroll >= RequiredRoll)
                {

                }
            }
        }

        public class ItemCard : Form1.Card
        {
            private string effect;
            public ItemCard(string Name, string e, int c) : base(c, Name)
            {
                effect = e;
            }
        }

        public class ItemHeroPair : Form1.Card
        {
            private HeroCard hero;
            private ItemCard item;
            public ItemHeroPair(HeroCard h, ItemCard i, int c) : base(c)
            {
                hero = h;
                item = i;
                Name = h.GetCardName() + " with " + i.GetCardName();
            }

            public override void playCard()
            {
                hero.playCard();
            }
        }

        public class MagicCard : Form1.Card
        {
            private string effect;
            public MagicCard(string Name, string e, int c) : base(c, Name)
            {
                effect = e;
            }
        }

        public class ReactionCard : Form1.Card
        {
            public ReactionCard(string Name, int c) : base(c, Name)
            {
            }
        }

        public class MonsterCard : Form1.Card
        {
            private string effect;
            private HeroClass ClassRequirment;
            private int PartySizeRequirment;
            private int ConsequenceRequirement;
            private int KillRequirement;

            public MonsterCard(string Name, string e, int cr, int kr, int psr, int c, HeroClass clr = HeroClass.no) : base(c, Name)
            {
                effect = e;
                ConsequenceRequirement = cr;
                KillRequirement = kr;
                ClassRequirment = clr;
            }

            public int GetKillRequirment()
            {
                return KillRequirement;
            }

            public HeroClass GetClassRequirment()
            {
                return ClassRequirment;
            }
            public int GetPartySizeRequirment()
            {
                return PartySizeRequirment;
            }
        }
        public class PartyLeader : Form1.Card
        {
            private string effect;
            private HeroClass HeroClass;

            public PartyLeader(string Name, string e, HeroClass hc, int c) : base(c, Name)
            {
                effect = e;
                HeroClass = hc;
                Size = new Size(379, 707);
            }
        }


        private void CardButton2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void FullDieTimer_Tick(object sender, EventArgs e)
        {
            DieTimer.Stop();
            DieTimer.Enabled = false;
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {

        }
    }
}
