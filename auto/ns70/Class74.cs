using System;
using System.Net;
using System.Net.Security;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using ns11;
using ns146;
using ns25;

namespace ns70;

internal class Class74
{
	public bool bool_0;

	public string string_0;

	public SecureString secureString_0;

	public string string_1;

	public object object_0;

	public byte[] byte_0;

	public int int_0;

	private static long long_0 = 0L;

	private static long long_1 = 0L;

	private static long long_2 = 0L;

	private static long long_3 = 0L;

	private static long long_4 = 0L;

	private static long long_5 = 0L;

	private static Random random_0 = new Random();

	public bool bool_1 = false;

	public static bool bool_2 = false;

	public static string string_2;

	public void method_0()
	{
		if (GClass1.long_0 < 0L)
		{
			GClass1.long_0 = 0L;
		}
		try
		{
			method_1();
		}
		catch
		{
		}
		GClass1.int_1++;
	}

	public void method_1()
	{
		while (true)
		{
			if (!Class11.bool_0)
			{
				if (GClass1.gstruct16_0 != null)
				{
					break;
				}
				if (Class11.smethod_28(long_0) <= 1500L)
				{
					Thread.Sleep(150);
					continue;
				}
			}
			long_0 = Class11.smethod_27();
			string text = method_8();
			if (text == null || text == string.Empty)
			{
				break;
			}
			string text2 = Class11.smethod_35(text, "10", Encoding.ASCII.GetBytes(Class11.smethod_0(Class11.char_9)));
			string[] array = text2.Split('\n', '\r');
			GClass1.gstruct16_0 = new GClass1.GStruct16[array.Length];
			int num = 0;
			string[] array2 = array;
			foreach (string text3 in array2)
			{
				if (text3 == null || text3 == string.Empty)
				{
					continue;
				}
				if (text3[0] != 'N')
				{
					string[] array3 = text3.Split('|');
					if (array3[0] == null || array3[0] == string.Empty)
					{
						continue;
					}
					string text4 = array3[0].Replace(" ", string.Empty);
					GClass1.gstruct16_0[num].uint_0 = Class11.smethod_6(text4);
					GClass1.gstruct16_0[num].long_0 = 0L;
					if (text4 != null && text4 != string.Empty)
					{
						_ = text4.Length;
						text4 = string.Empty;
						for (int j = 0; j < text4.Length; j++)
						{
							text4 += "\0";
						}
					}
					if (array3.Length <= 1)
					{
						num++;
						continue;
					}
					string[] array4 = array3[1].Split('.', '/', '-');
					if (array4.Length == 3)
					{
						int num2 = Class11.smethod_11(array4[0]);
						int num3 = Class11.smethod_11(array4[1]);
						int num4 = Class11.smethod_11(array4[2]);
						if (0 < num2 && num2 <= 31 && 0 < num3 && num3 <= 12 && num4 > 0)
						{
							GClass1.gstruct16_0[num].long_0 = new DateTime(num4, num3, num2, 12, 30, 0, 0).Ticks;
						}
					}
					if (array3.Length > 2)
					{
						string[] array5 = array3[2].Split(':');
						if (array5.Length > 1)
						{
							GClass1.gstruct16_0[num].string_0 = array5[0];
							GClass1.gstruct16_0[num].int_0 = Class11.smethod_11(array5[1]);
							if (array5.Length > 2)
							{
								GClass1.gstruct16_0[num].int_2 = Class11.smethod_11(array5[2]);
							}
							if (array5.Length > 3)
							{
								GClass1.gstruct16_0[num].int_1 = Class11.smethod_11(array5[3]);
							}
							if (array5.Length > 4)
							{
								GClass1.gstruct16_0[num].int_3 = Class11.smethod_11(array5[4]);
							}
							if (array5.Length > 5)
							{
								GClass1.gstruct16_0[num].string_2 = array5[5];
							}
						}
						if (array3.Length > 3)
						{
							GClass1.gstruct16_0[num].string_1 = array3[3];
						}
						num++;
					}
					else
					{
						num++;
					}
				}
				else
				{
					GClass1.long_0 = Class11.smethod_37(text3.Substring(1));
				}
			}
			if (num == 0)
			{
				GClass1.gstruct16_0 = null;
			}
			else if (GClass1.gstruct16_0.Length > num)
			{
				Array.Resize(ref GClass1.gstruct16_0, num);
			}
			break;
		}
		bool_0 = true;
	}

