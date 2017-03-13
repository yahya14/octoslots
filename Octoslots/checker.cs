using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octoslots
{
    public partial class Checker : Form
    {
        public Checker()
        {
            InitializeComponent();
        }

        public static int ver = 0;

        public int getAssembly()
        {
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            StringBuilder builder = new StringBuilder(version.Length);

            for (int i = 0; i < version.Length; i++)
            {
                if (!version[i].Equals('.'))
                {
                    builder.Append(version[i]);
                }
            }
            return Convert.ToInt32(builder.ToString());
        }

        public void checkUpdate()
        {
            try
            {
                //gets the latest version number
                //Code continues at Form1_Shown()
                ver = Convert.ToInt32(new WebClient().DownloadString("https://raw.githubusercontent.com/yahya14/server-centre/master/Octoslots/version.txt"));
            }
            catch { }
        }

        private void Checker_Load(object sender, EventArgs e)
        {
            try
            {
                 updateRTB.Text = new WebClient().DownloadString("https://raw.githubusercontent.com/yahya14/server-centre/master/Octoslots/changelog.txt");
            }
            catch { }
        }

        private void webButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yahya14/octoslots/releases");
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
