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
    public partial class Cancellation : Form
    {
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        Administrator admin;
        int quantity;
        public Cancellation(Administrator adm)
        {
            InitializeComponent();
            admin = adm;
            label2.Text = "";
            LoadProducts();
            getNumber();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            
        }

        public void getNumber()
        {
            Random random = new Random();
            label2.Text += random.Next(111111111, 999999999);
        }
        public void LoadCancelProducts()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select id, number, date, products.description, cancellation.quantity, reason, employee from cancellation join products on products.id_product = cancellation.id_product order by date;", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView2.Rows.Add(i, reader["id"].ToString(), reader["number"].ToString(), DateTime.Parse(reader["date"].ToString()).ToShortDateString(), reader["description"].ToString(), reader["quantity"].ToString(), reader["reason"].ToString(), reader["employee"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        public void LoadProducts()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select id_product, barcode, description, categories.category_name, manufacturers.manufacturer_name, purchase_price, retail_price, quantity from products join categories on categories.id_category = products.category_id join manufacturers on manufacturers.id_manufacturer = products.manufacturer_id order by barcode;", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id_product"].ToString(), reader["barcode"].ToString(), reader["description"].ToString(), reader["category_name"].ToString(), reader["manufacturer_name"].ToString(), reader["purchase_price"].ToString(), reader["retail_price"].ToString(), reader["quantity"].ToString());
            }
            reader.Close();
            connection.Close();
        }

        public void Search()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select id_product, barcode, description, categories.category_name, manufacturers.manufacturer_name, price, quantity, reorder from products join categories on categories.id_category = products.category_id join manufacturers on manufacturers.id_manufacturer = products.manufacturer_id where description like '" + tbSearch.Text + "%';", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id_product"].ToString(), reader["barcode"].ToString(), reader["description"].ToString(), reader["category_name"].ToString(), reader["manufacturer_name"].ToString(), reader["price"].ToString(), reader["quantity"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tbFullname.Clear();
            tbAddress.Clear();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            getNumber();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbFullname.Text == "")
                {
                    MessageBox.Show("Укажите количество товара!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (tbAddress.Text == "")
                {
                    MessageBox.Show("Укажите причину списания!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tbFullname.Text != "" && tbAddress.Text != "" && label11.Text != "" && label3.Text != "" && label7.Text != "" && label8.Text != "" && int.Parse(tbFullname.Text) <= quantity)
                {
                    connection.Open();
                    command = new MySqlCommand("update products set quantity = quantity - " + int.Parse(tbFullname.Text) + " where id_product = '" + label11.Text + "';", connection);
                    command.ExecuteNonQuery();
                    command = new MySqlCommand("insert into cancellation (number, date, id_product, quantity, reason, employee) values ('" + label2.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + label11.Text + "', '" + tbFullname.Text + "', '" + tbAddress.Text + "', '" + admin.labelUserName.Text + "');", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Операция прошла успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Введённое количество больше, чем есть в общем количестве!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (columnName == "Select")
            {
                try
                {
                    label11.Text = "";
                    label3.Text = "";
                    label7.Text = "";
                    label8.Text = "";
                    label11.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    label3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    label7.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    label8.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    quantity = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            LoadCancelProducts();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            LoadProducts();
        }
    }
}
