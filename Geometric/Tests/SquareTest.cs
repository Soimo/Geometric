using NUnit.Framework;
using GeometricFigures;
using System;

namespace Geometric
{
    class SquareTest
    {
        public void SquareLenghtTest(int arg1)
        {
            double squareLenght = 4 * arg1;
            Square square = new Square(arg1);
            Assert.AreEqual(squareLenght, square.getLengthSquare());
        }

        public void MultiplySourceSquareTest(int arg1)
        {
            Square square = new Square(arg1);
            double squareArea = Math.Pow(arg1, 2);
            Assert.AreEqual(squareArea, square.getAreaSquare());
        }

    }
}
