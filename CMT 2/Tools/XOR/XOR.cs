using System;
using System.Windows.Forms;
using CMT_2.Engine;
using CMT_2.BS;
using System.Collections.Generic;

namespace CMT_2.Tools
{
    public partial class XOR : Form
    {
        private static List<string> Keys = new List<string>();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Keys.Count > 25)
                MessageBox.Show("Too many keys!, max key count 25!");
            if (Keys.Contains(KeyBox.Text))
                return;
            RememberedSelector.Items.Clear();
            RememberedSelector.AutoCompleteCustomSource.Clear();
            Keys.Add(KeyBox.Text);
            RememberedSelector.AutoCompleteCustomSource.AddRange(Keys.ToArray());
            RememberedSelector.Items.AddRange(Keys.ToArray());
        }
    }
}
