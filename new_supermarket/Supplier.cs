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
    public partial class Supplier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Supplier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myconnection());
            LoadSupplier();
        }

       public void LoadSupplier()
        {
            dgvSupplier.Rows.Clear();
            int i = 0;
            cn.Open();
            cm = new SqlCommand("select * from tbSupplier", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dgvSupplier.Rows.Add(i, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());

            }
            dr.Close();
            cn.Close();
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSupplier.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                SupplierModule supplierModule = new SupplierModule(this);
                supplierModule.lblid.Text = dgvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
                supplierModule.textSupplier.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                supplierModule.textAddress.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                supplierModule.textContact.Text = dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                supplierModule.textPhone.Text = dgvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                supplierModule.textEmail.Text = dgvSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
               // supplierModule.textFax.Text = dgvSupplier.Rows[e.RowIndex].Cells[7].Value.ToString();


                supplierModule.btnsave.Enabled = false;
                supplierModule.btnupdate.Enabled = true;
                supplierModule.ShowDialog();


            }
            else if (colName == "Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete this record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tbSupplier where id like '" + dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Supplier have been Deleted successfuly", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SupplierModule supplierModule = new SupplierModule(this);
            supplierModule.ShowDialog();
        }
    }
}
