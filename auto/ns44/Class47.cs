using System;
using System.Threading;
using ns1;
using ns10;
using ns100;
using ns11;
using ns23;
using ns53;
using ns71;
using ns81;
using ns83;
using ns85;

namespace ns44;

internal class Class47
{
	public static int int_0 = 0;

	private static string string_0 = null;

	public static int int_1 = 0;

	public static int[] smethod_0(uint uint_0 = 3u)
	{
		int[,] array = new int[11, 3];
		Class10.smethod_4(array, 209866);
		int[,] array2 = array;
		for (int i = 0; i < array2.GetLength(0); i++)
		{
			if (uint_0 == array2[i, 0])
			{
				return new int[2]
				{
					array2[i, 1],
					array2[i, 2]
				};
			}
		}
		return new int[2] { 6, 10 };
	}

	public static bool smethod_1(uint uint_0)
	{
		int[] array = new int[6] { 3, 4, 9, 10, 11, 23 };
		for (int i = 0; i < array.Length; i++)
		{
			if (uint_0 == array[i])
			{
				return true;
			}
		}
		return false;
	}

	private static uint smethod_2(uint uint_0)
	{
		switch (uint_0)
		{
		default:
			return 11u;
		case 0u:
		case 1u:
			return 3u;
		case 2u:
			return 1u;
		case 3u:
			return 7u;
		case 4u:
			return 6u;
		case 5u:
			return 4u;
		case 6u:
			return 2u;
		case 7u:
			return 0u;
		case 8u:
			return 5u;
		case 9u:
			return 9u;
		case 10u:
			return 10u;
		}
	}

	public static bool smethod_3(CharacterAccountConfig characterAccountConfig_0, string string_1 = null)
	{
		if (Class24.smethod_30(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig_0.int_137) == 0)
		{
			return false;
		}
		string text = smethod_4(characterAccountConfig_0);
		if (text != null && !(text == string.Empty))
		{
			string[] array = new string[2] { "yes", "ok" };
			string[] array2 = text.Split(' ', '"');
			int num = 0;
			while (true)
			{
				if (num < array2.Length)
				{
					int num2 = 0;
					while (num2 < array.Length)
					{
						if (!(array2[num].ToLower() == array[num2]))
						{
							num2++;
							continue;
						}
						goto IL_00bd;
					}
					num++;
					continue;
				}
				string[] array3 = new string[2] { "gâ", "nhËp" };
				for (int i = 0; i < array3.Length; i++)
				{
					bool flag = false;
					for (num = 0; num < array2.Length; num++)
					{
						if (flag)
						{
							if (array2[num] == null || !(array2[num] != string.Empty))
							{
								continue;
							}
							goto IL_0150;
						}
						if (0 <= array2[num].ToLower().IndexOf(array3[i]))
						{
							flag = true;
						}
					}
					continue;
					IL_0150:
					string_1 = array2[num];
					break;
				}
				break;
				IL_00bd:
				string_1 = array2[num];
				break;
			}
		}
		bool result;
		if (result = string_1 != string.Empty && string_1 != null)
		{
			if (string_1[0] > '፻')
			{
				string_1 = Class11.smethod_54(string_1);
			}
			smethod_5(characterAccountConfig_0, string_1, bool_0: true);
		}
		return result;
	}

