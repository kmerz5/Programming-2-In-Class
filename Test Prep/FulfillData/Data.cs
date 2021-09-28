using System;
using System.Collections.Generic;
using System.Text;

namespace FulfillData
{
    public class Data
    {
        public string State {get;set;}
        public string Gender {get;set;}
        public double Mean {get;set;}
        public int Population { get; set; }


        public Data()
        {
            State = string.Empty;
            Gender = string.Empty;
            Mean = 0.0;
            Population = 0;
        }

    }
}
