using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byouga.Helpers
{
    internal static class DrawHelper
    {
        internal static void DrawLine(Graphics g,
            Color color, 
            float penSize,
            int x1, 
            int y1, 
            int x2, 
            int y2
            )
        {
            using (var pen = new Pen(color, penSize))
            {
                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }

    }
}
