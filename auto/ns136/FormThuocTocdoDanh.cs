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

namespace ns136;

public class FormThuocTocdoDanh : Form
{
	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static int int_1 = -1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

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

	private Label label1;

	private TextBox textBoxGiay;

	private Label label2;

	private Button buttonXoaThuong;

	private Button buttonThuong;

	private ListView listViewThuong;

	private ColumnHeader columnHeader_1;

	private ComboBox comboBoxThuong;

	public FormThuocTocdoDanh()
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

	private void FormThuocTocdoDanh_Load(object sender, EventArgs e)
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

	private void method_0(string[] string_1, string[] string_2)
	{
		listView1.Items.Clear();
		listViewThuong.Items.Clear();
		if (string_2 != null && string_2.Length != 0)
		{
			for (int i = 0; i < string_2.Length; i++)
			{
				method_1(listView1, Class1.smethod_1(string_2[i], 1));
			}
		}
		if (string_1 != null && string_1.Length != 0)
		{
			for (int j = 0; j < string_1.Length; j++)
			{
				method_1(listViewThuong, Class1.smethod_1(string_1[j], 1));
			}
		}
		textBoxGiay.Text = characterAccountConfig_0.int_64[2].ToString();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (int_1 != int_0)
			{
				int_1 = int_0;
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
				if (num < 0)
				{
					buttonThem.Enabled = false;
					listView1.Enabled = false;
				}
				else
				{
					buttonThem.Enabled = true;
					listView1.Enabled = true;
					method_0(Form1.characterAccountConfig_1[num].string_8, Form1.characterAccountConfig_1[num].string_7);
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
		if (Form1.characterAccountConfig_1[num].string_7 != null)
		{
			for (int j = 0; j < Form1.characterAccountConfig_1[num].string_7.Length; j++)
			{
				if (Form1.characterAccountConfig_1[num].string_7[j] == text)
				{
					return;
				}
			}
		}
		method_1(listView1, Class1.smethod_1(text, 1));
		Class11.smethod_29(ref Form1.characterAccountConfig_1[num].string_7, text);
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		if (listView1.SelectedIndices.Count == 0)
		{
			return;
		}
		int index = listView1.SelectedIndices[0];
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = listView1.Items[index].SubItems[0].Text;
		if (Form1.characterAccountConfig_1[num].string_7 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1[num].string_7.Length; i++)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[num].string_7[i], 1) == text)
				{
					Class11.smethod_30(ref Form1.characterAccountConfig_1[num].string_7, Form1.characterAccountConfig_1[num].string_7[i]);
					break;
				}
			}
		}
		listView1.Items.RemoveAt(index);
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
				if (i == num)
				{
					continue;
				}
				if (Form1.characterAccountConfig_1[num].string_7 != null && Form1.characterAccountConfig_1[num].string_7.Length != 0)
				{
					Form1.characterAccountConfig_1[i].string_7 = new string[Form1.characterAccountConfig_1[num].string_7.Length];
					for (int j = 0; j < Form1.characterAccountConfig_1[num].string_7.Length; j++)
					{
						Form1.characterAccountConfig_1[i].string_7[j] = Form1.characterAccountConfig_1[num].string_7[j];
					}
				}
				else
				{
					Form1.characterAccountConfig_1[i].string_7 = null;
				}
				if (Form1.characterAccountConfig_1[num].string_8 != null && Form1.characterAccountConfig_1[num].string_8.Length != 0)
				{
					Form1.characterAccountConfig_1[i].string_8 = new string[Form1.characterAccountConfig_1[num].string_8.Length];
					for (int k = 0; k < Form1.characterAccountConfig_1[num].string_8.Length; k++)
					{
						Form1.characterAccountConfig_1[i].string_8[k] = Form1.characterAccountConfig_1[num].string_8[k];
					}
				}
				else
				{
					Form1.characterAccountConfig_1[i].string_8 = null;
				}
				if (Form1.characterAccountConfig_1[num].int_64 != null)
				{
					if (Form1.characterAccountConfig_1[i].int_64 == null)
					{
						Form1.characterAccountConfig_1[i].int_64 = new int[Form1.characterAccountConfig_1[num].int_64.Length];
					}
					for (int l = 0; l < Form1.characterAccountConfig_1[num].int_64.Length; l++)
					{
						if (l != 1)
						{
							Form1.characterAccountConfig_1[i].int_64[l] = Form1.characterAccountConfig_1[num].int_64[l];
						}
					}
				}
				Class56.smethod_13(Form1.characterAccountConfig_1[i]);
			}
		}
		catch
		{
		}
	}

	private void textBoxGiay_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num >= 0)
		{
			int num2 = Class11.smethod_11(textBoxGiay.Text);
			if (num2 < 3)
			{
				num2 = 3;
			}
			Form1.characterAccountConfig_1[num].int_64[2] = num2;
		}
	}

	private void comboBoxThuong_MouseDown(object sender, MouseEventArgs e)
	{
		string_0 = Class85.smethod_34(characterAccountConfig_0);
		comboBoxThuong.Items.Clear();
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				comboBoxThuong.Items.Add(Class1.smethod_1(string_0[i], 1));
			}
		}
	}

	private void buttonThuong_Click(object sender, EventArgs e)
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
		string text2 = comboBoxThuong.Text;
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
		if (Form1.characterAccountConfig_1[num].string_8 != null)
		{
			for (int j = 0; j < Form1.characterAccountConfig_1[num].string_8.Length; j++)
			{
				if (Form1.characterAccountConfig_1[num].string_8[j] == text)
				{
					return;
				}
			}
		}
		method_1(listViewThuong, Class1.smethod_1(text, 1));
		Class11.smethod_29(ref Form1.characterAccountConfig_1[num].string_8, text);
	}

	private void buttonXoaThuong_Click(object sender, EventArgs e)
	{
		if (listViewThuong.SelectedIndices.Count == 0)
		{
			return;
		}
		int index = listViewThuong.SelectedIndices[0];
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			return;
		}
		string text = listViewThuong.Items[index].SubItems[0].Text;
		if (Form1.characterAccountConfig_1[num].string_8 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1[num].string_8.Length; i++)
			{
				if (Class1.smethod_1(Form1.characterAccountConfig_1[num].string_8[i], 1) == text)
				{
					Class11.smethod_30(ref Form1.characterAccountConfig_1[num].string_8, Form1.characterAccountConfig_1[num].string_8[i]);
					break;
				}
			}
		}
		listViewThuong.Items.RemoveAt(index);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns136.FormThuocTocdoDanh));
		this.comboBoxTenTuiMauHotro = new System.Windows.Forms.ComboBox();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.buttonThem = new System.Windows.Forms.Button();
		this.buttonXoa = new System.Windows.Forms.Button();
		this.buttonClose = new System.Windows.Forms.Button();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonAppAll = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.textBoxGiay = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.buttonXoaThuong = new System.Windows.Forms.Button();
		this.buttonThuong = new System.Windows.Forms.Button();
		this.listViewThuong = new System.Windows.Forms.ListView();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.comboBoxThuong = new System.Windows.Forms.ComboBox();
		base.SuspendLayout();
		this.comboBoxTenTuiMauHotro.DropDownWidth = 290;
		this.comboBoxTenTuiMauHotro.FormattingEnabled = true;
		this.comboBoxTenTuiMauHotro.Location = new System.Drawing.Point(3, 266);
		this.comboBoxTenTuiMauHotro.Name = "comboBoxTenTuiMauHotro";
		this.comboBoxTenTuiMauHotro.Size = new System.Drawing.Size(183, 21);
		this.comboBoxTenTuiMauHotro.TabIndex = 217;
		this.comboBoxTenTuiMauHotro.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenTuiMauHotro_MouseDown);
		this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_0 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(3, 154);
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(294, 107);
		this.listView1.TabIndex = 218;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "Tên thuốc (dùng trong Tống Kim)";
		this.columnHeader_0.Width = 250;
		this.buttonThem.Location = new System.Drawing.Point(193, 264);
		this.buttonThem.Name = "buttonThem";
		this.buttonThem.Size = new System.Drawing.Size(57, 23);
		this.buttonThem.TabIndex = 219;
		this.buttonThem.Text = "Thêm";
		this.buttonThem.UseVisualStyleBackColor = true;
		this.buttonThem.Click += new System.EventHandler(buttonThem_Click);
		this.buttonXoa.Location = new System.Drawing.Point(252, 264);
		this.buttonXoa.Name = "buttonXoa";
		this.buttonXoa.Size = new System.Drawing.Size(46, 23);
		this.buttonXoa.TabIndex = 220;
		this.buttonXoa.Text = "Xóa";
		this.buttonXoa.UseVisualStyleBackColor = true;
		this.buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		this.buttonClose.Location = new System.Drawing.Point(223, 342);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(75, 26);
		this.buttonClose.TabIndex = 222;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonAppAll.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonAppAll.Location = new System.Drawing.Point(4, 342);
		this.buttonAppAll.Name = "buttonAppAll";
		this.buttonAppAll.Size = new System.Drawing.Size(213, 26);
		this.buttonAppAll.TabIndex = 231;
		this.buttonAppAll.Text = "Áp dụng tên thuốc cho tất cả ac";
		this.buttonAppAll.UseVisualStyleBackColor = true;
		this.buttonAppAll.Click += new System.EventHandler(buttonAppAll_Click);
		this.label1.Location = new System.Drawing.Point(1, 5);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(297, 29);
		this.label1.TabIndex = 232;
		this.label1.Text = "Chức năng ăn thuốc khi bấm phím tắt thì thiết lập trong phần <Nhồi thuốc> của hậu cần. Còn phần này là ăn tự động.";
		this.textBoxGiay.Location = new System.Drawing.Point(252, 304);
		this.textBoxGiay.Name = "textBoxGiay";
		this.textBoxGiay.Size = new System.Drawing.Size(45, 20);
		this.textBoxGiay.TabIndex = 236;
		this.textBoxGiay.TextChanged += new System.EventHandler(textBoxGiay_TextChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(1, 298);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(236, 26);
		this.label2.TabIndex = 237;
		this.label2.Text = "Thời gian kiểm tra giữa 2 lần ăn thuốc (giây)\r\nNếu bị mis thì sẽ ăn lại, thường khoảng 3 - 5 giây";
		this.buttonXoaThuong.Location = new System.Drawing.Point(252, 115);
		this.buttonXoaThuong.Name = "buttonXoaThuong";
		this.buttonXoaThuong.Size = new System.Drawing.Size(46, 23);
		this.buttonXoaThuong.TabIndex = 241;
		this.buttonXoaThuong.Text = "Xóa";
		this.buttonXoaThuong.UseVisualStyleBackColor = true;
		this.buttonXoaThuong.Click += new System.EventHandler(buttonXoaThuong_Click);
		this.buttonThuong.Location = new System.Drawing.Point(193, 115);
		this.buttonThuong.Name = "buttonThuong";
		this.buttonThuong.Size = new System.Drawing.Size(57, 23);
		this.buttonThuong.TabIndex = 240;
		this.buttonThuong.Text = "Thêm";
		this.buttonThuong.UseVisualStyleBackColor = true;
		this.buttonThuong.Click += new System.EventHandler(buttonThuong_Click);
		this.listViewThuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listViewThuong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_1 });
		this.listViewThuong.FullRowSelect = true;
		this.listViewThuong.GridLines = true;
		this.listViewThuong.HideSelection = false;
		this.listViewThuong.Location = new System.Drawing.Point(3, 39);
		this.listViewThuong.Name = "listViewThuong";
		this.listViewThuong.Size = new System.Drawing.Size(294, 73);
		this.listViewThuong.TabIndex = 239;
		this.listViewThuong.UseCompatibleStateImageBehavior = false;
		this.listViewThuong.View = System.Windows.Forms.View.Details;
		this.columnHeader_1.Text = "Tên thuốc (dùng ở bản đồ thường)";
		this.columnHeader_1.Width = 250;
		this.comboBoxThuong.DropDownWidth = 290;
		this.comboBoxThuong.FormattingEnabled = true;
		this.comboBoxThuong.Location = new System.Drawing.Point(3, 117);
		this.comboBoxThuong.Name = "comboBoxThuong";
		this.comboBoxThuong.Size = new System.Drawing.Size(183, 21);
		this.comboBoxThuong.TabIndex = 238;
		this.comboBoxThuong.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxThuong_MouseDown);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(302, 376);
		base.Controls.Add(this.buttonXoaThuong);
		base.Controls.Add(this.buttonThuong);
		base.Controls.Add(this.listViewThuong);
		base.Controls.Add(this.comboBoxThuong);
		base.Controls.Add(this.textBoxGiay);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.buttonAppAll);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.buttonXoa);
		base.Controls.Add(this.buttonThem);
		base.Controls.Add(this.listView1);
		base.Controls.Add(this.comboBoxTenTuiMauHotro);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormThuocTocdoDanh";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "THUOC TOC DO DANH";
		base.Load += new System.EventHandler(FormThuocTocdoDanh_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
