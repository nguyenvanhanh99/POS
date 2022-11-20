using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Sales_and_Inventory_System__Gadgets_Shop_
{
    public partial class frmMainMenu : Form
    {
        SqlDataReader rdr = null;
        SqlConnection con = null;
        SqlCommand cmd = null;
        ConnectionString cs = new ConnectionString();
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers();
            frm.Show();
        }

        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistration frm = new frmRegistration();
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistration frm = new frmRegistration();
            frm.Show();
        }

        private void profileEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers();
            frm.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmProduct frm = new frmProduct();
            frm.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void wordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Wordpad.exe");
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskMgr.exe");
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.Show();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubCategory frm = new frmSubCategory();
            frm.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomersRecord frm = new frmCustomersRecord();
            frm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCategory o1 = new frmCategory();
            o1.Hide();
            frmSubCategory o2 = new frmSubCategory();
            o2.Hide();
            frmProduct o3 = new frmProduct();
            o3.Hide();
            frmRegisteredUsersDetails o4 = new frmRegisteredUsersDetails();
            o4.Hide();
            frmRegistration o5 = new frmRegistration();
            o5.Hide();
            frmStockRecord o6 = new frmStockRecord();
            o6.Hide();
            frmCustomersRecord o7 = new frmCustomersRecord();
            o7.Hide();
            frmSuppliersRecord o8 = new frmSuppliersRecord();
            o8.Hide();
            frmProductsRecord2 o9 = new frmProductsRecord2();
            o9.Hide();
            frmSalesRecord2 o10 = new frmSalesRecord2();
            o10.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
            frm.txtUserName.Text = "";
            frm.txtPassword.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.txtUserName.Focus();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
         ToolStripStatusLabel4.Text = System.DateTime.Now.ToString();
         GetData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // ToolStripStatusLabel4.Text = System.DateTime.Now.ToString();
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.Show();
        }

        private void productsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProductsRecord2 frm = new frmProductsRecord2();
            frm.Show();
        }

     
        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStock frm = new frmStock();
            frm.label8.Text = lblUser.Text;
            frm.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStock frm = new frmStock();
            frm.label8.Text = lblUser.Text;
            frm.Show();
        }

        public void GetData()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String sql = "SELECT Product.ProductID,ProductName,Features,Price,sum(Quantity),sum(Price*Quantity) from Temp_Stock,Product where Temp_Stock.ProductID=Product.ProductID group by Product.productID,productname,Price,Features,Quantity having(Quantity>0)  order by ProductName";
                cmd = new SqlCommand(sql, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSales frm = new frmSales();
            frm.label6.Text = lblUser.Text;
            frm.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSales frm = new frmSales();
            frm.label6.Text = lblUser.Text;
            frm.Show();
        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSalesRecord2 frm = new frmSalesRecord2();
            frm.Show();
        }

        private void loginDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginDetails frm = new frmLoginDetails();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try{
            con = new SqlConnection(cs.DBConn);
                con.Open();
                String sql = "SELECT Product.ProductID,ProductName,Features,Price,sum(Quantity),sum(Price*Quantity) from Temp_Stock,Product where Temp_Stock.ProductID=Product.ProductID and ProductName like '" + txtProductName.Text + "%' group by product.ProductID,productname,Price,Features,Quantity having(quantity>0) order by ProductName";
                cmd = new SqlCommand(sql, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            
        }

        private void profileEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSuppliers frm = new frmSuppliers();
            frm.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuppliers frm = new frmSuppliers();
            frm.Show();
        }

        private void suppliersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSuppliersRecord frm = new frmSuppliersRecord();
            frm.Show();
        }

        private void stockToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmStockRecord frm = new frmStockRecord();
            frm.Show();
        }

      
    }
}
