using System;
using System.Threading;
using ns10;
using ns11;
using ns28;
using ns41;
using ns42;
using ns63;

namespace ns34;

internal class Class37
{
	private struct LevelBracketMapGroup
	{
		public int levelBracket;

		public int[] mapIds;

		public string labelPrefix;
	}

	public static int int_0 = Class66.smethod_4("fChayboLThuydong", 0, "0");

	public static int int_1 = 0;

	public static string[] string_0 = null;

	public static MapNavigationEntry[] mapNavigationEntry_0 = null;

	public static int[] int_2 = null;

	private static string[] string_1 = new string[5] { "®«ng|§«ng", "t©y", "nam", "b¾c", "t©m" };

	private static string string_2 = "K8k4PE+h7NBWhZKMQ6vzakJAXF2FEDAHKLQ1LwMoAxQDSyuUFB3ugipSgypKhyiHKKwBqdWBKwYA";

	private static string string_3 = "K8k4PE+h7NBWhZKMQ6vzakJAXF2FEDAHKLQ1LwMoAxQDSyuUFB3ugipSgypKhyiHKKwBqdWBKwZxN0JNzs4oVSg7vDNZoSAjsybl8Ja8dKBE6eHuEpCi9jwFsBE1eYfWZCrklh5ekQcA";

	private static string string_4 = "RY/BCoJQEEXxT+YHBN3pojYuyzZFm1b2hBTjIaWgMF9Q6/oDoUiDIIO2b36seb6i1VxmLvfcKdRVQpHQA9fqJS11p8YSqq/RBs/ByvYqlOA6MBqDx0qom9xAQT0IOuQYq466dNDgYwp+hXSS7Fy5DuoYY4vyPWzLms4SwyiHxS5KjTJLQBMrVAu6BU6SEpb0FjA19wCDwTBnQ8AYbskUbdWy4RiuJlWb/ij/U5bgFzIwMKanfiAp6VjgLmKdmbHHmQ4IS7rIDw==";

	private static string string_5 = "PYwxCsJAFESvMhfIPYSAWAT7qJCfwlkIIdW/huVaryjWsf3/Yu5uINW8GZh3ksABZ3tRO08Z2/G+UbMTmrpmqHUblfYZIcF+s/qDWPyJefKoHik4WspC6QM6W696sTXg1lOUoOREeWvN4joUDexrbw5/";

	private static MapNavigationEntry smethod_0(int int_3)
	{
		if (int_3 > 0)
		{
			for (int i = 0; i < Class29.mapNavigationEntry_0.GetLength(0); i++)
			{
				if (int_3 == Class29.mapNavigationEntry_0[i].int_0)
				{
					return Class29.mapNavigationEntry_0[i];
				}
			}
		}
		if (int_3 > 0)
		{
			if (int_2 != null)
			{
				Array.Resize(ref int_2, int_2.Length + 1);
			}
			else
			{
				int_2 = new int[1];
			}
			int_2[int_2.Length - 1] = int_3;
		}
		return default(MapNavigationEntry);
	}

	private static void smethod_1(ref MapNavigationEntry[] mapNavigationEntry_1, MapNavigationEntry mapNavigationEntry_2)
	{
		if (mapNavigationEntry_1 == null)
		{
			mapNavigationEntry_1 = new MapNavigationEntry[1];
		}
		else
		{
			Array.Resize(ref mapNavigationEntry_1, mapNavigationEntry_1.Length + 1);
		}
		mapNavigationEntry_1[mapNavigationEntry_1.Length - 1] = mapNavigationEntry_2;
	}

	private static void smethod_2(ref MapNavigationEntry[] mapNavigationEntry_1, int[] int_3, string string_6, string string_7 = null, bool bool_0 = false, bool bool_1 = false, string string_8 = null)
	{
		for (int i = 0; i < int_3.Length; i++)
		{
			MapNavigationEntry mapNavigationEntry_2 = smethod_0(int_3[i]);
			if (mapNavigationEntry_2.int_0 <= 0)
			{
				if (!bool_1)
				{
					continue;
				}
				mapNavigationEntry_2.int_0 = int_3[i];
			}
			mapNavigationEntry_2.string_4 = string_6;
			if (string_8 != null && string_8 != string.Empty)
			{
				mapNavigationEntry_2.string_5 = string_8;
			}
			if (string_7 != null && string_7 != string.Empty)
			{
				if (mapNavigationEntry_2.string_2 != null && !(mapNavigationEntry_2.string_2 == string.Empty))
				{
					if (!bool_0)
					{
						mapNavigationEntry_2.string_2 = mapNavigationEntry_2.string_2 + "|" + string_7;
					}
					else
					{
						mapNavigationEntry_2.string_2 = string_7 + "|" + mapNavigationEntry_2.string_2;
					}
				}
				else
				{
					mapNavigationEntry_2.string_2 = string_7;
				}
			}
			smethod_1(ref mapNavigationEntry_1, mapNavigationEntry_2);
		}
	}

	private static void smethod_3(ref MapNavigationEntry[] mapNavigationEntry_1, string string_6 = null, int[] int_3 = null, int int_4 = 0, string string_7 = null)
	{
		if (int_3 == null || int_3.Length == 0)
		{
			int_3 = new int[22]
			{
				336, 75, 93, 322, 321, 227, 225, 226, 340, 144,
				124, 152, 875, 917, 918, 919, 920, 921, 922, 923,
				924, 950
			};
		}
		if (string_6 == null || string_6 == string.Empty)
		{
			string_6 = "å VIP|maps VIP|Êp 9| 90|n\u0001®å\u000190|Êp\u00019|9X|[90|" + Class11.smethod_72(string_3);
		}
		string text = string.Empty;
		for (int i = 0; i < 6; i++)
		{
			if (text != null && text != string.Empty)
			{
				text += "|";
			}
			text += "rang k|rang s";
		}
		smethod_2(ref mapNavigationEntry_1, int_3, string_6, text);
		if (int_4 == 0 || mapNavigationEntry_1 == null)
		{
			return;
		}
		for (int i = 0; i < mapNavigationEntry_1.Length; i++)
		{
			if (mapNavigationEntry_1[i].int_0 != 336)
			{
				continue;
			}
			if (int_4 < 0)
			{
				mapNavigationEntry_1[i] = default(MapNavigationEntry);
				break;
			}
			if (string_7 == null || string_7 == string.Empty)
			{
				string_7 = "Ýnh N\u00a8n|b¶n ®å kh|ng Kh\u00b8c|gia ho¹t|N¬i Muèn";
			}
			string_7 = "Phong L\u00a8ng|" + string_7;
			mapNavigationEntry_1[i].string_2 = "POS|36672,96512, 1|40864,93088, 2|49440,89856, 3|35655,102188,Phong L\u00a8ng\u0001" + string_6.Replace("|", "_") + "\u0001Phong L\u00a8ng";
			mapNavigationEntry_1[i].string_4 = string_7 + "|" + string_6;
			break;
		}
	}

	private static void smethod_4(ref MapNavigationEntry[] mapNavigationEntry_1, string string_6 = null, LevelBracketMapGroup[] levelBracketMapGroup_0 = null, string string_7 = null)
	{
		if (levelBracketMapGroup_0 == null)
		{
			return;
		}
		if (string_6 == null || string_6 == string.Empty)
		{
			string_6 = Class11.smethod_72(string_4) + "|" + Class11.smethod_72(string_3);
		}
		if (string_7 == null || string_7 == string.Empty)
		{
			string_7 = "rang k|rang s";
		}
		for (int i = 0; i < levelBracketMapGroup_0.GetLength(0); i++)
		{
			if (levelBracketMapGroup_0[i].mapIds != null && levelBracketMapGroup_0[i].mapIds.Length != 0)
			{
				if (levelBracketMapGroup_0[i].levelBracket <= 0)
				{
					levelBracketMapGroup_0[i].levelBracket = (i + 2) * 10;
				}
				string text = "cÊp " + levelBracketMapGroup_0[i].levelBracket + "| " + levelBracketMapGroup_0[i].levelBracket.ToString()[0].ToString() + "x";
				if (levelBracketMapGroup_0[i].labelPrefix != null && levelBracketMapGroup_0[i].labelPrefix != string.Empty)
				{
					text = levelBracketMapGroup_0[i].labelPrefix + "|" + text;
				}
				smethod_2(ref mapNavigationEntry_1, levelBracketMapGroup_0[i].mapIds, text + "|" + string_6, string_7);
			}
		}
	}

	private static void smethod_5(ref MapNavigationEntry[] mapNavigationEntry_1, string string_6 = null, int[] int_3 = null, string string_7 = null, int[] int_4 = null, string string_8 = null, int[] int_5 = null, string string_9 = null, int[] int_6 = null, string string_10 = null, int[] int_7 = null, string string_11 = null, int int_8 = 0)
	{
		string text = Class11.smethod_72(string_3);
		string text2 = Class11.smethod_72(string_2);
		if (int_3 == null || int_3.Length == 0)
		{
			int_3 = new int[7] { 1, 11, 37, 78, 80, 162, 176 };
		}
		if (string_6 == null || string_6 == string.Empty)
		{
			string_6 = "hµnh thÞ|hµnh thÞ|" + text;
		}
		smethod_2(ref mapNavigationEntry_1, int_3, string_6 + "|" + text2, null, bool_0: false, bool_1: true);
		if (int_4 == null || int_4.Length == 0)
		{
			int_4 = new int[9] { 20, 53, 99, 100, 101, 121, 153, 174, 175 };
		}
		if (string_7 == null || string_7 == string.Empty)
		{
			string_7 = "h«n tr|h«n tr|" + text;
		}
		smethod_2(ref mapNavigationEntry_1, int_4, string_7 + "|" + text2);
		if (int_5 != null || (string_8 != null && string_8 != string.Empty))
		{
			if (int_5 == null || int_5.Length == 0)
			{
				int_5 = new int[10] { 59, 103, 25, 183, 13, 154, 49, 115, 81, 131 };
			}
			if (string_8 == null || string_8 == string.Empty)
			{
				string_8 = "«n ph\u00b8i|«n ph\u00b8i|" + text;
			}
			smethod_2(ref mapNavigationEntry_1, int_5, string_8 + "|" + text2);
		}
		if (int_6 == null || int_6.Length == 0)
		{
			int_6 = new int[3] { 323, 324, 325 };
		}
		if (string_9 == null || string_9 == string.Empty)
		{
			string_9 = Class11.smethod_72(string_5) + "|" + text;
		}
		for (int i = 0; i < int_6.Length; i++)
		{
			int[] array = new int[1] { int_6[i] };
			string text3 = string_9;
			text3 = ((array[0] >= 324) ? ((array[0] != 324) ? (text3 + "|Cao C|Quèc chiÕn") : (text3 + "|Trung C")) : (text3 + "|S¬ C"));
			smethod_2(ref mapNavigationEntry_1, array, text3);
		}
		if (int_7 != null || (string_10 != null && string_10 != string.Empty))
		{
			if (int_7 == null || int_7.Length == 0)
			{
				int_7 = new int[8] { 520, 520, 521, 522, 523, 524, 525, 526 };
			}
			if (string_10 == null || string_10 == string.Empty)
			{
				string_10 = Class11.smethod_72("Kzs8T6Gk6PBcheyMmrxDazIVMvIP7SyBMJMzSisPT85TKM6sCTk8Ny9Dwe/Qirz0Gr+MzMPTchXCDm9RcDq0L7nGLx2obFqJQkjR4a48BV2FQ8sPbc1X8MhPrAEA") + text;
			}
			smethod_2(ref mapNavigationEntry_1, int_7, string_10);
		}
		if (int_8 > 0)
		{
			if (string_11 == null || string_11 == string.Empty)
			{
				string_11 = ((string_10 == null || !(string_10 != string.Empty)) ? "vÞ trÝ kh" : string_10);
				string_11 = "Hoa Nguy|Hoa Nguy|" + string_11;
			}
			MapNavigationEntry mapNavigationEntry_2 = smethod_0(int_8);
			mapNavigationEntry_2.string_4 = string_11;
			smethod_1(ref mapNavigationEntry_1, mapNavigationEntry_2);
		}
	}

	public static void smethod_6(ref MapNavigationEntry[] mapNavigationEntry_1, int int_3, string string_6, string string_7, string string_8 = null, string string_9 = null, string string_10 = null, bool bool_0 = false, string string_11 = null, string string_12 = null)
	{
		MapNavigationEntry mapNavigationEntry = new MapNavigationEntry
		{
			int_0 = int_3,
			string_2 = string_7,
			string_3 = string_9,
			string_4 = string_6,
			string_5 = string_10,
			string_0 = string_8,
			string_6 = string_11,
			string_7 = string_12
		};
		if (mapNavigationEntry_1 != null && mapNavigationEntry_1.Length != 0)
		{
			if (!bool_0)
			{
				for (int i = 0; i < mapNavigationEntry_1.Length; i++)
				{
					if (mapNavigationEntry_1[i].int_0 == int_3)
					{
						mapNavigationEntry_1[i] = mapNavigationEntry;
						return;
					}
				}
			}
			Array.Resize(ref mapNavigationEntry_1, mapNavigationEntry_1.Length + 1);
			mapNavigationEntry_1[mapNavigationEntry_1.Length - 1] = mapNavigationEntry;
		}
		else
		{
			mapNavigationEntry_1 = new MapNavigationEntry[1] { mapNavigationEntry };
		}
	}

	private static void smethod_7(ref MapNavigationEntry[] mapNavigationEntry_1, int int_3 = 355, string string_6 = null, string string_7 = null, string string_8 = null, string string_9 = null, string string_10 = null)
	{
		if (string_6 == null || string_6 == string.Empty)
		{
			string_6 = "Sinh T";
		}
		if (string_7 == null || string_7 == string.Empty)
		{
			string_7 = "POS|50304,78016,B¾c_ 1|38592,100992,Nam_ 2|49440,99520,§«ng_ 3|38976,78464,T©y_ 4";
		}
		if (int_3 <= 0)
		{
			int_3 = 355;
		}
		smethod_6(ref mapNavigationEntry_1, int_3, string_6, string_7, null, string_10, null, bool_0: false, string_8, string_9);
	}

	private static void smethod_8(ref MapNavigationEntry[] mapNavigationEntry_1, int int_3 = 959, string string_6 = null, string string_7 = null, string string_8 = null)
	{
		if (string_6 != null && !(string_6 == string.Empty))
		{
			if (string_6 == "null")
			{
				string_6 = null;
			}
		}
		else
		{
			string_6 = "ChiÕn Long|thÇn hµnh";
		}
		if (string_7 == null || string_7 == string.Empty)
		{
			string_7 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T\u00adêng V©n";
		}
		if (string_8 == null || string_8 == string.Empty)
		{
			string_8 = "ChiÕn Long";
		}
		smethod_6(ref mapNavigationEntry_0, int_3, string_6, string_7, "ChiÕn Long §éng", string_8);
	}

	private static void smethod_9(ref MapNavigationEntry[] mapNavigationEntry_1, string string_6)
	{
		smethod_6(ref mapNavigationEntry_1, -1, string_6, null, null, "VANTIEU", null, bool_0: true);
	}

