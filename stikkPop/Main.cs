using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using stikkPop.Properties;

namespace stikkPop
{
    public partial class Main : Form
    {
        string pasteURL;
        string pasteText;
        string isPrivate = "0";

        public string GetClipboardText()
        {
            String returnText = null;
            if (Clipboard.ContainsText())
            {
                returnText = Clipboard.GetText(TextDataFormat.Text);
            }
            return returnText;
        }

        public Main()
        {
            InitializeComponent();
            Configure configureDialog = new Configure();
            this.KeyDown += Main_KeyDown;

            //Is initial config needed?
            if (Settings.Default["EndPoint"].ToString() == string.Empty)
            {
                configureDialog.ShowDialog();
            }

            syntaxBox.SelectedItem = Settings.Default["syntax"];
        }

        void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                string pasteText = GetClipboardText();
                PasteText(pasteText);
            }
        }

        private void configureLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Configure configureDialog = new Configure();
            configureDialog.ShowDialog();
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            string pasteText = GetClipboardText();
            PasteText(pasteText);
        }

        public void PasteText(string pasteText)
        {
            List<string> errors = new List<string>();

            string endpointURL = Settings.Default["EndPoint"].ToString() + "/api/create";

            if (ValidateInput(errors))
            {
                pasteText = HttpUtility.UrlEncode(pasteText);
                if (privateCheckBox.Checked == true)
                {
                    isPrivate = "1";
                }

                string name = (string)Settings.Default["name"];
                name = HttpUtility.UrlEncode(name);

                try
                {
                    PostData(pasteText, name, endpointURL);
                }
                catch 
                {
                    MessageBox.Show("API Unreachable:\n " + endpointURL);
                }

            }
            else
            {
                StringBuilder sbErrors = new StringBuilder();

                if (errors.Count > 0)
                {
                    foreach (string error in errors)
                    {
                        sbErrors.AppendLine(error);
                    }

                    MessageBox.Show(sbErrors.ToString());
                }
            }
        }

        private void PostData(string pasteText, string name, string url)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "";
            postData += "text=" + pasteText;
            postData += "&lang=" + syntaxBox.SelectedValue;
            postData += "&title=" + titleBox.Text;
            postData += "&private=" + isPrivate;
            postData += "&name=" + name;
            postData += "&expire=" + expiryBox.ValueMember;

            byte[] post = encoding.GetBytes(postData);
            request.ContentLength = post.Length;

            using (Stream output = request.GetRequestStream())
            {
                output.Write(post, 0, post.Length);
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                var responseValue = string.Empty;

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var message = String.Format("Request failed. Received HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                // grab the response
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                        using (var reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                        }
                }

                pasteURL = responseValue;
            }

            urlBox.Text = pasteURL;

            if ((bool)Settings.Default["autoCopy"] == true)
            {
                Clipboard.SetText(urlBox.Text);
                PastedURLLabel.Text = "Pasted URL (Auto-copied)";
            }
            else
            {
                PastedURLLabel.Text = "Pasted URL";
            }

            if ((bool)Settings.Default["autoOpen"] == true)
            {
                System.Diagnostics.Process.Start(urlBox.Text);
            }
        }

        private static bool ValidateInput(List<string> errors)
        {
            bool isValid = true;

            if (Settings.Default["EndPoint"].ToString() == string.Empty)
            {
                isValid = false;
                errors.Add("API Endpoint has not been set.");
            }

            return isValid;
        }

        private void CopyLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(urlBox.Text);
            }
            catch { }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            syntaxBox.DataSource = Startup.syntaxList;
            syntaxBox.SelectedItem = Settings.Default["syntax"];
            if ((bool)Settings.Default["alwaysPrivate"] == true)
            {
                privateCheckBox.Enabled = false;
                privateCheckBox.Checked = true;
            }

            //Build a list
            var expiryTimes = new List<Expiry>();
            expiryTimes.Add(new Expiry() { Name = "Keep Forever", Value = "0" });
            expiryTimes.Add(new Expiry() { Name = "30 Minutes", Value = "30" });
            expiryTimes.Add(new Expiry() { Name = "1 Hour", Value = "60" });
            expiryTimes.Add(new Expiry() { Name = "6 Hours", Value = "360" });
            expiryTimes.Add(new Expiry() { Name = "12 Hours", Value = "720" });
            expiryTimes.Add(new Expiry() { Name = "1 Day", Value = "1440" });
            expiryTimes.Add(new Expiry() { Name = "1 Week", Value = "10080" });
            expiryTimes.Add(new Expiry() { Name = "4 Weeks", Value = "40320" });


            //Setup data binding
            this.expiryBox.DataSource = expiryTimes;
            this.expiryBox.DisplayMember = "Name";
            this.expiryBox.ValueMember = "Value";

            this.syntaxBox.KeyUp += new KeyEventHandler(this.syntaxBox_KeyUp);
        }

        private void urlLabel_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(urlBox.Text);
            }
            catch { }
        }

        private void syntaxBox_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;

            // Do nothing for certain keys, such as navigation keys.
            if ((e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                (e.KeyCode == Keys.Up) ||
                (e.KeyCode == Keys.Down) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.PageUp) ||
                (e.KeyCode == Keys.PageDown) ||
                (e.KeyCode == Keys.Home) ||
                (e.KeyCode == Keys.End))
            {
                return;
            }

            // Store the actual text that has been typed.
            actual = this.syntaxBox.Text;

            // Find the first match for the typed value.
            index = this.syntaxBox.FindString(actual);

            // Get the text of the first match.
            if (index > -1)
            {
                found = this.syntaxBox.Items[index].ToString();

                // Select this item from the list.
                this.syntaxBox.SelectedIndex = index;

                // Select the portion of the text that was automatically
                // added so that additional typing replaces it.
                this.syntaxBox.SelectionStart = actual.Length;
                this.syntaxBox.SelectionLength = found.Length;
            }
        }

        private void composeButton_Click(object sender, EventArgs e)
        {
            Composer composerDialog = new Composer(this);
            composerDialog.Show();
        }

        private void openStikkedLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Settings.Default["EndPoint"].ToString());
        }
    }
    public class Expiry
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
