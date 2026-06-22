using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns100;
using ns11;
using ns53;
using ns71;
using ns79;
using ns83;

namespace ns137;

public class FormTienSkill : Form
{
	public static bool bool_0 = false;

	public static int int_0 = 0;

	private static GStruct58[] gstruct58_0;

	private bool bool_1 = false;

	private bool bool_2 = false;

	private uint uint_0 = 0u;

	private string[] string_0 = new string[3] { "Chỉ phát chiêu 1 lần khi vừa gặp địch", "Phát chiêu lặp lại theo thời gian", "Phát và dừng chiêu theo khoảng cách" };

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private ComboBox comboBoxChieuthuc;

	private Button buttonClose;

	private Label label2;

	private TextBox textBoxThoigian;

	private Label label3;

	private RichTextBox richTextBox1;

	private Button buttonThuGanChieu;

	private ComboBox comboBoxKieudanh;

	private Label label1;

	private CheckBox checkBoxKethop;

	private Label label4;

	private CheckBox checkBoxQuai;

	private Label label5;

	private ComboBox comboBoxHieuUng;

	private Label label6;

	private TextBox textBoxKhoangCach;

	private CheckBox checkBoxDieuchinh;

	private TextBox textBoxDieuchinh;

	public FormTienSkill()
	{
		bool_0 = true;
		bool_1 = false;
		bool_2 = false;
		uint_0 = 0u;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	private void FormTienSkill_Load(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			int_0 = 0;
			bool_0 = false;
			return;
		}
		CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
		gstruct58_0 = Class83.smethod_22(characterAccountConfig_);
		if (gstruct58_0 != null)
		{
			int int_ = Form1.characterAccountConfig_1[num].gstruct50_0.int_1;
			string text = null;
			for (int i = 0; i < gstruct58_0.Length; i++)
			{
				comboBoxChieuthuc.Items.Add(gstruct58_0[i].string_0);
				if (int_ > 0 && gstruct58_0[i].int_1 == int_)
				{
					text = gstruct58_0[i].string_0;
				}
			}
			if (text != null && text != string.Empty)
			{
				comboBoxChieuthuc.Text = text;
			}
		}
		for (int j = 0; j < string_0.Length; j++)
		{
			comboBoxKieudanh.Items.Add(string_0[j]);
		}
		comboBoxKieudanh.Text = string_0[characterAccountConfig_.gstruct50_0.int_2];
		textBoxThoigian.Text = characterAccountConfig_.gstruct50_0.int_3.ToString();
		textBoxKhoangCach.Text = characterAccountConfig_.gstruct50_0.int_7.ToString();
		checkBoxKethop.Checked = characterAccountConfig_.gstruct50_0.int_4 > 0;
		checkBoxQuai.Checked = characterAccountConfig_.gstruct50_0.int_5 > 0;
		textBoxThoigian.Enabled = characterAccountConfig_.gstruct50_0.int_2 == 1;
		textBoxKhoangCach.Enabled = characterAccountConfig_.gstruct50_0.int_2 == 2;
		for (int k = 0; k < 100; k++)
		{
			comboBoxHieuUng.Items.Add(k);
		}
		comboBoxHieuUng.Text = characterAccountConfig_.gstruct50_0.int_6.ToString();
		checkBoxDieuchinh.Checked = characterAccountConfig_.gstruct50_0.int_8 > 0;
		textBoxDieuchinh.Text = characterAccountConfig_.gstruct50_0.int_9.ToString();
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		bool_1 = true;
		base.TopMost = true;
		base.Top = Cursor.Position.Y - base.Height - 10;
		base.Left = Cursor.Position.X - base.Width - 10;
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (0 <= num)
		{
			if (bool_2)
			{
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
			if (uint_0 != 0)
			{
				Class83.smethod_15(Form1.characterAccountConfig_1[num], uint_0);
				Class75.smethod_31(Form1.characterAccountConfig_1[num], uint_0);
			}
		}
		int_0 = 0;
		uint_0 = 0u;
		bool_0 = false;
		bool_2 = false;
		bool_1 = false;
		gstruct58_0 = null;
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

	private void textBoxThoigian_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (0 <= num)
			{
				Form1.characterAccountConfig_1[num].gstruct50_0.int_3 = Class11.smethod_11(textBoxThoigian.Text);
				bool_2 = true;
			}
		}
	}

