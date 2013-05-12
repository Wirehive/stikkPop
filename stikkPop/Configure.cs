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
using System.Net;
using System.Timers;

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
            Settings.Default["autoCopy"] = autoCopyCheckBox.Checked;
            Settings.Default["autoOpen"] = autoOpenCheckBox.Checked;
            Settings.Default.Save();
            this.Close();
        }

        System.Windows.Forms.Timer TestHTTP200Timer = new System.Windows.Forms.Timer();
        private void Configure_Load(object sender, EventArgs e)
        {
            //Set initial dialog state
            syntaxBox.DataSource = Startup.syntaxList;
            syntaxBox.SelectedItem = Settings.Default["syntax"];
            endpointBox.Text = Settings.Default["endpoint"].ToString();
            nameBox.Text = Settings.Default["name"].ToString();
            privateCheckBox.Checked = (bool)Settings.Default["alwaysPrivate"];
            autoCopyCheckBox.Checked = (bool)Settings.Default["autoCopy"];
            autoOpenCheckBox.Checked = (bool)Settings.Default["autoOpen"];

            //Validate endpoint URL and prepare to validate on typing
            TestHTTP200(endpointBox.Text);
            endpointBox.KeyUp += EndpointBox_KeyUp;
            TestHTTP200Timer.Tick += new EventHandler(TestHTTP200TimerEnd);
            TestHTTP200Timer.Interval = 750; 
        }

        void EndpointBox_KeyUp(object sender, KeyEventArgs e)
        {
            TestHTTP200Timer.Stop();
            TestHTTP200Timer.Start();
        }


        private void TestHTTP200TimerEnd(Object myObject, EventArgs myEventArgs)
        {
            TestHTTP200Timer.Stop();
            TestHTTP200(endpointBox.Text);
        }

        private void privateCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TestHTTP200(string url="empty")
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Method = "GET";

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        tick.Visible = false;
                        cross.Visible = true;
                    }
                    else
                    {
                        var responseValue = "";

                        using (var responseStream = response.GetResponseStream())
                        {
                            if (responseStream != null)
                                using (var reader = new System.IO.StreamReader(responseStream))
                                {
                                    responseValue = reader.ReadToEnd();
                                }
                        }

                        if (responseValue == "Error: Missing paste text\n")
                        {
                            tick.Visible = true;
                            cross.Visible = false;
                        }
                        else
                        {
                            tick.Visible = false;
                            cross.Visible = true;
                        }
                    }
                }
            }
            catch
            {
                tick.Visible = false;
                cross.Visible = true;
            }

        }
    }
}
