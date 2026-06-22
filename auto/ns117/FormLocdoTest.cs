using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns138;
using ns23;
using ns3;
using ns35;
using ns44;
using ns53;
using ns61;
using ns63;
using ns71;
using ns81;
using ns83;
using ns85;
using ns88;

namespace ns117;

public class FormLocdoTest : Form
{
	private TextBox textBoxSoLuongGiu;

	private Label labelSoLuongGiu;

	public static bool bool_0 = false;

	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonClose;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private TextBox textBoxMin;

	private Button buttonSua;

	private TextBox textBoxName;

	private CheckBox checkBoxThoahet;

	private CheckBox checkBox1;

	private TextBox textBox1;

	private TextBox textBox2;

	private CheckBox checkBox2;

	private TextBox textBox3;

	private CheckBox checkBox3;

	private TextBox textBox4;

	private CheckBox checkBox4;

	private TextBox textBox5;

	private CheckBox checkBox5;

	private TextBox textBox6;

	private CheckBox checkBox6;

	private Button buttonApdungAll;

	private CheckBox checkBoxBanVpHoagkimTest;

	private ColumnHeader columnHeader_3;

	private TextBox textBoxDong;

	private Label label1;

	private ListView listView2;

	private ColumnHeader columnHeader_4;

	private ColumnHeader columnHeader_5;

	private CheckBox checkBoxCoNopVP;

	private ComboBox comboBoxNopVP;

	private TextBox textBoxSoluongNop;

	private Button buttonXoa;

	private Button buttonThem;

	private ColumnHeader columnHeader_6;

	private LinkLabel linkLabelLuuy;

	private Button buttonBoCheck;

	private CheckBox checkBoxLocTrangbi;

	private ComboBox comboBoxLocTrangbi;

	public static int int_0 = 0;

	public static int int_1 = 0;

	public static string string_0 = Class11.smethod_15(Class66.smethod_7("TenVatPhamNhanTrangbiTest", 0));

	public static int int_2 = Class66.smethod_4("NhapSoluongTest", 0, "10");

	public static int int_3 = Class66.smethod_4("fCoNhapSLTest", 0, "0");

	public static int int_4 = Class66.smethod_4("DayLaNPC", 0, "0");

	public static bool bool_1 = Class66.smethod_4("flagLocThoahetDieukien", 0, "0") > 0;

	public static bool bool_2 = Class66.smethod_4("flagBanTrangbiHoangKimTest", 0, "0") > 0;

	public static int[] int_5 = new int[2]
	{
		Class66.smethod_4("flagChiLocLayTrangbi_0", 0, "0"),
		Class66.smethod_4("flagChiLocLayTrangbi_1", 0, "0")
	};

	public static GStruct63[] gstruct63_0 = null;

	public static int int_6 = Class66.smethod_4("fLocNopVP", 0, "0");

	public static int[] int_7 = new int[2]
	{
		Class66.smethod_4("TrangbiDong1_0", 0, "0"),
		Class66.smethod_4("TrangbiDong1_1", 0, "0")
	};

	public static int[] int_8 = new int[2]
	{
		Class66.smethod_4("TrangbiDong2_0", 0, "0"),
		Class66.smethod_4("TrangbiDong2_1", 0, "0")
	};

	public static int[] int_9 = new int[2]
	{
		Class66.smethod_4("TrangbiDong3_0", 0, "0"),
		Class66.smethod_4("TrangbiDong3_1", 0, "0")
	};

	public static int[] int_10 = new int[2]
	{
		Class66.smethod_4("TrangbiDong4_0", 0, "0"),
		Class66.smethod_4("TrangbiDong4_1", 0, "0")
	};

	public static int[] int_11 = new int[2]
	{
		Class66.smethod_4("TrangbiDong5_0", 0, "0"),
		Class66.smethod_4("TrangbiDong5_1", 0, "0")
	};

	public static int[] int_12 = new int[2]
	{
		Class66.smethod_4("TrangbiDong6_0", 0, "0"),
		Class66.smethod_4("TrangbiDong6_1", 0, "0")
	};

	public static string string_1 = "ClickMenuTest";

	public static int[] int_13 = Class11.smethod_70(Class66.smethod_7(string_1, 0, "9,1"));

	public int int_14;

	public int int_15;

	public int int_16;

	public int int_17;

	public static bool bool_3 = false;

	private Color color_0 = Color.DarkGreen;

	private static long long_0 = 0L;

	private static string[] string_2 = new string[10] { "Vũ khí cận chiến", "Vũ khí tầm xa", "Lấy áo", "Lấy nhẫn", "Lấy dây chuyền", "Lấy giầy", "Lấy đai lưng", "Lấy nón", "Lấy bao tay", "Lấy ngọc bội" };

	private static bool bool_4 = false;

	private IContainer icontainer_1;

	private static string[] string_3 = null;

	public static int int_18 = Class66.smethod_4("SoLuongTrangbiGiu", 0, "0");

