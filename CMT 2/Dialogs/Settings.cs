using CMT_2.Engine;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CMT_2.Dialogs
{
    public partial class Settings : Form
    {
        #region Settings
        public static bool ThemeIsDark
        {
            get
            {
                return Properties.Settings.Default.DarkTheme;
            }
            set
            {
                Properties.Settings.Default.DarkTheme = value;
                CMT_2.Properties.Settings.Default.Save();
            }
        }
        #endregion

        public Settings()
        {
            InitializeComponent();
        }
        private void Theme_Button_Click(object sender, EventArgs e)
        {
            ThemeIsDark = !ThemeIsDark;
            ThemeEngine.SetTheme();
            ThemeLabel.Text = ":  " + ThemeIsDark;

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            ThemeEngine.InitTheme(this);
            ThemeLabel.Text = ":  " + ThemeIsDark;
            GetPro.Visible = !Main.IsPro;
        }

        private void ThemeSettings_button_Click(object sender, EventArgs e)
        {
            if (!Main.IsPro)
            {
                MessageBox.Show("You not have pro version :(\nSorry bro");
            }
            else
            {
                new ThemeSettings().ShowDialog();
            }
        }

        private void GetPro_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/o_privet_t");
        }
    }
}
