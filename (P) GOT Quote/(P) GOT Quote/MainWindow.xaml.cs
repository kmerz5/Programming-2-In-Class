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

namespace _P__GOT_Quote
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_getquote_Click(object sender, RoutedEventArgs e)
        {
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(" https://got-quotes.herokuapp.com/quotes").Result;

                GOTAPI rand = JsonConvert.DeserializeObject<GOTAPI>(json);
                txt_quote.Text = $" \"{rand.quote}\"";



            }
        }

        private void btn_export_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