	private void comboBoxChieuthuc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1 || gstruct58_0 == null)
		{
			return;
		}
		int num = -1;
		string text = comboBoxChieuthuc.Text;
		for (int i = 0; i < gstruct58_0.Length; i++)
		{
			if (text == gstruct58_0[i].string_0)
			{
				num = gstruct58_0[i].int_1;
				break;
			}
		}
		int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num > 0 && 0 <= num2)
		{
			Form1.characterAccountConfig_1[num2].gstruct50_0.int_1 = num;
			bool_2 = true;
		}
	}

	private void buttonThuGanChieu_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
		if (characterAccountConfig_.gstruct50_0.int_1 > 0)
		{
			if (uint_0 == 0)
			{
				uint_0 = (uint)Class83.smethod_13(characterAccountConfig_);
			}
			Class83.smethod_15(characterAccountConfig_, (uint)characterAccountConfig_.gstruct50_0.int_1);
			Class75.smethod_31(characterAccountConfig_, (uint)characterAccountConfig_.gstruct50_0.int_1);
		}
	}

	private void comboBoxKieudanh_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxKieudanh.Text;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (text == string_0[i])
			{
				Form1.characterAccountConfig_1[num].gstruct50_0.int_2 = i;
				textBoxThoigian.Enabled = i == 1;
				textBoxKhoangCach.Enabled = i == 2;
				bool_2 = true;
				break;
			}
		}
	}

	private void checkBoxKethop_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (0 <= num)
			{
				Form1.characterAccountConfig_1[num].gstruct50_0.int_4 = Convert.ToByte(checkBoxKethop.Checked);
				bool_2 = true;
			}
		}
	}

	private void checkBoxQuai_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (0 <= num)
			{
				Form1.characterAccountConfig_1[num].gstruct50_0.int_5 = Convert.ToByte(checkBoxQuai.Checked);
				bool_2 = true;
			}
		}
	}

	private void comboBoxHieuUng_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (0 <= num)
			{
				Form1.characterAccountConfig_1[num].gstruct50_0.int_6 = Class11.smethod_11(comboBoxHieuUng.Text);
				bool_2 = true;
			}
		}
	}

	private void textBoxKhoangCach_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (0 <= num)
			{
				Form1.characterAccountConfig_1[num].gstruct50_0.int_7 = Class11.smethod_11(textBoxKhoangCach.Text);
				bool_2 = true;
			}
		}
	}

	private void checkBoxDieuchinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (0 <= num)
			{
				Form1.characterAccountConfig_1[num].gstruct50_0.int_8 = Convert.ToByte(checkBoxDieuchinh.Checked);
				bool_2 = true;
			}
		}
	}

	private void textBoxDieuchinh_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (0 <= num)
			{
				Form1.characterAccountConfig_1[num].gstruct50_0.int_9 = Class11.smethod_11(textBoxDieuchinh.Text);
				bool_2 = true;
			}
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns137.FormTienSkill));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.comboBoxChieuthuc = new System.Windows.Forms.ComboBox();
		this.buttonClose = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.textBoxThoigian = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.buttonThuGanChieu = new System.Windows.Forms.Button();
		this.comboBoxKieudanh = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.checkBoxKethop = new System.Windows.Forms.CheckBox();
		this.label4 = new System.Windows.Forms.Label();
		this.checkBoxQuai = new System.Windows.Forms.CheckBox();
		this.label5 = new System.Windows.Forms.Label();
		this.comboBoxHieuUng = new System.Windows.Forms.ComboBox();
		this.label6 = new System.Windows.Forms.Label();
		this.textBoxKhoangCach = new System.Windows.Forms.TextBox();
		this.checkBoxDieuchinh = new System.Windows.Forms.CheckBox();
		this.textBoxDieuchinh = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.comboBoxChieuthuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxChieuthuc.DropDownWidth = 220;
		this.comboBoxChieuthuc.FormattingEnabled = true;
		this.comboBoxChieuthuc.Location = new System.Drawing.Point(76, 145);
		this.comboBoxChieuthuc.Name = "comboBoxChieuthuc";
		this.comboBoxChieuthuc.Size = new System.Drawing.Size(241, 21);
		this.comboBoxChieuthuc.TabIndex = 11;
		this.comboBoxChieuthuc.SelectedIndexChanged += new System.EventHandler(comboBoxChieuthuc_SelectedIndexChanged);
		this.buttonClose.Location = new System.Drawing.Point(323, 369);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(78, 32);
		this.buttonClose.TabIndex = 15;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(116, 205);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(195, 13);
		this.label2.TabIndex = 17;
		this.label2.Text = "Thời gian giữa 2 lần phát tiền chiêu (ms)";
		this.textBoxThoigian.Location = new System.Drawing.Point(323, 202);
		this.textBoxThoigian.Name = "textBoxThoigian";
		this.textBoxThoigian.Size = new System.Drawing.Size(60, 20);
		this.textBoxThoigian.TabIndex = 18;
		this.textBoxThoigian.TextChanged += new System.EventHandler(textBoxThoigian_TextChanged);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(3, 148);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(66, 13);
		this.label3.TabIndex = 21;
		this.label3.Text = "- Tiền chiêu:";
		this.richTextBox1.Location = new System.Drawing.Point(1, 1);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.Size = new System.Drawing.Size(400, 131);
		this.richTextBox1.TabIndex = 22;
		this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
		this.buttonThuGanChieu.Location = new System.Drawing.Point(323, 145);
		this.buttonThuGanChieu.Name = "buttonThuGanChieu";
		this.buttonThuGanChieu.Size = new System.Drawing.Size(78, 38);
		this.buttonThuGanChieu.TabIndex = 23;
		this.buttonThuGanChieu.Text = "Thử gán tay trái";
		this.buttonThuGanChieu.UseVisualStyleBackColor = true;
		this.buttonThuGanChieu.Click += new System.EventHandler(buttonThuGanChieu_Click);
		this.comboBoxKieudanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxKieudanh.DropDownWidth = 220;
		this.comboBoxKieudanh.FormattingEnabled = true;
		this.comboBoxKieudanh.Location = new System.Drawing.Point(76, 171);
		this.comboBoxKieudanh.Name = "comboBoxKieudanh";
		this.comboBoxKieudanh.Size = new System.Drawing.Size(241, 21);
		this.comboBoxKieudanh.TabIndex = 24;
		this.comboBoxKieudanh.SelectedIndexChanged += new System.EventHandler(comboBoxKieudanh_SelectedIndexChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(3, 174);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(65, 13);
		this.label1.TabIndex = 25;
		this.label1.Text = "- Kiểu đánh:";
		this.checkBoxKethop.AutoSize = true;
		this.checkBoxKethop.ForeColor = System.Drawing.Color.DarkBlue;
		this.checkBoxKethop.Location = new System.Drawing.Point(6, 348);
		this.checkBoxKethop.Name = "checkBoxKethop";
		this.checkBoxKethop.Size = new System.Drawing.Size(237, 17);
		this.checkBoxKethop.TabIndex = 26;
		this.checkBoxKethop.Text = "Phát tiền chiêu theo kiểu nhấn phím kết hợp";
		this.checkBoxKethop.UseVisualStyleBackColor = true;
		this.checkBoxKethop.CheckedChanged += new System.EventHandler(checkBoxKethop_CheckedChanged);
		this.label4.ForeColor = System.Drawing.Color.DimGray;
		this.label4.Location = new System.Drawing.Point(7, 375);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(289, 30);
		this.label4.TabIndex = 27;
		this.label4.Text = "Một số chiêu thức không thể đánh bình thường mả phải kết hợp, các bạn hãy test để biết tiền chiêu là loại nào nhé";
		this.checkBoxQuai.AutoSize = true;
		this.checkBoxQuai.ForeColor = System.Drawing.Color.DarkBlue;
		this.checkBoxQuai.Location = new System.Drawing.Point(6, 320);
		this.checkBoxQuai.Name = "checkBoxQuai";
		this.checkBoxQuai.Size = new System.Drawing.Size(305, 17);
		this.checkBoxQuai.TabIndex = 28;
		this.checkBoxQuai.Text = "Đánh cả quái và boss (nếu không chọn thì chỉ đánh người)";
		this.checkBoxQuai.UseVisualStyleBackColor = true;
		this.checkBoxQuai.CheckedChanged += new System.EventHandler(checkBoxQuai_CheckedChanged);
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(129, 257);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(182, 13);
		this.label5.TabIndex = 29;
		this.label5.Text = "Thời gian khôi phục chiêu thức (giây)";
		this.comboBoxHieuUng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxHieuUng.FormattingEnabled = true;
		this.comboBoxHieuUng.Location = new System.Drawing.Point(323, 254);
		this.comboBoxHieuUng.Name = "comboBoxHieuUng";
		this.comboBoxHieuUng.Size = new System.Drawing.Size(60, 21);
		this.comboBoxHieuUng.TabIndex = 30;
		this.comboBoxHieuUng.SelectedIndexChanged += new System.EventHandler(comboBoxHieuUng_SelectedIndexChanged);
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(102, 231);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(209, 13);
		this.label6.TabIndex = 31;
		this.label6.Text = "Không phát tiền chiêu khi khoảng cách <=";
		this.textBoxKhoangCach.Location = new System.Drawing.Point(323, 228);
		this.textBoxKhoangCach.Name = "textBoxKhoangCach";
		this.textBoxKhoangCach.Size = new System.Drawing.Size(60, 20);
		this.textBoxKhoangCach.TabIndex = 32;
		this.textBoxKhoangCach.TextChanged += new System.EventHandler(textBoxKhoangCach_TextChanged);
		this.checkBoxDieuchinh.AutoSize = true;
		this.checkBoxDieuchinh.Location = new System.Drawing.Point(6, 289);
		this.checkBoxDieuchinh.Name = "checkBoxDieuchinh";
		this.checkBoxDieuchinh.Size = new System.Drawing.Size(313, 17);
		this.checkBoxDieuchinh.TabIndex = 33;
		this.checkBoxDieuchinh.Text = "Điều chỉnh lại khoảng cách tìm ac chính để ac không bị giật";
		this.checkBoxDieuchinh.UseVisualStyleBackColor = true;
		this.checkBoxDieuchinh.CheckedChanged += new System.EventHandler(checkBoxDieuchinh_CheckedChanged);
		this.textBoxDieuchinh.Location = new System.Drawing.Point(323, 287);
		this.textBoxDieuchinh.Name = "textBoxDieuchinh";
		this.textBoxDieuchinh.Size = new System.Drawing.Size(60, 20);
		this.textBoxDieuchinh.TabIndex = 34;
		this.textBoxDieuchinh.TextChanged += new System.EventHandler(textBoxDieuchinh_TextChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(404, 410);
		base.Controls.Add(this.textBoxDieuchinh);
		base.Controls.Add(this.checkBoxDieuchinh);
		base.Controls.Add(this.textBoxKhoangCach);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.comboBoxHieuUng);
		base.Controls.Add(this.comboBoxKieudanh);
		base.Controls.Add(this.textBoxThoigian);
		base.Controls.Add(this.comboBoxChieuthuc);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.checkBoxQuai);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.checkBoxKethop);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.buttonThuGanChieu);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormTienSkill";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "TIỀN CHIÊU";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormTienSkill_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
