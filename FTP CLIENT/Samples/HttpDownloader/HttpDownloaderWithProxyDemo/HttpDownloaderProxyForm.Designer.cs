namespace HttpDownloaderDemo
{
    partial class HttpFileDownloaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HttpFileDownloaderForm));
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_progress = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_stat = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_time_left = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.httpDownloader1 = new DotNetRemoting.HttpDownloaderCtl();
            this.textBox_loc_folder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_browse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox_proxy = new System.Windows.Forms.GroupBox();
            this.textBox_proxy_uri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_domain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_user_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_proxy = new System.Windows.Forms.RadioButton();
            this.radioButton_default_proxy = new System.Windows.Forms.RadioButton();
            this.radioButton_no_proxy = new System.Windows.Forms.RadioButton();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Speed = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.groupBox_proxy.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.Location = new System.Drawing.Point(340, 239);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox_url
            // 
            this.textBox_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_url.Location = new System.Drawing.Point(92, 163);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(323, 20);
            this.textBox_url.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(9, 277);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(403, 13);
            this.progressBar1.TabIndex = 3;
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.Location = new System.Drawing.Point(100, 249);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(33, 13);
            this.label_progress.TabIndex = 4;
            this.label_progress.Text = "None";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_stat,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_time_left,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel_Speed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(421, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Status : ";
            // 
            // toolStripStatusLabel_stat
            // 
            this.toolStripStatusLabel_stat.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel_stat.Name = "toolStripStatusLabel_stat";
            this.toolStripStatusLabel_stat.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel_stat.Text = "ready";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel2.Text = "Time left :";
            // 
            // toolStripStatusLabel_time_left
            // 
            this.toolStripStatusLabel_time_left.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel_time_left.Name = "toolStripStatusLabel_time_left";
            this.toolStripStatusLabel_time_left.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel_time_left.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL";
            // 
            // httpDownloader1
            // 
            this.httpDownloader1.BackColor = System.Drawing.SystemColors.Info;
            this.httpDownloader1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.httpDownloader1.FtpToolStripProgressBar = null;
            this.httpDownloader1.Location = new System.Drawing.Point(188, 176);
            this.httpDownloader1.Name = "httpDownloader1";
            this.httpDownloader1.ProgrBar = this.progressBar1;
            this.httpDownloader1.ProgressLabel = this.label_progress;
            this.httpDownloader1.ProxyToUse = DotNetRemoting.UseProxy.NotProxy;
            this.httpDownloader1.Size = new System.Drawing.Size(116, 32);
            this.httpDownloader1.TabIndex = 0;
            this.httpDownloader1.TimeOut = 5000;
            this.httpDownloader1.URLDownload = null;
            this.httpDownloader1.Visible = false;
            this.httpDownloader1.StatusUpdateEvent += new DotNetRemoting.UpdateDelegate(this.httpDownloader1_StatusUpdateEvent);
            // 
            // textBox_loc_folder
            // 
            this.textBox_loc_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_loc_folder.Location = new System.Drawing.Point(92, 204);
            this.textBox_loc_folder.Name = "textBox_loc_folder";
            this.textBox_loc_folder.Size = new System.Drawing.Size(275, 20);
            this.textBox_loc_folder.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Local Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Downloading";
            // 
            // button_browse
            // 
            this.button_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_browse.Location = new System.Drawing.Point(377, 202);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(38, 23);
            this.button_browse.TabIndex = 10;
            this.button_browse.Text = "...";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // groupBox_proxy
            // 
            this.groupBox_proxy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_proxy.Controls.Add(this.textBox_proxy_uri);
            this.groupBox_proxy.Controls.Add(this.label6);
            this.groupBox_proxy.Controls.Add(this.textBox_domain);
            this.groupBox_proxy.Controls.Add(this.label5);
            this.groupBox_proxy.Controls.Add(this.textBox_password);
            this.groupBox_proxy.Controls.Add(this.label4);
            this.groupBox_proxy.Controls.Add(this.textBox_user_name);
            this.groupBox_proxy.Controls.Add(this.label7);
            this.groupBox_proxy.Enabled = false;
            this.groupBox_proxy.Location = new System.Drawing.Point(169, 12);
            this.groupBox_proxy.Name = "groupBox_proxy";
            this.groupBox_proxy.Size = new System.Drawing.Size(244, 136);
            this.groupBox_proxy.TabIndex = 11;
            this.groupBox_proxy.TabStop = false;
            this.groupBox_proxy.Text = "Proxy";
            // 
            // textBox_proxy_uri
            // 
            this.textBox_proxy_uri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_proxy_uri.Location = new System.Drawing.Point(120, 24);
            this.textBox_proxy_uri.Name = "textBox_proxy_uri";
            this.textBox_proxy_uri.Size = new System.Drawing.Size(110, 20);
            this.textBox_proxy_uri.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(24, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "ProxyUri";
            // 
            // textBox_domain
            // 
            this.textBox_domain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_domain.Location = new System.Drawing.Point(120, 96);
            this.textBox_domain.Name = "textBox_domain";
            this.textBox_domain.Size = new System.Drawing.Size(110, 20);
            this.textBox_domain.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Domain";
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_password.Location = new System.Drawing.Point(120, 72);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(110, 20);
            this.textBox_password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // textBox_user_name
            // 
            this.textBox_user_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_user_name.Location = new System.Drawing.Point(120, 48);
            this.textBox_user_name.Name = "textBox_user_name";
            this.textBox_user_name.Size = new System.Drawing.Size(110, 20);
            this.textBox_user_name.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(24, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "User Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_proxy);
            this.groupBox1.Controls.Add(this.radioButton_default_proxy);
            this.groupBox1.Controls.Add(this.radioButton_no_proxy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 136);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_proxy
            // 
            this.radioButton_proxy.Location = new System.Drawing.Point(24, 72);
            this.radioButton_proxy.Name = "radioButton_proxy";
            this.radioButton_proxy.Size = new System.Drawing.Size(96, 16);
            this.radioButton_proxy.TabIndex = 2;
            this.radioButton_proxy.Text = "Proxy";
            this.radioButton_proxy.CheckedChanged += new System.EventHandler(this.radioButton_proxy_CheckedChanged);
            // 
            // radioButton_default_proxy
            // 
            this.radioButton_default_proxy.Location = new System.Drawing.Point(24, 48);
            this.radioButton_default_proxy.Name = "radioButton_default_proxy";
            this.radioButton_default_proxy.Size = new System.Drawing.Size(96, 16);
            this.radioButton_default_proxy.TabIndex = 1;
            this.radioButton_default_proxy.Text = "Default Proxy";
            this.radioButton_default_proxy.CheckedChanged += new System.EventHandler(this.radioButton_default_proxy_CheckedChanged);
            // 
            // radioButton_no_proxy
            // 
            this.radioButton_no_proxy.Checked = true;
            this.radioButton_no_proxy.Location = new System.Drawing.Point(24, 24);
            this.radioButton_no_proxy.Name = "radioButton_no_proxy";
            this.radioButton_no_proxy.Size = new System.Drawing.Size(96, 16);
            this.radioButton_no_proxy.TabIndex = 0;
            this.radioButton_no_proxy.TabStop = true;
            this.radioButton_no_proxy.Text = "No proxy";
            this.radioButton_no_proxy.CheckedChanged += new System.EventHandler(this.radioButton_no_proxy_CheckedChanged);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel3.Text = "Speed : ";
            // 
            // toolStripStatusLabel_Speed
            // 
            this.toolStripStatusLabel_Speed.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel_Speed.Name = "toolStripStatusLabel_Speed";
            this.toolStripStatusLabel_Speed.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel_Speed.Text = "0.0";
            // 
            // HttpFileDownloaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 322);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_proxy);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_loc_folder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label_progress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.httpDownloader1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 356);
            this.MinimumSize = new System.Drawing.Size(429, 356);
            this.Name = "HttpFileDownloaderForm";
            this.Text = "Http Downloader With Proxy";
            this.Load += new System.EventHandler(this.HttpFileDownloaderForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_proxy.ResumeLayout(false);
            this.groupBox_proxy.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotNetRemoting.HttpDownloaderCtl httpDownloader1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_progress;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_stat;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_time_left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_loc_folder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox_proxy;
        private System.Windows.Forms.TextBox textBox_proxy_uri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_domain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_user_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_proxy;
        private System.Windows.Forms.RadioButton radioButton_default_proxy;
        private System.Windows.Forms.RadioButton radioButton_no_proxy;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Speed;
    }
}

