using System;
using System.Windows.Forms;
using System.Drawing;

namespace TriangleProgram {
	public class Valid {
		public static void CheckValid(Triangle myTriangle) { //no two sides can add up to less than the third side
			double a = myTriangle.a; double b = myTriangle.b; double c = myTriangle.c; //for readability in the math
			bool valid;
			if (a+b<c || a+c<b || b+c<a)
				valid = false;
			else
				valid = true;
			myTriangle.valid = valid;
		}
	} //end Valid
} //end namespace