	public FormLocdoTest()
	{
		bool_3 = true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns117.FormLocdoTest));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_1);
		this.buttonClose = new System.Windows.Forms.Button();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		this.textBoxMin = new System.Windows.Forms.TextBox();
		this.buttonSua = new System.Windows.Forms.Button();
		this.textBoxName = new System.Windows.Forms.TextBox();
		this.checkBoxThoahet = new System.Windows.Forms.CheckBox();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.checkBox2 = new System.Windows.Forms.CheckBox();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.checkBox5 = new System.Windows.Forms.CheckBox();
		this.textBox6 = new System.Windows.Forms.TextBox();
		this.checkBox6 = new System.Windows.Forms.CheckBox();
		this.buttonApdungAll = new System.Windows.Forms.Button();
		this.checkBoxBanVpHoagkimTest = new System.Windows.Forms.CheckBox();
		this.textBoxDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.listView2 = new System.Windows.Forms.ListView();
		this.columnHeader_4 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_5 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_6 = new System.Windows.Forms.ColumnHeader();
		this.checkBoxCoNopVP = new System.Windows.Forms.CheckBox();
		this.comboBoxNopVP = new System.Windows.Forms.ComboBox();
		this.textBoxSoluongNop = new System.Windows.Forms.TextBox();
		this.buttonXoa = new System.Windows.Forms.Button();
		this.buttonThem = new System.Windows.Forms.Button();
		this.linkLabelLuuy = new System.Windows.Forms.LinkLabel();
		this.buttonBoCheck = new System.Windows.Forms.Button();
		this.checkBoxLocTrangbi = new System.Windows.Forms.CheckBox();
		this.comboBoxLocTrangbi = new System.Windows.Forms.ComboBox();
		this.textBoxSoLuongGiu = new System.Windows.Forms.TextBox();
		this.labelSoLuongGiu = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonClose.Location = new System.Drawing.Point(272, 536);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(101, 26);
		this.buttonClose.TabIndex = 8;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.listView1.CheckBoxes = true;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2, this.columnHeader_3 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(12, 272);
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(361, 197);
		this.listView1.TabIndex = 34;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(listView1_ItemCheck);
		this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		this.columnHeader_0.Text = "No";
		this.columnHeader_0.Width = 45;
		this.columnHeader_1.Text = "Thuộc tính";
		this.columnHeader_1.Width = 220;
		this.columnHeader_2.Text = "Min";
		this.columnHeader_2.Width = 33;
		this.columnHeader_3.Text = "Dòng";
		this.columnHeader_3.Width = 40;
		this.textBoxMin.Location = new System.Drawing.Point(267, 474);
		this.textBoxMin.Name = "textBoxMin";
		this.textBoxMin.Size = new System.Drawing.Size(33, 20);
		this.textBoxMin.TabIndex = 38;
		this.buttonSua.Location = new System.Drawing.Point(328, 474);
		this.buttonSua.Name = "buttonSua";
		this.buttonSua.Size = new System.Drawing.Size(45, 21);
		this.buttonSua.TabIndex = 39;
		this.buttonSua.Text = "Sửa";
		this.buttonSua.UseVisualStyleBackColor = true;
		this.buttonSua.Click += new System.EventHandler(buttonSua_Click);
		this.textBoxName.ForeColor = System.Drawing.Color.Blue;
		this.textBoxName.Location = new System.Drawing.Point(12, 474);
		this.textBoxName.Name = "textBoxName";
		this.textBoxName.ReadOnly = true;
		this.textBoxName.Size = new System.Drawing.Size(249, 20);
		this.textBoxName.TabIndex = 40;
		this.checkBoxThoahet.AutoSize = true;
		this.checkBoxThoahet.ForeColor = System.Drawing.Color.Purple;
		this.checkBoxThoahet.Location = new System.Drawing.Point(12, 251);
		this.checkBoxThoahet.Name = "checkBoxThoahet";
		this.checkBoxThoahet.Size = new System.Drawing.Size(283, 17);
		this.checkBoxThoahet.TabIndex = 43;
		this.checkBoxThoahet.Text = "Lọc đúng hết điều kiện thuộc tính dưới đây thì mới giữ";
		this.checkBoxThoahet.UseVisualStyleBackColor = true;
		this.checkBoxThoahet.CheckedChanged += new System.EventHandler(checkBoxThoahet_CheckedChanged);
		this.checkBox1.AutoSize = true;
		this.checkBox1.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBox1.Location = new System.Drawing.Point(12, 143);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(61, 17);
		this.checkBox1.TabIndex = 44;
		this.checkBox1.Text = "Dòng 1";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.textBox1.ForeColor = System.Drawing.Color.Black;
		this.textBox1.Location = new System.Drawing.Point(88, 143);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(33, 20);
		this.textBox1.TabIndex = 45;
		this.textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
		this.textBox2.ForeColor = System.Drawing.Color.Black;
		this.textBox2.Location = new System.Drawing.Point(88, 166);
		this.textBox2.Name = "textBox2";
		this.textBox2.Size = new System.Drawing.Size(33, 20);
		this.textBox2.TabIndex = 47;
		this.textBox2.TextChanged += new System.EventHandler(textBox2_TextChanged);
		this.checkBox2.AutoSize = true;
		this.checkBox2.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBox2.Location = new System.Drawing.Point(12, 168);
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.Size = new System.Drawing.Size(61, 17);
		this.checkBox2.TabIndex = 46;
		this.checkBox2.Text = "Dòng 2";
		this.checkBox2.UseVisualStyleBackColor = true;
		this.checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
		this.textBox3.ForeColor = System.Drawing.Color.Black;
		this.textBox3.Location = new System.Drawing.Point(217, 143);
		this.textBox3.Name = "textBox3";
		this.textBox3.Size = new System.Drawing.Size(33, 20);
		this.textBox3.TabIndex = 51;
		this.textBox3.TextChanged += new System.EventHandler(textBox3_TextChanged);
		this.checkBox3.AutoSize = true;
		this.checkBox3.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBox3.Location = new System.Drawing.Point(150, 143);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(61, 17);
		this.checkBox3.TabIndex = 50;
		this.checkBox3.Text = "Dòng 3";
		this.checkBox3.UseVisualStyleBackColor = true;
		this.checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		this.textBox4.ForeColor = System.Drawing.Color.Black;
		this.textBox4.Location = new System.Drawing.Point(217, 166);
		this.textBox4.Name = "textBox4";
		this.textBox4.Size = new System.Drawing.Size(33, 20);
		this.textBox4.TabIndex = 49;
		this.textBox4.TextChanged += new System.EventHandler(textBox4_TextChanged);
		this.checkBox4.AutoSize = true;
		this.checkBox4.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBox4.Location = new System.Drawing.Point(150, 168);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(61, 17);
		this.checkBox4.TabIndex = 48;
		this.checkBox4.Text = "Dòng 4";
		this.checkBox4.UseVisualStyleBackColor = true;
		this.checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
		this.textBox5.ForeColor = System.Drawing.Color.Black;
		this.textBox5.Location = new System.Drawing.Point(340, 143);
		this.textBox5.Name = "textBox5";
		this.textBox5.Size = new System.Drawing.Size(33, 20);
		this.textBox5.TabIndex = 55;
		this.textBox5.TextChanged += new System.EventHandler(textBox5_TextChanged);
		this.checkBox5.AutoSize = true;
		this.checkBox5.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBox5.Location = new System.Drawing.Point(273, 143);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(61, 17);
		this.checkBox5.TabIndex = 54;
		this.checkBox5.Text = "Dòng 5";
		this.checkBox5.UseVisualStyleBackColor = true;
		this.checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
		this.textBox6.ForeColor = System.Drawing.Color.Black;
		this.textBox6.Location = new System.Drawing.Point(340, 166);
		this.textBox6.Name = "textBox6";
		this.textBox6.Size = new System.Drawing.Size(33, 20);
		this.textBox6.TabIndex = 53;
		this.textBox6.TextChanged += new System.EventHandler(textBox6_TextChanged);
		this.checkBox6.AutoSize = true;
		this.checkBox6.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBox6.Location = new System.Drawing.Point(273, 168);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(61, 17);
		this.checkBox6.TabIndex = 52;
		this.checkBox6.Text = "Dòng 6";
		this.checkBox6.UseVisualStyleBackColor = true;
		this.checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
		this.buttonApdungAll.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonApdungAll.Location = new System.Drawing.Point(124, 536);
		this.buttonApdungAll.Name = "buttonApdungAll";
		this.buttonApdungAll.Size = new System.Drawing.Size(142, 26);
		this.buttonApdungAll.TabIndex = 56;
		this.buttonApdungAll.Text = "Áp dụng cho tất cả ac";
		this.buttonApdungAll.UseVisualStyleBackColor = true;
		this.buttonApdungAll.Click += new System.EventHandler(buttonApdungAll_Click);
		this.checkBoxBanVpHoagkimTest.AutoSize = true;
		this.checkBoxBanVpHoagkimTest.ForeColor = System.Drawing.Color.Red;
		this.checkBoxBanVpHoagkimTest.Location = new System.Drawing.Point(12, 224);
		this.checkBoxBanVpHoagkimTest.Name = "checkBoxBanVpHoagkimTest";
		this.checkBoxBanVpHoagkimTest.Size = new System.Drawing.Size(215, 17);
		this.checkBoxBanVpHoagkimTest.TabIndex = 190;
		this.checkBoxBanVpHoagkimTest.Text = "Bán luôn trang bị hoàng kim (cẩn thận !)";
		this.checkBoxBanVpHoagkimTest.UseVisualStyleBackColor = true;
		this.checkBoxBanVpHoagkimTest.CheckedChanged += new System.EventHandler(checkBoxBanVpHoagkimTest_CheckedChanged);
		this.textBoxDong.Location = new System.Drawing.Point(305, 474);
		this.textBoxDong.Name = "textBoxDong";
		this.textBoxDong.Size = new System.Drawing.Size(20, 20);
		this.textBoxDong.TabIndex = 191;
		this.label1.Location = new System.Drawing.Point(12, 500);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(238, 33);
		this.label1.TabIndex = 192;
		this.label1.Text = "Giá trị của Dòng (kế bên Min): Ghi 0 nếu không xét điều kiện dòng, tức là dòng nào cũng được";
		this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.columnHeader_4, this.columnHeader_5, this.columnHeader_6 });
		this.listView2.ForeColor = System.Drawing.Color.Black;
		this.listView2.FullRowSelect = true;
		this.listView2.GridLines = true;
		this.listView2.HideSelection = false;
		this.listView2.Location = new System.Drawing.Point(12, 29);
		this.listView2.MultiSelect = false;
		this.listView2.Name = "listView2";
		this.listView2.Size = new System.Drawing.Size(361, 71);
		this.listView2.TabIndex = 194;
		this.listView2.UseCompatibleStateImageBehavior = false;
		this.listView2.View = System.Windows.Forms.View.Details;
		this.columnHeader_4.Text = "No";
		this.columnHeader_4.Width = 45;
		this.columnHeader_5.Text = "Tên vật phẩm cần nộp";
		this.columnHeader_5.Width = 200;
		this.columnHeader_6.Text = "Số lượng mỗi lần nộp";
		this.columnHeader_6.Width = 90;
		this.checkBoxCoNopVP.AutoSize = true;
		this.checkBoxCoNopVP.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxCoNopVP.Location = new System.Drawing.Point(12, 4);
		this.checkBoxCoNopVP.Name = "checkBoxCoNopVP";
		this.checkBoxCoNopVP.Size = new System.Drawing.Size(168, 17);
		this.checkBoxCoNopVP.TabIndex = 195;
		this.checkBoxCoNopVP.Text = "Có nộp vật phẩm trước khi lọc";
		this.checkBoxCoNopVP.UseVisualStyleBackColor = true;
		this.checkBoxCoNopVP.CheckedChanged += new System.EventHandler(checkBoxCoNopVP_CheckedChanged);
		this.comboBoxNopVP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxNopVP.FormattingEnabled = true;
		this.comboBoxNopVP.Location = new System.Drawing.Point(124, 105);
		this.comboBoxNopVP.Name = "comboBoxNopVP";
		this.comboBoxNopVP.Size = new System.Drawing.Size(203, 21);
		this.comboBoxNopVP.TabIndex = 203;
		this.comboBoxNopVP.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxNopVP_MouseDown);
		this.textBoxSoluongNop.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluongNop.Location = new System.Drawing.Point(331, 106);
		this.textBoxSoluongNop.Name = "textBoxSoluongNop";
		this.textBoxSoluongNop.Size = new System.Drawing.Size(42, 20);
		this.textBoxSoluongNop.TabIndex = 204;
		this.textBoxSoluongNop.Text = "1";
		this.buttonXoa.Location = new System.Drawing.Point(12, 105);
		this.buttonXoa.Name = "buttonXoa";
		this.buttonXoa.Size = new System.Drawing.Size(45, 21);
		this.buttonXoa.TabIndex = 205;
		this.buttonXoa.Text = "Xóa";
		this.buttonXoa.UseVisualStyleBackColor = true;
		this.buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		this.buttonThem.Location = new System.Drawing.Point(63, 105);
		this.buttonThem.Name = "buttonThem";
		this.buttonThem.Size = new System.Drawing.Size(58, 21);
		this.buttonThem.TabIndex = 206;
		this.buttonThem.Text = "Thêm";
		this.buttonThem.UseVisualStyleBackColor = true;
		this.buttonThem.Click += new System.EventHandler(buttonThem_Click);
		this.linkLabelLuuy.AutoSize = true;
		this.linkLabelLuuy.Location = new System.Drawing.Point(183, 7);
		this.linkLabelLuuy.Name = "linkLabelLuuy";
		this.linkLabelLuuy.Size = new System.Drawing.Size(190, 13);
		this.linkLabelLuuy.TabIndex = 207;
		this.linkLabelLuuy.TabStop = true;
		this.linkLabelLuuy.Text = "==> click ở đây để xem ngay lưu ý <==";
		this.linkLabelLuuy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelLuuy_LinkClicked);
		this.buttonBoCheck.Location = new System.Drawing.Point(12, 536);
		this.buttonBoCheck.Name = "buttonBoCheck";
		this.buttonBoCheck.Size = new System.Drawing.Size(102, 26);
		this.buttonBoCheck.TabIndex = 208;
		this.buttonBoCheck.Text = "Bỏ check tất cả";
		this.buttonBoCheck.UseVisualStyleBackColor = true;
		this.buttonBoCheck.Click += new System.EventHandler(buttonBoCheck_Click);
		this.checkBoxLocTrangbi.AutoSize = true;
		this.checkBoxLocTrangbi.ForeColor = System.Drawing.Color.Red;
		this.checkBoxLocTrangbi.Location = new System.Drawing.Point(12, 200);
		this.checkBoxLocTrangbi.Name = "checkBoxLocTrangbi";
		this.checkBoxLocTrangbi.Size = new System.Drawing.Size(230, 17);
		this.checkBoxLocTrangbi.TabIndex = 209;
		this.checkBoxLocTrangbi.Text = "Chỉ lọc lấy trang bị ở bên, còn lại bán tất cả";
		this.checkBoxLocTrangbi.UseVisualStyleBackColor = true;
		this.checkBoxLocTrangbi.CheckedChanged += new System.EventHandler(checkBoxLocTrangbi_CheckedChanged);
		this.comboBoxLocTrangbi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxLocTrangbi.FormattingEnabled = true;
		this.comboBoxLocTrangbi.Location = new System.Drawing.Point(248, 198);
		this.comboBoxLocTrangbi.Name = "comboBoxLocTrangbi";
		this.comboBoxLocTrangbi.Size = new System.Drawing.Size(125, 21);
		this.comboBoxLocTrangbi.TabIndex = 210;
		this.comboBoxLocTrangbi.SelectedIndexChanged += new System.EventHandler(comboBoxLocTrangbi_SelectedIndexChanged);
		this.textBoxSoLuongGiu.Location = new System.Drawing.Point(294, 513);
		this.textBoxSoLuongGiu.Name = "textBoxSoLuongGiu";
		this.textBoxSoLuongGiu.Size = new System.Drawing.Size(50, 20);
		this.textBoxSoLuongGiu.TabIndex = 212;
		this.textBoxSoLuongGiu.Text = "0";
		this.textBoxSoLuongGiu.TextChanged += new System.EventHandler(textBoxSoLuongGiu_TextChanged);
		this.labelSoLuongGiu.AutoSize = true;
		this.labelSoLuongGiu.ForeColor = System.Drawing.Color.Blue;
		this.labelSoLuongGiu.Location = new System.Drawing.Point(266, 497);
		this.labelSoLuongGiu.Name = "labelSoLuongGiu";
		this.labelSoLuongGiu.Size = new System.Drawing.Size(107, 13);
		this.labelSoLuongGiu.TabIndex = 211;
		this.labelSoLuongGiu.Text = "Số lượng trang bị giữ:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(378, 566);
		base.Controls.Add(this.comboBoxLocTrangbi);
		base.Controls.Add(this.checkBoxLocTrangbi);
		base.Controls.Add(this.buttonBoCheck);
		base.Controls.Add(this.linkLabelLuuy);
		base.Controls.Add(this.buttonThem);
		base.Controls.Add(this.buttonXoa);
		base.Controls.Add(this.textBoxSoluongNop);
		base.Controls.Add(this.comboBoxNopVP);
		base.Controls.Add(this.checkBoxCoNopVP);
		base.Controls.Add(this.listView2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.textBoxDong);
		base.Controls.Add(this.checkBoxBanVpHoagkimTest);
		base.Controls.Add(this.buttonApdungAll);
		base.Controls.Add(this.textBox5);
		base.Controls.Add(this.checkBox5);
		base.Controls.Add(this.textBox6);
		base.Controls.Add(this.checkBox6);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.checkBox3);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.checkBox4);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.checkBox2);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.checkBox1);
		base.Controls.Add(this.checkBoxThoahet);
		base.Controls.Add(this.listView1);
		base.Controls.Add(this.textBoxName);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.textBoxMin);
		base.Controls.Add(this.buttonSua);
		base.Controls.Add(this.labelSoLuongGiu);
		base.Controls.Add(this.textBoxSoLuongGiu);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormLocdoTest";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "LOC TRANG BI TEST";
		base.Load += new System.EventHandler(FormLocdoTest_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public static GStruct63[] smethod_0()
	{
		string text = Class11.smethod_15(Class11.smethod_33(Class56.string_9 + "\\LocNop.txt", 0, 0, 1));
		if (text != null && !(text == string.Empty))
		{
			string[] array = text.Split('|');
			GStruct63[] array2 = new GStruct63[array.Length];
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null && !(array[i] == string.Empty))
				{
					string[] array3 = array[i].Split(';');
					if (array3.Length == 2)
					{
						array2[num].string_0 = array3[0];
						array2[num].int_0 = Class11.smethod_11(array3[1]);
						num++;
					}
				}
			}
			if (num == 0)
			{
				return null;
			}
			if (num < array2.Length)
			{
				Array.Resize(ref array2, num);
			}
			return array2;
		}
		return null;
	}

	public static void smethod_1(GStruct63[] gstruct63_1)
	{
		string text = string.Empty;
		if (gstruct63_1 != null)
		{
			for (int i = 0; i < gstruct63_1.Length; i++)
			{
				if (text != string.Empty)
				{
					text += "|";
				}
				object obj = text;
				text = string.Concat(obj, gstruct63_1[i].string_0, ";", gstruct63_1[i].int_0);
			}
			text = Class11.smethod_16(text);
		}
		Class11.smethod_34(Class56.string_9 + "\\LocNop.txt", text, 1);
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		smethod_1(gstruct63_0);
		int_14 = 0;
		int_15 = 0;
		bool_3 = false;
	}

	private void FormLocdoTest_Load(object sender, EventArgs e)
	{
		timer_0.Enabled = false;
		textBoxSoLuongGiu.Text = int_18.ToString();
		if (int_14 >= 0 && int_15 >= 0)
		{
			int num = int_14 - base.Width;
			int num2 = int_15 + int_17 - base.Height;
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
		base.TopMost = true;
		gstruct63_0 = smethod_0();
		if (gstruct63_0 != null)
		{
			for (int i = 0; i < gstruct63_0.Length; i++)
			{
				method_0(gstruct63_0[i]);
			}
		}
		checkBoxCoNopVP.Checked = int_6 > 0;
		checkBox1.Checked = int_7[0] > 0;
		textBox1.Text = int_7[1].ToString();
		checkBox2.Checked = int_8[0] > 0;
		textBox2.Text = int_8[1].ToString();
		checkBox3.Checked = int_9[0] > 0;
		textBox3.Text = int_9[1].ToString();
		checkBox4.Checked = int_10[0] > 0;
		textBox4.Text = int_10[1].ToString();
		checkBox5.Checked = int_11[0] > 0;
		textBox5.Text = int_11[1].ToString();
		checkBox6.Checked = int_12[0] > 0;
		textBox6.Text = int_12[1].ToString();
		checkBoxBanVpHoagkimTest.Checked = bool_2;
		checkBoxThoahet.Checked = bool_1;
		checkBoxLocTrangbi.Checked = int_5[0] > 0;
		for (int j = 0; j < string_2.Length; j++)
		{
			comboBoxLocTrangbi.Items.Add(string_2[j]);
		}
		comboBoxLocTrangbi.Text = string_2[int_5[1]];
		int num3 = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (0 > num3)
		{
			ItemAttributeFilterRule itemAttributeFilterRule_ = new ItemAttributeFilterRule
			{
				string_0 = "Chưa chọn ac, bấm Lọc sau khi chọn 1 ac nhé."
			};
			method_1(itemAttributeFilterRule_);
			base.Text = "Loc do * Chua chon ac nao";
		}
		else
		{
			CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[num3];
			if (characterAccountConfig.itemAttributeFilterRule_0 != null)
			{
				for (int k = 0; k < characterAccountConfig.itemAttributeFilterRule_0.Length; k++)
				{
					method_1(characterAccountConfig.itemAttributeFilterRule_0[k]);
				}
				for (int l = 0; l < characterAccountConfig.itemAttributeFilterRule_0.Length; l++)
				{
					if (l < listView1.Items.Count && characterAccountConfig.itemAttributeFilterRule_0[l].int_0 > 0)
					{
						listView1.Items[l].Checked = true;
						listView1.Items[l].ForeColor = color_0;
					}
				}
			}
		}
		timer_0.Interval = 300;
		timer_0.Enabled = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_3)
		{
			Close();
		}
		else if (long_0 > 0L && Class11.smethod_28(long_0) > 300L)
		{
			buttonApdungAll.Enabled = true;
			long_0 = 0L;
		}
	}

	private void method_0(GStruct63 gstruct63_1)
	{
		if (gstruct63_1.string_0 == null || gstruct63_1.string_0 == string.Empty)
		{
			return;
		}
		int num = 0;
		try
		{
			if (listView2.Items != null)
			{
				num = listView2.Items.Count;
			}
			string[] array = new string[3]
			{
				num.ToString(),
				Class1.smethod_1(gstruct63_1.string_0, 1),
				gstruct63_1.int_0.ToString()
			};
			ListViewItem listViewItem = new ListViewItem(array[0]);
			if (array.Length > 1)
			{
				for (int i = 1; i < array.Length; i++)
				{
					ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
					listViewItem.SubItems.Add(item);
				}
			}
			listView2.Items.Add(listViewItem);
		}
		catch
		{
		}
	}

	private void method_1(ItemAttributeFilterRule itemAttributeFilterRule_0)
	{
		int num = 0;
		try
		{
			if (listView1.Items != null)
			{
				num = listView1.Items.Count;
			}
			string[] array = new string[4]
			{
				num.ToString(),
				itemAttributeFilterRule_0.string_0,
				itemAttributeFilterRule_0.int_2.ToString(),
				itemAttributeFilterRule_0.int_3.ToString()
			};
			ListViewItem listViewItem = new ListViewItem(array[0]);
			if (array.Length > 1)
			{
				for (int i = 1; i < array.Length; i++)
				{
					ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
					listViewItem.SubItems.Add(item);
				}
			}
			listView1.Items.Add(listViewItem);
		}
		catch
		{
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView1.Items == null || listView1.Items.Count == 0)
		{
			return;
		}
		int num = 0;
		while (true)
		{
			if (num < listView1.Items.Count)
			{
				if (listView1.Items[num].Selected)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		textBoxName.Text = num + ". " + listView1.Items[num].SubItems[1].Text;
		textBoxMin.Text = listView1.Items[num].SubItems[2].Text;
		textBoxDong.Text = listView1.Items[num].SubItems[3].Text;
	}

	private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num >= 0)
		{
			int num2 = Convert.ToByte(e.NewValue);
			Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0[e.Index].int_0 = num2;
			if (num2 <= 0)
			{
				listView1.Items[e.Index].ForeColor = Color.Black;
			}
			else
			{
				listView1.Items[e.Index].ForeColor = color_0;
			}
		}
	}

	private void buttonSua_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			return;
		}
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0[i].int_2 = Class11.smethod_11(textBoxMin.Text);
				Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0[i].int_3 = Class11.smethod_11(textBoxDong.Text);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
				listView1.Items[i].SubItems[2].Text = Class11.smethod_11(textBoxMin.Text).ToString();
				listView1.Items[i].SubItems[3].Text = Class11.smethod_11(textBoxDong.Text).ToString();
				break;
			}
		}
	}

	private void buttonApdungAll_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (Form1.characterAccountConfig_1 == null || num < 0)
		{
			return;
		}
		for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
		{
			if (num != i)
			{
				if (Form1.characterAccountConfig_1[i].itemAttributeFilterRule_0 == null)
				{
					Form1.characterAccountConfig_1[i].itemAttributeFilterRule_0 = Class56.smethod_1();
				}
				for (int j = 0; j < Form1.characterAccountConfig_1[i].itemAttributeFilterRule_0.Length; j++)
				{
					Form1.characterAccountConfig_1[i].itemAttributeFilterRule_0[j].int_0 = Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0[j].int_0;
					Form1.characterAccountConfig_1[i].itemAttributeFilterRule_0[j].int_2 = Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0[j].int_2;
					Form1.characterAccountConfig_1[i].itemAttributeFilterRule_0[j].int_3 = Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0[j].int_3;
					Class56.smethod_13(Form1.characterAccountConfig_1[i]);
				}
			}
		}
		textBoxName.Text = "Đã áp dụng cho tất cả ac đang online.";
		long_0 = Class11.smethod_27();
	}

	private void checkBoxBanVpHoagkimTest_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			bool_2 = checkBoxBanVpHoagkimTest.Checked;
			Class66.smethod_11(Class66.smethod_1(), "flagBanTrangbiHoangKimTest", Convert.ToByte(bool_2), "", 0);
		}
	}

	private void checkBoxThoahet_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			bool_1 = checkBoxThoahet.Checked;
			Class66.smethod_11(Class66.smethod_1(), "flagLocThoahetDieukien", Convert.ToByte(bool_1), "", 0);
		}
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_7[0] = Convert.ToByte(checkBox1.Checked);
			Class66.smethod_11(Class66.smethod_1(), "TrangbiDong1_0", int_7[0], "", 0);
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_7[1] = Class11.smethod_11(textBox1.Text);
			Class66.smethod_11(Class66.smethod_1(), "TrangbiDong1_1", int_7[1], "", 0);
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_8[0] = Convert.ToByte(checkBox2.Checked);
			Class66.smethod_11(Class66.smethod_1(), "TrangbiDong2_0", int_8[0], "", 0);
		}
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_8[1] = Class11.smethod_11(textBox2.Text);
			Class66.smethod_11(Class66.smethod_1(), "TrangbiDong2_1", int_8[1], "", 0);
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_9[0] = Convert.ToByte(checkBox3.Checked);
			Class66.smethod_11(Class66.smethod_1(), "TrangbiDong3_0", int_9[0], "", 0);
		}
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_9[1] = Class11.smethod_11(textBox3.Text);
			Class66.smethod_11(Class66.smethod_1(), "TrangbiDong3_1", int_9[1], "", 0);
		}
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_10[0] = Convert.ToByte(checkBox4.Checked);
			Class66.smethod_11(Class66.smethod_1(), "TrangbiDong4_0", int_10[0], "", 0);
		}
	}

	private void textBox4_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_10[1] = Class11.smethod_11(textBox4.Text);
			Class66.smethod_11(Class66.smethod_1(), "TrangbiDong4_1", int_10[1], "", 0);
		}
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_11[0] = Convert.ToByte(checkBox5.Checked);
			Class66.smethod_11(Class66.smethod_1(), "TrangbiDong5_0", int_11[0], "", 0);
		}
	}

	private void textBox5_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_11[1] = Class11.smethod_11(textBox5.Text);
			Class66.smethod_11(Class66.smethod_1(), "TrangbiDong5_1", int_11[1], "", 0);
		}
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_12[0] = Convert.ToByte(checkBox6.Checked);
			Class66.smethod_11(Class66.smethod_1(), "TrangbiDong6_0", int_12[0], "", 0);
		}
	}

	private void textBox6_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_12[1] = Class11.smethod_11(textBox6.Text);
			Class66.smethod_11(Class66.smethod_1(), "TrangbiDong6_1", int_12[1], "", 0);
		}
	}

	private void checkBoxCoNopVP_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_6 = Convert.ToByte(checkBoxCoNopVP.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fLocNopVP", int_6, "", 0);
		}
	}

	private void comboBoxNopVP_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_0.Enabled || Form1.characterAccountConfig_1 == null)
		{
			return;
		}
		string_3 = null;
		if (gstruct63_0 != null)
		{
			string_3 = new string[gstruct63_0.Length];
			for (int i = 0; i < gstruct63_0.Length; i++)
			{
				string_3[i] = gstruct63_0[i].string_0;
			}
		}
		for (int j = 0; j < Form1.characterAccountConfig_1.Length; j++)
		{
			Class85.smethod_38(Form1.characterAccountConfig_1[j], ref string_3);
		}
		if (string_3 == null)
		{
			return;
		}
		string text = comboBoxNopVP.Text;
		string text2 = null;
		Array.Sort(string_3);
		bool_4 = true;
		comboBoxNopVP.Items.Clear();
		for (int k = 0; k < string_3.Length; k++)
		{
			string text3 = Class1.smethod_1(string_3[k], 1);
			if (text3 == text)
			{
				text2 = text;
			}
			comboBoxNopVP.Items.Add(text3);
		}
		if (text2 == null)
		{
			text2 = comboBoxNopVP.Items[0].ToString();
		}
		comboBoxNopVP.Text = text2;
		bool_4 = false;
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || bool_4 || Form1.characterAccountConfig_1 == null || string_3 == null)
		{
			return;
		}
		int num = Class11.smethod_11(textBoxSoluongNop.Text);
		string text = comboBoxNopVP.Text;
		string text2 = null;
		for (int i = 0; i < string_3.Length; i++)
		{
			if (text != null && text != string.Empty && Class1.smethod_1(string_3[i], 1) == text)
			{
				text2 = string_3[i];
				break;
			}
		}
		if (text2 == null)
		{
			return;
		}
		GStruct63 gStruct = new GStruct63
		{
			string_0 = text2,
			int_0 = num
		};
		if (gstruct63_0 != null)
		{
			int num2 = 0;
			while (true)
			{
				if (num2 < gstruct63_0.Length)
				{
					if (!(text2 == gstruct63_0[num2].string_0))
					{
						num2++;
						continue;
					}
					break;
				}
				method_0(gStruct);
				Array.Resize(ref gstruct63_0, gstruct63_0.Length + 1);
				gstruct63_0[gstruct63_0.Length - 1] = gStruct;
				break;
			}
		}
		else
		{
			gstruct63_0 = new GStruct63[1] { gStruct };
			listView2.Items.Clear();
			method_0(gStruct);
		}
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		string text = null;
		for (int i = 0; i < listView2.Items.Count; i++)
		{
			if (listView2.Items[i].Selected)
			{
				text = listView2.Items[i].SubItems[1].Text;
				listView2.Items.RemoveAt(i);
				break;
			}
		}
		if (text == null || text == string.Empty || gstruct63_0 == null)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		GStruct63[] array = new GStruct63[gstruct63_0.Length];
		for (int j = 0; j < gstruct63_0.Length; j++)
		{
			string text2 = Class1.smethod_1(gstruct63_0[j].string_0, 1);
			if (num2 == 0 && text2 == text)
			{
				num2 = 1;
				continue;
			}
			array[num].string_0 = gstruct63_0[j].string_0;
			array[num].int_0 = gstruct63_0[j].int_0;
			num++;
		}
		if (num2 == 0)
		{
			return;
		}
		if (num != 0)
		{
			gstruct63_0 = new GStruct63[num];
			for (int k = 0; k < num; k++)
			{
				gstruct63_0[k].string_0 = array[k].string_0;
				gstruct63_0[k].int_0 = array[k].int_0;
			}
		}
		else
		{
			gstruct63_0 = null;
			listView2.Items.Clear();
		}
	}

	public static void smethod_2()
	{
		int int_ = int_1;
		int_1 = 0;
		while (true)
		{
			try
			{
				smethod_3(int_);
				break;
			}
			catch
			{
				Thread.Sleep(1000);
			}
		}
	}

	public static void smethod_3(int int_19)
	{
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		int int_20 = 0;
		byte[] array = new byte[4];
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		uint[] array2 = null;
		uint[] uint_ = null;
		bool flag = false;
		gstruct63_0 = smethod_0();
		while (true)
		{
			if (!bool_0)
			{
				num2--;
				Thread.Sleep(30);
				if (num2 <= 0)
				{
					num = Class87.smethod_3(Form1.characterAccountConfig_1, int_19);
					if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_25 || string_0 == null || string_0 == string.Empty)
					{
						break;
					}
					characterAccountConfig = Form1.characterAccountConfig_1[num];
					if (!flag)
					{
						flag = true;
						Class75.smethod_52(characterAccountConfig, Class1.smethod_2("<color=yellow>Bắt đầu mở lọc trang bị vật phẩm Test..."));
					}
					num2 = 10;
				}
				Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_10 * 4, array, 1, ref int_20);
				if (array[0] == 0)
				{
					break;
				}
				Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_11 * 4, array, 4, ref int_20);
				int num4 = BitConverter.ToInt32(array, 0);
				if (num4 < 0)
				{
					num4 = 0;
				}
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_20);
				uint num5 = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num5 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_20);
				uint num6 = BitConverter.ToUInt32(array, 0);
				uint num7 = num6 * Class56.memorySignatureScanConfig_15.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_20);
				uint num8 = BitConverter.ToUInt32(array, 0);
				uint num9 = num8 + num7;
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num9 + Class56.memorySignatureScanConfig_55.uint_0, array, 4, ref int_20);
				int num10 = BitConverter.ToInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num9 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_20);
				int num11 = BitConverter.ToInt32(array, 0);
				int num12 = Class89.smethod_39(characterAccountConfig);
				if (num11 != 0 && num10 != 0 && num12 > 1)
				{
					if (bool_0)
					{
						Class75.smethod_52(characterAccountConfig, "<color=yellow>kÕt thóc Auto!");
						break;
					}
					if (int_4 <= 0)
					{
						array2 = Class85.smethod_29(characterAccountConfig, string_0);
						if (array2 == null)
						{
							num3++;
							if (num3 > 300)
							{
								Class75.smethod_52(characterAccountConfig, Class1.smethod_2("<color=yellow>Không tìm thấy vật phẩm XXX trong hành trang. Kết thúc !").Replace("XXX", string_0));
								break;
							}
							continue;
						}
						num3 = 0;
						Class75.smethod_43(characterAccountConfig, array2[0], (int)array2[2], (int)array2[3]);
					}
					else
					{
						array2 = new uint[1] { (uint)Class3.smethod_14(characterAccountConfig, string_0, ref uint_, 3) };
						if (characterAccountConfig.int_25 > 0)
						{
							int i = 0;
							byte[] array3 = Class11.smethod_47("§ang Train kh«ng thÓ läc ®å " + string_0);
							for (; i < 10; i++)
							{
								Class24.WriteProcessMemory(characterAccountConfig.int_137, num9 + Class56.memorySignatureScanConfig_251.uint_0, array3, array3.Length, ref int_20);
								Thread.Sleep(300);
							}
							continue;
						}
						if (array2[0] == 0 || uint_ == null)
						{
							int j = 0;
							byte[] array4 = Class11.smethod_47("Khong tim thay NPC " + string_0);
							for (; j < 10; j++)
							{
								Class24.WriteProcessMemory(characterAccountConfig.int_137, num9 + Class56.memorySignatureScanConfig_251.uint_0, array4, array4.Length, ref int_20);
								Thread.Sleep(300);
							}
							continue;
						}
						uint[] uint_2 = new uint[2]
						{
							Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
							Class24.smethod_30(num9 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
						};
						if (Class64.smethod_18(uint_2, uint_) > 22500L)
						{
							Class75.smethod_61(characterAccountConfig, uint_);
							continue;
						}
						Class95.smethod_8(characterAccountConfig);
						Class38.smethod_10(characterAccountConfig, array2[0]);
					}
					if (int_13 != null)
					{
						int num13 = 0;
						int num14 = int_13.Length;
						long num15 = 0L;
						int num16 = Class85.smethod_4(characterAccountConfig);
						while (true)
						{
							if (num15 == 0L)
							{
								num15 = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
							}
							if (num14 <= num13 || Class85.smethod_4(characterAccountConfig) > num16 || Math.Abs(DateTime.Now.Second * 1000 + DateTime.Now.Millisecond - num15) > 1000L)
							{
								break;
							}
							if (Class95.Class92.smethod_4(characterAccountConfig))
							{
								Class24.smethod_4(characterAccountConfig.uint_4, 32u);
							}
							int num17 = Class95.smethod_0(characterAccountConfig);
							int num18 = Class95.smethod_1(characterAccountConfig, num17);
							if (num17 >= 0 && num18 != 0)
							{
								int num19 = int_13[num13] - 1;
								if (num19 >= 0 && num18 > num19)
								{
									string text = Class95.smethod_3(characterAccountConfig, num19, num17, 40);
									Class95.smethod_5(characterAccountConfig, num19);
									num15 = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
									while (DateTime.Now.Second * 1000 + DateTime.Now.Millisecond - num15 < 1200L)
									{
										Thread.Sleep(1 + num4);
										int num20 = Class95.smethod_0(characterAccountConfig);
										int num21 = Class95.smethod_1(characterAccountConfig, num20);
										string text2 = Class95.smethod_3(characterAccountConfig, num19, num17, 40);
										if ((num20 != num17 && num20 != 2) || num21 != num18 || num21 <= num19 || text2 != text)
										{
											break;
										}
									}
								}
								num13++;
								num15 = 0L;
							}
							else
							{
								Thread.Sleep(10);
							}
						}
						if (int_3 > 0)
						{
							int num22 = int_2;
							if (num22 <= 0)
							{
								num22 = 1;
							}
							int num23 = 0;
							while (num23 < 150)
							{
								if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) == 0)
								{
									num23++;
									Thread.Sleep(10);
									continue;
								}
								Class47.smethod_5(characterAccountConfig, num22.ToString(), bool_0: true);
								Thread.Sleep(150);
								break;
							}
						}
					}
					if (int_6 > 0 && gstruct63_0 != null)
					{
						try
						{
							for (int k = 0; k < gstruct63_0.Length; k++)
							{
								smethod_4(characterAccountConfig, gstruct63_0[k].string_0, gstruct63_0[k].int_0);
							}
						}
						catch
						{
						}
						int num24 = Class85.smethod_4(characterAccountConfig);
						Thread.Sleep(300);
						Class75.smethod_110(characterAccountConfig);
						int l;
						for (l = 0; l < 10; l++)
						{
							if (!Class47.smethod_8(characterAccountConfig))
							{
								break;
							}
							Thread.Sleep(100);
						}
						Thread.Sleep(100);
						l = 0;
						while (l < 6 && Class85.smethod_4(characterAccountConfig) == num24)
						{
							if (!Class95.Class92.smethod_4(characterAccountConfig))
							{
								if (0 <= Class95.smethod_0(characterAccountConfig))
								{
									Class95.smethod_5(characterAccountConfig, 0);
								}
							}
							else
							{
								Class24.smethod_4(characterAccountConfig.uint_4, 32u);
							}
							l++;
							Thread.Sleep(100);
						}
					}
					smethod_5(characterAccountConfig, bool_1);
					if (bool_0)
					{
						Class75.smethod_52(characterAccountConfig, "<color=yellow>kÕt thóc Auto!");
						break;
					}
					int num25 = Class95.smethod_0(characterAccountConfig);
					if (num25 > 1)
					{
						Class95.smethod_5(characterAccountConfig, Class95.smethod_1(characterAccountConfig, 1) - 1);
						Thread.Sleep(100);
						Class95.smethod_5(characterAccountConfig, Class95.smethod_1(characterAccountConfig, 0) - 1);
						Thread.Sleep(100);
					}
				}
				else
				{
					Thread.Sleep(300);
				}
				continue;
			}
			num = Class87.smethod_3(Form1.characterAccountConfig_1, int_19);
			if (num >= 0)
			{
				characterAccountConfig = Form1.characterAccountConfig_1[num];
				Class75.smethod_52(characterAccountConfig, "<color=yellow>kÕt thóc Auto");
			}
			break;
		}
		Class75.smethod_2(characterAccountConfig, Class75.uint_10, 0, 4);
		Class75.smethod_52(characterAccountConfig, "<color=yellow>Ket thuc mo loc trang bi test!");
	}

	private static void smethod_4(CharacterAccountConfig characterAccountConfig_0, string string_4, int int_19)
	{
		if (string_4 == null || string_4 == string.Empty)
		{
			return;
		}
		int num = 0;
		do
		{
			if (!Class47.smethod_8(characterAccountConfig_0))
			{
				Thread.Sleep(10);
				num++;
				continue;
			}
			int int_20 = 0;
			byte[] array = new byte[string_4.Length + 3];
			byte[] array2 = new byte[1];
			byte[] array3 = new byte[4];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array3, 4, ref int_20);
			uint num2 = BitConverter.ToUInt32(array3, 0) + Class56.memorySignatureScanConfig_97.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array3, 4, ref int_20);
			uint num3 = BitConverter.ToUInt32(array3, 0);
			uint num4 = 12u;
			int num5 = Class85.smethod_4(characterAccountConfig_0);
			int num6 = 0;
			for (uint num7 = 1u; num7 < Class56.int_1 && num5 > num6; num7++)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + (num7 * 5 + Class56.memorySignatureScanConfig_99.uint_0) * 4, array3, 4, ref int_20);
				uint num8 = BitConverter.ToUInt32(array3, 0);
				if (num8 == 0)
				{
					continue;
				}
				uint num9 = num3 + num8 * Class56.memorySignatureScanConfig_106.uint_0;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array3, 4, ref int_20);
				if (BitConverter.ToInt32(array3, 0) != 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_107.uint_0, array2, 1, ref int_20);
				if (array2[0] == 0)
				{
					continue;
				}
				num6++;
				if (array2[0] != string_4[0])
				{
					continue;
				}
				uint num10 = num2 + num7 * 20;
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array2, 1, ref int_20);
				uint num11 = array2[0];
				if (num11 != 3 && num11 != 1)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_107.uint_0, array, array.Length, ref int_20);
				string text = Class1.smethod_3(array);
				if (text != string_4)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_119.uint_0, array3, 4, ref int_20);
				int num12 = BitConverter.ToInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_108.uint_0, array3, 4, ref int_20);
				int num13 = BitConverter.ToInt32(array3, 0);
				if (num13 == 0)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_119.uint_0 + 4, array3, 4, ref int_20);
					int num14 = BitConverter.ToInt32(array3, 0);
					if (num12 == 0 && num14 > 0)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_110.uint_0, array3, 4, ref int_20);
					int num15 = BitConverter.ToInt32(array3, 0);
					if (num15 <= 9)
					{
						int[] array4 = null;
						for (uint num16 = 0u; num16 < 6; num16++)
						{
							switch (num16)
							{
							case 0u:
								array4 = int_7;
								break;
							case 1u:
								array4 = int_8;
								break;
							case 2u:
								array4 = int_9;
								break;
							case 3u:
								array4 = int_10;
								break;
							case 4u:
								array4 = int_11;
								break;
							case 5u:
								array4 = int_12;
								break;
							}
							if (array4[0] <= 0)
							{
								continue;
							}
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_118.uint_0 + num16 * 16 + 4, array3, 4, ref int_20);
							int num17 = BitConverter.ToInt32(array3, 0);
							if (num17 >= array4[1])
							{
								continue;
							}
							goto IL_0585;
						}
						if (!bool_1)
						{
							continue;
						}
						int num18 = 0;
						int num19 = 0;
						bool flag = false;
						for (int i = 0; i < characterAccountConfig_0.itemAttributeFilterRule_0.Length; i++)
						{
							if (characterAccountConfig_0.itemAttributeFilterRule_0[i].int_0 <= 0)
							{
								continue;
							}
							num19++;
							flag = false;
							for (uint num20 = 0u; num20 < 6; num20++)
							{
								Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_118.uint_0 + num20 * 16, array3, 4, ref int_20);
								int num21 = BitConverter.ToInt32(array3, 0);
								if (characterAccountConfig_0.itemAttributeFilterRule_0[i].int_1 == num21)
								{
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_118.uint_0 + num20 * 16 + 4, array3, 4, ref int_20);
									int num22 = BitConverter.ToInt32(array3, 0);
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_118.uint_0 + num20 * 16 + 12, array3, 4, ref int_20);
									int num23 = BitConverter.ToInt32(array3, 0);
									bool flag2 = characterAccountConfig_0.itemAttributeFilterRule_0[i].int_2 <= num22 && num22 > 0;
									bool flag3 = characterAccountConfig_0.itemAttributeFilterRule_0[i].int_2 <= num23 && num23 > 0;
									bool flag4 = characterAccountConfig_0.itemAttributeFilterRule_0[i].int_2 <= 0;
									if ((characterAccountConfig_0.itemAttributeFilterRule_0[i].int_3 == 0 || characterAccountConfig_0.itemAttributeFilterRule_0[i].int_3 == num20 + 1) && (flag2 || flag3 || flag4))
									{
										num18++;
										flag = true;
										break;
									}
								}
							}
							if (flag || !bool_1)
							{
								continue;
							}
							goto IL_0585;
						}
						if (num19 == 0 || (bool_1 && num19 <= num18) || (!bool_1 && num18 > 0))
						{
							continue;
						}
					}
				}
				goto IL_0585;
				IL_0585:
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_111.uint_0, array3, 4, ref int_20);
				uint uint_ = BitConverter.ToUInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num9 + Class56.memorySignatureScanConfig_112.uint_0, array3, 4, ref int_20);
				uint uint_2 = BitConverter.ToUInt32(array3, 0);
				uint[] array5 = Class85.smethod_26(characterAccountConfig_0, num4, uint_, uint_2);
				if (array5 == null)
				{
					break;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0 - 4, array3, 4, ref int_20);
				uint num24 = BitConverter.ToUInt32(array3, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num10 + Class56.memorySignatureScanConfig_100.uint_0, array3, 4, ref int_20);
				uint num25 = BitConverter.ToUInt32(array3, 0);
				int num26 = 0;
				if (num12 > 0 && num13 > 1 && int_19 > 0 && num12 > int_19)
				{
					while (!Class11.bool_0 && Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_0.int_137) == 0)
					{
						if (num26 % 80 == 0)
						{
							Class75.smethod_71(characterAccountConfig_0, num8, (uint)int_19, 89);
						}
						Thread.Sleep(100);
						num26++;
						if (num26 > 200)
						{
							break;
						}
					}
					num12 = int_19;
				}
				else
				{
					while ((int)Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_0.int_137) <= 0)
					{
						if (num26 % 80 == 0)
						{
							Class75.smethod_46(characterAccountConfig_0, num24, num25, num11, num24, num25, num11);
						}
						Thread.Sleep(10);
						num26++;
						if (num26 > 200)
						{
							break;
						}
					}
					if (num12 <= 0)
					{
						num12 = 1;
					}
				}
				if (Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_0.int_137) != 0)
				{
					for (num26 = 0; num26 < 200; num26++)
					{
						if (num26 % 80 == 0)
						{
							Class75.smethod_46(characterAccountConfig_0, array5[0], array5[1], num4, array5[0], array5[1], num4);
						}
						if (Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_0.int_137) != 0)
						{
							Thread.Sleep(100);
							continue;
						}
						int_19 -= num12;
						break;
					}
				}
				if (Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_0.int_137) != 0)
				{
					num26 = 0;
					if (num11 == 1)
					{
						array5 = Class85.smethod_26(characterAccountConfig_0, 3u, uint_, uint_2);
						if (array5 != null)
						{
							num11 = 3u;
							num24 = array5[0];
							num25 = array5[1];
						}
					}
					for (; num26 < 200; num26++)
					{
						if (num26 % 80 == 0)
						{
							Class75.smethod_46(characterAccountConfig_0, num24, num25, num11, num24, num25, num11);
						}
						if (Class24.smethod_30(Class56.memorySignatureScanConfig_123.uint_0, characterAccountConfig_0.int_137) == 0)
						{
							break;
						}
						Thread.Sleep(100);
					}
				}
				if (int_19 <= 0)
				{
					break;
				}
			}
			break;
		}
		while (num <= 150);
	}

	public static void smethod_5(CharacterAccountConfig characterAccountConfig_0, bool bool_5)
	{
		int num = 0;
		int int_ = 0;
		byte[] array = new byte[1];
		byte[] array2 = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array2, 4, ref int_);
		uint num2 = BitConverter.ToUInt32(array2, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + Class56.memorySignatureScanConfig_13.uint_0, array2, 4, ref int_);
		uint num3 = BitConverter.ToUInt32(array2, 0);
		uint num4 = num3 * Class56.memorySignatureScanConfig_15.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_14.uint_0, array2, 4, ref int_);
		uint num5 = BitConverter.ToUInt32(array2, 0);
		uint num6 = num5 + num4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_105.uint_0, array2, 4, ref int_);
		uint num7 = BitConverter.ToUInt32(array2, 0);
		uint num8 = num2 + Class56.memorySignatureScanConfig_97.uint_0;
		int num9 = Class85.smethod_4(characterAccountConfig_0);
		int num10 = 0;
		int num11 = 0;
		for (uint num12 = 1u; num12 < Class56.int_1; num12++)
		{
			int num13 = Class85.smethod_4(characterAccountConfig_0);
			if (num9 != num13 || num11 > 0)
			{
				num9 = num13;
				num10 = 0;
				num12 = 1u;
			}
			num11 = 0;
			if (num9 <= num10)
			{
				break;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_43.uint_0, array, 1, ref int_);
			if (array[0] > 0)
			{
				break;
			}
			uint num14 = num8 + num12 * 20;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num14 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array2, 4, ref int_);
			uint num15 = BitConverter.ToUInt32(array2, 0);
			if (num15 == 0)
			{
				continue;
			}
			uint num16 = num7 + num15 * Class56.memorySignatureScanConfig_106.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_107.uint_0, array, 1, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			num10++;
			byte[] array3 = new byte[40];
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_107.uint_0, array3, array3.Length, ref int_);
			Class1.smethod_3(array3);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num14 + Class56.memorySignatureScanConfig_100.uint_0 - 8, array, 1, ref int_);
			if (array[0] != 3)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_108.uint_0, array, 1, ref int_);
			if (array[0] != 0)
			{
				continue;
			}
			if (!bool_2)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_109.uint_0, array, 1, ref int_);
				if (array[0] == 1 || array[0] == 4)
				{
					continue;
				}
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_120.uint_0, array2, 4, ref int_);
			if (BitConverter.ToInt32(array2, 0) != 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_119.uint_0, array2, 4, ref int_);
			int num17 = BitConverter.ToInt32(array2, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_119.uint_0 + 4, array2, 4, ref int_);
			int num18 = BitConverter.ToInt32(array2, 0);
			if (num17 == 0 && num18 > 0)
			{
				continue;
			}
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_110.uint_0, array2, 4, ref int_);
			int num19 = BitConverter.ToInt32(array2, 0);
			if (num19 > 9)
			{
				continue;
			}
			bool flag = false;
			if (int_5[0] > 0 && num19 != int_5[1] && (num19 != 0 || int_5[1] != 1) && (num19 != 1 || int_5[1] != 0))
			{
				flag = false;
			}
			else
			{
				int[] array4 = null;
				uint num20 = 0u;
				while (true)
				{
					if (num20 < 6)
					{
						switch (num20)
						{
						case 0u:
							array4 = int_7;
							break;
						case 1u:
							array4 = int_8;
							break;
						case 2u:
							array4 = int_9;
							break;
						case 3u:
							array4 = int_10;
							break;
						case 4u:
							array4 = int_11;
							break;
						case 5u:
							array4 = int_12;
							break;
						}
						if (array4[0] > 0)
						{
							Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_118.uint_0 + num20 * 16 + 4, array2, 4, ref int_);
							int num21 = BitConverter.ToInt32(array2, 0);
							if (num21 < array4[1])
							{
								flag = false;
								break;
							}
						}
						num20++;
						continue;
					}
					if (!bool_5)
					{
						flag = true;
						break;
					}
					int num22 = 0;
					int num23 = 0;
					bool flag2 = false;
					int num24 = 0;
					while (true)
					{
						if (num24 < characterAccountConfig_0.itemAttributeFilterRule_0.Length)
						{
							if (characterAccountConfig_0.itemAttributeFilterRule_0[num24].int_0 > 0)
							{
								num23++;
								flag2 = false;
								for (uint num25 = 0u; num25 < 6; num25++)
								{
									Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_118.uint_0 + num25 * 16, array2, 4, ref int_);
									int num26 = BitConverter.ToInt32(array2, 0);
									if (characterAccountConfig_0.itemAttributeFilterRule_0[num24].int_1 == num26)
									{
										Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_118.uint_0 + num25 * 16 + 4, array2, 4, ref int_);
										int num27 = BitConverter.ToInt32(array2, 0);
										Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_118.uint_0 + num25 * 16 + 12, array2, 4, ref int_);
										int num28 = BitConverter.ToInt32(array2, 0);
										bool flag3 = characterAccountConfig_0.itemAttributeFilterRule_0[num24].int_2 <= num27 && num27 > 0;
										bool flag4 = characterAccountConfig_0.itemAttributeFilterRule_0[num24].int_2 <= num28 && num28 > 0;
										bool flag5 = characterAccountConfig_0.itemAttributeFilterRule_0[num24].int_2 <= 0;
										if ((characterAccountConfig_0.itemAttributeFilterRule_0[num24].int_3 == 0 || characterAccountConfig_0.itemAttributeFilterRule_0[num24].int_3 == num25 + 1) && (flag3 || flag4 || flag5))
										{
											num22++;
											flag2 = true;
											break;
										}
									}
								}
								if (!flag2 && bool_1)
								{
									flag = false;
									break;
								}
							}
							num24++;
							continue;
						}
						flag = num23 == 0 || (bool_1 && num23 <= num22) || (!bool_1 && num22 > 0);
						break;
					}
					break;
				}
			}
			if (flag)
			{
				if (int_18 <= 0 || num < int_18)
				{
					num++;
					Class75.smethod_52(characterAccountConfig_0, Class1.smethod_2(string.Format("<color=green>Giữ trang bị ({0}/{1})", num, (int_18 > 0) ? int_18.ToString() : "∞")));
					continue;
				}
				flag = false;
				Class75.smethod_52(characterAccountConfig_0, Class1.smethod_2($"<color=yellow>Đã giữ đủ {int_18} trang bị. Bán item tiếp theo."));
			}
			int num29 = 0;
			uint uint_ = num16 + Class56.memorySignatureScanConfig_107.uint_0;
			while (!Class11.bool_0)
			{
				if (num29 % 10 == 0 && num15 != 0)
				{
					Class75.smethod_35(characterAccountConfig_0, num15);
				}
				Thread.Sleep(30);
				if (num29 % 15 == 0)
				{
					string string_ = Class89.smethod_22(characterAccountConfig_0);
					if (Class11.smethod_1(string_, "hÊt b¹i") > 0)
					{
						Class89.smethod_23(characterAccountConfig_0, "0K..");
						break;
					}
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num14 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array2, 4, ref int_);
				num15 = BitConverter.ToUInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + Class56.memorySignatureScanConfig_106.uint_0 - 4, array2, 4, ref int_);
				int num30 = BitConverter.ToInt32(array2, 0);
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + Class56.memorySignatureScanConfig_43.uint_0, array, 1, ref int_);
				byte b = array[0];
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 1, ref int_);
				byte b2 = array[0];
				if (num15 != 0 && num30 == 0 && b2 != 0 && b <= 0)
				{
					if (num29 > 100)
					{
						break;
					}
					num29++;
					continue;
				}
				num29 = 0;
				break;
			}
			if (int_18 > 0 && num >= int_18)
			{
				Class75.smethod_52(characterAccountConfig_0, Class1.smethod_2($"<color=yellow>Hoàn thành! Đã giữ đủ {int_18} trang bị. Dừng lọc đồ."));
				bool_0 = true;
				break;
			}
		}
	}

	private void linkLabelLuuy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string string_ = "Nếu trùng luyện các vật phẩm Hoàng Kim thì không được check vào mục []Bán luôn trang bị Hoàng Kim.||Đối với các vật phẩm đem nộp là trang bị (như Vũ khí, áo, mão ... ) nếu thỏa điều kiện của thuộc tính bên dưới thì nó sẽ giữ lại không nộp. Do vậy, sẽ có thể xảy ra trường hợp có vật phẩm nhưng auto không nộp.||Ví dụ trùng luyện vật phẩm Vũ khí Kim Ô, cần: 1 Vũ khí Kim Ô, 4 Kim Ô trùng luyện ngọc.||Nhưng có thể xảy ra trường hợp auto chỉ nộp 4 Kim Ô trùng luyện ngọc, mà không nộp vũ khí Kim Ô.||Nguyên nhân: Có thể bạn check vào dòng giữ lại [v] Tốc độ đánh = 40, mà vũ khí Kim Ô thì có tốc độ đánh 126, đã thỏa điều kiện nên nó không nộp.||Giải quyết: Check luôn dòng [v] Lọc đúng hết điều kiện thuộc tính dưới đây thì mới giữ.||Lúc này nếu auto giữ lại không nộp vũ khí, thì vũ khí đó đã đạt yêu cầu, bạn có thể tắt auto và đem vũ khí cất đi cho an toàn.";
		FormTip.smethod_0("LOC TRANG BỊ", string_, 60000000, 420, 340);
	}

	private void buttonBoCheck_Click(object sender, EventArgs e)
	{
		if (listView1.Items.Count > 0)
		{
			for (int i = 0; i < listView1.Items.Count; i++)
			{
				listView1.Items[i].Checked = false;
			}
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num >= 0 && Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0 != null)
		{
			for (int j = 0; j < Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0.Length; j++)
			{
				Form1.characterAccountConfig_1[num].itemAttributeFilterRule_0[j].int_0 = 0;
			}
		}
	}

	private void checkBoxLocTrangbi_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_5[0] = Convert.ToByte(checkBoxLocTrangbi.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagChiLocLayTrangbi_0", int_5[0], "", 0);
		}
	}

	private void comboBoxLocTrangbi_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		string text = comboBoxLocTrangbi.Text;
		for (int i = 0; i < string_2.Length; i++)
		{
			if (text == string_2[i])
			{
				int_5[1] = i;
				Class66.smethod_11(Class66.smethod_1(), "flagChiLocLayTrangbi_1", i, "", 0);
			}
		}
	}

	private void textBoxSoLuongGiu_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_18 = Class11.smethod_11(textBoxSoLuongGiu.Text);
			if (int_18 < 0)
			{
				int_18 = 0;
			}
			Class66.smethod_11(Class66.smethod_1(), "SoLuongTrangbiGiu", int_18, "", 0);
		}
	}

	public static void smethod_6()
	{
		bool_0 = false;
	}
}
