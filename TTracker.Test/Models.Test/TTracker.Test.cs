using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Triangle;

namespace Tracker.Triangle.Test
{
	[TestClass]
	public class TriangleTests
	{
		[TestMethod]
    public void Triangle_IsTriangle_True()
    {
      Triangle testTriangle = new Triangle(3, 5, 8);
    }

		[TestMethod]
		public void Triangle_IsEquilateral_True()
		{
			Triangle testTriangle = new Triangle(5, 5, 5);
			Assert.AreEqual("equilateral", testTriangle.TriangleType(testTriangle.Side1, testTriangle.Side2, testTriangle.Side3));
		}

		[TestMethod]
		public void Triangle_IsIsosceles_True()
		{
			Triangle testTriangle = new Triangle(5, 5, 6);
			Assert.AreEqual("isosceles", testTriangle.TriangleType(testTriangle.Side1, testTriangle.Side2, testTriangle.Side3));
		}

		[TestMethod]
		public void Triangle_IsScalene_True()
		{
			Triangle testTriangle = new Triangle(4, 5, 6);
			Assert.AreEqual("scalene", testTriangle.TriangleType(testTriangle.Side1, testTriangle.Side2, testTriangle.Side3));
		}
	}
}