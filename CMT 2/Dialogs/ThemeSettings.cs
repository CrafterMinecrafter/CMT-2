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
    public partial class ThemeSettings : Form
    {
        public ThemeSettings()
        {
            InitializeComponent();
        }

        private void ThemeSettings_Load(object sender, EventArgs e)
        {
            ThemeEngine.InitTheme(this);
        }

        private void SetIS(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                (sender as PictureBox).BackColor = colorDialog1.Color;
                
            }
        }

        private void c(object sender, EventArgs e)
        {

        }
    }
}
