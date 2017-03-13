using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octoslots
{
    public partial class SinglePlayerForm : Form
    {
        private static TCPGecko Gecko;
        public static uint octodiff;
        public static bool SPPoke;
        public static bool SPGearPoke;
        public static bool[] SPchoice = new bool[4];
        

        public SinglePlayerForm()
        {
            InitializeComponent();
            Gecko = Form1.Gecko;
            SPchoice[0] = true;
        }

        public bool CheckBoxChecked
        {
            get { return singlePlayerCheck.Checked; }
            set { singlePlayerCheck.Checked = value; }
        }

        private void radioInklingGirl_CheckedChanged(object sender, EventArgs e)
        {
            SPchoice[0] = radioInklingGirl.Checked;
        }

        private void radioAllGenders_CheckedChanged(object sender, EventArgs e)
        {
            SPchoice[1] = radioInklingGirl.Checked;
        }

        private void radioInklingBoy_CheckedChanged(object sender, EventArgs e)
        {
            SPchoice[2] = radioInklingGirl.Checked;
        }

        private void radioInklingsOnly_CheckedChanged(object sender, EventArgs e)
        {
            SPchoice[3] = radioInklingGirl.Checked;
        }

        private void singlePlayerCheck_CheckedChanged(object sender, EventArgs e)
        {
            singlePlayerGroup.Enabled = singlePlayerCheck.Checked;
            SPPoke = singlePlayerCheck.Checked;
        }

        private void playerOctogearCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SPGearPoke = playerOctogearCheckbox.Checked;
        }

        private void SinglePlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            singlePlayerGroup.Enabled = false;
            SPPoke = false;
        }
    }
}
