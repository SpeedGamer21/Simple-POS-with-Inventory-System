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
    public partial class frmprofiles : Form
    {
        public frmprofiles()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtUSL2.Text == "USERNAME")
            {

                MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM login WHERE Username='" + txtS.Text + "'", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                conn.Dispose();
            }
            else if (txtUSL2.Text == "NAME")
            {
                MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM login WHERE Name ='" + txtS.Text + "'", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                conn.Dispose();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM login", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                conn.Dispose();
            }


        }

        private void frmprofiles_Load(object sender, EventArgs e)
        {
            txtName.ReadOnly = true;
            txtPass.ReadOnly = true;
            txtUser.ReadOnly = true;
            txtID.ReadOnly = true;


            MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM login", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtUser.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtPass.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtUSL.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtUser.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtPass.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtUSL.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                txtName.ReadOnly = false;
                txtPass.ReadOnly = false;
                txtUser.ReadOnly = false;
            
        }

        private void button2_Click(object sender, EventArgs e)

        {
            MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");
            if (txtName.Text == null && txtPass.Text == null && txtUser.Text == null && txtUSL.Text == null)
            {
                MessageBox.Show("Fill all the Values", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {


                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE login SET Username=@user, Password=@password, Name=@name, Position=@pos WHERE ID='" + txtID.Text + "'", conn);
                    cmd.Parameters.AddWithValue("@user", txtUser.Text);
                    cmd.Parameters.AddWithValue("@password", txtPass.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@pos", txtUSL.Text);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    txtID.Clear();
                    txtName.ReadOnly = false;
                    txtPass.ReadOnly = false;
                    txtUser.ReadOnly = false;
                    txtName.Clear();
                    txtPass.Clear();
                    txtUser.Clear();
                    txtUSL.Text = "";
                    MessageBox.Show("Successfully Saved!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");
            string sdf = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Are you sure do you want to delete this entry?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE from login WHERE ID='" + sdf + "'", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("The entry has been Deleted Successfully!", "Success");
                conn.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");
            try {
                 conn.Open();
                    MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM login WHERE Name='" + txtName.Text + "'", conn);
                    MySqlDataReader dr = cmd1.ExecuteReader();
                    ;
                    if (dr.Read() == true)
                    {
                        conn.Close();
                        MessageBox.Show("The user already Exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                       
                    }
                    else
                    {
                         try
            {


                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO login (Username,Password,Name,Position)VALUES (@user,@password,@name,@pos)", conn);
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@password", txtPass.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@pos", txtUSL.Text);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                conn.Close();
                txtName.ReadOnly = false;
                txtPass.ReadOnly = false;
                txtUser.ReadOnly = false;
                txtName.Clear();
                txtPass.Clear();
                txtUser.Clear();
                txtUSL.Text = "";
                MessageBox.Show("Successfully Saved!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
                    }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
            txtUser.Clear();
            frmMain f2 = new frmMain();
            this.Hide();
            f2.Show();
        }
    }
}