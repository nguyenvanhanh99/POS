namespace Sales_and_Inventory_System__Gadgets_Shop_
{
    partial class frmCustomerMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerMainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTrackOrder = new System.Windows.Forms.Button();
            this.btnModifyDetails = new System.Windows.Forms.Button();
            this.btnProfileEntry = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Maroon;
            this.lblUser.Location = new System.Drawing.Point(682, 36);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(44, 22);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Blue;
            this.lblTime.Location = new System.Drawing.Point(560, 76);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 18);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeader.Location = new System.Drawing.Point(282, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(204, 39);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "POINT OF SALE";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.Black;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.Red;
            this.btnUpdateProfile.Location = new System.Drawing.Point(563, 151);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(239, 38);
            this.btnUpdateProfile.TabIndex = 16;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnPlaceOrder.Location = new System.Drawing.Point(563, 236);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(239, 38);
            this.btnPlaceOrder.TabIndex = 15;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(563, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(239, 38);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Log Out";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTrackOrder
            // 
            this.btnTrackOrder.BackColor = System.Drawing.Color.Black;
            this.btnTrackOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackOrder.ForeColor = System.Drawing.Color.Yellow;
            this.btnTrackOrder.Location = new System.Drawing.Point(563, 279);
            this.btnTrackOrder.Name = "btnTrackOrder";
            this.btnTrackOrder.Size = new System.Drawing.Size(239, 38);
            this.btnTrackOrder.TabIndex = 12;
            this.btnTrackOrder.Text = "Track Order";
            this.btnTrackOrder.UseVisualStyleBackColor = false;
            this.btnTrackOrder.Click += new System.EventHandler(this.btnTrackOrder_Click);
            // 
            // btnModifyDetails
            // 
            this.btnModifyDetails.BackColor = System.Drawing.Color.Black;
            this.btnModifyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyDetails.ForeColor = System.Drawing.Color.Cyan;
            this.btnModifyDetails.Location = new System.Drawing.Point(563, 194);
            this.btnModifyDetails.Name = "btnModifyDetails";
            this.btnModifyDetails.Size = new System.Drawing.Size(239, 38);
            this.btnModifyDetails.TabIndex = 11;
            this.btnModifyDetails.Text = "Update Login Details";
            this.btnModifyDetails.UseVisualStyleBackColor = false;
            this.btnModifyDetails.Click += new System.EventHandler(this.btnModifyDetails_Click);
            // 
            // btnProfileEntry
            // 
            this.btnProfileEntry.BackColor = System.Drawing.Color.Black;
            this.btnProfileEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileEntry.ForeColor = System.Drawing.Color.Lime;
            this.btnProfileEntry.Location = new System.Drawing.Point(563, 107);
            this.btnProfileEntry.Name = "btnProfileEntry";
            this.btnProfileEntry.Size = new System.Drawing.Size(239, 38);
            this.btnProfileEntry.TabIndex = 10;
            this.btnProfileEntry.Text = "Profile Entry";
            this.btnProfileEntry.UseVisualStyleBackColor = false;
            this.btnProfileEntry.Click += new System.EventHandler(this.btnProfileEntry_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sales_and_Inventory_System__Gadgets_Shop_.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(33, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmCustomerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(816, 380);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTrackOrder);
            this.Controls.Add(this.btnModifyDetails);
            this.Controls.Add(this.btnProfileEntry);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCustomerMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS [Customer Page]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomerMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomerMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblUser;
        internal System.Windows.Forms.Label lblHeader;
        internal System.Windows.Forms.Button btnUpdateProfile;
        internal System.Windows.Forms.Button btnPlaceOrder;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnTrackOrder;
        internal System.Windows.Forms.Button btnModifyDetails;
        internal System.Windows.Forms.Button btnProfileEntry;
    }
}