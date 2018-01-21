using System;
using System.Windows.Forms;
using DataAccess;

namespace WinAppAssignment1
{
    /// <summary>
    /// Krzysztof Szczurowski
    /// BCIT COMP3618 Assingment 1;
    /// Repo: https://github.com/kriss3/BCIT_COMP3618_Assignment1_QueryAnalyzer.git
    /// </summary>
    public partial class frmCommand : Form
    {
        public frmCommand()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var sRepo = new SimpleRepository();
            if (Helper.IsValid(txtQuery.Text))
            {
                dgvResults.DataSource = sRepo.GetResults(txtQuery.Text);
                dgvResults.DataMember = "Results";
            }
            else
            {
                MessageBox.Show("Basic Validation Failure. Please check your query for any Delete/Drop commands!", "Validation Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
