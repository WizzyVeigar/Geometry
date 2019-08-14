using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rektangel : Square
    {
        public Rektangel(float a) : base(a)
        {

        }

        public override double Areal()
        {
            float areal = A;
            return areal * areal;
        }

        public override double Perimeter()
        {
            return 4 * A;
        }
    }
}
