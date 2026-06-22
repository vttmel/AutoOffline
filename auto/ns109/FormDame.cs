using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns23;
using ns53;
using ns63;
using ns71;
using ns79;
using ns83;

namespace ns109;

public class FormDame : Form
{
	private IContainer icontainer_0 = null;

	private CheckBox checkBoxSkill1;

	private CheckBox checkBoxSkill2;

	private System.Windows.Forms.Timer timer_0;

	private ComboBox comboBoxKieudanh;

	private Label label1;

	private Button buttonClose;

	private CheckBox checkBoxTuDanhbinhthuong;

	private ComboBox comboBoxSkill1;

	private ComboBox comboBoxSkill2;

	private ComboBox comboBoxTenAc;

	private Label label3;

	private CheckBox checkBoxAllwayAttack;

	private Label label2;

	private RichTextBox richTextBox1;

	private TabControl tabControl1;

	private TabPage tabPageChieu12;

	private TabPage tabPageSendKey;

	private TextBox textBoxDeLay;

	private Label label4;

	private CheckBox checkBoxF_3;

	private CheckBox checkBoxF_2;

	private CheckBox checkBoxF_1;

	private ComboBox comboBoxKieuXuatchieu;

	private Label label6;

	private ComboBox comboBoxF_3;

	private ComboBox comboBoxF_2;

	private ComboBox comboBoxF_1;

	private Label labelTocdo;

	private TextBox textBoxTocdo;

	private CheckBox checkBoxCtrlShift;

	private TabPage tabPage1;

	private Button buttonNotCheckAll;

	private Label label5;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	public static int int_0 = 0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public static bool bool_0 = false;

	public static int int_5 = 0;

	public static int int_6 = Class66.smethod_4("flagDameMacdinh", 0, "0");

	public static int int_7 = 0;

	public static int int_8 = Class66.smethod_4("flagCtrlShift", 0, "1");

	public static int int_9 = Class66.smethod_4("IdexKieudanh", 0, "1");

	public static int int_10 = Class66.smethod_4("AllwayAttack", 0, "0");

	public static int int_11 = Class66.smethod_4("SwicthDame", 0, "1");

	public static int int_12 = Class66.smethod_4("TimerKeyXuat", 0, "300");

	public static int int_13 = Class66.smethod_4("TocdoDame", 0, "100");

	public static int int_14 = Class66.smethod_4("flagDameKethop", 0, "0");

	private static string[] string_0 = new string[3] { "1. Tự động đánh vào vị trí chuột", "2. Bấm và giữ phím tắt - Đánh vào vị trí chuột", "3. Bấm và giữ phím tắt - Tự động quét tìm đánh đối thủ" };

	private static string[] string_1 = new string[3] { "Sử dụng chiêu tay trái", "Đánh ra chiêu 1 2 bên dưới", "Đánh ra chiêu đã gán phím tắt" };

	public static string[,] string_2 = new string[3, 2]
	{
		{ "F3", "114" },
		{ "F4", "115" },
		{ "F5", "116" }
	};

	private static int int_15 = 0;

	private static bool bool_1 = false;

