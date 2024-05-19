using System.ComponentModel;

namespace Learning_System;

partial class AddingNewQuiz
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        components = new Container();
        Button btn_Cancel;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(AddingNewQuiz));
        AddNewQuizForm_HeadingLbl = new Label();
        AddNewQuizForm_GeneralLbl = new Label();
        AddNewQuizForm_NameLbl = new Label();
        AddNewQuizForm_NameTxt = new TextBox();
        AddNewQuizFormLbl_Description = new Label();
        AddNewQuizFormTxt_Description = new TextBox();
        AddNewQuizForm_LineLbl = new Label();
        AddNewQuizForm_TiminglLbl = new Label();
        AddNewQuizForm_OpenthequizLbl = new Label();
        AddNewQuizForm_ClosethequizLbl = new Label();
        AddNewQuizForm_Timelimit = new Label();
        AddNewQuizForm_Timeexpires = new Label();
        AddingNewQuizForm_openMonthCbo = new ComboBox();
        timeLimitLabel = new Label();
        AddNewQuizForm_TimelimiMinuteCbo = new ComboBox();
        AddNewQuizForm_TimeexpiresCloseCbo = new ComboBox();
        btn_Create = new Button();
        AddingNewQuizForm_DisplayCb = new CheckBox();
        AddingNewQuizForm_openEnableCb = new CheckBox();
        AddingNewQuizForm_closeEnableCB = new CheckBox();
        AddingNewQuizForm_timeLimitEnableCB = new CheckBox();
        AddingNewQuizForm_openDayNud = new NumericUpDown();
        AddingNewQuizForm_closeDayNud = new NumericUpDown();
        AddingNewQuizForm_closeMonthCbo = new ComboBox();
        AddingNewQuizForm_openYearNud = new NumericUpDown();
        AddingNewQuizForm_closeYearNud = new NumericUpDown();
        AddingNewQuizForm_openHourNud = new NumericUpDown();
        AddingNewQuizForm_openMinuteNud = new NumericUpDown();
        AddingNewQuizForm_closeHourNud = new NumericUpDown();
        AddingNewQuizForm_closeMinuteNud = new NumericUpDown();
        AddingNewQuizForm_timeLimitTxt = new TextBox();
        ImportForm_ExpandPic1 = new PictureBox();
        pictureBox1 = new PictureBox();
        pictureBox4 = new PictureBox();
        pictureBox5 = new PictureBox();
        pictureBox8 = new PictureBox();
        pictureBox9 = new PictureBox();
        pictureBox10 = new PictureBox();
        pictureBox2 = new PictureBox();
        pictureBox3 = new PictureBox();
        AddingNewQuiz_Tooltip = new ToolTip(components);
        btn_Cancel = new Button();
        ((ISupportInitialize)AddingNewQuizForm_openDayNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_closeDayNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_openYearNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_closeYearNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_openHourNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_openMinuteNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_closeHourNud).BeginInit();
        ((ISupportInitialize)AddingNewQuizForm_closeMinuteNud).BeginInit();
        ((ISupportInitialize)ImportForm_ExpandPic1).BeginInit();
        ((ISupportInitialize)pictureBox1).BeginInit();
        ((ISupportInitialize)pictureBox4).BeginInit();
        ((ISupportInitialize)pictureBox5).BeginInit();
        ((ISupportInitialize)pictureBox8).BeginInit();
        ((ISupportInitialize)pictureBox9).BeginInit();
        ((ISupportInitialize)pictureBox10).BeginInit();
        ((ISupportInitialize)pictureBox2).BeginInit();
        ((ISupportInitialize)pictureBox3).BeginInit();
        SuspendLayout();
        // 
        // btn_Cancel
        // 
        btn_Cancel.BackColor = Color.FromArgb(0, 159, 229);
        btn_Cancel.FlatStyle = FlatStyle.Flat;
        btn_Cancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btn_Cancel.ForeColor = Color.White;
        btn_Cancel.Location = new Point(495, 629);
        btn_Cancel.Name = "btn_Cancel";
        btn_Cancel.Size = new Size(160, 53);
        btn_Cancel.TabIndex = 36;
        btn_Cancel.Text = "CANCEL";
        btn_Cancel.UseVisualStyleBackColor = false;
        btn_Cancel.Click += Btn_Cancel_Click;
        btn_Cancel.Cursor = Cursors.Hand;
        // 
        // AddNewQuizForm_HeadingLbl
        // 
        AddNewQuizForm_HeadingLbl.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_HeadingLbl.ForeColor = Color.FromArgb(194, 36, 36);
        AddNewQuizForm_HeadingLbl.Location = new Point(4, 7);
        AddNewQuizForm_HeadingLbl.Name = "AddNewQuizForm_HeadingLbl";
        AddNewQuizForm_HeadingLbl.Size = new Size(533, 46);
        AddNewQuizForm_HeadingLbl.TabIndex = 0;
        AddNewQuizForm_HeadingLbl.Text = "Adding a new Quiz";
        // 
        // AddNewQuizForm_GeneralLbl
        // 
        AddNewQuizForm_GeneralLbl.AutoSize = true;
        AddNewQuizForm_GeneralLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
        AddNewQuizForm_GeneralLbl.ForeColor = Color.FromArgb(194, 36, 36);
        AddNewQuizForm_GeneralLbl.Location = new Point(39, 66);
        AddNewQuizForm_GeneralLbl.Name = "AddNewQuizForm_GeneralLbl";
        AddNewQuizForm_GeneralLbl.Size = new Size(71, 23);
        AddNewQuizForm_GeneralLbl.TabIndex = 1;
        AddNewQuizForm_GeneralLbl.Text = "General";
        // 
        // AddNewQuizForm_NameLbl
        // 
        AddNewQuizForm_NameLbl.AutoSize = true;
        AddNewQuizForm_NameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_NameLbl.Location = new Point(25, 100);
        AddNewQuizForm_NameLbl.Name = "AddNewQuizForm_NameLbl";
        AddNewQuizForm_NameLbl.Size = new Size(56, 23);
        AddNewQuizForm_NameLbl.TabIndex = 3;
        AddNewQuizForm_NameLbl.Text = "Name";
        // 
        // AddNewQuizForm_NameTxt
        // 
        AddNewQuizForm_NameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_NameTxt.Location = new Point(237, 100);
        AddNewQuizForm_NameTxt.Multiline = true;
        AddNewQuizForm_NameTxt.Name = "AddNewQuizForm_NameTxt";
        AddNewQuizForm_NameTxt.Size = new Size(400, 27);
        AddNewQuizForm_NameTxt.TabIndex = 4;
        // 
        // AddNewQuizFormLbl_Description
        // 
        AddNewQuizFormLbl_Description.AutoSize = true;
        AddNewQuizFormLbl_Description.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizFormLbl_Description.Location = new Point(25, 140);
        AddNewQuizFormLbl_Description.Name = "AddNewQuizFormLbl_Description";
        AddNewQuizFormLbl_Description.Size = new Size(96, 23);
        AddNewQuizFormLbl_Description.TabIndex = 5;
        AddNewQuizFormLbl_Description.Text = "Description";
        AddNewQuizFormLbl_Description.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AddNewQuizFormTxt_Description
        // 
        AddNewQuizFormTxt_Description.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizFormTxt_Description.Location = new Point(237, 140);
        AddNewQuizFormTxt_Description.Multiline = true;
        AddNewQuizFormTxt_Description.Name = "AddNewQuizFormTxt_Description";
        AddNewQuizFormTxt_Description.Size = new Size(627, 200);
        AddNewQuizFormTxt_Description.TabIndex = 6;
        // 
        // AddNewQuizForm_LineLbl
        // 
        AddNewQuizForm_LineLbl.BorderStyle = BorderStyle.FixedSingle;
        AddNewQuizForm_LineLbl.Location = new Point(24, 387);
        AddNewQuizForm_LineLbl.Name = "AddNewQuizForm_LineLbl";
        AddNewQuizForm_LineLbl.Size = new Size(840, 1);
        AddNewQuizForm_LineLbl.TabIndex = 9;
        // 
        // AddNewQuizForm_TiminglLbl
        // 
        AddNewQuizForm_TiminglLbl.AutoSize = true;
        AddNewQuizForm_TiminglLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
        AddNewQuizForm_TiminglLbl.ForeColor = Color.FromArgb(194, 36, 36);
        AddNewQuizForm_TiminglLbl.Location = new Point(39, 399);
        AddNewQuizForm_TiminglLbl.Name = "AddNewQuizForm_TiminglLbl";
        AddNewQuizForm_TiminglLbl.Size = new Size(67, 23);
        AddNewQuizForm_TiminglLbl.TabIndex = 10;
        AddNewQuizForm_TiminglLbl.Text = "Timing";
        // 
        // AddNewQuizForm_OpenthequizLbl
        // 
        AddNewQuizForm_OpenthequizLbl.AutoSize = true;
        AddNewQuizForm_OpenthequizLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_OpenthequizLbl.Location = new Point(25, 444);
        AddNewQuizForm_OpenthequizLbl.Name = "AddNewQuizForm_OpenthequizLbl";
        AddNewQuizForm_OpenthequizLbl.Size = new Size(119, 23);
        AddNewQuizForm_OpenthequizLbl.TabIndex = 11;
        AddNewQuizForm_OpenthequizLbl.Text = "Open the quiz";
        // 
        // AddNewQuizForm_ClosethequizLbl
        // 
        AddNewQuizForm_ClosethequizLbl.AutoSize = true;
        AddNewQuizForm_ClosethequizLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_ClosethequizLbl.Location = new Point(24, 486);
        AddNewQuizForm_ClosethequizLbl.Name = "AddNewQuizForm_ClosethequizLbl";
        AddNewQuizForm_ClosethequizLbl.Size = new Size(118, 23);
        AddNewQuizForm_ClosethequizLbl.TabIndex = 12;
        AddNewQuizForm_ClosethequizLbl.Text = "Close the quiz";
        // 
        // AddNewQuizForm_Timelimit
        // 
        AddNewQuizForm_Timelimit.AutoSize = true;
        AddNewQuizForm_Timelimit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_Timelimit.Location = new Point(25, 529);
        AddNewQuizForm_Timelimit.Name = "AddNewQuizForm_Timelimit";
        AddNewQuizForm_Timelimit.Size = new Size(85, 23);
        AddNewQuizForm_Timelimit.TabIndex = 13;
        AddNewQuizForm_Timelimit.Text = "Time limit";
        // 
        // AddNewQuizForm_Timeexpires
        // 
        AddNewQuizForm_Timeexpires.AutoSize = true;
        AddNewQuizForm_Timeexpires.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_Timeexpires.Location = new Point(25, 573);
        AddNewQuizForm_Timeexpires.Name = "AddNewQuizForm_Timeexpires";
        AddNewQuizForm_Timeexpires.Size = new Size(152, 23);
        AddNewQuizForm_Timeexpires.TabIndex = 14;
        AddNewQuizForm_Timeexpires.Text = "When time expires";
        // 
        // AddingNewQuizForm_openMonthCbo
        // 
        AddingNewQuizForm_openMonthCbo.Enabled = false;
        AddingNewQuizForm_openMonthCbo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_openMonthCbo.ItemHeight = 23;
        AddingNewQuizForm_openMonthCbo.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
        AddingNewQuizForm_openMonthCbo.Location = new Point(307, 440);
        AddingNewQuizForm_openMonthCbo.Name = "AddingNewQuizForm_openMonthCbo";
        AddingNewQuizForm_openMonthCbo.Size = new Size(90, 31);
        AddingNewQuizForm_openMonthCbo.TabIndex = 16;
        AddingNewQuizForm_openMonthCbo.SelectedIndexChanged += AddingNewQuizForm_openMonthCbo_SelectedIndexChanged;
        // 
        // timeLimitLabel
        // 
        timeLimitLabel.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
        timeLimitLabel.Location = new Point(295, 765);
        timeLimitLabel.Name = "timeLimitLabel";
        timeLimitLabel.Size = new Size(25, 30);
        timeLimitLabel.TabIndex = 34;
        timeLimitLabel.Text = "0";
        // 
        // AddNewQuizForm_TimelimiMinuteCbo
        // 
        AddNewQuizForm_TimelimiMinuteCbo.Enabled = false;
        AddNewQuizForm_TimelimiMinuteCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_TimelimiMinuteCbo.Items.AddRange(new object[] { "minutes", "hours" });
        AddNewQuizForm_TimelimiMinuteCbo.Location = new Point(307, 525);
        AddNewQuizForm_TimelimiMinuteCbo.Name = "AddNewQuizForm_TimelimiMinuteCbo";
        AddNewQuizForm_TimelimiMinuteCbo.Size = new Size(90, 31);
        AddNewQuizForm_TimelimiMinuteCbo.TabIndex = 30;
        // 
        // AddNewQuizForm_TimeexpiresCloseCbo
        // 
        AddNewQuizForm_TimeexpiresCloseCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewQuizForm_TimeexpiresCloseCbo.Items.AddRange(new object[] { " Open attempts are submitted automatically" });
        AddNewQuizForm_TimeexpiresCloseCbo.Location = new Point(237, 570);
        AddNewQuizForm_TimeexpiresCloseCbo.Name = "AddNewQuizForm_TimeexpiresCloseCbo";
        AddNewQuizForm_TimeexpiresCloseCbo.Size = new Size(389, 31);
        AddNewQuizForm_TimeexpiresCloseCbo.TabIndex = 33;
        // 
        // btn_Create
        // 
        btn_Create.BackColor = Color.FromArgb(194, 36, 36);
        btn_Create.FlatStyle = FlatStyle.Flat;
        btn_Create.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btn_Create.ForeColor = Color.White;
        btn_Create.Location = new Point(315, 629);
        btn_Create.Name = "btn_Create";
        btn_Create.Size = new Size(160, 53);
        btn_Create.TabIndex = 35;
        btn_Create.Text = "CREATE";
        btn_Create.UseVisualStyleBackColor = false;
        btn_Create.Click += Btn_Create_Click;
        btn_Create.Cursor = Cursors.Hand;
        // 
        // AddingNewQuizForm_DisplayCb
        // 
        AddingNewQuizForm_DisplayCb.AutoSize = true;
        AddingNewQuizForm_DisplayCb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_DisplayCb.Location = new Point(237, 353);
        AddingNewQuizForm_DisplayCb.Margin = new Padding(2);
        AddingNewQuizForm_DisplayCb.Name = "AddingNewQuizForm_DisplayCb";
        AddingNewQuizForm_DisplayCb.Size = new Size(293, 27);
        AddingNewQuizForm_DisplayCb.TabIndex = 37;
        AddingNewQuizForm_DisplayCb.Text = "Display discription on course page";
        AddingNewQuizForm_DisplayCb.UseVisualStyleBackColor = true;
        // 
        // AddingNewQuizForm_openEnableCb
        // 
        AddingNewQuizForm_openEnableCb.AutoSize = true;
        AddingNewQuizForm_openEnableCb.Enabled = false;
        AddingNewQuizForm_openEnableCb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_openEnableCb.Location = new Point(672, 440);
        AddingNewQuizForm_openEnableCb.Margin = new Padding(2);
        AddingNewQuizForm_openEnableCb.Name = "AddingNewQuizForm_openEnableCb";
        AddingNewQuizForm_openEnableCb.Size = new Size(83, 27);
        AddingNewQuizForm_openEnableCb.TabIndex = 38;
        AddingNewQuizForm_openEnableCb.Text = "Enable";
        AddingNewQuizForm_openEnableCb.UseVisualStyleBackColor = true;
        // 
        // AddingNewQuizForm_closeEnableCB
        // 
        AddingNewQuizForm_closeEnableCB.AutoSize = true;
        AddingNewQuizForm_closeEnableCB.Enabled = false;
        AddingNewQuizForm_closeEnableCB.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_closeEnableCB.Location = new Point(672, 480);
        AddingNewQuizForm_closeEnableCB.Margin = new Padding(2);
        AddingNewQuizForm_closeEnableCB.Name = "AddingNewQuizForm_closeEnableCB";
        AddingNewQuizForm_closeEnableCB.Size = new Size(83, 27);
        AddingNewQuizForm_closeEnableCB.TabIndex = 39;
        AddingNewQuizForm_closeEnableCB.Text = "Enable";
        AddingNewQuizForm_closeEnableCB.UseVisualStyleBackColor = true;
        // 
        // AddingNewQuizForm_timeLimitEnableCB
        // 
        AddingNewQuizForm_timeLimitEnableCB.AutoSize = true;
        AddingNewQuizForm_timeLimitEnableCB.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_timeLimitEnableCB.Location = new Point(407, 525);
        AddingNewQuizForm_timeLimitEnableCB.Margin = new Padding(2);
        AddingNewQuizForm_timeLimitEnableCB.Name = "AddingNewQuizForm_timeLimitEnableCB";
        AddingNewQuizForm_timeLimitEnableCB.Size = new Size(83, 27);
        AddingNewQuizForm_timeLimitEnableCB.TabIndex = 40;
        AddingNewQuizForm_timeLimitEnableCB.Text = "Enable";
        AddingNewQuizForm_timeLimitEnableCB.UseVisualStyleBackColor = true;
        AddingNewQuizForm_timeLimitEnableCB.CheckedChanged += AddingNewQuizForm_timeLimitEnableCB_CheckedChanged;
        // 
        // AddingNewQuizForm_openDayNud
        // 
        AddingNewQuizForm_openDayNud.Enabled = false;
        AddingNewQuizForm_openDayNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_openDayNud.Location = new Point(237, 440);
        AddingNewQuizForm_openDayNud.Margin = new Padding(2);
        AddingNewQuizForm_openDayNud.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        AddingNewQuizForm_openDayNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        AddingNewQuizForm_openDayNud.Name = "AddingNewQuizForm_openDayNud";
        AddingNewQuizForm_openDayNud.Size = new Size(59, 30);
        AddingNewQuizForm_openDayNud.TabIndex = 41;
        AddingNewQuizForm_openDayNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // AddingNewQuizForm_closeDayNud
        // 
        AddingNewQuizForm_closeDayNud.Enabled = false;
        AddingNewQuizForm_closeDayNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_closeDayNud.Location = new Point(237, 480);
        AddingNewQuizForm_closeDayNud.Margin = new Padding(2);
        AddingNewQuizForm_closeDayNud.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        AddingNewQuizForm_closeDayNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        AddingNewQuizForm_closeDayNud.Name = "AddingNewQuizForm_closeDayNud";
        AddingNewQuizForm_closeDayNud.Size = new Size(59, 30);
        AddingNewQuizForm_closeDayNud.TabIndex = 42;
        AddingNewQuizForm_closeDayNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // AddingNewQuizForm_closeMonthCbo
        // 
        AddingNewQuizForm_closeMonthCbo.Enabled = false;
        AddingNewQuizForm_closeMonthCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_closeMonthCbo.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
        AddingNewQuizForm_closeMonthCbo.Location = new Point(307, 480);
        AddingNewQuizForm_closeMonthCbo.Name = "AddingNewQuizForm_closeMonthCbo";
        AddingNewQuizForm_closeMonthCbo.Size = new Size(90, 31);
        AddingNewQuizForm_closeMonthCbo.TabIndex = 43;
        AddingNewQuizForm_closeMonthCbo.SelectedIndexChanged += AddingNewQuizForm_closeMonthCbo_SelectedIndexChanged;
        // 
        // AddingNewQuizForm_openYearNud
        // 
        AddingNewQuizForm_openYearNud.Enabled = false;
        AddingNewQuizForm_openYearNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_openYearNud.Location = new Point(407, 440);
        AddingNewQuizForm_openYearNud.Margin = new Padding(2);
        AddingNewQuizForm_openYearNud.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
        AddingNewQuizForm_openYearNud.Minimum = new decimal(new int[] { 2023, 0, 0, 0 });
        AddingNewQuizForm_openYearNud.Name = "AddingNewQuizForm_openYearNud";
        AddingNewQuizForm_openYearNud.Size = new Size(69, 30);
        AddingNewQuizForm_openYearNud.TabIndex = 44;
        AddingNewQuizForm_openYearNud.Value = new decimal(new int[] { 2023, 0, 0, 0 });
        // 
        // AddingNewQuizForm_closeYearNud
        // 
        AddingNewQuizForm_closeYearNud.Enabled = false;
        AddingNewQuizForm_closeYearNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_closeYearNud.Location = new Point(407, 480);
        AddingNewQuizForm_closeYearNud.Margin = new Padding(2);
        AddingNewQuizForm_closeYearNud.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
        AddingNewQuizForm_closeYearNud.Minimum = new decimal(new int[] { 2023, 0, 0, 0 });
        AddingNewQuizForm_closeYearNud.Name = "AddingNewQuizForm_closeYearNud";
        AddingNewQuizForm_closeYearNud.Size = new Size(69, 30);
        AddingNewQuizForm_closeYearNud.TabIndex = 45;
        AddingNewQuizForm_closeYearNud.Value = new decimal(new int[] { 2023, 0, 0, 0 });
        // 
        // AddingNewQuizForm_openHourNud
        // 
        AddingNewQuizForm_openHourNud.Enabled = false;
        AddingNewQuizForm_openHourNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_openHourNud.Location = new Point(492, 440);
        AddingNewQuizForm_openHourNud.Margin = new Padding(2);
        AddingNewQuizForm_openHourNud.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
        AddingNewQuizForm_openHourNud.Name = "AddingNewQuizForm_openHourNud";
        AddingNewQuizForm_openHourNud.Size = new Size(59, 30);
        AddingNewQuizForm_openHourNud.TabIndex = 46;
        AddingNewQuizForm_openHourNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // AddingNewQuizForm_openMinuteNud
        // 
        AddingNewQuizForm_openMinuteNud.Enabled = false;
        AddingNewQuizForm_openMinuteNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_openMinuteNud.Location = new Point(567, 440);
        AddingNewQuizForm_openMinuteNud.Margin = new Padding(2);
        AddingNewQuizForm_openMinuteNud.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
        AddingNewQuizForm_openMinuteNud.Name = "AddingNewQuizForm_openMinuteNud";
        AddingNewQuizForm_openMinuteNud.Size = new Size(59, 30);
        AddingNewQuizForm_openMinuteNud.TabIndex = 47;
        AddingNewQuizForm_openMinuteNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // AddingNewQuizForm_closeHourNud
        // 
        AddingNewQuizForm_closeHourNud.Enabled = false;
        AddingNewQuizForm_closeHourNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_closeHourNud.Location = new Point(492, 480);
        AddingNewQuizForm_closeHourNud.Margin = new Padding(2);
        AddingNewQuizForm_closeHourNud.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
        AddingNewQuizForm_closeHourNud.Name = "AddingNewQuizForm_closeHourNud";
        AddingNewQuizForm_closeHourNud.Size = new Size(59, 30);
        AddingNewQuizForm_closeHourNud.TabIndex = 48;
        AddingNewQuizForm_closeHourNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // AddingNewQuizForm_closeMinuteNud
        // 
        AddingNewQuizForm_closeMinuteNud.Enabled = false;
        AddingNewQuizForm_closeMinuteNud.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_closeMinuteNud.Location = new Point(567, 480);
        AddingNewQuizForm_closeMinuteNud.Margin = new Padding(2);
        AddingNewQuizForm_closeMinuteNud.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
        AddingNewQuizForm_closeMinuteNud.Name = "AddingNewQuizForm_closeMinuteNud";
        AddingNewQuizForm_closeMinuteNud.Size = new Size(59, 30);
        AddingNewQuizForm_closeMinuteNud.TabIndex = 49;
        AddingNewQuizForm_closeMinuteNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // AddingNewQuizForm_timeLimitTxt
        // 
        AddingNewQuizForm_timeLimitTxt.Enabled = false;
        AddingNewQuizForm_timeLimitTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        AddingNewQuizForm_timeLimitTxt.Location = new Point(237, 525);
        AddingNewQuizForm_timeLimitTxt.Margin = new Padding(2);
        AddingNewQuizForm_timeLimitTxt.Name = "AddingNewQuizForm_timeLimitTxt";
        AddingNewQuizForm_timeLimitTxt.Size = new Size(59, 30);
        AddingNewQuizForm_timeLimitTxt.TabIndex = 50;
        AddingNewQuizForm_timeLimitTxt.KeyPress += TimeLimit_KeyPress;
        // 
        // ImportForm_ExpandPic1
        // 
        ImportForm_ExpandPic1.Image = (Image)resources.GetObject("ImportForm_ExpandPic1.Image");
        ImportForm_ExpandPic1.Location = new Point(25, 73);
        ImportForm_ExpandPic1.Name = "ImportForm_ExpandPic1";
        ImportForm_ExpandPic1.Size = new Size(15, 10);
        ImportForm_ExpandPic1.SizeMode = PictureBoxSizeMode.Zoom;
        ImportForm_ExpandPic1.TabIndex = 52;
        ImportForm_ExpandPic1.TabStop = false;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(25, 407);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(15, 10);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 53;
        pictureBox1.TabStop = false;
        // 
        // pictureBox4
        // 
        pictureBox4.Image = Properties.Resources.exclaimation_removebg_preview;
        pictureBox4.Location = new Point(205, 103);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new Size(20, 20);
        pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox4.TabIndex = 56;
        pictureBox4.TabStop = false;
        AddingNewQuiz_Tooltip.SetToolTip(pictureBox4, "Required");
        // 
        // pictureBox5
        // 
        pictureBox5.Image = Properties.Resources.question_removebg_preview;
        pictureBox5.Location = new Point(205, 444);
        pictureBox5.Name = "pictureBox5";
        pictureBox5.Size = new Size(20, 20);
        pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox5.TabIndex = 57;
        pictureBox5.TabStop = false;
        AddingNewQuiz_Tooltip.SetToolTip(pictureBox5, "Time when quiz start. If Enable isn't checked, quiz will always open. Same as close.");
        // 
        // pictureBox8
        // 
        pictureBox8.Image = Properties.Resources.question_removebg_preview;
        pictureBox8.Location = new Point(535, 357);
        pictureBox8.Name = "pictureBox8";
        pictureBox8.Size = new Size(20, 20);
        pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox8.TabIndex = 60;
        pictureBox8.TabStop = false;
        // 
        // pictureBox9
        // 
        pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
        pictureBox9.Location = new Point(630, 446);
        pictureBox9.Name = "pictureBox9";
        pictureBox9.Size = new Size(25, 25);
        pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox9.TabIndex = 61;
        pictureBox9.TabStop = false;
        // 
        // pictureBox10
        // 
        pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
        pictureBox10.Location = new Point(630, 486);
        pictureBox10.Name = "pictureBox10";
        pictureBox10.Size = new Size(25, 25);
        pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox10.TabIndex = 62;
        pictureBox10.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Resources.question_removebg_preview;
        pictureBox2.Location = new Point(205, 529);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(20, 20);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 63;
        pictureBox2.TabStop = false;
        AddingNewQuiz_Tooltip.SetToolTip(pictureBox2, "If Enable isn't checked, users will be able to submit anytime.");
        // 
        // pictureBox3
        // 
        pictureBox3.Image = Properties.Resources.question_removebg_preview;
        pictureBox3.Location = new Point(205, 573);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(20, 20);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 64;
        pictureBox3.TabStop = false;
        AddingNewQuiz_Tooltip.SetToolTip(pictureBox3, "What to do with this contest when time expires.");
        // 
        // AddingNewQuiz
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        BackColor = SystemColors.ControlLightLight;
        ClientSize = new Size(904, 706);
        Controls.Add(pictureBox3);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        Controls.Add(pictureBox4);
        Controls.Add(pictureBox5);
        Controls.Add(pictureBox8);
        Controls.Add(pictureBox9);
        Controls.Add(pictureBox10);
        Controls.Add(ImportForm_ExpandPic1);
        Controls.Add(AddingNewQuizForm_timeLimitTxt);
        Controls.Add(AddingNewQuizForm_closeMinuteNud);
        Controls.Add(AddingNewQuizForm_closeHourNud);
        Controls.Add(AddingNewQuizForm_openMinuteNud);
        Controls.Add(AddingNewQuizForm_openHourNud);
        Controls.Add(AddingNewQuizForm_closeYearNud);
        Controls.Add(AddingNewQuizForm_openYearNud);
        Controls.Add(AddingNewQuizForm_closeMonthCbo);
        Controls.Add(AddingNewQuizForm_closeDayNud);
        Controls.Add(AddingNewQuizForm_openDayNud);
        Controls.Add(AddingNewQuizForm_timeLimitEnableCB);
        Controls.Add(AddingNewQuizForm_closeEnableCB);
        Controls.Add(AddingNewQuizForm_openEnableCb);
        Controls.Add(AddingNewQuizForm_DisplayCb);
        Controls.Add(btn_Cancel);
        Controls.Add(btn_Create);
        Controls.Add(timeLimitLabel);
        Controls.Add(AddNewQuizForm_HeadingLbl);
        Controls.Add(AddNewQuizForm_GeneralLbl);
        Controls.Add(AddNewQuizForm_NameTxt);
        Controls.Add(AddNewQuizFormTxt_Description);
        Controls.Add(AddNewQuizForm_NameLbl);
        Controls.Add(AddNewQuizFormLbl_Description);
        Controls.Add(AddNewQuizForm_LineLbl);
        Controls.Add(AddNewQuizForm_TiminglLbl);
        Controls.Add(AddNewQuizForm_OpenthequizLbl);
        Controls.Add(AddNewQuizForm_ClosethequizLbl);
        Controls.Add(AddNewQuizForm_Timelimit);
        Controls.Add(AddNewQuizForm_Timeexpires);
        Controls.Add(AddingNewQuizForm_openMonthCbo);
        Controls.Add(AddNewQuizForm_TimelimiMinuteCbo);
        Controls.Add(AddNewQuizForm_TimeexpiresCloseCbo);
        MaximizeBox = false;
        Name = "AddingNewQuiz";
        ((ISupportInitialize)AddingNewQuizForm_openDayNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_closeDayNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_openYearNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_closeYearNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_openHourNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_openMinuteNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_closeHourNud).EndInit();
        ((ISupportInitialize)AddingNewQuizForm_closeMinuteNud).EndInit();
        ((ISupportInitialize)ImportForm_ExpandPic1).EndInit();
        ((ISupportInitialize)pictureBox1).EndInit();
        ((ISupportInitialize)pictureBox4).EndInit();
        ((ISupportInitialize)pictureBox5).EndInit();
        ((ISupportInitialize)pictureBox8).EndInit();
        ((ISupportInitialize)pictureBox9).EndInit();
        ((ISupportInitialize)pictureBox10).EndInit();
        ((ISupportInitialize)pictureBox2).EndInit();
        ((ISupportInitialize)pictureBox3).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    #endregion

    private Label AddNewQuizForm_HeadingLbl;
    private Label AddNewQuizForm_GeneralLbl;
    private TextBox AddNewQuizForm_NameTxt;
    private Label AddNewQuizForm_NameLbl;
    private TextBox AddNewQuizFormTxt_Description;
    private Label AddNewQuizFormLbl_Description;
    private Label AddNewQuizForm_LineLbl;
    private Label AddNewQuizForm_TiminglLbl;
    private Label AddNewQuizForm_OpenthequizLbl;
    private Label AddNewQuizForm_ClosethequizLbl;
    private Label AddNewQuizForm_Timelimit;
    private Label AddNewQuizForm_Timeexpires;
    private ComboBox AddingNewQuizForm_openMonthCbo;
    private ComboBox AddNewQuizForm_TimelimiMinuteCbo;
    private ComboBox AddNewQuizForm_TimeexpiresCloseCbo;
    private Label timeLimitLabel;
    private Button btn_Create;
    private Button btn_Cancel;
    private CheckBox AddingNewQuizForm_DisplayCb;
    private CheckBox AddingNewQuizForm_openEnableCb;
    private CheckBox AddingNewQuizForm_closeEnableCB;
    private CheckBox AddingNewQuizForm_timeLimitEnableCB;
    private NumericUpDown AddingNewQuizForm_openDayNud;
    private NumericUpDown AddingNewQuizForm_closeDayNud;
    private ComboBox AddingNewQuizForm_closeMonthCbo;
    private NumericUpDown AddingNewQuizForm_openYearNud;
    private NumericUpDown AddingNewQuizForm_closeYearNud;
    private NumericUpDown AddingNewQuizForm_openHourNud;
    private NumericUpDown AddingNewQuizForm_openMinuteNud;
    private NumericUpDown AddingNewQuizForm_closeHourNud;
    private NumericUpDown AddingNewQuizForm_closeMinuteNud;
    private TextBox AddingNewQuizForm_timeLimitTxt;
    private PictureBox ImportForm_ExpandPic1;
    private PictureBox pictureBox1;
    private PictureBox pictureBox4;
    private PictureBox pictureBox5;
    private PictureBox pictureBox8;
    private PictureBox pictureBox9;
    private PictureBox pictureBox10;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private ToolTip AddingNewQuiz_Tooltip;
}
