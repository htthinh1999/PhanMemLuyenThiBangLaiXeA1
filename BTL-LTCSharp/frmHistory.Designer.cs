namespace BTL_LTCSharp
{
    partial class frmHistory
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
            this.gbxInformation = new System.Windows.Forms.GroupBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataHistory = new System.Windows.Forms.DataGridView();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblBornDate = new System.Windows.Forms.Label();
            this.txtBornDate = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.gbxInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInformation
            // 
            this.gbxInformation.Controls.Add(this.lblAddress);
            this.gbxInformation.Controls.Add(this.txtAddress);
            this.gbxInformation.Controls.Add(this.lblBornDate);
            this.gbxInformation.Controls.Add(this.txtBornDate);
            this.gbxInformation.Controls.Add(this.lblSex);
            this.gbxInformation.Controls.Add(this.txtSex);
            this.gbxInformation.Controls.Add(this.lblUserID);
            this.gbxInformation.Controls.Add(this.lblName);
            this.gbxInformation.Controls.Add(this.txtUserID);
            this.gbxInformation.Controls.Add(this.txtName);
            this.gbxInformation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInformation.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.gbxInformation.Location = new System.Drawing.Point(12, 12);
            this.gbxInformation.Name = "gbxInformation";
            this.gbxInformation.Size = new System.Drawing.Size(776, 105);
            this.gbxInformation.TabIndex = 6;
            this.gbxInformation.TabStop = false;
            this.gbxInformation.Text = "THÔNG TIN";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblUserID.Location = new System.Drawing.Point(6, 40);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(39, 15);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "Mã số";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblName.Location = new System.Drawing.Point(6, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Họ tên";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtUserID.Location = new System.Drawing.Point(61, 36);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(200, 21);
            this.txtUserID.TabIndex = 3;
            this.txtUserID.Text = "Mã số";
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtName.Location = new System.Drawing.Point(61, 68);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(200, 21);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Họ tên";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataHistory);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 315);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LỊCH SỬ";
            // 
            // dataHistory
            // 
            this.dataHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistory.Location = new System.Drawing.Point(6, 34);
            this.dataHistory.Name = "dataHistory";
            this.dataHistory.ReadOnly = true;
            this.dataHistory.Size = new System.Drawing.Size(761, 275);
            this.dataHistory.TabIndex = 0;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblSex.Location = new System.Drawing.Point(277, 40);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(55, 15);
            this.lblSex.TabIndex = 4;
            this.lblSex.Text = "Giới tính";
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSex.Location = new System.Drawing.Point(343, 36);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(150, 21);
            this.txtSex.TabIndex = 5;
            this.txtSex.Text = "Giới tính";
            this.txtSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBornDate
            // 
            this.lblBornDate.AutoSize = true;
            this.lblBornDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBornDate.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblBornDate.Location = new System.Drawing.Point(277, 72);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(60, 15);
            this.lblBornDate.TabIndex = 6;
            this.lblBornDate.Text = "Ngày sinh";
            // 
            // txtBornDate
            // 
            this.txtBornDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBornDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBornDate.Location = new System.Drawing.Point(343, 68);
            this.txtBornDate.Name = "txtBornDate";
            this.txtBornDate.ReadOnly = true;
            this.txtBornDate.Size = new System.Drawing.Size(150, 21);
            this.txtBornDate.TabIndex = 7;
            this.txtBornDate.Text = "Ngày sinh";
            this.txtBornDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblAddress.Location = new System.Drawing.Point(513, 56);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(44, 15);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtAddress.Location = new System.Drawing.Point(574, 52);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(193, 21);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Text = "Địa chỉ";
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxInformation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỊCH SỬ CÁC LẦN THI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHistory_FormClosing);
            this.Load += new System.EventHandler(this.frmHistory_Load);
            this.gbxInformation.ResumeLayout(false);
            this.gbxInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInformation;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataHistory;
        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.TextBox txtBornDate;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
    }
}