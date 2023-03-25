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
    public partial class DateFilter : Form
    {
        MySqlConnection connection = DBUtils.GetDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;
        Stock stock;
        public DateFilter(Stock st)
        {
            InitializeComponent();
            stock = st;
            dtp1.Text = DateTime.Today.ToString();
            dtp2.Text = DateTime.Today.ToString();
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
            stock.dataGridView2.Visible = true;
            stock.dataGridView1.Visible = false;
            try
            {
                connection.Open();
                TimeSpan startDate = new TimeSpan(dtp1.Value.Ticks);
                TimeSpan endDate = new TimeSpan(dtp2.Value.Ticks);
                if (startDate > endDate)
                {
                    MessageBox.Show("Начальная дата не может быть больше конечной", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    int i = 0;
                    stock.dataGridView2.Rows.Clear();
                    command = new MySqlCommand("select id, number, receipts_warehouse.id_product, products.description, receipts_warehouse.quantity, date, receipt_by, suppplier from receipts_warehouse join products on products.id_product = receipts_warehouse.id_product where date between '" + dtp1.Text + "' and '" + dtp2.Text + "';", connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        i++;
                        stock.dataGridView2.Rows.Add(i, reader["id"].ToString(), reader["number"].ToString(), reader["id_product"].ToString(), reader["description"].ToString(), reader["quantity"].ToString(), DateTime.Parse(reader["date"].ToString()).ToShortDateString(), reader["receipt_by"].ToString(), reader["suppplier"].ToString());                      
                    }
                    reader.Close();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
