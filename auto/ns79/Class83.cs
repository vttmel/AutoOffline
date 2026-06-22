using System;
using ns1;
using ns10;
using ns11;
using ns23;
using ns53;
using ns71;

namespace ns79;

internal class Class83
{
	public static int[,] int_0;

	public static uint uint_0;

	public static uint uint_1;

	public static uint uint_2;

	public static GStruct57[] gstruct57_0;

	public static GStruct58[] gstruct58_0;

	private static int[,] int_1;

	private static int[,] int_2;

	static Class83()
	{
		int_0 = null;
		uint_0 = 4u;
		uint_1 = 72u;
		uint_2 = 172u;
		gstruct57_0 = new GStruct57[11]
		{
			new GStruct57
			{
				int_0 = 1,
				string_0 = "THIEULAM",
				int_1 = new int[8] { 1, 2, 3, 4, 5, 6, 62, 72 }
			},
			new GStruct57
			{
				int_0 = 2,
				string_0 = "VODANG",
				int_1 = new int[8] { 7, 8, 9, 10, 11, 12, 63, 73 }
			},
			new GStruct57
			{
				int_0 = 3,
				string_0 = "NGAMY",
				int_1 = new int[8] { 13, 14, 15, 16, 17, 18, 64, 74 }
			},
			new GStruct57
			{
				int_0 = 4,
				string_0 = "CONLON",
				int_1 = new int[8] { 19, 20, 21, 22, 23, 24, 65, 75 }
			},
			new GStruct57
			{
				int_0 = 5,
				string_0 = "DUONGMON",
				int_1 = new int[8] { 25, 26, 27, 28, 29, 30, 66, 76 }
			},
			new GStruct57
			{
				int_0 = 6,
				string_0 = "THUYYEN",
				int_1 = new int[8] { 31, 32, 33, 34, 35, 36, 67, 77 }
			},
			new GStruct57
			{
				int_0 = 7,
				string_0 = "CAIBANG",
				int_1 = new int[8] { 37, 38, 39, 40, 41, 42, 68, 78 }
			},
			new GStruct57
			{
				int_0 = 8,
				string_0 = "THIENVUONG",
				int_1 = new int[8] { 43, 44, 45, 46, 47, 48, 69, 79 }
			},
			new GStruct57
			{
				int_0 = 9,
				string_0 = "NGUDOC",
				int_1 = new int[8] { 49, 50, 51, 52, 53, 54, 70, 80 }
			},
			new GStruct57
			{
				int_0 = 10,
				string_0 = "THIENNHAN",
				int_1 = new int[8] { 55, 56, 57, 58, 59, 60, 71, 81 }
			},
			new GStruct57
			{
				int_0 = 11,
				string_0 = "HOASON",
				int_1 = new int[8] { 82, 83, 84, 85, 86, 87, 88, 89 }
			}
		};
		gstruct58_0 = new GStruct58[11]
		{
			new GStruct58
			{
				int_1 = 10,
				string_0 = "THIEULAM",
				string_1 = "ThiÕu L©m"
			},
			new GStruct58
			{
				int_1 = 29,
				string_0 = "THIENVUONG",
				string_1 = "Thiªn V\u00ad¬ng"
			},
			new GStruct58
			{
				int_1 = 45,
				string_0 = "DUONGMON",
				string_1 = "§\u00adêng M«n"
			},
			new GStruct58
			{
				int_1 = 63,
				string_0 = "NGUDOC",
				string_1 = "Ngò §éc"
			},
			new GStruct58
			{
				int_1 = 80,
				string_0 = "NGAMY",
				string_1 = "Nga My"
			},
			new GStruct58
			{
				int_1 = 99,
				string_0 = "THUYYEN",
				string_1 = "Thóy Yªn"
			},
			new GStruct58
			{
				int_1 = 1347,
				string_0 = "HOASON",
				string_1 = "Hoa S¬n"
			},
			new GStruct58
			{
				int_1 = 122,
				string_0 = "CAIBANG",
				string_1 = "C\u00b8i Bang"
			},
			new GStruct58
			{
				int_1 = 135,
				string_0 = "THIENNHAN",
				string_1 = "Thiªn NhÉn"
			},
			new GStruct58
			{
				int_1 = 153,
				string_0 = "VODANG",
				string_1 = "Vâ §ang"
			},
			new GStruct58
			{
				int_1 = 169,
				string_0 = "CONLON",
				string_1 = "C«n L«n"
			}
		};
		int[,] array_ = new int[34, 2];
		Class10.smethod_4(array_, 348707);
		int_1 = array_;
		int_2 = new int[1, 2] { { 67, 174 } };
	}

	public static int smethod_0(int int_3)
	{
		int num = 0;
		if (1 <= int_3 && int_3 <= 60)
		{
			num = int_3 / 6;
			if (int_3 % 6 > 0)
			{
				num++;
			}
		}
		else if (62 <= int_3 && int_3 <= 71)
		{
			num = int_3 - 61;
		}
		else if (72 <= int_3 && int_3 <= 81)
		{
			num = int_3 - 71;
		}
		else if (82 <= int_3 && int_3 <= 89)
		{
			num = 11;
		}
		return num;
	}

	public static string smethod_1(int int_3)
	{
		string result = string.Empty;
		int num = smethod_0(int_3);
		if (num > 0)
		{
			result = gstruct57_0[num - 1].string_0;
		}
		return result;
	}

    public static int[] smethod_2(CharacterAccountConfig characterAccountConfig_0)
    {
        string text = smethod_18(characterAccountConfig_0);

        if (string.IsNullOrEmpty(text)) return null;

        switch (text.ToUpper()) // Thêm ToUpper để tránh lỗi chữ hoa chữ thường
        {
            case "CONLON":
                return new int[] { 173, 171 };
            case "THIENVUONG":
                return new int[] { 42, 33 };
            case "HOASON":
                return new int[] { 1358 };
            case "VODANG":
                return new int[] { 157 };
            case "THIEULAM":
                return new int[] { 15, 273 };
            case "THUYYEN":
                return new int[] { 109, 100 };
            case "CAIBANG":
                return new int[] { 130, 277 };
            case "THIENNHAN":
                return new int[] { 150 };
            default:
                return null;
        }
    }
    

