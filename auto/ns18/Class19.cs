using System;
using ns1;
using ns11;
using ns23;
using ns53;
using ns63;

namespace ns18;

internal class Class19
{
	public static string[] string_0 = new string[3]
	{
		Class11.smethod_15(Class66.smethod_7("KTCTabName0", 0)),
		Class11.smethod_15(Class66.smethod_7("KTCTabName1", 0)),
		Class11.smethod_15(Class66.smethod_7("KTCTabName2", 0))
	};

	public static GStruct1 smethod_0(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		int int_1 = 0;
		byte[] array = new byte[4];
		uint num = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_19.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_20.uint_0 - 4, array, 4, ref int_1);
		uint num2 = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_1);
		uint num3 = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + Class56.memorySignatureScanConfig_18.uint_0, array, 4, ref int_1);
		uint num4 = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + num4 * 4, array, 4, ref int_1);
		uint num5 = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + (uint)(int_0 * 4), array, 4, ref int_1);
		uint num6 = BitConverter.ToUInt32(array, 0) * Class56.memorySignatureScanConfig_22.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_20.uint_0, array, 4, ref int_1);
		uint num7 = BitConverter.ToUInt32(array, 0) + num6;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + 12, array, 4, ref int_1);
		int int_2 = BitConverter.ToInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + 36, array, 4, ref int_1);
		uint uint_ = BitConverter.ToUInt32(array, 0);
		array = new byte[64];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + 48, array, array.Length, ref int_1);
		string text = Class1.smethod_3(array);
		return new GStruct1
		{
			string_0 = text,
			int_0 = int_0,
			int_1 = int_2,
			uint_0 = uint_
		};
	}

	public static GStruct1[] smethod_1(CharacterAccountConfig characterAccountConfig_0)
	{
		GStruct1[] array = null;
		int num = 0;
		int num2 = 0;
		string text = null;
		for (int i = 0; i < 400; i++)
		{
			GStruct1 gStruct = smethod_0(characterAccountConfig_0, i);
			if (gStruct.string_0 == string.Empty)
			{
				continue;
			}
			if (!(text == gStruct.string_0))
			{
				num2 = 0;
			}
			else
			{
				num2++;
				if (num2 > 10)
				{
					break;
				}
			}
			text = gStruct.string_0;
			num++;
			Array.Resize(ref array, num);
			array[num - 1] = gStruct;
		}
		return array;
	}
}
