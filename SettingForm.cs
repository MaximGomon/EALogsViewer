using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EALogsViewer
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        public Setting SetParams
        {
            get
            {
                var set = new Setting();
                set.HistoryPath = tbHistoryPath.Text;
                set.LogPath = tbLogPath.Text;
                set.LogFileName = tbFileLogName.Text;
                set.BinaryFilesPath = tbBinaryFilePath.Text;
                set.IsSaveBinaryFiles = cbSaveFiles.Checked;
                set.IsLoadFullRequestText = cbLoadFullRequestText.Checked;
                if (rbPdf.Checked)
                {
                    set.FileType = FileType.PDF;
                }
                else
                {
                    set.FileType = FileType.Tiff;
                }
                return set;
            }
            set
            {
                tbHistoryPath.Text = value.HistoryPath;
                tbLogPath.Text = value.LogPath;
                tbFileLogName.Text = value.LogFileName;
                tbBinaryFilePath.Text = value.BinaryFilesPath;
                cbSaveFiles.Checked = value.IsSaveBinaryFiles;
                cbLoadFullRequestText.Checked = value.IsLoadFullRequestText;

                if (value.FileType == FileType.PDF)
                    rbPdf.Checked = true;
                else
                    rbTiff.Checked = true;
                //tbSystemLog.Text = value.SystemLog;
            }
        }

        private void btLogPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();

            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                tbLogPath.Text = browserDialog.SelectedPath;
            }
        }

        private void btHistoryPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();

            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                tbHistoryPath.Text = browserDialog.SelectedPath;
            }
        }

        private void btBinaryPathBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();

            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                tbBinaryFilePath.Text = browserDialog.SelectedPath;
            }
        }
    }
}
