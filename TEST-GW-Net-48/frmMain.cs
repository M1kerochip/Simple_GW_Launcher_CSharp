using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST_GW;

namespace TEST_GW__Net4
{
    public partial class frmMain : Form
    {
//-===========================================================================================================================================================
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// String to hold the filename of the .json settings file. File is named <Path_to_exe + program_name_less_extension + .json
        /// </summary>
        private string jSON_Settings;

//-===========================================================================================================================================================
        private void btnExecute_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            // Start the child process.
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            // Redirect the output stream of the child process.
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.RedirectStandardError = true;
            pProcess.StartInfo.FileName = txtGW.Text;
            if (txtWorkingDir.Text == "")
            {
                txtWorkingDir.Text = Path.GetDirectoryName(txtGW.Text);
            }

            string fullargs = txtArguments.Text;

            string filenameArg = txtWorkingDir.Text + Path.DirectorySeparatorChar + txtFilename.Text;

            if (fullargs.Contains("%FILENAME") || fullargs.Contains("%NOEXTFILENAME"))
            {
                if (fullargs.Contains("%FILENAME"))
                {
                    fullargs.Replace("%FILENAME", filenameArg);
                }
                if (fullargs.Contains("%NOEXTFILENAME"))
                {
                    fullargs.Replace("%NOEXTFILENAME", txtWorkingDir.Text + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(txtFilename.Text));
                }
            }
            else
            {
                fullargs += txtWorkingDir.Text + Path.DirectorySeparatorChar + txtFilename.Text;
            }

            pProcess.StartInfo.Arguments = fullargs;
            pProcess.StartInfo.WorkingDirectory = txtWorkingDir.Text;
            pProcess.StartInfo.CreateNoWindow = true;

            txtOutput.AppendText(fullargs + Environment.NewLine);

            pProcess.OutputDataReceived += (s, er) =>
            {
                if (!string.IsNullOrEmpty(er.Data))
                {
                    // Update controls in UI thread
                    this.Invoke((MethodInvoker)delegate
                    {
                        txtOutput.AppendText(er.Data + Environment.NewLine);
                    });
                }
            };

            pProcess.ErrorDataReceived += (s, er) =>
            {
                if (!string.IsNullOrEmpty(er.Data))
                {
                    // Process error information
                    txtOutput.AppendText(er.Data + Environment.NewLine);
                }
            };

            pProcess.Start();
            // Configure asynchronous reading
            pProcess.BeginOutputReadLine();
            pProcess.BeginErrorReadLine();

            // Wait for process completion
            pProcess.WaitForExit();

            pProcess.Close();
            pProcess.Dispose();

            if (chkSaveLog.Checked)
            {
                File.WriteAllText(txtWorkingDir.Text + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(txtFilename.Text) + ".log", txtOutput.Text);
            }
        }

//-===========================================================================================================================================================
        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            File.WriteAllText(txtWorkingDir.Text + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(txtFilename.Text) + ".log", txtOutput.Text);
        }

//-===========================================================================================================================================================
        private void lnkLblGWontheWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/keirf/greaseweazle/wiki");
        }

//-===========================================================================================================================================================
        private void lnkLabelRunBatch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Start the child process.
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            // Redirect the output stream of the child process.
            pProcess.StartInfo.UseShellExecute = true;
            pProcess.StartInfo.RedirectStandardOutput = false;
            pProcess.StartInfo.RedirectStandardError = false;
            pProcess.StartInfo.FileName = txtBatchFile.Text;
            if (txtWorkingDir.Text == "")
            {
                txtWorkingDir.Text = Path.GetDirectoryName(txtGW.Text);
            }
            pProcess.StartInfo.Arguments = txtWorkingDir.Text + Path.DirectorySeparatorChar;
            pProcess.StartInfo.Arguments += txtFilename.Text;
            pProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(txtBatchFile.Text);
            pProcess.StartInfo.CreateNoWindow = false;

            pProcess.Start();

            // Wait for process completion
            //pProcess.WaitForExit();

            //pProcess.Close();
            //pProcess.Dispose();
        }

//-===========================================================================================================================================================
        private void btnSelectScript_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                try
                {
                    if (System.IO.Directory.Exists(Path.GetDirectoryName(txtBatchFile.Text)))
                    {
                        openFileDialog.InitialDirectory = Path.GetDirectoryName(txtBatchFile.Text);
                    }
                    else
                    {
                        openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                    }
                }
                catch
                {
                    openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                }

                openFileDialog.Filter = "Batch Files (*.bat, *.cmd)|*.bat;*.cmd|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtBatchFile.Text = openFileDialog.FileName;
                }
            }
        }

