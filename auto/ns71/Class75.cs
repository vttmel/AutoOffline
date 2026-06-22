using System;
using System.Threading;
using ns1;
using ns11;
using ns146;
using ns23;
using ns35;
using ns36;
using ns52;
using ns53;
using ns63;
using ns80;
using ns81;
using ns85;

namespace ns71;

internal class Class75
{
	public static uint uint_0 = 65536u;

	public static uint uint_1 = 512u;

	private static uint uint_2 = 256u;

	private static uint uint_3 = 256u;

	private static uint uint_4 = 256u;

	public static uint uint_5 = 1u;

	public static uint uint_6 = 2u;

	public static uint uint_7 = 3u;

	public static uint uint_8 = 4u;

	public static uint uint_9 = 5u;

	public static uint uint_10 = 6u;

	public static uint uint_11 = 7u;

	public static uint uint_12 = 8u;

	public static uint uint_13 = 9u;

	public static uint uint_14 = 10u;

	public static uint uint_15 = 11u;

	public static uint uint_16 = 12u;

	public static uint uint_17 = 15u;

	public static uint uint_18 = 16u;

	public static uint uint_19 = 18u;

	public static uint uint_20 = 20u;

	public static uint uint_21 = 22u;

	public static uint uint_22 = 24u;

	public static uint uint_23 = 25u;

	public static uint uint_24 = 26u;

	public static uint uint_25 = 27u;

	public static uint uint_26 = 29u;

	public static uint uint_27 = 32u;

	public static uint uint_28 = 33u;

	public static uint uint_29 = 34u;

	public static uint uint_30 = 35u;

	public static uint uint_31 = 36u;

	public static uint uint_32 = 37u;

	public static uint uint_33 = 39u;

	public static uint uint_34 = 40u;

	public static uint uint_35 = 41u;

	public static uint uint_36 = 48u;

	public static uint uint_37 = 50u;

	public static uint uint_38 = 64u;

	public static uint uint_39 = 66u;

	public static uint uint_40 = 67u;

	public static uint uint_41 = 68u;

	public static uint uint_42 = 69u;

	public static uint uint_43 = 70u;

	public static uint uint_44 = 71u;

	public static uint uint_45 = 72u;

	public static uint uint_46 = 75u;

	public static uint uint_47 = 76u;

	public static uint uint_48 = 78u;

	public static uint uint_49 = 79u;

	public static uint uint_50 = 80u;

	public static uint uint_51 = 96u;

	public static uint uint_52 = 256u;

	public static uint uint_53 = 0u;

	public static void smethod_0(CharacterAccountConfig characterAccountConfig_0, uint uint_54)
	{
		DateTime now = DateTime.Now;
		int int_ = now.Second + now.Minute * 60 + now.Hour * 60 * 60;
		smethod_2(characterAccountConfig_0, uint_54, int_, 4);
	}

	public static int smethod_1(CharacterAccountConfig characterAccountConfig_0, uint uint_54)
	{
		DateTime now = DateTime.Now;
		int num = now.Second + now.Minute * 60 + now.Hour * 60 * 60;
		int num2 = smethod_3(characterAccountConfig_0, uint_54, 4);
		return Math.Abs(num2 - num);
	}

