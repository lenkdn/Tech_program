using System;
using System.Windows.Forms;

namespace Lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.comboBox_i.SelectedIndex = 0;
            this.comboBox_j.SelectedIndex = 0;
            this.listBox_a.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                float f, X;
                double Z = 0;
                f = Convert.ToSingle(textBox_f.Text);
                X = Convert.ToSingle(textBox_X.Text);
                uint N = Convert.ToUInt32(textBox_N.Text);
                int i, j, a;
                i = Convert.ToInt32(comboBox_i.SelectedItem.ToString());
                j = Convert.ToInt32(comboBox_j.SelectedItem.ToString());
                a = Convert.ToInt32(listBox_a.SelectedItem.ToString());

                if (radioButton1.Checked)
                {
                    for (int k = 1; k <= N; k++)
                    {
                        if (k % 2 == 0)
                        {
                            Z += Math.Pow(X, k - 1) * Math.Pow(f, k) / (k * (k + 1));
                        }
                        else
                        {
                            Z += -(Math.Pow(X, k - 1) * Math.Pow(f, k) / (k * (k + 1)));
                        }
                    }
                }
                else
                {
                    Z = a * (i + j) / (i * (i + 2));
                }
                textBox_Z.Text = Z.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно введены значения.");
            }
        }
    }
}
