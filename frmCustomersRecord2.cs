using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace Sales_and_Inventory_System__Gadgets_Shop_
{
    public partial class frmCustomersRecord2 : Form
    {
       
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();
        public frmCustomersRecord2()
        {
            InitializeComponent();
        }
        public void GetData()
        {
                try{
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(CustomerID)as [Customer ID],RTRIM(Customername) as [Customer Name],RTRIM(address) as [Address],RTRIM(city) as [City],RTRIM(ContactNo) as [Contact No.],RTRIM(ContactNo1) as [Contact No. 1],(email) as [Email],(notes) as [Notes] from Customer order by CustomerName", con);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "Customer");
                dataGridView1.DataSource = myDataSet.Tables["Customer"].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        private void frmCustomersRecord_Load(object sender, EventArgs e)
        {
            GetData();
        }
         
    

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
     
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             try{
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            this.Hide();
            frmCustomers frm= new frmCustomers();
           frm.Show();
           frm.txtCustomerID.Text = dr.Cells[0].Value.ToString();
           frm.txtCustomerName.Text = dr.Cells[1].Value.ToString();
           frm.txtAddress.Text = dr.Cells[2].Value.ToString();
           frm.txtCity.Text = dr.Cells[3].Value.ToString();
           frm.txtContactNo.Text = dr.Cells[4].Value.ToString();
           frm.txtContactNo1.Text = dr.Cells[5].Value.ToString();
           frm.txtEmail.Text = dr.Cells[6].Value.ToString();
           frm.txtNotes.Text = dr.Cells[7].Value.ToString();
           frm.btnUpdate.Enabled = true;
           frm.btnDelete.Enabled = true;
           frm.btnSave.Enabled = false;
           frm.txtCustomerName.Focus();
             }
        
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCustomers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(CustomerID)as [Customer ID],RTRIM(Customername) as [Customer Name],RTRIM(address) as [Address],RTRIM(city) as [City],RTRIM(ContactNo) as [Contact No.],RTRIM(ContactNo1) as [Contact No. 1],(email) as [Email],(notes) as [Notes] from Customer where CustomerName like '" + txtCustomers.Text + "%' order by CustomerName", con);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "Customer");
                dataGridView1.DataSource = myDataSet.Tables["Customer"].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Không có thông tin để xuất excel. Vui lòng kiểm tra lại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsTotal = 0;
            int colsTotal = 0;
            int I = 0;
            int j = 0;
            int iC = 0;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();

            try
            {
                Excel.Workbook excelBook = xlApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
                xlApp.Visible = true;

                rowsTotal = dataGridView1.RowCount - 1;
                colsTotal = dataGridView1.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView1.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView1.Rows[I].Cells[j].Value;
                    }
                }
                _with1.Rows["1:1"].Font.FontStyle = "Bold";
                _with1.Rows["1:1"].Font.Size = 12;

                _with1.Cells.Columns.AutoFit();
                _with1.Cells.Select();
                _with1.Cells.EntireColumn.AutoFit();
                _with1.Cells[1, 1].Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                xlApp = null;
            }
        }

        private void frmCustomersRecord1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmCustomers frm = new frmCustomers();
            frm.Show();
        }
    }
}
