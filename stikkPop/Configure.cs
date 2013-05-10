using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stikkPop.Properties;

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
            Settings.Default["endpoint"] = endpointBox.Text;
            Settings.Default["syntax"] = syntaxBox.SelectedValue;
            Settings.Default["name"] = nameBox.Text;
            Settings.Default["alwaysPrivate"] = privateCheckBox.Checked;
            Settings.Default.Save();
            this.Close();
        }

        private void Configure_Load(object sender, EventArgs e)
        {
            syntaxBox.DataSource = Startup.syntaxList;
            syntaxBox.SelectedItem = Settings.Default["syntax"];
            endpointBox.Text = Settings.Default["endpoint"].ToString();
            nameBox.Text = Settings.Default["name"].ToString();
            privateCheckBox.Checked = (bool)Settings.Default["alwaysPrivate"];
        }

        private void privateCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
