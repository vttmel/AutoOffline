using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns63;

namespace ns101;

public class FormAchinh : Form
{
	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonClose;

	private ComboBox comboBoxAc;

	private CheckBox checkBoxBamPhim;

	private Label label1;

	private Label label2;

	private Label label3;

	private CheckBox checkBoxAnhien;

	public static string string_0 = Class11.smethod_15(Class66.smethod_7("AccChinh2", 0));

	public static int int_0 = Class66.smethod_4("flagPhim2", 0, "0");

	public static int int_1 = Class66.smethod_4("flagAnHien", 0, "1");

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public static bool bool_0 = false;

	private bool bool_1 = false;

	public FormAchinh()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns101.FormAchinh));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonClose = new System.Windows.Forms.Button();
		this.comboBoxAc = new System.Windows.Forms.ComboBox();
		this.checkBoxBamPhim = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.checkBoxAnhien = new System.Windows.Forms.CheckBox();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonClose.Location = new System.Drawing.Point(109, 126);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(117, 27);
		this.buttonClose.TabIndex = 14;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.comboBoxAc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxAc.FormattingEnabled = true;
		this.comboBoxAc.Location = new System.Drawing.Point(109, 6);
		this.comboBoxAc.Name = "comboBoxAc";
		this.comboBoxAc.Size = new System.Drawing.Size(117, 21);
		this.comboBoxAc.TabIndex = 20;
		this.comboBoxAc.SelectedIndexChanged += new System.EventHandler(comboBoxAc_SelectedIndexChanged);
		this.comboBoxAc.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxAc_MouseDown);
		this.checkBoxBamPhim.AutoSize = true;
		this.checkBoxBamPhim.Location = new System.Drawing.Point(7, 38);
		this.checkBoxBamPhim.Name = "checkBoxBamPhim";
		this.checkBoxBamPhim.Size = new System.Drawing.Size(155, 17);
		this.checkBoxBamPhim.TabIndex = 23;
		this.checkBoxBamPhim.Text = "Đổi ac chính khi bấm phím";
		this.checkBoxBamPhim.UseVisualStyleBackColor = true;
		this.checkBoxBamPhim.CheckedChanged += new System.EventHandler(checkBoxBamPhim_CheckedChanged);
		this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(168, 35);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(58, 20);
		this.label1.TabIndex = 24;
		this.label1.Text = "F2";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(3, 9);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(99, 13);
		this.label2.TabIndex = 25;
		this.label2.Text = "Ac chính dự phòng";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(9, 98);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(218, 13);
		this.label3.TabIndex = 26;
		this.label3.Text = "Lưu ý: check vào sử dụng phím tắt ở phụ trợ";
		this.checkBoxAnhien.AutoSize = true;
		this.checkBoxAnhien.Location = new System.Drawing.Point(6, 63);
		this.checkBoxAnhien.Name = "checkBoxAnhien";
		this.checkBoxAnhien.Size = new System.Drawing.Size(203, 17);
		this.checkBoxAnhien.TabIndex = 27;
		this.checkBoxAnhien.Text = "Ẩn ac chính cũ và hiện ac chính mới";
		this.checkBoxAnhien.UseVisualStyleBackColor = true;
		this.checkBoxAnhien.CheckedChanged += new System.EventHandler(checkBoxAnhien_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(234, 160);
		base.Controls.Add(this.checkBoxAnhien);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.checkBoxBamPhim);
		base.Controls.Add(this.comboBoxAc);
		base.Controls.Add(this.buttonClose);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormAchinh";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "AC_CHINH_DU_PHONG";
		base.Load += new System.EventHandler(FormAchinh_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
	}

	private void FormAchinh_Load(object sender, EventArgs e)
	{
		if (int_2 > 0 && int_3 > 0)
		{
			int num = int_2 - base.Width;
			int num2 = int_3;
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
		checkBoxBamPhim.Checked = int_0 > 0;
		checkBoxAnhien.Checked = int_1 > 0;
		if (string_0 != null && string_0 != string.Empty)
		{
			comboBoxAc.Items.Add(string_0);
			comboBoxAc.Text = string_0;
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		bool_1 = true;
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

	private void comboBoxAc_MouseDown(object sender, MouseEventArgs e)
	{
		if (Form1.characterAccountConfig_1 == null)
		{
			return;
		}
		bool_1 = false;
		Thread.Sleep(100);
		string text = comboBoxAc.Text;
		string text2 = null;
		string text3 = string.Empty;
		comboBoxAc.Items.Clear();
		for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
		{
			text3 = Class1.smethod_1(Form1.characterAccountConfig_1[i].string_22, 1);
			comboBoxAc.Items.Add(text3);
			if (text == text3)
			{
				text2 = text3;
			}
		}
		if (text2 == null)
		{
			if (text != string.Empty && text != null)
			{
				comboBoxAc.Items.Add(text);
				text2 = text;
			}
			else
			{
				text2 = text3;
			}
		}
		comboBoxAc.Items.Add("");
		comboBoxAc.Text = text2;
		bool_1 = true;
	}

	private void comboBoxAc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_1 && timer_0.Enabled)
		{
			string_0 = comboBoxAc.Text;
			Class66.smethod_11(Class66.smethod_1(), "AccChinh2", Class11.smethod_16(string_0), "", 0);
		}
	}

	private void checkBoxBamPhim_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_1 && timer_0.Enabled)
		{
			int_0 = Convert.ToByte(checkBoxBamPhim.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagPhim2", int_0, "", 0);
		}
	}

	private void checkBoxAnhien_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_1 && timer_0.Enabled)
		{
			int_1 = Convert.ToByte(checkBoxAnhien.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagAnHien", int_1, "", 0);
		}
	}
}
