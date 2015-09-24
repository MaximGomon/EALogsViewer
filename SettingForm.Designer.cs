namespace EALogsViewer
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.tbHistoryPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLogPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btLogPath = new System.Windows.Forms.Button();
            this.btHistoryPath = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbFileLogName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBinaryPathBrowse = new System.Windows.Forms.Button();
            this.tbBinaryFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSaveFiles = new System.Windows.Forms.CheckBox();
            this.cbLoadFullRequestText = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbTiff = new System.Windows.Forms.RadioButton();
            this.rbPdf = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbHistoryPath
            // 
            this.tbHistoryPath.Location = new System.Drawing.Point(99, 40);
            this.tbHistoryPath.Name = "tbHistoryPath";
            this.tbHistoryPath.ReadOnly = true;
            this.tbHistoryPath.Size = new System.Drawing.Size(359, 20);
            this.tbHistoryPath.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Шлях до архівів";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLogPath
            // 
            this.tbLogPath.Location = new System.Drawing.Point(99, 12);
            this.tbLogPath.Name = "tbLogPath";
            this.tbLogPath.ReadOnly = true;
            this.tbLogPath.Size = new System.Drawing.Size(359, 20);
            this.tbLogPath.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Шлях до логів";
            // 
            // btLogPath
            // 
            this.btLogPath.Location = new System.Drawing.Point(455, 10);
            this.btLogPath.Name = "btLogPath";
            this.btLogPath.Size = new System.Drawing.Size(84, 23);
            this.btLogPath.TabIndex = 12;
            this.btLogPath.Text = "Огляд";
            this.btLogPath.UseVisualStyleBackColor = true;
            this.btLogPath.Click += new System.EventHandler(this.btLogPath_Click);
            // 
            // btHistoryPath
            // 
            this.btHistoryPath.Location = new System.Drawing.Point(455, 37);
            this.btHistoryPath.Name = "btHistoryPath";
            this.btHistoryPath.Size = new System.Drawing.Size(84, 23);
            this.btHistoryPath.TabIndex = 13;
            this.btHistoryPath.Text = "Огляд";
            this.btHistoryPath.UseVisualStyleBackColor = true;
            this.btHistoryPath.Click += new System.EventHandler(this.btHistoryPath_Click);
            // 
            // btsave
            // 
            this.btsave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btsave.Location = new System.Drawing.Point(190, 180);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(75, 23);
            this.btsave.TabIndex = 14;
            this.btsave.Text = "OK";
            this.btsave.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(271, 180);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Відміна";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // tbFileLogName
            // 
            this.tbFileLogName.Location = new System.Drawing.Point(99, 66);
            this.tbFileLogName.Name = "tbFileLogName";
            this.tbFileLogName.Size = new System.Drawing.Size(359, 20);
            this.tbFileLogName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ім\'я файлу логу";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btBinaryPathBrowse
            // 
            this.btBinaryPathBrowse.Location = new System.Drawing.Point(455, 92);
            this.btBinaryPathBrowse.Name = "btBinaryPathBrowse";
            this.btBinaryPathBrowse.Size = new System.Drawing.Size(84, 23);
            this.btBinaryPathBrowse.TabIndex = 21;
            this.btBinaryPathBrowse.Text = "Огляд";
            this.btBinaryPathBrowse.UseVisualStyleBackColor = true;
            this.btBinaryPathBrowse.Click += new System.EventHandler(this.btBinaryPathBrowse_Click);
            // 
            // tbBinaryFilePath
            // 
            this.tbBinaryFilePath.Location = new System.Drawing.Point(99, 94);
            this.tbBinaryFilePath.Name = "tbBinaryFilePath";
            this.tbBinaryFilePath.ReadOnly = true;
            this.tbBinaryFilePath.Size = new System.Drawing.Size(359, 20);
            this.tbBinaryFilePath.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Шлях для файлів";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSaveFiles
            // 
            this.cbSaveFiles.AutoSize = true;
            this.cbSaveFiles.Location = new System.Drawing.Point(97, 154);
            this.cbSaveFiles.Name = "cbSaveFiles";
            this.cbSaveFiles.Size = new System.Drawing.Size(147, 17);
            this.cbSaveFiles.TabIndex = 22;
            this.cbSaveFiles.Text = "Зберігати файли з логів";
            this.cbSaveFiles.UseVisualStyleBackColor = true;
            // 
            // cbLoadFullRequestText
            // 
            this.cbLoadFullRequestText.AutoSize = true;
            this.cbLoadFullRequestText.Location = new System.Drawing.Point(250, 154);
            this.cbLoadFullRequestText.Name = "cbLoadFullRequestText";
            this.cbLoadFullRequestText.Size = new System.Drawing.Size(209, 17);
            this.cbLoadFullRequestText.TabIndex = 23;
            this.cbLoadFullRequestText.Text = "Завантажувати повний текс запитів";
            this.cbLoadFullRequestText.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Тип файлів";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbTiff
            // 
            this.rbTiff.AutoSize = true;
            this.rbTiff.Location = new System.Drawing.Point(99, 124);
            this.rbTiff.Name = "rbTiff";
            this.rbTiff.Size = new System.Drawing.Size(40, 17);
            this.rbTiff.TabIndex = 25;
            this.rbTiff.TabStop = true;
            this.rbTiff.Text = "Tiff";
            this.rbTiff.UseVisualStyleBackColor = true;
            // 
            // rbPdf
            // 
            this.rbPdf.AutoSize = true;
            this.rbPdf.Location = new System.Drawing.Point(145, 124);
            this.rbPdf.Name = "rbPdf";
            this.rbPdf.Size = new System.Drawing.Size(46, 17);
            this.rbPdf.TabIndex = 26;
            this.rbPdf.TabStop = true;
            this.rbPdf.Text = "PDF";
            this.rbPdf.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 215);
            this.Controls.Add(this.rbPdf);
            this.Controls.Add(this.rbTiff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbLoadFullRequestText);
            this.Controls.Add(this.cbSaveFiles);
            this.Controls.Add(this.btBinaryPathBrowse);
            this.Controls.Add(this.tbBinaryFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFileLogName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.btHistoryPath);
            this.Controls.Add(this.btLogPath);
            this.Controls.Add(this.tbHistoryPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLogPath);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.Text = "Налаштування";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHistoryPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLogPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLogPath;
        private System.Windows.Forms.Button btHistoryPath;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbFileLogName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBinaryPathBrowse;
        private System.Windows.Forms.TextBox tbBinaryFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbSaveFiles;
        private System.Windows.Forms.CheckBox cbLoadFullRequestText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbTiff;
        private System.Windows.Forms.RadioButton rbPdf;
    }
}