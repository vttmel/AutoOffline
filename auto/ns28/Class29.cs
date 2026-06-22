using System;
using System.Threading;
using ns1;
using ns10;
using ns100;
using ns11;
using ns23;
using ns34;
using ns36;
using ns42;
using ns43;
using ns53;
using ns61;
using ns71;
using ns85;
using ns88;

namespace ns28;

internal class Class29
{
	public struct CityTeleportData
	{
		public string string_0;

		public int int_0;

		public uint[,] uint_0;
	}

	public static string string_0;

	public static string string_1;

	public static string string_2;

	public static MapNavigationEntry[] mapNavigationEntry_0;

	private static uint[,] uint_0;

	private static uint[,] uint_1;

	private static uint[,] uint_2;

	private static uint[,] uint_3;

	private static uint[,] uint_4;

	private static uint[,] uint_5;

	private static uint[,] uint_6;

	private static CityTeleportData[] cityTeleportData_0;

	private static int[] int_0;

	private static string string_3;

	private static Random random_0;

	static Class29()
	{
		string_0 = "\u00b8c Nh©n Cèc    =1230|MÆc Dung Cèc   =1231|YÕn S¬n §éng   =1232|B¶o S¬n §éng   =1233|§¹i Phó M«n    =1208|§¹i Quý M«n    =1209";
		string_1 = "dZY9bxtHEIb/ypZUd7f3XbggqYAMeCRsiyYSCCkOLMQrRAeGWAi43kXKxE4TKDDixJJsCQhiORSQpNj9Y5mdd/c+JLKhhOddzs7OvDvL49n8O7HYiCP1aS0G6r+leCJ834+r47YwK07Bk+qoEFN1v2SU6yte70Wy5hyjEYLqeEyBDtUNxTkRk3K9qrfxwmSHavfyQsph+FBUH9RH+p/1cMeX5+rqHGoEdaB/NjFPNufqujmgF/kI3pXd1pFXzV+pG31NYQd0qFX3tFm8K3Y7tXTXgia3DPJ8c67fnHVL70n5WGyFluFjuQ4s6dBHO/rpybgruIPKpMvbG6Vdqdkkq4b6D1uXTrQweKjUCXg+S+yQYfFSPNvoH86gSFacfabqWgw3lIMPNditSqjhbjWAGrFK/tC3S7GwNlG3+or+nOnX9BliYcwLJyv9rhB5YRZ94EVQk2pPL3yv2tkG3+9wVx5fVjs77geVWdIq25BSvlnaEmTZHplrQPntkQPI/h45hCz3yBHkfanFkMOqN5gfiFGpf6ea0J35iDkhrTAoCJZAEdBUv6Mgd+eAMeBwpa42Yr5Sd3RfWEiq3nBKgtqWYoY9DQ9CcGrQ61Nq7ScEDyLg2Yl+vxTjUv+4Bo/BKTLFwXVkTuHzPofZ0nr9a8GYRkobb/Rb4Ah4oN+saQpskQrNJ6ZDcpJxRZ0jTbVef3Qg8pdUk29w9w2PQnAclva4xPooAif/rK3IOAbur8XTlf4LjEKPiS30BZ2psKeJQ9DZifqbevUFtY0jUPryZ0qEivL2ewhxO4j+0y6n0IP8gIphWnlocjE4CYEX+hfaLde3KHgSAdvbMFZfLI9dFCppU+8ksX5gQl+6x/I0dP3XtyJX2yWWpw+9Uj9MafxAcS9Tag3zQkztnmlqPaEuT2ntJc6TZqBc0rk7ZeZZn7wyzVyYxVSZaySZ+a1Gj8qNfQb8TIKbGpqPO5goCyw2wSngZ9DQLea7NNa/2dWu+frCvIylM0tmu2+uz5xqDJi0HVS7IksdpipO9Y1NO0Ob2YZT/Y+BkqZFA+v+SJoSDXZxJQ2HhtJJLkADtPjpCpZnlQVrlVGptuJ5UQJGbf/QhLhf2i2dU9iXzdWXNG97zwZ8CY0Tx/Y8kqYtc5opLAH6FurLdnAatYxzusG1xSUN2t5sbjIv1pSgTdsPQWfm94Mx8hPgqIXdWVmIWwLPRKaU9chUJf/q68kLoBSILvBkRU8TswxsMujPRkykBzI14Nua+vA5JlFe2trQjwPG3CJ6Q/8FDUDpdSHFtcPN4LG6O62dLs0YnoxtDear0jxHzGPww1L/xPlu3ZYJBJTHTkpJvw6YDun6PS/c0szmQR7nolkfhZGbwqaXjevcBOXk+sjPDc/O/ZT0g4qd+MgsYQYXdbOLvP8B";
		string_2 = "ThÇn Hµnh Phï (Thµnh Cæ)|ThÇn Hµnh Phï (B¶n §å Ho¹t §éng)";
		mapNavigationEntry_0 = new MapNavigationEntry[433]
		{
			new MapNavigationEntry
			{
				int_0 = 1,
				string_0 = "Ph\u00adîng T\u00adêng",
				string_1 = "b¾c",
				string_3 = "Ph\u00adîng T\u00adêng",
				string_2 = "Ph\u00adîng T\u00adêng"
			},
			new MapNavigationEntry
			{
				int_0 = 2,
				string_0 = "Hoa S¬n",
				string_2 = "Hoa S¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 3,
				string_0 = "KiÕm C\u00b8c T©y B¾",
				string_3 = "KiÕm C\u00b8c",
				string_2 = "Nam - Ph\u00adîng T|T©y B¾c|KiÕm c\u00b8c"
			},
			new MapNavigationEntry
			{
				int_0 = 4,
				string_0 = "Kim Quang ®éng",
				string_3 = "Kim Quang",
				string_2 = "Kim Quang"
			},
			new MapNavigationEntry
			{
				int_0 = 5,
				string_0 = "Kinh Hoµng ®éng",
				string_3 = "Kinh Hoµng",
				string_2 = "Kinh Hoµng"
			},
			new MapNavigationEntry
			{
				int_0 = 6,
				string_0 = "Táa V©n ®éng",
				string_3 = "Táa V©n",
				string_2 = "Táa V©n"
			},
			new MapNavigationEntry
			{
				int_0 = 7,
				string_0 = "TÇn L\u00a8ng",
				string_3 = "L\u00a8ng TÇn Thñy Hoµng",
				string_2 = "TÇn L\u00a8ng|L\u00a8ng TÇn Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 8,
				string_0 = "L\u00a8ng TÇn Thñy H",
				string_3 = "tÇng 1 TÇn|L\u00a8ng TÇn Thñy Hoµng",
				string_2 = "tÇng 1 TÇn|l\u00a8ng tÇng 1|L\u00a8ng TÇn TÇng 1|L\u00a8ng TÇn Thñy Hoµng"
			},
			new MapNavigationEntry
			{
				int_0 = 9,
				string_0 = "Tr\u00adêng Giang Ng",
				string_3 = "Tr\u00adêng Giang",
				string_2 = "Tr\u00adêng Giang|Tr\u00aduêng Nguyªn"
			},
			new MapNavigationEntry
			{
				int_0 = 10,
				string_0 = "Nh¹n Th¹ch ®éng",
				string_3 = "Nh¹n Th¹ch",
				string_2 = "Nh¹n Th¹ch"
			},
			new MapNavigationEntry
			{
				int_0 = 11,
				string_0 = "Thµnh §«",
				string_1 = "®«ng|§«ng",
				string_3 = "Thµnh §«",
				string_2 = "Thµnh §«"
			},
			new MapNavigationEntry
			{
				int_0 = 12,
				string_0 = "§Þa ®¹o hËu viÖ",
				string_3 = "HËu ViÖn TÝn T\u00adíng Tù",
				string_2 = "hÇu viªn|TÝn T\u00adíng"
			},
			new MapNavigationEntry
			{
				int_0 = 13,
				string_0 = "Nga My ph\u00b8i",
				string_2 = "Nga M|T\u00ad Qu\u00b8 Nh"
			},
			new MapNavigationEntry
			{
				int_0 = 14,
				string_0 = "M·nh Hæ ®éng",
				string_3 = "M·nh Hæ",
				string_2 = "M·nh Hæ"
			},
			new MapNavigationEntry
			{
				int_0 = 19,
				string_0 = "KiÕm C\u00b8c T©y Na",
				string_3 = "KiÕm C\u00b8c Thôc §¹o",
				string_2 = "KiÕm c\u00b8c|T©y Nam|c\u00b8c thôc ®¹o"
			},
			new MapNavigationEntry
			{
				int_0 = 20,
				string_0 = "Giang T©n Th«n",
				string_3 = "Giang T©n",
				string_2 = "Giang T©n"
			},
			new MapNavigationEntry
			{
				int_0 = 21,
				string_0 = "Thanh Thµnh s¬n",
				string_3 = "Thanh Thµnh",
				string_2 = "POS|92224,116736,muèn ®i VËn Ti|62368,111968,muèn ®i Tr¶ T|85334,121740,muèn ®i C\u00adíp T\u0001\u0001Thanh Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 22,
				string_0 = "B¹ch V©n ®éng",
				string_3 = "B¹ch V©n",
				string_2 = "B¹ch V©n"
			},
			new MapNavigationEntry
			{
				int_0 = 23,
				string_0 = "ThÇn Tiªn ®éng",
				string_3 = "ThÇn Tiªn",
				string_2 = "ThÇn Tiªn"
			},
			new MapNavigationEntry
			{
				int_0 = 24,
				string_0 = "H\u00adëng Thñy §éng",
				string_3 = "H\u00adëng Thñy",
				string_2 = "H\u00adëng Thñy §éng -|H\u00adëng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 25,
				string_0 = "§\u00adêng M«n",
				string_2 = "§\u00adêng M«n"
			},
			new MapNavigationEntry
			{
				int_0 = 26,
				string_0 = "Tróc T¬ ®éng tÇ",
				string_2 = "Tróc T¬"
			},
			new MapNavigationEntry
			{
				int_0 = 27,
				string_0 = "Tróc T¬ ®éng tÇ",
				string_2 = "Tróc T¬ ®éng tÇng 2"
			},
			new MapNavigationEntry
			{
				int_0 = 30,
				string_0 = "Phóc Thµnh|V« Danh Thµnh",
				string_1 = "b¾c",
				string_2 = "Phóc Thµnh|V« Danh Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 31,
				string_0 = "ViÖt Thµnh",
				string_1 = "b¾c",
				string_2 = "ViÖt Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 36,
				string_0 = "Kh\u00b8nh Hßa Thµnh",
				string_1 = "b¾c",
				string_2 = "Kh\u00b8nh Hßa"
			},
			new MapNavigationEntry
			{
				int_0 = 37,
				string_0 = "BiÖn Kinh",
				string_1 = "®«ng|§«ng",
				string_3 = "BiÖn Kinh",
				string_2 = "BiÖn Kinh"
			},
			new MapNavigationEntry
			{
				int_0 = 38,
				string_0 = "ThiÕt th\u00b8p tÇng",
				string_3 = "ThiÕt Th\u00b8p mª cung",
				string_2 = "ThiÕt th\u00b8p|th\u00b8p tÇng 1|th\u00b8p mª cung tÇng 1|Mª Cung ThiÕp"
			},
			new MapNavigationEntry
			{
				int_0 = 39,
				string_0 = "ThiÕt th\u00b8p tÇng",
				string_2 = "ThiÕt th\u00b8p tÇng 2|th\u00b8p mª cung tÇng 2"
			},
			new MapNavigationEntry
			{
				int_0 = 40,
				string_0 = "ThiÕt th\u00b8p tÇng",
				string_3 = "Thiªn TÇm th\u00b8p tÇng 3",
				string_2 = "m th\u00b8p tÇng 3|ThiÕt th\u00b8p tÇng 3|th\u00b8p mª cung tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 41,
				string_0 = "Phôc Ng\u00adu S¬n T",
				string_3 = "Phôc Ng\u00adu T©y",
				string_2 = "Phôc Ng\u00adu T©y|Phôc Ng\u00adu S¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 42,
				string_0 = "Thiªn T©m ®éng",
				string_3 = "ªn T©m ®|ªn T©m §|ªn TÇm ®|ªn TÇm §",
				string_2 = "ªn T©m ®|ªn T©m §|ªn TÇm ®|ªn TÇm §"
			},
			new MapNavigationEntry
			{
				int_0 = 43,
				string_0 = "KiÕm C\u00b8c Trung",
				string_2 = "KiÕm C\u00b8c trung"
			},
			new MapNavigationEntry
			{
				int_0 = 47,
				string_0 = "Léc Thµnh|Hµ Thµnh",
				string_1 = "b¾c",
				string_2 = "Léc Thµnh|Hµ Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 49,
				string_0 = "Thiªn NhÉn Gi\u00b8o",
				string_2 = "Thiªn NhÉn"
			},
			new MapNavigationEntry
			{
				int_0 = 51,
				string_0 = "Th\u00b8nh ®éng tÇng",
				string_2 = "Th\u00b8nh ®éng tÇng 1|Th\u00b8nh §éng"
			},
			new MapNavigationEntry
			{
				int_0 = 52,
				string_0 = "Th\u00b8nh ®éng tÇng",
				string_2 = "Th\u00b8nh ®éng tÇng 2"
			},
			new MapNavigationEntry
			{
				int_0 = 53,
				string_0 = "Ba L\u00a8ng huyÖn",
				string_3 = "Ba L\u00a8ng",
				string_2 = "Ba L\u00a8ng"
			},
			new MapNavigationEntry
			{
				int_0 = 54,
				string_0 = "Nam Nh¹c trÊn",
				string_2 = "Nam Nh¹c"
			},
			new MapNavigationEntry
			{
				int_0 = 55,
				string_0 = "§µo Hoa Nguyªn",
				string_2 = "Hoa Ngu"
			},
			new MapNavigationEntry
			{
				int_0 = 56,
				string_0 = "Hoµnh S¬n Ph\u00b8i",
				string_3 = "nh s¬n",
				string_2 = "nh s¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 59,
				string_0 = "Thiªn V\u00ad¬ng Ban",
				string_2 = "Thiªn V\u00ad¬ng"
			},
			new MapNavigationEntry
			{
				int_0 = 60,
				string_0 = "Qu¶ng B×nh Thµnh",
				string_1 = "b¾c",
				string_2 = "Qu¶ng B×nh"
			},
			new MapNavigationEntry
			{
				int_0 = 61,
				string_0 = "Ninh ThuËn Thµnh",
				string_1 = "b¾c",
				string_2 = "Ninh ThuËn"
			},
			new MapNavigationEntry
			{
				int_0 = 66,
				string_0 = "§\u00b8y §éng §×nh h",
				string_2 = "§éng §×nh Hå|×nh hå tÇng 1"
			},
			new MapNavigationEntry
			{
				int_0 = 67,
				string_0 = "§\u00b8y §éng §×nh h",
				string_2 = "\u00b8y §éng §×nh Hå TÇng 2"
			},
			new MapNavigationEntry
			{
				int_0 = 68,
				string_0 = "Thanh Loa ®¶o",
				string_2 = "Thanh Loa"
			},
			new MapNavigationEntry
			{
				int_0 = 69,
				string_0 = "Thanh Loa ®¶o s",
				string_3 = "Thanh Loa ®éng",
				string_2 = "Thanh Loa ®éng|Thanh Loa §éng"
			},
			new MapNavigationEntry
			{
				int_0 = 70,
				string_0 = "Vò L\u00a8ng s¬n",
				string_3 = "Vò L\u00a8ng S¬n",
				string_2 = "L\u00a8ng s¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 71,
				string_0 = "B¹ch Thñy ®éng",
				string_3 = "B¹ch Thñy",
				string_2 = "B¹ch Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 72,
				string_0 = "§¹i Tï ®éng",
				string_3 = "§¹i Tï",
				string_2 = "¹i Tï"
			},
			new MapNavigationEntry
			{
				int_0 = 73,
				string_0 = "Phôc L\u00adu ®éng",
				string_3 = "Phôc L\u00adu ®éng",
				string_2 = "Phôc L\u00adu"
			},
			new MapNavigationEntry
			{
				int_0 = 74,
				string_0 = "Miªu LÜnh",
				string_3 = "Miªu LÜnh",
				string_2 = "Miªu LÜnh"
			},
			new MapNavigationEntry
			{
				int_0 = 75,
				string_0 = "Kho¶ Lang §éng",
				string_3 = "Kho¶ Lang|Kháa Lang",
				string_2 = "Kho¶ Lang|Kháa Lang|Xi V\u00adu|Kho¶\u0001Lang|Kháa\u0001Lang|Xi\u0001V\u00adu"
			},
			new MapNavigationEntry
			{
				int_0 = 76,
				string_0 = "S¬n B¶o ®éng",
				string_3 = "S¬n B¶o|Kho¶ Lang|Kháa Lang|Xi V\u00adu|Kho¶\u0001Lang|Kháa\u0001Lang|Xi\u0001V\u00adu",
				string_2 = "S¬n B¶o"
			},
			new MapNavigationEntry
			{
				int_0 = 77,
				string_0 = "YÕn Tö ®éng",
				string_3 = "YÕn Tö",
				string_2 = "YÕn Tö"
			},
			new MapNavigationEntry
			{
				int_0 = 78,
				string_0 = "T\u00ad¬ng D\u00ad¬ng",
				string_1 = "b¾c",
				string_3 = "T\u00ad¬ng D\u00ad¬ng",
				string_2 = "T\u00ad¬ng D\u00ad¬ng"
			},
			new MapNavigationEntry
			{
				int_0 = 79,
				string_0 = "MËt ®¹o Nha m«n",
				string_2 = "Nha m«n|M«n MËt"
			},
			new MapNavigationEntry
			{
				int_0 = 80,
				string_0 = "D\u00ad¬ng Ch©u",
				string_1 = "t©m",
				string_3 = "D\u00ad¬ng Ch©u",
				string_2 = "D\u00ad¬ng Ch©u"
			},
			new MapNavigationEntry
			{
				int_0 = 81,
				string_0 = "Vâ §ang Ph\u00b8i",
				string_2 = "Vâ §ang"
			},
			new MapNavigationEntry
			{
				int_0 = 83,
				string_0 = "Háa Lang ®éng",
				string_3 = "Háa Lang",
				string_2 = "Háa Lang"
			},
			new MapNavigationEntry
			{
				int_0 = 86,
				string_0 = "§µ Thµnh",
				string_1 = "b¾c",
				string_2 = "§µ Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 90,
				string_0 = "Phôc Ng\u00adu S¬n §",
				string_3 = "Phôc Ng\u00adu §«ng",
				string_2 = "Ng\u00adu §«ng|Ng\u00adu S¬n §«ng"
			},
			new MapNavigationEntry
			{
				int_0 = 91,
				string_0 = "Mª cung Kª Qu\u00b8n",
				string_3 = "Kª Qu\u00b8n",
				string_2 = "Kª Qu\u00b8n|Mª cung"
			},
			new MapNavigationEntry
			{
				int_0 = 92,
				string_0 = "Thôc C\u00ad¬ng s¬n",
				string_3 = "Thôc C\u00ad¬ng S¬n",
				string_2 = "Thôc C\u00ad¬ng"
			},
			new MapNavigationEntry
			{
				int_0 = 93,
				string_0 = "TiÕn Cóc ®éng",
				string_3 = "TiÕn Cóc",
				string_2 = "TiÕn Cóc"
			},
			new MapNavigationEntry
			{
				int_0 = 94,
				string_0 = "Linh Cèc ®éng",
				string_3 = "Linh Cèc",
				string_2 = "Linh C"
			},
			new MapNavigationEntry
			{
				int_0 = 99,
				string_0 = "VÜnh L¹c trÊn",
				string_3 = "VÜnh L¹c",
				string_2 = "VÜnh L¹c"
			},
			new MapNavigationEntry
			{
				int_0 = 100,
				string_0 = "Chu Tiªn trÊn",
				string_3 = "Chu Tiªn",
				string_2 = "Chu Tiªn"
			},
			new MapNavigationEntry
			{
				int_0 = 101,
				string_0 = "§¹o H\u00ad¬ng th«n",
				string_3 = "§¹o H\u00ad¬ng",
				string_2 = "§¹o H\u00ad¬ng"
			},
			new MapNavigationEntry
			{
				int_0 = 103,
				string_0 = "ThiÕu L©m ph\u00b8i",
				string_2 = "ThiÕu L©m"
			},
			new MapNavigationEntry
			{
				int_0 = 104,
				string_0 = "B×nh ThuËn Thµnh",
				string_1 = "b¾c",
				string_2 = "B×nh ThuËn"
			},
			new MapNavigationEntry
			{
				int_0 = 112,
				string_0 = "Gia Lai Thµnh",
				string_1 = "b¾c",
				string_2 = "Gia Lai"
			},
			new MapNavigationEntry
			{
				int_0 = 114,
				string_0 = "108 La H\u00b8n trËn",
				string_2 = "108 La|La h\u00b8n"
			},
			new MapNavigationEntry
			{
				int_0 = 115,
				string_0 = "C\u00b8i Bang",
				string_2 = "C\u00b8i Bang"
			},
			new MapNavigationEntry
			{
				int_0 = 116,
				string_0 = "T\u00adêng V©n ®éng",
				string_2 = "Tuêng V©n §éng TÇng 1|T\u00adêng V©n ®éng tÇng 1|T\u00adêng V©n §én"
			},
			new MapNavigationEntry
			{
				int_0 = 117,
				string_0 = "T\u00adêng V©n ®éng",
				string_2 = "T\u00adêng V©n ®éng tÇng 2|T\u00aduêng V©n §éng TÇng 2|T\u00adêng V©n §éng"
			},
			new MapNavigationEntry
			{
				int_0 = 118,
				string_0 = "T\u00adêng V©n ®éng",
				string_2 = "T\u00adêng V©n ®éng tÇng 3|T\u00adêng V©n §éng tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 119,
				string_0 = "T\u00adêng V©n ®éng",
				string_2 = "T\u00adêng V©n ®éng tÇng 4|T\u00adêng V©n §éng tÇng 4"
			},
			new MapNavigationEntry
			{
				int_0 = 120,
				string_0 = "T\u00adêng V©n ®éng",
				string_2 = "T\u00adêng V©n ®éng tÇng 5"
			},
			new MapNavigationEntry
			{
				int_0 = 121,
				string_0 = "Long M«n trÊn",
				string_3 = "Long M«n",
				string_2 = "Long M«n"
			},
			new MapNavigationEntry
			{
				int_0 = 122,
				string_0 = "Hoµng Hµ Nguyªn",
				string_3 = "Hoµng Hµ Nguyªn",
				string_2 = "Hoµng Hµ Nguyªn"
			},
			new MapNavigationEntry
			{
				int_0 = 123,
				string_0 = "L·o Hæ ®éng",
				string_3 = "L·o Hæ",
				string_2 = "L·o Hæ"
			},
			new MapNavigationEntry
			{
				int_0 = 124,
				string_0 = "C\u00b8n Viªn ®éng",
				string_3 = "n Viªn",
				string_2 = "n Viªn"
			},
			new MapNavigationEntry
			{
				int_0 = 125,
				string_0 = "L\u00adu Tiªn ®éng t",
				string_2 = "L\u00adu Tiªn"
			},
			new MapNavigationEntry
			{
				int_0 = 126,
				string_0 = "L\u00adu Tiªn ®éng t",
				string_2 = "L\u00adu Tiªn ®éng tÇng 2"
			},
			new MapNavigationEntry
			{
				int_0 = 127,
				string_0 = "L\u00adu Tiªn ®éng t",
				string_2 = "L\u00adu Tiªn ®éng tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 128,
				string_0 = "L\u00adu Tiªn ®éng t",
				string_2 = "L\u00adu Tiªn ®éng tÇng 4"
			},
			new MapNavigationEntry
			{
				int_0 = 129,
				string_0 = "L\u00adu Tiªn ®éng t",
				string_2 = "L\u00adu Tiªn ®éng TÇng 5 -|Tiªn ®éng tÇng 5"
			},
			new MapNavigationEntry
			{
				int_0 = 130,
				string_0 = "L\u00adu Tiªn ®éng t",
				string_2 = "L\u00adu Tiªn ®éng tÇng 6"
			},
			new MapNavigationEntry
			{
				int_0 = 131,
				string_0 = "C«n L«n ph\u00b8i",
				string_2 = "C«n L«n"
			},
			new MapNavigationEntry
			{
				int_0 = 132,
				string_0 = "B\u00a8ng HuyÖt ®éng",
				string_2 = "B\u00a8ng HuyÖt"
			},
			new MapNavigationEntry
			{
				int_0 = 135,
				string_0 = "KiÕn TÝnh Phong",
				string_2 = "KiÕn TÝnh Phong"
			},
			new MapNavigationEntry
			{
				int_0 = 136,
				string_0 = "Kho\u00b8i Ho¹t L©m",
				string_3 = "Sa M¹c",
				string_2 = "Kho\u00b8i Ho¹t L©m"
			},
			new MapNavigationEntry
			{
				int_0 = 137,
				string_0 = "Thä Thµnh|Kinh Thµnh",
				string_1 = "b¾c",
				string_2 = "Thä Thµnh|Kinh Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 139,
				string_0 = "Sµi Thµnh|C\u00b8t Thµnh",
				string_1 = "b¾c",
				string_2 = "Sµi Thµnh|C\u00b8t Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 140,
				string_0 = "D\u00adîc V\u00ad¬ng Cèc",
				string_3 = "D\u00adîc V\u00ad¬ng",
				string_2 = "D\u00adîc V\u00ad¬ng Cèc"
			},
			new MapNavigationEntry
			{
				int_0 = 141,
				string_0 = "D\u00adîc V\u00ad¬ng ®éng",
				string_3 = "D\u00adîc V\u00ad¬ng",
				string_2 = "D\u00adîc V\u00ad¬ng §éng (TÇng 1)|D\u00adîc V\u00ad¬ng ®éng tÇng 1"
			},
			new MapNavigationEntry
			{
				int_0 = 142,
				string_0 = "D\u00adîc V\u00ad¬ng ®éng",
				string_2 = "D\u00adîc V\u00ad¬ng ®éng tÇng 2|D\u00adîc V\u00ad¬ng §éng TÇng 2|D\u00aduîc V\u00adu¬ng §éng TÇng 2"
			},
			new MapNavigationEntry
			{
				int_0 = 143,
				string_0 = "D\u00adîc V\u00ad¬ng ®éng",
				string_2 = "D\u00adîc V\u00ad¬ng ®éng tÇng 3|D\u00aduîc V\u00adu¬ng §éng TÇng 3|TÇng 3 D\u00ad"
			},
			new MapNavigationEntry
			{
				int_0 = 144,
				string_0 = "D\u00adîc V\u00ad¬ng ®éng",
				string_3 = "TÇng 4 D\u00adîc",
				string_2 = "D\u00adîc V\u00ad¬ng ®éng tÇng 4|D\u00aduîc V\u00adu¬ng §éng TÇng 4|Çng\u0001 4"
			},
			new MapNavigationEntry
			{
				int_0 = 145,
				string_0 = "TuyÕt B\u00b8o ®éng",
				string_3 = "TuyÕt B\u00b8o ®éng",
				string_2 = "TuyÕt B\u00b8o ®éng tÇng 1|TuyÕt B\u00b8o"
			},
			new MapNavigationEntry
			{
				int_0 = 147,
				string_0 = "TuyÕt B\u00b8o ®éng tÇng 3",
				string_2 = "TuyÕt B\u00b8o ®éng tÇng 3|TuyÕt B\u00b8o §éng TÇng 3|3 TuyÕt B\u00b8o"
			},
			new MapNavigationEntry
			{
				int_0 = 148,
				string_0 = "TuyÕt B\u00b8o ®éng tÇng 4",
				string_2 = "TuyÕt b\u00b8o ®éng tÇng 4|TuyÕt B\u00b8o §éng TÇng 4|4 TuyÕt B\u00b8o"
			},
			new MapNavigationEntry
			{
				int_0 = 149,
				string_0 = "TuyÕt B\u00b8o ®éng tÇng 5",
				string_2 = "TuyÕt b\u00b8o ®éng tÇng 5|TuyÕt B\u00b8o §éng TÇng 5|5 TuyÕt B\u00b8o"
			},
			new MapNavigationEntry
			{
				int_0 = 150,
				string_0 = "TuyÕt B\u00b8o ®éng tÇng 6",
				string_2 = "TuyÕt b\u00b8o ®éng tÇng 6|TuyÕt B\u00b8o §éng TÇng 6|6 TuyÕt B\u00b8o"
			},
			new MapNavigationEntry
			{
				int_0 = 151,
				string_0 = "TuyÕt B\u00b8o ®éng tÇng 7",
				string_2 = "TuyÕt B\u00b8o ®éng tÇng 7|TuyÕt B\u00b8o §éng TÇng 7"
			},
			new MapNavigationEntry
			{
				int_0 = 152,
				string_0 = "TuyÕt B\u00b8o ®éng tÇng 8",
				string_2 = "TuyÕt B\u00b8o ®éng tÇng 8|TuyÕt B\u00b8o §éng TÇng 8"
			},
			new MapNavigationEntry
			{
				int_0 = 153,
				string_0 = "Th¹ch Cæ trÊn",
				string_3 = "Th¹ch Cæ",
				string_2 = "Th¹ch Cæ"
			},
			new MapNavigationEntry
			{
				int_0 = 154,
				string_0 = "Thóy Yªn m«n",
				string_2 = "Thóy Yªn"
			},
			new MapNavigationEntry
			{
				int_0 = 158,
				string_0 = "Thóy Yªn CÊm §Þa|Mª Cung CÊm §Þa",
				string_2 = "Thóy Yªn CÊm|Mª cung cÊm"
			},
			new MapNavigationEntry
			{
				int_0 = 160,
				string_0 = "L¹c D\u00ad¬ng|Nha Thµnh",
				string_1 = "®«ng|§«ng",
				string_2 = "L¹c D\u00ad¬ng|Nha Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 162,
				string_0 = "§¹i Lý",
				string_1 = "b¾c",
				string_3 = "§¹i Lý",
				string_2 = "§¹i Lý"
			},
			new MapNavigationEntry
			{
				int_0 = 163,
				string_0 = "\u00b8c b\u00b8 ®Þa ®¹o",
				string_2 = "\u00b8c b\u00b8|B\u00b8 §Þa|\u00b8c b\u00b8 ®ia ®¹o"
			},
			new MapNavigationEntry
			{
				int_0 = 164,
				string_0 = "Thiªn T©m Th\u00b8p tÇng 1|Thiªn TÇm Th\u00b8p tÇng 1",
				string_3 = "TÇm th\u00b8p tÇng 1",
				string_2 = "m Th\u00b8p tÇng 1|Thiªn TÇm Th\u00b8p|Thiªn T©m Th\u00b8p"
			},
			new MapNavigationEntry
			{
				int_0 = 165,
				string_0 = "Thiªn T©m Th\u00b8p tÇng 2|Thiªn TÇm Th\u00b8p tÇng 2",
				string_3 = "Thiªn TÇm th\u00b8p tÇng 2",
				string_2 = "m Th\u00b8p tÇng 2|Thiªn TÇm Th\u00b8p TÇng 2"
			},
			new MapNavigationEntry
			{
				int_0 = 166,
				string_0 = "Thiªn T©m Th\u00b8p tÇng 3|Thiªn TÇm Th\u00b8p tÇng 3|Thiªn T©m Th\u00b8p tÇng 4|Thiªn TÇm Th\u00b8p tÇng 4",
				string_2 = "m Th\u00b8p tÇng 3|Thiªn TÇm Th\u00b8p TÇng 4"
			},
			new MapNavigationEntry
			{
				int_0 = 167,
				string_0 = "§iÓm Th\u00ad¬ng s¬n",
				string_3 = "§iÓm Th\u00ad¬ng s¬n",
				string_2 = "m Th\u00ad¬ng s¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 168,
				string_0 = "Phông Nh·n ®éng",
				string_3 = "Phông Nh·n",
				string_2 = "Phông Nh·n"
			},
			new MapNavigationEntry
			{
				int_0 = 169,
				string_0 = "Long Nh·n ®éng",
				string_3 = "Long Nh·n",
				string_2 = "Long Nh·n"
			},
			new MapNavigationEntry
			{
				int_0 = 170,
				string_0 = "Thæ PhØ §éng",
				string_3 = "Thæ PhØ",
				string_2 = "Thæ phØ"
			},
			new MapNavigationEntry
			{
				int_0 = 171,
				string_0 = "§iÓm Th\u00ad¬ng §én",
				string_3 = "m Th\u00ad¬ng ®",
				string_2 = "m Th\u00ad¬ng ®|m Th\u00ad¬ng §"
			},
			new MapNavigationEntry
			{
				int_0 = 172,
				string_0 = "§iÓm Th\u00ad¬ng ®én",
				string_3 = "m Th\u00ad¬ng ®",
				string_2 = "Th\u00ad¬ng ®éng tÇng 2|Th\u00ad¬ng §éng TÇng 2|Th\u00ad¬ng §éng (TÇng 2)|Th\u00ad¬ng ®éng (TÇng 2)"
			},
			new MapNavigationEntry
			{
				int_0 = 173,
				string_0 = "§iÓm Th\u00ad¬ng ®én",
				string_2 = "Th\u00ad¬ng ®éng tÇng 3|Th\u00ad¬ng §éng TÇng 3|Th\u00ad¬ng §éng (TÇng 3)|Th\u00ad¬ng ®éng (TÇng 3)"
			},
			new MapNavigationEntry
			{
				int_0 = 174,
				string_0 = "Long TuyÒn th«n",
				string_3 = "Long TuyÒn",
				string_2 = "Long TuyÒn"
			},
			new MapNavigationEntry
			{
				int_0 = 175,
				string_0 = "T©y S¬n th«n",
				string_2 = "T©y S¬n|Vi S¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 176,
				string_0 = "L©m An",
				string_1 = "nam",
				string_3 = "L©m An",
				string_2 = "L©m An"
			},
			new MapNavigationEntry
			{
				int_0 = 179,
				string_0 = "La Tiªu s¬n",
				string_3 = "La Tiªu s¬n",
				string_2 = "La Tiªu s¬n|ChuyÓn Bao L"
			},
			new MapNavigationEntry
			{
				int_0 = 180,
				string_0 = "Long Cung ®éng",
				string_3 = "Long Cung",
				string_2 = "Long Cung"
			},
			new MapNavigationEntry
			{
				int_0 = 181,
				string_0 = "L\u00adìng Thñy ®éng",
				string_3 = "L\u00adìng Th|L\u00ad¬ng Th",
				string_2 = "L\u00adìng Th|L\u00ad¬ng Th|L\u00ad\u00b4ng Th|ng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 182,
				string_0 = "NghiÖt Long ®én",
				string_3 = "NghiÖt Long",
				string_2 = "Öt Long"
			},
			new MapNavigationEntry
			{
				int_0 = 183,
				string_0 = "Ngò §éc Gi\u00b8o",
				string_2 = "Ngò §éc"
			},
			new MapNavigationEntry
			{
				int_0 = 185,
				string_0 = "Hµ Thµnh|ViÖt Thµnh",
				string_1 = "nam",
				string_2 = "Hµ Thµnh|ViÖt Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 190,
				string_0 = "§µ Thµnh|Sµi Thµnh",
				string_1 = "®«ng|§«ng",
				string_2 = "§µ Thµnh|Sµi Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 193,
				string_0 = "Vò Di s¬n",
				string_3 = "Vò Di",
				string_2 = "Vò Di|Vu Di s¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 194,
				string_0 = "Ngäc Hoa ®éng",
				string_3 = "Ngäc Hoa",
				string_2 = "Ngäc Hoa"
			},
			new MapNavigationEntry
			{
				int_0 = 196,
				string_0 = "D\u00ad¬ng Gi\u00b8c ®éng",
				string_2 = "Du¬ng Gi\u00b8c|D\u00ad¬ng Gi\u00b8c"
			},
			new MapNavigationEntry
			{
				int_0 = 198,
				string_0 = "Thanh khª ®éng",
				string_3 = "Thanh Khª",
				string_2 = "Thanh Kh"
			},
			new MapNavigationEntry
			{
				int_0 = 199,
				string_0 = "Vò L\u00a8ng ®éng",
				string_3 = "Vò L\u00a8ng",
				string_2 = "Vò L\u00a8ng|Vu L\u00a8ng"
			},
			new MapNavigationEntry
			{
				int_0 = 200,
				string_0 = "Cæ D\u00ad¬ng §éng",
				string_3 = "Cæ D\u00ad¬ng",
				string_2 = "Cæ D\u00ad¬ng"
			},
			new MapNavigationEntry
			{
				int_0 = 201,
				string_0 = "B\u00a8ng Hµ ®éng",
				string_3 = "B\u00a8ng Hµ",
				string_2 = "B\u00a8ng Hµ"
			},
			new MapNavigationEntry
			{
				int_0 = 202,
				string_0 = "Phï Dung ®éng",
				string_3 = "Phï Dung",
				string_2 = "Phï Dung"
			},
			new MapNavigationEntry
			{
				int_0 = 203,
				string_0 = "V« Danh ®éng",
				string_3 = "V« Danh",
				string_2 = "V« Danh"
			},
			new MapNavigationEntry
			{
				int_0 = 204,
				string_0 = "Phi Thiªn ®éng",
				string_3 = "Phi Thiªn",
				string_2 = "Phi Thiªn"
			},
			new MapNavigationEntry
			{
				int_0 = 205,
				string_0 = "D\u00ad¬ng Trung ®én",
				string_3 = "¬ng Trung",
				string_2 = "¬ng Trung"
			},
			new MapNavigationEntry
			{
				int_0 = 206,
				string_0 = "TÇn L\u00a8ng tÇng 2",
				string_3 = "TÇn L\u00a8ng tÇng 2",
				string_2 = "TÇn L\u00a8ng tÇng 2|TÇn L\u00a8ng (TÇng 2)"
			},
			new MapNavigationEntry
			{
				int_0 = 207,
				string_0 = "TÇn L\u00a8ng tÇng 3",
				string_2 = "TÇn L\u00a8ng tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 224,
				string_0 = "Sa m¹c ®Þa biÓu",
				string_3 = "Sa M¹c Mª|Kho\u00b8i Ho¹t",
				string_2 = "a BiÓu|Kho\u00b8i Ho¹t"
			},
			new MapNavigationEntry
			{
				int_0 = 225,
				string_0 = "Sa M¹c 1|Sa M¹c Mª Cung 1",
				string_3 = "Sa M¹c Mª",
				string_2 = "Sa M¹c 1|M¹c Mª Cung 1|c s¬n  ®éng 1|c s¬n ®éng 1|Sa\u0001M¹c\u00011|\u0001M¹c\u0001Mª\u0001Cung\u00011|c\u0001s¬n\u0001\u0001®éng\u00011|c\u0001s¬n\u0001®éng\u00011"
			},
			new MapNavigationEntry
			{
				int_0 = 226,
				string_0 = "Sa M¹c 2|Sa M¹c Mª Cung 2",
				string_3 = "Sa M¹c Mª",
				string_2 = "Sa M¹c 2|M¹c Mª Cung 2|c s¬n  ®éng 2|c s¬n ®éng 2|Sa\u0001M¹c\u00012|\u0001M¹c\u0001Mª\u0001Cung\u00012|c\u0001s¬n\u0001\u0001®éng\u00012|c\u0001s¬n\u0001®éng\u00012"
			},
			new MapNavigationEntry
			{
				int_0 = 227,
				string_0 = "Sa M¹c 3|Sa M¹c Mª Cung 3",
				string_3 = "Sa M¹c Mª",
				string_2 = "Sa M¹c 3|M¹c Mª Cung 3|c s¬n  ®éng 3|c s¬n ®éng 3|Sa\u0001M¹c\u00013|\u0001M¹c\u0001Mª\u0001Cung\u00013|c\u0001s¬n\u0001\u0001®éng\u00013|c\u0001s¬n\u0001®éng\u00013"
			},
			new MapNavigationEntry
			{
				int_0 = 242,
				string_0 = "BÕn Tre Thµnh",
				string_1 = "b¾c",
				string_2 = "BÕn Tre"
			},
			new MapNavigationEntry
			{
				int_0 = 243,
				string_0 = "Cµ Mau Thµnh",
				string_1 = "b¾c",
				string_2 = "Cµ Mau"
			},
			new MapNavigationEntry
			{
				int_0 = 244,
				string_0 = "Long An Thµnh",
				string_1 = "b¾c",
				string_2 = "Long An"
			},
			new MapNavigationEntry
			{
				int_0 = 245,
				string_0 = "An GiangThµnh",
				string_1 = "b¾c",
				string_2 = "An Giang"
			},
			new MapNavigationEntry
			{
				int_0 = 246,
				string_0 = "HËu GiangThµnh",
				string_1 = "b¾c",
				string_2 = "HËu Giang"
			},
			new MapNavigationEntry
			{
				int_0 = 247,
				string_0 = "B¹c Liªu Thµnh",
				string_1 = "b¾c",
				string_2 = "B¹c Liªu"
			},
			new MapNavigationEntry
			{
				int_0 = 319,
				string_0 = "L©m Du Quan",
				string_3 = "L©m Du",
				string_2 = "L©m Du"
			},
			new MapNavigationEntry
			{
				int_0 = 320,
				string_0 = "Ch©n nói Tr\u00adêng",
				string_3 = "Tr\u00adêng B¹ch s¬n",
				string_2 = "Ch©n nói"
			},
			new MapNavigationEntry
			{
				int_0 = 321,
				string_0 = "Tr\u00adêng B¹ch s¬n",
				string_3 = "¬n Nam",
				string_2 = "¬n Nam|B¹ch Nam|¬n\u0001Nam|B¹ch\u0001Nam"
			},
			new MapNavigationEntry
			{
				int_0 = 322,
				string_0 = "Tr\u00adêng B¹ch s¬n",
				string_3 = "¬n B¾c",
				string_2 = "¬n B¾c|B¹ch B¾c|¬n\u0001B¾c|B¹ch\u0001B¾c"
			},
			new MapNavigationEntry
			{
				int_0 = 323,
				string_0 = "§iÓm b\u00b8o danh",
				string_2 = " danh|he Tèng"
			},
			new MapNavigationEntry
			{
				int_0 = 324,
				string_0 = "§iÓm b\u00b8o danh",
				string_2 = " danh|he Tèng"
			},
			new MapNavigationEntry
			{
				int_0 = 325,
				string_0 = "§iÓm b\u00b8o danh",
				string_2 = " danh|he Tèng"
			},
			new MapNavigationEntry
			{
				int_0 = 333,
				string_0 = "Hoa S¬n ph\u00b8i",
				string_2 = "POS|43328,100032,ChÝnh Kh|43584,93568,Ngäc N|50080,91424,T\u00ad NiÖm|48576,101088,TriÒu D\u00ad|41216,102784,Cæng Nam|49408,102464,Cæng §«ng|42240,92160,Cæng T©y|40611,103722,KÕt 1|49472,102368,KÕt 2|41952,92416,KÕt 3|46176,93632,Ph\u00b8i 1|49888,97120,Ph\u00b8i 2|49280,93536,Ph\u00b8i 3|47392,99200,Ph\u00b8i 4|40576,103904,TrÝ 1|41920,92576,TrÝ 2|48960,102656,TrÝ 3\u0001\u0001Hoa S¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 336,
				string_0 = "Phong L\u00a8ng ®é",
				string_3 = "Phong L\u00a8ng",
				string_2 = "Phong L\u00a8ng"
			},
			new MapNavigationEntry
			{
				int_0 = 340,
				string_0 = "M¹c Cao QuËt",
				string_3 = "M¹c Cao QuËt",
				string_2 = "M¹c Cao QuËt|M¹c\u0001Cao\u0001QuËt"
			},
			new MapNavigationEntry
			{
				int_0 = 341,
				string_0 = "M¹c B¾c Th¶o Ng",
				string_2 = "M¹c B¾c T"
			},
			new MapNavigationEntry
			{
				int_0 = 342,
				string_0 = "Vi s¬n ®¶o",
				string_2 = "Vi S¬n|T©y S¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 355,
				string_0 = "§Êu Tr\u00adêng Sinh",
				string_2 = "POS|50304,78016,KÕt 1|38592,100992,KÕt 2|49440,99520,KÕt 3|38976,78464,KÕt 4|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464,T©y\u0001\u0001Sinh T"
			},
			new MapNavigationEntry
			{
				int_0 = 416,
				string_0 = "L¹c D\u00ad¬ng",
				string_2 = "L¹c D\u00ad¬ng"
			},
			new MapNavigationEntry
			{
				int_0 = 419,
				string_0 = "Hang S¬n §oßng",
				string_2 = "Hang S¬n §oßng"
			},
			new MapNavigationEntry
			{
				int_0 = 420,
				string_0 = "Tiªu Kh«ng §éng",
				string_3 = "Tiªu Kh«ng §éng",
				string_2 = "Tiªu Kh«ng"
			},
			new MapNavigationEntry
			{
				int_0 = 421,
				string_0 = "M¹c TÝch §éng 1",
				string_3 = "M¹c TÝch §éng 1",
				string_2 = "M¹c TÝch §éng 1"
			},
			new MapNavigationEntry
			{
				int_0 = 422,
				string_0 = "M¹c TÝch §éng 2",
				string_3 = "M¹c TÝch §éng 2",
				string_2 = "M¹c TÝch §éng 2"
			},
			new MapNavigationEntry
			{
				int_0 = 423,
				string_0 = "M¹c TÝch §éng 3",
				string_3 = "M¹c TÝch §éng 3",
				string_2 = "M¹c TÝch §éng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 424,
				string_0 = "L¹c V©n §éng",
				string_3 = "L¹c V©n §éng",
				string_2 = "L¹c V©n §éng"
			},
			new MapNavigationEntry
			{
				int_0 = 428,
				string_0 = "T« Ch©u",
				string_2 = "T« Ch©u"
			},
			new MapNavigationEntry
			{
				int_0 = 429,
				string_0 = "Tiªu Kh«ng §éng",
				string_3 = "Tiªu Kh«ng §éng 2",
				string_2 = "Tiªu Kh«ng §éng 2|Tiªu Kh«ng 2"
			},
			new MapNavigationEntry
			{
				int_0 = 430,
				string_0 = "M¹c TÝch §éng 4",
				string_3 = "M¹c TÝch §éng 4",
				string_2 = "M¹c TÝch §éng 4"
			},
			new MapNavigationEntry
			{
				int_0 = 431,
				string_0 = "M¹c TÝch §éng 5",
				string_3 = "M¹c TÝch §éng 5",
				string_2 = "M¹c TÝch §éng 5"
			},
			new MapNavigationEntry
			{
				int_0 = 432,
				string_0 = "M¹c TÝch §éng 6",
				string_3 = "M¹c TÝch §éng 6",
				string_2 = "M¹c TÝch §éng 6"
			},
			new MapNavigationEntry
			{
				int_0 = 433,
				string_0 = "L¹c V©n §éng 2",
				string_3 = "L¹c V©n §éng 2",
				string_2 = "L¹c V©n §éng 2"
			},
			new MapNavigationEntry
			{
				int_0 = 434,
				string_0 = "Liªn Hoa th\u00b8p t",
				string_3 = "Liªn Hoa th\u00b8p tÇng 1",
				string_2 = "Liªn Hoa th\u00b8p tÇng 1"
			},
			new MapNavigationEntry
			{
				int_0 = 435,
				string_0 = "Liªn Hoa th\u00b8p t",
				string_3 = "Liªn Hoa th\u00b8p tÇng 5",
				string_2 = "Liªn Hoa th\u00b8p tÇng 2"
			},
			new MapNavigationEntry
			{
				int_0 = 436,
				string_0 = "Liªn Hoa th\u00b8p t",
				string_3 = "Liªn Hoa th\u00b8p tÇng 6",
				string_2 = "Liªn Hoa th\u00b8p tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 443,
				string_0 = "TuyÕt S¬n B¾c",
				string_2 = "TuyÕt S¬n B¾c"
			},
			new MapNavigationEntry
			{
				int_0 = 444,
				string_0 = "TuyÕt S¬n Nam",
				string_2 = "TuyÕt S¬n Nam"
			},
			new MapNavigationEntry
			{
				int_0 = 445,
				string_0 = "§Þa Long S¬n",
				string_2 = "§Þa Long S¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 446,
				string_0 = "§Þa MÉu S¬n",
				string_2 = "§Þa MÉu S¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 447,
				string_0 = "§Þa Hoµng S¬n",
				string_2 = "§Þa Hoµng S¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 456,
				string_0 = "M¹c C« Thµnh",
				string_2 = "M¹c C« Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 457,
				string_0 = "Mai Hoa LÜnh",
				string_2 = "Mai Hoa LÜnh"
			},
			new MapNavigationEntry
			{
				int_0 = 458,
				string_0 = "S\u00b8t Vùc",
				string_2 = "S\u00b8t Vùc"
			},
			new MapNavigationEntry
			{
				int_0 = 459,
				string_0 = "Kinh Ch©u Thµnh",
				string_2 = "Kinh Ch©u Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 460,
				string_0 = "Ung Ch©u Thµnh",
				string_2 = "Ung Ch©u Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 520,
				string_0 = "Minh NguyÖt trÊ",
				string_2 = "nguyÖt trÊn Ph\u00adîng T"
			},
			new MapNavigationEntry
			{
				int_0 = 521,
				string_0 = "Minh NguyÖt trÊ",
				string_2 = "nguyÖt trÊn Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 522,
				string_0 = "Minh NguyÖt trÊ",
				string_2 = "nguyÖt trÊn BiÖn K"
			},
			new MapNavigationEntry
			{
				int_0 = 523,
				string_0 = "Minh NguyÖt trÊ",
				string_2 = "nguyÖt trÊn T\u00ad¬ng D"
			},
			new MapNavigationEntry
			{
				int_0 = 524,
				string_0 = "Minh NguyÖt trÊ",
				string_2 = "nguyÖt trÊn D\u00ad¬ng C"
			},
			new MapNavigationEntry
			{
				int_0 = 525,
				string_0 = "Minh NguyÖt trÊ",
				string_2 = "nguyÖt trÊn §¹i L"
			},
			new MapNavigationEntry
			{
				int_0 = 526,
				string_0 = "Minh NguyÖt trÊ",
				string_2 = "nguyÖt trÊn L©m A"
			},
			new MapNavigationEntry
			{
				int_0 = 539,
				string_0 = "Tr\u00adêng Ca M«n c",
				string_3 = "Ca M«n"
			},
			new MapNavigationEntry
			{
				int_0 = 714,
				string_0 = "Cæ ®éng S¬n B¶o",
				string_5 = string_2,
				string_2 = "S¬n B¶o"
			},
			new MapNavigationEntry
			{
				int_0 = 715,
				string_0 = "Cæ Nam Tr\u00adêng B",
				string_5 = string_2,
				string_2 = "Nam Tr\u00adêng B"
			},
			new MapNavigationEntry
			{
				int_0 = 716,
				string_0 = "Cæ B¾c Tr\u00adêng B",
				string_5 = string_2,
				string_2 = "B¾c Tr\u00adêng B"
			},
			new MapNavigationEntry
			{
				int_0 = 717,
				string_0 = "Cæ M¹c Cao QuËt",
				string_5 = string_2,
				string_2 = "M¹c Cao QuËt"
			},
			new MapNavigationEntry
			{
				int_0 = 718,
				string_0 = "Sa M¹c Cæ 1",
				string_5 = string_2,
				string_2 = "Sa M¹c Cæ 1"
			},
			new MapNavigationEntry
			{
				int_0 = 719,
				string_0 = "Sa M¹c Cæ 2",
				string_5 = string_2,
				string_2 = "Sa M¹c Cæ 2"
			},
			new MapNavigationEntry
			{
				int_0 = 720,
				string_0 = "Sa M¹c Cæ 3",
				string_5 = string_2,
				string_2 = "Sa M¹c Cæ 3"
			},
			new MapNavigationEntry
			{
				int_0 = 721,
				string_5 = string_2,
				string_2 = "Cæ ®éng D\u00adîc V\u00ad"
			},
			new MapNavigationEntry
			{
				int_0 = 722,
				string_5 = string_2,
				string_2 = "Xi V\u00adu Cæ"
			},
			new MapNavigationEntry
			{
				int_0 = 723,
				string_0 = "Cæ L\u00a8ng ®é",
				string_5 = string_2,
				string_2 = "Cæ L\u00a8ng ®é"
			},
			new MapNavigationEntry
			{
				int_0 = 724,
				string_5 = string_2,
				string_2 = "Cæ ®éng TiÕn Có"
			},
			new MapNavigationEntry
			{
				int_0 = 725,
				string_5 = string_2,
				string_2 = "Cæ ®éng D\u00ad¬ng T"
			},
			new MapNavigationEntry
			{
				int_0 = 726,
				string_5 = string_2,
				string_2 = "Cæ ®éng Phi Thi"
			},
			new MapNavigationEntry
			{
				int_0 = 727,
				string_5 = string_2,
				string_2 = "Cæ ®éng Vò L\u00a8ng"
			},
			new MapNavigationEntry
			{
				int_0 = 728,
				string_5 = string_2,
				string_2 = "Cæ ®éng B\u00a8ng Hµ"
			},
			new MapNavigationEntry
			{
				int_0 = 729,
				string_5 = string_2,
				string_2 = "Cæ ®éng Nh¹n Th"
			},
			new MapNavigationEntry
			{
				int_0 = 730,
				string_5 = string_2,
				string_2 = "Cæ ®éng Thanh k"
			},
			new MapNavigationEntry
			{
				int_0 = 731,
				string_5 = string_2,
				string_2 = "Cæ §¹i Sa M¹"
			},
			new MapNavigationEntry
			{
				int_0 = 732,
				string_5 = string_2,
				string_2 = "Phï Dung"
			},
			new MapNavigationEntry
			{
				int_0 = 733,
				string_5 = string_2,
				string_2 = "L\u00adìng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 734,
				string_5 = string_2,
				string_2 = "Ch©n nói Hoang"
			},
			new MapNavigationEntry
			{
				int_0 = 735,
				string_2 = "Tµng TÝch Nga M"
			},
			new MapNavigationEntry
			{
				int_0 = 736,
				string_2 = "Tµng TÝch ThiÕu"
			},
			new MapNavigationEntry
			{
				int_0 = 737,
				string_2 = "Tµng TÝch Thiªn V\u00ad¬ng"
			},
			new MapNavigationEntry
			{
				int_0 = 738,
				string_2 = "Tµng TÝch Ngò §"
			},
			new MapNavigationEntry
			{
				int_0 = 739,
				string_2 = "Tµng TÝch §\u00adêng M«n"
			},
			new MapNavigationEntry
			{
				int_0 = 740,
				string_2 = "Tµng TÝch Thóy"
			},
			new MapNavigationEntry
			{
				int_0 = 741,
				string_2 = "Tµng TÝch C\u00b8i B"
			},
			new MapNavigationEntry
			{
				int_0 = 742,
				string_2 = "Tµng TÝch Thiªn"
			},
			new MapNavigationEntry
			{
				int_0 = 747,
				string_0 = "Tµng TÝch C«n L",
				string_2 = "C«n L«n"
			},
			new MapNavigationEntry
			{
				int_0 = 748,
				string_2 = "Tµng TÝch Vâ §a"
			},
			new MapNavigationEntry
			{
				int_0 = 749,
				string_0 = "Thµnh Cæ Ph\u00adîng",
				string_1 = "b¾c",
				string_5 = string_2,
				string_3 = "Ph\u00adîng T\u00adêng",
				string_2 = "Ph\u00adîng T\u00adêng"
			},
			new MapNavigationEntry
			{
				int_0 = 750,
				string_0 = "Thµnh Cæ Thµnh ",
				string_1 = "®«ng|§«ng",
				string_5 = string_2,
				string_3 = "Thµnh §«",
				string_2 = "Thµnh §«"
			},
			new MapNavigationEntry
			{
				int_0 = 751,
				string_0 = "Thµnh Cæ BiÖn K",
				string_1 = "®«ng|§«ng",
				string_5 = string_2,
				string_3 = "BiÖn Kinh",
				string_2 = "BiÖn Kinh"
			},
			new MapNavigationEntry
			{
				int_0 = 752,
				string_0 = "Thµnh Cæ §¹i Lý",
				string_1 = "b¾c",
				string_5 = string_2,
				string_3 = "§¹i Lý",
				string_2 = "§¹i Lý"
			},
			new MapNavigationEntry
			{
				int_0 = 753,
				string_0 = "Thµnh Cæ T\u00ad¬ng ",
				string_1 = "b¾c",
				string_5 = string_2,
				string_3 = "T\u00ad¬ng D\u00ad¬ng",
				string_2 = "T\u00ad¬ng D\u00ad¬ng"
			},
			new MapNavigationEntry
			{
				int_0 = 754,
				string_0 = "Thµnh Cæ D\u00ad¬ng",
				string_1 = "t©m",
				string_5 = string_2,
				string_3 = "D\u00ad¬ng Ch©u",
				string_2 = "D\u00ad¬ng Ch©u"
			},
			new MapNavigationEntry
			{
				int_0 = 755,
				string_0 = "Thµnh Cæ L©m An",
				string_1 = "nam",
				string_5 = string_2,
				string_3 = "L©m An",
				string_2 = "L©m An"
			},
			new MapNavigationEntry
			{
				int_0 = 772,
				string_3 = "(PH) Thiªn T©m Th\u00b8p tÇng 3",
				string_2 = "(PH) Thiªn T©m Th\u00b8p tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 777,
				string_3 = "L©m Du Ngo¹n",
				string_2 = "L©m Du Ngo¹n"
			},
			new MapNavigationEntry
			{
				int_0 = 778,
				string_3 = "L©m Du D\u00ad¬ng",
				string_2 = "L©m Du D\u00ad¬ng"
			},
			new MapNavigationEntry
			{
				int_0 = 875,
				string_0 = "H¾c Sa ®éng",
				string_3 = "H¾c Sa",
				string_2 = "H¾c Sa|H¾c\u0001Sa"
			},
			new MapNavigationEntry
			{
				int_0 = 897,
				string_0 = "Casio Las Vegas",
				string_2 = "Casio"
			},
			new MapNavigationEntry
			{
				int_0 = 917,
				string_0 = "TÝch HuyÕt Cèc",
				string_2 = "TÝch HuyÕt Cèc|Ph\u00b8ch HuyÕt|Méc Nhai N|Méc Nhai (N|TÝch\u0001HuyÕt\u0001Cèc|Ph\u00b8ch\u0001HuyÕt"
			},
			new MapNavigationEntry
			{
				int_0 = 918,
				string_0 = "\u00b8c Nh©n Cèc",
				string_2 = "\u00b8c Nh©n Cèc|Méc Nhai §|Méc Nhai (§|\u00b8c\u0001Nh©n\u0001Cèc"
			},
			new MapNavigationEntry
			{
				int_0 = 919,
				string_0 = "Thùc Cèt Nhai",
				string_2 = "Thùc Cèt Nhai|Thùc\u0001Cèt\u0001Nhai"
			},
			new MapNavigationEntry
			{
				int_0 = 920,
				string_0 = "H¾c Méc Nhai",
				string_2 = "H¾c Méc Nhai|H¾c\u0001Méc\u0001Nhai"
			},
			new MapNavigationEntry
			{
				int_0 = 921,
				string_0 = "Thiªn Phô S¬n",
				string_2 = "Thiªn Phô S¬n|TuyÕt S¬n N|Thiªn\u0001Phô\u0001S¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 922,
				string_0 = "Bµn Long S¬n",
				string_2 = "Bµn Long S¬n|TuyÕt S¬n B|Bµn\u0001Long\u0001S¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 923,
				string_0 = "§Þa MÉu S¬n",
				string_2 = "MÉu S¬n|Þa\u0001MÉu\u0001S¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 924,
				string_0 = "UyÓn Ph\u00adîng S¬n",
				string_2 = "UyÓn Ph\u00adîng S¬n|Méc Nhai B|Méc Nhai (B|UyÓn Phông S¬n|UyÓn\u0001Ph\u00adîng\u0001S¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 933,
				string_0 = "B¶n ®å Sinh Tö",
				string_2 = "Sinh T"
			},
			new MapNavigationEntry
			{
				int_0 = 934,
				string_0 = "Ngän nói Tr\u00adêng",
				string_2 = "Thiªn Tr×|hiªn Tr× MËt C"
			},
			new MapNavigationEntry
			{
				int_0 = 949,
				string_0 = "Mª Cung KiÕm Gia",
				string_2 = "POS|92224,116736,i VËn T|62368,111968,Tr¶ Ti|78912,124288,C\u00adíp Ti|78912,124288,KiÕm\u0001\u0001KiÕm Gia"
			},
			new MapNavigationEntry
			{
				int_0 = 950,
				string_0 = "\u00b8c Lang Cèc",
				string_2 = "\u00b8c Lang Cèc|\u00b8c\u0001Lang\u0001Cèc"
			},
			new MapNavigationEntry
			{
				int_0 = 959,
				string_0 = "ChiÕn Long §éng",
				string_3 = "ChiÕn Long",
				string_2 = "ChiÕn Long"
			},
			new MapNavigationEntry
			{
				int_0 = 967,
				string_0 = "V« Danh MËt C¶n",
				string_2 = "V« Danh BÝ C¶nh"
			},
			new MapNavigationEntry
			{
				int_0 = 968,
				string_2 = "NguyÖt Ca"
			},
			new MapNavigationEntry
			{
				int_0 = 977,
				string_0 = "B¶n §å Hßa B×nh",
				string_3 = "n b¶n ®å ho¹t",
				string_2 = "POS|59520,97248,HuyÒn V|61347,114306,Thanh L|49791,114310,Chu T\u00ad|49600,102496,B¹ch H|59520,97248,Cao CÊp\u0001\u0001Hßa B×nh|h\u00b8i qu¶"
			},
			new MapNavigationEntry
			{
				int_0 = 978,
				string_0 = "B¶n §å Hßa B×nh",
				string_2 = "Qu¶"
			},
			new MapNavigationEntry
			{
				int_0 = 981,
				string_0 = "H\u00adëng Thñy ®éng",
				string_2 = "H\u00adëng Thñy §éng NEW|H\u00adëng Thñy §éng 2"
			},
			new MapNavigationEntry
			{
				int_0 = 982,
				string_0 = "§iÓm Th\u00ad¬ng ®én",
				string_2 = "Òm th\u00ad¬ng ®éng tÇng NEW"
			},
			new MapNavigationEntry
			{
				int_0 = 983,
				string_0 = "T\u00adêng V©n ®éng ",
				string_2 = "T\u00adêng V©n ®éng NEW|T\u00adêng V©n ®éng tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 984,
				string_0 = "TÇn Thñy Hoµng",
				string_2 = "POS|43360,113376,Thanh L|40960,113408,Chu T\u00adíc|43392,110944,HuyÒn V|40992,110944,Kú L©n"
			},
			new MapNavigationEntry
			{
				int_0 = 986,
				string_0 = "HuÕ Thµnh",
				string_1 = "b¾c",
				string_2 = "HuÕ Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 988,
				string_0 = "H¶i Thµnh",
				string_1 = "b¾c",
				string_2 = "H¶i Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 989,
				string_0 = "Uyªn ¦¬ng Cèc",
				string_2 = "POS|49087,99974,V« T×nh|38689,100630,ThiÕt Thñ|39200,78208,L·nh HuyÕt|50171,77970,Truy MÖnh|52480,107296,TrÝ 1|57536,106272,TrÝ 2|58816,114112,TrÝ 3|52800,113376,TrÝ 4|50400,77984,ng 1 giê|49120,99904,ng 5 giê|38624,100960,ng 7 giê|39200,78208,ng 11 giê\u0001\u0001Kinh Thµnh|Ph\u00adîng Hoµng|Uyªn ¦¬ng"
			},
			new MapNavigationEntry
			{
				int_0 = 990,
				string_0 = "L©m Du §·ng|L©m Du Quan",
				string_2 = "POS|54243,101038,Cæng 1|45664,95840,Cæng 2|49664,95616,Cæng 3\u0001\u0001L©m Du §|L©m Du §|L©m Du §·ng"
			},
			new MapNavigationEntry
			{
				int_0 = 991,
				string_0 = "L©m Du Ngo¹n|ChiÕn Long §éng",
				string_3 = "ChiÕn Long",
				string_2 = "L©m Du Ngo¹n|ChiÕn Long"
			},
			new MapNavigationEntry
			{
				int_0 = 992,
				string_0 = "L©m Du D\u00ad¬ng",
				string_3 = "L©m Du D\u00ad¬ng",
				string_2 = "L©m Du D\u00ad¬ng"
			},
			new MapNavigationEntry
			{
				int_0 = 993,
				string_0 = "Gia Long Thµnh|Kh¶i Thµnh",
				string_1 = "b¾c",
				string_2 = "Gia Long|Kh¶i Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 994,
				string_2 = "POS|51328,109280,hu Vùc 1|52045,102016,hu Vùc 2|58208,101696,hu Vùc 3|58336,109056,hu Vùc 4\u0001\u0001Tranh |Tranh "
			},
			new MapNavigationEntry
			{
				int_0 = 995,
				string_2 = "POS|59968,99040,B¾c|51456,111880,Nam|60064,110496,§«ng|49536,102400,T©y\u0001\u0001s¬n §«ng|TuyÕt B\u00b8o|H¾c Méc Nhai|L©m Du M|S¬n ®éng 1|L©m Du Quan 2|L·o Hæ ®éng 2"
			},
			new MapNavigationEntry
			{
				int_0 = 996,
				string_2 = "s¬n T©y|TuyÖt T×nh Cèc|S¬n ®éng 2|L·o Hæ ®éng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 997,
				string_2 = "TuyÕt S¬n B|TuyÕt S¬n §|¬n T©y|¶i Chi L|S¬n ®éng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 998,
				string_0 = "Hoa S¬n ChiÕn",
				string_2 = "POS|41216,102784,Cæng Nam|49408,102464,Cæng §«ng|42240,92160,Cæng T©y|39616,82720,tr\u00b8i|49024,96576,ph¶i|42560,92384,kÕt 1|41376,101952,kÕt 2|49344,102336,kÕt 3|41216,102784,kÕt 1|49408,102464,kÕt 2|42240,92160,kÕt 3\u0001\u0001Vu S¬n N|TuyÕt S¬n T|L©m Du Quan T©y|S¬n ®éng 4|Du Quan VIP|¬n §«ng|Hoa S¬n Ch"
			},
			new MapNavigationEntry
			{
				int_0 = 999,
				string_2 = "Chî §en|Tr\u00adêng Sinh T|Vu S¬n B|L©m Du Quan §«ng|S¬n ®éng 5"
			},
			new MapNavigationEntry
			{
				int_0 = 1000,
				string_2 = "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464,T©y|58112,109056,Cæng 1|51712,109056,Cæng 2|58368,102400,Cæng 3\u0001\u0001L©m Du Quan 2|Cæ B¹ch S¬n N|Vu S¬n N|BÕn thuy| TrËn|S¬n ®éng 6|Þa Giíi|M¹n §µ"
			},
			new MapNavigationEntry
			{
				int_0 = 1001,
				string_2 = "L©m Du Quan 2|Cæ B¹ch S¬n B|Th\u00b8ch thøc|C\u00b8c T©y Nam 1|S¬n ®éng 7|rung Giíi|U Minh"
			},
			new MapNavigationEntry
			{
				int_0 = 1002,
				string_2 = "L©m Du Quan 3|Cæ M¹c Cao Q|Tr\u00adêng Ca|Tr\u00adêng B¹ch S¬n T©y|C\u00b8c T©y Nam 2|S¬n ®éng 8|hiªn Giíi"
			},
			new MapNavigationEntry
			{
				int_0 = 1003,
				string_2 = "L\u00adu Tiªn ®éng TÇng 7 - |Cæ Sa M¹c Mª Cung 1|Tr\u00adêng B¹ch S¬n §«ng|C\u00b8c T©y Nam 3|L©m Du Quan 2|S¬n ®éng 9|Tiªn ®éng tÇng 7"
			},
			new MapNavigationEntry
			{
				int_0 = 1004,
				string_2 = "POS|58368,109056,§«ng|51840,101920,T©y|51616,109152,Nam|58176,101760,B¾c\u0001\u0001C\u00b8c T©y Nam 4|L©m Du Quan 3|Cæ Sa M¹c Mª Cung 2|M¹c-Cao-QuËt 2"
			},
			new MapNavigationEntry
			{
				int_0 = 1005,
				string_2 = "Cæ Sa M¹c Mª Cung 3|Bó §\u00b8 Eve|C\u00b8c T©y Nam 5|V\u00adên §µo 1|Du Quan 4"
			},
			new MapNavigationEntry
			{
				int_0 = 1006,
				string_2 = "Cæ D\u00adîc V\u00ad¬ng ®éng tÇng 4|Cöu Ch©u|Thµnh Cç|C\u00b8c T©y Nam 6|V\u00adên §µo 2|Du Quan 5|iÓm Th\u00ad¬ng ®éng 4"
			},
			new MapNavigationEntry
			{
				int_0 = 1007,
				string_5 = string_2,
				string_2 = "Cæ Kháa Lang|µo Hoa|C\u00b8c T©y Nam 7|iÓm Th\u00ad¬ng ®éng 5|Du Quan 1"
			},
			new MapNavigationEntry
			{
				int_0 = 1008,
				string_5 = string_2,
				string_2 = "Cæ Phong L\u00a8ng|C\u00b8c T©y Nam 8|Ch©n nói|Du Quan 2"
			},
			new MapNavigationEntry
			{
				int_0 = 1009,
				string_2 = "Þa MÉu S\u00b8t|C©u C\u00b8|Cæ TiÕn Cóc|Thæ PhØ §éng 1|B¹ch S¬n Nam"
			},
			new MapNavigationEntry
			{
				int_0 = 1010,
				string_2 = "UyÓn Phông S\u00b8t|Thæ PhØ §éng 2|Sa M¹c 1|TuyÕt S¬n §«ng - L\u00adu Ph\u00adîng"
			},
			new MapNavigationEntry
			{
				int_0 = 1011,
				string_2 = "POS|41216,102784,kÕt 1|49408,102464,kÕt 2|42240,92160,kÕt 3\u0001\u0001Thæ PhØ §éng 3|Thanh Long|Thæ PhØ §éng 3|Sa m¹c 2|TuyÕt S¬n T©y - L\u00adu Ph\u00adîng"
			},
			new MapNavigationEntry
			{
				int_0 = 1012,
				string_2 = "Hßa B×nh Cèc|Thæ PhØ §éng 4|Sa m¹c 3|TuyÕt S¬n Nam"
			},
			new MapNavigationEntry
			{
				int_0 = 1013,
				string_2 = "Thæ PhØ §éng 5|Sa m¹c ®Þa|L·o Hæ ®éng 1|TuyÕt S¬n B¾c - L\u00adu Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 1014,
				string_2 = "Thæ PhØ §éng 6|B¹ch S¬n B¾c|L·o Hæ ®éng 2|(VD) Thiªn TÇm th\u00b8p tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1015,
				string_2 = "Thæ PhØ §éng 7|B¹ch S¬n Nam 2|L·o Hæ ®éng 3|(VD) S¬n §éng L\u00adìng Thñy 1"
			},
			new MapNavigationEntry
			{
				int_0 = 1016,
				string_2 = "Thæ PhØ §éng 8|B¹ch S¬n B¾c 2|L·o Hæ ®éng 4"
			},
			new MapNavigationEntry
			{
				int_0 = 1017,
				string_2 = "§iÓm Th\u00ad¬ng S¬n 1|L·o Hæ ®éng 5"
			},
			new MapNavigationEntry
			{
				int_0 = 1018,
				string_2 = "§iÓm Th\u00ad¬ng S¬n 2|BÝ C¶nh|L©m Du Quan |(HT) Thiªn T©m Th\u00b8p 1"
			},
			new MapNavigationEntry
			{
				int_0 = 1019,
				string_2 = "§iÓm Th\u00ad¬ng S¬n 3|L©m Du Quan 1|(HT) Thiªn T©m Th\u00b8p tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1020,
				string_2 = "§iÓm Th\u00ad¬ng S¬n 4|Cao M¹c 1|(ST) Thiªn TÇm th\u00b8p tÇng 3|TÝch HuyÕt Cèc"
			},
			new MapNavigationEntry
			{
				int_0 = 1021,
				string_2 = "§iÓm Th\u00ad¬ng S¬n 5|Cao M¹c 2|(HT) L\u00adìng Thñy|(ST) S¬n §éng L\u00adìng Thñy 1|\u00b8c Nh©n Cèc"
			},
			new MapNavigationEntry
			{
				int_0 = 1022,
				string_2 = "§iÓm Th\u00ad¬ng S¬n 6|[HT] TuyÕt S¬n B¾c|Skill|Bµn Long S¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 1023,
				string_2 = "§iÓm Th\u00ad¬ng S¬n 7"
			},
			new MapNavigationEntry
			{
				int_0 = 1024,
				string_2 = "§iÓm Th\u00ad¬ng S¬n 8|[HT] TuyÕt S¬n §|Ch©n nói Tam HiÖp 1"
			},
			new MapNavigationEntry
			{
				int_0 = 1025,
				string_2 = "T©m Th\u00b8p 1|[HT] TuyÕt S¬n T©y|Ch©n nói Tam HiÖp 2"
			},
			new MapNavigationEntry
			{
				int_0 = 1026,
				string_3 = "T©m Th\u00b8p 2|] Vu S¬n B¾c",
				string_2 = "T©m Th\u00b8p 2|] Vu S¬n B¾c|Ch©n nói Tam HiÖp 3|QuËt 1"
			},
			new MapNavigationEntry
			{
				int_0 = 1027,
				string_3 = "T©m Th\u00b8p 3|] Vu S¬n Nam",
				string_2 = "T©m Th\u00b8p 3|] Vu S¬n Nam|Ch©n nói Tam HiÖp 4"
			},
			new MapNavigationEntry
			{
				int_0 = 1028,
				string_3 = "T©m Th\u00b8p 4|] Vu S¬n §",
				string_2 = "T©m Th\u00b8p 4|] Vu S¬n §"
			},
			new MapNavigationEntry
			{
				int_0 = 1029,
				string_3 = "T©m Th\u00b8p 5|] Vu S¬n T©y",
				string_2 = "T©m Th\u00b8p 5|] Vu S¬n T©y|Tr\u00adêng S¬n §«ng"
			},
			new MapNavigationEntry
			{
				int_0 = 1030,
				string_0 = "Thiªn T©m Th\u00b8p ",
				string_3 = "T©m Th\u00b8p 6",
				string_2 = "T©m Th\u00b8p 6"
			},
			new MapNavigationEntry
			{
				int_0 = 1031,
				string_0 = "Sa M¹c 4|Thiªn T©m Th\u00b8p ",
				string_3 = "Sa M¹c 4|T©m Th\u00b8p 7",
				string_2 = "Sa M¹c 4|T©m Th\u00b8p 7"
			},
			new MapNavigationEntry
			{
				int_0 = 1032,
				string_0 = "Sa M¹c 5|Thiªn T©m Th\u00b8p ",
				string_3 = "Sa M¹c 5|T©m Th\u00b8p 8",
				string_2 = "Sa M¹c 5|T©m Th\u00b8p 8"
			},
			new MapNavigationEntry
			{
				int_0 = 1033,
				string_0 = "Sa M¹c 6",
				string_2 = "Sa M¹c 6|TÇm Th\u00b8p 1"
			},
			new MapNavigationEntry
			{
				int_0 = 1034,
				string_0 = "TÇng 3 Thiªn TÇ",
				string_3 = "TÇng 3 Thiªn TÇm Th\u00b8p 2",
				string_2 = "TÇm Th\u00b8p 2"
			},
			new MapNavigationEntry
			{
				int_0 = 1035,
				string_0 = "B¶o Tiªu Thµnh",
				string_2 = "POS|65504,124832,phÝa §«ng|52384,107104,phÝa T©y|53440,124064,phÝa Nam|64640,104288,phÝa B¾c\u0001\u0001TÇm Th\u00b8p 3|TÇng 3 Thiªn"
			},
			new MapNavigationEntry
			{
				int_0 = 1036,
				string_0 = "TÇng 3 Thiªn TÇ",
				string_3 = "TÇng 3 Thiªn TÇm Th\u00b8p 4",
				string_2 = "TÇm Th\u00b8p 4"
			},
			new MapNavigationEntry
			{
				int_0 = 1037,
				string_0 = "TÇng 3 Thiªn TÇ",
				string_3 = "TÇng 3 Thiªn TÇm Th\u00b8p 5",
				string_2 = "TÇm Th\u00b8p 5"
			},
			new MapNavigationEntry
			{
				int_0 = 1038,
				string_3 = "TÇng 3 Thiªn TÇm Th\u00b8p 6|(ST) Thæ PhØ ®éng",
				string_2 = "TÇm Th\u00b8p 6|(ST) Thæ PhØ ®éng"
			},
			new MapNavigationEntry
			{
				int_0 = 1039,
				string_0 = "TÇng 3 Thiªn TÇ",
				string_2 = "TÇm Th\u00b8p 7"
			},
			new MapNavigationEntry
			{
				int_0 = 1040,
				string_0 = "TÇng 3 Thiªn TÇm Th\u00b8p 8|(ST) Thiªn T©m Th\u00b8p 1",
				string_2 = "TÇm Th\u00b8p 8|(ST) Thiªn T©m Th\u00b8p 1"
			},
			new MapNavigationEntry
			{
				int_0 = 1041,
				string_0 = "L©m Du Quan 1|(ST) Thiªn T©m Th\u00b8p tÇng 3",
				string_2 = "L©m Du Quan 1|(ST) Thiªn T©m Th\u00b8p tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1042,
				string_0 = "L©m Du Quan 2|(ST) L\u00adìng Thñy",
				string_2 = "L©m Du Quan 2|(ST) L\u00adìng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1043,
				string_0 = "L©m Du Quan 3",
				string_2 = "L©m Du Quan 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1044,
				string_0 = "L©m Du Quan 4",
				string_2 = "L©m Du Quan 4"
			},
			new MapNavigationEntry
			{
				int_0 = 1045,
				string_0 = "L©m Du Quan 5|Kinh T©y",
				string_2 = "L©m Du Quan 5|Kinh T©y"
			},
			new MapNavigationEntry
			{
				int_0 = 1046,
				string_0 = "L©m Du Quan 6|D\u00ad¬ng Kinh Nam",
				string_2 = "L©m Du Quan 6|D\u00ad¬ng Kinh Nam"
			},
			new MapNavigationEntry
			{
				int_0 = 1047,
				string_0 = "L©m Du Quan 7|D\u00ad¬ng Kinh B¾c",
				string_2 = "L©m Du Quan 7|D\u00ad¬ng Kinh B¾c"
			},
			new MapNavigationEntry
			{
				int_0 = 1048,
				string_0 = "L©m Du Quan 8|B×nh Nguyªn §",
				string_2 = "L©m Du Quan 8|B×nh Nguyªn §"
			},
			new MapNavigationEntry
			{
				int_0 = 1049,
				string_0 = "L\u00adìng Thñy §éng 1|B×nh Nguyªn T",
				string_2 = "L\u00adìng Thñy §éng 1|B×nh Nguyªn T"
			},
			new MapNavigationEntry
			{
				int_0 = 1050,
				string_0 = "L\u00adìng Thñy §éng 2|D\u00ad¬ng Kinh Nam",
				string_2 = "L\u00adìng Thñy §éng 2|D\u00ad¬ng Kinh Nam"
			},
			new MapNavigationEntry
			{
				int_0 = 1051,
				string_0 = "L\u00adìng Thñy §éng 3|B×nh Nguyªn B¾c",
				string_2 = "L\u00adìng Thñy §éng 3|B×nh Nguyªn B¾c"
			},
			new MapNavigationEntry
			{
				int_0 = 1052,
				string_0 = "L\u00adìng Thñy §éng 4|Sa M¹c Nam",
				string_2 = "L\u00adìng Thñy §éng 4|Sa M¹c Nam"
			},
			new MapNavigationEntry
			{
				int_0 = 1053,
				string_0 = "L\u00adìng Thñy §éng 5|Sa M¹c B¾c",
				string_2 = "L\u00adìng Thñy §éng 5|Sa M¹c B¾c"
			},
			new MapNavigationEntry
			{
				int_0 = 1054,
				string_0 = "L\u00adìng Thñy §éng 6|KiÕm C\u00b8c T©y B¾c - L\u00adu Ph\u00adîng Hoµng",
				string_2 = "L\u00adìng Thñy §éng 6|KiÕm C\u00b8c T©y B¾c - L\u00adu Ph\u00adîng Hoµng"
			},
			new MapNavigationEntry
			{
				int_0 = 1055,
				string_0 = "L\u00adìng Thñy §éng 7|KiÕm C\u00b8c T©y §«ng - L\u00adu V« Danh",
				string_2 = "L\u00adìng Thñy §éng 7|KiÕm C\u00b8c T©y §«ng - L\u00adu V« Danh"
			},
			new MapNavigationEntry
			{
				int_0 = 1056,
				string_0 = "L\u00adìng Thñy §éng 8|(PH) Thæ PhØ ®éng",
				string_2 = "L\u00adìng Thñy §éng 8|(PH) Thæ PhØ ®éng"
			},
			new MapNavigationEntry
			{
				int_0 = 1057,
				string_0 = "Kim - Tr\u00adêng S¬|(VD)  Thæ PhØ ®éng",
				string_2 = "Kim - Tr\u00adêng S¬|(VD)  Thæ PhØ ®éng"
			},
			new MapNavigationEntry
			{
				int_0 = 1058,
				string_0 = "Mộc - Tr\u00adêng S¬|(PH) Thanh Thµnh s¬n|(PH) S¬n §éng L\u00adìng Thñy 1",
				string_2 = "Mộc - Tr\u00adêng S¬|(PH) Thanh Thµnh s¬n|(PH) S¬n §éng L\u00adìng Thñy 1"
			},
			new MapNavigationEntry
			{
				int_0 = 1059,
				string_3 = "Thủy - Tr\u00adêng S¬|(VD)  §iÓm Th\u00ad¬ng s¬n",
				string_2 = "Thủy - Tr\u00adêng S¬|(VD)  §iÓm Th\u00ad¬ng s¬n"
			},
			new MapNavigationEntry
			{
				int_0 = 1062,
				string_0 = "(Block)Ba L\u00a8ng huyÖn",
				string_2 = "(Block)Ba L\u00a8ng huyÖn"
			},
			new MapNavigationEntry
			{
				int_0 = 1068,
				string_0 = "(KT)Thiªn T©m Th\u00b8p tÇng 3",
				string_2 = "(KT)Thiªn T©m Th\u00b8p tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1069,
				string_0 = "(KT) L©m Du Quan 1",
				string_2 = "(KT) L©m Du Quan 1"
			},
			new MapNavigationEntry
			{
				int_0 = 1071,
				string_0 = "(KT) L\u00adìng Thñy",
				string_2 = "(KT) L\u00adìng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1079,
				string_0 = "TuyÕt Nam S¬n 1|(CT)Thiªn T©m Th\u00b8p tÇng 3",
				string_2 = "TuyÕt Nam S¬n 1|(CT)Thiªn T©m Th\u00b8p tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1080,
				string_0 = "TuyÕt Nam S¬n 2",
				string_2 = "TuyÕt Nam S¬n 2"
			},
			new MapNavigationEntry
			{
				int_0 = 1081,
				string_0 = "TuyÕt Nam S¬n 3",
				string_2 = "TuyÕt Nam S¬n 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1082,
				string_0 = "TuyÕt Nam S¬n 4|(CT) L©m Du Quan 1",
				string_2 = "TuyÕt Nam S¬n 4|(CT) L©m Du Quan 1"
			},
			new MapNavigationEntry
			{
				int_0 = 1083,
				string_0 = "TuyÕt Nam S¬n 5|(CT) L\u00adìng Thñy",
				string_2 = "TuyÕt Nam S¬n 5|(CT) L\u00adìng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1084,
				string_0 = "TuyÕt Nam S¬n 6",
				string_2 = "TuyÕt Nam S¬n 6"
			},
			new MapNavigationEntry
			{
				int_0 = 1085,
				string_0 = "TuyÕt Nam S¬n 7",
				string_2 = "TuyÕt Nam S¬n 7"
			},
			new MapNavigationEntry
			{
				int_0 = 1086,
				string_0 = "TuyÕt Nam S¬n 8",
				string_2 = "TuyÕt Nam S¬n 8"
			},
			new MapNavigationEntry
			{
				int_0 = 1087,
				string_0 = "§¹i Hoang M¹c 1",
				string_2 = "§¹i Hoang M¹c 1"
			},
			new MapNavigationEntry
			{
				int_0 = 1088,
				string_0 = "§¹i Hoang M¹c 2",
				string_2 = "§¹i Hoang M¹c 2"
			},
			new MapNavigationEntry
			{
				int_0 = 1089,
				string_0 = "§¹i Hoang M¹c 3",
				string_2 = "§¹i Hoang M¹c 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1090,
				string_0 = "§¹i Hoang M¹c 4",
				string_2 = "§¹i Hoang M¹c 4"
			},
			new MapNavigationEntry
			{
				int_0 = 1091,
				string_0 = "§¹i Hoang M¹c 5",
				string_2 = "§¹i Hoang M¹c 5"
			},
			new MapNavigationEntry
			{
				int_0 = 1092,
				string_0 = "§¹i Hoang M¹c 6",
				string_2 = "§¹i Hoang M¹c 6"
			},
			new MapNavigationEntry
			{
				int_0 = 1093,
				string_0 = "§¹i Hoang M¹c 7",
				string_2 = "§¹i Hoang M¹c 7"
			},
			new MapNavigationEntry
			{
				int_0 = 1094,
				string_0 = "§¹i Hoang M¹c 8",
				string_2 = "§¹i Hoang M¹c 8"
			},
			new MapNavigationEntry
			{
				int_0 = 1095,
				string_0 = "B×nh An S¬n 1|(VT) L\u00adìng Thñy",
				string_2 = "B×nh An S¬n 1|(VT) L\u00adìng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1096,
				string_0 = "B×nh An S¬n 2",
				string_2 = "B×nh An S¬n 2|B¹ch Nam Léc"
			},
			new MapNavigationEntry
			{
				int_0 = 1097,
				string_0 = "B×nh An S¬n 3",
				string_2 = "B×nh An S¬n 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1098,
				string_0 = "B×nh An S¬n 4",
				string_3 = "B×nh An S¬n 4",
				string_2 = "B×nh An S¬n 4"
			},
			new MapNavigationEntry
			{
				int_0 = 1099,
				string_0 = "B×nh An S¬n 5|Nam B¹ch S¬n C\u00adíc 1",
				string_2 = "B×nh An S¬n 5|Nam B¹ch S¬n C\u00adíc 1"
			},
			new MapNavigationEntry
			{
				int_0 = 1100,
				string_3 = "VËn Tiªu Bang H|Nam B¹ch S¬n C\u00adíc 2",
				string_2 = "POS|52768,90496,Tiªu Côc sè 1|61024,90432,Tiªu Côc sè 2|62944,99584,Tiªu Côc sè 3|63456,104672,Tiªu Côc sè 4|62560,109632,Th¶o KhÊu sè 1|60416,104864,Th¶o KhÊu sè 2|57632,92928,Th¶o KhÊu sè 3|53056,98784,Th¶o KhÊu sè 4\u0001\u0001Nam B¹ch S¬n C\u00adíc 2|Nam B¹ch S¬n C\u00adíc 2"
			},
			new MapNavigationEntry
			{
				int_0 = 1101,
				string_0 = "Nam B¹ch S¬n C\u00adíc 3",
				string_2 = "Nam B¹ch S¬n C\u00adíc 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1102,
				string_0 = "Nam B¹ch S¬n C\u00adíc 4",
				string_2 = "Nam B¹ch S¬n C\u00adíc 4"
			},
			new MapNavigationEntry
			{
				int_0 = 1103,
				string_0 = "Nam B¹ch S¬n C\u00adíc 5",
				string_2 = "Nam B¹ch S¬n C\u00adíc 5"
			},
			new MapNavigationEntry
			{
				int_0 = 1104,
				string_0 = "Nam B¹ch S¬n C\u00adíc 6",
				string_2 = "Nam B¹ch S¬n C\u00adíc 6"
			},
			new MapNavigationEntry
			{
				int_0 = 1109,
				string_0 = "KiÕm C\u00b8c §«ng Nam - L\u00adu Kinh",
				string_2 = "KiÕm C\u00b8c §«ng Nam - L\u00adu Kinh"
			},
			new MapNavigationEntry
			{
				int_0 = 1110,
				string_0 = "KiÕm C\u00b8c T©y Nguyªn - L\u00adu Sµi Thµnh",
				string_2 = "KiÕm C\u00b8c T©y Nguyªn - L\u00adu Sµi Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 1111,
				string_0 = "(KT) Thæ PhØ",
				string_2 = "(KT) Thæ PhØ ®éng - L\u00adu Kinh Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 1112,
				string_0 = "(ST) ThÇn Tiªn ®éng",
				string_2 = "(ST) ThÇn Tiªn ®éng"
			},
			new MapNavigationEntry
			{
				int_0 = 1113,
				string_0 = "(KT) ThÇn",
				string_2 = "(KT) ThÇn Tiªn ®éng - L\u00adu Kinh"
			},
			new MapNavigationEntry
			{
				int_0 = 1114,
				string_0 = "(ST) H\u00adëng Thñy",
				string_2 = "(ST) H\u00adëng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1115,
				string_0 = "(KT) H\u00adëng Thñy",
				string_2 = "(KT) H\u00adëng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1118,
				string_0 = "(BT) KiÕm C\u00b8c T©y Nguyªn",
				string_2 = "(BT) KiÕm C\u00b8c T©y Nguyªn"
			},
			new MapNavigationEntry
			{
				int_0 = 1119,
				string_0 = "(BT) Thæ PhØ",
				string_2 = "(BT) Thæ PhØ"
			},
			new MapNavigationEntry
			{
				int_0 = 1120,
				string_0 = "(BT) ThÇn",
				string_2 = "(BT) ThÇn Tiªn ®éng - L\u00adu BÕn Tre"
			},
			new MapNavigationEntry
			{
				int_0 = 1121,
				string_0 = "(BT) H\u00adëng Thñy",
				string_2 = "(BT) H\u00adëng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1122,
				string_0 = "(BT) Thiªn T©m Th\u00b8p tÇng 3",
				string_2 = "(BT) Thiªn T©m Th\u00b8p tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1123,
				string_0 = "(BT) L©m Du Quan",
				string_2 = "(BT) L©m Du Quan"
			},
			new MapNavigationEntry
			{
				int_0 = 1128,
				string_0 = "(CM) K",
				string_2 = "(CM) KiÕm C\u00b8c T©y Nguyªn"
			},
			new MapNavigationEntry
			{
				int_0 = 1129,
				string_0 = "(CM) Thæ PhØ",
				string_2 = "(CM) Thæ PhØ"
			},
			new MapNavigationEntry
			{
				int_0 = 1130,
				string_0 = "(CM) ThÇn",
				string_2 = "(CM) ThÇn Tiªn ®éng"
			},
			new MapNavigationEntry
			{
				int_0 = 1131,
				string_0 = "(CM) H\u00adëng Thñy",
				string_2 = "(CM) H\u00adëng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1132,
				string_0 = "(CM) Thiªn T©m Th\u00b8p tÇng 3",
				string_2 = "(CM) Thiªn T©m Th\u00b8p tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1133,
				string_0 = "(CM) L©m Du Quan",
				string_2 = "(CM) L©m Du Quan"
			},
			new MapNavigationEntry
			{
				int_0 = 1138,
				string_0 = "(LA) K",
				string_2 = "(LA) KiÕm C\u00b8c T©y Nguyªn"
			},
			new MapNavigationEntry
			{
				int_0 = 1139,
				string_0 = "(LA) Thæ PhØ",
				string_2 = "(LA) Thæ PhØ"
			},
			new MapNavigationEntry
			{
				int_0 = 1140,
				string_0 = "(LA) ThÇn",
				string_2 = "(LA) ThÇn Tiªn ®éng"
			},
			new MapNavigationEntry
			{
				int_0 = 1141,
				string_0 = "(LA) H\u00adëng Thñy",
				string_2 = "(LA) H\u00adëng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1142,
				string_0 = "(LA) Thiªn T©m Th\u00b8p tÇng 3",
				string_2 = "(LA) Thiªn T©m Th\u00b8p tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1143,
				string_0 = "(LA) L©m Du Quan",
				string_2 = "(LA) L©m Du Quan"
			},
			new MapNavigationEntry
			{
				int_0 = 1148,
				string_0 = "(AG) K",
				string_2 = "(AG) KiÕm C\u00b8c T©y Nguyªn"
			},
			new MapNavigationEntry
			{
				int_0 = 1149,
				string_0 = "(AG) Thæ PhØ",
				string_2 = "(AG) Thæ PhØ"
			},
			new MapNavigationEntry
			{
				int_0 = 1150,
				string_0 = "(AG) ThÇn",
				string_2 = "(AG) ThÇn Tiªn ®éng"
			},
			new MapNavigationEntry
			{
				int_0 = 1151,
				string_0 = "(AG) H\u00adëng Thñy",
				string_2 = "(AG) H\u00adëng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1152,
				string_0 = "(AG) Thiªn T©m Th\u00b8p tÇng 3",
				string_2 = "(AG) Thiªn T©m Th\u00b8p tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1153,
				string_0 = "(AG) L©m Du Quan",
				string_2 = "(AG) L©m Du Quan"
			},
			new MapNavigationEntry
			{
				int_0 = 1158,
				string_0 = "(HG) K",
				string_2 = "(HG) KiÕm C\u00b8c T©y Nguyªn"
			},
			new MapNavigationEntry
			{
				int_0 = 1159,
				string_0 = "(HG) Thæ PhØ",
				string_2 = "(HG) Thæ PhØ"
			},
			new MapNavigationEntry
			{
				int_0 = 1160,
				string_0 = "(HG) ThÇn",
				string_2 = "(HG) ThÇn Tiªn ®éng"
			},
			new MapNavigationEntry
			{
				int_0 = 1161,
				string_0 = "(HG) H\u00adëng Thñy",
				string_2 = "(HG) H\u00adëng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1162,
				string_0 = "(HG) Thiªn T©m Th\u00b8p tÇng 3",
				string_2 = "(HG) Thiªn T©m Th\u00b8p tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1163,
				string_0 = "(HG) L©m Du Quan",
				string_2 = "(HG) L©m Du Quan"
			},
			new MapNavigationEntry
			{
				int_0 = 1168,
				string_0 = "(BL) K",
				string_2 = "(BL) KiÕm C\u00b8c T©y Nguyªn"
			},
			new MapNavigationEntry
			{
				int_0 = 1169,
				string_0 = "(BL) Thæ PhØ",
				string_2 = "(BL) Thæ PhØ"
			},
			new MapNavigationEntry
			{
				int_0 = 1170,
				string_0 = "(BL) ThÇn",
				string_2 = "(BL) ThÇn Tiªn ®éng"
			},
			new MapNavigationEntry
			{
				int_0 = 1171,
				string_0 = "(BL) H\u00adëng Thñy",
				string_2 = "(BL) H\u00adëng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1172,
				string_0 = "(BL) Thiªn T©m Th\u00b8p tÇng 3",
				string_2 = "(BL) Thiªn T©m Th\u00b8p tÇng 3"
			},
			new MapNavigationEntry
			{
				int_0 = 1173,
				string_0 = "(BL) L©m Du Quan",
				string_2 = "(BL) L©m Du Quan"
			},
			new MapNavigationEntry
			{
				int_0 = 1178,
				string_0 = "(BT) L\u00adìng Thñy",
				string_2 = "(BT) L\u00adìng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1179,
				string_0 = "(CM) L\u00adìng Thñy",
				string_2 = "(CM) L\u00adìng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1180,
				string_0 = "(LA) L\u00adìng Thñy",
				string_2 = "(LA) L\u00adìng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1181,
				string_0 = "(AG) L\u00adìng Thñy",
				string_2 = "(AG) L\u00adìng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1182,
				string_0 = "(HG) L\u00adìng Thñy",
				string_2 = "(HG) L\u00adìng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1183,
				string_0 = "(BL) L\u00adìng Thñy",
				string_2 = "(BL) L\u00adìng Thñy"
			},
			new MapNavigationEntry
			{
				int_0 = 1234,
				string_0 = "KiÕm C\u00b8c V« D",
				string_2 = "KiÕm C\u00b8c V« Danh - L\u00adu V« Danh"
			},
			new MapNavigationEntry
			{
				int_0 = 1235,
				string_0 = "Thñ ThØ §éng - L\u00adu Sµi",
				string_2 = "Thñ ThØ §éng - L\u00adu Sµi"
			},
			new MapNavigationEntry
			{
				int_0 = 1236,
				string_0 = "ThÇn C«ng §éng",
				string_2 = "ThÇn C«ng §éng\t - L\u00adu Kinh Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 1237,
				string_0 = "H\u00adëng Háa ®éng",
				string_2 = "H\u00adëng Háa ®éng - L\u00adu C\u00b8t Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 1238,
				string_0 = "Cæ ThiÕt Th\u00b8p",
				string_2 = "Cæ ThiÕt Th\u00b8p - L\u00adu ViÖt Thµnh"
			},
			new MapNavigationEntry
			{
				int_0 = 1251,
				string_0 = "§«ng Du Quan - L\u00adu BÕn Tr",
				string_2 = "§«ng Du Quan - L\u00adu BÕn Tr"
			},
			new MapNavigationEntry
			{
				int_0 = 1252,
				string_0 = "T©y Du Quan - L\u00adu Cµ Mau",
				string_2 = "T©y Du Quan - L\u00adu Cµ Mau"
			},
			new MapNavigationEntry
			{
				int_0 = 1253,
				string_0 = "Nam Du Quan - L\u00adu Long An",
				string_2 = "Nam Du Quan - L\u00adu Long An"
			},
			new MapNavigationEntry
			{
				int_0 = 1254,
				string_0 = "B¾c Du Quan - L\u00adu An Gia",
				string_2 = "B¾c Du Quan - L\u00adu An Gia"
			},
			new MapNavigationEntry
			{
				int_0 = 1255,
				string_0 = "L\u00adìng Thñy §«ng",
				string_2 = "L\u00adìng Thñy §«ng - L\u00adu BÕn Tr"
			},
			new MapNavigationEntry
			{
				int_0 = 1256,
				string_0 = "L\u00adìng Thñy T©y",
				string_2 = "L\u00adìng Thñy T©y - L\u00adu Cµ M"
			},
			new MapNavigationEntry
			{
				int_0 = 1257,
				string_0 = "L\u00adìng Thñy Nam",
				string_2 = "L\u00adìng Thñy Nam - L\u00adu Long A"
			},
			new MapNavigationEntry
			{
				int_0 = 1258,
				string_0 = "Lưỡng Thủy Bắc",
				string_2 = "Lưỡng Thủy Bắc - Lưu An Gi"
			}
		};
		uint[,] array_ = new uint[5, 2];
		Class10.smethod_4(array_, 68852);
		uint_0 = array_;
		uint[,] array_2 = new uint[5, 2];
		Class10.smethod_4(array_2, 68901);
		uint_1 = array_2;
		uint[,] array_3 = new uint[5, 2];
		Class10.smethod_4(array_3, 68950);
		uint_2 = array_3;
		uint[,] array_4 = new uint[5, 2];
		Class10.smethod_4(array_4, 68999);
		uint_3 = array_4;
		uint[,] array_5 = new uint[5, 2];
		Class10.smethod_4(array_5, 69048);
		uint_4 = array_5;
		uint[,] array_6 = new uint[5, 2];
		Class10.smethod_4(array_6, 69097);
		uint_5 = array_6;
		uint[,] array_7 = new uint[5, 2];
		Class10.smethod_4(array_7, 69146);
		uint_6 = array_7;
		cityTeleportData_0 = new CityTeleportData[7]
		{
			new CityTeleportData
			{
				int_0 = 11,
				string_0 = "Thµnh §«",
				uint_0 = uint_0
			},
			new CityTeleportData
			{
				int_0 = 78,
				string_0 = "T\u00ad¬ng D\u00ad¬ng",
				uint_0 = uint_1
			},
			new CityTeleportData
			{
				int_0 = 1,
				string_0 = "Ph\u00adîng T\u00adêng",
				uint_0 = uint_2
			},
			new CityTeleportData
			{
				int_0 = 162,
				string_0 = "§¹i Lý",
				uint_0 = uint_3
			},
			new CityTeleportData
			{
				int_0 = 37,
				string_0 = "BiÖn Kinh",
				uint_0 = uint_4
			},
			new CityTeleportData
			{
				int_0 = 80,
				string_0 = "D\u00ad¬ng Ch©u",
				uint_0 = uint_5
			},
			new CityTeleportData
			{
				int_0 = 176,
				string_0 = "L©m An",
				uint_0 = uint_6
			}
		};
		int_0 = new int[14]
		{
			75, 225, 226, 227, 321, 322, 336, 340, 144, 93,
			124, 152, 320, 319
		};
		string_3 = "HYzBCQIxEEVb+QUs9qAiWIDgOQmyEzQTXZKDFViA2MEelAVFMKAIHmYaM3p7Dx5v7LAlfWBNMnCLRHqEXD2svKsuSA+MuRSmX3ZrsMsGyVhMpXi0Jqzg9G5gcopwpD1jIy+P5WzSIMkn1eN/bOUZwVL2SF2sHnRAp5dKrKeMkPXMoy8=";
		random_0 = new Random();
	}

