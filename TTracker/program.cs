using System;
using System.Collections.Generic;
using Tracker.Tri;

namespace Tracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Triangle Tracker!");
			Console.WriteLine("Input the first side length");
			string firstSideStr = Console.ReadLine();
			int firstSide = Int32.Parse(firstSideStr);
			Console.WriteLine("Input the second side length");
			string secondSideStr = Console.ReadLine();
			int secondSide = Int32.Parse(secondSideStr);
			Console.WriteLine("Input the third side length");
			string thirdSideStr = Console.ReadLine();
			int thirdSide = Int32.Parse(thirdSideStr);
			Triangle newTriangle = new Triangle (firstSide, secondSide, thirdSide);
			
      if (newTriangle.IsTriangle(newTriangle.Side1, newTriangle.Side2, newTriangle.Side3) == false)
			{
				Console.WriteLine("That's no triangle, please leave.");
			}
			else 
			{
				string result = newTriangle.TriangleType(newTriangle.Side1, newTriangle.Side2, newTriangle.Side3);
				Console.WriteLine("What a great triangle!  It's amazing.  It is a(n) " + result);
			}
    }
  }
}