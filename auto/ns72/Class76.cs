using System;
using System.Threading;
using ns1;
using ns100;
using ns11;
using ns13;
using ns23;
using ns28;
using ns3;
using ns44;
using ns50;
using ns53;
using ns61;
using ns71;
using ns83;
using ns85;
using ns88;

namespace ns72;

internal class Class76
{
	public static string[] string_0 = null;

	public static void smethod_0(int int_0)
	{
		while (true)
		{
			try
			{
				smethod_1(int_0);
				break;
			}
			catch
			{
			}
		}
	}

	public static void smethod_1(int int_0)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		long long_4 = 0L;
		string text = "V¹n Sù Th«ng";
		uint[] array = new uint[2] { 49893u, 99823u };
		uint[] uint_ = null;
		int int_1 = 0;
		byte[] byte_ = new byte[4];
		byte[] array2 = new byte[4];
		bool flag = false;
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		while (true)
		{
			Thread.Sleep(400);
			num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25 || !Form1.characterAccountConfig_1[num].bool_54)
			{
				break;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num];
			if (flag)
			{
				long num4 = Class11.smethod_28(long_3);
				if (num4 < Form1.int_47 * 1000)
				{
					long num5 = Form1.int_47 - num4 / 1000L;
					if (Class11.smethod_28(long_4) > 1000L)
					{
						bool bool_ = num5 > 3L;
						Class89.smethod_31(characterAccountConfig, num3 + ". Tiep theo con: " + num5 + " giay...", bool_);
						long_4 = Class11.smethod_27();
					}
					continue;
				}
			}
			if (Form1.string_11 != null && !(Form1.string_11 == string.Empty))
			{
				uint num6 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.int_137);
				uint num7 = Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig.int_137);
				uint num8 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig.int_137);
				uint num9 = num8 + num7 * Class56.memorySignatureScanConfig_15.uint_0;
				int num10 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
				int num11 = (int)Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
				int num12 = (int)Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
				int num13 = (int)Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig.int_137);
				int num14 = Class89.smethod_39(characterAccountConfig);
				if (num12 == 10 || num12 == 21 || num13 == 0 || num14 <= 1)
				{
					continue;
				}
				if (num10 != 54)
				{
					if (num10 == 53 || !Class29.smethod_7(characterAccountConfig, "Ba L\u00a8ng huyÖn"))
					{
						if (num11 > 0)
						{
							Class64.smethod_14(characterAccountConfig);
						}
						else
						{
							Class53.smethod_2(characterAccountConfig, "Nam Nh¹c trÊn");
						}
					}
					continue;
				}
				uint[] uint_2 = new uint[2]
				{
					Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
					Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
				};
				long num15 = Class64.smethod_18(uint_2, array);
				if (num15 <= 90000L)
				{
					int num16 = 0;
					do
					{
						if (num15 > 22500L)
						{
							Class75.smethod_61(characterAccountConfig, array);
							Thread.Sleep(300);
							uint_2 = new uint[2]
							{
								Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
								Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
							};
							num15 = Class64.smethod_18(uint_2, array);
							num16++;
							continue;
						}
						if (num2 > 0)
						{
							string text2 = Class3.smethod_16(characterAccountConfig, num2, ref uint_, text.Length + 10);
							if (text2 == null || !Class11.smethod_2(text2, text))
							{
								num2 = 0;
								uint_ = null;
								Class24.WriteProcessMemory(characterAccountConfig.int_137, num9 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_1);
							}
						}
						if (num2 <= 0)
						{
							num2 = Class3.smethod_15(characterAccountConfig, text, ref uint_);
							if (num2 <= 0)
							{
								Class64.smethod_12(characterAccountConfig);
								text = smethod_2(characterAccountConfig);
								break;
							}
						}
						num15 = Class64.smethod_18(uint_2, uint_);
						if (num15 > 22500L)
						{
							Class75.smethod_61(characterAccountConfig, uint_);
							Thread.Sleep(150);
						}
						Class95.smethod_8(characterAccountConfig);
						Class95.Class92.smethod_1(characterAccountConfig);
						Thread.Sleep(100);
						byte[] bytes = BitConverter.GetBytes(num2);
						Class24.WriteProcessMemory(characterAccountConfig.int_137, num9 + Class56.memorySignatureScanConfig_72.uint_0, bytes, 4, ref int_1);
						Thread.Sleep(300);
						int num17 = 0;
						string empty = string.Empty;
						num16 = 0;
						while (true)
						{
							if (!Class11.bool_0)
							{
								Thread.Sleep(100);
								empty = Class95.Class92.smethod_0(characterAccountConfig);
								num17 = Class95.smethod_1(characterAccountConfig);
								if (num17 <= 0)
								{
									if (empty == null || !(empty != string.Empty))
									{
										if (num16 > 15)
										{
											Class64.smethod_12(characterAccountConfig);
											break;
										}
										continue;
									}
									Class24.smethod_4(characterAccountConfig.uint_4, 32u);
									Class75.smethod_37(characterAccountConfig, 20000u);
									Thread.Sleep(300);
									break;
								}
							}
							string text3 = Class95.smethod_2(characterAccountConfig);
							Class95.Class92.smethod_1(characterAccountConfig);
							Class95.smethod_5(characterAccountConfig, characterAccountConfig.int_135);
							Thread.Sleep(300);
							num16 = 0;
							uint num18 = 0u;
							while (num18 == 0 && num16 < 10)
							{
								Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, array2, 4, ref int_1);
								num18 = BitConverter.ToUInt32(array2, 0);
								Thread.Sleep(100);
								num16++;
							}
							empty = Class95.Class92.smethod_0(characterAccountConfig);
							if (!Class11.smethod_2(empty, "chäc ghÑo ta"))
							{
								Class95.Class92.smethod_1(characterAccountConfig);
								Class47.smethod_5(characterAccountConfig, Form1.string_11, bool_0: true);
								num16 = 0;
								string text4 = null;
								while (true)
								{
									if (!Class11.bool_0)
									{
										empty = Class95.Class92.smethod_0(characterAccountConfig);
										text4 = Class95.Class91.smethod_1(characterAccountConfig);
										if (!(empty != string.Empty) && (!(text4 != string.Empty) || !(text4 != text3)))
										{
											num16++;
											Thread.Sleep(100);
											if (num16 > 15)
											{
												Class64.smethod_12(characterAccountConfig);
												break;
											}
											continue;
										}
									}
									string text5 = null;
									string text6 = null;
									string text7 = "|" + Form1.string_11 + "| kh«ng râ tung tÝch n¬i ®©u.";
									try
									{
										int num19 = Class11.smethod_1(text4, "\0");
										if (0 <= num19)
										{
											string text8 = text4.Substring(num19 + 2);
											int num20 = Class11.smethod_1(text8, "\u0003,");
											if (0 > num20)
											{
												if (text8 != null && text8 != string.Empty)
												{
													num16 = 0;
													for (int i = 0; i < text8.Length && text8[i] >= ' ' && text8[i] <= 'ú'; i++)
													{
														num16++;
													}
													if (num16 == 0)
													{
														num16 = text8.Length;
													}
													text6 = "Không rõ vị trí";
													text5 = text8.Substring(0, num16).Trim();
													string_0 = new string[2] { text5, text6 };
												}
											}
											else
											{
												text5 = text8.Substring(0, num20).Trim();
												int num21 = Class11.smethod_1(text8, "(");
												int num22 = Class11.smethod_1(text8, ")");
												if (0 <= num21 && num21 < num22)
												{
													text6 = text8.Substring(num21 + 1, num22 - num21 - 1).Replace(" ", "");
													string_0 = new string[2] { text5, text6 };
												}
											}
										}
									}
									catch
									{
									}
									if (text5 != null && text6 != null)
									{
										text7 = "|" + Form1.string_11 + "| ë (" + text6 + ") " + text5;
									}
									if (Form1.characterAccountConfig_1 != null)
									{
										for (int j = 0; j < Form1.characterAccountConfig_1.Length; j++)
										{
											if (characterAccountConfig.string_22 != Form1.characterAccountConfig_1[j].string_22)
											{
												Class75.smethod_50(characterAccountConfig, Form1.characterAccountConfig_1[j].string_22, text7);
											}
										}
									}
									if (Form1.int_45 > 0)
									{
										Class75.smethod_57(characterAccountConfig, "Chat('CH_TONG', '<color=yellow>" + text7 + "')");
										Thread.Sleep(300);
									}
									if (Form1.int_46 > 0)
									{
										Class75.smethod_57(characterAccountConfig, "Chat('CH_CHATROOM', '" + text7 + "')");
										Thread.Sleep(300);
									}
									num3++;
									long_3 = Class11.smethod_27();
									flag = true;
									break;
								}
							}
							else
							{
								Class24.smethod_4(characterAccountConfig.uint_4, 32u);
								Class75.smethod_37(characterAccountConfig, 20000u);
								Thread.Sleep(300);
							}
							break;
						}
						break;
					}
					while (num16 <= 10);
				}
				else if (Class11.smethod_28(long_2) > 3000L)
				{
					Class13.smethod_1(characterAccountConfig, array);
					long_2 = Class11.smethod_27();
				}
			}
			else
			{
				if (Class11.smethod_28(long_) > 15000L)
				{
					Class75.smethod_52(characterAccountConfig, "<color=yellow>Chua co thiet lap ten ac can tim");
					long_ = Class11.smethod_27();
				}
				Thread.Sleep(150);
			}
		}
		Class75.smethod_52(characterAccountConfig, "<color=green>Ket thuc Van su thong !");
	}

	private static string smethod_2(CharacterAccountConfig characterAccountConfig_0)
	{
		string text = "V¹n";
		uint[] uint_ = new uint[2] { 49893u, 99823u };
		int int_ = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[60];
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
		Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
		Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
		int num5 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
		if (num5 != 54)
		{
			return null;
		}
		Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
		_ = new uint[2]
		{
			Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
			Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
		};
		uint uint_2 = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_2, array, 4, ref int_);
		int num6 = BitConverter.ToInt32(array, 0);
		if (num6 <= 1)
		{
			return null;
		}
		int num7 = 0;
		long num8 = 0L;
		uint[] array3 = new uint[2];
		string text2 = null;
		for (uint num9 = 1u; num9 < 256; num9++)
		{
			if (num6 <= num7)
			{
				break;
			}
			uint num10 = num3 + num9 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			num7++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_52.uint_0, array, 4, ref int_);
			uint num11 = BitConverter.ToUInt32(array, 0);
			if (num11 == 3)
			{
				uint[] array4 = new uint[2];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_);
				array4[0] = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_);
				array4[1] = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_16.uint_0, array2, array2.Length, ref int_);
				string text3 = Class1.smethod_3(array2);
				string string_ = text3.ToLower();
				if (0 <= Class11.smethod_1(string_, text.ToLower()))
				{
					return text3;
				}
				long num12 = Class64.smethod_18(uint_, array4);
				if (num12 < 40000L && (text2 == null || num12 < num8))
				{
					num8 = num12;
					array3[0] = array4[0];
					array3[1] = array4[1];
					text2 = text3;
				}
			}
		}
		return text2;
	}
}
