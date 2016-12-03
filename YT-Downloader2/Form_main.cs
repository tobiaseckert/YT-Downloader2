



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YT_Downloader2
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

            #region Festgelegte Variablen hier
            string a = Convert.ToString(Application.ProductVersion);
            #endregion

            #region Listview Definition
            // vordefinierte Festlegung von listView 
            listView.LabelEdit = true;
            listView.AllowColumnReorder = true;
            listView.CheckBoxes = true;
            listView.GridLines = true;
            #endregion

            this.Text += " Version " + a;

            /*
             * Alternativ : Application.ExecutablePath
             *              AppDomain.CurrentDomain.BaseDirectory
             *
             *Pfad = dateiname ? zu langer Pfad
             *"C:\\Users\\Tobias\\AppData\\Roaming\\YouTube_Videodownloader\\YouTube-Videodownloader\\1.0.0.0\\pfad.config" ???*/

            string dateiname = Application.UserAppDataPath.ToString() + "\\pfad.config";

            FileInfo myFile = new FileInfo(dateiname);

            // Datei wird geöffnet, wenn vorhanden, ansonsten erstellt
            FileStream myStream = myFile.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);


            //überprüfen, ob die Datei exsistiert
            if (!File.Exists(dateiname))
            {
                // Öffne FolderBrowserDialog, wenn Dateiname nicht Vorhanden ist
                folderBrowserDialog.SelectedPath = Application.ExecutablePath;
                folderBrowserDialog.ShowDialog();
            }

        }
    }
}
