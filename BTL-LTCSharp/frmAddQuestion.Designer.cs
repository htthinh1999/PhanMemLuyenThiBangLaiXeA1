namespace BTL_LTCSharp
{
    partial class frmAddQuestion
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.txtAnswer4 = new System.Windows.Forms.TextBox();
            this.cbxAnwer1 = new System.Windows.Forms.CheckBox();
            this.cbxAnwer2 = new System.Windows.Forms.CheckBox();
            this.cbxAnwer3 = new System.Windows.Forms.CheckBox();
            this.cbxAnwer4 = new System.Windows.Forms.CheckBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoQuestionType3 = new System.Windows.Forms.RadioButton();
            this.rdoQuestionType2 = new System.Windows.Forms.RadioButton();
            this.rdoQuestionType1 = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtQuestion.Location = new System.Drawing.Point(32, 105);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(569, 30);
            this.txtQuestion.TabIndex = 0;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblQuestion.Location = new System.Drawing.Point(29, 85);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(55, 17);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Câu hỏi";
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblAnswer1.Location = new System.Drawing.Point(29, 368);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(63, 17);
            this.lblAnswer1.TabIndex = 3;
            this.lblAnswer1.Text = "Đáp án 1";
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtAnswer1.Location = new System.Drawing.Point(32, 388);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(492, 30);
            this.txtAnswer1.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 23.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblTitle.Location = new System.Drawing.Point(160, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 45);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "THÊM CÂU HỎI";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAddQuestion.FlatAppearance.BorderSize = 0;
            this.btnAddQuestion.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestion.Location = new System.Drawing.Point(165, 602);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(250, 40);
            this.btnAddQuestion.TabIndex = 5;
            this.btnAddQuestion.Text = "THÊM CÂU HỎI";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblAnswer2.Location = new System.Drawing.Point(29, 421);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(63, 17);
            this.lblAnswer2.TabIndex = 7;
            this.lblAnswer2.Text = "Đáp án 2";
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtAnswer2.Location = new System.Drawing.Point(32, 441);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(492, 30);
            this.txtAnswer2.TabIndex = 6;
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblAnswer3.Location = new System.Drawing.Point(29, 474);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(63, 17);
            this.lblAnswer3.TabIndex = 11;
            this.lblAnswer3.Text = "Đáp án 3";
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtAnswer3.Location = new System.Drawing.Point(32, 494);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(492, 30);
            this.txtAnswer3.TabIndex = 10;
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.AutoSize = true;
            this.lblAnswer4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer4.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblAnswer4.Location = new System.Drawing.Point(29, 527);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(63, 17);
            this.lblAnswer4.TabIndex = 13;
            this.lblAnswer4.Text = "Đáp án 4";
            // 
            // txtAnswer4
            // 
            this.txtAnswer4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtAnswer4.Location = new System.Drawing.Point(32, 547);
            this.txtAnswer4.Name = "txtAnswer4";
            this.txtAnswer4.Size = new System.Drawing.Size(492, 30);
            this.txtAnswer4.TabIndex = 12;
            // 
            // cbxAnwer1
            // 
            this.cbxAnwer1.AutoSize = true;
            this.cbxAnwer1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnwer1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.cbxAnwer1.Location = new System.Drawing.Point(530, 390);
            this.cbxAnwer1.Name = "cbxAnwer1";
            this.cbxAnwer1.Size = new System.Drawing.Size(71, 27);
            this.cbxAnwer1.TabIndex = 14;
            this.cbxAnwer1.Text = "Đúng";
            this.cbxAnwer1.UseVisualStyleBackColor = true;
            // 
            // cbxAnwer2
            // 
            this.cbxAnwer2.AutoSize = true;
            this.cbxAnwer2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnwer2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.cbxAnwer2.Location = new System.Drawing.Point(530, 443);
            this.cbxAnwer2.Name = "cbxAnwer2";
            this.cbxAnwer2.Size = new System.Drawing.Size(71, 27);
            this.cbxAnwer2.TabIndex = 15;
            this.cbxAnwer2.Text = "Đúng";
            this.cbxAnwer2.UseVisualStyleBackColor = true;
            // 
            // cbxAnwer3
            // 
            this.cbxAnwer3.AutoSize = true;
            this.cbxAnwer3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnwer3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.cbxAnwer3.Location = new System.Drawing.Point(530, 496);
            this.cbxAnwer3.Name = "cbxAnwer3";
            this.cbxAnwer3.Size = new System.Drawing.Size(71, 27);
            this.cbxAnwer3.TabIndex = 16;
            this.cbxAnwer3.Text = "Đúng";
            this.cbxAnwer3.UseVisualStyleBackColor = true;
            // 
            // cbxAnwer4
            // 
            this.cbxAnwer4.AutoSize = true;
            this.cbxAnwer4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnwer4.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.cbxAnwer4.Location = new System.Drawing.Point(530, 549);
            this.cbxAnwer4.Name = "cbxAnwer4";
            this.cbxAnwer4.Size = new System.Drawing.Size(71, 27);
            this.cbxAnwer4.TabIndex = 17;
            this.cbxAnwer4.Text = "Đúng";
            this.cbxAnwer4.UseVisualStyleBackColor = true;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Image = global::BTL_LTCSharp.Properties.Resources.open_picture;
            this.picImage.Location = new System.Drawing.Point(32, 154);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(350, 200);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 18;
            this.picImage.TabStop = false;
            this.picImage.Tag = "not_opened";
            this.picImage.Click += new System.EventHandler(this.OpenImage);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoQuestionType3);
            this.groupBox1.Controls.Add(this.rdoQuestionType2);
            this.groupBox1.Controls.Add(this.rdoQuestionType1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Location = new System.Drawing.Point(388, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 200);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại câu hỏi";
            // 
            // rdoQuestionType3
            // 
            this.rdoQuestionType3.AutoSize = true;
            this.rdoQuestionType3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoQuestionType3.Location = new System.Drawing.Point(6, 135);
            this.rdoQuestionType3.Name = "rdoQuestionType3";
            this.rdoQuestionType3.Size = new System.Drawing.Size(85, 27);
            this.rdoQuestionType3.TabIndex = 24;
            this.rdoQuestionType3.TabStop = true;
            this.rdoQuestionType3.Text = "Sa hình";
            this.rdoQuestionType3.UseVisualStyleBackColor = true;
            // 
            // rdoQuestionType2
            // 
            this.rdoQuestionType2.AutoSize = true;
            this.rdoQuestionType2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoQuestionType2.Location = new System.Drawing.Point(6, 87);
            this.rdoQuestionType2.Name = "rdoQuestionType2";
            this.rdoQuestionType2.Size = new System.Drawing.Size(95, 27);
            this.rdoQuestionType2.TabIndex = 23;
            this.rdoQuestionType2.TabStop = true;
            this.rdoQuestionType2.Text = "Biển báo";
            this.rdoQuestionType2.UseVisualStyleBackColor = true;
            // 
            // rdoQuestionType1
            // 
            this.rdoQuestionType1.AutoSize = true;
            this.rdoQuestionType1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoQuestionType1.Location = new System.Drawing.Point(6, 42);
            this.rdoQuestionType1.Name = "rdoQuestionType1";
            this.rdoQuestionType1.Size = new System.Drawing.Size(194, 27);
            this.rdoQuestionType1.TabIndex = 22;
            this.rdoQuestionType1.TabStop = true;
            this.rdoQuestionType1.Text = "Giao thông đường bộ";
            this.rdoQuestionType1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // frmAddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 654);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.cbxAnwer4);
            this.Controls.Add(this.cbxAnwer3);
            this.Controls.Add(this.cbxAnwer2);
            this.Controls.Add(this.cbxAnwer1);
            this.Controls.Add(this.lblAnswer4);
            this.Controls.Add(this.txtAnswer4);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtQuestion);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM CÂU HỎI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddQuestion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.CheckBox cbxAnwer1;
        private System.Windows.Forms.CheckBox cbxAnwer2;
        private System.Windows.Forms.CheckBox cbxAnwer3;
        private System.Windows.Forms.CheckBox cbxAnwer4;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoQuestionType3;
        private System.Windows.Forms.RadioButton rdoQuestionType2;
        private System.Windows.Forms.RadioButton rdoQuestionType1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}