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
    public partial class BrowseProducts : Form
    {
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        Stock stock;
        public BrowseProducts(Stock st)
        {
            InitializeComponent();
            stock = st;
            LoadProducts();
        }
        public void LoadProducts()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select id_product, description, quantity from products where description like '" + tbSearch.Text + "%';", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id_product"].ToString(), reader["description"].ToString(), reader["quantity"].ToString());
            }
            reader.Close();
            connection.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (columnName == "Выбрать")
            {
                try
                {
                    if (stock.tbNumber.Text != "" && stock.cbReceiptBy.Text != "" && stock.cbSupplier.Text != "")
                    {
                        connection.Open();
                        command = new MySqlCommand("insert into receipts_warehouse (number, id_product, date, receipt_by, suppplier) values (@number, @id_product, @date, @receipt_by, @supplier);", connection);
                        command.Parameters.AddWithValue("@number", stock.tbNumber.Text);
                        command.Parameters.AddWithValue("@id_product", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                        command.Parameters.AddWithValue("@date", stock.dtDate.Value);
                        command.Parameters.AddWithValue("@receipt_by", stock.cbReceiptBy.Text);
                        command.Parameters.AddWithValue("@supplier", stock.cbSupplier.Text);
                        command.ExecuteNonQuery();
                        stock.guna2Button3.Enabled = true;
                        stock.dataGridView1.Visible = true;
                        stock.dataGridView2.Visible = false;
                        connection.Close();
                        stock.LoadReceiptsWithWhere();
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
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            panelTitle.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void labelTabName_MouseMove(object sender, MouseEventArgs e)
        {
            labelTabName.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
