using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_2_Prep
{
    public class GOTAPI
    {
        public string quote { get; set; }
        public string character { get; set; }


        public override string ToString()
        {
            return $"{quote} - {character}";
        }
    }
}
