using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Quadrilateral : Solid
    {
        private float sideC;

        protected float SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        private float sideD;

        protected float SideD
        {
            get { return sideD; }
            set { sideD = value; }
        }


        protected Quadrilateral(float sideA) : base(sideA)
        {
        }

        protected Quadrilateral(float sideA, float sideB) : base(sideA, sideB)
        {
        }

        protected Quadrilateral(float sideA, float sideB, float sideC, float sideD) : base(sideA, sideB)
        {
            SideC = sideC;
            SideD = sideD;
        }
    }
}