	private static void smethod_10()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		int[,] array = new int[10, 2];
		Class10.smethod_4(array, 141600);
		int[,] array2 = array;
		int[] array3 = new int[7] { 11, 78, 1, 162, 37, 80, 176 };
		for (int i = 0; i < array2.GetLength(0); i++)
		{
			Array.Resize(ref array3, array3.Length + 1);
			array3[array3.Length - 1] = array2[i, 1];
		}
		smethod_5(ref mapNavigationEntry_0, null, array3);
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + Class11.smethod_72(string_3));
		smethod_3(ref mapNavigationEntry_0, null, null, 1);
		smethod_4(ref mapNavigationEntry_0, null, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 179 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[7] { 193, 170, 92, 22, 4, 6, 8 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 164, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[6] { 79, 56, 166, 114, 69, 94 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[7] { 319, 123, 206, 72, 169, 1000, 1001 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					10, 76, 124, 181, 198, 199, 200, 201, 202, 203,
					204, 205, 224, 320
				}
			}
		});
		smethod_8(ref mapNavigationEntry_0);
		Class45.smethod_7(array2);
		Class44.int_1 = array2;
	}

	private static void smethod_11()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		smethod_5(ref mapNavigationEntry_0, text + "|Thµnh thÞ", null, text + "|Th«n tr", null, text + "|n ph\u00b8i", null, text + "|Tèng Kim");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text, new int[13]
		{
			322, 321, 75, 227, 225, 226, 336, 340, 144, 93,
			124, 152, 76
		});
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|2x ®Õn 8x|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[2] { 19, 7 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 1000, 1001 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T");
	}

	private static void smethod_12()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text, new int[15]
		{
			875, 322, 321, 75, 227, 225, 226, 336, 340, 144,
			93, 124, 152, 76, 224
		});
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text, new LevelBracketMapGroup[5]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[4] { 170, 77, 8, 22 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[3] { 171, 23, 6 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[3] { 24, 125, 194 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 158, 196, 79 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[1] { 319 }
			}
		});
		smethod_5(ref mapNavigationEntry_0, text + "|Thµnh thÞ", null, text + "|Th«n tr", null, text + "|M«n ph\u00b8i", null, text + "|Tèng Kim");
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T");
	}

	private static void smethod_13()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		int[,] array = new int[8, 2];
		Class10.smethod_4(array, 142526);
		int[,] array2 = array;
		int[] array3 = new int[7] { 11, 78, 1, 162, 37, 80, 176 };
		for (int i = 0; i < array2.GetLength(0); i++)
		{
			Array.Resize(ref array3, array3.Length + 1);
			array3[array3.Length - 1] = array2[i, 1];
		}
		int[] array4 = new int[8] { 53, 20, 99, 100, 101, 121, 153, 174 };
		Array.Resize(ref array4, array4.Length + 1);
		array4[array4.Length - 1] = 1062;
		smethod_5(ref mapNavigationEntry_0, text + "|Thµnh thÞ", array3, text + "|Th«n tr", array4, text + "|M«n ph\u00b8i", null, text + "|ho¹t ®éng|Tèng Kim");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text, new int[14]
		{
			322, 321, 75, 227, 225, 226, 336, 340, 144, 93,
			124, 152, 76, 224
		});
		smethod_3(ref mapNavigationEntry_0, "cÊp 90 (New)|" + text, new int[21]
		{
			1079, 1080, 1081, 1082, 1083, 1084, 1085, 1086, 1087, 1088,
			1089, 1090, 1091, 1092, 1093, 1094, 1095, 1096, 1097, 1098,
			1099
		});
		smethod_4(ref mapNavigationEntry_0, "n n¬i luyÖn c|t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[8] { 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[8] { 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[8] { 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[8] { 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[8] { 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[8] { 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[8] { 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056 }
			}
		});
		smethod_6(ref mapNavigationEntry_0, 977, "gia ho¹t|ho¹t ®éng|Qu¶ H|Huy Hoµng|" + text, "POS|65418,82970,iÓm B\u00b8o dan|63072,92096,sè 1|62880,86432,sè 2|59168,85888,sè 3|55264,91968,sè 4|54976,97376,sè 5|57920,98368,sè 6|57120,94816,sè 7|61056,89056,sè 8");
		Class45.smethod_7(array2);
		Class44.int_1 = array2;
	}

	private static void smethod_14(bool bool_0 = false)
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "b¶n ®å luy";
		smethod_5(ref mapNavigationEntry_0, text + "|Thµnh thÞ", null, text + "|Th«n tr", null, text + "|n ph\u00b8i", null, text + "|Tèng Kim");
		smethod_3(ref mapNavigationEntry_0, text + "|cÊp 90|" + text, new int[13]
		{
			875, 322, 321, 75, 227, 225, 226, 336, 340, 144,
			93, 124, 152
		});
		smethod_4(ref mapNavigationEntry_0, text2 + "|t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 179 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[6] { 193, 170, 92, 22, 4, 6 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 164, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[6] { 79, 56, 166, 114, 69, 94 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 72, 169 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[7] { 224, 198, 320, 181, 201, 203, 202 }
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, text + "Sinh T");
		smethod_6(ref mapNavigationEntry_0, 1062, "§i §Õn V\u00ad¬ng KhiÕt Thµnh|" + text, "POS| 52064,105408,TËp KÕt 1|44224, 90944,TËp KÕt 2|62336,105376 ,TËp KÕt 3|62144,115936,TËp KÕt 4|54368,110464 ,TËp kÕt 5|57024,107840,TËp kÕt 6|60096,110464,TËp kÕt 7| 57152,113696,TËp kÕt 8");
		smethod_6(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé|" + text, "POS |35648,105952,B¹ch Hæ TrËn|36288,118368,Chu T\u00adíc TrËn|47520,107168,HuyÒn|47776,118144,Thanh");
		if (bool_0)
		{
			smethod_8(ref mapNavigationEntry_0, 959, "hiÕn Lo|" + text);
		}
	}

	private static void smethod_15()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		smethod_5(ref mapNavigationEntry_0, "Thµnh thÞ|" + text, null, "thñ th«n|Th«n tr|" + text, null, "M«n ph\u00b8i|" + text, null, "Tèng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "luyÖn c«ng|cÊp 90|" + text, new int[15]
		{
			875, 322, 321, 75, 227, 225, 226, 336, 340, 144,
			93, 124, 152, 76, 224
		});
		smethod_8(ref mapNavigationEntry_0);
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
	}

	private static void smethod_16()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		smethod_5(ref mapNavigationEntry_0, "Thµnh thÞ|" + text, null, "thñ th«n|Th«n tr|" + text, null, "M«n ph\u00b8i|" + text, null, "Tèng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "luyÖn c«ng|cÊp 90|" + text, new int[14]
		{
			875, 322, 321, 75, 225, 226, 227, 336, 340, 144,
			93, 124, 152, 76
		});
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|cña t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 179 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[6] { 193, 170, 92, 22, 4, 6 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 164, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[6] { 79, 56, 166, 114, 69, 94 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 72, 169 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[7] { 224, 198, 320, 181, 201, 203, 202 }
			}
		});
		smethod_8(ref mapNavigationEntry_0);
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T");
	}

	private static void smethod_17()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "ThÇn hµnh";
		string text2 = "B¶n ®å luyÖn c«ng.";
		smethod_5(ref mapNavigationEntry_0, text + "|Thµnh thÞ|Thµnh ThÞ", null, text + " |Th«n trang|Th«n trang", null, text + "|M«n Ph\u00b8i|M«n Ph\u00b8i", null, "Tèng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "CÊp 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, "2x ®Õn 8x|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[9] { 19, 7, 3, 43, 179, 14, 70, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[13]
				{
					193, 170, 92, 22, 4, 6, 8, 74, 77, 90,
					136, 141, 145
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 171, 172, 173, 21, 23, 5, 41, 122, 6,
					91, 135, 168, 180
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					182, 42, 24, 164, 165, 38, 39, 40, 66, 67,
					116, 125, 132, 147, 163, 12, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					79, 56, 166, 114, 51, 52, 158, 117, 118, 119,
					126, 127, 128, 148, 26, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[10] { 319, 123, 206, 72, 169, 94, 9, 55, 27, 129 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[15]
				{
					224, 198, 320, 181, 201, 203, 202, 10, 143, 151,
					24, 199, 205, 207, 204
				}
			}
		});
		smethod_7(ref mapNavigationEntry_0, 1040, "Sinh T|" + text, "POS|52416,100992,HËu Doanh 1|65440,83008,HËu Doanh 2|3,43840,85600|4,46816,88864");
		smethod_6(ref mapNavigationEntry_0, 997, "Thµnh thÞ|Thµnh thÞ míi|Th\u00a8ng Long|" + text, "POS|101824,165792,§«ng|97504,159456,T©y|96160,163392 ,Nam|103840,160896,B¾c|100608,162336 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 996, "Thµnh thÞ|Thµnh thÞ míi|Kinh §«|" + text, "POS|50336,107424 ,§«ng|47168,101664,T©y|46528,104640,Nam|54528,103552,B¾c|50464,103616 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 999, "Thµnh thÞ|Thµnh thÞ míi|Phong L\u00a8ng|" + text, "POS|52128,100992 ,B¾c|50528,100320 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 998, "Thµnh thÞ|Thµnh thÞ míi|Ch©u Giang|" + text, "POS|54272,102976 ,§«ng|51904,96512,T©y|54272,102976,Nam|59392,94912,B¾c|55232,99200,T©m");
		smethod_6(ref mapNavigationEntry_0, 1002, "luyÖn c«ng|90 Thu PhÝ|S¬n Nam|S¬n Nam 1| " + text, "POS|30944,74016,Nam 1");
		smethod_6(ref mapNavigationEntry_0, 1049, "luyÖn c«ng|90 Thu PhÝ|S¬n Nam|S¬n Nam 2| " + text, "POS|30944,74016,Nam 2");
		smethod_6(ref mapNavigationEntry_0, 1050, "luyÖn c«ng|90 Thu PhÝ|S¬n Nam|S¬n Nam 3| " + text, "POS|30944,74016,Nam 3");
		smethod_6(ref mapNavigationEntry_0, 1051, "luyÖn c«ng|90 Thu PhÝ|S¬n Nam|S¬n Nam 4| " + text, "POS|30944,74016,Nam 4");
		smethod_6(ref mapNavigationEntry_0, 1052, "luyÖn c«ng|90 Thu PhÝ|S¬n Nam|S¬n Nam 5| " + text, "POS|30944,74016,Nam 5");
		smethod_6(ref mapNavigationEntry_0, 1081, "luyÖn c«ng|90 Thu PhÝ|S¬n Nam|S¬n Nam 6| " + text, "POS|30944,74016,Nam 6");
		smethod_6(ref mapNavigationEntry_0, 1082, "luyÖn c«ng|90 Thu PhÝ|S¬n Nam|S¬n Nam 7| " + text, "POS|30944,74016,Nam 7");
		smethod_6(ref mapNavigationEntry_0, 1005, "luyÖn c«ng|90 Thu PhÝ|S¬n B¾c|S¬n B¾c 1| " + text, "POS|49994,101336 ,B¾c 1");
		smethod_6(ref mapNavigationEntry_0, 1053, "luyÖn c«ng|90 Thu PhÝ|S¬n B¾c|S¬n B¾c 2| " + text, "POS|49994,101336 ,B¾c 2");
		smethod_6(ref mapNavigationEntry_0, 1054, "luyÖn c«ng|90 Thu PhÝ|S¬n B¾c|S¬n B¾c 3| " + text, "POS|49994,101336 ,B¾c 3");
		smethod_6(ref mapNavigationEntry_0, 1055, "luyÖn c«ng|90 Thu PhÝ|S¬n B¾c|S¬n B¾c 4| " + text, "POS|49994,101336 ,B¾c 4");
		smethod_6(ref mapNavigationEntry_0, 1056, "luyÖn c«ng|90 Thu PhÝ|S¬n B¾c|S¬n B¾c 5| " + text, "POS|49994,101336 ,B¾c 5");
		smethod_6(ref mapNavigationEntry_0, 1079, "luyÖn c«ng|90 Thu PhÝ|S¬n B¾c|S¬n B¾c 6| " + text, "POS|49994,101336 ,B¾c 6");
		smethod_6(ref mapNavigationEntry_0, 1080, "luyÖn c«ng|90 Thu PhÝ|S¬n B¾c|S¬n B¾c 7| " + text, "POS|49994,101336 ,B¾c 7");
		smethod_6(ref mapNavigationEntry_0, 1006, "luyÖn c«ng|90 Thu PhÝ|QuËt|QuËt 1| " + text, "POS|58994,110060 ,QuËt 1");
		smethod_6(ref mapNavigationEntry_0, 1057, "luyÖn c«ng|90 Thu PhÝ|QuËt|QuËt 2| " + text, "POS|58994,110060 ,QuËt 2");
		smethod_6(ref mapNavigationEntry_0, 1058, "luyÖn c«ng|90 Thu PhÝ|QuËt|QuËt 3| " + text, "POS|58994,110060 ,QuËt 3");
		smethod_6(ref mapNavigationEntry_0, 1059, "luyÖn c«ng|90 Thu PhÝ|QuËt|QuËt 4| " + text, "POS|58994,110060 ,QuËt 4");
		smethod_6(ref mapNavigationEntry_0, 1062, "luyÖn c«ng|90 Thu PhÝ|QuËt|QuËt 5| " + text, "POS|58994,110060 ,QuËt 5");
		smethod_6(ref mapNavigationEntry_0, 1083, "luyÖn c«ng|90 Thu PhÝ|QuËt|QuËt 6| " + text, "POS|58994,110060 ,QuËt 6");
		smethod_6(ref mapNavigationEntry_0, 1084, "luyÖn c«ng|90 Thu PhÝ|QuËt|QuËt 7| " + text, "POS|58994,110060 ,QuËt 7");
	}

	private static void smethod_18()
	{
		string text = "thÇn hµnh";
		string string_ = "cÊp 90|" + text;
		int_2 = null;
		mapNavigationEntry_0 = null;
		int[,] array = new int[2, 2];
		Class10.smethod_4(array, 144135);
		int[,] array2 = array;
		int[] array3 = new int[7] { 11, 78, 1, 162, 37, 80, 176 };
		for (int i = 0; i < array2.GetLength(0); i++)
		{
			Array.Resize(ref array3, array3.Length + 1);
			array3[array3.Length - 1] = array2[i, 1];
		}
		smethod_5(ref mapNavigationEntry_0, "µnh thÞ|" + text, array3, "Th«n tr|" + text, null, "«n ph\u00b8i|" + text, null, "Tèng Ki|" + text);
		smethod_6(ref mapNavigationEntry_0, 997, string_, "¬n T©y", "Tr\u00adêng B¹ch S¬n T©y");
		smethod_6(ref mapNavigationEntry_0, 998, string_, "¬n §«ng", "Tr\u00adêng B¹ch S¬n §«ng");
		smethod_6(ref mapNavigationEntry_0, 54, text, "Nam Nh¹c", "Nam Nh¹c TrÊn");
		smethod_3(ref mapNavigationEntry_0, string_);
		smethod_4(ref mapNavigationEntry_0, "Õn n¬i luyÖn|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 7, 19, 71 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[4] { 170, 8, 420, 429 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[8] { 171, 172, 421, 422, 423, 430, 431, 432 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[6] { 38, 164, 424, 433, 434, 435 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 56, 117, 436 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[9] { 319, 995, 440, 996, 442, 437, 438, 441, 55 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[3] { 10, 224, 320 }
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		Class45.smethod_7(array2);
		Class44.int_1 = array2;
	}

	private static void smethod_19()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "gia ho¹t";
		smethod_5(ref mapNavigationEntry_0, text + "|hµnh thÞ", null, text + "|h«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text2 + "|" + text);
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|cÊp |" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 3 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[8] { 6, 8, 22, 77, 92, 145, 170, 193 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[5] { 5, 21, 23, 167, 171 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[9] { 114, 56, 79, 26, 68, 117, 147, 196, 94 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[12]
				{
					24, 38, 165, 166, 12, 42, 66, 67, 116, 163,
					164, 166
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[12]
				{
					319, 149, 206, 9, 27, 76, 94, 123, 142, 990,
					991, 992
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[8] { 224, 320, 198, 181, 204, 205, 201, 202 }
			}
		});
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text, new int[13]
		{
			875, 322, 321, 75, 336, 340, 144, 93, 124, 152,
			225, 226, 227
		}, 1);
		smethod_7(ref mapNavigationEntry_0, 355, "Phong S| Qu¶|" + text2, "POS|50304,78016, 1|38592,100992, 2|49440,99520, 3|38976,78464, 4|45952,85184, 12h|38592,100992, 9h|49440,99520, 6h|38976,78464, 3h");
		smethod_6(ref mapNavigationEntry_0, 1141, "luyÖn c«ng|cÊp 2|" + text, "T©y §«ng", "KiÕm C\u00b8c T©y §«ng");
		smethod_6(ref mapNavigationEntry_0, 1142, "luyÖn c«ng|cÊp 2|" + text, "TÇn L\u00a8ng 2", "TÇn L\u00a8ng 2");
		smethod_6(ref mapNavigationEntry_0, 1143, "luyÖn c«ng|cÊp 2|" + text, "TÇn L\u00a8ng 3", "TÇn L\u00a8ng 3");
		smethod_6(ref mapNavigationEntry_0, 1147, "luyÖn c«ng|cÊp 3|" + text, "Thæ PhØ §éng 2", "Thæ PhØ §éng 2");
		smethod_6(ref mapNavigationEntry_0, 1148, "luyÖn c«ng|cÊp 3|" + text, "Thæ PhØ §éng 3", "Thæ PhØ §éng 3");
		smethod_6(ref mapNavigationEntry_0, 1155, "luyÖn c«ng|cÊp 3|" + text, "B¹ch V©n ®éng 2", "B¹ch V©n ®éng 2");
		smethod_6(ref mapNavigationEntry_0, 1156, "luyÖn c«ng|cÊp 3|" + text, "B¹ch V©n ®éng 3", "B¹ch V©n ®éng 3");
		smethod_6(ref mapNavigationEntry_0, 1144, "luyÖn c«ng|cÊp 4|" + text, "Th\u00ad¬ng ®éng tÇng 4", "§iÓm Th\u00ad¬ng ®éng tÇng 4");
		smethod_6(ref mapNavigationEntry_0, 1145, "luyÖn c«ng|cÊp 4|" + text, "Th\u00ad¬ng ®éng tÇng 5", "§iÓm Th\u00ad¬ng ®éng tÇng 5");
		smethod_6(ref mapNavigationEntry_0, 1146, "luyÖn c«ng|cÊp 4|" + text, "Th\u00ad¬ng ®éng tÇng 6", "§iÓm Th\u00ad¬ng ®éng tÇng 6");
		smethod_6(ref mapNavigationEntry_0, 1158, "luyÖn c«ng|cÊp 4|" + text, "Th\u00ad¬ng ®éng tÇng 7", "§iÓm Th\u00ad¬ng ®éng tÇng 7");
		smethod_6(ref mapNavigationEntry_0, 1159, "luyÖn c«ng|cÊp 4|" + text, "Th\u00ad¬ng ®éng tÇng 8", "§iÓm Th\u00ad¬ng ®éng tÇng 8");
		smethod_6(ref mapNavigationEntry_0, 1160, "luyÖn c«ng|cÊp 4|" + text, "Th\u00ad¬ng ®éng tÇng 9", "§iÓm Th\u00ad¬ng ®éng tÇng 9");
		smethod_6(ref mapNavigationEntry_0, 1162, "luyÖn c«ng|cÊp 5|" + text, "H\u00adëng Thñy ®éng 2", "H\u00adëng Thñy ®éng 2");
		smethod_6(ref mapNavigationEntry_0, 1163, "luyÖn c«ng|cÊp 5|" + text, "H\u00adëng Thñy ®éng 3", "H\u00adëng Thñy ®éng 3");
		smethod_6(ref mapNavigationEntry_0, 166, "luyÖn c«ng|cÊp 6|" + text, "Thiªn TÇm Th\u00b8p 3", "Thiªn TÇm Th\u00b8p 3");
		smethod_6(ref mapNavigationEntry_0, 1165, "luyÖn c«ng|cÊp 6|" + text, "Thiªn TÇm Th\u00b8p 4", "Thiªn TÇm Th\u00b8p 4");
		smethod_6(ref mapNavigationEntry_0, 1166, "luyÖn c«ng|cÊp 6|" + text, "Thiªn TÇm Th\u00b8p 5", "Thiªn TÇm Th\u00b8p 5");
		smethod_6(ref mapNavigationEntry_0, 1116, "luyÖn c«ng|cÊp 7|" + text, "L©m Du 2", "L©m Du 2");
		smethod_6(ref mapNavigationEntry_0, 1117, "luyÖn c«ng|cÊp 7|" + text, "L©m Du 3", "L©m Du 3");
		smethod_6(ref mapNavigationEntry_0, 1118, "luyÖn c«ng|cÊp 7|" + text, "L©m Du 4", "L©m Du 4");
		smethod_6(ref mapNavigationEntry_0, 1120, "luyÖn c«ng|cÊp 7|" + text, "L·o Hæ §éng 6", "L·o Hæ §éng 6");
		smethod_6(ref mapNavigationEntry_0, 1121, "luyÖn c«ng|cÊp 7|" + text, "L·o Hæ §éng 7", "L·o Hæ §éng 7");
		smethod_6(ref mapNavigationEntry_0, 1122, "luyÖn c«ng|cÊp 7|" + text, "L·o Hæ §éng 8", "L·o Hæ §éng 8");
		smethod_6(ref mapNavigationEntry_0, 1149, "luyÖn c«ng|cÊp 7|" + text, "L©m Du Phong", "L©m Du Phong");
		smethod_6(ref mapNavigationEntry_0, 990, "luyÖn c«ng|cÊp 7|" + text, "L©m Du §·ng", "L©m Du §·ng");
		smethod_6(ref mapNavigationEntry_0, 991, "luyÖn c«ng|cÊp 7|" + text, "L©m Du Ngo¹n", "L©m Du Ngo¹n");
		smethod_6(ref mapNavigationEntry_0, 992, "luyÖn c«ng|cÊp 7|" + text, "L©m Du D\u00ad¬ng", "L©m Du D\u00ad¬ng");
		smethod_6(ref mapNavigationEntry_0, 1157, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", " (20)", "B¹ch V©n ®éng");
		smethod_6(ref mapNavigationEntry_0, 1161, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "3 (40)", "§iÓm Th\u00ad¬ng 3");
		smethod_6(ref mapNavigationEntry_0, 1164, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "Thñy ®éng (50)", "H\u00adëng Thñy ®éng");
		smethod_6(ref mapNavigationEntry_0, 1167, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "Th\u00b8p 1 (50)", "Thiªn TÇm Th\u00b8p 1");
		smethod_6(ref mapNavigationEntry_0, 1119, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "1 (PK)", "L©m Du PhÝ 1");
		smethod_6(ref mapNavigationEntry_0, 1168, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "2 (PK)", "L©m Du PhÝ 2");
		smethod_6(ref mapNavigationEntry_0, 1169, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "3 (PK)", "L©m Du PhÝ 3");
		smethod_6(ref mapNavigationEntry_0, 1170, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "4 (PK)", "L©m Du PhÝ 4");
		smethod_6(ref mapNavigationEntry_0, 1153, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "PhÝ 1 (No PK)", "L©m Du PhÝ 1");
		smethod_6(ref mapNavigationEntry_0, 1154, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "PhÝ 2 (No PK)", "L©m Du PhÝ 2");
		smethod_6(ref mapNavigationEntry_0, 1004, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "Cèc (90)", "TÝch HuyÕt Cèc");
		smethod_6(ref mapNavigationEntry_0, 1005, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "S¬n (90)", "Thiªn Phô S¬n");
		smethod_6(ref mapNavigationEntry_0, 1006, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "Nhai (90)", "Thùc Cèt Nhai");
		smethod_6(ref mapNavigationEntry_0, 1007, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "Nh©n Cèc (90)", "\u00b8c Nh©n Cèc");
		smethod_6(ref mapNavigationEntry_0, 1008, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "Bµn Long S¬n (90)", "Bµn Long S¬n");
		smethod_6(ref mapNavigationEntry_0, 1009, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "§Þa MÉu S\u00b8t (90)", "§Þa MÉu S\u00b8t");
		smethod_6(ref mapNavigationEntry_0, 1010, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "UyÓn Phông S\u00b8t (90)", "UyÓn Phông S\u00b8t");
		smethod_6(ref mapNavigationEntry_0, 1011, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "Thanh Long", "Thanh Long S\u00b8t");
		smethod_6(ref mapNavigationEntry_0, 1012, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "Hßa B×nh Cèc 1", "Hßa B×nh Cèc 1");
		smethod_6(ref mapNavigationEntry_0, 1171, "Trang k|Trang k|Trang k|Trang k|Trang k|Thu Ph", "Hßa B×nh Cèc 2", "Hßa B×nh Cèc 2");
		smethod_6(ref mapNavigationEntry_0, 336, "Phong L|" + text2, "Phong L");
		smethod_6(ref mapNavigationEntry_0, 977, "nh Trèn| Qu¶|" + text2 + "|" + text, null, "B¶n §å Hßa B×nh");
	}

	private static void smethod_20(bool bool_0 = false)
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string string_ = "cÊp 90|" + text;
		smethod_5(ref mapNavigationEntry_0, text + "|hµnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|èng Kim");
		smethod_6(ref mapNavigationEntry_0, 997, string_, "¬n T©y");
		smethod_6(ref mapNavigationEntry_0, 998, string_, "¬n §«ng");
		smethod_3(ref mapNavigationEntry_0, string_);
		smethod_4(ref mapNavigationEntry_0, "Õn n¬i luyÖn c|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[2] { 7, 19 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 8, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 171, 172 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 38, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[2] { 56, 117 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[2] { 55, 319 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[3] { 10, 224, 320 }
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		if (bool_0)
		{
			smethod_8(ref mapNavigationEntry_0, 959, "ChiÕn Long|" + text);
		}
	}

	private static void smethod_21()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		int[,] array = new int[5, 2];
		Class10.smethod_4(array, 145185);
		int[,] array2 = array;
		int[] array3 = new int[7] { 11, 78, 1, 162, 37, 80, 176 };
		for (int i = 0; i < array2.GetLength(0); i++)
		{
			Array.Resize(ref array3, array3.Length + 1);
			array3[array3.Length - 1] = array2[i, 1];
		}
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", array3, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "Tèng Ki|" + text);
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text, new int[21]
		{
			322, 321, 875, 75, 227, 225, 226, 336, 340, 144,
			93, 124, 152, 443, 444, 445, 419, 446, 447, 457,
			458
		});
		Class29.smethod_0(ref mapNavigationEntry_0, "B¹ch S¬n §=998|B¹ch S¬n T=997|Sahara=418", "cÊp 90|" + text, 2);
		smethod_4(ref mapNavigationEntry_0, "n n¬i luyÖn c|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[3] { 10, 224, 320 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[3] { 319, 438, 441 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 56, 117, 436 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[6] { 38, 164, 424, 433, 434, 435 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[8] { 171, 172, 421, 422, 423, 430, 431, 432 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[4] { 170, 7, 420, 429 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 7, 19, 71 }
			}
		});
		Class29.smethod_0(ref mapNavigationEntry_0, "H¾c Méc Nhai=995|§¹i Quang Minh=448|Sa M«n Quan=451", "ng 7x|n n¬i luyÖn c|" + text, 1);
		smethod_6(ref mapNavigationEntry_0, 54, text, "Nam Nh¹c");
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_8(ref mapNavigationEntry_0, 959, null, "ChiÕn Long", "ChiÕn Long");
		Class45.smethod_7(array2);
		Class44.int_1 = array2;
	}

	private static void smethod_22()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string string_ = "cÊp 90|" + text;
		smethod_5(ref mapNavigationEntry_0, text + "|hµnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|èng Kim");
		smethod_6(ref mapNavigationEntry_0, 997, string_, "¬n T©y");
		smethod_6(ref mapNavigationEntry_0, 998, string_, "¬n §«ng");
		smethod_3(ref mapNavigationEntry_0, string_);
		smethod_4(ref mapNavigationEntry_0, "Õn n¬i luyÖn c|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 7, 19, 71 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[4] { 8, 170, 429, 420 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[8] { 171, 172, 421, 422, 423, 430, 431, 432 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[6] { 38, 164, 424, 433, 434, 435 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[4] { 56, 117, 436, 983 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[4] { 55, 319, 995, 996 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[8] { 10, 224, 320, 181, 199, 203, 204, 198 }
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_6(ref mapNavigationEntry_0, 54, text, "Nam Nh¹c", "Nam Nh¹c TrÊn");
	}

	private static void smethod_23()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		smethod_5(ref mapNavigationEntry_0, text + "|hµnh thÞ", null, text + "|h«n tr", null, text + "|«n ph\u00b8i", null, text + "|èng Kim");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "n n¬i luyÖn c|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[4] { 7, 19, 71, 3 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[4] { 170, 8, 4, 22 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[5] { 171, 172, 982, 5, 23 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[6] { 981, 24, 38, 164, 182, 42 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[5] { 56, 117, 983, 114, 196 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[7] { 319, 995, 123, 169, 142, 129, 1003 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[10] { 10, 224, 320, 199, 202, 201, 204, 205, 200, 198 }
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
	}

	private static void smethod_24()
	{
		smethod_23();
		string text = "ThÇn hµnh";
		_ = text + "|n n¬i luyÖn c|";
		string text2 = "yªu cÇu LÖnh B|";
		string text3 = string.Empty;
		int num = 1012;
		for (int i = 1012; i <= 1017; i++)
		{
			smethod_6(ref mapNavigationEntry_0, i, text2 + "7x|rang s", "L·o Hæ ®éng " + text3);
			text3 = (i - num + 1).ToString();
		}
		text3 = string.Empty;
		num = 1018;
		for (int j = 1018; j <= 1019; j++)
		{
			smethod_6(ref mapNavigationEntry_0, j, text2 + "7x|rang s", "L©m Du Quan " + text3);
			text3 = (j - num + 1).ToString();
		}
		num = 1024;
		for (int k = 1024; k <= 1019; k++)
		{
			smethod_6(ref mapNavigationEntry_0, k, text2 + "8x|rang s", "Ch©n nói Tam HiÖp " + (k - num + 1));
		}
		smethod_3(ref mapNavigationEntry_0, text2 + "9x", new int[6] { 998, 1020, 1021, 1000, 1001, 1002 });
	}

	private static void smethod_25()
	{
		smethod_23();
		string text = "ThÇn hµnh";
		smethod_3(ref mapNavigationEntry_0, "p 90|" + text, new int[2] { 1026, 1029 });
		smethod_4(ref mapNavigationEntry_0, "n n¬i luyÖn c|" + text, new LevelBracketMapGroup[1]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 1006, 1007 },
				labelPrefix = "4x"
			}
		});
		smethod_6(ref mapNavigationEntry_0, 1022, "å LuyÖn Skill", "Skill");
	}

	private static void smethod_26()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "¹i Thµnh Th|" + text;
		string text3 = "Ho¹t §éng|Ho¹t ®éng|" + text;
		string string_ = "cÊp 90|" + text;
		smethod_5(ref mapNavigationEntry_0, text2 + "|hµnh thÞ", null, text2 + "|h«n tr", null, null, null, text2 + "|èng Kim");
		smethod_6(ref mapNavigationEntry_0, 995, text3 + "|Hoµng Thµn", "POS|59968,99040,B¾c|51456,111880,Nam|60064,110496,§«ng|49536,102400,T©y", "Hoµng Thµnh");
		smethod_6(ref mapNavigationEntry_0, 984, text3 + "|L\u00a8ng Mé", "POS|43360,113376,Thanh Long|40960,113408,Chu T\u00adíc|43392,110944,HuyÒn V|40992,110944,Kú L©n", "TÇn Thñy Hoµng");
		smethod_6(ref mapNavigationEntry_0, 968, text3, "NguyÖt Ca", "NguyÖt Ca §¶o");
		smethod_3(ref mapNavigationEntry_0, string_);
	}

	private static void smethod_27()
	{
		string text = "Õn thµnh thÞ th«n";
		string text2 = "i ®Õn b¶n ®å luyÖn c";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|èng Kim");
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|c«ng tõ cÊp|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[8] { 179, 70, 3, 7, 19, 43, 71, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[9] { 193, 92, 8, 22, 77, 170, 4, 6, 145 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[9] { 167, 21, 23, 171, 5, 41, 90, 91, 180 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[9] { 164, 38, 42, 24, 182, 194, 163, 116, 66 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[8] { 56, 79, 114, 94, 68, 166, 117, 196 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[12]
				{
					319, 72, 123, 125, 142, 169, 206, 995, 1000, 1001,
					1003, 1042
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 181, 198, 202, 203, 10, 204, 205,
					199, 200, 143, 207
				}
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_8(ref mapNavigationEntry_0);
	}

	private static void smethod_28()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		int[,] array = new int[1, 2] { { 78, 989 } };
		smethod_5(ref mapNavigationEntry_0, text + "|thµnh thÞ", null, text + "|Th«n trang", null, text + "|«n ph\u00b8i", null, text + "|èng Kim");
		smethod_6(ref mapNavigationEntry_0, 989, text + "|µnh thÞ", "L¹c D\u00ad¬ng");
		smethod_6(ref mapNavigationEntry_0, 977, text + "|Di|Tróc L©m M«n", "POS|65408,83328,Vµo Map Trªn|52064,101344,Vµo Map D\u00aduíi");
		smethod_6(ref mapNavigationEntry_0, 1080, "90 Thu|" + text, "Hoµ B×n", null, "Hoµ B×n");
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text, new int[12]
		{
			340, 321, 322, 336, 225, 226, 227, 83, 93, 124,
			144, 152
		});
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«n|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 207
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[14]
				{
					319, 9, 55, 27, 72, 76, 80, 120, 123, 129,
					130, 142, 169, 206
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					51, 52, 158, 56, 78, 114, 117, 118, 119, 126,
					127, 128, 147, 26, 166, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					164, 165, 38, 39, 40, 42, 66, 67, 116, 125,
					132, 145, 163, 12, 24, 182, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 41, 21, 122, 6, 23, 91, 135, 168, 171,
					172, 173, 180, 5
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[12]
				{
					193, 92, 8, 22, 74, 77, 90, 136, 141, 145,
					170, 4
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[10] { 179, 70, 3, 7, 14, 19, 43, 71, 83, 73 }
			}
		});
		Class29.smethod_0(ref mapNavigationEntry_0, "s¬n §«ng_s¬n ®«ng_VIP 1=999|s¬n T©y_VIP 2=1000", "90 Thu|" + text, 1);
		smethod_6(ref mapNavigationEntry_0, 1019, "luyÖn c«n|" + text, "L©m Du Quan 2");
		smethod_6(ref mapNavigationEntry_0, 1020, "luyÖn c«n|" + text, "L©m Du Quan 3");
		Class45.smethod_7(array);
		Class44.int_1 = array;
	}

	private static void smethod_29()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_6(ref mapNavigationEntry_0, 977, text + "|Di|Tróc L©m M«n", "POS|65408,83328,Vµo Map Trªn|52064,101344,Vµo Map D\u00aduíi");
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[9] { 7, 19, 3, 43, 179, 14, 70, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[13]
				{
					193, 170, 92, 22, 4, 6, 8, 74, 77, 90,
					136, 141, 145
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 171, 172, 173, 21, 23, 5, 41, 122, 6,
					91, 135, 168, 180
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					182, 42, 24, 164, 165, 38, 39, 40, 66, 67,
					116, 125, 132, 147, 163, 12, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					79, 56, 166, 114, 51, 52, 158, 117, 118, 119,
					126, 127, 128, 148, 26, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[10] { 319, 123, 206, 72, 169, 94, 9, 55, 27, 129 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[15]
				{
					224, 198, 320, 181, 201, 203, 202, 10, 143, 151,
					24, 199, 205, 207, 204
				}
			}
		});
	}

	private static void smethod_30()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "boss H|" + text, new int[18]
		{
			202, 76, 10, 198, 336, 75, 199, 204, 322, 203,
			225, 226, 227, 181, 205, 321, 340, 224
		});
		smethod_3(ref mapNavigationEntry_0, "å 90|Êp 90|" + text, new int[12]
		{
			322, 321, 75, 227, 225, 226, 336, 340, 144, 93,
			124, 152
		});
		smethod_6(ref mapNavigationEntry_0, 341, text, "M¹c B");
		smethod_6(ref mapNavigationEntry_0, 949, null, "KiÕm Gia", null, "KiÕm Gia");
		smethod_9(ref mapNavigationEntry_0, "VËn Tiªu|" + text + "|Hé Tèn|Ýnh N\u00a8n");
		smethod_6(ref mapNavigationEntry_0, 100, text + "|Hé Tèn|Ýnh N\u00a8n", "VËn Tiªu Bang");
		smethod_8(ref mapNavigationEntry_0, 959, null, "ChiÕn Long", "ChiÕn Long");
	}

	private static void smethod_31(bool bool_0 = false)
	{
		string text = "N¬i Muèn";
		string text2 = "LuyÖn C«ng|" + text;
		string text3 = "Ýnh N\u00a8n";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text, null, "B¾c §Èu|" + text3, null, "Hoa Ngu|" + text3, 55);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text2, null, 1);
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[8] { 3, 19, 43, 70, 71, 73, 7, 179 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[8] { 193, 145, 170, 92, 22, 4, 6, 77 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 164, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[7] { 79, 56, 166, 114, 69, 94, 180 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 72, 169 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[7] { 224, 198, 320, 181, 201, 203, 202 }
			}
		});
		string text4 = "TÝnh N\u00a8ng";
		smethod_6(ref mapNavigationEntry_0, 959, "ChiÕn Long|" + text4, "POS|45376,96160,Vò Di S¬n|49536,95840,T\u00adêng V©n §éng|54432,100864,La Tiªu S¬n");
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T");
		smethod_6(ref mapNavigationEntry_0, 55, "§µo Hoa Nguyªn|" + text4, "POS|54112,95456,§µo Hoa Nguyªn", "§µo Hoa Nguyªn");
		smethod_6(ref mapNavigationEntry_0, 336, "L\u00a8ng §é|" + text4, "POS|36751,96679,BÕn 1|41021,93148,BÕn 2|49440,89856,BÕn 3");
		smethod_9(ref mapNavigationEntry_0, text4 + "|VËn Tiªu|Hé Tèn");
		smethod_6(ref mapNavigationEntry_0, 949, "Mª Cung|" + text4, "KiÕm Gia");
		smethod_6(ref mapNavigationEntry_0, 934, "Mª Cung|" + text4, "hiªn Tr");
	}

	private static void smethod_32(bool bool_0 = false)
	{
		string text = "N¬i Muèn";
		string text2 = "Ýnh N\u00a8n|Thao T\u00b8c";
		string text3 = text2 + "|dông thuËt";
		if (bool_0)
		{
			text3 = text + "|" + text3;
		}
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "Tèng Kim|Phong V©n|Tèng-Kim|ng Tèng|" + text3, null, text2);
		smethod_3(ref mapNavigationEntry_0, text + "|å Míi", new int[9] { 917, 918, 919, 920, 921, 922, 923, 924, 950 });
		smethod_3(ref mapNavigationEntry_0, text + "|Êp 9", new int[13]
		{
			336, 75, 93, 322, 321, 227, 225, 226, 340, 144,
			124, 152, 875
		}, 1);
		smethod_4(ref mapNavigationEntry_0, text + "|10 => 80", new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[7] { 203, 181, 320, 224, 198, 202, 201 },
				labelPrefix = "ng 80"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[8] { 19, 3, 43, 179, 7, 70, 71, 73 },
				labelPrefix = "ng 20"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[9] { 170, 22, 4, 6, 92, 8, 193, 145, 77 },
				labelPrefix = "ng 30"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[8] { 171, 172, 173, 5, 23, 41, 21, 167 },
				labelPrefix = "ng 40"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[6] { 165, 164, 38, 24, 42, 182 },
				labelPrefix = "ng 50"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[8] { 166, 79, 196, 94, 114, 68, 180, 56 },
				labelPrefix = "ng 60"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[6] { 319, 55, 72, 169, 123, 206 },
				labelPrefix = "ng 70"
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_6(ref mapNavigationEntry_0, 333, text2, "n T\u00ad Qu\u00b8 Nhai");
		smethod_6(ref mapNavigationEntry_0, 949, text2, "KiÕm Gia");
		smethod_6(ref mapNavigationEntry_0, 934, text2, "Thiªn Tr×");
		smethod_9(ref mapNavigationEntry_0, text2 + "|VËn Tiªu|Hé Tèn");
	}

	private static void smethod_33()
	{
		string text = "ng Kh\u00b8c";
		string text2 = "N¬i Muèn";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text2 + "|µnh thÞ", null, text2 + "|Th«n tr", null, text2 + "|«n ph\u00b8i", null, "èng Kim|" + text2, null, null, null, "Hoa Ngu|" + text, 55);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text2, null, 1);
		smethod_4(ref mapNavigationEntry_0, text2, new LevelBracketMapGroup[1]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[6] { 203, 181, 320, 224, 198, 202 }
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_6(ref mapNavigationEntry_0, 949, "VËn Tiªu - Thanh", "POS|92224,116736,i VËn T|62368,111968,Tr¶ Ti|78912,124288,C\u00adíp Ti");
		smethod_6(ref mapNavigationEntry_0, 968, text, "NguyÖt Ca");
		smethod_6(ref mapNavigationEntry_0, 13, text, "T\u00ad Qu\u00b8 Nh");
	}

	private static void smethod_34()
	{
		string text = "trang - Thµnh";
		string text2 = "luyÖn c«n";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "Tèng - K|" + text);
		smethod_8(ref mapNavigationEntry_0, 959, "ChiÕn Lon|" + text);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text2);
		smethod_6(ref mapNavigationEntry_0, 949, "Êp 90|rang kÕ|rang kÕ|" + text2, "Cung Ki");
		smethod_6(ref mapNavigationEntry_0, 995, "Ho¹t §|Ho¹t ®|Hoµng Thµn", "POS|59968,99040,B¾c|51456,111880,Nam|60064,110496,§«ng|49536,102400,T©y", "Hoµng Thµnh");
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
	}

	private static void smethod_35()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|èng Kim");
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text, new int[13]
		{
			875, 322, 321, 75, 225, 226, 227, 336, 340, 144,
			93, 124, 152
		});
		smethod_6(ref mapNavigationEntry_0, 333, "Hoa S¬n|Ho¹t ", "POS|43232,99936,nh KhÝ|43488,93472,gäc N|49984,91328,T\u00ad NiÖm|48480,100992,riÒu D\u00ad¬n", "Hoa S¬n ChiÕn");
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
	}

	private static void smethod_36()
	{
		string text = "thÇn hµnh";
		string text2 = "luyÖn c«ng";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text, "POS|41600,88128,1|44192,91040,2|43840,85600,3|46816,88864,4");
		smethod_6(ref mapNavigationEntry_0, 978, "TÇn L\u00a8ng §¹i ChiÕn|" + text, "POS |40608,112032,§iÓm TËp KÕt 1|42208,110432,§iÓm TËp KÕt 2|43648,112032,§iÓm TËp KÕt 3|42112,113568,§iÓm TËp KÕt 4");
		smethod_6(ref mapNavigationEntry_0, 539, null, null, "Tr\u00adêng Ca M«n c", "Ca M«n");
		smethod_6(ref mapNavigationEntry_0, 998, null, null, "Hoa S¬n ChiÕn", "S¬n Chi");
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[10] { 179, 70, 3, 7, 14, 19, 43, 71, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[12]
				{
					193, 92, 8, 22, 74, 77, 90, 136, 141, 145,
					170, 4
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 41, 21, 122, 6, 23, 91, 135, 168, 171,
					172, 173, 180, 5
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					164, 165, 38, 39, 40, 42, 66, 67, 116, 125,
					132, 147, 163, 12, 24, 182, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					51, 52, 158, 56, 79, 114, 117, 118, 119, 126,
					127, 128, 148, 26, 166, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[14]
				{
					319, 9, 55, 27, 72, 76, 94, 120, 123, 129,
					130, 142, 169, 206
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 207
				}
			}
		});
	}

	private static void smethod_37()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_7(ref mapNavigationEntry_0, 977, "B\u00b8t Qu\u00b8i|Sinh T|" + text, null, "Trinh S\u00b8t", "1,41600,88128|2,44192,91040|3,43840,85600|4,46816,88864");
		smethod_6(ref mapNavigationEntry_0, 977, "B\u00b8t Qu\u00b8i|Sinh T|" + text, "POS|65444,82714,p T|52254,101007,p D", "B\u00b8t Qu\u00b8i TrËn", null, null, bool_0: false, "Trinh S\u00b8t", "55072,91936,i chuy_ 1|56320,89408,i chuy_ 2|57824,87264,i chuy_ 3|59072,85632,i chuy_ 4|63168,92128,i chuy_ 5|61984,94400,i chuy_ 6|60032,97088,i chuy_ 7|58048,98592,i chuy_ 8|55808,97216,i chuy_ 6h|62144,87776,i chuy_ 12h");
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 207
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[14]
				{
					319, 9, 55, 27, 72, 76, 94, 120, 123, 129,
					130, 142, 169, 206
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					51, 52, 158, 56, 79, 114, 117, 118, 119, 126,
					127, 128, 148, 26, 166, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					164, 165, 38, 39, 40, 42, 66, 67, 116, 125,
					132, 147, 163, 12, 24, 182, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 41, 21, 122, 6, 23, 91, 135, 168, 171,
					172, 173, 180, 5
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[12]
				{
					193, 92, 8, 22, 74, 77, 90, 136, 141, 145,
					170, 4
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[10] { 179, 70, 3, 7, 14, 19, 43, 71, 83, 73 }
			}
		});
	}

	private static void smethod_38()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|èng Kim");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_8(ref mapNavigationEntry_0, 959, "ChiÕn Long", "POS|54243,101038,sè 1|45664,95840,sè 2|49664,95616,sè 3");
	}

	private static void smethod_39()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "n nhanh n¬i|thÇn hµnh|n thµnh thÞ";
		smethod_5(ref mapNavigationEntry_0, text + "|hµnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|èng Kim");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "cµy cÊp|cña t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[2] { 7, 19 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 170, 8 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 171, 172 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 38, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[2] { 117, 56 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[2] { 319, 55 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[3] { 10, 224, 320 }
			}
		});
		smethod_6(ref mapNavigationEntry_0, 333, text, "Hoa-S¬n|Hoa S¬n|", "Hoa S¬n ph\u00b8i");
	}

	private static void smethod_40()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "luyÖn c«ng";
		string text2 = "n¬i ho¹t";
		smethod_5(ref mapNavigationEntry_0, "µnh thÞ|" + text, null, "Th«n tr|" + text, null, "«n ph\u00b8i|" + text, null, "Tèng Ki|" + text2, null, "inh Ngu|" + text2);
		smethod_4(ref mapNavigationEntry_0, text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[5] { 14, 19, 83, 70, 71 },
				labelPrefix = "- 20"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[5] { 4, 8, 22, 74, 77 },
				labelPrefix = "-30"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 5, 6, 23, 91 },
				labelPrefix = "-40"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 12, 24, 38, 42, 194 },
				labelPrefix = "-50"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[5] { 79, 56, 166, 26, 114 },
				labelPrefix = "-60"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[7] { 319, 123, 206, 9, 72, 76, 94 },
				labelPrefix = "- 70"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[7] { 200, 224, 320, 181, 201, 198, 10 },
				labelPrefix = "- 80"
			}
		});
		for (int i = 1031; i <= 1033; i++)
		{
			smethod_6(ref mapNavigationEntry_0, i, "h«ng cã cµy|" + text, "Sa M¹c " + (i - 1031 + 4));
		}
		smethod_3(ref mapNavigationEntry_0, "- 90|" + text);
		smethod_3(ref mapNavigationEntry_0, "- 100|" + text, new int[3] { 921, 922, 923 });
		smethod_3(ref mapNavigationEntry_0, "Méc N|" + text, new int[3] { 917, 918, 924 });
		smethod_3(ref mapNavigationEntry_0, "Uyªn ¦¬ng|" + text2, new int[1] { 989 });
		smethod_3(ref mapNavigationEntry_0, "B¶o Tiªu T|" + text2, new int[1] { 1035 });
	}

	private static void smethod_41()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "luyÖn c«ng";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 1 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[3] { 319, 123, 206 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			}
		});
		string string_ = "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y";
		smethod_7(ref mapNavigationEntry_0, 1000, "Sinh T|" + text, string_);
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text, string_);
	}

	private static void smethod_42()
	{
		string text = "n b¶n ®å luyÖn c«ng|2x - 9x";
		string text2 = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text2 + "|µnh thÞ", null, text2 + "|Th«n tr", null, text2 + "|«n ph\u00b8i", null, text2 + "|èng Kim");
		smethod_4(ref mapNavigationEntry_0, "2x-8x|t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[2] { 19, 7 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[3] { 319, 123, 206 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			}
		});
		smethod_3(ref mapNavigationEntry_0, "cÊp 9|" + text);
		smethod_8(ref mapNavigationEntry_0, 959, "null");
	}

	private static void smethod_43(bool bool_0)
	{
		string text = "thÇn hµnh";
		string text2 = " b¶n ®å luyÖn c«ng";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|èng Kim");
		smethod_3(ref mapNavigationEntry_0, "Êp 9|" + text);
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[2] { 19, 7 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[6] { 79, 56, 166, 118, 196, 147 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[9] { 319, 123, 206, 1000, 1001, 1002, 72, 169, 130 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[4] { 224, 320, 201, 143 }
			}
		});
		smethod_6(ref mapNavigationEntry_0, 995, "Maps VIP|" + text, "POS|50721,102152,1");
		smethod_6(ref mapNavigationEntry_0, 996, "Maps VIP|" + text, "POS|50721,102152,2");
		smethod_6(ref mapNavigationEntry_0, 997, "Maps VIP|" + text, "POS|50721,102152,3");
		smethod_6(ref mapNavigationEntry_0, 998, "Maps VIP|" + text, "POS|50721,102152,4");
		smethod_6(ref mapNavigationEntry_0, 999, "Maps VIP|" + text, "POS|50721,102152,5");
		smethod_6(ref mapNavigationEntry_0, 1000, "Maps VIP|" + text, "POS|50721,102152,6");
		smethod_6(ref mapNavigationEntry_0, 1001, "Maps VIP|" + text, "POS|50721,102152,7");
		smethod_6(ref mapNavigationEntry_0, 1002, "Maps VIP|" + text, "POS|50721,102152,8");
		smethod_6(ref mapNavigationEntry_0, 1003, "Maps VIP|" + text, "POS|50721,102152,9");
		smethod_6(ref mapNavigationEntry_0, 1004, "Maps VIP|" + text, "POS|50721,102152,10");
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_7(ref mapNavigationEntry_0, 989, "m M\u00b8u|" + text, "POS|52480,107296,TrÝ 1|57536,106272,TrÝ 2|58816,114112,TrÝ 3|52800,113376,TrÝ 4");
	}

	private static void smethod_44()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|èng Kim", null, "Þ trÝ k", null, "Þ trÝ k", 55);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[2] { 19, 7 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[3] { 319, 123, 206 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[12]
				{
					224, 198, 320, 181, 201, 10, 204, 203, 199, 202,
					76, 205
				}
			}
		});
	}

	private static void smethod_45()
	{
		smethod_14();
		string text = "lµm nhiÖm v";
		string text2 = "éng PK";
		smethod_9(ref mapNavigationEntry_0, "VËn Tiªu|" + text);
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n|" + text2, "POS|42560,92384,kÕt 1|41376,101952,kÕt 2|49344,102336,kÕt 3");
		smethod_8(ref mapNavigationEntry_0, 959, text2 + "|ChiÕn Long");
		smethod_7(ref mapNavigationEntry_0, 355, text2 + "|Sinh T");
	}

	private static void smethod_46()
	{
		string text = "thÇn hµnh";
		_ = "cÊp 90|" + text;
		int_2 = null;
		mapNavigationEntry_0 = null;
		int[] array = new int[22]
		{
			30, 989, 190, 137, 139, 31, 47, 86, 160, 988,
			986, 242, 243, 244, 245, 246, 247, 60, 61, 112,
			104, 36
		};
		int[,] array2 = new int[array.Length, 2];
		int[] array3 = new int[7] { 11, 78, 1, 162, 37, 80, 176 };
		for (int i = 0; i < array2.GetLength(0); i++)
		{
			array2[i, 0] = 78;
			array2[i, 1] = array[i];
			Array.Resize(ref array3, array3.Length + 1);
			array3[array3.Length - 1] = array2[i, 1];
		}
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ|rang k|rang k|rang k|rang k|rang k", array3, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "Tèng Ki|Trung C|" + text);
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text, new int[12]
		{
			322, 321, 75, 227, 225, 226, 336, 340, 144, 93,
			124, 152
		});
		string text2 = string.Empty;
		for (int j = 0; j < 5; j++)
		{
			text2 += "rang k|";
		}
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[23]
				{
					224, 198, 320, 181, 201, 203, 202, 181, 1042, 1021,
					1071, 1083, 1095, 1178, 1179, 1180, 1181, 1182, 1183, 1255,
					1256, 1257, 1258
				},
				labelPrefix = text2
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[19]
				{
					990, 777, 319, 123, 206, 94, 169, 1069, 1082, 1123,
					1133, 1143, 1153, 1163, 1173, 1251, 1252, 1253, 1254
				},
				labelPrefix = text2
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[15]
				{
					1068, 1079, 79, 56, 166, 114, 1041, 1019, 1122, 1132,
					1142, 1152, 1162, 1172, 1238
				},
				labelPrefix = text2
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[16]
				{
					-1676184685, 26819309, -688093359, 98355533, 1476210104, -1088300636, 1999788603, 109681648, -931698380, -862555076,
					1131, 1141, 1151, 1161, 1171, 1237
				},
				labelPrefix = text2
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[16]
				{
					21, 167, 6, 5, 23, 1058, 1059, 1112, 1113, 1120,
					1130, 1140, 1150, 1160, 1170, 1236
				},
				labelPrefix = text2
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[15]
				{
					92, 4, 193, 170, 1056, 1057, 1038, 1111, 1119, 1129,
					1139, 1149, 1159, 1169, 1235
				},
				labelPrefix = text2
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[14]
				{
					19, 7, 179, 1054, 1055, 1109, 1110, 1118, 1128, 1138,
					1148, 1158, 1168, 1234
				},
				labelPrefix = text2
			}
		});
		Class29.smethod_0(ref mapNavigationEntry_0, Class29.string_0, "Hßa B×nh|" + text, 0, null, 6);
		Class29.smethod_0(ref mapNavigationEntry_0, Class11.smethod_72(Class29.string_1), "cÊp  90|90(new)|90 (new)|" + text, 0, null, 20);
		smethod_6(ref mapNavigationEntry_0, 994, null, "MËt Cèc|Cèc §¹i|c nhËn");
		smethod_6(ref mapNavigationEntry_0, 995, null, "MËt Cèc|Cèc Thµnh|c nhËn");
		smethod_6(ref mapNavigationEntry_0, 713, null, "Qu¶ (s¬)");
		string string_ = "POS|53984,95488,tËp k_Th\u00adîng_ 1|55136,91968,tËp k_Th\u00adîng_ 2|55744,90432,tËp k_Th\u00adîng_ 3|56608,89312,tËp k_Th\u00adîng_ 4|57632,88064,tËp k_Th\u00adîng_ 5|58304,87136,tËp k_Th\u00adîng_ 6|59392,85952,tËp k_Th\u00adîng_ 7|61056,84896,tËp k_Th\u00adîng_ 8|55072,97440,tËp k_Trung_ 1|57152,94912,tËp k_Trung_ 2|61088,89088,tËp k_Trung_ 3|62848,86464,tËp k_Trung_ 4|56832,98816,tËp k_t H¹_ 1|57856,98304,tËp k_t H¹_ 2|59392,97664,tËp k_t H¹_ 3|60448,96128,tËp k_t H¹_ 4|61152,95488,tËp k_t H¹_ 5|61856,94112,tËp k_t H¹_ 6|63072,92096,tËp k_t H¹_ 7|64320,89760,tËp k_t H¹_ 8|";
		smethod_6(ref mapNavigationEntry_0, 977, null, "Qu¶ (trung)", null, "Qu¶ (trung)", null, bool_0: false, "D\u00adîc §iÕm", string_);
		smethod_6(ref mapNavigationEntry_0, 749, null, "Qu¶ (cao)|m s\u00a8n h", null, "Qu¶ (cao)|m s\u00a8n h", null, bool_0: false, "D\u00adîc §iÕm", string_);
		Class45.smethod_7(array2);
		Class44.int_1 = array2;
	}

	private static void smethod_47()
	{
		string text = "ThÇn hµnh";
		string text2 = "§i c\u00b8c ®Þa ®iÓm ®\u00adîc chØ ®Þnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		int[,] array = new int[1, 2] { { 78, 993 } };
		int[] array2 = new int[7] { 470, 78, 1, 162, 37, 80, 176 };
		for (int i = 0; i < array.GetLength(0); i++)
		{
			Array.Resize(ref array2, array2.Length + 1);
			array2[array2.Length - 1] = array[i, 1];
		}
		smethod_5(ref mapNavigationEntry_0, text + "|Thµnh thÞ|ThÊt §¹i Thµnh ThÞ", null, text + " |Th«n trang|Th«n trang", null, text + "|M«n Ph\u00b8i|M«n Ph\u00b8i", null, "Tèng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "®Þa ®iÓm chØ ®Þnh|CÊp 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, text2 + "|®Þa ®iÓm chØ ®Þnh|§i ®Õn n¬i luyÖn c«ng", new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[9] { 19, 7, 3, 43, 179, 14, 70, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[13]
				{
					193, 170, 92, 22, 4, 6, 8, 74, 77, 90,
					136, 141, 145
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 171, 172, 173, 21, 23, 5, 41, 122, 6,
					91, 135, 168, 180
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					182, 42, 24, 164, 165, 38, 39, 40, 66, 67,
					116, 125, 132, 147, 163, 12, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					79, 56, 166, 114, 51, 52, 158, 117, 118, 119,
					126, 127, 128, 148, 26, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[10] { 319, 123, 206, 72, 169, 94, 9, 55, 27, 129 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[15]
				{
					224, 198, 320, 181, 201, 203, 202, 10, 143, 151,
					24, 199, 205, 207, 204
				}
			}
		});
		smethod_6(ref mapNavigationEntry_0, 460, "Thµnh thÞ|§i Côm Thµnh ThÞ 1|Ung Ch©u Thµnh|" + text, "POS|51104,102592,§«ng|50178,99972,T©y|49376,103264 ,Nam|53184,101024 ,B¾c|51104,102592,T©m");
		smethod_6(ref mapNavigationEntry_0, 416, "Thµnh thÞ|§i Côm Thµnh ThÞ 1|L¹c D\u00ad¬ng|" + text, "POS|52448,104704 ,§«ng|50304,100032,T©y| 49376,103264  ,Nam|53184,101024  ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 456, "Thµnh thÞ|§i Côm Thµnh ThÞ 1|M¹c C« Thµnh|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 428, "Thµnh thÞ|§i Côm Thµnh ThÞ 1|T« Ch©u|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 471, "Thµnh thÞ|§i Côm Thµnh ThÞ 1|Gia §Þnh Thµnh|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 520, "Thµnh thÞ|§i Côm Thµnh ThÞ 1|Ph\u00adîng Hoµng Thµnh|" + text, "POS|52448,104704 ,§«ng|50304,100032 ,T©y|49376,103264 ,Nam|61056,100160 ,B¾c|51104,102592 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 521, "Thµnh thÞ|§i Côm Thµnh ThÞ 1|Phó Xu©n Thµnh|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 470, "Thµnh thÞ|§i Côm Thµnh ThÞ 1|§¹i La Thµnh|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 467, "Thµnh thÞ|§i Côm Thµnh ThÞ 1|Cæ Loa Thµnh|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 478, "Thµnh thÞ|§i Côm Thµnh ThÞ 1|Cæ Loa ThÞ|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 468, "Thµnh thÞ|§i Côm Thµnh ThÞ 1|Th\u00a8ng Long Thµnh| " + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 469, "Thµnh thÞ|§i Côm Thµnh ThÞ 1|Hoa L\u00ad Thµnhh| " + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 428, "Thµnh thÞ|§i Côm Thµnh ThÞ 2|T« Ch©u|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 416, "Thµnh thÞ|§i Côm Thµnh ThÞ 2|L¹c D\u00ad¬ng|" + text, "POS|52448,104704 ,§«ng|50304,100032,T©y| 49376,103264  ,Nam|53184,101024  ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 471, "Thµnh thÞ|§i Côm Thµnh ThÞ 2|Gia §Þnh Thµnh|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 520, "Thµnh thÞ|§i Côm Thµnh ThÞ 2|Ph\u00adîng Hoµng Thµnh|" + text, "POS|52448,104704 ,§«ng|50304,100032 ,T©y|49376,103264 ,Nam|61056,100160 ,B¾c|51104,102592 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 521, "Thµnh thÞ|§i Côm Thµnh ThÞ 2|Phó Xu©n Thµnh|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 456, "Thµnh thÞ|§i Côm Thµnh ThÞ 2|M¹c C« Thµnh|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 522, "Thµnh thÞ|§i Côm Thµnh ThÞ 2|Hoµng §Õ Thµnh| " + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 10, "Boss §¹i|Boss §¹i(§éng)|Nh¹n Th¹ch §éng|" + text, "POS|51280,102940,kÕt 1|56805,93690,kÕt 2|61056,100160 ,kÕt 3");
		smethod_6(ref mapNavigationEntry_0, 199, "Boss §¹i|Boss §¹i(§éng)|Vò L\u00a8ng §éng|" + text, "POS|49504,92416 ,kÕt 1|56128,100448 ,kÕt 2|48160,99136  ,kÕt 3");
		smethod_6(ref mapNavigationEntry_0, 202, "Boss §¹i|Boss §¹i(§éng)|Phï Dung §éng|" + text, "POS|51280,102940,kÕt 1|48896,88576  ,kÕt 2|57248,92832  ,kÕt 3");
		smethod_6(ref mapNavigationEntry_0, 205, "Boss §¹i|Boss §¹i(§éng)|D\u00ad¬ng Trung §éng|" + text, "POS|51280,102940,kÕt 1|50720,103136  ,kÕt 2|47808,99328  ,kÕt 3");
		smethod_6(ref mapNavigationEntry_0, 203, "Boss §¹i|Boss §¹i(§éng)|V« Danh §éng|" + text, "POS|51280,102940,kÕt 1|50944,105056  ,kÕt 2|54720,100326  ,kÕt 3");
		smethod_6(ref mapNavigationEntry_0, 200, "Boss §¹i|Boss §¹i(§éng)|Cæ D\u00ad¬ng §éng|" + text, "POS|53376,103168 ,kÕt 1|57152,107712 ,kÕt 2|50080,108000  ,kÕt 3");
	}

	private static void smethod_48()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		int[,] array = new int[7, 2];
		Class10.smethod_4(array, 152727);
		int[,] array2 = array;
		int[] array3 = new int[7] { 11, 78, 1, 162, 37, 80, 176 };
		for (int i = 0; i < array2.GetLength(0); i++)
		{
			Array.Resize(ref array3, array3.Length + 1);
			array3[array3.Length - 1] = array2[i, 1];
		}
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ|rang k|rang k", array3, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "Tèng Ki|Trung C|" + text);
		smethod_6(ref mapNavigationEntry_0, 713, text, "Qu¶ (s¬)");
		smethod_6(ref mapNavigationEntry_0, 1098, text + "|skill", "skill");
		smethod_6(ref mapNavigationEntry_0, 994, null, "MËt Cèc|Cèc §¹i|c nhËn");
		smethod_6(ref mapNavigationEntry_0, 995, null, "MËt Cèc|Cèc Thµnh|c nhËn");
		smethod_6(ref mapNavigationEntry_0, 977, text, "Qu¶ (trung)", null, "Qu¶ (trung)|tËp k", null, bool_0: false, "D\u00adîc §iÕm", "POS|63072,92096, 1_tËp k|62880,86432, 2_tËp k|59168,85888, 3_tËp k|55264,91968, 4_Trang_tËp k|54992,97378, 5_Trang_tËp k|57920,98368, 6_Trang_tËp k|57120,94816, 7_Trang_tËp k|61056,89056, 8_Trang_tËp k|57408,91264, 9_Trang_tËp k|57920,87680,10_Trang_tËp k|61888,94144,11_Trang_tËp k|60999,92584,12_Trang_tËp k|59648,97280,13_Trang_tËp k|59409,96269,14_Trang_tËp k|56864,89312,Th\u00adîng_Trang_tËp k|60928,95840,ch H¹_Trang_tËp k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text, new int[12]
		{
			322, 321, 75, 227, 225, 226, 336, 340, 144, 93,
			124, 152
		});
		smethod_2(ref mapNavigationEntry_0, new int[30]
		{
			1004, 1005, 1006, 1007, 1010, 1011, 1012, 1013, 1022, 1024,
			1025, 1026, 1027, 1028, 1029, 1045, 1046, 1047, 1048, 1049,
			1051, 1052, 1053, 1096, 1099, 1100, 1101, 1102, 1103, 1104
		}, "90(new)|Trang k|Trang k|Trang k|Trang k|Trang k|90new|90 new|90 (new)|" + text);
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[12]
				{
					224, 198, 320, 181, 201, 203, 202, 1042, 1021, 1095,
					1015, 1058
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[8] { 990, 777, 319, 123, 206, 94, 169, 778 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[9] { 79, 56, 166, 114, 1041, 1019, 1020, 1014, 772 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[8] { 182, 164, 38, 42, 24, 1040, 1018, 1114 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[8] { 21, 167, 6, 5, 23, 1058, 1059, 1112 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[7] { 92, 4, 193, 170, 1056, 1057, 1038 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[6] { 19, 7, 179, 1054, 1055, 1110 }
			}
		});
		Class45.smethod_7(array2);
		Class44.int_1 = array2;
	}

	private static void smethod_49()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		int[,] array = new int[5, 2];
		Class10.smethod_4(array, 153414);
		int[,] array2 = array;
		int[] array3 = new int[7] { 11, 78, 1, 162, 37, 80, 176 };
		for (int i = 0; i < array2.GetLength(0); i++)
		{
			Array.Resize(ref array3, array3.Length + 1);
			array3[array3.Length - 1] = array2[i, 1];
		}
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ|rang k|rang k", array3, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "Tèng Ki|Trung C|" + text);
		string string_ = text + "|skill";
		string string_2 = "Vò L\u00a8ng s¬n";
		string text2 = ") Vò L\u00a8ng s¬n ";
		smethod_6(ref mapNavigationEntry_0, 70, string_, string_2);
		smethod_6(ref mapNavigationEntry_0, 1034, string_, "N" + text2 + "1");
		smethod_6(ref mapNavigationEntry_0, 1035, string_, "N" + text2 + "2");
		smethod_6(ref mapNavigationEntry_0, 1036, string_, "NT" + text2 + "1");
		smethod_6(ref mapNavigationEntry_0, 1037, string_, "NT" + text2 + "2");
		smethod_6(ref mapNavigationEntry_0, 1038, string_, "KH" + text2 + "1");
		smethod_6(ref mapNavigationEntry_0, 1039, string_, "KH" + text2 + "2");
		smethod_6(ref mapNavigationEntry_0, 1040, string_, "KH" + text2 + "3");
		smethod_6(ref mapNavigationEntry_0, 1041, string_, "KH" + text2 + "3");
		smethod_6(ref mapNavigationEntry_0, 713, text, "qu¶ s¬|Qu¶ (s¬)");
		smethod_6(ref mapNavigationEntry_0, 977, text, "qu¶ trung|Qu¶ (trung)", null, "Qu¶ (trung)|tËp k", null, bool_0: false, "D\u00adîc §iÕm", "POS|63072,92096, 1_tËp k|62880,86432, 2_tËp k|59168,85888, 3_tËp k|55264,91968, 4_Trang_tËp k|54976,97376, 5_Trang_tËp k|57920,98368, 6_Trang_tËp k|57120,94816, 7_Trang_tËp k|61056,89056, 8_Trang_tËp k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text, new int[12]
		{
			322, 321, 75, 227, 225, 226, 336, 340, 144, 93,
			124, 152
		});
		string string_3 = "90(new)|Trang k|Trang k|Trang k|Trang k|Trang k|90new|90 new|90 (new)|" + text;
		smethod_6(ref mapNavigationEntry_0, 1046, string_3, "");
		smethod_6(ref mapNavigationEntry_0, 1047, string_3, "Sa M¹c Nam Léc");
		smethod_6(ref mapNavigationEntry_0, 1051, string_3, "D\u00ad¬ng Kinh B¾c");
		smethod_6(ref mapNavigationEntry_0, 1050, string_3, "D\u00ad¬ng Kinh Nam");
		smethod_6(ref mapNavigationEntry_0, 1049, string_3, "D\u00ad¬ng Kinh §«ng");
		smethod_6(ref mapNavigationEntry_0, 1048, string_3, "D\u00ad¬ng Kinh T©y");
		smethod_6(ref mapNavigationEntry_0, 1052, string_3, "B×nh Nguyªn §");
		smethod_6(ref mapNavigationEntry_0, 1053, string_3, "B×nh Nguyªn T©y");
		smethod_6(ref mapNavigationEntry_0, 1054, string_3, "B×nh Nguyªn Nam");
		smethod_6(ref mapNavigationEntry_0, 1055, string_3, "B×nh Nguyªn B¾c");
		smethod_6(ref mapNavigationEntry_0, 921, string_3, "VD) TuyÕt S¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 922, string_3, "VD) TuyÕt S¬n B¾c");
		smethod_6(ref mapNavigationEntry_0, 1056, string_3, "VD) TuyÕt S¬n T©y");
		smethod_6(ref mapNavigationEntry_0, 1010, string_3, "TuyÕt S¬n §«ng");
		smethod_6(ref mapNavigationEntry_0, 1011, string_3, "TuyÕt S¬n T©y - L\u00adu Ph\u00adîng");
		smethod_6(ref mapNavigationEntry_0, 1057, string_3, "Vu S¬n §«ng - L\u00adu V«");
		smethod_6(ref mapNavigationEntry_0, 1024, string_3, "ST) Vu S¬n T©y Léc - L\u00adu Sµi");
		smethod_6(ref mapNavigationEntry_0, 999, string_3, "Vu S¬n B¾c - L\u00adu L©m");
		smethod_6(ref mapNavigationEntry_0, 998, string_3, "Vu S¬n Nam - L\u00adu BiÖn");
		smethod_6(ref mapNavigationEntry_0, 1012, string_3, "TuyÕt S¬n Nam - L\u00adu Sµi");
		smethod_6(ref mapNavigationEntry_0, 1013, string_3, "TuyÕt S¬n B¾c - L\u00adu L©m");
		smethod_6(ref mapNavigationEntry_0, 1000, string_3, "Cæ B¹ch S¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 1001, string_3, "Cæ B¹ch S¬n B¾c");
		smethod_6(ref mapNavigationEntry_0, 1002, string_3, "Cæ M¹c Cao QuËt");
		smethod_6(ref mapNavigationEntry_0, 1003, string_3, "Cæ Sa M¹c Mª Cung 1");
		smethod_6(ref mapNavigationEntry_0, 1004, string_3, "Cæ Sa M¹c Mª Cung 2");
		smethod_6(ref mapNavigationEntry_0, 1005, string_3, "Cæ Sa M¹c Mª Cung 3");
		smethod_6(ref mapNavigationEntry_0, 1006, string_3, "Cæ D\u00adîc V\u00ad¬ng ®éng tÇng 4");
		smethod_6(ref mapNavigationEntry_0, 1007, string_3, "Cæ Kháa Lang §éng");
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[12]
				{
					224, 198, 320, 181, 201, 203, 202, 1042, 1021, 1095,
					1015, 1058
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[8] { 319, 123, 206, 94, 169, 990, 777, 778 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[6] { 79, 56, 166, 1020, 1014, 772 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[2] { 19, 7 }
			}
		});
		smethod_6(ref mapNavigationEntry_0, 994, null, "MËt Cèc|Cèc §¹i|c nhËn");
		smethod_6(ref mapNavigationEntry_0, 995, null, "MËt Cèc|Cèc Thµnh|c nhËn");
		Class45.smethod_7(array2);
		Class44.int_1 = array2;
	}

	private static void smethod_50()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		int[,] array = new int[8, 2];
		Class10.smethod_4(array, 154180);
		int[,] array2 = array;
		int[] array3 = new int[7] { 11, 78, 1, 162, 37, 80, 176 };
		for (int i = 0; i < array2.GetLength(0); i++)
		{
			Array.Resize(ref array3, array3.Length + 1);
			array3[array3.Length - 1] = array2[i, 1];
		}
		smethod_6(ref mapNavigationEntry_0, 977, null, "POS|63072,92096, 1|62880,86432, 2|59168,85888, 3|55264,91968, 4|54976,97376, 5|57920,98368, 6|57120,94816, 7|61056,89056, 8", null, "å Ho¹t");
		smethod_2(ref mapNavigationEntry_0, new int[11]
		{
			734, 731, 730, 733, 728, 727, 725, 729, 726, 732,
			714
		}, "cÊp 80|" + text, null, bool_0: false, bool_1: false, Class29.string_2);
		smethod_2(ref mapNavigationEntry_0, new int[10] { 716, 715, 722, 720, 718, 719, 723, 717, 721, 724 }, "cÊp 90|rang k|" + text, null, bool_0: false, bool_1: false, Class29.string_2);
		smethod_2(ref mapNavigationEntry_0, new int[7] { 750, 753, 749, 752, 751, 754, 755 }, "Thµnh Cæ §¹i|" + text, null, bool_0: false, bool_1: false, Class29.string_2);
		smethod_2(ref mapNavigationEntry_0, new int[7] { 11, 78, 1, 162, 37, 80, 176 }, text + "|hµnh ThÞ|b×nh th\u00adêng", null, bool_0: false, bool_1: false, Class29.string_2);
		smethod_2(ref mapNavigationEntry_0, new int[10] { 737, 736, 739, 738, 735, 740, 742, 741, 748, 747 }, "TÝch M«n ph|" + text, null, bool_0: false, bool_1: false, Class29.string_2);
		smethod_5(ref mapNavigationEntry_0, text + "|hµnh th", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "Tèng Ki|" + text);
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text, new int[12]
		{
			322, 321, 75, 227, 225, 226, 336, 340, 144, 93,
			124, 152
		});
		smethod_2(ref mapNavigationEntry_0, new int[2] { 997, 999 }, "n c«ng míi|" + text);
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text, new LevelBracketMapGroup[6]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[4] { 319, 990, 123, 206 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			}
		});
		smethod_6(ref mapNavigationEntry_0, 994, null, "MËt Cèc|Cèc §¹i|c nhËn");
		smethod_6(ref mapNavigationEntry_0, 995, null, "MËt Cèc|Cèc Thµnh|c nhËn");
		Class45.smethod_7(array2);
		Class44.int_1 = array2;
	}

	private static void smethod_51()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|n b¶n ®å luy|" + text, new int[11]
		{
			322, 321, 75, 227, 225, 226, 336, 340, 144, 93,
			152
		});
		int num = 0;
		string text2 = null;
		for (int i = 995; i <= 1005; i++)
		{
			num++;
			smethod_6(string_7: i switch
			{
				1005 => "M¹c Cao 1", 
				1004 => "Tr\u00adêng Ca", 
				_ => "S¬n ®éng " + num, 
			}, mapNavigationEntry_1: ref mapNavigationEntry_0, int_3: i, string_6: "c biÖt|rang k|" + text);
		}
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_8(ref mapNavigationEntry_0);
	}

	private static void smethod_52()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|èng Kim");
		smethod_3(ref mapNavigationEntry_0, "Êp 9|" + text);
		smethod_6(ref mapNavigationEntry_0, 224, "Êp 9|" + text, "Sa M¹c");
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_8(ref mapNavigationEntry_0);
	}

	private static void smethod_53(bool bool_0)
	{
		string text = "thÇn hµnh";
		string text2 = "c luyÖn c|" + text;
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[2] { 19, 7 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[4] { 319, 123, 206, 76 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[11]
				{
					224, 320, 201, 10, 181, 198, 199, 202, 203, 204,
					205
				}
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		if (bool_0)
		{
			smethod_8(ref mapNavigationEntry_0);
			smethod_6(ref mapNavigationEntry_0, 333, "Hoa-S¬n", "Hoa-S¬n", "Hoa-S¬n ph\u00b8i");
		}
	}

	private static void smethod_54(bool bool_0 = false)
	{
		string text = "thÇn hµnh";
		string text2 = "luyÖn c«ng|" + text;
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 207
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[10] { 179, 70, 19, 3, 7, 14, 43, 71, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[12]
				{
					193, 92, 8, 22, 74, 77, 90, 136, 141, 145,
					170, 4
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 41, 21, 122, 6, 23, 91, 135, 168, 171,
					172, 173, 180, 5
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					164, 165, 38, 39, 40, 42, 66, 67, 116, 125,
					132, 147, 182, 194, 24, 163, 12
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					51, 52, 158, 56, 79, 114, 117, 118, 119, 126,
					127, 128, 147, 26, 166, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[14]
				{
					319, 9, 55, 27, 72, 76, 94, 120, 123, 129,
					130, 142, 169, 206
				}
			}
		});
		smethod_6(ref mapNavigationEntry_0, 994, "h ®o¹t B", "POS|51328,109280, 1|52045,102016, 2|58208,101696, 3|58336,109056, 4", "Tranh §o¹t BH");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n", "POS|41216,102784,Cæng Nam|49408,102464,Cæng §«ng|42240,92160,Cæng T©y", "Hoa S¬n ChiÕn");
		smethod_6(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé", "POS|43360,113376,Thanh Long|40960,113408,Chu T\u00adíc|43392,110944,HuyÒn V|40992,110944,Kú L©n", "TÇn Thñy Hoµng");
		smethod_6(ref mapNavigationEntry_0, 539, null, null, "Tr\u00adêng Ca M«n c", "Ca M«n");
		smethod_7(ref mapNavigationEntry_0);
		if (!bool_0)
		{
			smethod_8(ref mapNavigationEntry_0);
		}
	}

	private static void smethod_55()
	{
		string text = "thÇn hµnh";
		string text2 = "luyÖn c«ng";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text2 + "|" + text, new int[12]
		{
			322, 321, 75, 225, 226, 227, 336, 340, 144, 93,
			124, 152
		});
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[15]
				{
					224, 198, 320, 181, 201, 203, 202, 10, 143, 151,
					24, 199, 205, 207, 204
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[9] { 7, 19, 3, 43, 179, 14, 70, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[13]
				{
					193, 170, 92, 22, 4, 6, 8, 74, 77, 90,
					136, 141, 145
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 171, 172, 173, 21, 23, 5, 41, 122, 6,
					91, 135, 168, 180
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					182, 42, 24, 164, 165, 38, 39, 40, 66, 67,
					116, 125, 132, 147, 163, 12, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					79, 56, 166, 114, 51, 52, 158, 117, 118, 119,
					126, 127, 128, 148, 26, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[12]
				{
					319, 123, 206, 72, 169, 94, 9, 55, 27, 129,
					130, 142
				}
			}
		});
		smethod_7(ref mapNavigationEntry_0);
		string text3 = "b¶n ®å míi";
		smethod_6(ref mapNavigationEntry_0, 437, null, null, null, "L©m Du C«n|" + text3);
		smethod_6(ref mapNavigationEntry_0, 224, null, null, null, "Sahara|" + text3);
		smethod_6(ref mapNavigationEntry_0, 1003, null, null, null, "B¹ch S¬n §|" + text3);
		smethod_6(ref mapNavigationEntry_0, 1002, null, null, null, "B¹ch S¬n T|" + text3);
	}

	private static void smethod_56()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 320, 201, 10, 143 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[14]
				{
					319, 9, 55, 27, 72, 76, 94, 120, 123, 129,
					130, 142, 169, 206
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[10] { 179, 70, 3, 7, 14, 19, 43, 71, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[5] { 193, 92, 8, 22, 74 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[5] { 167, 41, 21, 122, 6 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 38, 165, 38, 39, 40 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					51, 52, 158, 56, 79, 114, 117, 118, 119, 126,
					127, 128, 148, 26, 166, 196
				}
			}
		});
	}

	private static void smethod_57()
	{
		smethod_54();
		string text = "thÇn hµnh";
		string text2 = "luyÖn c«ng|" + text;
		string text3 = "dông thuËt|cÊp 90";
		string text4 = "dông thuËt|n¬i luyÖn c|2x ®Õn 8|cÊp ";
		for (int i = 0; i < mapNavigationEntry_0.Length; i++)
		{
			if (mapNavigationEntry_0[i].int_0 == 175)
			{
				ref MapNavigationEntry reference = ref mapNavigationEntry_0[i];
				reference = new MapNavigationEntry
				{
					int_0 = 355,
					string_0 = "§Êu Tr\u00adêng Sinh",
					string_2 = "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464,T©y",
					string_4 = "Sinh T"
				};
				continue;
			}
			string text5 = mapNavigationEntry_0[i].string_4;
			if (text5 == null || text5 == string.Empty)
			{
				continue;
			}
			if (0 > text5.IndexOf("Êp 90|" + text2))
			{
				for (int j = 2; j < 9; j++)
				{
					if (0 <= mapNavigationEntry_0[i].string_4.IndexOf("| " + j + "x"))
					{
						mapNavigationEntry_0[i].string_4 = text4 + j;
						break;
					}
				}
			}
			else
			{
				mapNavigationEntry_0[i].string_4 = text3;
			}
		}
	}

	private static void smethod_58()
	{
		string text = "N¬i Muèn";
		string text2 = "Ýnh N\u00a8n";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text2);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text, null, 1);
		smethod_9(ref mapNavigationEntry_0, "Hé Tèn|VËn Tiªu|" + text2);
		smethod_6(ref mapNavigationEntry_0, 2, text2, "Hoa S¬n");
		smethod_6(ref mapNavigationEntry_0, 934, text2, "Thiªn Tr×|hiªn Tr");
		smethod_6(ref mapNavigationEntry_0, 949, text2, "KiÕm Gia");
	}

	private static void smethod_59()
	{
		string text = "thÇn hµnh";
		string text2 = "luyÖn c«ng|" + text;
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text2, new int[13]
		{
			875, 322, 321, 75, 227, 225, 226, 336, 340, 144,
			93, 124, 152
		});
		smethod_4(ref mapNavigationEntry_0, text2 + "|t©n thñ", new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[7] { 224, 198, 320, 181, 201, 203, 202 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 72, 169 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 179 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[6] { 193, 170, 92, 22, 4, 6 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 38, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[6] { 79, 56, 166, 114, 68, 94 }
			}
		});
		smethod_2(ref mapNavigationEntry_0, new int[8] { 917, 918, 919, 920, 921, 922, 923, 924 }, "Æc biÖt", null, bool_0: false, bool_1: false, "CÈm nang t©n thñ");
	}

	private static void smethod_60()
	{
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, "µnh thÞ", null, "Th«n tr", null, "«n ph\u00b8i", null, "èng Kim");
		smethod_3(ref mapNavigationEntry_0, "Êp 90");
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng", new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[2] { 3, 70 },
				labelPrefix = "[20"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 90, 92 },
				labelPrefix = "[30"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 41, 122 },
				labelPrefix = "[40"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 125, 163 },
				labelPrefix = "[50"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[2] { 9, 56 },
				labelPrefix = "[60"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[2] { 319, 123 },
				labelPrefix = "[70"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[2] { 224, 320 },
				labelPrefix = "[80"
			}
		}, "KÕ|KÕ|KÕ");
		smethod_6(ref mapNavigationEntry_0, 949, null, "KiÕm Gia", null, "KiÕm Gia");
		smethod_6(ref mapNavigationEntry_0, 950, null, "c Lang C", null, "c Lang C");
		smethod_8(ref mapNavigationEntry_0);
	}

	private static void smethod_61()
	{
		string text = "thÇn hµnh";
		string string_ = "M6qwtbQ0rzEBUWY1piDKssaswtbQwMCkxhxMm9ZYgGnjmpDSysNTSxScDu3IB6ozrXE+vK1UwTnj0MpSkLxZjdPhqXkKJRmllSCuQU1IxqEdyRlAgcM7kkEihjUhRYfWHl6Vl67gnAgSMAIA";
		int_2 = null;
		mapNavigationEntry_0 = null;
		string string_2 = text + "|ng MU";
		string text2 = Class11.smethod_72(string_);
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text, null, "Þ trÝ k", null, "Þ trÝ k", 55);
		smethod_3(ref mapNavigationEntry_0, "trªn 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "d\u00adíi 90|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[2] { 19, 7 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[3] { 319, 123, 206 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			}
		});
		Class29.smethod_0(ref mapNavigationEntry_0, text2, string_2);
		smethod_6(ref mapNavigationEntry_0, 998, string_2, "POS|39616,82720,tr\u00b8i|49024,96576,ph¶i");
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_8(ref mapNavigationEntry_0);
	}

	private static void smethod_62()
	{
		string text = "thÇn hµnh";
		string text2 = "c«ng ";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "C«ng 90|cÊp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "10 ®Õn 8|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 203, 181, 320, 224, 198 },
				labelPrefix = text2 + "8"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[4] { 319, 55, 72, 169 },
				labelPrefix = text2 + "7"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[4] { 19, 3, 43, 179 },
				labelPrefix = text2 + "2"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[4] { 170, 22, 4, 6 },
				labelPrefix = text2 + "3"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[5] { 171, 172, 173, 5, 41 },
				labelPrefix = text2 + "4"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[4] { 164, 165, 24, 42 },
				labelPrefix = text2 + "5"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[4] { 166, 79, 196, 94 },
				labelPrefix = text2 + "6"
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_8(ref mapNavigationEntry_0);
	}

	private static void smethod_63()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "luyÖn c|" + text;
		string text3 = "cÊp 90|" + text2;
		string text4 = "Ho¹t ®éng|Ho¹t §éng";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, text3, new int[11]
		{
			340, 321, 322, 225, 226, 227, 75, 93, 124, 152,
			875
		}, -1);
		smethod_4(ref mapNavigationEntry_0, text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 207
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[14]
				{
					319, 9, 55, 27, 72, 76, 94, 120, 123, 129,
					130, 142, 169, 206
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					51, 52, 158, 56, 79, 114, 117, 118, 119, 126,
					127, 128, 148, 26, 166, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					164, 165, 38, 39, 40, 42, 66, 67, 116, 125,
					132, 147, 163, 12, 24, 182, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 41, 21, 122, 6, 23, 91, 135, 168, 171,
					172, 173, 180, 5
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[12]
				{
					193, 92, 8, 22, 74, 77, 90, 136, 141, 145,
					170, 4
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[10] { 179, 70, 3, 7, 14, 19, 43, 71, 83, 73 }
			}
		});
		smethod_8(ref mapNavigationEntry_0, 959, text4, "ChiÕn Long");
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text4, null, "Trinh S\u00b8t", "1,41600,88128|2,44192,91040|3,43840,85600|4,46816,88864");
		smethod_6(ref mapNavigationEntry_0, 336, "Phong L|" + text3, "Phong L");
		smethod_6(ref mapNavigationEntry_0, 989, "Tèng Kim Bang", "POS|49312,101696,Phe Tèng|50240,98720,Phe Kim", "Báo danh TĐBH");
		smethod_6(ref mapNavigationEntry_0, 984, text4 + "|L\u00a8ng Mé", "POS|43360,113376,Thanh Long|40960,113408,Chu T\u00adíc|43392,110944,HuyÒn V|40992,110944,Kú L©n");
		smethod_6(ref mapNavigationEntry_0, 998, text4 + "|Hoa S¬n", "POS|42560,92384,T©y|41376,101952,Nam|49344,102336,§«ng", "Hoa S¬n ChiÕn");
	}

	private static void smethod_64()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text);
		string string_ = "n n¬i luyÖn c|t©n thñ|luyÖn c«ng tõ cÊp|" + text;
		smethod_4(ref mapNavigationEntry_0, string_, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					10, 224, 320, 143, 202, 181, 198, 203, 201, 207,
					204, 199, 205, 200
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[6] { 7, 19, 3, 179, 70, 43 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[7] { 170, 8, 141, 22, 193, 90, 77 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[8] { 171, 172, 41, 21, 167, 173, 23, 135 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[8] { 38, 164, 24, 42, 163, 132, 182, 165 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[7] { 117, 166, 78, 114, 118, 119, 125 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[13]
				{
					319, 998, 123, 995, 996, 55, 206, 142, 94, 169,
					72, 120, 76
				}
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
	}

	private static void smethod_65()
	{
		string text = "Õn thµnh thÞ th«n trÊn|thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		string text2 = "n b¶n ®å lu";
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[7] { 224, 198, 320, 181, 201, 203, 202 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 179 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[6] { 193, 170, 92, 22, 4, 6 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 164, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[6] { 79, 56, 166, 114, 69, 94 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 72, 169 }
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
	}

	private static void smethod_66(string string_6 = null, string string_7 = null)
	{
		string text = "thÇn hµnh";
		string text2 = "B¶n ®å Ho¹|vÞ trÝ kh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_6(ref mapNavigationEntry_0, 355, "å Tranh |NhÆt Qu¶|Boss..|" + text2, "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng_®«ng|38974,78288,T©y", null, null, null, bool_0: false, "Trinh S\u00b8t", "41600,88128,t 1|44192,91040, 2|43991,85652, 3|46769,88730, 4|42975,90954, 5|45876,85596, 6");
		smethod_7(ref mapNavigationEntry_0, 933, "Sinh T|" + text2);
		smethod_6(ref mapNavigationEntry_0, 333, "Hoa S¬n P|" + text2 + "|" + text, "POS|40611,103722,t 1|49472,102368,t 2|41952,92416,t 3");
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text, null, text2, null, text2, 55);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					199, 204, 205, 207, 151, 143, 198, 320, 181, 201,
					202, 203, 224, 10
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[15]
				{
					319, 123, 55, 9, 27, 142, 120, 206, 169, 76,
					72, 68, 94, 319, 319
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[9] { 56, 79, 166, 114, 196, 147, 117, 118, 119 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[10] { 19, 3, 43, 7, 179, 70, 71, 73, 14, 83 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[12]
				{
					193, 8, 170, 92, 22, 4, 74, 77, 90, 136,
					141, 145
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					21, 167, 122, 41, 171, 172, 173, 23, 5, 135,
					6, 91, 168, 180
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[13]
				{
					66, 67, 12, 164, 38, 39, 40, 182, 42, 24,
					116, 125, 132
				}
			}
		});
	}

	private static void smethod_67()
	{
		string text = "n thµnh thÞ vµ th«n tr|thÇn hµnh";
		string text2 = "luyÖn c«ng";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text2, new int[12]
		{
			322, 321, 75, 227, 225, 226, 336, 340, 144, 93,
			124, 152
		});
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[3] { 319, 123, 206 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 71, 7 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[3] { 193, 8, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[3] { 21, 167, 171 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[3] { 182, 164, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T", null, "Sinh T");
		smethod_8(ref mapNavigationEntry_0);
		smethod_6(ref mapNavigationEntry_0, 341, "Th¶o Ng", "n| ");
	}

	private static void smethod_68()
	{
		string text = "n thµnh thÞ vµ th«n tr|thÇn hµnh";
		string text2 = "luyÖn c«ng";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T", null, "Sinh T");
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text2, new int[12]
		{
			322, 321, 75, 227, 225, 226, 336, 340, 144, 93,
			124, 152
		});
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[12]
				{
					319, 123, 206, 9, 27, 55, 69, 76, 94, 120,
					123, 142
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[7] { 19, 71, 7, 70, 179, 71, 43 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[7] { 193, 170, 22, 4, 136, 92, 90 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[8] { 21, 167, 171, 41, 23, 6, 5, 180 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[7] { 182, 164, 24, 165, 147, 132, 125 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[9] { 79, 56, 166, 119, 114, 51, 26, 196, 148 }
			}
		});
		string text3 = "Map Míi";
		string text4 = "L©m du quan 2";
		string text5 = "L©m du quan 3";
		smethod_6(ref mapNavigationEntry_0, 1003, text3, text4, text4, text4 + "|" + text3);
		smethod_6(ref mapNavigationEntry_0, 1004, text3, text5, text5, text5 + "|" + text3);
		string text6 = "Thu Ph";
		smethod_2(ref mapNavigationEntry_0, new int[2] { 1005, 1006 }, "7x|" + text6);
		smethod_2(ref mapNavigationEntry_0, new int[2] { 1008, 1013 }, "8x|" + text6);
		smethod_2(ref mapNavigationEntry_0, new int[7] { 1009, 1014, 1010, 1011, 1012, 1015, 1016 }, "9x|" + text6);
		smethod_8(ref mapNavigationEntry_0);
	}

	private static void smethod_69()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÞ vµ th«n";
		string text2 = "n b¶n ®å luy";
		string string_ = "Map Míi|" + text2;
		_ = "Thu Ph|" + text2;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text, null, "vÞ trÝ kh", null, "vÞ trÝ kh", 55);
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_6(ref mapNavigationEntry_0, 1003, string_, "L©m Du Quan 2", null, "L©m Du Quan 2");
		smethod_6(ref mapNavigationEntry_0, 1004, string_, "L©m Du Quan 3", null, "L©m Du Quan 3");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text2, new int[12]
		{
			322, 321, 75, 227, 225, 226, 336, 340, 144, 93,
			124, 152
		});
		smethod_4(ref mapNavigationEntry_0, "Thu Ph|" + text2, new LevelBracketMapGroup[3]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[2] { 1005, 1006 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[2] { 1008, 1013 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 90,
				mapIds = new int[7] { 1009, 1010, 1011, 1012, 1014, 1015, 1016 }
			}
		});
		smethod_4(ref mapNavigationEntry_0, text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[15]
				{
					1019, 1042, 1043, 319, 123, 206, 9, 27, 55, 68,
					76, 94, 120, 123, 142
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[8] { 19, 71, 7, 70, 179, 71, 43, 14 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[8] { 193, 8, 170, 22, 4, 136, 92, 90 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[8] { 21, 167, 171, 41, 23, 6, 5, 180 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[8] { 182, 164, 24, 165, 164, 147, 132, 125 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[8] { 79, 166, 119, 114, 51, 26, 196, 148 }
			}
		});
	}

	private static void smethod_70()
	{
		string text = "N¬i Muèn";
		string text2 = "luyÖn c«ng|" + text;
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, " 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[6] { 199, 202, 201, 204, 205, 203 },
				labelPrefix = " 80"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[6] { 319, 55, 142, 72, 169, 123 },
				labelPrefix = " 70"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[4] { 140, 7, 70, 2 },
				labelPrefix = " 20"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[4] { 22, 77, 92, 145 },
				labelPrefix = " 30"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 173, 21, 23, 5 },
				labelPrefix = " 40"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[6] { 24, 42, 38, 182, 66, 163 },
				labelPrefix = " 50"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[6] { 117, 166, 79, 196, 56, 94 },
				labelPrefix = " 60"
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_8(ref mapNavigationEntry_0);
	}

	private static void smethod_71()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "p 90|" + text);
		smethod_6(ref mapNavigationEntry_0, 977, text, "h\u00b8i qu¶");
		smethod_6(ref mapNavigationEntry_0, 1018, text, "BÝ C¶nh");
	}

	private static void smethod_72()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		int[,] array = new int[1, 2] { { 78, 993 } };
		int[] array2 = new int[7] { 11, 78, 1, 162, 37, 80, 176 };
		for (int i = 0; i < array.GetLength(0); i++)
		{
			Array.Resize(ref array2, array2.Length + 1);
			array2[array2.Length - 1] = array[i, 1];
		}
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", array2, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "Tèng Ki|" + text);
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text, new int[16]
		{
			1020, 1021, 1022, 875, 322, 321, 75, 225, 226, 227,
			336, 340, 144, 93, 124, 152
		});
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[2] { 7, 19 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[8] { 4, 8, 22, 77, 92, 145, 170, 193 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[5] { 5, 21, 23, 167, 171 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[6] { 24, 38, 66, 116, 163, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[6] { 56, 79, 94, 114, 166, 196 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[8] { 319, 123, 206, 142, 169, 72, 1007, 1008 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			}
		});
		string text2 = "POS|63072,92096, 1_p K|62880,86432, 2_p K|59168,85888, 3_p K|55264,91968, 4_p K|54976,97376, 5_p K|57920,98368, 6_p K|57120,94816, 7_p K|61056,89056, 8_p K";
		smethod_6(ref mapNavigationEntry_0, 977, "Qu¶|" + text, text2, null, null, null, bool_0: false, "D\u00adîc ", text2);
		smethod_6(ref mapNavigationEntry_0, 959, null, "ChiÕn Long", null, "ChiÕn Long");
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		Class45.smethod_7(array);
		Class44.int_1 = array;
	}

	private static void smethod_73()
	{
		string text = "thÇn hµnh";
		string text2 = "|hän N¬i";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text2 + "|µnh thÞ", null, text2 + "|Th«n tr", null, text2 + "|«n ph\u00b8i", null, "èng Kim|" + text2);
		smethod_3(ref mapNavigationEntry_0, "luyÖn c«ng|Êp 90|" + text2, null, 1);
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[8] { 3, 19, 43, 70, 71, 73, 7, 179 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[8] { 193, 145, 170, 92, 22, 4, 6, 77 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 164, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[7] { 79, 56, 166, 114, 69, 94, 180 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 72, 169 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[7] { 224, 198, 320, 181, 201, 203, 202 }
			}
		});
		smethod_6(ref mapNavigationEntry_0, 1, "VËn Tiªu|" + text, "POS|49920,88352");
		smethod_6(ref mapNavigationEntry_0, 978, "TÇn L\u00a8ng §¹i ChiÕn|" + text, "POS |40608,112032,§iÓm TËp KÕt 1|42208,110432,§iÓm TËp KÕt 2|43648,112032,§iÓm TËp KÕt 3|42112,113568,§iÓm TËp KÕt 4");
		smethod_6(ref mapNavigationEntry_0, 355, text + "|Sinh T", "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y");
		smethod_6(ref mapNavigationEntry_0, 959, "ChiÕn Long|" + text, "POS|45376,96160,Vò Di S¬n|49536,95840,T\u00adêng V©n §éng|54432,100864,La Tiªu S¬n");
		string text3 = "TÝnh N\u00a8ng";
		smethod_7(ref mapNavigationEntry_0, 1, text3 + "|Hé Tèng");
	}

	private static void smethod_74()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "2x ®Õn 8x|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[8] { 3, 19, 43, 70, 71, 73, 7, 179 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[8] { 193, 145, 170, 92, 22, 4, 6, 77 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 164, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[7] { 79, 56, 166, 114, 69, 94, 180 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 72, 169 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[7] { 224, 198, 320, 181, 201, 203, 202 }
			}
		});
		smethod_6(ref mapNavigationEntry_0, 355, text + "|Sinh T", "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y");
	}

	private static void smethod_75()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "luyÖn c«ng";
		string text3 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, text + "|«ng Thu Ph", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text3);
		smethod_6(ref mapNavigationEntry_0, 989, "Tèng Kim Bang", "POS|49312,101696,Phe Tèng|50240,98720,Phe Kim", "Báo danh TĐBH");
		smethod_6(ref mapNavigationEntry_0, 322, "cÊp 90|" + text2, "POS|50848,101248,Tr\u00adêng B¹ch s¬n B¾c", "Tr\u00adêng B¹ch s¬n B¾c");
		smethod_6(ref mapNavigationEntry_0, 998, "cÊp 90|" + text2, "POS|50848,101248,Tr\u00adêng B¹ch s¬n B¾c 2", "Tr\u00adêng B¹ch s¬n B¾c 2");
		smethod_6(ref mapNavigationEntry_0, 321, "cÊp 90|" + text2, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam", "Tr\u00adêng B¹ch s¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 997, "cÊp 90|" + text2, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam 2", "Tr\u00adêng B¹ch s¬n Nam 2");
		smethod_6(ref mapNavigationEntry_0, 75, "cÊp 90|" + text2, "POS|57952,96384,Kho¶ Lang ®éng", "Kho¶ Lang ®éng");
		smethod_6(ref mapNavigationEntry_0, 227, "cÊp 90|" + text2, "POS|50816,103584,Sa M¹c 3", "Sa M¹c 3");
		smethod_6(ref mapNavigationEntry_0, 225, "cÊp 90|" + text2, "POS|47168,104800,Sa M¹c 1", "Sa M¹c 1");
		smethod_6(ref mapNavigationEntry_0, 226, "cÊp 90|" + text2, "POS|49920,101888,Sa M¹c 2", "Sa M¹c 2");
		smethod_6(ref mapNavigationEntry_0, 336, "cÊp 90|" + text2, "POS|35968,101984,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_7(ref mapNavigationEntry_0, 340, "cÊp 90|trang kÕ|" + text2, "POS|59040,110016,M¹c Cao QuËt", "M¹c Cao QuËt");
		smethod_7(ref mapNavigationEntry_0, 1000, "cÊp 90|trang kÕ|" + text2, "POS|59040,110016,M¹c Cao QuËt 2", "M¹c Cao QuËt 2");
		smethod_7(ref mapNavigationEntry_0, 144, "cÊp 90|trang kÕ|" + text2, "POS|54112,96640,D\u00adîc V\u00ad¬ng ®éng tÇng 4", "D\u00adîc V\u00ad¬ng ®éng tÇng 4");
		smethod_7(ref mapNavigationEntry_0, 93, "cÊp 90|trang kÕ|" + text2, "POS|48928,101312,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_7(ref mapNavigationEntry_0, 124, "cÊp 90|trang kÕ|" + text2, "POS|53600,109376,C\u00b8n Viªn ®éng", "C\u00b8n Viªn ®éng");
		smethod_7(ref mapNavigationEntry_0, 152, "cÊp 90|trang kÕ|" + text2, "POS|53504,107552,TuyÕt B\u00b8o ®éng tÇng 8", "TuyÕt B\u00b8o ®éng tÇng 8");
		smethod_6(ref mapNavigationEntry_0, 1009, "«ng Thu Ph|" + text, "POS|30944,74016,Tr\u00adêng B¹ch §«ng", "Tr\u00adêng B¹ch §«ng");
		smethod_6(ref mapNavigationEntry_0, 1011, "«ng Thu Ph|" + text, "POS|50656,103680,Sa M¹c Haxara", "Sa M¹c Haxara");
		smethod_6(ref mapNavigationEntry_0, 1010, "«ng Thu Ph|" + text, "POS|59040,110016,M¹c Cao Qu\u00b8", "M¹c Cao Qu\u00b8");
		smethod_6(ref mapNavigationEntry_0, 1008, "«ng Thu Ph|" + text, "POS|36608,99840,Ch©n nói Tr\u00adêng B¹ch 1 - Save T\u00ad¬ng D\u00ad¬ng", "Ch©n nói Tr\u00adêng B¹ch 1 - Save T\u00ad¬ng D\u00ad¬ng");
		smethod_6(ref mapNavigationEntry_0, 1007, "«ng Thu Ph|" + text, "POS|45760,95872,L\u00adìng Thñy ®éng 1 - Save §¹i Lý", "L\u00adìng Thñy ®éng 1 - Save §¹i Lý");
		smethod_6(ref mapNavigationEntry_0, 1004, "«ng Thu Ph|" + text, "POS|51776,115072,L©m Du Quan 2 - BiÖn Kinh", "L©m Du Quan 2 - BiÖn Kinh");
		smethod_6(ref mapNavigationEntry_0, 1005, "«ng Thu Ph|" + text, "POS|51776,115072,L©m Du Quan 3 - §¹i Lý", "L©m Du Quan 3 - §¹i Lý");
		smethod_4(ref mapNavigationEntry_0, "hu vùc luyÖn c«ng|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[10] { 179, 70, 3, 7, 14, 19, 43, 71, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[12]
				{
					193, 92, 8, 22, 74, 77, 90, 136, 141, 145,
					170, 4
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 41, 21, 122, 6, 23, 91, 135, 168, 171,
					172, 173, 180, 5
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					66, 67, 116, 125, 164, 165, 38, 39, 40, 42,
					132, 147, 163, 12, 24, 182, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					51, 52, 158, 56, 79, 114, 117, 118, 119, 126,
					127, 128, 148, 26, 166, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[14]
				{
					319, 9, 55, 27, 72, 76, 94, 120, 123, 129,
					130, 142, 169, 206
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 206
				}
			}
		});
		string text4 = "o¹t §éng";
		smethod_7(ref mapNavigationEntry_0, 355, text4 + "|Sinh T");
		smethod_7(ref mapNavigationEntry_0, 959, text4 + "|ChiÕn Long");
		smethod_6(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé TÇn Thñy Hoµng|" + text4, "POS |43360,113376,Thanh|40960,113408,Chu|43392,110944,HuyÒn|40992,110944,Kú");
	}

	private static void smethod_76()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "luyÖn c«ng";
		string text3 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, text + "|«ng Thu Ph", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text3);
		smethod_6(ref mapNavigationEntry_0, 868, "Thµnh thÞ||T« Ch©u|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 989, "Tèng Kim Bang", "POS|49312,101696,Phe Tèng|50240,98720,Phe Kim", "Báo danh TĐBH");
		smethod_6(ref mapNavigationEntry_0, 869, "Thµnh thÞ|Tr\u00adêng An|" + text, "POS|50336,107424 ,§«ng|47168,101664,T©y|46528,104640,Nam|54528,103552,B¾c|50464,103616 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 870, "Thµnh thÞ|Ch©u Thµnh|" + text, "POS|50336,107424 ,§«ng|47168,101664,T©y|46528,104640,Nam|54528,103552,B¾c|50464,103616 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 322, "cÊp 90|" + text2, "POS|50848,101248,Tr\u00adêng B¹ch s¬n B¾c", "Tr\u00adêng B¹ch s¬n B¾c");
		smethod_6(ref mapNavigationEntry_0, 998, "cÊp 90|" + text2, "POS|50848,101248,Tr\u00adêng B¹ch s¬n B¾c 2", "Tr\u00adêng B¹ch s¬n B¾c 2");
		smethod_6(ref mapNavigationEntry_0, 321, "cÊp 90|" + text2, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam", "Tr\u00adêng B¹ch s¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 997, "cÊp 90|" + text2, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam 2", "Tr\u00adêng B¹ch s¬n Nam 2");
		smethod_6(ref mapNavigationEntry_0, 75, "cÊp 90|" + text2, "POS|57952,96384,Kho¶ Lang ®éng", "Kho¶ Lang ®éng");
		smethod_6(ref mapNavigationEntry_0, 227, "cÊp 90|" + text2, "POS|50816,103584,Sa M¹c 3", "Sa M¹c 3");
		smethod_6(ref mapNavigationEntry_0, 225, "cÊp 90|" + text2, "POS|47168,104800,Sa M¹c 1", "Sa M¹c 1");
		smethod_6(ref mapNavigationEntry_0, 226, "cÊp 90|" + text2, "POS|49920,101888,Sa M¹c 2", "Sa M¹c 2");
		smethod_6(ref mapNavigationEntry_0, 336, "cÊp 90|" + text2, "POS|35968,101984,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_7(ref mapNavigationEntry_0, 340, "cÊp 90|trang kÕ|" + text2, "POS|59040,110016,M¹c Cao QuËt", "M¹c Cao QuËt");
		smethod_7(ref mapNavigationEntry_0, 1000, "cÊp 90|trang kÕ|" + text2, "POS|59040,110016,M¹c Cao QuËt 2", "M¹c Cao QuËt 2");
		smethod_7(ref mapNavigationEntry_0, 144, "cÊp 90|trang kÕ|" + text2, "POS|54112,96640,D\u00adîc V\u00ad¬ng ®éng tÇng 4", "D\u00adîc V\u00ad¬ng ®éng tÇng 4");
		smethod_7(ref mapNavigationEntry_0, 93, "cÊp 90|trang kÕ|" + text2, "POS|48928,101312,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_7(ref mapNavigationEntry_0, 124, "cÊp 90|trang kÕ|" + text2, "POS|53600,109376,C\u00b8n Viªn ®éng", "C\u00b8n Viªn ®éng");
		smethod_7(ref mapNavigationEntry_0, 152, "cÊp 90|trang kÕ|" + text2, "POS|53504,107552,TuyÕt B\u00b8o ®éng tÇng 8", "TuyÕt B\u00b8o ®éng tÇng 8");
		smethod_6(ref mapNavigationEntry_0, 1009, "«ng Thu Ph|" + text, "POS|30944,74016,Tr\u00adêng B¹ch §«ng", "Tr\u00adêng B¹ch §«ng");
		smethod_6(ref mapNavigationEntry_0, 1011, "«ng Thu Ph|" + text, "POS|50656,103680,Sa M¹c Haxara", "Sa M¹c Haxara");
		smethod_6(ref mapNavigationEntry_0, 1010, "«ng Thu Ph|" + text, "POS|59040,110016,M¹c Cao Qu\u00b8", "M¹c Cao Qu\u00b8");
		smethod_6(ref mapNavigationEntry_0, 1008, "«ng Thu Ph|" + text, "POS|36608,99840,Ch©n nói Tr\u00adêng B¹ch 1 - Save T\u00ad¬ng D\u00ad¬ng", "Ch©n nói Tr\u00adêng B¹ch 1 - Save T\u00ad¬ng D\u00ad¬ng");
		smethod_6(ref mapNavigationEntry_0, 1007, "«ng Thu Ph|" + text, "POS|45760,95872,L\u00adìng Thñy ®éng 1 - Save §¹i Lý", "L\u00adìng Thñy ®éng 1 - Save §¹i Lý");
		smethod_6(ref mapNavigationEntry_0, 1004, "«ng Thu Ph|" + text, "POS|51776,115072,L©m Du Quan 2 - BiÖn Kinh", "L©m Du Quan 2 - BiÖn Kinh");
		smethod_6(ref mapNavigationEntry_0, 1005, "«ng Thu Ph|" + text, "POS|51776,115072,L©m Du Quan 3 - §¹i Lý", "L©m Du Quan 3 - §¹i Lý");
		smethod_6(ref mapNavigationEntry_0, 1015, "luyÖn c«ng|luyÖn c«ng 7x|" + text, "POS|49920,101888,L·o Hæ ®éng 2");
		smethod_6(ref mapNavigationEntry_0, 1016, "luyÖn c«ng|luyÖn c«ng 7x|" + text, "POS|49920,101888,L·o Hæ ®éng 3");
		smethod_6(ref mapNavigationEntry_0, 1017, "luyÖn c«ng|luyÖn c«ng 7x|" + text, "POS|49920,101888,L·o Hæ ®éng 4");
		smethod_6(ref mapNavigationEntry_0, 1018, "luyÖn c«ng|luyÖn c«ng 7x|" + text, "POS|49920,101888,L·o Hæ ®éng 5");
		smethod_6(ref mapNavigationEntry_0, 1019, "luyÖn c«ng|luyÖn c«ng 7x|" + text, "POS|49920,101888,L·o Hæ ®éng 6");
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					10, 224, 320, 143, 202, 181, 198, 203, 201, 207,
					204, 199, 205, 200
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[7] { 92, 7, 19, 3, 179, 70, 43 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[7] { 170, 8, 141, 22, 193, 90, 77 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[8] { 171, 172, 41, 21, 167, 173, 23, 135 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[8] { 38, 164, 24, 42, 163, 132, 182, 165 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[7] { 117, 166, 78, 114, 118, 119, 125 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[13]
				{
					319, 998, 123, 995, 996, 55, 206, 142, 94, 169,
					72, 120, 76
				}
			}
		});
		string text4 = "o¹t §éng";
		smethod_7(ref mapNavigationEntry_0, 355, text4 + "|Sinh T");
		smethod_7(ref mapNavigationEntry_0, 959, text4 + "|ChiÕn Long");
		smethod_6(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé TÇn Thñy Hoµng|" + text4, "POS |43360,113376,Thanh|40960,113408,Chu|43392,110944,HuyÒn|40992,110944,Kú");
	}

	private static void smethod_77()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "thÊt thµnh ®¹i chiÕn ";
		string text3 = "chØ ®Þnh";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, text + "|«ng Thu Ph", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text3);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text2);
		smethod_6(ref mapNavigationEntry_0, 868, "Thµnh thÞ||T« Ch©u|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 989, "Tèng Kim Bang", "POS|49312,101696,Phe Tèng|50240,98720,Phe Kim", "Báo danh TĐBH");
		smethod_6(ref mapNavigationEntry_0, 869, "Thµnh thÞ|Tr\u00adêng An|" + text, "POS|50336,107424 ,§«ng|47168,101664,T©y|46528,104640,Nam|54528,103552,B¾c|50464,103616 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 870, "Thµnh thÞ|Ch©u Thµnh|" + text, "POS|50336,107424 ,§«ng|47168,101664,T©y|46528,104640,Nam|54528,103552,B¾c|50464,103616 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 322, "cÊp 90|" + text3, "POS|50848,101248,Tr\u00adêng B¹ch s¬n B¾c", "Tr\u00adêng B¹ch s¬n B¾c");
		smethod_6(ref mapNavigationEntry_0, 998, "cÊp 90|" + text3, "POS|50848,101248,Tr\u00adêng B¹ch s¬n B¾c 2", "Tr\u00adêng B¹ch s¬n B¾c 2");
		smethod_6(ref mapNavigationEntry_0, 321, "cÊp 90|" + text3, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam", "Tr\u00adêng B¹ch s¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 997, "cÊp 90|" + text3, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam 2", "Tr\u00adêng B¹ch s¬n Nam 2");
		smethod_6(ref mapNavigationEntry_0, 75, "cÊp 90|" + text3, "POS|57952,96384,Kho¶ Lang ®éng", "Kho¶ Lang ®éng");
		smethod_6(ref mapNavigationEntry_0, 227, "cÊp 90|" + text3, "POS|50816,103584,Sa M¹c 3", "Sa M¹c 3");
		smethod_6(ref mapNavigationEntry_0, 225, "cÊp 90|" + text3, "POS|47168,104800,Sa M¹c 1", "Sa M¹c 1");
		smethod_6(ref mapNavigationEntry_0, 226, "cÊp 90|" + text3, "POS|49920,101888,Sa M¹c 2", "Sa M¹c 2");
		smethod_6(ref mapNavigationEntry_0, 336, "cÊp 90|" + text3, "POS|35968,101984,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_7(ref mapNavigationEntry_0, 340, "cÊp 90|trang kÕ|" + text3, "POS|59040,110016,M¹c Cao QuËt", "M¹c Cao QuËt");
		smethod_7(ref mapNavigationEntry_0, 1000, "cÊp 90|trang kÕ|" + text3, "POS|59040,110016,M¹c Cao QuËt 2", "M¹c Cao QuËt 2");
		smethod_7(ref mapNavigationEntry_0, 144, "cÊp 90|trang kÕ|" + text3, "POS|54112,96640,D\u00adîc V\u00ad¬ng ®éng tÇng 4", "D\u00adîc V\u00ad¬ng ®éng tÇng 4");
		smethod_7(ref mapNavigationEntry_0, 93, "cÊp 90|trang kÕ|" + text3, "POS|48928,101312,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_7(ref mapNavigationEntry_0, 124, "cÊp 90|trang kÕ|" + text3, "POS|53600,109376,C\u00b8n Viªn ®éng", "C\u00b8n Viªn ®éng");
		smethod_7(ref mapNavigationEntry_0, 152, "cÊp 90|trang kÕ|" + text3, "POS|53504,107552,TuyÕt B\u00b8o ®éng tÇng 8", "TuyÕt B\u00b8o ®éng tÇng 8");
		smethod_6(ref mapNavigationEntry_0, 1009, "«ng Thu Ph|" + text, "POS|30944,74016,Tr\u00adêng B¹ch §«ng", "Tr\u00adêng B¹ch §«ng");
		smethod_6(ref mapNavigationEntry_0, 1011, "«ng Thu Ph|" + text, "POS|50656,103680,Sa M¹c Haxara", "Sa M¹c Haxara");
		smethod_6(ref mapNavigationEntry_0, 1010, "«ng Thu Ph|" + text, "POS|59040,110016,M¹c Cao Qu\u00b8", "M¹c Cao Qu\u00b8");
		smethod_6(ref mapNavigationEntry_0, 1008, "«ng Thu Ph|" + text, "POS|36608,99840,Ch©n nói Tr\u00adêng B¹ch 1 - Save T\u00ad¬ng D\u00ad¬ng", "Ch©n nói Tr\u00adêng B¹ch 1 - Save T\u00ad¬ng D\u00ad¬ng");
		smethod_6(ref mapNavigationEntry_0, 1007, "«ng Thu Ph|" + text, "POS|45760,95872,L\u00adìng Thñy ®éng 1 - Save §¹i Lý", "L\u00adìng Thñy ®éng 1 - Save §¹i Lý");
		smethod_6(ref mapNavigationEntry_0, 1004, "«ng Thu Ph|" + text, "POS|51776,115072,L©m Du Quan 2 - BiÖn Kinh", "L©m Du Quan 2 - BiÖn Kinh");
		smethod_6(ref mapNavigationEntry_0, 1005, "«ng Thu Ph|" + text, "POS|51776,115072,L©m Du Quan 3 - §¹i Lý", "L©m Du Quan 3 - §¹i Lý");
		smethod_6(ref mapNavigationEntry_0, 1015, "luyÖn c«ng|luyÖn c«ng 7x|" + text, "POS|49920,101888,L·o Hæ ®éng 2");
		smethod_6(ref mapNavigationEntry_0, 1016, "luyÖn c«ng|luyÖn c«ng 7x|" + text, "POS|49920,101888,L·o Hæ ®éng 3");
		smethod_6(ref mapNavigationEntry_0, 1017, "luyÖn c«ng|luyÖn c«ng 7x|" + text, "POS|49920,101888,L·o Hæ ®éng 4");
		smethod_6(ref mapNavigationEntry_0, 1018, "luyÖn c«ng|luyÖn c«ng 7x|" + text, "POS|49920,101888,L·o Hæ ®éng 5");
		smethod_6(ref mapNavigationEntry_0, 1019, "luyÖn c«ng|luyÖn c«ng 7x|" + text, "POS|49920,101888,L·o Hæ ®éng 6");
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					10, 224, 320, 143, 202, 181, 198, 203, 201, 207,
					204, 199, 205, 200
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[7] { 92, 7, 19, 3, 179, 70, 43 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[7] { 170, 8, 141, 22, 193, 90, 77 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[8] { 171, 172, 41, 21, 167, 173, 23, 135 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[8] { 38, 164, 24, 42, 163, 132, 182, 165 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[7] { 117, 166, 78, 114, 118, 119, 125 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[13]
				{
					319, 998, 123, 995, 996, 55, 206, 142, 94, 169,
					72, 120, 76
				}
			}
		});
		string text4 = "o¹t §éng";
		smethod_7(ref mapNavigationEntry_0, 355, text4 + "|Sinh T");
		smethod_7(ref mapNavigationEntry_0, 959, text4 + "|ChiÕn Long");
		smethod_6(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé TÇn Thñy Hoµng|" + text4, "POS |43360,113376,Thanh|40960,113408,Chu|43392,110944,HuyÒn|40992,110944,Kú");
	}

	private static void smethod_78()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text2);
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 1 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[3] { 319, 123, 206 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			}
		});
		string text3 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text3, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n|" + text3, "POS|42560,92384,kÕt 1|41376,101952,kÕt 2|49344,102336,kÕt 3");
		smethod_6(ref mapNavigationEntry_0, 1062, "§i §Õn V\u00ad¬ng KhiÕt Thµnh|" + text, "POS| 52064,105408,TËp KÕt 1|44224, 90944,TËp KÕt 2|62336,105376 ,TËp KÕt 3|62144,115936,TËp KÕt 4|54368,110464 ,TËp kÕt 5|57024,107840,TËp kÕt 6|60096,110464,TËp kÕt 7| 57152,113696,TËp kÕt 8");
		smethod_6(ref mapNavigationEntry_0, 355, text3 + "|Sinh T", "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y");
		smethod_7(ref mapNavigationEntry_0, 978, text + "|TÇn", "POS|43232,110944|40736,110720|40608,113888|43712,113888 ");
		smethod_6(ref mapNavigationEntry_0, 523, text, "§i §\u00b8nh B¹c");
	}

	private static void smethod_79()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "|hän N¬i";
		string text2 = "thÇn hµnh";
		smethod_5(ref mapNavigationEntry_0, text2 + text + "|µnh thÞ", null, text2 + text + "|Th«n tr", null, text2 + text + "|«n ph\u00b8i", null, text2 + text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text2);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text2);
		smethod_6(ref mapNavigationEntry_0, 2, "Muèn §Õn|C¬ b¶n 10|10 trë lªn|C¶nh Kü Tr\u00adêng|" + text2, "POS|83264,115232,Hoa S¬n", "Hoa S¬n");
		smethod_6(ref mapNavigationEntry_0, 113, "Muèn §Õn|C¬ b¶n 10|40 trë lªn|ThiÕu L©m|" + text2, "POS|53960,107012,MËt thÊt ThiÕu", "MËt thÊt ThiÕu");
		smethod_6(ref mapNavigationEntry_0, 164, "Muèn §Õn|C¬ b¶n 10|50 trë lªn|tÇng 1|" + text2, "POS|51520,101888 ,Thiªn TÇm th\u00b8p", "Thiªn TÇm th\u00b8p");
		smethod_6(ref mapNavigationEntry_0, 165, "Muèn §Õn|C¬ b¶n 10|50 trë lªn|tÇng 2|" + text2, "POS|46976,100672 ,Thiªn TÇm th\u00b8p", "Thiªn TÇm th\u00b8p");
		smethod_6(ref mapNavigationEntry_0, 166, "Muèn §Õn|C¬ b¶n 10|60 trë lªn|tÇng 3|" + text2, "POS|53089,103144,Thiªn TÇm th\u00b8p", "Thiªn TÇm th\u00b8p");
		smethod_6(ref mapNavigationEntry_0, 319, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|Du Quan|" + text2, "POS|51776,115264,L©m Du Quan", "L©m Du Quan");
		smethod_6(ref mapNavigationEntry_0, 55, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|§µo Hoa Nguyªn|" + text2, "POS|54112,95456,§µo Hoa Nguyªn", "§µo Hoa Nguyªn");
		smethod_6(ref mapNavigationEntry_0, 72, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|§¹i Tï ®éng|" + text2, "POS|58837,103590,§¹i Tï ®éng", "§¹i Tï ®éng");
		smethod_6(ref mapNavigationEntry_0, 169, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|Long Nh·n ®éng|" + text2, "POS|52800,101664,Long Nh·n ®éng", "Long Nh·n ®éng");
		smethod_6(ref mapNavigationEntry_0, 69, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|Thanh Loa|" + text2, "POS|51200,102624,Thanh Loa ®¶o s", "Thanh Loa ®¶o s");
		smethod_6(ref mapNavigationEntry_0, 122, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|L·o Hæ|" + text2, "POS|53280,106432 ,Hoµng Hµ Nguyªn", "Hoµng Hµ Nguyªn");
		smethod_6(ref mapNavigationEntry_0, 206, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|TÇn L\u00a8ng tÇng 2|" + text2, "POS|51200,102912  ,TÇn L\u00a8ng tÇng 2", "TÇn L\u00a8ng tÇng 2");
		smethod_6(ref mapNavigationEntry_0, 142, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|D\u00adîc V\u00ad¬ng ®éng|" + text2, "POS|51200,102912  ,D\u00adîc V\u00ad¬ng ®éng", "D\u00adîc V\u00ad¬ng ®éng");
		smethod_6(ref mapNavigationEntry_0, 1045, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|Thu PhÝ|Quan 1|" + text2, "POS|51776,115264 ,L©m Du Quan 1", "L©m Du Quan 1");
		smethod_6(ref mapNavigationEntry_0, 1040, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|Thu PhÝ|Quan 2|" + text2, "POS|51776,115264 ,L©m Du Quan 2", "L©m Du Quan 2");
		smethod_6(ref mapNavigationEntry_0, 1041, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|Thu PhÝ|Quan 3|" + text2, "POS|51776,115264 ,L©m Du Quan 3", "L©m Du Quan 3");
		smethod_6(ref mapNavigationEntry_0, 1042, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|Thu PhÝ|Quan 4|" + text2, "POS|51776,115264 ,L©m Du Quan 4", "L©m Du Quan 4");
		smethod_6(ref mapNavigationEntry_0, 1043, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|Thu PhÝ|Quan 5|" + text2, "POS|51776,115264 ,L©m Du Quan 5", "L©m Du Quan 5");
		smethod_6(ref mapNavigationEntry_0, 1044, "Muèn §Õn|C¬ b¶n 10|70 trë lªn|Thu PhÝ|Quan 6|" + text2, "POS|51776,115264 ,L©m Du Quan 6", "L©m Du Quan 6");
		smethod_6(ref mapNavigationEntry_0, 203, "Muèn §Õn|C¬ b¶n 10|80 trë lªn|V« Danh ®éng|" + text2, "POS|49563,95875,V« Danh ®éng", "V« Danh ®éng");
		smethod_6(ref mapNavigationEntry_0, 181, "Muèn §Õn|C¬ b¶n 10|80 trë lªn|L\u00adìng Thñy ®éng|" + text2, "POS|50752,102464,L\u00adìng Thñy ®éng", "L\u00adìng Thñy ®éng");
		smethod_6(ref mapNavigationEntry_0, 320, "Muèn §Õn|C¬ b¶n 10|80 trë lªn|Ch©n nói Tr\u00adêng|" + text2, "POS|36608,99712 ,Ch©n nói Tr\u00adêng", "Ch©n nói Tr\u00adêng");
		smethod_6(ref mapNavigationEntry_0, 224, "Muèn §Õn|C¬ b¶n 10|80 trë lªn|Xa m¹c|" + text2, "POS|51776,102848,Sa m¹c ®Þa biÓu", "Sa m¹c ®Þa biÓu");
		smethod_6(ref mapNavigationEntry_0, 174, "Muèn §Õn|C¬ b¶n 10|80 trë lªn|Thanh Khª|" + text2, "POS|47456,98368,Long TuyÒn th«n", "Long TuyÒn th«n");
		smethod_6(ref mapNavigationEntry_0, 20, "Muèn §Õn|C¬ b¶n 10|80 trë lªn|Phï Dung|" + text2, "POS|118432,199424,Giang T©n Th«n", "Giang T©n Th«n");
		smethod_6(ref mapNavigationEntry_0, 207, "Muèn §Õn|C¬ b¶n 10|80 trë lªn|TÇn L\u00a8ng tÇng 3|" + text2, "POS|50912,102560,TÇn L\u00a8ng tÇng 3", "TÇn L\u00a8ng tÇng 3");
		smethod_6(ref mapNavigationEntry_0, 143, "Muèn §Õn|C¬ b¶n 10|80 trë lªn|D\u00adîc V\u00ad¬ng ®éng|" + text2, "POS|49024,104032,D\u00adîc V\u00ad¬ng ®éng", "D\u00adîc V\u00ad¬ng ®éng");
		smethod_6(ref mapNavigationEntry_0, 875, "Muèn §Õn|Êp 90|H¾c Sa ®éng|" + text2, "POS|50432,101664,H¾c Sa ®éng", "H¾c Sa ®éng");
		smethod_6(ref mapNavigationEntry_0, 322, "Muèn §Õn|Êp 90|b¾c|" + text2, "POS|50843,101266,Tr\u00adêng B¹ch s¬n", "Tr\u00adêng B¹ch s¬n");
		smethod_6(ref mapNavigationEntry_0, 321, "Muèn §Õn|Êp 90|nam|" + text2, "POS|30944,74016 ,Tr\u00adêng B¹ch s¬n", "Tr\u00adêng B¹ch s¬n");
		smethod_6(ref mapNavigationEntry_0, 75, "Muèn §Õn|Êp 90|Lang|" + text2, "POS|57952,96384  ,Kho¶ Lang ®éng", "Kho¶ Lang ®éng");
		smethod_6(ref mapNavigationEntry_0, 225, "Muèn §Õn|Êp 90|Sa M¹c 1|" + text2, "POS|57952,96384,Sa M¹c 1", "Sa M¹c 1");
		smethod_6(ref mapNavigationEntry_0, 226, "Muèn §Õn|Êp 90|Sa M¹c 2|" + text2, "POS|49920,101888,Sa M¹c 2", "Sa M¹c 2");
		smethod_6(ref mapNavigationEntry_0, 227, "Muèn §Õn|Êp 90|Sa M¹c 3|" + text2, "POS|50816,103584,Sa M¹c 3", "Sa M¹c 3");
		smethod_6(ref mapNavigationEntry_0, 336, "Muèn §Õn|Êp 90|Phong L\u00a8ng ®é|" + text2, "POS|35968,101984 ,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_6(ref mapNavigationEntry_0, 340, "Muèn §Õn|Êp 90|M¹c Cao QuËt|" + text2, "POS|59040,110016,M¹c Cao QuËt", "M¹c Cao QuËt");
		smethod_6(ref mapNavigationEntry_0, 144, "Muèn §Õn|Êp 90|D\u00adîc V\u00ad¬ng ®éng|" + text2, "POS|54112,96640,D\u00adîc V\u00ad¬ng ®éng", "D\u00adîc V\u00ad¬ng ®éng");
		smethod_6(ref mapNavigationEntry_0, 93, "Muèn §Õn|Êp 90|TiÕn|" + text2, "POS|48928,101312,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 1001, "Muèn §Õn|Maps|TiÕu Ng¹o 1|" + text2, "POS|30944,74016,TiÕu Ng¹o 1", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 1002, "Muèn §Õn|Maps|TiÕu Ng¹o 2|" + text2, "POS|30944,74016,TiÕu Ng¹o 2", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 1003, "Muèn §Õn|Maps|TiÕu Ng¹o 3|" + text2, "POS|51456,101376,TiÕu Ng¹o 3", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 1004, "Muèn §Õn|Maps|TiÕu Ng¹o 4|" + text2, "POS|58688,108960,TiÕu Ng¹o 4", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 1005, "Muèn §Õn|Maps|TiÕu Ng¹o 5|" + text2, "POS|58688,108960,TiÕu Ng¹o 5", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 1006, "Muèn §Õn|Maps|Hßa B×nh 1|" + text2, "POS|58688,108960,Hßa B×nh 1", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 1007, "Muèn §Õn|Maps|Hßa B×nh 2|" + text2, "POS|30944,74016,Hßa B×nh 2", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 1008, "Muèn §Õn|Maps|Hßa B×nh 3|" + text2, "POS|30944,74016,Hßa B×nh 3", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 917, "Muèn §Õn|Maps|HuyÕt|" + text2, "POS|58112,108544,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 918, "Muèn §Õn|Maps|\u00b8c Nh©n Cèc|" + text2, "POS|58112,108544,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 921, "Muèn §Õn|Maps|Thiªn Phô S¬n|" + text2, "POS|49920,99328,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 922, "Muèn §Õn|Maps|Bµn Long S¬n|" + text2, "POS|49920,99328,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 923, "Muèn §Õn|Maps|§Þa MÉu S¬n | " + text2, "POS|64256,130560,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 924, "Muèn §Õn|Maps|Phông| " + text2, "POS|64256,130560,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 998, "Muèn §Õn|Maps|B¹ch| " + text2, "POS|30944,74016,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 336, "PLD|BÕn 1|" + text2, "POS|36672,96512,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_6(ref mapNavigationEntry_0, 336, "PLD|BÕn 2|" + text2, "POS|40864,93088,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_6(ref mapNavigationEntry_0, 336, "PLD|BÕn 3|" + text2, "POS|49440,89856,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_6(ref mapNavigationEntry_0, 325, "Tèng Kim|Tèng|" + text2, "POS|49312,101696,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_6(ref mapNavigationEntry_0, 325, "Tèng Kim|Kim|" + text2, "POS|50240,98720,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_4(ref mapNavigationEntry_0, "¬ b¶n|" + text2 + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[6] { 19, 3, 43, 179, 7, 70 },
				labelPrefix = "20"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[12]
				{
					170, 22, 4, 6, 92, 8, 90, 145, 141, 77,
					136, 74
				},
				labelPrefix = "30"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[10] { 171, 172, 173, 5, 41, 21, 180, 167, 113, 6 },
				labelPrefix = "40"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[7] { 164, 165, 24, 42, 179, 132, 116 },
				labelPrefix = "50"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[5] { 166, 79, 196, 94, 114 },
				labelPrefix = "60"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[9] { 1045, 319, 55, 72, 169, 69, 122, 206, 142 },
				labelPrefix = "80"
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[8] { 203, 181, 320, 224, 174, 20, 207, 143 },
				labelPrefix = "80"
			}
		});
		string text3 = "o¹t §éng";
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text2);
		smethod_7(ref mapNavigationEntry_0, 959, text3 + "|ChiÕn Long");
		smethod_6(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé TÇn Thñy Hoµng|" + text3, "POS |43360,113376,Thanh|40960,113408,Chu|43392,110944,HuyÒn|40992,110944,Kú");
	}

	private static void smethod_80()
	{
		string text = "ThÇn hµnh";
		string text2 = "<HOT>Di chuyÓn ®Õn c\u00b8c ®Þa ®iÓm ®\u00adîc chØ ®Þnh";
		string text3 = "§i ®Õn b¶n ®å luyÖn c«ng";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text2 + "|Thµnh thÞ", null, text2 + "|Th«n trang", null, text2 + "|M«n Ph\u00b8i", null, "Tèng Kim|" + text2);
		smethod_3(ref mapNavigationEntry_0, "CÊp 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, text3 + "|B¶n §å LuyÖn C«ng", new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[9] { 19, 7, 3, 43, 179, 14, 70, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[13]
				{
					193, 170, 92, 22, 4, 6, 8, 74, 77, 90,
					136, 141, 145
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 171, 172, 173, 21, 23, 5, 41, 122, 6,
					91, 135, 168, 180
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					182, 42, 24, 164, 165, 38, 39, 40, 66, 67,
					116, 125, 132, 147, 163, 12, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					79, 56, 166, 114, 51, 52, 158, 117, 118, 119,
					126, 127, 128, 148, 26, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[10] { 319, 123, 206, 72, 169, 94, 9, 55, 27, 129 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[15]
				{
					224, 198, 320, 181, 201, 203, 202, 10, 143, 151,
					24, 199, 205, 207, 204
				}
			}
		});
		smethod_6(ref mapNavigationEntry_0, 1226, text + "|§Êu tr\u00adêng|§i ®Õn", "POS|52544,100864,TËp kÕt Nam|65408,82944 ,TËp kÕt B¾c.");
		smethod_6(ref mapNavigationEntry_0, 1254, "C\u00b8c b¶n ®å luyÖn c«ng yªu cÇu Th«ng Hµnh LÖnh|Khu luyÖn c«ng 7x thu phÝ|" + text, "POS|51520,115520,L©m Du Quan 1", "Thiªn Cæ QuyÕt");
		smethod_6(ref mapNavigationEntry_0, 1258, "C\u00b8c b¶n ®å luyÖn c«ng yªu cÇu Th«ng Hµnh LÖnh|Khu luyÖn c«ng 7x thu phÝ|" + text, "POS|51416,115636,L©m Du Quan 5", "Thiªn Cæ QuyÕt");
		smethod_6(ref mapNavigationEntry_0, 1000, "C\u00b8c b¶n ®å luyÖn c«ng yªu cÇu Th«ng Hµnh LÖnh|Khu luyÖn c«ng 9x thu phÝ|" + text, "POS|47141,104978 ,§Þa Giíi  1", "Thiªn Cæ QuyÕt");
		smethod_6(ref mapNavigationEntry_0, 1001, "C\u00b8c b¶n ®å luyÖn c«ng yªu cÇu Th«ng Hµnh LÖnh|Khu luyÖn c«ng 9x thu phÝ|" + text, "POS|49920,101888 ,Trung Giíi 1", "Thiªn Cæ QuyÕt");
		smethod_6(ref mapNavigationEntry_0, 1002, "C\u00b8c b¶n ®å luyÖn c«ng yªu cÇu Th«ng Hµnh LÖnh|Khu luyÖn c«ng 9x thu phÝ|" + text, "POS|50732,103926,Thiªn Giíi 1", "Thiªn Cæ QuyÕt");
		smethod_7(ref mapNavigationEntry_0, 1020, "C\u00b8c b¶n ®å luyÖn c«ng yªu cÇu Th«ng Hµnh LÖnh|Khu luyÖn c«ng 9x thu phÝ|Trang Sau|" + text, "POS|59022,110170 ,QuËt Cao M¹c 1", "Thiªn Cæ QuyÕt");
		smethod_7(ref mapNavigationEntry_0, 1021, "C\u00b8c b¶n ®å luyÖn c«ng yªu cÇu Th«ng Hµnh LÖnh|Khu luyÖn c«ng 9x thu phÝ|Trang Sau|" + text, "POS |59038,110102 ,QuËt Cao M¹c 2", "Thiªn Cæ QuyÕt");
		smethod_7(ref mapNavigationEntry_0, 1273, "C\u00b8c b¶n ®å luyÖn c«ng yªu cÇu Th«ng Hµnh LÖnh|Khu luyÖn c«ng 9x thu phÝ|Trang Sau|" + text, "POS|59040,110016 ,QuËt Cao M¹c 3", "Thiªn Cæ QuyÕt");
		smethod_7(ref mapNavigationEntry_0, 998, "C\u00b8c b¶n ®å luyÖn c«ng yªu cÇu Th«ng Hµnh LÖnh|Khu luyÖn c«ng 9x thu phÝ|Trang Sau|" + text, "POS|30944,74016,Tr\u00adêng B¹ch S¬n §«ng 1", "Thiªn Cæ QuyÕt");
		smethod_7(ref mapNavigationEntry_0, 1271, "C\u00b8c b¶n ®å luyÖn c«ng yªu cÇu Th«ng Hµnh LÖnh|Khu luyÖn c«ng 9x thu phÝ|Trang Sau|Trang Sau|" + text, "POS|30944,74016 ,Tr\u00adêng B¹ch S¬n §«ng 2", "Thiªn Cæ QuyÕt");
		smethod_7(ref mapNavigationEntry_0, 1272, "C\u00b8c b¶n ®å luyÖn c«ng yªu cÇu Th«ng Hµnh LÖnh|Khu luyÖn c«ng 9x thu phÝ|Trang Sau|Trang Sau|" + text, "POS|30944,74016 ,Tr\u00adêng B¹ch S¬n §«ng 3", "Thiªn Cæ QuyÕt");
		smethod_8(ref mapNavigationEntry_0);
	}

	private static void smethod_81()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "ö dông ®Õn";
		string text2 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text2);
		smethod_6(ref mapNavigationEntry_0, 989, "Tèng Kim Bang", "POS|49312,101696,Phe Tèng|50240,98720,Phe Kim", "Báo danh TĐBH");
		smethod_6(ref mapNavigationEntry_0, 322, "cÊp 90|" + text, "POS|50848,101248,Tr\u00adêng B¹ch s¬n B¾c", "Tr\u00adêng B¹ch s¬n B¾c");
		smethod_6(ref mapNavigationEntry_0, 998, "cÊp 90|" + text, "POS|50848,101248,Tr\u00adêng B¹ch s¬n B¾c 2", "Tr\u00adêng B¹ch s¬n B¾c 2");
		smethod_6(ref mapNavigationEntry_0, 321, "cÊp 90|" + text, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam", "Tr\u00adêng B¹ch s¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 997, "cÊp 90|" + text, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam 2", "Tr\u00adêng B¹ch s¬n Nam 2");
		smethod_6(ref mapNavigationEntry_0, 75, "cÊp 90|" + text, "POS|57952,96384,Kho¶ Lang ®éng", "Kho¶ Lang ®éng");
		smethod_6(ref mapNavigationEntry_0, 227, "cÊp 90|" + text, "POS|50816,103584,Sa M¹c 3", "Sa M¹c 3");
		smethod_6(ref mapNavigationEntry_0, 225, "cÊp 90|" + text, "POS|47168,104800,Sa M¹c 1", "Sa M¹c 1");
		smethod_6(ref mapNavigationEntry_0, 226, "cÊp 90|" + text, "POS|49920,101888,Sa M¹c 2", "Sa M¹c 2");
		smethod_6(ref mapNavigationEntry_0, 336, "cÊp 90|" + text, "POS|35968,101984,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_7(ref mapNavigationEntry_0, 340, "cÊp 90|trang kÕ|" + text, "POS|59040,110016,M¹c Cao QuËt", "M¹c Cao QuËt");
		smethod_7(ref mapNavigationEntry_0, 1000, "cÊp 90|trang kÕ|" + text, "POS|59040,110016,M¹c Cao QuËt 2", "M¹c Cao QuËt 2");
		smethod_7(ref mapNavigationEntry_0, 144, "cÊp 90|trang kÕ|" + text, "POS|54112,96640,D\u00adîc V\u00ad¬ng ®éng tÇng 4", "D\u00adîc V\u00ad¬ng ®éng tÇng 4");
		smethod_7(ref mapNavigationEntry_0, 93, "cÊp 90|trang kÕ|" + text, "POS|48928,101312,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_7(ref mapNavigationEntry_0, 124, "cÊp 90|trang kÕ|" + text, "POS|53600,109376,C\u00b8n Viªn ®éng", "C\u00b8n Viªn ®éng");
		smethod_7(ref mapNavigationEntry_0, 152, "cÊp 90|trang kÕ|" + text, "POS|53504,107552,TuyÕt B\u00b8o ®éng tÇng 8", "TuyÕt B\u00b8o ®éng tÇng 8");
		smethod_6(ref mapNavigationEntry_0, 1021, "Boss TiÓu|" + text, "POS|50144,103232,Thiªn V\u00ad¬ng Bang", "Thiªn V\u00ad¬ng Bang");
		smethod_6(ref mapNavigationEntry_0, 1024, "Boss TiÓu|" + text, "POS|51968,101248,ThiÕu L©m ph\u00b8i", "ThiÕu L©m ph\u00b8i");
		smethod_6(ref mapNavigationEntry_0, 1015, "Boss TiÓu|" + text, "POS|128896,165856,§\u00adêng M«n", "§\u00adêng M«n");
		smethod_6(ref mapNavigationEntry_0, 1018, "Boss TiÓu|" + text, "POS|47712,101664,Ngò §éc Gi\u00b8o", "Ngò §éc Gi\u00b8o");
		smethod_6(ref mapNavigationEntry_0, 1016, "Boss TiÓu|" + text, "POS|62336,157568,Nga My ph\u00b8i", "Nga My ph\u00b8i");
		smethod_6(ref mapNavigationEntry_0, 1019, "Boss TiÓu|" + text, "POS|12896,43552,Thóy Yªn m«n", "Thóy Yªn m«n");
		smethod_6(ref mapNavigationEntry_0, 1022, "Boss TiÓu|" + text, "POS|52608,102880,Thiªn NhÉn gi\u00b8o", "Thiªn NhÉn gi\u00b8o");
		smethod_6(ref mapNavigationEntry_0, 1020, "Boss TiÓu|" + text, "POS|48032,117504,C\u00b8i Bang", "C\u00b8i Bang");
		smethod_6(ref mapNavigationEntry_0, 1017, "Boss TiÓu|" + text, "POS|50944,102592,Vâ §ang ph\u00b8i", "Vâ §ang ph\u00b8i");
		smethod_6(ref mapNavigationEntry_0, 1023, "Boss TiÓu|" + text, "POS|47616,98208,C«n L«n ph\u00b8i", "C«n L«n ph\u00b8i");
		smethod_6(ref mapNavigationEntry_0, 1002, "90 mí|" + text, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam", "Tr\u00adêng B¹ch s¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 1005, "90 mí|" + text, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam", "Tr\u00adêng B¹ch s¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 1006, "90 mí|" + text, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam", "Tr\u00adêng B¹ch s¬n Nam");
		smethod_7(ref mapNavigationEntry_0, 1007, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 2|" + text, "POS|99267,127022,KiÕm C\u00b8c T©y Nam 2", "KiÕm C\u00b8c T©y Nam 2");
		smethod_7(ref mapNavigationEntry_0, 1009, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 2|" + text, "POS|72832,90400,TÇn L\u00a8ng 2", "TÇn L\u00a8ng 2");
		smethod_7(ref mapNavigationEntry_0, 1010, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 3|" + text, "POS|56288,107680,B¹ch V©n §éng 2", "B¹ch V©n §éng 2");
		smethod_7(ref mapNavigationEntry_0, 1011, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 3|" + text, "POS|52192,105344,Thôc C\u00ad¬ng S¬n 2", "Thôc C\u00ad¬ng S¬n 2");
		smethod_7(ref mapNavigationEntry_0, 113, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 4|MËt ThÊt TiÕu L©m|" + text, "POS|53888,107168 ,MËt ThÊt TiÕu L©m", "MËt ThÊt TiÕu L©m");
		smethod_7(ref mapNavigationEntry_0, 149, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 6|" + text, "POS|51520,103040,TuyÕt B\u00b8o §éng tÇng 3", "TuyÕt B\u00b8o ®éng");
		smethod_7(ref mapNavigationEntry_0, 994, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|" + text, "POS|52160,114784,L©m Du Quan 1", "Thiªn Cæ QuyÕt");
		smethod_7(ref mapNavigationEntry_0, 1004, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|" + text, "POS|52160,114784,L©m Du Quan 2", "Thiªn Cæ QuyÕt");
		smethod_7(ref mapNavigationEntry_0, 1013, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|" + text, "POS|52160,114784,L©m Du Quan 3", "§Ønh Quang Minh");
		smethod_7(ref mapNavigationEntry_0, 1014, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|" + text, "POS|52160,114784,L©m Du Quan 4", "§Ønh Quang Minh");
		smethod_7(ref mapNavigationEntry_0, 995, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|trang kÕ|" + text, "POS|54464,107200,L·o Hæ §éng 2", "T\u00ad Qu\u00b8i Nhai");
		smethod_7(ref mapNavigationEntry_0, 996, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|trang kÕ|" + text, "POS|54464,107200,L·o Hæ §éng 3", "H¾c Qu\u00b8i Nhai");
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[10] { 19, 1007, 3, 43, 70, 71, 73, 7, 1009, 179 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[6] { 193, 22, 1010, 92, 1011, 90 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[10] { 21, 167, 41, 91, 122, 113, 23, 8, 170, 180 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[7] { 182, 164, 165, 38, 116, 66, 125 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[7] { 79, 56, 166, 117, 118, 196, 149 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[15]
				{
					319, 993, 994, 1003, 1004, 1012, 1013, 1014, 123, 995,
					996, 206, 72, 169, 130
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[8] { 224, 198, 320, 181, 201, 202, 203, 207 }
			}
		});
		string text3 = "o¹t §éng";
		smethod_7(ref mapNavigationEntry_0, 355, "\u00b8t Qu\u00b8i TrËn §å|" + text);
		smethod_7(ref mapNavigationEntry_0, 959, text3 + "|ChiÕn Long");
		smethod_6(ref mapNavigationEntry_0, 333, "¬n Tam Kú|" + text3, "POS|42560,92384,T©y|41376,101952,Nam|49344,102336,§«ng");
	}

	private static void smethod_82()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text2);
		smethod_6(ref mapNavigationEntry_0, 989, "Tèng Kim Bang", "POS|49312,101696,Phe Tèng|50240,98720,Phe Kim", "Báo danh TĐBH");
		smethod_6(ref mapNavigationEntry_0, 322, "cÊp 90|" + text, "POS|50848,101248,Tr\u00adêng B¹ch s¬n B¾c", "Tr\u00adêng B¹ch s¬n B¾c");
		smethod_6(ref mapNavigationEntry_0, 998, "cÊp 90|" + text, "POS|50848,101248,Tr\u00adêng B¹ch s¬n B¾c 2", "Tr\u00adêng B¹ch s¬n B¾c 2");
		smethod_6(ref mapNavigationEntry_0, 321, "cÊp 90|" + text, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam", "Tr\u00adêng B¹ch s¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 997, "cÊp 90|" + text, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam 2", "Tr\u00adêng B¹ch s¬n Nam 2");
		smethod_6(ref mapNavigationEntry_0, 75, "cÊp 90|" + text, "POS|57952,96384,Kho¶ Lang ®éng", "Kho¶ Lang ®éng");
		smethod_6(ref mapNavigationEntry_0, 227, "cÊp 90|" + text, "POS|50816,103584,Sa M¹c 3", "Sa M¹c 3");
		smethod_6(ref mapNavigationEntry_0, 225, "cÊp 90|" + text, "POS|47168,104800,Sa M¹c 1", "Sa M¹c 1");
		smethod_6(ref mapNavigationEntry_0, 226, "cÊp 90|" + text, "POS|49920,101888,Sa M¹c 2", "Sa M¹c 2");
		smethod_6(ref mapNavigationEntry_0, 336, "cÊp 90|" + text, "POS|35968,101984,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_7(ref mapNavigationEntry_0, 340, "cÊp 90|trang kÕ|" + text, "POS|59040,110016,M¹c Cao QuËt", "M¹c Cao QuËt");
		smethod_7(ref mapNavigationEntry_0, 1000, "cÊp 90|trang kÕ|" + text, "POS|59040,110016,M¹c Cao QuËt 2", "M¹c Cao QuËt 2");
		smethod_7(ref mapNavigationEntry_0, 144, "cÊp 90|trang kÕ|" + text, "POS|54112,96640,D\u00adîc V\u00ad¬ng ®éng tÇng 4", "D\u00adîc V\u00ad¬ng ®éng tÇng 4");
		smethod_7(ref mapNavigationEntry_0, 93, "cÊp 90|trang kÕ|" + text, "POS|48928,101312,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_7(ref mapNavigationEntry_0, 124, "cÊp 90|trang kÕ|" + text, "POS|53600,109376,C\u00b8n Viªn ®éng", "C\u00b8n Viªn ®éng");
		smethod_7(ref mapNavigationEntry_0, 152, "cÊp 90|trang kÕ|" + text, "POS|53504,107552,TuyÕt B\u00b8o ®éng tÇng 8", "TuyÕt B\u00b8o ®éng tÇng 8");
		smethod_6(ref mapNavigationEntry_0, 1021, "Boss TiÓu|" + text, "POS|50144,103232,Thiªn V\u00ad¬ng Bang", "Thiªn V\u00ad¬ng Bang");
		smethod_6(ref mapNavigationEntry_0, 1024, "Boss TiÓu|" + text, "POS|51968,101248,ThiÕu L©m ph\u00b8i", "ThiÕu L©m ph\u00b8i");
		smethod_6(ref mapNavigationEntry_0, 1015, "Boss TiÓu|" + text, "POS|128896,165856,§\u00adêng M«n", "§\u00adêng M«n");
		smethod_6(ref mapNavigationEntry_0, 1018, "Boss TiÓu|" + text, "POS|47712,101664,Ngò §éc Gi\u00b8o", "Ngò §éc Gi\u00b8o");
		smethod_6(ref mapNavigationEntry_0, 1016, "Boss TiÓu|" + text, "POS|62336,157568,Nga My ph\u00b8i", "Nga My ph\u00b8i");
		smethod_6(ref mapNavigationEntry_0, 1019, "Boss TiÓu|" + text, "POS|12896,43552,Thóy Yªn m«n", "Thóy Yªn m«n");
		smethod_6(ref mapNavigationEntry_0, 1022, "Boss TiÓu|" + text, "POS|52608,102880,Thiªn NhÉn gi\u00b8o", "Thiªn NhÉn gi\u00b8o");
		smethod_6(ref mapNavigationEntry_0, 1020, "Boss TiÓu|" + text, "POS|48032,117504,C\u00b8i Bang", "C\u00b8i Bang");
		smethod_6(ref mapNavigationEntry_0, 1017, "Boss TiÓu|" + text, "POS|50944,102592,Vâ §ang ph\u00b8i", "Vâ §ang ph\u00b8i");
		smethod_6(ref mapNavigationEntry_0, 1023, "Boss TiÓu|" + text, "POS|47616,98208,C«n L«n ph\u00b8i", "C«n L«n ph\u00b8i");
		smethod_6(ref mapNavigationEntry_0, 1002, "90 mí|" + text, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam", "Tr\u00adêng B¹ch s¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 1005, "90 mí|" + text, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam", "Tr\u00adêng B¹ch s¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 1006, "90 mí|" + text, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam", "Tr\u00adêng B¹ch s¬n Nam");
		smethod_7(ref mapNavigationEntry_0, 1007, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 2|" + text, "POS|99267,127022,KiÕm C\u00b8c T©y Nam 2", "KiÕm C\u00b8c T©y Nam 2");
		smethod_7(ref mapNavigationEntry_0, 1009, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 2|" + text, "POS|72832,90400,TÇn L\u00a8ng 2", "TÇn L\u00a8ng 2");
		smethod_7(ref mapNavigationEntry_0, 1010, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 3|" + text, "POS|56288,107680,B¹ch V©n §éng 2", "B¹ch V©n §éng 2");
		smethod_7(ref mapNavigationEntry_0, 1011, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 3|" + text, "POS|52192,105344,Thôc C\u00ad¬ng S¬n 2", "Thôc C\u00ad¬ng S¬n 2");
		smethod_7(ref mapNavigationEntry_0, 149, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 6|" + text, "POS|51520,103040,TuyÕt B\u00b8o §éng tÇng 3", "TuyÕt B\u00b8o ®éng");
		smethod_7(ref mapNavigationEntry_0, 993, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|" + text, "POS|52160,114784,L©m Du Quan 2", "Thiªn Cæ QuyÕt");
		smethod_7(ref mapNavigationEntry_0, 994, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|" + text, "POS|52160,114784,L©m Du Quan 3", "§Ønh Quang Minh");
		smethod_7(ref mapNavigationEntry_0, 1003, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|" + text, "POS|52160,114784,L©m Du Quan 4", "§Ønh Quang Minh");
		smethod_7(ref mapNavigationEntry_0, 1004, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|" + text, "POS|52160,114784,L©m Du Quan 5", "§Ønh Quang Minh");
		smethod_7(ref mapNavigationEntry_0, 1012, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|" + text, "POS|52160,114784,L©m Du Quan 6", "§Ønh Quang Minh");
		smethod_7(ref mapNavigationEntry_0, 1013, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|" + text, "POS|52160,114784,L©m Du Quan 7", "§Ønh Quang Minh");
		smethod_7(ref mapNavigationEntry_0, 1014, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|" + text, "POS|52160,114784,L©m Du Quan 8", "§Ønh Quang Minh");
		smethod_7(ref mapNavigationEntry_0, 995, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|trang kÕ|" + text, "POS|54464,107200,L·o Hæ §éng 2", "T\u00ad Qu\u00b8i Nhai");
		smethod_7(ref mapNavigationEntry_0, 996, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|trang kÕ|" + text, "POS|54464,107200,L·o Hæ §éng 3", "H¾c Qu\u00b8i Nhai");
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[10] { 19, 1007, 3, 43, 70, 71, 73, 7, 1009, 179 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[6] { 193, 22, 1010, 92, 1011, 90 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[10] { 21, 167, 41, 91, 122, 113, 23, 8, 170, 180 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[7] { 182, 164, 165, 38, 116, 66, 125 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[7] { 79, 56, 166, 117, 118, 196, 149 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[15]
				{
					319, 993, 994, 1003, 1004, 1012, 1013, 1014, 123, 995,
					996, 206, 72, 169, 130
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[8] { 224, 198, 320, 181, 201, 202, 203, 207 }
			}
		});
		string text3 = "o¹t §éng";
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_7(ref mapNavigationEntry_0, 959, text3 + "|ChiÕn Long");
		smethod_6(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé TÇn Thñy Hoµng|" + text3, "POS |43360,113376,Thanh|40960,113408,Chu|43392,110944,HuyÒn|40992,110944,Kú");
	}

	private static void smethod_83()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "luyÖn c«ng";
		string text3 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text2);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text3);
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 1 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[3] { 319, 123, 206 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			}
		});
		string text4 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text4, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n|" + text4, "POS|42560,92384,kÕt 1|41376,101952,kÕt 2|49344,102336,kÕt 3");
		smethod_8(ref mapNavigationEntry_0, 959, text4 + "|ChiÕn Long");
		smethod_7(ref mapNavigationEntry_0, 355, text4 + "|Sinh T");
		string string_ = "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y";
		smethod_7(ref mapNavigationEntry_0, 1000, "Sinh T|" + text, string_);
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text, string_);
	}

	private static void smethod_84()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "luyÖn c«ng";
		string text3 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text2);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text3);
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 1 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[3] { 319, 123, 206 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			}
		});
		string text4 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text4, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n|" + text4, "POS|42560,92384,kÕt 1|41376,101952,kÕt 2|49344,102336,kÕt 3");
		smethod_8(ref mapNavigationEntry_0, 959, text4 + "|ChiÕn Long");
		smethod_7(ref mapNavigationEntry_0, 355, text4 + "|Sinh T");
		string string_ = "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y";
		smethod_7(ref mapNavigationEntry_0, 1000, "Sinh T|" + text, string_);
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text, string_);
	}

	private static void smethod_85()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "B¶n ®å s\u00a8n boss Hoµng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text2);
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 1 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[3] { 319, 123, 206 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			}
		});
		string text3 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text3, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n|" + text3, "POS|42560,92384,kÕt 1|41376,101952,kÕt 2|49344,102336,kÕt 3");
		smethod_6(ref mapNavigationEntry_0, 1062, "§i §Õn V\u00ad¬ng KhiÕt Thµnh|" + text, "POS| 52064,105408,TËp KÕt 1|44224, 90944,TËp KÕt 2|62336,105376 ,TËp KÕt 3|62144,115936,TËp KÕt 4|54368,110464 ,TËp kÕt 5|57024,107840,TËp kÕt 6|60096,110464,TËp kÕt 7| 57152,113696,TËp kÕt 8");
		smethod_6(ref mapNavigationEntry_0, 355, text3 + "|Sinh T", "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y");
		smethod_7(ref mapNavigationEntry_0, 978, text + "|TÇn", "POS|43232,110944|40736,110720|40608,113888|43712,113888 ");
		smethod_6(ref mapNavigationEntry_0, 523, text, "§i §\u00b8nh B¹c");
	}

	private static void smethod_86()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "ho¹t ®éng GAME ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|®éng GAME|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text2);
		smethod_7(ref mapNavigationEntry_0, 340, "cÊp 90|" + text, "POS|59040,110016,M¹c Cao QuËt", "M¹c Cao QuËt");
		smethod_6(ref mapNavigationEntry_0, 336, "cÊp 90|" + text, "POS|35968,101984,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_6(ref mapNavigationEntry_0, 322, "cÊp 90|" + text, "POS|50848,101248,Tr\u00adêng B¹ch s¬n B¾c", "Tr\u00adêng B¹ch s¬n B¾c");
		smethod_6(ref mapNavigationEntry_0, 321, "cÊp 90|" + text, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam", "Tr\u00adêng B¹ch s¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 227, "cÊp 90|" + text, "POS|50816,103584,Sa M¹c 3", "Sa M¹c 3");
		smethod_6(ref mapNavigationEntry_0, 225, "cÊp 90|" + text, "POS|47168,104800,Sa M¹c 1", "Sa M¹c 1");
		smethod_6(ref mapNavigationEntry_0, 226, "cÊp 90|" + text, "POS|49920,101888,Sa M¹c 2", "Sa M¹c 2");
		smethod_6(ref mapNavigationEntry_0, 144, "cÊp 90|" + text, "POS|54112,96640,D\u00adîc V\u00ad¬ng ®éng tÇng 4", "D\u00adîc V\u00ad¬ng ®éng tÇng 4");
		smethod_6(ref mapNavigationEntry_0, 93, "cÊp 90|" + text, "POS|48928,101312,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 124, "cÊp 90|" + text, "POS|53600,109376,C\u00b8n Viªn ®éng", "C\u00b8n Viªn ®éng");
		smethod_6(ref mapNavigationEntry_0, 152, "cÊp 90|" + text, "POS|53504,107552,TuyÕt B\u00b8o ®éng tÇng 8", "TuyÕt B\u00b8o ®éng tÇng 8");
		smethod_6(ref mapNavigationEntry_0, 75, "chØ ®Þnh|Êp 90|Lang|" + text, "POS|57952,96384  ,Kho¶ Lang ®éng", "Kho¶ Lang ®éng");
		smethod_6(ref mapNavigationEntry_0, 19, "§i ®Õn n¬i luyÖn c«ng|cÊp 20|T©y Nam|" + text, "POS|99328,126464  ,KiÕm C\u00b8c T©y Na", "KiÕm C\u00b8c T©y Na");
		smethod_4(ref mapNavigationEntry_0, "§i ®Õn n¬i luyÖn c«ng|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[10] { 179, 70, 3, 7, 14, 19, 43, 71, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[12]
				{
					193, 92, 8, 22, 74, 77, 90, 136, 141, 145,
					170, 4
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 41, 21, 122, 6, 23, 91, 135, 168, 171,
					172, 173, 180, 5
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					164, 165, 38, 39, 40, 42, 66, 67, 116, 125,
					132, 147, 163, 12, 24, 182, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					51, 52, 158, 56, 79, 114, 117, 118, 119, 126,
					127, 128, 148, 26, 166, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[14]
				{
					319, 9, 55, 27, 72, 76, 94, 120, 123, 129,
					130, 142, 169, 206
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 207
				}
			}
		});
		string text3 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text3, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n|" + text3, "POS|42560,92384,kÕt 1|41376,101952,kÕt 2|49344,102336,kÕt 3");
		smethod_8(ref mapNavigationEntry_0, 959, text3 + "|ChiÕn Long");
		smethod_7(ref mapNavigationEntry_0, 355, text3 + "|Sinh T");
		smethod_6(ref mapNavigationEntry_0, 355, "Phong S| Qu¶|" + text2, "POS|50304,78016,Doanh 1|38592,100992,Doanh 2|49440,99520,Doanh 3|38976,78464,Doanh 4", "Hoa S¬n ChiÕn");
		smethod_7(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé TÇn Thñy Hoµng|" + text2, "POS |43360,113376,Thanh|40960,113408,Chu|43392,110944,HuyÒn|40992,110944,Kú");
	}

	private static void smethod_87()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "ho¹t ®éng GAME ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|®éng GAME|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text2);
		smethod_7(ref mapNavigationEntry_0, 340, "cÊp 90|" + text, "POS|59040,110016,M¹c Cao QuËt", "M¹c Cao QuËt");
		smethod_6(ref mapNavigationEntry_0, 336, "cÊp 90|" + text, "POS|35968,101984,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_6(ref mapNavigationEntry_0, 322, "cÊp 90|" + text, "POS|50848,101248,Tr\u00adêng B¹ch s¬n B¾c", "Tr\u00adêng B¹ch s¬n B¾c");
		smethod_6(ref mapNavigationEntry_0, 321, "cÊp 90|" + text, "POS|30944,74016,Tr\u00adêng B¹ch s¬n Nam", "Tr\u00adêng B¹ch s¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 227, "cÊp 90|Trang kÕ |Sa M¹c mª cung 3 " + text, "POS|50816,103584,Sa M¹c mª cung 3", "Sa M¹c mª cung 3");
		smethod_6(ref mapNavigationEntry_0, 225, "cÊp 90|Trang kÕ |Sa M¹c mª cung 1 " + text, "POS|47168,104800,Sa M¹c mª cung 1 ", "Sa M¹c mª cung 1 ");
		smethod_6(ref mapNavigationEntry_0, 226, "cÊp 90|Trang kÕ |Sa M¹c mª cung 2 " + text, "POS|49920,101888,Sa M¹c mª cung 2", "Sa M¹c mª cung 2");
		smethod_6(ref mapNavigationEntry_0, 144, "cÊp 90|" + text, "POS|54112,96640,D\u00adîc V\u00ad¬ng ®éng tÇng 4", "D\u00adîc V\u00ad¬ng ®éng tÇng 4");
		smethod_6(ref mapNavigationEntry_0, 93, "cÊp 90|Trang kÕ|TiÕn Cóc ®éng|" + text, "POS|48928,101312,TiÕn Cóc ®éng", "TiÕn Cóc ®éng");
		smethod_6(ref mapNavigationEntry_0, 124, "cÊp 90|Trang kÕ|C\u00b8n Viªn ®éng| " + text, "POS|53600,109376,C\u00b8n Viªn ®éng", "C\u00b8n Viªn ®éng");
		smethod_6(ref mapNavigationEntry_0, 152, "cÊp 90|Trang kÕ|TuyÕt B\u00b8o ®éng tÇng 8| " + text, "POS|53504,107552,TuyÕt B\u00b8o ®éng tÇng 8", "TuyÕt B\u00b8o ®éng tÇng 8");
		smethod_6(ref mapNavigationEntry_0, 75, "chØ ®Þnh|Êp 90|Lang|" + text, "POS|57952,96384  ,Kho¶ Lang ®éng", "Kho¶ Lang ®éng");
		smethod_6(ref mapNavigationEntry_0, 19, "§i ®Õn n¬i luyÖn c«ng|cÊp 20|T©y Nam|" + text, "POS|99328,126464  ,KiÕm C\u00b8c T©y Na", "KiÕm C\u00b8c T©y Na");
		smethod_4(ref mapNavigationEntry_0, "§i ®Õn n¬i luyÖn c«ng|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[10] { 179, 70, 3, 7, 14, 19, 43, 71, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[12]
				{
					193, 92, 8, 22, 74, 77, 90, 136, 141, 145,
					170, 4
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 41, 21, 122, 6, 23, 91, 135, 168, 171,
					172, 173, 180, 5
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					164, 165, 38, 39, 40, 42, 66, 67, 116, 125,
					132, 147, 163, 12, 24, 182, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					51, 52, 158, 56, 79, 114, 117, 118, 119, 126,
					127, 128, 148, 26, 166, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[14]
				{
					319, 9, 55, 27, 72, 76, 94, 120, 123, 129,
					130, 142, 169, 206
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 207
				}
			}
		});
		string text3 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text3, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n|" + text3, "POS|42560,92384,kÕt 1|41376,101952,kÕt 2|49344,102336,kÕt 3");
		smethod_8(ref mapNavigationEntry_0, 959, text3 + "|ChiÕn Long");
		smethod_7(ref mapNavigationEntry_0, 355, text3 + "|Sinh T");
		smethod_6(ref mapNavigationEntry_0, 355, "Phong S| Qu¶|" + text2, "POS|50304,78016,Doanh 1|38592,100992,Doanh 2|49440,99520,Doanh 3|38976,78464,Doanh 4", "Hoa S¬n ChiÕn");
		smethod_7(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé TÇn Thñy Hoµng|" + text2, "POS |43360,113376,Thanh|40960,113408,Chu|43392,110944,HuyÒn|40992,110944,Kú");
	}

	private static void smethod_88()
	{
		string text = "ThÇn hµnh";
		string text2 = "§i c\u00b8c ®Þa ®iÓm ®\u00adîc chØ ®Þnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		int[,] array = new int[1, 2] { { 78, 993 } };
		int[] array2 = new int[7] { 470, 78, 1, 162, 37, 80, 176 };
		for (int i = 0; i < array.GetLength(0); i++)
		{
			Array.Resize(ref array2, array2.Length + 1);
			array2[array2.Length - 1] = array[i, 1];
		}
		smethod_5(ref mapNavigationEntry_0, text + "|Thµnh thÞ|ThÊt §¹i Thµnh ThÞ", null, text + " |Th«n trang|Th«n trang", null, text + "|M«n Ph\u00b8i|M«n Ph\u00b8i", null, "Tèng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "®Þa ®iÓm chØ ®Þnh|CÊp 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, text2 + "|®Þa ®iÓm chØ ®Þnh|§i ®Õn n¬i luyÖn c«ng", new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[9] { 19, 7, 3, 43, 179, 14, 70, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[13]
				{
					193, 170, 92, 22, 4, 6, 8, 74, 77, 90,
					136, 141, 145
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 171, 172, 173, 21, 23, 5, 41, 122, 6,
					91, 135, 168, 180
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					182, 42, 24, 164, 165, 38, 39, 40, 66, 67,
					116, 125, 132, 147, 163, 12, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					79, 56, 166, 114, 51, 52, 158, 117, 118, 119,
					126, 127, 128, 148, 26, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[10] { 319, 123, 206, 72, 169, 94, 9, 55, 27, 129 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[15]
				{
					224, 198, 320, 181, 201, 203, 202, 10, 143, 151,
					24, 199, 205, 207, 204
				}
			}
		});
	}

	private static void smethod_89()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 1 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[3] { 319, 123, 206 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			}
		});
		string text2 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text2, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n|" + text2, "POS|42560,92384,kÕt 1|41376,101952,kÕt 2|49344,102336,kÕt 3");
		smethod_8(ref mapNavigationEntry_0, 959, text2 + "|ChiÕn Long");
		smethod_7(ref mapNavigationEntry_0, 355, text2 + "|Sinh T");
		string string_ = "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y";
		smethod_7(ref mapNavigationEntry_0, 1000, "Sinh T|" + text, string_);
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text, string_);
	}

	private static void smethod_90()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "ChuyÓn map";
		string text3 = "b¶n ®å luyÖn c«ng";
		string text4 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text2 + "|µnh thÞ", null, text2 + "|Th«n tr", null, text2 + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text2, new int[15]
		{
			875, 322, 321, 75, 227, 225, 226, 336, 340, 144,
			93, 124, 152, 76, 224
		});
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text4);
		smethod_4(ref mapNavigationEntry_0, "cÊp|" + text3, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 179 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[6] { 193, 170, 92, 22, 4, 6 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 164, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[6] { 79, 56, 166, 114, 69, 94 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 72, 169 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[7] { 224, 198, 320, 181, 201, 198, 202 }
			}
		});
		string text5 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text5, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n|" + text5, "POS|42560,92384,kÕt 1|41376,101952,kÕt 2|49344,102336,kÕt 3");
		smethod_8(ref mapNavigationEntry_0, 959, text5 + "|ChiÕn Long");
		smethod_7(ref mapNavigationEntry_0, 355, text5 + "|Sinh T");
		string string_ = "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y";
		smethod_7(ref mapNavigationEntry_0, 1000, "Sinh T|" + text2, string_);
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text2, string_);
		smethod_6(ref mapNavigationEntry_0, 523, text2, "§i §\u00b8nh B¹c");
	}

	private static void smethod_91()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text2);
		smethod_4(ref mapNavigationEntry_0, "cÊp|" + text, new LevelBracketMapGroup[1]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[8] { 224, 320, 198, 181, 204, 205, 201, 202 }
			}
		});
		smethod_6(ref mapNavigationEntry_0, 199, "cÊp 80|" + text, "POS|52608,92992,Vò L\u00a8ng ®éng");
		smethod_6(ref mapNavigationEntry_0, 198, "cÊp 80|" + text, "POS|48672,94304,Thanh khª ®éng");
		smethod_6(ref mapNavigationEntry_0, 202, "cÊp 80|" + text, "POS|57152,90336,Phï Dung ®éng");
		smethod_6(ref mapNavigationEntry_0, 204, "cÊp 80|" + text, "POS|53824,108512,Phi Thiªn ®éng");
		smethod_6(ref mapNavigationEntry_0, 205, "cÊp 80|" + text, "POS|54272,108960,D\u00ad¬ng Trung ®én");
		smethod_6(ref mapNavigationEntry_0, 203, "cÊp 80|" + text, "POS|49600,95744 ,V« Danh ®éng");
		smethod_6(ref mapNavigationEntry_0, 10, "cÊp 80|" + text, "POS|51296,102688 ,Nh¹n Th¹ch ®éng");
		smethod_6(ref mapNavigationEntry_0, 1220, "§i L©m Du Quan|" + text, "POS|51447,114134");
		smethod_6(ref mapNavigationEntry_0, 978, "TÇn|" + text, "POS |43360,113376,Thanh|40960,113408,Chu|43392,110944,HuyÒn|40992,110944,Kú");
		smethod_7(ref mapNavigationEntry_0, 959, text + "|ChiÕn Long", "POS |49472,96000,Cæng T\u00adêng V©n|45568,95936,Cæng Vò Di S¬n|51520,92416,Cæng La tiªu (Trªn)| 54336,100864,Cæng La Tiªu S¬n (D\u00adíi)");
		smethod_6(ref mapNavigationEntry_0, 1062, "Long V\u00ad¬ng KhiÕt Thµnh|" + text, "POS| 52064,105408,TËp KÕt 1|44224, 90944,TËp KÕt 2|62336,105376 ,TËp KÕt 3|62144,115936,TËp KÕt 4|54368,110464 ,TËp kÕt 5|57024,107840,TËp kÕt 6|60096,110464,TËp kÕt 7| 57152,113696,TËp kÕt 8");
		smethod_7(ref mapNavigationEntry_0, 355, text + "|Sinh T");
	}

	private static void smethod_92()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text2);
		smethod_6(ref mapNavigationEntry_0, 989, "Tèng Kim Bang", "POS|49312,101696,Phe Tèng|50240,98720,Phe Kim", "Báo danh TĐBH");
		smethod_7(ref mapNavigationEntry_0, 1002, "t©n thñ|huyÓn ®Õn b¶n ®å luyÖn c«ng cÊp 7|" + text, "POS|52160,114784,L©m Du D\u00ad¬ng - L\u00adu §¹i Lý", "L©m Du D\u00ad¬ng");
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[2] { 19, 7 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[2] { 193, 170 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[2] { 21, 167 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[2] { 182, 164 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 79, 56, 166 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[6] { 319, 123, 206, 1000, 1001, 1002 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[5] { 224, 198, 320, 181, 201 }
			}
		});
		string text3 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text3, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 37, "Viªm §Ð|" + text3, "POS|51904,96512,T©y|59392,94912 ,B¾c|49344,102336,§«ng");
		smethod_6(ref mapNavigationEntry_0, 336, "L\u00a8ng §é|" + text3, "POS|36751,96679,BÕn 1|41021,93148,BÕn 2|49440,89856,BÕn 3");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n|" + text3, "POS|42560,92384,T©y|41376,101952,Nam|49344,102336,§«ng");
		smethod_7(ref mapNavigationEntry_0, 355, text3 + "|Sinh T");
		smethod_7(ref mapNavigationEntry_0, 959, text3 + "|ChiÕn Long");
		smethod_7(ref mapNavigationEntry_0, 1, text3 + "|Hé Tèng");
		smethod_6(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé TÇn Thñy Hoµng|" + text3, "POS |43360,113376,Thanh|40960,113408,Chu|43392,110944,HuyÒn|40992,110944,Kú");
		smethod_6(ref mapNavigationEntry_0, 336, "TËp KÕt|A|" + text, "POS|39808,99456,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_6(ref mapNavigationEntry_0, 336, "TËp KÕt|B|" + text, "POS|41792,95232,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
		smethod_6(ref mapNavigationEntry_0, 336, "TËp KÕt|C|" + text, "POS|49600,91488,Phong L\u00a8ng ®é", "Phong L\u00a8ng ®é");
	}

	private static void smethod_93()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "luyÖn c«ng";
		string text3 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text2);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text3);
		smethod_6(ref mapNavigationEntry_0, 989, "Tèng Kim Bang", "POS|49312,101696,Phe Tèng|50240,98720,Phe Kim", "Báo danh TĐBH");
		smethod_7(ref mapNavigationEntry_0, 325, "Tèng Kim|Tèng|" + text, "POS|49312,101696,§iÓm b\u00b8o danh T", "§iÓm b\u00b8o danh T");
		smethod_7(ref mapNavigationEntry_0, 325, "Tèng Kim|Kim|" + text, "POS|50240,98720,§iÓm b\u00b8o danh T", "§iÓm b\u00b8o danh T");
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[6] { 844743012, 609715556, 2003660687, -1771020923, -654567069, -614731095 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[8] { 193, 145, 170, 92, 22, 4, 6, 77 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 164, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[7] { 79, 56, 166, 114, 69, 94, 180 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 72, 169 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 207
				}
			}
		});
		string text4 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text4, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n ChiÕn| " + text4, "POS|46235,99226,kÕt 1|44480,97248 ,kÕt 2|46260,93690 ,kÕt 3|49216,92608,kÕt 4|49568,97856,kÕt 5");
		smethod_6(ref mapNavigationEntry_0, 355, "§Êu tr\u00adêng sinh tö|" + text, "POS|41760,87520,kÕt 1|44224,90944,kÕt 2|43920,85484,KÕt 3|46656,88288,TËp KÕt 4|47648, 91712,TËp kÕt 3h|41472, 92736,TËp kÕt 6h|42240, 84480,TËp kÕt 9h|46432, 84288,TËp kÕt 12h");
		smethod_7(ref mapNavigationEntry_0, 959, text4 + "|ChiÕn Long");
		smethod_6(ref mapNavigationEntry_0, 1062, "§i §Õn Thiªn Long §Êu Tr\u00adêng|" + text, "POS| 52064,105408,TËp KÕt 1|44224, 90944,TËp KÕt 2|62336,105376 ,TËp KÕt 3|62144,115936,TËp KÕt 4|54368,110464 ,TËp kÕt 5|57024,107840,TËp kÕt 6|60096,110464,TËp kÕt 7| 57152,113696,TËp kÕt 8");
		smethod_6(ref mapNavigationEntry_0, 984, "§Õn L\u00a8ng Mé TÇn Thuû Hoµng|" + text, "POS |43360,113376,Thanh|40960,113408,Chu|43392,110944,HuyÒn|40992,110944,Kú");
	}

	private static void smethod_94()
	{
		string text = "thÇn hµnh";
		string text2 = "§i ®Õn b¶n ®å luyÖn c«ng";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|Thµnh thÞ", null, text + "|Th«n trang", null, text + "|M«n Ph\u00b8i", null, "Tèng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "CÊp 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, text2 + "|B¶n §å LuyÖn C«ng", new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[9] { 19, 7, 3, 43, 179, 14, 70, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[13]
				{
					193, 170, 92, 22, 4, 6, 8, 74, 77, 90,
					136, 141, 145
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 171, 172, 173, 21, 23, 5, 41, 122, 6,
					91, 135, 168, 180
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					182, 42, 24, 164, 165, 38, 39, 40, 66, 67,
					116, 125, 132, 147, 163, 12, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					79, 56, 166, 114, 51, 52, 158, 117, 118, 119,
					126, 127, 128, 148, 26, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[10] { 319, 123, 206, 72, 169, 94, 9, 55, 27, 129 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[15]
				{
					224, 198, 320, 181, 201, 203, 202, 10, 143, 151,
					24, 199, 205, 207, 204
				}
			}
		});
		smethod_7(ref mapNavigationEntry_0, 355, "|Sinh T", "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y");
		smethod_7(ref mapNavigationEntry_0, 1, "§i ®Õn VËn Tiªu");
		smethod_8(ref mapNavigationEntry_0);
	}

	private static void smethod_95()
	{
		string text = "thÇn hµnh";
		string text2 = "§i ®Õn b¶n ®å luyÖn c«ng";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|Thµnh thÞ", null, text + "|Th«n trang", null, text + "|M«n Ph\u00b8i", null, "Tèng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "CÊp 90|" + text2);
		smethod_6(ref mapNavigationEntry_0, 416, "Thµnh thÞ|L¹c D\u00ad¬ng|" + text, "POS|52448,104704 ,§«ng|50304,100032,T©y| 49376,103264  ,Nam|53184,101024  ,B¾c|61056,100160 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 428, "Thµnh thÞ||T« Ch©u|" + text, "POS|51104,102592,§«ng|56805,93690,T©y| 61056,100160 ,Nam|61056,100160 ,B¾c|61056,100160 ,T©m");
		smethod_4(ref mapNavigationEntry_0, text2 + "|B¶n §å LuyÖn C«ng", new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[9] { 19, 7, 3, 43, 179, 14, 70, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[13]
				{
					193, 170, 92, 22, 4, 6, 8, 74, 77, 90,
					136, 141, 145
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 171, 172, 173, 21, 23, 5, 41, 122, 6,
					91, 135, 168, 180
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					182, 42, 24, 164, 165, 38, 39, 40, 66, 67,
					116, 125, 132, 147, 163, 12, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					79, 56, 166, 114, 51, 52, 158, 117, 118, 119,
					126, 127, 128, 148, 26, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[10] { 319, 123, 206, 72, 169, 94, 9, 55, 27, 129 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[15]
				{
					224, 198, 320, 181, 201, 203, 202, 10, 143, 151,
					24, 199, 205, 207, 204
				}
			}
		});
		smethod_6(ref mapNavigationEntry_0, 977, "Tróc L©m M«n|" + text, "POS|65408,83328,Vµo Map Trªn|52064,101344,Vµo Map D\u00adíi", null, "Tróc L©m M«n|tËp k", null, bool_0: false, "D\u00adîc §iÕm", "POS|63072,92096, 1_tËp k|62880,86432, 2_tËp k|59168,85888, 3_tËp k|55264,91968, 4_Trang_tËp k|54992,97378, 5_Trang_tËp k|57920,98368, 6_Trang_tËp k|57120,94816, 7_Trang_tËp k|61056,89056, 8_Trang_tËp k|57408,91264, 9_Trang_tËp k|57920,87680,10_Trang_tËp k|61888,94144,11_Trang_tËp k|60999,92584,12_Trang_tËp k|59648,97280,13_Trang_tËp k|59409,96269,14_Trang_tËp k|56864,89312,Th\u00adîng_Trang_tËp k|60928,95840,ch H¹_Trang_tËp k");
		smethod_6(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé|" + text, "POS |35648,105952,B¹ch Hæ TrËn|36288,118368,Chu T\u00adíc TrËn|47520,107168,HuyÒn|47776,118144,Thanh");
		smethod_8(ref mapNavigationEntry_0);
	}

	private static void smethod_96()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text, null, text2, null, text2, 55);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text);
		string text3 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text3, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n|" + text3, "POS|42560,92384,kÕt 1|41376,101952,kÕt 2|49344,102336,kÕt 3");
		smethod_6(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé|" + text, "POS |40608,110688,B¹ch Hæ TrËn|40576,113888 ,Chu T\u00adíc TrËn|43712,110752 ,HuyÒn|43712,113888 ,Thanh");
		smethod_6(ref mapNavigationEntry_0, 1062, text3 + "|KhiÕt Thµnh", "POS|56896,107840,TËp KÕt 1|57440,112448,TËp KÕt 2|56896,113632  ,TËp KÕt 3|52832,112256,TËp KÕt 4|54144,113120  ,TËp kÕt 5|53696,108384,TËp kÕt 6|60096,110464,TËp kÕt 7| 57152,113696,TËp kÕt 8");
		smethod_6(ref mapNavigationEntry_0, 355, text3 + "|Sinh T", "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y");
		smethod_7(ref mapNavigationEntry_0, 978, text + "|TÇn", "POS|43232,110944|40736,110720|40608,113888|43712,113888 ");
		smethod_6(ref mapNavigationEntry_0, 523, text, "§i §\u00b8nh B¹c");
	}

	private static void smethod_97()
	{
		string text = "Di chuyÓn ®Õn thµnh thÞ th«n trÊn";
		string text2 = "§i ®Õn b¶n ®å luyÖn c«ng";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|Thµnh thÞ", null, text + "|Th«n trang", null, text + "|M«n Ph\u00b8i", null, "Tèng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "CÊp 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, text2 + "|B¶n §å LuyÖn C«ng", new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[9] { 19, 7, 3, 43, 179, 14, 70, 83, 73 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[13]
				{
					193, 170, 92, 22, 4, 6, 8, 74, 77, 90,
					136, 141, 145
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 171, 172, 173, 21, 23, 5, 41, 122, 6,
					91, 135, 168, 180
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					182, 42, 24, 164, 165, 38, 39, 40, 66, 67,
					116, 125, 132, 147, 163, 12, 194
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					79, 56, 166, 114, 51, 52, 158, 117, 118, 119,
					126, 127, 128, 148, 26, 196
				}
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[10] { 319, 123, 206, 72, 169, 94, 9, 55, 27, 129 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[15]
				{
					224, 198, 320, 181, 201, 203, 202, 10, 143, 151,
					24, 199, 205, 207, 204
				}
			}
		});
		smethod_6(ref mapNavigationEntry_0, 355, "§Êu tr\u00adêng sinh tö|" + text, "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y");
		smethod_6(ref mapNavigationEntry_0, 936, "Thµnh thÞ|Thµnh thÞ|T\u00ad¬ng D\u00ad¬ng 2|" + text, "POS|50336,107424 ,§«ng|47168,101664,T©y|46528,104640,Nam|54528,103552,B¾c|50464,103616 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 941, "Thµnh thÞ|Thµnh thÞ|L¹c D\u00ad¬ng|" + text, "POS|50336,107424 ,§«ng|47168,101664,T©y|46528,104640,Nam|54528,103552,B¾c|50464,103616 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 940, "Thµnh thÞ|Thµnh thÞ|Cæ Loa|" + text, "POS|52448,104704 ,§«ng|50304,100032 ,T©y|49376,103264 ,Nam|61056,100160 ,B¾c|51104,102592 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 939, "Thµnh thÞ|Thµnh thÞ|ThÈm D\u00ad¬ng|" + text, "POS|54272,102976 ,§«ng|51904,96512,T©y|54272,102976,Nam|59392,94912,B¾c|55232,99200,T©m");
		smethod_6(ref mapNavigationEntry_0, 1013, "b¶n ®å luyÖn c«ng|LuyÖn C«ng (VIP ChiÕn §Êu)| " + text, "POS|30944,74016,TuyÕt S¬n T©y");
		smethod_6(ref mapNavigationEntry_0, 1024, "b¶n ®å luyÖn c«ng|LuyÖn C«ng (VIP ChiÕn §Êu)| " + text, "POS|30944,74016,TuyÕt S¬n B¾c");
		smethod_6(ref mapNavigationEntry_0, 1025, "b¶n ®å luyÖn c«ng|LuyÖn C«ng (VIP ChiÕn §Êu)| " + text, "POS|30944,74016,TuyÕt S¬n Nam");
		smethod_6(ref mapNavigationEntry_0, 1029, "b¶n ®å luyÖn c«ng|LuyÖn C«ng (VIP ChiÕn §Êu)| " + text, "POS|30944,74016,B\u00a8ng Hµn S¬n §«ng");
		smethod_6(ref mapNavigationEntry_0, 977, "Tróc L©m M«n|" + text, "POS|65408,83328,Vµo Map Trªn|52064,101344,Vµo Map D\u00adíi", null, "Tróc L©m M«n|tËp k", null, bool_0: false, "D\u00adîc §iÕm", "POS|63072,92096, 1_tËp k|62880,86432, 2_tËp k|59168,85888, 3_tËp k|55264,91968, 4_Trang_tËp k|54992,97378, 5_Trang_tËp k|57920,98368, 6_Trang_tËp k|57120,94816, 7_Trang_tËp k|61056,89056, 8_Trang_tËp k|57408,91264, 9_Trang_tËp k|57920,87680,10_Trang_tËp k|61888,94144,11_Trang_tËp k|60999,92584,12_Trang_tËp k|59648,97280,13_Trang_tËp k|59409,96269,14_Trang_tËp k|56864,89312,Th\u00adîng_Trang_tËp k|60928,95840,ch H¹_Trang_tËp k");
		smethod_6(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé|" + text, "POS |35648,105952,B¹ch Hæ TrËn|36288,118368,Chu T\u00adíc TrËn|47520,107168,HuyÒn|47776,118144,Thanh");
		smethod_8(ref mapNavigationEntry_0);
	}

	private static void smethod_98()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text2);
		smethod_6(ref mapNavigationEntry_0, 989, "Tèng Kim Bang", "POS|49312,101696,Phe Tèng|50240,98720,Phe Kim", "Báo danh TĐBH");
		smethod_7(ref mapNavigationEntry_0, 333, "M«n ph\u00b8i|Hoa S¬n|" + text, "POS|43041,100348 ,Hoa S¬n Ph\u00b8i", "Hoa S¬n Ph\u00b8i");
		smethod_7(ref mapNavigationEntry_0, 989, "M«n ph\u00b8i|Vò Hån|" + text, "POS|48960,104000,Vò Hån §\u00adêng", "Vò Hån §\u00adêng");
		smethod_7(ref mapNavigationEntry_0, 325, "Tèng Kim|Tèng|" + text, "POS|49312,101696,§iÓm b\u00b8o danh T", "§iÓm b\u00b8o danh T");
		smethod_7(ref mapNavigationEntry_0, 325, "Tèng Kim|Kim|" + text, "POS|50240,98720,§iÓm b\u00b8o danh T", "§iÓm b\u00b8o danh T");
		string text3 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text3, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n|" + text3, "POS|42560,92384,T©y|41376,101952,Nam|49344,102336,§«ng");
		smethod_6(ref mapNavigationEntry_0, 355, text3 + "|Sinh T", "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y");
		smethod_7(ref mapNavigationEntry_0, 959, text3 + "|ChiÕn Long");
		smethod_6(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé TÇn Thñy Hoµng|" + text3, "POS |43360,113376,Thanh|40960,113408,Chu|43392,110944,HuyÒn|40992,110944,Kú");
		smethod_6(ref mapNavigationEntry_0, 1062, "§i §Õn V\u00ad¬ng KhiÕt Thµnh|" + text, "POS| 52064,105408,TËp KÕt 1|44224, 90944,TËp KÕt 2|62336,105376 ,TËp KÕt 3|62144,115936,TËp KÕt 4|54368,110464 ,TËp kÕt 5|57024,107840,TËp kÕt 6|60096,110464,TËp kÕt 7| 57152,113696,TËp kÕt 8");
	}

	private static void smethod_99()
	{
		string text = "Muèn §Õn";
		string text2 = "LuyÖn C«ng|" + text;
		string text3 = "Ýnh N\u00a8n";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text, null, "B¾c §Èu|" + text3, null, "Hoa Ngu|" + text3, 55);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "2x ®Õn 8x|80 trë lªn|" + text2, new LevelBracketMapGroup[1]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 206
				}
			}
		});
		smethod_4(ref mapNavigationEntry_0, "2x ®Õn 8x|20 trë lªn|" + text2, new LevelBracketMapGroup[1]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[8] { 3, 19, 43, 70, 71, 73, 7, 179 }
			}
		});
		smethod_4(ref mapNavigationEntry_0, "2x ®Õn 8x|30 trë lªn|" + text2, new LevelBracketMapGroup[1]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[12]
				{
					193, 92, 8, 22, 74, 77, 90, 136, 141, 145,
					170, 4
				}
			}
		});
		smethod_4(ref mapNavigationEntry_0, "2x ®Õn 8x|40 trë lªn|" + text2, new LevelBracketMapGroup[1]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[14]
				{
					167, 171, 172, 173, 21, 23, 5, 41, 122, 6,
					91, 135, 168, 180
				}
			}
		});
		smethod_4(ref mapNavigationEntry_0, "2x ®Õn 8x|50 trë lªn|" + text2, new LevelBracketMapGroup[1]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[17]
				{
					182, 42, 24, 164, 165, 38, 39, 40, 66, 67,
					116, 125, 132, 147, 163, 12, 194
				}
			}
		});
		smethod_4(ref mapNavigationEntry_0, "2x ®Õn 8x|60 trë lªn|" + text2, new LevelBracketMapGroup[1]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[16]
				{
					79, 56, 166, 114, 51, 52, 158, 117, 118, 119,
					126, 127, 128, 148, 26, 196
				}
			}
		});
		smethod_4(ref mapNavigationEntry_0, "2x ®Õn 8x|70 trë lªn|" + text2, new LevelBracketMapGroup[1]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[10] { 319, 123, 206, 72, 169, 94, 9, 55, 27, 129 }
			}
		});
		string text4 = "o¹t §éng";
		smethod_6(ref mapNavigationEntry_0, 959, "ChiÕn Long|" + text4, "POS|45376,96160,Vò Di S¬n|49536,95840,T\u00adêng V©n §éng|54432,100864,La Tiªu S¬n");
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T");
		smethod_6(ref mapNavigationEntry_0, 55, "§µo Hoa Nguyªn|" + text4, "POS|54112,95456,§µo Hoa Nguyªn", "§µo Hoa Nguyªn");
		smethod_6(ref mapNavigationEntry_0, 336, "L\u00a8ng §é|" + text4, "POS|36751,96679,BÕn 1|41021,93148,BÕn 2|49440,89856,BÕn 3");
		smethod_9(ref mapNavigationEntry_0, "Hé Tèn|VËn Tiªu|" + text4);
		smethod_6(ref mapNavigationEntry_0, 949, "Mª Cung|" + text4, "KiÕm Gia");
		smethod_6(ref mapNavigationEntry_0, 934, "Mª Cung|" + text4, "hiªn Tr");
	}

	private static void smethod_100()
	{
		string text = "thÇn hµnh";
		int_2 = null;
		mapNavigationEntry_0 = null;
		int[,] array = new int[5, 2];
		Class10.smethod_4(array, 145185);
		int[,] array2 = array;
		int[] array3 = new int[7] { 11, 78, 1, 162, 37, 80, 176 };
		for (int i = 0; i < array2.GetLength(0); i++)
		{
			Array.Resize(ref array3, array3.Length + 1);
			array3[array3.Length - 1] = array2[i, 1];
		}
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", array3, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "Tèng Ki|" + text);
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text, new int[21]
		{
			322, 321, 875, 75, 227, 225, 226, 336, 340, 144,
			93, 124, 152, 443, 444, 445, 419, 446, 447, 457,
			458
		});
		Class29.smethod_0(ref mapNavigationEntry_0, "B¹ch S¬n §=998|B¹ch S¬n T=997|Sahara=418", "cÊp 90|" + text, 2);
		smethod_4(ref mapNavigationEntry_0, "n n¬i luyÖn c|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[3] { 10, 224, 320 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[3] { 319, 438, 441 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[3] { 56, 117, 436 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[6] { 38, 164, 424, 433, 434, 435 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[8] { 171, 172, 421, 422, 423, 430, 431, 432 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[4] { 170, 7, 420, 429 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 7, 19, 71 }
			}
		});
		Class29.smethod_0(ref mapNavigationEntry_0, "H¾c Méc Nhai=995|§¹i Quang Minh=448|Sa M«n Quan=451", "ng 7x|n n¬i luyÖn c|" + text, 1);
		smethod_6(ref mapNavigationEntry_0, 1095, "Cæ Thµnh|§« Cæ Thµnh|" + text, "POS|101824,165792,§«ng|97504,159456,T©y|96160,163392 ,Nam|103840,160896,B¾c|100608,162336 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 1096, "Cæ Thµnh|D\u00ad¬ng Cæ Thµnh|" + text, "POS|50336,107424 ,§«ng|47168,101664,T©y|46528,104640,Nam|54528,103552,B¾c|50464,103616 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 1097, "Cæ Thµnh|T\u00adêng Cæ Thµnh|" + text, "POS|52448,104704 ,§«ng|50304,100032 ,T©y|49376,103264 ,Nam|61056,100160 ,B¾c|51104,102592 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 1098, "Cæ Thµnh|Lý Cæ Thµnh|" + text, "POS|52128,100992 ,B¾c|50528,100320 ,T©m");
		smethod_6(ref mapNavigationEntry_0, 1099, "Cæ Thµnh|Kinh Cæ Thµnh|" + text, "POS|54272,102976 ,§«ng|51904,96512,T©y|54272,102976,Nam|59392,94912,B¾c|55232,99200,T©m");
		smethod_6(ref mapNavigationEntry_0, 1100, "Cæ Thµnh|Ch©u Cæ Thµnh|" + text, "POS|54912,103456 ,§«ng|53024,96800,T©y|51776,101824,Nam|59648,97152,B¾c|56256,96960,T©m");
		smethod_6(ref mapNavigationEntry_0, 1101, "Cæ Thµnh|An Cæ Thµnh|" + text, "POS|53920,105120 ,§«ng|44640,106176,Nam|50208,94016,B¾c");
		smethod_7(ref mapNavigationEntry_0, 995, "o¹t §éng|" + text, "POS|65344,82880,tr¹i 1|52224,101056,tr¹i 2");
		Class45.smethod_7(array2);
		Class44.int_1 = array2;
	}

	private static void smethod_101()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "luyÖn c|";
		string text3 = "cÊp 90|" + text2;
		string text4 = "Ho¹t ®éng|Ho¹t §éng";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "èng Kim|" + text);
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text2, new int[13]
		{
			340, 321, 322, 225, 226, 227, 75, 93, 124, 152,
			875, 144, 336
		});
		smethod_6(ref mapNavigationEntry_0, 1012, "V\u00ad¬ng ThiÕt Thµnh|" + text, "POS|54048,107552,TËp KÕt 1|53856,114080,TËp KÕt 2|60640,114144,TËp KÕt 3|60512,107392,TËp KÕt 4|55232,108928,TËp kÕt 5|55264,112768,TËp kÕt 6|59072,112768,TËp kÕt 7|59104,108896,TËp kÕt 8");
		smethod_8(ref mapNavigationEntry_0, 959, text4, "ChiÕn Long");
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text4, null, "Trinh S\u00b8t", "1,41600,88128|2,44192,91040|3,43840,85600|4,46816,88864");
		smethod_6(ref mapNavigationEntry_0, 336, "Phong L|" + text3, "Phong L");
		smethod_6(ref mapNavigationEntry_0, 989, "Tèng Kim Bang", "POS|49312,101696,Phe Tèng|50240,98720,Phe Kim", "Báo danh TĐBH");
		smethod_6(ref mapNavigationEntry_0, 1019, "TÇn Thñy Hoµng|" + text, "POS|40640,112096 ,TËp KÕt 1|42176,110784,TËp KÕt 2|43520,112000,TËp KÕt 3|42112,113248,TËp KÕt 4");
	}

	private static void smethod_102(bool bool_0 = false)
	{
		string text = "N¬i Muèn";
		string text2 = "luyÖn c|" + text;
		string text3 = "Ýnh N\u00a8n";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, "TÝnh N\u00a8ng|Phong V©n LuËn KiÕm|" + text, null, "B¾c §Èu|" + text3, null, "Hoa Ngu|" + text3, 55);
		smethod_3(ref mapNavigationEntry_0, "Êp 90|" + text2);
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[8] { 3, 19, 43, 70, 71, 73, 7, 179 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[8] { 193, 145, 170, 92, 22, 4, 6, 77 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 164, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[7] { 79, 56, 166, 114, 69, 94, 180 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 72, 169 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 207
				}
			}
		});
		string text4 = "TÝnh N\u00a8ng";
		smethod_6(ref mapNavigationEntry_0, 336, "Phong L\u00a8ng ®é|" + text4, "POS|36672,96512,BÕn 1|40864,93088,BÕn 2|49440,89856.BÕn 3");
		smethod_6(ref mapNavigationEntry_0, 978, "TÇn L\u00a8ng §¹i ChiÕn|" + text, "POS |40608,112032,§iÓm TËp KÕt 1|42208,110432,§iÓm TËp KÕt 2|43648,112032,§iÓm TËp KÕt 3|42112,113568,§iÓm TËp KÕt 4");
		smethod_6(ref mapNavigationEntry_0, 355, "Sinh T|" + text, "POS|41600,88128,1|44192,91040,2|43840,85600,3|46816,88864,4|45440,86432, 5|42912,91008, 6");
		smethod_8(ref mapNavigationEntry_0, 959, "ChiÕn Long|" + text);
		smethod_9(ref mapNavigationEntry_0, "Hé Tèn|VËn Tiªu|" + text4);
		smethod_6(ref mapNavigationEntry_0, 949, "Mª Cung|" + text4, "KiÕm Gia");
		smethod_6(ref mapNavigationEntry_0, 934, "Mª Cung|" + text4, "hiªn Tr");
	}

	private static void smethod_103()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "luyÖn c«ng";
		string text3 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text2);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text3);
		smethod_6(ref mapNavigationEntry_0, 989, "Tèng Kim Bang", "POS|49312,101696,Phe Tèng|50240,98720,Phe Kim", "Báo danh TĐBH");
		smethod_7(ref mapNavigationEntry_0, 325, "Tèng Kim|Tèng|" + text, "POS|49312,101696,§iÓm b\u00b8o danh T", "§iÓm b\u00b8o danh T");
		smethod_7(ref mapNavigationEntry_0, 325, "Tèng Kim|Kim|" + text, "POS|50240,98720,§iÓm b\u00b8o danh T", "§iÓm b\u00b8o danh T");
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[6] { 844743012, 609715556, 2003660687, -1771020923, -654567069, -614731095 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[8] { 193, 145, 170, 92, 22, 4, 6, 77 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 164, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[7] { 79, 56, 166, 114, 69, 94, 180 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 72, 169 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 207
				}
			}
		});
		string text4 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text4, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 998, "Hoa S¬n ChiÕn| " + text4, "POS|46235,99226,kÕt 1|44480,97248 ,kÕt 2|46260,93690 ,kÕt 3|49216,92608,kÕt 4|49568,97856,kÕt 5");
		smethod_6(ref mapNavigationEntry_0, 355, "Doanh Tr¹i Sinh Tö ChiÕn |" + text, "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y");
		smethod_7(ref mapNavigationEntry_0, 959, text4 + "|ChiÕn Long");
		smethod_6(ref mapNavigationEntry_0, 1062, "§i §Õn Thiªn Long §Êu Tr\u00adêng|" + text, "POS| 52064,105408,TËp KÕt 1|44224, 90944,TËp KÕt 2|62336,105376 ,TËp KÕt 3|62144,115936,TËp KÕt 4|54368,110464 ,TËp kÕt 5|57024,107840,TËp kÕt 6|60096,110464,TËp kÕt 7| 57152,113696,TËp kÕt 8");
		smethod_6(ref mapNavigationEntry_0, 1022, "V\u00ad¬ng ThiÕt Thµ|" + text4, "POS|53376,107040,TËp KÕt 1|55200,108768,TËp KÕt 2|60928,107008,TËp KÕt 3|59392,108544,TËp KÕt 4|60960,114624,TËp kÕt 5| 59520,113184,TËp kÕt 6|53760,114240,TËp kÕt 7|55008,112960,TËp kÕt 8");
		smethod_6(ref mapNavigationEntry_0, 1010, "Nam Thiªn M«n|" + text, "POS|49920,101888,1|54336,103936,2|56544,101088,3|58208,109248|4");
		smethod_7(ref mapNavigationEntry_0, 1017, text4 + "|thi ®Êu Bang Héi Tinh Anh");
		smethod_6(ref mapNavigationEntry_0, 984, "§Õn L\u00a8ng Mé TÇn Thuû Hoµng|" + text, "POS |43360,113376,Thanh|40960,113408,Chu|43392,110944,HuyÒn|40992,110944,Kú");
	}

	private static void smethod_104()
	{
		string text = "thÇn hµnh";
		string text2 = "Muèn §Õn";
		int_2 = null;
		mapNavigationEntry_0 = null;
		smethod_5(ref mapNavigationEntry_0, text2 + "|µnh thÞ", null, text2 + "|Th«n tr", null, text2 + "|«n ph\u00b8i", null, "TÝnh N\u00a8ng|Phong V©n LuËn KiÕm|" + text);
		smethod_3(ref mapNavigationEntry_0, "c«ng|cÊp 90|" + text2);
		smethod_3(ref mapNavigationEntry_0, "boss H|" + text2, new int[20]
		{
			202, 76, 10, 198, 336, 75, 199, 204, 322, 203,
			225, 226, 227, 181, 205, 321, 340, 224, 342, 341
		});
		smethod_4(ref mapNavigationEntry_0, "c«ng|cÊp 80|" + text2, new LevelBracketMapGroup[1]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 206
				}
			}
		});
		string text3 = "TÝnh N\u00a8ng";
		smethod_6(ref mapNavigationEntry_0, 1, "Hé Tèng|VËn Tiªu|" + text3, "POS|49920,88352");
		smethod_6(ref mapNavigationEntry_0, 978, "L\u00a8ng Mộ|" + text3, "POS |40608,112032,Hæ|42208,110432,Long|43648,112032,Vò|42112,113568,T\u00adíc");
		smethod_6(ref mapNavigationEntry_0, 355, text3 + "|Sinh T", "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y");
		smethod_6(ref mapNavigationEntry_0, 959, "ChiÕn Long|" + text3, "POS|45376,96160,Vò Di S¬n|49536,95840,T\u00adêng V©n §éng|54432,100864,La Tiªu S¬n");
	}

	private static void smethod_105()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		string text2 = "luyÖn c«ng";
		string text3 = "thÊt thµnh ®¹i chiÕn ";
		smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|Tèng Ki", null, "Þ trÝ k");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text2);
		smethod_3(ref mapNavigationEntry_0, "ChiÕn tr\u00adêng|" + text3);
		smethod_6(ref mapNavigationEntry_0, 989, "Tèng Kim Bang", "POS|49312,101696,Phe Tèng|50240,98720,Phe Kim", "Báo danh TĐBH");
		smethod_7(ref mapNavigationEntry_0, 325, "Tèng Kim|Tèng|" + text, "POS|49312,101696,§iÓm b\u00b8o danh T", "§iÓm b\u00b8o danh T");
		smethod_7(ref mapNavigationEntry_0, 325, "Tèng Kim|Kim|" + text, "POS|50240,98720,§iÓm b\u00b8o danh T", "§iÓm b\u00b8o danh T");
		smethod_4(ref mapNavigationEntry_0, "luyÖn c«ng|" + text2, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[6] { 844743012, 609715556, 2003660687, -1771020923, -654567069, -614731095 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[8] { 193, 145, 170, 92, 22, 4, 6, 77 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 164, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[7] { 79, 56, 166, 114, 69, 94, 180 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 72, 169 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[14]
				{
					224, 320, 201, 10, 143, 151, 181, 198, 199, 202,
					203, 204, 205, 207
				}
			}
		});
		string text4 = "éng PK";
		smethod_6(ref mapNavigationEntry_0, 1009, "C©u C\u00b8|" + text4, "C©u C\u00b8");
		smethod_6(ref mapNavigationEntry_0, 333, "Hoa S¬n ph\u00b8i| " + text4, "POS|46235,99226,kÕt 1|44480,97248 ,kÕt 2|46260,93690 ,kÕt 3|49216,92608,kÕt 4|49568,97856,kÕt 5");
		smethod_6(ref mapNavigationEntry_0, 355, "§Êu tr\u00adêng sinh tö|" + text, "POS|41760,87520,kÕt 1|44224,90944,kÕt 2|43920,85484,KÕt 3|46656,88288,TËp KÕt 4|47648, 91712,TËp kÕt 3h|41472, 92736,TËp kÕt 6h|42240, 84480,TËp kÕt 9h|46432, 84288,TËp kÕt 12h");
		smethod_7(ref mapNavigationEntry_0, 959, text4 + "|ChiÕn Long");
		smethod_6(ref mapNavigationEntry_0, 1062, "§i §Õn Thiªn Long §Êu Tr\u00adêng|" + text, "POS| 52064,105408,TËp KÕt 1|44224, 90944,TËp KÕt 2|62336,105376 ,TËp KÕt 3|62144,115936,TËp KÕt 4|54368,110464 ,TËp kÕt 5|57024,107840,TËp kÕt 6|60096,110464,TËp kÕt 7| 57152,113696,TËp kÕt 8");
		smethod_6(ref mapNavigationEntry_0, 984, "L\u00a8ng Mé TÇn Thñy Hoµng|" + text4, "POS |40672,112096,kÕt 1|42144,110624,kÕt 2|43520,112000,kÕt 3|42176,113440,kÕt 4");
	}

	private static void smethod_106()
	{
		mapNavigationEntry_0 = null;
		int_2 = null;
		string text = "thÇn hµnh";
		smethod_5(ref mapNavigationEntry_0, text + "|hµnh thÞ", null, text + "|Th«n tr", null, text + "|«n ph\u00b8i", null, text + "|èng Kim");
		smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text);
		smethod_4(ref mapNavigationEntry_0, "cµy cÊp|cña t©n thñ|" + text, new LevelBracketMapGroup[7]
		{
			new LevelBracketMapGroup
			{
				levelBracket = 20,
				mapIds = new int[3] { 19, 7, 179 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 30,
				mapIds = new int[6] { 193, 170, 92, 22, 4, 6 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 40,
				mapIds = new int[4] { 21, 167, 23, 5 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 50,
				mapIds = new int[5] { 182, 164, 38, 42, 24 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 60,
				mapIds = new int[6] { 79, 56, 166, 114, 69, 94 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 70,
				mapIds = new int[5] { 319, 123, 206, 72, 169 }
			},
			new LevelBracketMapGroup
			{
				levelBracket = 80,
				mapIds = new int[8] { 181, 224, 198, 320, 181, 201, 198, 202 }
			}
		});
		string text2 = "éng PK";
		smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text);
		smethod_7(ref mapNavigationEntry_0, 959, text2 + "|ChiÕn Long", "POS|45376,96160,Vò Di S¬n|49536,95840,T\u00adêng V©n|54432,100864,La Tiªu S¬n");
		smethod_6(ref mapNavigationEntry_0, 333, text, "Hoa-S¬n|Hoa S¬n|", "Hoa S¬n ph\u00b8i");
	}

	public static bool smethod_107()
	{
		string_0 = string_1;
		if (int_1 == 7)
		{
			smethod_40();
		}
		else if (int_1 == 662045)
		{
			smethod_106();
		}
		else if (int_1 == 662044)
		{
			smethod_98();
		}
		else if (int_1 == 662043)
		{
			smethod_77();
		}
		else if (int_1 == 662042)
		{
			smethod_105();
		}
		else if (int_1 == 622041)
		{
			smethod_76();
		}
		else if (int_1 == 622039)
		{
			smethod_103();
		}
		else if (int_1 == 622038)
		{
			smethod_102();
		}
		else if (int_1 == 622037)
		{
			smethod_101();
		}
		else if (int_1 == 662035)
		{
			smethod_100();
		}
		else if (int_1 == 622028)
		{
			smethod_96();
		}
		else if (int_1 == 622033)
		{
			smethod_104();
		}
		else if (int_1 == 622031)
		{
			smethod_74();
		}
		else if (int_1 == 622029)
		{
			smethod_47();
		}
		else if (int_1 == 622009)
		{
			smethod_93();
		}
		else if (int_1 == 5061991)
		{
			smethod_97();
		}
		else if (int_1 == 622010)
		{
			smethod_95();
		}
		else if (int_1 == 622011)
		{
			smethod_94();
		}
		else if (int_1 == 622012)
		{
			smethod_80();
		}
		else if (int_1 == 622013)
		{
			smethod_81();
		}
		else if (int_1 == 622032)
		{
			smethod_87();
		}
		else if (int_1 == 622014)
		{
			smethod_86();
		}
		else if (int_1 == 622015)
		{
			smethod_91();
		}
		else if (int_1 == 622016)
		{
			smethod_14();
		}
		else if (int_1 == 622017)
		{
			smethod_79();
		}
		else if (int_1 == 622018)
		{
			smethod_92();
		}
		else if (int_1 == 622019)
		{
			smethod_88();
		}
		else if (int_1 == 622020)
		{
			smethod_73();
		}
		else if (int_1 == 622021)
		{
			smethod_75();
		}
		else if (int_1 == 622022)
		{
			smethod_82();
		}
		else if (int_1 == 622023)
		{
			smethod_83();
		}
		else if (int_1 == 12)
		{
			smethod_41();
		}
		else if (int_1 != 19)
		{
			if (int_1 == 622024)
			{
				smethod_84();
			}
			else if (int_1 == 622025)
			{
				smethod_85();
			}
			else if (int_1 != 34)
			{
				if (int_1 != 38)
				{
					if (int_1 == 622026)
					{
						smethod_89();
					}
					else if (int_1 != 40)
					{
						if (int_1 != 41)
						{
							if (int_1 == 622027)
							{
								smethod_90();
							}
							else if (int_1 != 47)
							{
								if (int_1 != 52)
								{
									if (int_1 != 53)
									{
										if (int_1 == 121)
										{
											smethod_10();
										}
										else if (int_1 != 58)
										{
											if (int_1 != 62)
											{
												if (int_1 != 65)
												{
													if (int_1 == 68)
													{
														smethod_58();
													}
													else if (int_1 != 88)
													{
														if (int_1 != 105)
														{
															if (int_1 != 111)
															{
																if (int_1 != 118)
																{
																	if (int_1 != 121)
																	{
																		if (int_1 != 130)
																		{
																			if (int_1 != 131)
																			{
																				if (int_1 == 134)
																				{
																					smethod_55();
																				}
																				else if (int_1 != 137)
																				{
																					if (int_1 == 142)
																					{
																						smethod_54(bool_0: true);
																					}
																					else if (int_1 == 144)
																					{
																						smethod_71();
																					}
																					else if (int_1 == 146)
																					{
																						smethod_69();
																					}
																					else if (int_1 == 152)
																					{
																						smethod_64();
																					}
																					else if (int_1 == 156)
																					{
																						smethod_38();
																					}
																					else if (int_1 != 158)
																					{
																						if (int_1 == 1000)
																						{
																							smethod_11();
																						}
																						else if (int_1 == 1001)
																						{
																							smethod_12();
																						}
																						else if (int_1 != 1002)
																						{
																							if (int_1 != 1003)
																							{
																								if (int_1 != 1004)
																								{
																									if (int_1 != 1005)
																									{
																										if (int_1 != 622030)
																										{
																											if (int_1 == 1007)
																											{
																												smethod_18();
																											}
																											else if (int_1 == 1008)
																											{
																												smethod_19();
																											}
																											else if (int_1 != 1010)
																											{
																												if (int_1 == 1011)
																												{
																													smethod_20(bool_0: true);
																												}
																												else if (int_1 == 1012)
																												{
																													smethod_24();
																												}
																												else if (int_1 != 1013)
																												{
																													if (int_1 == 1014)
																													{
																														smethod_26();
																													}
																													else if (int_1 != 1015)
																													{
																														if (int_1 == 1016)
																														{
																															smethod_28();
																														}
																														else if (int_1 != 1017)
																														{
																															if (int_1 == 1018)
																															{
																																smethod_14(bool_0: true);
																															}
																															else if (int_1 != 622036)
																															{
																																if (int_1 != 1020)
																																{
																																	if (int_1 != 1021)
																																	{
																																		if (int_1 != 1022)
																																		{
																																			if (int_1 != 1023)
																																			{
																																				if (int_1 == 1024)
																																				{
																																					smethod_35();
																																				}
																																				else if (int_1 == 1025)
																																				{
																																					smethod_36();
																																				}
																																				else if (int_1 == 1026)
																																				{
																																					smethod_37();
																																				}
																																				else if (int_1 == 1027)
																																				{
																																					smethod_51();
																																				}
																																				else if (int_1 == 1028)
																																				{
																																					smethod_67();
																																				}
																																				else if (int_1 == 1029)
																																				{
																																					smethod_68();
																																				}
																																				else if (int_1 != 1030)
																																				{
																																					if (int_1 != 1031)
																																					{
																																						if (int_1 != 1032)
																																						{
																																							if (int_1 == 1033)
																																							{
																																								smethod_21();
																																							}
																																							else if (int_1 == 1034)
																																							{
																																								smethod_30();
																																							}
																																							else
																																							{
																																								smethod_10();
																																							}
																																						}
																																						else
																																						{
																																							smethod_63();
																																						}
																																					}
																																					else
																																					{
																																						smethod_62();
																																					}
																																				}
																																				else
																																				{
																																					smethod_46();
																																				}
																																			}
																																			else
																																			{
																																				smethod_32();
																																			}
																																		}
																																		else
																																		{
																																			smethod_34();
																																		}
																																	}
																																	else
																																	{
																																		smethod_32(bool_0: true);
																																	}
																																}
																																else
																																{
																																	smethod_31(bool_0: true);
																																}
																															}
																															else
																															{
																																smethod_99();
																															}
																														}
																														else
																														{
																															smethod_29();
																														}
																													}
																													else
																													{
																														smethod_27();
																													}
																												}
																												else
																												{
																													smethod_25();
																												}
																											}
																											else
																											{
																												smethod_20();
																											}
																										}
																										else
																										{
																											smethod_17();
																										}
																									}
																									else
																									{
																										smethod_16();
																									}
																								}
																								else
																								{
																									smethod_15();
																								}
																							}
																							else
																							{
																								smethod_14();
																							}
																						}
																						else
																						{
																							smethod_13();
																						}
																					}
																					else
																					{
																						smethod_72();
																					}
																				}
																				else
																				{
																					smethod_70();
																				}
																			}
																			else
																			{
																				smethod_53(bool_0: true);
																			}
																		}
																		else
																		{
																			smethod_22();
																		}
																	}
																	else
																	{
																		smethod_45();
																	}
																}
																else
																{
																	smethod_56();
																}
															}
															else
															{
																smethod_43(bool_0: true);
															}
														}
														else
														{
															smethod_53(bool_0: false);
														}
													}
												}
												else
												{
													smethod_59();
												}
											}
											else
											{
												smethod_65();
											}
										}
										else
										{
											smethod_61();
										}
									}
									else
									{
										smethod_57();
									}
								}
								else
								{
									smethod_52();
								}
							}
							else
							{
								smethod_66();
							}
						}
						else
						{
							smethod_50();
						}
					}
					else
					{
						smethod_49();
					}
				}
				else
				{
					smethod_33();
				}
			}
			else
			{
				smethod_60();
			}
		}
		else
		{
			smethod_43(bool_0: false);
		}
		new Thread(Class44.smethod_0).Start();
		return string_0 != null && mapNavigationEntry_0 != null;
	}
}
