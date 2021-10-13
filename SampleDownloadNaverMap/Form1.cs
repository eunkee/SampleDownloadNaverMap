using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace SampleDownloadNaverMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxClientKey.Text = RegistryDownloadNaverMap.ClientKey;
            TextBoxClientSecret.Text = RegistryDownloadNaverMap.ClientSecret;
            TextBoxLatitude.Text = RegistryDownloadNaverMap.Latitude;
            TextBoxLongitude.Text = RegistryDownloadNaverMap.Longitude;
            TextBoxImageWidth.Text = RegistryDownloadNaverMap.ImageWidth.ToString();
            TextBoxImageHeight.Text = RegistryDownloadNaverMap.ImageHeight.ToString();
            TextBoxZoomLevel.Text = RegistryDownloadNaverMap.ZoomLevel.ToString();
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            #region Exception: Download
            if (TextBoxClientKey.Text.Length <= 0)
            {
                Console.WriteLine("Failed: Client Key Lenght");
                return;
            }
            if (TextBoxClientSecret.Text.Length <= 0)
            {
                Console.WriteLine("Failed: Client Secret Lenght");
                return;
            }
            if (TextBoxLatitude.Text.Length <= 0)
            {
                Console.WriteLine("Failed: Latitude Lenght");
                return;
            }
            if (TextBoxLongitude.Text.Length <= 0)
            {
                Console.WriteLine("Failed: Longitude Lenght");
                return;
            }
            if (TextBoxImageWidth.Text.Length <= 0)
            {
                Console.WriteLine("Failed: Image Width Lenght");
                return;
            }
            if (TextBoxImageHeight.Text.Length <= 0)
            {
                Console.WriteLine("Failed: Image Height Lenght");
                return;
            }
            if (TextBoxZoomLevel.Text.Length <= 0)
            {
                Console.WriteLine("Failed: Zoom Level Lenght");
                return;
            }
            string clientKey = TextBoxClientKey.Text;
            string clientSecret = TextBoxClientSecret.Text;
            string latitude = TextBoxLatitude.Text;
            string longitude = TextBoxLongitude.Text;
            if (!double.TryParse(latitude, out double _ ))
            {
                Console.WriteLine("Failed: latitude Data Type");
                return;
            }
            if (!double.TryParse(longitude, out double _ ))
            {
                Console.WriteLine("Failed: longitude Data Type");
                return;
            }
            if (!int.TryParse(TextBoxImageWidth.Text, out int imageWidth))
            {
                Console.WriteLine("Failed: Image Width Data Type");
                return;
            }
            if (!int.TryParse(TextBoxImageHeight.Text, out int imageHeight))
            {
                Console.WriteLine("Failed: Image Height Data Type");
                return;
            }
            if (!int.TryParse(TextBoxZoomLevel.Text, out int zoomLevel))
            {
                Console.WriteLine("Failed: Zoom Level Data Type");
                return;
            }
            #endregion Exception: Download

            var task0 = Task.Run(() => MapDownload(clientKey, clientSecret, latitude, longitude, imageWidth, imageHeight, zoomLevel));
            task0.ContinueWith(x =>
            {
                RegistryDownloadNaverMap.ClientKey = clientKey;
                RegistryDownloadNaverMap.ClientSecret = clientSecret;
                RegistryDownloadNaverMap.Latitude = latitude;
                RegistryDownloadNaverMap.Longitude = longitude;
                RegistryDownloadNaverMap.ImageWidth = imageWidth;
                RegistryDownloadNaverMap.ImageHeight = imageHeight;
                RegistryDownloadNaverMap.ZoomLevel = zoomLevel;

            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public void MapDownload(string clientKey, string clientSecret, string latitude, string longitude, int imageWidth, int imageHeight, int zoomLevel)
        {
            string restAddr = $"https://naveropenapi.apigw.ntruss.com/map-static/v2/raster?" +
                $"w={imageWidth}&h={imageHeight}&center={longitude},{latitude}&level={zoomLevel}&format=png";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(restAddr);
            request.Headers.Add("X-NCP-APIGW-API-KEY-ID", clientKey);
            request.Headers.Add("X-NCP-APIGW-API-KEY", clientSecret);

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine($"StatusCode: {response.StatusCode}");
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream ReceiveStream = response.GetResponseStream();
                    Image img = System.Drawing.Image.FromStream(ReceiveStream);
                    img.Save(@"map.png", System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
