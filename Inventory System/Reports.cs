using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            frmSalesReport f2 = new frmSalesReport();
            this.Hide();
            f2.Show();
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            frmInvRep f2 = new frmInvRep();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain f2 = new frmMain();
            this.Hide();
            f2.Show();
        }
    }
}
