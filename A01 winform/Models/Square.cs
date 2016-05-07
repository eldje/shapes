using System;
using System.Windows.Forms;

namespace A01_winform.Models
{
    class Square : Shape
    {
        public Square(string name, int side) : base(name)
        {
            this.Side = side;
        }

        public int Side { get; set; }
        private double _Area;
        public override double Area
        {
            get { return _Area; }
            set { _Area = Math.Pow(Side,2); }
        }
    }
}
