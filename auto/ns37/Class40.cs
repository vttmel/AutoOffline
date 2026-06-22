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
using ns18;
using ns23;
using ns29;
using ns3;
using ns35;
using ns43;
using ns44;
using ns52;
using ns53;
using ns61;
using ns63;
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

namespace ns37;

internal class Class40
{
	public struct Struct17
	{
		public int int_0;

		public string string_0;

		public uint[] uint_0;

		public uint[] uint_1;

		public int int_1;

		public uint[,] uint_2;
	}

	public static string string_0;

	public static uint[] uint_0;

	public static uint[] uint_1;

	public static int int_0;

	public static Struct17 struct17_0;

	public static Struct17 struct17_1;

	public static Struct17 struct17_2;

	public static Struct17 struct17_3;

	static Class40()
	{
		string_0 = Class66.smethod_7("TenHieuthuocTamtru", 0);
		uint_0 = new uint[2]
		{
			Class66.smethod_5("ToadoHieuthuocTamtru_0", 0, "0"),
			Class66.smethod_5("ToadoHieuthuocTamtru_1", 0, "0")
		};
		uint_1 = new uint[2]
		{
			Class66.smethod_5("ToadoCongTamtru_0", 0, "0"),
			Class66.smethod_5("ToadoCongTamtru_1", 0, "0")
		};
		int_0 = 221;
		Struct17 @struct = new Struct17
		{
			int_0 = 223,
			string_0 = "VÖ binh",
			uint_0 = new uint[2] { 50433u, 101080u }
		};
		uint[,] array = new uint[5, 2];
		Class10.smethod_4(array, 175306);
		@struct.uint_2 = array;
		@struct.uint_1 = new uint[2] { 50537u, 101022u };
		@struct.int_1 = 130;
		struct17_0 = @struct;
		Struct17 struct2 = new Struct17
		{
			int_0 = int_0,
			string_0 = "d\u00adîc|phu",
			uint_0 = new uint[2] { 52640u, 104288u }
		};
		uint[,] array2 = new uint[5, 2];
		Class10.smethod_4(array2, 175399);
		struct2.uint_2 = array2;
		struct2.uint_1 = new uint[2] { 51803u, 103870u };
		struct2.int_1 = 140;
		struct17_1 = struct2;
		Struct17 struct3 = new Struct17
		{
			int_0 = 222,
			string_0 = "VÖ binh",
			uint_0 = new uint[2] { 50433u, 101080u }
		};
		uint[,] array3 = new uint[6, 2];
		Class10.smethod_4(array3, 175496);
		struct3.uint_2 = array3;
		struct3.uint_1 = new uint[2] { 50533u, 100992u };
		struct3.int_1 = 130;
		struct17_2 = struct3;
		Struct17 struct4 = new Struct17
		{
			int_0 = int_0,
			string_0 = "d\u00adîc|phu",
			uint_0 = new uint[2] { 42272u, 93408u }
		};
		uint[,] array4 = new uint[9, 2];
		Class10.smethod_4(array4, 175597);
		struct4.uint_2 = array4;
		struct4.uint_1 = new uint[2] { 42447u, 93736u };
		struct4.int_1 = 310;
		struct17_3 = struct4;
	}

