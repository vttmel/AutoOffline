using System;
using System.IO;
using System.Threading;
using ns10;
using ns11;
using ns53;
using ns69;

namespace ns41;

internal class Class44
{
	public static GStruct21[] gstruct21_0 = null;

	public static int[,] int_0 = null;

	public static int[,] int_1 = null;

	private static bool bool_0 = false;

	private static bool bool_1 = false;

	public static void smethod_0()
	{
		int num = 0;
		do
		{
			if (bool_0)
			{
				num++;
				Thread.Sleep(1000);
				continue;
			}
			bool_0 = true;
			int num2 = 0;
			string text = Class56.string_9 + "\\tbRoad.txt";
			while (true)
			{
				IL_012d:
				string text2 = Class11.smethod_33(text, 0, 0, 1);
				if (text2 != null && !(text2 == string.Empty))
				{
					while (text2 != null && text2 != string.Empty && (text2[0] == '\r' || text2[0] == '\n'))
					{
						text2 = text2.Substring(1);
					}
					if (text2 != null && !(text2 == string.Empty) && text2.IndexOf("=") <= 4)
					{
						string[] array = text2.Split('\r', '\n');
						int[,] array2 = new int[2, 2];
						Class10.smethod_4(array2, 187049);
						int[,] array3 = array2;
						int num3 = 0;
						int[,] array4 = new int[array3.GetLength(0), 2];
						if (int_1 != null)
						{
							array4 = new int[array3.GetLength(0) + int_1.GetLength(0), 2];
							for (int i = 0; i < int_1.GetLength(0); i++)
							{
								array4[num3, 0] = int_1[i, 0];
								array4[num3, 1] = int_1[i, 1];
								num3++;
							}
							int_1 = null;
						}
						for (int j = 0; j < array3.GetLength(0); j++)
						{
							array4[num3, 0] = array3[j, 0];
							array4[num3, 1] = array3[j, 1];
							num3++;
						}
						int_0 = new int[array4.GetLength(0), 2];
						for (int k = 0; k < array4.GetLength(0); k++)
						{
							int_0[k, 0] = array4[k, 0];
							int_0[k, 1] = array4[k, 1];
						}
						int num4 = 0;
						gstruct21_0 = new GStruct21[array.Length + array4.GetLength(0) + 1];
						string[] array5 = array;
						foreach (string text3 in array5)
						{
							if (text3 == null || text3 == string.Empty)
							{
								continue;
							}
							int num5 = text3.IndexOf("=");
							if (num5 < 0)
							{
								continue;
							}
							int num6 = Class11.smethod_11(text3.Substring(0, num5));
							if (num6 == 0)
							{
								continue;
							}
							string text4 = Class11.smethod_72(text3.Substring(num5 + 1).Trim());
							if (text4 == null || text4 == string.Empty)
							{
								continue;
							}
							ref GStruct21 reference = ref gstruct21_0[num4];
							reference = smethod_9(text4, num6);
							num4++;
							for (int m = 0; m < array4.GetLength(0); m++)
							{
								if (num6 == array4[m, 0])
								{
									ref GStruct21 reference2 = ref gstruct21_0[num4];
									reference2 = smethod_9(text4, array4[m, 1]);
									array4[m, 0] = -1;
									num4++;
								}
							}
						}
						if (num4 == 0)
						{
							gstruct21_0 = null;
						}
						else if (num4 < gstruct21_0.Length)
						{
							Array.Resize(ref gstruct21_0, num4);
						}
						break;
					}
				}
				while (true)
				{
					num2++;
					string text5 = null;
					if (num2 != 1)
					{
						if (num2 == 2)
						{
							text5 = "ᓸᔄᔄᔀᓊᒿᒿᓻᓹᓽᔉᓵᓾᒾᓾᓵᔄᒿᔅᔀᓼᓿᓱᓴᒿᔄᓽᔀᒿᔄᓲᓢᓿᓱᓴᒾᔄᔈᔄ";
						}
					}
					else
					{
						text5 = "ᔣᔯᔯᔫᔮᓵᓪᓪᔟᔭᔤᔱᔠᓩᔢᔪᔪᔢᔧᔠᓩᔞᔪᔨᓪᔡᔤᔧᔠᓪᔟᓪᓬᔍᔥᔪᔔᔡᓰᔰᔃᔞᓽᔪᔄᔜᔰᔱᔬᔃᓨᔡᔔᔵᔴᔝᔓᔏᔮᓫᓼᔑᔴᓳᓯᓪᔱᔤᔠᔲᓺᔰᔮᔫᓸᔮᔣᔜᔭᔤᔩᔢ";
					}
					if (text5 == null || text5 == string.Empty)
					{
						break;
					}
					try
					{
						Class11.smethod_23(Class56.string_9);
						FileInfo fileInfo = Class73.smethod_0(Class11.smethod_54(text5), text);
						if (fileInfo != null && fileInfo.Exists)
						{
							goto IL_012d;
						}
					}
					catch
					{
						goto IL_012d;
					}
				}
				break;
			}
			bool_0 = false;
			break;
		}
		while (num <= 20 && !Class11.bool_0);
	}

