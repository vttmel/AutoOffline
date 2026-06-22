using ns1;
using ns100;
using ns11;
using ns23;
using ns27;
using ns30;
using ns35;
using ns48;
using ns53;
using ns63;
using ns70;
using ns78;
using ns85;
using ns9;
using System;
using System.IO;
using System.Text;
using System.Threading;

namespace ns146;

public class GClass1
{
	public struct GStruct15
	{
		public string string_0;

		public string string_1;

		public uint uint_0;

		public long long_0;

		public string long_1;

		public int int_0;

		public bool bool_0;

		public uint[] uint_1;

		public string string_2;

		public string[] IPList;

		public string IPAuth;

		public long TimeDelaySendProtocol;
	}

	public struct GStruct16
	{
		public long long_0;

		public int int_0;

		public int int_1;

		public int int_2;

		public string string_0;

		public int int_3;

		public string string_1;

		public uint uint_0;

		public string string_2;
	}

	public static string string_0 = null;

	public static string string_1 = null;

	public static string string_2 = null;

	public static int int_0 = 0;

	public static long long_0 = -1L;

	public static int int_1 = 0;

	public static GStruct16[] gstruct16_0 = null;

	public static int int_2 = 0;

	public static bool bool_0 = false;

	public static long long_1 = 0L;

	public static bool bool_1 = false;

	public static string string_3 = null;

	public static string string_4 = null;

	public static string string_5 = null;

	public static long long_2 = 0L;

	public static long long_3 = 0L;

	public static int int_3 = 0;

	public static GStruct15 gstruct15_0 = default(GStruct15);

	public static int int_4 = 0;

	public static GStruct28[] gstruct28_0 = null;

	public static int int_5 = -1;

	public static int int_6 = 0;

	public static int int_7 = 1000;

	public static string string_6 = string.Empty;

	public static bool bool_2 = false;

	public static string string_7 = "\\script\\allowauto.lua";

	public static string string_8 = "RecvResult";

	public static string string_9 = "d";

