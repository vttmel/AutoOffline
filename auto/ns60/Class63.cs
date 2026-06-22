using System;
using System.Threading;
using ns1;
using ns100;
using ns11;
using ns116;
using ns23;
using ns53;
using ns61;
using ns71;
using ns81;
using ns83;
using ns85;

namespace ns60;

internal class Class63
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
						Form1.characterAccountConfig_1[num].bool_31 = false;
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_31)
					{
						break;
					}
					Form1.characterAccountConfig_1[num].bool_31 = true;
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
		int num = 0;
		int num2 = 52900;
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		int int_2 = 0;
		int num3 = 0;
		int num4 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		int num5 = -1;
		int num6 = 0;
		while (true)
		{
			num3--;
			Thread.Sleep(100);
			if (num3 <= num4)
			{
				num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25)
				{
					break;
				}
				num3 = 8;
				num4 = 0;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num];
			if (characterAccountConfig.int_61 > 0 && characterAccountConfig.int_25 <= 0 && characterAccountConfig.gstruct49_0.int_0 <= 0)
			{
				uint num7 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.int_137);
				uint num8 = Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig.int_137);
				uint num9 = num8 * Class56.memorySignatureScanConfig_15.uint_0;
				uint num10 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig.int_137);
				uint num11 = num10 + num9;
				int num12 = (int)Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig.int_137);
				int num13 = (int)Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
				Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
				int num14 = Class89.smethod_39(characterAccountConfig);
				int num15 = (int)Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
				if (num12 != 0 && num15 != 10 && num15 != 21 && num14 > 1 && (num13 > 0 || characterAccountConfig.int_39 > 0))
				{
					Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 4, ref int_2);
					if (BitConverter.ToInt32(array, 0) > 0)
					{
						int num16 = Class85.smethod_4(characterAccountConfig);
						if (num5 != num16)
						{
							num6 = Class85.smethod_25(characterAccountConfig);
							num5 = num16;
						}
						if (num6 <= 0)
						{
							continue;
						}
					}
					else
					{
						num5 = -1;
					}
					uint uint_ = characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_124.uint_0 + Class56.memorySignatureScanConfig_125.uint_0 + 4;
					Class24.ReadProcessMemory(characterAccountConfig.int_137, uint_, array, 4, ref int_2);
					int num17 = BitConverter.ToInt32(array, 0);
					if (num17 <= 0)
					{
						continue;
					}
					int num18 = 0;
					int num19 = 0;
					uint num20 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig.int_137);
					for (uint num21 = 1u; num21 < 256; num21++)
					{
						if (num21 % 50 == 0)
						{
							Thread.Sleep(30);
							if (Class11.bool_0)
							{
								break;
							}
						}
						if (num17 <= num18 && num19 > 5)
						{
							break;
						}
						uint num22 = num20 + num21 * Class56.memorySignatureScanConfig_127.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_138.uint_0, array2, 1, ref int_2);
						Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_137.uint_0, array, 4, ref int_2);
						if (array2[0] != 0 && BitConverter.ToInt32(array, 0) > 0)
						{
							num19 = 0;
							num18++;
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_128.uint_0, array, 1, ref int_2);
							if (array[0] == 4)
							{
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_132.uint_0, array, 4, ref int_2);
								if (BitConverter.ToUInt32(array, 0) <= 1)
								{
									continue;
								}
							}
							else
							{
								if (characterAccountConfig.string_4 != null)
								{
									bool flag = false;
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_138.uint_0, array2, array2.Length, ref int_2);
									string string_ = Class1.smethod_3(array2);
									for (int i = 0; i < characterAccountConfig.string_4.Length; i++)
									{
										if (Class11.smethod_2(string_, characterAccountConfig.string_4[i]))
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
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_129.uint_0, array, 4, ref int_2);
								int num23 = BitConverter.ToInt32(array, 0);
								if (num23 != 1 && num23 != 2 && num23 <= 4)
								{
									if (characterAccountConfig.int_62 <= 0 || (num23 == 4 && characterAccountConfig.int_42 > 0))
									{
										continue;
									}
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_130.uint_0, array, 4, ref int_2);
									int num24 = BitConverter.ToInt32(array, 0);
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_131.uint_0, array, 4, ref int_2);
									int num25 = BitConverter.ToInt32(array, 0);
									if (characterAccountConfig.int_62 != 10 && (characterAccountConfig.int_62 != 9 || num23 <= 0) && (characterAccountConfig.int_62 != 1 || num24 * num25 > 1) && (characterAccountConfig.int_62 != 2 || num24 * num25 > 1 || num23 <= 0) && (characterAccountConfig.int_62 != 3 || num24 * num25 > 2) && (characterAccountConfig.int_62 != 4 || num24 * num25 > 2 || num23 <= 0) && (characterAccountConfig.int_62 != 5 || num24 * num25 > 3) && (characterAccountConfig.int_62 != 6 || num24 * num25 > 3 || num23 <= 0) && (characterAccountConfig.int_62 != 7 || num24 * num25 > 4) && (characterAccountConfig.int_62 != 8 || num24 * num25 > 4 || num23 <= 0))
									{
										continue;
									}
								}
							}
							if (Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_140.uint_0, characterAccountConfig.int_137) != 0)
							{
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_133.uint_0, array, 4, ref int_2);
								uint num26 = BitConverter.ToUInt32(array, 0);
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_134.uint_0, array, 4, ref int_2);
								uint num27 = BitConverter.ToUInt32(array, 0);
								uint[] uint_2 = new uint[2]
								{
									Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
									Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
								};
								uint[] uint_3 = new uint[2] { num26, num27 };
								long num28 = Class64.smethod_18(uint_2, uint_3);
								if (num28 > num2)
								{
									continue;
								}
							}
							Class75.smethod_48(characterAccountConfig, num21);
							Thread.Sleep(10 + FormLocdo.int_5);
						}
						else
						{
							num19++;
						}
					}
				}
				else
				{
					Thread.Sleep(60);
				}
			}
			else
			{
				Thread.Sleep(300);
				num4 = 5;
			}
		}
	}
}
