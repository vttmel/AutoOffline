using System;
using System.Threading;
using ns10;
using ns100;
using ns11;
using ns13;
using ns23;
using ns28;
using ns3;
using ns35;
using ns42;
using ns43;
using ns50;
using ns53;
using ns61;
using ns71;
using ns83;
using ns85;
using ns88;

namespace ns38;

internal class Class41
{
	public static int int_0;

	private static uint[,] uint_0;

	static Class41()
	{
		int_0 = 878;
		uint[,] array_ = new uint[6, 2];
		Class10.smethod_4(array_, 177087);
		uint_0 = array_;
	}

	public static int smethod_0(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		string text = "truyÒn tèng";
		long long_ = 0L;
		uint[] array2 = null;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		while (true)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
			int num5 = BitConverter.ToInt32(array, 0);
			if (num5 != int_0)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
			uint num6 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
			uint num7 = BitConverter.ToUInt32(array, 0);
			uint num8 = num7 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
			uint num9 = BitConverter.ToUInt32(array, 0);
			uint num10 = num9 + num8;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_);
			BitConverter.ToInt32(array, 0);
			uint[] array3 = new uint[2]
			{
				Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
				Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
			};
			int num11 = Class64.smethod_20(uint_0, array3);
			uint[] array4 = new uint[2]
			{
				uint_0[num11, 0],
				uint_0[num11, 1]
			};
			long num12 = Class64.smethod_18(array3, array4);
			int num13 = Class87.smethod_3(Form1.characterAccountConfig_1, characterAccountConfig_0.int_136);
			int i;
			if (!Class11.bool_0 && num13 >= 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_);
				int num14 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
				int num15 = BitConverter.ToInt32(array, 0);
				int num16 = Class89.smethod_39(characterAccountConfig_0);
				if (num15 != 0 && num14 != 0 && num5 != 0 && num16 > 1 && num14 != 10 && num14 != 21)
				{
					Thread.Sleep(300);
					if (array2 == null)
					{
						array2 = new uint[2]
						{
							array3[0],
							array3[1]
						};
						num = 0;
					}
					if (num > 6)
					{
						long num17 = Class64.smethod_18(array2, array3);
						array2 = null;
						if (num17 < 180000L)
						{
							Class13.smethod_2(characterAccountConfig_0, bool_0: false);
							Class64.smethod_2(characterAccountConfig_0, array3, Class46.characterSyncSnapshot_0.uint_4, 600);
							continue;
						}
						num = 0;
					}
					if (num12 >= 22500L)
					{
						Class64.smethod_29(characterAccountConfig_0, bool_0: false);
						if (num12 < 1000000L)
						{
							Class13.smethod_2(characterAccountConfig_0, bool_0: false);
							Class75.smethod_61(characterAccountConfig_0, array4);
							num++;
							Thread.Sleep(200);
						}
						else if (Class11.smethod_28(long_) > 4000L)
						{
							Class13.smethod_1(characterAccountConfig_0, array4);
							long_ = Class11.smethod_27();
							num += 2;
						}
						continue;
					}
					for (i = 0; i < 10; i++)
					{
						Class75.smethod_61(characterAccountConfig_0, array4);
						Thread.Sleep(300);
						array3 = new uint[2]
						{
							Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
							Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
						};
						long num18 = Class64.smethod_18(array3, array4);
						if (num18 < 11250L)
						{
							break;
						}
					}
					i = 0;
					if (num2 > 0)
					{
						string text2 = Class3.smethod_16(characterAccountConfig_0, num2, ref array4, 32);
						if (text2 != null && 0 <= Class11.smethod_1(text2.ToUpper(), text.ToUpper()))
						{
							goto IL_0428;
						}
					}
					num2 = Class3.smethod_15(characterAccountConfig_0, text, ref array4, 3, bool_0: false);
					if (num2 <= 0)
					{
						if (num3 <= 0)
						{
							Class64.smethod_29(characterAccountConfig_0, bool_0: true);
							Thread.Sleep(300);
							Class75.smethod_57(characterAccountConfig_0, "Switch([[sit]])");
							Thread.Sleep(300);
							continue;
						}
						return 1;
					}
					goto IL_0428;
				}
				return 1;
			}
			return 1;
			IL_0428:
			Class95.smethod_8(characterAccountConfig_0);
			Thread.Sleep(100);
			Class38.smethod_10(characterAccountConfig_0, (uint)num2);
			Thread.Sleep(200);
			i = 0;
			do
			{
				if (Class95.smethod_0(characterAccountConfig_0) < 0)
				{
					i++;
					Thread.Sleep(100);
					continue;
				}
				Class95.smethod_6(characterAccountConfig_0, "khái khu");
				return 1;
			}
			while (i <= 15);
			if (num4 <= 2)
			{
				num4++;
				Class64.smethod_12(characterAccountConfig_0);
				Thread.Sleep(300);
				continue;
			}
			return 1;
		}
		return 1;
	}

	public static int smethod_1(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		long long_ = 0L;
		uint[] array2 = null;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		string text = "truyÒn tèng";
		string[] array3 = new string[4] { "12h", "6h", "9h", "3h" };
		uint[,] array4 = new uint[4, 2];
		Class10.smethod_4(array4, 176194);
		uint[,] array5 = array4;
		int num5 = 0;
		int[] array6 = new int[10];
		for (int i = 0; i < array6.Length; i++)
		{
			array6[i] = 4;
		}
		while (true)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
			int num6 = BitConverter.ToInt32(array, 0);
			if (num6 == int_0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref array6[0]);
				uint num7 = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref array6[1]);
				uint num8 = BitConverter.ToUInt32(array, 0);
				uint num9 = num8 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref array6[2]);
				uint num10 = BitConverter.ToUInt32(array, 0);
				uint num11 = num10 + num9;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref array6[3]);
				BitConverter.ToInt32(array, 0);
				uint[] array7 = new uint[2]
				{
					Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
				uint[] array8 = new uint[2];
				if ((Form1.int_10 > 0 || Form1.int_11 > 0) && Class46.characterSyncSnapshot_1.int_4 == int_0 && Class46.characterSyncSnapshot_1.uint_4 != null)
				{
					array8[0] = Class46.characterSyncSnapshot_1.uint_4[0];
					array8[1] = Class46.characterSyncSnapshot_1.uint_4[1];
				}
				else if (Class46.characterSyncSnapshot_0.uint_4 != null)
				{
					array8[0] = Class46.characterSyncSnapshot_0.uint_4[0];
					array8[1] = Class46.characterSyncSnapshot_0.uint_4[1];
				}
				long num12 = Class64.smethod_18(array7, array8);
				int num13 = Class64.smethod_20(uint_0, array7);
				uint[] array9 = new uint[2]
				{
					uint_0[num13, 0],
					uint_0[num13, 1]
				};
				long num14 = Class64.smethod_18(array7, array9);
				int num15 = Class64.smethod_20(array5, array8);
				uint[] uint_ = new uint[2]
				{
					array5[num15, 0],
					array5[num15, 1]
				};
				long num16 = Class64.smethod_18(array8, uint_);
				if (num12 < num14 + num16 || num15 == num13)
				{
					break;
				}
				int num17 = Class87.smethod_3(Form1.characterAccountConfig_1, characterAccountConfig_0.int_136);
				if (!Class11.bool_0 && num17 >= 0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref array6[4]);
					int num18 = BitConverter.ToInt32(array, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref array6[5]);
					int num19 = BitConverter.ToInt32(array, 0);
					int num20 = Class89.smethod_39(characterAccountConfig_0);
					if (num19 != 0 && num18 != 0 && num6 != 0 && num20 > 1 && num18 != 10 && num18 != 21)
					{
						num5 = 5;
						int num21 = 0;
						while (true)
						{
							if (num21 <= num5)
							{
								if (array6[num21] == 0)
								{
									break;
								}
								num21++;
								continue;
							}
							Thread.Sleep(300);
							if (array2 == null)
							{
								array2 = new uint[2]
								{
									array7[0],
									array7[1]
								};
								num = 0;
							}
							if (num > 6)
							{
								long num22 = Class64.smethod_18(array2, array7);
								array2 = null;
								if (num22 < 180000L)
								{
									Class13.smethod_2(characterAccountConfig_0, bool_0: false);
									Class64.smethod_2(characterAccountConfig_0, array7, Class46.characterSyncSnapshot_0.uint_4, 600);
									break;
								}
								num = 0;
							}
							if (num14 >= 22500L)
							{
								Class64.smethod_29(characterAccountConfig_0, bool_0: false);
								if (num14 < 1000000L)
								{
									Class13.smethod_2(characterAccountConfig_0, bool_0: false);
									Class75.smethod_61(characterAccountConfig_0, array9);
									num++;
									Thread.Sleep(200);
								}
								else if (Class11.smethod_28(long_) > 4000L)
								{
									Class13.smethod_1(characterAccountConfig_0, array9);
									long_ = Class11.smethod_27();
									num += 2;
								}
								break;
							}
							int j;
							for (j = 0; j < 10; j++)
							{
								Class75.smethod_61(characterAccountConfig_0, array9);
								Thread.Sleep(300);
								array7 = new uint[2]
								{
									Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
									Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
								};
								long num23 = Class64.smethod_18(array7, array9);
								if (num23 < 11250L)
								{
									break;
								}
							}
							j = 0;
							if (num2 > 0)
							{
								string text2 = Class3.smethod_16(characterAccountConfig_0, num2, ref array9, 32);
								if (text2 != null && 0 <= Class11.smethod_1(text2.ToUpper(), text.ToUpper()))
								{
									goto IL_05c1;
								}
							}
							num2 = Class3.smethod_15(characterAccountConfig_0, text, ref array9, 3, bool_0: false);
							if (num2 <= 0)
							{
								if (num3 <= 0)
								{
									Class64.smethod_29(characterAccountConfig_0, bool_0: true);
									Thread.Sleep(300);
									Class75.smethod_57(characterAccountConfig_0, "Switch([[sit]])");
									Thread.Sleep(300);
									break;
								}
								return 1;
							}
							goto IL_05c1;
							IL_05c1:
							Class95.smethod_8(characterAccountConfig_0);
							Thread.Sleep(100);
							Class38.smethod_10(characterAccountConfig_0, (uint)num2);
							Thread.Sleep(200);
							j = 0;
							do
							{
								if (Class95.smethod_0(characterAccountConfig_0) < 0)
								{
									j++;
									Thread.Sleep(100);
									if (Class95.Class92.smethod_4(characterAccountConfig_0))
									{
										Class95.Class92.smethod_5(characterAccountConfig_0);
									}
									continue;
								}
								Class95.smethod_6(characterAccountConfig_0, array3[num15]);
								return 1;
							}
							while (j <= 15);
							if (num4 <= 2)
							{
								num4++;
								Class64.smethod_12(characterAccountConfig_0);
								Thread.Sleep(300);
								break;
							}
							return 1;
						}
						continue;
					}
					return 1;
				}
				return 1;
			}
			return 1;
		}
		return 0;
	}

	public static int smethod_2(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		uint[] array2 = null;
		bool flag = false;
		bool flag2 = false;
		int num = 0;
		long long_ = 0L;
		while (true)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
			int num2 = BitConverter.ToInt32(array, 0);
			if (num2 != int_0)
			{
				Thread.Sleep(300);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
				uint num3 = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
				uint num4 = BitConverter.ToUInt32(array, 0);
				uint num5 = num4 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
				uint num6 = BitConverter.ToUInt32(array, 0);
				uint num7 = num6 + num5;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_);
				int num8 = BitConverter.ToInt32(array, 0);
				uint[] uint_ = new uint[2]
				{
					Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
				if (num8 > 0)
				{
					if (!flag && Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0)
					{
						flag = true;
						if (Class29.smethod_7(characterAccountConfig_0, 78, "b¾c"))
						{
							Class64.smethod_11(characterAccountConfig_0);
							Thread.Sleep(100);
							continue;
						}
					}
					if (!flag2)
					{
						flag2 = true;
						if (Class64.smethod_14(characterAccountConfig_0))
						{
							Class64.smethod_11(characterAccountConfig_0);
							Thread.Sleep(100);
							continue;
						}
					}
				}
				int[] array3 = Class64.smethod_9(num2);
				if (array3 == null)
				{
					break;
				}
				if (array3[1] != 0)
				{
					int num9 = Class64.int_0[array3[0], 0];
					if (!flag && Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0)
					{
						flag = true;
						if (Class29.smethod_7(characterAccountConfig_0, num9))
						{
							Class64.smethod_11(characterAccountConfig_0);
							Thread.Sleep(100);
							continue;
						}
					}
					if (num8 > 0)
					{
						array2 = Class45.smethod_11(uint_, num9, "Xa phu");
						if (array2 != null && num <= 5)
						{
							if (Class11.smethod_28(long_) > 4000L)
							{
								Class13.smethod_1(characterAccountConfig_0, array2);
								long_ = Class11.smethod_27();
							}
							continue;
						}
						return -2;
					}
					Class13.smethod_2(characterAccountConfig_0, bool_0: false);
					Class53.smethod_5(characterAccountConfig_0, num9);
					return -2;
				}
				array2 = Class45.smethod_11(uint_, num2, "Xa phu");
				if (array2 == null)
				{
					return -3;
				}
				Class53.smethod_2(characterAccountConfig_0, "ChiÕn Long Th", array2);
				return 2;
			}
			return 1;
		}
		return -1;
	}
}
