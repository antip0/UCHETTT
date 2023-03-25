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
    public partial class Manufacturers : Form
    {
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        public Manufacturers()
        {
            InitializeComponent();
            LoadManufacturers();
        }
        public void Search()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select * from manufacturers where manufacturer_name like '" + tbSearch.Text + "%';", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id_manufacturer"].ToString(), reader["manufacturer_name"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        public void LoadManufacturers()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select * from manufacturers order by manufacturer_name;", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id_manufacturer"].ToString(), reader["manufacturer_name"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddManufacturer addManufacturer = new AddManufacturer(this);
            addManufacturer.guna2TextBox2.Enabled = false;
            addManufacturer.guna2Button4.Enabled = false;
            addManufacturer.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (columnName == "Редактировать")
            {
                AddManufacturer addManufacturer = new AddManufacturer(this);
                addManufacturer.guna2TextBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                addManufacturer.guna2TextBox1.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                addManufacturer.guna2Button1.Enabled = false;
                addManufacturer.guna2TextBox2.Enabled = false;
                addManufacturer.ShowDialog();
            }
            else if (columnName == "Удалить")
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        command = new MySqlCommand("delete from manufacturers where id_manufacturer like '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        LoadManufacturers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
