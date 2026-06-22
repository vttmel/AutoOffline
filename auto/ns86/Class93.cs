using ns10;
using ns61;

namespace ns86;

internal class Class93
{
	public static GStruct23[] gstruct23_0 = null;

	public static GStruct23[] gstruct23_1 = null;

	public static uint[] smethod_0(uint[] uint_0)
	{
		if (gstruct23_1 == null)
		{
			gstruct23_1 = smethod_2();
		}
		int num = -1;
		long num2 = -1L;
		for (int i = 0; i < gstruct23_1.Length; i++)
		{
			long num3 = Class64.smethod_21(gstruct23_1[i].uint_0, uint_0);
			if (num < 0 || num3 < num2)
			{
				num = i;
				num2 = num3;
			}
		}
		return num switch
		{
			0 => new uint[2] { 52692u, 103470u }, 
			1 => new uint[2] { 49674u, 104586u }, 
			2 => new uint[2] { 49046u, 99282u }, 
			_ => new uint[2] { 52318u, 98808u }, 
		};
	}

	public static GStruct23[] smethod_1()
	{
		uint[,] array = new uint[12, 2];
		Class10.smethod_4(array, 367135);
		uint[,] uint_ = array;
		uint[,] array2 = new uint[10, 2];
		Class10.smethod_4(array2, 367240);
		uint[,] uint_2 = array2;
		uint[,] array3 = new uint[15, 2];
		Class10.smethod_4(array3, 367329);
		uint[,] uint_3 = array3;
		uint[,] array4 = new uint[12, 2];
		Class10.smethod_4(array4, 367458);
		uint[,] uint_4 = array4;
		uint[,] array5 = new uint[15, 2];
		Class10.smethod_4(array5, 367563);
		uint[,] uint_5 = array5;
		uint[,] array6 = new uint[9, 2];
		Class10.smethod_4(array6, 367692);
		uint[,] uint_6 = array6;
		uint[,] array7 = new uint[12, 2];
		Class10.smethod_4(array7, 367773);
		uint[,] uint_7 = array7;
		return new GStruct23[7]
		{
			new GStruct23
			{
				uint_0 = uint_
			},
			new GStruct23
			{
				uint_0 = uint_2
			},
			new GStruct23
			{
				uint_0 = uint_3
			},
			new GStruct23
			{
				uint_0 = uint_4
			},
			new GStruct23
			{
				uint_0 = uint_5
			},
			new GStruct23
			{
				uint_0 = uint_6
			},
			new GStruct23
			{
				uint_0 = uint_7
			}
		};
	}

	public static GStruct23[] smethod_2()
	{
		uint[,] array = new uint[7, 2];
		Class10.smethod_4(array, 367910);
		uint[,] uint_ = array;
		uint[,] array2 = new uint[7, 2];
		Class10.smethod_4(array2, 367975);
		uint[,] uint_2 = array2;
		uint[,] array3 = new uint[8, 2];
		Class10.smethod_4(array3, 368040);
		uint[,] uint_3 = array3;
		uint[,] array4 = new uint[7, 2];
		Class10.smethod_4(array4, 368113);
		uint[,] uint_4 = array4;
		return new GStruct23[4]
		{
			new GStruct23
			{
				uint_0 = uint_4
			},
			new GStruct23
			{
				uint_0 = uint_3
			},
			new GStruct23
			{
				uint_0 = uint_2
			},
			new GStruct23
			{
				uint_0 = uint_
			}
		};
	}
}
