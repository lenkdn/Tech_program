using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Lab17
{
    public partial class Form1 : Form
    {
        const int R1 = 50, R2 = 100;
        int D1 = R1 * 2,
            D2 = R2 * 2;
        float centerX = 200;
        float centerY = 200;

        Brush br1 = new SolidBrush(DefaultBackColor);
        Brush br2 = new SolidBrush(DefaultBackColor);
        Brush new_br = new SolidBrush(Color.DarkGray);

        Boolean DropStarted = false;

        public Form1()
        {
            InitializeComponent();

            foreach (Control ctrl in this.Controls)
            {
                if ((ctrl as Label) != null)
                {
                    (ctrl as Label).MouseDown += label_MouseDown;
                    (ctrl as Label).MouseMove += label_MouseMove;
                    (ctrl as Label).MouseUp += label_MouseUp;
                }
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics figure = e.Graphics;
            figure.DrawEllipse(Pens.Black, centerX - R1, centerY - R1, D1, D1);
            figure.DrawEllipse(Pens.Black, centerX - R2, centerY - R2, D2, D2);
            figure.DrawEllipse(Pens.Black, centerX - R2, centerY, D1, D1);

            Pen lineX = new Pen(Color.Black, 2) { CustomEndCap = new AdjustableArrowCap(5, 5) },
                lineY = new Pen(Color.Black, 2) { CustomEndCap = new AdjustableArrowCap(5, 5) },
                lineDiag = new Pen(Color.Black, 2),
                lineStrih = new Pen(Color.Black, 2);

            figure.DrawLine(lineX, 50, centerY, pictureBox1.Width - 50, centerY);
            figure.DrawLine(lineY, centerX, pictureBox1.Height - 50, centerX, 50);
            figure.DrawLine(lineDiag, centerX - R2, centerY + R2, centerX + R2 + 10, centerY - R2 - 10);

            lineStrih.DashStyle = DashStyle.Dash;
            figure.DrawLine(lineStrih, centerX, centerY - R2, centerX + R2, centerY - R2);
            figure.DrawLine(lineStrih, centerX + R2, centerY, centerX + R2, centerY - R2);

            figure.FillEllipse(Brushes.Black, centerX - R1 - 5, centerY - 5, 10, 10);
            figure.FillEllipse(Brushes.Black, centerX - 5, centerY + R1 - 5, 10, 10);
            figure.FillEllipse(Brushes.Black, centerX + R2 - 5, centerY - 5, 10, 10);
            figure.FillEllipse(Brushes.Black, centerX + R2 - 5, centerY - R2 - 5, 10, 10);

            GraphicsPath gp1 = new GraphicsPath();
            gp1.AddPie(centerX - R2, centerY - R2, D2, D2, 270, 45);
            gp1.AddPie(centerX - R1, centerY - R1, D1, D1, 270, 45);
            Region r1 = new Region(gp1);

            GraphicsPath gp2 = new GraphicsPath();
            gp2.AddPie(centerX - R2, centerY, D1, D1, -45, 180);
            GraphicsPath gp3 = new GraphicsPath();
            gp3.AddPie(centerX - R2, centerY - R2, D2, D2, 90, 45);
            gp3.AddEllipse(centerX - R1, centerY - R1, D1, D1);
            Region r2 = new Region(gp2);
            Region r3 = new Region(gp3);
            r2.Intersect(r3);
            figure.FillRegion(br1, r1);
            figure.FillRegion(br2, r2);
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int X = e.X, Y = e.Y;
            Brush old = new SolidBrush(DefaultBackColor);

            GraphicsPath gp1 = new GraphicsPath();
            gp1.AddPie(centerX - R2, centerY - R2, D2, D2, 270, 45);
            gp1.AddPie(centerX - R1, centerY - R1, D1, D1, 270, 45);
            Region r1 = new Region(gp1);

            GraphicsPath gp2 = new GraphicsPath();
            gp2.AddPie(centerX - R2, centerY, D1, D1, -45, 180);
            GraphicsPath gp3 = new GraphicsPath();
            gp3.AddPie(centerX - R2, centerY - R2, D2, D2, 90, 45);
            gp3.AddEllipse(centerX - R1, centerY - R1, D1, D1);
            Region r2 = new Region(gp2);
            Region r3 = new Region(gp3);
            r2.Intersect(r3);

            if (r1.IsVisible(X, Y))
                br1 = new_br;
            else
            {
                br1 = old;
                pictureBox1.Invalidate();
            }

            if (r2.IsVisible(X, Y))
                br2 = new_br;
            else
            {
                br2 = old;
                pictureBox1.Invalidate();
            }
        }

        private void BtnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                new_br = new SolidBrush(dlg.Color);
            }
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            DropStarted = true;
        }

        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (DropStarted)
            {
                c.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void label_MouseUp(object sender, MouseEventArgs e)
        {
            DropStarted = false;
        }

        private void btnStartAnimation_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStopAnimation_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            Color new_color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            int new_size = r.Next(10, 15);

            foreach (Label label in this.Controls.OfType<Label>())
            {
                label.ForeColor = new_color;
                label.Font = new Font(Font.FontFamily, new_size);
            }
        }
    }
}