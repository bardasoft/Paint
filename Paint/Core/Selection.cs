using Paint.Common;
using Paint.Data;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Core
{
    internal class Selection
    {
        private Point startPoint { get; set; }
        private Point endPoint { get; set; }
        private RectangleShape rectangleShapeFill;
        private RectangleShape rectangleShapeNoFill;

        internal Graphics graphics;
        private Brush brush;
        private Pen pen;

        public Selection(Graphics graphics)
        {
            this.graphics = graphics;
            brush = new SolidBrush(Color.Blue);
            pen = new Pen(brush)
            {
                DashStyle = DashStyle.Dash,
                DashPattern = new float[2] { 5, 5 }
            };
        }

        internal void MouseDownSelect(Point startpoint)
        {
            this.startPoint = startpoint;
        }

        internal void MouseMoveSelect(Point pointUpdate)
        {
            this.endPoint = pointUpdate;
            if (startPoint != endPoint)
            {
                Point p = Utilities.GetMinPoint(startPoint, endPoint);
                rectangleShapeNoFill = new RectangleShape(brush, pen, startPoint, endPoint, false, true);
                rectangleShapeNoFill.Draw(graphics);
                //if (endPoint.X > startPoint.X)
                //{
                //    rectangleShapeNoFill = new RectangleShape(brush, pen, startPoint, endPoint, false, true);
                //    rectangleShapeNoFill.Draw(graphics);
                //}
                //else
                //{
                //    rectangleShapeFill = new RectangleShape(brush, pen, startPoint, endPoint, true, true);
                //    rectangleShapeFill.Draw(graphics);
                //}
            }
        }

        internal void MouseUpSelect()
        {
        }
    }
}