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

namespace Classes_2_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*Create a WPF application, ----DONE----
             * Create the class ----DONE----
             * add an image to the form of a toy from the internet to help make it look pretty. ----DONE---- 
             * Allow the user to enter the Manufacturer, Name, the Image (a URL to a picture) and Price of the Toy. ----DONE---- 
             * Once they have entered the information (Make sure that nothing is an empty String and that Price is in fact a double), ----DONE---- 
             * the user will press a button to add the Toy to a ListBox. ----DONE--- 
             * Make sure to add the INSTANCE/OBJECT OF TYPE TOY to the ListBox. ----DONE----
             * The text that should display in the ListBox for the item should be in this format: "{Manufacturer} - {Name}".  ----DONE----
             * 
             * 
             * The user should be able to double click an item (TOY) in the ListBox and a MessageBox will pop up with the Aisle that the Toy is found on as well as show the picture of the image 
             * (The value for the Image should be a URL to an image found on the internet).  To convert a URL to an Image, you can use  the following code.
             var uri = new Uri("");
             var img = new BitmapImage(uri);*/
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_manufacturer.Text) == true)
            {
                MessageBox.Show("You must enter a valid manufacturer");
                return;
            }

            if (string.IsNullOrEmpty(txt_name.Text) == true)
            {
                MessageBox.Show("You must enter a valid toy name");
                return;

            }

            if (string.IsNullOrEmpty(txt_image.Text)== true)
            {
                MessageBox.Show("You must enter a valid URL");
                return;

            }

            double price;
            if (double.TryParse(txt_price.Text, out price) == false)
            {
                MessageBox.Show("You must enter a valid toy price");
                return;

            }

            string manufacturer = txt_manufacturer.Text;
            string name = txt_name.Text;
            string image = txt_image.Text;

            Toy toys = new Toy(manufacturer, name, price, image);
            lbx_output.Items.Add(toys);
        }

        private void lbx_output_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //have to say that selected is part of Toy in order for it to recognize GetAisle
            Toy selectedToy = (Toy)lbx_output.SelectedItem;
            MessageBox.Show(selectedToy.GetAisle());

            var uri = new Uri(selectedToy.Image);
            var img = new BitmapImage(uri);
            img_toy.Source = img;

            


        }
    }
}
