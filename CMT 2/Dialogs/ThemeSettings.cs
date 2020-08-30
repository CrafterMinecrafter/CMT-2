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
            try
            {
                ThemeEngine.InitTheme(this);
                label2.Text = "Selected Font:" + ThemeEngine.settingsClass.DefaultFont.Name;
                FromText(CMT_2.Properties.Settings.Default.customSettings);
            } catch
            { }
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
            return $"{FormColor.BackColor.ToArgb()}\n{ButtonColor.BackColor.ToArgb()}\n{LabelColor.BackColor.ToArgb()}\n{ButtonLineColor.BackColor.ToArgb()}\n{textbox_color.BackColor.ToArgb()}\n{Font_Button.Font.Name}";
        }
        private void FromText(string text)
        {
            var colors = text.Split('\n');
            FormColor.BackColor = Color.FromArgb(int.Parse(colors[0]));
            ButtonColor.BackColor = Color.FromArgb(int.Parse(colors[1]));
            LabelColor.BackColor = Color.FromArgb(int.Parse(colors[2]));
            ButtonLineColor.BackColor = Color.FromArgb(int.Parse(colors[3]));
            ButtonLineColor.BackColor = Color.FromArgb(int.Parse(colors[4]));
            Font_Button.Font = new Font(colors[5], 8f, GraphicsUnit.Point); 
        }
        public static void ToSettings()
        {
            var colors = CMT_2.Properties.Settings.Default.customSettings.Split('\n');
            ThemeEngine.settingsClass.Dark_Form_BackColor= Color.FromArgb(int.Parse(colors[0]));
            ThemeEngine.settingsClass.Dark_Button_BackColor  = Color.FromArgb(int.Parse(colors[1]));
            ThemeEngine.settingsClass.Light_Label_ForeColor = Color.FromArgb(int.Parse(colors[2]));
            ThemeEngine.settingsClass.Dark_Button_BorderColor = Color.FromArgb(int.Parse(colors[3]));
            ThemeEngine.settingsClass.Dark_textbox_BackColor = Color.FromArgb(int.Parse(colors[4]));
            ThemeEngine.settingsClass.DefaultFont = new Font(colors[5], 8f, GraphicsUnit.Point);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CMT_2.Properties.Settings.Default.customSettings = ToText();
            CMT_2.Properties.Settings.Default.Save();
            ToSettings();
            label2.Text = "Selected Font:" + ThemeEngine.settingsClass.DefaultFont.Name;
            ThemeEngine.SetTheme(Settings.ThemeIsDark);
        }

        private void Font_Button_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font_Button.Font = new Font(fontDialog1.Font.Name, 8f, GraphicsUnit.Point);
                label2.Text = "Selected Font:" + ThemeEngine.settingsClass.DefaultFont.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemeEngine.settingsClass.Reset();
            ThemeEngine.SetTheme(Settings.ThemeIsDark);
            Properties.Settings.Default.customSettings = "";
            Properties.Settings.Default.Save();
        }
    }
}
