using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns138;
using ns27;
using ns3;
using ns53;
using ns63;
using ns68;

namespace ns141;

public class FormTuyenchien : Form
{
	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static long long_0 = Class66.smethod_6("TC_TimeNext", 0);

	public static GStruct31[] gstruct31_0 = null;

	public int int_0 = 0;

	public int int_1 = 0;

	public int int_2;

	public int int_3;

	private bool bool_2 = false;

	private bool bool_3 = false;

	private long long_1 = -1L;

	private static string string_0 = "tbNameBhoTC";

	private static string[] string_1 = null;

	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ComboBox comboBoxThemAcc;

	private Button buttonThemAcc;

	private Button buttonXoaAcc;

	private Timer timer_0;

	private Button button1;

	private Button button2;

	private Button button3;

	private CheckBox checkBox1;

	private Label label1;

	private TextBox textBox1;

	private Button button5;

	private Label label2;

	private TextBox textBox2;

	private Button buttonEp;

	private Button buttonBoep;

	private RichTextBox richTextBox1;

	public FormTuyenchien()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	public static GStruct31[] smethod_0()
	{
		string text = Class66.smethod_7(string_0, 0);
		if (text != null && !(text == string.Empty))
		{
			string text2 = Class11.smethod_72(text);
			if (text2 != null && !(text2 == string.Empty))
			{
				string[] array = text2.Split('|');
				GStruct31[] array2 = null;
				string[] array3 = array;
				foreach (string text3 in array3)
				{
					if (text3 == null || text3 == string.Empty || text3.Length < 3)
					{
						continue;
					}
					int num = text3.IndexOf("=");
					if (num != 1)
					{
						continue;
					}
					int num2 = Convert.ToByte(text3[0] == '1');
					string text4 = text3.Substring(2);
					if (array2 == null)
					{
						array2 = new GStruct31[1]
						{
							new GStruct31
							{
								int_0 = num2,
								string_0 = text4
							}
						};
						continue;
					}
					bool flag = false;
					for (int j = 0; j < array2.Length; j++)
					{
						if (array2[j].string_0 == text4)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						Array.Resize(ref array2, array2.Length + 1);
						ref GStruct31 reference = ref array2[array2.Length - 1];
						reference = new GStruct31
						{
							int_0 = num2,
							string_0 = text4
						};
					}
				}
				return array2;
			}
			return null;
		}
		return null;
	}

	public static void smethod_1(GStruct31[] gstruct31_1)
	{
		string text = string.Empty;
		if (gstruct31_1 != null)
		{
			for (int i = 0; i < gstruct31_1.Length; i++)
			{
				if (gstruct31_1[i].string_0 != null && !(gstruct31_1[i].string_0 == string.Empty))
				{
					if (text != null && text != string.Empty)
					{
						text += "|";
					}
					object obj = text;
					text = string.Concat(obj, gstruct31_1[i].int_0, "=", gstruct31_1[i].string_0);
				}
			}
			text = Class11.smethod_71(text);
		}
		Class66.smethod_11(Class66.smethod_1(), string_0, text, "", 0);
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		smethod_1(gstruct31_0);
		bool_0 = false;
	}

