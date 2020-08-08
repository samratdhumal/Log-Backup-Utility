// This is a part of DotNetRemoting Library
// Copyright (C) 2002-2008 Amplefile
// All rights reserved.
//
// This source code can be used, distributed or modified
// only under terms and conditions 
// of the accompanying license agreement.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HttpDownloaderDemo
{
    public partial class HttpFileDownloaderForm : GenericSaveForm.GenericSavForm
    {
        public HttpFileDownloaderForm()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (button_start.Text == "Start")
            {
                httpDownloader1.URLDownload = textBox_url.Text;
                httpDownloader1.SetLocalFolder( textBox_loc_folder.Text);
                httpDownloader1.Start();
                button_start.Text = "Abort";
            }
            else
            {
                httpDownloader1.Abort();
                button_start.Text = "Start";
            }
        }

        private void httpDownloader1_StatusUpdateEvent(string Message, DotNetRemoting.DStatus Status, long FullSize, long CurrentBytes, TimeSpan EstimatedTimeLeft, double Speed)
        {
            toolStripStatusLabel_stat.Text = Message;

            toolStripStatusLabel_time_left.Text = DotNetRemoting.BaseDownloader.TimeSpanToString(EstimatedTimeLeft);

            toolStripStatusLabel_speed.Text = Speed.ToString("F1") + " Kb/s";

            if (Status == DotNetRemoting.DStatus.complete || 
                Status == DotNetRemoting.DStatus.error || 
                Status == DotNetRemoting.DStatus.timeout )
            {
                button_start.Text = "Start";
            }
        }

        private void HttpFileDownloaderForm_Load(object sender, EventArgs e)
        {
            _DownloaderSettings = (DownloaderSettings)GetSettingsObject(typeof(DownloaderSettings));
            textBox_loc_folder.Text = _DownloaderSettings.LocalFolder;
            textBox_url.Text = _DownloaderSettings.URL;
        }

        DownloaderSettings _DownloaderSettings;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _DownloaderSettings.LocalFolder = textBox_loc_folder.Text;
            _DownloaderSettings.URL = textBox_url.Text;
            base.OnFormClosing(e);
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = _DownloaderSettings.LocalFolder;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                _DownloaderSettings.LocalFolder = folderBrowserDialog1.SelectedPath;
                textBox_loc_folder.Text = _DownloaderSettings.LocalFolder;
            }
        }
    }

    #region App settings container
    [Serializable]
    public class DownloaderSettings
    {
        public string URL = "http://dotnetremoting.com/Download/SerializationStudioSetup.exe";
        public string LocalFolder;
    }
    #endregion
}