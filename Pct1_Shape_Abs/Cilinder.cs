using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracte
{
    class Cilinder : Circle
    {
        public double Height { get; set; }

        public Cilinder(double height, double radius)
            : base(radius)
        {
            Height = height;
        }

        public override double GetArea()
        {
            return base.GetArea() * 2 + 2 * Math.PI * Radius * Height;
        }
    }
}
