using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Shape
    {
        /// <summary>
        /// Method for calculating Area
        /// </summary>
        /// <returns>Retruns result of Area</returns>
        public abstract double Area();
        /// <summary>
        /// Method for calculating Perimeter
        /// </summary>
        /// <returns>Returns the result of Perimeter</returns>
        public abstract double Perimeter();
    }
}
