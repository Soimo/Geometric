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
    public void MultiplySource(int arg1)
    {
        Geometric.CirleTest ct = new Geometric.CirleTest();
        ct.MultiplySourceTest(arg1);
    }

    static object[] CircleDividedCases =
    {
        new object[] {-6 },
        new object[] { 0 },
        new object[] { 5 }
    };



}
