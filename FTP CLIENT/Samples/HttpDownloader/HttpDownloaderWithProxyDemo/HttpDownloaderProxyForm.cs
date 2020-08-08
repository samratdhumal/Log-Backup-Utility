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
                if (radioButton_proxy.Checked)
                {
                    httpDownloader1.ProxyToUse = DotNetRemoting.UseProxy.UseProxy;
                    httpDownloader1.SetProxyInfo(
                        textBox_proxy_uri.Text,
                        textBox_user_name.Text,
                        textBox_password.Text,
                        textBox_domain.Text);
                }

                if (radioButton_default_proxy.Checked)
                {
                    httpDownloader1.ProxyToUse = DotNetRemoting.UseProxy.UseDefaultProxy;
                }

                if (radioButton_no_proxy.Checked)
                {
                    httpDownloader1.ProxyToUse = DotNetRemoting.UseProxy.NotProxy;
                }

                httpDownloader1.URLDownload = textBox_url.Text;
                httpDownloader1.SetLocalFolder(textBox_loc_folder.Text);
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
            toolStripStatusLabel_Speed.Text = Speed.ToString("F1") + " Kb/s";

            if (Status == DotNetRemoting.DStatus.complete ||
                Status == DotNetRemoting.DStatus.error ||
                Status == DotNetRemoting.DStatus.timeout)
            {
                button_start.Text = "Start";
            }
        }

        private void HttpFileDownloaderForm_Load(object sender, EventArgs e)
        {
            _DownloaderSettings = (DownloaderSettings)GetSettingsObject(typeof(DownloaderSettings));
            textBox_loc_folder.Text = _DownloaderSettings.LocalFolder;
            textBox_url.Text = _DownloaderSettings.URL;

            textBox_proxy_uri.Text = _DownloaderSettings.proxy_uri;
            textBox_domain.Text = _DownloaderSettings.domain;
            textBox_user_name.Text = _DownloaderSettings.user_name;
            textBox_password.Text = _DownloaderSettings.password;
        }

        DownloaderSettings _DownloaderSettings;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _DownloaderSettings.LocalFolder = textBox_loc_folder.Text;
            _DownloaderSettings.URL = textBox_url.Text;
            _DownloaderSettings.proxy_uri = textBox_proxy_uri.Text;
            _DownloaderSettings.domain = textBox_domain.Text;
            _DownloaderSettings.user_name = textBox_user_name.Text;
            _DownloaderSettings.password = textBox_password.Text;

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

        private void radioButton_proxy_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_proxy.Enabled = radioButton_proxy.Checked;
        }

        private void radioButton_default_proxy_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_proxy.Enabled = radioButton_proxy.Checked;
        }

        private void radioButton_no_proxy_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_proxy.Enabled = radioButton_proxy.Checked;
        }
    }

    #region App settings container
    [Serializable]
    public class DownloaderSettings
    {
        public string URL = "http://dotnetremoting.com/Download/SerializationStudioSetup.exe";
        public string LocalFolder;
        public string proxy_uri;
        public string user_name;
        public string password;
        public string domain;
    }
    #endregion
}