using Newtonsoft.Json;
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

namespace Homework_6_Problem_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    /*You will be creating a GUI to allow the user to filter down their data set and then export all the data as a .json file format.  
     * Add the car_sales.csv  
     * 
     * 1. Download car_sales.csvfile to your project and then let the user select between all the unique color options that exist in the cars
     * (or have the option to select All) from a ComboBox. DONE 
     * 
     * Also, allow the user to type in a value for a year as well as a whether they want all sales Equal to, Less than or Equal to, 
     * or Greater than or Equal to the year they entered (e.g. If they entered 2005 and Less than or Equal to, you would filter out any car for a sale that is 2006 or newer). 
     * When the user presses a button, take all of the input from the user into account and filter out the results and add all of the records that match the criteria to a ListBox 
     * (Sales should be displayed as "{Year} {Make} - {Model}").  Below the ListBox, have a label that shows the number of items displayed in the ListBox.  Wherever you think it is appropriate, 
     * place a button to export the contents of the ListBox to a file named Car_Sales.json in the directory where the application is running.*/
    public partial class MainWindow : Window
    {
        List<Cars> allcars = new List<Cars>();
        List<string> ALLCARS = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            cbx_color.Items.Add("All");
            cbx_otheryears.Items.Add("Equal to Typed Year");
            cbx_otheryears.Items.Add("Greater than or Equal to Typed Year");
            cbx_otheryears.Items.Add("Less than or Equal to Typed Year");
            //vin,make,color,year,model,sale_price
            string[] lines = File.ReadAllLines("car_sales (1).csv").Skip(1).ToArray();
            foreach (var line in lines)
            {
                string[] pieces = line.Split(',');
                string Vin = pieces[0];
                string Make = pieces[1];
                string Color = pieces[2];
                string years = pieces[3];
                int Year = Convert.ToInt32(years);
                string Model = pieces[4];
                string Sale_Price = pieces[5];

                Cars car = new Cars(Vin, Make, Color, Year, Model, Sale_Price);
                allcars.Add(car);


            }

            foreach (var col in allcars)
            {
                if (cbx_color.Items.Contains(col.color) == false)
                {
                    cbx_color.Items.Add(col.color);

                }

            }
        }

        private void btn_showcars_Click(object sender, RoutedEventArgs e)
        {
            string carcolor = cbx_color.SelectedItem.ToString();
            int caryear = Convert.ToInt32(txt_year.Text);
            string othercaryears = cbx_otheryears.SelectedItem.ToString();

            foreach (var carinfo in allcars)
            {
                if (othercaryears == "Equal to Typed Year")
                {
                    if (carinfo.color == carcolor && carinfo.year == caryear)
                    {
                        lbx_results.Items.Add(carinfo);
                        ALLCARS.Add(carinfo.ToString());

                    }

                }
                else if (othercaryears == "Greater than or Equal to Typed Year")
                {
                    if (carinfo.color == carcolor && carinfo.year >= caryear)
                    {
                        lbx_results.Items.Add(carinfo);
                        ALLCARS.Add(carinfo.ToString());

                    }

                }
                else if (othercaryears == "Less than or Equal to Typed Year")
                {
                    if (carinfo.color == carcolor && carinfo.year <= caryear)
                    {
                        lbx_results.Items.Add(carinfo);
                        ALLCARS.Add(carinfo.ToString());

                    }

                }

                txt_resultcount.Text = (lbx_results.Items.Count.ToString());
                

            }
        }

        private void btn_export_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(ALLCARS);
            File.WriteAllText("Car_Sales.Json", json);
        }
    }
}
