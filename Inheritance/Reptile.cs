using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile: Animal
    {
        public Reptile()
        {
        }

        public bool IsPoisonous { get; set; }
        public string Color { get; set; }
        public int LengthInFeet { get; set; }
        public string BiterOrConstrictor { get; set; }

    }
}
