using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns109;
using ns11;
using ns13;
using ns146;
using ns19;
using ns23;
using ns28;
using ns3;
using ns34;
using ns40;
using ns41;
using ns42;
using ns43;
using ns50;
using ns53;
using ns56;
using ns6;
using ns61;
using ns63;
using ns65;
using ns68;
using ns71;
using ns83;
using ns85;
using ns86;
using ns88;
using ns94;

namespace ns121;

public class AuxiliaryMachineManager : Form
{
	public static int int_0 = 0;

	public static bool bool_0 = false;

	public static string[] string_0 = null;

	public static bool bool_1 = false;

	public static int[] int_1 = null;

	public static string string_1 = null;

	public static string string_2 = null;

	public static bool bool_2 = false;

	public static bool bool_3 = false;

	public static bool bool_4 = false;

	public static bool bool_5 = false;

	public static bool bool_6 = false;

	public static bool bool_7 = false;

	public static string string_3 = Class66.smethod_7("SMayphu", 0, "|");

	public static int int_2 = Class66.smethod_4("TocdoBaoToado", 0, "100");

	public int int_3 = 0;

	public int int_4 = 0;

	public int int_5;

	public int int_6;

	public static bool bool_8 = false;

	public static long long_0 = 0L;

	public static long long_1 = 4000L;

	private static bool bool_9 = false;

	private string[] string_4 = null;

	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ComboBox comboBoxThemAcc;

	private Button buttonThemAcc;

	private Button buttonXoaAcc;

	private System.Windows.Forms.Timer timer_0;

	private Label label1;

	private Button buttonClose;

	public AuxiliaryMachineManager()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	public static string smethod_0()
	{
		string text = string.Empty;
		string text2 = string.Empty;
		string text3 = string.Empty;
		if (Class72.string_4 != null)
		{
			for (int i = 0; i < Class72.string_4.Length; i++)
			{
				if (Class72.string_4[i] != null && !(Class72.string_4[i] == string.Empty))
				{
					if (text != string.Empty)
					{
						text += ";";
					}
					text += Class72.string_4[i];
				}
			}
		}
		if (Class72.string_3 != null)
		{
			for (int j = 0; j < Class72.string_3.Length; j++)
			{
				if (Class72.string_3[j] != null && !(Class72.string_3[j] == string.Empty))
				{
					if (text2 != string.Empty)
					{
						text2 += ";";
					}
					text2 += Class72.string_3[j];
				}
			}
		}
		if (Class72.string_5 != null)
		{
			for (int k = 0; k < Class72.string_5.Length; k++)
			{
				if (Class72.string_5[k] != null && !(Class72.string_5[k] == string.Empty))
				{
					if (text3 != string.Empty)
					{
						text3 += ";";
					}
					text3 += Class72.string_5[k];
				}
			}
		}
		string string_ = Class72.int_1 + "|" + Class72.int_2 + "|" + Class72.int_3 + "|" + text + "|" + text2 + "|" + text3;
		return Class11.smethod_64(string_);
	}

	public static void smethod_1(string string_5)
	{
		string text = Class11.smethod_65(string_5);
		string[] array = text.Split('|');
		if (array.Length < 3)
		{
			return;
		}
		Class72.int_1 = Class11.smethod_11(array[0]);
		Class72.int_2 = Class11.smethod_11(array[1]);
		Class72.int_3 = Class11.smethod_11(array[2]);
		if (array.Length > 3)
		{
			Class72.string_4 = null;
			if (array[3] != null && array[3] != string.Empty)
			{
				Class72.string_4 = array[3].Split(';');
			}
		}
		if (array.Length > 4)
		{
			Class72.string_3 = null;
			if (array[4] != null && array[4] != string.Empty)
			{
				Class72.string_3 = array[4].Split(';');
			}
		}
		if (array.Length > 5)
		{
			Class72.string_5 = null;
			if (array[5] != null && array[5] != string.Empty)
			{
				Class72.string_5 = array[5].Split(';');
			}
		}
		Class72.uint_1 = Class72.smethod_2(Class72.string_4);
		Class72.uint_0 = Class72.smethod_2(Class72.string_3);
	}

	private static string smethod_2(string string_5, int int_7, bool bool_10 = false)
	{
		if (string_5 != null && !(string_5 == string.Empty))
		{
			if (int_7 > 0)
			{
				string text;
				if (!bool_10)
				{
					if (int_7 > 9)
					{
						string_5 = Class11.smethod_71(string_5);
						if (string_5 != null && string_5 != string.Empty)
						{
							text = string.Empty;
							for (int i = 0; i < string_5.Length; i++)
							{
								char c = string_5[i];
								if (c >= '\u0080')
								{
									if (c > '\u0080')
									{
										c = (char)(c - 128);
									}
								}
								else
								{
									c = (char)(c + 128);
								}
								text += c;
							}
							string_5 = text;
						}
						return string_5;
					}
					text = string.Empty;
					for (int j = 0; j < string_5.Length; j++)
					{
						text += (char)(string_5[j] + int_7 + j % 10);
					}
					return text;
				}
				if (int_7 > 9)
				{
					string text2 = string.Empty;
					for (int k = 0; k < string_5.Length; k++)
					{
						char c2 = string_5[k];
						if (c2 < '\u0080')
						{
							c2 = (char)(c2 + 128);
						}
						else if (c2 > '\u0080')
						{
							c2 = (char)(c2 - 128);
						}
						text2 += c2;
					}
					string_5 = Class11.smethod_72(text2);
					return string_5;
				}
				text = string.Empty;
				for (int l = 0; l < string_5.Length; l++)
				{
					text += (char)(string_5[l] - int_7 - l % 10);
				}
				return text;
			}
			return string_5;
		}
		return string.Empty;
	}

	public static void smethod_3()
	{
		int int_ = int_0;
		int_0 = 0;
		while (true)
		{
			try
			{
				smethod_4(int_);
				break;
			}
			catch
			{
				Thread.Sleep(100);
			}
		}
	}

