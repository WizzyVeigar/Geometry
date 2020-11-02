using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Geometry
{
    public abstract class Triangle : Solid
    {
        private float sideC;

        protected float SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }


        public Triangle(float a, float b) : base(a, b)
        {

        }

        protected Triangle(float a, float b, float c) : base(a, b)
        {
            SideC = c;
        }

        public override double Area()
        {
            return 0.5 * SideA * SideB;
        }

        protected double FindSideC()
        {
            return Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
        }
    }
}