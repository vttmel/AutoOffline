using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns16;
using ns53;
using ns63;
using ns81;
using ns83;

namespace ns116;

public class FormLocdo : Form
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	public static int int_4 = 0;

	private string[] string_0 = new string[5] { "Kim", "Mộc", "Thủy", "Hỏa", "Thổ" };

	private string[] string_1 = new string[2] { "Giữ đồ theo thuộc tính", "Bán tất cả" };

	public static int int_5 = Class66.smethod_4("TocdoNhatdoExx", 0, "80");

	private Color color_0 = Color.MidnightBlue;

	private static long long_0 = 0L;

	private static string[] string_2 = null;

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Button buttonClose;

	private CheckBox checkBoxBando;

	private CheckBox checkBoxGiudoTheoCap;

	private ComboBox comboBoxCap;

	private CheckBox checkBoxGiudoTheoHe;

	private ComboBox comboBoxHe;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private CheckBox checkBoxGiudoTheoThuoctinh;

	private TextBox textBoxMin;

	private Button buttonSua;

	private TextBox textBoxName;

	private Button buttonApdungAll;

	private CheckBox checkBoxGiudoTim;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private Button buttonXoa;

	private Button buttonThem;

	private ComboBox comboBoxTenVatpham;

	private ListView listView2;

	private ColumnHeader columnHeader_3;

	private ColumnHeader columnHeader_4;

	private Label labelVidu;

	private Button buttonAppdungAll2;

	private CheckBox checkBoxNhatTrongthanh;

	private ComboBox comboBoxBando;

	private CheckBox checkBoxNhatTheoThuoctinh;

	private TabPage tabPage3;

	private Label label1;

	private CheckBox checkBoxKhongNhatdoTim;

	private CheckBox checkBoxThoahet;

	private CheckBox checkBoxGiuTrangsuc;

	private CheckBox checkBoxNgocBoi;

	private CheckBox checkBoxDaychuyen;

	private Label label2;

	private TextBox textBoxTocdoNhat;

	private TextBox textBoxDongDC;

	private TextBox textBoxDongNB;

	private TextBox textBoxDongNhan;

	private Button buttonBoCheck;

	private Button buttonS;

	private Button buttonO;

	private Button buttonXj;

	public FormLocdo()
	{
		bool_0 = true;
		try
		{
			InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}
		catch
		{
		}
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool flag = false;
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (0 <= num)
		{
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			flag = true;
		}
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				if (!flag)
				{
					Class56.smethod_13(Form1.characterAccountConfig_1[i]);
				}
			}
		}
		Class66.smethod_11(Class66.smethod_1(), "FormLocdo", tabControl1.SelectedIndex, "", 0);
		int_0 = 0;
		int_1 = 0;
		int_4 = 0;
		bool_0 = false;
	}

	private void FormLocdo_Load(object sender, EventArgs e)
	{
		try
		{
			method_0();
		}
		catch
		{
		}
	}

	private void method_0()
	{
		timer_0.Enabled = false;
		if (int_0 >= 0 && int_1 >= 0)
		{
			int num = int_0 - base.Width;
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
		tabControl1.SelectedIndex = Class66.smethod_4("FormLocdo", 0, "0");
		base.TopMost = true;
		for (int i = 0; i < string_0.Length; i++)
		{
			comboBoxHe.Items.Add(string_0[i]);
		}
		for (int j = 0; j <= 10; j++)
		{
			comboBoxCap.Items.Add(j.ToString());
		}
		for (int k = 0; k < string_1.Length; k++)
		{
			comboBoxBando.Items.Add(string_1[k]);
		}
		textBoxTocdoNhat.Text = int_5.ToString();
		int num3 = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (0 > num3)
		{
			ItemAttributeFilterRule itemAttributeFilterRule_ = new ItemAttributeFilterRule
			{
				string_0 = "Chưa chọn ac, bấm Lọc sau khi chọn 1 ac nhé."
			};
			method_1(itemAttributeFilterRule_);
			tabControl1.Enabled = false;
			buttonApdungAll.Enabled = false;
			base.Text = "Loc do * Chua chon ac nao";
		}
		else
		{
			CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[num3];
			checkBoxBando.Checked = characterAccountConfig.int_46[0] > 0;
			comboBoxBando.Text = string_1[characterAccountConfig.int_46[1]];
			checkBoxGiudoTheoCap.Checked = characterAccountConfig.int_47[0] > 0;
			checkBoxGiudoTheoHe.Checked = characterAccountConfig.int_48[0] > 0;
			checkBoxGiudoTim.Checked = characterAccountConfig.int_49 > 0;
			checkBoxNhatTrongthanh.Checked = characterAccountConfig.int_39 > 0;
			checkBoxNhatTheoThuoctinh.Checked = characterAccountConfig.int_40 > 0;
			checkBoxGiudoTheoThuoctinh.Checked = characterAccountConfig.int_50 > 0;
			checkBoxThoahet.Checked = characterAccountConfig.int_41 > 0;
			checkBoxThoahet.Enabled = characterAccountConfig.int_50 > 0;
			checkBoxKhongNhatdoTim.Checked = characterAccountConfig.int_42 > 0;
			checkBoxGiuTrangsuc.Checked = characterAccountConfig.int_43[0] > 0;
			textBoxDongNhan.Text = characterAccountConfig.int_43[1].ToString();
			checkBoxNgocBoi.Checked = characterAccountConfig.int_45[0] > 0;
			textBoxDongNB.Text = characterAccountConfig.int_45[1].ToString();
			checkBoxDaychuyen.Checked = characterAccountConfig.int_44[0] > 0;
			textBoxDongDC.Text = characterAccountConfig.int_44[1].ToString();
			comboBoxHe.Text = string_0[characterAccountConfig.int_48[1]];
			comboBoxCap.Text = characterAccountConfig.int_47[1].ToString();
			if (characterAccountConfig.itemAttributeFilterRule_0 != null)
			{
				for (int l = 0; l < characterAccountConfig.itemAttributeFilterRule_0.Length; l++)
				{
					method_1(characterAccountConfig.itemAttributeFilterRule_0[l]);
				}
				for (int m = 0; m < characterAccountConfig.itemAttributeFilterRule_0.Length; m++)
				{
					if (m < listView1.Items.Count && characterAccountConfig.itemAttributeFilterRule_0[m].int_0 > 0)
					{
						listView1.Items[m].Checked = true;
						listView1.Items[m].ForeColor = color_0;
					}
				}
			}
			if (characterAccountConfig.string_4 != null)
			{
				for (int n = 0; n < characterAccountConfig.string_4.Length; n++)
				{
					method_2(Class1.smethod_1(characterAccountConfig.string_4[n], 1));
				}
			}
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
		else if (long_0 > 0L && Class11.smethod_28(long_0) > 300L)
		{
			buttonApdungAll.Enabled = true;
			buttonAppdungAll2.Enabled = true;
			long_0 = 0L;
		}
	}

	private void method_1(ItemAttributeFilterRule itemAttributeFilterRule_0)
	{
		int num = 0;
		try
		{
			if (listView1.Items != null)
			{
				num = listView1.Items.Count;
			}
			string[] array = new string[3]
			{
				num.ToString(),
				itemAttributeFilterRule_0.string_0,
				itemAttributeFilterRule_0.int_2.ToString()
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
			listView1.Items.Add(listViewItem);
		}
		catch
		{
		}
	}

	private void method_2(string string_3)
	{
		int num = 0;
		try
		{
			if (listView2.Items != null)
			{
				num = listView2.Items.Count;
			}
			string[] array = new string[2]
			{
				num.ToString(),
				string_3
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
			listView2.Items.Add(listViewItem);
		}
		catch
		{
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxBando_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_46[0] = Convert.ToByte(checkBoxBando.Checked);
			}
		}
	}

	private void comboBoxBando_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxBando.Text;
		for (int i = 0; i < string_1.Length; i++)
		{
			if (text == string_1[i])
			{
				Form1.characterAccountConfig_1[num].int_46[1] = i;
				break;
			}
		}
	}

	private void checkBoxGiudoTheoCap_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_47[0] = Convert.ToByte(checkBoxGiudoTheoCap.Checked);
			}
		}
	}

	private void checkBoxGiudoTheoHe_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_48[0] = Convert.ToByte(checkBoxGiudoTheoHe.Checked);
			}
		}
	}

	private void checkBoxGiudoTheoThuoctinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_50 = Convert.ToByte(checkBoxGiudoTheoThuoctinh.Checked);
				checkBoxThoahet.Enabled = checkBoxGiudoTheoThuoctinh.Checked;
			}
		}
	}

	private void comboBoxCap_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_47[1] = Class11.smethod_11(comboBoxCap.Text);
			}
		}
	}

	private void comboBoxHe_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxHe.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_0.Length)
			{
				if (string_0[num2] == text)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		Form1.characterAccountConfig_1[num].int_48[1] = num2;
	}

	private void checkBoxNhatTrongthanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_39 = Convert.ToByte(checkBoxNhatTrongthanh.Checked);
			}
		}
	}

	private void checkBoxNhatTheoThuoctinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_40 = Convert.ToByte(checkBoxNhatTheoThuoctinh.Checked);
			}
		}
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView1.Items == null || listView1.Items.Count == 0)
		{
			return;
		}
		int num = 0;
		while (true)
		{
			if (num < listView1.Items.Count)
			{
				if (listView1.Items[num].Selected)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		textBoxName.Text = num + ". " + listView1.Items[num].SubItems[1].Text;
		textBoxMin.Text = listView1.Items[num].SubItems[2].Text;
	}

	private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num >= 0)
		{
			int num2 = Convert.ToByte(e.NewValue);
			Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0[e.Index].int_0 = num2;
			if (num2 > 0)
			{
				listView1.Items[e.Index].ForeColor = color_0;
			}
			else
			{
				listView1.Items[e.Index].ForeColor = Color.Black;
			}
		}
	}

	private void buttonSua_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			return;
		}
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0[i].int_2 = Class11.smethod_11(textBoxMin.Text);
				listView1.Items[i].SubItems[2].Text = textBoxMin.Text;
				break;
			}
		}
	}

	private void checkBoxGiudoTim_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_49 = Convert.ToByte(checkBoxGiudoTim.Checked);
			}
		}
	}

	private void checkBoxKhongNhatdoTim_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_42 = Convert.ToByte(checkBoxKhongNhatdoTim.Checked);
			}
		}
	}

	private void checkBoxThoahet_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_41 = Convert.ToByte(checkBoxThoahet.Checked);
			}
		}
	}

	private void checkBoxGiuTrangsuc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_43[0] = Convert.ToByte(checkBoxGiuTrangsuc.Checked);
			}
		}
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			return;
		}
		string text = null;
		try
		{
			for (int i = 0; i < listView2.Items.Count; i++)
			{
				if (!listView2.Items[i].Selected)
				{
					continue;
				}
				text = listView2.Items[i].SubItems[1].Text;
				listView2.Items.RemoveAt(i);
				if (listView2.Items.Count > 0)
				{
					if (listView2.Items.Count <= i)
					{
						i--;
					}
					listView2.Items[i].Selected = true;
					listView2.Items[i].Focused = true;
				}
			}
		}
		catch
		{
		}
		if (text == null || Form1.characterAccountConfig_1[num].string_4 == null)
		{
			return;
		}
		for (int i = 0; i < Form1.characterAccountConfig_1[num].string_4.Length; i++)
		{
			if (Class1.smethod_1(Form1.characterAccountConfig_1[num].string_4[i], 1) == text)
			{
				Class11.smethod_30(ref Form1.characterAccountConfig_1[num].string_4, Form1.characterAccountConfig_1[num].string_4[i]);
				Form1.characterAccountConfig_1[num].bool_10 = true;
				break;
			}
		}
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (string_2 == null || num < 0)
		{
			return;
		}
		string text = null;
		string text2 = comboBoxTenVatpham.Text;
		for (int i = 0; i < string_2.Length; i++)
		{
			if (text2 == Class1.smethod_1(string_2[i], 1))
			{
				text = string_2[i].Trim();
				break;
			}
		}
		if (text == null)
		{
			text = Class1.smethod_2(text2);
		}
		if (Form1.characterAccountConfig_1[num].string_4 != null)
		{
			for (int j = 0; j < Form1.characterAccountConfig_1[num].string_4.Length; j++)
			{
				if (Form1.characterAccountConfig_1[num].string_4[j] == text)
				{
					return;
				}
			}
		}
		method_2(Class1.smethod_1(text, 1));
		Class11.smethod_29(ref Form1.characterAccountConfig_1[num].string_4, text);
		Form1.characterAccountConfig_1[num].bool_10 = true;
	}

	private void listView2_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView1.Items == null || listView1.Items.Count == 0)
		{
			return;
		}
		string text = null;
		try
		{
			for (int i = 0; i < listView2.Items.Count; i++)
			{
				if (listView2.Items[i].Selected)
				{
					text = listView2.Items[i].SubItems[1].Text;
					break;
				}
			}
		}
		catch
		{
		}
		if (text != null && text != comboBoxTenVatpham.Text)
		{
			comboBoxTenVatpham.Items.Clear();
			comboBoxTenVatpham.Items.Add(text);
			comboBoxTenVatpham.Text = text;
		}
	}

	private void comboBoxTenVatpham_MouseDown(object sender, MouseEventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			return;
		}
		string_2 = Class85.smethod_34(Form1.characterAccountConfig_1[num]);
		comboBoxTenVatpham.Items.Clear();
		if (string_2 != null)
		{
			for (int i = 0; i < string_2.Length; i++)
			{
				comboBoxTenVatpham.Items.Add(Class1.smethod_1(string_2[i], 1));
			}
		}
	}

	private void buttonApdungAll_Click(object sender, EventArgs e)
	{
		if (Form1.characterAccountConfig_1 == null)
		{
			return;
		}
		buttonApdungAll.Enabled = false;
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, FormLocdo.int_4);
		if (num >= 0)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				if (num != i)
				{
					Form1.characterAccountConfig_1[i].int_47 = new int[2]
					{
						Form1.characterAccountConfig_1[num].int_47[0],
						Form1.characterAccountConfig_1[num].int_47[1]
					};
					Form1.characterAccountConfig_1[i].int_48 = new int[2]
					{
						Form1.characterAccountConfig_1[num].int_48[0],
						Form1.characterAccountConfig_1[num].int_48[1]
					};
					Form1.characterAccountConfig_1[i].int_49 = Form1.characterAccountConfig_1[num].int_49;
					Form1.characterAccountConfig_1[i].int_50 = Form1.characterAccountConfig_1[num].int_50;
					if (Form1.characterAccountConfig_1[i].itemAttributeFilterRule_0 == null)
					{
						Form1.characterAccountConfig_1[i].itemAttributeFilterRule_0 = Class56.smethod_1();
					}
					for (int j = 0; j < Form1.characterAccountConfig_1[i].itemAttributeFilterRule_0.Length; j++)
					{
						Form1.characterAccountConfig_1[i].itemAttributeFilterRule_0[j].int_0 = Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0[j].int_0;
						Form1.characterAccountConfig_1[i].itemAttributeFilterRule_0[j].int_2 = Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0[j].int_2;
					}
					Form1.characterAccountConfig_1[i].int_39 = Form1.characterAccountConfig_1[num].int_39;
					Form1.characterAccountConfig_1[i].int_40 = Form1.characterAccountConfig_1[num].int_40;
					Form1.characterAccountConfig_1[i].int_46 = new int[2]
					{
						Form1.characterAccountConfig_1[num].int_46[0],
						Form1.characterAccountConfig_1[num].int_46[1]
					};
					Form1.characterAccountConfig_1[i].int_61 = Form1.characterAccountConfig_1[num].int_61;
					Form1.characterAccountConfig_1[i].int_62 = Form1.characterAccountConfig_1[num].int_62;
					Form1.characterAccountConfig_1[i].int_42 = Form1.characterAccountConfig_1[num].int_42;
					for (int k = 0; k < 2; k++)
					{
						Form1.characterAccountConfig_1[i].int_43[k] = Form1.characterAccountConfig_1[num].int_43[k];
						Form1.characterAccountConfig_1[i].int_44[k] = Form1.characterAccountConfig_1[num].int_44[k];
						Form1.characterAccountConfig_1[i].int_45[k] = Form1.characterAccountConfig_1[num].int_45[k];
					}
				}
			}
		}
		else
		{
			int int_ = Convert.ToByte(checkBoxKhongNhatdoTim.Checked);
			int int_2 = Convert.ToByte(checkBoxNhatTrongthanh.Checked);
			int int_3 = Convert.ToByte(checkBoxNhatTheoThuoctinh.Checked);
			int[] array = new int[2]
			{
				Convert.ToByte(checkBoxGiuTrangsuc.Checked),
				Class11.smethod_11(textBoxDongNhan.Text)
			};
			int[] array2 = new int[2]
			{
				Convert.ToByte(checkBoxDaychuyen.Checked),
				Class11.smethod_11(textBoxDongDC.Text)
			};
			int[] array3 = new int[2]
			{
				Convert.ToByte(checkBoxNgocBoi.Checked),
				Class11.smethod_11(textBoxDongNB.Text)
			};
			int num2 = Convert.ToByte(checkBoxBando.Checked);
			int num3 = 0;
			for (int l = 0; l < string_1.Length; l++)
			{
				if (string_1[l] == comboBoxBando.Text)
				{
					num3 = l;
					break;
				}
			}
			int num4 = Convert.ToByte(checkBoxGiudoTheoHe.Checked);
			int num5 = 0;
			for (int m = 0; m < string_0.Length; m++)
			{
				if (string_0[m] == comboBoxHe.Text)
				{
					num5 = m;
					break;
				}
			}
			int num6 = Convert.ToByte(checkBoxGiudoTheoCap.Checked);
			int num7 = Class11.smethod_11(comboBoxCap.Text);
			int int_4 = Convert.ToByte(checkBoxGiudoTim.Checked);
			int int_5 = Convert.ToByte(checkBoxGiudoTheoThuoctinh.Checked);
			for (int n = 0; n < Form1.characterAccountConfig_1.Length; n++)
			{
				Form1.characterAccountConfig_1[n].int_47 = new int[2] { num6, num7 };
				Form1.characterAccountConfig_1[n].int_48 = new int[2] { num4, num5 };
				Form1.characterAccountConfig_1[n].int_49 = int_4;
				Form1.characterAccountConfig_1[n].int_50 = int_5;
				if (Form1.characterAccountConfig_1[n].itemAttributeFilterRule_0 == null)
				{
					Form1.characterAccountConfig_1[n].itemAttributeFilterRule_0 = Class56.smethod_1();
				}
				try
				{
					for (int num8 = 0; num8 < Form1.characterAccountConfig_1[n].itemAttributeFilterRule_0.Length; num8++)
					{
						Form1.characterAccountConfig_1[n].itemAttributeFilterRule_0[num8].int_0 = Convert.ToByte(listView1.Items[n].Checked);
						Form1.characterAccountConfig_1[n].itemAttributeFilterRule_0[num8].int_2 = Class11.smethod_11(listView1.Items[n].SubItems[2].Text);
					}
				}
				catch
				{
				}
				Form1.characterAccountConfig_1[n].int_46 = new int[2] { num2, num3 };
				Form1.characterAccountConfig_1[n].int_39 = int_2;
				Form1.characterAccountConfig_1[n].int_40 = int_3;
				Form1.characterAccountConfig_1[n].int_42 = int_;
				for (int num9 = 0; num9 < 2; num9++)
				{
					Form1.characterAccountConfig_1[n].int_43[num9] = array[num9];
					Form1.characterAccountConfig_1[n].int_44[num9] = array2[num9];
					Form1.characterAccountConfig_1[n].int_45[num9] = array3[num9];
				}
			}
		}
		textBoxName.Text = "Đã áp dụng cho tất cả ac đang online.";
		long_0 = Class11.smethod_27();
	}

	private void buttonAppdungAll2_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			return;
		}
		buttonAppdungAll2.Enabled = false;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				if (num == i)
				{
					continue;
				}
				Form1.characterAccountConfig_1[i].string_4 = null;
				if (Form1.characterAccountConfig_1[num].string_4 != null)
				{
					Form1.characterAccountConfig_1[i].string_4 = new string[Form1.characterAccountConfig_1[num].string_4.Length];
					for (int j = 0; j < Form1.characterAccountConfig_1[num].string_4.Length; j++)
					{
						Form1.characterAccountConfig_1[i].string_4[j] = Form1.characterAccountConfig_1[num].string_4[j];
					}
				}
				Form1.characterAccountConfig_1[i].bool_10 = true;
			}
		}
		long_0 = Class11.smethod_27();
	}

	private void checkBoxNgocBoi_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_45[0] = Convert.ToByte(checkBoxNgocBoi.Checked);
			}
		}
	}

	private void checkBoxDaychuyen_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_44[0] = Convert.ToByte(checkBoxDaychuyen.Checked);
			}
		}
	}

	private void textBoxTocdoNhat_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_5 = Class11.smethod_11(textBoxTocdoNhat.Text);
			if (int_5 < 0)
			{
				int_5 = 0;
			}
			Class66.smethod_11(Class66.smethod_1(), "TocdoNhatdoExx", int_5, "", 0);
		}
	}

	private void textBoxDongNhan_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_43[1] = Class11.smethod_11(textBoxDongNhan.Text);
			}
		}
	}

	private void textBoxDongNB_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_45[1] = Class11.smethod_11(textBoxDongNB.Text);
			}
		}
	}

	private void textBoxDongDC_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_44[1] = Class11.smethod_11(textBoxDongDC.Text);
			}
		}
	}

	private void buttonBoCheck_Click(object sender, EventArgs e)
	{
		if (listView1.Items.Count > 0)
		{
			for (int i = 0; i < listView1.Items.Count; i++)
			{
				listView1.Items[i].Checked = false;
			}
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num >= 0 && Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0 != null)
		{
			for (int j = 0; j < Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0.Length; j++)
			{
				Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0[j].int_0 = 0;
			}
		}
	}

	private void buttonO_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			return;
		}
		string text = Class56.string_8 + "\\Badlist";
		Class11.smethod_23(text);
		string text2 = Class56.smethod_26(text, "", "*.txt");
		if (text2 == string.Empty)
		{
			return;
		}
		Form1.characterAccountConfig_1[num].string_4 = null;
		listView2.Items.Clear();
		string text3 = Class11.smethod_15(Class11.smethod_33(text2, 0, 0, 1));
		if (text3 == null || !(text3 != string.Empty))
		{
			return;
		}
		string[] array = text3.Split('\r');
		int num2 = 0;
		Form1.characterAccountConfig_1[num].string_4 = new string[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null && !(array[i] == string.Empty))
			{
				Form1.characterAccountConfig_1[num].string_4[num2] = array[i];
				num2++;
				method_2(Class1.smethod_1(array[i], 1));
			}
		}
		if (num2 == 0)
		{
			Form1.characterAccountConfig_1[num].string_4 = null;
		}
		else if (num2 != array.Length)
		{
			Array.Resize(ref Form1.characterAccountConfig_1[num].string_4, num2);
		}
	}

	private void buttonS_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			return;
		}
		string text = Class1.smethod_1(Form1.characterAccountConfig_1[num].string_22, 1);
		string[] string_ = Form1.characterAccountConfig_1[num].string_4;
		string text2 = string.Empty;
		if (string_ != null && string_.Length != 0)
		{
			for (int i = 0; i < string_.Length; i++)
			{
				if (text2 != string.Empty)
				{
					text2 += "\r";
				}
				text2 += string_[i];
			}
			text2 = Class11.smethod_16(text2);
		}
		string text3 = Class56.string_8 + "\\Badlist";
		Class11.smethod_23(text3);
		string text4 = Class56.smethod_27(text3, text + "_badlist.txt");
		if (text4 != null && text4 != string.Empty)
		{
			Class11.smethod_34(text4, text2, 2);
		}
	}

	private void buttonXj_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num >= 0)
		{
			Form1.characterAccountConfig_1[num].string_4 = null;
			listView2.Items.Clear();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns116.FormLocdo));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonClose = new System.Windows.Forms.Button();
		this.checkBoxBando = new System.Windows.Forms.CheckBox();
		this.checkBoxGiudoTheoCap = new System.Windows.Forms.CheckBox();
		this.comboBoxCap = new System.Windows.Forms.ComboBox();
		this.checkBoxGiudoTheoHe = new System.Windows.Forms.CheckBox();
		this.comboBoxHe = new System.Windows.Forms.ComboBox();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.checkBoxGiudoTheoThuoctinh = new System.Windows.Forms.CheckBox();
		this.textBoxMin = new System.Windows.Forms.TextBox();
		this.buttonSua = new System.Windows.Forms.Button();
		this.textBoxName = new System.Windows.Forms.TextBox();
		this.buttonApdungAll = new System.Windows.Forms.Button();
		this.checkBoxGiudoTim = new System.Windows.Forms.CheckBox();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.buttonBoCheck = new System.Windows.Forms.Button();
		this.textBoxDongDC = new System.Windows.Forms.TextBox();
		this.textBoxDongNB = new System.Windows.Forms.TextBox();
		this.checkBoxNgocBoi = new System.Windows.Forms.CheckBox();
		this.textBoxDongNhan = new System.Windows.Forms.TextBox();
		this.checkBoxDaychuyen = new System.Windows.Forms.CheckBox();
		this.checkBoxGiuTrangsuc = new System.Windows.Forms.CheckBox();
		this.checkBoxThoahet = new System.Windows.Forms.CheckBox();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.buttonAppdungAll2 = new System.Windows.Forms.Button();
		this.listView2 = new System.Windows.Forms.ListView();
		this.columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_4 = new System.Windows.Forms.ColumnHeader();
		this.buttonThem = new System.Windows.Forms.Button();
		this.comboBoxTenVatpham = new System.Windows.Forms.ComboBox();
		this.buttonXoa = new System.Windows.Forms.Button();
		this.labelVidu = new System.Windows.Forms.Label();
		this.tabPage3 = new System.Windows.Forms.TabPage();
		this.label1 = new System.Windows.Forms.Label();
		this.checkBoxNhatTrongthanh = new System.Windows.Forms.CheckBox();
		this.comboBoxBando = new System.Windows.Forms.ComboBox();
		this.checkBoxNhatTheoThuoctinh = new System.Windows.Forms.CheckBox();
		this.checkBoxKhongNhatdoTim = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.textBoxTocdoNhat = new System.Windows.Forms.TextBox();
		this.buttonO = new System.Windows.Forms.Button();
		this.buttonS = new System.Windows.Forms.Button();
		this.buttonXj = new System.Windows.Forms.Button();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.tabPage2.SuspendLayout();
		this.tabPage3.SuspendLayout();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonClose.Location = new System.Drawing.Point(280, 485);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(60, 22);
		this.buttonClose.TabIndex = 8;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.checkBoxBando.ForeColor = System.Drawing.Color.Black;
		this.checkBoxBando.Location = new System.Drawing.Point(126, 3);
		this.checkBoxBando.Name = "checkBoxBando";
		this.checkBoxBando.Size = new System.Drawing.Size(218, 32);
		this.checkBoxBando.TabIndex = 9;
		this.checkBoxBando.Text = "Bán đồ khi về thành - chỉ áp dụng khi có check vào Train - tab Điều khiển";
		this.checkBoxBando.UseVisualStyleBackColor = true;
		this.checkBoxBando.CheckedChanged += new System.EventHandler(checkBoxBando_CheckedChanged);
		this.checkBoxGiudoTheoCap.AutoSize = true;
		this.checkBoxGiudoTheoCap.Location = new System.Drawing.Point(161, 28);
		this.checkBoxGiudoTheoCap.Name = "checkBoxGiudoTheoCap";
		this.checkBoxGiudoTheoCap.Size = new System.Drawing.Size(103, 17);
		this.checkBoxGiudoTheoCap.TabIndex = 32;
		this.checkBoxGiudoTheoCap.Text = "Giữ đồ theo cấp";
		this.checkBoxGiudoTheoCap.UseVisualStyleBackColor = true;
		this.checkBoxGiudoTheoCap.CheckedChanged += new System.EventHandler(checkBoxGiudoTheoCap_CheckedChanged);
		this.comboBoxCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxCap.FormattingEnabled = true;
		this.comboBoxCap.Location = new System.Drawing.Point(276, 26);
		this.comboBoxCap.Name = "comboBoxCap";
		this.comboBoxCap.Size = new System.Drawing.Size(51, 21);
		this.comboBoxCap.TabIndex = 30;
		this.comboBoxCap.SelectedIndexChanged += new System.EventHandler(comboBoxCap_SelectedIndexChanged);
		this.checkBoxGiudoTheoHe.AutoSize = true;
		this.checkBoxGiudoTheoHe.Location = new System.Drawing.Point(161, 51);
		this.checkBoxGiudoTheoHe.Name = "checkBoxGiudoTheoHe";
		this.checkBoxGiudoTheoHe.Size = new System.Drawing.Size(97, 17);
		this.checkBoxGiudoTheoHe.TabIndex = 33;
		this.checkBoxGiudoTheoHe.Text = "Giữ đồ theo hệ";
		this.checkBoxGiudoTheoHe.UseVisualStyleBackColor = true;
		this.checkBoxGiudoTheoHe.CheckedChanged += new System.EventHandler(checkBoxGiudoTheoHe_CheckedChanged);
		this.comboBoxHe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxHe.FormattingEnabled = true;
		this.comboBoxHe.Location = new System.Drawing.Point(276, 50);
		this.comboBoxHe.Name = "comboBoxHe";
		this.comboBoxHe.Size = new System.Drawing.Size(50, 21);
		this.comboBoxHe.TabIndex = 31;
		this.comboBoxHe.SelectedIndexChanged += new System.EventHandler(comboBoxHe_SelectedIndexChanged);
		this.listView1.CheckBoxes = true;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(3, 118);
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(326, 239);
		this.listView1.TabIndex = 34;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(listView1_ItemCheck);
		this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		this.columnHeader_0.Text = "No";
		this.columnHeader_0.Width = 45;
		this.columnHeader_1.Text = "Thuộc tính";
		this.columnHeader_1.Width = 225;
		this.columnHeader_2.Text = "Min";
		this.columnHeader_2.Width = 35;
		this.checkBoxGiudoTheoThuoctinh.AutoSize = true;
		this.checkBoxGiudoTheoThuoctinh.ForeColor = System.Drawing.Color.DarkBlue;
		this.checkBoxGiudoTheoThuoctinh.Location = new System.Drawing.Point(3, 73);
		this.checkBoxGiudoTheoThuoctinh.Name = "checkBoxGiudoTheoThuoctinh";
		this.checkBoxGiudoTheoThuoctinh.Size = new System.Drawing.Size(157, 17);
		this.checkBoxGiudoTheoThuoctinh.TabIndex = 35;
		this.checkBoxGiudoTheoThuoctinh.Text = "Giữ đồ theo thuộc tính dưới";
		this.checkBoxGiudoTheoThuoctinh.UseVisualStyleBackColor = true;
		this.checkBoxGiudoTheoThuoctinh.CheckedChanged += new System.EventHandler(checkBoxGiudoTheoThuoctinh_CheckedChanged);
		this.textBoxMin.Location = new System.Drawing.Point(249, 361);
		this.textBoxMin.Name = "textBoxMin";
		this.textBoxMin.Size = new System.Drawing.Size(33, 20);
		this.textBoxMin.TabIndex = 38;
		this.buttonSua.Location = new System.Drawing.Point(284, 360);
		this.buttonSua.Name = "buttonSua";
		this.buttonSua.Size = new System.Drawing.Size(45, 21);
		this.buttonSua.TabIndex = 39;
		this.buttonSua.Text = "Sửa";
		this.buttonSua.UseVisualStyleBackColor = true;
		this.buttonSua.Click += new System.EventHandler(buttonSua_Click);
		this.textBoxName.ForeColor = System.Drawing.Color.Blue;
		this.textBoxName.Location = new System.Drawing.Point(111, 361);
		this.textBoxName.Name = "textBoxName";
		this.textBoxName.ReadOnly = true;
		this.textBoxName.Size = new System.Drawing.Size(135, 20);
		this.textBoxName.TabIndex = 40;
		this.buttonApdungAll.ForeColor = System.Drawing.Color.Black;
		this.buttonApdungAll.Location = new System.Drawing.Point(132, 485);
		this.buttonApdungAll.Name = "buttonApdungAll";
		this.buttonApdungAll.Size = new System.Drawing.Size(142, 22);
		this.buttonApdungAll.TabIndex = 41;
		this.buttonApdungAll.Text = "Áp dụng cho tất cả ac";
		this.buttonApdungAll.UseVisualStyleBackColor = true;
		this.buttonApdungAll.Click += new System.EventHandler(buttonApdungAll_Click);
		this.checkBoxGiudoTim.AutoSize = true;
		this.checkBoxGiudoTim.Location = new System.Drawing.Point(161, 3);
		this.checkBoxGiudoTim.Name = "checkBoxGiudoTim";
		this.checkBoxGiudoTim.Size = new System.Drawing.Size(76, 17);
		this.checkBoxGiudoTim.TabIndex = 42;
		this.checkBoxGiudoTim.Text = "Giữ đồ tím";
		this.checkBoxGiudoTim.UseVisualStyleBackColor = true;
		this.checkBoxGiudoTim.CheckedChanged += new System.EventHandler(checkBoxGiudoTim_CheckedChanged);
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Controls.Add(this.tabPage3);
		this.tabControl1.Location = new System.Drawing.Point(0, 71);
		this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(340, 410);
		this.tabControl1.TabIndex = 43;
		this.tabPage1.Controls.Add(this.buttonBoCheck);
		this.tabPage1.Controls.Add(this.textBoxDongDC);
		this.tabPage1.Controls.Add(this.textBoxDongNB);
		this.tabPage1.Controls.Add(this.checkBoxNgocBoi);
		this.tabPage1.Controls.Add(this.textBoxDongNhan);
		this.tabPage1.Controls.Add(this.checkBoxDaychuyen);
		this.tabPage1.Controls.Add(this.checkBoxGiuTrangsuc);
		this.tabPage1.Controls.Add(this.checkBoxThoahet);
		this.tabPage1.Controls.Add(this.textBoxName);
		this.tabPage1.Controls.Add(this.checkBoxGiudoTim);
		this.tabPage1.Controls.Add(this.checkBoxGiudoTheoThuoctinh);
		this.tabPage1.Controls.Add(this.checkBoxGiudoTheoCap);
		this.tabPage1.Controls.Add(this.comboBoxCap);
		this.tabPage1.Controls.Add(this.textBoxMin);
		this.tabPage1.Controls.Add(this.checkBoxGiudoTheoHe);
		this.tabPage1.Controls.Add(this.comboBoxHe);
		this.tabPage1.Controls.Add(this.buttonSua);
		this.tabPage1.Controls.Add(this.listView1);
		this.tabPage1.Location = new System.Drawing.Point(4, 22);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(332, 384);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Bảng thuộc tính ";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.buttonBoCheck.Location = new System.Drawing.Point(3, 360);
		this.buttonBoCheck.Name = "buttonBoCheck";
		this.buttonBoCheck.Size = new System.Drawing.Size(102, 21);
		this.buttonBoCheck.TabIndex = 49;
		this.buttonBoCheck.Text = "Bỏ check tất cả";
		this.buttonBoCheck.UseVisualStyleBackColor = true;
		this.buttonBoCheck.Click += new System.EventHandler(buttonBoCheck_Click);
		this.textBoxDongDC.Location = new System.Drawing.Point(120, 49);
		this.textBoxDongDC.Name = "textBoxDongDC";
		this.textBoxDongDC.Size = new System.Drawing.Size(27, 20);
		this.textBoxDongDC.TabIndex = 48;
		this.textBoxDongDC.TextChanged += new System.EventHandler(textBoxDongDC_TextChanged);
		this.textBoxDongNB.Location = new System.Drawing.Point(120, 26);
		this.textBoxDongNB.Name = "textBoxDongNB";
		this.textBoxDongNB.Size = new System.Drawing.Size(27, 20);
		this.textBoxDongNB.TabIndex = 47;
		this.textBoxDongNB.TextChanged += new System.EventHandler(textBoxDongNB_TextChanged);
		this.checkBoxNgocBoi.AutoSize = true;
		this.checkBoxNgocBoi.Location = new System.Drawing.Point(3, 26);
		this.checkBoxNgocBoi.Name = "checkBoxNgocBoi";
		this.checkBoxNgocBoi.Size = new System.Drawing.Size(104, 17);
		this.checkBoxNgocBoi.TabIndex = 46;
		this.checkBoxNgocBoi.Text = "Giữ ngọc bội, >=";
		this.checkBoxNgocBoi.UseVisualStyleBackColor = true;
		this.checkBoxNgocBoi.CheckedChanged += new System.EventHandler(checkBoxNgocBoi_CheckedChanged);
		this.textBoxDongNhan.Location = new System.Drawing.Point(120, 3);
		this.textBoxDongNhan.Name = "textBoxDongNhan";
		this.textBoxDongNhan.Size = new System.Drawing.Size(27, 20);
		this.textBoxDongNhan.TabIndex = 46;
		this.textBoxDongNhan.TextChanged += new System.EventHandler(textBoxDongNhan_TextChanged);
		this.checkBoxDaychuyen.AutoSize = true;
		this.checkBoxDaychuyen.Location = new System.Drawing.Point(4, 49);
		this.checkBoxDaychuyen.Name = "checkBoxDaychuyen";
		this.checkBoxDaychuyen.Size = new System.Drawing.Size(118, 17);
		this.checkBoxDaychuyen.TabIndex = 45;
		this.checkBoxDaychuyen.Text = "Giữ dây chuyền, >=";
		this.checkBoxDaychuyen.UseVisualStyleBackColor = true;
		this.checkBoxDaychuyen.CheckedChanged += new System.EventHandler(checkBoxDaychuyen_CheckedChanged);
		this.checkBoxGiuTrangsuc.AutoSize = true;
		this.checkBoxGiuTrangsuc.Location = new System.Drawing.Point(3, 3);
		this.checkBoxGiuTrangsuc.Name = "checkBoxGiuTrangsuc";
		this.checkBoxGiuTrangsuc.Size = new System.Drawing.Size(114, 17);
		this.checkBoxGiuTrangsuc.TabIndex = 44;
		this.checkBoxGiuTrangsuc.Text = "Giữ nhẫn, dòng >=";
		this.checkBoxGiuTrangsuc.UseVisualStyleBackColor = true;
		this.checkBoxGiuTrangsuc.CheckedChanged += new System.EventHandler(checkBoxGiuTrangsuc_CheckedChanged);
		this.checkBoxThoahet.AutoSize = true;
		this.checkBoxThoahet.ForeColor = System.Drawing.Color.DarkBlue;
		this.checkBoxThoahet.Location = new System.Drawing.Point(3, 96);
		this.checkBoxThoahet.Name = "checkBoxThoahet";
		this.checkBoxThoahet.Size = new System.Drawing.Size(269, 17);
		this.checkBoxThoahet.TabIndex = 43;
		this.checkBoxThoahet.Text = "Thỏa mãn đúng hết điều kiện thuộc tính thì mới giữ";
		this.checkBoxThoahet.UseVisualStyleBackColor = true;
		this.checkBoxThoahet.CheckedChanged += new System.EventHandler(checkBoxThoahet_CheckedChanged);
		this.tabPage2.Controls.Add(this.buttonXj);
		this.tabPage2.Controls.Add(this.buttonS);
		this.tabPage2.Controls.Add(this.buttonO);
		this.tabPage2.Controls.Add(this.buttonAppdungAll2);
		this.tabPage2.Controls.Add(this.listView2);
		this.tabPage2.Controls.Add(this.buttonThem);
		this.tabPage2.Controls.Add(this.comboBoxTenVatpham);
		this.tabPage2.Controls.Add(this.buttonXoa);
		this.tabPage2.Controls.Add(this.labelVidu);
		this.tabPage2.Location = new System.Drawing.Point(4, 22);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(332, 384);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "Vật phẩm không nhặt";
		this.tabPage2.UseVisualStyleBackColor = true;
		this.buttonAppdungAll2.ForeColor = System.Drawing.Color.Black;
		this.buttonAppdungAll2.Location = new System.Drawing.Point(191, 355);
		this.buttonAppdungAll2.Name = "buttonAppdungAll2";
		this.buttonAppdungAll2.Size = new System.Drawing.Size(140, 26);
		this.buttonAppdungAll2.TabIndex = 44;
		this.buttonAppdungAll2.Text = "Áp dụng cho tất cả ac";
		this.buttonAppdungAll2.UseVisualStyleBackColor = true;
		this.buttonAppdungAll2.Click += new System.EventHandler(buttonAppdungAll2_Click);
		this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader_3, this.columnHeader_4 });
		this.listView2.FullRowSelect = true;
		this.listView2.GridLines = true;
		this.listView2.HideSelection = false;
		this.listView2.Location = new System.Drawing.Point(1, 1);
		this.listView2.Name = "listView2";
		this.listView2.Size = new System.Drawing.Size(330, 261);
		this.listView2.TabIndex = 35;
		this.listView2.UseCompatibleStateImageBehavior = false;
		this.listView2.View = System.Windows.Forms.View.Details;
		this.listView2.MouseUp += new System.Windows.Forms.MouseEventHandler(listView2_MouseUp);
		this.columnHeader_3.Text = "No";
		this.columnHeader_3.Width = 45;
		this.columnHeader_4.Text = "Tên vật phẩm";
		this.columnHeader_4.Width = 260;
		this.buttonThem.Location = new System.Drawing.Point(175, 268);
		this.buttonThem.Name = "buttonThem";
		this.buttonThem.Size = new System.Drawing.Size(52, 21);
		this.buttonThem.TabIndex = 40;
		this.buttonThem.Text = "Thêm";
		this.buttonThem.UseVisualStyleBackColor = true;
		this.buttonThem.Click += new System.EventHandler(buttonThem_Click);
		this.comboBoxTenVatpham.FormattingEnabled = true;
		this.comboBoxTenVatpham.Location = new System.Drawing.Point(3, 268);
		this.comboBoxTenVatpham.Name = "comboBoxTenVatpham";
		this.comboBoxTenVatpham.Size = new System.Drawing.Size(170, 21);
		this.comboBoxTenVatpham.TabIndex = 36;
		this.comboBoxTenVatpham.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenVatpham_MouseDown);
		this.buttonXoa.Location = new System.Drawing.Point(230, 268);
		this.buttonXoa.Name = "buttonXoa";
		this.buttonXoa.Size = new System.Drawing.Size(40, 21);
		this.buttonXoa.TabIndex = 41;
		this.buttonXoa.Text = "Xóa";
		this.buttonXoa.UseVisualStyleBackColor = true;
		this.buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		this.labelVidu.AutoSize = true;
		this.labelVidu.Location = new System.Drawing.Point(4, 298);
		this.labelVidu.Name = "labelVidu";
		this.labelVidu.Size = new System.Drawing.Size(323, 39);
		this.labelVidu.TabIndex = 42;
		this.labelVidu.Text = "Tên vật phẩm không nhặt có thể ghi rút gọn.\r\nVí dụ ghi: Phúc Duyên\r\nThì sẽ không nhặt tất cả các loại Phúc Duyên (đại, trung và tiểu)...";
		this.tabPage3.Controls.Add(this.label1);
		this.tabPage3.Location = new System.Drawing.Point(4, 22);
		this.tabPage3.Name = "tabPage3";
		this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage3.Size = new System.Drawing.Size(332, 384);
		this.tabPage3.TabIndex = 2;
		this.tabPage3.Text = "Lưu ý chung";
		this.tabPage3.UseVisualStyleBackColor = true;
		this.label1.Location = new System.Drawing.Point(3, 3);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(326, 161);
		this.label1.TabIndex = 0;
		this.label1.Text = resources.GetString("label1.Text");
		this.checkBoxNhatTrongthanh.AutoSize = true;
		this.checkBoxNhatTrongthanh.ForeColor = System.Drawing.Color.Black;
		this.checkBoxNhatTrongthanh.Location = new System.Drawing.Point(3, 3);
		this.checkBoxNhatTrongthanh.Name = "checkBoxNhatTrongthanh";
		this.checkBoxNhatTrongthanh.Size = new System.Drawing.Size(106, 17);
		this.checkBoxNhatTrongthanh.TabIndex = 45;
		this.checkBoxNhatTrongthanh.Text = "Nhặt trong thành";
		this.checkBoxNhatTrongthanh.UseVisualStyleBackColor = true;
		this.checkBoxNhatTrongthanh.CheckedChanged += new System.EventHandler(checkBoxNhatTrongthanh_CheckedChanged);
		this.comboBoxBando.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxBando.ForeColor = System.Drawing.Color.Black;
		this.comboBoxBando.FormattingEnabled = true;
		this.comboBoxBando.Location = new System.Drawing.Point(200, 37);
		this.comboBoxBando.Name = "comboBoxBando";
		this.comboBoxBando.Size = new System.Drawing.Size(140, 21);
		this.comboBoxBando.TabIndex = 46;
		this.comboBoxBando.SelectedIndexChanged += new System.EventHandler(comboBoxBando_SelectedIndexChanged);
		this.checkBoxNhatTheoThuoctinh.AutoSize = true;
		this.checkBoxNhatTheoThuoctinh.ForeColor = System.Drawing.Color.DarkBlue;
		this.checkBoxNhatTheoThuoctinh.Location = new System.Drawing.Point(3, 49);
		this.checkBoxNhatTheoThuoctinh.Name = "checkBoxNhatTheoThuoctinh";
		this.checkBoxNhatTheoThuoctinh.Size = new System.Drawing.Size(184, 17);
		this.checkBoxNhatTheoThuoctinh.TabIndex = 47;
		this.checkBoxNhatTheoThuoctinh.Text = "Nhặt theo bảng thuộc tính ở dưới";
		this.checkBoxNhatTheoThuoctinh.UseVisualStyleBackColor = true;
		this.checkBoxNhatTheoThuoctinh.CheckedChanged += new System.EventHandler(checkBoxNhatTheoThuoctinh_CheckedChanged);
		this.checkBoxKhongNhatdoTim.AutoSize = true;
		this.checkBoxKhongNhatdoTim.ForeColor = System.Drawing.Color.Black;
		this.checkBoxKhongNhatdoTim.Location = new System.Drawing.Point(3, 26);
		this.checkBoxKhongNhatdoTim.Name = "checkBoxKhongNhatdoTim";
		this.checkBoxKhongNhatdoTim.Size = new System.Drawing.Size(115, 17);
		this.checkBoxKhongNhatdoTim.TabIndex = 48;
		this.checkBoxKhongNhatdoTim.Text = "Không nhặt đồ tím";
		this.checkBoxKhongNhatdoTim.UseVisualStyleBackColor = true;
		this.checkBoxKhongNhatdoTim.CheckedChanged += new System.EventHandler(checkBoxKhongNhatdoTim_CheckedChanged);
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.DarkRed;
		this.label2.Location = new System.Drawing.Point(3, 489);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(88, 13);
		this.label2.TabIndex = 50;
		this.label2.Text = "Tốc độ nhặt (ms)";
		this.textBoxTocdoNhat.ForeColor = System.Drawing.Color.Black;
		this.textBoxTocdoNhat.Location = new System.Drawing.Point(93, 486);
		this.textBoxTocdoNhat.Name = "textBoxTocdoNhat";
		this.textBoxTocdoNhat.Size = new System.Drawing.Size(33, 20);
		this.textBoxTocdoNhat.TabIndex = 47;
		this.textBoxTocdoNhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBoxTocdoNhat.TextChanged += new System.EventHandler(textBoxTocdoNhat_TextChanged);
		this.buttonO.Image = ns16.Class16.Bitmap_0;
		this.buttonO.Location = new System.Drawing.Point(3, 345);
		this.buttonO.Name = "buttonO";
		this.buttonO.Size = new System.Drawing.Size(84, 36);
		this.buttonO.TabIndex = 45;
		this.buttonO.Text = "Open";
		this.buttonO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.buttonO.UseVisualStyleBackColor = true;
		this.buttonO.Click += new System.EventHandler(buttonO_Click);
		this.buttonS.Image = ns16.Class16.Bitmap_1;
		this.buttonS.Location = new System.Drawing.Point(89, 345);
		this.buttonS.Name = "buttonS";
		this.buttonS.Size = new System.Drawing.Size(84, 36);
		this.buttonS.TabIndex = 46;
		this.buttonS.Text = "Save";
		this.buttonS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.buttonS.UseVisualStyleBackColor = true;
		this.buttonS.Click += new System.EventHandler(buttonS_Click);
		this.buttonXj.Location = new System.Drawing.Point(272, 268);
		this.buttonXj.Name = "buttonXj";
		this.buttonXj.Size = new System.Drawing.Size(60, 21);
		this.buttonXj.TabIndex = 47;
		this.buttonXj.Text = "Xóa hết";
		this.buttonXj.UseVisualStyleBackColor = true;
		this.buttonXj.Click += new System.EventHandler(buttonXj_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(345, 511);
		base.Controls.Add(this.textBoxTocdoNhat);
		base.Controls.Add(this.checkBoxNhatTheoThuoctinh);
		base.Controls.Add(this.buttonApdungAll);
		base.Controls.Add(this.comboBoxBando);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.checkBoxBando);
		base.Controls.Add(this.checkBoxKhongNhatdoTim);
		base.Controls.Add(this.checkBoxNhatTrongthanh);
		base.Controls.Add(this.tabControl1);
		base.Controls.Add(this.buttonClose);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormLocdo";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "NHAT DO";
		base.Load += new System.EventHandler(FormLocdo_Load);
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage1.PerformLayout();
		this.tabPage2.ResumeLayout(false);
		this.tabPage2.PerformLayout();
		this.tabPage3.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
