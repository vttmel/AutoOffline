using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns100;
using ns11;
using ns23;
using ns53;
using ns63;
using ns79;
using ns83;

namespace ns123;

public class FormNgamyBuff : Form
{
	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonClose;

	private CheckBox checkBoxnttk;

	private ComboBox comboBoxNgaMyBuff;

	private Label labelPhimKethop;

	private Button buttonPhim;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	public static int int_4 = 0;

	public static string[] string_0 = new string[3] { "Ưu tiên buff cho ac chính", "Buff ac chính và ac phụ", "Chỉ buff cho bản thân" };

	public FormNgamyBuff()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns123.FormNgamyBuff));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonClose = new System.Windows.Forms.Button();
		this.checkBoxnttk = new System.Windows.Forms.CheckBox();
		this.comboBoxNgaMyBuff = new System.Windows.Forms.ComboBox();
		this.labelPhimKethop = new System.Windows.Forms.Label();
		this.buttonPhim = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonClose.Location = new System.Drawing.Point(156, 140);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(100, 27);
		this.buttonClose.TabIndex = 14;
		this.buttonClose.Text = "OK";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.checkBoxnttk.AutoSize = true;
		this.checkBoxnttk.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxnttk.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxnttk.ForeColor = System.Drawing.Color.Black;
		this.checkBoxnttk.Location = new System.Drawing.Point(12, 39);
		this.checkBoxnttk.Name = "checkBoxnttk";
		this.checkBoxnttk.Size = new System.Drawing.Size(180, 17);
		this.checkBoxnttk.TabIndex = 335;
		this.checkBoxnttk.Text = "Buff chiêu Ngọc Tuyền Tâm Kinh";
		this.checkBoxnttk.UseVisualStyleBackColor = false;
		this.checkBoxnttk.CheckedChanged += new System.EventHandler(checkBoxnttk_CheckedChanged);
		this.comboBoxNgaMyBuff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxNgaMyBuff.DropDownWidth = 120;
		this.comboBoxNgaMyBuff.ForeColor = System.Drawing.Color.Black;
		this.comboBoxNgaMyBuff.FormattingEnabled = true;
		this.comboBoxNgaMyBuff.Location = new System.Drawing.Point(12, 12);
		this.comboBoxNgaMyBuff.Name = "comboBoxNgaMyBuff";
		this.comboBoxNgaMyBuff.Size = new System.Drawing.Size(260, 21);
		this.comboBoxNgaMyBuff.TabIndex = 339;
		this.comboBoxNgaMyBuff.SelectedIndexChanged += new System.EventHandler(comboBoxNgaMyBuff_SelectedIndexChanged);
		this.labelPhimKethop.Enabled = false;
		this.labelPhimKethop.ForeColor = System.Drawing.Color.MediumBlue;
		this.labelPhimKethop.Location = new System.Drawing.Point(12, 65);
		this.labelPhimKethop.Name = "labelPhimKethop";
		this.labelPhimKethop.Size = new System.Drawing.Size(260, 72);
		this.labelPhimKethop.TabIndex = 340;
		this.labelPhimKethop.Text = "Lưu ý: Game phải ở chế độ Phím Kết Hợp thì mới sử dụng được chiêu Ngọc Tuyền Tâm Kinh.\r\n\r\nCách thiết lập phím kết hợp trong game:\r\nBấm Esc -> Tùy chọn hệ thống -> Phím kết hợp";
		this.buttonPhim.Location = new System.Drawing.Point(12, 140);
		this.buttonPhim.Name = "buttonPhim";
		this.buttonPhim.Size = new System.Drawing.Size(128, 27);
		this.buttonPhim.TabIndex = 341;
		this.buttonPhim.Text = "Phim Hướng dẫn";
		this.buttonPhim.UseVisualStyleBackColor = true;
		this.buttonPhim.Click += new System.EventHandler(buttonPhim_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(281, 179);
		base.Controls.Add(this.buttonPhim);
		base.Controls.Add(this.labelPhimKethop);
		base.Controls.Add(this.comboBoxNgaMyBuff);
		base.Controls.Add(this.checkBoxnttk);
		base.Controls.Add(this.buttonClose);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormNgamyBuff";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "NGA MY BUFF";
		base.Load += new System.EventHandler(FormNgamyBuff_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
	}

	private void FormNgamyBuff_Load(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			Close();
			return;
		}
		CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[num];
		if (int_0 > 0 && int_1 > 0)
		{
			int num2 = int_0 - base.Width - 10;
			int num3 = int_1 - base.Height - 10;
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
		for (int i = 0; i < string_0.Length; i++)
		{
			comboBoxNgaMyBuff.Items.Add(string_0[i]);
		}
		comboBoxNgaMyBuff.Text = string_0[characterAccountConfig.int_101[2]];
		checkBoxnttk.Checked = characterAccountConfig.int_101[6] > 0;
		labelPhimKethop.Enabled = characterAccountConfig.int_101[6] > 0;
		Thread.Sleep(100);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (Class11.bool_0 || !bool_0)
		{
			Close();
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		bool_0 = false;
		Close();
	}

	private void checkBoxnttk_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num < 0)
		{
			Close();
			return;
		}
		CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
		int num2 = 0;
		int num3 = 0;
		labelPhimKethop.Enabled = checkBoxnttk.Checked;
		if (checkBoxnttk.Checked)
		{
			num2 = 1114 * Convert.ToByte(Class83.smethod_16(characterAccountConfig_, 1114) > 0);
			num3 = 470;
		}
		if (num2 == 0)
		{
			num2 = 93 * Convert.ToByte(Class83.smethod_16(characterAccountConfig_, 93) > 0);
			num3 = 400;
		}
		Form1.characterAccountConfig_1[num].int_101[6] = Convert.ToByte(checkBoxnttk.Checked);
		Form1.characterAccountConfig_1[num].int_101[1] = num2;
		Form1.characterAccountConfig_1[num].int_101[5] = num3;
		Class56.smethod_13(Form1.characterAccountConfig_1[num]);
	}

	private void comboBoxNgaMyBuff_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_4);
		if (num >= 0)
		{
			string text = comboBoxNgaMyBuff.Text;
			int num2 = 0;
			while (true)
			{
				if (num2 < string_0.Length)
				{
					if (text == string_0[num2])
					{
						break;
					}
					num2++;
					continue;
				}
				return;
			}
			Form1.characterAccountConfig_1[num].int_101[2] = num2;
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		}
		else
		{
			Close();
		}
	}

	private void buttonPhim_Click(object sender, EventArgs e)
	{
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(string_))
		{
			string_ = Class66.smethod_0();
		}
		Class24.smethod_40(string_, "", "https://youtu.be/ngCGdG4dYAI", 0);
	}
}
