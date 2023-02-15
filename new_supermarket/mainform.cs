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

namespace new_supermarket
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();

        public Form1()
        {
            InitializeComponent();
            CostomizeDesing();
            cn = new SqlConnection(dbcon.myconnection());
            cn.Open();
           // MessageBox.Show("database connected");
        }

        private Form activeForm = null;
        public void openchildForm(Form childForm)
        {
            if (activeForm != null)
                    activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                lbtitle.Text = childForm.Text;
                panel1main.Controls.Add(childForm);
                panel1main.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }

        private void CostomizeDesing()
        {
            panel1subproduct.Visible = false;
            panelsubrecord.Visible = false;
            panelsubstock.Visible = false;
            panelsubsetting.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel1subproduct.Visible == true)
                panel1subproduct.Visible = false;
            if (panelsubrecord.Visible == true)
                panelsubrecord.Visible = false; 
            if (panelsubstock.Visible == true)
                panelsubstock.Visible = false; 
            if (panelsubsetting.Visible == true)
                panelsubsetting.Visible = false;
        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1tital_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndashboaed_Click(object sender, EventArgs e)
        {

        }

        private void panel1main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            showsubmenu(panel1subproduct);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildForm(new Product());
            hideSubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchildForm(new Category());
            hideSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchildForm(new Brand());
            hideSubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openchildForm(new Supplier());
            hideSubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubrecord);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubsetting);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panellogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnIn_Stock_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubstock);
        }

        private void btnStock_Entry_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
    }
}
