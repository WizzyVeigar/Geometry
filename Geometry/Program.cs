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
            List<Solid> allShapes = new List<Solid>();
            //for (int i = 0; i < 20; i++)
            //{
                allShapes.Add(new Rektangel(40,10));
                allShapes.Add(new Quadrilateral(10));
                allShapes.Add(new Parallelogram(3, 5, 20));
                allShapes.Add(new Triangle(2, 3.1415f));
                allShapes.Add(new Trapez(1.998f, 2.42f, 4.34235f));
            //}

            foreach (Solid shape in allShapes)
            {
                Console.WriteLine(shape.GetType().Name + ": " + "\n" + shape.Area() + "\n" + shape.Perimeter() + "\n");
            }

            Console.ReadKey();
        }
    }
}
