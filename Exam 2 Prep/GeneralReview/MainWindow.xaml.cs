using System;
using System.Collections.Generic;
using System.Linq;
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

namespace GeneralReview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //HOW TO DESERIALIZE AN OBJECT
            //--------------------------------------------------------------------------------------------------------------------------------
            /*
             * using (var client = new HttpClient())
             * {
             * var response = clinet.GetAsync("URL").Result;
             * if (response.StatusCode == System.Net.HttpStatusCode.OK)
             * {
             * string json = response.Content.ReadAsStringAsync().Result;
             * CLASSNAME VARIABLE = JsonConvert.DeserializeObject<CLASSNAME>(json);
             */



            //HOW TO SERIALIZE AN OBJECT
            //--------------------------------------------------------------------------------------------------------------------------------
            /*
             string json = JsonConvert.SerializeObject(LIST or LBX);
             File.WriteAllText("NAME OF FILE GIVEN", json);
             */


            //HOW TO CREATE ANOTHER WINDOW
            //----------------------------------------------------------------------------------------------------------------------------------
            /*
             WindowDetails VARIABLE = new WindowDetails();
             VARIABLE.SetData(selected); --> THIS IS A METHOD IN THE NEW WINDOW
             VARIABLE.ShowDialog();
             */

            //HOW TO PUT IN AN IMAGE
            //---------------------------------------------------------------------------------------------------------------------------------
            /*
             img_dog.Source = new BitmapImage(new Uri(dogs.message));
              NAME OF IMG                             VARIABLE DECLARED, CORRESPONDING THE THE ITEM IN THE CLASS THATS NEEDED
             */


            //HOW TO GET A VIDEO
            //---------------------------------------------------------------------------------------------------------------------------------
            /*
             media_video.Source = new Uri(video.url);
                                          VARIABLE DECLARED, CORRESPONDING THE THE ITEM IN THE CLASS THATS NEEDED
             */
        }
    }
}
