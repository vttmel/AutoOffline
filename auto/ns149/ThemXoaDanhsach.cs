using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns146;
using ns23;
using ns53;

namespace ns149;

public class ThemXoaDanhsach : Form
{
	public static bool bool_0 = false;

	public static int[] int_0 = null;

	public static int[] int_1 = null;

	private GStruct29[] gstruct29_0 = null;

	private GStruct29[] gstruct29_1 = null;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	private int int_6 = -1;

	private int int_7 = -1;

	private bool bool_1 = false;

	private IContainer icontainer_0 = null;

	private IContainer icontainer_1;

	private Button buttonAddAll;

	private Button buttonTrave;

	private Button buttonDemqua;

	private Button buttonXoatatca;

	private Button buttonClose;

	private Button buttonStickAll;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ListView listView2;

	private ColumnHeader columnHeader_1;

	private Label labelThongtin;

	private System.Windows.Forms.Timer timer_0;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private ListView listViewOff;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private Button buttonXoahet;

	private Button buttonXoa;

	private Label label1;

	public ThemXoaDanhsach()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	private void ThemXoaDanhsach_Load(object sender, EventArgs e)
	{
		if (int_2 >= 0 && int_3 >= 0)
		{
			int num = int_2 - base.Width;
			int num2 = int_3;
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
		bool_1 = false;
		if (Class56.bool_1)
		{
			new Thread(method_0).Start();
		}
		if (Form1.string_26 != null && Form1.string_26.Length != 0)
		{
			for (int i = 0; i < Form1.string_26.Length; i++)
			{
				method_1(listViewOff, Form1.string_26[i]);
			}
			listViewOff.Items[0].Selected = true;
			listViewOff.Items[0].Focused = true;
		}
		int int_ = 0;
		byte[] array = new byte[2];
		Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_1 * 4, array, 2, ref int_);
		buttonStickAll.Enabled = array[1] <= 0 || array[0] > 0;
		timer_0.Interval = 1;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		if (gstruct29_0 != null)
		{
			for (int i = 0; i < gstruct29_0.Length; i++)
			{
				Class24.smethod_32(gstruct29_0[i].int_1);
			}
		}
		if (gstruct29_1 != null)
		{
			for (int j = 0; j < gstruct29_1.Length; j++)
			{
				Class24.smethod_32(gstruct29_1[j].int_1);
			}
		}
		bool_0 = false;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
			return;
		}
		if (bool_1)
		{
			bool_1 = false;
			listView1.Items.Clear();
			listView2.Items.Clear();
			if (gstruct29_0 != null)
			{
				for (int i = 0; i < gstruct29_0.Length; i++)
				{
					method_2(listView1, gstruct29_0[i]);
				}
				method_3(listView1);
			}
			if (gstruct29_1 != null)
			{
				for (int j = 0; j < gstruct29_1.Length; j++)
				{
					method_2(listView2, gstruct29_1[j]);
				}
				method_3(listView2);
			}
			timer_0.Interval = 300;
		}
		int num = 0;
		int num2 = 0;
		if (gstruct29_0 != null)
		{
			num = gstruct29_0.Length;
		}
		if (gstruct29_1 != null)
		{
			num2 = gstruct29_1.Length;
		}
		string text = "Tổng có " + (num + num2) + " nhân vật (trái: " + num + "; phải: " + num2 + ") | Limit " + GClass1.int_7;
		if (labelThongtin.Text != text)
		{
			labelThongtin.Text = text;
		}
	}

	private void method_0()
	{
		gstruct29_1 = null;
		if (Form1.characterAccountConfig_1 != null && Form1.characterAccountConfig_1.Length != 0)
		{
			gstruct29_1 = new GStruct29[Form1.characterAccountConfig_1.Length];
			for (int i = 0; i < gstruct29_1.Length; i++)
			{
				gstruct29_1[i].int_0 = Form1.characterAccountConfig_1[i].int_136;
				gstruct29_1[i].int_1 = Class24.OpenProcess(2035711, bool_0: false, gstruct29_1[i].int_0);
				gstruct29_1[i].string_0 = Form1.characterAccountConfig_1[i].string_22;
			}
		}
		int int_ = 0;
		byte[] array = new byte[1];
		Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_4 * 4, array, 1, ref int_);
		int[] array2 = Class24.smethod_24(Class56.string_21);
		if (array2 != null && array[0] <= 0)
		{
			for (int j = 0; j < array2.Length; j++)
			{
				try
				{
					int num = array2[j];
					if (gstruct29_1 != null)
					{
						for (int k = 0; k < gstruct29_1.Length; k++)
						{
							if (num == gstruct29_1[k].int_0)
							{
								num = 0;
								break;
							}
						}
					}
					if (num != 0)
					{
						int num2 = Class24.OpenProcess(2035711, bool_0: false, num);
						uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, num2);
						uint num4 = Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_13.uint_0, num2) * Class56.memorySignatureScanConfig_15.uint_0;
						uint num5 = num4 + Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, num2);
						string text = Class24.smethod_28(num5 + Class56.memorySignatureScanConfig_16.uint_0, num2, 32);
						if (!(text == string.Empty) && text.Length >= 6)
						{
							smethod_0(ref gstruct29_0, num, num2, text);
						}
					}
				}
				catch
				{
				}
			}
			bool_1 = true;
		}
		else
		{
			bool_1 = true;
		}
	}

	private static void smethod_0(ref GStruct29[] gstruct29_2, int int_8, int int_9, string string_0)
	{
		GStruct29 gStruct = new GStruct29
		{
			int_0 = int_8,
			int_1 = int_9,
			string_0 = string_0
		};
		if (gstruct29_2 != null && gstruct29_2.Length != 0)
		{
			GStruct29[] array = new GStruct29[gstruct29_2.Length + 1];
			int num = 0;
			while (true)
			{
				if (num < gstruct29_2.Length)
				{
					ref GStruct29 reference = ref array[num];
					reference = gstruct29_2[num];
					if (array[num].int_0 == int_8)
					{
						break;
					}
					num++;
					continue;
				}
				array[array.Length - 1] = gStruct;
				gstruct29_2 = array;
				return;
			}
			gstruct29_2[num] = gStruct;
		}
		else
		{
			gstruct29_2 = new GStruct29[1] { gStruct };
		}
	}

	private static void smethod_1(ref GStruct29[] gstruct29_2, int int_8)
	{
		if (gstruct29_2 != null && gstruct29_2.Length != 0)
		{
			int num = 0;
			GStruct29[] array = new GStruct29[gstruct29_2.Length];
			for (int i = 0; i < gstruct29_2.Length; i++)
			{
				if (gstruct29_2[i].int_0 != int_8)
				{
					ref GStruct29 reference = ref array[num];
					reference = gstruct29_2[i];
					num++;
				}
			}
			if (num == 0)
			{
				gstruct29_2 = null;
				return;
			}
			GStruct29[] array2 = new GStruct29[num];
			for (int j = 0; j < num; j++)
			{
				ref GStruct29 reference2 = ref array2[j];
				reference2 = array[j];
			}
			gstruct29_2 = array2;
		}
		else
		{
			gstruct29_2 = null;
		}
	}

	private static int smethod_2(GStruct29[] gstruct29_2, int int_8)
	{
		if (gstruct29_2 != null && gstruct29_2.Length != 0 && int_8 != 0)
		{
			int num = 0;
			while (true)
			{
				if (num < gstruct29_2.Length)
				{
					if (gstruct29_2[num].int_0 == int_8)
					{
						break;
					}
					num++;
					continue;
				}
				return -1;
			}
			return num;
		}
		return -1;
	}

	private static int smethod_3(GStruct29[] gstruct29_2, ListView listView_0, int int_8)
	{
		if (gstruct29_2 != null && listView_0.Items != null && int_8 >= 0 && int_8 < listView_0.Items.Count)
		{
			int num = Class11.smethod_11(listView_0.Items[int_8].SubItems[listView_0.Items[int_8].SubItems.Count - 1].Text);
			int num2 = 0;
			while (true)
			{
				if (num2 < gstruct29_2.Length)
				{
					if (num == gstruct29_2[num2].int_0)
					{
						break;
					}
					num2++;
					continue;
				}
				return -1;
			}
			return num2;
		}
		return -1;
	}

	private static int smethod_4(ListView listView_0, int int_8)
	{
		if (listView_0.Items != null && listView_0.Items.Count != 0)
		{
			int index = listView_0.Items[0].SubItems.Count - 1;
			int num = 0;
			while (true)
			{
				if (num < listView_0.Items.Count)
				{
					if (int_8 == Class11.smethod_11(listView_0.Items[num].SubItems[index].Text))
					{
						break;
					}
					num++;
					continue;
				}
				return -1;
			}
			return num;
		}
		return -1;
	}

	private void method_1(ListView listView_0, string string_0)
	{
		try
		{
			string text = "1";
			if (listView_0.Items != null && listView_0.Items.Count > 0)
			{
				text = (listView_0.Items.Count + 1).ToString();
			}
			string[] array = new string[2]
			{
				text,
				Class1.smethod_1(string_0, 1)
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
			listView_0.Items.Add(listViewItem);
		}
		catch
		{
		}
	}

	private void method_2(ListView listView_0, GStruct29 gstruct29_2)
	{
		try
		{
			string[] array = new string[2]
			{
				Class1.smethod_1(gstruct29_2.string_0, 1),
				gstruct29_2.int_0.ToString()
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
			listView_0.Items.Add(listViewItem);
		}
		catch
		{
		}
	}

	private void method_3(ListView listView_0)
	{
		for (int i = 0; i < listView_0.Items.Count; i++)
		{
			if (Form1.string_22 == listView_0.Items[i].SubItems[0].Text || Form1.string_22 == Class1.smethod_1(listView_0.Items[i].SubItems[1].Text, 1))
			{
				listView_0.Items[i].ForeColor = Color.Blue;
			}
		}
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView1.Items != null)
		{
			for (int i = 0; i < listView1.Items.Count; i++)
			{
				if (listView1.Items[i].Selected)
				{
					int_6 = i;
					return;
				}
			}
		}
		int_6 = -1;
	}

	private void listView2_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView2.Items != null)
		{
			for (int i = 0; i < listView2.Items.Count; i++)
			{
				if (listView2.Items[i].Selected)
				{
					int_7 = i;
					return;
				}
			}
		}
		int_6 = -1;
	}

	private void buttonDemqua_Click(object sender, EventArgs e)
	{
		if (int_6 < 0 || (gstruct29_0 != null && listView2.Items.Count >= GClass1.int_7))
		{
			return;
		}
		int num = smethod_3(gstruct29_0, listView1, int_6);
		if (num >= 0)
		{
			labelThongtin.Text = "Thông tin:...";
			if (Class24.smethod_51(gstruct29_0[num].int_0))
			{
				smethod_0(ref gstruct29_1, gstruct29_0[num].int_0, gstruct29_0[num].int_1, gstruct29_0[num].string_0);
			}
			Class11.smethod_38(ref int_0, gstruct29_0[num].int_0);
			int num2 = smethod_2(gstruct29_1, gstruct29_0[num].int_0);
			smethod_1(ref gstruct29_0, gstruct29_0[num].int_0);
			listView1.Items.RemoveAt(int_6);
			if (num2 >= 0)
			{
				method_2(listView2, gstruct29_1[num2]);
				method_3(listView2);
			}
		}
	}

	private void buttonTrave_Click(object sender, EventArgs e)
	{
		if (int_7 < 0)
		{
			return;
		}
		int num = smethod_3(gstruct29_1, listView2, int_7);
		if (num >= 0)
		{
			if (Class24.smethod_51(gstruct29_1[num].int_0))
			{
				smethod_0(ref gstruct29_0, gstruct29_1[num].int_0, gstruct29_1[num].int_1, gstruct29_1[num].string_0);
			}
			Class11.smethod_38(ref int_1, gstruct29_1[num].int_0);
			int num2 = smethod_2(gstruct29_0, gstruct29_1[num].int_0);
			smethod_1(ref gstruct29_1, gstruct29_1[num].int_0);
			listView2.Items.RemoveAt(int_7);
			if (num2 >= 0)
			{
				method_2(listView1, gstruct29_0[num2]);
				method_3(listView1);
			}
		}
	}

	private void buttonAddAll_Click(object sender, EventArgs e)
	{
		int[] array = null;
		labelThongtin.Text = "Thông tin: ...";
		while (gstruct29_0 != null && gstruct29_0.Length != 0 && (gstruct29_0 == null || listView2.Items.Count < GClass1.int_7))
		{
			int num = smethod_4(listView1, gstruct29_0[0].int_0);
			if (0 <= num)
			{
				listView1.Items.RemoveAt(num);
			}
			if (Class24.smethod_51(gstruct29_0[0].int_0))
			{
				smethod_0(ref gstruct29_1, gstruct29_0[0].int_0, gstruct29_0[0].int_1, gstruct29_0[0].string_0);
			}
			Class11.smethod_38(ref array, gstruct29_0[0].int_0);
			int num2 = smethod_2(gstruct29_1, gstruct29_0[0].int_0);
			smethod_1(ref gstruct29_0, gstruct29_0[0].int_0);
			if (num2 >= 0)
			{
				method_2(listView2, gstruct29_1[num2]);
				method_3(listView2);
			}
		}
		int_0 = array;
	}

	private void buttonXoatatca_Click(object sender, EventArgs e)
	{
		int[] array = null;
		listView2.Items.Clear();
		while (gstruct29_1 != null && gstruct29_1.Length != 0)
		{
			if (Class24.smethod_51(gstruct29_1[0].int_0))
			{
				smethod_0(ref gstruct29_0, gstruct29_1[0].int_0, gstruct29_1[0].int_1, gstruct29_1[0].string_0);
			}
			Class11.smethod_38(ref array, gstruct29_1[0].int_0);
			int num = smethod_2(gstruct29_0, gstruct29_1[0].int_0);
			smethod_1(ref gstruct29_1, gstruct29_1[0].int_0);
			if (num >= 0)
			{
				method_2(listView1, gstruct29_0[num]);
				method_3(listView1);
			}
		}
		int_1 = array;
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		bool_0 = false;
		Close();
	}

	private void buttonStickAll_Click(object sender, EventArgs e)
	{
		Form1.int_138 = 0;
		Form1.bool_26 = true;
		bool_0 = false;
		Close();
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		if (listViewOff.Items.Count <= 0)
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < listViewOff.Items.Count; i++)
		{
			if (listViewOff.Items[i].Selected)
			{
				num = i;
				break;
			}
		}
		if (num < 0)
		{
			return;
		}
		string text = listViewOff.Items[num].SubItems[1].Text;
		listViewOff.Items.RemoveAt(num);
		if (Form1.string_26 != null && Form1.string_26.Length != 0)
		{
			for (int j = 0; j < Form1.string_26.Length; j++)
			{
				if (Class1.smethod_1(Form1.string_26[j], 1) == text)
				{
					text = Form1.string_26[j];
					Class11.smethod_30(ref Form1.string_26, text);
					break;
				}
			}
		}
		string text2 = string.Empty;
		if (Form1.string_26 != null && Form1.string_26.Length != 0)
		{
			for (int k = 0; k < Form1.string_26.Length; k++)
			{
				text2 = ((text2 != string.Empty) ? (text2 + "|" + Form1.string_26[k]) : Form1.string_26[k]);
			}
			text2 = Class11.smethod_16(text2);
		}
		Class11.smethod_34(Class56.string_13, text2, 1);
		if (listViewOff.Items != null && listViewOff.Items.Count > 0)
		{
			for (int l = 0; l < listViewOff.Items.Count; l++)
			{
				listViewOff.Items[l].SubItems[0].Text = (l + 1).ToString();
			}
			if (listViewOff.Items.Count <= num)
			{
				num--;
			}
			listViewOff.Items[num].Focused = true;
			listViewOff.Items[num].Selected = true;
		}
	}

	private void buttonXoahet_Click(object sender, EventArgs e)
	{
		if (listViewOff.Items != null && listViewOff.Items.Count > 0)
		{
			listViewOff.Items.Clear();
		}
		Form1.string_26 = null;
		Class11.smethod_20(Class56.string_13);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns149.ThemXoaDanhsach));
		this.buttonAddAll = new System.Windows.Forms.Button();
		this.buttonTrave = new System.Windows.Forms.Button();
		this.buttonDemqua = new System.Windows.Forms.Button();
		this.listView2 = new System.Windows.Forms.ListView();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_1);
		this.buttonXoatatca = new System.Windows.Forms.Button();
		this.buttonClose = new System.Windows.Forms.Button();
		this.labelThongtin = new System.Windows.Forms.Label();
		this.buttonStickAll = new System.Windows.Forms.Button();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.label1 = new System.Windows.Forms.Label();
		this.buttonXoahet = new System.Windows.Forms.Button();
		this.listViewOff = new System.Windows.Forms.ListView();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		this.buttonXoa = new System.Windows.Forms.Button();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.tabPage2.SuspendLayout();
		base.SuspendLayout();
		this.buttonAddAll.BackColor = System.Drawing.SystemColors.Control;
		this.buttonAddAll.ForeColor = System.Drawing.Color.Red;
		this.buttonAddAll.Location = new System.Drawing.Point(3, 185);
		this.buttonAddAll.Name = "buttonAddAll";
		this.buttonAddAll.Size = new System.Drawing.Size(129, 39);
		this.buttonAddAll.TabIndex = 16;
		this.buttonAddAll.Text = "Thêm tất cả";
		this.buttonAddAll.UseVisualStyleBackColor = false;
		this.buttonAddAll.Click += new System.EventHandler(buttonAddAll_Click);
		this.buttonTrave.BackColor = System.Drawing.SystemColors.Control;
		this.buttonTrave.ForeColor = System.Drawing.SystemColors.WindowText;
		this.buttonTrave.Location = new System.Drawing.Point(134, 155);
		this.buttonTrave.Name = "buttonTrave";
		this.buttonTrave.Size = new System.Drawing.Size(64, 30);
		this.buttonTrave.TabIndex = 13;
		this.buttonTrave.Text = "Xóa 1";
		this.buttonTrave.UseVisualStyleBackColor = false;
		this.buttonTrave.Click += new System.EventHandler(buttonTrave_Click);
		this.buttonDemqua.BackColor = System.Drawing.SystemColors.Control;
		this.buttonDemqua.ForeColor = System.Drawing.SystemColors.WindowText;
		this.buttonDemqua.Location = new System.Drawing.Point(3, 155);
		this.buttonDemqua.Name = "buttonDemqua";
		this.buttonDemqua.Size = new System.Drawing.Size(129, 30);
		this.buttonDemqua.TabIndex = 12;
		this.buttonDemqua.Text = "Thêm 1 ac";
		this.buttonDemqua.UseVisualStyleBackColor = false;
		this.buttonDemqua.Click += new System.EventHandler(buttonDemqua_Click);
		this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_1 });
		this.listView2.FullRowSelect = true;
		this.listView2.GridLines = true;
		this.listView2.HideSelection = false;
		this.listView2.Location = new System.Drawing.Point(135, 25);
		this.listView2.MultiSelect = false;
		this.listView2.Name = "listView2";
		this.listView2.Size = new System.Drawing.Size(131, 129);
		this.listView2.TabIndex = 10;
		this.listView2.UseCompatibleStateImageBehavior = false;
		this.listView2.View = System.Windows.Forms.View.Details;
		this.listView2.MouseUp += new System.Windows.Forms.MouseEventHandler(listView2_MouseUp);
		this.columnHeader_1.Text = "Nhân vật";
		this.columnHeader_1.Width = 105;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_0 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(2, 25);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(130, 129);
		this.listView1.TabIndex = 9;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.SelectedIndexChanged += new System.EventHandler(listView1_SelectedIndexChanged);
		this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		this.columnHeader_0.Text = "Nhân vật";
		this.columnHeader_0.Width = 105;
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonXoatatca.BackColor = System.Drawing.SystemColors.Control;
		this.buttonXoatatca.ForeColor = System.Drawing.Color.Red;
		this.buttonXoatatca.Location = new System.Drawing.Point(201, 155);
		this.buttonXoatatca.Name = "buttonXoatatca";
		this.buttonXoatatca.Size = new System.Drawing.Size(65, 30);
		this.buttonXoatatca.TabIndex = 17;
		this.buttonXoatatca.Text = "Xóa hết";
		this.buttonXoatatca.UseVisualStyleBackColor = false;
		this.buttonXoatatca.Click += new System.EventHandler(buttonXoatatca_Click);
		this.buttonClose.BackColor = System.Drawing.SystemColors.Control;
		this.buttonClose.ForeColor = System.Drawing.Color.DeepSkyBlue;
		this.buttonClose.Location = new System.Drawing.Point(135, 189);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(130, 74);
		this.buttonClose.TabIndex = 18;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = false;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.labelThongtin.AutoSize = true;
		this.labelThongtin.ForeColor = System.Drawing.Color.Black;
		this.labelThongtin.Location = new System.Drawing.Point(5, 5);
		this.labelThongtin.Name = "labelThongtin";
		this.labelThongtin.Size = new System.Drawing.Size(80, 15);
		this.labelThongtin.TabIndex = 19;
		this.labelThongtin.Text = "Thông tin acc";
		this.buttonStickAll.BackColor = System.Drawing.SystemColors.Control;
		this.buttonStickAll.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.buttonStickAll.ForeColor = System.Drawing.Color.Red;
		this.buttonStickAll.Location = new System.Drawing.Point(2, 223);
		this.buttonStickAll.Name = "buttonStickAll";
		this.buttonStickAll.Size = new System.Drawing.Size(130, 43);
		this.buttonStickAll.TabIndex = 158;
		this.buttonStickAll.Text = "Stick tất cả";
		this.buttonStickAll.UseVisualStyleBackColor = false;
		this.buttonStickAll.Click += new System.EventHandler(buttonStickAll_Click);
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Location = new System.Drawing.Point(1, 0);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(279, 295);
		this.tabControl1.TabIndex = 159;
		this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
		this.tabPage1.Controls.Add(this.buttonStickAll);
		this.tabPage1.Controls.Add(this.buttonClose);
		this.tabPage1.Controls.Add(this.buttonAddAll);
		this.tabPage1.Controls.Add(this.labelThongtin);
		this.tabPage1.Controls.Add(this.buttonDemqua);
		this.tabPage1.Controls.Add(this.buttonTrave);
		this.tabPage1.Controls.Add(this.buttonXoatatca);
		this.tabPage1.Controls.Add(this.listView1);
		this.tabPage1.Controls.Add(this.listView2);
		this.tabPage1.Location = new System.Drawing.Point(4, 24);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(271, 267);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Ac đang online";
		this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
		this.tabPage2.Controls.Add(this.label1);
		this.tabPage2.Controls.Add(this.buttonXoahet);
		this.tabPage2.Controls.Add(this.listViewOff);
		this.tabPage2.Controls.Add(this.buttonXoa);
		this.tabPage2.Location = new System.Drawing.Point(4, 24);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(271, 267);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "Ac offline hoặc bị diss";
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(5, 5);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(224, 15);
		this.label1.TabIndex = 160;
		this.label1.Text = "Các ac bị diss hoặc thoát được lưu ở đây";
		this.buttonXoahet.BackColor = System.Drawing.SystemColors.Control;
		this.buttonXoahet.ForeColor = System.Drawing.Color.Red;
		this.buttonXoahet.Location = new System.Drawing.Point(139, 197);
		this.buttonXoahet.Name = "buttonXoahet";
		this.buttonXoahet.Size = new System.Drawing.Size(124, 63);
		this.buttonXoahet.TabIndex = 161;
		this.buttonXoahet.Text = "Xóa hết";
		this.buttonXoahet.UseVisualStyleBackColor = false;
		this.buttonXoahet.Click += new System.EventHandler(buttonXoahet_Click);
		this.listViewOff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader_2, this.columnHeader_3 });
		this.listViewOff.FullRowSelect = true;
		this.listViewOff.GridLines = true;
		this.listViewOff.HideSelection = false;
		this.listViewOff.Location = new System.Drawing.Point(2, 29);
		this.listViewOff.MultiSelect = false;
		this.listViewOff.Name = "listViewOff";
		this.listViewOff.Size = new System.Drawing.Size(265, 162);
		this.listViewOff.TabIndex = 160;
		this.listViewOff.UseCompatibleStateImageBehavior = false;
		this.listViewOff.View = System.Windows.Forms.View.Details;
		this.columnHeader_2.Text = "STT";
		this.columnHeader_2.Width = 40;
		this.columnHeader_3.Text = "Nhân vật";
		this.columnHeader_3.Width = 165;
		this.buttonXoa.BackColor = System.Drawing.SystemColors.Control;
		this.buttonXoa.Location = new System.Drawing.Point(2, 197);
		this.buttonXoa.Name = "buttonXoa";
		this.buttonXoa.Size = new System.Drawing.Size(131, 63);
		this.buttonXoa.TabIndex = 160;
		this.buttonXoa.Text = "Xóa";
		this.buttonXoa.UseVisualStyleBackColor = false;
		this.buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.LightSteelBlue;
		base.ClientSize = new System.Drawing.Size(276, 296);
		base.Controls.Add(this.tabControl1);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "ThemXoaDanhsach";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "DANH SACH";
		base.Load += new System.EventHandler(ThemXoaDanhsach_Load);
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage1.PerformLayout();
		this.tabPage2.ResumeLayout(false);
		this.tabPage2.PerformLayout();
		base.ResumeLayout(false);
	}

	private void listView1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}
}
