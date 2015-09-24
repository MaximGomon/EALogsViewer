using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace EALogsViewer
{
    public partial class LogForm : Form
    {
        LogData datas = new LogData(); //загруженые данные с логов
        Setting setting = new Setting(); //загружениые настройки программы

        public LogForm()
        {
            InitializeComponent();
            filterSplitContainer.Panel1Collapsed = true;

            //Загружаеются настройки из файла конфига
            setting = Setting.LoadSetting();
            //На момент тестирования включал системный лог, сейчас не нужен
            setting.SystemLog = String.Empty;

            bool isAccess = false;
            //Проверка на существование папки, в которой лежат файлы с логами
            if (Directory.Exists(setting.LogPath))
            {
                isAccess = CheckAccessToFolder(setting.LogPath);
            }
            
            string path = setting.LogPath + @"\" + setting.LogFileName;
            setting.SystemLog += "File path: " + path;

            //если возможно прочитать файлы логов - читаем
            if (isAccess)
            {
                setting.SystemLog += "\r\nisAccess = true";
                //Читаем файлы логов
                LoadFileContent(path, false);
                setting.SystemLog += "\r\nLoadFileContent ends";
                setting.SystemLog += "\r\nLogItemCount = " + datas.Items.Count;
                //Заполняем данными с логов табличку
                FillListView(datas.Items);

                statusLabel_FilePath.Text = path;
                statusLabel_FilePath.ForeColor = Color.Black;
            }
            else
            {
                setting.SystemLog += "\r\nisAccess = false";
                statusLabel_FilePath.Text = string.Format("Помилка доступу до файлу або даного файлу не існує: {0}", path);
                statusLabel_FilePath.ForeColor = Color.Red;
            }
            //File.WriteAllText("\\Logs.txt", setting.SystemLog);
        }

        private bool CheckAccessToFolder(string logPath)
        {
            try
            {
                if (Directory.Exists(logPath))
                {
                    DirectorySecurity ds = Directory.GetAccessControl(logPath);
                    return true;
                }
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bool isLoad = LoadFileContent(openFileDialog.FileName);

                if (isLoad)
                {
                    //очищаем комбобокс с методами интеграции
                    comboBoxMethod.Items.Clear();
                    //Заполняем данными с логов табличку
                    FillListView(datas.Items);

                    statusLabel_FilePath.Text = openFileDialog.FileName;
                    statusLabel_FilePath.ForeColor = Color.Black;
                }
                else
                {
                    statusLabel_FilePath.Text = "Помилка доступу до файлу або даного файлу не існує";
                    statusLabel_FilePath.ForeColor = Color.Red;
                }
            }
        }

        private bool LoadFileContent(string path, bool isCleanData = true)
        {
            bool success = false;

            if (path != String.Empty)
            {

                if (File.Exists(path))
                {
                    string text = File.ReadAllText(path);

                    if (text != String.Empty)
                    {
                        //немного порнографии))
                        //setting.SystemLog += "\r\nFileText = " + text.Substring(0, 100);

                        //Загружаем данные с логов в структуру программы
                        if (FileWorker.ConvertTextToLogData(text, isCleanData, setting.IsLoadFullRequestText, ref datas))
                        {
                            success = true;
                        }
                        else
                        {
                            statusLabel_FilePath.Text = "Помилка читання файлу " + path;
                            statusLabel_FilePath.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        setting.SystemLog += "\r\nFileText = String.Empty";
                    }
                }
                else
                {
                    setting.SystemLog += "\r\nFile not exist: " + path;
                }
            }

            return success;
        }

        private void FillListView(List<LogItem> data)
        {
            dataListView.Items.Clear();
            detailRichTextBox.Text = String.Empty;
            //List<string> methodList = new List<string>();

            //if (comboBoxMethod.Items.Count > 0)
            //    methodList = (List<string>)comboBoxMethod.Items.Cast<List<string>>();

            int i = 1;
            List<string> errors = new List<string>();

            foreach (var logItem in data)
            {
                if (!comboBoxMethod.Items.Contains(logItem.Method))
                    comboBoxMethod.Items.Add(logItem.Method);
                
                ListViewItem item = dataListView.Items.Add(logItem.LineNumber.ToString());
                item.SubItems.Add(logItem.EventTime.ToEADate());
                item.SubItems.Add(logItem.Method);
                item.SubItems.Add(logItem.RNK);
                item.SubItems.Add(logItem.DocExternalNumber);
                item.SubItems.Add(logItem.AgreementCode);
                item.SubItems.Add(logItem.AccountNumber);
                item.SubItems.Add(logItem.AnswerTime.ToEADate());
                item.SubItems.Add(logItem.Responce);
                item.SubItems.Add(i.ToString());
                item.Tag = logItem.FullText;

                //Если в настройках установлено сохранение бинарных данных в файл - сохраняем
                if (setting.IsSaveBinaryFiles &&  !String.IsNullOrWhiteSpace(logItem.Base64String.Trim())
                    && !String.IsNullOrWhiteSpace(logItem.DocExternalNumber))
                {
                    string path = setting.BinaryFilesPath + @"\" + logItem.DocExternalNumber;
                    if (setting.FileType == FileType.PDF)
                        path += ".pdf";
                    else
                            path += ".tiff";
                    string fileWriteError = String.Empty;

                    if (!Directory.Exists(setting.BinaryFilesPath))
                        Directory.CreateDirectory(setting.BinaryFilesPath);

                    if(!Helpers.Base64ToImage(path, logItem.Base64String, out fileWriteError))
                    {
                        errors.Add("Не вдалося зберегти бінарний файл для документа №" + logItem.DocExternalNumber + "\r\n" + fileWriteError);
                    }
                }

                if (logItem.Responce.Contains("error"))
                {
                    item.BackColor = Color.LightCoral;
                }
                i++;
            }

            if (errors.Count > 0)
                DisplayErrors(errors);
        }

        private void DisplayErrors(List<string> errorList)
        {
            string errors = String.Empty;
            foreach (var item in errorList)
            {
                errors += item + "\r\n";
            }

            MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string text = (string)e.Item.Tag;
            detailRichTextBox.Text = text;
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            //Загрузка файлов с устаревшими логами(при установленом фильтре по дате) опираюсь на имя файла
            if (LoadHistoryFiles())
            {
                statusLabel_FilePath.Text = "Ок";
                statusLabel_FilePath.ForeColor = Color.Black;
            }
            else
            {
                statusLabel_FilePath.Text = "Помилка при завантажені історії дій!";
                statusLabel_FilePath.ForeColor = Color.Red;
            }
            //ФИльтрация текущих загруженных данных
            FilterCurrentData();
        }

        private bool LoadHistoryFiles()
        {
            string path = setting.HistoryPath;
            //беру дату с интерфейса для поиска файлов за этот день 
            DateTime searchDate = dtpEventDate.Value;

            string month = searchDate.Month.ToString().Length != 1
                ? searchDate.Month.ToString()
                : "0" + searchDate.Month.ToString();
            string day = searchDate.Day.ToString().Length != 1
                ? searchDate.Day.ToString()
                : "0" + searchDate.Day.ToString();
            //Получаем имя архивного файла логов
            string fileNameBegins = string.Format("{0}-{1}-{2}*{3}", searchDate.Year, month, day, setting.LogFileName);

            List<string> hFiles = Directory.GetFiles(path, fileNameBegins).ToList();

            //Проходим по всем архивным файлам логов и загружаем их контент (может выжрать немеряно памяти, рекорд 12 гиг)
            foreach (var file in hFiles)
            {
                LoadFileContent(file, false);
            }
            return true;
        }

        private void FilterCurrentData()
        {
            //фильтрация загруженых данных по указанным параметрам
            string method = comboBoxMethod.SelectedItem != null ? comboBoxMethod.SelectedItem.ToString() : "";
            string account = tbAccount.Text.Trim();
            string agrId = tbAgreementCode.Text.Trim();
            string rnk = tbRNK.Text.Trim();
            string docId = tbDocExternalId.Text.Trim();
            DateTime eventdate = dtpEventDate.Value;//.ToShortDateString();
            dataListView.Items.Clear();

            IEnumerable<LogItem> items = null;
            if (cbUseDate.Checked)
            {
                //string eventDate = eventdate.ToShortDateString();
                items = datas.Items.Where(
                i => i.Method.StartsWith(method.Trim()) &&
                    i.RNK.StartsWith(rnk.Trim()) &&
                    i.DocExternalNumber.StartsWith(docId.Trim()) &&
                    i.AgreementCode.StartsWith(agrId.Trim()) &&
                    i.AccountNumber.StartsWith(account.Trim()) &&
                    i.EventTime.ToShortDateString() == eventdate.ToShortDateString()
                    )
                    .OrderByDescending(i => i.EventTime);
            }
            else
            {
                items = datas.Items.Where(
                i => i.Method.StartsWith(method.Trim()) &&
                    i.RNK.StartsWith(rnk.Trim()) &&
                    i.DocExternalNumber.StartsWith(docId.Trim()) &&
                    i.AgreementCode.StartsWith(agrId.Trim()) &&
                    i.AccountNumber.StartsWith(account.Trim()) 
                    )
                    .OrderByDescending(i => i.EventTime); 
            }
            
            FillListView(items.ToList());
        }

        private void checkBoxBARS_CheckedChanged(object sender, EventArgs e)
        {
            //comboBoxMethod.Items.Clear();

            //if (checkBoxBARS.Checked)
            //{
            //    checkBoxPool.Checked = false;
            //    checkBoxProcessor.Checked = false;
            //    List<string> metods = ConfigurationManager.AppSettings["BarsMethods"].Split(',').ToList();
            //    comboBoxMethod.Items.Add("");
            //    comboBoxMethod.Items.AddRange(metods.ToArray());
            //    comboBoxMethod.SelectedIndex = 0;
            //}
        }

        private void checkBoxPool_CheckedChanged(object sender, EventArgs e)
        {
            //comboBoxMethod.Items.Clear();

            //if (checkBoxPool.Checked)
            //{
            //    checkBoxProcessor.Checked = false;
            //    checkBoxBARS.Checked = false;
            //    List<string> metods = ConfigurationManager.AppSettings["PoolMethods"].Split(',').ToList();
            //    comboBoxMethod.Items.Add("");
            //    comboBoxMethod.Items.AddRange(metods.ToArray());
            //    comboBoxMethod.SelectedIndex = 0;
            //}
        }

        private void checkBoxProcessor_CheckedChanged(object sender, EventArgs e)
        {
            //comboBoxMethod.Items.Clear();

            //if (checkBoxProcessor.Checked)
            //{
            //    checkBoxPool.Checked = false;
            //    checkBoxBARS.Checked = false;
            //    List<string> metods = ConfigurationManager.AppSettings["ProcessorMethods"].Split(',').ToList();
            //    comboBoxMethod.Items.Add("");
            //    comboBoxMethod.Items.AddRange(metods.ToArray());
            //    comboBoxMethod.SelectedIndex = 0;
            //}
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btClearFilter_Click(object sender, EventArgs e)
        {
            cbUseDate.Checked = false;
            FillListView(datas.Items);
        }

        private void cbUseDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUseDate.Checked)
            {
                dtpEventDate.Enabled = true;
            }
            else
            {
                dtpEventDate.Enabled = false;
            }
        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Setting.SaveSetting(setting);
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            SettingForm sf = new SettingForm();
            sf.SetParams = setting;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                setting = sf.SetParams;
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            //загружаем заново последний файл логов
            dataListView.Items.Clear();
            datas.Items.Clear();
            datas.IsDataLoad = false;
            string path = setting.LogPath + @"\" + setting.LogFileName;
            LoadFileContent(path, false);
            FillListView(datas.Items);
        }
    }
}
