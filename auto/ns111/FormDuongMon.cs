using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns109;
using ns11;
using ns23;
using ns43;
using ns53;
using ns61;
using ns63;
using ns71;
using ns79;
using ns83;

namespace ns111;

public class FormDuongMon : Form
{
	public int int_0;

	public int int_1;

	public static bool bool_0 = false;

	public static int int_2 = 0;

	public static int int_3 = Class66.smethod_4("SolanNhoiBoom", 0, "3");

	public static int int_4 = Class66.smethod_4("flagDatXungquanhAcChinh", 0, "1");

	public static int int_5 = Class66.smethod_4("KhoangCachDatBoom", 0, "200");

	private bool bool_1 = false;

	private IContainer icontainer_0 = null;

	private CheckBox checkBoxPhim1;

	private CheckBox checkBoxPhim2;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonClose;

	private CheckBox checkBoxPhim3;

	private CheckBox checkBoxDatXungQuanh;

	private TextBox textBoxKhoangCach;

	private ComboBox comboBoxBoom2;

	private ComboBox comboBoxBoom1;

	private ComboBox comboBoxBoom3;

	private RichTextBox richTextBox1;

	private ComboBox comboBoxTenAc;

	private Label label1;

	private GroupBox groupBox1;

	private ComboBox comboBoxSolanNhoiboom;

	private Label label2;

	public FormDuongMon()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	public static void smethod_0(CharacterAccountConfig characterAccountConfig_0, ref int int_6, uint[] uint_0, ref int int_7, bool bool_2)
	{
		int num = 0;
		int num2 = 0;
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
		uint num4 = Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
		uint num5 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		uint num6 = num5 + num4 * Class56.memorySignatureScanConfig_15.uint_0;
		if (Class64.smethod_29(characterAccountConfig_0, bool_0: true))
		{
			Thread.Sleep(150);
		}
		if (bool_2 && int_4 > 0)
		{
			int[] array = new int[18]
			{
				10, 90, 170, 250, 330, 70, 150, 230, 310, 350,
				50, 130, 210, 290, 30, 110, 190, 270
			};
			if (int_7 < 0 || array.Length <= int_7)
			{
				int_7 = 0;
			}
			int num7 = int_5;
			if (num7 > 50)
			{
				Random random = new Random();
				num7 = random.Next(50, num7);
			}
			double num8 = (double)Math.Abs(array[int_7]) * 3.14 / 180.0;
			uint[] array2 = new uint[2]
			{
				(uint)((double)uint_0[0] + (double)num7 * Math.Cos(num8)),
				(uint)((double)uint_0[1] - (double)num7 * Math.Sin(num8))
			};
			num = 0;
			num2 = 0;
			for (; num < 40; num++)
			{
				int num9 = (int)Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
				num2 = ((num9 <= 1) ? (num2 + 1) : 0);
				if (num2 > 10)
				{
					break;
				}
				Thread.Sleep(10);
			}
			if (num > 39)
			{
				Class75.smethod_57(characterAccountConfig_0, "Switch([[sit]])");
				Thread.Sleep(150);
			}
			int int_8 = 0;
			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_72.uint_0, new byte[4], 4, ref int_8);
			for (num = 0; num < 8; num++)
			{
				uint[] uint_1 = new uint[2]
				{
					Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
				long num10 = Class64.smethod_18(uint_1, array2);
				if (num10 < 7800L)
				{
					break;
				}
				Class75.smethod_61(characterAccountConfig_0, array2);
				Thread.Sleep(200);
			}
			int_7++;
		}
		int[,] array3 = new int[3, 2]
		{
			{
				characterAccountConfig_0.int_128[1],
				characterAccountConfig_0.int_128[2]
			},
			{
				characterAccountConfig_0.int_128[3],
				characterAccountConfig_0.int_128[4]
			},
			{
				characterAccountConfig_0.int_128[5],
				characterAccountConfig_0.int_128[6]
			}
		};
		int num11 = 0;
		do
		{
			int length = array3.GetLength(0);
			if (int_6 < 0 || length <= int_6)
			{
				int_6 = 0;
			}
			int num12 = int_6;
			while (array3[int_6, 0] <= 0 || array3[int_6, 1] <= 0)
			{
				int_6++;
				if (length <= int_6)
				{
					int_6 = 0;
				}
				if (num12 == int_6)
				{
					return;
				}
			}
			if (characterAccountConfig_0.int_136 != Class46.characterSyncSnapshot_0.int_0 || Form1.int_10 > 0 || Form1.int_11 > 0)
			{
				Class83.smethod_9(characterAccountConfig_0);
			}
			Class83.smethod_5(characterAccountConfig_0, array3[int_6, 1], 6, 1);
			int i = 0;
			int num13 = 0;
			for (; i < 15; i++)
			{
				int num14 = (int)Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
				num13 = ((num14 < 3) ? (num13 + 1) : 0);
				if (num13 > 6)
				{
					break;
				}
				Thread.Sleep(10);
			}
			i = 0;
			num13 = 0;
			for (; i < 60; i++)
			{
				if (i % 15 == 0)
				{
					if (FormDame.int_14 > 0)
					{
						Class24.smethod_76(characterAccountConfig_0.uint_4, 32);
					}
					else
					{
						Class24.smethod_76(characterAccountConfig_0.uint_4, 117);
					}
				}
				int num15 = (int)Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
				num13 = ((num15 < 4) ? (num13 + 1) : 0);
				if (num13 > 6)
				{
					break;
				}
				Thread.Sleep(10);
			}
			int_6++;
			num11++;
		}
		while (num11 < int_3);
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		int_0 = 0;
		int_1 = 0;
		int_2 = 0;
		bool_0 = false;
	}

