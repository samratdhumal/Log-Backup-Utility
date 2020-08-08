using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace MainPage
{
    public partial class Logbackup : Form
    {
        //Declare delegate used to communicate with UI thread
        private delegate void UpdateStatusDelegate(string _s);
        private UpdateStatusDelegate updateStatusDelegate = null;
        //Worker Thread declaration
        //private Thread workerThread = null;
        BackgroundWorker bgWorker;
        //Singleton
       
        //Boolean flag used to stop process;
        //private bool stopProcess = false;
        private long iFileCntr, iSrcFoldrSize, icpyProgrss, itmpfldrsize;
        int ipctComplete;
        public enum BackupSchedulerType { Time, Daily, Weekly, Monthly };
        //public enum ChboxLableType {LableforOverwrite, LableforSchdlr };
        //For Application State transition
        private enum AppStatus { Idle, CopyingFile };
        public Logbackup()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            iFileCntr = 0;
            iSrcFoldrSize = 0;
            icpyProgrss = 0;
            //?? If Scheduled back up going on ?? get status
            SetAppState(AppStatus.Idle, null);
        }
       
        void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Just update progress bar with % complete
            pbProgress.Value = e.ProgressPercentage;
            lblProgress.Text = pbProgress.Value.ToString() + "%";
        }
        //Update UI file copy completed here..
        void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    MessageBox.Show(e.Error.Message, "Error during file copy");
                }
                else if (e.Cancelled)
                {
                    lbl_status.Text = "**Cancelled**";
                }
                else
                {
                    updateStatusDelegate("Files Copied Successfully!!!");// + "\nNumber of files copied: " + iFileCntr.ToString() + "\nSource directory total size: " + iSrcFoldrSize.ToString() + " kb\nDestination directory total size: " + iDestFoldrSize.ToString() + " kb");
                    //SetAppState(AppStatus.Idle, null);
                }
            }
            finally
            {
                SetAppState(AppStatus.Idle, null);
                //updateStatusDelegate("Status:");
            }
        }
        //Do file copy here..
        void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //BackgroundWorker bw = sender as BackgroundWorker;
            //CopyFolder(bw, tb_source.Text, tb_destn.Text, chbox_overwrt.Checked);
            CopyFolder(tb_source.Text, tb_destn.Text, chbox_overwrt.Checked);
            // If operation was cancelled (triggered by CancellationPending),
            // we bailed out of CopyFolder() early.  But still need to set
            // Cancel flag, because RunWorkerCompleted event will still fire.
            if (bgWorker.CancellationPending)
                e.Cancel = true;
        }
        /// <summary>
        /// Copy files and folders from source path to destination path
        /// </summary>
        /// <param name="sSrcFolder"></param>
        /// <param name="sDestFolder"></param>
        /// <param name="bOvrWrt"></param>
        //public void CopyFolder(BackgroundWorker bw, string sSrcFolder, string sDestFolder, bool bOvrWrt)
        public void CopyFolder(string sSrcFolder, string sDestFolder, bool bOvrWrt)
        {
            //if (bgWorker.CancellationPending == true)
            //{
            //    return;
            //}
            //else
            //{
            //bool bOvrWrtModifiedFile;
            int nLstModfdDateTime = 0;
            //if (!this.stopProcess)
            //{
            //destination folder doesn't exists; Create one
            if (!Directory.Exists(sDestFolder))
            {
                Directory.CreateDirectory(sDestFolder);
            }
            //Retrieve all files from sourceFolder
            string[] files = Directory.GetFiles(sSrcFolder);
            foreach (string file in files)
            {
                string dest1;
                try
                {
                    string sFlname = Path.GetFileName(file);
                    bOvrWrt = true;
                    if ((File.Exists(sDestFolder + @"\" + sFlname)) && chbox_overwrt.Checked != true)
                    {
                        bOvrWrt = false;
                    }
                    dest1 = Path.Combine(sDestFolder, Path.GetFileNameWithoutExtension(sFlname) + Path.GetExtension(file));
                    //when Overwrite is disabled copy modified files only
                    if (!bOvrWrt)
                    {
                        //find if Src file is modified since last backup
                        nLstModfdDateTime = DateTime.Compare(File.GetLastWriteTimeUtc(file), File.GetLastWriteTimeUtc(dest1));
                        if (nLstModfdDateTime > 0)
                            bOvrWrt = true;
                    }

                    //Overwrite files 
                    if (bgWorker.CancellationPending == true)
                    {
                        break;
                    }
                    else
                    {
                        if (bOvrWrt)
                            File.Copy(file, dest1, bOvrWrt);
                    }
                    //Calculate number of files, source folder and dest folder size
                    iFileCntr++;
                    //FileInfo flSrcInfo = new FileInfo(file);
                    //iSrcFoldrSize += flSrcInfo.Length;
                    FileInfo flDestInfo = new FileInfo(dest1);
                    icpyProgrss += flDestInfo.Length;

                    ipctComplete = (int)(((double)icpyProgrss / (double)iSrcFoldrSize) * 100);
                    bgWorker.ReportProgress(ipctComplete);
                    //Thread.Sleep(1);
                    updateStatusDelegate(sFlname.ToString());
                }
                catch (UnauthorizedAccessException erruacs)
                {
                    MessageBox.Show("File is not accessible : skiping file", "Unauthorised Acess");
                    //lgobj1.CreateLog(file, "Acess denied" + erruacs.Message.ToString() + "\tStatus Skipped");
                    continue;
                }
            }
            string[] folders = Directory.GetDirectories(sSrcFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(sDestFolder, name);
                //Recursive call to CopyFolder()
                //CopyFolder(bw, folder, dest, bOvrWrt);              // To Copy Folders in directory
                CopyFolder(folder, dest, bOvrWrt);              // To Copy Folders in directory
            }
            //updateStatusDelegate("Files Copied Successfully!!!" + "\nNumber of files copied: " + iFileCntr.ToString() + "\nSource directory total size: " + iSrcFoldrSize.ToString() + " kb\nDestination directory total size: " + iDestFoldrSize.ToString() + " kb");
            //this.workerThread.Abort();  
            //}
            //else
            //{
            //stop heavy operation
            //this.workerThread.Abort();
            //}
            // updateStatusDelegate("Files Copied Successfully!!!" + "\nNumber of files copied: " + iFileCntr.ToString() + "\nSource directory total size: " + iSrcFoldrSize.ToString() + " kb\nDestination directory total size: " + iDestFoldrSize.ToString() + " kb");
            //}
            //updateStatusDelegate(file.ToString());
        }

        //Get SourceFolderSize
        private long GetFolderSize(string _fldrpth)
        {
            if (!_fldrpth.Equals(string.Empty))
            {
                //Retrieve all files from sourceFolder
                string[] files = Directory.GetFiles(_fldrpth);
                foreach (string file in files)
                {
                    FileInfo flInfo = new FileInfo(file);
                    itmpfldrsize += flInfo.Length;
                }
                string[] folders = Directory.GetDirectories(_fldrpth);
                foreach (string folder in folders)
                {
                    string name = Path.GetFileName(folder);
                    //Recursive call to GetSourceFolderSize
                    GetFolderSize(folder);
                    //CopyFolder(bw, folder, dest, bOvrWrt);              // To Copy Folders in directory
                    //lgobj1.CreateLog(Path.GetFileName(dest), "Folder Copied Successfully"); //Write to text File
                }
            }
            return itmpfldrsize;
        }

        //Update UI
        private void UpdateStatus(string sTxtToDisplay)
        {
            if (this.lbl_status.InvokeRequired)
            {
                this.lbl_status.BeginInvoke((MethodInvoker)delegate() { lbl_status.Text = sTxtToDisplay; });
            }
            else
                lbl_status.Text = sTxtToDisplay;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialise status
            
        }

        //Lable update on Checkbox
        public void UpdatefCpySettngsOvrtLable()
        {
            //Update "FileOverwrite" Enable/disable lable
            if (chbox_overwrt.Checked)
                lbl_fcpysettingsOvrt.Text = "File overwrite for existing file: Enabled";
            else
                lbl_fcpysettingsOvrt.Text = "File overwrite for existing file: Disabled";
            //Update "Schedular" Enable/disable lable
           /* if (chbox_schedlbckup.Checked)
                lbl_fcpysettingsSchdlr.Text = "Scheduled back up: Enabled";
            else
                lbl_fcpysettingsSchdlr.Text = "Scheduled back up: Disabled";*/
        }

        //private void chbox_overwrt_CheckedChanged(object sender, EventArgs e)
        //{
        //    UpdatefCpySettngsOvrtLable();
        //}

        //Application state transition
        private void SetAppState(AppStatus newstate, string filename)
        {
            switch (newstate)
            {
                case AppStatus.Idle:
                    //Hide progress widgets
                    SetFileCopyWidgetsVisible(false);
                    btn_bckupnow.Enabled = true;
                    chbox_overwrt.Enabled = true;
                    break;
                case AppStatus.CopyingFile:
                    SetFileCopyWidgetsVisible(true);
                    lblProgress.Text = pbProgress.Value.ToString();//string.Format("Reading file: {0}", filename);
                    pbProgress.Value = 0;
                    btn_bckupnow.Enabled = false;
                    chbox_overwrt.Enabled = false;
                    break;
            }
        }

        private void SetFileCopyWidgetsVisible(bool visible)
        {
            lblProgress.Visible = visible;
            pbProgress.Visible = visible;
            btnCancelcpy.Visible = visible;
        }

        

        private void chbox_overwrt_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdatefCpySettngsOvrtLable();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Logbackup_Load(object sender, EventArgs e)
        {
            this.updateStatusDelegate = new UpdateStatusDelegate(this.UpdateStatus);
            UpdatefCpySettngsOvrtLable();
        }

        private void Logbackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin.l = null;
        }

        private void btn_source_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = foldrbrws_src.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //display selected folder path
                tb_source.Text = foldrbrws_src.SelectedPath;
            }
        }

        private void btn_destn_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = foldrbrws_dest.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //display selected folder path
                tb_destn.Text = foldrbrws_dest.SelectedPath;
            }
        }

        private void chbox_overwrt_CheckedChanged(object sender, EventArgs e)
        {
            UpdatefCpySettngsOvrtLable();
        }

        private void btn_bckupnow_Click_1(object sender, EventArgs e)
        {
            iFileCntr = 0;
            iSrcFoldrSize = 0;
            icpyProgrss = 0;
            this.Invalidate();
            SetAppState(AppStatus.CopyingFile, tb_source.Text);
            //lbl_status.Text = "Preparing to copy..";
            iSrcFoldrSize = GetFolderSize(tb_source.Text);
            try
            {
                if ((tb_source.Text != string.Empty) && (tb_destn.Text != string.Empty))
                {
                    //lbl_status.ForeColor = Color.Black;
                    //BackgroundWorker bgWorker;
                    bgWorker = new BackgroundWorker();
                    bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
                    bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
                    bgWorker.WorkerReportsProgress = true;
                    bgWorker.WorkerSupportsCancellation = true;
                    bgWorker.ProgressChanged += new ProgressChangedEventHandler(bgWorker_ProgressChanged);
                    bgWorker.RunWorkerAsync();
                    btn_bckupnow.Enabled = false;
                }
                else
                {
                    //lbl_status.ForeColor = Color.Red;
                    lbl_status.Text = "Please select valid Source Destination directory";
                    SetAppState(AppStatus.Idle, null);
                }
            }
            catch (UnauthorizedAccessException erracess)
            {
                MessageBox.Show(erracess.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.GetType().ToString(), "Error");
                SetAppState(AppStatus.Idle, null);
                throw;
            }
        }

        

        private void btnCancelcpy_Click_1(object sender, EventArgs e)
        {
            bgWorker.CancelAsync();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
