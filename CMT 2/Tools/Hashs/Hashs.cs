using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMT_2.BS;
namespace CMT_2.Tools.Hashs
{
    public partial class Hashs : Form
    {
        private string UniversalCode =
        #region Code In Base64
            "cHVibGljIHN0YXRpYyBzdHJpbmcgSGFzaE5hbWUoc3RyaW5nIHRleHQpDQogICAgICAgIHsNCiAgICAgICAgICAgIHZhciB1dGY4RW5jb2RpbmcgPSBuZXcgU3lzdGVtLlRleHQuVVRGOEVuY29kaW5nKCk7DQogICAgICAgICAgICBieXRlW10gYnl0ZXMgPSB1dGY4RW5jb2RpbmcuR2V0Qnl0ZXModGV4dCk7DQogICAgICAgICAgICB2YXIgYWxnID0gU3lzdGVtLlNlY3VyaXR5LkNyeXB0b2dyYXBoeS4gSGFzaEFsZ29yaXRobS5DcmVhdGUoIkhhc2hOYW1lIik7DQogICAgICAgICAgICBieXRlW10gSGFzaEJ5dGVzID0gYWxnLkNvbXB1dGVIYXNoKGJ5dGVzKTsNCiAgICAgICAgICAgIHN0cmluZyBTdHJpbmdPdXRwdXQgPSBzdHJpbmcuRW1wdHk7DQogICAgICAgICAgICBmb3IgKGludCBhID0gMCwgYiA9IEhhc2hCeXRlcy5MZW5ndGg7IGEgPCBiIDspDQogICAgICAgICAgICB7DQogICAgICAgICAgICAgICAgU3RyaW5nT3V0cHV0ICs9IFN5c3RlbS5Db252ZXJ0LlRvU3RyaW5nKEhhc2hCeXRlc1thXSwgMTYpLlBhZExlZnQoMiwgJzAnKTsNCiAgICAgICAgICAgICAgICBhKys7DQogICAgICAgICAgICB9DQogICAgICAgICAgICByZXR1cm4gU3RyaW5nT3V0cHV0LlBhZExlZnQoMzIsICcwJyk7DQogICAgICAgIH0=";
        #endregion
        private string UniversalCodeForFiles =
        #region Code In Base64
            "cHVibGljIHN0YXRpYyBzdHJpbmcgSGFzaE5hbWVGaWxlKHN0cmluZyB0ZXh0LCBzdHJpbmcgUGF0aCkNCiAgICAgICAgew0KICAgICAgICAgICAgYnl0ZVtdIGJ5dGVzID0gU3lzdGVtLklPLkZpbGUuUmVhZEFsbEJ5dGVzKFBhdGgpOw0KICAgICAgICAgICAgdmFyIGFsZyA9IFN5c3RlbS5TZWN1cml0eS5DcnlwdG9ncmFwaHkuIEhhc2hBbGdvcml0aG0uQ3JlYXRlKCJIYXNoTmFtZSIpOw0KICAgICAgICAgICAgYnl0ZVtdIEhhc2hCeXRlcyA9IGFsZy5Db21wdXRlSGFzaChieXRlcyk7DQogICAgICAgICAgICBzdHJpbmcgU3RyaW5nT3V0cHV0ID0gc3RyaW5nLkVtcHR5Ow0KICAgICAgICAgICAgZm9yIChpbnQgYSA9IDAsIGIgPSBIYXNoQnl0ZXMuTGVuZ3RoOyBhIDwgYiA7KQ0KICAgICAgICAgICAgew0KICAgICAgICAgICAgICAgIFN0cmluZ091dHB1dCArPSBTeXN0ZW0uQ29udmVydC5Ub1N0cmluZyhIYXNoQnl0ZXNbYV0sIDE2KS5QYWRMZWZ0KDIsICcwJyk7DQogICAgICAgICAgICAgICAgYSsrOw0KICAgICAgICAgICAgfQ0KICAgICAgICAgICAgcmV0dXJuIFN0cmluZ091dHB1dC5QYWRMZWZ0KDMyLCAnMCcpOw0KICAgICAgICB9";
        #endregion
        public Hashs()
        {
            InitializeComponent();
        }

        private void Hashs_Load(object sender, EventArgs e)
        {
            Engine.ThemeEngine.InitTheme(this);
            SelectedHash.Text = "MD5";
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextToHash();
        }
        private void TextToHash()
        {
            hashBox.Text = Utils.AllHashes(textBox.Text, SelectedHash.Text);
        }
        private void SelectedHash_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextToHash();
        }

        private void GetCode_Button_Click(object sender, EventArgs e)
        {
            new Dialogs.TextBoxDialog(Utils.FromBase64(UniversalCode).Replace("HashName", SelectedHash.Text),"Code view").ShowDialog();
        }

        private void GetCodeForFiles_Button_Click(object sender, EventArgs e)
        {
            new Dialogs.TextBoxDialog(Utils.FromBase64(UniversalCodeForFiles).Replace("HashName", SelectedHash.Text), "Code view").ShowDialog();
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            hashBox.Text = Utils.AllHashesFile(FileTools.OpenFile(), SelectedHash.Text);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox2.Checked;
        }
    }
}
