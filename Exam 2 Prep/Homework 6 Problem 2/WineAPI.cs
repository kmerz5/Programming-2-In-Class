using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6_Problem_2
{
    public class WineAPI
    {
        public string id { get; set; }
        public string country { get; set; }
        public double price { get; set; }
        public string title { get; set; }

        public override string ToString()
        {
            return $"{title} - {price} - {country}";

        }
    }
}
