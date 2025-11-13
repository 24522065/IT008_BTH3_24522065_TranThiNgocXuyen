using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai02
{
    public partial class MainForm : Form
    {
        private Random rnd = new Random();
        private int x, y;
        private Color randomColor;
        private Font randomFont;
        private System.Windows.Forms.Timer timer;

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        public MainForm()
        {
            InitializeComponent();

            this.Paint += MainForm_Paint;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();

            GenerateRandomStyle();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GenerateRandomStyle();
            this.Invalidate(); 
        }

        private void GenerateRandomStyle()
        {
            x = rnd.Next(10, this.ClientSize.Width - 150);
            y = rnd.Next(10, this.ClientSize.Height - 50);
            randomColor = Color.FromArgb(255, rnd.Next(256), rnd.Next(256), rnd.Next(256));
            randomFont = new Font("Arial", rnd.Next(20, 60), FontStyle.Bold, GraphicsUnit.Pixel);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (SolidBrush brush = new SolidBrush(randomColor))
            {
                g.DrawString("Paint Event", randomFont, brush, new PointF(x, y));
            }
        }
    }
}
