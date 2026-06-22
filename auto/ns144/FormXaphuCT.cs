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
using ns36;
using ns50;
using ns53;
using ns6;
using ns61;
using ns71;
using ns83;
using ns85;

namespace ns144;

public class FormXaphuCT : Form
{
	public static bool bool_0 = false;

	public static int int_0 = 0;

	private static int int_1 = -1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	private static string[] string_0 = null;

	private static int int_6 = 0;

	private IContainer icontainer_0 = null;

	private Label label19;

	private Button buttonXoaCongThanhQuan;

	private ComboBox comboBoxCongThanhQuan;

	private Button buttonLayCongThanhQuan;

	private ListView listViewXaphuCongthanh;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonTudongLayvitri;

	private Label label1;

	public FormXaphuCT()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		int_0 = -2;
		bool_0 = false;
	}

	private void FormXaphuCT_Load(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			Close();
			return;
		}
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
		for (int i = 0; i < Class6.cityTransportData_0.Length; i++)
		{
			method_0(Class6.cityTransportData_0[i]);
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
		if (0 <= int_1)
		{
			string text = Class6.cityTransportData_0[int_1].string_0;
			uint[] array = new uint[2]
			{
				Class6.cityTransportData_0[int_1].uint_0[0],
				Class6.cityTransportData_0[int_1].uint_0[1]
			};
			listViewXaphuCongthanh.Items[int_1].SubItems[1].Text = Class1.smethod_1(text, 1);
			listViewXaphuCongthanh.Items[int_1].SubItems[2].Text = (array[0] / 256).ToString() + "," + array[1] / 512;
			int_1 = -1;
		}
	}

	private void method_0(Class6.CityTransportData cityTransportData_0)
	{
		try
		{
			string text = "...";
			string text2 = "...";
			if (cityTransportData_0.uint_0 != null)
			{
				text = cityTransportData_0.uint_0[0] / 256 + "," + cityTransportData_0.uint_0[1] / 512;
			}
			if (cityTransportData_0.string_0 != null && cityTransportData_0.string_0 != string.Empty)
			{
				text2 = Class1.smethod_1(cityTransportData_0.string_0, 1);
			}
			string[] array = new string[4]
			{
				cityTransportData_0.string_2,
				text2,
				text,
				cityTransportData_0.int_0.ToString()
			};
			ListViewItem listViewItem = new ListViewItem(array[0]);
			for (int i = 1; i < array.Length; i++)
			{
				ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
				listViewItem.SubItems.Add(item);
			}
			listViewXaphuCongthanh.Items.Add(listViewItem);
		}
		catch
		{
		}
	}

	private void comboBoxCongThanhQuan_MouseDown(object sender, MouseEventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			return;
		}
		timer_0.Enabled = false;
		comboBoxCongThanhQuan.Items.Clear();
		string_0 = null;
		Class3.smethod_25(Form1.characterAccountConfig_1[num], ref string_0, 3);
		int_6 = Class39.smethod_0(Form1.characterAccountConfig_1[num]);
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				comboBoxCongThanhQuan.Items.Add(Class1.smethod_1(string_0[i], 1));
			}
		}
		timer_0.Enabled = true;
	}

	private void buttonLayCongThanhQuan_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			return;
		}
		int num2 = Class39.smethod_0(Form1.characterAccountConfig_1[num]);
		if (string_0 != null && num2 == int_6)
		{
			string text = null;
			string text2 = comboBoxCongThanhQuan.Text;
			for (int i = 0; i < string_0.Length; i++)
			{
				if (text2 == Class1.smethod_1(string_0[i], 1))
				{
					text = string_0[i];
					break;
				}
			}
			if (text == null)
			{
				return;
			}
			uint[] uint_ = null;
			int num3 = Class3.smethod_15(Form1.characterAccountConfig_1[num], text, ref uint_);
			if (num3 <= 0)
			{
				return;
			}
			bool flag = false;
			for (int j = 0; j < Class6.cityTransportData_0.Length; j++)
			{
				if (num2 == Class6.cityTransportData_0[j].int_0)
				{
					Class6.cityTransportData_0[j].string_0 = text;
					Class6.cityTransportData_0[j].uint_0 = new uint[2]
					{
						uint_[0],
						uint_[1]
					};
					listViewXaphuCongthanh.Items[j].SubItems[1].Text = Class1.smethod_1(text, 1);
					listViewXaphuCongthanh.Items[j].SubItems[2].Text = (uint_[0] / 256).ToString() + "," + uint_[1] / 512;
					flag = true;
					break;
				}
			}
			if (flag)
			{
				Class6.smethod_4();
			}
		}
		else
		{
			Class11.smethod_29(ref Class11.string_17, "Hãy chọn vị trí Xa phu công thành quan trước nhé.");
		}
	}

	private void buttonXoaCongThanhQuan_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < listViewXaphuCongthanh.Items.Count; i++)
		{
			if (listViewXaphuCongthanh.Items[i].Selected)
			{
				listViewXaphuCongthanh.Items[i].SubItems[1].Text = "...";
				listViewXaphuCongthanh.Items[i].SubItems[2].Text = "...";
				Class6.cityTransportData_0[i].string_0 = null;
				Class6.cityTransportData_0[i].uint_0 = null;
				Class6.smethod_4();
			}
		}
	}

	private void buttonTudongLayvitri_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num >= 0 && !Form1.characterAccountConfig_1[num].bool_0)
		{
			Form1.characterAccountConfig_1[num].bool_0 = true;
			new Thread(smethod_0).Start();
		}
	}

	private static void smethod_0()
	{
		int int_ = int_0;
		try
		{
			smethod_1(int_);
		}
		catch
		{
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (0 <= num)
		{
			Form1.characterAccountConfig_1[num].bool_0 = false;
		}
	}

	private static void smethod_1(int int_7)
	{
		int num = 0;
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		string[] array = new string[4] { "Xa Phu C«ng Thµnh", "Çu C«ng Thµnh ChiÕn", "ThÊt thµnh", "tiÕp dÉn" };
		uint[,] array2 = new uint[7, 3];
		Class10.smethod_4(array2, 31828);
		uint[,] array3 = array2;
		int num2 = 0;
		int int_8 = 0;
		int num3 = 0;
		uint[] array4 = new uint[2];
		int num4 = 0;
		long long_ = 0L;
		byte[] array5 = new byte[4];
		byte[] array6 = new byte[60];
		while (true)
		{
			Thread.Sleep(300);
			num = Class87.smethod_3(Form1.characterAccountConfig_1, int_7);
			if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25 || !Form1.characterAccountConfig_1[num].bool_0)
			{
				break;
			}
			characterAccountConfig = Form1.characterAccountConfig_1[num];
			if (array3.GetLength(0) > num2)
			{
				uint num5 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.int_137);
				uint num6 = Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig.int_137);
				uint num7 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig.int_137);
				uint num8 = num7 + num6 * Class56.memorySignatureScanConfig_15.uint_0;
				int num9 = (int)Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.int_137);
				int num10 = (int)Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig.int_137);
				int num11 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
				Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig.int_137);
				int num12 = Class89.smethod_39(characterAccountConfig);
				if (num10 == 0 || num9 == 0 || num11 == 0 || num12 <= 1)
				{
					continue;
				}
				uint[] uint_ = new uint[2]
				{
					Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
					Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
				};
				num4 = (int)array3[num2, 0];
				array4[0] = array3[num2, 1];
				array4[1] = array3[num2, 2];
				if (num11 != num4)
				{
					if (!Class29.smethod_7(characterAccountConfig, num4, null, array4))
					{
						Class53.smethod_5(characterAccountConfig, num4);
					}
					num3 = 0;
					continue;
				}
				long num13 = Class64.smethod_18(uint_, array4);
				if (num13 <= 640000L)
				{
					Class13.smethod_2(characterAccountConfig, bool_0: false);
					if (num13 > 160000L)
					{
						Class75.smethod_61(characterAccountConfig, array4);
						Thread.Sleep(150);
						continue;
					}
					uint uint_2 = characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
					Class24.ReadProcessMemory(characterAccountConfig.int_137, uint_2, array5, 4, ref int_8);
					int num14 = BitConverter.ToInt32(array5, 0);
					if (num14 > 1)
					{
						string text = null;
						long num15 = 0L;
						uint[] array7 = new uint[2];
						int num16 = 0;
						for (uint num17 = 1u; num17 < 256; num17++)
						{
							if (num14 <= num16)
							{
								break;
							}
							if (num17 != num6)
							{
								uint num18 = num7 + num17 * Class56.memorySignatureScanConfig_15.uint_0;
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_16.uint_0, array5, 4, ref int_8);
								if (array5[0] == 0)
								{
									continue;
								}
								num16++;
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_50.uint_0, array5, 4, ref int_8);
								if (BitConverter.ToInt32(array5, 0) <= 0)
								{
									continue;
								}
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_52.uint_0, array5, 4, ref int_8);
								uint num19 = BitConverter.ToUInt32(array5, 0);
								if (num19 != 3)
								{
									continue;
								}
								uint[] array8 = new uint[2];
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array5, 4, ref int_8);
								array8[0] = BitConverter.ToUInt32(array5, 0);
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array5, 4, ref int_8);
								array8[1] = BitConverter.ToUInt32(array5, 0);
								Class24.ReadProcessMemory(characterAccountConfig.int_137, num18 + Class56.memorySignatureScanConfig_16.uint_0, array6, array6.Length, ref int_8);
								string text2 = Class1.smethod_3(array6);
								string string_ = text2.ToLower();
								bool flag = false;
								for (int i = 0; i < array.Length; i++)
								{
									if (0 <= Class11.smethod_1(string_, array[i].ToLower()))
									{
										flag = true;
										break;
									}
								}
								if (flag)
								{
									array7[0] = array8[0];
									array7[1] = array8[1];
									text = text2;
									break;
								}
								long num20 = Class64.smethod_18(array4, array8);
								if (num20 < 160000L && (text == null || num20 < num15))
								{
									num15 = num20;
									array7[0] = array8[0];
									array7[1] = array8[1];
									text = text2;
								}
							}
							else
							{
								num16++;
							}
						}
						if (text == null)
						{
							continue;
						}
						for (int j = 0; j < Class6.cityTransportData_0.Length; j++)
						{
							if (num11 == Class6.cityTransportData_0[j].int_0)
							{
								Class6.cityTransportData_0[j].string_0 = text;
								Class6.cityTransportData_0[j].uint_0 = new uint[2]
								{
									array7[0],
									array7[1]
								};
								Class6.smethod_4();
								int_1 = j;
								break;
							}
						}
						num2++;
						num3 = 0;
					}
					else
					{
						num3++;
						if (num3 > 10)
						{
							Class64.smethod_12(characterAccountConfig);
							num3 = 0;
						}
						Thread.Sleep(300);
					}
				}
				else if (Class11.smethod_28(long_) > 6000L)
				{
					Class13.smethod_1(characterAccountConfig, array4);
					long_ = Class11.smethod_27();
				}
				continue;
			}
			Form1.characterAccountConfig_1[num].bool_0 = false;
			Class75.smethod_52(characterAccountConfig, "<color=yellow>DA LAY XONG TAT CA VI TRI");
			break;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns144.FormXaphuCT));
		this.label19 = new System.Windows.Forms.Label();
		this.buttonXoaCongThanhQuan = new System.Windows.Forms.Button();
		this.comboBoxCongThanhQuan = new System.Windows.Forms.ComboBox();
		this.buttonLayCongThanhQuan = new System.Windows.Forms.Button();
		this.listViewXaphuCongthanh = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonTudongLayvitri = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.label19.ForeColor = System.Drawing.Color.Black;
		this.label19.Location = new System.Drawing.Point(3, 254);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(416, 46);
		this.label19.TabIndex = 234;
		this.label19.Text = resources.GetString("label19.Text");
		this.buttonXoaCongThanhQuan.Location = new System.Drawing.Point(205, 209);
		this.buttonXoaCongThanhQuan.Name = "buttonXoaCongThanhQuan";
		this.buttonXoaCongThanhQuan.Size = new System.Drawing.Size(74, 36);
		this.buttonXoaCongThanhQuan.TabIndex = 238;
		this.buttonXoaCongThanhQuan.Text = "Xóa, bỏ qua";
		this.buttonXoaCongThanhQuan.UseVisualStyleBackColor = true;
		this.buttonXoaCongThanhQuan.Click += new System.EventHandler(buttonXoaCongThanhQuan_Click);
		this.comboBoxCongThanhQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxCongThanhQuan.FormattingEnabled = true;
		this.comboBoxCongThanhQuan.Location = new System.Drawing.Point(4, 190);
		this.comboBoxCongThanhQuan.Name = "comboBoxCongThanhQuan";
		this.comboBoxCongThanhQuan.Size = new System.Drawing.Size(195, 21);
		this.comboBoxCongThanhQuan.TabIndex = 236;
		this.comboBoxCongThanhQuan.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxCongThanhQuan_MouseDown);
		this.buttonLayCongThanhQuan.Location = new System.Drawing.Point(4, 217);
		this.buttonLayCongThanhQuan.Name = "buttonLayCongThanhQuan";
		this.buttonLayCongThanhQuan.Size = new System.Drawing.Size(195, 28);
		this.buttonLayCongThanhQuan.TabIndex = 237;
		this.buttonLayCongThanhQuan.Text = "Lấy";
		this.buttonLayCongThanhQuan.UseVisualStyleBackColor = true;
		this.buttonLayCongThanhQuan.Click += new System.EventHandler(buttonLayCongThanhQuan_Click);
		this.listViewXaphuCongthanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listViewXaphuCongthanh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2, this.columnHeader_3 });
		this.listViewXaphuCongthanh.FullRowSelect = true;
		this.listViewXaphuCongthanh.GridLines = true;
		this.listViewXaphuCongthanh.HideSelection = false;
		this.listViewXaphuCongthanh.Location = new System.Drawing.Point(4, 35);
		this.listViewXaphuCongthanh.Name = "listViewXaphuCongthanh";
		this.listViewXaphuCongthanh.Size = new System.Drawing.Size(415, 149);
		this.listViewXaphuCongthanh.TabIndex = 235;
		this.listViewXaphuCongthanh.UseCompatibleStateImageBehavior = false;
		this.listViewXaphuCongthanh.View = System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "Thành";
		this.columnHeader_0.Width = 85;
		this.columnHeader_1.Text = "Xa phu CTQ";
		this.columnHeader_1.Width = 180;
		this.columnHeader_2.Text = "Vị trí";
		this.columnHeader_2.Width = 100;
		this.columnHeader_3.Text = "ID";
		this.columnHeader_3.Width = 30;
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonTudongLayvitri.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonTudongLayvitri.Location = new System.Drawing.Point(285, 209);
		this.buttonTudongLayvitri.Name = "buttonTudongLayvitri";
		this.buttonTudongLayvitri.Size = new System.Drawing.Size(134, 36);
		this.buttonTudongLayvitri.TabIndex = 240;
		this.buttonTudongLayvitri.Text = "Tự động chạy lấy vị trí xa phu vào CTC";
		this.buttonTudongLayvitri.UseVisualStyleBackColor = true;
		this.buttonTudongLayvitri.Click += new System.EventHandler(buttonTudongLayvitri_Click);
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(3, 2);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(416, 28);
		this.label1.TabIndex = 241;
		this.label1.Text = "Bạn phải lấy hết vị trí xa phu vào CTC của 7 thành thì auto mới vào được chiến trường CTC bằng xa phu.";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(426, 304);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.buttonLayCongThanhQuan);
		base.Controls.Add(this.comboBoxCongThanhQuan);
		base.Controls.Add(this.buttonTudongLayvitri);
		base.Controls.Add(this.label19);
		base.Controls.Add(this.buttonXoaCongThanhQuan);
		base.Controls.Add(this.listViewXaphuCongthanh);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormXaphuCT";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "XA PHU CONG THANH QUAN";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormXaphuCT_Load);
		base.ResumeLayout(false);
	}
}
