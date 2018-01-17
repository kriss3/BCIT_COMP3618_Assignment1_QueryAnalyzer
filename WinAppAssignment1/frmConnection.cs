using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace WinAppAssignment1
{
    public partial class frmConnection : Form
    {
        public frmConnection()
        {
            InitializeComponent();
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            var t = new SimpleRepository();
            txtConnectionDetails.Text = t.GetConnectionStatistics();
            txtConnectionDetails.SelectionStart = 0;
            lblToolStripStatus.Text = $"Connection Status: {t.ConnState}";
        }

        private void btnAnalyzer_Click(object sender, EventArgs e)
        {
            var com = new frmCommand();
            com.ShowDialog();
        }
    }
}
