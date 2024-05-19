namespace Learning_System
{
    partial class HomePageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            panel1 = new Panel();
            HomePageForm_UserNameLbl = new Label();
            HomePageForm_AvatarPic = new PictureBox();
            HomePageForm_MenuPic = new PictureBox();
            HomePageForm_GearPic = new PictureBox();
            HomePageForm_EditingBtn = new Button();
            HomePageForm_PathLbl = new Label();
            HomePageForm_ITLbl = new Label();
            panel3 = new Panel();
            panel_popup = new Panel();
            PopUpForm = new PopUpForm();
            flowLayoutPanel_popup = new FlowLayoutPanel();
            HomePageForm_QuestionsBtn = new Button();
            HomePageForm_CategoriesBtn = new Button();
            HomePageForm_ImportBtn = new Button();
            HomePageForm_ExportBtn = new Button();
            HomePageForm_QuestionsBankLbl = new Label();
            panel2 = new Panel();
            notifyIcon1 = new NotifyIcon(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomePageForm_AvatarPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HomePageForm_MenuPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HomePageForm_GearPic).BeginInit();
            panel3.SuspendLayout();
            panel_popup.SuspendLayout();
            flowLayoutPanel_popup.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 115, 165);
            panel1.Controls.Add(HomePageForm_UserNameLbl);
            panel1.Controls.Add(HomePageForm_AvatarPic);
            panel1.Controls.Add(HomePageForm_MenuPic);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1385, 64);
            panel1.TabIndex = 0;
            // 
            // HomePageForm_UserNameLbl
            // 
            HomePageForm_UserNameLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HomePageForm_UserNameLbl.AutoSize = true;
            HomePageForm_UserNameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomePageForm_UserNameLbl.ForeColor = Color.White;
            HomePageForm_UserNameLbl.Location = new Point(1215, 15);
            HomePageForm_UserNameLbl.Name = "HomePageForm_UserNameLbl";
            HomePageForm_UserNameLbl.Size = new Size(108, 28);
            HomePageForm_UserNameLbl.TabIndex = 2;
            HomePageForm_UserNameLbl.Text = "Group 14";
            // 
            // HomePageForm_AvatarPic
            // 
            HomePageForm_AvatarPic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HomePageForm_AvatarPic.Image = (Image)resources.GetObject("HomePageForm_AvatarPic.Image");
            HomePageForm_AvatarPic.Location = new Point(1321, 8);
            HomePageForm_AvatarPic.Name = "HomePageForm_AvatarPic";
            HomePageForm_AvatarPic.Size = new Size(59, 45);
            HomePageForm_AvatarPic.SizeMode = PictureBoxSizeMode.Zoom;
            HomePageForm_AvatarPic.TabIndex = 1;
            HomePageForm_AvatarPic.TabStop = false;
            // 
            // HomePageForm_MenuPic
            // 
            HomePageForm_MenuPic.Cursor = Cursors.Hand;
            HomePageForm_MenuPic.Image = (Image)resources.GetObject("HomePageForm_MenuPic.Image");
            HomePageForm_MenuPic.Location = new Point(22, 12);
            HomePageForm_MenuPic.Name = "HomePageForm_MenuPic";
            HomePageForm_MenuPic.Size = new Size(49, 33);
            HomePageForm_MenuPic.SizeMode = PictureBoxSizeMode.Zoom;
            HomePageForm_MenuPic.TabIndex = 0;
            HomePageForm_MenuPic.TabStop = false;
            HomePageForm_MenuPic.Click += HomePageForm_MenuPic_Click;
            // 
            // HomePageForm_GearPic
            // 
            HomePageForm_GearPic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HomePageForm_GearPic.Cursor = Cursors.Hand;
            HomePageForm_GearPic.Image = (Image)resources.GetObject("HomePageForm_GearPic.Image");
            HomePageForm_GearPic.Location = new Point(1330, 70);
            HomePageForm_GearPic.Name = "HomePageForm_GearPic";
            HomePageForm_GearPic.Size = new Size(48, 37);
            HomePageForm_GearPic.SizeMode = PictureBoxSizeMode.Zoom;
            HomePageForm_GearPic.TabIndex = 2;
            HomePageForm_GearPic.TabStop = false;
            HomePageForm_GearPic.Click += Picture_setting_Click;
            // 
            // HomePageForm_EditingBtn
            // 
            HomePageForm_EditingBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            HomePageForm_EditingBtn.BackColor = Color.FromArgb(0, 115, 165);
            HomePageForm_EditingBtn.Cursor = Cursors.Hand;
            HomePageForm_EditingBtn.FlatStyle = FlatStyle.Flat;
            HomePageForm_EditingBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomePageForm_EditingBtn.ForeColor = Color.White;
            HomePageForm_EditingBtn.Location = new Point(1166, 96);
            HomePageForm_EditingBtn.Name = "HomePageForm_EditingBtn";
            HomePageForm_EditingBtn.Size = new Size(211, 42);
            HomePageForm_EditingBtn.TabIndex = 6;
            HomePageForm_EditingBtn.Text = "TURN EDITING ON";
            HomePageForm_EditingBtn.UseVisualStyleBackColor = false;
            HomePageForm_EditingBtn.Click += HomePageForm_EditingBtn_Click;
            // 
            // HomePageForm_PathLbl
            // 
            HomePageForm_PathLbl.AutoSize = true;
            HomePageForm_PathLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            HomePageForm_PathLbl.Location = new Point(23, 83);
            HomePageForm_PathLbl.Name = "HomePageForm_PathLbl";
            HomePageForm_PathLbl.Size = new Size(291, 23);
            HomePageForm_PathLbl.TabIndex = 1;
            HomePageForm_PathLbl.Text = "Home  /  My courses  /  THI CUỐI KỲ";
            // 
            // HomePageForm_ITLbl
            // 
            HomePageForm_ITLbl.AutoSize = true;
            HomePageForm_ITLbl.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            HomePageForm_ITLbl.ForeColor = Color.FromArgb(194, 36, 36);
            HomePageForm_ITLbl.Location = new Point(23, 13);
            HomePageForm_ITLbl.Name = "HomePageForm_ITLbl";
            HomePageForm_ITLbl.Size = new Size(60, 60);
            HomePageForm_ITLbl.TabIndex = 0;
            HomePageForm_ITLbl.Text = "IT";
            // 
            // panel3
            // 
            panel3.Controls.Add(HomePageForm_EditingBtn);
            panel3.Controls.Add(HomePageForm_PathLbl);
            panel3.Controls.Add(HomePageForm_ITLbl);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(1385, 146);
            panel3.TabIndex = 2;
            panel3.Paint += Panel3_Paint;
            // 
            // panel_popup
            // 
            panel_popup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_popup.BorderStyle = BorderStyle.FixedSingle;
            panel_popup.Controls.Add(flowLayoutPanel_popup);
            panel_popup.Controls.Add(HomePageForm_QuestionsBankLbl);
            panel_popup.Location = new Point(822, 70);
            panel_popup.Name = "panel_popup";
            panel_popup.Size = new Size(502, 190);
            panel_popup.TabIndex = 1;
            panel_popup.Visible = false;
            // 
            // flowLayoutPanel_popup
            // 
            flowLayoutPanel_popup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel_popup.Controls.Add(HomePageForm_QuestionsBtn);
            flowLayoutPanel_popup.Controls.Add(HomePageForm_CategoriesBtn);
            flowLayoutPanel_popup.Controls.Add(HomePageForm_ImportBtn);
            flowLayoutPanel_popup.Controls.Add(HomePageForm_ExportBtn);
            flowLayoutPanel_popup.Location = new Point(313, 6);
            flowLayoutPanel_popup.Name = "flowLayoutPanel_popup";
            flowLayoutPanel_popup.Size = new Size(175, 179);
            flowLayoutPanel_popup.TabIndex = 9;
            // 
            // HomePageForm_QuestionsBtn
            // 
            HomePageForm_QuestionsBtn.Cursor = Cursors.Hand;
            HomePageForm_QuestionsBtn.FlatAppearance.BorderSize = 0;
            HomePageForm_QuestionsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            HomePageForm_QuestionsBtn.FlatStyle = FlatStyle.Flat;
            HomePageForm_QuestionsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomePageForm_QuestionsBtn.ForeColor = Color.FromArgb(44, 171, 230);
            HomePageForm_QuestionsBtn.Location = new Point(3, 3);
            HomePageForm_QuestionsBtn.Name = "HomePageForm_QuestionsBtn";
            HomePageForm_QuestionsBtn.Size = new Size(162, 39);
            HomePageForm_QuestionsBtn.TabIndex = 5;
            HomePageForm_QuestionsBtn.Text = "Questions";
            HomePageForm_QuestionsBtn.UseVisualStyleBackColor = true;
            HomePageForm_QuestionsBtn.Click += Button_Questions_Click;
            // 
            // HomePageForm_CategoriesBtn
            // 
            HomePageForm_CategoriesBtn.Cursor = Cursors.Hand;
            HomePageForm_CategoriesBtn.FlatAppearance.BorderSize = 0;
            HomePageForm_CategoriesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            HomePageForm_CategoriesBtn.FlatStyle = FlatStyle.Flat;
            HomePageForm_CategoriesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomePageForm_CategoriesBtn.ForeColor = Color.FromArgb(44, 171, 230);
            HomePageForm_CategoriesBtn.Location = new Point(3, 48);
            HomePageForm_CategoriesBtn.Name = "HomePageForm_CategoriesBtn";
            HomePageForm_CategoriesBtn.Size = new Size(162, 39);
            HomePageForm_CategoriesBtn.TabIndex = 6;
            HomePageForm_CategoriesBtn.Text = "Categories";
            HomePageForm_CategoriesBtn.UseVisualStyleBackColor = true;
            HomePageForm_CategoriesBtn.Click += Button_Categories_Click;
            // 
            // HomePageForm_ImportBtn
            // 
            HomePageForm_ImportBtn.Cursor = Cursors.Hand;
            HomePageForm_ImportBtn.FlatAppearance.BorderSize = 0;
            HomePageForm_ImportBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            HomePageForm_ImportBtn.FlatStyle = FlatStyle.Flat;
            HomePageForm_ImportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomePageForm_ImportBtn.ForeColor = Color.FromArgb(44, 171, 230);
            HomePageForm_ImportBtn.Location = new Point(3, 93);
            HomePageForm_ImportBtn.Name = "HomePageForm_ImportBtn";
            HomePageForm_ImportBtn.Size = new Size(162, 39);
            HomePageForm_ImportBtn.TabIndex = 7;
            HomePageForm_ImportBtn.Text = "Import";
            HomePageForm_ImportBtn.UseVisualStyleBackColor = true;
            HomePageForm_ImportBtn.Click += Button_Import_Click;
            // 
            // HomePageForm_ExportBtn
            // 
            HomePageForm_ExportBtn.Cursor = Cursors.Hand;
            HomePageForm_ExportBtn.FlatAppearance.BorderSize = 0;
            HomePageForm_ExportBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            HomePageForm_ExportBtn.FlatStyle = FlatStyle.Flat;
            HomePageForm_ExportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomePageForm_ExportBtn.ForeColor = Color.FromArgb(44, 171, 230);
            HomePageForm_ExportBtn.Location = new Point(3, 138);
            HomePageForm_ExportBtn.Name = "HomePageForm_ExportBtn";
            HomePageForm_ExportBtn.Size = new Size(162, 39);
            HomePageForm_ExportBtn.TabIndex = 8;
            HomePageForm_ExportBtn.Text = "Export";
            HomePageForm_ExportBtn.UseVisualStyleBackColor = true;
            HomePageForm_ExportBtn.Click += Button_Export_Click;
            // 
            // HomePageForm_QuestionsBankLbl
            // 
            HomePageForm_QuestionsBankLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            HomePageForm_QuestionsBankLbl.AutoSize = true;
            HomePageForm_QuestionsBankLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            HomePageForm_QuestionsBankLbl.ForeColor = Color.FromArgb(44, 171, 230);
            HomePageForm_QuestionsBankLbl.Location = new Point(10, 10);
            HomePageForm_QuestionsBankLbl.Name = "HomePageForm_QuestionsBankLbl";
            HomePageForm_QuestionsBankLbl.Size = new Size(209, 38);
            HomePageForm_QuestionsBankLbl.TabIndex = 0;
            HomePageForm_QuestionsBankLbl.Text = "Question Bank";
            // 
            // panel2
            // 
            panel2.Controls.Add(PopUpForm);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(1385, 514);
            panel2.TabIndex = 3;
            // 
            // PopUpForm
            // 
            PopUpForm.Dock = DockStyle.Fill;
            PopUpForm.Location = new Point(0, 0);
            PopUpForm.Name = "PopUpForm";
            PopUpForm.Size = new Size(1385, 514);
            PopUpForm.TabIndex = 0;
            PopUpForm.Visible = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = "You can return to home using 3-line button on the top-right of your computer screen.";
            notifyIcon1.BalloonTipTitle = "Welcome to our learning system app";
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.Text = "Notification";
            notifyIcon1.Visible = true;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1385, 724);
            Controls.Add(HomePageForm_GearPic);
            Controls.Add(panel_popup);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Learning System";
            Text = "Learning System";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomePageForm_AvatarPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)HomePageForm_MenuPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)HomePageForm_GearPic).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel_popup.ResumeLayout(false);
            panel_popup.PerformLayout();
            flowLayoutPanel_popup.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel3.ClientRectangle,
                    Color.LightBlue, 0, ButtonBorderStyle.Solid,
                    Color.LightBlue, 0, ButtonBorderStyle.Solid,
                    Color.LightBlue, 0, ButtonBorderStyle.Solid,
                    Color.Black, 1, ButtonBorderStyle.Solid);
        }

        #endregion

        private Panel panel1;
        private Label HomePageForm_UserNameLbl;
        private PictureBox HomePageForm_AvatarPic;
        private PictureBox HomePageForm_MenuPic;
        private Panel panel3;
        private PictureBox HomePageForm_GearPic;
        private Label HomePageForm_ITLbl;
        private Button HomePageForm_EditingBtn;
        private Panel panel2;
        private Label HomePageForm_PathLbl;
        private PopUpForm PopUpForm;
        private Label HomePageForm_QuestionsBankLbl;
        private FlowLayoutPanel flowLayoutPanel_popup;
        private Button HomePageForm_QuestionsBtn;
        private Button HomePageForm_CategoriesBtn;
        private Button HomePageForm_ImportBtn;
        private Button HomePageForm_ExportBtn;
        private Panel panel_popup;
        private NotifyIcon notifyIcon1;
    }
}