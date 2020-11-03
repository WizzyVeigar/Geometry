using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Parallelogram : Quadrilateral
    {
        public Parallelogram(float a, float b, float thirdvalue) : base(a, b, thirdvalue)
        {
            SideC = thirdvalue;
        }


        /// <summary>
        /// SideC is used as degrees, for calculating Area of a Parallelogram
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return SideA * SideB * Math.Sin((Math.PI / 180) * SideC);
            //return Math.Sin(degrees * Math.PI / 180);
        }

        public override double Perimeter()
        {
            return 2 * SideA + 2 * SideB;
        }
    }
}
