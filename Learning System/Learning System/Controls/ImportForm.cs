using Learning_System.Modals;
using Learning_System.ProcessingClasses;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Learning_System
{
    public partial class ImportForm : UserControl
    {
        private string? ImportPath;

        private string? selectedImage;

        private Paragraph? paragraph;

        private int lineIndex = 0;

        private const long SIZE_OF_MB = 1024 * 1024;

        private const int MAX_OF_SIZE = 200;

        private double maximumSizeForNewFiles = MAX_OF_SIZE;

        const int MAX_OF_LINES = 2000;

        private RichTextBox[] lineTextBoxes = new RichTextBox[MAX_OF_LINES];

        public ImportForm()
        {
            InitializeComponent();
            ImportForm_StatusLbl.Text = $"Maximum size for new files: {Math.Round(maximumSizeForNewFiles, 2)} MB";
        }

        private void ImportForm_SelectFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "File Text(*.txt)|*.txt|File .doc(*.doc)|*.doc|File .docx (*.docx)|*.docx|All File (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportPath = openFileDialog.FileName;
                ImportForm_StatusLbl.Text = "File choosen: " + Path.GetFileName(openFileDialog.FileName);
            }
        }

        /// <summary>
        /// Check Aiken format của dòng lựa chọn ("A. Choice's content")
        /// </summary>
        private char CheckChoicesAikenFormat(string choice)
        {
            if (choice.Length < 4) return ' ';
            return choice[0] < 'A' || choice[0] > 'Z' || choice[1] != '.' || choice[2] != ' ' || choice[3] == ' ' ? ' ' : choice[0];
        }

        /// <summary>
        /// Check Aiken format của dòng đáp án ("ANSWER: A")
        /// </summary>
        /// <param name="answer"> Dòng đáp án</param>
        /// <param name="_listAnswers"> Danh sách các lựa chọn của câu hỏi</param>
        private bool CheckAnswerAikenFormat(string answer, List<char> _listAnswers)
        {
            if (_listAnswers.Count < 2) return false;
            if (answer.Length != 9) return false;
            if (answer[..8] != "ANSWER: ") return false;
            foreach (char c in _listAnswers)
            {
                if (answer.EndsWith(c)) return true;
            }
            return false;
        }

        List<List<char>> answerLetter = new();

        /// <summary>
        /// Check Aiken format của file
        /// </summary>
        /// <param name="lines"> Các dòng text trong file</param>
        /// <returns> Số âm: Đúng format và trả về số câu hỏi trong file; Số dương: Sai format và trả về dòng đầu tiên bị sai format </returns>
        private int CheckAikenFormat(List<string> lines)
        {
            int i = 0;
            int questionCount = 0;
            while (i < lines.Count)
            {
                if (lines[i].Length > 0)
                {
                    questionCount++;
                    i++;
                    List<char> listAnswers = new();

                    try
                    {
                        while (lines[i] != null)
                        {
                            if (!CheckAnswerAikenFormat(lines[i], listAnswers))
                            {
                                char answerLetter = CheckChoicesAikenFormat(lines[i]);
                                if (answerLetter == ' ') return i;

                                listAnswers.Add(answerLetter);
                                i++;
                            }
                            else
                            {
                                i++;
                                if (i == lines.Count) break;
                                if (lines[i].Length > 0) return i;
                                while (lines[i].Length == 0 && i < lines.Count) i++;
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return i;
                        throw;
                    }

                    answerLetter.Add(listAnswers);
                }
                else return i;
            }
            return -questionCount;
        }


        /// <summary>
        /// Import câu hỏi vào file json
        /// </summary>
        /// <param name="lines"> Các dòng text trong file</param>
        /// <param name="_ImportPath"> Đường dẫn của file được chọn</param>
        private int ImportQuestionsFile(List<string> lines, string _ImportPath)
        {
            QuestionsTable.table.LoadData(JsonProcessing.QuestionsPath);
            CategoriesTable.table.LoadData(JsonProcessing.CategoriesPath);

            DataRow? _parentCategory;

            if (CategoriesTable.table.Length() == 0)
            {
                Modals.Categories _newCategory = new()
                {
                    Id = CategoriesTable.table.Length(),
                    Name = DateTime.Now.ToString(),
                    SubArray = new List<int>(),
                    QuestionArray = new List<int>(),
                    Description = "Auto-generated category",
                    IdNumber = "AGC"
                };

                if (CategoriesTable.table.Insert(JObject.FromObject(_newCategory)) == DataProcessing.StatusCode.Error)
                    throw new E05CantInsertProperly();
            }

            _parentCategory = CategoriesTable.table.Init().Offset(0).Limit(1).GetFirstRow();
            if (_parentCategory == null)
                throw new E02CantProcessQuery();

            System.Data.DataTable? _maxQuestionIdTbl = QuestionsTable.table.Init().Sort("ID desc").Get();

            ImportForm_ImportProgress.Value = 50;

            if (_maxQuestionIdTbl == null)
                throw new E02CantProcessQuery();

            int questionIDCount = (_maxQuestionIdTbl.Rows.Count == 0) ? 0 : _maxQuestionIdTbl.Rows[0].Field<int>("ID");

            int i = 0, questionOrder = 0;
            string EndLine = @"\r\n\\pard\\kerning0\\f1\\fs18\\par\r\n";

            while (i < lines.Count)
            {
                if (lines[i].Length > 0)
                {
                    string _stringContent;
                    if (Path.GetExtension(ImportPath) != ".txt") _stringContent = lineTextBoxes[i].Rtf;
                    else _stringContent = lines[i];
                    string questionContent = _stringContent;
                    questionContent = Regex.Replace(questionContent, EndLine, "", RegexOptions.RightToLeft);
                    questionIDCount++;
                    i++;

                    List<QuestionChoice> _questionChoices = new();

                    int choiceOrder = 0;

                    while (lines[i].Length > 0)
                    {
                        if (lines[i][1] == '.')
                        {
                            if (Path.GetExtension(ImportPath) != ".txt")
                            {
                                _stringContent = lineTextBoxes[i].Rtf;
                            }
                            else
                            {
                                _stringContent = lines[i];
                            }

                            // Remove choices' letter:
                            Regex removeChoice = new Regex(answerLetter[questionOrder][choiceOrder].ToString() + ". ");
                            _stringContent = removeChoice.Replace(_stringContent, "", 1);
                            _stringContent = Regex.Replace(_stringContent, EndLine, "", RegexOptions.RightToLeft);
                            
                            QuestionChoice _questionChoice = new()
                            {
                                choice = _stringContent,
                                mark = 0
                            };
                            _questionChoices.Add(_questionChoice);
                            i++;
                            choiceOrder++;
                        }
                        else
                        {
                            int j = 0;
                            foreach (QuestionChoice _questionChoice in _questionChoices)
                            {
                                if (lines[i].EndsWith(lines[i - _questionChoices.Count + j][0])) _questionChoice.mark = 1;
                                j++;
                            }
                            i++;
                            if (i >= lines.Count) break;
                            while (lines[i].Length == 0 && i < lines.Count) i++;
                            break;
                        }

                        ImportForm_ImportStatus.Text = "Added " + (i + 1) + "question";
                    }

                    Questions newQuestions = new()
                    {
                        ID = questionIDCount,
                        Name = "",
                        CategoryID = 0,
                        Content = questionContent,
                        DefaultMark = 1,
                        Choice = _questionChoices
                    };

                    QuestionsTable.table.Insert(JObject.FromObject(newQuestions));

                    JArray? parentCtg = _parentCategory.Field<JArray>("QuestionArray");
                    if (parentCtg == null)
                        throw new E03NotExistColumn("QuestionArray");
                    parentCtg.Add(newQuestions.ID);
                    questionOrder++;
                }
            }

            ImportForm_ImportProgress.Value = 70;

            JObject x = DataProcessing.ConvertDataRowToJObject(_parentCategory);

            if (CategoriesTable.table.Init().Offset(0).Limit(1).Update(JObject.FromObject(x)) == DataProcessing.StatusCode.Error)
                throw new E02CantProcessQuery();

            try
            {
                if (JsonProcessing.ExportJsonContentInDefaultFolder("Question.json", QuestionsTable.table.Export()) == null)
                    throw new E04CantExportProperly();
                if (JsonProcessing.ExportJsonContentInDefaultFolder("Category.json", CategoriesTable.table.Export()) == null)
                    throw new E04CantExportProperly();

                ImportForm_ImportProgress.Value = 90;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in exporting data!\nDescription: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DataProcessing.StatusCode.Error;
            }

            return DataProcessing.StatusCode.OK;
        }

        private bool CheckFileFormat(string _ImportPath)
        {
            if (Path.GetExtension(_ImportPath) != ".txt" && Path.GetExtension(_ImportPath) != ".doc" && Path.GetExtension(_ImportPath) != ".docx")
            {
                return false;
            }
            else return true;
        }

        /// <summary>
        /// Copy dòng đang được selected từ file .doc hoặc .docx để paste vào Rich Text Box.
        /// </summary>
        protected void CopyFromClipboardInlineShape()
        {
            if (paragraph == null) return;
            //InlineShape inlineShape = paragraph.Range.InlineShapes[selectedImageIndex];
            paragraph.Range.Select();
            paragraph.Range.Copy();
            Computer computer = new();
            //Image img = computer.Clipboard.GetImage();
            if (computer.Clipboard.GetDataObject() != null)
            {
                RichTextBox t = new();
                lineTextBoxes[lineIndex] = new RichTextBox();
                t.Paste();
                selectedImage = t.Rtf;
                //System.Windows.Forms.IDataObject data = computer.Clipboard.GetDataObject();
                //if (data.GetDataPresent(System.Windows.Forms.DataFormats.Bitmap))
                //{
                //    Image image = (Image)data.GetData(System.Windows.Forms.DataFormats.Bitmap, true);
                //    RichTextBox textBox = new RichTextBox();
                //    DataFormats.Format format = DataFormats.GetFormat(System.Windows.Forms.DataFormats.Bitmap);
                //    textBox.Paste(format);
                //    selectedImage = textBox.Rtf;
                //}
                //else
                //{
                //    selectedImage = "";
                //}
            }
            else
            {
                selectedImage = "";
            }
        }

        /// <summary>
        /// Đọc file .txt, .doc, .docx được chọn
        /// </summary>
        /// <param name="_ImportPath"> Đường dẫn của file được chọn </param>
        /// <returns>Trả về list các dòng text trong file, nếu là file doc thì paste content vào mảng Rich Text Box </returns>
        private List<string> ReadFromDocumentFile(string _ImportPath)
        {
            try
            {
                List<string> _lines = new();
                if (Path.GetExtension(_ImportPath) == ".txt")
                {
                    _lines = File.ReadAllLines(_ImportPath).ToList();
                }
                else
                {
                    Microsoft.Office.Interop.Word.Application application = new();
                    object miss = Missing.Value;
                    object path = _ImportPath;
                    object readOnly = true;
                    object save = false;
                    Document docs = application.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
                    if (docs != null)
                    {
                        if (docs.Paragraphs.Count > MAX_OF_LINES)
                        {
                            MessageBox.Show($"Maximum {MAX_OF_LINES} lines on .doc and .docx files!");
                            return _lines;
                        }
                        lineIndex = 0;
                        foreach (Paragraph p in docs.Paragraphs)
                        {
                            paragraph = p;
                            //_lines.Add(CopyFromClipboardInlineShape());
                            Thread thread = new(CopyFromClipboardInlineShape);
                            thread.SetApartmentState(ApartmentState.STA);
                            thread.Start();
                            thread.Join();
                            lineTextBoxes[lineIndex] = new RichTextBox
                            {
                                Rtf = selectedImage
                            };
                            _lines.Add(lineTextBoxes[lineIndex].Text.Trim());
                            lineIndex++;
                            //totaltext += p.Range.Text;
                        }
                        //string[] _totaltext = totaltext.Split('\r');
                        //_lines.AddRange(_totaltext);
                        docs.Close(ref save, ref miss, ref miss);
                    }
                    application.Quit(ref save, ref miss, ref miss);
                }
                return _lines;
            }
            catch
            {
                MessageBox.Show("Your import file has some errors.\nPlease check again. Be sure it has Aiken format!", "Error");
                return null;
            }
        }

        private void ImportForm_ImportBtn_Click(object sender, EventArgs e)
        {
            ImportForm_ImportStatus.Text = "Processing...";
            ImportForm_ImportProgress.Value = 0;
            ImportForm_ImportProgress.Maximum = 100;

            if (ImportPath == null)
            {
                MessageBox.Show("Please choose a file!");
            }
            else if (CheckFileFormat(ImportPath) == false)
            {
                MessageBox.Show("Wrong format!");
                ImportForm_StatusLbl.Text = $"Maximum size for new files: {Math.Round(maximumSizeForNewFiles, 2)} MB";
            }
            else
            {
                // Remove old list
                answerLetter.Clear();

                double fileSize = new System.IO.FileInfo(ImportPath).Length;
                if (fileSize >= MAX_OF_SIZE * SIZE_OF_MB)
                {
                    MessageBox.Show($"File's size must be smaller than {MAX_OF_SIZE} MB!");
                    ImportForm_StatusLbl.Text = $"Maximum size for new files: {Math.Round(maximumSizeForNewFiles, 2)} MB";
                    return;
                }
                ImportForm_ImportProgress.Value = 10;
                ImportForm_ImportStatus.Text = "Reading file content. It can be lagged during this phase. Please wait a couple of minutes...";
                List<string> lines = ReadFromDocumentFile(ImportPath);

                if (lines == null)
                    return;

                ImportForm_ImportProgress.Value = 20;
                ImportForm_ImportStatus.Text = "Checking Aiken format. It can be lagged during this phase. Please wait a couple of minutes...";
                if (lines == null) { return; }
                int checkAikenFormat = CheckAikenFormat(lines);
                if (checkAikenFormat >= 0)
                {
                    MessageBox.Show($"Error at line {checkAikenFormat + 1}!");
                    ImportForm_ImportStatus.Text = "Error";
                    ImportForm_StatusLbl.Text = $"Maximum size for new files: {Math.Round(maximumSizeForNewFiles, 2)} MB";
                }
                else
                {
                    ImportForm_ImportProgress.Value = 30;
                    if (ImportQuestionsFile(lines, ImportPath) == DataProcessing.StatusCode.OK)
                    {
                        ImportForm_ImportProgress.Value = 100;
                        ImportForm_ImportStatus.Text = "Done";

                        MessageBox.Show($"OK. Successfully imported {-checkAikenFormat} question(s)!");
                        maximumSizeForNewFiles -= fileSize / SIZE_OF_MB;
                        ImportForm_StatusLbl.Text = $"Maximum size for new files: {Math.Round(maximumSizeForNewFiles, 2)} MB";
                    }
                    else
                        ImportForm_ImportStatus.Text = "Error";
                }
                ImportPath = null;
                selectedImage = null;
                paragraph = null;
            }
        }

        private void Panel_drop_file_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                MessageBox.Show("Please dragdrop a file here");
                return;
            }
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop);
            ImportPath = FileList[0];
            ImportForm_StatusLbl.Text = "File choosen: " + Path.GetFileName(ImportPath);
        }

        private void Panel_drop_file_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                MessageBox.Show("Please dragdrop a file here");
                return;
            }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else e.Effect = DragDropEffects.None;
        }
    }
}