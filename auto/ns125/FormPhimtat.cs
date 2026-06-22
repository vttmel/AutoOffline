using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns100;
using ns63;
using ns71;

namespace ns125;

public class FormPhimtat : Form
{
	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Button buttonClose;

	private Label label2;

	private ComboBox comboBoxKieuPhimtat;

	private Button buttonGanPhimALL;

	private CheckBox checkBoxLuonGanKetHop;

	private RichTextBox richTextBox1;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	private static string[] string_0 = new string[2] { "Mặc định", "Kết hợp" };

	public FormPhimtat()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns125.FormPhimtat));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonClose = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.comboBoxKieuPhimtat = new System.Windows.Forms.ComboBox();
		this.buttonGanPhimALL = new System.Windows.Forms.Button();
		this.checkBoxLuonGanKetHop = new System.Windows.Forms.CheckBox();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonClose.Location = new System.Drawing.Point(353, 515);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(69, 23);
		this.buttonClose.TabIndex = 14;
		this.buttonClose.Text = "OK";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.Red;
		this.label2.Location = new System.Drawing.Point(5, 444);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(334, 13);
		this.label2.TabIndex = 16;
		this.label2.Text = "Yêu cầu chung: phải check vào mục [v] Sử dụng phím tắt (ở phụ trợ)";
		this.comboBoxKieuPhimtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxKieuPhimtat.DropDownWidth = 100;
		this.comboBoxKieuPhimtat.FormattingEnabled = true;
		this.comboBoxKieuPhimtat.Location = new System.Drawing.Point(27, 516);
		this.comboBoxKieuPhimtat.Name = "comboBoxKieuPhimtat";
		this.comboBoxKieuPhimtat.Size = new System.Drawing.Size(98, 21);
		this.comboBoxKieuPhimtat.TabIndex = 465;
		this.comboBoxKieuPhimtat.SelectedIndexChanged += new System.EventHandler(comboBoxKieuPhimtat_SelectedIndexChanged);
		this.buttonGanPhimALL.BackColor = System.Drawing.SystemColors.Control;
		this.buttonGanPhimALL.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonGanPhimALL.Location = new System.Drawing.Point(131, 515);
		this.buttonGanPhimALL.Name = "buttonGanPhimALL";
		this.buttonGanPhimALL.Size = new System.Drawing.Size(139, 23);
		this.buttonGanPhimALL.TabIndex = 467;
		this.buttonGanPhimALL.Text = "Gán lại cho tất cả ac";
		this.buttonGanPhimALL.UseVisualStyleBackColor = false;
		this.buttonGanPhimALL.Click += new System.EventHandler(buttonGanPhimALL_Click);
		this.checkBoxLuonGanKetHop.AutoSize = true;
		this.checkBoxLuonGanKetHop.ForeColor = System.Drawing.Color.Black;
		this.checkBoxLuonGanKetHop.Location = new System.Drawing.Point(8, 492);
		this.checkBoxLuonGanKetHop.Name = "checkBoxLuonGanKetHop";
		this.checkBoxLuonGanKetHop.Size = new System.Drawing.Size(330, 17);
		this.checkBoxLuonGanKetHop.TabIndex = 466;
		this.checkBoxLuonGanKetHop.Text = "Luôn gán phím tắt (bấm esc -> tùy chọn hệ thống) trong game là";
		this.checkBoxLuonGanKetHop.UseVisualStyleBackColor = true;
		this.checkBoxLuonGanKetHop.CheckedChanged += new System.EventHandler(checkBoxLuonGanKetHop_CheckedChanged);
		this.richTextBox1.Location = new System.Drawing.Point(4, 1);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.Size = new System.Drawing.Size(424, 437);
		this.richTextBox1.TabIndex = 468;
		this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
		this.richTextBox1.Text += "\r\n\r\nCtrl + 1: Chuyển đổi chế độ đánh người (Khoảng cách → Ngũ hành → Môn phái)";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(430, 551);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.comboBoxKieuPhimtat);
		base.Controls.Add(this.buttonGanPhimALL);
		base.Controls.Add(this.checkBoxLuonGanKetHop);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.buttonClose);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormPhimtat";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "PHIM TAT";
		base.Load += new System.EventHandler(FormPhimtat_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
	}

	private void FormPhimtat_Load(object sender, EventArgs e)
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
		for (int i = 0; i < string_0.Length; i++)
		{
			comboBoxKieuPhimtat.Items.Add(string_0[i]);
		}
		comboBoxKieuPhimtat.Text = string_0[Form1.int_22];
		checkBoxLuonGanKetHop.Checked = Form1.int_21 > 0;
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

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxLuonGanKetHop_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Form1.int_21 = Convert.ToByte(checkBoxLuonGanKetHop.Checked);
			Class66.smethod_11(Class66.smethod_1(), "LuonGanPhimtat", Form1.int_21, "", 0);
		}
	}

	private void comboBoxKieuPhimtat_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		string text = comboBoxKieuPhimtat.Text;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (text == string_0[i])
			{
				Form1.int_22 = i;
				Class66.smethod_11(Class66.smethod_1(), "flagKieuPhimTat", Form1.int_22, "", 0);
				break;
			}
		}
	}

	private void buttonGanPhimALL_Click(object sender, EventArgs e)
	{
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Class75.smethod_14(Form1.characterAccountConfig_1[i], Form1.int_22 > 0);
			}
		}
	}
}
