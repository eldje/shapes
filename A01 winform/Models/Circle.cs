using System;

namespace A01_winform.Models
{
    class Circle : Shape
    {
        public Circle(string name, int radius) : base(name)
        {
            this.Radius = radius;
            UpdateArea();
            SetColor();
        }

        public int Radius { get; set; }

        private void UpdateArea()
        {
            Area = Math.PI*Math.Pow(Radius, 2);
        }
    }
}
