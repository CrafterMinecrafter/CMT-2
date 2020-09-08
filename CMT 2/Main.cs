using CMT_2.Dialogs;
using CMT_2.Engine;
using CMT_2.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using UHWID;

namespace CMT_2
{
    public partial class Main : Form
    {
        public static bool IsPro;
        public static string CMTFolder = Path.GetPathRoot(Environment.SystemDirectory) + "/CrafterMinecrafter Tool/";
        private string[] dlls = new string[2];
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {

                using (WebClient wb = new WebClient())
                {
                    if (wb.DownloadString("https://ideone.com/plain/bAROiC").Contains(IDsManager.id[3]))
                    {
                        IsPro = true;
                        Text = "CrafterMinecrafter Tool Pro";
                    }
                    else
                    {
                        IsPro = false;
                        Text = "CrafterMinecrafter Tool Community";
                    }
                }
                if (!File.Exists(CMTFolder + "RememberedXORKeys.cmt") || File.Exists(CMTFolder + "RememberedAESKeys.cmt"))
                {
                    File.CreateText(Directory.CreateDirectory(CMTFolder + "/CrafterMinecrafter Tool").FullName + "/RememberedXORKeys.cmt");
                    File.CreateText(Directory.CreateDirectory(CMTFolder + "/CrafterMinecrafter Tool").FullName + "/RememberedAESKeys.cmt");
                }
                CMT_2.Properties.Settings.Default.Reload();
            }
            catch
            {
                Application.Exit();
            }





            if (IsPro)
            {
                try
                {
                    ThemeSettings.ToSettings();
                } catch
                {

                }
            }
            ThemeEngine.InitTheme(this);
        }

        private void Info_Button_Click(object sender, EventArgs e)
        {
            new Info().ShowDialog();
        }

        private void OpenSettings_button_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }

        private void XOR_Click(object sender, EventArgs e)
        {
            new XOR().Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            string buffer = "";
            for(int i = 0; i < CMT_2.Tools.XOR.Keys.Count; i++)
            {
                buffer += CMT_2.Tools.XOR.Keys[i] + "\n";
            }
            File.WriteAllText(CMTFolder + "RememberedXORKeys.cmt", buffer);
        }
    }
}