	public static void smethod_0()
	{
		byte[] array = null;
		int int_ = 0;
		byte[] array2 = new byte[4];
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		Class82[] array3 = null;
		Class74[] array4 = null;
		Class74[] array5 = null;
		Class74[] array6 = null;
		Class74[] array7 = null;
		Class74[] array8 = null;
		long num9 = 0L;
		while (true)
		{
			gstruct15_0 = new GStruct15
			{
				string_0 = null,
				string_1 = null,
				bool_0 = false,
				long_1 = string.Empty,
				long_0 = 0L,
				int_0 = 0,
				uint_0 = 0u
			};
			int_4 = 0;
			num6 = 0;
			num7 = 0;
			long_2 = 0L;
			int_2 = 0;
			while (true)
			{
				Thread.Sleep(1300);
				if (Class11.bool_0)
				{
					return;
				}
				if (int_2 == 2)
				{
					break;
				}
				num--;
				if (num <= 0)
				{
					bool_1 = bool_1 || smethod_2();
					num = 1800;
				}
				if (!Form1.bool_16 || Class11.uint_0 == 0)
				{
					continue;
				}
				if (bool_1)
				{
					Form1.characterAccountConfig_1 = null;
					continue;
				}
				int num10 = Class11.int_1;
				uint uint_ = Class11.uint_0;
				if (array3 == null || array == null)
				{
					array = new byte[8];
					array3 = new Class82[Class9.string_0.Length];
					int num11 = Class9.string_1.Length;
					array4 = new Class74[num11];
					array5 = new Class74[num11];
					array6 = new Class74[num11];
					array7 = new Class74[num11];
					array8 = new Class74[num11];
					// Class31.smethod_0(); // License check removed
					long_3 = 0L;
					string text = smethod_1(num10, uint_ + 256);
					text = Class11.smethod_54(smethod_1(num10, uint_ + 768));
					if (text != string.Empty)
					{
						array = Encoding.ASCII.GetBytes(text);
					}
					uint num12 = uint_ + 1024 + 8;
					Class24.ReadProcessMemory(num10, num12, array2, 4, ref int_);
					int num13 = BitConverter.ToInt32(array2, 0);
					if (num13 > 0)
					{
						text = smethod_1(num10, num12, bool_3: true);
						Class11.long_0 = Class11.smethod_37(text);
					}
				}
				if (num3 == 0)
				{
					num3 = 1;
					if (num7 == 0)
					{
						Class11.string_17 = new string[1] { "Đang kiểm tra phiên bản, xin chờ chút xíu..." };
					}
					else
					{
						Class11.string_17 = new string[1] { "Đang thử kiểm tra phiên bản lần thứ " + (num3 + 1) };
					}
					for (int i = 0; i < array4.Length; i++)
					{
						array4[i] = new Class74
						{
							object_0 = "KYKeoxe.txt",
							string_1 = Class9.string_1[i],
							bool_0 = false,
							int_0 = i + 1
						};
						new Thread(array4[i].method_6).Start();
					}
					Thread.Sleep(800);
				}
				if (num3 == 1 || num3 == -1)
				{
					if (string_4 == null || string_4 == string.Empty)
					{
						if (num3 == -1)
						{
							if (num7 < 3)
							{
								num7++;
								num3 = 0;
								continue;
							}
							if (bool_0)
							{
								num3 = 2;
								continue;
							}
							Class11.string_17 = new string[1] { "Không thể kiểm tra phiên bản. Qua phụ trợ bấm cập nhật auto mới." };
							return;
						}
						int num14 = array4.Length;
						for (int j = 0; j < array4.Length; j++)
						{
							if (array4[j] == null || array4[j].bool_0)
							{
								num14--;
							}
						}
						if (num14 <= 0)
						{
							num3 = -1;
						}
						continue;
					}
					num3 = 2;
				}
				switch (num3)
				{
				case 3:
					if (Class11.smethod_28(num9) > 43200000L)
					{
						num3 = 0;
						num9 = 0L;
					}
					break;
				case 2:
					Class11.smethod_29(ref Class11.string_17, Class11.smethod_0(Class11.char_22));
					int_2 = 1;
					bool_0 = true;
					num3 = 3;
					num7 = 0;
					num9 = Class11.smethod_27();
					break;
				}
				num2--;
				if (num2 <= 0 && (bool_0 || num3 == 3))
				{
					for (int k = 0; k < array3.Length; k++)
					{
						array3[k] = new Class82
						{
							string_0 = Class9.string_0[k]
						};
						long_1 = DateTime.Now.Ticks;
						new Thread(array3[k].method_0).Start();
						Thread.Sleep(150);
					}
					num2 = 1800;
					if (gstruct15_0.bool_0)
					{
						gstruct15_0.bool_0 = gstruct15_0.long_1 != string.Empty && gstruct15_0.uint_0 != 0 && gstruct15_0.long_0 > long_1 && long_1 > 636758336219996160L;
						int_2 = 1;
					}
				}
				if (long_1 <= 0L)
				{
					if (num2 > 100)
					{
						num2 = 100;
					}
					continue;
				}
				if (num5 == 0 && Class31.string_0 != string.Empty && Class31.bool_0)
				{
					num5 = 1;
					string text2 = Class11.smethod_54(Class11.string_5);
					string text3 = Class11.smethod_54(string.Concat(Class11.char_12));
					string object_ = "hdd/" + Class31.string_2 + text2 + Class31.long_0 + text3;
					for (int l = 0; l < array5.Length; l++)
					{
						array5[l] = new Class74
						{
							object_0 = object_,
							string_1 = Class9.string_1[l],
							bool_0 = false,
							int_0 = l + 1
						};
						new Thread(array5[l].method_3).Start();
					}
					Thread.Sleep(800);
				}
				if (int_4 == 0 && gstruct15_0.long_1 == string.Empty)
				{
					int_4 = 1;
					string object_2 = "license/" + Form1.string_15 + ".txt";
					if (Form1.string_15.IndexOf(Form1.string_13) != 0)
					{
						for (int m = 0; m < array6.Length; m++)
						{
							array6[m] = new Class74
							{
								object_0 = object_2,
								string_1 = Class9.string_1[m],
								bool_0 = false,
								int_0 = m + 1,
								byte_0 = array
							};
							new Thread(array6[m].method_5).Start();
						}
					}
					Thread.Sleep(800);
				}
				if (int_4 == 1)
				{
					bool flag = false;
					for (int n = 0; n < array6.Length; n++)
					{
						if (array6[n] != null && !array6[n].bool_0)
						{
							flag = true;
							break;
						}
					}
					if (!flag || gstruct15_0.uint_0 != 0)
					{
						int_4 = 2;
						int_2 = 1;
					}
				}
				if (num6 == 0 && long_2 <= 0L && gstruct15_0.long_1 != string.Empty && gstruct15_0.bool_0)
				{
					num6 = 1;
					string object_3 = "license/" + Form1.string_15 + "_" + gstruct15_0.long_1 + ".txt";
					for (int num15 = 0; num15 < array7.Length; num15++)
					{
						array7[num15] = new Class74
						{
							object_0 = object_3,
							string_1 = Class9.string_1[num15],
							bool_0 = false,
							int_0 = num15 + 1
						};
						new Thread(array7[num15].method_4).Start();
					}
					Thread.Sleep(1500);
				}
				if (num8 < 3)
				{
					num8++;
					continue;
				}
				if (num8 < 20)
				{
					num8++;
					continue;
				}
				if (num4 <= 0)
				{
					num4 = 600;
					for (int num16 = 0; num16 < array8.Length; num16++)
					{
						array8[num16] = new Class74
						{
							string_1 = Class9.string_1[num16],
							object_0 = "quangcao.txt",
							bool_0 = false,
							int_0 = num16 + 1
						};
						new Thread(array8[num16].method_2).Start();
						Thread.Sleep(800);
					}
				}
				num4--;
			}
		}
	}

