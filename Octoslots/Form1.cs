﻿using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Linq;
using System.Threading;

namespace Octoslots
{
    public partial class Form1 : Form
    {
        private void ICCheckBox()
        {

            //fixes transparecy for the checkbox backgrounds on the interface
            checkBoxP1.Parent = playerPicBox;
            checkBoxP1.BackColor = Color.Transparent;
            checkBoxP1.Location = new Point(checkBoxP1.Location.X - 8, checkBoxP1.Location.Y - 138);
            checkBoxP1.Font = FontConfig.paint;

            checkBoxP2.Parent = playerPicBox;
            checkBoxP2.BackColor = Color.Transparent;
            checkBoxP2.Location = new Point(checkBoxP2.Location.X - 8, checkBoxP2.Location.Y - 138);
            checkBoxP2.Font = FontConfig.paint;

            checkBoxP3.Parent = playerPicBox;
            checkBoxP3.BackColor = Color.Transparent;
            checkBoxP3.Location = new Point(checkBoxP3.Location.X - 8, checkBoxP3.Location.Y - 138);
            checkBoxP3.Font = FontConfig.paint;

            checkBoxP4.Parent = playerPicBox;
            checkBoxP4.BackColor = Color.Transparent;
            checkBoxP4.Location = new Point(checkBoxP4.Location.X - 8, checkBoxP4.Location.Y - 138);
            checkBoxP4.Font = FontConfig.paint;

            checkBoxP5.Parent = playerPicBox;
            checkBoxP5.BackColor = Color.Transparent;
            checkBoxP5.Location = new Point(checkBoxP5.Location.X - 8, checkBoxP5.Location.Y - 138);
            checkBoxP5.Font = FontConfig.paint;

            checkBoxP6.Parent = playerPicBox;
            checkBoxP6.BackColor = Color.Transparent;
            checkBoxP6.Location = new Point(checkBoxP6.Location.X - 8, checkBoxP6.Location.Y - 138);
            checkBoxP6.Font = FontConfig.paint;

            checkBoxP7.Parent = playerPicBox;
            checkBoxP7.BackColor = Color.Transparent;
            checkBoxP7.Location = new Point(checkBoxP7.Location.X - 8, checkBoxP7.Location.Y - 138);
            checkBoxP7.Font = FontConfig.paint;

            checkBoxP8.Parent = playerPicBox;
            checkBoxP8.BackColor = Color.Transparent;
            checkBoxP8.Location = new Point(checkBoxP8.Location.X - 8, checkBoxP8.Location.Y - 138);
            checkBoxP8.Font = FontConfig.paint;
        }

        public Form1()
        {
            InitializeComponent();
            FontConfig.PaintballFont();
            ICCheckBox();
        }

        public static TCPGecko Gecko;
        public bool sendStats = false;
        public bool canName = false;
        public uint diff, diff2;
        public uint octodiff;
        public uint SquadAddrs;
        public bool combineToggle;
        public uint delayRead = 1337;
        public uint mainNameDelay = 1337;
        public uint SquadAddr, OnlineAddr, PBAddr, FestAddr;
        public byte[] miiName;

        // auto refresh tied to the checkboxes (1st player to 8th player)
        public static bool[] autoRefresh = new bool[8];
        public static byte[][] name = new byte[8][];
        public static uint[] menuCheck = new uint[4];


        private void Form1_Load(object sender, EventArgs e)
        {
            Configuration.Load();
            ipBox.Text = Configuration.currentConfig.lastIp;
            this.Text += " (" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + ")";

            //un-nullify names array
            for (int i = 0; i < 8; i++)
                name[i] = new byte[0];

            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //checks program update
            Checker check = new Checker();
            new Thread(() => {
                Thread.Sleep(200);
                check.checkUpdate();

                Invoke(new MethodInvoker(Check));
                }).Start();
        }

        private void Check()
        {
            Checker check = new Checker();
            if (Checker.ver > check.getAssembly())
                check.ShowDialog(this);
        }

        private void writeString(uint address, string s)
        {
            writeString(address, s, s.Length);
        }
        private void writeString(uint address, string s, int len)
        {
            byte[] b = Encoding.GetEncoding("iso-8859-1").GetBytes(s);
            using (MemoryStream stream = new MemoryStream(b))
                Gecko.Upload(address, address + (uint)len, stream);
        }

