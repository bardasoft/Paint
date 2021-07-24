using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Paint.Common;

namespace Paint.Data
{
    class CircleShape : Shape
    {
        internal Point CenterPoint { get; set; }
        internal int Radius { get; set; }
        internal Rectangle RectangleBorder { get; set; }
        public CircleShape(Graphics graphics, SolidBrush brush, Pen pen, Point startPoint, Point endPoint, bool isFill)
        {
            this.Graphics = graphics;
            this.Brush = brush;
            this.Pen = pen;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.IsFill = isFill;
            this.CenterPoint = StartPoint;
            Radius = (int)Utilities.DistanceTwoPoints(StartPoint, EndPoint);
            RectangleBorder = new Rectangle(this.CenterPoint.X - Radius, CenterPoint.Y - Radius, Radius * 2, Radius * 2);
        }
        internal override void Draw()
        {
            if (StartPoint != EndPoint)
            {
                if (IsFill)
                {
                    Graphics.FillEllipse(Brush, RectangleBorder);
                }
                else
                {
                    Graphics.DrawEllipse(Pen, RectangleBorder);
                }
            }
        }
    }
}
