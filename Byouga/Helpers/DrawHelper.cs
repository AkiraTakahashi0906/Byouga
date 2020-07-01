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

        internal static void FillRectangle(Graphics g,
                                                        Color color,
                                                        int x,
                                                        int y, 
                                                        int width, 
                                                        int height)
        {
            using (var brush = new SolidBrush(color))
            {
                g.FillRectangle(brush, x, y, width, height);
            }
        }

        internal static void FillEllipse(Graphics g, Color color, int x, int y, int width, int height)
        {
            using (var brush = new SolidBrush(color))
            {
                g.FillEllipse(brush, x, y, width, height);
            }
        }

        internal static bool IsEllipse(int x, int y, int width, int height,int mouseX,int mouseY)
        {
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddEllipse(x,
                                        y,
                                        width,
                                        height);

                return path.IsVisible(mouseX, mouseY);
            }
        }

    }
}
