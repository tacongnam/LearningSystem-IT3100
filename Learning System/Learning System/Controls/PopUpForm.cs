namespace Learning_System
{
    public partial class PopUpForm : UserControl
    {
        public PopUpForm()
        {
            InitializeComponent();
        }

        private void Button_Questions_Click(object sender, EventArgs e)
        {
            if (PopUpForm_QuestionsBtn.Focused == true)
            {
                PopUpForm_QuestionsBtn.ForeColor = Color.Black;
                PopUpForm_CategoriesBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ImportBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ExportBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_QuestionsBtn.BackColor = Color.FromArgb(224, 224, 224);
                PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
            }
            CategoriesForm.Visible = false;
            ImportForm.Visible = false;
            ExportForm.Visible = false;
            QuestionsForm.Visible = true;
        }

        public void Show_Questions()
        {
            CategoriesForm.Visible = false;
            ImportForm.Visible = false;
            ExportForm.Visible = false;
            QuestionsForm.Visible = true;
            PopUpForm_QuestionsBtn.ForeColor = Color.Black;
            PopUpForm_CategoriesBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_ImportBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_ExportBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_QuestionsBtn.BackColor = Color.FromArgb(224, 224, 224);
            PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
        }

        public void Show_Categories()
        {
            QuestionsForm.Visible = false;
            ImportForm.Visible = false;
            ExportForm.Visible = false;
            CategoriesForm.Visible = true;
            PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_CategoriesBtn.ForeColor = Color.Black;
            PopUpForm_QuestionsBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_ImportBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_ExportBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_CategoriesBtn.BackColor = Color.FromArgb(224, 224, 224);
            PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
        }

        public void Show_Import()
        {
            PopUpForm_ImportBtn.ForeColor = Color.Black;
            PopUpForm_QuestionsBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_CategoriesBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_ExportBtn.ForeColor = Color.FromArgb(30, 170, 232);
            QuestionsForm.Visible = false;
            CategoriesForm.Visible = false;
            ExportForm.Visible = false;
            ImportForm.Visible = true;
            PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_ImportBtn.BackColor = Color.FromArgb(224, 224, 224);
            PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
        }

        public void Show_Export()
        {
            PopUpForm_ExportBtn.ForeColor = Color.Black;
            PopUpForm_QuestionsBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_CategoriesBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_ImportBtn.ForeColor = Color.FromArgb(30, 170, 232);
            QuestionsForm.Visible = false;
            CategoriesForm.Visible = false;
            ImportForm.Visible = false;
            ExportForm.Visible = true;
            PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
            PopUpForm_ExportBtn.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void Giao_dien_xem_danh_sach_cau_hoi_Load(object sender, EventArgs e)
        {
            if (PopUpForm_QuestionsBtn.Focused == true)
            {
                PopUpForm_QuestionsBtn.ForeColor = Color.Black;
                PopUpForm_CategoriesBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ImportBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ExportBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_QuestionsBtn.BackColor = Color.FromArgb(224, 224, 224);
                PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
            }
        }

        private void Button_Categories_Click(object sender, EventArgs e)
        {
            if (PopUpForm_CategoriesBtn.Focused == true)
            {
                PopUpForm_CategoriesBtn.ForeColor = Color.Black;
                PopUpForm_QuestionsBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ImportBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ExportBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_CategoriesBtn.BackColor = Color.FromArgb(224, 224, 224);
                PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
            }
            QuestionsForm.Visible = false;
            ImportForm.Visible = false;
            ExportForm.Visible = false;
            CategoriesForm.Visible = true;
        }

        private void Giao_dien_Categories_Load(object sender, EventArgs e)
        {
            if (PopUpForm_CategoriesBtn.Focused == true)
            {
                PopUpForm_CategoriesBtn.ForeColor = Color.Black;
                PopUpForm_QuestionsBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ImportBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ExportBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_CategoriesBtn.BackColor = Color.FromArgb(224, 224, 224);
                PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
            }
        }

        private void Button_Import_Click(object sender, EventArgs e)
        {
            if (PopUpForm_ImportBtn.Focused == true)
            {
                PopUpForm_ImportBtn.ForeColor = Color.Black;
                PopUpForm_QuestionsBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_CategoriesBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ExportBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ImportBtn.BackColor = Color.FromArgb(224, 224, 224);
                PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
            }
            QuestionsForm.Visible = false;
            CategoriesForm.Visible = false;
            ExportForm.Visible = false;
            ImportForm.Visible = true;
        }

        private void Giao_dien_Import_Load(object sender, EventArgs e)
        {
            if (PopUpForm_ImportBtn.Focused == true)
            {
                PopUpForm_ImportBtn.ForeColor = Color.Black;
                PopUpForm_QuestionsBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_CategoriesBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ExportBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ImportBtn.BackColor = Color.FromArgb(224, 224, 224);
                PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ExportBtn.BackColor = panel_chuc_nang.BackColor;
            }
        }

        private void Button_Export_Click(object sender, EventArgs e)
        {
            if (PopUpForm_ExportBtn.Focused == true)
            {
                PopUpForm_ExportBtn.ForeColor = Color.Black;
                PopUpForm_QuestionsBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_CategoriesBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ImportBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ExportBtn.BackColor = Color.FromArgb(224, 224, 224);
                PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
            }
            QuestionsForm.Visible = false;
            CategoriesForm.Visible = false;
            ImportForm.Visible = false;
            ExportForm.Visible = true;
        }

        private void Giao_dien_Export_Load(object sender, EventArgs e)
        {
            if (PopUpForm_ExportBtn.Focused == true)
            {
                PopUpForm_ExportBtn.ForeColor = Color.Black;
                PopUpForm_QuestionsBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_CategoriesBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ImportBtn.ForeColor = Color.FromArgb(30, 170, 232);
                PopUpForm_ExportBtn.BackColor = Color.FromArgb(224, 224, 224);
                PopUpForm_QuestionsBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_CategoriesBtn.BackColor = panel_chuc_nang.BackColor;
                PopUpForm_ImportBtn.BackColor = panel_chuc_nang.BackColor;
            }
        }
    }
}
