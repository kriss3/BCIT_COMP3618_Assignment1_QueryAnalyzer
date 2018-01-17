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
    public partial class frmCommand : Form
    {
        public frmCommand()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var t = new SimpleRepository();
            dgvResults.DataSource = t.GetResults(txtQuery.Text);
            dgvResults.DataMember = "Results";
        }
    }
}
