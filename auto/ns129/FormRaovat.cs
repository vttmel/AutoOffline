using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns23;
using ns3;
using ns31;
using ns53;
using ns68;
using ns71;
using ns83;

namespace ns129;

public class FormRaovat : Form
{
	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static int int_1 = 0;

	public static string[] string_0 = null;

	public static string string_1 = "NoAcceptBho.txt";

	public static string[,] string_2 = new string[5, 2]
	{
		{ "Thế giới", "CH_WORLD" },
		{ "Thành thị", "CH_CITY" },
		{ "Bang hội", "CH_TONG" },
		{ "Phòng tán", "CH_CHATROOM" },
		{ "Phụ cận", "CH_NEARBY" }
	};

	private static string string_3 = "ᓯᓥᔍᕪᔞᓕᔀᔎᔀᔚᔤᔭᔚᓕᔦᔪᔖᓕᔥᔝᖩᓕᔩᔧᖣᓕᔗᕿᔢᓕᔘᖀᔥᓕᔣᔝᖀᔩᓕᔖᔪᔩᔤᓕᔣᔝᖅᓕᔘᕭᔘᓕᔩᔝᖒᔢᓡᓕᕣᕬᓕᔘᖘᓕᔬᔚᔗᓕᔧᖚᔞᓕᓖᓣᓣᓣ";

	private string[] string_4 = null;

	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonClose;

	private ComboBox comboBoxRaoVat;

	private TextBox textBoxTimeRaoVat;

	private TextBox textBoxTextRaoVat;

	private CheckBox checkBoxRaoVat;

	private Label label1;

	private Label label2;

	private CheckBox checkBoxBomNoiluc;

	private CheckBox checkBoxRaoHinhanh;

	private GroupBox groupBoxRaovat;

	private CheckBox checkBoxAceptBH;

	private ListView listView2;

	private ColumnHeader columnHeader_0;

	private Label label3;

	private Button buttonXoaDanhAc;

	private ComboBox comboBoxKhongdanhAc;

	private GroupBox groupBox1;

	private Button button1;

