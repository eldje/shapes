namespace A01_winform.Models
{
    class Triangle : Shape
    {
        public Triangle(string name, int basis, int height) : base(name)
        {
            this.Basis = basis;
            this.Height = height;
            UpdateArea();
            SetColor();
        }

        public int Basis { get; set; }
        public int Height { get; set; }

        private void UpdateArea()
        {
            Area = Basis*Height;
        }
    }
}
