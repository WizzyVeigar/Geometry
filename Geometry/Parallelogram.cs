using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Parallelogram : Quadrilateral
    {
        private float degrees;

        public float Degrees
        {
            get
            {
                return degrees;
            }
            set
            {
                degrees = value;
            }
        }

        public Parallelogram(float a, float b, float degrees) : base(a, b)
        {
            Degrees = degrees;
        }


        public override double Area()
        {
            return SideA * SideB * Math.Sin((Math.PI / 180) * Degrees);
            //return Math.Sin(degrees * Math.PI / 180);
        }

        public override double Perimeter()
        {
            return 2 * SideA + 2 * SideB;
        }
    }
}
