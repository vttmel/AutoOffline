using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ns0;
using ns1;
using ns100;
using ns11;
using ns23;
using ns33;
using ns35;
using ns43;
using ns44;
using ns48;
using ns53;
using ns56;
using ns6;
using ns61;
using ns71;
using ns77;
using ns81;
using ns83;
using ns85;
using ns88;
using ns98;

namespace ns31;

internal class Class32
{
	public class ItemEntity
	{
		public string Name { get; set; }

		public int ItemId { get; set; }

		public int Count { get; set; }

		public uint Slot { get; set; }

		public uint Address { get; set; }
	}

	public static int int_0 = 0;

	public static int int_1 = 0;

	public static string[] string_0 = null;

	public static int int_2 = 0;

	public static int int_3 = 0;

	public static bool smethod_0(int int_4)
	{
		return int_4 == 336 || int_4 == 341 || int_4 == 342 || int_4 == 962 || int_4 == 963 || (337 <= int_4 && int_4 <= 339) || (387 <= int_4 && int_4 <= 395) || (209 <= int_4 && int_4 <= 211) || (849 <= int_4 && int_4 <= 862) || (464 <= int_4 && int_4 <= 471) || (480 <= int_4 && int_4 <= 495) || (926 <= int_4 && int_4 <= 932);
	}

