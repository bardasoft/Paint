using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Data
{
    internal class CrossHair
    {
        internal Rectangle Frame { get; set; }
        private LineShape verticalLine;
        private LineShape horizontalLine;
        private RectangleShape rectangleShape;
        private static Brush brush = new SolidBrush(Color.Black);
        private Pen pen = new Pen(brush);

        public CrossHair()
        {
            verticalLine = new LineShape(pen, brush);
            horizontalLine = new LineShape(pen, brush);
            rectangleShape = new RectangleShape(pen, brush);
        }

        internal void Draw(Graphics graphics, Point origin)
        {
            verticalLine.StartPoint = new Point(origin.X, Frame.Top);
            verticalLine.EndPoint = new Point(origin.X, Frame.Bottom);
            verticalLine.Draw(graphics);

            horizontalLine.StartPoint = new Point(Frame.Left, origin.Y);
            horizontalLine.EndPoint = new Point(Frame.Right, origin.Y);
            horizontalLine.Draw(graphics);

            const int recSize = 5;
            Point recPoint = new Point(origin.X - recSize, origin.Y - recSize);

            rectangleShape.Rectangle = new Rectangle(recPoint, new Size(2 * recSize, 2 * recSize));
            rectangleShape.Draw(graphics);
        }
    }
}