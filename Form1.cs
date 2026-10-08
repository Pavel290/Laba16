namespace Laba16 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                ShowData(openFileDialog.FileName);
            }
        }
        DataStorage data;

        private void ShowData(string fileName) {
            try {
                data = DataStorage.DataCreator(fileName);
            } catch (Exception ex) {
                MessageBox.Show("При загрузке данных чот-то сломалось");
            }
            dgvRaw.DataSource = data.GetRawData();
            dgvRaw.ReadOnly = true;
            dgvSummary.DataSource = data.GetSummaryData();
            dgvSummary.ReadOnly = true;
        }
    }
}
