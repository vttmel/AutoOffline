using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns100;
using ns11;
using ns138;
using ns23;
using ns24;
using ns53;
using ns63;
using ns83;

namespace ns113;

public class FormHuyenTinh : Form
{
	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonClose;

	private LinkLabel linkLabelPhimCheTaoHT;

	private LinkLabel linkLabelHDHT;

	private Button buttonDungChetao;

	private CheckBox checkBoxC8;

	private CheckBox checkBoxC7;

	private Button buttonChetaoHuyentinh;

	private CheckBox checkBoxC1;

	private Button buttonStopNangcapHT;

	private CheckBox checkBoxNguyenlieuBH;

	private CheckBox checkBoxC3;

	private CheckBox checkBoxC9;

	private CheckBox checkBoxC6;

	private Button buttonBatdauNangcap;

	private CheckBox checkBoxC4;

	private CheckBox checkBoxC2;

	private CheckBox checkBoxC5;

	private TextBox textBoxHT;

	private GroupBox groupBoxNangCap;

	public static int int_0 = 0;

	public static bool bool_0 = false;

	private static bool bool_1 = false;

	public FormHuyenTinh()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns113.FormHuyenTinh));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonClose = new System.Windows.Forms.Button();
		this.linkLabelPhimCheTaoHT = new System.Windows.Forms.LinkLabel();
		this.linkLabelHDHT = new System.Windows.Forms.LinkLabel();
		this.buttonDungChetao = new System.Windows.Forms.Button();
		this.checkBoxC8 = new System.Windows.Forms.CheckBox();
		this.checkBoxC7 = new System.Windows.Forms.CheckBox();
		this.buttonChetaoHuyentinh = new System.Windows.Forms.Button();
		this.checkBoxC1 = new System.Windows.Forms.CheckBox();
		this.buttonStopNangcapHT = new System.Windows.Forms.Button();
		this.checkBoxNguyenlieuBH = new System.Windows.Forms.CheckBox();
		this.checkBoxC3 = new System.Windows.Forms.CheckBox();
		this.checkBoxC9 = new System.Windows.Forms.CheckBox();
		this.checkBoxC6 = new System.Windows.Forms.CheckBox();
		this.buttonBatdauNangcap = new System.Windows.Forms.Button();
		this.checkBoxC4 = new System.Windows.Forms.CheckBox();
		this.checkBoxC2 = new System.Windows.Forms.CheckBox();
		this.checkBoxC5 = new System.Windows.Forms.CheckBox();
		this.textBoxHT = new System.Windows.Forms.TextBox();
		this.groupBoxNangCap = new System.Windows.Forms.GroupBox();
		this.groupBoxNangCap.SuspendLayout();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonClose.BackColor = System.Drawing.SystemColors.Control;
		this.buttonClose.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.buttonClose.ForeColor = System.Drawing.Color.Black;
		this.buttonClose.Location = new System.Drawing.Point(240, 232);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(76, 36);
		this.buttonClose.TabIndex = 139;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = false;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.linkLabelPhimCheTaoHT.AutoSize = true;
		this.linkLabelPhimCheTaoHT.Location = new System.Drawing.Point(3, 213);
		this.linkLabelPhimCheTaoHT.Name = "linkLabelPhimCheTaoHT";
		this.linkLabelPhimCheTaoHT.Size = new System.Drawing.Size(61, 13);
		this.linkLabelPhimCheTaoHT.TabIndex = 164;
		this.linkLabelPhimCheTaoHT.TabStop = true;
		this.linkLabelPhimCheTaoHT.Text = "Phim H.dẫn";
		this.linkLabelPhimCheTaoHT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelPhimCheTaoHT_LinkClicked);
		this.linkLabelHDHT.AutoSize = true;
		this.linkLabelHDHT.Location = new System.Drawing.Point(3, 190);
		this.linkLabelHDHT.Name = "linkLabelHDHT";
		this.linkLabelHDHT.Size = new System.Drawing.Size(60, 13);
		this.linkLabelHDHT.TabIndex = 163;
		this.linkLabelHDHT.TabStop = true;
		this.linkLabelHDHT.Text = "Hướng dẫn";
		this.linkLabelHDHT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelHDHT_LinkClicked);
		this.buttonDungChetao.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonDungChetao.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonDungChetao.Location = new System.Drawing.Point(154, 232);
		this.buttonDungChetao.Name = "buttonDungChetao";
		this.buttonDungChetao.Size = new System.Drawing.Size(80, 36);
		this.buttonDungChetao.TabIndex = 12;
		this.buttonDungChetao.Text = "Dừng chế tạo";
		this.buttonDungChetao.UseVisualStyleBackColor = false;
		this.buttonDungChetao.Click += new System.EventHandler(buttonDungChetao_Click);
		this.checkBoxC8.AutoSize = true;
		this.checkBoxC8.Location = new System.Drawing.Point(202, 53);
		this.checkBoxC8.Name = "checkBoxC8";
		this.checkBoxC8.Size = new System.Drawing.Size(78, 17);
		this.checkBoxC8.TabIndex = 8;
		this.checkBoxC8.Text = "Cấp 8 -> 9";
		this.checkBoxC8.UseVisualStyleBackColor = true;
		this.checkBoxC8.CheckedChanged += new System.EventHandler(checkBoxC8_CheckedChanged);
		this.checkBoxC7.AutoSize = true;
		this.checkBoxC7.Location = new System.Drawing.Point(202, 30);
		this.checkBoxC7.Name = "checkBoxC7";
		this.checkBoxC7.Size = new System.Drawing.Size(78, 17);
		this.checkBoxC7.TabIndex = 7;
		this.checkBoxC7.Text = "Cấp 7 -> 8";
		this.checkBoxC7.UseVisualStyleBackColor = true;
		this.checkBoxC7.CheckedChanged += new System.EventHandler(checkBoxC7_CheckedChanged);
		this.buttonChetaoHuyentinh.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonChetaoHuyentinh.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonChetaoHuyentinh.Location = new System.Drawing.Point(68, 232);
		this.buttonChetaoHuyentinh.Name = "buttonChetaoHuyentinh";
		this.buttonChetaoHuyentinh.Size = new System.Drawing.Size(80, 36);
		this.buttonChetaoHuyentinh.TabIndex = 11;
		this.buttonChetaoHuyentinh.Text = "Bắt đầu chế tạo";
		this.buttonChetaoHuyentinh.UseVisualStyleBackColor = false;
		this.buttonChetaoHuyentinh.Click += new System.EventHandler(buttonChetaoHuyentinh_Click);
		this.checkBoxC1.AutoSize = true;
		this.checkBoxC1.Location = new System.Drawing.Point(12, 30);
		this.checkBoxC1.Name = "checkBoxC1";
		this.checkBoxC1.Size = new System.Drawing.Size(78, 17);
		this.checkBoxC1.TabIndex = 1;
		this.checkBoxC1.Text = "Cấp 1 -> 2";
		this.checkBoxC1.UseVisualStyleBackColor = true;
		this.checkBoxC1.CheckedChanged += new System.EventHandler(checkBoxC1_CheckedChanged);
		this.buttonStopNangcapHT.Location = new System.Drawing.Point(154, 190);
		this.buttonStopNangcapHT.Name = "buttonStopNangcapHT";
		this.buttonStopNangcapHT.Size = new System.Drawing.Size(80, 36);
		this.buttonStopNangcapHT.TabIndex = 11;
		this.buttonStopNangcapHT.Text = "Dừng nâng cấp";
		this.buttonStopNangcapHT.UseVisualStyleBackColor = true;
		this.buttonStopNangcapHT.Click += new System.EventHandler(buttonStopNangcapHT_Click);
		this.checkBoxNguyenlieuBH.AutoSize = true;
		this.checkBoxNguyenlieuBH.ForeColor = System.Drawing.Color.Black;
		this.checkBoxNguyenlieuBH.Location = new System.Drawing.Point(12, 108);
		this.checkBoxNguyenlieuBH.Name = "checkBoxNguyenlieuBH";
		this.checkBoxNguyenlieuBH.Size = new System.Drawing.Size(281, 17);
		this.checkBoxNguyenlieuBH.TabIndex = 13;
		this.checkBoxNguyenlieuBH.Text = "Có lấy nguyên liệu trong rương bang hội đem chế tạo";
		this.checkBoxNguyenlieuBH.UseVisualStyleBackColor = true;
		this.checkBoxNguyenlieuBH.CheckedChanged += new System.EventHandler(checkBoxNguyenlieuBH_CheckedChanged);
		this.checkBoxC3.AutoSize = true;
		this.checkBoxC3.Location = new System.Drawing.Point(12, 76);
		this.checkBoxC3.Name = "checkBoxC3";
		this.checkBoxC3.Size = new System.Drawing.Size(78, 17);
		this.checkBoxC3.TabIndex = 3;
		this.checkBoxC3.Text = "Cấp 3 -> 4";
		this.checkBoxC3.UseVisualStyleBackColor = true;
		this.checkBoxC3.CheckedChanged += new System.EventHandler(checkBoxC3_CheckedChanged);
		this.checkBoxC9.AutoSize = true;
		this.checkBoxC9.Location = new System.Drawing.Point(202, 76);
		this.checkBoxC9.Name = "checkBoxC9";
		this.checkBoxC9.Size = new System.Drawing.Size(84, 17);
		this.checkBoxC9.TabIndex = 9;
		this.checkBoxC9.Text = "Cấp 9 -> 10";
		this.checkBoxC9.UseVisualStyleBackColor = true;
		this.checkBoxC9.CheckedChanged += new System.EventHandler(checkBoxC9_CheckedChanged);
		this.checkBoxC6.AutoSize = true;
		this.checkBoxC6.Location = new System.Drawing.Point(104, 76);
		this.checkBoxC6.Name = "checkBoxC6";
		this.checkBoxC6.Size = new System.Drawing.Size(78, 17);
		this.checkBoxC6.TabIndex = 6;
		this.checkBoxC6.Text = "Cấp 6 -> 7";
		this.checkBoxC6.UseVisualStyleBackColor = true;
		this.checkBoxC6.CheckedChanged += new System.EventHandler(checkBoxC6_CheckedChanged);
		this.buttonBatdauNangcap.Location = new System.Drawing.Point(68, 190);
		this.buttonBatdauNangcap.Name = "buttonBatdauNangcap";
		this.buttonBatdauNangcap.Size = new System.Drawing.Size(80, 36);
		this.buttonBatdauNangcap.TabIndex = 10;
		this.buttonBatdauNangcap.Text = "Bắt đầu nâng cấp";
		this.buttonBatdauNangcap.UseVisualStyleBackColor = true;
		this.buttonBatdauNangcap.Click += new System.EventHandler(buttonBatdauNangcap_Click);
		this.checkBoxC4.AutoSize = true;
		this.checkBoxC4.Location = new System.Drawing.Point(104, 30);
		this.checkBoxC4.Name = "checkBoxC4";
		this.checkBoxC4.Size = new System.Drawing.Size(78, 17);
		this.checkBoxC4.TabIndex = 4;
		this.checkBoxC4.Text = "Cấp 4 -> 5";
		this.checkBoxC4.UseVisualStyleBackColor = true;
		this.checkBoxC4.CheckedChanged += new System.EventHandler(checkBoxC4_CheckedChanged);
		this.checkBoxC2.AutoSize = true;
		this.checkBoxC2.Location = new System.Drawing.Point(12, 53);
		this.checkBoxC2.Name = "checkBoxC2";
		this.checkBoxC2.Size = new System.Drawing.Size(78, 17);
		this.checkBoxC2.TabIndex = 2;
		this.checkBoxC2.Text = "Cấp 2 -> 3";
		this.checkBoxC2.UseVisualStyleBackColor = true;
		this.checkBoxC2.CheckedChanged += new System.EventHandler(checkBoxC2_CheckedChanged);
		this.checkBoxC5.AutoSize = true;
		this.checkBoxC5.Location = new System.Drawing.Point(104, 53);
		this.checkBoxC5.Name = "checkBoxC5";
		this.checkBoxC5.Size = new System.Drawing.Size(78, 17);
		this.checkBoxC5.TabIndex = 5;
		this.checkBoxC5.Text = "Cấp 5 -> 6";
		this.checkBoxC5.UseVisualStyleBackColor = true;
		this.checkBoxC5.CheckedChanged += new System.EventHandler(checkBoxC5_CheckedChanged);
		this.textBoxHT.BackColor = System.Drawing.SystemColors.Control;
		this.textBoxHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxHT.Location = new System.Drawing.Point(6, 161);
		this.textBoxHT.Name = "textBoxHT";
		this.textBoxHT.Size = new System.Drawing.Size(310, 14);
		this.textBoxHT.TabIndex = 13;
		this.textBoxHT.Text = "Thông tin: ...";
		this.groupBoxNangCap.Controls.Add(this.checkBoxC8);
		this.groupBoxNangCap.Controls.Add(this.checkBoxC7);
		this.groupBoxNangCap.Controls.Add(this.checkBoxC1);
		this.groupBoxNangCap.Controls.Add(this.checkBoxNguyenlieuBH);
		this.groupBoxNangCap.Controls.Add(this.checkBoxC5);
		this.groupBoxNangCap.Controls.Add(this.checkBoxC3);
		this.groupBoxNangCap.Controls.Add(this.checkBoxC2);
		this.groupBoxNangCap.Controls.Add(this.checkBoxC9);
		this.groupBoxNangCap.Controls.Add(this.checkBoxC4);
		this.groupBoxNangCap.Controls.Add(this.checkBoxC6);
		this.groupBoxNangCap.Location = new System.Drawing.Point(6, 12);
		this.groupBoxNangCap.Name = "groupBoxNangCap";
		this.groupBoxNangCap.Size = new System.Drawing.Size(310, 143);
		this.groupBoxNangCap.TabIndex = 166;
		this.groupBoxNangCap.TabStop = false;
		this.groupBoxNangCap.Text = "CHẾ TẠO VÀ NÂNG CẤP HUYỀN TINH";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.LightSteelBlue;
		base.ClientSize = new System.Drawing.Size(324, 275);
		base.Controls.Add(this.groupBoxNangCap);
		base.Controls.Add(this.buttonDungChetao);
		base.Controls.Add(this.linkLabelHDHT);
		base.Controls.Add(this.linkLabelPhimCheTaoHT);
		base.Controls.Add(this.buttonChetaoHuyentinh);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.textBoxHT);
		base.Controls.Add(this.buttonStopNangcapHT);
		base.Controls.Add(this.buttonBatdauNangcap);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormHuyenTinh";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "HUYEN TINH";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormHuyenTinh_Load);
		this.groupBoxNangCap.ResumeLayout(false);
		this.groupBoxNangCap.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void FormHuyenTinh_Load(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (0 > num)
		{
			groupBoxNangCap.Enabled = false;
			buttonBatdauNangcap.Enabled = false;
			buttonChetaoHuyentinh.Enabled = false;
			textBoxHT.Text = "Chưa chọn ac nào, hãy chọn 1 ac rồi vào đây thiết lập";
		}
		else
		{
			CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[num];
			if (characterAccountConfig.byte_0[0] > 0)
			{
				textBoxHT.Text = "Đang tiến hành nâng cấp huyền tinh...";
			}
			else if (characterAccountConfig.bool_6)
			{
				textBoxHT.Text = "Đang tiến hành chế tạo huyền tinh...";
			}
			checkBoxNguyenlieuBH.Checked = Class25.int_1 > 0;
			method_0(characterAccountConfig.byte_0);
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		bool_1 = true;
		base.TopMost = true;
		base.Top = Cursor.Position.Y - base.Height - 10;
		base.Left = Cursor.Position.X - base.Width - 10;
	}

	private void method_0(byte[] byte_0)
	{
		buttonBatdauNangcap.Enabled = byte_0[0] == 0;
		checkBoxC1.Checked = byte_0[1] > 0;
		checkBoxC2.Checked = byte_0[2] > 0;
		checkBoxC3.Checked = byte_0[3] > 0;
		checkBoxC4.Checked = byte_0[4] > 0;
		checkBoxC5.Checked = byte_0[5] > 0;
		checkBoxC6.Checked = byte_0[6] > 0;
		checkBoxC7.Checked = byte_0[7] > 0;
		checkBoxC8.Checked = byte_0[8] > 0;
		checkBoxC9.Checked = byte_0[9] > 0;
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		int_0 = 0;
		bool_0 = false;
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

	private void buttonStopNangcapHT_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num >= 0)
		{
			Form1.characterAccountConfig_1[num].byte_0[0] = 0;
			buttonBatdauNangcap.Enabled = true;
			textBoxHT.Text = "Kết thúc nâng cấp!";
		}
	}

	private void buttonBatdauNangcap_Click(object sender, EventArgs e)
	{
		if (Class25.int_0 <= 0)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				buttonBatdauNangcap.Enabled = false;
				Form1.characterAccountConfig_1[num].byte_0[0] = 1;
				Class25.int_0 = Form1.characterAccountConfig_1[num].int_136;
				textBoxHT.Text = "Đang tiến hành nâng cấp huyền tinh...";
				new Thread(new Class25().method_0).Start();
			}
		}
	}

	private void buttonChetaoHuyentinh_Click(object sender, EventArgs e)
	{
		if (Class25.int_0 <= 0)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				textBoxHT.Text = "Đang tiến hành chế tạo huyền tinh...";
				Class25.int_0 = Form1.characterAccountConfig_1[num].int_136;
				new Thread(new Class25().method_1).Start();
			}
		}
	}

	private void buttonDungChetao_Click(object sender, EventArgs e)
	{
		if (Class25.int_0 <= 0)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].bool_6 = false;
				textBoxHT.Text = "Kết thúc chế tạo.";
			}
		}
	}

	private void checkBoxNguyenlieuBH_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class25.int_1 = Convert.ToByte(checkBoxNguyenlieuBH.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagNguyenlieuBH", Class25.int_1, "", 0);
		}
	}

	private void checkBoxC1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].byte_0[1] = Convert.ToByte(checkBoxC1.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxC2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].byte_0[2] = Convert.ToByte(checkBoxC2.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxC3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].byte_0[3] = Convert.ToByte(checkBoxC3.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxC4_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].byte_0[4] = Convert.ToByte(checkBoxC4.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxC5_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].byte_0[5] = Convert.ToByte(checkBoxC5.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxC6_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].byte_0[6] = Convert.ToByte(checkBoxC6.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxC7_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].byte_0[7] = Convert.ToByte(checkBoxC7.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxC8_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].byte_0[8] = Convert.ToByte(checkBoxC8.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxC9_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].byte_0[9] = Convert.ToByte(checkBoxC9.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void linkLabelPhimCheTaoHT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "https://youtu.be/LLMBuNwXzLw";
		Class11.string_17 = new string[1] { "Xem video hướng dẫn tại: " + text };
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
	}

	private void linkLabelHDHT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string string_ = "=========================================|CHẾ TẠO HUYỀN TINH KHÔNG CẦN VỀ THÀNH|=========================================||Yêu cầu: Phải có đủ ngân lượng và nguyên liệu (nhẫn, dây chuyền, ngọc bội) được đặt ở Hành trang hoặc rương bang hội.||Chức năng tự chế tạo Huyền tinh ở mục train được thực hiện khi thỏa điều kiện:||- Đang check vào mục train.|- Đang ở nơi chiến đấu hoặc là đang ở chế độ lượm rác|Sau mỗi 60 giây auto sẽ kiểm tra và thực hiện chế tạo 1 lần.||=========================================|NÂNG CẤP HUYỀN TINH|=========================================|Yêu cầu: Mở sẵn bảng chế tạo tại thợ rèn (sau đó tắt đi cũng được). Nếu không mở thì game sẽ báo lỗi phi pháp.|";
		FormTip.smethod_0(Form1.string_49, string_, 600000, 420, 340, bool_8: false, base.Left, base.Top);
	}
}