	public FormRaovat()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	public static void smethod_0()
	{
		int int_ = int_1;
		int_1 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (Class11.bool_0 || num < 0 || Form1.characterAccountConfig_1[num].int_69[0] <= 0)
				{
					if (0 <= num)
					{
						Form1.characterAccountConfig_1[num].bool_48 = false;
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_48)
					{
						break;
					}
					Form1.characterAccountConfig_1[num].bool_48 = true;
					flag = true;
				}
				smethod_1(int_);
			}
			catch
			{
			}
			Thread.Sleep(600);
		}
	}

	private static void smethod_1(int int_2)
	{
		int num = 0;
		int int_3 = 0;
		byte[] array = new byte[4];
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		int[] array2 = new int[string_2.GetLength(0)];
		array2[0] = 80;
		array2[1] = 20;
		array2[2] = 10;
		long long_ = 0L;
		string text = null;
		uint uint_ = 38u;
		uint uint_2 = 13u;
		while (true)
		{
			Thread.Sleep(800);
			num--;
			if (num <= 0)
			{
				int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
				if (Class11.bool_0 || num2 < 0 || Form1.characterAccountConfig_1[num2].int_69[0] <= 0)
				{
					break;
				}
				characterAccountConfig_ = Form1.characterAccountConfig_1[num2];
				text = null;
				num = 3;
			}
			if (characterAccountConfig_.string_10 == null || characterAccountConfig_.string_10 == string.Empty)
			{
				continue;
			}
			long num3 = Class11.smethod_28(long_);
			if (num3 < 1200L || num3 < characterAccountConfig_.int_69[2])
			{
				continue;
			}
			if (characterAccountConfig_.int_69[4] > 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_3);
				uint num4 = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num4 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_3);
				uint num5 = BitConverter.ToUInt32(array, 0) * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_3);
				uint num6 = BitConverter.ToUInt32(array, 0);
				uint num7 = num6 + num5;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num7 + Class56.memorySignatureScanConfig_46.uint_0, array, 4, ref int_3);
				int num8 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num7 + Class56.memorySignatureScanConfig_48.uint_0, array, 4, ref int_3);
				int num9 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num7 + Class56.memorySignatureScanConfig_48.uint_0 + 4, array, 4, ref int_3);
				int num10 = BitConverter.ToInt32(array, 0);
				if (num10 > num9 && num10 < 5000000)
				{
					num9 = num10;
				}
				int num11 = array2[characterAccountConfig_.int_69[1]] * num9;
				if (num8 * 100 < num11 && Class32.smethod_12(characterAccountConfig_, 1) > 0)
				{
					int i = 0;
					int num12 = num8;
					for (; i < 7; i++)
					{
						if (Class11.bool_0)
						{
							break;
						}
						Thread.Sleep(800);
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num7 + Class56.memorySignatureScanConfig_46.uint_0, array, 4, ref int_3);
						num8 = BitConverter.ToInt32(array, 0);
						if (num11 <= num8 * 100 || num8 <= num12)
						{
							break;
						}
						num12 = num8;
					}
				}
			}
			if (characterAccountConfig_.int_69[3] <= 0)
			{
				if (text == null || text == string.Empty)
				{
					text = characterAccountConfig_.string_10.Replace("\n", string.Empty);
				}
				Class75.smethod_57(characterAccountConfig_, "Chat('" + string_2[characterAccountConfig_.int_69[1], 1] + "', '" + text + "')");
			}
			else
			{
				Class75.smethod_57(characterAccountConfig_, "Focus([[commandline]])");
				Thread.Sleep(300);
				Class24.smethod_4(characterAccountConfig_.uint_4, uint_);
				Thread.Sleep(100);
				Class24.smethod_4(characterAccountConfig_.uint_4, uint_2);
			}
			long_ = Class11.smethod_27();
		}
	}

	private void FormRaovat_Load(object sender, EventArgs e)
	{
		for (int i = 0; i < string_2.GetLength(0); i++)
		{
			comboBoxRaoVat.Items.Add(string_2[i, 0]);
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (0 > num)
		{
			groupBoxRaovat.Enabled = false;
			checkBoxAceptBH.Enabled = false;
			textBoxTextRaoVat.Text = "Hãy chọn 1 ac trước rồi bấm nút Rao vặt để vào đây thiết lập";
		}
		else
		{
			CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[num];
			if (characterAccountConfig.string_10 == "null")
			{
				string string_ = Class11.smethod_54(string_3);
				Form1.characterAccountConfig_1[num].string_10 = string_;
				characterAccountConfig.string_10 = string_;
			}
			textBoxTextRaoVat.Text = characterAccountConfig.string_10;
			checkBoxRaoVat.Checked = characterAccountConfig.int_69[0] > 0;
			comboBoxRaoVat.Text = string_2[characterAccountConfig.int_69[1], 0];
			textBoxTimeRaoVat.Text = characterAccountConfig.int_69[2].ToString();
			checkBoxRaoHinhanh.Checked = characterAccountConfig.int_69[3] > 0;
			checkBoxBomNoiluc.Checked = characterAccountConfig.int_69[4] > 0;
			textBoxTextRaoVat.Enabled = characterAccountConfig.int_69[3] <= 0;
			comboBoxRaoVat.Enabled = characterAccountConfig.int_69[3] <= 0;
			groupBoxRaovat.Text = Class1.smethod_1(characterAccountConfig.string_22, 1);
			checkBoxAceptBH.Checked = characterAccountConfig.bool_17;
		}
		string_0 = Class72.smethod_0(string_1);
		if (string_0 != null)
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (string_0[j] != null)
				{
					method_1(listView2, Class1.smethod_1(string_0[j], 1));
				}
			}
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		base.Top = Cursor.Position.Y - base.Height - 10;
		base.Left = Cursor.Position.X - base.Width - 10;
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
		int_0 = 0;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxRaoVat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_69[0] = Convert.ToByte(checkBoxRaoVat.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxRaoVat_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxRaoVat.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_2.Length)
			{
				if (text == string_2[num2, 0])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		Form1.characterAccountConfig_1[num].int_69[1] = num2;
		Class56.smethod_13(Form1.characterAccountConfig_1[num]);
	}

	private void textBoxTimeRaoVat_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_69[2] = Class11.smethod_11(textBoxTimeRaoVat.Text);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxTextRaoVat_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].string_10 = textBoxTextRaoVat.Text;
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxRaoHinhanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_69[3] = Convert.ToByte(checkBoxRaoHinhanh.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
				textBoxTextRaoVat.Enabled = Form1.characterAccountConfig_1[num].int_69[3] <= 0;
				comboBoxRaoVat.Enabled = Form1.characterAccountConfig_1[num].int_69[3] <= 0;
			}
		}
	}

	private void checkBoxBomNoiluc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_69[4] = Convert.ToByte(checkBoxBomNoiluc.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxKhongdanhAc_MouseDown(object sender, MouseEventArgs e)
	{
		string_4 = null;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Class3.smethod_25(Form1.characterAccountConfig_1[i], ref string_4, 1);
			}
		}
		comboBoxKhongdanhAc.Items.Clear();
		if (string_4 != null)
		{
			Array.Sort(string_4);
			for (int j = 0; j < string_4.Length; j++)
			{
				comboBoxKhongdanhAc.Items.Add(Class1.smethod_1(string_4[j], 1));
			}
		}
	}

	private void comboBoxKhongdanhAc_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_0(listView2, comboBoxKhongdanhAc.Text, string_4, ref string_0);
		Class72.smethod_1(string_0, string_1);
	}

	private void method_0(ListView listView_0, string string_5, string[] string_6, ref string[] string_7)
	{
		if (string_5 == null || string_5 == string.Empty || string_6 == null)
		{
			return;
		}
		if (string_7 != null)
		{
			for (int i = 0; i < string_7.Length; i++)
			{
				if (string_5 == Class1.smethod_1(string_7[i], 1))
				{
					return;
				}
			}
		}
		for (int j = 0; j < string_6.Length; j++)
		{
			if (string_5 == Class1.smethod_1(string_6[j], 1))
			{
				string_5 = string_6[j];
				break;
			}
		}
		if (string_7 == null)
		{
			string_7 = new string[1] { string_5 };
		}
		else
		{
			string[] array = new string[string_7.Length + 1];
			for (int k = 0; k < string_7.Length; k++)
			{
				array[k] = string_7[k];
			}
			string_7 = new string[array.Length];
			for (int l = 0; l < string_7.Length; l++)
			{
				string_7[l] = array[l];
			}
			string_7[string_7.Length - 1] = string_5;
		}
		method_1(listView_0, Class1.smethod_1(string_5, 1));
	}

	private void method_1(ListView listView_0, string string_5)
	{
		try
		{
			string[] array = new string[1] { string_5 };
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

	private void checkBoxAceptBH_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].bool_17 = checkBoxAceptBH.Checked;
			}
		}
	}

	private void buttonXoaDanhAc_Click(object sender, EventArgs e)
	{
		method_2(listView2, ref string_0);
		Class72.smethod_1(string_0, string_1);
	}

	private void method_2(ListView listView_0, ref string[] string_5)
	{
		if (string_5 != null && string_5.Length != 0)
		{
			string empty = string.Empty;
			for (int i = 0; i < listView_0.Items.Count; i++)
			{
				if (listView_0.Items[i].Selected)
				{
					empty = listView_0.Items[i].SubItems[0].Text;
					listView_0.Items.RemoveAt(i);
					break;
				}
			}
			if (empty == null || empty == string.Empty)
			{
				return;
			}
			string[] array = new string[string_5.Length];
			int num = 0;
			for (int j = 0; j < string_5.Length; j++)
			{
				if (empty != Class1.smethod_1(string_5[j], 1))
				{
					array[num] = string_5[j];
					num++;
				}
			}
			if (num != 0)
			{
				string_5 = new string[num];
				for (int k = 0; k < num; k++)
				{
					string_5[k] = array[k];
				}
			}
			else
			{
				listView_0.Items.Clear();
				string_5 = null;
			}
		}
		else
		{
			listView_0.Items.Clear();
			string_5 = null;
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				string string_ = Class11.smethod_54(string_3);
				Form1.characterAccountConfig_1[num].string_10 = string_;
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
				textBoxTextRaoVat.Text = string_;
			}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns129.FormRaovat));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonClose = new System.Windows.Forms.Button();
		this.comboBoxRaoVat = new System.Windows.Forms.ComboBox();
		this.textBoxTimeRaoVat = new System.Windows.Forms.TextBox();
		this.textBoxTextRaoVat = new System.Windows.Forms.TextBox();
		this.checkBoxRaoVat = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.checkBoxBomNoiluc = new System.Windows.Forms.CheckBox();
		this.checkBoxRaoHinhanh = new System.Windows.Forms.CheckBox();
		this.groupBoxRaovat = new System.Windows.Forms.GroupBox();
		this.checkBoxAceptBH = new System.Windows.Forms.CheckBox();
		this.listView2 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.label3 = new System.Windows.Forms.Label();
		this.buttonXoaDanhAc = new System.Windows.Forms.Button();
		this.comboBoxKhongdanhAc = new System.Windows.Forms.ComboBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.button1 = new System.Windows.Forms.Button();
		this.groupBoxRaovat.SuspendLayout();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonClose.BackColor = System.Drawing.SystemColors.Control;
		this.buttonClose.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.buttonClose.ForeColor = System.Drawing.Color.Black;
		this.buttonClose.Location = new System.Drawing.Point(241, 339);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(77, 26);
		this.buttonClose.TabIndex = 139;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = false;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.comboBoxRaoVat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxRaoVat.DropDownWidth = 80;
		this.comboBoxRaoVat.FormattingEnabled = true;
		this.comboBoxRaoVat.Location = new System.Drawing.Point(222, 80);
		this.comboBoxRaoVat.Name = "comboBoxRaoVat";
		this.comboBoxRaoVat.Size = new System.Drawing.Size(84, 21);
		this.comboBoxRaoVat.TabIndex = 212;
		this.comboBoxRaoVat.SelectedIndexChanged += new System.EventHandler(comboBoxRaoVat_SelectedIndexChanged);
		this.textBoxTimeRaoVat.Location = new System.Drawing.Point(246, 105);
		this.textBoxTimeRaoVat.Name = "textBoxTimeRaoVat";
		this.textBoxTimeRaoVat.Size = new System.Drawing.Size(60, 20);
		this.textBoxTimeRaoVat.TabIndex = 210;
		this.textBoxTimeRaoVat.Text = "30000";
		this.textBoxTimeRaoVat.TextChanged += new System.EventHandler(textBoxTimeRaoVat_TextChanged);
		this.textBoxTextRaoVat.BackColor = System.Drawing.Color.White;
		this.textBoxTextRaoVat.Location = new System.Drawing.Point(9, 12);
		this.textBoxTextRaoVat.Multiline = true;
		this.textBoxTextRaoVat.Name = "textBoxTextRaoVat";
		this.textBoxTextRaoVat.Size = new System.Drawing.Size(297, 64);
		this.textBoxTextRaoVat.TabIndex = 211;
		this.textBoxTextRaoVat.Text = ":@TËp trung MCQ nhanh";
		this.textBoxTextRaoVat.TextChanged += new System.EventHandler(textBoxTextRaoVat_TextChanged);
		this.checkBoxRaoVat.AutoSize = true;
		this.checkBoxRaoVat.ForeColor = System.Drawing.Color.Black;
		this.checkBoxRaoVat.Location = new System.Drawing.Point(15, 345);
		this.checkBoxRaoVat.Name = "checkBoxRaoVat";
		this.checkBoxRaoVat.Size = new System.Drawing.Size(100, 17);
		this.checkBoxRaoVat.TabIndex = 209;
		this.checkBoxRaoVat.Text = "Bắt đầu rao vặt";
		this.checkBoxRaoVat.UseVisualStyleBackColor = true;
		this.checkBoxRaoVat.CheckedChanged += new System.EventHandler(checkBoxRaoVat_CheckedChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(77, 108);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(163, 13);
		this.label1.TabIndex = 213;
		this.label1.Text = "Thời gian giữa 2 lần rao (mili giây)";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(128, 83);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(88, 13);
		this.label2.TabIndex = 214;
		this.label2.Text = "Chọn tầng số rao";
		this.checkBoxBomNoiluc.AutoSize = true;
		this.checkBoxBomNoiluc.Location = new System.Drawing.Point(11, 133);
		this.checkBoxBomNoiluc.Name = "checkBoxBomNoiluc";
		this.checkBoxBomNoiluc.Size = new System.Drawing.Size(96, 17);
		this.checkBoxBomNoiluc.TabIndex = 215;
		this.checkBoxBomNoiluc.Text = "Có bơm nội lực";
		this.checkBoxBomNoiluc.UseVisualStyleBackColor = true;
		this.checkBoxBomNoiluc.CheckedChanged += new System.EventHandler(checkBoxBomNoiluc_CheckedChanged);
		this.checkBoxRaoHinhanh.ForeColor = System.Drawing.Color.MediumBlue;
		this.checkBoxRaoHinhanh.Location = new System.Drawing.Point(11, 153);
		this.checkBoxRaoHinhanh.Name = "checkBoxRaoHinhanh";
		this.checkBoxRaoHinhanh.Size = new System.Drawing.Size(282, 34);
		this.checkBoxRaoHinhanh.TabIndex = 216;
		this.checkBoxRaoHinhanh.Text = "Rao vặt có hình ảnh (bạn phải rao trước trong game 1 lần, auto gửi phím enter để rao)";
		this.checkBoxRaoHinhanh.UseVisualStyleBackColor = true;
		this.checkBoxRaoHinhanh.CheckedChanged += new System.EventHandler(checkBoxRaoHinhanh_CheckedChanged);
		this.groupBoxRaovat.Controls.Add(this.button1);
		this.groupBoxRaovat.Controls.Add(this.checkBoxRaoHinhanh);
		this.groupBoxRaovat.Controls.Add(this.checkBoxBomNoiluc);
		this.groupBoxRaovat.Controls.Add(this.label2);
		this.groupBoxRaovat.Controls.Add(this.label1);
		this.groupBoxRaovat.Controls.Add(this.comboBoxRaoVat);
		this.groupBoxRaovat.Controls.Add(this.textBoxTimeRaoVat);
		this.groupBoxRaovat.Controls.Add(this.textBoxTextRaoVat);
		this.groupBoxRaovat.Location = new System.Drawing.Point(4, 2);
		this.groupBoxRaovat.Name = "groupBoxRaovat";
		this.groupBoxRaovat.Size = new System.Drawing.Size(314, 194);
		this.groupBoxRaovat.TabIndex = 217;
		this.groupBoxRaovat.TabStop = false;
		this.checkBoxAceptBH.Location = new System.Drawing.Point(9, 23);
		this.checkBoxAceptBH.Name = "checkBoxAceptBH";
		this.checkBoxAceptBH.Size = new System.Drawing.Size(147, 37);
		this.checkBoxAceptBH.TabIndex = 218;
		this.checkBoxAceptBH.Text = "Tự động cho ac vào bang (đội trưởng trở lên)";
		this.checkBoxAceptBH.UseVisualStyleBackColor = true;
		this.checkBoxAceptBH.CheckedChanged += new System.EventHandler(checkBoxAceptBH_CheckedChanged);
		this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_0 });
		this.listView2.FullRowSelect = true;
		this.listView2.GridLines = true;
		this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listView2.HideSelection = false;
		this.listView2.Location = new System.Drawing.Point(162, 23);
		this.listView2.MultiSelect = false;
		this.listView2.Name = "listView2";
		this.listView2.Size = new System.Drawing.Size(135, 59);
		this.listView2.TabIndex = 219;
		this.listView2.UseCompatibleStateImageBehavior = false;
		this.listView2.View = System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "No";
		this.columnHeader_0.Width = 115;
		this.label3.Location = new System.Drawing.Point(26, 63);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(115, 31);
		this.label3.TabIndex = 220;
		this.label3.Text = "Danh sách ac không duyệt vào bang =>";
		this.buttonXoaDanhAc.BackColor = System.Drawing.SystemColors.Control;
		this.buttonXoaDanhAc.ForeColor = System.Drawing.Color.Black;
		this.buttonXoaDanhAc.Location = new System.Drawing.Point(272, 87);
		this.buttonXoaDanhAc.Name = "buttonXoaDanhAc";
		this.buttonXoaDanhAc.Size = new System.Drawing.Size(25, 21);
		this.buttonXoaDanhAc.TabIndex = 467;
		this.buttonXoaDanhAc.Text = "X";
		this.buttonXoaDanhAc.UseVisualStyleBackColor = false;
		this.buttonXoaDanhAc.Click += new System.EventHandler(buttonXoaDanhAc_Click);
		this.comboBoxKhongdanhAc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxKhongdanhAc.DropDownWidth = 125;
		this.comboBoxKhongdanhAc.FormattingEnabled = true;
		this.comboBoxKhongdanhAc.Location = new System.Drawing.Point(162, 88);
		this.comboBoxKhongdanhAc.Name = "comboBoxKhongdanhAc";
		this.comboBoxKhongdanhAc.Size = new System.Drawing.Size(104, 21);
		this.comboBoxKhongdanhAc.TabIndex = 466;
		this.comboBoxKhongdanhAc.SelectedIndexChanged += new System.EventHandler(comboBoxKhongdanhAc_SelectedIndexChanged);
		this.comboBoxKhongdanhAc.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxKhongdanhAc_MouseDown);
		this.groupBox1.Controls.Add(this.buttonXoaDanhAc);
		this.groupBox1.Controls.Add(this.comboBoxKhongdanhAc);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.listView2);
		this.groupBox1.Controls.Add(this.checkBoxAceptBH);
		this.groupBox1.Location = new System.Drawing.Point(6, 205);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(311, 122);
		this.groupBox1.TabIndex = 468;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Tuyển member bang hội";
		this.button1.BackColor = System.Drawing.SystemColors.Control;
		this.button1.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.Black;
		this.button1.Location = new System.Drawing.Point(8, 80);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(58, 23);
		this.button1.TabIndex = 469;
		this.button1.Text = "Mặc định";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new System.EventHandler(button1_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(325, 385);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.groupBoxRaovat);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.checkBoxRaoVat);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormRaovat";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "RAO VAT";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormRaovat_Load);
		this.groupBoxRaovat.ResumeLayout(false);
		this.groupBoxRaovat.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
