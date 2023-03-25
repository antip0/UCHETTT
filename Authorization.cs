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
    public partial class authorization : Form
    {
        Timer timer;
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        string query = "select * from employees;";
        public string password = "";
        public bool active_status;
        public authorization()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelFioWarning.Visible = false;
            labelPasswordWarning.Visible = false;
            pictureBox1.Visible = false;
            tbUserPassword.PasswordChar = '*';
            try
            {
                cbUserName.Items.Clear();
                connection.Open();
                command = new MySqlCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbUserName.Items.Add(reader.GetString("fullname"));
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        public void clearInfo()
        {
            cbUserName.SelectedIndex = -1;
            tbUserPassword.Clear();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tbUserPassword.PasswordChar = '*';
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tbUserPassword.PasswordChar = '\0';
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string fullname = "";
            int role = 0;
            if (cbUserName.Text == "")
            {
                timer = new Timer();
                timer.Interval = 2500;
                timer.Tick += Timer_Tick;
                labelFioWarning.Visible = true;
                timer.Start();
            }
            if (tbUserPassword.Text == "")
            {
                timer = new Timer();
                timer.Interval = 2500;
                timer.Tick += Timer_Tick;
                labelPasswordWarning.Visible = true;
                timer.Start();
            }
            if (cbUserName.Text != "" && tbUserPassword.Text != "")
            {
                try
                {
                    connection.Open();
                    command = new MySqlCommand("select * from employees where fullname = @fullname and password = @password;", connection);
                    command.Parameters.AddWithValue("@fullname", cbUserName.Text);
                    command.Parameters.AddWithValue("@password", tbUserPassword.Text);
                    reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        fullname = reader["fullname"].ToString();
                        role = int.Parse(reader["role"].ToString());
                        password = reader["password"].ToString();
                        active_status = bool.Parse(reader["active_status"].ToString());
                        if (active_status)
                        {
                            if (role == 1)
                            {
                                MessageBox.Show("Здравствуйте, " + fullname + "!", "Приветствие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cbUserName.SelectedIndex = -1;
                                tbUserPassword.Clear();
                                labelFioWarning.Visible = false;
                                labelPasswordWarning.Visible = false;
                                Administrator admin = new Administrator();
                                admin.labelUserName.Text = fullname;
                                admin.labelUserRole.Text = "Администратор";
                                admin.Owner = this;
                                this.Hide();
                                admin.Show();
                            }
                            else
                            {
                                MessageBox.Show("Здесь должен был открыться модуль кассира, но его его пока нет!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Аккаунт не активен! Обратитесь к администратору.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введён неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка!" + Environment.NewLine + ex.Message);
                }

            }
            else
            {

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            PassRecovery passRecovery = new PassRecovery();
            passRecovery.Owner = this;
            passRecovery.ShowDialog();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelFioWarning.Visible = false;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            labelPasswordWarning.Visible = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panelTitle.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            labelTabName.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUserName.Text != "")
            {
                labelFioWarning.Visible = false;
            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbUserPassword.Text != "")
            {
                labelPasswordWarning.Visible = false;
            }
        }

        private void tbUserPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbUserPassword.Text != "")
            {
                labelPasswordWarning.Visible = false;
            }
            else
            {
                timer = new Timer();
                timer.Interval = 2500;
                timer.Tick += Timer_Tick;
                labelPasswordWarning.Visible = true;
                timer.Start();
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            clearInfo();
            labelFioWarning.Visible = false;
            labelPasswordWarning.Visible = false;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUserName.Text != "")
            {
                labelFioWarning.Visible = false;
            }
            else
            {
                timer = new Timer();
                timer.Interval = 2500;
                timer.Tick += Timer_Tick;
                labelFioWarning.Visible = true;
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelFioWarning.Visible = false;
            labelPasswordWarning.Visible = false;
        }
    }
}
