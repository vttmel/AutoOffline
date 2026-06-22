using System;
using System.Threading;
using ns1;
using ns10;
using ns100;
using ns11;
using ns13;
using ns23;
using ns3;
using ns35;
using ns41;
using ns42;
using ns44;
using ns53;
using ns61;
using ns71;
using ns83;
using ns85;

namespace ns91;

internal class Class98
{
	private static uint[,] uint_0;

	static Class98()
	{
		uint[,] array_ = new uint[4, 2];
		Class10.smethod_4(array_, 374782);
		uint_0 = array_;
	}

	public static int smethod_0(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = false, uint[] uint_1 = null)
	{
		int int_ = characterAccountConfig_0.int_136;
		int result = 0;
		int num = 0;
		uint num2 = 0u;
		long long_ = 0L;
		bool flag = false;
		Class64.smethod_10(characterAccountConfig_0, "Luu ruong...");
		string string_ = "R\u00ad¬ng chøa|R\u00ad¬ng ®å|R\u00ad¬ng §å|chøa ®å|chøa §å|B¶o r\u00ad¬ng";
		while (true)
		{
			IL_0b68:
			Thread.Sleep(300);
			int num3 = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
			if (Class11.bool_0 || num3 < 0 || Class24.smethod_52(Form1.characterAccountConfig_1[num3].process_0) || !Form1.characterAccountConfig_1[num3].bool_25)
			{
				break;
			}
			characterAccountConfig_0 = Form1.characterAccountConfig_1[num3];
			uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num5 = Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
			uint num6 = num5 * Class56.memorySignatureScanConfig_15.uint_0;
			uint num7 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num8 = num7 + num6;
			int num9 = (int)Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
			int num10 = (int)Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
			int num11 = (int)Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
			int num13;
			if (num11 <= 0)
			{
				int num12 = Class89.smethod_39(characterAccountConfig_0);
				if (num10 != 0 && num9 != 0 && num9 != 10 && num9 != 21 && num12 > 1)
				{
					uint[] array = new uint[2]
					{
						Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					if (array[0] == 0 || array[1] == 0)
					{
						continue;
					}
					num13 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
					string string_2 = "R\u00ad¬ng chøa ®å";
					if (num13 == 999)
					{
						string_2 = "R\u00ad¬ng";
					}
					int[] array2 = Class64.smethod_9(num13);
					if (array2 == null)
					{
						flag = true;
						uint_1 = Class45.smethod_11(array, num13, string_2);
						if (uint_1 == null)
						{
							int num14 = Class3.smethod_13(characterAccountConfig_0, string_);
							if (num14 <= 0)
							{
								goto IL_03d1;
							}
							uint_1 = Class3.smethod_19(characterAccountConfig_0, num14);
						}
					}
					if (uint_1 == null)
					{
						uint_1 = Class45.smethod_11(array, num13, string_2);
						if (uint_1 == null)
						{
							int num15 = Class3.smethod_13(characterAccountConfig_0, string_);
							if (num15 <= 0)
							{
								goto IL_03d1;
							}
							uint_1 = Class3.smethod_19(characterAccountConfig_0, num15);
						}
					}
					long num16 = Class64.smethod_18(array, uint_1);
					if (num16 > 90000L)
					{
						Class64.smethod_29(characterAccountConfig_0, bool_0: false);
						uint[,] array3 = null;
						array3 = ((num13 == 341) ? uint_0 : Class44.smethod_1(num13, array, uint_1, "RUONGDO"));
						if (array3 != null)
						{
							int num17 = 0;
							while (num17 < 3)
							{
								array = new uint[2]
								{
									Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
									Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
								};
								Class13.smethod_2(characterAccountConfig_0, bool_0: false);
								if (Class64.smethod_22(characterAccountConfig_0, array3, array, uint_1, num13, bool_0: true, 15000, num13 == 333) > 0)
								{
									break;
								}
								int num18 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
								if (num18 != num13)
								{
									goto IL_0b68;
								}
								num11 = (int)Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
								if (num11 <= 0)
								{
									num17++;
									continue;
								}
								goto IL_0b8b;
							}
						}
					}
					goto IL_03d1;
				}
				result = -6;
			}
			else
			{
				result = -5;
			}
			goto IL_0bad;
			IL_0bad:
			Class75.smethod_52(characterAccountConfig_0, "Ket thuc luu ruong !");
			if (Class47.smethod_8(characterAccountConfig_0) && bool_0)
			{
				Class24.smethod_4(characterAccountConfig_0.uint_4, 27u);
			}
			return result;
			IL_0b53:
			Class64.smethod_12(characterAccountConfig_0);
			num++;
			if (num <= 3)
			{
				continue;
			}
			result = 1;
			goto IL_0bad;
			IL_0b8b:
			result = -5;
			goto IL_0bad;
			IL_03d1:
			if (uint_1 != null)
			{
				uint[] array4 = new uint[2]
				{
					Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
				long num19 = Class64.smethod_18(array4, uint_1);
				if (num19 > 90000L)
				{
					Class64.smethod_29(characterAccountConfig_0, bool_0: false);
					num9 = (int)Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
					if (!Class13.smethod_3(characterAccountConfig_0) || Class11.smethod_28(long_) > 6000L)
					{
						Class13.smethod_1(characterAccountConfig_0, uint_1);
						long_ = Class11.smethod_27();
					}
					continue;
				}
				Class13.smethod_2(characterAccountConfig_0, bool_0: false);
				for (int i = 0; i < 10; i++)
				{
					array4 = new uint[2]
					{
						Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					if (Class64.smethod_18(array4, uint_1) < 12500L)
					{
						break;
					}
					Class75.smethod_61(characterAccountConfig_0, uint_1);
					Thread.Sleep(300);
				}
			}
			num2 = 0u;
			int int_2 = 0;
			int int_3 = 15;
			int num20 = 0;
			byte[] array5 = new byte[15];
			byte[] array6 = new byte[4];
			uint[] array7 = null;
			uint uint_2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_124.uint_0 + Class56.memorySignatureScanConfig_125.uint_0 + 4;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_2, array6, 4, ref int_2);
			int num21 = BitConverter.ToInt32(array6, 0);
			if (num21 > 0 && num13 != 999)
			{
				int num22 = 0;
				uint num23 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
				for (uint num24 = 1u; num24 < 256; num24++)
				{
					if (!Class11.bool_0)
					{
						if (num21 <= num22 && num20 > 5)
						{
							break;
						}
						uint num25 = num23 + num24 * Class56.memorySignatureScanConfig_127.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num25, array6, 4, ref int_2);
						int num26 = BitConverter.ToInt32(array6, 0);
						if (num26 <= 0)
						{
							num20++;
							continue;
						}
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num25 + Class56.memorySignatureScanConfig_138.uint_0, array5, 1, ref int_2);
						if (array5[0] != 0)
						{
							num20 = 0;
							num22++;
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num25 + Class56.memorySignatureScanConfig_138.uint_0, array5, int_3, ref int_2);
							string string_3 = Class1.smethod_3(array5);
							if (0 > Class11.smethod_1(string_3, "r\u00ad¬ng") || Class11.smethod_1(string_3, "Tr\u00ad¬ng") >= 0)
							{
								continue;
							}
							num2 = num24;
							array7 = new uint[2]
							{
								Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_133.uint_0, characterAccountConfig_0.int_137),
								Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_134.uint_0, characterAccountConfig_0.int_137)
							};
							byte[] array8 = new byte[4];
							Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num25 + Class56.memorySignatureScanConfig_133.uint_0, array8, 4, ref int_2);
							Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num25 + Class56.memorySignatureScanConfig_134.uint_0, array8, 4, ref int_2);
							Class89.smethod_34(characterAccountConfig_0, 1);
							int num27 = 0;
							uint num28 = 0u;
							uint num29 = 0u;
							while (num27 < 10)
							{
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num25 + Class56.memorySignatureScanConfig_133.uint_0, array8, 4, ref int_2);
								num28 = BitConverter.ToUInt32(array8, 0);
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num25 + Class56.memorySignatureScanConfig_134.uint_0, array8, 4, ref int_2);
								num29 = BitConverter.ToUInt32(array8, 0);
								if (num28 == 0 || num29 == 0)
								{
									num27++;
									Thread.Sleep(100);
									continue;
								}
								array7 = new uint[2] { num28, num29 };
								break;
							}
							Class89.smethod_34(characterAccountConfig_0);
							break;
						}
						num20++;
						continue;
					}
					return 0;
				}
			}
			bool flag2 = false;
			if (num2 == 0)
			{
				if (!flag)
				{
					result = -1;
					goto IL_0bad;
				}
				int num30 = -1;
				long num31 = 0L;
				string empty = string.Empty;
				uint[] array9 = null;
				int int_4 = 0;
				byte[] array10 = new byte[4];
				uint_2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_2, array10, 4, ref int_4);
				int num32 = BitConverter.ToInt32(array10, 0);
				int num33 = 0;
				for (uint num34 = 1u; num34 < 256; num34++)
				{
					if (num32 <= num33)
					{
						break;
					}
					if (num34 != num5)
					{
						uint num35 = num7 + num34 * Class56.memorySignatureScanConfig_15.uint_0;
						uint uint_3 = num35 + Class56.memorySignatureScanConfig_16.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_3, array10, 4, ref int_4);
						if (array10[0] == 0)
						{
							continue;
						}
						num33++;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num35 + Class56.memorySignatureScanConfig_50.uint_0, array10, 4, ref int_4);
						if (BitConverter.ToInt32(array10, 0) > 0)
						{
							uint num36 = Class24.smethod_30(num35 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137);
							if (num36 == 3)
							{
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_3, array5, int_3, ref int_2);
								empty = Class1.smethod_3(array5).ToLower();
								uint[] array11 = new uint[2]
								{
									Class24.smethod_30(num35 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
									Class24.smethod_30(num35 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
								};
								if ((0 <= Class11.smethod_1(empty, "r\u00ad¬ng") && Class11.smethod_1(empty, "Tr\u00ad¬ng") < 0) || 0 <= Class11.smethod_1(empty, "hñ kh"))
								{
									num2 = num34;
									array7 = new uint[2]
									{
										array11[0],
										array11[1]
									};
									flag2 = true;
									break;
								}
								long num37 = Class64.smethod_18(uint_1, array11);
								if (num37 <= 40000L && (num30 < 0 || num37 < num31))
								{
									num30 = (int)num34;
									num31 = num37;
									array9 = new uint[2]
									{
										array11[0],
										array11[1]
									};
								}
							}
						}
						else
						{
							num20++;
						}
					}
					else
					{
						num33++;
					}
				}
				if (num2 == 0)
				{
					if (num30 <= 0)
					{
						result = 1;
						goto IL_0bad;
					}
					num2 = (uint)num30;
					array7 = new uint[2]
					{
						array9[0],
						array9[1]
					};
					flag2 = true;
				}
			}
			int num38 = 0;
			while (!Class11.bool_0)
			{
				if (!Class47.smethod_8(characterAccountConfig_0))
				{
					uint[] array12 = new uint[2]
					{
						Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					if (Class64.smethod_18(array12, array7) > 11500L)
					{
						Class75.smethod_61(characterAccountConfig_0, array7);
						Thread.Sleep(300);
					}
					if (!flag2)
					{
						Class75.smethod_48(characterAccountConfig_0, num2);
					}
					else
					{
						Class38.smethod_10(characterAccountConfig_0, num2);
					}
					Thread.Sleep(300);
					num38++;
					if (num38 % 10 != 0)
					{
						continue;
					}
					goto IL_0b53;
				}
				result = 1;
				break;
			}
			goto IL_0bad;
		}
		return 0;
	}
}
