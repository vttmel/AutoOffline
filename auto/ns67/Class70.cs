using System;
using System.Threading;
using ns10;
using ns100;
using ns11;
using ns23;
using ns53;
using ns63;
using ns7;
using ns83;

namespace ns67;

internal class Class70
{
	public static int int_0;

	public static uint uint_0;

	public static MemorySignatureScanConfig memorySignatureScanConfig_0;

	public static MemorySignatureScanConfig memorySignatureScanConfig_1;

	public static MemorySignatureScanConfig memorySignatureScanConfig_2;

	public static MemorySignatureScanConfig memorySignatureScanConfig_3;

	public static MemorySignatureScanConfig memorySignatureScanConfig_4;

	public static MemorySignatureScanConfig memorySignatureScanConfig_5;

	public static MemorySignatureScanConfig memorySignatureScanConfig_6;

	public static MemorySignatureScanConfig memorySignatureScanConfig_7;

	public static MemorySignatureScanConfig memorySignatureScanConfig_8;

	public static MemorySignatureScanConfig memorySignatureScanConfig_9;

	public static MemorySignatureScanConfig memorySignatureScanConfig_10;

	public static MemorySignatureScanConfig memorySignatureScanConfig_11;

	public static MemorySignatureScanConfig memorySignatureScanConfig_12;

	public static MemorySignatureScanConfig memorySignatureScanConfig_13;

	public static MemorySignatureScanConfig memorySignatureScanConfig_14;

	public static MemorySignatureScanConfig memorySignatureScanConfig_15;

	public static MemorySignatureScanConfig memorySignatureScanConfig_16;

	public static MemorySignatureScanConfig memorySignatureScanConfig_17;

	public static MemorySignatureScanConfig memorySignatureScanConfig_18;

	public static MemorySignatureScanConfig memorySignatureScanConfig_19;

	public static MemorySignatureScanConfig memorySignatureScanConfig_20;

	public static MemorySignatureScanConfig memorySignatureScanConfig_21;

	public static MemorySignatureScanConfig memorySignatureScanConfig_22;

	public static MemorySignatureScanConfig memorySignatureScanConfig_23;

	public static MemorySignatureScanConfig memorySignatureScanConfig_24;

	public static MemorySignatureScanConfig memorySignatureScanConfig_25;

	public static MemorySignatureScanConfig memorySignatureScanConfig_26;

	public static uint[,] uint_1;

	public static MemorySignatureScanConfig memorySignatureScanConfig_27;

	public static MemorySignatureScanConfig memorySignatureScanConfig_28;

	public static MemorySignatureScanConfig memorySignatureScanConfig_29;

	public static MemorySignatureScanConfig memorySignatureScanConfig_30;

	public static MemorySignatureScanConfig memorySignatureScanConfig_31;

	private static uint[] uint_2;

	private static uint[] uint_3;

	private static uint[] uint_4;

	private static uint[] uint_5;

	private static uint uint_6;

	private static uint[] uint_7;

	private static uint[] uint_8;

	private static uint[,] uint_9;

	public static int int_1;

	private static uint uint_10;

	private static int int_2;

	private static uint uint_11;

	private static int int_3;

	private static uint uint_12;

	private static int int_4;

	private static Random random_0;

	static Class70()
	{
		int_0 = Class66.smethod_4("fixgCash", 0, "1");
		uint_0 = 12u;
		memorySignatureScanConfig_0 = new MemorySignatureScanConfig
		{
			string_0 = "ENGINE_DISABLE_CASH_1",
			string_1 = "8B ?? ?? ?? ?? ?? ?? ?? ?? 33 C0 59 C3 57 8B",
			byte_0 = Class11.smethod_8("80 38 00 75 04"),
			int_4 = 0,
			int_0 = 1,
			int_2 = 4
		};
		memorySignatureScanConfig_1 = new MemorySignatureScanConfig
		{
			string_0 = "RAINBOW_CASH_1",
			string_1 = "3B 48 38 72 04",
			byte_0 = Class11.smethod_8("8B 45 FC 8B 4D 08"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -6
		};
		memorySignatureScanConfig_2 = new MemorySignatureScanConfig
		{
			string_0 = "MSVCR80_CASH_2",
			string_1 = "40 3B CE 75 F5",
			byte_0 = Class11.smethod_8("80 38 00 74 05"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -5
		};
		memorySignatureScanConfig_3 = new MemorySignatureScanConfig
		{
			string_0 = "LUALIBDLL_CASH_1",
			string_1 = "3C 3D 56 57 75",
			byte_0 = Class11.smethod_8("53 8B 5C 24 0C"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -7
		};
		memorySignatureScanConfig_4 = new MemorySignatureScanConfig
		{
			string_0 = "LUALIBDLL_CASH_2",
			string_1 = "83 F9 06 77 ?? ?? FF",
			byte_0 = Class11.smethod_8("57 8B F9 8B 08"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -5
		};
		memorySignatureScanConfig_5 = new MemorySignatureScanConfig
		{
			string_0 = "LUALIBDLL_CASH_3",
			string_1 = "89 ?? ?? 8B ?? ?? 89 ?? ?? C7",
			byte_0 = Class11.smethod_8("8B 51 44 83 C2 14"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -6
		};
		memorySignatureScanConfig_6 = new MemorySignatureScanConfig
		{
			string_0 = "LUALIBDLL_CASH_4",
			string_1 = "5E 5F 5D 5B 81 C4 ?? ?? ?? ?? C3",
			byte_0 = Class11.smethod_8("8B 44 94 10 8B 04 83"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -7
		};
		memorySignatureScanConfig_7 = new MemorySignatureScanConfig
		{
			string_0 = "LUALIBDLL_CASH_5",
			string_1 = "66 ?? ?? ?? 00 75 ?? 8B ?? ?? E8",
			byte_0 = Class11.smethod_8("39 76 08 75 1B"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -5
		};
		memorySignatureScanConfig_8 = new MemorySignatureScanConfig
		{
			string_0 = "LUALIBDLL_CASH_6",
			string_1 = "39 ?? ?? 74 ?? 8B ?? ?? 85 ?? 75",
			byte_0 = Class11.smethod_8("83 38 03 75 05"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -5
		};
		memorySignatureScanConfig_9 = new MemorySignatureScanConfig
		{
			string_0 = "LUALIBDLL_CASH_7",
			string_1 = "75 12 8B 40 08 8B 08",
			byte_0 = Class11.smethod_8("85 C0 74 17 83 38 06"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -7
		};
		memorySignatureScanConfig_10 = new MemorySignatureScanConfig
		{
			string_0 = "LUALIBDLL_CASH_8",
			string_1 = "EB 03 8B 71 08",
			byte_0 = Class11.smethod_8("8B 49 08 8B 31"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -5
		};
		memorySignatureScanConfig_11 = new MemorySignatureScanConfig
		{
			string_0 = "LUALIBDLL_CASH_9",
			string_1 = "83 C7 01 83 FF 02 75 73",
			byte_0 = Class11.smethod_8("85 C0"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -15
		};
		memorySignatureScanConfig_12 = new MemorySignatureScanConfig
		{
			string_0 = "LUALIBDLL_CASH_10",
			string_1 = "8B 0A 8B 51 18 8B 04 82 8B C8",
			byte_0 = Class11.smethod_8("8B 4E 08 8B 11"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -5
		};
		memorySignatureScanConfig_13 = new MemorySignatureScanConfig
		{
			string_0 = "LUALIBDLL_CASH_11",
			string_1 = "85 C9 74 10 8B 10 8B 12",
			byte_0 = Class11.smethod_8("8B 40 08 8B 48 04"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -6
		};
		memorySignatureScanConfig_14 = new MemorySignatureScanConfig
		{
			string_0 = "LUALIBDLL_CASH_12",
			string_1 = "85 C0 74 0C 83 F8 04",
			byte_0 = Class11.smethod_8("8B 4C 24 04 8B 01"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -6
		};
		memorySignatureScanConfig_15 = new MemorySignatureScanConfig
		{
			string_0 = "LUALIBDLL_CASH_13",
			string_1 = "8B 4C 24 08 3B 11 74 03",
			byte_0 = Class11.smethod_8("8B 44 24 04 8B 10"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -6
		};
		memorySignatureScanConfig_16 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_1",
			int_4 = 0,
			int_0 = 1,
			int_2 = 0
		};
		memorySignatureScanConfig_17 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_2",
			int_4 = 0,
			int_0 = 2,
			int_2 = 0
		};
		memorySignatureScanConfig_18 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_3",
			int_4 = 0,
			int_0 = 1,
			int_2 = 6
		};
		memorySignatureScanConfig_19 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_5",
			byte_0 = Class11.smethod_8("8B 11 8B C8 8B 42 10 FF D0"),
			int_4 = 0,
			int_0 = 1,
			int_2 = 23
		};
		memorySignatureScanConfig_20 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_6",
			byte_0 = Class11.smethod_8("8B 11 8B 52 10"),
			int_4 = 0,
			int_0 = 1,
			int_2 = 2
		};
		memorySignatureScanConfig_21 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_7",
			byte_0 = Class11.smethod_8("8B 4D 08 8B 14 99"),
			int_4 = 0,
			int_0 = 1,
			int_2 = 10
		};
		memorySignatureScanConfig_22 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_8",
			byte_0 = Class11.smethod_8("8B F1 83 7E 04 03"),
			int_4 = 0,
			int_0 = 1,
			int_2 = -6
		};
		memorySignatureScanConfig_23 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_9",
			byte_0 = Class11.smethod_8("8B 4F 20 8B 47 1C"),
			int_4 = 0,
			int_0 = 1,
			int_2 = 0
		};
		memorySignatureScanConfig_24 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_10",
			byte_0 = Class11.smethod_8("8B 4F 20 8B 47 1C"),
			int_4 = 0,
			int_0 = 2,
			int_2 = 0
		};
		memorySignatureScanConfig_25 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_13",
			byte_0 = Class11.smethod_8("55 8B EC 83 EC 08"),
			int_4 = 0,
			int_0 = 1,
			int_2 = 0
		};
		memorySignatureScanConfig_26 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_14",
			byte_0 = Class11.smethod_8("55 8B EC 83 EC 08"),
			int_4 = 0,
			int_0 = 2,
			int_2 = 0
		};
		uint[,] array_ = new uint[5, 2];
		Class10.smethod_4(array_, 315331);
		uint_1 = array_;
		memorySignatureScanConfig_27 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_17",
			byte_0 = Class11.smethod_8("89 46 10 B8 01 00 00 00"),
			int_4 = 0,
			int_0 = 1,
			int_2 = 13
		};
		memorySignatureScanConfig_28 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_18",
			byte_0 = Class11.smethod_8("8B 45 F8 8B 0C 82"),
			int_4 = 0,
			int_0 = 1,
			int_2 = 11
		};
		memorySignatureScanConfig_29 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_19",
			byte_0 = Class11.smethod_8("8B 45 F8 8B 0C 82"),
			int_4 = 0,
			int_0 = 2,
			int_2 = 11
		};
		memorySignatureScanConfig_30 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_20",
			byte_0 = Class11.smethod_8("8B 12 8B 42 10"),
			int_4 = 0,
			int_0 = 1,
			int_2 = 39
		};
		memorySignatureScanConfig_31 = new MemorySignatureScanConfig
		{
			string_0 = "GAME_DISABE_CASH_21",
			byte_0 = Class11.smethod_8("8B 12 8B 42 10"),
			int_4 = 0,
			int_0 = 2,
			int_2 = 39
		};
		uint_2 = new uint[4] { 5733873u, 5821081u, 5821129u, 5821177u };
		uint_3 = new uint[2] { 5487116u, 5488471u };
		uint_4 = new uint[2] { 4392437u, 4420261u };
		uint_5 = new uint[3] { 4617779u, 4757496u, 4759208u };
		uint_6 = 5170458u;
		uint_7 = new uint[2] { 4388439u, 4417002u };
		uint_8 = new uint[2] { 4417105u, 4388533u };
		uint[,] array_2 = new uint[3, 2];
		Class10.smethod_4(array_2, 315582);
		uint_9 = array_2;
		int_1 = 0;
		uint_10 = 0u;
		int_2 = 0;
		uint_11 = 0u;
		int_3 = 0;
		uint_12 = 0u;
		int_4 = 0;
		random_0 = new Random();
	}

