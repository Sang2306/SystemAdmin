using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAdmin
{
	static class Program
	{
		/// <summary>
		public static LoginForm loginForm;
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			loginForm = new LoginForm();
			Application.Run(loginForm);
		}
	}
}
