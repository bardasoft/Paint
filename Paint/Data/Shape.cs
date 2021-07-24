using Paint.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Data
{
    internal abstract class Shape
    {
        internal Graphics Graphics { get; set; }
        internal ShapeType ShapeType { get; set; }
        internal Point StartPoint { get; set; }
        internal Point EndPoint { get; set; }
        internal Pen Pen { get; set; }
        internal Brush Brush { get; set; }
        internal bool IsFilled { get; set; }
        internal bool IsDrawBorder { get; set; }
        internal bool IsSelected { get; set; }
        internal GraphicsPath GraphicsPath { get; set; }
        public Edge SelectedEdge { get; set; }

        public Shape()
        {

        }

        public Shape(Pen pen, Brush brush)
        {
            this.Pen = pen;
            this.Brush = brush;

        }
        internal virtual bool Select(Point point)
        {
            if (IsFilled)
            {
                return GraphicsPath.IsVisible(point);
            }
            else
            {
              return   GraphicsPath.IsOutlineVisible(point, this. Pen);
            }
        }
        protected void MovePoint(Point oldOriginPoint,Point newOriginPoint)
        {
            int dX = newOriginPoint.X - oldOriginPoint.X;
            int dy = newOriginPoint.Y - oldOriginPoint.Y;

            StartPoint = new Point(StartPoint.X + dX, StartPoint.Y + dy);
            EndPoint = new Point(EndPoint.X + dX, EndPoint.Y + dy);


        }
        protected Rectangle DetectBound()
        {
            return Utilities.GetRectangleByPoint(StartPoint, EndPoint);
        }
        internal virtual void Draw()
        { }
        internal virtual void Selected()
        {

        }

        public enum Edge
        {
            None, Left, Right, Top, Bottom
        }
    }
}