    public static int smethod_3(int int_3)
	{
		int num = 0;
		while (true)
		{
			if (num < int_1.GetLength(0))
			{
				if (int_3 == int_1[num, 0])
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return int_1[num, 1];
	}

	public static uint[] smethod_4(CharacterAccountConfig characterAccountConfig_0)
	{
		return smethod_18(characterAccountConfig_0) switch
		{
			"THIEULAM" => new uint[1] { 14u }, 
			"CAIBANG" => new uint[2] { 122u, 128u }, 
			"VODANG" => new uint[2] { 153u, 164u }, 
			"CONLON" => new uint[1] { 179u }, 
			"THUYYEN" => new uint[1] { 102u }, 
			"THIENNHAN" => new uint[2] { 145u, 138u }, 
			_ => null, 
		};
	}

	public static bool smethod_5(CharacterAccountConfig characterAccountConfig_0, int int_3, byte byte_0, byte byte_1 = 1)
	{
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_160.uint_0 != 0)
		{
			if (byte_0 >= 2)
			{
				if (byte_0 > 10)
				{
					byte_0 = 10;
				}
			}
			else
			{
				byte_0 = 2;
			}
			byte_0 -= 2;
			int int_4 = 0;
			byte[] bytes = BitConverter.GetBytes(int_3);
			byte[] byte_2 = new byte[4] { 4, 0, 4, 0 };
			byte[] byte_3 = new byte[4] { 1, 0, 0, 0 };
			uint num = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_160.uint_0;
			uint num2 = num + (uint)(byte_0 * 16);
			bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, byte_2, 4, ref int_4);
			bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2 + 4, bytes, 4, ref int_4);
			bool flag3 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2 + 8, byte_3, 4, ref int_4);
			return flag && flag2 && flag3;
		}
		return false;
	}

	public static uint[] smethod_6(CharacterAccountConfig characterAccountConfig_0, string string_0)
	{
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_92.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[string_0.Length + 3];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_92.uint_0 + 16, array, 4, ref int_);
			int num = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_92.uint_0, array, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array, 0);
			for (uint num3 = 0u; num > num3; num3++)
			{
				uint num4 = num2 + num3 * Class56.memorySignatureScanConfig_91.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4, array, 4, ref int_);
				uint num5 = BitConverter.ToUInt32(array, 0);
				if (num5 != 0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_93.uint_0, array2, array2.Length, ref int_);
					string text = Class1.smethod_3(array2);
					if (string_0 == text)
					{
						return new uint[2] { num3, num5 };
					}
				}
			}
			return null;
		}
		return null;
	}

	public static uint smethod_7(CharacterAccountConfig characterAccountConfig_0, uint uint_3)
	{
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_92.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_92.uint_0, array, 4, ref int_);
			uint num = BitConverter.ToUInt32(array, 0);
			uint uint_4 = num + uint_3 * Class56.memorySignatureScanConfig_91.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_4, array, 4, ref int_);
			return BitConverter.ToUInt32(array, 0);
		}
		return 0u;
	}

	public static string smethod_8(CharacterAccountConfig characterAccountConfig_0, uint uint_3)
	{
		string result = string.Empty;
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_92.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[80];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_92.uint_0, array, 4, ref int_);
			uint num = BitConverter.ToUInt32(array, 0);
			uint num2 = num + uint_3 * Class56.memorySignatureScanConfig_91.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2, array, 4, ref int_);
			if (BitConverter.ToUInt32(array, 0) != 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_93.uint_0, array2, array2.Length, ref int_);
				result = Class1.smethod_3(array2);
			}
			return result;
		}
		return result;
	}

	public static void smethod_9(CharacterAccountConfig characterAccountConfig_0, string string_0 = null)
	{
		int num = Class75.smethod_3(characterAccountConfig_0, Class75.uint_36, 4);
		if (num > 0 && smethod_7(characterAccountConfig_0, (uint)num) == 0)
		{
			num = 0;
		}
		if (num > 0)
		{
			return;
		}
		Class75.smethod_2(characterAccountConfig_0, Class75.uint_36, 0, 4);
		Class75.smethod_2(characterAccountConfig_0, Class75.uint_36 + 4, 0, 4);
		if (string_0 == null)
		{
			string_0 = "DirectShortcutSkill(4)";
		}
		uint[] array = smethod_6(characterAccountConfig_0, string_0);
		if (array == null)
		{
			int num2 = Class75.smethod_3(characterAccountConfig_0, Class75.uint_36 + 8, 4);
			int second = DateTime.Now.Second;
			if (Math.Abs(second - num2) > 15)
			{
				Class75.smethod_14(characterAccountConfig_0, bool_0: true);
				Class75.smethod_2(characterAccountConfig_0, Class75.uint_36 + 8, second, 4);
			}
		}
		else
		{
			Class75.smethod_2(characterAccountConfig_0, Class75.uint_36, (int)array[0], 4);
			Class75.smethod_2(characterAccountConfig_0, Class75.uint_36 + 4, (int)array[1], 4);
		}
	}

	public static int smethod_10(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_71.uint_0, characterAccountConfig_0.int_137);
	}

	public static bool smethod_11(GStruct58[] gstruct58_1, int int_3)
	{
		if (gstruct58_1 != null)
		{
			for (int i = 0; i < gstruct58_1.Length; i++)
			{
				if (gstruct58_1[i].int_1 == int_3)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static int smethod_12(GStruct58[] gstruct58_1, string string_0)
	{
		if (gstruct58_1 != null)
		{
			for (int i = 0; i < gstruct58_1.Length; i++)
			{
				if (string_0 == gstruct58_1[i].string_0)
				{
					return gstruct58_1[i].int_1;
				}
			}
		}
		return 0;
	}

	public static int smethod_13(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_68.uint_0, characterAccountConfig_0.int_137);
	}

	public static int smethod_14(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_70.uint_0, characterAccountConfig_0.int_137);
	}

	public static void smethod_15(CharacterAccountConfig characterAccountConfig_0, uint uint_3 = 0u, bool bool_0 = false)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint uint_4;
		if (uint_3 == 0)
		{
			uint_4 = (bool_0 ? (num + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_70.uint_0) : (num + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_68.uint_0));
			uint_3 = Class24.smethod_30(uint_4, characterAccountConfig_0.int_137);
		}
		uint_4 = num2 + num3 + Class56.memorySignatureScanConfig_161.uint_0 - (uint)(4 * (1 + Convert.ToByte(!bool_0)));
		Class24.smethod_31(uint_4, characterAccountConfig_0.int_137, uint_3);
	}

	public static int smethod_16(CharacterAccountConfig characterAccountConfig_0, int int_3)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num2 + num3 + Class56.memorySignatureScanConfig_161.uint_0;
		num4 += Class56.memorySignatureScanConfig_162.uint_0;
		int num5 = 0;
		while (true)
		{
			if (num5 < 80)
			{
				num5++;
				uint num6 = Class24.smethod_30(num4, characterAccountConfig_0.int_137);
				if (num6 == int_3)
				{
					break;
				}
				num4 += Class56.memorySignatureScanConfig_163.uint_0;
				continue;
			}
			return -1;
		}
		return (int)Class24.smethod_30(num4 + 4, characterAccountConfig_0.int_137);
	}

	public static string smethod_17(string string_0)
	{
		if (string_0 != null && string_0 != string.Empty)
		{
			for (int i = 0; i < gstruct58_0.Length; i++)
			{
				if (Class11.smethod_1(string_0, gstruct58_0[i].string_0) != 0 && Class11.smethod_1(gstruct58_0[i].string_0, string_0) != 0)
				{
					if (Class11.smethod_1(string_0, gstruct58_0[i].string_1) == 0 || Class11.smethod_1(gstruct58_0[i].string_1, string_0) == 0)
					{
						return gstruct58_0[i].string_1;
					}
					continue;
				}
				return gstruct58_0[i].string_1;
			}
		}
		return null;
	}

	public static string smethod_18(CharacterAccountConfig characterAccountConfig_0, string string_0 = null)
	{
		if (string_0 != null && string_0 != string.Empty)
		{
			for (int i = 0; i < gstruct58_0.Length; i++)
			{
				if (Class11.smethod_1(string_0, gstruct58_0[i].string_1) != 0 && Class11.smethod_1(gstruct58_0[i].string_1, string_0) != 0)
				{
					if (Class11.smethod_1(string_0, gstruct58_0[i].string_0) == 0 || Class11.smethod_1(gstruct58_0[i].string_0, string_0) == 0)
					{
						return gstruct58_0[i].string_1;
					}
					continue;
				}
				return gstruct58_0[i].string_0;
			}
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num2 + num3 + Class56.memorySignatureScanConfig_161.uint_0;
		num4 += Class56.memorySignatureScanConfig_162.uint_0;
		int num5 = 0;
		while (num5 < 80)
		{
			num5++;
			uint num6 = Class24.smethod_30(num4, characterAccountConfig_0.int_137);
			if (num6 != 0)
			{
				for (int j = 0; j < gstruct58_0.Length; j++)
				{
					if (gstruct58_0[j].int_1 == num6)
					{
						return gstruct58_0[j].string_0;
					}
				}
			}
			num4 += Class56.memorySignatureScanConfig_163.uint_0;
		}
		return string.Empty;
	}

	public static string smethod_19(CharacterAccountConfig characterAccountConfig_0, int int_3, int int_4 = 1, bool bool_0 = false)
	{
		if (Class56.memorySignatureScanConfig_263.uint_0 == 0)
		{
			return string.Empty;
		}
		if (int_4 < 0)
		{
			int_4 = 0;
		}
		int int_5 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		string text = string.Empty;
		uint num = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_263.uint_0;
		uint num2 = (uint)(((int_3 << 6) + int_4) * 4);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + num2 - 4, array, 4, ref int_5);
		uint num3 = BitConverter.ToUInt32(array, 0);
		if (num3 != 0)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + uint_0, array2, array2.Length, ref int_5);
			text = Class1.smethod_3(array2);
		}
		if (text == null || text == string.Empty)
		{
			num2 = (uint)(int_3 << 8);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + num2, array, 4, ref int_5);
			num3 = BitConverter.ToUInt32(array, 0);
			if (num3 != 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + uint_0, array2, array2.Length, ref int_5);
				text = Class1.smethod_3(array2);
			}
		}
		if (bool_0 && text != null && text != string.Empty)
		{
			text = Class1.smethod_1(text, 1);
		}
		return text;
	}

	public static int smethod_20(CharacterAccountConfig characterAccountConfig_0, int int_3, int int_4 = 1)
	{
		if (Class56.memorySignatureScanConfig_263.uint_0 == 0)
		{
			return 0;
		}
		if (int_4 < 0)
		{
			int_4 = 0;
		}
		int int_5 = 0;
		int num = 0;
		byte[] array = new byte[4];
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_263.uint_0;
		uint num3 = (uint)(((int_3 << 6) + int_4) * 4);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + num3 - 4, array, 4, ref int_5);
		uint num4 = BitConverter.ToUInt32(array, 0);
		if (num4 != 0)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + uint_1, array, 4, ref int_5);
			num = BitConverter.ToInt32(array, 0);
		}
		if (num == 0)
		{
			num3 = (uint)(int_3 << 8);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + num3, array, 4, ref int_5);
			num4 = BitConverter.ToUInt32(array, 0);
			if (num4 != 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + uint_1, array, 4, ref int_5);
				num = BitConverter.ToInt32(array, 0);
			}
		}
		return num;
	}

	public static int smethod_21(CharacterAccountConfig characterAccountConfig_0, int int_3)
	{
		if (Class56.memorySignatureScanConfig_263.uint_0 != 0)
		{
			int int_4 = 0;
			int result = 0;
			byte[] array = new byte[4];
			uint num = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_263.uint_0;
			uint num2 = (uint)(int_3 << 8);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + num2, array, 4, ref int_4);
			uint num3 = BitConverter.ToUInt32(array, 0);
			if (num3 != 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + uint_2, array, 1, ref int_4);
				result = array[0];
			}
			return result;
		}
		return 0;
	}

	public static GStruct58[] smethod_22(CharacterAccountConfig characterAccountConfig_0, int int_3 = -1)
	{
		int int_4 = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_4);
		uint num = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_4);
		uint num2 = BitConverter.ToUInt32(array, 0) * Class56.memorySignatureScanConfig_15.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_4);
		uint num3 = BitConverter.ToUInt32(array, 0);
		uint num4 = num2 + num3 + Class56.memorySignatureScanConfig_161.uint_0 + Class56.memorySignatureScanConfig_162.uint_0;
		int num5 = 0;
		GStruct58[] array2 = null;
		while (num5 < 73)
		{
			num5++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4, array, 4, ref int_4);
			int num6 = BitConverter.ToInt32(array, 0);
			if (num6 > 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + 4, array, 4, ref int_4);
				int num7 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + 8, array, 4, ref int_4);
				int num8 = BitConverter.ToInt32(array, 0);
				if (num7 < num8)
				{
					num7 = num8;
				}
				if (int_3 <= num7)
				{
					if (array2 == null)
					{
						array2 = new GStruct58[1];
					}
					else
					{
						Array.Resize(ref array2, array2.Length + 1);
					}
					array2[array2.Length - 1].int_1 = num6;
					array2[array2.Length - 1].int_0 = num5;
					array2[array2.Length - 1].int_2 = num7;
					array2[array2.Length - 1].int_4 = smethod_21(characterAccountConfig_0, num6);
					array2[array2.Length - 1].int_3 = smethod_20(characterAccountConfig_0, num6);
					array2[array2.Length - 1].string_0 = smethod_19(characterAccountConfig_0, num6, num7, bool_0: true);
				}
			}
			num4 += Class56.memorySignatureScanConfig_163.uint_0;
		}
		return array2;
	}

	public static GStruct58[] smethod_23()
	{
		return new GStruct58[955]
		{
			new GStruct58
			{
				int_1 = 1,
				int_3 = 100,
				string_0 = "Công kích vật lý  "
			},
			new GStruct58
			{
				int_1 = 2,
				int_3 = 320,
				string_0 = "Công kích vật lý gần "
			},
			new GStruct58
			{
				int_1 = 3,
				int_3 = 0,
				string_0 = "Thiếu Lâm Kiếm pháp"
			},
			new GStruct58
			{
				int_1 = 4,
				int_3 = 0,
				string_0 = "Thiếu Lâm Côn pháp"
			},
			new GStruct58
			{
				int_1 = 5,
				int_3 = 0,
				string_0 = "Thiếu Lâm thương pháp"
			},
			new GStruct58
			{
				int_1 = 6,
				int_3 = 0,
				string_0 = "Thiếu Lâm Đao pháp"
			},
			new GStruct58
			{
				int_1 = 7,
				int_3 = 0,
				string_0 = "Thiếu Lâm Chùy pháp"
			},
			new GStruct58
			{
				int_1 = 8,
				int_3 = 0,
				string_0 = "Thiếu Lâm Quyền Pháp"
			},
			new GStruct58
			{
				int_1 = 9,
				int_3 = 0,
				string_0 = "Hỗn Nguyên Nhất Khí công"
			},
			new GStruct58
			{
				int_1 = 10,
				int_3 = 90,
				string_0 = "Kim Cang Phục Ma"
			},
			new GStruct58
			{
				int_1 = 11,
				int_3 = 90,
				string_0 = "Hoành Tảo Lục Hợp"
			},
			new GStruct58
			{
				int_1 = 12,
				int_3 = 0,
				string_0 = "Kim Cang Hộ Thể "
			},
			new GStruct58
			{
				int_1 = 13,
				int_3 = 400,
				string_0 = "Lập Địa Thành Phật  "
			},
			new GStruct58
			{
				int_1 = 14,
				int_3 = 90,
				string_0 = "Hàng Long Bất Vũ  "
			},
			new GStruct58
			{
				int_1 = 15,
				int_3 = 400,
				string_0 = "Bất động Minh Vương "
			},
			new GStruct58
			{
				int_1 = 16,
				int_3 = 180,
				string_0 = "La Hán Trận"
			},
			new GStruct58
			{
				int_1 = 17,
				int_3 = 90,
				string_0 = "Long Trảo Hổ Trảo"
			},
			new GStruct58
			{
				int_1 = 18,
				int_3 = 400,
				string_0 = "Huệ Nhãn chú "
			},
			new GStruct58
			{
				int_1 = 19,
				int_3 = 200,
				string_0 = "Ma Ha Vô Lượng"
			},
			new GStruct58
			{
				int_1 = 20,
				int_3 = 90,
				string_0 = "Sư Tử Hống "
			},
			new GStruct58
			{
				int_1 = 21,
				int_3 = 0,
				string_0 = "Dịch Cân kinh"
			},
			new GStruct58
			{
				int_1 = 22,
				int_3 = 0,
				string_0 = "Kim Ba "
			},
			new GStruct58
			{
				int_1 = 23,
				int_3 = 0,
				string_0 = "Thiên Vương  Thương pháp"
			},
			new GStruct58
			{
				int_1 = 24,
				int_3 = 0,
				string_0 = "Thiên Vương  Đao pháp"
			},
			new GStruct58
			{
				int_1 = 25,
				int_3 = 0,
				string_0 = "Thánh Vương Đao pháp"
			},
			new GStruct58
			{
				int_1 = 26,
				int_3 = 0,
				string_0 = "Thiên Vương  Chùy Pháp"
			},
			new GStruct58
			{
				int_1 = 27,
				int_3 = 0,
				string_0 = "Thiên Vương  Phủ pháp"
			},
			new GStruct58
			{
				int_1 = 28,
				int_3 = 0,
				string_0 = "Thánh Vương Phủ pháp"
			},
			new GStruct58
			{
				int_1 = 29,
				int_3 = 72,
				string_0 = "Trảm Long quyết"
			},
			new GStruct58
			{
				int_1 = 30,
				int_3 = 90,
				string_0 = "Hồi Phong Lạc Nhạn"
			},
			new GStruct58
			{
				int_1 = 31,
				int_3 = 72,
				string_0 = "Hàng Vân Quyết"
			},
			new GStruct58
			{
				int_1 = 32,
				int_3 = 90,
				string_0 = "Vô Tâm Trảm "
			},
			new GStruct58
			{
				int_1 = 33,
				int_3 = 0,
				string_0 = "Tĩnh Tâm Quyết"
			},
			new GStruct58
			{
				int_1 = 34,
				int_3 = 72,
				string_0 = "Kinh Lôi Trảm "
			},
			new GStruct58
			{
				int_1 = 35,
				int_3 = 90,
				string_0 = "Dương Quan Tam Điệp"
			},
			new GStruct58
			{
				int_1 = 36,
				int_3 = 0,
				string_0 = "Thiên Vương Chiến ý "
			},
			new GStruct58
			{
				int_1 = 37,
				int_3 = 90,
				string_0 = "Bát Phong Trảm"
			},
			new GStruct58
			{
				int_1 = 38,
				int_3 = 90,
				string_0 = "Bàn Cổ Cửu Thức"
			},
			new GStruct58
			{
				int_1 = 39,
				int_3 = 0,
				string_0 = "Triêm Y Thập Bát Điệt"
			},
			new GStruct58
			{
				int_1 = 40,
				int_3 = 200,
				string_0 = "Đoạn Hồn Thích"
			},
			new GStruct58
			{
				int_1 = 41,
				int_3 = 90,
				string_0 = "Huyết Chiến Bát Phương"
			},
			new GStruct58
			{
				int_1 = 42,
				int_3 = 0,
				string_0 = "Kim Chung Tráo"
			},
			new GStruct58
			{
				int_1 = 43,
				int_3 = 0,
				string_0 = "Đường Môn ám khí "
			},
			new GStruct58
			{
				int_1 = 44,
				int_3 = 0,
				string_0 = "Đường Môn Đao pháp"
			},
			new GStruct58
			{
				int_1 = 45,
				int_3 = 400,
				string_0 = "Tích Lịch đơn"
			},
			new GStruct58
			{
				int_1 = 46,
				int_3 = 180,
				string_0 = "Đao Nhận cơ quan"
			},
			new GStruct58
			{
				int_1 = 47,
				int_3 = 450,
				string_0 = "Đoạt Hồn Tiêu"
			},
			new GStruct58
			{
				int_1 = 48,
				int_3 = 0,
				string_0 = "Tâm Nhãn "
			},
			new GStruct58
			{
				int_1 = 49,
				int_3 = 180,
				string_0 = "Địa Diệm cơ quan"
			},
			new GStruct58
			{
				int_1 = 50,
				int_3 = 360,
				string_0 = "Truy Tâm Tiễn"
			},
			new GStruct58
			{
				int_1 = 51,
				int_3 = 0,
				string_0 = "Thanh Mộc"
			},
			new GStruct58
			{
				int_1 = 52,
				int_3 = 180,
				string_0 = "Âm Lôi Cơ quan"
			},
			new GStruct58
			{
				int_1 = 53,
				int_3 = 75,
				string_0 = "Công kích vật lý "
			},
			new GStruct58
			{
				int_1 = 54,
				int_3 = 400,
				string_0 = "Mạn Thiên Hoa Vũ "
			},
			new GStruct58
			{
				int_1 = 55,
				int_3 = 0,
				string_0 = "Thối Độc Thuật"
			},
			new GStruct58
			{
				int_1 = 56,
				int_3 = 180,
				string_0 = "Hàn Sương Cơ quan"
			},
			new GStruct58
			{
				int_1 = 57,
				int_3 = 0,
				string_0 = "Băng Phách Hàn Quang"
			},
			new GStruct58
			{
				int_1 = 58,
				int_3 = 520,
				string_0 = "Thiên La Địa Võng"
			},
			new GStruct58
			{
				int_1 = 59,
				int_3 = 180,
				string_0 = "Cửu Cung Địa Sát"
			},
			new GStruct58
			{
				int_1 = 60,
				int_3 = 0,
				string_0 = "Ngũ Độc Đao pháp"
			},
			new GStruct58
			{
				int_1 = 61,
				int_3 = 0,
				string_0 = "Ngũ Độc Bổng pháp"
			},
			new GStruct58
			{
				int_1 = 62,
				int_3 = 0,
				string_0 = "Ngũ Độc Chưởng Pháp"
			},
			new GStruct58
			{
				int_1 = 63,
				int_3 = 180,
				string_0 = "Độc Sa chưởng"
			},
			new GStruct58
			{
				int_1 = 64,
				int_3 = 440,
				string_0 = "Băng Lam Huyền Tinh"
			},
			new GStruct58
			{
				int_1 = 65,
				int_3 = 400,
				string_0 = "Huyết Đao Độc Sát"
			},
			new GStruct58
			{
				int_1 = 66,
				int_3 = 0,
				string_0 = "Tạp Nan Dược Kinh"
			},
			new GStruct58
			{
				int_1 = 67,
				int_3 = 440,
				string_0 = "Cửu Thiên Cuồng Lôi "
			},
			new GStruct58
			{
				int_1 = 68,
				int_3 = 400,
				string_0 = "U Minh Khô Lâu"
			},
			new GStruct58
			{
				int_1 = 69,
				int_3 = 400,
				string_0 = "Vô Hình Độc"
			},
			new GStruct58
			{
				int_1 = 70,
				int_3 = 440,
				string_0 = "Xích Diệm Thực Thiên"
			},
			new GStruct58
			{
				int_1 = 71,
				int_3 = 420,
				string_0 = "Thiên Cương Địa Sát"
			},
			new GStruct58
			{
				int_1 = 72,
				int_3 = 440,
				string_0 = "Xuyên Tâm Độc Thích"
			},
			new GStruct58
			{
				int_1 = 73,
				int_3 = 440,
				string_0 = "Vạn Độc Thực Tâm"
			},
			new GStruct58
			{
				int_1 = 74,
				int_3 = 400,
				string_0 = "Chu Cáp Thanh Minh"
			},
			new GStruct58
			{
				int_1 = 75,
				int_3 = 0,
				string_0 = "Ngũ Độc Kỳ Kinh"
			},
			new GStruct58
			{
				int_1 = 76,
				int_3 = 0,
				string_0 = "Di Hoa Tiếp Ngọc"
			},
			new GStruct58
			{
				int_1 = 77,
				int_3 = 0,
				string_0 = "Nga Mi Kiếm pháp"
			},
			new GStruct58
			{
				int_1 = 78,
				int_3 = 0,
				string_0 = "Tiếp Dẫn Kiếm pháp"
			},
			new GStruct58
			{
				int_1 = 79,
				int_3 = 0,
				string_0 = "Nga Mi Chưởng pháp"
			},
			new GStruct58
			{
				int_1 = 80,
				int_3 = 240,
				string_0 = "Phiêu Tuyết Xuyên Vân "
			},
			new GStruct58
			{
				int_1 = 81,
				int_3 = 0,
				string_0 = "Thu Phong Diệp"
			},
			new GStruct58
			{
				int_1 = 82,
				int_3 = 570,
				string_0 = "Tứ Tượng Đồng Quy"
			},
			new GStruct58
			{
				int_1 = 83,
				int_3 = 180,
				string_0 = "Vọng Nguyệt"
			},
			new GStruct58
			{
				int_1 = 84,
				int_3 = 180,
				string_0 = "Phong Vũ Phiêu Hương"
			},
			new GStruct58
			{
				int_1 = 85,
				int_3 = 180,
				string_0 = "Nhất Diệp Tri Thu"
			},
			new GStruct58
			{
				int_1 = 86,
				int_3 = 180,
				string_0 = "Lưu Thủy "
			},
			new GStruct58
			{
				int_1 = 87,
				int_3 = 0,
				string_0 = "Băng Tâm Quyết"
			},
			new GStruct58
			{
				int_1 = 88,
				int_3 = 360,
				string_0 = "Bất Diệt Bất Tuyệt"
			},
			new GStruct58
			{
				int_1 = 89,
				int_3 = 180,
				string_0 = "Mộng Điệp "
			},
			new GStruct58
			{
				int_1 = 90,
				int_3 = 440,
				string_0 = "Mê Tung ảo ảnh"
			},
			new GStruct58
			{
				int_1 = 91,
				int_3 = 400,
				string_0 = "Phật Quang Phổ Chiếu"
			},
			new GStruct58
			{
				int_1 = 92,
				int_3 = 180,
				string_0 = "Phật Tâm Từ Hữu"
			},
			new GStruct58
			{
				int_1 = 93,
				int_3 = 400,
				string_0 = "Từ Hàng Phổ D"
			},
			new GStruct58
			{
				int_1 = 94,
				int_3 = 400,
				string_0 = "Từ Hàng Phổ Độ11"
			},
			new GStruct58
			{
				int_1 = 95,
				int_3 = 0,
				string_0 = "Thúy Yên Đao pháp"
			},
			new GStruct58
			{
				int_1 = 96,
				int_3 = 0,
				string_0 = "Thúy Yên Kiếm pháp"
			},
			new GStruct58
			{
				int_1 = 97,
				int_3 = 0,
				string_0 = "Thúy Yên Song đao"
			},
			new GStruct58
			{
				int_1 = 98,
				int_3 = 0,
				string_0 = "Bích Yên kiếm pháp"
			},
			new GStruct58
			{
				int_1 = 99,
				int_3 = 360,
				string_0 = "Phong Hoa Tuyết Nguyệt"
			},
			new GStruct58
			{
				int_1 = 100,
				int_3 = 0,
				string_0 = "Hộ Thể Hàn Băng "
			},
			new GStruct58
			{
				int_1 = 101,
				int_3 = 400,
				string_0 = "Trị liệu thuật"
			},
			new GStruct58
			{
				int_1 = 102,
				int_3 = 360,
				string_0 = "Phong Quyển Tàn Tuyết"
			},
			new GStruct58
			{
				int_1 = 103,
				int_3 = 0,
				string_0 = "Thiên Lý Băng Phong "
			},
			new GStruct58
			{
				int_1 = 104,
				int_3 = 0,
				string_0 = "Băng Hồn"
			},
			new GStruct58
			{
				int_1 = 105,
				int_3 = 300,
				string_0 = "Vũ Đả Lê Hoa"
			},
			new GStruct58
			{
				int_1 = 106,
				int_3 = 400,
				string_0 = "Băng Tung Vụ ảnh 111"
			},
			new GStruct58
			{
				int_1 = 107,
				int_3 = 180,
				string_0 = "Nhiếp Tâm Thuật"
			},
			new GStruct58
			{
				int_1 = 108,
				int_3 = 420,
				string_0 = "Mục Dã Lưu Tinh"
			},
			new GStruct58
			{
				int_1 = 109,
				int_3 = 0,
				string_0 = "Tuyết ảnh"
			},
			new GStruct58
			{
				int_1 = 110,
				int_3 = 180,
				string_0 = "Ngũ hành độn"
			},
			new GStruct58
			{
				int_1 = 111,
				int_3 = 72,
				string_0 = "Bích Hải Triều Sinh"
			},
			new GStruct58
			{
				int_1 = 112,
				int_3 = 0,
				string_0 = "Bích Hải Triều Sinhb"
			},
			new GStruct58
			{
				int_1 = 113,
				int_3 = 400,
				string_0 = "Phù Vân Tán Tuyết"
			},
			new GStruct58
			{
				int_1 = 114,
				int_3 = 0,
				string_0 = "Băng Cốt Tuyết Tâm"
			},
			new GStruct58
			{
				int_1 = 115,
				int_3 = 0,
				string_0 = "Cái Bang Bổng pháp"
			},
			new GStruct58
			{
				int_1 = 116,
				int_3 = 0,
				string_0 = "Cái Bang Chưởng Pháp"
			},
			new GStruct58
			{
				int_1 = 117,
				int_3 = 280,
				string_0 = "Đầu Thạch Vấn Lộ "
			},
			new GStruct58
			{
				int_1 = 118,
				int_3 = 400,
				string_0 = "Cô Mộc Độn Lôi "
			},
			new GStruct58
			{
				int_1 = 119,
				int_3 = 240,
				string_0 = "Diên Môn Thác Bát"
			},
			new GStruct58
			{
				int_1 = 120,
				int_3 = 400,
				string_0 = "Bôn Lưu Đáo Hải"
			},
			new GStruct58
			{
				int_1 = 121,
				int_3 = 180,
				string_0 = "Diệu Thủ Không Không"
			},
			new GStruct58
			{
				int_1 = 122,
				int_3 = 300,
				string_0 = "Kiến Nhân Thần Thủ "
			},
			new GStruct58
			{
				int_1 = 123,
				int_3 = 400,
				string_0 = "Khuê Mộc Tinh Chiếu"
			},
			new GStruct58
			{
				int_1 = 124,
				int_3 = 0,
				string_0 = "Đả Cẩu bổng"
			},
			new GStruct58
			{
				int_1 = 125,
				int_3 = 72,
				string_0 = "Bổng Đả ác Cẩu"
			},
			new GStruct58
			{
				int_1 = 126,
				int_3 = 400,
				string_0 = "Kim Ô ánh Tuyết"
			},
			new GStruct58
			{
				int_1 = 127,
				int_3 = 0,
				string_0 = "Hoạt Bất Lưu Thủ 11"
			},
			new GStruct58
			{
				int_1 = 128,
				int_3 = 400,
				string_0 = "Kháng Long Hữu Hối"
			},
			new GStruct58
			{
				int_1 = 129,
				int_3 = 400,
				string_0 = "Hóa Hiểm Vi Di"
			},
			new GStruct58
			{
				int_1 = 130,
				int_3 = 0,
				string_0 = "Túy Điệp Cuồng Vũ "
			},
			new GStruct58
			{
				int_1 = 131,
				int_3 = 0,
				string_0 = "Thiên Nhẫn  Đao pháp"
			},
			new GStruct58
			{
				int_1 = 132,
				int_3 = 0,
				string_0 = "Thiên Nhẫn  Mâu pháp"
			},
			new GStruct58
			{
				int_1 = 133,
				int_3 = 0,
				string_0 = "Thiên Nhẫn  phủ pháp"
			},
			new GStruct58
			{
				int_1 = 134,
				int_3 = 0,
				string_0 = "Thiên Nhẫn  Chùy pháp "
			},
			new GStruct58
			{
				int_1 = 135,
				int_3 = 270,
				string_0 = "Tàn Dương Như Huyết"
			},
			new GStruct58
			{
				int_1 = 136,
				int_3 = 440,
				string_0 = "Hỏa Liên Phần Hoa"
			},
			new GStruct58
			{
				int_1 = 137,
				int_3 = 440,
				string_0 = "ảo ảnh Phi Hồ "
			},
			new GStruct58
			{
				int_1 = 138,
				int_3 = 400,
				string_0 = "Thôi sơn  Điền Hải"
			},
			new GStruct58
			{
				int_1 = 139,
				int_3 = 60,
				string_0 = "Hỗn Thủy Mạc Ngư "
			},
			new GStruct58
			{
				int_1 = 140,
				int_3 = 440,
				string_0 = "Phi Hồng Vô Tích "
			},
			new GStruct58
			{
				int_1 = 141,
				int_3 = 72,
				string_0 = "Liệt Hỏa Tình Thiên "
			},
			new GStruct58
			{
				int_1 = 142,
				int_3 = 60,
				string_0 = "Thâu Thiên Hoán Nhật"
			},
			new GStruct58
			{
				int_1 = 143,
				int_3 = 440,
				string_0 = "Lịch Ma Đoạt Hồn"
			},
			new GStruct58
			{
				int_1 = 144,
				int_3 = 0,
				string_0 = "Minh Tôn Bản Sinh"
			},
			new GStruct58
			{
				int_1 = 145,
				int_3 = 280,
				string_0 = "Đơn Chỉ Liệt Diệm"
			},
			new GStruct58
			{
				int_1 = 146,
				int_3 = 180,
				string_0 = "Ngũ hành trận"
			},
			new GStruct58
			{
				int_1 = 147,
				int_3 = 60,
				string_0 = "Huyền Minh Hấp Tinh"
			},
			new GStruct58
			{
				int_1 = 148,
				int_3 = 570,
				string_0 = "Ma Diệm Thất Sát"
			},
			new GStruct58
			{
				int_1 = 149,
				int_3 = 0,
				string_0 = "Thực Cốt Huyết Nhận"
			},
			new GStruct58
			{
				int_1 = 150,
				int_3 = 0,
				string_0 = "Thiên Ma Giải Thể "
			},
			new GStruct58
			{
				int_1 = 151,
				int_3 = 0,
				string_0 = "Võ Đang Kiếm pháp"
			},
			new GStruct58
			{
				int_1 = 152,
				int_3 = 0,
				string_0 = "Võ Đang Quyền Pháp"
			},
			new GStruct58
			{
				int_1 = 153,
				int_3 = 400,
				string_0 = "Nộ Lôi Chỉ "
			},
			new GStruct58
			{
				int_1 = 154,
				int_3 = 0,
				string_0 = "Âm Dương Khí"
			},
			new GStruct58
			{
				int_1 = 155,
				int_3 = 480,
				string_0 = "Thương Hải Minh Nguyệt"
			},
			new GStruct58
			{
				int_1 = 156,
				int_3 = 0,
				string_0 = "Thuần Dương Tâm pháp"
			},
			new GStruct58
			{
				int_1 = 157,
				int_3 = 0,
				string_0 = "Tọa Vọng Vô Ngã "
			},
			new GStruct58
			{
				int_1 = 158,
				int_3 = 400,
				string_0 = "Kiếm Phi Kinh Thiên"
			},
			new GStruct58
			{
				int_1 = 159,
				int_3 = 180,
				string_0 = "Thất Tinh Trận"
			},
			new GStruct58
			{
				int_1 = 160,
				int_3 = 0,
				string_0 = "Thế Vân Tung"
			},
			new GStruct58
			{
				int_1 = 161,
				int_3 = 0,
				string_0 = "Lưỡng Nghi Tâm pháp"
			},
			new GStruct58
			{
				int_1 = 162,
				int_3 = 520,
				string_0 = "Huyền Nhất Vô Tượng"
			},
			new GStruct58
			{
				int_1 = 163,
				int_3 = 0,
				string_0 = "Nhân Kiếm Hợp Nhất"
			},
			new GStruct58
			{
				int_1 = 164,
				int_3 = 470,
				string_0 = "Bác Cấp Nhi Phục"
			},
			new GStruct58
			{
				int_1 = 165,
				int_3 = 400,
				string_0 = "Vô Ngã Vô Kiếm  "
			},
			new GStruct58
			{
				int_1 = 166,
				int_3 = 0,
				string_0 = "Thái Cực Thần Công "
			},
			new GStruct58
			{
				int_1 = 167,
				int_3 = 0,
				string_0 = "Côn Lôn Đao pháp"
			},
			new GStruct58
			{
				int_1 = 168,
				int_3 = 0,
				string_0 = "Côn Lôn Kiếm pháp"
			},
			new GStruct58
			{
				int_1 = 169,
				int_3 = 300,
				string_0 = "Hô Phong Pháp"
			},
			new GStruct58
			{
				int_1 = 170,
				int_3 = 0,
				string_0 = "Đại Lãng Thực Không"
			},
			new GStruct58
			{
				int_1 = 171,
				int_3 = 440,
				string_0 = "Thanh Phong phù "
			},
			new GStruct58
			{
				int_1 = 172,
				int_3 = 360,
				string_0 = "Thiên Tế Tấn Lôi  "
			},
			new GStruct58
			{
				int_1 = 173,
				int_3 = 440,
				string_0 = "Thiên Thanh Địa Trọc"
			},
			new GStruct58
			{
				int_1 = 174,
				int_3 = 440,
				string_0 = "Ki Bán phù "
			},
			new GStruct58
			{
				int_1 = 175,
				int_3 = 440,
				string_0 = "Khi Hàn Ngạo Tuyết"
			},
			new GStruct58
			{
				int_1 = 176,
				int_3 = 180,
				string_0 = "Cuồng Phong Sậu Điện"
			},
			new GStruct58
			{
				int_1 = 177,
				int_3 = 440,
				string_0 = "Bách Xuyên Nạp Hải"
			},
			new GStruct58
			{
				int_1 = 178,
				int_3 = 440,
				string_0 = "Nhất Khí Tam Thanh"
			},
			new GStruct58
			{
				int_1 = 179,
				int_3 = 400,
				string_0 = "Cuồng Lôi Chấn Địa "
			},
			new GStruct58
			{
				int_1 = 180,
				int_3 = 0,
				string_0 = "Độc Tê Tị Tà "
			},
			new GStruct58
			{
				int_1 = 181,
				int_3 = 440,
				string_0 = "Khí Tâm phù "
			},
			new GStruct58
			{
				int_1 = 182,
				int_3 = 470,
				string_0 = "Ngũ Lôi Chánh Pháp"
			},
			new GStruct58
			{
				int_1 = 183,
				int_3 = 180,
				string_0 = "Tuế Nguyệt Vô Tình phù "
			},
			new GStruct58
			{
				int_1 = 184,
				int_3 = 0,
				string_0 = "Kim Thiền Thoát Xác "
			},
			new GStruct58
			{
				int_1 = 185,
				int_3 = 180,
				string_0 = "Lam Ba "
			},
			new GStruct58
			{
				int_1 = 186,
				int_3 = 180,
				string_0 = "Hồng Ba "
			},
			new GStruct58
			{
				int_1 = 187,
				int_3 = 180,
				string_0 = "Lục Ba "
			},
			new GStruct58
			{
				int_1 = 188,
				int_3 = 180,
				string_0 = "Bạch Ba "
			},
			new GStruct58
			{
				int_1 = 189,
				int_3 = 180,
				string_0 = "Vũ Đả Lê Hoa "
			},
			new GStruct58
			{
				int_1 = 190,
				int_3 = 180,
				string_0 = "Mục Dã Lưu Tinh "
			},
			new GStruct58
			{
				int_1 = 191,
				int_3 = 180,
				string_0 = "Quan Âm Tán Tuyết "
			},
			new GStruct58
			{
				int_1 = 192,
				int_3 = 400,
				string_0 = "Thất Thương Thần Quyền "
			},
			new GStruct58
			{
				int_1 = 193,
				int_3 = 180,
				string_0 = "Kiếm Phi Kinh Thiên "
			},
			new GStruct58
			{
				int_1 = 194,
				int_3 = 180,
				string_0 = "Thiên La Địa VõngPhi Đao"
			},
			new GStruct58
			{
				int_1 = 195,
				int_3 = 180,
				string_0 = "Thiên Cương Địa Sát "
			},
			new GStruct58
			{
				int_1 = 196,
				int_3 = 180,
				string_0 = "Ném đá"
			},
			new GStruct58
			{
				int_1 = 197,
				int_3 = 180,
				string_0 = "Ném lông "
			},
			new GStruct58
			{
				int_1 = 198,
				int_3 = 180,
				string_0 = "Thổi lông "
			},
			new GStruct58
			{
				int_1 = 199,
				int_3 = 180,
				string_0 = "Phun nước bọt "
			},
			new GStruct58
			{
				int_1 = 200,
				int_3 = 180,
				string_0 = "Phun nước độc "
			},
			new GStruct58
			{
				int_1 = 201,
				int_3 = 180,
				string_0 = "Bắn tên "
			},
			new GStruct58
			{
				int_1 = 202,
				int_3 = 180,
				string_0 = "La Hán Trận "
			},
			new GStruct58
			{
				int_1 = 203,
				int_3 = 180,
				string_0 = "Vô Hình Độc "
			},
			new GStruct58
			{
				int_1 = 204,
				int_3 = 180,
				string_0 = "Thu Phong Diệp "
			},
			new GStruct58
			{
				int_1 = 205,
				int_3 = 180,
				string_0 = "Vọng Nguyệt "
			},
			new GStruct58
			{
				int_1 = 206,
				int_3 = 180,
				string_0 = "Lưu Thủy "
			},
			new GStruct58
			{
				int_1 = 207,
				int_3 = 180,
				string_0 = "Mộng Điệp  "
			},
			new GStruct58
			{
				int_1 = 208,
				int_3 = 180,
				string_0 = "Phật Tâm Từ Hữu"
			},
			new GStruct58
			{
				int_1 = 209,
				int_3 = 180,
				string_0 = "Đả Cẩu bổng "
			},
			new GStruct58
			{
				int_1 = 210,
				int_3 = 400,
				string_0 = "Khinh công "
			},
			new GStruct58
			{
				int_1 = 211,
				int_3 = 180,
				string_0 = "Thất Tinh Trận "
			},
			new GStruct58
			{
				int_1 = 212,
				int_3 = 180,
				string_0 = "Thanh Tâm Phạn Âm"
			},
			new GStruct58
			{
				int_1 = 213,
				int_3 = 180,
				string_0 = "Bất động Minh Vương "
			},
			new GStruct58
			{
				int_1 = 214,
				int_3 = 180,
				string_0 = "Huệ Nhãn chú "
			},
			new GStruct58
			{
				int_1 = 215,
				int_3 = 0,
				string_0 = "Nhân Kiếm Hợp Nhất "
			},
			new GStruct58
			{
				int_1 = 216,
				int_3 = 75,
				string_0 = "Kim Cang Phục Ma "
			},
			new GStruct58
			{
				int_1 = 217,
				int_3 = 75,
				string_0 = "Hoành Tảo Lục Hợp "
			},
			new GStruct58
			{
				int_1 = 218,
				int_3 = 75,
				string_0 = "Long Trảo Hổ Trảo "
			},
			new GStruct58
			{
				int_1 = 219,
				int_3 = 75,
				string_0 = "Hồi Phong Lạc Nhạn "
			},
			new GStruct58
			{
				int_1 = 220,
				int_3 = 75,
				string_0 = "Vô Tâm Trảm  "
			},
			new GStruct58
			{
				int_1 = 221,
				int_3 = 75,
				string_0 = "Dương Quan Tam Điệp "
			},
			new GStruct58
			{
				int_1 = 222,
				int_3 = 75,
				string_0 = "Bát Phong Trảm "
			},
			new GStruct58
			{
				int_1 = 223,
				int_3 = 75,
				string_0 = "Bàn Cổ Cửu Thức "
			},
			new GStruct58
			{
				int_1 = 224,
				int_3 = 75,
				string_0 = "Đoạn Hồn Thích "
			},
			new GStruct58
			{
				int_1 = 225,
				int_3 = 75,
				string_0 = "Huyết Chiến Bát Phương "
			},
			new GStruct58
			{
				int_1 = 226,
				int_3 = 180,
				string_0 = "Ngũ hành trận "
			},
			new GStruct58
			{
				int_1 = 227,
				int_3 = 180,
				string_0 = "Thiên La Địa Võng tiểu Phi Đao"
			},
			new GStruct58
			{
				int_1 = 228,
				int_3 = 180,
				string_0 = "Thiên La Địa Võng"
			},
			new GStruct58
			{
				int_1 = 229,
				int_3 = 75,
				string_0 = "Công kích Côn bổng "
			},
			new GStruct58
			{
				int_1 = 230,
				int_3 = 75,
				string_0 = "Công kích Song chùy "
			},
			new GStruct58
			{
				int_1 = 231,
				int_3 = 75,
				string_0 = "Công kích tay không"
			},
			new GStruct58
			{
				int_1 = 232,
				int_3 = 75,
				string_0 = "Song đaocông kích "
			},
			new GStruct58
			{
				int_1 = 233,
				int_3 = 270,
				string_0 = "Tàn Dương Như Huyết npc"
			},
			new GStruct58
			{
				int_1 = 234,
				int_3 = 180,
				string_0 = "Độc Sa chưởng npc"
			},
			new GStruct58
			{
				int_1 = 235,
				int_3 = 450,
				string_0 = "Truy Tâm Tiễn npc"
			},
			new GStruct58
			{
				int_1 = 236,
				int_3 = 360,
				string_0 = "Phong Hoa Tuyết Nguyệt npc"
			},
			new GStruct58
			{
				int_1 = 237,
				int_3 = 300,
				string_0 = "Hô Phong Pháp npc"
			},
			new GStruct58
			{
				int_1 = 238,
				int_3 = 72,
				string_0 = "Kinh Lôi Trảm npc"
			},
			new GStruct58
			{
				int_1 = 239,
				int_3 = 400,
				string_0 = "Nộ Lôi Chỉ npc"
			},
			new GStruct58
			{
				int_1 = 240,
				int_3 = 320,
				string_0 = "Tích Lịch đơn npc"
			},
			new GStruct58
			{
				int_1 = 241,
				int_3 = 180,
				string_0 = "Phiêu Tuyết Xuyên Vân npc"
			},
			new GStruct58
			{
				int_1 = 242,
				int_3 = 72,
				string_0 = "Trảm Long quyết npc"
			},
			new GStruct58
			{
				int_1 = 243,
				int_3 = 400,
				string_0 = "Tứ Tượng Đồng Quy "
			},
			new GStruct58
			{
				int_1 = 244,
				int_3 = 400,
				string_0 = "Ma Ha Vô Lượng npc"
			},
			new GStruct58
			{
				int_1 = 245,
				int_3 = 400,
				string_0 = "Huyền Nhất Vô Tượng npc"
			},
			new GStruct58
			{
				int_1 = 246,
				int_3 = 600,
				string_0 = "Bất Diệt Bất Tuyệt npc"
			},
			new GStruct58
			{
				int_1 = 247,
				int_3 = 400,
				string_0 = "Đơn Chỉ Liệt Diệm npc"
			},
			new GStruct58
			{
				int_1 = 248,
				int_3 = 400,
				string_0 = "Thiên la Địa võng  npc"
			},
			new GStruct58
			{
				int_1 = 249,
				int_3 = 350,
				string_0 = "Tiểu Lý Phi Đao"
			},
			new GStruct58
			{
				int_1 = 250,
				int_3 = 400,
				string_0 = "Tiểu Lý Phi Đao "
			},
			new GStruct58
			{
				int_1 = 251,
				int_3 = 800,
				string_0 = "Pháo Hoa"
			},
			new GStruct58
			{
				int_1 = 252,
				int_3 = 0,
				string_0 = "Phật Pháp Vô Biên "
			},
			new GStruct58
			{
				int_1 = 253,
				int_3 = 0,
				string_0 = "Ngự Độc Thực Cốt"
			},
			new GStruct58
			{
				int_1 = 254,
				int_3 = 0,
				string_0 = "Tam Muội Chân Hỏa"
			},
			new GStruct58
			{
				int_1 = 255,
				int_3 = 400,
				string_0 = "Sư Tử hựu Hống "
			},
			new GStruct58
			{
				int_1 = 266,
				int_3 = 360,
				string_0 = "NPC Phong Quyển Tàn Tuyết"
			},
			new GStruct58
			{
				int_1 = 267,
				int_3 = 90,
				string_0 = "Tam Hoàn Thao Nguyệt"
			},
			new GStruct58
			{
				int_1 = 268,
				int_3 = 75,
				string_0 = "Tam Hoàn Thao Nguyệt "
			},
			new GStruct58
			{
				int_1 = 269,
				int_3 = 0,
				string_0 = "Băng Tâm Trái ảnh"
			},
			new GStruct58
			{
				int_1 = 270,
				int_3 = 0,
				string_0 = "Đạp Tuyết Vô Ngân "
			},
			new GStruct58
			{
				int_1 = 271,
				int_3 = 90,
				string_0 = "Long Trảo Hổ Trảo"
			},
			new GStruct58
			{
				int_1 = 272,
				int_3 = 75,
				string_0 = "Long Trảo Hổ Trảo "
			},
			new GStruct58
			{
				int_1 = 273,
				int_3 = 0,
				string_0 = "Như Lai Thiên Diệp "
			},
			new GStruct58
			{
				int_1 = 274,
				int_3 = 0,
				string_0 = "Giáng Long Chưởng "
			},
			new GStruct58
			{
				int_1 = 275,
				int_3 = 0,
				string_0 = "Sương Ngạo Côn Lôn "
			},
			new GStruct58
			{
				int_1 = 276,
				int_3 = 480,
				string_0 = "Tuế Nguyệt Vô Tình "
			},
			new GStruct58
			{
				int_1 = 277,
				int_3 = 0,
				string_0 = "Hoạt Bất Lưu Thủ "
			},
			new GStruct58
			{
				int_1 = 278,
				int_3 = 400,
				string_0 = "Phong Vân Giáng "
			},
			new GStruct58
			{
				int_1 = 279,
				int_3 = 0,
				string_0 = "Phong Vân Giáng "
			},
			new GStruct58
			{
				int_1 = 280,
				int_3 = 180,
				string_0 = "Ba La Tâm Kinh"
			},
			new GStruct58
			{
				int_1 = 281,
				int_3 = 180,
				string_0 = "Ba La Tâm Kinh "
			},
			new GStruct58
			{
				int_1 = 282,
				int_3 = 180,
				string_0 = "Thanh Âm Phạn Xướng"
			},
			new GStruct58
			{
				int_1 = 283,
				int_3 = 400,
				string_0 = "Kháng Long Hữu Hối "
			},
			new GStruct58
			{
				int_1 = 290,
				int_3 = 470,
				string_0 = "Hoa Hồng trên mặt đất "
			},
			new GStruct58
			{
				int_1 = 291,
				int_3 = 0,
				string_0 = "Hạnh Vận Tinh "
			},
			new GStruct58
			{
				int_1 = 292,
				int_3 = 180,
				string_0 = "Hạnh Vận Tinh"
			},
			new GStruct58
			{
				int_1 = 301,
				int_3 = 400,
				string_0 = "Truy Tinh Trục Điện"
			},
			new GStruct58
			{
				int_1 = 302,
				int_3 = 470,
				string_0 = "Bạo Vũ Lê Hoa"
			},
			new GStruct58
			{
				int_1 = 303,
				int_3 = 50,
				string_0 = "Độc Thích Cốt "
			},
			new GStruct58
			{
				int_1 = 304,
				int_3 = 0,
				string_0 = "Độc Thích Cốt  "
			},
			new GStruct58
			{
				int_1 = 305,
				int_3 = 180,
				string_0 = "Thanh Mộc Công "
			},
			new GStruct58
			{
				int_1 = 306,
				int_3 = 180,
				string_0 = "Thanh Mộc Công "
			},
			new GStruct58
			{
				int_1 = 307,
				int_3 = 200,
				string_0 = "Công Thành xa"
			},
			new GStruct58
			{
				int_1 = 308,
				int_3 = 600,
				string_0 = "Đầu Thạch Xa công kích (vật lý) "
			},
			new GStruct58
			{
				int_1 = 309,
				int_3 = 600,
				string_0 = "Tất cả trạng thái miễn dịch"
			},
			new GStruct58
			{
				int_1 = 310,
				int_3 = 600,
				string_0 = "Đầu Thạch Xa công kích (Hỏa) "
			},
			new GStruct58
			{
				int_1 = 311,
				int_3 = 600,
				string_0 = "Đầu Thạch Xa công kích (băng) "
			},
			new GStruct58
			{
				int_1 = 312,
				int_3 = 600,
				string_0 = "Đầu Thạch Xacông kích (độc) "
			},
			new GStruct58
			{
				int_1 = 313,
				int_3 = 180,
				string_0 = "Hào quang tăng kháng tính "
			},
			new GStruct58
			{
				int_1 = 314,
				int_3 = 180,
				string_0 = "Hào quang tăng Sinh lực và Nội lực"
			},
			new GStruct58
			{
				int_1 = 315,
				int_3 = 180,
				string_0 = "Vòng tròn  tăng Sinh lực và Nội lực "
			},
			new GStruct58
			{
				int_1 = 316,
				int_3 = 180,
				string_0 = "Vòng tròn  tăng kháng tính "
			},
			new GStruct58
			{
				int_1 = 317,
				int_3 = 75,
				string_0 = "Kim Phật Xuất Kích"
			},
			new GStruct58
			{
				int_1 = 318,
				int_3 = 90,
				string_0 = "Đạt Ma Độ Giang"
			},
			new GStruct58
			{
				int_1 = 319,
				int_3 = 75,
				string_0 = "Hoành Tảo Thiên Quân"
			},
			new GStruct58
			{
				int_1 = 320,
				int_3 = 90,
				string_0 = "Hoành Tảo Lục Hợp 111"
			},
			new GStruct58
			{
				int_1 = 321,
				int_3 = 400,
				string_0 = "Vô Tướng Trảm "
			},
			new GStruct58
			{
				int_1 = 322,
				int_3 = 90,
				string_0 = "Phá Thiên Trảm "
			},
			new GStruct58
			{
				int_1 = 323,
				int_3 = 90,
				string_0 = "Truy Tinh Trục Nguyệt "
			},
			new GStruct58
			{
				int_1 = 324,
				int_3 = 72,
				string_0 = "Thừa Long Quyết "
			},
			new GStruct58
			{
				int_1 = 325,
				int_3 = 72,
				string_0 = "Truy Phong Quyết "
			},
			new GStruct58
			{
				int_1 = 326,
				int_3 = 75,
				string_0 = "Phá Thiên Trảm "
			},
			new GStruct58
			{
				int_1 = 327,
				int_3 = 75,
				string_0 = "Truy Tinh Trục Nguyệt "
			},
			new GStruct58
			{
				int_1 = 328,
				int_3 = 360,
				string_0 = "Tam Nga Tề Tuyết "
			},
			new GStruct58
			{
				int_1 = 329,
				int_3 = 400,
				string_0 = "Ngọc Tuyền Tẩy Trần "
			},
			new GStruct58
			{
				int_1 = 330,
				int_3 = 0,
				string_0 = "Thiên Phật Thiên Diệp "
			},
			new GStruct58
			{
				int_1 = 331,
				int_3 = 400,
				string_0 = "Kim Đỉnh Phật Quang "
			},
			new GStruct58
			{
				int_1 = 332,
				int_3 = 180,
				string_0 = "Phổ Độ Chúng Sinh "
			},
			new GStruct58
			{
				int_1 = 333,
				int_3 = 180,
				string_0 = "Phổ Độ Chúng Sinh "
			},
			new GStruct58
			{
				int_1 = 334,
				int_3 = 180,
				string_0 = "Thanh Âm Phạn Xướng 11"
			},
			new GStruct58
			{
				int_1 = 335,
				int_3 = 180,
				string_0 = "Thanh Âm Phạn Xướng "
			},
			new GStruct58
			{
				int_1 = 336,
				int_3 = 360,
				string_0 = "Băng Tung Vô ảnh "
			},
			new GStruct58
			{
				int_1 = 337,
				int_3 = 240,
				string_0 = "Băng Tâm Tiên Tử  "
			},
			new GStruct58
			{
				int_1 = 338,
				int_3 = 400,
				string_0 = "Phong Tuyết Băng Thiên "
			},
			new GStruct58
			{
				int_1 = 339,
				int_3 = 360,
				string_0 = "Nhiếp Hồn Nguyệt ảnh"
			},
			new GStruct58
			{
				int_1 = 340,
				int_3 = 400,
				string_0 = "Ngân Đao Xạ Nguyệt "
			},
			new GStruct58
			{
				int_1 = 341,
				int_3 = 400,
				string_0 = "Tán Hoa Tiêu "
			},
			new GStruct58
			{
				int_1 = 342,
				int_3 = 360,
				string_0 = "Cửu Cung Phi Tinh"
			},
			new GStruct58
			{
				int_1 = 343,
				int_3 = 50,
				string_0 = "Xuyên Tâm Thích "
			},
			new GStruct58
			{
				int_1 = 344,
				int_3 = 0,
				string_0 = "Xuyên Tâm Thích "
			},
			new GStruct58
			{
				int_1 = 345,
				int_3 = 50,
				string_0 = "Hàn Băng Thích "
			},
			new GStruct58
			{
				int_1 = 346,
				int_3 = 0,
				string_0 = "Hàn Băng Thích "
			},
			new GStruct58
			{
				int_1 = 347,
				int_3 = 50,
				string_0 = "Địa Diệm Hỏa "
			},
			new GStruct58
			{
				int_1 = 348,
				int_3 = 0,
				string_0 = "Địa Diệm Hỏa "
			},
			new GStruct58
			{
				int_1 = 349,
				int_3 = 50,
				string_0 = "Lôi Kích Thuật "
			},
			new GStruct58
			{
				int_1 = 350,
				int_3 = 0,
				string_0 = "Lôi Kích Thuật "
			},
			new GStruct58
			{
				int_1 = 351,
				int_3 = 50,
				string_0 = "Loạn Hoàn Kích"
			},
			new GStruct58
			{
				int_1 = 352,
				int_3 = 0,
				string_0 = "Loạn Hoàn Kích "
			},
			new GStruct58
			{
				int_1 = 353,
				int_3 = 420,
				string_0 = "Âm Phong Thực Cốt "
			},
			new GStruct58
			{
				int_1 = 354,
				int_3 = 420,
				string_0 = "Thiên Cương Độc Thủ "
			},
			new GStruct58
			{
				int_1 = 355,
				int_3 = 180,
				string_0 = "Huyền Âm Trảm "
			},
			new GStruct58
			{
				int_1 = 356,
				int_3 = 440,
				string_0 = "Xuyên Y Phá Giáp "
			},
			new GStruct58
			{
				int_1 = 357,
				int_3 = 400,
				string_0 = "Phi Long Tại Thiên "
			},
			new GStruct58
			{
				int_1 = 358,
				int_3 = 570,
				string_0 = "Tiềm Long Tại Uyên"
			},
			new GStruct58
			{
				int_1 = 359,
				int_3 = 400,
				string_0 = "Thiên Hạ Vô Cẩu "
			},
			new GStruct58
			{
				int_1 = 360,
				int_3 = 0,
				string_0 = "Tiêu Diêu Công "
			},
			new GStruct58
			{
				int_1 = 361,
				int_3 = 60,
				string_0 = "Vân Long Kích"
			},
			new GStruct58
			{
				int_1 = 362,
				int_3 = 420,
				string_0 = "Thiên Ngoại Lưu Tinh"
			},
			new GStruct58
			{
				int_1 = 363,
				int_3 = 570,
				string_0 = "Nghiệp Hỏa Phàn Thành "
			},
			new GStruct58
			{
				int_1 = 364,
				int_3 = 440,
				string_0 = "Bi Tô Thanh Phong "
			},
			new GStruct58
			{
				int_1 = 365,
				int_3 = 470,
				string_0 = "Thiên Địa Vô Cực "
			},
			new GStruct58
			{
				int_1 = 366,
				int_3 = 470,
				string_0 = "Thái Cực Vô ý "
			},
			new GStruct58
			{
				int_1 = 367,
				int_3 = 400,
				string_0 = "Kiếm Khí Tung Hoành "
			},
			new GStruct58
			{
				int_1 = 368,
				int_3 = 90,
				string_0 = "Nhân Kiếm Hợp Nhất  "
			},
			new GStruct58
			{
				int_1 = 369,
				int_3 = 480,
				string_0 = "Minh Nguyệt Vô Tâm "
			},
			new GStruct58
			{
				int_1 = 370,
				int_3 = 400,
				string_0 = "Vạn Kiếm Tề Phát "
			},
			new GStruct58
			{
				int_1 = 371,
				int_3 = 470,
				string_0 = "Thái Cực Kiếm ý "
			},
			new GStruct58
			{
				int_1 = 372,
				int_3 = 400,
				string_0 = "Ngạo Tuyết Tiêu Phong "
			},
			new GStruct58
			{
				int_1 = 373,
				int_3 = 470,
				string_0 = "Khiếu Phong Tam Liên Kích"
			},
			new GStruct58
			{
				int_1 = 374,
				int_3 = 400,
				string_0 = "Vụ Tỏa Côn Lôn "
			},
			new GStruct58
			{
				int_1 = 375,
				int_3 = 470,
				string_0 = "Lôi động Cửu Thiên "
			},
			new GStruct58
			{
				int_1 = 376,
				int_3 = 400,
				string_0 = "Túy Tiên Tá Cốt 99"
			},
			new GStruct58
			{
				int_1 = 377,
				int_3 = 400,
				string_0 = "Nộ Lôi Liên hoàn Kích "
			},
			new GStruct58
			{
				int_1 = 378,
				int_3 = 400,
				string_0 = "Phong Hỏa Liên Thiên "
			},
			new GStruct58
			{
				int_1 = 379,
				int_3 = 400,
				string_0 = "Ma Viêm Tại Thiên  "
			},
			new GStruct58
			{
				int_1 = 380,
				int_3 = 400,
				string_0 = "Phong Sương Toái ảnh "
			},
			new GStruct58
			{
				int_1 = 381,
				int_3 = 400,
				string_0 = "Băng Tâm Ngọc Lăng "
			},
			new GStruct58
			{
				int_1 = 382,
				int_3 = 400,
				string_0 = "Băng Tâm Tuyết Liên "
			},
			new GStruct58
			{
				int_1 = 383,
				int_3 = 420,
				string_0 = "Tinh Không Phá "
			},
			new GStruct58
			{
				int_1 = 384,
				int_3 = 180,
				string_0 = "Bách Độc Xuyên Tâm "
			},
			new GStruct58
			{
				int_1 = 385,
				int_3 = 360,
				string_0 = "Thôi Song Vọng Nguyệt"
			},
			new GStruct58
			{
				int_1 = 386,
				int_3 = 300,
				string_0 = "Ngự Phong thuật"
			},
			new GStruct58
			{
				int_1 = 387,
				int_3 = 400,
				string_0 = "Bình Địa Hám Lôi "
			},
			new GStruct58
			{
				int_1 = 388,
				int_3 = 180,
				string_0 = "Truy Phong Độc Cát "
			},
			new GStruct58
			{
				int_1 = 389,
				int_3 = 570,
				string_0 = "Long Chiến Ư Dã "
			},
			new GStruct58
			{
				int_1 = 390,
				int_3 = 440,
				string_0 = "Đoạn Cân Hủ Cốt "
			},
			new GStruct58
			{
				int_1 = 391,
				int_3 = 440,
				string_0 = "Nhiếp Hồn Loạn Tâm "
			},
			new GStruct58
			{
				int_1 = 392,
				int_3 = 470,
				string_0 = "Thúc Phược Chú "
			},
			new GStruct58
			{
				int_1 = 393,
				int_3 = 440,
				string_0 = "Bắc Minh Đáo Hải"
			},
			new GStruct58
			{
				int_1 = 394,
				int_3 = 440,
				string_0 = "Túy Tiên Tá Cốt"
			},
			new GStruct58
			{
				int_1 = 395,
				int_3 = 90,
				string_0 = "Dã Cầu Quyền "
			},
			new GStruct58
			{
				int_1 = 396,
				int_3 = 180,
				string_0 = "Xuân Phong Vũ Lộ "
			},
			new GStruct58
			{
				int_1 = 397,
				int_3 = 180,
				string_0 = "Vũ Lộ Xuân Phong  "
			},
			new GStruct58
			{
				int_1 = 398,
				int_3 = 360,
				string_0 = "Phong Quyển Tàn Tuyết (ảnh động) "
			},
			new GStruct58
			{
				int_1 = 399,
				int_3 = 360,
				string_0 = "Thiên Tế Tấn Lôi (ảnh động) "
			},
			new GStruct58
			{
				int_1 = 400,
				int_3 = 360,
				string_0 = "Kiếp Phú Tế Bần "
			},
			new GStruct58
			{
				int_1 = 404,
				int_3 = 75,
				string_0 = "Kinh Lôi Trảm  "
			},
			new GStruct58
			{
				int_1 = 405,
				int_3 = 75,
				string_0 = "Trảm Long quyết "
			},
			new GStruct58
			{
				int_1 = 406,
				int_3 = 75,
				string_0 = "Hàng Vân Quyết "
			},
			new GStruct58
			{
				int_1 = 407,
				int_3 = 72,
				string_0 = "Thừa Long Quyết  "
			},
			new GStruct58
			{
				int_1 = 408,
				int_3 = 72,
				string_0 = "Truy Phong Quyết  "
			},
			new GStruct58
			{
				int_1 = 409,
				int_3 = 75,
				string_0 = "Dã Cầu Quyền  "
			},
			new GStruct58
			{
				int_1 = 410,
				int_3 = 0,
				string_0 = "Bánh chưng May mắn "
			},
			new GStruct58
			{
				int_1 = 411,
				int_3 = 0,
				string_0 = "Nê Thu Công "
			},
			new GStruct58
			{
				int_1 = 412,
				int_3 = 0,
				string_0 = "Trường Sinh Quy Mệnh Quyết"
			},
			new GStruct58
			{
				int_1 = 413,
				int_3 = 0,
				string_0 = "Linh Hồ Khai Thần thuật "
			},
			new GStruct58
			{
				int_1 = 414,
				int_3 = 180,
				string_0 = "Kê Khuyển Thăng Thiên "
			},
			new GStruct58
			{
				int_1 = 415,
				int_3 = 180,
				string_0 = "Kê Khuyển Thăng Thiên "
			},
			new GStruct58
			{
				int_1 = 416,
				int_3 = 200,
				string_0 = "Đoạn Hồn Thích npc"
			},
			new GStruct58
			{
				int_1 = 417,
				int_3 = 75,
				string_0 = "Đoạn Hồn Thích npc"
			},
			new GStruct58
			{
				int_1 = 418,
				int_3 = 100,
				string_0 = "Công kích vật lý  npc"
			},
			new GStruct58
			{
				int_1 = 429,
				int_3 = 360,
				string_0 = "Tam Nga Tề Tuyết npc"
			},
			new GStruct58
			{
				int_1 = 430,
				int_3 = 400,
				string_0 = "Ngọc Tuyền Tẩy Trần npc"
			},
			new GStruct58
			{
				int_1 = 431,
				int_3 = 470,
				string_0 = "Thiên Địa Vô Cực npc"
			},
			new GStruct58
			{
				int_1 = 432,
				int_3 = 400,
				string_0 = "Kiếm Khí Tung Hoành npc"
			},
			new GStruct58
			{
				int_1 = 433,
				int_3 = 420,
				string_0 = "Thiên Ngoại Lưu Tinh npc"
			},
			new GStruct58
			{
				int_1 = 434,
				int_3 = 570,
				string_0 = "Nghiệp Hỏa Phàn Thành npc"
			},
			new GStruct58
			{
				int_1 = 435,
				int_3 = 400,
				string_0 = "Ma Viêm Tại Thiên npc"
			},
			new GStruct58
			{
				int_1 = 436,
				int_3 = 470,
				string_0 = "Bạo Vũ Lê Hoa npc"
			},
			new GStruct58
			{
				int_1 = 437,
				int_3 = 400,
				string_0 = "Truy Tinh Trục Điện npc"
			},
			new GStruct58
			{
				int_1 = 438,
				int_3 = 470,
				string_0 = "Thái Cực Vô ý npc"
			},
			new GStruct58
			{
				int_1 = 439,
				int_3 = 400,
				string_0 = "Nộ Lôi Liên Hoàn kích npc"
			},
			new GStruct58
			{
				int_1 = 440,
				int_3 = 0,
				string_0 = "Tiên Thảo Lộ "
			},
			new GStruct58
			{
				int_1 = 441,
				int_3 = 0,
				string_0 = "Thiên sơn  Bảo Lộ "
			},
			new GStruct58
			{
				int_1 = 442,
				int_3 = 0,
				string_0 = "Bách Quả Lộ "
			},
			new GStruct58
			{
				int_1 = 443,
				int_3 = 0,
				string_0 = "Bạch Câu hoàn"
			},
			new GStruct58
			{
				int_1 = 444,
				int_3 = 0,
				string_0 = "Phúc Tinh Cao Chiếu "
			},
			new GStruct58
			{
				int_1 = 445,
				int_3 = 90,
				string_0 = "công kích cơ bản (kim) "
			},
			new GStruct58
			{
				int_1 = 446,
				int_3 = 90,
				string_0 = "công kích cơ bản (mộc) "
			},
			new GStruct58
			{
				int_1 = 447,
				int_3 = 90,
				string_0 = "công kích cơ bản (thủy) "
			},
			new GStruct58
			{
				int_1 = 448,
				int_3 = 90,
				string_0 = "công kích cơ bản (hỏa) "
			},
			new GStruct58
			{
				int_1 = 449,
				int_3 = 90,
				string_0 = "công kích cơ bản (thổ) "
			},
			new GStruct58
			{
				int_1 = 534,
				int_3 = 90,
				string_0 = "Ngũ hành công kích. Kim"
			},
			new GStruct58
			{
				int_1 = 535,
				int_3 = 90,
				string_0 = "Ngũ hành công kích. Mộc"
			},
			new GStruct58
			{
				int_1 = 536,
				int_3 = 90,
				string_0 = "Ngũ hành công kích. Thủy"
			},
			new GStruct58
			{
				int_1 = 537,
				int_3 = 90,
				string_0 = "Ngũ hành công kích. Hỏa"
			},
			new GStruct58
			{
				int_1 = 538,
				int_3 = 90,
				string_0 = "Ngũ hành công kích. Thổ "
			},
			new GStruct58
			{
				int_1 = 539,
				int_3 = 180,
				string_0 = "Vòng tròn  miễn dịch "
			},
			new GStruct58
			{
				int_1 = 540,
				int_3 = 180,
				string_0 = "Vòng tròn  miễn dịch "
			},
			new GStruct58
			{
				int_1 = 549,
				int_3 = 0,
				string_0 = "Kim Cang Bất Phá "
			},
			new GStruct58
			{
				int_1 = 550,
				int_3 = 0,
				string_0 = "Bách Độc Bất Xâm"
			},
			new GStruct58
			{
				int_1 = 551,
				int_3 = 0,
				string_0 = "Băng Tuyết Sơ Dung"
			},
			new GStruct58
			{
				int_1 = 552,
				int_3 = 0,
				string_0 = "Chân Hỏa Kháng Lực"
			},
			new GStruct58
			{
				int_1 = 553,
				int_3 = 0,
				string_0 = "Lôi Đình Hộ giáp"
			},
			new GStruct58
			{
				int_1 = 554,
				int_3 = 75,
				string_0 = "Ngân Câu Thiết Hoạch "
			},
			new GStruct58
			{
				int_1 = 555,
				int_3 = 75,
				string_0 = "Hải Thiên Nhất Tuyến "
			},
			new GStruct58
			{
				int_1 = 556,
				int_3 = 75,
				string_0 = "Phá Không Trảm ảnh "
			},
			new GStruct58
			{
				int_1 = 557,
				int_3 = 75,
				string_0 = "Bất Diệt Sát ý "
			},
			new GStruct58
			{
				int_1 = 558,
				int_3 = 600,
				string_0 = "Trấn Ngục Phá Thiên. "
			},
			new GStruct58
			{
				int_1 = 559,
				int_3 = 600,
				string_0 = "Đại Bi Chú "
			},
			new GStruct58
			{
				int_1 = 560,
				int_3 = 300,
				string_0 = "Hắc Sát Thần Sa "
			},
			new GStruct58
			{
				int_1 = 561,
				int_3 = 300,
				string_0 = "Thiên Thù Vạn Độc  "
			},
			new GStruct58
			{
				int_1 = 562,
				int_3 = 300,
				string_0 = "Bi Ma Huyết Quang "
			},
			new GStruct58
			{
				int_1 = 563,
				int_3 = 350,
				string_0 = "Cô Yên Trục Vân "
			},
			new GStruct58
			{
				int_1 = 564,
				int_3 = 600,
				string_0 = "Luyện Ngục Hủ Cốt "
			},
			new GStruct58
			{
				int_1 = 565,
				int_3 = 600,
				string_0 = "Thực Cốt Huyết Nhẫn "
			},
			new GStruct58
			{
				int_1 = 566,
				int_3 = 280,
				string_0 = "Triều Khởi Nguyệt Doanh "
			},
			new GStruct58
			{
				int_1 = 567,
				int_3 = 280,
				string_0 = "Vạn Liễu Phiêu Phong "
			},
			new GStruct58
			{
				int_1 = 568,
				int_3 = 300,
				string_0 = "Tuyết ánh Hồng Trần  "
			},
			new GStruct58
			{
				int_1 = 569,
				int_3 = 320,
				string_0 = "Sương Dã Tiên Tung "
			},
			new GStruct58
			{
				int_1 = 570,
				int_3 = 600,
				string_0 = "Nghịch Chuyển Tâm Kinh "
			},
			new GStruct58
			{
				int_1 = 571,
				int_3 = 600,
				string_0 = "Huyền Băng Âm Khí "
			},
			new GStruct58
			{
				int_1 = 572,
				int_3 = 180,
				string_0 = "Viêm Long Chi Bào  "
			},
			new GStruct58
			{
				int_1 = 573,
				int_3 = 180,
				string_0 = "Triều Dương Liệt Diệm"
			},
			new GStruct58
			{
				int_1 = 574,
				int_3 = 200,
				string_0 = "Như Nhật Trung Thiên "
			},
			new GStruct58
			{
				int_1 = 575,
				int_3 = 200,
				string_0 = "Xí Không Hỏa Vũ "
			},
			new GStruct58
			{
				int_1 = 576,
				int_3 = 600,
				string_0 = "Trần Không Phạm Tẫn "
			},
			new GStruct58
			{
				int_1 = 577,
				int_3 = 600,
				string_0 = "Hỏa Phụng Khinh Ngâm  "
			},
			new GStruct58
			{
				int_1 = 578,
				int_3 = 220,
				string_0 = "Hỗn Nguyên Càn Khôn "
			},
			new GStruct58
			{
				int_1 = 579,
				int_3 = 240,
				string_0 = "Trường Hà Lạc Nhật "
			},
			new GStruct58
			{
				int_1 = 580,
				int_3 = 260,
				string_0 = "Tật Phong Tấn Lôi"
			},
			new GStruct58
			{
				int_1 = 581,
				int_3 = 260,
				string_0 = "Vô ảnh Kiếm Quyết "
			},
			new GStruct58
			{
				int_1 = 582,
				int_3 = 600,
				string_0 = "Thuần Dương Vô Cực"
			},
			new GStruct58
			{
				int_1 = 583,
				int_3 = 600,
				string_0 = "Vân Sinh Kết Hải "
			},
			new GStruct58
			{
				int_1 = 584,
				int_3 = 0,
				string_0 = "Bình Hoà Khí Quyết"
			},
			new GStruct58
			{
				int_1 = 585,
				int_3 = 0,
				string_0 = "Hư Không Thiểm ảnh"
			},
			new GStruct58
			{
				int_1 = 586,
				int_3 = 0,
				string_0 = "Hội Thần Tĩnh tâm"
			},
			new GStruct58
			{
				int_1 = 587,
				int_3 = 400,
				string_0 = "Vô Niệm Vô Kinh"
			},
			new GStruct58
			{
				int_1 = 588,
				int_3 = 0,
				string_0 = "Ngũ Hành Vô Tướng"
			},
			new GStruct58
			{
				int_1 = 589,
				int_3 = 0,
				string_0 = "Di Khí Phiêu Tung"
			},
			new GStruct58
			{
				int_1 = 590,
				int_3 = 0,
				string_0 = "Hoa Phi Điệp Vũ "
			},
			new GStruct58
			{
				int_1 = 591,
				int_3 = 400,
				string_0 = "Lưu Quang Phi Vũ"
			},
			new GStruct58
			{
				int_1 = 592,
				int_3 = 400,
				string_0 = "Hoàn Bỉ Chi Thân"
			},
			new GStruct58
			{
				int_1 = 593,
				int_3 = 400,
				string_0 = "Đảo Hành Nghịch Thi"
			},
			new GStruct58
			{
				int_1 = 594,
				int_3 = 0,
				string_0 = "Tính Ngạo Tam Đông"
			},
			new GStruct58
			{
				int_1 = 595,
				int_3 = 400,
				string_0 = "Điểm Huyết Tiệt Mạch"
			},
			new GStruct58
			{
				int_1 = 596,
				int_3 = 0,
				string_0 = "Vạn Độc Bất Phục"
			},
			new GStruct58
			{
				int_1 = 597,
				int_3 = 0,
				string_0 = "Thân Khinh Như Yến"
			},
			new GStruct58
			{
				int_1 = 598,
				int_3 = 0,
				string_0 = "Ngưng Âm Quy Nguyên"
			},
			new GStruct58
			{
				int_1 = 599,
				int_3 = 0,
				string_0 = "Dịch Cân Kinh"
			},
			new GStruct58
			{
				int_1 = 600,
				int_3 = 400,
				string_0 = "Thúc Thân Thuật"
			},
			new GStruct58
			{
				int_1 = 601,
				int_3 = 400,
				string_0 = "Hoãn Thân Thuật"
			},
			new GStruct58
			{
				int_1 = 602,
				int_3 = 400,
				string_0 = "Huyền Mục Định Thân Thuật"
			},
			new GStruct58
			{
				int_1 = 603,
				int_3 = 0,
				string_0 = "ích Thọ Âm Dương"
			},
			new GStruct58
			{
				int_1 = 604,
				int_3 = 400,
				string_0 = "An Phủ Chi Ngữ "
			},
			new GStruct58
			{
				int_1 = 605,
				int_3 = 0,
				string_0 = "Nữu Chuyển Càn Khôn"
			},
			new GStruct58
			{
				int_1 = 606,
				int_3 = 0,
				string_0 = "Tam Sinh Hữu Hạnh"
			},
			new GStruct58
			{
				int_1 = 607,
				int_3 = 400,
				string_0 = "Quỷ Mê Ma Hoặc"
			},
			new GStruct58
			{
				int_1 = 608,
				int_3 = 400,
				string_0 = "Đoạt Mệnh Triền Nhiễu "
			},
			new GStruct58
			{
				int_1 = 609,
				int_3 = 400,
				string_0 = "Yêu Hồ Trái ảnh"
			},
			new GStruct58
			{
				int_1 = 610,
				int_3 = 400,
				string_0 = "Hoặc Thần Loạn Tâm"
			},
			new GStruct58
			{
				int_1 = 611,
				int_3 = 400,
				string_0 = "Cô Thân Toái ảnh"
			},
			new GStruct58
			{
				int_1 = 612,
				int_3 = 400,
				string_0 = "Tử Vong Ki Bán"
			},
			new GStruct58
			{
				int_1 = 613,
				int_3 = 400,
				string_0 = "Thâm Hồn Niệm Xướng"
			},
			new GStruct58
			{
				int_1 = 614,
				int_3 = 400,
				string_0 = "Cập Hồn Chú "
			},
			new GStruct58
			{
				int_1 = 615,
				int_3 = 400,
				string_0 = "Hóa Tủy Vô ý "
			},
			new GStruct58
			{
				int_1 = 616,
				int_3 = 400,
				string_0 = "Dung Cốt Vô Tung "
			},
			new GStruct58
			{
				int_1 = 617,
				int_3 = 400,
				string_0 = "Âm Triều Chi Khí"
			},
			new GStruct58
			{
				int_1 = 618,
				int_3 = 400,
				string_0 = "ám Độc Chi Thủ "
			},
			new GStruct58
			{
				int_1 = 619,
				int_3 = 400,
				string_0 = "Tam Phục Chi Khí "
			},
			new GStruct58
			{
				int_1 = 620,
				int_3 = 0,
				string_0 = "Đấu Chuyển Tinh Di"
			},
			new GStruct58
			{
				int_1 = 621,
				int_3 = 200,
				string_0 = "Nam Minh Tam Đoạn Kích "
			},
			new GStruct58
			{
				int_1 = 629,
				int_3 = 0,
				string_0 = "Lăng Ba Vi Bộ "
			},
			new GStruct58
			{
				int_1 = 630,
				int_3 = 0,
				string_0 = "Huyền Thiên Vô Cực"
			},
			new GStruct58
			{
				int_1 = 657,
				int_3 = 280,
				string_0 = "Vạn Liễu Phiêu Phong  "
			},
			new GStruct58
			{
				int_1 = 658,
				int_3 = 320,
				string_0 = "Sương Dã Tiên Tung  "
			},
			new GStruct58
			{
				int_1 = 659,
				int_3 = 260,
				string_0 = "Tật Phong Tấn Lôi "
			},
			new GStruct58
			{
				int_1 = 660,
				int_3 = 400,
				string_0 = "Vô Nhân Vô Ngã "
			},
			new GStruct58
			{
				int_1 = 668,
				int_3 = 50,
				string_0 = "Bẫy choáng (Giáng Sinh) "
			},
			new GStruct58
			{
				int_1 = 669,
				int_3 = 50,
				string_0 = "Bẫy giảm tốc (Giáng Sinh) "
			},
			new GStruct58
			{
				int_1 = 670,
				int_3 = 0,
				string_0 = "Bẫy tăng tốc (Giáng Sinh) "
			},
			new GStruct58
			{
				int_1 = 671,
				int_3 = 50,
				string_0 = "Bẫy hôn mê (Giáng Sinh) "
			},
			new GStruct58
			{
				int_1 = 672,
				int_3 = 50,
				string_0 = "Bẫy giảm tốc (Giáng Sinh) "
			},
			new GStruct58
			{
				int_1 = 673,
				int_3 = 0,
				string_0 = "Bẫy hôn mê (Giáng Sinh) "
			},
			new GStruct58
			{
				int_1 = 674,
				int_3 = 0,
				string_0 = "Bẫy giảm tốc (Giáng Sinh) "
			},
			new GStruct58
			{
				int_1 = 707,
				int_3 = 0,
				string_0 = "Thiên Cơ Lệnh"
			},
			new GStruct58
			{
				int_1 = 708,
				int_3 = 0,
				string_0 = "Đảo Hư Thiên"
			},
			new GStruct58
			{
				int_1 = 709,
				int_3 = 0,
				string_0 = "Đại Thừa Như Lai Chú"
			},
			new GStruct58
			{
				int_1 = 710,
				int_3 = 0,
				string_0 = "Mê ảnh Tung"
			},
			new GStruct58
			{
				int_1 = 711,
				int_3 = 0,
				string_0 = "Hấp Tinh Yểm"
			},
			new GStruct58
			{
				int_1 = 712,
				int_3 = 180,
				string_0 = "Bế Nguyệt Phất Trần"
			},
			new GStruct58
			{
				int_1 = 713,
				int_3 = 0,
				string_0 = "Ngự Tuyết ẩn"
			},
			new GStruct58
			{
				int_1 = 714,
				int_3 = 0,
				string_0 = "Hỗn Thiên Khí Công"
			},
			new GStruct58
			{
				int_1 = 715,
				int_3 = 0,
				string_0 = "Ma Âm Phệ Phách"
			},
			new GStruct58
			{
				int_1 = 716,
				int_3 = 0,
				string_0 = "Xuất ứ Bất Nhiễm"
			},
			new GStruct58
			{
				int_1 = 717,
				int_3 = 0,
				string_0 = "Lưỡng Nghi Chân Khí"
			},
			new GStruct58
			{
				int_1 = 718,
				int_3 = 180,
				string_0 = "Kỹ năng phụ - Bế Nguyệt Phất Trần"
			},
			new GStruct58
			{
				int_1 = 719,
				int_3 = 0,
				string_0 = "Hấp Tinh Yểm_Quyết Chú"
			},
			new GStruct58
			{
				int_1 = 720,
				int_3 = 440,
				string_0 = "Hỗn Thiên Khí Công_Quyết Chú"
			},
			new GStruct58
			{
				int_1 = 721,
				int_3 = 0,
				string_0 = "Lưỡng Nghi Chân Khí_Ma Pháp Độn"
			},
			new GStruct58
			{
				int_1 = 722,
				int_3 = 0,
				string_0 = "Lưỡng Nghi Chân Khí_Gia Tốc"
			},
			new GStruct58
			{
				int_1 = 723,
				int_3 = 180,
				string_0 = "Ma Âm Phệ Phách - Hoảng loạn"
			},
			new GStruct58
			{
				int_1 = 724,
				int_3 = 0,
				string_0 = "Đảo Hư Thiên_Kháng bùa chú"
			},
			new GStruct58
			{
				int_1 = 725,
				int_3 = 0,
				string_0 = "Đại Thừa Như Lai Chú_Phản đòn bùa chú"
			},
			new GStruct58
			{
				int_1 = 726,
				int_3 = 0,
				string_0 = "Vòng sáng Thương Dăng"
			},
			new GStruct58
			{
				int_1 = 727,
				int_3 = 0,
				string_0 = "Vòng sáng Hương Tiêu"
			},
			new GStruct58
			{
				int_1 = 728,
				int_3 = 0,
				string_0 = "Vòng sáng Thương Ưng"
			},
			new GStruct58
			{
				int_1 = 729,
				int_3 = 0,
				string_0 = "Vòng sáng Hỏa Diệm"
			},
			new GStruct58
			{
				int_1 = 730,
				int_3 = 0,
				string_0 = "Vòng sáng ám ảnh"
			},
			new GStruct58
			{
				int_1 = 731,
				int_3 = 0,
				string_0 = "Vòng sáng Thất Kiếm"
			},
			new GStruct58
			{
				int_1 = 732,
				int_3 = 0,
				string_0 = "GM di chuyển"
			},
			new GStruct58
			{
				int_1 = 733,
				int_3 = 0,
				string_0 = "GM ẩn thân"
			},
			new GStruct58
			{
				int_1 = 734,
				int_3 = 0,
				string_0 = "Kỹ năng phụ - Sư Tử Hống"
			},
			new GStruct58
			{
				int_1 = 735,
				int_3 = 0,
				string_0 = "Linh Sâm Lực"
			},
			new GStruct58
			{
				int_1 = 736,
				int_3 = 500,
				string_0 = "Bang hội_Ném trùng đỏ"
			},
			new GStruct58
			{
				int_1 = 737,
				int_3 = 500,
				string_0 = "Kỹ năng ngụy trang"
			},
			new GStruct58
			{
				int_1 = 738,
				int_3 = 0,
				string_0 = "Kỹ năng phụ - Xuất ứ Bất Nhiễm"
			},
			new GStruct58
			{
				int_1 = 739,
				int_3 = 0,
				string_0 = "Kỹ năng bang hội_Phụng Hoàng ấn"
			},
			new GStruct58
			{
				int_1 = 740,
				int_3 = 0,
				string_0 = "Kỹ năng bang hội_Đoạn Võ Hồn"
			},
			new GStruct58
			{
				int_1 = 741,
				int_3 = 0,
				string_0 = "Kỹ năng bang hội_Vô Song Sát Trận"
			},
			new GStruct58
			{
				int_1 = 742,
				int_3 = 0,
				string_0 = "Kỹ năng bang hội_Đào Chu Tiền Đái"
			},
			new GStruct58
			{
				int_1 = 743,
				int_3 = 0,
				string_0 = "Kỹ năng bang hội_Thị Vệ Doanh"
			},
			new GStruct58
			{
				int_1 = 744,
				int_3 = 0,
				string_0 = "Kỹ năng bang hội_Linh Sâm Lực"
			},
			new GStruct58
			{
				int_1 = 745,
				int_3 = 0,
				string_0 = "Kỹ năng bang hội_Hoàng Kim Lệnh"
			},
			new GStruct58
			{
				int_1 = 749,
				int_3 = 0,
				string_0 = "Thiên Nhãn Phù_IB"
			},
			new GStruct58
			{
				int_1 = 750,
				int_3 = 0,
				string_0 = "Tăng điểm kinh nghiệm kỹ năng 120"
			},
			new GStruct58
			{
				int_1 = 751,
				int_3 = 0,
				string_0 = "Tăng Sinh, Nội lực (kỹ năng) "
			},
			new GStruct58
			{
				int_1 = 752,
				int_3 = 400,
				string_0 = "Quả cầu tuyết"
			},
			new GStruct58
			{
				int_1 = 753,
				int_3 = 440,
				string_0 = "Boss Dã Tẩu làm choáng"
			},
			new GStruct58
			{
				int_1 = 754,
				int_3 = 440,
				string_0 = "Boss Dã Tẩu giật lùi"
			},
			new GStruct58
			{
				int_1 = 755,
				int_3 = 440,
				string_0 = "Boss Dã Tẩu làm chậm"
			},
			new GStruct58
			{
				int_1 = 756,
				int_3 = 160,
				string_0 = "Kinh nghiệm pháo hoa Tết 1"
			},
			new GStruct58
			{
				int_1 = 757,
				int_3 = 0,
				string_0 = "Hiệu quả pháo hoa Tết"
			},
			new GStruct58
			{
				int_1 = 758,
				int_3 = 0,
				string_0 = "Chữ pháo hoa Tết 1a"
			},
			new GStruct58
			{
				int_1 = 759,
				int_3 = 0,
				string_0 = "Chữ pháo hoa Tết 1b"
			},
			new GStruct58
			{
				int_1 = 760,
				int_3 = 160,
				string_0 = "Kinh nghiệm pháo hoa Tết 2"
			},
			new GStruct58
			{
				int_1 = 763,
				int_3 = 60,
				string_0 = "Pháo nổ"
			},
			new GStruct58
			{
				int_1 = 840,
				int_3 = 160,
				string_0 = "ảậẻỗẹèằăắưẹộ"
			},
			new GStruct58
			{
				int_1 = 874,
				int_3 = 180,
				string_0 = "ạƠ³ầếẵ³àạõằã"
			},
			new GStruct58
			{
				int_1 = 875,
				int_3 = 180,
				string_0 = "ạƠ³ầếẵ³àạõằãìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 876,
				int_3 = 180,
				string_0 = "ÄĐềụấẫặầ_BOSSìăểÃ"
			},
			new GStruct58
			{
				int_1 = 877,
				int_3 = 400,
				string_0 = "Súng nước"
			},
			new GStruct58
			{
				int_1 = 930,
				int_3 = 400,
				string_0 = "ảẽằờ\u00b4è_BOSSìăểÃ"
			},
			new GStruct58
			{
				int_1 = 931,
				int_3 = 420,
				string_0 = "èỡÍõÁữéầ_boss"
			},
			new GStruct58
			{
				int_1 = 932,
				int_3 = 160,
				string_0 = "ãÅ±ơệủèỉéĐ"
			},
			new GStruct58
			{
				int_1 = 933,
				int_3 = 400,
				string_0 = "Cuồng nộ ngưu"
			},
			new GStruct58
			{
				int_1 = 934,
				int_3 = 400,
				string_0 = "¿ủÅÊệđÅưìểẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 935,
				int_3 = 400,
				string_0 = "Mãnh ngưu cường tập"
			},
			new GStruct58
			{
				int_1 = 936,
				int_3 = 400,
				string_0 = "ÃÍÅÊầ¿ẽđìểẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 937,
				int_3 = 72,
				string_0 = "Tiểu ngưu lưu tinh đan"
			},
			new GStruct58
			{
				int_1 = 938,
				int_3 = 50,
				string_0 = "éĂÅÊÁữéầà\u00afìểẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 939,
				int_3 = 180,
				string_0 = "Hào quang Ngưu Ma Vương"
			},
			new GStruct58
			{
				int_1 = 940,
				int_3 = 180,
				string_0 = "Hào quang hình viên đạn của Ngưu Ma Vương"
			},
			new GStruct58
			{
				int_1 = 941,
				int_3 = 180,
				string_0 = "Hào quang mãnh ngưu"
			},
			new GStruct58
			{
				int_1 = 942,
				int_3 = 180,
				string_0 = "ÃÍÅÊạõằãìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 943,
				int_3 = 180,
				string_0 = "Hào quang thái ngưu"
			},
			new GStruct58
			{
				int_1 = 944,
				int_3 = 180,
				string_0 = "²ậÅÊạõằãìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 945,
				int_3 = 180,
				string_0 = "Hào quang ẩn thân"
			},
			new GStruct58
			{
				int_1 = 946,
				int_3 = 180,
				string_0 = "testạõằã"
			},
			new GStruct58
			{
				int_1 = 947,
				int_3 = 400,
				string_0 = "testskill1"
			},
			new GStruct58
			{
				int_1 = 948,
				int_3 = 400,
				string_0 = "testskill2"
			},
			new GStruct58
			{
				int_1 = 949,
				int_3 = 72,
				string_0 = "testskill3"
			},
			new GStruct58
			{
				int_1 = 950,
				int_3 = 180,
				string_0 = "Hào quang ẩn thân"
			},
			new GStruct58
			{
				int_1 = 951,
				int_3 = 50,
				string_0 = "¿ỉệặéÍẹÊễẻẽíÚồ"
			},
			new GStruct58
			{
				int_1 = 964,
				int_3 = 180,
				string_0 = "ẳừ¿ạạõằã"
			},
			new GStruct58
			{
				int_1 = 965,
				int_3 = 180,
				string_0 = "ẳừ¿ạạõằãìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 966,
				int_3 = 180,
				string_0 = "Tăng võ công"
			},
			new GStruct58
			{
				int_1 = 967,
				int_3 = 180,
				string_0 = "Tăng kinh nghiệm"
			},
			new GStruct58
			{
				int_1 = 968,
				int_3 = 400,
				string_0 = "GM\u00b4úãảẻĐạƠằữẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 969,
				int_3 = 400,
				string_0 = "GM\u00b4úãảẻĐạƠằữẳẳÄĩìểẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 970,
				int_3 = 400,
				string_0 = "GMằự\u00b4ĂạƠằữẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 971,
				int_3 = 400,
				string_0 = "GMéĂãảẻĐạƠằữẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 972,
				int_3 = 180,
				string_0 = "GMạõằã"
			},
			new GStruct58
			{
				int_1 = 973,
				int_3 = 180,
				string_0 = "GMạõằãìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 974,
				int_3 = 400,
				string_0 = "GMẻ±ạƠằữẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 975,
				int_3 = 400,
				string_0 = "GMẻ±ạƠằữẳẳÄĩìểẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 979,
				int_3 = 180,
				string_0 = "Hồng Nguyệt"
			},
			new GStruct58
			{
				int_1 = 980,
				int_3 = 180,
				string_0 = "ÀảễÂ"
			},
			new GStruct58
			{
				int_1 = 981,
				int_3 = 0,
				string_0 = "Nến Cát Tường"
			},
			new GStruct58
			{
				int_1 = 982,
				int_3 = 0,
				string_0 = "Nến Như ý"
			},
			new GStruct58
			{
				int_1 = 983,
				int_3 = 180,
				string_0 = "La Hán Trận"
			},
			new GStruct58
			{
				int_1 = 984,
				int_3 = 180,
				string_0 = "La Hán Trận "
			},
			new GStruct58
			{
				int_1 = 985,
				int_3 = 448,
				string_0 = "ạưặùẳẳÄĩ1"
			},
			new GStruct58
			{
				int_1 = 986,
				int_3 = 448,
				string_0 = "ạư±ứẳẳÄĩ1"
			},
			new GStruct58
			{
				int_1 = 993,
				int_3 = 0,
				string_0 = "Đại Diệp Khí Tráo"
			},
			new GStruct58
			{
				int_1 = 994,
				int_3 = 0,
				string_0 = "Đại Diệp Khí Tráo (bị động )"
			},
			new GStruct58
			{
				int_1 = 995,
				int_3 = 0,
				string_0 = "Huyễn Anh Mê Tung Bộ"
			},
			new GStruct58
			{
				int_1 = 996,
				int_3 = 0,
				string_0 = "Huyễn Anh Mê Tung Bộ ( bị động )"
			},
			new GStruct58
			{
				int_1 = 997,
				int_3 = 0,
				string_0 = "Huyễn Anh Mê Tung Bộ"
			},
			new GStruct58
			{
				int_1 = 998,
				int_3 = 0,
				string_0 = "Trọng kích tuyệt đối"
			},
			new GStruct58
			{
				int_1 = 999,
				int_3 = 0,
				string_0 = "Công kích tuyệt đối ( bị động )"
			},
			new GStruct58
			{
				int_1 = 1000,
				int_3 = 1000,
				string_0 = "tianchiằỳạỉ"
			},
			new GStruct58
			{
				int_1 = 1001,
				int_3 = 400,
				string_0 = "tianchi3²ó"
			},
			new GStruct58
			{
				int_1 = 1002,
				int_3 = 800,
				string_0 = "tianchi3²óìểẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1003,
				int_3 = 400,
				string_0 = "èỡ³ỉẽíÚồ"
			},
			new GStruct58
			{
				int_1 = 1004,
				int_3 = 180,
				string_0 = "èỡ³ỉẽíÚồìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1006,
				int_3 = 400,
				string_0 = "èỡ³ỉboss"
			},
			new GStruct58
			{
				int_1 = 1007,
				int_3 = 400,
				string_0 = "èỡ³ỉbossìểẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1009,
				int_3 = 180,
				string_0 = "ẩôẳẳÄĩ+1ì\u00b4èơ"
			},
			new GStruct58
			{
				int_1 = 1010,
				int_3 = 0,
				string_0 = "Kim Cang Bất Hoại Thần Đơn"
			},
			new GStruct58
			{
				int_1 = 1011,
				int_3 = 0,
				string_0 = "Huyết ảnh Thần Hành Đơn"
			},
			new GStruct58
			{
				int_1 = 1012,
				int_3 = 0,
				string_0 = "Ngự Tuyết Băng Tâm Đơn"
			},
			new GStruct58
			{
				int_1 = 1013,
				int_3 = 800,
				string_0 = "Àọ±ựẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1014,
				int_3 = 800,
				string_0 = "Àọ±ự±ựầẵ"
			},
			new GStruct58
			{
				int_1 = 1015,
				int_3 = 800,
				string_0 = "ÁỳắÅèỡ±ọẫớẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1016,
				int_3 = 800,
				string_0 = "ÁỳắÅèỡ±ọẫớẳẳÄĩìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1017,
				int_3 = 1000,
				string_0 = "ắứẫ±XºÅẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1018,
				int_3 = 800,
				string_0 = "ắứẫ±XºÅìểẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1021,
				int_3 = 800,
				string_0 = "Thúy Ngọc Băng Huyền"
			},
			new GStruct58
			{
				int_1 = 1022,
				int_3 = 800,
				string_0 = "\u00b4ọểủ±ựéỵìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1024,
				int_3 = 400,
				string_0 = "Ngưng Tuyết Hàn Sương"
			},
			new GStruct58
			{
				int_1 = 1025,
				int_3 = 420,
				string_0 = "Phát ra Tri Thù tơ"
			},
			new GStruct58
			{
				int_1 = 1026,
				int_3 = 420,
				string_0 = "ạÅắứẫ±ảắấệ"
			},
			new GStruct58
			{
				int_1 = 1027,
				int_3 = 448,
				string_0 = "Không cử động được"
			},
			new GStruct58
			{
				int_1 = 1029,
				int_3 = 400,
				string_0 = "ẵÊÚÊ23ºÅẻịéẻạặ"
			},
			new GStruct58
			{
				int_1 = 1030,
				int_3 = 180,
				string_0 = "ẵÊÚÊ23ºÅẻịéẻạặìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1031,
				int_3 = 360,
				string_0 = "ẫòÍừẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1032,
				int_3 = 480,
				string_0 = "ÍÂảắậđẳểầ¿"
			},
			new GStruct58
			{
				int_1 = 1033,
				int_3 = 400,
				string_0 = "¿ủÅÊệđÅư5minCD"
			},
			new GStruct58
			{
				int_1 = 1034,
				int_3 = 400,
				string_0 = "ÃÍÅÊầ¿ẽđ5minCD"
			},
			new GStruct58
			{
				int_1 = 1035,
				int_3 = 400,
				string_0 = "éĂÅÊÁữéầà\u00af5minCD"
			},
			new GStruct58
			{
				int_1 = 1036,
				int_3 = 180,
				string_0 = "ÂịººếúNPCạ²ẽớ"
			},
			new GStruct58
			{
				int_1 = 1037,
				int_3 = 180,
				string_0 = "Âịººếúìểà\u00afNPCạ²ẽớ"
			},
			new GStruct58
			{
				int_1 = 1043,
				int_3 = 180,
				string_0 = "La Hán Trận"
			},
			new GStruct58
			{
				int_1 = 1044,
				int_3 = 180,
				string_0 = "Âịººếúìểà\u00afNPCạ²ẽớ"
			},
			new GStruct58
			{
				int_1 = 1045,
				int_3 = 480,
				string_0 = "Cửu Long Tại Thiên"
			},
			new GStruct58
			{
				int_1 = 1046,
				int_3 = 480,
				string_0 = "Song Long Hý Châu"
			},
			new GStruct58
			{
				int_1 = 1047,
				int_3 = 480,
				string_0 = "Đại Phong Khởi Hề"
			},
			new GStruct58
			{
				int_1 = 1048,
				int_3 = 480,
				string_0 = "Tả Tuyền Lam Kiếm Khí"
			},
			new GStruct58
			{
				int_1 = 1049,
				int_3 = 480,
				string_0 = "Hữu Tuyền Lam Kiếm Khí"
			},
			new GStruct58
			{
				int_1 = 1050,
				int_3 = 800,
				string_0 = "Lôi Điện Hạ Lạc"
			},
			new GStruct58
			{
				int_1 = 1051,
				int_3 = 260,
				string_0 = "\u00b4úãỗặð\u00a0õìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1052,
				int_3 = 470,
				string_0 = "Tiêu Diêu Tán"
			},
			new GStruct58
			{
				int_1 = 1053,
				int_3 = 470,
				string_0 = "130"
			},
			new GStruct58
			{
				int_1 = 1054,
				int_3 = 470,
				string_0 = "140"
			},
			new GStruct58
			{
				int_1 = 1055,
				int_3 = 200,
				string_0 = "Đại Lực Kim Cang Chưởng"
			},
			new GStruct58
			{
				int_1 = 1056,
				int_3 = 180,
				string_0 = "Vi Đà Hiến Xử"
			},
			new GStruct58
			{
				int_1 = 1057,
				int_3 = 400,
				string_0 = "Tam Giới Quy Thiền"
			},
			new GStruct58
			{
				int_1 = 1058,
				int_3 = 280,
				string_0 = "Hào Hùng Trảm"
			},
			new GStruct58
			{
				int_1 = 1059,
				int_3 = 72,
				string_0 = "Tung Hoành Bát Hoang"
			},
			new GStruct58
			{
				int_1 = 1060,
				int_3 = 108,
				string_0 = "Bá Vương Tạm Kim"
			},
			new GStruct58
			{
				int_1 = 1061,
				int_3 = 360,
				string_0 = "Kiếm Hoa Vãn Tinh"
			},
			new GStruct58
			{
				int_1 = 1062,
				int_3 = 400,
				string_0 = "Băng Vũ Lạc Tinh"
			},
			new GStruct58
			{
				int_1 = 1063,
				int_3 = 360,
				string_0 = "Băng Tước Hoạt Kỳ"
			},
			new GStruct58
			{
				int_1 = 1064,
				int_3 = 400,
				string_0 = "Băng Ngưng Hàn Yên"
			},
			new GStruct58
			{
				int_1 = 1065,
				int_3 = 240,
				string_0 = "Thủy Anh Man Tú"
			},
			new GStruct58
			{
				int_1 = 1066,
				int_3 = 420,
				string_0 = "Hình Tiêu Cốt Lập"
			},
			new GStruct58
			{
				int_1 = 1067,
				int_3 = 420,
				string_0 = "U Hồn Phệ ảnh"
			},
			new GStruct58
			{
				int_1 = 1068,
				int_3 = 420,
				string_0 = "ểÄằờấẫể°2"
			},
			new GStruct58
			{
				int_1 = 1069,
				int_3 = 360,
				string_0 = "Vô ảnh Xuyên"
			},
			new GStruct58
			{
				int_1 = 1070,
				int_3 = 470,
				string_0 = "Thiết Liên Tứ Sát"
			},
			new GStruct58
			{
				int_1 = 1071,
				int_3 = 360,
				string_0 = "Càn Khôn Nhất Trịch"
			},
			new GStruct58
			{
				int_1 = 1072,
				int_3 = 570,
				string_0 = "Ngũ Diệu Càn Khôn"
			},
			new GStruct58
			{
				int_1 = 1073,
				int_3 = 400,
				string_0 = "Thời Thặng Lục Long"
			},
			new GStruct58
			{
				int_1 = 1074,
				int_3 = 400,
				string_0 = "Bổng Huýnh Lược Địa"
			},
			new GStruct58
			{
				int_1 = 1075,
				int_3 = 60,
				string_0 = "Giang Hải Nộ Lan"
			},
			new GStruct58
			{
				int_1 = 1076,
				int_3 = 570,
				string_0 = "Tật Hỏa Liệu Nguyên"
			},
			new GStruct58
			{
				int_1 = 1077,
				int_3 = 280,
				string_0 = "Hào Hùng Trảm Địa Liệt"
			},
			new GStruct58
			{
				int_1 = 1078,
				int_3 = 470,
				string_0 = "Tạo Hóa Thái Thanh"
			},
			new GStruct58
			{
				int_1 = 1079,
				int_3 = 470,
				string_0 = "Kiếm Thùy Tinh Hà"
			},
			new GStruct58
			{
				int_1 = 1080,
				int_3 = 400,
				string_0 = "Cửu Thiên Cương Phong"
			},
			new GStruct58
			{
				int_1 = 1081,
				int_3 = 470,
				string_0 = "Thiên Lôi Chấn Nhạc"
			},
			new GStruct58
			{
				int_1 = 1082,
				int_3 = 180,
				string_0 = "ÃðìùảẫẫỳàỉÁẹ"
			},
			new GStruct58
			{
				int_1 = 1083,
				int_3 = 200,
				string_0 = "Long Thừa Bát Nhã Thủ"
			},
			new GStruct58
			{
				int_1 = 1084,
				int_3 = 280,
				string_0 = "ºÀéÛếảìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1085,
				int_3 = 400,
				string_0 = "ÍũÚéạộềằìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1086,
				int_3 = 280,
				string_0 = "ºÀéÛếảẫÂ¿ê"
			},
			new GStruct58
			{
				int_1 = 1087,
				int_3 = 72,
				string_0 = "ìíºỏ°ậằÄẫậºƯ"
			},
			new GStruct58
			{
				int_1 = 1088,
				int_3 = 108,
				string_0 = "°ễÍừửẫẵðẫậºƯ"
			},
			new GStruct58
			{
				int_1 = 1089,
				int_3 = 800,
				string_0 = "Kiếm Tâm Tĩnh Điển"
			},
			new GStruct58
			{
				int_1 = 1090,
				int_3 = 400,
				string_0 = "ìẽẻÂ±ựằêẫậºƯ"
			},
			new GStruct58
			{
				int_1 = 1091,
				int_3 = 800,
				string_0 = "Áữãỗằỉẹâ±ựệự"
			},
			new GStruct58
			{
				int_1 = 1092,
				int_3 = 400,
				string_0 = "±ựẩáÂềẹâẫậºƯ"
			},
			new GStruct58
			{
				int_1 = 1093,
				int_3 = 400,
				string_0 = "Khinh Sa Phù Thủy"
			},
			new GStruct58
			{
				int_1 = 1094,
				int_3 = 420,
				string_0 = "éẻẽỳạầÁÂẫậºƯ"
			},
			new GStruct58
			{
				int_1 = 1095,
				int_3 = 420,
				string_0 = "Hồn ảnh Tùng Sanh"
			},
			new GStruct58
			{
				int_1 = 1096,
				int_3 = 420,
				string_0 = "éẻẽỳạầÁÂẫậºƯ2"
			},
			new GStruct58
			{
				int_1 = 1097,
				int_3 = 400,
				string_0 = "Truy Tâm Tỏa Mệnh"
			},
			new GStruct58
			{
				int_1 = 1098,
				int_3 = 400,
				string_0 = "Thiết Sa Xạ Tinh"
			},
			new GStruct58
			{
				int_1 = 1099,
				int_3 = 360,
				string_0 = "ầơÀÔềằệÀ2"
			},
			new GStruct58
			{
				int_1 = 1100,
				int_3 = 360,
				string_0 = "ầơÀÔềằệÀ3"
			},
			new GStruct58
			{
				int_1 = 1101,
				int_3 = 400,
				string_0 = "ấ±³ậÁựÁỳáẵấụ"
			},
			new GStruct58
			{
				int_1 = 1102,
				int_3 = 240,
				string_0 = "ằăìễặđÁóáẵấụ"
			},
			new GStruct58
			{
				int_1 = 1103,
				int_3 = 280,
				string_0 = "Thời Thặng Lục Long Hỏa"
			},
			new GStruct58
			{
				int_1 = 1104,
				int_3 = 420,
				string_0 = "ẳ²ằðÁầễư2"
			},
			new GStruct58
			{
				int_1 = 1105,
				int_3 = 520,
				string_0 = "Kiếm Vũ Diệu Nguyệt"
			},
			new GStruct58
			{
				int_1 = 1106,
				int_3 = 400,
				string_0 = "ễỡằ\u00afèôầồẫậºƯ"
			},
			new GStruct58
			{
				int_1 = 1107,
				int_3 = 470,
				string_0 = "Kiếm Minh Thương Khung"
			},
			new GStruct58
			{
				int_1 = 1108,
				int_3 = 470,
				string_0 = "Phong Minh Ngọc Toái"
			},
			new GStruct58
			{
				int_1 = 1109,
				int_3 = 470,
				string_0 = "Lôi Động Càn Khôn"
			},
			new GStruct58
			{
				int_1 = 1110,
				int_3 = 420,
				string_0 = "Tích Lịch Loạn Hoàn Kích"
			},
			new GStruct58
			{
				int_1 = 1111,
				int_3 = 400,
				string_0 = "Ãễạơệựìểằðầẵ"
			},
			new GStruct58
			{
				int_1 = 1112,
				int_3 = 180,
				string_0 = "ệéễẵPKẩỹẩôẳẳÄĩ+1"
			},
			new GStruct58
			{
				int_1 = 1113,
				int_3 = 420,
				string_0 = "Tích Lịch Loạn Hoàn Hãm Tĩnh"
			},
			new GStruct58
			{
				int_1 = 1114,
				int_3 = 470,
				string_0 = "Ngọc Tuyền Tâm Kinh"
			},
			new GStruct58
			{
				int_1 = 1115,
				int_3 = 400,
				string_0 = "Minh Tâm Kiến Tính"
			},
			new GStruct58
			{
				int_1 = 1120,
				int_3 = 0,
				string_0 = "Kích Công Trợ Lực Hoàn"
			},
			new GStruct58
			{
				int_1 = 1121,
				int_3 = 0,
				string_0 = "Âm Dương Hoạt Huyết Đơn"
			},
			new GStruct58
			{
				int_1 = 1122,
				int_3 = 480,
				string_0 = "ÂíéýẵÊặứ"
			},
			new GStruct58
			{
				int_1 = 1123,
				int_3 = 0,
				string_0 = "Vũ Uy Thuật"
			},
			new GStruct58
			{
				int_1 = 1124,
				int_3 = 0,
				string_0 = "Nhược Thủy Thuật"
			},
			new GStruct58
			{
				int_1 = 1125,
				int_3 = 0,
				string_0 = "Trấn Nhạc Thuật"
			},
			new GStruct58
			{
				int_1 = 1126,
				int_3 = 0,
				string_0 = "Yên Ba Thuật"
			},
			new GStruct58
			{
				int_1 = 1127,
				int_3 = 0,
				string_0 = "Trường Sinh Thuật"
			},
			new GStruct58
			{
				int_1 = 1128,
				int_3 = 0,
				string_0 = "Bột Hải Thuật"
			},
			new GStruct58
			{
				int_1 = 1129,
				int_3 = 0,
				string_0 = "Thần Tuệ Thuật"
			},
			new GStruct58
			{
				int_1 = 1130,
				int_3 = 0,
				string_0 = "Truy ảnh Thuật"
			},
			new GStruct58
			{
				int_1 = 1131,
				int_3 = 60,
				string_0 = "Ma Âm Kích"
			},
			new GStruct58
			{
				int_1 = 1132,
				int_3 = 400,
				string_0 = "ằỉÁƯãẫùÚ"
			},
			new GStruct58
			{
				int_1 = 1133,
				int_3 = 400,
				string_0 = "ằỉÁƯãẫùÚìểẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1134,
				int_3 = 800,
				string_0 = "ẩôặÁéĂẫÁàỗ"
			},
			new GStruct58
			{
				int_1 = 1135,
				int_3 = 400,
				string_0 = "ệĩẫớ±ựẵỹẫớ1"
			},
			new GStruct58
			{
				int_1 = 1136,
				int_3 = 400,
				string_0 = "ệĩẫớảăàóãẫùÚ"
			},
			new GStruct58
			{
				int_1 = 1137,
				int_3 = 100,
				string_0 = "ằỉéýéýãỗonly"
			},
			new GStruct58
			{
				int_1 = 1138,
				int_3 = 100,
				string_0 = "ằỉÁƯéĂẫÁàỗ"
			},
			new GStruct58
			{
				int_1 = 1139,
				int_3 = 400,
				string_0 = "ệĩẫớ±ựẵỹẫớ2"
			},
			new GStruct58
			{
				int_1 = 1140,
				int_3 = 400,
				string_0 = "ệĩẫớ±ựẵỹẫớ3"
			},
			new GStruct58
			{
				int_1 = 1141,
				int_3 = 400,
				string_0 = "ệĩẫớ±ựẵỹẫớ4"
			},
			new GStruct58
			{
				int_1 = 1142,
				int_3 = 400,
				string_0 = "ệ±ẽò±ựÀõ"
			},
			new GStruct58
			{
				int_1 = 1143,
				int_3 = 400,
				string_0 = "ằỉéýéýãỗ"
			},
			new GStruct58
			{
				int_1 = 1144,
				int_3 = 360,
				string_0 = "ằỉéýéýãỗẫÁàỗ"
			},
			new GStruct58
			{
				int_1 = 1145,
				int_3 = 800,
				string_0 = "ệ±ẽò±ựÀõìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1146,
				int_3 = 200,
				string_0 = "\u00b4úÁƯẵðáếếặnpc"
			},
			new GStruct58
			{
				int_1 = 1147,
				int_3 = 180,
				string_0 = "ẻÔÍểẽìốặnpc"
			},
			new GStruct58
			{
				int_1 = 1148,
				int_3 = 400,
				string_0 = "ẩỵẵọạộỡứnpc"
			},
			new GStruct58
			{
				int_1 = 1149,
				int_3 = 280,
				string_0 = "ºÀéÛếảnpc"
			},
			new GStruct58
			{
				int_1 = 1150,
				int_3 = 72,
				string_0 = "ìíºỏ°ậằÄnpc"
			},
			new GStruct58
			{
				int_1 = 1151,
				int_3 = 108,
				string_0 = "°ễÍừửẫẵðnpc"
			},
			new GStruct58
			{
				int_1 = 1152,
				int_3 = 360,
				string_0 = "ẵÊằăÍỡắĐnpc"
			},
			new GStruct58
			{
				int_1 = 1153,
				int_3 = 400,
				string_0 = "±ựểờỗúắĐnpc"
			},
			new GStruct58
			{
				int_1 = 1154,
				int_3 = 360,
				string_0 = "±ựẩáễẵệƯnpc"
			},
			new GStruct58
			{
				int_1 = 1155,
				int_3 = 240,
				string_0 = "ậđể³Âỹéónpc"
			},
			new GStruct58
			{
				int_1 = 1156,
				int_3 = 420,
				string_0 = "éẻẽỳạầÁÂnpc"
			},
			new GStruct58
			{
				int_1 = 1157,
				int_3 = 420,
				string_0 = "ểÄằờấẫể°npc"
			},
			new GStruct58
			{
				int_1 = 1158,
				int_3 = 360,
				string_0 = "ẻịể°\u00b4ânpc"
			},
			new GStruct58
			{
				int_1 = 1159,
				int_3 = 470,
				string_0 = "èỳÁôậÄẫ±npc"
			},
			new GStruct58
			{
				int_1 = 1160,
				int_3 = 360,
				string_0 = "ầơÀÔềằệÀnpc"
			},
			new GStruct58
			{
				int_1 = 1161,
				int_3 = 400,
				string_0 = "ấ±³ậÁựÁỳnpc"
			},
			new GStruct58
			{
				int_1 = 1162,
				int_3 = 400,
				string_0 = "°ụồÄÂểàỉnpc"
			},
			new GStruct58
			{
				int_1 = 1163,
				int_3 = 60,
				string_0 = "ẵưºÊÅưÀẵnpc"
			},
			new GStruct58
			{
				int_1 = 1164,
				int_3 = 570,
				string_0 = "ẳ²ằðÁầễưnpc"
			},
			new GStruct58
			{
				int_1 = 1165,
				int_3 = 470,
				string_0 = "ễỡằ\u00afèôầồnpc"
			},
			new GStruct58
			{
				int_1 = 1166,
				int_3 = 470,
				string_0 = "ẵÊ\u00b4ạéầºểnpc"
			},
			new GStruct58
			{
				int_1 = 1167,
				int_3 = 400,
				string_0 = "ắÅèỡợáãỗnpc"
			},
			new GStruct58
			{
				int_1 = 1168,
				int_3 = 470,
				string_0 = "èỡÀìếðễÀnpc"
			},
			new GStruct58
			{
				int_1 = 1169,
				int_3 = 180,
				string_0 = "Vòng Sáng Long Câu"
			},
			new GStruct58
			{
				int_1 = 1170,
				int_3 = 180,
				string_0 = "Áỳắễạõằãìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1171,
				int_3 = 0,
				string_0 = "Chiến ý Thiên Thu"
			},
			new GStruct58
			{
				int_1 = 1172,
				int_3 = 800,
				string_0 = "éÄéÍẹèằă"
			},
			new GStruct58
			{
				int_1 = 1173,
				int_3 = 600,
				string_0 = "ÃÍ°²éĂếé"
			},
			new GStruct58
			{
				int_1 = 1175,
				int_3 = 420,
				string_0 = "2012ẹèằă1"
			},
			new GStruct58
			{
				int_1 = 1176,
				int_3 = 420,
				string_0 = "2012ẹèằă2"
			},
			new GStruct58
			{
				int_1 = 1177,
				int_3 = 420,
				string_0 = "2012ẹèằă3"
			},
			new GStruct58
			{
				int_1 = 1178,
				int_3 = 400,
				string_0 = "Hồi Xuân"
			},
			new GStruct58
			{
				int_1 = 1179,
				int_3 = 400,
				string_0 = "ẳểẹêẫẽẽịìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1180,
				int_3 = 400,
				string_0 = "Khô Mộc"
			},
			new GStruct58
			{
				int_1 = 1181,
				int_3 = 400,
				string_0 = "ẳừẹêẫẽẽịìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1182,
				int_3 = 400,
				string_0 = "Lưu Vân "
			},
			new GStruct58
			{
				int_1 = 1183,
				int_3 = 400,
				string_0 = "ẳểÅĩậ\u00a0ẫẽà\u00af"
			},
			new GStruct58
			{
				int_1 = 1184,
				int_3 = 400,
				string_0 = "Nê Trạch"
			},
			new GStruct58
			{
				int_1 = 1185,
				int_3 = 400,
				string_0 = "ẳừÅĩậ\u00a0ìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1186,
				int_3 = 50,
				string_0 = "Lôi Hỏa Kiếp"
			},
			new GStruct58
			{
				int_1 = 1187,
				int_3 = 50,
				string_0 = "Lôi Hỏa Kiếp 1"
			},
			new GStruct58
			{
				int_1 = 1188,
				int_3 = 50,
				string_0 = "Lôi Hỏa Kiếp 2"
			},
			new GStruct58
			{
				int_1 = 1189,
				int_3 = 50,
				string_0 = "Lôi Hỏa Kiếp 3"
			},
			new GStruct58
			{
				int_1 = 1193,
				int_3 = 90,
				string_0 = "Thanh Bình Lạc"
			},
			new GStruct58
			{
				int_1 = 1194,
				int_3 = 440,
				string_0 = "Điệp Vũ Hoa Phi"
			},
			new GStruct58
			{
				int_1 = 1195,
				int_3 = 50,
				string_0 = "Mê Túy Thiên Hương"
			},
			new GStruct58
			{
				int_1 = 1196,
				int_3 = 50,
				string_0 = "Mê Túy Thiên Hương 1"
			},
			new GStruct58
			{
				int_1 = 1197,
				int_3 = 50,
				string_0 = "Mê Túy Thiên Hương 2"
			},
			new GStruct58
			{
				int_1 = 1198,
				int_3 = 50,
				string_0 = "Mê Túy Thiên Hương 3"
			},
			new GStruct58
			{
				int_1 = 1201,
				int_3 = 180,
				string_0 = "ẻÔÍểằÔãă"
			},
			new GStruct58
			{
				int_1 = 1202,
				int_3 = 800,
				string_0 = "ầĐệỉÂƠÅÚÊă1-7ẳảÊâ"
			},
			new GStruct58
			{
				int_1 = 1203,
				int_3 = 800,
				string_0 = "ầĐệỉÂƠÅÚÊă\u00b4úếéÊâ"
			},
			new GStruct58
			{
				int_1 = 1204,
				int_3 = 800,
				string_0 = "1-7ẳảÅÚà\u00af±ơếă"
			},
			new GStruct58
			{
				int_1 = 1208,
				int_3 = 440,
				string_0 = "ẹÊễẻấỉẻÀẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1209,
				int_3 = 400,
				string_0 = "±ựả³ấỉẻÀạõằã"
			},
			new GStruct58
			{
				int_1 = 1210,
				int_3 = 400,
				string_0 = "±ựả³ấỉẻÀậÄẽúÍơạộ"
			},
			new GStruct58
			{
				int_1 = 1211,
				int_3 = 180,
				string_0 = "\u00b4ẩºẵấỉẻÀạõằã"
			},
			new GStruct58
			{
				int_1 = 1212,
				int_3 = 400,
				string_0 = "ằðầẵấỉẻÀẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1213,
				int_3 = 600,
				string_0 = "ÁộàỷẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1214,
				int_3 = 400,
				string_0 = "ốẫàỷẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1215,
				int_3 = 600,
				string_0 = "ÃễàỷẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1216,
				int_3 = 420,
				string_0 = "àặàỷ\u00b4úếéềừ²ĩàỉìƯ"
			},
			new GStruct58
			{
				int_1 = 1217,
				int_3 = 420,
				string_0 = "àặàỷ\u00b4úếéềừ²ĩàỉìƯệéẳọ"
			},
			new GStruct58
			{
				int_1 = 1218,
				int_3 = 420,
				string_0 = "àặàỷ\u00b4úếéềừ²ĩàỉìƯàÚảỵ²ó"
			},
			new GStruct58
			{
				int_1 = 1219,
				int_3 = 420,
				string_0 = "ềừ²ĩàỉìƯìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1220,
				int_3 = 0,
				string_0 = "Kim Quyên La Hán"
			},
			new GStruct58
			{
				int_1 = 1221,
				int_3 = 0,
				string_0 = "Chinh Chiến Bát Phương"
			},
			new GStruct58
			{
				int_1 = 1222,
				int_3 = 0,
				string_0 = "Sâm La Độc Hải"
			},
			new GStruct58
			{
				int_1 = 1223,
				int_3 = 0,
				string_0 = "Hấp Tinh trận"
			},
			new GStruct58
			{
				int_1 = 1224,
				int_3 = 0,
				string_0 = "Ba La Tâm Kinh"
			},
			new GStruct58
			{
				int_1 = 1225,
				int_3 = 0,
				string_0 = "Huyền Băng Vô Tức"
			},
			new GStruct58
			{
				int_1 = 1226,
				int_3 = 0,
				string_0 = "Liệt Hỏa Phẫn Thiên"
			},
			new GStruct58
			{
				int_1 = 1227,
				int_3 = 0,
				string_0 = "Ô Y Quyết"
			},
			new GStruct58
			{
				int_1 = 1228,
				int_3 = 0,
				string_0 = "Chân Vũ Thất Tiệt"
			},
			new GStruct58
			{
				int_1 = 1229,
				int_3 = 0,
				string_0 = "Thiên Cương Khất Kính"
			},
			new GStruct58
			{
				int_1 = 1230,
				int_3 = 0,
				string_0 = "Minh Kính Vô Di"
			},
			new GStruct58
			{
				int_1 = 1231,
				int_3 = 0,
				string_0 = "Du Long Chân Khí"
			},
			new GStruct58
			{
				int_1 = 1232,
				int_3 = 420,
				string_0 = "Hồn ảnh Tùng Sanh"
			},
			new GStruct58
			{
				int_1 = 1233,
				int_3 = 0,
				string_0 = "Xác suất hóa giảI sát thương hoàn toàn"
			},
			new GStruct58
			{
				int_1 = 1234,
				int_3 = 400,
				string_0 = "Từ Hàng Phổ D"
			},
			new GStruct58
			{
				int_1 = 1235,
				int_3 = 0,
				string_0 = "Dung Tuyết Vô Tung"
			},
			new GStruct58
			{
				int_1 = 1236,
				int_3 = 0,
				string_0 = "Ma Âm Phệ Phách"
			},
			new GStruct58
			{
				int_1 = 1237,
				int_3 = 0,
				string_0 = "Thiên Hành Khí Công"
			},
			new GStruct58
			{
				int_1 = 1238,
				int_3 = 0,
				string_0 = "Âm Dương Khí Quyết"
			},
			new GStruct58
			{
				int_1 = 1239,
				int_3 = 0,
				string_0 = "Tiên Thiên Cương Khí"
			},
			new GStruct58
			{
				int_1 = 1249,
				int_3 = 0,
				string_0 = "Khôi ẩn - Hắc Thần"
			},
			new GStruct58
			{
				int_1 = 1250,
				int_3 = 440,
				string_0 = "ºÚẫủÍã¿ứìỗệọ"
			},
			new GStruct58
			{
				int_1 = 1251,
				int_3 = 0,
				string_0 = "Tụ ẩn - Hắc Thần"
			},
			new GStruct58
			{
				int_1 = 1252,
				int_3 = 440,
				string_0 = "ºÚẫủằÔÍúìỗệọ"
			},
			new GStruct58
			{
				int_1 = 1262,
				int_3 = 0,
				string_0 = "Càn Khôn Vô Lượng"
			},
			new GStruct58
			{
				int_1 = 1263,
				int_3 = 800,
				string_0 = "ẹèằăéƯểù"
			},
			new GStruct58
			{
				int_1 = 1264,
				int_3 = 0,
				string_0 = "Phong Ma Quyết"
			},
			new GStruct58
			{
				int_1 = 1265,
				int_3 = 440,
				string_0 = "ằÔÍú7ºÅáăệỳ"
			},
			new GStruct58
			{
				int_1 = 1266,
				int_3 = 0,
				string_0 = "Triệt Vũ Phong Thế"
			},
			new GStruct58
			{
				int_1 = 1269,
				int_3 = 400,
				string_0 = "Người Tuyết"
			},
			new GStruct58
			{
				int_1 = 1270,
				int_3 = 400,
				string_0 = "Ông Già Noel"
			},
			new GStruct58
			{
				int_1 = 1271,
				int_3 = 400,
				string_0 = "Thiên Sứ Giáng Sinh"
			},
			new GStruct58
			{
				int_1 = 1272,
				int_3 = 400,
				string_0 = "\u00b4ú°ìéĩ"
			},
			new GStruct58
			{
				int_1 = 1273,
				int_3 = 400,
				string_0 = "<<ẻ\u00b4ãưềở>>"
			},
			new GStruct58
			{
				int_1 = 1274,
				int_3 = 400,
				string_0 = "Tinh Linh"
			},
			new GStruct58
			{
				int_1 = 1275,
				int_3 = 400,
				string_0 = "Heo trắng"
			},
			new GStruct58
			{
				int_1 = 1276,
				int_3 = 400,
				string_0 = "Bạch Hổ "
			},
			new GStruct58
			{
				int_1 = 1278,
				int_3 = 800,
				string_0 = "Äắẩậẽù\u00b4úếăà\u00af3"
			},
			new GStruct58
			{
				int_1 = 1279,
				int_3 = 800,
				string_0 = "Äắẩậẽù\u00b4úếăà\u00af2"
			},
			new GStruct58
			{
				int_1 = 1280,
				int_3 = 800,
				string_0 = "Äắẩậẽù\u00b4úếăà\u00af"
			},
			new GStruct58
			{
				int_1 = 1288,
				int_3 = 800,
				string_0 = "ễẵÄẽàụầđẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1291,
				int_3 = 800,
				string_0 = "ÄờấịÅÚ"
			},
			new GStruct58
			{
				int_1 = 1292,
				int_3 = 800,
				string_0 = "ÄờấịÅÚ±ơếă"
			},
			new GStruct58
			{
				int_1 = 1295,
				int_3 = 180,
				string_0 = "Hồi phục thuộc tính"
			},
			new GStruct58
			{
				int_1 = 1296,
				int_3 = 440,
				string_0 = "Tự hào ý chí chiến đấu"
			},
			new GStruct58
			{
				int_1 = 1297,
				int_3 = 440,
				string_0 = "°Áẩằếẵềõìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1317,
				int_3 = 0,
				string_0 = "Sát khí quyết"
			},
			new GStruct58
			{
				int_1 = 1318,
				int_3 = 0,
				string_0 = "Trường sinh quyết"
			},
			new GStruct58
			{
				int_1 = 1319,
				int_3 = 600,
				string_0 = "Hổ kích"
			},
			new GStruct58
			{
				int_1 = 1320,
				int_3 = 600,
				string_0 = "Xuyên Thạch"
			},
			new GStruct58
			{
				int_1 = 1321,
				int_3 = 0,
				string_0 = "Ngọc Thạch Phiến"
			},
			new GStruct58
			{
				int_1 = 1322,
				int_3 = 400,
				string_0 = "Hư Nhược Vô Lực"
			},
			new GStruct58
			{
				int_1 = 1323,
				int_3 = 0,
				string_0 = "Lăng Phong"
			},
			new GStruct58
			{
				int_1 = 1324,
				int_3 = 440,
				string_0 = "Nhật Nhiên"
			},
			new GStruct58
			{
				int_1 = 1325,
				int_3 = 0,
				string_0 = "Nhật Như Sơn"
			},
			new GStruct58
			{
				int_1 = 1326,
				int_3 = 440,
				string_0 = "Huyết Dũng"
			},
			new GStruct58
			{
				int_1 = 1327,
				int_3 = 0,
				string_0 = "Đẩu Uyển"
			},
			new GStruct58
			{
				int_1 = 1328,
				int_3 = 400,
				string_0 = "Tàn Phong Vân Quyền"
			},
			new GStruct58
			{
				int_1 = 1329,
				int_3 = 0,
				string_0 = "Đoạn Nguyệt"
			},
			new GStruct58
			{
				int_1 = 1330,
				int_3 = 440,
				string_0 = "phiến"
			},
			new GStruct58
			{
				int_1 = 1331,
				int_3 = 0,
				string_0 = "Tâm Tinh Thức"
			},
			new GStruct58
			{
				int_1 = 1332,
				int_3 = 440,
				string_0 = "Vô Ngã"
			},
			new GStruct58
			{
				int_1 = 1333,
				int_3 = 440,
				string_0 = "Kết băng"
			},
			new GStruct58
			{
				int_1 = 1334,
				int_3 = 440,
				string_0 = "ễẵÄẽ9áăệỳ1"
			},
			new GStruct58
			{
				int_1 = 1335,
				int_3 = 440,
				string_0 = "ễẵÄẽ9áăệỳ2"
			},
			new GStruct58
			{
				int_1 = 1336,
				int_3 = 0,
				string_0 = "Vũ Uy Thuật (trùng sinh 6)"
			},
			new GStruct58
			{
				int_1 = 1337,
				int_3 = 0,
				string_0 = "Nhược Thủy Thuật (trùng sinh 6)"
			},
			new GStruct58
			{
				int_1 = 1338,
				int_3 = 0,
				string_0 = "Trấn Sơn Thuật (trùng sinh 6)"
			},
			new GStruct58
			{
				int_1 = 1339,
				int_3 = 0,
				string_0 = "Yên Ba Thuật (trùng sinh 6)"
			},
			new GStruct58
			{
				int_1 = 1340,
				int_3 = 0,
				string_0 = "Trường Sinh Thuật (trùng sinh 6)"
			},
			new GStruct58
			{
				int_1 = 1341,
				int_3 = 0,
				string_0 = "Bá Hải Thuật (trùng sinh 6)"
			},
			new GStruct58
			{
				int_1 = 1342,
				int_3 = 0,
				string_0 = "Thần Tuệ Thuật(trùng sinh 6)"
			},
			new GStruct58
			{
				int_1 = 1343,
				int_3 = 0,
				string_0 = "Truy Cảnh Thuật (trùng sinh 6)"
			},
			new GStruct58
			{
				int_1 = 1344,
				int_3 = 0,
				string_0 = "Càn Khôn Vô Lượng"
			},
			new GStruct58
			{
				int_1 = 1347,
				int_3 = 400,
				string_0 = "Bạch Hồng Quán Nhật"
			},
			new GStruct58
			{
				int_1 = 1348,
				int_3 = 400,
				string_0 = "Vân Chưng Hà úy"
			},
			new GStruct58
			{
				int_1 = 1349,
				int_3 = 0,
				string_0 = "Kiếm Tông Tổng Quyết"
			},
			new GStruct58
			{
				int_1 = 1350,
				int_3 = 0,
				string_0 = "Dưỡng Ngô Kiếm Pháp"
			},
			new GStruct58
			{
				int_1 = 1351,
				int_3 = 480,
				string_0 = "Kim Nhạn Hoành Không"
			},
			new GStruct58
			{
				int_1 = 1352,
				int_3 = 0,
				string_0 = "Hữu Phụng Lai Nghi"
			},
			new GStruct58
			{
				int_1 = 1354,
				int_3 = 0,
				string_0 = "Hi Di Kiếm Pháp"
			},
			new GStruct58
			{
				int_1 = 1355,
				int_3 = 360,
				string_0 = "Thiên Thân Đảo Huyền"
			},
			new GStruct58
			{
				int_1 = 1357,
				int_3 = 0,
				string_0 = "Cao Sơn Lưu Thủy "
			},
			new GStruct58
			{
				int_1 = 1358,
				int_3 = 450,
				string_0 = "Huyễn Nhãn Vân Yên"
			},
			new GStruct58
			{
				int_1 = 1360,
				int_3 = 480,
				string_0 = "Thương Tùng Nghênh Khách"
			},
			new GStruct58
			{
				int_1 = 1361,
				int_3 = 480,
				string_0 = "²ễậẫểư¿Í2"
			},
			new GStruct58
			{
				int_1 = 1362,
				int_3 = 480,
				string_0 = "²ễậẫểư¿Í3"
			},
			new GStruct58
			{
				int_1 = 1363,
				int_3 = 480,
				string_0 = "Thái Nhạc Tam Thanh Phong"
			},
			new GStruct58
			{
				int_1 = 1364,
				int_3 = 0,
				string_0 = "Đoạt Mệnh Liên Hoàn Tam Tiên Kiếm"
			},
			new GStruct58
			{
				int_1 = 1365,
				int_3 = 0,
				string_0 = "Tử Hà Kiếm Khí"
			},
			new GStruct58
			{
				int_1 = 1366,
				int_3 = 0,
				string_0 = "Lạc Nhạn Kinh Hồng"
			},
			new GStruct58
			{
				int_1 = 1368,
				int_3 = 480,
				string_0 = "Độc Cô Cửu Kiếm"
			},
			new GStruct58
			{
				int_1 = 1369,
				int_3 = 0,
				string_0 = "Cửu kiếm hợp nhất"
			},
			new GStruct58
			{
				int_1 = 1370,
				int_3 = 0,
				string_0 = "Hạo Nhiên Chi Khí"
			},
			new GStruct58
			{
				int_1 = 1372,
				int_3 = 400,
				string_0 = "Thanh Vân Tống Sảng"
			},
			new GStruct58
			{
				int_1 = 1373,
				int_3 = 0,
				string_0 = "Kỹ năng vô hiệu Thanh Phong Chiếm Vị"
			},
			new GStruct58
			{
				int_1 = 1374,
				int_3 = 0,
				string_0 = "Long Nhiễu Thân"
			},
			new GStruct58
			{
				int_1 = 1375,
				int_3 = 0,
				string_0 = "Hải Nạp Bách Xuyên"
			},
			new GStruct58
			{
				int_1 = 1376,
				int_3 = 360,
				string_0 = "Long Huyền Kiếm Khí"
			},
			new GStruct58
			{
				int_1 = 1377,
				int_3 = 0,
				string_0 = "Long Huyền Kiếm Khí 2"
			},
			new GStruct58
			{
				int_1 = 1378,
				int_3 = 0,
				string_0 = "Khí Chấn Sơn Hà"
			},
			new GStruct58
			{
				int_1 = 1379,
				int_3 = 0,
				string_0 = "Khí Quán Trường Hồng"
			},
			new GStruct58
			{
				int_1 = 1380,
				int_3 = 360,
				string_0 = "Ma Vân Kiếm Khí"
			},
			new GStruct58
			{
				int_1 = 1381,
				int_3 = 360,
				string_0 = "Kiếm Khí Vô Cấp"
			},
			new GStruct58
			{
				int_1 = 1382,
				int_3 = 380,
				string_0 = "Phách Thạch Phá Ngọc"
			},
			new GStruct58
			{
				int_1 = 1383,
				int_3 = 220,
				string_0 = "Åỹấ\u00afặặểủ2"
			},
			new GStruct58
			{
				int_1 = 1384,
				int_3 = 600,
				string_0 = "Thần Quang Toàn Nhiễu"
			},
			new GStruct58
			{
				int_1 = 1385,
				int_3 = 360,
				string_0 = "ẫủạõéýẩặ2"
			},
			new GStruct58
			{
				int_1 = 1386,
				int_3 = 400,
				string_0 = "³ơẳảảẽằờ\u00b4è"
			},
			new GStruct58
			{
				int_1 = 1388,
				int_3 = 600,
				string_0 = "³ơẳảẻịéẻạặ"
			},
			new GStruct58
			{
				int_1 = 1389,
				int_3 = 180,
				string_0 = "³ơẳảẻịéẻạặìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1390,
				int_3 = 50,
				string_0 = "³ơẳảÂềằãằữ"
			},
			new GStruct58
			{
				int_1 = 1392,
				int_3 = 180,
				string_0 = "³ơẳả±ếễÂãữ³ắ"
			},
			new GStruct58
			{
				int_1 = 1393,
				int_3 = 180,
				string_0 = "³ơẳả±ếễÂãữ³ắìểẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1394,
				int_3 = 400,
				string_0 = "³ơẳả¿ºÁỳểéằÚ"
			},
			new GStruct58
			{
				int_1 = 1395,
				int_3 = 72,
				string_0 = "³ơẳảÁềằðầộèỡ"
			},
			new GStruct58
			{
				int_1 = 1397,
				int_3 = 440,
				string_0 = "³ơẳảặỳéÄãỷ"
			},
			new GStruct58
			{
				int_1 = 1398,
				int_3 = 180,
				string_0 = "³ơẳảÂịººếú"
			},
			new GStruct58
			{
				int_1 = 1399,
				int_3 = 180,
				string_0 = "³ơẳảÂịººếúìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1401,
				int_3 = 72,
				string_0 = "³ơẳả±èºÊ³±ẫỳ"
			},
			new GStruct58
			{
				int_1 = 1402,
				int_3 = 72,
				string_0 = "³ơẳả°ụ\u00b4ũảủạã"
			},
			new GStruct58
			{
				int_1 = 1403,
				int_3 = 400,
				string_0 = "³ơẳảẵÊãẫắêèỡ"
			},
			new GStruct58
			{
				int_1 = 1404,
				int_3 = 400,
				string_0 = "³ơẳảẵÊãẫắêèỡẫậºƯ"
			},
			new GStruct58
			{
				int_1 = 1406,
				int_3 = 600,
				string_0 = "³ơẳảÄĐềụấẫặầ_ẩºèồậổằỳìòả\u00af"
			},
			new GStruct58
			{
				int_1 = 1415,
				int_3 = 400,
				string_0 = "ÁữéầÂềằãằữ"
			},
			new GStruct58
			{
				int_1 = 1416,
				int_3 = 50,
				string_0 = "ÁữéầÂềằãằữìểẳẳÄĩ"
			},
			new GStruct58
			{
				int_1 = 1417,
				int_3 = 75,
				string_0 = "³ơẳảảẽằờ\u00b4èẫậºƯ"
			},
			new GStruct58
			{
				int_1 = 1420,
				int_3 = 480,
				string_0 = "Kiếm Pháp - Thái Nhạc Tam Thanh Phong"
			},
			new GStruct58
			{
				int_1 = 1421,
				int_3 = 480,
				string_0 = "Kiếm pháp - Độc Cô Cửu Kiếm"
			},
			new GStruct58
			{
				int_1 = 1426,
				int_3 = 72,
				string_0 = "Bích Hải Triều Sinh (Kiếm Tiên Lý Bạch)"
			},
			new GStruct58
			{
				int_1 = 1427,
				int_3 = 180,
				string_0 = "Bế Nguyệt Phất Trần (Kiếm Tiên Lý Bạch)"
			},
			new GStruct58
			{
				int_1 = 1428,
				int_3 = 180,
				string_0 = "Kĩ năng Bế Nguyệt Phất Trần (Kiếm Tiên Lý Bạch)"
			},
			new GStruct58
			{
				int_1 = 1443,
				int_3 = 400,
				string_0 = "Tham Lang"
			},
			new GStruct58
			{
				int_1 = 1444,
				int_3 = 400,
				string_0 = "ìứặùẳẳÄĩ1ìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1445,
				int_3 = 400,
				string_0 = "Chiết Cốt"
			},
			new GStruct58
			{
				int_1 = 1446,
				int_3 = 400,
				string_0 = "ìứặùẳẳÄĩ3ìểà\u00af"
			},
			new GStruct58
			{
				int_1 = 1447,
				int_3 = 180,
				string_0 = "Vòng hào quang Thần Lộc"
			},
			new GStruct58
			{
				int_1 = 1453,
				int_3 = 180,
				string_0 = "ệéễẵểẹềờẩỹẩôẳẳÄĩ+1"
			},
			new GStruct58
			{
				int_1 = 1457,
				int_3 = 440,
				string_0 = "ÃÍằÂéƠẹÀàÚềằấẵìỗệọ"
			},
			new GStruct58
			{
				int_1 = 1458,
				int_3 = 0,
				string_0 = "Mãnh Hổ Khiếu Nha chiêu thứ hai"
			},
			new GStruct58
			{
				int_1 = 1459,
				int_3 = 440,
				string_0 = "ÃÍằÂéƠẹÀàÚảỵấẵìỗệọ"
			},
			new GStruct58
			{
				int_1 = 1460,
				int_3 = 0,
				string_0 = "Mãnh Hổ Khiếu Nha chiêu thứ ba"
			},
			new GStruct58
			{
				int_1 = 1461,
				int_3 = 440,
				string_0 = "ÃÍằÂéƠẹÀàÚẩýấẵìỗệọ"
			},
			new GStruct58
			{
				int_1 = 1462,
				int_3 = 0,
				string_0 = "Mãnh Hổ Khiếu Nha chiêu thứ tư"
			},
			new GStruct58
			{
				int_1 = 1463,
				int_3 = 440,
				string_0 = "ÃÍằÂéƠẹÀàÚậÄấẵìỗệọ"
			},
			new GStruct58
			{
				int_1 = 1464,
				int_3 = 0,
				string_0 = "Mãnh Hổ Khiếu Nha chiêu thứ năm"
			},
			new GStruct58
			{
				int_1 = 1465,
				int_3 = 440,
				string_0 = "ÃÍằÂéƠẹÀàÚẻồấẵìỗệọ"
			},
			new GStruct58
			{
				int_1 = 1471,
				int_3 = 800,
				string_0 = "Pháo"
			}
		};
	}
}
