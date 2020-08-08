using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.Data.SqlClient;

namespace MainPage
{
    public partial class ForgotPassword : Form
    {
        SqlConnection con;
        SqlDataReader rdr;
        SqlCommand cmd;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();

        }

        private void submit_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();



            if (textBox1.Text != "" || textBox2.Text != "")
            {


                try
                {

                    con.ConnectionString = @"Data Source=AKSHAY;Initial Catalog=ApplicationLogBackup;Integrated Security=True";
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from register where username='" + textBox1.Text + "' and email='" + textBox2.Text + "'";

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {

                        try
                        {

                            MailMessage mail = new MailMessage();

                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");



                            mail.From = new MailAddress("logbackuputility@gmail.com");

                            mail.To.Add(textBox2.Text);

                            mail.Subject = "PASSWORD RECOVERY";
                            MessageBox.Show(""+mail);
                            String Password = rdr.GetString(1).ToString();

                            mail.Body = "YOUR PASSWORD FOR REGISTERED EMAIL ID IS '" + Password + "'";



                            SmtpServer.Port = 587;

                            SmtpServer.Credentials = new System.Net.NetworkCredential("logbackuputility@gmail.com", "GROUPSEVENLOGBACKUP");

                            SmtpServer.EnableSsl = true;



                            SmtpServer.Send(mail);

                            MessageBox.Show("****MAIL SENT****");

                        }



                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.ToString());

                        }

                    }
                    else
                    {
                        MessageBox.Show("You are not yet registered...");
                    }
                }



                catch (Exception et)
                {
                    MessageBox.Show("Exception" + et.ToString());
                }
                finally
                {
                    con.Close();
                }






            }
        }

    }
}

    

