using Newtonsoft.Json.Linq;
using stikkPop.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stikkPop
{
    class Imgur
    {
        const string ClientId = "6a67b5ef855d926";
        const string ClientSecret = "08ddad8a2e8a90efcd1d07f7c207238dddb93075";

        const string tokenEndpoint = "https://api.imgur.com/oauth2/token/";
        const string imageEndpoint = "https://api.imgur.com/3/image";

        public static string Upload(Image pasteImage)
        {
            string imagePath = Path.GetTempFileName();
            pasteImage.Save(imagePath, pasteImage.RawFormat);

            WebClient client = new WebClient();

            if ((bool)Settings.Default["imgurAuthenticated"] == true)
            {
                RefreshToken();
                client.Headers.Add("Authorization", "Bearer " + Settings.Default["imgurAccessToken"].ToString());
            }
            else
            {
                client.Headers.Add("Authorization", "Client-ID " + ClientId);
            }

            var values = new NameValueCollection
            {
                {"image", Convert.ToBase64String(File.ReadAllBytes(imagePath))}
            };

            try
            {
                byte[] responseArray = client.UploadValues(imageEndpoint, values);
                string json = Encoding.ASCII.GetString(responseArray);
                JObject o = JObject.Parse(json);
                string pasteURL = o["data"]["link"].ToString();
                return pasteURL;
            }
            catch (Exception)
            {
                MessageBox.Show("Error communicating with Imgur");
                return "";
            }

        }

        public static void RequestPin()
        {
            string OAuthUrlTemplate = "https://api.imgur.com/oauth2/authorize?client_id={0}&response_type={1}&state={2}";
            string RequestUrl = String.Format(OAuthUrlTemplate, ClientId, "pin", "stikkPop");

            System.Diagnostics.Process.Start(RequestUrl);
        }

        public static ImgurToken GetToken(string pin)
        {
            using (WebClient Client = new WebClient())
            {
                string access_token = String.Empty;
                string refresh_token = String.Empty;
                string expires_in = String.Empty;

                try
                {
                    byte[] ApiResponse = Client.UploadValues(tokenEndpoint, new NameValueCollection() {
                        { "client_id", ClientId },
                        { "client_secret", ClientSecret },
                        { "grant_type", "pin" },
                        { "pin", pin }
                    });

                    parseAuthResponse(ref access_token, ref refresh_token, ref expires_in, ApiResponse);
                    Settings.Default["imgurAuthenticated"] = true;
                }
                catch (WebException) { MessageBox.Show("Invalid PIN or service unavailable"); }

                return new ImgurToken()
                {
                    AccessToken = access_token,
                    RefreshToken = refresh_token,
                    ExpiresIn = expires_in
                };
            }
        }

        public static void RefreshToken()
        {
            if ((DateTime)Settings.Default["imgurTokenExpires"] > DateTime.Now)
            {
                return;
            }

            using (WebClient Client = new WebClient())
            {
                string access_token = String.Empty;
                string refresh_token = Settings.Default["imgurRefreshToken"].ToString();
                string expires_in = String.Empty;

                try
                {
                    byte[] ApiResponse = Client.UploadValues(tokenEndpoint, new NameValueCollection() {
                        { "client_id", ClientId },
                        { "client_secret", ClientSecret },
                        { "grant_type", "refresh_token" },
                        { "refresh_token", refresh_token }
                    });

                    parseAuthResponse(ref access_token, ref refresh_token, ref expires_in, ApiResponse);

                    Settings.Default["imgurAccessToken"] = access_token;
                    Settings.Default["imgurRefreshToken"] = refresh_token;
                    Settings.Default["imgurTokenExpires"] = DateTime.Now.AddSeconds(Convert.ToDouble(expires_in) - 120);
                }
                catch (WebException) { }
            }
        }

        private static void parseAuthResponse(ref string access_token, ref string refresh_token, ref string expires_in, byte[] ApiResponse)
        {
            string json = Encoding.ASCII.GetString(ApiResponse);
            JObject o = JObject.Parse(json);
            access_token = o["access_token"].ToString();
            refresh_token = o["refresh_token"].ToString();
            expires_in = o["expires_in"].ToString();
        }
    }

    public class ImgurToken
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string ExpiresIn { get; set; }
    }
}
