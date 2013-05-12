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

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                MessageBox.Show("Hello world");
            }
            base.OnKeyDown(e);
        }

        public Main()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Configure configureDialog = new Configure();
            configureDialog.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            pasteText = GetClipboardText();
            pasteText = HttpUtility.UrlEncode(pasteText);
            if (privateCheckBox.Checked == true)
            {
                isPrivate = "1";
            }
            string name = (string)Settings.Default["name"];
            name = HttpUtility.UrlEncode(name);

            HttpWebRequest request = WebRequest.Create(Settings.Default["EndPoint"].ToString()) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "";
            postData += "text="+pasteText;
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

        }

        private void CopyLinkButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(urlBox.Text);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void expiryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(urlBox.Text);
        }

        private void syntaxBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Expiry
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
