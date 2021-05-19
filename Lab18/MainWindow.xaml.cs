using System;
using System.Windows;

namespace Lab18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float x = Convert.ToSingle(TextBox_x.Text);
                uint N = Convert.ToUInt32(ComboBox_N.Text);
                uint K = Convert.ToUInt32(ComboBox_K.Text);
                uint I = 1, J = 1;

                for (uint i = 1; i < N; i++)
                    I += i;
                for (uint i = 1; i < K; i++)
                    J += i;

                float res = Convert.ToSingle((Math.Cos(Math.Pow(x, I)) + J) / (I * J));

                this.TextBox_ans.Text = res.ToString();
            }
            catch
            {
                MessageBox.Show("Неверно введено значение переменной.");
            }
        }
    }
}