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
    public partial class FrmAddEntry : Form
    {
        public FrmAddEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddStock f2 = new frmAddStock();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            String x = "";
            Random rand = new Random();

            MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");

            try
            {
                string z = Convert.ToString(DateTime.Now.Year);

                for (int y = 1; y <= 2; y++)
                {
                    x += Convert.ToString(rand.Next(0, 9));
                    if (y == 2)
                    {
                        x += "INV";
                    }

                }

                for (int y = 1; y <= 3; y++)
                {
                    x += Convert.ToString(rand.Next(0, 9));
                }


                txtID.Text = z + "-" + x;
                if (txtID.Text == x)

                {
                    x = null;
                }



                try
                {
                    conn.Open();
                    MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM tblstocks WHERE ITEMNAME='" + txtItem.Text + "'", conn);
                    MySqlDataReader dr = cmd1.ExecuteReader();
                    ;
                    if (dr.Read() == true)
                    {
                        conn.Close();
                        MessageBox.Show("The Item Already Exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                       
                    }
                    else
                    {
                        
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO tblstocks (STOCKID,ITEMNAME,DESCP,PRICE,STOCKLEFT,SUPP) VALUES (@UID,@ITEM,@DESC,@PRICE,@STOCK,@SUPP)", conn);
                        cmd.Parameters.AddWithValue("@UID", txtID.Text);
                        cmd.Parameters.AddWithValue("@ITEM", txtItem.Text);
                        cmd.Parameters.AddWithValue("@DESC", txtDesc.Text);
                        cmd.Parameters.AddWithValue("@PRICE", txtPrice.Text);
                        cmd.Parameters.AddWithValue("@STOCK", txtLeft.Text);
                        cmd.Parameters.AddWithValue("@SUPP", txtSupp.Text);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved!");

                        txtItem.Clear();
                        txtDesc.Clear();
                        txtPrice.Clear();
                        txtLeft.Clear();
                        txtSupp.Clear();
                        txtID.Clear();

                        conn.Close();
                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERROR!");
                }
               



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }


        private void FrmAddEntry_Load(object sender, EventArgs e)
        {
           
           
        }
    }
}
