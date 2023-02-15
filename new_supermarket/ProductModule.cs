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
    public partial class ProductModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stile = "poin of sale";
        Product product;
        //Category category;

        public ProductModule(Product pd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myconnection());
            product = pd;
            //category = ct;
            LoadCategory();
            LoadBrand();
        }

        public void LoadCategory()
        {
            cboCategory.Items.Clear();
            cboCategory.DataSource = dbcon.getTable("select * from tbCategory");
            cboCategory.DisplayMember = "category";
            cboCategory.ValueMember = "id";
        }

        public void LoadBrand()
        {
            cboBrand.Items.Clear();
            cboBrand.DataSource = dbcon.getTable("select * from tbBrand");
            cboBrand.DisplayMember = "brand";
            cboBrand.ValueMember = "id";
        }

        public void Clear()
        {
            textCode.Clear();
            textBarcode.Clear();
            textDescription.Clear();
            textPrice.Clear();
            cboBrand.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            UDReOrder.Value = 1;

            textCode.Focus();
            textCode.Enabled = true;
            btnsave.Enabled = true;
            btnupdate.Enabled = false;

        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void textBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this product", "save product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
                {
                    cm = new SqlCommand("insert into tbProduct(pcode, barcode, pdesc, bid, cid, price, reorder ) values (@pcode, @barcode, @pdesc, @bid, @cid, @price, @reorder )", cn);
                    cm.Parameters.AddWithValue("@pcode", textCode.Text);
                    cm.Parameters.AddWithValue("@barcode", textBarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", textDescription.Text);
                    cm.Parameters.AddWithValue("@bid", cboBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@cid", cboCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@price", double.Parse(textPrice.Text));
                    cm.Parameters.AddWithValue("@reorder", UDReOrder.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfuly saved", stile);
                    Clear();
                    product.LoadProduct();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ProductModule_Load(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Udate this category", "Pop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("update tbProduct set barcode = @barcode, pdesc = @pdesc, bid = @bid, cid = @cid, price = @price, reorder = @reorder where pcode like @pcode", cn);
                    cm.Parameters.AddWithValue("@pcode", textCode.Text);
                    cm.Parameters.AddWithValue("@barcode", textBarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", textDescription.Text);
                    cm.Parameters.AddWithValue("@bid", cboBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@cid", cboCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@price", double.Parse(textPrice.Text));
                    cm.Parameters.AddWithValue("@reorder", UDReOrder.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfuly updated", stile);
                    Clear();
                    this.Dispose();
                    product.LoadProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
