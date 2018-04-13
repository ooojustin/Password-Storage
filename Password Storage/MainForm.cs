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
		
		public void UpdateAccounts() {
			dataGrid.Rows.Clear();
			foreach (PassStoreAccount account in passStore.GetAccounts()) {
				string description = account.GetDescription();
				string username = account.GetUsername();
				string password = account.GetPassword();
				int column = dataGrid.Rows.Add(false, description, username, password);
				for (int i = 0; i < dataGrid.ColumnCount; i++) {
					DataGridViewCell cell = dataGrid.Rows[column].Cells[i];
					cell.Style.BackColor = Color.Black;
					cell.Style.ForeColor = Color.White;
				}
			}
		}
		
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
			
		void BtnDeleteAccountsClick(object sender, EventArgs e){
			List<DataGridViewRow> selected = SelectedAccounts();
			DialogResult confirm = MessageBox.Show("Are you sure you want to continue?\nThis action cannot be reversed.\n" + selected.Count + " accounts will be deleted.", "Password Storage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (confirm != DialogResult.Yes) return;
			List<PassStoreAccount> accountsToRemove = new List<PassStoreAccount>();
			foreach (DataGridViewRow row in selected) {
				int index = row.Index;
				PassStoreAccount toRemove = passStore.GetAccounts()[index];
				accountsToRemove.Add(toRemove);
			}
			foreach (PassStoreAccount account in accountsToRemove) {
				passStore.DeleteAccount(account);
			}
			UpdateAccounts();
		}
		
		
	}
}
