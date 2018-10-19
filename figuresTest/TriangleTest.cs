using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using areaCalc;

namespace areaCalc
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleSides3_3_4_AreaSqrt20()
        {
            
            // Arrange
            double Side1 = 3;
            double Side2 = 3;
            double Side3 = 4;
            double expectedArea = Math.Sqrt(20);

            // Act
            Triangle t = new Triangle(Side1, Side2, Side3);

            // Assert
            Assert.AreEqual(expectedArea, t.Area);

        }
    }
}
