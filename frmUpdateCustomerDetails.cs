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
    public partial class frmUpdateCustomerDetails : Form
    {
        SqlDataReader rdr= null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();
        public frmUpdateCustomerDetails()
        {
            InitializeComponent();
        }

       
     
        private void Email_Address_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail_Address.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmail_Address.Text))
                {
                    MessageBox.Show("invalid email address", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("only letters,numbers and underscore is allowed", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.SelectAll();
                    e.Cancel = true;
                }
            }
        }

     
        private void Update_record_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter username", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please enter email", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail_Address.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "update registration set  password='" + txtPassword.Text + "',contactno='" + txtContact_no.Text + "',email='" + txtEmail_Address.Text + "',name='" + txtName.Text + "' where username='" + txtUsername.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
        
                MessageBox.Show("Cập nhật thành công", "User Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate_record.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void Getdata()
        {
             con = new SqlConnection(cs.DBConn);
            con.Open();
            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT username,password,name,contactno,email FROM registration WHERE username = '" + textBox1.Text.Trim() + "'";
            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                txtUsername.Text = (rdr.GetString(0).Trim());
                txtPassword.Text = (rdr.GetString(1).Trim());
                txtName.Text = (rdr.GetString(2).Trim());
                txtContact_no.Text = (rdr.GetString(3).Trim());
                txtEmail_Address.Text = (rdr.GetString(4).Trim());
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
        private void frmUpdateCustomerDetails_Load(object sender, EventArgs e)
        {
           txtUsername.ReadOnly = true;
           Getdata();
        }

     
        }

     
    }
