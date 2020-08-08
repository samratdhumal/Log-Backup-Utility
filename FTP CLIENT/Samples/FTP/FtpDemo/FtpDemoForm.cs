// This is a part of DotNetRemoting Library
// Copyright (C) 2002-2008 Amplefile
// All rights reserved.
//
// This source code can be used, distributed or modified
// only under terms and conditions 
// of the accompanying license agreement.

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DotNetRemoting;
using EnterpriseDT.Net.Ftp;
using System.IO;

namespace FtpDemo
{
    public partial class FtpDemoForm : GenericSaveForm.GenericSavForm
    {
        FtpSettings _FtpSettings;

        public FtpDemoForm()
        {
            InitializeComponent();

            listView_data.ListViewItemSorter = new ItemComparer();

            ManageButtons(null);
        }

        private void SetCredentials()
        {
            if (!ftpCtl1.IsConnected)
            {
                ftpCtl1.RemoteHost = textBox_serv_ip.Text;
                int Port = int.Parse(textBox_port.Text);
                ftpCtl1.ControlPort = Port;
                ftpCtl1.Connect();

                if (ftpCtl1.IsConnected)
                {
                    ftpCtl1.Login(textBox_user_id.Text, textBox_password.Text);

                    if (checkBox_bin.Checked)
                        ftpCtl1.SetTransferType(FTPTransferType.BINARY);
                    else
                        ftpCtl1.SetTransferType(FTPTransferType.ASCII);

                    if (checkBox_Passive.Checked)
                        ftpCtl1.SetConnectMode(FTPConnectMode.PASV);
                    else
                        ftpCtl1.SetConnectMode(FTPConnectMode.ACTIVE);
                }
                else
                {
                    label_mess.Text = "Not Connected";
                }
            }
        }

        private void button_flist_Click(object sender, EventArgs e)
        {
            ManageButtons(null);
            SetCredentials();
            string[] Flist = ftpCtl1.Dir();
            listView_data.Items.Clear();

            if (Flist == null)
                return;

            foreach (string DItem in Flist)
            {
                ListViewItem lvi = new ListViewItem(DItem, 0);
                lvi.Tag = DItem;
                listView_data.Items.Add(lvi);
            }
        }

