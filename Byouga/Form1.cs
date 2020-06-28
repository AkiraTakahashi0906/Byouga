using Byouga.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Byouga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen blue = new Pen(Color.Blue, 1);
            e.Graphics.DrawLine(blue, 10, 20, 350, 20);

            Pen red = new Pen(Color.Red, 1);
            e.Graphics.DrawLine(red, 10, 40, 350, 40);

            Pen green = new Pen(Color.Green, 3);
            e.Graphics.DrawLine(green, 10, 60, 350, 60);

            e.Graphics.DrawRectangle(blue, 10, 80, 100, 40);

            SolidBrush greenBrush = new SolidBrush(Color.Green);
            e.Graphics.FillRectangle(greenBrush,10,140,100,40);
            e.Graphics.DrawRectangle(red, 10, 140, 100, 40);

            e.Graphics.DrawEllipse(blue, 10, 140, 100, 40);

            e.Graphics.FillEllipse(greenBrush, 10, 200, 16, 16);
            e.Graphics.DrawEllipse(red, 10, 200, 16, 16);

            var points = new List<Point>();
            points.Add(new Point(247,199));
            points.Add(new Point(223, 130));
            points.Add(new Point(294, 95));
            points.Add(new Point(368, 130));
            points.Add(new Point(341,199 ));

            e.Graphics.DrawPolygon(blue, points.ToArray());

            e.Graphics.DrawLines(red, points.ToArray());

            e.Graphics.DrawString("AAAABBBBCCCCC", this.Font, greenBrush, 10, 220);

            e.Graphics.FillRectangle(greenBrush, 10, 240, 200, 30);

            SolidBrush grayBrush = new SolidBrush(Color.Gray);

            var size0 = e.Graphics.MeasureString("0", this.Font);
            e.Graphics.DrawString("0", this.Font, grayBrush, 10 - (size0.Width / 2), 276);

            var size50 = e.Graphics.MeasureString("50", this.Font);
            e.Graphics.DrawString("50", this.Font, grayBrush, 110 - (size50.Width / 2), 276);

            var size100 = e.Graphics.MeasureString("100", this.Font);
            e.Graphics.DrawString("100", this.Font, grayBrush, 210- (size100.Width/2), 276);

            Pen gray = new Pen(Color.Gray);
            e.Graphics.DrawLine(gray, 10, 270, 10, 275);
            e.Graphics.DrawLine(gray, 110, 270, 110, 275);
            e.Graphics.DrawLine(gray, 210, 270, 210, 275);

            using (var f20 = new Font("Meiryo UI", 20f, FontStyle.Italic))
            {
                //フォントはディスポーズが必要
                e.Graphics.DrawString("AAAABBBBCCCCC", f20, greenBrush, 10, 300);
            }

            DrawHelper.DrawLine(e.Graphics, Color.Violet,3f, 10, 330, 200, 330);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
