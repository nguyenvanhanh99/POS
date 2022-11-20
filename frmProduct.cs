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
using System.Security.Cryptography;
namespace Sales_and_Inventory_System__Gadgets_Shop_
{
    public partial class frmProduct : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
       ConnectionString cs = new ConnectionString();
        public frmProduct()
        {
            InitializeComponent();
        }
        private void auto()
        {
            txtProductID.Text = "P-" + GetUniqueKey(6);
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
        private void frmProduct_Load(object sender, EventArgs e)
        {
            FillCombo();
            Autocomplete();
        }
        public void FillCombo()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(CategoryName) from Category order by CategoryName";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbCategory.Items.Add(rdr[0]);
                }
                con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            txtProductName.Text = "";
            cmbSubCategory.Text = "";
            cmbCategory.Text = "";
            txtPrice.Text = "";
            txtFeatures.Text = "";
            pictureBox1.Image = Properties.Resources._12;
            cmbSubCategory.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtProductName.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please enter product name", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }
            if (cmbCategory.Text == "")
            {
                MessageBox.Show("Please select category", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategory.Focus();
                return;
            }
            if (cmbSubCategory.Text == "")
            {
                MessageBox.Show("Please select sub category", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSubCategory.Focus();
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter price", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select ProductName from Product where ProductName='" + txtProductName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Product Name Already Exists", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Text = "";
                    txtProductName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                auto();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "insert into Product(ProductID,ProductName,CategoryID,SubCategoryID,Features,Price,Image) VALUES ('" + txtProductID.Text + "','" + txtProductName.Text + "'," + txtCategoryID.Text+ "," + txtSubCategoryID.Text+ ",@d1,"+ txtPrice.Text +",@d2)";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtFeatures.Text);
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(pictureBox1.Image);
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d2", SqlDbType.Image);
                p.Value = data;
                cmd.Parameters.Add(p);
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Thao tác thành công", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                string cq = "delete from product where productID='" + txtProductID.Text + "'";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Đã xóa thành công", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    Autocomplete();
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
        private void Autocomplete()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT distinct ProductName FROM product", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Product");
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["productname"].ToString());

                }
                txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtProductName.AutoCompleteCustomSource = col;
                txtProductName.AutoCompleteMode = AutoCompleteMode.Suggest;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please enter product name", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return;
            }
            if (cmbCategory.Text == "")
            {
                MessageBox.Show("Please select category", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategory.Focus();
                return;
            }
            if (cmbSubCategory.Text == "")
            {
                MessageBox.Show("Please select sub category", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSubCategory.Focus();
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter price", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            try
            {
              
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "Update product set ProductName='" + txtProductName.Text + "',CategoryID=" + txtCategoryID.Text + ",SubCategoryID=" + txtSubCategoryID.Text + ",Features=@d1,price=" + txtPrice.Text + ",Image=@d2 Where ProductID='" + txtProductID.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtFeatures.Text);
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(pictureBox1.Image);
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d2", SqlDbType.Image);
                p.Value = data;
                cmd.Parameters.Add(p);
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Cập nhật thành công", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                btnUpdate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductsRecord2 frm = new frmProductsRecord2();
            frm.Show();
            frm.GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              try
            {
                var _with1 = openFileDialog1;

                _with1.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                _with1.FilterIndex = 4;
                //Reset the file name
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
             // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
               try
            {
             con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT ID from Category WHERE CategoryName = '" + cmbCategory.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtCategoryID.Text = rdr.GetInt32(0).ToString().Trim();
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            cmbCategory.Text = cmbCategory.Text.Trim();
            cmbSubCategory.Items.Clear();
            cmbSubCategory.Text = "";
            cmbSubCategory.Enabled = true;
            cmbSubCategory.Focus();

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select distinct RTRIM(SubCategoryName) from Category,SubCategory where Category.ID=SubCategory.CategoryID and CategoryName= '" + cmbCategory.Text + "'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                   cmbSubCategory.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }
      
        private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
              try
            {
             con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT ID from SubCategory WHERE SubCategoryName = '" + cmbSubCategory.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtSubCategoryID.Text = rdr.GetInt32(0).ToString().Trim();
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
