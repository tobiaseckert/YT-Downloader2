/// TODO
/// Progress.SetValue(ProgressBar.ValueProperty
/// 




using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YT_Downloader2
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_main());
        }
        
        #region Debugging
        public static void DW(string strout)          // debug write
        {
         #if false
            System.IO.StreamWriter sw = new System.IO.StreamWriter( "e:\\debug.txt", true );
            sw.WriteLine( strout );
            sw.Close();
         #else
            Debug.WriteLine( strout );
         #endif
         }
         #endregion

    }
}
