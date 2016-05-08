using System;

namespace A01_winform.Models
{
    class Circle : Shape
    {
        public Circle(string name, double radius) : base(name)
        {
            this.Radius = radius;
            UpdateArea();
            SetColor();
        }
        public double Radius { get; set; }

        private void UpdateArea()
        {
            Area = Math.PI*Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return Name + " (" + Area + ")";
        }
    }
}
