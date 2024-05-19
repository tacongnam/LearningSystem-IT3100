namespace Learning_System
{
    partial class EditQuiz
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditQuiz));
            panel_edit = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            EditQuiz_ShuffleCbx = new CheckBox();
            EditQuiz_AddBtn = new Button();
            flowLayoutPanel_popup = new FlowLayoutPanel();
            EditForm_NewQuestionBtn = new Button();
            EditQuiz_BankBtn = new Button();
            EditQuiz_RandomBtn = new Button();
            EditQuiz_TotalofMarkLbl = new Label();
            EditQuiz_MaxGradeTxt = new TextBox();
            EditQuiz_SaveBtn = new Button();
            EditQuiz_MaxGradeLbl = new Label();
            EditQuiz_MultipleItemsBtn = new Button();
            EditQuiz_RepaginateBtn = new Button();
            EditQuiz_NumberofQuestionLbl = new Label();
            EditQuiz_ContestNameLbl = new Label();
            EditQuiz_QuestionDtg = new DataGridView();
            Content = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            QuestionID = new DataGridViewTextBoxColumn();
            DefaultMark = new DataGridViewTextBoxColumn();
            toolTip1 = new ToolTip(components);
            panel_edit.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel_popup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditQuiz_QuestionDtg).BeginInit();
            SuspendLayout();
            // 
            // panel_edit
            // 
            panel_edit.AutoScroll = true;
            panel_edit.BackColor = Color.White;
            panel_edit.Controls.Add(panel1);
            panel_edit.Controls.Add(flowLayoutPanel_popup);
            panel_edit.Controls.Add(EditQuiz_TotalofMarkLbl);
            panel_edit.Controls.Add(EditQuiz_MaxGradeTxt);
            panel_edit.Controls.Add(EditQuiz_SaveBtn);
            panel_edit.Controls.Add(EditQuiz_MaxGradeLbl);
            panel_edit.Controls.Add(EditQuiz_MultipleItemsBtn);
            panel_edit.Controls.Add(EditQuiz_RepaginateBtn);
            panel_edit.Controls.Add(EditQuiz_NumberofQuestionLbl);
            panel_edit.Controls.Add(EditQuiz_ContestNameLbl);
            panel_edit.Controls.Add(EditQuiz_QuestionDtg);
            panel_edit.Dock = DockStyle.Fill;
            panel_edit.Location = new Point(0, 0);
            panel_edit.Name = "panel_edit";
            panel_edit.Size = new Size(1379, 804);
            panel_edit.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(EditQuiz_ShuffleCbx);
            panel1.Controls.Add(EditQuiz_AddBtn);
            panel1.Location = new Point(0, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(1379, 76);
            panel1.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.question_removebg_preview;
            pictureBox1.Location = new Point(1338, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "Shuffle the order of questions");
            // 
            // EditQuiz_ShuffleCbx
            // 
            EditQuiz_ShuffleCbx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditQuiz_ShuffleCbx.AutoSize = true;
            EditQuiz_ShuffleCbx.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_ShuffleCbx.Location = new Point(1248, 11);
            EditQuiz_ShuffleCbx.Name = "EditQuiz_ShuffleCbx";
            EditQuiz_ShuffleCbx.Size = new Size(93, 29);
            EditQuiz_ShuffleCbx.TabIndex = 24;
            EditQuiz_ShuffleCbx.Text = "Shuffle";
            EditQuiz_ShuffleCbx.UseVisualStyleBackColor = true;
            // 
            // EditQuiz_AddBtn
            // 
            EditQuiz_AddBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditQuiz_AddBtn.BackColor = Color.Transparent;
            EditQuiz_AddBtn.Cursor = Cursors.Hand;
            EditQuiz_AddBtn.FlatAppearance.BorderColor = SystemColors.Control;
            EditQuiz_AddBtn.FlatStyle = FlatStyle.Flat;
            EditQuiz_AddBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            EditQuiz_AddBtn.ForeColor = Color.FromArgb(44, 171, 230);
            EditQuiz_AddBtn.Location = new Point(1298, 40);
            EditQuiz_AddBtn.Name = "EditQuiz_AddBtn";
            EditQuiz_AddBtn.Size = new Size(61, 31);
            EditQuiz_AddBtn.TabIndex = 25;
            EditQuiz_AddBtn.Text = "Add";
            EditQuiz_AddBtn.UseVisualStyleBackColor = false;
            EditQuiz_AddBtn.Click += EditQuiz_AddBtn_Click;
            // 
            // flowLayoutPanel_popup
            // 
            flowLayoutPanel_popup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel_popup.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel_popup.Controls.Add(EditForm_NewQuestionBtn);
            flowLayoutPanel_popup.Controls.Add(EditQuiz_BankBtn);
            flowLayoutPanel_popup.Controls.Add(EditQuiz_RandomBtn);
            flowLayoutPanel_popup.Location = new Point(1146, 258);
            flowLayoutPanel_popup.Name = "flowLayoutPanel_popup";
            flowLayoutPanel_popup.Size = new Size(217, 139);
            flowLayoutPanel_popup.TabIndex = 26;
            flowLayoutPanel_popup.Visible = false;
            // 
            // EditForm_NewQuestionBtn
            // 
            EditForm_NewQuestionBtn.BackColor = Color.WhiteSmoke;
            EditForm_NewQuestionBtn.Cursor = Cursors.Hand;
            EditForm_NewQuestionBtn.FlatAppearance.BorderSize = 0;
            EditForm_NewQuestionBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 159, 229);
            EditForm_NewQuestionBtn.FlatStyle = FlatStyle.Flat;
            EditForm_NewQuestionBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EditForm_NewQuestionBtn.ForeColor = Color.Black;
            EditForm_NewQuestionBtn.Location = new Point(3, 3);
            EditForm_NewQuestionBtn.Name = "EditForm_NewQuestionBtn";
            EditForm_NewQuestionBtn.Size = new Size(210, 39);
            EditForm_NewQuestionBtn.TabIndex = 5;
            EditForm_NewQuestionBtn.Text = "a new question";
            EditForm_NewQuestionBtn.TextAlign = ContentAlignment.MiddleLeft;
            EditForm_NewQuestionBtn.UseVisualStyleBackColor = false;
            // 
            // EditQuiz_BankBtn
            // 
            EditQuiz_BankBtn.BackColor = Color.WhiteSmoke;
            EditQuiz_BankBtn.Cursor = Cursors.Hand;
            EditQuiz_BankBtn.FlatAppearance.BorderSize = 0;
            EditQuiz_BankBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 159, 229);
            EditQuiz_BankBtn.FlatStyle = FlatStyle.Flat;
            EditQuiz_BankBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_BankBtn.ForeColor = Color.Black;
            EditQuiz_BankBtn.Location = new Point(3, 48);
            EditQuiz_BankBtn.Name = "EditQuiz_BankBtn";
            EditQuiz_BankBtn.Size = new Size(210, 39);
            EditQuiz_BankBtn.TabIndex = 6;
            EditQuiz_BankBtn.Text = "from question bank";
            EditQuiz_BankBtn.TextAlign = ContentAlignment.MiddleLeft;
            EditQuiz_BankBtn.UseVisualStyleBackColor = false;
            EditQuiz_BankBtn.Click += EditQuiz_BankBtn_Click;
            // 
            // EditQuiz_RandomBtn
            // 
            EditQuiz_RandomBtn.BackColor = Color.WhiteSmoke;
            EditQuiz_RandomBtn.Cursor = Cursors.Hand;
            EditQuiz_RandomBtn.FlatAppearance.BorderSize = 0;
            EditQuiz_RandomBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 159, 229);
            EditQuiz_RandomBtn.FlatStyle = FlatStyle.Flat;
            EditQuiz_RandomBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_RandomBtn.ForeColor = Color.Black;
            EditQuiz_RandomBtn.Location = new Point(3, 93);
            EditQuiz_RandomBtn.Name = "EditQuiz_RandomBtn";
            EditQuiz_RandomBtn.Size = new Size(210, 39);
            EditQuiz_RandomBtn.TabIndex = 7;
            EditQuiz_RandomBtn.Text = "a random question";
            EditQuiz_RandomBtn.TextAlign = ContentAlignment.MiddleLeft;
            EditQuiz_RandomBtn.UseVisualStyleBackColor = false;
            EditQuiz_RandomBtn.Click += EditQuiz_RandomBtn_Click;
            // 
            // EditQuiz_TotalofMarkLbl
            // 
            EditQuiz_TotalofMarkLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditQuiz_TotalofMarkLbl.AutoSize = true;
            EditQuiz_TotalofMarkLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_TotalofMarkLbl.Location = new Point(1199, 126);
            EditQuiz_TotalofMarkLbl.Name = "EditQuiz_TotalofMarkLbl";
            EditQuiz_TotalofMarkLbl.Size = new Size(164, 25);
            EditQuiz_TotalofMarkLbl.TabIndex = 23;
            EditQuiz_TotalofMarkLbl.Text = "Total of mark: 0.00";
            // 
            // EditQuiz_MaxGradeTxt
            // 
            EditQuiz_MaxGradeTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditQuiz_MaxGradeTxt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_MaxGradeTxt.Location = new Point(1164, 71);
            EditQuiz_MaxGradeTxt.Name = "EditQuiz_MaxGradeTxt";
            EditQuiz_MaxGradeTxt.Size = new Size(91, 32);
            EditQuiz_MaxGradeTxt.TabIndex = 22;
            EditQuiz_MaxGradeTxt.Text = "10.00";
            EditQuiz_MaxGradeTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // EditQuiz_SaveBtn
            // 
            EditQuiz_SaveBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditQuiz_SaveBtn.BackColor = Color.FromArgb(0, 159, 229);
            EditQuiz_SaveBtn.Cursor = Cursors.Hand;
            EditQuiz_SaveBtn.FlatStyle = FlatStyle.Flat;
            EditQuiz_SaveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_SaveBtn.ForeColor = Color.White;
            EditQuiz_SaveBtn.Location = new Point(1273, 63);
            EditQuiz_SaveBtn.Name = "EditQuiz_SaveBtn";
            EditQuiz_SaveBtn.Size = new Size(85, 48);
            EditQuiz_SaveBtn.TabIndex = 21;
            EditQuiz_SaveBtn.Text = "SAVE";
            EditQuiz_SaveBtn.UseVisualStyleBackColor = false;
            EditQuiz_SaveBtn.Click += EditQuiz_SaveBtn_Click;
            // 
            // EditQuiz_MaxGradeLbl
            // 
            EditQuiz_MaxGradeLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditQuiz_MaxGradeLbl.AutoSize = true;
            EditQuiz_MaxGradeLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_MaxGradeLbl.Location = new Point(1008, 76);
            EditQuiz_MaxGradeLbl.Name = "EditQuiz_MaxGradeLbl";
            EditQuiz_MaxGradeLbl.Size = new Size(150, 25);
            EditQuiz_MaxGradeLbl.TabIndex = 20;
            EditQuiz_MaxGradeLbl.Text = "Maximum grade";
            // 
            // EditQuiz_MultipleItemsBtn
            // 
            EditQuiz_MultipleItemsBtn.BackColor = Color.FromArgb(0, 159, 229);
            EditQuiz_MultipleItemsBtn.Cursor = Cursors.Hand;
            EditQuiz_MultipleItemsBtn.FlatStyle = FlatStyle.Flat;
            EditQuiz_MultipleItemsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_MultipleItemsBtn.ForeColor = Color.White;
            EditQuiz_MultipleItemsBtn.Location = new Point(243, 108);
            EditQuiz_MultipleItemsBtn.Name = "EditQuiz_MultipleItemsBtn";
            EditQuiz_MultipleItemsBtn.Size = new Size(270, 55);
            EditQuiz_MultipleItemsBtn.TabIndex = 19;
            EditQuiz_MultipleItemsBtn.Text = "SELECT MULTIPLE ITEMS";
            EditQuiz_MultipleItemsBtn.UseVisualStyleBackColor = false;
            // 
            // EditQuiz_RepaginateBtn
            // 
            EditQuiz_RepaginateBtn.BackColor = Color.FromArgb(0, 159, 229);
            EditQuiz_RepaginateBtn.Cursor = Cursors.Hand;
            EditQuiz_RepaginateBtn.FlatStyle = FlatStyle.Flat;
            EditQuiz_RepaginateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_RepaginateBtn.ForeColor = Color.White;
            EditQuiz_RepaginateBtn.Location = new Point(18, 108);
            EditQuiz_RepaginateBtn.Name = "EditQuiz_RepaginateBtn";
            EditQuiz_RepaginateBtn.Size = new Size(212, 55);
            EditQuiz_RepaginateBtn.TabIndex = 18;
            EditQuiz_RepaginateBtn.Text = "REPAGINATE";
            EditQuiz_RepaginateBtn.UseVisualStyleBackColor = false;
            // 
            // EditQuiz_NumberofQuestionLbl
            // 
            EditQuiz_NumberofQuestionLbl.AutoSize = true;
            EditQuiz_NumberofQuestionLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_NumberofQuestionLbl.Location = new Point(14, 72);
            EditQuiz_NumberofQuestionLbl.Name = "EditQuiz_NumberofQuestionLbl";
            EditQuiz_NumberofQuestionLbl.Size = new Size(263, 25);
            EditQuiz_NumberofQuestionLbl.TabIndex = 17;
            EditQuiz_NumberofQuestionLbl.Text = "Question: 0 | This quiz is open";
            // 
            // EditQuiz_ContestNameLbl
            // 
            EditQuiz_ContestNameLbl.AutoSize = true;
            EditQuiz_ContestNameLbl.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            EditQuiz_ContestNameLbl.ForeColor = Color.FromArgb(194, 36, 36);
            EditQuiz_ContestNameLbl.Location = new Point(3, 5);
            EditQuiz_ContestNameLbl.Name = "EditQuiz_ContestNameLbl";
            EditQuiz_ContestNameLbl.Size = new Size(859, 60);
            EditQuiz_ContestNameLbl.TabIndex = 16;
            EditQuiz_ContestNameLbl.Text = "Editing Quiz: Thi giữa kỳ 2 môn Công nghệ";
            // 
            // EditQuiz_QuestionDtg
            // 
            EditQuiz_QuestionDtg.AllowUserToAddRows = false;
            EditQuiz_QuestionDtg.AllowUserToDeleteRows = false;
            EditQuiz_QuestionDtg.AllowUserToResizeColumns = false;
            EditQuiz_QuestionDtg.AllowUserToResizeRows = false;
            EditQuiz_QuestionDtg.BackgroundColor = Color.White;
            EditQuiz_QuestionDtg.BorderStyle = BorderStyle.None;
            EditQuiz_QuestionDtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EditQuiz_QuestionDtg.ColumnHeadersVisible = false;
            EditQuiz_QuestionDtg.Columns.AddRange(new DataGridViewColumn[] { Content, Delete, QuestionID, DefaultMark });
            EditQuiz_QuestionDtg.GridColor = SystemColors.Control;
            EditQuiz_QuestionDtg.Location = new Point(14, 258);
            EditQuiz_QuestionDtg.Name = "EditQuiz_QuestionDtg";
            EditQuiz_QuestionDtg.ReadOnly = true;
            EditQuiz_QuestionDtg.RowHeadersWidth = 51;
            EditQuiz_QuestionDtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            EditQuiz_QuestionDtg.RowTemplate.Height = 29;
            EditQuiz_QuestionDtg.Size = new Size(1349, 524);
            EditQuiz_QuestionDtg.TabIndex = 27;
            EditQuiz_QuestionDtg.CellContentClick += EditQuiz_QuestionDtg_CellContentClick;
            EditQuiz_QuestionDtg.RowPostPaint += AutoNumberInDtg;
            // 
            // Content
            // 
            Content.HeaderText = "Content";
            Content.MinimumWidth = 6;
            Content.Name = "Content";
            Content.ReadOnly = true;
            Content.Width = 1200;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.thungrac;
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 50;
            // 
            // QuestionID
            // 
            QuestionID.HeaderText = "QuestionID";
            QuestionID.MinimumWidth = 6;
            QuestionID.Name = "QuestionID";
            QuestionID.ReadOnly = true;
            QuestionID.Visible = false;
            QuestionID.Width = 50;
            // 
            // DefaultMark
            // 
            DefaultMark.HeaderText = "DefaultMark";
            DefaultMark.MinimumWidth = 6;
            DefaultMark.Name = "DefaultMark";
            DefaultMark.ReadOnly = true;
            DefaultMark.Width = 50;
            // 
            // EditQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_edit);
            Name = "EditQuiz";
            Size = new Size(1379, 804);
            panel_edit.ResumeLayout(false);
            panel_edit.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel_popup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EditQuiz_QuestionDtg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_edit;
        private Button EditQuiz_AddBtn;
        public CheckBox EditQuiz_ShuffleCbx;
        private Label EditQuiz_TotalofMarkLbl;
        public TextBox EditQuiz_MaxGradeTxt;
        private Button EditQuiz_SaveBtn;
        private Label EditQuiz_MaxGradeLbl;
        private Button EditQuiz_MultipleItemsBtn;
        private Button EditQuiz_RepaginateBtn;
        private Label EditQuiz_NumberofQuestionLbl;
        public Label EditQuiz_ContestNameLbl;
        private FlowLayoutPanel flowLayoutPanel_popup;
        private Button EditForm_NewQuestionBtn;
        private Button EditQuiz_BankBtn;
        private Button EditQuiz_RandomBtn;
        private DataGridView EditQuiz_QuestionDtg;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewImageColumn Delete;
        private DataGridViewTextBoxColumn QuestionID;
        private DataGridViewTextBoxColumn DefaultMark;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolTip toolTip1;
    }
}
