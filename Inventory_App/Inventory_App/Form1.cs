using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
                        MessageBox.Show("You are a cashier");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a role");
                }
            }
        }
    }
}
