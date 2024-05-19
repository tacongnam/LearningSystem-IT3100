using Learning_System.Modals;
using Learning_System.ProcessingClasses;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Learning_System
{
    public partial class CategoriesForm : UserControl
    {
        bool _firstLoad = false;

        public void LoadCombobox()
        {
            DataTable? dt;

            // Only load from file first time   
            if (_firstLoad == false)
            {
                try
                {
                    JArray? _categoriesData = JsonProcessing.ImportJsonContentInDefaultFolder("category.json", null, null);

                    if (_categoriesData == null)
                        throw new E01CantFindFile("category.json");

                    CategoriesTable.table.Import(_categoriesData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't load category list.\nDescription: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _firstLoad = true;
            }

            dt = CategoriesTable.table.Init().Get();
            CategoriesForm_ParentCategoryCbo.ValueMember = "Id";
            CategoriesForm_ParentCategoryCbo.DisplayMember = "Name";
            CategoriesForm_ParentCategoryCbo.DataSource = dt;
            CategoriesForm_ParentCategoryCbo.SelectedIndex = -1;
            CategoriesForm_ParentCategoryCbo.SelectedText = "Default";
        }

        public CategoriesForm()
        {
            InitializeComponent();
            LoadCombobox();
        }

        private void CategoriesForm_AddCategoryBtn_Click(object sender, EventArgs e)
        {
            var _parentId = CategoriesForm_ParentCategoryCbo.SelectedValue;
            var _name = CategoriesForm_NameTxt.Text;
            var _description = CategoriesForm_CategoryInfoTxt.Text;
            var _id = CategoriesForm_IDNumberTxt.Text;

            string _errorNoti = "";
            if (_name == null || _name == "")
            {
                if (_errorNoti.Length > 0)
                    _errorNoti += ", ";
                _errorNoti += "Category's Name";
            }

            if (_errorNoti != "")
            {
                MessageBox.Show("Please don't leave these blank: " + _errorNoti, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Categories _newCategory = new()
                    {
                        Id = CategoriesTable.table.Length(),
                        Name = _name,
                        SubArray = new List<int>(),
                        QuestionArray = new List<int>(),
                        Description = _description,
                        IdNumber = _id
                    };

                    if (CategoriesTable.table.Insert(JObject.FromObject(_newCategory)) == DataProcessing.StatusCode.Error)
                        throw new E05CantInsertProperly();

                    // Nếu chọn giá trị parent là default, tự động gán category vào 0. Nếu không, set nó thành category mới.
                    if (_parentId != null)
                    {
                        List<string> _query = new() { "Id", _parentId.ToString() };
                        DataTable? _chkDT = CategoriesTable.table.Init().Query(_query).Get();
                        if (_chkDT == null)
                            throw new E02CantProcessQuery();

                        // Không có category nào thỏa mãn Id (lỗi?)
                        if (_chkDT.Rows.Count == 0)
                            throw new E99OtherException("Can't find your selected parent category value!");

                        DataRow? _parentRow = _chkDT.Rows[0];

                        if (_parentRow == null)
                            throw new E02CantProcessQuery();
                        else
                        {
                            var _x = _parentRow.Field<JArray>("SubArray");
                            if (_x != null)
                                _x.Add(_newCategory.Id);
                            else
                                throw new E03NotExistColumn("SubArray");

                            JObject x = DataProcessing.ConvertDataRowToJObject(_parentRow);

                            if (CategoriesTable.table.Init().Offset(0).Limit(1).Query(_query).Update(x) == DataProcessing.StatusCode.Error)
                                throw new E02CantProcessQuery();
                        }
                    }

                    CategoriesForm_ParentCategoryCbo.ValueMember = "Id";
                    CategoriesForm_ParentCategoryCbo.DisplayMember = "Name";
                    CategoriesForm_ParentCategoryCbo.DataSource = CategoriesTable.table.Init().Get();
                    CategoriesForm_ParentCategoryCbo.SelectedIndex = -1;
                    CategoriesForm_ParentCategoryCbo.SelectedText = "Default";


                    if (JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", CategoriesTable.table.Export()) == null)
                        throw new E04CantExportProperly();

                    MessageBox.Show("Add new category successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CategoriesForm_NameTxt.Text = "";
                    CategoriesForm_CategoryInfoTxt.Text = "";
                    CategoriesForm_IDNumberTxt.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add failed!\nDescription: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
