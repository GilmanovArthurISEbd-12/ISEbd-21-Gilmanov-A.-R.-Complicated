using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBenzo
{
    class DrawWheel
    {
        private Wheel wheelСount;
        public int WheelСount
        {
            set
            {
                if (value == 2)
                {
                    wheelСount = Wheel.two;
                }
                if (value == 3)
                {
                    wheelСount = Wheel.three;
                }
                if (value == 4)
                {
                    wheelСount = Wheel.four;
                }
            }
        }

        public void DrawTwoWheeles(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {

            Brush dopColorBrush = new SolidBrush(dopColor);

            g.FillEllipse(dopColorBrush, _startPosX + 125, _startPosY + 75, 15, 15);
            g.FillEllipse(dopColorBrush, _startPosX + 65, _startPosY + 75, 15, 15);

        }

        public void DrawThreeWheeles(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColorBrush = new SolidBrush(dopColor);

            g.FillEllipse(dopColorBrush, _startPosX + 46, _startPosY + 75, 15, 15);
        }

        public void DrawFourWheeles(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColorBrush = new SolidBrush(dopColor);

            g.FillEllipse(dopColorBrush, _startPosX + 89, _startPosY + 75, 15, 15);
        }

        public void DrawWheeles(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            if (wheelСount == Wheel.two || wheelСount > Wheel.two) 
            {
                DrawTwoWheeles(g, dopColor, _startPosX, _startPosY);
                if (wheelСount == Wheel.three || wheelСount > Wheel.three)
                {
                    DrawThreeWheeles(g, dopColor, _startPosX, _startPosY);
                    if (wheelСount == Wheel.four || wheelСount > Wheel.four)
                    {
                        DrawFourWheeles(g, dopColor, _startPosX, _startPosY);
                    }
                }
            }
        }
    }
}
