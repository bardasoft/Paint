
namespace Paint.UI
{
    partial class frmPaint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaint));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.chkFill = new System.Windows.Forms.CheckBox();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnFree = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btbTriangle = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnDoubleArrow = new System.Windows.Forms.Button();
            this.btnArrow = new System.Windows.Forms.Button();
            this.btnRightTriangle = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.picBoard = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssCoordinate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.tssPrompt = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picBoard, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1230, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1230, 100);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1222, 72);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 982F));
            this.tableLayoutPanel4.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnOpen, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1222, 72);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(96, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(48, 48);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(48, 0);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(48, 48);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(48, 48);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1222, 72);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Home";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 21;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnColorPicker, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBackgroundColor, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnForeColor, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.picColor, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNone, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnText, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFree, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLine, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRectangle, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEllipse, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCircle, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.btbTriangle, 12, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 20, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnErase, 19, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFill, 18, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDoubleArrow, 17, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnArrow, 16, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRightTriangle, 13, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPolygon, 14, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1222, 72);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnColorPicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnColorPicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorPicker.Location = new System.Drawing.Point(358, 0);
            this.btnColorPicker.Margin = new System.Windows.Forms.Padding(0);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(48, 48);
            this.btnColorPicker.TabIndex = 10;
            this.btnColorPicker.Text = "Color\r\nPicker";
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackgroundColor.BackgroundImage")));
            this.btnBackgroundColor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBackgroundColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnBackgroundColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor.Location = new System.Drawing.Point(310, 0);
            this.btnBackgroundColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(46, 48);
            this.btnBackgroundColor.TabIndex = 9;
            this.btnBackgroundColor.Text = "Background\r\nColor";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // btnForeColor
            // 
            this.btnForeColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForeColor.BackgroundImage")));
            this.btnForeColor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnForeColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnForeColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForeColor.Location = new System.Drawing.Point(262, 0);
            this.btnForeColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(46, 48);
            this.btnForeColor.TabIndex = 8;
            this.btnForeColor.Text = "Fore Color";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // picColor
            // 
            this.picColor.Image = global::Paint.Resources.Resource.ColorChart;
            this.picColor.Location = new System.Drawing.Point(48, 0);
            this.picColor.Margin = new System.Windows.Forms.Padding(0);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(214, 64);
            this.picColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picColor.TabIndex = 1;
            this.picColor.TabStop = false;
            this.picColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picColor_MouseClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.3268F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.6732F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbxSize, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkFill, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(406, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(110, 72);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // cbxSize
            // 
            this.cbxSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "15",
            "18",
            "20",
            "22",
            "25",
            "28",
            "30",
            "32",
            "35",
            "40",
            "45",
            "50"});
            this.cbxSize.Location = new System.Drawing.Point(63, 6);
            this.cbxSize.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(39, 23);
            this.cbxSize.TabIndex = 2;
            this.cbxSize.Text = "1";
            this.cbxSize.SelectedIndexChanged += new System.EventHandler(this.cbxSize_SelectedIndexChanged);
            // 
            // chkFill
            // 
            this.chkFill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkFill.AutoSize = true;
            this.chkFill.Location = new System.Drawing.Point(7, 36);
            this.chkFill.Margin = new System.Windows.Forms.Padding(0);
            this.chkFill.Name = "chkFill";
            this.chkFill.Size = new System.Drawing.Size(41, 19);
            this.chkFill.TabIndex = 4;
            this.chkFill.Text = "Fill";
            this.chkFill.UseVisualStyleBackColor = true;
            this.chkFill.CheckedChanged += new System.EventHandler(this.chkFill_CheckedChanged);
            // 
            // btnNone
            // 
            this.btnNone.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnNone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNone.Location = new System.Drawing.Point(0, 0);
            this.btnNone.Margin = new System.Windows.Forms.Padding(0);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(46, 48);
            this.btnNone.TabIndex = 0;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnText
            // 
            this.btnText.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnText.Location = new System.Drawing.Point(516, 0);
            this.btnText.Margin = new System.Windows.Forms.Padding(0);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(46, 48);
            this.btnText.TabIndex = 1;
            this.btnText.Text = "Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnFree
            // 
            this.btnFree.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnFree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFree.Location = new System.Drawing.Point(564, 0);
            this.btnFree.Margin = new System.Windows.Forms.Padding(0);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(46, 48);
            this.btnFree.TabIndex = 2;
            this.btnFree.Text = "Free";
            this.btnFree.UseVisualStyleBackColor = true;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // btnLine
            // 
            this.btnLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Location = new System.Drawing.Point(612, 0);
            this.btnLine.Margin = new System.Windows.Forms.Padding(0);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(46, 48);
            this.btnLine.TabIndex = 3;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Location = new System.Drawing.Point(660, 0);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(0);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(46, 48);
            this.btnRectangle.TabIndex = 4;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.Location = new System.Drawing.Point(708, 0);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(0);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(46, 48);
            this.btnEllipse.TabIndex = 5;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCircle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCircle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.Location = new System.Drawing.Point(756, 0);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(0);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(46, 48);
            this.btnCircle.TabIndex = 6;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btbTriangle
            // 
            this.btbTriangle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btbTriangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btbTriangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbTriangle.Location = new System.Drawing.Point(804, 0);
            this.btbTriangle.Margin = new System.Windows.Forms.Padding(0);
            this.btbTriangle.Name = "btbTriangle";
            this.btbTriangle.Size = new System.Drawing.Size(46, 48);
            this.btbTriangle.TabIndex = 6;
            this.btbTriangle.Text = "Triangle";
            this.btbTriangle.UseVisualStyleBackColor = true;
            this.btbTriangle.Click += new System.EventHandler(this.btbTriangle_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1188, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(34, 24);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnErase
            // 
            this.btnErase.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnErase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnErase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErase.Location = new System.Drawing.Point(1140, 0);
            this.btnErase.Margin = new System.Windows.Forms.Padding(0);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(46, 48);
            this.btnErase.TabIndex = 7;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnFill
            // 
            this.btnFill.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnFill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.Location = new System.Drawing.Point(1092, 0);
            this.btnFill.Margin = new System.Windows.Forms.Padding(0);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(46, 48);
            this.btnFill.TabIndex = 0;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnDoubleArrow
            // 
            this.btnDoubleArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDoubleArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnDoubleArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDoubleArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoubleArrow.Location = new System.Drawing.Point(1044, 0);
            this.btnDoubleArrow.Margin = new System.Windows.Forms.Padding(0);
            this.btnDoubleArrow.Name = "btnDoubleArrow";
            this.btnDoubleArrow.Size = new System.Drawing.Size(46, 48);
            this.btnDoubleArrow.TabIndex = 7;
            this.btnDoubleArrow.Text = "Double Arrow";
            this.btnDoubleArrow.UseVisualStyleBackColor = true;
            this.btnDoubleArrow.Click += new System.EventHandler(this.btnDoubleArrow_Click);
            // 
            // btnArrow
            // 
            this.btnArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrow.Location = new System.Drawing.Point(996, 0);
            this.btnArrow.Margin = new System.Windows.Forms.Padding(0);
            this.btnArrow.Name = "btnArrow";
            this.btnArrow.Size = new System.Drawing.Size(46, 48);
            this.btnArrow.TabIndex = 7;
            this.btnArrow.Text = "Arrow";
            this.btnArrow.UseVisualStyleBackColor = true;
            this.btnArrow.Click += new System.EventHandler(this.btnArrow_Click);
            // 
            // btnRightTriangle
            // 
            this.btnRightTriangle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRightTriangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnRightTriangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRightTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightTriangle.Location = new System.Drawing.Point(852, 0);
            this.btnRightTriangle.Margin = new System.Windows.Forms.Padding(0);
            this.btnRightTriangle.Name = "btnRightTriangle";
            this.btnRightTriangle.Size = new System.Drawing.Size(46, 48);
            this.btnRightTriangle.TabIndex = 6;
            this.btnRightTriangle.Text = "RightTriangle";
            this.btnRightTriangle.UseVisualStyleBackColor = true;
            this.btnRightTriangle.Click += new System.EventHandler(this.btnRightTriangle_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPolygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnPolygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolygon.Location = new System.Drawing.Point(900, 0);
            this.btnPolygon.Margin = new System.Windows.Forms.Padding(0);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(46, 48);
            this.btnPolygon.TabIndex = 6;
            this.btnPolygon.Text = "Polygon";
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // picBoard
            // 
            this.picBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoard.Location = new System.Drawing.Point(0, 100);
            this.picBoard.Margin = new System.Windows.Forms.Padding(0);
            this.picBoard.Name = "picBoard";
            this.picBoard.Size = new System.Drawing.Size(1230, 500);
            this.picBoard.TabIndex = 1;
            this.picBoard.TabStop = false;
            this.picBoard.SizeChanged += new System.EventHandler(this.picBoard_SizeChanged);
            this.picBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.picBoard_Paint);
            this.picBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBoard_MouseClick);
            this.picBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoard_MouseDown);
            this.picBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoard_MouseMove);
            this.picBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoard_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssCoordinate,
            this.toolStripSplitButton2,
            this.tssPrompt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1230, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssCoordinate
            // 
            this.tssCoordinate.Margin = new System.Windows.Forms.Padding(0);
            this.tssCoordinate.Name = "tssCoordinate";
            this.tssCoordinate.Size = new System.Drawing.Size(66, 22);
            this.tssCoordinate.Text = "Coordinate";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(26, 20);
            this.toolStripSplitButton2.Text = "|";
            // 
            // tssPrompt
            // 
            this.tssPrompt.Name = "tssPrompt";
            this.tssPrompt.Size = new System.Drawing.Size(47, 17);
            this.tssPrompt.Text = "Prompt";
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNone;
            this.ClientSize = new System.Drawing.Size(1230, 600);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPaint";
            this.Text = "Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPaint_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnFree;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssCoordinate;
        private System.Windows.Forms.ToolStripStatusLabel tssPrompt;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox picBoard;
        private System.Windows.Forms.CheckBox chkFill;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnArrow;
        private System.Windows.Forms.Button btnDoubleArrow;
        private System.Windows.Forms.Button btbTriangle;
        private System.Windows.Forms.Button btnRightTriangle;
        private System.Windows.Forms.Button btnPolygon;
    }
}

