namespace SmoothyInterface.Forms
{
	partial class UnhandledException
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnhandledException));
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tbExceptionDetails = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tbInfo.Location = new System.Drawing.Point(60, 53);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(388, 33);
            this.tbInfo.TabIndex = 1;
            this.tbInfo.Text = "We caught unhandled exception.Details are given below.";
            // 
            // tbExceptionDetails
            // 
            this.tbExceptionDetails.BackColor = System.Drawing.Color.LightSalmon;
            this.tbExceptionDetails.Location = new System.Drawing.Point(20, 94);
            this.tbExceptionDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbExceptionDetails.Multiline = true;
            this.tbExceptionDetails.Name = "tbExceptionDetails";
            this.tbExceptionDetails.ReadOnly = true;
            this.tbExceptionDetails.Size = new System.Drawing.Size(457, 224);
            this.tbExceptionDetails.TabIndex = 2;
            this.tbExceptionDetails.TextChanged += new System.EventHandler(this.tbExceptionDetails_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(193, 326);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // UnhandledException
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 363);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbExceptionDetails);
            this.Controls.Add(this.tbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UnhandledException";
            this.Text = "Unhandled Exception";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.TextBox tbInfo;
		private System.Windows.Forms.TextBox tbExceptionDetails;
		private System.Windows.Forms.Button btnOK;
	}
}