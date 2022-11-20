using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace Sales_and_Inventory_System__Gadgets_Shop_
{
    public partial class frmStock : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public frmStock()
        {
            InitializeComponent();
        }
        public void FillCombo()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(SupplierName) from Supplier order by SupplierName";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbSupplierName.Items.Add(rdr[0]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmStock_Load(object sender, EventArgs e)
        {
     
            FillCombo();
        }
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        private void auto()
        {
            txtStockID.Text = "ST-" + GetUniqueKey(6);
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductsRecord1 frm = new frmProductsRecord1();
            frm.label1.Text = label8.Text;
            frm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please retrieve product name", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }
            if (txtQty.Text == "")
            {
                MessageBox.Show("Please enter quantity", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQty.Focus();
                return;
            }
            if (cmbSupplierName.Text == "")
            {
                MessageBox.Show("Please select Supplier name", "Thao tác lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSupplierName.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
               
                string ct = "select ProductID from temp_Stock where ProductID='" + txtProductID.Text + "'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                     con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string cb2 = "Update Temp_Stock set Quantity=Quantity + " + txtQty.Text + " where ProductID='"+ txtProductID.Text + "'";
                    cmd = new SqlCommand(cb2);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();
                 
                }
                else
                {
                     con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string cb1 = "insert into Temp_Stock(ProductID,Quantity) VALUES ('" + txtProductID.Text + "'," + txtQty.Text + ")";
                    cmd = new SqlCommand(cb1);
                    cmd.Connection = con;
                   
                    cmd.ExecuteReader();
                    con.Close(); 
                }
                auto();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "insert into Stock(StockID,ProductID,SupplierID,Quantity,StockDate) VALUES ('" + txtStockID.Text + "','" + txtProductID.Text + "','" + txtSupplierID.Text + "'," + txtQty.Text + ",@d1)";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", dtpStockDate.Text);
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Thao tác thành công", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void Reset()
        {
          
            txtFeatures.Text = "";
            txtProductName.Text = "";
            txtQty.Text = "";
            cmbSupplierName.Text = "";
            txtStockID.Text = "";
            dtpStockDate.Text = DateTime.Today.ToString();
            
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
            }
        }
        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb2 = "Update Temp_Stock set Quantity=Quantity - " + txtQty1.Text + " where ProductID='" + txtProductID.Text + "'";
                cmd = new SqlCommand(cb2);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cq = "delete from Stock where StockID='" + txtStockID.Text + "'";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Đã xóa thành công", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.lblUser.Text = label8.Text;
            frm.Show();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStockRecord1 frm = new frmStockRecord1();
            frm.label1.Text = label8.Text;
            frm.Show();
            frm.GetData();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
                if (txtProductName.Text == "")
                {
                    MessageBox.Show("Please retrieve product name", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Focus();
                    return;
                }
                if (txtQty.Text == "")
                {
                    MessageBox.Show("Please enter quantity", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQty.Focus();
                    return;
                }
                if (cmbSupplierName.Text == "")
                {
                    MessageBox.Show("Please select Supplier name", "Thao tác lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSupplierName.Focus();
                    return;
                }
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();

                    string ct = "select ProductID from temp_Stock where ProductID='" + txtProductID.Text + "'";
                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        con = new SqlConnection(cs.DBConn);
                        con.Open();
                        string cb2 = "Update Temp_Stock set Quantity=Quantity + " + txtQty.Text + " - "+ txtQty1.Text + " where ProductID='" + txtProductID.Text + "'";
                        cmd = new SqlCommand(cb2);
                        cmd.Connection = con;
                        cmd.ExecuteReader();
                        con.Close();

                    }
                    else
                    {
                        con = new SqlConnection(cs.DBConn);
                        con.Open();
                        string cb1 = "insert into Temp_Stock(ProductID,Quantity) VALUES ('" + txtProductID.Text + "'," + txtQty.Text + ")";
                        cmd = new SqlCommand(cb1);
                        cmd.Connection = con;

                        cmd.ExecuteReader();
                        con.Close();
                    }
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string cb = "Update Stock set ProductID='" + txtProductID.Text + "',SupplierID='" + txtSupplierID.Text + "',Quantity=" + txtQty.Text + ",StockDate= '" + dtpStockDate.Text + "' where StockID='" + txtStockID.Text + "'";
                    cmd = new SqlCommand(cb);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Cập nhật thành công", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnUpdate.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

               private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT SupplierID from Supplier WHERE SupplierName = '" + cmbSupplierName.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtSupplierID.Text = rdr.GetString(0).Trim();
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
