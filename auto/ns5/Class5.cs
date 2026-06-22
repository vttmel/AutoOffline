using System;
using System.Threading;
using ns1;
using ns100;
using ns11;
using ns13;
using ns23;
using ns26;
using ns28;
using ns3;
using ns33;
using ns35;
using ns36;
using ns39;
using ns41;
using ns42;
using ns43;
using ns44;
using ns50;
using ns53;
using ns61;
using ns63;
using ns68;
using ns71;
using ns77;
using ns79;
using ns81;
using ns83;
using ns84;
using ns85;
using ns88;
using ns91;

namespace ns5;

internal class Class5
{
	public struct Struct28
	{
		public string bossDisplayName;

		public string bossNamePattern;

		public int bossMapId;

		public int bossLevel;

		public uint[] bossCoordinates;

		public string bossDirection;

		public int[] bossMapList;

		public int bossHuntDistance;
	}

	public static int int_0 = Class66.smethod_4("BosSatthuTuHuyNhiemvu", 0, "1");

	public static int int_1 = Class66.smethod_4("BosSatthuKhongLuuRuong", 0, "0");

	public static int int_2 = Class66.smethod_4("TuGhepSTG", 0, "1");

	public static Struct28[] struct28_0 = new Struct28[20]
	{
		new Struct28
		{
			bossNamePattern = "Gi¶|Cæ Giíi",
			bossDisplayName = "1. Giả Giới Nhân",
			bossMapId = 93,
			bossLevel = 80,
			bossCoordinates = new uint[2] { 52715u, 104877u },
			bossDirection = "t©y",
			bossMapList = new int[3] { 80, 92, 93 },
			bossHuntDistance = 160000
		},
		new Struct28
		{
			bossNamePattern = "Chu",
			bossDisplayName = "2. Chu Sở Bá",
			bossMapId = 93,
			bossLevel = 80,
			bossCoordinates = new uint[2] { 55437u, 102868u },
			bossDirection = "t©y",
			bossMapList = new int[3] { 80, 92, 93 },
			bossHuntDistance = 90000
		},
		new Struct28
		{
			bossNamePattern = "Trang",
			bossDisplayName = "3. Trang Minh Trung",
			bossMapId = 93,
			bossLevel = 80,
			bossCoordinates = new uint[2] { 51491u, 100875u },
			bossDirection = "t©y",
			bossMapList = new int[2] { 92, 93 },
			bossHuntDistance = 160000
		},
		new Struct28
		{
			bossNamePattern = "TrÞnh",
			bossDisplayName = "4. Trịnh Cửu Nhật",
			bossMapId = 93,
			bossLevel = 80,
			bossCoordinates = new uint[2] { 52796u, 97834u },
			bossDirection = "t©y",
			bossMapList = new int[3] { 80, 92, 93 },
			bossHuntDistance = 160000
		},
		new Struct28
		{
			bossNamePattern = "NhËm",
			bossDisplayName = "1. Nhậm Thương Khung",
			bossMapId = 340,
			bossLevel = 11,
			bossCoordinates = new uint[2] { 61824u, 88288u },
			bossDirection = "b¾c",
			bossMapList = new int[2] { 121, 340 },
			bossHuntDistance = 160000
		},
		new Struct28
		{
			bossNamePattern = "§o¹n",
			bossDisplayName = "2. Đoạn Lăng Nguyệt",
			bossMapId = 340,
			bossLevel = 11,
			bossCoordinates = new uint[2] { 55163u, 88546u },
			bossDirection = "b¾c",
			bossMapList = new int[2] { 121, 340 },
			bossHuntDistance = 160000
		},
		new Struct28
		{
			bossNamePattern = "T¶ ",
			bossDisplayName = "3. Tả Dật Minh",
			bossMapId = 340,
			bossLevel = 11,
			bossCoordinates = new uint[2] { 40831u, 87887u },
			bossDirection = "b¾c",
			bossMapList = new int[2] { 121, 340 },
			bossHuntDistance = 160000
		},
		new Struct28
		{
			bossNamePattern = "Trö",
			bossDisplayName = "4. Trử Thiên Mẫn",
			bossMapId = 340,
			bossLevel = 11,
			bossCoordinates = new uint[2] { 39012u, 87703u },
			bossDirection = "b¾c",
			bossMapList = new int[2] { 121, 340 },
			bossHuntDistance = 160000
		},
		new Struct28
		{
			bossNamePattern = "VÖ ",
			bossDisplayName = "1. Vệ Biên Thành",
			bossMapId = 75,
			bossLevel = 1,
			bossCoordinates = new uint[2] { 56098u, 99813u },
			bossDirection = "nam",
			bossMapList = new int[4] { 53, 74, 76, 75 },
			bossHuntDistance = 90000
		},
		new Struct28
		{
			bossNamePattern = "Gia",
			bossDisplayName = "2. Gia Các Kinh Hồng",
			bossMapId = 75,
			bossLevel = 1,
			bossCoordinates = new uint[2] { 52614u, 101114u },
			bossDirection = "nam",
			bossMapList = new int[4] { 53, 74, 76, 75 },
			bossHuntDistance = 160000
		},
		new Struct28
		{
			bossNamePattern = "T\u00a8ng",
			bossDisplayName = "3. Tăng Chỉ Oán",
			bossMapId = 75,
			bossLevel = 1,
			bossCoordinates = new uint[2] { 54681u, 101997u },
			bossDirection = "nam",
			bossMapList = new int[4] { 53, 74, 76, 75 },
			bossHuntDistance = 90000
		},
		new Struct28
		{
			bossNamePattern = "Cè ",
			bossDisplayName = "4. Cố Thủ Đằng",
			bossMapId = 75,
			bossLevel = 1,
			bossCoordinates = new uint[2] { 58573u, 102167u },
			bossDirection = "nam",
			bossMapList = new int[4] { 53, 74, 76, 75 },
			bossHuntDistance = 90000
		},
		new Struct28
		{
			bossNamePattern = "Hµ ",
			bossDisplayName = "1. Hà Sinh Vong",
			bossMapId = 225,
			bossLevel = 176,
			bossCoordinates = new uint[2] { 45570u, 99521u },
			bossDirection = "nam",
			bossMapList = new int[5] { 121, 131, 136, 224, 225 },
			bossHuntDistance = 90000
		},
		new Struct28
		{
			bossNamePattern = "Vò ",
			bossDisplayName = "2. Vũ Nhất Thế",
			bossMapId = 225,
			bossLevel = 176,
			bossCoordinates = new uint[2] { 40353u, 103922u },
			bossDirection = "nam",
			bossMapList = new int[5] { 121, 131, 136, 224, 225 },
			bossHuntDistance = 90000
		},
		new Struct28
		{
			bossNamePattern = "D\u00ad¬ng",
			bossDisplayName = "3. Dương Phong Dật",
			bossMapId = 225,
			bossLevel = 176,
			bossCoordinates = new uint[2] { 46454u, 107993u },
			bossDirection = "nam",
			bossMapList = new int[5] { 121, 131, 136, 224, 225 },
			bossHuntDistance = 90000
		},
		new Struct28
		{
			bossNamePattern = "Cam",
			bossDisplayName = "4. Cam Chính Cô",
			bossMapId = 225,
			bossLevel = 176,
			bossCoordinates = new uint[2] { 50786u, 106322u },
			bossDirection = "nam",
			bossMapList = new int[5] { 121, 131, 136, 224, 225 },
			bossHuntDistance = 160000
		},
		new Struct28
		{
			bossNamePattern = "V¹n",
			bossDisplayName = "1. Vạn Hồ Tinh",
			bossMapId = 321,
			bossLevel = 1,
			bossCoordinates = new uint[2] { 35616u, 82208u },
			bossDirection = "nam",
			bossMapList = new int[4] { 37, 319, 320, 321 },
			bossHuntDistance = 640000
		},
		new Struct28
		{
			bossNamePattern = "Bµo",
			bossDisplayName = "2. Bào Triệt Sơn",
			bossMapId = 321,
			bossLevel = 1,
			bossCoordinates = new uint[2] { 41206u, 83718u },
			bossDirection = "nam",
			bossMapList = new int[4] { 37, 319, 320, 321 },
			bossHuntDistance = 640000
		},
		new Struct28
		{
			bossNamePattern = "Liªn",
			bossDisplayName = "3. Liên Hình Thái",
			bossMapId = 321,
			bossLevel = 1,
			bossCoordinates = new uint[2] { 47565u, 87988u },
			bossDirection = "nam",
			bossMapList = new int[4] { 37, 319, 320, 321 },
			bossHuntDistance = 640000
		},
		new Struct28
		{
			bossNamePattern = "Phan",
			bossDisplayName = "4. Phan Ngạt Nhạn",
			bossMapId = 321,
			bossLevel = 1,
			bossCoordinates = new uint[2] { 40093u, 95276u },
			bossDirection = "nam",
			bossMapList = new int[4] { 37, 319, 320, 321 },
			bossHuntDistance = 640000
		}
	};