        private void IPBox_KeyDown(object sender, KeyEventArgs e) //User can press Enter to connect
        {
            if (e.KeyCode.ToString() == "Return")
                connectBox_Click(sender, e);
        }

        private void connectBox_Click(object sender, EventArgs e)
        {
            //start a TCP connection
            Gecko = new TCPGecko(ipBox.Text, 7331);
            try
            {
                Gecko.Connect();
            }
            catch (ETCPGeckoException)
            {
                MessageBox.Show(Properties.Strings.CONNECTION_FAILED_TEXT);
                return;
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show(Properties.Strings.INVALID_IP_TEXT);
                return;
            }

            //offset difference checker
            uint JRAddr = Gecko.peek(0x106E975C) + 0x92D8;
            if (Gecko.peek(JRAddr) == 0x000003F2) //loadiine & geckiine
            {
                uint diff = octodiff = JRAddr - 0x12CDADA0;
                uint diff2 = Gecko.peek(0x106EA828) - 0x332C1100;

                //if the uint becomes negative
                if (diff2 > 0x80000000)
                    diff2 = (0xFFFFFFFF - diff2) + 1;

                //base addresses
                SquadAddr = 0x1D9B1C2C + diff;
                PBAddr = 0x1D9B2264 + diff;
                OnlineAddr = 0x1CAFD9E8 + diff2;
                //FestAddr = 0x1CAFD918 + diff2;
#if DEBUG
                //for debuging do not remove
                Console.WriteLine("Debugging Data (used for math):");
                Console.WriteLine("diff: " + diff.ToString("X"));
                Console.WriteLine("diff2: " + diff2.ToString("X"));
                Console.WriteLine("Online: " + OnlineAddr.ToString("X"));
                Console.WriteLine("Private: " + PBAddr.ToString("X"));
                Console.WriteLine("Squad: " + SquadAddr.ToString("X"));
                Console.WriteLine("Festi: " + FestAddr.ToString("X"));
                Console.WriteLine("Gender: " + (0x12D1F364 + octodiff).ToString("X"));
#endif
            }
            else //when the pointer fails to work
            {
                disconnectBox_Click(sender, e);
                MessageBox.Show(Properties.Strings.FIND_DIFF_FAILED_TEXT, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //save IP to xml
            Configuration.currentConfig.lastIp = ipBox.Text;
            Configuration.Save();

            //change object states
            load();

            //loads Octo sfx
            if (sfxNormalRadio.Checked)
                sfxNormalRadio_CheckedChanged(sender, e);
            else if (sfxEliteRadio.Checked)
                sfxEliteRadio_CheckedChanged(sender, e);

            //Fixes the player Octoling sfx
            writeString(0x105EC6BE, "Other", 5);

            //starts poking timer
            getNames();
            autoRefreshTimer.Start();

            //get player's mii name (WILL be used when applicable on GUI)
            miiName = yourMiiName();
        }

        public void load()
        {
            connectBox.Enabled = false;
            disconnectBox.Enabled = true;
            ipBox.Enabled = false;
            playerPicBox.Enabled = true;
            toggleGenderButton.Enabled = true;
            sfxEliteRadio.Enabled = true;
            sfxNormalRadio.Enabled = true;
            sfxCombineRadio.Enabled = true;
            singlePlayerToolStripMenuItem.Enabled = true;

            if (modeComboBox.Text != "Choose Mode (Idle)")
                mainPlayerPokeCheck.Enabled = true;
        }

        public void hold()
        {
            connectBox.Enabled = true;
            disconnectBox.Enabled = false;
            ipBox.Enabled = true;
            playerPicBox.Enabled = false;
            toggleGenderButton.Enabled = false;
            sfxEliteRadio.Enabled = false;
            sfxNormalRadio.Enabled = false;
            sfxCombineRadio.Enabled = false;
            singlePlayerToolStripMenuItem.Enabled = false;
            mainPlayerPokeCheck.Enabled = false;

            SinglePlayerForm SP = new SinglePlayerForm();
            SP.CheckBoxChecked = false;
        }

        private void disconnectBox_Click(object sender, EventArgs e)
        {
            writeString(0x105EF3B0, "Player00", 8); //reverts safe octohax
            Disconnect();
            combineToggle = false;
        }

        private void Disconnect()
        {
            //reverts Octoling sfx
            writeString(0x105EC6BE, "Ctrl", 5);
            autoRefreshTimer.Stop(); //stops poking timer
            Gecko.Disconnect();
            hold();
        }

        //TIMER FUNCTION; runs at start and stops upon disconnection
        private void autoRefreshTimer_Tick(object sender, EventArgs e)
        {
            //syncs checks with the bool array
            checkVerify();

            //reads names to display them on the gui
            getNames();

            //auto pokes main player when checked
            if (mainPlayerPokeCheck.Checked && mainPlayerPokeCheck.Enabled)
                mainNameChecker();

            //loads octohax in menus
            menuCheck[0] = Gecko.peek(0x106E093C);
            menuCheck[1] = Gecko.peek(0x10707EA0);

            if (((menuCheck[0] == 0 && menuCheck[0] != menuCheck[2])  || (menuCheck[1] != 0x3F800000 && menuCheck[1] != menuCheck[3])) && (autoRefresh[0] || autoRefresh[1]))
            {
                //for activating only when the value changes
                menuCheck[2] = menuCheck[0];
                menuCheck[3] = menuCheck[1];

                if (autoRefresh[0])
                    writeString(0x105EF3B0, "Rival00", 8); //pokes safe octohax

                autoRefresh[0] = autoRefresh[1] = false;
                Gecko.poke(0x12D1F364 + octodiff, 0x00000000); //P1
                Gecko.poke(0x12D1F460 + octodiff, 0x00000000); //P2
            }
            else if (menuCheck[0] != menuCheck[2] || menuCheck[1] != menuCheck[3])
            {
                menuCheck[2] = menuCheck[0];
                menuCheck[3] = menuCheck[1];

                writeString(0x105EF3B0, "Player00", 8); //pokes safe octohax
            }
            //switch 
            if (SinglePlayerForm.SPPoke == false)
            {
                //pokes gender 2 on checked players (main function)
                for (uint i = 0; i < 8; i++)
                    if (autoRefresh[i])
                        Gecko.poke(0x12D1F364 + octodiff + (i * 0xFC), 0x00000002);
            }
            else
            {
                //pokes single player genders for singleplayerform
                singlePlayerPoke();
            }

            //toggled combine between normal and elite octoling when checked
            if (sfxCombineRadio.Checked)
            {
                if (combineToggle)
                {
                    combineToggle = false;
                    sfxNormalRadio_CheckedChanged(sender, e);
                }
                else
                {
                    combineToggle = true;
                    sfxEliteRadio_CheckedChanged(sender, e);
                }
            }
        }

        public void getNames()
        {
            //delayed timer note: every name validated has no delay, every name failed to validate will have delay based the value of the next line.
            if (delayRead >= 1) //change the delay here
            {
                
                if (modeComboBox.Text == "Squad Battle") //broken
                {
                     nameDump(SquadAddr, 0x460, 0x9C);
                     if (!canName)
                     switchSquadAddr();
                }
                else if (modeComboBox.Text == "Private Battle") //broken
                    nameDump(PBAddr, 0x460, 0x9C);
                else if (modeComboBox.Text == "Splatfest Battle") //broken
                nameDump(FestAddr, 0x460, 0x9C);
                else if (modeComboBox.Text == "Turf/Ranked Battle")
                    nameDump(OnlineAddr, 0x460, 0x9C);
                else if (modeComboBox.Text == "Classic Offsets") //Offset names within range of 0x12.
                    nameDump(0x12D1F32E + diff, 0x704, 0xFC);
                //All broken addresses need pointers for it, which I have no possesion of yet.
            }
            else
                delayRead = delayRead >= 1? delayRead : delayRead + 1;
        }

        //DUMP
        public void nameDump(uint address, uint length, uint nameOffset)
        {
            try
            {
                //name checler
                if (!canName && modeComboBox.Text != "Classic Offsets")
                {
                    //reads the first two names for name validation
                    using (MemoryStream small = new MemoryStream())
                    {
                        uint slength = length - (nameOffset * 6);
                        uint i = 256 - (256 - slength);

                        Gecko.Dump(address, address + slength, small);

                        //define dump to byte array
                        small.Seek(0, SeekOrigin.Begin);
                        byte[] smallb = small.GetBuffer();
                        byte[] playerscheck = new byte[i];
                        Array.Copy(smallb, playerscheck, i);

                        //validates to change names on gui
                        canName = validNamesChecker(playerscheck, nameOffset);
                    }
                    delayRead = 0;

                }
                else if (modeComboBox.Text == "Classic Offsets") //Classic doesn't need checks
                    canName = true;

                //if names validation is true, all names can be read and displayed on gui
                if (canName)
                {
                    //dumps all the player names
                    using (MemoryStream mainstream = new MemoryStream())
                    {
                        uint j = 256 - (256 - length);

                        //dumps data from memory
                        Gecko.Dump(address, address + length, mainstream);

                        //define dump to byte array
                        mainstream.Seek(0, SeekOrigin.Begin);
                        byte[] b = mainstream.GetBuffer();
                        byte[] playersArray = new byte[j];
                        Array.Copy(b, playersArray, j);

                        //validates to change names on gui
                        canName = validNamesChecker(playersArray, nameOffset);

                        if (canName)
                        {
                            //organize all player names from dump array if the name is validated.
                            uint nameLength = 0;
                            uint k = 0;

                            //detects name length before a 16-bit null at every name
                            for (uint i = 0; i < length; i += nameOffset)
                            {
                                for (uint c = 0; c < 0x16; c += 2)
                                {
                                    uint l = i + c;
                                    if (playersArray[l + 8] == 0 && playersArray[l + 9] == 0)
                                    {
                                        nameLength = c;
                                        break;
                                    }
                                }

                                //clone the displayable name array before the first null byte
                                name[k] = new byte[nameLength];
                                Array.Copy(playersArray, i + 8, name[k], 0, nameLength);
                                k++;
                            }
                        }
                        //displays all names on the GUI
                        changeNames();
                    }
                    //set no loop delay with every successful read (except the 0x12 range)
                    if (modeComboBox.Text == "Classic Offsets")
                        delayRead = 0;
                    else
                        delayRead = 1337;
                }
            }
            catch (ETCPGeckoException)
            {
                Gecko.Connect();
                MessageBox.Show(Properties.Strings.ERROR, "Session Has Been Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validNamesChecker(byte[] array, uint nameOffset)
        {
            bool check = false;

            //creates a 16 bit version of the data array
            int alength = array.Length / 4;
            int[] dataCheck32 = new int[alength];
            for (int i = 0; i < alength; i++)
                dataCheck32[i] = (array[i * 4] << 24) + (array[(i * 4) + 1] << 16) + (array[(i * 4) + 2] << 8) + array[(i * 4) + 3];

            //checks if "R~4" is present in P2-P8 (unable to check P1 but it should be fine)
            uint nlength = nameOffset / 4;
            for (int i = 0; i <= (array.Length / nameOffset); i++)
            {
                int r4 = (dataCheck32[(i * nlength)]);
                if (r4 == 0x10527E34)
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }
            }

            //the 0x12 range doesn't need checks, so the check always stays true if it's selected
            if (modeComboBox.Text == "Classic Offsets")
                check = true;

            //returns the bool value depending on the bool for checking
            if (check == true)
                return true;
            else
                return false;
        }

        //CHANGE GUI NAMES
        private void changeNames()
        {
            if (modeComboBox.Text != "Classic Offsets") //prevents the first player slot to be change in Classic mode, until one of the names have changed
            {
                checkBoxP1.Text = "  " + Encoding.BigEndianUnicode.GetString(name[0]);
            }
            checkBoxP2.Text = "  " + Encoding.BigEndianUnicode.GetString(name[1]);
            checkBoxP3.Text = "  " + Encoding.BigEndianUnicode.GetString(name[2]);
            checkBoxP4.Text = "  " + Encoding.BigEndianUnicode.GetString(name[3]);
            checkBoxP5.Text = "  " + Encoding.BigEndianUnicode.GetString(name[4]);
            checkBoxP6.Text = "  " + Encoding.BigEndianUnicode.GetString(name[5]);
            checkBoxP7.Text = "  " + Encoding.BigEndianUnicode.GetString(name[6]);
            checkBoxP8.Text = "  " + Encoding.BigEndianUnicode.GetString(name[7]);
        }

        //changes the first player's name if any other player's name has changed.
        private void checkBoxAllPlayers_TextChanged(object sender, EventArgs e)
        {
            checkBoxP1.Text = "  " + Encoding.BigEndianUnicode.GetString(name[0]);
        }

        //squads have 3 address since it's dynamic (un-used)
        public void switchSquadAddr()
        {
            switch (SquadAddrs)
            {
                case 0:
                    SquadAddrs = 1;
                    SquadAddr = 0x1D9B1C34 + diff;
                    break;
                case 1:
                    SquadAddrs = 2;
                    SquadAddr = 0x1D9B13B4 + diff;
                    break;
                case 2:
                    SquadAddrs = 0;
                    SquadAddr = 0x1D9AFBB4 + diff;
                    break;
            }
        }

        //reads and returns mii name in a byte array
        public byte[] yourMiiName()
        {
            //mii name address
            uint miiAddr = Gecko.peek(0x106E975C) - 0x113A8;
            //define memory dump
            using (MemoryStream small = new MemoryStream())
            {
                uint length = 0x14;

                //dumps data from memory
                Gecko.Dump(miiAddr, miiAddr + length, small);

                //define dump to byte array
                small.Seek(0, SeekOrigin.Begin);
                byte[] b = small.GetBuffer();

                uint nameLength = 0x14;
                for (uint i = 0; i < length; i += 2)
                {
                    if (b[i] == 0 && b[i + 1] == 0)
                    {
                        nameLength = i;
                        break;
                    }
                }
                byte[] Name = new byte[nameLength];
                Array.Copy(b, Name, nameLength);

                return Name;
            }
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!connectBox.Enabled)
                autoRefreshTimer_Tick(sender, e);

            if (modeComboBox.Text == "Choose Mode (Idle)")
                mainPlayerPokeCheck.Enabled = false;
            else
                mainPlayerPokeCheck.Enabled = true;
        }

        private void mainNameChecker()
        {
            for (uint i = 0; i < 8; i++)
            {
                if (name[i].SequenceEqual(miiName) && name[i].Length == miiName.Length )
                {
                    autoRefresh[i] = true;
                    break;
                }
            }

            if (!canName)
            {
                if (mainNameDelay >= 6)
                {
                    uint address = 0x12D1F336;
                    uint length = (uint)miiName.Length;
                    MemoryStream main = new MemoryStream();
                    uint l = 256 - (256 - length);

                    //dumps data from memory
                    Gecko.Dump(address, address + length, main);

                    //define dump to byte array
                    main.Seek(0, SeekOrigin.Begin);
                    byte[] b = main.GetBuffer();
                    byte[] P1 = new byte[l];
                    Array.Copy(b, P1, l);

                    if (P1.SequenceEqual(miiName))
                        autoRefresh[0] = true;
                }

                mainNameDelay = mainNameDelay < 1337 ? mainNameDelay + 1 : mainNameDelay;
            }
            else
                mainNameDelay = 0;
        }

        private void checkVerify()
        {
            autoRefresh[0] = checkBoxP1.Checked;
            autoRefresh[1] = checkBoxP2.Checked;
            autoRefresh[2] = checkBoxP3.Checked;
            autoRefresh[3] = checkBoxP4.Checked;
            autoRefresh[4] = checkBoxP5.Checked;
            autoRefresh[5] = checkBoxP6.Checked;
            autoRefresh[5] = checkBoxP7.Checked;
            autoRefresh[7] = checkBoxP8.Checked;
        }

        //patches sound pack for normal octoling sfx
        private void sfxNormalRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (sfxNormalRadio.Checked || sfxCombineRadio.Checked)
            {
                Gecko.poke(0x39737C94, 0x616C4156);
                Gecko.poke(0x39737CA8, 0x616C4156);
                Gecko.poke(0x39737CBC, 0x616C4156);
                Gecko.poke(0x39737CD0, 0x616C4156);
                Gecko.poke(0x39737CE4, 0x76616C41);
                Gecko.poke(0x39737CFC, 0x41566F69);
                Gecko.poke(0x39737D20, 0x76616C41);
                Gecko.poke(0x39737D34, 0x6C41566F);
                Gecko.poke(0x39737D44, 0x76616C41);
                Gecko.poke(0x39737D58, 0x6C41566F);
                Gecko.poke(0x39737D68, 0x76616C41);
                Gecko.poke(0x39737D7C, 0x616C4156);
                Gecko.poke(0x39737D90, 0x6C41566F);
                Gecko.poke(0x39737DA4, 0x41566F69);
                Gecko.poke(0x39737DB4, 0x616C4156);
                Gecko.poke(0x39737DC8, 0x41566F69);
            }
        }

        //patches sound pack for elite octoling sfx
        private void sfxEliteRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (sfxEliteRadio.Checked || sfxCombineRadio.Checked)
            {
                Gecko.poke(0x39737C94, 0x616C4256);
                Gecko.poke(0x39737CA8, 0x616C4256);
                Gecko.poke(0x39737CBC, 0x616C4256);
                Gecko.poke(0x39737CD0, 0x616C4256);
                Gecko.poke(0x39737CE4, 0x76616C42);
                Gecko.poke(0x39737CFC, 0x42566F69);
                Gecko.poke(0x39737D20, 0x76616C42);
                Gecko.poke(0x39737D34, 0x6C42566F);
                Gecko.poke(0x39737D44, 0x76616C42);
                Gecko.poke(0x39737D58, 0x6C42566F);
                Gecko.poke(0x39737D68, 0x76616C42);
                Gecko.poke(0x39737D7C, 0x616C4256);
                Gecko.poke(0x39737D90, 0x6C42566F);
                Gecko.poke(0x39737DA4, 0x42566F69);
                Gecko.poke(0x39737DB4, 0x616C4256);
                Gecko.poke(0x39737DC8, 0x42566F69);
            }
        }

        private void toggleGenderButton_Click(object sender, EventArgs e)
        {
            if (checkBoxP1.Checked && checkBoxP2.Checked && checkBoxP3.Checked && checkBoxP4.Checked
                    && checkBoxP5.Checked && checkBoxP6.Checked && checkBoxP7.Checked && checkBoxP8.Checked)
            {
                checkBoxP1.Checked = false;
                checkBoxP2.Checked = false;
                checkBoxP3.Checked = false;
                checkBoxP4.Checked = false;
                checkBoxP5.Checked = false;
                checkBoxP6.Checked = false;
                checkBoxP7.Checked = false;
                checkBoxP8.Checked = false;
            }
            else
            {
                checkBoxP1.Checked = true;
                checkBoxP2.Checked = true;
                checkBoxP3.Checked = true;
                checkBoxP4.Checked = true;
                checkBoxP5.Checked = true;
                checkBoxP6.Checked = true;
                checkBoxP7.Checked = true;
                checkBoxP8.Checked = true;
            }

        }

        ////SINGLE PLAYER
        private void singlePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinglePlayerForm singleplayerform = new SinglePlayerForm();
            singleplayerform.ShowDialog();
        }

