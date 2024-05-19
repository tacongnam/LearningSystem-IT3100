using Learning_System.Modals;
using Learning_System.ProcessingClasses;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Learning_System
{
    public partial class PreviewQuizForm : Form
    {
        private ContestForm contestForm;
        private double finalMark = 0;
        private bool finished = false;
        private int currentPage = 0;
        private int numberOfPage;
        private int numberOfQuestion;
        const int questionPerPage = 3;
        const int MAXQUESTION = 1000;
        private int timeLimit;
        private List<int> questionID;
        private DataProcessing questionsData;
        private Panel[] panel_Page = new Panel[MAXQUESTION];
        public Button[] button = new Button[MAXQUESTION * questionPerPage];
        private PageOfPreviewQuiz[] quiz = new PageOfPreviewQuiz[MAXQUESTION];

        public PreviewQuizForm(ContestForm contestForm, List<int> questionID)
        {
            InitializeComponent();
            panel_right.Width = 275;
            panel_left.Width = Screen.PrimaryScreen.WorkingArea.Width - panel_right.Width;
            panel_QuestionBtn.AutoScroll = true;
            this.contestForm = contestForm;
            this.timeLimit = contestForm.timeLimit;
            this.questionsData = QuestionsTable.table;
            this.questionID = questionID;
            PathLbl.Text += "  /  " + contestForm.nameContest + "  /  Preview";
            numberOfQuestion = questionID.Count;
            TimeLeftLbl.Text = contestForm.timeLimit.ToString() + " : 00";
            minute = contestForm.timeLimit;
            panel_time.Height -= panel_Review.Height;
            //
            DataRow[] dataRow = new DataRow[numberOfQuestion];
            for (int i = 0; i < numberOfQuestion; i++)
            {
                List<string> query = new() { "ID", questionID[i].ToString() };
                dataRow[i] = questionsData.Init().Offset(0).Limit(1).Query(query).GetFirstRow();
            }
            numberOfPage = Convert.ToInt32(Math.Ceiling((decimal)numberOfQuestion / questionPerPage));
            var x = numberOfQuestion / questionPerPage;
            for (int i = 0; i < x; i++)
            {
                panel_Page[i] = new Panel();
                panel_left.Controls.Add(panel_Page[i]);
                panel_Page[i].Dock = DockStyle.Fill;
                for (int j = 0; j < questionPerPage; j++)
                {
                    List<QuestionChoice> questionsChoices = new List<QuestionChoice>();
                    if (this.contestForm.editQuiz.EditQuiz_ShuffleCbx.Checked == false)
                        questionsChoices = dataRow[questionPerPage * i + j].Field<JArray>("Choice").ToObject<List<QuestionChoice>>();
                    else
                    {
                        questionsChoices = dataRow[questionPerPage * i + j].Field<JArray>("Choice").ToObject<List<QuestionChoice>>();
                        questionsChoices = this.shuffleList(questionsChoices);
                    }
                    var content = dataRow[questionPerPage * i + j].Field<string>("Content");
                    quiz[questionPerPage * i + j] = new PageOfPreviewQuiz(questionPerPage * i + j, questionsChoices, content, this);
                    quiz[questionPerPage * i + j].resize();
                    if (j == 0)
                    {
                        quiz[questionPerPage * i + j].Location = new Point(0, 0);
                    }
                    else
                    {
                        quiz[questionPerPage * i + j].Location = new Point(0, quiz[questionPerPage * i + j - 1].Height + quiz[questionPerPage * i + j - 1].Location.Y);
                    }
                    panel_Page[i].Controls.Add(quiz[questionPerPage * i + j]);
                }
                panel_Page[i].AutoScroll = true;
                panel_Page[i].AutoSize = true;
            }
            if (x < numberOfPage)
            {
                panel_Page[numberOfPage - 1] = new Panel();
                panel_left.Controls.Add(panel_Page[numberOfPage - 1]);
                panel_Page[numberOfPage - 1].Dock = DockStyle.Fill;
                panel_Page[numberOfPage - 1].AutoScroll = true;
                for (int j = questionPerPage * x; j < numberOfQuestion; j++)
                {
                    var questionsChoices = dataRow[j].Field<JArray>("Choice").ToObject<List<QuestionChoice>>();
                    var content = dataRow[j].Field<string>("Content");
                    quiz[j] = new PageOfPreviewQuiz(j, questionsChoices, content, this);
                    quiz[j].resize();
                    if (j == questionPerPage * x)
                    {
                        quiz[j].Location = new Point(0, 0);
                    }
                    else
                    {
                        quiz[j].Location = new Point(0, quiz[j - 1].Height + quiz[j - 1].Location.Y);
                    }
                    panel_Page[numberOfPage - 1].Controls.Add(quiz[j]);
                }
            }
            panel_Page[0].BringToFront();
            PreviousPageBtn.Visible = false;
            if (numberOfPage == 1)
            {
                NextPageBtn.Visible = false;
                panel_changePage.Visible = false;
            }
            //
            for (int i = 0; i < numberOfQuestion; i++)
            {
                button[i] = new Button();
                button[i].Anchor = AnchorStyles.Top | AnchorStyles.Left;
                button[i].BackColor = Color.FromArgb(0, 159, 229);
                button[i].FlatStyle = FlatStyle.Flat;
                button[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                button[i].ForeColor = Color.White;
                button[i].Location = new Point(15 + (i % 5) * 50, 5 + (i / 5) * 50);
                button[i].Size = new Size(45, 45);
                button[i].Text = (i + 1).ToString();
                button[i].UseVisualStyleBackColor = false;
                button[i].Click += pageButtonClick;
                panel_QuestionBtn.Controls.Add(button[i]);
            }
            FinishLbl.Location = new Point(FinishLbl.Location.X, button[numberOfQuestion - 1].Location.Y
                + button[numberOfQuestion - 1].Height + 10);
            if (contestForm.TimeLimitEnable == true)
            {
                countDownTimer.Start();
            }
            else
            {
                panel_timeLeft.Visible = false;
            }
        }

        private void PreviousPageBtn_Click(object sender, EventArgs e)
        {
            currentPage -= 1;
            if (currentPage == 0)
            {
                PreviousPageBtn.Visible = false;
            }
            NextPageBtn.Visible = true;
            panel_Page[currentPage].BringToFront();
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            currentPage += 1;
            if (currentPage == numberOfPage - 1)
            {
                NextPageBtn.Visible = false;
            }
            PreviousPageBtn.Visible = true;
            panel_Page[currentPage].BringToFront();
        }

        private void pageButtonClick(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            int x = (Convert.ToInt32(text) - 1) / questionPerPage;
            currentPage = x;
            panel_Page[x].BringToFront();
            if (currentPage == numberOfPage - 1)
            {
                NextPageBtn.Visible = false;
            }
            else NextPageBtn.Visible = true;
            if (currentPage == 0)
            {
                PreviousPageBtn.Visible = false;
            }
            else PreviousPageBtn.Visible = true;
        }

        private void FinishLbl_Click(object sender, EventArgs e)
        {
            if (finished == false)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to finish attempt ?", "Finish attempt",
                        MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    finished = true;
                    finishAttempt();
                    countDownTimer.Stop();
                }
            }
            else this.Close();
        }

        private void finishAttempt()
        {
            for (int i = 0; i < numberOfPage - 1; i++)
            {
                for (int j = 0; j < questionPerPage; j++)
                {
                    if (quiz[questionPerPage * i + j].IsMultipleChoiceQuestion == true)
                    {
                        string correctAnswer = "";
                        for (int k = 0; k < quiz[questionPerPage * i + j].numberOfChoice; k++)
                        {
                            quiz[questionPerPage * i + j].checkboxChoice[k].AutoCheck = false;
                            quiz[questionPerPage * i + j].checkboxChoice[k].Click -= quiz[questionPerPage * i + j].checkBoxClick;
                            if (quiz[questionPerPage * i + j].checkboxChoice[k].Checked == true)
                            {
                                quiz[questionPerPage * i + j].mark += quiz[questionPerPage * i + j].questionChoices[k].mark;
                                finalMark += quiz[questionPerPage * i + j].questionChoices[k].mark;
                            }
                            if (quiz[questionPerPage * i + j].questionChoices[k].mark > 0)
                                correctAnswer += "\n" + quiz[questionPerPage * i + j].alphabet[k].ToString()
                                    + ". " + quiz[questionPerPage * i + j].richTextBoxes[k].Text;
                        }
                        if (quiz[questionPerPage * i + j].mark == 1)
                        {
                            quiz[questionPerPage * i + j].KeyRtb.Text = "Your answer is correct.";
                            quiz[questionPerPage * i + j].KeyRtb.Font = new Font("Segoe UI", 12F);
                            quiz[questionPerPage * i + j].KeyRtb.BackColor = Color.LightGreen;
                            // set button color
                            button[questionPerPage * i + j].BackColor = Color.LightGreen;
                        }
                        else
                        {
                            quiz[questionPerPage * i + j].KeyRtb.BackColor = Color.FromArgb(255, 236, 220);
                            quiz[questionPerPage * i + j].KeyRtb.Text = "Your answer is incorrect.\nThe correct answer is:" + correctAnswer;
                            quiz[questionPerPage * i + j].KeyRtb.Font = new Font("Segoe UI", 12F);
                            // set button color
                            button[questionPerPage * i + j].BackColor = Color.Red;
                        }
                        // edit key rtb
                        quiz[questionPerPage * i + j].KeyRtb.Width = quiz[questionPerPage * i + j].panel2.Width;
                        using (Graphics g = CreateGraphics())
                        {
                            quiz[questionPerPage * i + j].KeyRtb.Height = (int)g.MeasureString(quiz[questionPerPage * i + j].KeyRtb.Text,
                                quiz[questionPerPage * i + j].KeyRtb.Font, quiz[questionPerPage * i + j].KeyRtb.Width).Height;
                        }
                        quiz[questionPerPage * i + j].KeyRtb.Location = new Point(quiz[questionPerPage * i + j].panel2.Location.X,
                            quiz[questionPerPage * i + j].panel2.Location.Y +
                            quiz[questionPerPage * i + j].panel2.Height + 10);
                        quiz[questionPerPage * i + j].KeyRtb.Visible = true;
                        quiz[questionPerPage * i + j].KeyRtb.ReadOnly = true;
                        quiz[questionPerPage * i + j].Height += quiz[questionPerPage * i + j].KeyRtb.Height + 10;
                        if (j == 0)
                        {
                            quiz[questionPerPage * i + j].Location = new Point(0, 0);
                        }
                        else quiz[questionPerPage * i + j].Location = new Point(0,
                            quiz[questionPerPage * i + j - 1].Location.Y + quiz[questionPerPage * i + j - 1].Height);
                    }
                    else
                    {
                        string correctAnswer = "";
                        for (int k = 0; k < quiz[questionPerPage * i + j].numberOfChoice; k++)
                        {
                            quiz[questionPerPage * i + j].radioChoice[k].AutoCheck = false;
                            quiz[questionPerPage * i + j].radioChoice[k].Click -= quiz[questionPerPage * i + j].radionButtonClick;
                            if (quiz[questionPerPage * i + j].radioChoice[k].Checked == true)
                            {
                                quiz[questionPerPage * i + j].mark += quiz[questionPerPage * i + j].questionChoices[k].mark;
                                finalMark += quiz[questionPerPage * i + j].questionChoices[k].mark;
                            }
                            if (quiz[questionPerPage * i + j].questionChoices[k].mark > 0)
                                correctAnswer += "\n" + quiz[questionPerPage * i + j].alphabet[k].ToString()
                                    + ". " + quiz[questionPerPage * i + j].richTextBoxes[k].Text;
                        }
                        if (quiz[questionPerPage * i + j].mark == 1)
                        {
                            quiz[questionPerPage * i + j].KeyRtb.Text = "Your answer is correct.";
                            quiz[questionPerPage * i + j].KeyRtb.BackColor = Color.LightGreen;
                            // set button color
                            button[questionPerPage * i + j].BackColor = Color.LightGreen;
                        }
                        else
                        {
                            quiz[questionPerPage * i + j].KeyRtb.BackColor = Color.FromArgb(255, 236, 220);
                            quiz[questionPerPage * i + j].KeyRtb.Text = "Your answer is incorrect.\nThe correct answer is:" + correctAnswer;
                            // set button color
                            button[questionPerPage * i + j].BackColor = Color.Red;
                        }
                        // edit key rtb
                        quiz[questionPerPage * i + j].KeyRtb.Width = quiz[questionPerPage * i + j].panel2.Width;
                        using (Graphics g = CreateGraphics())
                        {
                            quiz[questionPerPage * i + j].KeyRtb.Height = (int)g.MeasureString(quiz[questionPerPage * i + j].KeyRtb.Text,
                                quiz[questionPerPage * i + j].KeyRtb.Font, quiz[questionPerPage * i + j].KeyRtb.Width).Height;
                        }
                        quiz[questionPerPage * i + j].KeyRtb.Location = new Point(quiz[questionPerPage * i + j].panel2.Location.X,
                            quiz[questionPerPage * i + j].panel2.Location.Y +
                            quiz[questionPerPage * i + j].panel2.Height + 10);
                        quiz[questionPerPage * i + j].KeyRtb.Visible = true;
                        quiz[questionPerPage * i + j].KeyRtb.ReadOnly = true;
                        quiz[questionPerPage * i + j].Height += quiz[questionPerPage * i + j].KeyRtb.Height + 10;
                        if (j == 0)
                        {
                            quiz[questionPerPage * i + j].Location = new Point(0, 0);
                        }
                        else quiz[questionPerPage * i + j].Location = new Point(0,
                            quiz[questionPerPage * i + j - 1].Location.Y + quiz[questionPerPage * i + j - 1].Height);
                    }
                }
            }
            // last page
            int _x = numberOfQuestion / questionPerPage;
            if (_x * questionPerPage == numberOfQuestion) _x--;
            for (int i = _x * questionPerPage; i < numberOfQuestion; i++)
            {
                if (quiz[i].IsMultipleChoiceQuestion == true)
                {
                    string correctAnswer = "";
                    for (int k = 0; k < quiz[i].numberOfChoice; k++)
                    {
                        quiz[i].checkboxChoice[k].AutoCheck = false;
                        quiz[i].checkboxChoice[k].Click -= quiz[i].checkBoxClick;
                        if (quiz[i].checkboxChoice[k].Checked == true)
                        {
                            quiz[i].mark += quiz[i].questionChoices[k].mark;
                            finalMark += quiz[i].questionChoices[k].mark;
                        }
                        if (quiz[i].questionChoices[k].mark > 0)
                            correctAnswer += "\n" + quiz[i].alphabet[k].ToString() + ". " + quiz[i].richTextBoxes[k].Text;
                    }
                    if (quiz[i].mark == 1)
                    {
                        quiz[i].KeyRtb.Text = "Your answer is correct.";
                        quiz[i].KeyRtb.BackColor = Color.LightGreen;
                        // set button color
                        button[i].BackColor = Color.LightGreen;
                    }
                    else
                    {
                        quiz[i].KeyRtb.BackColor = Color.FromArgb(255, 236, 220);
                        quiz[i].KeyRtb.Text = "Your answer is incorrect.\nThe correct answer is:" + correctAnswer;
                        // set button color
                        button[i].BackColor = Color.Red;
                    }
                    // edit key rtb
                    quiz[i].KeyRtb.Width = quiz[i].panel2.Width;
                    using (Graphics g = CreateGraphics())
                    {
                        quiz[i].KeyRtb.Height = (int)g.MeasureString(quiz[i].KeyRtb.Text,
                            quiz[i].KeyRtb.Font, quiz[i].KeyRtb.Width).Height;
                    }
                    quiz[i].KeyRtb.Location = new Point(quiz[i].panel2.Location.X,
                        quiz[i].panel2.Location.Y +
                        quiz[i].panel2.Height + 10);
                    quiz[i].KeyRtb.Visible = true;
                    quiz[i].KeyRtb.ReadOnly = true;
                    quiz[i].Height += quiz[i].KeyRtb.Height + 10;
                    if (i == _x * questionPerPage)
                    {
                        quiz[i].Location = new Point(0, 0);
                    }
                    else quiz[i].Location = new Point(0,
                        quiz[i - 1].Location.Y + quiz[i - 1].Height);
                }
                else
                {
                    string correctAnswer = "";
                    for (int k = 0; k < quiz[i].numberOfChoice; k++)
                    {
                        quiz[i].radioChoice[k].AutoCheck = false;
                        quiz[i].radioChoice[k].Click -= quiz[i].radionButtonClick;
                        if (quiz[i].radioChoice[k].Checked == true)
                        {
                            quiz[i].mark += quiz[i].questionChoices[k].mark;
                            finalMark += quiz[i].questionChoices[k].mark;
                        }
                        if (quiz[i].questionChoices[k].mark > 0)
                            correctAnswer += "\n" + quiz[i].alphabet[k].ToString() + ". " + quiz[i].richTextBoxes[k].Text;
                    }
                    if (quiz[i].mark == 1)
                    {
                        quiz[i].KeyRtb.Text = "Your answer is correct.";
                        quiz[i].KeyRtb.BackColor = Color.LightGreen;
                        // set button color
                        button[i].BackColor = Color.LightGreen;
                    }
                    else
                    {
                        quiz[i].KeyRtb.BackColor = Color.FromArgb(255, 236, 220);
                        quiz[i].KeyRtb.Text = "Your answer is incorrect.\nThe correct answer is:" + correctAnswer;
                        // set button color
                        button[i].BackColor = Color.Red;
                    }
                    // edit key rtb
                    quiz[i].KeyRtb.Width = quiz[i].panel2.Width;
                    using (Graphics g = CreateGraphics())
                    {
                        quiz[i].KeyRtb.Height = (int)g.MeasureString(quiz[i].KeyRtb.Text,
                            quiz[i].KeyRtb.Font, quiz[i].KeyRtb.Width).Height;
                    }
                    quiz[i].KeyRtb.Location = new Point(quiz[i].panel2.Location.X,
                        quiz[i].panel2.Location.Y +
                        quiz[i].panel2.Height + 10);
                    quiz[i].KeyRtb.Visible = true;
                    quiz[i].KeyRtb.ReadOnly = true;
                    quiz[i].Height += quiz[i].KeyRtb.Height + 10;
                    if (i == _x * questionPerPage)
                    {
                        quiz[i].Location = new Point(0, 0);
                    }
                    else quiz[i].Location = new Point(0,
                        quiz[i - 1].Location.Y + quiz[i - 1].Height);
                }

            }

            // update status of review
            StartTimeLbl.Text = contestForm.timeStart.ToString();
            FinishTimeLbl.Text = DateTime.Now.ToString();
            TimeTakenLbl.Text = "1 min 27 secs";
            MarkLbl.Text = Math.Round(finalMark, 2).ToString() + "/" + questionID.Count.ToString();
            double x = finalMark / questionID.Count;
            GradeLbl.Text = Math.Round(x * Convert.ToDouble(contestForm.editQuiz.EditQuiz_MaxGradeTxt.Text), 2).ToString() + " out of "
                + contestForm.editQuiz.EditQuiz_MaxGradeTxt.Text + $" ({Math.Round(100 * x, 2)}%)";
            string[] str = TimeLeftLbl.Text.Split(':');
            if (Convert.ToInt32(str[1]) != 0)
            {
                TimeTakenLbl.Text = (Convert.ToInt32(contestForm.timeLimit) - Convert.ToInt32(str[0]) - 1).ToString()
                    + " min " + (60 - Convert.ToInt32(str[1])).ToString() + " sec";
            }
            else
            {
                TimeTakenLbl.Text = (Convert.ToInt32(contestForm.timeLimit) - Convert.ToInt32(str[0])).ToString()
                    + " min";
            }
            panel_Review.Visible = true;
            panel_time.Height = panel_Review.Height;
            panel_timeLeft.Visible = false;
            //
            panel_Page[0].BringToFront();
            currentPage = 0;
            FinishLbl.Text = "Finish review";
            PreviousPageBtn.Visible = false;
            if (numberOfPage > 0) NextPageBtn.Visible = true;
        }

        private int minute;
        private int second = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;
            if (second < 0)
            {
                minute--;
                second = 59;
            }
            TimeLeftLbl.Text = minute.ToString() + " : " + second.ToString();
            if (minute < 0)
            {
                countDownTimer.Stop();
                finishAttempt();
                finished = true;
            }
        }

        private List<QuestionChoice> shuffleList(List<QuestionChoice> list)
        {
            int i = list.Count;
            Random rd = new Random();
            while (i > 1)
            {
                i--;
                int k = rd.Next(i + 1);
                QuestionChoice tmp = list[k];
                list[k] = list[i];
                list[i] = tmp;
            }
            return list;
        }

        private void panel_timeLeft_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel_timeLeft.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

    }
}