	private static string smethod_1(int int_8, uint uint_0, bool bool_3 = false)
	{
		int int_9 = 0;
		byte[] array = new byte[4];
		string result = string.Empty;
		Class24.ReadProcessMemory(int_8, uint_0, array, 4, ref int_9);
		int num = BitConverter.ToInt32(array, 0);
		if (num > 0)
		{
			byte[] array2 = new byte[num];
			Class24.ReadProcessMemory(int_8, uint_0 + 4, array2, num, ref int_9);
			result = ((!bool_3) ? Class1.smethod_4(array2) : Class1.smethod_3(array2));
			if (array2[0] != 0)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i] = 0;
				}
				Class24.WriteProcessMemory(int_8, uint_0, array2, num, ref int_9);
			}
		}
		return result;
	}

	private static bool smethod_2()
	{
		bool flag = false;
		try
		{
			string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_0(Class56.char_0));
			string path = environmentVariable + "\\" + Class11.smethod_72(Class11.smethod_54(Class11.string_14));
			string string_ = Class11.smethod_0(Class11.char_27);
			string text = Class11.smethod_16(string_);
			string[] files = Directory.GetFiles(path, Class11.smethod_0(Class11.char_25));
			if (files != null)
			{
				files = Directory.GetFiles(path, Class11.smethod_0(Class11.char_26));
			}
			if (files != null)
			{
				string[] array = files;
				foreach (string string_2 in array)
				{
					string text2 = Class11.smethod_33(string_2, 0, 0, 1);
					if (text2 != null && text2 != string.Empty)
					{
						for (int j = 0; j < Class11.string_15.Length; j++)
						{
							string object_ = Class11.smethod_72(Class11.smethod_54(Class11.string_15[j]));
							flag = flag || 0 <= Class11.smethod_1(text2, object_);
						}
						if (flag)
						{
							Class66.smethod_11(Class66.smethod_1(), text, Class11.smethod_27(), "", 0);
							Class11.smethod_20(string_2);
							Class11.smethod_34(string_2, string.Empty, 1);
						}
					}
				}
			}
			if (!flag)
			{
				long num = Class66.smethod_6(text, 0, "0");
				long num2 = Class11.smethod_28(num);
				if (num2 < 295000L)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				Class66.smethod_11(Class66.smethod_1(), text, 0, "", 0);
			}
			Class66.smethod_11(Class66.smethod_1(), string_, DateTime.Now.AddYears(15).Ticks, "", 0);
			return flag;
		}
		catch
		{
			return flag;
		}
	}

	public static string[] smethod_3()
	{
		string text = Class11.smethod_0(Class11.char_15);
		if (!Class31.bool_0)
		{
			return new string[2]
			{
				text,
				Class11.smethod_0(Class11.char_16)
			};
		}
		DateTime dateTime = new DateTime(Class11.long_0);
		string text2 = Class11.smethod_0(Class11.char_17);
		if (long_1 > 0L)
		{
			text2 = ((int)new TimeSpan(Class11.long_0 - long_1).TotalDays).ToString();
		}
		string text3 = Class11.smethod_54(Class11.string_7);
		string text4 = null;
		for (int i = 0; i < Class31.string_1.Length; i++)
		{
			if (i > 0)
			{
				text4 += text3;
			}
			text4 += Class31.string_1[i];
		}
		Class11.smethod_6(text4 + text3 + Class31.long_0);
		Class31.smethod_8(text4).ToLower();
		if (Class31.string_0 == string.Empty || Class11.long_0 <= 0L)
		{
			text = Class11.smethod_0(Class11.char_18);
		}
		string text5 = Class11.smethod_0(Class11.char_19) + dateTime.Day + Class11.smethod_54(Class11.string_4) + dateTime.Month + Class11.smethod_54(Class11.string_4) + dateTime.Year + " " + Class11.smethod_54(Class11.string_8) + text2 + Class11.smethod_0(Class11.char_20) + Class11.smethod_54(Class11.string_9);
		return new string[2] { text, text5 };
	}

	public static string smethod_4()
	{
		try
		{
			if (gstruct15_0.long_0 == 0L)
			{
				return Class11.smethod_0(Class11.char_16);
			}
			DateTime dateTime = new DateTime(long_1);
			DateTime dateTime2 = new DateTime(gstruct15_0.long_0);
			int num = (int)(dateTime2 - dateTime).TotalDays;
			return Class11.smethod_54(Class11.string_11) + Class1.smethod_1(gstruct15_0.string_1, 1) + Class11.smethod_54(Class11.string_12) + " " + num + Class11.smethod_0(Class11.char_20) + Class56.string_7 + Class11.smethod_0(Class11.char_19) + dateTime2.Day + Class11.smethod_54(Class11.string_4) + dateTime2.Month + Class11.smethod_54(Class11.string_4) + dateTime2.Year + " " + dateTime2.ToShortTimeString() + Class56.string_7 + Class11.smethod_0(Class11.char_21) + Form1.string_15;
		}
		catch
		{
		}
		return string.Concat('\u0001');
	}

	public static int smethod_5(CharacterAccountConfig characterAccountConfig_0)
	{
		try
		{
			return smethod_6(characterAccountConfig_0);
		}
		catch
		{
		}
		return 0;
	}

    public static int smethod_6(CharacterAccountConfig characterAccountConfig_0)
    {
       
        return 2;
    }
}
