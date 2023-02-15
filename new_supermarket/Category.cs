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
    public partial class Category : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public Category()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myconnection());
            LoadCategory();
        }
        //Data retrival
        public void LoadCategory()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select * from tbCategory order by category", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString());
            }
            dr.Close();
            cn.Close();
        }



        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //for edit
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tbCategory where id like '" + dgvCategory[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category have been Deleted successfuly", "Pos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Edit")
            {
                CategoryModule module = new CategoryModule(this);
                module.lblid.Text = dgvCategory[1, e.RowIndex].Value.ToString();
                module.textCategory.Text = dgvCategory[2, e.RowIndex].Value.ToString();
                module.btnsave.Enabled = false;
                module.btnupdate.Enabled = true;
                module.ShowDialog();

            }
            LoadCategory();
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            CategoryModule module = new CategoryModule(this);
            module.ShowDialog();
        }
    }
}
