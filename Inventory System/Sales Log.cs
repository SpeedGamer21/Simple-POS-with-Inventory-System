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
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sales_Log_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server='" + Properties.Settings.Default.hostname + "';uid='" + Properties.Settings.Default.username + "';password='" + Properties.Settings.Default.password + "';database='" + Properties.Settings.Default.database + "';");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tmp_sale", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain f2 = new frmMain();
            this.Hide();
            f2.Show();
        }
    }
}
