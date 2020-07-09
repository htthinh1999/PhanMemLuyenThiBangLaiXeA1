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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void picExamination_Click(object sender, EventArgs e)
        {
            frmExamination examinationForm = new frmExamination();
            examinationForm.userForm = this;
            examinationForm.Show();
            this.Hide();
        }

        private void picHistory_Click(object sender, EventArgs e)
        {
            frmInformationAndHistory informationAndHistoryForm = new frmInformationAndHistory();
            informationAndHistoryForm.userForm = this;
            informationAndHistoryForm.Show();
            this.Hide();
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình chứ?", "Thoát chương trình?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