	public static void smethod_0(ref MapNavigationEntry[] mapNavigationEntry_1, string string_4, string string_5, int int_1 = 0, string string_6 = null, int int_2 = 1)
	{
		string[] array = string_4.Split('|');
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == null || array[i] == string.Empty)
			{
				continue;
			}
			string[] array2 = array[i].Split('=', ';');
			int num = Class11.smethod_11(array2[1]);
			string text = array2[0];
			if (num == 0 || text == null)
			{
				continue;
			}
			text = text.Replace("\t", "").Trim();
			if (text == null || text == string.Empty)
			{
				continue;
			}
			text = text.Replace("_", "|");
			if (int_2 > 0)
			{
				string text2 = string.Empty;
				for (int j = 0; j < int_2; j++)
				{
					if (text2 != null && text2 != string.Empty)
					{
						text2 += "|";
					}
					text2 += "rang k";
				}
				string_5 = string_5 + "|" + text2;
			}
			string string_7 = null;
			if (int_1 > 0)
			{
				string_7 = text;
			}
			Class37.smethod_6(ref mapNavigationEntry_1, num, string_5, text, text, string_7, string_6);
		}
	}

	private static int smethod_1(int int_1)
	{
		for (int i = 0; i < int_0.Length; i++)
		{
			if (int_1 == int_0[i])
			{
				return i;
			}
		}
		return -1;
	}

	public static void smethod_2(CharacterAccountConfig characterAccountConfig_0, int int_1 = -1)
	{
		if (Class75.smethod_1(characterAccountConfig_0, Class75.uint_18) >= 60)
		{
		}
	}

	public static int smethod_3(object object_0)
	{
		if (object_0 == null)
		{
			return -1;
		}
		string text = object_0.ToString();
		if (text == string.Empty)
		{
			return -1;
		}
		int result = -1;
		int num = -1;
		string[] array = typeof(string).ToString().Split('.');
		string value = array[array.Length - 1].ToUpper();
		bool flag;
		if (!(flag = 0 <= object_0.GetType().ToString().ToUpper()
			.IndexOf(value)))
		{
			num = Class11.smethod_11(text);
			if (num <= 0)
			{
				return -1;
			}
		}
		if (Class37.mapNavigationEntry_0 == null && !Class37.smethod_107())
		{
			return -1;
		}
		for (int i = 0; i < Class37.mapNavigationEntry_0.Length; i++)
		{
			if (!flag)
			{
				if (num > 0 && num == Class37.mapNavigationEntry_0[i].int_0)
				{
					result = i;
					break;
				}
			}
			else if (text == Class37.mapNavigationEntry_0[i].string_0 || text == Class37.mapNavigationEntry_0[i].string_2 || Class11.smethod_1(text, Class37.mapNavigationEntry_0[i].string_0) == 0 || Class11.smethod_1(Class37.mapNavigationEntry_0[i].string_0, text) == 0 || Class11.smethod_1(text, Class37.mapNavigationEntry_0[i].string_2) == 0 || Class11.smethod_1(Class37.mapNavigationEntry_0[i].string_2, text) == 0)
			{
				result = i;
				break;
			}
		}
		return result;
	}

	private static string smethod_4(object object_0, uint[] uint_7)
	{
		if (uint_7 != null)
		{
			int num = smethod_3(object_0);
			if (num < 0)
			{
				return null;
			}
			if (Class37.mapNavigationEntry_0 == null && !Class37.smethod_107())
			{
				return null;
			}
			int num2 = Class37.mapNavigationEntry_0[num].int_0;
			if (num2 > 0)
			{
				int num3 = Class45.smethod_0(num2);
				for (int i = 0; i < cityTeleportData_0.Length; i++)
				{
					if (num2 != cityTeleportData_0[i].int_0 && num3 != cityTeleportData_0[i].int_0)
					{
						continue;
					}
					int num4 = -1;
					long num5 = -1L;
					uint[,] array = cityTeleportData_0[i].uint_0;
					for (int j = 0; j < array.GetLength(0); j++)
					{
						if (array[j, 0] != 0)
						{
							long num6 = Class64.smethod_18(uint_7, new uint[2]
							{
								array[j, 0],
								array[j, 1]
							});
							if (num4 < 0 || num6 < num5)
							{
								num4 = j;
								num5 = num6;
							}
						}
					}
					if (0 <= num4)
					{
						return Class37.string_0[num4];
					}
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public static bool smethod_5(CharacterAccountConfig characterAccountConfig_0, string string_4)
	{
		int num = 0;
		int num2 = random_0.Next(10, 100);
		while (num < 40 && Class75.smethod_3(characterAccountConfig_0, Class75.uint_5, 4) > 0)
		{
			num++;
			Thread.Sleep(40 + num2);
		}
		int num3 = 0;
		Class39.smethod_0(characterAccountConfig_0);
		if (Class75.smethod_44(characterAccountConfig_0, "ThÇn Hµnh Phï"))
		{
			int num4 = 0;
			while (num4 < 7)
			{
				num4++;
				if (0 > Class95.smethod_0(characterAccountConfig_0))
				{
					Thread.Sleep(100 + Class95.int_0);
					continue;
				}
				num4 = 0;
				break;
			}
			if (num4 <= 0)
			{
				Thread.Sleep(230);
				num3 = Class95.smethod_6(characterAccountConfig_0, string_4, bool_0: false, bool_1: true);
				if (num3 > 0)
				{
					Thread.Sleep(300);
					Class64.smethod_11(characterAccountConfig_0);
				}
			}
			Class95.smethod_8(characterAccountConfig_0);
		}
		Class75.smethod_2(characterAccountConfig_0, Class75.uint_5, 0, 4);
		return num3 > 0;
	}

	public static int smethod_6(CharacterAccountConfig characterAccountConfig_0, int int_1 = 1)
	{
		for (int i = 0; i < Class37.mapNavigationEntry_0.Length; i++)
		{
			if ((int_1 != 53 && Class37.mapNavigationEntry_0[i].string_3 == "VANTIEU") || (int_1 == 53 && Class37.mapNavigationEntry_0[i].string_3 == "VANTIEUBANG"))
			{
				smethod_5(characterAccountConfig_0, Class37.mapNavigationEntry_0[i].string_4 + "|VËn Tiªu|BÕn Tµu");
				return 1;
			}
		}
		return 0;
	}

	public static bool smethod_7(CharacterAccountConfig characterAccountConfig_0, object object_0, string string_4 = null, uint[] uint_7 = null, bool bool_0 = false)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		if (int_ != 4)
		{
			return false;
		}
		uint num = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array, 0);
		uint num3 = num2 * Class56.memorySignatureScanConfig_15.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
		if (int_ != 4)
		{
			return false;
		}
		uint num4 = BitConverter.ToUInt32(array, 0);
		uint num5 = num4 + num3;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_);
		int num6 = BitConverter.ToInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
		int num7 = BitConverter.ToInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
		int num8 = BitConverter.ToInt32(array, 0);
		int num9 = Class89.smethod_39(characterAccountConfig_0);
		if (num7 != 0 && num8 != 0 && num6 != 0 && num9 > 1)
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_);
			int num10 = BitConverter.ToInt32(array, 0);
			int num11 = smethod_3(object_0);
			if (num11 < 0)
			{
				return false;
			}
			if (Class37.mapNavigationEntry_0 == null && !Class37.smethod_107())
			{
				return false;
			}
			string text = Class37.mapNavigationEntry_0[num11].string_4;
			if (text != null && !(text == string.Empty))
			{
				int num12 = Class37.mapNavigationEntry_0[num11].int_0;
				string text2 = Class37.mapNavigationEntry_0[num11].string_2;
				if (text2 != null && text2.IndexOf("POS") == 0)
				{
					string[] array2 = text2.Split('|', ',', ';');
					if (array2.Length > 3)
					{
						int num13 = array2.Length / 3;
						uint[] array3 = new uint[2];
						uint[] array4 = new uint[2];
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_);
						array4[0] = BitConverter.ToUInt32(array, 0);
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_);
						array4[1] = BitConverter.ToUInt32(array, 0);
						if (uint_7 != null)
						{
							array4[0] = uint_7[0];
							array4[1] = uint_7[1];
						}
						else if (Class46.characterSyncSnapshot_0.uint_4 != null && Class46.characterSyncSnapshot_0.uint_4[0] != 0 && Class46.characterSyncSnapshot_0.uint_4[1] != 0)
						{
							array4[0] = Class46.characterSyncSnapshot_0.uint_4[0];
							array4[1] = Class46.characterSyncSnapshot_0.uint_4[1];
						}
						long num14 = -1L;
						string text3 = null;
						for (int i = 0; i < num13; i++)
						{
							array3[0] = Class11.smethod_12(array2[i * 3 + 1]);
							array3[1] = Class11.smethod_12(array2[i * 3 + 2]);
							if (array3[0] != 0 && array3[1] != 0)
							{
								long num15 = Class64.smethod_18(array4, array3);
								if (text3 == null || text3 == string.Empty || num14 > num15)
								{
									text3 = array2[i * 3 + 3];
									num14 = num15;
								}
							}
						}
						if (text3 != null)
						{
							string[] array5 = text2.Split('\u0001');
							string[] array6 = text3.Split('\u0001');
							if (array6[0] != null && array6[0] != string.Empty)
							{
								text2 = array6[0];
							}
							if (array6.Length > 1 && array6[1] != null && array6[1] != string.Empty)
							{
								text = array6[1].Replace("_", "|");
							}
							if (array5.Length > 2 && array5[2] != null && array5[2] != string.Empty)
							{
								text2 = text2 + "|" + array5[2];
							}
							if (text2 != null && text2 != string.Empty)
							{
								text2 = text2.Replace("_", "|");
							}
						}
					}
				}
				string text4 = null;
				text4 = (((num12 != 959 && num12 != 990) || string_4 == null || !(string_4 != string.Empty)) ? text2 : string_4);
				if (string_4 == null || string_4 == string.Empty)
				{
					if (Class11.smethod_63(uint_7))
					{
						string_4 = smethod_4(num12, uint_7);
					}
					if (string_4 == null)
					{
						string_4 = Class37.mapNavigationEntry_0[num11].string_1;
					}
				}
				text = text4 + "|" + text;
				if (string_4 != null)
				{
					text = text + "|" + string_4;
				}
				if (bool_0)
				{
					string[] array7 = text.Split('|');
					if (array7.Length > 1)
					{
						text = "håi sinh|u R\u00ad¬ng| r\u00ad¬ng|iÓm Quay L¹i";
						for (int j = 1; j < array7.Length; j++)
						{
							text = text + "|" + array7[j];
						}
						text += "|Õt thóc";
					}
				}
				int num16 = 0;
				int num17 = random_0.Next(10, 100);
				while (num16 < 40 && Class75.smethod_3(characterAccountConfig_0, Class75.uint_5, 4) > 0)
				{
					num16++;
					Thread.Sleep(40 + num17);
				}
				Class75.smethod_2(characterAccountConfig_0, Class75.uint_5, 1, 4);
				int num18 = 0;
				int num19 = 0;
				while (true)
				{
					string text5 = "ThÇn Hµnh Phï";
					string string_5 = Class37.mapNavigationEntry_0[num11].string_5;
					bool flag;
					if (flag = num19 == 0 && string_5 != null && string_5 != string.Empty)
					{
						text5 = string_5;
					}
					bool flag2 = false;
					uint num20 = (uint)Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4);
					if (!flag && num20 != 0)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
						uint num21 = BitConverter.ToUInt32(array, 0);
						uint num22 = num21 + Class56.memorySignatureScanConfig_97.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num22 + (num20 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array, 4, ref int_);
						uint num23 = BitConverter.ToUInt32(array, 0);
						uint num24 = (uint)Class75.smethod_3(characterAccountConfig_0, Class75.uint_19 + 1, 4);
						if (num23 != 0 && num23 == num24)
						{
							uint num25 = num22 + num20 * 20;
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num25 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
							int num26 = array[0];
							if (num26 == 3)
							{
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_);
								if (int_ != 4)
								{
									return false;
								}
								uint num27 = BitConverter.ToUInt32(array, 0);
								uint num28 = num27 + num23 * Class56.memorySignatureScanConfig_106.uint_0;
								byte[] array8 = new byte[text5.Length + 2];
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num28 + Class56.memorySignatureScanConfig_107.uint_0, array8, array8.Length, ref int_);
								string text6 = Class1.smethod_3(array8).Replace(" ", string.Empty).ToLower();
								if (text6.IndexOf(text5.Replace(" ", string.Empty).ToLower()) >= 0)
								{
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num25 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array, 1, ref int_);
									int num29 = array[0];
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num25 + Class56.memorySignatureScanConfig_100.uint_0, array, 1, ref int_);
									int int_2 = array[0];
									if (Class95.Class92.smethod_4(characterAccountConfig_0) || 0 <= Class95.smethod_0(characterAccountConfig_0))
									{
										Class95.smethod_8(characterAccountConfig_0);
										Thread.Sleep(100);
									}
									flag2 = Class75.smethod_43(characterAccountConfig_0, num24, num29, int_2);
								}
							}
						}
					}
					if (!flag2)
					{
						if (Class95.Class92.smethod_4(characterAccountConfig_0) || 0 <= Class95.smethod_0(characterAccountConfig_0))
						{
							Class95.smethod_8(characterAccountConfig_0);
							Thread.Sleep(100);
						}
						flag2 = Class75.smethod_44(characterAccountConfig_0, text5, bool_0: false, -1, flag);
					}
					if (!flag2)
					{
						if (!flag || num19 != 0)
						{
							break;
						}
						num19 = 1;
						continue;
					}
					int num30 = 0;
					while (num30 < 7)
					{
						num30++;
						if (0 > Class95.smethod_0(characterAccountConfig_0))
						{
							Thread.Sleep(100 + Class95.int_0);
							continue;
						}
						num30 = 0;
						break;
					}
					if (num30 <= 0)
					{
						num18 = Class95.smethod_6(characterAccountConfig_0, text, bool_0: false, bool_1: true, bool_2: false, bool_3: true);
						if (!bool_0 && num18 > 0)
						{
							Thread.Sleep(300);
							int num31 = num10;
							int num32 = num8;
							int num33 = 0;
							int num34 = 0;
							long long_ = Class11.smethod_27();
							while (!Class11.bool_0 && Class11.smethod_28(long_) < 1200L && num33 < 30)
							{
								num33++;
								Thread.Sleep(60 + Class95.int_0);
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
								if (int_ == 4)
								{
									num = BitConverter.ToUInt32(array, 0);
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
									num2 = BitConverter.ToUInt32(array, 0);
									num3 = num2 * Class56.memorySignatureScanConfig_15.uint_0;
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
									if (int_ == 4)
									{
										num4 = BitConverter.ToUInt32(array, 0);
										num5 = num4 + num3;
										Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_);
										num6 = BitConverter.ToInt32(array, 0);
										Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
										num7 = BitConverter.ToInt32(array, 0);
										Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_);
										num31 = BitConverter.ToInt32(array, 0);
										Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_);
										num32 = BitConverter.ToInt32(array, 0);
										num9 = Class89.smethod_39(characterAccountConfig_0);
										if (num7 != 0 && num32 != 0 && num6 != 0 && num9 > 1)
										{
											if (num10 > 0 || num34 > 3 || num32 != num8 || num31 != num10)
											{
												break;
											}
											num34++;
										}
										else
										{
											num34 = 0;
										}
										continue;
									}
									return false;
								}
								return false;
							}
							if (num32 != num8 || num31 != num10)
							{
								num18 = 1;
							}
							num10 = num31;
						}
					}
					if (num10 == 0 && 0 <= Class95.smethod_0(characterAccountConfig_0))
					{
						Class95.smethod_8(characterAccountConfig_0);
						if (Form1.int_125 <= 0 && Class39.smethod_0(characterAccountConfig_0) == num8)
						{
							smethod_2(characterAccountConfig_0);
						}
					}
					break;
				}
				Class75.smethod_2(characterAccountConfig_0, Class75.uint_5, 0, 4);
				return num18 > 0;
			}
			return false;
		}
		return false;
	}
}
