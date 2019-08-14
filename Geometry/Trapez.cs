using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Trapez : Square
    {
        private float parallels;
        public float Parallels
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
            this.Parallels = parallels;
        }

        public float FindS()
        {
            return (A + Parallels - B + Parallels) / 2;
        }

        public double FindHeight()
        {
            double s = FindS();
            return 2 / (A - B) * Math.Sqrt(s * (s - A + B) * (s - parallels) * (s - Parallels));
            ///*return 2 / (A - B) */  return Math.Sqrt(10 * (10 - 10 + 8) * (10 - 9) * (10 - 9));
        }

        public override double Areal()
        {

            return 0.5 * FindHeight() * (A + B);
        }

        public override double Perimeter()
        {
            return A + B + 2 * Parallels;
        }
    }
}
