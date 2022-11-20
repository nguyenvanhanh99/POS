namespace Sales_and_Inventory_System__Gadgets_Shop_
{
    partial class frmCustomerProfileEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerProfileEntry));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtContactNo1 = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(185, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(160, 190);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(119, 20);
            this.txtContactNo.TabIndex = 3;
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo_KeyPress);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.LightGray;
            this.Label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(31, 29);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(140, 22);
            this.Label11.TabIndex = 12;
            this.Label11.Text = "Chi tiết khách hàng";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(160, 261);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.Location = new System.Drawing.Point(32, 225);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(95, 17);
            this.Label21.TabIndex = 75;
            this.Label21.Text = "Alt. Contact No.";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(34, 262);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(38, 17);
            this.Label20.TabIndex = 74;
            this.Label20.Text = "Email";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(32, 190);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(73, 17);
            this.Label19.TabIndex = 73;
            this.Label19.Text = "Contact No.";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(160, 155);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(144, 20);
            this.txtCity.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(160, 119);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(32, 155);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(31, 17);
            this.Label6.TabIndex = 69;
            this.Label6.Text = "City";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(32, 120);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(52, 17);
            this.Label5.TabIndex = 68;
            this.Label5.Text = "Address";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(34, 85);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 17);
            this.Label2.TabIndex = 67;
            this.Label2.Text = "Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(160, 85);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(273, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // txtContactNo1
            // 
            this.txtContactNo1.Location = new System.Drawing.Point(160, 224);
            this.txtContactNo1.Name = "txtContactNo1";
            this.txtContactNo1.Size = new System.Drawing.Size(119, 20);
            this.txtContactNo1.TabIndex = 4;
            this.txtContactNo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo1_KeyPress);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(315, 29);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(118, 20);
            this.txtCustomerID.TabIndex = 76;
            this.txtCustomerID.Visible = false;
            // 
            // frmCustomerProfileEntry
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(476, 398);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtContactNo1);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtCustomerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerProfileEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox txtContactNo;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.TextBox txtContactNo1;
        internal System.Windows.Forms.TextBox txtCustomerID;
    }
}