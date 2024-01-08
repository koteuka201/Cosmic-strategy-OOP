using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmStarategy
{
    internal class ElipseButton
    {
        public static void MakeButtonRound(Button button)
        {
            GraphicsPath buttonPath = new GraphicsPath();
            buttonPath.AddEllipse(0, 0, button.Width, button.Height);
            button.Region = new Region(buttonPath);
        }
    }
}