	public FormDame()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns109.FormDame));
		this.checkBoxSkill1 = new System.Windows.Forms.CheckBox();
		this.checkBoxSkill2 = new System.Windows.Forms.CheckBox();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.comboBoxKieudanh = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.buttonClose = new System.Windows.Forms.Button();
		this.checkBoxTuDanhbinhthuong = new System.Windows.Forms.CheckBox();
		this.comboBoxSkill1 = new System.Windows.Forms.ComboBox();
		this.comboBoxSkill2 = new System.Windows.Forms.ComboBox();
		this.comboBoxTenAc = new System.Windows.Forms.ComboBox();
		this.label3 = new System.Windows.Forms.Label();
		this.checkBoxAllwayAttack = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPageChieu12 = new System.Windows.Forms.TabPage();
		this.tabPageSendKey = new System.Windows.Forms.TabPage();
		this.textBoxDeLay = new System.Windows.Forms.TextBox();
		this.comboBoxF_3 = new System.Windows.Forms.ComboBox();
		this.comboBoxF_2 = new System.Windows.Forms.ComboBox();
		this.comboBoxF_1 = new System.Windows.Forms.ComboBox();
		this.label4 = new System.Windows.Forms.Label();
		this.checkBoxF_3 = new System.Windows.Forms.CheckBox();
		this.checkBoxF_2 = new System.Windows.Forms.CheckBox();
		this.checkBoxF_1 = new System.Windows.Forms.CheckBox();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.buttonNotCheckAll = new System.Windows.Forms.Button();
		this.label5 = new System.Windows.Forms.Label();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.comboBoxKieuXuatchieu = new System.Windows.Forms.ComboBox();
		this.label6 = new System.Windows.Forms.Label();
		this.labelTocdo = new System.Windows.Forms.Label();
		this.textBoxTocdo = new System.Windows.Forms.TextBox();
		this.checkBoxCtrlShift = new System.Windows.Forms.CheckBox();
		this.tabControl1.SuspendLayout();
		this.tabPageChieu12.SuspendLayout();
		this.tabPageSendKey.SuspendLayout();
		this.tabPage1.SuspendLayout();
		base.SuspendLayout();
		this.checkBoxSkill1.AutoSize = true;
		this.checkBoxSkill1.Location = new System.Drawing.Point(6, 16);
		this.checkBoxSkill1.Name = "checkBoxSkill1";
		this.checkBoxSkill1.Size = new System.Drawing.Size(62, 17);
		this.checkBoxSkill1.TabIndex = 0;
		this.checkBoxSkill1.Text = "Chiêu 1";
		this.checkBoxSkill1.UseVisualStyleBackColor = true;
		this.checkBoxSkill1.CheckedChanged += new System.EventHandler(checkBoxSkill1_CheckedChanged);
		this.checkBoxSkill2.AutoSize = true;
		this.checkBoxSkill2.Location = new System.Drawing.Point(6, 39);
		this.checkBoxSkill2.Name = "checkBoxSkill2";
		this.checkBoxSkill2.Size = new System.Drawing.Size(62, 17);
		this.checkBoxSkill2.TabIndex = 1;
		this.checkBoxSkill2.Text = "Chiêu 2";
		this.checkBoxSkill2.UseVisualStyleBackColor = true;
		this.checkBoxSkill2.CheckedChanged += new System.EventHandler(checkBoxSkill2_CheckedChanged);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.comboBoxKieudanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxKieudanh.DropDownWidth = 280;
		this.comboBoxKieudanh.FormattingEnabled = true;
		this.comboBoxKieudanh.Location = new System.Drawing.Point(94, 1);
		this.comboBoxKieudanh.Name = "comboBoxKieudanh";
		this.comboBoxKieudanh.Size = new System.Drawing.Size(298, 21);
		this.comboBoxKieudanh.TabIndex = 325;
		this.comboBoxKieudanh.SelectedIndexChanged += new System.EventHandler(comboBoxKieudanh_SelectedIndexChanged);
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(3, 29);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 13);
		this.label1.TabIndex = 326;
		this.label1.Text = "Phím đánh";
		this.buttonClose.Location = new System.Drawing.Point(310, 334);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(72, 26);
		this.buttonClose.TabIndex = 8;
		this.buttonClose.Text = "OK";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.checkBoxTuDanhbinhthuong.AutoSize = true;
		this.checkBoxTuDanhbinhthuong.ForeColor = System.Drawing.Color.DarkGreen;
		this.checkBoxTuDanhbinhthuong.Location = new System.Drawing.Point(6, 52);
		this.checkBoxTuDanhbinhthuong.Name = "checkBoxTuDanhbinhthuong";
		this.checkBoxTuDanhbinhthuong.Size = new System.Drawing.Size(318, 17);
		this.checkBoxTuDanhbinhthuong.TabIndex = 329;
		this.checkBoxTuDanhbinhthuong.Text = "Tự động chuyển sang đánh bình thường khi không bấm phím";
		this.checkBoxTuDanhbinhthuong.UseVisualStyleBackColor = true;
		this.checkBoxTuDanhbinhthuong.CheckedChanged += new System.EventHandler(checkBoxTuDanhbinhthuong_CheckedChanged);
		this.comboBoxSkill1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxSkill1.DropDownWidth = 200;
		this.comboBoxSkill1.ForeColor = System.Drawing.Color.Black;
		this.comboBoxSkill1.FormattingEnabled = true;
		this.comboBoxSkill1.Location = new System.Drawing.Point(74, 13);
		this.comboBoxSkill1.Name = "comboBoxSkill1";
		this.comboBoxSkill1.Size = new System.Drawing.Size(163, 21);
		this.comboBoxSkill1.TabIndex = 350;
		this.comboBoxSkill1.SelectedIndexChanged += new System.EventHandler(comboBoxSkill1_SelectedIndexChanged);
		this.comboBoxSkill2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxSkill2.DropDownWidth = 200;
		this.comboBoxSkill2.ForeColor = System.Drawing.Color.Black;
		this.comboBoxSkill2.FormattingEnabled = true;
		this.comboBoxSkill2.Location = new System.Drawing.Point(74, 37);
		this.comboBoxSkill2.Name = "comboBoxSkill2";
		this.comboBoxSkill2.Size = new System.Drawing.Size(163, 21);
		this.comboBoxSkill2.TabIndex = 351;
		this.comboBoxSkill2.SelectedIndexChanged += new System.EventHandler(comboBoxSkill2_SelectedIndexChanged);
		this.comboBoxTenAc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxTenAc.DropDownWidth = 120;
		this.comboBoxTenAc.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTenAc.FormattingEnabled = true;
		this.comboBoxTenAc.Location = new System.Drawing.Point(94, 195);
		this.comboBoxTenAc.Name = "comboBoxTenAc";
		this.comboBoxTenAc.Size = new System.Drawing.Size(100, 21);
		this.comboBoxTenAc.TabIndex = 353;
		this.comboBoxTenAc.SelectedIndexChanged += new System.EventHandler(comboBoxTenAc_SelectedIndexChanged);
		this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(94, 26);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(66, 18);
		this.label3.TabIndex = 356;
		this.label3.Text = "SPACE";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.checkBoxAllwayAttack.AutoSize = true;
		this.checkBoxAllwayAttack.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxAllwayAttack.Location = new System.Drawing.Point(6, 75);
		this.checkBoxAllwayAttack.Name = "checkBoxAllwayAttack";
		this.checkBoxAllwayAttack.Size = new System.Drawing.Size(279, 17);
		this.checkBoxAllwayAttack.TabIndex = 357;
		this.checkBoxAllwayAttack.Text = "Không đánh người, đánh quái nhưng vẫn dame được";
		this.checkBoxAllwayAttack.UseVisualStyleBackColor = true;
		this.checkBoxAllwayAttack.CheckedChanged += new System.EventHandler(checkBoxAllwayAttack_CheckedChanged);
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.Color.Black;
		this.label2.Location = new System.Drawing.Point(3, 5);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(65, 13);
		this.label2.TabIndex = 358;
		this.label2.Text = "Kiểu đánh";
		this.richTextBox1.Location = new System.Drawing.Point(3, 104);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.ReadOnly = true;
		this.richTextBox1.Size = new System.Drawing.Size(391, 85);
		this.richTextBox1.TabIndex = 359;
		this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
		this.tabControl1.Controls.Add(this.tabPageChieu12);
		this.tabControl1.Controls.Add(this.tabPageSendKey);
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Location = new System.Drawing.Point(5, 222);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(387, 106);
		this.tabControl1.TabIndex = 354;
		this.tabPageChieu12.Controls.Add(this.comboBoxSkill1);
		this.tabPageChieu12.Controls.Add(this.comboBoxSkill2);
		this.tabPageChieu12.Controls.Add(this.checkBoxSkill2);
		this.tabPageChieu12.Controls.Add(this.checkBoxSkill1);
		this.tabPageChieu12.Location = new System.Drawing.Point(4, 22);
		this.tabPageChieu12.Name = "tabPageChieu12";
		this.tabPageChieu12.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageChieu12.Size = new System.Drawing.Size(379, 80);
		this.tabPageChieu12.TabIndex = 0;
		this.tabPageChieu12.Text = "Đánh chiêu 1 2 dưới";
		this.tabPageChieu12.UseVisualStyleBackColor = true;
		this.tabPageSendKey.Controls.Add(this.textBoxDeLay);
		this.tabPageSendKey.Controls.Add(this.comboBoxF_3);
		this.tabPageSendKey.Controls.Add(this.comboBoxF_2);
		this.tabPageSendKey.Controls.Add(this.comboBoxF_1);
		this.tabPageSendKey.Controls.Add(this.label4);
		this.tabPageSendKey.Controls.Add(this.checkBoxF_3);
		this.tabPageSendKey.Controls.Add(this.checkBoxF_2);
		this.tabPageSendKey.Controls.Add(this.checkBoxF_1);
		this.tabPageSendKey.Location = new System.Drawing.Point(4, 22);
		this.tabPageSendKey.Name = "tabPageSendKey";
		this.tabPageSendKey.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageSendKey.Size = new System.Drawing.Size(379, 80);
		this.tabPageSendKey.TabIndex = 1;
		this.tabPageSendKey.Text = "Đánh ra liên tiếp chiêu ở phím tắt";
		this.tabPageSendKey.UseVisualStyleBackColor = true;
		this.textBoxDeLay.ForeColor = System.Drawing.Color.DarkRed;
		this.textBoxDeLay.Location = new System.Drawing.Point(256, 54);
		this.textBoxDeLay.Name = "textBoxDeLay";
		this.textBoxDeLay.Size = new System.Drawing.Size(59, 20);
		this.textBoxDeLay.TabIndex = 366;
		this.textBoxDeLay.TextChanged += new System.EventHandler(textBoxDeLay_TextChanged);
		this.comboBoxF_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxF_3.FormattingEnabled = true;
		this.comboBoxF_3.Location = new System.Drawing.Point(56, 56);
		this.comboBoxF_3.Name = "comboBoxF_3";
		this.comboBoxF_3.Size = new System.Drawing.Size(45, 21);
		this.comboBoxF_3.TabIndex = 364;
		this.comboBoxF_3.SelectedIndexChanged += new System.EventHandler(comboBoxF_3_SelectedIndexChanged);
		this.comboBoxF_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxF_2.FormattingEnabled = true;
		this.comboBoxF_2.Location = new System.Drawing.Point(56, 29);
		this.comboBoxF_2.Name = "comboBoxF_2";
		this.comboBoxF_2.Size = new System.Drawing.Size(45, 21);
		this.comboBoxF_2.TabIndex = 362;
		this.comboBoxF_2.SelectedIndexChanged += new System.EventHandler(comboBoxF_2_SelectedIndexChanged);
		this.comboBoxF_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxF_1.FormattingEnabled = true;
		this.comboBoxF_1.Location = new System.Drawing.Point(56, 2);
		this.comboBoxF_1.Name = "comboBoxF_1";
		this.comboBoxF_1.Size = new System.Drawing.Size(45, 21);
		this.comboBoxF_1.TabIndex = 360;
		this.comboBoxF_1.SelectedIndexChanged += new System.EventHandler(comboBoxF_1_SelectedIndexChanged);
		this.label4.ForeColor = System.Drawing.Color.Black;
		this.label4.Location = new System.Drawing.Point(106, 5);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(236, 72);
		this.label4.TabIndex = 360;
		this.label4.Text = "Thời gian giữa 2 lần send liên tiếp (mili giây). Canh chỉnh sao cho phù hợp tốc độ xuất chiêu, nhanh quá thì nó chỉ đánh được 1 chiêu, chậm quá thì lãng phí.";
		this.checkBoxF_3.AutoSize = true;
		this.checkBoxF_3.Location = new System.Drawing.Point(3, 58);
		this.checkBoxF_3.Name = "checkBoxF_3";
		this.checkBoxF_3.Size = new System.Drawing.Size(51, 17);
		this.checkBoxF_3.TabIndex = 365;
		this.checkBoxF_3.Text = "Send";
		this.checkBoxF_3.UseVisualStyleBackColor = true;
		this.checkBoxF_3.CheckedChanged += new System.EventHandler(checkBoxF_3_CheckedChanged);
		this.checkBoxF_2.AutoSize = true;
		this.checkBoxF_2.Location = new System.Drawing.Point(3, 31);
		this.checkBoxF_2.Name = "checkBoxF_2";
		this.checkBoxF_2.Size = new System.Drawing.Size(51, 17);
		this.checkBoxF_2.TabIndex = 363;
		this.checkBoxF_2.Text = "Send";
		this.checkBoxF_2.UseVisualStyleBackColor = true;
		this.checkBoxF_2.CheckedChanged += new System.EventHandler(checkBoxF_2_CheckedChanged);
		this.checkBoxF_1.AutoSize = true;
		this.checkBoxF_1.Location = new System.Drawing.Point(3, 4);
		this.checkBoxF_1.Name = "checkBoxF_1";
		this.checkBoxF_1.Size = new System.Drawing.Size(51, 17);
		this.checkBoxF_1.TabIndex = 361;
		this.checkBoxF_1.Text = "Send";
		this.checkBoxF_1.UseVisualStyleBackColor = true;
		this.checkBoxF_1.CheckedChanged += new System.EventHandler(checkBoxF_1_CheckedChanged);
		this.tabPage1.Controls.Add(this.buttonNotCheckAll);
		this.tabPage1.Controls.Add(this.label5);
		this.tabPage1.Controls.Add(this.listView1);
		this.tabPage1.Location = new System.Drawing.Point(4, 22);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(379, 80);
		this.tabPage1.TabIndex = 2;
		this.tabPage1.Text = "Loại trừ ac dame";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.buttonNotCheckAll.Location = new System.Drawing.Point(194, 51);
		this.buttonNotCheckAll.Name = "buttonNotCheckAll";
		this.buttonNotCheckAll.Size = new System.Drawing.Size(113, 26);
		this.buttonNotCheckAll.TabIndex = 365;
		this.buttonNotCheckAll.Text = "Bỏ check tất cả ac";
		this.buttonNotCheckAll.UseVisualStyleBackColor = true;
		this.buttonNotCheckAll.Click += new System.EventHandler(buttonNotCheckAll_Click);
		this.label5.ForeColor = System.Drawing.Color.Black;
		this.label5.Location = new System.Drawing.Point(191, 3);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(185, 45);
		this.label5.TabIndex = 361;
		this.label5.Text = "Nếu muốn loại trừ ac nào đó, không muốn nó dame kết hợp thì check vào tên ac";
		this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listView1.CheckBoxes = true;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_0 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(1, 1);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(184, 78);
		this.listView1.TabIndex = 2;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(listView1_ItemCheck);
		this.columnHeader_0.Text = "Nhân vật";
		this.columnHeader_0.Width = 160;
		this.comboBoxKieuXuatchieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxKieuXuatchieu.ForeColor = System.Drawing.Color.MediumBlue;
		this.comboBoxKieuXuatchieu.FormattingEnabled = true;
		this.comboBoxKieuXuatchieu.Location = new System.Drawing.Point(195, 195);
		this.comboBoxKieuXuatchieu.Name = "comboBoxKieuXuatchieu";
		this.comboBoxKieuXuatchieu.Size = new System.Drawing.Size(160, 21);
		this.comboBoxKieuXuatchieu.TabIndex = 352;
		this.comboBoxKieuXuatchieu.SelectedIndexChanged += new System.EventHandler(comboBoxKieuXuatchieu_SelectedIndexChanged);
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.Location = new System.Drawing.Point(3, 199);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(86, 13);
		this.label6.TabIndex = 361;
		this.label6.Text = "Chọn riêng ac";
		this.labelTocdo.AutoSize = true;
		this.labelTocdo.Location = new System.Drawing.Point(166, 28);
		this.labelTocdo.Name = "labelTocdo";
		this.labelTocdo.Size = new System.Drawing.Size(87, 13);
		this.labelTocdo.TabIndex = 362;
		this.labelTocdo.Text = "Tốc độ (mili giây)";
		this.textBoxTocdo.Location = new System.Drawing.Point(259, 24);
		this.textBoxTocdo.Name = "textBoxTocdo";
		this.textBoxTocdo.Size = new System.Drawing.Size(46, 20);
		this.textBoxTocdo.TabIndex = 363;
		this.textBoxTocdo.TextChanged += new System.EventHandler(textBoxTocdo_TextChanged);
		this.checkBoxCtrlShift.AutoSize = true;
		this.checkBoxCtrlShift.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxCtrlShift.Location = new System.Drawing.Point(6, 338);
		this.checkBoxCtrlShift.Name = "checkBoxCtrlShift";
		this.checkBoxCtrlShift.Size = new System.Drawing.Size(259, 17);
		this.checkBoxCtrlShift.TabIndex = 364;
		this.checkBoxCtrlShift.Text = "Sử dụng CTRL + SHIFT để tắt/bật dame kết hợp";
		this.checkBoxCtrlShift.UseVisualStyleBackColor = true;
		this.checkBoxCtrlShift.CheckedChanged += new System.EventHandler(checkBoxCtrlShift_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(394, 365);
		base.Controls.Add(this.checkBoxCtrlShift);
		base.Controls.Add(this.textBoxTocdo);
		base.Controls.Add(this.labelTocdo);
		base.Controls.Add(this.comboBoxTenAc);
		base.Controls.Add(this.comboBoxKieudanh);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.comboBoxKieuXuatchieu);
		base.Controls.Add(this.tabControl1);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.checkBoxAllwayAttack);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.checkBoxTuDanhbinhthuong);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormDame";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Dame Ket Hop";
		base.Load += new System.EventHandler(FormDame_Load);
		this.tabControl1.ResumeLayout(false);
		this.tabPageChieu12.ResumeLayout(false);
		this.tabPageChieu12.PerformLayout();
		this.tabPageSendKey.ResumeLayout(false);
		this.tabPageSendKey.PerformLayout();
		this.tabPage1.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public static void smethod_0()
	{
		int num = int_0;
		int_0 = 0;
		int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, num);
		if (num2 < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig = Form1.characterAccountConfig_1[num2];
		int int_ = 0;
		byte[] array = new byte[1] { 1 };
		Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_12 * 4, array, 1, ref int_);
		int num3 = 0;
		uint uint_ = characterAccountConfig.uint_4;
		long num4 = 0L;
		while (true)
		{
			num3--;
			Thread.Sleep(10);
			if (num4 > 0L)
			{
				long num5 = DateTime.Now.Ticks - num4;
				if (num5 < 3000000L || num5 < int_13 * 10000)
				{
					goto IL_0114;
				}
				num4 = 0L;
			}
			if (Class11.bool_0)
			{
				break;
			}
			if (num3 <= 0)
			{
				num2 = Class87.smethod_3(Form1.characterAccountConfig_1, num);
				if (num2 < 0)
				{
					break;
				}
				uint_ = Form1.characterAccountConfig_1[num2].uint_4;
				num3 = 60;
			}
			Class24.ReadProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_12 * 4 + 1, array, 1, ref int_);
			if (array[0] != 0)
			{
				array[0] = 0;
				Class24.WriteProcessMemory(characterAccountConfig.int_137, characterAccountConfig.uint_16 + Class75.uint_12 * 4 + 1, array, 1, ref int_);
				num4 = DateTime.Now.Ticks;
				goto IL_0114;
			}
			Thread.Sleep(200);
			continue;
			IL_0114:
			if (int_14 > 0)
			{
				Class24.smethod_76(uint_, 32);
			}
			else
			{
				Class24.smethod_76(uint_, 117);
			}
		}
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		int_1 = 0;
		int_2 = 0;
		bool_0 = false;
		Class66.smethod_11(Class66.smethod_1(), "tabControlDame", tabControl1.SelectedIndex, "", 0);
	}

	private bool method_0(GStruct58[] gstruct58_0)
	{
		comboBoxSkill1.Items.Clear();
		comboBoxSkill2.Items.Clear();
		if (gstruct58_0 != null)
		{
			for (int i = 0; i < gstruct58_0.Length; i++)
			{
				comboBoxSkill1.Items.Add(gstruct58_0[i].string_0);
				comboBoxSkill2.Items.Add(gstruct58_0[i].string_0);
			}
			return true;
		}
		return false;
	}

	private string method_1(GStruct58[] gstruct58_0, int int_16)
	{
		if (int_16 > 0 && gstruct58_0 != null)
		{
			for (int i = 0; i < gstruct58_0.Length; i++)
			{
				if (gstruct58_0[i].int_1 == int_16)
				{
					return gstruct58_0[i].string_0;
				}
			}
		}
		return string.Empty;
	}

	private void FormDame_Load(object sender, EventArgs e)
	{
		int_15 = int_5;
		bool_1 = false;
		if (int_1 > 0 && int_2 > 0)
		{
			int num = int_1 - base.Width - 10;
			int num2 = int_2 - base.Height - 10;
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
		for (int i = 0; i < string_2.GetLength(0); i++)
		{
			string item = string_2[i, 0];
			comboBoxF_1.Items.Add(item);
			comboBoxF_2.Items.Add(item);
			comboBoxF_3.Items.Add(item);
		}
		for (int j = 0; j < string_1.Length; j++)
		{
			comboBoxKieuXuatchieu.Items.Add(string_1[j]);
		}
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int k = 0; k < Form1.characterAccountConfig_1.Length; k++)
			{
				string text = Class1.smethod_1(Form1.characterAccountConfig_1[k].string_22, 1);
				comboBoxTenAc.Items.Add(text);
				method_2(listView1, text + "|" + Form1.characterAccountConfig_1[k].int_136);
			}
			for (int l = 0; l < Form1.characterAccountConfig_1.Length; l++)
			{
				if (Form1.characterAccountConfig_1[l].int_126 > 0 && l < listView1.Items.Count)
				{
					listView1.Items[l].Checked = true;
				}
			}
		}
		int num3 = 0;
		int num4 = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
		if (0 <= num4)
		{
			CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num4];
			comboBoxTenAc.Text = Class1.smethod_1(Form1.characterAccountConfig_1[num4].string_22, 1);
			GStruct58[] gstruct58_ = Class83.smethod_22(characterAccountConfig_);
			method_0(gstruct58_);
			checkBoxSkill1.Checked = characterAccountConfig_.int_127[1] > 0;
			comboBoxSkill1.Text = method_1(gstruct58_, characterAccountConfig_.int_127[2]);
			checkBoxSkill2.Checked = characterAccountConfig_.int_127[3] > 0;
			comboBoxSkill2.Text = method_1(gstruct58_, characterAccountConfig_.int_127[4]);
			checkBoxF_1.Checked = characterAccountConfig_.int_129[0] > 0;
			checkBoxF_2.Checked = characterAccountConfig_.int_129[1] > 0;
			checkBoxF_3.Checked = characterAccountConfig_.int_129[2] > 0;
			comboBoxF_1.Text = smethod_1(characterAccountConfig_.int_129[3]);
			comboBoxF_2.Text = smethod_1(characterAccountConfig_.int_129[4]);
			comboBoxF_3.Text = smethod_1(characterAccountConfig_.int_129[5]);
			num3 = characterAccountConfig_.int_127[0];
		}
		comboBoxKieuXuatchieu.Text = string_1[num3];
		method_3(num3);
		for (int m = 0; m < string_0.Length; m++)
		{
			comboBoxKieudanh.Items.Add(string_0[m]);
		}
		comboBoxKieudanh.Text = string_0[int_9];
		checkBoxTuDanhbinhthuong.Checked = int_11 > 0;
		checkBoxTuDanhbinhthuong.Enabled = int_9 == 1;
		checkBoxCtrlShift.Checked = int_8 > 0;
		checkBoxAllwayAttack.Checked = int_10 > 0;
		textBoxTocdo.Text = int_13.ToString();
		textBoxDeLay.Text = int_12.ToString();
		base.TopMost = true;
		tabControl1.SelectedIndex = Class66.smethod_4("tabControlDame", 0, "0");
		Thread.Sleep(60);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		bool_1 = true;
	}

	private void method_2(ListView listView_0, string string_3)
	{
		string[] array = string_3.Split('|');
		try
		{
			ListViewItem listViewItem = new ListViewItem(array[0]);
			for (int i = 1; i < array.Length; i++)
			{
				ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
				listViewItem.SubItems.Add(item);
			}
			listView1.Items.Add(listViewItem);
		}
		catch
		{
		}
	}

	private static string smethod_1(int int_16)
	{
		if (int_16 > 0)
		{
			for (int i = 0; i < string_2.GetLength(0); i++)
			{
				if (int_16 == Class11.smethod_11(string_2[i, 1]))
				{
					return string_2[i, 0];
				}
			}
		}
		return string.Empty;
	}

	private static int smethod_2(string string_3)
	{
		if (string_3 != null && string_3 != string.Empty)
		{
			for (int i = 0; i < string_2.GetLength(0); i++)
			{
				if (string_3 == string_2[i, 0])
				{
					return Class11.smethod_11(string_2[i, 1]);
				}
			}
		}
		return 0;
	}

	private void method_3(int int_16)
	{
		((Control)tabPageSendKey).Enabled = int_16 == 2;
		((Control)tabPageChieu12).Enabled = int_16 == 1;
		if (int_16 > 0)
		{
			tabControl1.SelectedIndex = int_16 - 1;
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void comboBoxKieudanh_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		string text = comboBoxKieudanh.Text;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (text == string_0[i])
			{
				int_9 = i;
				break;
			}
		}
		Class66.smethod_11(Class66.smethod_1(), "IdexKieudanh", int_9, "", 0);
		checkBoxTuDanhbinhthuong.Enabled = int_9 == 1;
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxTuDanhbinhthuong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_11 = Convert.ToByte(checkBoxTuDanhbinhthuong.Checked);
			Class66.smethod_11(Class66.smethod_1(), "SwicthDame", int_11, "", 0);
		}
	}

	private void comboBoxTenAc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int_15 = -1;
		string text = comboBoxTenAc.Text;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				if (text == Class1.smethod_1(Form1.characterAccountConfig_1[i].string_22, 1))
				{
					int_15 = Form1.characterAccountConfig_1[i].int_136;
					break;
				}
			}
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
		if (num >= 0)
		{
			CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
			bool_1 = false;
			GStruct58[] gstruct58_ = Class83.smethod_22(characterAccountConfig_);
			method_0(gstruct58_);
			checkBoxSkill1.Checked = characterAccountConfig_.int_127[1] > 0;
			comboBoxSkill1.Text = method_1(gstruct58_, characterAccountConfig_.int_127[2]);
			checkBoxSkill2.Checked = characterAccountConfig_.int_127[3] > 0;
			comboBoxSkill2.Text = method_1(gstruct58_, characterAccountConfig_.int_127[4]);
			checkBoxF_1.Checked = characterAccountConfig_.int_129[0] > 0;
			checkBoxF_2.Checked = characterAccountConfig_.int_129[1] > 0;
			checkBoxF_3.Checked = characterAccountConfig_.int_129[2] > 0;
			comboBoxF_1.Text = smethod_1(characterAccountConfig_.int_129[3]);
			comboBoxF_2.Text = smethod_1(characterAccountConfig_.int_129[4]);
			comboBoxF_3.Text = smethod_1(characterAccountConfig_.int_129[5]);
			comboBoxKieuXuatchieu.Text = string_1[characterAccountConfig_.int_127[0]];
			method_3(characterAccountConfig_.int_127[0]);
			Thread.Sleep(60);
			bool_1 = true;
		}
	}

	private void checkBoxSkill1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_127[1] = Convert.ToByte(checkBoxSkill1.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxSkill2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_127[3] = Convert.ToByte(checkBoxSkill2.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxSkill1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
		if (num < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
		GStruct58[] array = Class83.smethod_22(characterAccountConfig_);
		if (array == null)
		{
			return;
		}
		int num2 = 0;
		string text = comboBoxSkill1.Text;
		for (int i = 0; i < array.Length; i++)
		{
			if (text == array[i].string_0)
			{
				num2 = array[i].int_1;
				break;
			}
		}
		num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
		if (0 <= num)
		{
			Form1.characterAccountConfig_1[num].int_127[2] = num2;
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		}
	}

	private void comboBoxSkill2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
		if (num < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
		GStruct58[] array = Class83.smethod_22(characterAccountConfig_);
		if (array == null)
		{
			return;
		}
		int num2 = 0;
		string text = comboBoxSkill2.Text;
		for (int i = 0; i < array.Length; i++)
		{
			if (text == array[i].string_0)
			{
				num2 = array[i].int_1;
				break;
			}
		}
		num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
		if (0 <= num)
		{
			Form1.characterAccountConfig_1[num].int_127[4] = num2;
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		}
	}

	private void checkBoxAllwayAttack_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_10 = Convert.ToByte(checkBoxAllwayAttack.Checked);
			Class66.smethod_11(Class66.smethod_1(), "AllwayAttack", int_10, "", 0);
		}
	}

	private void comboBoxKieuXuatchieu_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
		if (num < 0)
		{
			return;
		}
		int num2 = -1;
		for (int i = 0; i < string_1.Length; i++)
		{
			if (comboBoxKieuXuatchieu.Text == string_1[i])
			{
				num2 = i;
				break;
			}
		}
		if (num2 >= 0)
		{
			Form1.characterAccountConfig_1[num].int_127[0] = num2;
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			method_3(num2);
		}
	}

	private void textBoxDeLay_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_12 = Class11.smethod_11(textBoxDeLay.Text);
			Class66.smethod_11(Class66.smethod_1(), "TimerKeyXuat", int_12, "", 0);
		}
	}

	private void checkBoxF_1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_129[0] = Convert.ToByte(checkBoxF_1.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxF_2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_129[1] = Convert.ToByte(checkBoxF_2.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxF_3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_129[2] = Convert.ToByte(checkBoxF_3.Checked);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxF_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_129[3] = smethod_2(comboBoxF_1.Text);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxF_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_129[4] = smethod_2(comboBoxF_2.Text);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxF_3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_15);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_129[5] = smethod_2(comboBoxF_3.Text);
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxTocdo_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_13 = Class11.smethod_11(textBoxTocdo.Text);
			Class66.smethod_11(Class66.smethod_1(), "TocdoDame", int_13, "", 0);
		}
	}

	private void checkBoxCtrlShift_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_8 = Convert.ToByte(checkBoxCtrlShift.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagCtrlShift", int_8, "", 0);
		}
	}

	private void buttonNotCheckAll_Click(object sender, EventArgs e)
	{
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Form1.characterAccountConfig_1[i].int_126 = 0;
				Class56.smethod_13(Form1.characterAccountConfig_1[i]);
			}
		}
		for (int j = 0; j < listView1.Items.Count; j++)
		{
			listView1.Items[j].Checked = false;
		}
	}

	private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (!timer_0.Enabled)
		{
			return;
		}
		int num = Class11.smethod_11(listView1.Items[e.Index].SubItems[1].Text);
		if (num == 0 || Form1.characterAccountConfig_1 == null)
		{
			return;
		}
		try
		{
			int num2 = 0;
			while (true)
			{
				if (num2 < Form1.characterAccountConfig_1.Length)
				{
					if (Form1.characterAccountConfig_1[num2].int_136 == num)
					{
						break;
					}
					num2++;
					continue;
				}
				return;
			}
			Form1.characterAccountConfig_1[num2].int_126 = Convert.ToByte(e.NewValue == CheckState.Checked);
			Class56.smethod_13(Form1.characterAccountConfig_1[num2]);
		}
		catch
		{
		}
	}
}
