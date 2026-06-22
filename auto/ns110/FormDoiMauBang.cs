using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns121;
using ns138;
using ns146;
using ns23;
using ns27;
using ns53;
using ns63;
using ns71;

namespace ns110;

public class FormDoiMauBang : Form
{
	public static bool bool_0 = false;

	public static GStruct2 gstruct2_0 = new GStruct2
	{
		string_0 = Class11.smethod_15(Class66.smethod_7("TenAccdoiMau", 0, "Li4u")),
		string_1 = Class11.smethod_15(Class66.smethod_7("DoiTheoTenAcc", 0)),
		string_2 = Class11.smethod_15(Class66.smethod_7("DoiTheoTenBang", 0)),
		int_2 = Class66.smethod_4("fDoituong", 0, "0"),
		int_1 = Class66.smethod_4("fNghichmau", 0, "0"),
		int_0 = 0
	};

	public int int_0 = 0;

	public int int_1 = 0;

	private bool bool_1 = false;

	private string[] string_0 = null;

	private string[] string_1 = null;

	public static int int_2 = -1;

	private IContainer icontainer_0 = null;

	private ComboBox comboBoxThemAcc;

	private System.Windows.Forms.Timer timer_0;

	private RadioButton radioButton1;

	private RadioButton radioButton2;

	private ComboBox comboBoxTenBHO;

	private CheckBox checkBoxNghichMau;

	private CheckBox checkBoxTudong;

	private Button buttonClose;

	private Button buttonHelp;

	private Label labelAdminGame;

	public FormDoiMauBang()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	public static void smethod_0(uint uint_0)
	{
		if (gstruct2_0.characterAccountConfig_0.int_136 > 0)
		{
			if (int_2 != gstruct2_0.characterAccountConfig_0.int_136 || gstruct2_0.int_3 <= 0)
			{
				gstruct2_0.int_3 = GClass1.smethod_5(gstruct2_0.characterAccountConfig_0);
				if (gstruct2_0.int_3 <= 0)
				{
					return;
				}
				int_2 = gstruct2_0.characterAccountConfig_0.int_136;
			}
			Class28.smethod_11(gstruct2_0.characterAccountConfig_0, uint_0);
		}
		else
		{
			Class11.string_17 = new string[1] { "Đổi màu bang: Hãy chọn tên ac đổi màu trước." };
		}
	}

	public static void smethod_1()
	{
		while (true)
		{
			try
			{
				if (!Class11.bool_0 && gstruct2_0.int_0 > 0)
				{
					Class75.smethod_52(gstruct2_0.characterAccountConfig_0, "<bclr=blue><color=green>§æi mµu bang tù ®éng...");
					smethod_2();
					Class75.smethod_52(gstruct2_0.characterAccountConfig_0, "<bclr=blue><color=green>KÕt thóc tù ®éng ®æi mµu bang !");
					continue;
				}
				break;
			}
			catch
			{
				Thread.Sleep(300);
			}
		}
	}

