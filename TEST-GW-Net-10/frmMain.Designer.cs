namespace TEST_GW
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            chkSaveLog = new CheckBox();
            txtGW = new TextBox();
            txtArguments = new TextBox();
            txtOutput = new TextBox();
            btnSaveLog = new Button();
            txtFilename = new TextBox();
            lblFilename = new Label();
            lblWorkingDir = new Label();
            txtWorkingDir = new TextBox();
            btnExecute = new Button();
            lblGW = new Label();
            lnkLblGWontheWeb = new LinkLabel();
            txtBatchFile = new TextBox();
            lblBatchFile = new Label();
            btnGW_EXE = new Button();
            btnWorkingDir = new Button();
            btnFilename = new Button();
            btnSelectScript = new Button();
            lnkLabelRunBatch = new LinkLabel();
            chkExecuteScriptAutomatically = new CheckBox();
            lblArguments = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ttGW = new ToolTip(components);
            cnMnuSt = new ContextMenuStrip(components);
            openFileDialogGW = new OpenFileDialog();
            openFileDialogFilename = new OpenFileDialog();
            openFileDialogScript = new OpenFileDialog();
            SuspendLayout();
            // 
            // chkSaveLog
            // 
            chkSaveLog.AutoSize = true;
            chkSaveLog.Checked = true;
            chkSaveLog.CheckState = CheckState.Checked;
            chkSaveLog.Location = new Point(12, 235);
            chkSaveLog.Name = "chkSaveLog";
            chkSaveLog.Size = new Size(150, 19);
            chkSaveLog.TabIndex = 1;
            chkSaveLog.Text = "Save Log Automatically";
            chkSaveLog.UseVisualStyleBackColor = true;
            // 
            // txtGW
            // 
            txtGW.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGW.Location = new Point(12, 35);
            txtGW.Name = "txtGW";
            txtGW.Size = new Size(528, 23);
            txtGW.TabIndex = 3;
            // 
            // txtArguments
            // 
            txtArguments.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtArguments.Location = new Point(12, 86);
            txtArguments.Name = "txtArguments";
            txtArguments.Size = new Size(528, 23);
            txtArguments.TabIndex = 5;
            // 
            // txtOutput
            // 
            txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOutput.Location = new Point(12, 260);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(558, 404);
            txtOutput.TabIndex = 6;
            // 
            // btnSaveLog
            // 
            btnSaveLog.Location = new Point(168, 231);
            btnSaveLog.Name = "btnSaveLog";
            btnSaveLog.Size = new Size(75, 23);
            btnSaveLog.TabIndex = 7;
            btnSaveLog.Text = "Save &Log";
            btnSaveLog.UseVisualStyleBackColor = true;
            btnSaveLog.Click += button2_Click;
            // 
            // txtFilename
            // 
            txtFilename.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFilename.Location = new Point(249, 157);
            txtFilename.Name = "txtFilename";
            txtFilename.Size = new Size(291, 23);
            txtFilename.TabIndex = 9;
            // 
            // lblFilename
            // 
            lblFilename.AutoSize = true;
            lblFilename.Location = new Point(188, 161);
            lblFilename.Name = "lblFilename";
            lblFilename.Size = new Size(55, 15);
            lblFilename.TabIndex = 10;
            lblFilename.Text = "Filename";
            lblFilename.DoubleClick += lblFilename_Click;
            // 
            // lblWorkingDir
            // 
            lblWorkingDir.AutoSize = true;
            lblWorkingDir.Location = new Point(140, 132);
            lblWorkingDir.Name = "lblWorkingDir";
            lblWorkingDir.Size = new Size(103, 15);
            lblWorkingDir.TabIndex = 12;
            lblWorkingDir.Text = "Working Directory";
            // 
            // txtWorkingDir
            // 
            txtWorkingDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtWorkingDir.Location = new Point(249, 128);
            txtWorkingDir.Name = "txtWorkingDir";
            txtWorkingDir.Size = new Size(291, 23);
            txtWorkingDir.TabIndex = 11;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(12, 131);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(100, 44);
            btnExecute.TabIndex = 13;
            btnExecute.Text = "&Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += button1_Click;
            // 
            // lblGW
            // 
            lblGW.AutoSize = true;
            lblGW.Location = new Point(12, 17);
            lblGW.Name = "lblGW";
            lblGW.Size = new Size(105, 15);
            lblGW.TabIndex = 15;
            lblGW.Text = "Greaseweazel (exe)";
            // 
            // lnkLblGWontheWeb
            // 
            lnkLblGWontheWeb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lnkLblGWontheWeb.AutoSize = true;
            lnkLblGWontheWeb.Location = new Point(421, 17);
            lnkLblGWontheWeb.Name = "lnkLblGWontheWeb";
            lnkLblGWontheWeb.Size = new Size(119, 15);
            lnkLblGWontheWeb.TabIndex = 16;
            lnkLblGWontheWeb.TabStop = true;
            lnkLblGWontheWeb.Text = "GreaseWeazle Project";
            lnkLblGWontheWeb.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtBatchFile
            // 
            txtBatchFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBatchFile.Location = new Point(12, 202);
            txtBatchFile.Name = "txtBatchFile";
            txtBatchFile.Size = new Size(528, 23);
            txtBatchFile.TabIndex = 17;
            // 
            // lblBatchFile
            // 
            lblBatchFile.AutoSize = true;
            lblBatchFile.Location = new Point(12, 184);
            lblBatchFile.Name = "lblBatchFile";
            lblBatchFile.Size = new Size(94, 15);
            lblBatchFile.TabIndex = 20;
            lblBatchFile.Text = "Script to Execute";
            // 
            // btnGW_EXE
            // 
            btnGW_EXE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGW_EXE.Location = new Point(546, 35);
            btnGW_EXE.Name = "btnGW_EXE";
            btnGW_EXE.Size = new Size(24, 23);
            btnGW_EXE.TabIndex = 21;
            btnGW_EXE.Text = "...";
            btnGW_EXE.UseVisualStyleBackColor = true;
            btnGW_EXE.Click += btnGW_EXE_Click;
            // 
            // btnWorkingDir
            // 
            btnWorkingDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnWorkingDir.Location = new Point(546, 128);
            btnWorkingDir.Name = "btnWorkingDir";
            btnWorkingDir.Size = new Size(24, 23);
            btnWorkingDir.TabIndex = 22;
            btnWorkingDir.Text = "...";
            btnWorkingDir.UseVisualStyleBackColor = true;
            btnWorkingDir.Click += btnWorkingDir_Click;
            // 
            // btnFilename
            // 
            btnFilename.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFilename.Location = new Point(546, 157);
            btnFilename.Name = "btnFilename";
            btnFilename.Size = new Size(24, 23);
            btnFilename.TabIndex = 23;
            btnFilename.Text = "...";
            btnFilename.UseVisualStyleBackColor = true;
            btnFilename.Click += btnFilename_Click;
            // 
            // btnSelectScript
            // 
            btnSelectScript.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectScript.Location = new Point(546, 202);
            btnSelectScript.Name = "btnSelectScript";
            btnSelectScript.Size = new Size(24, 23);
            btnSelectScript.TabIndex = 24;
            btnSelectScript.Text = "...";
            btnSelectScript.UseVisualStyleBackColor = true;
            btnSelectScript.Click += btnSelectScript_Click;
            // 
            // lnkLabelRunBatch
            // 
            lnkLabelRunBatch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lnkLabelRunBatch.AutoSize = true;
            lnkLabelRunBatch.Location = new Point(460, 184);
            lnkLabelRunBatch.Name = "lnkLabelRunBatch";
            lnkLabelRunBatch.Size = new Size(80, 15);
            lnkLabelRunBatch.TabIndex = 25;
            lnkLabelRunBatch.TabStop = true;
            lnkLabelRunBatch.Text = "Execute Script";
            lnkLabelRunBatch.LinkClicked += lnkLabelRunBatch_LinkClicked;
            // 
            // chkExecuteScriptAutomatically
            // 
            chkExecuteScriptAutomatically.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkExecuteScriptAutomatically.AutoSize = true;
            chkExecuteScriptAutomatically.Checked = true;
            chkExecuteScriptAutomatically.CheckState = CheckState.Checked;
            chkExecuteScriptAutomatically.Location = new Point(364, 235);
            chkExecuteScriptAutomatically.Name = "chkExecuteScriptAutomatically";
            chkExecuteScriptAutomatically.Size = new Size(176, 19);
            chkExecuteScriptAutomatically.TabIndex = 26;
            chkExecuteScriptAutomatically.Text = "Automatically Execute Script";
            chkExecuteScriptAutomatically.UseVisualStyleBackColor = true;
            // 
            // lblArguments
            // 
            lblArguments.AutoSize = true;
            lblArguments.Location = new Point(12, 68);
            lblArguments.Name = "lblArguments";
            lblArguments.Size = new Size(66, 15);
            lblArguments.TabIndex = 27;
            lblArguments.Text = "Arguments";
            lblArguments.DoubleClick += lblArguments_DoubleClick_1;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            // 
            // cnMnuSt
            // 
            cnMnuSt.Name = "contextMenuStrip1";
            cnMnuSt.Size = new Size(61, 4);
            cnMnuSt.ItemClicked += cnMnuSt_ItemClicked;
            // 
            // openFileDialogGW
            // 
            openFileDialogGW.FileName = "openFileDialog1";
            // 
            // openFileDialogFilename
            // 
            openFileDialogFilename.FileName = "openFileDialog1";
            // 
            // openFileDialogScript
            // 
            openFileDialogScript.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 676);
            ContextMenuStrip = cnMnuSt;
            Controls.Add(lblGW);
            Controls.Add(lnkLblGWontheWeb);
            Controls.Add(txtGW);
            Controls.Add(btnGW_EXE);
            Controls.Add(lblArguments);
            Controls.Add(txtArguments);
            Controls.Add(btnExecute);
            Controls.Add(lblWorkingDir);
            Controls.Add(txtWorkingDir);
            Controls.Add(btnWorkingDir);
            Controls.Add(txtFilename);
            Controls.Add(lblFilename);
            Controls.Add(btnFilename);
            Controls.Add(lblBatchFile);
            Controls.Add(lnkLabelRunBatch);
            Controls.Add(txtBatchFile);
            Controls.Add(btnSelectScript);
            Controls.Add(chkSaveLog);
            Controls.Add(btnSaveLog);
            Controls.Add(chkExecuteScriptAutomatically);
            Controls.Add(txtOutput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GreaweWeazle Launcher";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkSaveLog;
        private TextBox txtGW;
        private TextBox txtArguments;
        private TextBox txtOutput;
        private Button btnSaveLog;
        private TextBox txtFilename;
        private Label lblFilename;
        private Label lblWorkingDir;
        private TextBox txtWorkingDir;
        private Button btnExecute;
        private Label lblGW;
        private LinkLabel lnkLblGWontheWeb;

        private TextBox txtBatchFile;
        private Label lblBatchFile;
        private Button btnGW_EXE;
        private Button btnWorkingDir;
        private Button btnFilename;
        private Button btnSelectScript;
        private LinkLabel lnkLabelRunBatch;
        private CheckBox chkExecuteScriptAutomatically;
        private Label lblArguments;
        private FolderBrowserDialog folderBrowserDialog1;
        private ToolTip ttGW;
        private ContextMenuStrip cnMnuSt;
        private OpenFileDialog openFileDialogGW;
        private OpenFileDialog openFileDialogFilename;
        private OpenFileDialog openFileDialogScript;
    }
}
