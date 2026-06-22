using System;
using System.Threading;
using ns1;
using ns11;
using ns23;
using ns53;
using ns61;

namespace ns3;

internal class Class3
{
	public static uint smethod_0(uint[] uint_0, uint[] uint_1)
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
		return 2147483647u;
	}

	public static int smethod_1(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_9.uint_0 != 0 && Class56.memorySignatureScanConfig_10.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 4, ref int_);
			return BitConverter.ToInt32(array, 0);
		}
		return -1;
	}

	public static int smethod_2(CharacterAccountConfig characterAccountConfig_0, uint uint_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		uint num2 = num + uint_0 * Class56.memorySignatureScanConfig_15.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_85.uint_0, array, 4, ref int_);
		return BitConverter.ToInt32(array, 0);
	}

	private static uint smethod_3(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137) + (uint)(int)(int_0 * Class56.memorySignatureScanConfig_15.uint_0);
		return Class24.smethod_30(num + uint_0, characterAccountConfig_0.int_137);
	}

	private static void smethod_4(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0, int int_1)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137) + (uint)(int)(int_0 * Class56.memorySignatureScanConfig_15.uint_0);
		Class24.smethod_31(num + uint_0, characterAccountConfig_0.int_137, (uint)int_1);
	}

	private static string smethod_5(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137) + (uint)(int)(int_0 * Class56.memorySignatureScanConfig_15.uint_0);
		return Class24.smethod_28(num + uint_0, characterAccountConfig_0.int_137, 255);
	}

	public static int smethod_6(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		return (int)smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_26.uint_0 + 8);
	}

	public static int smethod_7(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		return (int)smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_26.uint_0 + 12) / 4;
	}

	public static int smethod_8(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		return (int)smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_43.uint_0);
	}

	public static int smethod_9(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		return (int)smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_52.uint_0);
	}

	public static int smethod_10(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		return (int)smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_17.uint_0);
	}

	public static int smethod_11(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		return (int)smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_50.uint_0);
	}

	public static int smethod_12(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		return (int)smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_55.uint_0);
	}

	public static int smethod_13(CharacterAccountConfig characterAccountConfig_0, string string_0, int int_0 = -1, bool bool_0 = false, int int_1 = -1, int int_2 = 80)
	{
		if (string_0 != null && !(string_0 == ""))
		{
			string[] array = string_0.Split('|');
			string[] array2 = new string[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = array[i].Trim().ToLower();
			}
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
			uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num4 = num3 + num2;
			int num5 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137);
			int num6 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137);
			int int_3 = 0;
			byte[] array3 = new byte[int_2];
			byte[] array4 = new byte[4];
			uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array4, 4, ref int_3);
			int num7 = BitConverter.ToInt32(array4, 0);
			if (num7 <= 0)
			{
				return -1;
			}
			int num8 = (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
			int num9 = 0;
			for (uint num10 = 1u; num10 < 256 && num7 > num9; num10++)
			{
				if (num10 == num8)
				{
					num9++;
					continue;
				}
				uint num11 = num3 + num10 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_16.uint_0, array4, 4, ref int_3);
				if (array4[0] == 0)
				{
					continue;
				}
				num9++;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_50.uint_0, array4, 4, ref int_3);
				if (BitConverter.ToInt32(array4, 0) <= 0)
				{
					continue;
				}
				if (0 <= int_0)
				{
					int num12 = (int)Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137);
					if (num12 != int_0)
					{
						continue;
					}
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_16.uint_0, array3, array3.Length, ref int_3);
				string text = Class1.smethod_3(array3);
				if (text == string.Empty)
				{
					continue;
				}
				string string_1 = text.Trim().ToLower();
				bool flag = false;
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j] == text || (!bool_0 && 0 <= Class11.smethod_1(string_1, array2[j])))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
				if (int_1 > 0 && num5 > 0 && num6 > 0)
				{
					int num13 = (int)Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137);
					int num14 = (int)Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137);
					if (num13 > 0 && num14 > 0)
					{
						long num15 = num5 - num13;
						long num16 = num6 - num14;
						if (num15 * num15 + num16 * num16 <= int_1)
						{
							return (int)num10;
						}
					}
					continue;
				}
				return (int)num10;
			}
			return -1;
		}
		return -1;
	}

	public static int smethod_14(CharacterAccountConfig characterAccountConfig_0, string string_0, ref uint[] uint_0, int int_0 = 1)
	{
		uint_0 = null;
		if (string_0 != null && !(string_0 == string.Empty))
		{
			int int_1 = 0;
			byte[] array = new byte[80];
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			byte[] array2 = new byte[4];
			uint uint_1 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_1, array2, 4, ref int_1);
			int num2 = BitConverter.ToInt32(array2, 0);
			if (num2 > 0)
			{
				int num3 = 0;
				for (uint num4 = 1u; num4 < 256; num4++)
				{
					if (num2 <= num3)
					{
						break;
					}
					uint num5 = num + num4 * Class56.memorySignatureScanConfig_15.uint_0;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_16.uint_0, array2, 4, ref int_1);
					if (array2[0] == 0)
					{
						continue;
					}
					num3++;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_50.uint_0, array2, 4, ref int_1);
					if (BitConverter.ToInt32(array2, 0) > 0 && Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137) == int_0)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_16.uint_0, array, array.Length, ref int_1);
						if (!(Class1.smethod_3(array) != string_0))
						{
							uint_0 = new uint[2]
							{
								Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
								Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
							};
							return (int)num4;
						}
					}
				}
				return -1;
			}
			return -1;
		}
		return -1;
	}

	public static int smethod_15(CharacterAccountConfig characterAccountConfig_0, string string_0, ref uint[] uint_0, int int_0 = 3, bool bool_0 = true, int int_1 = -1, int[] int_2 = null)
	{
		uint_0 = null;
		if (string_0 != null && !(string_0 == string.Empty))
		{
			string[] array = string_0.Split('|');
			string[] array2 = new string[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = array[i].Trim();
				array2[i] = array[i].ToUpper();
			}
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
			uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num4 = num3 + num2;
			uint[] uint_1 = new uint[2]
			{
				Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
				Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
			};
			int int_3 = 0;
			byte[] array3 = new byte[80];
			byte[] array4 = new byte[4];
			uint uint_2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_2, array4, 4, ref int_3);
			int num5 = BitConverter.ToInt32(array4, 0);
			if (num5 <= 0)
			{
				return 0;
			}
			long num6 = 0L;
			long num7 = 0L;
			uint num8 = 0u;
			int num9 = 0;
			for (uint num10 = 1u; num10 < 256; num10++)
			{
				if (num10 % 50 == 0)
				{
					Thread.Sleep(30);
				}
				if (num5 <= num9)
				{
					break;
				}
				uint num11 = num3 + num10 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_16.uint_0, array4, 4, ref int_3);
				if (array4[0] == 0)
				{
					continue;
				}
				num9++;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_50.uint_0, array4, 4, ref int_3);
				if (BitConverter.ToInt32(array4, 0) <= 0 || Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137) != int_0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_16.uint_0, array3, array3.Length, ref int_3);
				string text = Class1.smethod_3(array3).Trim();
				string string_1 = text.ToUpper();
				bool flag = false;
				for (int j = 0; j < array.Length; j++)
				{
					if (text == array[j] || (!bool_0 && 0 <= Class11.smethod_1(string_1, array2[j])))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
				if (int_2 != null)
				{
					for (int k = 0; k < int_2.Length; k++)
					{
						if (int_2[k] == num10)
						{
							flag = false;
							break;
						}
					}
				}
				if (flag)
				{
					uint[] array5 = new uint[2]
					{
						Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					num7 = Class64.smethod_18(uint_1, array5);
					if ((int_1 <= 0 || num7 <= int_1 * int_1) && (num8 == 0 || num7 < num6))
					{
						num8 = num10;
						uint_0 = new uint[2]
						{
							array5[0],
							array5[1]
						};
						num6 = num7;
					}
				}
			}
			return (int)num8;
		}
		return -1;
	}

	public static string smethod_16(CharacterAccountConfig characterAccountConfig_0, int int_0, ref uint[] uint_0, int int_1 = 60)
	{
		uint_0 = null;
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num3 = num2 + (uint)(int_0 * (int)Class56.memorySignatureScanConfig_15.uint_0);
		if ((int)Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137) <= 0)
		{
			return string.Empty;
		}
		int int_2 = 0;
		byte[] array = new byte[1];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + Class56.memorySignatureScanConfig_16.uint_0, array, 1, ref int_2);
		if (array[0] == 0)
		{
			return string.Empty;
		}
		array = new byte[int_1];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + Class56.memorySignatureScanConfig_16.uint_0, array, int_1, ref int_2);
		uint_0 = new uint[2]
		{
			Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
			Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
		};
		return Class1.smethod_3(array);
	}

	public static bool smethod_17(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num3 = num2 + (uint)(int_0 * (int)Class56.memorySignatureScanConfig_15.uint_0);
		int int_1 = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_1);
		return BitConverter.ToInt32(array, 0) > 0;
	}

	public static int smethod_18(CharacterAccountConfig characterAccountConfig_0, string string_0, ref uint[] uint_0, int int_0 = 60000, uint[] uint_1 = null)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num3 = num2 * Class56.memorySignatureScanConfig_15.uint_0;
		uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num5 = num4 + num3;
		if (uint_1 == null)
		{
			uint_1 = new uint[2]
			{
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
			};
		}
		char[] array = string_0.ToCharArray();
		int int_1 = 0;
		byte[] array2 = new byte[80];
		byte[] array3 = new byte[4];
		uint uint_2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_2, array3, 4, ref int_1);
		int num6 = BitConverter.ToInt32(array3, 0);
		if (num6 <= 1)
		{
			return 0;
		}
		uint num7 = 0u;
		long num8 = 0L;
		long num9 = 0L;
		int num10 = 0;
		for (uint num11 = 1u; num11 < 256; num11++)
		{
			if (num6 <= num10)
			{
				break;
			}
			if (num11 == num2)
			{
				num10++;
				continue;
			}
			uint num12 = num4 + num11 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_16.uint_0, array3, 4, ref int_1);
			if (array3[0] == 0)
			{
				continue;
			}
			num10++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_1);
			if (BitConverter.ToInt32(array3, 0) <= 0 || Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137) != 3)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_16.uint_0, array2, 1, ref int_1);
			if (array2[0] != array[0])
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_16.uint_0, array2, array2.Length, ref int_1);
			if (Class1.smethod_3(array2).IndexOf(string_0) == 0)
			{
				uint[] array4 = new uint[2]
				{
					Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
				num9 = smethod_0(uint_1, array4);
				if (num9 > 0L && num9 < int_0 && (num7 == 0 || num9 < num8))
				{
					num7 = num11;
					num8 = num9;
					uint_0 = array4;
				}
			}
		}
		return (int)num7;
	}

	public static uint[] smethod_19(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		uint num = smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0);
		uint num2 = smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0);
		if (num != 0 && num2 != 0)
		{
			return new uint[2] { num, num2 };
		}
		return null;
	}

	public static long[] smethod_20(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		return new long[2]
		{
			smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_45.uint_0),
			smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_47.uint_0)
		};
	}

	public static long[] smethod_21(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		return new long[2]
		{
			smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_46.uint_0),
			smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_48.uint_0)
		};
	}

	public static string smethod_22(CharacterAccountConfig characterAccountConfig_0, int int_0, int int_1 = 0)
	{
		string result = "";
		int num = smethod_11(characterAccountConfig_0, int_0);
		int num2 = smethod_9(characterAccountConfig_0, int_0);
		if (num > 0 && (int_1 < 0 || num2 == int_1))
		{
			result = smethod_5(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_16.uint_0);
		}
		return result;
	}

	public static string smethod_23(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + (uint)(int_0 * (int)Class56.memorySignatureScanConfig_15.uint_0);
		int int_1 = 0;
		byte[] array = new byte[30];
		byte[] array2 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_88.uint_0, array2, 4, ref int_1);
		uint num3 = BitConverter.ToUInt32(array2, 0);
		if (num3 != 0)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_89.uint_0, array, array.Length, ref int_1);
			string text = Class1.smethod_3(array);
			if (!(text == string.Empty))
			{
				if (Class11.smethod_6(text) != num3)
				{
					string text2 = string.Empty;
					int num4 = 0;
					while (true)
					{
						if (num4 < text.Length)
						{
							text2 += text[num4];
							if (Class11.smethod_6(text2) == num3)
							{
								break;
							}
							num4++;
							continue;
						}
						return string.Empty;
					}
					return text2;
				}
				return text;
			}
			return string.Empty;
		}
		return string.Empty;
	}

	public static void smethod_24(CharacterAccountConfig characterAccountConfig_0, ref string[] string_0)
	{
		byte[] array = new byte[48];
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		int int_ = 0;
		byte[] array2 = new byte[4];
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array2, 4, ref int_);
		int num2 = BitConverter.ToInt32(array2, 0);
		int num3 = 0;
		for (uint num4 = 1u; num4 < 256; num4++)
		{
			if (num2 <= num3)
			{
				break;
			}
			uint num5 = num + num4 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_16.uint_0, array2, 4, ref int_);
			if (array2[0] == 0)
			{
				continue;
			}
			num3++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_50.uint_0, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) <= 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_88.uint_0, array2, 4, ref int_);
			uint num6 = BitConverter.ToUInt32(array2, 0);
			if (num6 == 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_89.uint_0, array, array.Length, ref int_);
			string text = Class1.smethod_3(array);
			if (text == null || text == string.Empty)
			{
				continue;
			}
			string text2 = string.Empty;
			if (Class11.smethod_6(text) != num6)
			{
				string text3 = string.Empty;
				for (int i = 0; i < text.Length; i++)
				{
					text3 += text[i];
					if (Class11.smethod_6(text3) == num6)
					{
						text2 = text3;
						break;
					}
				}
			}
			else
			{
				text2 = text;
			}
			if (text2 == string.Empty)
			{
				continue;
			}
			if (string_0 != null)
			{
				bool flag = false;
				for (int j = 0; j < string_0.Length; j++)
				{
					if (text2 == string_0[j])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					Array.Resize(ref string_0, string_0.Length + 1);
					string_0[string_0.Length - 1] = text2;
				}
			}
			else
			{
				string_0 = new string[1] { text2 };
			}
		}
	}

	public static void smethod_25(CharacterAccountConfig characterAccountConfig_0, ref string[] string_0, int int_0 = -1, string[] string_1 = null)
	{
		byte[] array = new byte[53];
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		int int_1 = 0;
		byte[] array2 = new byte[4];
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array2, 4, ref int_1);
		int num2 = BitConverter.ToInt32(array2, 0);
		int num3 = 0;
		for (uint num4 = 1u; num4 < 256 && num2 > num3; num4++)
		{
			uint num5 = num + num4 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_16.uint_0, array2, 4, ref int_1);
			if (array2[0] == 0)
			{
				continue;
			}
			num3++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_50.uint_0, array2, 4, ref int_1);
			if (BitConverter.ToInt32(array2, 0) <= 0)
			{
				continue;
			}
			if (0 <= int_0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_52.uint_0, array2, 4, ref int_1);
				uint num6 = BitConverter.ToUInt32(array2, 0);
				if (num6 != int_0)
				{
					continue;
				}
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_16.uint_0, array, array.Length, ref int_1);
			string text = Class1.smethod_3(array);
			if (text == string.Empty)
			{
				continue;
			}
			if (string_1 != null)
			{
				bool flag = false;
				for (int i = 0; i < string_1.Length; i++)
				{
					if (text == string_1[i])
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
			if (string_0 != null)
			{
				bool flag2 = false;
				for (int j = 0; j < string_0.Length; j++)
				{
					if (text == string_0[j])
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					Array.Resize(ref string_0, string_0.Length + 1);
					string_0[string_0.Length - 1] = text;
				}
			}
			else
			{
				string_0 = new string[1] { text };
			}
		}
	}

	public static void smethod_26(CharacterAccountConfig characterAccountConfig_0, ref GStruct25[] gstruct25_0, int int_0 = -1, string[] string_0 = null)
	{
		byte[] array = new byte[53];
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		int int_1 = 0;
		byte[] array2 = new byte[4];
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array2, 4, ref int_1);
		int num2 = BitConverter.ToInt32(array2, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array2, 4, ref int_1);
		int int_2 = BitConverter.ToInt32(array2, 0);
		int num3 = 0;
		for (uint num4 = 1u; num4 < 256 && num2 > num3; num4++)
		{
			uint num5 = num + num4 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_16.uint_0, array2, 4, ref int_1);
			if (array2[0] == 0)
			{
				continue;
			}
			num3++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_50.uint_0, array2, 4, ref int_1);
			if (BitConverter.ToInt32(array2, 0) <= 0)
			{
				continue;
			}
			if (0 <= int_0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_52.uint_0, array2, 4, ref int_1);
				uint num6 = BitConverter.ToUInt32(array2, 0);
				if (num6 != int_0)
				{
					continue;
				}
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_16.uint_0, array, array.Length, ref int_1);
			string text = Class1.smethod_3(array);
			if (text == string.Empty)
			{
				continue;
			}
			if (string_0 != null)
			{
				bool flag = false;
				for (int i = 0; i < string_0.Length; i++)
				{
					if (text == string_0[i])
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
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array2, 4, ref int_1);
			uint num7 = BitConverter.ToUInt32(array2, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array2, 4, ref int_1);
			uint num8 = BitConverter.ToUInt32(array2, 0);
			if (gstruct25_0 != null)
			{
				bool flag2 = false;
				for (int j = 0; j < gstruct25_0.Length; j++)
				{
					if (text == gstruct25_0[j].string_0)
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					Array.Resize(ref gstruct25_0, gstruct25_0.Length + 1);
					gstruct25_0[gstruct25_0.Length - 1].string_0 = text;
					gstruct25_0[gstruct25_0.Length - 1].uint_0 = new uint[2] { num7, num8 };
					gstruct25_0[gstruct25_0.Length - 1].int_0 = int_2;
				}
			}
			else
			{
				gstruct25_0 = new GStruct25[1]
				{
					new GStruct25
					{
						string_0 = text,
						uint_0 = new uint[2] { num7, num8 },
						int_0 = int_2
					}
				};
			}
		}
	}

	public static int smethod_27(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		return (int)smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_66.uint_0);
	}

	public static int smethod_28(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		return (int)smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_56.uint_0);
	}

	public static int smethod_29(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		int num = (int)smethod_3(characterAccountConfig_0, int_0, Class56.memorySignatureScanConfig_54.uint_0);
		if (num > 4)
		{
			num = 5;
		}
		return num;
	}

	public static int smethod_30(CharacterAccountConfig characterAccountConfig_0, int int_0, int int_1)
	{
		uint uint_ = Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_2.uint_0 + (uint)((int)Class56.memorySignatureScanConfig_3.uint_0 * int_1);
		return (int)smethod_3(characterAccountConfig_0, int_0, uint_);
	}

	public static int smethod_31(CharacterAccountConfig characterAccountConfig_0, int int_0, int int_1)
	{
		int num = 0;
		if (characterAccountConfig_0.int_4 == null)
		{
			return -1;
		}
		for (int i = 0; i < characterAccountConfig_0.int_4.GetLength(0); i++)
		{
			if (int_1 == characterAccountConfig_0.int_4[i, 0])
			{
				num = characterAccountConfig_0.int_4[i, 1];
				break;
			}
		}
		if (num == 0)
		{
			return -1;
		}
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num3 = num2 + (uint)(int_0 * (int)Class56.memorySignatureScanConfig_15.uint_0);
		for (uint num4 = 0u; num4 < 6; num4++)
		{
			uint num5 = Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_2.uint_0 + Class56.memorySignatureScanConfig_3.uint_0 * num4, characterAccountConfig_0.int_137);
			if (num5 == num)
			{
				return num;
			}
		}
		return 0;
	}
}
