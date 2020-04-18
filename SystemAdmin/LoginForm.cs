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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			Program.servername = textBoxServerName.Text;
			Program.serverLogin = textBoxLoginName.Text;
			Program.password = textBoxPassword.Text;
			int is_ok = 1;//Program.KetNoi();
			if (is_ok != 0)
			{
				BackupAndRestore form = new BackupAndRestore();
				form.Activate();
				form.Show();
				Visible = false;
			}
			else
			{
				MessageBox.Show("Kiểm tra lại thông tin đăng nhập", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
