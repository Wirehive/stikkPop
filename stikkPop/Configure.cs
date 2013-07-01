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
        System.Windows.Forms.Timer TestHTTP200Timer = new System.Windows.Forms.Timer();

        public Configure()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Settings.Default["endpoint"] = GetUri(endpointBox.Text).ToString();
            Settings.Default["syntax"] = syntaxBox.SelectedValue;
            Settings.Default["name"] = nameBox.Text;
            Settings.Default["alwaysPrivate"] = privateCheckBox.Checked;
            Settings.Default["autoCopy"] = autoCopyCheckBox.Checked;
            Settings.Default["autoOpen"] = autoOpenCheckBox.Checked;
            Settings.Default.Save();
            this.Close();
        }
        
        private void Configure_Load(object sender, EventArgs e)
        {
            //Set initial dialog state
            syntaxBox.DataSource = Startup.syntaxList;
            syntaxBox.SelectedItem = Settings.Default["syntax"];
            updateImgurAuthenticatedVisibility();

            //Validate endpoint URL 
            TestHTTP200(endpointBox.Text + "/api/create");

            //prepare to validate on typing
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
            string testEndpoint = GetUri(endpointBox.Text) + "/api/create";
            TestHTTP200(testEndpoint);
        }

        public static Uri GetUri(string s)
        {
            return new UriBuilder(s).Uri;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Imgur.RequestPin();
        }

        private void validateImgurPIN(object sender, EventArgs e)
        {
            ImgurToken Token = Imgur.GetToken(PINbox.Text);
            Settings.Default["imgurAccessToken"] = Token.AccessToken;
            Settings.Default["imgurRefreshToken"] = Token.RefreshToken;
            Settings.Default["imgurTokenExpires"] = DateTime.Now.AddSeconds(Convert.ToDouble(Token.ExpiresIn)-120);

            updateImgurAuthenticatedVisibility();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Settings.Default["imgurAuthenticated"] = false;
            Settings.Default["imgurAccessToken"] = null;
            Settings.Default["imgurRefreshToken"] = null;
            updateImgurAuthenticatedVisibility();
        }

        private void updateImgurAuthenticatedVisibility()
        {
            loginLink.Visible = !(bool)Settings.Default["imgurAuthenticated"];
            labelYourPin.Visible = !(bool)Settings.Default["imgurAuthenticated"];
            PINbox.Visible = !(bool)Settings.Default["imgurAuthenticated"];
            validateButton.Visible = !(bool)Settings.Default["imgurAuthenticated"];

            autheticatedLabel.Visible = (bool)Settings.Default["imgurAuthenticated"];
            logOutButton.Visible = (bool)Settings.Default["imgurAuthenticated"];
        }
    }
}
