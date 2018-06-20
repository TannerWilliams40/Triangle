using System;
using System.Windows.Forms;
using System.Drawing;

namespace TriangleProgram {
	public class TestTriangle {
		public static Triangle myTriangle = new Triangle();
		public static void Main() {
			SimpleForm.Run();
			Valid.CheckValid(myTriangle);
			Types.DetermineTypes(myTriangle);
			Angles.SolveForAngles(myTriangle);
			if (myTriangle.valid) {
				Console.WriteLine("This is a valid " + myTriangle.types + " triangle. ");
				if (myTriangle.types != "right") {
					AngleType.DetermineAngleType(myTriangle);
					Console.WriteLine("This triangle is also " + myTriangle.angleType + ".");
				}
				Console.WriteLine("\nSide a: " + myTriangle.a + "\n" + 
								"Side b: " + myTriangle.b + "\n" +
								"Side c: " + myTriangle.c + "\n" + 
								"Angle A: " + myTriangle.A + "\n" +
								"Angle B: " + myTriangle.B + "\n" +
								"Angle C: " + myTriangle.C + "\n");
			}
			else
				Console.WriteLine("These side lengths cannot possibly make a valid triangle.\n");
		} //end Main
	} //end TestTriangle
}