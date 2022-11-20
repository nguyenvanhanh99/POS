using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sales_and_Inventory_System__Gadgets_Shop_
{
    public partial class frmCustomerRegistration : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();
        public frmCustomerRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        private void Register_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
          
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtContact_no.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact_no.Focus();
                return;
            }
            if (txtEmail_Address.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Email", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail_Address.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select username from registration where username=@find";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 30, "username"));
                cmd.Parameters["@find"].Value = txtUsername.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Username Already Exists", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtUsername.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct1 = "select Email from registration where Email='" + txtEmail_Address.Text + "'";

                cmd = new SqlCommand(ct1);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("ID Email đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail_Address.Text = "";
                    txtEmail_Address.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into Registration(Username,UserType,Password,ContactNo,Email,Name,JoiningDate) VALUES ('" + txtUsername.Text + "','Customer','" + txtPassword.Text + "','" + txtContact_no.Text + "','" + txtEmail_Address.Text + "','" + txtName.Text + "','" + System.DateTime.Now + "')";

                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Thao tác thành công", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void CheckAvailability_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Please enter username", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select username from registration where username='" + txtUsername.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Tên người dùng không khả dụng", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!rdr.Read())
                {
                    MessageBox.Show("Tên người dùng khả dụng", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();

                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Email_Address_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail_Address.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmail_Address.Text))
                {
                    MessageBox.Show("Địa chỉ Email không hợp lệ!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail_Address.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void Name_Of_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void Username_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9_]");
            if (txtUsername.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtUsername.Text))
                {
                    MessageBox.Show("Chỉ cho phép chữ cái, số, và dấu gạch dưới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.SelectAll();
                    e.Cancel = true;
                }
            }
        }

     
        private void txtContact_no_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmCustomerRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.txtUserName.Text = "";
            frm.txtPassword.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.txtUserName.Focus();
            frm.Show();
        }
    }
}