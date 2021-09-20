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

namespace _P__WPF___Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
        }

        private void btn_enter_Click(object sender, RoutedEventArgs e)
        {
            string manufacturer, name, price, url;
            manufacturer = txt_Manufacturer.Text;
            name = txt_Name.Text;
            price = txt_price.Text;
            url = txt_URL.Text;

            Toy toy = new Toy(manufacturer, name, Convert.ToDouble(price), url);
            lstbx_Toys.Items.Add(toy);

        }

        private void lstbx_Toys_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //LOOK AT HIS CODE ON GITHUB HE ADDED THIS PORTION AND HOW TO CHANGE THE PHOTO
        }
    }
}
