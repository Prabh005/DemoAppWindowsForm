using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DemoAppWindowsForm
{
    public partial class BtnRanNum : Form
    {
        public BtnRanNum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int n = num.Next();
            lblRanNum1.Text = "Random Number " + n;

        }

        private void pbimage_Click(object sender, EventArgs e)
        {
            PBPimg.Image = global::DemoAppWindowsForm.Properties.Resources.gg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(DemoAppWindowsForm.Properties.Resources.shotgun_spas_12_RA_The_Sun_God_503834910__2_);
            player.Load();
            player.Play();
        }
    }
}
