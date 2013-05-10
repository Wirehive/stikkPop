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

namespace stikkPop
{

    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pasteText = GetClipboardText();
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://paste.wirehive.net/api/create");
            request.Method = "POST";
            string boundary = Guid.NewGuid().ToString().Replace("-", "");
            request.ContentType = "multipart/form-data; boundary=" + boundary;

            string postData = string.Format("text=hello");
            byte[] post = Encoding.UTF8.GetBytes(postData);

            Stream stream = request.GetRequestStream();
            stream.Write(post, 0, post.Length);
            stream.Close();

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
    }
}
