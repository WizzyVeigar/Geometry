using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Quadrilateral : Square
    {
        public Quadrilateral(float sideA) : base(sideA)
        {
        }

        public Quadrilateral(float sideA, float sideB) : base(sideA, sideB)
        {
        }

        public Quadrilateral(float sideA, float sideB, float sideC, float sideD) : base(sideA, sideB, sideC, sideD)
        {
        }
    }
}
