using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmStarategy
{
    internal class ShipMovement
    {
        private SpaceShip shipSpek = SpaceShip.init();
        public static async Task MoveShip(PictureBox starShip, int x, int y, int speed, int LvlOfEngine)
        {
            int startX = starShip.Left;
            int startY = starShip.Top;

            int deltaX = (x - startX) / (speed / 10);
            int deltaY = (y - startY) / (speed / 10);

            if (LvlOfEngine == 2)
            {
                using (Graphics g = starShip.Parent.CreateGraphics())
                {
                    Pen whitePen = new Pen(Color.White, 5);
                    Pen bluePen = new Pen(Color.Blue, 5);
                    Pen redPen = new Pen(Color.Red, 5);
                    for (int i = 0; i <= speed / 10; i++)
                    {
                        int currentX = startX + (deltaX * i);
                        int currentY = startY + (deltaY * i);

                        starShip.Location = new Point(currentX, currentY);
                        int offset = 8;
                        g.DrawLine(redPen, startX + starShip.Width / 2, startY + starShip.Height / 2 + offset, currentX + starShip.Width / 2, currentY + starShip.Height / 2 + offset);
                        g.DrawLine(bluePen, startX + starShip.Width / 2, startY + starShip.Height / 2 + 1, currentX + starShip.Width / 2, currentY + starShip.Height / 2 + 1);
                        g.DrawLine(whitePen, startX + starShip.Width / 2, startY + starShip.Height / 2 - offset, currentX + starShip.Width / 2, currentY + starShip.Height / 2 - offset);

                        await Task.Delay(10);
                    }
                }
            }
            else
            {
                for (int i = 0; i <= speed / 10; i++)
                {
                    int currentX = startX + (deltaX * i);
                    int currentY = startY + (deltaY * i);

                    starShip.Location = new Point(currentX, currentY);

                    await Task.Delay(10);
                }
            }
        }
    }
}
