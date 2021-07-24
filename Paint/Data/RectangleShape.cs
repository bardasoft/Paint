using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Paint.Common;

namespace Paint.Data
{
    class RectangleShape : Shape
    {
       internal Rectangle Rectangle { get; set; }
        public RectangleShape(Graphics graphics, SolidBrush brush,Pen pen, Point startPoint, Point endPoint, bool isFill, bool isFillBorder)
        {
            this.Graphics = graphics;
            this.Brush = brush;
            this.Pen = pen;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.IsFilled = isFill;
            this.IsDrawBorder = isFillBorder;
            Rectangle = Utilities.GetRectangleByPoint(StartPoint, EndPoint);

        }
        internal override void Draw()
        {
            if (IsFilled)
            {
                Graphics.FillRectangle(Brush, Rectangle);
                if (IsDrawBorder)
                {
                    Graphics.DrawRectangle(Pen, Rectangle);
                }
            }
            else
            {
                Graphics.DrawRectangle(Pen, Rectangle);
            }
           

        }
    }
}
