namespace Learning_System
{
    partial class PopUpForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PopUpForm_ExportBtn = new Button();
            PopUpForm_ImportBtn = new Button();
            PopUpForm_CategoriesBtn = new Button();
            PopUpForm_QuestionsBtn = new Button();
            ExportForm = new ExportForm();
            panel_chuc_nang = new Panel();
            QuestionsForm = new QuestionsForm();
            CategoriesForm = new CategoriesForm();
            ImportForm = new ImportForm();
            panel_giao_dien = new Panel();
            panel_chuc_nang.SuspendLayout();
            panel_giao_dien.SuspendLayout();
            SuspendLayout();
            // 
            // PopUpForm_ExportBtn
            // 
            PopUpForm_ExportBtn.FlatAppearance.BorderSize = 0;
            PopUpForm_ExportBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            PopUpForm_ExportBtn.FlatStyle = FlatStyle.Flat;
            PopUpForm_ExportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_ExportBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_ExportBtn.Location = new Point(560, 3);
            PopUpForm_ExportBtn.Name = "PopUpForm_ExportBtn";
            PopUpForm_ExportBtn.Size = new Size(187, 61);
            PopUpForm_ExportBtn.TabIndex = 3;
            PopUpForm_ExportBtn.Text = "Export";
            PopUpForm_ExportBtn.UseVisualStyleBackColor = true;
            PopUpForm_ExportBtn.Click += Button_Export_Click;
            PopUpForm_ExportBtn.Cursor = Cursors.Hand;
            // 
            // PopUpForm_ImportBtn
            // 
            PopUpForm_ImportBtn.FlatAppearance.BorderSize = 0;
            PopUpForm_ImportBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            PopUpForm_ImportBtn.FlatStyle = FlatStyle.Flat;
            PopUpForm_ImportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_ImportBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_ImportBtn.Location = new Point(373, 3);
            PopUpForm_ImportBtn.Name = "PopUpForm_ImportBtn";
            PopUpForm_ImportBtn.Size = new Size(187, 61);
            PopUpForm_ImportBtn.TabIndex = 2;
            PopUpForm_ImportBtn.Text = "Import";
            PopUpForm_ImportBtn.UseVisualStyleBackColor = true;
            PopUpForm_ImportBtn.Click += Button_Import_Click;
            PopUpForm_ImportBtn.Cursor = Cursors.Hand;
            // 
            // PopUpForm_CategoriesBtn
            // 
            PopUpForm_CategoriesBtn.FlatAppearance.BorderSize = 0;
            PopUpForm_CategoriesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            PopUpForm_CategoriesBtn.FlatStyle = FlatStyle.Flat;
            PopUpForm_CategoriesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_CategoriesBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_CategoriesBtn.Location = new Point(186, 3);
            PopUpForm_CategoriesBtn.Name = "PopUpForm_CategoriesBtn";
            PopUpForm_CategoriesBtn.Size = new Size(187, 61);
            PopUpForm_CategoriesBtn.TabIndex = 1;
            PopUpForm_CategoriesBtn.Text = "Categories";
            PopUpForm_CategoriesBtn.UseVisualStyleBackColor = true;
            PopUpForm_CategoriesBtn.Click += Button_Categories_Click;
            PopUpForm_CategoriesBtn.Cursor = Cursors.Hand;
            // 
            // PopUpForm_QuestionsBtn
            // 
            PopUpForm_QuestionsBtn.FlatAppearance.BorderSize = 0;
            PopUpForm_QuestionsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            PopUpForm_QuestionsBtn.FlatStyle = FlatStyle.Flat;
            PopUpForm_QuestionsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PopUpForm_QuestionsBtn.ForeColor = Color.FromArgb(30, 170, 232);
            PopUpForm_QuestionsBtn.Location = new Point(-1, 3);
            PopUpForm_QuestionsBtn.Name = "PopUpForm_QuestionsBtn";
            PopUpForm_QuestionsBtn.Size = new Size(187, 61);
            PopUpForm_QuestionsBtn.TabIndex = 0;
            PopUpForm_QuestionsBtn.Text = "Questions";
            PopUpForm_QuestionsBtn.UseVisualStyleBackColor = true;
            PopUpForm_QuestionsBtn.Click += Button_Questions_Click;
            PopUpForm_QuestionsBtn.Cursor = Cursors.Hand;
            // 
            // ExportForm
            // 
            ExportForm.AutoScroll = true;
            ExportForm.BackColor = SystemColors.ControlLightLight;
            ExportForm.Dock = DockStyle.Fill;
            ExportForm.Location = new Point(0, 0);
            ExportForm.Name = "ExportForm";
            ExportForm.Size = new Size(1089, 555);
            ExportForm.TabIndex = 4;
            ExportForm.Visible = false;
            ExportForm.Load += Giao_dien_Export_Load;
            // 
            // panel_chuc_nang
            // 
            panel_chuc_nang.BackColor = SystemColors.ControlLightLight;
            panel_chuc_nang.Controls.Add(PopUpForm_QuestionsBtn);
            panel_chuc_nang.Controls.Add(PopUpForm_ImportBtn);
            panel_chuc_nang.Controls.Add(PopUpForm_ExportBtn);
            panel_chuc_nang.Controls.Add(PopUpForm_CategoriesBtn);
            panel_chuc_nang.Dock = DockStyle.Top;
            panel_chuc_nang.Location = new Point(0, 0);
            panel_chuc_nang.Name = "panel_chuc_nang";
            panel_chuc_nang.Size = new Size(1089, 70);
            panel_chuc_nang.TabIndex = 4;
            panel_chuc_nang.Paint += Panel_chuc_nang_Paint;
            // 
            // QuestionsForm
            // 
            QuestionsForm.AutoScroll = true;
            QuestionsForm.BackColor = SystemColors.ControlLightLight;
            QuestionsForm.Dock = DockStyle.Fill;
            QuestionsForm.Location = new Point(0, 0);
            QuestionsForm.Name = "QuestionsForm";
            QuestionsForm.Size = new Size(1089, 555);
            QuestionsForm.TabIndex = 0;
            QuestionsForm.Load += Giao_dien_xem_danh_sach_cau_hoi_Load;
            // 
            // CategoriesForm
            // 
            CategoriesForm.AutoScroll = true;
            CategoriesForm.BackColor = SystemColors.ControlLightLight;
            CategoriesForm.Dock = DockStyle.Fill;
            CategoriesForm.Location = new Point(0, 0);
            CategoriesForm.Name = "CategoriesForm";
            CategoriesForm.Size = new Size(1089, 555);
            CategoriesForm.TabIndex = 4;
            CategoriesForm.Visible = false;
            CategoriesForm.Load += Giao_dien_Categories_Load;
            // 
            // ImportForm
            // 
            ImportForm.AutoScroll = true;
            ImportForm.Dock = DockStyle.Fill;
            ImportForm.Location = new Point(0, 0);
            ImportForm.Name = "ImportForm";
            ImportForm.Size = new Size(1089, 555);
            ImportForm.TabIndex = 4;
            ImportForm.Visible = false;
            ImportForm.Load += Giao_dien_Import_Load;
            // 
            // panel_giao_dien
            // 
            panel_giao_dien.Controls.Add(QuestionsForm);
            panel_giao_dien.Controls.Add(ImportForm);
            panel_giao_dien.Controls.Add(ExportForm);
            panel_giao_dien.Controls.Add(CategoriesForm);
            panel_giao_dien.Dock = DockStyle.Fill;
            panel_giao_dien.Location = new Point(0, 70);
            panel_giao_dien.Name = "panel_giao_dien";
            panel_giao_dien.Size = new Size(1089, 555);
            panel_giao_dien.TabIndex = 5;
            // 
            // PopUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_giao_dien);
            Controls.Add(panel_chuc_nang);
            Name = "PopUpForm";
            Size = new Size(1089, 625);
            panel_chuc_nang.ResumeLayout(false);
            panel_giao_dien.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Panel_chuc_nang_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel_chuc_nang.ClientRectangle,
                    Color.LightBlue, 0, ButtonBorderStyle.Solid,
                    Color.LightBlue, 0, ButtonBorderStyle.Solid,
                    Color.LightBlue, 0, ButtonBorderStyle.Solid,
                    Color.Black, 1, ButtonBorderStyle.Solid);
        }

        #endregion
        private Button PopUpForm_ExportBtn;
        private Button PopUpForm_ImportBtn;
        private Button PopUpForm_CategoriesBtn;
        private Button PopUpForm_QuestionsBtn;
        private ExportForm ExportForm;
        private Panel panel_chuc_nang;
        private QuestionsForm QuestionsForm;
        private CategoriesForm CategoriesForm;
        private ImportForm ImportForm;
        private Panel panel_giao_dien;
    }
}