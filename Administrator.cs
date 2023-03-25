using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uchettt
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
            panelVisible();
            pbBack.Visible = false;
            panelTabs.Width = 47;
        }

        #region panel

        private void panelVisible()
        {
            panelProducts.Visible = false;
            panelStock.Visible = false;
        }

        private void hideSub()
        {
            if (panelProducts.Visible == true)
            {
                panelProducts.Visible = false;
            }
            if (panelStock.Visible == true)
            {
                panelStock.Visible = false;
            }
        }

        private void showSub(Panel sub)
        {
            if (sub.Visible == false)
            {
                hideSub();
                sub.Visible = true;
                pbBack.Visible = true;
                pbForward.Visible = false;
                panelTabs.Width = 47 + 168;
                label1.Visible = false;
                label2.Visible = false;
            }
            else if (sub.Visible == true)
            {
                sub.Visible = false;
                pbBack.Visible = false;
                pbForward.Visible = true;
                panelTabs.Width = 215 - 168;
            }
        }

        #endregion panel
        public void openForm(Form Form)
        {
            Form.TopLevel = false;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;
            panelDGVPlace.Controls.Add(Form);
            panelDGVPlace.Tag = Form;
            Form.BringToFront();
            Form.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {
            label1.Text = "Добро пожаловать, " + labelUserName.Text + "!";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            showSub(panelProducts);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            showSub(panelStock);
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(this);
            changePassword.ShowDialog();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panelTitle.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            labelUserName.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            labelUserRole.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void pbForward_Click(object sender, EventArgs e)
        {
            pbBack.Visible = true;
            pbForward.Visible = false;
            panelTabs.Width = 47 + 168;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            hideSub();
            pbBack.Visible = false;
            pbForward.Visible = true;
            panelTabs.Width = 215 - 168;
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void MainFormAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            hideSub();
        }

        private void bnManufacturers_Click(object sender, EventArgs e)
        {
            openForm(new Manufacturers());
        }

        private void bnCategories_Click(object sender, EventArgs e)
        {
            openForm(new Categories());
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            openForm(new Suppliers());
            hideSub();
        }


        private void bnProductList_Click(object sender, EventArgs e)
        {
            openForm(new ProductList());
        }

        private void bnEmployees_Click(object sender, EventArgs e)
        {
            openForm(new Employees());
            hideSub();
        }

        private void bnStockIn_Click(object sender, EventArgs e)
        {
            openForm(new Stock());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            openForm(new Cancellation(this));
        }
    }
}
