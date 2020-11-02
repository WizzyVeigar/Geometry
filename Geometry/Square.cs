using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square : Quadrilateral
    {
        public Square(float sideA) : base(sideA)
        {
            SideB = sideA;
            SideC = sideA;
            SideD = sideA;
        }

        public override double Area()
        {
            return SideA * SideA;
        }

        public override double Perimeter()
        {
            return SideA * 4;
        }
    }
}
