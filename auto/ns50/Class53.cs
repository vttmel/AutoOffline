using System;
using System.Threading;
using ns1;
using ns10;
using ns100;
using ns11;
using ns13;
using ns23;
using ns28;
using ns3;
using ns34;
using ns35;
using ns36;
using ns41;
using ns42;
using ns43;
using ns44;
using ns53;
using ns56;
using ns61;
using ns71;
using ns83;
using ns85;
using ns88;

namespace ns50;

internal class Class53
{
	public struct Struct21
	{
		public int int_0;

		public string string_0;

		public string string_1;

		public uint[,] uint_0;
	}

	public static Struct21[] struct21_0;

	private static uint[,] uint_0;

	private static uint[,] uint_1;

	private static uint[,] uint_2;

	private static uint[,] uint_3;

	private static uint[,] uint_4;

	static Class53()
	{
		Struct21[] array = new Struct21[3];
		ref Struct21 reference = ref array[0];
		Struct21 @struct = new Struct21
		{
			int_0 = 221,
			string_0 = "truyÒn tèng"
		};
		uint[,] array_ = new uint[8, 2];
		Class10.smethod_4(array_, 236526);
		@struct.uint_0 = array_;
		reference = @struct;
		ref Struct21 reference2 = ref array[1];
		Struct21 struct2 = new Struct21
		{
			int_0 = 539,
			string_0 = "DÞch tr¹m",
			string_1 = "Rêi khái"
		};
		uint[,] array_2 = new uint[4, 2];
		Class10.smethod_4(array_2, 236607);
		struct2.uint_0 = array_2;
		reference2 = struct2;
		ref Struct21 reference3 = ref array[2];
		reference3 = new Struct21
		{
			int_0 = 901,
			string_0 = "Xa Phu",
			string_1 = "Thµnh §«|«ng",
			uint_0 = new uint[1, 2] { { 52832u, 102112u } }
		};
		struct21_0 = array;
		uint[,] array_3 = new uint[6, 2];
		Class10.smethod_4(array_3, 236688);
		uint_0 = array_3;
		uint[,] array_4 = new uint[8, 2];
		Class10.smethod_4(array_4, 236745);
		uint_1 = array_4;
		uint[,] array_5 = new uint[8, 2];
		Class10.smethod_4(array_5, 236818);
		uint_2 = array_5;
		uint[,] array_6 = new uint[5, 2];
		Class10.smethod_4(array_6, 236891);
		uint_3 = array_6;
		uint[,] array_7 = new uint[10, 2];
		Class10.smethod_4(array_7, 236940);
		uint_4 = array_7;
	}

