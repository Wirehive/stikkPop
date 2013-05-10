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
            
            HttpWebRequest request = WebRequest.Create(Settings.Default["EndPoint"].ToString()) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "";
            pasteText = HttpUtility.UrlEncode(pasteText);
            postData += "text="+pasteText;
            postData += "&lang=" + syntaxBox.SelectedValue;
            postData += "&title=" + titleBox.Text;

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
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
