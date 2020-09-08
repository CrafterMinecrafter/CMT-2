using System;
using System.Windows.Forms;
using CMT_2.Engine;
using CMT_2.BS;
using System.Collections.Generic;

namespace CMT_2.Tools
{
    public partial class XOR : Form
    {
        public static List<string> Keys = new List<string>();
        public Utils utils = new Utils();
        public XOR()
        {
            InitializeComponent();
        }

        private void XOR_Load(object sender, EventArgs e)
        {
            ThemeEngine.InitTheme(this);
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
            EncBox.Text = utils.XOR(DecBox.Text, selectedKey, true);
        }
        private void Dec_button_Click(object sender, EventArgs e)
        {
            DecBox.Text = utils.XOR(EncBox.Text, selectedKey, false);

        }
        private string selectedKey = "z0c8pwApJ";

        private void DropDown_remove_Click(object sender, EventArgs e)
        {
            Keys.Remove((string)RememberedSelector.SelectedItem);
            RememberedSelector.Text = "";
        }
    }
}
