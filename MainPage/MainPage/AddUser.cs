using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using System.Net.Mail;

namespace MainPage
{
    public partial class AddUser : Form
    {
        SqlConnection con;
        
        public AddUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void adduser_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "PLEASE INSERT DATA");

            }
            else
            {
                errorProvider1.Clear();
            }


            if (textBox2.Text == "")
            {
                errorProvider3.SetError(textBox2, "PLEASE INSERT DATA");

            }
            else
            {

                errorProvider3.Clear();
            }


            if (textBox3.Text == "")
            {

                errorProvider2.SetError(textBox3, "PLEASE INSERT PASSWORD GREATER THAN 6 & LESS THAN 12 CHARACTERS");
            }


           /* else  if(textBox3.Text.Length < 6 && textBox3.Text.Length >= 12)
            {
            errorProvider2.SetError(textBox3, "PLEASE INSERT PASSWORD GREATER THAN 6 & LESS THAN 12 CHARACTERS");
            }*/

            else
            {

                errorProvider2.Clear();
            }



            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {




                con = new SqlConnection();

                try
                {

                    con.ConnectionString = @"Data Source=USER-PC\SHREE;Database=ApplicationLogBackup;Integrated Security=True";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into register values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox4.Text + "')";

                    int r = cmd.ExecuteNonQuery();
                    if (r >= 1)
                    {


                        MessageBox.Show("Data Inserted");

                        try
                        {

                            MailMessage mail = new MailMessage();

                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");



                            mail.From = new MailAddress("logbackuputility@gmail.com");

                            mail.To.Add(textBox2.Text);

                            mail.Subject = "Account Successfully Created";

                            String Password = textBox3.Text;
                            String username = textBox1.Text;

                            mail.Body = "YOUR USERNAME='" + username + "' AND PASSWORD='" + Password + "'";



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
                        MessageBox.Show("Data Not Inserted");
                    }

                }
                catch (Exception et)
                {
                    MessageBox.Show("Exception" + et.ToString());
                }
                finally
                {
                    con.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
        }
    }
}
