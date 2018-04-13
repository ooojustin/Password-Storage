/*
User: jusgarofolo
Date: 3/26/2018
Time: 9:09 AM
*/
namespace Password_Storage
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label4 = new System.Windows.Forms.Label();
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAddAccount = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExportCredentials = new System.Windows.Forms.Button();
			this.btnCopyUsername = new System.Windows.Forms.Button();
			this.btnCopyPassword = new System.Windows.Forms.Button();
			this.btnDeleteAccounts = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "Accounts:";
			// 
			// dataGrid
			// 
			this.dataGrid.AllowUserToAddRows = false;
			this.dataGrid.AllowUserToDeleteRows = false;
			this.dataGrid.AllowUserToResizeColumns = false;
			this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Checked,
									this.Description,
									this.Username,
									this.Password});
			this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid.GridColor = System.Drawing.Color.Black;
			this.dataGrid.Location = new System.Drawing.Point(0, 0);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.Size = new System.Drawing.Size(465, 240);
			this.dataGrid.TabIndex = 11;
			// 
			// Checked
			// 
			this.Checked.HeaderText = "Selected";
			this.Checked.Name = "Checked";
			// 
			// Description
			// 
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			// 
			// Username
			// 
			this.Username.HeaderText = "Username";
			this.Username.Name = "Username";
			this.Username.ReadOnly = true;
			// 
			// Password
			// 
			this.Password.HeaderText = "Password";
			this.Password.Name = "Password";
			// 
			// btnAddAccount
			// 
			this.btnAddAccount.BackColor = System.Drawing.Color.Black;
			this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddAccount.ForeColor = System.Drawing.Color.White;
			this.btnAddAccount.Location = new System.Drawing.Point(13, 275);
			this.btnAddAccount.Name = "btnAddAccount";
			this.btnAddAccount.Size = new System.Drawing.Size(465, 26);
			this.btnAddAccount.TabIndex = 13;
			this.btnAddAccount.Text = "Add New Account";
			this.btnAddAccount.UseVisualStyleBackColor = false;
			this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccountClick);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.dataGrid);
			this.panel1.Location = new System.Drawing.Point(12, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(467, 242);
			this.panel1.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 311);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 15);
			this.label1.TabIndex = 15;
			this.label1.Text = "Selected Account(s):";
			// 
			// btnExportCredentials
			// 
			this.btnExportCredentials.BackColor = System.Drawing.Color.Black;
			this.btnExportCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportCredentials.ForeColor = System.Drawing.Color.White;
			this.btnExportCredentials.Location = new System.Drawing.Point(13, 395);
			this.btnExportCredentials.Name = "btnExportCredentials";
			this.btnExportCredentials.Size = new System.Drawing.Size(465, 26);
			this.btnExportCredentials.TabIndex = 16;
			this.btnExportCredentials.Text = "Export Credentials";
			this.btnExportCredentials.UseVisualStyleBackColor = false;
			// 
			// btnCopyUsername
			// 
			this.btnCopyUsername.BackColor = System.Drawing.Color.Black;
			this.btnCopyUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCopyUsername.ForeColor = System.Drawing.Color.White;
			this.btnCopyUsername.Location = new System.Drawing.Point(13, 331);
			this.btnCopyUsername.Name = "btnCopyUsername";
			this.btnCopyUsername.Size = new System.Drawing.Size(465, 26);
			this.btnCopyUsername.TabIndex = 17;
			this.btnCopyUsername.Text = "Copy Username";
			this.btnCopyUsername.UseVisualStyleBackColor = false;
			// 
			// btnCopyPassword
			// 
			this.btnCopyPassword.BackColor = System.Drawing.Color.Black;
			this.btnCopyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCopyPassword.ForeColor = System.Drawing.Color.White;
			this.btnCopyPassword.Location = new System.Drawing.Point(13, 363);
			this.btnCopyPassword.Name = "btnCopyPassword";
			this.btnCopyPassword.Size = new System.Drawing.Size(465, 26);
			this.btnCopyPassword.TabIndex = 18;
			this.btnCopyPassword.Text = "Copy Password";
			this.btnCopyPassword.UseVisualStyleBackColor = false;
			// 
			// btnDeleteAccounts
			// 
			this.btnDeleteAccounts.BackColor = System.Drawing.Color.Black;
			this.btnDeleteAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteAccounts.ForeColor = System.Drawing.Color.White;
			this.btnDeleteAccounts.Location = new System.Drawing.Point(13, 427);
			this.btnDeleteAccounts.Name = "btnDeleteAccounts";
			this.btnDeleteAccounts.Size = new System.Drawing.Size(465, 26);
			this.btnDeleteAccounts.TabIndex = 19;
			this.btnDeleteAccounts.Text = "Delete Account(s)";
			this.btnDeleteAccounts.UseVisualStyleBackColor = false;
			this.btnDeleteAccounts.Click += new System.EventHandler(this.BtnDeleteAccountsClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(491, 469);
			this.Controls.Add(this.btnDeleteAccounts);
			this.Controls.Add(this.btnCopyPassword);
			this.Controls.Add(this.btnCopyUsername);
			this.Controls.Add(this.btnExportCredentials);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnAddAccount);
			this.Controls.Add(this.label4);
			this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Password Storage - Main";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnDeleteAccounts;
		private System.Windows.Forms.Button btnCopyPassword;
		private System.Windows.Forms.Button btnCopyUsername;
		private System.Windows.Forms.Button btnExportCredentials;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAddAccount;
		private System.Windows.Forms.DataGridViewTextBoxColumn Password;
		private System.Windows.Forms.DataGridViewTextBoxColumn Username;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Checked;
		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.Label label4;
	}
}
