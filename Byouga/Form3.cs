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
    public partial class Form3 : Form
    {
        //private PointInfo _pointInfo = null;
        private List<PointInfo> _pointInfos = new List<PointInfo>();
        private PointInfo _selectedPointInfo = null;
        //private bool _isMove = false;
        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //_pointInfo = new PointInfo(10, 10, 16, 16);
            _pointInfos.Add(new PointInfo(20, 20, 16, 16));
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //if (_pointInfo != null)
            //{
            //    DrawHelper.FillEllipse(e.Graphics, Color.Red,
            //        _pointInfo.X, 
            //        _pointInfo.Y, 
            //        _pointInfo.Width, 
            //        _pointInfo.Height);
            //}

            foreach(var pointInfo in _pointInfos)
            {
                DrawHelper.FillEllipse(e.Graphics, Color.Green,
                    pointInfo.X,
                    pointInfo.Y,
                    pointInfo.Width,
                    pointInfo.Height);
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            //if (_pointInfo == null)
            //{
            //    return;
            //}

            //Rectangle r = new Rectangle(
            //                                        _pointInfo.X,
            //                                        _pointInfo.Y,
            //                                        _pointInfo.Width,
            //                                        _pointInfo.Height);
            //if(r.Contains(e.X, e.Y))
            //{
            //    AddButton.Text = "OK";
            //}
            //else
            //{
            //    AddButton.Text = "NG";
            //}
            //using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            //{
            //    path.AddEllipse(_pointInfo.X,
            //                            _pointInfo.Y,
            //                            _pointInfo.Width,
            //                            _pointInfo.Height);
            //    if (path.IsVisible(e.X, e.Y))
            //    {
            //        AddButton.Text = "OK";
            //    }
            //    else
            //    {
            //        AddButton.Text = "NG";
            //    }

            //if (DrawHelper.IsEllipse(_pointInfo.X,
            //                        _pointInfo.Y,
            //                        _pointInfo.Width,
            //                        _pointInfo.Height,
            //                        e.X,
            //                        e.Y))
            //{
            //    AddButton.Text = "OK";
            //    _isMove = true;
            //}
            //else
            //{
            //    AddButton.Text = "NG";
            //    _isMove = false;
            //}

            foreach (var pointInfo in _pointInfos)
            {
                if(DrawHelper.IsEllipse(pointInfo.X,
                                    pointInfo.Y,
                                    pointInfo.Width,
                                    pointInfo.Height,
                                    e.X,
                                    e.Y))
                {
                    _selectedPointInfo = pointInfo;
                    break;
                }
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (_pointInfo == null)
            //{
            //    return;
            //}
            //if (!_isMove)
            //{
            //    return;
            //}

            if (_selectedPointInfo == null)
            {
                return;
            }

            int x = e.X;
            int y = e.Y;

            if (x < 0)
            {
                x = 0;
            }

            if (x>pictureBox1.Width)
            {
                x = pictureBox1.Width;
            }

            if (y < 0)
            {
                y = 0;
            }

            if (y > pictureBox1.Height)
            {
                y = pictureBox1.Height;
            }

            _selectedPointInfo.SetValue(x-8, y-8);
            //_pointInfo.SetValue(x-8, y-8);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //_isMove = false;
            _selectedPointInfo = null;
        }
    }

    internal class PointInfo
    {
        public PointInfo(int x ,int y ,int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
        internal int X { get; private set; }
        internal int Y { get; private set; }
        internal int Width { get; }
        internal int Height { get; }

        internal void SetValue(int x,int y)
        {
            X = x;
            Y = y;
        }
    }
}
