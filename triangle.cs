using System;
using System.Windows.Forms;
using System.Drawing;

namespace TriangleProgram {
	public class Triangle {
		public double a { get; set; } //sides a,b,c
		public double b { get; set; }
		public double c { get; set; } //angles A,B,C are directly opposite their corresponding sides.
		public double A { get; set; } //            __
		public double B { get; set; } //Example: -> \/ if the left side leg [indicated by the arrow] is side a,
		public double C { get; set; } 	//then the top right angle is A
		public bool valid { get; set; }
		public string types { get; set; }
		public string angleType {get; set; }
	} //end Triangle
} //end namespace