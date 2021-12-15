using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2MVC_Beginner.Models
{
    public class Pokidetails
    {
        public int height { get; set; }
        public string name { get; set; }
        public PokiSprites sprite { get; set; }
        public double weight { get; set; }

    }

    public class PokiSprites
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
    }
}