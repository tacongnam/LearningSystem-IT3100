namespace Learning_System
{
    partial class PageOfPreviewQuiz
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
            panel1 = new Panel();
            MarkLbl = new Label();
            AnswerLbl = new Label();
            QuestionLbl = new Label();
            NumberLbl = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            QuestionChoiceGrb = new GroupBox();
            panel_richTextboxes = new Panel();
            panel_button = new Panel();
            ContentRtb = new RichTextBox();
            KeyRtb = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            QuestionChoiceGrb.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(MarkLbl);
            panel1.Controls.Add(AnswerLbl);
            panel1.Controls.Add(QuestionLbl);
            panel1.Controls.Add(NumberLbl);
            panel1.Location = new Point(18, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 406);
            panel1.TabIndex = 0;
            // 
            // MarkLbl
            // 
            MarkLbl.AutoSize = true;
            MarkLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MarkLbl.ForeColor = Color.Black;
            MarkLbl.Location = new Point(4, 67);
            MarkLbl.Name = "MarkLbl";
            MarkLbl.Size = new Size(135, 23);
            MarkLbl.TabIndex = 6;
            MarkLbl.Text = "Mark out of 1.00\r\n";
            // 
            // AnswerLbl
            // 
            AnswerLbl.AutoSize = true;
            AnswerLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AnswerLbl.ForeColor = Color.Black;
            AnswerLbl.Location = new Point(4, 41);
            AnswerLbl.Name = "AnswerLbl";
            AnswerLbl.Size = new Size(144, 23);
            AnswerLbl.TabIndex = 5;
            AnswerLbl.Text = "Not yet answered";
            // 
            // QuestionLbl
            // 
            QuestionLbl.AutoSize = true;
            QuestionLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionLbl.ForeColor = Color.FromArgb(194, 36, 36);
            QuestionLbl.Location = new Point(4, 11);
            QuestionLbl.Name = "QuestionLbl";
            QuestionLbl.Size = new Size(79, 23);
            QuestionLbl.TabIndex = 3;
            QuestionLbl.Text = "Question";
            // 
            // NumberLbl
            // 
            NumberLbl.AutoSize = true;
            NumberLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            NumberLbl.ForeColor = Color.FromArgb(194, 36, 36);
            NumberLbl.Location = new Point(82, -4);
            NumberLbl.Name = "NumberLbl";
            NumberLbl.Size = new Size(35, 41);
            NumberLbl.TabIndex = 4;
            NumberLbl.Text = "1";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(ContentRtb);
            panel2.Location = new Point(226, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(1104, 406);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.FromArgb(231, 243, 245);
            panel3.Controls.Add(QuestionChoiceGrb);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 217);
            panel3.Name = "panel3";
            panel3.Size = new Size(1104, 189);
            panel3.TabIndex = 2;
            // 
            // QuestionChoiceGrb
            // 
            QuestionChoiceGrb.AutoSize = true;
            QuestionChoiceGrb.BackColor = Color.FromArgb(231, 243, 245);
            QuestionChoiceGrb.Controls.Add(panel_richTextboxes);
            QuestionChoiceGrb.Controls.Add(panel_button);
            QuestionChoiceGrb.Dock = DockStyle.Fill;
            QuestionChoiceGrb.Location = new Point(0, 0);
            QuestionChoiceGrb.Name = "QuestionChoiceGrb";
            QuestionChoiceGrb.Size = new Size(1104, 189);
            QuestionChoiceGrb.TabIndex = 1;
            QuestionChoiceGrb.TabStop = false;
            // 
            // panel_richTextboxes
            // 
            panel_richTextboxes.BackColor = Color.FromArgb(231, 243, 245);
            panel_richTextboxes.Dock = DockStyle.Fill;
            panel_richTextboxes.Location = new Point(41, 23);
            panel_richTextboxes.Name = "panel_richTextboxes";
            panel_richTextboxes.Size = new Size(1060, 163);
            panel_richTextboxes.TabIndex = 1;
            // 
            // panel_button
            // 
            panel_button.Dock = DockStyle.Left;
            panel_button.Location = new Point(3, 23);
            panel_button.Name = "panel_button";
            panel_button.Padding = new Padding(5);
            panel_button.Size = new Size(38, 163);
            panel_button.TabIndex = 0;
            // 
            // ContentRtb
            // 
            ContentRtb.BackColor = Color.FromArgb(231, 243, 245);
            ContentRtb.BorderStyle = BorderStyle.None;
            ContentRtb.Dock = DockStyle.Top;
            ContentRtb.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ContentRtb.Location = new Point(0, 0);
            ContentRtb.Margin = new Padding(10, 7, 3, 3);
            ContentRtb.Name = "ContentRtb";
            ContentRtb.Size = new Size(1104, 217);
            ContentRtb.TabIndex = 0;
            ContentRtb.Text = "";
            // 
            // KeyRtb
            // 
            KeyRtb.BackColor = Color.Gainsboro;
            KeyRtb.BorderStyle = BorderStyle.None;
            KeyRtb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            KeyRtb.Location = new Point(226, 441);
            KeyRtb.Margin = new Padding(10);
            KeyRtb.Name = "KeyRtb";
            KeyRtb.Size = new Size(1101, 217);
            KeyRtb.TabIndex = 3;
            KeyRtb.Text = "";
            KeyRtb.Visible = false;
            // 
            // PageOfPreviewQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(KeyRtb);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PageOfPreviewQuiz";
            Size = new Size(1340, 680);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            QuestionChoiceGrb.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label MarkLbl;
        private Label AnswerLbl;
        private Label QuestionLbl;
        private Label NumberLbl;
        private RichTextBox ContentRtb;
        private GroupBox QuestionChoiceGrb;
        private Panel panel_richTextboxes;
        private Panel panel_button;
        private Panel panel3;
        public RichTextBox KeyRtb;
        public Panel panel2;
    }
}
