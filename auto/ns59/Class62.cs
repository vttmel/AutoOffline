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

namespace ns59;

internal class Class62
{
	public static int int_0 = 180000;

	public static GStruct40[] gstruct40_0 = null;

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static int int_1 = 0;

	public static uint[] smethod_0(CharacterAccountConfig characterAccountConfig_0, uint[] uint_0, bool bool_2, bool bool_3)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		uint uint_1 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_124.uint_0 + Class56.memorySignatureScanConfig_125.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_1, array, 4, ref int_);
		int num = BitConverter.ToInt32(array, 0);
		if (num <= 0)
		{
			return null;
		}
		byte[] array2 = new byte[60];
		int num2 = 40000;
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num4 = Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num5 = num4 * Class56.memorySignatureScanConfig_15.uint_0;
		uint num6 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num7 = num6 + num5;
		uint num8 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		int num9 = characterAccountConfig_0.int_52 * characterAccountConfig_0.int_52;
		uint[] array3 = null;
		GStruct40[] array4 = null;
		int num10 = 0;
		int num11 = 0;
		for (uint num12 = 0u; num12 < 256; num12++)
		{
			if (!Class11.bool_0 && (num > num10 || num11 <= 5))
			{
				uint num13 = num8 + num12 * Class56.memorySignatureScanConfig_127.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13, array, 4, ref int_);
				int num14 = BitConverter.ToInt32(array, 0);
				if (num14 <= 0)
				{
					num11++;
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_138.uint_0, array2, 1, ref int_);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_137.uint_0, array, 4, ref int_);
				if (array2[0] != 0 && BitConverter.ToInt32(array, 0) > 0)
				{
					num11 = 0;
					num10++;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_133.uint_0, array, 4, ref int_);
					uint num15 = BitConverter.ToUInt32(array, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_134.uint_0, array, 4, ref int_);
					uint num16 = BitConverter.ToUInt32(array, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_128.uint_0, array, 4, ref int_);
					int num17 = BitConverter.ToInt32(array, 0);
					int num18 = -1;
					if (num17 != 4)
					{
						if (num17 != 3)
						{
							continue;
						}
						array4 = (bool_3 ? gstruct40_0 : characterAccountConfig_0.gstruct40_0);
						if (array4 != null)
						{
							try
							{
								bool flag = false;
								for (int i = 0; i < array4.Length; i++)
								{
									if (i > 0 && i % 50 == 0)
									{
										Thread.Sleep(15);
									}
									if (num14 == array4[i].int_0 && Class11.smethod_28(array4[i].long_0) < int_0)
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
							catch
							{
							}
						}
						if (characterAccountConfig_0.string_4 != null)
						{
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_138.uint_0, array2, array2.Length, ref int_);
							string string_ = Class1.smethod_3(array2);
							bool flag2 = false;
							for (int j = 0; j < characterAccountConfig_0.string_4.Length; j++)
							{
								if (Class11.smethod_2(string_, characterAccountConfig_0.string_4[j]))
								{
									flag2 = true;
									break;
								}
							}
							if (flag2)
							{
								continue;
							}
						}
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_129.uint_0, array, 4, ref int_);
						int num19 = BitConverter.ToInt32(array, 0);
						if (num19 != 1 && num19 != 2 && num19 <= 4)
						{
							if (characterAccountConfig_0.int_62 <= 0 || (num19 == 4 && characterAccountConfig_0.int_42 > 0))
							{
								continue;
							}
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_130.uint_0, array, 4, ref int_);
							int num20 = BitConverter.ToInt32(array, 0);
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_131.uint_0, array, 4, ref int_);
							int num21 = BitConverter.ToInt32(array, 0);
							if (characterAccountConfig_0.int_62 != 10 && (characterAccountConfig_0.int_62 != 9 || num19 <= 0) && (characterAccountConfig_0.int_62 != 1 || num20 * num21 > 1) && (characterAccountConfig_0.int_62 != 2 || num20 * num21 > 1 || num19 <= 0) && (characterAccountConfig_0.int_62 != 3 || num20 * num21 > 2) && (characterAccountConfig_0.int_62 != 4 || num20 * num21 > 2 || num19 <= 0) && (characterAccountConfig_0.int_62 != 5 || num20 * num21 > 3) && (characterAccountConfig_0.int_62 != 6 || num20 * num21 > 3 || num19 <= 0) && (characterAccountConfig_0.int_62 != 7 || num20 * num21 > 4) && (characterAccountConfig_0.int_62 != 8 || num20 * num21 > 4 || num19 <= 0))
							{
								continue;
							}
						}
					}
					else
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_132.uint_0, array, 4, ref int_);
						num18 = BitConverter.ToInt32(array, 0);
					}
					if (Class24.smethod_30(num13 + Class56.memorySignatureScanConfig_140.uint_0, characterAccountConfig_0.int_137) != 0)
					{
						uint[] uint_2 = new uint[2]
						{
							Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
							Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
						};
						uint[] array5 = new uint[2] { num15, num16 };
						long num22 = Class64.smethod_18(uint_2, array5);
						if (num22 > num2)
						{
							if (characterAccountConfig_0.int_54 <= 0 || num22 > 200000L)
							{
								if (num18 > 1)
								{
									if (uint_0 != null && uint_0[0] != 0)
									{
										num22 = Class64.smethod_18(uint_0, array5);
									}
									if ((array3 == null || num22 < array3[1]) && characterAccountConfig_0.int_51 > 0 && num22 <= num9)
									{
										array3 = new uint[5]
										{
											num12,
											(uint)num22,
											num15,
											num16,
											(uint)num14
										};
									}
								}
								continue;
							}
							for (int k = 0; k < 10; k++)
							{
								uint_2 = new uint[2]
								{
									Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
									Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
								};
								num22 = Class64.smethod_18(uint_2, array5);
								if (num22 <= num2)
								{
									break;
								}
								Class75.smethod_61(characterAccountConfig_0, array5);
								Thread.Sleep(150);
							}
						}
						Class75.smethod_48(characterAccountConfig_0, num12);
						Thread.Sleep(10 + FormLocdo.int_5);
					}
					else
					{
						Class75.smethod_48(characterAccountConfig_0, num12);
						Thread.Sleep(10 + FormLocdo.int_5);
					}
				}
				else
				{
					num11++;
				}
				continue;
			}
			return null;
		}
		return array3;
	}

	public static void smethod_1()
	{
		int int_ = int_1;
		int_1 = 0;
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
						Form1.characterAccountConfig_1[num].bool_32 = false;
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_32)
					{
						break;
					}
					Form1.characterAccountConfig_1[num].bool_32 = true;
					flag = true;
				}
				smethod_2(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_2(int int_2)
	{
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		int num = 0;
		int num2 = -1;
		long num3 = 0L;
		long long_ = 0L;
		while (true)
		{
			Thread.Sleep(600);
			int num4 = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
			if (Class11.bool_0 || num4 < 0 || !Form1.characterAccountConfig_1[num4].bool_25)
			{
				break;
			}
			Form1.characterAccountConfig_1[num4].bool_9 = false;
			characterAccountConfig = Form1.characterAccountConfig_1[num4];
			if (Class11.smethod_28(long_) > 3000L)
			{
				int num5 = 0;
				uint num6 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig.int_137);
				int int_3 = 0;
				int num7 = -1;
				byte[] byte_ = new byte[1];
				byte[] array = new byte[4];
				while (characterAccountConfig.gstruct40_0 != null && num5 < 60)
				{
					num7 = -1;
					for (int i = 0; i < characterAccountConfig.gstruct40_0.Length; i++)
					{
						if (i > 0 && i % 30 == 0)
						{
							Thread.Sleep(15);
						}
						uint num8 = num6 + characterAccountConfig.gstruct40_0[i].uint_0 * Class56.memorySignatureScanConfig_127.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_138.uint_0, byte_, 1, ref int_3);
						Class24.ReadProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_137.uint_0, array, 4, ref int_3);
						long num9 = Class11.smethod_28(characterAccountConfig.gstruct40_0[i].long_0);
						if ((array[0] == 0 || BitConverter.ToInt32(array, 0) <= 0) && num9 > 3000L)
						{
							characterAccountConfig.gstruct40_0[i].long_0 = Class11.smethod_27() - int_0 + 3000L;
							num5++;
						}
						if (Class11.smethod_28(characterAccountConfig.gstruct40_0[i].long_0) > int_0)
						{
							num7 = i;
							break;
						}
					}
					if (num7 < 0)
					{
						break;
					}
					smethod_5(ref characterAccountConfig.gstruct40_0, characterAccountConfig.gstruct40_0[num7].uint_0, characterAccountConfig.gstruct40_0[num7].int_0);
					num5++;
				}
				if (num5 > 0)
				{
					if (characterAccountConfig.gstruct40_0 != null && characterAccountConfig.gstruct40_0.Length != 0)
					{
						Form1.characterAccountConfig_1[num4].gstruct40_0 = new GStruct40[characterAccountConfig.gstruct40_0.Length];
						for (int j = 0; j < characterAccountConfig.gstruct40_0.Length; j++)
						{
							Form1.characterAccountConfig_1[num4].gstruct40_0[j].int_0 = characterAccountConfig.gstruct40_0[j].int_0;
							Form1.characterAccountConfig_1[num4].gstruct40_0[j].long_0 = characterAccountConfig.gstruct40_0[j].long_0;
							Form1.characterAccountConfig_1[num4].gstruct40_0[j].uint_0 = characterAccountConfig.gstruct40_0[j].uint_0;
						}
					}
					else
					{
						Form1.characterAccountConfig_1[num4].gstruct40_0 = null;
					}
				}
				if (!bool_0)
				{
					bool_0 = true;
					while (gstruct40_0 != null && num5 <= 255)
					{
						num7 = -1;
						for (int k = 0; k < gstruct40_0.Length; k++)
						{
							if (k > 0 && k % 30 == 0)
							{
								Thread.Sleep(15);
							}
							uint num10 = num6 + gstruct40_0[k].uint_0 * Class56.memorySignatureScanConfig_127.uint_0;
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num10 + Class56.memorySignatureScanConfig_138.uint_0, byte_, 1, ref int_3);
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num10 + Class56.memorySignatureScanConfig_137.uint_0, array, 4, ref int_3);
							long num11 = Class11.smethod_28(gstruct40_0[k].long_0);
							if ((array[0] == 0 || BitConverter.ToInt32(array, 0) <= 0) && num11 > 3000L)
							{
								gstruct40_0[k].long_0 = Class11.smethod_27() - int_0 + 3000L;
							}
							if (Class11.smethod_28(gstruct40_0[k].long_0) > int_0)
							{
								num7 = k;
								break;
							}
						}
						if (0 > num7)
						{
							break;
						}
						num5++;
						smethod_5(ref gstruct40_0, gstruct40_0[num7].uint_0, gstruct40_0[num7].int_0);
					}
					bool_0 = false;
				}
				long_ = Class11.smethod_27();
			}
			uint num12 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.int_137);
			uint num13 = Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig.int_137);
			uint num14 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig.int_137);
			uint num15 = num14 + num13 * Class56.memorySignatureScanConfig_15.uint_0;
			int num16 = (int)Class24.smethod_30(num15 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
			if (characterAccountConfig.int_61 <= 0 || characterAccountConfig.int_25 <= 0 || num16 <= 0 || characterAccountConfig.int_62 <= 0 || characterAccountConfig.int_40 <= 0)
			{
				continue;
			}
			int num17 = Class85.smethod_4(characterAccountConfig);
			if (num17 <= num2 && num == 0)
			{
				num2 = num17;
				continue;
			}
			num++;
			if (num3 == 0L)
			{
				num3 = Class11.smethod_27();
			}
			if (!characterAccountConfig.bool_7 && !characterAccountConfig.bool_8 && Class11.smethod_28(num3) >= 3000L)
			{
				try
				{
					smethod_3(characterAccountConfig);
					num = 0;
					num3 = 0L;
					num2 = Class85.smethod_4(characterAccountConfig);
				}
				catch
				{
				}
			}
			else
			{
				num2 = num17;
			}
		}
	}

	public static bool smethod_3(CharacterAccountConfig characterAccountConfig_0)
	{
		int num = -1;
		int int_ = 0;
		byte[] array = new byte[80];
		byte[] array2 = new byte[4];
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_97.uint_0;
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		bool flag = false;
		int num4 = Class85.smethod_4(characterAccountConfig_0);
		int num5 = 0;
		int int_2 = 0;
		byte[] array3 = new byte[4];
		for (uint num6 = 1u; num6 < Class56.int_1 && num4 > num5; num6++)
		{
			int num7 = 0;
			while ((characterAccountConfig_0.bool_7 || characterAccountConfig_0.bool_8) && num7 < 1000)
			{
				Thread.Sleep(10);
				num7++;
			}
			if (num6 % 10 == 0)
			{
				Thread.Sleep(15);
			}
			uint num8 = num3 + num6 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array3, 4, ref int_2);
			if (BitConverter.ToInt32(array3, 0) != 0)
			{
				continue;
			}
			uint uint_ = num8 + Class56.memorySignatureScanConfig_107.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array3, 1, ref int_2);
			if (array3[0] == 0)
			{
				continue;
			}
			uint num9 = Class85.smethod_1(characterAccountConfig_0, num6);
			if (num9 == 0)
			{
				continue;
			}
			num5++;
			if (!Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 1, ref int_) || array[0] == 0)
			{
				continue;
			}
			uint num10 = Class24.smethod_30(num2 + num9 * 20 + Class56.memorySignatureScanConfig_100.uint_0 - 8, characterAccountConfig_0.int_137);
			if ((int)num9 <= 0 || (num10 != 3 && num10 != 1))
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_108.uint_0, array2, 4, ref int_);
			int num11 = BitConverter.ToInt32(array2, 0);
			if (num11 > 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_109.uint_0, array2, 4, ref int_);
			int num12 = BitConverter.ToInt32(array2, 0);
			if (num12 == 1 || num12 == 2 || num12 == 4)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_120.uint_0, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_119.uint_0, array2, 4, ref int_);
			int num13 = BitConverter.ToInt32(array2, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_119.uint_0 + 4, array2, 4, ref int_);
			int num14 = BitConverter.ToInt32(array2, 0);
			if (num13 == 0 && num14 > 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, array.Length, ref int_);
			string text = Class1.smethod_3(array).Trim();
			if (text == null || text == string.Empty)
			{
				continue;
			}
			if (characterAccountConfig_0.string_4 != null)
			{
				int num15 = 0;
				while (num15 < characterAccountConfig_0.string_4.Length)
				{
					if (0 > Class11.smethod_1(text, characterAccountConfig_0.string_4[num15]))
					{
						num15++;
						continue;
					}
					goto IL_06b1;
				}
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_110.uint_0, array2, 4, ref int_);
			int num16 = BitConverter.ToInt32(array2, 0);
			if (num16 > 9)
			{
				continue;
			}
			if (characterAccountConfig_0.int_43[0] > 0 && num16 == 3)
			{
				if (characterAccountConfig_0.int_43[1] <= 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_118.uint_0 + (uint)((characterAccountConfig_0.int_43[1] - 1) * 16), array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
			}
			else if (characterAccountConfig_0.int_44[0] > 0 && num16 == 4)
			{
				if (characterAccountConfig_0.int_44[1] <= 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_118.uint_0 + (uint)((characterAccountConfig_0.int_44[1] - 1) * 16), array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
			}
			else if (characterAccountConfig_0.int_45[0] > 0 && num16 == 9)
			{
				if (characterAccountConfig_0.int_45[1] <= 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_118.uint_0 + (uint)((characterAccountConfig_0.int_45[1] - 1) * 16), array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
			}
			if (characterAccountConfig_0.int_47[0] > 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_114.uint_0, array2, 4, ref int_);
				if (characterAccountConfig_0.int_47[1] <= BitConverter.ToInt32(array2, 0))
				{
					continue;
				}
			}
			if (characterAccountConfig_0.int_48[0] > 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_115.uint_0, array2, 4, ref int_);
				if (characterAccountConfig_0.int_48[1] == BitConverter.ToInt32(array2, 0))
				{
					continue;
				}
			}
			if (characterAccountConfig_0.int_50 > 0)
			{
				int num17 = 0;
				int num18 = 0;
				bool flag2 = false;
				for (int i = 0; i < characterAccountConfig_0.itemAttributeFilterRule_0.Length; i++)
				{
					if (characterAccountConfig_0.itemAttributeFilterRule_0[i].int_0 <= 0)
					{
						continue;
					}
					num18++;
					flag2 = false;
					for (uint num19 = 0u; num19 < 6; num19++)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_118.uint_0 + num19 * 16, array2, 4, ref int_);
						int num20 = BitConverter.ToInt32(array2, 0);
						if (characterAccountConfig_0.itemAttributeFilterRule_0[i].int_1 == num20)
						{
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_118.uint_0 + num19 * 16 + 4, array2, 4, ref int_);
							int num21 = BitConverter.ToInt32(array2, 0);
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_118.uint_0 + num19 * 16 + 12, array2, 4, ref int_);
							int num22 = BitConverter.ToInt32(array2, 0);
							bool flag3 = characterAccountConfig_0.itemAttributeFilterRule_0[i].int_2 <= num21 && num21 > 0;
							bool flag4 = characterAccountConfig_0.itemAttributeFilterRule_0[i].int_2 <= num22 && num22 > 0;
							bool flag5 = characterAccountConfig_0.itemAttributeFilterRule_0[i].int_2 <= 0;
							if (flag3 || flag4 || flag5)
							{
								num17++;
								flag2 = true;
								break;
							}
						}
					}
					if (flag2 || characterAccountConfig_0.int_41 <= 0)
					{
						continue;
					}
					goto IL_06b1;
				}
				if (flag2 = num18 == 0 || (characterAccountConfig_0.int_41 > 0 && num18 <= num17) || (characterAccountConfig_0.int_41 <= 0 && num17 > 0))
				{
					continue;
				}
			}
			goto IL_06b1;
			IL_06b1:
			if (!flag)
			{
				num = Class87.smethod_3(Form1.characterAccountConfig_1, characterAccountConfig_0.int_136);
				if (0 <= num)
				{
					Form1.characterAccountConfig_1[num].bool_9 = true;
				}
				flag = true;
				bool_1 = true;
				Thread.Sleep(300);
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + num9 * 20 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array2, 4, ref int_);
			uint num23 = BitConverter.ToUInt32(array2, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + num9 * 20 + Class56.memorySignatureScanConfig_100.uint_0, array2, 4, ref int_);
			uint num24 = BitConverter.ToUInt32(array2, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 4, ref int_);
			int num25 = BitConverter.ToInt32(array2, 0);
			if (num25 > 0)
			{
				Class75.smethod_121(characterAccountConfig_0);
				Thread.Sleep(300);
			}
			int num26 = 0;
			num25 = 0;
			while (num26 < 150)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) <= 0)
				{
					if (num26 % 40 == 0)
					{
						Class75.smethod_46(characterAccountConfig_0, num23, num24, 3u, num23, num24, 1u);
					}
					num26++;
					Thread.Sleep(10);
					continue;
				}
				num25 = 1;
				break;
			}
			if (num25 <= 0)
			{
				continue;
			}
			uint[] uint_2 = null;
			uint num27 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
			for (uint num28 = 1u; num28 < 256; num28++)
			{
				if (num28 % 10 == 0)
				{
					Thread.Sleep(15);
				}
				uint num29 = num27 + num28 * Class56.memorySignatureScanConfig_127.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num29 + Class56.memorySignatureScanConfig_138.uint_0, array, 1, ref int_);
				if (array[0] != 0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num29 + Class56.memorySignatureScanConfig_137.uint_0, array2, 4, ref int_);
					if (BitConverter.ToInt32(array2, 0) > 0)
					{
						Class11.smethod_41(ref uint_2, num28);
					}
				}
			}
			Class75.smethod_121(characterAccountConfig_0);
			Thread.Sleep(300);
			for (uint num30 = 1u; num30 < 256; num30++)
			{
				if (num30 % 10 == 0)
				{
					Thread.Sleep(15);
				}
				uint num31 = num27 + num30 * Class56.memorySignatureScanConfig_127.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num31 + Class56.memorySignatureScanConfig_138.uint_0, array, 1, ref int_);
				byte b = (byte)text[0];
				if (array[0] != b)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num31 + Class56.memorySignatureScanConfig_137.uint_0, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) <= 0)
				{
					continue;
				}
				if (uint_2 != null)
				{
					bool flag6 = false;
					for (int j = 0; j < uint_2.Length; j++)
					{
						if (uint_2[j] == num30)
						{
							flag6 = true;
							break;
						}
					}
					if (flag6)
					{
						continue;
					}
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num31, array2, 4, ref int_);
				int int_3 = BitConverter.ToInt32(array2, 0);
				smethod_4(ref characterAccountConfig_0.gstruct40_0, num30, int_3);
				smethod_4(ref gstruct40_0, num30, int_3);
			}
		}
		if (flag)
		{
			bool_1 = false;
			num = Class87.smethod_3(Form1.characterAccountConfig_1, characterAccountConfig_0.int_136);
			if (num >= 0)
			{
				if (characterAccountConfig_0.gstruct40_0 != null && characterAccountConfig_0.gstruct40_0.Length != 0)
				{
					Form1.characterAccountConfig_1[num].gstruct40_0 = new GStruct40[characterAccountConfig_0.gstruct40_0.Length];
					for (int k = 0; k < characterAccountConfig_0.gstruct40_0.Length; k++)
					{
						Form1.characterAccountConfig_1[num].gstruct40_0[k].uint_0 = characterAccountConfig_0.gstruct40_0[k].uint_0;
						Form1.characterAccountConfig_1[num].gstruct40_0[k].long_0 = characterAccountConfig_0.gstruct40_0[k].long_0;
						Form1.characterAccountConfig_1[num].gstruct40_0[k].int_0 = characterAccountConfig_0.gstruct40_0[k].int_0;
					}
				}
				else
				{
					Form1.characterAccountConfig_1[num].gstruct40_0 = null;
				}
				Thread.Sleep(600);
				Form1.characterAccountConfig_1[num].bool_9 = false;
				return true;
			}
			return false;
		}
		return false;
	}

	public static void smethod_4(ref GStruct40[] gstruct40_1, uint uint_0, int int_2, long long_0 = 0L)
	{
		try
		{
			if (long_0 == 0L)
			{
				long_0 = Class11.smethod_27();
			}
			if (gstruct40_1 != null && gstruct40_1.Length != 0)
			{
				int num = gstruct40_1.Length;
				GStruct40[] array = new GStruct40[num + 1];
				int num2 = 0;
				while (true)
				{
					if (num2 < num)
					{
						if (gstruct40_1[num2].uint_0 == uint_0 && gstruct40_1[num2].int_0 == int_2)
						{
							break;
						}
						array[num2].int_0 = gstruct40_1[num2].int_0;
						array[num2].uint_0 = gstruct40_1[num2].uint_0;
						array[num2].long_0 = gstruct40_1[num2].long_0;
						num2++;
						continue;
					}
					ref GStruct40 reference = ref array[num];
					reference = new GStruct40
					{
						uint_0 = uint_0,
						int_0 = int_2,
						long_0 = long_0
					};
					gstruct40_1 = new GStruct40[num + 1];
					for (int i = 0; i <= num; i++)
					{
						gstruct40_1[i].int_0 = array[i].int_0;
						gstruct40_1[i].uint_0 = array[i].uint_0;
						gstruct40_1[i].long_0 = array[i].long_0;
					}
					return;
				}
				gstruct40_1[num2].long_0 = long_0;
			}
			else
			{
				gstruct40_1 = new GStruct40[1]
				{
					new GStruct40
					{
						uint_0 = uint_0,
						int_0 = int_2,
						long_0 = long_0
					}
				};
			}
		}
		catch
		{
		}
	}

	public static void smethod_5(ref GStruct40[] gstruct40_1, uint uint_0, int int_2)
	{
		try
		{
			if (gstruct40_1 != null && gstruct40_1.GetLength(0) != 0)
			{
				int num = gstruct40_1.Length;
				int num2 = 0;
				GStruct40[] array = new GStruct40[num];
				for (int i = 0; i < num; i++)
				{
					if (gstruct40_1[i].uint_0 != uint_0 || gstruct40_1[i].int_0 != int_2)
					{
						array[num2].uint_0 = gstruct40_1[i].uint_0;
						array[num2].int_0 = gstruct40_1[i].int_0;
						array[num2].long_0 = gstruct40_1[i].long_0;
						num2++;
					}
				}
				if (num2 != 0)
				{
					if (num2 < num)
					{
						gstruct40_1 = new GStruct40[num2];
						for (int j = 0; j < num2; j++)
						{
							gstruct40_1[j].uint_0 = array[j].uint_0;
							gstruct40_1[j].int_0 = array[j].int_0;
							gstruct40_1[j].long_0 = array[j].long_0;
						}
					}
				}
				else
				{
					gstruct40_1 = null;
				}
			}
			else
			{
				gstruct40_1 = null;
			}
		}
		catch
		{
		}
	}

	public static GStruct33 smethod_6(CharacterAccountConfig characterAccountConfig_0)
	{
		GStruct33 result = default(GStruct33);
		if ((int)Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_0.int_137) <= 0)
		{
			return result;
		}
		int int_ = 0;
		byte[] array = new byte[80];
		byte[] array2 = new byte[4];
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_97.uint_0;
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		byte[] array3 = new byte[4];
		int int_2 = 0;
		int num3 = Class85.smethod_4(characterAccountConfig_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class56.int_1; num5++)
		{
			if (num3 <= num4)
			{
				break;
			}
			uint num6 = num2 + num5 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array3, 4, ref int_2);
			if (BitConverter.ToInt32(array3, 0) != 0)
			{
				continue;
			}
			uint uint_ = num6 + Class56.memorySignatureScanConfig_107.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array3, 1, ref int_2);
			if (array3[0] == 0)
			{
				continue;
			}
			uint num7 = Class85.smethod_1(characterAccountConfig_0, num5);
			if ((int)num7 > 0)
			{
				num4++;
				uint num8 = Class24.smethod_30(num + num7 * 20 + Class56.memorySignatureScanConfig_100.uint_0 - 8, characterAccountConfig_0.int_137);
				if ((int)num7 > 0 && num8 == 1)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, array.Length, ref int_);
					result.string_0 = Class1.smethod_3(array);
					result.uint_1 = num5;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_111.uint_0, array2, 4, ref int_);
					result.uint_4 = BitConverter.ToUInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_112.uint_0, array2, 4, ref int_);
					result.uint_5 = BitConverter.ToUInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_109.uint_0, array2, 4, ref int_);
					result.int_2 = BitConverter.ToInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_110.uint_0, array2, 4, ref int_);
					result.int_1 = BitConverter.ToInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_108.uint_0, array2, 4, ref int_);
					result.int_0 = BitConverter.ToInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_120.uint_0, array2, 4, ref int_);
					result.int_3 = BitConverter.ToInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6, array2, 4, ref int_);
					result.uint_0 = BitConverter.ToUInt32(array2, 0);
					break;
				}
			}
		}
		return result;
	}
}
