using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboticArmCapture
{
    public partial class RoboticArm : UserControl
    {
        public float InitialVerticalAxis1 = -5;
        public float InitialVerticalAxis2 = 60;
        public float VerticalAxis1 = -5;
        public float VerticalAxis2 = 60;
        public float Extend = 40;
        public float AxisLength1 = 80;
        public float AxisLength2 = 100;
        public float ExtendLength = 80;
        public float CameraLength = 10;
        public float HorizontalAxis = 0;

        private LinearGradientBrush sideBrush = new LinearGradientBrush(new Point(0, 0), new Point(300, 0), Color.Silver, Color.White);
        private LinearGradientBrush topBrush = new LinearGradientBrush(new Point(200, 0), new Point(600, 0), Color.Silver, Color.White);

        public RoboticArm()
        {
            InitializeComponent();
        }

        private void RoboticArm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(this.BackColor);
            g.SmoothingMode = SmoothingMode.HighQuality;

            drawSideView(g);
            drawTopView(g);
        }

        private void drawSideView(Graphics g)
        {
            g.DrawString("Side View:", new Font("Consolas", 9), new SolidBrush(Color.Black), new PointF(10, 10));
            PointF axis1Point = new PointF(45, 180);
            PointF axis2Point = new PointF((float)(axis1Point.X + AxisLength1 * Math.Sin(VerticalAxis1 / 180.0 * Math.PI)),
                (float)(axis1Point.Y - AxisLength1 * Math.Cos(VerticalAxis1 / 180.0 * Math.PI)));

            drawVerticalAxis2(g, axis2Point);
            drawVerticalAxis1(g, axis1Point);
            drawSideBase(g, new PointF(10, 180));
        }

        private void drawTopView(Graphics g)
        {
            g.DrawString("Top View:", new Font("Consolas", 9), new SolidBrush(Color.Black), new PointF(250, 10));
            PointF center = new PointF(350, 130);
            drawTopBase(g, center);
            drawTopVerticalAxis(g, center);
        }

        private void drawTopBase(Graphics g, PointF coord)
        {
            g.FillRectangle(topBrush, new RectangleF(coord.X - 30, coord.Y - 15, 45, 30));
            g.DrawRectangles(Pens.Black, new RectangleF[]{
                new RectangleF(coord.X - 30, coord.Y - 15, 45, 30)
            });
            g.DrawEllipse(Pens.LightGray, new RectangleF(coord.X - 120, coord.Y - 120, 240, 240));
        }

        private void drawTopVerticalAxis(Graphics g, PointF coord)
        {
            using (Matrix m = new Matrix())
            {
                m.RotateAt(HorizontalAxis + 180, coord);
                g.Transform = m;
                float vAxis1 = 0.5f * (float)(AxisLength1 * Math.Sin(VerticalAxis1 / 180.0 * Math.PI));
                float vAxis2 = 0.5f * (float)(AxisLength2 * Math.Cos(VerticalAxis2 / 180.0 * Math.PI));
                float extend = 0.5f * (float)(ExtendLength * Math.Cos((VerticalAxis2 - Extend) / 180.0 * Math.PI));
                Pen extendPen = new Pen(Color.Orange, 10f);
                Pen cameraPen = new Pen(Color.Black, 10f);
                Pen lensPen = new Pen(Color.Red, 5f);
                g.DrawLine(extendPen, new PointF(coord.X, coord.Y + vAxis1 + vAxis2), new PointF(coord.X, coord.Y + vAxis1 + vAxis2 + extend));
                g.DrawLine(extendPen, new PointF(coord.X - 10, coord.Y + vAxis1 + vAxis2 + extend), new PointF(coord.X + 10, coord.Y + vAxis1 + vAxis2 + extend));
                g.DrawLine(cameraPen, new PointF(coord.X, coord.Y + vAxis1 + vAxis2 + extend + 5), new PointF(coord.X, coord.Y + vAxis1 + vAxis2 + extend + 10));
                g.DrawLine(lensPen, new PointF(coord.X, coord.Y + vAxis1 + vAxis2 + extend + 10), new PointF(coord.X, coord.Y + vAxis1 + vAxis2 + extend + 13));
                g.FillRectangle(topBrush, new RectangleF(coord.X - 5, coord.Y + vAxis1, 10, vAxis2));
                g.DrawRectangles(Pens.Black, new RectangleF[] {
                    new RectangleF(coord.X - 5, coord.Y + vAxis1, 10, vAxis2)
                });
                g.FillRectangle(topBrush, new RectangleF(coord.X - 10, coord.Y, 20, vAxis1));
                g.DrawRectangles(Pens.Black, new RectangleF[] {
                    new RectangleF(coord.X - 10, coord.Y, 20, vAxis1)
                });
                g.FillRectangles(new SolidBrush(Color.Black), new RectangleF[] {
                    new RectangleF(coord.X - 30, coord.Y + 5, 20, 10),
                    new RectangleF(coord.X + 10, coord.Y + 5, 20, 10),
                    new RectangleF(coord.X - 5, coord.Y - 5, 10, 10)
                });
                g.ResetTransform();
            }
        }

        private void drawSideBase(Graphics g, PointF coord)
        {
            g.FillRectangle(new SolidBrush(Color.Black), new RectangleF(coord.X, coord.Y + 20, 25f, 40f));
            g.FillPolygon(sideBrush, new PointF[] {
                new PointF(coord.X + 20, coord.Y),
                new PointF(coord.X + 50, coord.Y),
                new PointF(coord.X + 40, coord.Y + 50),
                new PointF(coord.X, coord.Y + 50)
            });
            g.FillRectangle(sideBrush, new RectangleF(coord.X - 5, coord.Y + 50, 50, 5));
            g.FillRectangle(sideBrush, new RectangleF(coord.X, coord.Y + 55, 40, 5));
            g.FillRectangle(sideBrush, new RectangleF(coord.X - 5, coord.Y + 60, 50, 5));

            g.FillRectangle(new SolidBrush(Color.Black), new RectangleF(coord.X + 25, coord.Y + 5, 25f, 25f));

            g.DrawPolygon(Pens.Black, new PointF[] {
                new PointF(coord.X + 20, coord.Y),
                new PointF(coord.X + 50, coord.Y),
                new PointF(coord.X + 40, coord.Y + 50),
                new PointF(coord.X, coord.Y + 50)
            });
            g.DrawRectangles(Pens.Black, new RectangleF[] {
                new RectangleF(coord.X - 5, coord.Y + 50, 50, 5),
                new RectangleF(coord.X, coord.Y + 55, 40, 5),
                new RectangleF(coord.X - 5, coord.Y + 60, 50, 5)
            });
        }

        private void drawVerticalAxis1(Graphics g, PointF coord)
        {
            using (Matrix m = new Matrix())
            {
                m.RotateAt(VerticalAxis1 - 90, new PointF(coord.X, coord.Y));
                g.Transform = m;
                g.FillRectangle(sideBrush, new RectangleF(coord.X, coord.Y - 15, AxisLength1, 30));
                g.DrawRectangles(Pens.Black, new RectangleF[] {
                    new RectangleF(coord.X, coord.Y - 15, AxisLength1, 30)
                });
                g.ResetTransform();
            }
        }

        private void drawVerticalAxis2(Graphics g, PointF coord)
        {
            using (Matrix m = new Matrix())
            {
                m.RotateAt(VerticalAxis2, new PointF(coord.X, coord.Y));
                g.Transform = m;
                g.FillRectangle(sideBrush, new RectangleF(coord.X, coord.Y - 10, AxisLength2, 20));
                g.DrawRectangles(Pens.Black, new RectangleF[] {
                    new RectangleF(coord.X, coord.Y - 10, AxisLength2, 20)
                });
                Pen extendPen = new Pen(Color.Orange, 14f);
                Pen cameraPen = new Pen(Color.Black, 20f);
                Pen lensPen = new Pen(Color.Red, 10f);
                PointF extendStartPt = new PointF(coord.X + AxisLength2, coord.Y);
                PointF extendEndPt = new PointF((float)(coord.X + AxisLength2 + ExtendLength * Math.Cos(Extend * Math.PI / 180.0)),
                        (float)(coord.Y - ExtendLength * Math.Sin(Extend * Math.PI / 180.0)));
                PointF cameraEndPt = new PointF((float)(coord.X + AxisLength2 + (ExtendLength + CameraLength) * Math.Cos(Extend * Math.PI / 180.0)),
                        (float)(coord.Y - (ExtendLength + CameraLength) * Math.Sin(Extend * Math.PI / 180.0)));
                PointF cameraEndPt2 = new PointF((float)(coord.X + AxisLength2 + (ExtendLength + CameraLength + 5) * Math.Cos(Extend * Math.PI / 180.0)),
                        (float)(coord.Y - (ExtendLength + CameraLength + 5) * Math.Sin(Extend * Math.PI / 180.0)));
                g.DrawLine(extendPen, extendStartPt, extendEndPt);
                g.DrawLine(cameraPen, extendEndPt, cameraEndPt);
                g.DrawLine(lensPen, cameraEndPt, cameraEndPt2);
                g.ResetTransform();
            }
        }

        public void setAngles(double delta_x, double delta_y, double delta_z)
        {
            VerticalAxis1 = (float)(InitialVerticalAxis1 - delta_z * Metrics.degreePerUnit);
            VerticalAxis2 = (float)(InitialVerticalAxis2 - delta_y * Metrics.degreePerUnit);
            HorizontalAxis = (float)(-delta_x * Metrics.degreePerUnit);
            this.Invalidate();
        }
    }
}
