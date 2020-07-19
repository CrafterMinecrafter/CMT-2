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
        private bool ThemeIsDark = false;
        #endregion

        public Settings()
        {
            InitializeComponent();
        }
        private void Theme_Button_Click(object sender, EventArgs e)
        {
            ThemeIsDark = !ThemeIsDark;
            ThemeEngine.SetTheme(ThemeIsDark);
            ThemeLabel.Text = ":  " + ThemeIsDark;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            ThemeLabel.Text = ":  " + ThemeIsDark;
        }


    }
}
