namespace SystemAdmin
{
	partial class BackupAndRestore
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupAndRestore));
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.backUpBtn = new System.Windows.Forms.ToolStripButton();
			this.restoreBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSplitButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.restoreTimeParameter = new System.Windows.Forms.ToolStripComboBox();
			this.createDeviceBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backUpBtn,
            this.restoreBtn,
            this.toolStripSplitButton,
            this.toolStripSeparator1,
            this.createDeviceBtn,
            this.exitBtn});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(984, 39);
			this.toolStrip.TabIndex = 0;
			// 
			// backUpBtn
			// 
			this.backUpBtn.Image = ((System.Drawing.Image)(resources.GetObject("backUpBtn.Image")));
			this.backUpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.backUpBtn.Name = "backUpBtn";
			this.backUpBtn.Size = new System.Drawing.Size(82, 36);
			this.backUpBtn.Text = "Sao lưu";
			// 
			// restoreBtn
			// 
			this.restoreBtn.Image = ((System.Drawing.Image)(resources.GetObject("restoreBtn.Image")));
			this.restoreBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.restoreBtn.Name = "restoreBtn";
			this.restoreBtn.Size = new System.Drawing.Size(90, 36);
			this.restoreBtn.Text = "Phục hồi";
			// 
			// toolStripSplitButton
			// 
			this.toolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreTimeParameter});
			this.toolStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton.Image")));
			this.toolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton.Name = "toolStripSplitButton";
			this.toolStripSplitButton.Size = new System.Drawing.Size(224, 36);
			this.toolStripSplitButton.Text = "Tham số phục hồi theo thời gian";
			// 
			// restoreTimeParameter
			// 
			this.restoreTimeParameter.Items.AddRange(new object[] {
            "On",
            "Off"});
			this.restoreTimeParameter.Name = "restoreTimeParameter";
			this.restoreTimeParameter.Size = new System.Drawing.Size(121, 23);
			// 
			// createDeviceBtn
			// 
			this.createDeviceBtn.Image = ((System.Drawing.Image)(resources.GetObject("createDeviceBtn.Image")));
			this.createDeviceBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.createDeviceBtn.Name = "createDeviceBtn";
			this.createDeviceBtn.Size = new System.Drawing.Size(140, 36);
			this.createDeviceBtn.Text = "Tạo device sao lưu";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// exitBtn
			// 
			this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
			this.exitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(73, 36);
			this.exitBtn.Text = "Thoát";
			// 
			// BackupAndRestore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.toolStrip);
			this.Name = "BackupAndRestore";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sao lưu - phục hồi cơ sở dữ liệu trong SQL Server";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BackupAndRestore_FormClosed);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton backUpBtn;
		private System.Windows.Forms.ToolStripButton restoreBtn;
		private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton;
		private System.Windows.Forms.ToolStripComboBox restoreTimeParameter;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton createDeviceBtn;
		private System.Windows.Forms.ToolStripButton exitBtn;
	}
}