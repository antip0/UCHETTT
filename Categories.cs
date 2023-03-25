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
    public partial class Categories : Form
    {

        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        public Categories()
        {
            InitializeComponent();
            LoadCategories();
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

        public void Search()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select id_category, category_name from categories where category_name like '" + tbSearch.Text + "%';", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id_category"].ToString(), reader["category_name"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        public void LoadCategories()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select * from categories order by category_name;", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id_category"].ToString(), reader["category_name"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory(this);
            addCategory.guna2TextBox2.Enabled = false;
            addCategory.guna2Button4.Enabled = false;
            addCategory.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (columnName == "Редактировать")
            {
                AddCategory addCategory = new AddCategory(this);
                addCategory.guna2TextBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                addCategory.guna2TextBox1.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                addCategory.guna2Button1.Enabled = false;
                addCategory.guna2TextBox2.Enabled = false;
                addCategory.ShowDialog();
            }
            else if (columnName == "Удалить")
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        command = new MySqlCommand("delete from categories where id_category like '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        LoadCategories();
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
