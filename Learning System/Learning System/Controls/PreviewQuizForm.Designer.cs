namespace Learning_System
{
    partial class PreviewQuizForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel_top = new Panel();
            panel_heading = new Panel();
            PathLbl = new Label();
            ITLbl = new Label();
            FinishLbl = new Label();
            label7 = new Label();
            PreviousPageBtn = new Button();
            panel_left = new Panel();
            panel_changePage = new Panel();
            NextPageBtn = new Button();
            panel_right = new Panel();
            panel_QuestionBtn = new Panel();
            panel1 = new Panel();
            QuizNavigationLbl = new Label();
            panel_time = new Panel();
            panel_timeLeft = new Panel();
            TimeLeftLbl = new Label();
            panel_Review = new Panel();
            GradeLbl = new Label();
            MarkLbl = new Label();
            TimeTakenLbl = new Label();
            FinishTimeLbl = new Label();
            label11 = new Label();
            StartTimeLbl = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            countDownTimer = new System.Windows.Forms.Timer(components);
            panel_heading.SuspendLayout();
            panel_left.SuspendLayout();
            panel_changePage.SuspendLayout();
            panel_right.SuspendLayout();
            panel_QuestionBtn.SuspendLayout();
            panel1.SuspendLayout();
            panel_time.SuspendLayout();
            panel_timeLeft.SuspendLayout();
            panel_Review.SuspendLayout();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.FromArgb(0, 159, 229);
            panel_top.BorderStyle = BorderStyle.FixedSingle;
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(1366, 64);
            panel_top.TabIndex = 2;
            // 
            // panel_heading
            // 
            panel_heading.BackColor = Color.White;
            panel_heading.BorderStyle = BorderStyle.FixedSingle;
            panel_heading.Controls.Add(PathLbl);
            panel_heading.Controls.Add(ITLbl);
            panel_heading.Dock = DockStyle.Top;
            panel_heading.Location = new Point(0, 64);
            panel_heading.Name = "panel_heading";
            panel_heading.Size = new Size(1366, 146);
            panel_heading.TabIndex = 4;
            // 
            // PathLbl
            // 
            PathLbl.AutoSize = true;
            PathLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PathLbl.Location = new Point(23, 83);
            PathLbl.Name = "PathLbl";
            PathLbl.Size = new Size(291, 23);
            PathLbl.TabIndex = 1;
            PathLbl.Text = "Home  /  My courses  /  THI CUỐI KỲ";
            // 
            // ITLbl
            // 
            ITLbl.AutoSize = true;
            ITLbl.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            ITLbl.ForeColor = Color.FromArgb(194, 36, 36);
            ITLbl.Location = new Point(23, 13);
            ITLbl.Name = "ITLbl";
            ITLbl.Size = new Size(60, 60);
            ITLbl.TabIndex = 0;
            ITLbl.Text = "IT";
            // 
            // FinishLbl
            // 
            FinishLbl.AutoSize = true;
            FinishLbl.BackColor = Color.WhiteSmoke;
            FinishLbl.Cursor = Cursors.Hand;
            FinishLbl.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FinishLbl.ForeColor = SystemColors.ActiveCaptionText;
            FinishLbl.Location = new Point(6, 347);
            FinishLbl.Name = "FinishLbl";
            FinishLbl.Size = new Size(172, 28);
            FinishLbl.TabIndex = 4;
            FinishLbl.Text = "Finish attempt ...";
            FinishLbl.Click += FinishLbl_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(7, 6);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 10;
            label7.Text = "Time left:";
            // 
            // PreviousPageBtn
            // 
            PreviousPageBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PreviousPageBtn.BackColor = Color.FromArgb(0, 159, 229);
            PreviousPageBtn.Cursor = Cursors.Hand;
            PreviousPageBtn.FlatStyle = FlatStyle.Flat;
            PreviousPageBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PreviousPageBtn.ForeColor = Color.White;
            PreviousPageBtn.Location = new Point(18, 5);
            PreviousPageBtn.Name = "PreviousPageBtn";
            PreviousPageBtn.Size = new Size(169, 47);
            PreviousPageBtn.TabIndex = 14;
            PreviousPageBtn.Text = "Previous page";
            PreviousPageBtn.UseVisualStyleBackColor = false;
            PreviousPageBtn.Click += PreviousPageBtn_Click;
            // 
            // panel_left
            // 
            panel_left.BackColor = Color.White;
            panel_left.Controls.Add(panel_changePage);
            panel_left.Dock = DockStyle.Fill;
            panel_left.Location = new Point(0, 407);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(1000, 308);
            panel_left.TabIndex = 5;
            // 
            // panel_changePage
            // 
            panel_changePage.BackColor = Color.White;
            panel_changePage.Controls.Add(PreviousPageBtn);
            panel_changePage.Controls.Add(NextPageBtn);
            panel_changePage.Dock = DockStyle.Bottom;
            panel_changePage.Location = new Point(0, 235);
            panel_changePage.Name = "panel_changePage";
            panel_changePage.Size = new Size(1000, 73);
            panel_changePage.TabIndex = 8;
            // 
            // NextPageBtn
            // 
            NextPageBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NextPageBtn.BackColor = Color.FromArgb(0, 159, 229);
            NextPageBtn.Cursor = Cursors.Hand;
            NextPageBtn.FlatStyle = FlatStyle.Flat;
            NextPageBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NextPageBtn.ForeColor = Color.White;
            NextPageBtn.Location = new Point(813, 5);
            NextPageBtn.Name = "NextPageBtn";
            NextPageBtn.Size = new Size(169, 47);
            NextPageBtn.TabIndex = 15;
            NextPageBtn.Text = "Next page";
            NextPageBtn.UseVisualStyleBackColor = false;
            NextPageBtn.Click += NextPageBtn_Click;
            // 
            // panel_right
            // 
            panel_right.BackColor = Color.White;
            panel_right.BorderStyle = BorderStyle.FixedSingle;
            panel_right.Controls.Add(panel_QuestionBtn);
            panel_right.Controls.Add(panel1);
            panel_right.Dock = DockStyle.Right;
            panel_right.Location = new Point(1000, 210);
            panel_right.Name = "panel_right";
            panel_right.Size = new Size(366, 505);
            panel_right.TabIndex = 6;
            // 
            // panel_QuestionBtn
            // 
            panel_QuestionBtn.AutoScroll = true;
            panel_QuestionBtn.Controls.Add(FinishLbl);
            panel_QuestionBtn.Dock = DockStyle.Fill;
            panel_QuestionBtn.Location = new Point(0, 46);
            panel_QuestionBtn.Name = "panel_QuestionBtn";
            panel_QuestionBtn.Size = new Size(364, 457);
            panel_QuestionBtn.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(QuizNavigationLbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 46);
            panel1.TabIndex = 0;
            // 
            // QuizNavigationLbl
            // 
            QuizNavigationLbl.AutoSize = true;
            QuizNavigationLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            QuizNavigationLbl.ForeColor = Color.FromArgb(194, 36, 36);
            QuizNavigationLbl.Location = new Point(6, 6);
            QuizNavigationLbl.Name = "QuizNavigationLbl";
            QuizNavigationLbl.Size = new Size(162, 28);
            QuizNavigationLbl.TabIndex = 2;
            QuizNavigationLbl.Text = "Quiz navigation";
            // 
            // panel_time
            // 
            panel_time.BackColor = Color.White;
            panel_time.Controls.Add(panel_timeLeft);
            panel_time.Controls.Add(panel_Review);
            panel_time.Dock = DockStyle.Top;
            panel_time.Location = new Point(0, 210);
            panel_time.Name = "panel_time";
            panel_time.Size = new Size(1000, 197);
            panel_time.TabIndex = 7;
            // 
            // panel_timeLeft
            // 
            panel_timeLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_timeLeft.BackColor = Color.White;
            panel_timeLeft.Controls.Add(TimeLeftLbl);
            panel_timeLeft.Controls.Add(label7);
            panel_timeLeft.ForeColor = SystemColors.ControlText;
            panel_timeLeft.Location = new Point(815, 3);
            panel_timeLeft.Name = "panel_timeLeft";
            panel_timeLeft.Size = new Size(174, 38);
            panel_timeLeft.TabIndex = 1;
            panel_timeLeft.Paint += panel_timeLeft_Paint;
            // 
            // TimeLeftLbl
            // 
            TimeLeftLbl.AutoSize = true;
            TimeLeftLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLeftLbl.ForeColor = Color.Black;
            TimeLeftLbl.Location = new Point(92, 6);
            TimeLeftLbl.Name = "TimeLeftLbl";
            TimeLeftLbl.Size = new Size(66, 25);
            TimeLeftLbl.TabIndex = 11;
            TimeLeftLbl.Text = "60 : 00";
            // 
            // panel_Review
            // 
            panel_Review.BorderStyle = BorderStyle.FixedSingle;
            panel_Review.Controls.Add(GradeLbl);
            panel_Review.Controls.Add(MarkLbl);
            panel_Review.Controls.Add(TimeTakenLbl);
            panel_Review.Controls.Add(FinishTimeLbl);
            panel_Review.Controls.Add(label11);
            panel_Review.Controls.Add(StartTimeLbl);
            panel_Review.Controls.Add(label6);
            panel_Review.Controls.Add(label5);
            panel_Review.Controls.Add(label4);
            panel_Review.Controls.Add(label3);
            panel_Review.Controls.Add(label2);
            panel_Review.Controls.Add(label1);
            panel_Review.Dock = DockStyle.Bottom;
            panel_Review.Location = new Point(0, 43);
            panel_Review.Name = "panel_Review";
            panel_Review.Size = new Size(1000, 154);
            panel_Review.TabIndex = 0;
            panel_Review.Visible = false;
            // 
            // GradeLbl
            // 
            GradeLbl.AutoSize = true;
            GradeLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            GradeLbl.ForeColor = Color.Black;
            GradeLbl.Location = new Point(152, 124);
            GradeLbl.Name = "GradeLbl";
            GradeLbl.Size = new Size(63, 25);
            GradeLbl.TabIndex = 14;
            GradeLbl.Text = "Grade";
            // 
            // MarkLbl
            // 
            MarkLbl.AutoSize = true;
            MarkLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MarkLbl.ForeColor = Color.Black;
            MarkLbl.Location = new Point(152, 100);
            MarkLbl.Name = "MarkLbl";
            MarkLbl.Size = new Size(63, 25);
            MarkLbl.TabIndex = 13;
            MarkLbl.Text = "Marks";
            // 
            // TimeTakenLbl
            // 
            TimeTakenLbl.AutoSize = true;
            TimeTakenLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TimeTakenLbl.ForeColor = Color.Black;
            TimeTakenLbl.Location = new Point(152, 76);
            TimeTakenLbl.Name = "TimeTakenLbl";
            TimeTakenLbl.Size = new Size(104, 25);
            TimeTakenLbl.TabIndex = 12;
            TimeTakenLbl.Text = "Time taken";
            // 
            // FinishTimeLbl
            // 
            FinishTimeLbl.AutoSize = true;
            FinishTimeLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FinishTimeLbl.ForeColor = Color.Black;
            FinishTimeLbl.Location = new Point(152, 52);
            FinishTimeLbl.Name = "FinishTimeLbl";
            FinishTimeLbl.Size = new Size(131, 25);
            FinishTimeLbl.TabIndex = 11;
            FinishTimeLbl.Text = "Completed on";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(152, 28);
            label11.Name = "label11";
            label11.Size = new Size(82, 25);
            label11.TabIndex = 10;
            label11.Text = "Finished";
            // 
            // StartTimeLbl
            // 
            StartTimeLbl.AutoSize = true;
            StartTimeLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            StartTimeLbl.ForeColor = Color.Black;
            StartTimeLbl.Location = new Point(152, 4);
            StartTimeLbl.Name = "StartTimeLbl";
            StartTimeLbl.Size = new Size(98, 25);
            StartTimeLbl.TabIndex = 9;
            StartTimeLbl.Text = "Started on";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(194, 36, 36);
            label6.Location = new Point(7, 124);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 8;
            label6.Text = "Grade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(194, 36, 36);
            label5.Location = new Point(7, 100);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 7;
            label5.Text = "Marks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(194, 36, 36);
            label4.Location = new Point(7, 76);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 6;
            label4.Text = "Time taken";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(194, 36, 36);
            label3.Location = new Point(7, 52);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 5;
            label3.Text = "Completed on";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(194, 36, 36);
            label2.Location = new Point(7, 28);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 4;
            label2.Text = "State";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(194, 36, 36);
            label1.Location = new Point(7, 4);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 3;
            label1.Text = "Started on";
            // 
            // countDownTimer
            // 
            countDownTimer.Interval = 1000;
            countDownTimer.Tick += timer1_Tick;
            // 
            // PreviewQuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 715);
            Controls.Add(panel_left);
            Controls.Add(panel_time);
            Controls.Add(panel_right);
            Controls.Add(panel_heading);
            Controls.Add(panel_top);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PreviewQuizForm";
            Text = "PreviewQuizForm";
            WindowState = FormWindowState.Maximized;
            panel_heading.ResumeLayout(false);
            panel_heading.PerformLayout();
            panel_left.ResumeLayout(false);
            panel_changePage.ResumeLayout(false);
            panel_right.ResumeLayout(false);
            panel_QuestionBtn.ResumeLayout(false);
            panel_QuestionBtn.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_time.ResumeLayout(false);
            panel_timeLeft.ResumeLayout(false);
            panel_timeLeft.PerformLayout();
            panel_Review.ResumeLayout(false);
            panel_Review.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_top;
        private Panel panel_heading;
        public Label PathLbl;
        private Label ITLbl;
        private Label QuizNavigationLbl;
        private Label FinishLbl;
        private Panel panel_QuestionBtn;
        private Button NextPageBtn;
        private Button PreviousPageBtn;
        private Panel panel_time;
        private Panel panel_changePage;
        public Panel panel_left;
        public Panel panel_right;
        private Panel panel_Review;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label GradeLbl;
        private Label MarkLbl;
        private Label TimeTakenLbl;
        private Label FinishTimeLbl;
        private Label label11;
        private Label StartTimeLbl;
        private Panel panel_timeLeft;
        private System.Windows.Forms.Timer countDownTimer;
        private Label label7;
        private Label TimeLeftLbl;
        private Panel panel1;
    }
}