	private void FormTuyenchien_Load(object sender, EventArgs e)
	{
		try
		{
			if (int_0 > 0 && int_1 > 0)
			{
				int num = int_0 - base.Width - 2;
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
			checkBox1.Checked = bool_1;
			gstruct31_0 = smethod_0();
			timer_0.Interval = 300;
			timer_0.Enabled = true;
			bool_2 = true;
			bool_3 = true;
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
			return;
		}
		if (bool_3)
		{
			bool_3 = false;
			method_0();
		}
		if (long_1 != long_0)
		{
			long_1 = long_0;
			if (long_0 == 0L)
			{
				DateTime dateTime = DateTime.Now.AddMinutes(14.0);
				textBox1.Text = "0";
				textBox2.Text = dateTime.Hour + ":" + dateTime.Minute + ":" + dateTime.Second;
			}
			else
			{
				TimeSpan timeSpan = new TimeSpan(long_0);
				TimeSpan timeSpan2 = new TimeSpan(long_0 + new TimeSpan(0, 0, 14, 0, 0).Ticks);
				textBox1.Text = timeSpan.Hours + ":" + timeSpan.Minutes + ":" + timeSpan.Seconds;
				textBox2.Text = timeSpan2.Hours + ":" + timeSpan2.Minutes + ":" + timeSpan2.Seconds;
			}
		}
	}

	private void method_0()
	{
		listView1.Items.Clear();
		if (gstruct31_0 == null)
		{
			return;
		}
		for (int i = 0; i < gstruct31_0.Length; i++)
		{
			method_1(Class1.smethod_1(gstruct31_0[i].string_0, 1));
		}
		for (int j = 0; j < gstruct31_0.Length; j++)
		{
			if (j < listView1.Items.Count && gstruct31_0[j].int_0 > 0)
			{
				listView1.Items[j].Checked = true;
			}
		}
	}

	public void method_1(string string_2)
	{
		try
		{
			ListViewItem value = new ListViewItem(string_2);
			listView1.Items.Add(value);
		}
		catch
		{
		}
	}

	private void comboBoxThemAcc_DropDown(object sender, EventArgs e)
	{
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Class28.smethod_5(Form1.characterAccountConfig_1[i]);
				Class3.smethod_24(Form1.characterAccountConfig_1[i], ref string_1);
			}
		}
		bool_2 = false;
		string text = comboBoxThemAcc.Text;
		string text2 = string.Empty;
		comboBoxThemAcc.Items.Clear();
		if (string_1 != null)
		{
			Array.Sort(string_1);
			for (int j = 0; j < string_1.Length; j++)
			{
				string text3 = Class1.smethod_1(string_1[j], 1);
				comboBoxThemAcc.Items.Add(text3);
				if (text2 == null || text2 == string.Empty || text == text3)
				{
					text2 = text3;
				}
			}
		}
		comboBoxThemAcc.Text = text2;
		bool_2 = true;
	}

	private void buttonThemAcc_Click(object sender, EventArgs e)
	{
		string text = comboBoxThemAcc.Text;
		if (string_1 == null || text == null || text == string.Empty)
		{
			return;
		}
		string text2 = null;
		for (int i = 0; i < string_1.Length; i++)
		{
			if (text == Class1.smethod_1(string_1[i], 1))
			{
				text2 = string_1[i];
				break;
			}
		}
		if (text2 == null || text2 == string.Empty)
		{
			return;
		}
		if (gstruct31_0 == null)
		{
			gstruct31_0 = new GStruct31[1]
			{
				new GStruct31
				{
					int_0 = 1,
					string_0 = text2
				}
			};
		}
		else
		{
			bool flag = false;
			for (int j = 0; j < gstruct31_0.Length; j++)
			{
				if (text2 == gstruct31_0[j].string_0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				Array.Resize(ref gstruct31_0, gstruct31_0.Length + 1);
				ref GStruct31 reference = ref gstruct31_0[gstruct31_0.Length - 1];
				reference = new GStruct31
				{
					int_0 = 1,
					string_0 = text2
				};
			}
		}
		if (listView1.Items.Count == 0)
		{
			method_1(text);
			listView1.Items[0].Checked = true;
		}
		else
		{
			bool flag2 = false;
			for (int k = 0; k < listView1.Items.Count; k++)
			{
				if (text == listView1.Items[k].SubItems[0].Text)
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				method_1(text);
				listView1.Items[listView1.Items.Count - 1].Checked = true;
			}
		}
		listView1.Items[listView1.Items.Count - 1].Checked = true;
		listView1.Items[listView1.Items.Count - 1].Selected = true;
	}

	private void buttonXoaAcc_Click(object sender, EventArgs e)
	{
		if (listView1.SelectedIndices.Count <= 0)
		{
			return;
		}
		if (gstruct31_0 != null)
		{
			int num = listView1.SelectedIndices[0];
			string text = listView1.Items[num].SubItems[0].Text;
			int num2 = 0;
			for (int i = 0; i < gstruct31_0.Length; i++)
			{
				if (text != Class1.smethod_1(gstruct31_0[i].string_0, 1))
				{
					gstruct31_0[num2].int_0 = gstruct31_0[i].int_0;
					gstruct31_0[num2].string_0 = gstruct31_0[i].string_0;
					num2++;
				}
			}
			if (num2 != 0)
			{
				if (num2 != gstruct31_0.Length)
				{
					Array.Resize(ref gstruct31_0, num2);
					listView1.Items.RemoveAt(num);
					if (listView1.Items.Count <= num)
					{
						num = listView1.Items.Count - 1;
					}
					if (0 <= num)
					{
						listView1.Items[num].Selected = true;
					}
				}
			}
			else
			{
				gstruct31_0 = null;
				listView1.Items.Clear();
			}
		}
		else if (listView1.Items.Count > 0)
		{
			listView1.Items.Clear();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (listView1.Items.Count > 0)
		{
			listView1.Items.Clear();
		}
		gstruct31_0 = null;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		bool_0 = false;
		Close();
	}

	private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (bool_2 && timer_0.Enabled)
		{
			int index = e.Index;
			string text = listView1.Items[index].SubItems[0].Text;
			if (gstruct31_0 != null && gstruct31_0.Length > index && !(text != Class1.smethod_1(gstruct31_0[index].string_0, 1)))
			{
				gstruct31_0[index].int_0 = Convert.ToByte(e.NewValue == CheckState.Checked);
				return;
			}
			listView1.Items.Clear();
			gstruct31_0 = null;
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		string string_ = "ᘁ㒞ᗍᚾ㒆ᘛᘔᗍᘡᘢᘦᚗᘛᗍᘐᘕᘖ㑬ᘛᗍᘏᘎᘛᘔᗍᘕ㒆ᘖᗙᗍᚾᘖ㑮ᘢᗍᘘᘖ㑴ᘛᗧᖷᖷᗚᗍᗻᘔᚏᘛᗍᘠᚎᘐᘕᗍᘡᘟᘜᘛᘔᗍᘏᘎᘛᘔᗍᘝᘕ㑐ᘖᗍᘐᚠᗍᘠ㑢ᘛᖷᗚᗍᗽᘕ㑐ᘖᗍᘐᘕ㑺ᘛᗍᘡᘟ\u175d㒈ᘐᗍᘎᘐᗍᚾ㒂ᘖᗍᘚᚍᘢᗍᘙᚍᗍᘁᘟ\u175d㒌ᘛᘔᗍᗹᚐᘜᗍᘕᘜ㑤ᘐᗍᗯᘎᘛᘔᗍᘐᘕ㒔ᖷᗚᗍᗽᘕ㑐ᘖᗍᘐᘕ㑺ᘛᗍᘡᘟ\u175d㒈ᘐᗍᘡᚗᘛᗍᘏᘎᘛᘔᗍᘕ㒆ᘖᗍᘐ㑔ᘛᗍᘡᘢᘦᚗᘛᗍᘐᘕᘖ㑬ᘛᗛᖷᖷᗻᘔᘢᘦᚗᘛᗍᘡ㑜ᘐᗧᖷᖷᘁᘕ㒊ᘖᗍᘔᘖᘎᘛᗍᘔᘖ㒜ᘎᗍᗟᗍᘙ㑔ᘛᗍᘡᘢᘦᚗᘛᗍᘐᘕᘖ㑬ᘛᗍᘙᚍᗍᗞᗢᗍᘝᘕᚧᘡᗙᗍᘑᘜᗍᚾᚠᗍᘎᘢᘡᘜᗍᘠ㑪ᗍᘡ㒞ᗍᚾ㒆ᘛᘔᗍᘡᘢᘦᚗᘛᗍᘐᘕᘖ㑬ᘛᗍᘙ㑎ᘖᗍ㒌ᗍᘝᘕᚧᘡᗍᘡᘕ㒖ᗍᗞᗡᗍᚾ㑰ᗍᘏ㑐ᘜᗍᚾ㑐ᘚᗍᘘᘕᚡᘛᘔᗍᘏ㑸ᗍᘔᘖᚎᘛᗍᚾᘜ㑎ᘛᗛᖷ";
		string string_2 = Class11.smethod_54(string_);
		FormTip.smethod_0(Form1.string_49, string_2, 300000, 360, 260, bool_8: false, base.Left, base.Top);
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_2 && timer_0.Enabled)
		{
			bool_1 = checkBox1.Checked;
		}
	}

	private void button5_Click(object sender, EventArgs e)
	{
		long_0 = 0L;
	}

	private void buttonEp_Click(object sender, EventArgs e)
	{
		Class72.string_4 = null;
		string text = string.Empty;
		int num = 0;
		if (gstruct31_0 != null)
		{
			for (int i = 0; i < gstruct31_0.Length; i++)
			{
				if (gstruct31_0[i].int_0 > 0)
				{
					if (Class72.string_4 == null)
					{
						Class72.string_4 = new string[1];
					}
					else
					{
						Array.Resize(ref Class72.string_4, Class72.string_4.Length + 1);
					}
					Class72.string_4[Class72.string_4.Length - 1] = gstruct31_0[i].string_0;
					num++;
					object obj = text;
					text = string.Concat(obj, num, ". ", Class1.smethod_1(gstruct31_0[i].string_0, 1), Class56.string_7);
				}
			}
		}
		Class72.uint_1 = Class72.smethod_2(Class72.string_4);
		Class72.smethod_1(Class72.string_4, Class72.string_0);
		Class72.int_1 = 1;
		Class66.smethod_11(Class66.smethod_1(), "flagLuonDanhBHO", Class72.int_1, "", 0);
		if (text == string.Empty || text == null)
		{
			text = "(Chưa có bang nào được chọn, bạn cần phải check chọn tên bang trong danh sách trên)";
		}
		string text2 = "Đã ép X bang vào danh sách luôn đánh bang hội (bấm nút Mở rộng ở bảng 1 để xem lại):\n\n".Replace("X", num.ToString()) + text;
		richTextBox1.Text = text2;
	}

	private void buttonBoep_Click(object sender, EventArgs e)
	{
		Class72.int_1 = 0;
		Class66.smethod_11(Class66.smethod_1(), "flagLuonDanhBHO", Class72.int_1, "", 0);
		richTextBox1.Text = "Đã bỏ check { luôn đánh bang hội } trong nút mở rộng";
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns141.FormTuyenchien));
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.comboBoxThemAcc = new System.Windows.Forms.ComboBox();
		this.buttonThemAcc = new System.Windows.Forms.Button();
		this.buttonXoaAcc = new System.Windows.Forms.Button();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.button1 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.button5 = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.buttonEp = new System.Windows.Forms.Button();
		this.buttonBoep = new System.Windows.Forms.Button();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		base.SuspendLayout();
		this.listView1.CheckBoxes = true;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_0 });
		this.listView1.ForeColor = System.Drawing.Color.Black;
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(3, 91);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(195, 127);
		this.listView1.TabIndex = 2;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(listView1_ItemCheck);
		this.columnHeader_0.Text = "Check vào Bang cần tuyên chiến";
		this.columnHeader_0.Width = 170;
		this.comboBoxThemAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxThemAcc.DropDownWidth = 120;
		this.comboBoxThemAcc.ForeColor = System.Drawing.Color.DarkBlue;
		this.comboBoxThemAcc.FormattingEnabled = true;
		this.comboBoxThemAcc.Location = new System.Drawing.Point(58, 223);
		this.comboBoxThemAcc.Name = "comboBoxThemAcc";
		this.comboBoxThemAcc.Size = new System.Drawing.Size(140, 21);
		this.comboBoxThemAcc.TabIndex = 63;
		this.comboBoxThemAcc.DropDown += new System.EventHandler(comboBoxThemAcc_DropDown);
		this.buttonThemAcc.ForeColor = System.Drawing.Color.DarkBlue;
		this.buttonThemAcc.Location = new System.Drawing.Point(3, 222);
		this.buttonThemAcc.Name = "buttonThemAcc";
		this.buttonThemAcc.Size = new System.Drawing.Size(50, 23);
		this.buttonThemAcc.TabIndex = 64;
		this.buttonThemAcc.Text = "Thêm";
		this.buttonThemAcc.UseVisualStyleBackColor = true;
		this.buttonThemAcc.Click += new System.EventHandler(buttonThemAcc_Click);
		this.buttonXoaAcc.ForeColor = System.Drawing.Color.Black;
		this.buttonXoaAcc.Location = new System.Drawing.Point(203, 145);
		this.buttonXoaAcc.Name = "buttonXoaAcc";
		this.buttonXoaAcc.Size = new System.Drawing.Size(70, 38);
		this.buttonXoaAcc.TabIndex = 65;
		this.buttonXoaAcc.Text = "Xóa";
		this.buttonXoaAcc.UseVisualStyleBackColor = true;
		this.buttonXoaAcc.Click += new System.EventHandler(buttonXoaAcc_Click);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.button1.ForeColor = System.Drawing.Color.Black;
		this.button1.Location = new System.Drawing.Point(203, 103);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(70, 38);
		this.button1.TabIndex = 66;
		this.button1.Text = "Xóa hết";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.button2.Location = new System.Drawing.Point(203, 327);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(70, 38);
		this.button2.TabIndex = 67;
		this.button2.Text = "Đóng";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.button3.ForeColor = System.Drawing.Color.Blue;
		this.button3.Location = new System.Drawing.Point(203, 207);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(70, 38);
		this.button3.TabIndex = 68;
		this.button3.Text = "Hướng dẫn";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.checkBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
		this.checkBox1.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBox1.Location = new System.Drawing.Point(3, 58);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(270, 19);
		this.checkBox1.TabIndex = 69;
		this.checkBox1.Text = "Ac đổi màu tự động tuyên chiến (14 phút 1 lần)";
		this.checkBox1.UseVisualStyleBackColor = false;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(3, 6);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(188, 13);
		this.label1.TabIndex = 71;
		this.label1.Text = "Thời gian tuyên chiến xong (hh:mm:ss)";
		this.textBox1.BackColor = System.Drawing.Color.White;
		this.textBox1.Location = new System.Drawing.Point(203, 3);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(70, 20);
		this.textBox1.TabIndex = 72;
		this.button5.ForeColor = System.Drawing.Color.DarkRed;
		this.button5.Location = new System.Drawing.Point(3, 25);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(148, 23);
		this.button5.TabIndex = 73;
		this.button5.Text = "khởi tạo lại kế tiếp >>";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new System.EventHandler(button5_Click);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(157, 29);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(40, 13);
		this.label2.TabIndex = 75;
		this.label2.Text = "Kế tiếp";
		this.textBox2.BackColor = System.Drawing.Color.White;
		this.textBox2.Location = new System.Drawing.Point(203, 26);
		this.textBox2.Name = "textBox2";
		this.textBox2.ReadOnly = true;
		this.textBox2.Size = new System.Drawing.Size(70, 20);
		this.textBox2.TabIndex = 76;
		this.buttonEp.Location = new System.Drawing.Point(3, 294);
		this.buttonEp.Name = "buttonEp";
		this.buttonEp.Size = new System.Drawing.Size(195, 38);
		this.buttonEp.TabIndex = 77;
		this.buttonEp.Text = "ép vào mục { luôn đánh bang hội } trong nút mở rộng";
		this.buttonEp.UseVisualStyleBackColor = true;
		this.buttonEp.Click += new System.EventHandler(buttonEp_Click);
		this.buttonBoep.Location = new System.Drawing.Point(3, 338);
		this.buttonBoep.Name = "buttonBoep";
		this.buttonBoep.Size = new System.Drawing.Size(195, 28);
		this.buttonBoep.TabIndex = 78;
		this.buttonBoep.Text = "bỏ ép { luôn đánh bang hội }";
		this.buttonBoep.UseVisualStyleBackColor = true;
		this.buttonBoep.Click += new System.EventHandler(buttonBoep_Click);
		this.richTextBox1.Location = new System.Drawing.Point(3, 250);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.ReadOnly = true;
		this.richTextBox1.Size = new System.Drawing.Size(270, 38);
		this.richTextBox1.TabIndex = 79;
		this.richTextBox1.Text = "";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(279, 373);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.buttonBoep);
		base.Controls.Add(this.buttonEp);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.button5);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.checkBox1);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.comboBoxThemAcc);
		base.Controls.Add(this.listView1);
		base.Controls.Add(this.buttonThemAcc);
		base.Controls.Add(this.buttonXoaAcc);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormTuyenchien";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "TUYEN CHIEN";
		base.Load += new System.EventHandler(FormTuyenchien_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
