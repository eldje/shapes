using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A01_winform.Models
{
    class Shapes
    {
        //all lists
        public BindingList<Shape> GreenShapes = new BindingList<Shape>();
        public BindingList<Shape> RedShapes = new BindingList<Shape>();
        public BindingList<Shape> OrangeShapes = new BindingList<Shape>();
        
        //move objects to list
        public void AddToList(Shape shape1)
        {
            if (shape1.Color == Color.Green)
                GreenShapes.Add(shape1);
            if (shape1.Color == Color.Green)
                RedShapes.Add(shape1);
            else
                OrangeShapes.Add(shape1);
        }

    }
}
