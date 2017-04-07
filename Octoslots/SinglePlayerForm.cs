using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Octoslots
{
    public partial class SinglePlayerForm : Form
    {
        private static TCPGecko Gecko;
        public static uint octodiff;
        public static bool SPPoke;
        public static bool[] SPchoice = new bool[4];
        public static string[][] SPOctoSlot = new string[4][]
        {
            new string[5] {"Default", "Hero Shot", "Hero Suit Headgear", "Hero Suit", "Hero Shoes" }, //Player 1 (main player)
            new string[5] {"Octoling", "Octoshot", "Octoling Goggles", "Octoling Armor", "Octoling Boots" }, //Player 2 (octoling 1)
            new string[5] {"Octoling", "Octoshot", "Octoling Goggles", "Octoling Armor", "Octoling Boots" }, //Player 3 (octoling 2)
            new string[5] {"Octoling", "Octoshot", "Octoling Goggles", "Octoling Armor", "Octoling Boots" }  //Player 4 (octoling 3)
        };

        public SinglePlayerForm()
        {
            InitializeComponent();
            Gecko = Main.Gecko;
            SPPoke = true;

            //loads combo boxes upon opening
            CBOctoSlot0Gender.Text = SPOctoSlot[0][0];
            CBOctoSlot0Weapon.Text = SPOctoSlot[0][1];
            CBOctoSlot0Head.Text = SPOctoSlot[0][2];
            CBOctoSlot0Clothes.Text = SPOctoSlot[0][3];
            CBOctoSlot0Shoes.Text = SPOctoSlot[0][4];

            CBOctoSlot1Gender.Text = SPOctoSlot[1][0];
            CBOctoSlot1Weapon.Text = SPOctoSlot[1][1];
            CBOctoSlot1Head.Text = SPOctoSlot[1][2];
            CBOctoSlot1Clothes.Text = SPOctoSlot[1][3];
            CBOctoSlot1Shoes.Text = SPOctoSlot[1][4];

            CBOctoSlot2Gender.Text = SPOctoSlot[2][0];
            CBOctoSlot2Weapon.Text = SPOctoSlot[2][1];
            CBOctoSlot2Head.Text = SPOctoSlot[2][2];
            CBOctoSlot2Clothes.Text = SPOctoSlot[2][3];
            CBOctoSlot2Shoes.Text = SPOctoSlot[2][4];

            CBOctoSlot3Gender.Text = SPOctoSlot[3][0];
            CBOctoSlot3Weapon.Text = SPOctoSlot[3][1];
            CBOctoSlot3Head.Text = SPOctoSlot[3][2];
            CBOctoSlot3Clothes.Text = SPOctoSlot[3][3];
            CBOctoSlot3Shoes.Text = SPOctoSlot[3][4];
        }

        private void SinglePlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tabGearAndWeapons.Enabled = false;
            SPPoke = false;
        }

        ////Player 1
        private void comboBoxPlayerGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[0][0] = CBOctoSlot0Gender.Text;
        }

        private void comboBoxPlayerWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[0][1] = CBOctoSlot0Weapon.Text;
        }

        private void comboBoxPlayerHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[0][2] = CBOctoSlot0Head.Text;
        }

        private void comboBoxPlayerClothes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[0][3] = CBOctoSlot0Clothes.Text;
        }

        private void comboBoxPlayerShoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[0][4] = CBOctoSlot0Shoes.Text;
        }

        ////Player 2
        private void comboBoxOctoGender1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[1][0] = CBOctoSlot1Gender.Text;
        }

        private void comboBoxOctoWeapon1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[1][1] = CBOctoSlot1Weapon.Text;
        }

        private void comboBoxOctoHead1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[1][2] = CBOctoSlot1Head.Text;
        }

        private void comboBoxOctoClothes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[1][3] = CBOctoSlot1Clothes.Text;
        }

        private void comboBoxOctoShoes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[1][4] = CBOctoSlot1Shoes.Text;
        }

        ////Player 3
        private void comboBoxOctoGender2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[2][0] = CBOctoSlot2Gender.Text;
        }

        private void comboBoxOctoWeapon2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[2][1] = CBOctoSlot2Weapon.Text;
        }

        private void comboBoxOctoHead2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[2][2] = CBOctoSlot2Head.Text;
        }

        private void comboBoxOctoClothes2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[2][3] = CBOctoSlot2Clothes.Text;
        }

        private void comboBoxOctoShoes2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[2][4] = CBOctoSlot2Shoes.Text;
        }

        ////Player 4
        private void comboBoxOctoGender3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[3][0] = CBOctoSlot3Gender.Text;
        }

        private void comboBoxOctoWeapon3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[3][1] = CBOctoSlot3Weapon.Text;
        }

        private void comboBoxOctoHead3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[3][2] = CBOctoSlot3Head.Text;
        }

        private void comboBoxOctoClothes3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[3][3] = CBOctoSlot3Clothes.Text;
        }

        private void comboBoxOctoShoes3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPOctoSlot[3][4] = CBOctoSlot3Shoes.Text;
        }
    }
}
