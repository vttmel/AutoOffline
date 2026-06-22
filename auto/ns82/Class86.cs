using System;
using System.Threading;
using ns1;
using ns10;
using ns100;
using ns109;
using ns11;
using ns111;
using ns121;
using ns13;
using ns20;
using ns23;
using ns28;
using ns29;
using ns3;
using ns31;
using ns33;
using ns35;
using ns37;
using ns42;
using ns43;
using ns44;
using ns50;
using ns53;
using ns56;
using ns6;
using ns61;
using ns65;
using ns68;
using ns71;
using ns77;
using ns79;
using ns81;
using ns83;
using ns85;
using ns88;
using ns91;

namespace ns82;

internal class Class86
{
	public static void smethod_0(int int_0)
	{
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		new Random();
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		int num4 = -1;
		int num5 = -1;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool bool_ = false;
		int num6 = 0;
		int num7 = 0;
		bool flag4 = false;
		bool flag5 = false;
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		uint num8 = 0u;
		uint uint_ = 0u;
		uint[] uint_2 = null;
		int int_1 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		int int_2 = 0;
		long num12 = 0L;
		long num13 = 0L;
		long long_4 = 0L;
		int num14 = 0;
		int int_3 = 0;
		int int_4 = 0;
		bool flag6 = false;
		uint[] array = null;
		int num15 = 0;
		bool flag7 = false;
		bool flag8 = false;
		int num16 = 0;
		int num17 = 0;
		int num18 = 0;
		int int_5 = -1;
		int[] array2 = new int[4];
		int int_6 = 0;
		byte[] byte_ = new byte[4];
		byte[] array3 = new byte[4];
		string text = null;
		uint[,] array4 = new uint[7, 3];
		Class10.smethod_4(array4, 357862);
		uint[,] array5 = array4;
		int num19 = 0;
		bool flag9 = false;
		bool flag10 = false;
		bool flag11 = false;
		int num20 = 0;
		int[] array6 = new int[10];
		for (int i = 0; i < array6.Length; i++)
		{
			array6[i] = 4;
		}
		while (true)
		{
			Thread.Sleep(200);
			num15 = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (Class11.bool_0 || num15 < 0 || Form1.int_24 != 2)
			{
				break;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num15];
			if (!characterAccountConfig.bool_25 || characterAccountConfig.bool_54 || characterAccountConfig.int_25 > 0 || characterAccountConfig.int_133[0] > 0 || characterAccountConfig.int_20[0] > 0)
			{
				break;
			}
			if (!characterAccountConfig.bool_15 && Class75.smethod_3(characterAccountConfig, Class75.uint_48, 4) <= 0)
			{
				if (Form1.int_28 == 1)
				{
					Class40.smethod_0(int_0);
					continue;
				}
				if (Form1.int_28 == 2)
				{
					Class21.smethod_0(int_0);
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref array6[0]);
				uint num21 = BitConverter.ToUInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_13.uint_0, array3, 4, ref array6[1]);
				uint num22 = BitConverter.ToUInt32(array3, 0);
				uint num23 = num22 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array3, 4, ref array6[2]);
				uint num24 = BitConverter.ToUInt32(array3, 0);
				uint num25 = num24 + num23;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num25, array3, 4, ref array6[3]);
				num8 = BitConverter.ToUInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_55.uint_0, array3, 4, ref array6[4]);
				int num26 = BitConverter.ToInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref array6[5]);
				int num27 = BitConverter.ToInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array3, 4, ref array6[6]);
				int num28 = BitConverter.ToInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref array6[7]);
				int num29 = BitConverter.ToInt32(array3, 0);
				num20 = 7;
				int num30 = Class89.smethod_12(characterAccountConfig);
				if ((characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0) || (num30 != 1 && num30 != 2))
				{
					if (num18 <= 0)
					{
						array2[0] = 0;
						array2[1] = 0;
						array2[2] = 0;
						array2[3] = 0;
					}
					num18 = 0;
					int num31 = Class89.smethod_39(characterAccountConfig);
					if (num27 != 0 && num26 != 0 && num28 != 0 && num31 > 1 && num26 != 10 && num26 != 21)
					{
						int num32 = 0;
						while (true)
						{
							if (num32 <= num20)
							{
								if (array6[num32] == 0)
								{
									break;
								}
								num32++;
								continue;
							}
							Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_23 * 4, array3, 1, ref int_6);
							if (array3[0] > 0)
							{
								flag = false;
								array3[0] = 0;
								Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_23 * 4, array3, 1, ref int_6);
							}
							Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_33 * 4, array3, 1, ref int_6);
							int num33 = array3[0];
							int num34;
							int num38;
							bool flag12;
							bool flag13;
							int int_8;
							uint[] array8;
							string text2;
							string string_;
							string string_2;
							string[] array9;
							uint[] array11;
							bool flag14;
							long num57;
							bool flag15;
							uint[] uint_3;
							int num36;
							if (num33 <= 0 && !flag9)
							{
								uint_3 = new uint[2]
								{
									Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
									Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
								};
								if (uint_3[0] == 0 || uint_3[1] == 0)
								{
									break;
								}
								if (flag10)
								{
									flag10 = false;
									Thread.Sleep(300);
									break;
								}
								if (num == num28 && (num2 == Class46.characterSyncSnapshot_0.int_4 || Form1.int_25 <= 0))
								{
									if (num4 != Form1.int_113)
									{
										flag4 = false;
										num7 = 0;
										num4 = Form1.int_113;
									}
									num34 = 600;
									if (characterAccountConfig.int_98 > 0)
									{
										num34 = characterAccountConfig.int_99;
									}
									Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_43 * 4, array3, 4, ref int_6);
									int num35 = BitConverter.ToInt32(array3, 0);
									num36 = num35;
									if (characterAccountConfig.int_95 > 0 && characterAccountConfig.int_96 > 0)
									{
										num36 = characterAccountConfig.int_96;
									}
									if (num36 <= 0)
									{
										num36 = 400;
									}
									Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_44 * 4, array3, 1, ref int_6);
									int num37 = array3[0];
									if (num37 > 0 && num36 > num35 && num35 > 0)
									{
										num36 = num35;
									}
									num16 = Form1.int_27;
									if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0)
									{
										if (num36 <= 180 && num16 < Form1.int_57)
										{
											num16 = Form1.int_57;
										}
										if (characterAccountConfig.int_131[0] > 0 && Form1.int_31 > 0 && num16 > 180)
										{
											num16 = 180;
										}
										if (flag11)
										{
											if (num29 > 0)
											{
												num16 = characterAccountConfig.gstruct50_0.int_9;
											}
											flag11 = false;
										}
									}
									array = uint_3;
									flag6 = false;
									num38 = 0;
									flag12 = false;
									flag13 = false;
									if ((Form1.int_49 > 0 && Class46.characterSyncSnapshot_0.int_0 != characterAccountConfig.int_136 && Class46.characterSyncSnapshot_0.int_0 > 0 && 926 <= Class46.characterSyncSnapshot_0.int_4 && Class46.characterSyncSnapshot_0.int_4 <= 932 && num19 != Class46.characterSyncSnapshot_0.int_4) || num4 != Form1.int_113)
									{
										flag4 = false;
										num7 = 0;
										num4 = Form1.int_113;
										num14 = 0;
										num19 = Class46.characterSyncSnapshot_0.int_4;
									}
									if (num3 != num29)
									{
										Thread.Sleep(100);
										uint_2 = null;
										int_1 = 0;
										int num39 = 0;
										while (num29 == 0 && num39 < 30 && num29 != num3)
										{
											Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref int_6);
											if (int_6 != 4)
											{
												goto end_IL_0400;
											}
											num21 = BitConverter.ToUInt32(array3, 0);
											Class24.ReadProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_13.uint_0, array3, 4, ref int_6);
											num22 = BitConverter.ToUInt32(array3, 0);
											num23 = num22 * Class56.memorySignatureScanConfig_15.uint_0;
											Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array3, 4, ref int_6);
											if (int_6 != 4)
											{
												goto end_IL_0400;
											}
											num24 = BitConverter.ToUInt32(array3, 0);
											num25 = num24 + num23;
											Class24.ReadProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_6);
											num29 = BitConverter.ToInt32(array3, 0);
											Thread.Sleep(10);
											num39++;
										}
										num3 = num29;
										if (num29 <= 0)
										{
											Thread.Sleep(150);
											Class95.smethod_8(characterAccountConfig);
											break;
										}
									}
									if (!Class6.smethod_0(num28))
									{
										if (num29 > 0)
										{
											flag = false;
											flag7 = true;
											if (num28 == 221 || num28 == 539)
											{
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
												if (Class53.smethod_0(characterAccountConfig) > 0)
												{
													break;
												}
											}
											int int_7 = Class6.cityTransportData_0[Form1.int_113].int_0;
											if (Class75.smethod_3(characterAccountConfig, Class75.uint_19, 4) > 0 && Class29.smethod_7(characterAccountConfig, int_7))
											{
												Thread.Sleep(300);
												Class64.smethod_11(characterAccountConfig);
												if (Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137) == 0)
												{
													break;
												}
											}
											if (Class64.smethod_14(characterAccountConfig))
											{
												Thread.Sleep(300);
												Class64.smethod_11(characterAccountConfig);
												if (Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137) == 0)
												{
													break;
												}
											}
											uint[] array7 = Class45.smethod_11(uint_3, num28, "Xa phu");
											if (array7 != null)
											{
												if (Class11.smethod_28(long_) > 4000L)
												{
													Class13.smethod_1(characterAccountConfig, array7);
													long_ = Class11.smethod_27();
												}
												break;
											}
										}
										if (Form1.int_119 > 0 && characterAccountConfig.int_136 == Class46.characterSyncSnapshot_0.int_0 && ((Form1.int_10 <= 0 && Form1.int_11 <= 0) || Class46.characterSyncSnapshot_1.int_4 <= 0))
										{
											Class64.smethod_10(characterAccountConfig, "CTC Ac chÝnh ng\u00adêi dïng tù ®iÒu khiÓn..");
											Thread.Sleep(300);
											break;
										}
										if (Class59.smethod_1(num28) != null)
										{
											Class53.smethod_5(characterAccountConfig, 11);
											flag5 = true;
											break;
										}
										if (!flag5)
										{
											int num40 = Class85.smethod_4(characterAccountConfig);
											if (flag && num5 >= 0 && num5 == num40)
											{
												if (flag7)
												{
													long num41 = Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_45.uint_0, characterAccountConfig.int_137);
													long num42 = Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_47.uint_0, characterAccountConfig.int_137) + 1;
													long num43 = Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_47.uint_0 + 4, characterAccountConfig.int_137) + 1;
													long num44 = Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_46.uint_0, characterAccountConfig.int_137);
													long num45 = Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_48.uint_0, characterAccountConfig.int_137) + 1;
													long num46 = Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_48.uint_0 + 4, characterAccountConfig.int_137) + 1;
													if (num43 > num42 && num43 < 150000L)
													{
														num42 = num43;
													}
													if (num46 > num45 && num46 < 150000L)
													{
														num45 = num46;
													}
													double num47 = num41 * 100L / num42;
													double num48 = num44 * 100L / num45;
													if (((num42 > 100L && characterAccountConfig.int_106[0] > 0 && characterAccountConfig.int_106[1] > 0 && num41 <= characterAccountConfig.int_106[1]) || (characterAccountConfig.int_109[0] > 0 && characterAccountConfig.int_109[1] > 0 && num47 <= (double)characterAccountConfig.int_109[1])) && Class32.smethod_12(characterAccountConfig, 0) > 0)
													{
														Thread.Sleep(600);
													}
													if (((num45 > 50L && characterAccountConfig.int_107[0] > 0 && characterAccountConfig.int_107[1] > 0 && num44 <= characterAccountConfig.int_107[1]) || (characterAccountConfig.int_111[0] > 0 && characterAccountConfig.int_111[1] > 0 && num48 <= (double)characterAccountConfig.int_111[1])) && Class32.smethod_12(characterAccountConfig, 1) > 0)
													{
														Thread.Sleep(300);
													}
													Thread.Sleep(150);
													num5 = Class85.smethod_4(characterAccountConfig);
													flag7 = false;
												}
												int_8 = Class6.cityTransportData_0[Form1.int_113].int_0;
												array8 = Class6.cityTransportData_0[Form1.int_113].uint_0;
												text2 = Class6.cityTransportData_0[Form1.int_113].string_0;
												string_ = Class6.cityTransportData_0[Form1.int_113].string_1;
												string_2 = Class6.cityTransportData_0[Form1.int_115].string_1;
												if (Form1.int_49 > 0 && Class46.characterSyncSnapshot_0.int_0 != characterAccountConfig.int_136 && Class46.characterSyncSnapshot_0.int_0 > 0 && Class46.characterSyncSnapshot_0.int_6 > 0 && 926 <= Class46.characterSyncSnapshot_0.int_4 && Class46.characterSyncSnapshot_0.int_4 <= 932)
												{
													for (num32 = 0; num32 < Class6.cityTransportData_0.Length; num32++)
													{
														if (Class46.characterSyncSnapshot_0.int_4 == Class6.cityTransportData_0[num32].int_1)
														{
															text2 = Class6.cityTransportData_0[num32].string_0;
															string_ = Class6.cityTransportData_0[num32].string_1;
															int_8 = Class6.cityTransportData_0[num32].int_0;
															array8 = Class6.cityTransportData_0[num32].uint_0;
															break;
														}
													}
												}
												if (text != null && text != string.Empty)
												{
													text2 = text;
												}
												if (Form1.int_112 > 0 && Class75.smethod_3(characterAccountConfig, Class75.uint_19, 4) > 0)
												{
													Class95.smethod_8(characterAccountConfig);
													Thread.Sleep(100);
													if (Class64.smethod_17(characterAccountConfig, "ThÇn Hµnh", bool_0: false))
													{
														Thread.Sleep(300);
														array9 = new string[8] { "ThÊt Thµnh", "ThÊt-Thµnh", "¹i ChiÕn", "tr\u00adêng ThÊt", "hiÕn tr\u00adêng", "o b¶n ®å C«ng T", "§i C«ng Thµnh", "Ok Ta" };
														string text3 = string.Empty;
														int num49 = 0;
														int num50 = -1;
														int num51 = 0;
														while (true)
														{
															num49++;
															Thread.Sleep(100);
															if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) != 0)
															{
																Class47.smethod_3(characterAccountConfig);
															}
															num50 = Class95.smethod_0(characterAccountConfig);
															if (0 <= num50)
															{
																num51 = Class95.smethod_1(characterAccountConfig, num50);
																for (num32 = 0; num32 < num51; num32++)
																{
																	text3 += Class95.smethod_3(characterAccountConfig, num32, num50, 128);
																}
																if (text3 != string.Empty)
																{
																	break;
																}
															}
															if (num49 <= 10)
															{
																continue;
															}
															goto IL_13b8;
														}
														if (num51 > 0)
														{
															for (int j = 0; j < num51; j++)
															{
																string string_3 = Class95.smethod_3(characterAccountConfig, j, num50, 128).ToLower();
																int num52 = 0;
																while (num52 < array9.Length)
																{
																	if (!(array9[num52] != "hiÕn tr\u00adêng") || 0 > Class11.smethod_1(string_3, array9[num52].ToLower()))
																	{
																		num52++;
																		continue;
																	}
																	goto IL_1128;
																}
															}
														}
														num49 = 0;
														if (Form1.string_37 != null && Form1.string_37 != string.Empty)
														{
															string[] array10 = Form1.string_37.Split(',', ';', '.', '-', '/');
															for (int k = 0; k < array10.Length; k++)
															{
																if (Class95.smethod_0(characterAccountConfig) < 0)
																{
																	break;
																}
																int num53 = Class11.smethod_11(array10[k]) - 1;
																int num54 = Class95.smethod_1(characterAccountConfig);
																if (0 <= num53 && num53 < num54)
																{
																	Class95.smethod_5(characterAccountConfig, num53);
																	Thread.Sleep(250 + Class95.int_0);
																	if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) != 0)
																	{
																		Class47.smethod_3(characterAccountConfig);
																	}
																}
															}
														}
														string text4;
														while (true)
														{
															num49++;
															Thread.Sleep(100);
															num50 = Class95.smethod_0(characterAccountConfig);
															if (0 <= num50)
															{
																text4 = string.Empty;
																num51 = Class95.smethod_1(characterAccountConfig, num50);
																for (num32 = 0; num32 < num51; num32++)
																{
																	text4 += Class95.smethod_3(characterAccountConfig, num32, num50, 128);
																}
																if (text3 != text4 && text4 != string.Empty)
																{
																	break;
																}
															}
															if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) != 0)
															{
																Class47.smethod_3(characterAccountConfig);
															}
															if (num49 <= 10)
															{
																continue;
															}
															goto IL_13b8;
														}
														text3 = text4;
														Thread.Sleep(300);
														if (num51 == 1)
														{
															Class95.smethod_5(characterAccountConfig, 0);
															break;
														}
														goto IL_1128;
													}
												}
												goto IL_13b8;
											}
											if (!Form1.bool_18 && Class36.smethod_3(characterAccountConfig, Form1.int_105 <= 0) == 0)
											{
												Thread.Sleep(300);
												break;
											}
											flag = true;
											if (characterAccountConfig.int_65 > 0)
											{
												Class64.smethod_3(characterAccountConfig, ref bool_);
											}
											num5 = Class85.smethod_4(characterAccountConfig);
											break;
										}
										flag5 = Class98.smethod_0(characterAccountConfig, bool_0: true) <= 0;
										break;
									}
									flag2 = false;
									flag3 = false;
									flag = false;
									num7 = 0;
									num6 = 0;
									array11 = new uint[2];
									flag14 = (Form1.int_10 > 0 || Form1.int_11 > 0) && Form1.int_25 > 0 && (Class46.characterSyncSnapshot_1.int_3 > 0 || Form1.int_26 > 0) && Class46.characterSyncSnapshot_1.int_4 > 0 && Class11.smethod_63(Class46.characterSyncSnapshot_1.uint_4) && (characterAccountConfig.int_136 == Class46.characterSyncSnapshot_0.int_0 || Class46.characterSyncSnapshot_0.int_0 <= 0);
									if (!(flag15 = Form1.int_25 > 0 && (Form1.int_26 > 0 || Class46.characterSyncSnapshot_0.int_3 > 0) && Class46.characterSyncSnapshot_0.int_0 != characterAccountConfig.int_136 && Class11.smethod_63(Class46.characterSyncSnapshot_0.uint_4) && Class46.characterSyncSnapshot_0.int_0 > 0 && Class46.characterSyncSnapshot_0.int_6 > 0))
									{
										if (characterAccountConfig.int_68 != null && characterAccountConfig.int_68[0] > 0 && !AuxiliaryMachineManager.bool_3)
										{
											uint[] array12 = null;
											if (num12 <= 0L || Class11.smethod_28(num12) >= 1000L)
											{
												array12 = Class64.smethod_26(characterAccountConfig, ref int_2);
												if (array12 != null)
												{
													num12 = 0L;
													long num55 = Class64.smethod_18(uint_3, array12);
													if (num55 < 8000L)
													{
														goto IL_2724;
													}
													if (num55 >= 15000L && num55 >= characterAccountConfig.int_68[1] * characterAccountConfig.int_68[1])
													{
														if (num55 < 360000L)
														{
															if (num17 > 0)
															{
																Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
															}
															num17 = 0;
															Class13.smethod_2(characterAccountConfig, bool_0: false);
															Class75.smethod_61(characterAccountConfig, array12);
															Thread.Sleep(200);
															break;
														}
														if (num55 < 1200000L)
														{
															if (Class11.smethod_28(long_) > 3000L)
															{
																Class13.smethod_1(characterAccountConfig, array12);
																long_ = Class11.smethod_27();
															}
															break;
														}
													}
													else
													{
														if (num26 <= 3 && num55 > 7500L)
														{
															if (num17 > 0)
															{
																Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
															}
															num17 = 0;
															Class75.smethod_61(characterAccountConfig, array12);
															Thread.Sleep(200);
															goto IL_3fdc;
														}
														num55 = 4L;
													}
												}
												else
												{
													num12 = Class11.smethod_27();
												}
											}
										}
										if (flag14)
										{
											int num56 = AuxiliaryMachineManager.smethod_9(characterAccountConfig, ref long_, ref int_1, ref uint_2);
											if (num56 <= 0)
											{
												Thread.Sleep(100);
												break;
											}
											num26 = (int)Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
											if (num26 < 3)
											{
												uint_3 = new uint[2]
												{
													Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
													Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
												};
												if (Class64.smethod_18(uint_3, Class46.characterSyncSnapshot_1.uint_4) > 5625L)
												{
													if (num17 > 0)
													{
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
													}
													num17 = 0;
													Class75.smethod_61(characterAccountConfig, Class46.characterSyncSnapshot_1.uint_4);
													Thread.Sleep(150);
												}
											}
										}
									}
									else
									{
										num28 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
										uint_3 = new uint[2]
										{
											Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
											Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
										};
										if (Class46.characterSyncSnapshot_0.int_4 == num28 && Class6.smethod_0(num28))
										{
											num57 = Class64.smethod_18(uint_3, Class46.characterSyncSnapshot_0.uint_4);
											if (characterAccountConfig.int_130[0] > 0 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && num29 == Class46.characterSyncSnapshot_0.int_3 && num29 > 0)
											{
												int num58 = characterAccountConfig.int_130[1] + Form1.int_27;
												if (num57 <= num58 * num58 && Class68.smethod_0(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4, characterAccountConfig.int_130[1]) > 0)
												{
													goto IL_404b;
												}
											}
											if (flag8 || num57 > num16 * num16)
											{
												goto IL_230a;
											}
											Class13.smethod_2(characterAccountConfig, bool_0: false);
											int num59 = num9;
											num9 = 0;
											uint_2 = null;
											int_1 = 0;
											if (num29 > 0 && !characterAccountConfig.bool_22 && characterAccountConfig.int_93 == 1 && Form1.int_109 > 0 && (Form1.int_35 > 0 || Form1.int_34 > 0 || Form1.int_36 > 0) && Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137) != 0)
											{
												Class64.smethod_30(characterAccountConfig);
											}
											if (num13 <= 0L || Class11.smethod_28(num13) >= 1500L)
											{
												uint[] uint_4 = new uint[2]
												{
													uint_3[0],
													uint_3[1]
												};
												if (Class46.smethod_5(num8, ref uint_3, ref uint_) > 0)
												{
													long num60 = Class64.smethod_18(uint_4, Class46.characterSyncSnapshot_0.uint_4);
													long num61 = Class64.smethod_18(uint_3, Class46.characterSyncSnapshot_0.uint_4);
													if (num61 <= num16 * num16)
													{
														num13 = Class11.smethod_27();
														if (num17 > 0)
														{
															Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
														}
														num17 = 0;
														Class46.smethod_6(characterAccountConfig, uint_3, Class46.characterSyncSnapshot_0.uint_4, num60 <= 5625L);
														goto IL_3fdc;
													}
													if (num59 > 0)
													{
														uint[] uint_5 = Class64.smethod_5(uint_3, Class46.characterSyncSnapshot_0.uint_4, -100);
														Class75.smethod_61(characterAccountConfig, uint_5);
														Thread.Sleep(120);
													}
													goto IL_230a;
												}
												num13 = 0L;
												if (num17 == 0 && Class64.smethod_18(uint_4, Class46.characterSyncSnapshot_0.uint_4) > Form1.int_27 * Form1.int_27)
												{
													num10++;
													if (num10 > 3)
													{
														Class75.smethod_61(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4);
														Thread.Sleep(150);
														num10 = 0;
													}
												}
												if (Form1.int_31 > 0 && num29 > 0 && characterAccountConfig.int_131[0] > 0 && Class75.smethod_3(characterAccountConfig, Class75.uint_31, 4) == 0)
												{
													Class75.smethod_2(characterAccountConfig, Class75.uint_31, 1, 4);
												}
											}
											int_1 = 0;
											uint_2 = null;
											array = Class46.characterSyncSnapshot_0.uint_4;
											flag6 = true;
										}
										else if (Class6.smethod_0(Class46.characterSyncSnapshot_0.int_4))
										{
											uint_3 = new uint[2]
											{
												Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
												Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
											};
											uint[] array13 = Class6.smethod_1(num28, uint_3, Class46.characterSyncSnapshot_0.int_4, Class46.characterSyncSnapshot_0.uint_4);
											if (array13 != null)
											{
												uint[] array14 = new uint[2]
												{
													array13[0],
													array13[1]
												};
												int int_9 = (int)array13[2];
												num57 = Class38.smethod_0(uint_3, array14);
												if (num57 >= 90000L)
												{
													if (uint_2 == null)
													{
														uint_2 = new uint[2]
														{
															uint_3[0],
															uint_3[1]
														};
														int_1 = 0;
													}
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
													num17 = 0;
													Class64.smethod_29(characterAccountConfig, bool_0: false);
													if (int_1 > 6)
													{
														long num62 = Class64.smethod_18(uint_2, uint_3);
														uint_2 = null;
														if (num62 < 180000L)
														{
															Class64.smethod_2(characterAccountConfig, uint_3, array14, 600);
															break;
														}
														int_1 = 0;
													}
													if (!Class13.smethod_3(characterAccountConfig) || Class11.smethod_28(long_) > 6000L)
													{
														int_1++;
														Class13.smethod_1(characterAccountConfig, array14);
														long_ = Class11.smethod_27();
													}
													break;
												}
												int_1 = 0;
												int_1 = 0;
												uint_2 = null;
												Class13.smethod_2(characterAccountConfig, bool_0: false);
												for (int l = 0; l < 10; l++)
												{
													uint_3 = new uint[2]
													{
														Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
														Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
													};
													num57 = Class64.smethod_18(uint_3, array14);
													if (num57 < 11500L || Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137) != num28)
													{
														break;
													}
													Class75.smethod_61(characterAccountConfig, array14);
													Thread.Sleep(300);
												}
												for (int m = 0; m < 5; m++)
												{
													Class64.smethod_25(characterAccountConfig, int_9);
													Thread.Sleep(300);
													uint num63 = Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
													if (num63 != num28)
													{
														break;
													}
												}
												break;
											}
										}
									}
									goto IL_2724;
								}
								flag = false;
								flag2 = false;
								flag3 = false;
								bool_ = false;
								uint_2 = null;
								int num64 = 0;
								while (true)
								{
									if (num != num28)
									{
										int num65 = Class89.smethod_39(characterAccountConfig);
										Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref int_6);
										if (int_6 != 4)
										{
											break;
										}
										num21 = BitConverter.ToUInt32(array3, 0);
										Class24.ReadProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_13.uint_0, array3, 4, ref int_6);
										num22 = BitConverter.ToUInt32(array3, 0);
										num23 = num22 * Class56.memorySignatureScanConfig_15.uint_0;
										Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array3, 4, ref int_6);
										if (int_6 != 4)
										{
											break;
										}
										num24 = BitConverter.ToUInt32(array3, 0);
										num25 = num24 + num23;
										Class24.ReadProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_6);
										num27 = BitConverter.ToInt32(array3, 0);
										Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array3, 4, ref int_6);
										num28 = BitConverter.ToInt32(array3, 0);
										Class24.ReadProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_6);
										num29 = BitConverter.ToInt32(array3, 0);
										Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
										num17 = 0;
										if (num29 <= 0 && num64 <= 8 && (num65 == 0 || num65 == 1 || num27 <= 0 || num28 <= 0))
										{
											num64++;
											Thread.Sleep(100);
											continue;
										}
									}
									num = num28;
									num2 = Class46.characterSyncSnapshot_0.int_4;
									break;
								}
								break;
							}
							bool value = false;
							if (num29 == 0)
							{
								flag9 = (value = Class98.smethod_0(characterAccountConfig, bool_0: true) != 1);
							}
							array3[0] = Convert.ToByte(value);
							Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_33 * 4, array3, 1, ref int_6);
							break;
							IL_2a10:
							uint num66 = 0u;
							uint[] array15 = null;
							uint[] uint_6 = null;
							if (!flag14)
							{
								if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136 && Class46.characterSyncSnapshot_0.uint_5 != 0)
								{
									uint num67 = Class46.characterSyncSnapshot_0.uint_5 >> 16;
									uint int_10 = Class46.characterSyncSnapshot_0.uint_5 - (num67 << 16);
									array15 = Class89.smethod_11(Class46.characterSyncSnapshot_0.uint_4, (int)int_10, (int)num67);
									uint[] array16 = Class89.smethod_10(uint_3, array15);
									num66 = (array16[1] << 16) + array16[0];
									uint_6 = Class46.characterSyncSnapshot_0.uint_4;
									Class89.smethod_7(characterAccountConfig, num66);
									Thread.Sleep(10);
								}
							}
							else
							{
								uint num68 = Class46.characterSyncSnapshot_1.uint_5 >> 16;
								uint int_11 = Class46.characterSyncSnapshot_1.uint_5 - (num68 << 16);
								array15 = Class89.smethod_11(Class46.characterSyncSnapshot_1.uint_4, (int)int_11, (int)num68);
								uint[] array17 = Class89.smethod_10(uint_3, array15);
								num66 = (array17[1] << 16) + array17[0];
								uint_6 = Class46.characterSyncSnapshot_1.uint_4;
								Class89.smethod_7(characterAccountConfig, num66);
								Thread.Sleep(10);
							}
							Class64.smethod_30(characterAccountConfig);
							int num69;
							if (characterAccountConfig.int_127[0] != 2)
							{
								if (characterAccountConfig.int_127[0] > 0)
								{
									bool flag16 = characterAccountConfig.int_127[1] > 0 && characterAccountConfig.int_127[2] > 0;
									bool flag17 = characterAccountConfig.int_127[3] > 0 && characterAccountConfig.int_127[4] > 0;
									if (flag16 && !flag17)
									{
										num69 = characterAccountConfig.int_127[2];
									}
									else if (flag17 && !flag16)
									{
										num69 = characterAccountConfig.int_127[4];
									}
									else if (flag16 && flag17)
									{
										num69 = ((0 > num11 || num11 > 25) ? characterAccountConfig.int_127[4] : characterAccountConfig.int_127[2]);
										if (num11 > 35)
										{
											num11 = 0;
										}
										num11++;
									}
								}
								if (num69 <= 0)
								{
									num69 = Class83.smethod_13(characterAccountConfig);
								}
								if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 || Form1.int_10 > 0 || Form1.int_11 > 0)
								{
									Class83.smethod_9(characterAccountConfig);
								}
								Class83.smethod_5(characterAccountConfig, num69, 6, 1);
								for (int n = 0; n < 3; n++)
								{
									if (FormDame.int_14 > 0)
									{
										Class24.smethod_76(characterAccountConfig.uint_4, 32);
									}
									else
									{
										Class24.smethod_76(characterAccountConfig.uint_4, 117);
									}
									if (n < 2)
									{
										Thread.Sleep(60);
									}
								}
							}
							else
							{
								Class64.smethod_0(characterAccountConfig.uint_4, characterAccountConfig.int_129, FormDame.int_12);
							}
							if (num66 != 0 && characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136)
							{
								if (characterAccountConfig.int_95 <= 0)
								{
									Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_31.uint_0, characterAccountConfig.int_137);
									int num70 = Class83.smethod_13(characterAccountConfig);
									if (num70 == 53 || num70 <= 1)
									{
										goto IL_3fdc;
									}
									if (num70 <= 100)
									{
										num70 = 400;
									}
								}
								string string_4 = Class89.smethod_20(characterAccountConfig);
								if (Class11.smethod_2(string_4, "iÓm qu\u00b8 x"))
								{
									uint[] array18 = Class64.smethod_5(uint_6, array15, -1 * (Form1.int_27 - 50));
									long num71 = Class64.smethod_18(uint_3, array18);
									if (num71 > 7000L)
									{
										Class75.smethod_61(characterAccountConfig, array18);
										Thread.Sleep(150);
										Class89.smethod_21(characterAccountConfig, "0K..");
									}
								}
							}
							goto IL_3fdc;
							IL_29db:
							num69 = 0;
							goto IL_2de3;
							IL_13b8:
							if (Form1.int_114 > 0 && num14 >= Form1.int_43 && (Form1.int_44 > 0 || num14 < Form1.int_43 * 2))
							{
								array8 = Class6.cityTransportData_0[Form1.int_115].uint_0;
								text2 = Class6.cityTransportData_0[Form1.int_115].string_0;
								string_ = Class6.cityTransportData_0[Form1.int_115].string_1;
								int_8 = Class6.cityTransportData_0[Form1.int_115].int_0;
								flag4 = true;
								if (text != null && text != string.Empty)
								{
									text2 = text;
								}
							}
							else if (num14 >= Form1.int_43 * 2)
							{
								num14 = 0;
							}
							int[] array19 = Class64.smethod_9(num28);
							int num74;
							if (array19 != null && num29 <= 0)
							{
								if (num28 != int_8)
								{
									if (!flag2 && Class75.smethod_3(characterAccountConfig, Class75.uint_19, 4) > 0)
									{
										flag2 = true;
										flag9 = Class29.smethod_7(characterAccountConfig, int_8, null, array8);
									}
									if (!flag9)
									{
										flag9 = Class53.smethod_5(characterAccountConfig, int_8) > 0;
									}
									break;
								}
								if (array8 == null)
								{
									for (int num72 = 0; num72 < array5.GetLength(0); num72++)
									{
										if (int_8 == array5[num72, 0])
										{
											array8 = new uint[2]
											{
												array5[num72, 1],
												array5[num72, 2]
											};
											break;
										}
									}
									if (array8 == null)
									{
										if (Class11.smethod_28(long_4) > 8000L)
										{
											string string_5 = Class6.cityTransportData_0[Form1.int_113].string_1;
											string string_6 = "<bclr=blue><color=green>[ " + string_5 + "] ch\u00ada cã täa ®é Xa phu C«ng thµnh chiÕn, vµo B¶ng 1 - CTC bÊm nót LÊy vÞ trÝ Xa phu ®Ó lÊy täa ®é";
											string string_7 = "<bclr=blue><color=green>NÕu vµo ®\u00adîc CTC b»ng ThÇn Hµnh phï, th× qua tab Cµi game cña auto chän l¹i cho ®óng WEB ®ang ch¬i.";
											Class75.smethod_52(characterAccountConfig, string_6);
											Class75.smethod_52(characterAccountConfig, string_7);
										}
										break;
									}
								}
								if (!flag4 && num7 < 6)
								{
									uint[] uint_7 = Class45.smethod_11(array8, int_8, "R\u00ad¬ng chøa ®å");
									flag4 = Class98.smethod_0(characterAccountConfig, bool_0: true, uint_7) > 0;
									num7++;
									break;
								}
								long num73 = Class64.smethod_18(uint_3, array8);
								if (num73 <= 90000L)
								{
									uint_2 = null;
									uint[] uint_8 = null;
									num74 = 0;
									string text5 = null;
									if (text2 != null && text2 != string.Empty)
									{
										num74 = smethod_1(characterAccountConfig, text2, ref uint_8);
										if (num74 > 0)
										{
											text5 = Class3.smethod_16(characterAccountConfig, num74, ref uint_8).Trim();
											if (text5 == string.Empty || text5 == "Xa phu" || text5.Length <= 7)
											{
												num74 = 0;
											}
										}
									}
									if (num74 <= 0)
									{
										string text6 = smethod_2(characterAccountConfig);
										if (text6 != null && text6 != string.Empty)
										{
											text = text6;
										}
										Class64.smethod_10(characterAccountConfig, "Khong tim thay Xa phu Cong thanh chien, auto tu dong thiet lap lai.");
										break;
									}
									for (int num75 = 0; num75 < 10; num75++)
									{
										uint_3 = new uint[2]
										{
											Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
											Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
										};
										num57 = Class64.smethod_18(uint_3, uint_8);
										if (num57 <= 11500L)
										{
											break;
										}
										Class75.smethod_61(characterAccountConfig, uint_8);
										Thread.Sleep(300);
									}
									Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num74), 4, ref int_6);
									Thread.Sleep(600);
									int num76 = Class95.smethod_0(characterAccountConfig);
									int num77 = Class95.smethod_1(characterAccountConfig, num76);
									if (0 <= Class95.smethod_0(characterAccountConfig) && num77 > 0 && 0 <= num76)
									{
										int[] array20 = new int[2];
										int[] array21 = array20;
										string[] array22 = new string[4] { "Ok Ta", "Vµo", "chiÕn tr\u00adêng", "ThÊt-Thµnh" };
										int num78 = -1;
										int num79 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
										for (num32 = 0; num32 < array22.Length; num77 = Class95.smethod_1(characterAccountConfig, num76), num32++)
										{
											string object_ = array22[num32].ToLower();
											int num80 = 0;
											while (num80 < num77)
											{
												string string_8 = Class95.smethod_3(characterAccountConfig, num80, num76, 128).ToLower();
												if (0 > Class11.smethod_1(string_8, object_))
												{
													num80++;
													continue;
												}
												goto IL_18bf;
											}
											continue;
											IL_18bf:
											num78 = num80;
											Class95.smethod_5(characterAccountConfig, num78);
											int num81 = 0;
											while (num81 < 15)
											{
												if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) != 0)
												{
													Class47.smethod_3(characterAccountConfig);
													Thread.Sleep(450);
												}
												int num82 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
												if (num79 == num82)
												{
													Thread.Sleep(60);
													num81++;
													continue;
												}
												goto IL_1a40;
											}
										}
										if (num78 < 0)
										{
											array21 = new int[3] { 3, 0, 0 };
										}
										int num83 = array21.Length;
										for (num32 = 0; num32 < num83; num32++)
										{
											Class95.smethod_5(characterAccountConfig, array21[num32]);
											int num84 = 0;
											while (num84 < 15)
											{
												int num85 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
												if (num79 == num85)
												{
													Thread.Sleep(60);
													num84++;
													continue;
												}
												goto IL_1a23;
											}
										}
										if (Form1.int_114 > 0)
										{
											num14++;
										}
									}
									Class95.smethod_8(characterAccountConfig);
									break;
								}
								if (uint_2 == null)
								{
									uint_2 = new uint[2]
									{
										uint_3[0],
										uint_3[1]
									};
									int_1 = 0;
								}
								if (int_1 > 6)
								{
									bool flag18 = uint_2 != null && Class64.smethod_18(uint_2, uint_3) < 180000L;
									uint_2 = null;
									if (flag18)
									{
										Class64.smethod_2(characterAccountConfig, uint_3, Class46.characterSyncSnapshot_0.uint_4, 600);
										break;
									}
									int_1 = 0;
								}
								if (!Class13.smethod_3(characterAccountConfig) || Class11.smethod_28(long_) > 4000L)
								{
									int_1++;
									Class13.smethod_1(characterAccountConfig, array8);
									long_ = Class11.smethod_27();
								}
								break;
							}
							if (!flag2 && Class75.smethod_3(characterAccountConfig, Class75.uint_19, 4) > 0)
							{
								flag2 = true;
								if (Class29.smethod_7(characterAccountConfig, int_8, null, array8))
								{
									goto IL_1b98;
								}
							}
							else if (!flag3 && !Class32.smethod_0(num28))
							{
								flag3 = true;
								if (Class64.smethod_14(characterAccountConfig))
								{
									goto IL_1b98;
								}
							}
							int int_12 = 1;
							array19 = Class64.smethod_9(string_);
							if (array19 != null)
							{
								int_12 = Class64.int_0[array19[0], array19[1]];
							}
							flag9 = Class53.smethod_5(characterAccountConfig, int_12) > 0;
							flag3 = false;
							flag2 = false;
							goto IL_1b98;
							IL_1b98:
							if (num28 != 2)
							{
								break;
							}
							return;
							IL_1a40:
							if (Class95.Class92.smethod_4(characterAccountConfig))
							{
								Class24.smethod_4(characterAccountConfig.uint_4, 32u);
							}
							break;
							IL_404b:
							if (!characterAccountConfig.bool_58 || characterAccountConfig.int_83 <= 0)
							{
								break;
							}
							if (Form1.int_106 != 0)
							{
								if (Class46.characterSyncSnapshot_0.int_7 == Class30.gstruct42_0[Form1.int_107].int_0)
								{
									Class38.smethod_54(characterAccountConfig, null, bool_0: true);
									if (Class11.smethod_28(long_2) > characterAccountConfig.long_9)
									{
										Class38.smethod_55(characterAccountConfig);
										long_2 = Class11.smethod_27();
									}
								}
							}
							else if (num38 > 0 && Class11.smethod_28(long_2) > characterAccountConfig.long_9)
							{
								Class38.smethod_54(characterAccountConfig, array11, bool_0: false);
								Class38.smethod_55(characterAccountConfig);
								long_2 = Class11.smethod_27();
							}
							break;
							IL_1a23:
							if (Class95.Class92.smethod_4(characterAccountConfig))
							{
								Class24.smethod_4(characterAccountConfig.uint_4, 32u);
							}
							break;
							IL_3fdc:
							if (!flag13 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && Class38.smethod_58(characterAccountConfig, new int[2] { 0, 1 }) != 0)
							{
								if (num17 > 0)
								{
									Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
								}
								num17 = 0;
							}
							if (flag12 && num38 <= 0)
							{
								FormDuongMon.smethod_0(characterAccountConfig, ref int_3, array, ref int_4, flag6);
							}
							goto IL_404b;
							IL_2724:
							num29 = (int)Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
							if (num29 <= 0)
							{
								break;
							}
							num74 = 0;
							flag15 = Form1.int_25 > 0 && Class46.characterSyncSnapshot_0.int_0 != characterAccountConfig.int_136 && Class46.characterSyncSnapshot_0.int_0 > 0 && Class46.characterSyncSnapshot_0.int_6 > 0 && Class46.characterSyncSnapshot_0.int_4 == num28;
							flag13 = !characterAccountConfig.bool_22 && (Form1.int_35 > 0 || Form1.int_34 > 0);
							if (characterAccountConfig.int_101[0] > 0 && characterAccountConfig.int_101[1] > 0 && characterAccountConfig.string_23 == "NGAMY")
							{
								long num86 = Class11.smethod_28(long_3);
								if (num86 < 300L)
								{
									break;
								}
								if (num86 > characterAccountConfig.int_101[4] && Class72.smethod_3(characterAccountConfig))
								{
									long_3 = Class11.smethod_27();
									break;
								}
							}
							for (int num87 = 0; num87 < Class56.int_0; num87++)
							{
								Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array3, 1, ref int_6);
								if (array3[0] == 0)
								{
									break;
								}
								Thread.Sleep(1);
							}
							if (!characterAccountConfig.bool_22)
							{
								bool flag19 = characterAccountConfig.int_128[0] > 0 && characterAccountConfig.int_128[1] > 0 && characterAccountConfig.int_128[2] > 0;
								bool flag20 = characterAccountConfig.int_128[0] > 0 && characterAccountConfig.int_128[3] > 0 && characterAccountConfig.int_128[4] > 0;
								bool flag21 = characterAccountConfig.int_128[0] > 0 && characterAccountConfig.int_128[5] > 0 && characterAccountConfig.int_128[6] > 0;
								flag12 = (flag19 || flag20 || flag21) && characterAccountConfig.string_23 == "DUONGMON";
								if (FormDame.int_6 <= 0 || characterAccountConfig.int_126 != 0 || flag12)
								{
									goto IL_2de3;
								}
								if (flag13 || FormDame.int_10 > 0)
								{
									num69 = 0;
									if (FormDame.int_9 == 0)
									{
										goto IL_2a10;
									}
									bool flag22 = Class46.characterSyncSnapshot_0.int_8 == 1 || (flag14 && Class46.characterSyncSnapshot_1.int_8 == 1);
									if (FormDame.int_9 != 1)
									{
										if (FormDame.int_9 != 2 || flag22)
										{
											goto IL_29db;
										}
										if (num17 > 0)
										{
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
										}
										num17 = 0;
									}
									else
									{
										if (flag22)
										{
											goto IL_2a10;
										}
										if (FormDame.int_11 > 0)
										{
											goto IL_29db;
										}
										if (num17 > 0)
										{
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
										}
										num17 = 0;
									}
								}
							}
							else if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0)
							{
								Class64.smethod_29(characterAccountConfig, bool_0: false);
							}
							goto IL_3fdc;
							IL_230a:
							flag8 = num57 > 40000L;
							Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
							num17 = 0;
							if (uint_2 == null)
							{
								uint_2 = new uint[2]
								{
									uint_3[0],
									uint_3[1]
								};
								int_1 = 0;
							}
							if (int_1 > 6)
							{
								long num88 = Class64.smethod_18(uint_2, uint_3);
								uint_2 = null;
								if (num88 < 180000L)
								{
									Class13.smethod_2(characterAccountConfig, bool_0: false);
									Class64.smethod_2(characterAccountConfig, uint_3, Class46.characterSyncSnapshot_0.uint_4, 600);
									goto IL_3fdc;
								}
								int_1 = 0;
							}
							if (num57 > Form1.int_108 * Form1.int_108)
							{
								Class64.smethod_29(characterAccountConfig, bool_0: false);
							}
							if (num57 < 900000L && num9 < 6)
							{
								num9++;
								Class13.smethod_2(characterAccountConfig, bool_0: false);
								Class75.smethod_61(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4);
								Thread.Sleep(150);
								goto IL_3fdc;
							}
							if (Class46.characterSyncSnapshot_0.uint_4 != null && (!Class13.smethod_3(characterAccountConfig) || Class11.smethod_28(long_) > 4000L))
							{
								Class13.smethod_1(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4);
								long_ = Class11.smethod_27();
								int_1++;
								num9 = 0;
							}
							break;
							IL_1128:
							string text7 = string_;
							int num89 = 0;
							num6++;
							if (num6 > 3)
							{
								if (Form1.int_114 > 0)
								{
									text7 = string_2;
								}
								if (num6 > 6)
								{
									num6 = 0;
								}
							}
							text7 = text7.ToLower();
							while (true)
							{
								if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) != 0)
								{
									Class47.smethod_3(characterAccountConfig);
									Thread.Sleep(450);
								}
								string text8 = null;
								int num90 = Class95.smethod_0(characterAccountConfig);
								int num91 = Class95.smethod_1(characterAccountConfig, num90);
								int num92 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
								for (int num93 = 0; num93 < array9.Length; num93++)
								{
									string object_2 = array9[num93].ToLower();
									num32 = 0;
									while (num32 < num91)
									{
										string text9 = Class95.smethod_3(characterAccountConfig, num32, num90, 128);
										if (num32 == 0)
										{
											text8 = text9;
										}
										string string_9 = text9.ToLower();
										if (Class11.smethod_1(string_9, object_2) < 0)
										{
											num32++;
											continue;
										}
										goto IL_1217;
									}
									continue;
									IL_1217:
									Class95.smethod_5(characterAccountConfig, num32);
									int num94 = 0;
									while (num94 < 8)
									{
										Thread.Sleep(100);
										if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) != 0)
										{
											Class47.smethod_3(characterAccountConfig);
											Thread.Sleep(450);
										}
										int num95 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
										if (num92 == num95)
										{
											int num96 = Class95.smethod_0(characterAccountConfig);
											if (0 <= num96)
											{
												int num97 = Class95.smethod_1(characterAccountConfig, num96);
												if (num90 != num96 || num97 != num91)
												{
													break;
												}
												string text10 = Class95.smethod_3(characterAccountConfig, 0, num96, 128);
												if (text10 != text8)
												{
													break;
												}
											}
											num94++;
											continue;
										}
										goto IL_139b;
									}
									Thread.Sleep(300);
									if (num89 != 0)
									{
										continue;
									}
									goto IL_1336;
								}
								Class95.smethod_8(characterAccountConfig);
								break;
								IL_139b:
								if (Class95.Class92.smethod_4(characterAccountConfig))
								{
									Class24.smethod_4(characterAccountConfig.uint_4, 32u);
								}
								break;
								IL_1336:
								array9 = new string[1] { text7 };
								Thread.Sleep(150);
								num89 = 1;
							}
							break;
							IL_2de3:
							if (flag13)
							{
								if (!Class46.smethod_7(characterAccountConfig, ref int_5) && Class89.smethod_12(characterAccountConfig) != 1)
								{
									num28 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
									uint_3 = new uint[2]
									{
										Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
										Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
									};
									uint[] uint_9 = uint_3;
									if (flag15 && Class46.characterSyncSnapshot_0.int_4 == num28 && Class46.characterSyncSnapshot_0.int_3 > 0 && Class46.characterSyncSnapshot_0.uint_4 != null)
									{
										uint_9 = Class46.characterSyncSnapshot_0.uint_4;
										num34 += num16;
									}
									uint num98 = 0u;
									if (Form1.int_37 > 0 && (flag14 || flag15))
									{
										if (!flag14)
										{
											if (flag15 && Class46.characterSyncSnapshot_0.int_4 == num28 && Class46.characterSyncSnapshot_0.uint_3 != num8)
											{
												num98 = Class46.characterSyncSnapshot_0.uint_3;
											}
										}
										else if (Class46.characterSyncSnapshot_1.int_4 == num28 && Class46.characterSyncSnapshot_1.uint_3 != num8)
										{
											num98 = Class46.characterSyncSnapshot_1.uint_3;
										}
										if (num98 == 0 && Form1.int_38 <= 0)
										{
											goto IL_3fdc;
										}
									}
									int[,] array23 = null;
									if (characterAccountConfig.int_119 > 0 && characterAccountConfig.int_3 != null)
									{
										array23 = ((characterAccountConfig.int_5 <= 0) ? Class72.smethod_6(characterAccountConfig, num98, num34, uint_9) : Class72.smethod_5(characterAccountConfig, num98, num34, uint_9));
										if (array23 != null && array23[0, 0] >= 0)
										{
											int num99 = -1;
											int int_13 = Class46.characterSyncSnapshot_0.int_4;
											num17 = 0;
											bool flag23 = false;
											bool flag24 = false;
											while (true)
											{
												int num100 = 0;
												int num101 = 400;
												uint num102 = 0u;
												while (num100 <= 0)
												{
													num99++;
													if (characterAccountConfig.int_3 != null && characterAccountConfig.int_3.GetLength(0) > num99 && characterAccountConfig.int_4 != null)
													{
														num100 = characterAccountConfig.int_3[num99, 0];
														if (num100 > 0)
														{
															num101 = Class83.smethod_20(characterAccountConfig, num100, characterAccountConfig.int_3[num99, 1]);
															break;
														}
														continue;
													}
													goto IL_3570;
												}
												num26 = (int)Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
												num27 = (int)Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig.int_137);
												num29 = (int)Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
												int num103 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
												if (num29 > 0 && num28 == num103 && num26 != 11 && num26 != 22 && num27 != 0)
												{
													for (int num104 = 0; num104 < array23.GetLength(0); num104++)
													{
														if (Class46.smethod_7(characterAccountConfig, ref int_5) || Class89.smethod_12(characterAccountConfig) == 1)
														{
															goto IL_3534;
														}
														int num105 = array23[num104, 0];
														num38 = array23[num104, 1];
														if (num38 <= 0)
														{
															continue;
														}
														num102 = num24 + (uint)(num38 * (int)Class56.memorySignatureScanConfig_15.uint_0);
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num102 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_6);
														if (BitConverter.ToInt32(array3, 0) <= 0)
														{
															continue;
														}
														if (num105 > 0)
														{
															Class24.ReadProcessMemory(characterAccountConfig.int_137, num102 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_6);
															if (BitConverter.ToInt32(array3, 0) <= 0)
															{
																continue;
															}
														}
														flag23 = true;
														if (!flag24 || num105 > 0)
														{
															if (num105 > 0)
															{
																flag24 = true;
															}
															if (Class3.smethod_31(characterAccountConfig, num38, num100) != 0)
															{
																continue;
															}
															num36 = num101;
															Class24.ReadProcessMemory(characterAccountConfig.int_137, num102 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array3, 4, ref int_6);
															array11[0] = BitConverter.ToUInt32(array3, 0);
															Class24.ReadProcessMemory(characterAccountConfig.int_137, num102 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array3, 4, ref int_6);
															array11[1] = BitConverter.ToUInt32(array3, 0);
															uint_3 = new uint[2]
															{
																Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
																Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
															};
															if (flag15)
															{
																uint_3 = new uint[2]
																{
																	Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
																	Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
																};
																long num106 = Class64.smethod_18(uint_3, Class46.characterSyncSnapshot_0.uint_4);
																if (int_13 != Class46.characterSyncSnapshot_0.int_4 || num106 > num16 * num16)
																{
																	goto IL_3511;
																}
																int num107 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array11));
																int num108 = (int)Math.Sqrt(Class64.smethod_18(uint_3, array11));
																int num109 = num107 - num16 + 10;
																if (num107 > num16 && num36 < num109 && (num108 > num107 || (num108 < num107 && num36 < num108)))
																{
																	num36 = num109;
																}
															}
															if (Class64.smethod_18(uint_3, array11) > num36 * num36 && characterAccountConfig.int_95 <= 0)
															{
																continue;
															}
															for (int num110 = 0; num110 < Class56.int_0; num110++)
															{
																Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array3, 1, ref int_6);
																if (array3[0] == 0)
																{
																	break;
																}
																Thread.Sleep(1);
															}
															Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(num100), 4, ref int_6);
															Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num36), 4, ref int_6);
															Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num38), 4, ref int_6);
															Thread.Sleep(10);
															num17 = 1;
															continue;
														}
														goto IL_3570;
													}
													continue;
												}
												if (num17 > 0)
												{
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
												}
												num17 = 0;
												break;
												IL_3570:
												if (num17 <= 0 && characterAccountConfig.int_6 <= 0 && flag23)
												{
													long num111 = 0L;
													uint_3 = new uint[2]
													{
														Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
														Class24.smethod_30(num25 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
													};
													num38 = -1;
													flag24 = false;
													Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_43 * 4, array3, 4, ref int_6);
													int num112 = BitConverter.ToInt32(array3, 0);
													num36 = num112;
													if (characterAccountConfig.int_95 > 0 && characterAccountConfig.int_96 > 0)
													{
														num36 = characterAccountConfig.int_96;
													}
													if (num36 <= 0)
													{
														num36 = 400;
													}
													Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_44 * 4, array3, 1, ref int_6);
													int num113 = array3[0];
													if (num113 > 0 && num36 > num112 && num112 > 0)
													{
														num36 = num112;
													}
													for (int num114 = 0; num114 < array23.GetLength(0); num114++)
													{
														int num115 = array23[num114, 0];
														int num116 = array23[num114, 1];
														int num117 = num36;
														if (num116 <= 0)
														{
															continue;
														}
														num102 = num24 + (uint)(num116 * (int)Class56.memorySignatureScanConfig_15.uint_0);
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num102 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_6);
														if (BitConverter.ToInt32(array3, 0) <= 0)
														{
															continue;
														}
														if (num115 > 0)
														{
															Class24.ReadProcessMemory(characterAccountConfig.int_137, num102 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_6);
															if (BitConverter.ToInt32(array3, 0) <= 0)
															{
																continue;
															}
														}
														if (flag24 && num115 <= 0 && num38 > 0)
														{
															break;
														}
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num102 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array3, 4, ref int_6);
														array11[0] = BitConverter.ToUInt32(array3, 0);
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num102 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array3, 4, ref int_6);
														array11[1] = BitConverter.ToUInt32(array3, 0);
														long num118 = Class64.smethod_18(uint_3, array11);
														if (num38 > 0 && num111 < num118)
														{
															continue;
														}
														if (flag15)
														{
															int num119 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array11));
															int num120 = (int)Math.Sqrt(Class64.smethod_18(uint_3, array11));
															int num121 = num119 - num16 + 10;
															if (num119 > num16 && num117 < num121 && (num120 > num119 || (num120 < num119 && num117 < num120)))
															{
																num117 = num121;
															}
														}
														if (num118 <= num117 * num117 || characterAccountConfig.int_95 > 0)
														{
															if (num115 > 0)
															{
																flag24 = true;
															}
															num38 = num116;
															num111 = num118;
															num36 = num117;
														}
													}
													if (num38 <= 0)
													{
														break;
													}
													Class64.smethod_30(characterAccountConfig);
													for (int num122 = 0; num122 < Class56.int_0; num122++)
													{
														Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array3, 1, ref int_6);
														if (array3[0] == 0)
														{
															break;
														}
														Thread.Sleep(1);
													}
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(Class83.smethod_13(characterAccountConfig)), 4, ref int_6);
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num36), 4, ref int_6);
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num38), 4, ref int_6);
												}
												else if (flag23 && num17 <= 0 && characterAccountConfig.int_6 > 0)
												{
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
												}
												break;
												IL_3511:
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
												break;
												IL_3534:
												Thread.Sleep(100);
												num17 = 0;
												break;
											}
										}
									}
									else if (flag13 = !characterAccountConfig.bool_22 && (Form1.int_35 > 0 || Form1.int_34 > 0))
									{
										array23 = Class72.smethod_5(characterAccountConfig, num98, num34, uint_9);
										if (array23 == null)
										{
											flag13 = false;
										}
										else
										{
											if (array23[0, 0] == -100)
											{
												break;
											}
											int num123 = 0;
											while (true)
											{
												if (array23[num123, 1] > 0)
												{
													array11 = new uint[2]
													{
														(uint)array23[num123, 4],
														(uint)array23[num123, 5]
													};
													if (flag15)
													{
														int num124 = (int)Math.Sqrt(Class64.smethod_18(uint_3, array11));
														int num125 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array11));
														if (num124 - num36 > 0)
														{
															if (num125 > num124)
															{
																int num126 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, uint_3));
																if (num126 + (num124 - num36) <= num16 + 10)
																{
																	goto IL_3bce;
																}
															}
															if (characterAccountConfig.int_88 == 1 && num123 == 0)
															{
																num123 = 1;
																continue;
															}
															if (num16 + num36 <= num125)
															{
																if (num17 > 0)
																{
																	Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
																}
																num17 = 0;
																break;
															}
														}
													}
													else if (Class64.smethod_18(uint_3, array11) > num36 * num36 && characterAccountConfig.int_95 <= 0)
													{
														if (characterAccountConfig.int_88 != 1 || num123 != 0)
														{
															break;
														}
														num123 = 1;
														continue;
													}
													goto IL_3bce;
												}
												if (num17 > 0)
												{
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
												}
												num17 = 0;
												break;
												IL_3bce:
												int num127 = array23[num123, 0];
												num38 = array23[num123, 1];
												_ = array23[num123, 2];
												if (Form1.int_56 > 0 && (num127 <= 0 || num127 == array2[0]) && array2[1] > 0 && array2[2] == num28 && array2[3] > 0)
												{
													int num128 = array2[0];
													int num129 = array2[1];
													uint num130 = num24 + (uint)(num129 * (int)Class56.memorySignatureScanConfig_15.uint_0);
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num130 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_6);
													if (BitConverter.ToInt32(array3, 0) > 0)
													{
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num130 + Class56.memorySignatureScanConfig_45.uint_0, array3, 4, ref int_6);
														long num131 = BitConverter.ToInt32(array3, 0);
														if ((ulong)num131 > 0uL)
														{
															Class24.ReadProcessMemory(characterAccountConfig.int_137, num130 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_6);
															if (num128 <= 0 || BitConverter.ToInt32(array3, 0) > 0)
															{
																array11 = new uint[2]
																{
																	Class24.smethod_30(num130 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
																	Class24.smethod_30(num130 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
																};
																long num132 = Class64.smethod_18(uint_3, array11);
																if (flag15)
																{
																	int num133 = (int)Math.Sqrt(num132);
																	int num134 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array11));
																	if (num133 - num36 > 0)
																	{
																		if (num134 > num133)
																		{
																			int num135 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, uint_3));
																			if (num135 + (num133 - num36) <= num16 + 10)
																			{
																				num127 = num128;
																				num38 = num129;
																			}
																		}
																	}
																	else
																	{
																		num127 = num128;
																		num38 = num129;
																	}
																}
																else if (num132 <= num36 * num36)
																{
																	num127 = num128;
																	num38 = num129;
																}
															}
														}
													}
												}
												array2[0] = num127;
												array2[1] = num38;
												array2[2] = num28;
												array2[3] = 0;
												if (num38 <= 0)
												{
													break;
												}
												array2[3] = 1;
												num17 = 1;
												num18 = 1;
												Class64.smethod_30(characterAccountConfig);
												for (int num136 = 0; num136 < Class56.int_0; num136++)
												{
													Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array3, 1, ref int_6);
													if (array3[0] == 0)
													{
														break;
													}
													Thread.Sleep(1);
												}
												if (characterAccountConfig.gstruct50_0.int_0 == 0 || Class72.smethod_10(characterAccountConfig, (uint)num38) <= 0)
												{
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(Class83.smethod_13(characterAccountConfig)), 4, ref int_6);
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num36), 4, ref int_6);
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num38), 4, ref int_6);
												}
												flag11 = characterAccountConfig.gstruct50_0.int_0 > 0 && characterAccountConfig.gstruct50_0.int_1 > 0 && characterAccountConfig.gstruct50_0.int_8 > 0 && characterAccountConfig.gstruct50_0.int_9 > 0;
												break;
											}
										}
									}
									else
									{
										flag13 = false;
									}
								}
								else
								{
									Thread.Sleep(100);
									num17 = 0;
								}
							}
							goto IL_3fdc;
							continue;
							end_IL_0400:
							break;
						}
					}
					else
					{
						if (num31 <= 1)
						{
							bool_ = false;
						}
						flag10 = num26 == 10 || num26 == 21;
						Thread.Sleep(60);
					}
				}
				else
				{
					if (num17 > 0)
					{
						Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
					}
					if (Form1.int_127 > 0)
					{
						Class24.WriteProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_251.uint_0, Class56.byte_0, Class56.byte_0.Length, ref int_6);
					}
					num17 = 0;
					num18 = 0;
				}
			}
			else
			{
				flag = false;
			}
		}
	}

	private static int smethod_1(CharacterAccountConfig characterAccountConfig_0, string string_0, ref uint[] uint_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
		Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
		Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
		Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
		Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
		_ = new uint[2]
		{
			Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
			Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
		};
		uint uint_1 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_1, array, 4, ref int_);
		int num5 = BitConverter.ToInt32(array, 0);
		if (num5 > 1)
		{
			int num6 = 0;
			string text = string_0.Trim().ToLower();
			for (uint num7 = 1u; num7 < 256; num7++)
			{
				if (num5 <= num6)
				{
					break;
				}
				uint num8 = num3 + num7 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				num6++;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
				if (BitConverter.ToInt32(array, 0) <= 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_52.uint_0, array, 4, ref int_);
				uint num9 = BitConverter.ToUInt32(array, 0);
				if (num9 == 3)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_16.uint_0, array2, array2.Length, ref int_);
					string text2 = Class1.smethod_3(array2).Trim().ToLower();
					if (!(text2 != text))
					{
						uint_0 = new uint[2];
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_);
						uint_0[0] = BitConverter.ToUInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_);
						uint_0[1] = BitConverter.ToUInt32(array, 0);
						return (int)num7;
					}
				}
			}
			return 0;
		}
		return 0;
	}

	private static string smethod_2(CharacterAccountConfig characterAccountConfig_0)
	{
		string[] array = new string[4] { "Xa Phu C«ng Thµnh", "Çu C«ng Thµnh ChiÕn", "ThÊt thµnh", "tiÕp dÉn" };
		uint[,] array2 = new uint[7, 3];
		Class10.smethod_4(array2, 363538);
		uint[,] array3 = array2;
		int int_ = 0;
		byte[] array4 = new byte[4];
		byte[] array5 = new byte[60];
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
		Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
		Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
		int num5 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
		Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
		_ = new uint[2]
		{
			Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
			Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
		};
		int num6 = -1;
		for (int i = 0; i < array3.GetLength(0); i++)
		{
			if (num5 == array3[i, 0])
			{
				num6 = i;
				break;
			}
		}
		if (num6 >= 0)
		{
			uint[] uint_ = new uint[2]
			{
				array3[num6, 1],
				array3[num6, 2]
			};
			uint uint_2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_2, array4, 4, ref int_);
			int num7 = BitConverter.ToInt32(array4, 0);
			if (num7 <= 1)
			{
				return null;
			}
			int num8 = 0;
			long num9 = 0L;
			uint[] array6 = new uint[2];
			string text = null;
			for (uint num10 = 1u; num10 < 256; num10++)
			{
				if (num7 <= num8)
				{
					break;
				}
				uint num11 = num3 + num10 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_16.uint_0, array4, 4, ref int_);
				if (array4[0] == 0)
				{
					continue;
				}
				num8++;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_52.uint_0, array4, 4, ref int_);
				uint num12 = BitConverter.ToUInt32(array4, 0);
				if (num12 != 3)
				{
					continue;
				}
				uint[] array7 = new uint[2];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array4, 4, ref int_);
				array7[0] = BitConverter.ToUInt32(array4, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array4, 4, ref int_);
				array7[1] = BitConverter.ToUInt32(array4, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_16.uint_0, array5, array5.Length, ref int_);
				string text2 = Class1.smethod_3(array5);
				string string_ = text2.ToLower();
				bool flag = false;
				for (int j = 0; j < array.Length; j++)
				{
					if (0 <= Class11.smethod_1(string_, array[j].ToLower()))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					string text3 = text2.Trim();
					if (!(text3 == "Xa phu") && text3.Length > 7)
					{
						long num13 = Class64.smethod_18(uint_, array7);
						if (num13 < 22500L && (text == null || num13 < num9))
						{
							num9 = num13;
							array6[0] = array7[0];
							array6[1] = array7[1];
							text = text2;
						}
					}
					continue;
				}
				array6[0] = array7[0];
				array6[1] = array7[1];
				text = text2;
				break;
			}
			return text;
		}
		return null;
	}
}
