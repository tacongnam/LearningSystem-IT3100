using Learning_System.Modals;
using Learning_System.ProcessingClasses;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Learning_System
{
    public partial class EditQuiz : UserControl
    {
        public ContestForm parentContestForm;

        public RandomQuestion randomQuestion;
        public FromQuestionBank fromQuestionBank;

        public DataProcessing questionsData = new();
        public DataProcessing categoriesData = new();
        public DataProcessing contestData = new();
        public List<int> questionID = new();
        public EditQuiz(ContestForm parentContestForm)
        {
            InitializeComponent();
            randomQuestion = new RandomQuestion(this);
            fromQuestionBank = new FromQuestionBank(this);
            Controls.Add(randomQuestion);
            Controls.Add(fromQuestionBank);
            randomQuestion.Dock = DockStyle.Fill;
            fromQuestionBank.Dock = DockStyle.Fill;
            this.parentContestForm = parentContestForm;
            panel1.Width = Screen.PrimaryScreen.WorkingArea.Width;
        }
        public void addData(DataProcessing _questionData, DataProcessing _categoriesData)
        {
            questionsData = _questionData;
            categoriesData = _categoriesData;
        }
        public void addContestData(DataProcessing _contestData)
        {
            contestData = _contestData;
        }

        private void EditQuiz_AddBtn_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel_popup.Visible == false)
                flowLayoutPanel_popup.Visible = true;
            else flowLayoutPanel_popup.Visible = false;
        }

        private void EditQuiz_BankBtn_Click(object sender, EventArgs e)
        {
            panel_edit.SendToBack();
            fromQuestionBank.BringToFront();
            randomQuestion.SendToBack();
            flowLayoutPanel_popup.Visible = false;
        }

        private void EditQuiz_RandomBtn_Click(object sender, EventArgs e)
        {
            panel_edit.SendToBack();
            fromQuestionBank.SendToBack();
            randomQuestion.BringToFront();
            flowLayoutPanel_popup.Visible = false;
        }

        private void EditQuiz_SaveBtn_Click(object sender, EventArgs e)
        {
            List<string> query = new() { "Id", parentContestForm.ContestID.ToString() };
            DataRow row = contestData.Init().Offset(0).Limit(1).Query(query).GetFirstRow();
            row.Field<JArray>("QuestionArray").Clear();
            row.Field<JArray>("QuestionArray").Add(questionID);
            row.BeginEdit();
            row["ShuffleAnswer"] = EditQuiz_ShuffleCbx.Checked;
            row["MaximumGrade"] = Convert.ToDouble(EditQuiz_MaxGradeTxt.Text);
            row.EndEdit();
            JObject x = DataProcessing.ConvertDataRowToJObject(row);
            if (contestData.Init().Offset(0).Limit(1).Query(query).Update(x) == DataProcessing.StatusCode.Error)
                throw new Exception();
            parentContestForm.saveContestData(contestData, questionID);
            parentContestForm.ContestForm_PathLbl.Text = "Home  /  My courses  /  THI CUỐI KỲ  /  General  /  " + parentContestForm.nameContest;
            this.SendToBack();
        }

        public void loadQuestionID(List<int> selectedQuestions)
        {
            if (selectedQuestions.Count == 0) return;
            for (int i = 0; i < selectedQuestions.Count; i++)
            {
                if (!questionID.Contains(selectedQuestions[i]))
                    questionID.Add(selectedQuestions[i]);
            }
            loadDatagridview();
        }
        public void loadDatagridview()
        {
            if (questionID.Count == 0) return;
            EditQuiz_QuestionDtg.Rows.Clear();
            EditQuiz_QuestionDtg.Width = Screen.PrimaryScreen.WorkingArea.Width - 30;
            EditQuiz_QuestionDtg.Columns[0].Width = EditQuiz_QuestionDtg.Width - 51 - 150;
            EditQuiz_QuestionDtg.AutoGenerateColumns = false;
            EditQuiz_QuestionDtg.DefaultCellStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_QuestionDtg.RowTemplate.Height = 35;
            for (int i = 0; i < questionID.Count; i++)
            {
                List<string> query = new List<string> { "ID", questionID[i].ToString() };
                DataRow row = questionsData.Init().Offset(0).Limit(1).Query(query).GetFirstRow();
                var index = EditQuiz_QuestionDtg.Rows.Add();
                DataGridViewRow DtgRow = EditQuiz_QuestionDtg.Rows[index];
                using (RichTextBox tmp = new RichTextBox())
                {
                    try
                    {
                        tmp.Rtf = row.Field<string>("Content");
                    }
                    catch
                    {
                        tmp.Text = row.Field<string>("Content");
                    }
                    string content = tmp.Text;
                    DtgRow.Cells[0].Value = row.Field<string>("Name") + " " + content;
                }
                List<QuestionChoice> choices = row.Field<JArray>("Choice").ToObject<List<QuestionChoice>>();
                DtgRow.Cells[2].Value = row.Field<int>("ID");
                DtgRow.Cells[3].Value = row.Field<double>("DefaultMark");
                if (i % 2 == 0) DtgRow.DefaultCellStyle.BackColor = Color.White;
                else DtgRow.DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            EditQuiz_NumberofQuestionLbl.Text = $"Question: {questionID.Count} | This quiz is open";
            EditQuiz_TotalofMarkLbl.Text = $"Total of mark: {questionID.Count}.00";
        }

        private void AutoNumberInDtg(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4);
            }
        }

        private void EditQuiz_QuestionDtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EditQuiz_QuestionDtg.Columns[e.ColumnIndex].Name == "Delete")
            {
                questionID.Remove(Convert.ToInt32(EditQuiz_QuestionDtg.Rows[e.RowIndex].Cells[2].Value));
                EditQuiz_QuestionDtg.Rows.RemoveAt(e.RowIndex);
                loadDatagridview();
            }
        }

    }
}
