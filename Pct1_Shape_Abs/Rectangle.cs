using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracte
{
    class Rectangle : Shape
    {
        public Rectangle(double l, double w)
            : base(l, w)
        {

        }

        public override double GetArea()
        {
            return base.GetArea();
        }

        public override double GetPerimeter()
        {
            return base.GetPerimeter() * 2;
        }
    }
}
