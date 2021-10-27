using System;
using System.Collections.Generic;
using System.Text;

namespace GOT2
{
    public class GOTQUOTE
    {
        public string quote { get; set; }
        public string character { get; set; }


        public override string ToString()
        {
            return $"{quote} - {character}";
        }
    }

   
}
