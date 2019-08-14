using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Geometry
{
    public class Triangle : Shape
    {
        public Triangle(float a, float b) : base(a, b)
        {

        }

        public override double Areal()
        {
            return 0.5 * A * B;
        }

        public double FindSideC()
        {
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }

        public override double Perimeter()
        {
            return A + B + FindSideC();
        }
    }
}