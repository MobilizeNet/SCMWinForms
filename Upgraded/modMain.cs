using System;
using System.Data.Common;
using System.IO;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;

namespace StarCarsManagement
{
	internal static class modMain
	{


		public static string connString = "";
		public static DbConnection conn = null;
		public static ADORecordSetHelper rs2 = null, rs = null, rs3 = null;

		internal static void OpenConnection()
		{
			conn = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateConnection();
			//UPGRADE_TODO: (7010) The connection string must be verified to fullfill the .NET data provider connection string requirements. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-7010
			conn.ConnectionString = connString;
			conn.Open();
		}

		//UPGRADE_WARNING: (1047) Application will terminate when Sub Main() finishes. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-1047
		[STAThread]
		public static void Main()
		{
			UpgradeSupport.helpSupport.HelpFile = "C:\\repos\\StarCarsManagement\\SCM_Help.chm";
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			UpgradeSupport.helpSupport.HelpFile = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\SCM_Help.chm";
			connString = $"{CommonFunctions.ReadFile("db.txt")}{Path.GetDirectoryName(Application.ExecutablePath)}\\database.mdb;Persist Security Info=False";

			OpenConnection();
			try
			{
				Application.Run(frmMain.DefInstance);
			}
			catch
			{
			}

			return;
		}

		internal static void ExecuteSQL(string query)
		{
			rs = new ADORecordSetHelper();
			rs.Open(query, conn, UpgradeHelpers.DB.LockTypeEnum.LockPessimistic);
		}

		internal static void ExecuteSQL2(string query)
		{
			rs2 = new ADORecordSetHelper();
			rs2.Open(query, conn, UpgradeHelpers.DB.LockTypeEnum.LockPessimistic);
		}

		internal static void ExecuteSQL3(string query)
		{
			rs3 = new ADORecordSetHelper();
			rs3.Open(query, conn, UpgradeHelpers.DB.LockTypeEnum.LockPessimistic);
		}
	}
}