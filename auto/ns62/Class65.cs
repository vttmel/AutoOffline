using System;
using System.Threading;
using ns100;
using ns109;
using ns11;
using ns111;
using ns121;
using ns13;
using ns23;
using ns27;
using ns28;
using ns29;
using ns3;
using ns35;
using ns43;
using ns50;
using ns53;
using ns56;
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

namespace ns62;

internal class Class65
{
	private static int int_0 = 0;

	public static void smethod_0(int int_1)
	{
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		long long_ = 0L;
		long long_2 = 0L;
		int num = -1;
		int num2 = 0;
		int num3 = -1;
		int num4 = -1;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		long long_3 = 0L;
		new Random();
		uint num5 = 0u;
		uint uint_ = 0u;
		uint[] uint_2 = null;
		int int_2 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int int_3 = 0;
		long num9 = 0L;
		long num10 = 0L;
		long long_4 = 0L;
		int int_4 = 0;
		int int_5 = 0;
		bool flag6 = false;
		uint[] array = null;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		int int_6 = -1;
		int[] array2 = new int[4];
		int int_7 = 0;
		byte[] byte_ = new byte[4];
		byte[] array3 = new byte[4];
		bool flag7 = false;
		bool flag8 = false;
		int num15 = 0;
		bool flag9 = false;
		int num16 = 0;
		int[] array4 = new int[10];
		for (int i = 0; i < array4.Length; i++)
		{
			array4[i] = 4;
		}
		int num17 = 0;
		while (true)
		{
			Thread.Sleep(200);
			num11 = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
			if (Class11.bool_0 || num11 < 0 || Form1.int_24 != 1)
			{
				break;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num11];
			if (!characterAccountConfig.bool_25 || characterAccountConfig.bool_54 || characterAccountConfig.int_25 > 0 || characterAccountConfig.int_133[0] > 0 || characterAccountConfig.int_20[0] > 0)
			{
				break;
			}
			if (!characterAccountConfig.bool_15 && Class75.smethod_3(characterAccountConfig, Class75.uint_48, 4) <= 0)
			{
				if (Form1.int_98 > 0 && !characterAccountConfig.bool_44 && int_0 <= 0)
				{
					int_0 = int_1;
					new Thread(smethod_1).Start();
					Thread.Sleep(300);
				}
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref array4[0]);
				uint num18 = BitConverter.ToUInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_13.uint_0, array3, 4, ref array4[1]);
				uint num19 = BitConverter.ToUInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array3, 4, ref array4[2]);
				uint num20 = BitConverter.ToUInt32(array3, 0);
				uint num21 = num19 * Class56.memorySignatureScanConfig_15.uint_0;
				uint num22 = num20 + num21;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num22, array3, 4, ref array4[3]);
				num5 = BitConverter.ToUInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_55.uint_0, array3, 4, ref array4[4]);
				int num23 = BitConverter.ToInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref array4[5]);
				int num24 = BitConverter.ToInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array3, 4, ref array4[6]);
				int num25 = BitConverter.ToInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref array4[7]);
				int num26 = BitConverter.ToInt32(array3, 0);
				num16 = 7;
				int num27 = Class89.smethod_12(characterAccountConfig);
				if ((characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0) || (num27 != 1 && num27 != 2))
				{
					if (num14 <= 0)
					{
						array2[0] = 0;
						array2[1] = 0;
						array2[2] = 0;
						array2[3] = 0;
					}
					num14 = 0;
					int num28 = Class89.smethod_39(characterAccountConfig);
					if (num24 != 0 && num23 != 0 && num25 != 0 && num23 != 10 && num23 != 21 && num28 > 1)
					{
						int num29 = 0;
						while (true)
						{
							if (num29 <= num16)
							{
								if (array4[num29] == 0)
								{
									break;
								}
								num29++;
								continue;
							}
							uint[] array5 = new uint[2]
							{
								Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
								Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
							};
							uint[] array6 = new uint[2];
							if (array5[0] == 0 || array5[1] == 0)
							{
								break;
							}
							int num31;
							int num33;
							int num34;
							bool flag10;
							bool flag12;
							bool flag11;
							long num46;
							int num32;
							if (!flag7)
							{
								if (num3 == num25)
								{
									if (num4 != num26)
									{
										uint_2 = null;
										int_2 = 0;
										int num30 = 0;
										while (num26 == 0 && num30 < 10 && num26 != num4)
										{
											Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref int_7);
											num18 = BitConverter.ToUInt32(array3, 0);
											Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_13.uint_0, array3, 4, ref int_7);
											num19 = BitConverter.ToUInt32(array3, 0);
											num21 = num19 * Class56.memorySignatureScanConfig_15.uint_0;
											Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array3, 4, ref int_7);
											num20 = BitConverter.ToUInt32(array3, 0);
											num22 = num20 + num21;
											Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_7);
											num26 = BitConverter.ToInt32(array3, 0);
											Thread.Sleep(100);
											num30++;
										}
										num4 = num26;
										Thread.Sleep(100);
										Class95.smethod_8(characterAccountConfig);
										break;
									}
									num31 = 600;
									if (characterAccountConfig.int_98 > 0)
									{
										num31 = characterAccountConfig.int_99;
									}
									if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0)
									{
										Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_43 * 4, array3, 4, ref int_7);
										characterAccountConfig.int_97 = BitConverter.ToInt32(array3, 0);
									}
									num32 = characterAccountConfig.int_97;
									if (characterAccountConfig.int_95 > 0 && characterAccountConfig.int_96 > 0)
									{
										num32 = characterAccountConfig.int_96;
									}
									if (num32 <= 0)
									{
										num32 = 500;
									}
									num12 = Form1.int_27;
									if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0)
									{
										if (num32 <= 180 && num12 < Form1.int_57)
										{
											num12 = Form1.int_57;
										}
										if (characterAccountConfig.int_131[0] > 0 && Form1.int_31 > 0 && num12 > 180)
										{
											num12 = 180;
										}
										if (flag9)
										{
											if (num26 > 0)
											{
												num12 = characterAccountConfig.gstruct50_0.int_9;
											}
											flag9 = false;
										}
									}
									array = array5;
									flag6 = false;
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_7);
									num26 = BitConverter.ToInt32(array3, 0);
									num33 = 0;
									num34 = 0;
									flag10 = false;
									flag11 = false;
									int[] array7 = Class59.smethod_0(num25);
									int num35 = Class59.smethod_2(num25);
									if (array7 == null && 0 > num35 && (Class64.smethod_9(num25) != null || Class59.smethod_1(num25) != null || 0 > Class59.smethod_3(array5, num25)))
									{
										Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_23 * 4, array3, 1, ref int_7);
										if (array3[0] > 0)
										{
											flag5 = false;
											array3[0] = 0;
											Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_23 * 4, array3, 1, ref int_7);
										}
										array3[0] = 0;
										Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_22 * 4, array3, 1, ref int_7);
										if (num25 == 221 || num25 == 539)
										{
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
											if (Class53.smethod_0(characterAccountConfig) > 0)
											{
												break;
											}
										}
										if (Class11.smethod_28(long_4) > 30000L)
										{
											Class75.smethod_52(characterAccountConfig, "<color=yellow>[*] TONG KIM - PHLT...");
											long_4 = Class11.smethod_27();
										}
										if (Form1.int_48[0] > 0)
										{
											Class59.smethod_9(int_1);
											break;
										}
										if (num26 <= 0)
										{
											Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_33 * 4, array3, 1, ref int_7);
											int num36 = array3[0];
											if (flag4 && num36 > 0)
											{
												bool value = false;
												if (num26 == 0)
												{
													value = Class98.smethod_0(characterAccountConfig, bool_0: true) != 1;
												}
												array3[0] = Convert.ToByte(value);
												Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_33 * 4, array3, 1, ref int_7);
												break;
											}
											uint num37 = num18 + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_75.uint_0;
											uint num38 = Class24.smethod_30(num37 + Class56.memorySignatureScanConfig_73.uint_0, characterAccountConfig.int_137);
											int num39 = characterAccountConfig.int_66;
											if (num39 < 2500000)
											{
												num39 = 2500000;
											}
											if (num38 < num39)
											{
												flag4 = true;
												uint num40 = Class24.smethod_30(num37 + Class56.memorySignatureScanConfig_74.uint_0, characterAccountConfig.int_137);
												if (num40 != 0)
												{
													int num41 = num39 - (int)num38;
													if (num41 > num40)
													{
														num41 = (int)num40;
													}
													if (!flag && characterAccountConfig.string_15 != null && characterAccountConfig.string_15 != string.Empty)
													{
														uint num42 = Class11.smethod_12(characterAccountConfig.string_15);
														if (num42 != 0)
														{
															Class75.smethod_117(characterAccountConfig, num42);
															flag = true;
															Thread.Sleep(300);
														}
													}
													Class75.smethod_37(characterAccountConfig, (uint)num41);
												}
											}
										}
										if (Form1.int_25 > 0 && array7 == null)
										{
											int num43 = 0;
											if ((Form1.int_10 <= 0 && Form1.int_11 <= 0) || Class59.smethod_0(Class46.characterSyncSnapshot_1.int_4) == null)
											{
												if (Class59.smethod_0(Class46.characterSyncSnapshot_0.int_4) != null)
												{
													num43 = Class46.characterSyncSnapshot_0.int_4;
												}
											}
											else
											{
												num43 = Class46.characterSyncSnapshot_1.int_4;
											}
											if (num43 > 0 && num43 != num25)
											{
												int num44 = Class29.smethod_3(num43);
												if (0 <= num44 && Class29.smethod_7(characterAccountConfig, num43))
												{
													Thread.Sleep(100);
												}
											}
										}
										if (num26 == 0)
										{
											break;
										}
									}
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_7);
									num26 = BitConverter.ToInt32(array3, 0);
									if (num26 > 0 && !flag8)
									{
										Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_7);
										num26 = BitConverter.ToInt32(array3, 0);
										if (num26 == 0)
										{
											break;
										}
										flag5 = false;
										if (array7 != null)
										{
											Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_22 * 4, array3, 1, ref int_7);
											if (array3[0] != 0)
											{
												if (Class59.uint_0 != null && Class59.uint_0[0] != 0 && Class59.uint_0[1] != 0 && Class59.uint_1 != null && Class59.uint_1[0] != 0 && Class59.uint_1[1] != 0 && Class59.int_1 == num25)
												{
													array5 = new uint[2]
													{
														Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
														Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
													};
													long num45 = Class64.smethod_18(array5, Class59.uint_1);
													if (!flag8)
													{
														Class64.smethod_29(characterAccountConfig, bool_0: false);
														if (num45 > 160000L)
														{
															if (Class11.smethod_28(long_) > 4000L)
															{
																Class13.smethod_1(characterAccountConfig, Class59.uint_1);
																long_ = Class11.smethod_27();
															}
															break;
														}
														Class13.smethod_2(characterAccountConfig, bool_0: false);
														if (!(flag8 = num45 <= 12500L))
														{
															Class75.smethod_61(characterAccountConfig, Class59.uint_1);
														}
													}
													if (flag8)
													{
														uint[] uint_3 = Class64.smethod_5(Class59.uint_0, Class59.uint_1, 1000);
														Class75.smethod_61(characterAccountConfig, uint_3);
													}
													Thread.Sleep(150);
													break;
												}
												flag8 = true;
											}
											if (flag8)
											{
												array3[0] = 0;
												Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_22 * 4, array3, 1, ref int_7);
											}
										}
										if (characterAccountConfig.int_63 > 0 && (num < 0 || num != Class85.smethod_4(characterAccountConfig)))
										{
											Class64.smethod_15(characterAccountConfig, characterAccountConfig.string_6);
											num = Class85.smethod_4(characterAccountConfig);
										}
										flag12 = (Form1.int_10 > 0 || Form1.int_11 > 0) && Form1.int_25 > 0 && (Class46.characterSyncSnapshot_1.int_3 > 0 || Form1.int_26 > 0) && Class46.characterSyncSnapshot_1.int_4 > 0 && Class11.smethod_63(Class46.characterSyncSnapshot_1.uint_4) && (characterAccountConfig.int_136 == Class46.characterSyncSnapshot_0.int_0 || Class46.characterSyncSnapshot_0.int_0 <= 0);
										flag2 = Form1.int_25 > 0 && Class46.characterSyncSnapshot_0.int_0 > 0 && Class46.characterSyncSnapshot_0.int_0 != characterAccountConfig.int_136 && Class46.characterSyncSnapshot_0.int_6 > 0 && Class46.characterSyncSnapshot_0.int_4 == num25 && Class11.smethod_63(Class46.characterSyncSnapshot_0.uint_4) && Class46.characterSyncSnapshot_0.int_3 > 0;
										flag11 = !characterAccountConfig.bool_22 && (Form1.int_35 > 0 || Form1.int_34 > 0);
										array5 = new uint[2]
										{
											Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
											Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
										};
										if (flag2 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0)
										{
											array5 = new uint[2]
											{
												Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
												Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
											};
											num46 = Class64.smethod_18(array5, Class46.characterSyncSnapshot_0.uint_4);
											if (characterAccountConfig.int_130[0] > 0 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && num26 == Class46.characterSyncSnapshot_0.int_3 && num26 > 0)
											{
												int num47 = characterAccountConfig.int_130[1] + Form1.int_27;
												if (num46 <= num47 * num47 && Class68.smethod_0(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4, characterAccountConfig.int_130[1]) > 0)
												{
													goto IL_2d8e;
												}
											}
											if (flag3 || num46 > num12 * num12)
											{
												goto IL_10f4;
											}
											Class13.smethod_2(characterAccountConfig, bool_0: false);
											int num48 = num6;
											num6 = 0;
											int_2 = 0;
											num17 = 0;
											if (num26 > 0 && !characterAccountConfig.bool_22 && characterAccountConfig.int_93 == 1 && Form1.int_109 > 0 && (Form1.int_35 > 0 || Form1.int_34 > 0 || Form1.int_36 > 0) && Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137) != 0)
											{
												Class64.smethod_30(characterAccountConfig);
											}
											if (num10 <= 0L || Class11.smethod_28(num10) >= 1500L)
											{
												uint[] uint_4 = new uint[2]
												{
													array5[0],
													array5[1]
												};
												if (Class46.smethod_5(num5, ref array5, ref uint_) > 0)
												{
													long num49 = Class64.smethod_18(uint_4, Class46.characterSyncSnapshot_0.uint_4);
													long num50 = Class64.smethod_18(array5, Class46.characterSyncSnapshot_0.uint_4);
													if (num50 > num12 * num12)
													{
														if (num48 > 0)
														{
															uint[] uint_5 = Class64.smethod_5(array5, Class46.characterSyncSnapshot_0.uint_4, -100);
															Class75.smethod_61(characterAccountConfig, uint_5);
															Thread.Sleep(120);
														}
														goto IL_10f4;
													}
													num10 = Class11.smethod_27();
													if (num13 > 0)
													{
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
													}
													num13 = 0;
													Class46.smethod_6(characterAccountConfig, array5, Class46.characterSyncSnapshot_0.uint_4, num49 <= 5625L);
													goto IL_2d1f;
												}
												num10 = 0L;
												if (num13 == 0 && Class64.smethod_18(uint_4, Class46.characterSyncSnapshot_0.uint_4) > Form1.int_27 * Form1.int_27)
												{
													num7++;
													if (num7 > 3)
													{
														Class75.smethod_61(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4);
														Thread.Sleep(150);
														num7 = 0;
													}
												}
												if (Form1.int_31 > 0 && num26 > 0 && characterAccountConfig.int_131[0] > 0 && Class75.smethod_3(characterAccountConfig, Class75.uint_31, 4) == 0)
												{
													Class75.smethod_2(characterAccountConfig, Class75.uint_31, 1, 4);
												}
											}
											int_2 = 0;
											uint_2 = null;
											array = Class46.characterSyncSnapshot_0.uint_4;
											flag6 = true;
										}
										else
										{
											if (characterAccountConfig.int_68 != null && characterAccountConfig.int_68[0] > 0 && !AuxiliaryMachineManager.bool_3)
											{
												uint[] array8 = null;
												if (num9 <= 0L || Class11.smethod_28(num9) >= 1000L)
												{
													array8 = Class64.smethod_26(characterAccountConfig, ref int_3);
													if (array8 != null)
													{
														num9 = 0L;
														long num51 = Class64.smethod_18(array5, array8);
														if (num51 < 8000L)
														{
															goto IL_1615;
														}
														if (num51 >= 15000L && num51 >= characterAccountConfig.int_68[1] * characterAccountConfig.int_68[1])
														{
															if (num51 < 360000L)
															{
																Class13.smethod_2(characterAccountConfig, bool_0: false);
																if (num13 > 0)
																{
																	Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
																}
																num13 = 0;
																Class75.smethod_61(characterAccountConfig, array8);
																Thread.Sleep(150);
																break;
															}
															if (num51 < 1200000L)
															{
																if (Class11.smethod_28(long_) > 3000L)
																{
																	Class13.smethod_1(characterAccountConfig, array8);
																	long_ = Class11.smethod_27();
																}
																break;
															}
														}
														else
														{
															if (num23 <= 3 && num51 > 7500L)
															{
																if (num13 > 0)
																{
																	Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
																}
																num13 = 0;
																Class75.smethod_61(characterAccountConfig, array8);
																Thread.Sleep(150);
																goto IL_2d1f;
															}
															num51 = 4L;
														}
													}
													else
													{
														num9 = Class11.smethod_27();
													}
												}
											}
											if (flag12)
											{
												int num52 = AuxiliaryMachineManager.smethod_10(characterAccountConfig, ref long_, ref int_2, ref uint_2);
												if (num52 <= 0)
												{
													Thread.Sleep(100);
													break;
												}
												num23 = (int)Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
												if (num23 < 3)
												{
													array5 = new uint[2]
													{
														Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
														Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
													};
													if (Class64.smethod_18(array5, Class46.characterSyncSnapshot_1.uint_4) > 5625L)
													{
														if (num13 > 0)
														{
															Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
														}
														num13 = 0;
														Class75.smethod_61(characterAccountConfig, Class46.characterSyncSnapshot_1.uint_4);
														Thread.Sleep(150);
													}
												}
											}
										}
										goto IL_1615;
									}
									array3[0] = 0;
									Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_22 * 4, array3, 1, ref int_7);
									if (characterAccountConfig.int_136 == Class46.characterSyncSnapshot_0.int_0 && Form1.int_94 <= 0 && ((Form1.int_10 <= 0 && Form1.int_11 <= 0) || Class46.characterSyncSnapshot_1.int_4 <= 0))
									{
										Thread.Sleep(300);
										break;
									}
									if (Form1.int_97 <= 0 && (!flag5 || flag8 || num < 0 || num != Class85.smethod_4(characterAccountConfig)))
									{
										if (!Form1.bool_18)
										{
											num2++;
											int num53 = Class59.smethod_7(characterAccountConfig);
											if (num53 <= 0 && num2 < 6)
											{
												Class64.smethod_13(characterAccountConfig);
												Thread.Sleep(300);
												break;
											}
										}
										num17 = 0;
										num2 = 0;
										flag5 = true;
										flag8 = false;
										num = Class85.smethod_4(characterAccountConfig);
										uint num54 = 1500000u;
										uint num55 = num18 + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_75.uint_0;
										uint num56 = Class24.smethod_30(num55 + Class56.memorySignatureScanConfig_73.uint_0, characterAccountConfig.int_137);
										uint num57 = Class24.smethod_30(num55 + Class56.memorySignatureScanConfig_74.uint_0, characterAccountConfig.int_137);
										if (num56 <= 1500000)
										{
											if (num57 == 0 || num56 >= num54 / 2)
											{
												break;
											}
											int num58 = (int)(num54 - num56);
											if (num58 > num57)
											{
												num58 = (int)num57;
											}
											if (!flag && characterAccountConfig.string_15 != null && characterAccountConfig.string_15 != string.Empty)
											{
												uint num59 = Class11.smethod_12(characterAccountConfig.string_15);
												if (num59 != 0)
												{
													Class75.smethod_117(characterAccountConfig, num59);
													flag = true;
													Thread.Sleep(300);
												}
											}
											Class75.smethod_37(characterAccountConfig, (uint)num58);
										}
										else
										{
											Class75.smethod_38(characterAccountConfig, num56 - num54);
										}
										break;
									}
									flag8 = false;
									if (Form1.int_25 <= 0 || Class46.characterSyncSnapshot_0.int_0 <= 0)
									{
									}
									bool flag13 = Form1.int_25 > 0 && (Form1.int_10 > 0 || Form1.int_11 > 0);
									if (0 > num35)
									{
										Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array3, 4, ref int_7);
										num25 = BitConverter.ToInt32(array3, 0);
										num17 = 0;
										if (Form1.int_25 > 0)
										{
											if (Form1.int_95 > 0 && Class46.characterSyncSnapshot_0.int_0 != characterAccountConfig.int_136 && (Class46.characterSyncSnapshot_0.int_0 == 0 || (Class46.characterSyncSnapshot_0.int_0 > 0 && Class46.characterSyncSnapshot_0.int_3 == 0)))
											{
												break;
											}
											if (Form1.int_96 > 0)
											{
												string[] array9 = new string[2];
												if (Form1.int_99 > 0 && (Class46.characterSyncSnapshot_0.int_0 != characterAccountConfig.int_136 || flag13))
												{
													uint[] uint_6 = Class46.characterSyncSnapshot_0.uint_4;
													if (flag13)
													{
														uint_6 = Class46.characterSyncSnapshot_1.uint_4;
													}
													array9 = Class59.smethod_5(num25, uint_6);
												}
												num17 = Class59.smethod_4(characterAccountConfig, array9[0], array9[1]);
											}
											if (num17 <= 0)
											{
												num17 = Class59.smethod_6(characterAccountConfig);
											}
											if (0 <= Class95.smethod_0(characterAccountConfig))
											{
												Class95.smethod_5(characterAccountConfig, 0);
												Thread.Sleep(100);
											}
										}
										if (num17 == 2 && Class11.smethod_28(long_4) > 10000L)
										{
											Class75.smethod_52(characterAccountConfig, Class11.smethod_54(Class11.string_0));
											long_4 = Class11.smethod_27();
										}
									}
									else if ((characterAccountConfig.int_136 == Class46.characterSyncSnapshot_0.int_0 && (Form1.int_94 > 0 || ((Form1.int_10 > 0 || Form1.int_11 > 0) && Class46.characterSyncSnapshot_1.int_4 > 0))) || (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && (Form1.int_95 <= 0 || Class46.characterSyncSnapshot_0.int_3 > 0)))
									{
										Class64.smethod_22(characterAccountConfig, Class59.uint_3, null, null, num25);
									}
									break;
								}
								flag5 = false;
								flag = false;
								uint_2 = null;
								int_2 = 0;
								num17 = 0;
								int num60 = 0;
								int num61 = 0;
								while (num3 != num25 && num60 < 15)
								{
									num60++;
									Thread.Sleep(100);
									Class89.smethod_39(characterAccountConfig);
									Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref int_7);
									num18 = BitConverter.ToUInt32(array3, 0);
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_13.uint_0, array3, 4, ref int_7);
									num19 = BitConverter.ToUInt32(array3, 0);
									num21 = num19 * Class56.memorySignatureScanConfig_15.uint_0;
									Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array3, 4, ref int_7);
									num20 = BitConverter.ToUInt32(array3, 0);
									num22 = num20 + num21;
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_7);
									num24 = BitConverter.ToInt32(array3, 0);
									Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array3, 4, ref int_7);
									num25 = BitConverter.ToInt32(array3, 0);
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_7);
									num26 = BitConverter.ToInt32(array3, 0);
									Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
									num13 = 0;
									if (num28 > 1 && num24 > 0 && num25 > 0 && num23 > 0)
									{
										if (num26 > 0 || num61 > 3)
										{
											break;
										}
										num61++;
									}
									else
									{
										num61 = 0;
									}
								}
								num3 = num25;
								break;
							}
							flag7 = false;
							num17 = 0;
							Thread.Sleep(300);
							break;
							IL_1615:
							if (characterAccountConfig.int_101[0] > 0 && characterAccountConfig.int_101[1] > 0 && characterAccountConfig.string_23 == "NGAMY")
							{
								long num62 = Class11.smethod_28(long_2);
								if (num62 < 300L)
								{
									break;
								}
								if (num62 > characterAccountConfig.int_101[4] && Class72.smethod_3(characterAccountConfig))
								{
									Thread.Sleep(80);
									long_2 = Class11.smethod_27();
									break;
								}
							}
							for (num15 = 0; num15 < Class56.int_0; num15++)
							{
								Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array3, 1, ref int_7);
								if (array3[0] == 0)
								{
									break;
								}
								Thread.Sleep(1);
							}
							int num63;
							if (characterAccountConfig.bool_22)
							{
								if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0)
								{
									Class64.smethod_29(characterAccountConfig, bool_0: false);
								}
							}
							else
							{
								bool flag14 = characterAccountConfig.int_128[0] > 0 && characterAccountConfig.int_128[1] > 0 && characterAccountConfig.int_128[2] > 0;
								bool flag15 = characterAccountConfig.int_128[0] > 0 && characterAccountConfig.int_128[3] > 0 && characterAccountConfig.int_128[4] > 0;
								bool flag16 = characterAccountConfig.int_128[0] > 0 && characterAccountConfig.int_128[5] > 0 && characterAccountConfig.int_128[6] > 0;
								flag10 = (flag14 || flag15 || flag16) && characterAccountConfig.string_23 == "DUONGMON";
								if (FormDame.int_6 <= 0 || characterAccountConfig.int_126 != 0 || flag10)
								{
									goto IL_1c3a;
								}
								if (flag11 || FormDame.int_10 > 0)
								{
									num63 = 0;
									if (FormDame.int_9 == 0)
									{
										goto IL_186f;
									}
									bool flag17 = Class46.characterSyncSnapshot_0.int_8 == 1 || (flag12 && Class46.characterSyncSnapshot_1.int_8 == 1);
									if (FormDame.int_9 == 1)
									{
										if (flag17)
										{
											goto IL_186f;
										}
										if (FormDame.int_11 > 0)
										{
											goto IL_183a;
										}
										if (num13 > 0)
										{
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
										}
										num13 = 0;
									}
									else
									{
										if (FormDame.int_9 != 2 || flag17)
										{
											goto IL_183a;
										}
										if (num13 > 0)
										{
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
										}
										num13 = 0;
									}
								}
							}
							goto IL_2d1f;
							IL_186f:
							uint num64 = 0u;
							uint[] array10 = null;
							uint[] uint_7 = null;
							if (!flag12)
							{
								if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136 && Class46.characterSyncSnapshot_0.uint_5 != 0)
								{
									uint num65 = Class46.characterSyncSnapshot_0.uint_5 >> 16;
									uint num66 = Class46.characterSyncSnapshot_0.uint_5 - (num65 << 16);
									array10 = Class89.smethod_11(Class46.characterSyncSnapshot_0.uint_4, (int)num66, (int)num65);
									uint[] array11 = Class89.smethod_10(array5, array10);
									num64 = (array11[1] << 16) + array11[0];
									uint_7 = Class46.characterSyncSnapshot_0.uint_4;
									Class89.smethod_7(characterAccountConfig, num64);
									Thread.Sleep(10);
								}
							}
							else
							{
								uint num67 = Class46.characterSyncSnapshot_1.uint_5 >> 16;
								uint num68 = Class46.characterSyncSnapshot_1.uint_5 - (num67 << 16);
								array10 = Class89.smethod_11(Class46.characterSyncSnapshot_1.uint_4, (int)num68, (int)num67);
								uint[] array12 = Class89.smethod_10(array5, array10);
								num64 = (array12[1] << 16) + array12[0];
								uint_7 = Class46.characterSyncSnapshot_1.uint_4;
								Class89.smethod_7(characterAccountConfig, num64);
								Thread.Sleep(10);
							}
							Class64.smethod_30(characterAccountConfig);
							if (characterAccountConfig.int_127[0] != 2)
							{
								if (characterAccountConfig.int_127[0] == 0)
								{
									bool flag18 = characterAccountConfig.int_127[1] > 0 && characterAccountConfig.int_127[2] > 0;
									bool flag19 = characterAccountConfig.int_127[3] > 0 && characterAccountConfig.int_127[4] > 0;
									if (flag18 && !flag19)
									{
										num63 = characterAccountConfig.int_127[2];
									}
									else if (flag19 && !flag18)
									{
										num63 = characterAccountConfig.int_127[4];
									}
									else if (flag18 && flag19)
									{
										num63 = ((0 > num8 || num8 > 25) ? characterAccountConfig.int_127[4] : characterAccountConfig.int_127[2]);
										if (num8 > 35)
										{
											num8 = 0;
										}
										num8++;
									}
								}
								if (num63 <= 0)
								{
									num63 = Class83.smethod_13(characterAccountConfig);
								}
								if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 || Form1.int_10 > 0 || Form1.int_11 > 0)
								{
									Class83.smethod_9(characterAccountConfig);
								}
								Class83.smethod_5(characterAccountConfig, num63, 6, 1);
								for (int j = 0; j < 3; j++)
								{
									if (FormDame.int_14 > 0)
									{
										Class24.smethod_76(characterAccountConfig.uint_4, 32);
									}
									else
									{
										Class24.smethod_76(characterAccountConfig.uint_4, 117);
									}
									if (j < 2)
									{
										Thread.Sleep(60);
									}
								}
							}
							else
							{
								Class64.smethod_0(characterAccountConfig.uint_4, characterAccountConfig.int_129, FormDame.int_12);
							}
							if (num64 != 0 && characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136)
							{
								if (characterAccountConfig.int_95 <= 0)
								{
									Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_31.uint_0, characterAccountConfig.int_137);
									int num69 = Class83.smethod_13(characterAccountConfig);
									if (num69 == 53 || num69 <= 1)
									{
										goto IL_2d1f;
									}
									if (num69 <= 100)
									{
										num69 = 400;
									}
								}
								string string_ = Class89.smethod_20(characterAccountConfig);
								if (Class11.smethod_2(string_, "iÓm qu\u00b8 x"))
								{
									uint[] array13 = Class64.smethod_5(uint_7, array10, -1 * (Form1.int_27 - 50));
									long num70 = Class64.smethod_18(array5, array13);
									if (num70 > 7000L)
									{
										Class75.smethod_61(characterAccountConfig, array13);
										Thread.Sleep(150);
										Class89.smethod_21(characterAccountConfig, "0K..");
									}
								}
							}
							goto IL_2d1f;
							IL_1c3a:
							if (flag11)
							{
								if (!Class46.smethod_7(characterAccountConfig, ref int_6) && Class89.smethod_12(characterAccountConfig) != 1)
								{
									num25 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
									array5 = new uint[2]
									{
										Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
										Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
									};
									uint[] uint_8 = array5;
									if (flag2 && Class46.characterSyncSnapshot_0.int_4 == num25 && Class46.characterSyncSnapshot_0.int_3 > 0 && Class46.characterSyncSnapshot_0.uint_4 != null)
									{
										uint_8 = Class46.characterSyncSnapshot_0.uint_4;
										num31 += num12;
									}
									uint num71 = 0u;
									if (Form1.int_37 > 0 && (flag12 || flag2))
									{
										if (flag12)
										{
											if (Class46.characterSyncSnapshot_1.int_4 == num25 && Class46.characterSyncSnapshot_1.uint_3 != num5)
											{
												num71 = Class46.characterSyncSnapshot_1.uint_3;
											}
										}
										else if (flag2 && Class46.characterSyncSnapshot_0.int_4 == num25 && Class46.characterSyncSnapshot_0.uint_3 != num5)
										{
											num71 = Class46.characterSyncSnapshot_0.uint_3;
										}
										if (num71 == 0 && Form1.int_38 <= 0)
										{
											goto IL_2d1f;
										}
									}
									int[,] array14 = null;
									if (characterAccountConfig.int_119 > 0 && characterAccountConfig.int_3 != null)
									{
										array14 = ((characterAccountConfig.int_5 > 0) ? Class72.smethod_5(characterAccountConfig, num71, num31, uint_8, null, bool_1: false, Form1.int_101 > 0) : Class72.smethod_6(characterAccountConfig, num71, num31, uint_8, null, bool_1: false, Form1.int_101 > 0));
										if (array14 != null && array14[0, 0] >= 0)
										{
											int num72 = -1;
											int int_8 = Class46.characterSyncSnapshot_0.int_4;
											num13 = 0;
											bool flag20 = false;
											bool flag21 = false;
											while (true)
											{
												int num73 = 0;
												int num74 = 400;
												uint num75 = 0u;
												while (num73 <= 0)
												{
													num72++;
													if (characterAccountConfig.int_3 != null && characterAccountConfig.int_3.GetLength(0) > num72 && characterAccountConfig.int_4 != null)
													{
														num73 = characterAccountConfig.int_3[num72, 0];
														if (num73 > 0)
														{
															num74 = Class83.smethod_20(characterAccountConfig, num73, characterAccountConfig.int_3[num72, 1]);
															break;
														}
														continue;
													}
													goto IL_2363;
												}
												num23 = (int)Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
												num24 = (int)Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig.int_137);
												num26 = (int)Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
												int num76 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
												if (num26 > 0 && num25 == num76 && num23 != 11 && num23 != 22 && num24 != 0)
												{
													for (int k = 0; k < array14.GetLength(0); k++)
													{
														if (Class46.smethod_7(characterAccountConfig, ref int_6) || Class89.smethod_12(characterAccountConfig) == 1)
														{
															goto IL_2327;
														}
														num33 = array14[k, 0];
														num34 = array14[k, 1];
														if (num34 <= 0)
														{
															continue;
														}
														num75 = num20 + (uint)(num34 * (int)Class56.memorySignatureScanConfig_15.uint_0);
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num75 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_7);
														if (BitConverter.ToInt32(array3, 0) <= 0)
														{
															continue;
														}
														if (num33 > 0)
														{
															Class24.ReadProcessMemory(characterAccountConfig.int_137, num75 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_7);
															if (BitConverter.ToInt32(array3, 0) <= 0)
															{
																continue;
															}
														}
														flag20 = true;
														if (!flag21 || num33 > 0)
														{
															if (num33 > 0)
															{
																flag21 = true;
															}
															if (Class3.smethod_31(characterAccountConfig, num34, num73) != 0)
															{
																continue;
															}
															num32 = num74;
															Class24.ReadProcessMemory(characterAccountConfig.int_137, num75 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array3, 4, ref int_7);
															array6[0] = BitConverter.ToUInt32(array3, 0);
															Class24.ReadProcessMemory(characterAccountConfig.int_137, num75 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array3, 4, ref int_7);
															array6[1] = BitConverter.ToUInt32(array3, 0);
															array5 = new uint[2]
															{
																Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
																Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
															};
															if (flag2)
															{
																array5 = new uint[2]
																{
																	Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
																	Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
																};
																long num77 = Class64.smethod_18(array5, Class46.characterSyncSnapshot_0.uint_4);
																if (int_8 != Class46.characterSyncSnapshot_0.int_4 || num77 > num12 * num12)
																{
																	goto IL_2304;
																}
																int num78 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array6));
																int num79 = (int)Math.Sqrt(Class64.smethod_18(array5, array6));
																int num80 = num78 - num12 + 10;
																if (num78 > num12 && num32 < num80 && (num79 > num78 || (num79 < num78 && num32 < num79)))
																{
																	num32 = num80;
																}
															}
															if (Class64.smethod_18(array5, array6) > num32 * num32 && characterAccountConfig.int_95 <= 0)
															{
																continue;
															}
															for (num15 = 0; num15 < Class56.int_0; num15++)
															{
																Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array3, 1, ref int_7);
																if (array3[0] == 0)
																{
																	break;
																}
																Thread.Sleep(1);
															}
															Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(num73), 4, ref int_7);
															Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num32), 4, ref int_7);
															Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num34), 4, ref int_7);
															Thread.Sleep(10);
															num13 = 1;
															continue;
														}
														goto IL_2363;
													}
													continue;
												}
												if (num13 > 0)
												{
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
												}
												num13 = 0;
												break;
												IL_2363:
												if (num13 <= 0 && characterAccountConfig.int_6 <= 0 && flag20)
												{
													long num81 = 0L;
													array5 = new uint[2]
													{
														Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
														Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
													};
													num33 = -1;
													num34 = -1;
													flag21 = false;
													num32 = characterAccountConfig.int_97;
													if (characterAccountConfig.int_95 > 0 && characterAccountConfig.int_96 > 0)
													{
														num32 = characterAccountConfig.int_96;
													}
													if (num32 <= 0)
													{
														num32 = 500;
													}
													for (int l = 0; l < array14.GetLength(0); l++)
													{
														int num82 = array14[l, 0];
														int num83 = array14[l, 1];
														int num84 = num32;
														if (num83 <= 0)
														{
															continue;
														}
														num75 = num20 + (uint)(num83 * (int)Class56.memorySignatureScanConfig_15.uint_0);
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num75 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_7);
														if (BitConverter.ToInt32(array3, 0) <= 0)
														{
															continue;
														}
														if (num82 > 0)
														{
															Class24.ReadProcessMemory(characterAccountConfig.int_137, num75 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_7);
															if (BitConverter.ToInt32(array3, 0) <= 0)
															{
																continue;
															}
														}
														if (flag21 && num82 <= 0 && num34 > 0)
														{
															break;
														}
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num75 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array3, 4, ref int_7);
														array6[0] = BitConverter.ToUInt32(array3, 0);
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num75 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array3, 4, ref int_7);
														array6[1] = BitConverter.ToUInt32(array3, 0);
														long num85 = Class64.smethod_18(array5, array6);
														if (num34 > 0 && num81 < num85)
														{
															continue;
														}
														if (flag2)
														{
															int num86 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array6));
															int num87 = (int)Math.Sqrt(Class64.smethod_18(array5, array6));
															int num88 = num86 - num12 + 10;
															if (num86 > num12 && num84 < num88 && (num87 > num86 || (num87 < num86 && num84 < num87)))
															{
																num84 = num88;
															}
														}
														if (num85 <= num84 * num84 || characterAccountConfig.int_95 > 0)
														{
															if (num82 > 0)
															{
																flag21 = true;
															}
															num34 = num83;
															num33 = num82;
															num81 = num85;
															num32 = num84;
														}
													}
													if (num34 <= 0)
													{
														break;
													}
													Class64.smethod_30(characterAccountConfig);
													for (num15 = 0; num15 < Class56.int_0; num15++)
													{
														Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array3, 1, ref int_7);
														if (array3[0] == 0)
														{
															break;
														}
														Thread.Sleep(1);
													}
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(Class83.smethod_13(characterAccountConfig)), 4, ref int_7);
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num32), 4, ref int_7);
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num34), 4, ref int_7);
												}
												else if (flag20 && num13 <= 0 && characterAccountConfig.int_6 > 0)
												{
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
												}
												break;
												IL_2304:
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
												break;
												IL_2327:
												Thread.Sleep(100);
												num13 = 0;
												break;
											}
										}
									}
									else if (!(flag11 = !characterAccountConfig.bool_22 && (Form1.int_35 > 0 || Form1.int_34 > 0)))
									{
										flag11 = false;
									}
									else
									{
										array14 = Class72.smethod_5(characterAccountConfig, num71, num31, uint_8, null, bool_1: false, Form1.int_101 > 0);
										if (array14 != null)
										{
											if (array14[0, 0] == -100)
											{
												break;
											}
											int num89 = 0;
											while (true)
											{
												if (array14[num89, 1] > 0)
												{
													array6 = new uint[2]
													{
														(uint)array14[num89, 4],
														(uint)array14[num89, 5]
													};
													if (!flag2)
													{
														if (Class64.smethod_18(array5, array6) > num32 * num32 && characterAccountConfig.int_95 <= 0)
														{
															if (characterAccountConfig.int_88 != 1 || num89 != 0)
															{
																break;
															}
															num89 = 1;
															continue;
														}
													}
													else
													{
														int num90 = (int)Math.Sqrt(Class64.smethod_18(array5, array6));
														int num91 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array6));
														if (num90 - num32 > 0)
														{
															if (num91 > num90)
															{
																int num92 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array5));
																if (num92 + (num90 - num32) <= num12 + 10)
																{
																	goto IL_2939;
																}
															}
															if (characterAccountConfig.int_88 == 1 && num89 == 0)
															{
																num89 = 1;
																continue;
															}
															if (num12 + num32 <= num91)
															{
																if (num13 > 0)
																{
																	Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
																}
																num13 = 0;
																break;
															}
														}
													}
													goto IL_2939;
												}
												if (num13 > 0)
												{
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
												}
												num13 = 0;
												break;
												IL_2939:
												num33 = array14[num89, 0];
												num34 = array14[num89, 1];
												_ = array14[num89, 2];
												if (Form1.int_56 > 0 && (num33 <= 0 || num33 == array2[0]) && array2[1] > 0 && array2[2] == num25 && array2[3] > 0)
												{
													int num93 = array2[0];
													int num94 = array2[1];
													uint num95 = num20 + (uint)(num94 * (int)Class56.memorySignatureScanConfig_15.uint_0);
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num95 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_7);
													if (BitConverter.ToInt32(array3, 0) > 0)
													{
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num95 + Class56.memorySignatureScanConfig_45.uint_0, array3, 4, ref int_7);
														long num96 = BitConverter.ToInt32(array3, 0);
														if ((ulong)num96 > 0uL)
														{
															Class24.ReadProcessMemory(characterAccountConfig.int_137, num95 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_7);
															if (num93 <= 0 || BitConverter.ToInt32(array3, 0) > 0)
															{
																array6 = new uint[2]
																{
																	Class24.smethod_30(num95 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
																	Class24.smethod_30(num95 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
																};
																long num97 = Class64.smethod_18(array5, array6);
																if (!flag2)
																{
																	if (num97 <= num32 * num32)
																	{
																		num33 = num93;
																		num34 = num94;
																	}
																}
																else
																{
																	int num98 = (int)Math.Sqrt(num97);
																	int num99 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array6));
																	if (num98 - num32 <= 0)
																	{
																		num33 = num93;
																		num34 = num94;
																	}
																	else if (num99 > num98)
																	{
																		int num100 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array5));
																		if (num100 + (num98 - num32) <= num12 + 10)
																		{
																			num33 = num93;
																			num34 = num94;
																		}
																	}
																}
															}
														}
													}
												}
												array2[0] = num33;
												array2[1] = num34;
												array2[2] = num25;
												array2[3] = 0;
												if (num34 <= 0)
												{
													break;
												}
												array2[3] = 1;
												num13 = 1;
												num14 = 1;
												Class64.smethod_30(characterAccountConfig);
												for (int m = 0; m < Class56.int_0; m++)
												{
													Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array3, 1, ref int_7);
													if (array3[0] == 0)
													{
														break;
													}
													Thread.Sleep(1);
												}
												if (characterAccountConfig.gstruct50_0.int_0 == 0 || Class72.smethod_10(characterAccountConfig, (uint)num34) <= 0)
												{
													int value2 = Class83.smethod_13(characterAccountConfig);
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(value2), 4, ref int_7);
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num32), 4, ref int_7);
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num34), 4, ref int_7);
												}
												flag9 = characterAccountConfig.gstruct50_0.int_0 > 0 && characterAccountConfig.gstruct50_0.int_1 > 0 && characterAccountConfig.gstruct50_0.int_8 > 0 && characterAccountConfig.gstruct50_0.int_9 > 0;
												break;
											}
										}
										else
										{
											flag11 = false;
										}
									}
								}
								else
								{
									Thread.Sleep(100);
									num13 = 0;
								}
							}
							goto IL_2d1f;
							IL_2d1f:
							if (!flag11 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && Class38.smethod_58(characterAccountConfig, new int[2] { 0, 1 }) != 0)
							{
								if (num13 > 0)
								{
									Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
								}
								num13 = 0;
							}
							if (flag10 && num34 <= 0)
							{
								FormDuongMon.smethod_0(characterAccountConfig, ref int_4, array, ref int_5, flag6);
							}
							goto IL_2d8e;
							IL_2d8e:
							if (!characterAccountConfig.bool_58 || characterAccountConfig.int_83 <= 0)
							{
								break;
							}
							if (Form1.int_106 != 0)
							{
								if (Class46.characterSyncSnapshot_0.int_7 == Class30.gstruct42_0[Form1.int_107].int_0)
								{
									Class38.smethod_54(characterAccountConfig, null, bool_0: true);
									if (Class11.smethod_28(long_3) > characterAccountConfig.long_9)
									{
										Class38.smethod_55(characterAccountConfig);
										long_3 = Class11.smethod_27();
									}
								}
							}
							else if (num34 > 0 && num33 > 0 && Class11.smethod_28(long_3) > characterAccountConfig.long_9)
							{
								Class38.smethod_54(characterAccountConfig, array6, bool_0: false);
								Class38.smethod_55(characterAccountConfig);
								long_3 = Class11.smethod_27();
							}
							break;
							IL_183a:
							num63 = 0;
							goto IL_1c3a;
							IL_10f4:
							flag3 = num46 > 40000L;
							Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
							num13 = 0;
							if (uint_2 == null)
							{
								uint_2 = new uint[2]
								{
									array5[0],
									array5[1]
								};
								int_2 = 0;
							}
							if (int_2 > 3)
							{
								long num101 = Class64.smethod_18(uint_2, array5);
								uint_2 = null;
								num17 = 0;
								if (num101 < 180000L)
								{
									Class13.smethod_2(characterAccountConfig, bool_0: false);
									Class64.smethod_2(characterAccountConfig, array5, Class46.characterSyncSnapshot_0.uint_4, 600);
									goto IL_2d1f;
								}
								int_2 = 0;
							}
							if (num46 > Form1.int_108 * Form1.int_108)
							{
								Class64.smethod_29(characterAccountConfig, bool_0: false);
							}
							if (Form1.int_96 > 0 && num46 > 2000000L && num17 <= 0)
							{
								string[] array15 = new string[2];
								if (Form1.int_99 > 0 && (Class46.characterSyncSnapshot_0.int_0 != characterAccountConfig.int_136 || flag12))
								{
									uint[] uint_9 = Class46.characterSyncSnapshot_0.uint_4;
									if (flag12)
									{
										uint_9 = Class46.characterSyncSnapshot_1.uint_4;
									}
									array15 = Class59.smethod_5(num25, uint_9);
								}
								Class59.smethod_4(characterAccountConfig, array15[0], array15[1]);
								array5 = new uint[2]
								{
									Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
									Class24.smethod_30(num22 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
								};
								num46 = Class64.smethod_18(array5, Class46.characterSyncSnapshot_0.uint_4);
								if (num46 < 900000L)
								{
									num6 = 0;
								}
								num17 = 1;
							}
							if (num46 < 900000L && num6 < 6)
							{
								num6++;
								Class13.smethod_2(characterAccountConfig, bool_0: false);
								Class75.smethod_61(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4);
								Thread.Sleep(150);
								goto IL_2d1f;
							}
							if (Class46.characterSyncSnapshot_0.uint_4 != null && (!Class13.smethod_3(characterAccountConfig) || Class11.smethod_28(long_) > 4000L))
							{
								Class13.smethod_1(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4);
								Thread.Sleep(300);
								long_ = Class11.smethod_27();
								int_2++;
								num6 = 0;
							}
							break;
						}
					}
					else
					{
						if (num28 <= 1)
						{
							flag = false;
						}
						flag7 = num23 == 10 || num23 == 21;
						num17 = 0;
						Thread.Sleep(60);
					}
				}
				else
				{
					if (num13 > 0)
					{
						Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
					}
					if (Form1.int_127 > 0)
					{
						Class24.WriteProcessMemory(characterAccountConfig.int_137, num22 + Class56.memorySignatureScanConfig_251.uint_0, Class56.byte_0, Class56.byte_0.Length, ref int_7);
					}
					num13 = 0;
					num14 = 0;
				}
			}
			else
			{
				flag5 = false;
			}
		}
	}

	private static void smethod_1()
	{
		int int_ = int_0;
		int_0 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25 || (Form1.int_24 != 1 && Form1.int_24 != 3) || Form1.int_98 <= 0)
				{
					if (0 <= num)
					{
						Form1.characterAccountConfig_1[num].bool_44 = false;
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_44)
					{
						break;
					}
					Form1.characterAccountConfig_1[num].bool_44 = true;
					flag = true;
				}
				smethod_2(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_2(int int_1)
	{
		int num = 0;
		int num2 = 0;
		int int_2 = 0;
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		byte[] array = null;
		uint uint_ = 0u;
		while (true)
		{
			num2--;
			Thread.Sleep(300);
			if (Class11.bool_0 || (Form1.int_24 != 1 && Form1.int_24 != 3) || Form1.int_98 <= 0)
			{
				break;
			}
			if (num2 <= 0)
			{
				num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
				if (num < 0 || !Form1.characterAccountConfig_1[num].bool_25)
				{
					break;
				}
				num2 = 3;
			}
			characterAccountConfig_ = Form1.characterAccountConfig_1[num];
			uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_.int_137);
			uint num4 = Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_.int_137);
			uint num5 = num4 * Class56.memorySignatureScanConfig_15.uint_0;
			uint num6 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_.int_137);
			uint num7 = num6 + num5;
			uint_ = num7 + Class56.memorySignatureScanConfig_89.uint_0;
			int num8 = Class89.smethod_36(characterAccountConfig_);
			int num9 = num8 / 3600;
			int num10 = num8 / 60 - num9 * 60;
			int num11 = num8 % 60;
			int num12 = Class89.smethod_38(characterAccountConfig_);
			int num13 = Class89.smethod_37(characterAccountConfig_);
			string string_ = "K:" + Class89.smethod_35(characterAccountConfig_) + " - T:" + Class89.smethod_35(characterAccountConfig_, bool_0: true) + " (" + num10 + ":" + num11 + ") " + num13 + "/" + num12;
			array = Class11.smethod_47(string_);
			Class24.WriteProcessMemory(characterAccountConfig_.int_137, uint_, array, array.Length, ref int_2);
		}
		string string_2 = Class28.smethod_10(characterAccountConfig_);
		array = Class11.smethod_47(string_2);
		Class24.WriteProcessMemory(characterAccountConfig_.int_137, uint_, array, array.Length, ref int_2);
	}
}
