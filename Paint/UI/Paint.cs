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
using Paint.Core;

namespace Paint.UI
{
    public partial class frmPaint : Form
    {
        private BufferedGraphics buffer;
        private BufferedGraphicsContext context;
        private List<Shape> drewShapes;
        private Shape selectedShape;

        private bool paint;
        private Graphics graphic;
        private Bitmap bitmap;
        private bool filled;
        private Point startPoint;
        private Point endPoint;
        private Point pointLocation;
        private Pen pen;

        private Pen erase;
        private float widthErase = 20;
        private SolidBrush brush;
        private bool isFill;
        private ShapeType shapeType;
        private ActionType currentAction;
        private ShapeType previousShape;
        private string previousPrompt;
        private Color foreColor;
        private Color backgroundColor;
        private Color backgroundSystemColor;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ColorDialog colorDialog;
        private const string fileFommat = ".png";

        private Selection selection;
        private CrossHair crossHair;

        private bool showCrossHair;

        public frmPaint()
        {
            InitializeComponent();
            cbxLDashStyle.Items.AddRange(Enum.GetNames(typeof(DashStyle)));
        }

        private void frmPaint_Load(object sender, EventArgs e)
        {
            InitGraphics();
            InitData();
        }

        private void InitGraphics()
        {
            //context = BufferedGraphicsManager.Current;
            //context.MaximumBuffer = new Size(this.Width, this.Height);
            //buffer = context.Allocate(picBoard.CreateGraphics(), picBoard.DisplayRectangle);
            //buffer.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            bitmap = new Bitmap(picBoard.Width, picBoard.Height);
            graphic = Graphics.FromImage(bitmap);
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.InterpolationMode = InterpolationMode.High;

            graphic.Clear(backgroundSystemColor);
            picBoard.Image = bitmap;
        }

        private void InitData()
        {
            paint = false;
            isFill = false;
            selection = new Selection(graphic);

            previousPrompt = string.Empty;
            openFileDialog = new OpenFileDialog()
            { };
            saveFileDialog = new SaveFileDialog();
            colorDialog = new ColorDialog();

            foreColor = Color.Black;
            backgroundSystemColor = Color.White;

            pen = new Pen(foreColor, float.Parse(cbxSize.Text));
            pen.LineJoin = LineJoin.Round;
            erase = new Pen(backgroundSystemColor, widthErase);
            brush = new SolidBrush(backgroundColor);

            crossHair = new CrossHair()
            {
                Frame = new Rectangle(0, 0, picBoard.Width, picBoard.Height)
            };
            showCrossHair = true;
            btnForeColor.BackColor = foreColor;
            cbxLDashStyle.SelectedIndex = 0;
            btnNone.Select();
            currentAction = ActionType.Select;
        }

        private void picBoard_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            startPoint = e.Location;
            switch (currentAction)
            {
                case ActionType.Select:
                    selection.MouseDownSelect(startPoint);
                    break;

                case ActionType.Draw:
                    break;

                case ActionType.Drawing:
                    break;

                case ActionType.Zoom:
                    break;

                default:
                    break;
            }
            //switch (currentAction)
            //{
            //    case ActionType.Select:
            //        MouseDown_Select(e.Location);
            //        break;
            //    //case ActionType.Draw:
            //    //    AddShape();
            //    //    Drawshapes[Drawshapes.Count - 1].StartPoint = e.Location;
            //    //    Drawshapes[Drawshapes.Count - 1].AddPoint(e.Location);
            //    //    Drawshapes[Drawshapes.Count - 1].AddPoint(e.Location);
            //    //   currentAction = ActionType.Drawing;
            //    //    break;
            //    case ActionType.Drawing:
            //        MouseDown_Drawing(e);
            //        break;
            //}
        }

