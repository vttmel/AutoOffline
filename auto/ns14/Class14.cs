using System;
using System.Threading;
using ns1;
using ns100;
using ns11;
using ns23;
using ns53;
using ns71;
using ns81;
using ns83;
using ns85;

namespace ns14;

internal class Class14
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
						Form1.characterAccountConfig_1[num].bool_39 = false;
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_39)
					{
						break;
					}
					Form1.characterAccountConfig_1[num].bool_39 = true;
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
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		int int_2 = 0;
		int num = -1;
		int num2 = -1;
		int num3 = 0;
		int num4 = -1;
		long num5 = 0L;
		long num6 = 0L;
		byte[] array = new byte[4];
		int num7 = -1;
		int num8 = 0;
		uint num9 = 0u;
		uint[,] array2 = null;
		while (true)
		{
			num8--;
			Thread.Sleep(300);
			if (num8 <= 0)
			{
				int num10 = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
				if (Class11.bool_0 || num10 < 0 || !Form1.characterAccountConfig_1[num10].bool_25)
				{
					break;
				}
				characterAccountConfig_ = Form1.characterAccountConfig_1[num10];
			}
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_2);
			int num11 = BitConverter.ToInt32(array, 0);
			if (num11 != 0 && (characterAccountConfig_.gstruct47_0[0].int_0 > 0 || characterAccountConfig_.gstruct47_0[1].int_0 > 0))
			{
				if (num7 != num11 || num9 == 0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_2);
					uint num12 = BitConverter.ToUInt32(array, 0);
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num12 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_2);
					uint num13 = BitConverter.ToUInt32(array, 0);
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_2);
					uint num14 = BitConverter.ToUInt32(array, 0);
					num9 = num14 + num13 * Class56.memorySignatureScanConfig_15.uint_0;
					num7 = num11;
					num6 = 0L;
				}
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num9 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_2);
				int num15 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num9 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_2);
				int num16 = BitConverter.ToInt32(array, 0);
				int num17 = Class89.smethod_39(characterAccountConfig_);
				if (num15 != 0 && num17 > 1)
				{
					switch (num16)
					{
					default:
						if (num6 == 0L || Class11.smethod_28(num6) > 15000L)
						{
							array2 = null;
							uint[] array3 = smethod_3(characterAccountConfig_, characterAccountConfig_.gstruct47_0[0].string_0, characterAccountConfig_.gstruct47_0[0].int_5);
							uint[] array4 = smethod_3(characterAccountConfig_, characterAccountConfig_.gstruct47_0[1].string_0, characterAccountConfig_.gstruct47_0[1].int_5);
							if (array3 != null && array4 != null)
							{
								array2 = new uint[2, 2]
								{
									{
										array3[0],
										array3[1]
									},
									{
										array4[0],
										array4[1]
									}
								};
							}
							num6 = Class11.smethod_27();
						}
						if (array2 != null)
						{
							num2++;
							if (num2 != 0 && num2 != 1)
							{
								num2 = 0;
							}
							if (characterAccountConfig_.gstruct47_0[num2].int_0 > 0 && characterAccountConfig_.gstruct47_0[num2].int_1 > 0 && characterAccountConfig_.gstruct47_0[num2].int_5 != null)
							{
								int int_3 = characterAccountConfig_.gstruct47_0[num2].int_1;
								int int_4 = characterAccountConfig_.gstruct47_0[num2].int_2;
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, num9 + Class56.memorySignatureScanConfig_45.uint_0, array, 4, ref int_2);
								long num18 = BitConverter.ToInt32(array, 0);
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, num9 + Class56.memorySignatureScanConfig_46.uint_0, array, 4, ref int_2);
								long num19 = BitConverter.ToInt32(array, 0);
								double num20 = -1.0;
								double num21 = -1.0;
								int num22 = -1;
								switch (int_3)
								{
								case 6:
								case 7:
								{
									Class24.ReadProcessMemory(characterAccountConfig_.int_137, num9 + Class56.uint_7, array, 4, ref int_2);
									num22 = BitConverter.ToInt32(array, 0);
									Class24.ReadProcessMemory(characterAccountConfig_.int_137, num9 + Class56.uint_8, array, 4, ref int_2);
									int num27 = BitConverter.ToInt32(array, 0);
									if (num22 < num27 && num27 < num22 * 3)
									{
										num22 = num27;
									}
									break;
								}
								case 5:
								{
									Class24.ReadProcessMemory(characterAccountConfig_.int_137, num9 + Class56.memorySignatureScanConfig_47.uint_0, array, 4, ref int_2);
									long num23 = BitConverter.ToInt32(array, 0);
									Class24.ReadProcessMemory(characterAccountConfig_.int_137, num9 + Class56.memorySignatureScanConfig_47.uint_0 + 4, array, 4, ref int_2);
									long num24 = BitConverter.ToInt32(array, 0);
									Class24.ReadProcessMemory(characterAccountConfig_.int_137, num9 + Class56.memorySignatureScanConfig_48.uint_0, array, 4, ref int_2);
									long num25 = BitConverter.ToInt32(array, 0);
									Class24.ReadProcessMemory(characterAccountConfig_.int_137, num9 + Class56.memorySignatureScanConfig_48.uint_0 + 4, array, 4, ref int_2);
									long num26 = BitConverter.ToInt32(array, 0);
									if (num24 > num23 && num24 < 5000000L)
									{
										num23 = num24;
									}
									if (num26 > num25 && num26 < 5000000L)
									{
										num25 = num26;
									}
									num20 = num18 * 100L / num23;
									num21 = num19 * 100L / num25;
									break;
								}
								}
								if (((int_3 == 1 && num19 <= int_4) || (int_3 == 2 && num19 > int_4) || (int_3 == 3 && num18 <= int_4) || (int_3 == 4 && num18 > int_4) || (int_3 == 5 && num20 >= (double)int_4 && num21 >= (double)int_4) || (int_3 == 6 && num22 <= int_4) || (int_3 == 7 && num22 > int_4)) && !smethod_2(characterAccountConfig_, array2[num2, 0], array2[num2, 1]))
								{
									array2 = null;
									num6 = 0L;
									continue;
								}
							}
							if (DateTime.Now.Ticks < num3 * 10000 + num5)
							{
								continue;
							}
							num5 = DateTime.Now.Ticks;
							num3 = 1000;
							num4 = -1;
							while (true)
							{
								num++;
								if (num != 0 && num != 1)
								{
									num = 0;
								}
								if (characterAccountConfig_.gstruct47_0[num].int_0 <= 0 || characterAccountConfig_.gstruct47_0[num].int_1 != 0 || characterAccountConfig_.gstruct47_0[num].int_5 == null || smethod_2(characterAccountConfig_, array2[num, 0], array2[num, 1]))
								{
									if (num4 >= 0)
									{
										if (num == num4)
										{
											num = -1;
											break;
										}
									}
									else
									{
										num4 = num;
									}
									continue;
								}
								array2 = null;
								num6 = 0L;
								break;
							}
						}
						else
						{
							Thread.Sleep(300);
						}
						continue;
					case 10:
					case 21:
						Thread.Sleep(300);
						num6 = 0L;
						continue;
					case 0:
						break;
					}
				}
				num7 = -1;
				num6 = 0L;
				Thread.Sleep(300);
			}
			else
			{
				Thread.Sleep(300);
			}
		}
	}

	private static bool smethod_2(CharacterAccountConfig characterAccountConfig_0, uint uint_0, uint uint_1)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + (uint_0 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0);
		if (num2 == uint_1)
		{
			uint num3 = num + uint_0 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
			if (array[0] == 3)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_);
				int num4 = array[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_);
				int int_2 = array[0];
				Class75.smethod_43(characterAccountConfig_0, num2, num4, int_2);
			}
			return true;
		}
		return false;
	}

	private static uint[] smethod_3(CharacterAccountConfig characterAccountConfig_0, string string_0, int[] int_1)
	{
		if (Class56.uint_0 != null && string_0 != null && !(string_0 == string.Empty) && int_1 != null)
		{
			int int_2 = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_2);
			uint num = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_2);
			uint num2 = BitConverter.ToUInt32(array2, 0);
			byte[] array3 = new byte[80];
			int num3 = Class85.smethod_4(characterAccountConfig_0);
			int num4 = 0;
			for (uint num5 = 1u; num5 < Class56.int_1; num5++)
			{
				if (num3 <= num4)
				{
					break;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + (num5 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_2);
				uint num6 = BitConverter.ToUInt32(array2, 0);
				if (num6 == 0)
				{
					continue;
				}
				uint num7 = num2 + num6 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_2);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_2);
				if (array[0] == 0)
				{
					continue;
				}
				num4++;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_2);
				if (array[0] != 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_110.uint_0, array, 1, ref int_2);
				if (array[0] != 0 && array[0] != 1)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_2);
				if (Class1.smethod_3(array3) != string_0)
				{
					continue;
				}
				bool flag = true;
				for (int i = 0; i < Class56.uint_0.Length; i++)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.uint_0[i], array2, 4, ref int_2);
					int num8 = BitConverter.ToInt32(array2, 0);
					if (num8 != int_1[i])
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					return new uint[2] { num5, num6 };
				}
			}
			return null;
		}
		return null;
	}
}
