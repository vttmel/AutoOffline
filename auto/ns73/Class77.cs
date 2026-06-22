using System;
using System.Net;
using System.Net.Sockets;
using ns100;
using ns109;
using ns11;
using ns121;
using ns146;
using ns19;
using ns34;
using ns43;
using ns56;
using ns63;
using ns71;
using ns74;
using ns75;

namespace ns73;

internal class Class77
{
	public static Class78 class78_0 = null;

	public static Class79 class79_0 = null;

	public static long long_0 = 0L;

	public static int int_0 = 0;

	public static int int_1 = Class66.smethod_4("KieuConnect", 0, "0");

	public static string string_0 = null;

	public static int int_2 = Class66.smethod_4("PortServer", 0, "0");

	public static string string_1 = string.Empty;

	public static int int_3 = Class66.smethod_4("nPort", 0, "0");

	public static string string_2 = Class66.smethod_7("ConnectIP", 0);

	private static bool bool_0 = false;

	public static string[] smethod_0()
	{
		string[] array = null;
		try
		{
			IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
			if (addressList != null)
			{
				for (int i = 0; i <= addressList.Length; i++)
				{
					if (addressList[i].AddressFamily == AddressFamily.InterNetwork && (!addressList[i].ToString().Contains(":") & !addressList.ToString().Contains("%")))
					{
						if (array == null)
						{
							array = new string[1] { addressList[i].ToString() };
						}
						else
						{
							Array.Resize(ref array, array.Length + 1);
							array[array.Length - 1] = addressList[i].ToString();
						}
					}
				}
			}
		}
		catch
		{
		}
		return array;
	}

	private static string smethod_1(string string_3, int int_4 = 2)
	{
		if (string_3 == null)
		{
			string_3 = string.Empty;
		}
		while (string_3.Length < int_4)
		{
			string_3 = "0" + string_3;
		}
		return string_3;
	}

	public static string smethod_2()
	{
		DateTime now = DateTime.Now;
		string text = smethod_1(now.Hour.ToString());
		string text2 = smethod_1(now.Minute.ToString());
		string text3 = smethod_1(now.Second.ToString());
		return text + ":" + text2 + ":" + text3;
	}

	private static string smethod_3(string[] string_3, int int_4, int int_5 = 0)
	{
		if ((int_5 <= 0 || int_5 > int_4) && string_3 != null && string_3.Length > int_4)
		{
			string text = string_3[int_4];
			if (text == null)
			{
				text = string.Empty;
			}
			return string_3[int_4];
		}
		return string.Empty;
	}

