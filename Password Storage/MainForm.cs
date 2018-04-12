/*
User: jusgarofolo
Date: 3/26/2018
Time: 9:09 AM
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Password_Storage
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form {
		
		private PassStore passStore;
		
		public MainForm(string dataPath, string password) {
			InitializeComponent();
			this.FormClosing += (s, e) => Application.Exit();
			passStore = new PassStore(dataPath, password);
		}	
		
	}
}
