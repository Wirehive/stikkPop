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
    public partial class Configure : Form
    {
        public Configure()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void Configure_Load(object sender, EventArgs e)
        {
            syntaxBox.DataSource = syntaxManager.syntaxList;
        }
    }
}
