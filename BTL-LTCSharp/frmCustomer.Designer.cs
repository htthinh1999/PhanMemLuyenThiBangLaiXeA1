namespace BTL_LTCSharp
{
    partial class frmCustomer
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picHistory = new System.Windows.Forms.PictureBox();
            this.picExamination = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExamination)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitle.Location = new System.Drawing.Point(105, 390);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "LUYỆN THI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(392, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "THÔNG TIN VÀ LỊCH SỬ THI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(144, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "LỰA CHỌN CHỨC NĂNG";
            // 
            // picHistory
            // 
            this.picHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHistory.Image = global::BTL_LTCSharp.Properties.Resources.history;
            this.picHistory.Location = new System.Drawing.Point(372, 87);
            this.picHistory.Name = "picHistory";
            this.picHistory.Size = new System.Drawing.Size(300, 300);
            this.picHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHistory.TabIndex = 1;
            this.picHistory.TabStop = false;
            this.picHistory.Click += new System.EventHandler(this.picHistory_Click);
            // 
            // picExamination
            // 
            this.picExamination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExamination.Image = global::BTL_LTCSharp.Properties.Resources.examination;
            this.picExamination.Location = new System.Drawing.Point(15, 87);
            this.picExamination.Name = "picExamination";
            this.picExamination.Size = new System.Drawing.Size(300, 300);
            this.picExamination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExamination.TabIndex = 0;
            this.picExamination.TabStop = false;
            this.picExamination.Click += new System.EventHandler(this.picExamination_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picHistory);
            this.Controls.Add(this.picExamination);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỰA CHỌN CHỨC NĂNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExamination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picHistory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picExamination;
    }
}