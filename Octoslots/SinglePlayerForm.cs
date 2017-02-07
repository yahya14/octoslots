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
        public static bool canPoke;
        public static bool[] singlePlayer = new bool[4];


        public SinglePlayerForm()
        {
            InitializeComponent();
            Gecko = Form1.Gecko;
            octodiff = Form1.octodiff;
            singlePlayer[0] = true;
        }

        public bool CheckBoxChecked
        {
            get { return singlePlayerCheck.Checked; }
            set { singlePlayerCheck.Checked = value; }
        }

        public static void singlePlayerPoke()
        {
            uint all = 0;
            uint inkling = 0;

            for (uint i = 0; i < 3; i++)
            {
                //pokes all cpus to the inkling girl gender
                if (singlePlayer[0])
                    Gecko.poke(0x12D1F460 + octodiff + (i * 0xFC), 0);
                //pokes all cpus to all genders
                else if (singlePlayer[1])
                    Gecko.poke(0x12D1F460 + octodiff + (i * 0xFC), all);
                //pokes all cpus to the inkling boy gender
                else if (singlePlayer[2])
                    Gecko.poke(0x12D1F460 + octodiff + (i * 0xFC), 0x1);

                //pokes all cpus to both inkling genders only
                else if (singlePlayer[3])
                    Gecko.poke(0x12D1F460 + octodiff + (i * 0xFC), inkling);

                //for all gender function
                all++;
                //for inkling cpus function
                if (inkling == 0 || inkling == 1)
                    inkling = 1;
                else
                    inkling = 0;

            }
        }

        private void radioInklingGirl_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInklingGirl.Checked == true)
                singlePlayer[0] = true;
            else
                singlePlayer[0] = false;
            
        }

        private void radioAllGenders_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAllGenders.Checked == true)
                singlePlayer[1] = true;
            else
                singlePlayer[1] = false;
        }

        private void radioInklingBoy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInklingBoy.Checked == true)
                singlePlayer[2] = true;
            else
                singlePlayer[2] = false;
        }

        private void radioInklingsOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInklingsOnly.Checked == true)
                singlePlayer[3] = true;
            else
                singlePlayer[3] = false;
        }

        private void singlePlayerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (singlePlayerCheck.Checked == true)
            {
                singlePlayerGroup.Enabled = true;
                canPoke = true;
            }
            else if (singlePlayerCheck.Checked == false)
            {
                
                canPoke = false;
                singlePlayerGroup.Enabled = false;
            }
            else
                singlePlayerGroup.Enabled = false;
                
        }

        private void SinglePlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            singlePlayerGroup.Enabled = false;
            canPoke = false;
        }
    }
}
