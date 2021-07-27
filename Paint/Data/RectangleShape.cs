using Paint.Common;
using System;
using System.Drawing;

namespace Paint.Data
{
    internal class RectangleShape : Shape
    {
        internal Rectangle Rectangle { get; set; }

        public RectangleShape(Pen pen, Brush brush) : base(pen, brush)
        {
            this.Brush = brush;
            this.Pen = pen;
        }

        public RectangleShape(Brush brush, Pen pen, Point startPoint, Point endPoint, bool isFill, bool isFillBorder)
        {
            this.Brush = brush;
            this.Pen = pen;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.IsFilled = isFill;
            this.IsDrawBorder = isFillBorder;
            Rectangle = Utilities.GetRectangleByPoint(StartPoint, EndPoint);
        }

        internal override void Draw(Graphics graphics)
        {
            if (IsFilled)
            {
                graphics.FillRectangle(Brush, Rectangle);
                if (IsDrawBorder)
                {
                    graphics.DrawRectangle(Pen, Rectangle);
                }
            }
            else
            {
                graphics.DrawRectangle(Pen, Rectangle);
            }
        }

        public override void SelectPoint(Point eLocation)
        {
            throw new NotImplementedException();
        }

        public override void Move(Point firstPoint, Point eLocation)
        {
            throw new NotImplementedException();
        }

        public override void AddPoint(Point p)
        {
            throw new NotImplementedException();
        }
    }
}