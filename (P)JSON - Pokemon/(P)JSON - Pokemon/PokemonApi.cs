using System;
using System.Collections.Generic;
using System.Text;

namespace _P_JSON___Pokemon
{

    public class PokemonApi
    {
        public int count { get; set; }
        
        public List<Data> results { get; set; }

        

    }

    public class Data
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
