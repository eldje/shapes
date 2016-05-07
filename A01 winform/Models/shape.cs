using System.Collections.Specialized;

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
        public abstract double Area { get; set; }
        private Color _Color;
        public Color Color
        {
            get
            {
                return _Color;
            }
            set
            {
                if (Area < 50)
                {
                    _Color = Color.Green;
                }
                if (Area > 100)
                {
                    _Color = Color.Red;
                }
                else
                {
                    _Color = Color.Orange;
                }
            }
        }
    }
}
