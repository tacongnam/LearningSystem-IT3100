using System.Windows.Forms;

namespace Learning_System
{
    partial class ContestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContestForm));
            panel1 = new Panel();
            ContestForm_MenuPic = new PictureBox();
            panel_heading = new Panel();
            ContestForm_PathLbl = new Label();
            ContestForm_ITLbl = new Label();
            panel_body = new Panel();
            panel_main = new Panel();
            ContestForm_PreviewQuizBtn = new Button();
            ContestForm_SummaryLbl = new Label();
            ContestForm_GradingMethodLbl = new Label();
            ContestForm_TimeLbl = new Label();
            ContestForm_EditPic = new PictureBox();
            ContestForm_ContestNameLbl = new Label();
            ContestForm_Tooltip = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContestForm_MenuPic).BeginInit();
            panel_heading.SuspendLayout();
            panel_body.SuspendLayout();
            panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContestForm_EditPic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 159, 229);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ContestForm_MenuPic);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1409, 64);
            panel1.TabIndex = 1;
            // 
            // ContestForm_MenuPic
            // 
            ContestForm_MenuPic.Cursor = Cursors.Hand;
            ContestForm_MenuPic.Image = (Image)resources.GetObject("ContestForm_MenuPic.Image");
            ContestForm_MenuPic.Location = new Point(27, 13);
            ContestForm_MenuPic.Name = "ContestForm_MenuPic";
            ContestForm_MenuPic.Size = new Size(49, 33);
            ContestForm_MenuPic.SizeMode = PictureBoxSizeMode.Zoom;
            ContestForm_MenuPic.TabIndex = 5;
            ContestForm_MenuPic.TabStop = false;
            ContestForm_Tooltip.SetToolTip(ContestForm_MenuPic, "Click here to return home page");
            ContestForm_MenuPic.Click += ContestForm_MenuPic_Click;
            // 
            // panel_heading
            // 
            panel_heading.BackColor = Color.White;
            panel_heading.BorderStyle = BorderStyle.FixedSingle;
            panel_heading.Controls.Add(ContestForm_PathLbl);
            panel_heading.Controls.Add(ContestForm_ITLbl);
            panel_heading.Dock = DockStyle.Top;
            panel_heading.Location = new Point(0, 64);
            panel_heading.Name = "panel_heading";
            panel_heading.Size = new Size(1409, 146);
            panel_heading.TabIndex = 3;
            // 
            // ContestForm_PathLbl
            // 
            ContestForm_PathLbl.AutoSize = true;
            ContestForm_PathLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ContestForm_PathLbl.Location = new Point(23, 83);
            ContestForm_PathLbl.Name = "ContestForm_PathLbl";
            ContestForm_PathLbl.Size = new Size(291, 23);
            ContestForm_PathLbl.TabIndex = 1;
            ContestForm_PathLbl.Text = "Home  /  My courses  /  THI CUỐI KỲ";
            // 
            // ContestForm_ITLbl
            // 
            ContestForm_ITLbl.AutoSize = true;
            ContestForm_ITLbl.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            ContestForm_ITLbl.ForeColor = Color.FromArgb(194, 36, 36);
            ContestForm_ITLbl.Location = new Point(23, 13);
            ContestForm_ITLbl.Name = "ContestForm_ITLbl";
            ContestForm_ITLbl.Size = new Size(60, 60);
            ContestForm_ITLbl.TabIndex = 0;
            ContestForm_ITLbl.Text = "IT";
            // 
            // panel_body
            // 
            panel_body.Controls.Add(panel_main);
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(0, 210);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(1409, 501);
            panel_body.TabIndex = 4;
            // 
            // panel_main
            // 
            panel_main.BackColor = Color.White;
            panel_main.Controls.Add(ContestForm_PreviewQuizBtn);
            panel_main.Controls.Add(ContestForm_SummaryLbl);
            panel_main.Controls.Add(ContestForm_GradingMethodLbl);
            panel_main.Controls.Add(ContestForm_TimeLbl);
            panel_main.Controls.Add(ContestForm_EditPic);
            panel_main.Controls.Add(ContestForm_ContestNameLbl);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(0, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1409, 501);
            panel_main.TabIndex = 0;
            // 
            // ContestForm_PreviewQuizBtn
            // 
            ContestForm_PreviewQuizBtn.Anchor = AnchorStyles.Bottom;
            ContestForm_PreviewQuizBtn.BackColor = Color.FromArgb(0, 159, 229);
            ContestForm_PreviewQuizBtn.Cursor = Cursors.Hand;
            ContestForm_PreviewQuizBtn.FlatStyle = FlatStyle.Flat;
            ContestForm_PreviewQuizBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ContestForm_PreviewQuizBtn.ForeColor = Color.White;
            ContestForm_PreviewQuizBtn.Location = new Point(589, 305);
            ContestForm_PreviewQuizBtn.Name = "ContestForm_PreviewQuizBtn";
            ContestForm_PreviewQuizBtn.Size = new Size(262, 54);
            ContestForm_PreviewQuizBtn.TabIndex = 6;
            ContestForm_PreviewQuizBtn.Text = "PREVIEW QUIZ NOW";
            ContestForm_PreviewQuizBtn.UseVisualStyleBackColor = false;
            ContestForm_PreviewQuizBtn.Click += ContestForm_PreviewQuizBtn_Click;
            // 
            // ContestForm_SummaryLbl
            // 
            ContestForm_SummaryLbl.AutoSize = true;
            ContestForm_SummaryLbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            ContestForm_SummaryLbl.ForeColor = Color.FromArgb(194, 36, 36);
            ContestForm_SummaryLbl.Location = new Point(23, 210);
            ContestForm_SummaryLbl.Name = "ContestForm_SummaryLbl";
            ContestForm_SummaryLbl.Size = new Size(555, 46);
            ContestForm_SummaryLbl.TabIndex = 5;
            ContestForm_SummaryLbl.Text = "Summary of your previous attempts";
            // 
            // ContestForm_GradingMethodLbl
            // 
            ContestForm_GradingMethodLbl.Anchor = AnchorStyles.Top;
            ContestForm_GradingMethodLbl.AutoSize = true;
            ContestForm_GradingMethodLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ContestForm_GradingMethodLbl.Location = new Point(576, 162);
            ContestForm_GradingMethodLbl.Name = "ContestForm_GradingMethodLbl";
            ContestForm_GradingMethodLbl.Size = new Size(262, 25);
            ContestForm_GradingMethodLbl.TabIndex = 3;
            ContestForm_GradingMethodLbl.Text = "Grading method: Last attempt";
            ContestForm_GradingMethodLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContestForm_TimeLbl
            // 
            ContestForm_TimeLbl.Anchor = AnchorStyles.Top;
            ContestForm_TimeLbl.AutoSize = true;
            ContestForm_TimeLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ContestForm_TimeLbl.Location = new Point(612, 119);
            ContestForm_TimeLbl.Name = "ContestForm_TimeLbl";
            ContestForm_TimeLbl.Size = new Size(206, 25);
            ContestForm_TimeLbl.TabIndex = 2;
            ContestForm_TimeLbl.Text = "Time limit: 999 minutes";
            ContestForm_TimeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContestForm_EditPic
            // 
            ContestForm_EditPic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ContestForm_EditPic.Cursor = Cursors.Hand;
            ContestForm_EditPic.Image = (Image)resources.GetObject("ContestForm_EditPic.Image");
            ContestForm_EditPic.Location = new Point(1334, 19);
            ContestForm_EditPic.Name = "ContestForm_EditPic";
            ContestForm_EditPic.Size = new Size(53, 38);
            ContestForm_EditPic.SizeMode = PictureBoxSizeMode.Zoom;
            ContestForm_EditPic.TabIndex = 1;
            ContestForm_EditPic.TabStop = false;
            ContestForm_EditPic.Click += ContestForm_EditPic_Click;
            // 
            // ContestForm_ContestNameLbl
            // 
            ContestForm_ContestNameLbl.AutoSize = true;
            ContestForm_ContestNameLbl.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            ContestForm_ContestNameLbl.ForeColor = Color.FromArgb(194, 36, 36);
            ContestForm_ContestNameLbl.Location = new Point(23, 19);
            ContestForm_ContestNameLbl.Name = "ContestForm_ContestNameLbl";
            ContestForm_ContestNameLbl.Size = new Size(600, 60);
            ContestForm_ContestNameLbl.TabIndex = 0;
            ContestForm_ContestNameLbl.Text = "Thi giữa kỳ 2 môn Công nghệ";
            // 
            // ContestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1409, 711);
            Controls.Add(panel_body);
            Controls.Add(panel_heading);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ContestForm";
            Text = "ContestForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContestForm_MenuPic).EndInit();
            panel_heading.ResumeLayout(false);
            panel_heading.PerformLayout();
            panel_body.ResumeLayout(false);
            panel_main.ResumeLayout(false);
            panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ContestForm_EditPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel_heading;
        public Label ContestForm_PathLbl;
        private Label ContestForm_ITLbl;
        private Panel panel_body;
        private Panel panel_main;
        private Label ContestForm_ContestNameLbl;
        private Button ContestForm_PreviewQuizBtn;
        private Label ContestForm_SummaryLbl;
        private Label ContestForm_GradingMethodLbl;
        private Label ContestForm_TimeLbl;
        private PictureBox ContestForm_EditPic;
        private PictureBox ContestForm_MenuPic;
        private ToolTip ContestForm_Tooltip;
    }
}