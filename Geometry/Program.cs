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
                allShapes.Add(new Square(10));
                allShapes.Add(new Parallelogram(3, 5, 20));
                allShapes.Add(new Right_Triangle(2, 5));
                allShapes.Add(new Trapez(10,8,9));
            //}

            foreach (Solid shape in allShapes)
            {
                Console.WriteLine(shape.GetType().Name + ": " + "\n" + shape.Area() + "\n" + shape.Perimeter() + "\n");
            }

            Console.ReadKey();
        }
    }
}
