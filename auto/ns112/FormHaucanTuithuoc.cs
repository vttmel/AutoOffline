using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns16;
using ns53;
using ns63;
using ns81;
using ns83;

namespace ns112;

public class FormHaucanTuithuoc : Form
{
	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static int int_1 = -1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	private int int_6 = -1;

	private static bool bool_1 = false;

	private static CharacterAccountConfig characterAccountConfig_0 = default(CharacterAccountConfig);

	private static string[] string_0 = null;

	private string[] string_1 = new string[2] { "không", "có" };

	private static string[] string_2 = null;

	private IContainer icontainer_0 = null;

	private CheckBox checkBoxCoNhapSoluong;

	private ComboBox comboBoxTenTuiMauHotro;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private Button buttonThem;

	private Button buttonXoa;

	private Button buttonClose;

	private System.Windows.Forms.Timer timer_0;

	private CheckBox checkBoxClickMenu;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private ColumnHeader columnHeader_4;

	private TextBox textBoxMothuocKhicon;

	private CheckBox checkBoxMoTheoThoigian;

	private CheckBox checkBoxMoTheoSoluong;

	private TextBox textBoxThoigian;

	private Button buttonAppAll;

	private CheckBox checkBoxTrangThai;

	private ColumnHeader columnHeader_5;

	private CheckBox checkBoxTamDung;

	private TextBox textBoxMenu;

	private Label label3;

	private TextBox textBoxSoluongMax;

	private Label label2;

	private CheckBox checkBoxKhongMo;

	private Panel panel1;

	private CheckBox checkBox1;

	private Label label1;

	private Label label4;

	private ComboBox comboBoxTenMau2;

	private Label label5;

	private Label label6;

