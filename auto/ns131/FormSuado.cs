using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns100;
using ns11;
using ns63;

namespace ns131;

public class FormSuado : Form
{
	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private CheckBox checkBoxOutGameKhidobenThap;

	private TextBox textBoxValueDobenThap;

	private CheckBox checkBoxThodiaphuDobenThap;

	private CheckBox checkBoxKhongSuaTK;

	private CheckBox checkBoxLuonSuaKhiMuathuoc;

	private CheckBox checkBoxBachKim;

	private Label label1;

	private TextBox textBoxPhanTram;

	private Label label2;

	private Label label3;

	private TextBox textBoxDiem;

	private Label label4;

	private Button buttonClose;

	private CheckBox checkBoxPhiChiendau;

	private TextBox textBox1;

	private Label label5;

	private Label label6;

	private CheckBox checkBoxPhimTat;

	public static int int_0 = 0;

	private bool bool_0 = false;

	public FormSuado()
	{
		int_0 = 1;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns131.FormSuado));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.checkBoxOutGameKhidobenThap = new System.Windows.Forms.CheckBox();
		this.textBoxValueDobenThap = new System.Windows.Forms.TextBox();
		this.checkBoxThodiaphuDobenThap = new System.Windows.Forms.CheckBox();
		this.checkBoxKhongSuaTK = new System.Windows.Forms.CheckBox();
		this.checkBoxLuonSuaKhiMuathuoc = new System.Windows.Forms.CheckBox();
		this.checkBoxBachKim = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.textBoxPhanTram = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.textBoxDiem = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.buttonClose = new System.Windows.Forms.Button();
		this.checkBoxPhiChiendau = new System.Windows.Forms.CheckBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.checkBoxPhimTat = new System.Windows.Forms.CheckBox();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.checkBoxOutGameKhidobenThap.AutoSize = true;
		this.checkBoxOutGameKhidobenThap.ForeColor = System.Drawing.Color.Black;
		this.checkBoxOutGameKhidobenThap.Location = new System.Drawing.Point(5, 137);
		this.checkBoxOutGameKhidobenThap.Name = "checkBoxOutGameKhidobenThap";
		this.checkBoxOutGameKhidobenThap.Size = new System.Drawing.Size(208, 17);
		this.checkBoxOutGameKhidobenThap.TabIndex = 174;
		this.checkBoxOutGameKhidobenThap.Text = "Thoát game khi không thể thổ địa phù";
		this.checkBoxOutGameKhidobenThap.UseVisualStyleBackColor = true;
		this.checkBoxOutGameKhidobenThap.CheckedChanged += new System.EventHandler(checkBoxOutGameKhidobenThap_CheckedChanged);
		this.textBoxValueDobenThap.Location = new System.Drawing.Point(220, 112);
		this.textBoxValueDobenThap.Name = "textBoxValueDobenThap";
		this.textBoxValueDobenThap.Size = new System.Drawing.Size(36, 20);
		this.textBoxValueDobenThap.TabIndex = 146;
		this.textBoxValueDobenThap.TextChanged += new System.EventHandler(textBoxValueDobenThap_TextChanged);
		this.checkBoxThodiaphuDobenThap.AutoSize = true;
		this.checkBoxThodiaphuDobenThap.ForeColor = System.Drawing.Color.Black;
		this.checkBoxThodiaphuDobenThap.Location = new System.Drawing.Point(5, 112);
		this.checkBoxThodiaphuDobenThap.Name = "checkBoxThodiaphuDobenThap";
		this.checkBoxThodiaphuDobenThap.Size = new System.Drawing.Size(209, 17);
		this.checkBoxThodiaphuDobenThap.TabIndex = 173;
		this.checkBoxThodiaphuDobenThap.Text = "Thổ địa phù khi độ bền xuống thấp <=";
		this.checkBoxThodiaphuDobenThap.UseVisualStyleBackColor = true;
		this.checkBoxThodiaphuDobenThap.CheckedChanged += new System.EventHandler(checkBoxThodiaphuDobenThap_CheckedChanged);
		this.checkBoxKhongSuaTK.AutoSize = true;
		this.checkBoxKhongSuaTK.ForeColor = System.Drawing.Color.DarkGreen;
		this.checkBoxKhongSuaTK.Location = new System.Drawing.Point(5, 27);
		this.checkBoxKhongSuaTK.Name = "checkBoxKhongSuaTK";
		this.checkBoxKhongSuaTK.Size = new System.Drawing.Size(190, 17);
		this.checkBoxKhongSuaTK.TabIndex = 334;
		this.checkBoxKhongSuaTK.Text = "Không sửa khi mua thuốc tống kim";
		this.checkBoxKhongSuaTK.UseVisualStyleBackColor = true;
		this.checkBoxKhongSuaTK.CheckedChanged += new System.EventHandler(checkBoxKhongSuaTK_CheckedChanged);
		this.checkBoxLuonSuaKhiMuathuoc.AutoSize = true;
		this.checkBoxLuonSuaKhiMuathuoc.ForeColor = System.Drawing.Color.DarkGreen;
		this.checkBoxLuonSuaKhiMuathuoc.Location = new System.Drawing.Point(5, 4);
		this.checkBoxLuonSuaKhiMuathuoc.Name = "checkBoxLuonSuaKhiMuathuoc";
		this.checkBoxLuonSuaKhiMuathuoc.Size = new System.Drawing.Size(229, 17);
		this.checkBoxLuonSuaKhiMuathuoc.TabIndex = 335;
		this.checkBoxLuonSuaKhiMuathuoc.Text = "Luôn sửa trang bị khi mua thuốc, tạp hóa...";
		this.checkBoxLuonSuaKhiMuathuoc.UseVisualStyleBackColor = true;
		this.checkBoxLuonSuaKhiMuathuoc.CheckedChanged += new System.EventHandler(checkBoxLuonSuaKhiMuathuoc_CheckedChanged);
		this.checkBoxBachKim.AutoSize = true;
		this.checkBoxBachKim.ForeColor = System.Drawing.Color.Black;
		this.checkBoxBachKim.Location = new System.Drawing.Point(5, 87);
		this.checkBoxBachKim.Name = "checkBoxBachKim";
		this.checkBoxBachKim.Size = new System.Drawing.Size(232, 17);
		this.checkBoxBachKim.TabIndex = 337;
		this.checkBoxBachKim.Text = "Sửa đồ bạch kim (+6 trở đi auto không sửa)";
		this.checkBoxBachKim.UseVisualStyleBackColor = true;
		this.checkBoxBachKim.CheckedChanged += new System.EventHandler(checkBoxBachKim_CheckedChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(31, 173);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(148, 13);
		this.label1.TabIndex = 339;
		this.label1.Text = "Sửa khi độ bền xuống còn ....";
		this.textBoxPhanTram.Location = new System.Drawing.Point(186, 170);
		this.textBoxPhanTram.Name = "textBoxPhanTram";
		this.textBoxPhanTram.Size = new System.Drawing.Size(30, 20);
		this.textBoxPhanTram.TabIndex = 340;
		this.textBoxPhanTram.TextChanged += new System.EventHandler(textBoxPhanTram_TextChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(222, 173);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(24, 13);
		this.label2.TabIndex = 341;
		this.label2.Text = "( %)";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(134, 196);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(46, 13);
		this.label3.TabIndex = 343;
		this.label3.Text = "hoặc <=";
		this.textBoxDiem.Location = new System.Drawing.Point(186, 193);
		this.textBoxDiem.Name = "textBoxDiem";
		this.textBoxDiem.Size = new System.Drawing.Size(30, 20);
		this.textBoxDiem.TabIndex = 342;
		this.textBoxDiem.TextChanged += new System.EventHandler(textBoxDiem_TextChanged);
		this.textBoxDiem.Leave += new System.EventHandler(textBoxDiem_Leave);
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(222, 196);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(39, 13);
		this.label4.TabIndex = 344;
		this.label4.Text = "( điểm)";
		this.buttonClose.Location = new System.Drawing.Point(171, 295);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(85, 26);
		this.buttonClose.TabIndex = 346;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.checkBoxPhiChiendau.AutoSize = true;
		this.checkBoxPhiChiendau.ForeColor = System.Drawing.Color.DarkGreen;
		this.checkBoxPhiChiendau.Location = new System.Drawing.Point(5, 49);
		this.checkBoxPhiChiendau.Name = "checkBoxPhiChiendau";
		this.checkBoxPhiChiendau.Size = new System.Drawing.Size(155, 17);
		this.checkBoxPhiChiendau.TabIndex = 347;
		this.checkBoxPhiChiendau.Text = "Sửa đồ ở nơi phi chiến đấu";
		this.checkBoxPhiChiendau.UseVisualStyleBackColor = true;
		this.checkBoxPhiChiendau.CheckedChanged += new System.EventHandler(checkBoxPhiChiendau_CheckedChanged);
		this.textBox1.Location = new System.Drawing.Point(186, 219);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(30, 20);
		this.textBox1.TabIndex = 349;
		this.textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(3, 222);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(176, 13);
		this.label5.TabIndex = 348;
		this.label5.Text = "Thời gian giữa 2 lần kiểm tra sửa đồ";
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(222, 223);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(35, 13);
		this.label6.TabIndex = 350;
		this.label6.Text = "( giây)";
		this.checkBoxPhimTat.AutoSize = true;
		this.checkBoxPhimTat.Location = new System.Drawing.Point(5, 261);
		this.checkBoxPhimTat.Name = "checkBoxPhimTat";
		this.checkBoxPhimTat.Size = new System.Drawing.Size(258, 17);
		this.checkBoxPhimTat.TabIndex = 351;
		this.checkBoxPhimTat.Text = "Sử dụng phím tắt CTRL + ALT để sửa đồ tại chỗ";
		this.checkBoxPhimTat.UseVisualStyleBackColor = true;
		this.checkBoxPhimTat.CheckedChanged += new System.EventHandler(checkBoxPhimTat_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(271, 333);
		base.Controls.Add(this.checkBoxPhimTat);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.checkBoxPhiChiendau);
		base.Controls.Add(this.textBoxDiem);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.textBoxPhanTram);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.checkBoxOutGameKhidobenThap);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.checkBoxThodiaphuDobenThap);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.checkBoxBachKim);
		base.Controls.Add(this.textBoxValueDobenThap);
		base.Controls.Add(this.checkBoxLuonSuaKhiMuathuoc);
		base.Controls.Add(this.checkBoxKhongSuaTK);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormSuado";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "Sua do";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormSuado_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		int_0 = 0;
	}

	private void FormSuado_Load(object sender, EventArgs e)
	{
		base.Top = Cursor.Position.Y - base.Height - 10;
		base.Left = Cursor.Position.X - base.Width - 10;
		textBoxValueDobenThap.Text = Form1.int_86.ToString();
		checkBoxThodiaphuDobenThap.Checked = Form1.int_87 > 0;
		checkBoxOutGameKhidobenThap.Checked = Form1.int_85 > 0;
		checkBoxKhongSuaTK.Checked = Form1.int_62 > 0;
		checkBoxOutGameKhidobenThap.Enabled = Form1.int_87 > 0;
		checkBoxLuonSuaKhiMuathuoc.Checked = Form1.int_63 > 0;
		checkBoxBachKim.Checked = Form1.int_64 > 0;
		textBoxPhanTram.Text = Form1.int_66[0].ToString();
		textBoxDiem.Text = Form1.int_66[1].ToString();
		checkBoxPhiChiendau.Checked = Form1.int_65 > 0;
		textBox1.Text = Form1.int_88.ToString();
		checkBoxPhimTat.Checked = Form1.int_68 > 0;
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		bool_0 = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			Close();
		}
	}

	private void checkBoxThodiaphuDobenThap_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			Form1.int_87 = Convert.ToByte(checkBoxThodiaphuDobenThap.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagThodiaphuDobenThap", Form1.int_87, "", 0);
			checkBoxOutGameKhidobenThap.Enabled = Form1.int_87 > 0;
		}
	}

	private void textBoxValueDobenThap_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			Form1.int_86 = Class11.smethod_11(textBoxValueDobenThap.Text);
			if (Form1.int_86 < 3)
			{
				Form1.int_86 = 3;
			}
			Class66.smethod_11(Class66.smethod_1(), "nDobenThap", Form1.int_86, "", 0);
		}
	}

	private void checkBoxOutGameKhidobenThap_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			Form1.int_85 = Convert.ToByte(checkBoxOutGameKhidobenThap.Checked);
			Class66.smethod_11(Class66.smethod_1(), "nDobenOut", Form1.int_85, "", 0);
		}
	}

	private void checkBoxKhongSuaTK_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			Form1.int_62 = Convert.ToByte(checkBoxKhongSuaTK.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagKhongSuaTK", Form1.int_62, "", 0);
		}
	}

	private void checkBoxLuonSuaKhiMuathuoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			Form1.int_63 = Convert.ToByte(checkBoxLuonSuaKhiMuathuoc.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagLuonSuaMua", Form1.int_63, "", 0);
		}
	}

	private void checkBoxBachKim_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			Form1.int_64 = Convert.ToByte(checkBoxBachKim.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagSudoBachKim", Form1.int_64, "", 0);
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		int_0 = 0;
		Close();
	}

	private void textBoxPhanTram_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			Form1.int_66[0] = Class11.smethod_11(textBoxPhanTram.Text);
			if (Form1.int_66[0] <= 10)
			{
				Form1.int_66[0] = 10;
			}
			Class66.smethod_11(Class66.smethod_1(), "fSuado1_0", Form1.int_66[0], "", 0);
		}
	}

	private void textBoxDiem_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			Form1.int_66[1] = Class11.smethod_11(textBoxDiem.Text);
			if (Form1.int_66[1] < 5)
			{
				Form1.int_66[1] = 5;
			}
			Class66.smethod_11(Class66.smethod_1(), "fSuado1_1", Form1.int_66[1], "", 0);
		}
	}

	private void textBoxDiem_Leave(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			Form1.int_66[1] = Class11.smethod_11(textBoxDiem.Text);
			if (Form1.int_66[1] < 5)
			{
				Form1.int_66[1] = 5;
				textBoxDiem.Text = "5";
			}
		}
	}

	private void checkBoxPhiChiendau_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			Form1.int_65 = Convert.ToByte(checkBoxPhiChiendau.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fSuaPhichiendau", Form1.int_65, "", 0);
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		Form1.int_88 = Class11.smethod_11(textBox1.Text);
		if (Form1.int_88 >= 10)
		{
			if (Form1.int_88 > 180)
			{
				Form1.int_88 = 180;
			}
		}
		else
		{
			Form1.int_88 = 10;
		}
		Class66.smethod_11(Class66.smethod_1(), "ThoigianSua", Form1.int_88, "", 0);
	}

	private void checkBoxPhimTat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_0)
		{
			Form1.int_68 = Convert.ToByte(checkBoxPhimTat.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagPhimTatSuado", Form1.int_68, "", 0);
		}
	}
}
