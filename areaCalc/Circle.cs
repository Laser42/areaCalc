using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaCalc
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            Area = Math.PI * radius * radius;
            Perimeter = 2 * Math.PI * radius;
            Name = "Circle";
        }
    }
}
