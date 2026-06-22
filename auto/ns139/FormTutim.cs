using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns100;
using ns11;
using ns23;
using ns34;
using ns53;
using ns63;

namespace ns139;

public class FormTutim : Form
{
	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonThoat;

	private ColumnHeader columnHeader_1;

	private Button buttonChonWeb;

	private RichTextBox richTextBox1;

	private TextBox textBoxTukhoa;

	private Label label1;

	private Button buttonTim;

	private Button buttonHuongdan;

	public static bool bool_0 = false;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	private int int_4 = -1;

	private int int_5 = -1;

	private Color color_0 = default(Color);

	private Color color_1 = default(Color);

	public FormTutim()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns139.FormTutim));
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonThoat = new System.Windows.Forms.Button();
		this.buttonChonWeb = new System.Windows.Forms.Button();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.textBoxTukhoa = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.buttonTim = new System.Windows.Forms.Button();
		this.buttonHuongdan = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader_0, this.columnHeader_1 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(1, 76);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(248, 332);
		this.listView1.TabIndex = 1;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		this.columnHeader_0.Text = "STT";
		this.columnHeader_0.Width = 40;
		this.columnHeader_1.Text = "Tên web";
		this.columnHeader_1.Width = 145;
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonThoat.Location = new System.Drawing.Point(197, 470);
		this.buttonThoat.Name = "buttonThoat";
		this.buttonThoat.Size = new System.Drawing.Size(51, 23);
		this.buttonThoat.TabIndex = 6;
		this.buttonThoat.Text = "Đóng";
		this.buttonThoat.UseVisualStyleBackColor = true;
		this.buttonThoat.Click += new System.EventHandler(buttonThoat_Click);
		this.buttonChonWeb.Location = new System.Drawing.Point(3, 414);
		this.buttonChonWeb.Name = "buttonChonWeb";
		this.buttonChonWeb.Size = new System.Drawing.Size(157, 26);
		this.buttonChonWeb.TabIndex = 7;
		this.buttonChonWeb.Text = "Lấy web đang chọn";
		this.buttonChonWeb.UseVisualStyleBackColor = true;
		this.buttonChonWeb.Click += new System.EventHandler(buttonChonWeb_Click);
		this.richTextBox1.BackColor = System.Drawing.Color.White;
		this.richTextBox1.Location = new System.Drawing.Point(3, 3);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.ReadOnly = true;
		this.richTextBox1.Size = new System.Drawing.Size(246, 70);
		this.richTextBox1.TabIndex = 8;
		this.richTextBox1.Text = "";
		this.textBoxTukhoa.Location = new System.Drawing.Point(12, 470);
		this.textBoxTukhoa.Name = "textBoxTukhoa";
		this.textBoxTukhoa.Size = new System.Drawing.Size(127, 20);
		this.textBoxTukhoa.TabIndex = 9;
		this.textBoxTukhoa.TextChanged += new System.EventHandler(textBoxTukhoa_TextChanged);
		this.textBoxTukhoa.KeyDown += new System.Windows.Forms.KeyEventHandler(textBoxTukhoa_KeyDown);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(9, 449);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(221, 13);
		this.label1.TabIndex = 10;
		this.label1.Text = "Nhập từ khóa tìm hoặc Id lic bang hội cần tìm";
		this.buttonTim.Location = new System.Drawing.Point(145, 470);
		this.buttonTim.Name = "buttonTim";
		this.buttonTim.Size = new System.Drawing.Size(46, 23);
		this.buttonTim.TabIndex = 11;
		this.buttonTim.Text = "Tìm";
		this.buttonTim.UseVisualStyleBackColor = true;
		this.buttonTim.Click += new System.EventHandler(buttonTim_Click);
		this.buttonHuongdan.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonHuongdan.Location = new System.Drawing.Point(166, 414);
		this.buttonHuongdan.Name = "buttonHuongdan";
		this.buttonHuongdan.Size = new System.Drawing.Size(82, 26);
		this.buttonHuongdan.TabIndex = 12;
		this.buttonHuongdan.Text = "Hướng dẫn";
		this.buttonHuongdan.UseVisualStyleBackColor = true;
		this.buttonHuongdan.Click += new System.EventHandler(buttonHuongdan_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(252, 500);
		base.Controls.Add(this.buttonHuongdan);
		base.Controls.Add(this.textBoxTukhoa);
		base.Controls.Add(this.buttonTim);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.buttonChonWeb);
		base.Controls.Add(this.buttonThoat);
		base.Controls.Add(this.listView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormTutim";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "FIND WEB";
		base.Load += new System.EventHandler(FormTutim_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
	}

	private void FormTutim_Load(object sender, EventArgs e)
	{
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
		int num3 = -1;
		for (int i = 0; i < Form1.string_7.GetLength(0); i++)
		{
			method_0(listView1, Form1.string_7[i, 0]);
			if (Form1.string_6 == Form1.string_7[i, 0])
			{
				num3 = listView1.Items.Count - 1;
			}
		}
		if (0 <= num3)
		{
			listView1.Items[num3].ForeColor = Color.Blue;
			listView1.Items[num3].Selected = true;
		}
		string text = "Nếu không tìm được WEB trong danh sách, thì tự làm như sau||1. Bỏ check tên ac phụ trên auto.|2. Đem ac chính lên bản đồ khó đi nào đó.|3. Chọn web XXX nào đó, ví dụ XXX là " + Form1.string_7[0, 0] + "|4. Check lại tên ac phụ, để ac phụ tiến hành tìm ac chính.||Nếu ac phụ đi Thần Hành phù lên được chỗ ac chính thì quá tốt, dừng lại, THP của web đang chọn là dùng được, ta chọn web đó.||Nếu ac phụ không đi được Thần Hành phù, thì tiếp tục làm lại bước 3.|";
		if (Class37.int_2 != null)
		{
			text += "|========================|Lỗi, không thể thần hành phù với các bản đồ có MapID sau:||";
			for (int j = 0; j < Class37.int_2.Length; j++)
			{
				text = text + Class37.int_2[j] + "; ";
			}
		}
		richTextBox1.Text = text.Replace("|", Class56.string_7);
		textBoxTukhoa.Text = Form1.string_12;
		Thread.Sleep(300);
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
	}

	private void method_0(ListView listView_0, string string_0)
	{
		try
		{
			string text = "1";
			string[] array = string_0.Split('|');
			if (listView_0.Items != null)
			{
				text = (listView_0.Items.Count + 1).ToString();
			}
			ListViewItem listViewItem = new ListViewItem(text);
			if (array.Length != 0)
			{
				for (int i = 0; i < array.Length; i++)
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

	private void method_1(ListView listView_0, int int_6)
	{
		if (int_4 <= 0 && listView_0.Items.Count > 0)
		{
			int_4 = listView_0.Height / (listView_0.GetItemRect(0).Height + 1);
		}
		if (int_4 > 0 && (listView_0.TopItem.Index + int_4 <= int_6 || int_6 < listView_0.TopItem.Index))
		{
			listView_0.TopItem = listView_0.Items[int_6];
		}
	}

	private void method_2()
	{
		string text = textBoxTukhoa.Text;
		if (text == null || text == string.Empty || listView1.Items.Count <= 0)
		{
			return;
		}
		string[] array = text.ToUpper().Split('_', ' ', '/', ':');
		int num = 0;
		if (int_5 > 0)
		{
			num = int_5 + 1;
		}
		bool flag = false;
		while (true)
		{
			for (int i = num; i < listView1.Items.Count; i++)
			{
				for (int j = 0; j < listView1.Items[i].SubItems.Count; j++)
				{
					string text2 = listView1.Items[i].SubItems[j].Text.ToUpper();
					for (int k = 0; k < array.Length; k++)
					{
						text = array[k];
						if (text == null || text == string.Empty)
						{
							continue;
						}
						if (text.IndexOf(".") > 0)
						{
							text = text.Split('.')[0];
						}
						if (text != null && !(text == string.Empty))
						{
							text = text.ToUpper();
							if (!(text == "HTTP") && !(text == "HTTPS") && 0 <= text2.IndexOf(text))
							{
								method_1(listView1, i);
								method_3(i);
								return;
							}
						}
					}
				}
			}
			if (flag || num <= 0)
			{
				break;
			}
			num = 0;
			flag = true;
		}
		Class11.smethod_62(richTextBox1, "Không tìm thấy \"" + textBoxTukhoa.Text + "\"");
	}

	private void buttonChonWeb_Click(object sender, EventArgs e)
	{
		if (int_5 >= 0 && Form1.int_4 != int_5)
		{
			Form1.int_4 = int_5;
			Close();
		}
	}

	private void buttonThoat_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void buttonTim_Click(object sender, EventArgs e)
	{
		method_2();
	}

	private void textBoxTukhoa_KeyDown(object sender, KeyEventArgs e)
	{
		if (timer_0.Enabled && e.KeyCode == Keys.Return)
		{
			method_2();
		}
	}

	private void method_3(int int_6)
	{
		if (0 <= int_5 && int_5 < listView1.Items.Count)
		{
			listView1.Items[int_5].BackColor = color_0;
			listView1.Items[int_5].ForeColor = color_1;
		}
		if (0 <= int_6 && int_6 < listView1.Items.Count)
		{
			color_0 = listView1.Items[int_6].BackColor;
			color_1 = listView1.Items[int_6].ForeColor;
			listView1.Items[int_6].BackColor = Color.Green;
			listView1.Items[int_6].ForeColor = Color.Yellow;
			int_5 = int_6;
		}
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView1.SelectedIndices.Count != 0)
		{
			method_3(listView1.SelectedIndices[0]);
		}
	}

	private void buttonHuongdan_Click(object sender, EventArgs e)
	{
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		string string_2 = "https://youtu.be/TRVdeyXbW94";
		Class24.smethod_40(string_, "", string_2, 0);
	}

	private void textBoxTukhoa_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Form1.string_12 = textBoxTukhoa.Text;
			Class66.smethod_11(Class66.smethod_1(), "textFindWeb", Form1.string_12, "", 0);
		}
	}
}
