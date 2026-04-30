namespace SimplePaint
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.Windows.Forms;
    using static System.Windows.Forms.DataFormats;

    public partial class Form1 : Form
    {
        //private double zoomRatio = 1.0;
        private Image originalImage = null;

        enum ToolType { Line, Rectangle, Circle }  // 사용할 도형 타입
        private Bitmap canvasBitmap;          // 실제 그림이 저장되는 비트맵
        private Graphics canvasGraphics;      // 비트맵 위에 그리기 위한 객체
        private bool isDrawing = false;       // 현재 드래그 중인지 여부
        private Point startPoint;             // 드래그 시작점
        private Point endPoint;               // 드래그 끝점
        private ToolType currentTool = ToolType.Line;  // 현재 선택된 도형
        private Color currentColor = Color.Black;      // 현재 색상
        private int currentLineWidth = 2;              // 현재 선 두께
        public Form1()
        {
            InitializeComponent();

            // 캔버스 초기화
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);   // 캔버스를 흰색으로 초기화
            picCanvas.Image = canvasBitmap;   // 그린 그림을 화면(PictureBox)에 표시

            // 마우스 이벤트 연결
            picCanvas.MouseDown += PicCanvas_MouseDown;
            picCanvas.MouseMove += PicCanvas_MouseMove;
            picCanvas.MouseUp += PicCanvas_MouseUp;

            // picCanvas가 다시 그려질 때 PicCanvas_Paint 함수를 실행하도록 연결
            picCanvas.Paint += PicCanvas_Paint;

            // 도형 선택 버튼 이벤트 연결
            btnLine.Click += btnLine_Click;
            btnRectangle.Click += btnRectangle_Click;
            btnCircle.Click += btnCircle_Click;

            // 색상 콤보박스 이벤트 연결
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            cmbColor.SelectedIndex = 0;  // 기본값: Black

            // 선 두께 트랙바 이벤트 연결
            trbLineWidth.Minimum = 1;    // 최소값
            trbLineWidth.Maximum = 10;   // 최대값
            trbLineWidth.Value = 2;
            trbLineWidth.ValueChanged += trbLineWidth_ValueChanged;

            //this.picCanvas.MouseWheel += new MouseEventHandler(picCanvas_MouseWheel);
        }

        private void PicCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;             // 드래그 시작
            startPoint = e.Location;      // 시작점 저장
        }
        private void PicCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;       // 그림 그리기와 상관 없는 마우스 움직임은 무시 endPoint = e.Location;        // 현재 위치 갱신
                                          // picCanvas를 다시 그려라 (Paint 이벤트를 발생시킨다)
            picCanvas.Invalidate();       // 화면 다시 그리기 (미리보기)
        }
        private void PicCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;     // 그림 그리기와 상관 없는 마우스 움직임은 무시
            isDrawing = false;          // 드래그 종료
            endPoint = e.Location; // 최종 위치 저장
            // 실제 비트맵에 도형 그리기 (확정)
            using (Pen pen = new Pen(currentColor, currentLineWidth))
            {
                DrawShape(canvasGraphics, pen, startPoint, endPoint);
            }
            picCanvas.Invalidate();     // 다시 그려서 결과 반영, Paint 이벤트 발생
        }
        private void DrawShape(Graphics g, Pen pen, Point p1, Point p2)
        {
            Rectangle rect = GetRectangle(p1, p2);
            switch (currentTool)
            {
                case ToolType.Line:
                    g.DrawLine(pen, p1, p2);
                    break;
                case ToolType.Rectangle:
                    g.DrawRectangle(pen, rect);
                    break;
                case ToolType.Circle:
                    g.DrawEllipse(pen, rect);
                    break;
            }
        }
        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!isDrawing)
                return;
            // 점선 펜 (미리보기용)
            using (Pen previewPen = new Pen(currentColor, currentLineWidth))
            {
                previewPen.DashStyle = DashStyle.Dash;
                DrawShape(e.Graphics, previewPen, startPoint, endPoint);
            }
        }
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
            Math.Min(p1.X, p2.X),
            Math.Min(p1.Y, p2.Y),
            Math.Abs(p1.X - p2.X),
            Math.Abs(p1.Y - p2.Y)
            );
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Line;
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Rectangle;
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Circle;
        }
        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColor.SelectedIndex)
            {
                case 0: // Black 검정
                    currentColor = Color.Black; break;
                case 1: // Red 빨강
                    currentColor = Color.Red; break;
                case 2: // Blue 파랑
                    currentColor = Color.Blue; break;
                case 3: // Green 녹색
                    currentColor = Color.Green; break;
                default:
                    currentColor = Color.Black; break;
            }
        }
        private void trbLineWidth_ValueChanged(object sender, EventArgs e)
        {
            currentLineWidth = trbLineWidth.Value;
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "이미지 열기";
                ofd.Filter = "이미지 파일 (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png|모든 파일 (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 기존 이미지가 있다면 해제
                        if (originalImage != null)
                        {
                            originalImage.Dispose();
                            originalImage = null;
                        }
                        // 선택한 이미지 로드
                        originalImage = Image.FromFile(ofd.FileName);
                        // 캔버스 크기에 맞게 조정하여 표시
                        canvasGraphics.Clear(Color.White); // 캔버스 초기화
                        canvasGraphics.DrawImage(originalImage, new Rectangle(0, 0, picCanvas.Width, picCanvas.Height));
                        picCanvas.Invalidate(); // 화면 갱신
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"이미지를 여는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            // 1. PictureBox에 이미지가 있는지 검사
            if (picCanvas.Image == null)
            {
                MessageBox.Show("저장할 이미지가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. 저장 대화상자 설정
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "이미지 저장하기";
                // 요청하신 BMP, PNG, JPEG 형식만 필터에 추가
                sfd.Filter = "Bitmap 파일 (*.bmp)|*.bmp|PNG 파일 (*.png)|*.png|JPEG 파일 (*.jpg;*.jpeg)|*.jpg";
                sfd.DefaultExt = "png"; // 기본 확장자 설정
                sfd.AddExtension = true;

                // 3. 사용자가 저장 버튼을 눌렀을 때
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 선택한 파일의 확장자 확인
                        string filePath = sfd.FileName;
                        string extension = System.IO.Path.GetExtension(filePath).ToLower();

                        // 확장자에 따른 이미지 포맷 결정
                        System.Drawing.Imaging.ImageFormat format;
                        switch (extension)
                        {
                            case ".bmp":
                                format = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                            case ".jpg":
                            case ".jpeg":
                                format = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case ".png":
                            default:
                                format = System.Drawing.Imaging.ImageFormat.Png;
                                break;
                        }

                        // 4. 이미지 저장 실행
                        picCanvas.Image.Save(filePath, format);
                        MessageBox.Show("성공적으로 저장되었습니다!", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"저장 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
