using System;
using System.Windows.Forms;
using System.Drawing;

namespace TriangleProgram {
	public class AngleType {
		public static void DetermineAngleType(Triangle myTriangle) { //Determines triangles angles
			double A = myTriangle.A; double B = myTriangle.B; double C = myTriangle.C; //for readability in the math
			string angleType;
			if (A > 90 || B > 90 || C > 90)
				angleType = "Obtuse";
			else //all angles are less than 90 degrees
				angleType = "Acute";
			myTriangle.angleType = angleType;
		}
	} //end AngleType
} //end namespace