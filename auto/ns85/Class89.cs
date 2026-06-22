using System;
using System.Threading;
using ns1;
using ns100;
using ns11;
using ns23;
using ns53;
using ns71;
using ns83;
using ns88;

namespace ns85;

internal class Class89
{
	private static uint uint_0 = 19u;

	private static uint uint_1 = 11u;

	private static string string_0 = null;

	private static uint uint_2 = 4u;

	private static long long_0 = 0L;

	public static uint smethod_0(CharacterAccountConfig characterAccountConfig_0, string string_1 = "\\settings\\shop\\type.txt")
	{
		uint num = Class24.smethod_1(characterAccountConfig_0.int_137, 86016u);
		if (num != 0)
		{
			uint num2 = num + 128;
			uint num3 = num2 - 128;
			uint num4 = num2 + 32;
			int int_ = 0;
			byte[] array = new byte[6];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_4.uint_0 + 11, array, array.Length, ref int_);
			byte[] array2 = Class11.smethod_47(string_1);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num + 4, array2, array2.Length, ref int_);
			string string_2 = "6068" + Class11.smethod_46(num3 + 4, 8, bool_1: false, bool_2: true) + "B9" + Class11.smethod_46(num4, 8, bool_1: false, bool_2: true) + "FF 15 00 00 00 0061C6 05" + Class11.smethod_46(num3, 8, bool_1: false, bool_2: true) + "01" + Class75.smethod_10(characterAccountConfig_0.uint_98);
			array2 = Class11.smethod_8(string_2);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array2, array2.Length, ref int_);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2 + 11, array, array.Length, ref int_);
			Class75.smethod_12(characterAccountConfig_0.int_137, num2);
			int num5 = 0;
			byte[] array3 = new byte[4];
			uint result = 0u;
			bool flag = false;
			while (num5 < 10)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3, array3, 1, ref int_);
				if (array3[0] <= 0)
				{
					num5++;
					Thread.Sleep(100);
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + 12, array3, 4, ref int_);
				result = BitConverter.ToUInt32(array3, 0);
				flag = true;
				break;
			}
			if (flag)
			{
				Class24.smethod_2(characterAccountConfig_0.int_137, num);
			}
			return result;
		}
		return 0u;
	}

	public static Struct24[] smethod_1(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = smethod_0(characterAccountConfig_0);
		if (num != 0)
		{
			int int_ = 0;
			byte[] array = new byte[512];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
			string text = Class1.smethod_3(array).Replace("\r", "\n").Replace("\n\n", "\n");
			string[] array2 = text.Split('\n');
			if (array2.Length > 1 && Class11.smethod_1(array2[0].ToUpper(), "TYPENAME") >= 0)
			{
				int num2 = 0;
				Struct24[] array3 = null;
				for (int i = 1; i < array2.Length && array2[i] != null && !(array2[i] == string.Empty); i++)
				{
					string[] array4 = array2[i].Split('\t');
					if (array4.Length == 2)
					{
						int int_2 = Class11.smethod_11(array4[1]);
						num2++;
						if (num2 == 1)
						{
							array3 = new Struct24[1]
							{
								new Struct24
								{
									int_0 = int_2,
									string_0 = array4[0]
								}
							};
						}
						else
						{
							Array.Resize(ref array3, num2);
							ref Struct24 reference = ref array3[num2 - 1];
							reference = new Struct24
							{
								int_0 = int_2,
								string_0 = array4[0]
							};
						}
					}
				}
				return array3;
			}
			return null;
		}
		return null;
	}

	public static string smethod_2(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = smethod_0(characterAccountConfig_0);
		if (num == 0)
		{
			return string.Empty;
		}
		int int_ = 0;
		byte[] array = new byte[80];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array, array.Length, ref int_);
		string text = Class1.smethod_3(array).Replace("\r", "\n").Replace("\n\n", "\n");
		string[] array2 = text.Split('\n');
		text = string.Empty;
		if (array2.Length > 1 && Class11.smethod_1(array2[0].ToUpper(), "TYPENAME") == 0)
		{
			array2 = array2[1].Split('\t');
			text = array2[0];
		}
		return text;
	}

	public static int smethod_3(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_1.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			if (Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_1.uint_0, array, 4, ref int_))
			{
				return BitConverter.ToInt32(array, 0);
			}
			return -1;
		}
		return -1;
	}

	public static bool smethod_4(CharacterAccountConfig characterAccountConfig_0)
	{
		if (string_0 == string.Empty || string_0 == null || Class11.smethod_28(long_0) > 600000L)
		{
			string_0 = smethod_2(characterAccountConfig_0);
			if ((string_0 == null || string_0 == string.Empty) && Form1.string_7 != null && 0 <= Form1.int_4 && Form1.int_4 < Form1.string_7.GetLength(0))
			{
				string_0 = Form1.string_7[Form1.int_4, 1];
			}
			long_0 = Class11.smethod_27();
		}
		return Class75.smethod_26(characterAccountConfig_0, string_0);
	}

	public static uint smethod_5(CharacterAccountConfig characterAccountConfig_0)
	{
		if (Class56.memorySignatureScanConfig_5.uint_0 == 0)
		{
			return 0u;
		}
		if (characterAccountConfig_0.uint_8 == 0)
		{
			characterAccountConfig_0.uint_8 = Class24.smethod_37(characterAccountConfig_0.int_136, "engine.dll");
			if (characterAccountConfig_0.uint_8 == 0)
			{
				return 0u;
			}
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, characterAccountConfig_0.int_136);
			if (0 <= num)
			{
				Form1.characterAccountConfig_1[num].uint_8 = characterAccountConfig_0.uint_8;
			}
		}
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_8 + Class56.memorySignatureScanConfig_5.uint_0, array, 4, ref int_);
		return BitConverter.ToUInt32(array, 0);
	}

	public static uint smethod_6(CharacterAccountConfig characterAccountConfig_0)
	{
		if (Class56.memorySignatureScanConfig_5.uint_0 == 0)
		{
			return 0u;
		}
		int int_ = 0;
		byte[] array = new byte[4];
		uint result = 0u;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_8 + Class56.memorySignatureScanConfig_5.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		if (num != 0)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_6.uint_0, array, 4, ref int_);
			result = BitConverter.ToUInt32(array, 0);
		}
		return result;
	}

	public static bool smethod_7(CharacterAccountConfig characterAccountConfig_0, uint uint_3)
	{
		if (Class56.memorySignatureScanConfig_6.uint_0 != 0)
		{
			uint num = smethod_5(characterAccountConfig_0);
			if (num == 0)
			{
				return false;
			}
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(uint_3);
			uint uint_4 = num + Class56.memorySignatureScanConfig_6.uint_0;
			return Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_4, bytes, bytes.Length, ref int_);
		}
		return false;
	}

	public static bool smethod_8(CharacterAccountConfig characterAccountConfig_0, int[] int_0)
	{
		if (Class56.memorySignatureScanConfig_6.uint_0 != 0)
		{
			uint num = smethod_5(characterAccountConfig_0);
			if (num == 0)
			{
				return false;
			}
			uint value = (uint)((int_0[1] << 16) + int_0[0]);
			int int_1 = 0;
			byte[] bytes = BitConverter.GetBytes(value);
			uint uint_ = num + Class56.memorySignatureScanConfig_6.uint_0;
			return Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_, bytes, bytes.Length, ref int_1);
		}
		return false;
	}

	public static bool smethod_9(CharacterAccountConfig characterAccountConfig_0, int int_0, int int_1)
	{
		if (Class56.memorySignatureScanConfig_6.uint_0 != 0)
		{
			uint num = smethod_5(characterAccountConfig_0);
			if (num == 0)
			{
				return false;
			}
			uint value = (uint)((int_1 << 16) + int_0);
			int int_2 = 0;
			byte[] bytes = BitConverter.GetBytes(value);
			uint uint_ = num + Class56.memorySignatureScanConfig_6.uint_0;
			return Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_, bytes, bytes.Length, ref int_2);
		}
		return false;
	}

	public static uint[] smethod_10(uint[] uint_3, uint[] uint_4)
	{
		int num = (int)(400 - (uint_3[0] - uint_4[0]));
		int num2 = 300 - (int)(uint_3[1] - uint_4[1]) / 2;
		return new uint[2]
		{
			(uint)num,
			(uint)num2
		};
	}

	public static uint[] smethod_11(uint[] uint_3, int int_0, int int_1)
	{
		int num = (int)uint_3[0] - (400 - int_0);
		int num2 = (int)uint_3[1] - (300 - int_1) * 2;
		return new uint[2]
		{
			(uint)num,
			(uint)num2
		};
	}

	public static int smethod_12(CharacterAccountConfig characterAccountConfig_0)
	{
		if (Class56.memorySignatureScanConfig_5.uint_0 == 0)
		{
			return 0;
		}
		int int_ = 0;
		int result = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_8 + Class56.memorySignatureScanConfig_5.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		if (num != 0)
		{
			uint uint_ = num + Class56.memorySignatureScanConfig_6.uint_0 + uint_2;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 1, ref int_);
			result = array[0];
		}
		return result;
	}

	public static int smethod_13(CharacterAccountConfig characterAccountConfig_0)
	{
		if (Class56.memorySignatureScanConfig_6.uint_0 != 0)
		{
			uint num = smethod_5(characterAccountConfig_0);
			if (num == 0)
			{
				return 0;
			}
			int int_ = 0;
			byte[] array = new byte[4];
			uint uint_ = num + Class56.memorySignatureScanConfig_6.uint_0 + uint_2;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 4, ref int_);
			return BitConverter.ToInt32(array, 0);
		}
		return -1;
	}

	public static void smethod_14(CharacterAccountConfig characterAccountConfig_0)
	{
		if (Class56.memorySignatureScanConfig_6.uint_0 != 0)
		{
			uint num = smethod_5(characterAccountConfig_0);
			if (num != 0)
			{
				int int_ = 0;
				byte[] byte_ = new byte[4];
				uint uint_ = num + Class56.memorySignatureScanConfig_6.uint_0 + uint_2;
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_, byte_, 4, ref int_);
			}
		}
	}

	public static void smethod_15(uint uint_3, uint uint_4)
	{
		Class24.SendMessage(uint_3, Class24.int_36, Class24.int_39, uint_4);
		Class24.SendMessage(uint_3, Class24.int_37, Class24.int_39, uint_4);
	}

	public static string smethod_16(CharacterAccountConfig characterAccountConfig_0)
	{
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_94.uint_0 + Class56.memorySignatureScanConfig_95.uint_0;
		return Class24.smethod_28(uint_, characterAccountConfig_0.int_137);
	}

	public static bool smethod_17(CharacterAccountConfig characterAccountConfig_0)
	{
		return Class24.smethod_30(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_96.uint_0, characterAccountConfig_0.int_137) != 0;
	}

	public static uint smethod_18(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_209.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_208.uint_0;
		return Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_211.uint_0, characterAccountConfig_0.int_137);
	}

	public static uint smethod_19(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_209.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_207.uint_0;
		return Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_211.uint_0, characterAccountConfig_0.int_137);
	}

	public static string smethod_20(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_209.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_208.uint_0;
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_211.uint_0, characterAccountConfig_0.int_137);
		if (num3 == 0)
		{
			return null;
		}
		uint num4 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_212.uint_0, characterAccountConfig_0.int_137);
		uint num5 = Class24.smethod_30(num4 + (num3 - 1) * 4, characterAccountConfig_0.int_137);
		int num6 = (int)Class24.smethod_30(num5 + 24, characterAccountConfig_0.int_137);
		num6 -= (int)uint_1;
		if (num6 <= 0)
		{
			return null;
		}
		uint uint_ = num5 + Class56.memorySignatureScanConfig_213.uint_0 + uint_1;
		string text = Class24.smethod_29(uint_, characterAccountConfig_0.int_137, num6);
		if (text.IndexOf('\0') > 0)
		{
			uint uint_2 = Class24.smethod_30(Class56.memorySignatureScanConfig_214.uint_0, characterAccountConfig_0.int_137) + 28;
			string text2 = Class24.smethod_28(uint_2, characterAccountConfig_0.int_137, num6);
			text = text.Replace('\0'.ToString(), "<" + text2 + ">");
		}
		return smethod_33(text, null, " ");
	}

	public static void smethod_21(CharacterAccountConfig characterAccountConfig_0, string string_1)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_209.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_208.uint_0;
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_211.uint_0, characterAccountConfig_0.int_137);
		if (num3 == 0)
		{
			return;
		}
		uint num4 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_212.uint_0, characterAccountConfig_0.int_137);
		uint num5 = Class24.smethod_30(num4 + (num3 - 1) * 4, characterAccountConfig_0.int_137);
		int num6 = (int)Class24.smethod_30(num5 + 24, characterAccountConfig_0.int_137);
		num6 -= (int)uint_1;
		if (num6 > 0)
		{
			uint uint_ = num5 + Class56.memorySignatureScanConfig_213.uint_0 + uint_1;
			if (string_1 == null || string_1 == string.Empty)
			{
				string_1 = "0K...";
			}
			if (string_1.Length > num6)
			{
				string_1 = string_1.Substring(0, num6);
			}
			int int_ = 0;
			byte[] array = Class11.smethod_47(string_1);
			num6 = array.Length + (int)uint_1;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_, array, array.Length, ref int_);
			array = BitConverter.GetBytes(num6);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num5 + 24, array, array.Length, ref int_);
		}
	}

	public static string smethod_22(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_209.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_207.uint_0;
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_211.uint_0, characterAccountConfig_0.int_137);
		if (num3 == 0)
		{
			return null;
		}
		uint num4 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_212.uint_0, characterAccountConfig_0.int_137);
		uint num5 = Class24.smethod_30(num4 + (num3 - 1) * 4, characterAccountConfig_0.int_137);
		int num6 = (int)Class24.smethod_30(num5 + 24, characterAccountConfig_0.int_137);
		num6 -= (int)uint_0;
		if (num6 <= 0)
		{
			return null;
		}
		uint uint_ = num5 + Class56.memorySignatureScanConfig_213.uint_0 + uint_0;
		string text = Class24.smethod_29(uint_, characterAccountConfig_0.int_137, num6);
		if (Class11.smethod_1(text, '\0') > 0)
		{
			uint uint_2 = Class24.smethod_30(Class56.memorySignatureScanConfig_214.uint_0, characterAccountConfig_0.int_137) + 28;
			string text2 = Class24.smethod_28(uint_2, characterAccountConfig_0.int_137, num6);
			text = text.Replace('\0'.ToString(), "<" + text2 + ">");
		}
		return smethod_33(text, null, " ");
	}

	public static void smethod_23(CharacterAccountConfig characterAccountConfig_0, string string_1)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_209.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_207.uint_0;
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_211.uint_0, characterAccountConfig_0.int_137);
		if (num3 == 0)
		{
			return;
		}
		uint num4 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_212.uint_0, characterAccountConfig_0.int_137);
		uint num5 = Class24.smethod_30(num4 + (num3 - 1) * 4, characterAccountConfig_0.int_137);
		int num6 = (int)Class24.smethod_30(num5 + 24, characterAccountConfig_0.int_137);
		num6 -= (int)uint_0;
		if (num6 > 0)
		{
			uint uint_ = num5 + Class56.memorySignatureScanConfig_213.uint_0 + uint_0;
			if (string_1 == null || string_1 == string.Empty)
			{
				string_1 = "0K..";
			}
			if (string_1.Length > num6)
			{
				string_1 = string_1.Substring(0, num6);
			}
			int int_ = 0;
			byte[] array = Class11.smethod_47(string_1);
			num6 = array.Length + (int)uint_0;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_, array, array.Length, ref int_);
			array = BitConverter.GetBytes(num6);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num5 + 24, array, array.Length, ref int_);
		}
	}

	public static string smethod_24(CharacterAccountConfig characterAccountConfig_0, uint uint_3)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_209.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_208.uint_0;
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_212.uint_0, characterAccountConfig_0.int_137);
		uint num4 = Class24.smethod_30(num3 + uint_3 * 4, characterAccountConfig_0.int_137);
		int num5 = (int)Class24.smethod_30(num4 + 24, characterAccountConfig_0.int_137);
		num5 -= 11;
		if (num5 <= 0)
		{
			return null;
		}
		uint uint_4 = num4 + Class56.memorySignatureScanConfig_213.uint_0 + uint_1;
		string text = Class24.smethod_29(uint_4, characterAccountConfig_0.int_137, num5);
		if (text.IndexOf('\0') > 0)
		{
			uint num6 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_211.uint_0, characterAccountConfig_0.int_137);
			if (uint_3 == num6 - 1)
			{
				uint uint_5 = Class24.smethod_30(Class56.memorySignatureScanConfig_214.uint_0, characterAccountConfig_0.int_137) + 28;
				string text2 = Class24.smethod_28(uint_5, characterAccountConfig_0.int_137, num5);
				text = text.Replace('\0'.ToString(), "<" + text2 + ">");
			}
		}
		return smethod_33(text, null, " ");
	}

	public static string smethod_25(CharacterAccountConfig characterAccountConfig_0, uint uint_3)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_209.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_207.uint_0;
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_212.uint_0, characterAccountConfig_0.int_137);
		uint num4 = Class24.smethod_30(num3 + uint_3 * 4, characterAccountConfig_0.int_137);
		int num5 = (int)Class24.smethod_30(num4 + 24, characterAccountConfig_0.int_137);
		num5 -= 19;
		if (num5 <= 0)
		{
			return null;
		}
		uint uint_4 = num4 + Class56.memorySignatureScanConfig_213.uint_0 + uint_0;
		string text = Class24.smethod_29(uint_4, characterAccountConfig_0.int_137, num5);
		if (Class11.smethod_1(text, '\0') > 0)
		{
			uint num6 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_211.uint_0, characterAccountConfig_0.int_137);
			if (uint_3 == num6 - 1)
			{
				uint uint_5 = Class24.smethod_30(Class56.memorySignatureScanConfig_214.uint_0, characterAccountConfig_0.int_137) + 28;
				string text2 = Class24.smethod_28(uint_5, characterAccountConfig_0.int_137, num5);
				text = text.Replace('\0'.ToString(), "<" + text2 + ">");
			}
		}
		return smethod_33(text, null, " ");
	}

	public static string[] smethod_26(CharacterAccountConfig characterAccountConfig_0, uint uint_3)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_209.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_207.uint_0;
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_211.uint_0, characterAccountConfig_0.int_137);
		uint num4 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_212.uint_0, characterAccountConfig_0.int_137);
		if (num3 <= uint_3)
		{
			uint_3 = num3;
		}
		uint num5 = num3 - uint_3;
		int num6 = 0;
		string[] array = new string[uint_3];
		for (uint num7 = num5; num7 < num3; num7++)
		{
			uint num8 = num5 + (num3 - num7) - 1;
			uint num9 = Class24.smethod_30(num4 + num8 * 4, characterAccountConfig_0.int_137);
			int num10 = (int)Class24.smethod_30(num9 + 24, characterAccountConfig_0.int_137);
			num10 -= 19;
			if (num10 > 0)
			{
				uint uint_4 = num9 + Class56.memorySignatureScanConfig_213.uint_0 + uint_0;
				string text = Class24.smethod_29(uint_4, characterAccountConfig_0.int_137, num10);
				if (!(text == string.Empty))
				{
					array[num6] = smethod_33(text, null, " ");
					num6++;
				}
			}
		}
		return array;
	}

	public static string smethod_27(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_209.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_208.uint_0;
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_211.uint_0, characterAccountConfig_0.int_137);
		uint num4 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_212.uint_0, characterAccountConfig_0.int_137);
		string text = null;
		for (uint num5 = 0u; num5 < num3; num5++)
		{
			uint num6 = Class24.smethod_30(num4 + num5 * 4, characterAccountConfig_0.int_137);
			int num7 = (int)Class24.smethod_30(num6 + 24, characterAccountConfig_0.int_137);
			num7 -= 11;
			if (num7 > 0)
			{
				uint uint_ = num6 + Class56.memorySignatureScanConfig_213.uint_0 + uint_1;
				string text2 = Class24.smethod_29(uint_, characterAccountConfig_0.int_137, num7);
				if (!(text2 == ""))
				{
					object obj = text;
					text = string.Concat(obj, "(", num5, ")", smethod_33(text2, null, " "), Class56.string_7);
				}
			}
		}
		return text;
	}

	public static string smethod_28(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_209.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_207.uint_0;
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_211.uint_0, characterAccountConfig_0.int_137);
		uint num4 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_212.uint_0, characterAccountConfig_0.int_137);
		string text = string.Empty;
		for (uint num5 = 0u; num5 < num3; num5++)
		{
			uint num6 = Class24.smethod_30(num4 + num5 * 4, characterAccountConfig_0.int_137);
			int num7 = (int)Class24.smethod_30(num6 + 24, characterAccountConfig_0.int_137);
			num7 -= 19;
			if (num7 > 0)
			{
				uint uint_ = num6 + Class56.memorySignatureScanConfig_213.uint_0 + uint_0;
				string text2 = Class24.smethod_29(uint_, characterAccountConfig_0.int_137, num7);
				if (!(text2 == ""))
				{
					object obj = text;
					text = string.Concat(obj, "(", num5, ")", smethod_33(text2, null, " "), Class56.string_7);
				}
			}
		}
		return text;
	}

	public static string smethod_29(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_209.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_208.uint_0;
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_212.uint_0, characterAccountConfig_0.int_137);
		string text = null;
		for (uint num4 = 0u; num4 < 256; num4++)
		{
			uint num5 = Class24.smethod_30(num3 + num4 * 4, characterAccountConfig_0.int_137);
			int num6 = (int)Class24.smethod_30(num5 + 24, characterAccountConfig_0.int_137);
			num6 -= 11;
			if (num6 > 0)
			{
				uint uint_ = num5 + Class56.memorySignatureScanConfig_213.uint_0 + uint_1;
				string text2 = Class24.smethod_29(uint_, characterAccountConfig_0.int_137, num6);
				if (!(text2 == ""))
				{
					object obj = text;
					text = string.Concat(obj, "(", num4, ")", smethod_33(text2, null, " "), Class56.string_7);
				}
			}
		}
		return text;
	}

	public static string smethod_30(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_209.uint_0, characterAccountConfig_0.int_137);
		uint num2 = num + Class56.memorySignatureScanConfig_207.uint_0;
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_212.uint_0, characterAccountConfig_0.int_137);
		string text = null;
		for (uint num4 = 0u; num4 < 256; num4++)
		{
			uint num5 = Class24.smethod_30(num3 + num4 * 4, characterAccountConfig_0.int_137);
			int num6 = (int)Class24.smethod_30(num5 + 24, characterAccountConfig_0.int_137);
			num6 -= 19;
			if (num6 > 0)
			{
				uint uint_ = num5 + Class56.memorySignatureScanConfig_213.uint_0 + uint_0;
				string text2 = Class24.smethod_29(uint_, characterAccountConfig_0.int_137, num6);
				if (!(text2 == ""))
				{
					object obj = text;
					text = string.Concat(obj, "(", num4, ")", smethod_33(text2, null, " "), Class56.string_7);
				}
			}
		}
		return text;
	}

	public static void smethod_31(CharacterAccountConfig characterAccountConfig_0, object object_0, bool bool_0 = true, uint uint_3 = 3u)
	{
		if (object_0 != null && characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_85 != 0 && Class56.memorySignatureScanConfig_210.uint_0 != 0)
		{
			uint uint_4 = Class56.memorySignatureScanConfig_207.uint_0;
			if (bool_0)
			{
				uint_3 = 3u;
				uint_4 = Class56.memorySignatureScanConfig_208.uint_0;
			}
			string[] array = new string[2] { "Cong bo", "Abc" };
			string string_ = object_0.GetType().ToString().ToUpper();
			if (Class11.smethod_1(string_, "[") <= 0)
			{
				array[1] = object_0.ToString();
			}
			else
			{
				array = (string[])object_0;
			}
			Class24.smethod_31(characterAccountConfig_0.uint_85 + 2, characterAccountConfig_0.int_137, uint_3);
			Class24.smethod_31(characterAccountConfig_0.uint_85 + 7, characterAccountConfig_0.int_137, (uint)array[1].Length);
			Class24.smethod_31(characterAccountConfig_0.uint_85 + 19, characterAccountConfig_0.int_137, uint_4);
			int int_ = 0;
			byte[] array2 = Class11.smethod_47(array[0]);
			uint num = characterAccountConfig_0.uint_85 - Class75.uint_1;
			bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num, array2, array2.Length, ref int_);
			array2 = Class11.smethod_47(array[1]);
			bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num + 80, array2, array2.Length, ref int_);
			if (flag && flag2)
			{
				Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_85);
			}
		}
	}

	public static void smethod_32(CharacterAccountConfig characterAccountConfig_0, uint uint_3)
	{
		if (characterAccountConfig_0.uint_18 != 0 && characterAccountConfig_0.uint_86 != 0)
		{
			Class24.smethod_31(characterAccountConfig_0.uint_86 + 2, characterAccountConfig_0.int_137, uint_3);
			Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_86);
		}
	}

	private static string smethod_33(string string_1, byte[] byte_0, string string_2 = "")
	{
		if (string_1 != null && string_1 != "")
		{
			if (byte_0 == null)
			{
				byte_0 = new byte[30];
				for (byte b = 0; b < byte_0.Length; b++)
				{
					byte_0[b] = b;
				}
			}
			for (int i = 0; i < byte_0.Length; i++)
			{
				string text = string_1;
				char c = (char)byte_0[i];
				string_1 = text.Replace(c.ToString(), string_2);
			}
		}
		return string_1;
	}

	public static bool smethod_34(CharacterAccountConfig characterAccountConfig_0, int int_0 = -1)
	{
		if (characterAccountConfig_0.uint_7 != 0)
		{
			int int_1 = 0;
			byte[] array = new byte[4];
			if (int_0 >= 0)
			{
				if (int_0 == 0)
				{
					array = new byte[1] { 2 };
					return Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_250.uint_0 + 6, array, 1, ref int_1);
				}
				if (int_0 <= 0)
				{
					return false;
				}
				array = new byte[1] { 235 };
				uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_250.uint_0 + 7;
				return Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_, array, 1, ref int_1);
			}
			array = new byte[2] { 1, 116 };
			return Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_250.uint_0 + 6, array, 2, ref int_1);
		}
		return false;
	}

	public static int smethod_35(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = false)
	{
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_252.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			uint num = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_252.uint_0;
			if (bool_0)
			{
				num -= 4;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num, array, 4, ref int_);
			return BitConverter.ToInt32(array, 0);
		}
		return 0;
	}

	public static int smethod_36(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = false)
	{
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_253.uint_0 != 0 && Class56.memorySignatureScanConfig_254.uint_0 != 0 && Class56.memorySignatureScanConfig_255.uint_0 != 0)
		{
			int num = 0;
			int int_ = 0;
			byte[] array = new byte[4];
			uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_253.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 4, ref int_);
			int num2 = BitConverter.ToInt32(array, 0);
			uint uint_2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_255.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_2, array, 4, ref int_);
			int num3 = BitConverter.ToInt32(array, 0);
			int num4 = num2 - num3;
			uint uint_3 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_254.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_3, array, 4, ref int_);
			int num5 = BitConverter.ToInt32(array, 0);
			if (num4 <= num5 * 1000)
			{
				int num6 = num4 / 1000;
				int num7 = num5 - num6;
				if (bool_0)
				{
					num7 /= 60;
				}
				num = num7 + 1;
			}
			else
			{
				int num8 = num4 / 1000;
				if (bool_0)
				{
					num8 /= 60;
				}
				num = num8 + 1;
			}
			return num;
		}
		return 0;
	}

	public static int smethod_37(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_257.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			int result = 0;
			uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_257.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 4, ref int_);
			uint num = BitConverter.ToUInt32(array, 0);
			if (num != 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + 4, array, 4, ref int_);
				result = BitConverter.ToInt32(array, 0);
			}
			return result;
		}
		return 0;
	}

	public static int smethod_38(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_256.uint_0 != 0 && Class56.memorySignatureScanConfig_258.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_256.uint_0 + Class56.memorySignatureScanConfig_258.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 4, ref int_);
			return BitConverter.ToInt32(array, 0);
		}
		return 0;
	}

	public static int smethod_39(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.int_136 > 0 && Class56.memorySignatureScanConfig_259.uint_0 != 0 && Class56.memorySignatureScanConfig_260.uint_0 != 0)
		{
			uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_259.uint_0 + Class56.memorySignatureScanConfig_260.uint_0;
			int int_ = 0;
			byte[] array = new byte[2];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 2, ref int_);
			if (int_ != 0)
			{
				return array[0] + array[1] * 256;
			}
			return 0;
		}
		return 999;
	}

	public static void smethod_40(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		byte[] byte_ = new byte[4];
		byte[] byte_2 = new byte[1];
		Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class95.uint_0, byte_2, 1, ref int_);
		for (uint num = 0u; num < 18; num++)
		{
			uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_179.uint_0 + num * 4;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 4, ref int_);
			if (BitConverter.ToUInt32(array, 0) != 0)
			{
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_, byte_, 4, ref int_);
			}
		}
	}

	public static void smethod_41(CharacterAccountConfig characterAccountConfig_0, bool bool_0)
	{
		if (characterAccountConfig_0.uint_7 == 0)
		{
			return;
		}
		int int_ = 0;
		uint uint_ = 24976 + characterAccountConfig_0.uint_7;
		byte[] array = new byte[3];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 3, ref int_);
		byte[] array2 = null;
		byte[] array3 = null;
		if (!bool_0)
		{
			array2 = new byte[3] { 194, 24, 0 };
			array3 = new byte[3] { 85, 139, 236 };
		}
		else
		{
			array2 = new byte[3] { 85, 139, 236 };
			array3 = new byte[3] { 194, 24, 0 };
		}
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (array[num] == array2[num])
				{
					num++;
					continue;
				}
				break;
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_, array3, 3, ref int_);
			break;
		}
	}
}
