using System;
using System.Globalization;
using System.Text;
using System.Threading;
using ns1;
using ns100;
using ns109;
using ns11;
using ns121;
using ns23;
using ns35;
using ns37;
using ns43;
using ns53;
using ns61;
using ns71;
using ns79;
using ns85;

namespace ns68;

internal class Class72
{
	public static bool bool_0 = false;

	public static int[] int_0 = null;

	public static GStruct26[] gstruct26_0 = null;

	public static string string_0 = "BhoAttack.txt";

	public static string string_1 = "BhoNoAttack.txt";

	public static string string_2 = "PlrNoAttack.txt";

	public static int int_1 = 0;

	public static int int_2 = 0;

	public static int int_3 = 0;

	public static int int_4 = 0;

	public static string[] string_3 = null;

	public static string[] string_4 = null;

	public static uint[] uint_0 = null;

	public static uint[] uint_1 = null;

	public static string[] string_5 = null;

	private const int int_5 = 5328;

	public static string[] smethod_0(string string_6)
	{
		string string_7 = Class56.string_10 + "\\" + string_6;
		string text = Class11.smethod_33(string_7, 0, 0, 1);
		if (text != null && !(text == string.Empty))
		{
			string text2 = Class11.smethod_15(text);
			if (text2 != null && !(text2 == string.Empty))
			{
				return text2.Split('|');
			}
			return null;
		}
		return null;
	}

	public static void smethod_1(string[] string_6, string string_7)
	{
		string text = string.Empty;
		if (string_6 != null)
		{
			for (int i = 0; i < string_6.Length; i++)
			{
				if (string_6[i] != null && !(string_6[i] == string.Empty))
				{
					if (text != null && text != string.Empty)
					{
						text += "|";
					}
					text += string_6[i];
				}
			}
		}
		if (text != string.Empty)
		{
			text = Class11.smethod_16(text);
		}
		Class11.smethod_23(Class56.string_10);
		Class11.smethod_34(Class56.string_10 + "\\" + string_7, text, 1);
	}

	public static uint[] smethod_2(string[] string_6)
	{
		if (string_6 == null)
		{
			return null;
		}
		uint[] array = new uint[string_6.Length];
		for (int i = 0; i < string_6.Length; i++)
		{
			array[i] = Class11.smethod_6(string_6[i]);
		}
		return array;
	}

