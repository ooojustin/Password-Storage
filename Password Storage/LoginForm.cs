/*
User: jusgarofolo
Date: 4/12/2018
Time: 8:40 AM
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Password_Storage
{
	/// <summary>
	/// Description of LoginForm.
	/// </summary>
	public partial class LoginForm : Form {
		
		private bool openOther = false;
		
		public LoginForm() {
			InitializeComponent();
			this.FormClosing += (s, e) => {
				if (!openOther) Application.Exit();
			};
		}
		
		void CbShowPasswordCheckedChanged(object sender, EventArgs e) {
			txtPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
		}
		
		void BtnContinueClick(object sender, EventArgs e) {
			string password = string.Empty;
			string dataPath = string.Empty;
			try {
				password = txtPassword.Text;
				string encryptedDataPath =	Settings.Default.DATA_PATH;
				dataPath = encryptedDataPath.DecryptString(password); // MIGHT FAIL
			} catch (Exception) {
				MessageBox.Show("Failed to verify master password.", "Password Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			openOther = true;
			new MainForm(dataPath, password).Show();
			Close();
		}
	}
}
