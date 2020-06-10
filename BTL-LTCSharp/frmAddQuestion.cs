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
    public partial class frmAddQuestion : Form
    {
        public frmAdmin adminForm;

        public frmAddQuestion()
        {
            InitializeComponent();
        }

        private void frmAddQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminForm.Show();
        }
    }
}
