using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_supermarket
{
    public partial class Product : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public Product()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myconnection());
           LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();    
            cm = new SqlCommand("select p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.reorder from tbProduct as p inner join tbBrand as b on b.id = p.bid inner join tbCategory as c on c.id = p.cid where concat(p.pdesc, b.brand, c.category) like '%" +textSearchh.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
         }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModule product = new ProductModule(this);
                product.textCode.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                product.textBarcode.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                product.textDescription.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                product.cboBrand.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                product.cboCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                product.textPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                product.UDReOrder.Value = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());

                product.textCode.Enabled = false;
                product.btnsave.Enabled = false;
                product.btnupdate.Enabled = true;
                product.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tbProduct where pcode like " + dgvProduct[1, e.RowIndex].Value.ToString() + "", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product have been Deleted successfuly", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadProduct();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule(this);
            productModule.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textSearchh_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void textSearchh_TextChanged_1(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