//-===========================================================================================================================================================
        private void btnFilename_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                try
                {
                    if (System.IO.Directory.Exists(Path.GetDirectoryName(txtWorkingDir.Text)))
                    {
                        openFileDialog.InitialDirectory = Path.GetDirectoryName(txtWorkingDir.Text);
                    }
                    else
                    {
                        openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                    }
                }
                catch
                {
                    openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                }

                
                openFileDialog.Filter = "Flux Files (*.scp, *.raw)|*.scp;*.raw|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtWorkingDir.Text = Path.GetDirectoryName(openFileDialog.FileName);
                    txtFilename.Text = Path.GetFileName(openFileDialog.FileName);
                }
            }
        }

//-===========================================================================================================================================================
        private void btnGW_EXE_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                try
                {
                    if (System.IO.Directory.Exists(Path.GetDirectoryName(txtGW.Text)))
                    {
                        openFileDialog.InitialDirectory = Path.GetDirectoryName(txtGW.Text);
                    }
                    else
                    {
                        openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                    }
                }
                catch
                {
                    openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                }

                openFileDialog.Filter = "Program Files (*.exe)|*.exe|Batch Files (*.bat, *.cmd)|*.bat;*.cmd|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtGW.Text = openFileDialog.FileName;
                }
            }
        }

//-===========================================================================================================================================================
        private void btnWorkingDir_Click(object sender, EventArgs e)
        {
            try
            {

                if (System.IO.Directory.Exists(Path.GetDirectoryName(txtWorkingDir.Text)))
                {
                    folderBrDlgWorkingDir.SelectedPath = Path.GetDirectoryName(txtWorkingDir.Text);
                }
                else
                {
                    folderBrDlgWorkingDir.SelectedPath = Path.GetDirectoryName(Application.ExecutablePath);
                }
            }
            catch
            {
                folderBrDlgWorkingDir.SelectedPath = Path.GetDirectoryName(Application.ExecutablePath);
            }

            if (folderBrDlgWorkingDir.ShowDialog() == DialogResult.OK)
            {
                txtWorkingDir.Text = folderBrDlgWorkingDir.SelectedPath;
            }
        }

//-===========================================================================================================================================================
        private void lblArguments_DoubleClick(object sender, EventArgs e)
        {
            txtArguments.Text = "read --revs 5 --tracks c=0-83:h=0-1:step=1 --seek-retries=1 -n \"";
        }

//-===========================================================================================================================================================
        private void lblFilename_DoubleClick(object sender, EventArgs e)
        {
            txtFilename.Text += "::disktype=0x04";
        }

//-===========================================================================================================================================================
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Greaseweazle Launcher v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            GWSettingsClass MySettings = new GWSettingsClass();

            try
            {
                jSON_Settings = Path.GetDirectoryName(Application.ExecutablePath) + 
                                Path.DirectorySeparatorChar + 
                                Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".json";
                
                if (System.IO.File.Exists(jSON_Settings))
                {
                    // Read the data back from the JSON file
                    string json = File.ReadAllText(jSON_Settings);
                    MySettings = JsonSerializer.Deserialize<GWSettingsClass>(json);

                    txtGW.Text = MySettings.GW_EXE;
                    txtArguments.Text = MySettings.GW_Arguments;
                    txtWorkingDir.Text = MySettings.Working_Folder;
                    txtFilename.Text = MySettings.File_Name;
                    txtBatchFile.Text = MySettings.Script_To_Run;
                    chkExecuteScriptAutomatically.Checked = MySettings.Execute_Script;
                    chkSaveLog.Checked = MySettings.Save_Log;
                    
                    btnBatch.Visible = MySettings.HideBatch;
                    chkDisablex64Redirection.Checked = MySettings.batch_Disablex64FileRedirection;
                    chkBatchClearAfterDragDrop.Checked = MySettings.batch_ClearListOnDragDrop;
                    chkBatchWaitForExit.Checked = MySettings.batch_WaitForExit;
                    chkBatchClearListAfterExecute.CheckState = (CheckState)MySettings.batch_ClearListAfterExecute;
                    chkBatchRunMinimized.CheckState = (CheckState)MySettings.batch_RunMinimized;
                    chkBatchExecuteScript.Checked = MySettings.batch_ExecuteScript;
                }
            }
            finally { }
            ;

            try
            {
                cnMnuSt.Items.Clear();

                string JSON_Arguments_Path = Path.GetDirectoryName(Application.ExecutablePath) +
                                             Path.DirectorySeparatorChar + 
                                             Path.GetFileNameWithoutExtension(Application.ExecutablePath) +
                                             ".Arguments.json";

                if (System.IO.File.Exists(JSON_Arguments_Path))             // If the JSON file exists
                {
                    string json = File.ReadAllText(JSON_Arguments_Path);    // Read the entire JSON into a string;                            

                    List<GWArguments> Args = JsonSerializer.Deserialize<List<GWArguments>>(json);   // Deserialise the class GWArguments into a list,
                                                                                                    // and store the result into a new list of that (same) class, Args

                    int x = 0;                                      // Starts a new item counter, at zero
                    foreach (var arg in Args)                       // For each argument set found in json...
                    {
                        cnMnuSt.Items.Add(arg.ArgumentName);        // Add a new menu item, and give it the name of argument set, from json
                        cnMnuSt.Items[x].Tag = arg.ArgumentValue;   // Sets the tag for that menu item to the actual argument string of the argument set, from json
                        x++;                                        // Move the item counter on
                    }

                }
            }
            finally { }
            ;

            //2026-04-14: added support for a 2 panel splitpanel control. (For multiple batch items)
            splitContainer1.Panel2Collapsed = true;
            this.Size = new Size(603, this.Size.Height);
        }

