using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns53;
using ns81;
using ns83;

namespace ns135;

public class FormThuocLag : Form
{
	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static int int_1 = -1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	private int int_6 = -1;

	private static bool bool_1 = false;

	private static CharacterAccountConfig characterAccountConfig_0 = default(CharacterAccountConfig);

	private static string[] string_0 = null;

	private IContainer icontainer_0 = null;

	private ComboBox comboBoxTenTuiMauHotro;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private Button buttonThem;

	private Button buttonXoa;

	private Button buttonClose;

	private Timer timer_0;

	private Button buttonAppAll;

	public FormThuocLag()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (0 <= num)
		{
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		}
		int_2 = 0;
		int_3 = 0;
		int_1 = -1;
		int_0 = 0;
		bool_0 = false;
	}

	private void FormThuocLag_Load(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			Close();
			return;
		}
		characterAccountConfig_0 = Form1.characterAccountConfig_1[num];
		if (int_2 > 0 && int_3 > 0)
		{
			int num2 = int_2 - base.Width - 10;
			int num3 = int_3 - base.Height - 10;
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
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		bool_1 = true;
		base.TopMost = true;
	}

	private void method_0(string[] string_1)
	{
		listView1.Items.Clear();
		if (string_1 != null && string_1.Length != 0)
		{
			for (int i = 0; i < string_1.Length; i++)
			{
				method_1(listView1, Class1.smethod_1(string_1[i], 1));
			}
		}
		int_6 = -1;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (int_1 != int_0)
			{
				int_1 = int_0;
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
				if (num >= 0)
				{
					buttonThem.Enabled = true;
					listView1.Enabled = true;
					method_0(Form1.characterAccountConfig_1[num].string_6);
				}
				else
				{
					buttonThem.Enabled = false;
					listView1.Enabled = false;
				}
			}
		}
		else
		{
			Close();
		}
	}

	private void method_1(ListView listView_0, string string_1)
	{
		try
		{
			string[] array = new string[1] { string_1 };
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

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		int_6 = -1;
		if (listView1.Items == null || listView1.Items.Count == 0)
		{
			return;
		}
		string text = null;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				int_6 = i;
				text = listView1.Items[i].SubItems[0].Text;
				break;
			}
		}
		if (int_6 >= 0 && text != null && text != comboBoxTenTuiMauHotro.Text)
		{
			comboBoxTenTuiMauHotro.Items.Clear();
			comboBoxTenTuiMauHotro.Items.Add(text);
			comboBoxTenTuiMauHotro.Text = text;
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void comboBoxTenTuiMauHotro_MouseDown(object sender, MouseEventArgs e)
	{
		string_0 = Class85.smethod_34(characterAccountConfig_0);
		comboBoxTenTuiMauHotro.Items.Clear();
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				comboBoxTenTuiMauHotro.Items.Add(Class1.smethod_1(string_0[i], 1));
			}
		}
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || string_0 == null)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = null;
		string text2 = comboBoxTenTuiMauHotro.Text;
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
		if (Form1.characterAccountConfig_1[num].string_6 != null)
		{
			for (int j = 0; j < Form1.characterAccountConfig_1[num].string_6.Length; j++)
			{
				if (Form1.characterAccountConfig_1[num].string_6[j] == text)
				{
					return;
				}
			}
		}
		method_1(listView1, Class1.smethod_1(text, 1));
		Class11.smethod_29(ref Form1.characterAccountConfig_1[num].string_6, text);
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenTuiMauHotro.Text;
		if (Form1.characterAccountConfig_1[num].string_6 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1[num].string_6.Length; i++)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[num].string_6[i], 1) == text)
				{
					Class11.smethod_30(ref Form1.characterAccountConfig_1[num].string_6, Form1.characterAccountConfig_1[num].string_6[i]);
					break;
				}
			}
		}
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (text == listView1.Items[i].SubItems[0].Text)
			{
				listView1.Items.RemoveAt(i);
				break;
			}
		}
	}

	private void buttonAppAll_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0 || Form1.characterAccountConfig_1 == null)
		{
			return;
		}
		try
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Form1.characterAccountConfig_1[i].int_63 = 1;
				if (i == num)
				{
					continue;
				}
				Form1.characterAccountConfig_1[i].string_6 = null;
				if (Form1.characterAccountConfig_1[num].string_6 != null)
				{
					Form1.characterAccountConfig_1[i].string_6 = new string[Form1.characterAccountConfig_1[num].string_6.Length];
					for (int j = 0; j < Form1.characterAccountConfig_1[num].string_6.Length; j++)
					{
						Form1.characterAccountConfig_1[i].string_6[j] = Form1.characterAccountConfig_1[num].string_6[j];
					}
				}
				Class56.smethod_13(Form1.characterAccountConfig_1[i]);
			}
		}
		catch
		{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns135.FormThuocLag));
		this.comboBoxTenTuiMauHotro = new System.Windows.Forms.ComboBox();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.buttonThem = new System.Windows.Forms.Button();
		this.buttonXoa = new System.Windows.Forms.Button();
		this.buttonClose = new System.Windows.Forms.Button();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonAppAll = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.comboBoxTenTuiMauHotro.DropDownWidth = 252;
		this.comboBoxTenTuiMauHotro.FormattingEnabled = true;
		this.comboBoxTenTuiMauHotro.Location = new System.Drawing.Point(4, 222);
		this.comboBoxTenTuiMauHotro.Name = "comboBoxTenTuiMauHotro";
		this.comboBoxTenTuiMauHotro.Size = new System.Drawing.Size(252, 21);
		this.comboBoxTenTuiMauHotro.TabIndex = 217;
		this.comboBoxTenTuiMauHotro.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenTuiMauHotro_MouseDown);
		this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_0 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(4, 4);
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(252, 210);
		this.listView1.TabIndex = 218;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		this.columnHeader_0.Text = "Tên thuốc";
		this.columnHeader_0.Width = 230;
		this.buttonThem.Location = new System.Drawing.Point(85, 250);
		this.buttonThem.Name = "buttonThem";
		this.buttonThem.Size = new System.Drawing.Size(113, 23);
		this.buttonThem.TabIndex = 219;
		this.buttonThem.Text = "Thêm";
		this.buttonThem.UseVisualStyleBackColor = true;
		this.buttonThem.Click += new System.EventHandler(buttonThem_Click);
		this.buttonXoa.Location = new System.Drawing.Point(4, 250);
		this.buttonXoa.Name = "buttonXoa";
		this.buttonXoa.Size = new System.Drawing.Size(75, 23);
		this.buttonXoa.TabIndex = 220;
		this.buttonXoa.Text = "Xóa";
		this.buttonXoa.UseVisualStyleBackColor = true;
		this.buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		this.buttonClose.Location = new System.Drawing.Point(204, 261);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(52, 36);
		this.buttonClose.TabIndex = 222;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonAppAll.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonAppAll.Location = new System.Drawing.Point(4, 277);
		this.buttonAppAll.Name = "buttonAppAll";
		this.buttonAppAll.Size = new System.Drawing.Size(194, 26);
		this.buttonAppAll.TabIndex = 231;
		this.buttonAppAll.Text = "Áp dụng ăn thuốc lag cho tất cả ac";
		this.buttonAppAll.UseVisualStyleBackColor = true;
		this.buttonAppAll.Click += new System.EventHandler(buttonAppAll_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(261, 310);
		base.Controls.Add(this.buttonAppAll);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.buttonXoa);
		base.Controls.Add(this.buttonThem);
		base.Controls.Add(this.listView1);
		base.Controls.Add(this.comboBoxTenTuiMauHotro);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormThuocLag";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "THUOC LAG";
		base.Load += new System.EventHandler(FormThuocLag_Load);
		base.ResumeLayout(false);
	}
}
