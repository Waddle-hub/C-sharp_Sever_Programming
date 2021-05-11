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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string CashName = "";
        SqlConnection connect = new SqlConnection(@"Server=193.225.33.22; Database=PZ7SK0_2021; user=RE1D25;Password=szelektcsillag");

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            userName.Text = String.Empty;
            userPass.Text = String.Empty;
        }

        private void submit_Login_Click(object sender, EventArgs e)
        {
            if (userName.Text == String.Empty || userPass.Text == String.Empty)
            {
                MessageBox.Show("Please fill in all the fields");
            }
            else
            {
                if (roleCMB.SelectedIndex > -1)
                {
                    if (roleCMB.SelectedItem.ToString() == "Admin")
                    {
                        if (userName.Text == "Admin" && userPass.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Admin access only");
                        }
                    }
                    else if (roleCMB.SelectedItem.ToString() == "Cashier")
                    {
                        connect.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from cashierTbl where cashName='"+userName.Text+"' and cashPass='"+userPass.Text+"'", connect);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            CashierPOS cash = new CashierPOS();
                            this.Hide();
                            CashName = userName.Text;
                            cash.Show();
                        }
                        else
                        {
                            MessageBox.Show("No matching account");
                        }
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a role");
                }
            }
        }

        private void back_Circle_Click(object sender, EventArgs e)
        {

        }
    }
}
