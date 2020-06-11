using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        void Login()
        {
            string sql = "Select * from TaiKhoan where Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'";
            DataTable dataLogin = DatabaseManager.executeQuery(sql);
            if (dataLogin.Rows.Count != 0)
            {
                if (Convert.ToInt32(dataLogin.Rows[0]["IsAdmin"]) == 0)
                {
                    frmCustomer customerForm = new frmCustomer();
                    customerForm.Show();
                }
                else
                {
                    frmAdmin adminForm = new frmAdmin();
                    adminForm.Show();
                }
                DatabaseManager.username = txtUsername.Text;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tên đăng nhập hoặc mật khẩu!!\nMời bạn nhập lại!!", "Đăng nhập sai!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp signUp = new frmSignUp();
            signUp.loginForm = this;
            signUp.Show();
            this.Hide();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình chứ?", "Thoát chương trình?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
