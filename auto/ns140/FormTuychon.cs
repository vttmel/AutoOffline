using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns138;
using ns145;
using ns18;
using ns29;
using ns53;
using ns63;
using ns71;
using ns79;
using ns83;
using ns85;
using ns90;

namespace ns140;

public class FormTuychon : Form
{
	private IContainer icontainer_0 = null;

	private TextBox textBoxGiaiBua;

	private CheckBox checkBoxDinhbangsat;

	private Timer timer_0;

	private CheckBox checkBoxTheoBua;

	private CheckBox checkBoxTheoThoigian;

	private TextBox textBoxThoigianGiaibua;

	private Button buttonApdungAll;

	private CheckBox checkBoxApdungAllThoigian;

	private GroupBox groupBox1;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private Label label2;

	private ComboBox comboBoxPhim;

	private CheckBox checkBoxBamphim;

	private TabPage tabPage3;

	private CheckBox checkBoxTutimMuctieu;

	private TabPage tabPage4;

	private RichTextBox richTextBox1;

	private Button buttonApdung;

	private CheckBox checkBoxBossTruocNguoiSau;

	private CheckBox checkBoxChetNamImAll;

	private TabPage tabPage6;

	private GroupBox groupBox2;

	private CheckBox checkBoxBosPhongTan;

	private CheckBox checkBoxBosKenhBang;

	private CheckBox checkBoxBosKenhKhac;

	private RichTextBox richTextBox2;

	private TextBox textBoxBosGiay;

	private Label label4;

	private TabPage tabPage5;

	private TabPage tabPage7;

	private CheckBox checkBoxMuaNoiChiendau;

	private ComboBox comboBox3;

	private ComboBox comboBox2;

	private ComboBox comboBox1;

	private Label label1;

	private CheckBox checkBoxChiTiet;

	private TabPage tabPage8;

	private Label label8;

	private Label label7;

	private Label label6;

	private CheckBox checkBoxQuangThuoc;

	private CheckBox checkBoxTDP;

	private Label label37;

	private Button buttonBaovatXoaSaiso;

	private TextBox textBoxSaisoBaovat;

	private Button buttonTimSaiso;

	private Label label3;

	private Label label5;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static int int_1 = 0;

	public static int int_2 = 0;

	private IContainer icontainer_1;

	private Struct24[] struct24_0 = null;