        private void button_details_Click(object sender, EventArgs e)
        {
            ManageButtons(null);
            SetCredentials();
            FTPFile[] Flist = ftpCtl1.GetDetails();
            listView_data.Items.Clear();
            if (Flist == null)
                return;

            foreach (FTPFile DItem in Flist)
            {
                ListViewItem lvi = new ListViewItem(DItem.Name, 0);
                lvi.Tag = DItem;

                if (DItem.Dir)
                {
                    lvi.ImageIndex = 1;
                }
                else
                {
                    lvi.SubItems.Add(DItem.Size.ToString());
                }
                listView_data.Items.Add(lvi);
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (listView_data.SelectedIndices.Count == 0)
                return;

            ListViewItem lvi = listView_data.SelectedItems[0];

            FTPFile DItem = (FTPFile)lvi.Tag;

            if (DItem.Dir)
            {
                ftpCtl1.RmDir(DItem.Name);
            }
            else
            {
                ftpCtl1.Delete(DItem.Name);
            }

            button_details_Click(null, null);
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            if (button_upload.Text == "Upload")
            {
                SetCredentials();
                string RemoteFile = Path.GetFileName(textBox_loc_file.Text);
                ftpCtl1.Put(textBox_loc_file.Text, RemoteFile);
                button_upload.Text = "Abort";
            }
            else
            {
                ftpCtl1.CancelTransfer();
                button_upload.Text = "Upload";
            }
        }

        private void button_dnld_Click(object sender, EventArgs e)
        {
            if (listView_data.SelectedIndices.Count == 0)
                return;

            if (_FtpSettings.LocalFolder == null)
            {
                MessageBox.Show("Local folder not set");
                return;
            }

            if (button_dnld.Text == "Download")
            {
                ListViewItem lvi = listView_data.SelectedItems[0];
                FTPFile DItem = (FTPFile)lvi.Tag;
                if (DItem.Dir)
                    return;
                SetCredentials();
                ftpCtl1.Download(_FtpSettings.LocalFolder, DItem.Name);
                button_dnld.Text = "Abort";
            }
            else
            {
                ftpCtl1.CancelTransfer();
                button_dnld.Text = "Download";
            }
        }

        private void button_mk_dir_Click(object sender, EventArgs e)
        {
            MkDirForm md = new MkDirForm();

            if (md.ShowDialog() == DialogResult.OK)
            {
                SetCredentials();
                ftpCtl1.MkDir(md.DirName);
                button_details_Click(null, null);
            }
        }

        private void ftpCtl1_StatusUpdateEvent(string Message, DotNetRemoting.DStatus Status, long FullSize, long CurrentBytes, TimeSpan EstimatedTimeLeft, double Speed)
        {
            toolStripStatusLabel_stat.Text = Status.ToString();
            label_mess.Text = Message;
            toolStripStatusLabel_time.Text = BaseDownloader.TimeSpanToString(EstimatedTimeLeft);
            toolStripStatusLabel_speed.Text = Speed.ToString("F1") + " Kb/s";

            if (Status == DStatus.complete || Status == DStatus.error)
            {
                button_upload.Text = "Upload";
                button_dnld.Text = "Download";
            }
        }

        #region AppSettings

        private void ManageButtons(ListViewItem lvi)
        {
            if (lvi == null)
            {
                button_del.Enabled = false;
                button_dnld.Enabled = false;
                return;
            }
            FTPFile DItem = lvi.Tag as FTPFile;
            button_del.Enabled = true;
            button_mk_dir.Enabled = true;
            button_upload.Enabled = true;

            if (DItem == null)
            {
                button_del.Enabled = false;
                return;
            }
            button_dnld.Enabled = !DItem.Dir;
        }

        private void FtpDemoForm_Load(object sender, EventArgs e)
        {
            _FtpSettings = (FtpSettings)GetSettingsObject(typeof(FtpSettings));
            ApplySettings();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveSettins();
            base.OnFormClosing(e);
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = _FtpSettings.LocalFolder;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                _FtpSettings.LocalFolder = folderBrowserDialog1.SelectedPath;
                textBox_local_folder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ApplySettings()
        {
            textBox_serv_ip.Text = _FtpSettings.ServerIP;
            textBox_user_id.Text = _FtpSettings.UserID;
            textBox_port.Text = _FtpSettings.Port.ToString();
            textBox_local_folder.Text = _FtpSettings.LocalFolder;
            textBox_password.Text = _FtpSettings.Password;
            checkBox_bin.Checked = _FtpSettings.Binary;
            checkBox_Passive.Checked = _FtpSettings.Passive;
            textBox_loc_file.Text = _FtpSettings.LocalFile;
        }

        private void SaveSettins()
        {
            _FtpSettings.ServerIP = textBox_serv_ip.Text;
            _FtpSettings.UserID = textBox_user_id.Text;
            _FtpSettings.Port = int.Parse(textBox_port.Text);
            _FtpSettings.LocalFolder = textBox_local_folder.Text;
            _FtpSettings.Password = textBox_password.Text;
            _FtpSettings.Binary = checkBox_bin.Checked;
            _FtpSettings.Passive = checkBox_Passive.Checked;
            _FtpSettings.LocalFile = textBox_loc_file.Text;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox_loc_file.Text = openFileDialog1.FileName;
            _FtpSettings.LocalFile = textBox_loc_file.Text;
        }

        private void button_file_browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = _FtpSettings.LocalFile;
            openFileDialog1.ShowDialog();
        }

        #endregion

        private void listView_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lvi = null;

            if (listView_data.SelectedIndices.Count > 0)
            {
                lvi = listView_data.SelectedItems[0];
            }

            ManageButtons(lvi);
        }
    }

    #region App settings container
    [Serializable]
    public class FtpSettings
    {
        public string ServerIP;
        public string LocalFolder;
        public int Port = 21;
        public bool Binary = true;
        public bool Passive;
        public string UserID;
        public string Password;
        public string LocalFile;
    }

    public class ItemComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            ListViewItem lvi1 = (ListViewItem)x;
            ListViewItem lvi2 = (ListViewItem)y;

            if (lvi2.ImageIndex > lvi1.ImageIndex)
                return 1;
            else
                return 0;
        }
    }

    #endregion

}