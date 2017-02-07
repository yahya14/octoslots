using System;
using System.Threading;
using System.Windows.Forms;

namespace Octoslots
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // for debugging purposes
            /*CultureInfo japaneseCulture = new CultureInfo("ja-JP");
            Thread.CurrentThread.CurrentCulture = japaneseCulture;
            Thread.CurrentThread.CurrentUICulture = japaneseCulture;
            CultureInfo.DefaultThreadCurrentCulture = japaneseCulture;
            CultureInfo.DefaultThreadCurrentUICulture = japaneseCulture;*/

            // Generate the weapon database on start up
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
