using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns23;
using ns53;
using ns63;
using ns71;
using ns81;
using ns83;
using ns85;

namespace ns103;

public class FormBanEvent : Form
{
	private IContainer icontainer_0 = null;

	private Button buttonXoa;

	private Button buttonThem;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ComboBox comboBoxTenTuiMauHotro;

	private Button buttonClose;

	private System.Windows.Forms.Timer timer_0;

	private Label label37;

	private TextBox textBoxTocdoban;

	private Label label1;

	public static int int_0 = 0;

	private static bool bool_0 = false;

	public static string[] string_0 = null;

	public static int int_1 = Class66.smethod_4("TocdoBanEvent", 0, "300");

	public static bool bool_1 = false;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	private static string[] string_1 = null;

	public FormBanEvent()
	{
		bool_1 = true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns103.FormBanEvent));
		this.buttonXoa = new System.Windows.Forms.Button();
		this.buttonThem = new System.Windows.Forms.Button();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.comboBoxTenTuiMauHotro = new System.Windows.Forms.ComboBox();
		this.buttonClose = new System.Windows.Forms.Button();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.label37 = new System.Windows.Forms.Label();
		this.textBoxTocdoban = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.buttonXoa.Location = new System.Drawing.Point(89, 315);
		this.buttonXoa.Name = "buttonXoa";
		this.buttonXoa.Size = new System.Drawing.Size(53, 23);
		this.buttonXoa.TabIndex = 235;
		this.buttonXoa.Text = "Xóa";
		this.buttonXoa.UseVisualStyleBackColor = true;
		this.buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		this.buttonThem.Location = new System.Drawing.Point(3, 315);
		this.buttonThem.Name = "buttonThem";
		this.buttonThem.Size = new System.Drawing.Size(80, 23);
		this.buttonThem.TabIndex = 234;
		this.buttonThem.Text = "Thêm";
		this.buttonThem.UseVisualStyleBackColor = true;
		this.buttonThem.Click += new System.EventHandler(buttonThem_Click);
		this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_0 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(3, 71);
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(200, 213);
		this.listView1.TabIndex = 233;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "Tên";
		this.columnHeader_0.Width = 180;
		this.comboBoxTenTuiMauHotro.DropDownWidth = 252;
		this.comboBoxTenTuiMauHotro.FormattingEnabled = true;
		this.comboBoxTenTuiMauHotro.Location = new System.Drawing.Point(3, 288);
		this.comboBoxTenTuiMauHotro.Name = "comboBoxTenTuiMauHotro";
		this.comboBoxTenTuiMauHotro.Size = new System.Drawing.Size(200, 21);
		this.comboBoxTenTuiMauHotro.TabIndex = 232;
		this.comboBoxTenTuiMauHotro.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenTuiMauHotro_MouseDown);
		this.buttonClose.Location = new System.Drawing.Point(150, 315);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(53, 23);
		this.buttonClose.TabIndex = 236;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.label37.AutoSize = true;
		this.label37.ForeColor = System.Drawing.Color.Maroon;
		this.label37.Location = new System.Drawing.Point(2, 5);
		this.label37.Name = "label37";
		this.label37.Size = new System.Drawing.Size(136, 13);
		this.label37.TabIndex = 357;
		this.label37.Text = "Thời gian kiểm tra (mili giây)";
		this.textBoxTocdoban.Location = new System.Drawing.Point(143, 2);
		this.textBoxTocdoban.Name = "textBoxTocdoban";
		this.textBoxTocdoban.Size = new System.Drawing.Size(60, 20);
		this.textBoxTocdoban.TabIndex = 358;
		this.textBoxTocdoban.TextChanged += new System.EventHandler(textBoxTocdoban_TextChanged);
		this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
		this.label1.Location = new System.Drawing.Point(0, 24);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(207, 42);
		this.label1.TabIndex = 359;
		this.label1.Text = "Nếu lâu lâu mới bán hoặc ăn thì để cao lên cỡ 3000 - 6000 nhé (vì để thấp thì %cpu sẽ cao dễ gây diss game)";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(207, 342);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.textBoxTocdoban);
		base.Controls.Add(this.label37);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.buttonXoa);
		base.Controls.Add(this.buttonThem);
		base.Controls.Add(this.listView1);
		base.Controls.Add(this.comboBoxTenTuiMauHotro);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormBanEvent";
		this.Text = "VAT PHAM RAC";
		base.Load += new System.EventHandler(FormBanEvent_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private static string[] smethod_0()
	{
		string text = Class11.smethod_33(Class56.string_9 + "\\VatphamRac.txt", 0, 0, 1);
		if (text != null && !(text == string.Empty))
		{
			string text2 = Class11.smethod_15(text);
			if (text2 != null && !(text2 == string.Empty))
			{
				string[] array = text2.Split('|');
				int num = array.Length;
				int num2 = 0;
				string[] array2 = new string[num];
				for (int i = 0; i < num; i++)
				{
					if (array[i] != null && array[i] != string.Empty)
					{
						array2[num2] = array[i];
						num2++;
					}
				}
				if (num2 == 0)
				{
					array2 = null;
				}
				else if (num2 < num)
				{
					Array.Resize(ref array2, num2);
				}
				return array2;
			}
			return null;
		}
		return null;
	}

	private static void smethod_1(string[] string_2)
	{
		string text = string.Empty;
		if (string_2 != null)
		{
			for (int i = 0; i < string_2.Length; i++)
			{
				if (string_2[i] != null && string_2[i] != string.Empty)
				{
					if (text != string.Empty)
					{
						text += "|";
					}
					text += string_2[i];
				}
			}
		}
		Class11.smethod_34(Class56.string_9 + "\\VatphamRac.txt", Class11.smethod_16(text), 1);
	}

	public static void smethod_2()
	{
		int int_ = int_0;
		int_0 = 0;
		bool flag = false;
		if (string_0 == null && !bool_0)
		{
			string_0 = smethod_0();
			bool_0 = true;
		}
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25 || Form1.characterAccountConfig_1[num].int_12[0] <= 0)
				{
					if (0 <= num)
					{
						Form1.characterAccountConfig_1[num].bool_3 = false;
						Class75.smethod_52(Form1.characterAccountConfig_1[num], "<color=green>KÕt thóc xö lý vËt phÈm trong danh s\u00b8ch !");
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_3)
					{
						break;
					}
					flag = true;
					Form1.characterAccountConfig_1[num].bool_3 = true;
					Class75.smethod_52(Form1.characterAccountConfig_1[num], "<color=green>§ang ch¹y xö lý vËt phÈm trong danh s\u00b8ch (tab event - b\u00b8n)...");
				}
				smethod_4(int_);
			}
			catch
			{
			}
			Thread.Sleep(300);
		}
	}

	public static void smethod_3()
	{
		try
		{
			int int_ = int_0;
			int_0 = 0;
			smethod_4(int_, bool_2: true);
		}
		catch
		{
		}
	}

	private static void smethod_4(int int_6, bool bool_2 = false)
	{
		CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int int_7 = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[1];
		byte[] array3 = new byte[60];
		int num4 = -1;
		while (true)
		{
			num3--;
			num4--;
			Thread.Sleep(100);
			if (num3 <= 0)
			{
				num = Class87.smethod_3(Form1.characterAccountConfig_1, int_6);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25)
				{
					break;
				}
				characterAccountConfig_ = Form1.characterAccountConfig_1[num];
				if (!bool_2 && characterAccountConfig_.int_12[0] <= 0)
				{
					break;
				}
				num3 = 10;
			}
			if (string_0 != null && string_0.Length != 0)
			{
				int num5 = Class85.smethod_4(characterAccountConfig_);
				if (!bool_2 && num2 == num5)
				{
					if (0 <= num4)
					{
						continue;
					}
					int num6 = int_1 % 100;
					if (num6 > 0)
					{
						Thread.Sleep(num6);
					}
					num4 = int_1 / 100;
				}
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_7);
				uint num7 = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num7 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_7);
				uint num8 = BitConverter.ToUInt32(array, 0) * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_7);
				uint num9 = BitConverter.ToUInt32(array, 0);
				uint num10 = num9 + num8;
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num10 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_7);
				int num11 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num10 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_7);
				int num12 = BitConverter.ToInt32(array, 0);
				int num13 = Class89.smethod_39(characterAccountConfig_);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num10 + Class56.memorySignatureScanConfig_43.uint_0, array, 4, ref int_7);
				int num14 = BitConverter.ToInt32(array, 0);
				if (num11 != 0 && num13 > 1 && num12 != 0 && num12 != 10 && num12 != 21 && (num14 <= 0 || characterAccountConfig_.int_12[1] != 0))
				{
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_105.uint_0, array, 4, ref int_7);
					uint num15 = BitConverter.ToUInt32(array, 0);
					Class24.ReadProcessMemory(characterAccountConfig_.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_7);
					uint num16 = BitConverter.ToUInt32(array, 0) + Class56.memorySignatureScanConfig_97.uint_0;
					num5 = Class85.smethod_4(characterAccountConfig_);
					int num17 = 0;
					for (uint num18 = 1u; num18 < Class56.int_1 && num5 > num17; num18++)
					{
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num16 + (num18 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array, 4, ref int_7);
						uint num19 = BitConverter.ToUInt32(array, 0);
						if (num19 == 0)
						{
							continue;
						}
						uint num20 = num15 + num19 * Class56.memorySignatureScanConfig_106.uint_0;
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num20 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array, 4, ref int_7);
						if (BitConverter.ToInt32(array, 0) != 0)
						{
							continue;
						}
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num20 + Class56.memorySignatureScanConfig_107.uint_0, array2, 1, ref int_7);
						if (array2[0] == 0)
						{
							continue;
						}
						num17++;
						uint num21 = num16 + num18 * 20;
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 1, ref int_7);
						if (array2[0] != 3)
						{
							continue;
						}
						if (Class56.memorySignatureScanConfig_120.uint_0 != 0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num20 + Class56.memorySignatureScanConfig_120.uint_0, array, 4, ref int_7);
							if (BitConverter.ToUInt32(array, 0) != 0)
							{
								continue;
							}
						}
						if (string_0 == null || string_0.Length == 0)
						{
							break;
						}
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num20 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_7);
						string text = Class1.smethod_3(array3);
						bool flag = false;
						try
						{
							for (int i = 0; i < string_0.Length; i++)
							{
								if (text == string_0[i])
								{
									flag = true;
									break;
								}
							}
						}
						catch
						{
							break;
						}
						if (!flag)
						{
							continue;
						}
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array2, 1, ref int_7);
						int num22 = array2[0];
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num21 + Class56.memorySignatureScanConfig_100.uint_0, array2, 1, ref int_7);
						int num23 = array2[0];
						int num24 = 0;
						int num25 = 800;
						Class24.ReadProcessMemory(characterAccountConfig_.int_137, num20 + Class56.memorySignatureScanConfig_119.uint_0, array, 4, ref int_7);
						int num26 = BitConverter.ToInt32(array, 0);
						int num27 = num26;
						while (!Class11.bool_0 && num24 <= num25)
						{
							if (num24 % num25 == 0)
							{
								if (characterAccountConfig_.int_12[1] == 0)
								{
									Class75.smethod_35(characterAccountConfig_, num19);
								}
								else
								{
									Class75.smethod_43(characterAccountConfig_, num19, num22, num23);
								}
							}
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num20 + Class56.memorySignatureScanConfig_107.uint_0, array2, 1, ref int_7);
							if (array2[0] == 0)
							{
								break;
							}
							num24++;
							Thread.Sleep(1);
							Class24.ReadProcessMemory(characterAccountConfig_.int_137, num20 + Class56.memorySignatureScanConfig_119.uint_0, array, 4, ref int_7);
							num26 = BitConverter.ToInt32(array, 0);
							if (num27 != num26)
							{
								num27 = num26;
								num24 = 0;
							}
						}
					}
				}
			}
			if (!bool_2)
			{
				num2 = Class85.smethod_4(characterAccountConfig_);
				continue;
			}
			break;
		}
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		smethod_1(string_0);
		bool_1 = false;
	}

	private void FormBanEvent_Load(object sender, EventArgs e)
	{
		if (int_2 > 0 && int_3 > 0)
		{
			int num = int_2 - base.Width - 10;
			int num2 = int_3 - base.Height - 10;
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
		string_0 = smethod_0();
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				method_0(listView1, Class1.smethod_1(string_0[i], 1));
			}
		}
		textBoxTocdoban.Text = int_1.ToString();
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			Close();
		}
	}

	private void method_0(ListView listView_0, string string_2)
	{
		try
		{
			string[] array = new string[1] { string_2 };
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

	private void comboBoxTenTuiMauHotro_MouseDown(object sender, MouseEventArgs e)
	{
		if (Form1.characterAccountConfig_1 == null)
		{
			return;
		}
		string_1 = null;
		int num = 0;
		for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
		{
			if (num > 10 && string_1 != null)
			{
				break;
			}
			Class85.smethod_38(Form1.characterAccountConfig_1[i], ref string_1);
		}
		comboBoxTenTuiMauHotro.Items.Clear();
		if (string_1 != null)
		{
			Array.Sort(string_1);
			for (int j = 0; j < string_1.Length; j++)
			{
				comboBoxTenTuiMauHotro.Items.Add(Class1.smethod_1(string_1[j], 1));
			}
		}
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		if (listView1.SelectedIndices.Count <= 0 || string_0 == null)
		{
			return;
		}
		int index = listView1.SelectedIndices[0];
		int num = string_0.Length;
		string text = listView1.Items[index].SubItems[0].Text;
		int num2 = -1;
		for (int i = 0; i < num; i++)
		{
			if (Class1.smethod_1(string_0[i], 1) == text)
			{
				num2 = i;
				break;
			}
		}
		if (num2 < 0)
		{
			return;
		}
		listView1.Items.RemoveAt(index);
		int num3 = 0;
		for (int j = 0; j < num; j++)
		{
			if (j != num2)
			{
				string_0[num3] = string_0[j];
				num3++;
			}
		}
		if (num3 == 0)
		{
			string_0 = null;
		}
		else
		{
			Array.Resize(ref string_0, num3);
		}
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (string_1 == null)
		{
			return;
		}
		string text = null;
		string text2 = comboBoxTenTuiMauHotro.Text;
		for (int i = 0; i < string_1.Length; i++)
		{
			if (text2 == Class1.smethod_1(string_1[i], 1))
			{
				text = string_1[i];
				break;
			}
		}
		if (text == null)
		{
			return;
		}
		if (string_0 == null)
		{
			string_0 = new string[1] { text };
		}
		else
		{
			for (int j = 0; j < string_0.Length; j++)
			{
				if (string_0[j] == text)
				{
					return;
				}
			}
			Array.Resize(ref string_0, string_0.Length + 1);
			string_0[string_0.Length - 1] = text;
		}
		method_0(listView1, Class1.smethod_1(text, 1));
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		bool_1 = false;
		Close();
	}

	private void textBoxTocdoban_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_1 = Class11.smethod_11(textBoxTocdoban.Text);
			if (int_1 < 0)
			{
				int_1 = 0;
			}
			Class66.smethod_11(Class66.smethod_1(), "TocdoBanEvent", int_1, "", 0);
		}
	}
}
