using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    //Rounded shapes are any shape with a rounded side
    abstract class Rounded : Solid
    {
        protected Rounded(float a) : base(a)
        {
        }

        protected Rounded(float a, float b) : base(a, b)
        {
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override double Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
