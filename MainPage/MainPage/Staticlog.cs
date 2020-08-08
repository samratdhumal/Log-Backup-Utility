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
    public partial class Staticlog : Form
    {
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        public Staticlog()
        {
            InitializeComponent();
        }

        private void Staticlog_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_btn.Enabled = false;
            delete_btn.Enabled = false;
            button2.Enabled = true;
            textBox1.Text = "";
            textBox3.Text = "";
             maskedTextBox1.Text = "";
            textBox5.Text = "";




            dt.Clear();
            this.dataGridView1.DataSource = dt;

            con = new SqlConnection();

            try
            {

                con.ConnectionString = @"Data Source=AKSHAY;Initial Catalog=ApplicationLogBackup;Integrated Security=True";
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select * from Data";


                sda.SelectCommand = cmd;
                sda.Fill(dt);
                this.dataGridView1.DataSource = dt;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "PLEASE INSERT DATA");

            }
            else
            {
                errorProvider1.Clear();
            }
            if (textBox3.Text == "")
            {
                errorProvider2.SetError(textBox3, "PLEASE INSERT DATA");


            }
            else
            {
                errorProvider2.Clear();
            }
            if ( maskedTextBox1.Text == "")
            {
                errorProvider3.SetError( maskedTextBox1, "PLEASE INSERT DATA");

            }
            else
            {
                errorProvider3.Clear();
            }
            if (textBox5.Text == "")
            {
                errorProvider4.SetError(textBox5, "PLEASE INSERT DATA");

            }
            else
            {
                errorProvider4.Clear();
            }





            if (textBox1.Text != "" && dateTimePicker1.Text != "" && textBox5.Text != "" && textBox3.Text != "" &&  maskedTextBox1.Text != "")
            {
                con = new SqlConnection();

                try
                {

                    con.ConnectionString = @"Data Source=USER-PC\SHREE;Database=ApplicationLogBackup;Integrated Security=True";
                    con.Open();
                    //  SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Data values('" + textBox1.Text + "','" + dateTimePicker1.Value + "','" + textBox3.Text + "','" +  maskedTextBox1.Text + "','" + textBox5.Text + "')";

                    int r = cmd.ExecuteNonQuery();
                    if (r >= 1)
                    {
                        textBox1.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                         maskedTextBox1.Text = "";
                        MessageBox.Show("Data Inserted");
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
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = false;
            update_btn.Enabled = true;
            delete_btn.Enabled = true;

            int i = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[i];

            textBox1.Text = row.Cells["Level"].Value.ToString();

            dateTimePicker1.Text = row.Cells["Date_Time"].Value.ToString();

            textBox3.Text = row.Cells["Source"].Value.ToString();

             maskedTextBox1.Text = row.Cells["Event_ID"].Value.ToString();

            textBox5.Text = row.Cells["Task_Category"].Value.ToString();



        }

        private void update_btn_Click(object sender, EventArgs e)
        {


            if (textBox1.Text != "" && dateTimePicker1.Text != "" && textBox5.Text != "" && textBox3.Text != "" &&  maskedTextBox1.Text != "")
            {
                con = new SqlConnection();

                try
                {

                    con.ConnectionString = @"Data Source=USER-PC\SHREE;Database=ApplicationLogBackup;Integrated Security=True";
                    con.Open();
                    //  SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Data set Level='" + textBox1.Text + "',Date_Time='" + dateTimePicker1.Value + "',Source='" + textBox3.Text + "',Task_Category='" + textBox5.Text + "' where Event_ID='" +  maskedTextBox1.Text + "'";

                    int r = cmd.ExecuteNonQuery();
                    if (r >= 1)
                    {
                        textBox1.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                         maskedTextBox1.Text = "";
                        MessageBox.Show("Data updated");


                        dt.Clear();
                        this.dataGridView1.DataSource = dt;

                        con = new SqlConnection();

                        try
                        {

                            con.ConnectionString = @"Data Source=USER-PC\SHREE;Database=ApplicationLogBackup;Integrated Security=True";
                            con.Open();
                            cmd.Connection = con;
                            cmd.CommandText = "select * from Data";


                            sda.SelectCommand = cmd;
                            sda.Fill(dt);
                            this.dataGridView1.DataSource = dt;
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
                    else
                    {
                        MessageBox.Show("Data Not updated");
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                con = new SqlConnection();

                try
                {

                    con.ConnectionString = @"Data Source=USER-PC\SHREE;Database=ApplicationLogBackup;Integrated Security=True";
                    con.Open();
                    //  SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Data where Level='" + textBox1.Text + "'";

                    int r = cmd.ExecuteNonQuery();
                    if (r >= 1)
                    {
                        textBox1.Text = "";
                        textBox3.Text = "";
                        textBox5.Text = "";
                         maskedTextBox1.Text = "";
                        MessageBox.Show("Data updated");

                      
                        dt.Clear();
                        this.dataGridView1.DataSource = dt;

                        con = new SqlConnection();

                        try
                        {

                            con.ConnectionString = @"Data Source=USER-PC\SHREE;Database=ApplicationLogBackup;Integrated Security=True";
                            con.Open();
                            cmd.Connection = con;
                            cmd.CommandText = "select * from Data";


                            sda.SelectCommand = cmd;
                            sda.Fill(dt);
                            this.dataGridView1.DataSource = dt;
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
                    else
                    {
                        MessageBox.Show("Data Not updated");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void update_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
