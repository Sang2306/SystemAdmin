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
		public BackupAndRestore()
		{
			InitializeComponent();
			img = timeRestoreParamenterOff.Image;
			groupBox.Visible = false;
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
				try
				{
					sP_STT_BACKUPTableAdapter.Fill(dS.SP_STT_BACKUP, database_name);
				}
				catch (Exception)
				{ }
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

			//Đóng/mở các nút trên giao diện
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
			string logical_device_name = database_name.Trim() + "_DEVICE";
			string command = "BACKUP DATABASE " + database_name + " TO " + logical_device_name;
			if (checkBoxWithInit.Checked)
			{
				//khi nguoi dung chon thi xoa toan bo cac ban backup va backup phien ban moi
				command += " WITH INIT;";
				//Delete các bản backup cũ trong trường hợp một/nhièu bản chưa được phục hồi
				string first = "declare @restore_history_id int\n" +
			   $"select @restore_history_id=restore_history_id from msdb.dbo.restorehistory where destination_database_name='{database_name.Trim()}'\n" +
				"delete from msdb.dbo.restorefilegroup where restore_history_id=@restore_history_id\n" +
				"delete from msdb.dbo.restorefile where restore_history_id=@restore_history_id\n" +
				"delete from msdb.dbo.restorehistory where restore_history_id=@restore_history_id\n";
				//Delete các bản backup cũ trong trường hợp một/nhièu bản chưa được phục hồi
				string second = "DECLARE @media_set_id INT\n" +
				$"select @media_set_id = media_set_id from msdb.dbo.backupmediafamily where logical_device_name='{logical_device_name}'\n" +
				"DECLARE @id INT\n" +
				"DECLARE backupset_ids CURSOR FOR\n" +
				"SELECT backup_set_id FROM msdb.dbo.backupset WHERE media_set_id=@media_set_id\n" +
				"OPEN backupset_ids\n" +
				"FETCH NEXT FROM backupset_ids INTO @id\n" +
				"WHILE @@FETCH_STATUS = 0\n" +
				"BEGIN\n" +
				"   delete from msdb.dbo.backupfilegroup where backup_set_id=@id\n" +
				"   delete from msdb.dbo.backupfile where backup_set_id=@id\n" +
				"   delete from msdb.dbo.Backupset where backup_set_id=@id\n" +
			   $"   delete from msdb.dbo.backupmediafamily where logical_device_name ='{logical_device_name}'\n" +
				"   FETCH NEXT FROM backupset_ids INTO @id\n" +
				"END\n" +
				"CLOSE backupset_ids\n" +
				"DEALLOCATE backupset_ids\n";

				SqlCommand sql = new SqlCommand();
				sql.CommandText = first;
				sql.CommandType = CommandType.Text;
				if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
				sql.Connection = Program.connect;
				sql.ExecuteNonQuery();
				sql.CommandText = second;
				sql.ExecuteNonQuery();
			}
			else
			{
				command += ";";
			}
			Program.ExecSqlDataReader(command).Close();
			sP_STT_BACKUPTableAdapter.Fill(dS.SP_STT_BACKUP, database_name);
		}

		private void dataGridViewBackup_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				string postion = dataGridViewBackup.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
				toolStripTextBoxSTT.Text = postion;
			}
			catch (Exception)
			{ }
		}

		private void restoreBtn_Click(object sender, EventArgs e)
		{
			string restore_command_step_1 = "ALTER DATABASE "+ database_name +" SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
			Program.ExecSqlDataReader(restore_command_step_1).Close();
			string restore_command_step_2 = "USE tempdb";
			Program.ExecSqlDataReader(restore_command_step_2).Close();
			string logicalname = database_name.Trim() + "_DEVICE";
			string restore_command_step_3 = "RESTORE DATABASE " + database_name + " FROM  " + logicalname + "  WITH FILE=" + toolStripTextBoxSTT.Text + ", REPLACE";
			Program.ExecSqlDataReader(restore_command_step_3).Close();
			string restore_command_step_4 = "ALTER DATABASE " + database_name + " SET MULTI_USER";
			Program.ExecSqlDataReader(restore_command_step_4).Close();
			MessageBox.Show("Phục hồi về bản backup thứ " + toolStripTextBoxSTT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
