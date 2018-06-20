using System;
using System.Windows.Forms;
using System.Drawing;

namespace TriangleProgram {
	public class Angles {
		public static void SolveForAngles(Triangle myTriangle) { //Determines triangles angles
			double a = myTriangle.a; double b = myTriangle.b; double c = myTriangle.c; //for readability in the math
			double A,B,C;
			A = Math.Acos((b*b + c*c - a*a) / (2*b*c)); //law of cosines
			B = Math.Acos((c*c + a*a - b*b) / (2*c*a)); //law of cosines
			A *= (180/Math.PI); B *= (180/Math.PI); //convert these values from radians to degrees 
			C = 180 - A - B; //The angles of a triangle always add to 180 degrees
			myTriangle.A = A; myTriangle.B = B; myTriangle.C = C;
		}
	} //end Angles
} //end namespace