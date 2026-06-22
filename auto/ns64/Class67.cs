using System;
using System.Threading;
using ns100;
using ns109;
using ns11;
using ns23;
using ns29;
using ns3;
using ns35;
using ns4;
using ns43;
using ns53;
using ns61;
using ns68;
using ns71;
using ns77;
using ns79;
using ns83;
using ns85;

namespace ns64;

internal class Class67
{
	public static void smethod_0(int int_0)
	{
		int num = 0;
		int int_1 = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int int_2 = -1;
		byte[] array = new byte[4];
		byte[] byte_ = new byte[4];
		int[] array2 = new int[5];
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		long long_ = 0L;
		long long_2 = 0L;
		int num7 = 0;
		int[] array3 = new int[10];
		for (int i = 0; i < array3.Length; i++)
		{
			array3[i] = 4;
		}
		while (true)
		{
			Thread.Sleep(100);
			num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (Class11.bool_0 || num < 0 || Form1.int_24 != 3)
			{
				break;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num];
			if (!characterAccountConfig.bool_25 || characterAccountConfig.int_20[0] > 0 || characterAccountConfig.int_133[0] > 0 || characterAccountConfig.bool_54 || characterAccountConfig.int_25 > 0 || characterAccountConfig.bool_55)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_42 * 4, array, 1, ref int_1);
			if (array[0] > 0 || characterAccountConfig.bool_15 || Class75.smethod_3(characterAccountConfig, Class75.uint_48, 4) > 0)
			{
				continue;
			}
			if (characterAccountConfig.gstruct49_0.int_0 > 0 && !characterAccountConfig.bool_45 && Class4.int_0 <= 0)
			{
				Class4.int_0 = int_0;
				new Thread(Class4.smethod_3).Start();
				Thread.Sleep(300);
			}
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref array3[1]);
			uint num8 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref array3[2]);
			uint num9 = BitConverter.ToUInt32(array, 0);
			uint num10 = num9 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref array3[3]);
			uint num11 = BitConverter.ToUInt32(array, 0);
			uint num12 = num11 + num10;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref array3[4]);
			int num13 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref array3[5]);
			int num14 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref array3[6]);
			int num15 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref array3[7]);
			int num16 = BitConverter.ToInt32(array, 0);
			int num17 = Class89.smethod_12(characterAccountConfig);
			if (characterAccountConfig.int_136 == Class81.characterAccountConfig_0.int_136 && (num17 == 1 || num17 == 2))
			{
				if (num2 > 0)
				{
					Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_1);
				}
				if (Form1.int_127 > 0)
				{
					Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_251.uint_0, Class56.byte_0, Class56.byte_0.Length, ref int_1);
				}
				num2 = 0;
				num3 = 0;
				continue;
			}
			if (num3 <= 0)
			{
				array2[0] = 0;
				array2[1] = 0;
				array2[2] = 0;
				array2[3] = 0;
				array2[4] = 0;
			}
			num3 = 0;
			uint[] array4 = new uint[2]
			{
				Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
				Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
			};
			int num18 = Class89.smethod_39(characterAccountConfig);
			if (num14 != 0 && num13 != 0 && num15 != 0 && num18 > 1 && num13 != 10 && num13 != 21 && array4[0] != 0 && array4[1] != 0)
			{
				num7 = 7;
				int num19 = 0;
				while (true)
				{
					if (num19 <= num7)
					{
						if (array3[num19] == 0)
						{
							break;
						}
						num19++;
						continue;
					}
					uint[] array5;
					int num22;
					int int_3;
					int num23;
					bool flag;
					int num24;
					bool flag2;
					if (num4 == num15)
					{
						if (num5 != num16)
						{
							int num20 = 0;
							while (num16 == 0 && num20 < 30 && num16 != num5)
							{
								Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_1);
								if (int_1 != 4)
								{
									goto end_IL_0440;
								}
								num8 = BitConverter.ToUInt32(array, 0);
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_1);
								num9 = BitConverter.ToUInt32(array, 0);
								num10 = num9 * Class56.memorySignatureScanConfig_15.uint_0;
								Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_1);
								if (int_1 != 4)
								{
									goto end_IL_0440;
								}
								num11 = BitConverter.ToUInt32(array, 0);
								num12 = num11 + num10;
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_1);
								num16 = BitConverter.ToInt32(array, 0);
								Thread.Sleep(10);
								num20++;
							}
							num5 = num16;
							if (num16 <= 0)
							{
								break;
							}
						}
						if (characterAccountConfig.int_101[0] > 0 && characterAccountConfig.int_101[1] > 0 && characterAccountConfig.string_23 == "NGAMY")
						{
							long num21 = Class11.smethod_28(long_);
							if (num21 < 300L)
							{
								break;
							}
							if (num21 > characterAccountConfig.int_101[4] && Class72.smethod_3(characterAccountConfig))
							{
								Thread.Sleep(80);
								long_ = Class11.smethod_27();
								break;
							}
						}
						for (int j = 0; j < Class56.int_0; j++)
						{
							Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array, 1, ref int_1);
							if (array[0] == 0)
							{
								break;
							}
							Thread.Sleep(1);
						}
						array5 = new uint[2];
						num22 = 0;
						int_3 = 600;
						if (characterAccountConfig.int_98 > 0)
						{
							int_3 = characterAccountConfig.int_99;
						}
						num23 = characterAccountConfig.int_97;
						if (characterAccountConfig.int_95 > 0 && characterAccountConfig.int_96 > 0)
						{
							num23 = characterAccountConfig.int_96;
						}
						if (num23 <= 0)
						{
							num23 = 500;
						}
						flag = (463 < num15 && num15 < 472) || (479 < num15 && num15 < 496);
						flag2 = !characterAccountConfig.bool_22 && (Form1.int_35 > 0 || Form1.int_34 > 0);
						if (FormDame.int_6 <= 0 || characterAccountConfig.int_126 != 0)
						{
							goto IL_090e;
						}
						if (flag2 || FormDame.int_10 > 0)
						{
							num24 = 0;
							if (FormDame.int_9 == 0)
							{
								goto IL_07ac;
							}
							bool flag3 = Class46.characterSyncSnapshot_0.int_8 == 1;
							if (FormDame.int_9 != 1)
							{
								if (FormDame.int_9 != 2 || flag3)
								{
									goto IL_0778;
								}
								if (num2 > 0)
								{
									Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_1);
								}
								num2 = 0;
							}
							else
							{
								if (flag3)
								{
									goto IL_07ac;
								}
								if (FormDame.int_11 > 0)
								{
									goto IL_0778;
								}
								if (num2 > 0)
								{
									Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_1);
								}
								num2 = 0;
							}
						}
						goto IL_164a;
					}
					int num25 = 0;
					while (true)
					{
						if (num4 != num15)
						{
							int num26 = Class89.smethod_39(characterAccountConfig);
							Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_1);
							num2 = 0;
							Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_1);
							if (int_1 != 4)
							{
								break;
							}
							num8 = BitConverter.ToUInt32(array, 0);
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_1);
							num9 = BitConverter.ToUInt32(array, 0);
							num10 = num9 * Class56.memorySignatureScanConfig_15.uint_0;
							Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_1);
							if (int_1 != 4)
							{
								break;
							}
							num11 = BitConverter.ToUInt32(array, 0);
							num12 = num11 + num10;
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_1);
							num14 = BitConverter.ToInt32(array, 0);
							Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_1);
							num15 = BitConverter.ToInt32(array, 0);
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_1);
							num16 = BitConverter.ToInt32(array, 0);
							if (num16 <= 0 && num25 <= 10 && (num26 == 0 || num26 == 1 || num14 <= 0 || num15 <= 0))
							{
								num25++;
								Thread.Sleep(100);
								continue;
							}
						}
						num4 = num15;
						break;
					}
					break;
					IL_07ac:
					Class64.smethod_30(characterAccountConfig);
					if (characterAccountConfig.int_127[0] != 2)
					{
						if (characterAccountConfig.int_127[0] > 0)
						{
							bool flag4 = characterAccountConfig.int_127[1] > 0 && characterAccountConfig.int_127[2] > 0;
							bool flag5 = characterAccountConfig.int_127[3] > 0 && characterAccountConfig.int_127[4] > 0;
							if (flag4 && !flag5)
							{
								num24 = characterAccountConfig.int_127[2];
							}
							else if (flag5 && !flag4)
							{
								num24 = characterAccountConfig.int_127[4];
							}
							else if (flag4 && flag5)
							{
								num24 = ((0 > num6 || num6 > 25) ? characterAccountConfig.int_127[4] : characterAccountConfig.int_127[2]);
								if (num6 > 35)
								{
									num6 = 0;
								}
								num6++;
							}
						}
						if (num24 <= 0)
						{
							num24 = Class83.smethod_13(characterAccountConfig);
						}
						Class83.smethod_9(characterAccountConfig);
						Class83.smethod_5(characterAccountConfig, num24, 6, 1);
						for (int k = 0; k < 3; k++)
						{
							if (FormDame.int_14 > 0)
							{
								Class24.smethod_76(characterAccountConfig.uint_4, 32);
							}
							else
							{
								Class24.smethod_76(characterAccountConfig.uint_4, 117);
							}
							if (k < 2)
							{
								Thread.Sleep(60);
							}
						}
					}
					else
					{
						Class64.smethod_0(characterAccountConfig.uint_4, characterAccountConfig.int_129, FormDame.int_12);
					}
					goto IL_164a;
					IL_0778:
					num24 = 0;
					goto IL_090e;
					IL_090e:
					if (flag2)
					{
						if (!Class46.smethod_7(characterAccountConfig, ref int_2) && Class89.smethod_12(characterAccountConfig) != 1)
						{
							num15 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
							array4 = new uint[2]
							{
								Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
								Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
							};
							int[,] array6 = null;
							if (characterAccountConfig.int_119 > 0 && characterAccountConfig.int_3 != null)
							{
								array6 = Class72.smethod_6(characterAccountConfig, 0u, int_3, array4);
								if (array6 != null && array6[0, 0] >= 0)
								{
									int num27 = -1;
									bool flag6 = false;
									bool flag7 = false;
									num2 = 0;
									while (true)
									{
										int num28 = 0;
										int num29 = 400;
										uint num30 = 0u;
										while (num28 <= 0)
										{
											num27++;
											if (characterAccountConfig.int_3 != null && characterAccountConfig.int_3.GetLength(0) > num27 && characterAccountConfig.int_4 != null)
											{
												num28 = characterAccountConfig.int_3[num27, 0];
												if (num28 > 0)
												{
													num29 = Class83.smethod_20(characterAccountConfig, num28, characterAccountConfig.int_3[num27, 1]);
													break;
												}
												continue;
											}
											goto IL_0e3a;
										}
										Class24.ReadProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_1);
										num13 = BitConverter.ToInt32(array, 0);
										Class24.ReadProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_1);
										num14 = BitConverter.ToInt32(array, 0);
										Class24.ReadProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_1);
										num16 = BitConverter.ToInt32(array, 0);
										Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_1);
										int num31 = BitConverter.ToInt32(array, 0);
										if (num16 > 0 && num15 == num31 && num13 != 11 && num13 != 22 && num14 != 0)
										{
											for (int l = 0; l < array6.GetLength(0); l++)
											{
												if (Class46.smethod_7(characterAccountConfig, ref int_2) || Class89.smethod_12(characterAccountConfig) == 1)
												{
													goto IL_0e00;
												}
												int num32 = array6[l, 0];
												num22 = array6[l, 1];
												if (num22 <= 0)
												{
													continue;
												}
												num30 = num11 + (uint)(num22 * (int)Class56.memorySignatureScanConfig_15.uint_0);
												Class24.ReadProcessMemory(characterAccountConfig.int_137, num30 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_1);
												if (BitConverter.ToInt32(array, 0) <= 0)
												{
													continue;
												}
												if (num32 > 0)
												{
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num30 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_1);
													if (BitConverter.ToInt32(array, 0) <= 0)
													{
														continue;
													}
												}
												flag6 = true;
												if (!flag7 || num32 > 0)
												{
													if (num32 > 0)
													{
														flag7 = true;
													}
													if (Class3.smethod_31(characterAccountConfig, num22, num28) != 0)
													{
														continue;
													}
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_1);
													array5[0] = BitConverter.ToUInt32(array, 0);
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_1);
													array5[1] = BitConverter.ToUInt32(array, 0);
													array4 = new uint[2]
													{
														Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
														Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
													};
													if (Class64.smethod_18(array4, array5) > num29 * num29 && characterAccountConfig.int_95 <= 0)
													{
														continue;
													}
													for (int m = 0; m < Class56.int_0; m++)
													{
														Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array, 1, ref int_1);
														if (array[0] == 0)
														{
															break;
														}
														Thread.Sleep(1);
													}
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(num28), 4, ref int_1);
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num29), 4, ref int_1);
													Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num22), 4, ref int_1);
													Thread.Sleep(10);
													num2 = 1;
													continue;
												}
												goto IL_0e3a;
											}
											continue;
										}
										if (num2 > 0)
										{
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_1);
										}
										num2 = 0;
										break;
										IL_0e00:
										num2 = 0;
										Thread.Sleep(100);
										break;
										IL_0e3a:
										if (num2 <= 0 && characterAccountConfig.int_6 <= 0 && flag6)
										{
											long num33 = 0L;
											array4 = new uint[2]
											{
												Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
												Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
											};
											num22 = -1;
											flag7 = false;
											int num34 = 0;
											int length = array6.GetLength(1);
											for (int n = 0; n < array6.GetLength(0); n++)
											{
												int num35 = array6[n, 0];
												int num36 = array6[n, 1];
												_ = array6[n, 2];
												int num37 = 0;
												if (length > 10)
												{
													num37 = array6[n, 10];
												}
												if (num36 <= 0)
												{
													continue;
												}
												num30 = num11 + (uint)(num36 * (int)Class56.memorySignatureScanConfig_15.uint_0);
												Class24.ReadProcessMemory(characterAccountConfig.int_137, num30 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_1);
												if (BitConverter.ToInt32(array, 0) <= 0)
												{
													continue;
												}
												if (num35 > 0)
												{
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num30 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_1);
													if (BitConverter.ToInt32(array, 0) <= 0)
													{
														continue;
													}
												}
												if (flag7 && num35 <= 0 && num22 > 0)
												{
													break;
												}
												Class24.ReadProcessMemory(characterAccountConfig.int_137, num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_1);
												array5[0] = BitConverter.ToUInt32(array, 0);
												Class24.ReadProcessMemory(characterAccountConfig.int_137, num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_1);
												array5[1] = BitConverter.ToUInt32(array, 0);
												long num38 = Class64.smethod_18(array4, array5);
												if ((num22 <= 0 || num33 >= num38) && (num38 <= num23 * num23 || characterAccountConfig.int_95 > 0))
												{
													if (num35 > 0)
													{
														flag7 = true;
													}
													num22 = num36;
													num34 = num37;
													num33 = num38;
												}
											}
											if (num22 <= 0)
											{
												break;
											}
											if (Form1.int_122 > 0 && flag)
											{
												if (num34 <= 0)
												{
													num30 = num11 + (uint)(num22 * (int)Class56.memorySignatureScanConfig_15.uint_0);
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_1);
													array5[0] = BitConverter.ToUInt32(array, 0);
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_1);
													array5[1] = BitConverter.ToUInt32(array, 0);
													if (Class72.smethod_4(characterAccountConfig.int_137, num15, array5) != 0)
													{
														num34 = 1;
													}
													else
													{
														uint num39 = (uint)((int)num11 + num22 * (int)Class56.memorySignatureScanConfig_15.uint_0 + (int)Class56.memorySignatureScanConfig_57.uint_0) + Class56.memorySignatureScanConfig_2.uint_0;
														for (uint num40 = 0u; num40 < 6; num40++)
														{
															Class24.ReadProcessMemory(characterAccountConfig.int_137, num39 + Class56.memorySignatureScanConfig_3.uint_0 * num40, array, 4, ref int_1);
															if (BitConverter.ToInt32(array, 0) == 45)
															{
																num34 = 1;
																break;
															}
														}
													}
												}
												if (num34 > 0)
												{
													num22 = 0;
													num2 = 0;
													break;
												}
											}
											Class64.smethod_30(characterAccountConfig);
											for (int num41 = 0; num41 < Class56.int_0; num41++)
											{
												Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array, 1, ref int_1);
												if (array[0] == 0)
												{
													break;
												}
												Thread.Sleep(1);
											}
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(Class83.smethod_13(characterAccountConfig)), 4, ref int_1);
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num23), 4, ref int_1);
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num22), 4, ref int_1);
										}
										else if (flag6 && num2 <= 0 && characterAccountConfig.int_6 > 0)
										{
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_1);
										}
										break;
									}
								}
							}
							else
							{
								array6 = Class72.smethod_5(characterAccountConfig, 0u, int_3, array4, Class72.int_0);
								if (array6 != null)
								{
									if (array6[0, 0] == -100)
									{
										break;
									}
									int num42 = 0;
									while (true)
									{
										if (array6[num42, 1] > 0)
										{
											array5 = new uint[2]
											{
												(uint)array6[num42, 4],
												(uint)array6[num42, 5]
											};
											if (Class64.smethod_18(array4, array5) > num23 * num23 && characterAccountConfig.int_95 <= 0)
											{
												if (characterAccountConfig.int_88 != 1 || num42 != 0)
												{
													break;
												}
												num42 = 1;
												continue;
											}
											int num43 = array6[num42, 0];
											num22 = array6[num42, 1];
											int num44 = array6[num42, 2];
											if (Form1.int_56 > 0 && (num43 <= 0 || num43 == array2[0]) && array2[1] > 0 && array2[2] == num15 && array2[3] > 0)
											{
												int num45 = array2[0];
												int num46 = array2[1];
												int num47 = array2[4];
												uint num48 = num11 + (uint)(num46 * (int)Class56.memorySignatureScanConfig_15.uint_0);
												Class24.ReadProcessMemory(characterAccountConfig.int_137, num48 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_1);
												if (BitConverter.ToInt32(array, 0) > 0)
												{
													Class24.ReadProcessMemory(characterAccountConfig.int_137, num48 + Class56.memorySignatureScanConfig_45.uint_0, array, 4, ref int_1);
													long num49 = BitConverter.ToInt32(array, 0);
													if ((ulong)num49 > 0uL)
													{
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num48 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_1);
														if (num45 <= 0 || BitConverter.ToInt32(array, 0) > 0)
														{
															array5 = new uint[2]
															{
																Class24.smethod_30(num48 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
																Class24.smethod_30(num48 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
															};
															long num50 = Class64.smethod_18(array4, array5);
															if (num50 <= num23 * num23)
															{
																num43 = num45;
																num22 = num46;
																num44 = num47;
															}
														}
													}
												}
											}
											array2[0] = num43;
											array2[1] = num22;
											array2[2] = num15;
											array2[3] = 0;
											array2[4] = num44;
											if (num22 <= 0)
											{
												break;
											}
											array2[3] = 1;
											num2 = 1;
											num3 = 1;
											Class64.smethod_30(characterAccountConfig);
											for (int num51 = 0; num51 < Class56.int_0; num51++)
											{
												Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array, 1, ref int_1);
												if (array[0] == 0)
												{
													break;
												}
												Thread.Sleep(1);
											}
											if (characterAccountConfig.gstruct50_0.int_0 == 0 || Class72.smethod_10(characterAccountConfig, (uint)num22) <= 0)
											{
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(Class83.smethod_13(characterAccountConfig)), 4, ref int_1);
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num23), 4, ref int_1);
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num22), 4, ref int_1);
											}
											break;
										}
										if (num2 > 0)
										{
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num12 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_1);
										}
										num2 = 0;
										break;
									}
								}
								else
								{
									flag2 = false;
								}
							}
						}
						else
						{
							Thread.Sleep(100);
							num2 = 0;
						}
					}
					goto IL_164a;
					IL_164a:
					if (!characterAccountConfig.bool_58 || characterAccountConfig.int_83 <= 0)
					{
						break;
					}
					if (Form1.int_106 == 0)
					{
						if (num22 > 0 && Class11.smethod_28(long_2) > characterAccountConfig.long_9)
						{
							Class38.smethod_54(characterAccountConfig, array5, bool_0: false);
							Class38.smethod_55(characterAccountConfig);
							long_2 = Class11.smethod_27();
						}
					}
					else if (Class46.characterSyncSnapshot_0.int_7 == Class30.gstruct42_0[Form1.int_107].int_0)
					{
						Class38.smethod_54(characterAccountConfig, null, bool_0: true);
						if (Class11.smethod_28(long_2) > characterAccountConfig.long_9)
						{
							Class38.smethod_55(characterAccountConfig);
							long_2 = Class11.smethod_27();
						}
					}
					break;
					continue;
					end_IL_0440:
					break;
				}
			}
			else
			{
				Thread.Sleep(60);
			}
		}
	}
}
