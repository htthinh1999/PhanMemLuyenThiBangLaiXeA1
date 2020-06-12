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
    }
}
