using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmStarategy
{
    internal class MakeShipOnForm
    {
        private PictureBox StarShip;
        public static PictureBox CreateShip(PictureBox pictureBox, Image ship, int width, int height)
        {

            PictureBox starShip = new PictureBox();
            starShip = new PictureBox();
            starShip.Size = new Size(0, 0);
            starShip.Location = new Point(width, height);
            System.Drawing.Image newShip = ship.GetThumbnailImage(120, 120, null, IntPtr.Zero);
            starShip.Image = newShip;

            return starShip;
        }
    }
}
