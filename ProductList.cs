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
    public partial class ProductList : Form
    {
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        public ProductList()
        {
            InitializeComponent();
            LoadProducts();
        }

        public void Search()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select id_product, barcode, description, categories.category_name, manufacturers.manufacturer_name, purchase_price, retail_price, quantity, reorder from products join categories on categories.id_category = products.category_id join manufacturers on manufacturers.id_manufacturer = products.manufacturer_id where description like '" + tbSearch.Text + "%';", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id_product"].ToString(), reader["barcode"].ToString(), reader["description"].ToString(), reader["category_name"].ToString(), reader["manufacturer_name"].ToString(), reader["purchase_price"].ToString(), reader["retail_price"].ToString(), reader["quantity"].ToString(), reader["reorder"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        public void LoadProducts()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select id_product, barcode, description, categories.category_name, manufacturers.manufacturer_name, purchase_price, retail_price, quantity, reorder from products join categories on categories.id_category = products.category_id join manufacturers on manufacturers.id_manufacturer = products.manufacturer_id order by barcode;", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id_product"].ToString(), reader["barcode"].ToString(), reader["description"].ToString(), reader["category_name"].ToString(), reader["manufacturer_name"].ToString(), reader["purchase_price"].ToString(), reader["retail_price"].ToString(), reader["quantity"].ToString(), reader["reorder"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(this);
            addProduct.tbId.Enabled = false;
            addProduct.guna2Button3.Enabled = false;
            addProduct.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                if (columnName == "Редактировать")
                {
                    AddProduct addProduct = new AddProduct(this);
                    addProduct.tbId.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                    addProduct.tbBarcode.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                    addProduct.tbDescription.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                    addProduct.cbCategory.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                    addProduct.cbManuf.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                    addProduct.guna2TextBox1.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                    addProduct.tbPrice.Text = dataGridView1[7, e.RowIndex].Value.ToString();
                    addProduct.tbCritical.Text = dataGridView1[9, e.RowIndex].Value.ToString();
                    addProduct.guna2Button1.Enabled = false;
                    addProduct.tbId.Enabled = false;
                    addProduct.ShowDialog();
                }
                else if (columnName == "Удалить")
                {
                    if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        connection.Open();
                        command = new MySqlCommand("delete from products where id_product = '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        LoadProducts();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            try
            {
                    int i = 0;
                    dataGridView1.Rows.Clear();
                    connection.Open();
                    command = new MySqlCommand("select id_product, barcode, description, categories.category_name, manufacturers.manufacturer_name, purchase_price, retail_price, quantity, reorder from products join categories on categories.id_category = products.category_id join manufacturers on manufacturers.id_manufacturer = products.manufacturer_id where quantity between 5 and 15 order by barcode;", connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        i++;
                        dataGridView1.Rows.Add(i, reader["id_product"].ToString(), reader["barcode"].ToString(), reader["description"].ToString(), reader["category_name"].ToString(), reader["manufacturer_name"].ToString(), reader["purchase_price"].ToString(), reader["retail_price"].ToString(), reader["quantity"].ToString(), reader["reorder"].ToString());
                    }
                    reader.Close();
                    connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductList_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Критическая отметка - индикатор количества товаров, при котором необходимо сделать повторную закупку товара у поставщика. Критическая отметка меньше либо равна 15 единицам!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
