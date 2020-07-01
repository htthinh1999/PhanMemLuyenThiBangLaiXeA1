namespace BTL_LTCSharp
{
    partial class frmAllInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllInformation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchResult = new System.Windows.Forms.TextBox();
            this.btnRefreshResult = new System.Windows.Forms.Button();
            this.btnSearchResult = new System.Windows.Forms.Button();
            this.dataHistory = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.btnRefreshInfo = new System.Windows.Forms.Button();
            this.btnSearchInfo = new System.Windows.Forms.Button();
            this.txtSearchInfo = new System.Windows.Forms.TextBox();
            this.dataInformation = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchResult);
            this.groupBox1.Controls.Add(this.btnRefreshResult);
            this.groupBox1.Controls.Add(this.btnSearchResult);
            this.groupBox1.Controls.Add(this.dataHistory);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Location = new System.Drawing.Point(12, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 250);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CÁC KẾT QUẢ THI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(195, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm kiếm thông tin kết quả";
            // 
            // txtSearchResult
            // 
            this.txtSearchResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchResult.Location = new System.Drawing.Point(379, 28);
            this.txtSearchResult.Name = "txtSearchResult";
            this.txtSearchResult.Size = new System.Drawing.Size(257, 25);
            this.txtSearchResult.TabIndex = 5;
            // 
            // btnRefreshResult
            // 
            this.btnRefreshResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshResult.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnRefreshResult.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshResult.Image")));
            this.btnRefreshResult.Location = new System.Drawing.Point(737, 28);
            this.btnRefreshResult.Name = "btnRefreshResult";
            this.btnRefreshResult.Size = new System.Drawing.Size(28, 28);
            this.btnRefreshResult.TabIndex = 4;
            this.btnRefreshResult.UseVisualStyleBackColor = true;
            this.btnRefreshResult.Click += new System.EventHandler(this.btnRefreshResult_Click);
            // 
            // btnSearchResult
            // 
            this.btnSearchResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchResult.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnSearchResult.Location = new System.Drawing.Point(642, 28);
            this.btnSearchResult.Name = "btnSearchResult";
            this.btnSearchResult.Size = new System.Drawing.Size(89, 27);
            this.btnSearchResult.TabIndex = 3;
            this.btnSearchResult.Text = "Tìm kiếm";
            this.btnSearchResult.UseVisualStyleBackColor = true;
            this.btnSearchResult.Click += new System.EventHandler(this.btnSearchResult_Click);
            // 
            // dataHistory
            // 
            this.dataHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistory.Location = new System.Drawing.Point(6, 61);
            this.dataHistory.Name = "dataHistory";
            this.dataHistory.ReadOnly = true;
            this.dataHistory.Size = new System.Drawing.Size(761, 189);
            this.dataHistory.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSex);
            this.groupBox2.Controls.Add(this.btnRefreshInfo);
            this.groupBox2.Controls.Add(this.btnSearchInfo);
            this.groupBox2.Controls.Add(this.txtSearchInfo);
            this.groupBox2.Controls.Add(this.dataInformation);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 262);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblSex.Location = new System.Drawing.Point(168, 42);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(205, 17);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "Tìm kiếm thông tin người dùng";
            // 
            // btnRefreshInfo
            // 
            this.btnRefreshInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshInfo.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnRefreshInfo.Image = global::BTL_LTCSharp.Properties.Resources.icon_refresh1;
            this.btnRefreshInfo.Location = new System.Drawing.Point(737, 37);
            this.btnRefreshInfo.Name = "btnRefreshInfo";
            this.btnRefreshInfo.Size = new System.Drawing.Size(28, 28);
            this.btnRefreshInfo.TabIndex = 3;
            this.btnRefreshInfo.UseVisualStyleBackColor = true;
            this.btnRefreshInfo.Click += new System.EventHandler(this.btnRefreshInfo_Click);
            // 
            // btnSearchInfo
            // 
            this.btnSearchInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchInfo.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.btnSearchInfo.Location = new System.Drawing.Point(642, 37);
            this.btnSearchInfo.Name = "btnSearchInfo";
            this.btnSearchInfo.Size = new System.Drawing.Size(89, 27);
            this.btnSearchInfo.TabIndex = 2;
            this.btnSearchInfo.Text = "Tìm kiếm";
            this.btnSearchInfo.UseVisualStyleBackColor = true;
            this.btnSearchInfo.Click += new System.EventHandler(this.btnSearchInfo_Click);
            // 
            // txtSearchInfo
            // 
            this.txtSearchInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInfo.Location = new System.Drawing.Point(379, 37);
            this.txtSearchInfo.Name = "txtSearchInfo";
            this.txtSearchInfo.Size = new System.Drawing.Size(257, 25);
            this.txtSearchInfo.TabIndex = 1;
            // 
            // dataInformation
            // 
            this.dataInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInformation.Location = new System.Drawing.Point(6, 70);
            this.dataInformation.Name = "dataInformation";
            this.dataInformation.ReadOnly = true;
            this.dataInformation.Size = new System.Drawing.Size(761, 186);
            this.dataInformation.TabIndex = 0;
            // 
            // frmAllInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CÁC THÔNG TIN NGƯỜI DÙNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAllInformation_FormClosing);
            this.Load += new System.EventHandler(this.frmAllInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataInformation;
        private System.Windows.Forms.Button btnSearchResult;
        private System.Windows.Forms.Button btnSearchInfo;
        private System.Windows.Forms.TextBox txtSearchInfo;
        private System.Windows.Forms.Button btnRefreshResult;
        private System.Windows.Forms.Button btnRefreshInfo;
        private System.Windows.Forms.TextBox txtSearchResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSex;
    }
}