using NUnit.Framework;
using GeometricFigures;
using System;

namespace Geometric
{
    public class CirleTest
    {
        public void CircleLenghtTest(int arg1)
        {
            double circleLenght = 2 * Math.PI * arg1;
            Circle circle = new Circle(arg1);
            Assert.AreEqual(circleLenght, circle.getLengthCircle());
        }

        public void MultiplySourceCircleTest(int arg1)
        {
            Circle circle = new Circle(arg1);
            double circleArea = Math.PI * Math.Pow(arg1, 2);
            Assert.AreEqual(circleArea, circle.getAreaCircle());
        }

    }
}
