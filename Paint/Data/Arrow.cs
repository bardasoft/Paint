using System.Drawing;
namespace Paint.Data
{
    class Arrow
    {
        private Graphics graphic;
        private Pen pen;
        private Point startPoint;
        private Point endPoint;
        internal Arrow(Graphics graphic, Pen pen, Point startPoint, Point endPoint)
        {

            this.graphic = graphic;
            this.pen = pen;
            this.startPoint = startPoint;
            this.endPoint = endPoint;

            DrawArrow();
        }
        private void DrawArrow()
        {
            Point p1 = endPoint - new Size(10, 7);
            //  if(Utilities.)
            //graphic.DrawLine(pen, p1, endPoint);
            //graphic.DrawLine(pen, startPoint, endPoint);


            // Vector
        }

    }
}
