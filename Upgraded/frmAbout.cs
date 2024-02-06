using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal partial class frmAbout
		: System.Windows.Forms.Form
	{

		public frmAbout()
			: base()
		{
			if (m_vb6FormDefInstance is null)
			{
				if (m_InitializingDefInstance)
				{
					m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						//For the start-up form, the first instance created is the default instance.
						if (!(System.Reflection.Assembly.GetExecutingAssembly().EntryPoint is null) && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							m_vb6FormDefInstance = this;
						}
					}
					catch
					{
					}
				}
			}
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			ReLoadForm(false);
		}


		private void frmAbout_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}

		// Reg Key Security Options...
		const int READ_CONTROL = 0x20000;
		const int KEY_QUERY_VALUE = 0x1;
		const int KEY_SET_VALUE = 0x2;
		const int KEY_CREATE_SUB_KEY = 0x4;
		const int KEY_ENUMERATE_SUB_KEYS = 0x8;
		const int KEY_NOTIFY = 0x10;
		const int KEY_CREATE_LINK = 0x20;
		const int KEY_ALL_ACCESS = KEY_QUERY_VALUE + KEY_SET_VALUE + KEY_CREATE_SUB_KEY + KEY_ENUMERATE_SUB_KEYS + KEY_NOTIFY + KEY_CREATE_LINK + READ_CONTROL;

		// Reg Key ROOT Types...
		const int HKEY_LOCAL_MACHINE = unchecked((int) 0x80000002);
		const int ERROR_SUCCESS = 0;
		const int REG_SZ = 1; // Unicode nul terminated string
		const int REG_DWORD = 4; // 32-bit number

		const string gREGKEYSYSINFOLOC = "SOFTWARE\\Microsoft\\Shared Tools Location";
		const string gREGVALSYSINFOLOC = "MSINFO";
		const string gREGKEYSYSINFO = "SOFTWARE\\Microsoft\\Shared Tools\\MSINFO";
		const string gREGVALSYSINFO = "PATH";

		//UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis#2041
		//[DllImport("advapi32.dll", EntryPoint = "RegOpenKeyExA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		//extern public static int RegOpenKeyEx(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, int ulOptions, int samDesired, ref int phkResult);
		//UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis#2041
		//[DllImport("advapi32.dll", EntryPoint = "RegQueryValueExA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		//extern public static int RegQueryValueEx(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int lpReserved, ref int lpType, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpData, ref int lpcbData);
		//UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis#2041
		//[DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		//extern public static int RegCloseKey(int hKey);

		private void cmdSysInfo_Click(Object eventSender, EventArgs eventArgs)
		{
			StartSysInfo();
		}

		private void cmdOK_Click(Object eventSender, EventArgs eventArgs)
		{
			this.Close();
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
		private void Form_Load()
		{
			this.Text = $"About {AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly())}";
			lblVersion.Text = $"Version {FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileMajorPart.ToString()}.{FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileMinorPart.ToString()}.{FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FilePrivatePart.ToString()}";
			lblTitle.Text = AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly());
			lblDescription.Text = $"Application used by the VBUC Team to test some controls in their .NET equivalent.{Environment.NewLine}Additionally, a double jump will be performed by the WebMap Team to test the same controls in their Web equivalent.";
			lblDisclaimer.Text = "Copyright (C) 2022 Mobilize.Net. All rights reserved.";
		}

		public void StartSysInfo()
		{
			try
			{

				_ = 0;
				string SysInfoPath = "";

				// Try To Get System Info Program Path\Name From Registry...
				string tempRefParam3 = gREGKEYSYSINFOLOC;
				string tempRefParam4 = gREGVALSYSINFOLOC;
				string tempRefParam = gREGKEYSYSINFO;
				string tempRefParam2 = gREGVALSYSINFO;
				if (GetKeyValue(HKEY_LOCAL_MACHINE, ref tempRefParam, ref tempRefParam2, ref SysInfoPath))
				{
					// Try To Get System Info Program Path Only From Registry...
				}
				else if (GetKeyValue(HKEY_LOCAL_MACHINE, ref tempRefParam3, ref tempRefParam4, ref SysInfoPath))
				{ 
					// Validate Existance Of Known 32 Bit File Version
					//UPGRADE_WARNING: (2099) Return value for Dir has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2099
					if (FileSystem.Dir($"{SysInfoPath}\\MSINFO32.EXE") != "")
					{
						SysInfoPath = $"{SysInfoPath}\\MSINFO32.EXE";

						// Error - File Can Not Be Found...
					}
					else
					{
						throw new Exception();
					}
					// Error - Registry Entry Can Not Be Found...
				}
				else
				{
					throw new Exception();
				}

				//UPGRADE_TODO: (7005) parameters (if any) must be set using the Arguments property of ProcessStartInfo More Information: https://docs.mobilize.net/vbuc/ewis#7005
				ProcessStartInfo startInfo = new ProcessStartInfo(SysInfoPath);
				startInfo.WindowStyle = ProcessWindowStyle.Normal;
				Process.Start(startInfo);
			}
			catch
			{
				MessageBox.Show("System Information Is Unavailable At This Time", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.OK);
			}

		}

		public bool GetKeyValue(int KeyRoot, ref string KeyName, ref string SubKeyRef, ref string KeyVal)
		{ // Loop Counter
			bool result = false;
			int hKey = 0; // Handle To An Open Registry Key
			int KeyValType = 0; // Data Type Of A Registry Key
			string tmpVal = ""; // Tempory Storage For A Registry Key Value
			int KeyValSize = 0; // Size Of Registry Key Variable
			//------------------------------------------------------------
			// Open RegKey Under KeyRoot {HKEY_LOCAL_MACHINE...}
			//------------------------------------------------------------
			int rc = SCMSupport.PInvoke.SafeNative.advapi32.RegOpenKeyEx(KeyRoot, ref KeyName, 0, KEY_ALL_ACCESS, ref hKey); // Return Code // Open Registry Key

			if (!(rc != ERROR_SUCCESS))
			{ // Handle Error...

				tmpVal = new string((char) 0, 1024); // Allocate Variable Space
				KeyValSize = 1024; // Mark Variable Size

				//------------------------------------------------------------
				// Retrieve Registry Key Value...
				//------------------------------------------------------------
				rc = SCMSupport.PInvoke.SafeNative.advapi32.RegQueryValueEx(hKey, ref SubKeyRef, 0, ref KeyValType, ref tmpVal, ref KeyValSize); // Get/Create Key Value

				if (!(rc != ERROR_SUCCESS))
				{ // Handle Errors

					if (Strings.Asc(tmpVal.Substring(KeyValSize - 1, Math.Min(1, tmpVal.Length - (KeyValSize - 1)))[0]) == 0)
					{ // Win95 Adds Null Terminated String...
						tmpVal = tmpVal.Substring(0, Math.Min(KeyValSize - 1, tmpVal.Length)); // Null Found, Extract From String
					}
					else
					{
						// WinNT Does NOT Null Terminate String...
						tmpVal = tmpVal.Substring(0, Math.Min(KeyValSize, tmpVal.Length)); // Null Not Found, Extract String Only
					}
					//------------------------------------------------------------
					// Determine Key Value Type For Conversion...
					//------------------------------------------------------------
					switch(KeyValType)
					{ // Search Data Types...
						case REG_SZ :  // String Registry Key Data Type 
							KeyVal = tmpVal;  // Copy String Value 
							break;
						case REG_DWORD :  // Double Word Registry Key Data Type 
							for (int i = Strings.Len(tmpVal); i >= 1; i--)
							{ // Convert Each Bit
								KeyVal = $"{KeyVal}{Strings.Asc(tmpVal.Substring(i - 1, Math.Min(1, tmpVal.Length - (i - 1)))[0]).ToString("X")}"; // Build Value Char. By Char.
							} 
							KeyVal = ($"&h{KeyVal}").ToString();  // Convert Double Word To String 
							break;
					}

					result = true; // Return Success
					rc = SCMSupport.PInvoke.SafeNative.advapi32.RegCloseKey(hKey); // Close Registry Key
					return result; // Exit

				}
			}
			// Cleanup After An Error Has Occured...
			KeyVal = ""; // Set Return Val To Empty String // Return Failure
			_ = SCMSupport.PInvoke.SafeNative.advapi32.RegCloseKey(hKey); // Close Registry Key
			return result;
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}