	public static void smethod_4(int int_7)
	{
		int int_8 = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = -1000;
		long num5 = 0L;
		byte[] array = new byte[4];
		string text = null;
		string empty = string.Empty;
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		while (true)
		{
			num--;
			Thread.Sleep(100);
			if (Class11.bool_0)
			{
				break;
			}
			if (num <= 0)
			{
				num3 = Class87.smethod_3(Form1.characterAccountConfig_1, int_7);
				if (num3 < 0)
				{
					break;
				}
				num = 30;
				Class89.smethod_41(characterAccountConfig_, Form1.int_13 > 0);
			}
			characterAccountConfig_ = Form1.characterAccountConfig_1[num3];
			if (num4 == -1000)
			{
				num4 = GClass1.smethod_5(characterAccountConfig_);
			}
			if (characterAccountConfig_.int_2 > 0 && num4 > 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_8);
				uint num6 = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num6 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_8);
				uint num7 = BitConverter.ToUInt32(array, 0);
				uint num8 = num7 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_8);
				uint num9 = BitConverter.ToUInt32(array, 0);
				uint num10 = num9 + num8;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num10 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_8);
				int num11 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num10 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_8);
				int num12 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_8);
				int num13 = BitConverter.ToInt32(array, 0);
				int num14 = Class89.smethod_39(characterAccountConfig_);
				if (num12 == 0 || num11 == 0 || num13 == 0 || num14 <= 1)
				{
					continue;
				}
				int num15 = 0;
				if (Form1.int_53 > 0)
				{
					num15 = Form1.int_54;
				}
				if (bool_8)
				{
					if (long_0 == 0L || text == null)
					{
						long_0 = Class11.smethod_27();
						text = "UP:" + num15 + ":" + smethod_0();
					}
					if (Class11.smethod_28(long_0) < long_1)
					{
						empty = text;
						goto IL_072c;
					}
					bool_8 = false;
					long_0 = 0L;
					text = null;
				}
				uint num16 = 0u;
				uint num17 = 0u;
				int num18 = Class46.characterSyncSnapshot_0.int_4;
				if (Class46.characterSyncSnapshot_0.uint_4 != null)
				{
					num16 = Class46.characterSyncSnapshot_0.uint_4[0];
					num17 = Class46.characterSyncSnapshot_0.uint_4[1];
				}
				if (num16 == 0 || num17 == 0 || num18 <= 0)
				{
					continue;
				}
				string text2 = "0";
				if (Class59.int_0 > 0)
				{
					if (Class11.smethod_28(Class59.long_0) < 1500L)
					{
						text2 = Class59.int_0.ToString();
					}
					else
					{
						Class59.int_0 = 0;
					}
				}
				empty = string_3 + num18 + string_3 + Class46.characterSyncSnapshot_0.int_3 + string_3 + num16 + string_3 + num17 + string_3 + Class46.characterSyncSnapshot_0.int_6 + string_3 + Class46.characterSyncSnapshot_0.uint_3 + string_3 + Form1.int_121 + string_3 + Form1.int_24 + string_3 + Form1.int_113 + string_3 + Form1.int_115 + string_3 + Class20.int_0 + string_3 + Form1.int_26 + string_3 + Form1.int_34 + string_3 + Form1.int_35 + string_3 + Form1.int_36 + string_3 + Form1.int_29 + string_3 + Class46.characterSyncSnapshot_0.int_2 + string_3 + Form1.int_28 + string_3 + Form1.int_94 + string_3 + Form1.int_95 + string_3 + FormDame.int_6 + string_3 + FormDame.int_9 + string_3 + FormDame.int_11 + string_3 + Class46.characterSyncSnapshot_0.uint_5 + string_3 + Class46.characterSyncSnapshot_0.int_7 + string_3 + Class46.characterSyncSnapshot_0.uint_3 + string_3 + Form1.int_37 + string_3 + Form1.int_38 + string_3 + Form1.int_25 + string_3 + Class46.characterSyncSnapshot_0.int_9 + string_3 + Class46.characterSyncSnapshot_0.uint_2 + string_3 + Form1.int_96 + string_3 + Class46.characterSyncSnapshot_0.int_8 + string_3 + num15 + string_3 + Form1.int_48[0] + string_3 + Form1.int_48[1] + string_3 + Form1.int_4 + string_3 + Class37.int_1 + string_3 + Form1.int_112 + string_3 + Form1.string_37.Replace(" ", "").Replace(",", "_") + string_3 + Form1.int_89 + string_3 + Form1.int_81 + string_3 + Form1.int_120 + string_3 + text2;
				goto IL_072c;
			}
			Form1.characterAccountConfig_1[num3].int_2 = 0;
			break;
			IL_072c:
			string text3 = smethod_2(empty, Form1.int_55);
			Class46.characterSyncSnapshot_0.int_9 = 0;
			if (string_0 != null)
			{
				int num19 = string_0.Length;
				if (num2 < 0 || num19 <= num2)
				{
					num2 = 0;
				}
				int num20 = num2;
				string text4 = null;
				while (text4 == null || text4 == string.Empty || text4 == characterAccountConfig_.string_22)
				{
					try
					{
						text4 = string_0[num2];
					}
					catch
					{
						break;
					}
					num2++;
					if (num2 < 0 || num19 <= num2)
					{
						num2 = 0;
					}
					if (num20 == num2 || string_0 == null || string_0.Length <= num20)
					{
						break;
					}
				}
				if (text4 != null && text4 != string.Empty && characterAccountConfig_.string_22 != text4)
				{
					Class75.smethod_50(characterAccountConfig_, text4, text3);
					Thread.Sleep(80 + 200 / num19 + int_2);
				}
			}
			if (Form1.int_12 > 0 && Class11.smethod_28(num5) >= 2500 + int_2)
			{
				Class75.smethod_57(characterAccountConfig_, "Chat('CH_CHATROOM', '" + text3 + "')");
				num5 = Class11.smethod_27();
			}
		}
		Class89.smethod_41(characterAccountConfig_, bool_0: false);
	}

	public static void smethod_5(CharacterAccountConfig characterAccountConfig_0)
	{
		if (Form1.int_11 <= 0)
		{
			return;
		}
		if (GClass1.long_1 != 0L && !bool_1)
		{
			string text = Class89.smethod_22(characterAccountConfig_0);
			if (text != null && text.Length >= 10)
			{
				int num = text.IndexOf(":");
				if (0 <= num && text.Length > num)
				{
					text = text.Substring(num + 1).Trim();
				}
				string text2 = smethod_2(text, Form1.int_55, bool_10: true);
				if (text2 != null && !(text2 == string.Empty))
				{
					int num2 = text2.IndexOf("UP:");
					if (0 <= num2)
					{
						bool_9 = true;
						string text3 = text2.Substring(num2);
						string[] array = text3.Split(':');
						if (array.Length >= 3 && array[2] != null && !(array[2] == string.Empty) && (Form1.int_53 <= 0 || Class11.smethod_11(array[1]) == Form1.int_54))
						{
							string text4 = array[2];
							int length = text4.Length;
							if (length % 2 > 0)
							{
								text4 = text4.Substring(0, length - 1);
							}
							smethod_1(text4);
							return;
						}
					}
					else
					{
						if (bool_9)
						{
							Form1.bool_17 = true;
							bool_9 = false;
						}
						if (string_3 == null || string_3 == string.Empty)
						{
							string_3 = "|";
						}
						string[] array2 = text2.Split(string_3[0]);
						int num3 = array2.Length;
						if (num3 >= 43)
						{
							try
							{
								if (Form1.int_53 <= 0 || Class11.smethod_11(smethod_8(array2, 34, num3)) == Form1.int_54)
								{
									if (Class46.characterSyncSnapshot_1.uint_4 == null)
									{
										Class46.characterSyncSnapshot_1.uint_4 = new uint[2];
									}
									Form1.int_119 = 0;
									Class46.characterSyncSnapshot_1.int_4 = Class11.smethod_11(smethod_8(array2, 1, num3));
									Class46.characterSyncSnapshot_1.int_3 = Class11.smethod_11(smethod_8(array2, 2, num3));
									Class46.characterSyncSnapshot_1.uint_4[0] = Class11.smethod_12(smethod_8(array2, 3, num3));
									Class46.characterSyncSnapshot_1.uint_4[1] = Class11.smethod_12(smethod_8(array2, 4, num3));
									Class46.characterSyncSnapshot_1.int_6 = Class11.smethod_11(smethod_8(array2, 5, num3));
									Class46.characterSyncSnapshot_1.uint_3 = Class11.smethod_12(smethod_8(array2, 6, num3));
									Form1.int_121 = Class11.smethod_11(smethod_8(array2, 7, num3));
									Form1.int_24 = Class11.smethod_11(smethod_8(array2, 8, num3));
									Form1.int_113 = Class11.smethod_11(smethod_8(array2, 9, num3));
									Form1.int_115 = Class11.smethod_11(smethod_8(array2, 10, num3));
									Class20.int_0 = Class11.smethod_11(smethod_8(array2, 11, num3));
									Form1.int_26 = Class11.smethod_11(smethod_8(array2, 12, num3));
									Form1.int_34 = Class11.smethod_11(smethod_8(array2, 13, num3));
									Form1.int_35 = Class11.smethod_11(smethod_8(array2, 14, num3));
									Form1.int_36 = Class11.smethod_11(smethod_8(array2, 15, num3));
									Class46.characterSyncSnapshot_1.int_10 = Class11.smethod_11(smethod_8(array2, 16, num3));
									Class46.characterSyncSnapshot_1.int_2 = Class11.smethod_11(smethod_8(array2, 17, num3));
									Form1.int_28 = Class11.smethod_11(smethod_8(array2, 18, num3));
									Form1.int_94 = 1;
									Form1.int_95 = Class11.smethod_11(smethod_8(array2, 20, num3));
									FormDame.int_6 = Class11.smethod_11(smethod_8(array2, 21, num3));
									FormDame.int_9 = Class11.smethod_11(smethod_8(array2, 22, num3));
									FormDame.int_11 = Class11.smethod_11(smethod_8(array2, 23, num3));
									Class46.characterSyncSnapshot_1.uint_5 = Class11.smethod_12(smethod_8(array2, 24, num3));
									Class46.characterSyncSnapshot_1.int_7 = Class11.smethod_11(smethod_8(array2, 25, num3));
									Class46.characterSyncSnapshot_1.uint_3 = Class11.smethod_12(smethod_8(array2, 26, num3));
									Form1.int_37 = Class11.smethod_11(smethod_8(array2, 27, num3));
									Form1.int_38 = Class11.smethod_11(smethod_8(array2, 28, num3));
									Form1.int_25 = Class11.smethod_11(smethod_8(array2, 29, num3));
									Class46.characterSyncSnapshot_1.int_9 = Class11.smethod_11(smethod_8(array2, 30, num3));
									Class46.characterSyncSnapshot_1.uint_2 = Class11.smethod_12(smethod_8(array2, 31, num3));
									Form1.int_96 = Class11.smethod_11(smethod_8(array2, 32, num3));
									Class46.characterSyncSnapshot_1.int_8 = Class11.smethod_11(smethod_8(array2, 33, num3));
									Class46.characterSyncSnapshot_0.int_8 = Class46.characterSyncSnapshot_1.int_8;
									Form1.int_48[0] = Class11.smethod_11(smethod_8(array2, 35, num3));
									Form1.int_48[1] = Class11.smethod_11(smethod_8(array2, 36, num3));
									Form1.int_4 = Class11.smethod_11(smethod_8(array2, 37, num3));
									Class37.int_1 = Class11.smethod_11(smethod_8(array2, 38, num3));
									Form1.int_112 = Class11.smethod_11(smethod_8(array2, 39, num3));
									Form1.string_37 = smethod_8(array2, 40, num3);
									Form1.int_89 = Class11.smethod_11(smethod_8(array2, 41, num3));
									Form1.int_81 = Class11.smethod_11(smethod_8(array2, 42, num3));
									Form1.int_120 = Class11.smethod_11(smethod_8(array2, 43, num3));
									if (num3 > 44)
									{
										int num4 = Class11.smethod_11(smethod_8(array2, 44, num3));
										if (num4 > 0 && Form1.characterAccountConfig_1 != null)
										{
											for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
											{
												if (num4 == 1 && Form1.characterAccountConfig_1[i].bool_25)
												{
													Class75.smethod_2(Form1.characterAccountConfig_1[i], Class75.uint_22, 1, 4);
												}
												else
												{
													Class75.smethod_2(Form1.characterAccountConfig_1[i], Class75.uint_22, 0, 4);
												}
											}
										}
									}
									goto IL_064e;
								}
							}
							catch
							{
								goto IL_064e;
							}
						}
					}
				}
			}
			if (Class11.smethod_28(Class46.characterSyncSnapshot_1.long_1) > 6000L)
			{
				Class89.smethod_41(characterAccountConfig_0, bool_0: false);
				if (Class11.smethod_2(text, "g\u00adêi nµy"))
				{
					Class89.smethod_23(characterAccountConfig_0, "0K..");
					Class75.smethod_57(characterAccountConfig_0, "Switch([[trade]])");
					Thread.Sleep(50);
				}
				Class46.characterSyncSnapshot_1.int_4 = 0;
				Class46.characterSyncSnapshot_1.long_1 = Class11.smethod_27();
			}
		}
		else
		{
			Class46.characterSyncSnapshot_1.int_4 = 0;
			Class46.characterSyncSnapshot_1.int_0 = 0;
			Class46.characterSyncSnapshot_1.int_6 = 0;
		}
		return;
		IL_064e:
		Class46.characterSyncSnapshot_1.long_1 = Class11.smethod_27();
	}

	private void AuxiliaryMachineManager_Load(object sender, EventArgs e)
	{
		if (int_3 >= 0 && int_4 >= 0)
		{
			int num = int_3 - base.Width - 10;
			int num2 = int_4 - base.Height - 10;
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
		listView1.Items.Clear();
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (string_0[i] != null && string_0[i] != string.Empty)
				{
					smethod_6(ref listView1, Class1.smethod_1(string_0[i], 1));
				}
			}
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	public static void smethod_6(ref ListView listView_0, string string_5)
	{
		if (string_5 != null)
		{
			try
			{
				ListViewItem listViewItem = new ListViewItem((listView_0.Items.Count + 1).ToString());
				ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, string_5);
				listViewItem.SubItems.Add(item);
				listView_0.Items.Add(listViewItem);
			}
			catch
			{
			}
		}
	}

	private int method_0(ListView listView_0)
	{
		if (listView_0.Items != null)
		{
			for (int i = 0; i < listView_0.Items.Count; i++)
			{
				if (listView_0.Items[i].Selected)
				{
					return i;
				}
			}
		}
		return -1;
	}

	private void comboBoxThemAcc_DropDown(object sender, EventArgs e)
	{
		string_4 = null;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Class3.smethod_25(Form1.characterAccountConfig_1[i], ref string_4, 1);
			}
		}
		comboBoxThemAcc.Items.Clear();
		if (string_4 != null)
		{
			Array.Sort(string_4);
			for (int j = 0; j < string_4.Length; j++)
			{
				comboBoxThemAcc.Items.Add(Class1.smethod_1(string_4[j], 1));
			}
		}
		comboBoxThemAcc.Items.Add(string.Empty);
	}

	private void buttonThemAcc_Click(object sender, EventArgs e)
	{
		string text = comboBoxThemAcc.Text;
		if (listView1.Items.Count > 0)
		{
			for (int i = 0; i < listView1.Items.Count; i++)
			{
				if (text == listView1.Items[i].SubItems[1].Text)
				{
					comboBoxThemAcc.Items.Clear();
					comboBoxThemAcc.Text = "";
					return;
				}
			}
		}
		if (string_4 != null)
		{
			for (int j = 0; j < string_4.Length; j++)
			{
				if (text == Class1.smethod_1(string_4[j], 1))
				{
					text = string_4[j];
					break;
				}
			}
		}
		Class11.smethod_29(ref string_0, text);
		smethod_6(ref listView1, text);
		comboBoxThemAcc.Items.Clear();
		comboBoxThemAcc.Text = "";
		smethod_7();
	}

	private void buttonXoaAcc_Click(object sender, EventArgs e)
	{
		int num = method_0(listView1);
		if (num < 0 || num > listView1.Items.Count - 1)
		{
			return;
		}
		string text = listView1.Items[num].SubItems[1].Text;
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (text == Class1.smethod_1(string_0[i], 1))
				{
					Class11.smethod_30(ref string_0, string_0[i]);
					break;
				}
			}
		}
		listView1.Items.RemoveAt(num);
		for (int j = 0; j < listView1.Items.Count; j++)
		{
			listView1.Items[j].SubItems[0].Text = (j + 1).ToString();
		}
		smethod_7();
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		bool_0 = false;
		Close();
	}

	private static void smethod_7()
	{
		string text = string.Empty;
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (text != string.Empty)
				{
					text += "|";
				}
				text += string_0[i];
			}
			text = Class11.smethod_16(text);
		}
		Class11.smethod_34(Class56.string_15, text, 1);
	}

	private static string smethod_8(string[] string_5, int int_7, int int_8 = 0)
	{
		if ((int_8 <= 0 || int_8 > int_7) && string_5 != null && string_5.Length > int_7)
		{
			return string_5[int_7];
		}
		return string.Empty;
	}

	public static int smethod_9(CharacterAccountConfig characterAccountConfig_0, ref long long_2, ref int int_7, ref uint[] uint_0)
	{
		Form1.int_119 = 0;
		if (Class11.smethod_63(Class46.characterSyncSnapshot_1.uint_4))
		{
			int num = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
			if (Class6.smethod_0(num))
			{
				uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
				uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
				uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
				uint num5 = num4 + num3 * Class56.memorySignatureScanConfig_15.uint_0;
				int num6 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
				int num7 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
				int num8 = Class89.smethod_39(characterAccountConfig_0);
				if (num6 != 10 && num6 != 21 && num7 != 0 && num8 > 1)
				{
					uint[] array = new uint[2]
					{
						Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					int num9 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
					long num12;
					byte[] byte_;
					if (num != Class46.characterSyncSnapshot_1.int_4)
					{
						if (!Class6.smethod_0(Class46.characterSyncSnapshot_1.int_4))
						{
							return 1;
						}
						array = new uint[2]
						{
							Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
							Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
						};
						uint[] array2 = Class6.smethod_1(num, array, Class46.characterSyncSnapshot_1.int_4, Class46.characterSyncSnapshot_1.uint_4);
						if (array2 != null)
						{
							int int_8 = 0;
							int int_9 = characterAccountConfig_0.int_137;
							uint uint_1 = num5 + Class56.memorySignatureScanConfig_72.uint_0;
							byte_ = new byte[4];
							Class24.WriteProcessMemory(int_9, uint_1, byte_, 4, ref int_8);
							uint[] array3 = new uint[2]
							{
								array2[0],
								array2[1]
							};
							int num10 = (int)array2[2];
							long num11 = Class64.smethod_18(array, array3);
							if (num11 >= 90000L)
							{
								Class64.smethod_29(characterAccountConfig_0, bool_0: false);
								if (uint_0 == null)
								{
									uint_0 = new uint[2]
									{
										array[0],
										array[1]
									};
									int_7 = 0;
								}
								if (int_7 > 6)
								{
									bool flag = uint_0 != null && Class64.smethod_18(uint_0, array) < 180000L;
									uint_0 = null;
									int_7 = 0;
									if (flag)
									{
										Class64.smethod_2(characterAccountConfig_0, array, Class46.characterSyncSnapshot_1.uint_4, 600);
										return -1;
									}
								}
								if (!Class13.smethod_3(characterAccountConfig_0) || Class11.smethod_28(long_2) > 3000L)
								{
									int_7++;
									Class13.smethod_1(characterAccountConfig_0, array3);
									long_2 = Class11.smethod_27();
								}
								return -1;
							}
							int_7 = 0;
							uint_0 = null;
							for (int i = 0; i < 10; i++)
							{
								array = new uint[2]
								{
									Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
									Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
								};
								num12 = Class64.smethod_18(array, array3);
								if (num12 < 11500L || Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137) != num)
								{
									break;
								}
								Class75.smethod_61(characterAccountConfig_0, array3);
								Thread.Sleep(300);
							}
							for (int j = 0; j < 5; j++)
							{
								Class64.smethod_25(characterAccountConfig_0, num10);
								Thread.Sleep(300);
								uint num13 = Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
								if (num13 != num)
								{
									break;
								}
							}
						}
						return -1;
					}
					num12 = Class64.smethod_18(array, Class46.characterSyncSnapshot_1.uint_4);
					if (characterAccountConfig_0.int_130[0] > 0 && characterAccountConfig_0.int_136 != Class46.characterSyncSnapshot_1.int_0 && num9 == Class46.characterSyncSnapshot_1.int_3 && num9 > 0)
					{
						int num14 = characterAccountConfig_0.int_130[1] + Form1.int_27;
						if (num12 <= num14 * num14 && Class68.smethod_0(characterAccountConfig_0, Class46.characterSyncSnapshot_1.uint_4, characterAccountConfig_0.int_130[1]) > 0)
						{
							return 3;
						}
					}
					if (num12 <= Form1.int_27 * Form1.int_27)
					{
						Class13.smethod_2(characterAccountConfig_0, bool_0: false);
						if (num12 > 20000L)
						{
							Class75.smethod_61(characterAccountConfig_0, Class46.characterSyncSnapshot_1.uint_4);
							Thread.Sleep(100);
						}
						int_7 = 0;
						uint_0 = null;
						return 3;
					}
					int int_10 = 0;
					int int_11 = characterAccountConfig_0.int_137;
					uint uint_2 = num5 + Class56.memorySignatureScanConfig_72.uint_0;
					byte_ = new byte[4];
					Class24.WriteProcessMemory(int_11, uint_2, byte_, 4, ref int_10);
					if (num12 > Form1.int_108 * Form1.int_108)
					{
						Class64.smethod_29(characterAccountConfig_0, bool_0: false);
					}
					if (int_7 > 6)
					{
						bool flag2 = uint_0 != null && Class64.smethod_18(uint_0, array) < 180000L;
						uint_0 = null;
						int_7 = 0;
						if (flag2)
						{
							int int_12 = 0;
							int int_13 = characterAccountConfig_0.int_137;
							uint uint_3 = num5 + Class56.memorySignatureScanConfig_72.uint_0;
							byte_ = new byte[4];
							Class24.WriteProcessMemory(int_13, uint_3, byte_, 4, ref int_12);
							Class64.smethod_2(characterAccountConfig_0, array, Class46.characterSyncSnapshot_1.uint_4, 600);
							return -1;
						}
					}
					if (num12 < 810000L)
					{
						Class13.smethod_2(characterAccountConfig_0, bool_0: false);
						Class75.smethod_61(characterAccountConfig_0, Class46.characterSyncSnapshot_1.uint_4);
						Thread.Sleep(100);
						return -1;
					}
					if (!Class13.smethod_3(characterAccountConfig_0) || Class11.smethod_28(long_2) > 3000L)
					{
						int_7++;
						Class13.smethod_1(characterAccountConfig_0, Class46.characterSyncSnapshot_1.uint_4);
						long_2 = Class11.smethod_27();
					}
					return -1;
				}
				return 1;
			}
			return 1;
		}
		return 1;
	}

	public static int smethod_10(CharacterAccountConfig characterAccountConfig_0, ref long long_2, ref int int_7, ref uint[] uint_0)
	{
		if (Class11.smethod_63(Class46.characterSyncSnapshot_1.uint_4))
		{
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
			uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
			int num5 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
			int num6 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
			int num7 = Class89.smethod_39(characterAccountConfig_0);
			if (num5 != 10 && num5 != 21 && num6 != 0 && num7 > 1)
			{
				int num8 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
				if (num8 != Class46.characterSyncSnapshot_1.int_4)
				{
					return 1;
				}
				int num9 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
				if (num9 > 0 && (num9 <= 0 || Class46.characterSyncSnapshot_1.int_3 > 0))
				{
					uint[] array = new uint[2]
					{
						Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
						Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
					};
					long num10 = Class64.smethod_18(array, Class46.characterSyncSnapshot_1.uint_4);
					if (characterAccountConfig_0.int_130[0] > 0 && characterAccountConfig_0.int_136 != Class46.characterSyncSnapshot_1.int_0 && num9 == Class46.characterSyncSnapshot_1.int_3 && num9 > 0)
					{
						int num11 = characterAccountConfig_0.int_130[1] + Form1.int_27;
						if (num10 <= num11 * num11 && Class68.smethod_0(characterAccountConfig_0, Class46.characterSyncSnapshot_1.uint_4, characterAccountConfig_0.int_130[1]) > 0)
						{
							return 3;
						}
					}
					if (num10 > Form1.int_27 * Form1.int_27)
					{
						int int_8 = 0;
						int int_9 = characterAccountConfig_0.int_137;
						uint uint_1 = num4 + Class56.memorySignatureScanConfig_72.uint_0;
						byte[] byte_ = new byte[4];
						Class24.WriteProcessMemory(int_9, uint_1, byte_, 4, ref int_8);
						if (num10 > Form1.int_108 * Form1.int_108)
						{
							Class64.smethod_29(characterAccountConfig_0, bool_0: false);
						}
						if (uint_0 == null)
						{
							uint_0 = new uint[2]
							{
								array[0],
								array[1]
							};
							int_7 = 0;
						}
						if (int_7 > 6)
						{
							bool flag = uint_0 != null && Class64.smethod_18(uint_0, array) < 180000L;
							uint_0 = null;
							int_7 = 0;
							if (flag)
							{
								Class64.smethod_2(characterAccountConfig_0, array, Class46.characterSyncSnapshot_1.uint_4, 600);
								return -1;
							}
						}
						if (num10 < 810000L)
						{
							Class13.smethod_2(characterAccountConfig_0, bool_0: false);
							Class75.smethod_61(characterAccountConfig_0, Class46.characterSyncSnapshot_1.uint_4);
							Thread.Sleep(100);
							return -1;
						}
						if (!Class13.smethod_3(characterAccountConfig_0) || Class11.smethod_28(long_2) > 3000L)
						{
							int_7++;
							Class13.smethod_1(characterAccountConfig_0, Class46.characterSyncSnapshot_1.uint_4);
							long_2 = Class11.smethod_27();
						}
						return -1;
					}
					Class13.smethod_2(characterAccountConfig_0, bool_0: false);
					if (num10 > 20000L)
					{
						Class75.smethod_61(characterAccountConfig_0, Class46.characterSyncSnapshot_1.uint_4);
						Thread.Sleep(110);
					}
					int_7 = 0;
					uint_0 = null;
					return 3;
				}
				return 1;
			}
			return 1;
		}
		return 1;
	}

	public static int smethod_11(CharacterAccountConfig characterAccountConfig_0, ref bool bool_10, ref long long_2, ref int int_7, ref uint[] uint_0)
	{
		if (!Class11.smethod_63(Class46.characterSyncSnapshot_1.uint_4))
		{
			return 1;
		}
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
		int num5 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
		int num6 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
		int num7 = Class89.smethod_39(characterAccountConfig_0);
		int num12;
		uint[] uint_2;
		uint[] uint_3;
		GStruct28 gStruct;
		int num8;
		byte[] byte_;
		uint[] array;
		if (num5 != 10 && num5 != 21 && num6 != 0 && num7 > 1)
		{
			array = new uint[2]
			{
				Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
				Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
			};
			num8 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
			int num9 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
			if (num9 != Class46.characterSyncSnapshot_1.int_4)
			{
				if (Class20.smethod_0(Class46.characterSyncSnapshot_1.int_4))
				{
					Class20.smethod_1(characterAccountConfig_0, bool_0: true, bool_1: true);
					return -4;
				}
				if ((num9 == 221 || num9 == 539) && Class53.smethod_0(characterAccountConfig_0) > 0)
				{
					return -5;
				}
				num9 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
				if (Class20.smethod_0(num9))
				{
					if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0 && Class29.smethod_7(characterAccountConfig_0, Class46.characterSyncSnapshot_1.int_4, null, Class46.characterSyncSnapshot_1.uint_4))
					{
						int num10 = 0;
						while (num10 < 10)
						{
							if (Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137) == num9)
							{
								num10++;
								Thread.Sleep(100);
								continue;
							}
							return -5;
						}
					}
					uint[] array2 = Class20.smethod_2(characterAccountConfig_0);
					if (array2 != null)
					{
						int int_8 = 0;
						int int_9 = characterAccountConfig_0.int_137;
						uint uint_1 = num4 + Class56.memorySignatureScanConfig_72.uint_0;
						byte_ = new byte[4];
						Class24.WriteProcessMemory(int_9, uint_1, byte_, 4, ref int_8);
						if (!Class13.smethod_3(characterAccountConfig_0) || Class11.smethod_28(long_2) > 3000L)
						{
							Class13.smethod_1(characterAccountConfig_0, array2);
							long_2 = Class11.smethod_27();
						}
					}
					return -5;
				}
				array = new uint[2]
				{
					Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
				gStruct = default(GStruct28);
				int num11 = 0;
				num12 = 0;
				uint_2 = null;
				uint_3 = null;
				if (num9 != 336 && Class46.characterSyncSnapshot_1.int_4 == 341)
				{
					long num13 = Class64.smethod_21(Class43.uint_0, array);
					long num14 = Class64.smethod_21(Class43.uint_1, array);
					if (num13 > num14)
					{
						return 6;
					}
					gStruct = Class45.smethod_4(num9, Class46.characterSyncSnapshot_1.int_4);
				}
				else
				{
					if (num9 == 175 || num9 == 195)
					{
						string text = "Tèng Kim Chiªu th|Phong V©n Chiªu\u00ad th";
						if (Class75.smethod_44(characterAccountConfig_0, text))
						{
							Thread.Sleep(300);
							Class95.smethod_5(characterAccountConfig_0, 0);
							return -6;
						}
					}
					if (num9 != 175)
					{
						if (Class45.smethod_1(num9) && !Class45.smethod_1(Class46.characterSyncSnapshot_1.int_4))
						{
							int num15 = 11;
							int[] array3 = Class64.smethod_9(Class46.characterSyncSnapshot_1.int_4);
							if (array3 != null)
							{
								num15 = Class64.int_0[array3[0], 0];
							}
							Class53.smethod_5(characterAccountConfig_0, num15);
							return -9;
						}
						if (Form1.int_26 <= 0 && Class46.characterSyncSnapshot_1.int_3 <= 0)
						{
							return 7;
						}
						if (num8 > 0 && Class46.characterSyncSnapshot_1.int_3 <= 0)
						{
							gStruct = Class45.smethod_4(num9, Class46.characterSyncSnapshot_1.int_4);
							if (gStruct.int_0 != num9 || gStruct.int_1 != Class46.characterSyncSnapshot_1.int_4)
							{
								if (Class11.smethod_1(Class46.characterSyncSnapshot_1.string_1, "Õn thuyÒ") > 0)
								{
									return 8;
								}
								if (Form1.int_90 > 0 && num9 != 195)
								{
									if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0 && Class29.smethod_7(characterAccountConfig_0, Class46.characterSyncSnapshot_1.int_4, null, Class46.characterSyncSnapshot_1.uint_4))
									{
										return -7;
									}
									if (Class64.smethod_14(characterAccountConfig_0))
									{
										return -8;
									}
								}
								if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0 && Class29.smethod_7(characterAccountConfig_0, Class46.characterSyncSnapshot_1.int_4, null, Class46.characterSyncSnapshot_1.uint_4))
								{
									if (num9 == 195 || num9 == 195)
									{
										try
										{
											int int_10 = 0;
											byte[] byte_2 = new byte[1] { 1 };
											Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_33 * 4, byte_2, 1, ref int_10);
										}
										catch
										{
										}
									}
									return -7;
								}
								if (num9 != 195)
								{
									if (Class64.smethod_14(characterAccountConfig_0))
									{
										Thread.Sleep(300);
										Class64.smethod_11(characterAccountConfig_0);
										Thread.Sleep(600);
										int num16 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
										if (num16 != num9)
										{
											return -9;
										}
									}
									string text2 = "Tèng Kim Chiªu th|Phong V©n Chiªu\u00ad th";
									if (Class75.smethod_44(characterAccountConfig_0, text2))
									{
										Thread.Sleep(300);
										Class95.smethod_5(characterAccountConfig_0, 0);
										return -6;
									}
									return -8;
								}
								return 9;
							}
						}
						else
						{
							if (num8 <= 0 && Class46.characterSyncSnapshot_1.int_3 <= 0)
							{
								if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0 && Class29.smethod_7(characterAccountConfig_0, Class46.characterSyncSnapshot_1.int_4, null, Class46.characterSyncSnapshot_1.uint_4))
								{
									return -7;
								}
								Class53.smethod_5(characterAccountConfig_0, Class46.characterSyncSnapshot_1.int_4);
								return -9;
							}
							if (num8 == 0 && Class46.characterSyncSnapshot_1.int_3 > 0)
							{
								gStruct = Class45.smethod_4(num9, Class46.characterSyncSnapshot_1.int_4);
								if (gStruct.int_0 != num9 || gStruct.int_1 != Class46.characterSyncSnapshot_1.int_4)
								{
									if (Form1.int_90 > 0 || Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) == 0)
									{
										if (bool_10)
										{
											bool_10 = false;
											uint[] uint_4 = null;
											if (Form1.int_25 > 0 && Class46.characterSyncSnapshot_1.int_0 > 0 && Class46.characterSyncSnapshot_1.int_4 == num9)
											{
												uint_4 = Class46.characterSyncSnapshot_1.uint_4;
											}
											if (Class53.smethod_2(characterAccountConfig_0, "®iÓm c", uint_4) > 0)
											{
												Class64.smethod_11(characterAccountConfig_0);
												goto IL_0b64;
											}
										}
										if (Class53.smethod_4(characterAccountConfig_0, Class46.characterSyncSnapshot_1.int_4) > 0)
										{
											Thread.Sleep(300);
											Class64.smethod_11(characterAccountConfig_0);
											Thread.Sleep(600);
											int num17 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
											if (num17 != num9)
											{
												goto IL_0b64;
											}
										}
									}
									bool flag = Class46.characterSyncSnapshot_1.int_4 == 181 && Class37.int_0 > 0;
									if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0 && !flag)
									{
										int num18 = Class46.characterSyncSnapshot_1.int_4;
										int num19 = Class29.smethod_3(num18);
										if (num19 < 0 && Class46.characterSyncSnapshot_1.int_4 == 76)
										{
											num18 = 75;
											num19 = Class29.smethod_3(75);
										}
										if (0 <= num19 && Class29.smethod_7(characterAccountConfig_0, num18))
										{
											Thread.Sleep(300);
											Class64.smethod_11(characterAccountConfig_0);
											Thread.Sleep(600);
											int num20 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
											if (num20 != num9)
											{
												goto IL_0b64;
											}
										}
										else if (num9 != 103 && num9 != 114 && num9 != 110 && (Class46.characterSyncSnapshot_1.int_4 == 110 || Class46.characterSyncSnapshot_1.int_4 == 114) && Class29.smethod_7(characterAccountConfig_0, 103))
										{
											Thread.Sleep(300);
											Class64.smethod_11(characterAccountConfig_0);
											Thread.Sleep(600);
											int num21 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
											if (num21 != num9)
											{
												goto IL_0b64;
											}
										}
									}
									int[] array4 = Class64.smethod_9(num9);
									if (array4 == null && Class46.characterSyncSnapshot_1.int_4 > 0 && Class59.smethod_1(num9) != null && Class59.smethod_0(Class46.characterSyncSnapshot_1.int_4) == null)
									{
										Class53.smethod_5(characterAccountConfig_0, 11);
										Thread.Sleep(600);
										int num22 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
										if (num22 != num9)
										{
											int int_11 = 0;
											byte[] byte_3 = new byte[1] { 1 };
											Class24.WriteProcessMemory(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_16 + Class75.uint_33 * 4, byte_3, 1, ref int_11);
											goto IL_0b64;
										}
									}
									bool flag2 = false;
									if (!Class20.smethod_0(Class46.characterSyncSnapshot_1.int_4))
									{
										if (Class46.characterSyncSnapshot_1.int_4 != 181)
										{
											if (Class46.characterSyncSnapshot_1.int_4 != 224)
											{
												if (Class46.characterSyncSnapshot_1.int_4 == 993)
												{
													Class53.smethod_2(characterAccountConfig_0, "NguyÖt Ca");
													flag2 = true;
												}
												else
												{
													Class53.smethod_4(characterAccountConfig_0, Class46.characterSyncSnapshot_1.int_4);
													flag2 = true;
												}
											}
											else
											{
												Class53.smethod_2(characterAccountConfig_0, "h÷ng n¬i ®· ®i q|Sa M¹c");
												flag2 = true;
											}
										}
										else
										{
											Class53.smethod_2(characterAccountConfig_0, "h÷ng n¬i ®· ®i q|L\u00adìng Thñy|" + Class46.characterSyncSnapshot_1.string_1);
											flag2 = true;
										}
									}
									else
									{
										Class53.smethod_2(characterAccountConfig_0, "ChiÕn Long|H\u00b8i Qu¶ H|L\u00adìng Thñy ");
										flag2 = true;
									}
									if (flag2)
									{
										Thread.Sleep(150);
										Class64.smethod_11(characterAccountConfig_0);
										int num23 = 0;
										while (num23 < 8)
										{
											int num24 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
											if (num24 == num9)
											{
												num23++;
												Thread.Sleep(100);
												continue;
											}
											goto IL_0b64;
										}
									}
									int num25 = -1;
									if (Form1.int_23 > 0)
									{
										num25 = -1;
									}
									if (num25 < 0)
									{
										num11 = Class64.smethod_7(num9, Class46.characterSyncSnapshot_1.int_4, ref gStruct);
										if (num11 == 0)
										{
											goto IL_0cfc;
										}
										if (num11 > 0)
										{
											Class53.smethod_5(characterAccountConfig_0, num11);
											goto IL_0b64;
										}
									}
									return -9;
								}
							}
							else
							{
								if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0 && Class29.smethod_7(characterAccountConfig_0, Class46.characterSyncSnapshot_1.int_4))
								{
									Thread.Sleep(300);
									Class64.smethod_11(characterAccountConfig_0);
									Thread.Sleep(600);
									int num26 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
									if (num26 != num9)
									{
										return -7;
									}
								}
								gStruct = Class45.smethod_4(num9, Class46.characterSyncSnapshot_1.int_4);
								if (gStruct.int_0 != num9 || gStruct.int_1 != Class46.characterSyncSnapshot_1.int_4)
								{
									num11 = Class64.smethod_7(num9, Class46.characterSyncSnapshot_1.int_4, ref gStruct);
									if (num11 != 0)
									{
										bool_10 = false;
										if (num11 > 0)
										{
											if (num9 == 336)
											{
												long num27 = Class64.smethod_21(Class43.uint_0, array);
												long num28 = Class64.smethod_21(Class43.uint_1, array);
												if (num27 > num28)
												{
													gStruct = Class45.smethod_4(num9, 121);
													goto IL_0cfc;
												}
											}
											if (Class64.smethod_14(characterAccountConfig_0))
											{
												Thread.Sleep(300);
												Class64.smethod_11(characterAccountConfig_0);
												Thread.Sleep(600);
												int num29 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
												if (num29 != num9)
												{
													return -8;
												}
											}
										}
										return 1;
									}
								}
							}
						}
					}
					else
					{
						gStruct = Class45.smethod_4(num9, 195);
					}
				}
				goto IL_0cfc;
			}
			bool flag3 = Class59.smethod_0(num9) != null || Class59.smethod_2(num9) > 0;
			if (num8 > 0 && flag3 && Class46.characterSyncSnapshot_1.int_3 <= 0)
			{
				return 3;
			}
			long num30 = Class64.smethod_18(array, Class46.characterSyncSnapshot_1.uint_4);
			if (characterAccountConfig_0.int_130[0] > 0 && characterAccountConfig_0.int_136 != Class46.characterSyncSnapshot_1.int_0 && num8 == Class46.characterSyncSnapshot_1.int_3 && num8 > 0)
			{
				int num31 = characterAccountConfig_0.int_130[1] + Form1.int_27;
				if (num30 <= num31 * num31 && Class68.smethod_0(characterAccountConfig_0, Class46.characterSyncSnapshot_1.uint_4, characterAccountConfig_0.int_130[1]) > 0)
				{
					return 4;
				}
			}
			if (num30 > Form1.int_27 * Form1.int_27)
			{
				if (num9 == 336)
				{
					int num32 = 0;
					int num33 = 0;
					long num34 = Class64.smethod_21(Class43.uint_0, array);
					long num35 = Class64.smethod_21(Class43.uint_1, array);
					if (num34 < num35)
					{
						num32 = 1;
					}
					num34 = Class64.smethod_21(Class43.uint_0, Class46.characterSyncSnapshot_1.uint_4);
					num35 = Class64.smethod_21(Class43.uint_1, Class46.characterSyncSnapshot_1.uint_4);
					if (num34 < num35)
					{
						num33 = 1;
					}
					if (num32 != num33)
					{
						return 5;
					}
				}
				int int_12 = 0;
				int int_13 = characterAccountConfig_0.int_137;
				uint uint_5 = num4 + Class56.memorySignatureScanConfig_72.uint_0;
				byte_ = new byte[4];
				Class24.WriteProcessMemory(int_13, uint_5, byte_, 4, ref int_12);
				if (uint_0 == null)
				{
					uint_0 = new uint[2]
					{
						array[0],
						array[1]
					};
					int_7 = 0;
				}
				if (int_7 > 6)
				{
					bool flag4 = uint_0 != null && Class64.smethod_18(uint_0, array) < 180000L;
					uint_0 = null;
					int_7 = 0;
					if (flag4)
					{
						Class64.smethod_2(characterAccountConfig_0, array, Class46.characterSyncSnapshot_1.uint_4, 600);
						return -1;
					}
				}
				if (num30 > Form1.int_108 * Form1.int_108)
				{
					Class64.smethod_29(characterAccountConfig_0, bool_0: false);
				}
				if (num30 < 22500L)
				{
					Class13.smethod_2(characterAccountConfig_0, bool_0: false);
					return 4;
				}
				if (num30 >= 810000L)
				{
					int[] array5 = Class64.smethod_9(num9);
					if (array5 != null && num8 > 0 && Class46.characterSyncSnapshot_1.int_3 <= 0)
					{
						if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0 && Class29.smethod_7(characterAccountConfig_0, Class46.characterSyncSnapshot_1.int_4, null, Class46.characterSyncSnapshot_1.uint_4))
						{
							return -2;
						}
						if (Class64.smethod_14(characterAccountConfig_0))
						{
							return -2;
						}
					}
					if (bool_10 && !flag3 && num8 == 0 && array5 != null && array5[1] == 0 && (Class46.characterSyncSnapshot_1.int_3 > 0 || Class46.characterSyncSnapshot_0.int_3 > 0))
					{
						bool_10 = false;
						uint[] uint_6 = null;
						if (Class46.characterSyncSnapshot_1.int_4 == num9)
						{
							uint_6 = Class46.characterSyncSnapshot_1.uint_4;
						}
						if (Class53.smethod_2(characterAccountConfig_0, "®iÓm c", uint_6) > 0)
						{
							Thread.Sleep(300);
							Class64.smethod_11(characterAccountConfig_0);
							return -2;
						}
					}
					int num36 = -1;
					long num37 = 0L;
					uint[,] array6 = null;
					uint[] array7 = null;
					if (Class46.characterSyncSnapshot_1.int_3 > 0)
					{
						uint[] array8 = Class45.smethod_11(Class46.characterSyncSnapshot_1.uint_4, num9, "NGOAITHANH");
						if (array8 != null)
						{
							long num38 = Class64.smethod_18(Class46.characterSyncSnapshot_1.uint_4, array8);
							if (num38 <= 100000000L)
							{
								array6 = Class44.smethod_1(num9, array, array8);
								if (array6 != null)
								{
									num36 = Class64.smethod_20(array6, array8);
									if (num36 >= 0)
									{
										array7 = new uint[2]
										{
											array6[num36, 0],
											array6[num36, 1]
										};
										num37 = Class64.smethod_18(array, array7);
										if (num37 > 500000L)
										{
											Class13.smethod_2(characterAccountConfig_0, bool_0: false);
											Class64.smethod_22(characterAccountConfig_0, array6, array, array8, num9, bool_0: true, 8000);
											num8 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
											if (num8 <= 0)
											{
												return -1;
											}
										}
									}
								}
							}
						}
					}
					else
					{
						array6 = Class44.smethod_1(num9, Class46.characterSyncSnapshot_1.uint_4);
						if (array6 != null)
						{
							num36 = Class64.smethod_20(array6, Class46.characterSyncSnapshot_1.uint_4);
							if (num36 >= 0)
							{
								array7 = new uint[2]
								{
									array6[num36, 0],
									array6[num36, 1]
								};
								num37 = Class64.smethod_18(array, array7);
								num8 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
								if (num37 >= 90000L && num8 <= 0)
								{
									Class13.smethod_2(characterAccountConfig_0, bool_0: false);
									Class64.smethod_22(characterAccountConfig_0, array6, array, Class46.characterSyncSnapshot_1.uint_4, num9, bool_0: true, 8000);
									return -1;
								}
							}
						}
					}
					if (num9 == 53 && Class46.characterSyncSnapshot_1.int_4 == 53 && num8 <= 0)
					{
						uint[] array9 = Class46.characterSyncSnapshot_1.uint_4;
						if (Class93.gstruct23_0 == null)
						{
							Class93.gstruct23_0 = Class93.smethod_1();
						}
						if (Class46.characterSyncSnapshot_1.int_3 > 0)
						{
							array9 = Class93.smethod_0(array9);
						}
						uint[,] uint_7 = Class45.smethod_10(Class93.gstruct23_0, array, array9);
						uint[] array10 = array;
						int num39 = Class64.smethod_22(characterAccountConfig_0, uint_7, array, array9, 53, bool_0: true, 8000);
						array = new uint[2]
						{
							Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
							Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
						};
						if (array10 != null && num39 > 0 && (array10[0] != array[0] || array10[1] != array[1]))
						{
							return -3;
						}
					}
					num30 = Class64.smethod_18(array, Class46.characterSyncSnapshot_1.uint_4);
					uint[] array11 = new uint[2]
					{
						Class46.characterSyncSnapshot_1.uint_4[0],
						Class46.characterSyncSnapshot_1.uint_4[1]
					};
					if (num9 == 333)
					{
						if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0 && num30 > 15354505L && Form1.string_6 == "vltrungnguyen.com")
						{
							num30 = -1L;
							int num40 = -1;
							for (int i = 0; i < Class101.gstruct25_0.Length; i++)
							{
								long num41 = Class64.smethod_18(Class46.characterSyncSnapshot_1.uint_4, Class101.gstruct25_0[i].uint_0);
								if (num40 < 0 || num41 < num30)
								{
									num40 = i;
									num30 = num41;
								}
							}
							if (Class29.smethod_5(characterAccountConfig_0, "b¶n ®å|§Æc BiÖt|" + Class101.gstruct25_0[num40].string_0))
							{
								Thread.Sleep(200);
								return -3;
							}
						}
						bool flag5 = Class101.smethod_0(array);
						bool flag6 = Class101.smethod_0(Class46.characterSyncSnapshot_1.uint_4);
						if (flag5 == flag6)
						{
							if (!flag5)
							{
								long num42 = Class64.smethod_21(Class101.uint_0, array);
								long num43 = Class64.smethod_21(Class101.uint_0, Class46.characterSyncSnapshot_1.uint_4);
								long num44 = Class64.smethod_18(array, Class46.characterSyncSnapshot_1.uint_4);
								if (num42 > 1500000L && num43 > 1500000L && num44 > 1500000L)
								{
									uint[,] array12 = Class101.smethod_1(array);
									num30 = Class64.smethod_21(array12, array);
									if (num30 <= 300000L)
									{
										Class64.smethod_22(characterAccountConfig_0, array12, array, null, num9, bool_0: false, 6000, bool_1: true);
										return -3;
									}
									array11[0] = array12[0, 0];
									array11[1] = array12[0, 1];
								}
							}
						}
						else
						{
							uint[,] array13 = null;
							uint[,] array14 = Class101.smethod_1(Class46.characterSyncSnapshot_1.uint_4);
							uint[,] array15 = Class101.smethod_1(array);
							int length = array14.GetLength(0);
							int length2 = array15.GetLength(0);
							long num45 = 0L;
							long num46 = 0L;
							if (!flag5)
							{
								num45 = Class64.smethod_19(array, array14[0, 0], array14[0, 1]);
								num45 += Class64.smethod_19(new uint[2]
								{
									array14[0, 0],
									array14[0, 1]
								}, array14[length - 1, 0], array14[length - 1, 1]);
								num45 += Class64.smethod_19(Class46.characterSyncSnapshot_1.uint_4, array14[length - 1, 0], array14[length - 1, 1]);
								num46 = Class64.smethod_19(array, array15[0, 0], array15[0, 1]);
								num46 += Class64.smethod_19(new uint[2]
								{
									array15[0, 0],
									array15[0, 1]
								}, array15[length2 - 1, 0], array15[length2 - 1, 1]);
								num46 += Class64.smethod_19(Class46.characterSyncSnapshot_1.uint_4, array15[length2 - 1, 0], array15[length2 - 1, 1]);
							}
							else
							{
								num45 = Class64.smethod_19(array, array14[length - 1, 0], array14[length - 1, 1]);
								num45 += Class64.smethod_19(new uint[2]
								{
									array14[0, 0],
									array14[0, 1]
								}, array14[length - 1, 0], array14[length - 1, 1]);
								num45 += Class64.smethod_19(Class46.characterSyncSnapshot_1.uint_4, array14[0, 0], array14[0, 1]);
								num46 = Class64.smethod_19(array, array15[length2 - 1, 0], array15[length2 - 1, 1]);
								num46 += Class64.smethod_19(new uint[2]
								{
									array15[0, 0],
									array15[0, 1]
								}, array15[length2 - 1, 0], array15[length2 - 1, 1]);
								num46 += Class64.smethod_19(Class46.characterSyncSnapshot_1.uint_4, array15[0, 0], array15[0, 1]);
							}
							array13 = ((num45 > num46) ? array15 : array14);
							uint[] array16 = new uint[2]
							{
								array13[0, 0],
								array13[0, 1]
							};
							uint[] array17 = new uint[2]
							{
								array13[array13.GetLength(0) - 1, 0],
								array13[array13.GetLength(0) - 1, 1]
							};
							num30 = Class64.smethod_21(array13, array);
							if (num30 <= 300000L)
							{
								if (flag5)
								{
									Class64.smethod_22(characterAccountConfig_0, array13, array, array16, num9, bool_0: false, 6000, bool_1: true);
								}
								else
								{
									Class64.smethod_22(characterAccountConfig_0, array13, array, array17, num9, bool_0: false, 6000, bool_1: true);
								}
								return -3;
							}
							if (flag5)
							{
								array11[0] = array17[0];
								array11[1] = array17[1];
							}
							else
							{
								array11[0] = array16[0];
								array11[1] = array16[1];
							}
						}
					}
					if (!Class13.smethod_3(characterAccountConfig_0) || Class11.smethod_28(long_2) > 4000L)
					{
						int_7++;
						Class13.smethod_1(characterAccountConfig_0, array11);
						Thread.Sleep(600);
						long_2 = Class11.smethod_27();
					}
					return -3;
				}
				Class13.smethod_2(characterAccountConfig_0, bool_0: false);
				Class75.smethod_61(characterAccountConfig_0, Class46.characterSyncSnapshot_1.uint_4);
				Thread.Sleep(100);
				return 2;
			}
			Class13.smethod_2(characterAccountConfig_0, bool_0: false);
			if (num30 > 20000L)
			{
				Class75.smethod_61(characterAccountConfig_0, Class46.characterSyncSnapshot_1.uint_4);
				Thread.Sleep(100);
			}
			int_7 = 0;
			uint_0 = null;
			return 4;
		}
		return 1;
		IL_0b64:
		Class95.smethod_8(characterAccountConfig_0);
		return -9;
		IL_0cfc:
		num8 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
		if (num8 > 0)
		{
			bool_10 = true;
		}
		if (gStruct.uint_0 == null)
		{
			int num47 = Class95.smethod_0(characterAccountConfig_0);
			Class75.smethod_59(characterAccountConfig_0, 0, Convert.ToByte(num47 != 0));
			return 12;
		}
		int int_14 = 0;
		int int_15 = characterAccountConfig_0.int_137;
		uint uint_8 = num4 + Class56.memorySignatureScanConfig_72.uint_0;
		byte_ = new byte[4];
		Class24.WriteProcessMemory(int_15, uint_8, byte_, 4, ref int_14);
		array = new uint[2]
		{
			Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
			Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
		};
		int num48 = 0;
		if (gStruct.uint_0.GetLength(0) > 1)
		{
			num48 = Class64.smethod_20(gStruct.uint_0, array);
		}
		Class64.smethod_8(gStruct.uint_0, num48, ref uint_2, ref uint_3, ref num12);
		long num49 = Class64.smethod_18(array, uint_2);
		if (num49 > 90000L)
		{
			if (uint_0 == null)
			{
				uint_0 = new uint[2]
				{
					array[0],
					array[1]
				};
				int_7 = 0;
			}
			if (int_7 > 6)
			{
				bool flag7 = uint_0 != null && Class64.smethod_18(uint_0, array) < 180000L;
				uint_0 = null;
				int_7 = 0;
				if (flag7)
				{
					Class64.smethod_2(characterAccountConfig_0, array, uint_2, 600);
					return -1;
				}
			}
			Class64.smethod_29(characterAccountConfig_0, bool_0: false);
			if (!Class13.smethod_3(characterAccountConfig_0) || Class11.smethod_28(long_2) > 3000L)
			{
				int_7++;
				Class13.smethod_1(characterAccountConfig_0, uint_2);
				long_2 = Class11.smethod_27();
			}
			return -4;
		}
		int_7 = 0;
		uint_0 = null;
		Class64.smethod_23(characterAccountConfig_0, uint_2, num12, uint_3, gStruct.int_1);
		return -4;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns121.AuxiliaryMachineManager));
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.comboBoxThemAcc = new System.Windows.Forms.ComboBox();
		this.buttonThemAcc = new System.Windows.Forms.Button();
		this.buttonXoaAcc = new System.Windows.Forms.Button();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.label1 = new System.Windows.Forms.Label();
		this.buttonClose = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader_0, this.columnHeader_1 });
		this.listView1.ForeColor = System.Drawing.Color.Black;
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(9, 48);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(265, 243);
		this.listView1.TabIndex = 2;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "No";
		this.columnHeader_0.Width = 40;
		this.columnHeader_1.Text = "Tên nhân vật";
		this.columnHeader_1.Width = 200;
		this.comboBoxThemAcc.DropDownWidth = 120;
		this.comboBoxThemAcc.ForeColor = System.Drawing.Color.Black;
		this.comboBoxThemAcc.FormattingEnabled = true;
		this.comboBoxThemAcc.Location = new System.Drawing.Point(9, 299);
		this.comboBoxThemAcc.Name = "comboBoxThemAcc";
		this.comboBoxThemAcc.Size = new System.Drawing.Size(178, 21);
		this.comboBoxThemAcc.TabIndex = 63;
		this.comboBoxThemAcc.DropDown += new System.EventHandler(comboBoxThemAcc_DropDown);
		this.buttonThemAcc.ForeColor = System.Drawing.Color.Black;
		this.buttonThemAcc.Location = new System.Drawing.Point(9, 326);
		this.buttonThemAcc.Name = "buttonThemAcc";
		this.buttonThemAcc.Size = new System.Drawing.Size(178, 26);
		this.buttonThemAcc.TabIndex = 64;
		this.buttonThemAcc.Text = "Thêm tên ac vào danh sách";
		this.buttonThemAcc.UseVisualStyleBackColor = true;
		this.buttonThemAcc.Click += new System.EventHandler(buttonThemAcc_Click);
		this.buttonXoaAcc.ForeColor = System.Drawing.Color.Black;
		this.buttonXoaAcc.Location = new System.Drawing.Point(193, 297);
		this.buttonXoaAcc.Name = "buttonXoaAcc";
		this.buttonXoaAcc.Size = new System.Drawing.Size(79, 23);
		this.buttonXoaAcc.TabIndex = 65;
		this.buttonXoaAcc.Text = "Xóa";
		this.buttonXoaAcc.UseVisualStyleBackColor = true;
		this.buttonXoaAcc.Click += new System.EventHandler(buttonXoaAcc_Click);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.label1.Location = new System.Drawing.Point(6, 5);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(268, 40);
		this.label1.TabIndex = 69;
		this.label1.Text = "Danh sách ac máy phụ cần thông báo, danh sách nếu càng ít thì tốc độ thông báo càng nhanh, do đó ac nào trong danh sách không online thì xóa đi nhé.";
		this.buttonClose.ForeColor = System.Drawing.Color.Black;
		this.buttonClose.Location = new System.Drawing.Point(193, 326);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(79, 26);
		this.buttonClose.TabIndex = 70;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(284, 359);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.listView1);
		base.Controls.Add(this.comboBoxThemAcc);
		base.Controls.Add(this.buttonThemAcc);
		base.Controls.Add(this.buttonXoaAcc);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "AuxiliaryMachineManager";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "DANH SACH AC MAY PHU";
		base.Load += new System.EventHandler(AuxiliaryMachineManager_Load);
		base.ResumeLayout(false);
	}
}
