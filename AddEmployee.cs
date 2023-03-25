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
    public partial class AddEmployee : Form
    {
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        Employees employees;
        public AddEmployee(Employees emp)
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

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "insert into employees (fullname, password, recovery_word) values ('" + tbFullname.Text + "', '" + tbPass.Text + "', '" + tbUserWord.Text + "');";
            string query1 = "update employees set role = (select id_role from roles where role = '" + cbRole.Text + "') where fullname = '" + tbFullname.Text + "';";
            string query2 = "update employees set active_status = 1 order by id_employee desc limit 1;";
            string query3 = "update employees set active_status = 0 order by id_employee desc limit 1;";
            try
            {
                connection.Open();
                if (tbFullname.Text != "" && cbRole.Text != "" && tbPass.Text != "" && tbPassRepeat.Text != "" && tbUserWord.Text != "")
                {
                    if (tbPass.Text == tbPassRepeat.Text)
                    {
                        getData(query + query1);
                        if (checkBox1.Checked == true)
                        {
                            getData(query2);
                        }
                        else
                        {
                            getData(query3);
                        }
                        employees.LoadEmployees();
                        tbUserWord.Clear();
                        tbFullname.Clear();
                        tbPassRepeat.Clear();
                        tbPass.Clear();
                        cbRole.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                  
                }
                else
                {
                    MessageBox.Show("Заполните все пустые поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tbFullname.Clear();
            tbPassRepeat.Clear();
            tbPass.Clear();
            cbRole.SelectedIndex = -1;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