	public static void smethod_2(CharacterAccountConfig characterAccountConfig_0, uint uint_54, int int_0, byte byte_0 = 4)
	{
		int int_1 = 0;
		byte[] bytes = BitConverter.GetBytes(int_0);
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + uint_54 * 4, bytes, byte_0, ref int_1);
	}

	public static int smethod_3(CharacterAccountConfig characterAccountConfig_0, uint uint_54, byte byte_0 = 4)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + uint_54 * 4, array, 4, ref int_);
		if (byte_0 > 3 && (array[1] > 0 || array[2] > 0 || array[3] > 0))
		{
			return BitConverter.ToInt32(array, 0);
		}
		return array[0];
	}

	public static uint smethod_4(uint uint_54, uint uint_55, uint uint_56, uint uint_57)
	{
		long num = (int)(uint_54 - uint_56);
		long num2 = (int)(uint_55 - uint_57);
		return (uint)(num * num + num2 * num2);
	}

	private static void smethod_5(int int_0, uint uint_54, byte[] byte_0)
	{
		int int_1 = 0;
		Class24.WriteProcessMemory(int_0, uint_54, byte_0, byte_0.Length, ref int_1);
	}

	private static void smethod_6(int int_0, uint uint_54, string string_0, bool bool_0 = true)
	{
		byte[] byte_ = Class11.smethod_47(string_0, bool_0);
		smethod_5(int_0, uint_54, byte_);
	}

	public static bool smethod_7(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0);
		uint num3 = num2 * Class56.memorySignatureScanConfig_15.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
		uint num4 = BitConverter.ToUInt32(array, 0);
		uint num5 = num4 + num3;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_);
		int num6 = BitConverter.ToInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
		int num7 = BitConverter.ToInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
		int num8 = BitConverter.ToInt32(array, 0);
		int num9 = Class89.smethod_39(characterAccountConfig_0);
		return num7 > 0 && num8 > 0 && num6 > 0 && num9 > 1;
	}

	public static void smethod_8(ref CharacterAccountConfig characterAccountConfig_0)
	{
		if (uint_53 == 0)
		{
			uint num = Class24.smethod_37(Class24.smethod_56(), "ntdll.dll");
			uint_53 = Class24.GetProcAddress(num, "RtlExitUserThread");
		}
		characterAccountConfig_0.uint_18 = 4096u;
		characterAccountConfig_0.uint_98 = smethod_9(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_51 = smethod_60(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_88 = smethod_62(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_84 = smethod_56(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_81 = smethod_53(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_82 = smethod_51(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_83 = smethod_49(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_43 = smethod_47(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_44 = smethod_45(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_46 = smethod_42(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_71 = smethod_40(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_60 = smethod_86(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_62 = smethod_36(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_61 = smethod_34(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_56 = smethod_33(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_40 = smethod_30(ref characterAccountConfig_0, bool_0: false);
		characterAccountConfig_0.uint_41 = smethod_30(ref characterAccountConfig_0, bool_0: true);
		characterAccountConfig_0.uint_78 = smethod_23(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_79 = smethod_24(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_58 = smethod_19(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_59 = smethod_21(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_90 = smethod_101(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_92 = smethod_17(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_67 = smethod_90(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_68 = smethod_91(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_69 = smethod_92(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_70 = smethod_93(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_94 = smethod_74(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_95 = smethod_15(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_96 = smethod_72(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_53 = smethod_81(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_54 = smethod_82(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_55 = smethod_78(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_42 = smethod_79(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_45 = smethod_83(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_47 = smethod_70(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_49 = smethod_68(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_48 = smethod_66(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_91 = smethod_65(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_50 = smethod_84(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_57 = smethod_98(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_63 = smethod_85(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_64 = smethod_88(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_66 = smethod_87(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_65 = smethod_89(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_72 = smethod_94(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_80 = smethod_97(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_77 = smethod_25(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_85 = smethod_76(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_86 = smethod_77(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_87 = smethod_99(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_89 = smethod_100(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_97 = smethod_13(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_73 = smethod_95(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_74 = smethod_96(ref characterAccountConfig_0);
		characterAccountConfig_0.uint_75 = smethod_58(ref characterAccountConfig_0, 0);
		characterAccountConfig_0.uint_76 = smethod_58(ref characterAccountConfig_0, 1);
	}

	private static uint smethod_9(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = uint_53 - (num + 8);
		string string_ = "33 C0 50E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0);
	}

	public static string smethod_10(uint uint_54)
	{
		string result = "C3";
		if (uint_54 != 0 && uint_53 != 0)
		{
			result = "3EC70424" + Class11.smethod_46(uint_54, 8, bool_1: false, bool_2: true) + "C3";
		}
		return result;
	}

	public static uint smethod_11(ref CharacterAccountConfig characterAccountConfig_0, uint uint_54, string string_0, string string_1 = "", uint uint_55 = 0u)
	{
		if (characterAccountConfig_0.uint_17 == 0)
		{
			return 0u;
		}
		string text = smethod_10(characterAccountConfig_0.uint_98);
		uint num = (uint)(text.Length / 2 - 1);
		byte[] array = Class11.smethod_8("60" + string_0 + "E8 00 00 00 00" + string_1 + "61" + text);
		int int_ = 204;
		uint num2 = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array, array.Length, ref int_);
		int num3 = string_1.Replace(" ", "").Length / 2;
		uint num4 = characterAccountConfig_0.uint_7;
		if (uint_55 != 0)
		{
			num4 = uint_55;
		}
		uint num5 = num4 + uint_54;
		uint num6 = (uint)((int)num2 + array.Length - num3 - 2) - num;
		uint num7 = num5 - num6;
		uint num8 = (uint)((int)num2 + array.Length - num3 - 6) - num;
		Class24.smethod_31(num8, characterAccountConfig_0.int_137, num7);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num2;
	}

	public static bool smethod_12(int int_0, uint uint_54)
	{
		if (int_0 != 0 && uint_54 != 0)
		{
			uint num = 0u;
			uint num2 = Class24.CreateRemoteThread(int_0, IntPtr.Zero, 0u, uint_54, 0u, 0u, out num);
			if (num2 != 0)
			{
				Class24.WaitForSingleObject(num2, 1000u);
				Class24.smethod_32((int)num2);
			}
			return num != 0;
		}
		return false;
	}

	private static uint smethod_13(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		string string_ = "6A 00 6A 01";
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_90.uint_0, string_, "83 C4 08");
	}

	public static bool smethod_14(CharacterAccountConfig characterAccountConfig_0, bool bool_0)
	{
		if (characterAccountConfig_0.uint_97 != 0)
		{
			int int_ = 0;
			byte[] byte_ = new byte[1] { Convert.ToByte(bool_0) };
			if (!Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_97 + 4, byte_, 1, ref int_))
			{
				return false;
			}
			return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_97);
		}
		return false;
	}

	private static uint smethod_15(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_196.uint_0 - (num + 32);
		string string_ = "60BA C8283F1581C2" + Class11.smethod_46(Class56.memorySignatureScanConfig_205.uint_0, 8, bool_1: false, bool_2: true) + "B8 010000008B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_224.uint_0, 8, bool_1: false, bool_2: true) + "5052 6A 05E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "61" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_196.uint_0 != 0 && Class56.memorySignatureScanConfig_224.uint_0 != 0);
	}

	public static bool smethod_16(CharacterAccountConfig characterAccountConfig_0, uint uint_54, byte byte_0 = 0)
	{
		if (characterAccountConfig_0.uint_95 != 0)
		{
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(uint_54);
			bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_95 + 2, bytes, bytes.Length, ref int_);
			if (byte_0 != 1)
			{
				byte_0 = 0;
			}
			bytes = new byte[1] { byte_0 };
			bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_95 + 13, bytes, 1, ref int_);
			if (flag && flag2)
			{
				return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_95);
			}
			return false;
		}
		return false;
	}

	private static uint smethod_17(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		string string_ = "60BE 184D4028BF 2BBC418BBB 010000008B0D" + Class11.smethod_46(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_197.uint_0, 8, bool_1: false, bool_2: true) + "8B 01 8B 50 3C 6A 00 56 57 53 FF D261" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_197.uint_0 != 0);
	}

	public static bool smethod_18(CharacterAccountConfig characterAccountConfig_0, object object_0)
	{
		if (characterAccountConfig_0.uint_92 != 0 && object_0 != null)
		{
			uint num = Class11.smethod_12(object_0.ToString());
			if (num == 0)
			{
				num = Class11.smethod_6(object_0.ToString());
				if (num == 0)
				{
					return false;
				}
			}
			int int_ = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[4];
			byte[] byte_ = new byte[4];
			byte[] bytes = BitConverter.GetBytes(num);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
			uint num3 = BitConverter.ToUInt32(array, 0);
			uint num4 = num3 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
			uint num5 = BitConverter.ToUInt32(array, 0);
			uint num6 = num5 + num4;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_88.uint_0, array2, 4, ref int_);
			if (BitConverter.ToUInt32(array2, 0) != 0)
			{
				uint num7 = num2 + Class56.memorySignatureScanConfig_189.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + 40, byte_, 4, ref int_);
				bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_92 + 2, bytes, bytes.Length, ref int_);
				bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_92 + 7, array2, 4, ref int_);
				bool flag3 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_92 + 12, byte_, 4, ref int_);
				if (flag && flag2 && flag3)
				{
					return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_92);
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private static uint smethod_19(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_237.uint_0 - (num + 38);
		string string_ = "60B8" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 25 C6 00 018B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_236.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 11 B8 00 00 00 00 55 89 E5 50E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_237.uint_0 != 0 && Class56.memorySignatureScanConfig_236.uint_0 != 0);
	}

	public static bool smethod_20(CharacterAccountConfig characterAccountConfig_0, uint uint_54)
	{
		if (characterAccountConfig_0.uint_58 != 0 && smethod_7(characterAccountConfig_0))
		{
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(uint_54);
			if (!Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_58 + 25, bytes, bytes.Length, ref int_))
			{
				return false;
			}
			return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_58);
		}
		return false;
	}

	private static uint smethod_21(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 8u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_238.uint_0 - (num + 44);
		string string_ = "60B8" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 2F C6 00 01A1" + Class11.smethod_46(Class56.memorySignatureScanConfig_105.uint_0, 8, bool_1: false, bool_2: true) + "85 C0 74 18 B9 00 00 00 0069C9" + Class11.smethod_46(Class56.memorySignatureScanConfig_106.uint_0, 8, bool_1: false, bool_2: true) + "01 C1 55 89 E5E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DBF" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "C6 07 00 89 47 FC 61" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_238.uint_0 != 0 && Class56.memorySignatureScanConfig_105.uint_0 != 0 && Class56.memorySignatureScanConfig_106.uint_0 != 0);
	}

	public static int smethod_22(CharacterAccountConfig characterAccountConfig_0, uint uint_54)
	{
		if (characterAccountConfig_0.uint_59 != 0)
		{
			int num = 0;
			int int_ = 0;
			byte[] array = new byte[1];
			while (num < 300)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_59 - 4, array, 1, ref int_);
				if (array[0] == 0)
				{
					break;
				}
				num++;
				Thread.Sleep(1);
			}
			array = BitConverter.GetBytes(uint_54);
			if (Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_59 + 24, array, array.Length, ref int_))
			{
				array = new byte[4];
				if (Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_59 - 8, array, array.Length, ref int_))
				{
					if (smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_59))
					{
						num = 0;
						int num2 = 0;
						while (num < 30)
						{
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_59 - 8, array, 4, ref int_);
							num2 = BitConverter.ToInt32(array, 0);
							if (num2 > 0)
							{
								break;
							}
							num++;
							Thread.Sleep(10);
						}
						return num2;
					}
					return -1;
				}
				return -1;
			}
			return -1;
		}
		return -1;
	}

	private static uint smethod_23(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		characterAccountConfig_0.uint_18 += 80u;
		uint num2 = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num3 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_225.uint_0 - (num2 + 46);
		string string_ = "60B8" + Class11.smethod_46(num2 - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 2D C6 00 01 90 90 90 908B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_224.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 15B8" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "55 89 E5 6A 00 50 6A 70E8" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num2 * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_225.uint_0 != 0 && Class56.memorySignatureScanConfig_224.uint_0 != 0);
	}

	private static uint smethod_24(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_232.uint_0 - (num + 9);
		string string_ = "60 55 89 E5E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "89 EC 5D61" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_232.uint_0 != 0);
	}

	private static uint smethod_25(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string string_ = "B8 " + Class11.smethod_46(characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18, 8, bool_1: false, bool_2: true) + "89 45 08 C7 00 10 00 00 00 66 C7 40 04 00 00 66 C7 40 06 A0 08 6A 00 50 6A 188B 0D " + Class11.smethod_46(Class56.memorySignatureScanConfig_224.uint_0, 8, bool_1: false, bool_2: true);
		characterAccountConfig_0.uint_18 += 16u;
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_225.uint_0, string_);
	}

	public static bool smethod_26(CharacterAccountConfig characterAccountConfig_0, string string_0)
	{
		if (characterAccountConfig_0.uint_78 != 0)
		{
			int int_ = 0;
			byte[] array = Class11.smethod_47(string_0);
			if (Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_78 - 80, array, array.Length, ref int_))
			{
				return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_78);
			}
			return false;
		}
		return false;
	}

	public static bool smethod_27(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_79 == 0)
		{
			return false;
		}
		return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_79);
	}

	public static bool smethod_28(CharacterAccountConfig characterAccountConfig_0, int int_0, int int_1 = 0)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_77 != 0)
		{
			int int_2 = 0;
			int value = int_1 * 16 + 2208;
			byte[] bytes = BitConverter.GetBytes(value);
			byte[] bytes2 = BitConverter.GetBytes(int_0);
			bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_77 + 19, bytes2, 2, ref int_2);
			bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_77 + 25, bytes, 2, ref int_2);
			if (flag && flag2)
			{
				return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_77);
			}
			return false;
		}
		return false;
	}

	public static int smethod_29(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = 2712668 + characterAccountConfig_0.uint_7;
		uint num2 = 508u;
		uint num3 = 16u;
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array, 4, ref int_);
		uint num4 = BitConverter.ToUInt32(array, 0);
		if (num4 == 0)
		{
			return -1000000;
		}
		uint num5 = num4 + num2 + num3;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5, array, 4, ref int_);
		uint num6 = BitConverter.ToUInt32(array, 0);
		if (num6 == 0)
		{
			return -1000001;
		}
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6, array, 1, ref int_);
		if (array[0] != 16)
		{
			return -1000002;
		}
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + 6, array, 2, ref int_);
		return array[1] * 256 + array[0];
	}

	private static uint smethod_30(ref CharacterAccountConfig characterAccountConfig_0, bool bool_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = 0u;
		num = ((!bool_0) ? Class56.memorySignatureScanConfig_67.uint_0 : Class56.memorySignatureScanConfig_69.uint_0);
		uint num2 = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num3 = characterAccountConfig_0.uint_7 + num - (num2 + 44);
		string string_ = "60B8" + Class11.smethod_46(num2 - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 2B C6 00 018B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 1781C1" + Class11.smethod_46(Class56.memorySignatureScanConfig_12.uint_0, 8, bool_1: false, bool_2: true) + "BB 53 00 00 00 55 89 E5 53E8" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num2 * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && num != 0 && Class56.memorySignatureScanConfig_11.uint_0 != 0 && Class56.memorySignatureScanConfig_12.uint_0 != 0);
	}

	public static bool smethod_31(CharacterAccountConfig characterAccountConfig_0, uint uint_54)
	{
		if (characterAccountConfig_0.uint_40 == 0)
		{
			return false;
		}
		int int_ = 0;
		byte[] array = new byte[1];
		int num = 0;
		while (!Class11.bool_0)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_40 - 4, array, 1, ref int_);
			if (array[0] == 0)
			{
				break;
			}
			num++;
			if (num <= 350)
			{
				Thread.Sleep(1);
				continue;
			}
			return false;
		}
		array = BitConverter.GetBytes(uint_54);
		if (!Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_40 + 31, array, array.Length, ref int_))
		{
			return false;
		}
		return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_40);
	}

	public static bool smethod_32(CharacterAccountConfig characterAccountConfig_0, uint uint_54)
	{
		if (characterAccountConfig_0.uint_41 == 0)
		{
			return false;
		}
		int int_ = 0;
		byte[] array = new byte[1];
		int num = 0;
		while (!Class11.bool_0)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_41 - 4, array, 1, ref int_);
			if (array[0] == 0)
			{
				break;
			}
			num++;
			if (num <= 350)
			{
				Thread.Sleep(1);
				continue;
			}
			return false;
		}
		array = BitConverter.GetBytes(uint_54);
		if (!Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_41 + 31, array, array.Length, ref int_))
		{
			return false;
		}
		return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_41);
	}

	private static uint smethod_33(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_169.uint_0 - (num + 36);
		string string_ = "60B9" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 23 C6 01 018B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_165.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 0F 55 89 E5 6A 00 6A 00E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_169.uint_0 != 0 && Class56.memorySignatureScanConfig_165.uint_0 != 0);
	}

	private static uint smethod_34(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_104.uint_0 - (num + 51);
		string string_ = "60B8" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 32 C6 00 01A1" + Class11.smethod_46(Class56.memorySignatureScanConfig_105.uint_0, 8, bool_1: false, bool_2: true) + "85 C0 74 1F B9 00 00 00 0069C9" + Class11.smethod_46(Class56.memorySignatureScanConfig_106.uint_0, 8, bool_1: false, bool_2: true) + "01 C88B88" + Class11.smethod_46(Class56.memorySignatureScanConfig_103.uint_0, 8, bool_1: false, bool_2: true) + "55 89 E5 51E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_105.uint_0 != 0 && Class56.memorySignatureScanConfig_106.uint_0 != 0 && Class56.memorySignatureScanConfig_103.uint_0 != 0 && Class56.memorySignatureScanConfig_104.uint_0 != 0);
	}

	public static bool smethod_35(CharacterAccountConfig characterAccountConfig_0, uint uint_54)
	{
		if (characterAccountConfig_0.uint_61 != 0 && smethod_7(characterAccountConfig_0))
		{
			int int_ = 0;
			byte[] array = new byte[4];
			int num = 0;
			while (num < 300)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_61 - 4, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) == 0)
				{
					break;
				}
				num++;
				Thread.Sleep(1);
			}
			byte[] bytes = BitConverter.GetBytes(uint_54);
			if (Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_61 + 24, bytes, bytes.Length, ref int_))
			{
				array = new byte[4];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
				uint num2 = BitConverter.ToUInt32(array, 0);
				array = new byte[4];
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2 + 35664, array, 4, ref int_);
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2 + 55416, array, 4, ref int_);
				return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_61);
			}
			return false;
		}
		return false;
	}

	private static uint smethod_36(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_225.uint_0 - (num + 41);
		string string_ = "60B8" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 28 C6 00 018B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_224.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 14 55 89 E5 68 00 01 00 00 6A 00 6A 05E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_224.uint_0 != 0 && Class56.memorySignatureScanConfig_225.uint_0 != 0);
	}

	public static bool smethod_37(CharacterAccountConfig characterAccountConfig_0, uint uint_54)
	{
		if (characterAccountConfig_0.uint_62 != 0 && smethod_7(characterAccountConfig_0))
		{
			int int_ = 0;
			byte[] array = new byte[1];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_62 - 4, array, 1, ref int_);
			if (array[0] > 0)
			{
				return false;
			}
			array[0] = 0;
			byte[] bytes = BitConverter.GetBytes(uint_54);
			bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_62 + 33, array, 1, ref int_);
			bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_62 + 28, bytes, 4, ref int_);
			if (flag && flag2)
			{
				return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_62);
			}
			return false;
		}
		return false;
	}

	public static bool smethod_38(CharacterAccountConfig characterAccountConfig_0, uint uint_54)
	{
		if (characterAccountConfig_0.uint_62 != 0 && smethod_7(characterAccountConfig_0))
		{
			int int_ = 0;
			byte[] array = new byte[1];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_62 - 4, array, 1, ref int_);
			if (array[0] > 0)
			{
				return false;
			}
			array[0] = 1;
			byte[] bytes = BitConverter.GetBytes(uint_54);
			bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_62 + 33, array, 1, ref int_);
			bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_62 + 28, bytes, 4, ref int_);
			if (flag && flag2)
			{
				return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_62);
			}
			return false;
		}
		return false;
	}

	public static uint smethod_39(CharacterAccountConfig characterAccountConfig_0, int int_0 = 1)
	{
		uint num = Class56.memorySignatureScanConfig_74.uint_0;
		if (int_0 == 1 || int_0 == 3)
		{
			num = Class56.memorySignatureScanConfig_73.uint_0;
		}
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_12.uint_0;
		uint num3 = num2 + Class56.memorySignatureScanConfig_75.uint_0 + num;
		return Class24.smethod_30(num3, characterAccountConfig_0.int_137);
	}

	private static uint smethod_40(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string string_ = "B8" + Class11.smethod_46(characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18, 8, bool_1: false, bool_2: true) + "80 38 0075 3D8B 0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_224.uint_0, 8, bool_1: false, bool_2: true) + "85 C974 33C6 00 01 83 C0 04 89 45 08C7 00 0B 00 00 00C7 40 04 01 00 00 006A 00 50 6A 18";
		string string_2 = "B8" + Class11.smethod_46(characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18, 8, bool_1: false, bool_2: true) + "FE 48 0180 78 01 007F C866 C7 00 00 00";
		characterAccountConfig_0.uint_18 += 256u;
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_225.uint_0, string_, string_2);
	}

	public static uint smethod_41(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		if (characterAccountConfig_0.uint_71 != 0 && smethod_7(characterAccountConfig_0))
		{
			uint result = characterAccountConfig_0.uint_71 - 256;
			int int_1 = 0;
			byte[] array = new byte[1];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, result, array, 1, ref int_1);
			if (array[0] == 0)
			{
				array = BitConverter.GetBytes(int_0);
				if (!Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_71 + 39, array, 4, ref int_1))
				{
					return 0u;
				}
				if (!smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_71))
				{
					return 0u;
				}
			}
			return result;
		}
		return 0u;
	}

	private static uint smethod_42(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_121.uint_0 - (num + 51);
		string string_ = "60B8" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 32 C6 00 018B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 1E81C1" + Class11.smethod_46(Class56.memorySignatureScanConfig_12.uint_0, 8, bool_1: false, bool_2: true) + "55 89 E5 6A 00 6A 09 6A 05 6A 03 68 01 00 00 00E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_121.uint_0 != 0);
	}

	public static bool smethod_43(CharacterAccountConfig characterAccountConfig_0, uint uint_54, int int_0, int int_1, int int_2 = 3)
	{
		if (characterAccountConfig_0.uint_46 != 0)
		{
			int int_3 = 0;
			byte[] bytes = BitConverter.GetBytes(uint_54);
			byte[] byte_ = new byte[1] { (byte)int_2 };
			byte[] byte_2 = new byte[1] { (byte)int_0 };
			byte[] byte_3 = new byte[1] { (byte)int_1 };
			bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_46 + 36, byte_3, 1, ref int_3);
			bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_46 + 38, byte_2, 1, ref int_3);
			bool flag3 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_46 + 40, byte_, 1, ref int_3);
			bool flag4 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_46 + 42, bytes, 4, ref int_3);
			if (flag && flag2 && flag3 && flag4)
			{
				return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_46);
			}
			return false;
		}
		return false;
	}

	public static bool smethod_44(CharacterAccountConfig characterAccountConfig_0, string string_0, bool bool_0 = false, int int_0 = -1, bool bool_1 = false)
	{
		if (string_0 != null && !(string_0 == string.Empty) && characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_46 != 0 && Class56.memorySignatureScanConfig_121.uint_0 != 0 && Class56.memorySignatureScanConfig_11.uint_0 != 0 && Class56.memorySignatureScanConfig_12.uint_0 != 0)
		{
			int num = 1;
			string[] array = string_0.Split('|', ',', ';');
			string[] array2 = new string[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					array[i] = string.Empty;
				}
				if (num < array[i].Length)
				{
					num = array[i].Length;
				}
				array2[i] = array[i].Trim().ToLower();
			}
			num += 3;
			int int_1 = 0;
			byte[] array3 = new byte[4];
			byte[] array4 = new byte[1];
			byte[] byte_ = new byte[num];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref int_1);
			uint num2 = BitConverter.ToUInt32(array3, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array3, 4, ref int_1);
			uint num3 = BitConverter.ToUInt32(array3, 0);
			int num4 = Class85.smethod_4(characterAccountConfig_0);
			int num5 = 0;
			uint num6 = 0u;
			int int_2 = 0;
			int int_3 = 0;
			uint num7 = 0u;
			int num8 = 0;
			int num9 = 0;
			for (uint num10 = 1u; num10 < Class56.int_1 && num4 > num5; num10++)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (num10 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array3, 4, ref int_1);
				uint num11 = BitConverter.ToUInt32(array3, 0);
				if (num11 == 0)
				{
					continue;
				}
				uint num12 = num3 + num11 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array3, 4, ref int_1);
				if (BitConverter.ToInt32(array3, 0) != 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_107.uint_0, array4, 1, ref int_1);
				if (array4[0] == 0)
				{
					continue;
				}
				num5++;
				uint num13 = num2 + num10 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array4, 1, ref int_1);
				if (array4[0] != 3)
				{
					continue;
				}
				if (0 <= int_0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_108.uint_0, array3, 4, ref int_1);
					int num14 = BitConverter.ToInt32(array3, 0);
					if (num14 != int_0)
					{
						continue;
					}
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array4, 1, ref int_1);
				int num15 = array4[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_100.uint_0, array4, 1, ref int_1);
				int num16 = array4[0];
				if (array != null)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_107.uint_0, byte_, num, ref int_1);
					string text = Class1.smethod_3(byte_);
					string text2 = text.Trim().ToLower();
					for (int j = 0; j < array.Length; j++)
					{
						if (!(text == array[j]) && !(text2 == array2[j]))
						{
							if (!bool_0)
							{
								if (0 <= text2.IndexOf(array2[j]))
								{
									num6 = num11;
									int_2 = num15;
									int_3 = num16;
									break;
								}
								if (0 <= array2[j].IndexOf(text2))
								{
									num7 = num11;
									num8 = num15;
									num9 = num16;
									break;
								}
							}
							continue;
						}
						return smethod_43(characterAccountConfig_0, num11, num15, num16);
					}
				}
				if (!bool_1 && (num6 != 0 || num7 != 0))
				{
					break;
				}
			}
			if (num6 == 0 && num7 != 0)
			{
				num6 = num7;
				int_2 = num8;
				int_3 = num9;
			}
			if (num6 == 0)
			{
				return false;
			}
			return smethod_43(characterAccountConfig_0, num6, int_2, int_3);
		}
		return false;
	}

	private static uint smethod_45(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_102.uint_0 - (num + 50);
		string string_ = "60B9" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 31 C6 01 018B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 1D81C1" + Class11.smethod_46(Class56.memorySignatureScanConfig_12.uint_0, 8, bool_1: false, bool_2: true) + "55 89 E5 6A 00 6A 00 6A 01 6A 02 6A 02 6A 03E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_102.uint_0 != 0);
	}

	public static void smethod_46(CharacterAccountConfig characterAccountConfig_0, uint uint_54, uint uint_55, uint uint_56, uint uint_57, uint uint_58, uint uint_59)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_44 != 0 && smethod_7(characterAccountConfig_0))
		{
			int int_ = 0;
			int num = 0;
			byte[] array = new byte[1];
			while (Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_44 - 4, array, 1, ref int_) && array[0] > 0 && num < 150)
			{
				Thread.Sleep(1);
				num++;
			}
			byte[] byte_ = new byte[1] { (byte)uint_57 };
			byte[] byte_2 = new byte[1] { (byte)uint_58 };
			byte[] byte_3 = new byte[1] { (byte)uint_59 };
			byte[] byte_4 = new byte[1] { (byte)uint_54 };
			byte[] byte_5 = new byte[1] { (byte)uint_55 };
			byte[] byte_6 = new byte[1] { (byte)uint_56 };
			bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_44 + 34, byte_2, 1, ref int_);
			bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_44 + 36, byte_, 1, ref int_);
			bool flag3 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_44 + 38, byte_3, 1, ref int_);
			bool flag4 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_44 + 40, byte_5, 1, ref int_);
			bool flag5 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_44 + 42, byte_4, 1, ref int_);
			bool flag6 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_44 + 44, byte_6, 1, ref int_);
			if (flag && flag2 && flag3 && flag4 && flag5 && flag6)
			{
				smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_44);
			}
		}
	}

	private static uint smethod_47(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_142.uint_0 - (num + 44);
		string string_ = "60B8" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 2B C6 00 01 B8 00 00 00 008B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 1281C1" + Class11.smethod_46(Class56.memorySignatureScanConfig_12.uint_0, 8, bool_1: false, bool_2: true) + "55 89 E5 50E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_142.uint_0 != 0);
	}

	public static void smethod_48(CharacterAccountConfig characterAccountConfig_0, uint uint_54 = 0u)
	{
		if (characterAccountConfig_0.uint_43 != 0)
		{
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(uint_54);
			if (Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_43 + 15, bytes, bytes.Length, ref int_))
			{
				smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_43);
			}
		}
	}

	private static uint smethod_49(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		characterAccountConfig_0.uint_18 += uint_3;
		uint num2 = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num3 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_218.uint_0 - (num2 + 50);
		string string_ = "60B8" + Class11.smethod_46(num2 - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 31 C6 00 01B8" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "BF" + Class11.smethod_46(num + 32, 8, bool_1: false, bool_2: true) + "8B D7 8A 1A 84 DB 74 03 42 EB F7 2B D7 7E 0E 55 89 E5 52 57 50E8" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num2 * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_218.uint_0 != 0);
	}

	public static void smethod_50(CharacterAccountConfig characterAccountConfig_0, string string_0, string string_1)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_83 != 0 && string_0 != null && !(string_0 == string.Empty) && string_1 != null && !(string_1 == string.Empty))
		{
			if (127 <= string_1.Length)
			{
				string_1 = string_1.Substring(0, 126);
			}
			if (uint_3 <= string_1.Length)
			{
				string_1 = string_1.Substring(0, (int)(uint_3 - 1));
			}
			int int_ = 0;
			byte[] array = Class11.smethod_47(string_1);
			bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_83 - uint_3 + 32, array, array.Length, ref int_);
			byte[] array2 = Class11.smethod_47(string_0);
			bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_83 - uint_3, array2, array2.Length, ref int_);
			if (flag && flag2)
			{
				smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_83);
			}
		}
	}

	private static uint smethod_51(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		characterAccountConfig_0.uint_18 += uint_1;
		uint num2 = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num3 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_219.uint_0 - (num2 + 40);
		string string_ = "60B8" + Class11.smethod_46(num2 - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 27 C6 00 01 B8 00 00 00 00BA" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "B9 01 00 00 00 55 89 E5 51 50 52E8" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num2 * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_219.uint_0 != 0);
	}

	public static void smethod_52(CharacterAccountConfig characterAccountConfig_0, string string_0, int int_0 = 1)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_82 != 0 && string_0 != null)
		{
			if (uint_1 <= string_0.Length - 1)
			{
				string_0 = string_0.Substring(0, (int)(uint_1 - 1));
			}
			int int_1 = 0;
			byte[] array = Class11.smethod_47(string_0);
			byte[] bytes = BitConverter.GetBytes(string_0.Length);
			byte[] bytes2 = BitConverter.GetBytes(int_0);
			bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_82 - uint_1, array, array.Length, ref int_1);
			bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_82 + 15, bytes, 4, ref int_1);
			bool flag3 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_82 + 25, bytes2, 4, ref int_1);
			if (flag && flag2 && flag3)
			{
				smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_82);
			}
		}
	}

	private static uint smethod_53(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		characterAccountConfig_0.uint_18 += uint_2;
		uint num2 = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num3 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_217.uint_0 - (num2 + 31);
		string string_ = "60B8" + Class11.smethod_46(num2 - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 1E C6 00 01 55 89 E5 6A 0068" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "6A 01E8" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num2 * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_217.uint_0 != 0);
	}

	public static void smethod_54(CharacterAccountConfig characterAccountConfig_0, string string_0, int int_0)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_81 != 0)
		{
			if (string_0.Length >= 127)
			{
				string_0 = string_0.Substring(0, 126);
			}
			if (string_0.Length >= uint_2)
			{
				string_0 = string_0.Substring(0, (int)(uint_2 - 1));
			}
			int int_1 = 0;
			byte[] array = Class11.smethod_47(string_0);
			byte[] byte_ = new byte[1] { (byte)string_0.Length };
			byte[] byte_2 = new byte[1] { (byte)int_0 };
			bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_81 - uint_2, array, array.Length, ref int_1);
			bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_81 + 18, byte_, 1, ref int_1);
			bool flag3 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_81 + 25, byte_2, 1, ref int_1);
			if (flag && flag2 && flag3)
			{
				smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_81);
			}
		}
	}

	public static void smethod_55(CharacterAccountConfig characterAccountConfig_0, string string_0, object object_0 = null)
	{
		if (object_0 == null)
		{
			object_0 = 1;
		}
		if (object_0.GetType() != string.Empty.GetType())
		{
			smethod_54(characterAccountConfig_0, string_0, (int)object_0);
			return;
		}
		smethod_57(characterAccountConfig_0, "Chat('" + object_0.ToString() + "', '" + string_0 + "')");
	}

	private static uint smethod_56(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		characterAccountConfig_0.uint_18 += uint_4;
		uint num2 = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num3 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_221.uint_0 - (num2 + 27);
		string string_ = "60B8" + Class11.smethod_46(num2 - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 1A C6 00 01 55 89 E568" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "E8" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num2 - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num2 * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_221.uint_0 != 0);
	}

	public static void smethod_57(CharacterAccountConfig characterAccountConfig_0, string string_0)
	{
		if (characterAccountConfig_0.uint_84 == 0 || string_0 == null)
		{
			return;
		}
		if (string_0.Length > 126)
		{
			string_0 = string_0.Substring(0, 126);
		}
		if (uint_4 <= string_0.Length)
		{
			string_0 = string_0.Substring(0, (int)(uint_4 - 1));
		}
		int int_ = 0;
		int num = 0;
		byte[] array = new byte[1];
		while (true)
		{
			if (!Class11.bool_0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_84 - 4, array, 1, ref int_);
				if (array[0] != 0)
				{
					num++;
					if (num <= 150)
					{
						Thread.Sleep(1);
						continue;
					}
					break;
				}
			}
			array = Class11.smethod_47(string_0);
			if (Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_84 - uint_4, array, array.Length, ref int_))
			{
				smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_84);
			}
			break;
		}
	}

	private static uint smethod_58(ref CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = Class56.memorySignatureScanConfig_147.uint_0;
		uint num3 = Class56.memorySignatureScanConfig_147.uint_0;
		uint num4 = Class56.memorySignatureScanConfig_144.uint_0;
		if (int_0 > 0)
		{
			num3 = Class56.memorySignatureScanConfig_149.uint_0;
			num4 = Class56.memorySignatureScanConfig_145.uint_0;
			num2 = Class56.memorySignatureScanConfig_151.uint_0;
		}
		int int_1 = 0;
		long num5 = Class11.smethod_37(Class56.int_5.ToString() + Class56.int_6);
		byte b = Convert.ToByte(GClass1.long_1 > num5);
		uint num6 = characterAccountConfig_0.uint_7 + num4 - (uint)(Convert.ToByte(b == 0) * 256);
		uint num7 = num + 47;
		uint num8 = num6 - num7;
		string string_ = "60B9" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 2F C6 01 018B0D" + Class11.smethod_46(characterAccountConfig_0.uint_7 + num3, 8, bool_1: false, bool_2: true) + "85 C9 74 1A BA 00 00 00 00833D" + Class11.smethod_46(characterAccountConfig_0.uint_7 + num2, 8, bool_1: false, bool_2: true) + "0074 0C55 89 E5 52E8" + Class11.smethod_46(num8, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_1);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0);
	}

	public static bool smethod_59(CharacterAccountConfig characterAccountConfig_0, int int_0, int int_1)
	{
		int int_2 = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		uint num = Class56.memorySignatureScanConfig_147.uint_0;
		uint num2 = characterAccountConfig_0.uint_75;
		if (int_1 > 0)
		{
			num2 = characterAccountConfig_0.uint_76;
			num = Class56.memorySignatureScanConfig_151.uint_0;
		}
		if (num2 == 0)
		{
			return false;
		}
		for (int i = 0; i < 300; i++)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 - 4, array, 1, ref int_2);
			if (array[0] == 0)
			{
				break;
			}
			Thread.Sleep(1);
		}
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + num, array2, 4, ref int_2);
		if (BitConverter.ToUInt32(array2, 0) != 0 && array[0] == 0)
		{
			array2 = BitConverter.GetBytes(int_0);
			if (!Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2 + 25, array2, 4, ref int_2))
			{
				return false;
			}
			bool result = smethod_12(characterAccountConfig_0.int_137, num2);
			for (int j = 0; j < 300; j++)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + num, array2, 4, ref int_2);
				if (BitConverter.ToInt32(array2, 0) == 0)
				{
					break;
				}
				Thread.Sleep(1);
			}
			return result;
		}
		return false;
	}

	private static uint smethod_60(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_223.uint_0 - (num + 71);
		string string_ = "60B9" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 46 C6 01 018B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 328B89" + Class11.smethod_46(Class56.memorySignatureScanConfig_13.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 28A1" + Class11.smethod_46(Class56.memorySignatureScanConfig_14.uint_0, 8, bool_1: false, bool_2: true) + "85 C0 74 1F69C9" + Class11.smethod_46(Class56.memorySignatureScanConfig_15.uint_0, 8, bool_1: false, bool_2: true) + "01 C1 55 89 E5 6A 00 68 9E A3 01 00 68 4A A7 00 00E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0);
	}

	public static void smethod_61(CharacterAccountConfig characterAccountConfig_0, uint[] uint_54)
	{
		if (characterAccountConfig_0.uint_51 != 0 && uint_54 != null && uint_54[0] != 0 && uint_54[1] != 0 && smethod_7(characterAccountConfig_0))
		{
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(uint_54[0]);
			byte[] bytes2 = BitConverter.GetBytes(uint_54[1]);
			bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_51 + 57, bytes2, 4, ref int_);
			bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_51 + 62, bytes, 4, ref int_);
			if (Class11.smethod_37(Class56.int_5.ToString() + Class56.int_6) < GClass1.long_1)
			{
				characterAccountConfig_0.uint_51++;
			}
			if (flag && flag2)
			{
				smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_51);
			}
		}
	}

	private static uint smethod_62(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_225.uint_0 - (num + 47);
		string string_ = "60B9" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 2E C6 01 018B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_236.uint_0, 8, bool_1: false, bool_2: true) + "83 F9 00 74 19 B8 FF FF FF FF BB FF FF FF FF 55 89 E5 53 50 6A 7EE8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "89 EC 5DC605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0);
	}

	public static bool smethod_63(CharacterAccountConfig characterAccountConfig_0, uint[] uint_54)
	{
		if (uint_54 != null && characterAccountConfig_0.uint_88 != 0 && smethod_7(characterAccountConfig_0))
		{
			int num = (int)Math.Round((decimal)uint_54[0] / 32m);
			int num2 = (int)Math.Round((decimal)uint_54[1] / 32m);
			if (num > 0 && num2 > 0)
			{
				int int_ = 0;
				byte[] bytes = BitConverter.GetBytes(num);
				byte[] bytes2 = BitConverter.GetBytes(num2);
				bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_88 + 26, bytes, 4, ref int_);
				bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_88 + 31, bytes2, 4, ref int_);
				if (flag && flag2)
				{
					return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_88);
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public static bool smethod_64(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_182.uint_0 != 0 && Class56.memorySignatureScanConfig_262.uint_0 != 0 && characterAccountConfig_0.uint_91 != 0)
		{
			return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_91);
		}
		return false;
	}

	private static uint smethod_65(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		string string_ = "33 C0 50 6A 01 50 6A 56 40A3" + Class11.smethod_46(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_262.uint_0, 8, bool_1: false, bool_2: true);
		string string_2 = "83 C4 10";
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_182.uint_0, string_, string_2);
	}

	private static uint smethod_66(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		characterAccountConfig_0.uint_18 += 48u;
		string string_ = "B9" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "8B 01 85 C0 75 23 40 89 01 83 C1 04 8B C18B 0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_236.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 0A 6A 00 50 6A 65";
		string string_2 = "C6 05" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "00";
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_225.uint_0, string_, string_2);
	}

	public static bool smethod_67(CharacterAccountConfig characterAccountConfig_0, uint uint_54, uint uint_55, uint uint_56)
	{
		if (characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_225.uint_0 != 0 && Class56.memorySignatureScanConfig_236.uint_0 != 0 && characterAccountConfig_0.uint_48 != 0)
		{
			uint num = characterAccountConfig_0.uint_48 - 48;
			int int_ = 0;
			byte[] array = new byte[1];
			if (Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array, 1, ref int_) && array[0] <= 0)
			{
				array = new byte[8] { 0, 0, 0, 0, 3, 0, 0, 0 };
				byte[] bytes = BitConverter.GetBytes(uint_54);
				byte[] bytes2 = BitConverter.GetBytes(uint_55);
				byte[] bytes3 = BitConverter.GetBytes(uint_56);
				if (Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num + 4, array, 8, ref int_) && Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num + 4 + 8, bytes, 4, ref int_) && Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num + 4 + 12, bytes2, 4, ref int_) && Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num + 4 + 16, bytes3, 4, ref int_))
				{
					return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_48);
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private static uint smethod_68(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		characterAccountConfig_0.uint_18 += 48u;
		string string_ = "B8" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "80 38 0075 218B 0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_236.uint_0, 8, bool_1: false, bool_2: true) + "85 C974 17C6 00 0183 C0 046A 0050 6A 65";
		string string_2 = "C6 05" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "00";
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_225.uint_0, string_, string_2);
	}

	public static bool smethod_69(CharacterAccountConfig characterAccountConfig_0, uint uint_54, uint uint_55, uint uint_56)
	{
		if (characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_225.uint_0 != 0 && Class56.memorySignatureScanConfig_236.uint_0 != 0 && characterAccountConfig_0.uint_49 != 0)
		{
			uint num = characterAccountConfig_0.uint_49 - 48;
			int int_ = 0;
			byte[] array = new byte[1];
			if (Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array, 1, ref int_) && array[0] <= 0)
			{
				array = new byte[8] { 1, 0, 0, 0, 3, 0, 0, 0 };
				byte[] bytes = BitConverter.GetBytes(uint_54);
				byte[] bytes2 = BitConverter.GetBytes(uint_55);
				byte[] bytes3 = BitConverter.GetBytes(uint_56);
				if (Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num + 4, array, array.Length, ref int_) && Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num + 4 + 8, bytes, 4, ref int_) && Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num + 4 + 8 + 4, bytes2, 4, ref int_) && Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num + 4 + 8 + 4 + 4, bytes3, 4, ref int_))
				{
					return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_49);
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private static uint smethod_70(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		string string_ = "B8 00 00 00 00BA 00 00 00 008B 0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_236.uint_0, 8, bool_1: false, bool_2: true) + "85 C974 17C6 05" + Class11.smethod_46(characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18, 8, bool_1: false, bool_2: true) + "0150526A 59";
		string string_2 = "C6 05" + Class11.smethod_46(characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18, 8, bool_1: false, bool_2: true) + "00";
		characterAccountConfig_0.uint_18 += 4u;
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_225.uint_0, string_, string_2);
	}

	public static bool smethod_71(CharacterAccountConfig characterAccountConfig_0, uint uint_54, uint uint_55, byte byte_0 = 89)
	{
		if (characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_225.uint_0 != 0 && Class56.memorySignatureScanConfig_236.uint_0 != 0 && characterAccountConfig_0.uint_47 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[1];
			if (Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_47 - 4, array, 1, ref int_) && array[0] <= 0)
			{
				array[0] = byte_0;
				if (!Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_47 + 31, array, 1, ref int_))
				{
					return false;
				}
				array = BitConverter.GetBytes(uint_55);
				if (Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_47 + 2, array, 4, ref int_))
				{
					array = BitConverter.GetBytes(uint_54);
					if (Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_47 + 7, array, 4, ref int_))
					{
						return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_47);
					}
					return false;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private static uint smethod_72(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_192.uint_0 - (num + 53);
		string string_ = "60 B8" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 37 C6 00 01B8 05000000B9" + Class11.smethod_46(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_191.uint_0, 8, bool_1: false, bool_2: true) + "8B 1D" + Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0, 8, bool_1: false, bool_2: true) + "81 C3" + Class11.smethod_46(Class56.memorySignatureScanConfig_189.uint_0, 8, bool_1: false, bool_2: true) + "8B 5B" + Class11.smethod_46(Class56.memorySignatureScanConfig_190.uint_0, 2, bool_1: false, bool_2: true) + "55 6A 00 6A 00 50 53 6A 01E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "83 C4 04 8B E5 5DC605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_192.uint_0 != 0);
	}

	public static bool smethod_73(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		int int_1 = 0;
		byte[] bytes = BitConverter.GetBytes(int_0);
		if (Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_96 + 15, bytes, 4, ref int_1))
		{
			return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_96);
		}
		return false;
	}

	private static uint smethod_74(ref CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_188.uint_0 != 0)
		{
			uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
			uint num2 = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18 + 4;
			characterAccountConfig_0.uint_18 += 8u;
			uint num3 = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
			string string_ = "60BA" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "C6 42 04 018B0D" + Class11.smethod_46(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_188.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 19 8B 01 85 C0 74 13 8B 40 1C 85 C0 74 0C 6A 00 6A 04 52 68 15 80 00 00 FF D0C6 05" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
			int int_ = 0;
			byte[] array = Class11.smethod_8(string_, bool_1: false);
			bool value = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num3, array, array.Length, ref int_);
			num3 *= Convert.ToByte(value);
			characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
			return num3;
		}
		return 0u;
	}

	public static bool smethod_75(CharacterAccountConfig characterAccountConfig_0, string string_0, uint uint_54 = 32769u, uint uint_55 = 4u, uint uint_56 = 0u)
	{
		if (characterAccountConfig_0.uint_94 != 0 && Class56.memorySignatureScanConfig_191.uint_0 != 0)
		{
			uint num = Class11.smethod_6(string_0);
			if (Class24.smethod_31(characterAccountConfig_0.uint_94 - 8, characterAccountConfig_0.int_137, num))
			{
				Class24.smethod_31(characterAccountConfig_0.uint_94 + 39, characterAccountConfig_0.int_137, uint_54);
				Class24.smethod_31(characterAccountConfig_0.uint_94 + 36, characterAccountConfig_0.int_137, uint_55, 1);
				Class24.smethod_31(characterAccountConfig_0.uint_94 + 34, characterAccountConfig_0.int_137, uint_56, 1);
				return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_94);
			}
			return false;
		}
		return false;
	}

	private static uint smethod_76(ref CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = num + 80;
		characterAccountConfig_0.uint_18 += uint_1;
		string string_ = "B8 03 00 00 00BA 3B 00 00 008B 35" + Class11.smethod_46(Class56.memorySignatureScanConfig_209.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "8D 8E" + Class11.smethod_46(Class56.memorySignatureScanConfig_208.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "6A 00 6A 00 51 5268" + Class11.smethod_46(num2.ToString(), 8, bool_1: false, bool_2: true) + "68" + Class11.smethod_46(num.ToString(), 8, bool_1: false, bool_2: true) + "50 8B CE";
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_210.uint_0, string_);
	}

	private static uint smethod_77(ref CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_17 == 0)
		{
			return 0u;
		}
		string string_ = "60B8 000000008B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_209.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "85 C9 74 2B69C0" + Class11.smethod_46(Class56.memorySignatureScanConfig_215.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "05" + Class11.smethod_46(Class56.memorySignatureScanConfig_216.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "03 C8 6A 00 51 68 65 05 00 00 8B 51 60 8B 12 8B 49 60 8B 42 10 85 C0 74 04 FF D0 EB 03 58 58 58 61" + smethod_10(characterAccountConfig_0.uint_98);
		byte[] array = Class11.smethod_8(string_);
		int int_ = 0;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		byte b = Convert.ToByte(Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_));
		uint num2 = (uint)(b * (array.Length + 4));
		characterAccountConfig_0.uint_18 += num2;
		return num * b;
	}

	private static uint smethod_78(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string text = Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string text2 = Class11.smethod_46(Class56.memorySignatureScanConfig_166.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "B9 00 00 00 00 6A 01 51 8B 0D " + text + "81 C1 " + text2;
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_220.uint_0, string_);
	}

	private static uint smethod_79(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_164.uint_0 - (num + 43);
		string string_ = "60B8" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 38 00 75 27 C6 00 01BE 96 00 00 008B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 0E81C1" + Class11.smethod_46(Class56.memorySignatureScanConfig_12.uint_0, 8, bool_1: false, bool_2: true) + "6A 01 56E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "C605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_164.uint_0 != 0 && Class56.memorySignatureScanConfig_11.uint_0 != 0 && Class56.memorySignatureScanConfig_12.uint_0 != 0);
	}

	public static bool smethod_80(CharacterAccountConfig characterAccountConfig_0, uint uint_54, int int_0)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_42 != 0)
		{
			if (int_0 > 57)
			{
				int_0 = 57;
			}
			int int_1 = 0;
			byte[] byte_ = new byte[1] { (byte)int_0 };
			byte[] bytes = BitConverter.GetBytes(uint_54);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_42 + 15, bytes, 4, ref int_1);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_42 + 36, byte_, 1, ref int_1);
			return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_42);
		}
		return false;
	}

	private static uint smethod_81(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string text = Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string text2 = Class11.smethod_46(Class56.memorySignatureScanConfig_12.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "8B 0D " + text + " 81 C1 " + text2;
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_201.uint_0, string_);
	}

	private static uint smethod_82(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string text = Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string text2 = Class11.smethod_46(Class56.memorySignatureScanConfig_12.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "8B 0D " + text + " 81 C1 " + text2;
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_206.uint_0, string_);
	}

	private static uint smethod_83(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string text = Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string text2 = Class11.smethod_46(Class56.memorySignatureScanConfig_12.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "8B 0D" + text + "81 C1" + text2;
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_122.uint_0, string_);
	}

	private static uint smethod_84(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string string_ = "6A 00 B9 6D 01 00 00 BA 13 01 00 00 51 52";
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_222.uint_0, string_);
	}

	private static uint smethod_85(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string string_ = "BA 00 00 00 008B 0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_236.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "85 C9 74 0A 52 6A 05 6A 58";
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_225.uint_0, string_);
	}

	private static uint smethod_86(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string string_ = "6A 00 6A 00 6A 47";
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_225.uint_0, string_);
	}

	private static uint smethod_87(ref CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_17 != 0)
		{
			uint result = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
			string string_ = "6068 00 00 00 0083 EC 108B 0D" + Class11.smethod_46(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_187.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 8B 44 24 10 C6 04 24 84 C6 44 24 01 04 89 44 24 02 C7 44 24 06 00 00 00 00 74 0E 8B 11 8B52 10 6A 0E 8D 44 24 04 50 FF D2 83 C4 14 61" + smethod_10(characterAccountConfig_0.uint_98);
			characterAccountConfig_0.uint_18 += 8u;
			byte[] array = Class11.smethod_8(string_);
			int int_ = 0;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, result, array, array.Length, ref int_);
			characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
			return result;
		}
		return 0u;
	}

	private static uint smethod_88(ref CharacterAccountConfig characterAccountConfig_0)
	{
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_185.uint_0, "6A 01", "83 C4 04");
	}

	private static uint smethod_89(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string string_ = "6A 00 68 A1 00 00 00 68 11 01 00 00 B9 74 93 68 11";
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_186.uint_0, string_);
	}

	private static uint smethod_90(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string string_ = "6A 01 68 00 00 00 00";
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_226.uint_0, string_, "83 C4 08");
	}

	private static uint smethod_91(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string text = Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string text2 = Class11.smethod_46(Class56.memorySignatureScanConfig_12.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "6A 01A1" + text + "8D 88" + text2;
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_227.uint_0, string_);
	}

	private static uint smethod_92(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string text = Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string text2 = Class11.smethod_46(Class56.memorySignatureScanConfig_12.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "6A 01A1" + text + "8D 88" + text2;
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_228.uint_0, string_);
	}

	private static uint smethod_93(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string text = Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string text2 = Class11.smethod_46(Class56.memorySignatureScanConfig_12.uint_0.ToString(), 8, bool_1: false, bool_2: true);
		string string_ = "B9 00 00 00 00 518B 0D" + text + "81 C1" + text2;
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_229.uint_0, string_);
	}

	private static uint smethod_94(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string string_ = "BB 00000000B9" + Class11.smethod_46(characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18, 8, bool_1: false, bool_2: true) + "C701 01000000 51 6A 00 538B0D" + Class11.smethod_46(Class56.memorySignatureScanConfig_11.uint_0, 8, bool_1: false, bool_2: true) + "85C9 7E 198B89" + Class11.smethod_46(Class56.memorySignatureScanConfig_13.uint_0, 8, bool_1: false, bool_2: true) + "69C9" + Class11.smethod_46(Class56.memorySignatureScanConfig_15.uint_0, 8, bool_1: false, bool_2: true) + "030D" + Class11.smethod_46(Class56.memorySignatureScanConfig_14.uint_0, 8, bool_1: false, bool_2: true);
		string string_2 = "EB 02 59 59 59 C701 00000000";
		characterAccountConfig_0.uint_18 += 4u;
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_233.uint_0, string_, string_2);
	}

	private static uint smethod_95(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		uint num2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_264.uint_0 - (num + 24);
		string string_ = "60B9" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 1A C6 01 01 55 8B EC6A 01E8" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "83 C4 04 8B E5 5DC605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0);
	}

	private static uint smethod_96(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		string string_ = "60B9" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "80 39 00 75 29 C6 01 018B 0D" + Class11.smethod_46(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_151.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 15 8B 11 85 D2 74 0F 8B 42 24 85 C0 74 08 55 8B EC FF D0 8B E5 5DC605" + Class11.smethod_46(num - 4, 8, bool_1: false, bool_2: true) + "0061" + smethod_10(characterAccountConfig_0.uint_98);
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(flag && characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_151.uint_0 != 0);
	}

	private static uint smethod_97(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		string string_ = "60B9" + Class11.smethod_46((characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18).ToString(), 8, bool_1: false, bool_2: true) + "C6 01 00 51B9" + Class11.smethod_46((characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_234.uint_0).ToString(), 8, bool_1: false, bool_2: true) + "8B C105" + Class11.smethod_46(Class56.memorySignatureScanConfig_235.uint_0.ToString(), 8, bool_1: false, bool_2: true) + "6A 00 50 68 65 05 00 00 89 48 60 8B 11 85 D2 74 09 8B 42 10 85 C0 74 02 FF D059 C6 01 0161" + smethod_10(characterAccountConfig_0.uint_98);
		characterAccountConfig_0.uint_18 += 4u;
		uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
		int int_ = 0;
		byte[] array = Class11.smethod_8(string_, bool_1: false);
		bool value = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		characterAccountConfig_0.uint_18 += (uint)(array.Length + 4);
		return num * Convert.ToByte(value);
	}

	private static uint smethod_98(ref CharacterAccountConfig characterAccountConfig_0)
	{
		characterAccountConfig_0.uint_18 += 4u;
		string string_ = "B8 12 00 00 00 B9 01 00 00 00 BA 01 00 00 00 6A 00 51 52 50";
		string string_2 = "83 C4 10";
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_182.uint_0, string_, string_2);
	}

	private static uint smethod_99(ref CharacterAccountConfig characterAccountConfig_0)
	{
		if (Class56.memorySignatureScanConfig_174.uint_0 != 0 && Class56.memorySignatureScanConfig_176.uint_0 != 0 && Class56.memorySignatureScanConfig_175.uint_0 != 0)
		{
			uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
			characterAccountConfig_0.uint_18 += 22u;
			uint num2 = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18 - 4;
			string string_ = "A1" + Class11.smethod_46(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_174.uint_0, 8, bool_1: false, bool_2: true) + "85 C0 74 3A8B 0D" + Class11.smethod_46(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_175.uint_0, 8, bool_1: false, bool_2: true) + "85 C9 74 30803D" + Class11.smethod_46(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_176.uint_0, 8, bool_1: false, bool_2: true) + "0074 27C605" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "016A 00 6A 00 6A 08 6A 03 6A 01 5068" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "51";
			string string_2 = "83 C4 20C605" + Class11.smethod_46(num2, 8, bool_1: false, bool_2: true) + "00";
			return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_176.uint_0, string_, string_2);
		}
		return 0u;
	}

	private static uint smethod_100(ref CharacterAccountConfig characterAccountConfig_0)
	{
		if (Class56.memorySignatureScanConfig_174.uint_0 != 0 && Class56.memorySignatureScanConfig_176.uint_0 != 0 && Class56.memorySignatureScanConfig_175.uint_0 != 0)
		{
			uint num = characterAccountConfig_0.uint_17 + characterAccountConfig_0.uint_18;
			characterAccountConfig_0.uint_18 += 80u;
			string string_ = "B8" + Class11.smethod_46(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_177.uint_0, 8, bool_1: false, bool_2: true) + "B9" + Class11.smethod_46(num, 8, bool_1: false, bool_2: true) + "6A 00 6A 01 6A 20 6A 06 6A 01 50 51 51";
			string string_2 = "83 C4 20";
			return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_176.uint_0, string_, string_2);
		}
		return 0u;
	}

	private static uint smethod_101(ref CharacterAccountConfig characterAccountConfig_0)
	{
		string string_ = "BA 01 00 00 00 6A 00 52 6A 26";
		return smethod_11(ref characterAccountConfig_0, Class56.memorySignatureScanConfig_196.uint_0, string_);
	}

	public static bool smethod_102(CharacterAccountConfig characterAccountConfig_0, uint uint_54)
	{
		if (characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_196.uint_0 != 0 && characterAccountConfig_0.uint_90 != 0 && smethod_7(characterAccountConfig_0))
		{
			if (!Class24.smethod_31(characterAccountConfig_0.uint_90 + 2, characterAccountConfig_0.int_137, uint_54))
			{
				return false;
			}
			return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_90);
		}
		return false;
	}

	public static bool smethod_103(CharacterAccountConfig characterAccountConfig_0, uint uint_54)
	{
		if (characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_225.uint_0 != 0 && characterAccountConfig_0.uint_63 != 0 && smethod_7(characterAccountConfig_0))
		{
			if (!Class24.smethod_31(characterAccountConfig_0.uint_63 + 2, characterAccountConfig_0.int_137, uint_54))
			{
				return false;
			}
			return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_63);
		}
		return false;
	}

	public static bool smethod_104(CharacterAccountConfig characterAccountConfig_0, object object_0 = null)
	{
		if (characterAccountConfig_0.uint_87 != 0 && smethod_7(characterAccountConfig_0))
		{
			int int_ = 0;
			byte[] array = new byte[1];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_87 - 4, array, 1, ref int_);
			if (array[0] > 0)
			{
				return false;
			}
			string string_ = "0/0";
			if (object_0 != null)
			{
				if (Class11.smethod_1(object_0.GetType().ToString(), "[") <= 0)
				{
					string_ = object_0.ToString();
				}
				else
				{
					uint[] array2 = (uint[])object_0;
					decimal num = Math.Round((decimal)array2[0] / 256m);
					decimal num2 = Math.Round((decimal)array2[1] / 512m);
					string_ = num + "/" + num2;
				}
			}
			array = Class11.smethod_47(string_);
			if (!Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_87 - 22, array, array.Length, ref int_))
			{
				return false;
			}
			return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_87);
		}
		return false;
	}

	public static bool smethod_105(CharacterAccountConfig characterAccountConfig_0, string string_0)
	{
		if (characterAccountConfig_0.uint_89 != 0 && smethod_7(characterAccountConfig_0))
		{
			int int_ = 0;
			byte[] array = Class11.smethod_47(string_0);
			if (Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_89 - 80, array, array.Length, ref int_))
			{
				return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_89);
			}
			return false;
		}
		return false;
	}

	public static bool smethod_106(CharacterAccountConfig characterAccountConfig_0, uint uint_54, uint uint_55 = 1u, uint uint_56 = 1u)
	{
		if (characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_182.uint_0 != 0 && characterAccountConfig_0.uint_57 != 0)
		{
			bool flag = Class24.smethod_31(characterAccountConfig_0.uint_57 + 2, characterAccountConfig_0.int_137, uint_54);
			bool flag2 = Class24.smethod_31(characterAccountConfig_0.uint_57 + 7, characterAccountConfig_0.int_137, uint_55);
			bool flag3 = Class24.smethod_31(characterAccountConfig_0.uint_57 + 12, characterAccountConfig_0.int_137, uint_56);
			if (flag && flag2 && flag3)
			{
				smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_57);
				return true;
			}
		}
		return false;
	}

    public static bool smethod_107(CharacterAccountConfig characterAccountConfig_0, object object_0)
    {
        // 1. Kiểm tra điều kiện đầu vào (Check config)
        if (characterAccountConfig_0.uint_17 == 0 ||
            Class56.memorySignatureScanConfig_186.uint_0 == 0 ||
            characterAccountConfig_0.uint_65 == 0 ||
            Class56.memorySignatureScanConfig_96.uint_0 == 0)
        {
            return false;
        }

        uint num = 500u;
        uint num2 = 297u;
        uint[] array = new uint[4] { 151u, 181u, 166u, 196u };
        uint num3 = 0u;

        // 2. Chờ trạng thái mở bảng nhân vật/tiềm năng
        long startTime = Class11.smethod_27();
        while ((num3 = Class24.smethod_30(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_96.uint_0, characterAccountConfig_0.int_137)) == 0)
        {
            if (Class11.smethod_28(startTime) > 3000L) return false;

            smethod_57(characterAccountConfig_0, "Open([[status]])");
            Thread.Sleep(600);
        }

        // 3. Xác định loại chỉ số (num4) dựa trên object_0
        uint num4 = 0u;
        string inputType = object_0.GetType().ToString().ToUpper();

        // Nếu object_0 không phải là kiểu số (int/Int32)
        if (!inputType.Contains("INT"))
        {
            string text2 = object_0.ToString().ToUpper().Trim();
            switch (text2)
            {
                case "TP":
                case "THANPHAP":
                case "1":
                    num4 = 1u; // Thân pháp
                    break;
                case "SK":
                case "SINHKHI":
                case "2":
                    num4 = 2u; // Sinh khí
                    break;
                case "NC":
                case "NOICONG":
                case "3":
                    num4 = 3u; // Nội công
                    break;
                default:
                    num4 = 0u;
                    break;
            }
        }
        else
        {
            // Nếu truyền vào là số trực tiếp
            num4 = Class11.smethod_12(object_0.ToString());
            if (num4 > 3) num4 = 3u;
        }

        // 4. Thực hiện ghi dữ liệu vào bộ nhớ (Memory Write)
        bool flag = Class24.smethod_31(characterAccountConfig_0.uint_65 + 2, characterAccountConfig_0.int_137, num4, 1);
        bool flag2 = Class24.smethod_31(characterAccountConfig_0.uint_65 + 4, characterAccountConfig_0.int_137, array[num4]);
        bool flag3 = Class24.smethod_31(characterAccountConfig_0.uint_65 + 9, characterAccountConfig_0.int_137, num2);
        bool flag4 = Class24.smethod_31(characterAccountConfig_0.uint_65 + 14, characterAccountConfig_0.int_137, num3 + num);

        // 5. Xác nhận kết quả
        if (flag && flag2 && flag3 && flag4)
        {
            bool result = smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_65);
            if (result)
            {
                Thread.Sleep(300);
            }
            return result;
        }

        return false;
    }

    public static bool smethod_108(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_17 != 0 && characterAccountConfig_0.uint_80 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
			uint num = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array, 0);
			uint num3 = num2 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
			uint num4 = BitConverter.ToUInt32(array, 0);
			uint num5 = num4 + num3;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_);
			int num6 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
			int num7 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
			int num8 = BitConverter.ToInt32(array, 0);
			int num9 = Class89.smethod_39(characterAccountConfig_0);
			if (num7 != 0 && num8 != 0 && num6 != 0 && num9 > 1)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_);
				int num10 = BitConverter.ToInt32(array, 0);
				if (smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_80))
				{
					int int_2 = 0;
					int i = 0;
					byte[] array2 = new byte[1];
					for (; i < 10; i++)
					{
						Thread.Sleep(100);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_80 - 4, array2, 1, ref int_2);
						if (array2[0] > 0)
						{
							array2[0] = 0;
							Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_80 - 4, array2, 1, ref int_2);
							break;
						}
					}
					i = 0;
					while (!Class11.bool_0 && i < 50)
					{
						Thread.Sleep(300);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
						num = BitConverter.ToUInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
						num2 = BitConverter.ToUInt32(array, 0);
						num3 = num2 * Class56.memorySignatureScanConfig_15.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
						num4 = BitConverter.ToUInt32(array, 0);
						num5 = num4 + num3;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_);
						num6 = BitConverter.ToInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
						num7 = BitConverter.ToInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_);
						int num11 = BitConverter.ToInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
						int num12 = BitConverter.ToInt32(array, 0);
						num9 = Class89.smethod_39(characterAccountConfig_0);
						if (num7 > 0 && num12 > 0 && num6 > 0 && num9 > 1 && (num12 != num8 || num11 != num10))
						{
							break;
						}
						i++;
					}
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public static void smethod_109(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_72 != 0 && Class56.memorySignatureScanConfig_11.uint_0 != 0 && Class56.memorySignatureScanConfig_233.uint_0 != 0 && Class56.memorySignatureScanConfig_13.uint_0 != 0 && Class56.memorySignatureScanConfig_15.uint_0 != 0 && Class56.memorySignatureScanConfig_14.uint_0 != 0)
		{
			int int_1 = 0;
			byte[] array = new byte[1];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_72 - 4, array, 1, ref int_1);
			if (array[0] <= 0)
			{
				Class24.smethod_31(characterAccountConfig_0.uint_72 + 2, characterAccountConfig_0.int_137, (uint)int_0);
				smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_72);
			}
		}
	}

	public static bool smethod_110(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		if (characterAccountConfig_0.uint_18 != 0 && Class56.memorySignatureScanConfig_185.uint_0 != 0)
		{
			uint num = Convert.ToUInt32(bool_0);
			Class24.smethod_31(characterAccountConfig_0.uint_64 + 2, characterAccountConfig_0.int_137, num, 1);
			return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_64);
		}
		return false;
	}

	public static void smethod_111(CharacterAccountConfig characterAccountConfig_0, uint uint_54 = 1u)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_68 != 0)
		{
			if (uint_54 != 1)
			{
				uint_54 = 0u;
			}
			Class24.smethod_31(characterAccountConfig_0.uint_68 + 2, characterAccountConfig_0.int_137, uint_54, 1);
			smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_68);
		}
	}

	public static void smethod_112(CharacterAccountConfig characterAccountConfig_0, uint uint_54 = 1u)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_69 != 0)
		{
			if (uint_54 != 1)
			{
				uint_54 = 0u;
				uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_12.uint_0;
				uint num2 = num + Class56.memorySignatureScanConfig_75.uint_0;
				uint num3 = (4 + Class56.memorySignatureScanConfig_230.uint_0) * 7;
				Class24.smethod_31(num2 + num3 * 4, characterAccountConfig_0.int_137, 0u);
			}
			Class24.smethod_31(characterAccountConfig_0.uint_69 + 2, characterAccountConfig_0.int_137, uint_54, 1);
			smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_69);
		}
	}

	public static uint smethod_113(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_12.uint_0;
		uint num2 = num + Class56.memorySignatureScanConfig_75.uint_0;
		uint num3 = (4 + Class56.memorySignatureScanConfig_230.uint_0) * 7;
		return Class24.smethod_30(num2 + num3 * 4, characterAccountConfig_0.int_137);
	}

	public static void smethod_114(CharacterAccountConfig characterAccountConfig_0, uint uint_54)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_70 != 0)
		{
			Class24.smethod_31(characterAccountConfig_0.uint_70 + 2, characterAccountConfig_0.int_137, uint_54);
			smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_70);
		}
	}

	public static void smethod_115(CharacterAccountConfig characterAccountConfig_0, string[] string_0 = null)
	{
		if (characterAccountConfig_0.uint_18 == 0 || characterAccountConfig_0.uint_67 == 0)
		{
			return;
		}
		string text = Class55.smethod_2(characterAccountConfig_0, bool_0: true);
		string[] array = text.Split(';');
		if (array.Length < 2)
		{
			return;
		}
		if (string_0 != null && string_0.Length != 0)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (array[1] == string_0[i] || Class1.smethod_1(array[1], 1) == string_0[i])
				{
					Class55.smethod_0(characterAccountConfig_0);
					return;
				}
			}
		}
		uint num = Class11.smethod_12(array[0]);
		Class24.smethod_31(characterAccountConfig_0.uint_67 + 4, characterAccountConfig_0.int_137, num);
		smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_67);
	}

	public static void smethod_116(CharacterAccountConfig characterAccountConfig_0, uint uint_54, uint uint_55)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_50 != 0)
		{
			Class24.smethod_31(characterAccountConfig_0.uint_50 + 4, characterAccountConfig_0.int_137, uint_55);
			Class24.smethod_31(characterAccountConfig_0.uint_50 + 9, characterAccountConfig_0.int_137, uint_54);
			smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_50);
		}
	}

	public static bool smethod_117(CharacterAccountConfig characterAccountConfig_0, uint uint_54)
	{
		if (characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_187.uint_0 != 0 && characterAccountConfig_0.uint_66 != 0)
		{
			if (Class24.smethod_31(characterAccountConfig_0.uint_66 + 2, characterAccountConfig_0.int_137, uint_54))
			{
				return smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_66);
			}
			return false;
		}
		return false;
	}

	public static void smethod_118(CharacterAccountConfig characterAccountConfig_0)
	{
		smethod_106(characterAccountConfig_0, 34u);
	}

	public static void smethod_119(CharacterAccountConfig characterAccountConfig_0)
	{
		smethod_106(characterAccountConfig_0, 18u);
	}

	public static void smethod_120(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_60 != 0)
		{
			smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_60);
		}
	}

	public static void smethod_121(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_45 != 0)
		{
			smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_45);
		}
	}

	public static string smethod_122(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		string text = "";
		string text2 = "";
		uint[] array = Class38.smethod_30(characterAccountConfig_0);
		if (array != null)
		{
			uint uint_ = array[0];
			uint num = array[1];
			uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
			int num4 = 25;
			for (int i = 0; i < 256; i++)
			{
				uint num5 = num2 + (uint)(i * (int)Class56.memorySignatureScanConfig_15.uint_0);
				int num6 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
				if (num6 > 0)
				{
					int num7 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137);
					uint num8 = Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137);
					uint num9 = Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137);
					long num10 = smethod_4(uint_, num, num8, num9);
					string text3 = "\"" + Class24.smethod_28(num5 + Class56.memorySignatureScanConfig_16.uint_0, characterAccountConfig_0.int_137) + "\"";
					while (text3.Length < num4)
					{
						text3 += " ";
					}
					string text4 = text;
					text = text4 + "-- " + i + "\t" + num7 + "   \t" + text3 + " {" + num8 + "," + num9 + "}, ( " + num8 / 256 + "," + num9 / 512 + " )\t" + num10 + "\t" + Math.Round(Math.Sqrt(num10), 0) + Class56.string_7;
				}
				int num11 = (int)Class24.smethod_30(num3 + (uint)(i * (int)Class56.memorySignatureScanConfig_127.uint_0), characterAccountConfig_0.int_137);
				if (num11 > 0)
				{
					int num12 = Class84.smethod_6(characterAccountConfig_0, i, num3);
					uint[] array2 = Class84.smethod_3(characterAccountConfig_0, i, num3);
					if (array2 == null)
					{
						uint[] array3 = new uint[2];
						array2 = array3;
					}
					long num13 = smethod_4(uint_, num, array2[0], array2[1]);
					string text5 = "\"" + Class84.smethod_5(characterAccountConfig_0, i, num3) + "\"";
					while (text5.Length < num4)
					{
						text5 += " ";
					}
					string text6 = text2;
					text2 = text6 + "-- " + i + "\t" + num12 + "   \t" + text5 + " {" + array2[0] + "," + array2[1] + "}, ( " + array2[0] / 256 + "," + array2[1] / 512 + " )\t" + num13 + "\t" + Math.Round(Math.Sqrt(num13), 0) + Class56.string_7;
				}
			}
			string text7 = "Map " + Class39.smethod_0(characterAccountConfig_0) + " = \"" + Class39.smethod_2(characterAccountConfig_0) + "\"; { " + uint_.ToString() + "," + num + " }" + Class56.string_7 + "=============================================================================================" + Class56.string_7 + "-- STT\tKind\tNPC name    \t\t  {posx, posy}\t   x/y screen\tLength\tSqrt(Length)" + Class56.string_7 + "[npc]" + Class56.string_7 + "=============================================================================================" + Class56.string_7 + "-- STT\tKind\tObject name  \t\t  {posx, posy}\t   x/y screen\tLength\tSqrt(Length)" + Class56.string_7 + "[object]" + Class56.string_7;
			text7 = text7.Replace("[npc]", text).Replace("[object]", text2) + Class56.string_7 + "=============================================================================================";
			if (bool_0)
			{
				string string_ = "Software\\Microsoft\\Notepad";
				string text8 = Class66.smethod_2(string_, "lfFaceName", 0);
				Class56.smethod_25("object_npc_info.txt", text7, bool_2: true, "VK Sans Serif", 12, 870, 425, 200, 280);
				if (text8 != "")
				{
					Class66.smethod_11(string_, "lfFaceName", text8, "", 1);
				}
			}
			return text7;
		}
		return "";
	}

	public static string smethod_123(CharacterAccountConfig characterAccountConfig_0, int int_0 = 0)
	{
		uint[] array = Class38.smethod_30(characterAccountConfig_0);
		if (array == null)
		{
			return "";
		}
		int num = Class38.smethod_17(characterAccountConfig_0);
		uint uint_ = array[0];
		uint uint_2 = array[1];
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		int num4 = -1;
		long num5 = 0L;
		long num6 = 0L;
		uint[] array2 = null;
		string text = "";
		int num7 = -1;
		long num8 = 0L;
		long num9 = 0L;
		uint[] array3 = null;
		string text2 = "";
		for (int i = 0; i < 256; i++)
		{
			uint num10 = num2 + (uint)(i * (int)Class56.memorySignatureScanConfig_15.uint_0);
			int num11 = (int)Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
			if (i != num && num11 > 0)
			{
				uint[] array4 = new uint[2]
				{
					Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
				num6 = smethod_4(uint_, uint_2, array4[0], array4[1]);
				if (num4 < 0 || num6 < num5)
				{
					num4 = i;
					num5 = num6;
					array2 = array4;
					text = Class24.smethod_28(num10 + Class56.memorySignatureScanConfig_16.uint_0, characterAccountConfig_0.int_137);
				}
			}
			int num12 = (int)Class24.smethod_30(num3 + (uint)(i * (int)Class56.memorySignatureScanConfig_127.uint_0), characterAccountConfig_0.int_137);
			if (num12 > 0)
			{
				uint[] array5 = Class84.smethod_3(characterAccountConfig_0, i, num3);
				if (array5 == null)
				{
					uint[] array6 = new uint[2];
					array5 = array6;
				}
				num9 = smethod_4(uint_, uint_2, array5[0], array5[1]);
				if (num7 < 0 || num9 < num8)
				{
					num7 = i;
					num8 = num9;
					array3 = array5;
					text2 = Class84.smethod_5(characterAccountConfig_0, i, num3);
				}
			}
		}
		if (num7 > 0 && (num4 < 0 || num8 < num5))
		{
			num4 = num7;
			num5 = num8;
			array2 = array3;
			text = text2;
		}
		string result = "";
		switch (int_0)
		{
		default:
			if (num4 > 0 && array2 != null)
			{
				result = num4 + "|" + text + "|X = " + array2[0] + ", Y = " + array2[1] + "|" + num5;
			}
			break;
		case 2:
			result = "{ X = " + array2[0] + ", Y = " + array2[1] + " }";
			break;
		case 1:
			result = text;
			break;
		}
		return result;
	}

	public static string smethod_124(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		uint[] array = Class38.smethod_30(characterAccountConfig_0);
		if (array == null)
		{
			return "";
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + (uint)(int_0 * (int)Class56.memorySignatureScanConfig_15.uint_0);
		int num3 = (int)Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
		int num4 = (int)Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137);
		uint uint_ = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137);
		uint uint_2 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137);
		long num5 = smethod_4(array[0], array[1], uint_, uint_2);
		string text = "\"" + Class24.smethod_28(num2 + Class56.memorySignatureScanConfig_16.uint_0, characterAccountConfig_0.int_137) + "\"";
		int num6 = Class39.smethod_0(characterAccountConfig_0);
		return "MapID = " + num6.ToString() + Class56.string_7 + Class39.smethod_2(characterAccountConfig_0) + Class56.string_7 + "=============================" + Class56.string_7 + "- Exist\t: " + num3.ToString() + Class56.string_7 + "- Kind\t: " + num4.ToString() + Class56.string_7 + "- Name\t: " + text + Class56.string_7 + "- NOPos\t: {" + array[0].ToString() + "," + array[1] + "}" + Class56.string_7 + "- Length\t: " + num5.ToString() + Class56.string_7 + "- Sqrt(L)\t: " + ((int)Math.Sqrt(num5)).ToString();
	}
}
