using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracte
{
    public class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Shape(double x, double y)
        {
            X = x;
            Y = y;
        }

        public virtual double GetArea()
        {
            return X * Y;
        }

        public virtual double GetPerimeter()
        {
            return X + Y;
        }
    }
}