        public void singlePlayerPoke()
        {
            uint all = 0;
            uint inkling = 0;

            if (autoRefresh[0])
                Gecko.poke(0x12D1F364 + octodiff, 0x00000002);

            for (uint i = 0; i < 3; i++)
            {
                //pokes all cpus to the inkling girl gender
                if (SinglePlayerForm.SPchoice[0])
                    Gecko.poke(0x12D1F460 + octodiff + (i * 0xFC), 0);
                //pokes all cpus to all genders
                else if (SinglePlayerForm.SPchoice[1])
                    Gecko.poke(0x12D1F460 + octodiff + (i * 0xFC), all);
                //pokes all cpus to the inkling boy gender
                else if (SinglePlayerForm.SPchoice[2])
                    Gecko.poke(0x12D1F460 + octodiff + (i * 0xFC), 0x1);

                //pokes all cpus to both inkling genders only
                else if (SinglePlayerForm.SPchoice[3])
                    Gecko.poke(0x12D1F460 + octodiff + (i * 0xFC), inkling);

                //for all gender function
                all++;
                //for inkling cpus function
                if (inkling == 0 || inkling == 1)
                    inkling = 1;
                else
                    inkling = 0;

                if (SinglePlayerForm.SPGearPoke)
                {
                    //????????????????????????????????????????????????????? :thumbsup:
                }
            }
        }
    }
}

