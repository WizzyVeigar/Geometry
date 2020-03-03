using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rektangel : Square
    {
        public Rektangel(float sideA, float sideB) : base(sideA, sideB)
        {
        }

        public Rektangel(float sideA, float sideB, float sideC, float sideD) : base(sideA, sideB, sideC, sideD)
        {
        }
    }
}
