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
    public partial class frmCustomerProfileEntry : Form
    {
        SqlDataReader rdr = null;
        SqlConnection con = null;
        SqlCommand cmd = null;
        ConnectionString cs = new ConnectionString();
        public frmCustomerProfileEntry()
        {
            InitializeComponent();
        }
  
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên", "Thao tác lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return;
            }

            if (txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thao tác lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            if (txtCity.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thành phố", "Thao tác lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                return;
            }
          
            if (txtContactNo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thao tác lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactNo.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct1 = "select CustomerID from Customer where CustomerID='" + txtCustomerID.Text + "'";

                cmd = new SqlCommand(ct1);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Hồ sơ đã được lưu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                    con = new SqlConnection(cs.DBConn);
                    con.Open();

                    string cb = "insert into Customer(CustomerID,Customername,address,City,ContactNo,ContactNo1,Email) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7)";

                    cmd = new SqlCommand(cb);

                    cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtCustomerID.Text);
                cmd.Parameters.AddWithValue("@d2", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@d3", txtAddress.Text);
                cmd.Parameters.AddWithValue("@d4", txtCity.Text);
                cmd.Parameters.AddWithValue("@d5", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@d6", txtContactNo1.Text);
                cmd.Parameters.AddWithValue("@d7", txtEmail.Text);
        
                  
                    cmd.ExecuteReader();
                    MessageBox.Show("Thao tác thành công", "Chi tiết khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    con.Close();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtContactNo1_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
