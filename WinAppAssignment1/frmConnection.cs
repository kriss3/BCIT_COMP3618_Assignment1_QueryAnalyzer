using System;
using System.Data;
using System.Windows.Forms;
using DataAccess;

namespace WinAppAssignment1
{
    /// <summary>
    /// Krzysztof Szczurowski
    /// BCIT COMP3618 Assingment 1;
    /// Repo: https://github.com/kriss3/BCIT_COMP3618_Assignment1_QueryAnalyzer.git
    /// </summary>
    public partial class frmConnection : Form
    {
        public SimpleRepository sRepo { get; private set; }
        public frmConnection()
        {
            InitializeComponent();
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            try
            {
                sRepo = new SimpleRepository();
                txtConnectionDetails.Text = Helper.GetConnectionDetails(sRepo.Connection);
                txtConnectionDetails.SelectionStart = 0;
                lblToolStripStatus.Text = $"Active Connection Status: {sRepo.Connection.State}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message},", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnAnalyzer_Click(object sender, EventArgs e)
        {
            var com = new frmCommand();
            com.ShowDialog();
        }

        private void frmConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sRepo.Connection.State != ConnectionState.Closed)
            {
                sRepo.Connection.Close();
                lblToolStripStatus.Text = $"Active Connection Status: {sRepo.Connection.State}";
                MessageBox.Show("Connection Closed!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
