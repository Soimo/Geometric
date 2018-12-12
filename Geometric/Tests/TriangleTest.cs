using NUnit.Framework;
using GeometricFigures;
using System;

namespace Geometric
{
    class TriangleTest
    {
        public void TriangleLenghtTest(int arg1, int arg2, int arg3)
        {
            double triangleLenght = arg1 + arg2 + arg3;
            Triangle triangle = new Triangle(arg1, arg2, arg3);
            Assert.AreEqual(triangleLenght, triangle.getLengthTriangle());
        }

        public void MultiplySourceTriangleTest(int arg1, int arg2, int arg3)
        {
            Triangle triangle = new Triangle(arg1, arg2, arg3);
            double p = (arg1 + arg2 + arg3) / 2;

            double triangleArea = Math.Sqrt(p * (p - arg1) * (p - arg2) * (p - arg3));
            Assert.AreEqual(Math.Round(triangleArea), Math.Round(triangle.getAreaTriangle()));
        }
    }
}
