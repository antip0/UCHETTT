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
    public partial class PassRecovery : Form
    {
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        public string password = "";
        public bool active_status;
        public PassRecovery()
        {
            InitializeComponent();
            TextBoxUserWord.PasswordChar = '*';
            TextBoxUserPass1.PasswordChar = '*';
            TextBoxUserPass2.PasswordChar = '*';
            TextBoxUserPass1.Enabled = false;
            TextBoxUserPass2.Enabled = false;
            pbDone.Visible = false;
            pbDone1.Visible = false;
            pbDone2.Visible = false;
            pbDone3.Visible = false;
            bnCheck.Enabled = false;
        }

        public void clearInfo()
        {
            TextBoxUserWord.Clear();
            TextBoxUserPass1.Clear();
            TextBoxUserPass2.Clear();
            TextBoxUserName.Clear();
        }

        private void passRecovery_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void passRecovery_Shown(object sender, EventArgs e)
        {
            TextBoxUserName.Focus();
        }

        private void TextBoxUserPass1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void TextBoxUserWord_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxUserName_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clearInfo();
            bnCheck.Text = "Проверить";
            bnCheck.Enabled = false;
            TextBoxUserPass1.Enabled = false;
            TextBoxUserPass2.Enabled = false;
            TextBoxUserWord.Enabled = true;
            TextBoxUserName.Enabled = true;
            pbDone.Visible = false;
            pbDone1.Visible = false;
            pbDone2.Visible = false;
            pbDone3.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string fullname = "", recovery_word = "";
            try
            {
                connection.Open();
                if (TextBoxUserName.Enabled == true && TextBoxUserWord.Enabled == true)
                {                   
                    command = new MySqlCommand("select * from employees where fullname = @fullname and recovery_word = @recovery_word;", connection);
                    command.Parameters.AddWithValue("@fullname", TextBoxUserName.Text);
                    command.Parameters.AddWithValue("@recovery_word", TextBoxUserWord.Text);
                    reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        recovery_word = reader["recovery_word"].ToString();
                        fullname = reader["fullname"].ToString();
                        active_status = bool.Parse(reader["active_status"].ToString());
                        if (active_status)
                        {
                                TextBoxUserName.Enabled = false;
                                TextBoxUserWord.Enabled = false;
                                pbDone.Visible = true;
                                pbDone1.Visible = true;
                            TextBoxUserPass1.Enabled = true;
                                TextBoxUserPass2.Enabled = true;
                            bnCheck.Enabled = false;
                            bnCheck.Text = "Сменить пароль";
                        }
                        else
                        {
                            MessageBox.Show("Аккаунт не активен!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ничего не найдено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (TextBoxUserPass1.Text != "" && TextBoxUserPass2.Text != "" && TextBoxUserName.Enabled == false && TextBoxUserWord.Enabled == false)
                {
                    if (TextBoxUserPass1.Text != TextBoxUserPass2.Text)
                    {
                        MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        command = new MySqlCommand("update employees set password = @password where fullname = @fullname;", connection);
                        command.Parameters.AddWithValue("@fullname", TextBoxUserName.Text);
                        command.Parameters.AddWithValue("@password", TextBoxUserPass1.Text);
                        command.ExecuteNonQuery();
                        pbDone2.Visible = true;
                        pbDone3.Visible = true;
                        MessageBox.Show("Пароль успешно восстановлен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void TextBoxUserName_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxUserName.Text != "" && TextBoxUserWord.Text != "")
            {
                bnCheck.Enabled = true;
            }
            else
            {
                bnCheck.Enabled = false;
            }
        }

        private void TextBoxUserWord_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxUserName.Text != "" && TextBoxUserWord.Text != "")
            {
                bnCheck.Enabled = true;
            }
            else
            {
                bnCheck.Enabled = false;
            }
        }

        private void TextBoxUserPass1_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxUserPass1.Text != "" && TextBoxUserPass2.Text != "")
            {
                bnCheck.Enabled = true;
            }
            else
            {
                bnCheck.Enabled = false;
            }
        }

        private void TextBoxUserPass2_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxUserPass1.Text != "" && TextBoxUserPass2.Text != "")
            {
                bnCheck.Enabled = true;
            }
            else
            {
                bnCheck.Enabled = false;
            }
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            pbDone.Visible = false;
            pbDone1.Visible = false;
            pbDone2.Visible = false;
            pbDone3.Visible = false;
            TextBoxUserName.Clear();
            TextBoxUserWord.Clear();
            TextBoxUserPass1.Clear();
            TextBoxUserPass2.Clear();
            bnCheck.Text = "Проверить";
            TextBoxUserName.Enabled = true;
            TextBoxUserWord.Enabled = true;
            TextBoxUserPass1.Enabled = false;
            TextBoxUserPass2.Enabled = false;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
