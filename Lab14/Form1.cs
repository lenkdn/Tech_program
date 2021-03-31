using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab14
{
    public partial class MainForm : Form
    {
        DateTimeFormat dtFormat = DateTimeFormat.ShowTime;
        ToolStripMenuItem currentCheckedItem;
        public MainForm()
        {
            InitializeComponent();
            Text = "Пример строки состояния";
            CenterToScreen();
            BackColor = Color.CadetBlue;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }

        public enum DateTimeFormat
        {
            ShowTime,
            ShowDate
        }

        private void TimerDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            string info = "";
            if (dtFormat == DateTimeFormat.ShowTime)
                info = DateTime.Now.ToLongTimeString();
            else
                info = DateTime.Now.ToLongDateString();
            toolStripStatusLabelClock.Text = info;
        }

        private void ToolStripMenuItemTime_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowTime;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }

        private void ToolStripMenuItemDate_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowDate;
            currentCheckedItem = toolStripMenuItemDate;
            currentCheckedItem.Checked = true;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelState.Text = string.Format("Координаты курсора мыши (X, Y): {0}, {1}", e.X, e.Y);

            float x = e.X;
            float y = e.Y;
            float z = 0, f = 0;

            if (toolStripComboBox1.SelectedIndex == 0)
            {
                z = Convert.ToSingle((y - Math.Sqrt(x)) / Math.Abs(x - y));
                f = Convert.ToSingle(Math.Sqrt(Math.Abs(Math.Sqrt(x) - Math.Sqrt(y))));
                toolStripStatusLabel1.Text = "Задание 2. Ответ: z = " + z.ToString() + "; f = " + f.ToString();
            }
            else
            {
                z = Convert.ToSingle(Math.Cos(x * x) + Math.Sin(y) * Math.Sin(y));
                toolStripStatusLabel1.Text = "Задание 2. Ответ: z = " + z.ToString();
            }
        }

        private void ContextMenuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                float x = Convert.ToSingle(toolStripTextBox_x2.Text);
                float y = Convert.ToSingle(toolStripTextBox_y2.Text);
                float z = Convert.ToSingle(toolStripTextBox_z2.Text);
                int a = Convert.ToInt32(toolStripComboBox_a2.Text);

                float ans = Convert.ToSingle(Math.Log10(a * x) + Math.Sin(z) - Math.Cos(y));
                Text = "Задание 1. Ответ: " + ans.ToString();
            }
            catch
            {
                Text = "Задание 1. Ошибка. Неверно введены значения.";
            }
        }

        private void MenuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                float x = Convert.ToSingle(toolStripTextBox_x.Text);
                float y = Convert.ToSingle(toolStripTextBox_y.Text);
                float z = Convert.ToSingle(toolStripTextBox_z.Text);
                int a = Convert.ToInt32(toolStripComboBox_a.Text);

                float ans = Convert.ToSingle(Math.Log10(a * x) + Math.Sin(z) - Math.Cos(y));
                Text = "Задание 1. Ответ: " + ans.ToString();
            }
            catch
            {
                Text = "Задание 1. Ошибка. Неверно введены значения.";
            }
        }
    }
}