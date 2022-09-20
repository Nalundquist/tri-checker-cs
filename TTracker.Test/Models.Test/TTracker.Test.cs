using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Triangle;

namespace Tracker.Triangle.Test
{
	[TestClass]
	public class TriangleTests
	{
		[TestMethod]
    public void Triangle_HoldsThreeValues_True()
    {
      Triangle testTriangle = new Triangle(3, 5, 8);
      // is largest side > other sides combined
      Assert.AreEqual(true, testTriangle.IsTriangle());
    }
	}
}