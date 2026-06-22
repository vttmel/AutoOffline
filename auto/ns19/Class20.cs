using System;
using System.Threading;
using ns10;
using ns100;
using ns11;
using ns23;
using ns28;
using ns3;
using ns34;
using ns50;
using ns53;
using ns56;
using ns61;
using ns63;
using ns71;
using ns83;
using ns85;
using ns88;

namespace ns19;

internal class Class20
{
	private static string string_0;

	public static string[] string_1;

	public static int int_0;

	public static int int_1;

	private static string[] string_2;

	private static Random random_0;

	private static uint[,] uint_0;

	private static uint[,] uint_1;

	private static uint[,] uint_2;

	private static uint[,] uint_3;

	static Class20()
	{
		string_0 = "truyÒn tèng";
		string_1 = new string[4] { "Bất kỳ", "La tiêu sơn", "Vũ di sơn", "Tường vân động" };
		int_0 = Class66.smethod_4("IndexChienlongdong", 0, "0");
		int_1 = -1;
		string_2 = null;
		random_0 = new Random();
		uint[,] array_ = new uint[4, 2];
		Class10.smethod_4(array_, 43953);
		uint_0 = array_;
		uint[,] array_2 = new uint[4, 2];
		Class10.smethod_4(array_2, 43994);
		uint_1 = array_2;
		uint[,] array_3 = new uint[3, 2];
		Class10.smethod_4(array_3, 44035);
		uint_2 = array_3;
		uint[,] array_4 = new uint[3, 2];
		Class10.smethod_4(array_4, 44068);
		uint_3 = array_4;
	}

	public static bool smethod_0(int int_2)
	{
		return int_2 == 959 || int_2 == 991 || int_2 == 990;
	}

