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
    public partial class frmRegistration : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Autocomplete();
        }
        private void Reset()
        {
            txtUsername.Text = "";
            cmbUserType.SelectedIndex = -1;
            txtPassword.Text = "";
            txtContact_no.Text = "";
            txtName.Text = "";
            txtEmail_Address.Text = "";
            btnRegister.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            txtUsername.Focus();
        }
        private void NewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter username", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (cmbUserType.Text == "")
            {
                MessageBox.Show("Please select user type", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUserType.Focus();
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
                    MessageBox.Show("Email ID Already Exists", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                string cb = "insert into Registration(Username,UsertYpe,Password,ContactNo,Email,Name,JoiningDate) VALUES ('" + txtUsername.Text + "','" + cmbUserType.Text + "','" + txtPassword.Text + "','" + txtContact_no.Text + "','" + txtEmail_Address.Text + "','" + txtName.Text + "','" + System.DateTime.Now + "')";

                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                btnRegister.Enabled = false;

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
                    MessageBox.Show("Username not available", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!rdr.Read())
                {
                    MessageBox.Show("Username available", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void GetDetails_Click(object sender, EventArgs e)
        {
            frmRegisteredUsersDetails frm = new frmRegisteredUsersDetails();
            frm.dataGridView1.DataSource = frm.GetData();
            frm.Show();

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

            btnDelete.Enabled = true;
            btnUpdate_record.Enabled = true;
            try
            {
                txtUsername.Text = txtUsername.Text.TrimEnd();
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT Usertype,password,name,contactno,email FROM registration WHERE username = '" + txtUsername.Text.Trim() + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    cmbUserType.Text = (rdr.GetString(0).Trim());
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Autocomplete()
        {
            try{
            con = new SqlConnection(cs.DBConn);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT username FROM registration", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "registration");
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            int i = 0;
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                col.Add(ds.Tables[0].Rows[i]["Username"].ToString());

            }
            txtUsername.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtUsername.AutoCompleteCustomSource = col;
            txtUsername.AutoCompleteMode = AutoCompleteMode.Suggest;

            con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (cmbUserType.Text == "")
            {
                MessageBox.Show("Please select user type", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUserType.Focus();
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

                string cb = "update registration set usertype='" + cmbUserType.Text + "', password='" + txtPassword.Text + "',contactno='" + txtContact_no.Text + "',email='" + txtEmail_Address.Text + "',name='" + txtName.Text + "' where username='" + txtUsername.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
        
                MessageBox.Show("Cập nhật thành công", "User Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                btnUpdate_record.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
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
                if (txtUsername.Text == "admin")
                {
                    MessageBox.Show("Admin Account can not be deleted", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "delete from Registration where Username='" + txtUsername.Text + "'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Đã xóa thành công", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Autocomplete();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    Autocomplete();
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

     
    }
}