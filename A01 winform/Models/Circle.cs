using System;
using System.Runtime.InteropServices;

namespace A01_winform.Models
{
    class Circle : Shape
    {
        public Circle(string name, int radius) : base(name)
        {
            this.Radius = radius;
        }

        public int Radius { get; set; }
        private double _Area;
        public override double Area
        {
            get { return _Area; }
            set { _Area = Math.PI * Math.Pow(Radius, 2); }
        }
    }
}
