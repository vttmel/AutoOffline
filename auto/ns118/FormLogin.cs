using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns2;
using ns21;
using ns23;
using ns32;
using ns45;
using ns53;
using ns63;

namespace ns118;

public class FormLogin : Form
{
	public static GStruct0[] gstruct0_0 = null;

	public static string[] string_0 = null;

	public static bool bool_0 = false;

	public static bool[] bool_1 = null;

	public static string[] string_1 = null;

	public static string string_2 = "";

	private ComboBox comboBox_0;

	public static bool bool_2 = false;

	public static bool bool_3 = false;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static int int_4 = Class66.smethod_4("flagKhongcoHsd", 0, "0");

	public static int int_5 = Class66.smethod_4("flagTuDangNhap", 0, "0");

	public static int int_6 = Class66.smethod_4("TimerOpenGame", 0, "4000");

	public static int int_7 = Class66.smethod_4("TimeDangNhap", 0, "16000");

	public static int int_8 = Class66.smethod_4("TimerNhapID", 0, "500");

	public static int int_9 = Class66.smethod_4("flagThuNho", 0, "1");

	public static int int_10 = Class66.smethod_4("fLog1ac", 0, "0");

	public static int int_11 = Class66.smethod_4("flagFileKhac", 0, "0");

	public static int int_12 = Class66.smethod_4("flagAccDll", 0, "0");

	public static string string_3 = Class66.smethod_7("PathFileKhac", 0);

	public static string string_4 = Class56.string_8 + "\\Login";

	public static string string_5 = string_4 + "\\Login.txt";

	public static string[] string_6 = new string[1] { "JX Tình Huynh Đệ|Huynh Đệ|Tương Phùng" };

	private static bool bool_4 = false;

	private static bool bool_5 = false;

	private int int_13 = 0;

	private static uint uint_0 = 0u;

	private bool bool_6 = false;

	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private System.Windows.Forms.Timer timer_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private Button buttonXoaTK;

	private Button buttonLen;

	private Button buttonXuong;

	private TextBox textBoxStatus;

	private ColumnHeader columnHeader_4;

	private Label labelStatus;

	private TextBox textBoxTimer;

	private LinkLabel linkLabelCheckAll;

	private TabPage tabPageAutoVLBS;

	private LinkLabel linkLabel1;

	private RichTextBox richTextBox1;

	private TextBox textBox1;

	private Button buttonOpenAuto;

	private Label label3;

	private TabPage tabPage2;

	private TextBox textBox2;

	private TextBox textBoxTimerDangNhap;

	private TextBox textBoxTimeOpenGame;

	private TextBox textBoxCmd;

	private Label label6;

	private CheckBox checkBoxHanSudung;

	private CheckBox checkBoxLog1ac;

	private Label label5;

	private Button buttonGameHu;

	private Label label2;

	private Label label1;

	private TabPage tabPage3;

	private ComboBox comboBoxPhanda;

	private Button buttonLuuDanhsach;

	private ComboBox comboBoxNhanVat;

	private Label labelPassword;

	private ComboBox comboBoxServer;

	private TextBox textBoxTaiKhoan;

	private TextBox textBoxPassword;

	private Button buttonSuaTK;

	private Label labelThem;

	private Button buttonPhimHuongdan;

	private Label labelTaiKhoan;

	private Label label4;

	private TabPage tabPage1;

	private TextBox textBoxFile;

	private Button buttonMoGame;

	private Button buttonBrowseGameKhac;

	private Button buttonThoatGame;

	private CheckBox checkBoxTuDangNhap;

	private Button buttonThoatGameAll;

	private CheckBox checkBoxThuNho;

	private CheckBox checkBoxFileKhac;

	private Button buttonStopLogin;

	private Button buttonLogin;

	private TabControl tabControl1;

	private TabPage tabPage4;

	private Button taonhanvat;

	private Label label7;

	private ComboBox comboBox1;

	private FolderBrowserDialog folderBrowserDialog_0;

	private FolderBrowserDialog folderBrowserDialog_1;

	private FolderBrowserDialog folderBrowserDialog_2;

	private FolderBrowserDialog folderBrowserDialog_3;

	private TextBox txtFilePath;

	private Button btnBrowse;

	private CheckBox checkBox1;

	private Button button1;

	private LinkLabel linkLabel2;

	private IContainer icontainer_1;

	public static void smethod_0(string string_7, out int int_14, out int int_15)
	{
		object obj;
		if (string_7 == null)
		{
			obj = null;
		}
		else
		{
			obj = string_7.Trim();
			if (obj != null)
			{
				goto IL_0015;
			}
		}
		obj = "";
		goto IL_0015;
		IL_0015:
		string_7 = (string)obj;
		switch (string_7)
		{
		default:
			int_14 = 200;
			int_15 = 560;
			break;
		case "Thổ":
			int_14 = 400;
			int_15 = 440;
			break;
		case "Hỏa":
			int_14 = 400;
			int_15 = 390;
			break;
		case "Thủy":
			int_14 = 400;
			int_15 = 330;
			break;
		case "Mộc":
			int_14 = 400;
			int_15 = 280;
			break;
		case "Kim":
			int_14 = 200;
			int_15 = 560;
			break;
		}
	}

	public static string smethod_1(string string_7, int int_14)
	{
		try
		{
			if (File.Exists(string_7))
			{
				using (StreamReader streamReader = new StreamReader(string_7, Encoding.UTF8))
				{
					int num = 0;
					string text;
					do
					{
						if ((text = streamReader.ReadLine()) == null)
						{
							return "";
						}
						num++;
					}
					while (num != int_14);
					return text.Trim();
				}
			}
			return "";
		}
		catch (Exception ex)
		{
			MessageBox.Show("Lỗi đọc file dòng " + int_14 + ": " + ex.Message);
			return "";
		}
	}

	public FormLogin()
	{
		bool_0 = true;
		string_0 = null;
		try
		{
			InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}
		catch
		{
		}
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		try
		{
			e.Cancel = true;
		}
		catch
		{
		}
		try
		{
			if (timer_0 != null)
			{
				timer_0.Enabled = false;
			}
		}
		catch
		{
		}
		Hide();
		Class22.smethod_1();
		int_0 = 0;
		int_1 = 0;
		bool_0 = false;
	}

	private void FormLogin_Load(object sender, EventArgs e)
	{
		try
		{
			method_0();
		}
		catch
		{
		}
	}

	private void method_0()
	{
		bool_4 = false;
		if (int_0 >= 0 && int_1 >= 0)
		{
			int num = int_0 - base.Width;
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
		string text = string.Empty;
		string text2 = string.Empty;
		for (int i = 0; i < string_6.Length; i++)
		{
			string text3 = string_6[i];
			if (text3 == null || text3 == string.Empty)
			{
				continue;
			}
			string[] array = text3.Split('|');
			comboBoxPhanda.Items.Add(array[0]);
			if ((string_6.Length <= 1 || i != 0) && text2 == string.Empty && array.Length > 1)
			{
				text = array[0];
				text2 = array[1];
				for (int j = 1; j < array.Length; j++)
				{
					comboBoxServer.Items.Add(array[j]);
				}
			}
		}
		comboBoxPhanda.Text = text;
		comboBoxServer.Text = text2;
		for (int k = 0; k < 6; k++)
		{
			comboBoxNhanVat.Items.Add(k + 1);
		}
		comboBoxNhanVat.Text = "1";
		if (gstruct0_0 != null)
		{
			bool_1 = new bool[gstruct0_0.Length];
			string_1 = new string[gstruct0_0.Length];
			for (int l = 0; l < string_1.Length; l++)
			{
				string_1[l] = "Kim";
			}
			for (int m = 0; m < gstruct0_0.Length; m++)
			{
				bool bool_ = gstruct0_0[m].int_1 > 0 && !Class24.smethod_52(gstruct0_0[m].process_0);
				method_2(gstruct0_0[m], bool_);
			}
		}
		checkBoxThuNho.Checked = int_9 > 0;
		checkBoxHanSudung.Checked = int_4 > 0;
		textBoxTimeOpenGame.Text = int_6.ToString();
		textBoxTimerDangNhap.Text = int_7.ToString();
		textBox2.Text = int_8.ToString();
		checkBoxTuDangNhap.Checked = int_5 > 0;
		checkBoxLog1ac.Checked = int_10 > 0;
		checkBoxFileKhac.Checked = int_11 > 0;
		checkBox1.Checked = int_12 > 0;
		textBoxFile.Text = string_3;
		textBox1.Text = Class35.string_0;
		richTextBox1.Text = Class56.string_23;
		if (Class2.string_1 != null && Class2.string_1 != string.Empty)
		{
			textBoxCmd.Text = Class2.string_1;
		}
		Thread.Sleep(100);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		base.Text = "LOGIN: CAP NHAT DANH SACH";
		bool_4 = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
			return;
		}
		if (string_0 != null && string_0.Length != 0)
		{
			textBoxStatus.Text = string_0[0];
			Class11.smethod_30(ref string_0, string_0[0]);
		}
		if (int_13 != Class48.int_2)
		{
			textBoxTimer.Text = "Đang chờ: " + Class48.int_2;
			int_13 = Class48.int_2;
		}
		if (Class35.string_1 != null)
		{
			Class11.smethod_62(richTextBox1, Class35.string_1);
			Class35.string_1 = null;
		}
		if (Class48.int_1 != null && Class48.int_1.Length != 0)
		{
			int num = Class48.int_1[0];
			Class11.smethod_39(ref Class48.int_1, num);
			if (0 <= num && num < listView1.Items.Count)
			{
				string text = gstruct0_0[num].string_0;
				string text2 = gstruct0_0[num].string_4;
				if (text2 != null && text2 != string.Empty)
				{
					text = Class1.smethod_1(text2, 1);
				}
				listView1.Items[num].SubItems[1].Text = text;
				if (Class24.smethod_52(gstruct0_0[num].process_0))
				{
					listView1.Items[num].ForeColor = Color.Black;
				}
				else
				{
					listView1.Items[num].ForeColor = Color.Blue;
				}
				listView1.Items[num].Checked = false;
			}
		}
		if (gstruct0_0 == null)
		{
			return;
		}
		for (int i = 0; i < gstruct0_0.Length; i++)
		{
			if (Class24.smethod_52(gstruct0_0[i].process_0))
			{
				if (listView1.Items[i].ForeColor != Color.Black)
				{
					listView1.Items[i].ForeColor = Color.Black;
					gstruct0_0[i].int_1 = 0;
				}
			}
			else if (listView1.Items[i].ForeColor != Color.Blue)
			{
				listView1.Items[i].ForeColor = Color.Blue;
			}
		}
	}

