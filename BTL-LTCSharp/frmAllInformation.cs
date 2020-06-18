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
    public partial class frmAllInformation : Form
    {
        public frmAdmin adminForm;

        public frmAllInformation()
        {
            InitializeComponent();
        }

        private void frmAllInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminForm.Show();
        }

        private void frmAllInformation_Load(object sender, EventArgs e)
        {
            ShowInformation();
            ShowHistory();
        }

        void ShowInformation()
        {
            string sql = "Select MaThiSinh AS N'Mã Thí Sinh', HoTenThiSinh AS N'Họ Tên', CONVERT(VARCHAR(10), NgaySinh, 103) AS N'Ngày Sinh', GioiTinh AS N'Giới Tính', DiaChi AS N'Địa Chỉ' from ThiSinh";
            dataInformation.DataSource = DatabaseManager.executeQuery(sql);

            dataInformation.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
            foreach (DataGridViewColumn column in dataInformation.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Font = new Font("Segoe UI", 12.75F);
                column.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        void ShowHistory()
        {
            string sql = "Select T.MaThiSinh AS N'Mã Thí Sinh', HoTenThiSinh AS N'Họ Tên', LanThi AS N'Lần Thi', ThoiGian AS N'Thời Gian', KetQua AS N'Kết Quả'" +
                            " from KetQua K inner join ThiSinh T on K.MaThiSinh = T.MaThiSinh order by T.MaThiSinh, LanThi";
            dataHistory.DataSource = DatabaseManager.executeQuery(sql);

            dataHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
            foreach (DataGridViewColumn column in dataHistory.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Font = new Font("Segoe UI", 12.75F);
                column.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}
