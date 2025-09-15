using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HereToSlayImplementation
{
    public partial class Form3 : Form
    {
        static public Form3 instance;
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


        private void CardButton2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
