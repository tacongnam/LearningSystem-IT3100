
namespace Learning_System
{
    partial class FromQuestionBank
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            FromQuestionBank_ExitBtn = new Button();
            FromQuestionBank_ShowQuestionsDtg = new DataGridView();
            FromQuestionBank_AddBtn = new Button();
            FromQuestionBank_OldQuestionCbx = new CheckBox();
            FromQuestionBank_SubcategoriesCbx = new CheckBox();
            FromQuestionBank_OptionLbl = new Label();
            FromQuestionBank_SelectCategoryCbo = new ComboBox();
            FromQuestionBank_CategoryLbl = new Label();
            FromQuestionBank_Header = new Label();
            Checkbox = new DataGridViewCheckBoxColumn();
            Content = new DataGridViewTextBoxColumn();
            QuestionID = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FromQuestionBank_ShowQuestionsDtg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(FromQuestionBank_ExitBtn);
            panel1.Controls.Add(FromQuestionBank_ShowQuestionsDtg);
            panel1.Controls.Add(FromQuestionBank_AddBtn);
            panel1.Controls.Add(FromQuestionBank_OldQuestionCbx);
            panel1.Controls.Add(FromQuestionBank_SubcategoriesCbx);
            panel1.Controls.Add(FromQuestionBank_OptionLbl);
            panel1.Controls.Add(FromQuestionBank_SelectCategoryCbo);
            panel1.Controls.Add(FromQuestionBank_CategoryLbl);
            panel1.Controls.Add(FromQuestionBank_Header);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 761);
            panel1.TabIndex = 0;
            // 
            // FromQuestionBank_ExitBtn
            // 
            FromQuestionBank_ExitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FromQuestionBank_ExitBtn.AutoSize = true;
            FromQuestionBank_ExitBtn.BackColor = SystemColors.ControlLight;
            FromQuestionBank_ExitBtn.BackgroundImageLayout = ImageLayout.Center;
            FromQuestionBank_ExitBtn.Cursor = Cursors.Hand;
            FromQuestionBank_ExitBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_ExitBtn.ForeColor = SystemColors.ActiveCaptionText;
            FromQuestionBank_ExitBtn.Location = new Point(440, 695);
            FromQuestionBank_ExitBtn.Name = "FromQuestionBank_ExitBtn";
            FromQuestionBank_ExitBtn.Size = new Size(121, 50);
            FromQuestionBank_ExitBtn.TabIndex = 34;
            FromQuestionBank_ExitBtn.Text = "Cancel";
            FromQuestionBank_ExitBtn.UseVisualStyleBackColor = false;
            FromQuestionBank_ExitBtn.Click += RandomQuestion_ExitBtn_Click;
            // 
            // FromQuestionBank_ShowQuestionsDtg
            // 
            FromQuestionBank_ShowQuestionsDtg.AllowUserToAddRows = false;
            FromQuestionBank_ShowQuestionsDtg.AllowUserToDeleteRows = false;
            FromQuestionBank_ShowQuestionsDtg.AllowUserToResizeColumns = false;
            FromQuestionBank_ShowQuestionsDtg.AllowUserToResizeRows = false;
            FromQuestionBank_ShowQuestionsDtg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FromQuestionBank_ShowQuestionsDtg.BackgroundColor = SystemColors.ButtonHighlight;
            FromQuestionBank_ShowQuestionsDtg.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            FromQuestionBank_ShowQuestionsDtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            FromQuestionBank_ShowQuestionsDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FromQuestionBank_ShowQuestionsDtg.Columns.AddRange(new DataGridViewColumn[] { Checkbox, Content, QuestionID });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            FromQuestionBank_ShowQuestionsDtg.DefaultCellStyle = dataGridViewCellStyle2;
            FromQuestionBank_ShowQuestionsDtg.Location = new Point(14, 243);
            FromQuestionBank_ShowQuestionsDtg.Margin = new Padding(2);
            FromQuestionBank_ShowQuestionsDtg.Name = "FromQuestionBank_ShowQuestionsDtg";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            FromQuestionBank_ShowQuestionsDtg.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            FromQuestionBank_ShowQuestionsDtg.RowHeadersVisible = false;
            FromQuestionBank_ShowQuestionsDtg.RowHeadersWidth = 4;
            FromQuestionBank_ShowQuestionsDtg.RowTemplate.Height = 33;
            FromQuestionBank_ShowQuestionsDtg.Size = new Size(1236, 434);
            FromQuestionBank_ShowQuestionsDtg.TabIndex = 36;
            FromQuestionBank_ShowQuestionsDtg.CellClick += FromQuestionBank_ShowQuestionsDtg_CellClick;
            // 
            // FromQuestionBank_AddBtn
            // 
            FromQuestionBank_AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FromQuestionBank_AddBtn.BackColor = Color.FromArgb(0, 115, 165);
            FromQuestionBank_AddBtn.Cursor = Cursors.Hand;
            FromQuestionBank_AddBtn.FlatStyle = FlatStyle.Flat;
            FromQuestionBank_AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_AddBtn.ForeColor = Color.White;
            FromQuestionBank_AddBtn.Location = new Point(14, 695);
            FromQuestionBank_AddBtn.Name = "FromQuestionBank_AddBtn";
            FromQuestionBank_AddBtn.Size = new Size(420, 50);
            FromQuestionBank_AddBtn.TabIndex = 35;
            FromQuestionBank_AddBtn.Text = "ADD SELECTED QUESTIONS TO THE QUIZ";
            FromQuestionBank_AddBtn.UseVisualStyleBackColor = false;
            FromQuestionBank_AddBtn.Click += FromQuestionBank_AddBtn_Click_1;
            // 
            // FromQuestionBank_OldQuestionCbx
            // 
            FromQuestionBank_OldQuestionCbx.AutoSize = true;
            FromQuestionBank_OldQuestionCbx.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_OldQuestionCbx.Location = new Point(18, 209);
            FromQuestionBank_OldQuestionCbx.Name = "FromQuestionBank_OldQuestionCbx";
            FromQuestionBank_OldQuestionCbx.Size = new Size(237, 29);
            FromQuestionBank_OldQuestionCbx.TabIndex = 34;
            FromQuestionBank_OldQuestionCbx.Text = "Also show old questions";
            FromQuestionBank_OldQuestionCbx.UseVisualStyleBackColor = true;
            // 
            // FromQuestionBank_SubcategoriesCbx
            // 
            FromQuestionBank_SubcategoriesCbx.AutoSize = true;
            FromQuestionBank_SubcategoriesCbx.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_SubcategoriesCbx.Location = new Point(18, 178);
            FromQuestionBank_SubcategoriesCbx.Name = "FromQuestionBank_SubcategoriesCbx";
            FromQuestionBank_SubcategoriesCbx.Size = new Size(372, 29);
            FromQuestionBank_SubcategoriesCbx.TabIndex = 33;
            FromQuestionBank_SubcategoriesCbx.Text = "Also show questions form subcategories";
            FromQuestionBank_SubcategoriesCbx.UseVisualStyleBackColor = true;
            FromQuestionBank_SubcategoriesCbx.CheckedChanged += FromQuestionBank_SubcategoriesCbx_CheckedChanged;
            // 
            // FromQuestionBank_OptionLbl
            // 
            FromQuestionBank_OptionLbl.AutoSize = true;
            FromQuestionBank_OptionLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            FromQuestionBank_OptionLbl.ForeColor = Color.FromArgb(44, 171, 230);
            FromQuestionBank_OptionLbl.Location = new Point(14, 150);
            FromQuestionBank_OptionLbl.Name = "FromQuestionBank_OptionLbl";
            FromQuestionBank_OptionLbl.Size = new Size(144, 25);
            FromQuestionBank_OptionLbl.TabIndex = 32;
            FromQuestionBank_OptionLbl.Text = "Search options";
            // 
            // FromQuestionBank_SelectCategoryCbo
            // 
            FromQuestionBank_SelectCategoryCbo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_SelectCategoryCbo.FormattingEnabled = true;
            FromQuestionBank_SelectCategoryCbo.Location = new Point(179, 90);
            FromQuestionBank_SelectCategoryCbo.Name = "FromQuestionBank_SelectCategoryCbo";
            FromQuestionBank_SelectCategoryCbo.Size = new Size(324, 33);
            FromQuestionBank_SelectCategoryCbo.TabIndex = 31;
            FromQuestionBank_SelectCategoryCbo.SelectedIndexChanged += FromQuestionBank_SelectCategoryCbo_SelectedIndexChanged;
            FromQuestionBank_SelectCategoryCbo.MouseClick += FromQuestionBank_SelectCategoryCbo_MouseClick;
            // 
            // FromQuestionBank_CategoryLbl
            // 
            FromQuestionBank_CategoryLbl.AutoSize = true;
            FromQuestionBank_CategoryLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_CategoryLbl.Location = new Point(14, 90);
            FromQuestionBank_CategoryLbl.Name = "FromQuestionBank_CategoryLbl";
            FromQuestionBank_CategoryLbl.Size = new Size(159, 25);
            FromQuestionBank_CategoryLbl.TabIndex = 30;
            FromQuestionBank_CategoryLbl.Text = "Select a category:";
            // 
            // FromQuestionBank_Header
            // 
            FromQuestionBank_Header.AutoSize = true;
            FromQuestionBank_Header.Font = new Font("Segoe UI", 25.8F, FontStyle.Regular, GraphicsUnit.Point);
            FromQuestionBank_Header.ForeColor = Color.FromArgb(194, 36, 36);
            FromQuestionBank_Header.Location = new Point(3, 7);
            FromQuestionBank_Header.Name = "FromQuestionBank_Header";
            FromQuestionBank_Header.Size = new Size(723, 59);
            FromQuestionBank_Header.TabIndex = 29;
            FromQuestionBank_Header.Text = "Add from a question bank at the end";
            // 
            // Checkbox
            // 
            Checkbox.HeaderText = "Select All";
            Checkbox.MinimumWidth = 8;
            Checkbox.Name = "Checkbox";
            Checkbox.Resizable = DataGridViewTriState.False;
            Checkbox.ToolTipText = "Chọn tất cả các câu hỏi";
            Checkbox.Width = 110;
            // 
            // Content
            // 
            Content.HeaderText = "Câu hỏi";
            Content.MinimumWidth = 8;
            Content.Name = "Content";
            Content.ReadOnly = true;
            Content.SortMode = DataGridViewColumnSortMode.NotSortable;
            Content.Width = 1050;
            // 
            // QuestionID
            // 
            QuestionID.HeaderText = "QuestionID";
            QuestionID.MinimumWidth = 8;
            QuestionID.Name = "QuestionID";
            QuestionID.Visible = false;
            QuestionID.Width = 150;
            // 
            // FromQuestionBank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel1);
            Name = "FromQuestionBank";
            Size = new Size(1411, 761);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FromQuestionBank_ShowQuestionsDtg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView FromQuestionBank_ShowQuestionsDtg;
        private Button FromQuestionBank_AddBtn;
        private CheckBox FromQuestionBank_OldQuestionCbx;
        private CheckBox FromQuestionBank_SubcategoriesCbx;
        private Label FromQuestionBank_OptionLbl;
        private ComboBox FromQuestionBank_SelectCategoryCbo;
        private Label FromQuestionBank_CategoryLbl;
        private Label FromQuestionBank_Header;
        private Button FromQuestionBank_ExitBtn;
        private DataGridViewCheckBoxColumn Checkbox;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewTextBoxColumn QuestionID;
    }
}
