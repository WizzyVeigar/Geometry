using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Geometry
{
    public class Triangle : Solid
    {
        public Triangle(float a, float b) : base(a, b)
        {

        }

        public override double Area()
        {
            return 0.5 * SideA * SideB;
        }

        public double FindSideC()
        {
            return Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
        }

        public override double Perimeter()
        {
            return SideA + SideB + FindSideC();
        }
    }
}