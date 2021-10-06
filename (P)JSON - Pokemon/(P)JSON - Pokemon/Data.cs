using System;
using System.Collections.Generic;
using System.Text;

namespace _P_JSON___Pokemon
{
    public class Data
    {
        public List<string> result { get; set; }
        public string name { get; set; }
        public string url { get; set; }


        public override string ToString()
        {
            return $"{name}";
        }
    }
}
