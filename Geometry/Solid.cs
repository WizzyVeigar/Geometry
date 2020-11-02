using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Solid : Shape
    {
        private float sideA;
        private float sideB;

        protected Solid(float sideA)
        {
            SideA = sideA;
        }

        protected Solid(float sideA, float sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        protected float SideA
        {
            get
            {
                return this.sideA;
            }
            set
            {
                this.sideA = value;
            }
        }

        protected float SideB
        {
            get
            {
                return this.sideB;
            }
            set
            {
                this.sideB = value;
            }
        }
    }
}