	public static bool smethod_3(CharacterAccountConfig characterAccountConfig_0)
	{
		if (Class46.uint_0 == null)
		{
			return false;
		}
		int num = 1114;
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num5 = num4 + num3 * Class56.memorySignatureScanConfig_15.uint_0;
		int num6 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_54.uint_0, characterAccountConfig_0.int_137);
		uint[] array;
		int int_;
		byte[] array2;
		uint num10;
		uint[] array3;
		byte[] array4;
		int num18;
		uint[] array5;
		uint[] array6;
		int num19;
		int num20;
		if (num6 > 0)
		{
			int num7 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
			array = new uint[2]
			{
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
			};
			int_ = 0;
			array2 = new byte[4];
			uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array2, 4, ref int_);
			int num8 = BitConverter.ToInt32(array2, 0);
			int num9 = 0;
			num10 = 0u;
			array3 = null;
			array4 = new byte[2];
			Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_1 * 4, array4, 2, ref int_);
			for (uint num11 = 1u; num11 < 256; num11++)
			{
				if (num8 <= num9)
				{
					break;
				}
				uint num12 = num4 + num11 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_16.uint_0, array2, 4, ref int_);
				if (array2[0] == 0)
				{
					continue;
				}
				num9++;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_50.uint_0, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) <= 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_52.uint_0, array2, 4, ref int_);
				int num13 = BitConverter.ToInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_43.uint_0, array2, 4, ref int_);
				int num14 = BitConverter.ToInt32(array2, 0);
				if (num13 != 1 || num14 <= 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_55.uint_0, array2, 4, ref int_);
				int num15 = BitConverter.ToInt32(array2, 0);
				if (num15 == 10 || num15 == 21)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12, array2, 4, ref int_);
				int num16 = BitConverter.ToInt32(array2, 0);
				if (num16 == -1 || num16 == 0)
				{
					continue;
				}
				try
				{
					if (Class46.uint_0 == null)
					{
						return false;
					}
					for (int i = 0; i < Class46.uint_0.Length; i++)
					{
						if (num16 == Class46.uint_0[i])
						{
							if (num16 == Class46.characterSyncSnapshot_0.uint_2)
							{
								num10 = num11;
							}
							if (array3 != null)
							{
								int num17 = array3.Length;
								Array.Resize(ref array3, num17 + 1);
								array3[num17] = num11;
							}
							else
							{
								array3 = new uint[1] { num11 };
							}
							break;
						}
					}
				}
				catch
				{
					return false;
				}
			}
			if (array3 != null)
			{
				num18 = -1;
				array5 = new uint[2];
				array6 = new uint[2];
				num19 = (int)Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
				num20 = 400;
				if (characterAccountConfig_0.int_101[1] == num)
				{
					num20 = 470;
				}
				if (characterAccountConfig_0.int_101[2] != 0 || num10 == 0 || Class46.characterSyncSnapshot_0.int_3 <= 0 || Class46.characterSyncSnapshot_0.int_4 != num7)
				{
					goto IL_06ae;
				}
				if (num19 != num10 && array4[0] != 0 && array4[1] != 0)
				{
					int int_2 = Class46.characterSyncSnapshot_0.int_1;
					uint num21 = Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, int_2);
					if (num21 == num7)
					{
						uint num22 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, int_2);
						uint num23 = Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_13.uint_0, int_2) * Class56.memorySignatureScanConfig_15.uint_0;
						uint num24 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, int_2);
						uint num25 = num24 + num23;
						int num26 = (int)Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_43.uint_0, int_2);
						int num27 = (int)Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_54.uint_0, int_2);
						if (num26 > 0 && num27 == num6)
						{
							int num28 = 0;
							while (num28 < 10)
							{
								array5[0] = Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, int_2);
								array5[1] = Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, int_2);
								array[0] = Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137);
								array[1] = Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137);
								long num29 = Class64.smethod_18(array, array5);
								if (num29 <= 1000000L)
								{
									if ((num28 == 0 && num29 <= num20 * num20) || num29 < 22500L)
									{
										break;
									}
									int int_3 = characterAccountConfig_0.int_137;
									uint uint_2 = num5 + Class56.memorySignatureScanConfig_72.uint_0;
									byte[] byte_ = new byte[4];
									Class24.WriteProcessMemory(int_3, uint_2, byte_, 4, ref int_);
									Class75.smethod_61(characterAccountConfig_0, array5);
									Thread.Sleep(150);
									num28++;
									continue;
								}
								goto IL_06ab;
							}
							long num30 = Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_45.uint_0, int_2);
							long num31 = Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_47.uint_0, int_2);
							long num32 = Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_47.uint_0 + 4, int_2);
							if (num32 > num31 && num32 < 300000L)
							{
								num31 = num32;
							}
							if (num31 > 100L)
							{
								long num33 = 100L * num30 / num31;
								if (num33 <= characterAccountConfig_0.int_101[3] || characterAccountConfig_0.int_101[3] > 99)
								{
									num18 = (int)num10;
									array6[0] = array5[0];
									array6[1] = array5[1];
									goto IL_09f0;
								}
							}
						}
					}
					goto IL_06ab;
				}
				goto IL_08fc;
			}
			return false;
		}
		return false;
		IL_06ab:
		num10 = 0u;
		goto IL_06ae;
		IL_08fc:
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_43.uint_0, array2, 4, ref int_);
		if (BitConverter.ToInt32(array2, 0) > 0)
		{
			array6[0] = array[0];
			array6[1] = array[1];
			if (characterAccountConfig_0.int_101[3] <= 99)
			{
				long num34 = Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_45.uint_0, characterAccountConfig_0.int_137);
				long num35 = Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_47.uint_0, characterAccountConfig_0.int_137);
				long num36 = Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_47.uint_0 + 4, characterAccountConfig_0.int_137);
				if (num36 > num35 && num36 < 300000L)
				{
					num35 = num36;
				}
				if (num35 <= 100L || 100L * num34 / num35 <= characterAccountConfig_0.int_101[3])
				{
					num18 = num19;
				}
			}
			else
			{
				num18 = num19;
			}
		}
		goto IL_09f0;
		IL_06ae:
		if (array4[0] > 0 && array4[1] > 0 && (characterAccountConfig_0.int_101[2] == 1 || num10 == 0))
		{
			uint num37 = 0u;
			long num38 = -1L;
			long num39 = -1L;
			for (int j = 0; j < array3.Length; j++)
			{
				if (num19 == array3[j])
				{
					continue;
				}
				uint num40 = num4 + array3[j] * Class56.memorySignatureScanConfig_15.uint_0;
				int num41 = (int)Class24.smethod_30(num40 + Class56.memorySignatureScanConfig_54.uint_0, characterAccountConfig_0.int_137);
				if (num6 != num41)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num40 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array2, 4, ref int_);
				array5[0] = BitConverter.ToUInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num40 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array2, 4, ref int_);
				array5[1] = BitConverter.ToUInt32(array2, 0);
				long num42 = Class64.smethod_18(array, array5);
				if (num42 > num20 * num20)
				{
					continue;
				}
				if (characterAccountConfig_0.int_101[3] <= 99)
				{
					long num43 = Class24.smethod_30(num40 + Class56.memorySignatureScanConfig_45.uint_0, characterAccountConfig_0.int_137);
					long num44 = Class24.smethod_30(num40 + Class56.memorySignatureScanConfig_47.uint_0, characterAccountConfig_0.int_137);
					long num45 = Class24.smethod_30(num40 + Class56.memorySignatureScanConfig_47.uint_0 + 4, characterAccountConfig_0.int_137);
					if (num45 > num44 && num45 < 300000L)
					{
						num44 = num45;
					}
					long num46 = num43;
					if (num44 > 100L)
					{
						num46 = 100L * num43 / num44;
					}
					if (num46 <= characterAccountConfig_0.int_101[3] && (num37 == 0 || num46 < num38 || (num46 == num38 && num42 < num39)))
					{
						num37 = array3[j];
						num39 = num42;
						num38 = num46;
						array6[0] = array5[0];
						array6[1] = array5[1];
					}
				}
				else if (num37 == 0 || num42 < num39)
				{
					num37 = array3[j];
					num39 = num42;
					array6[0] = array5[0];
					array6[1] = array5[1];
				}
			}
			if (num37 != 0)
			{
				num18 = (int)num37;
				goto IL_09f0;
			}
		}
		goto IL_08fc;
		IL_09f0:
		if (num18 <= 0)
		{
			return false;
		}
		for (int k = 0; k < 10; k++)
		{
			int int_4 = characterAccountConfig_0.int_137;
			uint uint_3 = num5 + Class56.memorySignatureScanConfig_72.uint_0;
			byte[] byte_2 = new byte[4];
			Class24.WriteProcessMemory(int_4, uint_3, byte_2, 4, ref int_);
			int num47 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
			if (num47 <= 3)
			{
				break;
			}
			Thread.Sleep(60);
		}
		if (characterAccountConfig_0.int_101[1] == num)
		{
			uint[] array7 = Class89.smethod_10(array, array6);
			uint uint_4 = (array7[1] << 16) + array7[0];
			Class89.smethod_7(characterAccountConfig_0, uint_4);
			Thread.Sleep(10);
			Class83.smethod_9(characterAccountConfig_0);
			Class83.smethod_5(characterAccountConfig_0, num, 6, 1);
			if (FormDame.int_14 > 0)
			{
				Class24.smethod_76(characterAccountConfig_0.uint_4, 32);
			}
			else
			{
				Class24.smethod_76(characterAccountConfig_0.uint_4, 117);
			}
		}
		else
		{
			uint value = uint.MaxValue;
			uint value2 = (uint)num18;
			if (num18 == num19)
			{
				value = array[0];
				value2 = array[1];
			}
			byte[] bytes = BitConverter.GetBytes(value);
			byte[] bytes2 = BitConverter.GetBytes(value2);
			byte[] byte_3 = new byte[4] { 5, 0, 0, 0 };
			byte[] bytes3 = BitConverter.GetBytes(characterAccountConfig_0.int_101[1]);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_37.uint_0, bytes, 4, ref int_);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_38.uint_0, bytes2, 4, ref int_);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_36.uint_0, bytes3, 4, ref int_);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_35.uint_0, byte_3, 4, ref int_);
		}
		Thread.Sleep(30);
		return true;
	}

	public static int smethod_4(int int_6, int int_7, uint[] uint_2)
	{
		try
		{
			int int_8 = 0;
			byte[] array = new byte[1];
			if (gstruct26_0 != null)
			{
				for (int i = 0; i < gstruct26_0.Length; i++)
				{
					if (gstruct26_0[i].int_0 == 0 || int_7 != gstruct26_0[i].int_1)
					{
						continue;
					}
					Class24.ReadProcessMemory(int_6, gstruct26_0[i].uint_0, array, 1, ref int_8);
					if (array[0] != 0)
					{
						long num = Class64.smethod_18(uint_2, gstruct26_0[i].uint_1);
						if (num < 360000L)
						{
							return 1;
						}
					}
					else
					{
						gstruct26_0[i].int_0 = 0;
						gstruct26_0[i].int_1 = 0;
					}
				}
			}
			return 0;
		}
		catch
		{
		}
		return -1;
	}

	public static int[,] smethod_5(CharacterAccountConfig characterAccountConfig_0, uint uint_2, int int_6 = 600, uint[] uint_3 = null, int[] int_7 = null, bool bool_1 = false, bool bool_2 = false, bool bool_3 = false)
	{
		byte[] array = new byte[4];
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_30.uint_0;
		uint num3 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
		uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num5 = num4 + num3;
		uint num6 = num + Class56.memorySignatureScanConfig_30.uint_0;
		uint num7 = Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_88.uint_0, characterAccountConfig_0.int_137);
		int int_8 = 0;
		long num8 = int_6 * int_6;
		int num9 = (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		int num10 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_54.uint_0, characterAccountConfig_0.int_137);
		int num11 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_56.uint_0, characterAccountConfig_0.int_137);
		if (uint_3 == null || uint_3.Length != 2 || uint_3[0] == 0 || uint_3[1] == 0)
		{
			uint_3 = new uint[2]
			{
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
			};
		}
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_38 * 4, array, 4, ref int_8);
		int num12 = BitConverter.ToInt32(array, 0);
		int num13 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
		bool flag = !bool_3 && ((926 <= num13 && num13 <= 932) || num13 == Class40.int_0);
		bool flag2 = (463 < num13 && num13 < 472) || (479 < num13 && num13 < 496);
		byte[] array2 = new byte[1];
		byte[] array3 = new byte[16];
		byte[] array4 = new byte[60];
		byte[] array5 = new byte[2];
		byte[] array6 = new byte[1];
		byte[] array7 = new byte[2];
		long[,,] array8 = new long[2, 5, 10];
		int[,] array9 = new int[2, 11];
		int[] array10 = new int[2];
		byte[] array11 = new byte[4];
		Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_2 * 4, array6, 1, ref int_8);
		Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_1 * 4, array5, 2, ref int_8);
		Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_3 * 4, array7, 2, ref int_8);
		uint uint_4 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_4, array, 4, ref int_8);
		int num14 = BitConverter.ToInt32(array, 0);
		if (num14 <= 1)
		{
			return null;
		}
		uint[] array12 = new uint[2];
		int num15 = 0;
		int num16 = 0;
		uint num17 = 0u;
		num17 = 1u;
		while (true)
		{
			if (num17 < 256)
			{
				if (!bool_1 && num17 % 2 == 0)
				{
					int num18 = Class89.smethod_12(characterAccountConfig_0);
					if (num18 == 1)
					{
						array9[0, 0] = -100;
						array9[1, 1] = -100;
						break;
					}
				}
				if (num14 > num16)
				{
					if (num17 != num9)
					{
						uint num19 = num4 + num17 * Class56.memorySignatureScanConfig_15.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_52.uint_0, array, 4, ref int_8);
						int num20 = BitConverter.ToInt32(array, 0);
						uint num21 = num19 + Class56.memorySignatureScanConfig_16.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num21, array, 4, ref int_8);
						if (array[0] != 0 || (num20 == 1 && Form1.int_123 > 0))
						{
							num16++;
							bool flag3 = array[0] == 84 && array[2] == 211;
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_8);
							if (BitConverter.ToInt32(array, 0) > 0)
							{
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_8);
								int num22 = BitConverter.ToInt32(array, 0);
								if (num20 >= 0 && num20 <= 1 && (num20 != 1 || (num22 > 0 && array5[0] != 0 && array5[1] != 0)))
								{
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_8);
									int num23 = BitConverter.ToInt32(array, 0);
									if (num23 != 10 && num23 != 21)
									{
										Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19, array11, 4, ref int_8);
										int num24 = BitConverter.ToInt32(array11, 0);
										if (num24 != -1 && num24 != 0)
										{
											Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_54.uint_0, array, 4, ref int_8);
											int num25 = BitConverter.ToInt32(array, 0);
											Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_45.uint_0, array, 4, ref int_8);
											long num26 = BitConverter.ToInt32(array, 0);
											Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_26.uint_0 + 8, array, 4, ref int_8);
											int num27 = BitConverter.ToInt32(array, 0);
											Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_26.uint_0 + 12, array, 4, ref int_8);
											int num28 = BitConverter.ToInt32(array, 0);
											Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_51.uint_0, array, 4, ref int_8);
											int num29 = BitConverter.ToInt32(array, 0);
											Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_8);
											array12[0] = BitConverter.ToUInt32(array, 0);
											Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_8);
											array12[1] = BitConverter.ToUInt32(array, 0);
											bool flag4 = false;
											if (flag2 && Form1.int_122 > 0 && num20 <= 0)
											{
												Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_15 + num17 * 8, array, 4, ref int_8);
												if (BitConverter.ToUInt32(array, 0) == num24)
												{
													Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_15 + num17 * 8 + 4, array2, 1, ref int_8);
													if (array2[0] > 0)
													{
														goto IL_0eb1;
													}
												}
												else
												{
													array2[0] = 0;
													if (flag3)
													{
														Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num21 + 5, array, 4, ref int_8);
														if (BitConverter.ToUInt32(array, 0) == 3580454990u)
														{
															array2[0] = 1;
														}
													}
													if (array2[0] <= 0)
													{
														uint num30 = num4 + num17 * Class56.memorySignatureScanConfig_15.uint_0 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_2.uint_0;
														for (uint num31 = 0u; num31 < 6; num31++)
														{
															Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num30 + Class56.memorySignatureScanConfig_3.uint_0 * num31, array, 4, ref int_8);
															if (BitConverter.ToInt32(array, 0) == 45)
															{
																array2[0] = 1;
																break;
															}
														}
													}
													Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_15 + num17 * 8, array11, 4, ref int_8);
													Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_15 + num17 * 8 + 4, array2, 1, ref int_8);
													if (array2[0] > 0)
													{
														int num32 = 0;
														while (bool_0 && num32 < 10)
														{
															Thread.Sleep(10);
															num32++;
														}
														bool_0 = true;
														int num33 = 1;
														if (gstruct26_0 != null)
														{
															num33 = gstruct26_0.Length + 1;
															Array.Resize(ref gstruct26_0, num33);
														}
														else
														{
															gstruct26_0 = new GStruct26[1];
														}
														gstruct26_0[num33 - 1].int_0 = num24;
														gstruct26_0[num33 - 1].int_1 = num13;
														gstruct26_0[num33 - 1].uint_0 = num21;
														gstruct26_0[num33 - 1].int_2 = 1;
														gstruct26_0[num33 - 1].uint_1 = new uint[2]
														{
															array12[0],
															array12[1]
														};
														bool_0 = false;
														goto IL_0eb1;
													}
												}
												if (smethod_4(characterAccountConfig_0.int_137, num13, array12) > 0)
												{
													goto IL_0eb1;
												}
											}
											while (true)
											{
												long num34;
												int num35;
												int num36;
												if (!flag4 && (uint_2 == 0 || num24 != uint_2))
												{
													num34 = Class64.smethod_18(uint_3, array12);
													if (num34 > num8)
													{
														break;
													}
													Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_53.uint_0, array, 4, ref int_8);
													num35 = BitConverter.ToInt32(array, 0);
													if (num35 < 0 || num35 > 4)
													{
														break;
													}
													Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_85.uint_0, array, 4, ref int_8);
													num36 = BitConverter.ToInt32(array, 0);
													if (num20 <= 0)
													{
														if (Form1.int_35 <= 0 || (num10 > 0 && num25 == num10 && num25 != 4))
														{
															break;
														}
														if (flag)
														{
															Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_16.uint_0, array4, array4.Length, ref int_8);
															string text = Class1.smethod_3(array4);
															if (!(text == string.Empty) && Class11.smethod_1(text, "[" + characterAccountConfig_0.string_20 + "]") > 0)
															{
																break;
															}
															if (Form1.int_36 > 0 && Form1.int_40 > 0)
															{
																flag4 = true;
																continue;
															}
														}
														else
														{
															bool flag5 = false;
															if (int_7 != null)
															{
																for (int i = 0; i < int_7.Length; i++)
																{
																	if (num24 == int_7[i])
																	{
																		flag5 = true;
																		break;
																	}
																}
															}
															if (flag5)
															{
																break;
															}
															if (Form1.int_36 > 0 || num26 <= 0L)
															{
																if (num27 > 0 && num28 > 15 && num29 > 0)
																{
																	if (Form1.int_40 > 0)
																	{
																		flag4 = true;
																		continue;
																	}
																}
																else if (bool_2)
																{
																	if (num29 <= 0 || num26 <= 0L)
																	{
																		break;
																	}
																}
																else if (num29 <= 95 || num26 <= 0L)
																{
																	break;
																}
															}
														}
													}
													else
													{
														if (Form1.int_34 <= 0 || num22 <= 0 || num12 > 0 || num25 == 0 || num10 == 0 || (Form1.int_39 <= 0 && (num23 == 3 || num23 == 4)))
														{
															break;
														}
														if (Form1.int_92 > 0)
														{
															Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_51.uint_0, array, 4, ref int_8);
															int num37 = BitConverter.ToInt32(array, 0);
															if (num37 < Form1.int_93)
															{
																break;
															}
														}
														if (string_5 != null && string_5.Length != 0)
														{
															Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_16.uint_0, array3, array3.Length, ref int_8);
															string text2 = Class1.smethod_3(array3);
															bool flag6 = false;
															for (int j = 0; j < string_5.Length; j++)
															{
																if (text2 == string_5[j])
																{
																	flag6 = true;
																	break;
																}
															}
															if ((int_3 > 0 && flag6) || (int_6 > 0 && !flag6))
															{
																break;
															}
														}
														if (array5[0] == 0 || array5[1] == 0)
														{
															break;
														}
														Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_88.uint_0, array, 4, ref int_8);
														uint num38 = BitConverter.ToUInt32(array, 0);
														if (num38 != 0)
														{
															if (Form1.int_110 > 0 && num38 == num7)
															{
																break;
															}
															if (int_2 > 0 && uint_0 != null && !AuxiliaryMachineManager.bool_4)
															{
																bool flag7 = false;
																for (int k = 0; k < uint_0.Length; k++)
																{
																	if (num38 == uint_0[k])
																	{
																		flag7 = true;
																		break;
																	}
																}
																if (flag7)
																{
																	break;
																}
															}
															if (int_1 > 0 && uint_1 != null)
															{
																int num39 = 0;
																while (num39 < uint_1.Length)
																{
																	if (num38 != uint_1[num39])
																	{
																		num39++;
																		continue;
																	}
																	if (bool_2)
																	{
																		if (num29 > 0 && num26 > 0L && num26 < 1000L)
																		{
																			array9[0, 0] = num20;
																			array9[0, 1] = (int)num17;
																			array9[0, 2] = num24;
																			array9[0, 3] = (int)Class64.smethod_18(uint_3, array12);
																			array9[0, 4] = (int)array12[0];
																			array9[0, 5] = (int)array12[1];
																			array9[0, 6] = num27;
																			array9[0, 7] = num28;
																			array9[0, 8] = num29;
																			array9[0, 9] = (int)num26;
																			array9[0, 10] = num36;
																			array9[1, 1] = -1;
																			return array9;
																		}
																		if (num29 <= 0 || num26 <= 0L)
																		{
																			continue;
																		}
																	}
																	goto IL_0d7d;
																}
															}
														}
														if (!flag || (num7 == num38 && num7 != 0 && num38 != 0))
														{
															Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_61.uint_0, array, 4, ref int_8);
															uint num40 = BitConverter.ToUInt32(array, 0);
															Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19, array, 4, ref int_8);
															uint num41 = BitConverter.ToUInt32(array, 0);
															if (num40 == num41)
															{
																Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_62.uint_0, array, 4, ref int_8);
																characterAccountConfig_0.gstruct45_0.uint_2 = BitConverter.ToUInt32(array, 0);
																if (characterAccountConfig_0.gstruct45_0.uint_2 == 2)
																{
																	goto IL_0d7d;
																}
															}
															if (num25 == num10 && num25 != 4)
															{
																break;
															}
															Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_56.uint_0, array, 4, ref int_8);
															int num42 = BitConverter.ToInt32(array, 0);
															if (num11 + num42 <= 1)
															{
																break;
															}
														}
													}
													goto IL_0d7d;
												}
												goto IL_0f77;
												IL_0d7d:
												try
												{
													if (num20 > 1)
													{
														num20 = 1;
													}
													long num43 = array8[num20, num35, 2];
													if (num43 <= 0L || num43 >= num34)
													{
														array10[num20]++;
														array8[num20, num35, 0] = num17 + array6[0];
														array8[num20, num35, 1] = num24;
														array8[num20, num35, 2] = ((!bool_2 || num29 <= 0 || num26 <= 0L || num26 >= 1000L) ? num34 : (num34 - 50000L));
														array8[num20, num35, 3] = array12[0];
														array8[num20, num35, 4] = array12[1];
														array8[num20, num35, 5] = num27;
														array8[num20, num35, 6] = num28;
														array8[num20, num35, 7] = num29;
														array8[num20, num35, 8] = num26;
														array8[num20, num35, 9] = num36;
														num15++;
													}
												}
												catch
												{
												}
												if (!bool_2 || array9[0, 1] <= 0)
												{
													break;
												}
												goto IL_0f77;
												IL_0f77:
												array9[0, 0] = num20;
												array9[0, 1] = (int)num17;
												array9[0, 2] = num24;
												array9[0, 3] = (int)Class64.smethod_18(uint_3, array12);
												array9[0, 4] = (int)array12[0];
												array9[0, 5] = (int)array12[1];
												array9[0, 6] = num27;
												array9[0, 7] = num28;
												array9[0, 8] = num29;
												array9[0, 9] = (int)num26;
												array9[1, 1] = -1;
												goto end_IL_0306;
											}
										}
									}
								}
							}
						}
					}
					else
					{
						num16++;
					}
					goto IL_0eb1;
				}
			}
			if (num15 == 0)
			{
				return null;
			}
			int num44 = 2;
			while (true)
			{
				num44--;
				if (num44 < 0)
				{
					break;
				}
				if (array10[num44] == 0)
				{
					continue;
				}
				if (characterAccountConfig_0.int_88 <= 0)
				{
					int num45 = -1;
					long num46 = -1L;
					for (int l = 0; l < 5; l++)
					{
						if (array8[num44, l, 0] > 0L)
						{
							bool flag8 = num46 > array8[num44, l, 2] && array7[1] > 0;
							bool flag9 = num46 < array8[num44, l, 2] && array7[1] <= 0;
							if (num46 < 0L || flag8 || flag9)
							{
								num45 = l + array7[1] - array7[0];
								num46 = array8[num44, l, 2];
							}
						}
					}
					if (0 > num45)
					{
						continue;
					}
					array9[0, 0] = num44;
					array9[0, 1] = (int)array8[num44, num45, 0];
					array9[0, 2] = (int)array8[num44, num45, 1];
					array9[0, 3] = (int)array8[num44, num45, 2];
					array9[0, 4] = (int)array8[num44, num45, 3];
					array9[0, 5] = (int)array8[num44, num45, 4];
					array9[0, 6] = (int)array8[num44, num45, 5];
					array9[0, 7] = (int)array8[num44, num45, 6];
					array9[0, 8] = (int)array8[num44, num45, 7];
					array9[0, 9] = (int)array8[num44, num45, 8];
					array9[0, 10] = (int)array8[num44, num45, 9];
					break;
				}
				int num47 = 0;
				int num49;
				if (characterAccountConfig_0.int_143 == 1 && characterAccountConfig_0.int_91 != null && characterAccountConfig_0.int_91.Length != 0)
				{
					try
					{
						string text3 = "Ưu tiên Môn phái: ";
						for (int m = 0; m < characterAccountConfig_0.int_91.Length; m++)
						{
							text3 = text3 + characterAccountConfig_0.int_91[m] + " ";
						}
					}
					catch
					{
					}
					while (num47 < characterAccountConfig_0.int_91.Length)
					{
						int num48 = characterAccountConfig_0.int_91[num47];
						num49 = smethod_11(num48);
						try
						{
							_ = $"Môn phái ID: {num48} -> Ngũ hành: {num49}";
						}
						catch
						{
						}
						if (array8[num44, num49, 0] <= 0L)
						{
							num47++;
							continue;
						}
						goto IL_1301;
					}
					continue;
				}
				while (num47 < characterAccountConfig_0.int_90.Length)
				{
					num49 = characterAccountConfig_0.int_90[num47];
					if (array8[num44, num49, 0] <= 0L)
					{
						num47++;
						continue;
					}
					goto IL_1301;
				}
				continue;
				IL_1301:
				array9[0, 0] = num44;
				array9[0, 1] = (int)array8[num44, num49, 0];
				array9[0, 2] = (int)array8[num44, num49, 1];
				array9[0, 3] = (int)array8[num44, num49, 2];
				array9[0, 4] = (int)array8[num44, num49, 3];
				array9[0, 5] = (int)array8[num44, num49, 4];
				array9[0, 6] = (int)array8[num44, num49, 5];
				array9[0, 7] = (int)array8[num44, num49, 6];
				array9[0, 8] = (int)array8[num44, num49, 7];
				array9[0, 9] = (int)array8[num44, num49, 8];
				array9[0, 10] = (int)array8[num44, num49, 9];
				break;
			}
			break;
			IL_0eb1:
			num17++;
			continue;
			end_IL_0306:
			break;
		}
		if (array9[1, 1] != -1 && array9[0, 1] > 0)
		{
			int num50 = -1;
			int num51 = -1;
			long num52 = -1L;
			if (characterAccountConfig_0.int_88 > 0)
			{
				for (int n = 0; n <= 1; n++)
				{
					for (int num53 = 0; num53 < 5; num53++)
					{
						if (array8[n, num53, 0] > 0L && array9[0, 1] != array8[n, num53, 0] && (num52 < 0L || num52 > array8[n, num53, 2]))
						{
							num50 = n;
							num51 = num53;
							num52 = array8[n, num53, 2];
						}
					}
				}
			}
			if (0 <= num50 && 0 <= num51)
			{
				array9[1, 0] = num50;
				array9[1, 1] = (int)array8[num50, num51, 0];
				array9[1, 2] = (int)array8[num50, num51, 1];
				array9[1, 3] = (int)array8[num50, num51, 2];
				array9[1, 4] = (int)array8[num50, num51, 3];
				array9[1, 5] = (int)array8[num50, num51, 4];
				array9[1, 6] = (int)array8[num50, num51, 5];
				array9[1, 7] = (int)array8[num50, num51, 6];
				array9[1, 8] = (int)array8[num50, num51, 7];
				array9[1, 9] = (int)array8[num50, num51, 8];
				array9[1, 10] = (int)array8[num50, num51, 9];
			}
		}
		try
		{
			uint[] array13 = uint_3;
			if (array13 == null || array13.Length != 2 || (array13[0] == 0 && array13[1] == 0))
			{
				uint num54 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
				int num55 = (int)Class24.smethod_30(num54 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
				uint num56 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
				uint num57 = Class56.memorySignatureScanConfig_15.uint_0;
				uint num58 = num56 + (uint)(num55 * (int)num57);
				array13 = new uint[2]
				{
					Class24.smethod_30(num58 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num58 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
			}
			if (smethod_15(characterAccountConfig_0, int_6, array13, out var int_9))
			{
				for (int num59 = 0; num59 < 11; num59++)
				{
					array9[0, num59] = int_9[num59];
				}
			}
		}
		catch
		{
		}
		return array9;
	}

	public static int[,] smethod_6(CharacterAccountConfig characterAccountConfig_0, uint uint_2, int int_6 = 600, uint[] uint_3 = null, int[] int_7 = null, bool bool_1 = false, bool bool_2 = false, bool bool_3 = false)
	{
		int int_8 = 0;
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_30.uint_0;
		uint num3 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
		uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num5 = num4 + num3;
		uint num6 = num + Class56.memorySignatureScanConfig_30.uint_0;
		uint num7 = Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_88.uint_0, characterAccountConfig_0.int_137);
		long num8 = int_6 * int_6;
		int num9 = (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		int num10 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_54.uint_0, characterAccountConfig_0.int_137);
		int num11 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_56.uint_0, characterAccountConfig_0.int_137);
		if (uint_3 == null || uint_3.Length != 2 || uint_3[0] == 0 || uint_3[1] == 0)
		{
			uint_3 = new uint[2]
			{
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
			};
		}
		int num12 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
		bool flag = !bool_3 && ((926 <= num12 && num12 <= 932) || num12 == Class40.int_0);
		bool flag2 = (463 < num12 && num12 < 472) || (479 < num12 && num12 < 496);
		byte[] array = new byte[1];
		byte[] array2 = new byte[16];
		int num13 = 11;
		int[,] array3 = new int[2, 11];
		long[,] long_ = null;
		long[,] long_2 = null;
		int num14 = 0;
		int num15 = 0;
		byte[] array4 = new byte[4];
		byte[] array5 = new byte[4];
		uint uint_4 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_4, array4, 4, ref int_8);
		int num16 = BitConverter.ToInt32(array4, 0);
		if (num16 <= 1)
		{
			return null;
		}
		uint[] array6 = new uint[2];
		int num17 = 0;
		int num18 = 0;
		uint num19 = 0u;
		for (num19 = 1u; num19 < 256; num19++)
		{
			if (bool_1 || num19 % 2 != 0 || Class89.smethod_12(characterAccountConfig_0) != 1)
			{
				if (num16 <= num18)
				{
					break;
				}
				if (num19 != num9)
				{
					uint num20 = num4 + num19 * Class56.memorySignatureScanConfig_15.uint_0;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_52.uint_0, array4, 4, ref int_8);
					int num21 = BitConverter.ToInt32(array4, 0);
					uint num22 = num20 + Class56.memorySignatureScanConfig_16.uint_0;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num22, array4, 4, ref int_8);
					if (array4[0] == 0 && (num21 != 1 || Form1.int_123 <= 0))
					{
						continue;
					}
					bool flag3 = array4[0] == 84 && array4[2] == 211;
					num18++;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_50.uint_0, array4, 4, ref int_8);
					if (BitConverter.ToInt32(array4, 0) <= 0)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_43.uint_0, array4, 4, ref int_8);
					int num23 = BitConverter.ToInt32(array4, 0);
					if (num21 > 0 && num23 <= 0)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_55.uint_0, array4, 4, ref int_8);
					int num24 = BitConverter.ToInt32(array4, 0);
					if (num24 == 10 || num24 == 21)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20, array5, 4, ref int_8);
					int num25 = BitConverter.ToInt32(array5, 0);
					if (num25 == -1 || num25 == 0)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_54.uint_0, array4, 4, ref int_8);
					int num26 = BitConverter.ToInt32(array4, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_45.uint_0, array4, 4, ref int_8);
					long num27 = BitConverter.ToInt32(array4, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_26.uint_0 + 8, array4, 4, ref int_8);
					int num28 = BitConverter.ToInt32(array4, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_26.uint_0 + 12, array4, 4, ref int_8);
					int num29 = BitConverter.ToInt32(array4, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_51.uint_0, array4, 4, ref int_8);
					int num30 = BitConverter.ToInt32(array4, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array4, 4, ref int_8);
					array6[0] = BitConverter.ToUInt32(array4, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array4, 4, ref int_8);
					array6[1] = BitConverter.ToUInt32(array4, 0);
					int num31 = 0;
					bool flag4 = false;
					if (flag2 && Form1.int_122 > 0 && num21 <= 0)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_15 + num19 * 8, array4, 4, ref int_8);
						if (BitConverter.ToUInt32(array4, 0) != num25)
						{
							array[0] = 0;
							if (flag3)
							{
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num22 + 5, array4, 4, ref int_8);
								if (BitConverter.ToUInt32(array4, 0) == 3580454990u)
								{
									array[0] = 1;
								}
							}
							if (array[0] <= 0)
							{
								uint num32 = num4 + num19 * Class56.memorySignatureScanConfig_15.uint_0 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_2.uint_0;
								for (uint num33 = 0u; num33 < 6; num33++)
								{
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num32 + Class56.memorySignatureScanConfig_3.uint_0 * num33, array4, 4, ref int_8);
									if (BitConverter.ToInt32(array4, 0) == 45)
									{
										array[0] = 1;
										break;
									}
								}
							}
							Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_15 + num19 * 8, array5, 4, ref int_8);
							Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_15 + num19 * 8 + 4, array, 1, ref int_8);
							if (array[0] > 0)
							{
								num31 = 1;
								int num34 = 0;
								while (bool_0 && num34 < 15)
								{
									Thread.Sleep(10);
									num34++;
								}
								bool_0 = true;
								int num35 = 1;
								if (gstruct26_0 != null)
								{
									num35 = gstruct26_0.Length + 1;
									Array.Resize(ref gstruct26_0, num35);
								}
								else
								{
									gstruct26_0 = new GStruct26[1];
								}
								gstruct26_0[num35 - 1].int_0 = num25;
								gstruct26_0[num35 - 1].int_1 = num12;
								gstruct26_0[num35 - 1].int_2 = 1;
								gstruct26_0[num35 - 1].uint_1 = new uint[2]
								{
									array6[0],
									array6[1]
								};
								bool_0 = false;
							}
						}
						else
						{
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_15 + num19 * 8 + 4, array, 1, ref int_8);
							if (array[0] == 0 && smethod_4(characterAccountConfig_0.int_137, num12, array6) != 0)
							{
								array[0] = 1;
							}
							num31 = array[0];
						}
					}
					while (true)
					{
						long num36;
						if (!flag4 && (uint_2 == 0 || num25 != uint_2))
						{
							num36 = Class64.smethod_18(uint_3, array6);
							if (num36 > num8)
							{
								break;
							}
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_53.uint_0, array4, 4, ref int_8);
							int num37 = BitConverter.ToInt32(array4, 0);
							if (num37 < 0 || num37 > 4)
							{
								break;
							}
							if (num21 <= 0)
							{
								if (Form1.int_35 <= 0 || (num10 > 0 && num26 == num10 && num26 != 4))
								{
									break;
								}
								if (!flag)
								{
									bool flag5 = false;
									if (int_7 != null)
									{
										for (int i = 0; i < int_7.Length; i++)
										{
											if (num19 == int_7[i])
											{
												flag5 = true;
												break;
											}
										}
									}
									if (flag5)
									{
										break;
									}
									bool flag6 = num28 > 0 && num29 > 15 && num30 > 0;
									if (Form1.int_36 > 0 || num27 <= 0L)
									{
										if (flag6)
										{
											if (Form1.int_40 > 0)
											{
												flag4 = true;
												continue;
											}
										}
										else if (bool_2)
										{
											if (num30 <= 0 || num27 <= 0L)
											{
												break;
											}
										}
										else if (num30 <= 95 || num27 <= 0L)
										{
											break;
										}
									}
								}
								else
								{
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_16.uint_0, array, array.Length, ref int_8);
									string text = Class1.smethod_3(array);
									if (!(text == string.Empty) && Class11.smethod_1(text, "[" + characterAccountConfig_0.string_20 + "]") > 0)
									{
										break;
									}
									if (Form1.int_36 > 0 && Form1.int_40 > 0)
									{
										flag4 = true;
										continue;
									}
								}
							}
							else
							{
								if (Form1.int_34 <= 0 || num23 <= 0 || num26 == 0 || num10 == 0 || (Form1.int_39 <= 0 && (num24 == 3 || num24 == 4)))
								{
									break;
								}
								if (Form1.int_92 > 0)
								{
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_51.uint_0, array4, 4, ref int_8);
									int num38 = BitConverter.ToInt32(array4, 0);
									if (num38 < Form1.int_93)
									{
										break;
									}
								}
								if (string_5 != null && string_5.Length != 0)
								{
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_16.uint_0, array2, array2.Length, ref int_8);
									string text2 = Class1.smethod_3(array2);
									bool flag7 = false;
									for (int j = 0; j < string_5.Length; j++)
									{
										if (text2 == string_5[j])
										{
											flag7 = true;
											break;
										}
									}
									if ((int_3 > 0 && flag7) || (int_6 > 0 && !flag7))
									{
										break;
									}
								}
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_88.uint_0, array4, 4, ref int_8);
								uint num39 = BitConverter.ToUInt32(array4, 0);
								if (num39 != 0)
								{
									if (Form1.int_110 > 0 && num39 == num7)
									{
										break;
									}
									if (int_2 > 0 && uint_0 != null && !AuxiliaryMachineManager.bool_4)
									{
										bool flag8 = false;
										for (int k = 0; k < uint_0.Length; k++)
										{
											if (num39 == uint_0[k])
											{
												flag8 = true;
												break;
											}
										}
										if (flag8)
										{
											break;
										}
									}
									if (int_1 > 0 && uint_1 != null)
									{
										int num40 = 0;
										while (num40 < uint_1.Length)
										{
											if (num39 != uint_1[num40])
											{
												num40++;
												continue;
											}
											goto IL_0cb4;
										}
									}
								}
								if (!flag || (num7 == num39 && num7 != 0 && num39 != 0))
								{
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_61.uint_0, array4, 4, ref int_8);
									uint num41 = BitConverter.ToUInt32(array4, 0);
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20, array4, 4, ref int_8);
									uint num42 = BitConverter.ToUInt32(array4, 0);
									if (num41 == num42)
									{
										Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_62.uint_0, array4, 4, ref int_8);
										characterAccountConfig_0.gstruct45_0.uint_2 = BitConverter.ToUInt32(array4, 0);
										if (characterAccountConfig_0.gstruct45_0.uint_2 == 2)
										{
											goto IL_0cb4;
										}
									}
									if (num26 == num10 && num26 != 4)
									{
										break;
									}
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num20 + Class56.memorySignatureScanConfig_56.uint_0, array4, 4, ref int_8);
									int num43 = BitConverter.ToInt32(array4, 0);
									if (num11 + num43 <= 1)
									{
										break;
									}
								}
							}
							if (bool_2)
							{
								if (num30 > 0 && num27 > 0L && num27 < 1000L)
								{
									array3[0, 0] = num21;
									array3[0, 1] = (int)num19;
									array3[0, 2] = num25;
									array3[0, 3] = (int)Class64.smethod_18(uint_3, array6);
									array3[0, 4] = (int)array6[0];
									array3[0, 5] = (int)array6[1];
									array3[0, 6] = num28;
									array3[0, 7] = num29;
									array3[0, 8] = num30;
									array3[0, 9] = (int)num27;
									array3[0, 10] = num31;
									array3[1, 1] = -1;
									return array3;
								}
								if (num30 <= 0 || num27 <= 0L)
								{
									goto IL_0f63;
								}
							}
							goto IL_0cb4;
						}
						goto IL_0f63;
						IL_0f63:
						array3[0, 0] = num21;
						array3[0, 1] = (int)num19;
						array3[0, 2] = num25;
						array3[0, 3] = (int)Class64.smethod_18(uint_3, array6);
						array3[0, 4] = (int)array6[0];
						array3[0, 5] = (int)array6[1];
						array3[0, 6] = num28;
						array3[0, 7] = num29;
						array3[0, 8] = num30;
						array3[0, 9] = (int)num27;
						array3[0, 10] = num31;
						array3[1, 1] = -1;
						return array3;
						IL_0cb4:
						try
						{
							if (num13 < 11)
							{
								num13 = 11;
							}
							if (num21 == 0)
							{
								num14 = Class11.smethod_40(ref long_, 1, num13);
								long_[num14 - 1, 0] = num21;
								long_[num14 - 1, 1] = num19;
								long_[num14 - 1, 2] = num25;
								long num44 = (long_[num14 - 1, 3] = ((!bool_2 || num30 <= 0 || num27 <= 0L || num27 >= 1000L) ? num36 : (num36 - 50000L)));
								long_[num14 - 1, 3] = num44;
								long_[num14 - 1, 4] = array6[0];
								long_[num14 - 1, 5] = array6[1];
								long_[num14 - 1, 6] = num28;
								long_[num14 - 1, 7] = num29;
								long_[num14 - 1, 8] = num30;
								long_[num14 - 1, 9] = num27;
								long_[num14 - 1, 10] = num31;
							}
							else
							{
								num15 = Class11.smethod_40(ref long_2, 1, num13);
								long_2[num15 - 1, 0] = num21;
								long_2[num15 - 1, 1] = num19;
								long_2[num15 - 1, 2] = num25;
								long_2[num15 - 1, 3] = num36;
								long_2[num15 - 1, 4] = array6[0];
								long_2[num15 - 1, 5] = array6[1];
								long_2[num15 - 1, 6] = num28;
								long_2[num15 - 1, 7] = num29;
								long_2[num15 - 1, 8] = num30;
								long_2[num15 - 1, 9] = num27;
							}
							num17++;
						}
						catch
						{
						}
						if (!bool_2 || array3[0, 1] <= 0)
						{
							break;
						}
						return array3;
					}
				}
				else
				{
					num18++;
				}
				continue;
			}
			array3[0, 0] = -100;
			array3[1, 0] = -100;
			return array3;
		}
		if (num17 != 0)
		{
			array3 = new int[num14 + num15, num13];
			long num45 = 0L;
			if (num15 > 0)
			{
				while (true)
				{
					int l;
					int num46;
					for (l = 0; l < num15 - 1; l++)
					{
						num46 = l;
						while (num46 < num15)
						{
							if (long_2[num46, 3] >= long_2[l, 3])
							{
								num46++;
								continue;
							}
							goto IL_109a;
						}
						for (int m = 0; m < num13; m++)
						{
							array3[l, m] = (int)long_2[l, m];
						}
					}
					break;
					IL_109a:
					for (int n = 0; n < num13; n++)
					{
						num45 = long_2[l, n];
						long_2[l, n] = long_2[num46, n];
						long_2[num46, n] = num45;
					}
				}
				for (int num47 = 0; num47 < num13; num47++)
				{
					array3[num15 - 1, num47] = (int)long_2[num15 - 1, num47];
				}
			}
			if (num14 > 0)
			{
				while (true)
				{
					int num48;
					int num49;
					for (num48 = 0; num48 < num14 - 1; num48++)
					{
						num49 = num48;
						while (num49 < num14)
						{
							if (long_[num49, 3] >= long_[num48, 3])
							{
								num49++;
								continue;
							}
							goto IL_118d;
						}
						for (int num50 = 0; num50 < num13; num50++)
						{
							array3[num15 + num48, num50] = (int)long_[num48, num50];
						}
					}
					break;
					IL_118d:
					for (int num51 = 0; num51 < num13; num51++)
					{
						num45 = long_[num48, num51];
						long_[num48, num51] = long_[num49, num51];
						long_[num49, num51] = num45;
					}
				}
				for (int num52 = 0; num52 < num13; num52++)
				{
					array3[num15 + num14 - 1, num52] = (int)long_[num14 - 1, num52];
				}
			}
			return array3;
		}
		return null;
	}

	public static string smethod_7(CharacterAccountConfig characterAccountConfig_0, uint[] uint_2 = null)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		uint uint_3 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_3, array, 4, ref int_);
		int num = BitConverter.ToInt32(array, 0);
		if (num <= 1)
		{
			return null;
		}
		string text = null;
		long num2 = 0L;
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		if (uint_2 == null)
		{
			uint_2 = Class38.smethod_30(characterAccountConfig_0);
		}
		uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		int num5 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		int num6 = 0;
		byte[] array2 = new byte[2];
		Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_1 * 4, array2, 2, ref int_);
		for (int i = 1; i < 256; i++)
		{
			if (text == null || i <= 40)
			{
				if (num <= num6)
				{
					break;
				}
				if (i != num5)
				{
					uint num7 = num3 + (uint)(i * (int)Class56.memorySignatureScanConfig_15.uint_0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_);
					if (array[0] == 0)
					{
						continue;
					}
					num6++;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
					if (BitConverter.ToInt32(array, 0) <= 0 || (int)Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137) <= 0)
					{
						continue;
					}
					int num8 = (int)Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
					if (num8 == 10 || num8 == 21)
					{
						continue;
					}
					int num9 = (int)Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137);
					if (num9 != 1 || array2[0] == 0 || array2[1] == 0)
					{
						continue;
					}
					uint[] array3 = new uint[2]
					{
						Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					long num10 = Class64.smethod_18(uint_2, array3);
					if (num10 == 0L || (text != null && num10 > 1690000L) || (text != null && num2 <= num10))
					{
						continue;
					}
					string text2 = Class24.smethod_28(num7 + Class56.memorySignatureScanConfig_16.uint_0, characterAccountConfig_0.int_137, 32);
					for (int j = 0; j < characterAccountConfig_0.string_18.Length; j++)
					{
						if (text2 == characterAccountConfig_0.string_18[j])
						{
							text = text2;
							num2 = num10;
							break;
						}
					}
				}
				else
				{
					num6++;
				}
				continue;
			}
			return text;
		}
		return text;
	}

	public static uint[] smethod_8(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		int int_ = 0;
		byte[] array = new byte[4];
		uint uint_3 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_3, array, 4, ref int_);
		byte[] array2 = new byte[2];
		Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_1 * 4, array2, 2, ref int_);
		int num2 = BitConverter.ToInt32(array, 0);
		if (num2 > 1 && array2[0] != 0 && array2[1] != 0)
		{
			uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			int num4 = (int)Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
			int num5 = 0;
			for (uint num6 = 1u; num6 < 256; num6++)
			{
				if (num2 <= num5)
				{
					break;
				}
				if (num6 == num4)
				{
					num5++;
					continue;
				}
				uint num7 = num + num6 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				num5++;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) <= 0)
				{
					continue;
				}
				uint num8 = Class24.smethod_30(num7, characterAccountConfig_0.int_137);
				if (uint_2 == num8)
				{
					uint num9 = Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137);
					if (num9 == 0 || array2[0] != 0)
					{
						uint num10 = Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137);
						uint num11 = Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137);
						return new uint[5] { num6, num9, 0u, num10, num11 };
					}
				}
			}
			return null;
		}
		return null;
	}

	public static int[,] smethod_9(CharacterAccountConfig characterAccountConfig_0, uint uint_2, int int_6 = 600, uint[] uint_3 = null, int[] int_7 = null, bool bool_1 = false)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_30.uint_0;
		uint num3 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
		uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num5 = num4 + num3;
		uint num6 = num + Class56.memorySignatureScanConfig_30.uint_0;
		Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_88.uint_0, characterAccountConfig_0.int_137);
		long num7 = int_6 * int_6;
		int num8 = (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		int num9 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_54.uint_0, characterAccountConfig_0.int_137);
		int num10 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_56.uint_0, characterAccountConfig_0.int_137);
		if (uint_3 == null || uint_3.Length != 2 || uint_3[0] == 0 || uint_3[1] == 0)
		{
			uint_3 = new uint[2]
			{
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
			};
		}
		int num11 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
		bool flag = (926 <= num11 && num11 <= 932) || num11 == Class40.int_0;
		byte[] array = new byte[60];
		int num12 = 10;
		int[,] array2 = new int[2, 10];
		long[,] long_ = null;
		long[,] long_2 = null;
		int num13 = 0;
		int num14 = 0;
		int int_8 = 0;
		byte[] array3 = new byte[4];
		uint uint_4 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_4, array3, 4, ref int_8);
		int num15 = BitConverter.ToInt32(array3, 0);
		if (num15 > 1)
		{
			uint[] array4 = new uint[2];
			int num16 = 0;
			int num17 = 0;
			uint num18 = 0u;
			for (num18 = 1u; num18 < 256; num18++)
			{
				if (bool_1 || num18 % 2 != 0 || Class89.smethod_12(characterAccountConfig_0) != 1)
				{
					if (num15 <= num17)
					{
						break;
					}
					if (num18 == num8)
					{
						num17++;
						continue;
					}
					uint num19 = num4 + num18 * Class56.memorySignatureScanConfig_15.uint_0;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_16.uint_0, array3, 4, ref int_8);
					if (array3[0] == 0)
					{
						continue;
					}
					num17++;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_8);
					if (BitConverter.ToInt32(array3, 0) <= 0)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_52.uint_0, array3, 4, ref int_8);
					int num20 = BitConverter.ToInt32(array3, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_8);
					int num21 = BitConverter.ToInt32(array3, 0);
					if (num20 < 0 || (num20 > 0 && num21 <= 0))
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_55.uint_0, array3, 4, ref int_8);
					int num22 = BitConverter.ToInt32(array3, 0);
					if (num22 == 10 || num22 == 21)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19, array3, 4, ref int_8);
					int num23 = BitConverter.ToInt32(array3, 0);
					if (num23 == -1 || num23 == 0)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_54.uint_0, array3, 4, ref int_8);
					int num24 = BitConverter.ToInt32(array3, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_45.uint_0, array3, 4, ref int_8);
					long num25 = BitConverter.ToInt32(array3, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_26.uint_0 + 8, array3, 4, ref int_8);
					int num26 = BitConverter.ToInt32(array3, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_26.uint_0 + 12, array3, 4, ref int_8);
					int num27 = BitConverter.ToInt32(array3, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_51.uint_0, array3, 4, ref int_8);
					int num28 = BitConverter.ToInt32(array3, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array3, 4, ref int_8);
					array4[0] = BitConverter.ToUInt32(array3, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array3, 4, ref int_8);
					array4[1] = BitConverter.ToUInt32(array3, 0);
					bool flag2 = false;
					while (true)
					{
						long num29;
						if (!flag2 && (uint_2 == 0 || num23 != uint_2))
						{
							num29 = Class64.smethod_18(uint_3, array4);
							if (num29 > num7)
							{
								break;
							}
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_53.uint_0, array3, 4, ref int_8);
							int num30 = BitConverter.ToInt32(array3, 0);
							if (num30 < 0 || num30 > 4)
							{
								break;
							}
							if (num20 <= 0)
							{
								if (characterAccountConfig_0.int_27 <= 0 || (num9 > 0 && num24 == num9 && num24 != 4))
								{
									break;
								}
								if (!flag)
								{
									bool flag3 = false;
									if (int_7 != null)
									{
										for (int i = 0; i < int_7.Length; i++)
										{
											if (num18 == int_7[i])
											{
												flag3 = true;
												break;
											}
										}
									}
									if (flag3)
									{
										break;
									}
									if (Form1.int_36 > 0 || num25 <= 0L)
									{
										if (num26 <= 0 || num27 <= 15 || num28 <= 0)
										{
											break;
										}
										if (Form1.int_40 > 0)
										{
											flag2 = true;
											continue;
										}
									}
								}
								else
								{
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_16.uint_0, array, array.Length, ref int_8);
									string text = Class1.smethod_3(array);
									if (!(text == string.Empty) && Class11.smethod_1(text, "[" + characterAccountConfig_0.string_20 + "]") > 0)
									{
										break;
									}
								}
							}
							else
							{
								if (num21 <= 0 || num24 == 0 || num9 == 0)
								{
									break;
								}
								if (num24 != num9 || num24 == 4)
								{
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19 + Class56.memorySignatureScanConfig_56.uint_0, array3, 4, ref int_8);
									int num31 = BitConverter.ToInt32(array3, 0);
									if (num10 + num31 > 1)
									{
										goto IL_0771;
									}
								}
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_61.uint_0, array3, 4, ref int_8);
								uint num32 = BitConverter.ToUInt32(array3, 0);
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num19, array3, 4, ref int_8);
								uint num33 = BitConverter.ToUInt32(array3, 0);
								if (num32 != num33)
								{
									break;
								}
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_62.uint_0, array3, 4, ref int_8);
								characterAccountConfig_0.gstruct45_0.uint_2 = BitConverter.ToUInt32(array3, 0);
								if (characterAccountConfig_0.gstruct45_0.uint_2 != 2)
								{
									break;
								}
							}
							goto IL_0771;
						}
						array2[0, 0] = num20;
						array2[0, 1] = (int)num18;
						array2[0, 2] = num23;
						array2[0, 3] = (int)Class64.smethod_18(uint_3, array4);
						array2[0, 4] = (int)array4[0];
						array2[0, 5] = (int)array4[1];
						array2[0, 6] = num26;
						array2[0, 7] = num27;
						array2[0, 8] = num28;
						array2[0, 9] = (int)num25;
						array2[1, 1] = -1;
						return array2;
						IL_0771:
						try
						{
							if (num12 < 10)
							{
								num12 = 10;
							}
							if (num20 == 0)
							{
								num13 = Class11.smethod_40(ref long_, 1, num12);
								long_[num13 - 1, 0] = num20;
								long_[num13 - 1, 1] = num18;
								long_[num13 - 1, 2] = num23;
								long_[num13 - 1, 3] = num29;
								long_[num13 - 1, 4] = array4[0];
								long_[num13 - 1, 5] = array4[1];
								long_[num13 - 1, 6] = num26;
								long_[num13 - 1, 7] = num27;
								long_[num13 - 1, 8] = num28;
								long_[num13 - 1, 9] = num25;
							}
							else
							{
								num14 = Class11.smethod_40(ref long_2, 1, num12);
								long_2[num14 - 1, 0] = num20;
								long_2[num14 - 1, 1] = num18;
								long_2[num14 - 1, 2] = num23;
								long_2[num14 - 1, 3] = num29;
								long_2[num14 - 1, 4] = array4[0];
								long_2[num14 - 1, 5] = array4[1];
								long_2[num14 - 1, 6] = num26;
								long_2[num14 - 1, 7] = num27;
								long_2[num14 - 1, 8] = num28;
								long_2[num14 - 1, 9] = num25;
							}
							num16++;
						}
						catch
						{
						}
						break;
					}
					continue;
				}
				array2[0, 0] = -100;
				array2[1, 0] = -100;
				return array2;
			}
			if (num16 != 0)
			{
				array2 = new int[num13 + num14, num12];
				long num34 = 0L;
				if (num14 > 0)
				{
					while (true)
					{
						int j;
						int num35;
						for (j = 0; j < num14 - 1; j++)
						{
							num35 = j;
							while (num35 < num14)
							{
								if (long_2[num35, 3] >= long_2[j, 3])
								{
									num35++;
									continue;
								}
								goto IL_0a36;
							}
							for (int k = 0; k < num12; k++)
							{
								array2[j, k] = (int)long_2[j, k];
							}
						}
						break;
						IL_0a36:
						for (int l = 0; l < num12; l++)
						{
							num34 = long_2[j, l];
							long_2[j, l] = long_2[num35, l];
							long_2[num35, l] = num34;
						}
					}
					for (int m = 0; m < num12; m++)
					{
						array2[num14 - 1, m] = (int)long_2[num14 - 1, m];
					}
				}
				if (num13 > 0)
				{
					while (true)
					{
						int n;
						int num36;
						for (n = 0; n < num13 - 1; n++)
						{
							num36 = n;
							while (num36 < num13)
							{
								if (long_[num36, 3] >= long_[n, 3])
								{
									num36++;
									continue;
								}
								goto IL_0b29;
							}
							for (int num37 = 0; num37 < num12; num37++)
							{
								array2[num14 + n, num37] = (int)long_[n, num37];
							}
						}
						break;
						IL_0b29:
						for (int num38 = 0; num38 < num12; num38++)
						{
							num34 = long_[n, num38];
							long_[n, num38] = long_[num36, num38];
							long_[num36, num38] = num34;
						}
					}
					for (int num39 = 0; num39 < num12; num39++)
					{
						array2[num14 + num13 - 1, num39] = (int)long_[num13 - 1, num39];
					}
				}
				return array2;
			}
			return null;
		}
		return null;
	}

	public static int smethod_10(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		int int_;
		byte[] array2;
		uint num8;
		uint[] array3;
		uint[] array4;
		if (characterAccountConfig_0.gstruct50_0.int_0 != 0 && characterAccountConfig_0.gstruct50_0.int_1 > 0 && uint_2 != 0)
		{
			int_ = 0;
			if (characterAccountConfig_0.gstruct50_0.int_6 > 0)
			{
				byte[] array = new byte[8];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_26 * 4, array, 8, ref int_);
				long num = BitConverter.ToInt64(array, 0);
				long ticks = DateTime.Now.Ticks;
				long num2 = (long)new TimeSpan(ticks - num).TotalMilliseconds;
				if (num > 0L && num2 <= characterAccountConfig_0.gstruct50_0.int_6 * 1000)
				{
					return 0;
				}
				array = BitConverter.GetBytes(ticks);
				Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_26 * 4, array, 8, ref int_);
			}
			array2 = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array2, 4, ref int_);
			uint num3 = BitConverter.ToUInt32(array2, 0);
			if (num3 == 0)
			{
				return 0;
			}
			uint num4 = num3 + uint_2 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4, array2, 4, ref int_);
			int num5 = BitConverter.ToInt32(array2, 0);
			if (num5 != 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_52.uint_0, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) == 0 && characterAccountConfig_0.gstruct50_0.int_5 == 0)
				{
					return 0;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_);
				uint num6 = BitConverter.ToUInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_13.uint_0, array2, 4, ref int_);
				uint num7 = BitConverter.ToUInt32(array2, 0) * Class56.memorySignatureScanConfig_15.uint_0;
				num8 = num3 + num7;
				array3 = new uint[2];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array2, 4, ref int_);
				array3[0] = BitConverter.ToUInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array2, 4, ref int_);
				array3[1] = BitConverter.ToUInt32(array2, 0);
				array4 = new uint[2];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array2, 4, ref int_);
				array4[0] = BitConverter.ToUInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array2, 4, ref int_);
				array4[1] = BitConverter.ToUInt32(array2, 0);
				if (characterAccountConfig_0.gstruct50_0.int_2 == 0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_24 * 4, array2, 4, ref int_);
					if (BitConverter.ToInt32(array2, 0) != num5)
					{
						array2 = BitConverter.GetBytes(num5);
						Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_24 * 4, array2, 4, ref int_);
						goto IL_047a;
					}
				}
				if (characterAccountConfig_0.gstruct50_0.int_2 == 1)
				{
					byte[] array5 = new byte[8];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_25 * 4, array5, 8, ref int_);
					long num9 = BitConverter.ToInt64(array5, 0);
					long ticks2 = DateTime.Now.Ticks;
					long num10 = (long)new TimeSpan(ticks2 - num9).TotalMilliseconds;
					if (num9 == 0L || num10 > characterAccountConfig_0.gstruct50_0.int_3)
					{
						array5 = BitConverter.GetBytes(ticks2);
						Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_25 * 4, array5, 8, ref int_);
						goto IL_047a;
					}
				}
				if (characterAccountConfig_0.gstruct50_0.int_2 == 2)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_24 * 4, array2, 4, ref int_);
					if (BitConverter.ToInt32(array2, 0) == num5)
					{
						long num11 = Class64.smethod_18(array4, array3);
						long num12 = characterAccountConfig_0.gstruct50_0.int_7 * characterAccountConfig_0.gstruct50_0.int_7;
						if (num11 <= num12)
						{
							goto IL_05b0;
						}
					}
					else
					{
						array2 = BitConverter.GetBytes(num5);
						Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_24 * 4, array2, 4, ref int_);
					}
					goto IL_047a;
				}
				goto IL_05b0;
			}
			return 0;
		}
		return 0;
		IL_05b0:
		return 0;
		IL_047a:
		int i = 0;
		int num13 = 0;
		byte[] byte_ = new byte[4];
		for (; i < 30; i++)
		{
			if (num13 >= 5)
			{
				break;
			}
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_);
			Thread.Sleep(10);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_55.uint_0, array2, 4, ref int_);
			num13 = ((array2[0] == 1) ? (num13 + 1) : 0);
		}
		if (characterAccountConfig_0.gstruct50_0.int_4 <= 0)
		{
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(characterAccountConfig_0.gstruct50_0.int_1), 4, ref int_);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(uint_2), 4, ref int_);
		}
		else
		{
			uint[] array6 = Class89.smethod_10(array4, array3);
			uint uint_3 = (array6[1] << 16) + array6[0];
			Class89.smethod_7(characterAccountConfig_0, uint_3);
			Class83.smethod_9(characterAccountConfig_0);
			Class83.smethod_5(characterAccountConfig_0, characterAccountConfig_0.gstruct50_0.int_1, 6, 1);
			Thread.Sleep(120);
			Class24.smethod_76(characterAccountConfig_0.uint_4, 117);
		}
		Thread.Sleep(100);
		return 1;
	}

	private static int smethod_11(int int_6)
	{
		switch (int_6)
		{
		default:
			return 0;
		case 2:
		case 4:
			return 4;
		case 3:
		case 6:
			return 2;
		case 5:
		case 9:
			return 1;
		case 7:
		case 10:
			return 3;
		case 1:
		case 8:
		case 11:
			return 0;
		}
	}

	private static string smethod_12(string string_6)
	{
		if (string.IsNullOrEmpty(string_6))
		{
			return string.Empty;
		}
		string text = string_6.Normalize(NormalizationForm.FormD);
		StringBuilder stringBuilder = new StringBuilder(text.Length);
		string text2 = text;
		foreach (char c in text2)
		{
			UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
			if (unicodeCategory != UnicodeCategory.NonSpacingMark)
			{
				stringBuilder.Append(char.ToLowerInvariant(c));
			}
		}
		return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
	}

	private static int smethod_13(string string_6)
	{
		if (string.IsNullOrEmpty(string_6))
		{
			return 999;
		}
		string text = smethod_12(string_6);
		string text2 = string_6.ToLowerInvariant();
		if (!text.Contains("dai tuong") && !text2.Contains("đại tướng") && !text2.Contains("§¹i"))
		{
			if (!text.Contains("pho tuong") && !text2.Contains("phó tướng") && !text2.Contains("ph?"))
			{
				if (!text.Contains("thong linh") && !text2.Contains("thống lĩnh") && !text2.Contains("thèng"))
				{
					if (!text.Contains("hieu uy") && !text2.Contains("hiệu úy") && !text2.Contains("hiöu"))
					{
						if (!text.Contains("binh si") && !text2.Contains("binh sĩ"))
						{
							return 999;
						}
						return 4;
					}
					return 3;
				}
				return 2;
			}
			return 1;
		}
		return 0;
	}

	private static string smethod_14(CharacterAccountConfig characterAccountConfig_0, uint uint_2)
	{
		try
		{
			byte[] byte_ = new byte[32];
			int int_ = 0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_2 + 5328, byte_, 32, ref int_);
			string text = Class1.smethod_3(byte_);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		catch
		{
		}
		try
		{
			byte[] byte_2 = new byte[64];
			int int_2 = 0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_2 + 5328, byte_2, 64, ref int_2);
			string text2 = Class1.smethod_3(byte_2);
			if (!string.IsNullOrEmpty(text2))
			{
				return text2;
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	private static bool smethod_15(CharacterAccountConfig characterAccountConfig_0, int int_6, uint[] uint_2, out int[] int_7)
	{
		int_7 = null;
		try
		{
			byte[] array = new byte[4];
			int int_8 = 0;
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num3 = Class56.memorySignatureScanConfig_15.uint_0;
			int num4 = (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
			int num5 = (int)Class24.smethod_30((uint)((int)num2 + num4 * (int)num3) + Class56.memorySignatureScanConfig_54.uint_0, characterAccountConfig_0.int_137);
			int num6 = (int)Class24.smethod_30((uint)((int)num2 + num4 * (int)num3) + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137);
			long num7 = (long)int_6 * (long)int_6;
			int num8 = 999;
			int num9 = -1;
			long num10 = 2147483647L;
			int num11 = 101;
			if (uint_2 == null || uint_2.Length != 2 || (uint_2[0] == 0 && uint_2[1] == 0))
			{
				uint num12 = num2 + (uint)(num4 * (int)num3);
				uint_2 = new uint[2]
				{
					Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
			}
			for (int i = 1; i < 256; i++)
			{
				if (i == num4)
				{
					continue;
				}
				uint num13 = num2 + (uint)(i * (int)num3);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_8);
				if (array[0] == 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_8);
				if (BitConverter.ToInt32(array, 0) <= 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_54.uint_0, array, 4, ref int_8);
				if (BitConverter.ToInt32(array, 0) != num5)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_52.uint_0, array, 4, ref int_8);
				int num14 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_8);
				int num15 = BitConverter.ToInt32(array, 0);
				if (num15 <= 0 || (num6 > 0 && num14 == num6))
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_8);
				int num16 = BitConverter.ToInt32(array, 0);
				if (num16 == 10 || num16 == 21)
				{
					continue;
				}
				uint num17 = Class24.smethod_30(num13 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137);
				uint num18 = Class24.smethod_30(num13 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137);
				long num19 = Class64.smethod_18(uint_2, new uint[2] { num17, num18 });
				if (num19 > num7)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_45.uint_0, array, 4, ref int_8);
				int num20 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_47.uint_0, array, 4, ref int_8);
				int num21 = BitConverter.ToInt32(array, 0);
				if (num21 > 0 && num20 > 0)
				{
					int num22 = ((num21 > 0) ? (num20 * 100 / num21) : 100);
					string string_ = smethod_14(characterAccountConfig_0, num13);
					int num23 = smethod_13(string_);
					if (num23 < num8 || (num23 == num8 && (num22 < num11 || (num22 == num11 && num19 < num10))))
					{
						num8 = num23;
						num10 = num19;
						num9 = i;
						num11 = num22;
					}
				}
			}
			if (num9 > 0)
			{
				uint num24 = num2 + (uint)(num9 * (int)num3);
				int[] array2 = new int[11];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num24 + Class56.memorySignatureScanConfig_52.uint_0, array, 4, ref int_8);
				array2[0] = BitConverter.ToInt32(array, 0);
				array2[1] = num9;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num24, array, 4, ref int_8);
				array2[2] = BitConverter.ToInt32(array, 0);
				uint num25 = Class24.smethod_30(num24 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137);
				uint num26 = Class24.smethod_30(num24 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137);
				array2[3] = (int)Class64.smethod_18(uint_2, new uint[2] { num25, num26 });
				array2[4] = (int)num25;
				array2[5] = (int)num26;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num24 + Class56.memorySignatureScanConfig_26.uint_0 + 8, array, 4, ref int_8);
				array2[6] = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num24 + Class56.memorySignatureScanConfig_26.uint_0 + 12, array, 4, ref int_8);
				array2[7] = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num24 + Class56.memorySignatureScanConfig_51.uint_0, array, 4, ref int_8);
				array2[8] = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num24 + Class56.memorySignatureScanConfig_45.uint_0, array, 4, ref int_8);
				array2[9] = BitConverter.ToInt32(array, 0);
				array2[10] = 0;
				int_7 = array2;
				return true;
			}
		}
		catch
		{
		}
		return false;
	}
}
