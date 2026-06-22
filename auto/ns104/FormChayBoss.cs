using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns10;
using ns100;
using ns11;
using ns13;
using ns138;
using ns23;
using ns28;
using ns41;
using ns42;
using ns43;
using ns50;
using ns53;
using ns61;
using ns63;
using ns71;
using ns83;
using ns85;
using ns91;

namespace ns104;

public class FormChayBoss : Form
{
	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private CheckBox checkBoxTuLuuRuong;

	private ComboBox comboBoxTenTat;

	private TextBox textBoxToado;

	private Label label1;

	private Button buttonThem;

	private Button buttonXoa;

	private Button buttonSua;

	private Label label2;

	private Button buttonLen;

	private Button buttonXuong;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonMacdinh;

	private ColumnHeader columnHeader_2;

	private Button buttonApdungAll;

	private GroupBox groupBox1;

	private Label label3;

	private Label label4;

	private CheckBox checkBoxTrolaiDiemcu;

	private Button buttonLuu;

	private Button buttonXem;

	private Label label5;

	private Button buttonThumucAuto;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	public static bool bool_0;

	public static bool bool_1;

	public static string string_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	private static bool bool_2;

	private static bool bool_3;

	public static int int_4;

	public static int int_5;

	public static string[,] string_1;

	private static uint[,] uint_0;

	public static string[,] string_2;

