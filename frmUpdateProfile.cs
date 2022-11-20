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
    public partial class frmUpdateProfile : Form
    {
        SqlDataReader rdr = null;
        SqlConnection con = null;
        SqlCommand cmd = null;
        ConnectionString cs = new ConnectionString();
        public frmUpdateProfile()
        {
            InitializeComponent();
        }
  
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
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
                    MessageBox.Show("Vui lòng nhập thành phố", "Thao tác lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCity.Focus();
                    return;
                }

                if (txtContactNo.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại", "Thao tác lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContactNo.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "update Customer set Customername=@d2,address=@d3,City=@d4,ContactNo=@d5,ContactNo1=@d6,Email=@d7 where CustomerID=@d1";

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
                MessageBox.Show("Cập nhật thành công", "Chi tiết khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate.Enabled = false;
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
        public void Getdata()
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT CustomerID,CustomerName,Address,City,ContactNo,ContactNo1,Email FROM Customer WHERE CustomerID = '" + txtCustomerID.Text.Trim() + "'";
            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                txtCustomerID.Text = (rdr.GetString(0).Trim());
                txtCustomerName.Text = (rdr.GetString(1).Trim());
                txtAddress.Text = (rdr.GetString(2).Trim());
                txtCity.Text = (rdr.GetString(3).Trim());
                txtContactNo.Text = (rdr.GetString(4).Trim());
                txtContactNo1.Text = (rdr.GetString(5).Trim());
                txtEmail.Text = (rdr.GetString(6).Trim());
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
        private void frmUpdateProfile_Load(object sender, EventArgs e)
        {
            Getdata();
        }

    }
}