	public static int smethod_0(CharacterAccountConfig characterAccountConfig_0, uint[,] uint_5 = null)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		long num4 = 0L;
		string string_ = "Xa phu|DÞch tr¹m|truyÒn tèng";
		string text = null;
		bool flag = false;
		while (true)
		{
			Thread.Sleep(300);
			if (Class11.bool_0)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
			if (int_ != 4)
			{
				continue;
			}
			uint num5 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
			uint num6 = BitConverter.ToUInt32(array, 0);
			uint num7 = num6 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
			if (int_ != 4)
			{
				continue;
			}
			uint num8 = BitConverter.ToUInt32(array, 0);
			uint num9 = num8 + num7;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_);
			int num10 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
			int num11 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
			int num12 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_);
			BitConverter.ToInt32(array, 0);
			int num13 = Class89.smethod_39(characterAccountConfig_0);
			if (num11 != 0 && num10 != 0 && num12 != 0 && num13 > 1)
			{
				num = 0;
				if (!flag)
				{
					Class95.smethod_8(characterAccountConfig_0);
					Thread.Sleep(100);
					flag = true;
				}
				if (uint_5 == null)
				{
					for (int i = 0; i < struct21_0.Length; i++)
					{
						if (struct21_0[i].int_0 == num12)
						{
							uint_5 = struct21_0[i].uint_0;
							string_ = struct21_0[i].string_0;
							num3 = struct21_0[i].int_0;
							text = struct21_0[i].string_1;
						}
					}
				}
				if (uint_5 == null)
				{
					return 0;
				}
				if (num3 != 0)
				{
					if (num12 != num3)
					{
						return 1;
					}
				}
				else
				{
					num3 = num12;
				}
				uint[] array2 = new uint[2]
				{
					Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
				int num14 = Class64.smethod_20(uint_5, array2);
				if (num14 < 0)
				{
					return 0;
				}
				uint[] uint_6 = new uint[2]
				{
					uint_5[num14, 0],
					uint_5[num14, 1]
				};
				long num15 = Class64.smethod_18(array2, uint_6);
				if (num15 > 300000L)
				{
					if (Class11.smethod_28(num4) > 6000L)
					{
						if (num4 > 0L)
						{
							return 2;
						}
						Class64.smethod_29(characterAccountConfig_0, bool_0: false);
						Class13.smethod_1(characterAccountConfig_0, uint_6);
						num4 = Class11.smethod_27();
					}
					continue;
				}
				Class13.smethod_2(characterAccountConfig_0, bool_0: false);
				if (num15 <= 22500L)
				{
					if (num15 > 7500L)
					{
						Class75.smethod_61(characterAccountConfig_0, uint_6);
						Thread.Sleep(450);
					}
					int num16 = Class3.smethod_13(characterAccountConfig_0, string_, 3);
					if (num16 > 0)
					{
						bool flag2 = false;
						while (true)
						{
							int int_2 = 0;
							byte[] bytes = BitConverter.GetBytes(num16);
							Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_72.uint_0, bytes, 4, ref int_2);
							Thread.Sleep(300);
							for (int j = 0; j < 10; j++)
							{
								Thread.Sleep(150);
								if (0 <= Class95.smethod_0(characterAccountConfig_0) && Class95.smethod_1(characterAccountConfig_0) > 0)
								{
									if (text != null)
									{
										Class95.smethod_6(characterAccountConfig_0, text);
									}
									else
									{
										Class95.smethod_5(characterAccountConfig_0, 0);
									}
									return 1;
								}
							}
							if (flag2)
							{
								break;
							}
							flag2 = true;
						}
						return -2;
					}
					return -1;
				}
				if (num2 >= 10)
				{
					return 3;
				}
				num2++;
				Class75.smethod_61(characterAccountConfig_0, uint_6);
			}
			else
			{
				num++;
				if (num >= 6)
				{
					return 0;
				}
			}
		}
		return 0;
	}

	private static uint[] smethod_1(int int_0, uint[] uint_5)
	{
		uint[] result = null;
		uint[,] array = null;
		for (int i = 0; i < Class45.gstruct27_0.Length; i++)
		{
			if (int_0 != Class45.gstruct27_0[i].int_0)
			{
				continue;
			}
			GStruct24[] gstruct24_ = Class45.gstruct27_0[i].gstruct24_0;
			for (int j = 0; j < gstruct24_.Length; j++)
			{
				if (gstruct24_[j].string_0 == "NgoaiThanh")
				{
					array = gstruct24_[j].uint_0;
					break;
				}
			}
			break;
		}
		if (array != null)
		{
			int num = Class64.smethod_20(array, uint_5);
			result = new uint[2]
			{
				array[num, 0],
				array[num, 1]
			};
		}
		return result;
	}

	public static int smethod_2(CharacterAccountConfig characterAccountConfig_0, string string_0, uint[] uint_5 = null, uint[,] uint_6 = null, int int_0 = 0, string string_1 = null)
	{
		int result = 0;
		for (int i = 0; i < 6; i++)
		{
			if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_5, 4) <= 0)
			{
				break;
			}
			Thread.Sleep(100);
		}
		Class75.smethod_2(characterAccountConfig_0, Class75.uint_5, 1, 4);
		try
		{
			result = smethod_3(characterAccountConfig_0, string_0, uint_5, uint_6, int_0, string_1);
		}
		catch
		{
		}
		Class75.smethod_2(characterAccountConfig_0, Class75.uint_5, 0, 4);
		return result;
	}

	private static int smethod_3(CharacterAccountConfig characterAccountConfig_0, string string_0, uint[] uint_5 = null, uint[,] uint_6 = null, int int_0 = 0, string string_1 = null)
	{
		string text = Class24.smethod_28(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_28.uint_0 + Class56.memorySignatureScanConfig_29.uint_0, characterAccountConfig_0.int_137, 60);
		int num = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
		bool flag = Class11.smethod_1(text, "iÓm b\u00b8o d") > 0;
		bool flag2 = num == 333;
		bool flag3 = num == 933;
		bool flag4 = num == 977;
		bool flag5 = num == 977 && 0 <= text.IndexOf("Cas");
		int int_1 = characterAccountConfig_0.int_136;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		long num5 = 0L;
		long long_ = 0L;
		long long_2 = 0L;
		uint[] array = null;
		bool flag6 = false;
		bool flag7 = false;
		bool flag8 = false;
		uint num6 = 0u;
		uint num7 = 0u;
		uint num8 = 0u;
		uint num9 = 0u;
		int num10 = 0;
		string string_2 = "D\u00adîc th\u00ad¬ng";
		string string_3 = "Qu©n Nhu";
		uint[,] array2 = new uint[4, 2];
		Class10.smethod_4(array2, 233731);
		uint[,] array3 = array2;
		if (string_1 != null && string_1 != string.Empty && uint_5 != null && uint_5[0] != 0 && uint_5[1] != 0 && string_1.IndexOf("POS") == 0)
		{
			string[] array4 = null;
			string[] array5 = string_1.Split('|');
			uint[] array6 = null;
			uint[] array7 = null;
			for (int i = 0; i < array5.Length; i++)
			{
				if (array5[i] == null || array5[i] == string.Empty)
				{
					continue;
				}
				string[] array8 = array5[i].Split(',', ';');
				if (array8.Length < 3)
				{
					continue;
				}
				string text2 = array8[2];
				uint num11 = Class11.smethod_12(array8[0]);
				uint num12 = Class11.smethod_12(array8[1]);
				if (text2 == null || text2 == string.Empty || num11 == 0 || num12 == 0)
				{
					text2 = array8[0];
					num11 = Class11.smethod_12(array8[1]);
					num12 = Class11.smethod_12(array8[2]);
					if (text2 == null || text2 == string.Empty || num11 == 0 || num12 == 0)
					{
						continue;
					}
				}
				if (array4 == null)
				{
					array4 = new string[1];
					array6 = new uint[1];
					array7 = new uint[1];
				}
				else
				{
					Array.Resize(ref array4, array4.Length + 1);
					Array.Resize(ref array6, array6.Length + 1);
					Array.Resize(ref array7, array7.Length + 1);
				}
				array4[array4.Length - 1] = text2;
				array6[array6.Length - 1] = num11;
				array7[array7.Length - 1] = num12;
			}
			if (array4 != null && array4.Length != 0)
			{
				uint[,] array9 = new uint[array4.Length, 2];
				for (int j = 0; j < array9.GetLength(0); j++)
				{
					if (j < array6.Length && j < array7.Length)
					{
						array9[j, 0] = array6[j];
						array9[j, 1] = array7[j];
					}
				}
				int num13 = Class64.smethod_20(array9, uint_5);
				if (0 <= num13 && array4[num13] != null)
				{
					string_0 = string_0 + "|" + array4[num13].Replace("_", "|");
				}
			}
		}
		while (true)
		{
			Thread.Sleep(300);
			int num14 = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
			if (Class11.bool_0 || num14 < 0 || Class24.smethod_52(Form1.characterAccountConfig_1[num14].process_0) || !Form1.characterAccountConfig_1[num14].bool_25)
			{
				break;
			}
			characterAccountConfig_0 = Form1.characterAccountConfig_1[num14];
			num6 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			num7 = Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
			num8 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			num9 = num8 + num7;
			int num15 = (int)Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
			int num20;
			uint[] array10;
			if (num15 <= 0)
			{
				int num16 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
				int num17 = (int)Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
				int num18 = (int)Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
				array10 = new uint[2]
				{
					Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
				if (array10[0] == 0 || array10[1] == 0)
				{
					continue;
				}
				int num19 = Class89.smethod_39(characterAccountConfig_0);
				if (num18 != 0 && num17 != 0 && num17 != 10 && num17 != 21 && num16 != 0 && num19 > 1)
				{
					if (num == num16)
					{
						int[] array11 = Class64.smethod_9(string_0);
						if (array11 == null)
						{
							num20 = Class3.smethod_13(characterAccountConfig_0, "Xa phu", 3, !flag);
							if (num20 <= 0)
							{
								if (!flag2)
								{
									if (flag4)
									{
										num20 = Class3.smethod_13(characterAccountConfig_0, string_3, 3);
									}
								}
								else
								{
									num20 = Class3.smethod_13(characterAccountConfig_0, string_2, 3);
								}
								if (num20 <= 0)
								{
									if (!flag6 && uint_6 != null && (int_0 == 0 || int_0 == num16))
									{
										int length = uint_6.GetLength(0);
										uint[] array12 = new uint[2]
										{
											uint_6[length - 1, 0],
											uint_6[length - 1, 1]
										};
										num5 = Class64.smethod_18(array10, array12);
										num15 = (int)Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
										if (num5 > 60000L && num15 <= 0)
										{
											Class64.smethod_22(characterAccountConfig_0, uint_6, null, array12, num16, bool_0: true);
											continue;
										}
										flag6 = true;
									}
									if (uint_5 == null)
									{
										uint_5 = new uint[2]
										{
											Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
											Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
										};
									}
									array = Class45.smethod_11(uint_5, num16, "Xa phu");
									if (array == null)
									{
										if (flag2)
										{
											array = Class45.smethod_11(uint_5, num16, "HIEUTHUOC");
										}
										else if (!flag5)
										{
											if (flag3)
											{
												array = new uint[2] { 53040u, 117298u };
											}
											else if (flag4)
											{
												int int_2 = 0;
												byte[] byte_ = new byte[4];
												Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_28.uint_0 + Class56.memorySignatureScanConfig_29.uint_0, byte_, 4, ref int_2);
												if (Class1.smethod_3(byte_) == "Cæ L")
												{
													int num21 = Class64.smethod_20(array3, array10);
													array = new uint[2]
													{
														array3[num21, 0],
														array3[num21, 1]
													};
												}
											}
										}
										else
										{
											array = new uint[2] { 49472u, 105888u };
										}
										if (array == null)
										{
											num2 = -2;
											break;
										}
									}
									long num22 = Class64.smethod_18(array10, array);
									if (num22 > 90000L)
									{
										Class64.smethod_29(characterAccountConfig_0, bool_0: false);
										flag7 = false;
										uint[,] array13 = Class44.smethod_1(num16, array10, array, "XAPHU", bool_2: true);
										if (array13 != null)
										{
											flag7 = true;
											int num23 = 0;
											while (num23 < 3)
											{
												array10 = new uint[2]
												{
													Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
													Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
												};
												if (Class64.smethod_22(characterAccountConfig_0, array13, array10, array, num16, bool_0: true) > 0)
												{
													goto IL_08e1;
												}
												Thread.Sleep(300);
												num15 = (int)Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
												if (num15 <= 0)
												{
													Thread.Sleep(300);
													num23++;
													continue;
												}
												goto IL_0c34;
											}
										}
										if (Class11.smethod_28(long_) > 6000L)
										{
											int num24 = Class13.smethod_1(characterAccountConfig_0, array);
											long_ = Class11.smethod_27();
											if (num24 <= 0)
											{
												Class64.smethod_12(characterAccountConfig_0);
											}
										}
										continue;
									}
									if (num22 > 22500L)
									{
										Class75.smethod_61(characterAccountConfig_0, array);
										Thread.Sleep(500);
									}
								}
							}
							goto IL_08e1;
						}
						int num25 = Class64.int_0[array11[0], array11[1]];
						num2 = ((num16 == num25) ? 1 : smethod_5(characterAccountConfig_0, num25));
						break;
					}
					num2 = 1;
					break;
				}
				num2 = -2;
				break;
			}
			num2 = 2;
			break;
			IL_0c34:
			num2 = 2;
			break;
			IL_0bb6:
			num4++;
			if (num4 <= 3)
			{
				Class64.smethod_12(characterAccountConfig_0);
				continue;
			}
			num2 = -3;
			break;
			IL_08e1:
			array10 = new uint[2]
			{
				Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
				Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
			};
			if (num20 <= 0)
			{
				num20 = Class3.smethod_13(characterAccountConfig_0, "Xa phu", 3, !flag);
				if (num20 <= 0 && flag2)
				{
					num20 = Class3.smethod_13(characterAccountConfig_0, string_2, 3);
				}
				if (num20 <= 0)
				{
					return -3;
				}
			}
			if (array == null)
			{
				array = Class3.smethod_19(characterAccountConfig_0, num20);
				if (array == null)
				{
					return -3;
				}
			}
			num5 = Class64.smethod_18(array10, array);
			if (num5 <= 160000L)
			{
				if (num5 <= 0L)
				{
					Class64.smethod_12(characterAccountConfig_0);
					continue;
				}
				int num26 = 0;
				while (num26 < 10)
				{
					array10 = new uint[2]
					{
						Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					num5 = Class64.smethod_18(array10, array);
					if (num5 <= 11250L)
					{
						break;
					}
					num26++;
					Class75.smethod_61(characterAccountConfig_0, array);
					Thread.Sleep(300);
				}
				num2 = 0;
				Class95.smethod_8(characterAccountConfig_0);
				Thread.Sleep(100);
				if (flag8)
				{
					Class64.smethod_12(characterAccountConfig_0);
					Class38.smethod_10(characterAccountConfig_0, (uint)num20);
				}
				else
				{
					Class38.smethod_10(characterAccountConfig_0, (uint)num20);
				}
				Thread.Sleep(300);
				int num27 = 0;
				while (Class95.smethod_0(characterAccountConfig_0) < 0)
				{
					if (Form1.int_91 > 0 && Class24.smethod_30(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig_0.int_137) != 0)
					{
						string text3 = Class47.smethod_4(characterAccountConfig_0);
						if (text3 != null && text3 != string.Empty)
						{
							int num28 = Class11.smethod_10(text3);
							if (num28 > 0)
							{
								Class47.smethod_5(characterAccountConfig_0, num28.ToString(), bool_0: true);
								Thread.Sleep(300);
							}
						}
					}
					num27++;
					Thread.Sleep(100);
					if (num27 <= 10)
					{
						continue;
					}
					goto IL_0bb6;
				}
				if (!flag2 && !flag3)
				{
					if (flag4)
					{
						string_0 = "Rêi khái|X\u00b8c nh";
					}
				}
				else
				{
					string_0 = "Rêi khái";
				}
				num2 = Convert.ToByte(Class95.smethod_6(characterAccountConfig_0, string_0) > 0);
				if (num2 > 0)
				{
					break;
				}
				Class95.smethod_8(characterAccountConfig_0);
				if (num10 != 0)
				{
					break;
				}
				if (flag)
				{
					string_0 = "hµnh thÞ|hµnh ph|Thµnh §«";
				}
				else if (flag5)
				{
					string_0 = "hµnh thÞ|Thµnh §«";
				}
				num10++;
			}
			else if (flag7 && num3 < 3)
			{
				num3++;
			}
			else if (Class11.smethod_28(long_2) > 3500L)
			{
				Class13.smethod_1(characterAccountConfig_0, array);
				long_2 = Class11.smethod_27();
			}
		}
		if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_20, 4) > 0)
		{
			num6 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			num7 = Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
			num8 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			num9 = num8 + num7;
			int num29 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
			int num30 = (int)Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
			int num31 = (int)Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
			int num32 = Class89.smethod_39(characterAccountConfig_0);
			int num33 = (int)Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_44.uint_0, characterAccountConfig_0.int_137);
			if (num29 > 0 && num30 > 0 && num31 > 0 && num32 > 1 && num33 <= 0)
			{
				Class75.smethod_57(characterAccountConfig_0, "Switch([[horse]])");
			}
		}
		return num2;
	}

	public static int smethod_4(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		string text = null;
		if (224 <= int_0 && int_0 <= 227)
		{
			text = "Sa M¹c Mª Cung";
		}
		else
		{
			switch (int_0)
			{
			default:
			{
				int num = Class29.smethod_3(int_0);
				if (0 <= num)
				{
					if (Class37.mapNavigationEntry_0[num].string_3 != null)
					{
						text = Class37.mapNavigationEntry_0[num].string_3;
					}
				}
				else
				{
					text = Class39.smethod_1(int_0) + "|" + Class46.characterSyncSnapshot_0.string_1;
				}
				break;
			}
			case 322:
				text = "Tr\u00adêng B¹ch s¬n B";
				break;
			case 321:
				text = "Tr\u00adêng B¹ch s¬n N";
				break;
			case 181:
				text = "La Tiªu s¬n";
				break;
			}
		}
		int num2 = 0;
		if (text != null)
		{
			Class13.smethod_2(characterAccountConfig_0, bool_0: false);
			num2 = smethod_2(characterAccountConfig_0, "h÷ng n¬i ®· ®i q|" + text);
			Class95.smethod_8(characterAccountConfig_0);
			if (num2 > 0)
			{
				Class64.smethod_11(characterAccountConfig_0);
			}
		}
		return num2;
	}

	public static int smethod_5(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		int result = 0;
		for (int i = 0; i < 6; i++)
		{
			if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_5, 4) <= 0)
			{
				break;
			}
			Thread.Sleep(100);
		}
		Class75.smethod_2(characterAccountConfig_0, Class75.uint_5, 1, 4);
		try
		{
			result = smethod_6(characterAccountConfig_0, int_0);
		}
		catch
		{
		}
		Class75.smethod_2(characterAccountConfig_0, Class75.uint_5, 0, 4);
		return result;
	}

	private static int smethod_6(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		int[] array = Class64.smethod_9(int_0);
		if (array == null)
		{
			return -1;
		}
		string[,] array2 = new string[3, 5]
		{
			{ "2", "DÞch tr¹m Xa phu", "ng thµnh", "83745", "114757" },
			{ "949", "Phu x", null, "51264", "101984" },
			{ "897", "Xa phu", "ng thµnh", "49472", "105888" }
		};
		int result = 0;
		int num = 0;
		int num2 = 0;
		int[] array3 = null;
		long long_ = 0L;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		uint num3 = 0u;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		string text = "D\u00adîc th\u00ad¬ng";
		string text2 = "Qu©n Nhu";
		uint[,] array4 = new uint[3, 2];
		Class10.smethod_4(array4, 235128);
		uint[,] array5 = array4;
		uint[,] array6 = new uint[4, 2];
		Class10.smethod_4(array6, 235161);
		uint[,] array7 = array6;
		while (true)
		{
			Thread.Sleep(300);
			int num7 = Class87.smethod_3(Form1.characterAccountConfig_1, characterAccountConfig_0.int_136);
			if (Class11.bool_0 || num7 < 0 || Class24.smethod_52(Form1.characterAccountConfig_1[num7].process_0) || !Form1.characterAccountConfig_1[num7].bool_25 || Class46.bool_0)
			{
				break;
			}
			characterAccountConfig_0 = Form1.characterAccountConfig_1[num7];
			int num8 = Class89.smethod_12(characterAccountConfig_0);
			if (num8 == 1)
			{
				continue;
			}
			uint num9 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num10 = Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
			uint num11 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			num3 = num11 + num10;
			int num12 = (int)Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
			int num13 = (int)Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
			int num14 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
			int num15 = Class89.smethod_39(characterAccountConfig_0);
			int num16;
			string string_;
			uint[] array9;
			int num18;
			string text3;
			uint[] array8;
			if (num12 > 0 && num13 > 0 && num14 > 0 && num15 > 1)
			{
				num = 0;
				flag3 = false;
				if (num13 != 10 && num13 != 21)
				{
					array8 = new uint[2]
					{
						Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					if (array8[0] == 0 || array8[1] == 0)
					{
						continue;
					}
					if (int_0 != num14)
					{
						if (num4 == num14)
						{
							if (num5 == 3)
							{
								Class64.smethod_12(characterAccountConfig_0);
							}
							if (num5 > 5 || num6 > 3)
							{
								result = -1;
								break;
							}
						}
						else
						{
							num5 = 0;
							num6 = 0;
							num4 = num14;
						}
						array9 = null;
						num16 = 0;
						string_ = "Xa phu";
						text3 = "hµnh thÞ";
						if (Class59.smethod_1(num14) == null)
						{
							if (num14 != 933)
							{
								if (num14 != 333)
								{
									if (num14 == 977)
									{
										int int_1 = 0;
										byte[] byte_ = new byte[4];
										Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_28.uint_0 + Class56.memorySignatureScanConfig_29.uint_0, byte_, 4, ref int_1);
										string text4 = Class1.smethod_3(byte_);
										if (text4 == "Cæ L")
										{
											int num17 = Class64.smethod_20(array7, array8);
											array9 = new uint[2]
											{
												array7[num17, 0],
												array7[num17, 1]
											};
											string_ = text2;
											text3 = "Rêi khái|X\u00b8c nh";
											goto IL_077a;
										}
									}
									num18 = 0;
									while (num18 < array2.GetLength(0))
									{
										if (!(num14.ToString() == array2[num18, 0]))
										{
											num18++;
											continue;
										}
										goto IL_05c9;
									}
									array3 = Class64.smethod_9(num14);
									if (array3 == null)
									{
										array9 = Class45.smethod_11(array8, num14, string_);
										if (array9 == null)
										{
											string text5 = Class24.smethod_28(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_28.uint_0 + Class56.memorySignatureScanConfig_29.uint_0, characterAccountConfig_0.int_137, 48);
											if (!(text5 != string.Empty) || (0 > Class11.smethod_1(text5, "tr\u00adêng li") && 0 > Class11.smethod_1(text5, "tr\u00adêng §¹")))
											{
												result = -1;
												break;
											}
											array9 = new uint[2] { 46752u, 96704u };
											flag3 = true;
										}
										else
										{
											flag3 = true;
										}
									}
									else
									{
										array9 = Class45.smethod_11(array8, num14, string_);
										if (array9 == null)
										{
											result = -2;
											break;
										}
										num16 = ((array[0] != array3[0]) ? ((array3[1] > 0) ? Class64.int_0[array3[0], array3[1] - 1] : ((Class64.int_0[array[0], 0] != Class64.int_0[array3[0], 0]) ? Class64.int_0[array[0], 0] : Class64.int_0[array[0], 1])) : ((array3[1] > array[1]) ? Class64.int_0[array3[0], array3[1] - 1] : Class64.int_0[array3[0], array3[1] + 1]));
									}
								}
								else
								{
									int num19 = 0;
									if (Form1.string_6.IndexOf("vltrungnguyen") != 0)
									{
										num19 = Class64.smethod_20(array5, array8);
									}
									array9 = new uint[2]
									{
										array5[num19, 0],
										array5[num19, 1]
									};
									string_ = text;
									text3 = "Rêi khái";
								}
							}
							else
							{
								string_ = "Xa phu";
								text3 = "Rêi khái";
								array9 = new uint[2] { 53040u, 117298u };
							}
						}
						else
						{
							int num20 = (int)Class64.smethod_21(Class59.uint_4, array8);
							int num21 = (int)Class64.smethod_21(Class59.uint_5, array8);
							int length = Class59.uint_5.GetLength(0);
							array9 = new uint[2]
							{
								Class59.uint_5[length - 1, 0],
								Class59.uint_5[length - 1, 1]
							};
							if (num20 > 0 && num20 < num21)
							{
								length = Class59.uint_4.GetLength(0);
								array9 = new uint[2]
								{
									Class59.uint_4[length - 1, 0],
									Class59.uint_4[length - 1, 1]
								};
							}
							text3 = "hµnh thÞ|hµnh ph";
							if (!flag2 && (int_0 == 99 || int_0 == 121))
							{
								num16 = int_0;
								flag2 = true;
							}
							else
							{
								num16 = Class64.int_0[array[0], 0];
								if (num16 == 1 || num16 == 37)
								{
									num16 = 11;
								}
							}
						}
						goto IL_077a;
					}
					result = 1;
					break;
				}
				result = -1;
				break;
			}
			num++;
			if (num >= 3)
			{
				result = -1;
				break;
			}
			continue;
			IL_0908:
			uint num22 = Class38.smethod_41(characterAccountConfig_0);
			if (num22 < 500)
			{
				if (!flag && characterAccountConfig_0.string_15 != null && characterAccountConfig_0.string_15 != string.Empty)
				{
					uint num23 = Class11.smethod_12(characterAccountConfig_0.string_15);
					if (num23 != 0)
					{
						Class75.smethod_117(characterAccountConfig_0, num23);
						flag = true;
						Thread.Sleep(300);
					}
				}
				uint num24 = 500 - num22;
				uint num25 = Class38.smethod_41(characterAccountConfig_0, bool_0: true);
				if (num25 >= num24)
				{
					if (num24 > 100000)
					{
						num24 = 100000u;
					}
					Class75.smethod_37(characterAccountConfig_0, num24);
					Thread.Sleep(300);
				}
			}
			string text6 = null;
			int num26 = Class29.smethod_3(num16);
			if (0 <= num26 && Class37.mapNavigationEntry_0[num26].string_3 != null)
			{
				text6 = Class37.mapNavigationEntry_0[num26].string_3;
			}
			if (flag3 || text6 == null || text6 == string.Empty || text6 == "Kh«ng x\u00b8c ®Þnh")
			{
				int[] array10 = Class64.smethod_9(int_0);
				if (array10 == null)
				{
					text6 = " ";
				}
				else
				{
					num14 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
					int[] array11 = Class64.smethod_9(num14);
					text6 = ((array11 == null || array11[0] != array10[0] || array10[1] <= array11[1]) ? Class64.string_0[array10[0], 0] : Class64.string_0[array10[0], array10[1]]);
					text6 += "| b¾c";
				}
			}
			if (text3 != null && text3 != string.Empty)
			{
				text3 += "|";
			}
			text3 = text3 + text6 + "|KÕt thóc";
			int num28;
			while (true)
			{
				Class13.smethod_2(characterAccountConfig_0, bool_0: false);
				int i;
				for (i = 0; i < 10; i++)
				{
					if (array9 == null)
					{
						break;
					}
					Class75.smethod_61(characterAccountConfig_0, array9);
					Thread.Sleep(300);
					array8 = new uint[2]
					{
						Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					long num27 = Class64.smethod_18(array8, array9);
					if (num27 < 11250L)
					{
						break;
					}
				}
				if (num28 <= 0)
				{
					num28 = Class3.smethod_13(characterAccountConfig_0, string_, 3, array3 != null && array3[1] == 0);
					if (num28 <= 0)
					{
						break;
					}
					num2 = 0;
				}
				Class95.smethod_8(characterAccountConfig_0);
				Thread.Sleep(100);
				Class38.smethod_10(characterAccountConfig_0, (uint)num28);
				Thread.Sleep(150);
				i = 0;
				while (Class95.smethod_0(characterAccountConfig_0) < 0)
				{
					i++;
					Thread.Sleep(100);
					if (Form1.int_91 > 0 && Class24.smethod_30(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig_0.int_137) != 0)
					{
						string text7 = Class47.smethod_4(characterAccountConfig_0);
						if (text7 != null && text7 != string.Empty)
						{
							int num29 = Class11.smethod_10(text7);
							if (num29 > 0)
							{
								Class47.smethod_5(characterAccountConfig_0, num29.ToString(), bool_0: true);
								Thread.Sleep(300);
							}
						}
					}
					if (i < 10)
					{
						continue;
					}
					i++;
					if (i <= 8)
					{
						continue;
					}
					goto IL_0c6f;
				}
				goto IL_0cca;
				IL_0c6f:
				num2++;
				if (num2 <= 4)
				{
					if (num2 % 2 != 0)
					{
						continue;
					}
					goto IL_0d0f;
				}
				goto IL_0d9d;
			}
			num2++;
			if (num2 <= 4)
			{
				if (num2 % 3 == 0)
				{
					Class64.smethod_12(characterAccountConfig_0);
				}
				continue;
			}
			result = -4;
			break;
			IL_0d9d:
			result = -4;
			break;
			IL_0cca:
			Thread.Sleep(100);
			if (Class95.smethod_6(characterAccountConfig_0, text3) > 0)
			{
				Thread.Sleep(100);
				Class64.smethod_11(characterAccountConfig_0);
				num6++;
			}
			else
			{
				Class95.smethod_8(characterAccountConfig_0);
				num5++;
				num2 = 0;
			}
			continue;
			IL_077a:
			array3 = Class64.smethod_9(num14);
			num28 = Class3.smethod_13(characterAccountConfig_0, string_, 3, array3 != null && array3[1] == 0);
			if (num28 > 0)
			{
				array9 = Class3.smethod_19(characterAccountConfig_0, num28);
				long num30 = Class64.smethod_18(array8, array9);
				if (num30 > 0L && num30 < 90000L)
				{
					goto IL_0908;
				}
			}
			int num31 = (int)Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
			Class24.smethod_28(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_28.uint_0 + Class56.memorySignatureScanConfig_29.uint_0, characterAccountConfig_0.int_137, 20);
			uint[,] array12 = Class44.smethod_1(num14, array8, array9, "XAPHU", bool_2: true);
			if (array12 != null && num31 <= 0)
			{
				int num32 = 0;
				while (num32 < 3)
				{
					array8 = new uint[2]
					{
						Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					if (Class64.smethod_22(characterAccountConfig_0, array12, array8, array9, num14, bool_0: true) > 0)
					{
						goto IL_0908;
					}
					Thread.Sleep(300);
					if ((int)Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137) <= 0)
					{
						Thread.Sleep(300);
						num32++;
						continue;
					}
					goto IL_0d94;
				}
			}
			if (Class11.smethod_28(long_) > 6000L)
			{
				int num33 = Class13.smethod_1(characterAccountConfig_0, array9);
				long_ = Class11.smethod_27();
				if (num33 <= 0)
				{
					Class64.smethod_12(characterAccountConfig_0);
				}
			}
			continue;
			IL_0d0f:
			Class64.smethod_12(characterAccountConfig_0);
			continue;
			IL_0d94:
			result = 2;
			break;
			IL_05c9:
			string_ = array2[num18, 1];
			text3 = array2[num18, 2];
			array9 = new uint[2]
			{
				Class11.smethod_12(array2[num18, 3]),
				Class11.smethod_12(array2[num18, 4])
			};
			num16 = Class64.int_0[array[0], 0];
			goto IL_077a;
		}
		return result;
	}

	public static int smethod_7(CharacterAccountConfig characterAccountConfig_0)
	{
		int[] array = Class64.smethod_9(Class39.smethod_0(characterAccountConfig_0));
		if (array != null)
		{
			if (array[1] != 0)
			{
				uint[,] array2 = null;
				int num = Class39.smethod_0(characterAccountConfig_0);
				switch (num)
				{
				case 53:
					array2 = uint_0;
					break;
				case 20:
					array2 = uint_1;
					break;
				case 174:
					array2 = uint_4;
					break;
				case 153:
					array2 = uint_3;
					break;
				case 121:
					array2 = uint_2;
					break;
				}
				if (array2 != null)
				{
					int num2 = 0;
					while (num2 < 3 && Class64.smethod_22(characterAccountConfig_0, array2, null, null, num, bool_0: true) <= 0)
					{
						num2++;
						Thread.Sleep(300);
					}
				}
				return smethod_5(characterAccountConfig_0, Class64.int_0[array[0], 0]);
			}
			return 1;
		}
		return -1;
	}
}
