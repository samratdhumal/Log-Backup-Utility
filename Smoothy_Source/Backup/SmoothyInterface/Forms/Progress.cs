using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SmoothyInterface.Forms
{
	public partial class Progress : Form
	{
		#region Globals
		
		bool stop = false;
		int count = 0;
		Thread busyBarThread;
				
		#endregion

		public Progress()
		{
			InitializeComponent();
			StartBusyBarThread();
		}

		private void StartBusyBarThread()
		{
			busyBarThread = new Thread(new ThreadStart(StartBusyBar));
			busyBarThread.Start();
		}
				
		public void IncrementValue()
		{
			lock (this)
			{
				count++;

				if (this.InvokeRequired)
				{
					this.BeginInvoke(new MethodInvoker(UpdateInfo));
				}
				else
				{
					UpdateInfo();
				}
			}
		}

		private void UpdateInfo()
		{
			lblLoadedCount.Text = count.ToString();
		}
				
		private void Progress_FormClosing(object sender, FormClosingEventArgs e)
		{
			stop = true;
			busyBarThread.Join();
		}

		private void StartBusyBar()
		{
			while (!stop)
			{
				if (busyBar1.Value == busyBar1.Maximum)
				{
					busyBar1.Value = busyBar1.Minimum;
				}
				else
				{
					busyBar1.Value++;
				}

				Application.DoEvents();
				System.Threading.Thread.Sleep(200);
			}
		}
	}
}