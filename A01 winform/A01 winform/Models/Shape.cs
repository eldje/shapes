using System.Runtime.InteropServices;

namespace A01_winform.Models
{
    enum Color
    {
        Red,
        Orange,
        Green
    };

    abstract class Shape
    {
        public Shape(string name)
        {
            this.Name = name;
            this.Area = 0;
            this.Color = Color.Red;
        }
        public string Name { get; set; }
        public double Area { get; set; }
        public Color Color { get; set; }
        
        public override string ToString()
        {
            return Name;
        }
        protected void SetColor()
        {
            if (Area < 50)
            {
                Color = Color.Green;
            }
            else if (Area > 100)
            {
                Color = Color.Red;
            }
            else
            {
                Color = Color.Orange;
            }
        }
    }
}
