using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsBenzo;

namespace WindowsFormsBenzovoz
{
	public partial class FormBenzo : Form
	{
		private  Benzovoz benzovoz;
		public FormBenzo()
		{
			InitializeComponent();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxBenzo.Width, pictureBoxBenzo.Height);
			Graphics gr = Graphics.FromImage(bmp);
			benzovoz.DrawTransport(gr);
			pictureBoxBenzo.Image = bmp;
		}
		
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
            int wheelNum = Convert.ToInt32(WheelCount.SelectedItem.ToString());
            benzovoz = new Benzovoz(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.OrangeRed,
		   true, true, wheelNum);
			benzovoz.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBenzo.Width,
		   pictureBoxBenzo.Height);
			Draw();

		}

		
		private void buttonMove_Click(object sender, EventArgs e)
		{
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					benzovoz.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					benzovoz.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					benzovoz.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					benzovoz.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}
