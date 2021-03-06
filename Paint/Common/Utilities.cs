using System;
using System.Drawing;

namespace Paint.Common
{
    internal static class Utilities
    {
        internal static Point GetMinPoint(Point point1, Point point2)
        {
            Point zeroPoint = Point.Empty;
            double distance1 = DistanceTwoPoints(zeroPoint, point1);
            double distance2 = DistanceTwoPoints(zeroPoint, point2);
            return distance1 <= distance2 ? point1 : point2;
        }

        internal static double DistanceTwoPoints(Point point1, Point point2)
        {
            double deltaX = Math.Pow(point2.X - point1.X, 2);
            double deltaY = Math.Pow(point2.Y - point1.Y, 2);
            return Math.Sqrt(deltaX + deltaY);
        }

        internal static Rectangle GetRectangleByPoint(Point point1, Point point2)
        {
            int minPointX = Math.Min(point1.X, point2.X);
            int maxPointX = Math.Max(point1.X, point2.X);
            int minPointY = Math.Min(point1.Y, point2.Y);
            int maxPointY = Math.Max(point1.Y, point2.Y);

            return new Rectangle(minPointX, minPointY, maxPointX - minPointX, maxPointY - minPointY);
        }

        public static void FillArea(Bitmap bitmap, int x, int y, Color newColor)
        {
            Color oldColor = bitmap.GetPixel(x, y);
            int width = bitmap.Width;
            int height = bitmap.Height;

            if (x < 0 || x > width - 1 || y < 0 || y > height - 1) return;
            if (oldColor != newColor)
            {
                bitmap.SetPixel(x, y, newColor);
                FillArea(bitmap, x + 1, y, newColor);
                FillArea(bitmap, x - 1, y, newColor);
                FillArea(bitmap, x, y + 1, newColor);
                FillArea(bitmap, x, y - 1, newColor);
            }
        }
    }
}