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
		DateTime latestBackupRecordDate;
		DateTime selectedBackupRecordDate; //Khi click vao 1 ban backup se luu lai ngay gio cua ban backup(su dung trong truong hop xoa ban backup)
		bool timeParameterChecked = false;
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
			timeParameterChecked = true;
			groupBox.Visible = true;
		}

		private void timeRestoreParamenterOff_Click(object sender, EventArgs e)
		{
			timeRestoreParamenterOn.Image = null;
			timeRestoreParamenterOff.Image = img;
			timeParameterChecked = false;
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
					if (dataGridViewBackup.RowCount == 0)
					{
						toolStripTextBoxSTT.Text = "--";
					}
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
			//tạo device de backup database
			string logicalname = database_name.Trim() + "_DEVICE";
			string physicalname = Program.backup_device_path + logicalname + ".bak";
			string devtype = "disk";
			SqlCommand sql_command_1 = new SqlCommand("sp_addumpdevice", Program.connect);
			sql_command_1.CommandType = CommandType.StoredProcedure;
			sql_command_1.Parameters.AddWithValue("@devtype", devtype);
			sql_command_1.Parameters.AddWithValue("@logicalname ", logicalname);
			sql_command_1.Parameters.AddWithValue("@physicalname ", physicalname);
			if (Program.execStoreProcedureWithReturnValue(sql_command_1) ==1)
			{
				MessageBox.Show("Không thể tạo device", "Lỗi tạo device", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}



			//tao device de backup log trong truong hop nguoi dung backup co tham so thoi gian
			logicalname = database_name.Trim() + "_DEVICE" + "_LOG";
			physicalname = Program.backup_device_path + logicalname + ".bak";
			SqlCommand sql_command_2 = new SqlCommand("sp_addumpdevice", Program.connect);
			sql_command_2.CommandType = CommandType.StoredProcedure;
			sql_command_2.Parameters.AddWithValue("@devtype", devtype);
			sql_command_2.Parameters.AddWithValue("@logicalname ", logicalname);
			sql_command_2.Parameters.AddWithValue("@physicalname ", physicalname);
			if (Program.execStoreProcedureWithReturnValue(sql_command_2) == 1)
			{
				MessageBox.Show("Không thể tạo device để backup log", "Lỗi tạo device", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
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
				//truong hop da co 1/nhieu ban backup đã dc phuc hoi
				string first = "declare restore_history_id_set cursor for\n" +
				$"select restore_history_id from msdb.dbo.restorehistory where destination_database_name='{database_name.Trim()}';\n" +
				"declare @restore_history_id int\n" +
				"open restore_history_id_set\n" +
				"fetch next from restore_history_id_set into @restore_history_id\n" +
				"while @@FETCH_STATUS = 0\n" +
				"begin\n" +
				"	delete from msdb.dbo.restorefilegroup where restore_history_id=@restore_history_id\n" +
				"	delete from msdb.dbo.restorefile where restore_history_id=@restore_history_id\n" +
				"	delete from msdb.dbo.restorehistory where restore_history_id=@restore_history_id\n" +
				"	fetch next from restore_history_id_set into @restore_history_id\n" +
				"end\n" +
				"close restore_history_id_set\n" +
				"deallocate restore_history_id_set\n";
				//Xoa cac ban backup cu
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

			try
			{
				Program.ExecSqlDataReader(command).Close();
				sP_STT_BACKUPTableAdapter.Fill(dS.SP_STT_BACKUP, database_name);
			}
			catch (Exception)
			{ }
		}

		private void dataGridViewBackup_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				string postion = dataGridViewBackup.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
				toolStripTextBoxSTT.Text = postion;
				DateTime dateTime = (DateTime)dataGridViewBackup.Rows[e.RowIndex].Cells[2].Value;
				dateEditRestore.DateTime = dateTime;
				timeEditRestore.Time = dateTime;

				//de lat nua xoa dua vao ngay gio cua ban backup
				selectedBackupRecordDate = dateTime;
			}
			catch (Exception)
			{ }
		}

		private void restoreBtn_Click(object sender, EventArgs e)
		{

			if (toolStripTextBoxSTT.Text == "--")
			{
				MessageBox.Show("Không có bất kỳ bản sao lưu được chọn để phục hồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			string logical_device_name = database_name.Trim() + "_DEVICE";
			//kiem tra thamm so thoi gian co dc chon hay khong
			if (timeParameterChecked)
			{
				DateTime date = dateEditRestore.DateTime;
				DateTime time = timeEditRestore.Time;
				DateTime chooseRestoreTime = DateTime.Parse($"{date.Year}-{date.Month}-{date.Day} {time.TimeOfDay}");
				//kiem tra thoi diem chon phuc hoi < thoi diem hien tai 1 phut khong?
				if (DateTime.Compare(DateTime.Now, chooseRestoreTime.AddMinutes(1)) < 0)
				{
					MessageBox.Show($"Thời điểm phục hồi phải trước {DateTime.Now} ít nhất 1 phút\nXem hướng dẫn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else if (DateTime.Compare(latestBackupRecordDate.AddMinutes(1), chooseRestoreTime) > 0)
				{
					MessageBox.Show($"Thời điểm phục hồi phải sau bản backup gần nhất vào {latestBackupRecordDate} ít nhất 1 phút\nXem hướng dẫn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				string at = $"{date.Year}-{date.Month}-{date.Day} {time.TimeOfDay}";
				try
				{
					Program.ExecSqlDataReader($"ALTER DATABASE {database_name} SET SINGLE_USER WITH ROLLBACK IMMEDIATE\n").Close();

					Program.ExecSqlDataReader($"BACKUP LOG {database_name} TO {logical_device_name}_LOG WITH NORECOVERY, INIT\n").Close();

					Program.ExecSqlDataReader($"RESTORE DATABASE {database_name} FROM {logical_device_name} WITH NORECOVERY").Close();

					Program.ExecSqlDataReader($"RESTORE DATABASE {database_name} FROM {logical_device_name}_LOG WITH STOPAT='{at}'\n").Close();

					Program.ExecSqlDataReader($"ALTER DATABASE {database_name} SET MULTI_USER\n").Close();

					MessageBox.Show("Phục hồi về thời điểm " + at, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception)
				{
					MessageBox.Show("Thời điểm chọn phục hồi không khả thi\nHoặc quá trình phục hồi đang diễn ra...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				//phuc hoi ve ban backup trong device
				string restore =
					$"ALTER DATABASE {database_name} SET SINGLE_USER WITH ROLLBACK IMMEDIATE\n" +
					"USE tempdb\n" +
					$"RESTORE DATABASE {database_name} FROM {logical_device_name}  WITH FILE={toolStripTextBoxSTT.Text}, REPLACE\n" +
					$"ALTER DATABASE {database_name} SET MULTI_USER";
				try
				{
					Program.ExecSqlDataReader(restore).Close();
					MessageBox.Show("Phục hồi về bản backup thứ " + toolStripTextBoxSTT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception)
				{ }
			}
		}

		private void dataGridViewBackup_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
		{
			//Khi load danh sach cac ban backup cua database thi ngay/thang backup da dc sap xep theo thu tu giam dan
			//va cell dang dung tai row tren cung
			try
			{
				string postion = dataGridViewBackup.Rows[e.Cell.RowIndex].Cells[0].FormattedValue.ToString();
				toolStripTextBoxSTT.Text = postion;
				latestBackupRecordDate = (DateTime)dataGridViewBackup.Rows[e.Cell.RowIndex].Cells[2].Value;
				dateEditRestore.DateTime = latestBackupRecordDate;
				timeEditRestore.Time = latestBackupRecordDate;

				//de lat nua xoa dua vao ngay gio cua ban backup
				selectedBackupRecordDate = latestBackupRecordDate;
			}
			catch (Exception)
			{ }
		}

		private void dataGridViewBackup_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				contextMenuStrip.Show(Cursor.Position);
			}
		}

		private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show($"Bạn có đồng ý xóa bản backup {selectedBackupRecordDate.ToString("yyyy-MM-dd HH:mm:ss.fff")} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				//Xóa bản backup trong database
				string delete = "declare @backup_set_id int;" +
							$"select @backup_set_id=backup_set_id from msdb.dbo.backupset bks where bks.database_name='{database_name}' and bks.backup_start_date='{selectedBackupRecordDate.ToString("yyyy-MM-dd HH:mm:ss.fff")}';" +
							"declare @restore_history_id int;" +
							"select @restore_history_id=restore_history_id from msdb.dbo.restorehistory where backup_set_id=@backup_set_id;" +
							"delete from msdb.dbo.restorefilegroup where restore_history_id=@restore_history_id;" +
							"delete from msdb.dbo.restorefile where restore_history_id=@restore_history_id;" +
							"delete from msdb.dbo.restorehistory where backup_set_id=@backup_set_id;" +
							"delete from msdb.dbo.backupfilegroup where backup_set_id=@backup_set_id;" +
							"delete from msdb.dbo.backupfile where backup_set_id=@backup_set_id;" +
							"delete from msdb.dbo.Backupset where backup_set_id=@backup_set_id;";
				SqlCommand sql = new SqlCommand();
				sql.CommandType = CommandType.Text;
				sql.CommandText = delete;
				if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
				sql.Connection = Program.connect;
				sql.ExecuteNonQuery();
				//todo xoá xong tạo backup mới không được


				//Fill lại dữ liệu
				sP_STT_BACKUPTableAdapter.Fill(dS.SP_STT_BACKUP, database_name);

				MessageBox.Show("Đã xóa thành công! " + selectedBackupRecordDate);
			}
		}
	}
}
