using System;

namespace A01_winform.Models
{
    class Square : Shape
    {
        public Square(string name, int side) : base(name)
        {
            this.Side = side;
            UpdateArea();
            SetColor();
        }

        public int Side { get; set; }
        private void UpdateArea()
        {
            Area = Math.Pow(Side, 2);
        }
    }
}
