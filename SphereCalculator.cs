using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    // Concrete Flyweight class - Sphere
    public class SphereCalculator : IShapeCalculator
    {
        public double CalculateVolume(double[] dimensions)
        {
            double radius = dimensions[0];
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        public double CalculateCircumference(double[] dimensions)
        {
            double radius = dimensions[0];
            return 2 * Math.PI * radius;
        }
    }
}
