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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void DrawTestButton_Click(object sender, EventArgs e)
        {
            Form3.instance3.game.DrawACard(Form3.instance3.thisPlayer);
        }
    }
}
