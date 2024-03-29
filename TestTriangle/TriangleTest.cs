﻿using NUnit.Framework;
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
        [Test]
        public void AnalyzeTriangle_input5and4and3_OutputScaleneTriangleIsFormed()
        {
            //Arrange
            int side1 = 20, side2 = 10, side3 = 22;
            string expected = "A scalene triangle is formed";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AnalyzeTriangle_input10and20and12_OutputScaleneTriangleIsFormed()
        {
            //Arrange
            int side1 = 10, side2 = 20, side3 = 12;
            string expected = "A scalene triangle is formed";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AnalyzeTriangle_input30and11and12_OutputScaleneTriangleIsFormed()
        {
            //Arrange
            int side1 = 30, side2 = 20, side3 = 12;
            string expected = "A scalene triangle is formed";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AnalyzeTriangle_input22and20and21_OutputScaleneTriangleIsFormed()
        {
            //Arrange
            int side1 = 22, side2 = 20, side3 = 21;
            string expected = "A scalene triangle is formed";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AnalyzeTriangle_input23and24and28_OutputScaleneTriangleIsFormed()
        {
            //Arrange
            int side1 = 23, side2 = 24, side3 = 28;
            string expected = "A scalene triangle is formed";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AnalyzeTriangle_input0and0and2_OutputInvalidTriangle()
        {
            //Arrange
            int side1 = 0, side2 = 0, side3 = 2;
            string expected = "At least one side entered had a zero - invalid triangle";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AnalyzeTriangle_input0and1and2_OutputInvalidTriangle()
        {
            //Arrange
            int side1 = 0, side2 = 1, side3 = 2;
            string expected = "At least one side entered had a zero - invalid triangle";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AnalyzeTriangle_input0and0and0_OutputInvalidTriangle()
        {
            //Arrange
            int side1 = 0, side2 = 0, side3 = 0;
            string expected = "At least one side entered had a zero - invalid triangle";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AnalyzeTriangle_input1and1and4_OutputNotATriangle()
        {
            //Arrange
            int side1 = 1, side2 = 1, side3 = 4;
            string expected = "A triangle cannot be formed";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AnalyzeTriangle_input12and12and500_OutputNotATriangle()
        {
            //Arrange
            int side1 = 12, side2 = 12, side3 = 500;
            string expected = "A triangle cannot be formed";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AnalyzeTriangle_input3and2and1000_OutputNotATriangle()
        {
            //Arrange
            int side1 = 3, side2 = 2, side3 = 1000;
            string expected = "A triangle cannot be formed";

            //act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
