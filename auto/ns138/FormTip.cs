using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns100;
using ns11;
using ns53;
using ns63;

namespace ns138;

public class FormTip : Form
{
	private IContainer icontainer_0 = null;

	private CheckBox checkBoxKhongHienthi;

	private Button buttonDong;

	private Timer timer_0;

	private RichTextBox richTextBoxStatus;

	private Button buttonCopy;

	public static bool bool_0 = false;

	public bool bool_1 = false;

	public bool bool_2 = false;

	public string string_0 = null;

	public string string_1 = null;

	public string string_2 = null;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4 = 0;

	public bool bool_3 = false;

	public bool bool_4 = false;

	public int int_5 = 0;

	public int int_6 = 0;

	public bool bool_5 = false;

	public bool bool_6 = false;

	private string string_3 = null;

	private static long long_0 = 0L;

	public bool bool_7 = false;

	public string string_4 = null;

	private IContainer icontainer_1;

	private WebBrowser webBrowser1;

	public FormTip()
	{
		bool_0 = !bool_0;
		InitializeComponent();
		webBrowser1 = new WebBrowser();
		webBrowser1.Location = richTextBoxStatus.Location;
		webBrowser1.MinimumSize = richTextBoxStatus.MaximumSize;
		webBrowser1.Name = "webBrowser1";
		webBrowser1.Size = richTextBoxStatus.Size;
		webBrowser1.TabIndex = 5;
		base.Controls.Add(webBrowser1);
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
		this.icontainer_1 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns138.FormTip));
		this.checkBoxKhongHienthi = new System.Windows.Forms.CheckBox();
		this.buttonDong = new System.Windows.Forms.Button();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_1);
		this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
		this.buttonCopy = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.checkBoxKhongHienthi.AutoSize = true;
		this.checkBoxKhongHienthi.BackColor = System.Drawing.Color.LightSteelBlue;
		this.checkBoxKhongHienthi.Location = new System.Drawing.Point(0, 307);
		this.checkBoxKhongHienthi.Name = "checkBoxKhongHienthi";
		this.checkBoxKhongHienthi.Size = new System.Drawing.Size(199, 17);
		this.checkBoxKhongHienthi.TabIndex = 1;
		this.checkBoxKhongHienthi.Text = "Không hiện bảng thông báo này nữa";
		this.checkBoxKhongHienthi.UseVisualStyleBackColor = false;
		this.checkBoxKhongHienthi.CheckedChanged += new System.EventHandler(checkBoxKhongHienthi_CheckedChanged);
		this.buttonDong.Location = new System.Drawing.Point(363, 303);
		this.buttonDong.Name = "buttonDong";
		this.buttonDong.Size = new System.Drawing.Size(77, 21);
		this.buttonDong.TabIndex = 2;
		this.buttonDong.Text = "Đóng";
		this.buttonDong.UseVisualStyleBackColor = true;
		this.buttonDong.Click += new System.EventHandler(buttonDong_Click);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.richTextBoxStatus.BackColor = System.Drawing.Color.White;
		this.richTextBoxStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.richTextBoxStatus.ForeColor = System.Drawing.SystemColors.WindowText;
		this.richTextBoxStatus.Location = new System.Drawing.Point(0, 0);
		this.richTextBoxStatus.Name = "richTextBoxStatus";
		this.richTextBoxStatus.Size = new System.Drawing.Size(443, 301);
		this.richTextBoxStatus.TabIndex = 3;
		this.richTextBoxStatus.Text = "Hướng dẫn sử dụng";
		this.richTextBoxStatus.TextChanged += new System.EventHandler(richTextBoxStatus_TextChanged);
		this.buttonCopy.Location = new System.Drawing.Point(282, 303);
		this.buttonCopy.Name = "buttonCopy";
		this.buttonCopy.Size = new System.Drawing.Size(77, 21);
		this.buttonCopy.TabIndex = 4;
		this.buttonCopy.Text = "Copy";
		this.buttonCopy.UseVisualStyleBackColor = true;
		this.buttonCopy.Click += new System.EventHandler(buttonCopy_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.LightSteelBlue;
		base.ClientSize = new System.Drawing.Size(444, 323);
		base.Controls.Add(this.buttonCopy);
		base.Controls.Add(this.checkBoxKhongHienthi);
		base.Controls.Add(this.richTextBoxStatus);
		base.Controls.Add(this.buttonDong);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormTip";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "HUONG DAN";
		base.Load += new System.EventHandler(FormTip_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
		bool_2 = false;
		string_0 = null;
		string_2 = null;
		int_4 = -1;
		string_1 = null;
		int_5 = 0;
		int_6 = 0;
		bool_5 = false;
		bool_6 = false;
	}

	private void FormTip_Load(object sender, EventArgs e)
	{
		Hide();
		buttonCopy.Visible = bool_5;
		if (bool_4)
		{
			buttonDong.Visible = false;
			if (int_5 <= 0)
			{
				int_5 = 281;
			}
			if (int_6 <= 0)
			{
				int_6 = 130;
			}
			richTextBoxStatus.Width = int_5 - 7;
			richTextBoxStatus.Height = int_6 - 27;
			richTextBoxStatus.Top = 0;
			richTextBoxStatus.Left = 0;
			richTextBoxStatus.Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Width = int_5;
			if (bool_5)
			{
				base.Height = int_6 + 30;
				buttonCopy.Top = richTextBoxStatus.Top + richTextBoxStatus.Height + 5;
				buttonCopy.Left = (base.Width - buttonCopy.Width) / 2;
			}
			else
			{
				base.Height = int_6 + 2;
			}
		}
		else
		{
			base.StartPosition = FormStartPosition.CenterScreen;
		}
		if (int_0 > 0 && int_1 > 0)
		{
			checkBoxKhongHienthi.Visible = false;
			int num = int_0 - base.Width - 5;
			int num2 = int_1 - base.Height - 5;
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
		if (string_0 != null)
		{
			string text = string_0;
			if (!bool_2)
			{
				text = text.Replace("|", Class56.string_7).Replace("\\n", Class56.string_7).Replace("\\t", '\t'.ToString());
			}
			richTextBoxStatus.Text = text;
		}
		checkBoxKhongHienthi.Enabled = !bool_1;
		richTextBoxStatus.WordWrap = !bool_3;
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		long_0 = Class11.smethod_27();
		if (string_1 != null)
		{
			Text = string_1;
		}
		string_3 = Text;
		base.TopMost = true;
		Show();
	}

	private void buttonDong_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxKhongHienthi_CheckedChanged(object sender, EventArgs e)
	{
		if (Form1.string_10 == null)
		{
			Form1.string_10 = string.Empty;
		}
		string text = "Không hiện bảng thông báo này nữa";
		string text2 = string.Empty;
		if (!checkBoxKhongHienthi.Checked)
		{
			if (string_2 != null && string_2 != string.Empty)
			{
				Class66.smethod_11(Class66.smethod_1(), string_2, string.Empty, "", 0);
			}
			else
			{
				Class66.smethod_11(Class66.smethod_1(), "UpdateNew", 0, "", 0);
			}
		}
		else
		{
			if (string_2 != null && string_2 != string.Empty)
			{
				Class66.smethod_11(Class66.smethod_1(), string_2, string_0, "", 0);
			}
			else
			{
				Class66.smethod_11(Class66.smethod_1(), "UpdateNew", string_0.Length, "", 0);
			}
			text2 = " (có thể xem lại ở Phụ trợ - Phim)";
		}
		checkBoxKhongHienthi.Text = text + text2;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
		else if (int_4 > 0)
		{
			long num = int_4 - Class11.smethod_28(long_0);
			Text = string_3 + " (" + num / 1000L + "s)";
			if (num < 0L)
			{
				Close();
			}
		}
	}

	public static void smethod_0(string string_5, string string_6, int int_7 = 60000, int int_8 = 345, int int_9 = 200, bool bool_8 = false, int int_10 = -1, int int_11 = -1, bool bool_9 = false, bool bool_10 = false, bool bool_11 = false)
	{
		if (int_8 < 0)
		{
			int_8 = 345;
		}
		if (int_9 < 0)
		{
			int_9 = 200;
		}
		if (int_7 < 0)
		{
			int_7 = 60000;
		}
		FormTip formTip = new FormTip();
		formTip.string_0 = string_6;
		formTip.bool_2 = bool_11;
		if (int_10 >= 0 && int_11 >= 0)
		{
			formTip.int_0 = int_10 + 5;
			formTip.int_1 = int_11 + int_9 + 5;
		}
		else
		{
			formTip.int_0 = Cursor.Position.X;
			formTip.int_1 = Cursor.Position.Y;
		}
		formTip.bool_5 = bool_9;
		formTip.bool_6 = bool_10;
		formTip.int_2 = Form1.int_52[0];
		formTip.int_3 = Form1.int_52[1];
		formTip.bool_4 = true;
		formTip.bool_3 = bool_8;
		formTip.int_5 = int_8;
		formTip.int_6 = int_9;
		formTip.int_4 = int_7;
		formTip.string_1 = string_5;
		formTip.Show();
	}

	private void buttonCopy_Click(object sender, EventArgs e)
	{
		try
		{
			string text = richTextBoxStatus.Text;
			if (text.IndexOf("\r") < 0)
			{
				text = text.Replace("\n", "\r\n");
			}
			if (bool_6)
			{
				text = text + "\r\nSign: " + Class11.smethod_16(text);
			}
			Clipboard.SetText(text);
		}
		catch
		{
		}
	}

	private void richTextBoxStatus_TextChanged(object sender, EventArgs e)
	{
	}
}
