using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Triangle
{
	public class IsTriangle
	{
		public static int a,b,c;
		public static bool valid;
		public static string types;
		public static int Input(char side) //gets side lengths
		{
			int verified; //input value after int verification
			while (true) //will keep accepting inputs until given an int
			{
				Console.WriteLine("Side " + side + " length: \n");
				if (int.TryParse(Console.ReadLine(), out verified)) //verifies x is an int
				{
					return verified;
				}
				else
				{
					Console.WriteLine("Input must be an integer, please try again.\n");
				}
			}
		}
		public static bool CheckValid(int a, int b, int c) //checks validity of triangle
		{
			if (a+b<c || a+c<b || b+c<a)
				return false;
			return true;
		}
		public static string CheckTypes(int a, int b, int c) //returns if triangle is right/isosceles/equilateral/standard
		{
			string types = "";
			if (a*a+b*b==c*c) //pythagorean theorem
				types += "right";
			else if (a==b || a==c || b==c)
			{
				types += "isosceles";
				if (a==b && a==c && b==c)
					types += " equilateral";
			}
			else
				types += "standard"; //for our intents and purposes standard is any triangle that is not acute/isosceles/equilateral
			return types;
		}
		public static void Main()
		{
			a = Input('a');
			b = Input('b');
			c = Input('c');
			valid = CheckValid(a,b,c);
			types = CheckTypes(a,b,c);
			if (valid == true)
			{
				if (types == "right" || types == "standard") // for a versus an in output
					Console.WriteLine("This is a valid triangle. It is a " + types + " triangle.\n");
				else
					Console.WriteLine("This is a valid triangle. It is an " + types + " triangle.\n");
			}
			else
				Console.WriteLine("These side lengths cannot possibly make a valid triangle.\n");
		}
	}
}