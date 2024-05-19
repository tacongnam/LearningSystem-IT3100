using Learning_System.Modals;
using Learning_System.ProcessingClasses;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Text.RegularExpressions;

namespace Learning_System
{
    public partial class EditQuestionForm : Form
    {
        const int MAXOFCHOICE = 26;
        private int Count_Choices;
        private int Count_Button = 1;
        private int Count_Line = 0;
        private bool IsInitial = true;
        private int CurrentParentId;
        private int QuestionID;

        // dynamic control
        Panel[] panelParent = new Panel[MAXOFCHOICE];
        Panel[] panel = new Panel[MAXOFCHOICE];
        RichTextBox[] richTextBoxes = new RichTextBox[MAXOFCHOICE];
        ComboBox[] combobox = new ComboBox[MAXOFCHOICE];
        Label[] labelChoice = new Label[MAXOFCHOICE];
        Label[] labelGrade = new Label[MAXOFCHOICE];

        // Data cho category
        private DataTable? categoriesDataTable = new();

        // Data cho question
        private DataTable? questionsDataTable = new();

        public EditQuestionForm(int ID, int ParentID)
        {
            CurrentParentId = ParentID;
            QuestionID = ID;
            // Doc du lieu Question
            try
            {
                QuestionsTable.table.LoadData(JsonProcessing.QuestionsPath);
                questionsDataTable = QuestionsTable.table.Init().Get();

                if (questionsDataTable == null)
                    throw new E02CantProcessQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get categories data.\nDescription: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InitializeComponent();
            this.ActiveControl = AddNewQuestionForm_CategoryCbo;
            AddNewQuestionForm_MarkTxt.ReadOnly = true;
            //Doc du lieu Category
            try
            {
                if (IsInitial == true)
                {
                    CategoriesTable.table.LoadData(JsonProcessing.CategoriesPath);
                    categoriesDataTable = CategoriesTable.table.Init().Get();
                    if (categoriesDataTable == null)
                        throw new E02CantProcessQuery();

                    IsInitial = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get categories data.\nDescription: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddNewQuestionForm_CategoryCbo.ValueMember = "Id";
            AddNewQuestionForm_CategoryCbo.DisplayMember = "Name";
            AddNewQuestionForm_CategoryCbo.DataSource = categoriesDataTable;

            // Doc du lieu cau hoi vao form
            List<string> queryQuestion = new() { "ID", ID.ToString() };
            DataTable? _chkDT = QuestionsTable.table.Init().Offset(0).Limit(1).Query(queryQuestion).Get();
            if (_chkDT == null)
                throw new E02CantProcessQuery();

            // Can't find your old question
            if (_chkDT.Rows.Count == 0)
                throw new E99OtherException("Can't load your question. Please try again");

            DataRow? currentQuestionRow = QuestionsTable.table.Init().Offset(0).Limit(1).Query(queryQuestion).GetFirstRow();
            if (currentQuestionRow == null)
                throw new E02CantProcessQuery();

            AddNewQuestionForm_NameTxt.Text = currentQuestionRow.Field<string>("Name");
            try
            {
                AddNewQuestionForm_TextRtb.Rtf = currentQuestionRow.Field<string>("Content");
            }
            catch
            {
                AddNewQuestionForm_TextRtb.Text = currentQuestionRow.Field<string>("Content");
            }

            AddNewQuestionForm_MarkTxt.Text = currentQuestionRow.Field<double>("DefaultMark").ToString();
            AddNewQuestionForm_CategoryCbo.SelectedIndex = CurrentParentId;
            JArray? choiceJArray = currentQuestionRow.Field<JArray>("Choice");
            if (choiceJArray == null)
                throw new E03NotExistColumn("Choice");
            List<QuestionChoice>? choices = choiceJArray.ToObject<List<QuestionChoice>>();

            Count_Choices = choices.Count;
            if (choices.Count > MAXOFCHOICE)
            {
                MessageBox.Show($"Max number of choice is {MAXOFCHOICE}, others is deleted!");
                choices.RemoveRange(MAXOFCHOICE, choices.Count - MAXOFCHOICE);
            }
            for (int i = 0; i < choices.Count; i++)
            {
                richTextBoxes[i] = new RichTextBox();
                combobox[i] = new System.Windows.Forms.ComboBox();
                labelChoice[i] = new Label();
                labelGrade[i] = new Label();
                //panel Parent
                panelParent[i] = new Panel
                {
                    Location = new Point(0, panel_.Height + i * 258),
                    Size = new Size(1212, 258)
                };
                //panel
                panel[i] = new Panel
                {
                    Location = new Point(354, 6),
                    Size = new Size(900, 243)
                };
                panel[i].Controls.Add(richTextBoxes[i]);
                panel[i].Controls.Add(combobox[i]);
                panel[i].Controls.Add(labelChoice[i]);
                panel[i].Controls.Add(labelGrade[i]);
                // combobox
                combobox[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                combobox[i].FormattingEnabled = true;
                combobox[i].Items.AddRange(new object[] { "None", "100%", "90%", "83.33333%", "80%", "75%", "70%", "66.66667%", "60%", "50%", "40%", "33.33333%", "30%", "25%", "20%", "16.66667%", "14.28571%", "12.5%", "11.11111%", "10%", "5%", "-5%", "-10%", "-11.11111%", "-12.5%", "-14.28571%", "-16.66667%", "-20%", "-25%", "-30%", "-33.33333%", "-40%", "-50%", "-60%", "-66.66667%", "-70%", "-75%", "-80%", "-83.33333%" });
                combobox[i].Location = new Point(106, 201);
                combobox[i].TabIndex = (i * 2 + 1) + 12;
                combobox[i].Size = new Size(151, 31);
                // richtextbox
                richTextBoxes[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                richTextBoxes[i].Location = new Point(106, 14);
                richTextBoxes[i].Size = new Size(730, 162);
                richTextBoxes[i].TabIndex = (i * 2) + 12;
                richTextBoxes[i].Text = "";
                // label choice
                labelChoice[i].AutoSize = true;
                labelChoice[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                labelChoice[i].Location = new Point(12, 14);
                labelChoice[i].Size = new Size(71, 23);
                labelChoice[i].Text = "Choice " + (i + 1).ToString() + ": ";
                // label grade
                labelGrade[i].AutoSize = true;
                labelGrade[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                labelGrade[i].Location = new Point(12, 201);
                labelGrade[i].Size = new Size(56, 23);
                labelGrade[i].Text = "Grade";

                panel_body.Controls.Add(panelParent[i]);
                panelParent[i].Controls.Add(panel[i]);

                // doc data cho choice
                combobox[i].SelectedIndex = ConvertDoubleToComboboxIndex(choices[i].mark);
                try
                {
                    richTextBoxes[i].Rtf = choices[i].choice;
                }
                catch
                {
                    richTextBoxes[i].Text = choices[i].choice;
                }
            }
            panel_button.Location = new Point(0, panel_.Height + choices.Count * 258);
        }

        public EditQuestionForm()
        {
            InitializeComponent();
        }

        private void AddNewQuestionForm_SaveBtn_Click(object sender, EventArgs e)
        {
            if (UpdateNewQuestion() == true)
                Close();
        }

        private void AddNewQuestionForm_CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewQuestionForm_SaveAndContinueBtn_Click(object sender, EventArgs e)
        {
            if (UpdateNewQuestion() == true)
                Count_Button++;
        }

        private bool UpdateNewQuestion()
        {
            string _error = "";
            if (AddNewQuestionForm_NameTxt.Text == null || AddNewQuestionForm_NameTxt.Text == "")
            {
                if (_error.Length > 0)
                    _error += ", ";
                _error += "Question name";
            }
            if (AddNewQuestionForm_TextRtb.Text == null || AddNewQuestionForm_TextRtb.Text == "")
            {
                if (_error.Length > 0)
                    _error += ", ";
                _error += "Question text";
            }
            if (AddNewQuestionForm_MarkTxt.Text == null || AddNewQuestionForm_MarkTxt.Text == "")
            {
                if (_error.Length > 0)
                    _error += ", ";
                _error += "Default mark";
            }
            if (_error != "")
            {
                AddNewQuestionForm_ErrorLbl.Text = "Must be filled: " + _error;
            }
            else
            {
                if (Count_Button > 0)
                {
                    List<string> _query1 = new() { "Id", CurrentParentId.ToString() };
                    DataTable? _parentTbl = CategoriesTable.table.Init().Offset(0).Limit(1).Query(_query1).Get();
                    if (_parentTbl == null)
                        throw new E02CantProcessQuery();

                    // If old category was deleted by sth? => Create new category
                    if (_parentTbl.Rows.Count == 0)
                    {
                        Categories _newCategory = new()
                        {
                            Id = CategoriesTable.table.Length(),
                            Name = DateTime.Now.ToString(),
                            SubArray = new List<int>(),
                            QuestionArray = new List<int>(),
                            Description = "Auto-generated category",
                            IdNumber = "AGC"
                        };

                        if (CategoriesTable.table.Insert(JObject.FromObject(_newCategory)) == DataProcessing.StatusCode.Error)
                            throw new E05CantInsertProperly();

                        CurrentParentId = _newCategory.Id;
                    }
                    else
                    {
                        DataRow _parentRow = _parentTbl.Rows[0];

                        JArray? _x = _parentRow.Field<JArray>("QuestionArray");
                        if (_x == null)
                            throw new E03NotExistColumn("QuestionArray");

                        List<int>? questionArray = _x.ToObject<List<int>>();
                        if (questionArray == null)
                            throw new E99OtherException("Can't get data from null!");

                        _x.RemoveAt(questionArray.IndexOf(QuestionID));
                        JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);
                        if (CategoriesTable.table.Init().Offset(0).Limit(1).Query(_query1).Update(x) == DataProcessing.StatusCode.Error)
                            throw new E02CantProcessQuery();
                    }
                }
                AddNewQuestionForm_ErrorLbl.Text = "";

                var _parentId = AddNewQuestionForm_CategoryCbo.SelectedValue;
                var _name = AddNewQuestionForm_NameTxt.Text;
                var _content = AddNewQuestionForm_TextRtb.Rtf;

                // Default / NULL value => use the old category
                if (AddNewQuestionForm_CategoryCbo.SelectedValue == null)
                {
                    _parentId = CurrentParentId;
                }

                try
                {
                    Convert.ToDouble(AddNewQuestionForm_MarkTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Default mark must be double");
                    return false;
                }
                var _defaultmark = Convert.ToDouble(AddNewQuestionForm_MarkTxt.Text);
                // doc du lieu tu dap an
                var _choice = new List<QuestionChoice>();
                double sumPositiveGrade = 0;
                for (int i = 0; i < Count_Choices; i++)
                {
                    if (richTextBoxes[i].TextLength != 0)
                    { 
                        QuestionChoice newChoice = new QuestionChoice()
                        {
                            choice = richTextBoxes[i].Rtf,
                            mark = ConvertComboboxTextToDouble(combobox[i].Text)
                        };
                        _choice.Add(newChoice);
                        if (newChoice.mark > 0)
                            sumPositiveGrade += newChoice.mark;
                    }
                }

                if (sumPositiveGrade != (double)1)
                {
                    MessageBox.Show("Sum of all positive grades must equals to 100%!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (_choice.Count == 1)
                {
                    MessageBox.Show("Your question must have at least two choices!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                try
                {
                    Questions _newQuestion = new()
                    {
                        ID = QuestionID,
                        CategoryID = Convert.ToInt32(_parentId.ToString()),
                        Name = _name,
                        Content = _content,
                        DefaultMark = _defaultmark,
                        Choice = _choice
                    };

                    List<string> _query = new() { "Id", _parentId.ToString() };
                    DataTable? _parentTbl = CategoriesTable.table.Init().Limit(1).Query(_query).Get();
                    if (_parentTbl == null)
                        throw new E02CantProcessQuery();

                    // Chac chan co row (khong co thi tren vua tao oi), neu khong co thi chiu thoi
                    DataRow _parentRow = _parentTbl.Rows[0];

                    JArray? _x = _parentRow.Field<JArray>("QuestionArray");
                    if (_x == null)
                        throw new E03NotExistColumn("QuestionArray");

                    _x.Add(_newQuestion.ID);
                    JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);
                    if (CategoriesTable.table.Init().Offset(0).Limit(1).Query(_query).Update(x) == DataProcessing.StatusCode.Error)
                        throw new E02CantProcessQuery();

                    if (JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", CategoriesTable.table.Export()) == null)
                        throw new E04CantExportProperly();

                    CurrentParentId = Convert.ToInt32(_parentId.ToString());

                    List<string> query = new() { "ID", QuestionID.ToString() };
                    DataTable? _questionTbl = QuestionsTable.table.Init().Offset(0).Limit(1).Query(query).Get();
                    if (_questionTbl == null)
                        throw new E02CantProcessQuery();

                    // If this qs is not exist (by somehow), we have to insert it
                    if (_questionTbl.Rows.Count == 0)
                    {
                        if (QuestionsTable.table.Insert(JObject.FromObject(_newQuestion)) == DataProcessing.StatusCode.Error)
                            throw new E02CantProcessQuery();
                    }
                    else
                    {
                        DataRow _questionRow = _questionTbl.Rows[0];

                        _questionRow.BeginEdit();
                        _questionRow["Name"] = _name;
                        _questionRow["CategoryID"] = CurrentParentId;
                        _questionRow["Content"] = _content;
                        _questionRow["DefaultMark"] = _defaultmark;
                        _questionRow["Choice"] = JArray.FromObject(_choice);
                        _questionRow.EndEdit();

                        JObject _ = DataProcessing.ConvertDataRowToJObject(_questionRow);
                        if (QuestionsTable.table.Init().Offset(0).Limit(1).Query(query).Update(_) == DataProcessing.StatusCode.Error)
                            throw new E02CantProcessQuery();
                    }

                    if (JsonProcessing.ExportJsonContentInDefaultFolder("Question.json", QuestionsTable.table.Export()) == null)
                        throw new E04CantExportProperly();

                    MessageBox.Show("Update question successfully!", "Success");

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update question failed!\nDescription: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return false;
        }

        private void AddNewQuestionForm_MoreChoicesBtn_Click(object sender, EventArgs e)
        {
            // Keep the number of choices <= 26 to use English alphabet
            if (Count_Choices + 3 > 26)
            {
                MessageBox.Show("Can't add more than 26 choices in a single question!", "Warning");
                return;
            }

            if (Count_Choices + 3 > MAXOFCHOICE)
            {
                MessageBox.Show($"Max of choice is {MAXOFCHOICE}");
                AddNewQuestionForm_MoreChoicesBtn.Visible = false;
                return;
            }

            for (int i = Count_Choices; i < Count_Choices + 3; i++)
            {
                richTextBoxes[i] = new RichTextBox();
                combobox[i] = new System.Windows.Forms.ComboBox();
                labelChoice[i] = new Label();
                labelGrade[i] = new Label();

                //panel Parent
                panelParent[i] = new Panel
                {
                    Location = new Point(0, panelParent[i - 1].Location.Y + 258),
                    Size = new Size(1212, 258)
                };

                //panel
                panel[i] = new Panel
                {
                    Location = new Point(354, 6),
                    Size = new Size(900, 243)
                };
                panel[i].Controls.Add(richTextBoxes[i]);
                panel[i].Controls.Add(combobox[i]);
                panel[i].Controls.Add(labelChoice[i]);
                panel[i].Controls.Add(labelGrade[i]);

                // combobox
                combobox[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                combobox[i].FormattingEnabled = true;
                combobox[i].Items.AddRange(new object[] { "None", "100%", "90%", "83.33333%", "80%", "75%", "70%", "66.66667%", "60%", "50%", "40%", "33.33333%", "30%", "25%", "20%", "16.66667%", "14.28571%", "12.5%", "11.11111%", "10%", "5%", "-5%", "-10%", "-11.11111%", "-12.5%", "-14.28571%", "-16.66667%", "-20%", "-25%", "-30%", "-33.33333%", "-40%", "-50%", "-60%", "-66.66667%", "-70%", "-75%", "-80%", "-83.33333%" });
                combobox[i].Location = new Point(106, 201);
                combobox[i].Size = new Size(151, 31);
                combobox[i].Text = "None";
                combobox[i].TabIndex = (i * 2 + 1) + 12;

                // richtextbox
                richTextBoxes[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                richTextBoxes[i].Location = new Point(106, 14);
                richTextBoxes[i].Size = new Size(730, 162);
                richTextBoxes[i].Text = "";
                richTextBoxes[i].TabIndex = (i * 2) + 12;

                // label choice
                labelChoice[i].AutoSize = true;
                labelChoice[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                labelChoice[i].Location = new Point(12, 14);
                labelChoice[i].Size = new Size(71, 23);
                labelChoice[i].Text = "Choice " + (i + 1).ToString() + ": ";

                // label grade
                labelGrade[i].AutoSize = true;
                labelGrade[i].Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                labelGrade[i].Location = new Point(12, 201);
                labelGrade[i].Size = new Size(56, 23);
                labelGrade[i].Text = "Grade";

                panel_body.Controls.Add(panelParent[i]);
                panelParent[i].Controls.Add(panel[i]);
            }

            panel_button.Location = new Point(0, panelParent[Count_Choices + 2].Location.Y + 258);
            if (Count_Choices + 3 >= MAXOFCHOICE)
                AddNewQuestionForm_MoreChoicesBtn.Visible = false;
            else Count_Choices += 3;
        }

        private double ConvertComboboxTextToDouble(string _CboText)
        {
            try
            {
                return Convert.ToDouble(_CboText.Substring(0, _CboText.Length - 1)) / 100.0;
            }
            catch
            {
                return 0;
            }
        }

        private int ConvertDoubleToComboboxIndex(double mark)
        {
            List<double> list = new() { 0, 100, 90, 83.33333, 80, 75, 70, 66.66667, 60, 50, 40, 33.33333, 30, 25, 20, 16.66667, 14.28571, 12.5, 11.11111, 10, 5, -5, -10, -11.11111, -12.5, -14.28571, -16.66667, -20, -25, -30, -33.33333, -40, -50, -60, -66.66667, -70, -75, -80, -83.33333 };
            if (mark == 0) return 0;
            else return list.IndexOf(mark * 100);
        }

    }
}
