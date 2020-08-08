namespace MainPage
{
    partial class Logbackup
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
            this.chbox_overwrt = new System.Windows.Forms.CheckBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_bckupnow = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_source = new System.Windows.Forms.Button();
            this.tb_destn = new System.Windows.Forms.TextBox();
            this.tb_source = new System.Windows.Forms.TextBox();
            this.btn_destn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.foldrbrws_dest = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCancelcpy = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.foldrbrws_src = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_fcpysettingsSchdlr = new System.Windows.Forms.Label();
            this.lbl_fcpysettingsOvrt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbox_overwrt
            // 
            this.chbox_overwrt.AutoSize = true;
            this.chbox_overwrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbox_overwrt.Location = new System.Drawing.Point(228, 109);
            this.chbox_overwrt.Name = "chbox_overwrt";
            this.chbox_overwrt.Size = new System.Drawing.Size(130, 17);
            this.chbox_overwrt.TabIndex = 5;
            this.chbox_overwrt.Text = "Overwrite existing files";
            this.chbox_overwrt.UseVisualStyleBackColor = true;
            this.chbox_overwrt.CheckedChanged += new System.EventHandler(this.chbox_overwrt_CheckedChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(12, 140);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(43, 13);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Status :";
            // 
            // btn_bckupnow
            // 
            this.btn_bckupnow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bckupnow.Location = new System.Drawing.Point(15, 109);
            this.btn_bckupnow.Name = "btn_bckupnow";
            this.btn_bckupnow.Size = new System.Drawing.Size(71, 28);
            this.btn_bckupnow.TabIndex = 3;
            this.btn_bckupnow.Text = "Backup";
            this.btn_bckupnow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_bckupnow.UseVisualStyleBackColor = true;
            this.btn_bckupnow.Click += new System.EventHandler(this.btn_bckupnow_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(18, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 227);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chbox_overwrt);
            this.tabPage1.Controls.Add(this.lbl_status);
            this.tabPage1.Controls.Add(this.btn_bckupnow);
            this.tabPage1.Controls.Add(this.btn_source);
            this.tabPage1.Controls.Add(this.tb_destn);
            this.tabPage1.Controls.Add(this.tb_source);
            this.tabPage1.Controls.Add(this.btn_destn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(359, 201);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Folder Path";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_source
            // 
            this.btn_source.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_source.Location = new System.Drawing.Point(228, 27);
            this.btn_source.Name = "btn_source";
            this.btn_source.Size = new System.Drawing.Size(82, 23);
            this.btn_source.TabIndex = 2;
            this.btn_source.Text = "Source";
            this.btn_source.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_source.UseVisualStyleBackColor = true;
            this.btn_source.Click += new System.EventHandler(this.btn_source_Click_1);
            // 
            // tb_destn
            // 
            this.tb_destn.Location = new System.Drawing.Point(15, 68);
            this.tb_destn.Name = "tb_destn";
            this.tb_destn.Size = new System.Drawing.Size(207, 20);
            this.tb_destn.TabIndex = 1;
            // 
            // tb_source
            // 
            this.tb_source.Location = new System.Drawing.Point(15, 28);
            this.tb_source.Name = "tb_source";
            this.tb_source.Size = new System.Drawing.Size(207, 20);
            this.tb_source.TabIndex = 0;
            // 
            // btn_destn
            // 
            this.btn_destn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_destn.Location = new System.Drawing.Point(228, 67);
            this.btn_destn.Name = "btn_destn";
            this.btn_destn.Size = new System.Drawing.Size(82, 23);
            this.btn_destn.TabIndex = 2;
            this.btn_destn.Text = "Destination";
            this.btn_destn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_destn.UseVisualStyleBackColor = true;
            this.btn_destn.Click += new System.EventHandler(this.btn_destn_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbProgress,
            this.lblProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 371);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(506, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pbProgress
            // 
            this.pbProgress.ForeColor = System.Drawing.Color.DeepPink;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(100, 16);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgress.Click += new System.EventHandler(this.pbProgress_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(23, 17);
            this.lblProgress.Text = "0%";
            // 
            // btnCancelcpy
            // 
            this.btnCancelcpy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelcpy.Location = new System.Drawing.Point(187, 333);
            this.btnCancelcpy.Name = "btnCancelcpy";
            this.btnCancelcpy.Size = new System.Drawing.Size(75, 23);
            this.btnCancelcpy.TabIndex = 10;
            this.btnCancelcpy.Text = "Stop";
            this.btnCancelcpy.UseVisualStyleBackColor = true;
            this.btnCancelcpy.Click += new System.EventHandler(this.btnCancelcpy_Click_1);
            // 
            // btn_exit
            // 
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.Location = new System.Drawing.Point(357, 333);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Cancel";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // lbl_fcpysettingsSchdlr
            // 
            this.lbl_fcpysettingsSchdlr.AutoSize = true;
            this.lbl_fcpysettingsSchdlr.ForeColor = System.Drawing.Color.Black;
            this.lbl_fcpysettingsSchdlr.Location = new System.Drawing.Point(19, 283);
            this.lbl_fcpysettingsSchdlr.Name = "lbl_fcpysettingsSchdlr";
            this.lbl_fcpysettingsSchdlr.Size = new System.Drawing.Size(103, 13);
            this.lbl_fcpysettingsSchdlr.TabIndex = 4;
            this.lbl_fcpysettingsSchdlr.Text = "Scheduled back up:";
            this.lbl_fcpysettingsSchdlr.Visible = false;
            // 
            // lbl_fcpysettingsOvrt
            // 
            this.lbl_fcpysettingsOvrt.AutoSize = true;
            this.lbl_fcpysettingsOvrt.ForeColor = System.Drawing.Color.Black;
            this.lbl_fcpysettingsOvrt.Location = new System.Drawing.Point(19, 265);
            this.lbl_fcpysettingsOvrt.Name = "lbl_fcpysettingsOvrt";
            this.lbl_fcpysettingsOvrt.Size = new System.Drawing.Size(141, 13);
            this.lbl_fcpysettingsOvrt.TabIndex = 4;
            this.lbl_fcpysettingsOvrt.Text = "File overwrite for existing file:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbl_fcpysettingsSchdlr);
            this.groupBox2.Controls.Add(this.lbl_fcpysettingsOvrt);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(2, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 309);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // Logbackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 393);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancelcpy);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox2);
            this.Name = "Logbackup";
            this.Text = "Logbackup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Logbackup_FormClosing);
            this.Load += new System.EventHandler(this.Logbackup_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbox_overwrt;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_bckupnow;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_source;
        private System.Windows.Forms.TextBox tb_destn;
        private System.Windows.Forms.TextBox tb_source;
        private System.Windows.Forms.Button btn_destn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pbProgress;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
        private System.Windows.Forms.FolderBrowserDialog foldrbrws_dest;
        private System.Windows.Forms.Button btnCancelcpy;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.FolderBrowserDialog foldrbrws_src;
        private System.Windows.Forms.Label lbl_fcpysettingsSchdlr;
        private System.Windows.Forms.Label lbl_fcpysettingsOvrt;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}