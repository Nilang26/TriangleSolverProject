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
        }
    }

