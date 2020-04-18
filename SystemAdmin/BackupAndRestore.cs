using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAdmin
{
	public partial class BackupAndRestore : Form
	{
		public BackupAndRestore()
		{
			InitializeComponent();
		}

		private void BackupAndRestore_FormClosed(object sender, FormClosedEventArgs e)
		{
			Program.loginForm.Close();
		}

		private void BackupAndRestore_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dS.databases' table. You can move, or remove it, as needed.
			this.databasesTableAdapter.Fill(this.dS.databases);

		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			Dispose();
			Program.loginForm.Visible = true;
		}
		Image img = null;
		private void timeRestoreParamenterOn_Click(object sender, EventArgs e)
		{
			timeRestoreParamenterOff.Image = null;
			timeRestoreParamenterOn.Image = img;
			groupBox.Visible = true;
		}

		private void timeRestoreParamenterOff_Click(object sender, EventArgs e)
		{
			img = timeRestoreParamenterOn.Image;
			timeRestoreParamenterOn.Image = null;
			timeRestoreParamenterOff.Image = img;
			groupBox.Visible = false;
		}
	}
}
