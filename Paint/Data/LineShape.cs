using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Data
{
    internal class LineShape : Shape
    {
        private int selectedPoint;

        public LineShape(Pen pen, Brush brush) : base(pen, brush)
        {
            pen.StartCap = pen.EndCap = LineCap.Flat;
        }

        //public LineShape( Pen pen,Point startPoint, Point endPoint)
        //{
        //    this.Graphics = graphics;
        //    this.Pen = pen;
        //    this.StartPoint = startPoint;
        //    this.EndPoint = endPoint;
        //}
        internal override void Draw(Graphics graphics)
        {
            if (StartPoint != EndPoint)
            {
                graphics.DrawLine(this.Pen, StartPoint, EndPoint);
                GraphicsPath.Reset();
                if (IsSelected)
                {
                    Brush brush = new SolidBrush(Color.Blue);
                    graphics.FillRectangle(brush, StartPoint.X - 3, StartPoint.Y - 3, 6, 6);
                    graphics.FillRectangle(brush, EndPoint.X - 3, EndPoint.Y - 3, 6, 6);
                }
            }
        }

        public override void Move(Point firstPoint, Point eLocation)
        {
            throw new NotImplementedException();
        }

        public override void SelectPoint(Point point)
        {
            double d1 = Math.Pow(point.X - StartPoint.X, 2) + Math.Pow(point.Y - StartPoint.Y, 2);
            double d2 = Math.Pow(point.X - EndPoint.X, 2) + Math.Pow(point.Y - EndPoint.Y, 2);

            if (d1 < d2)
                selectedPoint = 1;
            else
                selectedPoint = 2;
        }

        public override void AddPoint(Point point)
        {
            EndPoint = point;
        }
    }
}