	private static void smethod_2()
	{
		int int_ = 0;
		int num = 0;
		int int_2 = 32;
		int num2 = 0;
		byte[] array = new byte[4];
		byte[] byte_ = new byte[32];
		byte[] array2 = new byte[12];
		uint num3 = 0u;
		while (true)
		{
			Thread.Sleep(300);
			if (AuxiliaryMachineManager.bool_5)
			{
				gstruct2_0.int_0 = 0;
			}
			if (Class11.bool_0 || gstruct2_0.int_0 <= 0)
			{
				break;
			}
			if (gstruct2_0.characterAccountConfig_0.int_136 <= 0)
			{
				num = 0;
				continue;
			}
			num--;
			if (num <= 0)
			{
				gstruct2_0.int_3 = GClass1.smethod_5(gstruct2_0.characterAccountConfig_0);
				num = 100;
			}
			if (gstruct2_0.int_3 <= 0)
			{
				continue;
			}
			int int_3;
			uint num7;
			uint num8;
			uint num13;
			uint num10;
			uint num4;
			if (num2 <= 0)
			{
				if (gstruct2_0.int_2 > 0)
				{
					if (gstruct2_0.string_2 == null || gstruct2_0.string_2 == string.Empty)
					{
						continue;
					}
				}
				else if (gstruct2_0.string_1 == null || gstruct2_0.string_1 == string.Empty)
				{
					continue;
				}
				int_3 = gstruct2_0.characterAccountConfig_0.int_137;
				num4 = 0u;
				Class24.ReadProcessMemory(int_3, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
				uint num5 = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(int_3, num5 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_);
				uint num6 = BitConverter.ToUInt32(array, 0) * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(int_3, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_);
				num7 = BitConverter.ToUInt32(array, 0);
				num8 = num7 + num6;
				if (num3 != 0)
				{
					num4 = num7 + num3 * Class56.memorySignatureScanConfig_15.uint_0;
					Class24.ReadProcessMemory(int_3, num4 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
					if (BitConverter.ToInt32(array, 0) > 0)
					{
						Class24.ReadProcessMemory(int_3, num4 + Class56.memorySignatureScanConfig_16.uint_0, array, 1, ref int_);
						if (array[0] != 0)
						{
							Class24.ReadProcessMemory(int_3, num4 + Class56.memorySignatureScanConfig_54.uint_0, array, 1, ref int_);
							int num9 = array[0];
							if (num9 > 0 && num9 <= 3)
							{
								if (gstruct2_0.int_2 != 0)
								{
									if (gstruct2_0.uint_0 != 0)
									{
										Class24.ReadProcessMemory(int_3, num4 + Class56.memorySignatureScanConfig_88.uint_0, array, 4, ref int_);
										num10 = BitConverter.ToUInt32(array, 0);
										if (num10 == gstruct2_0.uint_0)
										{
											goto IL_056c;
										}
									}
								}
								else
								{
									Class24.ReadProcessMemory(int_3, num4 + Class56.memorySignatureScanConfig_16.uint_0, byte_, int_2, ref int_);
									string text = Class1.smethod_3(byte_);
									if (text != string.Empty && text == gstruct2_0.string_1)
									{
										goto IL_056c;
									}
								}
							}
						}
					}
				}
				num3 = 0u;
				gstruct2_0.uint_0 = 0u;
				uint uint_ = gstruct2_0.characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
				Class24.ReadProcessMemory(int_3, uint_, array, 4, ref int_);
				int num11 = BitConverter.ToInt32(array, 0);
				int num12 = 0;
				for (num13 = 1u; num13 < 256 && num11 > num12; num13++)
				{
					num4 = num7 + num13 * Class56.memorySignatureScanConfig_15.uint_0;
					Class24.ReadProcessMemory(int_3, num4 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
					if (BitConverter.ToInt32(array, 0) <= 0)
					{
						continue;
					}
					Class24.ReadProcessMemory(int_3, num4 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_);
					if (array[0] == 0)
					{
						continue;
					}
					num12++;
					Class24.ReadProcessMemory(int_3, num4 + Class56.memorySignatureScanConfig_52.uint_0, array, 4, ref int_);
					uint num14 = BitConverter.ToUInt32(array, 0);
					if (num14 != 1)
					{
						continue;
					}
					Class24.ReadProcessMemory(int_3, num4 + Class56.memorySignatureScanConfig_54.uint_0, array, 1, ref int_);
					int num15 = array[0];
					if (num15 <= 0 || num15 > 3)
					{
						continue;
					}
					if (gstruct2_0.int_2 <= 0)
					{
						Class24.ReadProcessMemory(int_3, num4 + Class56.memorySignatureScanConfig_16.uint_0, byte_, int_2, ref int_);
						string text2 = Class1.smethod_3(byte_);
						if (!(Class1.smethod_1(text2, 1) == gstruct2_0.string_1))
						{
							continue;
						}
						goto IL_0556;
					}
					Class24.ReadProcessMemory(int_3, num4 + Class56.memorySignatureScanConfig_88.uint_0, array, 4, ref int_);
					num10 = BitConverter.ToUInt32(array, 0);
					if (num10 == 0)
					{
						continue;
					}
					Class24.ReadProcessMemory(int_3, num4 + Class56.memorySignatureScanConfig_89.uint_0, array2, array2.Length, ref int_);
					if (array2[0] == 0)
					{
						continue;
					}
					string text3 = Class1.smethod_3(array2);
					if (Class11.smethod_6(text3) != num10)
					{
						string text4 = string.Empty;
						for (int i = 0; i < text3.Length; i++)
						{
							text4 += text3[i];
							if (Class11.smethod_6(text4) == num10)
							{
								text3 = text4;
								break;
							}
						}
					}
					if (!(text3 == gstruct2_0.string_2))
					{
						continue;
					}
					goto IL_055c;
				}
				num2 = 10;
			}
			else
			{
				num2--;
			}
			continue;
			IL_055c:
			num3 = num13;
			gstruct2_0.uint_0 = num10;
			goto IL_056c;
			IL_056c:
			num4 = num7 + num3 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(int_3, num4 + Class56.memorySignatureScanConfig_54.uint_0, array, 4, ref int_);
			uint num16 = array[0];
			if (num16 == 0 || num16 > 3)
			{
				continue;
			}
			Class24.ReadProcessMemory(int_3, num8 + Class56.memorySignatureScanConfig_54.uint_0, array, 4, ref int_);
			uint num17 = array[0];
			if (num17 == 0)
			{
				continue;
			}
			uint num18 = 0u;
			if (gstruct2_0.int_1 > 0)
			{
				if (num17 == num16)
				{
					num18 = num16 + 1;
					if (num18 > 3)
					{
						num18 = 1u;
					}
				}
			}
			else if (num17 != num16)
			{
				num18 = num16;
			}
			if (num18 != 0)
			{
				smethod_0(num18);
				Thread.Sleep(100);
			}
			continue;
			IL_0556:
			num3 = num13;
			goto IL_056c;
		}
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
		bool_1 = false;
	}

	private void FormDoiMauBang_Load(object sender, EventArgs e)
	{
		try
		{
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
			radioButton1.Checked = gstruct2_0.int_2 == 0;
			radioButton2.Checked = gstruct2_0.int_2 > 0;
			checkBoxNghichMau.Checked = gstruct2_0.int_1 > 0;
			checkBoxTudong.Checked = !AuxiliaryMachineManager.bool_5 && gstruct2_0.int_0 > 0;
			if (gstruct2_0.string_1 != null && gstruct2_0.string_1 != string.Empty)
			{
				comboBoxThemAcc.Items.Add(Class1.smethod_1(gstruct2_0.string_1, 1));
				comboBoxThemAcc.Text = comboBoxThemAcc.Items[0].ToString();
			}
			if (gstruct2_0.string_2 != null && gstruct2_0.string_2 != string.Empty)
			{
				comboBoxTenBHO.Items.Add(Class1.smethod_1(gstruct2_0.string_2, 1));
				comboBoxTenBHO.Text = comboBoxTenBHO.Items[0].ToString();
			}
			if (AuxiliaryMachineManager.bool_5)
			{
				gstruct2_0.int_0 = 0;
				checkBoxTudong.Enabled = false;
				labelAdminGame.Text = "( Adgame đã khóa rồi !!! )";
			}
			Text = "DOI MAU BANG";
			timer_0.Interval = 300;
			timer_0.Enabled = true;
			bool_1 = true;
			base.TopMost = true;
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

	private void buttonClose_Click(object sender, EventArgs e)
	{
		bool_0 = false;
		Close();
	}

	public static void smethod_3(CharacterAccountConfig characterAccountConfig_0, ref string[] string_2, string[] string_3 = null, bool bool_2 = false)
	{
		byte[] array = new byte[53];
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		int int_ = 0;
		byte[] array2 = new byte[4];
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array2, 4, ref int_);
		int num2 = BitConverter.ToInt32(array2, 0);
		int num3 = 0;
		for (uint num4 = 1u; num4 < 256 && num2 > num3; num4++)
		{
			uint num5 = num + num4 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_50.uint_0, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) <= 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_16.uint_0, array2, 4, ref int_);
			if (array2[0] == 0)
			{
				continue;
			}
			num3++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_52.uint_0, array2, 4, ref int_);
			uint num6 = BitConverter.ToUInt32(array2, 0);
			if (num6 != 1)
			{
				continue;
			}
			string text = string.Empty;
			if (!bool_2)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_16.uint_0, array, array.Length, ref int_);
				text = Class1.smethod_3(array);
			}
			else
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_88.uint_0, array2, 4, ref int_);
				uint num7 = BitConverter.ToUInt32(array2, 0);
				if (num7 == 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_89.uint_0, array, array.Length, ref int_);
				string text2 = Class1.smethod_3(array);
				if (text2 == null || text2 == string.Empty)
				{
					continue;
				}
				string text3 = string.Empty;
				if (Class11.smethod_6(text2) != num7)
				{
					for (int i = 0; i < text2.Length; i++)
					{
						text3 += text2[i];
						if (Class11.smethod_6(text3) == num7)
						{
							text = text3;
							break;
						}
					}
				}
				else
				{
					text = text2;
				}
			}
			if (text == string.Empty)
			{
				continue;
			}
			if (string_3 != null)
			{
				bool flag = false;
				for (int j = 0; j < string_3.Length; j++)
				{
					if (text == string_3[j])
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
			if (string_2 != null)
			{
				bool flag2 = false;
				for (int k = 0; k < string_2.Length; k++)
				{
					if (text == string_2[k])
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					Array.Resize(ref string_2, string_2.Length + 1);
					string_2[string_2.Length - 1] = text;
				}
			}
			else
			{
				string_2 = new string[1] { text };
			}
		}
	}

	private void comboBoxThemAcc_MouseDown(object sender, MouseEventArgs e)
	{
		bool_1 = false;
		comboBoxThemAcc.Items.Clear();
		string_1 = null;
		if (gstruct2_0.string_1 != null && gstruct2_0.string_1 != string.Empty)
		{
			string_1 = new string[1] { gstruct2_0.string_1 };
		}
		smethod_3(gstruct2_0.characterAccountConfig_0, ref string_1, new string[1] { gstruct2_0.characterAccountConfig_0.string_22 });
		if (string_1 != null)
		{
			Array.Sort(string_1);
			for (int i = 0; i < string_1.Length; i++)
			{
				comboBoxThemAcc.Items.Add(Class1.smethod_1(string_1[i], 1));
			}
		}
		comboBoxThemAcc.Items.Add(string.Empty);
		bool_1 = true;
	}

	private void comboBoxThemAcc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_1 == null)
		{
			return;
		}
		string text = comboBoxThemAcc.Text;
		for (int i = 0; i < string_1.Length; i++)
		{
			if (Class1.smethod_1(string_1[i], 1) == text)
			{
				gstruct2_0.string_1 = string_1[i];
				Class66.smethod_11(Class66.smethod_1(), "DoiTheoTenAcc", Class11.smethod_16(gstruct2_0.string_1), "", 0);
				break;
			}
		}
	}

	private void comboBoxTenBHO_MouseDown(object sender, MouseEventArgs e)
	{
		bool_1 = false;
		comboBoxTenBHO.Items.Clear();
		string_0 = null;
		if (gstruct2_0.string_2 != null && gstruct2_0.string_2 != string.Empty)
		{
			string_0 = new string[1] { gstruct2_0.string_2 };
		}
		smethod_3(gstruct2_0.characterAccountConfig_0, ref string_0, new string[1] { gstruct2_0.characterAccountConfig_0.string_20 }, bool_2: true);
		if (string_0 != null)
		{
			Array.Sort(string_0);
			for (int i = 0; i < string_0.Length; i++)
			{
				comboBoxTenBHO.Items.Add(Class1.smethod_1(string_0[i], 1));
			}
		}
		comboBoxTenBHO.Items.Add(string.Empty);
		bool_1 = true;
	}

	private void comboBoxTenBHO_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_0 == null)
		{
			return;
		}
		string text = comboBoxTenBHO.Text;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (Class1.smethod_1(string_0[i], 1) == text)
			{
				gstruct2_0.string_2 = string_0[i];
				gstruct2_0.uint_0 = 0u;
				Class66.smethod_11(Class66.smethod_1(), "DoiTheoTenBang", Class11.smethod_16(gstruct2_0.string_2), "", 0);
				break;
			}
		}
	}

	private void radioButton1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1 && radioButton1.Checked)
		{
			radioButton2.Checked = false;
			gstruct2_0.int_2 = 0;
			gstruct2_0.uint_0 = 0u;
			Class66.smethod_11(Class66.smethod_1(), "fDoituong", gstruct2_0.int_2, "", 0);
		}
	}

	private void radioButton2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1 && radioButton2.Checked)
		{
			radioButton1.Checked = false;
			gstruct2_0.int_2 = 1;
			gstruct2_0.uint_0 = 0u;
			Class66.smethod_11(Class66.smethod_1(), "fDoituong", gstruct2_0.int_2, "", 0);
		}
	}

	private void checkBoxNghichMau_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1 && radioButton2.Checked)
		{
			gstruct2_0.int_1 = Convert.ToByte(checkBoxNghichMau.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fNghichmau", gstruct2_0.int_1, "", 0);
		}
	}

	private void checkBoxTudong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1 && radioButton2.Checked)
		{
			gstruct2_0.int_0 = Convert.ToByte(checkBoxTudong.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fTudong", gstruct2_0.int_0, "", 0);
			if (gstruct2_0.int_0 > 0)
			{
				new Thread(smethod_1).Start();
			}
		}
	}

	private void buttonHelp_Click(object sender, EventArgs e)
	{
		string string_ = "1. Đổi theo màu ac của đối phương||- Bạn phải đem ac đổi màu của bạn đứng gần ac của đối phương.|- Lưu ý tránh trường hợp chọn ac đối phương đang có PT (cờ) trên đầu, vì khi bang hội đối phương đổi màu thì ac này sẽ không bị đổi màu theo. Tốt nhất chọn ac đang ngồi bán hàng trong thành.||2. Đổi màu theo màu ac của bang hội.||- Ưu điểm: ac của bạn chỉ cần đứng gần ac (bất kỳ) trong bang hội của đối phương thì sẽ đổi màu được.|- Khuyết điểm: Nếu ac bạn đang đánh nhau mà bị chết về thành, nếu trong thành không có ac của đối phương thì sẽ ko đổi màu được.||";
		FormTip.smethod_0(Form1.string_49, string_, 600000, 400, 260);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns110.FormDoiMauBang));
		this.comboBoxThemAcc = new System.Windows.Forms.ComboBox();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.radioButton1 = new System.Windows.Forms.RadioButton();
		this.radioButton2 = new System.Windows.Forms.RadioButton();
		this.comboBoxTenBHO = new System.Windows.Forms.ComboBox();
		this.checkBoxNghichMau = new System.Windows.Forms.CheckBox();
		this.checkBoxTudong = new System.Windows.Forms.CheckBox();
		this.buttonClose = new System.Windows.Forms.Button();
		this.buttonHelp = new System.Windows.Forms.Button();
		this.labelAdminGame = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.comboBoxThemAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxThemAcc.DropDownWidth = 120;
		this.comboBoxThemAcc.ForeColor = System.Drawing.Color.Black;
		this.comboBoxThemAcc.FormattingEnabled = true;
		this.comboBoxThemAcc.Location = new System.Drawing.Point(30, 34);
		this.comboBoxThemAcc.Name = "comboBoxThemAcc";
		this.comboBoxThemAcc.Size = new System.Drawing.Size(155, 21);
		this.comboBoxThemAcc.TabIndex = 63;
		this.comboBoxThemAcc.SelectedIndexChanged += new System.EventHandler(comboBoxThemAcc_SelectedIndexChanged);
		this.comboBoxThemAcc.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxThemAcc_MouseDown);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.radioButton1.AutoSize = true;
		this.radioButton1.Location = new System.Drawing.Point(4, 11);
		this.radioButton1.Name = "radioButton1";
		this.radioButton1.Size = new System.Drawing.Size(166, 17);
		this.radioButton1.TabIndex = 64;
		this.radioButton1.TabStop = true;
		this.radioButton1.Text = "Theo màu ac của đối phương";
		this.radioButton1.UseVisualStyleBackColor = true;
		this.radioButton1.CheckedChanged += new System.EventHandler(radioButton1_CheckedChanged);
		this.radioButton2.AutoSize = true;
		this.radioButton2.Location = new System.Drawing.Point(4, 63);
		this.radioButton2.Name = "radioButton2";
		this.radioButton2.Size = new System.Drawing.Size(168, 17);
		this.radioButton2.TabIndex = 65;
		this.radioButton2.TabStop = true;
		this.radioButton2.Text = "Đổi theo màu ac của bang hội";
		this.radioButton2.UseVisualStyleBackColor = true;
		this.radioButton2.CheckedChanged += new System.EventHandler(radioButton2_CheckedChanged);
		this.comboBoxTenBHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxTenBHO.DropDownWidth = 120;
		this.comboBoxTenBHO.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTenBHO.FormattingEnabled = true;
		this.comboBoxTenBHO.Location = new System.Drawing.Point(30, 86);
		this.comboBoxTenBHO.Name = "comboBoxTenBHO";
		this.comboBoxTenBHO.Size = new System.Drawing.Size(155, 21);
		this.comboBoxTenBHO.TabIndex = 66;
		this.comboBoxTenBHO.SelectedIndexChanged += new System.EventHandler(comboBoxTenBHO_SelectedIndexChanged);
		this.comboBoxTenBHO.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenBHO_MouseDown);
		this.checkBoxNghichMau.AutoSize = true;
		this.checkBoxNghichMau.Location = new System.Drawing.Point(30, 187);
		this.checkBoxNghichMau.Name = "checkBoxNghichMau";
		this.checkBoxNghichMau.Size = new System.Drawing.Size(100, 17);
		this.checkBoxNghichMau.TabIndex = 69;
		this.checkBoxNghichMau.Text = "Đổi nghịch màu";
		this.checkBoxNghichMau.UseVisualStyleBackColor = true;
		this.checkBoxNghichMau.CheckedChanged += new System.EventHandler(checkBoxNghichMau_CheckedChanged);
		this.checkBoxTudong.AutoSize = true;
		this.checkBoxTudong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxTudong.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxTudong.Location = new System.Drawing.Point(30, 139);
		this.checkBoxTudong.Name = "checkBoxTudong";
		this.checkBoxTudong.Size = new System.Drawing.Size(123, 17);
		this.checkBoxTudong.TabIndex = 182;
		this.checkBoxTudong.Text = "Tự động đổi màu";
		this.checkBoxTudong.UseVisualStyleBackColor = true;
		this.checkBoxTudong.CheckedChanged += new System.EventHandler(checkBoxTudong_CheckedChanged);
		this.buttonClose.Location = new System.Drawing.Point(124, 228);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(80, 28);
		this.buttonClose.TabIndex = 183;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.buttonHelp.Location = new System.Drawing.Point(32, 228);
		this.buttonHelp.Name = "buttonHelp";
		this.buttonHelp.Size = new System.Drawing.Size(80, 28);
		this.buttonHelp.TabIndex = 184;
		this.buttonHelp.Text = "Trợ giúp";
		this.buttonHelp.UseVisualStyleBackColor = true;
		this.buttonHelp.Click += new System.EventHandler(buttonHelp_Click);
		this.labelAdminGame.AutoSize = true;
		this.labelAdminGame.Location = new System.Drawing.Point(44, 160);
		this.labelAdminGame.Name = "labelAdminGame";
		this.labelAdminGame.Size = new System.Drawing.Size(16, 13);
		this.labelAdminGame.TabIndex = 185;
		this.labelAdminGame.Text = "...";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.LightSteelBlue;
		base.ClientSize = new System.Drawing.Size(220, 265);
		base.Controls.Add(this.labelAdminGame);
		base.Controls.Add(this.buttonHelp);
		base.Controls.Add(this.checkBoxNghichMau);
		base.Controls.Add(this.checkBoxTudong);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.comboBoxTenBHO);
		base.Controls.Add(this.radioButton2);
		base.Controls.Add(this.radioButton1);
		base.Controls.Add(this.comboBoxThemAcc);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormDoiMauBang";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "ĐỔI MÀU BANG";
		base.Load += new System.EventHandler(FormDoiMauBang_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
