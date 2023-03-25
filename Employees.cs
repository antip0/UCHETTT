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
    public partial class Employees : Form
    {

        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        public Employees()
        {
            InitializeComponent();
            LoadEmployees();
        }

        public void Search()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select id_employee, fullname, roles.role, active_status from employees join roles on roles.id_role = employees.role where fullname like '" + tbSearch.Text + "%';", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id_employee"].ToString(), reader["fullname"].ToString(), reader["role"].ToString(), reader["active_status"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        public void LoadEmployees()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("select id_employee, fullname, roles.role, active_status from employees join roles on roles.id_role = employees.role order by fullname;", connection);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader["id_employee"].ToString(), reader["fullname"].ToString(), reader["role"].ToString(), reader["active_status"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AccountStatus accountStatus = new AccountStatus(this);
            accountStatus.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(this);
            addEmployee.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;            
            if (columnName == "Удалить")
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        command = new MySqlCommand("delete from employees where id_employee like '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        LoadEmployees();
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
