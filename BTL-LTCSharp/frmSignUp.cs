﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTCSharp
{
    public partial class frmSignUp : Form
    {
        public frmLogin loginForm;

        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            if(InputValid())
            {
                string sql = "Insert into TaiKhoan values('" + txtUsername.Text + "', '" + txtPassword.Text + "', 0)";
                DatabaseManager.executeQuery(sql);
                sql = "Select COUNT(*) from ThiSinh";
                int IDindex = Convert.ToInt32(DatabaseManager.executeQuery(sql).Rows[0][0]) + 1;
                string maThiSinh = "TS" + Convert.ToString(IDindex).PadLeft(3, '0');
                sql = "Insert into ThiSinh values('" + maThiSinh + "', N'" + txtFullName.Text + "', '" + cbxYear.Text + cbxMonth.Text + cbxDay.Text + "', '"
                                                        + (cbxSex.Text.Equals("Nam") ? "M" : "F") + "', N'" + txtAddress.Text + "', '" + txtUsername.Text + "')";
                DatabaseManager.executeQuery(sql);
                MessageBox.Show("Chúc mừng!!\nBạn đã đăng ký thành công!!", "Đăng ký thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (UsernameValid())
            {
                MessageBox.Show("Bạn có thể dùng tên đăng nhập này!!", "Tên đăng nhập hơp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool UsernameValid()
        {
            if (!txtUsername.Text.Equals(""))
            {
                string sql = "Select Username" +
                            " from TaiKhoan" +
                            " where Username = '" + txtUsername.Text + "'";
                if (DatabaseManager.executeQuery(sql).Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!!\nMời bạn nhập tên đăng nhập khác!", "Tồn tại tên đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!!\nMời bạn nhập tên đăng nhập!", "Lỗi nhập tên đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
        }

        bool PasswordValid()
        {
            if (!txtPassword.Text.Equals("") && !txtPassword.Text.Equals(txtPasswordAgain.Text))
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp\nMời bạn nhập lại mật khẩu!", "Lỗi nhập mật khẩu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        bool InputValid()
        {
            int day, month, year;
            bool isDay = !cbxDay.Text.Equals("") && int.TryParse(cbxDay.Text, out day);
            bool isMonth = !cbxMonth.Text.Equals("") && int.TryParse(cbxMonth.Text, out month);
            bool isYear = !cbxYear.Text.Equals("") && int.TryParse(cbxYear.Text, out year);
            bool isSex = (!cbxSex.Text.Equals("") && (Convert.ToString(cbxSex.Text).Equals("Nam") || Convert.ToString(cbxSex.Text).Equals("Nữ"))) ? true : false;
            bool isFullName = !txtFullName.Equals("");
            
            if(UsernameValid())
            {
                if (PasswordValid())
                {
                    if (isFullName)
                    {
                        if (isSex)
                        {
                            if (isDay)
                            {
                                if (isMonth)
                                {
                                    if (isYear)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Lỗi năm không hợp lệ!\nMời bạn chọn lại!", "Lỗi nhập không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Lỗi tháng không hợp lệ!\nMời bạn chọn lại!", "Lỗi nhập không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Lỗi ngày không hợp lệ!\nMời bạn chọn lại!", "Lỗi nhập không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lỗi giới tính không hợp lệ!\nMời bạn chọn lại!", "Lỗi nhập không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi tên không hợp lệ!\nMời bạn nhập lại!", "Lỗi nhập không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            return false;
        }
    }
}