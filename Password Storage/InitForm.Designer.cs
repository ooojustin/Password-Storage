/*
User: jusgarofolo
Date: 3/26/2018
Time: 9:11 AM
*/
namespace Password_Storage
{
	partial class InitForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDataPath = new System.Windows.Forms.TextBox();
			this.btnSelectPath = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbShowPassword = new System.Windows.Forms.CheckBox();
			this.btnContinue = new System.Windows.Forms.Button();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Path:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(224, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Create a file to store data in.";
			// 
			// txtDataPath
			// 
			this.txtDataPath.BackColor = System.Drawing.Color.Black;
			this.txtDataPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDataPath.ForeColor = System.Drawing.Color.White;
			this.txtDataPath.Location = new System.Drawing.Point(62, 30);
			this.txtDataPath.Name = "txtDataPath";
			this.txtDataPath.Size = new System.Drawing.Size(242, 23);
			this.txtDataPath.TabIndex = 2;
			this.txtDataPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnSelectPath
			// 
			this.btnSelectPath.BackColor = System.Drawing.Color.Black;
			this.btnSelectPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelectPath.ForeColor = System.Drawing.Color.White;
			this.btnSelectPath.Location = new System.Drawing.Point(310, 30);
			this.btnSelectPath.Name = "btnSelectPath";
			this.btnSelectPath.Size = new System.Drawing.Size(56, 23);
			this.btnSelectPath.TabIndex = 3;
			this.btnSelectPath.Text = "...";
			this.btnSelectPath.UseVisualStyleBackColor = false;
			this.btnSelectPath.Click += new System.EventHandler(this.BtnSelectPathClick);
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.Black;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.ForeColor = System.Drawing.Color.White;
			this.txtPassword.Location = new System.Drawing.Point(92, 80);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(214, 23);
			this.txtPassword.TabIndex = 6;
			this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(273, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Enter a password to encrypt your data.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Password:";
			// 
			// cbShowPassword
			// 
			this.cbShowPassword.AutoSize = true;
			this.cbShowPassword.Location = new System.Drawing.Point(312, 83);
			this.cbShowPassword.Name = "cbShowPassword";
			this.cbShowPassword.Size = new System.Drawing.Size(54, 19);
			this.cbShowPassword.TabIndex = 7;
			this.cbShowPassword.Text = "Show";
			this.cbShowPassword.UseVisualStyleBackColor = true;
			this.cbShowPassword.CheckedChanged += new System.EventHandler(this.CbShowPasswordCheckedChanged);
			// 
			// btnContinue
			// 
			this.btnContinue.BackColor = System.Drawing.Color.Black;
			this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnContinue.ForeColor = System.Drawing.Color.White;
			this.btnContinue.Location = new System.Drawing.Point(16, 109);
			this.btnContinue.Name = "btnContinue";
			this.btnContinue.Size = new System.Drawing.Size(350, 26);
			this.btnContinue.TabIndex = 8;
			this.btnContinue.Text = "Continue";
			this.btnContinue.UseVisualStyleBackColor = false;
			this.btnContinue.Click += new System.EventHandler(this.BtnContinueClick);
			// 
			// InitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(390, 147);
			this.Controls.Add(this.btnContinue);
			this.Controls.Add(this.cbShowPassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnSelectPath);
			this.Controls.Add(this.txtDataPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "InitForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Password Storage - Initialization";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.Button btnContinue;
		private System.Windows.Forms.CheckBox cbShowPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnSelectPath;
		private System.Windows.Forms.TextBox txtDataPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
