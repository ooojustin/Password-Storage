/*
User: jusgarofolo
Date: 3/26/2018
Time: 9:09 AM
*/
using System;
using System.Windows.Forms;

namespace Password_Storage
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class P {
		
		public static string DATA_PATH = string.Empty;
		public static string ENCRYPTION_KEY = string.Empty;
		
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			string dataPath = Settings.Default.DATA_PATH;
			bool needInit = string.IsNullOrWhiteSpace(dataPath);
			if (needInit) 
				new InitForm().Show();
			else 
				new LoginForm().Show();
			
			//Settings.Default.DATA_PATH = "";
			//Settings.Default.Save();
			
			Application.Run();
		}
		
	}
}