        private void picBoard_MouseMove(object sender, MouseEventArgs e)
        {
            tssCoordinate.Text = $"{e.X}, {e.Y}px";

            pointLocation = e.Location;

            if (paint)
            {
                endPoint = e.Location;
                switch (currentAction)
                {
                    case ActionType.Select:
                        // selection.MouseMoveSelect(endPoint);

                        break;

                    case ActionType.Drawing:
                        // MouseMove_Drawing(e.Location);
                        break;
                }
            }

            // endPoint = e.Location;

            //switch (Shape)
            //{
            //    case ShapeType.None:
            //        break;

            //    case ShapeType.Free:
            //        pen.LineJoin = LineJoin.Round;
            //        pen.StartCap = LineCap.Flat;
            //        pen.EndCap = LineCap.Flat;
            //        graphic.DrawLine(pen, startPoint, endPoint);
            //        startPoint = endPoint;
            //        break;

            //    case ShapeType.Erase:
            //        pen.LineJoin = LineJoin.Round;
            //        pen.StartCap = LineCap.Flat;
            //        pen.EndCap = LineCap.Flat;
            //        graphic.DrawLine(erase, startPoint, endPoint);
            //        startPoint = endPoint;
            //        break;

            //    case ShapeType.Line:

            //        break;

            //    case ShapeType.Rectangle:
            //        break;

            //    case ShapeType.Square:
            //        break;

            //    case ShapeType.Ellipse:
            //        break;

            //    case ShapeType.Circle:
            //        break;

            //    case ShapeType.Triangle:
            //        break;

            //    case ShapeType.Petagon:
            //        break;

            //    case ShapeType.Hecxagon:
            //        break;

            //    case ShapeType.Fill:
            //        break;

            //    default:
            //        break;
            //}
            picBoard.Refresh();//call paint
        }