	public static string smethod_2(string string_7)
	{
		if (string_7 != null && !(string_7 == ""))
		{
			string text = "";
			char[] array = string_7.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				text += (char)(255 - array[i]);
			}
			return text;
		}
		return "";
	}

	private string method_1(string string_7)
	{
		if (!(string_7 == string.Empty))
		{
			string text = Class11.smethod_15(string_7);
			byte b = (byte)text.Length;
			if (b > 3 && text[b - 1] == '\u0003')
			{
				return string_7;
			}
			return Class11.smethod_16((char)string_7.Length + string_7 + "\u0003");
		}
		return string.Empty;
	}

	public static int smethod_3(ref GStruct0[] gstruct0_1, GStruct0 gstruct0_2)
	{
		if (gstruct0_1 != null && gstruct0_1.Length != 0)
		{
			GStruct0[] array = new GStruct0[gstruct0_1.Length + 1];
			for (int i = 0; i < gstruct0_1.Length; i++)
			{
				GStruct0 gStruct = gstruct0_1[i];
				if (!(gStruct.string_3 == gstruct0_2.string_3) || !(gStruct.string_2 == gstruct0_2.string_2) || !(gStruct.string_0 == gstruct0_2.string_0) || gStruct.int_4 != gstruct0_2.int_4)
				{
					ref GStruct0 reference = ref array[i];
					reference = gstruct0_1[i];
					continue;
				}
				return -1;
			}
			int num = array.Length - 1;
			array[num] = gstruct0_2;
			gstruct0_1 = array;
			return num;
		}
		gstruct0_1 = new GStruct0[1] { gstruct0_2 };
		return 0;
	}

	public static int smethod_4(GStruct0[] gstruct0_1, GStruct0 gstruct0_2)
	{
		if (gstruct0_1 != null && gstruct0_1.Length != 0)
		{
			for (int i = 0; i < gstruct0_1.Length; i++)
			{
				GStruct0 gStruct = gstruct0_1[i];
				if (gStruct.string_3 == gstruct0_2.string_3 && gStruct.string_2 == gstruct0_2.string_2 && gStruct.string_0 == gstruct0_2.string_0 && gStruct.int_4 == gstruct0_2.int_4)
				{
					return i;
				}
			}
		}
		return -1;
	}

	private void method_2(GStruct0 gstruct0_1, bool bool_7 = false)
	{
		int num = 0;
		try
		{
			if (listView1.Items != null)
			{
				num = listView1.Items.Count;
			}
		}
		catch
		{
		}
		string[] array = new string[6]
		{
			num.ToString(),
			Class1.smethod_1(gstruct0_1.string_4, 1),
			gstruct0_1.string_0,
			gstruct0_1.int_4.ToString(),
			gstruct0_1.string_3,
			gstruct0_1.string_2
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
		if (bool_7)
		{
			listView1.Items[listView1.Items.Count - 1].ForeColor = Color.Blue;
		}
	}

	private void method_3(ListView listView_0, int int_14 = 0)
	{
		if (listView_0.Items == null)
		{
			return;
		}
		int count = listView_0.Items.Count;
		if (count != 0)
		{
			if (int_14 >= count)
			{
				int_14 = count - 1;
			}
			listView_0.TopItem = listView_0.Items[int_14];
			listView_0.Items[int_14].Focused = true;
			listView_0.Items[int_14].Selected = true;
		}
	}

	private void buttonXoaTK_Click(object sender, EventArgs e)
	{
		if (gstruct0_0 == null || listView1.SelectedIndices == null || listView1.SelectedIndices.Count == 0)
		{
			return;
		}
		int num = listView1.SelectedIndices[0];
		string text = gstruct0_0[num].string_0;
		int num2 = 0;
		for (int i = 0; i < gstruct0_0.Length; i++)
		{
			if (i != num)
			{
				ref GStruct0 reference = ref gstruct0_0[num2];
				reference = gstruct0_0[i];
				num2++;
			}
		}
		if (num2 == 0)
		{
			gstruct0_0 = null;
			listView1.Items.Clear();
		}
		else if (num2 < gstruct0_0.Length)
		{
			Array.Resize(ref gstruct0_0, num2);
			listView1.Items.RemoveAt(num);
		}
		if (listView1.Items != null && listView1.Items.Count != 0)
		{
			if (num > listView1.Items.Count - 1)
			{
				num = listView1.Items.Count - 1;
			}
			listView1.Items[num].Focused = true;
			listView1.Items[num].Selected = true;
			for (int j = num; j < listView1.Items.Count; j++)
			{
				listView1.Items[j].SubItems[0].Text = j.ToString();
			}
			textBoxStatus.Text = "Đã xóa tài khoản " + text;
			bool_3 = true;
		}
		else
		{
			bool_3 = true;
		}
	}

	private void buttonSuaTK_Click(object sender, EventArgs e)
	{
		if (gstruct0_0 == null || listView1.SelectedIndices == null || listView1.SelectedIndices.Count == 0)
		{
			return;
		}
		int num = listView1.SelectedIndices[0];
		GStruct0 gStruct = new GStruct0
		{
			string_0 = listView1.Items[num].SubItems[2].Text,
			int_4 = Class11.smethod_11(listView1.Items[num].SubItems[3].Text),
			string_3 = listView1.Items[num].SubItems[4].Text,
			string_2 = listView1.Items[num].SubItems[5].Text
		};
		if (textBoxTaiKhoan.Text == "")
		{
			textBoxStatus.Text = "Chưa nhập ID tài khoản.";
			return;
		}
		string text = method_1(textBoxPassword.Text);
		if (text == "")
		{
			textBoxStatus.Text = "Chưa nhập PASSWORD tài khoản.";
			return;
		}
		gstruct0_0[num].string_0 = textBoxTaiKhoan.Text;
		gstruct0_0[num].string_1 = text;
		gstruct0_0[num].int_4 = Class11.smethod_11(comboBoxNhanVat.Text);
		gstruct0_0[num].string_2 = comboBoxPhanda.Text;
		gstruct0_0[num].string_3 = comboBoxServer.Text;
		listView1.Items[num].SubItems[2].Text = textBoxTaiKhoan.Text;
		listView1.Items[num].SubItems[3].Text = comboBoxNhanVat.Text;
		listView1.Items[num].SubItems[4].Text = comboBoxServer.Text;
		listView1.Items[num].SubItems[5].Text = comboBoxPhanda.Text;
		textBoxStatus.Text = "Đã sửa tài khoản tại dòng " + num;
		bool_3 = true;
	}

	private void buttonLuuDanhsach_Click(object sender, EventArgs e)
	{
		Class22.smethod_1();
		textBoxStatus.Text = "Đã lưu tệp danh sách: " + string_5;
	}

	private void listView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		int num = -1;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				num = i;
				break;
			}
		}
		if (num < 0)
		{
			return;
		}
		GStruct0 gstruct0_ = new GStruct0
		{
			string_0 = listView1.Items[num].SubItems[2].Text,
			int_4 = Class11.smethod_11(listView1.Items[num].SubItems[3].Text),
			string_3 = listView1.Items[num].SubItems[4].Text,
			string_2 = listView1.Items[num].SubItems[5].Text
		};
		int num2 = smethod_4(gstruct0_0, gstruct0_);
		if (num2 < 0)
		{
			return;
		}
		bool_4 = false;
		comboBoxServer.Items.Clear();
		for (int j = 0; j < string_6.Length; j++)
		{
			string text = string_6[j];
			if (text == null || text == string.Empty)
			{
				continue;
			}
			string[] array = text.Split('|');
			if (gstruct0_.string_2 == array[0])
			{
				for (int k = 1; k < array.Length; k++)
				{
					comboBoxServer.Items.Add(array[k]);
				}
			}
		}
		textBoxTaiKhoan.Text = gstruct0_.string_0;
		comboBoxNhanVat.Text = gstruct0_.int_4.ToString();
		comboBoxServer.Text = gstruct0_.string_3;
		comboBoxPhanda.Text = gstruct0_.string_2;
		textBoxPassword.Text = gstruct0_0[num2].string_1;
		Thread.Sleep(100);
		bool_4 = true;
	}

	private void labelThem_Click(object sender, EventArgs e)
	{
		if (!(textBoxTaiKhoan.Text == ""))
		{
			string text = method_1(textBoxPassword.Text);
			if (text == string.Empty)
			{
				textBoxStatus.Text = "Chưa nhập PASSWORD tài khoản.";
				return;
			}
			GStruct0 gStruct = new GStruct0
			{
				string_0 = textBoxTaiKhoan.Text,
				string_1 = text,
				int_4 = Class11.smethod_11(comboBoxNhanVat.Text),
				string_2 = comboBoxPhanda.Text,
				string_3 = comboBoxServer.Text
			};
			int num = smethod_3(ref gstruct0_0, gStruct);
			if (num < 0)
			{
				textBoxStatus.Text = "Tài khoản [" + gStruct.string_0 + "] đã tồn tại.";
				return;
			}
			method_2(gStruct);
			method_3(listView1, listView1.Items.Count - 1);
			textBoxStatus.Text = "Đã thêm tài khoản " + gStruct.string_0;
			bool_3 = true;
		}
		else
		{
			textBoxStatus.Text = "Chưa nhập ID tài khoản.";
		}
	}

	private void buttonLen_Click(object sender, EventArgs e)
	{
		int num = -1;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				num = i;
				break;
			}
		}
		if (num <= 0)
		{
			return;
		}
		GStruct0 gstruct0_ = new GStruct0
		{
			string_0 = listView1.Items[num].SubItems[2].Text,
			int_4 = Class11.smethod_11(listView1.Items[num].SubItems[3].Text),
			string_3 = listView1.Items[num].SubItems[4].Text,
			string_2 = listView1.Items[num].SubItems[5].Text
		};
		int num2 = smethod_4(gstruct0_0, gstruct0_);
		if (num2 < 0)
		{
			return;
		}
		for (int j = 1; j < listView1.Items[num].SubItems.Count; j++)
		{
			string text = listView1.Items[num].SubItems[j].Text;
			listView1.Items[num].SubItems[j].Text = listView1.Items[num - 1].SubItems[j].Text;
			listView1.Items[num - 1].SubItems[j].Text = text;
		}
		Color backColor = listView1.Items[num].BackColor;
		Color foreColor = listView1.Items[num].ForeColor;
		listView1.Items[num].BackColor = listView1.Items[num - 1].BackColor;
		listView1.Items[num].ForeColor = listView1.Items[num - 1].ForeColor;
		listView1.Items[num - 1].BackColor = backColor;
		listView1.Items[num - 1].ForeColor = foreColor;
		listView1.Items[num - 1].Focused = true;
		listView1.Items[num - 1].Selected = true;
		num--;
		int num3 = 0;
		try
		{
			if (listView1.TopItem != null)
			{
				num3 = listView1.TopItem.Index;
			}
		}
		catch
		{
			num3 = 0;
		}
		if (num < num3 && num3 > 0)
		{
			if (num3 < 10)
			{
				listView1.TopItem = listView1.Items[0];
			}
			else
			{
				listView1.TopItem = listView1.Items[num3 - 10];
			}
		}
		gstruct0_ = gstruct0_0[num2];
		ref GStruct0 reference = ref gstruct0_0[num2];
		reference = gstruct0_0[num2 - 1];
		gstruct0_0[num2 - 1] = gstruct0_;
		bool_3 = true;
	}

	private void buttonXuong_Click(object sender, EventArgs e)
	{
		int num = -1;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				num = i;
				break;
			}
		}
		if (num < 0 || listView1.Items.Count - 1 <= num)
		{
			return;
		}
		GStruct0 gstruct0_ = new GStruct0
		{
			string_0 = listView1.Items[num].SubItems[2].Text,
			int_4 = Class11.smethod_11(listView1.Items[num].SubItems[3].Text),
			string_3 = listView1.Items[num].SubItems[4].Text,
			string_2 = listView1.Items[num].SubItems[5].Text
		};
		int num2 = smethod_4(gstruct0_0, gstruct0_);
		if (num2 >= 0)
		{
			for (int j = 1; j < listView1.Items[num].SubItems.Count; j++)
			{
				string text = listView1.Items[num].SubItems[j].Text;
				listView1.Items[num].SubItems[j].Text = listView1.Items[num + 1].SubItems[j].Text;
				listView1.Items[num + 1].SubItems[j].Text = text;
			}
			Color backColor = listView1.Items[num].BackColor;
			Color foreColor = listView1.Items[num].ForeColor;
			listView1.Items[num].BackColor = listView1.Items[num + 1].BackColor;
			listView1.Items[num].ForeColor = listView1.Items[num + 1].ForeColor;
			listView1.Items[num + 1].BackColor = backColor;
			listView1.Items[num + 1].ForeColor = foreColor;
			listView1.Items[num + 1].Focused = true;
			listView1.Items[num + 1].Selected = true;
			num++;
			if (num > listView1.TopItem.Index + 8)
			{
				listView1.TopItem = listView1.Items[num];
			}
			gstruct0_ = gstruct0_0[num2];
			ref GStruct0 reference = ref gstruct0_0[num2];
			reference = gstruct0_0[num2 + 1];
			gstruct0_0[num2 + 1] = gstruct0_;
			bool_3 = true;
		}
	}

	private void textBoxTimeOpenGame_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_6 = Class11.smethod_11(textBoxTimeOpenGame.Text);
			Class66.smethod_11(Class66.smethod_1(), "TimerOpenGame", int_6, "", 0);
		}
	}

	private void textBoxTimerDangNhap_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_7 = Class11.smethod_11(textBoxTimerDangNhap.Text);
			Class66.smethod_11(Class66.smethod_1(), "TimeDangNhap", int_7, "", 0);
		}
	}

	private void buttonThoatGameAll_Click(object sender, EventArgs e)
	{
		bool flag = false;
		int[] array = Class24.smethod_24(Class56.string_21);
		if (array != null)
		{
			if (!flag)
			{
				string text = "Bạn chắc chắn muốn thoát hết game ?";
				if (MessageBox.Show(text, Form1.string_49, MessageBoxButtons.YesNo) == DialogResult.No)
				{
					return;
				}
				flag = true;
			}
			for (int i = 0; i < array.Length; i++)
			{
				Class24.smethod_48(array[i]);
				Thread.Sleep(60);
			}
		}
		if (Class56.string_19 == null || Class56.string_19 == string.Empty)
		{
			return;
		}
		string processName = Class56.string_19;
		if (Class11.smethod_1(Class56.string_19.ToUpper(), ".EXE") > 0)
		{
			string[] array2 = Class11.smethod_14(Class56.string_19, '.');
			processName = array2[0];
		}
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName(processName);
			if (processesByName == null || processesByName.Length == 0)
			{
				processesByName = Process.GetProcessesByName(Class56.string_19 + "\u00a0");
				if (processesByName == null || processesByName.Length == 0)
				{
					break;
				}
			}
			if (!flag)
			{
				string text2 = "Bạn chắc chắn muốn thoát hết game ?";
				if (MessageBox.Show(text2, Form1.string_49, MessageBoxButtons.YesNo) == DialogResult.No)
				{
					break;
				}
				flag = true;
			}
			try
			{
				for (int j = 0; j < processesByName.Length; j++)
				{
					Class24.smethod_53(processesByName[j]);
				}
			}
			catch
			{
				continue;
			}
			textBoxStatus.Text = "Đã thoát hết game.";
			break;
		}
	}

	private void buttonPhimHuongdan_Click(object sender, EventArgs e)
	{
		string text = "https://youtu.be/dleEtu8n5fY";
		textBoxStatus.Text = "Link phim Hướng dẫn: " + text;
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
	}

	private void method_4()
	{
		uint num = uint_0;
		if (num != 0)
		{
			Class24.ShowWindow(num, Class24.int_26);
			Thread.Sleep(150);
			Class24.ShowWindow(num, Class24.int_24);
		}
	}

	private void method_5()
	{
		uint num = uint_0;
		if (num != 0)
		{
			Class24.ShowWindow(num, Class24.int_27);
			Thread.Sleep(150);
			Class24.ShowWindow(num, Class24.int_25);
			Class24.SetForegroundWindow(num);
		}
	}

	private void method_6()
	{
		uint num = uint_0;
		if (num != 0)
		{
			Class24.ShowWindow(num, Class24.int_26);
		}
	}

	private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (bool_5)
		{
			e.NewValue = e.CurrentValue;
		}
	}

	private void listView1_MouseDown(object sender, MouseEventArgs e)
	{
		bool_5 = true;
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		bool_5 = false;
		if (e.Button != MouseButtons.Right || gstruct0_0 == null || gstruct0_0.Length == 0)
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				num = i;
				break;
			}
		}
		if (num < 0 || listView1.Items.Count <= num)
		{
			return;
		}
		GStruct0 gstruct0_ = new GStruct0
		{
			string_0 = listView1.Items[num].SubItems[2].Text,
			int_4 = Class11.smethod_11(listView1.Items[num].SubItems[3].Text),
			string_3 = listView1.Items[num].SubItems[4].Text,
			string_2 = listView1.Items[num].SubItems[5].Text
		};
		int num2 = smethod_4(gstruct0_0, gstruct0_);
		if (num2 >= 0)
		{
			if (gstruct0_0[num2].int_1 != 0 && !Class24.smethod_52(gstruct0_0[num2].process_0))
			{
				uint_0 = gstruct0_0[num2].uint_0;
				new Thread(method_4).Start();
				return;
			}
			Class48.bool_1 = true;
			Thread.Sleep(100);
			Class11.smethod_38(ref Class48.int_0, num2);
			Class48.bool_1 = false;
		}
	}

	private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left || gstruct0_0 == null || gstruct0_0.Length == 0)
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				num = i;
				break;
			}
		}
		if (num >= 0 && listView1.Items.Count > num)
		{
			GStruct0 gstruct0_ = new GStruct0
			{
				string_0 = listView1.Items[num].SubItems[2].Text,
				int_4 = Class11.smethod_11(listView1.Items[num].SubItems[3].Text),
				string_3 = listView1.Items[num].SubItems[4].Text,
				string_2 = listView1.Items[num].SubItems[5].Text
			};
			int num2 = smethod_4(gstruct0_0, gstruct0_);
			if (num2 >= 0 && !Class24.smethod_52(gstruct0_0[num2].process_0))
			{
				uint_0 = gstruct0_0[num2].uint_0;
				new Thread(method_5).Start();
			}
		}
	}

	private void checkBoxThuNho_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_9 = Convert.ToByte(checkBoxThuNho.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagThuNho", int_9, "", 0);
		}
	}

	private void comboBoxPhanda_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_4)
		{
			return;
		}
		comboBoxServer.Items.Clear();
		string text = comboBoxPhanda.Text;
		int num = 0;
		string[] array;
		while (true)
		{
			if (num >= string_6.Length)
			{
				return;
			}
			string text2 = string_6[num];
			if (text2 != null && !(text2 == string.Empty))
			{
				array = text2.Split('|');
				if (text == array[0])
				{
					break;
				}
			}
			num++;
		}
		if (array.Length > 1)
		{
			for (int i = 1; i < array.Length; i++)
			{
				comboBoxServer.Items.Add(array[i]);
			}
			comboBoxServer.Text = array[1];
		}
	}

	private void buttonLogin_Click(object sender, EventArgs e)
	{
		Class48.bool_1 = true;
		Thread.Sleep(100);
		bool flag = false;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Checked)
			{
				flag = true;
				Class11.smethod_38(ref Class48.int_0, i);
			}
		}
		if (flag)
		{
			Class48.bool_1 = false;
			return;
		}
		int num = -1;
		for (int j = 0; j < listView1.Items.Count; j++)
		{
			if (listView1.Items[j].Selected)
			{
				num = j;
				break;
			}
		}
		if (0 <= num)
		{
			Class11.smethod_38(ref Class48.int_0, num);
		}
		Class48.bool_1 = false;
	}

	private void checkBoxTuDangNhap_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_5 = Convert.ToByte(checkBoxTuDangNhap.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagTuDangNhap", int_5, "", 0);
		}
	}

	private void buttonMoGame_Click(object sender, EventArgs e)
	{
		Class2.smethod_1();
	}

	private void buttonStopLogin_Click(object sender, EventArgs e)
	{
		Class48.bool_0 = true;
	}

	private void linkLabelCheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		bool_6 = !bool_6;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			listView1.Items[i].Checked = bool_6;
		}
	}

	private void buttonGameHu_Click(object sender, EventArgs e)
	{
		new Thread(method_7).Start();
	}

	private void method_7()
	{
		string_0 = new string[1] { Class48.smethod_5() };
	}

	private void checkBoxLog1ac_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_10 = Convert.ToByte(checkBoxLog1ac.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fLog1ac", int_10, "", 0);
		}
	}

	private void checkBoxFileKhac_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_4)
		{
			int_11 = Convert.ToByte(checkBoxFileKhac.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagFileKhac", int_11, "", 0);
		}
	}

	private void buttonBrowseGameKhac_Click(object sender, EventArgs e)
	{
		string text = Class56.string_18;
		if (text == string.Empty || text == null)
		{
			text = Class56.string_8;
		}
		string text2 = Class56.smethod_26(text, string.Empty, "*.exe");
		textBoxFile.Text = text2;
		string_3 = text2;
		Class66.smethod_11(Class66.smethod_1(), "PathFileKhac", string_3, "", 0);
		if (text2 != null && text2 != string.Empty)
		{
			Class24.smethod_71(text2);
		}
	}

	private void buttonThoatGame_Click(object sender, EventArgs e)
	{
		if (gstruct0_0 != null && listView1.SelectedIndices != null && listView1.SelectedIndices.Count != 0)
		{
			int num = listView1.SelectedIndices[0];
			if (num >= 0 && gstruct0_0.Length > num && !Class24.smethod_52(gstruct0_0[num].process_0))
			{
				Class24.smethod_53(gstruct0_0[num].process_0);
			}
		}
	}

	private void checkBoxHanSudung_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_4 = Convert.ToByte(checkBoxHanSudung.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagKhongcoHsd", int_4, "", 0);
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			textBox1.Text = Clipboard.GetText();
		}
		catch
		{
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class35.string_0 = textBox1.Text;
			Class66.smethod_11(Class66.smethod_1(), "SBLV", Class35.string_0, "", 0);
		}
	}

	private void buttonOpenAuto_Click(object sender, EventArgs e)
	{
		new Thread(new Class35().method_0).Start();
	}

	private void textBoxCmd_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class2.string_1 = textBoxCmd.Text;
		}
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_8 = Class11.smethod_11(textBox2.Text);
			Class66.smethod_11(Class66.smethod_1(), "TimerNhapID", int_8, "", 0);
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
		this.icontainer_1 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns118.FormLogin));
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_4 = new System.Windows.Forms.ColumnHeader();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_1);
		this.buttonXoaTK = new System.Windows.Forms.Button();
		this.buttonLen = new System.Windows.Forms.Button();
		this.buttonXuong = new System.Windows.Forms.Button();
		this.textBoxStatus = new System.Windows.Forms.TextBox();
		this.labelStatus = new System.Windows.Forms.Label();
		this.textBoxTimer = new System.Windows.Forms.TextBox();
		this.linkLabelCheckAll = new System.Windows.Forms.LinkLabel();
		this.tabPageAutoVLBS = new System.Windows.Forms.TabPage();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.buttonOpenAuto = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.textBoxTimerDangNhap = new System.Windows.Forms.TextBox();
		this.textBoxTimeOpenGame = new System.Windows.Forms.TextBox();
		this.textBoxCmd = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.checkBoxHanSudung = new System.Windows.Forms.CheckBox();
		this.checkBoxLog1ac = new System.Windows.Forms.CheckBox();
		this.label5 = new System.Windows.Forms.Label();
		this.buttonGameHu = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.tabPage3 = new System.Windows.Forms.TabPage();
		this.comboBoxPhanda = new System.Windows.Forms.ComboBox();
		this.buttonLuuDanhsach = new System.Windows.Forms.Button();
		this.comboBoxNhanVat = new System.Windows.Forms.ComboBox();
		this.labelPassword = new System.Windows.Forms.Label();
		this.comboBoxServer = new System.Windows.Forms.ComboBox();
		this.textBoxTaiKhoan = new System.Windows.Forms.TextBox();
		this.textBoxPassword = new System.Windows.Forms.TextBox();
		this.buttonSuaTK = new System.Windows.Forms.Button();
		this.labelThem = new System.Windows.Forms.Label();
		this.buttonPhimHuongdan = new System.Windows.Forms.Button();
		this.labelTaiKhoan = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.button1 = new System.Windows.Forms.Button();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.textBoxFile = new System.Windows.Forms.TextBox();
		this.buttonMoGame = new System.Windows.Forms.Button();
		this.buttonBrowseGameKhac = new System.Windows.Forms.Button();
		this.buttonThoatGame = new System.Windows.Forms.Button();
		this.checkBoxTuDangNhap = new System.Windows.Forms.CheckBox();
		this.buttonThoatGameAll = new System.Windows.Forms.Button();
		this.checkBoxThuNho = new System.Windows.Forms.CheckBox();
		this.checkBoxFileKhac = new System.Windows.Forms.CheckBox();
		this.buttonStopLogin = new System.Windows.Forms.Button();
		this.buttonLogin = new System.Windows.Forms.Button();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage4 = new System.Windows.Forms.TabPage();
		this.txtFilePath = new System.Windows.Forms.TextBox();
		this.btnBrowse = new System.Windows.Forms.Button();
		this.label7 = new System.Windows.Forms.Label();
		this.comboBox1 = new System.Windows.Forms.ComboBox();
		this.taonhanvat = new System.Windows.Forms.Button();
		this.folderBrowserDialog_0 = new System.Windows.Forms.FolderBrowserDialog();
		this.folderBrowserDialog_1 = new System.Windows.Forms.FolderBrowserDialog();
		this.folderBrowserDialog_2 = new System.Windows.Forms.FolderBrowserDialog();
		this.folderBrowserDialog_3 = new System.Windows.Forms.FolderBrowserDialog();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.tabPageAutoVLBS.SuspendLayout();
		this.tabPage2.SuspendLayout();
		this.tabPage3.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.tabControl1.SuspendLayout();
		this.tabPage4.SuspendLayout();
		base.SuspendLayout();
		this.listView1.CheckBoxes = true;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[5] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2, this.columnHeader_3, this.columnHeader_4 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(1, 43);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(300, 144);
		this.listView1.TabIndex = 1;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(listView1_ItemCheck);
		this.listView1.SelectedIndexChanged += new System.EventHandler(listView1_SelectedIndexChanged);
		this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(listView1_MouseDoubleClick);
		this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(listView1_MouseDown);
		this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		this.columnHeader_0.Text = "No";
		this.columnHeader_0.Width = 50;
		this.columnHeader_1.Text = "Nhân vật";
		this.columnHeader_1.Width = 120;
		this.columnHeader_2.Text = "ID";
		this.columnHeader_2.Width = 30;
		this.columnHeader_3.Text = "Số";
		this.columnHeader_3.Width = 25;
		this.columnHeader_4.Text = "Server";
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonXoaTK.Location = new System.Drawing.Point(212, 59);
		this.buttonXoaTK.Name = "buttonXoaTK";
		this.buttonXoaTK.Size = new System.Drawing.Size(46, 23);
		this.buttonXoaTK.TabIndex = 171;
		this.buttonXoaTK.Text = "Xóa";
		this.buttonXoaTK.UseVisualStyleBackColor = true;
		this.buttonXoaTK.Click += new System.EventHandler(buttonXoaTK_Click);
		this.buttonLen.BackColor = System.Drawing.SystemColors.Control;
		this.buttonLen.Image = (System.Drawing.Image)resources.GetObject("buttonLen.Image");
		this.buttonLen.Location = new System.Drawing.Point(307, 43);
		this.buttonLen.Name = "buttonLen";
		this.buttonLen.Size = new System.Drawing.Size(35, 50);
		this.buttonLen.TabIndex = 172;
		this.buttonLen.UseVisualStyleBackColor = false;
		this.buttonLen.Click += new System.EventHandler(buttonLen_Click);
		this.buttonXuong.BackColor = System.Drawing.SystemColors.Control;
		this.buttonXuong.Image = (System.Drawing.Image)resources.GetObject("buttonXuong.Image");
		this.buttonXuong.Location = new System.Drawing.Point(307, 137);
		this.buttonXuong.Name = "buttonXuong";
		this.buttonXuong.Size = new System.Drawing.Size(35, 50);
		this.buttonXuong.TabIndex = 173;
		this.buttonXuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.buttonXuong.UseVisualStyleBackColor = false;
		this.buttonXuong.Click += new System.EventHandler(buttonXuong_Click);
		this.textBoxStatus.Location = new System.Drawing.Point(1, 1);
		this.textBoxStatus.Name = "textBoxStatus";
		this.textBoxStatus.ReadOnly = true;
		this.textBoxStatus.Size = new System.Drawing.Size(145, 20);
		this.textBoxStatus.TabIndex = 174;
		this.labelStatus.AutoSize = true;
		this.labelStatus.ForeColor = System.Drawing.Color.DarkRed;
		this.labelStatus.Location = new System.Drawing.Point(169, 24);
		this.labelStatus.Name = "labelStatus";
		this.labelStatus.Size = new System.Drawing.Size(157, 13);
		this.labelStatus.TabIndex = 178;
		this.labelStatus.Text = "Click chuột phải để login nhanh";
		this.textBoxTimer.Location = new System.Drawing.Point(152, 1);
		this.textBoxTimer.Name = "textBoxTimer";
		this.textBoxTimer.ReadOnly = true;
		this.textBoxTimer.Size = new System.Drawing.Size(190, 20);
		this.textBoxTimer.TabIndex = 181;
		this.linkLabelCheckAll.AutoSize = true;
		this.linkLabelCheckAll.Location = new System.Drawing.Point(3, 24);
		this.linkLabelCheckAll.Name = "linkLabelCheckAll";
		this.linkLabelCheckAll.Size = new System.Drawing.Size(142, 13);
		this.linkLabelCheckAll.TabIndex = 182;
		this.linkLabelCheckAll.TabStop = true;
		this.linkLabelCheckAll.Text = "Check hoặc Uncheck tất cả";
		this.linkLabelCheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelCheckAll_LinkClicked);
		this.tabPageAutoVLBS.Controls.Add(this.linkLabel1);
		this.tabPageAutoVLBS.Controls.Add(this.richTextBox1);
		this.tabPageAutoVLBS.Controls.Add(this.textBox1);
		this.tabPageAutoVLBS.Controls.Add(this.buttonOpenAuto);
		this.tabPageAutoVLBS.Controls.Add(this.label3);
		this.tabPageAutoVLBS.Location = new System.Drawing.Point(4, 22);
		this.tabPageAutoVLBS.Name = "tabPageAutoVLBS";
		this.tabPageAutoVLBS.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageAutoVLBS.Size = new System.Drawing.Size(339, 117);
		this.tabPageAutoVLBS.TabIndex = 5;
		this.tabPageAutoVLBS.Text = "VLBS";
		this.tabPageAutoVLBS.UseVisualStyleBackColor = true;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Location = new System.Drawing.Point(300, 70);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(37, 13);
		this.linkLabel1.TabIndex = 183;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = " ..dán ";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.richTextBox1.Location = new System.Drawing.Point(2, 0);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.Size = new System.Drawing.Size(336, 59);
		this.richTextBox1.TabIndex = 3;
		this.richTextBox1.Text = "";
		this.textBox1.Location = new System.Drawing.Point(155, 67);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(142, 20);
		this.textBox1.TabIndex = 0;
		this.textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
		this.buttonOpenAuto.Location = new System.Drawing.Point(2, 65);
		this.buttonOpenAuto.Name = "buttonOpenAuto";
		this.buttonOpenAuto.Size = new System.Drawing.Size(80, 23);
		this.buttonOpenAuto.TabIndex = 2;
		this.buttonOpenAuto.Text = "Mở auto";
		this.buttonOpenAuto.UseVisualStyleBackColor = true;
		this.buttonOpenAuto.Click += new System.EventHandler(buttonOpenAuto_Click);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(105, 70);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(44, 13);
		this.label3.TabIndex = 1;
		this.label3.Text = "Mã máy";
		this.tabPage2.Controls.Add(this.textBox2);
		this.tabPage2.Controls.Add(this.textBoxTimerDangNhap);
		this.tabPage2.Controls.Add(this.textBoxTimeOpenGame);
		this.tabPage2.Controls.Add(this.textBoxCmd);
		this.tabPage2.Controls.Add(this.label6);
		this.tabPage2.Controls.Add(this.checkBoxHanSudung);
		this.tabPage2.Controls.Add(this.checkBoxLog1ac);
		this.tabPage2.Controls.Add(this.label5);
		this.tabPage2.Controls.Add(this.buttonGameHu);
		this.tabPage2.Controls.Add(this.label2);
		this.tabPage2.Controls.Add(this.label1);
		this.tabPage2.Location = new System.Drawing.Point(4, 22);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(339, 117);
		this.tabPage2.TabIndex = 4;
		this.tabPage2.Text = "Khác";
		this.tabPage2.UseVisualStyleBackColor = true;
		this.textBox2.Location = new System.Drawing.Point(113, 46);
		this.textBox2.Name = "textBox2";
		this.textBox2.Size = new System.Drawing.Size(50, 20);
		this.textBox2.TabIndex = 400;
		this.textBox2.TextChanged += new System.EventHandler(textBox2_TextChanged);
		this.textBoxTimerDangNhap.Location = new System.Drawing.Point(113, 23);
		this.textBoxTimerDangNhap.Name = "textBoxTimerDangNhap";
		this.textBoxTimerDangNhap.Size = new System.Drawing.Size(50, 20);
		this.textBoxTimerDangNhap.TabIndex = 167;
		this.textBoxTimerDangNhap.TextChanged += new System.EventHandler(textBoxTimerDangNhap_TextChanged);
		this.textBoxTimeOpenGame.Location = new System.Drawing.Point(113, 2);
		this.textBoxTimeOpenGame.Name = "textBoxTimeOpenGame";
		this.textBoxTimeOpenGame.Size = new System.Drawing.Size(50, 20);
		this.textBoxTimeOpenGame.TabIndex = 165;
		this.textBoxTimeOpenGame.TextChanged += new System.EventHandler(textBoxTimeOpenGame_TextChanged);
		this.textBoxCmd.ForeColor = System.Drawing.Color.DarkBlue;
		this.textBoxCmd.Location = new System.Drawing.Point(85, 68);
		this.textBoxCmd.Name = "textBoxCmd";
		this.textBoxCmd.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.textBoxCmd.Size = new System.Drawing.Size(78, 20);
		this.textBoxCmd.TabIndex = 397;
		this.textBoxCmd.TextChanged += new System.EventHandler(textBoxCmd_TextChanged);
		this.label6.AutoSize = true;
		this.label6.BackColor = System.Drawing.SystemColors.Control;
		this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
		this.label6.Location = new System.Drawing.Point(1, 49);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(105, 13);
		this.label6.TabIndex = 399;
		this.label6.Text = "Time nhập ID && pass";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.checkBoxHanSudung.AutoSize = true;
		this.checkBoxHanSudung.Location = new System.Drawing.Point(174, 22);
		this.checkBoxHanSudung.Name = "checkBoxHanSudung";
		this.checkBoxHanSudung.Size = new System.Drawing.Size(162, 17);
		this.checkBoxHanSudung.TabIndex = 391;
		this.checkBoxHanSudung.Text = "game không có hạn sử dụng";
		this.checkBoxHanSudung.UseVisualStyleBackColor = true;
		this.checkBoxHanSudung.CheckedChanged += new System.EventHandler(checkBoxHanSudung_CheckedChanged);
		this.checkBoxLog1ac.AutoSize = true;
		this.checkBoxLog1ac.Location = new System.Drawing.Point(174, 3);
		this.checkBoxLog1ac.Name = "checkBoxLog1ac";
		this.checkBoxLog1ac.Size = new System.Drawing.Size(114, 17);
		this.checkBoxLog1ac.TabIndex = 390;
		this.checkBoxLog1ac.Text = "Fix User32 log 1ac";
		this.checkBoxLog1ac.UseVisualStyleBackColor = true;
		this.checkBoxLog1ac.CheckedChanged += new System.EventHandler(checkBoxLog1ac_CheckedChanged);
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(3, 71);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(77, 13);
		this.label5.TabIndex = 398;
		this.label5.Text = "Command Line";
		this.buttonGameHu.Location = new System.Drawing.Point(223, 49);
		this.buttonGameHu.Name = "buttonGameHu";
		this.buttonGameHu.Size = new System.Drawing.Size(116, 37);
		this.buttonGameHu.TabIndex = 178;
		this.buttonGameHu.Text = "Thoát hết game hư còn chạy ngầm";
		this.buttonGameHu.UseVisualStyleBackColor = true;
		this.buttonGameHu.Click += new System.EventHandler(buttonGameHu_Click);
		this.label2.AutoSize = true;
		this.label2.BackColor = System.Drawing.SystemColors.Control;
		this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
		this.label2.Location = new System.Drawing.Point(1, 26);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(107, 13);
		this.label2.TabIndex = 166;
		this.label2.Text = "Time đăng nhập (ms)";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label1.AutoSize = true;
		this.label1.BackColor = System.Drawing.SystemColors.Control;
		this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
		this.label1.Location = new System.Drawing.Point(1, 5);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 13);
		this.label1.TabIndex = 164;
		this.label1.Text = "Time mở game (ms)";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.tabPage3.Controls.Add(this.comboBoxPhanda);
		this.tabPage3.Controls.Add(this.buttonLuuDanhsach);
		this.tabPage3.Controls.Add(this.comboBoxNhanVat);
		this.tabPage3.Controls.Add(this.labelPassword);
		this.tabPage3.Controls.Add(this.comboBoxServer);
		this.tabPage3.Controls.Add(this.textBoxTaiKhoan);
		this.tabPage3.Controls.Add(this.textBoxPassword);
		this.tabPage3.Controls.Add(this.buttonXoaTK);
		this.tabPage3.Controls.Add(this.buttonSuaTK);
		this.tabPage3.Controls.Add(this.labelThem);
		this.tabPage3.Controls.Add(this.buttonPhimHuongdan);
		this.tabPage3.Controls.Add(this.labelTaiKhoan);
		this.tabPage3.Controls.Add(this.label4);
		this.tabPage3.Location = new System.Drawing.Point(4, 22);
		this.tabPage3.Name = "tabPage3";
		this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage3.Size = new System.Drawing.Size(339, 117);
		this.tabPage3.TabIndex = 2;
		this.tabPage3.Text = "Nhập tài khoản";
		this.tabPage3.UseVisualStyleBackColor = true;
		this.comboBoxPhanda.BackColor = System.Drawing.SystemColors.Control;
		this.comboBoxPhanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxPhanda.FormattingEnabled = true;
		this.comboBoxPhanda.Location = new System.Drawing.Point(151, 7);
		this.comboBoxPhanda.Name = "comboBoxPhanda";
		this.comboBoxPhanda.Size = new System.Drawing.Size(110, 21);
		this.comboBoxPhanda.TabIndex = 166;
		this.comboBoxPhanda.SelectedIndexChanged += new System.EventHandler(comboBoxPhanda_SelectedIndexChanged);
		this.buttonLuuDanhsach.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonLuuDanhsach.Location = new System.Drawing.Point(264, 7);
		this.buttonLuuDanhsach.Name = "buttonLuuDanhsach";
		this.buttonLuuDanhsach.Size = new System.Drawing.Size(73, 37);
		this.buttonLuuDanhsach.TabIndex = 175;
		this.buttonLuuDanhsach.Text = "Lưu danh sách";
		this.buttonLuuDanhsach.UseVisualStyleBackColor = true;
		this.buttonLuuDanhsach.Click += new System.EventHandler(buttonLuuDanhsach_Click);
		this.comboBoxNhanVat.BackColor = System.Drawing.SystemColors.Window;
		this.comboBoxNhanVat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxNhanVat.FormattingEnabled = true;
		this.comboBoxNhanVat.Location = new System.Drawing.Point(60, 60);
		this.comboBoxNhanVat.Name = "comboBoxNhanVat";
		this.comboBoxNhanVat.Size = new System.Drawing.Size(35, 21);
		this.comboBoxNhanVat.TabIndex = 165;
		this.comboBoxNhanVat.SelectedIndexChanged += new System.EventHandler(comboBoxNhanVat_SelectedIndexChanged);
		this.labelPassword.AutoSize = true;
		this.labelPassword.BackColor = System.Drawing.SystemColors.Control;
		this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlText;
		this.labelPassword.Location = new System.Drawing.Point(3, 34);
		this.labelPassword.Name = "labelPassword";
		this.labelPassword.Size = new System.Drawing.Size(53, 13);
		this.labelPassword.TabIndex = 162;
		this.labelPassword.Text = "Password";
		this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.comboBoxServer.BackColor = System.Drawing.SystemColors.Control;
		this.comboBoxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxServer.FormattingEnabled = true;
		this.comboBoxServer.Location = new System.Drawing.Point(151, 32);
		this.comboBoxServer.Name = "comboBoxServer";
		this.comboBoxServer.Size = new System.Drawing.Size(110, 21);
		this.comboBoxServer.TabIndex = 167;
		this.textBoxTaiKhoan.Location = new System.Drawing.Point(61, 7);
		this.textBoxTaiKhoan.Name = "textBoxTaiKhoan";
		this.textBoxTaiKhoan.Size = new System.Drawing.Size(85, 20);
		this.textBoxTaiKhoan.TabIndex = 163;
		this.textBoxPassword.Location = new System.Drawing.Point(61, 32);
		this.textBoxPassword.Name = "textBoxPassword";
		this.textBoxPassword.PasswordChar = '*';
		this.textBoxPassword.Size = new System.Drawing.Size(85, 20);
		this.textBoxPassword.TabIndex = 164;
		this.buttonSuaTK.Location = new System.Drawing.Point(151, 59);
		this.buttonSuaTK.Name = "buttonSuaTK";
		this.buttonSuaTK.Size = new System.Drawing.Size(55, 23);
		this.buttonSuaTK.TabIndex = 170;
		this.buttonSuaTK.Text = "Sửa";
		this.buttonSuaTK.UseVisualStyleBackColor = true;
		this.buttonSuaTK.Click += new System.EventHandler(buttonSuaTK_Click);
		this.labelThem.BackColor = System.Drawing.Color.LightSteelBlue;
		this.labelThem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.labelThem.Cursor = System.Windows.Forms.Cursors.Hand;
		this.labelThem.ForeColor = System.Drawing.Color.MediumBlue;
		this.labelThem.Location = new System.Drawing.Point(100, 60);
		this.labelThem.Name = "labelThem";
		this.labelThem.Size = new System.Drawing.Size(45, 21);
		this.labelThem.TabIndex = 176;
		this.labelThem.Text = "Thêm";
		this.labelThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.labelThem.Click += new System.EventHandler(labelThem_Click);
		this.buttonPhimHuongdan.ForeColor = System.Drawing.Color.Blue;
		this.buttonPhimHuongdan.Location = new System.Drawing.Point(264, 49);
		this.buttonPhimHuongdan.Name = "buttonPhimHuongdan";
		this.buttonPhimHuongdan.Size = new System.Drawing.Size(73, 36);
		this.buttonPhimHuongdan.TabIndex = 182;
		this.buttonPhimHuongdan.Text = "Phim hướng dẫn login";
		this.buttonPhimHuongdan.UseVisualStyleBackColor = true;
		this.buttonPhimHuongdan.Click += new System.EventHandler(buttonPhimHuongdan_Click);
		this.labelTaiKhoan.AutoSize = true;
		this.labelTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
		this.labelTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
		this.labelTaiKhoan.Location = new System.Drawing.Point(3, 11);
		this.labelTaiKhoan.Name = "labelTaiKhoan";
		this.labelTaiKhoan.Size = new System.Drawing.Size(55, 13);
		this.labelTaiKhoan.TabIndex = 161;
		this.labelTaiKhoan.Text = "Tài khoản";
		this.labelTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.BackColor = System.Drawing.SystemColors.Control;
		this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
		this.label4.Location = new System.Drawing.Point(3, 64);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(51, 13);
		this.label4.TabIndex = 168;
		this.label4.Text = "Nhân vật";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.Click += new System.EventHandler(label4_Click);
		this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
		this.tabPage1.Controls.Add(this.linkLabel2);
		this.tabPage1.Controls.Add(this.button1);
		this.tabPage1.Controls.Add(this.checkBox1);
		this.tabPage1.Controls.Add(this.textBoxFile);
		this.tabPage1.Controls.Add(this.buttonMoGame);
		this.tabPage1.Controls.Add(this.buttonBrowseGameKhac);
		this.tabPage1.Controls.Add(this.buttonThoatGame);
		this.tabPage1.Controls.Add(this.checkBoxTuDangNhap);
		this.tabPage1.Controls.Add(this.buttonThoatGameAll);
		this.tabPage1.Controls.Add(this.checkBoxThuNho);
		this.tabPage1.Controls.Add(this.checkBoxFileKhac);
		this.tabPage1.Controls.Add(this.buttonStopLogin);
		this.tabPage1.Controls.Add(this.buttonLogin);
		this.tabPage1.Location = new System.Drawing.Point(4, 22);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(339, 117);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Quản lý";
		this.button1.Location = new System.Drawing.Point(140, 49);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(90, 22);
		this.button1.TabIndex = 398;
		this.button1.Text = "Mở Auto VLBS";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.checkBox1.Location = new System.Drawing.Point(3, 49);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(110, 20);
		this.checkBox1.TabIndex = 397;
		this.checkBox1.Text = "Tick Auto VLBS";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.textBoxFile.ForeColor = System.Drawing.Color.DarkBlue;
		this.textBoxFile.Location = new System.Drawing.Point(140, 25);
		this.textBoxFile.Name = "textBoxFile";
		this.textBoxFile.ReadOnly = true;
		this.textBoxFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.textBoxFile.Size = new System.Drawing.Size(198, 20);
		this.textBoxFile.TabIndex = 395;
		this.buttonMoGame.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonMoGame.Location = new System.Drawing.Point(140, 77);
		this.buttonMoGame.Name = "buttonMoGame";
		this.buttonMoGame.Size = new System.Drawing.Size(60, 36);
		this.buttonMoGame.TabIndex = 389;
		this.buttonMoGame.Text = "Mở game";
		this.buttonMoGame.UseVisualStyleBackColor = false;
		this.buttonMoGame.Click += new System.EventHandler(buttonMoGame_Click);
		this.buttonBrowseGameKhac.ForeColor = System.Drawing.Color.DarkBlue;
		this.buttonBrowseGameKhac.Location = new System.Drawing.Point(308, 2);
		this.buttonBrowseGameKhac.Name = "buttonBrowseGameKhac";
		this.buttonBrowseGameKhac.Size = new System.Drawing.Size(30, 21);
		this.buttonBrowseGameKhac.TabIndex = 396;
		this.buttonBrowseGameKhac.Text = "***";
		this.buttonBrowseGameKhac.UseVisualStyleBackColor = true;
		this.buttonBrowseGameKhac.Click += new System.EventHandler(buttonBrowseGameKhac_Click);
		this.buttonThoatGame.ForeColor = System.Drawing.Color.Black;
		this.buttonThoatGame.Location = new System.Drawing.Point(204, 76);
		this.buttonThoatGame.Name = "buttonThoatGame";
		this.buttonThoatGame.Size = new System.Drawing.Size(63, 36);
		this.buttonThoatGame.TabIndex = 344;
		this.buttonThoatGame.Text = "Thoát game";
		this.buttonThoatGame.UseVisualStyleBackColor = true;
		this.buttonThoatGame.Click += new System.EventHandler(buttonThoatGame_Click);
		this.checkBoxTuDangNhap.AutoSize = true;
		this.checkBoxTuDangNhap.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxTuDangNhap.Location = new System.Drawing.Point(3, 3);
		this.checkBoxTuDangNhap.Name = "checkBoxTuDangNhap";
		this.checkBoxTuDangNhap.Size = new System.Drawing.Size(109, 17);
		this.checkBoxTuDangNhap.TabIndex = 388;
		this.checkBoxTuDangNhap.Text = "Tự log ac khi diss";
		this.checkBoxTuDangNhap.UseVisualStyleBackColor = true;
		this.checkBoxTuDangNhap.CheckedChanged += new System.EventHandler(checkBoxTuDangNhap_CheckedChanged);
		this.buttonThoatGameAll.Location = new System.Drawing.Point(268, 75);
		this.buttonThoatGameAll.Name = "buttonThoatGameAll";
		this.buttonThoatGameAll.Size = new System.Drawing.Size(70, 36);
		this.buttonThoatGameAll.TabIndex = 177;
		this.buttonThoatGameAll.Text = "Thoát hết game";
		this.buttonThoatGameAll.UseVisualStyleBackColor = true;
		this.buttonThoatGameAll.Click += new System.EventHandler(buttonThoatGameAll_Click);
		this.checkBoxThuNho.AutoSize = true;
		this.checkBoxThuNho.Location = new System.Drawing.Point(3, 26);
		this.checkBoxThuNho.Name = "checkBoxThuNho";
		this.checkBoxThuNho.Size = new System.Drawing.Size(115, 17);
		this.checkBoxThuNho.TabIndex = 184;
		this.checkBoxThuNho.Text = "Thu nhỏ khi log ac";
		this.checkBoxThuNho.UseVisualStyleBackColor = true;
		this.checkBoxThuNho.CheckedChanged += new System.EventHandler(checkBoxThuNho_CheckedChanged);
		this.checkBoxFileKhac.AutoSize = true;
		this.checkBoxFileKhac.ForeColor = System.Drawing.Color.DarkBlue;
		this.checkBoxFileKhac.Location = new System.Drawing.Point(140, 3);
		this.checkBoxFileKhac.Name = "checkBoxFileKhac";
		this.checkBoxFileKhac.Size = new System.Drawing.Size(164, 17);
		this.checkBoxFileKhac.TabIndex = 393;
		this.checkBoxFileKhac.Text = "Mở game thông qua file khác";
		this.checkBoxFileKhac.UseVisualStyleBackColor = true;
		this.checkBoxFileKhac.CheckedChanged += new System.EventHandler(checkBoxFileKhac_CheckedChanged);
		this.buttonStopLogin.BackColor = System.Drawing.SystemColors.Control;
		this.buttonStopLogin.Location = new System.Drawing.Point(73, 77);
		this.buttonStopLogin.Name = "buttonStopLogin";
		this.buttonStopLogin.Size = new System.Drawing.Size(60, 36);
		this.buttonStopLogin.TabIndex = 390;
		this.buttonStopLogin.Text = "Dừng lại";
		this.buttonStopLogin.UseVisualStyleBackColor = false;
		this.buttonStopLogin.Click += new System.EventHandler(buttonStopLogin_Click);
		this.buttonLogin.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonLogin.Location = new System.Drawing.Point(3, 77);
		this.buttonLogin.Name = "buttonLogin";
		this.buttonLogin.Size = new System.Drawing.Size(67, 36);
		this.buttonLogin.TabIndex = 185;
		this.buttonLogin.Text = "Login";
		this.buttonLogin.UseVisualStyleBackColor = false;
		this.buttonLogin.Click += new System.EventHandler(buttonLogin_Click);
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage3);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Controls.Add(this.tabPageAutoVLBS);
		this.tabControl1.Controls.Add(this.tabPage4);
		this.tabControl1.Location = new System.Drawing.Point(0, 193);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(347, 143);
		this.tabControl1.TabIndex = 180;
		this.tabPage4.Controls.Add(this.txtFilePath);
		this.tabPage4.Controls.Add(this.btnBrowse);
		this.tabPage4.Controls.Add(this.label7);
		this.tabPage4.Controls.Add(this.comboBox1);
		this.tabPage4.Controls.Add(this.taonhanvat);
		this.tabPage4.Location = new System.Drawing.Point(4, 22);
		this.tabPage4.Name = "tabPage4";
		this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage4.Size = new System.Drawing.Size(339, 117);
		this.tabPage4.TabIndex = 6;
		this.tabPage4.Text = "Tạo Nhân Vật";
		this.tabPage4.UseVisualStyleBackColor = true;
		this.tabPage4.Click += new System.EventHandler(tabPage4_Click);
		this.txtFilePath.Location = new System.Drawing.Point(75, 7);
		this.txtFilePath.Name = "txtFilePath";
		this.txtFilePath.Size = new System.Drawing.Size(87, 20);
		this.txtFilePath.TabIndex = 4;
		this.txtFilePath.TextChanged += new System.EventHandler(txtFilePath_TextChanged);
		this.btnBrowse.Location = new System.Drawing.Point(6, 7);
		this.btnBrowse.Name = "btnBrowse";
		this.btnBrowse.Size = new System.Drawing.Size(63, 20);
		this.btnBrowse.TabIndex = 3;
		this.btnBrowse.Text = "Tên NV";
		this.btnBrowse.UseVisualStyleBackColor = true;
		this.btnBrowse.Click += new System.EventHandler(btnBrowse_Click);
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(6, 41);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(62, 13);
		this.label7.TabIndex = 2;
		this.label7.Text = "Ngũ Hành :";
		this.label7.Click += new System.EventHandler(label7_Click);
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Items.AddRange(new object[5] { "Kim", "Mộc", "Thủy", "Hỏa", "Thổ" });
		this.comboBox1.Location = new System.Drawing.Point(74, 38);
		this.comboBox1.Name = "comboBox1";
		this.comboBox1.Size = new System.Drawing.Size(87, 21);
		this.comboBox1.TabIndex = 1;
		this.comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
		this.taonhanvat.Location = new System.Drawing.Point(226, 58);
		this.taonhanvat.Name = "taonhanvat";
		this.taonhanvat.Size = new System.Drawing.Size(102, 25);
		this.taonhanvat.TabIndex = 0;
		this.taonhanvat.Text = "Tạo nhân vật";
		this.taonhanvat.UseVisualStyleBackColor = true;
		this.taonhanvat.Click += new System.EventHandler(taonhanvat_Click);
		this.linkLabel2.AutoSize = true;
		this.linkLabel2.Location = new System.Drawing.Point(240, 52);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new System.Drawing.Size(67, 13);
		this.linkLabel2.TabIndex = 399;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "video chi tiết";
		this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(344, 335);
		base.Controls.Add(this.buttonXuong);
		base.Controls.Add(this.linkLabelCheckAll);
		base.Controls.Add(this.buttonLen);
		base.Controls.Add(this.textBoxTimer);
		base.Controls.Add(this.labelStatus);
		base.Controls.Add(this.tabControl1);
		base.Controls.Add(this.textBoxStatus);
		base.Controls.Add(this.listView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormLogin";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "LOGIN";
		base.Load += new System.EventHandler(FormLogin_Load);
		this.tabPageAutoVLBS.ResumeLayout(false);
		this.tabPageAutoVLBS.PerformLayout();
		this.tabPage2.ResumeLayout(false);
		this.tabPage2.PerformLayout();
		this.tabPage3.ResumeLayout(false);
		this.tabPage3.PerformLayout();
		this.tabPage1.ResumeLayout(false);
		this.tabPage1.PerformLayout();
		this.tabControl1.ResumeLayout(false);
		this.tabPage4.ResumeLayout(false);
		this.tabPage4.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void taonhanvat_Click(object sender, EventArgs e)
	{
		if (bool_1 == null && gstruct0_0 != null)
		{
			bool_1 = new bool[gstruct0_0.Length];
			string_1 = new string[gstruct0_0.Length];
			for (int i = 0; i < string_1.Length; i++)
			{
				string_1[i] = "Kim";
			}
		}
		object selectedItem = comboBox1.SelectedItem;
		object obj;
		if (selectedItem == null)
		{
			obj = null;
		}
		else
		{
			string obj2 = selectedItem.ToString();
			if (obj2 == null)
			{
				obj = null;
			}
			else
			{
				obj = obj2.Trim();
				if (obj != null)
				{
					goto IL_0084;
				}
			}
		}
		obj = "Kim";
		goto IL_0084;
		IL_0084:
		string text = (string)obj;
		Class48.bool_1 = true;
		Thread.Sleep(100);
		bool flag = false;
		for (int j = 0; j < listView1.Items.Count; j++)
		{
			if (listView1.Items[j].Checked)
			{
				flag = true;
				if (j < bool_1.Length)
				{
					bool_1[j] = true;
					string_1[j] = text;
				}
				Class11.smethod_38(ref Class48.int_0, j);
			}
		}
		if (flag)
		{
			Class48.bool_1 = false;
			textBoxStatus.Text = "Đã thêm các tài khoản vào queue tạo nhân vật với hệ " + text + ".";
			return;
		}
		int num = -1;
		for (int k = 0; k < listView1.Items.Count; k++)
		{
			if (listView1.Items[k].Selected)
			{
				num = k;
				break;
			}
		}
		if (0 <= num)
		{
			if (num < bool_1.Length)
			{
				bool_1[num] = true;
				string_1[num] = text;
			}
			Class11.smethod_38(ref Class48.int_0, num);
			textBoxStatus.Text = "Đã thêm tài khoản vào queue tạo nhân vật với hệ " + text + ".";
		}
		else
		{
			textBoxStatus.Text = "Vui lòng chọn tài khoản để tạo nhân vật!";
		}
		Class48.bool_1 = false;
	}

	private void method_8(object sender, EventArgs e)
	{
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		object selectedItem = comboBox1.SelectedItem;
		object obj;
		if (selectedItem == null)
		{
			obj = null;
		}
		else
		{
			string obj2 = selectedItem.ToString();
			if (obj2 == null)
			{
				obj = null;
			}
			else
			{
				obj = obj2.Trim();
				if (obj != null)
				{
					goto IL_002c;
				}
			}
		}
		obj = "Kim";
		goto IL_002c;
		IL_002c:
		string text = (string)obj;
		textBoxStatus.Text = "Đã chọn hệ: " + text;
	}

	private void comboBoxNhanVat_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void tabPage4_Click(object sender, EventArgs e)
	{
	}

	private void label7_Click(object sender, EventArgs e)
	{
	}

	private void btnBrowse_Click(object sender, EventArgs e)
	{
		using OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = "C:\\";
		openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
		openFileDialog.FilterIndex = 1;
		openFileDialog.RestoreDirectory = true;
		openFileDialog.Title = "Chọn file tên nhân vật";
		if (openFileDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		txtFilePath.Text = openFileDialog.FileName;
		string_2 = openFileDialog.FileName;
		try
		{
			string text = smethod_5(openFileDialog.FileName);
			if (!string.IsNullOrEmpty(text))
			{
				textBoxStatus.Text = "File đã chọn - Dòng đầu: " + text;
			}
			else
			{
				textBoxStatus.Text = "File trống hoặc không đọc được.";
			}
		}
		catch (Exception ex)
		{
			textBoxStatus.Text = "Lỗi đọc file: " + ex.Message;
		}
	}

	public static string smethod_5(string string_7)
	{
		return smethod_1(string_7, 1);
	}

	public static int smethod_6(string string_7)
	{
		try
		{
			if (File.Exists(string_7))
			{
				return File.ReadAllLines(string_7, Encoding.UTF8).Length;
			}
			return 0;
		}
		catch
		{
			return 0;
		}
	}

	public static bool smethod_7(uint uint_1, string string_7)
	{
		try
		{
			if (string.IsNullOrEmpty(string_7))
			{
				return false;
			}
			Class24.SetForegroundWindow(uint_1);
			Thread.Sleep(200);
			foreach (char char_ in string_7)
			{
				short num = Class24.VkKeyScan(char_);
				byte byte_ = (byte)(num & 0xFF);
				byte b = (byte)((num >> 8) & 0xFF);
				if ((b & 1) != 0)
				{
					Class24.keybd_event(16, 0, 0, 0);
				}
				Class24.keybd_event(byte_, 0, 0, 0);
				Thread.Sleep(30);
				Class24.keybd_event(byte_, 0, 2, 0);
				Thread.Sleep(30);
				if ((b & 1) != 0)
				{
					Class24.keybd_event(16, 0, 2, 0);
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			MessageBox.Show("Lỗi gửi text: " + ex.Message);
			return false;
		}
	}

	public static void smethod_8()
	{
		try
		{
			string[] array = new string[3] { "tbtauto", "AutoVLBS 1.9", "AutoVLBS 2.6" };
			for (int i = 0; i < array.Length; i++)
			{
				try
				{
					uint num = (uint)Class24.FindWindow(null, array[i]);
					if (num != 0)
					{
						uint num2 = smethod_9(num, "SysListView32", 4);
						if (num2 != 0)
						{
							Class24.PostMessageA_1(num2, Class24.int_36, 1u, 2293772u);
							Thread.Sleep(20);
							Class24.PostMessageA_1(num2, Class24.int_37, 0u, 2293772u);
							Thread.Sleep(20);
						}
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	private static uint smethod_9(uint uint_1, string string_7, int int_14)
	{
		int int_15 = 0;
		return smethod_10(uint_1, string_7, int_14, ref int_15);
	}

	private static uint smethod_10(uint uint_1, string string_7, int int_14, ref int int_15)
	{
		uint num = 0u;
		int num2 = 0;
		uint num3;
		while (true)
		{
			num = Class24.FindWindowEx(uint_1, num, null, null);
			if (num != 0)
			{
				StringBuilder stringBuilder = new StringBuilder(256);
				Class24.GetClassName(num, stringBuilder, 256);
				string text = stringBuilder.ToString();
				if (text == string_7)
				{
					int_15++;
					if (int_15 == int_14)
					{
						return num;
					}
				}
				num3 = smethod_10(num, string_7, int_14, ref int_15);
				if (num3 != 0)
				{
					break;
				}
				num2++;
				if (num2 <= 10000)
				{
					continue;
				}
			}
			return 0u;
		}
		return num3;
	}

	private void txtFilePath_TextChanged(object sender, EventArgs e)
	{
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_12 = Convert.ToByte(checkBox1.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagAccDll", int_12, "", 0);
			if (checkBox1.Checked)
			{
				textBoxStatus.Text = "Sẽ chạy thao tác AutoIT sau khi login xong";
			}
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		try
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string text = Path.Combine(baseDirectory, "Auto_VLBS");
			string text2 = Path.Combine(text, "TBT_VLBS.exe");
			if (!File.Exists(text2))
			{
				textBoxStatus.Text = "Không tìm thấy Auto_VLBS\\TBT_VLBS.exe";
				return;
			}
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = text2;
			processStartInfo.WorkingDirectory = text;
			processStartInfo.UseShellExecute = true;
			Process.Start(processStartInfo);
			textBoxStatus.Text = "Đã mở Auto VLBS.";
		}
		catch (Exception ex)
		{
			textBoxStatus.Text = "Lỗi mở Auto VLBS: " + ex.Message;
		}
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string fileName = "https://www.facebook.com/share/v/1BtV5wmSFg/";
		Process.Start(fileName);
	}
}
