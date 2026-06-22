using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns23;
using ns35;
using ns44;
using ns53;
using ns69;
using ns71;
using ns79;

namespace ns132;

public class FormTangdiem : Form
{
	private struct Struct15
	{
		public int[] int_0;

		public string[] string_0;
	}

	public static bool bool_0 = false;

	public int int_0 = 0;

	public int int_1 = 0;

	public int int_2;

	public int int_3;

	private static string[] string_0 = new string[4] { "Sức mạnh", "Thân pháp", "Sinh khí", "Nội công" };

	private static string[,] string_1 = new string[10, 2]
	{
		{ "Thiếu Lâm", "THIEULAM" },
		{ "Thiên Vương", "THIENVUONG" },
		{ "Đường Môn", "DUONGMON" },
		{ "Ngũ Độc", "NGUDOC" },
		{ "Nga My", "NGAMY" },
		{ "Thúy Yên", "THUYYEN" },
		{ "Cái Bang", "CAIBANG" },
		{ "Thiên Nhẫn", "THIENNHAN" },
		{ "Võ Đang", "VODANG" },
		{ "Côn Lôn", "CONLON" }
	};

	private static Struct15[] struct15_0 = null;

	private static string string_2 = "TANGDIEM\\Tangdiem.txt";

	private static int int_4 = 0;

	private static GStruct58[] gstruct58_0 = null;

	private static bool bool_1 = false;

	private static int int_5 = 0;

	private static int int_6 = -1;

	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private ListView listViewMonPhai;

	private ColumnHeader columnHeader_0;

	private Label label1;

	private ListView listViewTiemNang;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private ListView listViewKyNang;

	private ColumnHeader columnHeader_3;

	private ColumnHeader columnHeader_4;

	private TextBox textBoxTiemNang;

	private Button buttonDocLuu;

	private Button buttonLuu;

	private Button buttonTangdiem;

	private Button buttonTangAll;

	private Button buttonClose;

	private TextBox textBoxKyNang;

	private ComboBox comboBoxAc;

	private Button buttonLen;

	private Button buttonXuong;

	private Label label3;

	private Label labelTong;

	private Button buttonXoaAll;

	private Button buttonStop;

	private Button buttonReFresh;

