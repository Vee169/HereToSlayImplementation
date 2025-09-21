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

namespace HereToSlayImplementation
{
    public partial class Form3 : Form
    {
        static public Form3 instance;
        public System.Windows.Forms.Timer timer;
        public Form3()
        {
            instance = this;

            InitializeComponent();
        }

        public enum HeroClass
        {
            wizard,
            thief,
            guardian,
            fighter,
            ranger,
            bard
        }

        public static int RollDie()
        {
            Random rand = new Random();

            return rand.Next(1, 7) + rand.Next(1, 7);
        }

        public class Game
        {
            private Form1.Player player1;
            private Form1.Player player2;
            private Form1.Player player3;
            private Form1.Player player4;
            private Form1.Player player5;
            private Form1.Player player6;
            private List<Form1.Card> Discard;
            private List<Form1.Card> Deck;

            public Game(Form1.Player player1, Form1.Player player2, List<Form1.Card> discard, List<Form1.Card> deck,  Form1.Player player3 = null, Form1.Player player4 = null, Form1.Player player5 = null, Form1.Player player6 = null)
            {
                this.player1 = player1;
                this.player2 = player2;
                this.player3 = player3;
                this.player4 = player4;
                this.player5 = player5;
                this.player6 = player6;
                Discard = discard;
                Deck = deck;
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

            public HeroCard(string Name, HeroClass heroClass, int r, bool ap, bool s, bool ac, bool ad, int an, string oe) : base(Name)
            {
                Class = heroClass;
                RequiredRoll = r;
                affectsPlayer = ap;
                steal = s;
                affectsCards = ac;
                affectsDice = ad;
                affectedNumber = an;
                otherEffect = oe;
            }


        }

        public class ItemCard : Form1.Card
        {
            private string effect;
            public ItemCard(string Name, string e) : base(Name)
            {
                effect = e;
            }
        }

        public class ItemHeroPair : Form1.Card
        {
            private HeroCard hero;
            private ItemCard item;
            public ItemHeroPair(HeroCard h, ItemCard i)
            {
                hero = h;
                item = i;
                Name = h.GetCardName() + " with " + i.GetCardName();
            }
        }

        public class MagicCard : Form1.Card
        {
            private string effect;
            public MagicCard(string Name, string e) : base(Name)
            {
                effect = e;
            }
        }

        public class ReactionCard : Form1.Card
        {
            public ReactionCard(string Name) : base(Name)
            {
            }
        }

        public class MonsterCard : Form1.Card
        {
            private string effect;
            private int ConsequenceRequirement;
            private int KillRequirement;

            public MonsterCard(string Name, string e, int cr, int kr) : base(Name)
            {
                effect = e;
                ConsequenceRequirement = cr;
                KillRequirement = kr;
            }
        }
        public class PartyLeader : Form1.Card
        {
            private string effect;
            private HeroClass HeroClass;
            
            public PartyLeader(string Name, string e, HeroClass hc) : base(Name)
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
    }
}
