using System;

namespace Tracker.Tri
{
	public class Triangle
	{
		public int Side1 { get; set; }
		public int Side2 { get; set; }
		public int Side3 { get; set; }

		public Triangle(int side1, int side2, int side3)
		{
			Side1 = side1;
      Side2 = side2;
      Side3 = side3;
		}

    public bool IsTriangle(int side1, int side2, int side3)
    {
      return (side1 + side2 >= side3 && side2 + side3 >= side1 && side1 + side3 >= side2);
    }

		public string TriangleType(int side1, int side2, int side3)
		{
			if (side1 == side2 && side2 == side3 && side1 == side3)
			{
				return "equilateral";
			}
			else if (side1 == side2 || side1 == side3 || side2 == side3)
			{
				return "isosceles";
			}
			else if (side1 != side2 && side2 != side3 && side1 != side3)
			{
				return "scalene";
			}
			else
			{
				return "not triangle";
			}
		}
	}
}