        private void picBoard_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            endPoint = e.Location;
            switch (currentAction)
            {
                case ActionType.Select:

                    // picBoard.Refresh();
                    //buffer.Render();
                    break;

                case ActionType.Draw:
                    break;

                case ActionType.Drawing:
                    break;

                case ActionType.Zoom:
                    break;

                default:
                    break;
            }
        }

        private void MouseMove_Drawing(Point eLocation)
        {
            if (drewShapes.Count <= 0) return;

            //Cập nhật các điểm để vẽ
            //Hình dáng mouse
            // pnlPaint.Cursor = Cursors.Cross;
            //Đối với cách hình thông thường
            //if (MyShape != SHAPES.CURVE && MyShape != SHAPES.POLYGON && MyShape != SHAPES.CLOSEDCURVE)
            //    DrawObj[DrawObj.Count - 1].AddPoint(eLocation);
            //Đối với Curve và Polygon
            //else
            //{
            //    if (MyShape == SHAPES.CURVE)
            //    {
            //        var shape = (DrawObj[DrawObj.Count - 1] as MyCurve);
            //        int i = shape.LPoints.Count;
            //        shape.LPoints[i - 1] = eLocation;
            //    }
            //    else if (MyShape == SHAPES.POLYGON)
            //    {
            //        var shape = (DrawObj[DrawObj.Count - 1] as MyPolygon);
            //        int i = shape.LPoints.Count;
            //        shape.LPoints[i - 1] = eLocation;
            //    }
            //    else if (MyShape == SHAPES.CLOSEDCURVE)
            //    {
            //        var shape = (DrawObj[DrawObj.Count - 1] as MyClosedCurve);
            //        int i = shape.LPoints.Count;
            //        shape.LPoints[i - 1] = eLocation;
            //    }
            //}
            RePaint();
        }

        private void MouseDown_Drawing(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (drewShapes.Count < 1) return;
                    drewShapes[drewShapes.Count - 1].AddPoint(e.Location);
                    break;

                case MouseButtons.Right:
                    currentAction = ActionType.Draw;
                    break;
            }
        }

        private List<Point> ps = new List<Point>();

        private void picBoard_Paint(object sender, PaintEventArgs e)
        {
            var paintGraphic = e.Graphics;

            switch (currentAction)
            {
                case ActionType.Select:
                    selection.graphics = paintGraphic;
                    selection.MouseMoveSelect(endPoint);

                    break;

                case ActionType.Drawing:
                    // MouseMove_Drawing(e.Location);
                    break;
            }

            if (showCrossHair)
            {
                crossHair.Draw(paintGraphic, pointLocation);
            }

            // Paint(paintGraphic, Shape);
        }

        private new void Paint(Graphics graphic, ShapeType shape)
        {
        }

        private void MouseDown_Select(Point point)
        {
        }

        private void RePaint()
        {
            using (Brush brush = new SolidBrush(Color.White))
            {
                buffer.Graphics.FillRectangle(brush, 0, 0, picBoard.Width, picBoard.Height);
                drewShapes.ForEach(shape => shape.Draw(buffer.Graphics));
                //if (IsDrawRegion)
                //    using (Pen pen = new Pen(Color.Black) { DashStyle = DashStyle.Dash })
                //    {
                //        Gp.Graphics.DrawRectangle(pen, SelectedRegion);
                //    }
                picBoard.Focus();
                buffer.Render();
            }
        }

        private Shape SelectShape(Point p)
        {
            int index = -1;
            for (int i = 0; i < drewShapes.Count; i++)
            {
                drewShapes[i].IsSelected = false;
                if (drewShapes[i].Select(p))
                {
                    drewShapes[i].IsSelected = true;
                    index = i;
                }
            }
            return index >= 0 ? drewShapes[index] : null;
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

        private void btnNone_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.None;
            tssPrompt.Text = string.Empty;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Line;
            tssPrompt.Text = "Pick and hold 2 points";
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Free;
            //    picBoard.Cursor = new Cursor();
            tssPrompt.Text = "Hold your mouse";
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Erase;
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
            shapeType = ShapeType.Rectangle;
            tssPrompt.Text = "Pick and hold 2 points";
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Ellipse;
            tssPrompt.Text = "Pick and hold 2 points";
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Circle;
            tssPrompt.Text = "Pick a center point and hold your mouse to set radius";
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Text;
            tssPrompt.Text = "Pick a point to place text";
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Fill;
            tssPrompt.Text = "Pick a point to fill an are";
        }

        private void btnArrow_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Arrow;
        }

        private void btnDoubleArrow_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.DoubleArrow;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Triangle;
        }

        private void btnRightTriangle_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.RightTriangle;
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Polygon;
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                foreColor = colorDialog.Color;
                pen.Color = foreColor;
                btnForeColor.BackColor = foreColor;
            }
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                backgroundColor = colorDialog.Color;

                brush.Color = backgroundColor;

                btnBackgroundColor.BackColor = backgroundColor;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
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

        private void cbxLDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen.DashStyle = Enum.Parse<DashStyle>(cbxLDashStyle.SelectedItem.ToString());
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
            if (shapeType == ShapeType.Fill)
            {
                Point point = set_Point(picBoard, e.Location);
                Color color = ((Bitmap)picBoard.Image).GetPixel(point.X, point.Y);
                if (color != brush.Color/*GetColorAt(e.X, e.Y) != pen.Color*/)
                {
                    Fill(bitmap, point.X, point.Y, brush.Color);
                    // Utilities. FillArea(bitmap, point.X, point.Y, pen.Color);
                    picBoard.Refresh();
                }
            }
            else if (shapeType == ShapeType.Point)
            {
                Point point = set_Point(picBoard, e.Location);
                foreColor = ((Bitmap)picBoard.Image).GetPixel(point.X, point.Y);
                pen.Color = foreColor;

                btnForeColor.BackColor = foreColor;
                shapeType = previousShape;
                tssPrompt.Text = previousPrompt;
            }
            else if (shapeType == ShapeType.Polygon)
            {
            }
        }

        private void picColor_MouseClick(object sender, MouseEventArgs e)
        {
            var pic = sender as PictureBox;
            Point point = set_Point(pic, e.Location);
            Color color = ((Bitmap)pic.Image).GetPixel(point.X, point.Y);
            pen.Color = color;
            btnForeColor.BackColor = color;
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            previousShape = shapeType;
            previousPrompt = tssPrompt.Text;
            shapeType = ShapeType.Point;
            tssPrompt.Text = "Pick a point to get corlor";
            // picBoard.Cursor= new Cursor(Resources.Resource.ResourceManager.GetString(Resources.Resource.DigitalPencil))
        }

        private void chkFill_CheckedChanged(object sender, EventArgs e)
        {
            isFill = chkFill.Checked;
        }

        private void frmPaint_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void frmPaint_KeyUp(object sender, KeyEventArgs e)
        {
            tssCommand.Text = e.KeyCode.ToString();
            if (e.KeyCode == Keys.Enter)
            {
                if (shapeType == ShapeType.Polygon)
                {
                    GraphicsPath gpath = new GraphicsPath();
                    if (ps.Count > 2)
                    {
                        gpath.AddClosedCurve(ps.ToArray(), 0);
                        if (isFill)
                        {
                            graphic.FillPath(brush, gpath);
                        }
                        else
                        {
                            graphic.DrawPath(pen, gpath);
                        }
                        ps.Clear();

                        picBoard.Invalidate();
                    }
                }
            }
        }

        private void picBoard_MouseLeave(object sender, EventArgs e)
        {
            //Cursor.Show();
        }

        private void chkShowCrossHair_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowCrossHair.Checked)
            {
                showCrossHair = true;
            }
            else
                showCrossHair = false;
        }
    }
}