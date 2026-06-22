using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns145;
using ns16;
using ns35;
using ns36;
using ns53;
using ns66;
using ns83;

namespace ns126;

public class FormPhongKy1 : Form
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	public static int int_4 = 0;

	public static bool bool_1 = false;

	public static bool bool_2 = false;

	public static bool bool_3 = false;

	public static bool bool_4 = false;

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Button buttonXoaPk2;

	private Button buttonXoaPk;

	private Label label23;

	private Button buttonStopWritePathPk2;

	private Button buttonWritePathPk2;

	private Button buttonSavePathPk2;

	private Button buttonOpenPathPk2;

	private ListView listViewPk2;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private Button buttonStopWritePathPk;

	private Label label22;

	private Button buttonWritePathPk;

	private ListView listViewPk1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private Button buttonSavePathPk;

	private Button buttonOpenPathPk;

	private Button buttonXoahet1;

	private Button buttonXoahet2;

	public FormPhongKy1()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		if (bool_2 || bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (0 <= num)
			{
				if (Form1.characterAccountConfig_1[num].string_3 != null)
				{
					Class38.smethod_50(Form1.characterAccountConfig_1[num], Form1.characterAccountConfig_1[num].string_3);
				}
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
		bool_1 = false;
		bool_2 = false;
		bool_3 = false;
		bool_4 = false;
		bool_0 = false;
	}

	private void FormPhongKy1_Load(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (Class11.bool_0 || num < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[num];
		if (int_0 >= 0 && int_1 >= 0)
		{
			int num2 = int_0 - base.Width;
			int num3 = int_1 + int_3 - base.Height;
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			SetBounds(num2, num3, base.Width, base.Height);
		}
		listViewPk1.Items.Clear();
		if (characterAccountConfig.uint_2 != null)
		{
			for (int i = 0; i < characterAccountConfig.uint_2.GetLength(0); i++)
			{
				method_0(listViewPk1, new uint[2]
				{
					characterAccountConfig.uint_2[i, 0],
					characterAccountConfig.uint_2[i, 1]
				});
			}
		}
		listViewPk2.Items.Clear();
		if (characterAccountConfig.uint_3 != null)
		{
			for (int j = 0; j < characterAccountConfig.uint_3.GetLength(0); j++)
			{
				method_0(listViewPk2, new uint[2]
				{
					characterAccountConfig.uint_3[j, 0],
					characterAccountConfig.uint_3[j, 1]
				});
			}
		}
		buttonStopWritePathPk.Enabled = false;
		buttonStopWritePathPk2.Enabled = false;
		timer_0.Interval = 100;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void method_0(ListView listView_0, uint[] uint_0)
	{
		try
		{
			int num = 0;
			if (listView_0.Items != null)
			{
				num = listView_0.Items.Count;
			}
			string[] array = new string[2]
			{
				num.ToString(),
				uint_0[0] + "," + uint_0[1]
			};
			ListViewItem listViewItem = new ListViewItem(array[0]);
			ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[1]);
			listViewItem.SubItems.Add(item);
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
			if (bool_3)
			{
				bool_3 = false;
				if (bool_1)
				{
					method_1();
				}
			}
			if (bool_4)
			{
				bool_4 = false;
				if (bool_2)
				{
					method_2();
				}
			}
		}
		else
		{
			Close();
		}
	}

	private void method_1()
	{
		if (bool_2 || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
		int num2 = Class39.smethod_0(characterAccountConfig_);
		if (num2 != characterAccountConfig_.int_35 && characterAccountConfig_.int_35 > 0)
		{
			listViewPk1.Items.Clear();
			Form1.characterAccountConfig_1[num].uint_2 = null;
		}
		Form1.characterAccountConfig_1[num].int_35 = num2;
		uint[] array = Class38.smethod_30(characterAccountConfig_);
		if (characterAccountConfig_.uint_2 != null)
		{
			for (int i = 0; i < characterAccountConfig_.uint_2.GetLength(0); i++)
			{
				if (characterAccountConfig_.uint_2[i, 0] == array[0] && characterAccountConfig_.uint_2[i, 1] == array[1])
				{
					return;
				}
			}
		}
		Class11.smethod_55(ref Form1.characterAccountConfig_1[num].uint_2, array);
		method_0(listViewPk1, array);
		method_3(listViewPk1, listViewPk1.Items.Count - 1);
		Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		string string_ = "#" + (Form1.characterAccountConfig_1[num].uint_2.GetLength(0) - 1) + " (" + array[0] + "," + array[1] + ")";
		Class38.smethod_50(characterAccountConfig_, string_);
	}

	private void method_2()
	{
		if (!bool_2 || bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
		int num2 = Class39.smethod_0(characterAccountConfig_);
		if (num2 != characterAccountConfig_.int_36 && characterAccountConfig_.int_36 > 0)
		{
			listViewPk2.Items.Clear();
			Form1.characterAccountConfig_1[num].uint_3 = null;
		}
		Form1.characterAccountConfig_1[num].int_36 = num2;
		characterAccountConfig_ = Form1.characterAccountConfig_1[num];
		uint[] array = Class38.smethod_30(characterAccountConfig_);
		if (characterAccountConfig_.uint_3 != null)
		{
			for (int i = 0; i < characterAccountConfig_.uint_3.GetLength(0); i++)
			{
				if (characterAccountConfig_.uint_3[i, 0] == array[0] && characterAccountConfig_.uint_3[i, 1] == array[1])
				{
					return;
				}
			}
		}
		Class11.smethod_55(ref Form1.characterAccountConfig_1[num].uint_3, array);
		method_0(listViewPk2, array);
		method_3(listViewPk2, listViewPk2.Items.Count - 1);
		Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		string string_ = "##" + (Form1.characterAccountConfig_1[num].uint_3.GetLength(0) - 1) + " (" + array[0] + "," + array[1] + ")";
		Class38.smethod_50(characterAccountConfig_, string_);
	}

	private void buttonOpenPathPk_Click(object sender, EventArgs e)
	{
		string text = Class56.string_8 + "\\Toado";
		Class11.smethod_23(text);
		string text2 = Class56.smethod_26(text, "", "*.pxy");
		if (text2 == string.Empty)
		{
			return;
		}
		int num = (num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4));
		if (num >= 0)
		{
			listViewPk1.Items.Clear();
			string text3 = Class11.smethod_15(Class11.smethod_33(text2, 0, 0, 1));
			if (!(text3 == string.Empty))
			{
				string[] array = text3.Split('|');
				if (array.Length == 2)
				{
					int num2 = Class11.smethod_11(array[0]);
					if (num2 != 0)
					{
						if (num2 < 387 || num2 > 389)
						{
							Class11.smethod_29(ref Class11.string_17, "FORM:Thông báo: Tệp Tọa độ này không phải của map Phong kỳ.");
						}
						Form1.characterAccountConfig_1[num].int_35 = num2;
						Form1.characterAccountConfig_1[num].uint_2 = null;
						string[] array2 = array[1].Split(':');
						if (array2 != null && array2.Length != 0)
						{
							Form1.characterAccountConfig_1[num].uint_2 = new uint[array2.Length, 2];
							for (int i = 0; i < array2.Length; i++)
							{
								string[] array3 = array2[i].Split(';');
								if (array3.Length == 2)
								{
									for (int j = 0; j < 2; j++)
									{
										Form1.characterAccountConfig_1[num].uint_2[i, j] = Class11.smethod_12(array3[j]);
									}
								}
								method_0(listViewPk1, new uint[2]
								{
									Form1.characterAccountConfig_1[num].uint_2[i, 0],
									Form1.characterAccountConfig_1[num].uint_2[i, 1]
								});
							}
						}
						Class69.int_0 = Form1.characterAccountConfig_1[num].int_136;
						return;
					}
				}
			}
			Form1.characterAccountConfig_1[num].int_35 = 0;
			Form1.characterAccountConfig_1[num].uint_2 = null;
			Class69.int_0 = Form1.characterAccountConfig_1[num].int_136;
		}
		else
		{
			Close();
		}
	}

	private void buttonOpenPathPk2_Click(object sender, EventArgs e)
	{
		string text = Class56.string_8 + "\\Toado";
		Class11.smethod_23(text);
		string text2 = Class56.smethod_26(text, "", "*.txy");
		if (text2 == string.Empty)
		{
			return;
		}
		int num = (num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4));
		if (num >= 0)
		{
			listViewPk2.Items.Clear();
			string text3 = Class11.smethod_15(Class11.smethod_33(text2, 0, 0, 1));
			if (!(text3 == string.Empty))
			{
				string[] array = text3.Split('|');
				if (array.Length == 2)
				{
					int num2 = Class11.smethod_11(array[0]);
					if (num2 != 0)
					{
						if (num2 < 387 || num2 > 389)
						{
							Class11.smethod_29(ref Class11.string_17, "FORM:Thông báo: Tệp Tọa độ này không phải của map Phong kỳ.");
						}
						Form1.characterAccountConfig_1[num].int_36 = num2;
						Form1.characterAccountConfig_1[num].uint_3 = null;
						string[] array2 = array[1].Split(':');
						if (array2 != null && array2.Length != 0)
						{
							Form1.characterAccountConfig_1[num].uint_3 = new uint[array2.Length, 2];
							for (int i = 0; i < array2.Length; i++)
							{
								string[] array3 = array2[i].Split(';');
								if (array3.Length == 2)
								{
									for (int j = 0; j < 2; j++)
									{
										Form1.characterAccountConfig_1[num].uint_3[i, j] = Class11.smethod_12(array3[j]);
									}
								}
								method_0(listViewPk2, new uint[2]
								{
									Form1.characterAccountConfig_1[num].uint_3[i, 0],
									Form1.characterAccountConfig_1[num].uint_3[i, 1]
								});
							}
						}
						Class69.int_0 = Form1.characterAccountConfig_1[num].int_136;
						return;
					}
				}
			}
			Form1.characterAccountConfig_1[num].int_36 = 0;
			Form1.characterAccountConfig_1[num].uint_3 = null;
			Class69.int_0 = Form1.characterAccountConfig_1[num].int_136;
		}
		else
		{
			Close();
		}
	}

	private void buttonSavePathPk_Click(object sender, EventArgs e)
	{
		int num = (num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4));
		if (num >= 0)
		{
			CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[num];
			string text = Class56.string_8 + "\\Toado";
			Class11.smethod_23(text);
			string text2 = Class56.smethod_27(text, Class1.smethod_1(characterAccountConfig.string_22, 1) + ".pxy");
			if (text2 == string.Empty)
			{
				return;
			}
			string text3 = string.Empty;
			if (characterAccountConfig.uint_2 != null)
			{
				for (int i = 0; i < characterAccountConfig.uint_2.GetLength(0); i++)
				{
					if (text3 != string.Empty)
					{
						text3 += ":";
					}
					object obj = text3;
					text3 = string.Concat(obj, characterAccountConfig.uint_2[i, 0], ";", characterAccountConfig.uint_2[i, 1]);
				}
			}
			string string_ = characterAccountConfig.int_35 + "|" + text3;
			Class11.smethod_34(text2, Class11.smethod_16(string_), 2);
		}
		else
		{
			Close();
		}
	}

	private void buttonSavePathPk2_Click(object sender, EventArgs e)
	{
		int num = (num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4));
		if (num >= 0)
		{
			CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[num];
			string text = Class56.string_8 + "\\Toado";
			Class11.smethod_23(text);
			string text2 = Class56.smethod_27(text, Class1.smethod_1(characterAccountConfig.string_22, 1) + ".txy");
			if (text2 == string.Empty)
			{
				return;
			}
			string text3 = string.Empty;
			if (characterAccountConfig.uint_3 != null)
			{
				for (int i = 0; i < characterAccountConfig.uint_3.GetLength(0); i++)
				{
					if (text3 != string.Empty)
					{
						text3 += ":";
					}
					object obj = text3;
					text3 = string.Concat(obj, characterAccountConfig.uint_3[i, 0], ";", characterAccountConfig.uint_3[i, 1]);
				}
			}
			string string_ = characterAccountConfig.int_36 + "|" + text3;
			Class11.smethod_34(text2, Class11.smethod_16(string_), 2);
		}
		else
		{
			Close();
		}
	}

	private void buttonWritePathPk_Click(object sender, EventArgs e)
	{
		int num = (num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4));
		if (num < 0)
		{
			Close();
		}
		else if (!bool_2 && !bool_1)
		{
			bool_1 = true;
			buttonWritePathPk.Enabled = false;
			buttonStopWritePathPk.Enabled = true;
			Form1.characterAccountConfig_1[num].string_3 = Class38.smethod_49(Form1.characterAccountConfig_1[num]);
			Class38.smethod_50(Form1.characterAccountConfig_1[num], "BÊm Space ®Ó ghi ®\u00adêng dÉn");
			GClass0.smethod_1();
			GClass0.smethod_0();
		}
	}

	private void buttonWritePathPk2_Click(object sender, EventArgs e)
	{
		int num = (num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4));
		if (num >= 0)
		{
			if (!bool_1 && !bool_2)
			{
				bool_2 = true;
				buttonWritePathPk2.Enabled = false;
				buttonStopWritePathPk2.Enabled = true;
				Form1.characterAccountConfig_1[num].string_3 = Class38.smethod_49(Form1.characterAccountConfig_1[num]);
				Class38.smethod_50(Form1.characterAccountConfig_1[num], "BÊm Space ®Ó ghi to¹ ®é");
				GClass0.smethod_1();
				GClass0.smethod_0();
			}
		}
		else
		{
			Close();
		}
	}

	private void buttonStopWritePathPk_Click(object sender, EventArgs e)
	{
		int num = (num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4));
		if (num >= 0)
		{
			buttonWritePathPk.Enabled = true;
			buttonStopWritePathPk.Enabled = false;
			if (bool_1 && Form1.characterAccountConfig_1[num].string_3 != null)
			{
				Class38.smethod_50(Form1.characterAccountConfig_1[num], Form1.characterAccountConfig_1[num].string_3);
			}
			bool_1 = false;
		}
		else
		{
			Close();
		}
	}

	private void buttonStopWritePathPk2_Click(object sender, EventArgs e)
	{
		int num = (num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4));
		if (num >= 0)
		{
			buttonWritePathPk2.Enabled = true;
			buttonStopWritePathPk2.Enabled = false;
			if (bool_2 && Form1.characterAccountConfig_1[num].string_3 != null)
			{
				Class38.smethod_50(Form1.characterAccountConfig_1[num], Form1.characterAccountConfig_1[num].string_3);
			}
			bool_2 = false;
		}
		else
		{
			Close();
		}
	}

	private void method_3(ListView listView_0, int int_5 = 0)
	{
		if (listView_0.Items == null)
		{
			return;
		}
		int count = listView_0.Items.Count;
		if (count != 0)
		{
			if (int_5 >= count)
			{
				int_5 = count - 1;
			}
			listView_0.TopItem = listView_0.Items[int_5];
			listView_0.Items[int_5].Focused = true;
			listView_0.Items[int_5].Selected = true;
		}
	}

	private void buttonXoaPk_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			Close();
			return;
		}
		CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[num];
		if (listViewPk1.Items != null && listViewPk1.Items.Count > 0 && characterAccountConfig.uint_2 != null && characterAccountConfig.uint_2.GetLength(0) != 0)
		{
			int num2 = -1;
			for (int i = 0; i < listViewPk1.Items.Count; i++)
			{
				if (listViewPk1.Items[i].Selected)
				{
					num2 = i;
					break;
				}
			}
			if (num2 < 0)
			{
				return;
			}
			string[] array = listViewPk1.Items[num2].SubItems[1].Text.Split(',');
			if (array.Length < 2)
			{
				return;
			}
			uint num3 = Class11.smethod_12(array[0]);
			uint num4 = Class11.smethod_12(array[1]);
			int num5 = 0;
			uint[,] array2 = new uint[characterAccountConfig.uint_2.GetLength(0), 2];
			for (int j = 0; j < characterAccountConfig.uint_2.GetLength(0); j++)
			{
				if (characterAccountConfig.uint_2[j, 0] != num3 && characterAccountConfig.uint_2[j, 1] != num4)
				{
					array2[num5, 0] = characterAccountConfig.uint_2[j, 0];
					array2[num5, 1] = characterAccountConfig.uint_2[j, 1];
					num5++;
				}
			}
			if (num5 != 0)
			{
				if (num5 == characterAccountConfig.uint_2.GetLength(0))
				{
					return;
				}
				try
				{
					Class69.int_0 = Form1.characterAccountConfig_1[num].int_136;
					Form1.characterAccountConfig_1[num].uint_2 = new uint[num5, 2];
					for (int k = 0; k < num5; k++)
					{
						Form1.characterAccountConfig_1[num].uint_2[k, 0] = array2[k, 0];
						Form1.characterAccountConfig_1[num].uint_2[k, 1] = array2[k, 1];
					}
				}
				catch
				{
					num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
					if (num < 0)
					{
						Close();
						return;
					}
				}
				listViewPk1.Items.RemoveAt(num2);
				for (int l = 0; l < listViewPk1.Items.Count; l++)
				{
					listViewPk1.Items[l].SubItems[0].Text = l.ToString();
				}
				if (listViewPk1.Items.Count <= num2)
				{
					if (num2 == 0)
					{
						Form1.characterAccountConfig_1[num].uint_2 = null;
						listViewPk1.Items.Clear();
						return;
					}
					num2 = listViewPk1.Items.Count - 1;
				}
				method_3(listViewPk1, num2);
			}
			else
			{
				Form1.characterAccountConfig_1[num].uint_2 = null;
				listViewPk1.Items.Clear();
			}
		}
		else
		{
			Form1.characterAccountConfig_1[num].uint_2 = null;
			listViewPk1.Items.Clear();
		}
	}

	private void buttonXoaPk2_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num >= 0)
		{
			CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[num];
			if (listViewPk2.Items != null && listViewPk2.Items.Count > 0 && characterAccountConfig.uint_3 != null && characterAccountConfig.uint_3.GetLength(0) != 0)
			{
				int num2 = -1;
				for (int i = 0; i < listViewPk2.Items.Count; i++)
				{
					if (listViewPk2.Items[i].Selected)
					{
						num2 = i;
						break;
					}
				}
				if (num2 < 0)
				{
					return;
				}
				string[] array = listViewPk2.Items[num2].SubItems[1].Text.Split(',');
				if (array.Length < 2)
				{
					return;
				}
				uint num3 = Class11.smethod_12(array[0]);
				uint num4 = Class11.smethod_12(array[1]);
				int num5 = 0;
				uint[,] array2 = new uint[characterAccountConfig.uint_3.GetLength(0), 2];
				for (int j = 0; j < characterAccountConfig.uint_3.GetLength(0); j++)
				{
					if (characterAccountConfig.uint_3[j, 0] != num3 && characterAccountConfig.uint_3[j, 1] != num4)
					{
						array2[num5, 0] = characterAccountConfig.uint_3[j, 0];
						array2[num5, 1] = characterAccountConfig.uint_3[j, 1];
						num5++;
					}
				}
				if (num5 == 0)
				{
					Form1.characterAccountConfig_1[num].uint_3 = null;
					listViewPk2.Items.Clear();
				}
				else
				{
					if (num5 == characterAccountConfig.uint_3.GetLength(0))
					{
						return;
					}
					try
					{
						Class69.int_0 = Form1.characterAccountConfig_1[num].int_136;
						Form1.characterAccountConfig_1[num].uint_3 = new uint[num5, 2];
						for (int k = 0; k < num5; k++)
						{
							Form1.characterAccountConfig_1[num].uint_3[k, 0] = array2[k, 0];
							Form1.characterAccountConfig_1[num].uint_3[k, 1] = array2[k, 1];
						}
					}
					catch
					{
						num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
						if (num < 0)
						{
							Close();
							return;
						}
					}
					listViewPk2.Items.RemoveAt(num2);
					for (int l = 0; l < listViewPk2.Items.Count; l++)
					{
						listViewPk2.Items[l].SubItems[0].Text = l.ToString();
					}
					if (listViewPk2.Items.Count <= num2)
					{
						if (num2 == 0)
						{
							Form1.characterAccountConfig_1[num].uint_3 = null;
							listViewPk2.Items.Clear();
							return;
						}
						num2 = listViewPk2.Items.Count - 1;
					}
					method_3(listViewPk2, num2);
				}
			}
			else
			{
				Form1.characterAccountConfig_1[num].uint_3 = null;
				listViewPk2.Items.Clear();
			}
		}
		else
		{
			Close();
		}
	}

	private void buttonXoahet1_Click(object sender, EventArgs e)
	{
		listViewPk1.Items.Clear();
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			Close();
		}
		else
		{
			Form1.characterAccountConfig_1[num].uint_2 = null;
		}
	}

	private void buttonXoahet2_Click(object sender, EventArgs e)
	{
		listViewPk2.Items.Clear();
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			Close();
		}
		else
		{
			Form1.characterAccountConfig_1[num].uint_3 = null;
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns126.FormPhongKy1));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonXoaPk2 = new System.Windows.Forms.Button();
		this.buttonXoaPk = new System.Windows.Forms.Button();
		this.label23 = new System.Windows.Forms.Label();
		this.listViewPk2 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.label22 = new System.Windows.Forms.Label();
		this.listViewPk1 = new System.Windows.Forms.ListView();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		this.buttonStopWritePathPk2 = new System.Windows.Forms.Button();
		this.buttonWritePathPk2 = new System.Windows.Forms.Button();
		this.buttonSavePathPk2 = new System.Windows.Forms.Button();
		this.buttonOpenPathPk2 = new System.Windows.Forms.Button();
		this.buttonStopWritePathPk = new System.Windows.Forms.Button();
		this.buttonWritePathPk = new System.Windows.Forms.Button();
		this.buttonSavePathPk = new System.Windows.Forms.Button();
		this.buttonOpenPathPk = new System.Windows.Forms.Button();
		this.buttonXoahet1 = new System.Windows.Forms.Button();
		this.buttonXoahet2 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonXoaPk2.Location = new System.Drawing.Point(246, 286);
		this.buttonXoaPk2.Name = "buttonXoaPk2";
		this.buttonXoaPk2.Size = new System.Drawing.Size(83, 23);
		this.buttonXoaPk2.TabIndex = 254;
		this.buttonXoaPk2.Text = "Xóa";
		this.buttonXoaPk2.UseVisualStyleBackColor = true;
		this.buttonXoaPk2.Click += new System.EventHandler(buttonXoaPk2_Click);
		this.buttonXoaPk.Location = new System.Drawing.Point(82, 286);
		this.buttonXoaPk.Name = "buttonXoaPk";
		this.buttonXoaPk.Size = new System.Drawing.Size(85, 23);
		this.buttonXoaPk.TabIndex = 253;
		this.buttonXoaPk.Text = "Xóa";
		this.buttonXoaPk.UseVisualStyleBackColor = true;
		this.buttonXoaPk.Click += new System.EventHandler(buttonXoaPk_Click);
		this.label23.AutoSize = true;
		this.label23.Location = new System.Drawing.Point(8, 9);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(113, 13);
		this.label23.TabIndex = 249;
		this.label23.Text = "#Đường dẫn ra tọa độ";
		this.listViewPk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listViewPk2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader_0, this.columnHeader_1 });
		this.listViewPk2.FullRowSelect = true;
		this.listViewPk2.GridLines = true;
		this.listViewPk2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listViewPk2.HideSelection = false;
		this.listViewPk2.Location = new System.Drawing.Point(175, 55);
		this.listViewPk2.MultiSelect = false;
		this.listViewPk2.Name = "listViewPk2";
		this.listViewPk2.Size = new System.Drawing.Size(155, 228);
		this.listViewPk2.TabIndex = 246;
		this.listViewPk2.UseCompatibleStateImageBehavior = false;
		this.listViewPk2.View = System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "N";
		this.columnHeader_0.Width = 35;
		this.columnHeader_1.Text = "Tọa độ";
		this.columnHeader_1.Width = 95;
		this.label22.AutoSize = true;
		this.label22.Location = new System.Drawing.Point(174, 9);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(122, 13);
		this.label22.TabIndex = 247;
		this.label22.Text = "##Tọa độ điểm trinh sát";
		this.listViewPk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listViewPk1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader_2, this.columnHeader_3 });
		this.listViewPk1.FullRowSelect = true;
		this.listViewPk1.GridLines = true;
		this.listViewPk1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listViewPk1.HideSelection = false;
		this.listViewPk1.Location = new System.Drawing.Point(12, 55);
		this.listViewPk1.MultiSelect = false;
		this.listViewPk1.Name = "listViewPk1";
		this.listViewPk1.Size = new System.Drawing.Size(155, 227);
		this.listViewPk1.TabIndex = 248;
		this.listViewPk1.UseCompatibleStateImageBehavior = false;
		this.listViewPk1.View = System.Windows.Forms.View.Details;
		this.columnHeader_2.Text = "N";
		this.columnHeader_2.Width = 35;
		this.columnHeader_3.Text = "Tọa độ";
		this.columnHeader_3.Width = 95;
		this.buttonStopWritePathPk2.Image = ns16.Class16.Bitmap_3;
		this.buttonStopWritePathPk2.Location = new System.Drawing.Point(299, 28);
		this.buttonStopWritePathPk2.Name = "buttonStopWritePathPk2";
		this.buttonStopWritePathPk2.Size = new System.Drawing.Size(30, 23);
		this.buttonStopWritePathPk2.TabIndex = 259;
		this.buttonStopWritePathPk2.UseVisualStyleBackColor = true;
		this.buttonStopWritePathPk2.Click += new System.EventHandler(buttonStopWritePathPk2_Click);
		this.buttonWritePathPk2.Image = ns16.Class16.Bitmap_2;
		this.buttonWritePathPk2.Location = new System.Drawing.Point(264, 28);
		this.buttonWritePathPk2.Name = "buttonWritePathPk2";
		this.buttonWritePathPk2.Size = new System.Drawing.Size(30, 23);
		this.buttonWritePathPk2.TabIndex = 258;
		this.buttonWritePathPk2.UseVisualStyleBackColor = true;
		this.buttonWritePathPk2.Click += new System.EventHandler(buttonWritePathPk2_Click);
		this.buttonSavePathPk2.Image = ns16.Class16.Bitmap_1;
		this.buttonSavePathPk2.Location = new System.Drawing.Point(210, 28);
		this.buttonSavePathPk2.Name = "buttonSavePathPk2";
		this.buttonSavePathPk2.Size = new System.Drawing.Size(30, 23);
		this.buttonSavePathPk2.TabIndex = 257;
		this.buttonSavePathPk2.UseVisualStyleBackColor = true;
		this.buttonSavePathPk2.Click += new System.EventHandler(buttonSavePathPk2_Click);
		this.buttonOpenPathPk2.Image = ns16.Class16.Bitmap_0;
		this.buttonOpenPathPk2.Location = new System.Drawing.Point(176, 28);
		this.buttonOpenPathPk2.Name = "buttonOpenPathPk2";
		this.buttonOpenPathPk2.Size = new System.Drawing.Size(30, 23);
		this.buttonOpenPathPk2.TabIndex = 256;
		this.buttonOpenPathPk2.UseVisualStyleBackColor = true;
		this.buttonOpenPathPk2.Click += new System.EventHandler(buttonOpenPathPk2_Click);
		this.buttonStopWritePathPk.Image = (System.Drawing.Image)resources.GetObject("buttonStopWritePathPk.Image");
		this.buttonStopWritePathPk.Location = new System.Drawing.Point(124, 28);
		this.buttonStopWritePathPk.Name = "buttonStopWritePathPk";
		this.buttonStopWritePathPk.Size = new System.Drawing.Size(30, 23);
		this.buttonStopWritePathPk.TabIndex = 255;
		this.buttonStopWritePathPk.UseVisualStyleBackColor = true;
		this.buttonStopWritePathPk.Click += new System.EventHandler(buttonStopWritePathPk_Click);
		this.buttonWritePathPk.Image = (System.Drawing.Image)resources.GetObject("buttonWritePathPk.Image");
		this.buttonWritePathPk.Location = new System.Drawing.Point(91, 28);
		this.buttonWritePathPk.Name = "buttonWritePathPk";
		this.buttonWritePathPk.Size = new System.Drawing.Size(30, 23);
		this.buttonWritePathPk.TabIndex = 252;
		this.buttonWritePathPk.UseVisualStyleBackColor = true;
		this.buttonWritePathPk.Click += new System.EventHandler(buttonWritePathPk_Click);
		this.buttonSavePathPk.Image = (System.Drawing.Image)resources.GetObject("buttonSavePathPk.Image");
		this.buttonSavePathPk.Location = new System.Drawing.Point(46, 28);
		this.buttonSavePathPk.Name = "buttonSavePathPk";
		this.buttonSavePathPk.Size = new System.Drawing.Size(30, 23);
		this.buttonSavePathPk.TabIndex = 251;
		this.buttonSavePathPk.UseVisualStyleBackColor = true;
		this.buttonSavePathPk.Click += new System.EventHandler(buttonSavePathPk_Click);
		this.buttonOpenPathPk.Image = (System.Drawing.Image)resources.GetObject("buttonOpenPathPk.Image");
		this.buttonOpenPathPk.Location = new System.Drawing.Point(12, 28);
		this.buttonOpenPathPk.Name = "buttonOpenPathPk";
		this.buttonOpenPathPk.Size = new System.Drawing.Size(30, 23);
		this.buttonOpenPathPk.TabIndex = 250;
		this.buttonOpenPathPk.UseVisualStyleBackColor = true;
		this.buttonOpenPathPk.Click += new System.EventHandler(buttonOpenPathPk_Click);
		this.buttonXoahet1.Location = new System.Drawing.Point(12, 286);
		this.buttonXoahet1.Name = "buttonXoahet1";
		this.buttonXoahet1.Size = new System.Drawing.Size(64, 23);
		this.buttonXoahet1.TabIndex = 260;
		this.buttonXoahet1.Text = "Xóa hết";
		this.buttonXoahet1.UseVisualStyleBackColor = true;
		this.buttonXoahet1.Click += new System.EventHandler(buttonXoahet1_Click);
		this.buttonXoahet2.Location = new System.Drawing.Point(175, 286);
		this.buttonXoahet2.Name = "buttonXoahet2";
		this.buttonXoahet2.Size = new System.Drawing.Size(65, 23);
		this.buttonXoahet2.TabIndex = 261;
		this.buttonXoahet2.Text = "Xóa hết";
		this.buttonXoahet2.UseVisualStyleBackColor = true;
		this.buttonXoahet2.Click += new System.EventHandler(buttonXoahet2_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(334, 315);
		base.Controls.Add(this.buttonXoahet2);
		base.Controls.Add(this.buttonXoahet1);
		base.Controls.Add(this.buttonXoaPk2);
		base.Controls.Add(this.buttonXoaPk);
		base.Controls.Add(this.label23);
		base.Controls.Add(this.buttonStopWritePathPk2);
		base.Controls.Add(this.buttonWritePathPk2);
		base.Controls.Add(this.buttonSavePathPk2);
		base.Controls.Add(this.buttonOpenPathPk2);
		base.Controls.Add(this.listViewPk2);
		base.Controls.Add(this.buttonStopWritePathPk);
		base.Controls.Add(this.label22);
		base.Controls.Add(this.buttonWritePathPk);
		base.Controls.Add(this.listViewPk1);
		base.Controls.Add(this.buttonSavePathPk);
		base.Controls.Add(this.buttonOpenPathPk);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormPhongKy1";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "TOA DO PHONG KY";
		base.Load += new System.EventHandler(FormPhongKy1_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
