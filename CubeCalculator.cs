using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    // Concrete Flyweight class - Cube
    public class CubeCalculator : IShapeCalculator
    {
        public double CalculateVolume(double[] dimensions)
        {
            double sideLength = dimensions[0];
            return Math.Pow(sideLength, 3);
        }

        public double CalculateCircumference(double[] dimensions)
        {
            double sideLength = dimensions[0];
            return 12 * sideLength;
        }
    }

}
