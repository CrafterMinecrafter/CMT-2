using CMT_2.Dialogs;
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
using UHWID;

namespace CMT_2
{
    public partial class Main : Form
    {
        private bool IsPro;
        bool DarkTheme = false;
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
                    index = Convert.ToInt32(wb.DownloadString("http://localhost:8885?token="  + IDsManager.id[1]));
                   
                }
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
            File.Create(Directory.GetLogicalDrives()[0] + "/CrafterMinecrafter Tool/Settings.CMT");
        }

        private void Info_Button_Click(object sender, EventArgs e)
        {
            new Info().ShowDialog();
        }
    }
}
