﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rektangel : Quadrilateral
    {
        public Rektangel(float sideA, float sideB) : base(sideA, sideB)
        {
        }

        public Rektangel(float sideA, float sideB, float sideC, float sideD) : base(sideA, sideB, sideC, sideD)
        {
        }

        public override double Area()
        {
            return SideA * SideB;
        }

        public override double Perimeter()
        {
            return 2 * (SideA + SideB);
        }
    }
}
