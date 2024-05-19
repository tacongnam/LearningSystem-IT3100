using Learning_System.Modals;
using Learning_System.ProcessingClasses;
using Learning_System.Properties;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Learning_System
{
    public partial class ContestForm : Form
    {
        public DateTime timeStart;
        public EditQuiz editQuiz;
        public string nameContest;
        public int timeLimit;
        public bool TimeLimitEnable;

        public ContestForm()
        {
            InitializeComponent();

            timeStart = DateTime.Now;

            ContestID = Settings.Default.ChoosingContest;

            DataProcessing questionsData = QuestionsTable.table;
            DataProcessing categoriesData = CategoriesTable.table;

            loadQuestionData();
            loadCategoryData();

            editQuiz = new EditQuiz(this);
            panel_body.Controls.Add(editQuiz);
            editQuiz.Dock = DockStyle.Fill;

            editQuiz.addData(questionsData, categoriesData);
            loadContestData();
            editQuiz.addContestData(contestData);
            editQuiz.fromQuestionBank.addData(questionsData, categoriesData, _categoriesDataJarray);
            editQuiz.randomQuestion.addData(questionsData, categoriesData, _categoriesDataJarray);
        }

        private void ContestForm_EditPic_Click(object sender, EventArgs e)
        {
            panel_main.SendToBack();
            editQuiz.BringToFront();
            ContestForm_PathLbl.Text = "Home  /  My courses  /  THI CUỐI KỲ  /  General  /  " + nameContest + "  /  Edit quiz";
        }

        private JArray? _categoriesDataJarray = new();
        private DataProcessing contestData = ContestsTable.table;
        public int ContestID;

        private void loadQuestionData()
        {
            JArray? _questionsData = JsonProcessing.ImportJsonContentInDefaultFolder("Question.json", null, null);
            if (_questionsData == null)
                throw new E01CantFindFile();

            QuestionsTable.table.Import(_questionsData);
        }

        private void loadCategoryData()
        {
            _categoriesDataJarray = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
            if (_categoriesDataJarray == null)
                throw new E01CantFindFile();

            CategoriesTable.table.Import(_categoriesDataJarray);
        }

        private void loadContestData()
        {
            JArray? _contestData = JsonProcessing.ImportJsonContentInDefaultFolder("Contest.json", null, null);
            if (_contestData == null)
                throw new E01CantFindFile();

            ContestsTable.table.Import(_contestData);


            List<string> query = new() { "Id", ContestID.ToString() };
            DataRow? row = ContestsTable.table.Init().Offset(0).Limit(1).Query(query).GetFirstRow();
            nameContest = row.Field<string>("Name");

            ContestForm_ContestNameLbl.Text = nameContest;
            ContestForm_TimeLbl.Text = "Time limit: " + row.Field<int>("TimeLimit").ToString() + " minutes";
            timeLimit = row.Field<int>("TimeLimit");

            editQuiz.EditQuiz_ContestNameLbl.Text = "Editing quiz: " + nameContest;
            editQuiz.EditQuiz_ShuffleCbx.Checked = row.Field<bool>("ShuffleAnswer");

            if (row.Field<double>("MaximumGrade").ToString() == null || row.Field<double>("MaximumGrade").ToString() == "")
                editQuiz.EditQuiz_MaxGradeTxt.Text = "10.00";
            else editQuiz.EditQuiz_MaxGradeTxt.Text = row.Field<double>("MaximumGrade").ToString();
            ContestForm_PathLbl.Text = "Home  /  My courses  /  THI CUỐI KỲ  /  General  /  " + nameContest;
            var x = row.Field<JArray>("QuestionArray").ToObject<List<int>>();
            if (row.Field<bool>("TimeLimitEnable") == false)
            {
                ContestForm_TimeLbl.Visible = false;
                TimeLimitEnable = false;
            }
            else
            {
                TimeLimitEnable = true;
            }
            editQuiz.loadQuestionID(x);
        }

        public void saveContestData(DataProcessing contestData, List<int> questionID)
        {
            if (JsonProcessing.ExportJsonContentInDefaultFolder("Contest.json", contestData.Export()) == null)
                throw new E04CantExportProperly();
            this.contestData = contestData;
            editQuiz.loadQuestionID(questionID);
        }

        public void updateContestData(DataProcessing contestData)
        {
            this.contestData = contestData;
        }

        private void ContestForm_PreviewQuizBtn_Click(object sender, EventArgs e)
        {
            if (editQuiz.questionID.Count == 0)
            {
                MessageBox.Show("Before previewing the quiz, you must add some questions");
            }
            else
            {
                this.Hide();
                StartAttemptForm startAttemptForm = new StartAttemptForm(this, editQuiz.questionID);
                startAttemptForm.ShowDialog();
                this.Show();
            }
        }

        private void ContestForm_MenuPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}