	public static int smethod_1(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = false, bool bool_1 = false)
	{
		int result = 0;
		int int_ = characterAccountConfig_0.int_136;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		long long_ = 0L;
		string object_ = string_0.ToUpper();
		string text = "ChiÕn Long|H\u00b8i-Qu¶|H\u00b8i Qu¶ H|L\u00adìng Thñy |nhÆt H¹t-Hoµng|H\u00b8iQu¶";
		int num5 = 0;
		while (true)
		{
			Thread.Sleep(200);
			int num6 = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
			uint num10;
			if (!Class11.bool_0 && num6 >= 0 && Class89.smethod_12(characterAccountConfig_0) <= 0 && Class89.smethod_39(characterAccountConfig_0) > 1)
			{
				if (bool_1 || Form1.int_121 > 0)
				{
					characterAccountConfig_0 = Form1.characterAccountConfig_1[num6];
					if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_48, 4) > 0 || !characterAccountConfig_0.bool_25 || characterAccountConfig_0.int_20[0] > 0 || characterAccountConfig_0.int_133[0] > 0 || characterAccountConfig_0.bool_54 || characterAccountConfig_0.int_25 > 0 || characterAccountConfig_0.bool_15)
					{
						break;
					}
					if (bool_0 || Form1.int_24 == 0)
					{
						uint num7 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
						if (num7 == 0)
						{
							continue;
						}
						uint num8 = Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
						uint num9 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
						if (num9 == 0)
						{
							continue;
						}
						num10 = num9 + num8 * Class56.memorySignatureScanConfig_15.uint_0;
						int num11 = (int)Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
						int num12 = (int)Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
						int num13 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
						int num14 = (int)Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
						if (num11 != 10 && num11 != 21 && num12 != 0 && num11 != 0 && num13 != 0)
						{
							num4 = 0;
							uint[] array = new uint[2]
							{
								Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
								Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
							};
							if (array[0] == 0 || array[1] == 0)
							{
								continue;
							}
							if (!smethod_0(num13))
							{
								if (num14 <= 0)
								{
									string text2 = null;
									if (int_0 != 1)
									{
										if (int_0 != 2)
										{
											if (int_0 == 3)
											{
												text2 = "T\u00adêng V©n|Cæng 3";
											}
										}
										else
										{
											text2 = "Vò Di|Cæng 2";
										}
									}
									else
									{
										text2 = "La Tiªu|Cæng 1";
									}
									if (int_1 < 0)
									{
										int_1 = 0;
										string_2 = null;
										if (Class37.mapNavigationEntry_0 != null)
										{
											for (int i = 0; i < Class37.mapNavigationEntry_0.Length; i++)
											{
												if (!smethod_0(Class37.mapNavigationEntry_0[i].int_0))
												{
													continue;
												}
												int_1 = Class37.mapNavigationEntry_0[i].int_0;
												if (Class37.mapNavigationEntry_0[i].string_2 == null || !(Class37.mapNavigationEntry_0[i].string_2 != string.Empty))
												{
													break;
												}
												string[] array2 = Class37.mapNavigationEntry_0[i].string_2.Split('|');
												string_2 = new string[3];
												for (int j = 0; j < string_2.Length; j++)
												{
													if (j < array2.Length)
													{
														string_2[j] = array2[j];
													}
													else
													{
														string_2[j] = array2[array2.Length - 1];
													}
												}
												break;
											}
										}
									}
									if ((Form1.int_116 <= 0 || Form1.int_117 <= 0) && (num5 < 3 || (Form1.int_116 > 0 && Form1.int_117 == 0)) && int_1 > 0)
									{
										if (string_2 != null)
										{
											if (text2 != null)
											{
												text2 += "|";
											}
											text2 = ((int_0 > 0) ? (text2 + string_2[int_0 - 1]) : (text2 + string_2[random_0.Next(0, 2)]));
										}
										Class29.smethod_7(characterAccountConfig_0, int_1, text2);
										Thread.Sleep(100);
										Class95.smethod_8(characterAccountConfig_0);
										num5++;
									}
									else
									{
										int[] array3 = Class64.smethod_9(num13);
										if (array3 != null && array3[1] != 0)
										{
											Class53.smethod_7(characterAccountConfig_0);
											result = -2;
											break;
										}
										Class53.smethod_2(characterAccountConfig_0, text + "|" + text2);
										Class95.smethod_8(characterAccountConfig_0);
									}
									continue;
								}
							}
							else if (num5 > 0)
							{
								num5 = 0;
							}
							if (smethod_0(num13) && int_0 != 0)
							{
								long num15 = Class64.smethod_21(uint_1, array);
								long num16 = Class64.smethod_21(uint_0, array);
								long num17 = Class64.smethod_21(uint_2, array);
								if ((int_0 != 1 || num17 > num15 || num17 > num16) && (int_0 != 2 || num15 > num17 || num15 > num16) && (int_0 != 3 || num16 > num17 || num16 > num15))
								{
									if (Class11.smethod_28(long_) > 3000L)
									{
										Class75.smethod_52(characterAccountConfig_0, "§ang chän l¹i cæng lªn cl®...");
										long_ = Class11.smethod_27();
									}
									if (Form1.int_116 > 0 && Form1.int_117 == 0 && int_1 > 0)
									{
										string text3 = null;
										if (int_0 != 1)
										{
											if (int_0 != 2)
											{
												if (int_0 == 3)
												{
													text3 = "T\u00adêng V©n|Cæng 3";
												}
											}
											else
											{
												text3 = "Vò Di|Cæng 2";
											}
										}
										else
										{
											text3 = "La Tiªu|Cæng 1";
										}
										if (string_2 != null)
										{
											if (text3 != null)
											{
												text3 += "|";
											}
											text3 = ((int_0 <= 0) ? (text3 + string_2[random_0.Next(0, 2)]) : (text3 + string_2[int_0 - 1]));
										}
										if (Class29.smethod_7(characterAccountConfig_0, int_1, text3 + string_2))
										{
											Class95.smethod_8(characterAccountConfig_0);
											num5++;
										}
										continue;
									}
									uint[,] array4 = null;
									array4 = ((num17 <= num16 && num17 <= num15) ? uint_2 : ((num15 > num16 || num15 > num17) ? uint_0 : uint_1));
									int length = array4.GetLength(0);
									uint[] array5 = new uint[2]
									{
										array4[length - 1, 0],
										array4[length - 1, 1]
									};
									long num18 = Class64.smethod_18(array, array5);
									if (num18 > 90000L)
									{
										num++;
										if (num < 3)
										{
											Class59.smethod_11(characterAccountConfig_0, array4, array5, bool_0: true, 10000);
											continue;
										}
									}
									for (num = 0; num < 10; num++)
									{
										array = new uint[2]
										{
											Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
											Class24.smethod_30(num10 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
										};
										if (Class64.smethod_18(array, array5) <= 11500L)
										{
											break;
										}
										Class75.smethod_61(characterAccountConfig_0, array5);
										Thread.Sleep(300);
									}
									num = 0;
									if (num2 > 0)
									{
										string text4 = Class3.smethod_16(characterAccountConfig_0, num2, ref array5, 32);
										if (text4 != null && 0 <= Class11.smethod_1(text4.ToUpper(), object_))
										{
											goto IL_07e6;
										}
									}
									num2 = Class3.smethod_15(characterAccountConfig_0, string_0, ref array5, 3, bool_0: false);
									if (num2 > 0)
									{
										goto IL_07e6;
									}
									goto IL_0848;
								}
								result = 1;
								break;
							}
							result = 1;
							break;
						}
						if (num12 == 0 || num11 == 0)
						{
							num4++;
							if (num4 < 10)
							{
								Thread.Sleep(100);
								continue;
							}
						}
						result = -1;
						break;
					}
					result = 1;
					break;
				}
				result = -1;
				break;
			}
			result = -1;
			break;
			IL_07e6:
			int int_2 = 0;
			byte[] bytes = BitConverter.GetBytes(num2);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_72.uint_0, bytes, 4, ref int_2);
			Thread.Sleep(100);
			num = 0;
			while (Class95.smethod_0(characterAccountConfig_0) < 0)
			{
				num++;
				Thread.Sleep(100);
				if (num <= 10)
				{
					continue;
				}
				goto IL_0848;
			}
			num = 0;
			Class95.smethod_5(characterAccountConfig_0, 0);
			num2 = 0;
			continue;
			IL_0848:
			num3++;
			Thread.Sleep(100);
			if (num3 > 10)
			{
				Class64.smethod_29(characterAccountConfig_0, bool_0: true);
				Thread.Sleep(300);
				Class75.smethod_57(characterAccountConfig_0, "Switch([[sit]])");
				Thread.Sleep(300);
				num3 = 0;
			}
		}
		return result;
	}

	public static uint[] smethod_2(CharacterAccountConfig characterAccountConfig_0)
	{
		uint[,] array = new uint[4, 2];
		Class10.smethod_4(array, 43708);
		uint[,] array2 = array;
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2;
		Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
		Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
		int num5 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
		if (!smethod_0(num5))
		{
			return null;
		}
		uint[] array3 = new uint[2]
		{
			Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
			Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
		};
		int num6 = Class64.smethod_20(array2, array3);
		if (num6 >= 0)
		{
			uint[] array4 = new uint[2]
			{
				array2[num6, 0],
				array2[num6, 1]
			};
			long num7 = Class64.smethod_18(array3, array4);
			if (num7 <= 90000L)
			{
				long long_ = Class11.smethod_27();
				while (!Class11.bool_0)
				{
					array3 = new uint[2]
					{
						Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					num7 = Class64.smethod_18(array3, array4);
					if (num7 < 22500L)
					{
						break;
					}
					if (Class11.smethod_28(long_) <= 6000L)
					{
						uint num8 = Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
						if (num8 == num5)
						{
							Class75.smethod_61(characterAccountConfig_0, array4);
							Thread.Sleep(300);
							continue;
						}
						return null;
					}
					return null;
				}
				string text = "ruyÒn tèng";
				int num9 = Class3.smethod_13(characterAccountConfig_0, text, 3);
				if (num9 <= 0)
				{
					return null;
				}
				bool flag = false;
				while (true)
				{
					Class95.smethod_8(characterAccountConfig_0);
					Thread.Sleep(100);
					int int_ = 0;
					byte[] bytes = BitConverter.GetBytes(num9);
					Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_72.uint_0, bytes, 4, ref int_);
					Thread.Sleep(100);
					for (int i = 0; i < 10; i++)
					{
						Thread.Sleep(150);
						if (0 <= Class95.smethod_0(characterAccountConfig_0) && Class95.smethod_1(characterAccountConfig_0) > 0)
						{
							Class75.smethod_59(characterAccountConfig_0, 0, 0);
							return null;
						}
					}
					if (flag)
					{
						break;
					}
					flag = true;
				}
				return null;
			}
			return array4;
		}
		return null;
	}
}
