using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CosmStarategy
{
    internal class leaveFlash
    {
        public static async Task LeaveTrace(PictureBox starShip)
        {
            using (Graphics g = starShip.CreateGraphics())
            {
                for (int i = 0; i < 255; i++)
                {
                    // Определение цветов для флага России (белый, синий, красный)
                    Color[] colors = { Color.White, Color.FromArgb(i, 0, 56, 168), Color.FromArgb(i, 213, 43, 30) };

                    // Отрисовка трех полос флага России
                    for (int j = 0; j < 3; j++)
                    {
                        int stripeHeight = starShip.Height / 3;
                        int stripeY = starShip.Top + j * stripeHeight;

                        Rectangle stripeRect = new Rectangle(starShip.Left, stripeY, starShip.Width, stripeHeight);
                        using (SolidBrush brush = new SolidBrush(colors[j]))
                        {
                            g.FillRectangle(brush, stripeRect);
                        }
                    }

                    await Task.Delay(10);
                }
            }
        }
    }
}
