/*
User: jusgarofolo
Date: 4/12/2018
Time: 8:40 AM
*/
namespace Password_Storage
{
	partial class LoginForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.btnContinue = new System.Windows.Forms.Button();
			this.cbShowPassword = new System.Windows.Forms.CheckBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(245, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "Welcome to Password Storage!\r\nPlease enter your master password.";
			// 
			// btnContinue
			// 
			this.btnContinue.BackColor = System.Drawing.Color.Black;
			this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnContinue.ForeColor = System.Drawing.Color.White;
			this.btnContinue.Location = new System.Drawing.Point(12, 74);
			this.btnContinue.Name = "btnContinue";
			this.btnContinue.Size = new System.Drawing.Size(350, 26);
			this.btnContinue.TabIndex = 12;
			this.btnContinue.Text = "Continue";
			this.btnContinue.UseVisualStyleBackColor = false;
			this.btnContinue.Click += new System.EventHandler(this.BtnContinueClick);
			// 
			// cbShowPassword
			// 
			this.cbShowPassword.AutoSize = true;
			this.cbShowPassword.ForeColor = System.Drawing.Color.White;
			this.cbShowPassword.Location = new System.Drawing.Point(308, 48);
			this.cbShowPassword.Name = "cbShowPassword";
			this.cbShowPassword.Size = new System.Drawing.Size(54, 19);
			this.cbShowPassword.TabIndex = 11;
			this.cbShowPassword.Text = "Show";
			this.cbShowPassword.UseVisualStyleBackColor = true;
			this.cbShowPassword.CheckedChanged += new System.EventHandler(this.CbShowPasswordCheckedChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.Black;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.ForeColor = System.Drawing.Color.White;
			this.txtPassword.Location = new System.Drawing.Point(88, 45);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(214, 23);
			this.txtPassword.TabIndex = 10;
			this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Password:";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(378, 114);
			this.Controls.Add(this.btnContinue);
			this.Controls.Add(this.cbShowPassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "LoginForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Password Storage - Login";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.CheckBox cbShowPassword;
		private System.Windows.Forms.Button btnContinue;
		private System.Windows.Forms.Label label2;
	}
}
