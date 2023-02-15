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
    public partial class BandModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Brand brand;

        public BandModule(Brand br)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myconnection());
            brand = br;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbBrand(brand)VALUES(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", textBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has successful saved.", "POS");
                    Clear();
                    brand.LoadBrand();
                }
                brand.LoadBrand();
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BandModule_Load(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            textBrand.Clear();
            btnupdate.Enabled = false;
            btnsave.Enabled = true;
            textBrand.Focus();

        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //update batton
            if(MessageBox.Show("Are you sure you want to Udate this brand","Pop", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("update tbBrand set brand = @brand where id like '" + lblid.Text + "'", cn);
                cm.Parameters.AddWithValue("@brand", textBrand.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Brand has been successfuly updated", "Pos");
                Clear();
                this.Dispose();
            }
        }
    }
}
