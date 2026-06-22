using System;
using System.Threading;
using ns100;
using ns11;
using ns23;
using ns53;
using ns71;
using ns83;

namespace ns51;

internal class Class54
{
	public static int int_0 = 0;

	public static void smethod_0()
	{
		int int_ = int_0;
		int_0 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25)
				{
					if (0 <= num)
					{
						Form1.characterAccountConfig_1[num].bool_30 = false;
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_30)
					{
						break;
					}
					Form1.characterAccountConfig_1[num].bool_30 = true;
					flag = true;
				}
				smethod_1(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_1(int int_1)
	{
		int int_2 = 0;
		byte[] array = new byte[1];
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		int num = 0;
		long num2 = 0L;
		long long_ = 0L;
		byte[] array2 = new byte[4];
		byte[] byte_ = array2;
		byte[] array3 = null;
		byte[] byte_2 = new byte[4];
		byte[] byte_3 = new byte[4] { 5, 0, 0, 0 };
		byte[] bytes = BitConverter.GetBytes(716);
		byte[] byte_4 = new byte[4];
		byte[] byte_5 = new byte[4];
		int num3 = 0;
		while (true)
		{
			num--;
			Thread.Sleep(300);
			if (num < 0)
			{
				num3 = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
				if (Class11.bool_0 || num3 < 0 || !Form1.characterAccountConfig_1[num3].bool_25)
				{
					break;
				}
				num = 10;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num3];
			if (characterAccountConfig.int_80 <= 0 || !characterAccountConfig.bool_57 || characterAccountConfig.gstruct49_0.int_0 > 0 || Class75.smethod_3(characterAccountConfig, Class75.uint_6, 4) > 0)
			{
				continue;
			}
			uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.int_137);
			uint num5 = Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig.int_137);
			uint num6 = num5 * Class56.memorySignatureScanConfig_15.uint_0;
			uint num7 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig.int_137);
			uint num8 = num7 + num6;
			int num9 = (int)Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
			int num10 = (int)Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig.int_137);
			int num11 = (int)Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
			if (num11 <= 0 || num10 == 0)
			{
				continue;
			}
			switch (num9)
			{
			case 10:
			case 21:
				long_ = 0L;
				num2 = 0L;
				continue;
			case 0:
				continue;
			}
			array3 = null;
			if (characterAccountConfig.int_82 > 0)
			{
				if (Class11.smethod_28(long_) < characterAccountConfig.int_87)
				{
					continue;
				}
			}
			else
			{
				if (Class11.smethod_28(long_) < characterAccountConfig.long_9)
				{
					continue;
				}
				if (characterAccountConfig.int_81 > 0 && num9 == 9)
				{
					Class24.ReadProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_38.uint_0 + 4, array, 1, ref int_2);
					if (array[0] == 0)
					{
						goto IL_02ad;
					}
				}
				if (num2 == 0L)
				{
					for (int i = 0; i < Class56.int_2.Length; i++)
					{
						for (uint num12 = 0u; num12 < 6; num12++)
						{
							uint num13 = Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_2.uint_0 + Class56.memorySignatureScanConfig_3.uint_0 * num12, characterAccountConfig.int_137);
							if (num13 == Class56.int_2[i])
							{
								num2 = Class11.smethod_27();
								break;
							}
						}
					}
					continue;
				}
				if (Class11.smethod_28(num2) <= characterAccountConfig.int_85)
				{
					continue;
				}
			}
			goto IL_02ad;
			IL_02ad:
			int num14 = 0;
			Class75.smethod_2(characterAccountConfig, Class75.uint_6, 1, 4);
			byte[] array4 = new byte[4];
			if (array3 == null)
			{
				array3 = new byte[4];
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_31.uint_0, array3, 4, ref int_2);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num4 + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_68.uint_0, byte_2, 4, ref int_2);
			}
			while (true)
			{
				int j = 0;
				int num15 = -1;
				for (; j < 300; j++)
				{
					Class24.WriteProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_2);
					Class24.ReadProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_55.uint_0, array4, 1, ref int_2);
					if (array4[0] < 4 && (num15 == -1 || num15 > 80))
					{
						break;
					}
					num15 = ((array4[0] <= 3) ? (num15 + 1) : 0);
					Thread.Sleep(1);
				}
				Class24.WriteProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_31.uint_0, byte_, 4, ref int_2);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, byte_4, 4, ref int_2);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, byte_5, 4, ref int_2);
				Class24.WriteProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_37.uint_0, byte_4, 4, ref int_2);
				Class24.WriteProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_38.uint_0, byte_5, 4, ref int_2);
				Class24.WriteProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_36.uint_0, bytes, bytes.Length, ref int_2);
				Class24.WriteProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_35.uint_0, byte_3, 4, ref int_2);
				for (j = 0; j < 60; j++)
				{
					for (uint num16 = 0u; num16 < 6; num16++)
					{
						Class24.ReadProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_2.uint_0 + Class56.memorySignatureScanConfig_3.uint_0 * num16, array4, 4, ref int_2);
						if (BitConverter.ToInt32(array4, 0) == 122)
						{
							goto end_IL_0503;
						}
					}
					Thread.Sleep(10);
				}
				if (num14 > 0)
				{
					break;
				}
				num14++;
				continue;
				end_IL_0503:
				break;
			}
			if (array3 != null)
			{
				Class24.WriteProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_31.uint_0, array3, 4, ref int_2);
				Class24.WriteProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_161.uint_0 - 8, byte_2, 4, ref int_2);
				Class24.WriteProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_35.uint_0, byte_, 4, ref int_2);
				array3 = null;
			}
			Class75.smethod_2(characterAccountConfig, Class75.uint_6, 0, 4);
			num2 = 0L;
			long_ = Class11.smethod_27();
		}
	}
}
