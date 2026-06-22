using System;
using System.Threading;
using ns1;
using ns100;
using ns11;
using ns23;
using ns28;
using ns31;
using ns35;
using ns44;
using ns53;
using ns61;
using ns63;
using ns71;
using ns81;
using ns83;
using ns85;

namespace ns24;

internal class Class25
{
	public static int int_0 = 0;

	public static int int_1 = Class66.smethod_4("flagNguyenlieuBH", 0, "0");

	public void method_0()
	{
		int num = int_0;
		int_0 = 0;
		bool flag = false;
		bool flag2 = false;
		int int_ = 0;
		string text = "HuyÒn Tinh Kho\u00b8ng Th¹ch".ToLower();
		byte[] array = new byte[text.Length + 3];
		byte[] array2 = new byte[1];
		byte[] array3 = new byte[4];
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		int num2 = 0;
		int num3;
		while (true)
		{
			Thread.Sleep(300);
			num3 = Class87.smethod_3(Form1.characterAccountConfig_1, num);
			if (Class11.bool_0 || num3 < 0 || !Form1.characterAccountConfig_1[num3].bool_25 || Form1.characterAccountConfig_1[num3].byte_0[0] == 0)
			{
				break;
			}
			characterAccountConfig_ = Form1.characterAccountConfig_1[num3];
			uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_.int_137);
			uint num5 = Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_.int_137);
			uint num6 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_.int_137);
			uint num7 = num6 + num5 * Class56.memorySignatureScanConfig_15.uint_0;
			int num8 = (int)Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_.int_137);
			int num9 = (int)Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_.int_137);
			int num10 = Class89.smethod_39(characterAccountConfig_);
			if (num8 == 10 || num8 == 21 || num9 == 0 || num10 <= 1)
			{
				continue;
			}
			uint num11 = num4 + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_75.uint_0;
			if (!flag)
			{
				num3 = Class87.smethod_3(Form1.characterAccountConfig_1, num);
				if (0 <= num3)
				{
					Form1.characterAccountConfig_1[num3].bool_15 = true;
				}
				if (characterAccountConfig_.string_15 != null && characterAccountConfig_.string_15 != string.Empty)
				{
					uint num12 = Class11.smethod_12(characterAccountConfig_.string_15);
					if (num12 != 0)
					{
						Class75.smethod_117(characterAccountConfig_, num12);
						Thread.Sleep(100);
					}
					Thread.Sleep(350);
				}
				long num13 = Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_74.uint_0, characterAccountConfig_.int_137);
				if (num13 > 0L)
				{
					Class75.smethod_37(characterAccountConfig_, (uint)num13);
				}
				flag = true;
				Class75.smethod_52(characterAccountConfig_, "<color=yellow>Bat dau nang cap Huyen tinh...");
			}
			uint num14 = num4 + Class56.memorySignatureScanConfig_97.uint_0;
			uint num15 = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_.int_137);
			int num16 = -1;
			for (int i = 1; i < 10; i++)
			{
				if (characterAccountConfig_.byte_0[i] > 0)
				{
					num16 = i;
					break;
				}
			}
			if (num16 < 0)
			{
				break;
			}
			if (!flag2)
			{
				Class75.smethod_52(characterAccountConfig_, Class1.smethod_2("<color=yellow>Nâng cấp huyền tinh " + num16 + " -> " + (num16 + 1)));
				flag2 = true;
			}
			int num17 = 0;
			uint[] array4 = new uint[3];
			uint[] array5 = array4;
			int num18 = Class85.smethod_4(characterAccountConfig_);
			int num19 = 0;
			uint num20 = 1u;
			while (true)
			{
				if (num20 < Class56.int_1 && num18 > num19)
				{
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num14 + (num20 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array3, 4, ref int_);
					uint num21 = BitConverter.ToUInt32(array3, 0);
					if (num21 != 0)
					{
						uint num22 = num15 + num21 * Class56.memorySignatureScanConfig_106.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num22 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array3, 4, ref int_);
						if (BitConverter.ToInt32(array3, 0) == 0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num22 + Class56.memorySignatureScanConfig_107.uint_0, array2, 1, ref int_);
							if (array2[0] != 0)
							{
								num19++;
								uint num23 = num14 + num20 * 20;
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, num23 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 1, ref int_);
								uint num24 = array2[0];
								if (num24 == 1 || num24 == 3)
								{
									Class24.ReadProcessMemory(characterAccountConfig_.int_137, num22 + Class56.memorySignatureScanConfig_108.uint_0, array2, 1, ref int_);
									if (array2[0] == 6)
									{
										Class24.ReadProcessMemory(characterAccountConfig_.int_137, num22 + Class56.memorySignatureScanConfig_111.uint_0, array2, 1, ref int_);
										int num25 = array2[0];
										Class24.ReadProcessMemory(characterAccountConfig_.int_137, num22 + Class56.memorySignatureScanConfig_112.uint_0, array2, 1, ref int_);
										int num26 = array2[0];
										if (num25 == 1 && num26 == 1)
										{
											Class24.ReadProcessMemory(characterAccountConfig_.int_137, num22 + Class56.memorySignatureScanConfig_119.uint_0, array3, 4, ref int_);
											int num27 = BitConverter.ToInt32(array3, 0);
											if (num27 > 0)
											{
												Class24.ReadProcessMemory(characterAccountConfig_.int_137, num22 + Class56.memorySignatureScanConfig_114.uint_0, array2, 1, ref int_);
												if (array2[0] == num16)
												{
													Class24.ReadProcessMemory(characterAccountConfig_.int_137, num22 + Class56.memorySignatureScanConfig_107.uint_0, array, array.Length, ref int_);
													string string_ = Class1.smethod_3(array).ToLower();
													if (Class11.smethod_1(string_, text) >= 0)
													{
														if (num27 != 1)
														{
															uint[] array6 = Class85.smethod_26(characterAccountConfig_, 3u);
															if (array6 != null)
															{
																if (num24 != 1)
																{
																	int num28 = 0;
																	while (!Class11.bool_0 && Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_.int_137) == 0)
																	{
																		if (num28 % 20 == 0)
																		{
																			Class75.smethod_71(characterAccountConfig_, num21, 1u, 89);
																		}
																		if (num28 > 1500)
																		{
																			Class75.smethod_52(characterAccountConfig_, Class1.smethod_2("Không thể tách vật phẩm !"));
																			if (Class47.smethod_8(characterAccountConfig_))
																			{
																				Class47.smethod_11(characterAccountConfig_);
																			}
																			Thread.Sleep(300);
																			num28 = 0;
																		}
																		Thread.Sleep(10);
																		num28++;
																	}
																}
																int num29 = 0;
																while (!Class11.bool_0 && (int)Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_.int_137) > 0)
																{
																	if (num29 % 20 == 0)
																	{
																		Class75.smethod_46(characterAccountConfig_, array6[0], array6[1], 3u, array6[0], array6[1], 3u);
																	}
																	if (num29 > 1500)
																	{
																		Class75.smethod_52(characterAccountConfig_, Class1.smethod_2("Không thể đặt vật phẩm xuống !"));
																		if (Class47.smethod_8(characterAccountConfig_))
																		{
																			Class47.smethod_11(characterAccountConfig_);
																		}
																		Thread.Sleep(300);
																		num29 = 0;
																	}
																	Thread.Sleep(10);
																	num29++;
																}
																break;
															}
														}
														else
														{
															bool flag3 = false;
															for (int j = 0; j < array5.Length; j++)
															{
																if (array5[j] == num21)
																{
																	flag3 = true;
																	break;
																}
															}
															if (!flag3)
															{
																array5[num17] = num21;
																num17++;
																if (num17 > 2)
																{
																	num2++;
																	Class75.smethod_69(characterAccountConfig_, array5[0], array5[1], array5[2]);
																	if (num2 < 5)
																	{
																		break;
																	}
																	num2 = 0;
																	string string_2 = Class89.smethod_20(characterAccountConfig_);
																	if (Class11.smethod_2(string_2, "phi ph"))
																	{
																		Class89.smethod_21(characterAccountConfig_, "_open");
																		if (Class75.smethod_64(characterAccountConfig_))
																		{
																			Thread.Sleep(800);
																			Class47.smethod_11(characterAccountConfig_);
																		}
																	}
																	break;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					num20++;
					continue;
				}
				num3 = Class87.smethod_3(Form1.characterAccountConfig_1, num);
				if (0 <= num3)
				{
					Form1.characterAccountConfig_1[num3].byte_0[num16] = 0;
					flag2 = false;
				}
				break;
			}
		}
		Class75.smethod_52(characterAccountConfig_, "<color=yellow>Ket thuc nang cap Huyen tinh !");
		num3 = Class87.smethod_3(Form1.characterAccountConfig_1, num);
		if (0 <= num3)
		{
			if (Class47.smethod_8(characterAccountConfig_))
			{
				Class47.smethod_11(characterAccountConfig_);
			}
			Form1.characterAccountConfig_1[num3].byte_0 = new byte[11];
			Form1.characterAccountConfig_1[num3].byte_0[10] = 1;
			Form1.characterAccountConfig_1[num3].bool_15 = false;
		}
	}

	public void method_1()
	{
		int num = int_0;
		int_0 = 0;
		bool flag = false;
		bool flag2 = false;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = -1;
		int int_ = 0;
		long long_ = 0L;
		uint num6 = 0u;
		uint num7 = 0u;
		uint num8 = 0u;
		int int_2 = 0;
		byte[] array = new byte[4];
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		while (true)
		{
			num2--;
			Thread.Sleep(200);
			if (num2 <= 0)
			{
				num3 = Class87.smethod_3(Form1.characterAccountConfig_1, num);
				if (Class11.bool_0 || num3 < 0)
				{
					break;
				}
				characterAccountConfig_ = Form1.characterAccountConfig_1[num3];
				if (!characterAccountConfig_.bool_25 || (num5 != -1 && num5 != characterAccountConfig_.int_26))
				{
					break;
				}
				if (!flag)
				{
					Form1.characterAccountConfig_1[num3].bool_6 = true;
					num5 = characterAccountConfig_.int_26;
					Class75.smethod_52(characterAccountConfig_, Class1.smethod_2("<color=yellow>Bắt đầu chế tạo Huyền tinh..."));
					flag = true;
				}
				else if (!characterAccountConfig_.bool_6)
				{
					break;
				}
				int_ = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_.int_137);
				num2 = 10;
			}
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_2);
			uint num9 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_2);
			uint num10 = BitConverter.ToUInt32(array, 0);
			uint num11 = num9 + Class56.memorySignatureScanConfig_97.uint_0;
			uint[] array2 = new uint[3];
			int num12 = Class85.smethod_4(characterAccountConfig_);
			int num13 = 0;
			uint num14 = 1u;
			while (num14 < Class56.int_1)
			{
				if (array2[0] == 0 || array2[1] == 0 || array2[2] == 0)
				{
					if (num12 <= num13)
					{
						break;
					}
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num11 + (num14 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array, 4, ref int_2);
					uint num15 = BitConverter.ToUInt32(array, 0);
					if (num15 != 0)
					{
						uint num16 = num10 + num15 * Class56.memorySignatureScanConfig_106.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num16 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_2);
						if (BitConverter.ToInt32(array, 0) == 0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num16 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_2);
							if (array[0] != 0)
							{
								num13++;
								uint num17 = num11 + num14 * 20;
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, num17 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_2);
								uint num18 = array[0];
								if (num18 == 3 || (num18 == 23 && int_1 > 0))
								{
									Class24.ReadProcessMemory(characterAccountConfig_.int_137, num16 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_2);
									if (array[0] == 0)
									{
										Class24.ReadProcessMemory(characterAccountConfig_.int_137, num16 + Class56.memorySignatureScanConfig_110.uint_0, array, 1, ref int_2);
										uint num19 = array[0];
										if ((array2[0] == 0 && num19 == 3) || (array2[1] == 0 && num19 == 9) || (array2[2] == 0 && num19 == 4))
										{
											switch (num19)
											{
											default:
												array2[1] = num15;
												break;
											case 4u:
												array2[2] = num15;
												break;
											case 3u:
												array2[0] = num15;
												break;
											}
										}
									}
								}
							}
						}
					}
					num14++;
					continue;
				}
				goto IL_0291;
			}
			break;
			IL_0291:
			if (num6 == array2[0] && num7 == array2[1] && num8 == array2[2])
			{
				num4++;
				string string_ = Class89.smethod_20(characterAccountConfig_);
				if (!Class11.smethod_2(string_, "phi ph"))
				{
					if (!Class32.smethod_0(int_) && Class11.smethod_28(long_) > 600L)
					{
						bool flag3;
						if (!(flag3 = Class11.smethod_2(string_, "kh«ng ") && (Class11.smethod_2(string_, "TiÒn") || Class11.smethod_2(string_, "l\u00adîng"))))
						{
							flag3 = Class38.smethod_41(characterAccountConfig_) < 1000;
						}
						else
						{
							Class89.smethod_21(characterAccountConfig_, "0K..");
						}
						if (flag3)
						{
							if (!Class64.smethod_14(characterAccountConfig_) && Class75.smethod_3(characterAccountConfig_, Class75.uint_19, 4) > 0)
							{
								Class29.smethod_7(characterAccountConfig_, 37, "®«ng|§«ng");
							}
							Thread.Sleep(300);
						}
						long_ = Class11.smethod_27();
					}
				}
				else
				{
					Class89.smethod_21(characterAccountConfig_, "0K..");
					flag2 = Class75.smethod_64(characterAccountConfig_);
					Thread.Sleep(300);
				}
				if (num4 > 12)
				{
					Class89.smethod_31(characterAccountConfig_, "Khong the che tao Huyen tinh");
					break;
				}
			}
			else
			{
				num6 = array2[0];
				num7 = array2[1];
				num8 = array2[2];
				num4 = 0;
			}
			Class75.smethod_67(characterAccountConfig_, array2[0], array2[1], array2[2]);
		}
		num3 = Class87.smethod_3(Form1.characterAccountConfig_1, num);
		if (0 <= num3)
		{
			Form1.characterAccountConfig_1[num3].bool_6 = false;
			if (flag2)
			{
				Class47.smethod_11(characterAccountConfig_);
			}
			Class75.smethod_52(characterAccountConfig_, Class1.smethod_2("<color=yellow>Kết thúc chế tạo !"));
		}
	}
}
