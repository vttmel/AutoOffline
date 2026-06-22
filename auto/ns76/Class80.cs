using System;
using System.Threading;
using ns1;
using ns100;
using ns103;
using ns11;
using ns121;
using ns124;
using ns13;
using ns14;
using ns146;
using ns23;
using ns27;
using ns28;
using ns31;
using ns35;
using ns36;
using ns43;
using ns48;
using ns5;
using ns51;
using ns53;
using ns54;
using ns56;
using ns57;
using ns59;
using ns60;
using ns61;
using ns62;
using ns64;
using ns66;
using ns67;
using ns68;
using ns71;
using ns72;
using ns79;
using ns8;
using ns81;
using ns82;
using ns83;
using ns85;
using ns87;
using ns88;
using ns90;
using ns93;
using ns95;

namespace ns76;

internal class Class80
{
	public static int int_0 = 0;

	public static int[] int_1 = null;

	private static int int_2 = 0;

	private static int int_3 = 0;

	private static int int_4 = 0;

	public static void smethod_0()
	{
		while (true)
		{
			Thread.Sleep(300);
			if (Class11.bool_0)
			{
				break;
			}
			if (Form1.bool_16 && !Form1.bool_14 && Form1.int_7 <= Form1.int_6 && Class11.int_1 > 0 && Class11.uint_1 != 0 && int_1 != null && int_2 <= 0 && int_3 <= 0 && Class100.int_0 <= 0 && Class54.int_0 <= 0 && Class63.int_0 <= 0 && Class62.int_1 <= 0 && Class8.int_0 <= 0 && Class8.int_1 <= 0 && Class32.int_2 <= 0 && Class32.int_0 <= 0 && Class32.int_1 <= 0 && Class32.int_3 <= 0 && Class97.int_2 <= 0)
			{
				try
				{
					int num = int_1[0];
					Class11.smethod_39(ref int_1, num);
					int_2 = num;
					int_3 = num;
					Class63.int_0 = num;
					Class62.int_1 = num;
					Class8.int_0 = num;
					Class8.int_1 = num;
					Class100.int_0 = num;
					Class32.int_1 = num;
					Class32.int_0 = num;
					Class32.int_2 = num;
					Class32.int_3 = num;
					Class54.int_0 = num;
					Class97.int_2 = num;
					new Thread(smethod_2).Start();
					new Thread(smethod_1).Start();
					new Thread(Class100.smethod_0).Start();
					new Thread(Class54.smethod_0).Start();
					new Thread(Class63.smethod_0).Start();
					new Thread(Class62.smethod_1).Start();
					new Thread(Class8.smethod_0).Start();
					new Thread(Class8.smethod_2).Start();
					new Thread(Class32.smethod_19).Start();
					new Thread(Class32.smethod_3).Start();
					new Thread(Class32.smethod_1).Start();
					new Thread(Class32.smethod_21).Start();
					new Thread(Class97.smethod_2).Start();
				}
				catch
				{
				}
			}
		}
	}

