using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
		string database_name;
		string selected_logical_name;
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

			try
			{
				database_name = dataGridViewDatabases.Rows[0].Cells[0].FormattedValue.ToString();
				//set toolStripTextBoxDatabaseName to the name of database
				toolStripTextBoxDatabaseName.Text = database_name;
				//kiểm tra xem back up device đã được tạo cho cơ sở dữ liệu đang chọn hay chưa
				string logicalname = database_name.Trim() + "_DEVICE";
				checkIfDeviceExisted(logicalname);
				sP_STT_BACKUPTableAdapter.Fill(dS.SP_STT_BACKUP, database_name);
			}
			catch (Exception){}

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
				database_name = dataGridViewDatabases.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
				//set toolStripTextBoxDatabaseName to the name of database
				toolStripTextBoxDatabaseName.Text = database_name;
				//kiểm tra xem back up device đã được tạo cho cơ sở dữ liệu đang chọn hay chưa
				string logicalname = database_name.Trim() + "_DEVICE";
				checkIfDeviceExisted(logicalname);
				//show các bản backup của database đã chọn
				sP_STT_BACKUPTableAdapter.Fill(dS.SP_STT_BACKUP, database_name);
			}
			catch (ArgumentOutOfRangeException)
			{
				
			}
		}

		private void createDeviceBtn_Click(object sender, EventArgs e)
		{
			//tạo device
			string logicalname = database_name.Trim() + "_DEVICE";
			string physicalname = Program.backup_device_path + logicalname + ".bak";
			string devtype = "disk";
			SqlCommand sql_command = new SqlCommand("sp_addumpdevice", Program.connect);
			sql_command.CommandType = CommandType.StoredProcedure;
			sql_command.Parameters.AddWithValue("@devtype", devtype);
			sql_command.Parameters.AddWithValue("@logicalname ", logicalname);
			sql_command.Parameters.AddWithValue("@physicalname ", physicalname);
			if (Program.execStoreProcedureWithReturnValue(sql_command)==1)
			{
				MessageBox.Show("Không thể tạo device", "Lỗi tạo device", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			createDeviceBtn.Enabled = false;
			backUpBtn.Enabled = true;
			restoreBtn.Enabled = true;
			toolStripSplitButtonTimeRestore.Enabled = true;
		}
		private Boolean checkIfDeviceExisted(string logicalname)
		{
			string command = "SELECT name FROM sys.backup_devices WHERE name='" + logicalname + "'";
			SqlDataReader reader = Program.ExecSqlDataReader(command);
			try
			{
				if (!reader.HasRows)
				{
					createDeviceBtn.Enabled = true;
					backUpBtn.Enabled = false;
					restoreBtn.Enabled = false;
					toolStripSplitButtonTimeRestore.Enabled = false;
					selected_logical_name = "";
					return false;
				}
				createDeviceBtn.Enabled = false;
				backUpBtn.Enabled = true;
				restoreBtn.Enabled = true;
				toolStripSplitButtonTimeRestore.Enabled = true;
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thực thi lệnh kiểm tra tồn tại device cho db" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			finally
			{
				reader.Close();
				Program.connect.Close();
			}
		}

		private void backUpBtn_Click(object sender, EventArgs e)
		{
			string command = "BACKUP DATABASE " + database_name + " TO " + database_name.Trim() + "_DEVICE";
			if (checkBoxWithInit.Checked)
			{
				command += " WITH INIT;";
			}else
			{
				command += ";";
			}
			Program.ExecSqlDataReader(command).Close();
			sP_STT_BACKUPTableAdapter.Fill(dS.SP_STT_BACKUP, database_name);
		}
	}
}
