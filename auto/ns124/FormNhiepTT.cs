using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns10;
using ns100;
using ns11;
using ns13;
using ns23;
using ns28;
using ns3;
using ns31;
using ns33;
using ns35;
using ns41;
using ns44;
using ns50;
using ns53;
using ns61;
using ns63;
using ns71;
using ns81;
using ns83;
using ns84;
using ns85;
using ns88;
using ns91;

namespace ns124;

public class FormNhiepTT : Form
{
	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonThoat;

	private Label label1;

	private ComboBox comboBox1;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ComboBox comboBox2;

	private RichTextBox richTextBox1;

	private CheckBox checkBoxTuchuyenThanh;

	private CheckBox checkBoxTDP;

	private CheckBox checkBoxLongHH;

	private Button button1;

	private Label label2;

	private NumericUpDown numericUpDown1;

	private Label label3;

	private ComboBox comboBoxAn;

	private Label label4;

	private TextBox textBoxSL;

	private Label label5;

	public static int int_0 = 0;

	public static string[,] string_0 = new string[7, 2]
	{
		{ "Lâm An", "176" },
		{ "Biện Kinh", "37" },
		{ "Dương Châu", "80" },
		{ "Phượng Tường", "01" },
		{ "Đại Lý", "162" },
		{ "Thành Đô", "11" },
		{ "Tương Dương", "78" }
	};

	public static bool bool_0 = false;

	public static string string_1 = Class66.smethod_7("NTT_Khunggio", 0);

	public static string string_2 = Class11.smethod_72(Class66.smethod_7("NTT_TenVatphamAn", 0));

	public static int int_1 = Class66.smethod_4("NTT_SLVatphamAn", 0, "2");

	public static int int_2 = Class66.smethod_4("NTT_TimeDelta", 0, "0");

	public static int int_3 = Class66.smethod_4("NTT_MapId", 0, "1");

	public static int int_4 = Class66.smethod_4("NTT_ChuyenThanh", 0, "1");

	public static int int_5 = Class66.smethod_4("NTT_Thodiaphu", 0, "0");

	public static int int_6 = Class66.smethod_4("NTT_LongHH", 0, "1");

	public static int int_7 = Class66.smethod_4("NTT_KieuPT", 0, "0");

	public int int_8;

	public int int_9;

	public int int_10;

	public int int_11;

	private string[] string_3 = new string[2] { "1. Chỉ cần 4ac trở đi thì click vượt ải", "2. Chờ đủ người chung tổ đội có trong danh sách PT (ở bảng 1)" };

	private static string string_4 = "bVJPSyMxFL/3U7yjBVvUo4cFz8IiOHhP0zIZ7Mx0pxnBo4h4EvToYbHdUkRWoa7CQsKyh3T7PfJN9vcy49CCl8kkee/37+VQlVlMceLt9306kDT25g9pb1+p56Y59UWmSBc5as7cL3x3d2iknNHbNBZlsyOt3DPazDSlLF4tUNi0d1utE/dCfW/n1ENFRlJ5e5Nxc80bukVNvsbr7U9UKep84QX1W2g185TBnnQbkiaUefO3rIF1McgZ51spIMNNzkm59zQoDRTy3xOULe+cCU5Uw6kToIyYcC43lC9vofCipFMs19k+tTp0BAmzhKR7o2M31RTBzSM7MbOMtlTuzW/5yc3Q2yvCwf2IOiRKna9FnXr70IYuby8Jv6zwR9moXS28ncnt2infVwMpVovVFGuV3ibiEDGdUyFgoUMRNpokZLDh5V1CJwFTU3DCvLA4qn2pgTzlZHOWhTgixpPDBKdfVZVTpDBQXXjzCMcsqCegY6/dpYNNGQx9jyuYfxXVLkEjsz+EJzX5QI6i2v96+k3YGO+LrjwG3KOo5uVoMcoqvAt+jPxI+8l4TLFIB+uJ5HEYN94C4n2rwIBTjb77Hw==";

	private string[] string_5 = null;

