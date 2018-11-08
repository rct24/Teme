//1. Creează clasa Shape cu două metode virtuale: GetPerimeter și GetArea.
//Toate formele geometrice moștenesc(direct sau indirect) clasa Shape.
//Creează clase care să modeleze cercuri, dreptunghiuri, pătrate și cilindrii.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracte
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            Console.WriteLine("Circle: ");
            Console.WriteLine(Math.Round(c.GetArea(), 2));
            Console.WriteLine(Math.Round(c.GetPerimeter(), 2));

            Rectangle r = new Rectangle(2, 3);
            Console.WriteLine("Rectangle: ");
            Console.WriteLine(r.GetArea());
            Console.WriteLine(r.GetPerimeter());

            Square s = new Square(5);
            Console.WriteLine("Square: ");
            Console.WriteLine(s.GetArea());
            Console.WriteLine(s.GetPerimeter());

            Cilinder cil = new Cilinder(10, 5);
            Console.WriteLine(Math.Round(cil.GetArea(), 2));
            //cil.GetPerimeter(); cum pot face ca sa nu-i mai dau acces lui cil la GetPerimeter() de la circle? 
        }
    }
}
