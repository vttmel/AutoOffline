using System;
using System.Threading;
using ns1;
using ns11;
using ns23;
using ns43;
using ns53;
using ns71;
using ns81;
using ns85;

namespace ns35;

internal class Class38
{
	public static string string_0 = "<no name>";

	public static string[] string_1 = new string[2] { "tiÕn hµnh", "®ang" };

	public static string[] string_2 = new string[4] { "Chat('CH_NEARBY', '<color=green>XXX<color=white> YYY <color=red>cõu s\u00b8t<color=white> víi b¹n.')", "<color=white>* <color=green>XXX<color=yellow> YYY <color=red>cõu s\u00b8t<color=yellow> víi b¹n.", "------------------------------------------", "<color=white>* <color=green>KÕt thóc cõu s\u00b8t" };

	public static string string_3 = "Chat('CH_TONG', '<color=green>XXX<color=white> YYY <color=red>cõu s\u00b8t<color=white> víi b¹n.')";

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

	public static uint smethod_1(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		return num3 + num2;
	}

	private static void smethod_2(CharacterAccountConfig characterAccountConfig_0, uint uint_0, int int_0)
	{
		uint num = smethod_1(characterAccountConfig_0);
		Class24.smethod_31(num + uint_0, characterAccountConfig_0.int_137, (uint)int_0);
	}

	private static uint smethod_3(CharacterAccountConfig characterAccountConfig_0, uint uint_0)
	{
		uint num = smethod_1(characterAccountConfig_0);
		return Class24.smethod_30(num + uint_0, characterAccountConfig_0.int_137);
	}

