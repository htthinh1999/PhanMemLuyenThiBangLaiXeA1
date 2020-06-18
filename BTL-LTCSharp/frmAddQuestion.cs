using BTL_LTCSharp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTCSharp
{
    public partial class frmAddQuestion : Form
    {
        public frmAdmin adminForm;

        RadioButton[] rdoQuestionType;
        TextBox[] txtAnswer;
        CheckBox[] cbxAnswer;

        List<string> answersInsertToDB = new List<string>();
        List<bool> checkAnswersInsertToDB = new List<bool>();
        bool hasResult = false;
        int idQuestion;
        int questionType = 0;

        public frmAddQuestion()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            rdoQuestionType = new RadioButton[] { rdoQuestionType1, rdoQuestionType2, rdoQuestionType3 };
            txtAnswer = new TextBox[] { txtAnswer1, txtAnswer2, txtAnswer3, txtAnswer4 };
            cbxAnswer = new CheckBox[] { cbxAnwer1, cbxAnwer2, cbxAnwer3, cbxAnwer4 };
        }

        private void frmAddQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminForm.Show();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestionAndAnswersToDB();
        }

        void AddQuestionAndAnswersToDB()
        {
            for (int i = 0; i < 3; i++)
            {
                if (rdoQuestionType[i].Checked)
                {
                    questionType = i + 1;
                    break;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (!txtAnswer[i].Text.Equals(""))
                {
                    if (!answersInsertToDB.Contains(txtAnswer[i].Text))
                    {
                        answersInsertToDB.Add(txtAnswer[i].Text);
                        checkAnswersInsertToDB.Add(cbxAnswer[i].Checked);
                        if (cbxAnswer[i].Checked) { hasResult = true; }
                    }
                }
            }

            if (!txtQuestion.Text.Equals(""))
            {
                if(questionType != 0)
                {
                    if (answersInsertToDB.Count >= 2)
                    {
                        if (hasResult)
                        {
                            AddQuestionToDB();
                            AddAnswersToDB();
                            MessageBox.Show("Bạn đã thêm câu hỏi thành công!!", "Thêm thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetInput();
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa chọn câu trả lời đúng cho câu hỏi!", "Lỗi chưa chọn câu đúng!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng câu trả lời phải tối thiểu là 2!", "Lỗi chưa đủ câu trả lời!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAnswer2.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn loại câu hỏi!", "Lỗi chưa chọn loại câu hỏi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập câu hỏi!", "Lỗi chưa nhập câu hỏi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuestion.Focus();
            }

        }

        void AddQuestionToDB()
        {
            string sql = "Select COUNT(*) from CauHoi";
            idQuestion = int.Parse(DatabaseManager.executeQuery(sql).Rows[0][0].ToString()) + 1;

            if (questionType != 1)
            {
                if (picImage.Tag.Equals("opened"))
                {
                    sql = "Insert into CauHoi values('" + Convert.ToString(idQuestion).PadLeft(3, '0') + "'," +
                        " N'" + txtQuestion.Text + "', " + questionType + ", '" + idQuestion + "')";
                }
                else
                {
                    MessageBox.Show("Loại câu hỏi là '" + rdoQuestionType[questionType - 1].Text + "'!\nBạn cần phải có hình ảnh!!", "Lỗi chưa chọn ảnh!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OpenImage(picImage, EventArgs.Empty);
                }
                SaveImage();
            }
            else
            {
                sql = "Insert into CauHoi values('" + Convert.ToString(idQuestion).PadLeft(3, '0') + "'," +
                    " N'" + txtQuestion.Text + "', " + questionType + ", '')";
            }

            Console.WriteLine(sql);
            DatabaseManager.executeQuery(sql);


        }

        void AddAnswersToDB()
        {
            string sql = "Select COUNT(*) from DapAn";
            int answerID = int.Parse(DatabaseManager.executeQuery(sql).Rows[0][0].ToString()) + 1;

            for (int i = 0; i < answersInsertToDB.Count; i++)
            {
                sql = "Insert into DapAn values('" + (answerID + i) + "', N'" + answersInsertToDB[i] + "', '" + idQuestion + "', " + ((checkAnswersInsertToDB[i]) ? 1 : 0) + ")";
                Console.WriteLine(sql);
                DatabaseManager.executeQuery(sql);
            }

            answersInsertToDB.Clear();
            checkAnswersInsertToDB.Clear();
        }

        void OpenImage(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog()
            {
                Title = "Chọn ảnh cho câu hỏi!",
                Filter = "Image file|*.jpg;*.jpeg;*.bmp|jpg files|*.jpg|jpeg files|*.jpeg|bmp files|*.bmp"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                PictureBox pic = sender as PictureBox;
                pic.Tag = "opened";
                pic.Image = new Bitmap(fileName);
                pic.BackgroundImage = null;
            }
        }

        void SaveImage()
        {
            string directoryName = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory + "images\\");
            //Console.WriteLine(Path.Combine(directoryName, idQuestion + ".jpg"));
            picImage.Image.Save(Path.Combine(directoryName, idQuestion + ".jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        void ResetInput()
        {
            txtQuestion.Clear();
            for(int i=0; i<txtAnswer.Length; i++)
            {
                txtAnswer[i].Clear();
                cbxAnswer[i].Checked = false;
            }
        }

    }
}
