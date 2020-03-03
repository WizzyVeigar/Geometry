using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Square : Solid
    {
        private float sideC;
        private float sideD;

        public float SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                sideC = value;
            }
        }
        public float SideD
        {
            get
            {
                return sideD;
            }
            set
            {
                sideD = value;
            }
        }


        public Square(float sideA) : base(sideA)
        {
        }

        public Square(float sideA, float sideB) : base(sideA, sideB)
        {
        }

        public Square(float sideA, float sideB, float sideC, float sideD) : base(sideA, sideB)
        {
            SideC = sideC;
            SideD = sideD;
        }

        public override double Area()
        {
            return SideA * SideA;
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC + SideD;
        }
    }
}
