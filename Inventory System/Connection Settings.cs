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
    public partial class Con_Sett : Form
    {
        public Con_Sett()
        {
            InitializeComponent();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            MySqlConnection Conn;

            Conn = new MySqlConnection();
            Conn.ConnectionString = "Server =" + txtServer.Text +  ";user id=" + txtUser.Text + ";password=" + txtPass.Text + ";database=" + txtDB.Text + ";";

            try
            {
                Conn.Open();
                MessageBox.Show("Connection Established!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void Con_Sett_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["hostname"] = txtServer.Text;
            Properties.Settings.Default["username"] = txtUser.Text;
            Properties.Settings.Default["password"] = txtPass.Text;
            Properties.Settings.Default["database"] = txtDB.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("Settings Saved!");


            txtServer.Clear();
            txtUser.Clear();
            txtPass.Clear();
            txtDB.Clear();

            this.Hide();
            frmLogin f2 = new frmLogin();
            f2.ShowDialog();


        }
    }



}