	public static void smethod_0(int int_1)
	{
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		bool flag = false;
		bool flag2 = false;
		int num = 0;
		int num2 = 0;
		int num3 = -1;
		int num4 = 0;
		int int_2 = 0;
		int int_3 = 0;
		int num5 = 0;
		int num6 = -1;
		uint num7 = 0u;
		uint uint_ = 0u;
		uint[] array = null;
		int num8 = 0;
		long num9 = 0L;
		long long_ = 0L;
		long num10 = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		int num11 = -1;
		int int_4 = 0;
		int int_5 = 0;
		int num12 = -1;
		int num13 = 0;
		bool flag3 = false;
		bool flag4 = false;
		uint[] array2 = null;
		int num14 = 0;
		int num15 = 0;
		int num16 = 0;
		int num17 = 0;
		int int_6 = -1;
		int[] array3 = new int[4];
		int int_7 = 0;
		byte[] byte_ = new byte[4];
		byte[] array4 = new byte[4];
		bool flag5 = false;
		bool flag6 = false;
		int num18 = 0;
		int[] array5 = new int[10];
		for (int i = 0; i < array5.Length; i++)
		{
			array5[i] = 4;
		}
		while (true)
		{
			Thread.Sleep(200);
			num14 = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
			if (Class11.bool_0 || num14 < 0 || Form1.int_24 != 2 || Form1.int_28 != 1)
			{
				break;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num14];
			if (!characterAccountConfig.bool_25 || characterAccountConfig.bool_54 || characterAccountConfig.int_133[0] > 0 || characterAccountConfig.int_20[0] > 0)
			{
				break;
			}
			if (!characterAccountConfig.bool_15 && Class75.smethod_3(characterAccountConfig, Class75.uint_48, 4) <= 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array4, 4, ref array5[0]);
				uint num19 = BitConverter.ToUInt32(array4, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num19 + Class56.memorySignatureScanConfig_13.uint_0, array4, 4, ref array5[1]);
				uint num20 = BitConverter.ToUInt32(array4, 0);
				uint num21 = num20 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array4, 4, ref array5[2]);
				uint num22 = BitConverter.ToUInt32(array4, 0);
				uint num23 = num22 + num21;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num23, array4, 4, ref array5[3]);
				num7 = BitConverter.ToUInt32(array4, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_55.uint_0, array4, 4, ref array5[4]);
				int num24 = BitConverter.ToInt32(array4, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_50.uint_0, array4, 4, ref array5[5]);
				int num25 = BitConverter.ToInt32(array4, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array4, 4, ref array5[6]);
				int num26 = BitConverter.ToInt32(array4, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_43.uint_0, array4, 4, ref array5[7]);
				int num27 = BitConverter.ToInt32(array4, 0);
				int num28 = Class89.smethod_12(characterAccountConfig);
				if ((characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0) || (num28 != 1 && num28 != 2))
				{
					if (num17 <= 0)
					{
						array3[0] = 0;
						array3[1] = 0;
						array3[2] = 0;
						array3[3] = 0;
					}
					num17 = 0;
					int num29 = Class89.smethod_39(characterAccountConfig);
					if (num25 != 0 && num24 != 0 && num26 != 0 && num24 != 10 && num24 != 21 && num29 > 1)
					{
						uint[] array6 = new uint[2]
						{
							Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
							Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
						};
						uint[] array7 = new uint[2];
						if (array6[0] == 0 || array6[1] == 0)
						{
							continue;
						}
						if (!flag5)
						{
							num18 = 7;
							int num30 = 0;
							while (true)
							{
								if (num30 <= num18)
								{
									if (array5[num30] == 0)
									{
										break;
									}
									num30++;
									continue;
								}
								Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_23 * 4, array4, 1, ref int_7);
								if (array4[0] > 0)
								{
									flag = false;
									array4[0] = 0;
									Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_23 * 4, array4, 1, ref int_7);
								}
								int num32;
								bool flag7;
								int num34;
								bool flag9;
								bool flag10;
								bool flag8;
								long num35;
								Struct17 struct2;
								int num33;
								if (num12 == num26 && (num6 == Class46.characterSyncSnapshot_0.int_4 || Form1.int_25 <= 0))
								{
									if (num11 != num27)
									{
										int_3 = 0;
										array = null;
										int num31 = 0;
										while (num27 == 0 && num31 < 30 && num27 != num11)
										{
											Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array4, 4, ref int_7);
											num19 = BitConverter.ToUInt32(array4, 0);
											Class24.ReadProcessMemory(characterAccountConfig.int_137, num19 + Class56.memorySignatureScanConfig_13.uint_0, array4, 4, ref int_7);
											num20 = BitConverter.ToUInt32(array4, 0);
											num21 = num20 * Class56.memorySignatureScanConfig_15.uint_0;
											Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array4, 4, ref int_7);
											num22 = BitConverter.ToUInt32(array4, 0);
											num23 = num22 + num21;
											Class24.ReadProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_43.uint_0, array4, 4, ref int_7);
											num27 = BitConverter.ToInt32(array4, 0);
											Thread.Sleep(10);
											num31++;
										}
										num11 = num27;
										if (num27 <= 0)
										{
											Thread.Sleep(150);
											Class95.smethod_8(characterAccountConfig);
											break;
										}
									}
									num32 = 600;
									if (characterAccountConfig.int_98 > 0)
									{
										num32 = characterAccountConfig.int_99;
									}
									if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0)
									{
										Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_43 * 4, array4, 4, ref int_7);
										characterAccountConfig.int_97 = BitConverter.ToInt32(array4, 0);
									}
									num33 = characterAccountConfig.int_97;
									if (characterAccountConfig.int_95 > 0 && characterAccountConfig.int_96 > 0)
									{
										num33 = characterAccountConfig.int_96;
									}
									if (num33 <= 0)
									{
										num33 = 500;
									}
									num15 = Form1.int_27;
									if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0)
									{
										if (num33 <= 180 && num15 < Form1.int_57)
										{
											num15 = Form1.int_57;
										}
										if (characterAccountConfig.int_131[0] > 0 && Form1.int_31 > 0 && num15 > 180)
										{
											num15 = 180;
										}
										if (flag6)
										{
											if (num27 > 0)
											{
												num15 = characterAccountConfig.gstruct50_0.int_9;
											}
											flag6 = false;
										}
									}
									array2 = array6;
									flag4 = false;
									flag7 = false;
									flag8 = false;
									num34 = 0;
									if (num27 > 0 && num26 == int_0)
									{
										flag = false;
										flag = false;
										if (Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137) == 0)
										{
											break;
										}
										flag9 = (Form1.int_10 > 0 || Form1.int_11 > 0) && Form1.int_25 > 0 && (Class46.characterSyncSnapshot_1.int_3 > 0 || Form1.int_26 > 0) && Class46.characterSyncSnapshot_1.int_4 > 0 && Class11.smethod_63(Class46.characterSyncSnapshot_1.uint_4) && (characterAccountConfig.int_136 == Class46.characterSyncSnapshot_0.int_0 || Class46.characterSyncSnapshot_0.int_0 <= 0);
										flag10 = Form1.int_25 > 0 && Class46.characterSyncSnapshot_0.int_0 > 0 && Class46.characterSyncSnapshot_0.int_0 != characterAccountConfig.int_136 && Class46.characterSyncSnapshot_0.int_6 > 0 && Class11.smethod_63(Class46.characterSyncSnapshot_0.uint_4) && Class46.characterSyncSnapshot_0.int_4 == num26 && Class46.characterSyncSnapshot_0.int_3 > 0;
										flag8 = !characterAccountConfig.bool_22 && (Form1.int_35 > 0 || Form1.int_34 > 0);
										array6 = new uint[2]
										{
											Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
											Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
										};
										if (flag10 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0)
										{
											array6 = new uint[2]
											{
												Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
												Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
											};
											num35 = Class64.smethod_18(array6, Class46.characterSyncSnapshot_0.uint_4);
											if (characterAccountConfig.int_130[0] > 0 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && num27 == Class46.characterSyncSnapshot_0.int_3 && num27 > 0)
											{
												int num36 = characterAccountConfig.int_130[1] + Form1.int_27;
												if (num35 <= num36 * num36 && Class68.smethod_0(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4, characterAccountConfig.int_130[1]) > 0)
												{
													goto IL_268d;
												}
											}
											if (flag3 || num35 > num15 * num15)
											{
												goto IL_0b6e;
											}
											Class13.smethod_2(characterAccountConfig, bool_0: false);
											int num37 = num5;
											num5 = 0;
											int_3 = 0;
											if (num27 > 0 && !characterAccountConfig.bool_22 && characterAccountConfig.int_93 == 1 && Form1.int_109 > 0 && (Form1.int_35 > 0 || Form1.int_34 > 0 || Form1.int_36 > 0) && Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137) != 0)
											{
												Class64.smethod_30(characterAccountConfig);
											}
											if (num9 <= 0L || Class11.smethod_28(num9) >= 1500L)
											{
												uint[] array8 = new uint[2]
												{
													array6[0],
													array6[1]
												};
												if (Class46.smethod_5(num7, ref array6, ref uint_) > 0)
												{
													long num38 = Class64.smethod_18(array8, Class46.characterSyncSnapshot_0.uint_4);
													long num39 = Class64.smethod_18(array6, Class46.characterSyncSnapshot_0.uint_4);
													if (num39 > num15 * num15)
													{
														if (num37 > 0)
														{
															uint[] uint_2 = Class64.smethod_5(array6, Class46.characterSyncSnapshot_0.uint_4, -100);
															Class75.smethod_61(characterAccountConfig, uint_2);
															Thread.Sleep(120);
														}
														goto IL_0b6e;
													}
													num9 = Class11.smethod_27();
													if (num16 > 0)
													{
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
													}
													num16 = 0;
													Class46.smethod_6(characterAccountConfig, array6, Class46.characterSyncSnapshot_0.uint_4, num38 <= 5625L);
													goto IL_261e;
												}
												num9 = 0L;
												if (num16 == 0 && Class64.smethod_18(array8, Class46.characterSyncSnapshot_0.uint_4) > Form1.int_27 * Form1.int_27)
												{
													num8++;
													if (num8 > 3)
													{
														Class75.smethod_61(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4);
														Thread.Sleep(150);
														num8 = 0;
													}
												}
												if (Form1.int_31 > 0 && num27 > 0 && characterAccountConfig.int_131[0] > 0 && Class75.smethod_3(characterAccountConfig, Class75.uint_31, 4) == 0)
												{
													Class75.smethod_2(characterAccountConfig, Class75.uint_31, 1, 4);
												}
											}
											int_3 = 0;
											array = null;
											array2 = Class46.characterSyncSnapshot_0.uint_4;
											flag4 = true;
										}
										else
										{
											if (characterAccountConfig.int_68 != null && characterAccountConfig.int_68[0] > 0 && !AuxiliaryMachineManager.bool_3)
											{
												uint[] array9 = null;
												if (num10 <= 0L || Class11.smethod_28(num10) >= 1000L)
												{
													array9 = Class64.smethod_26(characterAccountConfig, ref int_2);
													if (array9 != null)
													{
														num10 = 0L;
														long num40 = Class64.smethod_18(array6, array9);
														if (num40 < 8000L)
														{
															goto IL_0f74;
														}
														if (num40 >= 15000L && num40 >= characterAccountConfig.int_68[1] * characterAccountConfig.int_68[1])
														{
															if (num40 < 360000L)
															{
																Class13.smethod_2(characterAccountConfig, bool_0: false);
																if (num16 > 0)
																{
																	Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
																}
																num16 = 0;
																Class75.smethod_61(characterAccountConfig, array9);
																Thread.Sleep(200);
																break;
															}
															if (num40 < 1200000L)
															{
																if (Class11.smethod_28(long_) > 3000L)
																{
																	Class13.smethod_1(characterAccountConfig, array9);
																	long_ = Class11.smethod_27();
																}
																break;
															}
														}
														else
														{
															if (num24 <= 3 && num40 > 7500L)
															{
																if (num16 > 0)
																{
																	Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
																}
																num16 = 0;
																Class75.smethod_61(characterAccountConfig, array9);
																Thread.Sleep(200);
																goto IL_261e;
															}
															num40 = 4L;
														}
													}
													else
													{
														num10 = Class11.smethod_27();
													}
												}
											}
											if (flag9)
											{
												int num41 = AuxiliaryMachineManager.smethod_10(characterAccountConfig, ref long_, ref int_3, ref array);
												if (num41 <= 0)
												{
													Thread.Sleep(100);
													break;
												}
												num24 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
												if (num24 < 3)
												{
													array6 = new uint[2]
													{
														Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
														Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
													};
													if (Class64.smethod_18(array6, Class46.characterSyncSnapshot_1.uint_4) > 5625L)
													{
														if (num16 > 0)
														{
															Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
														}
														num16 = 0;
														Class75.smethod_61(characterAccountConfig, Class46.characterSyncSnapshot_1.uint_4);
														Thread.Sleep(150);
													}
												}
											}
										}
										goto IL_0f74;
									}
									if (num26 != struct17_0.int_0 && num26 != struct17_2.int_0)
									{
										Struct17 @struct = struct17_1;
										if (Form1.int_29 > 0)
										{
											@struct = struct17_3;
										}
										if (num26 != @struct.int_0)
										{
											Class64.smethod_10(characterAccountConfig, "<color=yellow>Cong Thanh Chien Tam Tru...");
											Thread.Sleep(300);
											break;
										}
										if (Form1.int_119 > 0 && characterAccountConfig.int_136 == Class46.characterSyncSnapshot_0.int_0 && ((Form1.int_10 <= 0 && Form1.int_11 <= 0) || Class46.characterSyncSnapshot_1.int_4 <= 0))
										{
											Class64.smethod_10(characterAccountConfig, "<color=pink>CTC Ac chÝnh ng\u00adêi dïng tù ®iÒu khiÓn..");
											Thread.Sleep(300);
											break;
										}
										Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_33 * 4, array4, 1, ref int_7);
										int num42 = array4[0];
										if (num42 <= 0)
										{
											Class64.smethod_29(characterAccountConfig, bool_0: false);
											if (flag && num3 >= 0 && num3 == Class85.smethod_4(characterAccountConfig))
											{
												num2 = 0;
												if (Class64.smethod_18(array6, uint_1) > 90000L)
												{
													if (Class11.smethod_28(long_) > 6000L)
													{
														Class13.smethod_1(characterAccountConfig, uint_1);
														long_ = Class11.smethod_27();
													}
													break;
												}
												num = 0;
												num4 = 0;
												while (!Class11.bool_0 && num4 < 50)
												{
													num26 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
													num27 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
													if (num26 != @struct.int_0 || num27 > 0)
													{
														break;
													}
													array6 = new uint[2]
													{
														Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
														Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
													};
													if (Class64.smethod_18(array6, uint_1) < 12500L)
													{
														break;
													}
													Class75.smethod_61(characterAccountConfig, uint_1);
													Thread.Sleep(300);
													num4++;
												}
												for (int j = 0; j < 3; j++)
												{
													Class64.smethod_25(characterAccountConfig, @struct.int_1);
													Thread.Sleep(300);
													int num43 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
													num27 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
													if (num43 != num26 || num27 > 0)
													{
														break;
													}
												}
												Thread.Sleep(600);
												Class95.smethod_8(characterAccountConfig);
												break;
											}
											if (!Form1.bool_18)
											{
												num2++;
												int num44 = smethod_1(characterAccountConfig);
												if (num44 <= 0 && num2 < 6)
												{
													Class64.smethod_13(characterAccountConfig);
													Thread.Sleep(300);
													break;
												}
											}
											num2 = 0;
											flag = true;
											num3 = Class85.smethod_4(characterAccountConfig);
											uint num45 = num19 + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_75.uint_0;
											uint num46 = Class24.smethod_30(num45 + Class56.memorySignatureScanConfig_74.uint_0, characterAccountConfig.int_137);
											if (num46 == 0)
											{
												break;
											}
											if (!flag2 && characterAccountConfig.string_15 != null && characterAccountConfig.string_15 != string.Empty)
											{
												uint num47 = Class11.smethod_12(characterAccountConfig.string_15);
												if (num47 != 0)
												{
													Class75.smethod_117(characterAccountConfig, num47);
													flag2 = true;
													Thread.Sleep(300);
												}
											}
											if (Form1.int_67[0] <= 0)
											{
												if (num46 > 6000000)
												{
													num46 = 6000000u;
												}
											}
											else if (num46 > Form1.int_67[1] * 10000)
											{
												num46 = (uint)(Form1.int_67[1] * 10000);
											}
											Class75.smethod_37(characterAccountConfig, num46);
											Thread.Sleep(100);
										}
										else
										{
											bool value = false;
											if (num27 == 0)
											{
												value = Class98.smethod_0(characterAccountConfig, bool_0: true) != 1;
											}
											array4[0] = Convert.ToByte(value);
											Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_33 * 4, array4, 1, ref int_7);
										}
										break;
									}
									struct2 = struct17_0;
									if (num26 == struct17_2.int_0)
									{
										struct2 = struct17_2;
									}
									if (Class64.smethod_18(array6, struct2.uint_1) > 90000L)
									{
										num++;
										if (num <= 3)
										{
											num30 = 0;
											while (num30 < 3)
											{
												array6 = new uint[2]
												{
													Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
													Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
												};
												if (Class64.smethod_18(array6, struct2.uint_1) >= 90000L)
												{
													Class64.smethod_22(characterAccountConfig, struct2.uint_2, array6, struct2.uint_1, struct2.int_0, bool_0: false, 8000);
													num27 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
													if (num27 > 0)
													{
														break;
													}
													num30++;
													continue;
												}
												goto IL_2cda;
											}
										}
										else
										{
											num = 0;
											if (Class11.smethod_28(long_) > 6000L)
											{
												Class13.smethod_1(characterAccountConfig, struct2.uint_1);
												long_ = Class11.smethod_27();
											}
										}
										break;
									}
									goto IL_2cda;
								}
								if (num16 > 0)
								{
									Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
								}
								num16 = 0;
								flag = false;
								flag2 = false;
								int num48 = 0;
								while (num12 != num26)
								{
									int num49 = Class89.smethod_39(characterAccountConfig);
									Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array4, 4, ref int_7);
									num19 = BitConverter.ToUInt32(array4, 0);
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num19 + Class56.memorySignatureScanConfig_13.uint_0, array4, 4, ref int_7);
									num20 = BitConverter.ToUInt32(array4, 0);
									num21 = num20 * Class56.memorySignatureScanConfig_15.uint_0;
									Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array4, 4, ref int_7);
									num22 = BitConverter.ToUInt32(array4, 0);
									num23 = num22 + num21;
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_50.uint_0, array4, 4, ref int_7);
									num25 = BitConverter.ToInt32(array4, 0);
									Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array4, 4, ref int_7);
									num26 = BitConverter.ToInt32(array4, 0);
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_43.uint_0, array4, 4, ref int_7);
									num27 = BitConverter.ToInt32(array4, 0);
									Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
									num16 = 0;
									if (num27 > 0 || num48 > 8 || (num49 != 0 && num49 != 1 && num25 > 0 && num26 > 0))
									{
										break;
									}
									num48++;
									Thread.Sleep(100);
								}
								num12 = num26;
								num6 = Class46.characterSyncSnapshot_0.int_4;
								break;
								IL_268d:
								if (!characterAccountConfig.bool_58 || characterAccountConfig.int_83 <= 0)
								{
									break;
								}
								if (Form1.int_106 == 0)
								{
									if (num34 > 0 && Class11.smethod_28(long_2) > characterAccountConfig.long_9)
									{
										Class38.smethod_54(characterAccountConfig, array7, bool_0: false);
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
								IL_2cda:
								num = 0;
								num4 = 0;
								while (!Class11.bool_0 && num4 < 50)
								{
									num26 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
									if (num26 != struct2.int_0)
									{
										break;
									}
									array6 = new uint[2]
									{
										Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
										Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
									};
									if (Class64.smethod_18(array6, struct2.uint_1) < 12500L)
									{
										break;
									}
									Class75.smethod_61(characterAccountConfig, struct2.uint_1);
									Thread.Sleep(300);
									num4++;
								}
								for (int k = 0; k < 3; k++)
								{
									Class64.smethod_25(characterAccountConfig, struct2.int_1);
									Thread.Sleep(300);
									int num50 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
									if (num50 != num26)
									{
										break;
									}
								}
								Thread.Sleep(600);
								Class95.smethod_8(characterAccountConfig);
								break;
								IL_261e:
								if (!flag8 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && Class38.smethod_58(characterAccountConfig, new int[2] { 0, 1 }) != 0)
								{
									if (num16 > 0)
									{
										Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
									}
									num16 = 0;
								}
								if (flag7 && num34 <= 0)
								{
									FormDuongMon.smethod_0(characterAccountConfig, ref int_4, array2, ref int_5, flag4);
								}
								goto IL_268d;
								IL_1c52:
								Thread.Sleep(100);
								num16 = 0;
								goto IL_261e;
								IL_1c61:
								if (num16 > 0)
								{
									Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
								}
								num16 = 0;
								goto IL_261e;
								IL_119e:
								int num51 = 0;
								goto IL_159b;
								IL_1c8e:
								bool flag11;
								int[,] array10;
								if (num16 <= 0 && characterAccountConfig.int_6 <= 0 && flag11)
								{
									long num52 = 0L;
									array6 = new uint[2]
									{
										Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
										Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
									};
									num34 = -1;
									bool flag12 = false;
									num33 = characterAccountConfig.int_97;
									if (characterAccountConfig.int_95 > 0 && characterAccountConfig.int_96 > 0)
									{
										num33 = characterAccountConfig.int_96;
									}
									if (num33 <= 0)
									{
										num33 = 500;
									}
									for (int l = 0; l < array10.GetLength(0); l++)
									{
										int num53 = array10[l, 0];
										int num54 = array10[l, 1];
										int num55 = num33;
										if (num54 <= 0)
										{
											continue;
										}
										uint num56 = num22 + (uint)(num54 * (int)Class56.memorySignatureScanConfig_15.uint_0);
										Class24.ReadProcessMemory(characterAccountConfig.int_137, num56 + Class56.memorySignatureScanConfig_50.uint_0, array4, 4, ref int_7);
										if (BitConverter.ToInt32(array4, 0) <= 0)
										{
											continue;
										}
										if (num53 > 0)
										{
											Class24.ReadProcessMemory(characterAccountConfig.int_137, num56 + Class56.memorySignatureScanConfig_43.uint_0, array4, 4, ref int_7);
											if (BitConverter.ToInt32(array4, 0) <= 0)
											{
												continue;
											}
										}
										if (flag12 && num53 <= 0 && num34 > 0)
										{
											break;
										}
										Class24.ReadProcessMemory(characterAccountConfig.int_137, num56 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array4, 4, ref int_7);
										array7[0] = BitConverter.ToUInt32(array4, 0);
										Class24.ReadProcessMemory(characterAccountConfig.int_137, num56 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array4, 4, ref int_7);
										array7[1] = BitConverter.ToUInt32(array4, 0);
										long num57 = Class64.smethod_18(array6, array7);
										if (num34 > 0 && num52 < num57)
										{
											continue;
										}
										if (flag10)
										{
											int num58 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array7));
											int num59 = (int)Math.Sqrt(Class64.smethod_18(array6, array7));
											int num60 = num58 - num15 + 10;
											if (num58 > num15 && num55 < num60 && (num59 > num58 || (num59 < num58 && num55 < num59)))
											{
												num55 = num60;
											}
										}
										if (num57 <= num55 * num55 || characterAccountConfig.int_95 > 0)
										{
											if (num53 > 0)
											{
												flag12 = true;
											}
											num34 = num54;
											num52 = num57;
											num33 = num55;
										}
									}
									if (num34 > 0)
									{
										Class64.smethod_30(characterAccountConfig);
										for (int m = 0; m < Class56.int_0; m++)
										{
											Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array4, 1, ref int_7);
											if (array4[0] == 0)
											{
												break;
											}
											Thread.Sleep(1);
										}
										Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(Class83.smethod_13(characterAccountConfig)), 4, ref int_7);
										Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num33), 4, ref int_7);
										Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num34), 4, ref int_7);
									}
								}
								else if (flag11 && num16 <= 0 && characterAccountConfig.int_6 > 0)
								{
									Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
								}
								goto IL_261e;
								IL_159b:
								if (flag8)
								{
									if (!Class46.smethod_7(characterAccountConfig, ref int_6) && Class89.smethod_12(characterAccountConfig) != 1)
									{
										num26 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
										array6 = new uint[2]
										{
											Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
											Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
										};
										uint[] uint_3 = array6;
										if (flag10 && Class46.characterSyncSnapshot_0.int_4 == num26 && Class46.characterSyncSnapshot_0.int_3 > 0 && Class46.characterSyncSnapshot_0.uint_4 != null)
										{
											uint_3 = Class46.characterSyncSnapshot_0.uint_4;
											num32 += num15;
										}
										uint num61 = 0u;
										if (Form1.int_37 > 0 && (flag9 || flag10))
										{
											if (flag9)
											{
												if (Class46.characterSyncSnapshot_1.int_4 == num26 && Class46.characterSyncSnapshot_1.uint_3 != num7)
												{
													num61 = Class46.characterSyncSnapshot_1.uint_3;
												}
											}
											else if (flag10 && Class46.characterSyncSnapshot_0.int_4 == num26 && Class46.characterSyncSnapshot_0.uint_3 != num7)
											{
												num61 = Class46.characterSyncSnapshot_0.uint_3;
											}
											if (num61 == 0 && Form1.int_38 <= 0)
											{
												goto IL_261e;
											}
										}
										array10 = null;
										if (characterAccountConfig.int_119 > 0 && characterAccountConfig.int_3 != null)
										{
											array10 = ((characterAccountConfig.int_5 > 0) ? Class72.smethod_5(characterAccountConfig, num61, num32, uint_3) : Class72.smethod_6(characterAccountConfig, num61, num32, uint_3));
											if (array10 != null && array10[0, 0] >= 0)
											{
												int num62 = -1;
												int int_8 = Class46.characterSyncSnapshot_0.int_4;
												num16 = 0;
												flag11 = false;
												bool flag13 = false;
												while (Class89.smethod_12(characterAccountConfig) != 1)
												{
													int num63 = 0;
													int num64 = 400;
													uint num65 = 0u;
													while (num63 <= 0)
													{
														num62++;
														if (characterAccountConfig.int_3 != null && characterAccountConfig.int_3.GetLength(0) > num62 && characterAccountConfig.int_4 != null)
														{
															num63 = characterAccountConfig.int_3[num62, 0];
															if (num63 > 0)
															{
																num64 = Class83.smethod_20(characterAccountConfig, num63, characterAccountConfig.int_3[num62, 1]);
																break;
															}
															continue;
														}
														goto IL_1c8e;
													}
													num24 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
													num25 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig.int_137);
													num27 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
													int num66 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
													if (num27 > 0 && num26 == num66 && num24 != 11 && num24 != 22 && num25 != 0)
													{
														for (int n = 0; n < array10.GetLength(0); n++)
														{
															if (Class46.smethod_7(characterAccountConfig, ref int_6) || Class89.smethod_12(characterAccountConfig) == 1)
															{
																goto IL_1c52;
															}
															int num67 = array10[n, 0];
															num34 = array10[n, 1];
															if (num34 <= 0)
															{
																continue;
															}
															num65 = num22 + (uint)(num34 * (int)Class56.memorySignatureScanConfig_15.uint_0);
															Class24.ReadProcessMemory(characterAccountConfig.int_137, num65 + Class56.memorySignatureScanConfig_50.uint_0, array4, 4, ref int_7);
															if (BitConverter.ToInt32(array4, 0) <= 0)
															{
																continue;
															}
															if (num67 > 0)
															{
																Class24.ReadProcessMemory(characterAccountConfig.int_137, num65 + Class56.memorySignatureScanConfig_43.uint_0, array4, 4, ref int_7);
																if (BitConverter.ToInt32(array4, 0) <= 0)
																{
																	continue;
																}
															}
															flag11 = true;
															if (!flag13 || num67 > 0)
															{
																if (num67 > 0)
																{
																	flag13 = true;
																}
																if (Class3.smethod_31(characterAccountConfig, num34, num63) != 0)
																{
																	continue;
																}
																num33 = num64;
																Class24.ReadProcessMemory(characterAccountConfig.int_137, num65 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array4, 4, ref int_7);
																array7[0] = BitConverter.ToUInt32(array4, 0);
																Class24.ReadProcessMemory(characterAccountConfig.int_137, num65 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array4, 4, ref int_7);
																array7[1] = BitConverter.ToUInt32(array4, 0);
																array6 = new uint[2]
																{
																	Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
																	Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
																};
																if (flag10)
																{
																	array6 = new uint[2]
																	{
																		Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
																		Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
																	};
																	long num68 = Class64.smethod_18(array6, Class46.characterSyncSnapshot_0.uint_4);
																	if (int_8 != Class46.characterSyncSnapshot_0.int_4 || num68 > num15 * num15)
																	{
																		goto IL_1c2f;
																	}
																	int num69 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array7));
																	int num70 = (int)Math.Sqrt(Class64.smethod_18(array6, array7));
																	int num71 = num69 - num15 + 10;
																	if (num69 > num15 && num33 < num71 && (num70 > num69 || (num70 < num69 && num33 < num70)))
																	{
																		num33 = num71;
																	}
																}
																if (Class64.smethod_18(array6, array7) > num33 * num33 && characterAccountConfig.int_95 <= 0)
																{
																	continue;
																}
																for (int num72 = 0; num72 < Class56.int_0; num72++)
																{
																	Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array4, 1, ref int_7);
																	if (array4[0] == 0)
																	{
																		break;
																	}
																	Thread.Sleep(1);
																}
																Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(num63), 4, ref int_7);
																Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num33), 4, ref int_7);
																Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num34), 4, ref int_7);
																Thread.Sleep(10);
																num16 = 1;
																continue;
															}
															goto IL_1c8e;
														}
														continue;
													}
													goto IL_1c61;
												}
												break;
											}
										}
										else if (!(flag8 = !characterAccountConfig.bool_22 && (Form1.int_35 > 0 || Form1.int_34 > 0)))
										{
											flag8 = false;
										}
										else
										{
											array10 = Class72.smethod_5(characterAccountConfig, num61, num32, uint_3);
											if (array10 != null)
											{
												if (array10[0, 0] == -100)
												{
													break;
												}
												int num73 = 0;
												while (true)
												{
													if (array10[num73, 1] > 0)
													{
														array7 = new uint[2]
														{
															(uint)array10[num73, 4],
															(uint)array10[num73, 5]
														};
														if (flag10)
														{
															int num74 = (int)Math.Sqrt(Class64.smethod_18(array6, array7));
															int num75 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array7));
															if (num74 - num33 > 0)
															{
																if (num75 > num74)
																{
																	int num76 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array6));
																	if (num76 + (num74 - num33) <= num15 + 10)
																	{
																		goto IL_2249;
																	}
																}
																if (characterAccountConfig.int_88 == 1 && num73 == 0)
																{
																	num73 = 1;
																	continue;
																}
																if (num15 + num33 <= num75)
																{
																	if (num16 > 0)
																	{
																		Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
																	}
																	num16 = 0;
																	break;
																}
															}
														}
														else if (Class64.smethod_18(array6, array7) > num33 * num33 && characterAccountConfig.int_95 <= 0)
														{
															if (characterAccountConfig.int_88 != 1 || num73 != 0)
															{
																break;
															}
															num73 = 1;
															continue;
														}
														goto IL_2249;
													}
													if (num16 > 0)
													{
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
													}
													num16 = 0;
													break;
													IL_2249:
													int num77 = array10[num73, 0];
													num34 = array10[num73, 1];
													_ = array10[num73, 2];
													if (Form1.int_56 > 0 && (num77 <= 0 || num77 == array3[0]) && array3[1] > 0 && array3[2] == num26 && array3[3] > 0)
													{
														int num78 = array3[0];
														int num79 = array3[1];
														uint num80 = num22 + (uint)(num79 * (int)Class56.memorySignatureScanConfig_15.uint_0);
														Class24.ReadProcessMemory(characterAccountConfig.int_137, num80 + Class56.memorySignatureScanConfig_50.uint_0, array4, 4, ref int_7);
														if (BitConverter.ToInt32(array4, 0) > 0)
														{
															Class24.ReadProcessMemory(characterAccountConfig.int_137, num80 + Class56.memorySignatureScanConfig_45.uint_0, array4, 4, ref int_7);
															long num81 = BitConverter.ToInt32(array4, 0);
															if ((ulong)num81 > 0uL)
															{
																Class24.ReadProcessMemory(characterAccountConfig.int_137, num80 + Class56.memorySignatureScanConfig_43.uint_0, array4, 4, ref int_7);
																if (num78 <= 0 || BitConverter.ToInt32(array4, 0) > 0)
																{
																	array7 = new uint[2]
																	{
																		Class24.smethod_30(num80 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
																		Class24.smethod_30(num80 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
																	};
																	long num82 = Class64.smethod_18(array6, array7);
																	if (!flag10)
																	{
																		if (num82 <= num33 * num33)
																		{
																			num77 = num78;
																			num34 = num79;
																		}
																	}
																	else
																	{
																		int num83 = (int)Math.Sqrt(num82);
																		int num84 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array7));
																		if (num83 - num33 > 0)
																		{
																			if (num84 > num83)
																			{
																				int num85 = (int)Math.Sqrt(Class64.smethod_18(Class46.characterSyncSnapshot_0.uint_4, array6));
																				if (num85 + (num83 - num33) <= num15 + 10)
																				{
																					num77 = num78;
																					num34 = num79;
																				}
																			}
																		}
																		else
																		{
																			num77 = num78;
																			num34 = num79;
																		}
																	}
																}
															}
														}
													}
													array3[0] = num77;
													array3[1] = num34;
													array3[2] = num26;
													array3[3] = 0;
													if (num34 <= 0)
													{
														break;
													}
													array3[3] = 1;
													num16 = 1;
													num17 = 1;
													Class64.smethod_30(characterAccountConfig);
													for (int num86 = 0; num86 < Class56.int_0; num86++)
													{
														Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array4, 1, ref int_7);
														if (array4[0] == 0)
														{
															break;
														}
														Thread.Sleep(1);
													}
													if (characterAccountConfig.gstruct50_0.int_0 == 0 || Class72.smethod_10(characterAccountConfig, (uint)num34) <= 0)
													{
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(Class83.smethod_13(characterAccountConfig)), 4, ref int_7);
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num33), 4, ref int_7);
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num34), 4, ref int_7);
													}
													flag6 = characterAccountConfig.gstruct50_0.int_0 > 0 && characterAccountConfig.gstruct50_0.int_1 > 0 && characterAccountConfig.gstruct50_0.int_8 > 0 && characterAccountConfig.gstruct50_0.int_9 > 0;
													break;
												}
											}
											else
											{
												flag8 = false;
											}
										}
									}
									else
									{
										Thread.Sleep(100);
										num16 = 0;
									}
								}
								goto IL_261e;
								IL_0f74:
								if (characterAccountConfig.int_101[0] > 0 && characterAccountConfig.int_101[1] > 0 && characterAccountConfig.string_23 == "NGAMY")
								{
									long num87 = Class11.smethod_28(long_3);
									if (num87 < 300L)
									{
										break;
									}
									if (num87 > characterAccountConfig.int_101[4] && Class72.smethod_3(characterAccountConfig))
									{
										Thread.Sleep(80);
										long_3 = Class11.smethod_27();
										break;
									}
								}
								for (int num88 = 0; num88 < Class56.int_0; num88++)
								{
									Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array4, 1, ref int_7);
									if (array4[0] == 0)
									{
										break;
									}
									Thread.Sleep(1);
								}
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
									flag7 = (flag14 || flag15 || flag16) && characterAccountConfig.string_23 == "DUONGMON";
									if (FormDame.int_6 <= 0 || characterAccountConfig.int_126 != 0 || flag7)
									{
										goto IL_159b;
									}
									if (flag8 || FormDame.int_10 > 0)
									{
										num51 = 0;
										if (FormDame.int_9 == 0)
										{
											goto IL_11d3;
										}
										bool flag17 = Class46.characterSyncSnapshot_0.int_8 == 1 || (flag9 && Class46.characterSyncSnapshot_1.int_8 == 1);
										if (FormDame.int_9 != 1)
										{
											if (FormDame.int_9 != 2 || flag17)
											{
												goto IL_119e;
											}
											if (num16 > 0)
											{
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
											}
											num16 = 0;
										}
										else
										{
											if (flag17)
											{
												goto IL_11d3;
											}
											if (FormDame.int_11 > 0)
											{
												goto IL_119e;
											}
											if (num16 > 0)
											{
												Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
											}
											num16 = 0;
										}
									}
								}
								goto IL_261e;
								IL_1c2f:
								Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
								goto IL_261e;
								IL_0b6e:
								flag3 = num35 > 40000L;
								Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
								num16 = 0;
								if (array == null)
								{
									array = new uint[2]
									{
										array6[0],
										array6[1]
									};
									int_3 = 0;
								}
								if (int_3 > 6)
								{
									long num89 = Class64.smethod_18(array, array6);
									array = null;
									if (num89 < 180000L)
									{
										Class13.smethod_2(characterAccountConfig, bool_0: false);
										Class64.smethod_2(characterAccountConfig, array6, Class46.characterSyncSnapshot_0.uint_4, 600);
										goto IL_261e;
									}
									int_3 = 0;
								}
								if (num35 > Form1.int_108 * Form1.int_108)
								{
									Class64.smethod_29(characterAccountConfig, bool_0: false);
								}
								if (num35 < 900000L && num5 < 6)
								{
									num5++;
									Class13.smethod_2(characterAccountConfig, bool_0: false);
									Class75.smethod_61(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4);
									Thread.Sleep(150);
									goto IL_261e;
								}
								if (Class46.characterSyncSnapshot_0.uint_4 != null && (!Class13.smethod_3(characterAccountConfig) || Class11.smethod_28(long_) > 3000L))
								{
									Class13.smethod_1(characterAccountConfig, Class46.characterSyncSnapshot_0.uint_4);
									long_ = Class11.smethod_27();
									int_3++;
									num5 = 0;
								}
								break;
								IL_11d3:
								uint num90 = 0u;
								uint[] uint_4 = null;
								uint[] array11 = null;
								if (!flag9)
								{
									if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136 && Class46.characterSyncSnapshot_0.uint_5 != 0)
									{
										uint num91 = Class46.characterSyncSnapshot_0.uint_5 >> 16;
										uint num92 = Class46.characterSyncSnapshot_0.uint_5 - (num91 << 16);
										uint_4 = Class89.smethod_11(Class46.characterSyncSnapshot_0.uint_4, (int)num92, (int)num91);
										uint[] array12 = Class89.smethod_10(array6, uint_4);
										num90 = (array12[1] << 16) + array12[0];
										array11 = Class46.characterSyncSnapshot_0.uint_4;
										Class89.smethod_7(characterAccountConfig, num90);
										Thread.Sleep(10);
									}
								}
								else
								{
									uint num93 = Class46.characterSyncSnapshot_1.uint_5 >> 16;
									uint num94 = Class46.characterSyncSnapshot_1.uint_5 - (num93 << 16);
									uint_4 = Class89.smethod_11(Class46.characterSyncSnapshot_1.uint_4, (int)num94, (int)num93);
									uint[] array13 = Class89.smethod_10(array6, uint_4);
									num90 = (array13[1] << 16) + array13[0];
									array11 = Class46.characterSyncSnapshot_1.uint_4;
									Class89.smethod_7(characterAccountConfig, num90);
									Thread.Sleep(10);
								}
								Class64.smethod_30(characterAccountConfig);
								if (characterAccountConfig.int_127[0] == 2)
								{
									Class64.smethod_0(characterAccountConfig.uint_4, characterAccountConfig.int_129, FormDame.int_12);
								}
								else
								{
									if (characterAccountConfig.int_127[0] == 1)
									{
										bool flag18 = characterAccountConfig.int_127[1] > 0 && characterAccountConfig.int_127[2] > 0;
										bool flag19 = characterAccountConfig.int_127[3] > 0 && characterAccountConfig.int_127[4] > 0;
										if (flag18 && !flag19)
										{
											num51 = characterAccountConfig.int_127[2];
										}
										else if (flag19 && !flag18)
										{
											num51 = characterAccountConfig.int_127[4];
										}
										else if (flag18 && flag19)
										{
											num51 = ((0 > num13 || num13 > 25) ? characterAccountConfig.int_127[4] : characterAccountConfig.int_127[2]);
											if (num13 > 35)
											{
												num13 = 0;
											}
											num13++;
										}
									}
									if (num51 <= 0)
									{
										num51 = Class83.smethod_13(characterAccountConfig);
									}
									if (characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 || Form1.int_10 > 0 || Form1.int_11 > 0)
									{
										Class83.smethod_9(characterAccountConfig);
									}
									Class83.smethod_5(characterAccountConfig, num51, 6, 1);
									for (int num95 = 0; num95 < 3; num95++)
									{
										if (FormDame.int_14 > 0)
										{
											Class24.smethod_76(characterAccountConfig.uint_4, 32);
										}
										else
										{
											Class24.smethod_76(characterAccountConfig.uint_4, 117);
										}
										if (num95 < 2)
										{
											Thread.Sleep(60);
										}
									}
								}
								if (num90 != 0 && characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136)
								{
									if (characterAccountConfig.int_95 <= 0)
									{
										Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_31.uint_0, characterAccountConfig.int_137);
										int num96 = Class83.smethod_13(characterAccountConfig);
										if (num96 == 53 || num96 <= 1)
										{
											goto IL_261e;
										}
										if (num96 <= 100)
										{
											num96 = 400;
										}
									}
									string string_ = Class89.smethod_20(characterAccountConfig);
									if (Class11.smethod_2(string_, "iÓm qu\u00b8 x"))
									{
										uint[] uint_5 = Class64.smethod_5(array11, uint_4, -1 * (Form1.int_27 - 50));
										long num97 = Class64.smethod_18(array6, uint_5);
										if (num97 > 7000L)
										{
											Class75.smethod_61(characterAccountConfig, uint_5);
											Thread.Sleep(150);
											Class89.smethod_21(characterAccountConfig, "0K..");
										}
									}
								}
								goto IL_261e;
							}
						}
						else
						{
							flag5 = false;
							Thread.Sleep(300);
						}
					}
					else
					{
						if (num29 <= 1)
						{
							flag2 = false;
						}
						flag5 = num24 == 10 || num24 == 21;
						Thread.Sleep(60);
					}
				}
				else
				{
					if (num16 > 0)
					{
						Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_7);
					}
					if (Form1.int_127 > 0)
					{
						Class24.WriteProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_251.uint_0, Class56.byte_0, Class56.byte_0.Length, ref int_7);
					}
					num16 = 0;
					num17 = 0;
				}
			}
			else
			{
				flag = false;
			}
		}
	}

	public static int smethod_1(CharacterAccountConfig characterAccountConfig_0)
	{
		if (string_0 != null && !(string_0 == string.Empty) && uint_0 != null && string_0[0] != 0)
		{
			int int_ = characterAccountConfig_0.int_136;
			int result = 0;
			int num = 0;
			int num2 = -1;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int int_2 = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[4];
			GStruct1[] array3 = null;
			Class64.smethod_10(characterAccountConfig_0, "Mua thuèc, xin chê chøt xÝu...");
			long long_ = 0L;
			while (true)
			{
				Thread.Sleep(300);
				int num8 = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (Class11.bool_0 || num8 < 0 || !Form1.characterAccountConfig_1[num8].bool_25)
				{
					break;
				}
				characterAccountConfig_0 = Form1.characterAccountConfig_1[num8];
				if ((characterAccountConfig_0.int_71[0] > 0 && characterAccountConfig_0.int_71[2] > 0) || (characterAccountConfig_0.int_72[0] > 0 && characterAccountConfig_0.int_72[2] > 0) || (characterAccountConfig_0.int_73[0] > 0 && characterAccountConfig_0.int_73[2] > 0))
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_2);
					uint num9 = BitConverter.ToUInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_13.uint_0, array2, 4, ref int_2);
					uint num10 = BitConverter.ToUInt32(array2, 0);
					uint num11 = num10 * Class56.memorySignatureScanConfig_15.uint_0;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array2, 4, ref int_2);
					uint num12 = BitConverter.ToUInt32(array2, 0);
					uint num13 = num12 + num11;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_55.uint_0, array2, 4, ref int_2);
					int num14 = BitConverter.ToInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_50.uint_0, array2, 4, ref int_2);
					int num15 = BitConverter.ToInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array2, 4, ref int_2);
					int num16 = BitConverter.ToInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_43.uint_0, array2, 4, ref int_2);
					int num17 = BitConverter.ToInt32(array2, 0);
					if (num14 != 10 && num14 != 21)
					{
						if (num15 != 0 && num14 != 0 && num16 != 0)
						{
							if (num17 <= 0)
							{
								if (Class85.smethod_25(characterAccountConfig_0) != 0)
								{
									if (num3 == 0)
									{
										Class75.smethod_2(characterAccountConfig_0, Class75.uint_32, 1, 4);
										Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num13 + Class56.memorySignatureScanConfig_72.uint_0, array, 4, ref int_2);
										num3 = 1;
									}
									Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
									uint[] array4 = new uint[2]
									{
										Class24.smethod_30(num13 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
										Class24.smethod_30(num13 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
									};
									if (array4[0] == 0 || array4[1] == 0)
									{
										continue;
									}
									int num18 = 0;
									if (Class64.smethod_18(array4, uint_0) > 90000L)
									{
										if (Class11.smethod_28(long_) > 4000L)
										{
											Class13.smethod_1(characterAccountConfig_0, uint_0);
											long_ = Class11.smethod_27();
										}
										continue;
									}
									num18 = 0;
									while (true)
									{
										if (!Class11.bool_0)
										{
											array4 = new uint[2]
											{
												Class24.smethod_30(num13 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
												Class24.smethod_30(num13 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
											};
											if (Class64.smethod_18(array4, uint_0) >= 22500L)
											{
												Class75.smethod_61(characterAccountConfig_0, uint_0);
												Thread.Sleep(300);
												num18++;
												if (num18 > 15)
												{
													result = -3;
													Class64.smethod_12(characterAccountConfig_0);
													break;
												}
												continue;
											}
										}
										uint[] array5 = null;
										if (num2 > 0)
										{
											string text = Class3.smethod_16(characterAccountConfig_0, num2, ref array5, 30);
											if (text == null || Class11.smethod_1(text, string_0) < 0)
											{
												num2 = 0;
												array5 = null;
											}
										}
										if (num2 <= 0)
										{
											num2 = Class3.smethod_15(characterAccountConfig_0, string_0, ref array5, 3, bool_0: false);
											if (num2 <= 0)
											{
												result = -4;
												Class64.smethod_12(characterAccountConfig_0);
												break;
											}
										}
										while (true)
										{
											for (num18 = 0; num18 < 10; num18++)
											{
												if (array5 == null)
												{
													break;
												}
												array4 = new uint[2]
												{
													Class24.smethod_30(num13 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
													Class24.smethod_30(num13 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
												};
												if (Class64.smethod_18(array4, array5) < 11250L)
												{
													break;
												}
												Class75.smethod_61(characterAccountConfig_0, array5);
												Thread.Sleep(300);
											}
											while (true)
											{
												Class95.smethod_8(characterAccountConfig_0);
												Thread.Sleep(100);
												Class38.smethod_10(characterAccountConfig_0, (uint)num2);
												Thread.Sleep(800);
												if (0 <= Class95.smethod_0(characterAccountConfig_0))
												{
													Class95.smethod_6(characterAccountConfig_0, "ua");
													Thread.Sleep(800);
												}
												if (num4 == 0)
												{
													if (characterAccountConfig_0.string_15 != null && characterAccountConfig_0.string_15 != string.Empty)
													{
														uint num19 = Class11.smethod_12(characterAccountConfig_0.string_15);
														if (num19 != 0)
														{
															Class75.smethod_117(characterAccountConfig_0, num19);
															Thread.Sleep(100);
														}
													}
													uint num20 = num9 + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_75.uint_0;
													long num21 = Class24.smethod_30(num20 + Class56.memorySignatureScanConfig_74.uint_0, characterAccountConfig_0.int_137);
													if (num21 > 0L)
													{
														if (Form1.int_67[0] <= 0)
														{
															if (num21 > 6000000L)
															{
																num21 = 6000000L;
															}
														}
														else if (num21 > Form1.int_67[1] * 10000)
														{
															num21 = Form1.int_67[1] * 10000;
														}
														Class75.smethod_37(characterAccountConfig_0, (uint)num21);
													}
													num4 = 1;
												}
												num18 = 0;
												while (!Class47.smethod_8(characterAccountConfig_0))
												{
													num18++;
													Thread.Sleep(60);
													if (num18 <= 10)
													{
														continue;
													}
													goto IL_0684;
												}
												break;
												IL_0684:
												num5++;
												if (num5 < 2)
												{
													continue;
												}
												goto IL_06e6;
											}
											num5 = 0;
											num6 = 0;
											num7 = 2;
											if (array3 == null)
											{
												array3 = Class19.smethod_1(characterAccountConfig_0);
												if (array3 == null)
												{
													result = -7;
													break;
												}
											}
											int num22 = 0;
											int num23 = 0;
											while (true)
											{
												num8 = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
												if (Class11.bool_0 || num8 < 0 || !Form1.characterAccountConfig_1[num8].bool_25)
												{
													break;
												}
												characterAccountConfig_0 = Form1.characterAccountConfig_1[num8];
												int num24 = -1;
												int num25 = 0;
												int num26 = 0;
												string text2 = null;
												string text3 = null;
												int[] array6 = null;
												if (num22 != 0)
												{
													if (num22 == 1)
													{
														array6 = characterAccountConfig_0.int_72;
														text2 = characterAccountConfig_0.string_12;
													}
													else
													{
														if (num22 != 2)
														{
															result = 1;
															break;
														}
														array6 = characterAccountConfig_0.int_73;
														text2 = characterAccountConfig_0.string_13;
													}
												}
												else
												{
													array6 = characterAccountConfig_0.int_71;
													text2 = characterAccountConfig_0.string_11;
												}
												if (array6[0] > 0 && array6[2] > 0 && text2 != null && text2 != string.Empty)
												{
													text2 = text2.Trim();
													text3 = text2.ToUpper();
													int num27 = -1;
													for (int i = 0; i < array3.Length; i++)
													{
														if (0 <= Class11.smethod_1(array3[i].string_0.ToUpper(), text3))
														{
															num27 = array3[i].int_0;
														}
														if (text2 == array3[i].string_0.Trim())
														{
															num24 = array3[i].int_0;
															break;
														}
													}
													if (num24 < 0)
													{
														num24 = num27;
														if (num24 < 0)
														{
															num22++;
															continue;
														}
													}
													num26 = Class85.smethod_31(characterAccountConfig_0, text2);
													num25 = array6[2] - num26;
													if (num25 > 0)
													{
														string empty = string.Empty;
														uint num28 = Class24.smethod_30(Class56.memorySignatureScanConfig_165.uint_0, characterAccountConfig_0.int_137);
														uint num29 = Class24.smethod_30(num28 + Class56.memorySignatureScanConfig_167.uint_0, characterAccountConfig_0.int_137);
														byte[] array7 = new byte[15];
														int num30 = Class85.smethod_4(characterAccountConfig_0);
														for (int j = 0; j < num25; j++)
														{
															Class75.smethod_41(characterAccountConfig_0, num24);
															Thread.Sleep(8 + Form1.int_118);
															if ((j == 0 || j % 8 != 0) && j + 1 != num25)
															{
																continue;
															}
															int num31 = Class85.smethod_4(characterAccountConfig_0);
															if (num31 == num30)
															{
																num23++;
																if (num23 > 10)
																{
																	result = 1;
																	goto end_IL_0750;
																}
															}
															else
															{
																num30 = num31;
																num23 = 0;
															}
															try
															{
																if (!Class11.bool_0 && Form1.characterAccountConfig_1[num8].bool_25)
																{
																	goto IL_0a5d;
																}
															}
															catch
															{
																goto IL_0a5d;
															}
															goto end_IL_0750;
															IL_0a5d:
															uint num32 = 0u;
															while (num32 < 2)
															{
																Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num29 + num32 * 4, array, 4, ref int_2);
																uint uint_ = BitConverter.ToUInt32(array, 0);
																Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array7, array7.Length, ref int_2);
																empty = Class1.smethod_3(array7);
																if (!(empty != string.Empty))
																{
																	num32++;
																	continue;
																}
																goto IL_0a26;
															}
															continue;
															IL_0a26:
															Class55.smethod_0(characterAccountConfig_0);
															if (Class11.smethod_1(empty, "ho¶ng trèng") > 0 && Class85.smethod_25(characterAccountConfig_0) == 0)
															{
																result = 1;
																goto end_IL_0750;
															}
														}
														continue;
													}
												}
												num22++;
												continue;
												end_IL_0750:
												break;
											}
											break;
											IL_06e6:
											num5 = 0;
											num6++;
											if (num6 < 2)
											{
												num8 = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
												if (0 <= num8)
												{
													Class64.smethod_12(characterAccountConfig_0);
													continue;
												}
											}
											result = -6;
											break;
										}
										break;
									}
								}
								else
								{
									result = 1;
								}
							}
							else
							{
								result = 1;
							}
						}
						else
						{
							Thread.Sleep(300);
							num++;
							if (num <= 3)
							{
								continue;
							}
							result = -1;
						}
					}
					else
					{
						result = -1;
					}
				}
				else
				{
					result = 1;
				}
				Class75.smethod_2(characterAccountConfig_0, Class75.uint_32, 0, 4);
				if (num7 > 0)
				{
					if (Form1.int_61 > 0 && Form1.int_63 > 0)
					{
						Class85.smethod_40(characterAccountConfig_0, 0, 0, num7 < 2);
					}
					Class47.smethod_11(characterAccountConfig_0);
				}
				Class75.smethod_52(characterAccountConfig_0, "Mua thuèc kÕt thóc !");
				return result;
			}
			return 0;
		}
		Class64.smethod_10(characterAccountConfig_0, Class1.smethod_2("<color=yellow>Không thể mua thuốc, bạn cần vào mục CTC Tam trụ để lấy tên hiệu thuốc..."));
		return 1;
	}
}
