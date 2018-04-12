/*
User: jusgarofolo
Date: 3/26/2018
Time: 9:11 AM
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Password_Storage
{
	/// <summary>
	/// Description of InitForm.
	/// </summary>
	public partial class InitForm : Form
	{
		
		public InitForm() {
			InitializeComponent();
			this.FormClosing += (s, e) => Application.Exit();
		}
		
		void BtnSelectPathClick(object sender, EventArgs e) {
			sfd.FileName = "";
			sfd.Filter = "*Data Files (*.data)|*.data";
			DialogResult result = sfd.ShowDialog();
			if (result == DialogResult.OK)
				txtDataPath.Text = sfd.FileName;
		}
		
		void CbShowPasswordCheckedChanged(object sender, EventArgs e) {
			txtPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
		}	
		
		void BtnContinueClick(object sender, EventArgs e){
			// storing a password isn't required, we use that as our encryption key
			string dataPath = txtDataPath.Text;
			Settings.Default.DATA_PATH = encryptedPath;
			Settings.Default.Save();
			Application.Restart();
		}
		
	}
}
