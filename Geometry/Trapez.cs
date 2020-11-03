using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Trapez : Quadrilateral
    {
        public Trapez(float a, float b, float thirdValue) : base(a, b, thirdValue)
        {
            SideC = thirdValue;
            SideD = thirdValue;
        }
        /// <summary>
        /// Finding the length of the side, used for calculating the height
        /// </summary>
        /// <returns></returns>
        private float FindS()
        {
            return (SideA + SideC - SideB + SideD) / 2;
        }

        /// <summary>
        /// Finds the height of the Trapez, used for calculating Area
        /// </summary>
        /// <returns></returns>
        private double FindHeight()
        {
            float s = FindS();
            return 2 / (SideA - SideB) * Math.Sqrt(s * (s - SideA + SideB) * (s - SideC) * (s - SideD));
            ///*return 2 / (A - B) */  return Math.Sqrt(10 * (10 - 10 + 8) * (10 - 9) * (10 - 9));
        }

        public override double Area()
        {

            return 0.5 * FindHeight() * (SideA + SideB);
        }

        public override double Perimeter()
        {
            return SideA + SideB + 2 * SideC;
        }
    }
}
