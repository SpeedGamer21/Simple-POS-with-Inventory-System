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

namespace Inventory_System
{
    public partial class frmStocks : Form
    {
        public frmStocks()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtLeft_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSupp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain f2 = new frmMain();
            this.Hide();
            f2.ShowDialog();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
             if (cb1.Text == "STOCK ID")
            {

                try
                {
                    MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblstocks WHERE STOCKID LIKE @stockid", conn);
                    cmd.Parameters.AddWithValue("@stockid", string.Format("%{0}%", txtS.Text));
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv12.DataSource = dt;
                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERROR");
                }

            }
            else if (cb1.Text == "ITEM NAME")
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblstocks WHERE ITEMNAME LIKE @stockid", conn);
                    cmd.Parameters.AddWithValue("@stockid", string.Format("%{0}%", txtS.Text));
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv12.DataSource = dt;
                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERROR");
                }

            }
            else if (cb1.Text == "DESCRIPTION")
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblstocks WHERE DESCP LIKE @stockid", conn);
                    cmd.Parameters.AddWithValue("@stockid", string.Format("%{0}%", txtS.Text));
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv12.DataSource = dt;
                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERROR");
                }
            }
            else if (cb1.Text == "PRICE")
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblstocks WHERE PRICE LIKE @stockid", conn);
                    cmd.Parameters.AddWithValue("@stockid", string.Format("%{0}%", txtS.Text));
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv12.DataSource = dt;
                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERROR");
                }
               
            }
            else if (cb1.Text == "SUPPLIER")
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblstocks WHERE SUPP LIKE @stockid", conn);
                    cmd.Parameters.AddWithValue("@stockid", string.Format("%{0}%", txtS.Text));
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv12.DataSource = dt;
                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERROR");
                }
            }
            else
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblstocks", conn);
                    cmd.Parameters.AddWithValue("@stockid", string.Format("%{0}%", txtS.Text));
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv12.DataSource = dt;
                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERROR");
                }
            }

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgv12.SelectedRows.Count > 0)
            {
                txtID.Text = dgv12.SelectedRows[0].Cells[1].Value.ToString();
                txtItem.Text = dgv12.SelectedRows[0].Cells[2].Value.ToString();
                txtDesc.Text = dgv12.SelectedRows[0].Cells[3].Value.ToString();
                txtPrice.Text = dgv12.SelectedRows[0].Cells[4].Value.ToString();
                txtSupp.Text = dgv12.SelectedRows[0].Cells[5].Value.ToString();
                txtLeft.Text = dgv12.SelectedRows[0].Cells[6].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dgv12.SelectedRows.Count > 0)
            {
                txtID.Text = dgv12.SelectedRows[0].Cells[1].Value.ToString();
                txtItem.Text = dgv12.SelectedRows[0].Cells[2].Value.ToString();
                txtDesc.Text = dgv12.SelectedRows[0].Cells[3].Value.ToString();
                txtPrice.Text = dgv12.SelectedRows[0].Cells[4].Value.ToString();
                txtSupp.Text = dgv12.SelectedRows[0].Cells[5].Value.ToString();
                txtLeft.Text = dgv12.SelectedRows[0].Cells[6].Value.ToString();

            }
        }

        private void frmStocks_Load(object sender, EventArgs e)
        {

        }
    }
}
