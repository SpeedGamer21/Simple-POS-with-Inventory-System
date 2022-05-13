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


namespace Inventory_System
{
    public partial class frmPOSsearch : Form
    {
       private frmPOS form1;

     
        public frmPOSsearch(frmPOS form1)
        {
            InitializeComponent();
            this.form1 = form1;
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

        private void button1_Click(object sender, EventArgs e)
        {

            string code;
            string item;
            string price;
            string txID = form1.txtxn.Text;

            decimal totalqty;
            string qty;
            qty = Interaction.InputBox("Enter Quantity", "Quantity", "1");
            var sss = Convert.ToDecimal(qty);
            DateTime dateTime = DateTime.UtcNow.Date;





            if (dgv12.SelectedRows.Count > 0)
            {
                code = dgv12.SelectedRows[0].Cells[1].Value.ToString();
                item = dgv12.SelectedRows[0].Cells[2].Value.ToString();
                price = dgv12.SelectedRows[0].Cells[4].Value.ToString();
                string left = dgv12.SelectedRows[0].Cells[6].Value.ToString();
                var lefts = Convert.ToDecimal(left);

                try
                {
                    if (lefts < sss)
                    {
                        MessageBox.Show("Stocks are not enough!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");

                        conn.Open();
                        MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM tmp_sale WHERE ITEMCODE=@ITMCS AND TRANSID=@TRSID", conn);
                        cmd3.Parameters.AddWithValue("@ITMCS", code);
                        cmd3.Parameters.AddWithValue("@TRSID", txID);
                        MySqlDataReader rd = cmd3.ExecuteReader();

                        if (rd.Read() == true)
                        {
                            MessageBox.Show("The item is already in the cart!");

                        }
                        else
                        {
                            conn.Close();
                            var dectotal = Convert.ToDecimal(qty);
                            var decwty = Convert.ToDecimal(price);
                            totalqty = dectotal * decwty;
                            var txttotal = Convert.ToDecimal(form1.frmTotal.Text);
                            var totaltext = txttotal + totalqty;
                            form1.frmTotal.Text = totaltext.ToString();
                            conn.Open();
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO tmp_sale (TRANSID, ITEMCODE,ITEMNAME,PRICE,TOTALPRICE,QTY,DATE) VALUES (@TRANS,@ITMCDE,@ITM,@PRICE,@TOTALPRICE,@QTY,@DT)", conn);
                            cmd.Parameters.AddWithValue("@TRANS", txID);
                            cmd.Parameters.AddWithValue("@ITMCDE", code);
                            cmd.Parameters.AddWithValue("@ITM", item);
                            cmd.Parameters.AddWithValue("@PRICE", decwty);
                            cmd.Parameters.AddWithValue("@TOTALPRICE", totalqty);
                            cmd.Parameters.AddWithValue("@QTY", qty);
                            cmd.Parameters.AddWithValue("@DT", dateTime);

                            cmd.ExecuteNonQuery();
                            conn.Close();

                            conn.Open();
                            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM tmp_sale WHERE TRANSID='" + txID + "'", conn);
                            MySqlDataAdapter sda = new MySqlDataAdapter();
                            sda.SelectCommand = cmd2;
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            form1.dgv1.DataSource = dt;
                            form1.dgv1.Columns["ID"].Visible = false;
                            form1.dgv1.Columns["TRANSID"].Visible = false;
                            form1.dgv1.Columns["DATE"].Visible = false;
                            form1.dgv1.Columns["ITEMCODE"].Width = 100;
                            form1.dgv1.Columns["ITEMNAME"].Width = 500;
                            conn.Close();
                            conn.Dispose();
                            this.Hide();

                        }


                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Warning!", error.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgv12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmPOSsearch_Load(object sender, EventArgs e)
        {

        }
    }
}