	public static void smethod_4(string string_3)
	{
		Form1.int_11 = 0;
		Form1.int_10 = 1;
		if (GClass1.long_1 != 0L && !AuxiliaryMachineManager.bool_1)
		{
			if (string_3 == null || string_3 == string.Empty)
			{
				return;
			}
			try
			{
				if (string_3[0] == 'U' && string_3[1] == 'P' && string_3[2] == ':')
				{
					string text = string_3.Substring(3);
					int length = text.Length;
					if (length % 2 > 0)
					{
						text = text.Substring(0, length - 1);
					}
					AuxiliaryMachineManager.smethod_1(text);
					bool_0 = true;
					return;
				}
				if (bool_0)
				{
					bool_0 = false;
					Form1.bool_17 = true;
				}
				int num;
				int num2;
				while (true)
				{
					num = string_3.IndexOf('@');
					num2 = string_3.IndexOf('*');
					if (num2 >= num)
					{
						break;
					}
					string_3 = string_3.Substring(num);
				}
				if (num < 0 || num2 < 0)
				{
					return;
				}
				string text2 = string_3.Substring(num, num2 + 1);
				string[] array = text2.Split('|');
				int num3 = array.Length;
				if (num3 < 44)
				{
					return;
				}
				if (Class46.characterSyncSnapshot_1.uint_4 == null)
				{
					Class46.characterSyncSnapshot_1.uint_4 = new uint[2];
				}
				if (Class46.characterSyncSnapshot_1.int_11 == null)
				{
					Class46.characterSyncSnapshot_1.int_11 = new int[4];
				}
				Form1.int_119 = 0;
				Class46.characterSyncSnapshot_1.int_4 = Class11.smethod_11(smethod_3(array, 1, num3));
				Class46.characterSyncSnapshot_1.int_3 = Class11.smethod_11(smethod_3(array, 2, num3));
				Class46.characterSyncSnapshot_1.uint_4[0] = Class11.smethod_12(smethod_3(array, 3, num3));
				Class46.characterSyncSnapshot_1.uint_4[1] = Class11.smethod_12(smethod_3(array, 4, num3));
				Class46.characterSyncSnapshot_1.int_6 = Class11.smethod_11(smethod_3(array, 5, num3));
				Class46.characterSyncSnapshot_1.uint_3 = Class11.smethod_12(smethod_3(array, 6, num3));
				Form1.int_121 = Class11.smethod_11(smethod_3(array, 7, num3));
				Form1.int_24 = Class11.smethod_11(smethod_3(array, 8, num3));
				Form1.int_113 = Class11.smethod_11(smethod_3(array, 9, num3));
				Form1.int_115 = Class11.smethod_11(smethod_3(array, 10, num3));
				Class20.int_0 = Class11.smethod_11(smethod_3(array, 11, num3));
				Form1.int_26 = Class11.smethod_11(smethod_3(array, 12, num3));
				Form1.int_34 = Class11.smethod_11(smethod_3(array, 13, num3));
				Form1.int_35 = Class11.smethod_11(smethod_3(array, 14, num3));
				Form1.int_36 = Class11.smethod_11(smethod_3(array, 15, num3));
				Class46.characterSyncSnapshot_1.int_10 = Class11.smethod_11(smethod_3(array, 16, num3));
				Class46.characterSyncSnapshot_1.int_2 = Class11.smethod_11(smethod_3(array, 17, num3));
				Form1.int_28 = Class11.smethod_11(smethod_3(array, 18, num3));
				Form1.int_94 = 1;
				Form1.int_95 = Class11.smethod_11(smethod_3(array, 20, num3));
				FormDame.int_6 = Class11.smethod_11(smethod_3(array, 21, num3));
				FormDame.int_9 = Class11.smethod_11(smethod_3(array, 22, num3));
				FormDame.int_11 = Class11.smethod_11(smethod_3(array, 23, num3));
				Class46.characterSyncSnapshot_1.uint_5 = Class11.smethod_12(smethod_3(array, 24, num3));
				Class46.characterSyncSnapshot_1.int_7 = Class11.smethod_11(smethod_3(array, 25, num3));
				Class46.characterSyncSnapshot_1.uint_3 = Class11.smethod_12(smethod_3(array, 26, num3));
				Form1.int_37 = Class11.smethod_11(smethod_3(array, 27, num3));
				Form1.int_38 = Class11.smethod_11(smethod_3(array, 28, num3));
				Form1.int_25 = Class11.smethod_11(smethod_3(array, 29, num3));
				Class46.characterSyncSnapshot_1.int_9 = Class11.smethod_11(smethod_3(array, 30, num3));
				Class46.characterSyncSnapshot_1.uint_2 = Class11.smethod_12(smethod_3(array, 31, num3));
				Form1.int_96 = Class11.smethod_11(smethod_3(array, 32, num3));
				Class46.characterSyncSnapshot_1.int_8 = Class11.smethod_11(smethod_3(array, 33, num3));
				Class46.characterSyncSnapshot_0.int_8 = Class11.smethod_11(smethod_3(array, 34, num3));
				Form1.int_48[0] = Class11.smethod_11(smethod_3(array, 35, num3));
				Form1.int_48[1] = Class11.smethod_11(smethod_3(array, 36, num3));
				Form1.int_4 = Class11.smethod_11(smethod_3(array, 37, num3));
				Class37.int_1 = Class11.smethod_11(smethod_3(array, 38, num3));
				Form1.int_112 = Class11.smethod_11(smethod_3(array, 39, num3));
				Form1.string_37 = smethod_3(array, 40, num3);
				Form1.int_89 = Class11.smethod_11(smethod_3(array, 41, num3));
				Form1.int_81 = Class11.smethod_11(smethod_3(array, 42, num3));
				Form1.int_120 = Class11.smethod_11(smethod_3(array, 43, num3));
				if (num3 <= 44)
				{
					return;
				}
				int num4 = Class11.smethod_11(smethod_3(array, 44, num3));
				if (num4 <= 0 || Form1.characterAccountConfig_1 == null)
				{
					return;
				}
				for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
				{
					if (num4 == 1 && Form1.characterAccountConfig_1[i].bool_25)
					{
						Class75.smethod_2(Form1.characterAccountConfig_1[i], Class75.uint_22, 1, 4);
					}
					else
					{
						Class75.smethod_2(Form1.characterAccountConfig_1[i], Class75.uint_22, 0, 4);
					}
				}
				return;
			}
			catch
			{
				return;
			}
		}
		Class46.characterSyncSnapshot_1.int_4 = 0;
		Class46.characterSyncSnapshot_1.int_0 = 0;
		Class46.characterSyncSnapshot_1.int_6 = 0;
	}

