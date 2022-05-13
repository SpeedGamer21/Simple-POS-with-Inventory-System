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
    public partial class frmMain : Form
    {
        Timer t = new Timer();
        public frmMain()
        {
           
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_tick);
            t.Start();
        }

        private void t_tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            label14.Text = time;
        } 
 

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStocks f2 = new frmStocks();
            f2.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddStock f2 = new frmAddStock();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS f2 = new frmPOS();
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmLogin f2 = new frmLogin();
            this.Hide();
            f2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmLog f2 = new frmLog();
            this.Hide();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmprofiles f2 = new frmprofiles();
            this.Hide();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReports f2 = new frmReports();
            this.Hide();
            f2.Show();
            
        }
    }
}
