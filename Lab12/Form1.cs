using System;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            float x, y, z, ax1, e7, as_9, Z;
            x = e.X;
            textBox_x.Text = e.X.ToString();
            y = e.Y;
            textBox_y.Text = e.Y.ToString();

            try
            {
                z = Convert.ToSingle(textBox_z.Text);
                ax1 = Convert.ToSingle(textBox_ax1.Text);
                e7 = Convert.ToSingle(textBox_e7.Text);
                as_9 = Convert.ToSingle(textBox_as_9.Text);
                Z = Convert.ToSingle(z * ax1 + Math.Sqrt(Math.Abs(e7 + x / y)) - Math.Abs(x + Math.Cos(as_9 + y)));
                Text = "Z = " + Z.ToString();
            }
            catch (Exception)
            {
                Text = "ERROR";
            }
        }
    }
}
