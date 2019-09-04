using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLib;

namespace GeometryLibTest
{
    [TestClass]
    public class GeometryTest
    {
        [TestMethod]
        public void TestTriangleType()
        {
            Triangle tri = new Triangle(1, 2, 3);
            Triangle tri1 = new Triangle(4, 5, 3);
            Assert.AreEqual(tri.IsRect(), false);
            Assert.AreEqual(tri1.IsRect(), true);
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            Triangle tri1 = new Triangle(4, 5, 3);
            Assert.AreEqual(tri1.CalcS(), 6);
        }
    }
}
