namespace BTL_LTCSharp
{
    partial class frmExamination
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.gbxInformation = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbxAskAnswer = new System.Windows.Forms.GroupBox();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbxAnswer4 = new System.Windows.Forms.CheckBox();
            this.cbxAnswer3 = new System.Windows.Forms.CheckBox();
            this.cbxAnswer2 = new System.Windows.Forms.CheckBox();
            this.cbxAnswer1 = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbxInformation.SuspendLayout();
            this.gbxAskAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblName.Location = new System.Drawing.Point(6, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Họ Tên";
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
            // gbxInformation
            // 
            this.gbxInformation.Controls.Add(this.lblTimer);
            this.gbxInformation.Controls.Add(this.lblUserID);
            this.gbxInformation.Controls.Add(this.lblName);
            this.gbxInformation.Controls.Add(this.txtUserID);
            this.gbxInformation.Controls.Add(this.txtName);
            this.gbxInformation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInformation.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.gbxInformation.Location = new System.Drawing.Point(12, 12);
            this.gbxInformation.Name = "gbxInformation";
            this.gbxInformation.Size = new System.Drawing.Size(776, 105);
            this.gbxInformation.TabIndex = 5;
            this.gbxInformation.TabStop = false;
            this.gbxInformation.Text = "THÔNG TIN";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTimer.Location = new System.Drawing.Point(682, 40);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(88, 37);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "15:00";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblQuestion.Location = new System.Drawing.Point(6, 42);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(760, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(87, 25);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Câu hỏi?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(694, 461);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 35);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(735, 461);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 35);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gbxAskAnswer
            // 
            this.gbxAskAnswer.Controls.Add(this.lblAnswer4);
            this.gbxAskAnswer.Controls.Add(this.lblAnswer3);
            this.gbxAskAnswer.Controls.Add(this.lblAnswer2);
            this.gbxAskAnswer.Controls.Add(this.lblAnswer1);
            this.gbxAskAnswer.Controls.Add(this.picImage);
            this.gbxAskAnswer.Controls.Add(this.btnSubmit);
            this.gbxAskAnswer.Controls.Add(this.cbxAnswer4);
            this.gbxAskAnswer.Controls.Add(this.cbxAnswer3);
            this.gbxAskAnswer.Controls.Add(this.cbxAnswer2);
            this.gbxAskAnswer.Controls.Add(this.cbxAnswer1);
            this.gbxAskAnswer.Controls.Add(this.btnNext);
            this.gbxAskAnswer.Controls.Add(this.btnPrevious);
            this.gbxAskAnswer.Controls.Add(this.lblQuestion);
            this.gbxAskAnswer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAskAnswer.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.gbxAskAnswer.Location = new System.Drawing.Point(12, 123);
            this.gbxAskAnswer.Name = "gbxAskAnswer";
            this.gbxAskAnswer.Size = new System.Drawing.Size(776, 500);
            this.gbxAskAnswer.TabIndex = 4;
            this.gbxAskAnswer.TabStop = false;
            this.gbxAskAnswer.Text = "CÂU HỎI";
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.AutoSize = true;
            this.lblAnswer4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer4.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer4.Location = new System.Drawing.Point(57, 374);
            this.lblAnswer4.MaximumSize = new System.Drawing.Size(740, 0);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(72, 21);
            this.lblAnswer4.TabIndex = 11;
            this.lblAnswer4.Text = "Đáp án 4";
            this.lblAnswer4.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer3.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer3.Location = new System.Drawing.Point(56, 288);
            this.lblAnswer3.MaximumSize = new System.Drawing.Size(740, 0);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(72, 21);
            this.lblAnswer3.TabIndex = 10;
            this.lblAnswer3.Text = "Đáp án 3";
            this.lblAnswer3.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer2.Location = new System.Drawing.Point(56, 202);
            this.lblAnswer2.MaximumSize = new System.Drawing.Size(740, 0);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(72, 21);
            this.lblAnswer2.TabIndex = 9;
            this.lblAnswer2.Text = "Đáp án 2";
            this.lblAnswer2.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer1.Location = new System.Drawing.Point(56, 116);
            this.lblAnswer1.MaximumSize = new System.Drawing.Size(740, 0);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(72, 21);
            this.lblAnswer1.TabIndex = 8;
            this.lblAnswer1.Text = "Đáp án 1";
            this.lblAnswer1.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // picImage
            // 
            this.picImage.Image = global::BTL_LTCSharp.Properties.Resources._150;
            this.picImage.Location = new System.Drawing.Point(187, 98);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(400, 200);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 7;
            this.picImage.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(317, 461);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 35);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "NỘP BÀI";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbxAnswer4
            // 
            this.cbxAnswer4.AutoSize = true;
            this.cbxAnswer4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnswer4.ForeColor = System.Drawing.Color.Black;
            this.cbxAnswer4.Location = new System.Drawing.Point(9, 365);
            this.cbxAnswer4.MaximumSize = new System.Drawing.Size(755, 0);
            this.cbxAnswer4.MinimumSize = new System.Drawing.Size(0, 40);
            this.cbxAnswer4.Name = "cbxAnswer4";
            this.cbxAnswer4.Size = new System.Drawing.Size(15, 40);
            this.cbxAnswer4.TabIndex = 5;
            this.cbxAnswer4.UseVisualStyleBackColor = true;
            this.cbxAnswer4.Click += new System.EventHandler(this.cbxAnswer_Click);
            // 
            // cbxAnswer3
            // 
            this.cbxAnswer3.AutoSize = true;
            this.cbxAnswer3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnswer3.ForeColor = System.Drawing.Color.Black;
            this.cbxAnswer3.Location = new System.Drawing.Point(9, 279);
            this.cbxAnswer3.MaximumSize = new System.Drawing.Size(755, 0);
            this.cbxAnswer3.MinimumSize = new System.Drawing.Size(0, 40);
            this.cbxAnswer3.Name = "cbxAnswer3";
            this.cbxAnswer3.Size = new System.Drawing.Size(15, 40);
            this.cbxAnswer3.TabIndex = 5;
            this.cbxAnswer3.UseVisualStyleBackColor = true;
            this.cbxAnswer3.Click += new System.EventHandler(this.cbxAnswer_Click);
            // 
            // cbxAnswer2
            // 
            this.cbxAnswer2.AutoSize = true;
            this.cbxAnswer2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnswer2.ForeColor = System.Drawing.Color.Black;
            this.cbxAnswer2.Location = new System.Drawing.Point(9, 193);
            this.cbxAnswer2.MaximumSize = new System.Drawing.Size(755, 0);
            this.cbxAnswer2.MinimumSize = new System.Drawing.Size(0, 40);
            this.cbxAnswer2.Name = "cbxAnswer2";
            this.cbxAnswer2.Size = new System.Drawing.Size(15, 40);
            this.cbxAnswer2.TabIndex = 5;
            this.cbxAnswer2.UseVisualStyleBackColor = true;
            this.cbxAnswer2.Click += new System.EventHandler(this.cbxAnswer_Click);
            // 
            // cbxAnswer1
            // 
            this.cbxAnswer1.AutoSize = true;
            this.cbxAnswer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnswer1.ForeColor = System.Drawing.Color.Black;
            this.cbxAnswer1.Location = new System.Drawing.Point(9, 107);
            this.cbxAnswer1.MaximumSize = new System.Drawing.Size(755, 0);
            this.cbxAnswer1.MinimumSize = new System.Drawing.Size(0, 40);
            this.cbxAnswer1.Name = "cbxAnswer1";
            this.cbxAnswer1.Size = new System.Drawing.Size(15, 40);
            this.cbxAnswer1.TabIndex = 5;
            this.cbxAnswer1.UseVisualStyleBackColor = true;
            this.cbxAnswer1.Click += new System.EventHandler(this.cbxAnswer_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.gbxInformation);
            this.Controls.Add(this.gbxAskAnswer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExamination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LUYỆN THI TRẮC NGHIỆM BẰNG LÁI XE A1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExamination_FormClosing);
            this.gbxInformation.ResumeLayout(false);
            this.gbxInformation.PerformLayout();
            this.gbxAskAnswer.ResumeLayout(false);
            this.gbxAskAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.GroupBox gbxInformation;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox gbxAskAnswer;
        private System.Windows.Forms.CheckBox cbxAnswer1;
        private System.Windows.Forms.CheckBox cbxAnswer3;
        private System.Windows.Forms.CheckBox cbxAnswer2;
        private System.Windows.Forms.CheckBox cbxAnswer4;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer1;
    }
}