using Learning_System.Modals;
using Learning_System.ProcessingClasses;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Learning_System
{
    public partial class FromQuestionBank : UserControl
    {
        private EditQuiz ParentEditQuiz;

        private bool isLoad = false;
        public List<int> questionSelectedList = new List<int>();

        public DataProcessing questionsData = new();
        public DataProcessing categoriesData = new();
        public JArray _categoriesDataJarray = new();
        public FromQuestionBank(EditQuiz _EditQuiz)
        {
            InitializeComponent();

            FromQuestionBank_SelectCategoryCbo.Text = "  Default";
            ParentEditQuiz = _EditQuiz;
            FromQuestionBank_ShowQuestionsDtg.BorderStyle = BorderStyle.None;
            FromQuestionBank_ShowQuestionsDtg.Width = Screen.PrimaryScreen.WorkingArea.Width - 30;
            FromQuestionBank_ShowQuestionsDtg.Columns[1].Width = FromQuestionBank_ShowQuestionsDtg.Width - 130;
            FromQuestionBank_ShowQuestionsDtg.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_ShowQuestionsDtg.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_ShowQuestionsDtg.RowTemplate.Height = 35;
            FromQuestionBank_AddBtn.Location = new Point(FromQuestionBank_ShowQuestionsDtg.Location.X,
                FromQuestionBank_ShowQuestionsDtg.Location.Y + FromQuestionBank_ShowQuestionsDtg.Height + 50);
        }
        public void addData(DataProcessing _questionData, DataProcessing _categoriesData, JArray __categoriesDataJarray)
        {
            questionsData = QuestionsTable.table;
            categoriesData = CategoriesTable.table;
            _categoriesDataJarray = __categoriesDataJarray;
        }

        private void FromQuestionBank_CategoryCbo_DropDown(object sender, EventArgs e)
        {

        }

        //bien dung de gui id cua category dang duoc chon sang form edit question
        //private int SendParentIdToEditForm;
        //bien luu cac category duoc hien tren datagridview
        private List<int> selectedCategoriesIdList = new List<int>();
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

        public void showQuestions(List<int> showQuestionsFromCategoriesID, bool _showQuestionsFromSubcategories)
        {
            FromQuestionBank_ShowQuestionsDtg.Rows.Clear();

            try
            {
                if (questionsData.Length() == 0) MessageBox.Show("Không có câu hỏi nào trong Categories này!");
                else
                {
                    //var index = QuestionForm_ShowQuestionsDtg.Rows.Add();
                    //QuestionForm_ShowQuestionsDtg.Rows[index].Cells[1].Value = "Question name / ID number";
                    for (int i = 0; i < questionsData.Length(); i++)
                    {
                        DataRow? Question = questionsData.Init().Offset(i).Limit(1).Sort("ID desc").GetFirstRow();
                        if (Question == null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Can't get questions data:\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            if (dialogResult == DialogResult.OK)
                                System.Windows.Forms.Application.Exit();
                            return;
                        }
                        int inCategories = Question.Field<int>("CategoryID");
                        int QuestionID = Question.Field<int>("ID");
                        if ((showQuestionsFromCategoriesID.Contains(inCategories) && _showQuestionsFromSubcategories) || (showQuestionsFromCategoriesID[0] == inCategories && !showQuestionsFromSubcategories))
                        {
                            string? _QuestionName = Question.Field<string>("Content");

                            //                            DataGridViewRow row = (DataGridViewRow)QuestionForm_ShowQuestionsDtg.Rows[0].Clone();
                            var index = FromQuestionBank_ShowQuestionsDtg.Rows.Add();
                            DataGridViewRow row = FromQuestionBank_ShowQuestionsDtg.Rows[index];
                            //
                            RichTextBox tmp = new RichTextBox();
                            tmp.Visible = false;
                            try
                            {
                                tmp.Rtf = _QuestionName;
                                row.Cells[1].Value = tmp.Text;
                            }
                            catch
                            {
                                row.Cells[1].Value = _QuestionName;
                            }
                            row.Cells[2].Value = QuestionID;
                            if (i % 2 == 0) row.DefaultCellStyle.BackColor = Color.White;
                            else row.DefaultCellStyle.BackColor = Color.AliceBlue;

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Can't get questions data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.OK)
                    System.Windows.Forms.Application.Exit();
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

            FromQuestionBank_SelectCategoryCbo.ValueMember = "Id";
            FromQuestionBank_SelectCategoryCbo.DisplayMember = "Name";
            FromQuestionBank_SelectCategoryCbo.DataSource = onlyCategoriesName;
            FromQuestionBank_SelectCategoryCbo.DrawItem += new DrawItemEventHandler((sender, args) =>
            {
                System.Drawing.Font font;
                FontFamily ffm = FromQuestionBank_SelectCategoryCbo.Font.FontFamily;
                float fsz = FromQuestionBank_SelectCategoryCbo.Font.Size;

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

        private void FromQuestionBank_SelectCategoryCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FromQuestionBank_SelectCategoryCbo.SelectedItem == null) return;
            var a = (Categories)FromQuestionBank_SelectCategoryCbo.SelectedItem;
            selectedCategoriesIdList.Clear();
            int _parentCategories = a.Id;
            //
            //SendParentIdToEditForm = _parentCategories;
            //
            try
            {
                JArray? _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("Category.json", null, null);
                if (_categoriesDataJarray == null) return;
                List<Categories>? categories = _categoriesDataJarray.ToObject<List<Categories>>();
                if (categories == null || _categoriesDataJarray == null) return;
                if (_parentCategories >= 0)
                {
                    selectedCategoriesIdList.Add(_parentCategories);
                    GetSubCategories(_parentCategories, ref selectedCategoriesIdList, ref categories);
                    showQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
                }
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show("Can't get categories data:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialog == DialogResult.OK)
                    System.Windows.Forms.Application.Exit();
            }
        }

        /*private void QuestionsForm_ShowFromSubcategoriesCb_CheckedChanged(object sender, EventArgs e)
        {
            showQuestionsFromSubcategories = QuestionsForm_ShowFromSubcategoriesCb.Checked;
            showQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
        }*/

        private void FromQuestionBank_SubcategoriesCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (FromQuestionBank_SelectCategoryCbo.SelectedIndex == -1)
            {
                FromQuestionBank_SubcategoriesCbx.Checked = false;
                return;
            }
            else
            {
                showQuestionsFromSubcategories = FromQuestionBank_SubcategoriesCbx.Checked;
                showQuestions(selectedCategoriesIdList, showQuestionsFromSubcategories);
            }
        }

        private void FromQuestionBank_SelectCategoryCbo_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isLoad)
            {
                isLoad = true;
                LoadCategoriesData();
            }
        }

        private void FromQuestionBank_AddBtn_Click_1(object sender, EventArgs e)
        {
            questionSelectedList.Clear();
            for (int i = 0; i < FromQuestionBank_ShowQuestionsDtg.RowCount; i++)
            {
                DataGridViewRow row = FromQuestionBank_ShowQuestionsDtg.Rows[i];
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    questionSelectedList.Add(Convert.ToInt32(row.Cells[2].Value));
                }
            }
            this.SendToBack();
            ParentEditQuiz.loadQuestionID(questionSelectedList);
            FromQuestionBank_SelectCategoryCbo.Text = "  Default";
            if (FromQuestionBank_SubcategoriesCbx.Checked == true)
            { FromQuestionBank_SubcategoriesCbx.Checked = false; }
        }

        private void RandomQuestion_ExitBtn_Click(object sender, EventArgs e)
        {
            questionSelectedList.Clear();
            this.SendToBack();
        }

        private void FromQuestionBank_ShowQuestionsDtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Select "Select All" cell
                if (e.RowIndex == -1 && e.ColumnIndex == 0)
                {
                    if (FromQuestionBank_ShowQuestionsDtg.Rows.Count == 0)
                        return;

                    FromQuestionBank_ShowQuestionsDtg.CurrentCell = FromQuestionBank_ShowQuestionsDtg.CurrentRow.Cells[1];
                    foreach (DataGridViewRow row in FromQuestionBank_ShowQuestionsDtg.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                        if (chk.Value == null || Convert.ToBoolean(chk.Value) == false)
                            chk.Value = (object)true;
                        else
                            chk.Value = (object)false;

                        // chk.Value = !(chk.Value == null ? false : (bool)chk.Value); //because chk.Value is initialy null
                    }

                }
            }
            catch { return; }
        }

    }
}
