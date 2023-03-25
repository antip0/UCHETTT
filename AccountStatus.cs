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
    public partial class AccountStatus : Form
    {
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        Employees employees;
        public AccountStatus(Employees emp)
        {
            InitializeComponent();
            employees = emp;
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

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void AccountStatus_Load(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                guna2ComboBox1.Items.Clear();
                command = new MySqlCommand("select * from employees where role != 1;", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    guna2ComboBox1.Items.Add(reader.GetString("fullname"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + Environment.NewLine + ex.Message);
            }
            reader.Close();
            connection.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2ComboBox1.Text != "")
                {
                    connection.Open();
                    command = new MySqlCommand("select * from employees where fullname = @fullname and active_status = 0;", connection);
                    command.Parameters.AddWithValue("@fullname", guna2ComboBox1.Text);
                    reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        if (MessageBox.Show("Вы действительно хотите активировать этот аккаунт?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string query = "update employees set active_status = 1 where fullname = '" + guna2ComboBox1.Text + "';";
                            getData(query);
                            MessageBox.Show("Активация аккаунта прошла успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            employees.LoadEmployees();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Аккаунт уже активирован!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    reader.Close();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Укажите ФИО!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2ComboBox1.Text != "")
                {
                    connection.Open();
                    command = new MySqlCommand("select * from employees where fullname = @fullname and active_status = 1;", connection);
                    command.Parameters.AddWithValue("@fullname", guna2ComboBox1.Text);
                    reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        if (MessageBox.Show("Вы действительно хотите деактивировать этот аккаунт?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string query = "update employees set active_status = 0 where fullname = '" + guna2ComboBox1.Text + "';";
                            getData(query);
                            MessageBox.Show("Деактивация аккаунта прошла успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            employees.LoadEmployees();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Аккаунт уже деактивирован!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    reader.Close();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Укажите ФИО!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
