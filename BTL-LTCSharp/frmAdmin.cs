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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void picAddQuestionAnswer_Click(object sender, EventArgs e)
        {
            frmAddQuestion addQuestionForm = new frmAddQuestion();
            addQuestionForm.adminForm = this;
            addQuestionForm.Show();
            this.Hide();
        }

        private void picAllResult_Click(object sender, EventArgs e)
        {
            frmAllInformation allInformationForm = new frmAllInformation();
            allInformationForm.adminForm = this;
            allInformationForm.Show();
            this.Hide();
        }
    }
}
