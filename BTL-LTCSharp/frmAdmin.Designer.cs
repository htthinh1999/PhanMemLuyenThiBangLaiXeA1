namespace BTL_LTCSharp
{
    partial class frmAdmin
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
            this.picAllResult = new System.Windows.Forms.PictureBox();
            this.picAddQuestionAnswer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAllResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddQuestionAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitle.Location = new System.Drawing.Point(93, 390);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "THÊM CÂU HỎI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(376, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "CÁC THÔNG TIN NGƯỜI DÙNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 23.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(144, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "LỰA CHỌN CHỨC NĂNG";
            // 
            // picAllResult
            // 
            this.picAllResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAllResult.Image = global::BTL_LTCSharp.Properties.Resources.history;
            this.picAllResult.Location = new System.Drawing.Point(372, 87);
            this.picAllResult.Name = "picAllResult";
            this.picAllResult.Size = new System.Drawing.Size(300, 300);
            this.picAllResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAllResult.TabIndex = 1;
            this.picAllResult.TabStop = false;
            this.picAllResult.Click += new System.EventHandler(this.picAllResult_Click);
            // 
            // picAddQuestionAnswer
            // 
            this.picAddQuestionAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddQuestionAnswer.Image = global::BTL_LTCSharp.Properties.Resources.question_answer;
            this.picAddQuestionAnswer.Location = new System.Drawing.Point(15, 87);
            this.picAddQuestionAnswer.Name = "picAddQuestionAnswer";
            this.picAddQuestionAnswer.Size = new System.Drawing.Size(300, 300);
            this.picAddQuestionAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddQuestionAnswer.TabIndex = 0;
            this.picAddQuestionAnswer.TabStop = false;
            this.picAddQuestionAnswer.Click += new System.EventHandler(this.picAddQuestionAnswer_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picAllResult);
            this.Controls.Add(this.picAddQuestionAnswer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỰA CHỌN CHỨC NĂNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picAllResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddQuestionAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picAllResult;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picAddQuestionAnswer;
    }
}