	public static int smethod_4(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_85.uint_0, array, 4, ref int_);
		return BitConverter.ToInt32(array, 0);
	}

	public static string smethod_5(CharacterAccountConfig characterAccountConfig_0)
	{
		string result = string_0;
		if (characterAccountConfig_0.int_137 > 0)
		{
			uint num = smethod_1(characterAccountConfig_0);
			string text = Class24.smethod_28(num + Class56.memorySignatureScanConfig_16.uint_0, characterAccountConfig_0.int_137);
			if (text != "")
			{
				result = text;
			}
		}
		return result;
	}

	public static int smethod_6(CharacterAccountConfig characterAccountConfig_0)
	{
		if (Class56.memorySignatureScanConfig_11.uint_0 != 0 && Class56.memorySignatureScanConfig_23.uint_0 != 0)
		{
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_23.uint_0, characterAccountConfig_0.int_137);
		}
		return 0;
	}

	public static bool smethod_7(CharacterAccountConfig characterAccountConfig_0, ref GStruct45 gstruct45_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_30.uint_0;
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_61.uint_0, characterAccountConfig_0.int_137);
		if (num2 == 0)
		{
			if (gstruct45_0.uint_0 != 0)
			{
				gstruct45_0.uint_0 = 0u;
				gstruct45_0.string_0 = null;
			}
		}
		else if (gstruct45_0.uint_0 != num2)
		{
			gstruct45_0.uint_0 = num2;
			gstruct45_0.uint_1 = Class24.smethod_30(num + 12, characterAccountConfig_0.int_137);
			gstruct45_0.uint_2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_62.uint_0, characterAccountConfig_0.int_137);
			gstruct45_0.string_0 = Class24.smethod_28(num + Class56.memorySignatureScanConfig_60.uint_0, characterAccountConfig_0.int_137, 32);
			gstruct45_0.bool_0 = false;
		}
		return num2 != 0;
	}

	public static int smethod_8(CharacterAccountConfig characterAccountConfig_0, uint uint_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		int int_ = 0;
		byte[] array = new byte[4];
		uint uint_1 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_1, array, 4, ref int_);
		int num4 = BitConverter.ToInt32(array, 0);
		if (num4 > 1)
		{
			int num5 = 0;
			for (int i = 1; i < 256; i++)
			{
				if (num4 <= num5)
				{
					break;
				}
				if (i == num3)
				{
					num5++;
					continue;
				}
				uint num6 = num + (uint)(i * (int)Class56.memorySignatureScanConfig_15.uint_0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				num5++;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) <= 0 || (int)Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137) <= 0)
				{
					continue;
				}
				int num7 = (int)Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
				if (num7 != 10 && num7 != 21)
				{
					int num8 = (int)Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137);
					if (num8 == 1 && uint_0 == Class24.smethod_30(num6, characterAccountConfig_0.int_137))
					{
						return i;
					}
				}
			}
			return 0;
		}
		return 0;
	}

	public static int[] smethod_9(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_32.uint_0, characterAccountConfig_0.int_137);
		if (num == 0)
		{
			return null;
		}
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
		uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num5 = num4 + num3;
		uint num6 = Class24.smethod_30(num5 + 4160, characterAccountConfig_0.int_137);
		uint num7 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_34.uint_0, characterAccountConfig_0.int_137);
		uint num8 = Class24.smethod_30(num7 + num6 * Class56.memorySignatureScanConfig_33.uint_0 + Class56.memorySignatureScanConfig_40.uint_0, characterAccountConfig_0.int_137);
		int[] int_ = null;
		while (num8 != 0)
		{
			uint num9 = Class24.smethod_30(num8 + 4, characterAccountConfig_0.int_137);
			uint num10 = Class24.smethod_30(num8 + 16, characterAccountConfig_0.int_137);
			uint num11 = Class24.smethod_30(Class56.memorySignatureScanConfig_41.uint_0, characterAccountConfig_0.int_137);
			num8 = num9;
			if (num11 == 0)
			{
				continue;
			}
			uint uint_ = num10 * Class56.memorySignatureScanConfig_15.uint_0 + num11 + Class56.memorySignatureScanConfig_42.uint_0;
			uint num12 = Class24.smethod_30(uint_, characterAccountConfig_0.int_137);
			while (num12 != 0)
			{
				uint num13 = Class24.smethod_30(num12 + 4, characterAccountConfig_0.int_137);
				int num14 = (int)Class24.smethod_30(num12 + 24, characterAccountConfig_0.int_137);
				num12 = num13;
				if (num14 > 0 && num14 < 6001)
				{
					Class11.smethod_38(ref int_, num14);
				}
			}
		}
		return int_;
	}

	public static bool smethod_10(CharacterAccountConfig characterAccountConfig_0, uint uint_0)
	{
		if (!characterAccountConfig_0.bool_23)
		{
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
			uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint uint_1 = num3 + num2 + Class56.memorySignatureScanConfig_72.uint_0;
			return Class24.smethod_31(uint_1, characterAccountConfig_0.int_137, uint_0);
		}
		return true;
	}

	public static void smethod_11(CharacterAccountConfig characterAccountConfig_0, int int_0, uint uint_0 = 0u)
	{
		uint uint_1 = 5u;
		uint uint_2 = uint.MaxValue;
		uint uint_3 = uint_0;
		uint num = smethod_1(characterAccountConfig_0);
		if (uint_0 == 0)
		{
			uint_2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137);
			uint_3 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137);
		}
		Class24.smethod_31(num + Class56.memorySignatureScanConfig_37.uint_0, characterAccountConfig_0.int_137, uint_2);
		Class24.smethod_31(num + Class56.memorySignatureScanConfig_38.uint_0, characterAccountConfig_0.int_137, uint_3);
		Class24.smethod_31(num + Class56.memorySignatureScanConfig_36.uint_0, characterAccountConfig_0.int_137, (uint)int_0);
		Class24.smethod_31(num + Class56.memorySignatureScanConfig_35.uint_0, characterAccountConfig_0.int_137, uint_1);
	}

	public static string smethod_12(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = smethod_1(characterAccountConfig_0);
		string result = "";
		if (characterAccountConfig_0.int_137 > 0 && num != 0)
		{
			result = Class24.smethod_28(num + Class56.memorySignatureScanConfig_89.uint_0, characterAccountConfig_0.int_137, 32);
		}
		return result;
	}

	public static uint smethod_13(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
		return Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_88.uint_0, characterAccountConfig_0.int_137);
	}

	public static int smethod_14(CharacterAccountConfig characterAccountConfig_0, uint uint_0 = 0u, uint uint_1 = 0u)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = 0u;
		num2 = ((uint_1 != 0) ? (uint_0 switch
		{
			0u => Class56.memorySignatureScanConfig_78.uint_0, 
			1u => Class56.memorySignatureScanConfig_80.uint_0, 
			2u => Class56.memorySignatureScanConfig_82.uint_0, 
			_ => Class56.memorySignatureScanConfig_84.uint_0, 
		}) : (uint_0 switch
		{
			0u => Class56.memorySignatureScanConfig_77.uint_0, 
			1u => Class56.memorySignatureScanConfig_79.uint_0, 
			2u => Class56.memorySignatureScanConfig_81.uint_0, 
			_ => Class56.memorySignatureScanConfig_83.uint_0, 
		}));
		return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_12.uint_0 + num2, characterAccountConfig_0.int_137);
	}

	public static int smethod_15(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_76.uint_0, characterAccountConfig_0.int_137);
	}

	public static int smethod_16(CharacterAccountConfig characterAccountConfig_0)
	{
		uint uint_ = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		return (int)Class24.smethod_30(uint_, characterAccountConfig_0.int_137);
	}

	public static int smethod_17(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
	}

	public static bool smethod_18(CharacterAccountConfig characterAccountConfig_0)
	{
		if (Class56.memorySignatureScanConfig_105.uint_0 != 0 && Class56.memorySignatureScanConfig_106.uint_0 != 0 && Class56.memorySignatureScanConfig_110.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_);
			uint num = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array2, 0);
			int num3 = Class85.smethod_4(characterAccountConfig_0);
			int num4 = 0;
			for (uint num5 = 1u; num5 < Class56.int_1; num5++)
			{
				if (num3 <= num4)
				{
					break;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + (num5 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_);
				uint num6 = BitConverter.ToUInt32(array2, 0);
				if (num6 == 0)
				{
					continue;
				}
				uint num7 = num2 + num6 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				num4++;
				uint num8 = num + num5 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
				if (array[0] == 2)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_110.uint_0, array, 1, ref int_);
					uint num9 = array[0];
					if (num9 == 10)
					{
						return true;
					}
				}
			}
			return false;
		}
		return false;
	}

	public static bool smethod_19(CharacterAccountConfig characterAccountConfig_0)
	{
		int num = (int)smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_44.uint_0);
		return num > 0;
	}

	public static long smethod_20(CharacterAccountConfig characterAccountConfig_0)
	{
		return smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_45.uint_0);
	}

	public static long smethod_21(CharacterAccountConfig characterAccountConfig_0)
	{
		return smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_47.uint_0);
	}

	public static long smethod_22(CharacterAccountConfig characterAccountConfig_0)
	{
		return smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_47.uint_0 + 4);
	}

	public static long smethod_23(CharacterAccountConfig characterAccountConfig_0)
	{
		return smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_46.uint_0);
	}

	public static long smethod_24(CharacterAccountConfig characterAccountConfig_0)
	{
		return smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_48.uint_0);
	}

	public static long smethod_25(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_12.uint_0;
		int int_ = 0;
		byte[] array = new byte[8];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_24.uint_0, array, 8, ref int_);
		return BitConverter.ToInt64(array, 0);
	}

	public static long smethod_26(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_12.uint_0;
		int int_ = 0;
		byte[] array = new byte[8];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_24.uint_0 + 8, array, 8, ref int_);
		return BitConverter.ToInt64(array, 0);
	}

	public static int smethod_27(CharacterAccountConfig characterAccountConfig_0)
	{
		return (int)smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_43.uint_0);
	}

	public static int smethod_28(CharacterAccountConfig characterAccountConfig_0)
	{
		return (int)smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_50.uint_0);
	}

	public static int smethod_29(CharacterAccountConfig characterAccountConfig_0)
	{
		return (int)smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_53.uint_0);
	}

	public static uint[] smethod_30(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0);
		uint num2 = smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0);
		if (num != 0 && num2 != 0)
		{
			return new uint[2] { num, num2 };
		}
		return null;
	}

	public static int smethod_31(CharacterAccountConfig characterAccountConfig_0)
	{
		return (int)smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_55.uint_0);
	}

	public static int smethod_32(CharacterAccountConfig characterAccountConfig_0)
	{
		return (int)smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_66.uint_0);
	}

	public static int smethod_33(CharacterAccountConfig characterAccountConfig_0)
	{
		int num = (int)smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_54.uint_0);
		if (num > 4)
		{
			num = 5;
		}
		return num;
	}

	public static int smethod_34(CharacterAccountConfig characterAccountConfig_0)
	{
		return (int)smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_51.uint_0);
	}

	public static int smethod_35(CharacterAccountConfig characterAccountConfig_0)
	{
		return (int)smethod_3(characterAccountConfig_0, Class56.memorySignatureScanConfig_56.uint_0);
	}

	public static bool smethod_36(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_30.uint_0 + Class56.memorySignatureScanConfig_62.uint_0, characterAccountConfig_0.int_137);
		return num2 == 2;
	}

	public static uint smethod_37(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		return Class24.smethod_30(num + Class56.memorySignatureScanConfig_30.uint_0 + Class56.memorySignatureScanConfig_61.uint_0, characterAccountConfig_0.int_137);
	}

	public static int smethod_38(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_30.uint_0 + Class56.memorySignatureScanConfig_61.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		int int_ = 0;
		byte[] array = new byte[4];
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 4, ref int_);
		int num4 = BitConverter.ToInt32(array, 0);
		if (num4 > 1)
		{
			int num5 = (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
			int num6 = 0;
			for (uint num7 = 1u; num7 < 256; num7++)
			{
				if (num4 <= num6)
				{
					break;
				}
				if (num7 == num5)
				{
					num6++;
					continue;
				}
				uint num8 = num3 + num7 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				num6++;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) > 0)
				{
					uint num9 = Class24.smethod_30(num8, characterAccountConfig_0.int_137);
					if (num9 == num2)
					{
						return (int)num7;
					}
				}
			}
			return 0;
		}
		return 0;
	}

	public static int smethod_39(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint uint_ = num + Class56.memorySignatureScanConfig_30.uint_0 + Class56.memorySignatureScanConfig_65.uint_0;
		return (int)Class24.smethod_30(uint_, characterAccountConfig_0.int_137);
	}

	public static string smethod_40(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		return Class24.smethod_28(num + Class56.memorySignatureScanConfig_30.uint_0 + Class56.memorySignatureScanConfig_60.uint_0, characterAccountConfig_0.int_137, 32);
	}

	public static uint smethod_41(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = false)
	{
		uint uint_ = Class56.memorySignatureScanConfig_73.uint_0;
		if (bool_0)
		{
			uint_ = Class56.memorySignatureScanConfig_74.uint_0;
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_12.uint_0;
		uint uint_2 = num + Class56.memorySignatureScanConfig_75.uint_0 + uint_;
		return Class24.smethod_30(uint_2, characterAccountConfig_0.int_137);
	}

	public static void smethod_42(CharacterAccountConfig characterAccountConfig_0, uint uint_0, bool bool_0 = true)
	{
		uint uint_1 = Class56.memorySignatureScanConfig_74.uint_0;
		if (bool_0)
		{
			uint_1 = Class56.memorySignatureScanConfig_73.uint_0;
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_12.uint_0;
		uint uint_2 = num + Class56.memorySignatureScanConfig_75.uint_0 + uint_1;
		Class24.smethod_31(uint_2, characterAccountConfig_0.int_137, uint_0);
	}

	public static int[] smethod_43(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		return new int[2]
		{
			(int)Class24.smethod_30((uint)((int)(num + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_76.uint_0) + int_0 * 4 + 8), characterAccountConfig_0.int_137),
			(int)Class24.smethod_30((uint)((int)(num + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_76.uint_0) + int_0 * 4 + 32), characterAccountConfig_0.int_137)
		};
	}

	public static int smethod_44(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		return (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_76.uint_0, characterAccountConfig_0.int_137);
	}

	public static bool smethod_45(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_96.uint_0, characterAccountConfig_0.int_137);
		return num != 0;
	}

	public static int smethod_46(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		uint num = Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_2.uint_0 + (uint)((int)Class56.memorySignatureScanConfig_3.uint_0 * int_0);
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num5 = num4 + num3 * Class56.memorySignatureScanConfig_15.uint_0;
		return (int)Class24.smethod_30(num5 + num, characterAccountConfig_0.int_137);
	}

	public static bool smethod_47(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
		int num5 = 0;
		for (uint num6 = 0u; num6 < 6; num6++)
		{
			uint num7 = Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_2.uint_0 + Class56.memorySignatureScanConfig_3.uint_0 * num6;
			int num8 = (int)Class24.smethod_30(num4 + num7 + 20, characterAccountConfig_0.int_137);
			if (num8 == 1)
			{
				num5++;
			}
		}
		return num5 > 5;
	}

	public static bool smethod_48(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
		int int_ = 0;
		byte[] array = new byte[1];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_38.uint_0 + 4, array, 1, ref int_);
		return array[0] > 0;
	}

	public static string smethod_49(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = smethod_1(characterAccountConfig_0);
		if (characterAccountConfig_0.int_137 != 0 && num != 0)
		{
			byte[] array = new byte[80];
			int int_ = 0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_89.uint_0, array, array.Length, ref int_);
			return Class1.smethod_3(array);
		}
		return string.Empty;
	}

	public static void smethod_50(CharacterAccountConfig characterAccountConfig_0, string string_4)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2;
		if (characterAccountConfig_0.int_137 == 0 || num4 == 0)
		{
			return;
		}
		byte[] array = new byte[4];
		byte[] array2 = array;
		if (string_4 != "")
		{
			char[] array3 = string_4.ToCharArray();
			array2 = new byte[array3.Length + 1];
			for (int i = 0; i < array3.Length; i++)
			{
				array2[i] = (byte)array3[i];
			}
			array2[array2.Length - 1] = 0;
		}
		int int_ = 0;
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_89.uint_0, array2, array2.Length, ref int_);
	}

	public static void smethod_51(CharacterAccountConfig characterAccountConfig_0, int int_0 = 75)
	{
		smethod_2(characterAccountConfig_0, Class56.memorySignatureScanConfig_31.uint_0, int_0);
	}

	public static void smethod_52(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		smethod_2(characterAccountConfig_0, Class56.memorySignatureScanConfig_43.uint_0, int_0);
	}

	public static void smethod_53(CharacterAccountConfig characterAccountConfig_0, int int_0 = 0)
	{
		smethod_2(characterAccountConfig_0, Class56.memorySignatureScanConfig_56.uint_0, int_0);
	}

	public static void smethod_54(CharacterAccountConfig characterAccountConfig_0, uint[] uint_0, bool bool_0, int int_0 = 10)
	{
		if (!bool_0 && (uint_0 == null || uint_0[0] == 0 || uint_0[1] == 0))
		{
			return;
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
		int i = 0;
		int int_1 = 0;
		byte[] array = new byte[4];
		byte[] byte_ = array;
		for (; i < int_0; i++)
		{
			if (bool_0)
			{
				uint num5 = Class46.characterSyncSnapshot_0.uint_5 >> 16;
				uint int_2 = Class46.characterSyncSnapshot_0.uint_5 - (num5 << 16);
				uint_0 = Class89.smethod_11(Class46.characterSyncSnapshot_0.uint_4, (int)int_2, (int)num5);
			}
			if (uint_0 != null && uint_0[0] != 0 && uint_0[1] != 0)
			{
				if (uint_0 != null)
				{
					Class75.smethod_61(characterAccountConfig_0, uint_0);
					Thread.Sleep(200);
				}
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_1);
				uint[] uint_1 = new uint[2]
				{
					Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
				if (smethod_0(uint_1, uint_0) < 11250)
				{
					break;
				}
				continue;
			}
			break;
		}
	}

	public static void smethod_55(CharacterAccountConfig characterAccountConfig_0)
	{
		for (int i = 0; i < 80; i++)
		{
			if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_6, 4) <= 0)
			{
				break;
			}
			Thread.Sleep(10);
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
		int int_ = 0;
		byte[] array = new byte[4];
		byte[] byte_ = array;
		array = new byte[4];
		byte[] byte_2 = array;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_31.uint_0, byte_2, 4, ref int_);
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(75), 4, ref int_);
		uint uint_ = 5u;
		uint uint_2 = Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137);
		uint uint_3 = Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137);
		for (int j = 0; j < 3; j++)
		{
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_);
			Thread.Sleep(10);
			Class24.smethod_31(num4 + Class56.memorySignatureScanConfig_37.uint_0, characterAccountConfig_0.int_137, uint_2);
			Class24.smethod_31(num4 + Class56.memorySignatureScanConfig_38.uint_0, characterAccountConfig_0.int_137, uint_3);
			Class24.smethod_31(num4 + Class56.memorySignatureScanConfig_36.uint_0, characterAccountConfig_0.int_137, 715u);
			Class24.smethod_31(num4 + Class56.memorySignatureScanConfig_35.uint_0, characterAccountConfig_0.int_137, uint_);
			Thread.Sleep(210 - j * 100);
		}
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_31.uint_0, byte_2, 4, ref int_);
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_35.uint_0, byte_, 4, ref int_);
	}

	public static bool smethod_56(CharacterAccountConfig characterAccountConfig_0)
	{
		for (int i = 0; i < 80; i++)
		{
			if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_6, 4) <= 0)
			{
				break;
			}
			Thread.Sleep(10);
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
		int int_ = 0;
		byte[] array = new byte[4];
		for (uint num5 = 0u; num5 < 6; num5++)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_2.uint_0 + Class56.memorySignatureScanConfig_3.uint_0 * num5, array, 4, ref int_);
			int num6 = BitConverter.ToInt32(array, 0);
			if (num6 == 122)
			{
				return true;
			}
		}
		byte[] array2 = new byte[4];
		byte[] byte_ = array2;
		byte[] byte_2 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_31.uint_0, byte_2, 4, ref int_);
		int j = 0;
		int num7 = -1;
		for (; j < 150; j++)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_55.uint_0, array, 1, ref int_);
			if (array[0] < 4 && (num7 == -1 || num7 > 80))
			{
				break;
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_);
			num7 = ((array[0] <= 3) ? (num7 + 1) : 0);
			Thread.Sleep(1);
		}
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_31.uint_0, byte_, 4, ref int_);
		byte[] byte_3 = new byte[4] { 5, 0, 0, 0 };
		byte[] bytes = BitConverter.GetBytes(716);
		byte[] byte_4 = new byte[4];
		byte[] byte_5 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, byte_4, 4, ref int_);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, byte_5, 4, ref int_);
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_37.uint_0, byte_4, 4, ref int_);
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_38.uint_0, byte_5, 4, ref int_);
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_36.uint_0, bytes, bytes.Length, ref int_);
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_35.uint_0, byte_3, 4, ref int_);
		Thread.Sleep(100);
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_31.uint_0, byte_2, 4, ref int_);
		return false;
	}

	public static void smethod_57(CharacterAccountConfig characterAccountConfig_0, string string_4)
	{
		uint num = smethod_1(characterAccountConfig_0);
		if (characterAccountConfig_0.int_137 != 0 && num != 0 && Class56.memorySignatureScanConfig_251.uint_0 != 0)
		{
			byte[] array = Class11.smethod_47(string_4);
			int int_ = 0;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_251.uint_0, array, array.Length, ref int_);
		}
	}

	public static uint smethod_58(CharacterAccountConfig characterAccountConfig_0, int[] int_0)
	{
		if (int_0 == null)
		{
			int_0 = new int[1] { 1 };
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
		uint num5 = Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_72.uint_0, characterAccountConfig_0.int_137);
		if ((int)num5 > 0)
		{
			uint num6 = num3 + num5 * Class56.memorySignatureScanConfig_15.uint_0;
			if (Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137) == 0)
			{
				return 0u;
			}
			int num7 = (int)Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137);
			int num8 = 0;
			while (true)
			{
				if (num8 < int_0.Length)
				{
					if (num7 == int_0[num8])
					{
						break;
					}
					num8++;
					continue;
				}
				return 0u;
			}
			return num5;
		}
		return 0u;
	}
}