	public void method_2()
	{
		Random random = new Random();
		int num = random.Next(100, 400);
		while (true)
		{
			if (!Class11.bool_0 && long_1 > 0L)
			{
				if (Class26.gstruct14_0 != null)
				{
					break;
				}
				if (Class11.smethod_28(long_1) <= 150000L)
				{
					Thread.Sleep(150 + num);
					continue;
				}
			}
			long_1 = Class11.smethod_27();
			string text = method_8();
			if (text == null || text == string.Empty)
			{
				break;
			}
			string[] array = null;
			string[] array2 = text.Split('\n', '\r');
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] != null && array2[i] != string.Empty)
				{
					string[] array3 = array2[i].Split('|');
					int num2 = array3.Length;
					if (num2 < 2 || array3[1] != "1")
					{
					}
					if (array != null)
					{
						Array.Resize(ref array, array.Length + 1);
						array[array.Length - 1] = array2[i];
					}
					else
					{
						array = new string[1] { array2[i] };
					}
				}
			}
			if (array == null)
			{
				break;
			}
			Class26.string_0 = new string[array.Length];
			for (int j = 0; j < array.Length; j++)
			{
				string text2 = string.Empty;
				if (bool_2)
				{
					text2 = array[j].Replace("http://", "https://");
				}
				Class26.string_0[j] = text2;
			}
			new Thread(Class26.smethod_0).Start();
			break;
		}
		long_1 = 0L;
		bool_0 = true;
	}

	public void method_3()
	{
		while (true)
		{
			if (!Class11.bool_0 && long_2 > 0L)
			{
				if (GClass1.long_3 > 0L)
				{
					break;
				}
				if (Class11.smethod_28(long_2) <= 1500L)
				{
					Thread.Sleep(150);
					continue;
				}
			}
			long_2 = Class11.smethod_27();
			string text = method_8();
			if (text != null && !(text == string.Empty))
			{
				GClass1.string_6 = text;
				GClass1.int_2 = 1;
			}
			break;
		}
		bool_0 = true;
	}

	public void method_4()
	{
		while (true)
		{
			if (!Class11.bool_0 && long_3 > 0L)
			{
				if (GClass1.long_2 > 0L)
				{
					break;
				}
				if (Class11.smethod_28(long_3) <= 1500L)
				{
					Thread.Sleep(150);
					continue;
				}
			}
			long_3 = Class11.smethod_27();
			string text = method_8();
			if (text != null && !(text == string.Empty))
			{
				string text2 = Class11.smethod_35(text, "JXKeoXe", Encoding.ASCII.GetBytes("JXKEOXEUKDKLA5H8"));
				if (text2 != null && !(text2 == string.Empty))
				{
					GClass1.long_2 = GClass1.gstruct15_0.long_0;
					GClass1.int_2 = 1;
					GClass1.string_6 = text2;
				}
			}
			break;
		}
		bool_0 = true;
	}

	public void method_5()
	{
		while (true)
		{
			if (!Class11.bool_0 && long_3 > 0L)
			{
				if (GClass1.gstruct15_0.bool_0)
				{
					break;
				}
				if (Class11.smethod_28(long_3) <= 1500L)
				{
					Thread.Sleep(150);
					continue;
				}
			}
			if (byte_0 == null || byte_0.Length == 0)
			{
				break;
			}
			long_3 = Class11.smethod_27();
			string text = method_8();
			if (!GClass1.gstruct15_0.bool_0 && !(text == string.Empty))
			{
				string[] array = text.Split('$');
				if (array.Length >= 2)
				{
					string text2 = Class11.smethod_35(array[1], "JXKeoXe", Encoding.ASCII.GetBytes("JXKEOXEUKDKLA5H8"));
					if (text2 != null && !(text2 == string.Empty))
					{
						string[] array2 = text2.Split('|');
						if (array2.Length >= 2)
						{
							if (!array2[0].Contains(array2[1]))
							{
								GClass1.string_2 = "bang";
								GClass1.gstruct15_0.string_2 = string.Empty;
								GClass1.gstruct15_0.long_1 = string.Empty;
								GClass1.gstruct15_0.uint_1 = null;
								string empty = string.Empty;
								empty = array2[2];
								GClass1.gstruct15_0.string_0 = array2[1];
								GClass1.gstruct15_0.string_1 = array2[0];
								GClass1.gstruct15_0.string_2 = Class11.smethod_16(empty);
								GClass1.gstruct15_0.long_0 = Class11.smethod_37(array2[3]);
								GClass1.gstruct15_0.long_1 = array2[5];
								GClass1.gstruct15_0.int_0 = Class11.smethod_11(array2[4]);
								GClass1.gstruct15_0.uint_0 = Class11.smethod_6(array2[0]);
								GClass1.string_1 = array2[6];
								GClass1.string_0 = array2[7];
								GClass1.int_0 = Class11.smethod_11(array2[8]);
								GClass1.int_7 = Class11.smethod_11(array2[4]);
								if (empty != null && empty != string.Empty)
								{
									string[] array3 = empty.Replace(" ", string.Empty).Replace("-", string.Empty).Split(',', ';');
									GClass1.gstruct15_0.uint_1 = new uint[array3.Length];
									GClass1.gstruct15_0.IPList = new string[array3.Length];
									for (int i = 0; i < array3.Length; i++)
									{
										GClass1.gstruct15_0.uint_1[i] = Class11.smethod_6(array3[i]);
										GClass1.gstruct15_0.IPList[i] = array3[i];
									}
									int length = empty.Length;
									empty = string.Empty;
									for (int j = 0; j < length; j++)
									{
										empty += "\0";
									}
									array3 = null;
								}
								GClass1.gstruct15_0.bool_0 = GClass1.gstruct15_0.uint_0 != 0 && GClass1.gstruct15_0.long_0 > GClass1.long_1 && GClass1.long_1 > 638082106219996160L;
								GClass1.string_6 = string.Empty;
								GClass1.int_2 = 1;
								break;
							}
							GClass1.string_2 = "server";
							GClass1.gstruct15_0.string_2 = string.Empty;
							GClass1.gstruct15_0.long_1 = string.Empty;
							GClass1.gstruct15_0.uint_1 = null;
							GClass1.gstruct15_0.string_0 = array2[1];
							string empty2 = string.Empty;
							empty2 = array2[2];
							GClass1.gstruct15_0.string_0 = array2[1];
							GClass1.gstruct15_0.string_1 = array2[0];
							GClass1.gstruct15_0.string_2 = Class11.smethod_16(empty2);
							GClass1.gstruct15_0.long_0 = Class11.smethod_37(array2[3]);
							GClass1.gstruct15_0.long_1 = array2[5];
							GClass1.gstruct15_0.int_0 = Class11.smethod_11(array2[4]);
							GClass1.gstruct15_0.uint_0 = Class11.smethod_6(array2[0]);
							GClass1.string_1 = array2[6];
							GClass1.string_0 = array2[7];
							GClass1.int_0 = Class11.smethod_11(array2[8]);
							GClass1.int_7 = Class11.smethod_11(array2[4]);
							if (empty2 != null && empty2 != string.Empty)
							{
								string[] array4 = empty2.Replace(" ", string.Empty).Replace("-", string.Empty).Split(',', ';');
								GClass1.gstruct15_0.uint_1 = new uint[array4.Length];
								GClass1.gstruct15_0.IPList = new string[array4.Length];
								for (int k = 0; k < array4.Length; k++)
								{
									GClass1.gstruct15_0.uint_1[k] = Class11.smethod_6(array4[k]);
									GClass1.gstruct15_0.IPList[k] = array4[k];
								}
								int length2 = empty2.Length;
								empty2 = string.Empty;
								for (int l = 0; l < length2; l++)
								{
									empty2 += "\0";
								}
								array4 = null;
							}
							GClass1.gstruct15_0.bool_0 = GClass1.gstruct15_0.uint_0 != 0 && GClass1.gstruct15_0.long_0 > GClass1.long_1 && GClass1.long_1 > 638082106219996160L;
							GClass1.string_6 = string.Empty;
							GClass1.int_2 = 1;
							break;
						}
					}
				}
			}
			if (text != string.Empty && text != null)
			{
				int length3 = text.Length;
				text = string.Empty;
				for (int m = 0; m < length3; m++)
				{
					text += "\0";
				}
			}
			break;
		}
		bool_0 = true;
		byte_0 = null;
	}

	public void method_6()
	{
		while (!Class11.bool_0 && long_4 > 0L && Class11.smethod_28(long_4) <= 1500L)
		{
			Thread.Sleep(150);
		}
		long_4 = Class11.smethod_27();
		string text = method_8();
		string[] array;
		if (text != null && !(text == string.Empty))
		{
			array = text.Split('|');
			string text2 = array[0].Replace(".", "");
			if (Class11.smethod_11(text2) > 0)
			{
				if (GClass1.string_4 == null || !(GClass1.string_4 != string.Empty))
				{
					goto IL_016a;
				}
				string text3 = GClass1.string_4.Replace(".", "");
				while (text3.Length != text2.Length)
				{
					if (text3.Length < text2.Length)
					{
						text3 += "0";
					}
					else
					{
						text2 += "0";
					}
				}
				int num = Class11.smethod_11(text3);
				int num2 = Class11.smethod_11(text2);
				if (num2 >= num)
				{
					if (num2 != num)
					{
						goto IL_016a;
					}
					if (array.Length > 1 && array[1] != string.Empty && array[1] != null)
					{
						GClass1.string_5 = array[1];
					}
				}
			}
		}
		goto IL_019f;
		IL_016a:
		GClass1.string_4 = array[0];
		GClass1.string_3 = array[0];
		if (array.Length > 1 && array[1] != string.Empty && array[1] != null)
		{
			GClass1.string_5 = array[1];
		}
		goto IL_019f;
		IL_019f:
		bool_0 = true;
	}

	public void method_7()
	{
		try
		{
		}
		catch
		{
		}
	}

	private string method_8()
	{
		string result = string.Empty;
		if (string_1 != null && !(string_1 == string.Empty))
		{
			try
			{
				string text = object_0.ToString();
				string text2 = object_0.GetType().ToString().ToUpper();
				if (text2.IndexOf(Class11.smethod_54(Class11.string_12)) > 0)
				{
					text = string.Concat((char[])object_0);
				}
				if (text[0] > 'ÿ')
				{
					text = Class11.smethod_54(text);
				}
				if ((byte)text[0] != 47)
				{
					text = "/" + text;
				}
				if ((smethod_0() != string.Empty && smethod_0().Contains("Windows 10")) || (smethod_0() != string.Empty && smethod_0().Contains("Windows 11")))
				{
					bool_2 = true;
					string_1 = string_1.Replace("http://", "https://");
				}
				Uri uri = new Uri(string_1 + text);
				if (uri.Host != null && !(uri.Host == string.Empty))
				{
					string text3 = uri.Host.ToLower();
					if (text3 != null && !(text3 == string.Empty))
					{
						WebClient webClient = new WebClient();
						if ((smethod_0() != string.Empty && smethod_0().Contains("Windows 10")) || (smethod_0() != string.Empty && smethod_0().Contains("Windows 11")))
						{
							bool_2 = true;
							ServicePointManager.ServerCertificateValidationCallback = (object _003Cp0_003E, X509Certificate _003Cp1_003E, X509Chain _003Cp2_003E, SslPolicyErrors _003Cp3_003E) => true;
                            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072 | (SecurityProtocolType)768 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;
                            webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134");
						}
						byte[] array = null;
						if (string_1[0] != 'f' && string_1[0] != 'F')
						{
							array = webClient.DownloadData(uri);
						}
						else
						{
							if (string_0 != null && string_0 != string.Empty && string_0[0] > 'ÿ')
							{
								string_0 = Class11.smethod_54(string_0);
							}
							webClient.Credentials = new NetworkCredential(string_0, secureString_0);
							array = webClient.DownloadData(uri);
						}
						if (array != null)
						{
							result = Encoding.UTF8.GetString(array, 0, array.Length);
						}
						webClient.CancelAsync();
						webClient.Dispose();
					}
				}
			}
			catch (Exception)
			{
			}
		}
		if (string_0 != string.Empty && string_0 != null)
		{
			int length = string_0.Length;
			string_0 = string.Empty;
			for (int num = 0; num < length; num++)
			{
				string_0 += "\0";
			}
		}
		secureString_0 = null;
		string_0 = null;
		return result;
	}

	private static string smethod_0()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
			_ = (string)registryKey.GetValue("ProductName");
			return "Windows 7";
		}
		catch
		{
			return string.Empty;
		}
	}
}
