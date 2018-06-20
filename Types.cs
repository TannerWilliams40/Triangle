using System;
using System.Windows.Forms;
using System.Drawing;

namespace TriangleProgram {
	public class Types {
		public static void DetermineTypes(Triangle myTriangle) { //determines if triangle is right/isosceles/equilateral/standard
			double a = myTriangle.a; double b = myTriangle.b; double c = myTriangle.c; //for readability in the math
			string types;
			if (a*a+b*b==c*c) //pythagorean theorem
				types = "Right";
			else if (a==b || a==c || b==c) {
				types = "Isosceles";
				if (a==b && a==c && b==c)
					types += " Equilateral";
			}
			else
				types = "Scalene"; //all sides are of different lengths
			myTriangle.types = types;
		}
	} //end Types
} //end namespace