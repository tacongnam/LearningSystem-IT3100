using Learning_System.Modals;
using Learning_System.ProcessingClasses;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Text.RegularExpressions;

namespace Learning_System
{
    public partial class AddNewQuestionForm : Form
    {
        const int MAXOFCHOICE = 20;
        private int Count_Choices = 2;
        private int Count_Button = 0;
        private bool IsInitial = true;
        private int CurrentParentId;
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

        public AddNewQuestionForm()
        {
            try
            {
                QuestionsTable.table.LoadData(JsonProcessing.QuestionsPath);
                questionsDataTable = QuestionsTable.table.Init().Get();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get categories data!\nDescription: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InitializeComponent();
            this.ActiveControl = AddNewQuestionForm_CategoryCbo;

            AddNewQuestionForm_MarkTxt.ReadOnly = true;
            AddNewQuestionForm_MarkTxt.Text = "1";
            for (int i = 0; i < 2; i++)
            {
                richTextBoxes[i] = new RichTextBox();
                combobox[i] = new ComboBox();
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
                panel[i].BackColor = SystemColors.Control;
                // combobox
                combobox[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                combobox[i].FormattingEnabled = true;
                combobox[i].Items.AddRange(new object[] { "None", "100%", "90%", "83.33333%", "80%", "75%", "70%", "66.66667%", "60%", "50%", "40%", "33.33333%", "30%", "25%", "20%", "16.66667%", "14.28571%", "12.5%", "11.11111%", "10%", "5%", "-5%", "-10%", "-11.11111%", "-12.5%", "-14.28571%", "-16.66667%", "-20%", "-25%", "-30%", "-33.33333%", "-40%", "-50%", "-60%", "-66.66667%", "-70%", "-75%", "-80%", "-83.33333%" });
                combobox[i].Location = new Point(106, 201);
                combobox[i].Size = new Size(151, 31);
                combobox[i].Text = "None";
                combobox[i].TabIndex = (i * 2 + 1) + 12;
                // richtextbox
                richTextBoxes[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                richTextBoxes[i].Location = new Point(106, 14);
                richTextBoxes[i].Size = new Size(730, 162);
                richTextBoxes[i].Text = "";
                combobox[i].TabIndex = (i * 2) + 12;
                // label choice
                labelChoice[i].AutoSize = true;
                labelChoice[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                labelChoice[i].Location = new Point(12, 14);
                labelChoice[i].Size = new Size(71, 23);
                labelChoice[i].Text = "Choice " + (i + 1).ToString() + ": ";
                // label grade
                labelGrade[i].AutoSize = true;
                labelGrade[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                labelGrade[i].Location = new Point(12, 201);
                labelGrade[i].Size = new Size(56, 23);
                labelGrade[i].Text = "Grade";

                panel_body.Controls.Add(panelParent[i]);
                panelParent[i].Controls.Add(panel[i]);
            }
            panel_button.Location = new Point(0, panelParent[Count_Choices - 1].Location.Y + 258);
        }

        private void AddNewQuestionForm_CategoryCbo_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (IsInitial == true)
                {
                    CategoriesTable.table.LoadData("Category.json");
                    categoriesDataTable = CategoriesTable.table.Init().Get();
                    IsInitial = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get categories data!\nDescription: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddNewQuestionForm_CategoryCbo.ValueMember = "Id";
            AddNewQuestionForm_CategoryCbo.DisplayMember = "Name";
            AddNewQuestionForm_CategoryCbo.DataSource = categoriesDataTable;
        }

        private void AddNewQuestionForm_SaveBtn_Click(object sender, EventArgs e)
        {
            if (AddNewQuestion() == true)
                Close();
        }

        private void AddNewQuestionForm_CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewQuestionForm_SaveAndContinueBtn_Click(object sender, EventArgs e)
        {
            if (AddNewQuestion() == true)
                Count_Button++;
        }

        private bool AddNewQuestion()
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
                MessageBox.Show("These fields must be filled: " + _error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (Count_Button > 0)
                {
                    DataRow? _maxIDRow = QuestionsTable.table.Init().Sort("ID desc").GetFirstRow();
                    if (_maxIDRow == null)
                        throw new E02CantProcessQuery();

                    int a = _maxIDRow.Field<int>("ID");
                    List<string> _query = new() { "ID", a.ToString() };
                    _ = QuestionsTable.table.Init().Offset(0).Limit(1).Query(_query).Delete();

                    List<string> _query1 = new() { "Id", CurrentParentId.ToString() };

                    DataRow? _parentRow = CategoriesTable.table.Init().Offset(0).Limit(1).Query(_query1).GetFirstRow();
                    if (_parentRow == null)
                        throw new E02CantProcessQuery();

                    JArray? _x = _parentRow.Field<JArray>("QuestionArray");
                    if (_x == null)
                        throw new E03NotExistColumn("QuestionArray");

                    _x.RemoveAt(_x.Count - 1);
                    JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);

                    if (CategoriesTable.table.Init().Offset(0).Limit(1).Query(_query1).Update(x) == DataProcessing.StatusCode.Error)
                        throw new E02CantProcessQuery();
                }

                AddNewQuestionForm_ErrorLbl.Text = "";

                var _parentId = AddNewQuestionForm_CategoryCbo.SelectedValue;
                var _name = AddNewQuestionForm_NameTxt.Text;
                string _content;
                if (AddNewQuestionForm_TextRtb.Rtf.Contains("\\pict"))
                    _content = AddNewQuestionForm_TextRtb.Rtf;
                else _content = AddNewQuestionForm_TextRtb.Text;
                try
                {
                    Convert.ToDouble(AddNewQuestionForm_MarkTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Default mark must be double", "Error");
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
                        string _choiceContent;
                        if (richTextBoxes[i].Rtf.Contains("\\pict"))
                            _choiceContent = richTextBoxes[i].Rtf;
                        else _choiceContent = richTextBoxes[i].Text;

                        QuestionChoice newChoice = new QuestionChoice()
                        {
                            choice = _choiceContent,
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

                if (_parentId == null)
                {
                    int categoriesCount = CategoriesTable.table.Length();
                    if (categoriesCount > 0)
                    {
                        _parentId = 0;
                    }
                    else
                    {
                        Categories _newCategory = new()
                        {
                            Id = categoriesCount,
                            Name = DateTime.Now.ToString(),
                            SubArray = new List<int>(),
                            QuestionArray = new List<int>(),
                            Description = "Auto-generated category",
                            IdNumber = "AGC"
                        };

                        if (CategoriesTable.table.Insert(JObject.FromObject(_newCategory)) == DataProcessing.StatusCode.Error)
                            throw new E05CantInsertProperly();

                        _parentId = _newCategory.Id;
                    }
                }

                try
                {
                    // This GetFirstRow doesn't affect the return value below
                    DataRow? _maxIDRow = QuestionsTable.table.Init().Sort("ID desc").GetFirstRow();
                    if (_maxIDRow == null)
                        throw new E02CantProcessQuery();

                    Questions _newQuestion = new()
                    {
                        ID = (_maxIDRow == null) ? 0 : (_maxIDRow.Field<int>("ID") + 1),
                        CategoryID = Convert.ToInt32(_parentId.ToString()),
                        Name = _name,
                        Content = _content,
                        DefaultMark = _defaultmark,
                        Choice = _choice
                    };

                    List<string> _query = new() { "Id", _parentId.ToString() };
                    DataTable? _chkDt = CategoriesTable.table.Init().Query(_query).Get();
                    if (_chkDt == null)
                        throw new E02CantProcessQuery();

                    // Can't find this parent ID (file error, ...?)
                    if (_chkDt.Rows.Count == 0)
                    {
                        AddNewQuestionForm_CategoryCbo_DropDown(AddNewQuestionForm_CategoryCbo, new EventArgs());
                        throw new E99OtherException("Can't find this category ID. Please try again.");
                    }

                    DataRow? _parentRow = CategoriesTable.table.Init().Query(_query).GetFirstRow();

                    if (_parentRow == null)
                        throw new E02CantProcessQuery();
                    else
                    {
                        JArray? _x = _parentRow.Field<JArray>("QuestionArray");
                        if (_x == null)
                            throw new E03NotExistColumn("QuestionArray");

                        _x.Add(_newQuestion.ID);

                        JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);

                        if (CategoriesTable.table.Init().Offset(0).Limit(1).Query(_query).Update(x) == DataProcessing.StatusCode.Error)
                            throw new E02CantProcessQuery();

                        if (JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", CategoriesTable.table.Export()) == null)
                            throw new E04CantExportProperly("Category.json");

                        CurrentParentId = Convert.ToInt32(_parentId.ToString());

                        if (QuestionsTable.table.Insert(JObject.FromObject(_newQuestion)) == DataProcessing.StatusCode.Error)
                            throw new E05CantInsertProperly();

                        if (JsonProcessing.ExportJsonContentInDefaultFolder("Question.json", QuestionsTable.table.Export()) == null)
                            throw new E04CantExportProperly();
                    }

                    MessageBox.Show("Add question successfully!", "Success");

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add question failed!\nDescription: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            for (int i = Count_Choices; i < Count_Choices + 3; i++)
            {
                richTextBoxes[i] = new RichTextBox();
                combobox[i] = new ComboBox();
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
                panel[i].BackColor = SystemColors.Control;
                // combobox
                combobox[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                combobox[i].FormattingEnabled = true;
                combobox[i].Items.AddRange(new object[] { "None", "100%", "90%", "83.33333%", "80%", "75%", "70%", "66.66667%", "60%", "50%", "40%", "33.33333%", "30%", "25%", "20%", "16.66667%", "14.28571%", "12.5%", "11.11111%", "10%", "5%", "-5%", "-10%", "-11.11111%", "-12.5%", "-14.28571%", "-16.66667%", "-20%", "-25%", "-30%", "-33.33333%", "-40%", "-50%", "-60%", "-66.66667%", "-70%", "-75%", "-80%", "-83.33333%" });
                combobox[i].Location = new Point(106, 201);
                combobox[i].Size = new Size(151, 31);
                combobox[i].TabIndex = (i * 2 + 1) + 12;
                combobox[i].Text = "None";
                // richtextbox
                richTextBoxes[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                richTextBoxes[i].Location = new Point(106, 14);
                richTextBoxes[i].Size = new Size(730, 162);
                richTextBoxes[i].Text = "";
                combobox[i].TabIndex = (i * 2) + 12;
                // label choice
                labelChoice[i].AutoSize = true;
                labelChoice[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                labelChoice[i].Location = new Point(12, 14);
                labelChoice[i].Size = new Size(71, 23);
                labelChoice[i].Text = "Choice " + (i + 1).ToString() + ": ";
                // label grade
                labelGrade[i].AutoSize = true;
                labelGrade[i].Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
    }
}
