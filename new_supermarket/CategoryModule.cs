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
    public partial class CategoryModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Category category;

        public CategoryModule(Category ct)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myconnection());
            category = ct;
        }

        public void Clear()
        {
            textCategory.Clear();
            textCategory.Focus();
            btnsave.Enabled = true;
            btnupdate.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbCategory(category)VALUES(@category)", cn);
                    cm.Parameters.AddWithValue("@category", textCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has successful saved.", "POS");
                    Clear();
                   // brand.LoadBrand();
                }
                category.LoadCategory();
            }
            catch (Exception ex)
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
            //update batton
            if (MessageBox.Show("Are you sure you want to Udate this category", "Pop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("update tbCategory set category = @category where id like '" + lblid.Text + "'", cn);
                cm.Parameters.AddWithValue("@category", textCategory.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("category has been successfuly updated", "Pos");
                Clear();
                this.Dispose();
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CategoryModule_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
