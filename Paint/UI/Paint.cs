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
        private bool paint;
        private Graphics graphic;
        private Bitmap bitmap;
        private bool filled;
        private Point startPoint;
        private Point endPoint;
        private Pen pen;

        private Pen erase;
        private float widthErase = 20;
        private SolidBrush brush;
        bool isFill;
        private Shape shape;
        private Shape previousShape;
        private string previousPrompt;

        Color foreColor;
        Color backgroundColor;
        Color backgroundSystemColor;

        OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        ColorDialog colorDialog;
        private string fileFommat = ".png";
        public frmPaint()
        {
            InitializeComponent();

        }
        private void frmPaint_Load(object sender, EventArgs e)
        {
            isFill = false;
            previousPrompt = string.Empty;
            openFileDialog = new OpenFileDialog()
            { };
            saveFileDialog = new SaveFileDialog();
            colorDialog = new ColorDialog();
            paint = false;
            foreColor = Color.Black;
            backgroundSystemColor = Color.White;
            bitmap = new Bitmap(picBoard.Width, picBoard.Height);

            graphic = Graphics.FromImage(bitmap);
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.InterpolationMode = InterpolationMode.High;


            graphic.Clear(backgroundSystemColor);
            picBoard.Image = bitmap;

            pen = new Pen(foreColor, float.Parse(cbxSize.Text));
            pen.LineJoin = LineJoin.Round;
            erase = new Pen(backgroundSystemColor, widthErase);
            brush = new SolidBrush(foreColor);
            btnForeColor.BackColor = foreColor;

            btnNone.Select();

        }

        private void picBoard_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            startPoint = e.Location;
        }

        private void picBoard_MouseMove(object sender, MouseEventArgs e)
        {
            tssCoordinate.Text = $"{e.X}, {e.Y}px";
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
            endPoint = e.Location;
            Paint(graphic, shape);

            switch (shape)
            {
                case Shape.Text:
                    Point eLocation = e.Location;
                    InputText inputText = new InputText();


                    Size inputSize = inputText.Size;
                    Point locationInputText = new Point(eLocation.X - 30, (int)(eLocation.Y + inputSize.Height / 2) - 50);
                    if (eLocation.X + inputSize.Width > picBoard.Width)
                    {
                        locationInputText.X = picBoard.Width - inputSize.Width;
                    }
                    if (eLocation.Y + inputSize.Height > picBoard.Height)
                    {
                        locationInputText.Y = picBoard.Height - inputSize.Height+100;

                    }
                    inputText.Location = locationInputText;
                    if (inputText.ShowDialog() == DialogResult.OK)
                    {
                        graphic.DrawString(inputText.InputString, new Font("Arial", 12), brush, startPoint);
                    }
                    break;
                default:
                    break;
            }

            picBoard.Refresh();//call paint
        }


        private void picBoard_Paint(object sender, PaintEventArgs e)
        {
            var paintGraphic = e.Graphics;

            Paint(paintGraphic, shape);




            // TextFormatFlags flags = TextFormatFlags.Bottom | TextFormatFlags.EndEllipsis;
            //TextRenderer.DrawText(e.Graphics, "This is some text that will be clipped at the end.", this.Font,
            //  new Rectangle(10, 10, 300, 50), SystemColors.ControlText/*, flags*/);
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
                    if (isFill)
                    {
                        graphic.FillRectangle(brush, rectangle);

                    }
                    else
                    {
                        graphic.DrawRectangle(pen, rectangle);
                    }

                    break;

                case Shape.Square:
                    break;

                case Shape.Ellipse:
                    Rectangle rectangleElip = Utilities.GetRectangleByPoint(startPoint, endPoint);
                    if (isFill)
                    {
                        graphic.FillEllipse(brush, rectangleElip);
                    }
                    else
                    {
                        graphic.DrawEllipse(pen, rectangleElip);
                    }

                    break;

                case Shape.Circle:
                    // MessageBox.Show(startPoint+ endPoint.ToString());
                    if (startPoint != endPoint)
                    {
                        Point center = startPoint;
                        int radius = (int)Utilities.DistanceTwoPoints(startPoint, endPoint);
                        Rectangle rect = new Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2);
                        if (isFill)
                        {
                            graphic.FillEllipse(brush, rect);
                        }
                        else
                        {
                            graphic.DrawEllipse(pen, rect);
                        }

                    }

                    break;

                case Shape.Triangle:
                    break;

                case Shape.Petagon:
                    break;

                case Shape.Hecxagon:
                    break;

                case Shape.Fill:
                    break;
                case Shape.Text:
                    break;

                default:
                    break;
            }

        }

        private void picBoard_SizeChanged(object sender, EventArgs e)
        {
            // var newbitmap = (Bitmap)picBoard.Image;

            //  bitmap = new Bitmap(picBoard.Width,picBoard.Height);
            // graphic = Graphics.FromImage(result);
            // graphic.Clear(backGroundColor);
            //graphic = Graphics.FromImage(newbitmap);
            //  graphic.DrawImage(newbitmap, 0,0);
            //  picBoard.Image = newbitmap;
            // picBoard.Image = bitmap;
            //graphic.Clear(Color.White);


        }
        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }
        //void XX(float width, float height)
        //{

        //    var brush = new SolidBrush(Color.Black);
        //    var image = new Bitmap(picBoard.Image);
        //    float scale = Math.Min(width / image.Width, height / image.Height);
        //    var bmp = new Bitmap((int)width, (int)height);
        //    var graph = Graphics.FromImage(bmp);

        //    // uncomment for higher quality output
        //    //graph.InterpolationMode = InterpolationMode.High;
        //    //graph.CompositingQuality = CompositingQuality.HighQuality;
        //    //graph.SmoothingMode = SmoothingMode.AntiAlias;

        //    var scaleWidth = (int)(image.Width * scale);
        //    var scaleHeight = (int)(image.Height * scale);

        //    graph.FillRectangle(brush, new RectangleF(0, 0, width, height));
        //    graph.DrawImage(image, ((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight);

        //}

        private void btnNone_Click(object sender, EventArgs e)
        {
            shape = Shape.None;
            tssPrompt.Text = string.Empty;

        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            shape = Shape.Line;
            tssPrompt.Text = "Pick and hold 2 points";
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            shape = Shape.Free;
            //    picBoard.Cursor = new Cursor();
            tssPrompt.Text = "Hold your mouse";
        }
        private void btnErase_Click(object sender, EventArgs e)
        {
            shape = Shape.Erase;
            //  picBoard.Cursor = new Cursor(@"D:\Libraries\Icons\eraser.ico");
            tssPrompt.Text = "Hold your mouse";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphic.Clear(Color.White);
            picBoard.Refresh();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            shape = Shape.Rectangle;
            tssPrompt.Text = "Pick and hold 2 points";

        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            shape = Shape.Ellipse;
            tssPrompt.Text = "Pick and hold 2 points";
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            shape = Shape.Circle;
            tssPrompt.Text = "Pick a center point and hold your mouse to set radius";
        }
        private void btnText_Click(object sender, EventArgs e)
        {
            shape = Shape.Text;
            tssPrompt.Text = "Pick a point to place text";
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            shape = Shape.Fill;
            tssPrompt.Text = "Pick a point to fill an are";
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                foreColor = colorDialog.Color;
                pen.Color = foreColor;
                brush.Color = foreColor;
                btnForeColor.BackColor = foreColor;
            }
        }
        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                backgroundColor = colorDialog.Color;
                //pen.Color = foreColor;
                //brush.Color = foreColor;
                //btnForeColor.BackColor = foreColor;
            }
        }
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

        private static Point set_Point(PictureBox pb, Point pt)
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

        private Color GetColorAt(int x, int y)
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
            if (shape == Shape.Fill)
            {
                Point point = set_Point(picBoard, e.Location);
                Color color = ((Bitmap)picBoard.Image).GetPixel(point.X, point.Y);
                if (color != pen.Color/*GetColorAt(e.X, e.Y) != pen.Color*/)
                {
                    Fill(bitmap, point.X, point.Y, pen.Color);
                    picBoard.Refresh();
                }
            }
            else if (shape == Shape.Point)
            {
                Point point = set_Point(picBoard, e.Location);
                foreColor = ((Bitmap)picBoard.Image).GetPixel(point.X, point.Y);
                pen.Color = foreColor;
                brush.Color = foreColor;
                btnForeColor.BackColor = foreColor;
                shape = previousShape;
                tssPrompt.Text = previousPrompt;

            }

        }

        private void picColor_MouseClick(object sender, MouseEventArgs e)
        {
            var pic = sender as PictureBox;
            Point point = set_Point(pic, e.Location);
            Color color = ((Bitmap)pic.Image).GetPixel(point.X, point.Y);
            pen.Color = color;
            brush.Color = color;
            btnForeColor.BackColor = color;

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    graphic.Clear(backgroundSystemColor);

                    Bitmap openBitmap = new Bitmap(openFileDialog.FileName);

                    //  graphic = Graphics.FromImage(openBitmap);
                    graphic.DrawImage(openBitmap, new Point(0, 0));
                    picBoard.Refresh();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                btnNone_Click(sender, e);
            }
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            previousShape = shape;
            previousPrompt = tssPrompt.Text;
            shape = Shape.Point;
            tssPrompt.Text = "Pick a point to get corlor";
            // picBoard.Cursor= new Cursor(Resources.Resource.ResourceManager.GetString(Resources.Resource.DigitalPencil))

        }

        private void chkFill_CheckedChanged(object sender, EventArgs e)
        {
            isFill = chkFill.Checked;
        }
    }
}