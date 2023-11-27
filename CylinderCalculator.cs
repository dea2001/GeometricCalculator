using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{// Concrete Flyweight class - Cylinder
    public class CylinderCalculator : IShapeCalculator
    {
        public double CalculateVolume(double[] dimensions)
        {
            double radius = dimensions[0];
            double height = dimensions[1];
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public double CalculateCircumference(double[] dimensions)
        {
            double radius = dimensions[0];
            return 2 * Math.PI * radius;
        }
    }
}

