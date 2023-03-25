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
    public partial class AddProduct : Form
    {
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        Double purchase_price, retail_price, result;
        ProductList productList;
        public AddProduct(ProductList list)
        {
            InitializeComponent();
            productList = list;
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tbBarcode.Clear();
            tbDescription.Clear();
            tbPrice.Clear();
            tbCritical.Clear();
            cbManuf.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
            tbBarcode.Focus();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            try
            {
                cbManuf.Items.Clear();
                connection.Open();
                command = new MySqlCommand("select * from manufacturers;", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbManuf.Items.Add(reader.GetString("manufacturer_name"));
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + Environment.NewLine + ex.Message);
            }

            try
            {
                cbCategory.Items.Clear();
                connection.Open();
                command = new MySqlCommand("select * from categories;", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbCategory.Items.Add(reader.GetString("category_name"));
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbBarcode.Text != "" && tbDescription.Text != "" && cbManuf.Text != "" && cbCategory.Text != "" && guna2TextBox1.Text != "" && tbPrice.Text != "" && tbCritical.Text != "")
                {                  
                    if (int.Parse(tbCritical.Text) <= 15)
                    {
                        connection.Open();
                        command = new MySqlCommand("insert into products (barcode, description, purchase_price, retail_price, reorder) values (@barcode, @description, @purchase_price, @retail_price, @reorder);", connection);
                        command.Parameters.AddWithValue("@barcode", tbBarcode.Text);
                        command.Parameters.AddWithValue("@description", tbDescription.Text);
                        command.Parameters.AddWithValue("@purchase_price", guna2TextBox1.Text);
                        command.Parameters.AddWithValue("@retail_price", Double.Parse(tbPrice.Text));
                        command.Parameters.AddWithValue("@reorder", tbCritical.Text);
                        command.ExecuteNonQuery();
                        command = new MySqlCommand("update products set manufacturer_id = (select id_manufacturer from manufacturers where manufacturer_name = '" + cbManuf.Text + "'), category_id = (select id_category from categories where category_name = '" + cbCategory.Text + "') where barcode = '" + tbBarcode.Text + "';", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        tbBarcode.Clear();
                        tbDescription.Clear();
                        tbPrice.Clear();
                        tbCritical.Clear();
                        cbManuf.SelectedIndex = -1;
                        cbCategory.SelectedIndex = -1;
                        tbBarcode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Нет необходимости ставить значение больше 15, но желательно больше 5!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все пустые поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                productList.LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
   
            try
            {
                if (tbBarcode.Text != "" && tbDescription.Text != "" && cbCategory.Text != "" && cbManuf.Text != "" && guna2TextBox1.Text != "" && tbPrice.Text != "" && tbCritical.Text != "")
                {
                    command = new MySqlCommand("update products set barcode = @barcode, description = @description, category_id = (select id_category from categories where category_name = @category), manufacturer_id = (select id_manufacturer from manufacturers where manufacturer_name = @manufacturer), purchase_price = @purchase_price, retail_price = @retail_price, reorder = @reorder where id_product = @id;", connection);
                    command.Parameters.AddWithValue("@barcode", tbBarcode.Text);
                    command.Parameters.AddWithValue("@description", tbDescription.Text);
                    command.Parameters.AddWithValue("@category", cbCategory.Text);
                    command.Parameters.AddWithValue("@manufacturer", cbManuf.Text);
                    command.Parameters.AddWithValue("@purchase_price", guna2TextBox1.Text);
                    command.Parameters.AddWithValue("@retail_price", Double.Parse(tbPrice.Text));
                    command.Parameters.AddWithValue("@reorder", tbCritical.Text);
                    command.Parameters.AddWithValue("@id", tbId.Text);
                    if (int.Parse(tbCritical.Text) <= 15 && int.Parse(tbCritical.Text) >= 5)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        productList.LoadProducts();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Нет необходимости ставить значение больше 15, но желательно больше 5!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                tbPrice.Clear();
                if (guna2TextBox1.Text != "")
                {
                    purchase_price = Double.Parse(guna2TextBox1.Text);
                    retail_price = (purchase_price * 20) / 100;
                    result = purchase_price + retail_price;
                    tbPrice.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
