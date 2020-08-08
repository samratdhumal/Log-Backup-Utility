using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FtpDemo
{
    public partial class MkDirForm : Form
    {
        public MkDirForm()
        {
            InitializeComponent();
        }

        public string DirName
        {
            get
            {
                return textBox_dir_name.Text;
            }
        }

        private void MkDirForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}