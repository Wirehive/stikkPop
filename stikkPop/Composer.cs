using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stikkPop
{
    public partial class Composer : Form
    {
        public Main mainForm = null;

        public Composer(Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            composedTextBox.KeyDown += composedTextBox_KeyDown;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            mainForm.PasteText(composedTextBox.Text);
            this.Close();
        }

        private void composedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                composedTextBox.SelectAll();
            }
        }
    }
}
