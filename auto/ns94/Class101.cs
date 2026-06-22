using ns10;
using ns61;

namespace ns94;

internal class Class101
{
	public static GStruct25[] gstruct25_0;

	public static uint[,] uint_0;

	public static uint[,] uint_1;

	public static uint[,] uint_2;

	private static uint[,] uint_3;

	private static uint[,] uint_4;

	static Class101()
	{
		gstruct25_0 = new GStruct25[3]
		{
			new GStruct25
			{
				int_0 = 333,
				uint_0 = new uint[2] { 42240u, 92160u },
				string_0 = "T©y"
			},
			new GStruct25
			{
				int_0 = 333,
				uint_0 = new uint[2] { 49408u, 102464u },
				string_0 = "®«ng|§«ng"
			},
			new GStruct25
			{
				int_0 = 333,
				uint_0 = new uint[2] { 41265u, 102756u },
				string_0 = "Nam"
			}
		};
		uint[,] array_ = new uint[3, 2];
		Class10.smethod_4(array_, 376335);
		uint_0 = array_;
		uint[,] array_2 = new uint[3, 2];
		Class10.smethod_4(array_2, 376368);
		uint_1 = array_2;
		uint[,] array_3 = new uint[4, 2];
		Class10.smethod_4(array_3, 376401);
		uint_2 = array_3;
		uint[,] array_4 = new uint[52, 2];
		Class10.smethod_4(array_4, 376442);
		uint_3 = array_4;
		uint[,] array_5 = new uint[84, 2];
		Class10.smethod_4(array_5, 376868);
		uint_4 = array_5;
	}

	public static bool smethod_0(uint[] uint_5)
	{
		long num = Class64.smethod_21(uint_4, uint_5);
		long num2 = Class64.smethod_21(uint_3, uint_5);
		return num < num2;
	}

	public static uint[,] smethod_1(uint[] uint_5)
	{
		uint[,] array = new uint[3, 2];
		int num = Class64.smethod_20(uint_0, uint_5);
		array[0, 0] = uint_0[num, 0];
		array[0, 1] = uint_0[num, 1];
		num = Class64.smethod_20(uint_1, uint_5);
		array[1, 0] = uint_1[num, 0];
		array[1, 1] = uint_1[num, 1];
		num = Class64.smethod_20(uint_2, uint_5);
		array[2, 0] = uint_2[num, 0];
		array[2, 1] = uint_2[num, 1];
		return Class64.smethod_20(array, uint_5) switch
		{
			1 => uint_1, 
			0 => uint_0, 
			_ => uint_2, 
		};
	}
}
