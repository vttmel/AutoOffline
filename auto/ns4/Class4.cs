using System;
using System.Threading;
using ns1;
using ns100;
using ns11;
using ns23;
using ns3;
using ns44;
using ns53;
using ns61;
using ns71;
using ns81;
using ns83;
using ns85;

namespace ns4;

internal class Class4
{
	public static int int_0 = 0;

	public static void smethod_0(CharacterAccountConfig characterAccountConfig_0, ref string[] string_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 4, ref int_);
		int num2 = BitConverter.ToInt32(array, 0);
		int num3 = 0;
		string[] array3 = null;
		for (int i = 1; i < 256 && num2 > num3; i++)
		{
			uint num4 = num + (uint)(i * (int)Class56.memorySignatureScanConfig_15.uint_0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			num3++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_52.uint_0, array, 4, ref int_);
			uint num5 = BitConverter.ToUInt32(array, 0);
			if (num5 != 3)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_16.uint_0, array2, array2.Length, ref int_);
			string text = Class1.smethod_3(array2);
			if (string_0 != null)
			{
				bool flag = false;
				for (int j = 0; j < string_0.Length; j++)
				{
					if (string_0[j] == text)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					continue;
				}
			}
			if (array3 == null)
			{
				array3 = new string[1];
			}
			else
			{
				bool flag2 = false;
				for (int k = 0; k < array3.Length; k++)
				{
					if (array3[k] == text)
					{
						flag2 = true;
						break;
					}
				}
				if (flag2)
				{
					continue;
				}
				Array.Resize(ref array3, array3.Length + 1);
			}
			array3[array3.Length - 1] = text;
		}
		if (array3 != null)
		{
			Array.Sort(array3);
			int num6 = 0;
			if (string_0 != null)
			{
				num6 = string_0.Length;
				Array.Resize(ref string_0, string_0.Length + array3.Length);
			}
			else
			{
				string_0 = new string[array3.Length];
			}
			for (int l = 0; l < array3.Length; l++)
			{
				string_0[l + num6] = array3[l];
			}
		}
	}

	public static void smethod_1(CharacterAccountConfig characterAccountConfig_0, ref string[] string_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_124.uint_0 + Class56.memorySignatureScanConfig_125.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 4, ref int_);
		int num = BitConverter.ToInt32(array, 0);
		if (num <= 0)
		{
			return;
		}
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_126.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0);
		int num3 = 0;
		string[] array3 = null;
		for (uint num4 = 0u; num4 < 256 && num > num3; num4++)
		{
			uint num5 = num2 + num4 * Class56.memorySignatureScanConfig_127.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5, array, 4, ref int_);
			int num6 = BitConverter.ToInt32(array, 0);
			if (num6 <= 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_138.uint_0, array2, 1, ref int_);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_137.uint_0, array, 4, ref int_);
			if (array2[0] == 0 || BitConverter.ToInt32(array, 0) <= 0)
			{
				continue;
			}
			num3++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_128.uint_0, array, 4, ref int_);
			int num7 = BitConverter.ToInt32(array, 0);
			if (num7 == 4)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_138.uint_0, array2, array2.Length, ref int_);
			string text = Class1.smethod_3(array2);
			if (string_0 != null)
			{
				bool flag = false;
				for (int i = 0; i < string_0.Length; i++)
				{
					if (string_0[i] == text)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					continue;
				}
			}
			if (array3 == null)
			{
				array3 = new string[1];
			}
			else
			{
				bool flag2 = false;
				for (int j = 0; j < array3.Length; j++)
				{
					if (array3[j] == text)
					{
						flag2 = true;
						break;
					}
				}
				if (flag2)
				{
					continue;
				}
				Array.Resize(ref array3, array3.Length + 1);
			}
			array3[array3.Length - 1] = text;
		}
		if (array3 != null)
		{
			Array.Sort(array3);
			int num8 = 0;
			if (string_0 != null)
			{
				num8 = string_0.Length;
				Array.Resize(ref string_0, string_0.Length + array3.Length);
			}
			else
			{
				string_0 = new string[array3.Length];
			}
			for (int k = 0; k < array3.Length; k++)
			{
				string_0[k + num8] = array3[k];
			}
		}
	}

	public static void smethod_2(CharacterAccountConfig characterAccountConfig_0, ref string[] string_0, int int_1 = 0)
	{
		int int_2 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[80];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_2);
		uint num = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_2);
		uint num2 = BitConverter.ToUInt32(array, 0);
		string[] array3 = null;
		int num3 = Class85.smethod_4(characterAccountConfig_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class56.int_1 && num3 > num4; num5++)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + (num5 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array, 4, ref int_2);
			uint num6 = BitConverter.ToUInt32(array, 0);
			if (num6 == 0)
			{
				continue;
			}
			uint num7 = num2 + num6 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_2);
			if (BitConverter.ToInt32(array, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_2);
			if (array[0] == 0)
			{
				continue;
			}
			num4++;
			uint num8 = num + num5 * 20;
			if (int_1 > 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_2);
				if (array[0] != int_1)
				{
					continue;
				}
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_2);
			if (array[0] == 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array2, array2.Length, ref int_2);
			string text = Class1.smethod_3(array2);
			if (string_0 != null)
			{
				bool flag = false;
				for (int i = 0; i < string_0.Length; i++)
				{
					if (string_0[i] == text)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					continue;
				}
			}
			if (array3 == null)
			{
				array3 = new string[1];
			}
			else
			{
				bool flag2 = false;
				for (int j = 0; j < array3.Length; j++)
				{
					if (array3[j] == text)
					{
						flag2 = true;
						break;
					}
				}
				if (flag2)
				{
					continue;
				}
				Array.Resize(ref array3, array3.Length + 1);
			}
			array3[array3.Length - 1] = text;
		}
		if (array3 != null)
		{
			Array.Sort(array3);
			int num9 = 0;
			if (string_0 == null)
			{
				string_0 = new string[array3.Length];
			}
			else
			{
				num9 = string_0.Length;
				Array.Resize(ref string_0, string_0.Length + array3.Length);
			}
			for (int k = 0; k < array3.Length; k++)
			{
				string_0[k + num9] = array3[k];
			}
		}
	}

	public static void smethod_3()
	{
		int int_ = int_0;
		int_0 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25 || Form1.characterAccountConfig_1[num].gstruct49_0.int_0 <= 0)
				{
					if (0 <= num)
					{
						Form1.characterAccountConfig_1[num].bool_45 = false;
						Form1.characterAccountConfig_1[num].gstruct49_0.int_0 = 0;
						Class75.smethod_2(Form1.characterAccountConfig_1[num], Class75.uint_13, 0, 4);
						Class75.smethod_52(Form1.characterAccountConfig_1[num], "<color=green><bclr=blue>KÕt thóc nhÆt qu¶ !");
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_45)
					{
						break;
					}
					if (Class75.smethod_3(Form1.characterAccountConfig_1[num], Class75.uint_13, 4) == 0)
					{
						Form1.characterAccountConfig_1[num].gstruct49_0.int_0 = 0;
						continue;
					}
					flag = true;
					Form1.characterAccountConfig_1[num].bool_45 = true;
					Class75.smethod_52(Form1.characterAccountConfig_1[num], "<color=green><bclr=blue>NhÆt qu¶ Huy Hoµng, Hoµng Kim...");
				}
				smethod_4(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_4(int int_1)
	{
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		bool flag = false;
		bool flag2 = false;
		int num = 0;
		string text = Class56.string_22.ToLower();
		int int_2 = 0;
		byte[] array = new byte[4];
		byte[] array2 = null;
		byte[] array3 = null;
		int num2 = 0;
		int num3 = -1;
		int num4 = 0;
		uint num5 = 0u;
		uint[] array4 = new uint[2];
		while (true)
		{
			num2--;
			Thread.Sleep(100);
			if (num2 <= 0)
			{
				num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25 || Form1.characterAccountConfig_1[num].gstruct49_0.int_0 <= 0)
				{
					flag2 = true;
				}
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num];
			DateTime now = DateTime.Now;
			int hour = now.Hour;
			int minute = now.Minute;
			int second = now.Second;
			long ticks = new TimeSpan(hour, minute, second).Ticks;
			long ticks2 = new TimeSpan(characterAccountConfig.gstruct49_0.int_3, characterAccountConfig.gstruct49_0.int_4, characterAccountConfig.gstruct49_0.int_5).Ticks;
			uint num6 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.int_137);
			uint num7 = Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig.int_137);
			uint num8 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig.int_137);
			uint num9 = num8 + num7 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_13 * 4, array, 4, ref int_2);
			if (array[0] == 0)
			{
				flag2 = true;
			}
			if (flag2 || num3 != characterAccountConfig.gstruct49_0.int_2)
			{
				num3 = characterAccountConfig.gstruct49_0.int_2;
				if (flag2)
				{
					break;
				}
			}
			Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_15 * 4, array, 1, ref int_2);
			int num10 = array[0];
			Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_16 * 4, array, 4, ref int_2);
			array4[0] = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + (Class75.uint_16 + 1) * 4, array, 4, ref int_2);
			array4[1] = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + (Class75.uint_16 + 2) * 4, array, 4, ref int_2);
			int num11 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_2);
			int num12 = BitConverter.ToInt32(array, 0);
			uint[] uint_ = new uint[2];
			uint[] array5 = new uint[2]
			{
				Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
				Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
			};
			int num13 = Class89.smethod_12(characterAccountConfig);
			if (num13 == 1)
			{
				int num14 = 5;
				if (num4 < 5)
				{
					if (num10 > 0)
					{
						array2 = Class11.smethod_47("§Þnh l¹i quanh ®iÓm: " + (num14 - num4));
						Class24.WriteProcessMemory(characterAccountConfig.int_137, num9 + Class56.memorySignatureScanConfig_251.uint_0, array2, array2.Length, ref int_2);
					}
				}
				else
				{
					if (num10 > 0)
					{
						Class75.smethod_2(characterAccountConfig, Class75.uint_16, (int)array5[0], 4);
						Class75.smethod_2(characterAccountConfig, Class75.uint_16 + 1, (int)array5[1], 4);
						Class75.smethod_2(characterAccountConfig, Class75.uint_16 + 2, num12, 4);
						array2 = Class11.smethod_47("Täa ®é míi: " + array5[0] + "," + array5[1]);
						Class24.WriteProcessMemory(characterAccountConfig.int_137, num9 + Class56.memorySignatureScanConfig_251.uint_0, array2, array2.Length, ref int_2);
					}
					num5 = 0u;
				}
				num4++;
				continue;
			}
			num4 = 0;
			if (characterAccountConfig.gstruct49_0.int_2 > 0)
			{
				long num15 = ticks2 - ticks;
				array2 = Class11.smethod_47(hour + "." + minute + "." + second + "(" + num15 / 10000000L + ")");
				Class24.WriteProcessMemory(characterAccountConfig.int_137, num9 + Class56.memorySignatureScanConfig_251.uint_0, array2, array2.Length, ref int_2);
				if (num15 > 0L)
				{
					continue;
				}
			}
			uint uint_2 = characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, uint_2, array, 4, ref int_2);
			int num16 = BitConverter.ToInt32(array, 0);
			if (num16 <= 1)
			{
				continue;
			}
			int num17 = 0;
			uint num18 = 0u;
			long num19 = 0L;
			long num20 = 0L;
			string text2 = text;
			if (characterAccountConfig.gstruct49_0.string_0 != null && characterAccountConfig.gstruct49_0.string_0 != string.Empty)
			{
				text2 = characterAccountConfig.gstruct49_0.string_0.ToLower();
			}
			if (array3 == null || array3.Length != text2.Length + 5)
			{
				array3 = new byte[text2.Length + 5];
			}
			if (num5 != 0)
			{
				string text3 = Class3.smethod_16(characterAccountConfig, (int)num5, ref uint_);
				if (text3 != null && text3 != string.Empty && 0 <= Class11.smethod_1(text3, text2))
				{
					if (num10 > 0 && array4[0] != 0 && array4[1] != 0)
					{
						num18 = num8 + num5 * Class56.memorySignatureScanConfig_15.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_2);
						uint_[0] = BitConverter.ToUInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_2);
						uint_[1] = BitConverter.ToUInt32(array, 0);
						num20 = Class64.smethod_18(array4, uint_);
						if (num20 > characterAccountConfig.gstruct49_0.int_1 * characterAccountConfig.gstruct49_0.int_1)
						{
							goto IL_0624;
						}
					}
					goto IL_07c8;
				}
			}
			goto IL_0624;
			IL_0624:
			num5 = 0u;
			for (uint num21 = 1u; num21 < 256 && num16 > num17; num21++)
			{
				num18 = num8 + num21 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_2);
				if (array[0] == 0)
				{
					continue;
				}
				num17++;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_52.uint_0, array, 4, ref int_2);
				uint num22 = BitConverter.ToUInt32(array, 0);
				if (num22 != 3)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_2);
				uint_[0] = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_2);
				uint_[1] = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_16.uint_0, array3, array3.Length, ref int_2);
				string string_ = Class1.smethod_3(array3).ToLower();
				if (Class11.smethod_1(string_, text2) < 0)
				{
					continue;
				}
				if (num10 > 0 && array4[0] != 0 && array4[1] != 0)
				{
					num20 = Class64.smethod_18(array4, uint_);
					if (num20 > characterAccountConfig.gstruct49_0.int_1 * characterAccountConfig.gstruct49_0.int_1)
					{
						continue;
					}
				}
				else
				{
					num20 = Class64.smethod_18(array5, uint_);
				}
				if (num5 == 0 || num20 < num19)
				{
					num5 = num21;
					num19 = num20;
				}
			}
			goto IL_07c8;
			IL_07c8:
			if (num5 != 0)
			{
				num18 = num8 + num5 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_2);
				uint_[0] = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_2);
				uint_[1] = BitConverter.ToUInt32(array, 0);
				int i;
				for (i = 0; i < 5; i++)
				{
					array5 = new uint[2]
					{
						Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
						Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
					};
					long num23 = Class64.smethod_18(array5, uint_);
					if (num23 <= 7500L)
					{
						break;
					}
					Class75.smethod_61(characterAccountConfig, uint_);
					Thread.Sleep(150);
				}
				if (characterAccountConfig.gstruct49_0.int_6 > 0)
				{
					Class47.smethod_10(characterAccountConfig);
				}
				Class24.WriteProcessMemory(characterAccountConfig.int_137, num9 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num5), 4, ref int_2);
				if (characterAccountConfig.gstruct49_0.int_6 <= 0)
				{
					continue;
				}
				flag = false;
				i = 0;
				while (i < 600)
				{
					int num24 = Class47.smethod_9(characterAccountConfig);
					if (num24 <= 0)
					{
						i++;
						Thread.Sleep(1);
						continue;
					}
					flag = true;
					break;
				}
				i = 0;
				long long_ = Class11.smethod_27();
				int num25 = -16777215;
				while (flag && Class11.smethod_28(long_) < characterAccountConfig.gstruct49_0.int_7)
				{
					Thread.Sleep(1);
					string text4 = Class3.smethod_16(characterAccountConfig, (int)num5, ref uint_);
					if (text4 != null && !(text4 == string.Empty))
					{
						int num26 = Class47.smethod_9(characterAccountConfig);
						if (num25 != -16777215 && num26 <= num25)
						{
							if (i > 300 && num26 <= num25)
							{
								break;
							}
						}
						else
						{
							i = 0;
							num25 = num26;
						}
						array2 = Class11.smethod_47(num26.ToString());
						Class24.WriteProcessMemory(characterAccountConfig.int_137, num9 + Class56.memorySignatureScanConfig_251.uint_0, array2, array2.Length, ref int_2);
						Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_13 * 4, array, 1, ref int_2);
						if (array[0] != 0)
						{
							Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_14 * 4, array, 1, ref int_2);
							if (array[0] == 0)
							{
								break;
							}
							i++;
							continue;
						}
						flag2 = true;
						break;
					}
					num5 = 0u;
					break;
				}
			}
			else if (num10 > 0 && num11 == num12 && array4[0] != 0 && array4[1] != 0)
			{
				num20 = Class64.smethod_18(array4, array5);
				if (num20 > 11200L)
				{
					Class75.smethod_61(characterAccountConfig, array4);
					Thread.Sleep(200);
				}
			}
		}
		num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (0 <= num)
		{
			Form1.characterAccountConfig_1[num].gstruct49_0.int_0 = 0;
		}
		Class75.smethod_2(characterAccountConfig, Class75.uint_13, 0, 4);
	}
}
