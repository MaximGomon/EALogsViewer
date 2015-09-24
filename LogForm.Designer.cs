namespace EALogsViewer
{
    partial class LogForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel_FilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.filterSplitContainer = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxProcessor = new System.Windows.Forms.CheckBox();
            this.checkBoxPool = new System.Windows.Forms.CheckBox();
            this.checkBoxBARS = new System.Windows.Forms.CheckBox();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.cbUseDate = new System.Windows.Forms.CheckBox();
            this.btClearFilter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.btFilter = new System.Windows.Forms.Button();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDocExternalId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAgreementCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRNK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainerData = new System.Windows.Forms.SplitContainer();
            this.dataListView = new System.Windows.Forms.ListView();
            this.lineNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.method = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rnk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.docId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.agrId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.account = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.answerTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detailRichTextBox = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mainMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.tbOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.btSetting = new System.Windows.Forms.ToolStripButton();
            this.tbExit = new System.Windows.Forms.ToolStripButton();
            this.linkRnk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterSplitContainer)).BeginInit();
            this.filterSplitContainer.Panel1.SuspendLayout();
            this.filterSplitContainer.Panel2.SuspendLayout();
            this.filterSplitContainer.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerData)).BeginInit();
            this.splitContainerData.Panel1.SuspendLayout();
            this.splitContainerData.Panel2.SuspendLayout();
            this.splitContainerData.SuspendLayout();
            this.mainMenuToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLabel_FilePath});
            this.statusStrip.Location = new System.Drawing.Point(0, 537);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(900, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "File path:";
            // 
            // statusLabel_FilePath
            // 
            this.statusLabel_FilePath.Name = "statusLabel_FilePath";
            this.statusLabel_FilePath.Size = new System.Drawing.Size(48, 17);
            this.statusLabel_FilePath.Text = "C:\\Logs";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.filterSplitContainer);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerData);
            this.splitContainerMain.Size = new System.Drawing.Size(900, 537);
            this.splitContainerMain.SplitterDistance = 155;
            this.splitContainerMain.TabIndex = 2;
            // 
            // filterSplitContainer
            // 
            this.filterSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.filterSplitContainer.IsSplitterFixed = true;
            this.filterSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.filterSplitContainer.Name = "filterSplitContainer";
            this.filterSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // filterSplitContainer.Panel1
            // 
            this.filterSplitContainer.Panel1.Controls.Add(this.label6);
            this.filterSplitContainer.Panel1.Controls.Add(this.checkBoxProcessor);
            this.filterSplitContainer.Panel1.Controls.Add(this.checkBoxPool);
            this.filterSplitContainer.Panel1.Controls.Add(this.checkBoxBARS);
            // 
            // filterSplitContainer.Panel2
            // 
            this.filterSplitContainer.Panel2.Controls.Add(this.groupBoxFilters);
            this.filterSplitContainer.Size = new System.Drawing.Size(900, 155);
            this.filterSplitContainer.SplitterDistance = 28;
            this.filterSplitContainer.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(305, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Select service for fill method combo box";
            // 
            // checkBoxProcessor
            // 
            this.checkBoxProcessor.AutoSize = true;
            this.checkBoxProcessor.Location = new System.Drawing.Point(199, 7);
            this.checkBoxProcessor.Name = "checkBoxProcessor";
            this.checkBoxProcessor.Size = new System.Drawing.Size(99, 17);
            this.checkBoxProcessor.TabIndex = 2;
            this.checkBoxProcessor.Text = "Data Processor";
            this.checkBoxProcessor.UseVisualStyleBackColor = true;
            this.checkBoxProcessor.CheckedChanged += new System.EventHandler(this.checkBoxProcessor_CheckedChanged);
            // 
            // checkBoxPool
            // 
            this.checkBoxPool.AutoSize = true;
            this.checkBoxPool.Location = new System.Drawing.Point(120, 7);
            this.checkBoxPool.Name = "checkBoxPool";
            this.checkBoxPool.Size = new System.Drawing.Size(73, 17);
            this.checkBoxPool.TabIndex = 1;
            this.checkBoxPool.Text = "Data Pool";
            this.checkBoxPool.UseVisualStyleBackColor = true;
            this.checkBoxPool.CheckedChanged += new System.EventHandler(this.checkBoxPool_CheckedChanged);
            // 
            // checkBoxBARS
            // 
            this.checkBoxBARS.AutoSize = true;
            this.checkBoxBARS.Location = new System.Drawing.Point(14, 7);
            this.checkBoxBARS.Name = "checkBoxBARS";
            this.checkBoxBARS.Size = new System.Drawing.Size(100, 17);
            this.checkBoxBARS.TabIndex = 0;
            this.checkBoxBARS.Text = "BARS Sheduler";
            this.checkBoxBARS.UseVisualStyleBackColor = true;
            this.checkBoxBARS.CheckedChanged += new System.EventHandler(this.checkBoxBARS_CheckedChanged);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.cbUseDate);
            this.groupBoxFilters.Controls.Add(this.btClearFilter);
            this.groupBoxFilters.Controls.Add(this.label7);
            this.groupBoxFilters.Controls.Add(this.dtpEventDate);
            this.groupBoxFilters.Controls.Add(this.btFilter);
            this.groupBoxFilters.Controls.Add(this.tbAccount);
            this.groupBoxFilters.Controls.Add(this.label5);
            this.groupBoxFilters.Controls.Add(this.tbDocExternalId);
            this.groupBoxFilters.Controls.Add(this.label4);
            this.groupBoxFilters.Controls.Add(this.tbAgreementCode);
            this.groupBoxFilters.Controls.Add(this.label3);
            this.groupBoxFilters.Controls.Add(this.tbRNK);
            this.groupBoxFilters.Controls.Add(this.label2);
            this.groupBoxFilters.Controls.Add(this.comboBoxMethod);
            this.groupBoxFilters.Controls.Add(this.label1);
            this.groupBoxFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxFilters.Location = new System.Drawing.Point(0, -4);
            this.groupBoxFilters.Margin = new System.Windows.Forms.Padding(10);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxFilters.Size = new System.Drawing.Size(900, 127);
            this.groupBoxFilters.TabIndex = 0;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фільтри";
            // 
            // cbUseDate
            // 
            this.cbUseDate.AutoSize = true;
            this.cbUseDate.Location = new System.Drawing.Point(446, 96);
            this.cbUseDate.Name = "cbUseDate";
            this.cbUseDate.Size = new System.Drawing.Size(15, 14);
            this.cbUseDate.TabIndex = 14;
            this.cbUseDate.UseVisualStyleBackColor = true;
            this.cbUseDate.CheckedChanged += new System.EventHandler(this.cbUseDate_CheckedChanged);
            // 
            // btClearFilter
            // 
            this.btClearFilter.BackgroundImage = global::EALogsViewer.Properties.Resources.symbol_delete;
            this.btClearFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClearFilter.Location = new System.Drawing.Point(731, 40);
            this.btClearFilter.Name = "btClearFilter";
            this.btClearFilter.Size = new System.Drawing.Size(62, 58);
            this.btClearFilter.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btClearFilter, "Скасувати фільтрацію");
            this.btClearFilter.UseVisualStyleBackColor = true;
            this.btClearFilter.Click += new System.EventHandler(this.btClearFilter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дата події";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Enabled = false;
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEventDate.Location = new System.Drawing.Point(467, 94);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(117, 20);
            this.dtpEventDate.TabIndex = 11;
            // 
            // btFilter
            // 
            this.btFilter.BackgroundImage = global::EALogsViewer.Properties.Resources.symbol_check;
            this.btFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFilter.Location = new System.Drawing.Point(663, 40);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(62, 58);
            this.btFilter.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btFilter, "Застосувати фільтр");
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(95, 96);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(243, 20);
            this.tbAccount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Номер \r\nрахунку";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDocExternalId
            // 
            this.tbDocExternalId.Location = new System.Drawing.Point(445, 60);
            this.tbDocExternalId.Name = "tbDocExternalId";
            this.tbDocExternalId.Size = new System.Drawing.Size(139, 20);
            this.tbDocExternalId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер друку";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAgreementCode
            // 
            this.tbAgreementCode.Location = new System.Drawing.Point(95, 60);
            this.tbAgreementCode.Name = "tbAgreementCode";
            this.tbAgreementCode.Size = new System.Drawing.Size(243, 20);
            this.tbAgreementCode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Код угоди";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbRNK
            // 
            this.tbRNK.Location = new System.Drawing.Point(445, 24);
            this.tbRNK.Name = "tbRNK";
            this.tbRNK.Size = new System.Drawing.Size(139, 20);
            this.tbRNK.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RNK:";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Location = new System.Drawing.Point(95, 24);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(243, 21);
            this.comboBoxMethod.Sorted = true;
            this.comboBoxMethod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Метод:";
            // 
            // splitContainerData
            // 
            this.splitContainerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerData.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerData.Location = new System.Drawing.Point(0, 0);
            this.splitContainerData.Name = "splitContainerData";
            this.splitContainerData.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerData.Panel1
            // 
            this.splitContainerData.Panel1.Controls.Add(this.dataListView);
            // 
            // splitContainerData.Panel2
            // 
            this.splitContainerData.Panel2.Controls.Add(this.detailRichTextBox);
            this.splitContainerData.Size = new System.Drawing.Size(900, 378);
            this.splitContainerData.SplitterDistance = 213;
            this.splitContainerData.TabIndex = 1;
            // 
            // dataListView
            // 
            this.dataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lineNumber,
            this.eventTime,
            this.method,
            this.rnk,
            this.docId,
            this.agrId,
            this.account,
            this.answerTime,
            this.resp,
            this.number,
            this.linkRnk});
            this.dataListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListView.FullRowSelect = true;
            this.dataListView.GridLines = true;
            this.dataListView.Location = new System.Drawing.Point(0, 0);
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(900, 213);
            this.dataListView.TabIndex = 0;
            this.dataListView.UseCompatibleStateImageBehavior = false;
            this.dataListView.View = System.Windows.Forms.View.Details;
            this.dataListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.dataListView_ItemSelectionChanged);
            // 
            // lineNumber
            // 
            this.lineNumber.DisplayIndex = 1;
            this.lineNumber.Text = "Line";
            this.lineNumber.Width = 35;
            // 
            // eventTime
            // 
            this.eventTime.DisplayIndex = 2;
            this.eventTime.Text = "Час події";
            this.eventTime.Width = 115;
            // 
            // method
            // 
            this.method.DisplayIndex = 3;
            this.method.Text = "Метод";
            this.method.Width = 105;
            // 
            // rnk
            // 
            this.rnk.DisplayIndex = 4;
            this.rnk.Text = "RNK";
            this.rnk.Width = 55;
            // 
            // docId
            // 
            this.docId.DisplayIndex = 5;
            this.docId.Text = "№ друку";
            // 
            // agrId
            // 
            this.agrId.DisplayIndex = 6;
            this.agrId.Text = "Код угоди";
            // 
            // account
            // 
            this.account.DisplayIndex = 7;
            this.account.Text = "Рахунок";
            this.account.Width = 100;
            // 
            // answerTime
            // 
            this.answerTime.DisplayIndex = 8;
            this.answerTime.Text = "Час відповіді";
            this.answerTime.Width = 115;
            // 
            // resp
            // 
            this.resp.DisplayIndex = 9;
            this.resp.Text = "Текст відповіді";
            this.resp.Width = 800;
            // 
            // number
            // 
            this.number.DisplayIndex = 0;
            this.number.Text = "№п/п";
            this.number.Width = 35;
            // 
            // detailRichTextBox
            // 
            this.detailRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.detailRichTextBox.Name = "detailRichTextBox";
            this.detailRichTextBox.Size = new System.Drawing.Size(900, 161);
            this.detailRichTextBox.TabIndex = 0;
            this.detailRichTextBox.Text = "";
            // 
            // mainMenuToolStrip
            // 
            this.mainMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbOpenFile,
            this.tsbRefresh,
            this.btSetting,
            this.tbExit});
            this.mainMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuToolStrip.Name = "mainMenuToolStrip";
            this.mainMenuToolStrip.Size = new System.Drawing.Size(900, 25);
            this.mainMenuToolStrip.TabIndex = 3;
            this.mainMenuToolStrip.Text = "toolStrip1";
            // 
            // tbOpenFile
            // 
            this.tbOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("tbOpenFile.Image")));
            this.tbOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpenFile.Name = "tbOpenFile";
            this.tbOpenFile.Size = new System.Drawing.Size(23, 22);
            this.tbOpenFile.Text = "Відкрити файл";
            this.tbOpenFile.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "Оновити";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // btSetting
            // 
            this.btSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSetting.Image = ((System.Drawing.Image)(resources.GetObject("btSetting.Image")));
            this.btSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(23, 22);
            this.btSetting.ToolTipText = "Налаштування";
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // tbExit
            // 
            this.tbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbExit.Image = ((System.Drawing.Image)(resources.GetObject("tbExit.Image")));
            this.tbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbExit.Name = "tbExit";
            this.tbExit.Size = new System.Drawing.Size(23, 22);
            this.tbExit.Text = "Вихід";
            this.tbExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // linkRnk
            // 
            this.linkRnk.Text = "Link РНК";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 559);
            this.Controls.Add(this.mainMenuToolStrip);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogForm";
            this.Text = "Log Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogForm_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.filterSplitContainer.Panel1.ResumeLayout(false);
            this.filterSplitContainer.Panel1.PerformLayout();
            this.filterSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterSplitContainer)).EndInit();
            this.filterSplitContainer.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.splitContainerData.Panel1.ResumeLayout(false);
            this.splitContainerData.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerData)).EndInit();
            this.splitContainerData.ResumeLayout(false);
            this.mainMenuToolStrip.ResumeLayout(false);
            this.mainMenuToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_FilePath;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer filterSplitContainer;
        private System.Windows.Forms.CheckBox checkBoxProcessor;
        private System.Windows.Forms.CheckBox checkBoxPool;
        private System.Windows.Forms.CheckBox checkBoxBARS;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDocExternalId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAgreementCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRNK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.ListView dataListView;
        private System.Windows.Forms.ColumnHeader lineNumber;
        private System.Windows.Forms.ColumnHeader method;
        private System.Windows.Forms.ColumnHeader rnk;
        private System.Windows.Forms.ColumnHeader eventTime;
        private System.Windows.Forms.ColumnHeader docId;
        private System.Windows.Forms.ColumnHeader agrId;
        private System.Windows.Forms.ColumnHeader account;
        private System.Windows.Forms.ColumnHeader answerTime;
        private System.Windows.Forms.ColumnHeader resp;
        private System.Windows.Forms.SplitContainer splitContainerData;
        private System.Windows.Forms.RichTextBox detailRichTextBox;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Button btClearFilter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip mainMenuToolStrip;
        private System.Windows.Forms.ToolStripButton tbOpenFile;
        private System.Windows.Forms.ToolStripButton tbExit;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.CheckBox cbUseDate;
        private System.Windows.Forms.ToolStripButton btSetting;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ColumnHeader linkRnk;
    }
}

