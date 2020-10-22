using CMT_2.BS;
using CMT_2.Engine;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CMT_2.Tools
{
    public partial class AES : Form
    {
        private BS.AesEncryptor aes;

        public static List<string> Keys = new List<string>();
        public AES()
        {
            InitializeComponent();
        }

        private void AES_Load(object sender, EventArgs e)
        {
            ThemeEngine.InitTheme(this);
            aes = new AesEncryptor();
        }

        private void RememberedSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyBox.Text = (string)(sender as ComboBox).SelectedItem;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            selectedKey = KeyBox.Text;
            if (Keys.Count > 25)
            {
                MessageBox.Show("Too many keys!, max key count 25!");
                return;
            }
            if (Keys.Contains(KeyBox.Text))
                return;
            Keys.Add(KeyBox.Text);
        }

        private void RememberedSelector_DropDown(object sender, EventArgs e)
        {
            RememberedSelector.Items.Clear();
            RememberedSelector.Items.AddRange(Keys.ToArray());
        }

        private void Enc_Button_Click(object sender, EventArgs e)
        {

            try
            {
                EncBox.Text = aes.Encrypt(DecBox.Text, selectedKey);
            }
            catch
            {
                MessageBox.Show("Text Error");
            }
        }
        private void Dec_button_Click(object sender, EventArgs e)
        {

            try
            {
                DecBox.Text = aes.DecryptString(EncBox.Text, selectedKey);
            }
            catch
            {
                MessageBox.Show("Text Error");
            }

        }
        private string selectedKey = "defaultKey";

        private void DropDown_remove_Click(object sender, EventArgs e)
        {
            Keys.Remove((string)RememberedSelector.SelectedItem);
            RememberedSelector.Text = "";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBox2.Checked;
        }
    }
}
