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
    public partial class Suppliers : Form
    {
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        public Suppliers()
        {
            InitializeComponent();
            LoadSuppliers();
        }
        public void Search()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select * from suppliers where name like '" + tbSearch.Text + "%';", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id_supplier"].ToString(), reader["name"].ToString(), reader["supp_fullname"].ToString(), reader["address"].ToString(), reader["phone_number"].ToString(), reader["email"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        public void LoadSuppliers()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select * from suppliers order by name;", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id_supplier"].ToString(), reader["name"].ToString(), reader["supp_fullname"].ToString(), reader["address"].ToString(), reader["phone_number"].ToString(), reader["email"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier(this);
            addSupplier.guna2Button3.Enabled = false;
            addSupplier.tbId.Enabled = false;
            addSupplier.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (columnName == "Редактировать")
            {
                AddSupplier addSupplier = new AddSupplier(this);
                addSupplier.tbId.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                addSupplier.tbSupplier.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                addSupplier.tbContactPerson.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                addSupplier.tbAddress.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                addSupplier.tbPhone.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                addSupplier.tbEmail.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                addSupplier.guna2Button1.Enabled = false;
                addSupplier.tbId.Enabled = false;
                addSupplier.ShowDialog();
            }
            else if (columnName == "Удалить")
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        command = new MySqlCommand("delete from suppliers where id_supplier like '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        LoadSuppliers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
