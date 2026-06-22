using System;
using System.Threading;
using ns1;
using ns100;
using ns11;
using ns23;
using ns3;
using ns52;
using ns53;
using ns71;

namespace ns84;

internal class Class88
{
	public int int_0 = 0;

	public static void smethod_0(CharacterAccountConfig characterAccountConfig_0)
	{
		Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_53);
	}

	public static void smethod_1(CharacterAccountConfig characterAccountConfig_0)
	{
		Class75.smethod_57(characterAccountConfig_0, "CreateTeam()");
	}

	public static void smethod_2(CharacterAccountConfig characterAccountConfig_0)
	{
		Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_54);
	}

	public static void smethod_3(CharacterAccountConfig characterAccountConfig_0, string string_0)
	{
		Class75.smethod_57(characterAccountConfig_0, "InviteTeam('" + string_0 + "')");
	}

	public static bool smethod_4(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		return Class24.smethod_30(num + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_202.uint_0, characterAccountConfig_0.int_137) != 0;
	}

	public static GStruct61 smethod_5(CharacterAccountConfig characterAccountConfig_0)
	{
		GStruct60[] array = new GStruct60[8];
		int num = 0;
		string string_ = string.Empty;
		for (int i = 0; i < 8; i++)
		{
			string text = Class24.smethod_28(Class56.memorySignatureScanConfig_203.uint_0 + characterAccountConfig_0.uint_7 + (uint)(i * (int)Class56.memorySignatureScanConfig_198.uint_0), characterAccountConfig_0.int_137, 32);
			if (text != string.Empty)
			{
				num++;
				if (i == 0)
				{
					string_ = text;
				}
				array[i].string_0 = text;
				array[i].int_1 = i;
				array[i].int_0 = (int)Class24.smethod_30((uint)(Class56.memorySignatureScanConfig_200.uint_0 + characterAccountConfig_0.uint_7 + i * Class56.memorySignatureScanConfig_199.uint_0), characterAccountConfig_0.int_137);
			}
		}
		return new GStruct61
		{
			int_0 = num,
			string_0 = string_,
			gstruct60_0 = array
		};
	}

	public static void smethod_6(CharacterAccountConfig characterAccountConfig_0, string[] string_0 = null, bool bool_0 = true)
	{
		string text = Class55.smethod_2(characterAccountConfig_0, bool_0: true);
		string[] array = text.Split(';');
		if (array.Length < 2)
		{
			return;
		}
		if (string_0 != null && string_0.Length != 0)
		{
			bool flag = false;
			array[1] = Class1.smethod_1(array[1], 1);
			for (int i = 0; i < string_0.Length; i++)
			{
				if (array[1] == string_0[i])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return;
			}
		}
		uint uint_ = Class11.smethod_12(array[0]);
		Class24.smethod_31(characterAccountConfig_0.uint_55 + 2, characterAccountConfig_0.int_137, uint_);
		Class24.smethod_31(characterAccountConfig_0.uint_55 + 7, characterAccountConfig_0.int_137, Convert.ToByte(bool_0), 1);
		Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_55);
	}

	private int method_0(CharacterAccountConfig[] characterAccountConfig_0, int int_1)
	{
		if (characterAccountConfig_0 != null && characterAccountConfig_0.Length != 0)
		{
			for (int i = 0; i < characterAccountConfig_0.Length; i++)
			{
				if (int_1 == characterAccountConfig_0[i].int_136)
				{
					return i;
				}
			}
		}
		return -1;
	}

	public void method_1()
	{
		int int_ = int_0;
		int num = 1;
		int num2 = 255;
		long long_ = 0L;
		string[] array = new string[2] { "chó", "thÝm" };
		GStruct62 gStruct = default(GStruct62);
		while (!Class11.bool_0)
		{
			Thread.Sleep(300);
			int num3 = method_0(Form1.characterAccountConfig_1, int_);
			if (num3 < 0)
			{
				break;
			}
			CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num3];
			if (!characterAccountConfig_.bool_25)
			{
				break;
			}
			if (gStruct.string_0 == null || gStruct.string_0 == "")
			{
				continue;
			}
			string[] array2 = gStruct.string_0.Split(',');
			if (array2 == null || array2.Length == 0)
			{
				continue;
			}
			int num4 = -1;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] == characterAccountConfig_.string_22 || array2[i] == Class1.smethod_1(characterAccountConfig_.string_22, 1))
				{
					num4 = i;
					break;
				}
			}
			if (num4 < 0)
			{
				continue;
			}
			gStruct.int_0 = Convert.ToByte(num4 == 0) + 3 * Convert.ToByte(num4 != 0);
			uint num5 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_.int_137);
			uint num6 = Class24.smethod_30(Class56.memorySignatureScanConfig_165.uint_0, characterAccountConfig_.int_137);
			uint uint_ = Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_167.uint_0, characterAccountConfig_.int_137);
			uint num7 = Class24.smethod_30(uint_, characterAccountConfig_.int_137);
			string text = Class24.smethod_28(num7, characterAccountConfig_.int_137, 60);
			GStruct61 gStruct2 = smethod_5(characterAccountConfig_);
			bool flag = smethod_4(characterAccountConfig_);
			if (gStruct.int_0 == 1 && (array2 == null || array2.Length == 0))
			{
				continue;
			}
			if (gStruct.int_0 <= 1)
			{
				if (flag)
				{
					if (!(gStruct2.string_0 != characterAccountConfig_.string_22))
					{
						if (gStruct2.int_0 != 8)
						{
							if (num >= num2)
							{
								num = 1;
							}
							int num8 = 0;
							for (int j = num; j < num2; j++)
							{
								num8++;
								uint num9 = (uint)j * Class56.memorySignatureScanConfig_15.uint_0;
								uint num10 = Class24.smethod_30(num5 + num9 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_.int_137);
								if (num10 != 1 || Class24.smethod_30(num5 + num9 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_.int_137) == 0)
								{
									continue;
								}
								string text2 = Class24.smethod_28(num5 + num9 + Class56.memorySignatureScanConfig_16.uint_0, characterAccountConfig_.int_137, 32);
								if (text2 == "" || text2 == characterAccountConfig_.string_22)
								{
									continue;
								}
								if (Class11.bool_0)
								{
									return;
								}
								Thread.Sleep(200);
								bool flag2 = false;
								string text3 = Class1.smethod_1(text2, 1);
								if (gStruct2.int_0 > 0 && gStruct2.gstruct60_0 != null)
								{
									for (int k = 0; k < gStruct2.gstruct60_0.Length; k++)
									{
										if (gStruct2.gstruct60_0[k].string_0 != null && gStruct2.gstruct60_0[k].string_0 != "" && gStruct2.gstruct60_0[k].string_0 == text2)
										{
											flag2 = true;
											break;
										}
									}
								}
								if (flag2)
								{
									continue;
								}
								if (gStruct.int_0 == 1)
								{
									flag2 = true;
									if (array2 != null && array2.Length != 0)
									{
										for (int l = 0; l < array2.Length; l++)
										{
											if (text2 == array2[l] || text3 == array2[l])
											{
												flag2 = false;
												break;
											}
										}
									}
								}
								if (!flag2)
								{
									smethod_3(characterAccountConfig_, text2);
									if (Class11.smethod_28(long_) > 3000L)
									{
										int num11 = Convert.ToByte(Class3.smethod_10(characterAccountConfig_, j) > 0);
										string text4 = "<color=green>" + text2 + "<color=white> vµo pt ®i " + array[num11] + " :B";
										Class75.smethod_57(characterAccountConfig_, "Chat('CH_NEARBY', '" + text4 + "')");
										long_ = Class11.smethod_27();
									}
									break;
								}
							}
							num = ((num8 != 0) ? (num + num8) : (num + 1));
						}
					}
					else
					{
						smethod_2(characterAccountConfig_);
					}
				}
				else
				{
					smethod_1(characterAccountConfig_);
				}
			}
			else
			{
				if (text == string.Empty)
				{
					continue;
				}
				if (flag)
				{
					if (gStruct.int_0 == 2 || array2 == null || array2.Length == 0)
					{
						if (gStruct2.string_0 != characterAccountConfig_.string_22)
						{
							goto IL_06cd;
						}
						smethod_2(characterAccountConfig_);
						flag = false;
						Thread.Sleep(450);
					}
					if (gStruct2.gstruct60_0 != null)
					{
						for (int m = 0; m < gStruct2.gstruct60_0.Length; m++)
						{
							Thread.Sleep(100);
							string string_ = gStruct2.gstruct60_0[m].string_0;
							if (string_ == null || string_ == "" || string_ == characterAccountConfig_.string_22)
							{
								continue;
							}
							string_ = Class1.smethod_1(string_, 1);
							int num12 = 0;
							while (num12 < array2.Length)
							{
								if (!(string_ == array2[num12]))
								{
									Thread.Sleep(100);
									num12++;
									continue;
								}
								goto IL_06cd;
							}
						}
					}
				}
				if (Class11.smethod_1(text, "mêi tæ ®éi") > 0)
				{
					string text5 = Class24.smethod_28(num7 + Class56.memorySignatureScanConfig_205.uint_0, characterAccountConfig_.int_137, 25);
					if (!(text5 == string.Empty))
					{
						if (!flag || gStruct.int_0 <= 2 || array2 == null || array2.Length == 0)
						{
							goto IL_062a;
						}
						text5 = Class1.smethod_1(text5, 1);
						int num13 = 0;
						while (num13 < array2.Length)
						{
							if (!(text5 == array2[num13]))
							{
								num13++;
								continue;
							}
							goto IL_062a;
						}
					}
				}
			}
			goto IL_06cd;
			IL_062a:
			uint num14 = Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_170.uint_0, characterAccountConfig_.int_137);
			if (num14 != 0 && num14 < int.MaxValue)
			{
				Class24.smethod_31(characterAccountConfig_.uint_55 + 2, characterAccountConfig_.int_137, num14);
				Class24.smethod_31(characterAccountConfig_.uint_55 + 7, characterAccountConfig_.int_137, 1u, 1);
				Class75.smethod_12(characterAccountConfig_.int_137, characterAccountConfig_.uint_55);
				if (Class11.smethod_28(long_) > 2500L)
				{
					Class75.smethod_57(characterAccountConfig_, "Chat('CH_NEARBY', 'C\u00b8m ¬n thÝm ®· mêi !:0')");
					long_ = Class11.smethod_27();
				}
				Thread.Sleep(500);
				continue;
			}
			goto IL_06cd;
			IL_06cd:
			if (text != string.Empty)
			{
				Class75.smethod_12(characterAccountConfig_.int_137, characterAccountConfig_.uint_56);
			}
			Thread.Sleep(300);
		}
	}
}
