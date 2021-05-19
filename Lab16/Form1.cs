using System;
using System.Windows.Forms;

namespace Lab16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            openFileDlg.InitialDirectory = Application.StartupPath;
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                ShowData(openFileDlg.FileName);
            }
        }

        private void ShowData(String datapath)
        {
            try
            {
                dgvRaw.DataSource = DataStorage.DataCreator(datapath).GetRawData();
                dgvRaw.ReadOnly = true;
                dgvSummary.DataSource = DataStorage.DataCreator(datapath).GetSummaryData();
                dgvSummary.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("При загрузке данных что-то сломалось");
            }
        }
    }
}