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
    public partial class ChangePassword : Form
    {
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        Administrator admin;
        public ChangePassword(Administrator adm)
        {
            InitializeComponent();
            admin = adm;
            bnCheck.Enabled = false;
            pbDone.Visible = false;
            pictureBox4.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            guna2TextBox2.Enabled = false;
            guna2TextBox4.Enabled = false;
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

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            try
            {
                guna2ComboBox1.Items.Clear();
                connection.Open();
                command = new MySqlCommand("select * from employees;", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    guna2ComboBox1.Items.Add(reader.GetString("fullname"));
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pbDone.Visible = false;
            pictureBox4.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            guna2TextBox1.Enabled = true;
            guna2ComboBox1.Enabled = true;
            guna2TextBox2.Enabled = false;
            guna2TextBox4.Enabled = false;
            bnCheck.Text = "Проверить";
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox4.Clear();
            guna2ComboBox1.SelectedIndex = -1;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string fullname = "", password = "";
            bool active_status;
            try
            {
                connection.Open();
                if (guna2ComboBox1.Enabled == true && guna2TextBox1.Enabled == true)
                {
                    command = new MySqlCommand("select * from employees where fullname = @fullname and password = @password;", connection);
                    command.Parameters.AddWithValue("@fullname", guna2ComboBox1.Text);
                    command.Parameters.AddWithValue("@password", guna2TextBox1.Text);
                    reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        password = reader["password"].ToString();
                        fullname = reader["fullname"].ToString();
                        active_status = bool.Parse(reader["active_status"].ToString());
                        if (active_status)
                        {
                            guna2ComboBox1.Enabled = false;
                            guna2TextBox1.Enabled = false;
                            pbDone.Visible = true;
                            pictureBox4.Visible = true;
                            guna2TextBox2.Enabled = true;
                            guna2TextBox4.Enabled = true;
                            bnCheck.Enabled = false;
                            bnCheck.Text = "Сменить";
                        }
                        else
                        {
                            MessageBox.Show("Аккаунт не активен!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверно введён пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (guna2TextBox2.Text != "" && guna2TextBox4.Text != "" && guna2ComboBox1.Enabled == false && guna2TextBox1.Enabled == false)
                {
                    if (guna2TextBox1.Text == guna2TextBox2.Text && guna2TextBox2.Text == guna2TextBox4.Text)
                    {
                        MessageBox.Show("Пароль не должен совпадать с ранее используемым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (guna2TextBox2.Text != guna2TextBox4.Text)
                    {
                        MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        command = new MySqlCommand("update employees set password = @password where fullname = @fullname;", connection);
                        command.Parameters.AddWithValue("@fullname", guna2ComboBox1.Text);
                        command.Parameters.AddWithValue("@password", guna2TextBox2.Text);
                        command.ExecuteNonQuery();
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        MessageBox.Show("Смена пароля прошла успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.Text != "" && guna2TextBox1.Text != "")
            {
                bnCheck.Enabled = true;
            }
            else
            {
                bnCheck.Enabled = false;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.Text != "" && guna2TextBox1.Text != "")
            {
                bnCheck.Enabled = true;
            }
            else
            {
                bnCheck.Enabled = false;
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text != "" && guna2TextBox4.Text != "")
            {
                bnCheck.Enabled = true;
            }
            else
            {
                bnCheck.Enabled = false;
            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text != "" && guna2TextBox4.Text != "")
            {
                bnCheck.Enabled = true;
            }
            else
            {
                bnCheck.Enabled = false;
            }
        }
    }
}
