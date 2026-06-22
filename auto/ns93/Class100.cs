using System;
using System.Threading;
using ns1;
using ns100;
using ns11;
using ns23;
using ns27;
using ns52;
using ns53;
using ns56;
using ns61;
using ns71;
using ns83;
using ns84;
using ns85;

namespace ns93;

internal class Class100
{
	public static int int_0 = 0;

	public static void smethod_0()
	{
		int int_ = int_0;
		int_0 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25)
				{
					if (0 <= num)
					{
						Form1.characterAccountConfig_1[num].bool_34 = false;
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_34)
					{
						break;
					}
					Form1.characterAccountConfig_1[num].bool_34 = true;
					flag = true;
				}
				smethod_1(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_1(int int_1)
	{
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		int num = 0;
		int int_2 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[48];
		while (true)
		{
			Thread.Sleep(800);
			int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
			if (Class11.bool_0 || num2 < 0 || !Form1.characterAccountConfig_1[num2].bool_25)
			{
				break;
			}
			num++;
			if (num < 10 || Form1.characterAccountConfig_1[num2].int_121[0] == 0)
			{
				continue;
			}
			try
			{
				characterAccountConfig = Form1.characterAccountConfig_1[num2];
			}
			catch
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_2);
			if (int_2 != 4)
			{
				continue;
			}
			uint num3 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num3 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_2);
			uint num4 = BitConverter.ToUInt32(array, 0);
			uint num5 = num4 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_2);
			if (int_2 != 4)
			{
				continue;
			}
			uint num6 = BitConverter.ToUInt32(array, 0);
			uint num7 = num6 + num5;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num7 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_2);
			int num8 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num7 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_2);
			int num9 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_2);
			int num10 = BitConverter.ToInt32(array, 0);
			int num11 = Class89.smethod_39(characterAccountConfig);
			if (num9 <= 0 || num10 <= 0 || num8 <= 0 || num11 <= 1)
			{
				continue;
			}
			num = 0;
			if (num10 == 962 || num10 == 963 || (849 <= num10 && num10 <= 862) || (464 <= num10 && num10 <= 471) || (480 <= num10 && num10 <= 495))
			{
				continue;
			}
			int[] array3 = Class59.smethod_0(num10);
			if (array3 != null && Class59.smethod_2(num10) < 0)
			{
				Thread.Sleep(800);
				continue;
			}
			string text = Class28.smethod_10(characterAccountConfig);
			GStruct61 gStruct = Class88.smethod_5(characterAccountConfig);
			if (characterAccountConfig.int_121[4] > 0)
			{
				byte[] array4 = new byte[1];
				if (gStruct.int_0 > 0)
				{
					array4 = Class11.smethod_47("PT(" + gStruct.int_0 + ")-" + gStruct.string_0);
				}
				else if (text != string.Empty)
				{
					array4 = Class11.smethod_47(text);
				}
				Class24.WriteProcessMemory(characterAccountConfig.int_137, num7 + Class56.memorySignatureScanConfig_89.uint_0, array4, array4.Length, ref int_2);
			}
			if (characterAccountConfig.int_121[1] != 0)
			{
				if ((463 < num10 && num10 < 472) || (479 < num10 && num10 < 496))
				{
					Thread.Sleep(800);
					continue;
				}
				if (gStruct.int_0 != 0)
				{
					if (!(gStruct.string_0 != characterAccountConfig.string_22))
					{
						int num12 = (int)Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_23.uint_0, characterAccountConfig.int_137);
						if ((4 <= gStruct.int_0 && num12 < 6) || (5 <= gStruct.int_0 && num12 < 12) || (6 <= gStruct.int_0 && num12 < 19) || (7 <= gStruct.int_0 && num12 < 19) || 8 <= gStruct.int_0)
						{
							continue;
						}
					}
					else
					{
						Class88.smethod_2(characterAccountConfig);
						Thread.Sleep(600);
						Class88.smethod_1(characterAccountConfig);
					}
				}
				else
				{
					Class88.smethod_1(characterAccountConfig);
				}
				uint uint_ = characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, uint_, array, 4, ref int_2);
				int num13 = BitConverter.ToInt32(array, 0);
				if (num13 <= 1)
				{
					continue;
				}
				int num14 = 0;
				string[] string_ = null;
				for (uint num15 = 1u; num15 < 256; num15++)
				{
					if (num15 % 60 == 0)
					{
						Thread.Sleep(100);
					}
					if (num13 <= num14)
					{
						break;
					}
					string text2;
					if (num15 != num4)
					{
						uint num16 = num6 + num15 * Class56.memorySignatureScanConfig_15.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_2);
						if (array[0] == 0)
						{
							continue;
						}
						num14++;
						Class24.ReadProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_2);
						if (BitConverter.ToInt32(array, 0) <= 0 || Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig.int_137) != 1)
						{
							continue;
						}
						Class24.ReadProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_16.uint_0, array2, array2.Length, ref int_2);
						text2 = Class1.smethod_3(array2);
						if (text2.Length < 5)
						{
							continue;
						}
						if (gStruct.gstruct60_0 != null)
						{
							bool flag = false;
							for (int i = 1; i < gStruct.gstruct60_0.Length; i++)
							{
								if (text2 == gStruct.gstruct60_0[i].string_0)
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
						if (characterAccountConfig.int_121[2] > 0 && characterAccountConfig.string_19 != null)
						{
							int num17 = 0;
							while (num17 < characterAccountConfig.string_19.Length)
							{
								if (!(text2 == characterAccountConfig.string_19[num17]))
								{
									num17++;
									continue;
								}
								goto IL_05c8;
							}
						}
						if (characterAccountConfig.int_121[3] > 0 && text != string.Empty)
						{
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_89.uint_0, array2, array2.Length, ref int_2);
							string string_2 = Class1.smethod_3(array2);
							if (0 <= Class11.smethod_1(string_2, text))
							{
								goto IL_070d;
							}
						}
						if (characterAccountConfig.int_121[2] > 0 || characterAccountConfig.int_121[3] > 0)
						{
							continue;
						}
						uint[] uint_2 = new uint[2]
						{
							Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
							Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
						};
						uint[] uint_3 = new uint[2]
						{
							Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
							Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
						};
						long num18 = Class64.smethod_18(uint_2, uint_3);
						if (num18 > 500000L)
						{
							continue;
						}
						goto IL_070d;
					}
					num14++;
					continue;
					IL_070d:
					Class75.smethod_57(characterAccountConfig, "InviteTeam('" + text2 + "')");
					Thread.Sleep(300);
					continue;
					IL_05c8:
					Class11.smethod_29(ref string_, text2);
					goto IL_070d;
				}
				if (string_ != null)
				{
					for (int j = 0; j < string_.Length; j++)
					{
						Class75.smethod_57(characterAccountConfig, "InviteTeam('" + string_[j] + "')");
						Thread.Sleep(600);
					}
				}
				continue;
			}
			string text3 = Class55.smethod_2(characterAccountConfig, bool_0: true);
			if (text3 == string.Empty)
			{
				continue;
			}
			if (gStruct.int_0 != 0)
			{
				if (gStruct.int_0 <= 1)
				{
					Class88.smethod_2(characterAccountConfig);
					Thread.Sleep(600);
				}
				else if (characterAccountConfig.int_121[2] > 0 && characterAccountConfig.string_19 != null)
				{
					int num19 = 0;
					while (num19 < characterAccountConfig.string_19.Length)
					{
						if (!(gStruct.string_0 == characterAccountConfig.string_19[num19]))
						{
							num19++;
							continue;
						}
						goto IL_099d;
					}
				}
			}
			if (Class11.smethod_1(text3, "mêi tæ") > 0)
			{
				string[] array5 = text3.Split('|');
				string text4 = null;
				int num20 = 0;
				while (num20 < array5.Length)
				{
					if (Class11.smethod_1(array5[num20], "mêi tæ") <= 0)
					{
						num20++;
						continue;
					}
					if (characterAccountConfig.int_121[2] > 0 && characterAccountConfig.string_19 != null)
					{
						int num21 = 0;
						while (num21 < characterAccountConfig.string_19.Length)
						{
							if (Class11.smethod_1(array5[num20], characterAccountConfig.string_19[num21]) <= 0)
							{
								num21++;
								continue;
							}
							goto IL_08d0;
						}
						break;
					}
					text4 = array5[num20];
					goto IL_08e0;
					IL_08e0:
					if (text4 == null)
					{
						break;
					}
					string[] array6 = text4.Split(';');
					if (array6.Length != 2 || (gStruct.string_0 != null && Class11.smethod_1(array6[1], gStruct.string_0 + " ") == 0))
					{
						break;
					}
					uint num22 = Class11.smethod_12(array6[0]);
					if (num22 != 0)
					{
						Class24.smethod_31(characterAccountConfig.uint_55 + 2, characterAccountConfig.int_137, num22);
						Class24.smethod_31(characterAccountConfig.uint_55 + 7, characterAccountConfig.int_137, 1u, 1);
						for (int k = 0; k < 3; k++)
						{
							Class75.smethod_12(characterAccountConfig.int_137, characterAccountConfig.uint_55);
							Thread.Sleep(999);
						}
					}
					break;
					IL_08d0:
					text4 = array5[num20];
					goto IL_08e0;
				}
			}
			goto IL_099d;
			IL_099d:
			if (text3 == null || Class11.smethod_1(text3, "giao dÞch") >= 0)
			{
				continue;
			}
			uint num23 = Class24.smethod_30(Class56.memorySignatureScanConfig_165.uint_0, characterAccountConfig.int_137);
			uint num24 = Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_167.uint_0, characterAccountConfig.int_137);
			if (num24 == 0)
			{
				continue;
			}
			uint num25 = Class24.smethod_30(num24, characterAccountConfig.int_137);
			if (num25 != 0)
			{
				string text5 = Class24.smethod_28(num25, characterAccountConfig.int_137, 78);
				if (text5 != null && !(text5 == string.Empty))
				{
					Class75.smethod_12(characterAccountConfig.int_137, characterAccountConfig.uint_56);
				}
			}
		}
	}
}
