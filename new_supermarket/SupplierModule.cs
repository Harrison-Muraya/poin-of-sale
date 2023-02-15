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
    public partial class SupplierModule : Form
    {
        System.Data.SqlClient.SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stile = "poin of sale";
       Supplier supplier;

        public SupplierModule(Supplier sp)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myconnection());
           supplier = sp;
            //category = ct;
            //LoadCategory();
          //  LoadBrand();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            textAddress.Clear();
            textContact.Clear();
            textEmail.Clear();
            textPhone.Clear();
            textFax.Clear();
            textSupplier.Clear();

            btnsave.Enabled = true;
            btnupdate.Enabled = false;
            textSupplier.Focus();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Supplier", "save Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
                {
                    cn.Open();
                    cm = new SqlCommand("insert into tbSupplier(supplier, address, contactperson, phone, email, fax ) values (@supplier, @address, @contactperson, @phone, @email, @fax )", cn);
                    cm.Parameters.AddWithValue("@supplier", textSupplier.Text);
                    cm.Parameters.AddWithValue("@address", textAddress.Text);
                    cm.Parameters.AddWithValue("@contactperson", textContact.Text);
                    cm.Parameters.AddWithValue("@phone", textPhone.Text);
                    cm.Parameters.AddWithValue("@email", textEmail.Text);
                    cm.Parameters.AddWithValue("@fax", textFax.Text);                   
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Supplier has been successfuly saved", stile);
                    Clear();
                    supplier.LoadSupplier();
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Udate this Supplier", "Pop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("update tbSupplier set supplier = @supplier, address = @address, contactperson = @contactperson, phone = @phone, email = @email, fax = @fax  where id = @id", cn);
                    cm.Parameters.AddWithValue("@supplier", textSupplier.Text);
                    cm.Parameters.AddWithValue("@address", textAddress.Text);
                    cm.Parameters.AddWithValue("@contactperson", textContact.Text);
                    cm.Parameters.AddWithValue("@phone", textPhone.Text);
                    cm.Parameters.AddWithValue("@email", textEmail.Text);
                    cm.Parameters.AddWithValue("@fax", textFax.Text);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Supplier has been successfuly updated", stile);
                    Clear();
                    this.Dispose();
                    supplier.LoadSupplier();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
