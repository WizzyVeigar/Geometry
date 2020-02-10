using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Shape
    {

        private float a;
        private float b;
        
        public float A
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
            }
        }

        public float B
        {
            get
            {
                return this.b;
            }
            set
            {
                this.b = value;
            }
        }

        public Shape(float a)
        {
            this.A = a;
        }
        public Shape(float a, float b)
        {
            this.A = a;
            this.B = b;
        }
        /// <summary>
        /// Method for calculating Area
        /// </summary>
        /// <returns>Retruns result of Area</returns>
        public abstract double Area();
        /// <summary>
        /// Method for calculating Perimeter
        /// </summary>
        /// <returns>returns the result of Perimeter</returns>
        public abstract double Perimeter();
    }
}
