using Learning_System.Modals;
using Learning_System.ProcessingClasses;
using Newtonsoft.Json.Linq;
using System.Data;

namespace Learning_System;

public partial class AddingNewQuiz : Form
{
    public AddingNewQuiz()
    {
        InitializeComponent();

        AddingNewQuizForm_closeMonthCbo.SelectedIndex = 0;
        AddingNewQuizForm_openMonthCbo.SelectedIndex = 0;
        AddNewQuizForm_TimelimiMinuteCbo.SelectedIndex = 0;
        AddNewQuizForm_TimeexpiresCloseCbo.SelectedIndex = 0;
        AddingNewQuizForm_openDayNud.Maximum = 31;
        AddingNewQuizForm_closeDayNud.Maximum = 31;

        AddNewQuizForm_Load();
    }

    public void AddNewQuizForm_Load()
    {
        ContestsTable.table.LoadData(JsonProcessing.ContestsPath);
    }

    private void Btn_Create_Click(object sender, EventArgs e)
    {
        var _name = AddNewQuizForm_NameTxt.Text;
        var _description = AddNewQuizFormTxt_Description.Text;
        var _displayEnable = AddingNewQuizForm_DisplayCb.Checked;
        var _timeLimitEnable = AddingNewQuizForm_timeLimitEnableCB.Checked;
        int _timeLimit;

        if (_timeLimitEnable == false)
            _timeLimit = int.MaxValue;
        else
        {
            if (AddNewQuizForm_TimelimiMinuteCbo.Text == "hours")
                _timeLimit = int.Parse(AddingNewQuizForm_timeLimitTxt.Text) * 60;
            else if (AddNewQuizForm_TimelimiMinuteCbo.Text == "minutes")
                _timeLimit = int.Parse(AddingNewQuizForm_timeLimitTxt.Text);
            else
                _timeLimit = int.Parse(AddingNewQuizForm_timeLimitTxt.Text);
        }

        var _openEnable = AddingNewQuizForm_openEnableCb.Checked;
        var _closeEnable = AddingNewQuizForm_closeEnableCB.Checked;
        DateTime _timeStart, _timeEnd;

        if (_openEnable == true)
            _timeStart = new((int)AddingNewQuizForm_openYearNud.Value,
                              AddingNewQuizForm_openMonthCbo.SelectedIndex + 1,
                              (int)AddingNewQuizForm_openDayNud.Value,
                              (int)AddingNewQuizForm_openHourNud.Value,
                              (int)AddingNewQuizForm_openMinuteNud.Value,
                              0);
        else
            _timeStart = DateTime.MinValue;

        if (_closeEnable == true)
            _timeEnd = new((int)AddingNewQuizForm_closeYearNud.Value,
                              AddingNewQuizForm_closeMonthCbo.SelectedIndex + 1,
                              (int)AddingNewQuizForm_closeDayNud.Value,
                              (int)AddingNewQuizForm_closeHourNud.Value,
                              (int)AddingNewQuizForm_closeMinuteNud.Value,
                              0);
        else
            _timeEnd = DateTime.MaxValue;


        string _errorNoti = "";
        if (_name == null || _name == "")
        {
            if (_errorNoti.Length > 0)
                _errorNoti += ", ";
            _errorNoti += "Quiz's Name";
        }

        if (_errorNoti != "")
        {
            MessageBox.Show("Please finish these fields: " + _errorNoti, "Error");
            return;
        }
        else
        {
            try
            {
                // This GetFirstRow doesn't affect the return value below
                DataRow? _maxIdRow = ContestsTable.table.Init().Sort("Id desc").GetFirstRow();

                Contests _newQuiz = new()
                {
                    Id = (_maxIdRow == null) ? 0 : (_maxIdRow.Field<int>("Id") + 1),
                    Name = _name,
                    Description = _description,
                    DescriptionShow = _displayEnable,
                    QuestionArray = new List<int>(),
                    ShuffleAnswer = false,
                    TimeStart = _timeStart,
                    StartEnable = _openEnable,
                    TimeEnd = _timeEnd,
                    EndEnable = _closeEnable,
                    TimeLimit = _timeLimit,
                    TimeLimitEnable = _timeLimitEnable,
                    MaximumGrade = 10
                };

                if (ContestsTable.table.Insert(JObject.FromObject(_newQuiz)) == DataProcessing.StatusCode.Error)
                    throw new E02CantProcessQuery();

                JsonProcessing.ExportJsonContentInDefaultFolder("Contest.json", ContestsTable.table.Export());
                MessageBox.Show("Add new contest successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddNewQuizForm_NameTxt.Text = "";
                AddNewQuizFormTxt_Description.Text = "";
                AddNewQuizForm_Timelimit.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm phần tử thất bại!\nChi tiết lỗi:\n" + ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        this.Close();
    }

    private void TimeLimit_KeyPress(object sender, KeyPressEventArgs e)
    {
        char ch = e.KeyChar;

        if (Char.IsDigit(ch))
        { e.Handled = false; }
        else if (ch == 8) { e.Handled = false; }
        else { e.Handled = true; }
    }

    private void AddingNewQuizForm_openMonthCbo_SelectedIndexChanged(object sender, EventArgs e)
    {
        string? a = AddingNewQuizForm_openMonthCbo.SelectedItem.ToString();
        if ((a == "January") || (a == "March") || (a == "May") || (a == "July") || (a == "August") || (a == "October") || (a == "December"))
        {
            AddingNewQuizForm_openDayNud.Maximum = 31;
        }
        if ((a == "April") || (a == "June") || (a == "September") || (a == "November"))
        {
            AddingNewQuizForm_openDayNud.Maximum = 31;
        }
        if (a == "February")
        {
            int b = (int)AddingNewQuizForm_openYearNud.Value;
            if ((b % 4) == 0) { AddingNewQuizForm_openDayNud.Maximum = 29; }
            else AddingNewQuizForm_openDayNud.Maximum = 28;
        }
    }

    private void AddingNewQuizForm_closeMonthCbo_SelectedIndexChanged(object sender, EventArgs e)
    {
        string? a = AddingNewQuizForm_closeMonthCbo.SelectedItem.ToString();
        if ((a == "January") || (a == "March") || (a == "May") || (a == "July") || (a == "August") || (a == "October") || (a == "December"))
        {
            AddingNewQuizForm_closeDayNud.Maximum = 31;
        }
        if ((a == "April") || (a == "June") || (a == "September") || (a == "November"))
        {
            AddingNewQuizForm_closeDayNud.Maximum = 30;
        }
        if (a == "February")
        {
            int b = (int)AddingNewQuizForm_closeYearNud.Value;
            if ((b % 4) == 0) { AddingNewQuizForm_closeDayNud.Maximum = 29; }
            else AddingNewQuizForm_closeDayNud.Maximum = 28;
        }
    }

    private void Btn_Cancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void AddingNewQuizForm_timeLimitEnableCB_CheckedChanged(object sender, EventArgs e)
    {
        if (AddingNewQuizForm_timeLimitEnableCB.Checked == false)
        {
            AddingNewQuizForm_timeLimitTxt.Enabled = false;
            AddNewQuizForm_TimelimiMinuteCbo.Enabled = false;
        }
        else
        {
            AddingNewQuizForm_timeLimitTxt.Enabled = true;
            AddNewQuizForm_TimelimiMinuteCbo.Enabled = true;
        }
    }
}