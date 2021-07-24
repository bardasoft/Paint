using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Data
{
    class Shape
    {
        internal Graphics Graphics { get; set; }
        internal ShapeType ShapeType { get; set; }
        internal Point StartPoint { get; set; }
        internal Point EndPoint { get; set; }
        internal Pen Pen { get; set; }
        internal SolidBrush Brush { get; set; }
        internal bool IsFill { get; set; }
        internal bool IsSelected { get; set; }
        internal GraphicsPath Border { get; set; }
        internal virtual void Draw()
        { }
        internal virtual void Selected()
        {

        }


    }
}
