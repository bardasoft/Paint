using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    internal enum Shapes
    {
        None,
        Erase,
        Free,
        Line,
        Rectangle,
        Square,
        Elip,
        Circle,
        Triangle,
        Petagon,
        Hecxagon,
        Fill,
    }
    public partial class frmPaint : Form
    {
        bool paint;
        private Graphics graphic;
        Bitmap bitmap;
        private bool filled;
        Point startPoint;
        Point endPoint;
        private Pen pen;
        float widthPen =10;
        private Pen erase;
        float widthErase = 20;
        private Brush brush;
        private Shapes shape;

        public frmPaint()
        {
            InitializeComponent();
            paint = false;
            bitmap = new Bitmap(picBoard.Width, picBoard.Height);
            graphic = Graphics.FromImage(bitmap);
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.Clear(Color.White);
            picBoard.Image = bitmap;

            pen = new Pen(Color.Black,widthPen);
            erase = new Pen(Color.White, widthErase);


        }
        private void picBoard_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            startPoint = e.Location;
        }

        private void picBoard_MouseMove(object sender, MouseEventArgs e)
        {

            if (paint)
            {
                if (shape == Shapes.Free)
                {
                    endPoint = e.Location;
                    graphic.DrawLine(pen, startPoint, endPoint);
                    startPoint = endPoint;
                }
                else if(shape == Shapes.Erase)
                {

                    endPoint = e.Location;
                    graphic.DrawLine(erase, startPoint, endPoint);
                    startPoint = endPoint;
                }


            }

            picBoard.Refresh();
        }

        private void picBoard_MouseUp(object sender, MouseEventArgs e)
        {
            // picBoard.Refresh();
            paint = false;

        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            shape = Shapes.Line;
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            shape = Shapes.Free;
        }

        private void picBoard_Paint(object sender, PaintEventArgs e)
        {
            switch (shape)
            {
                case Shapes.None:
                    break;
                case Shapes.Free:
                    break;
                case Shapes.Line:
                    graphic.DrawLine(pen, startPoint, endPoint);
                    break;
                case Shapes.Rectangle:
                    break;
                case Shapes.Square:
                    break;
                case Shapes.Elip:
                    break;
                case Shapes.Circle:
                    break;
                case Shapes.Triangle:
                    break;
                case Shapes.Petagon:
                    break;
                case Shapes.Hecxagon:
                    break;
                case Shapes.Fill:
                    break;
                default:
                    break;
            }
        }



        private void picBoard_SizeChanged(object sender, EventArgs e)
        {
            bitmap = new Bitmap(picBoard.Width, picBoard.Height);
            graphic = Graphics.FromImage(bitmap);
            graphic.Clear(Color.White);
            picBoard.Image = bitmap;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            shape = Shapes.Erase;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphic.Clear(Color.White);
            picBoard.Refresh();
        }
    }
}
