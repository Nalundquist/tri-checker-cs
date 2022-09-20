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
      Assert.AreEqual(true, testTriangle.IsTriangle(testTriangle.Side1, testTriangle.Side2, testTriangle.Side3));
    }

		[TestMethod]
		public void Triangle_IsEquilateral_True()
		{
			Triangle testTriangle = new Triangle(5, 5, 5);
			Assert.AreEqual("equilateral", testTriangle.TriangleType(testTriangle.Side1, testTriangle.Side2, testTriangle.Side3));
		}
	}
}