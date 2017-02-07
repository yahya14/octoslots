using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Octoslots
{
    public static class FontConfig
    {
        [DllImport("gdi32.dll")]
        public static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        public static FontFamily Paintball;
        public static Font paint;

        public static void PaintballFont()
        {
            // Create the byte array and get its length
            byte[] fontArray = Properties.Resources.Paintball_Beta_3;
            int dataLength = Properties.Resources.Paintball_Beta_3.Length;

            //assign memory and copy byte[] on that memory address
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();
            //pass the font to the PrivateFontCollection
            pfc.AddMemoryFont(ptrData, dataLength);

            //free the unsafe memory
            Marshal.FreeCoTaskMem(ptrData);

            Paintball = pfc.Families[0];
            paint = new Font(Paintball, (float)12.75, FontStyle.Bold);
        }
    }
}
