using System.IO;
using System.Net;
using ns147;

namespace ns69;

internal class Class73
{
	public static FileInfo smethod_0(string string_0, string string_1)
	{
		string value = "drive.google.com";
		string value2 = "https://drive.google.com";
		if (!string_0.StartsWith(value) && !string_0.StartsWith(value2))
		{
			return smethod_1(string_0, string_1, null);
		}
		return smethod_2(string_0, string_1);
	}

	private static FileInfo smethod_1(string string_0, string string_1, WebClient webClient_0)
	{
		try
		{
			if (webClient_0 == null)
			{
				using (webClient_0 = new WebClient())
				{
					webClient_0.DownloadFile(string_0, string_1);
					return new FileInfo(string_1);
				}
			}
			webClient_0.DownloadFile(string_0, string_1);
			return new FileInfo(string_1);
		}
		catch (WebException)
		{
			return null;
		}
	}

	private static FileInfo smethod_2(string string_0, string string_1)
	{
		string_0 = smethod_3(string_0);
		using GClass2 webClient_ = new GClass2();
		for (int i = 0; i < 2; i++)
		{
			FileInfo fileInfo = smethod_1(string_0, string_1, webClient_);
			if (fileInfo != null)
			{
				if (fileInfo.Length <= 60000L)
				{
					string text;
					using (StreamReader streamReader = fileInfo.OpenText())
					{
						char[] array = new char[20];
						int num = streamReader.ReadBlock(array, 0, 20);
						if (num < 20 || !new string(array).Contains("<!DOCTYPE html>"))
						{
							return fileInfo;
						}
						text = streamReader.ReadToEnd();
					}
					int num2 = text.LastIndexOf("href=\"/uc?");
					if (num2 >= 0)
					{
						num2 += 6;
						int num3 = text.IndexOf('"', num2);
						if (num3 >= 0)
						{
							string_0 = "https://drive.google.com" + text.Substring(num2, num3 - num2).Replace("&amp;", "&");
							continue;
						}
						return fileInfo;
					}
					return fileInfo;
				}
				return fileInfo;
			}
			return null;
		}
		return smethod_1(string_0, string_1, webClient_);
	}

	private static string smethod_3(string string_0)
	{
		int num = string_0.IndexOf("id=");
		int num2;
		if (num > 0)
		{
			num += 3;
			num2 = string_0.IndexOf('&', num);
			if (num2 < 0)
			{
				num2 = string_0.Length;
			}
		}
		else
		{
			num = string_0.IndexOf("file/d/");
			if (num < 0)
			{
				return string.Empty;
			}
			num += 7;
			num2 = string_0.IndexOf('/', num);
			if (num2 < 0)
			{
				num2 = string_0.IndexOf('?', num);
				if (num2 < 0)
				{
					num2 = string_0.Length;
				}
			}
		}
		return "https://drive.google.com/uc?id=" + string_0.Substring(num, num2 - num) + "&export=download";
	}
}
