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
    public partial class CashierPOS : Form
    {
        public CashierPOS()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Server=193.225.33.22; Database=PZ7SK0_2021; user=RE1D25;Password=szelektcsillag");

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

        private void populate()
        {
            connect.Open();
            string query = "select prodName,prodQuantity from productTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDGV1.DataSource = ds.Tables[0];
            connect.Close();
        }
        private void populateBills()
        {
            connect.Open();
            string query = "select * from billTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGV.DataSource = ds.Tables[0];
            connect.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CashierPOS_Load(object sender, EventArgs e)
        {
            populate();
            populateBills();
            fillComboBox();
            lblCashName.Text = Form1.CashName;
            lblDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

   

        private void prodDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodName.Text = prodDGV1.SelectedRows[0].Cells[0].Value.ToString();
            prodPrice.Text = prodDGV1.SelectedRows[0].Cells[1].Value.ToString();
         
        }

        int n = 0, grdTotal = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if(billId.Text == String.Empty)
            {
                MessageBox.Show("Missing bill Id");
            }else
            {
                try
                {
                    connect.Open();
                    string query = "insert into billTbl values(" + billId.Text + ",'" + lblCashName.Text + "', " + lblDate.Text + "," + lblAmount.Text + ");";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Added Successfully");
                    connect.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                populateBills();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                document.Print();
            }
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Store", new Font("Century Gothic",25,FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill Id: " + DGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100,700));
            e.Graphics.DrawString("Cashier Name: " + DGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, 100));
            e.Graphics.DrawString("Date: " + DGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, 130));
            e.Graphics.DrawString("Total Amount : " + DGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, 160));
            e.Graphics.DrawString("CodeSpace", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Red, new Point(230, 230));


        }

        private void button8_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void prodCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            connect.Open();
            string query = "select prodName,prodQuantity from productTbl where prodCat='" + prodCmb.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDGV1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int  total = Convert.ToInt32(prodPrice.Text) * Convert.ToInt32(prodQty.Text);
            if (prodName.Text == String.Empty || prodPrice.Text == String.Empty || prodQty.Text == String.Empty)
            {
                MessageBox.Show("Please fill in all fields");
            }else
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(orderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = prodName.Text;
                newRow.Cells[2].Value = prodQty.Text;
                newRow.Cells[3].Value = prodPrice.Text;
                newRow.Cells[4].Value = total;
                orderDGV.Rows.Add(newRow);
                prodQty.Text = String.Empty;
                n++;
                grdTotal = grdTotal + total;
                lblAmount.Text = grdTotal.ToString();
            }
        }
    }
}
