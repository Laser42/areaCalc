using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaCalc
{
    public class Triangle : Figure
    {
        private double side21;
        private double v;
        private double side31;

        // I use 3 doubles instead of array to guarantee that triangle will have exactly 3 sides
        // Also, it will simplify both Area and Perimeter calculation
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }
        public bool IsRightTriangle { get; private set; }

        public Triangle (double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

            Perimeter = Side1 + Side2 + Side3;
            double HalfPer = Perimeter / 2;
            Area = Math.Sqrt(HalfPer * (HalfPer - Side1) * (HalfPer - Side2) * (HalfPer - Side3) );

            // Check if triangle is right (90 degrees-angled)
            if (
                (Side1 * Side1 == (Side2 * Side2) + (Side3 * Side3)) ||
                (Side2 * Side2 == (Side1 * Side1) + (Side3 * Side3)) ||
                (Side3 * Side3 == (Side1 * Side1) + (Side2 * Side2))
                )
            {
                IsRightTriangle = true;
            }
            else { IsRightTriangle = false; }

            Name = "Triangle";
        }
    }
}
