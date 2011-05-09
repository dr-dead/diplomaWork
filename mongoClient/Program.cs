using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace mongoClient
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			if(args.Length > 0)
			{
				System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(args[0]);
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginForm());
			if(ServerConnection.Connected)
			{
				Application.Run(new MainForm());
			}
		}
	}
}
