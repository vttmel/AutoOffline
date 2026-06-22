using System;
using System.Threading;
using ns1;
using ns100;
using ns11;
using ns13;
using ns18;
using ns23;
using ns28;
using ns3;
using ns35;
using ns41;
using ns42;
using ns44;
using ns50;
using ns53;
using ns56;
using ns61;
using ns71;
using ns81;
using ns83;
using ns85;
using ns88;
using ns91;

namespace ns33;

internal class Class36
{
	public static int[] smethod_0(CharacterAccountConfig characterAccountConfig_0)
	{
		if (Class85.smethod_25(characterAccountConfig_0) != 0)
		{
			int[] array = new int[3] { 100, 100, 100 };
			if (characterAccountConfig_0.int_71[0] > 0 && characterAccountConfig_0.int_71[2] > 0 && characterAccountConfig_0.string_11 != null && characterAccountConfig_0.string_11 != string.Empty)
			{
				array[0] = Class85.smethod_31(characterAccountConfig_0, characterAccountConfig_0.string_11);
			}
			if (characterAccountConfig_0.int_72[0] > 0 && characterAccountConfig_0.int_72[2] > 0 && characterAccountConfig_0.string_12 != null && characterAccountConfig_0.string_12 != string.Empty)
			{
				array[1] = Class85.smethod_31(characterAccountConfig_0, characterAccountConfig_0.string_12);
			}
			if (characterAccountConfig_0.int_73[0] > 0 && characterAccountConfig_0.int_73[2] > 0 && characterAccountConfig_0.string_13 != null && characterAccountConfig_0.string_13 != string.Empty)
			{
				array[2] = Class85.smethod_31(characterAccountConfig_0, characterAccountConfig_0.string_13);
			}
			return array;
		}
		return null;
	}

	public static int smethod_1(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = false)
	{
		string[] array = new string[3] { characterAccountConfig_0.string_11, characterAccountConfig_0.string_12, characterAccountConfig_0.string_13 };
		int[,] array2 = new int[3, 3]
		{
			{
				characterAccountConfig_0.int_71[0],
				characterAccountConfig_0.int_71[2],
				0
			},
			{
				characterAccountConfig_0.int_72[0],
				characterAccountConfig_0.int_72[2],
				0
			},
			{
				characterAccountConfig_0.int_73[0],
				characterAccountConfig_0.int_73[2],
				0
			}
		};
		bool flag = false;
		for (int i = 0; i < array2.GetLength(0); i++)
		{
			if (array2[i, 0] > 0 && array[i] != null && !(array[i] == string.Empty))
			{
				int num = Class85.smethod_31(characterAccountConfig_0, array[i].Trim());
				array2[i, 2] = array2[i, 1] - num;
				if (array2[i, 2] > 0 && (bool_0 || num <= Form1.int_60))
				{
					flag = true;
				}
			}
		}
		int result = 1;
		if (flag)
		{
			result = -1;
			for (int j = 0; j < array2.GetLength(0); j++)
			{
				if (array2[j, 2] <= 0)
				{
					continue;
				}
				try
				{
					int num2 = smethod_2(characterAccountConfig_0, Class19.string_0[j], array[j], array2[j, 2]);
					if (num2 > 0)
					{
						result = 1;
					}
					if (num2 != -2)
					{
						continue;
					}
					return result;
				}
				catch
				{
					Class75.smethod_2(characterAccountConfig_0, Class75.uint_32, 0, 4);
				}
			}
		}
		return result;
	}

