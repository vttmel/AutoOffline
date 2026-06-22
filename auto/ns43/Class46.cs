using System;
using System.Threading;
using ns100;
using ns106;
using ns11;
using ns121;
using ns23;
using ns35;
using ns40;
using ns53;
using ns61;
using ns71;
using ns77;
using ns83;
using ns85;

namespace ns43;

internal class Class46
{
	public static CharacterSyncSnapshot characterSyncSnapshot_0;

	public static CharacterSyncSnapshot characterSyncSnapshot_1;

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static uint[] uint_0 = null;

	private static int int_0 = 0;

	public static void smethod_0()
	{
		while (true)
		{
			try
			{
				if (Class11.bool_0)
				{
					break;
				}
				smethod_1();
			}
			catch
			{
			}
			Thread.Sleep(999);
		}
	}

	public static void smethod_1()
	{
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		characterSyncSnapshot_0 = new CharacterSyncSnapshot
		{
			uint_4 = new uint[2]
		};
		int num = -1;
		int num2 = -1;
		int num3 = 0;
		string[] array = new string[2] { "<color=yellow>Ac chÝnh: XXX bÞ mÊt kÕt nèi.", "<color=yellow>Ac chÝnh: XXX ®ang ho¹t ®éng." };
		long long_ = 0L;
		long long_2 = 0L;
		int int_ = 0;
		int num4 = 0;
		int num5 = 0;
		byte[] byte_ = new byte[1];
		byte[] byte_2 = new byte[2];
		byte[] array2 = new byte[4];
		while (!Class11.bool_0)
		{
			Thread.Sleep(200);
			if (Class11.smethod_28(long_2) > 6000L)
			{
				uint_0 = smethod_2();
				long_2 = Class11.smethod_27();
				Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_2 * 4, byte_, 1, ref int_);
				Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_3 * 4, byte_2, 2, ref int_);
			}
			if (Form1.int_58 != 0)
			{
				if (Form1.int_10 > 0 || Form1.int_11 > 0)
				{
					if (Form1.int_10 <= 0 && Form1.int_11 > 0)
					{
						AuxiliaryMachineManager.smethod_5(characterAccountConfig_);
					}
					if (characterSyncSnapshot_1.int_9 > 0)
					{
						smethod_8(characterSyncSnapshot_1.int_9);
					}
					if (Class11.smethod_28(long_) > 30000L)
					{
						Class89.smethod_32(characterAccountConfig_, 0u);
						long_ = Class11.smethod_27();
					}
					characterSyncSnapshot_1.int_9 = 0;
				}
				if (num != characterAccountConfig_.int_136)
				{
					num = characterAccountConfig_.int_136;
					smethod_3();
					smethod_4("<color=yellow>Ac chÝnh: " + characterAccountConfig_.string_22);
					num3 = -100;
				}
				num3--;
				if (num3 <= 0)
				{
					int num6 = Class87.smethod_3(Form1.characterAccountConfig_1, Form1.int_58);
					if (num6 < 0 || Class24.smethod_52(Form1.characterAccountConfig_1[num6].process_0))
					{
						Form1.int_58 = 0;
						continue;
					}
					characterAccountConfig_ = Form1.characterAccountConfig_1[num6];
					num3 = 10;
				}
				characterSyncSnapshot_0.uint_1 = characterAccountConfig_.uint_7;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_);
				uint num7 = BitConverter.ToUInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num7 + Class56.memorySignatureScanConfig_13.uint_0, array2, 4, ref int_);
				uint num8 = BitConverter.ToUInt32(array2, 0);
				uint num9 = num8 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_14.uint_0, array2, 4, ref int_);
				uint num10 = BitConverter.ToUInt32(array2, 0);
				uint num11 = num10 + num9;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_50.uint_0, array2, 4, ref int_);
				characterSyncSnapshot_0.int_6 = BitConverter.ToInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_27.uint_0, array2, 4, ref int_);
				int num12 = BitConverter.ToInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array2, 4, ref int_);
				uint num13 = BitConverter.ToUInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array2, 4, ref int_);
				uint num14 = BitConverter.ToUInt32(array2, 0);
				if (num12 <= 0 || num13 == 0 || num14 == 0)
				{
					Thread.Sleep(10);
					continue;
				}
				if (characterSyncSnapshot_0.int_6 <= 0 && num4 <= 60)
				{
					num4++;
					Thread.Sleep(10);
					continue;
				}
				num4 = 0;
				if (num2 != characterSyncSnapshot_0.int_6)
				{
					if (characterSyncSnapshot_0.int_6 <= 0)
					{
						characterSyncSnapshot_0.bool_0 = true;
						num5++;
						if (num5 < 3)
						{
							continue;
						}
					}
					num2 = characterSyncSnapshot_0.int_6;
					smethod_4(array[num2].Replace("XXX", characterAccountConfig_.string_22));
				}
				num5 = 0;
				characterSyncSnapshot_0.int_0 = characterAccountConfig_.int_136;
				characterSyncSnapshot_0.int_1 = characterAccountConfig_.int_137;
				characterSyncSnapshot_0.process_0 = characterAccountConfig_.process_0;
				characterSyncSnapshot_0.uint_0 = characterAccountConfig_.uint_4;
				characterSyncSnapshot_0.uint_2 = Class24.smethod_30(num11, characterAccountConfig_.int_137);
				if (Form1.int_10 <= 0 && Form1.int_11 <= 0)
				{
					characterSyncSnapshot_0.uint_5 = Class89.smethod_6(characterAccountConfig_);
				}
				else
				{
					characterSyncSnapshot_0.uint_5 = characterSyncSnapshot_1.uint_5;
					characterSyncSnapshot_0.int_7 = characterSyncSnapshot_1.int_7;
				}
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_43.uint_0, array2, 4, ref int_);
				characterSyncSnapshot_0.int_3 = BitConverter.ToInt32(array2, 0);
				if ((Form1.int_10 > 0 || Form1.int_11 > 0) && characterSyncSnapshot_1.int_4 > 0)
				{
					characterSyncSnapshot_0.int_2 = characterSyncSnapshot_1.int_2;
				}
				else
				{
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_56.uint_0, array2, 4, ref int_);
					characterSyncSnapshot_0.int_2 = BitConverter.ToInt32(array2, 0);
				}
				characterSyncSnapshot_0.long_0 = Class11.smethod_27();
				if (characterSyncSnapshot_0.uint_4 == null)
				{
					characterSyncSnapshot_0.uint_4 = new uint[2];
				}
				characterSyncSnapshot_0.uint_4[0] = num13;
				characterSyncSnapshot_0.uint_4[1] = num14;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_54.uint_0, array2, 4, ref int_);
				characterSyncSnapshot_0.int_5 = BitConverter.ToInt32(array2, 0);
				characterSyncSnapshot_0.string_0 = Class24.smethod_28(num11 + Class56.memorySignatureScanConfig_16.uint_0, characterAccountConfig_.int_137, 32);
				if (num12 != characterSyncSnapshot_0.int_4)
				{
					characterSyncSnapshot_0.int_4 = num12;
					smethod_3();
				}
				characterSyncSnapshot_0.bool_0 = num10 == 0 || characterSyncSnapshot_0.int_6 == 0 || characterSyncSnapshot_0.int_4 == 0 || characterSyncSnapshot_0.string_0 == string.Empty || characterSyncSnapshot_0.string_1 == string.Empty;
				if (characterSyncSnapshot_0.int_4 != 162)
				{
					if (characterSyncSnapshot_0.int_4 != 321)
					{
						characterSyncSnapshot_0.string_1 = Class24.smethod_28(characterAccountConfig_.uint_7 + Class56.memorySignatureScanConfig_28.uint_0 + Class56.memorySignatureScanConfig_29.uint_0, characterAccountConfig_.int_137, 48);
					}
					else
					{
						characterSyncSnapshot_0.string_1 = "Tr\u00adêng B¹ch s¬n Nam";
					}
				}
				else
				{
					characterSyncSnapshot_0.string_1 = "§¹i Lý";
				}
				uint uint_ = 0u;
				if (characterSyncSnapshot_0.int_3 > 0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + Class56.memorySignatureScanConfig_72.uint_0, array2, 4, ref int_);
					uint num15 = BitConverter.ToUInt32(array2, 0);
					if ((int)num15 > 0)
					{
						uint num16 = num10 + num15 * Class56.memorySignatureScanConfig_15.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num16 + Class56.memorySignatureScanConfig_50.uint_0, array2, 4, ref int_);
						if (BitConverter.ToUInt32(array2, 0) != 0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num16 + Class56.memorySignatureScanConfig_52.uint_0, array2, 4, ref int_);
							uint num17 = BitConverter.ToUInt32(array2, 0);
							if (num17 <= 1)
							{
								uint_ = Class24.smethod_30(num16, characterAccountConfig_.int_137);
							}
						}
					}
					num15 = 0u;
				}
				characterSyncSnapshot_0.uint_3 = uint_;
			}
			else
			{
				if (Class81.characterAccountConfig_0.int_136 > 0)
				{
					characterSyncSnapshot_0.uint_5 = Class89.smethod_6(Class81.characterAccountConfig_0);
					uint[] array3 = Class38.smethod_30(Class81.characterAccountConfig_0);
					if (array3 != null)
					{
						characterSyncSnapshot_0.uint_4 = new uint[2]
						{
							array3[0],
							array3[1]
						};
					}
				}
				characterSyncSnapshot_0.int_0 = 0;
				characterSyncSnapshot_0.uint_2 = 0u;
				characterSyncSnapshot_0.uint_3 = 0u;
				characterSyncSnapshot_0.int_4 = 0;
				characterSyncSnapshot_0.bool_0 = false;
				num = -1;
			}
			Class24.WriteProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_4 * 4, byte_, 1, ref int_);
			Class24.WriteProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_5 * 4, byte_2, 2, ref int_);
		}
	}

	private static uint[] smethod_2()
	{
		if (Form1.characterAccountConfig_1 != null && Form1.characterAccountConfig_1.Length != 0)
		{
			uint[] array = new uint[Form1.characterAccountConfig_1.Length];
			for (int i = 0; i < array.Length; i++)
			{
				CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[i];
				uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.int_137);
				uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig.int_137);
				uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig.int_137);
				uint uint_ = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
				array[i] = Class24.smethod_30(uint_, characterAccountConfig.int_137);
			}
			return array;
		}
		return null;
	}

	private static void smethod_3()
	{
		try
		{
			if (Form1.characterAccountConfig_1 == null)
			{
				return;
			}
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				if (Form1.characterAccountConfig_1[i].int_136 != characterSyncSnapshot_0.int_0)
				{
					Class75.smethod_2(Form1.characterAccountConfig_1[i], Class75.uint_17, 1, 4);
				}
			}
		}
		catch
		{
		}
	}

	private static void smethod_4(string string_0)
	{
		if (Form1.int_71 > 0 || Form1.characterAccountConfig_1 == null)
		{
			return;
		}
		try
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				int num = 0;
				while (Form1.characterAccountConfig_1[i].bool_2 && num < 30)
				{
					Thread.Sleep(10);
					num++;
				}
				if (!Form1.characterAccountConfig_1[i].bool_2)
				{
					Class75.smethod_52(Form1.characterAccountConfig_1[i], string_0);
				}
			}
		}
		catch
		{
		}
	}

	public static int smethod_5(uint uint_1, ref uint[] uint_2, ref uint uint_3)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterSyncSnapshot_0.int_1);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterSyncSnapshot_0.int_1) * Class56.memorySignatureScanConfig_15.uint_0;
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterSyncSnapshot_0.int_1);
		uint num4 = num3 + num2;
		uint num5 = num3 + uint_3 * Class56.memorySignatureScanConfig_15.uint_0;
		uint num6 = Class24.smethod_30(num5, characterSyncSnapshot_0.int_1);
		uint num7 = Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterSyncSnapshot_0.int_1);
		uint num8 = Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterSyncSnapshot_0.int_1);
		if (num7 != 0 && num8 != 0)
		{
			if (characterSyncSnapshot_0.uint_4 == null)
			{
				characterSyncSnapshot_0.uint_4 = new uint[2];
			}
			characterSyncSnapshot_0.uint_4[0] = num7;
			characterSyncSnapshot_0.uint_4[1] = num8;
			if (num6 != uint_1)
			{
				int int_ = 0;
				byte[] array = new byte[4];
				uint num9 = characterSyncSnapshot_0.uint_1;
				if (num9 == 0)
				{
					num9 = 4194304u;
				}
				uint uint_4 = num9 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
				Class24.ReadProcessMemory(characterSyncSnapshot_0.int_1, uint_4, array, 4, ref int_);
				if (int_ != 4)
				{
					return 0;
				}
				int num10 = BitConverter.ToInt32(array, 0);
				if (num10 <= 1)
				{
					return 0;
				}
				int num11 = (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterSyncSnapshot_0.int_1);
				int num12 = 0;
				uint_3 = 0u;
				for (uint num13 = 1u; num13 < 256; num13++)
				{
					if (num13 % 50 == 0)
					{
						Thread.Sleep(10);
					}
					if (num10 <= num12)
					{
						break;
					}
					if (num13 == num11)
					{
						num12++;
						continue;
					}
					num5 = num3 + num13 * Class56.memorySignatureScanConfig_15.uint_0;
					Class24.ReadProcessMemory(characterSyncSnapshot_0.int_1, num5 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_);
					if (array[0] == 0 || int_ != 4)
					{
						continue;
					}
					num12++;
					Class24.ReadProcessMemory(characterSyncSnapshot_0.int_1, num5 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
					if (int_ == 4 && BitConverter.ToInt32(array, 0) > 0)
					{
						num6 = Class24.smethod_30(num5, characterSyncSnapshot_0.int_1);
						if (uint_1 == num6)
						{
							uint_3 = num13;
							break;
						}
					}
				}
				if (uint_3 == 0)
				{
					return -1;
				}
			}
			long num14 = Class64.smethod_18(uint_2, characterSyncSnapshot_0.uint_4);
			uint_2 = new uint[2]
			{
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterSyncSnapshot_0.int_1),
				Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterSyncSnapshot_0.int_1)
			};
			long num15 = Class64.smethod_18(uint_2, characterSyncSnapshot_0.uint_4);
			int num16 = Form1.int_27;
			if (num16 < 200)
			{
				num16 = 200;
			}
			if (num15 - num14 > 22500L && num16 * num16 <= num15 && num15 <= 1000000L)
			{
				return 1;
			}
			return 0;
		}
		return 0;
	}

	public static void smethod_6(CharacterAccountConfig characterAccountConfig_0, uint[] uint_1, uint[] uint_2, bool bool_2 = false)
	{
		if (uint_2 != null && uint_2[0] != 0 && uint_2[1] != 0)
		{
			bool flag = uint_1 != null && uint_1[0] != 0 && uint_1[1] != 0;
			long num = Class64.smethod_18(uint_1, uint_2);
			if (flag && (bool_2 || num < 14400L))
			{
				uint[] uint_3 = Class64.smethod_5(uint_1, uint_2, -150);
				Class75.smethod_61(characterAccountConfig_0, uint_3);
			}
			else
			{
				Class75.smethod_61(characterAccountConfig_0, uint_2);
			}
			Thread.Sleep(60);
		}
	}

	public static bool smethod_7(CharacterAccountConfig characterAccountConfig_0, ref int int_1)
	{
		if (Class81.characterAccountConfig_0.int_136 == characterAccountConfig_0.int_136)
		{
			if (Form1.int_69 > 0)
			{
				return 48 < characterSyncSnapshot_0.int_7 && characterSyncSnapshot_0.int_7 < 58;
			}
			int num = Class89.smethod_3(characterAccountConfig_0);
			bool result = int_1 != num;
			int_1 = num;
			return result;
		}
		return false;
	}

	public static void smethod_8(int int_1)
	{
		if (Form1.characterAccountConfig_1 == null)
		{
			return;
		}
		for (int i = 0; Form1.characterAccountConfig_1.Length > i; i++)
		{
			if (!Form1.characterAccountConfig_1[i].bool_25)
			{
				continue;
			}
			switch (int_1)
			{
			case 1:
			case 2:
				Form1.characterAccountConfig_1[i].int_76[4] = int_1;
				continue;
			case 3:
			case 4:
				Form1.int_111 = int_1;
				Form1.characterAccountConfig_1[i].bool_55 = Form1.characterAccountConfig_1[i].bool_25;
				continue;
			case 5:
				new Thread(FormClickNPC.smethod_1).Start();
				continue;
			}
			if (100 <= int_1 && int_1 <= 102)
			{
				Form1.int_111 = int_1 - 100;
				Class11.smethod_38(ref Class43.int_0, Form1.characterAccountConfig_1[i].int_136);
				if (!Class43.bool_0)
				{
					Class43.smethod_0();
				}
				continue;
			}
			switch (int_1)
			{
			case 104:
			{
				for (int j = 0; j < 100; j++)
				{
					if (int_0 <= 0)
					{
						break;
					}
					Thread.Sleep(1);
				}
				int_0 = Form1.characterAccountConfig_1[i].int_136;
				new Thread(smethod_9).Start();
				break;
			}
			case 103:
			{
				int int_2 = 0;
				byte[] byte_ = new byte[1] { Convert.ToByte(Form1.characterAccountConfig_1[i].bool_25) };
				Class24.WriteProcessMemory(Form1.characterAccountConfig_1[i].int_137, Form1.characterAccountConfig_1[i].uint_16 + Class75.uint_33 * 4, byte_, 1, ref int_2);
				break;
			}
			}
		}
	}

	private static void smethod_9()
	{
		int num = int_0;
		int_0 = 0;
		int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, num);
		if (0 <= num2)
		{
			Class64.smethod_14(Form1.characterAccountConfig_1[num2]);
		}
	}
}
