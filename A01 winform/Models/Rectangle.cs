namespace A01_winform.Models
{
    class Rectangle : Shape
    {
        public Rectangle(string name, int width, int height) : base(name)
        {
            this.Width = width;
            this.Height = height;
            UpdateArea();
            SetColor();
        }

        public int Width { get; set; }
        public int Height { get; set; }

        private void UpdateArea()
        {
            Area = Width * Height;
        }
    }
}
