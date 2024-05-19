using Learning_System.Modals;
using Learning_System.ProcessingClasses;
using Learning_System.Properties;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Learning_System
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeDataTable();
            InitializeComponent();

            notifyIcon1.ShowBalloonTip(10000);

            LoadContestList();
        }

        private void InitializeDataTable()
        {
            List<string> showColumns, showKey;
            List<Type> showType;

            showColumns = new() { "Id", "Name", "SubArray", "QuestionArray", "Description", "IdNumber" };
            showType = new() { typeof(int), typeof(string), typeof(JArray), typeof(JArray), typeof(string), typeof(string) };
            showKey = new() { "PRIMARY KEY", "NOT NULL", "", "", "", "" };

            CategoriesTable.table.Import(showColumns, showType, showKey);

            showColumns = new() { "ID", "Name", "CategoryID", "Content", "DefaultMark", "Choice" };
            showType = new() { typeof(int), typeof(string), typeof(int), typeof(string), typeof(double), typeof(JArray) };
            showKey = new() { "PRIMARY KEY", "NOT NULL", "", "NOT NULL", "NOT NULL", "" };

            QuestionsTable.table.Import(showColumns, showType, showKey);

            showColumns = new() { "Id", "Name", "Description", "DescriptionShow", "QuestionArray", "ShuffleAnswer",
                                               "TimeStart", "StartEnable", "TimeEnd", "EndEnable", "TimeLimit", "TimeLimitEnable", "MaximumGrade"};
            showType = new() { typeof(int), typeof(string), typeof(string), typeof(bool), typeof(JArray), typeof(bool),
                                          typeof(DateTime), typeof(bool), typeof(DateTime), typeof(bool), typeof(int), typeof(bool), typeof(double)};
            showKey = new() { "PRIMARY KEY", "NOT NULL", "", "", "", "", "NOT NULL", "NOT NULL", "NOT NULL", "NOT NULL", "NOT NULL", "NOT NULL", "NOT NULL" };

            ContestsTable.table.Import(showColumns, showType, showKey);
        }

        private void LoadContestList()
        {
            try
            {
                ContestsTable.table.LoadData(JsonProcessing.ContestsPath);

                DataTable? _DT = ContestsTable.table.Init().Sort("TimeStart desc").Get();

                if (_DT == null)
                    throw new E02CantProcessQuery();
                else
                {
                    for (int i = 0; i < _DT.Rows.Count; i++)
                    {
                        LinkLabel linklbl = new()
                        {
                            Name = "ExportForm_Linklbl" + i.ToString(),
                            Location = new Point(120, 150 + i * 45),
                            Font = new Font("Arvoregular", 12F, FontStyle.Regular, GraphicsUnit.Point),
                            ActiveLinkColor = Color.Black,
                            VisitedLinkColor = Color.Black,
                            LinkColor = Color.Black,
                            LinkBehavior = LinkBehavior.HoverUnderline,
                            FlatStyle = FlatStyle.Flat,
                            TabIndex = 10,
                            Text = _DT.Rows[i].Field<string>("Name"),
                            AutoSize = true,
                            MaximumSize = new Size(500, 0)
                        };

                        int id = _DT.Rows[i].Field<int>("Id");
                        linklbl.Click += new EventHandler((sender, args) =>
                        {
                            Settings.Default["ChoosingContest"] = id;
                            Settings.Default.Save();
                            ContestForm contestForm = new();
                            this.Hide();
                            contestForm.ShowDialog();
                            this.Show();
                        });

                        System.ComponentModel.ComponentResourceManager resources = new(typeof(HomePageForm));

                        PictureBox pictureBox = new()
                        {
                            Name = "ExportForm_PictureBox" + i.ToString(),
                            Location = new Point(90, 150 + i * 45),
                            Size = new Size(20, 20),
                            SizeMode = PictureBoxSizeMode.AutoSize,
                            TabIndex = 0,
                            TabStop = false
                        };

                        DateTime endTime = _DT.Rows[i].Field<DateTime>("TimeEnd");
                        if (DateTime.Compare(endTime, DateTime.Now) < 0)
                            pictureBox.Image = Resources.checked_file_blur;
                        else
                            pictureBox.Image = Resources.checked_file;

                        panel2.Controls.Add(linklbl);
                        panel2.Controls.Add(pictureBox);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something got error when we were getting your information!\nDescription: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Picture_setting_Click(object sender, EventArgs e)
        {
            if (panel_popup.Visible == false)
            {
                panel_popup.Visible = true;
            }
            else
            {
                panel_popup.Visible = false;
            }
        }

        private void Button_Import_Click(object sender, EventArgs e)
        {
            if (panel_popup.Visible == false)
            {
                panel_popup.Visible = true;
            }
            else
            {
                panel_popup.Visible = false;
            }
            PopUpForm.Visible = true;
            PopUpForm.Show_Import();
        }

        private void Button_Categories_Click(object sender, EventArgs e)
        {
            if (panel_popup.Visible == false)
            {
                panel_popup.Visible = true;
            }
            else
            {
                panel_popup.Visible = false;
            }
            PopUpForm.Visible = true;
            PopUpForm.Show_Categories();
        }

        private void Button_Questions_Click(object sender, EventArgs e)
        {
            if (panel_popup.Visible == false)
            {
                panel_popup.Visible = true;
            }
            else
            {
                panel_popup.Visible = false;
            }
            PopUpForm.Visible = true;
            PopUpForm.Show_Questions();
        }

        private void Button_Export_Click(object sender, EventArgs e)
        {
            if (panel_popup.Visible == false)
            {
                panel_popup.Visible = true;
            }
            else
            {
                panel_popup.Visible = false;
            }
            PopUpForm.Visible = true;
            PopUpForm.Show_Export();
        }

        private void HomePageForm_MenuPic_Click(object sender, EventArgs e)
        {
            panel_popup.Visible = false;
            PopUpForm.Visible = false;
            LoadContestList();
        }

        private void HomePageForm_EditingBtn_Click(object sender, EventArgs e)
        {
            AddingNewQuiz aDN = new AddingNewQuiz();
            aDN.ShowDialog();
            LoadContestList();
        }
    }
}