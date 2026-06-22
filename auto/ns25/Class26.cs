using System;
using System.IO;
using System.Net;
using System.Threading;
using ns11;
using ns146;
using ns53;

namespace ns25;

internal class Class26
{
	public static string[] string_0 = null;

	public static GStruct14[] gstruct14_0 = null;

	public static void smethod_0()
	{
		int num = 0;
		while (true)
		{
			try
			{
				smethod_1();
				break;
			}
			catch
			{
				Thread.Sleep(300);
				num++;
				if (num < 3)
				{
					continue;
				}
				break;
			}
		}
	}

	public static void smethod_1()
	{
		if (string_0 == null || string_0.Length == 0)
		{
			return;
		}
		int num = 0;
		GStruct14[] array = new GStruct14[string_0.Length];
		for (int i = 0; i < string_0.Length; i++)
		{
			string text = string_0[i];
			if (text == null || text == string.Empty)
			{
				continue;
			}
			string[] array2 = text.Split('|');
			if (array2[0] == string.Empty || array2[0] == null)
			{
				continue;
			}
			array[num].string_1 = array2[0];
			array[num].string_2 = null;
			array[num].int_1 = 30000;
			if (array2.Length > 1)
			{
				array[num].string_2 = array2[1];
			}
			if (array2.Length > 2 && array2[2] != null && array2[2] != string.Empty)
			{
				string[] array3 = array2[2].Split('.', '/', '-');
				if (array3.Length == 3)
				{
					int num2 = Class11.smethod_11(array3[0]);
					int num3 = Class11.smethod_11(array3[1]);
					int num4 = Class11.smethod_11(array3[2]);
					if (0 < num2 && num2 <= 31 && 0 < num3 && num3 <= 12 && num4 > 0)
					{
						long ticks = new DateTime(num4, num3, num2, 12, 30, 0, 0).Ticks;
						array[num].long_0 = ticks;
						array[num].bool_0 = GClass1.long_1 > ticks;
					}
					array[num].string_3 = array2[2];
				}
			}
			if (array2.Length > 3 && array2[3] != null && array2[3] != string.Empty)
			{
				int num5 = Class11.smethod_11(array2[3]);
				if (num5 > 0)
				{
					array[num].int_1 = num5;
				}
			}
			array[num].int_0 = Class11.smethod_11(array[num].string_2);
			if (array[num].int_0 <= 0)
			{
				array[num].string_0 = smethod_4(array[num].string_1);
				if (array[num].string_0 == null)
				{
					continue;
				}
			}
			num++;
		}
		if (num > 0)
		{
			gstruct14_0 = new GStruct14[num];
			for (int j = 0; j < num; j++)
			{
				gstruct14_0[j].string_0 = array[j].string_0;
				gstruct14_0[j].string_1 = array[j].string_1;
				gstruct14_0[j].string_2 = array[j].string_2;
				gstruct14_0[j].long_0 = array[j].long_0;
				gstruct14_0[j].int_0 = array[j].int_0;
				gstruct14_0[j].bool_0 = array[j].bool_0;
				gstruct14_0[j].string_3 = array[j].string_3;
				gstruct14_0[j].int_1 = array[j].int_1;
			}
		}
	}

	private static byte[] smethod_2(string string_1, int int_0 = 15000)
	{
		try
		{
			Uri requestUri = new Uri(string_1);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
			httpWebRequest.Timeout = int_0;
			httpWebRequest.ReadWriteTimeout = int_0;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			MemoryStream memoryStream = new MemoryStream();
			httpWebResponse.GetResponseStream().CopyTo(memoryStream);
			return memoryStream.ToArray();
		}
		catch
		{
		}
		return null;
	}

	private static byte[] smethod_3(string string_1)
	{
		try
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(string_1);
			byte[] result = webClient.DownloadData(address);
			webClient.CancelAsync();
			return result;
		}
		catch
		{
		}
		return null;
	}

	private static string smethod_4(string string_1)
	{
		string text = null;
		try
		{
			byte[] array = smethod_2(string_1);
			if (array == null || array.Length == 0)
			{
				array = smethod_3(string_1);
			}
			if (array != null && array.Length != 0)
			{
				string text2 = Path.GetTempPath();
				if (text2 == null)
				{
					text2 = Class56.string_10;
				}
				while (text2 != null && text2 != string.Empty && (text2[text2.Length - 1] == '\\' || text2[text2.Length - 1] == '/'))
				{
					text2 = text2.Substring(0, text2.Length - 1);
				}
				string[] array2 = string_1.Split('/', '\\');
				text = text2 + "\\" + array2[array2.Length - 1];
				Class11.smethod_51(text, array);
			}
		}
		catch
		{
		}
		return text;
	}
}
