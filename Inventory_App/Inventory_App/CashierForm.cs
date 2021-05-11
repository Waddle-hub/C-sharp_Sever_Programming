using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_App
{
    public partial class CashierForm : Form
    {
        private void clearTextBoxes()
        {
            cashId.Text = String.Empty;
            cashName.Text = String.Empty;
            cashAge.Text = String.Empty;
            cashPhone.Text = String.Empty;
            cashPassword.Text = String.Empty;
        }
        public CashierForm()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Server=193.225.33.22; Database=PZ7SK0_2021; user=RE1D25;Password=szelektcsillag");

        private void populate()
        {
            connect.Open();
            string query = "select * from cashierTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            cashDGV.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            this.Hide();
            category.Show();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cashId.Text = cashDGV.SelectedRows[0].Cells[0].Value.ToString();
            cashName.Text = cashDGV.SelectedRows[0].Cells[1].Value.ToString();
            cashAge.Text = cashDGV.SelectedRows[0].Cells[2].Value.ToString();
            cashPhone.Text = cashDGV.SelectedRows[0].Cells[3].Value.ToString();
            cashPassword.Text = cashDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (cashId.Text == String.Empty)
                {
                    MessageBox.Show("Please select a cashier to delete");
                }
                else
                {
                    connect.Open();
                    string query = "delete from cashierTbl where cashId=" + cashId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cashier deleted");
                    connect.Close();
                    populate();
                    clearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string query = "insert into cashierTbl values(" + cashId.Text + ",'" + cashName.Text + "'," + cashAge.Text + ", '" + cashPhone.Text + "','" + cashPassword.Text + "');";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cashier Added Successfully");
                connect.Close();
                populate();
                clearTextBoxes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (cashId.Text == String.Empty || cashName.Text == String.Empty || cashAge.Text == String.Empty || cashPhone.Text == String.Empty || cashPassword.Text == String.Empty)
                {
                    MessageBox.Show("Please fill in all the fields before editing");
                }
                else
                {
                    connect.Open();
                    string query = "update cashierTbl set cashName='" + cashName.Text + "', cashAge=" + cashAge.Text + ", cashPhone='" + cashPhone.Text + "', cashPass='" + cashPassword.Text + "' where cashId =" + cashId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cashier has been edited");
                    connect.Close();
                    clearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
