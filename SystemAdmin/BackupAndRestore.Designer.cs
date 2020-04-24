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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupAndRestore));
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.backUpBtn = new System.Windows.Forms.ToolStripButton();
			this.restoreBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSplitButtonTimeRestore = new System.Windows.Forms.ToolStripDropDownButton();
			this.timeRestoreParamenterOn = new System.Windows.Forms.ToolStripMenuItem();
			this.timeRestoreParamenterOff = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.createDeviceBtn = new System.Windows.Forms.ToolStripButton();
			this.exitBtn = new System.Windows.Forms.ToolStripButton();
			this.dataGridViewDatabases = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.databaseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.databasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dS = new SystemAdmin.DS();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBoxDatabaseName = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripTextBoxSTT = new System.Windows.Forms.ToolStripTextBox();
			this.dataGridViewBackup = new System.Windows.Forms.DataGridView();
			this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.backupstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sPSTTBACKUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.checkBoxWithInit = new System.Windows.Forms.CheckBox();
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.timeEditRestore = new DevExpress.XtraEditors.TimeEdit();
			this.dateEditRestore = new DevExpress.XtraEditors.DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.databasesTableAdapter = new SystemAdmin.DSTableAdapters.databasesTableAdapter();
			this.sP_STT_BACKUPTableAdapter = new SystemAdmin.DSTableAdapters.SP_STT_BACKUPTableAdapter();
			this.toolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabases)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sPSTTBACKUPBindingSource)).BeginInit();
			this.groupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeEditRestore.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditRestore.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditRestore.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backUpBtn,
            this.restoreBtn,
            this.toolStripSplitButtonTimeRestore,
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
			this.backUpBtn.Click += new System.EventHandler(this.backUpBtn_Click);
			// 
			// restoreBtn
			// 
			this.restoreBtn.Image = ((System.Drawing.Image)(resources.GetObject("restoreBtn.Image")));
			this.restoreBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.restoreBtn.Name = "restoreBtn";
			this.restoreBtn.Size = new System.Drawing.Size(90, 36);
			this.restoreBtn.Text = "Phục hồi";
			this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
			// 
			// toolStripSplitButtonTimeRestore
			// 
			this.toolStripSplitButtonTimeRestore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeRestoreParamenterOn,
            this.timeRestoreParamenterOff});
			this.toolStripSplitButtonTimeRestore.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonTimeRestore.Image")));
			this.toolStripSplitButtonTimeRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButtonTimeRestore.Name = "toolStripSplitButtonTimeRestore";
			this.toolStripSplitButtonTimeRestore.Size = new System.Drawing.Size(224, 36);
			this.toolStripSplitButtonTimeRestore.Text = "Tham số phục hồi theo thời gian";
			// 
			// timeRestoreParamenterOn
			// 
			this.timeRestoreParamenterOn.Name = "timeRestoreParamenterOn";
			this.timeRestoreParamenterOn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
			this.timeRestoreParamenterOn.Size = new System.Drawing.Size(164, 22);
			this.timeRestoreParamenterOn.Text = "Bật";
			this.timeRestoreParamenterOn.Click += new System.EventHandler(this.timeRestoreParamenterOn_Click);
			// 
			// timeRestoreParamenterOff
			// 
			this.timeRestoreParamenterOff.Image = ((System.Drawing.Image)(resources.GetObject("timeRestoreParamenterOff.Image")));
			this.timeRestoreParamenterOff.Name = "timeRestoreParamenterOff";
			this.timeRestoreParamenterOff.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
			this.timeRestoreParamenterOff.Size = new System.Drawing.Size(164, 22);
			this.timeRestoreParamenterOff.Text = "Tắt";
			this.timeRestoreParamenterOff.Click += new System.EventHandler(this.timeRestoreParamenterOff_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// createDeviceBtn
			// 
			this.createDeviceBtn.Image = ((System.Drawing.Image)(resources.GetObject("createDeviceBtn.Image")));
			this.createDeviceBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.createDeviceBtn.Name = "createDeviceBtn";
			this.createDeviceBtn.Size = new System.Drawing.Size(140, 36);
			this.createDeviceBtn.Text = "Tạo device sao lưu";
			this.createDeviceBtn.Click += new System.EventHandler(this.createDeviceBtn_Click);
			// 
			// exitBtn
			// 
			this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
			this.exitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(73, 36);
			this.exitBtn.Text = "Thoát";
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// dataGridViewDatabases
			// 
			this.dataGridViewDatabases.AllowUserToAddRows = false;
			this.dataGridViewDatabases.AllowUserToDeleteRows = false;
			this.dataGridViewDatabases.AutoGenerateColumns = false;
			this.dataGridViewDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDatabases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.databaseidDataGridViewTextBoxColumn});
			this.dataGridViewDatabases.DataSource = this.databasesBindingSource;
			this.dataGridViewDatabases.Dock = System.Windows.Forms.DockStyle.Left;
			this.dataGridViewDatabases.Location = new System.Drawing.Point(0, 39);
			this.dataGridViewDatabases.Name = "dataGridViewDatabases";
			this.dataGridViewDatabases.ReadOnly = true;
			this.dataGridViewDatabases.Size = new System.Drawing.Size(240, 522);
			this.dataGridViewDatabases.TabIndex = 1;
			this.dataGridViewDatabases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Cơ sở dữ liệu";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.nameDataGridViewTextBoxColumn.Width = 240;
			// 
			// databaseidDataGridViewTextBoxColumn
			// 
			this.databaseidDataGridViewTextBoxColumn.DataPropertyName = "database_id";
			this.databaseidDataGridViewTextBoxColumn.HeaderText = "database_id";
			this.databaseidDataGridViewTextBoxColumn.Name = "databaseidDataGridViewTextBoxColumn";
			this.databaseidDataGridViewTextBoxColumn.ReadOnly = true;
			this.databaseidDataGridViewTextBoxColumn.Visible = false;
			// 
			// databasesBindingSource
			// 
			this.databasesBindingSource.DataMember = "databases";
			this.databasesBindingSource.DataSource = this.dS;
			// 
			// dS
			// 
			this.dS.DataSetName = "DS";
			this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxDatabaseName,
            this.toolStripTextBoxSTT});
			this.toolStrip1.Location = new System.Drawing.Point(240, 39);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(744, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(95, 22);
			this.toolStripLabel1.Text = "Tên cơ sở dữ liệu";
			// 
			// toolStripTextBoxDatabaseName
			// 
			this.toolStripTextBoxDatabaseName.Enabled = false;
			this.toolStripTextBoxDatabaseName.Name = "toolStripTextBoxDatabaseName";
			this.toolStripTextBoxDatabaseName.Size = new System.Drawing.Size(150, 25);
			// 
			// toolStripTextBoxSTT
			// 
			this.toolStripTextBoxSTT.Enabled = false;
			this.toolStripTextBoxSTT.Name = "toolStripTextBoxSTT";
			this.toolStripTextBoxSTT.Size = new System.Drawing.Size(50, 25);
			this.toolStripTextBoxSTT.Text = "0";
			// 
			// dataGridViewBackup
			// 
			this.dataGridViewBackup.AllowUserToAddRows = false;
			this.dataGridViewBackup.AllowUserToDeleteRows = false;
			this.dataGridViewBackup.AutoGenerateColumns = false;
			this.dataGridViewBackup.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewBackup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.backupstartdateDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
			this.dataGridViewBackup.DataSource = this.sPSTTBACKUPBindingSource;
			this.dataGridViewBackup.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGridViewBackup.Location = new System.Drawing.Point(240, 64);
			this.dataGridViewBackup.Name = "dataGridViewBackup";
			this.dataGridViewBackup.ReadOnly = true;
			this.dataGridViewBackup.Size = new System.Drawing.Size(744, 231);
			this.dataGridViewBackup.TabIndex = 3;
			this.dataGridViewBackup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBackup_CellClick);
			// 
			// positionDataGridViewTextBoxColumn
			// 
			this.positionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
			this.positionDataGridViewTextBoxColumn.HeaderText = "Bản sao lưu thứ #";
			this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
			this.positionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn1.HeaderText = "Diễn giải";
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// backupstartdateDataGridViewTextBoxColumn
			// 
			this.backupstartdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.backupstartdateDataGridViewTextBoxColumn.DataPropertyName = "backup_start_date";
			this.backupstartdateDataGridViewTextBoxColumn.HeaderText = "Ngày giờ sao lưu";
			this.backupstartdateDataGridViewTextBoxColumn.Name = "backupstartdateDataGridViewTextBoxColumn";
			this.backupstartdateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// usernameDataGridViewTextBoxColumn
			// 
			this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
			this.usernameDataGridViewTextBoxColumn.HeaderText = "User sao lưu";
			this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
			this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sPSTTBACKUPBindingSource
			// 
			this.sPSTTBACKUPBindingSource.DataMember = "SP_STT_BACKUP";
			this.sPSTTBACKUPBindingSource.DataSource = this.dS;
			// 
			// checkBoxWithInit
			// 
			this.checkBoxWithInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxWithInit.AutoSize = true;
			this.checkBoxWithInit.Location = new System.Drawing.Point(504, 310);
			this.checkBoxWithInit.Name = "checkBoxWithInit";
			this.checkBoxWithInit.Size = new System.Drawing.Size(308, 17);
			this.checkBoxWithInit.TabIndex = 4;
			this.checkBoxWithInit.Text = "Xóa tất cả các bản sao lưu cũ truóc khi tạo bản sao lưu mới";
			this.checkBoxWithInit.UseVisualStyleBackColor = true;
			// 
			// groupBox
			// 
			this.groupBox.BackColor = System.Drawing.Color.White;
			this.groupBox.Controls.Add(this.richTextBox1);
			this.groupBox.Controls.Add(this.timeEditRestore);
			this.groupBox.Controls.Add(this.dateEditRestore);
			this.groupBox.Controls.Add(this.label1);
			this.groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox.Location = new System.Drawing.Point(240, 352);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(744, 209);
			this.groupBox.TabIndex = 5;
			this.groupBox.TabStop = false;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.BackColor = System.Drawing.Color.White;
			this.richTextBox1.Enabled = false;
			this.richTextBox1.Location = new System.Drawing.Point(229, 71);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(343, 118);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// timeEditRestore
			// 
			this.timeEditRestore.EditValue = new System.DateTime(2020, 4, 18, 0, 0, 0, 0);
			this.timeEditRestore.Location = new System.Drawing.Point(472, 23);
			this.timeEditRestore.Name = "timeEditRestore";
			this.timeEditRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.timeEditRestore.Size = new System.Drawing.Size(100, 20);
			this.timeEditRestore.TabIndex = 2;
			// 
			// dateEditRestore
			// 
			this.dateEditRestore.EditValue = null;
			this.dateEditRestore.Location = new System.Drawing.Point(326, 23);
			this.dateEditRestore.Name = "dateEditRestore";
			this.dateEditRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEditRestore.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEditRestore.Size = new System.Drawing.Size(136, 20);
			this.dateEditRestore.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(178, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thời điểm bạn muốn phụ hồi";
			// 
			// databasesTableAdapter
			// 
			this.databasesTableAdapter.ClearBeforeFill = true;
			// 
			// sP_STT_BACKUPTableAdapter
			// 
			this.sP_STT_BACKUPTableAdapter.ClearBeforeFill = true;
			// 
			// BackupAndRestore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.groupBox);
			this.Controls.Add(this.checkBoxWithInit);
			this.Controls.Add(this.dataGridViewBackup);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dataGridViewDatabases);
			this.Controls.Add(this.toolStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "BackupAndRestore";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sao lưu - phục hồi cơ sở dữ liệu trong SQL Server";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BackupAndRestore_FormClosed);
			this.Load += new System.EventHandler(this.BackupAndRestore_Load);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabases)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sPSTTBACKUPBindingSource)).EndInit();
			this.groupBox.ResumeLayout(false);
			this.groupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeEditRestore.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditRestore.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditRestore.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton backUpBtn;
		private System.Windows.Forms.ToolStripButton restoreBtn;
		private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButtonTimeRestore;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton createDeviceBtn;
		private System.Windows.Forms.ToolStripButton exitBtn;
		private System.Windows.Forms.DataGridView dataGridViewDatabases;
		private DS dS;
		private System.Windows.Forms.BindingSource databasesBindingSource;
		private DSTableAdapters.databasesTableAdapter databasesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn databaseidDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxDatabaseName;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSTT;
		private System.Windows.Forms.DataGridView dataGridViewBackup;
		private System.Windows.Forms.BindingSource sPSTTBACKUPBindingSource;
		private DSTableAdapters.SP_STT_BACKUPTableAdapter sP_STT_BACKUPTableAdapter;
		private System.Windows.Forms.CheckBox checkBoxWithInit;
		private System.Windows.Forms.GroupBox groupBox;
		private DevExpress.XtraEditors.TimeEdit timeEditRestore;
		private DevExpress.XtraEditors.DateEdit dateEditRestore;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ToolStripMenuItem timeRestoreParamenterOn;
		private System.Windows.Forms.ToolStripMenuItem timeRestoreParamenterOff;
		private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn backupstartdateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
	}
}