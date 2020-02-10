using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Parallelogram : Square
    {
        private float degrees;
        public Parallelogram(float a, float b, float degrees) : base(a, b)
        {
            this.Degrees = degrees;
        }

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


        public override double Area()
        {
            return Math.Sin(degrees * Math.PI / 180);
        }

        public override double Perimeter()
        {
            return 2 * A + 2 * B;
        }
    }
}
