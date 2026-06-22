using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns100;
using ns11;
using ns150;
using ns30;
using ns53;
using ns63;

namespace ns99;

public class Dangky : Form
{
	private IContainer icontainer_0 = null;

	private Button dkcopy;

	private TextBox dkidcode;

	private Label label1;

	private RichTextBox dksr;

	private Label label2;

	private Button dkxoahet;

	private Button dkdanvao;

	private Button dkdangky;

	private Timer timer_0;

	private Button buttonCapnhatlic;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private CheckBox checkBoxOcungThu2;

	public static int int_0 = 0;

	private IContainer icontainer_1;

	private string[] string_0 = null;

	public Dangky()
	{
		int_0 = 1;
		string text = string.Empty;
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_0(Class56.char_0));
		string_0 = new string[2]
		{
			environmentVariable + "\\" + Class11.smethod_0(Class11.char_31),
			Class56.string_9 + "\\" + Class11.smethod_0(Class11.char_31)
		};
		InitializeComponent();
		tabControl1.Controls.Remove(tabPage2);
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		base.TopMost = true;
		if (Class31.string_3 != null && Class31.string_3 != string.Empty)
		{
			dkidcode.Text = Class31.string_3;
		}
		else
		{
			dkidcode.Text = Class31.string_2;
		}
		bool flag = false;
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				string text2 = Class11.smethod_33(string_0[i], 1, 1, 1);
				if (text2 != null && text2 != string.Empty)
				{
					text = text2;
					flag = true;
					break;
				}
			}
		}
		dksr.Text = text;
		dksr.ReadOnly = flag;
		buttonCapnhatlic.Enabled = flag;
		dkdanvao.Enabled = !flag;
		dkxoahet.Enabled = !flag;
		dkdangky.Enabled = !flag;
		checkBoxOcungThu2.Checked = Class31.int_1 > 0;
		Class11.smethod_23(Class56.string_9);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns99.Dangky));
		this.dkcopy = new System.Windows.Forms.Button();
		this.dkidcode = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.dksr = new System.Windows.Forms.RichTextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.dkxoahet = new System.Windows.Forms.Button();
		this.dkdanvao = new System.Windows.Forms.Button();
		this.dkdangky = new System.Windows.Forms.Button();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_1);
		this.buttonCapnhatlic = new System.Windows.Forms.Button();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.checkBoxOcungThu2 = new System.Windows.Forms.CheckBox();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.tabPage2.SuspendLayout();
		base.SuspendLayout();
		this.dkcopy.BackColor = System.Drawing.Color.LightSteelBlue;
		this.dkcopy.ForeColor = System.Drawing.Color.Black;
		this.dkcopy.Location = new System.Drawing.Point(440, 3);
		this.dkcopy.Name = "dkcopy";
		this.dkcopy.Size = new System.Drawing.Size(58, 24);
		this.dkcopy.TabIndex = 0;
		this.dkcopy.Text = "Copy";
		this.dkcopy.UseVisualStyleBackColor = false;
		this.dkcopy.Click += new System.EventHandler(dkcopy_Click);
		this.dkidcode.ForeColor = System.Drawing.Color.Black;
		this.dkidcode.Location = new System.Drawing.Point(62, 3);
		this.dkidcode.Name = "dkidcode";
		this.dkidcode.ReadOnly = true;
		this.dkidcode.Size = new System.Drawing.Size(370, 21);
		this.dkidcode.TabIndex = 1;
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(3, 7);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(51, 15);
		this.label1.TabIndex = 2;
		this.label1.Text = "Mã máy";
		this.dksr.ForeColor = System.Drawing.Color.Black;
		this.dksr.Location = new System.Drawing.Point(7, 55);
		this.dksr.Name = "dksr";
		this.dksr.Size = new System.Drawing.Size(490, 85);
		this.dksr.TabIndex = 3;
		this.dksr.Text = "";
		this.dksr.TextChanged += new System.EventHandler(dksr_TextChanged);
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.Black;
		this.label2.Location = new System.Drawing.Point(3, 37);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(291, 15);
		this.label2.TabIndex = 4;
		this.label2.Text = "Bấm nút [Dán Serial] để điền serial vào box dưới đây";
		this.dkxoahet.BackColor = System.Drawing.SystemColors.Control;
		this.dkxoahet.ForeColor = System.Drawing.Color.Black;
		this.dkxoahet.Location = new System.Drawing.Point(259, 151);
		this.dkxoahet.Name = "dkxoahet";
		this.dkxoahet.Size = new System.Drawing.Size(97, 30);
		this.dkxoahet.TabIndex = 5;
		this.dkxoahet.Text = "Xoá hết";
		this.dkxoahet.UseVisualStyleBackColor = false;
		this.dkxoahet.Click += new System.EventHandler(dkxoahet_Click);
		this.dkdanvao.BackColor = System.Drawing.SystemColors.Control;
		this.dkdanvao.ForeColor = System.Drawing.Color.Black;
		this.dkdanvao.Location = new System.Drawing.Point(141, 151);
		this.dkdanvao.Name = "dkdanvao";
		this.dkdanvao.Size = new System.Drawing.Size(101, 30);
		this.dkdanvao.TabIndex = 6;
		this.dkdanvao.Text = "Dán Serial";
		this.dkdanvao.UseVisualStyleBackColor = false;
		this.dkdanvao.Click += new System.EventHandler(dkdanvao_Click);
		this.dkdangky.BackColor = System.Drawing.SystemColors.Control;
		this.dkdangky.ForeColor = System.Drawing.Color.MediumBlue;
		this.dkdangky.Location = new System.Drawing.Point(387, 151);
		this.dkdangky.Name = "dkdangky";
		this.dkdangky.Size = new System.Drawing.Size(111, 30);
		this.dkdangky.TabIndex = 7;
		this.dkdangky.Text = "Đăng ký";
		this.dkdangky.UseVisualStyleBackColor = false;
		this.dkdangky.Click += new System.EventHandler(dkdangky_Click);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonCapnhatlic.BackColor = System.Drawing.SystemColors.Control;
		this.buttonCapnhatlic.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonCapnhatlic.Location = new System.Drawing.Point(7, 151);
		this.buttonCapnhatlic.Name = "buttonCapnhatlic";
		this.buttonCapnhatlic.Size = new System.Drawing.Size(128, 30);
		this.buttonCapnhatlic.TabIndex = 8;
		this.buttonCapnhatlic.Text = "Cập nhật LIC mới";
		this.buttonCapnhatlic.UseVisualStyleBackColor = false;
		this.buttonCapnhatlic.Click += new System.EventHandler(buttonCapnhatlic_Click);
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Location = new System.Drawing.Point(0, 1);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(523, 226);
		this.tabControl1.TabIndex = 9;
		this.tabPage1.Controls.Add(this.dksr);
		this.tabPage1.Controls.Add(this.buttonCapnhatlic);
		this.tabPage1.Controls.Add(this.dkcopy);
		this.tabPage1.Controls.Add(this.dkdangky);
		this.tabPage1.Controls.Add(this.dkidcode);
		this.tabPage1.Controls.Add(this.dkdanvao);
		this.tabPage1.Controls.Add(this.label1);
		this.tabPage1.Controls.Add(this.dkxoahet);
		this.tabPage1.Controls.Add(this.label2);
		this.tabPage1.Location = new System.Drawing.Point(4, 24);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(515, 198);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Đăng ký";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.tabPage2.Controls.Add(this.checkBoxOcungThu2);
		this.tabPage2.Location = new System.Drawing.Point(4, 24);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(515, 198);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "Thông tin khác";
		this.tabPage2.UseVisualStyleBackColor = true;
		this.checkBoxOcungThu2.AutoSize = true;
		this.checkBoxOcungThu2.Location = new System.Drawing.Point(7, 7);
		this.checkBoxOcungThu2.Name = "checkBoxOcungThu2";
		this.checkBoxOcungThu2.Size = new System.Drawing.Size(86, 19);
		this.checkBoxOcungThu2.TabIndex = 0;
		this.checkBoxOcungThu2.Text = "checkBox1";
		this.checkBoxOcungThu2.UseVisualStyleBackColor = true;
		this.checkBoxOcungThu2.CheckedChanged += new System.EventHandler(checkBoxOcungThu2_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(520, 225);
		base.Controls.Add(this.tabControl1);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "Dangky";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "DANG KY SU DUNG";
		base.TopMost = true;
		base.Load += new System.EventHandler(Dangky_Load);
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage1.PerformLayout();
		this.tabPage2.ResumeLayout(false);
		this.tabPage2.PerformLayout();
		base.ResumeLayout(false);
	}

	private void dkcopy_Click(object sender, EventArgs e)
	{
		try
		{
			if (dkidcode.Text != null && dkidcode.Text != string.Empty)
			{
				Clipboard.SetText(dkidcode.Text);
			}
		}
		catch
		{
		}
	}

	private void dkxoahet_Click(object sender, EventArgs e)
	{
		dksr.Text = "";
	}

	private void dkdanvao_Click(object sender, EventArgs e)
	{
		try
		{
			dksr.Text = Clipboard.GetText();
		}
		catch
		{
		}
	}

	private void dkdangky_Click(object sender, EventArgs e)
	{
		string text = dksr.Text.Trim();
		if (string.IsNullOrEmpty(text))
		{
			MessageBox.Show("Chưa nhập mã đăng ký", Form1.string_49);
			return;
		}
		if (text == dkidcode.Text.Trim())
		{
			string text2 = Class11.smethod_72("88t4uGt5rkLRw92TM3UUjkw8vKhSIefwAoXcw4uBeGGljkJ2xuEteekKBUCFizMVilOLMhNz9Lg8Di+uVEh6uGtprkLe4V0lCsn5BZVwTRDjFNIf7l6bqVBYmqjgnZmrEPlw1/48oA0PdzeDbMiFGgUUOdIMND/78F49AA==");
			MessageBox.Show(text2, Form1.string_49);
			return;
		}
		text = text.Replace(":", "").Replace("\t", "").Replace(" ", "");
		if (text != "" && Class11.smethod_1(text, " ") < 0 && Class11.smethod_1(text, "à") < 0)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				Class11.smethod_34(string_0[i], text, 1);
			}
			char[] char_ = new char[175]
			{
				'ᕳ', 'ᕤ', 'ᕡ', 'ᕛ', 'ᔸ', 'ᕙ', 'ᖍ', 'ᖌ', 'ᖇ', 'ᔸ',
				'ᕙ', 'ᕙ', 'ᕙ', 'ᕙ', 'ᕵ', 'ᔸ', 'ᔢ', 'ᕥ', 'ᕹ', 'ᔸ',
				'ᖅ', 'ᕹ', 'ᖑ', 'ᔡ', 'ᕒ', 'ᔸ', 'ᕰ', 'ᕰ', 'ᕰ', 'ᕰ',
				'ᔢ', 'ᕫ', 'ᕽ', 'ᖊ', 'ᖁ', 'ᕹ', 'ᖄ', 'ᔡ', 'ᕒ', 'ᔸ',
				'ᕱ', 'ᕱ', 'ᕱ', 'ᕱ', 'ᔢ', 'ᔢ', 'ᕛ', 'ᕹ', 'ᕻ', 'ᖀ',
				'ᔸ', 'ᖄ', 'ᕹ', 'ᖅ', 'ᕒ', 'ᔸ', 'ᕛ', 'ᖇ', 'ᖈ', 'ᖑ',
				'ᔸ', 'ᖈ', 'ᖀ', 'ᖁ', 'ᕹ', 'ᔸ', 'ᖋ', 'ᕹ', 'ᖍ', 'ᔸ',
				'ᕻ', 'ᖀ', 'ᖍ', 'ᖇ', 'ᖁ', 'ᔸ', 'ᕫ', 'ᕽ', 'ᖊ', 'ᖁ',
				'ᕹ', 'ᖄ', 'ᔸ', 'ᕻ', 'ᖀ', 'ᖇ', 'ᔸ', 'ᕼ', 'ᕽ', 'ᖆ',
				'ᔸ', 'ᖀ', 'ᕽ', 'ᖌ', 'ᔸ', 'ᕀ', 'ᖃ', 'ᕽ', 'ᔸ', 'ᕻ',
				'ᕹ', 'ᔸ', 'ᕊ', 'ᔸ', 'ᕼ', 'ᕹ', 'ᖍ', 'ᔸ', 'ᕕ', 'ᕕ',
				'ᔸ', 'ᕻ', 'ᖍ', 'ᖇ', 'ᖁ', 'ᔸ', 'ᕻ', 'ᖍ', 'ᖆ', 'ᕿ',
				'ᔸ', 'ᖆ', 'ᕽ', 'ᖍ', 'ᔸ', 'ᕻ', 'ᖇ', 'ᕁ', 'ᔢ', 'ᕫ',
				'ᕹ', 'ᖍ', 'ᔸ', 'ᕼ', 'ᖇ', 'ᔸ', 'ᕼ', 'ᕹ', 'ᖆ', 'ᔸ',
				'ᖎ', 'ᕹ', 'ᖇ', 'ᔸ', 'ᕺ', 'ᖇ', 'ᖐ', 'ᔸ', 'ᖋ', 'ᕽ',
				'ᖊ', 'ᖁ', 'ᕹ', 'ᖄ', 'ᔸ', 'ᖎ', 'ᕹ', 'ᔸ', 'ᖆ', 'ᖀ',
				'ᕹ', 'ᖆ', 'ᔸ', 'ᖆ', 'ᖍ', 'ᖌ', 'ᔸ', 'ᕼ', 'ᕹ', 'ᖆ',
				'ᕿ', 'ᔸ', 'ᖃ', 'ᖑ', 'ᕆ'
			};
			string text3 = Class11.smethod_0(char_);
			text3 = text3.Replace(Class11.smethod_0(new char[4] { 'ᒮ', 'ᒮ', 'ᒮ', 'ᒮ' }), Form1.string_49);
			text3 = text3.Replace("\n", Class56.string_7);
			text3 = text3.Replace(Class11.smethod_0(new char[4] { 'ᓅ', 'ᓅ', 'ᓅ', 'ᓅ' }), Class31.string_2);
			text3 = text3.Replace(Class11.smethod_0(new char[4] { 'ᓆ', 'ᓆ', 'ᓆ', 'ᓆ' }), text);
			Class11.smethod_34(Class11.smethod_0(Class11.char_32), text3, 1);
			string string_ = "PY49CsJAEIV7T/E8gDmArY21WNguibjBZCJk1wtYW1iKTYJYqRjUahex2JB7zE0cLezm/X3MuGvYH2iBhN2ZkIUqR8auTkG6a1AqO+wNMGV3M1DWFCJG2rLfG6w0u2OKdaiKX4RYs98SknAX3sQSVAmV5ClFUSS72fyPZve2iMMDgqgJJfurPOBPsjM6XNDu2o3cy/D66oq0lJ9i9Hsf";
			MessageBox.Show(Class11.smethod_72(string_), Form1.string_49);
			TryNewVersion.int_0 = 2;
			Close();
		}
	}

	private void Dangky_Load(object sender, EventArgs e)
	{
		int num = Cursor.Position.X;
		int num2 = Cursor.Position.Y;
		num -= base.Width;
		num2 -= base.Height;
		if (num <= 0)
		{
			num = 1;
		}
		if (num2 <= 0)
		{
			num2 = 1;
		}
		SetBounds(num, num2, base.Width, base.Height);
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		int_0 = 0;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			Close();
		}
	}

	private void buttonCapnhatlic_Click(object sender, EventArgs e)
	{
		dksr.ReadOnly = false;
		dksr.BackColor = Color.White;
		buttonCapnhatlic.Enabled = false;
		dkdanvao.Enabled = true;
		dkxoahet.Enabled = true;
		dkdangky.Enabled = true;
	}

	private void checkBoxOcungThu2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class31.int_1 = Convert.ToByte(checkBoxOcungThu2.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fMultiHd", Class31.int_1, "", 0);
		}
	}

	private void dksr_TextChanged(object sender, EventArgs e)
	{
	}
}
