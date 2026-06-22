using System.Diagnostics;
using ns11;
using ns118;
using ns23;
using ns49;
using ns53;
using ns89;

namespace ns21;

internal class Class22
{
	public static string smethod_0(string string_0)
	{
		if (string_0 != null && !(string_0 == ""))
		{
			string text = "";
			char[] array = string_0.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				text += (char)(255 - array[i]);
			}
			return text;
		}
		return "";
	}

	public static void smethod_1()
	{
		string text = string.Empty;
		if (FormLogin.gstruct0_0 != null)
		{
			for (int i = 0; i < FormLogin.gstruct0_0.Length; i++)
			{
				GStruct0 gStruct = FormLogin.gstruct0_0[i];
				string string_ = gStruct.string_0 + "\u0002" + gStruct.string_1 + "\u0002" + gStruct.int_4 + "\u0002" + gStruct.string_2 + "\u0002" + gStruct.string_3 + "\u0002" + gStruct.string_4 + "\u0002" + gStruct.string_5 + "\u0002" + gStruct.string_6 + "\u0002" + gStruct.int_3 + "\u0002None";
				string text2 = Class11.smethod_16(smethod_0(string_));
				if (text != string.Empty)
				{
					text += "\u0001";
				}
				text += text2;
			}
		}
		Class11.smethod_23(FormLogin.string_4);
		Class11.smethod_34(FormLogin.string_5, text, 1);
	}

	public static void smethod_2()
	{
		FormLogin.bool_2 = false;
		FormLogin.bool_3 = false;
		int num = 10;
		string text = Class11.smethod_33(FormLogin.string_5, 0, 0, 1);
		if (text == string.Empty)
		{
			FormLogin.bool_2 = true;
			FormLogin.bool_3 = true;
			return;
		}
		string[] array = text.Split('\u0001');
		string[,] array2 = new string[array.Length, num];
		int num2 = 0;
		for (int i = 0; i < array.Length; i++)
		{
			string text2 = Class11.smethod_15(array[i]);
			if (text2 == null || text2 == string.Empty)
			{
				continue;
			}
			string[] array3 = smethod_0(text2).Split('\u0002');
			if (array3.Length >= num)
			{
				for (int j = 0; j < num; j++)
				{
					array2[num2, j] = array3[j];
				}
				num2++;
			}
		}
		if (num2 != 0)
		{
			FormLogin.gstruct0_0 = new GStruct0[num2];
			for (int k = 0; k < num2; k++)
			{
				FormLogin.gstruct0_0[k].string_0 = array2[k, 0];
				FormLogin.gstruct0_0[k].string_1 = array2[k, 1];
				FormLogin.gstruct0_0[k].int_4 = Class11.smethod_11(array2[k, 2]);
				FormLogin.gstruct0_0[k].string_2 = array2[k, 3];
				FormLogin.gstruct0_0[k].string_3 = array2[k, 4];
				FormLogin.gstruct0_0[k].string_4 = array2[k, 5];
				FormLogin.gstruct0_0[k].string_5 = array2[k, 6];
				FormLogin.gstruct0_0[k].string_6 = array2[k, 7];
				FormLogin.gstruct0_0[k].int_3 = Class11.smethod_11(array2[k, 8]);
			}
			FormLogin.bool_2 = true;
			FormLogin.bool_3 = true;
		}
		else
		{
			FormLogin.bool_2 = true;
			FormLogin.bool_3 = true;
		}
	}

	public static void smethod_3()
	{
		if (FormLogin.gstruct0_0 == null || FormLogin.gstruct0_0.Length == 0)
		{
			return;
		}
		int[] array = Class24.smethod_24(Class56.string_21);
		if (array == null)
		{
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			try
			{
				int num = array[i];
				GStruct8[] array2 = Class24.smethod_62(num, "WIN_CLASS:Sword3 Class");
				if (array2 == null || array2.Length == 0)
				{
					continue;
				}
				uint uint_ = array2[0].uint_0;
				uint num2 = Class24.smethod_59(num);
				if (num2 == 0)
				{
					continue;
				}
				int num3 = Class24.OpenProcess(2035711, bool_0: false, num);
				if (num3 <= 0)
				{
					continue;
				}
				uint num4 = Class24.smethod_30(Class96.uint_0, num3);
				uint num5 = Class24.smethod_30(num4 + Class96.uint_2, num3) * Class96.uint_4;
				uint num6 = Class24.smethod_30(Class96.uint_3, num3);
				uint num7 = num6 + num5;
				string text = Class24.smethod_28(num7 + Class96.uint_5, num3);
				if (text != null && text.Length >= 6)
				{
					Process processById = Process.GetProcessById(num);
					int num8 = -1;
					if (FormLogin.gstruct0_0 != null)
					{
						for (int j = 0; j < FormLogin.gstruct0_0.Length; j++)
						{
							if (text == FormLogin.gstruct0_0[j].string_4)
							{
								num8 = j;
								break;
							}
						}
					}
					if (0 <= num8)
					{
						FormLogin.gstruct0_0[num8].int_1 = num;
						FormLogin.gstruct0_0[num8].int_2 = num3;
						FormLogin.gstruct0_0[num8].process_0 = processById;
						FormLogin.gstruct0_0[num8].uint_1 = num2;
						FormLogin.gstruct0_0[num8].uint_0 = uint_;
						Class52.smethod_2(ref FormLogin.gstruct0_0[num8]);
					}
				}
				else
				{
					Class24.smethod_32(num3);
				}
			}
			catch
			{
			}
		}
	}
}
