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
    public partial class frmHistory : Form
    {
        public frmCustomer customerForm;
     
        public frmHistory()
        {
            InitializeComponent();
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            ShowInformation();
            ShowHistory();
        }

        void ShowInformation()
        {
            foreach(ComboBox cbxInfor in gbxInformation.Controls.OfType<ComboBox>())
            {
                cbxInfor.Hide();
            }

            string sql = "Select MaThiSinh, HoTenThiSinh, CONVERT(VARCHAR(10), NgaySinh, 103) AS 'NgaySinh', GioiTinh, DiaChi" +
                            " from ThiSinh" +
                            " where Username = '" + DatabaseManager.username + "'";
            DataTable dataTable = DatabaseManager.executeQuery(sql);
            txtUserID.Text = Convert.ToString(dataTable.Rows[0]["MaThiSinh"]);
            txtName.Text = Convert.ToString(dataTable.Rows[0]["HoTenThiSinh"]);
            txtSex.Text = Convert.ToString(dataTable.Rows[0]["GioiTinh"]).Equals("M") ? "Nam" : "Nữ";
            txtBornDate.Text = Convert.ToString(dataTable.Rows[0]["NgaySinh"]);
            txtAddress.Text = Convert.ToString(dataTable.Rows[0]["DiaChi"]);
        }

        void ShowHistory()
        {
            string sql = "Select LanThi AS N'Lần Thi', ThoiGian AS N'Thời Gian', KetQua AS N'Kết Quả'" +
                            " from KetQua K inner join ThiSinh T on K.MaThiSinh = T.MaThiSinh" +
                            " where Username = '" + DatabaseManager.username + "'";
            dataHistory.DataSource = DatabaseManager.executeQuery(sql);

            dataHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
            foreach (DataGridViewColumn column in dataHistory.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Font = new Font("Segoe UI", 12.75F);
                column.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void frmHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            customerForm.Show();
        }

        private void btnUpdateInformation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals("SỬA THÔNG TIN"))
            {
                btn.Text = "CẬP NHẬT THÔNG TIN";

                txtSex.Hide();
                txtBornDate.Hide();
                foreach (TextBox textbox in gbxInformation.Controls.OfType<TextBox>())
                {
                    if (textbox != txtUserID)
                    {
                        textbox.ReadOnly = false;
                    }
                }
                foreach (ComboBox cbxInfor in gbxInformation.Controls.OfType<ComboBox>())
                {
                    cbxInfor.Show();
                }

                string sql = "Select CONVERT(VARCHAR(10), NgaySinh, 103) AS 'NgaySinh', GioiTinh" +
                            " from ThiSinh" +
                            " where Username = '" + DatabaseManager.username + "'";
                DataTable data = DatabaseManager.executeQuery(sql);
                string dateBorn = data.Rows[0]["NgaySinh"].ToString();
                string sex = data.Rows[0]["GioiTinh"].ToString();
                Console.WriteLine(sex);
                cbxSex.Text = (sex.Equals("M")) ? "Nam" : "Nữ";
                cbxDay.Text = dateBorn.Substring(0, 2);
                cbxMonth.Text = dateBorn.Substring(3, 2);
                cbxYear.Text = dateBorn.Substring(6, 4);
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn thay đổi thông tin?", "Xác nhận thay đổi thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btn.Text = "SỬA THÔNG TIN";

                    txtSex.Show();
                    txtBornDate.Show();
                    foreach (TextBox textbox in gbxInformation.Controls.OfType<TextBox>())
                    {
                        if (textbox != txtUserID)
                        {
                            textbox.ReadOnly = true;
                        }
                    }
                    foreach (ComboBox cbxInfor in gbxInformation.Controls.OfType<ComboBox>())
                    {
                        cbxInfor.Hide();
                    }

                    string sql = "prc_SuaThongTinThiSinh '" + DatabaseManager.username + "', N'" + txtName.Text + "'," +
                        " '" + cbxYear.Text + cbxMonth.Text + cbxDay.Text + "', '" + (cbxSex.Text.Equals("Nam") ? "M" : "F") + "', N'" + txtAddress.Text + "'";
                    Console.WriteLine(sql);
                    DatabaseManager.executeQuery(sql);
                    ShowInformation();
                    MessageBox.Show("Chỉnh sửa thông tin thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!txtOldPassword.Text.Equals(""))
            {
                if (!txtNewPassword.Text.Equals(""))
                {
                    if (!txtConfirmNewPassword.Text.Equals(""))
                    {
                        if (txtConfirmNewPassword.Text.Equals(txtNewPassword.Text))
                        {
                            string sql = "select * from TaiKhoan where Username='" + DatabaseManager.username + "' AND Password='" + txtOldPassword.Text + "'";
                            if (DatabaseManager.executeQuery(sql).Rows.Count != 0)
                            {
                                if (!txtOldPassword.Text.Equals(txtNewPassword.Text))
                                {
                                    if (MessageBox.Show("Bạn có muốn đổi mật khẩu?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        sql = "prc_SuaMatKhau '" + DatabaseManager.username + "', '" + txtNewPassword.Text + "'";
                                        DatabaseManager.executeQuery(sql);
                                        MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtOldPassword.Clear();
                                        txtNewPassword.Clear();
                                        txtConfirmNewPassword.Clear();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu hiện tại!", "Lỗi nhập sai!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtNewPassword.Clear();
                                    txtConfirmNewPassword.Clear();
                                    txtNewPassword.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nhập sai mật khẩu hiện tại!\nMời bạn nhập lại!", "Lỗi nhập sai!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtOldPassword.Clear();
                                txtOldPassword.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xác nhận mật khẩu và mật khẩu mới phải giống nhau!", "Lỗi nhập sai!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtConfirmNewPassword.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập xác nhận mật khẩu!", "Lỗi chưa nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtConfirmNewPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu mới!", "Lỗi chưa nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu hiện tại!", "Lỗi chưa nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPassword.Focus();
            }
        }
    }
}
