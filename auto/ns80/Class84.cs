using System;
using ns1;
using ns11;
using ns23;
using ns53;

namespace ns80;

internal class Class84
{
	public static int smethod_0(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_124.uint_0 != 0 && Class56.memorySignatureScanConfig_125.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_124.uint_0 + Class56.memorySignatureScanConfig_125.uint_0 + 4;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 4, ref int_);
			return BitConverter.ToInt32(array, 0);
		}
		return -1;
	}

	public static int smethod_1(CharacterAccountConfig characterAccountConfig_0, string string_0, bool bool_0 = false, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		}
		int num = 1;
		while (true)
		{
			if (num < 256)
			{
				uint num2 = uint_0 + (uint)(num * (int)Class56.memorySignatureScanConfig_127.uint_0);
				string text = Class24.smethod_28(num2 + Class56.memorySignatureScanConfig_138.uint_0, characterAccountConfig_0.int_137);
				if (string_0 == text || (!bool_0 && Class11.smethod_1(text, string_0) >= 0))
				{
					break;
				}
				num++;
				continue;
			}
			return 0;
		}
		return num;
	}

	public static uint smethod_2(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		}
		uint_0 += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_127.uint_0);
		return Class24.smethod_30(uint_0, characterAccountConfig_0.int_137);
	}

	public static uint[] smethod_3(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0 = 0u)
	{
		uint[] result = null;
		if (uint_0 == 0)
		{
			uint_0 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		}
		uint_0 += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_127.uint_0);
		uint num = Class24.smethod_30(uint_0 + Class56.memorySignatureScanConfig_133.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(uint_0 + Class56.memorySignatureScanConfig_134.uint_0, characterAccountConfig_0.int_137);
		if (num != 0 && num2 != 0)
		{
			result = new uint[2] { num, num2 };
		}
		return result;
	}

	public static int[] smethod_4(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		}
		uint_0 += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_127.uint_0);
		int num = (int)Class24.smethod_30(uint_0 + Class56.memorySignatureScanConfig_130.uint_0, characterAccountConfig_0.int_137);
		int num2 = (int)Class24.smethod_30(uint_0 + Class56.memorySignatureScanConfig_131.uint_0, characterAccountConfig_0.int_137);
		return new int[2] { num, num2 };
	}

	public static string smethod_5(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0 = 0u, bool bool_0 = false)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		}
		uint_0 += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_127.uint_0);
		string text = Class24.smethod_28(uint_0 + Class56.memorySignatureScanConfig_138.uint_0, characterAccountConfig_0.int_137, 32);
		if (bool_0)
		{
			text = Class1.smethod_1(text, 1);
		}
		return text;
	}

	public static int smethod_6(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		}
		uint_0 += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_127.uint_0);
		return (int)Class24.smethod_30(uint_0 + Class56.memorySignatureScanConfig_128.uint_0, characterAccountConfig_0.int_137);
	}

	public static bool smethod_7(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		}
		uint_0 += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_127.uint_0);
		uint num = Class24.smethod_30(uint_0 + Class56.memorySignatureScanConfig_141.uint_0, characterAccountConfig_0.int_137);
		return num == 0;
	}

	public static uint smethod_8(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		}
		uint_0 += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_127.uint_0);
		return Class24.smethod_30(uint_0 + Class56.memorySignatureScanConfig_140.uint_0, characterAccountConfig_0.int_137);
	}

	public static uint smethod_9(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		}
		uint_0 += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_127.uint_0);
		return Class24.smethod_30(uint_0 + Class56.memorySignatureScanConfig_129.uint_0, characterAccountConfig_0.int_137);
	}

	public static uint smethod_10(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		}
		uint_0 += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_127.uint_0);
		return Class24.smethod_30(uint_0 + Class56.memorySignatureScanConfig_139.uint_0, characterAccountConfig_0.int_137);
	}

	public static uint smethod_11(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		}
		uint_0 += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_127.uint_0);
		return Class24.smethod_30(uint_0 + Class56.memorySignatureScanConfig_136.uint_0, characterAccountConfig_0.int_137);
	}

	public static uint smethod_12(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		}
		uint_0 += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_127.uint_0);
		return Class24.smethod_30(uint_0 + Class56.memorySignatureScanConfig_137.uint_0, characterAccountConfig_0.int_137);
	}

	public static uint smethod_13(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0 = 0u)
	{
		if (uint_0 == 0)
		{
			uint_0 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		}
		uint_0 += (uint)(int_0 * (int)Class56.memorySignatureScanConfig_127.uint_0);
		return Class24.smethod_30(uint_0 + Class56.memorySignatureScanConfig_132.uint_0, characterAccountConfig_0.int_137);
	}
}
