using System;
using ns100;
using ns146;
using ns2;
using ns23;
using ns53;
using ns71;

namespace ns47;

internal class Class50
{
	public static void smethod_0(CharacterAccountConfig characterAccountConfig_0, int int_0, int int_1 = -1)
	{
		int num = GClass1.smethod_5(characterAccountConfig_0);
		if (num > 0)
		{
			Class2.bool_0 = true;
		}
		if (num <= 0 || characterAccountConfig_0.uint_7 == 0 || Class56.memorySignatureScanConfig_245.uint_0 == 0 || Class56.memorySignatureScanConfig_246.uint_0 == 0)
		{
			return;
		}
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_245.uint_0;
		uint uint_2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_246.uint_0;
		int int_2 = 0;
		byte[] array = new byte[2];
		switch (int_0)
		{
		default:
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 2, ref int_2);
			if (array[0] == 144 && array[1] == 144)
			{
				array = new byte[2] { 117, 237 };
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_, array, array.Length, ref int_2);
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_2, array, 2, ref int_2);
			if (array[0] == 144 && array[1] == 233)
			{
				array = new byte[2] { 15, 132 };
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_2, array, array.Length, ref int_2);
			}
			smethod_1(characterAccountConfig_0, 20);
			break;
		case 2:
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 2, ref int_2);
			if (array[0] == 144 && array[1] == 144)
			{
				array = new byte[2] { 117, 237 };
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_, array, array.Length, ref int_2);
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_2, array, 2, ref int_2);
			if (array[0] == 15 && array[1] == 132)
			{
				array = new byte[2] { 144, 233 };
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_2, array, array.Length, ref int_2);
			}
			smethod_1(characterAccountConfig_0, 60);
			break;
		case 1:
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 2, ref int_2);
			if (array[0] == 117 && array[1] == 237)
			{
				array = new byte[2] { 144, 144 };
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_, array, array.Length, ref int_2);
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_2, array, 2, ref int_2);
			if (array[0] == 144 && array[1] == 233)
			{
				array = new byte[2] { 15, 132 };
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_2, array, array.Length, ref int_2);
			}
			smethod_1(characterAccountConfig_0, 40);
			break;
		}
		if (0 <= int_1)
		{
			int_0 = int_1;
		}
		if (Form1.int_71 == 0)
		{
			int num2 = Convert.ToByte(int_0 > 0 && int_0 < 3) * int_0;
			Class75.smethod_52(characterAccountConfig_0, "<bclr=blue><color=green>§ang Gi¶m CPU ®en mµn h×nh: Møc " + num2 + " (bÊm F10)");
		}
	}

	public static void smethod_1(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		uint num = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_247.uint_0;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_248.uint_0;
		uint num3 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_249.uint_0;
		int int_1 = 0;
		byte[] array = new byte[1];
		byte[] byte_ = new byte[1] { (byte)int_0 };
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array, 1, ref int_1);
		if (array[0] == 106)
		{
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num + 1, byte_, 1, ref int_1);
		}
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2, array, 1, ref int_1);
		if (array[0] == 106)
		{
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2 + 1, byte_, 1, ref int_1);
		}
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3, array, 1, ref int_1);
		if (array[0] == 106)
		{
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num3 + 1, byte_, 1, ref int_1);
		}
	}
}
