namespace A01_winform.Models
{
    class Rectangle : Shape
    {
        public Rectangle(string name, double width, double height) : base(name)
        {
            this.Width = width;
            this.Height = height;
            UpdateArea();
            SetColor();
        }

        public double Width { get; set; }
        public double Height { get; set; }

        private void UpdateArea()
        {
            Area = Width * Height;
        }
    }
}
