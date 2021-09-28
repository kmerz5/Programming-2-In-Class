using Microsoft.Win32;
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

namespace FulfillData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //create a dictionary to hold everything in
        private Dictionary<string, List<Data>> DataSet = new Dictionary<string, List<Data>>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_pick_dataset_Click(object sender, RoutedEventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = path;
            ofd.Filter = "Coma Seperated Value Documents (.csv) | *.csv";

            if (ofd.ShowDialog() == true)
            {
                //We need to populate the data
                PopulateData(ofd.FileName);

                //Populate the list boxes for each category of fulfillment
                PopulateListBox("Male", lbx_males);
                PopulateListBox("Female", lbx_females);
                PopulateListBox("Both", lbx_both);

                //populate the list box for the mean >= 8
                PopulateListBoxForMeanGreaterThan();


            }


        }

        private void PopulateListBoxForMeanGreaterThan()
        {
            double mean = 8;
            //For each of the genders in each state if the gender is "both" then we want to see if the Mean in the data is >= 8 if so then add that state to the list box

            foreach (var state in DataSet.Keys)
            {
                foreach (var gend in DataSet[state])
                {
                    if ("both".ToLower() == gend.Gender.ToLower())
                    {
                        if (gend.Mean >= mean)
                        {
                            lbx_mean.Items.Add(state);

                        }

                    }

                }

            }

        }

        private void PopulateListBox(string gender, ListBox lst)
        {
            //We need to find the maximum which will give us the state with the maximum for each category
            double max = 0;
            foreach (var item in DataSet.Keys)
            {
                foreach (var gend in DataSet[item])
                {
                    //if the gender entered (to lower) = gend(variable created in the foreach statement)- so looking at each gender in the dataset
                    //gender entered = gender in the data set
                    if (gender.ToLower() == gend.Gender.ToLower())
                    {
                        //then see if the mean correlated to that gender is greater than the max
                        if (gend.Mean > max)
                        {
                            //if it is greater than the max then it becomes the new max and continues through untill we go through every mean in the dataset
                            max = gend.Mean;

                        }

                    }

                }

            }

            //Going through to see which state has this max number and then adding it to the list
            foreach (var state in DataSet.Keys)
            {
                foreach (var gend in DataSet[state])
                {
                    if (gender.ToLower() == gend.Gender.ToLower())
                    {
                        if (gend.Mean == max)
                        {
                            lst.Items.Add(state);

                        }

                    }

                }

            }
        }

        private void PopulateData(string fileName)
        {
            var lines = File.ReadAllLines(fileName);

            string state = "";
            for (int i = 1; i < lines.Length; i++)
            {
                //reading in the file and splitting it on the ,
                var line = lines[i];
                var pieces = line.Split(',');

                //basically saying if the string is not blank then state is equal to pieces at [0]
                if (string.IsNullOrWhiteSpace(pieces[0]) == false)
                {
                    state = pieces[0];

                }

                //Basically saying that if these are the types they need to be then continue on
                double mean;
                int pop;
                if (double.TryParse(pieces[2], out mean) == false)
                {
                    continue;

                }
                if (int.TryParse(pieces[3], out pop) == false)
                {
                    continue;

                }

                //This is saying if the dataset does not already contain the state, the to add it to the Dictionary as a new list
                if (DataSet.ContainsKey(state) == false)
                {
                    DataSet.Add(state, new List<Data>());

                }

                //This is adding all the different types and setting them equal to their variables and correspond to the class
                DataSet[state].Add(new Data()
                {
                    State = state,
                    Gender = pieces[1],
                    Mean = mean,
                    Population = pop

                });

            }
        }
    }
}
