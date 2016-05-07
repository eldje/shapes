namespace A01_winform.Models
{
    class Triangle : Shape
    {
        public Triangle(string name, int basis, int height) : base(name)
        {
            this.Basis = basis;
            this.Height = height;
        }

        public int Basis { get; set; }
        public int Height { get; set; }
        private double _Area;
        public override double Area
        {
            get { return _Area; }
            set { _Area = (Height*Basis)/2 ; }
        }
    }
}
