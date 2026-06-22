using System;
using System.Threading;
using ns11;
using ns23;
using ns53;
using ns71;
using ns85;

namespace ns13;

internal class Class13
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

	public static int smethod_1(CharacterAccountConfig characterAccountConfig_0, uint[] uint_0)
	{
		if (uint_0 != null && characterAccountConfig_0.uint_88 != 0 && uint_0[0] != 0 && uint_0[1] != 0)
		{
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
			uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num4 = num3 + num2;
			int num5 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
			int num6 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
			int num7 = Class89.smethod_39(characterAccountConfig_0);
			int num8 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
			if (num6 != 0 && num5 != 0 && num5 != 10 && num5 != 21 && num8 != 0 && num7 > 1)
			{
				if (!Class75.smethod_63(characterAccountConfig_0, uint_0))
				{
					return -1;
				}
				int num9 = 0;
				int int_ = 0;
				int num10 = 0;
				byte[] array = new byte[1];
				while (!Class11.bool_0 && num9 < 60)
				{
					if (num10 != 0)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_88 - 4, array, 1, ref int_);
						if (array[0] <= 0 && Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137) == 3)
						{
							return 1;
						}
					}
					else if (smethod_3(characterAccountConfig_0))
					{
						num10 = 1;
					}
					num9++;
					Thread.Sleep(10);
				}
				return -1;
			}
			return 0;
		}
		return 0;
	}

	public static bool smethod_2(CharacterAccountConfig characterAccountConfig_0, bool bool_0)
	{
		return Class24.smethod_31(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_178.uint_0, characterAccountConfig_0.int_137, Convert.ToUInt32(bool_0));
	}

	public static bool smethod_3(CharacterAccountConfig characterAccountConfig_0)
	{
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_178.uint_0;
		int num = (int)Class24.smethod_30(uint_, characterAccountConfig_0.int_137);
		return num > 0;
	}
}
