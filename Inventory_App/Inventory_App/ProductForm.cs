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
            catCmb.ValueMember = "catName";
            catCmb.DataSource = dt;
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
                string query = "instert into productTbl values(" + prodId.Text + ",'" + prodName.Text + "'," + prodQuantity.Text + ", "+prodPrice.Text +","+catCmb.SelectedValue.ToString()+")";
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
    }
}
