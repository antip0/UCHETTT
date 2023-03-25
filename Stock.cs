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
    public partial class Stock : Form
    {
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        public Stock()
        {
            InitializeComponent();
            guna2Button2.Enabled = false;
            guna2Button3.Enabled = false;
            getNumber();
            LoadReceipts();
            dtDate.Text = DateTime.Today.ToString();
        }

        public void getNumber()
        {
            Random random = new Random();
            tbNumber.Clear();
            tbNumber.Text += random.Next(111111111, 999999999);
        }

        public void LoadReceiptsWithWhere()
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select id, number, receipts_warehouse.id_product, products.description, receipts_warehouse.quantity, date, receipt_by, suppplier from receipts_warehouse join products on products.id_product = receipts_warehouse.id_product where number = '" + tbNumber.Text + "' order by number;", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id"].ToString(), reader["number"].ToString(), reader["id_product"].ToString(), reader["description"].ToString(), reader["quantity"].ToString(), DateTime.Parse(reader["date"].ToString()).ToShortDateString(), reader["receipt_by"].ToString(), reader["suppplier"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        public void LoadReceipts()
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            int i = 0;
            dataGridView2.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select id, number, receipts_warehouse.id_product, products.description, receipts_warehouse.quantity, date, receipt_by, suppplier from receipts_warehouse join products on products.id_product = receipts_warehouse.id_product order by id;", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView2.Rows.Add(i, reader["id"].ToString(), reader["number"].ToString(), reader["id_product"].ToString(), reader["description"].ToString(), reader["quantity"].ToString(), DateTime.Parse(reader["date"].ToString()).ToShortDateString(), reader["receipt_by"].ToString(), reader["suppplier"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            getNumber();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            try
            {
                cbReceiptBy.Items.Clear();
                connection.Open();
                command = new MySqlCommand("select * from employees;", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbReceiptBy.Items.Add(reader.GetString("fullname"));
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
                cbSupplier.Items.Clear();
                connection.Open();
                command = new MySqlCommand("select * from suppliers;", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbSupplier.Items.Add(reader.GetString("name"));
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("select * from suppliers where name = '" + cbSupplier.Text + "'", connection);
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                tbFullname.Text = reader["supp_fullname"].ToString();
                tbAddress.Text = reader["address"].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (columnName == "Delete")
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        command = new MySqlCommand("delete from receipts_warehouse where id = '" + dataGridView1[1, e.RowIndex].Value.ToString() + "';", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        LoadReceiptsWithWhere();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            LoadReceiptsWithWhere();
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Ничего не найдено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbNumber.Text != "")
            {
                guna2Button2.Enabled = true;
            }
            else
            {
                guna2Button2.Enabled = false;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    connection.Open();
                    command = new MySqlCommand("update products set quantity = quantity + " + int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) + " where id_product = '" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "';", connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    connection.Open();
                    command = new MySqlCommand("update receipts_warehouse set quantity = quantity + " + int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) + " where id = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "';", connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                guna2Button3.Enabled = false;
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                tbNumber.Clear();
                cbReceiptBy.SelectedIndex = -1;
                cbSupplier.SelectedIndex = -1;
                tbFullname.Clear();
                tbAddress.Clear();

                getNumber();
                LoadReceiptsWithWhere();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            guna2Button3.Enabled = false;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            tbNumber.Clear();
            cbReceiptBy.SelectedIndex = -1;
            cbSupplier.SelectedIndex = -1;
            tbFullname.Clear();
            tbAddress.Clear();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            LoadReceipts();
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Ничего не найдено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbReceiptBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            BrowseProducts browseProducts = new BrowseProducts(this);
            browseProducts.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridView2.Columns[e.ColumnIndex].Name;
            try
            {

                if (columnName == "DeleteFromAll")
                {
                    if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            connection.Open();
                            command = new MySqlCommand("update products set quantity = quantity - " + int.Parse(dataGridView2[5, e.RowIndex].Value.ToString()) + " where id_product = '" + dataGridView2[3, e.RowIndex].Value.ToString() + "';", connection);
                            command.ExecuteNonQuery();
                            command = new MySqlCommand("delete from receipts_warehouse where id = '" + dataGridView2[1, e.RowIndex].Value.ToString() + "';", connection);
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                LoadReceipts();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            DateFilter dateFilter = new DateFilter(this);
            dateFilter.ShowDialog();
        }
    }
}
