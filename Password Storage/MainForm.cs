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
			UpdateAccounts();
		}	
		
		// update the accounts in the grid view based on passStore data
		public void UpdateAccounts() {
			dataGrid.Rows.Clear();
			foreach (PassStoreAccount account in passStore.GetAccounts()) {
				string description = account.GetDescription();
				string username = account.GetUsername();
				string password = string.Empty;
				int passLength = account.GetPassword().Length;
				for (int i = 0; i < passLength; i++)
					password += '•';
				int column = dataGrid.Rows.Add(false, description, username, password);
				for (int i = 0; i < dataGrid.ColumnCount; i++) {
					DataGridViewCell cell = dataGrid.Rows[column].Cells[i];
					cell.Style.BackColor = Color.Black;
					cell.Style.ForeColor = Color.White;
				}
			}
		}
		
		// return a list of all selected rows (checkbox in first column is checked)
		public List<DataGridViewRow> SelectedAccounts() {
			List<DataGridViewRow> selected = new List<DataGridViewRow>();
			for (int i = 0; i < dataGrid.RowCount; i++) {
				DataGridViewRow row = dataGrid.Rows[i];
				if ((bool)row.Cells[0].Value)
					selected.Add(row);				
			}
			return selected;
		}

		void BtnAddAccountClick(object sender, EventArgs e) {
			new AddAccountForm(this, passStore).Show();
		}
		
		// delete selected accounts from the grid view		
		void BtnDeleteAccountsClick(object sender, EventArgs e) {
			List<DataGridViewRow> selected = SelectedAccounts();
			if (selected.Count == 0) {
				MessageBox.Show("Please select the account(s) you'd like to delete.", "Password Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DialogResult confirm = MessageBox.Show("Are you sure you want to continue?\nThis action cannot be reversed.\n" + selected.Count + " accounts will be deleted.", "Password Storage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (confirm != DialogResult.Yes) return;
			List<PassStoreAccount> accounts = passStore.GetAccounts();
			List<PassStoreAccount> accountsToRemove = new List<PassStoreAccount>();
			foreach (DataGridViewRow row in selected) {
				int index = row.Index;
				PassStoreAccount toRemove = accounts[index];
				accountsToRemove.Add(toRemove);
			}
			foreach (PassStoreAccount account in accountsToRemove)
				passStore.DeleteAccount(account);
			UpdateAccounts();
		}
		
		// export selected accounts to clipboard (format: description - username - password)
		void BtnExportAccountsClick(object sender, EventArgs e) {
			List<DataGridViewRow> selected = SelectedAccounts();
			int total = selected.Count; // how many selected rows there are
			if (total == 0) {
				MessageBox.Show("Please select the account(s) you'd like to export.", "Password Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			List<PassStoreAccount> accounts = passStore.GetAccounts();
			string data = string.Empty;
			foreach (DataGridViewRow row in selected) {
				int index = row.Index;
				PassStoreAccount account = accounts[index];
				string description = account.GetDescription();
				string username = account.GetUsername();
				string password = account.GetPassword();
				data += description + " - " + username + " - " + password;
				if (row != selected[total - 1]) {
					// new line if it's not the last item
					data += Environment.NewLine;
				}
			}
			try {
				Clipboard.SetText(data);
				MessageBox.Show(total + " account(s) have been copied to your clipboard.", "Password Storage", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch (Exception) {
				MessageBox.Show("Failed to copy information to clipboard.", "Password Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnCopyUsernameClick(object sender, EventArgs e) {
			List<DataGridViewRow> selected = SelectedAccounts();
			if (selected.Count != 1) {
				MessageBox.Show("Please select one account.", "Password Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			PassStoreAccount account = passStore.GetAccounts()[selected[0].Index];
			try {
				Clipboard.SetText(account.GetUsername());
			} catch (Exception) {
				MessageBox.Show("Failed to copy information to clipboard.", "Password Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnCopyPasswordClick(object sender, EventArgs e) {
			List<DataGridViewRow> selected = SelectedAccounts();
			if (selected.Count != 1) {
				MessageBox.Show("Please select one account.", "Password Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			PassStoreAccount account = passStore.GetAccounts()[selected[0].Index];
			try {
				Clipboard.SetText(account.GetPassword());
			} catch (Exception) {
				MessageBox.Show("Failed to copy information to clipboard.", "Password Storage", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}								
	}
}
