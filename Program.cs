using Drawing;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        CalculatorApp calculatorApp = new CalculatorApp();

        // Add calculations to the app
        calculatorApp.AddCalculation("sphere", new double[] { 3.0 }); // Sphere with radius 3
        calculatorApp.AddCalculation("cylinder", new double[] { 2.0, 5.0 }); // Cylinder with radius 2 and height 5
        calculatorApp.AddCalculation("cube", new double[] { 4.0 }); // Cube with side length 4

        // Perform calculations
        calculatorApp.PerformCalculations();
    }
}
