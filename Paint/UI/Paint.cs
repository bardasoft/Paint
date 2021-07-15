using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.Common;
using Paint.Data;


namespace Paint.UI
{
   
    public partial class frmPaint : Form
    {
        bool paint;
        private Graphics graphic;
        Bitmap bitmap;
        private bool filled;
        Point startPoint;
        Point endPoint;
        private Pen pen;

        private Pen erase;
        float widthErase = 20;
        private Brush brush;
        private Shape shape;

        public frmPaint()
        {
            InitializeComponent();
            paint = false;
            Color penColor = Color.Black;
            Color eraseColor = Color.White;
            bitmap = new Bitmap(picBoard.Width, picBoard.Height);
            graphic = Graphics.FromImage(bitmap);
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.Clear(eraseColor);
            picBoard.Image = bitmap;



            pen = new Pen(penColor, float.Parse(cbxSize.Text));
            erase = new Pen(eraseColor, widthErase);

            btnColor.BackColor = penColor;


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
                endPoint = e.Location;

                switch (shape)
                {
                    case Shape.None:
                        break;
                    case Shape.Free:
                        graphic.DrawLine(pen, startPoint, endPoint);
                        startPoint = endPoint;
                        break;
                    case Shape.Erase:
                        graphic.DrawLine(erase, startPoint, endPoint);
                        startPoint = endPoint;
                        break;
                    case Shape.Line:

                        break;
                    case Shape.Rectangle:
                        break;
                    case Shape.Square:
                        break;
                    case Shape.Ellipse:
                        break;
                    case Shape.Circle:
                        break;
                    case Shape.Triangle:
                        break;
                    case Shape.Petagon:
                        break;
                    case Shape.Hecxagon:
                        break;
                    case Shape.Fill:
                        break;
                    default:
                        break;
                }
                picBoard.Refresh();//call paint
            }



        }

        private void picBoard_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            Paint(graphic, shape);

        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            shape = Shape.Line;
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            shape = Shape.Free;
            //    picBoard.Cursor = new Cursor(); 
        }

        private void picBoard_Paint(object sender, PaintEventArgs e)
        {
            var paintGraphic = e.Graphics;

            Paint(paintGraphic, shape);
        }

        private new void Paint(Graphics graphic, Shape shape)
        {
            switch (shape)
            {
                case Shape.None:
                    break;
                case Shape.Free:
                    //graphic.DrawLine(pen, startPoint, endPoint);
                    //startPoint = endPoint;
                    break;
                case Shape.Erase:
                    // graphic.DrawLine(erase, startPoint, endPoint);
                    // startPoint = endPoint;
                    break;
                case Shape.Line:


                    graphic.DrawLine(pen, startPoint, endPoint);

                    break;
                case Shape.Rectangle:
                    Rectangle rectangle = Utilities.GetRectangleByPoint(startPoint, endPoint);
                    graphic.DrawRectangle(pen, rectangle);
                    break;
                case Shape.Square:
                    break;
                case Shape.Ellipse:
                    Rectangle rectangleElip = Utilities.GetRectangleByPoint(startPoint, endPoint);
                    graphic.DrawEllipse(pen, rectangleElip);
                    break;
                case Shape.Circle:
                    break;
                case Shape.Triangle:
                    break;
                case Shape.Petagon:
                    break;
                case Shape.Hecxagon:
                    break;
                case Shape.Fill:
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
            shape = Shape.Erase;
            //  picBoard.Cursor = new Cursor(@"D:\Libraries\Icons\eraser.ico");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphic.Clear(Color.White);
            picBoard.Refresh();
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            shape = Shape.Rectangle;
        }
        private void btnElip_Click(object sender, EventArgs e)
        {
            shape = Shape.Ellipse;
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            shape = Shape.Fill;
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                pen.Color = colorDialog.Color;
                btnColor.BackColor = pen.Color;
            }
        }
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName + ".bmp", ImageFormat.Bmp);
            }

        }

        private void cbxSize_SelectedIndexChanged(object sender, EventArgs e)
        {

            pen.Width = float.Parse(cbxSize.Text);
        }




        static Point set_Point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }
        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color Old_Color, Color New_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == Old_Color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, New_Color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color New_Clr)
        {
            Color Old_Color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, New_Clr);
            if (Old_Color == New_Clr) { return; }

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y - 1, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X + 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y + 1, Old_Color, New_Clr);
                }
               
            }
        }
       
        Color GetColorAt(int x, int y)
        {
            Bitmap bmp = new Bitmap(1, 1);
            Rectangle bounds = new Rectangle(x, y, 1, 1);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            }
              
            return bmp.GetPixel(0, 0);
        }
        private void picBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if(shape== Shape.Fill)
            {
                if(GetColorAt(e.X,e.Y)!=pen.Color)
                {
                    Point point = set_Point(picBoard, e.Location);
                    Fill(bitmap, point.X, point.Y, pen.Color);
                    picBoard.Refresh();
                }
               
            }
          
        }
    }
}
