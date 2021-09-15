﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _P__WPF___Classes
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
            Aisle = string.Empty;
        }

        public string GetAisle()
        {
            char output = Manufacturer.ToUpper()[0];
            return $"{output}{Price}";
           
        }
    }
}