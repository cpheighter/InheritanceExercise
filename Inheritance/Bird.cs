using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public string TypeOfBird { get; set; } 
        public double WingSpan { get; set; }
        public bool CanSwin { get; set; }
        public string FavoriteFood { get; set; }
    }
}
