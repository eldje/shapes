namespace A01_winform.Models
{
    class Rectangle : Shape
    {
        public Rectangle(string name, int width, int height) : base(name)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }
        private double _Area;
        public override double Area
        {
            get { return _Area; }
            set { _Area = Width * Height; }
        }
    }
}
