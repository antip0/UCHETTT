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

namespace uchettt
{
    public partial class AddManufacturer : Form
    {

        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        Manufacturers manufacturers;
        public AddManufacturer(Manufacturers manuf)
        {
            InitializeComponent();
            manufacturers = manuf;
        }
        public void getData(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
            try
            {
                conn.Open();
                DataTable table = new DataTable();
                ada.Fill(table);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void labelUserName_MouseMove(object sender, MouseEventArgs e)
        {
            labelUserName.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
            guna2TextBox1.Focus();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "insert into manufacturers (manufacturer_name) values ('" + guna2TextBox1.Text + "');";
            try
            {
                connection.Open();
                if (guna2TextBox1.Text != "")
                {
                    getData(query);
                    manufacturers.LoadManufacturers();
                    guna2TextBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Заполните все пустые поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string query = "update manufacturers set manufacturer_name = '" + guna2TextBox1.Text + "' where id_manufacturer = '" + guna2TextBox2.Text + "';";
            try
            {
                connection.Open();
                if (guna2TextBox1.Text != "")
                {
                    getData(query);
                    manufacturers.LoadManufacturers();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Заполните все пустые поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
