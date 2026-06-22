using System;
using System.Threading;
using ns1;
using ns10;
using ns100;
using ns11;
using ns119;
using ns121;
using ns13;
using ns23;
using ns35;
using ns42;
using ns43;
using ns44;
using ns53;
using ns71;
using ns81;
using ns83;
using ns85;
using ns88;

namespace ns61;

internal class Class64
{
	public static string[,] string_0;

	public static int[,] int_0;

	static Class64()
	{
		string_0 = new string[8, 3]
		{
			{ "T\u00ad¬ng D\u00ad¬ng", "Ba L\u00a8ng huyÖn", "Nam Nh¹c trÊn" },
			{ "D\u00ad¬ng Ch©u", "§¹o H\u00ad¬ng th«n", null },
			{ "Ph\u00adîng T\u00adêng", "Long M«n trÊn", null },
			{ "Ph\u00adîng T\u00adêng", "VÜnh L¹c trÊn", null },
			{ "§¹i L", "Th¹ch Cæ trÊn", null },
			{ "Thµnh §«", "Giang T©n Th«n", null },
			{ "L©m An", "Long TuyÒn th«n", null },
			{ "BiÖn Kinh", "Chu Tiªn trÊn", null }
		};
		int[,] array_ = new int[8, 3];
		Class10.smethod_4(array_, 288849);
		int_0 = array_;
	}

	public static int smethod_0(uint uint_0, int[] int_1, int int_2)
	{
		int num = 0;
		int num2 = 0;
		int_2 += 50;
		if (int_1.Length > 5)
		{
			for (int i = 0; i < 3; i++)
			{
				if (int_1[i] > 0 && int_1[i + 3] > 0)
				{
					if (num2 != num)
					{
						num2 = num;
						Thread.Sleep(int_2);
					}
					Class24.smethod_4(uint_0, (uint)int_1[i + 3]);
					num++;
				}
			}
		}
		return num;
	}

	public static int smethod_1(long long_0)
	{
		if (long_0 >= 600000L)
		{
			if (long_0 >= 1000000L)
			{
				if (long_0 < 1500000L)
				{
					return 5000;
				}
				if (long_0 < 2000000L)
				{
					return 6000;
				}
				if (long_0 < 2500000L)
				{
					return 7000;
				}
				if (long_0 >= 3000000L)
				{
					if (long_0 >= 3500000L)
					{
						return 10000;
					}
					return 9000;
				}
				return 8000;
			}
			return 4000;
		}
		return 3000;
	}

	public static void smethod_2(CharacterAccountConfig characterAccountConfig_0, uint[] uint_0, uint[] uint_1, int int_1 = 1000)
	{
		if (!Class11.smethod_63(uint_0) || !Class11.smethod_63(uint_1))
		{
			return;
		}
		int num = 90;
		num = ((uint_1[0] < uint_0[0]) ? 210 : 45);
		double num2 = (double)Math.Abs(num) * 3.14 / 180.0;
		uint[] uint_2 = new uint[2]
		{
			(uint)((double)uint_0[0] + 400.0 * Math.Cos(num2)),
			(uint)((double)uint_0[1] - 400.0 * Math.Sin(num2))
		};
		uint[] uint_3 = smethod_5(uint_0, uint_2, 150);
		int num3 = new Random().Next(100, 200);
		uint_1[0] += (uint)num3;
		uint_1[1] += (uint)num3;
		uint_3 = smethod_5(uint_1, uint_3, int_1);
		uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num5 = Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num6 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num7 = num6 + num5 * Class56.memorySignatureScanConfig_15.uint_0;
		int int_2 = 0;
		int int_3 = characterAccountConfig_0.int_137;
		uint uint_4 = num7 + Class56.memorySignatureScanConfig_72.uint_0;
		byte[] byte_ = new byte[4];
		Class24.WriteProcessMemory(int_3, uint_4, byte_, 4, ref int_2);
		Class13.smethod_1(characterAccountConfig_0, uint_3);
		int num8 = 0;
		int num9 = 0;
		while (num8 < 3 && num9 < 50)
		{
			int num10 = Class89.smethod_39(characterAccountConfig_0);
			int num11 = (int)Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
			if (num11 == 1 || num10 <= 1)
			{
				num8++;
			}
			Thread.Sleep(100);
			num9++;
		}
	}

