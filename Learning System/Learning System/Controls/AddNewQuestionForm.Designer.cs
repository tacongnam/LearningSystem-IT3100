using Learning_System.Properties;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Learning_System
{
    partial class AddNewQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewQuestionForm));
            AddNewQuestionForm_HeadingLbl = new Label();
            panel_heading = new Panel();
            panel_body = new Panel();
            panel_button = new Panel();
            AddNewQuestionForm_ErrorLbl = new Label();
            AddNewQuestionForm_MoreChoicesBtn = new Button();
            AddNewQuestionForm_SaveAndContinueBtn = new Button();
            AddNewQuestionForm_SaveBtn = new Button();
            AddNewQuestionForm_CancelBtn = new Button();
            panel_ = new Panel();
            AddNewQuestionForm_TextRtb = new RichTextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            AddNewQuestionForm_CategoryLbl = new Label();
            AddNewQuestionForm_NameLbl = new Label();
            AddNewQuestionForm_TextLbl = new Label();
            AddNewQuestionForm_MarkLbl = new Label();
            AddNewQuestionForm_CategoryCbo = new ComboBox();
            AddNewQuestionForm_NameTxt = new TextBox();
            AddNewQuestionForm_MarkTxt = new TextBox();
            AddNewQuestionForm_ExpandPic = new PictureBox();
            AddNewQuestionForm_GeneralBtn = new Button();
            AddNewQuestionForm_ToolTip = new ToolTip(components);
            HomePageForm_PathLbl = new Label();
            HomePageForm_ITLbl = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            panel_heading.SuspendLayout();
            panel_body.SuspendLayout();
            panel_button.SuspendLayout();
            panel_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddNewQuestionForm_ExpandPic).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // AddNewQuestionForm_HeadingLbl
            // 
            AddNewQuestionForm_HeadingLbl.AutoSize = true;
            AddNewQuestionForm_HeadingLbl.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_HeadingLbl.ForeColor = Color.FromArgb(194, 36, 36);
            AddNewQuestionForm_HeadingLbl.Location = new Point(4, 7);
            AddNewQuestionForm_HeadingLbl.Name = "AddNewQuestionForm_HeadingLbl";
            AddNewQuestionForm_HeadingLbl.Size = new Size(634, 54);
            AddNewQuestionForm_HeadingLbl.TabIndex = 8;
            AddNewQuestionForm_HeadingLbl.Text = "Adding a Multiple choice question";
            // 
            // panel_heading
            // 
            panel_heading.BackColor = SystemColors.ControlLightLight;
            panel_heading.Controls.Add(AddNewQuestionForm_HeadingLbl);
            panel_heading.Dock = DockStyle.Top;
            panel_heading.Location = new Point(0, 207);
            panel_heading.Name = "panel_heading";
            panel_heading.Size = new Size(1233, 71);
            panel_heading.TabIndex = 9;
            // 
            // panel_body
            // 
            panel_body.AutoScroll = true;
            panel_body.BackColor = SystemColors.ControlLightLight;
            panel_body.Controls.Add(panel_button);
            panel_body.Controls.Add(panel_);
            panel_body.Controls.Add(AddNewQuestionForm_ExpandPic);
            panel_body.Controls.Add(AddNewQuestionForm_GeneralBtn);
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(0, 278);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(1233, 705);
            panel_body.TabIndex = 0;
            // 
            // panel_button
            // 
            panel_button.Controls.Add(AddNewQuestionForm_ErrorLbl);
            panel_button.Controls.Add(AddNewQuestionForm_MoreChoicesBtn);
            panel_button.Controls.Add(AddNewQuestionForm_SaveAndContinueBtn);
            panel_button.Controls.Add(AddNewQuestionForm_SaveBtn);
            panel_button.Controls.Add(AddNewQuestionForm_CancelBtn);
            panel_button.Location = new Point(0, 511);
            panel_button.Margin = new Padding(2);
            panel_button.Name = "panel_button";
            panel_button.Size = new Size(1233, 258);
            panel_button.TabIndex = 0;
            // 
            // AddNewQuestionForm_ErrorLbl
            // 
            AddNewQuestionForm_ErrorLbl.AutoSize = true;
            AddNewQuestionForm_ErrorLbl.Location = new Point(429, 91);
            AddNewQuestionForm_ErrorLbl.Name = "AddNewQuestionForm_ErrorLbl";
            AddNewQuestionForm_ErrorLbl.Size = new Size(0, 20);
            AddNewQuestionForm_ErrorLbl.TabIndex = 0;
            // 
            // AddNewQuestionForm_MoreChoicesBtn
            // 
            AddNewQuestionForm_MoreChoicesBtn.BackColor = Color.FromArgb(0, 159, 229);
            AddNewQuestionForm_MoreChoicesBtn.Cursor = Cursors.Hand;
            AddNewQuestionForm_MoreChoicesBtn.FlatStyle = FlatStyle.Flat;
            AddNewQuestionForm_MoreChoicesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_MoreChoicesBtn.ForeColor = Color.White;
            AddNewQuestionForm_MoreChoicesBtn.Location = new Point(429, 24);
            AddNewQuestionForm_MoreChoicesBtn.Name = "AddNewQuestionForm_MoreChoicesBtn";
            AddNewQuestionForm_MoreChoicesBtn.Size = new Size(328, 51);
            AddNewQuestionForm_MoreChoicesBtn.TabIndex = 99;
            AddNewQuestionForm_MoreChoicesBtn.Text = "BLANKS FOR 3 MORE CHOICES ";
            AddNewQuestionForm_MoreChoicesBtn.UseVisualStyleBackColor = false;
            AddNewQuestionForm_MoreChoicesBtn.Click += AddNewQuestionForm_MoreChoicesBtn_Click;
            // 
            // AddNewQuestionForm_SaveAndContinueBtn
            // 
            AddNewQuestionForm_SaveAndContinueBtn.BackColor = Color.FromArgb(0, 159, 229);
            AddNewQuestionForm_SaveAndContinueBtn.Cursor = Cursors.Hand;
            AddNewQuestionForm_SaveAndContinueBtn.FlatStyle = FlatStyle.Flat;
            AddNewQuestionForm_SaveAndContinueBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_SaveAndContinueBtn.ForeColor = Color.White;
            AddNewQuestionForm_SaveAndContinueBtn.Location = new Point(429, 129);
            AddNewQuestionForm_SaveAndContinueBtn.Name = "AddNewQuestionForm_SaveAndContinueBtn";
            AddNewQuestionForm_SaveAndContinueBtn.Size = new Size(407, 51);
            AddNewQuestionForm_SaveAndContinueBtn.TabIndex = 100;
            AddNewQuestionForm_SaveAndContinueBtn.Text = "SAVE CHANGES AND CONTINUE EDITING";
            AddNewQuestionForm_SaveAndContinueBtn.UseVisualStyleBackColor = false;
            AddNewQuestionForm_SaveAndContinueBtn.Click += AddNewQuestionForm_SaveAndContinueBtn_Click;
            // 
            // AddNewQuestionForm_SaveBtn
            // 
            AddNewQuestionForm_SaveBtn.BackColor = Color.FromArgb(194, 36, 36);
            AddNewQuestionForm_SaveBtn.Cursor = Cursors.Hand;
            AddNewQuestionForm_SaveBtn.FlatStyle = FlatStyle.Flat;
            AddNewQuestionForm_SaveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_SaveBtn.ForeColor = Color.White;
            AddNewQuestionForm_SaveBtn.Location = new Point(429, 186);
            AddNewQuestionForm_SaveBtn.Name = "AddNewQuestionForm_SaveBtn";
            AddNewQuestionForm_SaveBtn.Size = new Size(181, 53);
            AddNewQuestionForm_SaveBtn.TabIndex = 101;
            AddNewQuestionForm_SaveBtn.Text = "SAVE CHANGES";
            AddNewQuestionForm_SaveBtn.UseVisualStyleBackColor = false;
            AddNewQuestionForm_SaveBtn.Click += AddNewQuestionForm_SaveBtn_Click;
            // 
            // AddNewQuestionForm_CancelBtn
            // 
            AddNewQuestionForm_CancelBtn.BackColor = Color.FromArgb(0, 159, 229);
            AddNewQuestionForm_CancelBtn.Cursor = Cursors.Hand;
            AddNewQuestionForm_CancelBtn.FlatStyle = FlatStyle.Flat;
            AddNewQuestionForm_CancelBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_CancelBtn.ForeColor = Color.White;
            AddNewQuestionForm_CancelBtn.Location = new Point(643, 186);
            AddNewQuestionForm_CancelBtn.Name = "AddNewQuestionForm_CancelBtn";
            AddNewQuestionForm_CancelBtn.Size = new Size(135, 53);
            AddNewQuestionForm_CancelBtn.TabIndex = 102;
            AddNewQuestionForm_CancelBtn.Text = "CANCEL";
            AddNewQuestionForm_CancelBtn.UseVisualStyleBackColor = false;
            AddNewQuestionForm_CancelBtn.Click += AddNewQuestionForm_CancelBtn_Click;
            // 
            // panel_
            // 
            panel_.BackColor = SystemColors.ControlLightLight;
            panel_.Controls.Add(AddNewQuestionForm_TextRtb);
            panel_.Controls.Add(pictureBox3);
            panel_.Controls.Add(pictureBox1);
            panel_.Controls.Add(pictureBox2);
            panel_.Controls.Add(AddNewQuestionForm_CategoryLbl);
            panel_.Controls.Add(AddNewQuestionForm_NameLbl);
            panel_.Controls.Add(AddNewQuestionForm_TextLbl);
            panel_.Controls.Add(AddNewQuestionForm_MarkLbl);
            panel_.Controls.Add(AddNewQuestionForm_CategoryCbo);
            panel_.Controls.Add(AddNewQuestionForm_NameTxt);
            panel_.Controls.Add(AddNewQuestionForm_MarkTxt);
            panel_.Dock = DockStyle.Top;
            panel_.Location = new Point(0, 0);
            panel_.Name = "panel_";
            panel_.Size = new Size(1233, 474);
            panel_.TabIndex = 0;
            // 
            // AddNewQuestionForm_TextRtb
            // 
            AddNewQuestionForm_TextRtb.AutoSize = true;
            AddNewQuestionForm_TextRtb.EnableAutoDragDrop = true;
            AddNewQuestionForm_TextRtb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_TextRtb.Location = new Point(460, 174);
            AddNewQuestionForm_TextRtb.Name = "AddNewQuestionForm_TextRtb";
            AddNewQuestionForm_TextRtb.Size = new Size(730, 235);
            AddNewQuestionForm_TextRtb.TabIndex = 10;
            AddNewQuestionForm_TextRtb.Text = "";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.exclaimation_removebg_preview;
            pictureBox3.Location = new Point(429, 442);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            AddNewQuestionForm_ToolTip.SetToolTip(pictureBox3, "Required");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.exclaimation_removebg_preview;
            pictureBox1.Location = new Point(429, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            AddNewQuestionForm_ToolTip.SetToolTip(pictureBox1, "Required");
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.exclaimation_removebg_preview;
            pictureBox2.Location = new Point(429, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            AddNewQuestionForm_ToolTip.SetToolTip(pictureBox2, "Required");
            // 
            // AddNewQuestionForm_CategoryLbl
            // 
            AddNewQuestionForm_CategoryLbl.AutoSize = true;
            AddNewQuestionForm_CategoryLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_CategoryLbl.Location = new Point(33, 56);
            AddNewQuestionForm_CategoryLbl.Name = "AddNewQuestionForm_CategoryLbl";
            AddNewQuestionForm_CategoryLbl.Size = new Size(88, 25);
            AddNewQuestionForm_CategoryLbl.TabIndex = 4;
            AddNewQuestionForm_CategoryLbl.Text = "Category";
            // 
            // AddNewQuestionForm_NameLbl
            // 
            AddNewQuestionForm_NameLbl.AutoSize = true;
            AddNewQuestionForm_NameLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_NameLbl.Location = new Point(33, 104);
            AddNewQuestionForm_NameLbl.Name = "AddNewQuestionForm_NameLbl";
            AddNewQuestionForm_NameLbl.Size = new Size(140, 25);
            AddNewQuestionForm_NameLbl.TabIndex = 5;
            AddNewQuestionForm_NameLbl.Text = "Question name";
            // 
            // AddNewQuestionForm_TextLbl
            // 
            AddNewQuestionForm_TextLbl.AutoSize = true;
            AddNewQuestionForm_TextLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_TextLbl.Location = new Point(33, 180);
            AddNewQuestionForm_TextLbl.Name = "AddNewQuestionForm_TextLbl";
            AddNewQuestionForm_TextLbl.Size = new Size(124, 25);
            AddNewQuestionForm_TextLbl.TabIndex = 6;
            AddNewQuestionForm_TextLbl.Text = "Question text";
            // 
            // AddNewQuestionForm_MarkLbl
            // 
            AddNewQuestionForm_MarkLbl.AutoSize = true;
            AddNewQuestionForm_MarkLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_MarkLbl.Location = new Point(33, 439);
            AddNewQuestionForm_MarkLbl.Name = "AddNewQuestionForm_MarkLbl";
            AddNewQuestionForm_MarkLbl.Size = new Size(120, 25);
            AddNewQuestionForm_MarkLbl.TabIndex = 7;
            AddNewQuestionForm_MarkLbl.Text = "Default mark";
            // 
            // AddNewQuestionForm_CategoryCbo
            // 
            AddNewQuestionForm_CategoryCbo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_CategoryCbo.FormattingEnabled = true;
            AddNewQuestionForm_CategoryCbo.Items.AddRange(new object[] { "Default" });
            AddNewQuestionForm_CategoryCbo.Location = new Point(460, 53);
            AddNewQuestionForm_CategoryCbo.Name = "AddNewQuestionForm_CategoryCbo";
            AddNewQuestionForm_CategoryCbo.Size = new Size(281, 33);
            AddNewQuestionForm_CategoryCbo.TabIndex = 8;
            AddNewQuestionForm_CategoryCbo.Text = "Default";
            AddNewQuestionForm_CategoryCbo.DropDown += AddNewQuestionForm_CategoryCbo_DropDown;
            // 
            // AddNewQuestionForm_NameTxt
            // 
            AddNewQuestionForm_NameTxt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_NameTxt.Location = new Point(460, 101);
            AddNewQuestionForm_NameTxt.Name = "AddNewQuestionForm_NameTxt";
            AddNewQuestionForm_NameTxt.Size = new Size(281, 32);
            AddNewQuestionForm_NameTxt.TabIndex = 9;
            // 
            // AddNewQuestionForm_MarkTxt
            // 
            AddNewQuestionForm_MarkTxt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_MarkTxt.Location = new Point(460, 436);
            AddNewQuestionForm_MarkTxt.Name = "AddNewQuestionForm_MarkTxt";
            AddNewQuestionForm_MarkTxt.Size = new Size(281, 32);
            AddNewQuestionForm_MarkTxt.TabIndex = 11;
            AddNewQuestionForm_MarkTxt.Text = "1";
            // 
            // AddNewQuestionForm_ExpandPic
            // 
            AddNewQuestionForm_ExpandPic.Image = (Image)resources.GetObject("AddNewQuestionForm_ExpandPic.Image");
            AddNewQuestionForm_ExpandPic.Location = new Point(32, 17);
            AddNewQuestionForm_ExpandPic.Name = "AddNewQuestionForm_ExpandPic";
            AddNewQuestionForm_ExpandPic.Size = new Size(15, 10);
            AddNewQuestionForm_ExpandPic.SizeMode = PictureBoxSizeMode.Zoom;
            AddNewQuestionForm_ExpandPic.TabIndex = 0;
            AddNewQuestionForm_ExpandPic.TabStop = false;
            // 
            // AddNewQuestionForm_GeneralBtn
            // 
            AddNewQuestionForm_GeneralBtn.FlatAppearance.BorderSize = 0;
            AddNewQuestionForm_GeneralBtn.FlatStyle = FlatStyle.Flat;
            AddNewQuestionForm_GeneralBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuestionForm_GeneralBtn.ForeColor = Color.FromArgb(194, 36, 36);
            AddNewQuestionForm_GeneralBtn.Location = new Point(33, 6);
            AddNewQuestionForm_GeneralBtn.Name = "AddNewQuestionForm_GeneralBtn";
            AddNewQuestionForm_GeneralBtn.Size = new Size(96, 28);
            AddNewQuestionForm_GeneralBtn.TabIndex = 3;
            AddNewQuestionForm_GeneralBtn.Text = "General";
            AddNewQuestionForm_GeneralBtn.UseVisualStyleBackColor = true;
            // 
            // HomePageForm_PathLbl
            // 
            HomePageForm_PathLbl.AutoSize = true;
            HomePageForm_PathLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            HomePageForm_PathLbl.Location = new Point(31, 150);
            HomePageForm_PathLbl.Name = "HomePageForm_PathLbl";
            HomePageForm_PathLbl.Size = new Size(859, 25);
            HomePageForm_PathLbl.TabIndex = 1;
            HomePageForm_PathLbl.Text = "Home  /  My courses  /  THI CUỐI KỲ / Question bank / Questions / Editing a Multiple choice question";
            // 
            // HomePageForm_ITLbl
            // 
            HomePageForm_ITLbl.AutoSize = true;
            HomePageForm_ITLbl.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            HomePageForm_ITLbl.ForeColor = Color.FromArgb(194, 36, 36);
            HomePageForm_ITLbl.Location = new Point(31, 80);
            HomePageForm_ITLbl.Name = "HomePageForm_ITLbl";
            HomePageForm_ITLbl.Size = new Size(60, 60);
            HomePageForm_ITLbl.TabIndex = 0;
            HomePageForm_ITLbl.Text = "IT";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(HomePageForm_PathLbl);
            panel3.Controls.Add(HomePageForm_ITLbl);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1233, 207);
            panel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 115, 165);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 64);
            panel1.TabIndex = 10;
            // 
            // AddNewQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1233, 983);
            Controls.Add(panel_body);
            Controls.Add(panel_heading);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewQuestionForm";
            WindowState = FormWindowState.Maximized;
            panel_heading.ResumeLayout(false);
            panel_heading.PerformLayout();
            panel_body.ResumeLayout(false);
            panel_button.ResumeLayout(false);
            panel_button.PerformLayout();
            panel_.ResumeLayout(false);
            panel_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddNewQuestionForm_ExpandPic).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label AddNewQuestionForm_HeadingLbl;
        private Panel panel_heading;
        private Panel panel_body;
        private Label AddNewQuestionForm_CategoryLbl;
        private Button AddNewQuestionForm_GeneralBtn;
        private ComboBox AddNewQuestionForm_CategoryCbo;
        private Label AddNewQuestionForm_MarkLbl;
        private Label AddNewQuestionForm_TextLbl;
        private Label AddNewQuestionForm_NameLbl;
        private TextBox AddNewQuestionForm_MarkTxt;
        private TextBox AddNewQuestionForm_NameTxt;
        private Button AddNewQuestionForm_MoreChoicesBtn;
        private Button AddNewQuestionForm_SaveBtn;
        private Button AddNewQuestionForm_CancelBtn;
        private Button AddNewQuestionForm_SaveAndContinueBtn;
        private PictureBox AddNewQuestionForm_ExpandPic;
        private RichTextBox AddNewQuestionForm_TextRtb;
        private Panel panel_;
        private Panel panel_button;
        private Label AddNewQuestionForm_ErrorLbl;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private ToolTip AddNewQuestionForm_ToolTip;

        private Panel panel3;
        private Label HomePageForm_PathLbl;
        private Label HomePageForm_ITLbl;
        private Panel panel1;
    }
}
