using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAdmin
{
	static class Program
	{
		/// <summary>
		public static SqlConnection connect = new SqlConnection();
		public static String connectString = "";
		public static LoginForm loginForm;
		public static string database="tempdb";
		public static string serverLogin;
		public static string password;
		public static string servername;

		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			loginForm = new LoginForm();
			Application.Run(loginForm);
		}

		public static int KetNoi()
		{
			//neu chung ta dang co connection va trang thai ket noi hien tai dang mo
			if (Program.connect != null && Program.connect.State == ConnectionState.Open)
			{
				Program.connect.Close();// dong ket noi
			}

			try
			{
				Program.connectString = "Data Source=" + Program.servername + ";Initial Catalog=" +
						  Program.database + ";User ID=" +
						  Program.serverLogin + ";password=" + Program.password;
				Program.connect.ConnectionString = Program.connectString;
				Program.connect.Open();
				return 1;
			}
			catch (Exception)
			{
				return 0;
			}
		}

		public static SqlDataReader ExecSqlDataReader(String strLenh)
		{
			SqlDataReader myreader;
			SqlCommand sqlcmd = new SqlCommand(strLenh, Program.connect);
			sqlcmd.CommandType = CommandType.Text;

			if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();

			try
			{
				myreader = sqlcmd.ExecuteReader();
				return myreader;
			}
			catch (SqlException ex)
			{
				Program.connect.Close();
				MessageBox.Show(ex.Message);
				return null;
			}
		}
	}
}
