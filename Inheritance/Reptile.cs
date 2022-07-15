using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool HasShell { get; set; } 
        public double Weight { get; set; }
        public string Color { get; set; }
        public int NumberOfTeeth { get; set; }
    }
}
