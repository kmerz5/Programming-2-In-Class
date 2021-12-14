using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Beginner.Models
{
    public class PokemonAPI
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokiAPI
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<PokemonAPI>results { get; set; }
    }
}