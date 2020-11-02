using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Right_Triangle : Triangle
    {
        public Right_Triangle(float a, float b) : base(a, b)
        {
        }

        public Right_Triangle(float a, float b, float c) : base(a, b, c)
        {
        }

        public override double Perimeter()
        {
            if (SideC == 0)
            {
                return SideA + SideB + FindSideC();
            }
            else
            {
                return SideA + SideB + SideC;
            }
        }
    }
}
