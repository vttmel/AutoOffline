using System;
using System.Threading;
using ns23;
using ns53;
using ns61;
using ns71;

namespace ns65;

internal class Class68
{
	public static int smethod_0(CharacterAccountConfig characterAccountConfig_0, uint[] uint_0, int int_0)
	{
		int int_1 = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_37 * 4, array, 4, ref int_1);
		int num = BitConverter.ToInt32(array, 0);
		if (num != int_0)
		{
			array = BitConverter.GetBytes(int_0);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_37 * 4, array, 4, ref int_1);
			double num2 = 200.0;
			double num3 = Math.Sqrt((double)(int_0 * int_0) + 40000.0);
			double num4 = num2 / num3;
			int num5 = (int)Math.Round(num4 * 180.0 / 3.14, 0);
			array = BitConverter.GetBytes(num5);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + (Class75.uint_37 + 1) * 4, array, 4, ref int_1);
			array = BitConverter.GetBytes(360 / num5);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + (Class75.uint_37 + 2) * 4, array, 4, ref int_1);
			array = new byte[4];
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + (Class75.uint_37 + 3) * 4, array, 4, ref int_1);
		}
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + (Class75.uint_37 + 1) * 4, array, 4, ref int_1);
		uint num6 = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + (Class75.uint_37 + 2) * 4, array, 4, ref int_1);
		uint num7 = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + (Class75.uint_37 + 3) * 4, array, 4, ref int_1);
		uint num8 = BitConverter.ToUInt32(array, 0);
		if (num7 <= num8)
		{
			num8 = 0u;
			array = BitConverter.GetBytes(0u);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + (Class75.uint_37 + 3) * 4, array, 4, ref int_1);
		}
		uint num9 = num8 * num6;
		if (num9 == 0 || num9 > 360)
		{
			num9 = 10u;
		}
		uint[] array2 = new uint[2];
		double num10 = (double)num9 * 3.14 / 180.0;
		array2[0] = (uint)((double)uint_0[0] + (double)int_0 * Math.Cos(num10));
		array2[1] = (uint)((double)uint_0[1] - (double)int_0 * Math.Sin(num10));
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_1);
		uint num11 = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_1);
		uint num12 = BitConverter.ToUInt32(array, 0);
		uint num13 = num12 * Class56.memorySignatureScanConfig_15.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_1);
		uint num14 = BitConverter.ToUInt32(array, 0);
		uint num15 = num14 + num13;
		uint[] array3 = new uint[2];
		int num16 = 3;
		for (int i = 0; i <= num16; i++)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num15 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_1);
			array3[0] = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num15 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_1);
			array3[1] = BitConverter.ToUInt32(array, 0);
			if (Class64.smethod_18(array3, array2) < 11500L)
			{
				break;
			}
			Class75.smethod_61(characterAccountConfig_0, array2);
			if (i > 0 && i < num16)
			{
				Thread.Sleep(100);
			}
		}
		array = BitConverter.GetBytes((int)(num8 + 1));
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + (Class75.uint_37 + 3) * 4, array, 4, ref int_1);
		return 1;
	}
}
