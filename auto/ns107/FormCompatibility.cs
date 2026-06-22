using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns23;
using ns53;
using ns63;
using ns67;
using ns85;

namespace ns107;

public class FormCompatibility : Form
{
	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonClose;

	private Button buttonFix;

	private TextBox textBoxPhienBan;

	private RichTextBox richTextBox1;

	private Button buttonDefender;

	private TextBox textBoxThongso;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private Label label3;

	private Label label2;

	private TabPage tabPage2;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private Button buttonOpen;

	private Button buttonXoa;

	private Button buttonReFresh;

	private TextBox textBoxItem;

	private Button buttonXoahet;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	public static string[] string_0 = null;

	public static string string_1 = "ᓹᓵᓬᓺᓽᓧᓸᓫᔂᓽᔕᔝᓜᓚᓙᓘᓴᔕᔊᔋᔂᓳᔏᔉᔘᔕᔙᔕᔌᔚᔂᓽᔏᔔᔊᔕᔝᔙᔂᓩᔛᔘᔘᔋᔔᔚᓼᔋᔘᔙᔏᔕᔔᔂᓸᔛᔔᓵᔔᔉᔋ";

	public static string string_2 = "ᔃᔟᔖᔤᔧᔑᔢᔕᔌᓽᔙᔓᔢᔟᔣᔟᔖᔤᔌᔇᔙᔞᔔᔟᔧᔣᔌᓳᔥᔢᔢᔕᔞᔤᔆᔕᔢᔣᔙᔟᔞᔌᔀᔟᔜᔙᔓᔙᔕᔣᔌᓵᔨᔠᔜᔟᔢᔕᔢᔌᓴᔙᔣᔑᔜᔜᔟᔧᔂᔥᔞ";

	private static string string_3 = null;

