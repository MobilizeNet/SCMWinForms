using System.Runtime.InteropServices;
using System;

namespace SCMSupport.PInvoke.SafeNative
{
	public static class advapi32
	{

		public static int RegCloseKey(int hKey)
		{
			return SCMSupport.PInvoke.UnsafeNative.advapi32.RegCloseKey(hKey);
		}
		public static int RegOpenKeyEx(int hKey, ref string lpSubKey, int ulOptions, int samDesired, ref int phkResult)
		{
			return SCMSupport.PInvoke.UnsafeNative.advapi32.RegOpenKeyEx(hKey, ref lpSubKey, ulOptions, samDesired, ref phkResult);
		}
		public static int RegQueryValueEx(int hKey, ref string lpValueName, int lpReserved, ref int lpType, ref string lpData, ref int lpcbData)
		{
			return SCMSupport.PInvoke.UnsafeNative.advapi32.RegQueryValueEx(hKey, ref lpValueName, lpReserved, ref lpType, ref lpData, ref lpcbData);
		}
	}
}