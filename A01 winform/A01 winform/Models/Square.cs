using System;

namespace A01_winform.Models
{
    class Square : Shape
    {
        public Square(string name, double side) : base(name)
        {
            this.Side = side;
            UpdateArea();
            SetColor();
        }

        public double Side { get; set; }
        private void UpdateArea()
        {
            Area = Math.Pow(Side, 2);
        }
        public override string ToString()
        {
            return Name + " (" + Area + ")";
        }
    }
}
