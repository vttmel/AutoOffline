using System;
using System.Threading;
using ns100;
using ns109;
using ns11;
using ns111;
using ns121;
using ns13;
using ns23;
using ns28;
using ns29;
using ns3;
using ns33;
using ns35;
using ns39;
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

namespace ns20;

internal class Class21
{
	public static void smethod_0(int int_0)
	{
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		long long_ = 0L;
		long long_2 = 0L;
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		bool bool_ = false;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		long long_3 = 0L;
		new Random();
		uint[] uint_ = null;
		uint num4 = 0u;
		uint uint_2 = 0u;
		int num5 = 0;
		int num6 = 0;
		int int_1 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int int_2 = 0;
		long num10 = 0L;
		long num11 = 0L;
		long long_4 = 0L;
		int int_3 = 0;
		int int_4 = 0;
		bool flag5 = false;
		uint[] array = null;
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		int num15 = 0;
		int int_5 = -1;
		int[] array2 = new int[4];
		int int_6 = 0;
		byte[] byte_ = new byte[4];
		byte[] array3 = new byte[4];
		bool flag6 = false;
		bool flag7 = false;
		bool flag8 = false;
		int num16 = 0;
		int[] array4 = new int[10];
		for (int i = 0; i < array4.Length; i++)
		{
			array4[i] = 4;
		}
		while (true)
		{
			Thread.Sleep(200);
			num12 = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (Class11.bool_0 || num12 < 0 || Form1.int_24 != 2 || Form1.int_28 != 2)
			{
				break;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num12];
			if (!characterAccountConfig.bool_25 || characterAccountConfig.bool_54 || characterAccountConfig.int_25 > 0 || characterAccountConfig.int_133[0] > 0 || characterAccountConfig.int_20[0] > 0)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref array4[0]);
			uint num17 = BitConverter.ToUInt32(array3, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num17 + Class56.memorySignatureScanConfig_13.uint_0, array3, 4, ref array4[1]);
			uint num18 = BitConverter.ToUInt32(array3, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array3, 4, ref array4[2]);
			uint num19 = BitConverter.ToUInt32(array3, 0);
			uint num20 = num18 * Class56.memorySignatureScanConfig_15.uint_0;
			uint num21 = num19 + num20;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num21, array3, 4, ref array4[3]);
			num4 = BitConverter.ToUInt32(array3, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_55.uint_0, array3, 4, ref array4[4]);
			int num22 = BitConverter.ToInt32(array3, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref array4[5]);
			int num23 = BitConverter.ToInt32(array3, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array3, 4, ref array4[6]);
			int num24 = BitConverter.ToInt32(array3, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref array4[7]);
			int num25 = BitConverter.ToInt32(array3, 0);
			int num26 = Class89.smethod_12(characterAccountConfig);
			if ((characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0) || (num26 != 1 && num26 != 2))
			{
				if (num15 <= 0)
				{
					array2[0] = 0;
					array2[1] = 0;
					array2[2] = 0;
					array2[3] = 0;
				}
				num15 = 0;
				int num27 = Class89.smethod_39(characterAccountConfig);
				if (num23 != 0 && num22 != 0 && num24 != 0 && num22 != 10 && num22 != 21 && num27 > 1)
				{
					if (flag6)
					{
						flag6 = false;
						Thread.Sleep(300);
						continue;
					}
					num16 = 7;
					int num28 = 0;
					while (true)
					{
						if (num28 <= num16)
						{
							if (array4[num28] == 0)
							{
								break;
							}
							num28++;
							continue;
						}
						Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_23 * 4, array3, 1, ref int_6);
						if (array3[0] > 0)
						{
							flag3 = false;
							array3[0] = 0;
							Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_23 * 4, array3, 1, ref int_6);
						}
						uint[] array5 = new uint[2]
						{
							Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
							Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
						};
						if (array5[0] == 0 || array5[1] == 0)
						{
							break;
						}
						uint[] array6 = new uint[2];
						int num30;
						int num32;
						int num33;
						bool flag9;
						bool flag11;
						bool flag10;
						long num36;
						int num31;
						if (num2 == num24)
						{
							if (num3 != num25)
							{
								uint_ = null;
								int_1 = 0;
								int num29 = 0;
								while (num25 == 0 && num29 < 30 && num25 != num3)
								{
									Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref int_6);
									num17 = BitConverter.ToUInt32(array3, 0);
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num17 + Class56.memorySignatureScanConfig_13.uint_0, array3, 4, ref int_6);
									num18 = BitConverter.ToUInt32(array3, 0);
									num20 = num18 * Class56.memorySignatureScanConfig_15.uint_0;
									Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array3, 4, ref int_6);
									num19 = BitConverter.ToUInt32(array3, 0);
									num21 = num19 + num20;
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_6);
									num25 = BitConverter.ToInt32(array3, 0);
									Thread.Sleep(10);
									num29++;
								}
								num3 = num25;
								Thread.Sleep(100);
								Class95.smethod_8(characterAccountConfig);
								break;
							}
							num30 = 600;
							if (characterAccountConfig.int_98 > 0)
							{
								num30 = characterAccountConfig.int_99;
							}
							if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0)
							{
								Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_43 * 4, array3, 4, ref int_6);
								characterAccountConfig.int_97 = BitConverter.ToInt32(array3, 0);
							}
							num31 = characterAccountConfig.int_97;
							if (characterAccountConfig.int_95 > 0 && characterAccountConfig.int_96 > 0)
							{
								num31 = characterAccountConfig.int_96;
							}
							if (num31 <= 0)
							{
								num31 = 500;
							}
							num13 = Form1.int_27;
							if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0)
							{
								if (num31 <= 180 && num13 < Form1.int_57)
								{
									num13 = Form1.int_57;
								}
								if (characterAccountConfig.int_131[0] > 0 && Form1.int_31 > 0 && num13 > 180)
								{
									num13 = 180;
								}
								if (flag8)
								{
									if (num25 > 0)
									{
										num13 = characterAccountConfig.gstruct50_0.int_9;
									}
									flag8 = false;
								}
							}
							array = array5;
							flag5 = false;
							num32 = 0;
							num33 = 0;
							flag9 = false;
							flag10 = false;
							if (num24 != Form1.int_30)
							{
								if (Form1.int_119 > 0 && Class46.characterSyncSnapshot_0.int_0 == characterAccountConfig.int_136)
								{
									if (Class11.smethod_28(long_4) > 30000L)
									{
										Class75.smethod_52(characterAccountConfig, "<color=yellow>Dang o che do ac chinh nguoi dung Tu dieu khien...");
										long_4 = Class11.smethod_27();
									}
									break;
								}
								int[] array7 = Class64.smethod_9(num24);
								if (array7 == null)
								{
									flag3 = false;
									if (Class59.smethod_1(num24) != null)
									{
										Class53.smethod_5(characterAccountConfig, 11);
										flag7 = true;
										break;
									}
									if (Class59.smethod_0(num24) != null || 0 <= Class59.smethod_2(num24))
									{
										break;
									}
									if (Class75.smethod_3(characterAccountConfig, Class75.uint_19, 4) > 0 && num5 < 6)
									{
										Class29.smethod_7(characterAccountConfig, 11, "®«ng|§«ng");
										num5++;
										break;
									}
									if (num25 > 0 && num6 < 6)
									{
										Class64.smethod_14(characterAccountConfig);
										num6++;
										if (num6 > 3)
										{
											num5 = 0;
										}
										break;
									}
								}
								if (array7 != null && array7[1] == 0)
								{
									int num34 = Class85.smethod_4(characterAccountConfig);
									if (flag3 && num >= 0 && num == num34)
									{
										if (flag7 && num25 == 0)
										{
											flag7 = Class98.smethod_0(characterAccountConfig, bool_0: true) < 0;
										}
										else
										{
											Class53.smethod_2(characterAccountConfig, "Tam M«n §µi");
										}
										break;
									}
									if (!Form1.bool_18)
									{
										if (Class42.smethod_0(characterAccountConfig) == 0)
										{
											Thread.Sleep(300);
											break;
										}
										int num35 = Class36.smethod_3(characterAccountConfig, Form1.int_105 <= 0);
										if (num35 == 0 || (num35 < 0 && !flag4))
										{
											Thread.Sleep(300);
											flag4 = num35 < 0;
											break;
										}
									}
									flag3 = true;
									flag4 = false;
									num = Class85.smethod_4(characterAccountConfig);
									if (characterAccountConfig.int_65 > 0)
									{
										Class64.smethod_3(characterAccountConfig, ref bool_);
									}
								}
								else
								{
									Class53.smethod_5(characterAccountConfig, 11);
									flag7 = true;
								}
								break;
							}
							flag3 = false;
							flag3 = false;
							if (Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137) == 0)
							{
								break;
							}
							flag11 = (Form1.int_10 > 0 || Form1.int_11 > 0) && Form1.int_25 > 0 && (Class46.characterSyncSnapshot_1.int_3 > 0 || Form1.int_26 > 0) && Class46.characterSyncSnapshot_1.int_4 > 0 && Class11.smethod_63(Class46.characterSyncSnapshot_1.uint_4) && (characterAccountConfig.int_136 == Class46.characterSyncSnapshot_0.int_0 || Class46.characterSyncSnapshot_0.int_0 <= 0);
							flag = Form1.int_25 > 0 && Class46.characterSyncSnapshot_0.int_0 > 0 && Class46.characterSyncSnapshot_0.int_0 != characterAccountConfig.int_136 && Class46.characterSyncSnapshot_0.int_6 > 0 && Class46.characterSyncSnapshot_0.int_4 == num24 && Class11.smethod_63(Class46.characterSyncSnapshot_0.uint_4) && Class46.characterSyncSnapshot_0.int_3 > 0;
							flag10 = !characterAccountConfig.bool_22 && (Form1.int_35 > 0 || Form1.int_34 > 0);
							array5 = new uint[2]
							{
								Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
								Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
							};
							if (flag && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0)
							{
								array5 = new uint[2]
								{
									Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
									Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
								};
								num36 = Class64.smethod_18(array5, Class46.characterSyncSnapshot_0.uint_4);
								if (characterAccountConfig.int_130[0] > 0 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && num25 == Class46.characterSyncSnapshot_0.int_3 && num25 > 0)
								{
									int num37 = characterAccountConfig.int_130[1] + Form1.int_27;
									if (num36 <= num37 * num37 && Class68.smethod_0(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4, characterAccountConfig.int_130[1]) > 0)
									{
										goto IL_286a;
									}
								}
								if (flag2 || num36 > num13 * num13)
								{
									goto IL_0d42;
								}
								Class13.smethod_2(characterAccountConfig, bool_0: false);
								int num38 = num7;
								num7 = 0;
								int_1 = 0;
								if (num25 > 0 && !characterAccountConfig.bool_22 && characterAccountConfig.int_93 == 1 && Form1.int_109 > 0 && (Form1.int_35 > 0 || Form1.int_34 > 0 || Form1.int_36 > 0) && Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137) != 0)
								{
									Class64.smethod_30(characterAccountConfig);
								}
								if (num11 <= 0L || Class11.smethod_28(num11) >= 1500L)
								{
									uint[] uint_3 = new uint[2]
									{
										array5[0],
										array5[1]
									};
									if (Class46.smethod_5(num4, ref array5, ref uint_2) > 0)
									{
										long num39 = Class64.smethod_18(uint_3, Class46.characterSyncSnapshot_0.uint_4);
										long num40 = Class64.smethod_18(array5, Class46.characterSyncSnapshot_0.uint_4);
										if (num40 > num13 * num13)
										{
											if (num38 > 0)
											{
												uint[] uint_4 = Class64.smethod_5(array5, Class46.characterSyncSnapshot_0.uint_4, -100);
												Class75.smethod_61(characterAccountConfig, uint_4);
												Thread.Sleep(120);
											}
											goto IL_0d42;
										}
										num11 = Class11.smethod_27();
										if (num14 > 0)
										{
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
										}
										num14 = 0;
										Class46.smethod_6(characterAccountConfig, array5, Class46.characterSyncSnapshot_0.uint_4, num39 <= 5625L);
										goto IL_27fb;
									}
									num11 = 0L;
									if (num14 == 0 && Class64.smethod_18(uint_3, Class46.characterSyncSnapshot_0.uint_4) > Form1.int_27 * Form1.int_27)
									{
										num8++;
										if (num8 > 3)
										{
											Class75.smethod_61(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4);
											Thread.Sleep(150);
											num8 = 0;
										}
									}
									if (Form1.int_31 > 0 && num25 > 0 && characterAccountConfig.int_131[0] > 0 && Class75.smethod_3(characterAccountConfig, Class75.uint_31, 4) == 0)
									{
										Class75.smethod_2(characterAccountConfig, Class75.uint_31, 1, 4);
									}
								}
								int_1 = 0;
								uint_ = null;
								array = Class46.characterSyncSnapshot_0.uint_4;
								flag5 = true;
							}
							else
							{
								if (characterAccountConfig.int_68 != null && characterAccountConfig.int_68[0] > 0 && !AuxiliaryMachineManager.bool_3)
								{
									uint[] array8 = null;
									if (num10 <= 0L || Class11.smethod_28(num10) >= 1000L)
									{
										array8 = Class64.smethod_26(characterAccountConfig, ref int_2);
										if (array8 == null)
										{
											num10 = Class11.smethod_27();
										}
										else
										{
											num10 = 0L;
											long num41 = Class64.smethod_18(array5, array8);
											if (num41 < 8000L)
											{
												goto IL_114a;
											}
											if (num41 >= 15000L && num41 >= characterAccountConfig.int_68[1] * characterAccountConfig.int_68[1])
											{
												if (num41 < 360000L)
												{
													Class13.smethod_2(characterAccountConfig, bool_0: false);
													if (num14 > 0)
													{
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
													}
													num14 = 0;
													Class75.smethod_61(characterAccountConfig, array8);
													Thread.Sleep(150);
													break;
												}
												if (num41 < 1200000L)
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
												if (num22 <= 3 && num41 > 7500L)
												{
													if (num14 > 0)
													{
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
													}
													num14 = 0;
													Class75.smethod_61(characterAccountConfig, array8);
													Thread.Sleep(150);
													goto IL_27fb;
												}
												num41 = 4L;
											}
										}
									}
								}
								if (flag11)
								{
									int num42 = AuxiliaryMachineManager.smethod_10(characterAccountConfig, ref long_, ref int_1, ref uint_);
									if (num42 <= 0)
									{
										Thread.Sleep(100);
										break;
									}
									num22 = (int)Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
									if (num22 < 3)
									{
										array5 = new uint[2]
										{
											Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
											Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
										};
										if (Class64.smethod_18(array5, Class46.characterSyncSnapshot_1.uint_4) > 5625L)
										{
											if (num14 > 0)
											{
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
											}
											num14 = 0;
											Class75.smethod_61(characterAccountConfig, Class46.characterSyncSnapshot_1.uint_4);
											Thread.Sleep(150);
										}
									}
								}
							}
							goto IL_114a;
						}
						flag3 = false;
						bool_ = false;
						uint_ = null;
						int_1 = 0;
						int num43 = 0;
						while (num2 != num24)
						{
							int num44 = Class89.smethod_39(characterAccountConfig);
							Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref int_6);
							num17 = BitConverter.ToUInt32(array3, 0);
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num17 + Class56.memorySignatureScanConfig_13.uint_0, array3, 4, ref int_6);
							num18 = BitConverter.ToUInt32(array3, 0);
							num20 = num18 * Class56.memorySignatureScanConfig_15.uint_0;
							Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array3, 4, ref int_6);
							num19 = BitConverter.ToUInt32(array3, 0);
							num21 = num19 + num20;
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_6);
							num23 = BitConverter.ToInt32(array3, 0);
							Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array3, 4, ref int_6);
							num24 = BitConverter.ToInt32(array3, 0);
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_6);
							num25 = BitConverter.ToInt32(array3, 0);
							Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
							num14 = 0;
							if (num25 > 0 || num43 > 8 || (num44 != 0 && num44 != 1 && num23 > 0 && num24 > 0))
							{
								break;
							}
							num43++;
							Thread.Sleep(100);
						}
						num2 = num24;
						break;
						IL_286a:
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
						else if (num33 > 0 && num32 > 0 && Class11.smethod_28(long_3) > characterAccountConfig.long_9)
						{
							Class38.smethod_54(characterAccountConfig, array6, bool_0: false);
							Class38.smethod_55(characterAccountConfig);
							long_3 = Class11.smethod_27();
						}
						break;
						IL_1719:
						if (flag10)
						{
							if (!Class46.smethod_7(characterAccountConfig, ref int_5) && Class89.smethod_12(characterAccountConfig) != 1)
							{
								num24 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
								array5 = new uint[2]
								{
									Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
									Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
								};
								uint[] uint_5 = array5;
								if (flag && Class46.characterSyncSnapshot_0.int_4 == num24 && Class46.characterSyncSnapshot_0.int_3 > 0 && Class46.characterSyncSnapshot_0.uint_4 != null)
								{
									uint_5 = Class46.characterSyncSnapshot_0.uint_4;
									num30 += num13;
								}
								uint num45 = 0u;
								if (Form1.int_37 > 0 && (flag11 || flag))
								{
									if (flag11)
									{
										if (Class46.characterSyncSnapshot_1.int_4 == num24 && Class46.characterSyncSnapshot_1.uint_3 != num4)
										{
											num45 = Class46.characterSyncSnapshot_1.uint_3;
										}
									}
									else if (flag && Class46.characterSyncSnapshot_0.int_4 == num24 && Class46.characterSyncSnapshot_0.uint_3 != num4)
									{
										num45 = Class46.characterSyncSnapshot_0.uint_3;
									}
									if (num45 == 0 && Form1.int_38 <= 0)
									{
										goto IL_27fb;
									}
								}
								int[,] array9 = null;
								if (characterAccountConfig.int_119 > 0 && characterAccountConfig.int_3 != null)
								{
									array9 = ((characterAccountConfig.int_5 > 0) ? Class72.smethod_5(characterAccountConfig, num45, num30, uint_5, null, bool_1: false, Form1.int_101 > 0, bool_3: true) : Class72.smethod_6(characterAccountConfig, num45, num30, uint_5, null, bool_1: false, Form1.int_101 > 0, bool_3: true));
									if (array9 != null && array9[0, 0] >= 0)
									{
										int num46 = -1;
										int int_7 = Class46.characterSyncSnapshot_0.int_4;
										num14 = 0;
										bool flag12 = false;
										bool flag13 = false;
										while (true)
										{
											int num47 = 0;
											int num48 = 400;
											uint num49 = 0u;
											while (num47 <= 0)
											{
												num46++;
												if (characterAccountConfig.int_3 != null && characterAccountConfig.int_3.GetLength(0) > num46 && characterAccountConfig.int_4 != null)
												{
													num47 = characterAccountConfig.int_3[num46, 0];
													if (num47 > 0)
													{
														num48 = Class83.smethod_20(characterAccountConfig, num47, characterAccountConfig.int_3[num46, 1]);
														break;
													}
													continue;
												}
												goto IL_1e04;
											}
											num22 = (int)Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
											num23 = (int)Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig.int_137);
											num25 = (int)Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
											int num50 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
											if (num25 > 0 && num24 == num50 && num22 != 11 && num22 != 22 && num23 != 0)
											{
												for (int j = 0; j < array9.GetLength(0); j++)
												{
													if (Class46.smethod_7(characterAccountConfig, ref int_5) || Class89.smethod_12(characterAccountConfig) == 1)
													{
														goto IL_1dc8;
													}
													num32 = array9[j, 0];
													num33 = array9[j, 1];
													if (num33 <= 0)
													{
														continue;
													}
													num49 = num19 + (uint)(num33 * (int)Class56.memorySignatureScanConfig_15.uint_0);
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num49 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_6);
													if (BitConverter.ToInt32(array3, 0) <= 0)
													{
														continue;
													}
													if (num32 > 0)
													{
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num49 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_6);
														if (BitConverter.ToInt32(array3, 0) <= 0)
														{
															continue;
														}
													}
													flag12 = true;
													if (!flag13 || num32 > 0)
													{
														if (num32 > 0)
														{
															flag13 = true;
														}
														if (Class3.smethod_31(characterAccountConfig, num33, num47) != 0)
														{
															continue;
														}
														num31 = num48;
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num49 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array3, 4, ref int_6);
														array6[0] = BitConverter.ToUInt32(array3, 0);
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num49 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array3, 4, ref int_6);
														array6[1] = BitConverter.ToUInt32(array3, 0);
														array5 = new uint[2]
														{
															Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
															Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
														};
														if (flag)
														{
															array5 = new uint[2]
															{
																Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
																Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
															};
															long num51 = Class64.smethod_18(array5, Class46.characterSyncSnapshot_0.uint_4);
															if (int_7 != Class46.characterSyncSnapshot_0.int_4 || num51 > num13 * num13)
															{
																goto IL_1da5;
															}
															int num52 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array6));
															int num53 = (int)Math.Sqrt(Class64.smethod_18(array5, array6));
															int num54 = num52 - num13 + 10;
															if (num52 > num13 && num31 < num54 && (num53 > num52 || (num53 < num52 && num31 < num53)))
															{
																num31 = num54;
															}
														}
														if (Class64.smethod_18(array5, array6) > num31 * num31 && characterAccountConfig.int_95 <= 0)
														{
															continue;
														}
														for (int k = 0; k < Class56.int_0; k++)
														{
															Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array3, 1, ref int_6);
															if (array3[0] == 0)
															{
																break;
															}
															Thread.Sleep(1);
														}
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(num47), 4, ref int_6);
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num31), 4, ref int_6);
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num33), 4, ref int_6);
														Thread.Sleep(10);
														num14 = 1;
														continue;
													}
													goto IL_1e04;
												}
												continue;
											}
											if (num14 > 0)
											{
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
											}
											num14 = 0;
											break;
											IL_1e04:
											if (num14 <= 0 && characterAccountConfig.int_6 <= 0 && flag12)
											{
												long num55 = 0L;
												array5 = new uint[2]
												{
													Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
													Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
												};
												num32 = -1;
												num33 = -1;
												flag13 = false;
												num31 = characterAccountConfig.int_97;
												if (characterAccountConfig.int_95 > 0 && characterAccountConfig.int_96 > 0)
												{
													num31 = characterAccountConfig.int_96;
												}
												if (num31 <= 0)
												{
													num31 = 500;
												}
												Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_44 * 4, array3, 1, ref int_6);
												int num56 = array3[0];
												if (num56 > 0 && num31 > characterAccountConfig.int_97 && characterAccountConfig.int_97 > 0)
												{
													num31 = characterAccountConfig.int_97;
												}
												for (int l = 0; l < array9.GetLength(0); l++)
												{
													int num57 = array9[l, 0];
													int num58 = array9[l, 1];
													int num59 = num31;
													if (num58 <= 0)
													{
														continue;
													}
													num49 = num19 + (uint)(num58 * (int)Class56.memorySignatureScanConfig_15.uint_0);
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num49 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_6);
													if (BitConverter.ToInt32(array3, 0) <= 0)
													{
														continue;
													}
													if (num57 > 0)
													{
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num49 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_6);
														if (BitConverter.ToInt32(array3, 0) <= 0)
														{
															continue;
														}
													}
													if (flag13 && num57 <= 0 && num33 > 0)
													{
														break;
													}
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num49 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array3, 4, ref int_6);
													array6[0] = BitConverter.ToUInt32(array3, 0);
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num49 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array3, 4, ref int_6);
													array6[1] = BitConverter.ToUInt32(array3, 0);
													long num60 = Class64.smethod_18(array5, array6);
													if (num33 > 0 && num55 < num60)
													{
														continue;
													}
													if (flag)
													{
														int num61 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array6));
														int num62 = (int)Math.Sqrt(Class64.smethod_18(array5, array6));
														int num63 = num61 - num13 + 10;
														if (num61 > num13 && num59 < num63 && (num62 > num61 || (num62 < num61 && num59 < num62)))
														{
															num59 = num63;
														}
													}
													if (num60 <= num59 * num59 || characterAccountConfig.int_95 > 0)
													{
														if (num57 > 0)
														{
															flag13 = true;
														}
														num33 = num58;
														num32 = num57;
														num55 = num60;
														num31 = num59;
													}
												}
												if (num33 <= 0)
												{
													break;
												}
												Class64.smethod_30(characterAccountConfig);
												for (int m = 0; m < Class56.int_0; m++)
												{
													Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array3, 1, ref int_6);
													if (array3[0] == 0)
													{
														break;
													}
													Thread.Sleep(1);
												}
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(Class83.smethod_13(characterAccountConfig)), 4, ref int_6);
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num31), 4, ref int_6);
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num33), 4, ref int_6);
											}
											else if (flag12 && num14 <= 0 && characterAccountConfig.int_6 > 0)
											{
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
											}
											break;
											IL_1da5:
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
											break;
											IL_1dc8:
											Thread.Sleep(100);
											num14 = 0;
											break;
										}
									}
								}
								else if (flag10 = !characterAccountConfig.bool_22 && (Form1.int_35 > 0 || Form1.int_34 > 0))
								{
									array9 = Class72.smethod_5(characterAccountConfig, num45, num30, uint_5, null, bool_1: false, Form1.int_101 > 0, bool_3: true);
									if (array9 == null)
									{
										flag10 = false;
									}
									else
									{
										if (array9[0, 0] == -100)
										{
											break;
										}
										int num64 = 0;
										while (true)
										{
											if (array9[num64, 1] > 0)
											{
												array6 = new uint[2]
												{
													(uint)array9[num64, 4],
													(uint)array9[num64, 5]
												};
												if (flag)
												{
													int num65 = (int)Math.Sqrt(Class64.smethod_18(array5, array6));
													int num66 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array6));
													if (num65 - num31 > 0)
													{
														if (num66 > num65)
														{
															int num67 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array5));
															if (num67 + (num65 - num31) <= num13 + 10)
															{
																goto IL_23fd;
															}
														}
														if (characterAccountConfig.int_88 == 1 && num64 == 0)
														{
															num64 = 1;
															continue;
														}
														if (num13 + num31 <= num66)
														{
															if (num14 > 0)
															{
																Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
															}
															num14 = 0;
															break;
														}
													}
												}
												else if (Class64.smethod_18(array5, array6) > num31 * num31 && characterAccountConfig.int_95 <= 0)
												{
													if (characterAccountConfig.int_88 != 1 || num64 != 0)
													{
														break;
													}
													num64 = 1;
													continue;
												}
												goto IL_23fd;
											}
											if (num14 > 0)
											{
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
											}
											num14 = 0;
											break;
											IL_23fd:
											num32 = array9[num64, 0];
											num33 = array9[num64, 1];
											_ = array9[num64, 2];
											if (Form1.int_56 > 0 && (num32 <= 0 || num32 == array2[0]) && array2[1] > 0 && array2[2] == num24 && array2[3] > 0)
											{
												int num68 = array2[0];
												int num69 = array2[1];
												uint num70 = num19 + (uint)(num69 * (int)Class56.memorySignatureScanConfig_15.uint_0);
												Class24.ReadProcessMemory(characterAccountConfig.int_137, num70 + Class56.memorySignatureScanConfig_50.uint_0, array3, 4, ref int_6);
												if (BitConverter.ToInt32(array3, 0) > 0)
												{
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num70 + Class56.memorySignatureScanConfig_45.uint_0, array3, 4, ref int_6);
													long num71 = BitConverter.ToInt32(array3, 0);
													if ((ulong)num71 > 0uL)
													{
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num70 + Class56.memorySignatureScanConfig_43.uint_0, array3, 4, ref int_6);
														if (num68 <= 0 || BitConverter.ToInt32(array3, 0) > 0)
														{
															array6 = new uint[2]
															{
																Class24.smethod_30(num70 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
																Class24.smethod_30(num70 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
															};
															long num72 = Class64.smethod_18(array5, array6);
															if (flag)
															{
																int num73 = (int)Math.Sqrt(num72);
																int num74 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array6));
																if (num73 - num31 > 0)
																{
																	if (num74 > num73)
																	{
																		int num75 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array5));
																		if (num75 + (num73 - num31) <= num13 + 10)
																		{
																			num32 = num68;
																			num33 = num69;
																		}
																	}
																}
																else
																{
																	num32 = num68;
																	num33 = num69;
																}
															}
															else if (num72 <= num31 * num31)
															{
																num32 = num68;
																num33 = num69;
															}
														}
													}
												}
											}
											array2[0] = num32;
											array2[1] = num33;
											array2[2] = num24;
											array2[3] = 0;
											if (num33 <= 0)
											{
												break;
											}
											array2[3] = 1;
											num14 = 1;
											num15 = 1;
											Class64.smethod_30(characterAccountConfig);
											for (int n = 0; n < Class56.int_0; n++)
											{
												Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array3, 1, ref int_6);
												if (array3[0] == 0)
												{
													break;
												}
												Thread.Sleep(1);
											}
											if (characterAccountConfig.gstruct50_0.int_0 == 0 || Class72.smethod_10(characterAccountConfig, (uint)num33) <= 0)
											{
												int value = Class83.smethod_13(characterAccountConfig);
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(value), 4, ref int_6);
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num31), 4, ref int_6);
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num33), 4, ref int_6);
											}
											flag8 = characterAccountConfig.gstruct50_0.int_0 > 0 && characterAccountConfig.gstruct50_0.int_1 > 0 && characterAccountConfig.gstruct50_0.int_8 > 0 && characterAccountConfig.gstruct50_0.int_9 > 0;
											break;
										}
									}
								}
								else
								{
									flag10 = false;
								}
							}
							else
							{
								Thread.Sleep(100);
								num14 = 0;
							}
						}
						goto IL_27fb;
						IL_27fb:
						if (!flag10 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && Class38.smethod_58(characterAccountConfig, new int[2] { 0, 1 }) != 0)
						{
							if (num14 > 0)
							{
								Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
							}
							num14 = 0;
						}
						if (flag9 && num33 <= 0)
						{
							FormDuongMon.smethod_0(characterAccountConfig, ref int_3, array, ref int_4, flag5);
						}
						goto IL_286a;
						IL_0d42:
						flag2 = num36 > 40000L;
						Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
						num14 = 0;
						if (uint_ == null)
						{
							uint_ = new uint[2]
							{
								array5[0],
								array5[1]
							};
							int_1 = 0;
						}
						if (int_1 > 6)
						{
							long num76 = Class64.smethod_18(uint_, array5);
							uint_ = null;
							if (num76 < 180000L)
							{
								Class13.smethod_2(characterAccountConfig, bool_0: false);
								Class64.smethod_2(characterAccountConfig, array5, Class46.characterSyncSnapshot_0.uint_4, 600);
								goto IL_27fb;
							}
							int_1 = 0;
						}
						if (num36 > Form1.int_108 * Form1.int_108)
						{
							Class64.smethod_29(characterAccountConfig, bool_0: false);
						}
						if (num36 < 900000L && num7 < 6)
						{
							num7++;
							Class13.smethod_2(characterAccountConfig, bool_0: false);
							Class75.smethod_61(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4);
							Thread.Sleep(150);
							goto IL_27fb;
						}
						if (Class46.characterSyncSnapshot_0.uint_4 != null && (!Class13.smethod_3(characterAccountConfig) || Class11.smethod_28(long_) > 4000L))
						{
							Class13.smethod_1(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4);
							Thread.Sleep(300);
							long_ = Class11.smethod_27();
							int_1++;
							num7 = 0;
						}
						break;
						IL_114a:
						if (characterAccountConfig.int_101[0] > 0 && characterAccountConfig.int_101[1] > 0 && characterAccountConfig.string_23 == "NGAMY")
						{
							long num77 = Class11.smethod_28(long_2);
							if (num77 < 300L)
							{
								break;
							}
							if (num77 > characterAccountConfig.int_101[4] && Class72.smethod_3(characterAccountConfig))
							{
								Thread.Sleep(80);
								long_2 = Class11.smethod_27();
								break;
							}
						}
						for (int num78 = 0; num78 < Class56.int_0; num78++)
						{
							Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array3, 1, ref int_6);
							if (array3[0] == 0)
							{
								break;
							}
							Thread.Sleep(1);
						}
						int num79;
						if (!characterAccountConfig.bool_22)
						{
							bool flag14 = characterAccountConfig.int_128[0] > 0 && characterAccountConfig.int_128[1] > 0 && characterAccountConfig.int_128[2] > 0;
							bool flag15 = characterAccountConfig.int_128[0] > 0 && characterAccountConfig.int_128[3] > 0 && characterAccountConfig.int_128[4] > 0;
							bool flag16 = characterAccountConfig.int_128[0] > 0 && characterAccountConfig.int_128[5] > 0 && characterAccountConfig.int_128[6] > 0;
							flag9 = (flag14 || flag15 || flag16) && characterAccountConfig.string_23 == "DUONGMON";
							if (FormDame.int_6 <= 0 || characterAccountConfig.int_126 != 0 || flag9)
							{
								goto IL_1719;
							}
							if (flag10 || FormDame.int_10 > 0)
							{
								num79 = 0;
								if (FormDame.int_9 == 0)
								{
									goto IL_13a3;
								}
								bool flag17 = Class46.characterSyncSnapshot_0.int_8 == 1 || (flag11 && Class46.characterSyncSnapshot_1.int_8 == 1);
								if (FormDame.int_9 == 1)
								{
									if (flag17)
									{
										goto IL_13a3;
									}
									if (FormDame.int_11 > 0)
									{
										goto IL_136e;
									}
									if (num14 > 0)
									{
										Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
									}
									num14 = 0;
								}
								else
								{
									if (FormDame.int_9 != 2 || flag17)
									{
										goto IL_136e;
									}
									if (num14 > 0)
									{
										Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
									}
									num14 = 0;
								}
							}
						}
						else if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0)
						{
							Class64.smethod_29(characterAccountConfig, bool_0: false);
						}
						goto IL_27fb;
						IL_136e:
						num79 = 0;
						goto IL_1719;
						IL_13a3:
						uint num80 = 0u;
						uint[] array10 = null;
						uint[] uint_6 = null;
						if (!flag11)
						{
							if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136 && Class46.characterSyncSnapshot_0.uint_5 != 0)
							{
								uint num81 = Class46.characterSyncSnapshot_0.uint_5 >> 16;
								uint int_8 = Class46.characterSyncSnapshot_0.uint_5 - (num81 << 16);
								array10 = Class89.smethod_11(Class46.characterSyncSnapshot_0.uint_4, (int)int_8, (int)num81);
								uint[] array11 = Class89.smethod_10(array5, array10);
								num80 = (array11[1] << 16) + array11[0];
								uint_6 = Class46.characterSyncSnapshot_0.uint_4;
								Class89.smethod_7(characterAccountConfig, num80);
								Thread.Sleep(10);
							}
						}
						else
						{
							uint num82 = Class46.characterSyncSnapshot_1.uint_5 >> 16;
							uint int_9 = Class46.characterSyncSnapshot_1.uint_5 - (num82 << 16);
							array10 = Class89.smethod_11(Class46.characterSyncSnapshot_1.uint_4, (int)int_9, (int)num82);
							uint[] array12 = Class89.smethod_10(array5, array10);
							num80 = (array12[1] << 16) + array12[0];
							uint_6 = Class46.characterSyncSnapshot_1.uint_4;
							Class89.smethod_7(characterAccountConfig, num80);
							Thread.Sleep(10);
						}
						Class64.smethod_30(characterAccountConfig);
						if (characterAccountConfig.int_127[0] == 2)
						{
							Class64.smethod_0(characterAccountConfig.uint_4, characterAccountConfig.int_129, FormDame.int_12);
						}
						else
						{
							if (characterAccountConfig.int_127[0] > 0)
							{
								bool flag18 = characterAccountConfig.int_127[1] > 0 && characterAccountConfig.int_127[2] > 0;
								bool flag19 = characterAccountConfig.int_127[3] > 0 && characterAccountConfig.int_127[4] > 0;
								if (flag18 && !flag19)
								{
									num79 = characterAccountConfig.int_127[2];
								}
								else if (flag19 && !flag18)
								{
									num79 = characterAccountConfig.int_127[4];
								}
								else if (flag18 && flag19)
								{
									num79 = ((0 > num9 || num9 > 25) ? characterAccountConfig.int_127[4] : characterAccountConfig.int_127[2]);
									if (num9 > 35)
									{
										num9 = 0;
									}
									num9++;
								}
							}
							if (num79 <= 0)
							{
								num79 = Class83.smethod_13(characterAccountConfig);
							}
							if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 || Form1.int_10 > 0 || Form1.int_11 > 0)
							{
								Class83.smethod_9(characterAccountConfig);
							}
							Class83.smethod_5(characterAccountConfig, num79, 6, 1);
							for (int num83 = 0; num83 < 3; num83++)
							{
								if (FormDame.int_14 > 0)
								{
									Class24.smethod_76(characterAccountConfig.uint_4, 32);
								}
								else
								{
									Class24.smethod_76(characterAccountConfig.uint_4, 117);
								}
								if (num83 < 2)
								{
									Thread.Sleep(60);
								}
							}
						}
						if (num80 != 0 && characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136)
						{
							if (characterAccountConfig.int_95 <= 0)
							{
								Class24.smethod_30(num21 + Class56.memorySignatureScanConfig_31.uint_0, characterAccountConfig.int_137);
								int num84 = Class83.smethod_13(characterAccountConfig);
								if (num84 == 53 || num84 <= 1)
								{
									goto IL_27fb;
								}
								if (num84 <= 100)
								{
									num84 = 400;
								}
							}
							string string_ = Class89.smethod_20(characterAccountConfig);
							if (Class11.smethod_2(string_, "iÓm qu\u00b8 x"))
							{
								uint[] array13 = Class64.smethod_5(uint_6, array10, -1 * (Form1.int_27 - 50));
								long num85 = Class64.smethod_18(array5, array13);
								if (num85 > 7000L)
								{
									Class75.smethod_61(characterAccountConfig, array13);
									Thread.Sleep(150);
									Class89.smethod_21(characterAccountConfig, "0K..");
								}
							}
						}
						goto IL_27fb;
					}
				}
				else
				{
					if (num27 <= 1)
					{
						bool_ = false;
					}
					flag6 = num22 == 10 || num22 == 21;
					Thread.Sleep(60);
				}
			}
			else
			{
				if (num14 > 0)
				{
					Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_6);
				}
				if (Form1.int_127 > 0)
				{
					Class24.WriteProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_251.uint_0, Class56.byte_0, Class56.byte_0.Length, ref int_6);
				}
				num14 = 0;
				num15 = 0;
			}
		}
	}
}
