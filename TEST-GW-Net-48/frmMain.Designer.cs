using System.Drawing;
using System.Windows.Forms;

namespace TEST_GW__Net4
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.folderBrDlgWorkingDir = new System.Windows.Forms.FolderBrowserDialog();
            this.ttGW = new System.Windows.Forms.ToolTip(this.components);
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnGW_EXE = new System.Windows.Forms.Button();
            this.btnWorkingDir = new System.Windows.Forms.Button();
            this.btnFilename = new System.Windows.Forms.Button();
            this.btnSelectScript = new System.Windows.Forms.Button();
            this.lnkLblGWontheWeb = new System.Windows.Forms.LinkLabel();
            this.lnkLabelRunBatch = new System.Windows.Forms.LinkLabel();
            this.txtGW = new System.Windows.Forms.TextBox();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.txtWorkingDir = new System.Windows.Forms.TextBox();
            this.txtBatchFile = new System.Windows.Forms.TextBox();
            this.chkExecuteScriptAutomatically = new System.Windows.Forms.CheckBox();
            this.txtFileList = new System.Windows.Forms.TextBox();
            this.cnMnuSt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBatch = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.lblWorkingDir = new System.Windows.Forms.Label();
            this.lblGW = new System.Windows.Forms.Label();
            this.lblBatchFile = new System.Windows.Forms.Label();
            this.lblArguments = new System.Windows.Forms.Label();
            this.chkSaveLog = new System.Windows.Forms.CheckBox();
            this.chkBatchExecuteScript = new System.Windows.Forms.CheckBox();
            this.chkBatchRunMinimized = new System.Windows.Forms.CheckBox();
            this.chkBatchWaitForExit = new System.Windows.Forms.CheckBox();
            this.chkBatchClearListAfterExecute = new System.Windows.Forms.CheckBox();
            this.chkBatchClearAfterDragDrop = new System.Windows.Forms.CheckBox();
            this.chkDisablex64Redirection = new System.Windows.Forms.CheckBox();
            this.btnBatchClearList = new System.Windows.Forms.Button();
            this.btnBatchExecute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrDlgWorkingDir
            // 
            this.folderBrDlgWorkingDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 245);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(567, 419);
            this.txtOutput.TabIndex = 32;
            this.ttGW.SetToolTip(this.txtOutput, "The results, in realtime, of the command executed above. Will be automatically sa" +
        "ved if the save check box is checked.");
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Location = new System.Drawing.Point(12, 216);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLog.TabIndex = 33;
            this.btnSaveLog.Text = "Save &Log";
            this.ttGW.SetToolTip(this.btnSaveLog, "Saves a log file, in the format Working Directory\\Filename.log");
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(12, 116);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(100, 44);
            this.btnExecute.TabIndex = 38;
            this.btnExecute.Text = "&Execute";
            this.ttGW.SetToolTip(this.btnExecute, "Execute the program, with the above parameters, using the filename on the right");
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnGW_EXE
            // 
            this.btnGW_EXE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGW_EXE.Location = new System.Drawing.Point(555, 23);
            this.btnGW_EXE.Name = "btnGW_EXE";
            this.btnGW_EXE.Size = new System.Drawing.Size(24, 23);
            this.btnGW_EXE.TabIndex = 43;
            this.btnGW_EXE.Text = "...";
            this.ttGW.SetToolTip(this.btnGW_EXE, "Browse to the GW.exe.");
            this.btnGW_EXE.UseVisualStyleBackColor = true;
            this.btnGW_EXE.Click += new System.EventHandler(this.btnGW_EXE_Click);
            // 
            // btnWorkingDir
            // 
            this.btnWorkingDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorkingDir.Location = new System.Drawing.Point(555, 112);
            this.btnWorkingDir.Name = "btnWorkingDir";
            this.btnWorkingDir.Size = new System.Drawing.Size(24, 23);
            this.btnWorkingDir.TabIndex = 44;
            this.btnWorkingDir.Text = "...";
            this.ttGW.SetToolTip(this.btnWorkingDir, "Browse to a folder, to use as the working directoy.");
            this.btnWorkingDir.UseVisualStyleBackColor = true;
            this.btnWorkingDir.Click += new System.EventHandler(this.btnWorkingDir_Click);
            // 
            // btnFilename
            // 
            this.btnFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilename.Location = new System.Drawing.Point(555, 142);
            this.btnFilename.Name = "btnFilename";
            this.btnFilename.Size = new System.Drawing.Size(24, 23);
            this.btnFilename.TabIndex = 45;
            this.btnFilename.Text = "...";
            this.ttGW.SetToolTip(this.btnFilename, "Pick the filename to work on, here. The Working directory will also be set.");
            this.btnFilename.UseVisualStyleBackColor = true;
            this.btnFilename.Click += new System.EventHandler(this.btnFilename_Click);
            // 
            // btnSelectScript
            // 
            this.btnSelectScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectScript.Location = new System.Drawing.Point(555, 185);
            this.btnSelectScript.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectScript.Name = "btnSelectScript";
            this.btnSelectScript.Size = new System.Drawing.Size(24, 23);
            this.btnSelectScript.TabIndex = 46;
            this.btnSelectScript.Text = "...";
            this.ttGW.SetToolTip(this.btnSelectScript, "Browse to the batch file/script to run.");
            this.btnSelectScript.UseVisualStyleBackColor = true;
            this.btnSelectScript.Click += new System.EventHandler(this.btnSelectScript_Click);
            // 
            // lnkLblGWontheWeb
            // 
            this.lnkLblGWontheWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLblGWontheWeb.AutoSize = true;
            this.lnkLblGWontheWeb.Location = new System.Drawing.Point(439, 9);
            this.lnkLblGWontheWeb.Name = "lnkLblGWontheWeb";
            this.lnkLblGWontheWeb.Size = new System.Drawing.Size(110, 13);
            this.lnkLblGWontheWeb.TabIndex = 40;
            this.lnkLblGWontheWeb.TabStop = true;
            this.lnkLblGWontheWeb.Text = "Greaseweazle Project";
            this.ttGW.SetToolTip(this.lnkLblGWontheWeb, "The Greaseweazle project Wiki page.");
            this.lnkLblGWontheWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblGWontheWeb_LinkClicked);
            // 
            // lnkLabelRunBatch
            // 
            this.lnkLabelRunBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLabelRunBatch.AutoSize = true;
            this.lnkLabelRunBatch.Location = new System.Drawing.Point(473, 169);
            this.lnkLabelRunBatch.Name = "lnkLabelRunBatch";
            this.lnkLabelRunBatch.Size = new System.Drawing.Size(76, 13);
            this.lnkLabelRunBatch.TabIndex = 47;
            this.lnkLabelRunBatch.TabStop = true;
            this.lnkLabelRunBatch.Text = "Execute Script";
            this.ttGW.SetToolTip(this.lnkLabelRunBatch, "Run the batch file/script below, immediately. (File above must exist)");
            this.lnkLabelRunBatch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabelRunBatch_LinkClicked);
            // 
            // txtGW
            // 
            this.txtGW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGW.Location = new System.Drawing.Point(12, 25);
            this.txtGW.Name = "txtGW";
            this.txtGW.Size = new System.Drawing.Size(537, 20);
            this.txtGW.TabIndex = 30;
            this.ttGW.SetToolTip(this.txtGW, "Set the path to the exe here.");
            // 
            // txtArguments
            // 
            this.txtArguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArguments.Location = new System.Drawing.Point(12, 72);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(537, 20);
            this.txtArguments.TabIndex = 31;
            this.ttGW.SetToolTip(this.txtArguments, "Set all the program parameters here. The filename will be appended unless you use" +
        " %FILENAME or %NOEXTFILENAME");
            // 
            // txtFilename
            // 
            this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilename.Location = new System.Drawing.Point(249, 142);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(300, 20);
            this.txtFilename.TabIndex = 34;
            this.ttGW.SetToolTip(this.txtFilename, "The name of the file to work on, in the folder above.");
            // 
            // txtWorkingDir
            // 
            this.txtWorkingDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkingDir.Location = new System.Drawing.Point(249, 113);
            this.txtWorkingDir.Name = "txtWorkingDir";
            this.txtWorkingDir.Size = new System.Drawing.Size(300, 20);
            this.txtWorkingDir.TabIndex = 36;
            this.ttGW.SetToolTip(this.txtWorkingDir, "The main folder to keep all your input/output files.");
            // 
            // txtBatchFile
            // 
            this.txtBatchFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBatchFile.Location = new System.Drawing.Point(12, 187);
            this.txtBatchFile.Name = "txtBatchFile";
            this.txtBatchFile.Size = new System.Drawing.Size(537, 20);
            this.txtBatchFile.TabIndex = 41;
            this.ttGW.SetToolTip(this.txtBatchFile, "Run this script on the filename above. While the main GW program has no problem w" +
        "ith filenames that have spaces, scripts/batch files might.");
            // 
            // chkExecuteScriptAutomatically
            // 
            this.chkExecuteScriptAutomatically.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkExecuteScriptAutomatically.AutoSize = true;
            this.chkExecuteScriptAutomatically.Checked = true;
            this.chkExecuteScriptAutomatically.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExecuteScriptAutomatically.Location = new System.Drawing.Point(389, 220);
            this.chkExecuteScriptAutomatically.Name = "chkExecuteScriptAutomatically";
            this.chkExecuteScriptAutomatically.Size = new System.Drawing.Size(160, 17);
            this.chkExecuteScriptAutomatically.TabIndex = 48;
            this.chkExecuteScriptAutomatically.Text = "Automatically Execute Script";
            this.ttGW.SetToolTip(this.chkExecuteScriptAutomatically, "If checked, the above script will run once the command has been executed.");
            this.chkExecuteScriptAutomatically.UseVisualStyleBackColor = true;
            // 
            // txtFileList
            // 
            this.txtFileList.AllowDrop = true;
            this.txtFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileList.Location = new System.Drawing.Point(3, 12);
            this.txtFileList.Multiline = true;
            this.txtFileList.Name = "txtFileList";
            this.txtFileList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFileList.Size = new System.Drawing.Size(553, 562);
            this.txtFileList.TabIndex = 30;
            this.ttGW.SetToolTip(this.txtFileList, "A list of files for the exe and arguments (left)");
            // 
            // cnMnuSt
            // 
            this.cnMnuSt.Name = "cnMnuSt";
            this.cnMnuSt.Size = new System.Drawing.Size(61, 4);
            this.cnMnuSt.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cnMnuSt_ItemClicked);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtOutput);
            this.splitContainer1.Panel1.Controls.Add(this.btnBatch);
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveLog);
            this.splitContainer1.Panel1.Controls.Add(this.btnExecute);
            this.splitContainer1.Panel1.Controls.Add(this.btnGW_EXE);
            this.splitContainer1.Panel1.Controls.Add(this.btnWorkingDir);
            this.splitContainer1.Panel1.Controls.Add(this.btnFilename);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectScript);
            this.splitContainer1.Panel1.Controls.Add(this.lnkLblGWontheWeb);
            this.splitContainer1.Panel1.Controls.Add(this.lnkLabelRunBatch);
            this.splitContainer1.Panel1.Controls.Add(this.lblFilename);
            this.splitContainer1.Panel1.Controls.Add(this.lblWorkingDir);
            this.splitContainer1.Panel1.Controls.Add(this.lblGW);
            this.splitContainer1.Panel1.Controls.Add(this.lblBatchFile);
            this.splitContainer1.Panel1.Controls.Add(this.lblArguments);
            this.splitContainer1.Panel1.Controls.Add(this.txtGW);
            this.splitContainer1.Panel1.Controls.Add(this.txtArguments);
            this.splitContainer1.Panel1.Controls.Add(this.txtFilename);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkingDir);
            this.splitContainer1.Panel1.Controls.Add(this.txtBatchFile);
            this.splitContainer1.Panel1.Controls.Add(this.chkSaveLog);
            this.splitContainer1.Panel1.Controls.Add(this.chkExecuteScriptAutomatically);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chkBatchExecuteScript);
            this.splitContainer1.Panel2.Controls.Add(this.chkBatchRunMinimized);
            this.splitContainer1.Panel2.Controls.Add(this.chkBatchWaitForExit);
            this.splitContainer1.Panel2.Controls.Add(this.chkBatchClearListAfterExecute);
            this.splitContainer1.Panel2.Controls.Add(this.chkBatchClearAfterDragDrop);
            this.splitContainer1.Panel2.Controls.Add(this.chkDisablex64Redirection);
            this.splitContainer1.Panel2.Controls.Add(this.btnBatchClearList);
            this.splitContainer1.Panel2.Controls.Add(this.btnBatchExecute);
            this.splitContainer1.Panel2.Controls.Add(this.txtFileList);
            this.splitContainer1.Size = new System.Drawing.Size(1157, 676);
            this.splitContainer1.SplitterDistance = 585;
            this.splitContainer1.TabIndex = 32;
            // 
            // btnBatch
            // 
            this.btnBatch.Location = new System.Drawing.Point(249, 216);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(100, 23);
            this.btnBatch.TabIndex = 50;
            this.btnBatch.Text = "&Batch Mode";
            this.btnBatch.UseVisualStyleBackColor = true;
            this.btnBatch.Visible = false;
            this.btnBatch.Click += new System.EventHandler(this.btnBatch_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(188, 146);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(49, 13);
            this.lblFilename.TabIndex = 35;
            this.lblFilename.Text = "Filename";
            this.lblFilename.DoubleClick += new System.EventHandler(this.lblFilename_DoubleClick);
            // 
            // lblWorkingDir
            // 
            this.lblWorkingDir.AutoSize = true;
            this.lblWorkingDir.Location = new System.Drawing.Point(140, 117);
            this.lblWorkingDir.Name = "lblWorkingDir";
            this.lblWorkingDir.Size = new System.Drawing.Size(92, 13);
            this.lblWorkingDir.TabIndex = 37;
            this.lblWorkingDir.Text = "Working Directory";
            // 
            // lblGW
            // 
            this.lblGW.AutoSize = true;
            this.lblGW.Location = new System.Drawing.Point(12, 9);
            this.lblGW.Name = "lblGW";
            this.lblGW.Size = new System.Drawing.Size(100, 13);
            this.lblGW.TabIndex = 39;
            this.lblGW.Text = "Greaseweazel (exe)";
            // 
            // lblBatchFile
            // 
            this.lblBatchFile.AutoSize = true;
            this.lblBatchFile.Location = new System.Drawing.Point(12, 169);
            this.lblBatchFile.Name = "lblBatchFile";
            this.lblBatchFile.Size = new System.Drawing.Size(88, 13);
            this.lblBatchFile.TabIndex = 42;
            this.lblBatchFile.Text = "Script to Execute";
            // 
            // lblArguments
            // 
            this.lblArguments.AutoSize = true;
            this.lblArguments.Location = new System.Drawing.Point(12, 54);
            this.lblArguments.Name = "lblArguments";
            this.lblArguments.Size = new System.Drawing.Size(57, 13);
            this.lblArguments.TabIndex = 49;
            this.lblArguments.Text = "Arguments";
            this.lblArguments.DoubleClick += new System.EventHandler(this.lblArguments_DoubleClick);
            // 
            // chkSaveLog
            // 
            this.chkSaveLog.AutoSize = true;
            this.chkSaveLog.Checked = true;
            this.chkSaveLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveLog.Location = new System.Drawing.Point(93, 220);
            this.chkSaveLog.Name = "chkSaveLog";
            this.chkSaveLog.Size = new System.Drawing.Size(137, 17);
            this.chkSaveLog.TabIndex = 29;
            this.chkSaveLog.Text = "Save Log Automatically";
            this.chkSaveLog.UseVisualStyleBackColor = true;
            // 
            // chkBatchExecuteScript
            // 
            this.chkBatchExecuteScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBatchExecuteScript.AutoSize = true;
            this.chkBatchExecuteScript.Location = new System.Drawing.Point(254, 647);
            this.chkBatchExecuteScript.Name = "chkBatchExecuteScript";
            this.chkBatchExecuteScript.Size = new System.Drawing.Size(95, 17);
            this.chkBatchExecuteScript.TabIndex = 38;
            this.chkBatchExecuteScript.Text = "Execute Script";
            this.chkBatchExecuteScript.UseVisualStyleBackColor = true;
            // 
            // chkBatchRunMinimized
            // 
            this.chkBatchRunMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBatchRunMinimized.AutoSize = true;
            this.chkBatchRunMinimized.Location = new System.Drawing.Point(154, 647);
            this.chkBatchRunMinimized.Name = "chkBatchRunMinimized";
            this.chkBatchRunMinimized.Size = new System.Drawing.Size(94, 17);
            this.chkBatchRunMinimized.TabIndex = 37;
            this.chkBatchRunMinimized.Text = "Run minimized";
            this.chkBatchRunMinimized.ThreeState = true;
            this.chkBatchRunMinimized.UseVisualStyleBackColor = true;
            // 
            // chkBatchWaitForExit
            // 
            this.chkBatchWaitForExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBatchWaitForExit.AutoSize = true;
            this.chkBatchWaitForExit.Location = new System.Drawing.Point(154, 616);
            this.chkBatchWaitForExit.Name = "chkBatchWaitForExit";
            this.chkBatchWaitForExit.Size = new System.Drawing.Size(82, 17);
            this.chkBatchWaitForExit.TabIndex = 36;
            this.chkBatchWaitForExit.Text = "Wait for exit";
            this.chkBatchWaitForExit.UseVisualStyleBackColor = true;
            // 
            // chkBatchClearListAfterExecute
            // 
            this.chkBatchClearListAfterExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBatchClearListAfterExecute.AutoSize = true;
            this.chkBatchClearListAfterExecute.Location = new System.Drawing.Point(3, 647);
            this.chkBatchClearListAfterExecute.Name = "chkBatchClearListAfterExecute";
            this.chkBatchClearListAfterExecute.Size = new System.Drawing.Size(135, 17);
            this.chkBatchClearListAfterExecute.TabIndex = 35;
            this.chkBatchClearListAfterExecute.Text = "Clear List after Execute";
            this.chkBatchClearListAfterExecute.ThreeState = true;
            this.chkBatchClearListAfterExecute.UseVisualStyleBackColor = true;
            // 
            // chkBatchClearAfterDragDrop
            // 
            this.chkBatchClearAfterDragDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBatchClearAfterDragDrop.AutoSize = true;
            this.chkBatchClearAfterDragDrop.Location = new System.Drawing.Point(3, 616);
            this.chkBatchClearAfterDragDrop.Name = "chkBatchClearAfterDragDrop";
            this.chkBatchClearAfterDragDrop.Size = new System.Drawing.Size(145, 17);
            this.chkBatchClearAfterDragDrop.TabIndex = 34;
            this.chkBatchClearAfterDragDrop.Text = "Clear List on Drag && Drop";
            this.chkBatchClearAfterDragDrop.UseVisualStyleBackColor = true;
            // 
            // chkDisablex64Redirection
            // 
            this.chkDisablex64Redirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDisablex64Redirection.AutoSize = true;
            this.chkDisablex64Redirection.Location = new System.Drawing.Point(3, 584);
            this.chkDisablex64Redirection.Name = "chkDisablex64Redirection";
            this.chkDisablex64Redirection.Size = new System.Drawing.Size(285, 17);
            this.chkDisablex64Redirection.TabIndex = 33;
            this.chkDisablex64Redirection.Text = "Disable x64 file redirection (System32 --> SYSWOW64)";
            this.chkDisablex64Redirection.UseVisualStyleBackColor = true;
            // 
            // btnBatchClearList
            // 
            this.btnBatchClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchClearList.Location = new System.Drawing.Point(456, 580);
            this.btnBatchClearList.Name = "btnBatchClearList";
            this.btnBatchClearList.Size = new System.Drawing.Size(100, 23);
            this.btnBatchClearList.TabIndex = 32;
            this.btnBatchClearList.Text = "Clear List";
            this.btnBatchClearList.UseVisualStyleBackColor = true;
            this.btnBatchClearList.Click += new System.EventHandler(this.btnBatchClearList_Click);
            // 
            // btnBatchExecute
            // 
            this.btnBatchExecute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchExecute.Location = new System.Drawing.Point(356, 620);
            this.btnBatchExecute.Name = "btnBatchExecute";
            this.btnBatchExecute.Size = new System.Drawing.Size(200, 44);
            this.btnBatchExecute.TabIndex = 31;
            this.btnBatchExecute.Text = "E&xecute Batch";
            this.btnBatchExecute.UseVisualStyleBackColor = true;
            this.btnBatchExecute.Click += new System.EventHandler(this.btnBatchExecute_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 676);
            this.ContextMenuStrip = this.cnMnuSt;
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GreaweWeazle Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrDlgWorkingDir;
        private ToolTip ttGW;
        private ContextMenuStrip cnMnuSt;
        private SplitContainer splitContainer1;
        private TextBox txtOutput;
        private Button btnBatch;
        private Button btnSaveLog;
        private Button btnExecute;
        private Button btnGW_EXE;
        private Button btnWorkingDir;
        private Button btnFilename;
        private Button btnSelectScript;
        private LinkLabel lnkLblGWontheWeb;
        private LinkLabel lnkLabelRunBatch;
        private Label lblFilename;
        private Label lblWorkingDir;
        private Label lblGW;
        private Label lblBatchFile;
        private Label lblArguments;
        private TextBox txtGW;
        private TextBox txtArguments;
        private TextBox txtFilename;
        private TextBox txtWorkingDir;
        private TextBox txtBatchFile;
        private CheckBox chkSaveLog;
        private CheckBox chkExecuteScriptAutomatically;
        private TextBox txtFileList;
        private CheckBox chkBatchRunMinimized;
        private CheckBox chkBatchWaitForExit;
        private CheckBox chkBatchClearListAfterExecute;
        private CheckBox chkBatchClearAfterDragDrop;
        private CheckBox chkDisablex64Redirection;
        private Button btnBatchClearList;
        private Button btnBatchExecute;
        private CheckBox chkBatchExecuteScript;
    }
}

