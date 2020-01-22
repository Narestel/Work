using System;
using AreaOfShapeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreasOfShapeLibraryTest
{
    [TestClass]
    public class UnitTestOfArea
    {
        [TestMethod]
        public void TestArea()
        {
            double[,] sides = new double[3, 2] { { 3, 3 }, { 7, 2 }, { 3.8, 5.5 } };
            for (int i = 0; i < sides.GetLength(0); i++)
            {
                double test = sides[i, 0] * sides[i, 1];
                double fromLibrary = AreaOfShape.AreaSquare(sides[i, 0], sides[i, 1]);
                Assert.AreEqual(fromLibrary, test, 0.01, "From library = " + fromLibrary + ", but it should be = " + test);
            }
        }

        [TestMethod]
        public void TestTriangleThreeSides()
        {
            double[,] sides = { { 3, 7, 5.5 },
                                { 8, 5, 5 },
                                { 3.3, 3.2, 3.1 } };
            for (int i = 0; i < sides.GetLength(0); i++)
            {
                double pper = (sides[i, 0] + sides[i, 1] + sides[i, 2]) / 2;
                double test = Math.Sqrt((pper * (pper - sides[i, 0]) * (pper - sides[i, 1]) * (pper - sides[i, 2])));

                double fromLibrary1 = AreaOfShape.AreaTriangle(sides[i, 0], sides[i, 1], sides[i, 2]);
                Assert.AreEqual(fromLibrary1, test, 0.01, "From library area = " + fromLibrary1 + ", but it should be = " + test
                    + " with sides " + sides[i, 0] + " " + sides[i, 1] + " " + sides[i, 2]);
            }
        }

        [TestMethod]
        public void TestTriangleBaseAndHeight()
        {
            double[,] sides = { { 3, 7 },
                                { 8, 5 },
                                { 3.3, 3.2 } };
            for (int i = 0; i < sides.GetLength(0); i++)
            {
                double test = sides[i, 0] * sides[i, 1] / 2;
                double fromLibrary = AreaOfShape.AreaTriangle(sides[i, 0], sides[i, 1]);
                Assert.AreEqual(fromLibrary, test, 0.01, "From library area = " + fromLibrary + ", but it should be = " + test
                   + " with base " + sides[i, 0] + " and height " + sides[i, 1]);
            }
        }

        [TestMethod]
        public void TestCircle()
        {
            double[] r = { 3, 7, 1.1 };
            for (int i = 0; i < r.Length; i++)
            {
                double test = Math.PI * r[i] * r[i];
                double fromLibrary = AreaOfShape.AreaCircle(r[i]);
                Assert.AreEqual(fromLibrary, test, 0.01, "From library = " + fromLibrary + ", but it should be = " + test);
            }
        }

        [TestMethod]
        public void TestIsRightTriangle()
        {
            double[,] sides = { { 5, 4, 3 }, { 5, 5, 3 } };
            for (int i = 0; i < sides.GetLength(0); i++)
            {
                bool test = (Math.Pow(sides[i, 0], 2) == (Math.Pow(sides[i, 1], 2) + Math.Pow(sides[i, 2], 2)));
                bool fromLibrary = AreaOfShape.IsRightTriangle(sides[i, 0], sides[i, 1], sides[i, 2]);
                Assert.AreEqual(fromLibrary, test);
            }
        }
    }
}
