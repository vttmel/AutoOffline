using System;
using ns1;
using ns23;
using ns53;
using ns71;

namespace ns58;

internal class Class61
{
	public static uint uint_0 = 34180u;

	public static uint uint_1 = 1356u;

	public static int smethod_0(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		int int_1 = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_1);
		uint num = BitConverter.ToUInt32(array, 0);
		if (num == 0)
		{
			return -1;
		}
		uint num2 = num + Class56.memorySignatureScanConfig_12.uint_0 + uint_0 + uint_1;
		uint num3 = num2;
		uint num4 = Class24.smethod_30(num3 + 4, characterAccountConfig_0.int_137);
		uint num5 = Class24.smethod_30(num4 + 4, characterAccountConfig_0.int_137);
		while (true)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + 21, array, 4, ref int_1);
			if (array[0] != 0)
			{
				break;
			}
			uint num6 = Class24.smethod_30(num5 + 12, characterAccountConfig_0.int_137);
			if (num6 >= int_0)
			{
				num4 = num5;
				num5 = Class24.smethod_30(num5, characterAccountConfig_0.int_137);
			}
			else
			{
				num5 = Class24.smethod_30(num5 + 8, characterAccountConfig_0.int_137);
			}
		}
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + 16, array, 4, ref int_1);
		return BitConverter.ToInt32(array, 0);
	}

	public static int smethod_1(CharacterAccountConfig characterAccountConfig_0)
	{
		return smethod_0(characterAccountConfig_0, 1027);
	}

	public static int smethod_2(CharacterAccountConfig characterAccountConfig_0)
	{
		return smethod_0(characterAccountConfig_0, 1044);
	}

	public static bool smethod_3(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_151.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		if (num != 0)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_265.uint_0, array, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array, 0);
			return num == num2;
		}
		return false;
	}

	public static void smethod_4(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_151.uint_0, array, 4, ref int_);
		if (BitConverter.ToUInt32(array, 0) != 0)
		{
			Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_74);
		}
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_147.uint_0, array, 4, ref int_);
		if (BitConverter.ToUInt32(array, 0) != 0)
		{
			Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_73);
		}
	}

	public static string[] smethod_5(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = false)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_265.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		if (num == 0)
		{
			return null;
		}
		if (!bool_0)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_151.uint_0, array, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array, 0);
			if (num2 != num)
			{
				return null;
			}
		}
		string[] array2 = new string[3];
		uint uint_ = num + Class56.memorySignatureScanConfig_266.uint_0 + Class56.memorySignatureScanConfig_157.uint_0;
		uint uint_2 = num + Class56.memorySignatureScanConfig_267.uint_0 + Class56.memorySignatureScanConfig_157.uint_0;
		uint uint_3 = num + Class56.memorySignatureScanConfig_268.uint_0 + Class56.memorySignatureScanConfig_157.uint_0;
		byte[] array3 = new byte[60];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array3, array3.Length, ref int_);
		array2[0] = Class1.smethod_3(array3);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_2, array3, array3.Length, ref int_);
		array2[1] = Class1.smethod_3(array3);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_3, array3, array3.Length, ref int_);
		array2[2] = Class1.smethod_3(array3);
		return array2;
	}
}