	private static void smethod_1()
	{
		int num = int_3;
		int_3 = 0;
		int num2 = 0;
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		bool flag = false;
		int num3 = 0;
		while (true)
		{
			try
			{
				num2 = Class87.smethod_3(Form1.characterAccountConfig_1, num);
				if (Class11.bool_0 || num2 < 0 || !Form1.characterAccountConfig_1[num2].bool_25)
				{
					if (0 <= num2)
					{
						Form1.characterAccountConfig_1[num2].bool_28 = false;
					}
					break;
				}
				if (num3 > 0)
				{
					Class56.smethod_13(Form1.characterAccountConfig_1[num2]);
					num3 = 0;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num2].bool_28)
					{
						break;
					}
					Form1.characterAccountConfig_1[num2].bool_28 = true;
					flag = true;
				}
				Form1.characterAccountConfig_1[num2].gstruct49_0.int_0 = 0;
				characterAccountConfig = Form1.characterAccountConfig_1[num2];
				if (characterAccountConfig.bool_2)
				{
					Thread.Sleep(100);
				}
				else
				{
					if (Form1.int_71 == 0)
					{
						Class75.smethod_52(characterAccountConfig, "-------------------------------------------");
						Class75.smethod_52(characterAccountConfig, "<color=yellow>" + Form1.string_49.ToUpper() + " FOR PRIVATE GAME");
					}
					if (characterAccountConfig.int_20[0] > 0 && Form1.int_71 == 0)
					{
						if (characterAccountConfig.int_20[1] <= 0)
						{
							Class75.smethod_52(characterAccountConfig, "<bclr=blue><color=green>CHAY TIN SU THIEN BAO KHO");
							Class69.smethod_7(num);
						}
						else
						{
							Class75.smethod_52(characterAccountConfig, "<bclr=blue><color=green>CHAY TIN SU PHONG KY");
							Class69.smethod_0(num);
						}
						num3 = 1;
						Thread.Sleep(1000);
					}
					else if (characterAccountConfig.int_133[0] <= 0)
					{
						if (characterAccountConfig.bool_54)
						{
							if (Form1.int_71 == 0)
							{
								Class75.smethod_52(characterAccountConfig, "<bclr=blue><color=green>VAN SU THONG");
							}
							Class76.smethod_0(num);
						}
						else if (!characterAccountConfig.bool_55)
						{
							if (characterAccountConfig.int_25 <= 0)
							{
								if (Form1.int_24 == 0)
								{
									if (Form1.int_71 == 0)
									{
										Class75.smethod_52(characterAccountConfig, "<bclr=blue><color=green>WAR (PK -SAN BOSS)");
									}
									Class57.smethod_0(num);
								}
								else if (Form1.int_24 != 1)
								{
									if (Form1.int_24 == 2)
									{
										if (Form1.int_71 == 0)
										{
											Class75.smethod_52(characterAccountConfig, "<bclr=blue><color=green>CHIEN TRUONG CONG THANH CHIEN");
										}
										Class86.smethod_0(num);
									}
									if (Form1.int_24 == 3)
									{
										if (Form1.int_71 == 0)
										{
											Class75.smethod_52(characterAccountConfig, "<bclr=blue><color=green>CHE DO DON DAU");
											Class75.smethod_52(characterAccountConfig, "<bclr=blue><color=green>ChÕ ®é nµy chØ ®\u00b8nh vµ b¬m m\u00b8u");
										}
										Class67.smethod_0(num);
									}
								}
								else
								{
									if (Form1.int_71 == 0)
									{
										Class75.smethod_52(characterAccountConfig, "<bclr=blue><color=green>TONG KIM - PHONG HOA LIEN THANH");
									}
									Class65.smethod_0(num);
								}
							}
							else
							{
								Class75.smethod_52(characterAccountConfig, "<bclr=blue><color=green>T-R-A-I-N-(" + Class39.smethod_1(characterAccountConfig.int_32) + ")");
								Class60.smethod_0(num);
							}
						}
						else
						{
							if (Form1.int_71 == 0)
							{
								Class75.smethod_52(characterAccountConfig, "<bclr=blue><color=green>LEN VI SON DAO");
							}
							Class94.smethod_0(num);
						}
					}
					else
					{
						if (Form1.int_71 == 0)
						{
							Class75.smethod_52(characterAccountConfig, "<bclr=blue><color=green>SAN BOSS SAT THU");
						}
						Class5.smethod_0(num);
						num3 = 1;
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_2()
	{
		int int_ = int_2;
		int_2 = 0;
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
						Form1.characterAccountConfig_1[num].bool_27 = false;
						CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
						Class75.smethod_52(characterAccountConfig_, "-------------------------------------------");
						Class75.smethod_52(characterAccountConfig_, "<color=yellow>" + Form1.string_49.ToUpper() + " FOR PRIVATE GAME");
						Class75.smethod_52(characterAccountConfig_, "<color=green>§\u00adîc viÕt bëi: AnDzai");
						Class75.smethod_52(characterAccountConfig_, "<color=green>Webs:  ");
						Class75.smethod_52(characterAccountConfig_, "-------------------------------------------");
						Class75.smethod_52(characterAccountConfig_, "KET THUC AUTO.");
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_27)
					{
						break;
					}
					flag = true;
					Form1.characterAccountConfig_1[num].bool_27 = true;
					Class11.smethod_29(ref Class11.string_17, "[" + Class1.smethod_1(Form1.characterAccountConfig_1[num].string_22, 1) + "] đang chạy.");
				}
				smethod_3(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_3(int int_5)
	{
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		int int_6 = 0;
		byte[] byte_ = new byte[4];
		byte[] array = new byte[4];
		byte[] array2 = new byte[1];
		long num = -1L;
		long long_ = 0L;
		long num2 = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		long long_4 = 0L;
		long long_5 = 0L;
		long long_6 = 0L;
		long long_7 = 0L;
		long long_8 = 0L;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		int num3 = 0;
		int num4 = 0;
		int num5 = -1;
		int num6 = -1;
		int num7 = 0;
		int num8 = -1;
		int num9 = -1;
		int num10 = 0;
		int num11 = 0;
		long[] array3 = new long[3];
		long[] array4 = array3;
		long long_9 = 0L;
		bool flag6 = false;
		int num12 = 0;
		int num13 = 0;
		int[] array5 = new int[10];
		for (int i = 0; i < array5.Length; i++)
		{
			array5[i] = 4;
		}
		Random random = new Random();
		int num14 = 0;
		int num15 = random.Next(100, 600);
		int num16 = random.Next(3000, 9000);
		long long_10 = Class11.smethod_27();
		while (true)
		{
			Thread.Sleep(200);
			int num17 = Class87.smethod_3(Form1.characterAccountConfig_1, int_5);
			if (Class11.bool_0 || num17 < 0 || !Form1.characterAccountConfig_1[num17].bool_25)
			{
				break;
			}
			if (flag2)
			{
				Form1.characterAccountConfig_1[num17].gstruct45_0 = characterAccountConfig_.gstruct45_0;
				flag2 = false;
			}
			characterAccountConfig_ = Form1.characterAccountConfig_1[num17];
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref array5[0]);
			uint num18 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref array5[1]);
			uint num19 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref array5[2]);
			uint num20 = BitConverter.ToUInt32(array, 0);
			uint num21 = num20 + num19 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref array5[3]);
			int num22 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref array5[4]);
			int num23 = BitConverter.ToInt32(array, 0);
			if (num23 > 0 && num22 > 0 && Class11.smethod_28(long_2) > num3)
			{
				if (GClass1.string_4 == null || GClass1.string_4 == string.Empty || (!flag && (Form1.bool_14 || Form1.int_7 > Form1.int_6)))
				{
					num17 = Class87.smethod_3(Form1.characterAccountConfig_1, int_5);
					if (0 <= num17)
					{
						Form1.characterAccountConfig_1[num17].bool_25 = false;
					}
					Class75.smethod_52(characterAccountConfig_, Class1.smethod_2(Class11.smethod_0(Class11.char_35)));
					break;
				}
				int num24 = GClass1.smethod_5(characterAccountConfig_);
				if (num24 > 0)
				{
					if (!flag)
					{
						if (Form1.int_71 != 0)
						{
							Class75.smethod_52(characterAccountConfig_, ">>");
						}
						else
						{
							Class75.smethod_52(characterAccountConfig_, Class11.string_16);
						}
						if (Form1.int_21 > 0 || Form1.int_10 > 0 || Form1.int_11 > 0)
						{
							Class75.smethod_14(characterAccountConfig_, Form1.int_22 > 0);
						}
					}
					num3 = 180000;
					if (num24 > 1 && GClass1.gstruct15_0.uint_1 != null)
					{
						TcpConnectionEntry[] array6 = Class51.smethod_0(new int[1] { characterAccountConfig_.int_136 });
						if (array6 == null)
						{
							num3 = 3000;
						}
						else
						{
							int num25 = 0;
							string text = string.Empty;
							int num26 = 0;
							while (true)
							{
								if (num26 < array6.Length)
								{
									string string_ = array6[num26].string_2;
									if (string_ != null && !(string_ == string.Empty))
									{
										uint num27 = Class11.smethod_6(string_.Replace(" ", string.Empty));
										if (num27 != 0)
										{
											for (int j = 0; j < GClass1.gstruct15_0.uint_1.Length; j++)
											{
												if (num27 == GClass1.gstruct15_0.uint_1[j])
												{
													goto end_IL_043d;
												}
											}
											if (text != string.Empty && text != null)
											{
												text += ",";
											}
											text += string_;
											num25++;
										}
									}
									num26++;
									continue;
								}
								if (num25 <= 0)
								{
									break;
								}
								num17 = Class87.smethod_3(Form1.characterAccountConfig_1, int_5);
								if (0 <= num17)
								{
									Form1.characterAccountConfig_1[num17].bool_25 = false;
								}
								Class75.smethod_52(characterAccountConfig_, Class11.smethod_0(Class11.char_38).Replace("me kh", "me (" + text + ") kh").Replace("héi,", "(" + Form1.string_15 + "),"));
								return;
								continue;
								end_IL_043d:
								break;
							}
						}
					}
					num4 = 0;
					flag = true;
				}
				else
				{
					if ((!flag && num4 > 1) || num4 > 3)
					{
						num17 = Class87.smethod_3(Form1.characterAccountConfig_1, int_5);
						if (0 <= num17)
						{
							Form1.characterAccountConfig_1[num17].bool_25 = false;
						}
						if (num24 == -10)
						{
							Class75.smethod_52(characterAccountConfig_, "<color=white>[TBTkeoxe]: Ngµy giê cña m\u00b8y tÝnh bÞ sai, h·y ®iÒu chØnh l¹i míi sö dông ®\u00adîc auto.");
						}
						else if (num24 < 0)
						{
							Class75.smethod_52(characterAccountConfig_, "<color=white>[TBTkeoxe]: <color=yellow>LIC ®\u00a8ng ký cã m· x\u00b8c thùc kh«ng ®óng,Vui lßng kiÓm tra l¹i Bang héi , Server,HoÆc liªn hÖ admin ®Ó ®\u00adîc hç trî.");
						}
						else
						{
							Class75.smethod_52(characterAccountConfig_, "<color=white>[TBTkeoxe]: <color=yellow>Ch\u00ada ®\u00a8ng ký sö dông nªn kh«ng thÓ dïng ®\u00adîc,Vui lßng kiÓm tra l¹i Bang héi , Server,HoÆc liªn hÖ admin ®Ó ®\u00adîc hç trî.");
						}
						break;
					}
					num4++;
					num3 = 3000;
				}
				long_2 = Class11.smethod_27();
			}
			if (AuxiliaryMachineManager.string_2 != null && AuxiliaryMachineManager.string_2 != string.Empty && Class11.smethod_28(long_10) > num16)
			{
				int num28 = 0;
				if (0 <= AuxiliaryMachineManager.string_2.IndexOf("="))
				{
					string[] array7 = AuxiliaryMachineManager.string_2.Split('=');
					AuxiliaryMachineManager.string_2 = array7[0];
					num28 = Class11.smethod_11(array7[1]);
				}
				if (0 <= AuxiliaryMachineManager.string_2.IndexOf(",?"))
				{
					string string_2 = Class24.smethod_28(num21 + Class56.memorySignatureScanConfig_16.uint_0, characterAccountConfig_.int_137);
					uint num29 = Class11.smethod_6(string_2);
					AuxiliaryMachineManager.string_2 = AuxiliaryMachineManager.string_2.Replace(",?", "," + num29);
				}
				Class75.smethod_57(characterAccountConfig_, AuxiliaryMachineManager.string_2);
				long_10 = Class11.smethod_27();
				num16 = ((num28 <= 0) ? random.Next(15000, 30000) : num28);
			}
			int num30 = Class89.smethod_39(characterAccountConfig_);
			if (num23 != 0 && num22 != 0 && num22 != 10 && num22 != 21 && num30 > 1)
			{
				num7 = 0;
				num2 = 0L;
				if (flag4)
				{
					flag4 = false;
					Thread.Sleep(1000);
					Class95.smethod_8(characterAccountConfig_);
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref array5[5]);
				int num31 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref array5[6]);
				int num32 = BitConverter.ToInt32(array, 0);
				num13 = 6;
				int num33 = 0;
				while (true)
				{
					if (num33 <= num13)
					{
						if (array5[num33] == 0)
						{
							break;
						}
						num33++;
						continue;
					}
					if (num6 != num32)
					{
						for (num33 = 0; num33 < array4.Length; num33++)
						{
							array4[num33] = 0L;
						}
						if (Class64.smethod_9(num31) == null)
						{
							flag3 = true;
							long_6 = Class11.smethod_27();
						}
						num6 = num32;
						num = -1L;
						Class75.smethod_2(characterAccountConfig_, Class75.uint_31, 0, 4);
					}
					if (num5 != num31)
					{
						for (num33 = 0; num33 < array4.Length; num33++)
						{
							array4[num33] = 0L;
						}
						flag3 = true;
						long_6 = Class11.smethod_27();
						num5 = num31;
						num = -1L;
						long_8 = Class11.smethod_27();
					}
					if (Class11.smethod_28(long_8) > num15)
					{
						num15 = 3000;
						long_8 = DateTime.Now.AddSeconds(30.0).Ticks;
						uint[,] array8 = Class85.smethod_41(characterAccountConfig_);
						Class75.smethod_2(characterAccountConfig_, Class75.uint_20, (int)array8[0, 0], 4);
						Class75.smethod_2(characterAccountConfig_, Class75.uint_20 + 1, (int)array8[0, 1], 4);
						Class75.smethod_2(characterAccountConfig_, Class75.uint_19, (int)array8[1, 0], 4);
						Class75.smethod_2(characterAccountConfig_, Class75.uint_19 + 1, (int)array8[1, 1], 4);
					}
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_7 + Class56.memorySignatureScanConfig_147.uint_0, array, 4, ref int_6);
					uint num34 = BitConverter.ToUInt32(array, 0);
					if (Class70.int_0 > 0 && num34 == 0)
					{
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_7 + Class95.uint_0, array, 1, ref int_6);
						int num35 = array[0];
						uint uint_ = characterAccountConfig_.uint_7 + Class56.memorySignatureScanConfig_179.uint_0 + Class56.memorySignatureScanConfig_180.uint_0 + Class56.memorySignatureScanConfig_181.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, uint_, array, 1, ref int_6);
						int num36 = array[0];
						int num37 = 0;
						if (num35 > 0 && num36 > 0)
						{
							if (num36 > 1)
							{
								array[0] = 1;
								Class24.WriteProcessMemory(characterAccountConfig_.int_137, uint_, array, 1, ref int_6);
								num37 = 1;
							}
						}
						else if (num35 > 0 || num36 > 0)
						{
							array[0] = 0;
							Class24.WriteProcessMemory(characterAccountConfig_.int_137, uint_, array, 1, ref int_6);
							Class89.smethod_40(characterAccountConfig_);
							num37 = 1;
						}
						if (num37 > 0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_21, array, 4, ref int_6);
							num37 = BitConverter.ToInt32(array, 0) + 1;
							byte[] bytes = BitConverter.GetBytes(num37);
							Class24.WriteProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_21, bytes, 4, ref int_6);
						}
					}
					if (characterAccountConfig_.int_67[0] > 0)
					{
						num14--;
						if (num14 <= 0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_88.uint_0, array, 4, ref int_6);
							if (BitConverter.ToUInt32(array, 0) != 0)
							{
								uint num38 = num18 + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_75.uint_0;
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, num38 + Class56.memorySignatureScanConfig_73.uint_0, array, 4, ref int_6);
								int num39 = BitConverter.ToInt32(array, 0);
								int num40 = 10000;
								if (num39 > characterAccountConfig_.int_67[1] * 10000)
								{
									int num41 = num39 - characterAccountConfig_.int_67[1] * num40;
									if (num41 > 10 * num40)
									{
										num41 = 10 * num40;
									}
									Class75.smethod_73(characterAccountConfig_, num41);
								}
							}
							num14 = 5;
						}
					}
					int num42 = Class83.smethod_13(characterAccountConfig_);
					if (num9 != num42)
					{
						int num43 = Class83.smethod_16(characterAccountConfig_, num42);
						int num44 = Class83.smethod_21(characterAccountConfig_, num42);
						int num45 = Class83.smethod_20(characterAccountConfig_, num42, num43) - 12;
						if (num45 <= 0)
						{
							num45 = characterAccountConfig_.int_96;
						}
						Class75.smethod_2(characterAccountConfig_, Class75.uint_43, num45, 4);
						Class75.smethod_2(characterAccountConfig_, Class75.uint_46, num44, 4);
						num9 = num42;
					}
					if (characterAccountConfig_.int_123 > 0 && !characterAccountConfig_.bool_36 && FormNhiepTT.int_0 <= 0)
					{
						FormNhiepTT.int_0 = int_5;
						new Thread(FormNhiepTT.smethod_0).Start();
						Thread.Sleep(100);
					}
					if (characterAccountConfig_.int_12[0] > 0 && !characterAccountConfig_.bool_3 && FormBanEvent.int_0 <= 0)
					{
						FormBanEvent.int_0 = int_5;
						new Thread(FormBanEvent.smethod_2).Start();
						Thread.Sleep(100);
					}
					if (!characterAccountConfig_.bool_39 && characterAccountConfig_.gstruct47_0[0].int_0 > 0 && characterAccountConfig_.gstruct47_0[1].int_0 > 0 && Class14.int_0 <= 0)
					{
						Class14.int_0 = int_5;
						new Thread(Class14.smethod_0).Start();
						Thread.Sleep(100);
					}
					if ((Form1.int_10 > 0 || Form1.int_11 > 0) && (Form1.int_58 <= 0 || Class46.characterSyncSnapshot_0.int_0 <= 0))
					{
						if (Form1.int_10 <= 0 && Form1.int_11 > 0)
						{
							AuxiliaryMachineManager.smethod_5(characterAccountConfig_);
						}
						if (Class46.characterSyncSnapshot_1.int_9 > 0)
						{
							Class46.smethod_8(Class46.characterSyncSnapshot_1.int_9);
							Class46.characterSyncSnapshot_1.int_9 = 0;
						}
						if (Class11.smethod_28(long_3) > 30000L)
						{
							Class89.smethod_32(characterAccountConfig_, 0u);
							long_3 = Class11.smethod_27();
						}
					}
					int num46 = Class85.smethod_4(characterAccountConfig_);
					if (characterAccountConfig_.int_75 != null && characterAccountConfig_.int_75[0] > 0 && Class11.smethod_28(long_4) > 1000L)
					{
						if (num8 < num46)
						{
							Class32.smethod_15(characterAccountConfig_);
							long_4 = Class11.smethod_27();
						}
						num8 = num46;
					}
					if (Class11.smethod_28(long_) > 90000L)
					{
						long_ = Class11.smethod_27();
						num17 = Class87.smethod_3(Form1.characterAccountConfig_1, int_5);
						if (num17 < 0)
						{
							return;
						}
						characterAccountConfig_ = Form1.characterAccountConfig_1[num17];
						Class75.smethod_2(characterAccountConfig_, 0u, 0, 4);
						Class75.smethod_2(characterAccountConfig_, Class75.uint_5, 0, 4);
						Class75.smethod_2(characterAccountConfig_, Class75.uint_6, 0, 4);
						Class75.smethod_2(characterAccountConfig_, Class75.uint_31, 0, 4);
						Form1.characterAccountConfig_1[num17].string_20 = Class28.smethod_10(characterAccountConfig_);
						string text2 = Class83.smethod_18(characterAccountConfig_);
						Form1.characterAccountConfig_1[num17].string_23 = text2;
						if (text2 == "NGAMY")
						{
							int num47 = 0;
							int num48 = 0;
							if (characterAccountConfig_.int_101[6] > 0)
							{
								num47 = 1114 * Convert.ToByte(Class83.smethod_16(characterAccountConfig_, 1114) > 0);
								num48 = 470;
							}
							if (num47 == 0)
							{
								num47 = 93 * Convert.ToByte(Class83.smethod_16(characterAccountConfig_, 93) > 0);
								num48 = 400;
							}
							Form1.characterAccountConfig_1[num17].int_101[1] = num47;
							Form1.characterAccountConfig_1[num17].int_101[5] = num48;
						}
						if (!characterAccountConfig_.bool_57 && text2 == "VODANG")
						{
							int num49 = Class83.smethod_16(characterAccountConfig_, 716);
							Form1.characterAccountConfig_1[num17].bool_57 = num49 > 0;
							if (num49 < 1)
							{
								num49 = 1;
							}
							else if (Class56.int_3.Length < num49)
							{
								num49 = Class56.int_3.Length;
							}
							Form1.characterAccountConfig_1[num17].long_9 = Class56.int_3[num49 - 1];
						}
						if (!characterAccountConfig_.bool_58 && text2 == "THIENNHAN")
						{
							int num50 = Class83.smethod_16(characterAccountConfig_, 715);
							Form1.characterAccountConfig_1[num17].bool_58 = num50 > 0;
							if (num50 >= 1)
							{
								if (Class56.int_4.Length < num50)
								{
									num50 = Class56.int_4.Length;
								}
							}
							else
							{
								num50 = 1;
							}
							Form1.characterAccountConfig_1[num17].long_9 = Class56.int_4[num50 - 1];
						}
						switch (text2)
						{
						default:
							if (characterAccountConfig_.int_119 > 0)
							{
								Form1.characterAccountConfig_1[num17].int_119 = 0;
							}
							break;
						case "THIENNHAN":
						case "NGUDOC":
						case "CONLON":
							break;
						}
						if (characterAccountConfig_.int_3 != null)
						{
							for (num33 = 0; num33 < characterAccountConfig_.int_3.GetLength(0); num33++)
							{
								int num51 = Class83.smethod_16(characterAccountConfig_, characterAccountConfig_.int_3[num33, 0]);
								Form1.characterAccountConfig_1[num17].int_3[num33, 1] = num51;
								if (num51 <= 0)
								{
									Form1.characterAccountConfig_1[num17].int_3[num33, 0] = 0;
								}
							}
							Form1.characterAccountConfig_1[num17].int_4 = Class56.smethod_17(text2);
						}
						if ((characterAccountConfig_.int_84[0] > 0 || characterAccountConfig_.int_84[1] > 0) && text2 == "CONLON" && !characterAccountConfig_.bool_18 && Class102.int_0 <= 0)
						{
							Class102.int_0 = characterAccountConfig_.int_136;
							new Thread(Class102.smethod_0).Start();
							Thread.Sleep(300);
						}
					}
					if (Form1.int_24 == 0)
					{
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_56.uint_0, array, 4, ref int_6);
						int num52 = BitConverter.ToInt32(array, 0);
						int num54;
						if (num32 > 0 && !characterAccountConfig_.bool_22)
						{
							int num53 = Class75.smethod_3(characterAccountConfig_, Class75.uint_30, 4);
							if (num53 <= 0)
							{
								if (Form1.int_25 > 0 && Form1.int_89 > 0)
								{
									uint[] uint_2 = new uint[2]
									{
										Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_.int_137),
										Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_.int_137)
									};
									num54 = -1;
									bool flag7 = (Form1.int_10 > 0 || Form1.int_11 > 0) && Class46.characterSyncSnapshot_1.int_4 == num31 && Class11.smethod_63(Class46.characterSyncSnapshot_1.uint_4) && Class64.smethod_18(uint_2, Class46.characterSyncSnapshot_1.uint_4) < 1000000L;
									bool flag8 = Form1.int_10 <= 0 && Form1.int_11 <= 0 && Class46.characterSyncSnapshot_0.int_4 == num31 && Class46.characterSyncSnapshot_0.int_0 > 0 && Class46.characterSyncSnapshot_0.int_0 != characterAccountConfig_.int_136 && Class11.smethod_63(Class46.characterSyncSnapshot_0.uint_4) && Class64.smethod_18(uint_2, Class46.characterSyncSnapshot_0.uint_4) < 1000000L;
									if (flag7 && num52 != Class46.characterSyncSnapshot_1.int_2)
									{
										num54 = Class46.characterSyncSnapshot_1.int_2;
									}
									else if (flag8 && num52 != Class46.characterSyncSnapshot_0.int_2)
									{
										num54 = Class46.characterSyncSnapshot_0.int_2;
									}
									else if (!flag7 && !flag8 && num52 > 0 && Class46.characterSyncSnapshot_0.int_0 > 0 && Class46.characterSyncSnapshot_0.int_0 != characterAccountConfig_.int_136)
									{
										num54 = num52 - 1;
									}
									if (num54 > 0 || (num54 == 0 && Class11.smethod_28(long_5) > 3000L))
									{
										if (num54 < num52)
										{
											num54 = num52 - 1;
										}
										Class75.smethod_57(characterAccountConfig_, "Switch([[pk]]," + num54 + ")");
										if (num52 == 1)
										{
											long_5 = Class11.smethod_27();
										}
									}
								}
							}
							else
							{
								Class75.smethod_2(characterAccountConfig_, Class75.uint_30, 0, 4);
								if (Class46.characterSyncSnapshot_0.int_0 == characterAccountConfig_.int_136 || Class46.characterSyncSnapshot_0.int_0 == 0 || Form1.int_25 == 0 || Form1.int_89 <= 0)
								{
									num52 = ((num52 == 2) ? 1 : 2);
									Class75.smethod_57(characterAccountConfig_, "Switch([[pk]]," + num52 + ")");
									long_5 = Class11.smethod_27();
								}
							}
						}
						else if (num52 > 0 && Class11.smethod_28(long_5) > 5000L)
						{
							Class75.smethod_57(characterAccountConfig_, "Switch([[pk]]," + (num52 - 1) + ")");
							long_5 = Class11.smethod_27();
						}
						num54 = -1;
					}
					if (flag3 && Class11.smethod_28(long_6) > 3000L)
					{
						if (characterAccountConfig_.int_138[0] > 0 && characterAccountConfig_.int_138[1] > 0)
						{
							int num55 = Class83.smethod_13(characterAccountConfig_);
							if (num55 != characterAccountConfig_.int_138[1])
							{
								Class83.smethod_15(characterAccountConfig_, (uint)characterAccountConfig_.int_138[1]);
								Class75.smethod_31(characterAccountConfig_, (uint)characterAccountConfig_.int_138[1]);
								Thread.Sleep(300);
							}
						}
						if (characterAccountConfig_.int_139[0] > 0 && characterAccountConfig_.int_139[1] > 0)
						{
							int num56 = Class83.smethod_14(characterAccountConfig_);
							if (num56 != characterAccountConfig_.int_139[1])
							{
								Class83.smethod_15(characterAccountConfig_, (uint)characterAccountConfig_.int_139[1], bool_0: true);
								Class75.smethod_32(characterAccountConfig_, (uint)characterAccountConfig_.int_139[1]);
								Thread.Sleep(300);
							}
						}
						if (characterAccountConfig_.int_140[0] > 0 && characterAccountConfig_.int_140[1] > 0)
						{
							int num57 = Class83.smethod_16(characterAccountConfig_, characterAccountConfig_.int_140[1]);
							Class75.smethod_2(characterAccountConfig_, Class75.uint_7, num57, 4);
						}
						if (characterAccountConfig_.int_141[0] > 0 && characterAccountConfig_.int_141[1] > 0)
						{
							int num58 = Class83.smethod_16(characterAccountConfig_, characterAccountConfig_.int_141[1]);
							Class75.smethod_2(characterAccountConfig_, Class75.uint_8, num58, 4);
						}
						if (characterAccountConfig_.int_142[0] > 0 && characterAccountConfig_.int_142[1] > 0)
						{
							int num59 = Class83.smethod_16(characterAccountConfig_, characterAccountConfig_.int_142[1]);
							Class75.smethod_2(characterAccountConfig_, Class75.uint_9, num59, 4);
						}
						flag3 = false;
					}
					if (Form1.int_61 > 0 && (Form1.int_65 > 0 || num32 > 0))
					{
						long ticks = new TimeSpan(0, 0, 0, Form1.int_88, 0).Ticks;
						if (num <= 0L)
						{
							num = DateTime.Now.Ticks - ticks + new TimeSpan(0, 0, 0, 10, 0).Ticks;
						}
						if (DateTime.Now.Ticks >= num + ticks)
						{
							int num60 = Class75.smethod_3(characterAccountConfig_, Class75.uint_5, 4);
							if (num60 <= 0)
							{
								GStruct34[] array9 = Class85.smethod_40(characterAccountConfig_, Form1.int_66[0], Form1.int_66[1]);
								num = DateTime.Now.Ticks;
								if (array9 != null)
								{
									if (!(array9[0].string_0 == "CHANGE"))
									{
										int num61 = -1;
										for (int k = 0; k < array9.Length; k++)
										{
											if (array9[k].int_0 <= Form1.int_86)
											{
												num61 = k;
												break;
											}
										}
										if (num61 >= 0)
										{
											bool flag9 = false;
											if (Form1.int_87 > 0)
											{
												Class29.smethod_7(characterAccountConfig_, "Ph\u00adîng T\u00adêng", "t©m");
												Class64.smethod_14(characterAccountConfig_);
												int num62 = 0;
												int num63 = 0;
												while (true)
												{
													num62++;
													Thread.Sleep(100);
													if (num62 > 15)
													{
														break;
													}
													Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_6);
													num18 = BitConverter.ToUInt32(array, 0);
													Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_6);
													num19 = BitConverter.ToUInt32(array, 0);
													Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_6);
													num20 = BitConverter.ToUInt32(array, 0);
													num21 = num20 + num19 * Class56.memorySignatureScanConfig_15.uint_0;
													Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_6);
													num23 = BitConverter.ToInt32(array, 0);
													Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_6);
													num32 = BitConverter.ToInt32(array, 0);
													Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_6);
													num31 = BitConverter.ToInt32(array, 0);
													if (num23 > 0 && num31 > 0 && num32 <= 0)
													{
														if (num63 >= 6)
														{
															flag9 = true;
															num17 = Class87.smethod_3(Form1.characterAccountConfig_1, int_5);
															if (0 <= num17)
															{
																Form1.characterAccountConfig_1[num17].bool_25 = false;
															}
															break;
														}
														num63++;
													}
													else
													{
														num63 = 0;
													}
												}
												Class75.smethod_52(characterAccountConfig_, "<color=yellow>[ Trang bi do ben thap can sua chua ]");
												Class38.smethod_50(characterAccountConfig_, "[ Trang bi do ben thap can sua chua ]");
											}
											if (!flag9 && Form1.int_85 > 0)
											{
												if (array9 != null && num61 < array9.Length && 0 <= num61)
												{
													string string_3 = "Nhân vật [" + Class1.smethod_1(characterAccountConfig_.string_22, 1) + "] đã thoát do có trang bị " + Class1.smethod_1(array9[num61].string_0, 1) + " độ bền <= " + Form1.int_86 + ", hãy nhanh chóng sửa chữa.";
													Class56.smethod_25("TrangbiDobenThap.txt", string_3, bool_2: true, "Tahoma", 12, 600, 400, 200, 280);
												}
												Class24.smethod_53(characterAccountConfig_.process_0);
											}
										}
									}
									else
									{
										num = -1L;
									}
								}
							}
						}
					}
					if (num32 <= 0)
					{
						flag2 = characterAccountConfig_.gstruct45_0.uint_0 != 0 || characterAccountConfig_.gstruct45_0.int_0 > 0;
						characterAccountConfig_.gstruct45_0.uint_0 = 0u;
						characterAccountConfig_.gstruct45_0.int_0 = 0;
						for (num33 = 0; num33 < array4.Length; num33++)
						{
							array4[num33] = 0L;
						}
						Thread.Sleep(100);
						break;
					}
					if (characterAccountConfig_.int_64[0] > 0 && Class11.smethod_28(long_9) > (1 + characterAccountConfig_.int_64[2]) * 1000)
					{
						if (!flag6)
						{
							flag6 = num12 != Class85.smethod_4(characterAccountConfig_);
						}
						if (flag6)
						{
							uint num64 = Class24.smethod_30(num21 + Class56.uint_7, characterAccountConfig_.int_137);
							uint num65 = Class24.smethod_30(num21 + Class56.uint_8, characterAccountConfig_.int_137);
							if (num64 < num65 && num65 < num64 * 3)
							{
								num64 = num65;
							}
							if (num64 <= characterAccountConfig_.int_64[1])
							{
								flag6 = ((Form1.int_24 == 1 || Class59.smethod_0(num31) != null) ? Class64.smethod_16(characterAccountConfig_, characterAccountConfig_.string_7) : Class64.smethod_16(characterAccountConfig_, characterAccountConfig_.string_8));
							}
						}
						num12 = Class85.smethod_4(characterAccountConfig_);
						long_9 = Class11.smethod_27();
					}
					if (!Form1.bool_22 && Class11.smethod_28(long_7) >= 800L)
					{
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_16 + Class75.uint_41 * 4, array2, 1, ref int_6);
						if (array2[0] > 0)
						{
							for (num33 = 0; num33 < array4.Length; num33++)
							{
								array4[num33] = 0L;
							}
							array2[0] = 0;
							Class24.WriteProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_16 + Class75.uint_41 * 4, array2, 1, ref int_6);
						}
						num10++;
						num11 = 0;
						switch (num10)
						{
						default:
							if (characterAccountConfig_.int_140[0] > 0 && characterAccountConfig_.int_140[1] > 0 && Class11.smethod_28(array4[0]) > characterAccountConfig_.int_140[2] && Class75.smethod_3(characterAccountConfig_, Class75.uint_7, 4) > 0)
							{
								num11 = characterAccountConfig_.int_140[1];
								array4[0] = Class11.smethod_27();
							}
							num10 = 1;
							break;
						case 3:
							if (num10 == 3 && characterAccountConfig_.int_142[0] > 0 && characterAccountConfig_.int_142[1] > 0 && Class11.smethod_28(array4[2]) > characterAccountConfig_.int_142[2] && Class75.smethod_3(characterAccountConfig_, Class75.uint_9, 4) > 0)
							{
								num11 = characterAccountConfig_.int_142[1];
								array4[2] = Class11.smethod_27();
							}
							break;
						case 2:
							if (characterAccountConfig_.int_141[0] > 0 && characterAccountConfig_.int_141[1] > 0 && Class11.smethod_28(array4[1]) > characterAccountConfig_.int_141[2] && Class75.smethod_3(characterAccountConfig_, Class75.uint_8, 4) > 0)
							{
								num11 = characterAccountConfig_.int_141[1];
								array4[1] = Class11.smethod_27();
							}
							break;
						}
						if (num11 > 0)
						{
							int num66 = 0;
							int num67 = 0;
							byte[] array10 = new byte[4];
							byte[] byte_2 = new byte[4];
							byte[] byte_3 = new byte[4];
							Class75.smethod_2(characterAccountConfig_, Class75.uint_6, 1, 4);
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_31.uint_0, byte_2, 4, ref int_6);
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num18 + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_68.uint_0, byte_3, 4, ref int_6);
							Thread.Sleep(100);
							int num68 = 0;
							while (true)
							{
								if (num66 >= 200 || num67 >= 10)
								{
									Class38.smethod_11(characterAccountConfig_, num11);
									num66 = 0;
									while (num66 < 8 && num11 > 0)
									{
										num66++;
										Thread.Sleep(100);
										for (uint num69 = 0u; num69 < 6; num69++)
										{
											uint num70 = Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_2.uint_0 + Class56.memorySignatureScanConfig_3.uint_0 * num69;
											Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + num70, array10, 4, ref int_6);
											int num71 = BitConverter.ToInt32(array10, 0);
											if (num71 > 0 && Class83.smethod_3(num71) == num11)
											{
												num11 = 0;
												break;
											}
										}
									}
									if (num11 <= 0 || num68 != 0)
									{
										break;
									}
									num68 = 1;
								}
								else
								{
									num66++;
									Class24.WriteProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
									Thread.Sleep(1);
									Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_55.uint_0, array10, 1, ref int_6);
									num67 = ((array10[0] <= 4) ? (num67 + 1) : 0);
								}
							}
							Class24.WriteProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_31.uint_0, byte_2, 4, ref int_6);
							Class24.WriteProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_161.uint_0 - 8, byte_3, 4, ref int_6);
							Class75.smethod_2(characterAccountConfig_, Class75.uint_6, 0, 4);
							long_7 = Class11.smethod_27();
						}
					}
					uint num72 = 0u;
					uint num73 = num18 + Class56.memorySignatureScanConfig_30.uint_0;
					uint[] uint_3;
					if (Form1.int_18 > 0 || Form1.int_20 > 0 || Form1.int_19 > 0)
					{
						if (characterAccountConfig_.gstruct45_0.uint_0 != 0 && characterAccountConfig_.gstruct45_0.int_0 > 0)
						{
							num72 = 0u;
							uint_3 = new uint[2]
							{
								Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_.int_137),
								Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_.int_137)
							};
							if (characterAccountConfig_.string_18 != null)
							{
								if (AuxiliaryMachineManager.bool_2)
								{
									int[] array11 = Class59.smethod_0(num31);
									if (array11 != null)
									{
										if (!flag5)
										{
											Class75.smethod_55(characterAccountConfig_, "<color=green>ChÕ ®é cõu s\u00b8t trong Tèng Kim ®· bÞ t¾t bëi adgame.");
											flag5 = true;
										}
										goto IL_1ed4;
									}
									flag5 = false;
								}
								int num74 = 0;
								while (num74 < characterAccountConfig_.string_18.Length)
								{
									if (characterAccountConfig_.gstruct45_0.string_0 != characterAccountConfig_.string_18[num74])
									{
										num74++;
										continue;
									}
									goto IL_1de5;
								}
							}
						}
						goto IL_1ed4;
					}
					goto IL_2117;
					IL_2117:
					if (characterAccountConfig_.int_120 > 0 && int_4 <= 0 && !characterAccountConfig_.bool_24)
					{
						int_4 = int_5;
						new Thread(smethod_4).Start();
					}
					break;
					IL_1ed4:
					uint num75 = Class24.smethod_30(num73 + Class56.memorySignatureScanConfig_61.uint_0, characterAccountConfig_.int_137);
					if (num75 != characterAccountConfig_.gstruct45_0.uint_0 || characterAccountConfig_.gstruct45_0.int_0 <= 0)
					{
						if (characterAccountConfig_.gstruct45_0.uint_0 != num75 && num75 == 0)
						{
							Class75.smethod_52(characterAccountConfig_, "<color=yellow>KÕt thóc cõu s\u00b8t");
							characterAccountConfig_.gstruct45_0.uint_0 = num75;
							num17 = Class87.smethod_3(Form1.characterAccountConfig_1, int_5);
							if (num17 < 0)
							{
								return;
							}
							Form1.characterAccountConfig_1[num17].gstruct45_0 = characterAccountConfig_.gstruct45_0;
						}
						else
						{
							characterAccountConfig_.gstruct45_0.uint_0 = num75;
							if (num75 != 0)
							{
								characterAccountConfig_.gstruct45_0.int_0 = Class38.smethod_8(characterAccountConfig_, num75);
								num72 = num20 + (uint)(characterAccountConfig_.gstruct45_0.int_0 * (int)Class56.memorySignatureScanConfig_15.uint_0);
								if (Class24.smethod_30(num72 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_.int_137) != 0)
								{
									characterAccountConfig_.gstruct45_0.uint_2 = Class24.smethod_30(num73 + Class56.memorySignatureScanConfig_62.uint_0, characterAccountConfig_.int_137);
									characterAccountConfig_.gstruct45_0.string_0 = Class24.smethod_28(num73 + Class56.memorySignatureScanConfig_60.uint_0, characterAccountConfig_.int_137, 16);
									string text3 = Class38.string_1[Convert.ToByte(characterAccountConfig_.gstruct45_0.uint_2 == 2)];
									if (Form1.int_20 > 0)
									{
										Class75.smethod_57(characterAccountConfig_, Class38.string_2[0].Replace("XXX", characterAccountConfig_.gstruct45_0.string_0).Replace("YYY", text3));
										Thread.Sleep(100);
									}
									if (Form1.int_18 > 0)
									{
										Class75.smethod_52(characterAccountConfig_, "<color=green>" + characterAccountConfig_.gstruct45_0.string_0 + "<color=white> " + text3 + " <color=red>cõu s\u00b8t<color=white> víi b¹n.");
										Thread.Sleep(100);
									}
									if (Form1.int_19 > 0)
									{
										Class75.smethod_57(characterAccountConfig_, Class38.string_3.Replace("XXX", characterAccountConfig_.gstruct45_0.string_0).Replace("YYY", text3));
										Thread.Sleep(100);
									}
								}
							}
						}
					}
					flag2 = true;
					goto IL_2117;
					IL_1de5:
					num72 = num20 + (uint)(characterAccountConfig_.gstruct45_0.int_0 * (int)Class56.memorySignatureScanConfig_15.uint_0);
					if (Class24.smethod_30(num72 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_.int_137) == 0 || Class24.smethod_28(num73 + Class56.memorySignatureScanConfig_60.uint_0, characterAccountConfig_.int_137, 18) != characterAccountConfig_.gstruct45_0.string_0)
					{
						characterAccountConfig_.gstruct45_0.int_0 = Class38.smethod_8(characterAccountConfig_, characterAccountConfig_.gstruct45_0.uint_0);
						if (characterAccountConfig_.gstruct45_0.int_0 == 0)
						{
							goto IL_2117;
						}
					}
					uint[] uint_4 = new uint[2]
					{
						Class24.smethod_30(num72 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_.int_137),
						Class24.smethod_30(num72 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_.int_137)
					};
					Class64.smethod_18(uint_3, uint_4);
					goto IL_1ed4;
				}
				continue;
			}
			Class13.smethod_2(characterAccountConfig_, bool_0: false);
			num7++;
			if (num7 < 4)
			{
				Thread.Sleep(100);
				continue;
			}
			flag4 = flag4 || num23 == 0 || num30 <= 1;
			if (num30 <= 1)
			{
				Thread.Sleep(300);
				num2 = Class11.smethod_27();
				long_8 = num2;
				continue;
			}
			long num76 = Class11.smethod_28(num2);
			if (characterAccountConfig_.int_94 <= 0 && (Form1.int_42 <= 0 || Form1.int_41 <= 0) && num76 > 10000L)
			{
				Class24.smethod_4(characterAccountConfig_.uint_4, 32u);
				Thread.Sleep(600);
				if (num2 > 0L && num76 > 15000L)
				{
					Class75.smethod_108(characterAccountConfig_);
				}
				if (0 <= Class95.smethod_0(characterAccountConfig_))
				{
					Class95.smethod_8(characterAccountConfig_);
				}
			}
			num6 = -1;
		}
	}

	private static void smethod_4()
	{
		int num = int_4;
		long long_ = 0L;
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		while (true)
		{
			try
			{
				Thread.Sleep(500);
				int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, num);
				if (num2 < 0)
				{
					break;
				}
				if (!Class11.bool_0 && Form1.characterAccountConfig_1[num2].bool_25 && Form1.characterAccountConfig_1[num2].int_120 > 0)
				{
					characterAccountConfig_ = Form1.characterAccountConfig_1[num2];
					if (!characterAccountConfig_.bool_24 || int_4 > 0)
					{
						Class75.smethod_52(characterAccountConfig_, "<color=yellow>Cõu s\u00b8t theo danh s\u00b8ch: <color=green>BËt");
						Form1.characterAccountConfig_1[num2].bool_24 = true;
						int_4 = 0;
					}
					if (characterAccountConfig_.string_18 == null || characterAccountConfig_.string_18.Length == 0)
					{
						continue;
					}
					uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_.int_137);
					uint num4 = num3 + Class56.memorySignatureScanConfig_30.uint_0;
					uint num5 = Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_.int_137);
					uint num6 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_.int_137);
					uint num7 = num6 + num5 * Class56.memorySignatureScanConfig_15.uint_0;
					int num8 = (int)Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_.int_137);
					int num9 = (int)Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_.int_137);
					int num10 = (int)Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_.int_137);
					if (num8 > 0 && num10 != 0 && num9 != 0 && num9 != 10 && num9 != 21)
					{
						if (Class11.smethod_28(long_) <= 1500L)
						{
							continue;
						}
						string text = Class72.smethod_7(characterAccountConfig_);
						if (text != null)
						{
							characterAccountConfig_.gstruct45_0.uint_2 = Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_62.uint_0, characterAccountConfig_.int_137);
							if (characterAccountConfig_.gstruct45_0.uint_2 < 2)
							{
								Class75.smethod_57(characterAccountConfig_, "Revenge('" + text + "')");
								Thread.Sleep(300);
								long_ = Class11.smethod_27();
							}
						}
					}
					else
					{
						Thread.Sleep(600);
					}
					continue;
				}
				Form1.characterAccountConfig_1[num2].bool_24 = false;
				Class75.smethod_52(characterAccountConfig_, "<color=yellow>Cõu s\u00b8t theo danh s\u00b8ch: <color=green>T¾t");
				break;
			}
			catch
			{
			}
		}
	}
}
