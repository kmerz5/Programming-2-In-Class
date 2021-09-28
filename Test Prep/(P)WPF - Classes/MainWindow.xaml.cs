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

namespace _P_WPF___Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    /*Create a WPF application, add an image to the form of a toy from the internet to help make it look pretty.  Allow the user to enter the Manufacturer, Name, the Image (a URL to a picture) and Price of the Toy.
     * Once they have entered the information (Make sure that nothing is an empty String and that Price is in fact a double), the user will press a button to add the Toy to a ListBox.  Make sure to add the 
     * INSTANCE/OBJECT OF TYPE TOY to the ListBox.  The text that should display in the ListBox for the item should be in this format: "{Manufacturer} - {Name}".  The user should be able to double click an item 
     * (TOY) in the ListBox and a MessageBox will pop up with the Aisle that the Toy is found on as well as show the picture of the image (The value for the Image should be a URL to an image found on the internet).
     * To convert a URL to an Image, you can use  the following code
     * var uri = new Uri("");
     * var img = new BitmapImage(uri);

     To get the selected Toy, there is a property on a ListBox that will give you the one selected.  We will cast that selected item (it could be of ANY type, so we will explicitly tell it to treat it as a Toy)
    so that we can get all the properties about the toy.

    Toy selectedToy = (Toy)lstToys.SelectedItem;*/
    public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string manufacturer = txt_manufacturer.Text;
            string name = txt_toy.Text;
            string price = txt_price.Text;
            string url = txt_url.Text;

            Toy toy = new Toy(manufacturer, name, Convert.ToDouble(price), url);
            lstbx_output.Items.Add(toy);

            //Need to add the part for the double click and also changing the image.

        }

        private void lstbx_output_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Toy selectedToy = (Toy)lstbx_output.SelectedItem;
            MessageBox.Show(selectedToy.GetAisle());

            var uri = new Uri(selectedToy.Image);
            var img = new BitmapImage(uri);
            img_ToChange.Source = img;
        }
    }
}
