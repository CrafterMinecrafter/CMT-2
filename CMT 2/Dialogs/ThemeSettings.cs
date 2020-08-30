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
        private string ToText()
        {
            return $"{FormColor.BackColor.ToArgb()}\n{ButtonColor.BackColor.ToArgb()}\n{ButtonLineColor.BackColor.ToArgb()}\n{LabelColor.BackColor.ToArgb()}";
        }
        private void FromText(string text)
        {
            var colors = text.Split('\n');
            FormColor.BackColor = Color.FromArgb(int.Parse(colors[0]));
            ButtonColor.BackColor = Color.FromArgb(int.Parse(colors[1]));
            ButtonLineColor.BackColor = Color.FromArgb(int.Parse(colors[2]));
            LabelColor.BackColor = Color.FromArgb(int.Parse(colors[3]));

        }
        public static void ToSettings()
        {
            var colors = text.Split('\n');
            FormColor.BackColor = Color.FromArgb(int.Parse(colors[0]));
            ButtonColor.BackColor = Color.FromArgb(int.Parse(colors[1]));
            ButtonLineColor.BackColor = Color.FromArgb(int.Parse(colors[2]));
            LabelColor.BackColor = Color.FromArgb(int.Parse(colors[3]));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CMT_2.Properties.Settings.Default.customSettings = ToText();
            CMT_2.Properties.Settings.Default.Save();

        }
    }
}
