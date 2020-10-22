using CMT_2.Engine;
using System;
using System.Drawing;
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
            }
            catch
            { }
        }

        private void SetIS(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                (sender as PictureBox).BackColor = colorDialog1.Color;

            }
        }

        private string ToText()
        {
            return $"{FormColor.BackColor.ToArgb()}\n{ButtonColor.BackColor.ToArgb()}\n{LabelColor.BackColor.ToArgb()}\n{ButtonLineColor.BackColor.ToArgb()}\n{textbox_color.BackColor.ToArgb()}\n{Font_Button.Font.Name}";
        }
        private void FromText(string text)
        {
            var colors = text.Split('\n');//setting load
            FormColor.BackColor = Color.FromArgb(int.Parse(colors[0]));//form
            ButtonColor.BackColor = Color.FromArgb(int.Parse(colors[1]));//button
            LabelColor.BackColor = Color.FromArgb(int.Parse(colors[2]));//label
            ButtonLineColor.BackColor = Color.FromArgb(int.Parse(colors[3]));//button line
            textbox_color.BackColor = Color.FromArgb(int.Parse(colors[4]));//textbox
            Font_Button.Font = new Font(colors[5], 8f, GraphicsUnit.Point);//font
        }
        public static void ToSettings()
        {
            var colors = CMT_2.Properties.Settings.Default.customSettings.Split('\n');//setting load
            ThemeEngine.settingsClass.Dark_Form_BackColor = Color.FromArgb(int.Parse(colors[0]));//form
            ThemeEngine.settingsClass.Dark_Button_BackColor = Color.FromArgb(int.Parse(colors[1]));//button
            ThemeEngine.settingsClass.Light_Label_ForeColor = Color.FromArgb(int.Parse(colors[2]));//label
            ThemeEngine.settingsClass.Dark_Button_BorderColor = Color.FromArgb(int.Parse(colors[3]));//button line
            ThemeEngine.settingsClass.Dark_textbox_BackColor = Color.FromArgb(int.Parse(colors[4]));//textbox
            ThemeEngine.settingsClass.DefaultFont = new Font(colors[5], 8f, GraphicsUnit.Point);//font
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CMT_2.Properties.Settings.Default.customSettings = ToText();
            CMT_2.Properties.Settings.Default.Save();
            ToSettings();
            label2.Text = "Selected Font:" + ThemeEngine.settingsClass.DefaultFont.Name;
            ThemeEngine.SetTheme();
        }

        private void Font_Button_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                (sender as Button).Font = new Font(fontDialog1.Font.Name, 8f, GraphicsUnit.Point);
                label2.Text = "Selected Font:" + ThemeEngine.settingsClass.DefaultFont.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemeEngine.settingsClass.Reset();
            Properties.Settings.Default.customSettings = "";
            Properties.Settings.Default.Save();
            ThemeEngine.SetTheme();
        }
    }
}
