using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Data
{
    class LineShape : Shape
    {
        public LineShape(Graphics graphics, Pen pen,Point startPoint, Point endPoint)
        {
            this.Graphics = graphics;
            this.Pen = pen;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }
        internal override void Draw()
        {
            Graphics.DrawLine(this.Pen, StartPoint, EndPoint);
        }
    }
}
