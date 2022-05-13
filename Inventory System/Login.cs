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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM login WHERE username=@user AND password=@pass;", conn);
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                MySqlDataReader dr = cmd.ExecuteReader();
 
              
                if (dr.Read() == true)
                {
                   
                    conn.Close();
                    this.Hide();
                    string user = ds.Tables[0].Rows[0]["Name"].ToString();
                    string userlvl = ds.Tables[0].Rows[0]["Position"].ToString();
                    frmMain f1 = new frmMain();
                    f1.lblName.Text = user;
                    if (userlvl == "SALES"){
                        f1.button2.Enabled = false;
                        f1.button3.Enabled = false;
                        f1.button6.Enabled = false;

                        //ADMIN
//SALES
//INVENTORY
                    }
                    else if (userlvl == "INVENTORY")
                    {
                        f1.button4.Enabled = false;
                    }
                    f1.ShowDialog();
             
                    
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!", "Inventory Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();

                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
