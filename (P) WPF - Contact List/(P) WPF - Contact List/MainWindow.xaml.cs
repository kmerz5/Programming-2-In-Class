﻿using System;
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

namespace _P__WPF___Contact_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*string[] fileContents = File.ReadAllLines(fileLocation);

            for (int i = 1; i < fileContents.Length; i++)
            {
                string line = fileContents[i];

                string[] pieces = line.Split(',');

                string paymentType = pieces[3];*/

            string[] fileContents = System.IO.File.ReadAllLines("contacts.txt");

            for (int i = 1; i < fileContents.Length; i++)
            {
                string line = fileContents[i];
                string[] pieces = line.Split('|');

                string id = pieces[0];
                double ID = Convert.ToDouble(id);
                string firstName = pieces[1];
                string lastName = pieces[2];
                string email = pieces[3];
                string photo = pieces[4];

                Contact information = new Contact(ID, firstName, lastName, email, photo);
                lstbx_output.Items.Add(information);

            }
            }
           
    }
}
