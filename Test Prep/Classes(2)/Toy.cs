using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_2_
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        private string Aisle;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0.0;
            Image = string.Empty;
            Aisle =  GetAisle();
        }

        public Toy(string manufacturer, string name, double price, string image)
        {
            Manufacturer = manufacturer;
            Name = name;
            Price = price;
            Image = image;
            Aisle = GetAisle();

        }


        public string GetAisle()
        {
            return $"{Manufacturer.ToUpper()[0]}{Price.ToString()}";


        }

        public override string ToString()
        {
            return $"{ Manufacturer} - {Name} ";
        }
    }
}
