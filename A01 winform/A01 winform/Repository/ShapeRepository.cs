using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A01_winform.Models;

namespace A01_winform.Repository
{
    enum ShapeForm
    {
        Circle,
        Rectangle,
        Square,
        Triangle
    }
    class ShapeRepository
    {
        public List<Shape> Shapes { get; set; } = new List<Shape>();

        public void AddShape(ShapeForm shapeForm, string name, params double[] args)
        {
            switch (shapeForm)
            {
                case ShapeForm.Circle:
                    Shapes.Add(new Circle(name, args[0]));
                    break;
                case ShapeForm.Square:
                    Shapes.Add(new Square(name, args[0]));
                    break;
                case ShapeForm.Triangle:
                    Shapes.Add(new Triangle(name, args[0], args[1]));
                    break;
                case ShapeForm.Rectangle:
                    Shapes.Add(new Rectangle(name,args[0], args[1]));
                    break;
            }
        }
    }
}