	public static int int_3 = 0;

	public static void smethod_0(int int_4)
	{
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		long long_4 = 0L;
		long long_5 = 0L;
		long long_6 = 0L;
		long num = 0L;
		long num2 = 0L;
		int int_5 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = -1;
		int num9 = -1;
		byte[] array = new byte[4];
		byte[] byte_ = new byte[4];
		byte[] array2 = new byte[2];
		byte[] array3 = new byte[1];
		bool flag = false;
		bool bool_ = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		bool flag7 = false;
		bool flag8 = false;
		bool flag9 = false;
		bool flag10 = false;
		bool flag11 = false;
		int num10 = -1;
		int num11 = -1;
		GStruct61 gStruct = default(GStruct61);
		while (true)
		{
			Thread.Sleep(200);
			int num12 = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (Class11.bool_0 || num12 < 0)
			{
				break;
			}
			if (flag9)
			{
				Form1.characterAccountConfig_1[num12].int_133[1] = num3;
				flag9 = false;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num12];
			if (!characterAccountConfig.bool_25 || characterAccountConfig.int_133[0] <= 0)
			{
				break;
			}
			Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_1 * 4, array2, 2, ref int_5);
			uint num13 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.int_137);
			uint num14 = Class24.smethod_30(num13 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig.int_137);
			uint num15 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig.int_137);
			uint num16 = num15 + num14 * Class56.memorySignatureScanConfig_15.uint_0;
			int num17 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
			int num18 = (int)Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
			int num19 = (int)Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
			int num20 = (int)Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig.int_137);
			int num21 = Class89.smethod_39(characterAccountConfig);
			if (num20 <= 0 || num17 <= 0 || num19 == 10 || num19 == 21 || num21 <= 1)
			{
				continue;
			}
			int num22 = Class89.smethod_12(characterAccountConfig);
			if ((characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0) || (num22 != 1 && num22 != 2))
			{
				uint[] array4 = new uint[2]
				{
					Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
					Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
				};
				if (array4[0] == 0 || array4[1] == 0)
				{
					continue;
				}
				int num23 = 0;
				while (true)
				{
					if (num8 != num17)
					{
						int num24 = Class89.smethod_39(characterAccountConfig);
						Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_5);
						num5 = 0;
						num20 = (int)Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig.int_137);
						num17 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
						num18 = (int)Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
						if (num18 <= 0 && num23 <= 8 && (num24 == 0 || num24 == 1 || num20 <= 0 || num17 <= 0))
						{
							num23++;
							Thread.Sleep(100);
							continue;
						}
						num8 = num17;
						break;
					}
					int num25 = characterAccountConfig.int_133[3];
					int bossMapId = struct28_0[num25].bossMapId;
					uint[] bossCoordinates;
					int num34;
					int num36;
					uint[] uint_;
					long num39;
					int num37;
					if (num10 == num25 && num3 > 0)
					{
						if (int_2 > 0 && num4 <= 0)
						{
							smethod_3(int_4);
							num4 = 1;
							break;
						}
						if (num3 != 2)
						{
							Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_2 * 4, array3, 1, ref int_5);
							if (num18 <= 0)
							{
								int num26 = Class85.smethod_4(characterAccountConfig);
								if (characterAccountConfig.int_134 <= 0 && (!flag8 || num11 < 0 || num11 != num26))
								{
									if (Class42.smethod_0(characterAccountConfig) == 0)
									{
										Thread.Sleep(300);
										break;
									}
									int num27 = Class36.smethod_3(characterAccountConfig, Form1.int_105 <= 0);
									if (num27 != 0 && (num27 >= 0 || flag11))
									{
										flag8 = true;
										flag11 = false;
										num11 = Class85.smethod_4(characterAccountConfig);
									}
									else
									{
										Thread.Sleep(300);
										flag11 = num27 < 0;
									}
									break;
								}
								if (!flag && characterAccountConfig.int_65 > 0)
								{
									Class64.smethod_3(characterAccountConfig, ref bool_);
									flag = true;
								}
							}
							if (Class11.smethod_28(long_) > 30000L)
							{
								Class89.smethod_32(characterAccountConfig, 0u);
								long_ = Class11.smethod_27();
							}
							string[] array5 = Class89.smethod_26(characterAccountConfig, 8u);
							bool flag12 = false;
							if (array5 != null)
							{
								for (int i = 0; i < array5.Length; i++)
								{
									string string_ = array5[i].ToLower();
									if (flag12 = Class11.smethod_1(string_, ", hoµn thµnh nh".ToLower()) > 0 || Class11.smethod_1(string_, "thñ ®· bÞ tiªu di".ToLower()) > 0 || Class11.smethod_1(string_, "c tªn s\u00b8t thñ".ToLower()) > 0 || Class11.smethod_1(string_, "s\u00b8t thñ lÖnh cÊp 90".ToLower()) > 0 || Class11.smethod_1(string_, "s\u00b8t thñ, hoµn thµnh".ToLower()) > 0)
									{
										break;
									}
								}
							}
							if (!flag12 && !flag7)
							{
								if (characterAccountConfig.int_133[4] > 0)
								{
									break;
								}
								if (!flag10 && Form1.characterAccountConfig_1 != null)
								{
									gStruct = Class88.smethod_5(characterAccountConfig);
									if (flag10 = gStruct.int_0 <= 1 || gStruct.gstruct60_0 == null || gStruct.gstruct60_0.Length <= 1)
									{
										break;
									}
									try
									{
										string text = null;
										if (!(characterAccountConfig.string_22 == gStruct.string_0))
										{
											int num28 = 0;
											while (num28 < Form1.characterAccountConfig_1.Length)
											{
												int num29 = 0;
												while (true)
												{
													if (num29 < gStruct.gstruct60_0.Length)
													{
														if (!Form1.characterAccountConfig_1[num28].bool_25 || !(Form1.characterAccountConfig_1[num28].string_22 == gStruct.gstruct60_0[num29].string_0) || Form1.characterAccountConfig_1[num28].int_133[0] <= 0 || Form1.characterAccountConfig_1[num28].int_133[1] > 0)
														{
															num29++;
															continue;
														}
														if (Class11.smethod_28(long_3) > 8000L)
														{
															Class75.smethod_52(characterAccountConfig, "§ang chê " + gStruct.gstruct60_0[num29].string_0 + " nhËn xong nhiÖm vô.");
															long_3 = Class11.smethod_27();
														}
														Thread.Sleep(300);
														goto end_IL_0382;
													}
													num28++;
													break;
												}
											}
											goto IL_0827;
										}
										for (int j = 0; j < Form1.characterAccountConfig_1.Length; j++)
										{
											for (int k = 0; k < gStruct.gstruct60_0.Length; k++)
											{
												if (Form1.characterAccountConfig_1[j].bool_25 && Form1.characterAccountConfig_1[j].string_22 == gStruct.gstruct60_0[k].string_0 && Form1.characterAccountConfig_1[j].int_136 != characterAccountConfig.int_136 && Form1.characterAccountConfig_1[j].int_133[0] > 0 && (Form1.characterAccountConfig_1[j].int_133[3] != num25 || Form1.characterAccountConfig_1[j].int_133[1] <= 0))
												{
													Form1.characterAccountConfig_1[j].int_133[3] = num25;
													text = gStruct.gstruct60_0[k].string_0;
												}
											}
										}
										if (text == null)
										{
											goto IL_0827;
										}
										if (Class11.smethod_28(long_3) > 8000L)
										{
											Class75.smethod_52(characterAccountConfig, "§ang chê " + text + " nhËn xong nhiÖm vô.");
											long_3 = Class11.smethod_27();
										}
										Thread.Sleep(300);
										goto end_IL_05f9;
										IL_0827:
										flag10 = true;
										Class75.smethod_52(characterAccountConfig, "TÊt c¶ ®· nhËn nhiÖm vô.");
										end_IL_05f9:;
									}
									catch
									{
									}
									break;
								}
								int bossHuntDistance = struct28_0[num25].bossHuntDistance;
								int[] bossMapList = struct28_0[num25].bossMapList;
								bossCoordinates = struct28_0[num25].bossCoordinates;
								if (num17 == bossMapId)
								{
									flag2 = false;
									flag3 = false;
									flag4 = false;
									flag = false;
									flag8 = false;
									num6 = 0;
									num7 = 0;
									long num30 = Class64.smethod_18(array4, bossCoordinates);
									int num31 = 90000;
									if (bossHuntDistance > 0)
									{
										num31 = bossHuntDistance;
									}
									if (!flag5 && num30 <= num31)
									{
										if (!flag6)
										{
											flag6 = true;
											num2 = 0L;
										}
										if ((int)Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137) <= 0)
										{
											break;
										}
										if (characterAccountConfig.int_101[0] > 0 && characterAccountConfig.int_101[1] > 0 && characterAccountConfig.string_23 == "NGAMY")
										{
											long num32 = Class11.smethod_28(long_5);
											if (num32 < 300L)
											{
												break;
											}
											if (num32 > characterAccountConfig.int_101[4] && Class72.smethod_3(characterAccountConfig))
											{
												Thread.Sleep(80);
												long_5 = Class11.smethod_27();
												break;
											}
										}
										for (int l = 0; l < Class56.int_0; l++)
										{
											Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array, 1, ref int_5);
											if (array[0] == 0)
											{
												break;
											}
											Thread.Sleep(1);
										}
										int[,] array6 = Class72.smethod_5(characterAccountConfig, 0u, 1000, array4);
										if (flag6 && int_0 > 0)
										{
											gStruct = Class88.smethod_5(characterAccountConfig);
											if (gStruct.int_0 < 2 || gStruct.gstruct60_0 == null || gStruct.gstruct60_0.Length < 2 || characterAccountConfig.string_22 == gStruct.string_0)
											{
												flag7 = false;
												if ((array6 == null || array6[0, 1] <= 0) && num2 > 0L && Class11.smethod_28(num2) <= 9999999L)
												{
													if (Class11.smethod_28(num2) > 60000L)
													{
														flag7 = true;
														num2 = 0L;
														break;
													}
												}
												else
												{
													num2 = Class11.smethod_27();
												}
											}
										}
										if (!characterAccountConfig.bool_22)
										{
											if (Class89.smethod_12(characterAccountConfig) != 1 && !Class46.smethod_7(characterAccountConfig, ref num9))
											{
												Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_43 * 4, array, 4, ref int_5);
												int num33 = BitConverter.ToInt32(array, 0);
												num34 = num33;
												if (characterAccountConfig.int_95 > 0 && characterAccountConfig.int_96 > 0)
												{
													num34 = characterAccountConfig.int_96;
												}
												if (num34 <= 0)
												{
													num34 = 400;
												}
												Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_44 * 4, array, 1, ref int_5);
												int num35 = array[0];
												if (num35 > 0 && num34 > num33 && num33 > 0)
												{
													num34 = num33;
												}
												array4 = new uint[2]
												{
													Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
													Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
												};
												if (array6 == null || array6[0, 0] < 0)
												{
													break;
												}
												num36 = array6[0, 0];
												num37 = array6[0, 1];
												if (num37 <= 0)
												{
													break;
												}
												uint num38 = num15 + (uint)(num37 * (int)Class56.memorySignatureScanConfig_15.uint_0);
												uint_ = new uint[2]
												{
													Class24.smethod_30(num38 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
													Class24.smethod_30(num38 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
												};
												Class24.ReadProcessMemory(characterAccountConfig.int_137, num38 + Class56.memorySignatureScanConfig_45.uint_0, array, 4, ref int_5);
												num39 = BitConverter.ToInt32(array, 0);
												if (characterAccountConfig.int_119 > 0 && characterAccountConfig.int_3 != null)
												{
													int num40 = -1;
													int num41 = -1;
													long long_7 = 0L;
													while (Class89.smethod_12(characterAccountConfig) != 1 && !Class46.smethod_7(characterAccountConfig, ref num9))
													{
														int num42 = 0;
														int value = 400;
														while (num42 <= 0)
														{
															num40++;
															if (characterAccountConfig.int_3 != null && characterAccountConfig.int_3.GetLength(0) > num40 && characterAccountConfig.int_4 != null)
															{
																num42 = characterAccountConfig.int_3[num40, 0];
																if (num42 > 0)
																{
																	value = Class83.smethod_20(characterAccountConfig, num42, characterAccountConfig.int_3[num40, 1]);
																	break;
																}
																continue;
															}
															goto IL_0ea9;
														}
														if (Class3.smethod_31(characterAccountConfig, num37, num42) != 0)
														{
															continue;
														}
														if (num36 <= 0)
														{
															if (num41 >= 0 && num41 == num40)
															{
																if (Class11.smethod_28(long_7) > 8000L)
																{
																	goto IL_0e6f;
																}
															}
															else
															{
																num41 = num40;
																long_7 = Class11.smethod_27();
															}
														}
														for (int m = 0; m < Class56.int_0; m++)
														{
															Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array, 1, ref int_5);
															if (array[0] == 0)
															{
																break;
															}
															Thread.Sleep(1);
														}
														Class64.smethod_30(characterAccountConfig);
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(num42), 4, ref int_5);
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(value), 4, ref int_5);
														Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num37 + array3[0]), 4, ref int_5);
														Thread.Sleep(30);
														num5 = 1;
													}
													Thread.Sleep(100);
													num5 = 0;
													break;
												}
												goto IL_0ea9;
											}
											Thread.Sleep(180);
											num5 = 0;
											break;
										}
										if (num5 > 0)
										{
											Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_5);
										}
										num5 = 0;
										break;
									}
									flag6 = false;
									flag5 = num30 > 25600L;
									Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_5);
									if (num30 < 160000L)
									{
										Class13.smethod_2(characterAccountConfig, bool_0: false);
										Class75.smethod_61(characterAccountConfig, bossCoordinates);
										Thread.Sleep(150);
										break;
									}
									Class64.smethod_29(characterAccountConfig, bool_0: false);
									if (!Class13.smethod_3(characterAccountConfig) || Class11.smethod_28(long_2) > 5000L)
									{
										Class13.smethod_1(characterAccountConfig, bossCoordinates);
										long_2 = Class11.smethod_27();
									}
									break;
								}
								flag6 = false;
								if (!flag2)
								{
									Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_5);
									Class75.smethod_52(characterAccountConfig, "<color=yellow>§\u00b8nh boss <" + Class1.smethod_2(struct28_0[num25].bossDisplayName) + "> t¹i (" + bossCoordinates[0] / 256 + "," + bossCoordinates[1] / 512 + ") " + Class39.smethod_1(struct28_0[num25].bossMapId));
									flag2 = true;
								}
								if (num18 <= 0 && Class64.smethod_9(num17) != null)
								{
									if (!flag3)
									{
										if (Class53.smethod_2(characterAccountConfig, "®iÓm c") > 0)
										{
											Class64.smethod_11(characterAccountConfig);
										}
										flag3 = true;
										break;
									}
									if (!flag4)
									{
										if (Class53.smethod_4(characterAccountConfig, bossMapId) > 0)
										{
											Class64.smethod_11(characterAccountConfig);
										}
										flag4 = true;
										break;
									}
								}
								if (Class75.smethod_3(characterAccountConfig, Class75.uint_19, 4) > 0 && num6 < 3 && Class29.smethod_7(characterAccountConfig, bossMapId))
								{
									num6++;
									break;
								}
								int num43 = -1;
								int num44 = -1;
								for (int n = 0; n < bossMapList.Length; n++)
								{
									if (bossMapList[n] == num17)
									{
										num43 = bossMapList[n];
										if (n < bossMapList.Length - 1)
										{
											num44 = bossMapList[n + 1];
										}
										break;
									}
								}
								if (num43 <= 0)
								{
									if (num18 > 0 && num7 < 3)
									{
										num7++;
										Class64.smethod_14(characterAccountConfig);
									}
									else if (Class11.smethod_28(long_3) > 30000L)
									{
										Class75.smethod_52(characterAccountConfig, "<color=yellow>§\u00b8nh bos S\u00b8t thñ: Kh«ng thÓ T§P vµ THP, kh«ng t×m ®\u00adîc ®\u00adêng ®i");
										num6 = 0;
										flag4 = false;
										long_3 = Class11.smethod_27();
									}
								}
								else
								{
									if (num43 == bossMapId || num44 < 0)
									{
										break;
									}
									GStruct28 gStruct2 = Class45.smethod_4(num43, num44);
									if (gStruct2.uint_0 == null)
									{
										if (Class11.smethod_28(long_3) > 30000L)
										{
											Class75.smethod_52(characterAccountConfig, "<color=yellow>§\u00b8nh boss s\u00b8t thñ: Auto ch\u00ada ®Þnh nghÜa ®\u00adêng ®i");
											long_3 = Class11.smethod_27();
										}
										break;
									}
									int num45 = 0;
									if (gStruct2.uint_0.GetLength(0) > 1)
									{
										num45 = Class64.smethod_20(gStruct2.uint_0, array4);
									}
									uint[] uint_2 = null;
									uint[] uint_3 = null;
									int num46 = 0;
									Class64.smethod_8(gStruct2.uint_0, num45, ref uint_2, ref uint_3, ref num46);
									if (Class64.smethod_18(array4, uint_2) >= 240000L)
									{
										int[] array7 = Class64.smethod_9(num17);
										num18 = (int)Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
										if (num18 <= 0 && array7 != null && array7[1] == 0)
										{
											uint[] array8 = Class45.smethod_11(uint_2, num17, "NGOAITHANH");
											if (array8 != null)
											{
												long num47 = Class64.smethod_18(uint_2, array8);
												if (num47 <= 400000000L)
												{
													uint[,] array9 = Class44.smethod_1(num17, array4, array8);
													if (array9 != null)
													{
														int num48 = Class64.smethod_20(array9, array8);
														if (num48 >= 0)
														{
															uint[] uint_4 = new uint[2]
															{
																array9[num48, 0],
																array9[num48, 1]
															};
															long num49 = Class64.smethod_18(array4, uint_4);
															if (num49 > 90000L)
															{
																Class13.smethod_2(characterAccountConfig, bool_0: false);
																Class64.smethod_22(characterAccountConfig, array9, array4, array8, num17, bool_0: true, 6000);
																break;
															}
														}
													}
												}
											}
										}
										if (!Class13.smethod_3(characterAccountConfig) || Class11.smethod_28(long_2) > 5000L)
										{
											Class13.smethod_1(characterAccountConfig, uint_2);
											long_2 = Class11.smethod_27();
											Thread.Sleep(300);
										}
										Class64.smethod_29(characterAccountConfig, bool_0: false);
									}
									else
									{
										Class64.smethod_23(characterAccountConfig, uint_2, num46, uint_3, gStruct2.int_1);
									}
								}
								break;
							}
							num3 = 0;
							num4 = 0;
							flag9 = true;
							if (smethod_5())
							{
								string text2 = "Tiếp tục săn boss <" + Class1.smethod_2(struct28_0[num25].bossDisplayName) + ">";
								if (Class88.smethod_5(characterAccountConfig).int_0 > 0)
								{
									Class75.smethod_57(characterAccountConfig, "Chat('CH_TEAM', '" + text2 + "')");
								}
								else
								{
									Class75.smethod_52(characterAccountConfig, "<color=yellow>" + text2);
								}
							}
							else
							{
								if (num25 + 1 < struct28_0.Length && struct28_0[num25 + 1].bossMapId == bossMapId)
								{
									num25++;
								}
								else
								{
									for (int num50 = 0; num50 < struct28_0.Length; num50++)
									{
										if (struct28_0[num50].bossMapId == bossMapId)
										{
											num25 = num50;
											break;
										}
									}
								}
								string text3 = "TiÕp theo lµ bos <" + Class1.smethod_2(struct28_0[num25].bossDisplayName) + ">";
								if (Class88.smethod_5(characterAccountConfig).int_0 > 0)
								{
									Class75.smethod_57(characterAccountConfig, "Chat('CH_TEAM', '" + text3 + "')");
								}
								else
								{
									Class75.smethod_52(characterAccountConfig, "<color=yellow>" + text3);
								}
							}
							num12 = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
							if (0 <= num12)
							{
								Form1.characterAccountConfig_1[num12].int_133[3] = num25;
							}
							if (flag7)
							{
								gStruct = Class88.smethod_5(characterAccountConfig);
								if (gStruct.int_0 > 1 && gStruct.gstruct60_0 != null && gStruct.gstruct60_0.Length > 1 && characterAccountConfig.string_22 == gStruct.string_0)
								{
									for (int num51 = 0; num51 < Form1.characterAccountConfig_1.Length; num51++)
									{
										for (int num52 = 0; num52 < gStruct.gstruct60_0.Length; num52++)
										{
											if (Form1.characterAccountConfig_1[num51].bool_25 && Form1.characterAccountConfig_1[num51].string_22 == gStruct.gstruct60_0[num52].string_0 && Form1.characterAccountConfig_1[num51].int_136 != characterAccountConfig.int_136 && Form1.characterAccountConfig_1[num51].int_133[0] > 0)
											{
												Form1.characterAccountConfig_1[num51].int_133[3] = num25;
												Form1.characterAccountConfig_1[num51].int_133[1] = 0;
											}
										}
									}
								}
							}
							flag7 = false;
							Thread.Sleep(3000);
							break;
						}
						Form1.characterAccountConfig_1[num12].int_133[0] = 0;
						Form1.characterAccountConfig_1[num12].int_133[1] = 0;
						if (num18 > 0)
						{
							if (!Class64.smethod_14(characterAccountConfig))
							{
								Class29.smethod_7(characterAccountConfig, struct28_0[num25].bossMapId, struct28_0[num25].bossDirection);
							}
							Thread.Sleep(1000);
						}
						Class75.smethod_52(characterAccountConfig, "<color=yellow>KET THUC, DA 8 LAN GIET SAT THU.");
						break;
					}
					num = -1L;
					num10 = num25;
					flag10 = false;
					flag6 = false;
					Form1.characterAccountConfig_1[num12].int_133[1] = 0;
					num3 = smethod_1(int_4);
					flag9 = true;
					Class75.smethod_57(characterAccountConfig, "ClearMessage()");
					break;
					IL_0ea9:
					if (num36 <= 0)
					{
						if (num <= 0L || num39 < num)
						{
							num = num39;
							long_6 = Class11.smethod_27();
						}
						if (Class11.smethod_28(long_6) > 12000L)
						{
							Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_5);
							Class64.smethod_12(characterAccountConfig, characterAccountConfig.int_93 > 0);
							for (int num53 = 0; num53 < 12; num53++)
							{
								array4 = new uint[2]
								{
									Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
									Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
								};
								if (Class64.smethod_18(array4, bossCoordinates) < 11500L)
								{
									break;
								}
								Class75.smethod_61(characterAccountConfig, bossCoordinates);
								Thread.Sleep(150);
							}
							num = num39;
							long_6 = Class11.smethod_27();
							break;
						}
					}
					Class64.smethod_30(characterAccountConfig);
					if (characterAccountConfig.bool_58 && characterAccountConfig.int_83 > 0 && Form1.int_106 == 0 && Class11.smethod_28(long_4) > characterAccountConfig.long_9)
					{
						Class38.smethod_54(characterAccountConfig, uint_, bool_0: false);
						Class38.smethod_55(characterAccountConfig);
						long_4 = Class11.smethod_27();
						Thread.Sleep(100);
					}
					num37 = array2[0] * array2[1] * num37 + array3[0];
					for (int num54 = 0; num54 < Class56.int_0; num54++)
					{
						Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_6 * 4, array, 1, ref int_5);
						if (array[0] == 0)
						{
							break;
						}
						Thread.Sleep(1);
					}
					Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_161.uint_0 - 8, BitConverter.GetBytes(Class83.smethod_13(characterAccountConfig)), 4, ref int_5);
					Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_31.uint_0, BitConverter.GetBytes(num34), 4, ref int_5);
					Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num37), 4, ref int_5);
					num5 = 1;
					break;
					IL_0e6f:
					Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_5);
					Class64.smethod_12(characterAccountConfig);
					break;
					continue;
					end_IL_0382:
					break;
				}
			}
			else
			{
				if (num5 > 0)
				{
					Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_5);
				}
				if (Form1.int_127 > 0)
				{
					Class24.WriteProcessMemory(characterAccountConfig.int_137, num16 + Class56.memorySignatureScanConfig_251.uint_0, Class56.byte_0, Class56.byte_0.Length, ref int_5);
				}
				num5 = 0;
			}
		}
	}

	private static int smethod_1(int int_4)
	{
		int num = 0;
		int num2 = 0;
		string text = "NhiÕp|Nhiªp| TrÇn|p Thi Tr";
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = -1;
		long long_ = 0L;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool bool_ = false;
		bool flag5 = false;
		bool flag6 = false;
		int result = 0;
		int num9 = -1;
		int num10 = 0;
		string text2 = null;
		while (true)
		{
			IL_0c56:
			Thread.Sleep(300);
			num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (Class11.bool_0 || num < 0)
			{
				break;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num];
			if (!characterAccountConfig.bool_25 || characterAccountConfig.int_133[0] <= 0)
			{
				break;
			}
			uint num11 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.int_137);
			uint num12 = Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig.int_137);
			uint num13 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig.int_137);
			uint num14 = num13 + num12 * Class56.memorySignatureScanConfig_15.uint_0;
			int num15 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
			int num16 = (int)Class24.smethod_30(num14 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
			int num17 = (int)Class24.smethod_30(num14 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
			int num18 = (int)Class24.smethod_30(num14 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig.int_137);
			int num19 = Class89.smethod_39(characterAccountConfig);
			if (num18 > 0 && num15 > 0 && num17 != 10 && num17 != 21 && num19 > 1 && Class89.smethod_12(characterAccountConfig) != 1)
			{
				if (num9 != num15)
				{
					num9 = num15;
				}
				if (num8 >= 0 && num8 == num16)
				{
					if (num16 == 0)
					{
						Class64.smethod_29(characterAccountConfig, bool_0: false);
					}
					uint[] uint_ = new uint[2]
					{
						Class24.smethod_30(num14 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
						Class24.smethod_30(num14 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
					};
					int bossLevel = struct28_0[characterAccountConfig.int_133[3]].bossLevel;
					int bossMapId = struct28_0[characterAccountConfig.int_133[3]].bossMapId;
					if (!flag2)
					{
						flag2 = num15 != bossLevel && num15 != bossMapId;
					}
					string bossDirection = struct28_0[characterAccountConfig.int_133[3]].bossDirection;
					uint[] array = null;
					Class45.smethod_12(bossLevel, "NhiÕp ThÝ TrÇn");
					if (num16 > 0 || (num15 != bossLevel && (int_1 <= 0 || Class64.smethod_9(num15) == null)))
					{
						flag4 = false;
						if (num16 > 0)
						{
							if (flag5)
							{
								result = 1;
								break;
							}
							if (num4 < 3)
							{
								num4++;
								if (Class64.smethod_14(characterAccountConfig))
								{
									continue;
								}
							}
						}
						if (num3 < 3 && Class75.smethod_3(characterAccountConfig, Class75.uint_19, 4) > 0)
						{
							array = Class45.smethod_12(bossLevel, "NhiÕp ThÝ TrÇn");
							if (Class29.smethod_7(characterAccountConfig, bossLevel, bossDirection, array))
							{
								num4 = 0;
								num3++;
								continue;
							}
						}
						if (num16 > 0)
						{
							uint[] array2 = Class45.smethod_11(uint_, num15, "Xa phu");
							if (array2 == null)
							{
								num4 = 0;
								num3 = 0;
							}
							else if (Class11.smethod_28(long_) > 4000L)
							{
								Class13.smethod_1(characterAccountConfig, array2);
								long_ = Class11.smethod_27();
							}
							continue;
						}
						if (Class64.smethod_9(num15) == null)
						{
							Class75.smethod_52(characterAccountConfig, "<color=yellow>Khong the ve thanh, that bai !");
							break;
						}
						if (int_1 <= 0)
						{
							Class53.smethod_5(characterAccountConfig, bossLevel);
							continue;
						}
					}
					if (!flag3 && flag2 && int_1 <= 0)
					{
						if (Class98.smethod_0(characterAccountConfig, bool_0: true) > 0)
						{
							flag3 = true;
							flag2 = false;
						}
						continue;
					}
					if (!flag4)
					{
						if (Class42.smethod_0(characterAccountConfig) == 0)
						{
							Thread.Sleep(300);
							continue;
						}
						int num20 = Class36.smethod_3(characterAccountConfig, Form1.int_105 <= 0);
						if (num20 != 0 && (num20 >= 0 || flag6))
						{
							flag4 = true;
							flag6 = false;
							if (characterAccountConfig.int_65 > 0)
							{
								Class64.smethod_3(characterAccountConfig, ref bool_);
							}
						}
						else
						{
							Thread.Sleep(300);
							flag6 = num20 < 0;
						}
						continue;
					}
					uint_ = new uint[2]
					{
						Class24.smethod_30(num14 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
						Class24.smethod_30(num14 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
					};
					array = Class45.smethod_12(num15, "NhiÕp ThÝ TrÇn");
					long num21 = Class64.smethod_18(uint_, array);
					if (num21 > 350000L)
					{
						uint[,] array3 = Class27.smethod_0(num15, uint_, array);
						if ((array3 == null || Class64.smethod_22(characterAccountConfig, array3, uint_, array, num15, bool_0: true, 10000) <= 0) && Class11.smethod_28(long_) > 4000L)
						{
							Class13.smethod_1(characterAccountConfig, array);
							long_ = Class11.smethod_27();
						}
						continue;
					}
					Class13.smethod_2(characterAccountConfig, bool_0: false);
					int num22 = 0;
					while (num22 < 15)
					{
						uint_ = new uint[2]
						{
							Class24.smethod_30(num14 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
							Class24.smethod_30(num14 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
						};
						num21 = Class64.smethod_18(uint_, array);
						if (num21 < 11500L)
						{
							break;
						}
						Class75.smethod_61(characterAccountConfig, array);
						num22++;
						Thread.Sleep(300);
					}
					while (true)
					{
						num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
						if (Class11.bool_0 || num < 0)
						{
							break;
						}
						characterAccountConfig = Form1.characterAccountConfig_1[num];
						if (!characterAccountConfig.bool_25 || characterAccountConfig.int_133[0] <= 0)
						{
							break;
						}
						num15 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
						int num24;
						int num25;
						if (num9 <= 0 || num9 == num15 || !flag5)
						{
							uint[] uint_2 = null;
							if (num2 > 0)
							{
								string text3 = Class3.smethod_16(characterAccountConfig, num2, ref uint_2, 30);
								bool flag7 = false;
								if (text3 != null && text3 != string.Empty)
								{
									string[] array4 = text.Split('|');
									string string_ = text3.ToLower();
									for (int i = 0; i < array4.Length; i++)
									{
										if (array4[i] != null && 0 <= Class11.smethod_1(string_, array4[i].ToLower()))
										{
											flag7 = true;
											break;
										}
									}
								}
								if (!flag7)
								{
									num2 = 0;
									uint_2 = null;
								}
							}
							if (num2 <= 0)
							{
								num2 = Class3.smethod_15(characterAccountConfig, text, ref uint_2, 3, bool_0: false);
								if (num2 <= 0)
								{
									Class64.smethod_12(characterAccountConfig);
									num5++;
									if (num5 > 10)
									{
										Class75.smethod_52(characterAccountConfig, "<color=yellow>Loi (1): Bi LAG, khong the nhan nhiem vu !");
										break;
									}
									goto IL_0c56;
								}
							}
							num5 = 0;
							num22 = 0;
							num4 = 0;
							num3 = 0;
							for (; num22 < 10; num22++)
							{
								if (num2 <= 0)
								{
									break;
								}
								if (uint_2 == null)
								{
									break;
								}
								uint_ = new uint[2]
								{
									Class24.smethod_30(num14 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
									Class24.smethod_30(num14 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
								};
								long num23 = Class64.smethod_18(uint_, uint_2);
								if (num23 < 11250L)
								{
									break;
								}
								Class75.smethod_61(characterAccountConfig, uint_2);
								Thread.Sleep(300);
							}
							Class95.smethod_8(characterAccountConfig);
							Thread.Sleep(100);
							Class38.smethod_10(characterAccountConfig, (uint)num2);
							Thread.Sleep(100);
							num22 = 0;
							while (Class95.smethod_0(characterAccountConfig) < 0)
							{
								num22++;
								if (num22 <= 10)
								{
									Thread.Sleep(100);
									continue;
								}
								goto IL_0ba7;
							}
							Thread.Sleep(600);
							num24 = Class95.smethod_0(characterAccountConfig);
							num25 = Class95.smethod_1(characterAccountConfig, num24);
							if (num25 > 0)
							{
								string[] array5 = new string[3] { "cÊp 90", "NhËn NhiÖm Vô S\u00b8t", "NhiÖm Vô S\u00b8t Thñ Ph" };
								if (!flag)
								{
									array5 = new string[1] { "hñy bá" };
								}
								int num26 = -1;
								for (int j = 0; j < array5.Length; j++)
								{
									string object_ = array5[j].ToUpper();
									for (int k = 0; k < num25; k++)
									{
										string string_2 = Class95.smethod_3(characterAccountConfig, k, num24, 128).ToUpper();
										if (0 <= Class11.smethod_1(string_2, object_))
										{
											num26 = k;
											Class95.smethod_5(characterAccountConfig, num26);
											Thread.Sleep(600);
											break;
										}
									}
								}
								string string_3 = Class95.smethod_2(characterAccountConfig);
								if (flag && Class11.smethod_1(string_3, "hñy bá nhi") <= 0)
								{
									string[] array6 = struct28_0[characterAccountConfig.int_133[3]].bossNamePattern.ToLower().Split('|');
									while (true)
									{
										Thread.Sleep(300);
										num24 = Class95.smethod_0(characterAccountConfig);
										num25 = Class95.smethod_1(characterAccountConfig, num24);
										if (num25 <= 0)
										{
											break;
										}
										if (num25 == 1)
										{
											string string_4 = Class95.smethod_2(characterAccountConfig, num24);
											if (Class11.smethod_1(string_4, "khinh k") > 0)
											{
												Class95.smethod_5(characterAccountConfig, 0);
												return 2;
											}
										}
										num26 = -1;
										int num27 = -1;
										for (int l = 0; l < num25; l++)
										{
											string string_5 = Class95.smethod_3(characterAccountConfig, l, num24, 128).ToLower();
											bool flag8 = false;
											for (int m = 0; m < array6.Length; m++)
											{
												if (Class11.smethod_1(string_5, array6[m]) == 0)
												{
													flag8 = true;
													break;
												}
											}
											if (!flag8)
											{
												if (0 <= Class11.smethod_1(string_5, "trang k") || 0 <= Class11.smethod_1(string_5, "trang s"))
												{
													num27 = l;
												}
												continue;
											}
											num26 = l;
											Class95.smethod_5(characterAccountConfig, num26);
											Thread.Sleep(600);
											break;
										}
										if (num26 < 0 && 0 <= num27)
										{
											Class95.smethod_5(characterAccountConfig, num27);
											Thread.Sleep(600);
											continue;
										}
										goto IL_0a47;
									}
									Class95.smethod_8(characterAccountConfig);
									num6++;
									if (num6 > 8)
									{
										break;
									}
								}
								else
								{
									Class95.smethod_5(characterAccountConfig, 0);
									Thread.Sleep(300);
									flag = true;
									num7 = 0;
								}
								continue;
							}
							Class95.smethod_8(characterAccountConfig);
							break;
						}
						result = 1;
						break;
						IL_0ba7:
						Class64.smethod_12(characterAccountConfig);
						num6++;
						if (num6 <= 8)
						{
							if (num6 % 3 != 0)
							{
								continue;
							}
							goto IL_0c56;
						}
						Class75.smethod_52(characterAccountConfig, "<color=yellow>Loi (2): Bi LAG, khong the nhan nhiem vu !");
						break;
						IL_0a47:
						Thread.Sleep(600);
						num24 = Class95.smethod_0(characterAccountConfig);
						num25 = Class95.smethod_1(characterAccountConfig, num24);
						string text4 = Class95.smethod_2(characterAccountConfig, num24);
						if (Class11.smethod_1(text4, "khinh k") <= 0)
						{
							if (num25 > 0)
							{
								Class95.smethod_5(characterAccountConfig, 0);
								Thread.Sleep(600);
							}
							string text5 = string.Empty;
							if (Class95.Class92.smethod_4(characterAccountConfig))
							{
								text5 = Class95.Class92.smethod_0(characterAccountConfig);
							}
							if (num10 <= 0 && text5 != null && text5 != string.Empty && text5.IndexOf("ng©n l\u00adîng") > 0)
							{
								if (characterAccountConfig.string_15 != null && characterAccountConfig.string_15 != string.Empty)
								{
									uint num28 = Class11.smethod_12(characterAccountConfig.string_15);
									if (num28 != 0)
									{
										Class75.smethod_117(characterAccountConfig, num28);
										Thread.Sleep(300);
									}
								}
								uint num29 = Class38.smethod_41(characterAccountConfig, bool_0: true);
								if (num29 != 0)
								{
									if (num29 > 2000000)
									{
										num29 = 2000000u;
									}
									Class75.smethod_37(characterAccountConfig, num29);
								}
								num10 = 1;
								num7 = 0;
							}
							flag5 = true;
							if (num10 == 1 || (num7 < 2 && Class11.smethod_1(text4, "ng\u00ad¬i th¾ng") < 0))
							{
								if (num10 == 1)
								{
									num10 = 2;
								}
								num7++;
								continue;
							}
							int num30 = Class11.smethod_1(text4, ":");
							int num31 = Class11.smethod_1(text4, ")");
							text2 = ((num30 <= 0 || num31 <= num30) ? ("§· nhËn giÕt <" + Class1.smethod_2(struct28_0[characterAccountConfig.int_133[3]].bossDisplayName) + ">") : ("§· nhËn giÕt " + text4.Substring(num30 + 2, num31 - num30 - 1)));
							if (Class88.smethod_5(characterAccountConfig).int_0 > 0)
							{
								Class75.smethod_57(characterAccountConfig, "Chat('CH_TEAM', '" + text2 + "')");
							}
							else
							{
								Class75.smethod_52(characterAccountConfig, "<color=yellow>" + text2);
							}
							result = 1;
							break;
						}
						Class95.smethod_5(characterAccountConfig, 0);
						return 2;
					}
					break;
				}
				for (int n = 0; n < 8; n++)
				{
					if (num16 == num8)
					{
						break;
					}
					if (num8 <= 0)
					{
						break;
					}
					num16 = (int)Class24.smethod_30(num14 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
					Thread.Sleep(100);
				}
				num8 = num16;
			}
			else
			{
				Thread.Sleep(100);
			}
		}
		if (num10 > 0 && characterAccountConfig.int_65 > 0)
		{
			Class64.smethod_3(characterAccountConfig, ref bool_);
		}
		return result;
	}

	public static void smethod_2()
	{
		int int_ = int_3;
		int_3 = 0;
		try
		{
			smethod_3(int_);
		}
		catch
		{
		}
	}

	public static void smethod_3(int int_4)
	{
		int num = 0;
		int num2 = 0;
		string text = "NhiÕp|Nhiªp| TrÇn|p Thi Tr";
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = -1;
		long long_ = 0L;
		int num7 = 0;
		string text2 = "S\u00b8t Thñ lÖnh";
		byte[] array = new byte[text2.Length + 1];
		uint num8 = 12u;
		while (true)
		{
			Thread.Sleep(300);
			num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (Class11.bool_0 || num < 0 || Form1.int_24 != 0 || !Form1.characterAccountConfig_1[num].bool_25)
			{
				break;
			}
			characterAccountConfig_ = Form1.characterAccountConfig_1[num];
			if (smethod_4(characterAccountConfig_) < 5)
			{
				break;
			}
			if (Class47.smethod_20(characterAccountConfig_) >= 0)
			{
				uint num9 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_.int_137);
				uint num10 = Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_.int_137);
				uint num11 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_.int_137);
				uint num12 = num11 + num10 * Class56.memorySignatureScanConfig_15.uint_0;
				int num13 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_.int_137);
				int num14 = (int)Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_.int_137);
				int num15 = (int)Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_.int_137);
				int num16 = (int)Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_.int_137);
				int num17 = Class89.smethod_39(characterAccountConfig_);
				if (num16 <= 0 || num13 <= 0 || num15 == 10 || num15 == 21 || num17 <= 1)
				{
					continue;
				}
				if (num6 >= 0 && num6 == num14)
				{
					if (num14 == 0)
					{
						Class64.smethod_29(characterAccountConfig_, bool_0: false);
					}
					uint[] array2 = new uint[2]
					{
						Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_.int_137),
						Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_.int_137)
					};
					int[] array3 = Class64.smethod_9(num13);
					if (array3 != null && array3[1] == 0 && num14 <= 0)
					{
						uint[] array4 = Class45.smethod_12(num13, "NhiÕp ThÝ TrÇn");
						long num18 = Class64.smethod_18(array2, array4);
						if (num18 > 350000L)
						{
							uint[,] array5 = Class27.smethod_0(num13, array2, array4);
							if ((array5 == null || Class64.smethod_22(characterAccountConfig_, array5, array2, array4, num13, bool_0: true, 10000) <= 0) && Class11.smethod_28(long_) > 4000L)
							{
								Class13.smethod_1(characterAccountConfig_, array4);
								long_ = Class11.smethod_27();
							}
							continue;
						}
						Class13.smethod_2(characterAccountConfig_, bool_0: false);
						int num19 = 0;
						while (num19 < 15)
						{
							array2 = new uint[2]
							{
								Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_.int_137),
								Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_.int_137)
							};
							num18 = Class64.smethod_18(array2, array4);
							if (num18 < 11500L)
							{
								break;
							}
							Class75.smethod_61(characterAccountConfig_, array4);
							num19++;
							Thread.Sleep(300);
						}
						uint[] uint_ = null;
						if (num2 > 0)
						{
							string text3 = Class3.smethod_16(characterAccountConfig_, num2, ref uint_, 30);
							bool flag = false;
							if (text3 != null && text3 != string.Empty)
							{
								string[] array6 = text.Split('|');
								string string_ = text3.ToLower();
								for (int i = 0; i < array6.Length; i++)
								{
									if (array6[i] != null && 0 <= Class11.smethod_1(string_, array6[i].ToLower()))
									{
										flag = true;
										break;
									}
								}
							}
							if (!flag)
							{
								num2 = 0;
								uint_ = null;
							}
						}
						if (num2 <= 0)
						{
							num2 = Class3.smethod_15(characterAccountConfig_, text, ref uint_, 3, bool_0: false);
							if (num2 <= 0)
							{
								Class64.smethod_12(characterAccountConfig_);
								num5++;
								if (num5 > 10)
								{
									Class75.smethod_52(characterAccountConfig_, "<color=yellow>Loi (1): Bi LAG, khong the nhan nhiem vu !");
									break;
								}
								continue;
							}
						}
						Class95.smethod_8(characterAccountConfig_);
						Thread.Sleep(100);
						Class38.smethod_10(characterAccountConfig_, (uint)num2);
						Thread.Sleep(100);
						num19 = 0;
						while (Class95.smethod_0(characterAccountConfig_) < 0)
						{
							num19++;
							if (num19 <= 10)
							{
								Thread.Sleep(100);
								continue;
							}
							goto IL_08bc;
						}
						Thread.Sleep(600);
						int num20 = Class95.smethod_0(characterAccountConfig_);
						int num21 = Class95.smethod_1(characterAccountConfig_, num20);
						if (num21 <= 0)
						{
							Class64.smethod_12(characterAccountConfig_);
							continue;
						}
						bool flag2 = false;
						for (int j = 0; j < num21; j++)
						{
							string string_2 = Class95.smethod_3(characterAccountConfig_, j, num20, 128).ToLower();
							if (0 <= Class11.smethod_1(string_2, "p th"))
							{
								Class95.smethod_5(characterAccountConfig_, j);
								Thread.Sleep(600);
								num19 = 0;
								while (num19 < 10 && Class95.smethod_0(characterAccountConfig_) >= 0)
								{
									num19++;
									Thread.Sleep(100);
								}
								flag2 = Class47.smethod_8(characterAccountConfig_);
								Class95.smethod_8(characterAccountConfig_);
								break;
							}
						}
						if (flag2)
						{
							int int_5 = 0;
							byte[] array7 = new byte[4];
							uint num22 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_.int_137) + Class56.memorySignatureScanConfig_97.uint_0;
							uint num23 = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_.int_137);
							int num24 = Class85.smethod_4(characterAccountConfig_);
							int num25 = 0;
							int num26 = 0;
							int num27 = 0;
							for (uint num28 = 1u; num28 < Class56.int_1; num28++)
							{
								if (num26 > 3)
								{
									num27 = smethod_4(characterAccountConfig_, (int)num8);
								}
								if (num24 <= num25 || num27 > 4)
								{
									break;
								}
								uint num29 = num23 + num28 * Class56.memorySignatureScanConfig_106.uint_0;
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, num29 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array7, 4, ref int_5);
								if (BitConverter.ToInt32(array7, 0) != 0)
								{
									continue;
								}
								uint num30 = Class85.smethod_1(characterAccountConfig_, num28);
								if ((int)num30 <= 0)
								{
									continue;
								}
								num25++;
								uint uint_2 = num29 + Class56.memorySignatureScanConfig_107.uint_0;
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, uint_2, array7, 1, ref int_5);
								if ((array7[0] != 83 && array7[0] != 115) || (int)Class24.smethod_30(num29 + Class56.memorySignatureScanConfig_108.uint_0, characterAccountConfig_.int_137) <= 0)
								{
									continue;
								}
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, num29 + Class56.memorySignatureScanConfig_114.uint_0, array7, 4, ref int_5);
								if (BitConverter.ToInt32(array7, 0) != 90)
								{
									continue;
								}
								uint num31 = Class24.smethod_30(num22 + num30 * 20 + Class56.memorySignatureScanConfig_100.uint_0 - 8, characterAccountConfig_.int_137);
								if (num31 != 23 && num31 != 3)
								{
									continue;
								}
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, uint_2, array, array.Length, ref int_5);
								string string_3 = Class1.smethod_3(array).ToLower();
								if (Class11.smethod_1(string_3, text2.ToLower()) != 0)
								{
									continue;
								}
								uint num32 = num22 + num30 * 20;
								uint num33 = Class24.smethod_30(num32 + Class56.memorySignatureScanConfig_100.uint_0 - 4, characterAccountConfig_.int_137);
								uint num34 = Class24.smethod_30(num32 + Class56.memorySignatureScanConfig_100.uint_0, characterAccountConfig_.int_137);
								uint uint_3 = Class24.smethod_30(num29 + Class56.memorySignatureScanConfig_111.uint_0, characterAccountConfig_.int_137);
								uint uint_4 = Class24.smethod_30(num29 + Class56.memorySignatureScanConfig_112.uint_0, characterAccountConfig_.int_137);
								uint[] array8 = Class85.smethod_26(characterAccountConfig_, num8, uint_3, uint_4);
								if (array8 == null)
								{
									goto end_IL_09b0;
								}
								Class75.smethod_46(characterAccountConfig_, num33, num34, num31, num33, num34, num31);
								num19 = 0;
								while ((int)Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_.int_137) <= 0)
								{
									num19++;
									if (num19 <= 10)
									{
										Thread.Sleep(100);
										continue;
									}
									goto IL_0864;
								}
								Class75.smethod_46(characterAccountConfig_, array8[0], array8[1], num8, array8[0], array8[1], num8);
								num19 = 0;
								while ((int)Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_.int_137) > 0)
								{
									num19++;
									if (num19 <= 10)
									{
										Thread.Sleep(100);
										continue;
									}
									goto IL_0857;
								}
								num26++;
							}
							if (num27 < 5)
							{
								num27 = smethod_4(characterAccountConfig_, (int)num8);
							}
							if (num27 <= 4)
							{
								break;
							}
							Class75.smethod_110(characterAccountConfig_);
							Thread.Sleep(300);
							Class95.smethod_8(characterAccountConfig_);
						}
						else if (num7 > 3)
						{
							break;
						}
					}
					else if (num3 < 3 && Class29.smethod_7(characterAccountConfig_, 80, "t©y"))
					{
						num3++;
					}
					else if (num14 > 0 && num4 < 3 && Class64.smethod_14(characterAccountConfig_))
					{
						num4++;
					}
					else
					{
						if (array3 == null)
						{
							continue;
						}
						if (num14 > 0)
						{
							uint[] array9 = Class45.smethod_11(array2, num13, "Xa phu");
							if (array9 != null && Class11.smethod_28(long_) > 4000L)
							{
								Class13.smethod_1(characterAccountConfig_, array9);
								long_ = Class11.smethod_27();
							}
						}
						else
						{
							Class53.smethod_7(characterAccountConfig_);
						}
					}
					continue;
				}
				for (int k = 0; k < 8; k++)
				{
					if (num14 == num6)
					{
						break;
					}
					if (num6 <= 0)
					{
						break;
					}
					num14 = (int)Class24.smethod_30(num12 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_.int_137);
					Thread.Sleep(100);
				}
				num6 = num14;
				continue;
			}
			Class75.smethod_52(characterAccountConfig_, "<color=yellow>Kh«ng thÓ ®Æt vËt phÈm xuèng.");
			break;
			IL_0857:
			Class75.smethod_110(characterAccountConfig_, bool_0: false);
			continue;
			IL_0864:
			Class75.smethod_110(characterAccountConfig_, bool_0: false);
			continue;
			IL_08bc:
			Class64.smethod_12(characterAccountConfig_);
			continue;
			end_IL_09b0:
			break;
		}
		if (Class47.smethod_8(characterAccountConfig_))
		{
			Class75.smethod_110(characterAccountConfig_, bool_0: false);
		}
		Class95.smethod_8(characterAccountConfig_);
		Class75.smethod_52(characterAccountConfig_, "<color=green>KÕt thóc ghÐp s\u00b8t thñ gi¶n.");
	}

	public static int smethod_4(CharacterAccountConfig characterAccountConfig_0, int int_4 = -1)
	{
		string text = "S\u00b8t Thñ lÖnh".ToLower();
		int int_5 = 0;
		byte[] array = new byte[text.Length + 1];
		byte[] array2 = new byte[4];
		int num = Class85.smethod_4(characterAccountConfig_0);
		int num2 = 0;
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_97.uint_0;
		uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		int num5 = 0;
		for (uint num6 = 1u; num6 < Class56.int_1 && num > num2; num6++)
		{
			uint num7 = num4 + num6 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_5);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			uint num8 = Class85.smethod_1(characterAccountConfig_0, num6);
			if ((int)num8 <= 0)
			{
				continue;
			}
			num2++;
			uint uint_ = num7 + Class56.memorySignatureScanConfig_107.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array2, 1, ref int_5);
			if ((array2[0] != 83 && array2[0] != 115) || (int)Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_108.uint_0, characterAccountConfig_0.int_137) <= 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_114.uint_0, array2, 4, ref int_5);
			if (BitConverter.ToInt32(array2, 0) != 90)
			{
				continue;
			}
			uint num9 = Class24.smethod_30(num3 + num8 * 20 + Class56.memorySignatureScanConfig_100.uint_0 - 8, characterAccountConfig_0.int_137);
			if (int_4 > 0)
			{
				if (int_4 != num9)
				{
					continue;
				}
			}
			else if (num9 != 23 && num9 != 3)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, array.Length, ref int_5);
			string string_ = Class1.smethod_3(array).ToLower();
			if (Class11.smethod_1(string_, text.ToLower()) == 0)
			{
				num5++;
			}
		}
		return num5;
	}

	private static bool smethod_5()
	{
		try
		{
			return Form1.smethod_3();
		}
		catch
		{
		}
		return false;
	}
}