	public FormNhiepTT()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns124.FormNhiepTT));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonThoat = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.comboBox1 = new System.Windows.Forms.ComboBox();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.comboBox2 = new System.Windows.Forms.ComboBox();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.checkBoxTuchuyenThanh = new System.Windows.Forms.CheckBox();
		this.checkBoxTDP = new System.Windows.Forms.CheckBox();
		this.checkBoxLongHH = new System.Windows.Forms.CheckBox();
		this.button1 = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
		this.label3 = new System.Windows.Forms.Label();
		this.comboBoxAn = new System.Windows.Forms.ComboBox();
		this.label4 = new System.Windows.Forms.Label();
		this.textBoxSL = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonThoat.Location = new System.Drawing.Point(267, 411);
		this.buttonThoat.Name = "buttonThoat";
		this.buttonThoat.Size = new System.Drawing.Size(70, 27);
		this.buttonThoat.TabIndex = 6;
		this.buttonThoat.Text = "Đóng";
		this.buttonThoat.UseVisualStyleBackColor = true;
		this.buttonThoat.Click += new System.EventHandler(buttonThoat_Click);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(3, 10);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(133, 13);
		this.label1.TabIndex = 7;
		this.label1.Text = "Báo danh Vượt ải tại thành";
		this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Location = new System.Drawing.Point(192, 6);
		this.comboBox1.Name = "comboBox1";
		this.comboBox1.Size = new System.Drawing.Size(151, 21);
		this.comboBox1.TabIndex = 8;
		this.comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
		this.listView1.CheckBoxes = true;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_0 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(4, 58);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(90, 288);
		this.listView1.TabIndex = 9;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(listView1_ItemCheck);
		this.columnHeader_0.Text = "Khung giờ";
		this.columnHeader_0.Width = 70;
		this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox2.FormattingEnabled = true;
		this.comboBox2.Location = new System.Drawing.Point(97, 33);
		this.comboBox2.Name = "comboBox2";
		this.comboBox2.Size = new System.Drawing.Size(246, 21);
		this.comboBox2.TabIndex = 11;
		this.comboBox2.SelectedIndexChanged += new System.EventHandler(comboBox2_SelectedIndexChanged);
		this.richTextBox1.Location = new System.Drawing.Point(97, 58);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.Size = new System.Drawing.Size(246, 267);
		this.richTextBox1.TabIndex = 12;
		this.richTextBox1.Text = "";
		this.checkBoxTuchuyenThanh.AutoSize = true;
		this.checkBoxTuchuyenThanh.Location = new System.Drawing.Point(102, 330);
		this.checkBoxTuchuyenThanh.Name = "checkBoxTuchuyenThanh";
		this.checkBoxTuchuyenThanh.Size = new System.Drawing.Size(197, 17);
		this.checkBoxTuchuyenThanh.TabIndex = 13;
		this.checkBoxTuchuyenThanh.Text = "Tự chuyển qua thành khác nếu đầy";
		this.checkBoxTuchuyenThanh.UseVisualStyleBackColor = true;
		this.checkBoxTuchuyenThanh.CheckedChanged += new System.EventHandler(checkBoxTuchuyenThanh_CheckedChanged);
		this.checkBoxTDP.AutoSize = true;
		this.checkBoxTDP.Location = new System.Drawing.Point(102, 353);
		this.checkBoxTDP.Name = "checkBoxTDP";
		this.checkBoxTDP.Size = new System.Drawing.Size(211, 17);
		this.checkBoxTDP.TabIndex = 14;
		this.checkBoxTDP.Text = "Tự thổ địa phù về nếu đang chiến đấu";
		this.checkBoxTDP.UseVisualStyleBackColor = true;
		this.checkBoxTDP.CheckedChanged += new System.EventHandler(checkBoxTDP_CheckedChanged);
		this.checkBoxLongHH.AutoSize = true;
		this.checkBoxLongHH.Location = new System.Drawing.Point(102, 378);
		this.checkBoxLongHH.Name = "checkBoxLongHH";
		this.checkBoxLongHH.Size = new System.Drawing.Size(54, 17);
		this.checkBoxLongHH.TabIndex = 15;
		this.checkBoxLongHH.Text = "Tự ăn";
		this.checkBoxLongHH.UseVisualStyleBackColor = true;
		this.checkBoxLongHH.CheckedChanged += new System.EventHandler(checkBoxLongHH_CheckedChanged);
		this.button1.Location = new System.Drawing.Point(4, 31);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(90, 23);
		this.button1.TabIndex = 16;
		this.button1.Text = "Xóa khung giờ";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.label2.Location = new System.Drawing.Point(3, 354);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(92, 40);
		this.label2.TabIndex = 17;
		this.label2.Text = "Báo danh sớm (-) hoặc trễ (+) hơn";
		this.numericUpDown1.Location = new System.Drawing.Point(6, 399);
		this.numericUpDown1.Maximum = new decimal(new int[4] { 59, 0, 0, 0 });
		this.numericUpDown1.Minimum = new decimal(new int[4] { 59, 0, 0, -2147483648 });
		this.numericUpDown1.Name = "numericUpDown1";
		this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
		this.numericUpDown1.TabIndex = 18;
		this.numericUpDown1.ValueChanged += new System.EventHandler(numericUpDown1_ValueChanged);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(59, 403);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(28, 13);
		this.label3.TabIndex = 19;
		this.label3.Text = "phút";
		this.comboBoxAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxAn.FormattingEnabled = true;
		this.comboBoxAn.Location = new System.Drawing.Point(162, 376);
		this.comboBoxAn.Name = "comboBoxAn";
		this.comboBoxAn.Size = new System.Drawing.Size(124, 21);
		this.comboBoxAn.TabIndex = 20;
		this.comboBoxAn.SelectedIndexChanged += new System.EventHandler(comboBoxAn_SelectedIndexChanged);
		this.comboBoxAn.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxAn_MouseDown);
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.Location = new System.Drawing.Point(150, 403);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(113, 13);
		this.label4.TabIndex = 21;
		this.label4.Text = "{ Long huyết hoàn ... }";
		this.textBoxSL.Location = new System.Drawing.Point(288, 376);
		this.textBoxSL.Name = "textBoxSL";
		this.textBoxSL.Size = new System.Drawing.Size(25, 20);
		this.textBoxSL.TabIndex = 22;
		this.textBoxSL.Text = "2";
		this.textBoxSL.TextChanged += new System.EventHandler(textBoxSL_TextChanged);
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(318, 379);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(21, 13);
		this.label5.TabIndex = 23;
		this.label5.Text = "cái";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(344, 442);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.textBoxSL);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.comboBoxAn);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.numericUpDown1);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.checkBoxLongHH);
		base.Controls.Add(this.checkBoxTDP);
		base.Controls.Add(this.buttonThoat);
		base.Controls.Add(this.checkBoxTuchuyenThanh);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.comboBox2);
		base.Controls.Add(this.listView1);
		base.Controls.Add(this.comboBox1);
		base.Controls.Add(this.label1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormNhiepTT";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "Vuot ai";
		base.Load += new System.EventHandler(FormNhiepTT_Load);
		((System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public static void smethod_0()
	{
		int int_ = int_0;
		int_0 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25 || Form1.characterAccountConfig_1[num].int_123 <= 0)
				{
					if (0 <= num)
					{
						Form1.characterAccountConfig_1[num].bool_36 = false;
						Class75.smethod_57(Form1.characterAccountConfig_1[num], "Chat('CH_NEARBY', '(hod)<color=green>" + Form1.string_49 + "<color=white> ChÕ ®é b\u00b8o danh v\u00adît ¶i kÕt thóc !')");
						int int_2 = 0;
						byte[] array = new byte[1];
						byte[] byte_ = array;
						Class24.WriteProcessMemory(Form1.characterAccountConfig_1[num].int_137, Form1.characterAccountConfig_1[num].uint_16 + Class75.uint_42 * 4, byte_, 1, ref int_2);
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_36)
					{
						break;
					}
					flag = true;
					Form1.characterAccountConfig_1[num].bool_36 = true;
					Class75.smethod_57(Form1.characterAccountConfig_1[num], "Chat('CH_NEARBY', '(lvd)<color=green>" + Form1.string_49 + "<color=white> ChÕ ®é chê ®îi b\u00b8o danh v\u00adît ¶i b¾t ®Çu s½n sµng!')");
				}
				smethod_3(int_);
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}
	}

	private static string smethod_1(int int_12)
	{
		string result = "t©m";
		switch (int_12)
		{
		case 176:
			result = "b¾c";
			break;
		case 11:
			result = "®«ng|§«ng";
			break;
		}
		return result;
	}

	private static int smethod_2(CharacterAccountConfig characterAccountConfig_0, uint[] uint_0)
	{
		uint num = 3u;
		if (uint_0 != null && uint_0[4] != num)
		{
			uint uint_1 = 1u;
			uint uint_2 = 2u;
			Class85.smethod_24(characterAccountConfig_0, 3u);
			while (true)
			{
				uint[] array = Class85.smethod_26(characterAccountConfig_0, num, uint_1, uint_2);
				if (array == null)
				{
					int num2 = Class32.smethod_12(characterAccountConfig_0, 1);
					int num3 = Class32.smethod_12(characterAccountConfig_0, 0);
					if (num2 <= 0 && num3 <= 0)
					{
						break;
					}
					Thread.Sleep(10);
					continue;
				}
				int int_ = 0;
				int i = 0;
				byte[] array2 = new byte[4];
				for (; i < 20; i++)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 1, ref int_);
					int num4 = array2[0];
					if (num4 > 0)
					{
						break;
					}
					if (i % 4 == 0)
					{
						Class75.smethod_46(characterAccountConfig_0, uint_0[2], uint_0[3], uint_0[4], uint_0[2], uint_0[3], uint_0[4]);
					}
					if (i > 20)
					{
						break;
					}
					Thread.Sleep(300);
				}
				i = 0;
				while (i < 20)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 1, ref int_);
					if (array2[0] != 0)
					{
						if (i % 4 == 0)
						{
							Class75.smethod_46(characterAccountConfig_0, array[0], array[1], num, array[0], array[1], num);
						}
						i++;
						Thread.Sleep(300);
						continue;
					}
					return 1;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 1, ref int_);
				if (array2[0] > 0)
				{
					Class75.smethod_46(characterAccountConfig_0, uint_0[2], uint_0[3], uint_0[4], uint_0[2], uint_0[3], uint_0[4]);
					Thread.Sleep(300);
				}
				return 0;
			}
			return -1;
		}
		return 1;
	}

	public static void smethod_3(int int_12)
	{
		int int_13 = 0;
		byte[] array = new byte[4];
		int[] array2 = new int[10];
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = 4;
		}
		long long_ = 0L;
		long long_2 = 0L;
		long long_3 = 0L;
		long ticks = new TimeSpan(0, 0, 10, 0, 0).Ticks;
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		int num12 = 100;
		int num13 = 0;
		uint[,] array3 = new uint[7, 3];
		Class10.smethod_4(array3, 20727);
		uint[,] array4 = array3;
		int num14 = 0;
		int num15 = 0;
		string text = null;
		while (true)
		{
			Thread.Sleep(1000);
			int num16 = Class87.smethod_3(Form1.characterAccountConfig_1, int_12);
			if (Class11.bool_0 || num16 < 0 || !Form1.characterAccountConfig_1[num16].bool_25 || Form1.characterAccountConfig_1[num16].int_123 <= 0)
			{
				break;
			}
			CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[num16];
			Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_27.uint_0, array, 4, ref int_13);
			int num17 = BitConverter.ToInt32(array, 0);
			if ((463 >= num17 || num17 >= 472) && (479 >= num17 || num17 >= 496))
			{
				if (string_1 == null || string_1 == string.Empty)
				{
					if (Class11.smethod_28(long_) > 15000L)
					{
						Class75.smethod_52(characterAccountConfig, "- Lçi b\u00b8o danh V\u00adît ¶i: b¹n ch\u00ada chän khung giê...");
						long_ = Class11.smethod_27();
					}
					continue;
				}
				int num18 = Class89.smethod_12(characterAccountConfig);
				if (num18 > 0)
				{
					continue;
				}
				DateTime now = DateTime.Now;
				long ticks2 = new TimeSpan(0, now.Hour, now.Minute, now.Second, now.Millisecond).Ticks;
				string[] array5 = string_1.Split(',', ';', '-');
				int num19 = 0;
				while (num19 < array5.Length)
				{
					long ticks3 = new TimeSpan(0, Class11.smethod_11(array5[num19]), int_2, 0, 0).Ticks;
					long num20 = ticks2 - ticks3;
					if (0L > num20 || num20 > ticks)
					{
						num19++;
						continue;
					}
					goto IL_0289;
				}
			}
			array[0] = 0;
			Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_42 * 4, array, 1, ref int_13);
			if (num15 > 0)
			{
				Thread.Sleep(1000);
				Class95.smethod_8(characterAccountConfig);
			}
			num = -1;
			num2 = -1;
			num6 = 0;
			num7 = 0;
			num8 = 0;
			num15 = 0;
			text = null;
			num13 = 0;
			num5 = 0;
			num4 = 0;
			Thread.Sleep(300);
			continue;
			IL_0289:
			if (num4 == 0)
			{
				Class75.smethod_57(characterAccountConfig, "Chat('CH_NEARBY', '(lvd)<color=green>" + Form1.string_49 + "<color=white> TU DONG BAO DANH VUOT AI')");
				num4 = 1;
			}
			if (num < 0 || num3 != int_3)
			{
				num = int_3;
				num3 = int_3;
			}
			if (num2 == num17)
			{
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref array2[0]);
				uint num21 = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num21 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref array2[1]);
				uint num22 = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref array2[2]);
				uint num23 = BitConverter.ToUInt32(array, 0);
				uint num24 = num23 + num22 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num24 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref array2[3]);
				int num25 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num24 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref array2[4]);
				int num26 = BitConverter.ToInt32(array, 0);
				int num27 = Class89.smethod_39(characterAccountConfig);
				if (num26 == 0 || num25 == 0 || num25 == 10 || num25 == 21 || num27 <= 1)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num24 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref array2[5]);
				int num28 = BitConverter.ToInt32(array, 0);
				int num29 = 0;
				while (true)
				{
					if (num29 <= 5)
					{
						if (array2[num29] == 0)
						{
							break;
						}
						num29++;
						continue;
					}
					uint[] array7;
					uint[] uint_;
					if (num28 <= 0)
					{
						array[0] = 1;
						Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_42 * 4, array, 1, ref int_13);
						if (num17 != num)
						{
							if (num9 < 5 && Class75.smethod_3(characterAccountConfig, Class75.uint_19, 4) > 0)
							{
								Class29.smethod_7(characterAccountConfig, num, smethod_1(num));
								num9++;
							}
							else
							{
								Class53.smethod_5(characterAccountConfig, num);
							}
							Thread.Sleep(1000);
							break;
						}
						if (num7 > 0)
						{
							if (int_6 > 0)
							{
								if (int_1 < 0)
								{
									int_1 = 1;
								}
								if (string_2 == null || string_2 == string.Empty)
								{
									string_2 = "Long HuyÕt Hoµn";
								}
								if (num8 < int_1)
								{
									Class75.smethod_44(characterAccountConfig, string_2, bool_0: true);
									Thread.Sleep(300);
									Class95.smethod_8(characterAccountConfig);
									num8++;
								}
							}
							if (num6 >= 3)
							{
								uint[] array6 = new uint[2];
								for (num29 = 0; num29 < array4.GetLength(0); num29++)
								{
									if (num == array4[num29, 0])
									{
										array6[0] = array4[num29, 1];
										array6[1] = array4[num29, 2];
									}
								}
								array7 = new uint[2];
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num24 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_13);
								array7[0] = BitConverter.ToUInt32(array, 0);
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num24 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_13);
								array7[1] = BitConverter.ToUInt32(array, 0);
								long num30 = Class64.smethod_18(array7, array6);
								if (num30 < 300000L)
								{
									num11 = 0;
									num12++;
									if (num12 > 100)
									{
										num12 = 0;
										Class75.smethod_61(characterAccountConfig, new uint[2]
										{
											array6[0] + 120,
											array6[1] + 120
										});
										Thread.Sleep(300);
									}
									else if (num30 > 11250L)
									{
										Class75.smethod_61(characterAccountConfig, array6);
										Thread.Sleep(300);
									}
									GStruct61 gStruct = Class88.smethod_5(characterAccountConfig);
									if (!(gStruct.string_0 != characterAccountConfig.string_22))
									{
										if (gStruct.int_0 <= 3)
										{
											if (Class11.smethod_28(long_) > 30000L)
											{
												Class75.smethod_52(characterAccountConfig, "- Tæ ®éi ®ang cã " + gStruct.int_0 + " thµnh viªn, ®ang chê ®ñ...");
												long_ = Class11.smethod_27();
											}
											break;
										}
										if (int_7 > 0 && characterAccountConfig.string_19 != null)
										{
											num14 = 0;
											if (gStruct.int_0 > 0)
											{
												for (num29 = 0; num29 < gStruct.gstruct60_0.GetLength(0); num29++)
												{
													string text2 = gStruct.gstruct60_0[num29].string_0;
													if (text2 == null || text2 == string.Empty)
													{
														continue;
													}
													for (int j = 0; j < characterAccountConfig.string_19.Length; j++)
													{
														if (text2 == characterAccountConfig.string_19[j])
														{
															num14++;
															break;
														}
													}
												}
											}
											if (num14 <= 7 && num14 != characterAccountConfig.string_19.Length)
											{
												break;
											}
										}
										uint_ = null;
										if (num15 > 0)
										{
											string text3 = Class3.smethod_16(characterAccountConfig, num15, ref uint_, 40);
											if (text3 == text)
											{
												goto IL_09c6;
											}
										}
										num15 = Class3.smethod_15(characterAccountConfig, "NhiÕp |Ý TrÇn", ref uint_, 3, bool_0: false);
										if (num15 <= 0)
										{
											if (Class11.smethod_28(long_) > 30000L)
											{
												Class75.smethod_52(characterAccountConfig, "- Kh«ng t×m thÊy NPC NhiÕp ThÝ TrÇn...");
												long_ = Class11.smethod_27();
											}
											break;
										}
										text = Class3.smethod_16(characterAccountConfig, num15, ref uint_, 40);
										goto IL_09c6;
									}
									string text4 = Class89.smethod_22(characterAccountConfig);
									if (text4 != null && text4.Length > 6)
									{
										int num31 = text4.IndexOf(":");
										if (0 <= num31 && text4.Length > num31)
										{
											text4 = text4.Substring(num31 + 1).Trim();
										}
										string text5 = Class11.smethod_72(text4);
										num31 = text5.IndexOf("m=");
										if (0 <= num31)
										{
											int num32 = Class11.smethod_11(text5.Substring(num31 + 2));
											if (num32 > 0 && int_3 != num32)
											{
												for (num29 = 0; num29 < array4.GetLength(0); num29++)
												{
													if (num32 != array4[num29, 0])
													{
														continue;
													}
													int_3 = num32;
													for (int k = 0; k < string_0.GetLength(0); k++)
													{
														if (string_0[k, 1] == num32.ToString())
														{
															if (Class11.smethod_28(long_) > 30000L)
															{
																Class75.smethod_57(characterAccountConfig, "Chat('CH_NEARBY', '" + Class1.smethod_2("<color=pink>Đã đầy, chuyển sang " + string_0[k, 0]) + "')");
																long_ = Class11.smethod_27();
															}
															break;
														}
													}
													break;
												}
											}
										}
									}
									if (Class11.smethod_28(long_) > 30000L)
									{
										Class89.smethod_32(characterAccountConfig, 1u);
										Thread.Sleep(300);
										Class75.smethod_57(characterAccountConfig, "Chat('CH_NEARBY', '(lvd)<color=green>" + Form1.string_49 + "<color=white> §ang chê ®éi truëng b\u00b8o danh...')");
										long_ = Class11.smethod_27();
									}
									break;
								}
								Class64.smethod_29(characterAccountConfig, bool_0: false);
								if (num11 < 5)
								{
									uint[,] array8 = Class44.smethod_1(num17, array7, array6);
									if (array8 != null)
									{
										num11++;
										if (0 <= Class64.smethod_22(characterAccountConfig, array8, array7, array6, num17, bool_0: false, 16000))
										{
											num11 = 0;
										}
										break;
									}
								}
								if (!Class13.smethod_3(characterAccountConfig) || Class11.smethod_28(long_2) > 6000L)
								{
									Class13.smethod_1(characterAccountConfig, array6);
									long_2 = Class11.smethod_27();
								}
								break;
							}
							num6++;
							if (0 <= Class36.smethod_3(characterAccountConfig))
							{
								num6 = 3;
							}
							Thread.Sleep(300);
							break;
						}
						if (Class11.smethod_28(long_3) < 10000L)
						{
							if (Class11.smethod_28(long_) > 30000L)
							{
								Class75.smethod_52(characterAccountConfig, "- Kh«ng t×m thÊy S\u00b8t Thñ gi¶n...");
								long_ = Class11.smethod_27();
							}
							break;
						}
						int[] array9 = new int[5] { 3, 23, 4, 9, 10 };
						string text6 = "S\u00b8t thñ gi¶n";
						uint[] array10 = null;
						for (num29 = 0; num29 < array9.Length; num29++)
						{
							array10 = Class85.smethod_29(characterAccountConfig, text6, array9[num29], bool_3: true);
							if (array10 != null)
							{
								break;
							}
						}
						if (array10 != null)
						{
							if (array10[4] == 3)
							{
								num7 = 1;
								break;
							}
							if (array10[4] == 23)
							{
								smethod_2(characterAccountConfig, array10);
								Thread.Sleep(300);
								break;
							}
						}
						uint[] array11 = null;
						string text7 = "S\u00b8t Thñ Gi¶n lÔ hép";
						for (num29 = 0; num29 < array9.Length; num29++)
						{
							array11 = Class85.smethod_29(characterAccountConfig, text7, array9[num29], bool_3: true);
							if (array11 != null)
							{
								break;
							}
						}
						if (array11 != null)
						{
							if (array11[4] == 3)
							{
								Class75.smethod_43(characterAccountConfig, array11[0], (int)array11[2], (int)array11[3]);
								Thread.Sleep(300);
								Class95.smethod_6(characterAccountConfig, "m|t|h");
								Thread.Sleep(300);
								break;
							}
							if (array11[4] == 23)
							{
								smethod_2(characterAccountConfig, array11);
								Thread.Sleep(300);
								break;
							}
						}
						bool flag = array10 != null && (array10[4] == 4 || array10[4] == 9 || array10[4] == 10);
						bool flag2 = array11 != null && (array11[4] == 4 || array11[4] == 9 || array11[4] == 10);
						if (!flag && !flag2)
						{
							long_3 = Class11.smethod_27();
							break;
						}
						if (!Class47.smethod_8(characterAccountConfig))
						{
							Class98.smethod_0(characterAccountConfig);
							break;
						}
						if (!flag)
						{
							if (flag2)
							{
								smethod_2(characterAccountConfig, array11);
							}
						}
						else
						{
							smethod_2(characterAccountConfig, array10);
						}
						Class47.smethod_11(characterAccountConfig);
						break;
					}
					if (int_5 <= 0)
					{
						if (Class11.smethod_28(long_) > 30000L)
						{
							Class75.smethod_52(characterAccountConfig, "- Kh«ng thÓ b\u00b8o danh v\u00adît ¶i do ®ang ë n¬i chiÕn ®Êu, vµo b¶ng 2 auto ®Ó thiÕt lËp l¹i nÕu muèn...");
							long_ = Class11.smethod_27();
						}
						array[0] = 0;
						Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_42 * 4, array, 1, ref int_13);
						break;
					}
					if (num9 < 5)
					{
						if (Class75.smethod_3(characterAccountConfig, Class75.uint_19, 4) <= 0)
						{
							num9 = 5;
						}
						else
						{
							Class29.smethod_7(characterAccountConfig, num, smethod_1(num));
						}
						num9++;
						num10 = 0;
					}
					else if (num10 < 5)
					{
						Class64.smethod_14(characterAccountConfig);
						num10++;
						num9 = 0;
					}
					Thread.Sleep(300);
					break;
					IL_09c6:
					while (true)
					{
						num14 = 0;
						while (!Class11.bool_0 && num14 < 10)
						{
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num24 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_13);
							array7[0] = BitConverter.ToUInt32(array, 0);
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num24 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_13);
							array7[1] = BitConverter.ToUInt32(array, 0);
							if (Class64.smethod_18(array7, uint_) < 22500L)
							{
								break;
							}
							Class75.smethod_61(characterAccountConfig, uint_);
							Thread.Sleep(300);
							num14++;
						}
						Class95.smethod_8(characterAccountConfig);
						Class95.Class91.smethod_2(characterAccountConfig);
						Class38.smethod_10(characterAccountConfig, (uint)num15);
						Thread.Sleep(300);
						num14 = 0;
						while (Class95.smethod_0(characterAccountConfig) < 0)
						{
							num14++;
							Thread.Sleep(100);
							if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) != 0)
							{
								string text8 = Class47.smethod_4(characterAccountConfig);
								if (text8.IndexOf("è l\u00adîn") > 0)
								{
									Class47.smethod_3(characterAccountConfig, "1");
								}
								else
								{
									Class47.smethod_3(characterAccountConfig);
								}
							}
							if (Class95.Class92.smethod_4(characterAccountConfig))
							{
								Class95.Class92.smethod_5(characterAccountConfig);
							}
							if (num14 <= 10)
							{
								continue;
							}
							goto IL_09b6;
						}
						num13 = 0;
						if (num5 <= 0)
						{
							uint num33 = num21 + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_75.uint_0;
							Class24.ReadProcessMemory(characterAccountConfig.int_137, num33 + Class56.memorySignatureScanConfig_73.uint_0, array, 4, ref int_13);
							int num34 = BitConverter.ToInt32(array, 0);
							int num35 = 100000;
							if (num34 < 100000)
							{
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num33 + Class56.memorySignatureScanConfig_74.uint_0, array, 4, ref int_13);
								int num36 = BitConverter.ToInt32(array, 0);
								int num37 = num35 - num34;
								if (num37 <= num36)
								{
									if (characterAccountConfig.string_15 != null && characterAccountConfig.string_15 != string.Empty)
									{
										uint num38 = Class11.smethod_12(characterAccountConfig.string_15);
										if (num38 != 0)
										{
											Class75.smethod_117(characterAccountConfig, num38);
											Thread.Sleep(300);
										}
									}
									Class75.smethod_37(characterAccountConfig, (uint)num37);
									Thread.Sleep(300);
								}
							}
							num5 = 1;
						}
						string text9 = "luyÖn s\u00b8t thñ|khiªu chiÕn|dÉn d¾t ®éi";
						Class95.smethod_6(characterAccountConfig, text9);
						string string_ = Class95.Class91.smethod_1(characterAccountConfig);
						Class95.smethod_8(characterAccountConfig);
						if (int_4 == 0 || Class11.smethod_1(string_, "h«ng cßn chç") < 0)
						{
							break;
						}
						int num39 = -1;
						for (num29 = 0; num29 < array4.GetLength(0); num29++)
						{
							if (int_3 == array4[num29, 0])
							{
								num29 = ((array4.GetLength(0) - 1 > num29) ? (num29 + 1) : 0);
								num39 = (int)array4[num29, 0];
								break;
							}
						}
						if (num39 <= 0 || int_3 == num39)
						{
							break;
						}
						GStruct61 gStruct2 = Class88.smethod_5(characterAccountConfig);
						if (gStruct2.int_0 > 0)
						{
							string text10 = Class11.smethod_71("m=" + num39);
							for (int l = 0; l < 3; l++)
							{
								for (num29 = 0; num29 < gStruct2.gstruct60_0.GetLength(0); num29++)
								{
									if (characterAccountConfig.string_22 != gStruct2.gstruct60_0[num29].string_0 && gStruct2.gstruct60_0[num29].string_0 != null && gStruct2.gstruct60_0[num29].string_0 != string.Empty)
									{
										Class75.smethod_50(characterAccountConfig, gStruct2.gstruct60_0[num29].string_0, text10);
										Thread.Sleep(100);
									}
								}
								Thread.Sleep(600);
							}
						}
						for (num29 = 0; num29 < string_0.GetLength(0); num29++)
						{
							if (string_0[num29, 1] == num39.ToString())
							{
								Class75.smethod_52(characterAccountConfig, Class1.smethod_2("Đã đầy, chuyển sang " + string_0[num29, 0]));
								break;
							}
						}
						int_3 = num39;
						break;
						IL_09b6:
						num13++;
						if (num13 > 3)
						{
							Class64.smethod_12(characterAccountConfig);
							num13 = 0;
							break;
						}
					}
					break;
				}
			}
			else
			{
				num2 = num17;
				num9 = 0;
				num10 = 0;
				num5 = 0;
				num6 = 0;
				num7 = 0;
				num8 = 0;
			}
		}
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		int_8 = 0;
		int_9 = 0;
		int_0 = 0;
		bool_0 = false;
	}

	private void FormNhiepTT_Load(object sender, EventArgs e)
	{
		Thread.Sleep(100);
		if (int_8 > 0 && int_9 > 0)
		{
			int num = int_8 - base.Width - 10;
			int num2 = int_9 - base.Height - 10;
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
		for (int i = 0; i < string_0.GetLength(0); i++)
		{
			comboBox1.Items.Add(string_0[i, 0]);
			if (int_3 == Class11.smethod_11(string_0[i, 1]))
			{
				comboBox1.Text = string_0[i, 0];
			}
		}
		for (int j = 0; j < string_3.GetLength(0); j++)
		{
			comboBox2.Items.Add(string_3[j]);
			if (j == int_7)
			{
				comboBox2.Text = string_3[j];
			}
		}
		for (int k = 0; k < 24; k++)
		{
			method_0(listView1, k + " giờ");
		}
		if (string_1 != null && string_1 != string.Empty)
		{
			string[] array = string_1.Split(',', ';', '-');
			for (int l = 0; l < array.Length; l++)
			{
				listView1.Items[Class11.smethod_11(array[l])].Checked = true;
			}
		}
		checkBoxTuchuyenThanh.Checked = int_4 > 0;
		checkBoxTDP.Checked = int_5 > 0;
		checkBoxLongHH.Checked = int_6 > 0;
		richTextBox1.Text = Class11.smethod_72(string_4);
		numericUpDown1.Value = int_2;
		string_5 = null;
		if (string_2 != null && string_2 != string.Empty)
		{
			string_5 = new string[1] { string_2 };
			string item = Class1.smethod_1(string_2, 1);
			comboBoxAn.Items.Add(item);
			comboBoxAn.Text = item;
		}
		textBoxSL.Text = int_1.ToString();
		Thread.Sleep(100);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void method_0(ListView listView_0, string string_6)
	{
		try
		{
			ListViewItem value = new ListViewItem(string_6);
			listView_0.Items.Add(value);
		}
		catch
		{
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void buttonThoat_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int index = e.Index;
		int num = Convert.ToByte(e.NewValue);
		if (num > 0)
		{
			if (string_1 == null || string_1 == string.Empty)
			{
				string_1 = index.ToString();
				return;
			}
			string[] array = string_1.Split(',', ';', '-');
			for (int i = 0; i < array.Length; i++)
			{
				if (index == Class11.smethod_11(array[i]))
				{
					return;
				}
			}
			string_1 = string_1 + "," + index;
		}
		else
		{
			if (string_1 == null || string_1 == string.Empty)
			{
				return;
			}
			string[] array2 = string_1.Split(',', ';', '-');
			string_1 = null;
			for (int j = 0; j < array2.Length; j++)
			{
				if (index != Class11.smethod_11(array2[j]))
				{
					if (string_1 != null && string_1 != string.Empty)
					{
						string_1 += ",";
					}
					string_1 += array2[j];
				}
			}
		}
		Class66.smethod_11(Class66.smethod_1(), "NTT_Khunggio", string_1, "", 0);
	}

	private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		string text = comboBox2.Text;
		int num = 0;
		while (true)
		{
			if (num < string_3.Length)
			{
				if (text == string_3[num])
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		int_7 = num;
		Class66.smethod_11(Class66.smethod_1(), "NTT_KieuPT", int_7, "", 0);
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		string text = comboBox1.Text;
		for (int i = 0; i < string_0.GetLength(0); i++)
		{
			if (text == string_0[i, 0])
			{
				int_3 = Class11.smethod_11(string_0[i, 1]);
				Class66.smethod_11(Class66.smethod_1(), "NTT_MapId", int_3, "", 0);
				break;
			}
		}
	}

	private void checkBoxTuchuyenThanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_4 = Convert.ToByte(checkBoxTuchuyenThanh.Checked);
			Class66.smethod_11(Class66.smethod_1(), "NTT_ChuyenThanh", int_4, "", 0);
		}
	}

	private void checkBoxTDP_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_5 = Convert.ToByte(checkBoxTDP.Checked);
			Class66.smethod_11(Class66.smethod_1(), "NTT_Thodiaphu", int_5, "", 0);
		}
	}

	private void checkBoxLongHH_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_6 = Convert.ToByte(checkBoxLongHH.Checked);
			Class66.smethod_11(Class66.smethod_1(), "NTT_LongHH", int_6, "", 0);
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			listView1.Items[i].Checked = i == 0;
		}
		listView1.TopItem = listView1.Items[0];
		listView1.Items[0].Selected = true;
		string_1 = "0";
		Class66.smethod_11(Class66.smethod_1(), "NTT_Khunggio", string_1, "", 0);
	}

	private void comboBoxAn_MouseDown(object sender, MouseEventArgs e)
	{
		string_5 = null;
		comboBoxAn.Items.Clear();
		timer_0.Enabled = false;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Class85.smethod_38(Form1.characterAccountConfig_1[i], ref string_5, 0);
			}
		}
		if (string_2 != null && string_2 != string.Empty)
		{
			if (string_5 == null)
			{
				string_5 = new string[1];
			}
			else
			{
				Array.Resize(ref string_5, string_5.Length + 1);
			}
			string_5[string_5.Length - 1] = string_2;
		}
		comboBoxAn.Items.Add("");
		if (string_5 != null)
		{
			Array.Sort(string_5);
			for (int j = 0; j < string_5.Length; j++)
			{
				comboBoxAn.Items.Add(Class1.smethod_1(string_5[j], 1));
			}
			if (string_2 != null && string_2 != string.Empty)
			{
				comboBoxAn.Text = Class1.smethod_1(string_2, 1);
			}
		}
		timer_0.Enabled = true;
	}

	private void comboBoxAn_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		string text = string.Empty;
		string text2 = comboBoxAn.Text;
		if (string_5 != null)
		{
			for (int i = 0; i < string_5.Length; i++)
			{
				if (text2 == Class1.smethod_1(string_5[i], 1))
				{
					text = string_5[i];
					break;
				}
			}
		}
		string_2 = text;
		Class66.smethod_11(Class66.smethod_1(), "NTT_TenVatphamAn", Class11.smethod_71(string_2), "", 0);
	}

	private void numericUpDown1_ValueChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_2 = (int)numericUpDown1.Value;
			Class66.smethod_11(Class66.smethod_1(), "NTT_TimeDelta", int_2, "", 0);
		}
	}

	private void textBoxSL_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_1 = Class11.smethod_11(textBoxSL.Text);
			if (int_1 <= 0)
			{
				int_1 = 1;
			}
			Class66.smethod_11(Class66.smethod_1(), "NTT_SLVatphamAn", int_1, "", 0);
		}
	}
}
