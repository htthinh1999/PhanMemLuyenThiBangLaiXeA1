using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTCSharp
{
    public partial class frmExamination : Form
    {
        public frmCustomer customerForm;

        Dictionary<int, string> question = new Dictionary<int, string>();
        Dictionary<int, string> imageOfquestion = new Dictionary<int, string>();
        Dictionary<int, List<string>> answer = new Dictionary<int, List<string>>();

        int timeCountDown = 900;    // 15 minutes = 900 seconds
        int maxQuestionIndex = 150;
        int questionIndex = 1;

        public frmExamination()
        {
            InitializeComponent();
            Init();
        }
        private void frmExamination_Load(object sender, EventArgs e)
        {
            ShowInformation();
        }

        void ShowInformation()
        {
            string sql = "Select MaThiSinh, HoTenThiSinh from ThiSinh where Username = '" + DatabaseManager.username + "'";
            DataTable dataTable = DatabaseManager.executeQuery(sql);
            txtUserID.Text = Convert.ToString(dataTable.Rows[0]["MaThiSinh"]);
            txtName.Text = Convert.ToString(dataTable.Rows[0]["HoTenThiSinh"]);
        }

        void Init()
        {
            GetQuestionFromDB();
            GetAnswerFromDB();
            ShowQuestionAndAnswer(questionIndex);
        }

        void GetQuestionFromDB()
        {
            string sql = "Select MaCauHoi, NDCauHoi, Hinh from CauHoi";
            DataTable dataQuestion = DatabaseManager.executeQuery(sql);
            foreach (DataRow row in dataQuestion.Rows)
            {
                question.Add(Convert.ToInt32(row["MaCauHoi"]), Convert.ToString(row["NDCauHoi"]));
                imageOfquestion.Add(Convert.ToInt32(row["MaCauHoi"]), Convert.ToString(row["Hinh"]));
            }
        }

        void GetAnswerFromDB()
        {
            string sql = "Select MaCauHoi, NDCauTraLoi from DapAn";
            DataTable dataAnswer = DatabaseManager.executeQuery(sql);
            foreach (DataRow row in dataAnswer.Rows)
            {
                int maCauHoi = Convert.ToInt32(row["MaCauHoi"]);
                if (!answer.ContainsKey(maCauHoi))
                {
                    List<string> answersOfQuestion = new List<string>();
                    answer.Add(maCauHoi, answersOfQuestion);
                }
                answer[maCauHoi].Add(Convert.ToString(row["NDCauTraLoi"]));
            }
        }

        void ShowQuestionAndAnswer(int questionID)
        {
            gbxAskAnswer.Text = "CÂU HỎI " + questionIndex;
            lblQuestion.Text = question[questionID];
            int answerIndex = 0;
            if (!imageOfquestion[questionID].Equals(""))
            {
                picImage.Image = new Bitmap((Bitmap)Properties.Resources.ResourceManager.GetObject(imageOfquestion[questionID]));
                picImage.Location = new Point(picImage.Location.X, lblQuestion.Location.Y + lblQuestion.Height + 10);
                picImage.Show();
            }
            else
            {
                picImage.Hide();
            }
            foreach (CheckBox cbxAnswer in gbxAskAnswer.Controls.OfType<CheckBox>())
            {
                cbxAnswer.Checked = false;
                if(answerIndex >= answer[questionID].Count) { cbxAnswer.Hide(); continue; }
                cbxAnswer.Show();
                cbxAnswer.Text = answer[questionID][answerIndex];
                Console.WriteLine(cbxAnswer.Text);
                cbxAnswer.Location = new Point(lblQuestion.Location.X, (picImage.Visible)? picImage.Location.Y + picImage.Height + answerIndex * 35 : lblQuestion.Location.Y + lblQuestion.Height + answerIndex * 70 + 20);
                answerIndex++;
            }
        }

        void GetAnswersFromUser()
        {
            foreach(CheckBox cbx in gbxAskAnswer.Controls.OfType<CheckBox>())
            {
                if(cbx.Text.Equals("1.05 năm."))
                {
                    MessageBox.Show("OK");
                    break;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            questionIndex = Math.Max(1, --questionIndex);
            ShowQuestionAndAnswer(questionIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            questionIndex = Math.Min(maxQuestionIndex, ++questionIndex);
            ShowQuestionAndAnswer(questionIndex);
        }

        private void frmExamination_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát cuộc thi chứ?", "Thoát cuộc thi?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                customerForm.Show();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeCountDown > 0)
            {
                timeCountDown--;
                TimeSpan time = TimeSpan.FromSeconds(timeCountDown);
                lblTimer.Text = time.ToString(@"mm\:ss");
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Phần thi đã hết giờ!", "Hết giờ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
