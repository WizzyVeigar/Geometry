using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square : Shape
    {
        private float c;
        private float d;
        public float C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public float D
        {
            get
            {
                return d;
            }
            set
            {
                d = value;
            }
        }

        public Square(float a) : base(a)
        {
        }

        public Square(float a, float b) : base(a, b)
        {

        }

        public Square(float a, float b, float c, float d) : base(a, b)
        {
            this.C = c;
            this.D = d;
        }

        public override double Area()
        {
            return A * A;
        }

        public override double Perimeter()
        {
            return A + B + C + D;
        }
    }
}
