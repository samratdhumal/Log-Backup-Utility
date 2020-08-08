using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainPage
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            au.Show();
            this.Hide();







        }

        private void label2_Click(object sender, EventArgs e)
        {
            Staticlog s = new Staticlog();
            s.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ServerSide.Form1 a = new ServerSide.Form1();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login l=new Login();
            l.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
