using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MainPage
{
    public partial class Login : Form
    {
         SqlConnection con;
        SqlDataReader rdr;
        SqlCommand cmd;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
                
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void login_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "PLEASE ENTER VALID USERNAME");
            }
            else
            {

                errorProvider1.Clear();
            }

            if (textBox2.Text == "")
            {
                errorProvider2.SetError(textBox2, "PLEASE ENTER VALID PASSWORD");
            }
            else
            {

                errorProvider2.Clear();
            }


            if (textBox1.Text != "" || textBox2.Text != "")
            {
                con = new SqlConnection();


                try
                {

                    con.ConnectionString = @"Data Source=AKSHAY;Initial Catalog=ApplicationLogBackup;Integrated Security=True";
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from register where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";

                    rdr = cmd.ExecuteReader();
                    // loop through result set
                    if (rdr.Read())
                    {
                        String role = rdr.GetString(3);
                        MessageBox.Show("login success");

                        if (role.Equals("admin"))
                        {
                            
                            //ServerSide.Form1 a = new ServerSide.Form1();
                            Admin a = new Admin();
                            a.Show();
                            this.Hide();
                        }
                        else
                        { //user page
                        }




                    }
                    else { MessageBox.Show("sorry"); }



                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            ForgotPassword f = new ForgotPassword();
            f.Show();
            this.Hide();
        }
    }
}
