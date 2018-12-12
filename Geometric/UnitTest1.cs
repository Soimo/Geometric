using NUnit.Framework;
using GeometricFigures;
using System;


[TestFixture]
public class GeometricFiguresTest
{
    [Test]
    [TestCase(14, TestName = "CircleLenght")]
    public void CircleLenght(int arg1)
    {
        Geometric.CirleTest ct = new Geometric.CirleTest();
        ct.CircleLenghtTest(arg1);
    }


    [Test, TestCaseSource("CircleDividedCases")]
    public void MultiplySourceCircle(int arg1)
    {
        Geometric.CirleTest ct = new Geometric.CirleTest();
        ct.MultiplySourceCircleTest(arg1);
    }


    [Test]
    [TestCase(10, TestName = "SquareLenght")]
    public void SquareLenght(int arg1)
    {
        Geometric.SquareTest st = new Geometric.SquareTest();
        st.SquareLenghtTest(arg1);
    }


    [Test, TestCaseSource("SquareDividedCases")]
    public void MultiplySourceSquare(int arg1)
    {
        Geometric.SquareTest st = new Geometric.SquareTest();
        st.MultiplySourceSquareTest(arg1);
    }


    static object[] SquareDividedCases =
{
        new object[] { 0  },
        new object[] { 8 },
        new object[] { 15 }
    };


    static object[] CircleDividedCases =
    {
        new object[] {-6 },
        new object[] { 0 },
        new object[] { 5 }
    };



}
