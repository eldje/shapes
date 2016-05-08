namespace A01_winform.Models
{
    class Triangle : Shape
    {
        public Triangle(string name, double basis, double height) : base(name)
        {
            this.Basis = basis;
            this.Height = height;
            UpdateArea();
            SetColor();
        }

        public double Basis { get; set; }
        public double Height { get; set; }

        private void UpdateArea()
        {
            Area = Basis*Height;
        }
        public override string ToString()
        {
            return Name + " (" + Area + ")";
        }
    }
}
