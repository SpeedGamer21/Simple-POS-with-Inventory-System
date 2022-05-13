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
    public partial class frmAddStock : Form
    {
        public static string id;
        public static string item;
        public static string desc;
        public static string instock;
        public static string price;
        public static string supp;

        public frmAddStock()
        {
            InitializeComponent();
        }

        private void frmAddStock_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAddEntry f2 = new FrmAddEntry();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dgv12.SelectedRows.Count > 0)
            {
                id = dgv12.SelectedRows[0].Cells[1].Value.ToString();
                item = dgv12.SelectedRows[0].Cells[2].Value.ToString();
                desc = dgv12.SelectedRows[0].Cells[3].Value.ToString();
                price = dgv12.SelectedRows[0].Cells[4].Value.ToString();
                instock = dgv12.SelectedRows[0].Cells[6].Value.ToString();
                supp = dgv12.SelectedRows[0].Cells[5].Value.ToString();

            }

            this.Hide();
            frmEditItem f2 = new frmEditItem();
            f2.ShowDialog();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f2 = new frmMain();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");

                DialogResult dialogResult = MessageBox.Show("Are you sure do you want to delete this inventory?", "Are you Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    conn.Open();
                    string sss = dgv12.SelectedRows[0].Cells[1].Value.ToString();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM tblstocks WHERE STOCKID LIKE '%" + sss + "%'", conn);
                    cmd.Parameters.AddWithValue("@stockid", string.Format("%{0}%", id));
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv12.DataSource = dt;
                    conn.Close();
                    conn.Dispose();
                } 
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR");
            }
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

        private void txtS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

        
    

