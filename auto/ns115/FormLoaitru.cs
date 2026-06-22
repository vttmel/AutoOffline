using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns124;
using ns53;
using ns63;

namespace ns115;

public class FormLoaitru : Form
{
	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ComboBox comboBoxAcc;

	private Button buttonThem;

	private Button buttonXoa;

	private Label label1;

	private Timer timer_0;

	private Button buttonThoat;

	private Button buttonXoahet;

	private Button button1;

	public static bool bool_0 = false;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	private int int_4 = -1;

	public FormLoaitru()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns124.FormNhiepTT));
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.comboBoxAcc = new System.Windows.Forms.ComboBox();
		this.buttonThem = new System.Windows.Forms.Button();
		this.buttonXoa = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonThoat = new System.Windows.Forms.Button();
		this.buttonXoahet = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_0 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(3, 62);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(179, 183);
		this.listView1.TabIndex = 1;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(listView1_MouseClick);
		this.columnHeader_0.Text = "Nhân vật";
		this.columnHeader_0.Width = 146;
		this.comboBoxAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxAcc.FormattingEnabled = true;
		this.comboBoxAcc.Location = new System.Drawing.Point(61, 261);
		this.comboBoxAcc.Name = "comboBoxAcc";
		this.comboBoxAcc.Size = new System.Drawing.Size(121, 21);
		this.comboBoxAcc.TabIndex = 2;
		this.comboBoxAcc.DropDown += new System.EventHandler(comboBoxAcc_DropDown);
		this.buttonThem.Location = new System.Drawing.Point(3, 256);
		this.buttonThem.Name = "buttonThem";
		this.buttonThem.Size = new System.Drawing.Size(52, 28);
		this.buttonThem.TabIndex = 3;
		this.buttonThem.Text = "Thêm";
		this.buttonThem.UseVisualStyleBackColor = true;
		this.buttonThem.Click += new System.EventHandler(buttonThem_Click);
		this.buttonXoa.ForeColor = System.Drawing.Color.DarkBlue;
		this.buttonXoa.Location = new System.Drawing.Point(188, 127);
		this.buttonXoa.Name = "buttonXoa";
		this.buttonXoa.Size = new System.Drawing.Size(70, 38);
		this.buttonXoa.TabIndex = 4;
		this.buttonXoa.Text = "Xóa";
		this.buttonXoa.UseVisualStyleBackColor = true;
		this.buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		this.label1.Location = new System.Drawing.Point(3, 3);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(252, 45);
		this.label1.TabIndex = 5;
		this.label1.Text = "Những ac nằm trong danh sách này luôn ở chế độ KHÔNG tự vệ (không đánh), ví dụ ac nga my buff... chỉ dùng theo sau để buff hỗ trợ.";
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonThoat.Location = new System.Drawing.Point(188, 246);
		this.buttonThoat.Name = "buttonThoat";
		this.buttonThoat.Size = new System.Drawing.Size(70, 38);
		this.buttonThoat.TabIndex = 6;
		this.buttonThoat.Text = "Đóng";
		this.buttonThoat.UseVisualStyleBackColor = true;
		this.buttonThoat.Click += new System.EventHandler(buttonThoat_Click);
		this.buttonXoahet.Location = new System.Drawing.Point(188, 62);
		this.buttonXoahet.Name = "buttonXoahet";
		this.buttonXoahet.Size = new System.Drawing.Size(70, 38);
		this.buttonXoahet.TabIndex = 7;
		this.buttonXoahet.Text = "Xóa hết";
		this.buttonXoahet.UseVisualStyleBackColor = true;
		this.buttonXoahet.Click += new System.EventHandler(buttonXoahet_Click);
		this.button1.ForeColor = System.Drawing.Color.DarkRed;
		this.button1.Location = new System.Drawing.Point(188, 175);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(70, 38);
		this.button1.TabIndex = 8;
		this.button1.Text = "Thêm tất cả ac";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(263, 296);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.buttonXoahet);
		base.Controls.Add(this.buttonThoat);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.buttonXoa);
		base.Controls.Add(this.buttonThem);
		base.Controls.Add(this.comboBoxAcc);
		base.Controls.Add(this.listView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormLoaitru";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "Danh sach loai tru";
		base.Load += new System.EventHandler(FormLoaitru_Load);
		base.ResumeLayout(false);
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		string text = "";
		if (Class56.string_6 != null)
		{
			for (int i = 0; i < Class56.string_6.Length; i++)
			{
				if (!(Class56.string_6[i] != ""))
				{
					continue;
				}
				if (text != "")
				{
					text += "|";
				}
				text += Class56.string_6[i];
				if (Form1.characterAccountConfig_1 == null)
				{
					continue;
				}
				for (int j = 0; j < Form1.characterAccountConfig_1.Length; j++)
				{
					if (Class56.string_6[i] == Form1.characterAccountConfig_1[j].string_22)
					{
						Form1.characterAccountConfig_1[j].bool_22 = true;
						break;
					}
				}
			}
		}
		Class66.smethod_11(Class66.smethod_1(), Class56.string_5, Class11.smethod_16(text), "", 0);
		int_0 = 0;
		int_1 = 0;
		bool_0 = false;
	}

	private void FormLoaitru_Load(object sender, EventArgs e)
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
		if (Class56.string_6 != null && Class56.string_6.Length != 0)
		{
			for (int i = 0; i < Class56.string_6.Length; i++)
			{
				if (Class56.string_6[i] != "")
				{
					method_0(listView1, Class1.smethod_1(Class56.string_6[i], 1));
				}
			}
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		method_1("Danh sach loai tru");
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void method_0(ListView listView_0, string string_0)
	{
		try
		{
			ListViewItem value = new ListViewItem(string_0);
			listView_0.Items.Add(value);
		}
		catch
		{
		}
	}

	private void comboBoxAcc_DropDown(object sender, EventArgs e)
	{
		comboBoxAcc.Items.Clear();
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				bool flag = false;
				if (Class56.string_6 != null)
				{
					for (int j = 0; j < Class56.string_6.Length; j++)
					{
						if (Class56.string_6[j] == Form1.characterAccountConfig_1[i].string_22)
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					string item = Class1.smethod_1(Form1.characterAccountConfig_1[i].string_22, 1);
					comboBoxAcc.Items.Add(item);
				}
			}
		}
		comboBoxAcc.Text = "";
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (Form1.characterAccountConfig_1 == null || Form1.characterAccountConfig_1.Length == 0)
		{
			return;
		}
		string text = comboBoxAcc.Text;
		for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
		{
			if (!(Class1.smethod_1(Form1.characterAccountConfig_1[i].string_22, 1) == text))
			{
				continue;
			}
			bool flag = false;
			if (Class56.string_6 != null)
			{
				for (int j = 0; j < Class56.string_6.Length; j++)
				{
					if (Class56.string_6[j] == Form1.characterAccountConfig_1[i].string_22)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				Class11.smethod_29(ref Class56.string_6, Form1.characterAccountConfig_1[i].string_22);
				Form1.characterAccountConfig_1[i].bool_22 = true;
				method_0(listView1, Class1.smethod_1(Form1.characterAccountConfig_1[i].string_22, 1));
			}
			break;
		}
		comboBoxAcc.Items.Clear();
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		if (listView1.SelectedIndices == null || listView1.SelectedIndices.Count == 0)
		{
			return;
		}
		string text = listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[i].string_22, 1) == text)
				{
					Form1.characterAccountConfig_1[i].bool_22 = false;
					break;
				}
			}
		}
		for (int j = 0; j < listView1.Items.Count; j++)
		{
			if (listView1.Items[j].SubItems[0].Text == text)
			{
				listView1.Items.RemoveAt(j);
				break;
			}
		}
		if (Class56.string_6 != null)
		{
			for (int k = 0; k < Class56.string_6.Length; k++)
			{
				if (Class1.smethod_1(Class56.string_6[k], 1) == text)
				{
					Class11.smethod_30(ref Class56.string_6, Class56.string_6[k]);
					break;
				}
			}
		}
		comboBoxAcc.Items.Clear();
	}

	private void listView1_MouseClick(object sender, MouseEventArgs e)
	{
		int_4 = -1;
		if (listView1.Items == null)
		{
			return;
		}
		string text = comboBoxAcc.Text;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				int_4 = i;
				string text2 = listView1.Items[i].SubItems[0].Text;
				if (text != text2)
				{
					comboBoxAcc.Items.Clear();
					comboBoxAcc.Items.Add(text2);
					comboBoxAcc.Text = text2;
				}
				break;
			}
		}
	}

	private void buttonXoahet_Click(object sender, EventArgs e)
	{
		_ = comboBoxAcc.Text;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Form1.characterAccountConfig_1[i].bool_22 = false;
			}
		}
		Class56.string_6 = null;
		listView1.Items.Clear();
	}

	private void buttonThoat_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (Form1.characterAccountConfig_1 == null || Form1.characterAccountConfig_1.Length == 0)
		{
			return;
		}
		Class56.string_6 = null;
		listView1.Items.Clear();
		for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
		{
			string string_ = Form1.characterAccountConfig_1[i].string_22;
			if (string_ != null && !(string_ == string.Empty))
			{
				if (Class56.string_6 == null)
				{
					Class56.string_6 = new string[1];
				}
				else
				{
					Array.Resize(ref Class56.string_6, Class56.string_6.Length + 1);
				}
				Form1.characterAccountConfig_1[i].bool_22 = true;
				Class56.string_6[Class56.string_6.Length - 1] = string_;
				method_0(listView1, Class1.smethod_1(string_, 1));
			}
		}
	}

	private void method_1(string string_0)
	{
		base.Text = string_0;
	}
}
