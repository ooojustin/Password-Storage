/*
User: jusgarofolo
Date: 4/13/2018
Time: 7:38 AM
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Password_Storage
{
	/// <summary>
	/// Description of AddAccountForm.
	/// </summary>
	public partial class AddAccountForm : Form
	{
		
		private MainForm parent;
		private PassStore passStore;
		
		public AddAccountForm(MainForm parent, PassStore passStore) {
			InitializeComponent();
			this.parent = parent;
			this.passStore = passStore;
		}
		
		void BtnAddAccountClick(object sender, EventArgs e)	{
			string description = txtDescription.Text;
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			passStore.AddAccount(description, username, password);
			parent.UpdateAccounts();
			Close();
		}	
		
		void CbShowPasswordCheckedChanged(object sender, EventArgs e) {
			txtPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
		}
		
	}
}
