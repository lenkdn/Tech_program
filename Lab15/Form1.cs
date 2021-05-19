using System;
using System.IO;
using System.Windows.Forms;

namespace Lab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                float x = Convert.ToSingle(textBox_x.Text);
                uint n = Convert.ToUInt32(textBox_n.Text);
                float s = 0;
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        s += Convert.ToSingle(-Math.Pow(x, i + 2) / ((i + 2) * (i + 3)));
                    }
                    else
                    {
                        s += Convert.ToSingle(Math.Pow(x, i + 2) / ((i + 2) * (i + 3)));
                    }
                }
                textBox_ans.Text = s.ToString();
            }
            catch
            {
                MessageBox.Show("Неверно введены значения!");
            }

        }

        private void BtnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                BackColor = dlg.Color;
            }
        }

        private void BtnChooseFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowHelp = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Font = dlg.Font;
            }
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Title = "Выбор папки для сохранения файла";
            dlg.Filter = "TXT (*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtSaveFile.Text = dlg.FileName;
                Save(dlg.FileName);
            }
        }

        private void Save(string filename)
        {
            StreamWriter SW = new StreamWriter(filename);
            SW.WriteLine("x = " + textBox_x.Text);
            SW.WriteLine("n = " + textBox_n.Text);                
            SW.Write("Ответ: " + textBox_ans.Text);
            SW.Close();
        }
    }
}
