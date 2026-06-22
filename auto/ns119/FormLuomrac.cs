using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns13;
using ns138;
using ns23;
using ns24;
using ns36;
using ns53;
using ns57;
using ns59;
using ns61;
using ns63;
using ns71;
using ns81;
using ns83;
using ns85;

namespace ns119;

public class FormLuomrac : Form
{
	public static bool bool_0 = false;

	public static int int_0 = 0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public static int int_5 = Class66.smethod_4("ThoigiantrePCD", 0, "100");

	private bool bool_1 = false;

	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Label label1;

	private CheckBox checkBoxAccept;

	private Button buttonDong;

	private Button buttonPhichiendau;

	private CheckBox checkBoxBanTheoThuoctinh;

	private Label label2;

	private TextBox textBoxThoigianTre;

	private Label label3;

	private Button button1;

	private TextBox textBox1;

	private Label label4;

	private IContainer icontainer_1;

	private GroupBox groupBox1;

	public FormLuomrac()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		int_0 = 0;
		bool_0 = false;
	}

	private void FormLuomrac_Load(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			Close();
			return;
		}
		Form1.characterAccountConfig_1[num].int_55 = 0;
		CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[num];
		if (int_1 >= 0 && int_2 >= 0)
		{
			int num2 = int_1 - base.Width - 10;
			int num3 = int_2 - base.Height - 10;
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
		checkBoxAccept.Checked = characterAccountConfig.int_55 > 0;
		checkBoxBanTheoThuoctinh.Checked = characterAccountConfig.int_56 > 0;
		textBoxThoigianTre.Text = int_5.ToString();
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

	private void checkBoxBanTheoThuoctinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_56 = Convert.ToByte(checkBoxBanTheoThuoctinh.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxAccept_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_55 = Convert.ToByte(checkBoxAccept.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonPhichiendau_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num >= 0)
		{
			string text = Class1.smethod_1(Form1.characterAccountConfig_1[num].string_22, 1) + ": " + Class56.string_7 + "Khi làm phi chiến đấu, ac phải lưu rương khác map. " + Class56.string_7 + "Ví dụ làm ở Mạc Cao Quật thì không được lưu rương Thành đô, ở Sa mạc 1, 2, 3 thì không được lưu rương Lâm an..." + Class56.string_7 + "Sau khi làm phi chiến đấu, ac sẽ tự thoát game và bạn phải log lại. Bạn chắc chắn muốn làm phi chiến đấu cho ac ?";
			if (MessageBox.Show(text, Form1.string_49, MessageBoxButtons.YesNo) != DialogResult.No)
			{
				Class64.smethod_28(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonDong_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void textBoxThoigianTre_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int_5 = Class11.smethod_11(textBoxThoigianTre.Text);
			Class66.smethod_11(Class66.smethod_1(), "ThoigiantrePCD", int_5, "", 0);
		}
	}

	public static void smethod_0(int int_6)
	{
		try
		{
			smethod_1(int_6);
		}
		catch
		{
		}
	}

	private static void smethod_1(int int_6)
	{
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		int num = -1;
		int num2 = 0;
		long long_ = 0L;
		long long_2 = 0L;
		int num3 = -1;
		int num4 = 0;
		uint[] uint_ = null;
		string[] string_ = null;
		bool flag = false;
		long long_3 = 0L;
		long long_4 = 0L;
		uint[] array = null;
		uint[] array2 = null;
		int num5 = -1;
		long num6 = 0L;
		while (true)
		{
			Thread.Sleep(300);
			int num7 = Class87.smethod_3(Form1.characterAccountConfig_1, int_6);
			if (Class11.bool_0 || num7 < 0 || !Form1.characterAccountConfig_1[num7].bool_25 || Form1.characterAccountConfig_1[num7].int_25 <= 0 || Form1.characterAccountConfig_1[num7].int_54 <= 0 || Form1.characterAccountConfig_1[num7].int_55 <= 0 || Form1.characterAccountConfig_1[num7].int_32 <= 0)
			{
				break;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num7];
			if (!flag)
			{
				Class75.smethod_52(characterAccountConfig, "<color=yellow>Chay Rac: " + Class39.smethod_1(characterAccountConfig.int_32));
				flag = true;
			}
			if (characterAccountConfig.bool_15 || characterAccountConfig.gstruct49_0.int_0 > 0 || Class89.smethod_12(characterAccountConfig) > 0)
			{
				continue;
			}
			uint num8 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.int_137);
			uint num9 = Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig.int_137);
			uint num10 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig.int_137);
			uint num11 = num10 + num9 * Class56.memorySignatureScanConfig_15.uint_0;
			int num12 = (int)Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
			int num13 = (int)Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig.int_137);
			int num14 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
			uint[] array3 = new uint[2]
			{
				Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
				Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
			};
			int num15 = Class89.smethod_39(characterAccountConfig);
			if (num13 == 0 || num12 == 0 || num14 == 0 || num12 == 10 || num12 == 21 || num15 <= 1)
			{
				continue;
			}
			Class64.smethod_29(characterAccountConfig, bool_0: false);
			if (Class11.smethod_28(long_2) > 300000L)
			{
				uint_ = null;
				string_ = new string[3] { "ThÇn Hµnh Phï", "Thæ ®Þa phï", "Håi thµnh phï" };
				long_2 = Class11.smethod_27();
			}
			if (characterAccountConfig.int_26 > 0 && !characterAccountConfig.bool_6 && Class11.smethod_28(long_3) > 15000L)
			{
				Class25.int_0 = int_6;
				new Thread(new Class25().method_1).Start();
				long_3 = Class11.smethod_27();
			}
			if (num14 != characterAccountConfig.int_32)
			{
				Class64.smethod_10(characterAccountConfig, "Sai map (toa do chay khong phai cua map nay) !");
				goto IL_07fe;
			}
			uint uint_2;
			int num19;
			long long_5;
			if (characterAccountConfig.int_61 > 0)
			{
				if (array != null)
				{
					uint num16 = Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig.int_137);
					uint num17 = num16 + array[0] * Class56.memorySignatureScanConfig_127.uint_0;
					int int_7 = 0;
					byte[] array4 = new byte[1];
					byte[] array5 = new byte[4];
					Class24.ReadProcessMemory(characterAccountConfig.int_137, num17 + Class56.memorySignatureScanConfig_138.uint_0, array4, 1, ref int_7);
					Class24.ReadProcessMemory(characterAccountConfig.int_137, num17 + Class56.memorySignatureScanConfig_137.uint_0, array5, 4, ref int_7);
					if (array4[0] == 0 || BitConverter.ToInt32(array5, 0) <= 0)
					{
						array = null;
					}
				}
				if (array == null)
				{
					array = Class62.smethod_0(characterAccountConfig, array3, bool_2: true, bool_3: false);
				}
				if (array != null)
				{
					uint[] array6 = new uint[2]
					{
						array[2],
						array[3]
					};
					long num18 = Class64.smethod_18(array3, array6);
					if (num18 <= characterAccountConfig.int_52 * characterAccountConfig.int_52)
					{
						if (num5 == array[0] && array2 != null && array2[0] == array[2] && array2[1] == array[3])
						{
							uint_2 = array[0];
							num19 = (int)array[4];
							long_5 = 0L;
							if (Class11.smethod_28(long_4) > 12000L)
							{
								goto IL_0511;
							}
							if (Class11.smethod_28(long_4) > 3000L)
							{
								string string_2 = Class89.smethod_20(characterAccountConfig);
								if (0 < Class11.smethod_1(string_2, "qu\u00b8 xa") || 0 < Class11.smethod_1(string_2, "o¶ng trèn"))
								{
									long_5 = Class11.smethod_27() - Class62.int_0 + 6000L;
									Class89.smethod_21(characterAccountConfig, "0K..");
									if (Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_44.uint_0, characterAccountConfig.int_137) == 0)
									{
										Class75.smethod_57(characterAccountConfig, "Switch([[sit]])");
									}
									goto IL_0511;
								}
							}
						}
						else
						{
							num5 = (int)array[0];
							array2 = new uint[2]
							{
								array[2],
								array[3]
							};
							long_4 = Class11.smethod_27();
						}
						if (num18 > 40000L && characterAccountConfig.int_54 <= 0)
						{
							Class75.smethod_61(characterAccountConfig, array6);
							Thread.Sleep(150);
						}
						Class75.smethod_48(characterAccountConfig, array[0]);
						Thread.Sleep(150);
					}
				}
			}
			goto IL_0596;
			IL_07fe:
			int num20 = (int)Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
			if (num20 > 0)
			{
				continue;
			}
			int num21 = Class85.smethod_4(characterAccountConfig);
			if (num3 != num21)
			{
				if (characterAccountConfig.int_56 <= 0)
				{
					smethod_2(characterAccountConfig, ref uint_, ref string_);
				}
				else
				{
					Class60.smethod_4(characterAccountConfig);
				}
				num3 = Class85.smethod_4(characterAccountConfig);
			}
			continue;
			IL_068d:
			uint[] array7;
			if (characterAccountConfig.uint_0 != null)
			{
				int length = characterAccountConfig.uint_0.GetLength(0);
				if (num < 0 || num2 == 0)
				{
					num = 0;
					if (length > 1)
					{
						num = Class64.smethod_20(characterAccountConfig.uint_0, array3);
						if (num < 0)
						{
							num = 0;
						}
					}
					num2 = 1;
				}
				array7 = new uint[2]
				{
					characterAccountConfig.uint_0[num, 0],
					characterAccountConfig.uint_0[num, 1]
				};
				long num22 = Class64.smethod_18(array3, array7);
				if (num22 > 600000L)
				{
					if (!Class13.smethod_3(characterAccountConfig) || Class11.smethod_28(long_) > 10000L)
					{
						Class13.smethod_1(characterAccountConfig, array7);
						long_ = Class11.smethod_27();
					}
					continue;
				}
				if (num22 > 16000L)
				{
					Class75.smethod_61(characterAccountConfig, array7);
					Thread.Sleep(100);
					continue;
				}
				if (length > 1)
				{
					num += num2;
					if (characterAccountConfig.int_29 > 0)
					{
						if (num < 0 || length <= num)
						{
							num = 0;
						}
						num2 = 1;
					}
					else if (num < 0)
					{
						num = 0;
						num2 = 1;
						if (length > 1)
						{
							num++;
						}
					}
					else if (length <= num)
					{
						num = length - 1;
						num2 = -1;
						if (length > 1)
						{
							num--;
						}
					}
				}
			}
			goto IL_07fe;
			IL_0511:
			Class62.smethod_4(ref characterAccountConfig.gstruct40_0, uint_2, num19, long_5);
			num5 = -1;
			array = null;
			long_4 = Class11.smethod_27();
			goto IL_0596;
			IL_0596:
			if (num6 > 0L && Class11.smethod_28(num6) < 1000L)
			{
				goto IL_068d;
			}
			uint[] array8 = null;
			long num23 = 0L;
			array7 = null;
			array8 = Class64.smethod_26(characterAccountConfig, ref num4);
			if (array8 != null)
			{
				num6 = 0L;
				array7 = array8;
				num23 = Class64.smethod_18(array3, array8);
				if (num23 >= 8000L)
				{
					if (num23 >= 22500L && num23 >= characterAccountConfig.int_68[1] * characterAccountConfig.int_68[1])
					{
						if (num23 >= 360000L)
						{
							if (num23 >= 1200000L)
							{
								goto IL_068d;
							}
							if (Class11.smethod_28(long_) > 3000L)
							{
								Class13.smethod_1(characterAccountConfig, array8);
								long_ = Class11.smethod_27();
							}
						}
						else
						{
							Class13.smethod_2(characterAccountConfig, bool_0: false);
							Class75.smethod_61(characterAccountConfig, array8);
							Thread.Sleep(100);
						}
					}
					else
					{
						Class75.smethod_61(characterAccountConfig, array8);
						Thread.Sleep(100);
					}
				}
			}
			else
			{
				num6 = Class11.smethod_27();
			}
			goto IL_07fe;
		}
	}

	private static void smethod_2(CharacterAccountConfig characterAccountConfig_0, ref uint[] uint_0, ref string[] string_0)
	{
		int int_ = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		byte[] array3 = new byte[80];
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_97.uint_0;
		uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_105.uint_0, characterAccountConfig_0.int_137);
		byte[] array4 = new byte[4];
		int int_2 = 0;
		int num3 = Class85.smethod_4(characterAccountConfig_0);
		int num4 = 0;
		for (uint num5 = 1u; num5 < Class56.int_1 && num3 > num4; num5++)
		{
			uint num6 = num2 + num5 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array4, 4, ref int_2);
			if (BitConverter.ToInt32(array4, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_107.uint_0, array4, 1, ref int_2);
			if (array4[0] == 0)
			{
				continue;
			}
			uint num7 = Class85.smethod_1(characterAccountConfig_0, num5);
			if (num7 == 0)
			{
				continue;
			}
			num4++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_120.uint_0, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_108.uint_0, array2, 4, ref int_);
			int num8 = BitConverter.ToInt32(array2, 0);
			if (num8 > 3)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_109.uint_0, array2, 4, ref int_);
			int num9 = BitConverter.ToInt32(array2, 0);
			if (num9 == 1 || num9 == 4)
			{
				continue;
			}
			if (uint_0 != null)
			{
				bool flag = false;
				for (int i = 0; i < uint_0.Length; i++)
				{
					if (num5 == uint_0[i])
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					continue;
				}
			}
			if (string_0 != null)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_);
				string string_1 = Class1.smethod_3(array3).ToLower();
				bool flag2 = false;
				for (int j = 0; j < string_0.Length; j++)
				{
					if (Class11.smethod_1(string_1, string_0[j].ToLower()) == 0)
					{
						flag2 = true;
						break;
					}
				}
				if (flag2)
				{
					continue;
				}
			}
			uint num10 = Class24.smethod_30(num + num7 * 20 + Class56.memorySignatureScanConfig_100.uint_0 - 8, characterAccountConfig_0.int_137);
			if ((int)num7 <= 0 || num10 != 3)
			{
				continue;
			}
			uint num11 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num12 = Class24.smethod_30(num11 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
			uint num13 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num14 = num13 + num12 * Class56.memorySignatureScanConfig_15.uint_0;
			Class75.smethod_35(characterAccountConfig_0, num5);
			int num15 = 0;
			while (!Class11.bool_0 && Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_) && array[0] != 0)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num14 + Class56.memorySignatureScanConfig_43.uint_0, array2, 4, ref int_);
				if (BitConverter.ToInt32(array2, 0) > 0)
				{
					break;
				}
				num15++;
				Thread.Sleep(100);
				if (num15 > 15)
				{
					string string_2 = Class89.smethod_22(characterAccountConfig_0);
					if (Class11.smethod_1(string_2, "hÊt b¹i") > 0)
					{
						Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_);
						string string_3 = Class1.smethod_3(array3);
						Class11.smethod_29(ref string_0, string_3);
						Class11.smethod_41(ref uint_0, num5);
						Class89.smethod_23(characterAccountConfig_0, "0K..");
						break;
					}
				}
			}
		}
		Thread.Sleep(100);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		string text = "https://youtu.be/dDYR4Al3LIg";
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
		string string_ = "Xem video hướng dẫn tại: " + Class56.string_7 + text;
		FormTip.smethod_0("PHI CHIEN DAU", string_, 600000, 250, 80);
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
		this.icontainer_1 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns119.FormLuomrac));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_1);
		this.label1 = new System.Windows.Forms.Label();
		this.checkBoxAccept = new System.Windows.Forms.CheckBox();
		this.buttonDong = new System.Windows.Forms.Button();
		this.buttonPhichiendau = new System.Windows.Forms.Button();
		this.checkBoxBanTheoThuoctinh = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.textBoxThoigianTre = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.button1 = new System.Windows.Forms.Button();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.label1.Location = new System.Drawing.Point(12, 32);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(370, 175);
		this.label1.TabIndex = 0;
		this.label1.Text = resources.GetString("label1.Text");
		this.checkBoxAccept.AutoSize = true;
		this.checkBoxAccept.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxAccept.Location = new System.Drawing.Point(94, 407);
		this.checkBoxAccept.Name = "checkBoxAccept";
		this.checkBoxAccept.Size = new System.Drawing.Size(92, 17);
		this.checkBoxAccept.TabIndex = 1;
		this.checkBoxAccept.Text = "Tôi đã hiểu rõ";
		this.checkBoxAccept.UseVisualStyleBackColor = true;
		this.checkBoxAccept.CheckedChanged += new System.EventHandler(checkBoxAccept_CheckedChanged);
		this.buttonDong.Location = new System.Drawing.Point(284, 398);
		this.buttonDong.Name = "buttonDong";
		this.buttonDong.Size = new System.Drawing.Size(97, 32);
		this.buttonDong.TabIndex = 2;
		this.buttonDong.Text = "Đóng";
		this.buttonDong.UseVisualStyleBackColor = true;
		this.buttonDong.Click += new System.EventHandler(buttonDong_Click);
		this.buttonPhichiendau.Location = new System.Drawing.Point(280, 126);
		this.buttonPhichiendau.Name = "buttonPhichiendau";
		this.buttonPhichiendau.Size = new System.Drawing.Size(81, 34);
		this.buttonPhichiendau.TabIndex = 3;
		this.buttonPhichiendau.Text = "Làm phi chiến đấu";
		this.buttonPhichiendau.UseVisualStyleBackColor = true;
		this.buttonPhichiendau.Click += new System.EventHandler(buttonPhichiendau_Click);
		this.checkBoxBanTheoThuoctinh.AutoSize = true;
		this.checkBoxBanTheoThuoctinh.Location = new System.Drawing.Point(15, 9);
		this.checkBoxBanTheoThuoctinh.Name = "checkBoxBanTheoThuoctinh";
		this.checkBoxBanTheoThuoctinh.Size = new System.Drawing.Size(234, 17);
		this.checkBoxBanTheoThuoctinh.TabIndex = 4;
		this.checkBoxBanTheoThuoctinh.Text = "Bán rác theo bảng thuộc tính Lọc vật phẩm";
		this.checkBoxBanTheoThuoctinh.UseVisualStyleBackColor = true;
		this.checkBoxBanTheoThuoctinh.CheckedChanged += new System.EventHandler(checkBoxBanTheoThuoctinh_CheckedChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(123, 141);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(91, 13);
		this.label2.TabIndex = 5;
		this.label2.Text = "Thời gian trễ (ms):";
		this.textBoxThoigianTre.Location = new System.Drawing.Point(220, 138);
		this.textBoxThoigianTre.Name = "textBoxThoigianTre";
		this.textBoxThoigianTre.Size = new System.Drawing.Size(46, 20);
		this.textBoxThoigianTre.TabIndex = 6;
		this.textBoxThoigianTre.TextChanged += new System.EventHandler(textBoxThoigianTre_TextChanged);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(8, 28);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(258, 13);
		this.label3.TabIndex = 7;
		this.label3.Text = "Cách 1: làm thủ công bằng tay (tỉ lệ thành công cao )";
		this.button1.Location = new System.Drawing.Point(280, 38);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(81, 26);
		this.button1.TabIndex = 8;
		this.button1.Text = "Xem phim";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.textBox1.Location = new System.Drawing.Point(11, 44);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(263, 20);
		this.textBox1.TabIndex = 9;
		this.textBox1.Text = " ";
		this.label4.Location = new System.Drawing.Point(8, 87);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(344, 48);
		this.label4.TabIndex = 10;
		this.label4.Text = "Cách 2: để auto tự làm, cách này tỉ lệ thành công thấp. \r\nLưu ý:Nên chỉnh lại <Thời gian trễ> nhỏ xuống hoặc cao hơn nếu làm phi chiến đấu không thành công.";
		this.groupBox1.Controls.Add(this.buttonPhichiendau);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.textBox1);
		this.groupBox1.Controls.Add(this.button1);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.textBoxThoigianTre);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Location = new System.Drawing.Point(4, 219);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(377, 168);
		this.groupBox1.TabIndex = 11;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Cách làm phi chiến đấu";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(388, 435);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.checkBoxBanTheoThuoctinh);
		base.Controls.Add(this.buttonDong);
		base.Controls.Add(this.checkBoxAccept);
		base.Controls.Add(this.label1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormLuomrac";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "LUOM RAC PHI SHOP";
		base.Load += new System.EventHandler(FormLuomrac_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
