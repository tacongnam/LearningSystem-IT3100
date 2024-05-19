
using Learning_System.Modals;
using Learning_System.ProcessingClasses;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Learning_System
{
    public partial class QuestionsForm : UserControl
    {
        //bien luu cac category duoc hien tren datagridview
        private List<int> selectedCategoriesIdList = new();
        // bien co hien cau hoi tu category con hay khong
        private bool showQuestionsFromSubcategories = false;
        private void GetSubCategories(int _parentCategories, ref List<int> _subCategories, ref List<Categories> categories)
        {
            foreach (int x in categories[_parentCategories].SubArray)
            {
                _subCategories.Add(x);
                GetSubCategories(x, ref _subCategories, ref categories);
            }
        }

        public void ShowQuestions(List<int> showQuestionsFromCategoriesID, bool _showQuestionsFromSubcategories)
        {
            QuestionForm_ShowQuestionsDtg.Rows.Clear();

            if (showQuestionsFromCategoriesID.Count == 0)
                return;

            try
            {
                QuestionsTable.table.LoadData(JsonProcessing.QuestionsPath);

                if (QuestionsTable.table.Length() == 0) MessageBox.Show("Không có câu hỏi nào trong Categories này!");
                else
                {
                    //var index = QuestionForm_ShowQuestionsDtg.Rows.Add();
                    //QuestionForm_ShowQuestionsDtg.Rows[index].Cells[1].Value = "Question name / ID number";
                    for (int i = 0; i < QuestionsTable.table.Length(); i++)
                    {
                        DataRow? Question = QuestionsTable.table.Init().Offset(i).Limit(1).Sort("ID desc").GetFirstRow();
                        if (Question == null)
                            throw new E02CantProcessQuery();

                        int inCategories = Question.Field<int>("CategoryID");
                        int QuestionID = Question.Field<int>("ID");
                        if ((showQuestionsFromCategoriesID.Contains(inCategories) && _showQuestionsFromSubcategories) || (showQuestionsFromCategoriesID[0] == inCategories && !showQuestionsFromSubcategories))
                        {
                            string? _QuestionName = Question.Field<string>("Content");
                            var index = QuestionForm_ShowQuestionsDtg.Rows.Add();
                            DataGridViewRow row = QuestionForm_ShowQuestionsDtg.Rows[index];

                            RichTextBox tmp = new()
                            {
                                Visible = false
                            };
                            try
                            {
                                tmp.Rtf = _QuestionName;
                                row.Cells[1].Value = tmp.Text;
                            }
                            catch
                            {
                                row.Cells[1].Value = _QuestionName;
                            }
                            row.Cells[2].Value = "Edit";

                            DataGridViewButtonCell c = (DataGridViewButtonCell)row.Cells[2];
                            c.FlatStyle = FlatStyle.Flat;
                            if (i % 2 == 0)
                                c.Style.BackColor = Color.White;
                            else
                                c.Style.BackColor = Color.AliceBlue;
                            c.Style.ForeColor = Color.FromArgb(30, 170, 232);
                            c.Style.Font = new("Segoe UI", 11F, FontStyle.Bold);
                            c.Style.Padding = new Padding(0);

                            row.Cells[3].Value = QuestionID;
                            row.Cells[4].Value = inCategories;
                            if (i % 2 == 0) row.DefaultCellStyle.BackColor = Color.White;
                            else row.DefaultCellStyle.BackColor = Color.AliceBlue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuestionForm_ShowQuestionsDtg.Enabled = false;
                QuestionsForm_CreateNewQuestionBtn.Enabled = false;
                QuestionsForm_ShowFromSubcategoriesCb.Enabled = false;
            }
        }

        public struct CboList
        {
            public Categories category;
            public int loaded;
        }

        public void LoadCategoriesData()
        {
            List<CboList>? listCategories = new();
            List<CboList> newListCategories = new();
            try
            {
                DataTable _dt = CategoriesTable.table.Init().Get();

                if (_dt == null) return;

                foreach (DataRow _row in _dt.Rows)
                {
                    CboList _c = new();
                    _c.category = new Categories();

                    _c.category.Id = _row.Field<int>("Id");
                    _c.category.Name = _row.Field<string>("Name");
                    _c.category.QuestionArray = _row.Field<JArray>("QuestionArray").ToObject<List<int>>();
                    _c.category.SubArray = _row.Field<JArray>("SubArray").ToObject<List<int>>();

                    _c.loaded = 0;
                    listCategories.Add(_c);
                }

                /*
                List<Categories>? _tmp;

                JArray? _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
                if (_categoriesData == null)
                    throw new E01CantFindFile("category.json");

                _tmp = _categoriesData.ToObject<List<Categories>>();

                if (_tmp == null) return;

                foreach (Categories _x in _tmp)
                {
                    CboList _c = new();
                    _c.category = _x;
                    _c.loaded = 0;

                    listCategories.Add(_c);
                }
                */
                for (int i = 0; i < listCategories.Count; i++)
                    if (listCategories[i].loaded == 0)
                    {
                        listCategories[i] = new CboList
                        {
                            category = listCategories[i].category,
                            loaded = -1
                        };

                        AddSpace(ref newListCategories, ref listCategories, i, "  ");
                    }

                newListCategories.Reverse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Categories> onlyCategoriesName = new List<Categories>();
            foreach (CboList _x in newListCategories)
                onlyCategoriesName.Add(_x.category);

            QuestionsForm_SelectCategoryCbo.ValueMember = "Id";
            QuestionsForm_SelectCategoryCbo.DisplayMember = "Name";
            QuestionsForm_SelectCategoryCbo.DataSource = onlyCategoriesName;
            QuestionsForm_SelectCategoryCbo.DrawItem += new DrawItemEventHandler((sender, args) =>
            {
                System.Drawing.Font font;
                FontFamily ffm = QuestionsForm_SelectCategoryCbo.Font.FontFamily;
                float fsz = QuestionsForm_SelectCategoryCbo.Font.Size;

                if (newListCategories.Count > args.Index)
                {
                    if (newListCategories[args.Index].loaded == -1)
                        font = new System.Drawing.Font(ffm, fsz, FontStyle.Bold);
                    else
                        font = new System.Drawing.Font(ffm, fsz, FontStyle.Regular);

                    if ((args.State & DrawItemState.Selected) == DrawItemState.Selected)
                    {
                        args.DrawBackground();
                        args.Graphics.DrawString(newListCategories[args.Index].category.Name, font, SystemBrushes.Window, args.Bounds);
                    }
                    else
                    {
                        args.DrawBackground();
                        args.Graphics.DrawString(newListCategories[args.Index].category.Name, font, SystemBrushes.WindowText, args.Bounds);
                    }
                }
            });
        }

        //Them Space cho cac lua chon Combobox
        public void AddSpace(ref List<CboList> List, ref List<CboList> addList, int begin, string space)
        {
            if (addList[begin].loaded == 0)
                addList[begin] = new CboList
                {
                    category = addList[begin].category,
                    loaded = 1
                };

            foreach (int x in addList[begin].category.SubArray)
            {
                addList[x].category.Name = space + addList[x].category.Name;
                AddSpace(ref List, ref addList, x, space + "  ");
            }
            addList[begin].category.Name = "  " + addList[begin].category.Name;

            if (addList[begin].category.QuestionArray.Count > 0)
                addList[begin].category.Name = addList[begin].category.Name + " (" + addList[begin].category.QuestionArray.Count + ")";
            List.Add(addList[begin]);
        }

        public QuestionsForm()
        {
            InitializeComponent();
            LoadCategoriesData();

            QuestionsForm_SelectCategoryCbo.SelectedIndex = -1;
            QuestionsForm_SelectCategoryCbo.SelectedText = "  Default";
            QuestionForm_ShowQuestionsDtg.Width = Screen.PrimaryScreen.WorkingArea.Width - 100;
            QuestionForm_ShowQuestionsDtg.Columns[1].Width = QuestionForm_ShowQuestionsDtg.Width - 230;
            QuestionForm_ShowQuestionsDtg.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionForm_ShowQuestionsDtg.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionForm_ShowQuestionsDtg.RowTemplate.Height = 35;
        }

        private void QuestionsForm_SelectCategoryCbo_ClickOrDropDown(object sender, EventArgs e)
        {
            LoadCategoriesData();
        }

        private void QuestionsForm_CreateNewQuestionBtn_Click(object sender, EventArgs e)
        {
            AddNewQuestionForm addNewQuestionForm = new();
            addNewQuestionForm.ShowDialog();
            ShowQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
        }

        private void QuestionsForm_SelectCategoryCbo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (QuestionsForm_SelectCategoryCbo.SelectedItem == null) return;

            var a = (Categories)QuestionsForm_SelectCategoryCbo.SelectedItem;

            selectedCategoriesIdList.Clear();
            int _parentCategories = a.Id;
            try
            {
                JArray? _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
                if (_categoriesData == null)
                    throw new E01CantFindFile("Category.json");

                List<Categories>? categories = _categoriesData.ToObject<List<Categories>>();
                if (categories == null) return;

                if (_parentCategories >= 0)
                {
                    selectedCategoriesIdList.Add(_parentCategories);
                    GetSubCategories(_parentCategories, ref selectedCategoriesIdList, ref categories);
                    ShowQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get categories data!\nDescription: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void QuestionsForm_ShowFromSubcategoriesCb_CheckedChanged(object sender, EventArgs e)
        {
            showQuestionsFromSubcategories = QuestionsForm_ShowFromSubcategoriesCb.Checked;
            ShowQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
        }

        private void QuestionForm_ShowQuestionsDtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (QuestionForm_ShowQuestionsDtg.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            {
                var a = QuestionForm_ShowQuestionsDtg.Rows[e.RowIndex];
                EditQuestionForm editQuestionForm = new(Convert.ToInt32(a.Cells[3].Value), Convert.ToInt32(a.Cells[4].Value));
                editQuestionForm.ShowDialog();
                ShowQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
            }
        }

        private void QuestionForm_ShowQuestionsDtg_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            var dataGridView = (sender as DataGridView);
            //Check the condition as per the requirement casting the cell value to the appropriate type
            if (e.ColumnIndex == 2)
            {
                var gridCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                gridCell.Style.ForeColor = Color.White;
                gridCell.Style.Font = new("Segoe UI", 11, FontStyle.Bold | FontStyle.Underline);
            }
        }

        private void QuestionForm_ShowQuestionsDtg_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            var dataGridView = (sender as DataGridView);
            //Check the condition as per the requirement casting the cell value to the appropriate type
            if (e.ColumnIndex == 2)
            {
                var gridCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                gridCell.Style.ForeColor = Color.FromArgb(30, 170, 232);
                gridCell.Style.Font = new("Segoe UI", 11, FontStyle.Bold);
            }
        }
    }
}