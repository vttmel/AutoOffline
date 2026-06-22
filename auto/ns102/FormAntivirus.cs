using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ns100;
using ns107;
using ns11;
using ns146;
using ns23;
using ns53;
using ns63;
using ns97;

namespace ns102;

public class FormAntivirus : Form
{
	public struct GStruct55
	{
		public Process process_0;

		public int int_0;

		public string string_0;
	}

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static bool bool_2 = false;

	public static GStruct55[] gstruct55_0 = null;

	private bool bool_3 = false;

	private string[] string_0 = new string[3] { "ᒺᓡ㌓ᓦᒒᖃ㍋ᓠᓙ", "ᓆ㌓ᓟᒒᓠᓙᘢᓠᓙ", "ᖁᕔᒑᓥᓙᓠᕒᓥ" };

	private static int int_0 = 0;

	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private Label label1;

	private Button buttonTieudiet;

	private Button buttonClose;

	private Label label2;

	private LinkLabel linkLabelTaiBKAV;

	private TextBox textBox1;

	private ColumnHeader columnHeader_2;

	private Button buttonMothumuc;

	private RichTextBox richTextBox1;

	private CheckBox checkBoxKhongHienCanhbao;

	public FormAntivirus()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	private static void smethod_0()
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		do
		{
			if (Class11.bool_0)
			{
				return;
			}
			num2 = DateTime.Now.Ticks;
			if (num == 0L)
			{
				num = num2;
			}
			else
			{
				num3 = num2 - num;
				num = num2;
				if (num4 < num3)
				{
					num4 = num3;
				}
			}
			Thread.Sleep(10);
		}
		while (!GClass1.bool_0 || num4 == 0L || Class11.uint_1 == 0 || Class11.int_1 <= 0);
		int int_ = 0;
		byte[] byte_ = new byte[2] { 1, 1 };
		Class24.WriteProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_1 * 4, byte_, 2, ref int_);
	}

	private static void smethod_1()
	{
		string string_ = "ᓛᓷᓮᓼᓿᓩᓺᓭᓤᓕᓱᓫᓺᓷᓻᓷᓮᓼᓤᓞᓱᓻᓽᓩᓴᓛᓼᓽᓬᓱᓷ";
		string string_2 = "ᓇᓩᓦᓡᓜᓚᓫᓄᓉᓌᓃᓠᓪᓫ";
		string string_3 = "ᓇᓜᓮᓯᓇᓪᓜᓟᓠᓟᓎᓪᓧᓰᓯᓤᓪᓩ";
		string text = Class11.smethod_54(string_);
		string[] array = Class66.smethod_10(text, bool_0: true, bool_1: false, 1);
		if (array == null || array.Length == 0)
		{
			return;
		}
		string[] array2 = new string[2] { "ᓜᓕᓛᓕᓟᓨᓕ", "ᓚᓨᓛᓕᓟᓨᓕ" };
		string[] array3 = null;
		for (int i = 0; i < array.Length; i++)
		{
			string text2 = text + "\\" + array[i];
			string text3 = Class66.smethod_8(text2, Class11.smethod_54(string_3), 1);
			string string_4 = text2 + "\\" + Class11.smethod_54(string_2);
			string[] array4 = Class66.smethod_10(string_4, bool_0: true);
			if (array4 == null || array4.Length == 0)
			{
				continue;
			}
			string empty = string.Empty;
			string empty2 = string.Empty;
			for (int j = 0; j < array4.Length; j++)
			{
				if (text3 != null && text3 != string.Empty)
				{
					empty = text3;
					text3 = null;
					j = -1;
				}
				else
				{
					empty = Class66.smethod_8(string_4, array4[j], 1);
				}
				empty2 = empty.ToLower();
				for (int k = 0; k < array2.Length; k++)
				{
					if (0 <= empty2.IndexOf(Class11.smethod_54(array2[k])))
					{
						if (array3 != null)
						{
							Array.Resize(ref array3, array3.Length + 1);
						}
						else
						{
							array3 = new string[1];
						}
						array3[array3.Length - 1] = empty.Split('|')[0];
					}
				}
			}
		}
		if (array3 != null && array3.Length != 0)
		{
			switch (Class11.smethod_6(Environment.MachineName.ToLower()))
			{
			}
		}
	}

	private static void smethod_2()
	{
		for (int i = 0; Form1.string_43.GetLength(0) > i; i++)
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName(Form1.string_43[i, 0]);
				if (processesByName == null || processesByName.Length == 0)
				{
					continue;
				}
				if (Form1.string_43[i, 1] != null && !(Form1.string_43[i, 1] == string.Empty))
				{
					string text = Form1.string_43[i, 1].ToLower();
					for (int j = 0; j < processesByName.Length; j++)
					{
						string text2 = string.Empty;
						try
						{
							uint uint_ = 256u;
							StringBuilder stringBuilder = new StringBuilder(256);
							text2 = ((Class24.QueryFullProcessImageName(processesByName[j].Handle, 0u, stringBuilder, out uint_) == 0) ? processesByName[j].MainModule.FileName : stringBuilder.ToString());
						}
						catch
						{
						}
						if (text2 != null && !(text2 == string.Empty))
						{
							string[] array = Class11.smethod_14(text2);
							if (array[0].ToLower() == text)
							{
								Class24.smethod_43(processesByName[j]);
							}
						}
					}
				}
				else
				{
					for (int k = 0; k < processesByName.Length; k++)
					{
						Class24.smethod_43(processesByName[k]);
					}
				}
			}
			catch
			{
			}
		}
	}

	public static void smethod_3()
	{
		new Thread(smethod_0).Start();
		int num = 0;
		int num2 = 0;
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_0(Class56.char_0));
		if (environmentVariable == null || environmentVariable == string.Empty)
		{
			return;
		}
		Process[] array = null;
		string[,] array2 = new string[3, 2]
		{
			{ "ZXhwbG9yZXI=", environmentVariable },
			{ "c3ZjaG9zdA==", null },
			{ "c3Bvb2xzdg==", null }
		};
		string string_ = Class11.smethod_54(FormCompatibility.string_2);
		string value = "AutoVolam".ToLower();
		while (true)
		{
			num--;
			num2--;
			Thread.Sleep(1200);
			if (Class11.bool_0)
			{
				break;
			}
			if (num2 <= 0)
			{
				for (byte b = 0; b <= 1; b++)
				{
					string[] array3 = Class66.smethod_10(string_, b > 0);
					if (array3 != null && array3.Length != 0)
					{
						for (int i = 0; i < array3.Length; i++)
						{
							string text = Class66.smethod_8(string_, array3[i], 1);
							Console.WriteLine(text);
							if (text != null && text != string.Empty && 0 <= text.ToLower().IndexOf(value))
							{
								Class66.smethod_13(string_, array3[i], b);
							}
							for (int j = 0; j < Class104.string_0.Length; j++)
							{
								string text2 = Class104.string_0[j];
								if (text2 != null && text2 != string.Empty && text2.ToLower().IndexOf(text) < 0)
								{
									Class66.smethod_11(string_, text2, text2, "", 1);
								}
							}
						}
					}
				}
				num2 = 60;
			}
			if (Form1.int_74 <= 0 || num > 0 || bool_0)
			{
				continue;
			}
			smethod_2();
			num = 900;
			if (bool_1)
			{
				num = 180;
				continue;
			}
			for (int k = 0; k < array2.GetLength(0); k++)
			{
				string processName = Class11.smethod_15(array2[k, 0]).ToLower();
				string text3 = array2[k, 1];
				if (text3 == null || text3 == string.Empty)
				{
					text3 = environmentVariable + "\\system32";
				}
				text3 = text3.ToLower();
				array = Process.GetProcessesByName(processName);
				if (array == null || array.Length == 0)
				{
					continue;
				}
				for (int l = 0; l < array.Length; l++)
				{
					int num3 = 0;
					string text4 = string.Empty;
					try
					{
						uint uint_ = 256u;
						StringBuilder stringBuilder = new StringBuilder(256);
						text4 = ((Class24.QueryFullProcessImageName(array[l].Handle, 0u, stringBuilder, out uint_) == 0) ? array[l].MainModule.FileName : stringBuilder.ToString());
						num3 = array[l].Id;
					}
					catch
					{
					}
					if (text4 == null || text4 == string.Empty)
					{
						continue;
					}
					string text5 = Class11.smethod_14(text4)[0];
					if (text5 != null && text5 != string.Empty)
					{
						text5 = text5.ToLower();
					}
					if (text5 == text3)
					{
						continue;
					}
					if (gstruct55_0 != null)
					{
						bool flag = false;
						for (int m = 0; m < gstruct55_0.Length; m++)
						{
							if (gstruct55_0[m].int_0 == num3)
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							Array.Resize(ref gstruct55_0, gstruct55_0.Length + 1);
							gstruct55_0[gstruct55_0.Length - 1].int_0 = num3;
							gstruct55_0[gstruct55_0.Length - 1].process_0 = array[l];
							gstruct55_0[gstruct55_0.Length - 1].string_0 = text4;
						}
					}
					else
					{
						gstruct55_0 = new GStruct55[1]
						{
							new GStruct55
							{
								process_0 = array[l],
								int_0 = num3,
								string_0 = text4
							}
						};
					}
				}
			}
			bool_2 = gstruct55_0 != null && gstruct55_0.Length != 0;
		}
	}

	private void FormAntivirus_Load(object sender, EventArgs e)
	{
		if (gstruct55_0 != null && gstruct55_0.Length != 0)
		{
			for (int i = 0; i < gstruct55_0.Length; i++)
			{
				try
				{
					method_0(gstruct55_0[i].int_0, gstruct55_0[i].string_0);
				}
				catch
				{
				}
			}
			bool_3 = true;
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
		gstruct55_0 = null;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
			return;
		}
		if (int_0 < 0)
		{
			buttonTieudiet.Enabled = true;
			int_0 = 0;
			bool_3 = true;
		}
		if (!bool_3 || listView1.Items == null)
		{
			return;
		}
		bool_3 = false;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			int processId = Class11.smethod_11(listView1.Items[i].SubItems[0].Text);
			string text = Class11.smethod_54(string_0[2]);
			bool flag = false;
			try
			{
				Process processById = Process.GetProcessById(processId);
				if (!Class24.smethod_52(processById))
				{
					if (processById.Threads[0].WaitReason == ThreadWaitReason.Suspended)
					{
						text = Class11.smethod_54(string_0[1]);
					}
					else
					{
						text = Class11.smethod_54(string_0[0]);
						flag = true;
					}
				}
			}
			catch
			{
			}
			listView1.Items[i].SubItems[2].Text = text;
			if (!flag)
			{
				listView1.Items[i].ForeColor = Color.DarkGray;
			}
		}
	}

	private void method_0(int int_1, string string_1)
	{
		string[] array = new string[3]
		{
			int_1.ToString(),
			string_1,
			"..."
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

	private void linkLabelTaiBKAV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string string_ = "bkav.com.vn/download";
		Class24.smethod_40(Class66.smethod_0(), "", string_, 0);
	}

	private void buttonTieudiet_Click(object sender, EventArgs e)
	{
		if (int_0 <= 0)
		{
			buttonTieudiet.Enabled = false;
			new Thread(method_1).Start();
		}
	}

	private void method_1()
	{
		if (gstruct55_0 != null && gstruct55_0.Length != 0)
		{
			string string_ = "ᓌᓤᓬᒫᒩᒨᒧᓃᓤᓙᓚᓑ";
			string string_2 = "ᒼᓛᓐᓒ";
			string text = Class11.smethod_54(FormCompatibility.string_1);
			string[] array = new string[4]
			{
				text,
				text.Replace(Class11.smethod_54(string_2), ""),
				text.Replace(Class11.smethod_54(string_), ""),
				text.Replace(Class11.smethod_54(string_), "").Replace(Class11.smethod_54(string_2), "")
			};
			string[] array2 = "explorer|svchost|spoolsv".Split('|');
			int_0 = 1;
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < gstruct55_0.Length; j++)
				{
					try
					{
						Class24.smethod_43(gstruct55_0[j].process_0);
					}
					catch
					{
					}
				}
			}
			Random random = new Random();
			for (int k = 0; k < gstruct55_0.Length; k++)
			{
				try
				{
					int num = 0;
					string text2 = gstruct55_0[k].string_0;
					string text3 = random.Next(10000, 1000000).ToString();
					while (Class11.smethod_17(text2) && num <= 20)
					{
						if (num % 10 == 0)
						{
							Class11.smethod_19(text2, text2 + "." + text3);
						}
						num++;
						Thread.Sleep(300);
					}
				}
				catch
				{
				}
			}
			for (int l = 0; l < gstruct55_0.Length; l++)
			{
				try
				{
					Class24.smethod_53(gstruct55_0[l].process_0);
				}
				catch
				{
				}
			}
			for (int m = 0; m < gstruct55_0.Length; m++)
			{
				try
				{
					for (int n = 0; n < array.Length; n++)
					{
						for (int num2 = 0; num2 < array2.Length; num2++)
						{
							Class66.smethod_13(array[n], array2[num2], 0);
							Class66.smethod_13(array[n], array2[num2], 1);
						}
					}
				}
				catch
				{
				}
			}
			int_0 = -1;
		}
		else
		{
			int_0 = -1;
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void buttonMothumuc_Click(object sender, EventArgs e)
	{
		string string_ = "ᓚᓭᓥᓡᓤᓧᓚᓧᒣᓚᓭᓚ";
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_0(Class56.char_0));
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
		string[] array = Class11.smethod_14(listView1.Items[num].SubItems[1].Text);
		Class24.smethod_40(environmentVariable + "\\" + Class11.smethod_54(string_), array[0], array[0], 0);
	}

	private void checkBoxKhongHienCanhbao_CheckedChanged(object sender, EventArgs e)
	{
		bool_1 = checkBoxKhongHienCanhbao.Checked;
		if (bool_1)
		{
			MessageBox.Show("Chú ý: Bật lại cảnh báo này ở tab Cài game của auto.");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns102.FormAntivirus));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.label1 = new System.Windows.Forms.Label();
		this.buttonTieudiet = new System.Windows.Forms.Button();
		this.buttonClose = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.linkLabelTaiBKAV = new System.Windows.Forms.LinkLabel();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.buttonMothumuc = new System.Windows.Forms.Button();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.checkBoxKhongHienCanhbao = new System.Windows.Forms.CheckBox();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(4, 35);
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(435, 113);
		this.listView1.TabIndex = 0;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "PID";
		this.columnHeader_1.Text = "Tệp";
		this.columnHeader_1.Width = 275;
		this.columnHeader_2.Text = "Tình trạng";
		this.columnHeader_2.Width = 80;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(3, 11);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(394, 13);
		this.label1.TabIndex = 1;
		this.label1.Text = "Cảnh báo: Danh sách dưới đây là các file có thể đã bị nhiễm keylog";
		this.buttonTieudiet.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonTieudiet.Location = new System.Drawing.Point(339, 150);
		this.buttonTieudiet.Name = "buttonTieudiet";
		this.buttonTieudiet.Size = new System.Drawing.Size(100, 36);
		this.buttonTieudiet.TabIndex = 2;
		this.buttonTieudiet.Text = "Tiêu diệt";
		this.buttonTieudiet.UseVisualStyleBackColor = true;
		this.buttonTieudiet.Click += new System.EventHandler(buttonTieudiet_Click);
		this.buttonClose.Location = new System.Drawing.Point(339, 273);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(100, 30);
		this.buttonClose.TabIndex = 3;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(4, 188);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(70, 13);
		this.label2.TabIndex = 4;
		this.label2.Text = "Cách xử lý:";
		this.linkLabelTaiBKAV.AutoSize = true;
		this.linkLabelTaiBKAV.Location = new System.Drawing.Point(4, 290);
		this.linkLabelTaiBKAV.Name = "linkLabelTaiBKAV";
		this.linkLabelTaiBKAV.Size = new System.Drawing.Size(119, 13);
		this.linkLabelTaiBKAV.TabIndex = 5;
		this.linkLabelTaiBKAV.TabStop = true;
		this.linkLabelTaiBKAV.Text = "Tải BKAV Home tại đây";
		this.linkLabelTaiBKAV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelTaiBKAV_LinkClicked);
		this.textBox1.Location = new System.Drawing.Point(6, 258);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(195, 20);
		this.textBox1.TabIndex = 6;
		this.textBox1.Text = "http://www.bkav.com.vn/download";
		this.buttonMothumuc.Location = new System.Drawing.Point(233, 150);
		this.buttonMothumuc.Name = "buttonMothumuc";
		this.buttonMothumuc.Size = new System.Drawing.Size(100, 36);
		this.buttonMothumuc.TabIndex = 7;
		this.buttonMothumuc.Text = "Mở thư mục có keylog";
		this.buttonMothumuc.UseVisualStyleBackColor = true;
		this.buttonMothumuc.Click += new System.EventHandler(buttonMothumuc_Click);
		this.richTextBox1.Location = new System.Drawing.Point(6, 212);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.ReadOnly = true;
		this.richTextBox1.Size = new System.Drawing.Size(433, 37);
		this.richTextBox1.TabIndex = 8;
		this.richTextBox1.Text = "1. Bấm nút Tiêu diệt để tạm thời làm keylog ngưng hoạt động (chưa xóa hết keylog)\n2. Tải trình quét virus BKAV Home bên dưới về cài đặt và quét keylog.";
		this.checkBoxKhongHienCanhbao.AutoSize = true;
		this.checkBoxKhongHienCanhbao.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxKhongHienCanhbao.Location = new System.Drawing.Point(4, 152);
		this.checkBoxKhongHienCanhbao.Name = "checkBoxKhongHienCanhbao";
		this.checkBoxKhongHienCanhbao.Size = new System.Drawing.Size(196, 17);
		this.checkBoxKhongHienCanhbao.TabIndex = 10;
		this.checkBoxKhongHienCanhbao.Text = "Không hiện bảng cảnh báo này nữa";
		this.checkBoxKhongHienCanhbao.UseVisualStyleBackColor = true;
		this.checkBoxKhongHienCanhbao.CheckedChanged += new System.EventHandler(checkBoxKhongHienCanhbao_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(443, 310);
		base.Controls.Add(this.checkBoxKhongHienCanhbao);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.buttonMothumuc);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.linkLabelTaiBKAV);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.buttonTieudiet);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.listView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormAntivirus";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "KYKEOXE PHAT HIEN CO VIRUS - KEYLOG";
		base.Load += new System.EventHandler(FormAntivirus_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
