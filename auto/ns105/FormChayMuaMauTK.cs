using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns143;
using ns23;
using ns35;
using ns36;
using ns56;
using ns63;
using ns83;

namespace ns105;

public class FormChayMuaMauTK : Form
{
	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Label label1;

	private Label label2;

	private Label label3;

	private TextBox textBoxCong1;

	private TextBox textBoxCong2;

	private Button buttonLay1;

	private Button buttonLay2;

	private Button buttonPhim;

	private Button buttonClose;

	private TextBox textBoxText;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public FormChayMuaMauTK()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns105.FormChayMuaMauTK));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.textBoxCong1 = new System.Windows.Forms.TextBox();
		this.textBoxCong2 = new System.Windows.Forms.TextBox();
		this.buttonLay1 = new System.Windows.Forms.Button();
		this.buttonLay2 = new System.Windows.Forms.Button();
		this.buttonPhim = new System.Windows.Forms.Button();
		this.buttonClose = new System.Windows.Forms.Button();
		this.textBoxText = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(5, 9);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(164, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "Lấy Tọa độ vị trí cổng hậu doanh";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(5, 41);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(137, 13);
		this.label2.TabIndex = 1;
		this.label2.Text = "Tọa độ ngoài, xa mép cổng";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(5, 66);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(143, 13);
		this.label3.TabIndex = 2;
		this.label3.Text = "Tọa độ ngoài, gần mép cổng";
		this.textBoxCong1.Location = new System.Drawing.Point(160, 38);
		this.textBoxCong1.Name = "textBoxCong1";
		this.textBoxCong1.ReadOnly = true;
		this.textBoxCong1.Size = new System.Drawing.Size(87, 21);
		this.textBoxCong1.TabIndex = 3;
		this.textBoxCong2.Location = new System.Drawing.Point(160, 63);
		this.textBoxCong2.Name = "textBoxCong2";
		this.textBoxCong2.ReadOnly = true;
		this.textBoxCong2.Size = new System.Drawing.Size(87, 21);
		this.textBoxCong2.TabIndex = 4;
		this.buttonLay1.Location = new System.Drawing.Point(256, 35);
		this.buttonLay1.Name = "buttonLay1";
		this.buttonLay1.Size = new System.Drawing.Size(59, 23);
		this.buttonLay1.TabIndex = 5;
		this.buttonLay1.Text = "Lấy (1)";
		this.buttonLay1.UseVisualStyleBackColor = true;
		this.buttonLay1.Click += new System.EventHandler(buttonLay1_Click);
		this.buttonLay2.Location = new System.Drawing.Point(256, 61);
		this.buttonLay2.Name = "buttonLay2";
		this.buttonLay2.Size = new System.Drawing.Size(59, 23);
		this.buttonLay2.TabIndex = 6;
		this.buttonLay2.Text = "Lấy (2)";
		this.buttonLay2.UseVisualStyleBackColor = true;
		this.buttonLay2.Click += new System.EventHandler(buttonLay2_Click);
		this.buttonPhim.Location = new System.Drawing.Point(61, 109);
		this.buttonPhim.Name = "buttonPhim";
		this.buttonPhim.Size = new System.Drawing.Size(137, 26);
		this.buttonPhim.TabIndex = 7;
		this.buttonPhim.Text = "Phim hướng dẫn";
		this.buttonPhim.UseVisualStyleBackColor = true;
		this.buttonPhim.Click += new System.EventHandler(buttonPhim_Click);
		this.buttonClose.Location = new System.Drawing.Point(204, 109);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(111, 26);
		this.buttonClose.TabIndex = 8;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.textBoxText.BackColor = System.Drawing.Color.LightSteelBlue;
		this.textBoxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxText.Location = new System.Drawing.Point(182, 10);
		this.textBoxText.Name = "textBoxText";
		this.textBoxText.ReadOnly = true;
		this.textBoxText.Size = new System.Drawing.Size(128, 14);
		this.textBoxText.TabIndex = 9;
		this.textBoxText.Text = "...";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.LightSteelBlue;
		base.ClientSize = new System.Drawing.Size(326, 147);
		base.Controls.Add(this.textBoxText);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.buttonPhim);
		base.Controls.Add(this.buttonLay2);
		base.Controls.Add(this.buttonLay1);
		base.Controls.Add(this.textBoxCong2);
		base.Controls.Add(this.textBoxCong1);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormChayMuaMauTK";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "CONG HAU DOANH";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormChayMuaMauTK_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void FormChayMuaMauTK_Load(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (0 <= num)
		{
			int num2 = Class39.smethod_0(Form1.characterAccountConfig_1[num]);
			if (num2 != Class59.int_1 && Class59.smethod_0(num2) != null)
			{
				Class59.uint_0 = new uint[2];
				Class59.uint_1 = new uint[2];
				Class59.int_1 = 0;
				Class66.smethod_11(Class66.smethod_1(), "CongHauDoanhNgoai_0", Class59.uint_0[0], "", 0);
				Class66.smethod_11(Class66.smethod_1(), "CongHauDoanhNgoai_1", Class59.uint_0[1], "", 0);
				Class66.smethod_11(Class66.smethod_1(), "CongHauDoanhTrong_0", Class59.uint_1[0], "", 0);
				Class66.smethod_11(Class66.smethod_1(), "CongHauDoanhTrong_1", Class59.uint_1[1], "", 0);
				Class66.smethod_11(Class66.smethod_1(), "MapIDCongTongKim", Class59.int_1, "", 0);
				Class66.smethod_11(Class66.smethod_1(), "ThongTinMapTK", "", "", 0);
			}
		}
		textBoxText.Text = Class66.smethod_7("ThongTinMapTK", 0);
		textBoxCong1.Text = Class59.uint_0[0] + "," + Class59.uint_0[1];
		textBoxCong2.Text = Class59.uint_1[0] + "," + Class59.uint_1[1];
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		base.Top = Cursor.Position.Y - base.Height - 10;
		base.Left = Cursor.Position.X - base.Width - 10;
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
		int_0 = 0;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void buttonPhim_Click(object sender, EventArgs e)
	{
		string text = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(text))
		{
			text = Class66.smethod_0();
		}
		Class24.smethod_40(text, "", FormVideoHelp.string_0, 0);
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		bool_0 = false;
	}

	private void buttonLay1_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num >= 0)
		{
			Class59.uint_0 = Class38.smethod_30(Form1.characterAccountConfig_1[num]);
			if (Class59.uint_0 == null)
			{
				Class59.uint_0 = new uint[2];
			}
			Class59.int_1 = Class39.smethod_0(Form1.characterAccountConfig_1[num]);
			string object_ = Class1.smethod_1(Class39.smethod_2(Form1.characterAccountConfig_1[num]), 1) + " (" + Class59.int_1 + ")";
			textBoxCong1.Text = Class59.uint_0[0] + "," + Class59.uint_0[1];
			textBoxText.Text = object_;
			Class66.smethod_11(Class66.smethod_1(), "CongHauDoanhNgoai_0", Class59.uint_0[0], "", 0);
			Class66.smethod_11(Class66.smethod_1(), "CongHauDoanhNgoai_1", Class59.uint_0[1], "", 0);
			Class66.smethod_11(Class66.smethod_1(), "MapIDCongTongKim", Class59.int_1, "", 0);
			Class66.smethod_11(Class66.smethod_1(), "ThongTinMapTK", object_, "", 0);
		}
	}

	private void buttonLay2_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num >= 0)
		{
			Class59.uint_1 = Class38.smethod_30(Form1.characterAccountConfig_1[num]);
			if (Class59.uint_1 == null)
			{
				Class59.uint_1 = new uint[2];
			}
			Class59.int_1 = Class39.smethod_0(Form1.characterAccountConfig_1[num]);
			string object_ = Class1.smethod_1(Class39.smethod_2(Form1.characterAccountConfig_1[num]), 1) + " (" + Class59.int_1 + ")";
			textBoxCong2.Text = Class59.uint_1[0] + "," + Class59.uint_1[1];
			textBoxText.Text = object_;
			Class66.smethod_11(Class66.smethod_1(), "CongHauDoanhTrong_0", Class59.uint_1[0], "", 0);
			Class66.smethod_11(Class66.smethod_1(), "CongHauDoanhTrong_1", Class59.uint_1[1], "", 0);
			Class66.smethod_11(Class66.smethod_1(), "MapIDCongTongKim", Class59.int_1, "", 0);
			Class66.smethod_11(Class66.smethod_1(), "ThongTinMapTK", object_, "", 0);
		}
	}
}
