using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TestTriangle
{
    public class TriangleTest
    {
        [TestFixture]

        public class TringlesolverTestCase
        {
            [Test]
            public void AnalyzeTriangle_input3and3and3_OutputEquilateralTriangleIsFormed()
            {
                //Arrange
                int side1 = 3, side2 = 3, side3 = 3;
                string expected = "An equilateral triangle is formed";

                //act
                string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

                //assert
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        public void AnalyzeTriangle_input10and10and12_OutputIsoscelesTriangleIsFormed()
        {
            //Arrange
            int side1 = 10, side2 = 10, side3 = 12;
            string expected = "An isosceles triangle is formed";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AnalyzeTriangle_input4and4and3_OutputIsoscelesTriangleIsFormed()
        {
            //Arrange
            int side1 = 4, side2 = 4, side3 = 3;
            string expected = "An isosceles triangle is formed";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AnalyzeTriangle_input1and1and3_OutputIsoscelesTriangleIsFormed()
        {
            //Arrange
            int side1 = 5, side2 = 5, side3 = 3;
            string expected = "An isosceles triangle is formed";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}