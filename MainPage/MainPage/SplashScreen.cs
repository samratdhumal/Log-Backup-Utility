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
    public partial class SplashScreen : Form
    {
        
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            //Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 4, Microsoft.Win32.RegistryValueKind.DWord);
            //MessageBox.Show("All Usb Ports Are Disabled ", "Sucess @ Rebyc ");


        }

        private void button1_Click(object sender, EventArgs e)
        {

            

           



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                progressBar1.Value = 0;

                Login l = new Login();
                l.Show();
                this.Hide();
                

            }
            else
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
            
        }
        
    }
}
