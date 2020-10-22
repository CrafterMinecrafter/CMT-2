using System.Windows.Forms;

namespace CMT_2.Dialogs
{
    public partial class TextBoxDialog : Form
    {
        public TextBoxDialog()
        {
            InitializeComponent();
        }
        public TextBoxDialog(string Text, string Name)
        {
            InitializeComponent();
            this.Text = Name;
            Box.Text = Text;
        }

        private async void TextBoxDialog_Load(object sender, System.EventArgs e)
        {
            await Engine.ThemeEngine.InitTheme(this);
        }
    }
}