	public static uint[,] smethod_1(int int_2, uint[] uint_0, uint[] uint_1 = null, string string_0 = null, bool bool_2 = false)
	{
		int num = 0;
		while (bool_1 && num < 1000)
		{
			num++;
			Thread.Sleep(1);
		}
		bool_1 = true;
		uint[,] result = null;
		if (gstruct21_0 != null)
		{
			for (int i = 0; i < gstruct21_0.Length; i++)
			{
				if (int_2 == gstruct21_0[i].int_0)
				{
					result = smethod_4(gstruct21_0[i], uint_0, uint_1, string_0, bool_2);
					break;
				}
			}
		}
		bool_1 = false;
		return result;
	}

	public static int smethod_2(int int_2)
	{
		for (int i = 0; i < gstruct21_0.Length; i++)
		{
			if (int_2 == gstruct21_0[i].int_0)
			{
				return i;
			}
		}
		return -1;
	}

	public static uint[] smethod_3(GStruct21 gstruct21_1, uint[] uint_0, string string_0, bool bool_2 = false)
	{
		if (gstruct21_1.uint_0 != null && gstruct21_1.uint_0.GetLength(0) != 0)
		{
			int length = gstruct21_1.uint_0.GetLength(0);
			if (string_0 != null && string_0 != string.Empty && gstruct21_1.string_0 != null)
			{
				string[] array = string_0.ToLower().Split('|');
				int num = gstruct21_1.string_0.Length;
				long num2 = -1L;
				int num3 = -1;
				for (int i = 0; i < gstruct21_1.int_1; i++)
				{
					if (i >= num)
					{
						continue;
					}
					for (int j = 0; j < array.Length; j++)
					{
						string text = gstruct21_1.string_0[i].ToLower();
						if ((text == array[j] || (!bool_2 && 0 <= text.IndexOf(array[j]))) && i < length)
						{
							uint[] uint_1 = new uint[2]
							{
								gstruct21_1.uint_0[i, 0],
								gstruct21_1.uint_0[i, 1]
							};
							long num4 = smethod_6(uint_0, uint_1);
							if (num3 < 0 || num4 < num2)
							{
								num3 = i;
								num2 = num4;
							}
						}
					}
				}
				if (0 <= num3)
				{
					return new uint[2]
					{
						gstruct21_1.uint_0[num3, 0],
						gstruct21_1.uint_0[num3, 1]
					};
				}
			}
			return null;
		}
		return null;
	}

