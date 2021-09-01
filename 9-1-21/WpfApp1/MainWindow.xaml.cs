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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lblOutput.Visibility = Visibility.Hidden;
            lblNameReturn.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int age = Convert.ToInt32(txtAge.Text);


            DateTime today = DateTime.Now;
            int birthYear = today.Year - age;

            // MessageBox.Show($"You were born in {birthYear.ToString("N0")}");

            lblOutput.Content = $"You were born in {birthYear.ToString("N0")}";
            lblOutput.Visibility = Visibility.Visible;


            string name = txtName.Text;
            string response = $"{name} is a beautiful name!";

            lblNameReturn.Content = response;
            lblNameReturn.Visibility = Visibility.Visible;
        }
    }
}
