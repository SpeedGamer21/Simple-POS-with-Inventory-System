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
    public partial class frmEditItem : Form
    {
        public frmEditItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");

            try
            {

                decimal txtAmount = Convert.ToDecimal(txtPrice.Text);
                decimal txtLefts = Convert.ToInt32(txtLeft.Text);
         
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE tblstocks SET ITEMNAME=@ITEM, DESCP=@DESC, PRICE=@PRICE, STOCKLEFT=@STOCK, SUPP=@SUPP WHERE STOCKID=@UID", conn);
                cmd.Parameters.AddWithValue("@UID", txtID.Text);
                cmd.Parameters.AddWithValue("@ITEM", txtItem.Text);
                cmd.Parameters.AddWithValue("@DESC", txtDesc.Text);
                cmd.Parameters.AddWithValue("@PRICE", txtAmount);
                cmd.Parameters.AddWithValue("@STOCK", txtLefts);
                cmd.Parameters.AddWithValue("@SUPP", txtSupp.Text);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved!");

                txtID.Clear();
                txtItem.Clear();
                txtDesc.Clear();
                txtPrice.Clear();
                txtLeft.Clear();
                txtSupp.Clear();

                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {

            txtID.Text = frmAddStock.id;
            txtItem.Text = frmAddStock.item;
            txtDesc.Text = frmAddStock.desc;
            txtLeft.Text = frmAddStock.instock;
            txtPrice.Text = frmAddStock.price;
            txtSupp.Text = frmAddStock.supp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddStock f2 = new frmAddStock();
            f2.ShowDialog();
        }
    }
}
