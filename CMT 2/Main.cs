using CMT_2.Dialogs;
using CMT_2.Engine;
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
        private string[] dlls = new string[2];
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            int index = 0;
            try
            {

                using (WebClient wb = new WebClient())
                {
                    index = Convert.ToInt32(wb.DownloadString("http://localhost:8885?token=" + IDsManager.id[1]));

                }
                if (!File.Exists(Path.GetPathRoot(Environment.SystemDirectory) + "/CrafterMinecrafter Tool/Settings.cmt"))
                    File.CreateText(Directory.CreateDirectory(Path.GetPathRoot(Environment.SystemDirectory) + "/CrafterMinecrafter Tool").FullName + "/Settings.cmt");
                CMT_2.Properties.Settings.Default.Reload();
            }
            catch
            {
                Application.Exit();
            }
            switch (index)
            {
                case 1:
                    {
                        IsPro = false;
                        Text = "CrafterMinecrafter Tool Community";
                        break;
                    }
                case 2:
                    {
                        IsPro = true;
                        Text = "CrafterMinecrafter Tool Pro";

                        break;
                    }
                default:
                    {
                        Application.Exit();
                        break;
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
    }
}
