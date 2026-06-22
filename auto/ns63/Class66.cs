using System;
using Microsoft.Win32;
using ns11;
using ns23;

namespace ns63;

internal class Class66
{
	private static RegistryKey registryKey_0 = null;

	private static RegistryKey registryKey_1 = null;

	public static string string_0 = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\DisallowRun";

	public static string smethod_0()
	{
		try
		{
			string name = "HTTP\\shell\\open\\command";
			using RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(name, writable: false);
			return ((string)registryKey.GetValue(null, null)).Split('"')[1];
		}
		catch
		{
		}
		return string.Empty;
	}

	public static string smethod_1()
	{
		return Class11.smethod_72("C/Z3Cwl3DHKNiQkIAgA=");
	}

	public static string smethod_2(string string_1, string string_2, byte byte_0 = 0, string string_3 = "")
	{
		string text = string.Empty;
		try
		{
			RegistryKey registryKey = ((byte_0 == 0) ? Registry.LocalMachine.OpenSubKey(string_1) : Registry.CurrentUser.OpenSubKey(string_1));
			string_2 = string_2.ToUpper();
			string[] valueNames = registryKey.GetValueNames();
			string[] array = valueNames;
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				if (text2.ToUpper() == string_2)
				{
					text = registryKey.GetValue(text2).ToString();
					break;
				}
			}
			if (text == string.Empty)
			{
				text = string_3;
			}
			registryKey.Close();
		}
		catch
		{
			text = string_3;
			smethod_12(string_1, byte_0);
		}
		return text;
	}

	public static string smethod_3(string string_1, byte byte_0 = 0, string string_2 = "")
	{
		string text = string.Empty;
		string name = smethod_1();
		try
		{
			RegistryKey registryKey;
			if (byte_0 == 0)
			{
				if (registryKey_0 == null)
				{
					registryKey_0 = Registry.LocalMachine.OpenSubKey(name);
				}
				registryKey = registryKey_0;
			}
			else
			{
				if (registryKey_1 == null)
				{
					registryKey_1 = Registry.CurrentUser.OpenSubKey(name);
				}
				registryKey = registryKey_1;
			}
			string_1 = string_1.ToUpper();
			string[] valueNames = registryKey.GetValueNames();
			string[] array = valueNames;
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				if (text2.ToUpper() == string_1)
				{
					text = registryKey.GetValue(text2).ToString();
					break;
				}
			}
			if (text == string.Empty)
			{
				text = string_2;
			}
		}
		catch
		{
			text = string_2;
			smethod_12(smethod_1(), byte_0);
			registryKey_0 = null;
			registryKey_1 = null;
		}
		return text;
	}

	public static int smethod_4(string string_1, byte byte_0 = 0, string string_2 = "")
	{
		int result = 0;
		string text = smethod_3(string_1, byte_0, string_2);
		if (text != null && text != string.Empty)
		{
			try
			{
				result = Convert.ToInt32(text);
			}
			catch
			{
				result = 0;
			}
		}
		return result;
	}

	public static uint smethod_5(string string_1, byte byte_0 = 0, string string_2 = "")
	{
		uint result = 0u;
		string text = smethod_3(string_1, byte_0, string_2);
		if (text != null && text != string.Empty)
		{
			try
			{
				result = Convert.ToUInt32(text);
			}
			catch
			{
				result = 0u;
			}
		}
		return result;
	}

	public static long smethod_6(string string_1, byte byte_0 = 0, string string_2 = "")
	{
		long result = 0L;
		string text = smethod_3(string_1, byte_0, string_2);
		if (text != null && text != string.Empty)
		{
			try
			{
				result = Convert.ToInt64(text);
			}
			catch
			{
				result = 0L;
			}
		}
		return result;
	}

	public static string smethod_7(string string_1, byte byte_0 = 0, string string_2 = "")
	{
		return smethod_3(string_1, byte_0, string_2);
	}

	public static string smethod_8(string string_1, string string_2, byte byte_0 = 0, string string_3 = "")
	{
		string text = string.Empty;
		try
		{
			string_2 = string_2.ToUpper();
			RegistryKey registryKey = ((byte_0 == 0) ? Registry.LocalMachine.OpenSubKey(string_1) : Registry.CurrentUser.OpenSubKey(string_1));
			string[] valueNames = registryKey.GetValueNames();
			string[] array = valueNames;
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				if (text2.ToUpper() == string_2)
				{
					object value = registryKey.GetValue(text2);
					if (Class11.smethod_1(value.ToString().ToUpper(), "STRING[]") <= 0)
					{
						text = value.ToString();
						break;
					}
					string[] array3 = (string[])value;
					text = array3[0];
					break;
				}
			}
			if (text == "")
			{
				text = string_3;
			}
			registryKey.Close();
		}
		catch
		{
			text = string_3;
			smethod_12(string_1, byte_0);
		}
		return text;
	}

	public static string[] smethod_9(string string_1, bool bool_0 = false)
	{
		try
		{
			RegistryKey registryKey = ((!bool_0) ? Registry.LocalMachine.OpenSubKey(string_1, writable: true) : Registry.CurrentUser.OpenSubKey(string_1, writable: true));
			if (registryKey != null)
			{
				string[] subKeyNames = registryKey.GetSubKeyNames();
				registryKey.Close();
				return subKeyNames;
			}
		}
		catch
		{
		}
		return null;
	}

	public static string[] smethod_10(string string_1, bool bool_0 = false, bool bool_1 = false, int int_0 = 0)
	{
		try
		{
			RegistryKey registryKey = ((!bool_0) ? Registry.LocalMachine.OpenSubKey(string_1, writable: true) : Registry.CurrentUser.OpenSubKey(string_1, writable: true));
			if (registryKey != null)
			{
				string[] array = null;
				if (int_0 > 0)
				{
					if (int_0 != 1)
					{
						array = registryKey.GetValueNames();
						if (array != null && array.Length != 0)
						{
							string[] subKeyNames = registryKey.GetSubKeyNames();
							if (subKeyNames != null)
							{
								int num = array.Length;
								Array.Resize(ref array, num + subKeyNames.Length);
								for (int i = 0; i < subKeyNames.Length; i++)
								{
									array[num + i] = subKeyNames[i];
								}
							}
						}
						else
						{
							array = registryKey.GetSubKeyNames();
						}
					}
					else
					{
						array = registryKey.GetSubKeyNames();
					}
				}
				else
				{
					array = registryKey.GetValueNames();
				}
				if (bool_1 && array != null)
				{
					for (int j = 0; j < array.Length; j++)
					{
						array[j] = registryKey.Name + "\\" + array[j];
					}
				}
				registryKey.Close();
				return array;
			}
		}
		catch
		{
		}
		return null;
	}

	public static bool smethod_11(string string_1, string string_2, object object_0, string string_3 = "", byte byte_0 = 0)
	{
		try
		{
			RegistryKey registryKey = ((byte_0 == 0) ? Registry.LocalMachine.CreateSubKey(string_1) : Registry.CurrentUser.CreateSubKey(string_1));
			if (registryKey != null)
			{
				if (object_0 != null)
				{
					registryKey.SetValue(string_2, object_0, smethod_14(string_3));
				}
				else
				{
					registryKey.SetValue(string_2, string.Empty, smethod_14(string_3));
				}
				registryKey.Close();
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static void smethod_12(string string_1, byte byte_0 = 0)
	{
		try
		{
			if (byte_0 == 0)
			{
				Registry.LocalMachine.CreateSubKey(string_1);
			}
			else
			{
				Registry.CurrentUser.CreateSubKey(string_1);
			}
		}
		catch
		{
		}
	}

	public static void smethod_13(string string_1, string string_2, byte byte_0 = 0)
	{
		try
		{
			if (byte_0 == 3)
			{
				if (string_1.IndexOf("HKEY_LOCAL_MACHINE\\") != 0)
				{
					if (string_1.IndexOf("HKEY_CURRENT_USER\\") == 0)
					{
						byte_0 = 2;
						string_1 = string_1.Replace("HKEY_CURRENT_USER\\", string.Empty);
					}
				}
				else
				{
					byte_0 = 0;
					string_1 = string_1.Replace("HKEY_LOCAL_MACHINE\\", string.Empty);
				}
			}
			RegistryKey registryKey = ((byte_0 == 0) ? Registry.LocalMachine.OpenSubKey(string_1, writable: true) : Registry.CurrentUser.OpenSubKey(string_1, writable: true));
			if (registryKey != null)
			{
				registryKey.DeleteValue(string_2);
				registryKey.Close();
			}
		}
		catch
		{
		}
	}

	private static RegistryValueKind smethod_14(string string_1 = "")
	{
		RegistryValueKind result = RegistryValueKind.String;
		string_1 = string_1.ToUpper();
		if (!(string_1 == "DWORD"))
		{
			if (string_1 == "BINARY")
			{
				result = RegistryValueKind.Binary;
			}
		}
		else
		{
			result = RegistryValueKind.DWord;
		}
		return result;
	}

	public static void smethod_15(string string_1)
	{
		try
		{
			for (int i = 0; i < 10; i++)
			{
				int num = Class24.smethod_54("Regedit");
				if (num == 0)
				{
					break;
				}
				Class24.smethod_48(num);
			}
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit", "LastKey", string_1);
			Class24.smethod_40("regedit.exe", "", "", 0);
		}
		catch
		{
		}
	}
}