	public FormTangdiem()
	{
		bool_0 = true;
		new Thread(smethod_2).Start();
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	private static void smethod_0(Struct15[] struct15_1, string string_3 = null)
	{
		if (struct15_1 == null)
		{
			struct15_1 = new Struct15[10];
		}
		string text = null;
		for (int i = 0; i < struct15_1.Length; i++)
		{
			int[] array = struct15_1[i].int_0;
			if (array == null)
			{
				array = new int[4];
			}
			string text2 = null;
			for (int j = 0; j < array.Length; j++)
			{
				if (text2 != null && text2 != string.Empty)
				{
					text2 += ";";
				}
				text2 += array[j];
			}
			if (text != null && text != string.Empty)
			{
				text += "\r\n";
			}
			object obj = text;
			text = string.Concat(obj, i, "=", text2);
		}
		if (string_3 == null || string_3 == string.Empty)
		{
			string_3 = Class56.string_8 + "\\" + string_2;
		}
		string[] array2 = Class11.smethod_14(string_3);
		Class11.smethod_23(array2[0]);
		Class11.smethod_34(string_3, text, 1);
	}

	private static Struct15[] smethod_1(string string_3 = null, bool bool_2 = false)
	{
		if (string_3 == null || string_3 == string.Empty)
		{
			string_3 = Class56.string_8 + "\\" + string_2;
		}
		int num = 10;
		Struct15[] array = new Struct15[10];
		array[0].int_0 = new int[38]
		{
			0, 0, 0, 2, 0, 0, 1, 0, 0, 3,
			0, 0, 10, 0, 14, 0, 8, 0, 4, 0,
			6, 0, 15, 0, 16, 0, 20, 0, 271, 0,
			11, 0, 19, 0, 273, 0, 21, 0
		};
		array[1].int_0 = new int[44]
		{
			0, 0, 0, 2, 0, 0, 1, 0, 0, 3,
			0, 0, 29, 0, 34, 0, 30, 0, 26, 0,
			23, 0, 24, 0, 33, 0, 37, 0, 35, 0,
			31, 0, 40, 0, 42, 0, 32, 0, 36, 0,
			41, 0, 324, 0
		};
		array[2].int_0 = new int[44]
		{
			0, 0, 0, 2, 0, 0, 1, 0, 0, 3,
			0, 0, 45, 0, 43, 0, 347, 0, 303, 0,
			50, 0, 54, 0, 47, 0, 343, 0, 345, 0,
			349, 0, 249, 0, 48, 0, 58, 0, 341, 0,
			351, 0, 1110, 0
		};
		array[3].int_0 = new int[48]
		{
			0, 0, 0, 2, 0, 0, 1, 0, 0, 3,
			0, 0, 63, 0, 65, 0, 62, 0, 60, 0,
			67, 0, 70, 0, 66, 0, 68, 0, 384, 0,
			64, 0, 69, 0, 356, 0, 73, 0, 72, 0,
			71, 0, 75, 0, 74, 0, 390, 0
		};
		array[4].int_0 = new int[44]
		{
			0, 0, 0, 2, 0, 0, 1, 0, 0, 3,
			0, 0, 80, 0, 101, 0, 85, 0, 77, 0,
			79, 0, 93, 0, 385, 0, 82, 0, 89, 0,
			86, 0, 92, 0, 88, 0, 252, 0, 91, 0,
			282, 0, 332, 0
		};
		array[5].int_0 = new int[36]
		{
			0, 0, 0, 2, 0, 0, 1, 0, 0, 3,
			0, 0, 99, 0, 102, 0, 95, 0, 97, 0,
			269, 0, 105, 0, 113, 0, 100, 0, 109, 0,
			108, 0, 114, 0, 111, 0
		};
		array[6].int_0 = new int[38]
		{
			0, 0, 0, 2, 0, 0, 1, 0, 0, 3,
			0, 0, 117, 0, 122, 0, 119, 0, 116, 0,
			115, 0, 129, 0, 274, 0, 124, 0, 277, 0,
			128, 0, 125, 0, 130, 0, 360, 0
		};
		array[7].int_0 = new int[42]
		{
			0, 0, 0, 2, 0, 0, 1, 0, 0, 3,
			0, 0, 135, 0, 145, 0, 132, 0, 131, 0,
			136, 0, 137, 0, 141, 0, 138, 0, 140, 0,
			364, 0, 143, 0, 142, 0, 150, 0, 148, 0,
			391, 0
		};
		array[8].int_0 = new int[36]
		{
			0, 0, 0, 2, 0, 0, 1, 0, 0, 3,
			0, 0, 153, 0, 155, 0, 152, 0, 151, 0,
			159, 0, 164, 0, 158, 0, 160, 0, 157, 0,
			165, 0, 166, 0, 267, 0
		};
		array[9].int_0 = new int[50]
		{
			0, 0, 0, 2, 0, 0, 1, 0, 0, 3,
			0, 0, 169, 0, 179, 0, 167, 0, 168, 0,
			392, 0, 171, 0, 174, 0, 178, 0, 172, 0,
			393, 0, 173, 0, 175, 0, 181, 0, 176, 0,
			90, 0, 275, 0, 182, 0, 630, 0, 394, 0
		};
		Struct15[] array2 = new Struct15[10];
		string text = Class11.smethod_33(string_3, 0, 0, 1);
		if (!bool_2 && text != null && !(text == string.Empty))
		{
			int[] array3 = new int[num];
			string[] array4 = text.Split('\r', '\n');
			int num2 = 0;
			while (true)
			{
				if (num2 < array4.Length)
				{
					if (array4[num2] != null && !(array4[num2] == string.Empty))
					{
						string[] array5 = array4[num2].Split('=');
						if (array5.Length == 2)
						{
							int num3 = Class11.smethod_11(array5[0].Trim());
							if (num3 >= 0 && num > num3)
							{
								string[] array6 = array5[1].Trim().Split(';', ',');
								if (array6.Length != array[num3].int_0.Length)
								{
									break;
								}
								array2[num3].int_0 = new int[array6.Length];
								for (int i = 0; i < array6.Length; i++)
								{
									array2[num3].int_0[i] = Class11.smethod_11(array6[i].Trim());
								}
								array3[num3] = 1;
							}
						}
					}
					num2++;
					continue;
				}
				num2 = 0;
				while (true)
				{
					if (num2 < array.Length)
					{
						if (array2[num2].int_0 == null || array2[num2].int_0.Length != array[num2].int_0.Length || array3[num2] == 0)
						{
							break;
						}
						num2++;
						continue;
					}
					return array2;
				}
				break;
			}
		}
		array2 = new Struct15[array.Length];
		for (int j = 0; j < array.Length; j++)
		{
			if (array[j].int_0 != null)
			{
				array2[j].int_0 = new int[array[j].int_0.Length];
				for (int k = 0; k < array[j].int_0.Length; k++)
				{
					array2[j].int_0[k] = array[j].int_0[k];
				}
			}
		}
		return array2;
	}

	private void method_0()
	{
		int num = int_4;
		int_4 = 0;
		try
		{
			method_1(num);
		}
		catch
		{
			int int_ = 0;
			byte[] byte_ = new byte[4];
			if (Form1.characterAccountConfig_1 == null)
			{
				return;
			}
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				if (num == Form1.characterAccountConfig_1[i].int_136)
				{
					Class24.WriteProcessMemory(Form1.characterAccountConfig_1[i].int_137, Form1.characterAccountConfig_1[i].uint_16 + Class75.uint_40 * 4, byte_, 1, ref int_);
					break;
				}
			}
		}
	}

