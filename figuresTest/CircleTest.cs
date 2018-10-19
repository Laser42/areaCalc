using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using areaCalc;

namespace figuresTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleRadius2_4PIArea()
        {

            // Arrange
            double Radius = 2;
            double expectedArea = 4 * Math.PI;

            // Act
            Circle c = new Circle(Radius);

            // Assert
            Assert.AreEqual(expectedArea, c.Area);

        }

    }
}