//-===========================================================================================================================================================
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                GWSettingsClass MySettings = new GWSettingsClass();

                MySettings.GW_EXE = txtGW.Text;
                MySettings.GW_Arguments = txtArguments.Text;
                MySettings.Working_Folder = txtWorkingDir.Text;
                MySettings.File_Name = txtFilename.Text;
                MySettings.Script_To_Run = txtBatchFile.Text;
                MySettings.Execute_Script = chkExecuteScriptAutomatically.Checked;
                MySettings.Save_Log = chkSaveLog.Checked;

                MySettings.HideBatch = btnBatch.Visible;
                MySettings.batch_Disablex64FileRedirection = chkDisablex64Redirection.Checked;
                MySettings.batch_ClearListOnDragDrop = chkBatchClearAfterDragDrop.Checked;
                MySettings.batch_WaitForExit = chkBatchWaitForExit.Checked;
                MySettings.batch_ClearListAfterExecute = (int)chkBatchClearListAfterExecute.CheckState;
                MySettings.batch_RunMinimized = (int)chkBatchRunMinimized.CheckState;
                MySettings.batch_ExecuteScript = chkBatchExecuteScript.Checked;

                var options = new JsonSerializerOptions { WriteIndented = true };

                string json = JsonSerializer.Serialize(MySettings, options);

                File.WriteAllText(jSON_Settings, json);
            }
            finally
            { }
            ;
        }

//-===========================================================================================================================================================
        private void cnMnuSt_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            txtArguments.Text = (String)e.ClickedItem.Tag;  // Retrieve the actual arguments from the menu where we'd previously stored it as a string
        }

//-===========================================================================================================================================================
        private void btnBatch_Click(object sender, EventArgs e)
        {
            //txtGW.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //txtArguments.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //txtBatchFile.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //txtFilename.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //txtOutput.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //txtWorkingDir.Anchor = AnchorStyles.Left | AnchorStyles.Top;

            //btnGW_EXE.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //btnBatch.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //btnWorkingDir.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //btnFilename.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //btnSelectScript.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //btnBatch.Anchor = AnchorStyles.Left | AnchorStyles.Top;

            //lnkLabelRunBatch.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //lnkLblGWontheWeb.Anchor = AnchorStyles.Left | AnchorStyles.Top;

            //chkExecuteScriptAutomatically.Anchor = AnchorStyles.Left | AnchorStyles.Top;

            //            txtFileList.Anchor = AnchorStyles.Left | AnchorStyles.Top;

            //this.Size = new Size(this.Size.Width + 600,this.Size.Height);

            //txtGW.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //txtArguments.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //txtBatchFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //txtFilename.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            //txtWorkingDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            //btnGW_EXE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            //btnBatch.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            //btnWorkingDir.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            //btnFilename.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            //btnSelectScript.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            //btnBatch.Anchor = AnchorStyles.Right | AnchorStyles.Top;

            //lnkLabelRunBatch.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            //lnkLblGWontheWeb.Anchor = AnchorStyles.Right | AnchorStyles.Top;

            //chkExecuteScriptAutomatically.Anchor = AnchorStyles.Right | AnchorStyles.Top;

            //txtFileList.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;

            if (splitContainer1.Panel2Collapsed == true)
            {
                this.Size = new Size(this.Size.Width *2, this.Size.Height);
                splitContainer1.Panel2Collapsed = false;
            }
            else
            {
                this.Size = new Size(this.Size.Width /2, this.Size.Height);
                splitContainer1.Panel2Collapsed = true;
            }
        }

        //-===========================================================================================================================================================
        private void btnBatchClearList_Click(object sender, EventArgs e)
        {
            txtFileList.Clear();
        }

        //-===========================================================================================================================================================
        private void btnBatchExecute_Click(object sender, EventArgs e)
        {
            if (txtFileList.Lines.Length > 0)
            {

            }
        }
    }
}
