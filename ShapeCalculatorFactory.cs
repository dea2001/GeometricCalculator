using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    // Flyweight Factory
    public class ShapeCalculatorFactory
    {
        private Dictionary<string, IShapeCalculator> shapeCalculators = new Dictionary<string, IShapeCalculator>();

        public IShapeCalculator GetCalculator(string shapeType)
        {
            if (!shapeCalculators.ContainsKey(shapeType))
            {
                switch (shapeType.ToLower())
                {
                    case "sphere":
                        shapeCalculators[shapeType] = new SphereCalculator();
                        break;
                    case "cylinder":
                        shapeCalculators[shapeType] = new CylinderCalculator();
                        break;
                    case "cube":
                        shapeCalculators[shapeType] = new CubeCalculator();
                        break;
                    // Add more shapes as needed
                    default:
                        throw new ArgumentException("Invalid shape type");
                }
            }
            return shapeCalculators[shapeType];
        }
    }
}
