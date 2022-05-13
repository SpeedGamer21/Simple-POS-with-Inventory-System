using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using CrystalDecisions.CrystalReports.Engine;


namespace Inventory_System
{
    public partial class frmPOS : Form
    {



        
        public frmPOS()
        {

            InitializeComponent();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddItem_Click(object sender, EventArgs e)
        {
            frmPOSsearch f2 = new frmPOSsearch(this);
            f2.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPOS_Load(object sender, EventArgs e)
        {

            String x = "";
            Random rand = new Random();


            for (int y = 7; y <= 10; y++)
            {
                x += Convert.ToString(rand.Next(0, 9));
                if (y == 10)
                {
                    x += "INV";
                }

            }

            for (int y = 1; y <= 3; y++)
            {
                x += Convert.ToString(rand.Next(0, 9));
            }


            txtxn.Text = x;
            if (txtxn.Text == x)
            {
                x = null;
            }


        }

        private void frmDelete_Click(object sender, EventArgs e)
        {

            if (this.dgv1.SelectedRows.Count > 0)
            {
                string item;
                string totalprice;
                string id;
                
                item = dgv1.SelectedRows[0].Cells["ITEMNAME"].Value.ToString();
                totalprice = dgv1.SelectedRows[0].Cells["TOTALPRICE"].Value.ToString();
                id = dgv1.SelectedRows[0].Cells["TRANSID"].Value.ToString();

                var Total = Convert.ToDecimal(frmTotal.Text);
                var TotalPr = Convert.ToDecimal(totalprice);
                var FinalTotal = Total - TotalPr;
                var sss = Convert.ToString(FinalTotal);
                frmTotal.Text = sss;

                 DialogResult dialogResult = MessageBox.Show("Are you sure do you want to delete this ?", "Are you Sure?", MessageBoxButtons.YesNo);
                 if (dialogResult == DialogResult.Yes)
                 {
                    
                     MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");
                     conn.Open();
                     MySqlCommand cmd = new MySqlCommand("DELETE FROM tmp_sale WHERE ITEMNAME='" + item + "'", conn);
                     cmd.ExecuteNonQuery();
                     conn.Close();


                     conn.Open();
                     MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM tmp_sale WHERE TRANSID='" + id + "'", conn);
                     MySqlDataAdapter da = new MySqlDataAdapter();
                     da.SelectCommand = cmd2;
                     DataTable dt = new DataTable();
                     da.Fill(dt);
                     dgv1.DataSource = dt;
                     conn.Close();
                     
                 }
            }
        }

        private void frmCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure do you want to cancel the transaction?", "Are you Sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string xx = txtxn.Text;
                MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM tmp_sale WHERE TRANSID='" + xx + "'", conn);
                cmd.ExecuteNonQuery();
                frmTotal.Text = "0";
                dgv1.DataSource=null;

                
            }

        }

        private void frmExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f2 = new frmMain();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string total =  Interaction.InputBox("Amount Tendered");

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");

            for (int rows = 0; rows < dgv1.Rows.Count; rows++)
            {
               
                    string item = dgv1.Rows[rows].Cells["ITEMCODE"].Value.ToString();
                    string asd = (dgv1.Rows[rows].Cells["QTY"].Value.ToString());
                    var cc = Convert.ToDecimal(asd);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE tblstocks SET STOCKLEFT = (STOCKLEFT -" + cc + "), SOLD = (SOLD + " + cc + ") WHERE STOCKID = '" + item + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
            }


            frmReceipt f2 = new frmReceipt();
            Receipt rc = new Receipt();

            rc.SetParameterValue("transID", txtxn.Text);
            f2.myViewer.ReportSource = rc;
            f2.Show();
         
        
          


         
          
        }

        private void button_Click(object sender, EventArgs e)
        {
            
        }

      
    }
}
