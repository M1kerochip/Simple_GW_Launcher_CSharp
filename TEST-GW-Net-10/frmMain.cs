using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TEST_GW
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
        private void button1_Click(object sender, EventArgs e)
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

            txtOutput.AppendText(Path.GetFileName(txtGW.Text) + " " + txtArguments.Text + " " + txtFilename.Text + Environment.NewLine);

            pProcess.OutputDataReceived += (s, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    // Update controls in UI thread
                    this.Invoke((System.Windows.Forms.MethodInvoker)delegate
                    {
                        txtOutput.AppendText(e.Data + Environment.NewLine);
                    });
                }
            };

            pProcess.ErrorDataReceived += (s, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    // Process error information
                    txtOutput.AppendText(e.Data + Environment.NewLine);
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
        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(txtWorkingDir.Text + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(txtFilename.Text) + ".log", txtOutput.Text);
        }

 //-===========================================================================================================================================================
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            pProcess.StartInfo.Arguments = "\"" + txtWorkingDir.Text + Path.DirectorySeparatorChar;
            pProcess.StartInfo.Arguments += txtFilename.Text + "\"";
            pProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(txtBatchFile.Text);
            pProcess.StartInfo.CreateNoWindow = false;

            pProcess.Start();

            // Wait for process completion
            // pProcess.WaitForExit();

            // pProcess.Close();
            // pProcess.Dispose();
        }

 //-===========================================================================================================================================================
        private void btnSelectScript_Click(object sender, EventArgs e)
        {
            if (Path.Exists(Path.GetDirectoryName(txtBatchFile.Text)))
            {
                openFileDialogScript.InitialDirectory = Path.GetDirectoryName(txtBatchFile.Text);
            }
            else
            {
                openFileDialogScript.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            }

            openFileDialogScript.Filter = "Batch Files (*.bat, *.cmd)|*.bat;*.cmd|All files (*.*)|*.*";
            openFileDialogScript.FilterIndex = 1;
            openFileDialogScript.RestoreDirectory = false;

            if (openFileDialogScript.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                txtBatchFile.Text = openFileDialogScript.FileName;
            }
        }

 //-===========================================================================================================================================================
        private void btnFilename_Click(object sender, EventArgs e)
        {
            openFileDialogFilename.Filter = "Flux Files (*.scp, *.raw)|*.scp;*.raw|All files (*.*)|*.*";
            openFileDialogFilename.FilterIndex = 1;
            openFileDialogFilename.RestoreDirectory = false;

            if (openFileDialogFilename.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                txtWorkingDir.Text = Path.GetDirectoryName(openFileDialogFilename.FileName);
                txtFilename.Text = Path.GetFileName(openFileDialogFilename.FileName);
            }
        }

 //-===========================================================================================================================================================
        private void btnGW_EXE_Click(object sender, EventArgs e)
        {
            if (Path.Exists(Path.GetDirectoryName(txtGW.Text)))
            {
                openFileDialogGW.InitialDirectory = Path.GetDirectoryName(txtGW.Text);
            }
            else
            {
                openFileDialogGW.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            }

            openFileDialogGW.Filter = "Program Files (*.exe)|*.exe|Batch Files (*.bat, *.cmd)|*.bat;*.cmd|All files (*.*)|*.*";
            openFileDialogGW.FilterIndex = 1;
            openFileDialogGW.RestoreDirectory = false;

            if (openFileDialogGW.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                txtGW.Text = openFileDialogGW.FileName;
            }
        }

//-===========================================================================================================================================================
        private void btnWorkingDir_Click(object sender, EventArgs e)
        {

            if (Path.Exists(Path.GetDirectoryName(txtWorkingDir.Text)))
            {
                folderBrowserDialog1.InitialDirectory = Path.GetDirectoryName(txtWorkingDir.Text);
            }
            else
            {
                folderBrowserDialog1.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            }

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtWorkingDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

 //-===========================================================================================================================================================
        private void lblArguments_DoubleClick_1(object sender, EventArgs e)
        {
            txtArguments.Text = "read --revs 5 --tracks c=0-83:h=0-1:step=1 --seek-retries=1 -n \"";
        }
        
 //-===========================================================================================================================================================
        private void lblFilename_Click(object sender, EventArgs e)
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
                openFileDialogGW.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                openFileDialogFilename.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                openFileDialogScript.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);


                jSON_Settings = Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + 
                                Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".json";

                if (Path.Exists(jSON_Settings))
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
                }
            }
            finally { }
            ;

            try
            {
                cnMnuSt.Items.Clear();
                
                string JSON_Arguments_Path = Path.GetDirectoryName(Application.ExecutablePath) + 
                                            Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(Application.ExecutablePath) + 
                                            ".Arguments.json";
                
                if (Path.Exists(JSON_Arguments_Path))                       // If the JSON file exists
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

                var options = new JsonSerializerOptions { WriteIndented = true };

                string json = JsonSerializer.Serialize(MySettings, options);

                File.WriteAllText(jSON_Settings, json);
            }
            finally { }
            ;
        }

 //-===========================================================================================================================================================
        private void cnMnuSt_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            txtArguments.Text = (String)e.ClickedItem.Tag;  // Retrieve the actual arguments from the menu where we'd previously stored it as a string
        }
    }
}
