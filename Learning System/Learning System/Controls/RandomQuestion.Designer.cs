namespace Learning_System
{
    partial class RandomQuestion
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
            RandomQuestion_Header = new Label();
            RandomQuestion_CategoryLbl = new Label();
            RandomQuestion_CategoryCbo = new ComboBox();
            RandomQuestion_SubcategoriesCbx = new CheckBox();
            RandomQuestion_NumberOfQuestionLbl = new Label();
            RandomQuestion_AddBtn = new Button();
            RandomQuestion_ButtonPanelPnl = new Panel();
            RandomQuestion_ShowQuestionDgv = new DataGridView();
            Icon = new DataGridViewImageColumn();
            Content = new DataGridViewTextBoxColumn();
            RandomQuestions_NumberOfRdQuestionsCbo = new ComboBox();
            RandomQuestion_ExitBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)RandomQuestion_ShowQuestionDgv).BeginInit();
            SuspendLayout();
            // 
            // RandomQuestion_Header
            // 
            RandomQuestion_Header.AutoSize = true;
            RandomQuestion_Header.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_Header.ForeColor = Color.FromArgb(194, 36, 36);
            RandomQuestion_Header.Location = new Point(3, 10);
            RandomQuestion_Header.Name = "RandomQuestion_Header";
            RandomQuestion_Header.Size = new Size(470, 60);
            RandomQuestion_Header.TabIndex = 18;
            RandomQuestion_Header.Text = "Add random questions";
            // 
            // RandomQuestion_CategoryLbl
            // 
            RandomQuestion_CategoryLbl.AutoSize = true;
            RandomQuestion_CategoryLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_CategoryLbl.Location = new Point(13, 79);
            RandomQuestion_CategoryLbl.Name = "RandomQuestion_CategoryLbl";
            RandomQuestion_CategoryLbl.Size = new Size(88, 25);
            RandomQuestion_CategoryLbl.TabIndex = 19;
            RandomQuestion_CategoryLbl.Text = "Category";
            // 
            // RandomQuestion_CategoryCbo
            // 
            RandomQuestion_CategoryCbo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_CategoryCbo.FormattingEnabled = true;
            RandomQuestion_CategoryCbo.Location = new Point(283, 79);
            RandomQuestion_CategoryCbo.Name = "RandomQuestion_CategoryCbo";
            RandomQuestion_CategoryCbo.Size = new Size(348, 33);
            RandomQuestion_CategoryCbo.TabIndex = 20;
            RandomQuestion_CategoryCbo.SelectedIndexChanged += RandomQuestion_CategoryCbo_SelectedIndexChanged;
            RandomQuestion_CategoryCbo.Click += RandomQuestion_CategoryCbo_Click;
            // 
            // RandomQuestion_SubcategoriesCbx
            // 
            RandomQuestion_SubcategoriesCbx.AutoSize = true;
            RandomQuestion_SubcategoriesCbx.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_SubcategoriesCbx.Location = new Point(283, 124);
            RandomQuestion_SubcategoriesCbx.Name = "RandomQuestion_SubcategoriesCbx";
            RandomQuestion_SubcategoriesCbx.Size = new Size(382, 29);
            RandomQuestion_SubcategoriesCbx.TabIndex = 26;
            RandomQuestion_SubcategoriesCbx.Text = "Include questions from subcategories too";
            RandomQuestion_SubcategoriesCbx.UseVisualStyleBackColor = true;
            RandomQuestion_SubcategoriesCbx.CheckedChanged += RandomQuestion_SubcategoriesCbx_CheckedChanged;
            // 
            // RandomQuestion_NumberOfQuestionLbl
            // 
            RandomQuestion_NumberOfQuestionLbl.AutoSize = true;
            RandomQuestion_NumberOfQuestionLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_NumberOfQuestionLbl.Location = new Point(13, 174);
            RandomQuestion_NumberOfQuestionLbl.Name = "RandomQuestion_NumberOfQuestionLbl";
            RandomQuestion_NumberOfQuestionLbl.Size = new Size(260, 25);
            RandomQuestion_NumberOfQuestionLbl.TabIndex = 27;
            RandomQuestion_NumberOfQuestionLbl.Text = "Number of random questions";
            // 
            // RandomQuestion_AddBtn
            // 
            RandomQuestion_AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RandomQuestion_AddBtn.AutoSize = true;
            RandomQuestion_AddBtn.BackColor = Color.FromArgb(0, 115, 165);
            RandomQuestion_AddBtn.Cursor = Cursors.Hand;
            RandomQuestion_AddBtn.FlatStyle = FlatStyle.Flat;
            RandomQuestion_AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_AddBtn.ForeColor = Color.White;
            RandomQuestion_AddBtn.Location = new Point(28, 732);
            RandomQuestion_AddBtn.Name = "RandomQuestion_AddBtn";
            RandomQuestion_AddBtn.Size = new Size(405, 48);
            RandomQuestion_AddBtn.TabIndex = 28;
            RandomQuestion_AddBtn.Text = "ADD RANDOM QUESTIONS TO THE QUIZ";
            RandomQuestion_AddBtn.UseVisualStyleBackColor = false;
            RandomQuestion_AddBtn.Click += RandomQuestion_AddBtn_Click;
            // 
            // RandomQuestion_ButtonPanelPnl
            // 
            RandomQuestion_ButtonPanelPnl.AutoSize = true;
            RandomQuestion_ButtonPanelPnl.Location = new Point(13, 247);
            RandomQuestion_ButtonPanelPnl.Name = "RandomQuestion_ButtonPanelPnl";
            RandomQuestion_ButtonPanelPnl.Size = new Size(497, 50);
            RandomQuestion_ButtonPanelPnl.TabIndex = 29;
            // 
            // RandomQuestion_ShowQuestionDgv
            // 
            RandomQuestion_ShowQuestionDgv.AllowUserToAddRows = false;
            RandomQuestion_ShowQuestionDgv.AllowUserToDeleteRows = false;
            RandomQuestion_ShowQuestionDgv.AllowUserToResizeColumns = false;
            RandomQuestion_ShowQuestionDgv.AllowUserToResizeRows = false;
            RandomQuestion_ShowQuestionDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            RandomQuestion_ShowQuestionDgv.BackgroundColor = Color.White;
            RandomQuestion_ShowQuestionDgv.BorderStyle = BorderStyle.Fixed3D;
            RandomQuestion_ShowQuestionDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RandomQuestion_ShowQuestionDgv.ColumnHeadersVisible = false;
            RandomQuestion_ShowQuestionDgv.Columns.AddRange(new DataGridViewColumn[] { Icon, Content });
            RandomQuestion_ShowQuestionDgv.GridColor = SystemColors.Control;
            RandomQuestion_ShowQuestionDgv.Location = new Point(13, 312);
            RandomQuestion_ShowQuestionDgv.Name = "RandomQuestion_ShowQuestionDgv";
            RandomQuestion_ShowQuestionDgv.ReadOnly = true;
            RandomQuestion_ShowQuestionDgv.RowHeadersVisible = false;
            RandomQuestion_ShowQuestionDgv.RowHeadersWidth = 51;
            RandomQuestion_ShowQuestionDgv.RowTemplate.Height = 29;
            RandomQuestion_ShowQuestionDgv.Size = new Size(1510, 401);
            RandomQuestion_ShowQuestionDgv.TabIndex = 30;
            // 
            // Icon
            // 
            Icon.HeaderText = "Column1";
            Icon.Image = Properties.Resources.list_;
            Icon.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Icon.MinimumWidth = 6;
            Icon.Name = "Icon";
            Icon.ReadOnly = true;
            Icon.Width = 50;
            // 
            // Content
            // 
            Content.HeaderText = "";
            Content.MinimumWidth = 6;
            Content.Name = "Content";
            Content.ReadOnly = true;
            Content.Width = 1350;
            // 
            // RandomQuestions_NumberOfRdQuestionsCbo
            // 
            RandomQuestions_NumberOfRdQuestionsCbo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestions_NumberOfRdQuestionsCbo.FormattingEnabled = true;
            RandomQuestions_NumberOfRdQuestionsCbo.Location = new Point(283, 173);
            RandomQuestions_NumberOfRdQuestionsCbo.Name = "RandomQuestions_NumberOfRdQuestionsCbo";
            RandomQuestions_NumberOfRdQuestionsCbo.Size = new Size(106, 33);
            RandomQuestions_NumberOfRdQuestionsCbo.TabIndex = 32;
            // 
            // RandomQuestion_ExitBtn
            // 
            RandomQuestion_ExitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RandomQuestion_ExitBtn.AutoSize = true;
            RandomQuestion_ExitBtn.BackColor = SystemColors.ControlLight;
            RandomQuestion_ExitBtn.BackgroundImageLayout = ImageLayout.Center;
            RandomQuestion_ExitBtn.Cursor = Cursors.Hand;
            RandomQuestion_ExitBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RandomQuestion_ExitBtn.ForeColor = SystemColors.ActiveCaptionText;
            RandomQuestion_ExitBtn.Location = new Point(435, 732);
            RandomQuestion_ExitBtn.Name = "RandomQuestion_ExitBtn";
            RandomQuestion_ExitBtn.Size = new Size(121, 48);
            RandomQuestion_ExitBtn.TabIndex = 34;
            RandomQuestion_ExitBtn.Text = "Cancel";
            RandomQuestion_ExitBtn.UseVisualStyleBackColor = false;
            RandomQuestion_ExitBtn.Click += RandomQuestion_ExitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 212);
            label1.Name = "label1";
            label1.Size = new Size(259, 25);
            label1.TabIndex = 34;
            label1.Text = "Questions matching this filter";
            // 
            // RandomQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(RandomQuestion_ExitBtn);
            Controls.Add(RandomQuestions_NumberOfRdQuestionsCbo);
            Controls.Add(RandomQuestion_ShowQuestionDgv);
            Controls.Add(RandomQuestion_ButtonPanelPnl);
            Controls.Add(RandomQuestion_AddBtn);
            Controls.Add(RandomQuestion_NumberOfQuestionLbl);
            Controls.Add(RandomQuestion_SubcategoriesCbx);
            Controls.Add(RandomQuestion_CategoryCbo);
            Controls.Add(RandomQuestion_CategoryLbl);
            Controls.Add(RandomQuestion_Header);
            Name = "RandomQuestion";
            Size = new Size(1647, 793);
            ((System.ComponentModel.ISupportInitialize)RandomQuestion_ShowQuestionDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RandomQuestion_Header;
        private Label RandomQuestion_CategoryLbl;
        private ComboBox RandomQuestion_CategoryCbo;
        private CheckBox RandomQuestion_SubcategoriesCbx;
        private Label RandomQuestion_NumberOfQuestionLbl;
        private Button RandomQuestion_AddBtn;
        private Panel RandomQuestion_ButtonPanelPnl;
        private DataGridView RandomQuestion_ShowQuestionDgv;
        private DataGridViewImageColumn Icon;
        private DataGridViewTextBoxColumn Content;
        private ComboBox RandomQuestions_NumberOfRdQuestionsCbo;
        private Button RandomQuestion_ExitBtn;
        private Label label1;
    }
}
