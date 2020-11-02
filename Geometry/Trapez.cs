using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Trapez : Quadrilateral
    {
        private float parallels;
        protected float Parallels
        {
            get
            {
                return parallels;
            }
            set
            {
                parallels = value;
            }
        }

        public Trapez(float a, float b, float parallels) : base(a, b)
        {
            Parallels = parallels;
        }

        private float FindS()
        {
            return (SideA + Parallels - SideB + Parallels) / 2;
        }

        private double FindHeight()
        {
            float s = FindS();
            return 2 / (SideA - SideB) * Math.Sqrt(s * (s - SideA + SideB) * (s - parallels) * (s - Parallels));
            ///*return 2 / (A - B) */  return Math.Sqrt(10 * (10 - 10 + 8) * (10 - 9) * (10 - 9));
        }

        public override double Area()
        {

            return 0.5 * FindHeight() * (SideA + SideB);
        }

        public override double Perimeter()
        {
            return SideA + SideB + 2 * Parallels;
        }
    }
}
