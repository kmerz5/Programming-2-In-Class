using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework_4_Problem_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    /*For this problem, you will be using a webservice to get a random video to play.  
     * The webservice can be found at : http://pcbstuou.w27.wh-2.com/webservices/3033/api/random/video (Links to an external site.) . 
     * You will want to have a button to get a random video from the webservice for the user to press as well as a play and stop button.  
     * When the video is playing, the play button should double as a pause button and should change the text to reflect the available option. */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn_play_pause.IsEnabled = false;
            btn_stop.IsEnabled = false;
            media_video.LoadedBehavior = MediaState.Manual;
        }

        private void btn_getvideo_Click(object sender, RoutedEventArgs e)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("http://pcbstuou.w27.wh-2.com/webservices/3033/api/random/video ").Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    RandVidAPI video = JsonConvert.DeserializeObject<RandVidAPI>(json);
                    media_video.Source = new Uri(video.url);
                    btn_play_pause.Content = "Play";
                    btn_play_pause.IsEnabled = true;
                    btn_stop.IsEnabled = true;
                }

            }

            
        }

        private void btn_play_pause_Click(object sender, RoutedEventArgs e)
        {
            string status = btn_play_pause.Content.ToString().ToLower();
            switch (status)
            {
                case "play":
                    media_video.Play();
                    btn_play_pause.Content = "Pause";
                    break;

                case "pause":
                    media_video.Pause();
                    btn_play_pause.Content = "Play";
                    break;
                default:
                    break;
            }
        }

        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {
            media_video.Stop();
        }
    }
}
