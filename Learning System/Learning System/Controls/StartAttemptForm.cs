using Learning_System.Modals;
using Learning_System.ProcessingClasses;

namespace Learning_System
{
    public partial class StartAttemptForm : Form
    {
        private ContestForm contestForm;
        private int timeLimit;
        private DataProcessing questionsData;
        private List<int> questionID;
        private string nameContest;
        public StartAttemptForm(ContestForm contestForm, List<int> questionID)
        {
            InitializeComponent();
            this.contestForm = contestForm;
            timeLimit = contestForm.timeLimit;
            questionsData = QuestionsTable.table;
            this.questionID = questionID;
            nameContest = contestForm.nameContest;
            if (contestForm.TimeLimitEnable == true)
            {
                NotiTxt.Text = $"Your attempt will have a time limit of {timeLimit} minutes. When you start, the timer will begin to count down and cannot be paused. You must finish your attempt before it expires. Are you sure you wish to start now?";
            }
            else
            {
                TimeLbl.Text = "";
                NotiTxt.Text = "Are you sure you wish to start now?";
            }
        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            PreviewQuizForm previewQuizForm = new PreviewQuizForm(contestForm, questionID);
            previewQuizForm.ShowDialog();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            ExportQuizForm exportQuizForm = new ExportQuizForm(questionID);
            exportQuizForm.ShowDialog();
        }
    }
}