	public static string smethod_5()
	{
		Form1.int_10 = 0;
		uint num = 0u;
		uint num2 = 0u;
		int int_ = Class46.characterSyncSnapshot_0.int_4;
		if (Class46.characterSyncSnapshot_0.uint_4 != null)
		{
			num = Class46.characterSyncSnapshot_0.uint_4[0];
			num2 = Class46.characterSyncSnapshot_0.uint_4[1];
		}
		if (num != 0 && num2 != 0 && int_ > 0)
		{
			string text = "0";
			if (Class59.int_0 > 0)
			{
				if (Class11.smethod_28(Class59.long_0) < 1500L)
				{
					text = Class59.int_0.ToString();
				}
				else
				{
					Class59.int_0 = 0;
				}
			}
			string result = "@|" + int_ + "|" + Class46.characterSyncSnapshot_0.int_3 + "|" + num + "|" + num2 + "|" + Class46.characterSyncSnapshot_0.int_6 + "|" + Class46.characterSyncSnapshot_0.uint_3 + "|" + Form1.int_121 + "|" + Form1.int_24 + "|" + Form1.int_113 + "|" + Form1.int_115 + "|" + Class20.int_0 + "|" + Form1.int_26 + "|" + Form1.int_34 + "|" + Form1.int_35 + "|" + Form1.int_36 + "|" + Form1.int_29 + "|" + Class46.characterSyncSnapshot_0.int_2 + "|" + Form1.int_28 + "|" + Form1.int_94 + "|" + Form1.int_95 + "|" + FormDame.int_6 + "|" + FormDame.int_9 + "|" + FormDame.int_11 + "|" + Class46.characterSyncSnapshot_0.uint_5 + "|" + Class46.characterSyncSnapshot_0.int_7 + "|" + Class46.characterSyncSnapshot_0.uint_3 + "|" + Form1.int_37 + "|" + Form1.int_38 + "|" + Form1.int_25 + "|" + Class46.characterSyncSnapshot_0.int_9 + "|" + Class46.characterSyncSnapshot_0.uint_2 + "|" + Form1.int_96 + "|" + Class46.characterSyncSnapshot_0.int_8 + "|" + Class46.characterSyncSnapshot_0.int_8 + "|" + Form1.int_48[0] + "|" + Form1.int_48[1] + "|" + Form1.int_4 + "|" + Class37.int_1 + "|" + Form1.int_112 + "|" + Form1.string_37.Replace(" ", "").Replace(",", "_") + "|" + Form1.int_89 + "|" + Form1.int_81 + "|" + Form1.int_120 + "|" + text + "|*";
			Class46.characterSyncSnapshot_0.int_9 = 0;
			return result;
		}
		return string.Empty;
	}
}