	private static void smethod_0(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		if (Class56.memorySignatureScanConfig_7.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_7.uint_0, array, 4, ref int_);
			uint num = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array, 0);
			if (num2 == 1347469363)
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, new byte[4] { 51, 192, 195, 144 }, 4, ref int_);
			}
		}
	}

	private static uint smethod_1(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0 = true)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_11 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = Class11.smethod_8("80 38 00 74 05", bool_1: false);
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_11 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 24) + 5;
			uint num4 = num - (num2 + 35) + 10;
			string string_ = "3D 00 00 01 00 7E 11 3D 00 10 FE 7F 7D 0A 80 38 00 74 0BE9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "E9" + Class11.smethod_46(num4, 8, bool_1: false, bool_2: true);
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num5 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num5, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num5 + 4);
			if (bool_0)
			{
				array3 = BitConverter.GetBytes(num2 - num - 5);
				array = new byte[5]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3]
				};
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_2(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0 = true)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_8 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = new byte[5] { 128, 56, 0, 117, 4 };
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_8 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 23) + 9;
			string string_ = "3D 00 00 01 00 7E 12 3D 00 10 FE 7F 7D 0B 80 38 000F 85" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "EB 06FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "33 C0 59 C3";
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[5]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3]
				};
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_3(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0 = true)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_10 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = Class11.smethod_8("8B 45 FC 8B 4D 08", bool_1: false);
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_10 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 25) + 6;
			string string_ = "8B 45 FC 8B 4D 08 3D 00 00 01 00 7E 0C 3D 00 10 FE 7F 7D 05E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "8B E5 5D C2 04 00";
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[6]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3],
					144
				};
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_4(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_9 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = new byte[5] { 83, 139, 92, 36, 12 };
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_9 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 25) + 5;
			string string_ = "53 8B 5C 24 0C 81 FB 00 00 01 00 7E 0C 81 FB 00 10 FE 7F0F 8C" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "5B C3";
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[5]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3]
				};
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_5(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_9 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = new byte[5] { 87, 139, 249, 139, 8 };
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_9 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 55) + 5;
			string string_ = "3D 00 00 01 00 7E 31 3D 00 10 FE 7F 7D 2A 57 8B F9 8B 08 83 F9 01 74 1A 83 F9 02 74 15 8B 48 08 81 F9 00 00 01 00 7E 0F 81 F9 00 10 FE 7F 7D 07 8B 08E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "5FFF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "81 FF 00 00 01 00 7E 08 81 FF 00 10 FE 7F 7C 05 BF 00 00 01 00 81 FB 00 00 01 00 7E 0D 81 FB 00 10 FE 7F 7C 05 BB 00 00 01 00 C3";
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[5]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3]
				};
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_6(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_9 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = new byte[6] { 139, 81, 68, 131, 194, 20 };
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_9 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 41) + 6;
			string string_ = "81 F9 00 00 01 00 7E 21 3D 00 00 01 00 7E 1A 81 F9 00 10 FE 7F 7D 12 3D 00 10 FE 7F 7D 0B 8B 51 44 83 C2 14E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "C3";
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[6]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3],
					144
				};
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_7(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_9 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = new byte[7] { 139, 68, 148, 16, 139, 4, 131 };
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_9 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 38) + 7;
			string string_ = "8B 44 94 10 81 FB 00 00 01 00 7E 0D 81 FB 00 10 FE 7F 7D 05 8B 04 83 EB 08 33 C0FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true);
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				byte[] array4 = new byte[7] { 233, 0, 0, 0, 0, 144, 144 };
				array4[1] = array3[0];
				array4[2] = array3[1];
				array4[3] = array3[2];
				array4[4] = array3[3];
				array = array4;
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_8(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_9 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = new byte[5] { 57, 118, 8, 117, 27 };
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_9 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 49) + 5;
			string string_ = "81 FE 00 00 01 00 7E 29 81 FE 00 10 FE 7F 7D 21 39 76 08 75 22 66 83 7E 0C 00 74 10 81 FF 00 00 01 00 7E 0D 81 FF 00 10 FE 7F 7D 05E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "C3";
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[5]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3]
				};
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_9(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_9 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = new byte[5] { 131, 56, 3, 117, 5 };
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_9 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 33) + 10;
			uint num4 = num - (num2 + 38) + 5;
			string string_ = "3D 00 00 01 00 7E 07 3D 00 10 FE 7F 7C 0AFF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "83 C0 10 C3 83 38 030F 85" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "E9" + Class11.smethod_46(num4, 8, bool_1: false, bool_2: true);
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num5 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num5, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num5 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[5]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3]
				};
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_10(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_9 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = new byte[7] { 133, 192, 116, 23, 131, 56, 6 };
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_9 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 84) + 29;
			string string_ = "85 C0 74 48 3D 00 00 01 00 7E 3B 3D 00 10 FE 7F 7D 34 83 38 06 75 35 8B 40 08 3D 00 00 01 00 7E 25 3D 00 10 FE 7F 7D 1E 8B 08 81 F9 00 00 01 00 7E 14 81 F9 00 10 FE 7F 7D 0C 66 83 79 0C 00 75 0B 33 C0 B0 01 C3FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "33 C0 C3E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true);
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				byte[] array4 = new byte[7] { 233, 0, 0, 0, 0, 144, 144 };
				array4[1] = array3[0];
				array4[2] = array3[1];
				array4[3] = array3[2];
				array4[4] = array3[3];
				array = array4;
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_11(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_9 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			byte[] array2 = Class11.smethod_8("66 83 7E 0C 00");
			if (array == null)
			{
				array = Class11.smethod_8("8B 49 08 8B 31");
			}
			byte[] array3 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_9 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array3, array3.Length, ref int_);
			if (array3[0] != 233)
			{
				for (int i = 0; i < array3.Length; i++)
				{
					if (array3[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = 58u;
			uint num4 = num - (num2 + 58) + 5;
			uint num5 = num - (num2 + 100) + 15;
			string string_ = "81 F9 00 00 01 00 7E 5C 81 F9 00 10 FE 7F 7D 54 8B 49 08 81 F9 00 00 01 00 7E 49 81 F9 00 10 FE 7F 7D 41 8B 31 81 FE 00 00 01 00 7E 37 81 FE 00 10 FE 7F 7D 2FE9" + Class11.smethod_46(num4, 8, bool_1: false, bool_2: true) + "81 FE 00 00 01 00 7E 22 81 FF 00 00 01 00 7E 1A 81 FE 00 10 FE 7F 7D 12 81 FF 00 10 FE 7F 7D 0A 66 83 7E 0C 00E9" + Class11.smethod_46(num5, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "5E C3";
			byte[] array4 = Class11.smethod_8(string_, bool_1: false);
			int num6 = array4.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array4, num6, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num6 + 4);
			if (bool_0)
			{
				array4 = BitConverter.GetBytes(num2 - num - 5);
				array = new byte[5]
				{
					233,
					array4[0],
					array4[1],
					array4[2],
					array4[3]
				};
				array4 = BitConverter.GetBytes(num2 + num3 - num - 15);
				array2 = new byte[5]
				{
					233,
					array4[0],
					array4[1],
					array4[2],
					array4[3]
				};
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num + 10, array2, array2.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static bool smethod_12(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_9 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = new byte[2] { 133, 192 };
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_9 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[1] == 192)
			{
				if (array2[0] != 133 && array2[0] != 51)
				{
					return false;
				}
				if (bool_0 && array2[0] == 133)
				{
					array2[0] = 51;
					Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array2, 1, ref int_);
				}
				else if (!bool_0 && array2[0] == 51)
				{
					array2[0] = 133;
					Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array2, 1, ref int_);
				}
				return true;
			}
			return false;
		}
		return false;
	}

	private static uint smethod_13(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_9 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = Class11.smethod_8("8B 4E 08 8B 11");
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_9 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 98) + 13;
			string string_ = "81 FE 00 00 01 00 7E 5A 81 FE 00 10 FE 7F 7D 52 8B 4E 08 81 F9 00 00 01 00 7E 47 81 F9 00 10 FE 7F 7D 3F 8B 11 81 FA 00 00 01 00 7E 35 81 FA 00 10 FE 7F 7D 2D 8B 0A 81 F9 00 00 01 00 7E 23 81 F9 00 10 FE 7F 7D 1B 8B 51 18 81 FA 00 00 01 00 7E 10 81 FA 00 10 FE 7F 7D 08 8B 04 82E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "33 C0 5E C3";
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[5]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3]
				};
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_14(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_9 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = Class11.smethod_8("8B 40 08 8B 48 04");
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_9 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 95) + 14;
			string string_ = "3D 00 00 01 00 7E 58 3D 00 10 FE 7F 7D 51 8B 40 08 3D 00 00 01 00 7E 47 3D 00 10 FE 7F 7D 40 8B 48 04 85 C9 74 3F 81 F9 00 00 01 00 7E 31 81 F9 00 10 FE 7F 7D 29 8B 10 81 FA 00 00 01 00 7E 1F 81 FA 00 10 FE 7F 7D 17 8B 12 81 FA 00 00 01 00 7E 0D 81 FA 00 10 FE 7F 7D 05E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "83 C8 FF C3";
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[6]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3],
					144
				};
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_15(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_9 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = Class11.smethod_8("8B 4C 24 04 8B 01");
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_9 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 88) + 5;
			string string_ = "8B 4C 24 04 81 F9 00 00 01 00 7E 3E 81 F9 00 10 FE 7F 7D 36 8B 01 85 C0 74 1A 83 F8 04 75 14 8B 41 08 3D 00 00 01 00 7E 0B 3D 00 10 FE 7F 7D 04 8B 40 04 C3 8B 49 08 81 F9 00 00 01 00 7E 0B 81 F9 00 10 FE 7F 7D 03 8B 01 C3 33 C0FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "C3E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true);
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[6]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3],
					144
				};
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_16(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0 && characterAccountConfig_0.uint_9 != 0 && characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = Class11.smethod_8("8B 44 24 04 8B 10");
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_9 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 45) + 10;
			string string_ = "8B 44 24 04 8B 4C 24 08 3D 00 00 01 00 7E 1E 3D 00 10 FE 7F 7D 17 81 F9 00 00 01 00 7E 0F 81 F9 00 10 FE 7F 7D 07 8B 10E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "33 C0 40 C3";
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[6]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3],
					144
				};
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_17(CharacterAccountConfig characterAccountConfig_0, uint uint_13, byte byte_0, bool bool_0)
	{
		if (uint_13 == 0)
		{
			return characterAccountConfig_0.uint_22;
		}
		string text = Class11.smethod_46(byte_0, 2, bool_1: false);
		int int_ = 0;
		byte[] array = Class11.smethod_8("55 8B EC 83 EC" + text);
		byte[] array2 = new byte[array.Length];
		uint num = characterAccountConfig_0.uint_7 + uint_13;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
		if (array2[0] != 233)
		{
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] != array[i])
				{
					return characterAccountConfig_0.uint_22;
				}
			}
		}
		characterAccountConfig_0.uint_22 += 16u;
		uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
		uint num3 = num - (num2 + 27) + 6;
		string string_ = "81 F9 00 00 01 00 7E 13 81 F9 00 10 FE 7F 7D 0B 55 8B EC83 EC" + text + "E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "33 C0 C2 04 00";
		byte[] array3 = Class11.smethod_8(string_, bool_1: false);
		int num4 = array3.Length;
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
		characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
		if (bool_0)
		{
			uint value = num2 - num - 5;
			array3 = BitConverter.GetBytes(value);
			array = new byte[6]
			{
				233,
				array3[0],
				array3[1],
				array3[2],
				array3[3],
				144
			};
		}
		if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
		{
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_18(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = new byte[5] { 139, 66, 16, 255, 208 };
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_7 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 51) + 5;
			string string_ = "81 FA 00 00 01 00 7E 1D 81 FA 00 10 FE 7F 7D 15 8B 42 10 3D 00 00 01 00 7E 0B 3D 00 10 FE 7F 7D 04 FF D0 EB 09 58 5A 59FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true);
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[5]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3]
				};
			}
			if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_19(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 == 0)
		{
			return characterAccountConfig_0.uint_22;
		}
		int int_ = 0;
		byte[] array = memorySignatureScanConfig_32.byte_0;
		if (array == null)
		{
			array = new byte[9] { 139, 17, 139, 200, 139, 66, 16, 255, 208 };
		}
		byte[] array2 = new byte[array.Length];
		uint num = characterAccountConfig_0.uint_7 + memorySignatureScanConfig_32.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
		if (array2[0] != 233)
		{
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] != array[i])
				{
					return characterAccountConfig_0.uint_22;
				}
			}
		}
		characterAccountConfig_0.uint_22 += 16u;
		uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
		uint num3 = num - (num2 + 71) + 9;
		string string_ = "81 F9 00 00 01 00 7E 31 81 F9 00 10 FE 7F 7D 29 8B 11 8B C8 81 FA 00 00 01 00 7E 1D 81 FA 00 10 FE 7F 7D 15 8B 42 10 3D 00 00 01 00 7E 0B 3D 00 10 FE 7F 7D 04 FF D0 EB 09 58 5A 58FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true);
		byte[] array3 = Class11.smethod_8(string_, bool_1: false);
		int num4 = array3.Length;
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
		characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
		if (bool_0)
		{
			uint value = num2 - num - 5;
			array3 = BitConverter.GetBytes(value);
			byte[] array4 = new byte[9] { 233, 0, 0, 0, 0, 144, 144, 144, 144 };
			array4[1] = array3[0];
			array4[2] = array3[1];
			array4[3] = array3[2];
			array4[4] = array3[3];
			array = array4;
		}
		if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
		{
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_20(CharacterAccountConfig characterAccountConfig_0, uint uint_13, bool bool_0)
	{
		if (uint_13 == 0)
		{
			return characterAccountConfig_0.uint_22;
		}
		int int_ = 0;
		byte[] array = new byte[5] { 139, 17, 139, 82, 16 };
		byte[] array2 = new byte[array.Length];
		uint num = characterAccountConfig_0.uint_7 + uint_13;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
		if (array2[0] != 233)
		{
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] != array[i])
				{
					return characterAccountConfig_0.uint_22;
				}
			}
		}
		characterAccountConfig_0.uint_22 += 16u;
		uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
		uint num3 = num - (num2 + 58) + 5;
		string string_ = "81 F9 00 00 01 00 7E 32 81 F9 00 10 FE 7F 7D 2A 8B 11 81 FA 00 00 01 00 7E 20 81 FA 00 10 FE 7F 7D 18 8B 52 10 81 FA 00 00 01 00 7E 0D 81 FA 00 10 FE 7F 7D 05E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "83 C4 08 C2 04 00";
		byte[] array3 = Class11.smethod_8(string_, bool_1: false);
		int num4 = array3.Length;
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
		characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
		if (bool_0)
		{
			uint value = num2 - num - 5;
			array3 = BitConverter.GetBytes(value);
			array = new byte[5]
			{
				233,
				array3[0],
				array3[1],
				array3[2],
				array3[3]
			};
		}
		if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
		{
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_21(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = Class11.smethod_8("8B 4D 08 8B 14 99");
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_7 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 43) + 6;
			uint num4 = num - (num2 + 54) - 26;
			string string_ = "8B 4D 08 81 F9 00 00 01 00 7E 20 81 F9 00 10 FE 7F 7D 18 8B 14 99 81 FA 00 00 01 00 7E 0D 81 FA 00 10 FE 7F 7D 05E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "E9" + Class11.smethod_46(num4, 8, bool_1: false, bool_2: true);
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num5 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num5, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num5 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[6]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3],
					144
				};
			}
			if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_22(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0)
	{
		if (memorySignatureScanConfig_32.uint_0 == 0)
		{
			return characterAccountConfig_0.uint_22;
		}
		int int_ = 0;
		byte[] array = memorySignatureScanConfig_32.byte_0;
		if (array == null)
		{
			array = Class11.smethod_8("8B F1 83 7E 04 03");
		}
		byte[] array2 = new byte[array.Length];
		uint num = characterAccountConfig_0.uint_7 + memorySignatureScanConfig_32.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
		if (array2[0] != 233)
		{
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] != array[i])
				{
					return characterAccountConfig_0.uint_22;
				}
			}
		}
		characterAccountConfig_0.uint_22 += 16u;
		uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
		uint num3 = num - (num2 + 25) + 6;
		string string_ = "81 FE 00 00 01 00 7E 11 81 FE 00 10 FE 7F 7D 09 83 7E 04 03E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "5EC3";
		byte[] array3 = Class11.smethod_8(string_, bool_1: false);
		int num4 = array3.Length;
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
		characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
		if (bool_0)
		{
			uint value = num2 - num - 5;
			array3 = BitConverter.GetBytes(value);
			array = new byte[6]
			{
				233,
				array3[0],
				array3[1],
				array3[2],
				array3[3],
				144
			};
		}
		if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
		{
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_23(CharacterAccountConfig characterAccountConfig_0, uint uint_13, bool bool_0)
	{
		if (uint_13 != 0)
		{
			int int_ = 0;
			byte[] array = Class11.smethod_8("8B 4F 20 8B 47 1C");
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_7 + uint_13;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 27) + 6;
			uint num4 = num - (num2 + 40) + 32;
			string string_ = "81 FF 00 00 01 00 7E 13 81 FF 00 10 FE 7F 7D 0B 8B 4F 20 8B 47 1CE9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "33 C0E9" + Class11.smethod_46(num4, 8, bool_1: false, bool_2: true);
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num5 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num5, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num5 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[6]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3],
					144
				};
			}
			if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_24(CharacterAccountConfig characterAccountConfig_0, uint uint_13, bool bool_0)
	{
		if (uint_13 == 0)
		{
			return characterAccountConfig_0.uint_22;
		}
		int int_ = 0;
		byte[] array = Class11.smethod_8("8B 45 F8 8B 0C 82");
		byte[] array2 = new byte[array.Length];
		uint num = characterAccountConfig_0.uint_7 + uint_13;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
		if (array2[0] != 233)
		{
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] != array[i])
				{
					return characterAccountConfig_0.uint_22;
				}
			}
		}
		characterAccountConfig_0.uint_22 += 16u;
		uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
		uint num3 = num - (num2 + 43) + 6;
		string string_ = "81 FA 00 00 01 00 7E 23 81 FA 00 10 FE 7F 7D 1B 8B 45 F8 8B 0C 82 81 F9 00 00 01 00 7E 0D 81 F9 00 10 FE 7F 7D 05E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "8B 45 FC 8B E5 5D C2 04 00";
		byte[] array3 = Class11.smethod_8(string_, bool_1: false);
		int num4 = array3.Length;
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
		characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
		if (bool_0)
		{
			uint value = num2 - num - 5;
			array3 = BitConverter.GetBytes(value);
			array = new byte[6]
			{
				233,
				array3[0],
				array3[1],
				array3[2],
				array3[3],
				144
			};
		}
		if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
		{
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_25(CharacterAccountConfig characterAccountConfig_0, uint uint_13, bool bool_0)
	{
		if (uint_13 != 0)
		{
			int int_ = 0;
			byte[] array = Class11.smethod_8("8B 12 8B 42 10");
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_7 + uint_13;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 69) + 7;
			string string_ = "81 FA 00 00 01 00 7E 2F 81 FA 00 10 FE 7F 7D 27 8B 12 81 FA 00 00 01 00 7E 1D 81 FA 00 10 FE 7F 7D 15 8B 42 10 3D 00 00 01 00 7E 0B 3D 00 10 FE 7F 7D 04 FF D0 EB 09FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "59 59 59E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true);
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[5]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3]
				};
			}
			if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_26(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		uint[] array = new uint[3] { 246944u, 247008u, 744240u };
		int num = -1;
		while (true)
		{
			IL_01b6:
			num++;
			if (array.Length <= num)
			{
				break;
			}
			int int_ = 0;
			byte[] array2 = Class11.smethod_8("55 8B EC 51 89 4D FC");
			byte[] array3 = new byte[array2.Length];
			uint num2 = characterAccountConfig_0.uint_7 + array[num];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2, array3, array3.Length, ref int_);
			if (array3[0] != 233)
			{
				int num3 = 0;
				while (num3 < array3.Length)
				{
					if (array3[num3] == array2[num3])
					{
						num3++;
						continue;
					}
					goto IL_01b6;
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num4 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num5 = num2 - (num4 + 28) + 7;
			string string_ = "81 F9 00 00 01 00 7E 14 81 F9 00 10 FE 7F 7D 0C 55 8B EC 51 89 4D FCE9" + Class11.smethod_46(num5, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "C3";
			byte[] array4 = Class11.smethod_8(string_, bool_1: false);
			int num6 = array4.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4, array4, num6, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num6 + 4);
			if (bool_0)
			{
				uint value = num4 - num2 - 5;
				array4 = BitConverter.GetBytes(value);
				byte[] array5 = new byte[7] { 233, 0, 0, 0, 0, 144, 144 };
				array5[1] = array4[0];
				array5[2] = array4[1];
				array5[3] = array4[2];
				array5[4] = array4[3];
				array2 = array5;
			}
			if ((!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233))
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array2, array2.Length, ref int_);
			}
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_27(CharacterAccountConfig characterAccountConfig_0, uint uint_13, byte byte_0, bool bool_0 = true)
	{
		if (uint_13 != 0)
		{
			int int_ = 0;
			byte[] array = Class11.smethod_8("55 8B EC 83 EC 0C 89 4D F4");
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_7 + uint_13;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + 36, array2, 1, ref int_);
			if (array2[0] != byte_0)
			{
				return characterAccountConfig_0.uint_22;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 202) + 5;
			string string_ = "55 8B EC 83 EC 0C 89 4D F4 8B 45 F4 3D 00 00 01 00 0F 8E 8A 00 00 00 3D 00 10 FE 7F 0F 8D 7F 0000 00 8B 48 04 81 F9 00 00 01 00 7E 74 81 F9 00 10 FE 7F 7D 6C 8B 51 04 89 55 F8 8B 45 F4 8B 4804 89 4D FC 8B 55 F8 81 FA 00 00 01 00 7E 52 81 FA 00 10 FE 7F 7D 4A0F BE 42" + Class11.smethod_46(byte_0, 2, bool_1: false) + "85 C0 75 48 8B 4D F8 8B 55 08 81 FA 00 00 01 00 7E 34 81 FA 00 10 FE 7F 7D 2C 8B 41 0C 33 C9 3B02 0F 9C C1 0F B6 D1 85 D2 74 0B 8B 45 F8 8B 48 08 89 4D F8 EB 0E 8B 55 F8 89 55 FC 8B 45 F8 8B08 89 4D F8 EB A3FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "8B 45 FC 3D 00 00 01 00 7E 09 3D 00 10 FE 7F 7D 02 EB 05B8" + Class11.smethod_46(characterAccountConfig_0.uint_21 + 4, 8, bool_1: false, bool_2: true) + "8B E5 5D C2 04 00E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true);
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[6]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3],
					195
				};
			}
			if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_28(CharacterAccountConfig characterAccountConfig_0, MemorySignatureScanConfig memorySignatureScanConfig_32, bool bool_0 = true)
	{
		if (memorySignatureScanConfig_32.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = memorySignatureScanConfig_32.byte_0;
			if (array == null)
			{
				array = Class11.smethod_8("89 46 10 B8 01 00 00 00");
			}
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_7 + memorySignatureScanConfig_32.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 27) + 8;
			string string_ = "81 FE 00 00 01 00 7E 13 81 FE 00 10 FE 7F 7D 0B 89 46 10 33 C0 40E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "5E C2 08 00";
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				byte[] array4 = new byte[8] { 233, 0, 0, 0, 0, 144, 144, 144 };
				array4[1] = array3[0];
				array4[2] = array3[1];
				array4[3] = array3[2];
				array4[4] = array3[3];
				array = array4;
			}
			if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_29(CharacterAccountConfig characterAccountConfig_0, uint uint_13, bool bool_0 = true)
	{
		if (characterAccountConfig_0.uint_21 != 0 && uint_13 != 0)
		{
			int int_ = 0;
			uint num = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_147.uint_0;
			byte[] array = Class11.smethod_8("8B 0D" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true));
			byte[] array2 = Class11.smethod_8("8B 15" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true));
			byte[] array3 = new byte[array.Length];
			uint num2 = characterAccountConfig_0.uint_7 + uint_13;
			uint num3 = num2 + 11;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2, array3, array3.Length, ref int_);
			if (array3[0] != 233)
			{
				for (int i = 0; i < array3.Length; i++)
				{
					if (array3[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num4 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num5 = num4 + 27;
			uint num6 = num2 - (num4 + 27) + 6;
			uint num7 = num3 - (num5 + 27) + 6;
			string string_ = "8B 0D" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "81 F9 00 00 01 00 7E 28 81 F9 00 10 FE 7F 7D 20E9" + Class11.smethod_46(num6, 8, bool_1: false, bool_2: true) + "8B 15" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "81 FA 00 00 01 00 7E 0D 81 FA 00 10 FE 7F 7D 05E9" + Class11.smethod_46(num7, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "33 C0 8B 4D F4 64 89 0D 00 00 00 00 59 8B E5 5D C3";
			byte[] array4 = Class11.smethod_8(string_, bool_1: false);
			int num8 = array4.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4, array4, num8, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num8 + 4);
			if (bool_0)
			{
				array4 = BitConverter.GetBytes(num4 - (num2 + 5));
				array = new byte[6]
				{
					233,
					array4[0],
					array4[1],
					array4[2],
					array4[3],
					144
				};
				array4 = BitConverter.GetBytes(num5 - (num3 + 5));
				array2 = new byte[6]
				{
					233,
					array4[0],
					array4[1],
					array4[2],
					array4[3],
					144
				};
			}
			if ((!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233))
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array, array.Length, ref int_);
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num3, array2, array2.Length, ref int_);
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_30(CharacterAccountConfig characterAccountConfig_0, uint uint_13, bool bool_0 = true)
	{
		if (characterAccountConfig_0.uint_21 != 0 && uint_13 != 0)
		{
			int int_ = 0;
			string text = "8B 91";
			byte[] array = Class11.smethod_8(text);
			byte[] array2 = new byte[4];
			uint num = 0u;
			byte[] array3 = new byte[array.Length];
			uint num2 = characterAccountConfig_0.uint_7 + uint_13;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2, array3, array3.Length, ref int_);
			if (array3[0] == 233)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + 1, array2, array2.Length, ref int_);
				num = BitConverter.ToUInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + num2 + 5 + 18, array2, array2.Length, ref int_);
			}
			else
			{
				for (int i = 0; i < array3.Length; i++)
				{
					if (array3[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + 2, array2, array2.Length, ref int_);
			}
			num = BitConverter.ToUInt32(array2, 0);
			characterAccountConfig_0.uint_22 += 16u;
			uint num3 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num4 = num2 - (num3 + 74) + 9;
			string string_ = "81 F9 00 00 01 00 7E 35 81 F9 00 10 FE 7F 7D 2D" + text + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "81 FA 00 00 01 00 7E 1F 81 FA 00 10 FE 7F 7D 17 8B 04 82 85 C0 74 18 3D 00 00 01 00 7E 09 3D 00 10 FE 7F 7D 02 EB 08 33 C0FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "E9" + Class11.smethod_46(num4, 8, bool_1: false, bool_2: true);
			byte[] array4 = Class11.smethod_8(string_, bool_1: false);
			int num5 = array4.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num3, array4, num5, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num5 + 4);
			if (bool_0)
			{
				uint value = num3 - num2 - 5;
				array4 = BitConverter.GetBytes(value);
				array2 = new byte[6]
				{
					233,
					array4[0],
					array4[1],
					array4[2],
					array4[3],
					144
				};
			}
			else
			{
				array2 = Class11.smethod_8(text + Class11.smethod_46(num, 8, bool_1: false, bool_2: true));
			}
			if (num != 0 && ((!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233)))
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array2, array2.Length, ref int_);
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_31(CharacterAccountConfig characterAccountConfig_0, uint uint_13, bool bool_0 = true)
	{
		if (characterAccountConfig_0.uint_21 != 0 && uint_13 != 0)
		{
			int int_ = 0;
			string text = "8B 88";
			byte[] array = Class11.smethod_8(text);
			byte[] array2 = new byte[4];
			uint num = 0u;
			byte[] array3 = new byte[array.Length];
			uint num2 = characterAccountConfig_0.uint_7 + uint_13;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2, array3, array3.Length, ref int_);
			if (array3[0] != 233)
			{
				for (int i = 0; i < array3.Length; i++)
				{
					if (array3[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + 2, array2, array2.Length, ref int_);
			}
			else
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + 1, array2, array2.Length, ref int_);
				num = BitConverter.ToUInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + num2 + 5 + 16, array2, array2.Length, ref int_);
			}
			num = BitConverter.ToUInt32(array2, 0);
			characterAccountConfig_0.uint_22 += 16u;
			uint num3 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num4 = num2 - (num3 + 41) + 6;
			uint num5 = num2 - (num3 + 57) - 25;
			string string_ = "3D 00 00 01 00 7E 22 3D 00 10 FE 7F 7D 1B" + text + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "81 F9 00 00 01 00 7E 0D 81 F9 00 10 FE 7F 7D 05E9" + Class11.smethod_46(num4, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "33 C0 89 45 F4E9" + Class11.smethod_46(num5, 8, bool_1: false, bool_2: true);
			byte[] array4 = Class11.smethod_8(string_, bool_1: false);
			int num6 = array4.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num3, array4, num6, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num6 + 4);
			if (bool_0)
			{
				uint value = num3 - num2 - 5;
				array4 = BitConverter.GetBytes(value);
				array2 = new byte[6]
				{
					233,
					array4[0],
					array4[1],
					array4[2],
					array4[3],
					144
				};
			}
			else
			{
				array2 = Class11.smethod_8(text + Class11.smethod_46(num, 8, bool_1: false, bool_2: true));
			}
			if (num != 0 && ((!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233)))
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array2, array2.Length, ref int_);
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_32(CharacterAccountConfig characterAccountConfig_0, uint uint_13, uint uint_14, bool bool_0 = true)
	{
		if (characterAccountConfig_0.uint_21 != 0 && uint_13 != 0)
		{
			int int_ = 0;
			byte[] array = Class11.smethod_8("7D 19 8B 45 F4");
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_7 + uint_13;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			byte[] array3 = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + 7, array3, 4, ref int_);
			if (BitConverter.ToInt32(array3, 0) == uint_14)
			{
				characterAccountConfig_0.uint_22 += 16u;
				uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
				uint num3 = num - (num2 + 74) + 25;
				uint num4 = num - (num2 + 85) + 27;
				string string_ = "7D 4E 8B 45 F4 3D 00 00 01 00 7E 3E 3D 00 10 FE 7F 7D 378B 88" + Class11.smethod_46(uint_14, 8, bool_1: false, bool_2: true) + "81 F9 00 00 01 00 7E 29 81 F9 00 10 FE 7F 7D 21 8B 55 F8 8B 04 91 3D 00 00 01 00 7E 14 3D 00 10 FE 7F 7D 0D 8B 4D FC 03 08 89 4D FCE9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "E9" + Class11.smethod_46(num4, 8, bool_1: false, bool_2: true);
				byte[] array4 = Class11.smethod_8(string_, bool_1: false);
				int num5 = array4.Length;
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array4, num5, ref int_);
				characterAccountConfig_0.uint_22 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num2 - num - 5;
					array4 = BitConverter.GetBytes(value);
					array = new byte[5]
					{
						233,
						array4[0],
						array4[1],
						array4[2],
						array4[3]
					};
				}
				if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
				{
					Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
				}
				return characterAccountConfig_0.uint_22;
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_33(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		if (characterAccountConfig_0.uint_21 != 0)
		{
			uint[] array = new uint[2] { 5664480u, 5675472u };
			int int_ = 0;
			int i = 0;
			string text = "A1" + Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0, 8, bool_1: false, bool_2: true);
			string text2 = "8B 15" + Class11.smethod_46(Class56.memorySignatureScanConfig_14.uint_0, 8, bool_1: false, bool_2: true);
			for (; array.Length > i; i++)
			{
				characterAccountConfig_0.uint_22 += 16u;
				byte[] array2 = Class11.smethod_8(text);
				byte[] array3 = new byte[array2.Length];
				uint num = characterAccountConfig_0.uint_7 + (array[i] - 4194304);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array3, array3.Length, ref int_);
				if (array3[0] != 233)
				{
					int num2 = 0;
					while (num2 < array3.Length)
					{
						if (array3[num2] == array2[num2])
						{
							num2++;
							continue;
						}
						goto IL_0220;
					}
				}
				uint num3 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
				uint num4 = num - (num3 + 46) + 11;
				string string_ = text + "3D 00 00 01 00 7E 22 3D 00 10 FE 7F 7D 1B" + text2 + "81 FA 00 00 01 00 7E 0D 81 FA 00 10 FE 7F 7D 05E9" + Class11.smethod_46(num4, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "C2 04 00";
				byte[] array4 = Class11.smethod_8(string_, bool_1: false);
				int num5 = array4.Length;
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num3, array4, num5, ref int_);
				characterAccountConfig_0.uint_22 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num - 5;
					array4 = BitConverter.GetBytes(value);
					array2 = new byte[5]
					{
						233,
						array4[0],
						array4[1],
						array4[2],
						array4[3]
					};
				}
				if ((!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233))
				{
					Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
				}
				IL_0220:;
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_34(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		if (characterAccountConfig_0.uint_21 == 0)
		{
			return characterAccountConfig_0.uint_22;
		}
		uint[] array = new uint[2] { 5775311u, 5775344u };
		int int_ = 0;
		for (int i = 0; array.Length > i; i++)
		{
			characterAccountConfig_0.uint_22 += 16u;
			byte[] array2 = Class11.smethod_8("B8 01000000");
			byte[] array3 = new byte[array2.Length];
			uint num = characterAccountConfig_0.uint_7 + (array[i] - 4194304);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array3, array3.Length, ref int_);
			if (array3[0] != 233)
			{
				int num2 = 0;
				while (num2 < array3.Length)
				{
					if (array3[num2] == array2[num2])
					{
						num2++;
						continue;
					}
					goto IL_01d5;
				}
			}
			uint num3 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num4 = num - (num3 + 23) + 5;
			string string_ = "33 C0 40 81 F9 00 00 01 00 7E 0C 81 F9 00 10 FE 7F0F 8C" + Class11.smethod_46(num4, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "33 C0 C3";
			byte[] array4 = Class11.smethod_8(string_, bool_1: false);
			int num5 = array4.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num3, array4, num5, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num5 + 4);
			if (bool_0)
			{
				uint value = num3 - num - 5;
				array4 = BitConverter.GetBytes(value);
				array2 = new byte[5]
				{
					233,
					array4[0],
					array4[1],
					array4[2],
					array4[3]
				};
			}
			if ((!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233))
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			}
			IL_01d5:;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_35(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		if (characterAccountConfig_0.uint_21 == 0)
		{
			return characterAccountConfig_0.uint_22;
		}
		int int_ = 0;
		byte[] array = Class11.smethod_8("8B 48 08 89 4C 24 10");
		byte[] array2 = new byte[array.Length];
		uint num = characterAccountConfig_0.uint_7 + 1479774;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
		if (array2[0] != 233)
		{
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] != array[i])
				{
					return characterAccountConfig_0.uint_22;
				}
			}
		}
		characterAccountConfig_0.uint_22 += 16u;
		uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
		uint num3 = num - (num2 + 26) + 7;
		uint num4 = num - (num2 + 37) + 31;
		string string_ = "3D 00 00 01 00 7E 13 3D 00 10 FE 7F 7D 0C 8B 48 08 89 4C 24 10E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "E9" + Class11.smethod_46(num4, 8, bool_1: false, bool_2: true);
		byte[] array3 = Class11.smethod_8(string_, bool_1: false);
		int num5 = array3.Length;
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num5, ref int_);
		characterAccountConfig_0.uint_22 += (uint)(num5 + 4);
		if (bool_0)
		{
			uint value = num2 - num - 5;
			array3 = BitConverter.GetBytes(value);
			byte[] array4 = new byte[7] { 233, 0, 0, 0, 0, 144, 144 };
			array4[1] = array3[0];
			array4[2] = array3[1];
			array4[3] = array3[2];
			array4[4] = array3[3];
			array = array4;
		}
		if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
		{
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_36(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		if (characterAccountConfig_0.uint_21 != 0)
		{
			uint[] array = new uint[4] { 5722133u, 5985340u, 6196267u, 6197195u };
			int int_ = 0;
			for (int i = 0; array.Length > i; i++)
			{
				characterAccountConfig_0.uint_22 += 16u;
				byte[] array2 = Class11.smethod_8("8B 07 8B 10 6A 01");
				byte[] array3 = new byte[array2.Length];
				uint num = characterAccountConfig_0.uint_7 + (array[i] - 4194304);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array3, array3.Length, ref int_);
				if (array3[0] != 233)
				{
					int num2 = 0;
					while (num2 < array3.Length)
					{
						if (array3[num2] == array2[num2])
						{
							num2++;
							continue;
						}
						goto IL_01ec;
					}
				}
				uint num3 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
				uint num4 = num - (num3 + 57) + 6;
				uint num5 = num - (num3 + 70) + 10;
				string string_ = "81 FF 00 00 01 00 7E 31 81 FF 00 10 FE 7F 7D 29 8B 07 3D 00 00 01 00 7E 20 3D 00 10 FE 7F 7D 19 8B 10 81 FA 00 00 01 00 7E 0F 81 FA 00 10 FE 7F 7D 07 6A 01E9" + Class11.smethod_46(num4, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "33 DBE9" + Class11.smethod_46(num5, 8, bool_1: false, bool_2: true);
				byte[] array4 = Class11.smethod_8(string_, bool_1: false);
				int num6 = array4.Length;
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num3, array4, num6, ref int_);
				characterAccountConfig_0.uint_22 += (uint)(num6 + 4);
				if (bool_0)
				{
					uint value = num3 - num - 5;
					array4 = BitConverter.GetBytes(value);
					array2 = new byte[6]
					{
						233,
						array4[0],
						array4[1],
						array4[2],
						array4[3],
						144
					};
				}
				if ((!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233))
				{
					Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
				}
				IL_01ec:;
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_37(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		if (characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			byte[] array = Class11.smethod_8("8B 45 08 8B 0C 98");
			byte[] array2 = new byte[array.Length];
			uint num = characterAccountConfig_0.uint_7 + 2086671;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			if (array2[0] != 233)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != array[i])
					{
						return characterAccountConfig_0.uint_22;
					}
				}
			}
			characterAccountConfig_0.uint_22 += 16u;
			uint num2 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
			uint num3 = num - (num2 + 41) + 6;
			string string_ = "8B 45 08 3D 00 00 01 00 7E 1F 3D 00 10 FE 7F 7D 18 8B 0C 98 81 F9 00 00 01 00 7E 0D 81 F9 00 10 FE 7F 7D 05E9" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "59 5F 5E 5B 8B E5 5D C2 20 00";
			byte[] array3 = Class11.smethod_8(string_, bool_1: false);
			int num4 = array3.Length;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array3, num4, ref int_);
			characterAccountConfig_0.uint_22 += (uint)(num4 + 4);
			if (bool_0)
			{
				uint value = num2 - num - 5;
				array3 = BitConverter.GetBytes(value);
				array = new byte[6]
				{
					233,
					array3[0],
					array3[1],
					array3[2],
					array3[3],
					144
				};
			}
			if ((!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233))
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	private static uint smethod_38(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		if (characterAccountConfig_0.uint_21 != 0)
		{
			uint[] array = new uint[2] { 4392027u, 4419851u };
			for (int i = 0; array.Length > i; i++)
			{
				uint num = array[i];
				int int_ = 0;
				byte[] array2 = Class11.smethod_8("8B 0C 88 8B 55 F8");
				byte[] array3 = new byte[array2.Length];
				uint num2 = characterAccountConfig_0.uint_7 + (num - 4194304);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2, array3, array3.Length, ref int_);
				if (array3[0] != 233)
				{
					int num3 = 0;
					while (num3 < array3.Length)
					{
						if (array3[num3] == array2[num3])
						{
							num3++;
							continue;
						}
						goto IL_01d5;
					}
				}
				characterAccountConfig_0.uint_22 += 16u;
				uint num4 = characterAccountConfig_0.uint_21 + characterAccountConfig_0.uint_22;
				uint num5 = num2 - (num4 + 57) + 6;
				string string_ = "3D 00 00 01 00 7E 32 3D 00 10 FE 7F 7D 2B 8B 0C 88 81 F9 00 00 01 00 7E 20 81 F9 00 10 FE 7F 7D 18 8B 55 F8 81 FA 00 00 01 00 7E 0D 81 FA 00 10 FE 7F 7D 05E9" + Class11.smethod_46(num5, 8, bool_1: false, bool_2: true) + "FF 05" + Class11.smethod_46(characterAccountConfig_0.uint_21 + uint_0, 8, bool_1: false, bool_2: true) + "8B E5 5D C2 04 00";
				byte[] array4 = Class11.smethod_8(string_, bool_1: false);
				int num6 = array4.Length;
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4, array4, num6, ref int_);
				characterAccountConfig_0.uint_22 += (uint)(num6 + 4);
				if (bool_0)
				{
					uint value = num4 - num2 - 5;
					array4 = BitConverter.GetBytes(value);
					array2 = new byte[6]
					{
						233,
						array4[0],
						array4[1],
						array4[2],
						array4[3],
						144
					};
				}
				if ((!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233))
				{
					Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array2, array2.Length, ref int_);
				}
				IL_01d5:;
			}
			return characterAccountConfig_0.uint_22;
		}
		return characterAccountConfig_0.uint_22;
	}

	public static void smethod_39()
	{
		int num = int_1;
		int_1 = 0;
		if (num > 0)
		{
			int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, num);
			if (0 <= num2)
			{
				smethod_44(Form1.characterAccountConfig_1[num2]);
			}
		}
	}

	private static uint smethod_40(CharacterAccountConfig characterAccountConfig_0, string string_0 = "lualibdll.dll")
	{
		uint result = 0u;
		try
		{
			string fileName = characterAccountConfig_0.process_0.MainModule.FileName;
			string string_1 = Class11.smethod_14(fileName)[0] + "\\" + string_0;
			string string_2 = Class11.smethod_7(string_1);
			result = Class11.smethod_6(string_2);
		}
		catch
		{
		}
		return result;
	}

	private static MemorySignatureScanConfig[] smethod_41()
	{
		return new MemorySignatureScanConfig[13]
		{
			memorySignatureScanConfig_3, memorySignatureScanConfig_4, memorySignatureScanConfig_5, memorySignatureScanConfig_6, memorySignatureScanConfig_7, memorySignatureScanConfig_8, memorySignatureScanConfig_9, memorySignatureScanConfig_10, memorySignatureScanConfig_11, memorySignatureScanConfig_12,
			memorySignatureScanConfig_13, memorySignatureScanConfig_14, memorySignatureScanConfig_15
		};
	}

	private static MemorySignatureScanConfig[] smethod_42()
	{
		return new MemorySignatureScanConfig[1] { memorySignatureScanConfig_1 };
	}

	private static MemorySignatureScanConfig[] smethod_43()
	{
		return new MemorySignatureScanConfig[1] { memorySignatureScanConfig_2 };
	}

	public static uint smethod_44(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_21 != 0)
		{
			int int_ = 0;
			if (characterAccountConfig_0.uint_7 == 0)
			{
				characterAccountConfig_0.uint_7 = 4194304u;
			}
			if (characterAccountConfig_0.uint_8 == 0)
			{
				characterAccountConfig_0.uint_8 = Class24.smethod_37(characterAccountConfig_0.int_136, "engine.dll");
			}
			if (characterAccountConfig_0.uint_9 == 0)
			{
				characterAccountConfig_0.uint_9 = Class24.smethod_37(characterAccountConfig_0.int_136, "lualibdll.dll");
			}
			if (characterAccountConfig_0.uint_10 == 0)
			{
				characterAccountConfig_0.uint_10 = Class24.smethod_37(characterAccountConfig_0.int_136, "rainbow.dll");
			}
			if (characterAccountConfig_0.uint_12 == 0)
			{
				uint num = Class24.smethod_37(characterAccountConfig_0.int_136, "kernel32.dll");
				characterAccountConfig_0.uint_12 = Class24.GetProcAddress(num, "ReadProcessMemory");
			}
			if (characterAccountConfig_0.uint_13 == 0)
			{
				uint num2 = Class24.smethod_37(characterAccountConfig_0.int_136, "ntdll.dll");
				characterAccountConfig_0.uint_13 = Class24.GetProcAddress(num2, "ZwReadVirtualMemory");
			}
			uint[] array = null;
			byte[] array2 = null;
			int num3 = 0;
			int num4 = 0;
			uint num5 = 0u;
			while (true)
			{
				bool flag = true;
				if (uint_10 != 0 || num4 > 0)
				{
					if (num5 == 0)
					{
						num5 = smethod_40(characterAccountConfig_0);
					}
					bool flag2 = true;
					MemorySignatureScanConfig[] array3 = smethod_41();
					for (int i = 0; i < array3.Length; i++)
					{
						if (array3[i].uint_0 == 0)
						{
							flag2 = false;
							break;
						}
					}
					if (flag2)
					{
						flag = uint_10 != num5 && num4 <= 0;
					}
				}
				if (!flag || num4 > 1)
				{
					break;
				}
				if (int_2 > 0 && num3 < 10)
				{
					num3++;
					Thread.Sleep(random_0.Next(10, 200) + 100);
					continue;
				}
				int_2 = 1;
				array = Class24.smethod_66(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_9, ".text");
				array2 = new byte[array[0]];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_9 + array[1], array2, array2.Length, ref int_);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_3, 0L, 0u, 0, bool_0: true);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_4, 0L, 0u, 0, bool_0: true);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_5, 0L, 0u, 0, bool_0: true);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_6, 0L, 0u, 0, bool_0: true);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_7, 0L, 0u, 0, bool_0: true);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_8, 0L, 0u, 0, bool_0: true);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_9, 0L, 0u, 0, bool_0: true);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_10, 0L, 0u, 0, bool_0: true);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_11, 0L, 0u, 0, bool_0: true);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_12, 0L, 0u, 0, bool_0: true);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_13, 0L, 0u, 0, bool_0: true);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_14, 0L, 0u, 0, bool_0: true);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_15, 0L, 0u, 0, bool_0: true);
				Thread.Sleep(300);
				int_2 = 0;
				num4++;
			}
			if (num4 == 1)
			{
				uint_10 = num5;
			}
			num3 = 0;
			num4 = 0;
			num5 = 0u;
			while (true)
			{
				bool flag3 = true;
				if (uint_11 != 0 || num4 > 0)
				{
					if (num5 == 0)
					{
						num5 = smethod_40(characterAccountConfig_0, "rainbow.dll");
					}
					bool flag4 = true;
					MemorySignatureScanConfig[] array4 = smethod_42();
					for (int j = 0; j < array4.Length; j++)
					{
						if (array4[j].uint_0 == 0)
						{
							flag4 = false;
							break;
						}
					}
					if (flag4)
					{
						flag3 = uint_11 != num5 && num4 <= 0;
					}
				}
				if (!flag3 || num4 > 1)
				{
					break;
				}
				if (int_3 > 0 && num3 < 10)
				{
					num3++;
					Thread.Sleep(random_0.Next(10, 200) + 100);
					continue;
				}
				int_3 = 1;
				array = Class24.smethod_66(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_10, ".text");
				array2 = new byte[array[0]];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_10 + array[1], array2, array2.Length, ref int_);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_1, 0L, 0u, 0, bool_0: true);
				Thread.Sleep(200);
				int_3 = 0;
				num4++;
			}
			if (num4 == 1)
			{
				uint_11 = num5;
			}
			num3 = 0;
			num4 = 0;
			num5 = 0u;
			while (true)
			{
				bool flag5 = true;
				if (uint_12 != 0 || num4 > 0)
				{
					if (num5 == 0)
					{
						num5 = smethod_40(characterAccountConfig_0, "msvcr80.dll");
					}
					bool flag6 = true;
					MemorySignatureScanConfig[] array5 = smethod_43();
					for (int k = 0; k < array5.Length; k++)
					{
						if (array5[k].uint_0 == 0)
						{
							flag6 = false;
							break;
						}
					}
					if (flag6)
					{
						flag5 = uint_12 != num5 && num4 <= 0;
					}
				}
				if (!flag5 || num4 > 1)
				{
					break;
				}
				if (int_4 > 0 && num3 < 10)
				{
					num3++;
					Thread.Sleep(random_0.Next(10, 200) + 100);
					continue;
				}
				int_4 = 1;
				array = Class24.smethod_66(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_11, ".text");
				array2 = new byte[array[0]];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_11 + array[1], array2, array2.Length, ref int_);
				Class7.smethod_4(array[1], array2, ref memorySignatureScanConfig_2, 0L, 0u, 0, bool_0: true);
				Thread.Sleep(100);
				int_4 = 0;
				num4++;
			}
			if (num4 == 1)
			{
				uint_12 = num5;
			}
			characterAccountConfig_0.uint_22 = 32u;
			bool bool_ = int_0 > 0;
			byte[] bytes = BitConverter.GetBytes(characterAccountConfig_0.uint_12);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_21 + 4, bytes, 4, ref int_);
			bytes = BitConverter.GetBytes(characterAccountConfig_0.uint_13);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_21 + 8, bytes, 4, ref int_);
			smethod_0(characterAccountConfig_0);
			characterAccountConfig_0.uint_22 = smethod_1(characterAccountConfig_0, memorySignatureScanConfig_2);
			characterAccountConfig_0.uint_22 = smethod_2(characterAccountConfig_0, memorySignatureScanConfig_0);
			characterAccountConfig_0.uint_22 = smethod_3(characterAccountConfig_0, memorySignatureScanConfig_1);
			characterAccountConfig_0.uint_22 = smethod_4(characterAccountConfig_0, memorySignatureScanConfig_3, bool_0: true);
			characterAccountConfig_0.uint_22 = smethod_5(characterAccountConfig_0, memorySignatureScanConfig_4, bool_0: true);
			characterAccountConfig_0.uint_22 = smethod_6(characterAccountConfig_0, memorySignatureScanConfig_5, bool_0: true);
			characterAccountConfig_0.uint_22 = smethod_7(characterAccountConfig_0, memorySignatureScanConfig_6, bool_0: true);
			characterAccountConfig_0.uint_22 = smethod_8(characterAccountConfig_0, memorySignatureScanConfig_7, bool_0: true);
			characterAccountConfig_0.uint_22 = smethod_9(characterAccountConfig_0, memorySignatureScanConfig_8, bool_0: true);
			characterAccountConfig_0.uint_22 = smethod_10(characterAccountConfig_0, memorySignatureScanConfig_9, bool_0: true);
			characterAccountConfig_0.uint_22 = smethod_11(characterAccountConfig_0, memorySignatureScanConfig_10, bool_0: true);
			smethod_12(characterAccountConfig_0, memorySignatureScanConfig_11, bool_0: true);
			characterAccountConfig_0.uint_22 = smethod_13(characterAccountConfig_0, memorySignatureScanConfig_12, bool_0: true);
			characterAccountConfig_0.uint_22 = smethod_14(characterAccountConfig_0, memorySignatureScanConfig_13, bool_0: true);
			characterAccountConfig_0.uint_22 = smethod_15(characterAccountConfig_0, memorySignatureScanConfig_14, bool_0: true);
			characterAccountConfig_0.uint_22 = smethod_16(characterAccountConfig_0, memorySignatureScanConfig_15, bool_0: true);
			characterAccountConfig_0.uint_22 = smethod_18(characterAccountConfig_0, memorySignatureScanConfig_18, bool_);
			characterAccountConfig_0.uint_22 = smethod_19(characterAccountConfig_0, memorySignatureScanConfig_19, bool_);
			for (int l = 0; l < uint_2.GetLength(0); l++)
			{
				characterAccountConfig_0.uint_22 = smethod_20(characterAccountConfig_0, uint_2[l] - 4194304, bool_);
			}
			characterAccountConfig_0.uint_22 = smethod_21(characterAccountConfig_0, memorySignatureScanConfig_21, bool_);
			characterAccountConfig_0.uint_22 = smethod_22(characterAccountConfig_0, memorySignatureScanConfig_22, bool_);
			for (int m = 0; m < uint_3.GetLength(0); m++)
			{
				characterAccountConfig_0.uint_22 = smethod_23(characterAccountConfig_0, uint_3[m] - 4194304, bool_);
			}
			characterAccountConfig_0.uint_22 = smethod_28(characterAccountConfig_0, memorySignatureScanConfig_27, bool_);
			for (int n = 0; n < uint_4.GetLength(0); n++)
			{
				characterAccountConfig_0.uint_22 = smethod_24(characterAccountConfig_0, uint_4[n] - 4194304, bool_);
			}
			for (int num6 = 0; num6 < uint_5.GetLength(0); num6++)
			{
				characterAccountConfig_0.uint_22 = smethod_25(characterAccountConfig_0, uint_5[num6] - 4194304, bool_);
			}
			characterAccountConfig_0.uint_22 = smethod_26(characterAccountConfig_0, bool_);
			characterAccountConfig_0.uint_22 = smethod_29(characterAccountConfig_0, uint_6 - 4194304, bool_);
			for (int num7 = 0; num7 < uint_7.Length; num7++)
			{
				characterAccountConfig_0.uint_22 = smethod_30(characterAccountConfig_0, uint_7[num7] - 4194304, bool_);
			}
			for (int num8 = 0; num8 < uint_8.Length; num8++)
			{
				characterAccountConfig_0.uint_22 = smethod_31(characterAccountConfig_0, uint_8[num8] - 4194304, bool_);
			}
			for (int num9 = 0; num9 < uint_9.GetLength(0); num9++)
			{
				characterAccountConfig_0.uint_22 = smethod_32(characterAccountConfig_0, uint_9[num9, 0] - 4194304, uint_9[num9, 1], bool_);
			}
			characterAccountConfig_0.uint_22 = smethod_17(characterAccountConfig_0, memorySignatureScanConfig_25.uint_0, 8, bool_);
			characterAccountConfig_0.uint_22 = smethod_17(characterAccountConfig_0, memorySignatureScanConfig_26.uint_0, 8, bool_);
			characterAccountConfig_0.uint_22 = smethod_17(characterAccountConfig_0, memorySignatureScanConfig_16.uint_0, 12, bool_);
			characterAccountConfig_0.uint_22 = smethod_17(characterAccountConfig_0, memorySignatureScanConfig_17.uint_0, 12, bool_);
			for (int num10 = 0; num10 < uint_1.GetLength(0); num10++)
			{
				characterAccountConfig_0.uint_22 = smethod_27(characterAccountConfig_0, uint_1[num10, 0] - 4194304, (byte)uint_1[num10, 1], bool_);
			}
			characterAccountConfig_0.uint_22 = smethod_33(characterAccountConfig_0, bool_);
			characterAccountConfig_0.uint_22 = smethod_34(characterAccountConfig_0, bool_);
			characterAccountConfig_0.uint_22 = smethod_35(characterAccountConfig_0, bool_);
			characterAccountConfig_0.uint_22 = smethod_36(characterAccountConfig_0, bool_);
			characterAccountConfig_0.uint_22 = smethod_37(characterAccountConfig_0, bool_);
			characterAccountConfig_0.uint_22 = smethod_38(characterAccountConfig_0, bool_);
			return 1u;
		}
		return 1u;
	}
}
