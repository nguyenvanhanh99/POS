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
    public partial class frmCustomers : Form
    {
      
        SqlConnection con = null;
        SqlCommand cmd = null;
        ConnectionString cs = new ConnectionString();
        public frmCustomers()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtAddress.Text = "";
            txtCity.Text = "";
            txtEmail.Text = "";
            txtCustomerName.Text = "";
            txtContactNo1.Text = "";
            txtNotes.Text = "";
            txtContactNo.Text = "";
            txtCustomerID.Text = "";
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            txtCustomerName.Focus();

        }
        private void frmCustomers_Load(object sender, EventArgs e)
        {

        }
        private void auto()
        {
            txtCustomerID.Text = "C-" + GetUniqueKey(6);
        }
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "123456789".ToCharArray();
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
      
     
        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
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

            try
            {
                auto();
             
                    con = new SqlConnection(cs.DBConn);
                    con.Open();

                    string cb = "insert into Customer(CustomerID,Customername,address,City,ContactNo,ContactNo1,Email,Notes) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)";

                    cmd = new SqlCommand(cb);

                    cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtCustomerID.Text);
                cmd.Parameters.AddWithValue("@d2", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@d3", txtAddress.Text);
                cmd.Parameters.AddWithValue("@d4", txtCity.Text);
                cmd.Parameters.AddWithValue("@d5", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@d6", txtContactNo1.Text);
                cmd.Parameters.AddWithValue("@d7", txtEmail.Text);
                cmd.Parameters.AddWithValue("@d8", txtNotes.Text);
                  
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
        private void delete_records()
        {

            try
            {

              int RowsAffected = 0;
              con = new SqlConnection(cs.DBConn);
              con.Open();
              string cq = "delete from Customer where CustomerID='" + txtCustomerID.Text + "'";
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
                    con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Bạn có muốn xóa thông tin", "Hồ sơ khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    delete_records();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                string cb = "update Customer set Customername=@d2,address=@d3,City=@d4,ContactNo=@d5,ContactNo1=@d6,Email=@d7,Notes=@d8 where CustomerID=@d1";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtCustomerID.Text);
                cmd.Parameters.AddWithValue("@d2", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@d3", txtAddress.Text);
                cmd.Parameters.AddWithValue("@d4", txtCity.Text);
                cmd.Parameters.AddWithValue("@d5", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@d6", txtContactNo1.Text);
                cmd.Parameters.AddWithValue("@d7", txtEmail.Text);
                cmd.Parameters.AddWithValue("@d8", txtNotes.Text);
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

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomersRecord2 frm = new frmCustomersRecord2();
            frm.Show();
            frm.GetData();
        }

    }
}
