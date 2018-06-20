using System;
using System.Windows.Forms;
using System.Drawing;

namespace TriangleProgram {
	public class SimpleForm : Form {
		private Label label1; private Label label2; private Label label3;
		private TextBox textbox1; private TextBox textbox2; private TextBox textbox3;
		private Button button1; 

		public SimpleForm():this(100,200,325,200) {} //constructor data

		public SimpleForm (int x, int y, int width, int height) { //constructor
			this.Bounds = new Rectangle(x,y,width,height);
			this.Text = "Triangle";
			InitializeForm();
		}

		private void InitializeForm() { //makes the labels, textboxes, and buttons on the form
			label1 = new Label(); label1.Text = "Side a: "; label1.Location = new Point(25,25); //labels
			label2 = new Label(); label2.Text = "Side b: "; label2.Location = new Point(25,50);
			label3 = new Label(); label3.Text = "Side c: "; label3.Location = new Point(25,75);
			textbox1 = new TextBox(); textbox1.Location = new Point (175,25); //textboxes
			textbox2 = new TextBox(); textbox2.Location = new Point (175,50);
			textbox3 = new TextBox(); textbox3.Location = new Point (175,75);
			button1 = new Button(); button1.Text = "Submit"; button1.Location = new Point(110,125); button1.Click += HandleClick; //buttons

			this.Controls.Add(label1); this.Controls.Add(label2); this.Controls.Add(label3); //labels
			this.Controls.Add(textbox1); this.Controls.Add(textbox2); this.Controls.Add(textbox3); //textboxes
			this.Controls.Add(button1); //butttons
		}

		public void HandleClick(object sender, EventArgs e) {
			double number;
			if (double.TryParse(textbox1.Text.Trim(), out number) && double.TryParse(textbox2.Text.Trim(), out number) && double.TryParse(textbox3.Text.Trim(), out number)) {
				TestTriangle.myTriangle.a = Convert.ToDouble(textbox1.Text);
				TestTriangle.myTriangle.b = Convert.ToDouble(textbox2.Text);
				TestTriangle.myTriangle.c = Convert.ToDouble(textbox3.Text);
				this.Close(); //closes form
			}
			else
				MessageBox.Show("Please insert valid numbers.");
		}
		public static void Run() {
			Application.Run(new SimpleForm());
		}
	} //end SimpleForm
} //end namespace