	public FormCompatibility()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns107.FormCompatibility));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonClose = new System.Windows.Forms.Button();
		this.buttonFix = new System.Windows.Forms.Button();
		this.textBoxPhienBan = new System.Windows.Forms.TextBox();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.buttonDefender = new System.Windows.Forms.Button();
		this.textBoxThongso = new System.Windows.Forms.TextBox();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.label3 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.buttonXoahet = new System.Windows.Forms.Button();
		this.textBoxItem = new System.Windows.Forms.TextBox();
		this.buttonReFresh = new System.Windows.Forms.Button();
		this.buttonOpen = new System.Windows.Forms.Button();
		this.buttonXoa = new System.Windows.Forms.Button();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.tabPage2.SuspendLayout();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonClose.BackColor = System.Drawing.SystemColors.Control;
		this.buttonClose.Location = new System.Drawing.Point(302, 173);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(59, 38);
		this.buttonClose.TabIndex = 14;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = false;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.buttonFix.BackColor = System.Drawing.SystemColors.Control;
		this.buttonFix.Location = new System.Drawing.Point(6, 173);
		this.buttonFix.Name = "buttonFix";
		this.buttonFix.Size = new System.Drawing.Size(155, 38);
		this.buttonFix.TabIndex = 17;
		this.buttonFix.Text = "Chuyển game sang chế độ 16-bit Windows 8, 10";
		this.buttonFix.UseVisualStyleBackColor = false;
		this.buttonFix.Click += new System.EventHandler(buttonFix_Click);
		this.textBoxPhienBan.BackColor = System.Drawing.SystemColors.Control;
		this.textBoxPhienBan.Location = new System.Drawing.Point(124, 27);
		this.textBoxPhienBan.Name = "textBoxPhienBan";
		this.textBoxPhienBan.ReadOnly = true;
		this.textBoxPhienBan.Size = new System.Drawing.Size(237, 20);
		this.textBoxPhienBan.TabIndex = 18;
		this.richTextBox1.Location = new System.Drawing.Point(6, 54);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.Size = new System.Drawing.Size(355, 103);
		this.richTextBox1.TabIndex = 20;
		this.richTextBox1.Text = "";
		this.buttonDefender.BackColor = System.Drawing.SystemColors.Control;
		this.buttonDefender.Location = new System.Drawing.Point(167, 173);
		this.buttonDefender.Name = "buttonDefender";
		this.buttonDefender.Size = new System.Drawing.Size(129, 38);
		this.buttonDefender.TabIndex = 23;
		this.buttonDefender.Text = "Tắt Defender trên Windows 8 và 10";
		this.buttonDefender.UseVisualStyleBackColor = false;
		this.buttonDefender.Click += new System.EventHandler(buttonDefender_Click);
		this.textBoxThongso.BackColor = System.Drawing.SystemColors.Control;
		this.textBoxThongso.Location = new System.Drawing.Point(124, 4);
		this.textBoxThongso.Name = "textBoxThongso";
		this.textBoxThongso.ReadOnly = true;
		this.textBoxThongso.Size = new System.Drawing.Size(237, 20);
		this.textBoxThongso.TabIndex = 25;
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Location = new System.Drawing.Point(0, 0);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(375, 246);
		this.tabControl1.TabIndex = 31;
		this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
		this.tabPage1.Controls.Add(this.buttonDefender);
		this.tabPage1.Controls.Add(this.label3);
		this.tabPage1.Controls.Add(this.buttonFix);
		this.tabPage1.Controls.Add(this.buttonClose);
		this.tabPage1.Controls.Add(this.richTextBox1);
		this.tabPage1.Controls.Add(this.label2);
		this.tabPage1.Controls.Add(this.textBoxThongso);
		this.tabPage1.Controls.Add(this.textBoxPhienBan);
		this.tabPage1.Location = new System.Drawing.Point(4, 22);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(367, 220);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Sửa lỗi cash, diss game";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(3, 30);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(102, 13);
		this.label3.TabIndex = 32;
		this.label3.Text = "Phiên bản Windows";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(4, 5);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(96, 13);
		this.label2.TabIndex = 31;
		this.label2.Text = "Thông số máy tính";
		this.tabPage2.Controls.Add(this.buttonXoahet);
		this.tabPage2.Controls.Add(this.textBoxItem);
		this.tabPage2.Controls.Add(this.buttonReFresh);
		this.tabPage2.Controls.Add(this.buttonOpen);
		this.tabPage2.Controls.Add(this.buttonXoa);
		this.tabPage2.Controls.Add(this.listView1);
		this.tabPage2.Location = new System.Drawing.Point(4, 22);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(367, 220);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "Các khởi động cùng Windows";
		this.tabPage2.UseVisualStyleBackColor = true;
		this.buttonXoahet.Location = new System.Drawing.Point(79, 192);
		this.buttonXoahet.Name = "buttonXoahet";
		this.buttonXoahet.Size = new System.Drawing.Size(70, 26);
		this.buttonXoahet.TabIndex = 21;
		this.buttonXoahet.Text = "Xóa hết";
		this.buttonXoahet.UseVisualStyleBackColor = true;
		this.buttonXoahet.Click += new System.EventHandler(buttonXoahet_Click);
		this.textBoxItem.BackColor = System.Drawing.Color.LightGray;
		this.textBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxItem.Font = new System.Drawing.Font("Candara", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxItem.Location = new System.Drawing.Point(2, 160);
		this.textBoxItem.Multiline = true;
		this.textBoxItem.Name = "textBoxItem";
		this.textBoxItem.Size = new System.Drawing.Size(362, 26);
		this.textBoxItem.TabIndex = 15;
		this.textBoxItem.Text = "...";
		this.buttonReFresh.Location = new System.Drawing.Point(280, 192);
		this.buttonReFresh.Name = "buttonReFresh";
		this.buttonReFresh.Size = new System.Drawing.Size(87, 26);
		this.buttonReFresh.TabIndex = 14;
		this.buttonReFresh.Text = "ReFresh";
		this.buttonReFresh.UseVisualStyleBackColor = true;
		this.buttonReFresh.Click += new System.EventHandler(buttonReFresh_Click);
		this.buttonOpen.Location = new System.Drawing.Point(170, 192);
		this.buttonOpen.Name = "buttonOpen";
		this.buttonOpen.Size = new System.Drawing.Size(104, 26);
		this.buttonOpen.TabIndex = 13;
		this.buttonOpen.Text = "Mở đường dẫn";
		this.buttonOpen.UseVisualStyleBackColor = true;
		this.buttonOpen.Click += new System.EventHandler(buttonOpen_Click);
		this.buttonXoa.Location = new System.Drawing.Point(3, 192);
		this.buttonXoa.Name = "buttonXoa";
		this.buttonXoa.Size = new System.Drawing.Size(70, 26);
		this.buttonXoa.TabIndex = 12;
		this.buttonXoa.Text = "Xóa";
		this.buttonXoa.UseVisualStyleBackColor = true;
		this.buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(0, 0);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(367, 158);
		this.listView1.TabIndex = 11;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		this.columnHeader_0.Text = "No";
		this.columnHeader_0.Width = 25;
		this.columnHeader_1.Text = "Tên";
		this.columnHeader_1.Width = 100;
		this.columnHeader_2.Text = "Đường dẫn";
		this.columnHeader_2.Width = 220;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.LightSteelBlue;
		base.ClientSize = new System.Drawing.Size(377, 245);
		base.Controls.Add(this.tabControl1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormCompatibility";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "FIX CASH DISS GAME";
		base.Load += new System.EventHandler(FormCompatibility_Load);
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage1.PerformLayout();
		this.tabPage2.ResumeLayout(false);
		this.tabPage2.PerformLayout();
		base.ResumeLayout(false);
	}

	public static string[] smethod_0()
	{
		try
		{
			return smethod_1();
		}
		catch
		{
		}
		return null;
	}

	private static string[] smethod_1()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string[] array = new string[2]
		{
			string.Empty,
			string.Empty
		};
		bool flag;
		if (!(flag = oSVersion.Platform != PlatformID.Win32Windows))
		{
			switch (version.Minor)
			{
			case 90:
				array[0] = "ME";
				break;
			case 10:
				if (!(flag = !(version.Revision.ToString() == "2222A")))
				{
					array[0] = "98SE";
				}
				else
				{
					array[0] = "98";
				}
				break;
			case 0:
				array[0] = "95";
				break;
			}
		}
		else if (!(flag = oSVersion.Platform != PlatformID.Win32NT))
		{
			switch (version.Major)
			{
			case 3:
				array[0] = "NT3.51";
				break;
			case 4:
				array[0] = "NT4.0";
				break;
			case 5:
				if (!(flag = version.Minor != 0))
				{
					array[0] = "2000";
				}
				else
				{
					array[0] = "XP";
				}
				break;
			case 6:
				flag = version.Minor != 0;
				goto default;
			default:
				if (!flag)
				{
					array[0] = "VISTA";
				}
				else if (!(flag = version.Minor != 1))
				{
					array[0] = "7";
				}
				else if (!(flag = version.Minor != 2))
				{
					array[0] = "8";
				}
				else
				{
					array[0] = "8.1";
				}
				break;
			case 10:
				array[0] = "10";
				break;
			case 7:
			case 8:
			case 9:
				break;
			}
		}
		if (!(flag = !(array[0] != string.Empty)))
		{
			array[1] = "Windows " + array[0];
			if (!(flag = !(oSVersion.ServicePack != "")))
			{
				string[] array2;
				(array2 = array)[1] = array2[1] + " " + oSVersion.ServicePack;
			}
		}
		return array;
	}

	public static bool smethod_2(string[] string_4)
	{
		return string_4 != null && string_4[0] != "10" && string_4[0] != "8.1" && string_4[0] != "8" && string_4[0] != "7" && string_4[0] != "VISTA";
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
	}

	private void FormCompatibility_Load(object sender, EventArgs e)
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
		try
		{
			string_0 = smethod_0();
		}
		catch
		{
		}
		if (string_0 != null && string_0[0] != string.Empty)
		{
			textBoxPhienBan.Text = string_0[1];
		}
		else
		{
			textBoxPhienBan.Text = "Không xác định";
		}
		int int_ = 0;
		byte[] array = new byte[2];
		Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_1 * 4, array, 2, ref int_);
		textBoxThongso.Text = "[ " + array[0] + "." + array[1] + " ]";
		if (Form1.characterAccountConfig_1 != null)
		{
			byte[] array2 = new byte[4];
			string text = string.Empty;
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Class24.ReadProcessMemory(Form1.characterAccountConfig_1[i].int_137, Form1.characterAccountConfig_1[i].uint_21 + Class70.uint_0, array2, 4, ref int_);
				int num3 = BitConverter.ToInt32(array2, 0);
				Class24.ReadProcessMemory(Form1.characterAccountConfig_1[i].int_137, Form1.characterAccountConfig_1[i].uint_21, array2, 4, ref int_);
				int num4 = BitConverter.ToInt32(array2, 0);
				if (num3 > 0)
				{
					if (text != null && text != string.Empty)
					{
						text += Class56.string_7;
					}
					object obj2 = text;
					text = string.Concat(obj2, Class11.smethod_46(Form1.characterAccountConfig_1[i].uint_21, 8, bool_1: false, bool_2: true), ": ", Class1.smethod_1(Form1.characterAccountConfig_1[i].string_22, 1), " có tổng ", num3, " lỗi game, ", num4, " lần fix.");
				}
				Class89.smethod_40(Form1.characterAccountConfig_1[i]);
			}
			if (text != null && text != string.Empty)
			{
				richTextBox1.Text = text;
			}
		}
		method_0();
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void method_0()
	{
		listView1.Items.Clear();
		string[] array = null;
		string[] array2 = null;
		string string_ = "ᓌᓤᓬᒫᒩᒨᒧᓃᓤᓙᓚᓑ";
		string string_2 = "ᒼᓛᓐᓒ";
		string text = Class11.smethod_54(string_1);
		string[] array3 = new string[4]
		{
			text.Replace(Class11.smethod_54(string_2), ""),
			text,
			text.Replace(Class11.smethod_54(string_), "").Replace(Class11.smethod_54(string_2), ""),
			text.Replace(Class11.smethod_54(string_), "")
		};
		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < array3.Length; j++)
			{
				string[] array4 = Class66.smethod_10(array3[j], i > 0, bool_1: true);
				if (array4 == null)
				{
					continue;
				}
				for (int k = 0; k < array4.Length; k++)
				{
					if (array2 == null)
					{
						array2 = new string[1];
					}
					else
					{
						Array.Resize(ref array2, array2.Length + 1);
					}
					array2[array2.Length - 1] = array4[k];
				}
			}
		}
		if (FormCompatibility.string_3 == null || FormCompatibility.string_3 == string.Empty)
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			Class24.SHGetSpecialFolderPath(IntPtr.Zero, stringBuilder, 22, bool_0: false);
			FormCompatibility.string_3 = stringBuilder.ToString();
		}
		if (FormCompatibility.string_3 != null && FormCompatibility.string_3 != string.Empty)
		{
			array = Directory.GetFiles(FormCompatibility.string_3 + "\\Programs\\Startup", "*.*");
		}
		Color foreColor = Color.Black;
		if (array != null && array.Length != 0)
		{
			for (int l = 0; l < array.Length; l++)
			{
				string[] array5 = array[l].Split('\\');
				string[] string_3 = new string[2]
				{
					array5[array5.Length - 1],
					array[l]
				};
				method_1(string_3);
			}
			foreColor = Color.DarkBlue;
		}
		if (array2 != null && array2.Length != 0)
		{
			for (int m = 0; m < array2.Length; m++)
			{
				string[] array6 = array2[m].Split('\\');
				string[] string_4 = new string[2]
				{
					array6[array6.Length - 1],
					array2[m]
				};
				method_1(string_4);
				listView1.Items[listView1.Items.Count - 1].ForeColor = foreColor;
			}
		}
	}

	private void method_1(string[] string_4)
	{
		try
		{
			ListViewItem listViewItem = new ListViewItem((listView1.Items.Count + 1).ToString());
			for (int i = 0; i < string_4.Length; i++)
			{
				listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, string_4[i]));
			}
			listView1.Items.Add(listViewItem);
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
		Close();
	}

	private static void smethod_3(string string_4, string string_5, bool bool_1 = true)
	{
		try
		{
			string text = "Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers";
			if (!bool_1)
			{
				Class66.smethod_13(text, string_4, 0);
				Class66.smethod_13(text, string_4, 1);
			}
			else
			{
				Class66.smethod_11(text, string_4, string_5, "", 0);
				Class66.smethod_11(text, string_4, string_5, "", 1);
			}
		}
		catch
		{
		}
	}

	private void buttonFix_Click(object sender, EventArgs e)
	{
		string string_ = string.Empty;
		if (string_0 != null && string_0[0] != string.Empty && (string_0[0] == "10" || string_0[0] == "8.1" || string_0[0] == "8"))
		{
			string_ = "16BITCOLOR";
		}
		string text = null;
		int[] array = Class24.smethod_24(Class56.string_21);
		if (array != null && array.Length != 0)
		{
			for (int i = 0; i < array.Length; i++)
			{
				try
				{
					Process processById = Process.GetProcessById(array[i]);
					text = processById.MainModule.FileName;
					string text2 = Class66.smethod_7("PathGame", 0);
					if (text != null && text != string.Empty)
					{
						if (text2 != text)
						{
							Class66.smethod_11(Class66.smethod_1(), "PathGame", text, "", 0);
							Class24.smethod_71(text, bool_0: false);
						}
						break;
					}
				}
				catch
				{
				}
			}
		}
		if (text == null || text == string.Empty)
		{
			text = Class66.smethod_7("PathGame", 0);
			if (text == null || text == string.Empty || !Class11.smethod_17(text))
			{
				richTextBox1.Text = "Hãy mở 1 cửa sổ game lên trước khi bấm nút Fix này.";
				return;
			}
		}
		smethod_3(text, string_);
		string[] array2 = Class11.smethod_14(text);
		string string_2 = array2[0] + "\\config.ini";
		if (Class11.smethod_17(string_2))
		{
			string text3 = Class11.smethod_33(string_2, 0, 0, 1);
			string[] array3 = text3.Split('\r', '\n');
			string text4 = string.Empty;
			for (int j = 0; j < array3.Length; j++)
			{
				if (array3[j].ToLower().IndexOf("epresent") > 0)
				{
					text4 = array3[j];
					break;
				}
			}
			text3 = ((!(text4 != string.Empty)) ? Class11.smethod_72("NYoxC8IwFAb392skolum1LoIBkNxKB0e5cME0md4Rqn/3nRwuztuDNAPdKIzL9jYP7Xaw9EY6iCJ89/3RKPLCVIncizXAhk03yPktKZqd9S/cw6zAtLkhqJ4tdka6n1opfsKL2m+pEfcbsfFc432Bw==") : text3.Replace(text4, "Represent=2"));
			Class11.smethod_34(string_2, text3, 1);
		}
		richTextBox1.Text = "Đã chuyển game sang chạy ở chế độ 16bit";
	}

	private void buttonDefender_Click(object sender, EventArgs e)
	{
		string text = "SOFTWARE\\Policies\\Microsoft\\Windows Defender";
		Class66.smethod_11(text, "DisableAntiSpyware", 1, "DWORD", 0);
		Class66.smethod_11(text, "DisableAntiSpyware", 1, "DWORD", 1);
		richTextBox1.Text = "Đã tắt Windows Denfender, khởi động lại máy tính mới có hiệu lực. Nếu muốn khôi phục thì xóa nhánh sau trong registry:" + Class56.string_7 + text;
	}

	private static int smethod_4(string string_4, int int_4)
	{
		ServiceController serviceController = new ServiceController(string_4);
		try
		{
			TimeSpan timeout = TimeSpan.FromMilliseconds(int_4);
			string text = serviceController.Status.ToString().ToUpper();
			if (text.IndexOf("STOP") < 0)
			{
				serviceController.Stop();
				serviceController.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
			}
			return 1;
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_5()
	{
		try
		{
			if (string_0 == null)
			{
				string_0 = smethod_0();
			}
		}
		catch
		{
		}
		try
		{
			Process process = new Process();
			process.StartInfo.Arguments = "Firewall set opmode disable";
			process.StartInfo.FileName = "netsh.exe";
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.WaitForExit();
		}
		catch
		{
		}
		if (string_0 != null && !(string_0[0] == string.Empty))
		{
			if (!(string_0[0] == "7") && !(string_0[0] == "VISTA"))
			{
				if (string_0[0] != "10" && string_0[0] != "8.1" && string_0[0] != "8")
				{
					return smethod_4("ShareAccess", 10000);
				}
				return 0;
			}
			return smethod_4("MpsSvc", 10000);
		}
		smethod_4("MpsSvc", 10000);
		return smethod_4("ShareAccess", 10000);
	}

	private void method_2(string string_4, string string_5)
	{
		if (string_4 == null || string_4 == string.Empty)
		{
			return;
		}
		if (string_4[1] != ':')
		{
			string[] array = Class11.smethod_14(string_4);
			Class66.smethod_13(array[0], array[1], 3);
			return;
		}
		string processName = string_5.ToUpper().Replace(".EXE", "");
		Process[] processesByName = Process.GetProcessesByName(processName);
		if (processesByName != null && processesByName.Length != 0)
		{
			for (int i = 0; i < processesByName.Length; i++)
			{
				Class24.smethod_53(processesByName[i]);
			}
			Thread.Sleep(600);
		}
		Class11.smethod_20(string_4);
		Class11.smethod_17(string_4);
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		if (listView1.SelectedIndices.Count != 0)
		{
			int index = listView1.SelectedIndices[0];
			string string_ = listView1.Items[index].SubItems[2].Text;
			string string_2 = listView1.Items[index].SubItems[1].Text;
			listView1.Items.RemoveAt(index);
			method_2(string_, string_2);
		}
	}

	private void buttonOpen_Click(object sender, EventArgs e)
	{
		if (listView1.SelectedIndices.Count == 0)
		{
			return;
		}
		int index = listView1.SelectedIndices[0];
		string text = listView1.Items[index].SubItems[2].Text;
		if (text != null && !(text == string.Empty))
		{
			string[] array = Class11.smethod_14(text);
			if (text[1] == ':')
			{
				Class24.smethod_40("explorer.exe", "", array[0], 0);
			}
			else if (array.Length > 1)
			{
				Class66.smethod_15(array[0]);
			}
		}
	}

	private void buttonReFresh_Click(object sender, EventArgs e)
	{
		method_0();
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView1.SelectedIndices.Count != 0)
		{
			textBoxItem.Text = listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text;
		}
	}

	private void buttonXoahet_Click(object sender, EventArgs e)
	{
		if (listView1.Items == null || listView1.Items.Count == 0)
		{
			return;
		}
		string text = "Bạn chắc chắn muốn xóa hết tất cả ?";
		if (MessageBox.Show(text, Form1.string_49, MessageBoxButtons.YesNo) != DialogResult.No)
		{
			string[] array = new string[listView1.Items.Count];
			string[] array2 = new string[listView1.Items.Count];
			for (int i = 0; i < listView1.Items.Count; i++)
			{
				array[i] = listView1.Items[i].SubItems[2].Text;
				array2[i] = listView1.Items[i].SubItems[1].Text;
			}
			listView1.Items.Clear();
			for (int j = 0; j < array.Length; j++)
			{
				method_2(array[j], array2[j]);
			}
		}
	}
}
