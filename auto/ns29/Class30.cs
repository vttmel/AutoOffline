namespace ns29;

internal class Class30
{
	public static int int_0 = 1187916127;

	public static int int_1 = 112;

	public static int int_2 = 113;

	public static int int_3 = 118;

	public static int int_4 = 119;

	public static int int_5 = 120;

	public static int int_6 = 121;

	public static int int_7 = 107;

	public static int int_8 = 187;

	public static int int_9 = 109;

	public static int int_10 = 189;

	public static int int_11 = 90;

	public static int int_12 = 88;

	public static int int_13 = 75;

	public static int int_14 = 65;

	public static int int_15 = 83;

	public static int int_16 = 70;

	public static int int_17 = 71;

	public static int int_18 = 49;

	public static GStruct42[] gstruct42_0 = new GStruct42[10]
	{
		new GStruct42
		{
			string_0 = "A",
			int_0 = 65
		},
		new GStruct42
		{
			string_0 = "S",
			int_0 = 83
		},
		new GStruct42
		{
			string_0 = "Z",
			int_0 = 90
		},
		new GStruct42
		{
			string_0 = "X",
			int_0 = 88
		},
		new GStruct42
		{
			string_0 = "4",
			int_0 = 52
		},
		new GStruct42
		{
			string_0 = "5",
			int_0 = 53
		},
		new GStruct42
		{
			string_0 = "6",
			int_0 = 54
		},
		new GStruct42
		{
			string_0 = "7",
			int_0 = 55
		},
		new GStruct42
		{
			string_0 = "8",
			int_0 = 56
		},
		new GStruct42
		{
			string_0 = "9",
			int_0 = 57
		}
	};

	public static GStruct42[] gstruct42_1 = new GStruct42[9]
	{
		new GStruct42
		{
			string_0 = "1",
			int_0 = 49
		},
		new GStruct42
		{
			string_0 = "2",
			int_0 = 50
		},
		new GStruct42
		{
			string_0 = "3",
			int_0 = 51
		},
		new GStruct42
		{
			string_0 = "4",
			int_0 = 52
		},
		new GStruct42
		{
			string_0 = "5",
			int_0 = 53
		},
		new GStruct42
		{
			string_0 = "6",
			int_0 = 54
		},
		new GStruct42
		{
			string_0 = "7",
			int_0 = 55
		},
		new GStruct42
		{
			string_0 = "8",
			int_0 = 56
		},
		new GStruct42
		{
			string_0 = "9",
			int_0 = 57
		}
	};

	public static GStruct42[] gstruct42_2 = new GStruct42[2]
	{
		new GStruct42
		{
			string_0 = "F2",
			int_0 = 113
		},
		new GStruct42
		{
			string_0 = "A",
			int_0 = 65
		}
	};

	public static int smethod_0(GStruct42[] gstruct42_3, string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < gstruct42_3.GetLength(0))
			{
				if (string_0 == gstruct42_3[num].string_0)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return gstruct42_3[num].int_0;
	}

	public static string smethod_1(GStruct42[] gstruct42_3, int int_19)
	{
		for (int i = 0; i < gstruct42_3.GetLength(0); i++)
		{
			if (int_19 == gstruct42_3[i].int_0)
			{
				return gstruct42_3[i].string_0;
			}
		}
		return null;
	}
}