	private void method_1(int int_7)
	{
		if (int_7 == 0 || struct15_0 == null)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				if (int_7 == Form1.characterAccountConfig_1[i].int_136)
				{
					characterAccountConfig_ = Form1.characterAccountConfig_1[i];
					break;
				}
			}
		}
		int int_8 = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_16 + Class75.uint_40 * 4, array, 1, ref int_8);
		if (array[0] > 0)
		{
			return;
		}
		array[0] = 1;
		Class24.WriteProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_16 + Class75.uint_40 * 4, array, 1, ref int_8);
		Class75.smethod_52(characterAccountConfig_, "<bclr=blue><color=green>* B¾t ®Çu t\u00a8ng ®iÓm tiÒm n\u00a8ng vµ kü n\u00a8ng");
		bool flag = false;
		string text = Class83.smethod_18(characterAccountConfig_);
		int num = -1;
		if (text != null && text != string.Empty)
		{
			for (int j = 0; j < string_1.GetLength(0); j++)
			{
				if (text == string_1[j, 1])
				{
					num = j;
					break;
				}
			}
		}
		if (num >= 0)
		{
			int[] array2 = null;
			int[] array3 = null;
			for (int k = 0; k < 4; k++)
			{
				if (struct15_0[num].int_0[k * 3 + 1] != 0)
				{
					if (array2 == null)
					{
						array2 = new int[1];
						array3 = new int[1];
					}
					else
					{
						Array.Resize(ref array2, array2.Length + 1);
						Array.Resize(ref array3, array3.Length + 1);
					}
					array2[array2.Length - 1] = struct15_0[num].int_0[k * 3];
					array3[array3.Length - 1] = struct15_0[num].int_0[k * 3 + 2];
				}
			}
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			while (true)
			{
				Thread.Sleep(100);
				if (Class11.bool_0 || Class24.smethod_52(characterAccountConfig_.process_0) || num < 0)
				{
					break;
				}
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_16 + Class75.uint_40 * 4, array, 1, ref int_8);
				if (array[0] == 0)
				{
					break;
				}
				if (!flag && array2 != null && array2.Length > num2)
				{
					int num7 = Class38.smethod_44(characterAccountConfig_);
					if (num7 != 0)
					{
						int num8 = array2[num2];
						int num9 = Class38.smethod_43(characterAccountConfig_, num8)[1];
						if (num9 <= array3[num2])
						{
							int num10 = array3[num2] - num9;
							if (num10 > 233)
							{
								num10 = 233;
							}
							if (num10 > num7)
							{
								num10 = num7;
							}
							if (num10 > 0)
							{
								Class24.ReadProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, array, 4, ref int_8);
								if (BitConverter.ToUInt32(array, 0) != 0)
								{
									Class24.smethod_4(characterAccountConfig_.uint_4, 13u);
									Thread.Sleep(100);
								}
								if (Class75.smethod_107(characterAccountConfig_, num8))
								{
									num4 = 0;
									int l;
									for (l = 0; l < 100; l++)
									{
										Class24.ReadProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, array, 4, ref int_8);
										if (BitConverter.ToUInt32(array, 0) == 0)
										{
											Thread.Sleep(10);
											continue;
										}
										l = -1;
										break;
									}
									if (l < 0)
									{
										Class47.smethod_5(characterAccountConfig_, num10.ToString(), bool_0: true);
										for (l = 0; l < 100; l++)
										{
											int num11 = Class38.smethod_43(characterAccountConfig_, num8)[1];
											if (num11 <= num9)
											{
												Thread.Sleep(10);
												continue;
											}
											l = -1;
											break;
										}
										if (l < 0)
										{
											continue;
										}
									}
									if (num5 < 3)
									{
										num5++;
										Thread.Sleep(800);
										continue;
									}
								}
								else if (num4 < 3)
								{
									Thread.Sleep(800);
									num4++;
									continue;
								}
							}
						}
						num2++;
						num4 = 0;
						num5 = 0;
						continue;
					}
					flag = true;
				}
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_8);
				uint uint_ = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_71.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, uint_, array, 4, ref int_8);
				int num12 = BitConverter.ToInt32(array, 0);
				if (num12 <= 0)
				{
					break;
				}
				int num13 = -1;
				int num14;
				for (num14 = 12 + num3; num14 < struct15_0[num].int_0.Length - 1; num14++)
				{
					if (struct15_0[num].int_0[num14] > 0 && struct15_0[num].int_0[num14 + 1] > 0)
					{
						int num15 = Class83.smethod_16(characterAccountConfig_, struct15_0[num].int_0[num14]);
						if (struct15_0[num].int_0[num14 + 1] > num15)
						{
							num3 = num14 - 12;
							num13 = num14;
							break;
						}
					}
					num14++;
				}
				if (num13 < 0)
				{
					break;
				}
				int num16 = struct15_0[num].int_0[num13];
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_8);
				uint num17 = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num17 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_8);
				uint num18 = BitConverter.ToUInt32(array, 0) * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_8);
				uint num19 = BitConverter.ToUInt32(array, 0);
				uint num20 = num18 + num19 + Class56.memorySignatureScanConfig_161.uint_0 + Class56.memorySignatureScanConfig_162.uint_0;
				int num21 = 0;
				int num22 = -1;
				while (num21 < 80)
				{
					num21++;
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num20, array, 4, ref int_8);
					if (BitConverter.ToUInt32(array, 0) != num16)
					{
						num20 += Class56.memorySignatureScanConfig_163.uint_0;
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num20 + 4, array, 4, ref int_8);
					num22 = BitConverter.ToInt32(array, 0);
					break;
				}
				int num23 = struct15_0[num].int_0[num13 + 1] - num22;
				if (num22 >= 0 && num23 > 0)
				{
					if (num23 > num12)
					{
						num23 = num12;
					}
					if (num23 + num22 > 20)
					{
						num23 = 20 - num22;
					}
					if (num23 <= 0)
					{
						num23 = 1;
					}
					Class75.smethod_52(characterAccountConfig_, "<color=green>-> " + num23 + " ®iÓm: " + Class1.smethod_2(smethod_3(num16).string_0));
					Thread.Sleep(10);
					byte[] byte_ = new byte[1] { (byte)num23 };
					byte[] bytes = BitConverter.GetBytes(num16);
					Class24.WriteProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_42 + 15, bytes, 4, ref int_8);
					Class24.WriteProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_42 + 36, byte_, 1, ref int_8);
					Class75.smethod_12(characterAccountConfig_.int_137, characterAccountConfig_.uint_42);
					for (int m = 0; m < 50; m++)
					{
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num20 + 4, array, 4, ref int_8);
						int num24 = BitConverter.ToInt32(array, 0);
						if (num24 <= num22)
						{
							Thread.Sleep(10);
							continue;
						}
						m = -1;
						break;
					}
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, num20 + 4, array, 4, ref int_8);
					int num25 = BitConverter.ToInt32(array, 0);
					if (struct15_0[num].int_0[num13 + 1] > num25)
					{
						if (num25 > num22)
						{
							num6 = 0;
							continue;
						}
						if (num6 < 2)
						{
							num6++;
							continue;
						}
					}
				}
				num3++;
				num6 = 0;
			}
		}
		array[0] = 0;
		Class24.WriteProcessMemory(characterAccountConfig_.int_137, characterAccountConfig_.uint_16 + Class75.uint_40 * 4, array, 1, ref int_8);
		Class75.smethod_52(characterAccountConfig_, "<bclr=blue><color=green>* KÕt thóc t\u00a8ng ®iÓm");
	}

	private static void smethod_2()
	{
		if (bool_1)
		{
			return;
		}
		bool_1 = true;
		int num = 0;
		string string_ = Class56.string_9 + "\\tbSkill.txt";
		while (true)
		{
			IL_014b:
			string text = Class11.smethod_33(string_, 0, 0, 1);
			if (text != null && !(text == string.Empty))
			{
				while (text != null && text != string.Empty && (text[0] == '\r' || text[0] == '\n'))
				{
					text = text.Substring(1);
				}
				if (text != null && !(text == string.Empty))
				{
					string[] array = text.Replace("\r\n", "\n").Trim().Split('\n');
					if (array[0] != null && !(array[0] == string.Empty) && array[0].IndexOf("=") >= 0)
					{
						int num2 = 0;
						gstruct58_0 = new GStruct58[array.Length];
						string[] array2 = array;
						foreach (string text2 in array2)
						{
							if (text2 != null && !(text2 == string.Empty))
							{
								int num3 = text2.IndexOf("=");
								if (num3 >= 0)
								{
									string string_2 = text2.Substring(0, num3);
									string text3 = text2.Substring(num3 + 1);
									gstruct58_0[num2].int_1 = Class11.smethod_11(string_2);
									gstruct58_0[num2].string_0 = text3;
									num2++;
								}
							}
						}
						if (num2 != 0)
						{
							if (num2 < gstruct58_0.Length)
							{
								Array.Resize(ref gstruct58_0, num2);
							}
						}
						else
						{
							gstruct58_0 = null;
						}
						break;
					}
				}
			}
			while (true)
			{
				num++;
				string text4 = null;
				if (num != 1)
				{
					if (num == 2)
					{
						text4 = "ᓹᔅᔅᔁᓋᓀᓀᓼᓺᓾᔊᓶᓿᒿᓿᓶᔅᓀᔆᔁᓽᔀᓲᓵᓀᔅᓾᔁᓀᔅᓳᓤᓼᓺᓽᓽᒿᔅᔉᔅ";
					}
				}
				else
				{
					text4 = "ᔣᔯᔯᔫᔮᓵᓪᓪᔟᔭᔤᔱᔠᓩᔢᔪᔪᔢᔧᔠᓩᔞᔪᔨᓪᔡᔤᔧᔠᓪᔟᓪᓬᔚᔉᔆᔵᔢᔆᓫᔂᔝᔆᓮᔄᔂᓨᓫᔦᔱᔜᔎᔩᔁᔕᔎᔓᔉᓱᔧᔪᔱᔠᔂᔐᓪᔱᔤᔠᔲᓺᔰᔮᔫᓸᔮᔣᔜᔭᔤᔩᔢ";
				}
				if (text4 == null || text4 == string.Empty)
				{
					break;
				}
				try
				{
					Class11.smethod_23(Class56.string_9);
					FileInfo fileInfo = Class73.smethod_0(Class11.smethod_54(text4), string_);
					if (fileInfo != null && fileInfo.Exists)
					{
						goto IL_014b;
					}
				}
				catch
				{
					goto IL_014b;
				}
			}
			break;
		}
		bool_1 = false;
	}

	private static GStruct58 smethod_3(int int_7)
	{
		if (gstruct58_0 != null)
		{
			for (int i = 0; i < gstruct58_0.Length; i++)
			{
				if (int_7 == gstruct58_0[i].int_1)
				{
					return gstruct58_0[i];
				}
			}
		}
		return new GStruct58
		{
			int_1 = -1,
			string_0 = string.Empty
		};
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		smethod_0(struct15_0);
		bool_0 = false;
	}

	private void FormTangdiem_Load(object sender, EventArgs e)
	{
		try
		{
			if (int_0 > 0 && int_1 > 0)
			{
				int num = int_0 - base.Width - 2;
				int num2 = int_1 + int_3 - base.Height;
				if (num < 0)
				{
					num = 0;
				}
				if (num2 < 0)
				{
					num2 = 0;
				}
				SetBounds(num, num2, base.Width, base.Height);
			}
			method_3();
			Color color = Color.DarkRed;
			for (int i = 0; i < string_1.GetLength(0); i++)
			{
				listViewMonPhai.Items.Add(string_1[i, 0]);
				if (i % 2 == 0)
				{
					color = ((color != Color.DarkRed) ? Color.DarkRed : Color.DarkBlue);
				}
				listViewMonPhai.Items[listViewMonPhai.Items.Count - 1].ForeColor = color;
			}
			listViewMonPhai.Items[0].Selected = true;
			int_5 = 0;
			int_6 = -1;
			timer_0.Interval = 100;
			timer_0.Enabled = true;
			base.TopMost = true;
		}
		catch
		{
		}
	}

	private void method_2(ListView listView_0, string[] string_3)
	{
		try
		{
			ListViewItem listViewItem = new ListViewItem(string_3[0]);
			for (int i = 1; i < string_3.Length; i++)
			{
				ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, string_3[i]);
				listViewItem.SubItems.Add(item);
			}
			listView_0.Items.Add(listViewItem);
		}
		catch
		{
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (int_6 != int_5 && gstruct58_0 != null && !bool_1)
			{
				int_6 = int_5;
				method_4();
				method_5();
				labelTong.Text = method_6();
			}
		}
		else
		{
			Close();
		}
	}

	private void method_3()
	{
		comboBoxAc.Items.Clear();
		string text = string.Empty;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				string text2 = Class1.smethod_1(Class83.smethod_18(Form1.characterAccountConfig_1[i], Class83.smethod_18(Form1.characterAccountConfig_1[i])), 1);
				string text3 = Class1.smethod_1(Form1.characterAccountConfig_1[i].string_22, 1) + " ( " + text2 + ")";
				if (text == string.Empty)
				{
					text = text3;
				}
				comboBoxAc.Items.Add(text3);
			}
		}
		if (text != null && text != string.Empty)
		{
			comboBoxAc.Text = text;
		}
	}

	private void method_4()
	{
		if (listViewMonPhai.SelectedIndices.Count <= 0)
		{
			return;
		}
		int num = listViewMonPhai.SelectedIndices[0];
		if (struct15_0 == null)
		{
			struct15_0 = smethod_1();
		}
		if (listViewTiemNang.Items.Count > 0)
		{
			listViewTiemNang.Items.Clear();
		}
		for (int i = 0; i < string_0.Length; i++)
		{
			int num2 = struct15_0[num].int_0[i * 3];
			int num3 = struct15_0[num].int_0[i * 3 + 2];
			method_2(listViewTiemNang, new string[2]
			{
				string_0[num2],
				num3.ToString()
			});
		}
		for (int j = 0; j < string_0.Length; j++)
		{
			if (j < listViewTiemNang.Items.Count)
			{
				int num4 = struct15_0[num].int_0[j * 3 + 1];
				if (num4 > 0)
				{
					listViewTiemNang.Items[j].Checked = true;
				}
			}
		}
	}

	private void method_5()
	{
		if (listViewMonPhai.SelectedIndices.Count <= 0)
		{
			return;
		}
		int num = listViewMonPhai.SelectedIndices[0];
		if (struct15_0 == null)
		{
			struct15_0 = smethod_1();
		}
		if (listViewKyNang.Items.Count > 0)
		{
			listViewKyNang.Items.Clear();
		}
		int num2 = 12;
		int num3 = struct15_0[num].int_0.Length;
		if (struct15_0[num].string_0 == null)
		{
			struct15_0[num].string_0 = new string[num3];
		}
		int num4;
		for (num4 = num2; num4 < num3; num4++)
		{
			int int_ = struct15_0[num].int_0[num4];
			int num5 = struct15_0[num].int_0[num4 + 1];
			if (struct15_0[num].string_0[num4] == null || struct15_0[num].string_0[num4] == string.Empty)
			{
				struct15_0[num].string_0[num4] = smethod_3(int_).string_0;
			}
			method_2(listViewKyNang, new string[3]
			{
				struct15_0[num].string_0[num4],
				num5.ToString(),
				int_.ToString()
			});
			num4++;
		}
	}

	private string method_6()
	{
		int num = 0;
		for (int i = 0; i < listViewKyNang.Items.Count; i++)
		{
			int num2 = Class11.smethod_11(listViewKyNang.Items[i].SubItems[1].Text);
			num += num2;
		}
		return num.ToString();
	}

	private void listViewMonPhai_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (listViewMonPhai.SelectedIndices.Count > 0)
		{
			int_5 = listViewMonPhai.SelectedIndices[0];
		}
	}

	private void listViewTiemNang_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (listViewMonPhai.SelectedIndices.Count > 0)
		{
			int num = listViewMonPhai.SelectedIndices[0];
			int index = e.Index;
			struct15_0[num].int_0[index * 3 + 1] = Convert.ToByte(e.NewValue == CheckState.Checked);
		}
	}

	private void listViewTiemNang_MouseUp(object sender, MouseEventArgs e)
	{
		if (listViewTiemNang.SelectedIndices.Count > 0)
		{
			int index = listViewTiemNang.SelectedIndices[0];
			textBoxTiemNang.Text = listViewTiemNang.Items[index].SubItems[1].Text;
		}
	}

	private void listViewKyNang_MouseUp(object sender, MouseEventArgs e)
	{
		if (listViewKyNang.SelectedIndices.Count > 0)
		{
			int index = listViewKyNang.SelectedIndices[0];
			textBoxKyNang.Text = listViewKyNang.Items[index].SubItems[1].Text;
		}
	}

	private void buttonLen_Click(object sender, EventArgs e)
	{
		if (listViewMonPhai.SelectedIndices.Count <= 0 || listViewTiemNang.SelectedIndices.Count <= 0)
		{
			return;
		}
		int num = listViewTiemNang.SelectedIndices[0];
		if (num > 0)
		{
			int num2 = listViewMonPhai.SelectedIndices[0];
			int[] array = new int[3]
			{
				struct15_0[num2].int_0[(num - 1) * 3],
				struct15_0[num2].int_0[(num - 1) * 3 + 1],
				struct15_0[num2].int_0[(num - 1) * 3 + 2]
			};
			struct15_0[num2].int_0[(num - 1) * 3] = struct15_0[num2].int_0[num * 3];
			struct15_0[num2].int_0[(num - 1) * 3 + 1] = struct15_0[num2].int_0[num * 3 + 1];
			struct15_0[num2].int_0[(num - 1) * 3 + 2] = struct15_0[num2].int_0[num * 3 + 2];
			struct15_0[num2].int_0[num * 3] = array[0];
			struct15_0[num2].int_0[num * 3 + 1] = array[1];
			struct15_0[num2].int_0[num * 3 + 2] = array[2];
			for (int i = 0; i < listViewTiemNang.Items[num].SubItems.Count; i++)
			{
				string text = listViewTiemNang.Items[num - 1].SubItems[i].Text;
				listViewTiemNang.Items[num - 1].SubItems[i].Text = listViewTiemNang.Items[num].SubItems[i].Text;
				listViewTiemNang.Items[num].SubItems[i].Text = text;
			}
			listViewTiemNang.Items[num - 1].Selected = true;
			listViewTiemNang.Items[num - 1].Checked = struct15_0[num2].int_0[(num - 1) * 3 + 1] > 0;
			listViewTiemNang.Items[num].Selected = false;
			listViewTiemNang.Items[num].Checked = struct15_0[num2].int_0[num * 3 + 1] > 0;
		}
	}

	private void buttonXuong_Click(object sender, EventArgs e)
	{
		if (listViewMonPhai.SelectedIndices.Count <= 0 || listViewTiemNang.SelectedIndices.Count <= 0)
		{
			return;
		}
		int num = listViewTiemNang.SelectedIndices[0];
		if (num <= 2)
		{
			int num2 = listViewMonPhai.SelectedIndices[0];
			int[] array = new int[3]
			{
				struct15_0[num2].int_0[(num + 1) * 3],
				struct15_0[num2].int_0[(num + 1) * 3 + 1],
				struct15_0[num2].int_0[(num + 1) * 3 + 2]
			};
			struct15_0[num2].int_0[(num + 1) * 3] = struct15_0[num2].int_0[num * 3];
			struct15_0[num2].int_0[(num + 1) * 3 + 1] = struct15_0[num2].int_0[num * 3 + 1];
			struct15_0[num2].int_0[(num + 1) * 3 + 2] = struct15_0[num2].int_0[num * 3 + 2];
			struct15_0[num2].int_0[num * 3] = array[0];
			struct15_0[num2].int_0[num * 3 + 1] = array[1];
			struct15_0[num2].int_0[num * 3 + 2] = array[2];
			for (int i = 0; i < listViewTiemNang.Items[num].SubItems.Count; i++)
			{
				string text = listViewTiemNang.Items[num + 1].SubItems[i].Text;
				listViewTiemNang.Items[num + 1].SubItems[i].Text = listViewTiemNang.Items[num].SubItems[i].Text;
				listViewTiemNang.Items[num].SubItems[i].Text = text;
			}
			listViewTiemNang.Items[num + 1].Selected = true;
			listViewTiemNang.Items[num + 1].Checked = struct15_0[num2].int_0[(num + 1) * 3 + 1] > 0;
			listViewTiemNang.Items[num].Selected = false;
			listViewTiemNang.Items[num].Checked = struct15_0[num2].int_0[num * 3 + 1] > 0;
		}
	}

	private void textBoxTiemNang_KeyUp(object sender, KeyEventArgs e)
	{
		if (listViewMonPhai.SelectedIndices.Count > 0 && listViewTiemNang.SelectedIndices.Count > 0)
		{
			int num = listViewTiemNang.SelectedIndices[0];
			int num2 = listViewMonPhai.SelectedIndices[0];
			struct15_0[num2].int_0[num * 3 + 2] = Class11.smethod_11(textBoxTiemNang.Text);
			listViewTiemNang.Items[num].SubItems[1].Text = struct15_0[num2].int_0[num * 3 + 2].ToString();
		}
	}

	private void textBoxKyNang_KeyUp(object sender, KeyEventArgs e)
	{
		if (listViewMonPhai.SelectedIndices.Count > 0 && listViewKyNang.SelectedIndices.Count > 0)
		{
			int num = listViewKyNang.SelectedIndices[0];
			int num2 = listViewMonPhai.SelectedIndices[0];
			struct15_0[num2].int_0[12 + num * 2 + 1] = Class11.smethod_11(textBoxKyNang.Text);
			listViewKyNang.Items[num].SubItems[1].Text = struct15_0[num2].int_0[12 + num * 2 + 1].ToString();
			labelTong.Text = method_6();
		}
	}

	private void buttonLuu_Click(object sender, EventArgs e)
	{
		string[] array = Class11.smethod_14(Class56.string_8 + "\\" + string_2);
		Class11.smethod_23(array[0]);
		string text = Class56.smethod_27(array[0], "MAU_TANG_DIEM.TXT");
		if (!(text == string.Empty))
		{
			smethod_0(struct15_0, text);
		}
	}

	private void buttonDocLuu_Click(object sender, EventArgs e)
	{
		string[] array = Class11.smethod_14(Class56.string_8 + "\\" + string_2);
		Class11.smethod_23(array[0]);
		string text = Class56.smethod_26(array[0], "", "*.TXT");
		if (!(text == string.Empty))
		{
			struct15_0 = smethod_1(text);
			listViewMonPhai.Items[0].Selected = true;
			int_5 = 0;
			int_6 = -1;
		}
	}

	private void buttonXoaAll_Click(object sender, EventArgs e)
	{
		struct15_0 = smethod_1(null, bool_2: true);
		listViewMonPhai.Items[0].Selected = true;
		int_5 = 0;
		int_6 = -1;
	}

	private void buttonTangdiem_Click(object sender, EventArgs e)
	{
		string text = comboBoxAc.Text;
		if (text == null || text == string.Empty)
		{
			return;
		}
		int num = text.IndexOf("(");
		if (num > 0)
		{
			text = text.Substring(0, num - 1);
		}
		int num2 = 0;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				if (text == Class1.smethod_1(Form1.characterAccountConfig_1[i].string_22, 1))
				{
					num2 = Form1.characterAccountConfig_1[i].int_136;
					break;
				}
			}
		}
		if (num2 > 0)
		{
			int_4 = num2;
			new Thread(method_0).Start();
		}
	}

	private void buttonTangAll_Click(object sender, EventArgs e)
	{
		try
		{
			if (Form1.characterAccountConfig_1 == null)
			{
				return;
			}
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				int num = 0;
				while (int_4 > 0 && num < 100)
				{
					Thread.Sleep(10);
					num++;
				}
				int_4 = Form1.characterAccountConfig_1[i].int_136;
				new Thread(method_0).Start();
			}
		}
		catch
		{
		}
	}

	private void buttonStop_Click(object sender, EventArgs e)
	{
		int int_ = 0;
		byte[] byte_ = new byte[1];
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Class24.WriteProcessMemory(Form1.characterAccountConfig_1[i].int_137, Form1.characterAccountConfig_1[i].uint_16 + Class75.uint_40 * 4, byte_, 1, ref int_);
			}
		}
	}

	private void buttonReFresh_Click(object sender, EventArgs e)
	{
		method_3();
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		bool_0 = false;
		Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns132.FormTangdiem));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.listViewMonPhai = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.label1 = new System.Windows.Forms.Label();
		this.listViewTiemNang = new System.Windows.Forms.ListView();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.listViewKyNang = new System.Windows.Forms.ListView();
		this.columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_4 = new System.Windows.Forms.ColumnHeader();
		this.textBoxTiemNang = new System.Windows.Forms.TextBox();
		this.buttonDocLuu = new System.Windows.Forms.Button();
		this.buttonLuu = new System.Windows.Forms.Button();
		this.buttonTangdiem = new System.Windows.Forms.Button();
		this.buttonTangAll = new System.Windows.Forms.Button();
		this.buttonClose = new System.Windows.Forms.Button();
		this.textBoxKyNang = new System.Windows.Forms.TextBox();
		this.comboBoxAc = new System.Windows.Forms.ComboBox();
		this.buttonXuong = new System.Windows.Forms.Button();
		this.buttonLen = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		this.labelTong = new System.Windows.Forms.Label();
		this.buttonXoaAll = new System.Windows.Forms.Button();
		this.buttonStop = new System.Windows.Forms.Button();
		this.buttonReFresh = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.listViewMonPhai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listViewMonPhai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_0 });
		this.listViewMonPhai.ForeColor = System.Drawing.Color.Red;
		this.listViewMonPhai.FullRowSelect = true;
		this.listViewMonPhai.GridLines = true;
		this.listViewMonPhai.HideSelection = false;
		this.listViewMonPhai.Location = new System.Drawing.Point(3, 46);
		this.listViewMonPhai.MultiSelect = false;
		this.listViewMonPhai.Name = "listViewMonPhai";
		this.listViewMonPhai.Size = new System.Drawing.Size(127, 191);
		this.listViewMonPhai.TabIndex = 4;
		this.listViewMonPhai.UseCompatibleStateImageBehavior = false;
		this.listViewMonPhai.View = System.Windows.Forms.View.Details;
		this.listViewMonPhai.SelectedIndexChanged += new System.EventHandler(listViewMonPhai_SelectedIndexChanged);
		this.columnHeader_0.Text = "Môn phái";
		this.columnHeader_0.Width = 85;
		this.label1.Location = new System.Drawing.Point(2, 4);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(201, 33);
		this.label1.TabIndex = 5;
		this.label1.Text = "Hãy thiết lập mẫu điểm cho từng môn phái, auto tự động dò để tăng theo";
		this.listViewTiemNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listViewTiemNang.CheckBoxes = true;
		this.listViewTiemNang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader_1, this.columnHeader_2 });
		this.listViewTiemNang.FullRowSelect = true;
		this.listViewTiemNang.GridLines = true;
		this.listViewTiemNang.HideSelection = false;
		this.listViewTiemNang.Location = new System.Drawing.Point(3, 239);
		this.listViewTiemNang.MultiSelect = false;
		this.listViewTiemNang.Name = "listViewTiemNang";
		this.listViewTiemNang.Size = new System.Drawing.Size(127, 93);
		this.listViewTiemNang.TabIndex = 7;
		this.listViewTiemNang.UseCompatibleStateImageBehavior = false;
		this.listViewTiemNang.View = System.Windows.Forms.View.Details;
		this.listViewTiemNang.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(listViewTiemNang_ItemCheck);
		this.listViewTiemNang.MouseUp += new System.Windows.Forms.MouseEventHandler(listViewTiemNang_MouseUp);
		this.columnHeader_1.Text = "Tiềm năng";
		this.columnHeader_1.Width = 85;
		this.columnHeader_2.Text = "Điểm";
		this.columnHeader_2.Width = 39;
		this.listViewKyNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listViewKyNang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader_3, this.columnHeader_4 });
		this.listViewKyNang.FullRowSelect = true;
		this.listViewKyNang.GridLines = true;
		this.listViewKyNang.HideSelection = false;
		this.listViewKyNang.Location = new System.Drawing.Point(136, 46);
		this.listViewKyNang.MultiSelect = false;
		this.listViewKyNang.Name = "listViewKyNang";
		this.listViewKyNang.Size = new System.Drawing.Size(274, 211);
		this.listViewKyNang.TabIndex = 8;
		this.listViewKyNang.UseCompatibleStateImageBehavior = false;
		this.listViewKyNang.View = System.Windows.Forms.View.Details;
		this.listViewKyNang.MouseUp += new System.Windows.Forms.MouseEventHandler(listViewKyNang_MouseUp);
		this.columnHeader_3.Text = "Tăng kỹ năng cho chiêu thức";
		this.columnHeader_3.Width = 200;
		this.columnHeader_4.Text = "Điểm";
		this.columnHeader_4.Width = 40;
		this.textBoxTiemNang.Location = new System.Drawing.Point(89, 338);
		this.textBoxTiemNang.Name = "textBoxTiemNang";
		this.textBoxTiemNang.Size = new System.Drawing.Size(41, 20);
		this.textBoxTiemNang.TabIndex = 9;
		this.textBoxTiemNang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBoxTiemNang.KeyUp += new System.Windows.Forms.KeyEventHandler(textBoxTiemNang_KeyUp);
		this.buttonDocLuu.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonDocLuu.Location = new System.Drawing.Point(275, 1);
		this.buttonDocLuu.Name = "buttonDocLuu";
		this.buttonDocLuu.Size = new System.Drawing.Size(60, 38);
		this.buttonDocLuu.TabIndex = 16;
		this.buttonDocLuu.Text = "Đọc mẫu";
		this.buttonDocLuu.UseVisualStyleBackColor = true;
		this.buttonDocLuu.Click += new System.EventHandler(buttonDocLuu_Click);
		this.buttonLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonLuu.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonLuu.Location = new System.Drawing.Point(207, 1);
		this.buttonLuu.Name = "buttonLuu";
		this.buttonLuu.Size = new System.Drawing.Size(65, 38);
		this.buttonLuu.TabIndex = 17;
		this.buttonLuu.Text = "Lưu mẫu";
		this.buttonLuu.UseVisualStyleBackColor = true;
		this.buttonLuu.Click += new System.EventHandler(buttonLuu_Click);
		this.buttonTangdiem.Location = new System.Drawing.Point(136, 327);
		this.buttonTangdiem.Name = "buttonTangdiem";
		this.buttonTangdiem.Size = new System.Drawing.Size(67, 38);
		this.buttonTangdiem.TabIndex = 18;
		this.buttonTangdiem.Text = "Tăng đểm ac chọn";
		this.buttonTangdiem.UseVisualStyleBackColor = true;
		this.buttonTangdiem.Click += new System.EventHandler(buttonTangdiem_Click);
		this.buttonTangAll.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonTangAll.Location = new System.Drawing.Point(207, 327);
		this.buttonTangAll.Name = "buttonTangAll";
		this.buttonTangAll.Size = new System.Drawing.Size(65, 38);
		this.buttonTangAll.TabIndex = 19;
		this.buttonTangAll.Text = "Tăng tất cả ac";
		this.buttonTangAll.UseVisualStyleBackColor = true;
		this.buttonTangAll.Click += new System.EventHandler(buttonTangAll_Click);
		this.buttonClose.Location = new System.Drawing.Point(347, 327);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(60, 38);
		this.buttonClose.TabIndex = 20;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.textBoxKyNang.Location = new System.Drawing.Point(338, 260);
		this.textBoxKyNang.Name = "textBoxKyNang";
		this.textBoxKyNang.Size = new System.Drawing.Size(40, 20);
		this.textBoxKyNang.TabIndex = 21;
		this.textBoxKyNang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBoxKyNang.KeyUp += new System.Windows.Forms.KeyEventHandler(textBoxKyNang_KeyUp);
		this.comboBoxAc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxAc.FormattingEnabled = true;
		this.comboBoxAc.Location = new System.Drawing.Point(136, 295);
		this.comboBoxAc.Name = "comboBoxAc";
		this.comboBoxAc.Size = new System.Drawing.Size(199, 21);
		this.comboBoxAc.TabIndex = 23;
		this.buttonXuong.BackColor = System.Drawing.SystemColors.Control;
		this.buttonXuong.Image = (System.Drawing.Image)resources.GetObject("buttonXuong.Image");
		this.buttonXuong.Location = new System.Drawing.Point(33, 336);
		this.buttonXuong.Name = "buttonXuong";
		this.buttonXuong.Size = new System.Drawing.Size(25, 23);
		this.buttonXuong.TabIndex = 411;
		this.buttonXuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.buttonXuong.UseVisualStyleBackColor = false;
		this.buttonXuong.Click += new System.EventHandler(buttonXuong_Click);
		this.buttonLen.BackColor = System.Drawing.SystemColors.Control;
		this.buttonLen.Image = (System.Drawing.Image)resources.GetObject("buttonLen.Image");
		this.buttonLen.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.buttonLen.Location = new System.Drawing.Point(3, 336);
		this.buttonLen.Name = "buttonLen";
		this.buttonLen.Size = new System.Drawing.Size(25, 23);
		this.buttonLen.TabIndex = 410;
		this.buttonLen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.buttonLen.UseVisualStyleBackColor = false;
		this.buttonLen.Click += new System.EventHandler(buttonLen_Click);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(135, 263);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(140, 13);
		this.label3.TabIndex = 414;
		this.label3.Text = "Tiêu tốn tổng điểm kỹ năng:";
		this.labelTong.AutoSize = true;
		this.labelTong.Location = new System.Drawing.Point(273, 263);
		this.labelTong.Name = "labelTong";
		this.labelTong.Size = new System.Drawing.Size(16, 13);
		this.labelTong.TabIndex = 415;
		this.labelTong.Text = "...";
		this.buttonXoaAll.ForeColor = System.Drawing.Color.DarkBlue;
		this.buttonXoaAll.Location = new System.Drawing.Point(340, 1);
		this.buttonXoaAll.Name = "buttonXoaAll";
		this.buttonXoaAll.Size = new System.Drawing.Size(70, 38);
		this.buttonXoaAll.TabIndex = 416;
		this.buttonXoaAll.Text = "Xóa về mặc định";
		this.buttonXoaAll.UseVisualStyleBackColor = true;
		this.buttonXoaAll.Click += new System.EventHandler(buttonXoaAll_Click);
		this.buttonStop.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonStop.Location = new System.Drawing.Point(275, 327);
		this.buttonStop.Name = "buttonStop";
		this.buttonStop.Size = new System.Drawing.Size(60, 38);
		this.buttonStop.TabIndex = 417;
		this.buttonStop.Text = "Dừng tất cả";
		this.buttonStop.UseVisualStyleBackColor = true;
		this.buttonStop.Click += new System.EventHandler(buttonStop_Click);
		this.buttonReFresh.Location = new System.Drawing.Point(340, 293);
		this.buttonReFresh.Name = "buttonReFresh";
		this.buttonReFresh.Size = new System.Drawing.Size(67, 23);
		this.buttonReFresh.TabIndex = 418;
		this.buttonReFresh.Text = "Refresh";
		this.buttonReFresh.UseVisualStyleBackColor = true;
		this.buttonReFresh.Click += new System.EventHandler(buttonReFresh_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(419, 370);
		base.Controls.Add(this.buttonReFresh);
		base.Controls.Add(this.labelTong);
		base.Controls.Add(this.buttonStop);
		base.Controls.Add(this.buttonXoaAll);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.buttonXuong);
		base.Controls.Add(this.buttonLen);
		base.Controls.Add(this.comboBoxAc);
		base.Controls.Add(this.textBoxKyNang);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.buttonTangAll);
		base.Controls.Add(this.buttonTangdiem);
		base.Controls.Add(this.buttonLuu);
		base.Controls.Add(this.buttonDocLuu);
		base.Controls.Add(this.textBoxTiemNang);
		base.Controls.Add(this.listViewTiemNang);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.listViewMonPhai);
		base.Controls.Add(this.listViewKyNang);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormTangdiem";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Tang diem";
		base.Load += new System.EventHandler(FormTangdiem_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
