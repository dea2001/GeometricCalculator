using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public interface IShapeCalculator
    {
        double CalculateVolume(double[] dimensions);
        double CalculateCircumference(double[] dimensions);
    }
}
