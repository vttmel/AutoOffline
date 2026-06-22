using System;
using ns23;
using ns53;

namespace ns0;

internal class Class0
{
	public static bool smethod_0(CharacterAccountConfig characterAccountConfig_0, uint uint_0)
	{
		try
		{
			int int_ = 0;
			byte[] array = new byte[4];
			uint num = uint_0 + Class56.memorySignatureScanConfig_38.uint_0;
			uint uint_1 = num - 5780;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_1, array, 4, ref int_);
			if (int_ == 4)
			{
				int num2 = BitConverter.ToInt32(array, 0);
				return num2 > 0;
			}
		}
		catch
		{
		}
		return false;
	}
}