	public static void smethod_1()
	{
		int int_ = int_1;
		int_1 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25)
				{
					if (0 <= num)
					{
						Form1.characterAccountConfig_1[num].bool_33 = false;
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_33)
					{
						break;
					}
					Form1.characterAccountConfig_1[num].bool_33 = true;
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

	public static void smethod_2(int int_4)
	{
		int num = 0;
		int num2 = -1;
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		int num3 = 0;
		int num4 = -1;
		int int_5 = 0;
		byte[] array = new byte[4];
		int num5 = 0;
		int[] array2 = new int[10];
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = 4;
		}
		Random random = new Random();
		int num6 = 0;
		int num7 = random.Next(5000, 20000);
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		long long_4 = 0L;
		while (true)
		{
			num--;
			num6 = random.Next(300, 700);
			Thread.Sleep(300 + num6);
			if (num <= 0)
			{
				num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
				if (Class11.bool_0 || num2 < 0 || !Form1.characterAccountConfig_1[num2].bool_25)
				{
					break;
				}
				num = 3;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num2];
			if (Form1.int_72 > 0 && characterAccountConfig.int_69[0] <= 0 && Class11.smethod_28(long_2) > 30000L)
			{
				string text = Form1.string_24;
				if (Class75.smethod_3(characterAccountConfig, Class75.uint_48, 4) > 0)
				{
					text = Form1.string_49 + " click npc ghÐp nép vËt phÈm event - http: //Mel . c o m";
				}
				else if (Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_10 * 4, array, 1, ref int_5) && int_5 > 0 && array[0] > 0)
				{
					text = Form1.string_49 + " ®ang läc vËt phÈm theo ®iÒu kiÖn - http:// http: //Mel . c o m";
				}
				Class75.smethod_57(characterAccountConfig, "Chat('CH_NEARBY', '" + text + "')");
				long_2 = Class11.smethod_27();
			}
			if (string_0 != null && string_0.Length != 0)
			{
				if (Class11.smethod_28(long_3) < num7)
				{
					num10++;
				}
				else
				{
					num10 = 0;
					num7 = random.Next(5000, 20000);
					long_3 = Class11.smethod_27();
					TcpConnectionEntry[] array3 = Class51.smethod_0(new int[1] { characterAccountConfig.int_136 });
					for (int j = 0; j < string_0.Length; j++)
					{
						if (string_0[j] == null || string_0[j] == string.Empty)
						{
							continue;
						}
						string[] array4 = null;
						string[] array5 = string_0[j].Split('|');
						if (array5[0] != null && array5[0] != string.Empty)
						{
							array4 = array5[0].Split(';', ',', '-');
						}
						bool flag = false;
						if (array4 != null && array3 != null)
						{
							for (int k = 0; k < array3.Length; k++)
							{
								int num11 = 0;
								while (num11 < array4.Length)
								{
									if (!(array4[num11] == array3[k].string_2) || array3[k].string_2 == null || !(array3[k].string_2 != string.Empty))
									{
										num11++;
										continue;
									}
									goto IL_02be;
								}
								continue;
								IL_02be:
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							continue;
						}
						if (array5.Length > 1 && array5[1] != null && array5[1] != string.Empty)
						{
							string text2 = null;
							string[] array6 = array5[1].Split('\u0001');
							if (array6.Length <= num9)
							{
								num9 = 0;
							}
							text2 = array6[num9];
							num9++;
							if (text2 != null && text2.IndexOf("?") > 0)
							{
								string[] array7 = text2.Split(',');
								uint num12 = Class11.smethod_6((Class38.smethod_20(characterAccountConfig) + random.Next(100, 10000)).ToString());
								string text3 = Class11.smethod_16("]ihsJPL_2^iupx,-,%.,.." + Class1.smethod_7(num12.ToString()));
								text2 = array7[0] + "," + num12 + ",'" + text3 + "')";
								byte[] bytes = BitConverter.GetBytes(num12);
								Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_51 * 4, bytes, bytes.Length, ref int_5);
							}
							if (text2 != null && text2 != string.Empty)
							{
								Class75.smethod_57(characterAccountConfig, text2);
								if (num8 == 0)
								{
									Thread.Sleep(600);
									Class75.smethod_52(characterAccountConfig, "-");
									num8 = 1;
								}
							}
						}
						if (array5.Length > 2 && array5[2] != null)
						{
							long num13 = Class11.smethod_37(array5[2]);
							if (num13 > 0L)
							{
								num7 = (int)num13;
							}
						}
						break;
					}
				}
				if (num10 > 10 && Class11.smethod_28(long_4) > 15000L)
				{
					num10 = 0;
					long_3 = 0L;
					long_4 = Class11.smethod_27();
				}
			}
			if (characterAccountConfig.int_115 <= 0 && characterAccountConfig.int_117 <= 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref array2[0]);
			uint num14 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num14 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref array2[1]);
			uint num15 = BitConverter.ToUInt32(array, 0) * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref array2[2]);
			uint num16 = BitConverter.ToUInt32(array, 0);
			uint num17 = num16 + num15;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num17 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref array2[3]);
			int num18 = BitConverter.ToInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num17 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref array2[4]);
			int num19 = BitConverter.ToInt32(array, 0);
			int num20 = Class89.smethod_39(characterAccountConfig);
			if (num18 != 0 && num20 > 1 && num19 != 0 && num19 != 10 && num19 != 21)
			{
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num17 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref array2[5]);
				BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref array2[6]);
				int int_6 = BitConverter.ToInt32(array, 0);
				if (Class11.smethod_28(long_) < 1000L)
				{
					continue;
				}
				num5 = 6;
				int num21 = 0;
				while (true)
				{
					if (num21 <= num5)
					{
						if (array2[num21] == 0)
						{
							break;
						}
						num21++;
						continue;
					}
					int num22 = Class85.smethod_4(characterAccountConfig);
					if (0 <= num4 && num4 <= num22)
					{
						num4 = num22;
						break;
					}
					num4 = num22;
					bool flag2 = false;
					if (characterAccountConfig.int_115 > 0)
					{
						flag2 = smethod_5(characterAccountConfig, 0)[0] <= characterAccountConfig.int_116;
					}
					if (!flag2 && characterAccountConfig.int_117 > 0)
					{
						flag2 = smethod_5(characterAccountConfig, 1)[0] <= characterAccountConfig.int_118;
					}
					if (flag2)
					{
						num3++;
						long_ = Class11.smethod_27();
						if (!smethod_0(int_6) && num3 < 4)
						{
							Class64.smethod_14(characterAccountConfig);
							Thread.Sleep(300);
						}
						else if (!characterAccountConfig.bool_12)
						{
							num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
							if (0 <= num2)
							{
								Form1.characterAccountConfig_1[num2].bool_12 = true;
								characterAccountConfig = Form1.characterAccountConfig_1[num2];
							}
						}
						break;
					}
					num3 = 0;
					if (characterAccountConfig.bool_12)
					{
						num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
						if (0 <= num2)
						{
							Form1.characterAccountConfig_1[num2].bool_12 = false;
							characterAccountConfig = Form1.characterAccountConfig_1[num2];
						}
					}
					break;
				}
			}
			else
			{
				Thread.Sleep(100);
			}
		}
	}

	public static void smethod_3()
	{
		int int_ = int_0;
		int_0 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25)
				{
					if (0 <= num)
					{
						Form1.characterAccountConfig_1[num].bool_35 = false;
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_35)
					{
						break;
					}
					Form1.characterAccountConfig_1[num].bool_35 = true;
					flag = true;
				}
				smethod_4(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	public static void smethod_4(int int_4)
	{
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		long long_4 = 0L;
		long long_5 = 0L;
		long long_6 = 0L;
		long long_7 = 0L;
		long long_8 = 0L;
		long long_9 = 0L;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		long long_10 = 0L;
		bool flag5 = false;
		bool flag6 = false;
		bool flag7 = false;
		bool flag8 = false;
		bool flag9 = false;
		bool flag10 = false;
		bool flag11 = false;
		int num = 0;
		int num2 = 0;
		int num3 = -1;
		int num4 = -1;
		int num5 = -1;
		int int_5 = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		byte[] array3 = new byte[9];
		bool flag12 = false;
		int num6 = 0;
		int num7 = 0;
		int[] array4 = new int[10];
		for (int i = 0; i < array4.Length; i++)
		{
			array4[i] = 4;
		}
		ComboMedicineEntry[] array5 = null;
		byte b = 0;
		while (true)
		{
			num6--;
			Thread.Sleep(100);
			if (Class11.bool_0)
			{
				break;
			}
			if (num6 <= 0)
			{
				num5 = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
				if (num5 < 0 || !Form1.characterAccountConfig_1[num5].bool_25)
				{
					break;
				}
				num6 = 10;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num5];
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref array4[0]);
			uint num8 = BitConverter.ToUInt32(array2, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num8 + Class56.memorySignatureScanConfig_13.uint_0, array2, 4, ref array4[1]);
			uint num9 = BitConverter.ToUInt32(array2, 0) * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array2, 4, ref array4[2]);
			uint num10 = BitConverter.ToUInt32(array2, 0);
			uint num11 = num10 + num9;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num11 + Class56.memorySignatureScanConfig_50.uint_0, array2, 4, ref array4[3]);
			int num12 = BitConverter.ToInt32(array2, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num11 + Class56.memorySignatureScanConfig_55.uint_0, array2, 4, ref array4[4]);
			int num13 = BitConverter.ToInt32(array2, 0);
			int num14 = Class89.smethod_39(characterAccountConfig);
			if (num12 != 0 && num14 > 1 && num13 != 0 && num13 != 10 && num13 != 21)
			{
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array2, 4, ref array4[5]);
				int num15 = BitConverter.ToInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num11 + Class56.memorySignatureScanConfig_43.uint_0, array2, 4, ref array4[6]);
				int num16 = BitConverter.ToInt32(array2, 0);
				num7 = 6;
				int num17 = 0;
				while (true)
				{
					if (num17 <= num7)
					{
						if (array4[num17] == 0)
						{
							break;
						}
						num17++;
						continue;
					}
					if (num3 != num16)
					{
						int num18 = 0;
						while (num16 == 0 && num18 < 30 && num16 != num3)
						{
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num11 + Class56.memorySignatureScanConfig_43.uint_0, array2, 4, ref int_5);
							num16 = BitConverter.ToInt32(array2, 0);
							Thread.Sleep(10);
							num18++;
						}
						if (num3 != num16)
						{
							flag2 = true;
							flag3 = true;
							flag7 = false;
							flag8 = false;
							num3 = num16;
							break;
						}
					}
					if ((flag12 = num != num15) && num15 > 0)
					{
						flag2 = true;
						flag3 = true;
						flag7 = false;
						flag8 = false;
						flag5 = false;
						flag9 = Class6.smethod_0(num15);
						flag10 = Class59.smethod_0(num15) != null;
						flag11 = 0 <= Class59.smethod_2(num15);
						flag6 = smethod_0(num15);
					}
					num = num15;
					if (b == 0)
					{
						Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_51 * 4, array2, 4, ref int_5);
						uint num19 = BitConverter.ToUInt32(array2, 0);
						if (num19 != 0 && characterAccountConfig.uint_14 != 0)
						{
							uint num20 = 349368u;
							Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_14 + 349368, array, 1, ref int_5);
							if (array[0] == 116 || array[0] == 235)
							{
								array[0] = 235;
								Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_14 + num20, array, 1, ref int_5);
								b = 1;
								Class56.string_23 += num19;
							}
						}
					}
					int num21 = -1;
					Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_45 * 4, array3, 9, ref int_5);
					while (true)
					{
						num21++;
						if (num21 > 8)
						{
							break;
						}
						if (array3[num21] == 0)
						{
							continue;
						}
						if (characterAccountConfig.bool_25 && (Combo.int_6 != 0 || num16 != 0) && (Combo.int_5 != 0 || characterAccountConfig.int_136 == Class81.characterAccountConfig_0.int_136))
						{
							int num22 = -1;
							int num23 = 1;
							int num24 = 49 + num21;
							array5 = null;
							if (Class81.characterAccountConfig_0.gstruct44_0 != null)
							{
								for (int j = 0; j < Class81.characterAccountConfig_0.gstruct44_0.Length; j++)
								{
									if (num24 == Class81.characterAccountConfig_0.gstruct44_0[j].int_0)
									{
										num22 = j;
										break;
									}
								}
								if (0 <= num22)
								{
									array5 = Class81.characterAccountConfig_0.gstruct44_0[num22].comboMedicineEntry_0;
								}
							}
							else if (characterAccountConfig.gstruct44_0 != null)
							{
								for (int k = 0; k < characterAccountConfig.gstruct44_0.Length; k++)
								{
									if (num24 == characterAccountConfig.gstruct44_0[k].int_0)
									{
										num22 = k;
										break;
									}
								}
								if (0 <= num22)
								{
									array5 = characterAccountConfig.gstruct44_0[num22].comboMedicineEntry_0;
								}
							}
							if (0 <= num22 && array5 != null)
							{
								if (characterAccountConfig.int_136 != Class81.characterAccountConfig_0.int_136)
								{
									num23 = Combo.int_4;
								}
								for (int l = 0; l < array5.Length; l++)
								{
									int num25 = array5[l].int_0 / num23;
									int num26 = array5[l].int_0 % num23;
									if (num26 > 0)
									{
										num26 = 1;
									}
									smethod_13(characterAccountConfig, array5[l].string_0, num25 + num26, -1, -1);
								}
							}
						}
						array[0] = 0;
						Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_45 * 4 + (uint)num21, array, 1, ref int_5);
					}
					Class24.ReadProcessMemory(characterAccountConfig.int_137, num11 + Class56.memorySignatureScanConfig_45.uint_0, array2, 4, ref array4[0]);
					long num27 = BitConverter.ToInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig.int_137, num11 + Class56.memorySignatureScanConfig_47.uint_0, array2, 4, ref array4[1]);
					long num28 = BitConverter.ToInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig.int_137, num11 + Class56.memorySignatureScanConfig_47.uint_0 + 4, array2, 4, ref array4[2]);
					long num29 = BitConverter.ToInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig.int_137, num11 + Class56.memorySignatureScanConfig_46.uint_0, array2, 4, ref array4[3]);
					long num30 = BitConverter.ToInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig.int_137, num11 + Class56.memorySignatureScanConfig_48.uint_0, array2, 4, ref array4[4]);
					long num31 = BitConverter.ToInt32(array2, 0);
					Class24.ReadProcessMemory(characterAccountConfig.int_137, num11 + Class56.memorySignatureScanConfig_48.uint_0 + 4, array2, 4, ref array4[5]);
					long num32 = BitConverter.ToInt32(array2, 0);
					num7 = 5;
					num17 = 0;
					while (true)
					{
						if (num17 <= num7)
						{
							if (array4[num17] == 0)
							{
								break;
							}
							num17++;
							continue;
						}
						if (num29 > num28 && num29 < 5000000L)
						{
							num28 = num29;
						}
						if (num32 > num31 && num32 < 5000000L)
						{
							num31 = num32;
						}
						if (num16 != 0 && num28 > 0L && num31 > 0L)
						{
							flag = true;
							double num33 = num27 * 100L / num28;
							double num34 = num30 * 100L / num31;
							if (!flag6 && !flag5 && !flag9 && ((characterAccountConfig.int_113[0] > 0 && characterAccountConfig.int_113[1] > 0 && num33 <= (double)characterAccountConfig.int_113[1]) || (characterAccountConfig.int_114[0] > 0 && characterAccountConfig.int_114[1] > 0 && num34 <= (double)characterAccountConfig.int_114[1])) && Class11.smethod_28(long_) > 300L)
							{
								Class64.smethod_14(characterAccountConfig, bool_0: false);
								num2++;
								if (num2 > 3)
								{
									string string_ = Class89.smethod_20(characterAccountConfig);
									if (Class11.smethod_1(string_, "ph\u00b8t huy t\u00b8c dông t¹i") > 0)
									{
										flag5 = true;
										Class89.smethod_21(characterAccountConfig, "0K..");
									}
									num2 = 0;
								}
								long_ = Class11.smethod_27();
							}
							bool flag13 = false;
							bool flag14 = false;
							if (!flag7 && characterAccountConfig.int_110[0] > 0 && num33 <= (double)characterAccountConfig.int_110[1] && characterAccountConfig.string_16 != null && characterAccountConfig.string_16 != string.Empty && characterAccountConfig.int_110[2] <= Class11.smethod_28(long_7))
							{
								flag7 = smethod_13(characterAccountConfig, characterAccountConfig.string_16, characterAccountConfig.int_110[3]) <= 0;
								long_7 = Class11.smethod_27();
							}
							if (!flag8 && characterAccountConfig.int_112[0] > 0 && num34 <= (double)characterAccountConfig.int_112[1] && characterAccountConfig.string_17 != null && characterAccountConfig.string_17 != string.Empty && characterAccountConfig.int_112[2] <= Class11.smethod_28(long_8))
							{
								flag8 = smethod_13(characterAccountConfig, characterAccountConfig.string_17, characterAccountConfig.int_112[3]) <= 0;
								long_8 = Class11.smethod_27();
							}
							if (characterAccountConfig.int_106[0] > 0 && characterAccountConfig.int_106[1] > 0 && num27 <= characterAccountConfig.int_106[1] && characterAccountConfig.int_106[2] <= Class11.smethod_28(long_5))
							{
								bool flag15 = false;
								if (characterAccountConfig.int_108 > 0 && flag3)
								{
									flag15 = (flag3 = smethod_12(characterAccountConfig, 0, characterAccountConfig.int_106[3], bool_0: true) > 0);
								}
								if (!flag15)
								{
									flag13 = smethod_12(characterAccountConfig, 0, characterAccountConfig.int_106[3]) <= 0;
								}
								long_5 = Class11.smethod_27();
							}
							if (characterAccountConfig.int_109[0] > 0 && characterAccountConfig.int_109[1] > 0 && num33 <= (double)characterAccountConfig.int_109[1] && characterAccountConfig.int_109[2] <= Class11.smethod_28(long_3))
							{
								bool flag16 = false;
								if (characterAccountConfig.int_108 > 0 && flag3)
								{
									flag16 = (flag3 = smethod_12(characterAccountConfig, 0, characterAccountConfig.int_109[3], bool_0: true) > 0);
								}
								if (!flag16)
								{
									flag13 = smethod_12(characterAccountConfig, 0, characterAccountConfig.int_109[3]) <= 0;
								}
								long_3 = Class11.smethod_27();
							}
							if (characterAccountConfig.int_107[0] > 0 && characterAccountConfig.int_107[1] > 0 && num30 <= characterAccountConfig.int_107[1] && characterAccountConfig.int_107[2] <= Class11.smethod_28(long_6))
							{
								if (flag2)
								{
									flag2 = smethod_12(characterAccountConfig, 1, characterAccountConfig.int_107[3], bool_0: true) > 0;
								}
								if (!flag2)
								{
									flag14 = smethod_12(characterAccountConfig, 1, characterAccountConfig.int_107[3]) <= 0;
								}
								long_6 = Class11.smethod_27();
							}
							if (characterAccountConfig.int_111[0] > 0 && characterAccountConfig.int_111[1] > 0 && num34 <= (double)characterAccountConfig.int_111[1] && characterAccountConfig.int_111[2] <= Class11.smethod_28(long_4))
							{
								if (flag2)
								{
									flag2 = smethod_12(characterAccountConfig, 1, characterAccountConfig.int_111[3], bool_0: true) > 0;
								}
								if (!flag2)
								{
									flag14 = smethod_12(characterAccountConfig, 1, characterAccountConfig.int_111[3]) <= 0;
								}
								long_4 = Class11.smethod_27();
							}
							if (Form1.int_24 == 0 && characterAccountConfig.int_25 > 0 && characterAccountConfig.int_19 > 0 && num27 <= characterAccountConfig.int_18)
							{
								if (Class46.characterSyncSnapshot_0.int_0 > 0)
								{
									Class75.smethod_50(characterAccountConfig, Class46.characterSyncSnapshot_0.string_0, Class1.smethod_2("Thoát game vì Sinh lực thấp, Thím có thể thiết lập lại trong mục Hậu cần - Phục hồi nhé."));
									Thread.Sleep(600);
								}
								Class75.smethod_57(characterAccountConfig, "ExitGame()");
								Thread.Sleep(100);
								Class24.smethod_53(characterAccountConfig.process_0);
							}
							int num35 = Class85.smethod_4(characterAccountConfig);
							if (num4 != num35)
							{
								num4 = num35;
								flag8 = false;
								flag7 = false;
								flag4 = false;
							}
							if (num16 > 0 && ((flag13 && characterAccountConfig.int_115 > 0) || (flag14 && characterAccountConfig.int_117 > 0)) && !flag9 && !flag10 && !flag11 && Class11.smethod_28(long_2) > 800L)
							{
								if (!flag6 && !flag5)
								{
									Class64.smethod_14(characterAccountConfig, bool_0: false);
								}
								else
								{
									num5 = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
									if (0 <= num5)
									{
										Form1.characterAccountConfig_1[num5].bool_12 = true;
									}
								}
								long_2 = Class11.smethod_27();
							}
							smethod_10(characterAccountConfig, num11, ref long_10);
							if (characterAccountConfig.int_58 <= 0 || num16 <= 0 || flag4 || Class11.smethod_28(long_9) <= Form1.int_130 * 60000L)
							{
								break;
							}
							int num36 = 0;
							for (uint num37 = 0u; num37 < 6; num37++)
							{
								uint num38 = Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_2.uint_0 + Class56.memorySignatureScanConfig_3.uint_0 * num37;
								int num39 = (int)Class24.smethod_30(num11 + num38 + 20, characterAccountConfig.int_137);
								if (num39 == 1)
								{
									num36++;
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num11 + num38, array2, 4, ref int_5);
									int num40 = BitConverter.ToInt32(array2, 0);
									if (num40 == 71)
									{
										num36 = -1;
										break;
									}
								}
							}
							if (num36 != -1 && num36 < 6)
							{
								flag4 = !smethod_14(characterAccountConfig);
							}
							long_9 = Class11.smethod_27();
						}
						else
						{
							if (flag && flag12 && num28 < 100L)
							{
								smethod_12(characterAccountConfig, 0);
							}
							flag = false;
							flag5 = false;
						}
						break;
					}
					break;
				}
			}
			else
			{
				Thread.Sleep(100);
			}
		}
	}

	public static int[] smethod_5(CharacterAccountConfig characterAccountConfig_0, int int_4, bool bool_0 = false)
	{
		int int_5 = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_5);
		uint num = BitConverter.ToUInt32(array2, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_5);
		uint num2 = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		int[] array3 = new int[2];
		int num3 = Class85.smethod_4(characterAccountConfig_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class56.int_1; num5++)
		{
			if (num3 <= num4)
			{
				break;
			}
			uint num6 = num2 + num5 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array2, 4, ref int_5);
			uint num7 = BitConverter.ToUInt32(array2, 0);
			if (num7 == 0)
			{
				continue;
			}
			uint num8 = num + num7 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8, array2, 4, ref int_5);
			if (BitConverter.ToInt32(array2, 0) == 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_5);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_5);
			if (array[0] == 0)
			{
				continue;
			}
			num4++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_5);
			int num9 = array[0];
			if (num9 != 3)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_111.uint_0, array, 1, ref int_5);
			int num10 = array[0];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_112.uint_0, array, 1, ref int_5);
			int num11 = array[0];
			array3[1] += num11 * num10;
			if (num10 != 1 || num11 != 1)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_5);
			if (array[0] != 1)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_110.uint_0, array2, 4, ref int_5);
			int num12 = BitConverter.ToInt32(array2, 0);
			if (num12 == int_4 || (!bool_0 && num12 > 0 && (num12 % 2 == 0 || num12 == 9)))
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_119.uint_0, array2, 4, ref int_5);
				int num13 = BitConverter.ToInt32(array2, 0);
				if (num13 <= 0)
				{
					num13 = 1;
				}
				array3[0] += num13;
			}
		}
		return array3;
	}

	public static int[] smethod_6(CharacterAccountConfig characterAccountConfig_0, string string_1)
	{
		int[] array = new int[2];
		if (string_1 != null && !(string_1 == string.Empty))
		{
			int int_ = 0;
			int num = 4 + string_1.Length;
			byte[] array2 = new byte[1];
			byte[] array3 = new byte[4];
			byte[] byte_ = new byte[num];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array3, 4, ref int_);
			uint num2 = BitConverter.ToUInt32(array3, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref int_);
			uint num3 = BitConverter.ToUInt32(array3, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			int num4 = Class85.smethod_4(characterAccountConfig_0);
			int num5 = 0;
			for (uint num6 = 1u; num6 < Class56.int_1; num6++)
			{
				if (num4 <= num5)
				{
					break;
				}
				uint num7 = num3 + num6 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array3, 4, ref int_);
				uint num8 = BitConverter.ToUInt32(array3, 0);
				if (num8 == 0)
				{
					continue;
				}
				uint num9 = num2 + num8 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9, array3, 4, ref int_);
				if (BitConverter.ToInt32(array3, 0) == 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array3, 4, ref int_);
				if (BitConverter.ToInt32(array3, 0) != 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_107.uint_0, array2, 1, ref int_);
				if (array2[0] == 0)
				{
					continue;
				}
				num5++;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 1, ref int_);
				int num10 = array2[0];
				if (num10 != 3)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_111.uint_0, array2, 1, ref int_);
				int num11 = array2[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_112.uint_0, array2, 1, ref int_);
				int num12 = array2[0];
				array[1] += num12 * num11;
				if (num11 != 1 || num12 != 1)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_107.uint_0, byte_, num, ref int_);
				string text = Class1.smethod_3(byte_);
				if (!(text != string_1))
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_119.uint_0, array3, 4, ref int_);
					int num13 = BitConverter.ToInt32(array3, 0);
					if (num13 <= 0)
					{
						num13 = 1;
					}
					array[0] += num13;
				}
			}
			return array;
		}
		return array;
	}

	public static List<ItemEntity> smethod_7(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[80];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		List<ItemEntity> list = new List<ItemEntity>();
		for (uint num3 = 1u; num3 < Class56.int_1; num3++)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (num3 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array, 4, ref int_);
			uint num4 = BitConverter.ToUInt32(array, 0);
			if (num4 == 0 || int_ != 4)
			{
				continue;
			}
			uint num5 = num + num4 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_110.uint_0, array, 4, ref int_);
			if (int_ == 4)
			{
				int itemId = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_119.uint_0, array, 4, ref int_);
				int count = ((int_ != 4) ? 1 : BitConverter.ToInt32(array, 0));
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_107.uint_0, array2, array2.Length, ref int_);
				string itemName = Class1.smethod_3(array2).Trim();
				if (!string.IsNullOrEmpty(itemName) && !list.Any((ItemEntity x) => string.Equals(x.Name, itemName, StringComparison.OrdinalIgnoreCase)))
				{
					list.Add(new ItemEntity
					{
						Name = itemName,
						ItemId = itemId,
						Count = count,
						Slot = num3,
						Address = num5
					});
				}
			}
		}
		return list;
	}

	public static int smethod_8(CharacterAccountConfig characterAccountConfig_0, int int_4)
	{
		int int_5 = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_5);
		uint num = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_5);
		uint num2 = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		int num3 = 0;
		for (uint num4 = 1u; num4 < Class56.int_1; num4++)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (num4 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array, 4, ref int_5);
			uint num5 = BitConverter.ToUInt32(array, 0);
			if (num5 == 0 || int_5 != 4)
			{
				continue;
			}
			uint num6 = num + num5 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_110.uint_0, array, 4, ref int_5);
			if (int_5 != 4)
			{
				continue;
			}
			int num7 = BitConverter.ToInt32(array, 0);
			Console.WriteLine($"Found item ID: {num7} at slot {num4}");
			if (num7 == int_4)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_119.uint_0, array, 4, ref int_5);
				if (int_5 == 4)
				{
					num3++;
				}
			}
		}
		return num3;
	}

	public static int smethod_9(CharacterAccountConfig characterAccountConfig_0, string string_1)
	{
		int int_ = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		byte[] array3 = new byte[80];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_);
		uint num = BitConverter.ToUInt32(array2, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		int num3 = 0;
		for (uint num4 = 1u; num4 < Class56.int_1; num4++)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (num4 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_);
			uint num5 = BitConverter.ToUInt32(array2, 0);
			if (num5 == 0 || int_ != 4)
			{
				continue;
			}
			uint num6 = num + num5 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_);
			string text = Class1.smethod_1(Class1.smethod_3(array3).Trim(), 1);
			if (!string.IsNullOrEmpty(text) && text.Equals(string_1, StringComparison.OrdinalIgnoreCase))
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_119.uint_0, array2, 4, ref int_);
				if (int_ == 4)
				{
					int val = BitConverter.ToInt32(array2, 0);
					num3 += Math.Max(1, val);
				}
			}
		}
		return num3;
	}

	private static void smethod_10(CharacterAccountConfig characterAccountConfig_0, uint uint_0, ref long long_0)
	{
		if (characterAccountConfig_0.int_74[0] <= 0)
		{
			return;
		}
		if (long_0 > 0L)
		{
			long num = Class11.smethod_28(long_0);
			if (num >= characterAccountConfig_0.int_74[1] && Class0.smethod_0(characterAccountConfig_0, uint_0))
			{
				int num2 = characterAccountConfig_0.int_74[2];
				if (num2 < 1)
				{
					num2 = 1;
				}
				if (smethod_11(characterAccountConfig_0, num2))
				{
					long_0 = Class11.smethod_27();
				}
			}
		}
		else
		{
			long_0 = Class11.smethod_27();
		}
	}

	private static bool smethod_11(CharacterAccountConfig characterAccountConfig_0, int int_4)
	{
		try
		{
			int int_5 = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[1];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_5);
			uint num = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_5);
			uint num2 = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			int num3 = Class85.smethod_4(characterAccountConfig_0);
			int num4 = 0;
			for (uint num5 = 1u; num5 < Class56.int_1; num5++)
			{
				if (num4 >= int_4)
				{
					break;
				}
				if (num5 > num3)
				{
					break;
				}
				uint num6 = num2 + num5 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array, 4, ref int_5);
				uint num7 = BitConverter.ToUInt32(array, 0);
				if (num7 == 0 || int_5 != 4)
				{
					continue;
				}
				uint num8 = num + num7 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_5);
				if (BitConverter.ToInt32(array, 0) != 0 || int_5 != 4)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 1, ref int_5);
				int num9 = array2[0];
				if (num9 != 3 || int_5 == 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_110.uint_0, array, 4, ref int_5);
				if (int_5 != 4)
				{
					continue;
				}
				int num10 = BitConverter.ToInt32(array, 0);
				if (num10 == 4)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array2, 1, ref int_5);
					int num11 = array2[0];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_100.uint_0, array2, 1, ref int_5);
					int num12 = array2[0];
					Class75.smethod_43(characterAccountConfig_0, num7, num11, num12, num9);
					num4++;
					if (num4 < int_4)
					{
						Thread.Sleep(1);
					}
				}
			}
			return num4 > 0;
		}
		catch
		{
			return false;
		}
	}

	public static int smethod_12(CharacterAccountConfig characterAccountConfig_0, int int_4, int int_5 = 1, bool bool_0 = false)
	{
		int num = 0;
		uint num2 = 1u;
		int int_6 = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_6);
		uint num3 = BitConverter.ToUInt32(array2, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_6);
		uint num4 = BitConverter.ToUInt32(array2, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		while (true)
		{
			int num5 = Class85.smethod_4(characterAccountConfig_0);
			int num6 = 0;
			uint num7 = num2;
			int num17;
			while (true)
			{
				if (num7 < Class56.int_1 && num5 > num6)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + (num7 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array2, 4, ref int_6);
					uint num8 = BitConverter.ToUInt32(array2, 0);
					if (num8 == 0 || int_6 != 4)
					{
						goto IL_02e5;
					}
					uint num9 = num3 + num8 * Class56.memorySignatureScanConfig_106.uint_0;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_6);
					if (BitConverter.ToInt32(array2, 0) != 0 || int_6 != 4)
					{
						goto IL_02e5;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_6);
					if (array[0] == 0 || int_6 == 0)
					{
						goto IL_02e5;
					}
					num6++;
					uint num10 = num4 + num7 * 20;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_6);
					int num11 = array[0];
					if (num11 != 3 || int_6 == 0)
					{
						goto IL_02e5;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_6);
					if (array[0] != 1 || int_6 == 0)
					{
						goto IL_02e5;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_110.uint_0, array2, 4, ref int_6);
					if (int_6 != 4)
					{
						goto IL_02e5;
					}
					int num12 = BitConverter.ToInt32(array2, 0);
					if (num12 == 4 || (num12 != int_4 && (bool_0 || num12 <= 0 || (num12 % 2 != 0 && num12 != 9))))
					{
						goto IL_02e5;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_111.uint_0, array, 1, ref int_6);
					int num13 = array[0];
					if (num13 != 1 || int_6 == 0)
					{
						goto IL_02e5;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_112.uint_0, array, 1, ref int_6);
					int num14 = array[0];
					if (num14 != 1 || int_6 == 0)
					{
						goto IL_02e5;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_6);
					int num15 = array[0];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_6);
					int num16 = array[0];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_119.uint_0, array2, 4, ref int_6);
					num17 = BitConverter.ToInt32(array2, 0);
					if (int_6 != 4)
					{
						goto IL_02e5;
					}
					Class75.smethod_43(characterAccountConfig_0, num8, num15, num16, num11);
					num++;
					if (num < int_5)
					{
						break;
					}
				}
				return num;
				IL_02e5:
				num7++;
			}
			num2 = num7 + Convert.ToByte(num17 <= 0);
		}
	}

	public static int smethod_13(CharacterAccountConfig characterAccountConfig_0, string string_1, int int_4 = 1, int int_5 = -1, int int_6 = 1)
	{
		if (string_1 != null && !(string_1 == string.Empty))
		{
			int num = 0;
			uint num2 = 1u;
			int int_7 = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[1];
			int num3 = string_1.Length + 3;
			byte[] byte_ = new byte[num3];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_7);
			uint num4 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_7);
			uint num5 = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			while (true)
			{
				int num6 = Class85.smethod_4(characterAccountConfig_0);
				int num7 = 0;
				uint num8 = num2;
				int num17;
				while (true)
				{
					if (num8 < Class56.int_1 && num6 > num7)
					{
						uint num9 = num5 + num8 * 20;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array, 4, ref int_7);
						uint num10 = BitConverter.ToUInt32(array, 0);
						if (num10 == 0 || int_7 != 4)
						{
							goto IL_02af;
						}
						uint num11 = num4 + num10 * Class56.memorySignatureScanConfig_106.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_7);
						if (BitConverter.ToInt32(array, 0) != 0 || int_7 != 4)
						{
							goto IL_02af;
						}
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_107.uint_0, array2, 1, ref int_7);
						if (array2[0] == 0 || int_7 == 0)
						{
							goto IL_02af;
						}
						num7++;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 1, ref int_7);
						int num12 = array2[0];
						if (num12 != 3 || int_7 == 0)
						{
							goto IL_02af;
						}
						if (int_6 > 0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_111.uint_0, array2, 1, ref int_7);
							int num13 = array2[0];
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_112.uint_0, array2, 1, ref int_7);
							int num14 = array2[0];
							if (num13 * num14 != int_6)
							{
								goto IL_02af;
							}
						}
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_107.uint_0, byte_, num3, ref int_7);
						string text = Class1.smethod_3(byte_);
						if (text != string_1 || int_7 == 0)
						{
							goto IL_02af;
						}
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array2, 1, ref int_7);
						int num15 = array2[0];
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_100.uint_0, array2, 1, ref int_7);
						int num16 = array2[0];
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num11 + Class56.memorySignatureScanConfig_119.uint_0, array, 4, ref int_7);
						if (int_7 != 4)
						{
							goto IL_02af;
						}
						num17 = BitConverter.ToInt32(array, 0);
						Class75.smethod_43(characterAccountConfig_0, num10, num15, num16, num12);
						num++;
						if (num < int_4)
						{
							break;
						}
					}
					return num;
					IL_02af:
					num8++;
				}
				num2 = num8 + Convert.ToByte(num17 <= 0);
			}
		}
		return 1;
	}

	public static bool smethod_14(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		string text = "Tiªn Th¶o Lé".ToLower();
		byte[] array2 = new byte[text.Length + 3];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_97.uint_0;
		int num3 = Class85.smethod_4(characterAccountConfig_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class56.int_1; num5++)
		{
			if (num3 <= num4)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (num5 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array, 4, ref int_);
			uint num6 = BitConverter.ToUInt32(array, 0);
			if (num6 == 0)
			{
				continue;
			}
			uint num7 = num + num6 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_);
			if (BitConverter.ToInt32(array, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			num4++;
			uint num8 = num2 + num5 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
			int num9 = array[0];
			if (num9 == 3)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_107.uint_0, array2, array2.Length, ref int_);
				string string_ = Class1.smethod_3(array2).Replace("Ù", string.Empty).ToLower();
				if (Class11.smethod_1(string_, text) >= 0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_);
					int num10 = array[0];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num8 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_);
					int num11 = array[0];
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num7 + Class56.memorySignatureScanConfig_119.uint_0, array, 4, ref int_);
					BitConverter.ToInt32(array, 0);
					Class75.smethod_43(characterAccountConfig_0, num6, num10, num11, num9);
					return true;
				}
			}
		}
		return false;
	}

	public static void smethod_15(CharacterAccountConfig characterAccountConfig_0)
	{
		try
		{
			smethod_16(characterAccountConfig_0);
		}
		catch
		{
		}
	}

	private static void smethod_16(CharacterAccountConfig characterAccountConfig_0)
	{
		int num = 0;
		string[] array = new string[3] { characterAccountConfig_0.string_11, characterAccountConfig_0.string_12, characterAccountConfig_0.string_13 };
		int int_ = 0;
		byte[] array2 = new byte[80];
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i];
			if (text == null || text == string.Empty)
			{
				continue;
			}
			text = array[i].Trim();
			string object_ = Class1.smethod_1(array[i], 1).ToUpper();
			if (characterAccountConfig_0.int_75.Length <= i + 1)
			{
				continue;
			}
			uint num3 = (uint)characterAccountConfig_0.int_75[i + 1];
			if (num3 == 0 || num3 > 9)
			{
				continue;
			}
			bool flag = false;
			for (int j = 0; j < 9; j++)
			{
				uint num4 = Class47.smethod_7(characterAccountConfig_0, j);
				if (num4 != 0)
				{
					uint num5 = num2 + num4 * Class56.memorySignatureScanConfig_106.uint_0;
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_107.uint_0, array2, array2.Length, ref int_);
					string string_ = Class1.smethod_3(array2);
					string string_2 = Class1.smethod_1(string_, 1);
					if (0 <= Class11.smethod_1(string_, text) || 0 <= Class11.smethod_1(string_2, object_))
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				continue;
			}
			uint num6 = Class85.smethod_30(characterAccountConfig_0, text);
			if (num6 == 0)
			{
				if (num <= 0)
				{
					num = 60;
				}
				continue;
			}
			num = 300;
			uint uint_ = Class85.smethod_1(characterAccountConfig_0, num6);
			uint num7 = Class85.smethod_6(characterAccountConfig_0, uint_);
			uint num8 = Class85.smethod_7(characterAccountConfig_0, uint_);
			bool flag2 = true;
			int num9 = 0;
			while (true)
			{
				if (!Class11.bool_0)
				{
					if ((int)Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_0.int_137) > 0)
					{
						break;
					}
					if (num9 % 30 == 0)
					{
						Class75.smethod_46(characterAccountConfig_0, num7, num8, 3u, num7, num8, 3u);
					}
					Thread.Sleep(3);
					num9++;
					if (num9 > 300)
					{
						flag2 = false;
						break;
					}
					continue;
				}
				return;
			}
			if (!flag2)
			{
				continue;
			}
			num9 = 0;
			num3--;
			while (true)
			{
				if (!Class11.bool_0)
				{
					if ((int)Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_0.int_137) <= 0)
					{
						break;
					}
					if (num9 % 30 == 0)
					{
						Class75.smethod_46(characterAccountConfig_0, num3, 0u, 7u, num3, 0u, 7u);
					}
					Thread.Sleep(3);
					num9++;
					if (num9 > 300)
					{
						flag2 = false;
						break;
					}
					continue;
				}
				return;
			}
			if (!flag2)
			{
				Class75.smethod_46(characterAccountConfig_0, num7, num8, 3u, num7, num8, 3u);
			}
		}
	}

	private static void smethod_17(CharacterAccountConfig characterAccountConfig_0)
	{
		int num = 0;
		int int_ = 0;
		byte[] byte_ = new byte[4];
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num5 = num4 + num3 * Class56.memorySignatureScanConfig_15.uint_0;
		int num6 = 0;
		while (num6 < 300 && num < 1000)
		{
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_178.uint_0, byte_, 4, ref int_);
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_);
			num6 = ((Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137) < 3) ? (num6 + 1) : 0);
			num++;
			Thread.Sleep(1);
		}
		Thread.Sleep(100);
	}

	private static void smethod_18(CharacterAccountConfig characterAccountConfig_0, int int_4)
	{
		uint num = 0u;
		int num2 = 0;
		do
		{
			if (num == 0)
			{
				num = Class24.smethod_30(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_158.uint_0, characterAccountConfig_0.int_137);
				Thread.Sleep(1);
				num2++;
				continue;
			}
			int num3 = -1;
			long long_ = Class11.smethod_27();
			while (Class11.smethod_28(long_) <= int_4)
			{
				Thread.Sleep(100);
				num = Class24.smethod_30(characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_158.uint_0, characterAccountConfig_0.int_137);
				int num4 = (int)Class24.smethod_30(num + Class56.memorySignatureScanConfig_159.uint_0, characterAccountConfig_0.int_137);
				if (num4 > 1)
				{
					if (num3 < 0 && num4 > 100)
					{
						break;
					}
					num3 = 0;
				}
				else
				{
					num3++;
					if (num3 > 3)
					{
						break;
					}
				}
			}
			break;
		}
		while (num2 <= 300);
	}

	public static void smethod_19()
	{
		int int_ = int_2;
		int_2 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25)
				{
					if (0 <= num)
					{
						Form1.characterAccountConfig_1[num].bool_29 = false;
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_29)
					{
						break;
					}
					Form1.characterAccountConfig_1[num].bool_29 = true;
					flag = true;
				}
				smethod_20(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_20(int int_4)
	{
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		long[] array = null;
		long[] array2 = null;
		long[] array3 = null;
		bool[] array4 = null;
		int[] array5 = null;
		int[] array6 = null;
		int[] array7 = null;
		byte[] array8 = new byte[4];
		int int_5 = 0;
		int num = 0;
		int num2 = 300;
		int num3 = -1;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		long long_ = 0L;
		while (true)
		{
			IL_0a7a:
			Thread.Sleep(100 + num2);
			num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25)
			{
				break;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num];
			num2 = 300;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array8, 4, ref int_5);
			if (int_5 != 4)
			{
				continue;
			}
			uint num9 = BitConverter.ToUInt32(array8, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num9 + Class56.memorySignatureScanConfig_13.uint_0, array8, 4, ref int_5);
			uint num10 = BitConverter.ToUInt32(array8, 0);
			uint num11 = num10 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array8, 4, ref int_5);
			if (int_5 != 4)
			{
				continue;
			}
			uint num12 = BitConverter.ToUInt32(array8, 0);
			uint num13 = num12 + num11;
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num13 + Class56.memorySignatureScanConfig_43.uint_0, array8, 4, ref int_5);
			int num14 = BitConverter.ToInt32(array8, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num13 + Class56.memorySignatureScanConfig_55.uint_0, array8, 4, ref int_5);
			int num15 = BitConverter.ToInt32(array8, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, num13 + Class56.memorySignatureScanConfig_50.uint_0, array8, 4, ref int_5);
			int num16 = BitConverter.ToInt32(array8, 0);
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array8, 4, ref int_5);
			int num17 = BitConverter.ToInt32(array8, 0);
			int num18 = Class89.smethod_39(characterAccountConfig);
			GStruct36 gStruct;
			bool flag2;
			int num25;
			int num24;
			if (num16 != 0 && num15 != 0 && num18 > 1 && num17 != 0)
			{
				if (num14 <= 0 || num7 != num17)
				{
					num7 = num17;
					num8 = 0;
				}
				if (num14 > 0 && characterAccountConfig.int_131[0] > 0 && characterAccountConfig.int_136 != Class46.characterSyncSnapshot_0.int_0 && Class75.smethod_3(characterAccountConfig, Class75.uint_31, 4) == 1)
				{
					bool flag = false;
					int num19 = Class85.smethod_4(characterAccountConfig);
					for (int i = 0; i < Class56.string_25.GetLength(0); i++)
					{
						for (int j = 0; j < Class56.string_25.GetLength(1); j++)
						{
							if (Class56.string_25[i, j] != null)
							{
								uint num20 = Class85.smethod_30(characterAccountConfig, Class56.string_25[i, j], bool_3: false, 3u, bool_4: true);
								if (num20 != 0)
								{
									Class75.smethod_103(characterAccountConfig, num20);
									flag = true;
									Thread.Sleep(300);
									break;
								}
							}
						}
					}
					Class75.smethod_2(characterAccountConfig, Class75.uint_31, 2, 4);
					if (flag && Form1.int_32 > 0 && num8 < 4 && (num17 == 336 || !smethod_0(num17)))
					{
						int num21 = 0;
						while (num21 < 8)
						{
							Thread.Sleep(150);
							if (Class85.smethod_4(characterAccountConfig) < num19)
							{
								break;
							}
							num15 = (int)Class24.smethod_30(num13 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
							num14 = (int)Class24.smethod_30(num13 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
							if (num15 != 10 && num15 != 21 && num14 != 0)
							{
								num21++;
								continue;
							}
							goto IL_0a7a;
						}
						num8++;
						Class64.smethod_14(characterAccountConfig);
					}
				}
				if (num15 == 10 || num15 == 21)
				{
					continue;
				}
				if (num5 > 0)
				{
					num5--;
					if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) != 0)
					{
						Class24.smethod_4(characterAccountConfig.uint_4, 13u);
						Thread.Sleep(10);
					}
					if (num5 == 0)
					{
						Class95.smethod_8(characterAccountConfig);
					}
				}
				if (num6 < 10 && Class75.smethod_3(characterAccountConfig, Class75.uint_5, 4) > 0)
				{
					num6++;
					Thread.Sleep(10);
					continue;
				}
				num6 = 0;
				if (characterAccountConfig.gstruct36_0 == null)
				{
					continue;
				}
				if (num3 != characterAccountConfig.gstruct36_0.Length)
				{
					num3 = characterAccountConfig.gstruct36_0.Length;
					if (num3 == 0)
					{
						continue;
					}
					array = new long[num3];
					array2 = new long[num3];
					array3 = new long[num3];
					array5 = new int[num3];
					array4 = new bool[num3];
					array6 = new int[num3];
					array7 = new int[num3];
				}
				for (int k = 0; k < num3; k++)
				{
					if (characterAccountConfig.gstruct36_0[k].int_5 > 0)
					{
						num2 = 0;
						break;
					}
				}
				if (num3 <= num4)
				{
					num4 = 0;
				}
				gStruct = characterAccountConfig.gstruct36_0[num4];
				flag2 = gStruct.int_8 > 0 && gStruct.int_9 != null;
				int num22 = Class85.smethod_4(characterAccountConfig);
				int num23 = 0;
				num24 = 0;
				num25 = 0;
				int num26 = 0;
				int num27 = 0;
				int num28 = 400;
				if (Form1.int_75 > 0)
				{
					num28 = 900;
				}
				if (Form1.int_17 <= 0 || num14 > 0)
				{
					if (gStruct.int_5 > 0 && ((!array4[num4] && array5[num4] != num22) || Class11.smethod_28(array[num4]) >= 1000L))
					{
						array[num4] = Class11.smethod_27();
						array4[num4] = false;
						int[] array9 = null;
						array9 = ((gStruct.int_0 <= 0) ? smethod_5(characterAccountConfig, 2) : smethod_6(characterAccountConfig, gStruct.string_1));
						if (gStruct.int_6 >= array9[0])
						{
							if (array9[1] <= 59)
							{
								while (Class64.smethod_17(characterAccountConfig, gStruct.string_0))
								{
									if (num5 <= 0)
									{
										num5 = 8;
									}
									num23 = 0;
									num22 = Class85.smethod_4(characterAccountConfig);
									while (num23 < num28)
									{
										int num29 = Class85.smethod_4(characterAccountConfig);
										if (num29 <= num22 && gStruct.int_7 != 0 && (!flag2 || 0 > Class95.smethod_0(characterAccountConfig)))
										{
											if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) != 0)
											{
												break;
											}
											Thread.Sleep(1);
											num23++;
											continue;
										}
										goto IL_09e2;
									}
									num24 = 0;
									if (Class47.smethod_5(characterAccountConfig, Form1.int_16.ToString(), bool_0: true) <= 0)
									{
										int num30 = Class85.smethod_4(characterAccountConfig);
										if (num30 <= num22)
										{
											if (num26 == 0)
											{
												num26++;
												continue;
											}
											goto IL_0701;
										}
									}
									goto IL_09e2;
								}
								array4[num4] = Class85.smethod_31(characterAccountConfig, gStruct.string_0) <= 0;
								if (array4[num4] && Form1.int_33 > 0 && Class11.smethod_28(long_) > 30000L)
								{
									Class36.smethod_1(characterAccountConfig);
									long_ = Class11.smethod_27();
								}
								goto IL_0a6b;
							}
							array5[num4] = num22;
							continue;
						}
						array5[num4] = num22;
					}
					if (array2[num4] == 0L)
					{
						array2[num4] = Class11.smethod_27();
					}
					if (gStruct.int_1 <= 0)
					{
						array2[num4] = Class11.smethod_27();
					}
					else if (Class11.smethod_28(array2[num4]) >= gStruct.int_4)
					{
						array2[num4] = Class11.smethod_27();
						while (Class64.smethod_17(characterAccountConfig, gStruct.string_0))
						{
							if (num5 <= 0)
							{
								num5 = 8;
							}
							num23 = 0;
							num22 = Class85.smethod_4(characterAccountConfig);
							while (num23 < num28)
							{
								int num31 = Class85.smethod_4(characterAccountConfig);
								if (num31 <= num22 && gStruct.int_7 != 0 && (!flag2 || 0 > Class95.smethod_0(characterAccountConfig)))
								{
									if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) != 0)
									{
										break;
									}
									Thread.Sleep(1);
									num23++;
									continue;
								}
								goto IL_09e2;
							}
							num24 = 0;
							if (Class47.smethod_5(characterAccountConfig, Form1.int_16.ToString(), bool_0: true) <= 0)
							{
								int num32 = Class85.smethod_4(characterAccountConfig);
								if (num32 <= num22)
								{
									if (num27 == 0)
									{
										num27++;
										continue;
									}
									num24 = Class64.smethod_27(characterAccountConfig, gStruct.string_0, Form1.int_16, bool_0: true);
									if (num24 <= 0)
									{
										break;
									}
								}
							}
							goto IL_09e2;
						}
						goto IL_0a6b;
					}
				}
				if (gStruct.int_2 > 0 && (array7[num4] != num17 || array6[num4] != num14))
				{
					if (Class11.smethod_28(array3[num4]) >= 800L)
					{
						array7[num4] = num17;
						array6[num4] = num14;
						array3[num4] = Class11.smethod_27();
						while (Class64.smethod_17(characterAccountConfig, gStruct.string_0))
						{
							if (num5 <= 0)
							{
								num5 = 8;
							}
							num23 = 0;
							while (num23 < num28)
							{
								int num33 = Class85.smethod_4(characterAccountConfig);
								if (num33 <= num22 && gStruct.int_7 != 0 && (!flag2 || 0 > Class95.smethod_0(characterAccountConfig)))
								{
									if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) != 0)
									{
										break;
									}
									Thread.Sleep(1);
									num23++;
									continue;
								}
								goto IL_09e2;
							}
							num24 = 0;
							if (Class47.smethod_5(characterAccountConfig, Form1.int_16.ToString(), bool_0: true) <= 0)
							{
								int num34 = Class85.smethod_4(characterAccountConfig);
								if (num34 <= num22)
								{
									if (num27 == 0)
									{
										num27++;
										continue;
									}
									num24 = Class64.smethod_27(characterAccountConfig, gStruct.string_0, Form1.int_16, bool_0: true);
									if (num24 <= 0)
									{
										break;
									}
								}
							}
							goto IL_09e2;
						}
					}
				}
				else
				{
					array3[num4] = Class11.smethod_27();
				}
				goto IL_0a6b;
			}
			Thread.Sleep(100);
			continue;
			IL_09e2:
			num25 = 0;
			while (flag2 && num25 < 10)
			{
				Thread.Sleep(100);
				if (0 > Class95.smethod_0(characterAccountConfig))
				{
					num25++;
					continue;
				}
				for (int l = 0; l < gStruct.int_9.Length; l++)
				{
					int num35 = gStruct.int_9[l] - 1;
					if (0 <= num35)
					{
						Class95.smethod_5(characterAccountConfig, num35);
						Thread.Sleep(50 + Class95.int_0);
					}
				}
				break;
			}
			array5[num4] = Class85.smethod_4(characterAccountConfig);
			goto IL_0a6b;
			IL_0a6b:
			num4++;
			continue;
			IL_0701:
			num24 = Class64.smethod_27(characterAccountConfig, gStruct.string_0, Form1.int_16, bool_0: true);
			if (num24 > 0)
			{
				goto IL_09e2;
			}
			goto IL_0a6b;
		}
	}

	public static void smethod_21()
	{
		int int_ = int_3;
		int_3 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25)
				{
					if (0 <= num)
					{
						Form1.characterAccountConfig_1[num].bool_43 = false;
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_43)
					{
						break;
					}
					Form1.characterAccountConfig_1[num].bool_43 = true;
					flag = true;
				}
				smethod_22(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	private static void smethod_22(int int_4)
	{
		int int_5 = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		long long_ = 0L;
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		while (true)
		{
			num--;
			Thread.Sleep(200);
			if (Class11.bool_0)
			{
				break;
			}
			if (num <= 0)
			{
				num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
				if (num2 < 0 || !Form1.characterAccountConfig_1[num2].bool_25)
				{
					break;
				}
				num = 6;
			}
			bool flag = false;
			num4 = Form1.characterAccountConfig_1[num2].int_76[4];
			Form1.characterAccountConfig_1[num2].int_76[4] = 0;
			characterAccountConfig = Form1.characterAccountConfig_1[num2];
			if (characterAccountConfig.string_14 != null && !(characterAccountConfig.string_14 == string.Empty) && (characterAccountConfig.int_76[1] > 0 || characterAccountConfig.int_76[0] > 0))
			{
				int num5 = Class85.smethod_4(characterAccountConfig);
				if (characterAccountConfig.int_76[1] > 0 && num4 > 0)
				{
					flag = true;
				}
				else
				{
					if (characterAccountConfig.int_76[0] <= 0)
					{
						Thread.Sleep(300);
						continue;
					}
					long num6 = Class11.smethod_28(long_);
					if (num6 < 300L || (num3 == num5 && num6 < 1500L))
					{
						continue;
					}
					num4 = 1;
				}
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_5);
				uint num7 = BitConverter.ToUInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num7 + Class56.memorySignatureScanConfig_13.uint_0, array2, 4, ref int_5);
				uint num8 = BitConverter.ToUInt32(array2, 0) * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array2, 4, ref int_5);
				uint num9 = BitConverter.ToUInt32(array2, 0);
				uint num10 = num9 + num8;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num10 + Class56.memorySignatureScanConfig_43.uint_0, array2, 4, ref int_5);
				if (BitConverter.ToInt32(array2, 0) <= 0 && !flag)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array2, 4, ref int_5);
				int num11 = BitConverter.ToInt32(array2, 0);
				string string_ = characterAccountConfig.string_14;
				int num12 = characterAccountConfig.int_76[2];
				int num13 = characterAccountConfig.int_76[3];
				if (num13 <= 0)
				{
					num13 = 1;
				}
				if (flag)
				{
					num12 = num13;
				}
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_5);
				uint num14 = BitConverter.ToUInt32(array2, 0);
				uint num15 = num7 + Class56.memorySignatureScanConfig_97.uint_0;
				uint[,] array3 = new uint[num5, 3];
				byte[] array4 = new byte[string_.Length + 4];
				int num16 = 0;
				int num17 = 0;
				int num18 = 0;
				uint num19 = 1u;
				while (true)
				{
					if (num19 < Class56.int_1)
					{
						Class24.ReadProcessMemory(characterAccountConfig.int_137, num10 + Class56.memorySignatureScanConfig_55.uint_0, array, 1, ref int_5);
						int num20 = array[0];
						Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array2, 4, ref int_5);
						int num21 = BitConverter.ToInt32(array2, 0);
						int num22 = Class89.smethod_39(characterAccountConfig);
						if (num20 == 0 || num20 == 10 || num20 == 21 || num22 <= 1 || num21 != num11)
						{
							break;
						}
						if (num5 > num18)
						{
							uint num23 = num15 + num19 * 20;
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array2, 4, ref int_5);
							uint num24 = BitConverter.ToUInt32(array2, 0);
							if (num24 == 0)
							{
								goto IL_0561;
							}
							uint num25 = num14 + num24 * Class56.memorySignatureScanConfig_106.uint_0;
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_5);
							if (BitConverter.ToInt32(array2, 0) != 0)
							{
								goto IL_0561;
							}
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_5);
							if (array[0] == 0)
							{
								goto IL_0561;
							}
							num18++;
							if (array[0] != string_[0])
							{
								goto IL_0561;
							}
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num23 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_5);
							uint num26 = array[0];
							if (num26 != 23 && num26 != 3 && num26 != 1)
							{
								goto IL_0561;
							}
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_5);
							if (array[0] == 0)
							{
								goto IL_0561;
							}
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num25 + Class56.memorySignatureScanConfig_107.uint_0, array4, array4.Length, ref int_5);
							string text = Class1.smethod_3(array4);
							if (text != string_ && (Form1.int_102 > 0 || string_[0] != text[0] || text.IndexOf(string_) < 0))
							{
								goto IL_0561;
							}
							if (num4 < 2)
							{
								if (num26 != 3)
								{
									array3[num17, 0] = num26;
									array3[num17, 1] = num24;
									array3[num17, 2] = num19;
									num17++;
									goto IL_0561;
								}
								if (num12 > num16)
								{
									num16++;
									goto IL_0561;
								}
								goto IL_086f;
							}
							if (num26 != 23)
							{
								array3[num17, 0] = num26;
								array3[num17, 1] = num24;
								array3[num17, 2] = num19;
								num17++;
							}
							goto IL_0561;
						}
					}
					uint num27 = 23u;
					int num28 = num17;
					if (num4 < 2)
					{
						num27 = 3u;
						num28 = num13 - num16;
						if (num28 > num17)
						{
							num28 = num17;
						}
					}
					if (num28 > 0 && num17 > 0)
					{
						for (int i = 0; i < num17; i++)
						{
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num10 + Class56.memorySignatureScanConfig_55.uint_0, array, 1, ref int_5);
							int num29 = array[0];
							Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array2, 4, ref int_5);
							int num30 = BitConverter.ToInt32(array2, 0);
							int num31 = Class89.smethod_39(characterAccountConfig);
							if (num29 == 0 || num29 == 10 || num29 == 21 || num31 <= 1 || num30 != num11)
							{
								goto end_IL_0567;
							}
							if (num28 <= 0)
							{
								break;
							}
							uint num32 = array3[i, 1];
							uint num33 = array3[i, 2];
							uint num34 = num14 + num32 * Class56.memorySignatureScanConfig_106.uint_0;
							uint num35 = num15 + num33 * 20;
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num35 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array2, 4, ref int_5);
							uint uint_ = BitConverter.ToUInt32(array2, 0);
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num35 + Class56.memorySignatureScanConfig_100.uint_0, array2, 4, ref int_5);
							uint uint_2 = BitConverter.ToUInt32(array2, 0);
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num34 + Class56.memorySignatureScanConfig_111.uint_0, array2, 4, ref int_5);
							uint uint_3 = BitConverter.ToUInt32(array2, 0);
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num34 + Class56.memorySignatureScanConfig_112.uint_0, array2, 4, ref int_5);
							uint uint_4 = BitConverter.ToUInt32(array2, 0);
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num15 + num33 * 20 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 4, ref int_5);
							uint num36 = BitConverter.ToUInt32(array2, 0);
							if (num36 == num27)
							{
								num28--;
								continue;
							}
							uint[] array5 = Class85.smethod_26(characterAccountConfig, num27, uint_3, uint_4);
							if (array5 == null)
							{
								break;
							}
							uint num37 = num36;
							uint num38;
							for (int j = 0; j < 1000; j++)
							{
								if (num37 == 1)
								{
									num37 = num27;
									uint_ = array5[0];
									uint_2 = array5[1];
								}
								if (j % 100 == 0)
								{
									Class24.ReadProcessMemory(characterAccountConfig.int_137, num15 + num33 * 20 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 4, ref int_5);
									num38 = BitConverter.ToUInt32(array2, 0);
									if (num38 != num37)
									{
										goto IL_084d;
									}
									Class75.smethod_46(characterAccountConfig, uint_, uint_2, num37, array5[0], array5[1], num27);
								}
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num15 + num33 * 20 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 4, ref int_5);
								uint num39 = BitConverter.ToUInt32(array2, 0);
								if (num39 == num27 || num39 != num36)
								{
									break;
								}
								num37 = num39;
								Thread.Sleep(1);
							}
							goto IL_0858;
							IL_0858:
							num28--;
							continue;
							IL_084d:
							if (num38 != num27)
							{
								break;
							}
							goto IL_0858;
						}
					}
					goto IL_086f;
					IL_086f:
					long_ = Class11.smethod_27();
					num3 = Class85.smethod_4(characterAccountConfig);
					break;
					IL_0561:
					num19++;
					continue;
					end_IL_0567:
					break;
				}
			}
			else
			{
				Thread.Sleep(300);
			}
		}
	}
}
