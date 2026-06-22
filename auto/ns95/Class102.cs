using System;
using System.Threading;
using ns100;
using ns11;
using ns23;
using ns43;
using ns53;
using ns61;
using ns71;
using ns79;
using ns83;

namespace ns95;

internal class Class102
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
						Form1.characterAccountConfig_1[num].bool_18 = false;
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_18)
					{
						break;
					}
					Form1.characterAccountConfig_1[num].bool_18 = true;
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
		int num2 = 0;
		int int_2 = 0;
		int num3 = 0;
		int num4 = 0;
		long long_ = 0L;
		uint num5 = 0u;
		byte[] array = new byte[4];
		byte[] byte_ = new byte[4];
		byte[] byte_2 = new byte[4] { 5, 0, 0, 0 };
		byte[] bytes = BitConverter.GetBytes(171);
		byte[] bytes2 = BitConverter.GetBytes(173);
		uint[] array2 = new uint[2];
		int num6 = 0;
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		while (true)
		{
			num--;
			Thread.Sleep(500);
			if (num < 0)
			{
				num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
				if (Class11.bool_0 || num2 < 0 || !Form1.characterAccountConfig_1[num2].bool_25)
				{
					break;
				}
				num = 5;
				characterAccountConfig_ = Form1.characterAccountConfig_1[num2];
			}
			if (Class46.characterSyncSnapshot_0.int_0 <= 0 || characterAccountConfig_.int_136 == Class46.characterSyncSnapshot_0.int_0 || Class11.smethod_28(long_) < 1000L)
			{
				continue;
			}
			num6 = 1 - num6;
			if (num6 <= 0)
			{
				if (characterAccountConfig_.int_84[1] <= 0)
				{
					continue;
				}
				if (num4 <= 0)
				{
					num4 = Class83.smethod_16(characterAccountConfig_, 173);
				}
				if (num4 <= 0)
				{
					continue;
				}
			}
			else
			{
				if (characterAccountConfig_.int_84[0] <= 0)
				{
					continue;
				}
				if (num3 <= 0)
				{
					num3 = Class83.smethod_16(characterAccountConfig_, 171);
				}
				if (num3 <= 0)
				{
					continue;
				}
			}
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_2);
			uint num7 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, num7 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_2);
			uint num8 = BitConverter.ToUInt32(array, 0);
			uint num9 = num8 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_2);
			uint num10 = BitConverter.ToUInt32(array, 0);
			uint num11 = num10 + num9;
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_54.uint_0, array, 4, ref int_2);
			int num12 = BitConverter.ToInt32(array, 0);
			if (num12 <= 0 || num12 == 4)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_2);
			int num13 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_2);
			int num14 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_2);
			int num15 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_2);
			int num16 = BitConverter.ToInt32(array, 0);
			if (num16 <= 0 || num14 == 0 || num15 != Class46.characterSyncSnapshot_0.int_4 || num13 == 0 || num13 == 10 || num13 == 21)
			{
				continue;
			}
			uint[] uint_ = new uint[2]
			{
				Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_.int_137),
				Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_.int_137)
			};
			if (Class64.smethod_18(uint_, Class46.characterSyncSnapshot_0.uint_4) > 400000L)
			{
				continue;
			}
			int num17 = 0;
			uint num18 = 0u;
			if (num5 != 0)
			{
				num18 = num10 + num5 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18, array, 4, ref int_2);
				int num19 = BitConverter.ToInt32(array, 0);
				if (num19 == Class46.characterSyncSnapshot_0.uint_2)
				{
					goto IL_0485;
				}
			}
			num5 = 0u;
			uint uint_2 = characterAccountConfig_.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, uint_2, array, 4, ref int_2);
			int num20 = BitConverter.ToInt32(array, 0);
			if (num20 <= 1)
			{
				continue;
			}
			int num21 = 0;
			uint num22;
			for (num22 = 1u; num22 < 256 && num20 > num21; num22++)
			{
				num18 = num10 + num22 * Class56.memorySignatureScanConfig_15.uint_0;
				uint uint_3 = num18 + Class56.memorySignatureScanConfig_16.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, uint_3, array, 4, ref int_2);
				if (array[0] == 0)
				{
					continue;
				}
				num21++;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18, array, 4, ref int_2);
				int num23 = BitConverter.ToInt32(array, 0);
				if (num23 != Class46.characterSyncSnapshot_0.uint_2)
				{
					continue;
				}
				goto IL_0481;
			}
			goto IL_07b3;
			IL_07b3:
			if (num17 > 0)
			{
				Class75.smethod_2(characterAccountConfig_, Class75.uint_6, 0, 4);
			}
			long_ = Class11.smethod_27();
			continue;
			IL_0481:
			num5 = num22;
			goto IL_0485;
			IL_0485:
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_2);
			if (BitConverter.ToInt32(array, 0) > 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_2);
				int num24 = BitConverter.ToInt32(array, 0);
				if (num24 != 10 && num24 != 21)
				{
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18 + Class56.memorySignatureScanConfig_54.uint_0, array, 4, ref int_2);
					int num25 = BitConverter.ToInt32(array, 0);
					if (num25 == num12)
					{
						while (num17 <= 1)
						{
							for (uint num26 = 0u; num26 < 6; num26++)
							{
								uint num27 = Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_2.uint_0 + Class56.memorySignatureScanConfig_3.uint_0 * num26;
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18 + num27, array, 4, ref int_2);
								int num28 = BitConverter.ToInt32(array, 0);
								if ((num6 > 0 && num28 == 17) || (num6 == 0 && num28 == 13))
								{
									goto end_IL_07a6;
								}
							}
							Class75.smethod_2(characterAccountConfig_, Class75.uint_6, 1, 4);
							Class24.WriteProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_2);
							Thread.Sleep(100);
							for (int i = 0; i < 10; i++)
							{
								uint_ = new uint[2]
								{
									Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_.int_137),
									Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_.int_137)
								};
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_2);
								array2[0] = BitConverter.ToUInt32(array, 0);
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_2);
								array2[1] = BitConverter.ToUInt32(array, 0);
								if (Class64.smethod_18(uint_, array2) < 160000L)
								{
									break;
								}
								Class75.smethod_61(characterAccountConfig_, array2);
								Thread.Sleep(180);
							}
							uint value = num5;
							byte[] bytes3 = BitConverter.GetBytes(uint.MaxValue);
							byte[] bytes4 = BitConverter.GetBytes(value);
							Class24.WriteProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_37.uint_0, bytes3, 4, ref int_2);
							Class24.WriteProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_38.uint_0, bytes4, 4, ref int_2);
							if (num6 <= 0)
							{
								Class24.WriteProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_36.uint_0, bytes2, 4, ref int_2);
							}
							else
							{
								Class24.WriteProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_36.uint_0, bytes, 4, ref int_2);
							}
							Class24.WriteProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_35.uint_0, byte_2, 4, ref int_2);
							num17++;
							Thread.Sleep(450);
							continue;
							end_IL_07a6:
							break;
						}
					}
				}
			}
			goto IL_07b3;
		}
	}
}
