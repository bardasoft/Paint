using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Paint.Common;

namespace Paint.Data
{
    class EllipseShape : Shape
    {
        internal Point CenterPoint { get; set; }
        internal Rectangle Rectangle { get; set; }
        public EllipseShape(Graphics graphics, SolidBrush brush, Pen pen, Point startPoint, Point endPoint, bool isFill , bool isFillBorder)
        {
            this.Graphics = graphics;
            this.Brush = brush;
            this.Pen = pen;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.IsFilled = isFill;
            this.IsDrawBorder = isFillBorder;
            this.CenterPoint = StartPoint;

            Rectangle = Utilities.GetRectangleByPoint(StartPoint, EndPoint);
        }
        internal override void Draw()
        {
            if (StartPoint != EndPoint)
            {
                if (IsFilled)
                {
                    Graphics.FillEllipse(Brush, Rectangle);
                    if (IsDrawBorder)
                    {
                        Graphics.DrawEllipse(Pen, Rectangle);
                    }
                }
                else
                {
                    Graphics.DrawEllipse(Pen, Rectangle);
                }
            }
        }
    }
}