	public static string smethod_4(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_172.uint_0 != 0 && Class56.memorySignatureScanConfig_173.uint_0 != 0 && Class56.memorySignatureScanConfig_171.uint_0 != 0)
		{
			uint num = Class24.smethod_30(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig_0.int_137);
			if (num == 0)
			{
				return string.Empty;
			}
			uint num2 = num + Class56.memorySignatureScanConfig_173.uint_0 - 40;
			uint uint_ = num2 - 12;
			int int_ = 0;
			byte[] array = new byte[1];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 1, ref int_);
			int num3 = array[0];
			if (num3 <= 0)
			{
				num3 = 1;
			}
			array = new byte[num3];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2, array, num3, ref int_);
			return Class1.smethod_3(array);
		}
		return string.Empty;
	}

	public static int smethod_5(CharacterAccountConfig characterAccountConfig_0, string string_1, bool bool_0 = false)
	{
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_172.uint_0 != 0 && Class56.memorySignatureScanConfig_173.uint_0 != 0 && Class56.memorySignatureScanConfig_171.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, array, 4, ref int_);
			uint num = BitConverter.ToUInt32(array, 0);
			if (num != 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_173.uint_0 + Class56.memorySignatureScanConfig_171.uint_0, array, 4, ref int_);
				uint num2 = BitConverter.ToUInt32(array, 0);
				if (num2 != 0)
				{
					byte[] array2 = Class11.smethod_47(string_1);
					byte[] array3 = new byte[1];
					byte[] byte_ = new byte[1] { (byte)string_1.Length };
					int num3 = 0;
					while (num3 <= 100 && array3[0] == 0)
					{
						num3++;
						Thread.Sleep(1);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2, array3, 1, ref int_);
					}
					bool flag = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2 - 52, byte_, 1, ref int_);
					bool flag2 = Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2, array2, array2.Length, ref int_);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 - 71, array3, 2, ref int_);
					if (array3[0] == 0)
					{
						array3[0] = 1;
						Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num2 - 71, array3, 1, ref int_);
					}
					if (bool_0)
					{
						Thread.Sleep(10);
						Class24.smethod_4(characterAccountConfig_0.uint_4, 13u);
					}
					return Convert.ToByte(flag2 && flag);
				}
				if (bool_0)
				{
					Class24.smethod_4(characterAccountConfig_0.uint_4, 13u);
				}
				return 0;
			}
			return 0;
		}
		return -1;
	}

	public static string smethod_6(CharacterAccountConfig characterAccountConfig_0)
	{
		if (characterAccountConfig_0.uint_7 != 0 && Class56.memorySignatureScanConfig_172.uint_0 != 0 && Class56.memorySignatureScanConfig_173.uint_0 != 0 && Class56.memorySignatureScanConfig_171.uint_0 != 0)
		{
			int int_ = 0;
			byte[] array = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, array, 4, ref int_);
			uint num = BitConverter.ToUInt32(array, 0);
			if (num == 0)
			{
				return null;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_173.uint_0 + Class56.memorySignatureScanConfig_171.uint_0, array, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array, 0);
			if (num2 != 0)
			{
				int num3 = 0;
				byte[] array2 = new byte[1];
				while (num3 <= 300 && array2[0] == 0)
				{
					num3++;
					Thread.Sleep(1);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2, array2, 1, ref int_);
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 - 52, array2, 1, ref int_);
				if (array2[0] != 0)
				{
					byte[] byte_ = new byte[array2[0]];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2, byte_, array2[0], ref int_);
					return Class1.smethod_3(byte_);
				}
				return string.Empty;
			}
			return null;
		}
		return null;
	}

	public static uint smethod_7(CharacterAccountConfig characterAccountConfig_0, int int_2)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_12.uint_0;
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_261.uint_0, characterAccountConfig_0.int_137);
		uint result = 0u;
		if (num2 != 0)
		{
			result = Class24.smethod_30(num2 + (uint)(int_2 * 4), characterAccountConfig_0.int_137);
		}
		return result;
	}

	public static bool smethod_8(CharacterAccountConfig characterAccountConfig_0)
	{
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_179.uint_0 + Class56.memorySignatureScanConfig_180.uint_0 + Class56.memorySignatureScanConfig_181.uint_0;
		uint num = Class24.smethod_30(uint_, characterAccountConfig_0.int_137);
		return num != 0;
	}

	public static int smethod_9(CharacterAccountConfig characterAccountConfig_0)
	{
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_158.uint_0;
		uint num = Class24.smethod_30(uint_, characterAccountConfig_0.int_137);
		if (num == 0)
		{
			return -1000;
		}
		uint uint_2 = num + Class56.memorySignatureScanConfig_159.uint_0;
		return (int)(Class24.smethod_30(uint_2, characterAccountConfig_0.int_137) - 1);
	}

	public static void smethod_10(CharacterAccountConfig characterAccountConfig_0)
	{
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_158.uint_0;
		uint num = Class24.smethod_30(uint_, characterAccountConfig_0.int_137);
		if (num != 0)
		{
			uint uint_2 = num + Class56.memorySignatureScanConfig_159.uint_0;
			int int_ = 0;
			byte[] byte_ = new byte[4] { 1, 0, 0, 0 };
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, uint_2, byte_, 4, ref int_);
		}
	}

	public static bool smethod_11(CharacterAccountConfig characterAccountConfig_0)
	{
		bool result;
		if (result = smethod_8(characterAccountConfig_0))
		{
			Class24.smethod_4(characterAccountConfig_0.uint_4, 27u);
			Thread.Sleep(999);
		}
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_151.uint_0;
		if ((int)Class24.smethod_30(uint_, characterAccountConfig_0.int_137) > 0)
		{
			Class24.smethod_4(characterAccountConfig_0.uint_4, 27u);
		}
		return result;
	}

	public static int smethod_12(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_184.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_156.uint_0, characterAccountConfig_0.int_137);
		return (int)Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_183.uint_0, characterAccountConfig_0.int_137);
	}

	public static uint smethod_13(CharacterAccountConfig characterAccountConfig_0)
	{
		if (Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_0.int_137) == 0)
		{
			return 0u;
		}
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0);
		int num3 = Class85.smethod_4(characterAccountConfig_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class56.int_1; num5++)
		{
			if (num3 <= num4)
			{
				break;
			}
			uint num6 = num + num5 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array, 4, ref int_);
			uint num7 = BitConverter.ToUInt32(array, 0);
			if (num7 == 0)
			{
				continue;
			}
			uint num8 = num2 + num7 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_);
			if (BitConverter.ToInt32(array, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_);
			if (array[0] != 0)
			{
				num4++;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
				if (array[0] == 1)
				{
					return num5;
				}
			}
		}
		return 0u;
	}

	public static int smethod_14(CharacterAccountConfig characterAccountConfig_0, uint uint_0 = 3u)
	{
		int int_ = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 4, ref int_);
		if (BitConverter.ToInt32(array2, 0) > 0)
		{
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
				if (array[0] != 1)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_111.uint_0, array, 1, ref int_);
				uint uint_1 = array[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_112.uint_0, array, 1, ref int_);
				uint uint_2 = array[0];
				uint num9 = uint_0;
				uint[] array3 = Class85.smethod_26(characterAccountConfig_0, num9, uint_1, uint_2);
				if (array3 == null)
				{
					num9 = 3u;
					array3 = Class85.smethod_26(characterAccountConfig_0, 3u, uint_1, uint_2);
					if (array3 == null)
					{
						return -1;
					}
				}
				int num10 = 0;
				while (!Class11.bool_0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 4, ref int_);
					if (BitConverter.ToInt32(array2, 0) > 0)
					{
						if (num10 % 5 == 0)
						{
							Class75.smethod_46(characterAccountConfig_0, array3[0], array3[1], num9, array3[0], array3[1], num9);
						}
						if (num10 > 30)
						{
							break;
						}
						num10++;
						Thread.Sleep(100);
						continue;
					}
					return 1;
				}
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 4, ref int_);
			return Convert.ToByte(BitConverter.ToInt32(array2, 0) <= 0);
		}
		return 0;
	}

	public static int smethod_15(CharacterAccountConfig characterAccountConfig_0, uint uint_0, uint uint_1, string string_1, int int_2 = -1, bool bool_0 = false, bool bool_1 = false, bool bool_2 = false)
	{
		if (string_1 != null && !(string_1 == string.Empty))
		{
			int result = 1;
			int int_3 = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_3);
			uint num = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_3);
			uint num2 = BitConverter.ToUInt32(array2, 0);
			int num3 = 1;
			string[] array3 = string_1.Split('|');
			string[] array4 = new string[array3.Length];
			for (int i = 0; i < array3.Length; i++)
			{
				if (array3[i] == null)
				{
					array3[i] = string.Empty;
				}
				if (num3 < array3[i].Length)
				{
					num3 = array3[i].Length;
				}
				array4[i] = array3[i].Trim().ToLower();
			}
			num3 += 2;
			byte[] byte_ = new byte[num3];
			smethod_20(characterAccountConfig_0);
			bool flag = smethod_1(uint_0) && smethod_1(uint_1) && uint_0 != uint_1;
			int num4 = Class85.smethod_4(characterAccountConfig_0);
			int num5 = 0;
			for (uint num6 = 1u; num6 < Class56.int_1 && num4 > num5; num6++)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + (num6 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_3);
				uint num7 = BitConverter.ToUInt32(array2, 0);
				if (num7 == 0)
				{
					continue;
				}
				uint num8 = num2 + num7 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_3);
				if (BitConverter.ToInt32(array2, 0) != 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_3);
				if (array[0] == 0)
				{
					continue;
				}
				num5++;
				uint num9 = num + num6 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_3);
				uint num10 = array[0];
				if (num10 != uint_0)
				{
					continue;
				}
				if (bool_1)
				{
					if (Class56.memorySignatureScanConfig_120.uint_0 == 0)
					{
						result = -5;
						break;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_120.uint_0, array2, 4, ref int_3);
					int num11 = BitConverter.ToInt32(array2, 0);
					if (num11 != -2)
					{
						continue;
					}
				}
				bool flag2;
				if (!(flag2 = array3 == null))
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, byte_, num3, ref int_3);
					string text = Class1.smethod_3(byte_);
					string string_2 = text.ToLower();
					for (int j = 0; j < array3.Length; j++)
					{
						if (text == array3[j] || (!bool_0 && Class11.smethod_1(string_2, array4[j]) == 0))
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						continue;
					}
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_3);
				uint num12 = array[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_3);
				uint num13 = array[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_111.uint_0, array, 1, ref int_3);
				uint num14 = array[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_112.uint_0, array, 1, ref int_3);
				uint num15 = array[0];
				uint[] array5 = Class85.smethod_26(characterAccountConfig_0, uint_1, num14, num15);
				if (array5 != null)
				{
					int k = 0;
					if (!flag)
					{
						if (bool_2)
						{
							int num16 = int_2;
							if (num16 <= 0)
							{
								num16 = 1;
							}
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_119.uint_0, array2, 4, ref int_3);
							int num17 = BitConverter.ToInt32(array2, 0);
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_108.uint_0, array2, 0, ref int_3);
							int num18 = array2[0];
							int num19 = 0;
							while (!Class11.bool_0 && num17 > num16 && num18 > 1)
							{
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 4, ref int_3);
								int num20 = BitConverter.ToInt32(array2, 0);
								if (num19 > 30 || num20 > 0)
								{
									break;
								}
								if (num19 % 8 == 0)
								{
									Class75.smethod_71(characterAccountConfig_0, num7, (uint)num16, 89);
								}
								Thread.Sleep(100);
								num19++;
							}
						}
						int num21 = 0;
						while (!Class11.bool_0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 4, ref int_3);
							int num22 = BitConverter.ToInt32(array2, 0);
							if (num22 > 0)
							{
								break;
							}
							if (num21 % 6 == 0)
							{
								Class75.smethod_46(characterAccountConfig_0, num12, num13, num10, num12, num13, num10);
							}
							if (num21 <= 40)
							{
								Thread.Sleep(100);
								num21++;
								continue;
							}
							goto IL_0629;
						}
						num21 = 0;
						while (!Class11.bool_0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 4, ref int_3);
							if (BitConverter.ToInt32(array2, 0) == 0)
							{
								break;
							}
							if (num21 % 6 == 0)
							{
								Class75.smethod_46(characterAccountConfig_0, array5[0], array5[1], uint_1, array5[0], array5[1], uint_1);
							}
							if (num21 <= 40)
							{
								Thread.Sleep(100);
								num21++;
								continue;
							}
							goto IL_062e;
						}
						if (int_2 >= 0)
						{
							int_2--;
							if (int_2 <= 0)
							{
								result = 1;
								break;
							}
						}
						continue;
					}
					Class75.smethod_46(characterAccountConfig_0, num12, num13, uint_0, array5[0], array5[1], uint_1);
					for (; k < 30; k++)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_3);
						uint num23 = array[0];
						if (num10 != num23)
						{
							break;
						}
						Thread.Sleep(10);
					}
					if (int_2 >= 0)
					{
						int_2--;
						if (int_2 <= 0)
						{
							result = 1;
							break;
						}
					}
				}
				else if (num14 <= 1 && num15 <= 1)
				{
					result = 0;
					break;
				}
				continue;
				IL_062e:
				Class75.smethod_46(characterAccountConfig_0, num12, num13, num10, num12, num13, num10);
				result = -2;
				break;
				IL_0629:
				result = -2;
				break;
			}
			return result;
		}
		return 0;
	}

	public static int smethod_16(CharacterAccountConfig characterAccountConfig_0, uint uint_0, uint uint_1, string string_1, int int_2 = -1, bool bool_0 = false, bool bool_1 = false)
	{
		if (string_1 != null && !(string_1 == string.Empty))
		{
			int num = 1;
			int int_3 = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_3);
			uint num2 = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_3);
			uint num3 = BitConverter.ToUInt32(array2, 0);
			int num4 = 1;
			string[] array3 = string_1.Split('|');
			string[] array4 = new string[array3.Length];
			for (int i = 0; i < array3.Length; i++)
			{
				if (array3[i] == null)
				{
					array3[i] = string.Empty;
				}
				if (num4 < array3[i].Length)
				{
					num4 = array3[i].Length;
				}
				array4[i] = array3[i].Trim().ToLower();
			}
			num4 += 2;
			byte[] array5 = new byte[num4];
			smethod_20(characterAccountConfig_0);
			if (!smethod_1(uint_0) || !smethod_1(uint_1))
			{
			}
			int num5 = Class85.smethod_4(characterAccountConfig_0);
			int num6 = 0;
			int num7 = 0;
			uint num8 = 1u;
			while (true)
			{
				uint num14;
				uint num15;
				if (num8 < Class56.int_1 && num5 > num6)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (num8 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_3);
					uint num9 = BitConverter.ToUInt32(array2, 0);
					if (num9 != 0)
					{
						uint num10 = num3 + num9 * Class56.memorySignatureScanConfig_106.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_3);
						if (BitConverter.ToInt32(array2, 0) == 0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_3);
							if (array[0] != 0)
							{
								num6++;
								uint num11 = num2 + num8 * 20;
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_3);
								if (array[0] == uint_0)
								{
									if (bool_1 && Class56.memorySignatureScanConfig_120.uint_0 != 0)
									{
										int num12 = (int)Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_120.uint_0, characterAccountConfig_0.int_137);
										if (num12 != -2)
										{
											goto IL_05a1;
										}
									}
									bool flag = false;
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_107.uint_0, array5, array5.Length, ref int_3);
									string text = Class1.smethod_3(array5);
									for (int j = 0; j < array3.Length; j++)
									{
										string text2 = array3[j];
										if (!(text2 == "*"))
										{
											bool flag2 = bool_0;
											int num13 = Class11.smethod_1(text2, "*");
											if (num13 > 0)
											{
												text2 = text2.Substring(0, num13);
												flag2 = false;
											}
											if (text == text2 || (!flag2 && Class11.smethod_1(text, text2) == 0))
											{
												flag = true;
												break;
											}
											continue;
										}
										flag = true;
										break;
									}
									if (flag)
									{
										Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_3);
										num14 = array[0];
										Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_3);
										num15 = array[0];
										Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_111.uint_0, array, 1, ref int_3);
										uint num16 = array[0];
										Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_112.uint_0, array, 1, ref int_3);
										uint num17 = array[0];
										uint[] array6 = Class85.smethod_26(characterAccountConfig_0, uint_1, num16, num17);
										if (array6 != null)
										{
											Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_119.uint_0, array2, 4, ref int_3);
											int num18 = BitConverter.ToInt32(array2, 0);
											Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_108.uint_0, array2, 1, ref int_3);
											int num19 = array2[0];
											int num20 = 0;
											if (num18 > 0 && num19 > 1 && int_2 > 0 && num18 > int_2)
											{
												while (!Class11.bool_0)
												{
													Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 4, ref int_3);
													int num21 = BitConverter.ToInt32(array2, 0);
													if (num21 > 0)
													{
														break;
													}
													if (num20 % 8 == 0)
													{
														Class75.smethod_71(characterAccountConfig_0, num9, (uint)int_2, 89);
													}
													if (num20 <= 30)
													{
														Thread.Sleep(100);
														num20++;
														continue;
													}
													goto IL_05b7;
												}
												num7 = int_2;
											}
											else
											{
												while (!Class11.bool_0)
												{
													Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 4, ref int_3);
													int num22 = BitConverter.ToInt32(array2, 0);
													if (num22 > 0)
													{
														break;
													}
													if (num20 % 6 == 0)
													{
														Class75.smethod_46(characterAccountConfig_0, num14, num15, uint_0, num14, num15, uint_0);
													}
													if (num20 <= 40)
													{
														Thread.Sleep(100);
														num20++;
														continue;
													}
													goto IL_05bc;
												}
												num7 = ((num18 <= 0 || num19 <= 1) ? (num7 + 1) : (num7 + num18));
											}
											num20 = 0;
											while (!Class11.bool_0)
											{
												Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 4, ref int_3);
												if (BitConverter.ToInt32(array2, 0) == 0)
												{
													break;
												}
												if (num20 % 6 == 0)
												{
													Class75.smethod_46(characterAccountConfig_0, array6[0], array6[1], uint_1, array6[0], array6[1], uint_1);
												}
												if (num20 <= 40)
												{
													Thread.Sleep(100);
													num20++;
													continue;
												}
												goto IL_05c1;
											}
											if (int_2 > 0 && num7 >= int_2)
											{
												num = 1;
												break;
											}
										}
										else if (num16 <= 1 && num17 <= 1)
										{
											num = 0;
											break;
										}
									}
								}
							}
						}
					}
					goto IL_05a1;
				}
				num = ((num7 > 0) ? 1 : 2);
				break;
				IL_05a1:
				num8++;
				continue;
				IL_05b7:
				num = -5;
				break;
				IL_05bc:
				num = -2;
				break;
				IL_05c1:
				Class75.smethod_46(characterAccountConfig_0, num14, num15, uint_0, num14, num15, uint_0);
				num = -4;
				break;
			}
			return num;
		}
		return 0;
	}

	private static uint[,] smethod_17(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0);
		int num3 = Class85.smethod_4(characterAccountConfig_0);
		int num4 = 0;
		uint[,] array2 = new uint[num3, 2];
		for (uint num5 = 1u; num5 < Class56.int_1; num5++)
		{
			if (num3 <= num4)
			{
				break;
			}
			uint num6 = num + num5 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array, 4, ref int_);
			uint num7 = BitConverter.ToUInt32(array, 0);
			if (num7 == 0)
			{
				continue;
			}
			uint num8 = num2 + num7 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_);
			if (BitConverter.ToInt32(array, 0) == 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_);
				if (array[0] != 0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
					array2[num4, 0] = num5;
					array2[num4, 1] = array[0];
					num4++;
				}
			}
		}
		return array2;
	}

	public static void smethod_18()
	{
		int int_ = int_0;
		int_0 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (!Class11.bool_0 && num >= 0)
				{
					if (!flag)
					{
						if (Form1.characterAccountConfig_1[num].bool_41)
						{
							break;
						}
						Form1.characterAccountConfig_1[num].bool_41 = true;
						flag = true;
					}
					smethod_19(int_);
					continue;
				}
				if (0 <= num)
				{
					Form1.characterAccountConfig_1[num].bool_41 = false;
				}
				break;
			}
			catch
			{
			}
		}
	}

	private static void smethod_19(int int_2)
	{
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		int num = 0;
		int int_3 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		long num2 = 0L;
		while (true)
		{
			num--;
			Thread.Sleep(600);
			if (Class11.bool_0)
			{
				break;
			}
			if (num <= 0)
			{
				int num3 = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
				if (num3 < 0)
				{
					break;
				}
				num = 30;
				characterAccountConfig_ = Form1.characterAccountConfig_1[num3];
			}
			if (num2 > 0L && Class11.smethod_28(num2) > 10000L)
			{
				string_0 = null;
				num2 = 0L;
			}
			int num4 = Class75.smethod_3(characterAccountConfig_, Class75.uint_50, 4);
			if (num4 <= 0)
			{
				continue;
			}
			string text = null;
			uint num5 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_.int_137) + Class56.memorySignatureScanConfig_97.uint_0;
			uint num6 = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_.int_137);
			int num7;
			int num8;
			uint num9;
			if (num4 > 2)
			{
				long long_ = Class11.smethod_27();
				while (Class11.smethod_28(long_) < 10000L)
				{
					text = string_0;
					if (text == null || !(text != string.Empty))
					{
						Thread.Sleep(100);
						continue;
					}
					goto IL_0131;
				}
			}
			else
			{
				num2 = Class11.smethod_27();
				if (num4 == 2)
				{
					Class75.smethod_52(characterAccountConfig_, "<bclr=white><color=red>TÊt c¶ ac cïng Qu\u00a8ng ®å...");
				}
				else
				{
					Class75.smethod_52(characterAccountConfig_, "<bclr=white><color=red>Qu\u00a8ng ®å...<bclr=blue><color=green>(hoÆc bÊm phÝm CTRL + ALT + F ®Ó tÊt c¶ ac cßn l¹i cïng qu\u00a8ng theo)");
				}
				if ((int)Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_.int_137) > 0)
				{
					num7 = Class85.smethod_4(characterAccountConfig_);
					num8 = 0;
					for (num9 = 1u; num9 < Class56.int_1; num9++)
					{
						if (num7 <= num8)
						{
							break;
						}
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num5 + (num9 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array, 4, ref int_3);
						uint num10 = BitConverter.ToUInt32(array, 0);
						if (num10 == 0)
						{
							continue;
						}
						uint num11 = num6 + num10 * Class56.memorySignatureScanConfig_106.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_3);
						if (BitConverter.ToInt32(array, 0) != 0)
						{
							continue;
						}
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_3);
						if (array[0] != 0)
						{
							num8++;
							uint num12 = num5 + num9 * 20;
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num12 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_3);
							int num13 = array[0];
							if (num13 == 1)
							{
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_107.uint_0, array2, array2.Length, ref int_3);
								text = Class1.smethod_3(array2);
								break;
							}
						}
					}
					if (num4 <= 2)
					{
						string_0 = text;
					}
					goto IL_02cf;
				}
				Class75.smethod_52(characterAccountConfig_, "<bclr=blue><color=white>H·y cÇm 1 vËt phÈm, sau ®ã bÊm Ctrl + F (hoÆc Ctrl + Alt + F) ®Ó tiÕn hµnh vøt bá.");
			}
			goto IL_0687;
			IL_0687:
			Class75.smethod_2(characterAccountConfig_, Class75.uint_50, 0, 4);
			continue;
			IL_02cf:
			num7 = Class85.smethod_4(characterAccountConfig_);
			num8 = 0;
			uint num14 = 255u;
			uint num15 = 255u;
			num9 = 1u;
			while (true)
			{
				if (num9 < Class56.int_1 && num7 > num8)
				{
					if (Class75.smethod_3(characterAccountConfig_, Class75.uint_50, 4) != 0 && text != null && !(text == string.Empty))
					{
						int num16 = 0;
						while (!Class11.bool_0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 4, ref int_3);
							if (BitConverter.ToInt32(array, 0) == 0)
							{
								break;
							}
							if (num16 % 10 == 0)
							{
								Class75.smethod_121(characterAccountConfig_);
							}
							if (num16 <= 100)
							{
								Thread.Sleep(30);
								num16++;
								continue;
							}
							goto IL_058b;
						}
						if (num7 > num8)
						{
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num5 + (num9 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array, 4, ref int_3);
							uint num17 = BitConverter.ToUInt32(array, 0);
							if (num17 != 0)
							{
								uint num18 = num6 + num17 * Class56.memorySignatureScanConfig_106.uint_0;
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_3);
								if (BitConverter.ToInt32(array, 0) == 0)
								{
									Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_3);
									if (array[0] != 0)
									{
										num8++;
										if (array[0] == text[0])
										{
											uint num19 = num5 + num9 * 20;
											Class24.ReadProcessMemory(characterAccountConfig_.int_137, num19 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_3);
											uint num20 = array[0];
											if (num20 == 3)
											{
												Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18 + Class56.memorySignatureScanConfig_107.uint_0, array2, array2.Length, ref int_3);
												string text2 = Class1.smethod_3(array2);
												if (!(text2 != text))
												{
													Class24.ReadProcessMemory(characterAccountConfig_.int_137, num19 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_3);
													uint num21 = array[0];
													Class24.ReadProcessMemory(characterAccountConfig_.int_137, num19 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_3);
													uint num22 = array[0];
													num16 = 0;
													while (!Class11.bool_0)
													{
														Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 4, ref int_3);
														if (BitConverter.ToInt32(array, 0) > 0)
														{
															break;
														}
														if (num16 % 5 == 0)
														{
															Class75.smethod_46(characterAccountConfig_, num21, num22, num20, num21, num22, num20);
														}
														Thread.Sleep(80);
														num16++;
														if (num16 <= 42)
														{
															continue;
														}
														goto IL_05a8;
													}
													num14 = num21;
													num15 = num22;
												}
											}
										}
									}
								}
							}
							num9++;
							continue;
						}
					}
					else
					{
						Thread.Sleep(100);
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 4, ref int_3);
						if (num14 != 255 && BitConverter.ToInt32(array, 0) > 0)
						{
							Class75.smethod_46(characterAccountConfig_, num14, num15, 3u, num14, num15, 3u);
						}
						if (num4 <= 2)
						{
							string_0 = null;
						}
					}
				}
				if (num14 != 255 && num4 > 2 && Class75.smethod_3(characterAccountConfig_, Class75.uint_50, 4) > 0)
				{
					Thread.Sleep(100);
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 4, ref int_3);
					if (BitConverter.ToInt32(array, 0) > 0)
					{
						Class75.smethod_121(characterAccountConfig_);
					}
				}
				break;
				IL_05a8:
				Class75.smethod_52(characterAccountConfig_, "<bclr=blue><color=white>>Kh«ng thÓ cÇm vËt phÈm <" + text + ">");
				break;
				IL_058b:
				Class75.smethod_52(characterAccountConfig_, "<bclr=blue><color=white>Kh«ng thÓ qu\u00a8ng <" + text + ">");
				break;
			}
			Class75.smethod_52(characterAccountConfig_, "<bclr=white><color=red>Qu\u00a8ng ®å kÕt thóc !");
			goto IL_0687;
			IL_0131:
			Class75.smethod_52(characterAccountConfig_, "<bclr=white><color=red>Qu\u00a8ng ®å...");
			goto IL_02cf;
		}
	}

	public static int smethod_20(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 4, ref int_);
		if (BitConverter.ToInt32(array, 0) <= 0)
		{
			return 0;
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_97.uint_0;
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		int num3 = Class85.smethod_4(characterAccountConfig_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class56.int_1; num5++)
		{
			if (num3 <= num4)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + (num5 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array, 4, ref int_);
			uint num6 = BitConverter.ToUInt32(array, 0);
			if (num6 == 0)
			{
				continue;
			}
			uint num7 = num2 + num6 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_);
			if (BitConverter.ToInt32(array, 0) != 0)
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
			uint num9 = array[0];
			if (num9 != 1)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_111.uint_0, array, 1, ref int_);
			int uint_ = array[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_112.uint_0, array, 1, ref int_);
			int uint_2 = array[0];
			uint[] array2 = Class85.smethod_26(characterAccountConfig_0, 3u, (uint)uint_, (uint)uint_2);
			if (array2 == null)
			{
				return -1;
			}
			int num10 = 0;
			while (num10 < 100)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) > 0)
				{
					if (num10 % 30 == 0)
					{
						Class75.smethod_46(characterAccountConfig_0, array2[0], array2[1], 3u, array2[0], array2[1], 3u);
					}
					num10++;
					Thread.Sleep(10);
					continue;
				}
				return 1;
			}
			return -1;
		}
		return 0;
	}

	private static uint smethod_21(uint[,] uint_0, uint uint_1)
	{
		if (uint_0 != null)
		{
			for (int i = 0; i < uint_0.GetLength(0); i++)
			{
				if (uint_0[i, 0] == uint_1)
				{
					return uint_0[i, 1];
				}
			}
		}
		return 0u;
	}

	public static void smethod_22()
	{
		int int_ = int_1;
		int_1 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (!Class11.bool_0 && num >= 0)
				{
					if (!flag)
					{
						if (Form1.characterAccountConfig_1[num].bool_40)
						{
							break;
						}
						Form1.characterAccountConfig_1[num].bool_40 = true;
						flag = true;
					}
					smethod_23(int_);
					continue;
				}
				if (0 <= num)
				{
					Form1.characterAccountConfig_1[num].bool_40 = false;
				}
				break;
			}
			catch
			{
			}
		}
	}

	private static void smethod_23(int int_2)
	{
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		int int_3 = 0;
		int num = 0;
		int num2 = 0;
		int num3 = -1;
		int num4 = 12000;
		byte[] array = new byte[4];
		long num5 = 0L;
		uint[,] array2 = null;
		uint num6 = 0u;
		uint num7 = 0u;
		uint num8 = 0u;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		while (true)
		{
			num2--;
			Thread.Sleep(300);
			if (Class11.bool_0)
			{
				break;
			}
			if (num2 <= 0)
			{
				num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
				if (num < 0)
				{
					break;
				}
				num2 = 30;
				characterAccountConfig_ = Form1.characterAccountConfig_1[num];
			}
			int num14 = Class75.smethod_3(characterAccountConfig_, Class75.uint_21, 4);
			uint num16;
			uint num17;
			if (num14 != 0)
			{
				if (num3 != num14)
				{
					num3 = num14;
					num5 = Class11.smethod_27();
					array2 = null;
					string text = string.Empty;
					switch (num14)
					{
					case 1:
						text = "ChuyÓn ®å (kÝch th\u00adíc)";
						break;
					case 2:
						text = "ChuyÓn ®å (cïng lo¹i)";
						break;
					case 3:
						text = "Gép vËt phÈm";
						break;
					}
					Class75.smethod_52(characterAccountConfig_, "<color=yellow>" + text + ": <color=red>B¾t ®Çu..");
					Class85.smethod_24(characterAccountConfig_, 3u);
				}
				if (num14 == 3)
				{
					smethod_24(characterAccountConfig_);
					num5 = 1L;
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_3);
				uint num15 = BitConverter.ToUInt32(array, 0);
				num16 = num15 + Class56.memorySignatureScanConfig_97.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_3);
				num17 = BitConverter.ToUInt32(array, 0);
				if (array2 == null)
				{
					num6 = 0u;
					num7 = 0u;
					num8 = 0u;
					array2 = smethod_17(characterAccountConfig_);
					if (array2 == null)
					{
						goto IL_0390;
					}
					Class75.smethod_52(characterAccountConfig_, "H·y cÇm vËt phÈm mÉu.");
				}
				if (num7 == 0)
				{
					if (Class11.smethod_28(num5) <= num4)
					{
						int num18 = Class75.smethod_3(characterAccountConfig_, Class75.uint_21, 4);
						if (num18 != num14)
						{
							num3 = -1;
							continue;
						}
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 4, ref int_3);
						if (BitConverter.ToUInt32(array, 0) == 0)
						{
							continue;
						}
						num6 = smethod_13(characterAccountConfig_);
						for (int i = 0; i < array2.GetLength(0); i++)
						{
							if (num6 == array2[i, 0])
							{
								num7 = array2[i, 1];
								break;
							}
						}
						if (num7 == 0)
						{
							continue;
						}
						uint num19 = num16 + num6 * 20;
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num19 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array, 4, ref int_3);
						uint num20 = BitConverter.ToUInt32(array, 0);
						if (num20 != 0)
						{
							uint num21 = num17 + num20 * Class56.memorySignatureScanConfig_106.uint_0;
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_3);
							num9 = array[0];
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_110.uint_0, array, 1, ref int_3);
							num10 = array[0];
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class85.uint_1, array, 4, ref int_3);
							num11 = BitConverter.ToInt32(array, 0);
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class85.uint_1 + 4, array, 4, ref int_3);
							BitConverter.ToInt32(array, 0);
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_111.uint_0, array, 1, ref int_3);
							num12 = array[0];
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_112.uint_0, array, 1, ref int_3);
							num13 = array[0];
							Class75.smethod_52(characterAccountConfig_, "H·y ®Æt vµo r\u00ad¬ng ®Ých.");
							goto IL_03a2;
						}
					}
					goto IL_0390;
				}
				goto IL_03a2;
			}
			if (num5 > 0L)
			{
				Class75.smethod_52(characterAccountConfig_, "KÕt thóc !");
			}
			num5 = 0L;
			num3 = -1;
			array2 = null;
			Thread.Sleep(200);
			continue;
			IL_0390:
			Class75.smethod_2(characterAccountConfig_, Class75.uint_21, 0, 4);
			continue;
			IL_03a2:
			if (num8 == 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num16 + num6 * 20 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_3);
				if (array[0] == 1)
				{
					continue;
				}
				if (array[0] == num7)
				{
					num7 = 0u;
					num6 = 0u;
					continue;
				}
				num8 = array[0];
			}
			while (true)
			{
				int num22 = 0;
				int num23 = Class85.smethod_4(characterAccountConfig_);
				int num24 = 0;
				uint num25 = 0u;
				while (true)
				{
					num25++;
					if (num23 <= num24 || Class56.int_1 <= num25)
					{
						break;
					}
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_16 + Class75.uint_21 * 4, array, 1, ref int_3);
					num14 = array[0];
					if (num14 == 0)
					{
						goto end_IL_083a;
					}
					uint num26 = num16 + num25 * 20;
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num26 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array, 4, ref int_3);
					uint num27 = BitConverter.ToUInt32(array, 0);
					if (num27 == 0)
					{
						continue;
					}
					uint num28 = num17 + num27 * Class56.memorySignatureScanConfig_106.uint_0;
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num28 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_3);
					if (BitConverter.ToInt32(array, 0) != 0)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num28 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_3);
					if (array[0] == 0)
					{
						continue;
					}
					num24++;
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num26 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_3);
					if (array[0] != num7)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num28 + Class56.memorySignatureScanConfig_111.uint_0, array, 1, ref int_3);
					uint num29 = array[0];
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num28 + Class56.memorySignatureScanConfig_112.uint_0, array, 1, ref int_3);
					uint num30 = array[0];
					bool flag = num29 == num12 && num30 == num13;
					if (num14 == 2)
					{
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num28 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_3);
						int num31 = array[0];
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num28 + Class56.memorySignatureScanConfig_110.uint_0, array, 1, ref int_3);
						int num32 = array[0];
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num28 + Class85.uint_1, array, 4, ref int_3);
						int num33 = BitConverter.ToInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num28 + Class85.uint_1 + 4, array, 4, ref int_3);
						BitConverter.ToInt32(array, 0);
						flag = num31 == num9 && num32 == num10 && num33 == num11;
					}
					if (!flag)
					{
						continue;
					}
					uint[] array3 = Class85.smethod_26(characterAccountConfig_, num8, num29, num30);
					if (array3 != null)
					{
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num26 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_3);
						byte b = array[0];
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num26 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_3);
						byte b2 = array[0];
						int num34 = 0;
						int num35 = 0;
						while (!Class11.bool_0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 1, ref int_3);
							int num36 = array[0];
							if (num36 <= 0)
							{
								if (num35 % 8 == 0)
								{
									Class75.smethod_46(characterAccountConfig_, b, b2, num7, b, b2, num7);
								}
								if (num35 > 60)
								{
									break;
								}
								Thread.Sleep(10);
								num35++;
								continue;
							}
							num34 = 1;
							break;
						}
						if (num34 == 0)
						{
							continue;
						}
						num35 = 0;
						while (!Class11.bool_0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 1, ref int_3);
							if (array[0] != 0)
							{
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, num26 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array, 4, ref int_3);
								if (BitConverter.ToInt32(array, 0) != 0)
								{
									if (num35 % 8 == 0)
									{
										Class75.smethod_46(characterAccountConfig_, array3[0], array3[1], num8, array3[0], array3[1], num8);
									}
									if (num35 > 60)
									{
										break;
									}
									num35++;
									Thread.Sleep(10);
									continue;
								}
								num34 = 0;
								break;
							}
							num34 = 0;
							num22++;
							break;
						}
						if (num34 <= 0)
						{
							continue;
						}
						Class75.smethod_46(characterAccountConfig_, b, b2, num7, b, b2, num7);
						for (num35 = 0; num35 < 100; num35++)
						{
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 4, ref int_3);
							if (BitConverter.ToInt32(array, 0) == 0)
							{
								break;
							}
							Thread.Sleep(10);
						}
						continue;
					}
					num3 = -1;
					goto end_IL_083a;
				}
				if (num22 <= 0)
				{
					num3 = -1;
					break;
				}
				continue;
				end_IL_083a:
				break;
			}
		}
	}

	public static void smethod_24(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		int num = 0;
		byte[] array = new byte[4];
		while (true)
		{
			Thread.Sleep(10);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
			uint num3 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
			uint num4 = BitConverter.ToUInt32(array, 0);
			uint num5 = num4 + num3 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
			int num6 = BitConverter.ToInt32(array, 0);
			int num7 = Class89.smethod_39(characterAccountConfig_0);
			if (num6 <= 0 || num7 <= 1)
			{
				if (num >= 10)
				{
					break;
				}
				num++;
				Thread.Sleep(100);
				continue;
			}
			num = 0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_);
			int num8 = BitConverter.ToInt32(array, 0);
			if (num8 == 11 || num8 == 22)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_);
			uint num9 = BitConverter.ToUInt32(array, 0);
			uint num10 = num2 + Class56.memorySignatureScanConfig_97.uint_0;
			uint[] uint_ = null;
			int num11 = 0;
			uint num12 = 0u;
			while (true)
			{
				num12++;
				int num13 = Class85.smethod_4(characterAccountConfig_0);
				if (Class11.bool_0 || num13 <= num11 || Class56.int_1 <= num12 || Class75.smethod_3(characterAccountConfig_0, Class75.uint_21, 4) != 3)
				{
					break;
				}
				uint num14 = num10 + num12 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num14 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array, 4, ref int_);
				uint num15 = BitConverter.ToUInt32(array, 0);
				if (num15 == 0)
				{
					continue;
				}
				uint num16 = num9 + num15 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) != 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				num11++;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num14 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
				if (array[0] != 3)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_119.uint_0, array, 4, ref int_);
				int num17 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_119.uint_0 + 4, array, 4, ref int_);
				int num18 = BitConverter.ToInt32(array, 0);
				if (num17 > 0 && num18 > 0 && num18 > num17)
				{
					int num19 = smethod_25(characterAccountConfig_0, ref uint_, num12);
					if (num19 > 0)
					{
						num12 = 0u;
						num11 = 0;
					}
				}
			}
			Class85.smethod_24(characterAccountConfig_0, 3u);
			break;
		}
		Class75.smethod_2(characterAccountConfig_0, Class75.uint_21, 0, 4);
	}

	private static int smethod_25(CharacterAccountConfig characterAccountConfig_0, ref uint[] uint_0, uint uint_1)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		int num = Class75.smethod_3(characterAccountConfig_0, Class75.uint_21, 4);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_);
		uint num3 = BitConverter.ToUInt32(array, 0);
		uint num4 = num2 + uint_1 * 20;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array, 4, ref int_);
		uint num5 = BitConverter.ToUInt32(array, 0);
		if (num5 != 0)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
			byte b = array[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_);
			byte b2 = array[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_);
			byte b3 = array[0];
			uint num6 = num3 + num5 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_111.uint_0, array, 1, ref int_);
			byte b4 = array[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_112.uint_0, array, 1, ref int_);
			byte b5 = array[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_107.uint_0, array2, array2.Length, ref int_);
			byte b6 = array2[0];
			string text = Class1.smethod_3(array2);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class85.uint_1, array, 4, ref int_);
			uint num7 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class85.uint_1 + 4, array, 4, ref int_);
			uint num8 = BitConverter.ToUInt32(array, 0);
			int num9 = 0;
			int num10 = 0;
			int num11 = Class85.smethod_4(characterAccountConfig_0);
			array2 = new byte[text.Length + 2];
			for (uint num12 = 1u; num12 < Class56.int_1 && num11 > num10 && Class75.smethod_3(characterAccountConfig_0, Class75.uint_21, 4) == num; num12++)
			{
				uint num13 = num2 + num12 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array, 4, ref int_);
				uint num14 = BitConverter.ToUInt32(array, 0);
				if (num14 == 0)
				{
					continue;
				}
				uint num15 = num3 + num14 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num15 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) != 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num15 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_);
				byte b7 = array[0];
				num10++;
				if (num12 == uint_1 || b7 != b6)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num15 + Class56.memorySignatureScanConfig_107.uint_0, array2, array2.Length, ref int_);
				string text2 = Class1.smethod_3(array2);
				if (text2 != text)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
				if (array[0] != b)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num15 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num15 + Class56.memorySignatureScanConfig_111.uint_0, array, 1, ref int_);
				byte b8 = array[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num15 + Class56.memorySignatureScanConfig_112.uint_0, array, 1, ref int_);
				byte b9 = array[0];
				if (b4 != b8 || b5 != b9)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num15 + Class85.uint_1, array, 4, ref int_);
				uint num16 = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num15 + Class85.uint_1 + 4, array, 4, ref int_);
				uint num17 = BitConverter.ToUInt32(array, 0);
				if (num16 != num7 || num17 != num8)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num15 + Class56.memorySignatureScanConfig_119.uint_0, array, 4, ref int_);
				int num18 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num15 + Class56.memorySignatureScanConfig_119.uint_0 + 4, array, 4, ref int_);
				int num19 = BitConverter.ToInt32(array, 0);
				if (num18 <= 0 || num19 <= 0 || num19 <= num18)
				{
					continue;
				}
				if (uint_0 != null)
				{
					bool flag = false;
					for (int i = 0; i < uint_0.Length; i++)
					{
						if (uint_0[i] == num12)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						continue;
					}
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_);
				uint num20 = array[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_);
				uint num21 = array[0];
				int num22 = 0;
				int num23 = 0;
				while (!Class11.bool_0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 4, ref int_);
					if (BitConverter.ToInt32(array, 0) <= 0)
					{
						if (num22 % 8 == 0)
						{
							Class75.smethod_46(characterAccountConfig_0, num20, num21, b, num20, num21, b);
						}
						if (num22 <= 60)
						{
							Thread.Sleep(10);
							num22++;
							continue;
						}
						Class11.smethod_41(ref uint_0, num12);
						break;
					}
					num23 = 1;
					break;
				}
				num22 = 0;
				while (!Class11.bool_0 && num23 > 0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array, 4, ref int_);
					if (BitConverter.ToInt32(array, 0) != 0)
					{
						if (num22 % 8 == 0)
						{
							Class75.smethod_46(characterAccountConfig_0, b2, b3, b, b2, b3, b);
						}
						if (num22 <= 60)
						{
							num22++;
							Thread.Sleep(10);
							continue;
						}
						Class75.smethod_46(characterAccountConfig_0, num20, num21, b, num20, num21, b);
						Class11.smethod_41(ref uint_0, num12);
						break;
					}
					num9++;
					break;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array, 4, ref int_);
				if (BitConverter.ToUInt32(array, 0) == 0)
				{
					break;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_119.uint_0, array, 4, ref int_);
				int num24 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_119.uint_0 + 4, array, 4, ref int_);
				int num25 = BitConverter.ToInt32(array, 0);
				if (num25 <= num24)
				{
					break;
				}
			}
			return num9;
		}
		return 0;
	}
}
