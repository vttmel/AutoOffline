using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ns11;
using ns146;

namespace ns78;

internal class Class82
{
	public string string_0 = null;

	public void method_0()
	{
		try
		{
			string text = Class11.smethod_72(string_0);
			string text2 = string.Empty;
			string text3 = Class11.smethod_54(Class11.string_5);
			string text4 = Class11.smethod_54(Class11.string_7);
			string text5 = Class11.smethod_54(Class11.string_2);
			string text6 = Class11.smethod_54(Class11.string_4);
			if (text[0] != text4[0])
			{
				TcpClient tcpClient = new TcpClient(text, 13);
				StreamReader streamReader = new StreamReader(tcpClient.GetStream());
				string text7 = streamReader.ReadToEnd();
				tcpClient.Close();
				if (text7.Length > 24)
				{
					text2 = ((Class11.smethod_1(text7.ToUpper(), Class11.smethod_0(Class11.char_28)) <= 0) ? Convert.ToDateTime(text7.Substring(0, 20)).ToString(Class11.smethod_0(Class11.char_29)) : text7.Substring(7, 17));
				}
			}
			else
			{
				WebClient webClient = new WebClient();
				byte[] array = webClient.DownloadData(Class11.smethod_0(Class11.char_13) + text.Substring(1));
				string text8 = Encoding.Default.GetString(array, 0, array.Length);
				string text9 = text8.Substring(Class11.smethod_1(text8, Class11.smethod_0(Class11.char_14)) + 12);
				string text10 = text9.Substring(0, Class11.smethod_1(text9, "<")).Replace(" ", "");
				string[] array2 = text10.Split(text6[0], text5[0], text4[0], text3[0]);
				if (array2.Length == 6)
				{
					if (array2[2].Length > 2)
					{
						int length = array2[2].Length;
						array2[2] = array2[2].Substring(length - 2);
					}
					text2 = array2[2] + text3 + array2[1] + text3 + array2[0] + " " + array2[3] + text4 + array2[4] + text4 + array2[5];
				}
				webClient.CancelAsync();
			}
			if (text2 != null && text2 != string.Empty)
			{
				CultureInfo cultureInfo = new CultureInfo(CultureInfo.CurrentCulture.Name);
				cultureInfo.Calendar.TwoDigitYearMax = 2099;
				DateTime dateTime = DateTime.ParseExact(text2, Class11.smethod_0(Class11.char_29), cultureInfo, DateTimeStyles.AssumeUniversal);
				if (GClass1.long_1 < dateTime.Ticks)
				{
					GClass1.long_1 = dateTime.Ticks;
				}
			}
		}
		catch
		{
		}
	}
}