	private void FormDuongMon_Load(object sender, EventArgs e)
	{
		timer_0.Enabled = false;
		bool_1 = false;
		if (int_0 > 0 && int_1 > 0)
		{
			int num = int_0 - base.Width - 10;
			int num2 = int_1 - base.Height - 10;
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
		CharacterAccountConfig characterAccountConfig_ = new CharacterAccountConfig
		{
			int_136 = 0
		};
		int num3 = -1;
		int num4 = -1;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				string text = Class83.smethod_18(Form1.characterAccountConfig_1[i]);
				if (text == "DUONGMON")
				{
					comboBoxTenAc.Items.Add(Class1.smethod_1(Form1.characterAccountConfig_1[i].string_22, 1));
					if (num3 <= 0)
					{
						num3 = Form1.characterAccountConfig_1[i].int_136;
						characterAccountConfig_ = Form1.characterAccountConfig_1[i];
					}
				}
			}
		}
		if (int_2 > 0)
		{
			int num5 = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
			if (0 <= num5)
			{
				string text2 = Class83.smethod_18(Form1.characterAccountConfig_1[num5]);
				if (text2 == "DUONGMON")
				{
					num4 = Form1.characterAccountConfig_1[num5].int_136;
					characterAccountConfig_ = Form1.characterAccountConfig_1[num5];
				}
			}
		}
		if (num4 <= 0 && num3 > 0)
		{
			num4 = num3;
		}
		int_2 = 0;
		groupBox1.Enabled = num4 > 0;
		if (num4 > 0)
		{
			int_2 = num4;
			comboBoxTenAc.Text = Class1.smethod_1(characterAccountConfig_.string_22, 1);
			GStruct58[] gstruct58_ = Class83.smethod_22(characterAccountConfig_);
			method_1(comboBoxBoom1, gstruct58_);
			method_1(comboBoxBoom2, gstruct58_);
			method_1(comboBoxBoom3, gstruct58_);
			checkBoxPhim1.Checked = characterAccountConfig_.int_128[1] > 0;
			checkBoxPhim2.Checked = characterAccountConfig_.int_128[3] > 0;
			checkBoxPhim3.Checked = characterAccountConfig_.int_128[5] > 0;
			comboBoxBoom1.Text = method_2(gstruct58_, characterAccountConfig_.int_128[2]);
			comboBoxBoom2.Text = method_2(gstruct58_, characterAccountConfig_.int_128[4]);
			comboBoxBoom3.Text = method_2(gstruct58_, characterAccountConfig_.int_128[6]);
		}
		for (int j = 1; j < 5; j++)
		{
			comboBoxSolanNhoiboom.Items.Add(j);
		}
		checkBoxDatXungQuanh.Checked = int_4 > 0;
		textBoxKhoangCach.Text = int_5.ToString();
		comboBoxSolanNhoiboom.Text = int_3.ToString();
		Thread.Sleep(100);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		bool_1 = true;
		base.TopMost = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void checkBoxPhim1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_128[1] = Convert.ToByte(checkBoxPhim1.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxPhim2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_128[3] = Convert.ToByte(checkBoxPhim2.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxPhim3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_128[5] = Convert.ToByte(checkBoxPhim3.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxDatXungQuanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_4 = Convert.ToByte(checkBoxDatXungQuanh.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagDatXungquanhAcChinh", int_4, "", 0);
		}
	}

	private void textBoxKhoangCach_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_5 = Class11.smethod_11(textBoxKhoangCach.Text);
			if (int_5 < 0)
			{
				int_5 = 0;
			}
			Class66.smethod_11(Class66.smethod_1(), "KhoangCachDatBoom", int_5, "", 0);
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		string text = "https://youtu.be/NPL9IJdsf3g";
		Class11.smethod_29(ref Class11.string_17, "Xem video hướng dẫn tại: " + text);
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
	}

	private bool method_1(ComboBox comboBox_0, GStruct58[] gstruct58_0)
	{
		comboBox_0.Items.Clear();
		if (gstruct58_0 != null)
		{
			for (int i = 0; i < gstruct58_0.Length; i++)
			{
				comboBox_0.Items.Add(gstruct58_0[i].string_0);
			}
			return true;
		}
		return false;
	}

	private string method_2(GStruct58[] gstruct58_0, int int_6)
	{
		if (int_6 > 0 && gstruct58_0 != null)
		{
			for (int i = 0; i < gstruct58_0.Length; i++)
			{
				if (gstruct58_0[i].int_1 == int_6)
				{
					return gstruct58_0[i].string_0;
				}
			}
		}
		return string.Empty;
	}

	private void comboBoxTenAc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int_2 = -1;
		string text = comboBoxTenAc.Text;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				if (text == Class1.smethod_1(Form1.characterAccountConfig_1[i].string_22, 1))
				{
					int_2 = Form1.characterAccountConfig_1[i].int_136;
					break;
				}
			}
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
		if (num >= 0)
		{
			CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
			bool_1 = false;
			GStruct58[] gstruct58_ = Class83.smethod_22(characterAccountConfig_);
			method_1(comboBoxBoom1, gstruct58_);
			method_1(comboBoxBoom2, gstruct58_);
			method_1(comboBoxBoom3, gstruct58_);
			checkBoxPhim1.Checked = characterAccountConfig_.int_128[1] > 0;
			checkBoxPhim2.Checked = characterAccountConfig_.int_128[3] > 0;
			checkBoxPhim3.Checked = characterAccountConfig_.int_128[5] > 0;
			comboBoxBoom1.Text = method_2(gstruct58_, characterAccountConfig_.int_128[2]);
			comboBoxBoom2.Text = method_2(gstruct58_, characterAccountConfig_.int_128[4]);
			comboBoxBoom3.Text = method_2(gstruct58_, characterAccountConfig_.int_128[5]);
			Thread.Sleep(60);
			bool_1 = true;
		}
	}

	private void comboBoxBoom1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
		if (num < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
		GStruct58[] array = Class83.smethod_22(characterAccountConfig_);
		if (array == null)
		{
			return;
		}
		int num2 = 0;
		string text = comboBoxBoom1.Text;
		for (int i = 0; i < array.Length; i++)
		{
			if (text == array[i].string_0)
			{
				num2 = array[i].int_1;
				break;
			}
		}
		num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
		if (0 <= num)
		{
			Form1.characterAccountConfig_1[num].int_128[2] = num2;
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		}
	}

	private void comboBoxBoom2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
		if (num < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
		GStruct58[] array = Class83.smethod_22(characterAccountConfig_);
		if (array == null)
		{
			return;
		}
		int num2 = 0;
		string text = comboBoxBoom2.Text;
		for (int i = 0; i < array.Length; i++)
		{
			if (text == array[i].string_0)
			{
				num2 = array[i].int_1;
				break;
			}
		}
		num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
		if (0 <= num)
		{
			Form1.characterAccountConfig_1[num].int_128[4] = num2;
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		}
	}

	private void comboBoxBoom3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
		if (num < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
		GStruct58[] array = Class83.smethod_22(characterAccountConfig_);
		if (array == null)
		{
			return;
		}
		int num2 = 0;
		string text = comboBoxBoom3.Text;
		for (int i = 0; i < array.Length; i++)
		{
			if (text == array[i].string_0)
			{
				num2 = array[i].int_1;
				break;
			}
		}
		num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
		if (0 <= num)
		{
			Form1.characterAccountConfig_1[num].int_128[6] = num2;
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns111.FormDuongMon));
		this.checkBoxPhim1 = new System.Windows.Forms.CheckBox();
		this.checkBoxPhim2 = new System.Windows.Forms.CheckBox();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonClose = new System.Windows.Forms.Button();
		this.checkBoxPhim3 = new System.Windows.Forms.CheckBox();
		this.checkBoxDatXungQuanh = new System.Windows.Forms.CheckBox();
		this.textBoxKhoangCach = new System.Windows.Forms.TextBox();
		this.comboBoxBoom2 = new System.Windows.Forms.ComboBox();
		this.comboBoxBoom1 = new System.Windows.Forms.ComboBox();
		this.comboBoxBoom3 = new System.Windows.Forms.ComboBox();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.comboBoxTenAc = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.comboBoxSolanNhoiboom = new System.Windows.Forms.ComboBox();
		this.label2 = new System.Windows.Forms.Label();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		this.checkBoxPhim1.AutoSize = true;
		this.checkBoxPhim1.ForeColor = System.Drawing.Color.Black;
		this.checkBoxPhim1.Location = new System.Drawing.Point(14, 18);
		this.checkBoxPhim1.Name = "checkBoxPhim1";
		this.checkBoxPhim1.Size = new System.Drawing.Size(62, 17);
		this.checkBoxPhim1.TabIndex = 0;
		this.checkBoxPhim1.Text = "Boom 1";
		this.checkBoxPhim1.UseVisualStyleBackColor = true;
		this.checkBoxPhim1.CheckedChanged += new System.EventHandler(checkBoxPhim1_CheckedChanged);
		this.checkBoxPhim2.AutoSize = true;
		this.checkBoxPhim2.ForeColor = System.Drawing.Color.Black;
		this.checkBoxPhim2.Location = new System.Drawing.Point(14, 43);
		this.checkBoxPhim2.Name = "checkBoxPhim2";
		this.checkBoxPhim2.Size = new System.Drawing.Size(62, 17);
		this.checkBoxPhim2.TabIndex = 1;
		this.checkBoxPhim2.Text = "Boom 2";
		this.checkBoxPhim2.UseVisualStyleBackColor = true;
		this.checkBoxPhim2.CheckedChanged += new System.EventHandler(checkBoxPhim2_CheckedChanged);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonClose.Location = new System.Drawing.Point(94, 293);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(100, 26);
		this.buttonClose.TabIndex = 8;
		this.buttonClose.Text = "OK";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.checkBoxPhim3.AutoSize = true;
		this.checkBoxPhim3.ForeColor = System.Drawing.Color.Black;
		this.checkBoxPhim3.Location = new System.Drawing.Point(14, 70);
		this.checkBoxPhim3.Name = "checkBoxPhim3";
		this.checkBoxPhim3.Size = new System.Drawing.Size(62, 17);
		this.checkBoxPhim3.TabIndex = 332;
		this.checkBoxPhim3.Text = "Boom 3";
		this.checkBoxPhim3.UseVisualStyleBackColor = true;
		this.checkBoxPhim3.CheckedChanged += new System.EventHandler(checkBoxPhim3_CheckedChanged);
		this.checkBoxDatXungQuanh.AutoSize = true;
		this.checkBoxDatXungQuanh.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxDatXungQuanh.Location = new System.Drawing.Point(17, 263);
		this.checkBoxDatXungQuanh.Name = "checkBoxDatXungQuanh";
		this.checkBoxDatXungQuanh.Size = new System.Drawing.Size(177, 17);
		this.checkBoxDatXungQuanh.TabIndex = 334;
		this.checkBoxDatXungQuanh.Text = "Đặt boom xung quanh ac chính";
		this.checkBoxDatXungQuanh.UseVisualStyleBackColor = true;
		this.checkBoxDatXungQuanh.CheckedChanged += new System.EventHandler(checkBoxDatXungQuanh_CheckedChanged);
		this.textBoxKhoangCach.Location = new System.Drawing.Point(207, 261);
		this.textBoxKhoangCach.Name = "textBoxKhoangCach";
		this.textBoxKhoangCach.Size = new System.Drawing.Size(50, 20);
		this.textBoxKhoangCach.TabIndex = 335;
		this.textBoxKhoangCach.TextChanged += new System.EventHandler(textBoxKhoangCach_TextChanged);
		this.comboBoxBoom2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxBoom2.ForeColor = System.Drawing.Color.Black;
		this.comboBoxBoom2.FormattingEnabled = true;
		this.comboBoxBoom2.Location = new System.Drawing.Point(95, 42);
		this.comboBoxBoom2.Name = "comboBoxBoom2";
		this.comboBoxBoom2.Size = new System.Drawing.Size(140, 21);
		this.comboBoxBoom2.TabIndex = 353;
		this.comboBoxBoom2.SelectedIndexChanged += new System.EventHandler(comboBoxBoom2_SelectedIndexChanged);
		this.comboBoxBoom1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxBoom1.ForeColor = System.Drawing.Color.Black;
		this.comboBoxBoom1.FormattingEnabled = true;
		this.comboBoxBoom1.Location = new System.Drawing.Point(95, 18);
		this.comboBoxBoom1.Name = "comboBoxBoom1";
		this.comboBoxBoom1.Size = new System.Drawing.Size(140, 21);
		this.comboBoxBoom1.TabIndex = 352;
		this.comboBoxBoom1.SelectedIndexChanged += new System.EventHandler(comboBoxBoom1_SelectedIndexChanged);
		this.comboBoxBoom3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxBoom3.ForeColor = System.Drawing.Color.Black;
		this.comboBoxBoom3.FormattingEnabled = true;
		this.comboBoxBoom3.Location = new System.Drawing.Point(95, 66);
		this.comboBoxBoom3.Name = "comboBoxBoom3";
		this.comboBoxBoom3.Size = new System.Drawing.Size(140, 21);
		this.comboBoxBoom3.TabIndex = 354;
		this.comboBoxBoom3.SelectedIndexChanged += new System.EventHandler(comboBoxBoom3_SelectedIndexChanged);
		this.richTextBox1.Location = new System.Drawing.Point(3, 3);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.Size = new System.Drawing.Size(254, 91);
		this.richTextBox1.TabIndex = 355;
		this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
		this.comboBoxTenAc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxTenAc.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTenAc.FormattingEnabled = true;
		this.comboBoxTenAc.Location = new System.Drawing.Point(98, 100);
		this.comboBoxTenAc.Name = "comboBoxTenAc";
		this.comboBoxTenAc.Size = new System.Drawing.Size(159, 21);
		this.comboBoxTenAc.TabIndex = 356;
		this.comboBoxTenAc.SelectedIndexChanged += new System.EventHandler(comboBoxTenAc_SelectedIndexChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(1, 104);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(91, 13);
		this.label1.TabIndex = 357;
		this.label1.Text = "Chọn Đường Môn";
		this.groupBox1.Controls.Add(this.comboBoxBoom3);
		this.groupBox1.Controls.Add(this.comboBoxBoom2);
		this.groupBox1.Controls.Add(this.comboBoxBoom1);
		this.groupBox1.Controls.Add(this.checkBoxPhim3);
		this.groupBox1.Controls.Add(this.checkBoxPhim1);
		this.groupBox1.Controls.Add(this.checkBoxPhim2);
		this.groupBox1.Location = new System.Drawing.Point(3, 128);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(254, 100);
		this.groupBox1.TabIndex = 358;
		this.groupBox1.TabStop = false;
		this.comboBoxSolanNhoiboom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxSolanNhoiboom.ForeColor = System.Drawing.Color.Black;
		this.comboBoxSolanNhoiboom.FormattingEnabled = true;
		this.comboBoxSolanNhoiboom.Location = new System.Drawing.Point(207, 234);
		this.comboBoxSolanNhoiboom.Name = "comboBoxSolanNhoiboom";
		this.comboBoxSolanNhoiboom.Size = new System.Drawing.Size(50, 21);
		this.comboBoxSolanNhoiboom.TabIndex = 355;
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.DarkRed;
		this.label2.Location = new System.Drawing.Point(52, 238);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(133, 13);
		this.label2.TabIndex = 359;
		this.label2.Text = "Số lần nhồi boom tại 1 chỗ";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(264, 328);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.comboBoxSolanNhoiboom);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.comboBoxTenAc);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.textBoxKhoangCach);
		base.Controls.Add(this.checkBoxDatXungQuanh);
		base.Controls.Add(this.buttonClose);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormDuongMon";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "DUONG MON BOOM";
		base.Load += new System.EventHandler(FormDuongMon_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
