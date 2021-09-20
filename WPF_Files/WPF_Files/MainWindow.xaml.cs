using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPF_Files
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fileLocation = txtFile.Text;
            if (File.Exists(fileLocation) == true)
            {
                MessageBox.Show("Invalid file. Try again!");
                txtFile.Clear();
                return;
            }
            //Go look at GitHub for his code for the other example of importing a file by using a Class
            //also did an example of writing a file (which we wont need to do till later in semester)

            string[] fileContents = File.ReadAllLines(fileLocation);

            for (int i = 1; i < fileContents.Length; i++)
            {
                string line = fileContents[i];

                string[] pieces = line.Split(',');

                string paymentType = pieces[3];

                if (paymentType == "Mastercard")
                {
                    lstContents.Items.Add(line);

                }
               

            }
        }
    }
}
