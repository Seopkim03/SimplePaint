namespace SimplePaint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            btnLine = new Button();
            btnRectangle = new Button();
            btnCircle = new Button();
            cmbColor = new ComboBox();
            trbLineWidth = new TrackBar();
            grpShape = new GroupBox();
            grpColor = new GroupBox();
            grpThickness = new GroupBox();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            picCanvas = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            grpShape.SuspendLayout();
            grpColor.SuspendLayout();
            grpThickness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(1, 1);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(231, 50);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Simple Paint";
            // 
            // btnLine
            // 
            btnLine.Image = (Image)resources.GetObject("btnLine.Image");
            btnLine.ImageAlign = ContentAlignment.TopCenter;
            btnLine.Location = new Point(9, 18);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(67, 60);
            btnLine.TabIndex = 1;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btnLine_Click;
            // 
            // btnRectangle
            // 
            btnRectangle.Image = (Image)resources.GetObject("btnRectangle.Image");
            btnRectangle.ImageAlign = ContentAlignment.TopCenter;
            btnRectangle.Location = new Point(82, 18);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(67, 60);
            btnRectangle.TabIndex = 2;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.ImageAlign = ContentAlignment.TopCenter;
            btnCircle.Location = new Point(155, 18);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(67, 60);
            btnCircle.TabIndex = 3;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black 검정", "Red 빨강", "Blue 파랑", "Green 초록" });
            cmbColor.Location = new Point(6, 32);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(121, 23);
            cmbColor.TabIndex = 4;
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(21, 26);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(104, 45);
            trbLineWidth.TabIndex = 5;
            // 
            // grpShape
            // 
            grpShape.Controls.Add(btnCircle);
            grpShape.Controls.Add(btnRectangle);
            grpShape.Controls.Add(btnLine);
            grpShape.Location = new Point(12, 56);
            grpShape.Name = "grpShape";
            grpShape.Size = new Size(235, 88);
            grpShape.TabIndex = 8;
            grpShape.TabStop = false;
            grpShape.Text = "도형 선택";
            // 
            // grpColor
            // 
            grpColor.Controls.Add(cmbColor);
            grpColor.Location = new Point(253, 57);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(136, 87);
            grpColor.TabIndex = 9;
            grpColor.TabStop = false;
            grpColor.Text = "색 선택";
            // 
            // grpThickness
            // 
            grpThickness.Controls.Add(trbLineWidth);
            grpThickness.Location = new Point(396, 56);
            grpThickness.Name = "grpThickness";
            grpThickness.Size = new Size(144, 88);
            grpThickness.TabIndex = 10;
            grpThickness.TabStop = false;
            grpThickness.Text = "선 두께";
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.FromArgb(255, 255, 128);
            btnOpenFile.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnOpenFile.Location = new Point(573, 74);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(89, 62);
            btnOpenFile.TabIndex = 6;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = SystemColors.ActiveCaption;
            btnSaveFile.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSaveFile.Location = new Point(668, 74);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(89, 62);
            btnSaveFile.TabIndex = 7;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.BorderStyle = BorderStyle.FixedSingle;
            picCanvas.Location = new Point(8, 17);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(769, 287);
            picCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
            picCanvas.TabIndex = 11;
            picCanvas.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(picCanvas);
            panel1.Location = new Point(4, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 307);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(819, 503);
            Controls.Add(panel1);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(grpThickness);
            Controls.Add(grpColor);
            Controls.Add(grpShape);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Simple Paint v1.0";
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            grpShape.ResumeLayout(false);
            grpColor.ResumeLayout(false);
            grpThickness.ResumeLayout(false);
            grpThickness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private Button btnLine;
        private Button btnRectangle;
        private Button btnCircle;
        private ComboBox cmbColor;
        private TrackBar trbLineWidth;
        private GroupBox grpShape;
        private GroupBox grpColor;
        private GroupBox grpThickness;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private PictureBox picCanvas;
        private Panel panel1;
    }
}