	public static uint[,] smethod_4(GStruct21 gstruct21_1, uint[] uint_0, uint[] uint_1 = null, string string_0 = null, bool bool_2 = false)
	{
		if (gstruct21_1.uint_0 != null && gstruct21_1.uint_0.GetLength(0) != 0)
		{
			int length = gstruct21_1.uint_0.GetLength(0);
			if ((uint_1 == null || uint_1[0] == 0 || uint_1[1] == 0) && string_0 != null && string_0 != string.Empty && gstruct21_1.string_0 != null)
			{
				string[] array = string_0.ToLower().Split('|');
				int num = gstruct21_1.string_0.Length;
				long num2 = -1L;
				int num3 = -1;
				for (int i = 0; i < gstruct21_1.int_1; i++)
				{
					if (i >= num)
					{
						continue;
					}
					for (int j = 0; j < array.Length; j++)
					{
						string text = gstruct21_1.string_0[i].ToLower();
						if ((text == array[j] || (!bool_2 && 0 <= text.IndexOf(array[j]))) && i < length)
						{
							uint[] uint_2 = new uint[2]
							{
								gstruct21_1.uint_0[i, 0],
								gstruct21_1.uint_0[i, 1]
							};
							long num4 = smethod_6(uint_0, uint_2);
							if (num3 < 0 || num4 < num2)
							{
								num3 = i;
								num2 = num4;
							}
						}
					}
				}
				if (0 <= num3)
				{
					uint_1 = new uint[2]
					{
						gstruct21_1.uint_0[num3, 0],
						gstruct21_1.uint_0[num3, 1]
					};
				}
			}
			if (uint_1 != null && uint_1[0] != 0 && uint_1[1] != 0)
			{
				int num5 = -1;
				int num6 = -1;
				long num7 = -1L;
				long num8 = -1L;
				for (int k = 0; k < length; k++)
				{
					uint[] uint_3 = new uint[2]
					{
						gstruct21_1.uint_0[k, 0],
						gstruct21_1.uint_0[k, 1]
					};
					long num9 = smethod_6(uint_0, uint_3);
					long num10 = smethod_6(uint_1, uint_3);
					if (num5 < 0 || num9 < num7)
					{
						num5 = k;
						num7 = num9;
					}
					if (num6 < 0 || num10 < num8)
					{
						num6 = k;
						num8 = num10;
					}
				}
				if (num5 == num6)
				{
					return null;
				}
				int[] array2 = smethod_5(gstruct21_1.int_4, num5, num6);
				if (array2 != null && array2.Length != 0)
				{
					uint[,] array3 = new uint[array2.Length, 2];
					for (int l = 0; l < array2.Length; l++)
					{
						array3[l, 0] = gstruct21_1.uint_0[array2[l], 0];
						array3[l, 1] = gstruct21_1.uint_0[array2[l], 1];
					}
					return array3;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public static int[] smethod_5(int[,] int_2, int int_3, int int_4)
	{
		if (int_2 == null)
		{
			return null;
		}
		int length = int_2.GetLength(0);
		if (int_3 >= 0 && length > int_3 && int_4 >= 0 && length > int_4)
		{
			if (int_3 == int_4)
			{
				return new int[1] { int_3 };
			}
			int num = 599999999;
			int[] array = new int[length];
			int[] array2 = new int[length];
			int[] array3 = new int[length];
			byte[] array4 = new byte[length];
			array[int_3] = 0;
			array2[int_3] = 0;
			int num2 = int_3;
			int num3 = 0;
			while (num2 != int_4)
			{
				num3 = -1;
				int num4 = num;
				for (int i = 0; i < length; i++)
				{
					if (array4[i] == 0)
					{
						array[i] = -1;
						array2[i] = num;
						array3[i] = 0;
						array4[i] = 1;
					}
					if (array3[i] == 0)
					{
						int num5 = int_2[num2, i];
						int num6 = array2[num2] + num5;
						if (num2 == 0)
						{
							num6 = num5;
						}
						if (num5 > 0 && array2[i] > num6)
						{
							array2[i] = num6;
							array[i] = num2;
						}
						if (num4 > array2[i])
						{
							num4 = array2[i];
							num3 = i;
						}
					}
				}
				if (num3 >= 0)
				{
					num2 = num3;
					array3[num2] = 1;
					continue;
				}
				return null;
			}
			num2 = 0;
			num3 = int_4;
			int[] array5 = new int[length];
			while (num3 != int_3)
			{
				if (num2 > 0)
				{
					num3 = array[num3];
				}
				array5[num2] = num3;
				num2++;
			}
			int[] array6 = new int[num2];
			for (int j = 0; j < num2; j++)
			{
				array6[j] = array5[num2 - j - 1];
			}
			return array6;
		}
		return null;
	}

	public static long smethod_6(uint[] uint_0, uint[] uint_1)
	{
		if (uint_0 != null && uint_1 != null && uint_0[0] != 0 && uint_0[1] != 0 && uint_1[0] != 0 && uint_1[1] != 0)
		{
			long num = (int)(uint_0[0] - uint_1[0]);
			long num2 = (int)(uint_0[1] - uint_1[1]);
			long num3 = num * num + num2 * num2;
			if (num3 == 0L)
			{
				num3 = 1L;
			}
			return (uint)num3;
		}
		return 2147483647L;
	}

	private static int smethod_7(string string_0)
	{
		if (string_0 != null && !(string_0 == string.Empty))
		{
			string[] array = string_0.Split(' ', ',', '=', '\t');
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] != null && array[i] != string.Empty)
				{
					return Class11.smethod_11(array[i]);
				}
			}
			return 0;
		}
		return 0;
	}

	private static uint[] smethod_8(string string_0)
	{
		if (string_0 != null && !(string_0 == string.Empty))
		{
			string[] array = string_0.Split(' ', ',', '=', '\t');
			uint[] array2 = new uint[2];
			int num = 0;
			int num2 = 1;
			while (true)
			{
				if (num2 < array.Length)
				{
					if (array[num2] != string.Empty && array[num2] != null)
					{
						array2[num] = Class11.smethod_12(array[num2]);
						if (1 <= num)
						{
							break;
						}
						num++;
					}
					num2++;
					continue;
				}
				return null;
			}
			return array2;
		}
		return null;
	}

	public static GStruct21 smethod_9(string string_0, int int_2 = 0, string string_1 = null)
	{
		GStruct21 result = new GStruct21
		{
			int_4 = null
		};
		if (string_0 != null && !(string_0 == string.Empty))
		{
			string[] array = string_0.Replace("\r\n", "\n").Split('\r', '\n');
			int num = 0;
			int num2 = -1;
			int num3 = 0;
			result.int_1 = 0;
			result.uint_0 = new uint[array.Length, 2];
			result.string_0 = new string[array.Length];
			result.int_3 = new int[array.Length, 3];
			result.string_1 = string_1;
			result.int_0 = int_2;
			char[] array2 = new char[3] { ' ', ',', '\t' };
			while (num2 < array.Length - 1)
			{
				num2++;
				string_0 = array[num2];
				if (string_0 == null || string_0.Length < 2 || (string_0[0] == '/' && string_0[1] == '/'))
				{
					continue;
				}
				if (string_0 == "0 0" || string_0 == "0,0")
				{
					num3++;
				}
				switch (num3)
				{
				default:
				{
					int num7 = -1;
					for (int i = 0; i < array2.Length; i++)
					{
						int num8 = string_0.IndexOf(array2[i]);
						if (0 <= num8 && (num7 < 0 || num8 < num7))
						{
							num7 = num8;
						}
					}
					if (num7 < 0)
					{
						continue;
					}
					string text = string_0.Substring(0, num7);
					switch (text.ToUpper())
					{
					case "RATIOOUT":
						result.int_6 = smethod_7(string_0);
						continue;
					case "MAPID":
						result.int_0 = smethod_7(string_0);
						continue;
					case "RATIOIN":
						result.int_5 = smethod_7(string_0);
						continue;
					case "POSOUT":
						result.uint_2 = smethod_8(string_0);
						continue;
					case "POSIN":
						result.uint_1 = smethod_8(string_0);
						continue;
					}
					uint num9 = Class11.smethod_12(text);
					uint num10 = 0u;
					string text2 = string.Empty;
					do
					{
						string_0 = string_0.Substring(num7 + 1);
						num7 = -1;
						for (int j = 0; j < array2.Length; j++)
						{
							int num11 = string_0.IndexOf(array2[j]);
							if (0 <= num11 && (num7 < 0 || num11 < num7))
							{
								num7 = num11;
							}
						}
					}
					while (num7 == 0);
					if (num7 > 0)
					{
						string string_2 = string_0.Substring(0, num7);
						num10 = Class11.smethod_12(string_2);
						if (num7 + 1 < string_0.Length)
						{
							text2 = string_0.Substring(num7 + 1);
						}
					}
					if (num9 != 0 && num10 != 0)
					{
						result.uint_0[result.int_1, 0] = num9;
						result.uint_0[result.int_1, 1] = num10;
						result.string_0[result.int_1] = text2;
						result.int_1++;
					}
					continue;
				}
				case 1:
				{
					string[] array3 = string_0.Split(' ', ',');
					if (array3.Length < 2 || (array3[0] == "0" && array3[1] == "0"))
					{
						continue;
					}
					int num4 = Class11.smethod_11(array3[0]);
					int num5 = Class11.smethod_11(array3[1]);
					int num6 = -1;
					if (result.int_1 > num4 && result.int_1 > num5)
					{
						if (array3.Length < 3)
						{
							uint[] uint_ = new uint[2]
							{
								result.uint_0[num4, 0],
								result.uint_0[num4, 1]
							};
							uint[] uint_2 = new uint[2]
							{
								result.uint_0[num5, 0],
								result.uint_0[num5, 1]
							};
							num6 = (int)Math.Sqrt(smethod_6(uint_, uint_2));
						}
						else
						{
							num6 = Class11.smethod_11(array3[2]);
						}
						if (0 <= num4 && num4 != num5 && num6 > 0)
						{
							result.int_3[num, 0] = num4;
							result.int_3[num, 1] = num5;
							result.int_3[num, 2] = num6;
							num++;
						}
					}
					continue;
				}
				case 2:
					break;
				}
				break;
			}
			if (result.int_1 != 0 && num != 0)
			{
				result.int_4 = new int[result.int_1, result.int_1];
				for (int k = 0; k < result.int_1; k++)
				{
					for (int l = 0; l < result.int_1; l++)
					{
						if (k != l)
						{
							result.int_4[k, l] = -1;
						}
					}
				}
				for (int m = 0; m < num; m++)
				{
					int num12 = result.int_3[m, 0];
					int num13 = result.int_3[m, 1];
					int num14 = result.int_3[m, 2];
					if (num12 < result.int_1 && num13 < result.int_1)
					{
						result.int_4[num12, num13] = num14;
						result.int_4[num13, num12] = num14;
					}
				}
				return result;
			}
			return result;
		}
		return result;
	}
}
