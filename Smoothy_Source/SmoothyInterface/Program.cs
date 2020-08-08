using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmoothyInterface.Forms;

namespace SmoothyInterface
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			try
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainWindow());
			}
			catch (Exception ex)
			{
				UnhandledException form = new UnhandledException(ex);
				form.ShowDialog();
			}
		}
	}
}