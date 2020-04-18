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
	}
}