	public FormTuychon()
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
		this.icontainer_1 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns140.FormTuychon));
		this.textBoxGiaiBua = new System.Windows.Forms.TextBox();
		this.checkBoxDinhbangsat = new System.Windows.Forms.CheckBox();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_1);
		this.checkBoxTheoBua = new System.Windows.Forms.CheckBox();
		this.checkBoxTheoThoigian = new System.Windows.Forms.CheckBox();
		this.textBoxThoigianGiaibua = new System.Windows.Forms.TextBox();
		this.buttonApdungAll = new System.Windows.Forms.Button();
		this.checkBoxApdungAllThoigian = new System.Windows.Forms.CheckBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.richTextBox2 = new System.Windows.Forms.RichTextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.comboBoxPhim = new System.Windows.Forms.ComboBox();
		this.checkBoxBamphim = new System.Windows.Forms.CheckBox();
		this.tabPage3 = new System.Windows.Forms.TabPage();
		this.checkBoxChetNamImAll = new System.Windows.Forms.CheckBox();
		this.checkBoxBossTruocNguoiSau = new System.Windows.Forms.CheckBox();
		this.checkBoxTutimMuctieu = new System.Windows.Forms.CheckBox();
		this.tabPage4 = new System.Windows.Forms.TabPage();
		this.buttonApdung = new System.Windows.Forms.Button();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.tabPage5 = new System.Windows.Forms.TabPage();
		this.tabPage6 = new System.Windows.Forms.TabPage();
		this.checkBoxChiTiet = new System.Windows.Forms.CheckBox();
		this.textBoxBosGiay = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.checkBoxBosPhongTan = new System.Windows.Forms.CheckBox();
		this.checkBoxBosKenhBang = new System.Windows.Forms.CheckBox();
		this.checkBoxBosKenhKhac = new System.Windows.Forms.CheckBox();
		this.tabPage7 = new System.Windows.Forms.TabPage();
		this.label5 = new System.Windows.Forms.Label();
		this.buttonBaovatXoaSaiso = new System.Windows.Forms.Button();
		this.textBoxSaisoBaovat = new System.Windows.Forms.TextBox();
		this.buttonTimSaiso = new System.Windows.Forms.Button();
		this.label37 = new System.Windows.Forms.Label();
		this.comboBox3 = new System.Windows.Forms.ComboBox();
		this.comboBox2 = new System.Windows.Forms.ComboBox();
		this.comboBox1 = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.tabPage8 = new System.Windows.Forms.TabPage();
		this.checkBoxTDP = new System.Windows.Forms.CheckBox();
		this.label8 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.checkBoxQuangThuoc = new System.Windows.Forms.CheckBox();
		this.checkBoxMuaNoiChiendau = new System.Windows.Forms.CheckBox();
		this.label3 = new System.Windows.Forms.Label();
		this.groupBox1.SuspendLayout();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.tabPage2.SuspendLayout();
		this.tabPage3.SuspendLayout();
		this.tabPage4.SuspendLayout();
		this.tabPage6.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.tabPage7.SuspendLayout();
		this.tabPage8.SuspendLayout();
		base.SuspendLayout();
		this.textBoxGiaiBua.Location = new System.Drawing.Point(257, 7);
		this.textBoxGiaiBua.Name = "textBoxGiaiBua";
		this.textBoxGiaiBua.Size = new System.Drawing.Size(50, 20);
		this.textBoxGiaiBua.TabIndex = 169;
		this.textBoxGiaiBua.TextChanged += new System.EventHandler(textBoxGiaiBua_TextChanged);
		this.checkBoxDinhbangsat.AutoSize = true;
		this.checkBoxDinhbangsat.Location = new System.Drawing.Point(6, 58);
		this.checkBoxDinhbangsat.Name = "checkBoxDinhbangsat";
		this.checkBoxDinhbangsat.Size = new System.Drawing.Size(278, 17);
		this.checkBoxDinhbangsat.TabIndex = 2;
		this.checkBoxDinhbangsat.Text = "Tự xuất 120 khi bị đứng hình do dính băng sát, bẫy...";
		this.checkBoxDinhbangsat.UseVisualStyleBackColor = true;
		this.checkBoxDinhbangsat.CheckedChanged += new System.EventHandler(checkBoxDinhbangsat_CheckedChanged);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.checkBoxTheoBua.AutoSize = true;
		this.checkBoxTheoBua.Location = new System.Drawing.Point(6, 9);
		this.checkBoxTheoBua.Name = "checkBoxTheoBua";
		this.checkBoxTheoBua.Size = new System.Drawing.Size(251, 17);
		this.checkBoxTheoBua.TabIndex = 3;
		this.checkBoxTheoBua.Text = "Tự xuất skill 120 khi bị bùa, độc... sau (mili giây)";
		this.checkBoxTheoBua.UseVisualStyleBackColor = true;
		this.checkBoxTheoBua.CheckedChanged += new System.EventHandler(checkBoxTheoBua_CheckedChanged);
		this.checkBoxTheoThoigian.AutoSize = true;
		this.checkBoxTheoThoigian.Location = new System.Drawing.Point(6, 34);
		this.checkBoxTheoThoigian.Name = "checkBoxTheoThoigian";
		this.checkBoxTheoThoigian.Size = new System.Drawing.Size(228, 17);
		this.checkBoxTheoThoigian.TabIndex = 170;
		this.checkBoxTheoThoigian.Text = "Hoặc xuất skill 120 theo thời gian (mili giây)";
		this.checkBoxTheoThoigian.UseVisualStyleBackColor = true;
		this.checkBoxTheoThoigian.CheckedChanged += new System.EventHandler(checkBoxTheoThoigian_CheckedChanged);
		this.textBoxThoigianGiaibua.Location = new System.Drawing.Point(257, 31);
		this.textBoxThoigianGiaibua.Name = "textBoxThoigianGiaibua";
		this.textBoxThoigianGiaibua.Size = new System.Drawing.Size(50, 20);
		this.textBoxThoigianGiaibua.TabIndex = 171;
		this.textBoxThoigianGiaibua.TextChanged += new System.EventHandler(textBoxThoigianGiaibua_TextChanged);
		this.buttonApdungAll.Location = new System.Drawing.Point(184, 14);
		this.buttonApdungAll.Name = "buttonApdungAll";
		this.buttonApdungAll.Size = new System.Drawing.Size(111, 40);
		this.buttonApdungAll.TabIndex = 172;
		this.buttonApdungAll.Text = "Áp dụng cho tất cả ac Võ đang";
		this.buttonApdungAll.UseVisualStyleBackColor = true;
		this.buttonApdungAll.Click += new System.EventHandler(buttonApdungAll_Click);
		this.checkBoxApdungAllThoigian.Checked = true;
		this.checkBoxApdungAllThoigian.CheckState = System.Windows.Forms.CheckState.Checked;
		this.checkBoxApdungAllThoigian.Location = new System.Drawing.Point(6, 19);
		this.checkBoxApdungAllThoigian.Name = "checkBoxApdungAllThoigian";
		this.checkBoxApdungAllThoigian.Size = new System.Drawing.Size(174, 33);
		this.checkBoxApdungAllThoigian.TabIndex = 173;
		this.checkBoxApdungAllThoigian.Text = "Không áp dụng cho tất cả ac phần thời gian (mili giây)";
		this.checkBoxApdungAllThoigian.UseVisualStyleBackColor = true;
		this.groupBox1.Controls.Add(this.buttonApdungAll);
		this.groupBox1.Controls.Add(this.checkBoxApdungAllThoigian);
		this.groupBox1.Location = new System.Drawing.Point(3, 84);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(306, 63);
		this.groupBox1.TabIndex = 174;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Áp dụng tất cả Võ đang";
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Controls.Add(this.tabPage3);
		this.tabControl1.Controls.Add(this.tabPage4);
		this.tabControl1.Controls.Add(this.tabPage5);
		this.tabControl1.Controls.Add(this.tabPage6);
		this.tabControl1.Controls.Add(this.tabPage7);
		this.tabControl1.Controls.Add(this.tabPage8);
		this.tabControl1.Location = new System.Drawing.Point(1, 1);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(321, 177);
		this.tabControl1.TabIndex = 175;
		this.tabPage1.Controls.Add(this.checkBoxTheoThoigian);
		this.tabPage1.Controls.Add(this.groupBox1);
		this.tabPage1.Controls.Add(this.checkBoxDinhbangsat);
		this.tabPage1.Controls.Add(this.textBoxThoigianGiaibua);
		this.tabPage1.Controls.Add(this.checkBoxTheoBua);
		this.tabPage1.Controls.Add(this.textBoxGiaiBua);
		this.tabPage1.Location = new System.Drawing.Point(4, 22);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(313, 151);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "VĐ";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.tabPage2.Controls.Add(this.richTextBox2);
		this.tabPage2.Controls.Add(this.label2);
		this.tabPage2.Controls.Add(this.comboBoxPhim);
		this.tabPage2.Controls.Add(this.checkBoxBamphim);
		this.tabPage2.Location = new System.Drawing.Point(4, 22);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(313, 151);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "TN";
		this.tabPage2.UseVisualStyleBackColor = true;
		this.richTextBox2.Location = new System.Drawing.Point(3, 3);
		this.richTextBox2.Name = "richTextBox2";
		this.richTextBox2.Size = new System.Drawing.Size(307, 96);
		this.richTextBox2.TabIndex = 23;
		this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(224, 109);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(83, 13);
		this.label2.TabIndex = 22;
		this.label2.Text = "phím xuất chiêu";
		this.comboBoxPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxPhim.FormattingEnabled = true;
		this.comboBoxPhim.Location = new System.Drawing.Point(241, 125);
		this.comboBoxPhim.Name = "comboBoxPhim";
		this.comboBoxPhim.Size = new System.Drawing.Size(52, 21);
		this.comboBoxPhim.TabIndex = 20;
		this.comboBoxPhim.SelectedIndexChanged += new System.EventHandler(comboBoxPhim_SelectedIndexChanged);
		this.checkBoxBamphim.Location = new System.Drawing.Point(3, 107);
		this.checkBoxBamphim.Name = "checkBoxBamphim";
		this.checkBoxBamphim.Size = new System.Drawing.Size(193, 41);
		this.checkBoxBamphim.TabIndex = 19;
		this.checkBoxBamphim.Text = "Bấm phím để TN xuất chiêu theo vị trí chuột của ac chính";
		this.checkBoxBamphim.UseVisualStyleBackColor = true;
		this.checkBoxBamphim.CheckedChanged += new System.EventHandler(checkBoxBamphim_CheckedChanged);
		this.tabPage3.Controls.Add(this.checkBoxChetNamImAll);
		this.tabPage3.Controls.Add(this.checkBoxBossTruocNguoiSau);
		this.tabPage3.Controls.Add(this.checkBoxTutimMuctieu);
		this.tabPage3.Location = new System.Drawing.Point(4, 22);
		this.tabPage3.Name = "tabPage3";
		this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage3.Size = new System.Drawing.Size(313, 151);
		this.tabPage3.TabIndex = 2;
		this.tabPage3.Text = "Kiểu";
		this.tabPage3.UseVisualStyleBackColor = true;
		this.checkBoxChetNamImAll.AutoSize = true;
		this.checkBoxChetNamImAll.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxChetNamImAll.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxChetNamImAll.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxChetNamImAll.Location = new System.Drawing.Point(6, 97);
		this.checkBoxChetNamImAll.Name = "checkBoxChetNamImAll";
		this.checkBoxChetNamImAll.Size = new System.Drawing.Size(175, 17);
		this.checkBoxChetNamImAll.TabIndex = 349;
		this.checkBoxChetNamImAll.Text = "Áp dụng toàn cục cho tất cả ac";
		this.checkBoxChetNamImAll.UseVisualStyleBackColor = false;
		this.checkBoxChetNamImAll.CheckedChanged += new System.EventHandler(checkBoxChetNamImAll_CheckedChanged);
		this.checkBoxBossTruocNguoiSau.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxBossTruocNguoiSau.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxBossTruocNguoiSau.Location = new System.Drawing.Point(6, 3);
		this.checkBoxBossTruocNguoiSau.Name = "checkBoxBossTruocNguoiSau";
		this.checkBoxBossTruocNguoiSau.Size = new System.Drawing.Size(217, 37);
		this.checkBoxBossTruocNguoiSau.TabIndex = 348;
		this.checkBoxBossTruocNguoiSau.Text = "Ưu tiên đánh boss trước, đánh người sau";
		this.checkBoxBossTruocNguoiSau.UseVisualStyleBackColor = false;
		this.checkBoxBossTruocNguoiSau.CheckedChanged += new System.EventHandler(checkBoxBossTruocNguoiSau_CheckedChanged);
		this.checkBoxTutimMuctieu.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTutimMuctieu.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxTutimMuctieu.Location = new System.Drawing.Point(7, 49);
		this.checkBoxTutimMuctieu.Name = "checkBoxTutimMuctieu";
		this.checkBoxTutimMuctieu.Size = new System.Drawing.Size(216, 33);
		this.checkBoxTutimMuctieu.TabIndex = 336;
		this.checkBoxTutimMuctieu.Text = "Nếu ac chính không có mục tiêu thì ac phụ tự tìm mục tiêu để đánh";
		this.checkBoxTutimMuctieu.UseVisualStyleBackColor = false;
		this.checkBoxTutimMuctieu.CheckedChanged += new System.EventHandler(checkBoxTutimMuctieu_CheckedChanged);
		this.tabPage4.Controls.Add(this.buttonApdung);
		this.tabPage4.Controls.Add(this.richTextBox1);
		this.tabPage4.Location = new System.Drawing.Point(4, 22);
		this.tabPage4.Name = "tabPage4";
		this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage4.Size = new System.Drawing.Size(313, 151);
		this.tabPage4.TabIndex = 3;
		this.tabPage4.Text = "KhCách";
		this.tabPage4.UseVisualStyleBackColor = true;
		this.buttonApdung.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonApdung.Location = new System.Drawing.Point(30, 127);
		this.buttonApdung.Name = "buttonApdung";
		this.buttonApdung.Size = new System.Drawing.Size(257, 23);
		this.buttonApdung.TabIndex = 6;
		this.buttonApdung.Text = "Áp dụng kiểu đánh khoảng cách tất cả ac";
		this.buttonApdung.UseVisualStyleBackColor = true;
		this.buttonApdung.Click += new System.EventHandler(buttonApdung_Click);
		this.richTextBox1.Location = new System.Drawing.Point(1, 3);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.Size = new System.Drawing.Size(310, 123);
		this.richTextBox1.TabIndex = 5;
		this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
		this.richTextBox1.TextChanged += new System.EventHandler(richTextBox1_TextChanged);
		this.tabPage5.Location = new System.Drawing.Point(4, 22);
		this.tabPage5.Name = "tabPage5";
		this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage5.Size = new System.Drawing.Size(313, 151);
		this.tabPage5.TabIndex = 4;
		this.tabPage5.Text = "Sửa đồ";
		this.tabPage5.UseVisualStyleBackColor = true;
		this.tabPage6.Controls.Add(this.checkBoxChiTiet);
		this.tabPage6.Controls.Add(this.textBoxBosGiay);
		this.tabPage6.Controls.Add(this.label4);
		this.tabPage6.Controls.Add(this.groupBox2);
		this.tabPage6.Location = new System.Drawing.Point(4, 22);
		this.tabPage6.Name = "tabPage6";
		this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage6.Size = new System.Drawing.Size(313, 151);
		this.tabPage6.TabIndex = 5;
		this.tabPage6.Text = "Báo";
		this.tabPage6.UseVisualStyleBackColor = true;
		this.checkBoxChiTiet.AutoSize = true;
		this.checkBoxChiTiet.Location = new System.Drawing.Point(7, 127);
		this.checkBoxChiTiet.Name = "checkBoxChiTiet";
		this.checkBoxChiTiet.Size = new System.Drawing.Size(138, 17);
		this.checkBoxChiTiet.TabIndex = 217;
		this.checkBoxChiTiet.Text = "Báo chi tiết hướng chạy";
		this.checkBoxChiTiet.UseVisualStyleBackColor = true;
		this.checkBoxChiTiet.CheckedChanged += new System.EventHandler(checkBoxChiTiet_CheckedChanged);
		this.textBoxBosGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxBosGiay.ForeColor = System.Drawing.Color.Black;
		this.textBoxBosGiay.Location = new System.Drawing.Point(118, 104);
		this.textBoxBosGiay.Name = "textBoxBosGiay";
		this.textBoxBosGiay.Size = new System.Drawing.Size(39, 20);
		this.textBoxBosGiay.TabIndex = 221;
		this.textBoxBosGiay.TextChanged += new System.EventHandler(textBoxBosGiay_TextChanged);
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(4, 107);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(100, 13);
		this.label4.TabIndex = 222;
		this.label4.Text = "Thời gian báo (giây)";
		this.groupBox2.Controls.Add(this.checkBoxBosPhongTan);
		this.groupBox2.Controls.Add(this.checkBoxBosKenhBang);
		this.groupBox2.Controls.Add(this.checkBoxBosKenhKhac);
		this.groupBox2.Location = new System.Drawing.Point(3, 3);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(154, 96);
		this.groupBox2.TabIndex = 220;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Thiết lập chung";
		this.checkBoxBosPhongTan.AutoSize = true;
		this.checkBoxBosPhongTan.Location = new System.Drawing.Point(18, 47);
		this.checkBoxBosPhongTan.Name = "checkBoxBosPhongTan";
		this.checkBoxBosPhongTan.Size = new System.Drawing.Size(97, 17);
		this.checkBoxBosPhongTan.TabIndex = 216;
		this.checkBoxBosPhongTan.Text = "Báo Phòng tán";
		this.checkBoxBosPhongTan.UseVisualStyleBackColor = true;
		this.checkBoxBosPhongTan.CheckedChanged += new System.EventHandler(checkBoxBosPhongTan_CheckedChanged);
		this.checkBoxBosKenhBang.AutoSize = true;
		this.checkBoxBosKenhBang.Location = new System.Drawing.Point(18, 70);
		this.checkBoxBosKenhBang.Name = "checkBoxBosKenhBang";
		this.checkBoxBosKenhBang.Size = new System.Drawing.Size(99, 17);
		this.checkBoxBosKenhBang.TabIndex = 215;
		this.checkBoxBosKenhBang.Text = "Báo kênh bang";
		this.checkBoxBosKenhBang.UseVisualStyleBackColor = true;
		this.checkBoxBosKenhBang.CheckedChanged += new System.EventHandler(checkBoxBosKenhBang_CheckedChanged);
		this.checkBoxBosKenhKhac.AutoSize = true;
		this.checkBoxBosKenhKhac.ForeColor = System.Drawing.Color.DarkBlue;
		this.checkBoxBosKenhKhac.Location = new System.Drawing.Point(18, 22);
		this.checkBoxBosKenhKhac.Name = "checkBoxBosKenhKhac";
		this.checkBoxBosKenhKhac.Size = new System.Drawing.Size(99, 17);
		this.checkBoxBosKenhKhac.TabIndex = 214;
		this.checkBoxBosKenhKhac.Text = "Báo kênh khác";
		this.checkBoxBosKenhKhac.UseVisualStyleBackColor = true;
		this.checkBoxBosKenhKhac.CheckedChanged += new System.EventHandler(checkBoxBosKenhKhac_CheckedChanged);
		this.tabPage7.Controls.Add(this.label5);
		this.tabPage7.Controls.Add(this.buttonBaovatXoaSaiso);
		this.tabPage7.Controls.Add(this.textBoxSaisoBaovat);
		this.tabPage7.Controls.Add(this.buttonTimSaiso);
		this.tabPage7.Controls.Add(this.label37);
		this.tabPage7.Controls.Add(this.comboBox3);
		this.tabPage7.Controls.Add(this.comboBox2);
		this.tabPage7.Controls.Add(this.comboBox1);
		this.tabPage7.Controls.Add(this.label1);
		this.tabPage7.Location = new System.Drawing.Point(4, 22);
		this.tabPage7.Name = "tabPage7";
		this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage7.Size = new System.Drawing.Size(313, 151);
		this.tabPage7.TabIndex = 6;
		this.tabPage7.Text = "KTC";
		this.tabPage7.UseVisualStyleBackColor = true;
		this.label5.Location = new System.Drawing.Point(3, 95);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(242, 47);
		this.label5.TabIndex = 360;
		this.label5.Text = "1. Bấm nút Bảo vật để mở bảng kỳ trân các lên\r\n2. Bấm nút Mua, để đó đừng bấm xác nhận\r\n3. Ở auto, bấm nút Lấy giá trị sai số ở bên dưới.";
		this.buttonBaovatXoaSaiso.Location = new System.Drawing.Point(247, 56);
		this.buttonBaovatXoaSaiso.Name = "buttonBaovatXoaSaiso";
		this.buttonBaovatXoaSaiso.Size = new System.Drawing.Size(65, 21);
		this.buttonBaovatXoaSaiso.TabIndex = 352;
		this.buttonBaovatXoaSaiso.Text = "Mặc định";
		this.buttonBaovatXoaSaiso.UseVisualStyleBackColor = true;
		this.buttonBaovatXoaSaiso.Click += new System.EventHandler(buttonBaovatXoaSaiso_Click);
		this.textBoxSaisoBaovat.Location = new System.Drawing.Point(247, 81);
		this.textBoxSaisoBaovat.Name = "textBoxSaisoBaovat";
		this.textBoxSaisoBaovat.ReadOnly = true;
		this.textBoxSaisoBaovat.Size = new System.Drawing.Size(64, 20);
		this.textBoxSaisoBaovat.TabIndex = 350;
		this.textBoxSaisoBaovat.Text = "0";
		this.textBoxSaisoBaovat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.buttonTimSaiso.Location = new System.Drawing.Point(247, 106);
		this.buttonTimSaiso.Name = "buttonTimSaiso";
		this.buttonTimSaiso.Size = new System.Drawing.Size(65, 42);
		this.buttonTimSaiso.TabIndex = 351;
		this.buttonTimSaiso.Text = "Lấy giá trị sai số";
		this.buttonTimSaiso.UseVisualStyleBackColor = true;
		this.buttonTimSaiso.Click += new System.EventHandler(buttonTimSaiso_Click);
		this.label37.ForeColor = System.Drawing.Color.DarkGreen;
		this.label37.Location = new System.Drawing.Point(3, 56);
		this.label37.Name = "label37";
		this.label37.Size = new System.Drawing.Size(242, 31);
		this.label37.TabIndex = 176;
		this.label37.Text = "Nếu mua SAI ở Bảo vật (không mua được), thì làm 3 bước dưới để lấy giá trị sai số fix lỗi.";
		this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox3.ForeColor = System.Drawing.Color.DarkRed;
		this.comboBox3.FormattingEnabled = true;
		this.comboBox3.Location = new System.Drawing.Point(210, 25);
		this.comboBox3.Name = "comboBox3";
		this.comboBox3.Size = new System.Drawing.Size(100, 21);
		this.comboBox3.TabIndex = 359;
		this.comboBox3.SelectedIndexChanged += new System.EventHandler(comboBox3_SelectedIndexChanged);
		this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox2.ForeColor = System.Drawing.Color.DarkRed;
		this.comboBox2.FormattingEnabled = true;
		this.comboBox2.Location = new System.Drawing.Point(109, 25);
		this.comboBox2.Name = "comboBox2";
		this.comboBox2.Size = new System.Drawing.Size(100, 21);
		this.comboBox2.TabIndex = 357;
		this.comboBox2.SelectedIndexChanged += new System.EventHandler(comboBox2_SelectedIndexChanged);
		this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox1.ForeColor = System.Drawing.Color.DarkRed;
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Location = new System.Drawing.Point(7, 25);
		this.comboBox1.Name = "comboBox1";
		this.comboBox1.Size = new System.Drawing.Size(100, 21);
		this.comboBox1.TabIndex = 355;
		this.comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(4, 5);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(301, 13);
		this.label1.TabIndex = 352;
		this.label1.Text = "[ Mua 1] [ Mua 2] [ Mua 3 ] trong Bảo vật nằm ở tab tương ứng";
		this.tabPage8.Controls.Add(this.checkBoxTDP);
		this.tabPage8.Controls.Add(this.label8);
		this.tabPage8.Controls.Add(this.label7);
		this.tabPage8.Controls.Add(this.label6);
		this.tabPage8.Controls.Add(this.checkBoxQuangThuoc);
		this.tabPage8.Location = new System.Drawing.Point(4, 22);
		this.tabPage8.Name = "tabPage8";
		this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage8.Size = new System.Drawing.Size(313, 151);
		this.tabPage8.TabIndex = 7;
		this.tabPage8.Text = "Quăng thuốc";
		this.tabPage8.UseVisualStyleBackColor = true;
		this.checkBoxTDP.AutoSize = true;
		this.checkBoxTDP.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxTDP.Location = new System.Drawing.Point(4, 127);
		this.checkBoxTDP.Name = "checkBoxTDP";
		this.checkBoxTDP.Size = new System.Drawing.Size(210, 17);
		this.checkBoxTDP.TabIndex = 216;
		this.checkBoxTDP.Text = "Thổ địa phù sau khi quăng thuốc xong";
		this.checkBoxTDP.UseVisualStyleBackColor = true;
		this.checkBoxTDP.CheckedChanged += new System.EventHandler(checkBoxTDP_CheckedChanged);
		this.label8.Location = new System.Drawing.Point(99, 4);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(212, 100);
		this.label8.TabIndex = 215;
		this.label8.Text = resources.GetString("label8.Text");
		this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label7.Location = new System.Drawing.Point(11, 27);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(79, 21);
		this.label7.TabIndex = 214;
		this.label7.Text = "  CTRL + F1  ";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.ForeColor = System.Drawing.Color.DarkRed;
		this.label6.Location = new System.Drawing.Point(5, 4);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(80, 13);
		this.label6.TabIndex = 213;
		this.label6.Text = "Phím tắt quăng";
		this.checkBoxQuangThuoc.AutoSize = true;
		this.checkBoxQuangThuoc.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxQuangThuoc.Location = new System.Drawing.Point(4, 104);
		this.checkBoxQuangThuoc.Name = "checkBoxQuangThuoc";
		this.checkBoxQuangThuoc.Size = new System.Drawing.Size(209, 17);
		this.checkBoxQuangThuoc.TabIndex = 212;
		this.checkBoxQuangThuoc.Text = "Gặp ac chính thì tự động quăng thuốc";
		this.checkBoxQuangThuoc.UseVisualStyleBackColor = true;
		this.checkBoxQuangThuoc.CheckedChanged += new System.EventHandler(checkBoxQuangThuoc_CheckedChanged);
		this.checkBoxMuaNoiChiendau.AutoSize = true;
		this.checkBoxMuaNoiChiendau.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxMuaNoiChiendau.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxMuaNoiChiendau.Location = new System.Drawing.Point(4, 183);
		this.checkBoxMuaNoiChiendau.Name = "checkBoxMuaNoiChiendau";
		this.checkBoxMuaNoiChiendau.Size = new System.Drawing.Size(276, 17);
		this.checkBoxMuaNoiChiendau.TabIndex = 349;
		this.checkBoxMuaNoiChiendau.Text = "Tự động mua ở nơi chiến đấu, lưu ý các vấn đề sau:";
		this.checkBoxMuaNoiChiendau.UseVisualStyleBackColor = false;
		this.checkBoxMuaNoiChiendau.CheckedChanged += new System.EventHandler(checkBoxMuaNoiChiendau_CheckedChanged);
		this.label3.Location = new System.Drawing.Point(3, 209);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(320, 33);
		this.label3.TabIndex = 350;
		this.label3.Text = "- Khi nút <Tự mở túi thuốc> đã mở hết túi thuốc\r\n- Các game không mua được ở nơi chiến đấu thì đừng check vào";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(324, 250);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.tabControl1);
		base.Controls.Add(this.checkBoxMuaNoiChiendau);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormTuychon";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "TUY CHON";
		base.Load += new System.EventHandler(FormTuychon_Load);
		this.groupBox1.ResumeLayout(false);
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage1.PerformLayout();
		this.tabPage2.ResumeLayout(false);
		this.tabPage2.PerformLayout();
		this.tabPage3.ResumeLayout(false);
		this.tabPage3.PerformLayout();
		this.tabPage4.ResumeLayout(false);
		this.tabPage6.ResumeLayout(false);
		this.tabPage6.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.tabPage7.ResumeLayout(false);
		this.tabPage7.PerformLayout();
		this.tabPage8.ResumeLayout(false);
		this.tabPage8.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		if (int_1 <= 0)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (0 <= num)
			{
				Form1.characterAccountConfig_1[num].int_82 = Convert.ToByte(checkBoxTheoThoigian.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
		if (int_2 > 0)
		{
			int_2 = 2;
		}
		int_0 = 0;
		bool_0 = false;
	}

	private void FormTuychon_Load(object sender, EventArgs e)
	{
		int num = int_1 / 100;
		int num2 = int_1 % 100;
		if (num > 0)
		{
			int_1 = num;
		}
		int_2 = 0;
		tabControl1.SelectedIndex = int_1;
		if (int_1 <= 0)
		{
			int num3 = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (0 <= num3)
			{
				CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num3];
				textBoxGiaiBua.Text = characterAccountConfig_.int_85.ToString();
				checkBoxDinhbangsat.Checked = characterAccountConfig_.int_81 > 0;
				checkBoxTheoBua.Checked = characterAccountConfig_.int_82 <= 0;
				checkBoxTheoThoigian.Checked = characterAccountConfig_.int_82 > 0;
				textBoxThoigianGiaibua.Text = characterAccountConfig_.int_87.ToString();
				checkBoxApdungAllThoigian.Checked = true;
				struct24_0 = Class89.smethod_1(characterAccountConfig_);
			}
			tabControl1.Controls.Remove(tabPage2);
			tabControl1.Controls.Remove(tabPage3);
			tabControl1.Controls.Remove(tabPage4);
			tabControl1.Controls.Remove(tabPage5);
			tabControl1.Controls.Remove(tabPage6);
			tabControl1.Controls.Remove(tabPage7);
			tabControl1.Controls.Remove(tabPage8);
			tabPage1.Text = "Skill 120 Võ Đang";
		}
		else if (int_1 != 1)
		{
			if (int_1 == 2)
			{
				tabControl1.Controls.Remove(tabPage1);
				tabControl1.Controls.Remove(tabPage2);
				tabControl1.Controls.Remove(tabPage4);
				tabControl1.Controls.Remove(tabPage5);
				tabControl1.Controls.Remove(tabPage6);
				tabControl1.Controls.Remove(tabPage7);
				tabControl1.Controls.Remove(tabPage8);
				checkBoxTutimMuctieu.Checked = Form1.int_38 > 0;
				checkBoxBossTruocNguoiSau.Checked = Form1.int_40 > 0;
				checkBoxChetNamImAll.Checked = Form1.int_42 > 0;
				switch (num2)
				{
				case 1:
					tabPage3.Text = "Ưu tiên đánh boss";
					checkBoxBossTruocNguoiSau.Location = new Point(6, 6);
					checkBoxTutimMuctieu.Visible = false;
					checkBoxChetNamImAll.Visible = false;
					break;
				case 2:
					tabPage3.Text = "Mục tiêu";
					checkBoxTutimMuctieu.Location = new Point(6, 6);
					checkBoxBossTruocNguoiSau.Visible = false;
					checkBoxChetNamImAll.Visible = false;
					break;
				case 3:
					tabPage3.Text = "Chết nằm im";
					checkBoxChetNamImAll.Location = new Point(6, 6);
					checkBoxTutimMuctieu.Visible = false;
					checkBoxBossTruocNguoiSau.Visible = false;
					int_2 = 1;
					break;
				}
				tabControl1.Size = new Size(230, 75);
				base.ClientSize = new Size(235, 80);
			}
			else if (int_1 == 3)
			{
				tabControl1.Controls.Remove(tabPage1);
				tabControl1.Controls.Remove(tabPage2);
				tabControl1.Controls.Remove(tabPage3);
				tabControl1.Controls.Remove(tabPage5);
				tabControl1.Controls.Remove(tabPage6);
				tabControl1.Controls.Remove(tabPage7);
				tabControl1.Controls.Remove(tabPage8);
				tabPage4.Text = "Đánh khoảng cách";
			}
			else if (int_1 == 4)
			{
				tabControl1.Controls.Remove(tabPage1);
				tabControl1.Controls.Remove(tabPage2);
				tabControl1.Controls.Remove(tabPage3);
				tabControl1.Controls.Remove(tabPage4);
				tabControl1.Controls.Remove(tabPage6);
				tabControl1.Controls.Remove(tabPage7);
				tabControl1.Controls.Remove(tabPage8);
				tabPage5.Text = "Sửa đồ";
			}
			else if (int_1 != 5)
			{
				if (int_1 != 6)
				{
					if (int_1 == 7)
					{
						tabControl1.Controls.Remove(tabPage1);
						tabControl1.Controls.Remove(tabPage2);
						tabControl1.Controls.Remove(tabPage3);
						tabControl1.Controls.Remove(tabPage4);
						tabControl1.Controls.Remove(tabPage5);
						tabControl1.Controls.Remove(tabPage6);
						tabControl1.Controls.Remove(tabPage7);
						tabPage8.Text = "Quăng tiếp thuốc";
						checkBoxQuangThuoc.Checked = Form1.int_31 > 0;
						checkBoxTDP.Checked = Form1.int_32 > 0;
					}
				}
				else
				{
					tabControl1.Controls.Remove(tabPage1);
					tabControl1.Controls.Remove(tabPage2);
					tabControl1.Controls.Remove(tabPage3);
					tabControl1.Controls.Remove(tabPage4);
					tabControl1.Controls.Remove(tabPage5);
					tabControl1.Controls.Remove(tabPage6);
					tabControl1.Controls.Remove(tabPage8);
					tabPage7.Text = "Kiểu mua thuốc ở Bảo vật (toàn cục)";
					base.ClientSize = new Size(330, 275);
					checkBoxMuaNoiChiendau.Checked = Form1.int_33 > 0;
					textBoxSaisoBaovat.Text = Form1.int_9.ToString();
					if (struct24_0 == null && Form1.characterAccountConfig_1 != null)
					{
						for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
						{
							struct24_0 = Class89.smethod_1(Form1.characterAccountConfig_1[i]);
							if (struct24_0 != null)
							{
								break;
							}
						}
					}
					if (Class19.string_0 == null)
					{
						Class19.string_0 = new string[3];
					}
					if (struct24_0 == null)
					{
						if (Class19.string_0[0] != null && Class19.string_0[0] != string.Empty)
						{
							string item = Class1.smethod_1(Class19.string_0[0], 1);
							comboBox1.Items.Add(item);
							comboBox1.Text = item;
						}
						if (Class19.string_0[1] != null && Class19.string_0[1] != string.Empty)
						{
							string item2 = Class1.smethod_1(Class19.string_0[1], 1);
							comboBox2.Items.Add(item2);
							comboBox2.Text = item2;
						}
						if (Class19.string_0[2] != null && Class19.string_0[2] != string.Empty)
						{
							string item3 = Class1.smethod_1(Class19.string_0[2], 1);
							comboBox3.Items.Add(item3);
							comboBox3.Text = item3;
						}
					}
					else
					{
						bool flag = false;
						bool flag2 = false;
						bool flag3 = false;
						for (int j = 0; j < struct24_0.Length; j++)
						{
							string item4 = Class1.smethod_1(struct24_0[j].string_0, 1);
							comboBox1.Items.Add(item4);
							comboBox2.Items.Add(item4);
							comboBox3.Items.Add(item4);
							if (struct24_0[j].string_0 == Class19.string_0[0])
							{
								comboBox1.Text = item4;
								flag = true;
							}
							if (struct24_0[j].string_0 == Class19.string_0[1])
							{
								comboBox2.Text = item4;
								flag2 = true;
							}
							if (struct24_0[j].string_0 == Class19.string_0[2])
							{
								comboBox3.Text = item4;
								flag3 = true;
							}
						}
						if (!flag)
						{
							comboBox1.Text = comboBox1.Items[0].ToString();
							Class19.string_0[0] = struct24_0[0].string_0;
							Class66.smethod_11(Class66.smethod_1(), "KTCTabName0", Class11.smethod_16(struct24_0[0].string_0), "", 0);
						}
						if (!flag2)
						{
							comboBox2.Text = comboBox2.Items[0].ToString();
							Class19.string_0[1] = struct24_0[0].string_0;
							Class66.smethod_11(Class66.smethod_1(), "KTCTabName1", Class11.smethod_16(struct24_0[0].string_0), "", 0);
						}
						if (!flag3)
						{
							comboBox3.Text = comboBox3.Items[0].ToString();
							Class19.string_0[2] = struct24_0[0].string_0;
							Class66.smethod_11(Class66.smethod_1(), "KTCTabName2", Class11.smethod_16(struct24_0[0].string_0), "", 0);
						}
					}
				}
			}
			else
			{
				tabControl1.Controls.Remove(tabPage1);
				tabControl1.Controls.Remove(tabPage2);
				tabControl1.Controls.Remove(tabPage3);
				tabControl1.Controls.Remove(tabPage4);
				tabControl1.Controls.Remove(tabPage5);
				tabControl1.Controls.Remove(tabPage7);
				tabControl1.Controls.Remove(tabPage8);
				tabPage6.Text = "Báo Boss";
				tabControl1.Size = new Size(170, 175);
				base.ClientSize = new Size(175, 178);
				checkBoxBosKenhKhac.Checked = Class97.int_0[0] > 0;
				checkBoxBosKenhBang.Checked = Class97.int_0[2] > 0;
				checkBoxBosPhongTan.Checked = Class97.int_0[1] > 0;
				textBoxBosGiay.Text = Class97.int_0[3].ToString();
				checkBoxChiTiet.Checked = Class97.int_1 > 0;
			}
		}
		else
		{
			for (int k = 0; k < Class30.gstruct42_0.Length; k++)
			{
				comboBoxPhim.Items.Add(Class30.gstruct42_0[k].string_0);
			}
			comboBoxPhim.Text = Class30.gstruct42_0[Form1.int_107].string_0;
			checkBoxBamphim.Checked = Form1.int_106 > 0;
			tabControl1.Controls.Remove(tabPage1);
			tabControl1.Controls.Remove(tabPage3);
			tabControl1.Controls.Remove(tabPage4);
			tabControl1.Controls.Remove(tabPage5);
			tabControl1.Controls.Remove(tabPage6);
			tabControl1.Controls.Remove(tabPage7);
			tabControl1.Controls.Remove(tabPage8);
			tabPage2.Text = "Skill 120 Thiên Nhẫn";
		}
		base.Top = Cursor.Position.Y - base.Height - 10;
		base.Left = Cursor.Position.X - base.Width - 10;
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

	private void checkBoxDinhbangsat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			buttonApdungAll.Enabled = true;
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_81 = Convert.ToByte(checkBoxDinhbangsat.Checked);
			}
		}
	}

	private void textBoxGiaiBua_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			buttonApdungAll.Enabled = true;
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_85 = Class11.smethod_11(textBoxGiaiBua.Text);
			}
		}
	}

	private void checkBoxTheoBua_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			checkBoxTheoThoigian.Checked = !checkBoxTheoBua.Checked;
			buttonApdungAll.Enabled = true;
		}
	}

	private void checkBoxTheoThoigian_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			checkBoxTheoBua.Checked = !checkBoxTheoThoigian.Checked;
			buttonApdungAll.Enabled = true;
		}
	}

	private void textBoxThoigianGiaibua_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			buttonApdungAll.Enabled = true;
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_87 = Class11.smethod_11(textBoxThoigianGiaibua.Text);
			}
		}
	}

	private void buttonApdungAll_Click(object sender, EventArgs e)
	{
		if (Form1.characterAccountConfig_1 == null)
		{
			return;
		}
		int int_ = Class11.smethod_11(textBoxGiaiBua.Text);
		int int_2 = Convert.ToByte(checkBoxTheoThoigian.Checked);
		int int_3 = Class11.smethod_11(textBoxThoigianGiaibua.Text);
		int int_4 = Convert.ToByte(checkBoxDinhbangsat.Checked);
		bool flag = checkBoxApdungAllThoigian.Checked;
		for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
		{
			string text = Class83.smethod_18(Form1.characterAccountConfig_1[i]);
			if (text != "VODANG")
			{
				continue;
			}
			int num = Class83.smethod_16(Form1.characterAccountConfig_1[i], 716);
			if (num > 0)
			{
				Form1.characterAccountConfig_1[i].int_82 = int_2;
				Form1.characterAccountConfig_1[i].int_81 = int_4;
				if (flag)
				{
					Form1.characterAccountConfig_1[i].int_85 = int_;
					Form1.characterAccountConfig_1[i].int_87 = int_3;
				}
			}
		}
		buttonApdungAll.Enabled = false;
	}

	private void checkBoxBamphim_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Form1.int_106 = Convert.ToByte(checkBoxBamphim.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagTNBamPhim", Form1.int_106, "", 0);
			if (Form1.int_106 > 0 && Form1.int_69 <= 0)
			{
				Form1.int_69 = 1;
				GClass0.smethod_1();
				GClass0.smethod_0();
			}
		}
	}

	private void comboBoxPhim_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		string text = comboBoxPhim.Text;
		for (int i = 0; i < Class30.gstruct42_0.Length; i++)
		{
			if (text == Class30.gstruct42_0[i].string_0)
			{
				if (Form1.int_107 != i)
				{
					Form1.int_107 = i;
					Class66.smethod_11(Class66.smethod_1(), "TNIdexPhim", Form1.int_107, "", 0);
				}
				break;
			}
		}
	}

	private void checkBoxTutimMuctieu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Form1.int_38 = Convert.ToByte(checkBoxTutimMuctieu.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagTutimMuctieu", Form1.int_38, "", 0);
		}
	}

	private void buttonApdung_Click(object sender, EventArgs e)
	{
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Form1.characterAccountConfig_1[i].int_88 = 0;
				Class56.smethod_13(Form1.characterAccountConfig_1[i]);
			}
		}
		bool_0 = false;
		Close();
	}

	private void checkBoxBossTruocNguoiSau_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Form1.int_40 = Convert.ToByte(checkBoxBossTruocNguoiSau.Checked);
			Class66.smethod_11(Class66.smethod_1(), "BossTruocNguoiSau", Form1.int_40, "", 0);
		}
	}

	private void checkBoxChetNamImAll_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Form1.int_42 = Convert.ToByte(checkBoxChetNamImAll.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fNamImONOFF", Form1.int_42, "", 0);
		}
	}

	private void checkBoxBosKenhKhac_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class97.int_0[0] = Convert.ToByte(checkBoxBosKenhKhac.Checked);
			Class66.smethod_11(Class66.smethod_1(), "KenhKhac", Class97.int_0[0], "", 0);
		}
	}

	private void checkBoxBosPhongTan_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class97.int_0[1] = Convert.ToByte(checkBoxBosPhongTan.Checked);
			Class66.smethod_11(Class66.smethod_1(), "PhongTan", Class97.int_0[1], "", 0);
		}
	}

	private void checkBoxBosKenhBang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class97.int_0[2] = Convert.ToByte(checkBoxBosKenhBang.Checked);
			Class66.smethod_11(Class66.smethod_1(), "KenhBang", Class97.int_0[2], "", 0);
		}
	}

	private void textBoxBosGiay_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class97.int_0[3] = Class11.smethod_11(textBoxBosGiay.Text);
			Class66.smethod_11(Class66.smethod_1(), "BaoTime", Class97.int_0[3], "", 0);
		}
	}

	private void checkBoxMuaNoiChiendau_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Form1.int_33 = Convert.ToByte(checkBoxMuaNoiChiendau.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fMuaNoiChiendau", Form1.int_33, "", 0);
		}
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || struct24_0 == null)
		{
			return;
		}
		string text = comboBox1.Text;
		int num = 0;
		while (true)
		{
			if (num < struct24_0.Length)
			{
				string text2 = Class1.smethod_1(struct24_0[num].string_0, 1);
				if (text2 == text)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Class19.string_0[0] = struct24_0[num].string_0;
		Class66.smethod_11(Class66.smethod_1(), "KTCTabName0", Class11.smethod_16(struct24_0[num].string_0), "", 0);
	}

	private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || struct24_0 == null)
		{
			return;
		}
		string text = comboBox2.Text;
		for (int i = 0; i < struct24_0.Length; i++)
		{
			string text2 = Class1.smethod_1(struct24_0[i].string_0, 1);
			if (text2 == text)
			{
				Class19.string_0[1] = struct24_0[i].string_0;
				Class66.smethod_11(Class66.smethod_1(), "KTCTabName1", Class11.smethod_16(struct24_0[i].string_0), "", 0);
				break;
			}
		}
	}

	private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || struct24_0 == null)
		{
			return;
		}
		string text = comboBox3.Text;
		for (int i = 0; i < struct24_0.Length; i++)
		{
			string text2 = Class1.smethod_1(struct24_0[i].string_0, 1);
			if (text2 == text)
			{
				Class19.string_0[2] = struct24_0[i].string_0;
				Class66.smethod_11(Class66.smethod_1(), "KTCTabName2", Class11.smethod_16(struct24_0[i].string_0), "", 0);
				break;
			}
		}
	}

	private void checkBoxChiTiet_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Class97.int_1 = Convert.ToByte(checkBoxChiTiet.Checked);
			Class66.smethod_11(Class66.smethod_1(), "Chitiet", Class97.int_1, "", 0);
		}
	}

	private void checkBoxQuangThuoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Form1.int_31 = Convert.ToByte(checkBoxQuangThuoc.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fQuangThuocAchinh", Form1.int_31, "", 0);
		}
	}

	private void checkBoxTDP_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Form1.int_32 = Convert.ToByte(checkBoxTDP.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fQuangThuocTDP", Form1.int_32, "", 0);
		}
	}

	private void buttonBaovatXoaSaiso_Click(object sender, EventArgs e)
	{
		Form1.int_9 = 0;
		Class66.smethod_11(Class66.smethod_1(), "SaisoBaovat", Form1.int_9, "", 0);
		textBoxSaisoBaovat.Text = Form1.int_9.ToString();
	}

	private void buttonTimSaiso_Click(object sender, EventArgs e)
	{
		string text = "Hãy chọn 1 ac rồi bấm nút < Bảo vật > và bấm nút < " + buttonTimSaiso.Text + "> này.";
		int num = -1000000;
		int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (0 <= num2)
		{
			num = Class75.smethod_29(Form1.characterAccountConfig_1[num2]);
		}
		if (-1000002 <= num && num <= -1000000 && Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				num = Class75.smethod_29(Form1.characterAccountConfig_1[i]);
				if (num > -1000000 || num < -1000002)
				{
					break;
				}
			}
		}
		switch (num)
		{
		default:
		{
			int num3 = (Form1.int_9 = (num - 2208) / 16);
			Class66.smethod_11(Class66.smethod_1(), "SaisoBaovat", Form1.int_9, "", 0);
			textBoxSaisoBaovat.Text = num3.ToString();
			text = "Đã lấy được giá trị sai số là: " + num3 + ". " + Class56.string_7 + "Có thể mua vật phẩm ở Bảo vật được rồi !";
			break;
		}
		case -1000002:
			text = "Hãy bấm nút Mua cho ac <" + Class1.smethod_1(Form1.characterAccountConfig_1[num2].string_22, 1) + "> sau đó lấy lại giá trị.";
			break;
		case -1000001:
			text = "Không lấy được giá trị, hãy mở Bảo vật và bấm nút Mua cho ac <" + Class1.smethod_1(Form1.characterAccountConfig_1[num2].string_22, 1) + "> sau đó lấy lại giá trị.";
			break;
		case -1000000:
			text = "Hãy chọn 1 ac rồi bấm nút < Bảo vật > và bấm nút < " + buttonTimSaiso.Text + "> này.";
			break;
		}
		FormTip.smethod_0(Form1.string_49, text, 60000, 250, 100);
	}

	private void richTextBox1_TextChanged(object sender, EventArgs e)
	{
	}
}
