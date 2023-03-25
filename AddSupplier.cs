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
    public partial class AddSupplier : Form
    {
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        Suppliers suppliers;
        public AddSupplier(Suppliers supp)
        {
            InitializeComponent();
            suppliers = supp;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tbSupplier.Clear();
            tbAddress.Clear();
            tbContactPerson.Clear();
            tbPhone.Clear();
            tbEmail.Clear();
            tbContactPerson.Focus();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                if (tbSupplier.Text != "" && tbAddress.Text != "" && tbContactPerson.Text != "" && tbEmail.Text != "" && tbPhone.Text != "")
                {
                    command = new MySqlCommand("insert into suppliers (name, supp_fullname, address, phone_number, email)  values (@supplier, @contactperson, @address, @phone, @email)", connection);
                    command.Parameters.AddWithValue("@supplier", tbSupplier.Text);
                    command.Parameters.AddWithValue("@contactperson", tbContactPerson.Text);
                    command.Parameters.AddWithValue("@address", tbAddress.Text);
                    command.Parameters.AddWithValue("@phone", tbPhone.Text);
                    command.Parameters.AddWithValue("@email", tbEmail.Text);
                    command.ExecuteNonQuery();
                    suppliers.LoadSuppliers();
                }
                else
                {
                    MessageBox.Show("Заполните все пустые поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                if (tbSupplier.Text != "" && tbAddress.Text != "" && tbContactPerson.Text != "" && tbEmail.Text != "" && tbPhone.Text != "")
                {
                    command = new MySqlCommand("update suppliers set name = @supplier, supp_fullname = @contactperson, address = @address, phone_number = @phone, email = @email where id_supplier = @id_supplier", connection);
                    command.Parameters.AddWithValue("@supplier", tbSupplier.Text);
                    command.Parameters.AddWithValue("@contactperson", tbContactPerson.Text);
                    command.Parameters.AddWithValue("@address", tbAddress.Text);
                    command.Parameters.AddWithValue("@phone", tbPhone.Text);
                    command.Parameters.AddWithValue("@email", tbEmail.Text);
                    command.Parameters.AddWithValue("@id_supplier", tbId.Text);
                    command.ExecuteNonQuery();
                    suppliers.LoadSuppliers();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Заполните все пустые поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
}