	public FormChayBoss()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	static FormChayBoss()
	{
		bool_0 = false;
		bool_1 = false;
		string_0 = null;
		bool_2 = false;
		bool_3 = false;
		int_4 = Class66.smethod_4("flagLuuRuongChayBoss", 0, "1");
		int_5 = Class66.smethod_4("flagDiemcuChayBoss", 0, "1");
		string_1 = new string[111, 5]
		{
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "PDĐ.1 213.182", "213.182", "11", "11|20|202", "Phù Dung động" },
			{ "PDĐ.2 192.188", "192.188", "11", "11|20|202", "Phù Dung động" },
			{ "PDĐ.3 200.195", "200.195", "11", "11|20|202", "Phù Dung động" },
			{ "PDĐ.4 193.177", "193.177", "11", "11|20|202", "Phù Dung động" },
			{ "PDĐ.5 185.176", "185.176", "11", "11|20|202", "Phù Dung động" },
			{ "PDĐ.6 191.166", "191.166", "11", "11|20|202", "Phù Dung động" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "PTĐ.1 205.202", "205.202", "37", "37|100|204", "Phi Thiên động" },
			{ "PTĐ.2 219.220", "219.220", "37", "37|100|204", "Phi Thiên động" },
			{ "PTĐ.3 182.225", "182.225", "37", "37|100|204", "Phi Thiên động" },
			{ "PTĐ.4 175.212", "175.212", "37", "37|100|204", "Phi Thiên động" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "TKĐ.1 211.188", "211.188", "162", "176|174|198", "Thanh Khê động" },
			{ "TKĐ.2 192.176", "192.176", "162", "176|174|198", "Thanh Khê động" },
			{ "TKĐ.3 202.199", "202.199", "162", "176|174|198", "Thanh Khê động" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "VLĐ.1 225.187", "225.187", "78", "78|53|199", "Vũ Lăng động" },
			{ "VLĐ.2 209.200", "209.200", "78", "78|53|199", "Vũ Lăng động" },
			{ "VLĐ.3 181.185", "181.185", "78", "78|53|199", "Vũ Lăng động" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "LTĐ.1 0.0", "0.0", "162", "176|174|179|181", "Lưỡng Thủy động" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "DTĐ.1 201.210", "201.210", "80", "80|101|205", "Dương Trung động" },
			{ "DTĐ.2 198.202", "198.202", "80", "80|101|205", "Dương Trung động" },
			{ "DTĐ.3 187.194", "187.194", "80", "80|101|205", "Dương Trung động" },
			{ "DTĐ.4 160.192", "160.192", "80", "80|101|205", "Dương Trung động" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "NTĐ.1 0.0", "0.0", "11", "11|9|10", "Nhạn Thạch động" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "SBĐ.1 0.0", "0.0", "1", "78|53|74|76", "Sơn Bảo động" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "KLĐ.1 0.0", "0.0", "1", "78|53|74|76|75", "Khỏa Lang động" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "VDĐ.1 0.0", "0.0", "162", "162|153|203", "Vô Danh động" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "TBN.1 164.149", "164.149", "1", "37|319|320|321", "Trường Bạch Sơn Nam" },
			{ "TBN.2 183.148", "183.148", "1", "37|319|320|321", "Trường Bạch Sơn Nam" },
			{ "TBN.3 148.175", "148.175", "1", "37|319|320|321", "Trường Bạch Sơn Nam" },
			{ "TBN.4 124.180", "124.180", "1", "37|319|320|321", "Trường Bạch Sơn Nam" },
			{ "TBN.5 127.186", "127.186", "1", "37|319|320|321", "Trường Bạch Sơn Nam" },
			{ "TBN.6 172.193", "172.193", "1", "37|319|320|321", "Trường Bạch Sơn Nam" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "TBB.1 222.202", "222.202", "37", "37|319|320|322", "Trường Bạch Sơn Bắc" },
			{ "TBB.2 248.202", "248.202", "37", "37|319|320|322", "Trường Bạch Sơn Bắc" },
			{ "TBB.3 237.202", "237.202", "37", "37|319|320|322", "Trường Bạch Sơn Bắc" },
			{ "TBB.4 211.218", "211.218", "37", "37|319|320|322", "Trường Bạch Sơn Bắc" },
			{ "TBB.5 203.221", "203.221", "37", "37|319|320|322", "Trường Bạch Sơn Bắc" },
			{ "TBB.6 226.230", "226.230", "37", "37|319|320|322", "Trường Bạch Sơn Bắc" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "MCQ.1 167.183", "167.183", "11", "1|121|340", "Mạc Cao Quật" },
			{ "MCQ.2 175.201", "175.201", "11", "1|121|340", "Mạc Cao Quật" },
			{ "MCQ.3 206.205", "206.205", "11", "1|121|340", "Mạc Cao Quật" },
			{ "MCQ.4 231.177", "231.177", "11", "1|121|340", "Mạc Cao Quật" },
			{ "MCQ.5 219.205", "219.205", "11", "1|121|340", "Mạc Cao Quật" },
			{ "MCQ.6 225.194", "225.194", "11", "1|121|340", "Mạc Cao Quật" },
			{ "MCQ.7 185.205", "185.205", "11", "1|121|340", "Mạc Cao Quật" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "SMĐB.1 215.178", "215.178", "176", "1|121|131|136|224", "Sa Mạc địa biểu" },
			{ "SMĐB.2 230.185", "230.185", "176", "1|121|131|136|224", "Sa Mạc địa biểu" },
			{ "SMĐB.3 188.190", "188.190", "176", "1|121|131|136|224", "Sa Mạc địa biểu" },
			{ "SMĐB.4 210.192", "210.192", "176", "1|121|131|136|224", "Sa Mạc địa biểu" },
			{ "SMĐB.5 211.200", "211.200", "176", "1|121|131|136|224", "Sa Mạc địa biểu" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "SM1.1 194.205", "194.205", "176", "1|121|131|136|224|225", "Sa Mạc 1" },
			{ "SM1.2 180.210", "180.210", "176", "1|121|131|136|224|225", "Sa Mạc 1" },
			{ "SM1.3 176.216", "176.216", "176", "1|121|131|136|224|225", "Sa Mạc 1" },
			{ "SM1.4 160.203", "160.203", "176", "1|121|131|136|224|225", "Sa Mạc 1" },
			{ "SM1.5 176.194", "176.194", "176", "1|121|131|136|224|225", "Sa Mạc 1" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "SM2.1 215.201", "215.201", "176", "1|121|131|136|224|226", "Sa Mạc 2" },
			{ "SM2.2 0.0", "0.0", "176", "1|121|131|136|224|226", "Sa Mạc 2" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "SM3.1 170.197", "170.197", "176", "1|121|131|136|224|227", "Sa Mạc 3" },
			{ "SM3.2 0.0", "0.0", "176", "1|121|131|136|224|227", "Sa Mạc 3" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "PLĐ.1 0.0", "0.0", "78", "1|121|336", "Phong Lăng độ" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "LA.1 154.209", "154.209", "176", "176", "Lâm An" },
			{ "LA.2 150.192", "150.192", "176", "176", "Lâm An" },
			{ "LA.3 140.168", "140.168", "176", "176", "Lâm An" },
			{ "LA.4 0.0", "0.0", "176", "176", "Lâm An" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "BK.1 200.176", "200.176", "37", "37", "Biện Kinh" },
			{ "BK.2 252.175", "252.175", "37", "37", "Biện Kinh" },
			{ "BK.3 222.212", "222.212", "37", "37", "Biện Kinh" },
			{ "BK.4 0.0", "0.0", "37", "37", "Biện Kinh" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "PhTuong.1 177.204", "177.204", "1", "1", "Phượng Tường" },
			{ "PhTuong.2 225.191", "225.191", "1", "1", "Phượng Tường" },
			{ "PhTuong.3 229.213", "229.213", "1", "1", "Phượng Tường" },
			{ "PhTuong.4 0.0", "0.0", "1", "1", "Phượng Tường" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "DC.1 202.180", "202.180", "80", "80", "Dương Châu" },
			{ "DC.2 193.210", "193.210", "80", "80", "Dương Châu" },
			{ "DC.3 0.0", "0.0", "80", "80", "Dương Châu" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "ĐL.1 225.207", "225.207", "162", "162", "Đại Lý" },
			{ "ĐL.2 223.186", "223.186", "162", "162", "Đại Lý" },
			{ "ĐL.3 165.196", "165.196", "162", "162", "Đại Lý" },
			{ "ĐL.4 0.0", "0.0", "162", "162", "Đại Lý" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "TD.1 174.190", "174.190", "78", "78", "Tương Dương" },
			{ "TD.2 212.209", "212.209", "78", "78", "Tương Dương" },
			{ "TD.3 210.221", "210.221", "78", "78", "Tương Dương" },
			{ "TD.4 0.0", "0.0", "78", "78", "Tương Dương" },
			{ "...", "0.0", "0", "0|0|0|0", "" },
			{ "TĐô.1 374.302", "374.302", "11", "11", "Thành Đô" },
			{ "TĐô.2 419.320", "419.320", "11", "11", "Thành Đô" },
			{ "TĐô.3 375.328", "375.328", "11", "11", "Thành Đô" },
			{ "TĐô.4 0.0", "0.0", "11", "11", "Thành Đô" }
		};
		uint[,] array_ = new uint[16, 2];
		Class10.smethod_4(array_, 387451);
		uint_0 = array_;
		string_2 = smethod_0();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns104.FormChayBoss));
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.checkBoxTuLuuRuong = new System.Windows.Forms.CheckBox();
		this.comboBoxTenTat = new System.Windows.Forms.ComboBox();
		this.textBoxToado = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.buttonThem = new System.Windows.Forms.Button();
		this.buttonXoa = new System.Windows.Forms.Button();
		this.buttonSua = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.buttonLen = new System.Windows.Forms.Button();
		this.buttonXuong = new System.Windows.Forms.Button();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonMacdinh = new System.Windows.Forms.Button();
		this.buttonApdungAll = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.checkBoxTrolaiDiemcu = new System.Windows.Forms.CheckBox();
		this.buttonLuu = new System.Windows.Forms.Button();
		this.buttonXem = new System.Windows.Forms.Button();
		this.label5 = new System.Windows.Forms.Label();
		this.buttonThumucAuto = new System.Windows.Forms.Button();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.groupBox1.SuspendLayout();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.tabPage2.SuspendLayout();
		base.SuspendLayout();
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(1, 3);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(348, 277);
		this.listView1.TabIndex = 0;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		this.columnHeader_0.Text = "Tên tắt";
		this.columnHeader_0.Width = 110;
		this.columnHeader_1.Text = "Tọa độ";
		this.columnHeader_1.Width = 80;
		this.columnHeader_2.Text = "Tên đầy đủ";
		this.columnHeader_2.Width = 130;
		this.checkBoxTuLuuRuong.AutoSize = true;
		this.checkBoxTuLuuRuong.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxTuLuuRuong.Location = new System.Drawing.Point(3, 511);
		this.checkBoxTuLuuRuong.Name = "checkBoxTuLuuRuong";
		this.checkBoxTuLuuRuong.Size = new System.Drawing.Size(225, 17);
		this.checkBoxTuLuuRuong.TabIndex = 162;
		this.checkBoxTuLuuRuong.Text = "Lưu rương trước khi chạy đến tọa độ boss";
		this.checkBoxTuLuuRuong.UseVisualStyleBackColor = true;
		this.checkBoxTuLuuRuong.CheckedChanged += new System.EventHandler(checkBoxTuLuuRuong_CheckedChanged);
		this.comboBoxTenTat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxTenTat.FormattingEnabled = true;
		this.comboBoxTenTat.Location = new System.Drawing.Point(57, 56);
		this.comboBoxTenTat.Name = "comboBoxTenTat";
		this.comboBoxTenTat.Size = new System.Drawing.Size(79, 21);
		this.comboBoxTenTat.TabIndex = 163;
		this.textBoxToado.Location = new System.Drawing.Point(57, 82);
		this.textBoxToado.Name = "textBoxToado";
		this.textBoxToado.Size = new System.Drawing.Size(79, 20);
		this.textBoxToado.TabIndex = 164;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(12, 82);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(42, 13);
		this.label1.TabIndex = 165;
		this.label1.Text = "Tọa độ";
		this.buttonThem.Location = new System.Drawing.Point(142, 80);
		this.buttonThem.Name = "buttonThem";
		this.buttonThem.Size = new System.Drawing.Size(72, 23);
		this.buttonThem.TabIndex = 166;
		this.buttonThem.Text = "Thêm mới";
		this.buttonThem.UseVisualStyleBackColor = true;
		this.buttonThem.Click += new System.EventHandler(buttonThem_Click);
		this.buttonXoa.Location = new System.Drawing.Point(221, 54);
		this.buttonXoa.Name = "buttonXoa";
		this.buttonXoa.Size = new System.Drawing.Size(45, 23);
		this.buttonXoa.TabIndex = 167;
		this.buttonXoa.Text = "Xóa";
		this.buttonXoa.UseVisualStyleBackColor = true;
		this.buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		this.buttonSua.Location = new System.Drawing.Point(142, 54);
		this.buttonSua.Name = "buttonSua";
		this.buttonSua.Size = new System.Drawing.Size(72, 23);
		this.buttonSua.TabIndex = 168;
		this.buttonSua.Text = "Sửa";
		this.buttonSua.UseVisualStyleBackColor = true;
		this.buttonSua.Click += new System.EventHandler(buttonSua_Click);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(12, 61);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(26, 13);
		this.label2.TabIndex = 169;
		this.label2.Text = "Tên";
		this.buttonLen.ForeColor = System.Drawing.Color.DarkGreen;
		this.buttonLen.Location = new System.Drawing.Point(273, 54);
		this.buttonLen.Name = "buttonLen";
		this.buttonLen.Size = new System.Drawing.Size(60, 23);
		this.buttonLen.TabIndex = 170;
		this.buttonLen.Text = "Lên";
		this.buttonLen.UseVisualStyleBackColor = true;
		this.buttonLen.Click += new System.EventHandler(buttonLen_Click);
		this.buttonXuong.ForeColor = System.Drawing.Color.DarkGreen;
		this.buttonXuong.Location = new System.Drawing.Point(273, 80);
		this.buttonXuong.Name = "buttonXuong";
		this.buttonXuong.Size = new System.Drawing.Size(60, 23);
		this.buttonXuong.TabIndex = 171;
		this.buttonXuong.Text = "Xuống";
		this.buttonXuong.UseVisualStyleBackColor = true;
		this.buttonXuong.Click += new System.EventHandler(buttonXuong_Click);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonMacdinh.ForeColor = System.Drawing.Color.Black;
		this.buttonMacdinh.Location = new System.Drawing.Point(173, 551);
		this.buttonMacdinh.Name = "buttonMacdinh";
		this.buttonMacdinh.Size = new System.Drawing.Size(90, 38);
		this.buttonMacdinh.TabIndex = 172;
		this.buttonMacdinh.Text = "Xóa tọa độ về mặc định";
		this.buttonMacdinh.UseVisualStyleBackColor = true;
		this.buttonMacdinh.Click += new System.EventHandler(buttonMacdinh_Click);
		this.buttonApdungAll.ForeColor = System.Drawing.Color.Black;
		this.buttonApdungAll.Location = new System.Drawing.Point(268, 551);
		this.buttonApdungAll.Name = "buttonApdungAll";
		this.buttonApdungAll.Size = new System.Drawing.Size(90, 38);
		this.buttonApdungAll.TabIndex = 173;
		this.buttonApdungAll.Text = "Lưu thay đổi và đóng";
		this.buttonApdungAll.UseVisualStyleBackColor = true;
		this.buttonApdungAll.Click += new System.EventHandler(buttonApdungAll_Click);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.buttonXuong);
		this.groupBox1.Controls.Add(this.buttonLen);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.buttonSua);
		this.groupBox1.Controls.Add(this.buttonXoa);
		this.groupBox1.Controls.Add(this.buttonThem);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.textBoxToado);
		this.groupBox1.Controls.Add(this.comboBoxTenTat);
		this.groupBox1.Location = new System.Drawing.Point(2, 288);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(347, 116);
		this.groupBox1.TabIndex = 175;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Thêm bớt - Chỉnh sửa tọa độ";
		this.label3.Location = new System.Drawing.Point(12, 20);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(318, 28);
		this.label3.TabIndex = 172;
		this.label3.Text = "Cột tọa độ ghi 0.0 là chưa có tọa độ boss, người dùng phải tự sửa hoặc thêm vào (hoặc để 0.0 nếu muốn ac chạy lên đầu cổng)";
		this.label4.Location = new System.Drawing.Point(2, 4);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(356, 59);
		this.label4.TabIndex = 173;
		this.label4.Text = resources.GetString("label4.Text");
		this.checkBoxTrolaiDiemcu.AutoSize = true;
		this.checkBoxTrolaiDiemcu.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxTrolaiDiemcu.Location = new System.Drawing.Point(262, 511);
		this.checkBoxTrolaiDiemcu.Name = "checkBoxTrolaiDiemcu";
		this.checkBoxTrolaiDiemcu.Size = new System.Drawing.Size(96, 17);
		this.checkBoxTrolaiDiemcu.TabIndex = 177;
		this.checkBoxTrolaiDiemcu.Text = "Trở lại điểm cũ";
		this.checkBoxTrolaiDiemcu.UseVisualStyleBackColor = true;
		this.checkBoxTrolaiDiemcu.CheckedChanged += new System.EventHandler(checkBoxTrolaiDiemcu_CheckedChanged);
		this.buttonLuu.ForeColor = System.Drawing.Color.Purple;
		this.buttonLuu.Location = new System.Drawing.Point(3, 551);
		this.buttonLuu.Name = "buttonLuu";
		this.buttonLuu.Size = new System.Drawing.Size(72, 38);
		this.buttonLuu.TabIndex = 178;
		this.buttonLuu.Text = "Lưu để xem lại";
		this.buttonLuu.UseVisualStyleBackColor = true;
		this.buttonLuu.Click += new System.EventHandler(buttonLuu_Click);
		this.buttonXem.ForeColor = System.Drawing.Color.Purple;
		this.buttonXem.Location = new System.Drawing.Point(80, 551);
		this.buttonXem.Name = "buttonXem";
		this.buttonXem.Size = new System.Drawing.Size(63, 38);
		this.buttonXem.TabIndex = 179;
		this.buttonXem.Text = "Xem lại file lưu";
		this.buttonXem.UseVisualStyleBackColor = true;
		this.buttonXem.Click += new System.EventHandler(buttonXem_Click);
		this.label5.Location = new System.Drawing.Point(4, 4);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(345, 201);
		this.label5.TabIndex = 180;
		this.label5.Text = resources.GetString("label5.Text");
		this.buttonThumucAuto.ForeColor = System.Drawing.Color.Black;
		this.buttonThumucAuto.Location = new System.Drawing.Point(124, 208);
		this.buttonThumucAuto.Name = "buttonThumucAuto";
		this.buttonThumucAuto.Size = new System.Drawing.Size(90, 38);
		this.buttonThumucAuto.TabIndex = 181;
		this.buttonThumucAuto.Text = "Mở thư mục auto";
		this.buttonThumucAuto.UseVisualStyleBackColor = true;
		this.buttonThumucAuto.Click += new System.EventHandler(buttonThumucAuto_Click);
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Location = new System.Drawing.Point(1, 68);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(357, 437);
		this.tabControl1.TabIndex = 182;
		this.tabPage1.Controls.Add(this.listView1);
		this.tabPage1.Controls.Add(this.groupBox1);
		this.tabPage1.Location = new System.Drawing.Point(4, 22);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(349, 411);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Tọa độ boss";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.tabPage2.Controls.Add(this.label5);
		this.tabPage2.Controls.Add(this.buttonThumucAuto);
		this.tabPage2.Location = new System.Drawing.Point(4, 22);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(349, 411);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "Chép tọa độ sang máy khác";
		this.tabPage2.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(359, 602);
		base.Controls.Add(this.buttonLuu);
		base.Controls.Add(this.buttonXem);
		base.Controls.Add(this.tabControl1);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.buttonApdungAll);
		base.Controls.Add(this.buttonMacdinh);
		base.Controls.Add(this.checkBoxTrolaiDiemcu);
		base.Controls.Add(this.checkBoxTuLuuRuong);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormChayBoss";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "BOSS";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormChayBoss_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage2.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private static string[,] smethod_0()
	{
		string text = Class11.smethod_33(Class56.string_9 + "\\ToadoBoss.txt", 0, 0, 1);
		if (text != null && !(text == string.Empty))
		{
			string[] array = text.Split('\r', '\n');
			int num = 0;
			bool flag = false;
			bool flag2 = false;
			string[,] array2 = new string[array.Length, 5];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null || array[i] == string.Empty)
				{
					continue;
				}
				string[] array3 = array[i].Split('ÿ');
				if (array3.Length == 5 && smethod_1(array3[0]))
				{
					if (Class11.smethod_2(array3[0], "PhTuong"))
					{
						flag = true;
					}
					if (Class11.smethod_2(array3[0], "SBĐ"))
					{
						flag2 = true;
					}
					for (int j = 0; j < 5; j++)
					{
						array2[num, j] = array3[j];
					}
					num++;
				}
			}
			if (!flag || !flag2)
			{
				bool_3 = true;
			}
			if (num != array2.GetLength(0))
			{
				string[,] array4 = new string[num, 5];
				for (int k = 0; k < num; k++)
				{
					for (int l = 0; l < 5; l++)
					{
						array4[k, l] = array2[k, l];
					}
				}
				return array4;
			}
			return array2;
		}
		return string_1;
	}

	private static bool smethod_1(string string_3)
	{
		if (string_3 != null && !(string_3 == string.Empty))
		{
			int num = Class11.smethod_1(string_3, ".");
			if (num > 0)
			{
				string_3 = string_3.Substring(0, num);
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < string_1.GetLength(0))
				{
					if (Class11.smethod_1(string_1[num2, 0], string_3) == 0)
					{
						break;
					}
					num2++;
					continue;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public static int smethod_2(CharacterAccountConfig characterAccountConfig_0)
	{
		int num = 0;
		int int_ = characterAccountConfig_0.int_136;
		int num2 = 0;
		int num3 = characterAccountConfig_0.int_0;
		long long_ = 0L;
		uint[] array = null;
		if (num3 >= 0 && string_2.GetLength(0) > num3)
		{
			string text = string_2[num3, 0];
			if (text != null && !(text == string.Empty) && !(text == "...") && text[0] != '.')
			{
				string[] array2 = string_2[num3, 1].Split('/', '.', ',');
				if (array2.Length < 2)
				{
					num = 1;
				}
				else
				{
					int num4 = Class11.smethod_11(string_2[num3, 2]);
					if (num4 > 0)
					{
						uint[] array3 = new uint[2]
						{
							Class11.smethod_12(array2[0]) * 256,
							Class11.smethod_12(array2[1]) * 512
						};
						string[] array4 = string_2[num3, 3].Split('|');
						int[] array5 = new int[array4.Length];
						for (int i = 0; i < array5.Length; i++)
						{
							array5[i] = Class11.smethod_11(array4[i]);
						}
						int num5 = array5[array5.Length - 1];
						if (num5 > 0)
						{
							bool flag = int_4 <= 0;
							bool flag2 = false;
							int num6 = 0;
							int num7 = 0;
							int num8 = 0;
							int num9 = 0;
							int num10 = 0;
							int num11 = 0;
							int num12 = -1;
							int num13 = 0;
							uint[,] array6 = new uint[5, 2];
							Class10.smethod_4(array6, 380109);
							uint[,] array7 = array6;
							GStruct28 gStruct = default(GStruct28);
							int num14 = 0;
							int num15 = -1;
							int num16 = 0;
							int num17 = -1;
							int int_2 = 0;
							byte[] byte_ = new byte[4];
							while (true)
							{
								Thread.Sleep(180);
								int num18 = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
								uint num23;
								bool flag3;
								int num32;
								bool flag5;
								uint[] array8;
								int num27;
								int num26;
								int num33;
								if (!Class11.bool_0 && num18 >= 0 && Form1.characterAccountConfig_1[num18].bool_25)
								{
									characterAccountConfig_0 = Form1.characterAccountConfig_1[num18];
									if (num14 == 0)
									{
										if (Class46.characterSyncSnapshot_0.int_0 == characterAccountConfig_0.int_136)
										{
											Class46.characterSyncSnapshot_0.bool_1 = true;
										}
										Class75.smethod_52(characterAccountConfig_0, Class1.smethod_2("<color=yellow>Bắt đầu chạy điểm boss..."));
										num14 = 1;
									}
									if (num3 == characterAccountConfig_0.int_0 && characterAccountConfig_0.bool_1)
									{
										int num19 = Class89.smethod_12(characterAccountConfig_0);
										if (num19 != 1)
										{
											uint num20 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
											uint num21 = Class24.smethod_30(num20 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
											uint num22 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
											num23 = num22 + num21 * Class56.memorySignatureScanConfig_15.uint_0;
											int num24 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
											int num25 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
											num26 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
											num27 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
											int num28 = Class89.smethod_39(characterAccountConfig_0);
											if (num25 > 0 && num26 > 0 && num24 != 10 && num24 != 21 && num28 > 1)
											{
												if (num17 != num26)
												{
													num16 = 0;
													num17 = num26;
												}
												if (num15 >= 0 && num15 == num27)
												{
													array8 = new uint[2]
													{
														Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
														Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
													};
													flag3 = array3 == null || array3[0] == 0 || array3[1] == 0;
													if (num26 == num5 && (flag || int_4 <= 0 || num27 > 0))
													{
														flag = true;
														num16 = 0;
														if (!flag3)
														{
															if (0 > num12 || num12 == num27)
															{
																long num29 = Class64.smethod_18(array8, array3);
																if (num29 >= 100000L)
																{
																	if (array == null)
																	{
																		array = new uint[2]
																		{
																			array8[0],
																			array8[1]
																		};
																		num2 = 0;
																	}
																	if (num2 > 2)
																	{
																		bool flag4 = array != null && Class64.smethod_18(array, array8) < 180000L;
																		array = null;
																		if (flag4)
																		{
																			Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_2);
																			Class64.smethod_2(characterAccountConfig_0, array8, array3, 600);
																			goto IL_10a6;
																		}
																	}
																	Class64.smethod_29(characterAccountConfig_0, bool_0: false);
																	if (num26 == 224)
																	{
																		num29 = Class64.smethod_21(array7, array8);
																		if (num29 < 200000L)
																		{
																			int length = array7.GetLength(0);
																			uint[] uint_ = new uint[2]
																			{
																				array7[0, 0],
																				array7[0, 1]
																			};
																			uint[] array9 = new uint[2]
																			{
																				array7[length - 1, 0],
																				array7[length - 1, 1]
																			};
																			long num30 = Class64.smethod_18(array8, uint_);
																			long num31 = Class64.smethod_18(array8, array9);
																			if (num30 < num31)
																			{
																				Class64.smethod_22(characterAccountConfig_0, array7, array8, array9, num26);
																			}
																		}
																	}
																	if (!Class13.smethod_3(characterAccountConfig_0) || Class11.smethod_28(long_) > 5000L)
																	{
																		num2++;
																		num12 = num27;
																		Class13.smethod_1(characterAccountConfig_0, array3);
																		long_ = Class11.smethod_27();
																	}
																	goto IL_10a6;
																}
																num = 1;
																break;
															}
															num = -1;
															break;
														}
														num = 1;
														break;
													}
													if (Form1.int_15 > 0 && num27 > 0)
													{
														gStruct = Class45.smethod_4(num26, num5);
														if (gStruct.int_0 == num26 && gStruct.int_1 == num5 && gStruct.uint_0 != null)
														{
															goto IL_0c68;
														}
													}
													uint[] array10 = null;
													num32 = array5.Length;
													flag5 = false;
													if (!flag2)
													{
														if (num13 <= 0)
														{
															num13 = ((num26 == num4) ? 1 : 0);
														}
														if (num32 > 1)
														{
															num33 = 0;
															while (num33 < array5.Length)
															{
																if (array5[num33] != num26)
																{
																	num33++;
																	continue;
																}
																goto IL_063a;
															}
														}
													}
													if (!flag && int_4 > 0)
													{
														if (num32 == 1 && !flag3)
														{
															array10 = Class45.smethod_11(array3, num4, "R\u00ad¬ng chøa ®å");
														}
														if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0 && num9 < 2)
														{
															flag = Class29.smethod_7(characterAccountConfig_0, num4, null, array10, bool_0: true);
															num9++;
															goto IL_10a6;
														}
														num27 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
														if (num27 > 0)
														{
															int[] array11 = new int[4] { 224, 225, 226, 227 };
															bool flag6 = false;
															bool flag7 = false;
															for (num33 = 0; num33 < array11.Length; num33++)
															{
																if (num5 == array11[num33])
																{
																	flag6 = true;
																}
																if (num26 == array11[num33])
																{
																	flag7 = true;
																}
															}
															if (flag6 && flag7)
															{
																gStruct = Class45.smethod_4(num26, num5);
																goto IL_0c68;
															}
															if (!Class64.smethod_14(characterAccountConfig_0))
															{
																Thread.Sleep(100);
																num = 1;
															}
															else
															{
																Thread.Sleep(300);
																Class64.smethod_11(characterAccountConfig_0);
																num = -1;
															}
															break;
														}
														num26 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
														if (num26 != num4)
														{
															num13 = 2;
															if (flag2 = Class53.smethod_5(characterAccountConfig_0, num4) > 0)
															{
																Thread.Sleep(300);
																Class64.smethod_11(characterAccountConfig_0);
															}
														}
														else
														{
															flag = int_4 <= 0 || Class98.smethod_0(characterAccountConfig_0, bool_0: true, array10) > 0;
														}
														goto IL_10a6;
													}
													num10++;
													flag2 = false;
													goto IL_07be;
												}
												for (int j = 0; j < 8; j++)
												{
													if (num27 == num15)
													{
														break;
													}
													if (num15 <= 0)
													{
														break;
													}
													num27 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
													Thread.Sleep(100);
												}
												num15 = num27;
												num16 = 0;
												goto IL_10a6;
											}
											num = -2;
											break;
										}
										Thread.Sleep(100);
										goto IL_10a6;
									}
									num = -1;
									Class13.smethod_2(characterAccountConfig_0, bool_0: false);
									break;
								}
								num = -1;
								break;
								IL_063a:
								flag5 = true;
								if (num33 <= 0)
								{
									num10++;
									goto IL_07be;
								}
								goto IL_0b39;
								IL_0c68:
								Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_2);
								array8 = new uint[2]
								{
									Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
									Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
								};
								int num34 = 0;
								if (gStruct.uint_0.GetLength(0) > 1)
								{
									num34 = Class64.smethod_20(gStruct.uint_0, array8);
								}
								uint[] uint_2 = null;
								uint[] uint_3 = null;
								int num35 = 0;
								Class64.smethod_8(gStruct.uint_0, num34, ref uint_2, ref uint_3, ref num35);
								long num36 = Class64.smethod_18(array8, uint_2);
								if (num36 <= 240000L)
								{
									int num37 = 0;
									int num38 = 0;
									Thread.Sleep(600);
									while (num37 < 100 && num38 < 30)
									{
										int num39 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
										num38 = ((num39 != 3) ? (num38 + 1) : 0);
										num37++;
										Thread.Sleep(10);
									}
									Class64.smethod_23(characterAccountConfig_0, uint_2, num35, uint_3, gStruct.int_1);
									goto IL_10a6;
								}
								if (array == null)
								{
									array = new uint[2]
									{
										array8[0],
										array8[1]
									};
									num2 = 0;
								}
								if (num2 > 12)
								{
									long num40 = Class64.smethod_18(array, array8);
									if (num40 < 180000L)
									{
										Class24.WriteProcessMemory(characterAccountConfig_0.int_137, num23 + Class56.memorySignatureScanConfig_72.uint_0, byte_, 4, ref int_2);
										Class64.smethod_2(characterAccountConfig_0, array8, uint_2, 600);
									}
									array = null;
								}
								if (num26 == 53 && num5 == 199)
								{
									Class64.smethod_22(characterAccountConfig_0, uint_0, array8, null, num26, bool_0: false, 8000);
									goto IL_10a6;
								}
								num27 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
								if (num27 <= 0)
								{
									int[] array12 = Class64.smethod_9(num26);
									if (array12 == null || array12[1] != 0)
									{
										goto IL_0f5d;
									}
									uint[] array13 = Class45.smethod_11(uint_2, num26, "NGOAITHANH");
									if (array13 != null)
									{
										long num41 = Class64.smethod_18(uint_2, array13);
										if (num41 <= 400000000L)
										{
											uint[,] array14 = Class44.smethod_1(num26, array8, array13);
											if (array14 != null)
											{
												int num42 = Class64.smethod_20(array14, array13);
												if (num42 >= 0)
												{
													uint[] uint_4 = new uint[2]
													{
														array14[num42, 0],
														array14[num42, 1]
													};
													long num43 = Class64.smethod_18(array8, uint_4);
													if (num43 > 90000L)
													{
														Class13.smethod_2(characterAccountConfig_0, bool_0: false);
														Class64.smethod_22(characterAccountConfig_0, array14, array8, array13, num26, bool_0: true, 6000);
														goto IL_10a6;
													}
													goto IL_0f5d;
												}
											}
										}
									}
								}
								goto IL_1008;
								IL_10a6:
								Thread.Sleep(150);
								continue;
								IL_0b39:
								num26 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
								int num44 = -1;
								for (num33 = 0; num33 < array5.Length; num33++)
								{
									if (num26 == array5[num33])
									{
										num44 = num33;
										break;
									}
								}
								if (num44 >= 0 && array5.Length - 1 > num44)
								{
									gStruct = Class45.smethod_4(num26, array5[num44 + 1]);
									if (gStruct.uint_0 == null)
									{
										num = 1;
										break;
									}
									goto IL_0c68;
								}
								num26 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
								if (num26 == num5 && num11 <= 3)
								{
									num11++;
									if (!flag)
									{
										flag = num11 > 2;
									}
									goto IL_10a6;
								}
								num = 1;
								break;
								IL_07be:
								if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0 && num6 < 2)
								{
									bool flag8;
									if (!(flag8 = Class29.smethod_7(characterAccountConfig_0, num5)) && array5[num32 - 1] == 76)
									{
										flag8 = Class29.smethod_7(characterAccountConfig_0, 75);
									}
									if (flag8)
									{
										Thread.Sleep(300);
										Class64.smethod_11(characterAccountConfig_0);
										num6++;
										goto IL_10a6;
									}
								}
								num6 = 2;
								if (num10 == 1)
								{
									num27 = (int)Class24.smethod_30(num23 + Class56.memorySignatureScanConfig_43.uint_0, characterAccountConfig_0.int_137);
									if (num27 > 0)
									{
										if (flag5)
										{
											goto IL_0a5b;
										}
										if (num13 < 2)
										{
											num13 = 2;
											if (Class64.smethod_14(characterAccountConfig_0))
											{
												Thread.Sleep(300);
												Class64.smethod_11(characterAccountConfig_0);
												goto IL_10a6;
											}
										}
									}
									if (int_5 > 0 && num13 == 1 && Class53.smethod_2(characterAccountConfig_0, "®iÓm c") > 0)
									{
										num10 = 0;
										num13 = 2;
										Thread.Sleep(300);
										Class64.smethod_11(characterAccountConfig_0);
										Thread.Sleep(300);
										int num45 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
										if (num45 == num5)
										{
											goto IL_10a6;
										}
										if (num45 != num26)
										{
											if (num32 > 1)
											{
												num33 = 0;
												while (num33 < array5.Length)
												{
													if (array5[num33] != num26)
													{
														num33++;
														continue;
													}
													goto IL_10a6;
												}
											}
											if (Class64.smethod_14(characterAccountConfig_0))
											{
												Thread.Sleep(300);
												Class64.smethod_11(characterAccountConfig_0);
												goto IL_10a6;
											}
											num = -1;
											break;
										}
									}
									num13 = 2;
									num10 = 2;
									if (Class53.smethod_4(characterAccountConfig_0, array5[num32 - 1]) > 0)
									{
										Thread.Sleep(300);
										Class64.smethod_11(characterAccountConfig_0);
										goto IL_10a6;
									}
									num26 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
									if (num26 != array5[0])
									{
										if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0 && num7 < 2)
										{
											uint[] uint_5 = null;
											if (num32 == 1 && !flag3)
											{
												uint_5 = Class45.smethod_11(array3, array5[0], "NGOAITHANH");
											}
											num7++;
											if (Class29.smethod_7(characterAccountConfig_0, array5[0], null, uint_5))
											{
												Thread.Sleep(300);
												Class64.smethod_11(characterAccountConfig_0);
												goto IL_10a6;
											}
										}
										if (Class53.smethod_5(characterAccountConfig_0, array5[0]) > 0)
										{
											Thread.Sleep(300);
											Class64.smethod_11(characterAccountConfig_0);
										}
										goto IL_10a6;
									}
								}
								goto IL_0a5b;
								IL_0f5d:
								if (num26 == 224)
								{
									long num46 = Class64.smethod_21(array7, array8);
									if (num46 < 200000L)
									{
										int length2 = array7.GetLength(0);
										uint[] uint_6 = new uint[2]
										{
											array7[0, 0],
											array7[0, 1]
										};
										uint[] array15 = new uint[2]
										{
											array7[length2 - 1, 0],
											array7[length2 - 1, 1]
										};
										long num47 = Class64.smethod_18(array8, uint_6);
										long num48 = Class64.smethod_18(array8, array15);
										if (num47 < num48)
										{
											Class64.smethod_22(characterAccountConfig_0, array7, array8, array15, num26, bool_0: true);
										}
									}
								}
								goto IL_1008;
								IL_1008:
								if (!Class13.smethod_3(characterAccountConfig_0) || Class11.smethod_28(long_) > 5000L)
								{
									num2 += 3;
									Class13.smethod_1(characterAccountConfig_0, uint_2);
									long_ = Class11.smethod_27();
									Thread.Sleep(300);
								}
								Class64.smethod_29(characterAccountConfig_0, bool_0: false);
								goto IL_10a6;
								IL_0a5b:
								int num49 = -1;
								if (Class75.smethod_3(characterAccountConfig_0, Class75.uint_19, 4) > 0 && num8 < 2)
								{
									for (num33 = 0; num33 < num32; num33++)
									{
										int num50 = array5[num32 - num33 - 1];
										if (0 <= Class29.smethod_3(num50))
										{
											num49 = num50;
											break;
										}
									}
									if (num49 > 0 && Class29.smethod_7(characterAccountConfig_0, num49))
									{
										Thread.Sleep(300);
										Class64.smethod_11(characterAccountConfig_0);
										num8++;
										goto IL_10a6;
									}
									num8 = 2;
								}
								num49 = -1;
								for (num33 = 0; num33 < num32 && Class64.smethod_9(array5[num33]) != null; num33++)
								{
									num49 = array5[num33];
								}
								num26 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
								if (num26 == num49)
								{
									goto IL_0b39;
								}
								if (num49 > 0 && Class53.smethod_5(characterAccountConfig_0, num49) > 0)
								{
									Thread.Sleep(300);
									Class64.smethod_11(characterAccountConfig_0);
								}
								num16++;
								if (num16 <= 3)
								{
									goto IL_10a6;
								}
								gStruct = Class45.smethod_4(num26, num5);
								if (gStruct.int_0 != num26 || gStruct.int_1 != num5 || gStruct.uint_0 == null)
								{
									num16 = 0;
									goto IL_10a6;
								}
								goto IL_0c68;
							}
						}
						else
						{
							num = 1;
						}
					}
					else
					{
						num = 1;
					}
				}
			}
			else
			{
				num = 1;
			}
		}
		else
		{
			num = 1;
		}
		if (num > 0 && Class46.characterSyncSnapshot_0.int_0 == characterAccountConfig_0.int_136)
		{
			Class46.characterSyncSnapshot_0.bool_1 = false;
		}
		Class13.smethod_2(characterAccountConfig_0, bool_0: false);
		Class75.smethod_52(characterAccountConfig_0, Class1.smethod_2("<color=yellow>Kết thúc chạy điểm boss !"));
		return num;
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		string text = string.Empty;
		if (string_2 != null)
		{
			for (int i = 0; i < string_2.GetLength(0); i++)
			{
				string text2 = string.Empty;
				for (int j = 0; j < string_2.GetLength(1); j++)
				{
					if (text2 != string.Empty)
					{
						text2 += "ÿ";
					}
					text2 += string_2[i, j];
				}
				if (text != string.Empty)
				{
					text += "\r";
				}
				text += text2;
			}
		}
		Class11.smethod_34(Class56.string_9 + "\\ToadoBoss.txt", text, 1);
		bool_0 = false;
	}

	private void FormChayBoss_Load(object sender, EventArgs e)
	{
		timer_0.Enabled = false;
		if (0 <= int_0 && 0 <= int_1)
		{
			int num = int_0 - base.Width;
			int num2 = int_1 + int_3 - base.Height;
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
		checkBoxTuLuuRuong.Checked = int_4 > 0;
		checkBoxTrolaiDiemcu.Checked = int_5 > 0;
		if (string_2 != null)
		{
			for (int i = 0; i < string_2.GetLength(0); i++)
			{
				method_0(listView1, string_2[i, 0], string_2[i, 1], string_2[i, 4]);
			}
		}
		string text = string.Empty;
		for (int j = 0; j < string_1.GetLength(0); j++)
		{
			string text2 = string_1[j, 0];
			int num3 = Class11.smethod_1(text2, ".");
			if (num3 > 0)
			{
				text2 = text2.Substring(0, num3);
			}
			if (text == string.Empty)
			{
				text = text2;
			}
			else if (!smethod_3(text, text2))
			{
				text = text + "|" + text2;
			}
			if (j == 70)
			{
				Thread.Sleep(10);
			}
		}
		string[] array = text.Split('|');
		for (int k = 0; k < array.Length; k++)
		{
			comboBoxTenTat.Items.Add(array[k]);
		}
		comboBoxTenTat.Text = array[0];
		Thread.Sleep(150);
		if (bool_3)
		{
			string string_ = "Chưa được cập nhật Phượng Tường và Sơn Bảo động, bấm nút sau để cập nhật lại phần này:||1. Bấm nút <Lưu vào tệp> để đề phòng cần xem lại tọa độ.||2. Bấm nút <Xóa tọa độ về mặc định> để hiển thị phần Phượng Tường.||";
			FormTip.smethod_0("DIEM BOSS", string_, 600000, 300, 180, bool_8: false, base.Left, base.Top);
		}
		timer_0.Interval = 100;
		timer_0.Enabled = true;
		bool_2 = true;
		base.TopMost = true;
	}

	private static bool smethod_3(string string_3, string string_4)
	{
		return Class11.smethod_1(string_3, string_4) >= 0;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void method_0(ListView listView_0, string string_3, string string_4, string string_5)
	{
		try
		{
			string[] array = new string[3] { string_3, string_4, string_5 };
			ListViewItem listViewItem = new ListViewItem(array[0]);
			if (array.Length > 1)
			{
				for (int i = 1; i < array.Length; i++)
				{
					ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
					listViewItem.SubItems.Add(item);
				}
			}
			listView_0.Items.Add(listViewItem);
		}
		catch
		{
		}
	}

	private int method_1(ListView listView_0)
	{
		if (listView_0.Items != null)
		{
			for (int i = 0; i < listView_0.Items.Count; i++)
			{
				if (listView_0.Items[i].Selected)
				{
					return i;
				}
			}
		}
		return -1;
	}

	private void checkBoxTuLuuRuong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int_4 = Convert.ToByte(checkBoxTuLuuRuong.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagLuuRuongChayBoss", int_4, "", 0);
		}
	}

	private void buttonApdungAll_Click(object sender, EventArgs e)
	{
		bool_0 = false;
		Close();
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || !bool_2)
		{
			return;
		}
		int num = method_1(listView1);
		if (num >= 0)
		{
			string text = (string_0 = listView1.Items[num].SubItems[0].Text);
			int num2 = Class11.smethod_1(text, ".");
			if (num2 > 0)
			{
				text = text.Substring(0, num2);
			}
			comboBoxTenTat.Text = text;
			textBoxToado.Text = listView1.Items[num].SubItems[1].Text;
		}
	}

	private void buttonSua_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_2)
		{
			return;
		}
		string text = textBoxToado.Text.Trim().Replace(" ", "").Replace("/", ".")
			.Replace(",", ".");
		if (Class11.smethod_1(text, ".") <= 0)
		{
			return;
		}
		int num = method_1(listView1);
		if (num >= 0 && string_2.GetLength(0) > num)
		{
			string text2 = listView1.Items[num].SubItems[0].Text;
			string oldValue = listView1.Items[num].SubItems[1].Text;
			listView1.Items[num].SubItems[0].Text = text2.Replace(oldValue, text);
			listView1.Items[num].SubItems[1].Text = text;
			int num2 = Class11.smethod_1(string_2[num, 0], " ");
			if (num2 > 0)
			{
				string_2[num, 0] = string_2[num, 0].Substring(0, num2) + " " + text;
			}
			string_2[num, 1] = text;
			bool_1 = true;
		}
	}

	private void buttonMacdinh_Click(object sender, EventArgs e)
	{
		string text = "Huong dan: Bấm <Lưu vào tệp> đề phòng muốn xem lại tọa độ cũ." + Class56.string_7 + Class56.string_7 + "Bạn chắc chắn muốn xóa dữ liệu tọa độ boss hiện tại để đưa về mặc định của auto ?";
		if (MessageBox.Show(text, Form1.string_49, MessageBoxButtons.YesNo) != DialogResult.No)
		{
			string_2 = string_1;
			listView1.Items.Clear();
			for (int i = 0; i < string_2.GetLength(0); i++)
			{
				method_0(listView1, string_2[i, 0], string_2[i, 1], string_2[i, 4]);
			}
			bool_1 = true;
			bool_3 = false;
		}
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		int num = method_1(listView1);
		if (num < 0 || string_2.GetLength(0) <= num)
		{
			return;
		}
		listView1.Items.RemoveAt(num);
		int num2 = num;
		int count = listView1.Items.Count;
		if (count > 0)
		{
			if (count <= num)
			{
				num = count - 1;
			}
			listView1.TopItem = listView1.Items[num];
			listView1.Items[num].Focused = true;
			listView1.Items[num].Selected = true;
		}
		if (string_2 == null)
		{
			return;
		}
		string[,] array = new string[string_2.GetLength(0) - 1, string_2.GetLength(1)];
		int num3 = 0;
		for (int i = 0; i < string_2.GetLength(0); i++)
		{
			if (i != num2)
			{
				for (int j = 0; j < string_2.GetLength(1); j++)
				{
					array[num3, j] = string_2[i, j];
				}
				num3++;
			}
		}
		string_2 = array;
		bool_1 = true;
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (FormChayBoss.string_2 == null)
		{
			FormChayBoss.string_2 = string_1;
			listView1.Items.Clear();
			for (int i = 0; i < FormChayBoss.string_2.GetLength(0); i++)
			{
				method_0(listView1, FormChayBoss.string_2[i, 0], FormChayBoss.string_2[i, 1], FormChayBoss.string_2[i, 4]);
			}
			bool_1 = true;
			return;
		}
		int num = -1;
		int num2 = 1;
		string text = "...";
		string text2 = "0.0";
		string text3 = comboBoxTenTat.Text;
		if (!(text3 == "..."))
		{
			text2 = textBoxToado.Text.Replace(",", ".").Replace("/", ".");
			if (Class11.smethod_1(text2, ".") <= 0)
			{
				string string_ = "Tọa độ sai qui cách, phải là dạng XXX.YYY (ví dụ: 123.456)";
				FormTip.smethod_0(Form1.string_49, string_, 600000, 250, 80);
				return;
			}
			for (int j = 0; j < FormChayBoss.string_2.GetLength(0); j++)
			{
				if (Class11.smethod_1(FormChayBoss.string_2[j, 0], text3) == 0)
				{
					num2++;
				}
			}
			for (int k = 0; k < string_1.GetLength(0); k++)
			{
				if (Class11.smethod_1(string_1[k, 0], text3) == 0)
				{
					num = k;
					break;
				}
			}
			if (num < 0)
			{
				string string_2 = "Tên tắt Không có trong danh sách, bạn bấm nút Xóa đưa về tọa độ mặc định để lấy tên tắt.|";
				FormTip.smethod_0(Form1.string_49, string_2, 600000, 280, 100);
				return;
			}
			text = text3 + "." + num2 + " " + text2;
		}
		string[,] array = new string[FormChayBoss.string_2.GetLength(0) + 1, FormChayBoss.string_2.GetLength(1)];
		for (int l = 0; l < FormChayBoss.string_2.GetLength(0); l++)
		{
			for (int m = 0; m < FormChayBoss.string_2.GetLength(1); m++)
			{
				array[l, m] = FormChayBoss.string_2[l, m];
			}
		}
		int length = FormChayBoss.string_2.GetLength(0);
		string text4 = string.Empty;
		array[length, 0] = text;
		array[length, 1] = text2;
		array[length, 2] = "0";
		array[length, 3] = "0|0|0|0";
		array[length, 4] = text4;
		if (text != "...")
		{
			for (int n = 2; n < FormChayBoss.string_2.GetLength(1); n++)
			{
				array[length, n] = string_1[num, n];
			}
			text4 = string_1[num, 4];
		}
		FormChayBoss.string_2 = array;
		method_0(listView1, text, text2, text4);
		length = listView1.Items.Count;
		listView1.TopItem = listView1.Items[length - 1];
		listView1.Items[length - 1].Focused = true;
		listView1.Items[length - 1].Selected = true;
		bool_1 = true;
	}

	private void buttonLen_Click(object sender, EventArgs e)
	{
		int num = method_1(listView1);
		if (num <= 0 || string_2 == null)
		{
			return;
		}
		int count = listView1.Items[num].SubItems.Count;
		for (int i = 0; i < count; i++)
		{
			string text = listView1.Items[num].SubItems[i].Text;
			listView1.Items[num].SubItems[i].Text = listView1.Items[num - 1].SubItems[i].Text;
			listView1.Items[num - 1].SubItems[i].Text = text;
		}
		if (num == listView1.TopItem.Index)
		{
			listView1.TopItem = listView1.Items[num - 1];
		}
		listView1.Items[num - 1].Focused = true;
		listView1.Items[num - 1].Selected = true;
		if (string_2.GetLength(0) > 1)
		{
			for (int j = 0; j < string_2.GetLength(1); j++)
			{
				string text2 = string_2[num, j];
				string_2[num, j] = string_2[num - 1, j];
				string_2[num - 1, j] = text2;
			}
		}
		bool_1 = true;
	}

	private void buttonXuong_Click(object sender, EventArgs e)
	{
		int num = method_1(listView1);
		if (num <= 0 || string_2.GetLength(0) - 1 <= num || string_2 == null)
		{
			return;
		}
		int count = listView1.Items[num].SubItems.Count;
		for (int i = 0; i < count; i++)
		{
			string text = listView1.Items[num].SubItems[i].Text;
			listView1.Items[num].SubItems[i].Text = listView1.Items[num + 1].SubItems[i].Text;
			listView1.Items[num + 1].SubItems[i].Text = text;
		}
		if (num - listView1.TopItem.Index > 12)
		{
			listView1.TopItem = listView1.Items[num + 1];
		}
		listView1.Items[num + 1].Focused = true;
		listView1.Items[num + 1].Selected = true;
		if (string_2.GetLength(0) > 1)
		{
			for (int j = 0; j < string_2.GetLength(1); j++)
			{
				string text2 = string_2[num, j];
				string_2[num, j] = string_2[num + 1, j];
				string_2[num + 1, j] = text2;
			}
		}
		bool_1 = true;
	}

	private void checkBoxTrolaiDiemcu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int_5 = Convert.ToByte(checkBoxTrolaiDiemcu.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagDiemcuChayBoss", int_5, "", 0);
		}
	}

	private void buttonLuu_Click(object sender, EventArgs e)
	{
		string text = Class56.string_9 + "\\ToadoBossLuu.txt";
		if (Class11.smethod_17(text))
		{
			string text2 = "Lệnh lưu vào tệp sẽ ghi đè tọa độ boss hiện có vào tệp ToadoBossLuu.txt cũ, nên những tọa độ cũ trong tệp sẽ mất hết và thay thế vào đó là tọa độ boss hiện tại." + Class56.string_7 + Class56.string_7 + "Bạn có chắc chắn muốn lưu vào tệp không ?";
			if (MessageBox.Show(text2, "TOA_DO_BOSS", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}
		}
		string text3 = string.Empty;
		if (string_2 != null)
		{
			for (int i = 0; i < string_2.GetLength(0); i++)
			{
				if (string_2.GetLength(1) >= 2)
				{
					object obj = text3;
					text3 = string.Concat(obj, i, ". ", string_2[i, 0]);
					if (string_2[i, 1] != null && string_2[i, 1] != string.Empty && string_2[i, 1] != "0.0")
					{
						text3 = text3 + "\t : " + string_2[i, 1];
					}
					if (string_2[i, 4] != null && string_2[i, 4] != string.Empty)
					{
						text3 = text3 + "\t : " + string_2[i, 4];
					}
					text3 += Class56.string_7;
				}
			}
		}
		Class11.smethod_34(text, text3, 1);
		MessageBox.Show("Đã lưu tọa độ boss vào tệp: " + Class56.string_7 + text, "TOA DO BOSS", MessageBoxButtons.OK);
	}

	private void buttonXem_Click(object sender, EventArgs e)
	{
		string string_ = Class11.smethod_33(Class56.string_9 + "\\ToadoBossLuu.txt", 0, 0, 1);
		FormTip.smethod_0("TOA DO BOSS (LUU)", string_, 900000, 430, 600, bool_8: true);
	}

	private void buttonThumucAuto_Click(object sender, EventArgs e)
	{
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_0(Class56.char_0));
		string string_ = Class56.string_9;
		Class24.smethod_40(environmentVariable + "\\explorer.exe", string_, string_, 0);
	}
}
