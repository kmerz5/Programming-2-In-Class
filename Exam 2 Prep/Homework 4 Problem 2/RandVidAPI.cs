using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4_Problem_2
{
   public class RandVidAPI
    {
        public string description { get; set; }
        public string url { get; set;  }
        public string id { get; set; }


        public RandVidAPI()
        {
            description = string.Empty;
            url = string.Empty;
            id = string.Empty;
        }

        
    }
}