	public static int smethod_2(CharacterAccountConfig characterAccountConfig_0, string string_0, string string_1, int int_0)
	{
		Struct24[] array = Class89.smethod_1(characterAccountConfig_0);
		if (array == null)
		{
			Class75.smethod_52(characterAccountConfig_0, "Khong the su dung chuc nang mua o Bao vat.");
			Thread.Sleep(1000);
			return 1;
		}
		int num = -1;
		for (int i = 0; i < array.Length; i++)
		{
			if (string_0 == array[i].string_0)
			{
				num = i;
				break;
			}
		}
		if (num < 0)
		{
			Class75.smethod_52(characterAccountConfig_0, "Kh«ng thÓ mua ë b¶o vËt, bÊm nót <KTC, B¶o vËt> cña auto ®Ó chän l¹i.");
			Thread.Sleep(1000);
			return 1;
		}
		string_1 = string_1.Trim().ToLower();
		int num2 = -1;
		int num3 = array[num].int_0 - array[0].int_0;
		Class75.smethod_26(characterAccountConfig_0, string_0);
		Thread.Sleep(300);
		Class75.smethod_27(characterAccountConfig_0);
		GStruct1[] array2 = Class19.smethod_1(characterAccountConfig_0);
		if (array2 != null && array2.Length != 0)
		{
			for (int j = 0; j < array2.Length; j++)
			{
				if (string_1 == array2[j].string_0.ToLower().Trim())
				{
					num2 = array2[j].int_0;
					break;
				}
			}
			if (num2 >= 0)
			{
				int k = 0;
				uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_165.uint_0, characterAccountConfig_0.int_137);
				for (; k < 4; k++)
				{
					uint num5 = Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_167.uint_0, characterAccountConfig_0.int_137);
					if (num5 != 0)
					{
						uint num6 = Class24.smethod_30(num5 + (uint)(k * 4), characterAccountConfig_0.int_137);
						if (num6 != 0 && Class24.smethod_30(num6, characterAccountConfig_0.int_137) != 0)
						{
							Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_56);
							Thread.Sleep(100);
						}
					}
				}
				int int_1 = 0;
				byte[] array3 = new byte[15];
				for (int l = 1; l < 60; l++)
				{
					if (l % 5 == 0)
					{
						int num7 = Class87.smethod_3(Form1.characterAccountConfig_1, characterAccountConfig_0.int_136);
						if (Class11.bool_0 || num7 < 0 || !Form1.characterAccountConfig_1[num7].bool_25)
						{
							return -2;
						}
					}
					int num8 = Class85.smethod_4(characterAccountConfig_0);
					Class75.smethod_28(characterAccountConfig_0, num2, num3 + Form1.int_9);
					Thread.Sleep(100);
					k = 0;
					bool flag = false;
					for (; k < 80; k++)
					{
						if (num8 == Class85.smethod_4(characterAccountConfig_0))
						{
							Thread.Sleep(10);
							continue;
						}
						flag = true;
						int_0--;
						break;
					}
					if (!flag || int_0 <= 0)
					{
						break;
					}
					uint num9 = Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_167.uint_0, characterAccountConfig_0.int_137);
					if (num9 == 0)
					{
						continue;
					}
					uint num10 = Class24.smethod_30(num9, characterAccountConfig_0.int_137);
					if (num10 != 0)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10, array3, array3.Length, ref int_1);
						string text = Class1.smethod_3(array3);
						if (text != string.Empty && Class11.smethod_1(text, "kh«ng") > 0)
						{
							break;
						}
						Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_56);
						Thread.Sleep(100);
					}
				}
				return 1;
			}
			return -1;
		}
		return -1;
	}

	public static int smethod_3(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		while (true)
		{
			try
			{
				if (characterAccountConfig_0.int_77 > 0)
				{
					smethod_1(characterAccountConfig_0);
					return 1;
				}
				return smethod_5(characterAccountConfig_0, bool_0);
			}
			catch
			{
				Class75.smethod_2(characterAccountConfig_0, Class75.uint_32, 0, 4);
			}
		}
	}

	private static int smethod_4(CharacterAccountConfig characterAccountConfig_0, int int_0)
	{
		int num = Class85.smethod_25(characterAccountConfig_0);
		if (int_0 > num)
		{
			int_0 = num;
		}
		if (int_0 < 1)
		{
			int_0 = 1;
		}
		return int_0;
	}

	private static int smethod_5(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = true)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_32 * 4, array, 1, ref int_);
		if (array[0] <= 0)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
			int int_2 = BitConverter.ToInt32(array, 0);
			if (Class59.smethod_1(int_2) == null)
			{
				byte[] byte_ = new byte[4];
				byte[] array2 = new byte[3];
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				int num10 = 0;
				int num11 = 0;
				int num12 = 0;
				int num13 = -1;
				int num14 = 0;
				int num15 = 0;
				int num16 = 0;
				int num17 = 0;
				int num18 = 0;
				int num19 = 0;
				int num20 = 0;
				int num21 = 0;
				int num22 = 0;
				int num23 = 0;
				int num24 = 0;
				long long_ = 0L;
				string text = null;
				string text2 = null;
				uint[] uint_ = null;
				string text3 = null;
				string string_ = "Giao|ua d\u00adîc p|Më shop|Trao ®æi|chØ ®Õn|Mua ";
				GStruct1[] array3 = null;
				int num25 = 0;
				while (true)
				{
					Thread.Sleep(300);
					int num26 = Class87.smethod_3(Form1.characterAccountConfig_1, characterAccountConfig_0.int_136);
					uint num27;
					uint num30;
					int num33;
					int num35;
					bool flag;
					uint[] array4;
					if (!Class11.bool_0 && num26 >= 0 && Form1.characterAccountConfig_1[num26].bool_25 && !Form1.bool_18)
					{
						if (num17 > 0)
						{
							Form1.characterAccountConfig_1[num26].int_70 = 0;
							num17 = 0;
						}
						characterAccountConfig_0 = Form1.characterAccountConfig_1[num26];
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
						num27 = BitConverter.ToUInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num27 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
						uint num28 = BitConverter.ToUInt32(array, 0) * Class56.memorySignatureScanConfig_15.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
						uint num29 = BitConverter.ToUInt32(array, 0);
						num30 = num29 + num28;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num30 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
						int num31 = BitConverter.ToInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num30 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_);
						int num32 = BitConverter.ToInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num30 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_);
						num33 = BitConverter.ToInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
						int_2 = BitConverter.ToInt32(array, 0);
						int num34 = Class89.smethod_39(characterAccountConfig_0);
						if (num31 != 0 && num32 != 0 && int_2 != 0 && num34 > 1 && num32 != 10 && num32 != 21)
						{
							num7 = 0;
							if (characterAccountConfig_0.int_79 > 0 && Form1.int_103 > 0 && num24 == 0)
							{
								num24 = 1;
								string text4 = Form1.string_35;
								if (characterAccountConfig_0.string_11 != null && characterAccountConfig_0.string_11 != string.Empty)
								{
									if (text4 != null && text4 != string.Empty)
									{
										text4 += "|";
									}
									text4 += characterAccountConfig_0.string_11;
								}
								if (text4 != null && text4 != string.Empty)
								{
									if (smethod_7(characterAccountConfig_0, text4) != 1)
									{
										num15 = 2;
									}
									continue;
								}
							}
							num35 = Class85.smethod_25(characterAccountConfig_0);
							if (num35 != 0)
							{
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
								int_2 = BitConverter.ToInt32(array, 0);
								if (num13 != int_2 && num2 > 0 && num13 > 0)
								{
									num2 = 0;
									num13 = int_2;
									Class98.smethod_0(characterAccountConfig_0, bool_0: true);
									continue;
								}
								string text5 = Class24.smethod_28(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_28.uint_0 + Class56.memorySignatureScanConfig_29.uint_0, characterAccountConfig_0.int_137, 20);
								flag = int_2 == 540 || int_2 == 541 || int_2 == 542 || 0 <= Class11.smethod_1(text5, "tr\u00adêng §¹") || 0 <= Class11.smethod_1(text5.ToLower(), "tr\u00adêng li".ToLower());
								bool flag2 = int_2 == 13;
								if (int_2 == 333)
								{
									Class11.smethod_1(text5, "Hoa");
								}
								text3 = ((int_2 == 977 && (0 <= Class11.smethod_1(text5, "Cæ") || 0 <= Class11.smethod_1(text5, "Hßa B"))) ? "Qu©n Nhu|D\u00adîc §iÕm|d\u00adîc ®iÕm|\u00b8n thuèc|D\u00adîc th\u00ad¬ng|iÖu thuèc|HËu cÇn H|u doanh q|ThÇn Y|D\u00adîc S\u00ad" : ((!flag2 || characterAccountConfig_0.int_70 <= 0) ? "D\u00adîc §iÕm|d\u00adîc ®iÕm|\u00b8n thuèc|D\u00adîc th\u00ad¬ng|iÖu thuèc|HËu cÇn H|u doanh q|ThÇn Y|D\u00adîc S\u00ad" : "D\u00adîc S\u00ad|DiÖu KhiÕt"));
								array4 = new uint[2]
								{
									Class24.smethod_30(num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
									Class24.smethod_30(num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
								};
								num16 = 0;
								if (characterAccountConfig_0.int_78 > 0 && num14 == 0 && Form1.int_134 != null && Form1.string_35 != null && Form1.string_35 != string.Empty)
								{
									int num36 = Class85.smethod_31(characterAccountConfig_0, Form1.string_35);
									if (num36 <= Form1.int_60)
									{
										text = Form1.string_35;
										num14 = 1;
										num22 = 1;
										num16 = 1;
									}
								}
								if (num14 != 1)
								{
									num20 = -1;
									num21 = -1;
									for (int i = 0; i < 3; i++)
									{
										int[] array5 = null;
										switch (i)
										{
										default:
											array5 = characterAccountConfig_0.int_73;
											text = characterAccountConfig_0.string_13;
											break;
										case 1:
											array5 = characterAccountConfig_0.int_72;
											text = characterAccountConfig_0.string_12;
											break;
										case 0:
											array5 = characterAccountConfig_0.int_71;
											text = characterAccountConfig_0.string_11;
											break;
										}
										if (array2[i] > 0 || array5[0] <= 0 || array5[2] <= 0 || array5 == null || text == null || text == string.Empty || 0 <= text.IndexOf("H·y mua"))
										{
											continue;
										}
										int num37 = Class85.smethod_31(characterAccountConfig_0, text);
										int num38 = array5[2] - num37;
										if (num38 <= 0 || (num37 > Form1.int_60 && (num23 != 2 || i != 0)))
										{
											array2[i] = 1;
											continue;
										}
										if (i == 0)
										{
											num16 = 1;
										}
										num20 = num38;
										num21 = i;
										break;
									}
									if (num20 <= 0)
									{
										num8 = 1;
										break;
									}
									if (array3 != null && Class47.smethod_8(characterAccountConfig_0))
									{
										goto IL_1017;
									}
								}
								if (num12 == 0)
								{
									if (Class47.smethod_8(characterAccountConfig_0))
									{
										Class47.smethod_11(characterAccountConfig_0);
									}
									Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num30 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_);
									Class75.smethod_2(characterAccountConfig_0, Class75.uint_32, 257, 4);
									num12 = 1;
									Class75.smethod_52(characterAccountConfig_0, "<color=green><bclr=blue>* Mua thuèc...");
								}
								if (num18 > 0)
								{
									string text6 = Class3.smethod_16(characterAccountConfig_0, num18, ref uint_, 40);
									if (text6 == text2)
									{
										goto IL_0810;
									}
								}
								goto IL_0d89;
							}
							num8 = 1;
							break;
						}
						if (num7 < 5)
						{
							num7++;
							continue;
						}
						num8 = -1;
						break;
					}
					num8 = 0;
					break;
					IL_0e55:
					Class75.smethod_52(characterAccountConfig_0, "<color=yellow>Kh«ng thÓ mua m\u00b8u ë Nga my !...");
					num17 = 1;
					num18 = 0;
					continue;
					IL_139c:
					num18 = 0;
					Class64.smethod_12(characterAccountConfig_0);
					continue;
					IL_1017:
					num25 = 2;
					if (array3 == null)
					{
						array3 = Class19.smethod_1(characterAccountConfig_0);
						if (array3 == null)
						{
							num8 = -7;
							break;
						}
					}
					int num39 = -1;
					int num40 = -1;
					string text7 = text.Trim();
					string object_ = text.ToUpper();
					if (array3 != null)
					{
						for (int j = 0; j < array3.Length; j++)
						{
							if (0 <= Class11.smethod_1(array3[j].string_0.ToUpper(), object_))
							{
								num40 = array3[j].int_0;
							}
							if (text7 == array3[j].string_0.Trim())
							{
								num39 = array3[j].int_0;
								break;
							}
						}
					}
					if (num39 < 0)
					{
						num39 = num40;
						if (num39 < 0)
						{
							array2[num21] = 1;
							continue;
						}
					}
					int k = 0;
					uint num41 = Class24.smethod_30(Class56.memorySignatureScanConfig_165.uint_0, characterAccountConfig_0.int_137);
					for (; k < 6; k++)
					{
						uint num42 = Class24.smethod_30(num41 + Class56.memorySignatureScanConfig_167.uint_0, characterAccountConfig_0.int_137);
						if (num42 != 0)
						{
							uint num43 = Class24.smethod_30(num42 + (uint)(k * 4), characterAccountConfig_0.int_137);
							if (num43 != 0 && Class24.smethod_30(num43, characterAccountConfig_0.int_137) != 0)
							{
								Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_56);
								Thread.Sleep(300);
							}
						}
					}
					int num44 = 0;
					bool flag3 = false;
					byte[] array6 = new byte[20];
					for (int l = 0; l < num20; l++)
					{
						int num45 = Class85.smethod_4(characterAccountConfig_0);
						Class75.smethod_41(characterAccountConfig_0, num39);
						int m;
						for (m = 0; m < 30; m++)
						{
							if (Class85.smethod_4(characterAccountConfig_0) == num45)
							{
								Thread.Sleep(10);
								continue;
							}
							m = -1;
							num44 = 0;
							break;
						}
						if (m == -1)
						{
							continue;
						}
						num44++;
						if (num44 <= 3)
						{
							uint num46 = Class24.smethod_30(num41 + Class56.memorySignatureScanConfig_167.uint_0, characterAccountConfig_0.int_137);
							if (num46 == 0)
							{
								continue;
							}
							uint num47 = Class24.smethod_30(num46, characterAccountConfig_0.int_137);
							if (num47 == 0)
							{
								continue;
							}
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num47, array6, array6.Length, ref int_);
							string text8 = Class1.smethod_3(array6);
							if (text8 != string.Empty)
							{
								if (Class11.smethod_1(text8, "tói kh«ng") > 0 || Class11.smethod_1(text8, "ho¶ng trèng") > 0)
								{
									flag3 = true;
									Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_56);
									break;
								}
								if (Class11.smethod_1(text8, "µng kh") > 0 || (Class11.smethod_1(text8, "iÒn") > 0 && Class11.smethod_1(text8, "kh«ng") > 0))
								{
									goto IL_1482;
								}
							}
							Thread.Sleep(10);
							continue;
						}
						goto IL_12d7;
					}
					goto IL_12e9;
					IL_1394:
					num18 = 0;
					continue;
					IL_0d89:
					if (characterAccountConfig_0.int_70 > 0)
					{
						if (int_2 == 13)
						{
							goto IL_0705;
						}
						if (num4 < 3 && int_2 != 13 && Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0)
						{
							num4++;
							if (Class29.smethod_7(characterAccountConfig_0, 13))
							{
								Class64.smethod_11(characterAccountConfig_0);
								Thread.Sleep(100);
							}
							continue;
						}
					}
					int[] array7 = Class64.smethod_9(int_2);
					if (bool_0 && array7 != null && array7[1] != 0)
					{
						int num48 = 1;
						if (array7 != null)
						{
							num48 = Class64.int_0[array7[0], 0];
						}
						num2 = 1;
						if (num3 < 3 && Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0)
						{
							string string_2 = "t©m";
							if (num13 <= 0)
							{
								if (num48 == 11 || num48 == 176)
								{
									string_2 = "®«ng|§«ng";
								}
							}
							else
							{
								string_2 = null;
							}
							num3++;
							if (Class29.smethod_7(characterAccountConfig_0, num48, string_2))
							{
								Class64.smethod_11(characterAccountConfig_0);
								Thread.Sleep(100);
							}
							continue;
						}
						if (num <= 0)
						{
							num++;
							Class53.smethod_5(characterAccountConfig_0, num48);
							Class64.smethod_11(characterAccountConfig_0);
							Thread.Sleep(100);
							continue;
						}
					}
					goto IL_0705;
					IL_0e7c:
					num25 = 1;
					Class75.smethod_52(characterAccountConfig_0, "* mua miÔn phÝ...");
					int num49 = 0;
					if (Form1.int_134 != null)
					{
						for (int n = 0; n < Form1.int_134.Length; n++)
						{
							if (Form1.int_134[n] > 0)
							{
								Class95.smethod_5(characterAccountConfig_0, Form1.int_134[n] - 1);
								Thread.Sleep(450);
								num49++;
							}
						}
					}
					if (num49 == 0 || 0 <= Class95.smethod_0(characterAccountConfig_0))
					{
						Class95.smethod_5(characterAccountConfig_0, 0);
						Thread.Sleep(450);
					}
					int num50 = 0;
					int num51 = 0;
					int num53;
					for (; num50 < 8; num50++)
					{
						if (Class24.smethod_30(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig_0.int_137) != 0 && !Class47.smethod_3(characterAccountConfig_0))
						{
							if (Form1.int_104 <= 0 && Class11.smethod_9(Class47.smethod_6(characterAccountConfig_0)) != num35)
							{
								int num52 = num35;
								if (num52 <= 0)
								{
									num52 = 99;
								}
								Class47.smethod_5(characterAccountConfig_0, num52.ToString(), bool_0: true);
							}
							else
							{
								Class24.smethod_4(characterAccountConfig_0.uint_4, 13u);
							}
							num51 = 1;
						}
						if (Class85.smethod_4(characterAccountConfig_0) <= num53)
						{
							if (num51 > 0)
							{
								num51++;
								if (num51 > 10)
								{
									break;
								}
							}
							Thread.Sleep(100 + Class95.int_0);
							continue;
						}
						Thread.Sleep(300);
						if (0 <= Class95.smethod_0(characterAccountConfig_0))
						{
							int num54 = Class95.smethod_1(characterAccountConfig_0);
							Class95.smethod_5(characterAccountConfig_0, num54 - 1);
						}
						break;
					}
					if (num15 > 1 || Class85.smethod_4(characterAccountConfig_0) <= num53)
					{
						num14 = 2;
						continue;
					}
					goto IL_1318;
					IL_149e:
					num8 = -6;
					break;
					IL_0705:
					num18 = 0;
					text2 = null;
					uint_ = null;
					num18 = Class3.smethod_15(characterAccountConfig_0, text3, ref uint_, 3, bool_0: false);
					if (num18 > 0)
					{
						text2 = Class3.smethod_16(characterAccountConfig_0, num18, ref uint_, 40);
					}
					else
					{
						if (num33 > 0)
						{
							num8 = 1;
							break;
						}
						if (int_2 == 13)
						{
							uint_ = ((text2 != null && text2 != string.Empty && text2.IndexOf("u Khi") > 0) ? new uint[2] { 61929u, 157207u } : new uint[2] { 62020u, 157428u });
						}
						else if (!flag)
						{
							int num55 = Class44.smethod_2(int_2);
							if (0 <= num55)
							{
								uint_ = Class44.smethod_3(Class44.gstruct21_0[num55], array4, "HIEUTHUOC");
							}
							if (uint_ == null)
							{
								uint_ = Class45.smethod_11(array4, int_2, "HIEUTHUOC");
							}
						}
						else
						{
							uint_ = new uint[2] { 49792u, 97600u };
						}
						if (uint_ == null)
						{
							num8 = -2;
							Class64.smethod_10(characterAccountConfig_0, "Chua dinh nghia NPC map nay.");
							break;
						}
					}
					goto IL_0810;
					IL_1014:
					num22 = 2;
					goto IL_1017;
					IL_1462:
					num8 = -3;
					Class64.smethod_12(characterAccountConfig_0);
					break;
					IL_1482:
					num8 = 1;
					Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_56);
					break;
					IL_1476:
					num8 = -5;
					break;
					IL_12e9:
					if (!flag3 || (num21 <= 0 && characterAccountConfig_0.int_79 > 0 && num15 != 2))
					{
						if (num21 == 0)
						{
							num23 = 1;
						}
						goto IL_1318;
					}
					num8 = 1;
					break;
					IL_0e6c:
					num18 = 0;
					Class64.smethod_12(characterAccountConfig_0);
					continue;
					IL_0810:
					num3 = 0;
					array4 = new uint[2]
					{
						Class24.smethod_30(num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					long num56 = Class64.smethod_18(array4, uint_);
					if (num56 <= 300000L)
					{
						Class13.smethod_2(characterAccountConfig_0, bool_0: false);
						array4 = new uint[2]
						{
							Class24.smethod_30(num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
							Class24.smethod_30(num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
						};
						int num57 = 0;
						while (!Class11.bool_0)
						{
							Class75.smethod_61(characterAccountConfig_0, uint_);
							Thread.Sleep(300);
							array4 = new uint[2]
							{
								Class24.smethod_30(num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
								Class24.smethod_30(num30 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
							};
							if (Class64.smethod_18(array4, uint_) < 22500L)
							{
								break;
							}
							num57++;
							if (num57 <= 15)
							{
								continue;
							}
							goto IL_1462;
						}
						while (num18 > 0)
						{
							if (Class47.smethod_8(characterAccountConfig_0))
							{
								Class47.smethod_11(characterAccountConfig_0);
							}
							Class95.smethod_8(characterAccountConfig_0);
							Class95.Class92.smethod_1(characterAccountConfig_0);
							Thread.Sleep(100);
							Class38.smethod_10(characterAccountConfig_0, (uint)num18);
							Thread.Sleep(150);
							num57 = 0;
							bool flag4 = Class47.smethod_8(characterAccountConfig_0);
							while (true)
							{
								if (Class95.smethod_0(characterAccountConfig_0) < 0 && !flag4)
								{
									num57++;
									Thread.Sleep(100);
									if (Class24.smethod_30(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig_0.int_137) != 0)
									{
										string text9 = Class47.smethod_4(characterAccountConfig_0);
										if (text9.IndexOf("è l\u00adîn") <= 0)
										{
											Class47.smethod_3(characterAccountConfig_0);
										}
										else
										{
											Class47.smethod_3(characterAccountConfig_0, smethod_4(characterAccountConfig_0, num20).ToString());
										}
									}
									if (Class95.Class92.smethod_4(characterAccountConfig_0))
									{
										string text10 = Class95.Class92.smethod_0(characterAccountConfig_0);
										Class95.Class92.smethod_5(characterAccountConfig_0);
										if (text10.IndexOf("h\u00adëng m«n c") > 0 && int_2 == 13)
										{
											break;
										}
									}
									if (flag4 == Class47.smethod_8(characterAccountConfig_0))
									{
										if (num57 < 10)
										{
											continue;
										}
										goto IL_0aa0;
									}
									flag4 = true;
								}
								num5 = 0;
								if (num11 < 3)
								{
									if (characterAccountConfig_0.string_15 != null && characterAccountConfig_0.string_15 != string.Empty)
									{
										uint num58 = Class11.smethod_12(characterAccountConfig_0.string_15);
										if (num58 != 0)
										{
											Class75.smethod_117(characterAccountConfig_0, num58);
											Thread.Sleep(300);
										}
									}
									uint num59 = num27 + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_75.uint_0;
									long num60 = Class24.smethod_30(num59 + Class56.memorySignatureScanConfig_74.uint_0, characterAccountConfig_0.int_137);
									if (num60 > 0L)
									{
										if (Form1.int_67[0] > 0)
										{
											if (num60 > Form1.int_67[1] * 10000)
											{
												num60 = Form1.int_67[1] * 10000;
											}
										}
										else if (num60 > 6000000L)
										{
											num60 = 6000000L;
										}
										Class75.smethod_37(characterAccountConfig_0, (uint)num60);
										Thread.Sleep(300);
									}
									num11 = 3;
								}
								goto IL_0bba;
							}
							goto IL_0e55;
							IL_0bba:
							num53 = Class85.smethod_4(characterAccountConfig_0);
							if (num14 == 1 && 0 <= Class95.smethod_0(characterAccountConfig_0))
							{
								goto IL_0e7c;
							}
							bool flag5 = Class95.smethod_6(characterAccountConfig_0, string_) > 0;
							flag4 = Class47.smethod_8(characterAccountConfig_0);
							if (!flag5 && !flag4)
							{
								if (num19 == 0)
								{
									num19 = 1;
									string string_3 = "Mua M\u00b8u";
									if (Class95.smethod_6(characterAccountConfig_0, string_3) <= 0)
									{
										Class95.smethod_5(characterAccountConfig_0, 0);
									}
									int num61 = 0;
									while (num61 < 10 && !(flag4 = Class47.smethod_8(characterAccountConfig_0)))
									{
										num61++;
										Thread.Sleep(60);
									}
								}
								Class95.smethod_8(characterAccountConfig_0);
							}
							num57 = 0;
							flag4 = Class47.smethod_8(characterAccountConfig_0);
							num53 = Class85.smethod_4(characterAccountConfig_0);
							int num62 = 0;
							while (!flag4)
							{
								num57++;
								if (Class24.smethod_30(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig_0.int_137) != 0)
								{
									string text11 = Class47.smethod_4(characterAccountConfig_0);
									if (text11.IndexOf("è l\u00adîn") <= 0)
									{
										Class47.smethod_3(characterAccountConfig_0);
									}
									else
									{
										Class47.smethod_3(characterAccountConfig_0, smethod_4(characterAccountConfig_0, num20).ToString());
									}
									Thread.Sleep(600);
									num62 = 1;
								}
								Thread.Sleep(100);
								if (Class85.smethod_4(characterAccountConfig_0) <= num53 || num62 <= 0)
								{
									flag4 = Class47.smethod_8(characterAccountConfig_0);
									if (num57 < 10)
									{
										continue;
									}
									goto IL_0d20;
								}
								goto IL_1394;
							}
							goto IL_1014;
							IL_0d20:
							num6++;
							if (num6 == 2)
							{
								goto IL_139c;
							}
							if (num6 <= 3)
							{
								continue;
							}
							goto IL_149e;
							IL_0aa0:
							num5++;
							if (num5 == 2)
							{
								goto IL_0e6c;
							}
							if (num5 <= 3)
							{
								continue;
							}
							goto IL_1476;
						}
						if (num10 == 0)
						{
							num10++;
							goto IL_0d89;
						}
						num8 = -5;
						break;
					}
					Class64.smethod_29(characterAccountConfig_0, bool_0: false);
					if (num9 < 5)
					{
						uint[,] array8 = Class44.smethod_1(int_2, array4, uint_);
						if (array8 != null)
						{
							num9++;
							if (0 <= Class64.smethod_22(characterAccountConfig_0, array8, array4, uint_, int_2, bool_0: false, 16000))
							{
								num9 = 0;
							}
							continue;
						}
					}
					if (!Class13.smethod_3(characterAccountConfig_0) || Class11.smethod_28(long_) > 6000L)
					{
						Class13.smethod_1(characterAccountConfig_0, uint_);
						long_ = Class11.smethod_27();
					}
					continue;
					IL_12d7:
					if (Class85.smethod_25(characterAccountConfig_0) == 0)
					{
						flag3 = true;
						goto IL_12e9;
					}
					array3 = null;
					continue;
					IL_1318:
					Thread.Sleep(150);
					if (num16 <= 0 || characterAccountConfig_0.int_79 <= 0 || num15 >= 2 || text == null || !(text != string.Empty))
					{
						continue;
					}
					num15 = smethod_7(characterAccountConfig_0, text);
					if (num15 != 1)
					{
						num15 = 2;
						if (num21 == 0 && num23 == 1)
						{
							num23 = 2;
						}
					}
				}
				if (num25 > 0 && Form1.int_61 > 0 && Form1.int_63 > 0)
				{
					Class85.smethod_40(characterAccountConfig_0, 0, 0, num25 == 1);
				}
				if (num22 > 0)
				{
					if (Class47.smethod_8(characterAccountConfig_0))
					{
						Class47.smethod_11(characterAccountConfig_0);
					}
					if (characterAccountConfig_0.int_65 > 0)
					{
						bool bool_1 = true;
						Class64.smethod_3(characterAccountConfig_0, ref bool_1);
					}
				}
				if (num12 > 0)
				{
					Class75.smethod_2(characterAccountConfig_0, Class75.uint_32, 0, 4);
					Class75.smethod_52(characterAccountConfig_0, "<color=green><bclr=blue>* KÕt thóc !");
				}
				return num8;
			}
			return 1;
		}
		return 1;
	}

	private static int smethod_6(string[] string_0, string string_1)
	{
		if (string_0 != null && string_1 != null && !(string_1 == string.Empty))
		{
			string[] array = string_1.Split('|');
			for (int i = 0; i < string_0.Length; i++)
			{
				for (int j = 0; j < array.Length; j++)
				{
					if (0 <= Class11.smethod_1(string_0[i], array[j]))
					{
						return i;
					}
				}
			}
			return -1;
		}
		return -1;
	}

	public static int smethod_7(CharacterAccountConfig characterAccountConfig_0, string string_0)
	{
		if (string_0 != null && !(string_0 == string.Empty))
		{
			string[] array = string_0.Split('|');
			int num = 1;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = array[i].ToLower();
				if (num < array[i].Length)
				{
					num = array[i].Length;
				}
			}
			int int_ = 0;
			byte[] array2 = new byte[4];
			byte[] array3 = new byte[num + 4];
			long long_ = Class11.smethod_27();
			uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_97.uint_0;
			uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
			int result = 1;
			uint num4 = 23u;
			int num5 = Class85.smethod_4(characterAccountConfig_0);
			int num6 = 0;
			int num7 = 0;
			for (uint num8 = 1u; num8 < Class56.int_1; num8++)
			{
				if (Class11.smethod_28(long_) > 3000L)
				{
					int num9 = Class87.smethod_3(Form1.characterAccountConfig_1, characterAccountConfig_0.int_136);
					if (num9 < 0 || !Form1.characterAccountConfig_1[num9].bool_25)
					{
						return 0;
					}
					long_ = Class11.smethod_27();
				}
				if (!Class11.bool_0)
				{
					if (num5 <= num6)
					{
						break;
					}
					uint num10 = num2 + num8 * 20;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array2, 4, ref int_);
					uint num11 = BitConverter.ToUInt32(array2, 0);
					if (num11 == 0)
					{
						continue;
					}
					uint num12 = num3 + num11 * Class56.memorySignatureScanConfig_106.uint_0;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_);
					if (BitConverter.ToInt32(array2, 0) != 0)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_107.uint_0, array2, 1, ref int_);
					if (array2[0] == 0)
					{
						continue;
					}
					num6++;
					bool flag = false;
					byte b = array2[0];
					for (int j = 0; j < array.Length; j++)
					{
						if (b == array[j][0] || b + 32 == array[j][0])
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 1, ref int_);
					uint num13 = array2[0];
					if (num13 != 3 && num13 != 1)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_108.uint_0, array2, 1, ref int_);
					if (array2[0] == 0)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_);
					string text = Class1.smethod_3(array3).ToLower();
					flag = false;
					for (int k = 0; k < array.Length; k++)
					{
						if (0 <= text.IndexOf(array[k]))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array2, 1, ref int_);
					uint uint_ = array2[0];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0, array2, 1, ref int_);
					uint uint_2 = array2[0];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_111.uint_0, array2, 1, ref int_);
					uint uint_3 = array2[0];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + Class56.memorySignatureScanConfig_112.uint_0, array2, 1, ref int_);
					uint uint_4 = array2[0];
					uint[] array4 = Class85.smethod_26(characterAccountConfig_0, num4, uint_3, uint_4);
					if (array4 != null)
					{
						result = 1;
						int l;
						for (l = 0; l < 120; l++)
						{
							if (l % 8 == 0)
							{
								Class75.smethod_46(characterAccountConfig_0, uint_, uint_2, num13, array4[0], array4[1], num4);
							}
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 4, ref int_);
							int num14 = BitConverter.ToInt32(array2, 0);
							if (num14 == num13)
							{
								Thread.Sleep(10);
								continue;
							}
							l = -1;
							break;
						}
						if (l == -1)
						{
							num7 = 0;
							continue;
						}
						if (num7 <= 0)
						{
							num7++;
							continue;
						}
						result = -1;
						break;
					}
					result = 2;
					break;
				}
				return 0;
			}
			Thread.Sleep(100);
			Class47.smethod_20(characterAccountConfig_0);
			return result;
		}
		return -1;
	}
}
