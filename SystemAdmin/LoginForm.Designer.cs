namespace SystemAdmin
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelPassword = new System.Windows.Forms.Label();
			this.labelLoginName = new System.Windows.Forms.Label();
			this.labelServerName = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxLoginName = new System.Windows.Forms.TextBox();
			this.textBoxServerName = new System.Windows.Forms.TextBox();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPassword.Location = new System.Drawing.Point(87, 183);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(78, 20);
			this.labelPassword.TabIndex = 14;
			this.labelPassword.Text = "Password";
			// 
			// labelLoginName
			// 
			this.labelLoginName.AutoSize = true;
			this.labelLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLoginName.Location = new System.Drawing.Point(87, 133);
			this.labelLoginName.Name = "labelLoginName";
			this.labelLoginName.Size = new System.Drawing.Size(92, 20);
			this.labelLoginName.TabIndex = 13;
			this.labelLoginName.Text = "Login name";
			// 
			// labelServerName
			// 
			this.labelServerName.AutoSize = true;
			this.labelServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelServerName.Location = new System.Drawing.Point(87, 79);
			this.labelServerName.Name = "labelServerName";
			this.labelServerName.Size = new System.Drawing.Size(99, 20);
			this.labelServerName.TabIndex = 12;
			this.labelServerName.Text = "Server name";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPassword.Location = new System.Drawing.Point(213, 177);
			this.textBoxPassword.MinimumSize = new System.Drawing.Size(0, 30);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(230, 30);
			this.textBoxPassword.TabIndex = 11;
			// 
			// textBoxLoginName
			// 
			this.textBoxLoginName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLoginName.Location = new System.Drawing.Point(213, 127);
			this.textBoxLoginName.MinimumSize = new System.Drawing.Size(0, 30);
			this.textBoxLoginName.Name = "textBoxLoginName";
			this.textBoxLoginName.Size = new System.Drawing.Size(230, 30);
			this.textBoxLoginName.TabIndex = 10;
			// 
			// textBoxServerName
			// 
			this.textBoxServerName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxServerName.Location = new System.Drawing.Point(213, 73);
			this.textBoxServerName.MinimumSize = new System.Drawing.Size(0, 30);
			this.textBoxServerName.Name = "textBoxServerName";
			this.textBoxServerName.Size = new System.Drawing.Size(230, 30);
			this.textBoxServerName.TabIndex = 9;
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(368, 235);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 33);
			this.buttonExit.TabIndex = 15;
			this.buttonExit.Text = "Thoát";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(213, 235);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 33);
			this.buttonOK.TabIndex = 16;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// LoginForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(570, 343);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.labelLoginName);
			this.Controls.Add(this.labelServerName);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxLoginName);
			this.Controls.Add(this.textBoxServerName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dăng nhập";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.Label labelLoginName;
		private System.Windows.Forms.Label labelServerName;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.TextBox textBoxLoginName;
		private System.Windows.Forms.TextBox textBoxServerName;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonOK;
	}
}

