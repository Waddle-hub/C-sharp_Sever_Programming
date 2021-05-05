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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"");

        private void addCat_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string query = "instert into categoryTbl values(" + catID.Text + ",'" + catName.Text + "','" + catDesc.Text + "')";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                populate();
                connect.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            connect.Open();
            string query = "select * from categoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            connect.Close();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catID.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            catName.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            catDesc.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void deleteCat_Click(object sender, EventArgs e)
        {
            try
            {
                if(catID.Text == String.Empty)
                {
                    MessageBox.Show("Please select a category to delete");
                }else
                {
                    connect.Open();
                    string query = "delete from categoryTbl where catId=" + catID.Text+ "";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category deleted");
                    connect.Close();
                    populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editCat_Click(object sender, EventArgs e)
        {
            try
            {
                if (catID.Text == String.Empty || catName.Text == String.Empty || catDesc.Text == String.Empty)
                {
                    MessageBox.Show("Please fill in all the fields before editing");
                }else
                {
                    connect.Open();
                    string query = "update categoryTbl set catName='" + catName.Text + "', catDesc='" + catDesc.Text + "' where catId=" + catID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been edited");
                    connect.Close();
                    populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            this.Hide();
            product.Show();
        }
    }
}
