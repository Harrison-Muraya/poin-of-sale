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
    public partial class Brand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;


        public Brand()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myconnection());
            LoadBrand();
           // cn.Open();
            // MessageBox.Show("database connected"

        }

        //data retrival
        public void LoadBrand()
        {
            int i = 0;
            dgvBrand.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select * from tbBrand order by brand", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dgvBrand.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //for edit
            string colName = dgvBrand.Columns[e.ColumnIndex].Name;
            if(colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record","Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tbBrand where id like '" + dgvBrand[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand have been Deleted successfuly", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(colName == "Edit")
            {
                BandModule bandModule = new BandModule(this);
                bandModule.lblid.Text = dgvBrand[1, e.RowIndex].Value.ToString();
                bandModule.textBrand.Text = dgvBrand[2, e.RowIndex].Value.ToString();
                bandModule.btnsave.Enabled = false;
                bandModule.btnupdate.Enabled = true;
                bandModule.ShowDialog();

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            BandModule moduleform = new BandModule(this);
            moduleform.ShowDialog();
        }
    }
}
