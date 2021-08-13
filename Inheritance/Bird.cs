using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird: Animal
    {
        public Bird()
        {
        }

        public long NumberOfFeathers { get; set; }
        public string Color { get; set; }
        public int NumberOfWings { get; set; }
        public string LongOrShortBeak { get; set; }

    }
}
