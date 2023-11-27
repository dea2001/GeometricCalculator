using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    // Client
    class CalculatorApp
    {
        private ShapeCalculatorFactory calculatorFactory = new ShapeCalculatorFactory();
        private List<Tuple<string, double[]>> calculations = new List<Tuple<string, double[]>>();

        public void AddCalculation(string shapeType, double[] dimensions)
        {
            calculations.Add(new Tuple<string, double[]>(shapeType, dimensions));
        }

        public void PerformCalculations()
        {
            foreach (var calculation in calculations)
            {
                IShapeCalculator calculator = calculatorFactory.GetCalculator(calculation.Item1);
                double volume = calculator.CalculateVolume(calculation.Item2);
                double circumference = calculator.CalculateCircumference(calculation.Item2);

                Console.WriteLine($"Shape: {calculation.Item1}, Volume: {volume:F2}, Circumference: {circumference:F2}");
            }
        }
    }

}
