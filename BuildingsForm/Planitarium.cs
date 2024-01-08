using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmStarategy
{
    public partial class Planitarium : Form
    {
        public Planitarium()
        {
            InitializeComponent();
            ElipseButton.MakeButtonRound(buttonTayplin);
            ElipseButton.MakeButtonRound(buttonAndromeda);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTayplin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tayplin tayplin = new Tayplin();
            tayplin.Show();
        }

        private void buttonAndromeda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Andromeda andromeda = new Andromeda();
            andromeda.Show();
        }
    }
}
