/*
User: jusgarofolo
Date: 4/13/2018
Time: 7:38 AM
*/
namespace Password_Storage
{
	partial class AddAccountForm
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
			this.btnAddAccount = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbShowPassword = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnAddAccount
			// 
			this.btnAddAccount.BackColor = System.Drawing.Color.Black;
			this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddAccount.ForeColor = System.Drawing.Color.White;
			this.btnAddAccount.Location = new System.Drawing.Point(12, 170);
			this.btnAddAccount.Name = "btnAddAccount";
			this.btnAddAccount.Size = new System.Drawing.Size(353, 26);
			this.btnAddAccount.TabIndex = 3;
			this.btnAddAccount.Text = "Add Account";
			this.btnAddAccount.UseVisualStyleBackColor = false;
			this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccountClick);
			// 
			// txtDescription
			// 
			this.txtDescription.BackColor = System.Drawing.Color.Black;
			this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescription.ForeColor = System.Drawing.Color.White;
			this.txtDescription.Location = new System.Drawing.Point(12, 27);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(353, 23);
			this.txtDescription.TabIndex = 0;
			this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 15);
			this.label4.TabIndex = 14;
			this.label4.Text = "Account Description:";
			// 
			// txtUsername
			// 
			this.txtUsername.BackColor = System.Drawing.Color.Black;
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsername.ForeColor = System.Drawing.Color.White;
			this.txtUsername.Location = new System.Drawing.Point(12, 72);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(353, 23);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 15);
			this.label1.TabIndex = 18;
			this.label1.Text = "Username/Email:";
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.Black;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.ForeColor = System.Drawing.Color.White;
			this.txtPassword.Location = new System.Drawing.Point(12, 117);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(353, 23);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 15);
			this.label2.TabIndex = 20;
			this.label2.Text = "Password:";
			// 
			// cbShowPassword
			// 
			this.cbShowPassword.Location = new System.Drawing.Point(13, 146);
			this.cbShowPassword.Name = "cbShowPassword";
			this.cbShowPassword.Size = new System.Drawing.Size(147, 18);
			this.cbShowPassword.TabIndex = 4;
			this.cbShowPassword.Text = "Show Password";
			this.cbShowPassword.UseVisualStyleBackColor = true;
			this.cbShowPassword.CheckedChanged += new System.EventHandler(this.CbShowPasswordCheckedChanged);
			// 
			// AddAccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(377, 210);
			this.Controls.Add(this.cbShowPassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAddAccount);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label4);
			this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "AddAccountForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Password Storage - Add Account";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox cbShowPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button btnAddAccount;
	}
}
