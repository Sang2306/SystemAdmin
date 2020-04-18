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
		Image img = null;
		public BackupAndRestore()
		{
			InitializeComponent();
			img = timeRestoreParamenterOn.Image;
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
		
		private void timeRestoreParamenterOn_Click(object sender, EventArgs e)
		{
			timeRestoreParamenterOff.Image = null;
			timeRestoreParamenterOn.Image = img;
			groupBox.Visible = true;
		}

		private void timeRestoreParamenterOff_Click(object sender, EventArgs e)
		{
			timeRestoreParamenterOn.Image = null;
			timeRestoreParamenterOff.Image = img;
			groupBox.Visible = false;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				string database_name = dataGridViewDatabases.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
				//set toolStripTextBoxDatabaseName to the name of database
				toolStripTextBoxDatabaseName.Text = database_name;
			}
			catch (ArgumentOutOfRangeException)
			{
				
			}
		}

		private void createDeviceBtn_Click(object sender, EventArgs e)
		{
			AddDeviceForm form = new AddDeviceForm();
			form.ShowDialog(this);
		}
	}
}
