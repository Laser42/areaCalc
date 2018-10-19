using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaCalc
{
    class UnknownFigure
    {

        // If radius is specified, this is Circle
        public double GetArea(double radius)
        {
            Circle c = new Circle(radius);
            return c.Area;
        }

        // If 3 sides are specified, this is Triangle
        public double GetArea (double side1, double side2, double side3)
        {
            Triangle t = new Triangle(side1, side2, side3);
            return t.Area;
        }

    }
}
