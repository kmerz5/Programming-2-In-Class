using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6_Problem_1
{
    public class Cars
    {
        //vin,make,color,year,model,sale_price
        public string vin { get; set; }
        public string make { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public string model { get; set; }
        public string sale_price { get; set; }

        public Cars()
        {
            vin = string.Empty;
            make = string.Empty;
            color = string.Empty;
            year = 0;
            model = string.Empty;
            sale_price = string.Empty;
        }

        public Cars(string Vin, string Make, string Color, int Year, string Model, string Sale_Price)
        {
            vin = Vin;
            make = Make;
            color = Color;
            year = Year;
            model = Model;
            sale_price = Sale_Price;
        }

        public override string ToString()
        {
            return $"{year} {make} - {model}";
        }
    }
}
