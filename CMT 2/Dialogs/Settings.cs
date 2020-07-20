using CMT_2.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMT_2.Dialogs
{
    public partial class Settings : Form
    {
        #region Settings
        public static bool ThemeIsDark = false;
        #endregion
        static Settings()
        {
            ThemeIsDark = CMT_2.Properties.Settings.Default.DarkTheme;
        }
        public Settings()
        {
            InitializeComponent();
        }
        private void Theme_Button_Click(object sender, EventArgs e)
        {
            ThemeIsDark = !ThemeIsDark;
            ThemeEngine.SetTheme(ThemeIsDark);
            ThemeLabel.Text = ":  " + ThemeIsDark;
            CMT_2.Properties.Settings.Default.DarkTheme = ThemeIsDark;
            CMT_2.Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            ThemeEngine.InitTheme(this);
            ThemeLabel.Text = ":  " + ThemeIsDark;
        }


    }
}
