using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> allShapes = new List<Shape>();
            for (int i = 0; i < 20; i++)
            {
                allShapes.Add(new Rektangel(40));
                allShapes.Add(new Square(10));
                allShapes.Add(new Parallelogram(3, 5, 20));
                allShapes.Add(new Triangle(2, 3.1415f));
                allShapes.Add(new Trapez(1.998f, 2.42f, 4.34235f));
            }

            foreach (Shape shape in allShapes)
            {
                Console.WriteLine(shape.GetType().Name + ": " + "\n" + shape.Areal() + "\n" + shape.Perimeter() + "\n");
            }

            Console.ReadKey();
        }
    }
}