	public FormHaucanTuithuoc()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool flag = false;
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (0 <= num)
		{
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			flag = true;
		}
		if (!flag && Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Class56.smethod_13(Form1.characterAccountConfig_1[i]);
			}
		}
		int_2 = 0;
		int_3 = 0;
		int_1 = -1;
		int_0 = 0;
		bool_0 = false;
	}

	private void FormHaucanTuithuoc_Load(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			Close();
			return;
		}
		characterAccountConfig_0 = Form1.characterAccountConfig_1[num];
		if (int_2 >= 0 && int_3 >= 0)
		{
			int num2 = int_2 - base.Width;
			int num3 = int_3 + int_5 - base.Height;
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
		textBoxSoluongMax.Text = Form1.int_16.ToString();
		checkBoxKhongMo.Checked = Form1.int_17 > 0;
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		bool_1 = true;
		base.TopMost = true;
	}

	private void method_0(GStruct36[] gstruct36_0)
	{
		listView1.Items.Clear();
		int_6 = -1;
		if (gstruct36_0 != null && gstruct36_0.Length != 0)
		{
			for (int i = 0; i < gstruct36_0.Length; i++)
			{
				method_2(listView1, gstruct36_0[i]);
			}
			int_6 = 0;
			listView1.Items[int_6].Focused = true;
			listView1.Items[int_6].Selected = true;
		}
	}

	private void method_1(GStruct36 gstruct36_0)
	{
		bool_1 = false;
		comboBoxTenTuiMauHotro.Text = Class1.smethod_1(gstruct36_0.string_0, 1);
		checkBoxMoTheoThoigian.Checked = gstruct36_0.int_1 > 0;
		textBoxThoigian.Text = gstruct36_0.int_4.ToString();
		checkBoxMoTheoSoluong.Checked = gstruct36_0.int_5 > 0;
		textBoxMothuocKhicon.Text = gstruct36_0.int_6.ToString();
		checkBoxClickMenu.Checked = gstruct36_0.int_8 > 0;
		checkBox1.Checked = gstruct36_0.int_0 > 0;
		comboBoxTenMau2.Text = Class1.smethod_1(gstruct36_0.string_1, 1);
		string text = "1,1";
		if (gstruct36_0.int_9 != null)
		{
			text = null;
			for (int i = 0; i < gstruct36_0.int_9.Length; i++)
			{
				if (text != null)
				{
					text += ",";
				}
				text += gstruct36_0.int_9[i];
			}
		}
		textBoxMenu.Text = text;
		checkBoxCoNhapSoluong.Checked = gstruct36_0.int_7 > 0;
		checkBoxTrangThai.Checked = gstruct36_0.int_2 > 0;
		checkBoxTamDung.Checked = gstruct36_0.int_3 > 0;
		checkBoxTamDung.Enabled = gstruct36_0.int_2 > 0;
		Thread.Sleep(100);
		bool_1 = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
		else
		{
			if (int_1 == int_0)
			{
				return;
			}
			int_1 = int_0;
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
			if (num >= 0)
			{
				buttonThem.Enabled = true;
				listView1.Enabled = true;
				characterAccountConfig_0 = Form1.characterAccountConfig_1[num];
				method_0(characterAccountConfig_0.gstruct36_0);
				int_6 = -1;
				if (characterAccountConfig_0.gstruct36_0 != null)
				{
					int_6 = 0;
					method_1(characterAccountConfig_0.gstruct36_0[0]);
				}
			}
			else
			{
				buttonThem.Enabled = false;
				listView1.Enabled = false;
			}
		}
	}

	private void method_2(ListView listView_0, GStruct36 gstruct36_0)
	{
		try
		{
			string text = gstruct36_0.int_6.ToString();
			if (gstruct36_0.int_5 > 0)
			{
				text = "* " + text;
			}
			string text2 = gstruct36_0.int_4.ToString();
			if (gstruct36_0.int_1 > 0)
			{
				text2 = "* " + text2;
			}
			string text3 = "không";
			if (gstruct36_0.int_8 > 0)
			{
				text3 = "có";
			}
			string[] array = new string[6]
			{
				Class1.smethod_1(gstruct36_0.string_0, 1),
				text,
				text2,
				string_1[Convert.ToByte(gstruct36_0.int_7 > 0)],
				text3,
				gstruct36_0.int_2.ToString()
			};
			ListViewItem listViewItem = new ListViewItem(array[0]);
			if (array.Length > 1)
			{
				for (int i = 1; i < array.Length; i++)
				{
					ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
					listViewItem.SubItems.Add(item);
				}
			}
			listView_0.Items.Add(listViewItem);
		}
		catch
		{
		}
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		int_6 = -1;
		if (listView1.Items == null || listView1.Items.Count == 0)
		{
			return;
		}
		string text = null;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				int_6 = i;
				text = listView1.Items[i].SubItems[0].Text;
				break;
			}
		}
		if (int_6 < 0 || text == null)
		{
			return;
		}
		if (text != comboBoxTenTuiMauHotro.Text)
		{
			comboBoxTenTuiMauHotro.Items.Clear();
			comboBoxTenTuiMauHotro.Items.Add(text);
			comboBoxTenTuiMauHotro.Text = text;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0 || Form1.characterAccountConfig_1[num].gstruct36_0 == null)
		{
			return;
		}
		for (int j = 0; j < Form1.characterAccountConfig_1[num].gstruct36_0.Length; j++)
		{
			if (Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[j].string_0, 1) == text)
			{
				method_1(Form1.characterAccountConfig_1[num].gstruct36_0[j]);
			}
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		string text = comboBoxTenTuiMauHotro.Text;
		comboBoxTenTuiMauHotro.Items.Clear();
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num >= 0 && Form1.characterAccountConfig_1[num].gstruct36_0 != null && Form1.characterAccountConfig_1[num].gstruct36_0.Length != 0)
		{
			if (Form1.characterAccountConfig_1[num].gstruct36_0.Length != 1)
			{
				GStruct36[] array = new GStruct36[Form1.characterAccountConfig_1[num].gstruct36_0.Length];
				int num2 = 0;
				for (int i = 0; i < Form1.characterAccountConfig_1[num].gstruct36_0.Length; i++)
				{
					if (!(Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[i].string_0, 1) != text))
					{
						continue;
					}
					array[num2].string_0 = Form1.characterAccountConfig_1[num].gstruct36_0[i].string_0;
					array[num2].int_5 = Form1.characterAccountConfig_1[num].gstruct36_0[i].int_5;
					array[num2].int_6 = Form1.characterAccountConfig_1[num].gstruct36_0[i].int_6;
					array[num2].int_1 = Form1.characterAccountConfig_1[num].gstruct36_0[i].int_1;
					array[num2].int_4 = Form1.characterAccountConfig_1[num].gstruct36_0[i].int_4;
					array[num2].int_7 = Form1.characterAccountConfig_1[num].gstruct36_0[i].int_7;
					array[num2].int_8 = Form1.characterAccountConfig_1[num].gstruct36_0[i].int_8;
					if (Form1.characterAccountConfig_1[num].gstruct36_0[i].int_9 != null)
					{
						array[num2].int_9 = new int[Form1.characterAccountConfig_1[num].gstruct36_0[i].int_9.Length];
						for (int j = 0; j < Form1.characterAccountConfig_1[num].gstruct36_0[i].int_9.Length; j++)
						{
							array[num2].int_9[j] = Form1.characterAccountConfig_1[num].gstruct36_0[i].int_9[j];
						}
					}
					num2++;
				}
				for (int k = 0; k < listView1.Items.Count; k++)
				{
					if (listView1.Items[k].SubItems[0].Text == text)
					{
						listView1.Items.RemoveAt(k);
						break;
					}
				}
				if (num2 != Form1.characterAccountConfig_1[num].gstruct36_0.Length)
				{
					Form1.characterAccountConfig_1[num].gstruct36_0 = new GStruct36[num2];
					for (int l = 0; l < num2; l++)
					{
						Form1.characterAccountConfig_1[num].gstruct36_0[l].string_0 = array[l].string_0;
						Form1.characterAccountConfig_1[num].gstruct36_0[l].int_5 = array[l].int_5;
						Form1.characterAccountConfig_1[num].gstruct36_0[l].int_6 = array[l].int_6;
						Form1.characterAccountConfig_1[num].gstruct36_0[l].int_1 = array[l].int_1;
						Form1.characterAccountConfig_1[num].gstruct36_0[l].int_4 = array[l].int_4;
						Form1.characterAccountConfig_1[num].gstruct36_0[l].int_7 = array[l].int_7;
						Form1.characterAccountConfig_1[num].gstruct36_0[l].int_8 = array[l].int_8;
						if (array[l].int_9 != null)
						{
							Form1.characterAccountConfig_1[num].gstruct36_0[l].int_9 = new int[array[l].int_9.Length];
							for (int m = 0; m < array[l].int_9.Length; m++)
							{
								Form1.characterAccountConfig_1[num].gstruct36_0[l].int_9[m] = array[l].int_9[m];
							}
						}
					}
					if (listView1.Items.Count <= int_6)
					{
						int_6--;
					}
					if (0 <= int_6)
					{
						listView1.Items[int_6].Focused = true;
						listView1.Items[int_6].Selected = true;
						method_1(Form1.characterAccountConfig_1[num].gstruct36_0[int_6]);
					}
				}
				else
				{
					int_6 = 0;
					listView1.Items[int_6].Focused = true;
					listView1.Items[int_6].Selected = true;
					method_1(Form1.characterAccountConfig_1[num].gstruct36_0[int_6]);
				}
			}
			else if (Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[0].string_0, 1) == text)
			{
				Form1.characterAccountConfig_1[num].gstruct36_0 = null;
				int_6 = -1;
				listView1.Items.Clear();
			}
		}
		else
		{
			if (listView1.Items.Count > 0)
			{
				listView1.Items.Clear();
			}
			int_6 = -1;
		}
	}

	private void comboBoxTenTuiMauHotro_MouseDown(object sender, MouseEventArgs e)
	{
		string_0 = Class85.smethod_34(characterAccountConfig_0);
		comboBoxTenTuiMauHotro.Items.Clear();
		if (string_0 != null)
		{
			Array.Sort(string_0);
			for (int i = 0; i < string_0.Length; i++)
			{
				comboBoxTenTuiMauHotro.Items.Add(Class1.smethod_1(string_0[i], 1));
			}
		}
	}

	private void checkBoxMoTheoSoluong_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = "0";
		string text2 = comboBoxTenTuiMauHotro.Text;
		if (Form1.characterAccountConfig_1[num].gstruct36_0 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1[num].gstruct36_0.Length; i++)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[i].string_0, 1) == text2)
				{
					Form1.characterAccountConfig_1[num].gstruct36_0[i].int_5 = Convert.ToByte(checkBoxMoTheoSoluong.Checked);
					text = Form1.characterAccountConfig_1[num].gstruct36_0[i].int_6.ToString();
					break;
				}
			}
		}
		if (checkBoxMoTheoSoluong.Checked)
		{
			text = "* " + text;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < listView1.Items.Count)
			{
				if (listView1.Items[num2].SubItems[0].Text == text2)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		listView1.Items[num2].SubItems[1].Text = text;
	}

	private void textBoxMothuocKhicon_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = "0";
		string text2 = comboBoxTenTuiMauHotro.Text;
		if (Form1.characterAccountConfig_1[num].gstruct36_0 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1[num].gstruct36_0.Length; i++)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[i].string_0, 1) == text2)
				{
					Form1.characterAccountConfig_1[num].gstruct36_0[i].int_6 = Class11.smethod_11(textBoxMothuocKhicon.Text);
					text = Form1.characterAccountConfig_1[num].gstruct36_0[i].int_6.ToString();
					break;
				}
			}
		}
		if (checkBoxMoTheoSoluong.Checked)
		{
			text = "* " + text;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < listView1.Items.Count)
			{
				if (listView1.Items[num2].SubItems[0].Text == text2)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		listView1.Items[num2].SubItems[1].Text = text;
	}

	private void checkBoxMoTheoThoigian_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = "0";
		string text2 = comboBoxTenTuiMauHotro.Text;
		if (Form1.characterAccountConfig_1[num].gstruct36_0 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1[num].gstruct36_0.Length; i++)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[i].string_0, 1) == text2)
				{
					Form1.characterAccountConfig_1[num].gstruct36_0[i].int_1 = Convert.ToByte(checkBoxMoTheoThoigian.Checked);
					text = Form1.characterAccountConfig_1[num].gstruct36_0[i].int_4.ToString();
					break;
				}
			}
		}
		if (checkBoxMoTheoThoigian.Checked)
		{
			text = "* " + text;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < listView1.Items.Count)
			{
				if (listView1.Items[num2].SubItems[0].Text == text2)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		listView1.Items[num2].SubItems[2].Text = text;
	}

	private void textBoxThoigian_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = "0";
		string text2 = comboBoxTenTuiMauHotro.Text;
		if (Form1.characterAccountConfig_1[num].gstruct36_0 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1[num].gstruct36_0.Length; i++)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[i].string_0, 1) == text2)
				{
					Form1.characterAccountConfig_1[num].gstruct36_0[i].int_4 = Class11.smethod_11(textBoxThoigian.Text);
					text = Form1.characterAccountConfig_1[num].gstruct36_0[i].int_4.ToString();
					break;
				}
			}
		}
		if (checkBoxMoTheoThoigian.Checked)
		{
			text = "* " + text;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < listView1.Items.Count)
			{
				if (listView1.Items[num2].SubItems[0].Text == text2)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		listView1.Items[num2].SubItems[2].Text = text;
	}

	private void checkBoxClickMenu_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenTuiMauHotro.Text;
		if (Form1.characterAccountConfig_1[num].gstruct36_0 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1[num].gstruct36_0.Length; i++)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[i].string_0, 1) == text)
				{
					Form1.characterAccountConfig_1[num].gstruct36_0[i].int_8 = Convert.ToByte(checkBoxClickMenu.Checked);
					break;
				}
			}
		}
		string text2 = "không";
		if (checkBoxClickMenu.Checked)
		{
			text2 = "có";
		}
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].SubItems[0].Text == text)
			{
				listView1.Items[i].SubItems[4].Text = text2;
				break;
			}
		}
	}

	private void checkBoxCoNhapSoluong_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenTuiMauHotro.Text;
		if (Form1.characterAccountConfig_1[num].gstruct36_0 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1[num].gstruct36_0.Length; i++)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[i].string_0, 1) == text)
				{
					Form1.characterAccountConfig_1[num].gstruct36_0[i].int_7 = Convert.ToByte(checkBoxCoNhapSoluong.Checked);
					break;
				}
			}
		}
		string text2 = string_1[Convert.ToByte(checkBoxCoNhapSoluong.Checked)];
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].SubItems[0].Text == text)
			{
				listView1.Items[i].SubItems[3].Text = text2;
				break;
			}
		}
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_0 == null)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		GStruct36 gstruct36_ = default(GStruct36);
		string text = comboBoxTenTuiMauHotro.Text;
		int num2 = Convert.ToByte(checkBox1.Checked);
		string text2 = string.Empty;
		if (num2 > 0 && string_2 != null)
		{
			string text3 = comboBoxTenMau2.Text;
			for (int i = 0; i < string_2.Length; i++)
			{
				if (text3 == Class1.smethod_1(string_2[i], 1))
				{
					text2 = string_2[i];
					break;
				}
			}
		}
		if (Form1.characterAccountConfig_1[num].gstruct36_0 != null)
		{
			for (int j = 0; j < Form1.characterAccountConfig_1[num].gstruct36_0.Length; j++)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[j].string_0, 1) == text)
				{
					string text4 = string.Empty;
					if (string_2 != null && string_2.Length > j && string_2[j] != null)
					{
						text4 = string_2[j];
					}
					Form1.characterAccountConfig_1[num].gstruct36_0[j].string_1 = text4;
				}
			}
		}
		for (int k = 0; k < string_0.Length; k++)
		{
			if (Class1.smethod_1(string_0[k], 1) == text)
			{
				gstruct36_.string_0 = string_0[k];
				gstruct36_.int_5 = Convert.ToByte(checkBoxMoTheoSoluong.Checked);
				gstruct36_.int_6 = Class11.smethod_11(textBoxMothuocKhicon.Text);
				gstruct36_.int_1 = Convert.ToByte(checkBoxMoTheoThoigian.Checked);
				gstruct36_.int_4 = Class11.smethod_11(textBoxThoigian.Text);
				gstruct36_.int_7 = Convert.ToByte(checkBoxCoNhapSoluong.Checked);
				gstruct36_.int_8 = Convert.ToByte(checkBoxClickMenu.Checked);
				gstruct36_.int_9 = Form1.smethod_2(textBoxMenu.Text);
				gstruct36_.int_2 = Convert.ToByte(checkBoxTrangThai.Checked);
				gstruct36_.int_3 = Convert.ToByte(checkBoxTamDung.Checked);
				gstruct36_.int_0 = Convert.ToByte(checkBox1.Checked);
				gstruct36_.string_1 = text2;
				break;
			}
		}
		if (gstruct36_.int_9 == null)
		{
			gstruct36_.int_9 = new int[2] { 1, 1 };
		}
		if (Form1.characterAccountConfig_1[num].gstruct36_0 != null && Form1.characterAccountConfig_1[num].gstruct36_0.Length != 0)
		{
			GStruct36[] array = new GStruct36[Form1.characterAccountConfig_1[num].gstruct36_0.Length + 1];
			for (int l = 0; l < Form1.characterAccountConfig_1[num].gstruct36_0.Length; l++)
			{
				if (!(gstruct36_.string_0 == Form1.characterAccountConfig_1[num].gstruct36_0[l].string_0))
				{
					array[l].string_0 = Form1.characterAccountConfig_1[num].gstruct36_0[l].string_0;
					array[l].int_5 = Form1.characterAccountConfig_1[num].gstruct36_0[l].int_5;
					array[l].int_6 = Form1.characterAccountConfig_1[num].gstruct36_0[l].int_6;
					array[l].int_1 = Form1.characterAccountConfig_1[num].gstruct36_0[l].int_1;
					array[l].int_4 = Form1.characterAccountConfig_1[num].gstruct36_0[l].int_4;
					array[l].int_7 = Form1.characterAccountConfig_1[num].gstruct36_0[l].int_7;
					array[l].int_8 = Form1.characterAccountConfig_1[num].gstruct36_0[l].int_8;
					if (Form1.characterAccountConfig_1[num].gstruct36_0[l].int_9 == null)
					{
						Form1.characterAccountConfig_1[num].gstruct36_0[l].int_9 = new int[2] { 1, 1 };
					}
					array[l].int_9 = new int[Form1.characterAccountConfig_1[num].gstruct36_0[l].int_9.Length];
					for (int m = 0; m < array[l].int_9.Length; m++)
					{
						array[l].int_9[m] = Form1.characterAccountConfig_1[num].gstruct36_0[l].int_9[m];
					}
					array[l].int_2 = Form1.characterAccountConfig_1[num].gstruct36_0[l].int_2;
					array[l].int_3 = Form1.characterAccountConfig_1[num].gstruct36_0[l].int_3;
					array[l].int_0 = Form1.characterAccountConfig_1[num].gstruct36_0[0].int_0;
					array[l].string_1 = Form1.characterAccountConfig_1[num].gstruct36_0[0].string_1;
					continue;
				}
				return;
			}
			int num3 = array.Length - 1;
			array[num3].string_0 = gstruct36_.string_0;
			array[num3].int_5 = gstruct36_.int_5;
			array[num3].int_6 = gstruct36_.int_6;
			array[num3].int_1 = gstruct36_.int_1;
			array[num3].int_4 = gstruct36_.int_4;
			array[num3].int_7 = gstruct36_.int_7;
			array[num3].int_8 = gstruct36_.int_8;
			if (gstruct36_.int_9 == null)
			{
				gstruct36_.int_9 = new int[2] { 1, 1 };
			}
			array[num3].int_9 = new int[gstruct36_.int_9.Length];
			for (int n = 0; n < gstruct36_.int_9.Length; n++)
			{
				array[num3].int_9[n] = gstruct36_.int_9[n];
			}
			array[num3].int_2 = gstruct36_.int_2;
			array[num3].int_3 = gstruct36_.int_3;
			array[num3].int_0 = gstruct36_.int_0;
			array[num3].string_1 = gstruct36_.string_1;
			Form1.characterAccountConfig_1[num].gstruct36_0 = new GStruct36[array.Length];
			for (int num4 = 0; num4 < Form1.characterAccountConfig_1[num].gstruct36_0.Length; num4++)
			{
				Form1.characterAccountConfig_1[num].gstruct36_0[num4].string_0 = array[num4].string_0;
				Form1.characterAccountConfig_1[num].gstruct36_0[num4].int_5 = array[num4].int_5;
				Form1.characterAccountConfig_1[num].gstruct36_0[num4].int_6 = array[num4].int_6;
				Form1.characterAccountConfig_1[num].gstruct36_0[num4].int_1 = array[num4].int_1;
				Form1.characterAccountConfig_1[num].gstruct36_0[num4].int_4 = array[num4].int_4;
				Form1.characterAccountConfig_1[num].gstruct36_0[num4].int_7 = array[num4].int_7;
				Form1.characterAccountConfig_1[num].gstruct36_0[num4].int_8 = array[num4].int_8;
				Form1.characterAccountConfig_1[num].gstruct36_0[num4].int_9 = new int[array[num4].int_9.Length];
				for (int num5 = 0; num5 < gstruct36_.int_9.Length; num5++)
				{
					Form1.characterAccountConfig_1[num].gstruct36_0[num4].int_9[num5] = array[num4].int_9[num5];
				}
				Form1.characterAccountConfig_1[num].gstruct36_0[num4].int_2 = array[num4].int_2;
				Form1.characterAccountConfig_1[num].gstruct36_0[num4].int_3 = array[num4].int_3;
				Form1.characterAccountConfig_1[num].gstruct36_0[num4].int_0 = array[num4].int_0;
				Form1.characterAccountConfig_1[num].gstruct36_0[num4].string_1 = array[num4].string_1;
			}
		}
		else
		{
			Form1.characterAccountConfig_1[num].gstruct36_0 = new GStruct36[1];
			Form1.characterAccountConfig_1[num].gstruct36_0[0].string_0 = gstruct36_.string_0;
			Form1.characterAccountConfig_1[num].gstruct36_0[0].int_5 = gstruct36_.int_5;
			Form1.characterAccountConfig_1[num].gstruct36_0[0].int_6 = gstruct36_.int_6;
			Form1.characterAccountConfig_1[num].gstruct36_0[0].int_1 = gstruct36_.int_1;
			Form1.characterAccountConfig_1[num].gstruct36_0[0].int_4 = gstruct36_.int_4;
			Form1.characterAccountConfig_1[num].gstruct36_0[0].int_7 = gstruct36_.int_7;
			Form1.characterAccountConfig_1[num].gstruct36_0[0].int_8 = gstruct36_.int_8;
			Form1.characterAccountConfig_1[num].gstruct36_0[0].int_9 = new int[gstruct36_.int_9.Length];
			for (int num6 = 0; num6 < gstruct36_.int_9.Length; num6++)
			{
				Form1.characterAccountConfig_1[num].gstruct36_0[0].int_9[num6] = gstruct36_.int_9[num6];
			}
			Form1.characterAccountConfig_1[num].gstruct36_0[0].int_2 = gstruct36_.int_2;
			Form1.characterAccountConfig_1[num].gstruct36_0[0].int_3 = gstruct36_.int_3;
			Form1.characterAccountConfig_1[num].gstruct36_0[0].int_0 = gstruct36_.int_0;
			Form1.characterAccountConfig_1[num].gstruct36_0[0].string_1 = gstruct36_.string_1;
			listView1.Items.Clear();
			int_6 = 0;
		}
		method_2(listView1, gstruct36_);
		if (0 <= int_6 && int_6 < listView1.Items.Count)
		{
			listView1.Items[int_6].Focused = true;
			listView1.Items[int_6].Selected = true;
		}
	}

	private void buttonAppAll_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0 || Form1.characterAccountConfig_1 == null)
		{
			return;
		}
		for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
		{
			if (i == num)
			{
				continue;
			}
			Form1.characterAccountConfig_1[i].gstruct36_0 = null;
			if (Form1.characterAccountConfig_1[num].gstruct36_0 == null || Form1.characterAccountConfig_1[num].gstruct36_0.Length == 0)
			{
				continue;
			}
			Form1.characterAccountConfig_1[i].gstruct36_0 = new GStruct36[Form1.characterAccountConfig_1[num].gstruct36_0.Length];
			for (int j = 0; j < Form1.characterAccountConfig_1[num].gstruct36_0.Length; j++)
			{
				Form1.characterAccountConfig_1[i].gstruct36_0[j].string_0 = Form1.characterAccountConfig_1[num].gstruct36_0[j].string_0;
				Form1.characterAccountConfig_1[i].gstruct36_0[j].int_5 = Form1.characterAccountConfig_1[num].gstruct36_0[j].int_5;
				Form1.characterAccountConfig_1[i].gstruct36_0[j].int_6 = Form1.characterAccountConfig_1[num].gstruct36_0[j].int_6;
				Form1.characterAccountConfig_1[i].gstruct36_0[j].int_1 = Form1.characterAccountConfig_1[num].gstruct36_0[j].int_1;
				Form1.characterAccountConfig_1[i].gstruct36_0[j].int_4 = Form1.characterAccountConfig_1[num].gstruct36_0[j].int_4;
				Form1.characterAccountConfig_1[i].gstruct36_0[j].int_8 = Form1.characterAccountConfig_1[num].gstruct36_0[j].int_8;
				if (Form1.characterAccountConfig_1[num].gstruct36_0[j].int_9 == null)
				{
					Form1.characterAccountConfig_1[num].gstruct36_0[j].int_9 = new int[2] { 1, 1 };
				}
				Form1.characterAccountConfig_1[i].gstruct36_0[j].int_9 = new int[Form1.characterAccountConfig_1[num].gstruct36_0[j].int_9.Length];
				for (int k = 0; k < Form1.characterAccountConfig_1[num].gstruct36_0[j].int_9.Length; k++)
				{
					Form1.characterAccountConfig_1[i].gstruct36_0[j].int_9[k] = Form1.characterAccountConfig_1[num].gstruct36_0[j].int_9[k];
				}
				Form1.characterAccountConfig_1[i].gstruct36_0[j].int_7 = Form1.characterAccountConfig_1[num].gstruct36_0[j].int_7;
				Form1.characterAccountConfig_1[i].gstruct36_0[j].int_2 = Form1.characterAccountConfig_1[num].gstruct36_0[j].int_2;
				Form1.characterAccountConfig_1[i].gstruct36_0[j].int_3 = Form1.characterAccountConfig_1[num].gstruct36_0[j].int_3;
				Form1.characterAccountConfig_1[i].gstruct36_0[j].int_0 = Form1.characterAccountConfig_1[num].gstruct36_0[j].int_0;
				Form1.characterAccountConfig_1[i].gstruct36_0[j].string_1 = Form1.characterAccountConfig_1[num].gstruct36_0[j].string_1;
				Class56.smethod_13(Form1.characterAccountConfig_1[i]);
			}
		}
	}

	private void checkBoxTrangThai_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = "0";
		string text2 = comboBoxTenTuiMauHotro.Text;
		int num2 = Convert.ToByte(checkBoxTrangThai.Checked);
		if (Form1.characterAccountConfig_1[num].gstruct36_0 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1[num].gstruct36_0.Length; i++)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[i].string_0, 1) == text2)
				{
					Form1.characterAccountConfig_1[num].gstruct36_0[i].int_2 = num2;
					text = num2.ToString();
					break;
				}
			}
		}
		for (int j = 0; j < listView1.Items.Count; j++)
		{
			if (listView1.Items[j].SubItems[0].Text == text2)
			{
				listView1.Items[j].SubItems[5].Text = text;
				break;
			}
		}
		checkBoxTamDung.Enabled = num2 > 0;
	}

	private void checkBoxTamDung_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenTuiMauHotro.Text;
		if (Form1.characterAccountConfig_1[num].gstruct36_0 == null)
		{
			return;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < Form1.characterAccountConfig_1[num].gstruct36_0.Length)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[num2].string_0, 1) == text)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		Form1.characterAccountConfig_1[num].gstruct36_0[num2].int_3 = Convert.ToByte(checkBoxTamDung.Checked);
	}

	private void textBoxMenu_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenTuiMauHotro.Text;
		if (Form1.characterAccountConfig_1[num].gstruct36_0 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1[num].gstruct36_0.Length; i++)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[i].string_0, 1) == text)
				{
					Form1.characterAccountConfig_1[num].gstruct36_0[i].int_9 = Form1.smethod_2(textBoxMenu.Text);
					break;
				}
			}
		}
		string text2 = "không";
		if (checkBoxClickMenu.Checked)
		{
			text2 = "có";
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < listView1.Items.Count)
			{
				if (listView1.Items[num2].SubItems[0].Text == text)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		listView1.Items[num2].SubItems[4].Text = text2;
	}

	private void textBoxSoluongMax_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_16 = Class11.smethod_11(textBoxSoluongMax.Text);
			Class66.smethod_11(Class66.smethod_1(), "SoluongThuocMoilanMo", Form1.int_16, "", 0);
		}
	}

	private void checkBoxKhongMo_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_17 = Convert.ToByte(checkBoxKhongMo.Checked);
			Class66.smethod_11(Class66.smethod_1(), "PCDKhongMoTui", Form1.int_17, "", 0);
		}
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenTuiMauHotro.Text;
		if (Form1.characterAccountConfig_1[num].gstruct36_0 == null)
		{
			return;
		}
		for (int i = 0; i < Form1.characterAccountConfig_1[num].gstruct36_0.Length; i++)
		{
			if (Class1.smethod_1(Form1.characterAccountConfig_1[num].gstruct36_0[i].string_0, 1) == text)
			{
				Form1.characterAccountConfig_1[num].gstruct36_0[i].int_0 = Convert.ToByte(checkBox1.Checked);
			}
		}
	}

	private void comboBoxTenMau2_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		bool_1 = false;
		string_2 = Class85.smethod_34(Form1.characterAccountConfig_1[num]);
		comboBoxTenMau2.Items.Clear();
		if (string_2 != null)
		{
			Array.Sort(string_2);
			for (int i = 0; i < string_2.Length; i++)
			{
				comboBoxTenMau2.Items.Add(Class1.smethod_1(string_2[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_1 = true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns112.FormHaucanTuithuoc));
		this.checkBoxCoNhapSoluong = new System.Windows.Forms.CheckBox();
		this.comboBoxTenTuiMauHotro = new System.Windows.Forms.ComboBox();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_4 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_5 = new System.Windows.Forms.ColumnHeader();
		this.buttonThem = new System.Windows.Forms.Button();
		this.buttonXoa = new System.Windows.Forms.Button();
		this.buttonClose = new System.Windows.Forms.Button();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.checkBoxClickMenu = new System.Windows.Forms.CheckBox();
		this.textBoxMothuocKhicon = new System.Windows.Forms.TextBox();
		this.checkBoxMoTheoThoigian = new System.Windows.Forms.CheckBox();
		this.checkBoxMoTheoSoluong = new System.Windows.Forms.CheckBox();
		this.textBoxThoigian = new System.Windows.Forms.TextBox();
		this.buttonAppAll = new System.Windows.Forms.Button();
		this.checkBoxTrangThai = new System.Windows.Forms.CheckBox();
		this.checkBoxTamDung = new System.Windows.Forms.CheckBox();
		this.textBoxMenu = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.textBoxSoluongMax = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.checkBoxKhongMo = new System.Windows.Forms.CheckBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.comboBoxTenMau2 = new System.Windows.Forms.ComboBox();
		this.label5 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.checkBoxCoNhapSoluong.AutoSize = true;
		this.checkBoxCoNhapSoluong.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxCoNhapSoluong.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
		this.checkBoxCoNhapSoluong.ForeColor = System.Drawing.Color.DarkGreen;
		this.checkBoxCoNhapSoluong.Location = new System.Drawing.Point(11, 168);
		this.checkBoxCoNhapSoluong.Name = "checkBoxCoNhapSoluong";
		this.checkBoxCoNhapSoluong.Size = new System.Drawing.Size(343, 17);
		this.checkBoxCoNhapSoluong.TabIndex = 210;
		this.checkBoxCoNhapSoluong.Text = "Có nhập số lượng khi mở túi thuốc (không có nhập thì đừng check)";
		this.checkBoxCoNhapSoluong.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		this.checkBoxCoNhapSoluong.UseVisualStyleBackColor = false;
		this.checkBoxCoNhapSoluong.CheckedChanged += new System.EventHandler(checkBoxCoNhapSoluong_CheckedChanged);
		this.comboBoxTenTuiMauHotro.FormattingEnabled = true;
		this.comboBoxTenTuiMauHotro.Location = new System.Drawing.Point(11, 139);
		this.comboBoxTenTuiMauHotro.Name = "comboBoxTenTuiMauHotro";
		this.comboBoxTenTuiMauHotro.Size = new System.Drawing.Size(229, 21);
		this.comboBoxTenTuiMauHotro.TabIndex = 217;
		this.comboBoxTenTuiMauHotro.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenTuiMauHotro_MouseDown);
		this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[6] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2, this.columnHeader_3, this.columnHeader_4, this.columnHeader_5 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(11, 26);
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(453, 108);
		this.listView1.TabIndex = 218;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		this.columnHeader_0.Text = "Tên túi máu, vật phẩm";
		this.columnHeader_0.Width = 130;
		this.columnHeader_1.Text = "Theo SL";
		this.columnHeader_1.Width = 65;
		this.columnHeader_2.Text = "Theo time";
		this.columnHeader_2.Width = 65;
		this.columnHeader_3.Text = "Box nhập";
		this.columnHeader_3.Width = 65;
		this.columnHeader_4.Text = "Click menu";
		this.columnHeader_4.Width = 65;
		this.columnHeader_5.Text = "TT";
		this.columnHeader_5.Width = 40;
		this.buttonThem.ForeColor = System.Drawing.Color.DarkBlue;
		this.buttonThem.Location = new System.Drawing.Point(246, 139);
		this.buttonThem.Name = "buttonThem";
		this.buttonThem.Size = new System.Drawing.Size(148, 23);
		this.buttonThem.TabIndex = 219;
		this.buttonThem.Text = "Thêm vào danh sách";
		this.buttonThem.UseVisualStyleBackColor = true;
		this.buttonThem.Click += new System.EventHandler(buttonThem_Click);
		this.buttonXoa.Location = new System.Drawing.Point(400, 139);
		this.buttonXoa.Name = "buttonXoa";
		this.buttonXoa.Size = new System.Drawing.Size(64, 23);
		this.buttonXoa.TabIndex = 220;
		this.buttonXoa.Text = "Xóa";
		this.buttonXoa.UseVisualStyleBackColor = true;
		this.buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		this.buttonClose.Location = new System.Drawing.Point(368, 363);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(96, 27);
		this.buttonClose.TabIndex = 222;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.checkBoxClickMenu.AutoSize = true;
		this.checkBoxClickMenu.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxClickMenu.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
		this.checkBoxClickMenu.ForeColor = System.Drawing.Color.Black;
		this.checkBoxClickMenu.Location = new System.Drawing.Point(11, 353);
		this.checkBoxClickMenu.Name = "checkBoxClickMenu";
		this.checkBoxClickMenu.Size = new System.Drawing.Size(268, 17);
		this.checkBoxClickMenu.TabIndex = 223;
		this.checkBoxClickMenu.Text = "Có menu và cần click vào các dòng...(ví dụ: 4,2,1)";
		this.checkBoxClickMenu.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		this.checkBoxClickMenu.UseVisualStyleBackColor = false;
		this.checkBoxClickMenu.CheckedChanged += new System.EventHandler(checkBoxClickMenu_CheckedChanged);
		this.textBoxMothuocKhicon.ForeColor = System.Drawing.Color.Black;
		this.textBoxMothuocKhicon.Location = new System.Drawing.Point(259, 195);
		this.textBoxMothuocKhicon.Name = "textBoxMothuocKhicon";
		this.textBoxMothuocKhicon.Size = new System.Drawing.Size(48, 20);
		this.textBoxMothuocKhicon.TabIndex = 226;
		this.textBoxMothuocKhicon.TextChanged += new System.EventHandler(textBoxMothuocKhicon_TextChanged);
		this.checkBoxMoTheoThoigian.AutoSize = true;
		this.checkBoxMoTheoThoigian.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxMoTheoThoigian.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
		this.checkBoxMoTheoThoigian.ForeColor = System.Drawing.Color.Black;
		this.checkBoxMoTheoThoigian.Location = new System.Drawing.Point(11, 281);
		this.checkBoxMoTheoThoigian.Name = "checkBoxMoTheoThoigian";
		this.checkBoxMoTheoThoigian.Size = new System.Drawing.Size(238, 17);
		this.checkBoxMoTheoThoigian.TabIndex = 227;
		this.checkBoxMoTheoThoigian.Text = "Sử dụng theo thời gian (ms) (1giây = 1000ms)";
		this.checkBoxMoTheoThoigian.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		this.checkBoxMoTheoThoigian.UseVisualStyleBackColor = false;
		this.checkBoxMoTheoThoigian.CheckedChanged += new System.EventHandler(checkBoxMoTheoThoigian_CheckedChanged);
		this.checkBoxMoTheoSoluong.AutoSize = true;
		this.checkBoxMoTheoSoluong.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxMoTheoSoluong.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
		this.checkBoxMoTheoSoluong.ForeColor = System.Drawing.Color.Black;
		this.checkBoxMoTheoSoluong.Location = new System.Drawing.Point(11, 196);
		this.checkBoxMoTheoSoluong.Name = "checkBoxMoTheoSoluong";
		this.checkBoxMoTheoSoluong.Size = new System.Drawing.Size(244, 17);
		this.checkBoxMoTheoSoluong.TabIndex = 228;
		this.checkBoxMoTheoSoluong.Text = "Sử dụng khi số lượng thuốc phục hồi máu còn";
		this.checkBoxMoTheoSoluong.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		this.checkBoxMoTheoSoluong.UseVisualStyleBackColor = false;
		this.checkBoxMoTheoSoluong.CheckedChanged += new System.EventHandler(checkBoxMoTheoSoluong_CheckedChanged);
		this.textBoxThoigian.ForeColor = System.Drawing.Color.Black;
		this.textBoxThoigian.Location = new System.Drawing.Point(285, 279);
		this.textBoxThoigian.Name = "textBoxThoigian";
		this.textBoxThoigian.Size = new System.Drawing.Size(73, 20);
		this.textBoxThoigian.TabIndex = 229;
		this.textBoxThoigian.TextChanged += new System.EventHandler(textBoxThoigian_TextChanged);
		this.buttonAppAll.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonAppAll.Location = new System.Drawing.Point(368, 315);
		this.buttonAppAll.Name = "buttonAppAll";
		this.buttonAppAll.Size = new System.Drawing.Size(96, 42);
		this.buttonAppAll.TabIndex = 231;
		this.buttonAppAll.Text = "Áp dụng cho tất cả ac";
		this.buttonAppAll.UseVisualStyleBackColor = true;
		this.buttonAppAll.Click += new System.EventHandler(buttonAppAll_Click);
		this.checkBoxTrangThai.AutoSize = true;
		this.checkBoxTrangThai.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTrangThai.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
		this.checkBoxTrangThai.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTrangThai.Location = new System.Drawing.Point(11, 307);
		this.checkBoxTrangThai.Name = "checkBoxTrangThai";
		this.checkBoxTrangThai.Size = new System.Drawing.Size(327, 17);
		this.checkBoxTrangThai.TabIndex = 234;
		this.checkBoxTrangThai.Text = "Sử dụng khi thay đổi bản đồ hoặc thay đổi trạng thái chiến đấu";
		this.checkBoxTrangThai.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		this.checkBoxTrangThai.UseVisualStyleBackColor = false;
		this.checkBoxTrangThai.CheckedChanged += new System.EventHandler(checkBoxTrangThai_CheckedChanged);
		this.checkBoxTamDung.AutoSize = true;
		this.checkBoxTamDung.ForeColor = System.Drawing.Color.DarkGreen;
		this.checkBoxTamDung.Location = new System.Drawing.Point(40, 330);
		this.checkBoxTamDung.Name = "checkBoxTamDung";
		this.checkBoxTamDung.Size = new System.Drawing.Size(203, 17);
		this.checkBoxTamDung.TabIndex = 237;
		this.checkBoxTamDung.Text = "Tạm dừng mọi hoạt động khi sử dụng";
		this.checkBoxTamDung.UseVisualStyleBackColor = true;
		this.checkBoxTamDung.CheckedChanged += new System.EventHandler(checkBoxTamDung_CheckedChanged);
		this.textBoxMenu.ForeColor = System.Drawing.Color.Black;
		this.textBoxMenu.Location = new System.Drawing.Point(285, 351);
		this.textBoxMenu.Name = "textBoxMenu";
		this.textBoxMenu.Size = new System.Drawing.Size(73, 20);
		this.textBoxMenu.TabIndex = 241;
		this.textBoxMenu.TextChanged += new System.EventHandler(textBoxMenu_TextChanged);
		this.label3.AutoSize = true;
		this.label3.ForeColor = System.Drawing.Color.DarkRed;
		this.label3.Location = new System.Drawing.Point(363, 198);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(108, 13);
		this.label3.TabIndex = 242;
		this.label3.Text = "(Số lượng mỗi lần mở)";
		this.textBoxSoluongMax.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluongMax.Location = new System.Drawing.Point(311, 195);
		this.textBoxSoluongMax.Name = "textBoxSoluongMax";
		this.textBoxSoluongMax.Size = new System.Drawing.Size(47, 20);
		this.textBoxSoluongMax.TabIndex = 243;
		this.textBoxSoluongMax.TextChanged += new System.EventHandler(textBoxSoluongMax_TextChanged);
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.Red;
		this.label2.Location = new System.Drawing.Point(8, 381);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(313, 13);
		this.label2.TabIndex = 245;
		this.label2.Text = "Xem và kết hợp với phần <Hậu cần - nhồi thuốc > nha các bạn !";
		this.checkBoxKhongMo.AutoSize = true;
		this.checkBoxKhongMo.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxKhongMo.Location = new System.Drawing.Point(11, 3);
		this.checkBoxKhongMo.Name = "checkBoxKhongMo";
		this.checkBoxKhongMo.Size = new System.Drawing.Size(436, 17);
		this.checkBoxKhongMo.TabIndex = 246;
		this.checkBoxKhongMo.Text = "Không mở túi ở nơi phi chiến đấu (không áp dụng cho thay đổi bản đồ hoặc trạng thái)";
		this.checkBoxKhongMo.UseVisualStyleBackColor = true;
		this.checkBoxKhongMo.CheckedChanged += new System.EventHandler(checkBoxKhongMo_CheckedChanged);
		this.panel1.BackgroundImage = ns16.Class16.Bitmap_4;
		this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.panel1.Location = new System.Drawing.Point(368, 164);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(93, 28);
		this.panel1.TabIndex = 247;
		this.checkBox1.AutoSize = true;
		this.checkBox1.ForeColor = System.Drawing.Color.DarkGreen;
		this.checkBox1.Location = new System.Drawing.Point(40, 221);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(131, 17);
		this.checkBox1.TabIndex = 248;
		this.checkBox1.Text = "Thuốc khi mở túi ra là ";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(16, 216);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(21, 13);
		this.label1.TabIndex = 249;
		this.label1.Text = "|__";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(16, 327);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(21, 13);
		this.label4.TabIndex = 250;
		this.label4.Text = "|__";
		this.comboBoxTenMau2.BackColor = System.Drawing.SystemColors.Info;
		this.comboBoxTenMau2.DropDownWidth = 180;
		this.comboBoxTenMau2.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTenMau2.FormattingEnabled = true;
		this.comboBoxTenMau2.Location = new System.Drawing.Point(178, 219);
		this.comboBoxTenMau2.Name = "comboBoxTenMau2";
		this.comboBoxTenMau2.Size = new System.Drawing.Size(180, 21);
		this.comboBoxTenMau2.TabIndex = 333;
		this.comboBoxTenMau2.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenMau2_MouseDown);
		this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
		this.label5.Location = new System.Drawing.Point(69, 244);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(362, 30);
		this.label5.TabIndex = 334;
		this.label5.Text = "nếu không bơm được thuốc sau khi mở bung túi, thì bên tab Phục hồi hãy check vào bơm mức 2 và chọn tên thuốc trên";
		this.label6.AutoSize = true;
		this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
		this.label6.Location = new System.Drawing.Point(42, 244);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(21, 13);
		this.label6.TabIndex = 335;
		this.label6.Text = "|__";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(471, 406);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.comboBoxTenMau2);
		base.Controls.Add(this.checkBox1);
		base.Controls.Add(this.checkBoxTamDung);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.buttonXoa);
		base.Controls.Add(this.buttonThem);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.checkBoxKhongMo);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.textBoxSoluongMax);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.textBoxMenu);
		base.Controls.Add(this.checkBoxClickMenu);
		base.Controls.Add(this.checkBoxTrangThai);
		base.Controls.Add(this.buttonAppAll);
		base.Controls.Add(this.textBoxThoigian);
		base.Controls.Add(this.checkBoxMoTheoSoluong);
		base.Controls.Add(this.checkBoxMoTheoThoigian);
		base.Controls.Add(this.textBoxMothuocKhicon);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.comboBoxTenTuiMauHotro);
		base.Controls.Add(this.checkBoxCoNhapSoluong);
		base.Controls.Add(this.listView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormHaucanTuithuoc";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "MO TUI VAT PHAM";
		base.Load += new System.EventHandler(FormHaucanTuithuoc_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
