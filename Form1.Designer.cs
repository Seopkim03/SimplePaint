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
            comboBox1 = new ComboBox();
            trackBar1 = new TrackBar();
            grpShape = new GroupBox();
            grpColor = new GroupBox();
            grpThickness = new GroupBox();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            grpShape.SuspendLayout();
            grpColor.SuspendLayout();
            grpThickness.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(-2, 0);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Black 검정", "Red 빨강", "Blue 파랑", "Green 초록" });
            comboBox1.Location = new Point(6, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(21, 26);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 5;
            // 
            // grpShape
            // 
            grpShape.Controls.Add(btnCircle);
            grpShape.Controls.Add(btnRectangle);
            grpShape.Controls.Add(btnLine);
            grpShape.Location = new Point(2, 53);
            grpShape.Name = "grpShape";
            grpShape.Size = new Size(235, 88);
            grpShape.TabIndex = 8;
            grpShape.TabStop = false;
            grpShape.Text = "도형 선택";
            // 
            // grpColor
            // 
            grpColor.Controls.Add(comboBox1);
            grpColor.Location = new Point(243, 54);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(136, 87);
            grpColor.TabIndex = 9;
            grpColor.TabStop = false;
            grpColor.Text = "색 선택";
            // 
            // grpThickness
            // 
            grpThickness.Controls.Add(trackBar1);
            grpThickness.Location = new Point(386, 53);
            grpThickness.Name = "grpThickness";
            grpThickness.Size = new Size(144, 88);
            grpThickness.TabIndex = 10;
            grpThickness.TabStop = false;
            grpThickness.Text = "선 두께";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnOpenFile.Location = new Point(563, 71);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(89, 62);
            btnOpenFile.TabIndex = 6;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSaveFile.Location = new Point(658, 71);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(89, 62);
            btnSaveFile.TabIndex = 7;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(grpThickness);
            Controls.Add(grpColor);
            Controls.Add(grpShape);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Simple Paint v1.0";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            grpShape.ResumeLayout(false);
            grpColor.ResumeLayout(false);
            grpThickness.ResumeLayout(false);
            grpThickness.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private Button btnLine;
        private Button btnRectangle;
        private Button btnCircle;
        private ComboBox comboBox1;
        private TrackBar trackBar1;
        private GroupBox grpShape;
        private GroupBox grpColor;
        private GroupBox grpThickness;
        private Button btnOpenFile;
        private Button btnSaveFile;
    }
}
