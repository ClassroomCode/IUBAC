using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            // Encrypt the value of PlainTextBox and put the result in ResultTextBox
            // ResultTextBox.Text = SomeObj.Encrypt(PlainTextBox.Text)
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            // Decrypt the value of CipherTextBox and put the result in ResultTextBox
            // ResultTextBox.Text = SomeObj.Decrypt(CipherTextBox.Text)
        }
    }
}
