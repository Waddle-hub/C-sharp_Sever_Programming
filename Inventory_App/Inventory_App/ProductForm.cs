using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_App
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"");

        private void populate()
        {
            connect.Open();
            string query = "select * from categoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDGV.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fillComboBox()
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select catName from categoryTbl", connect);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("catName", typeof(string));
            dt.Load(rdr);
            prodCmb.ValueMember = "catName";
            prodCmb.DataSource = dt;
            connect.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            this.Hide();
            category.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string query = "instert into productTbl values(" + prodId.Text + ",'" + prodName.Text + "'," + prodQuantity.Text + ", "+prodPrice.Text +","+prodCmb.SelectedValue.ToString()+");";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                populate();
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prodDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodId.Text = prodDGV.SelectedRows[0].Cells[0].Value.ToString();
            prodName.Text = prodDGV.SelectedRows[0].Cells[1].Value.ToString();
            prodQuantity.Text = prodDGV.SelectedRows[0].Cells[2].Value.ToString();
            prodPrice.Text = prodDGV.SelectedRows[0].Cells[3].Value.ToString();
            prodCmb.SelectedValue = prodDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodId.Text == String.Empty)
                {
                    MessageBox.Show("Please select a product to delete");
                }
                else
                {
                    connect.Open();
                    string query = "delete from productTbl where prodId=" + prodId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted");
                    connect.Close();
                    populate();
                }
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
                if (prodId.Text == String.Empty || prodName.Text == String.Empty || prodPrice.Text == String.Empty || prodQuantity.Text == String.Empty)
                {
                    MessageBox.Show("Please fill in all the fields before editing");
                }
                else
                {
                    connect.Open();
                    string query = "update productTbl set prodName='" + prodName.Text + "', prodPrice=" + prodPrice.Text + ", prodCat='"+prodCmb.SelectedValue.ToString()+"' where prodId=" + prodId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product has been edited");
                    connect.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