	public static void smethod_3(CharacterAccountConfig characterAccountConfig_0, ref bool bool_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		uint num2 = num + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_75.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_73.uint_0, array, 4, ref int_);
		uint num3 = BitConverter.ToUInt32(array, 0);
		if (num3 < characterAccountConfig_0.int_66)
		{
			if (!bool_0 && characterAccountConfig_0.string_15 != null && characterAccountConfig_0.string_15 != string.Empty)
			{
				uint num4 = Class11.smethod_12(characterAccountConfig_0.string_15);
				if (num4 != 0)
				{
					Class75.smethod_117(characterAccountConfig_0, num4);
					bool_0 = true;
					Thread.Sleep(300);
				}
			}
			uint num5 = (uint)characterAccountConfig_0.int_66 - num3;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_74.uint_0, array, 4, ref int_);
			uint num6 = BitConverter.ToUInt32(array, 0);
			if (num6 != 0)
			{
				if (num5 > num6)
				{
					num5 = num6;
				}
				Class75.smethod_37(characterAccountConfig_0, num5);
			}
		}
		else if (characterAccountConfig_0.int_66 < num3)
		{
			Class75.smethod_38(characterAccountConfig_0, num3 - (uint)characterAccountConfig_0.int_66);
		}
	}

	public static void smethod_4(CharacterAccountConfig characterAccountConfig_0, uint uint_0, int int_1 = 180)
	{
		int num = 0;
		int num2 = 0;
		while (num < int_1)
		{
			num++;
			Thread.Sleep(1);
			uint num3 = Class24.smethod_30(uint_0 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
			if (num3 != 3)
			{
				if (num2 > 0 || num > 50)
				{
					break;
				}
			}
			else
			{
				num2 = 1;
			}
		}
	}

	public static uint[] smethod_5(uint[] uint_0, uint[] uint_1, int int_1 = 350)
	{
		if (uint_0 != null && uint_1 != null)
		{
			long num = uint_0[0];
			long num2 = uint_0[1];
			long num3 = uint_1[0];
			long num4 = uint_1[1];
			if (num3 == num)
			{
				if (num3 == 0L)
				{
					return null;
				}
				num3++;
			}
			long num5 = num3 - num;
			long num6 = num4 - num2;
			short num7 = (short)((num3 - num) / Math.Abs(num3 - num));
			double num8 = 0.0;
			double num9 = 0.0;
			if (0 <= int_1)
			{
				num8 = (double)num7 * Math.Sqrt(int_1 * int_1 / (1L + num6 / num5 * (num6 / num5))) + (double)num3;
				num9 = (double)num4 + (double)(num6 / num5) * (num8 - (double)num3);
			}
			else
			{
				num8 = (double)num7 * Math.Sqrt(int_1 * int_1 / (1L + num6 / num5 * (num6 / num5))) + (double)num;
				num9 = (double)num2 + (double)(num6 / num5) * (num8 - (double)num);
			}
			return new uint[2]
			{
				(uint)num8,
				(uint)num9
			};
		}
		return null;
	}

	public static uint[] smethod_6(uint[] uint_0, uint[] uint_1, int int_1)
	{
		long num = Class38.smethod_0(uint_0, uint_1);
		if (int_1 > 0 && num > int_1 * int_1)
		{
			int num2 = (int)(Math.Sqrt(num) - (double)int_1);
			return smethod_5(uint_0, uint_1, -num2);
		}
		return null;
	}

	public static int smethod_7(int int_1, int int_2, ref GStruct28 gstruct28_0)
	{
		int[] int_3 = null;
		int[] int_4 = null;
		while (true)
		{
			Class11.smethod_38(ref int_4, int_2);
			for (int i = 0; i < Class45.gstruct28_0.Length; i++)
			{
				if (Class45.gstruct28_0[i].int_1 != int_2)
				{
					continue;
				}
				if (Class45.gstruct28_0[i].int_0 != int_1)
				{
					if (smethod_9(Class45.gstruct28_0[i].int_0) == null)
					{
						bool flag = false;
						if (int_4 != null)
						{
							for (int j = 0; j < int_4.Length; j++)
							{
								if (int_4[j] == Class45.gstruct28_0[i].int_0)
								{
									flag = true;
									break;
								}
							}
						}
						if (!flag)
						{
							Class11.smethod_38(ref int_3, Class45.gstruct28_0[i].int_0);
						}
						continue;
					}
					return Class45.gstruct28_0[i].int_0;
				}
				gstruct28_0 = Class45.smethod_4(int_1, int_2);
				return 0;
			}
			if (int_3 == null || int_3.Length == 0)
			{
				break;
			}
			int_2 = int_3[0];
			Class11.smethod_39(ref int_3, int_2);
		}
		return -1;
	}

	public static void smethod_8(uint[,] uint_0, int int_1, ref uint[] uint_1, ref uint[] uint_2, ref int int_2)
	{
		uint_1 = null;
		uint_2 = null;
		int_2 = -1;
		if (uint_0 != null && int_1 < uint_0.GetLength(0) && uint_0.GetLength(1) > 2)
		{
			uint_1 = new uint[2]
			{
				uint_0[int_1, 0],
				uint_0[int_1, 1]
			};
			int_2 = (int)uint_0[int_1, 2];
			if (uint_0.GetLength(1) > 4)
			{
				uint_2 = new uint[2]
				{
					uint_0[int_1, 3],
					uint_0[int_1, 4]
				};
			}
		}
	}

	public static int[] smethod_9(object object_0)
	{
		if (object_0 == null)
		{
			return null;
		}
		string text = object_0.ToString();
		if (text == string.Empty)
		{
			return null;
		}
		string[] array = typeof(string).ToString().Split('.');
		string object_1 = array[array.Length - 1].ToUpper();
		if (Class11.smethod_1(object_0.GetType().ToString().ToUpper(), object_1) < 0)
		{
			int num = Class11.smethod_11(text);
			if (num > 0)
			{
				for (int i = 0; i < int_0.GetLength(0); i++)
				{
					for (int j = 0; j < int_0.GetLength(1); j++)
					{
						if (num == int_0[i, j])
						{
							return new int[2] { i, j };
						}
					}
				}
			}
			return null;
		}
		int length = string_0.GetLength(0);
		int length2 = string_0.GetLength(1);
		for (int k = 0; k < length; k++)
		{
			for (int l = 0; l < length2; l++)
			{
				string text2 = string_0[k, l];
				if (text2 != null && !(text2 == string.Empty))
				{
					if (Class11.smethod_1(text2, text) == 0 || Class11.smethod_1(text, text2) == 0)
					{
						return new int[2] { k, l };
					}
					string text3 = Class1.smethod_1(text, 1);
					string text4 = Class1.smethod_1(text2, 1);
					if (Class11.smethod_1(text3, text4) == 0 || Class11.smethod_1(text4, text3) == 0)
					{
						return new int[2] { k, l };
					}
				}
			}
		}
		return null;
	}

	public static int smethod_10(CharacterAccountConfig characterAccountConfig_0, string string_1)
	{
		if (Class75.smethod_1(characterAccountConfig_0, Class75.uint_29) >= 15)
		{
			Class75.smethod_0(characterAccountConfig_0, Class75.uint_29);
			Class75.smethod_52(characterAccountConfig_0, string_1);
			return 1;
		}
		return 0;
	}

	public static int smethod_11(CharacterAccountConfig characterAccountConfig_0, int int_1 = 15000)
	{
		long long_ = Class11.smethod_27();
		while (!Class11.bool_0 && Class11.smethod_28(long_) < int_1)
		{
			Thread.Sleep(60 + Class95.int_0);
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
			uint num3 = num2 * Class56.memorySignatureScanConfig_15.uint_0;
			uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num5 = num4 + num3;
			uint num6 = Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
			uint num7 = Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
			uint num8 = Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
			int num9 = Class89.smethod_39(characterAccountConfig_0);
			if (num6 != 0 && num9 > 1 && num8 != 0 && num7 != 0)
			{
				return 1;
			}
		}
		return 0;
	}

	public static int smethod_12(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		if (Class75.smethod_1(characterAccountConfig_0, Class75.uint_27) >= 5 && Class75.smethod_7(characterAccountConfig_0))
		{
			Class75.smethod_0(characterAccountConfig_0, Class75.uint_27);
			if (Class47.smethod_8(characterAccountConfig_0))
			{
				Class47.smethod_11(characterAccountConfig_0);
			}
			Class95.smethod_8(characterAccountConfig_0);
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
			uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num4 = num3 + num2;
			int int_ = 0;
			byte[] array = new byte[4];
			byte[] byte_ = array;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_);
			int num5 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_44.uint_0, characterAccountConfig_0.int_137);
			if (bool_0 && num5 > 0)
			{
				Class75.smethod_57(characterAccountConfig_0, "Switch([[horse]])");
				Thread.Sleep(600);
			}
			if (num5 == 0)
			{
				Class75.smethod_57(characterAccountConfig_0, "Switch([[sit]])");
				Thread.Sleep(600);
			}
			uint[] array2 = new uint[2]
			{
				Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
				Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
			};
			if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_28, 4) > 0)
			{
				array2[0] -= 100u;
				array2[1] -= 100u;
				Class75.smethod_2(characterAccountConfig_0, Class75.uint_28, 0, 4);
			}
			else
			{
				array2[0] += 100u;
				array2[1] += 100u;
				Class75.smethod_2(characterAccountConfig_0, Class75.uint_28, 1, 4);
			}
			Class75.smethod_61(characterAccountConfig_0, array2);
			Thread.Sleep(500);
			uint[] array3 = new uint[2]
			{
				Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
				Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
			};
			long num6 = smethod_18(array2, array3);
			if ((array2[0] == array3[0] && array2[1] == array3[1]) || num6 < 11500L)
			{
				smethod_13(characterAccountConfig_0);
			}
			return (int)(1 + Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_44.uint_0, characterAccountConfig_0.int_137));
		}
		return 0;
	}

	public static void smethod_13(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = 0u;
		if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_28, 4) > 0)
		{
			num = 13107500u;
			Class75.smethod_2(characterAccountConfig_0, Class75.uint_28, 0, 4);
		}
		else
		{
			num = 24904160u;
			Class75.smethod_2(characterAccountConfig_0, Class75.uint_28, 1, 4);
		}
		Class89.smethod_15(characterAccountConfig_0.uint_4, num);
		Thread.Sleep(800);
		num = 19661200u;
		Class89.smethod_15(characterAccountConfig_0.uint_4, 19661200u);
		Thread.Sleep(300);
		Class89.smethod_14(characterAccountConfig_0);
	}

	public static bool smethod_14(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0);
		uint num3 = num2 * Class56.memorySignatureScanConfig_15.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
		uint num4 = BitConverter.ToUInt32(array, 0);
		uint num5 = num4 + num3;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_);
		if (BitConverter.ToUInt32(array, 0) != 0)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_);
			int num6 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
			int num7 = BitConverter.ToInt32(array, 0);
			uint[] array2 = Class85.smethod_42(characterAccountConfig_0);
			if (array2 != null && Class75.smethod_43(characterAccountConfig_0, array2[0], (int)array2[2], (int)array2[3]))
			{
				int num8 = 0;
				while (!bool_0 && num8 < 30)
				{
					num8++;
					Thread.Sleep(60);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
					num = BitConverter.ToUInt32(array, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
					num2 = BitConverter.ToUInt32(array, 0);
					num3 = num2 * Class56.memorySignatureScanConfig_15.uint_0;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
					num4 = BitConverter.ToUInt32(array, 0);
					num5 = num4 + num3;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
					if (BitConverter.ToUInt32(array, 0) != 0)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
						int num9 = BitConverter.ToInt32(array, 0);
						if (num9 > 0 && num9 != num7)
						{
							break;
						}
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_);
						int num10 = BitConverter.ToInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_);
						int num11 = BitConverter.ToInt32(array, 0);
						if (num10 <= 0 && num11 > 0 && num11 != num6)
						{
							break;
						}
					}
				}
				return true;
			}
			return false;
		}
		return true;
	}

	public static void smethod_15(CharacterAccountConfig characterAccountConfig_0, string[] string_1)
	{
		if (string_1 == null)
		{
			return;
		}
		string[] array = Class1.smethod_5(ref string_1, bool_0: true);
		int int_ = 80;
		int int_2 = 0;
		byte[] array2 = new byte[1];
		byte[] array3 = new byte[4];
		byte[] byte_ = new byte[80];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref int_2);
		uint num = BitConverter.ToUInt32(array3, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array3, 4, ref int_2);
		uint num2 = BitConverter.ToUInt32(array3, 0);
		int num3 = Class85.smethod_4(characterAccountConfig_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class56.int_1; num5++)
		{
			if (num3 <= num4)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + (num5 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array3, 4, ref int_2);
			uint num6 = BitConverter.ToUInt32(array3, 0);
			if (num6 == 0)
			{
				continue;
			}
			uint num7 = num2 + num6 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array3, 4, ref int_2);
			if (BitConverter.ToInt32(array3, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array2, 1, ref int_2);
			if (array2[0] == 0)
			{
				continue;
			}
			num4++;
			uint num8 = num + num5 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 1, ref int_2);
			if (array2[0] != 3)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, byte_, int_, ref int_2);
			string text = Class1.smethod_3(byte_).Trim();
			int num9 = -1;
			for (int i = 0; i < string_1.Length; i++)
			{
				if (text == string_1[i] || Class1.smethod_1(text, 1).ToUpper() == array[i])
				{
					num9 = i;
					break;
				}
			}
			if (num9 >= 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array2, 1, ref int_2);
				int num10 = array2[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0, array2, 1, ref int_2);
				int int_3 = array2[0];
				Class75.smethod_43(characterAccountConfig_0, num6, num10, int_3);
				Thread.Sleep(30);
			}
		}
	}

	public static bool smethod_16(CharacterAccountConfig characterAccountConfig_0, string[] string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			int num = 1;
			string[] array = new string[string_1.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if (string_1[i] == null)
				{
					string_1[i] = string.Empty;
				}
				if (num < string_1[i].Length)
				{
					num = string_1[i].Length;
				}
				array[i] = string_1[i].ToLower();
			}
			num += 3;
			int int_ = 0;
			int num2 = string_1.Length;
			byte[] byte_ = new byte[num];
			byte[] array2 = new byte[num2];
			byte[] array3 = new byte[1];
			byte[] array4 = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array4, 4, ref int_);
			uint num3 = BitConverter.ToUInt32(array4, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array4, 4, ref int_);
			uint num4 = BitConverter.ToUInt32(array4, 0);
			int num5 = Class85.smethod_4(characterAccountConfig_0);
			int num6 = 0;
			for (uint num7 = 1u; num7 < Class56.int_1; num7++)
			{
				if (num5 <= num6)
				{
					break;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + (num7 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array4, 4, ref int_);
				uint num8 = BitConverter.ToUInt32(array4, 0);
				if (num8 == 0)
				{
					continue;
				}
				uint num9 = num4 + num8 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array4, 4, ref int_);
				if (BitConverter.ToInt32(array4, 0) != 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_107.uint_0, array3, 1, ref int_);
				if (array3[0] == 0)
				{
					continue;
				}
				num6++;
				uint num10 = num3 + num7 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array3, 1, ref int_);
				if (array3[0] != 3)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_107.uint_0, byte_, num, ref int_);
				string text = Class1.smethod_3(byte_);
				string text2 = text.ToLower();
				int num11 = -1;
				for (int j = 0; j < string_1.Length; j++)
				{
					if (array2[j] <= 0 && (text == string_1[j] || text2 == array[j]))
					{
						num11 = j;
						break;
					}
				}
				if (num11 < 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array3, 1, ref int_);
				int num12 = array3[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0, array3, 1, ref int_);
				int int_2 = array3[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_119.uint_0, array4, 4, ref int_);
				int num13 = BitConverter.ToInt32(array4, 0);
				Class75.smethod_43(characterAccountConfig_0, num8, num12, int_2);
				Thread.Sleep(100);
				for (int k = 0; k < 30; k++)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array4, 4, ref int_);
					if (BitConverter.ToInt32(array4, 0) != 0)
					{
						break;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + (num7 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array4, 4, ref int_);
					if (BitConverter.ToUInt32(array4, 0) == 0)
					{
						break;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_119.uint_0, array4, 4, ref int_);
					int num14 = BitConverter.ToInt32(array4, 0);
					if (num13 > 0 && num14 != num13)
					{
						break;
					}
					Thread.Sleep(10);
				}
				array2[num11] = 1;
				num2--;
			}
			return num2 != string_1.Length;
		}
		return true;
	}

	public static bool smethod_17(CharacterAccountConfig characterAccountConfig_0, string string_1, bool bool_0 = true)
	{
		if (string_1 != null && !(string_1 == string.Empty))
		{
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
			uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_97.uint_0;
			int int_ = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			string[] array3 = string_1.Split('|');
			string[] array4 = new string[array3.Length];
			int num3 = 1;
			for (int i = 0; i < array3.Length; i++)
			{
				if (array3[i] == null)
				{
					array3[i] = string.Empty;
				}
				if (array3[i].Length > num3)
				{
					num3 = array3[i].Length;
				}
				array4[i] = array3[i].Trim().ToLower();
			}
			num3 += 3;
			byte[] byte_ = new byte[num3];
			int num4 = Class85.smethod_4(characterAccountConfig_0);
			int num5 = 0;
			for (uint num6 = 1u; num6 < Class56.int_1; num6++)
			{
				if (num4 <= num5)
				{
					break;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (num6 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_);
				uint num7 = BitConverter.ToUInt32(array2, 0);
				if (num7 == 0)
				{
					continue;
				}
				uint num8 = num + num7 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				num5++;
				uint num9 = num2 + num6 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
				int num10 = array[0];
				if (num10 != 3)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_111.uint_0, array, 1, ref int_);
				int num11 = array[0];
				if (num11 != 1)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_112.uint_0, array, 1, ref int_);
				int num12 = array[0];
				if (num12 != 1)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_);
				int num13 = array[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_);
				int int_2 = array[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, byte_, num3, ref int_);
				string text = Class1.smethod_3(byte_);
				string text2 = null;
				bool flag = false;
				for (int j = 0; j < array3.Length; j++)
				{
					if (!(text == array3[j]))
					{
						if (!bool_0)
						{
							if (text2 == null)
							{
								text2 = text.ToLower();
							}
							if (0 <= text2.IndexOf(array4[j]))
							{
								flag = true;
								break;
							}
						}
						continue;
					}
					flag = true;
					break;
				}
				if (!flag)
				{
					continue;
				}
				int num14 = 0;
				while (num14 < 100)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_46 - 4, array, 1, ref int_);
					if (array[0] == 0)
					{
						break;
					}
					num14++;
					Thread.Sleep(1);
				}
				return Class75.smethod_43(characterAccountConfig_0, num7, num13, int_2, num10);
			}
			return false;
		}
		return false;
	}

	public static long smethod_18(uint[] uint_0, uint[] uint_1)
	{
		if (uint_0 != null && uint_1 != null && uint_0[0] != 0 && uint_0[1] != 0 && uint_1[0] != 0 && uint_1[1] != 0)
		{
			long num = (int)(uint_0[0] - uint_1[0]);
			long num2 = (int)(uint_0[1] - uint_1[1]);
			long num3 = num * num + num2 * num2;
			if (num3 == 0L)
			{
				num3 = 1L;
			}
			return (uint)num3;
		}
		return 2147483647L;
	}

	public static long smethod_19(uint[] uint_0, uint uint_1, uint uint_2)
	{
		if (uint_0 != null && uint_0[0] != 0 && uint_0[1] != 0 && uint_1 != 0 && uint_2 != 0)
		{
			long num = (int)(uint_0[0] - uint_1);
			long num2 = (int)(uint_0[1] - uint_2);
			long num3 = num * num + num2 * num2;
			if (num3 == 0L)
			{
				num3 = 1L;
			}
			return (uint)num3;
		}
		return 2147483647L;
	}

	public static int smethod_20(uint[,] uint_0, uint[] uint_1)
	{
		if (uint_0 != null && uint_1 != null && uint_0.GetLength(1) >= 2 && uint_1.GetLength(0) >= 2)
		{
			int num = -1;
			long num2 = -1L;
			for (int i = 0; i < uint_0.GetLength(0); i++)
			{
				uint[] uint_2 = new uint[2]
				{
					uint_0[i, 0],
					uint_0[i, 1]
				};
				long num3 = smethod_18(uint_1, uint_2);
				if (num < 0 || num3 < num2)
				{
					num = i;
					num2 = num3;
				}
			}
			return num;
		}
		return -1;
	}

	public static long smethod_21(uint[,] uint_0, uint[] uint_1)
	{
		if (uint_0 != null && uint_1 != null)
		{
			long num = -1L;
			long num2 = -1L;
			for (int i = 0; i < uint_0.GetLength(0); i++)
			{
				uint[] uint_2 = new uint[2]
				{
					uint_0[i, 0],
					uint_0[i, 1]
				};
				long num3 = smethod_18(uint_1, uint_2);
				if (num < 0L || num3 < num2)
				{
					num = i;
					num2 = num3;
				}
			}
			return num2;
		}
		return -1L;
	}

	public static int smethod_22(CharacterAccountConfig characterAccountConfig_0, uint[,] uint_0, uint[] uint_1 = null, uint[] uint_2 = null, int int_1 = -1, bool bool_0 = false, int int_2 = 0, bool bool_1 = false)
	{
		int int_3 = characterAccountConfig_0.int_136;
		int result = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		bool flag = false;
		bool flag2 = false;
		long num4 = 0L;
		long long_ = 0L;
		long long_2 = 0L;
		long num5 = Class11.smethod_27();
		long long_3 = num5;
		uint num6 = 0u;
		uint[] array = null;
		bool flag3 = false;
		int num7 = -1;
		int num8 = 0;
		int num9 = 0;
		int num10 = -1;
		int num11 = 0;
		int num12 = 0;
		int num13 = -1;
		int int_4 = 0;
		byte[] array2 = new byte[4];
		byte[] byte_ = array2;
		bool flag4 = false;
		int num14 = 0;
		int[] array3 = new int[10];
		for (int i = 0; i < array3.Length; i++)
		{
			array3[i] = 4;
		}
		byte[] array4 = new byte[4];
		while (true)
		{
			IL_0945:
			Thread.Sleep(100);
			int num15 = Class87.smethod_3(Form1.characterAccountConfig_1, int_3);
			if (Class11.bool_0 || num15 < 0 || Class24.smethod_52(Form1.characterAccountConfig_1[num15].process_0) || !Form1.characterAccountConfig_1[num15].bool_25 || Class46.bool_0)
			{
				break;
			}
			characterAccountConfig_0 = Form1.characterAccountConfig_1[num15];
			int num16 = Class89.smethod_12(characterAccountConfig_0);
			if (num16 != 1)
			{
				num12 = 0;
				int num17 = Class89.smethod_39(characterAccountConfig_0);
				if (num17 > 1)
				{
					num11 = 0;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array4, 4, ref array3[0]);
					uint num18 = BitConverter.ToUInt32(array4, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num18 + Class56.memorySignatureScanConfig_13.uint_0, array4, 4, ref array3[1]);
					uint num19 = BitConverter.ToUInt32(array4, 0);
					uint num20 = num19 * Class56.memorySignatureScanConfig_15.uint_0;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array4, 4, ref array3[2]);
					uint num21 = BitConverter.ToUInt32(array4, 0);
					num6 = num21 + num20;
					if (!flag4)
					{
						Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_4);
						flag4 = true;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_55.uint_0, array4, 4, ref array3[3]);
					int num22 = BitConverter.ToInt32(array4, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_50.uint_0, array4, 4, ref array3[4]);
					int num23 = BitConverter.ToInt32(array4, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array4, 4, ref array3[5]);
					int num24 = BitConverter.ToInt32(array4, 0);
					if (int_1 > 0 && num24 != int_1)
					{
						result = -1;
						break;
					}
					if (num23 == 0 || num22 == 0 || num22 == 10 || num22 == 21 || num24 == 0 || characterAccountConfig_0.long_10 > num5)
					{
						result = -1;
						break;
					}
					int num25 = (int)Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
					if (bool_0 && num25 > 0)
					{
						result = 1;
						break;
					}
					if (num13 != num25)
					{
						if (0 <= num13)
						{
							flag = false;
							uint_1 = null;
						}
						num13 = num25;
					}
					if (int_2 > 0 && Class11.smethod_28(long_3) > int_2)
					{
						result = 101;
						break;
					}
					num14 = 5;
					int num26 = 0;
					while (num26 <= num14)
					{
						if (array3[num26] != 0)
						{
							num26++;
							continue;
						}
						goto IL_0945;
					}
					uint[] array5 = new uint[2]
					{
						Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					if (num10 >= 0)
					{
						if (num10 != num24)
						{
							result = 1;
							break;
						}
					}
					else
					{
						num10 = num24;
					}
					if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_17, 4) > 0)
					{
						Class75.smethod_2(characterAccountConfig_0, Class75.uint_17, 0, 4);
						result = 0;
						break;
					}
					if (uint_0.GetLength(0) != 1)
					{
						if (!flag)
						{
							flag = true;
							if (uint_1 == null)
							{
								num = smethod_20(uint_0, array5);
								num7 = num;
								uint_1 = new uint[2]
								{
									uint_0[num, 0],
									uint_0[num, 1]
								};
							}
							else
							{
								num = smethod_20(uint_0, uint_1);
								num7 = num;
								flag3 = true;
							}
							if (uint_2 == null)
							{
								num2 = uint_0.GetLength(0) - 1;
								uint_2 = new uint[2]
								{
									uint_0[num2, 0],
									uint_0[num2, 1]
								};
							}
							else
							{
								num2 = smethod_20(uint_0, uint_2);
							}
							num3 = ((num <= num2) ? 1 : (-1));
						}
						if (flag2)
						{
							uint_1 = new uint[2]
							{
								uint_0[num, 0],
								uint_0[num, 1]
							};
							num4 = smethod_18(array5, uint_1);
							if (!flag3)
							{
								if (num4 <= 22500L)
								{
									smethod_29(characterAccountConfig_0, bool_0: false);
									num = smethod_20(uint_0, uint_1);
									if ((num < num7 && num3 > 0) || (num > num7 && num3 < 0))
									{
										num8++;
										if (num8 % 6 == 0)
										{
											smethod_12(characterAccountConfig_0);
											num9++;
											if (num9 > 3)
											{
												result = -1;
												break;
											}
										}
										if (num3 > 0)
										{
											num--;
											if (num < 0)
											{
												num = 0;
											}
										}
										else
										{
											num++;
											if (num2 < num)
											{
												num = num2;
											}
										}
										num7 = num;
									}
									else
									{
										num += num3;
										num7 = num;
										num8 = 0;
										num9 = 0;
										if ((num3 > 0 && num2 < num) || (num3 < 0 && num < num2))
										{
											result = 1;
											break;
										}
									}
									continue;
								}
								if (Class13.smethod_3(characterAccountConfig_0))
								{
									Class13.smethod_2(characterAccountConfig_0, bool_0: false);
								}
								if (array == null)
								{
									array = new uint[2]
									{
										Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
										Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
									};
									long_ = Class11.smethod_27();
								}
								Class75.smethod_61(characterAccountConfig_0, uint_1);
								Thread.Sleep(200);
								if (Class11.smethod_28(long_) < 6000L)
								{
									continue;
								}
								array5 = new uint[2]
								{
									Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
									Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
								};
								num4 = smethod_18(array, array5);
								if (num4 < 90000L)
								{
									num8++;
									if (num8 % 6 == 0)
									{
										smethod_12(characterAccountConfig_0);
										num9++;
										if (num9 > 3)
										{
											result = -1;
											break;
										}
									}
									Thread.Sleep(300);
									array5 = new uint[2]
									{
										Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
										Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
									};
									num = smethod_20(uint_0, array5);
									if (num3 > 0)
									{
										num--;
										if (num < 0)
										{
											num = 0;
										}
									}
									else
									{
										num++;
										if (num2 < num)
										{
											num = num2;
										}
									}
									num7 = num;
								}
								else
								{
									array = new uint[2]
									{
										array5[0],
										array5[1]
									};
								}
								long_ = Class11.smethod_27();
							}
							else
							{
								flag3 = false;
								flag2 = false;
							}
							continue;
						}
						int j = 0;
						num4 = smethod_18(array5, uint_1);
						if (!bool_1 && num4 > 1000000L)
						{
							if (Class11.smethod_28(long_2) > 3000L)
							{
								Class13.smethod_1(characterAccountConfig_0, uint_1);
								long_2 = Class11.smethod_27();
							}
							continue;
						}
						if (Class13.smethod_3(characterAccountConfig_0))
						{
							Class13.smethod_2(characterAccountConfig_0, bool_0: false);
						}
						for (; j < 5; j++)
						{
							array5 = new uint[2]
							{
								Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
								Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
							};
							num4 = smethod_18(array5, uint_1);
							if (num4 <= 22500L)
							{
								break;
							}
							Class75.smethod_61(characterAccountConfig_0, uint_1);
							Thread.Sleep(300);
						}
						num24 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
						if (int_1 <= 0 || num24 == int_1)
						{
							if (!bool_1 && j > 4 && num4 > 22500L)
							{
								Class13.smethod_1(characterAccountConfig_0, uint_1);
								Thread.Sleep(300);
							}
							flag2 = true;
							continue;
						}
						result = 1;
						break;
					}
					uint[] array6 = new uint[2]
					{
						uint_0[0, 0],
						uint_0[0, 1]
					};
					long num27 = smethod_18(array5, array6);
					if (num27 < 22500L)
					{
						result = 1;
						break;
					}
					if (!bool_1 && num27 > 1000000L)
					{
						if (Class11.smethod_28(long_2) > 3000L)
						{
							Class13.smethod_1(characterAccountConfig_0, array6);
							long_2 = Class11.smethod_27();
						}
					}
					else
					{
						Class75.smethod_61(characterAccountConfig_0, array6);
						Thread.Sleep(200);
					}
				}
				else
				{
					num11++;
					if (num11 > 10)
					{
						result = -1;
						break;
					}
				}
			}
			else
			{
				Thread.Sleep(200);
				num12++;
				if (num12 > 1)
				{
					flag = false;
					flag2 = false;
					uint_1 = null;
				}
			}
		}
		Class13.smethod_2(characterAccountConfig_0, bool_0: false);
		return result;
	}

	public static int smethod_23(CharacterAccountConfig characterAccountConfig_0, uint[] uint_0, int int_1, uint[] uint_1 = null, int int_2 = -1)
	{
		int int_3 = characterAccountConfig_0.int_136;
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_3);
		if (!Class11.bool_0 && num >= 0 && !Class24.smethod_52(Form1.characterAccountConfig_1[num].process_0) && Form1.characterAccountConfig_1[num].bool_25)
		{
			uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
			uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num5 = num4 + num3;
			int num6 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
			if (num6 == int_2)
			{
				return 1;
			}
			uint[] array = new uint[2]
			{
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
			};
			int num7 = 0;
			if (uint_1 != null)
			{
				for (num7 = 0; num7 < 10; num7++)
				{
					uint num8 = Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
					if (num8 == num6 && num8 != int_2)
					{
						array = new uint[2]
						{
							Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
							Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
						};
						if (smethod_18(array, uint_1) < 11500L)
						{
							break;
						}
						Class75.smethod_61(characterAccountConfig_0, uint_1);
						Thread.Sleep(300);
						continue;
					}
					return 1;
				}
				for (num7 = 0; num7 < 10; num7++)
				{
					if (Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137) != 3)
					{
						break;
					}
					Thread.Sleep(100);
				}
			}
			num7 = 0;
			while (!Class11.bool_0 && num7 < 15)
			{
				uint num9 = Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
				if ((num9 == 0 || num9 == num6) && num9 != int_2)
				{
					array = new uint[2]
					{
						Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					if (smethod_18(array, uint_0) < 11500L)
					{
						break;
					}
					Class75.smethod_61(characterAccountConfig_0, uint_0);
					Thread.Sleep(300);
					num7++;
					continue;
				}
				return 1;
			}
			for (num7 = 0; num7 < 10; num7++)
			{
				if (Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137) != 3)
				{
					break;
				}
				Thread.Sleep(100);
			}
			for (int i = 0; i < 5; i++)
			{
				uint num10 = Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
				if ((num10 == 0 || num10 == num6) && num10 != int_2)
				{
					if (Class75.smethod_7(characterAccountConfig_0))
					{
						smethod_25(characterAccountConfig_0, int_1);
					}
					Thread.Sleep(300);
					continue;
				}
				return 1;
			}
			return 0;
		}
		return 0;
	}

	public static int smethod_24(CharacterAccountConfig characterAccountConfig_0, uint[] uint_0, int int_1, uint[] uint_1 = null, uint[,] uint_2 = null, int int_2 = -10)
	{
		int int_3 = characterAccountConfig_0.int_136;
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_3);
		if (!Class11.bool_0 && num >= 0 && !Class24.smethod_52(Form1.characterAccountConfig_1[num].process_0) && Form1.characterAccountConfig_1[num].bool_25)
		{
			uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
			uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num5 = num4 + num3;
			int num6 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
			if (num6 == int_2)
			{
				return 1;
			}
			uint[] array = new uint[2]
			{
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
			};
			if (uint_2 != null)
			{
				int num7 = smethod_20(uint_2, array);
				if (0 < num7)
				{
					uint_0 = new uint[2]
					{
						uint_2[num7, 0],
						uint_2[num7, 1]
					};
					if (uint_2.GetLength(1) > 2)
					{
						int_1 = (int)uint_2[num7, 2];
					}
					uint_1 = null;
				}
			}
			long num8 = smethod_18(array, uint_0);
			if (num8 > 90000L)
			{
				smethod_29(characterAccountConfig_0, bool_0: false);
				Thread.Sleep(100);
				Class13.smethod_1(characterAccountConfig_0, uint_0);
				return -1;
			}
			long long_ = Class11.smethod_27();
			while (!Class11.bool_0)
			{
				array = new uint[2]
				{
					Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
				num8 = smethod_18(array, uint_0);
				if (num8 < 11500L || Class11.smethod_28(long_) > 6000L)
				{
					break;
				}
				uint num9 = Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
				if ((num9 == 0 || num9 == num6) && num9 != int_2)
				{
					Class75.smethod_61(characterAccountConfig_0, uint_0);
					Thread.Sleep(300);
					continue;
				}
				return 1;
			}
			long_ = Class11.smethod_27();
			while (!Class11.bool_0 && uint_1 != null)
			{
				array = new uint[2]
				{
					Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
				num8 = smethod_18(array, uint_1);
				if (num8 < 11500L || Class11.smethod_28(long_) > 6000L)
				{
					break;
				}
				uint num10 = Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
				if ((num10 == 0 || num10 == num6) && num10 != int_2)
				{
					Class75.smethod_61(characterAccountConfig_0, uint_1);
					Thread.Sleep(300);
					continue;
				}
				return 1;
			}
			long_ = Class11.smethod_27();
			while (Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137) > 1 && Class11.smethod_28(long_) < 1800L)
			{
				Thread.Sleep(300);
			}
			int num11 = 0;
			while (true)
			{
				if (num11 < 5)
				{
					if (Class75.smethod_7(characterAccountConfig_0))
					{
						smethod_25(characterAccountConfig_0, int_1);
					}
					Thread.Sleep(350);
					uint num12 = Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
					if ((num12 != 0 && num12 != num6) || num12 == int_2)
					{
						break;
					}
					num11++;
					continue;
				}
				return 0;
			}
			return 1;
		}
		return 0;
	}

	public static void smethod_25(CharacterAccountConfig characterAccountConfig_0, int int_1)
	{
		uint[] array = Class38.smethod_30(characterAccountConfig_0);
		if (array != null)
		{
			double num = (double)Math.Abs(int_1) * 3.14 / 180.0;
			uint[] uint_ = new uint[2]
			{
				(uint)((double)array[0] + 200.0 * Math.Cos(num)),
				(uint)((double)array[1] - 200.0 * Math.Sin(num))
			};
			Class75.smethod_61(characterAccountConfig_0, uint_);
			Thread.Sleep(150);
		}
	}

	public static uint[] smethod_26(CharacterAccountConfig characterAccountConfig_0, ref int int_1)
	{
		if (!AuxiliaryMachineManager.bool_3 && characterAccountConfig_0.int_68 != null && characterAccountConfig_0.int_68[0] > 0 && characterAccountConfig_0.string_9 != null && !(characterAccountConfig_0.string_9 == string.Empty) && !(characterAccountConfig_0.string_9 == characterAccountConfig_0.string_22))
		{
			bool flag = false;
			int int_2 = 0;
			byte[] array = new byte[characterAccountConfig_0.string_9.Length + 1];
			string text = null;
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
			uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num4 = 0u;
			uint num5 = 0u;
			while (true)
			{
				if (int_1 > 0)
				{
					num4 = num3 + (uint)(int_1 * (int)Class56.memorySignatureScanConfig_15.uint_0);
					num5 = num4 + Class56.memorySignatureScanConfig_16.uint_0;
					if (Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5, array, 1, ref int_2) && array[0] != 0 && Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137) == 1)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5, array, array.Length, ref int_2);
						text = Class1.smethod_3(array);
						if (!(text == string.Empty) && Class11.smethod_2(text, characterAccountConfig_0.string_9, bool_1: true) && (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137) > 0)
						{
							return new uint[2]
							{
								Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
								Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
							};
						}
					}
				}
				if (flag)
				{
					break;
				}
				int int_3 = 0;
				byte[] array2 = new byte[4];
				uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array2, 4, ref int_3);
				int num6 = BitConverter.ToInt32(array2, 0);
				if (num6 > 1)
				{
					int num7 = 0;
					uint num8 = 1u;
					while (true)
					{
						if (num8 < 256 && num6 > num7)
						{
							if (num8 == num2)
							{
								num7++;
							}
							else
							{
								num4 = num3 + num8 * Class56.memorySignatureScanConfig_15.uint_0;
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_50.uint_0, array2, 4, ref int_3);
								if (BitConverter.ToInt32(array2, 0) > 0)
								{
									num7++;
									if (Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137) == 1)
									{
										num5 = num4 + Class56.memorySignatureScanConfig_16.uint_0;
										if (Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5, array, 1, ref int_2) && array[0] != 0)
										{
											Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5, array, array.Length, ref int_2);
											text = Class1.smethod_3(array);
											if (text != string.Empty && Class11.smethod_2(text, characterAccountConfig_0.string_9, bool_1: true))
											{
												break;
											}
										}
									}
								}
							}
							num8++;
							continue;
						}
						return null;
					}
					int_1 = (int)num8;
					flag = true;
					continue;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public static int smethod_27(CharacterAccountConfig characterAccountConfig_0, string string_1, int int_1 = -1, bool bool_0 = false)
	{
		int int_2 = 0;
		byte[] array = new byte[4];
		int num = 0;
		while (true)
		{
			if (!bool_0 && characterAccountConfig_0.uint_19 != 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_19, array, 4, ref int_2);
				if (BitConverter.ToInt32(array, 0) > 0)
				{
					return 0;
				}
				array[0] = 1;
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_19, array, 1, ref int_2);
				if (!smethod_17(characterAccountConfig_0, string_1))
				{
					num = -1;
					break;
				}
			}
			int i = 0;
			uint num2;
			for (num2 = 0u; num2 == 0; i++, Thread.Sleep(1))
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_151.uint_0, array, 4, ref int_2);
				num2 = BitConverter.ToUInt32(array, 0);
				if (num2 != 0)
				{
					continue;
				}
				if (bool_0)
				{
					goto IL_006e;
				}
				if (i <= 300)
				{
					continue;
				}
				goto IL_020c;
			}
			string text = "STRINGINPUT";
			uint uint_ = num2 + Class56.memorySignatureScanConfig_242.uint_0;
			array = new byte[text.Length + 1];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, array.Length, ref int_2);
			string text2 = Class1.smethod_3(array).Trim().ToUpper();
			if (!(text2 != text))
			{
				int num3 = Form1.int_16;
				if (int_1 >= 0 && num3 <= int_1)
				{
					num3 = int_1 + 1;
				}
				if (characterAccountConfig_0.int_25 > 0 && characterAccountConfig_0.int_60 != null && characterAccountConfig_0.int_60[0] > 0)
				{
					int[] array2 = new int[5] { 1, 2, 3, 4, 6 };
					int num4 = array2[characterAccountConfig_0.int_60[1]];
					int num5 = Class85.smethod_25(characterAccountConfig_0);
					int num6 = num5 - num4;
					if (num6 < 0)
					{
						num6 = 0;
					}
					if (num3 > num6)
					{
						num3 = num6;
					}
				}
				char[] array3 = num3.ToString().ToCharArray();
				for (int j = 0; j < array3.Length; j++)
				{
					Class24.smethod_4(characterAccountConfig_0.uint_4, array3[j]);
					Thread.Sleep(10);
				}
				Class24.smethod_4(characterAccountConfig_0.uint_4, 13u);
				num = 2;
			}
			else
			{
				num = 1;
			}
			break;
			IL_020c:
			num = 1;
			break;
			IL_006e:
			bool_0 = false;
		}
		if (characterAccountConfig_0.uint_19 != 0)
		{
			byte[] array4 = new byte[4];
			array = array4;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_19, array, 4, ref int_2);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_19 + 4, array, 4, ref int_2);
		}
		return num;
	}

	public static void smethod_28(CharacterAccountConfig characterAccountConfig_0)
	{
		if (Class38.smethod_27(characterAccountConfig_0) > 0 && smethod_14(characterAccountConfig_0))
		{
			Thread.Sleep(1 + FormLuomrac.int_5);
			Class24.smethod_53(characterAccountConfig_0.process_0);
		}
	}

	public static bool smethod_29(CharacterAccountConfig characterAccountConfig_0, bool bool_0)
	{
		int int_ = 0;
		byte[] array = new byte[8];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_47 * 4, array, 8, ref int_);
		long long_ = BitConverter.ToInt64(array, 0);
		if (Class11.smethod_28(long_) >= 999L)
		{
			bool result = false;
			byte[] array2 = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_);
			uint num = BitConverter.ToUInt32(array2, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_13.uint_0, array2, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array2, 0);
			uint num3 = num2 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array2, 4, ref int_);
			uint num4 = BitConverter.ToUInt32(array2, 0);
			uint num5 = num4 + num3;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_44.uint_0, array2, 4, ref int_);
			int num6 = BitConverter.ToInt32(array2, 0);
			if ((bool_0 && num6 > 0) || (!bool_0 && num6 == 0 && Class75.smethod_3(characterAccountConfig_0, Class75.uint_20, 4) > 0))
			{
				Class75.smethod_57(characterAccountConfig_0, "Switch([[horse]])");
				result = true;
			}
			array = BitConverter.GetBytes(DateTime.Now.Ticks);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_47 * 4, array, 8, ref int_);
			return result;
		}
		return false;
	}

	public static bool smethod_30(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.int_93 <= 2)
		{
			int int_ = 0;
			byte[] array = new byte[8];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_47 * 4, array, 8, ref int_);
			long long_ = BitConverter.ToInt64(array, 0);
			if (Class11.smethod_28(long_) >= 999L)
			{
				byte[] array2 = new byte[4];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_);
				uint num = BitConverter.ToUInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_13.uint_0, array2, 4, ref int_);
				uint num2 = BitConverter.ToUInt32(array2, 0);
				uint num3 = num2 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array2, 4, ref int_);
				uint num4 = BitConverter.ToUInt32(array2, 0);
				uint num5 = num4 + num3;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_44.uint_0, array2, 4, ref int_);
				int num6 = BitConverter.ToInt32(array2, 0);
				bool flag = false;
				if (num6 <= 0)
				{
					if (characterAccountConfig_0.int_93 <= 0)
					{
						flag = true;
					}
					else if (characterAccountConfig_0.int_93 == 2)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_46 * 4, array2, 4, ref int_);
						if (BitConverter.ToInt32(array2, 0) == 0)
						{
							flag = true;
						}
					}
				}
				else if (characterAccountConfig_0.int_93 == 1)
				{
					flag = true;
				}
				else if (characterAccountConfig_0.int_93 == 2)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_46 * 4, array2, 4, ref int_);
					int num7 = BitConverter.ToInt32(array2, 0);
					if (num7 > 0)
					{
						flag = true;
					}
				}
				if (flag)
				{
					Class75.smethod_57(characterAccountConfig_0, "Switch([[horse]])");
				}
				array = BitConverter.GetBytes(DateTime.Now.Ticks);
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_47 * 4, array, 8, ref int_);
				return flag;
			}
			return false;
		}
		return false;
	}
}
