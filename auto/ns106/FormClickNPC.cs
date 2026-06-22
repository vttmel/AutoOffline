using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns138;
using ns18;
using ns23;
using ns3;
using ns33;
using ns44;
using ns52;
using ns53;
using ns61;
using ns63;
using ns71;
using ns81;
using ns83;
using ns85;
using ns88;

namespace ns106;

public class FormClickNPC : Form
{
	private IContainer icontainer_0 = null;

	private ComboBox comboBoxVatpham;

	private Label label1;

	private TextBox textBoxMenuVatpham;

	private CheckBox checkBoxCosudungVatpham;

	private CheckBox checkBoxDoithoaiTruoc;

	private System.Windows.Forms.Timer timer_0;

	private Button buttonApdungAll;

	private Button buttonDong;

	private Label labelTenac;

	private RichTextBox richTextBox1;

	private CheckBox checkBoxCoMuaVatpham;

	private ComboBox comboBoxMuaVP;

	private TextBox textBoxSoluongMua;

	private Label label3;

	private LinkLabel linkLabelMuaPhaohoa;

	private CheckBox checkBoxRuthettien;

	private CheckBox checkBoxClickNpcNopVP;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ComboBox comboBoxNop;

	private Button buttonThem;

	private Button buttonXoa;

	private Label label2;

	private TextBox textBoxSoluongNop;

	private CheckBox checkBoxMuaKTC;

	private ComboBox comboBoxTabKTC;

	private Button buttonSuaNopVP;

	private CheckBox checkBoxTach;

	private Label label4;

	private CheckBox checkBoxMuaKhiHet;

	private TextBox textBoxMuaKhicon;

	private CheckBox checkBoxCoNhapSL;

	private TextBox textBoxCoNhapSL;

	private Label label5;

	private Label label6;

	private Label label7;

	private Label label9;

	private TextBox textBox1;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public static int int_5 = Class66.smethod_4("fNhapSoluongClickNPC", 0, "0");

	public static int int_6 = Class66.smethod_4("iNhapSoluongClickNPC", 0, "3");

	public static int int_7 = Class66.smethod_4("fXoaMenuSauClickNPC", 0, "0");

	public static int int_8 = Class66.smethod_4("iXoaMenuSauClickNPC", 0, "1200");

	private bool bool_1 = false;

	private bool bool_2 = false;

	private string[] string_0 = null;

	private static Struct24[] struct24_0 = null;

	public static int int_9 = 0;

	public static int int_10 = 0;

	public FormClickNPC()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns106.FormClickNPC));
		this.comboBoxVatpham = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.textBoxMenuVatpham = new System.Windows.Forms.TextBox();
		this.checkBoxCosudungVatpham = new System.Windows.Forms.CheckBox();
		this.checkBoxDoithoaiTruoc = new System.Windows.Forms.CheckBox();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonApdungAll = new System.Windows.Forms.Button();
		this.buttonDong = new System.Windows.Forms.Button();
		this.labelTenac = new System.Windows.Forms.Label();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.checkBoxCoMuaVatpham = new System.Windows.Forms.CheckBox();
		this.comboBoxMuaVP = new System.Windows.Forms.ComboBox();
		this.textBoxSoluongMua = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.linkLabelMuaPhaohoa = new System.Windows.Forms.LinkLabel();
		this.checkBoxRuthettien = new System.Windows.Forms.CheckBox();
		this.checkBoxClickNpcNopVP = new System.Windows.Forms.CheckBox();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.comboBoxNop = new System.Windows.Forms.ComboBox();
		this.buttonThem = new System.Windows.Forms.Button();
		this.buttonXoa = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.textBoxSoluongNop = new System.Windows.Forms.TextBox();
		this.checkBoxMuaKTC = new System.Windows.Forms.CheckBox();
		this.comboBoxTabKTC = new System.Windows.Forms.ComboBox();
		this.buttonSuaNopVP = new System.Windows.Forms.Button();
		this.checkBoxTach = new System.Windows.Forms.CheckBox();
		this.label4 = new System.Windows.Forms.Label();
		this.checkBoxMuaKhiHet = new System.Windows.Forms.CheckBox();
		this.textBoxMuaKhicon = new System.Windows.Forms.TextBox();
		this.checkBoxCoNhapSL = new System.Windows.Forms.CheckBox();
		this.textBoxCoNhapSL = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.textBox1 = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.comboBoxVatpham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxVatpham.DropDownWidth = 200;
		this.comboBoxVatpham.ForeColor = System.Drawing.Color.Black;
		this.comboBoxVatpham.FormattingEnabled = true;
		this.comboBoxVatpham.Location = new System.Drawing.Point(145, 93);
		this.comboBoxVatpham.Name = "comboBoxVatpham";
		this.comboBoxVatpham.Size = new System.Drawing.Size(150, 21);
		this.comboBoxVatpham.TabIndex = 199;
		this.comboBoxVatpham.SelectedIndexChanged += new System.EventHandler(comboBoxVatpham_SelectedIndexChanged);
		this.comboBoxVatpham.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxVatpham_MouseDown);
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
		this.label1.Location = new System.Drawing.Point(50, 117);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(91, 13);
		this.label1.TabIndex = 200;
		this.label1.Text = "_click dòng menu";
		this.textBoxMenuVatpham.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxMenuVatpham.Font = new System.Drawing.Font("Courier New", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxMenuVatpham.ForeColor = System.Drawing.Color.Black;
		this.textBoxMenuVatpham.Location = new System.Drawing.Point(145, 114);
		this.textBoxMenuVatpham.Name = "textBoxMenuVatpham";
		this.textBoxMenuVatpham.Size = new System.Drawing.Size(150, 17);
		this.textBoxMenuVatpham.TabIndex = 201;
		this.textBoxMenuVatpham.TextChanged += new System.EventHandler(textBoxMenuVatpham_TextChanged);
		this.checkBoxCosudungVatpham.AutoSize = true;
		this.checkBoxCosudungVatpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxCosudungVatpham.ForeColor = System.Drawing.Color.MidnightBlue;
		this.checkBoxCosudungVatpham.Location = new System.Drawing.Point(3, 95);
		this.checkBoxCosudungVatpham.Name = "checkBoxCosudungVatpham";
		this.checkBoxCosudungVatpham.Size = new System.Drawing.Size(145, 17);
		this.checkBoxCosudungVatpham.TabIndex = 202;
		this.checkBoxCosudungVatpham.Text = "1a. Có sử dụng vật phẩm";
		this.checkBoxCosudungVatpham.UseVisualStyleBackColor = true;
		this.checkBoxCosudungVatpham.CheckedChanged += new System.EventHandler(checkBoxCosudungVatpham_CheckedChanged);
		this.checkBoxDoithoaiTruoc.AutoSize = true;
		this.checkBoxDoithoaiTruoc.ForeColor = System.Drawing.Color.MidnightBlue;
		this.checkBoxDoithoaiTruoc.Location = new System.Drawing.Point(3, 158);
		this.checkBoxDoithoaiTruoc.Name = "checkBoxDoithoaiTruoc";
		this.checkBoxDoithoaiTruoc.Size = new System.Drawing.Size(223, 17);
		this.checkBoxDoithoaiTruoc.TabIndex = 203;
		this.checkBoxDoithoaiTruoc.Text = "1b. Click Npc xong mới sử dụng vật phẩm";
		this.checkBoxDoithoaiTruoc.UseVisualStyleBackColor = true;
		this.checkBoxDoithoaiTruoc.CheckedChanged += new System.EventHandler(checkBoxDoithoaiTruoc_CheckedChanged);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonApdungAll.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonApdungAll.Location = new System.Drawing.Point(4, 467);
		this.buttonApdungAll.Name = "buttonApdungAll";
		this.buttonApdungAll.Size = new System.Drawing.Size(141, 26);
		this.buttonApdungAll.TabIndex = 207;
		this.buttonApdungAll.Text = "Áp dụng cho tất cả ac";
		this.buttonApdungAll.UseVisualStyleBackColor = true;
		this.buttonApdungAll.Click += new System.EventHandler(buttonApdungAll_Click);
		this.buttonDong.Location = new System.Drawing.Point(177, 467);
		this.buttonDong.Name = "buttonDong";
		this.buttonDong.Size = new System.Drawing.Size(105, 26);
		this.buttonDong.TabIndex = 208;
		this.buttonDong.Text = "Đóng";
		this.buttonDong.UseVisualStyleBackColor = true;
		this.buttonDong.Click += new System.EventHandler(buttonDong_Click);
		this.labelTenac.AutoSize = true;
		this.labelTenac.BackColor = System.Drawing.SystemColors.Control;
		this.labelTenac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.labelTenac.ForeColor = System.Drawing.Color.Red;
		this.labelTenac.Location = new System.Drawing.Point(1, 74);
		this.labelTenac.Name = "labelTenac";
		this.labelTenac.Size = new System.Drawing.Size(51, 13);
		this.labelTenac.TabIndex = 210;
		this.labelTenac.Text = "Tên ac:";
		this.richTextBox1.BackColor = System.Drawing.Color.Gainsboro;
		this.richTextBox1.Location = new System.Drawing.Point(1, 2);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.ReadOnly = true;
		this.richTextBox1.Size = new System.Drawing.Size(294, 70);
		this.richTextBox1.TabIndex = 211;
		this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
		this.checkBoxCoMuaVatpham.AutoSize = true;
		this.checkBoxCoMuaVatpham.ForeColor = System.Drawing.Color.Indigo;
		this.checkBoxCoMuaVatpham.Location = new System.Drawing.Point(3, 202);
		this.checkBoxCoMuaVatpham.Name = "checkBoxCoMuaVatpham";
		this.checkBoxCoMuaVatpham.Size = new System.Drawing.Size(127, 17);
		this.checkBoxCoMuaVatpham.TabIndex = 212;
		this.checkBoxCoMuaVatpham.Text = "2a. Có mua vật phẩm";
		this.checkBoxCoMuaVatpham.UseVisualStyleBackColor = true;
		this.checkBoxCoMuaVatpham.CheckedChanged += new System.EventHandler(checkBoxCoMuaVatpham_CheckedChanged);
		this.comboBoxMuaVP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxMuaVP.DropDownWidth = 200;
		this.comboBoxMuaVP.ForeColor = System.Drawing.Color.Black;
		this.comboBoxMuaVP.FormattingEnabled = true;
		this.comboBoxMuaVP.Location = new System.Drawing.Point(145, 199);
		this.comboBoxMuaVP.Name = "comboBoxMuaVP";
		this.comboBoxMuaVP.Size = new System.Drawing.Size(150, 21);
		this.comboBoxMuaVP.TabIndex = 213;
		this.comboBoxMuaVP.SelectedIndexChanged += new System.EventHandler(comboBoxMuaVP_SelectedIndexChanged);
		this.comboBoxMuaVP.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxMuaVP_MouseDown);
		this.textBoxSoluongMua.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluongMua.Location = new System.Drawing.Point(229, 222);
		this.textBoxSoluongMua.Name = "textBoxSoluongMua";
		this.textBoxSoluongMua.Size = new System.Drawing.Size(66, 20);
		this.textBoxSoluongMua.TabIndex = 214;
		this.textBoxSoluongMua.Text = "1";
		this.textBoxSoluongMua.TextChanged += new System.EventHandler(textBoxSoluongMua_TextChanged);
		this.label3.AutoSize = true;
		this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
		this.label3.Location = new System.Drawing.Point(8, 446);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(200, 13);
		this.label3.TabIndex = 215;
		this.label3.Text = "(ví dụ như mua lệnh bài phi tốc tống kim)";
		this.linkLabelMuaPhaohoa.AutoSize = true;
		this.linkLabelMuaPhaohoa.Location = new System.Drawing.Point(214, 446);
		this.linkLabelMuaPhaohoa.Name = "linkLabelMuaPhaohoa";
		this.linkLabelMuaPhaohoa.Size = new System.Drawing.Size(68, 13);
		this.linkLabelMuaPhaohoa.TabIndex = 217;
		this.linkLabelMuaPhaohoa.TabStop = true;
		this.linkLabelMuaPhaohoa.Text = "=> Xem phim";
		this.linkLabelMuaPhaohoa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelMuaPhaohoa_LinkClicked);
		this.checkBoxRuthettien.AutoSize = true;
		this.checkBoxRuthettien.ForeColor = System.Drawing.Color.Indigo;
		this.checkBoxRuthettien.Location = new System.Drawing.Point(3, 243);
		this.checkBoxRuthettien.Name = "checkBoxRuthettien";
		this.checkBoxRuthettien.Size = new System.Drawing.Size(139, 17);
		this.checkBoxRuthettien.TabIndex = 218;
		this.checkBoxRuthettien.Text = "2b. Rút hết tiền khi mua";
		this.checkBoxRuthettien.UseVisualStyleBackColor = true;
		this.checkBoxRuthettien.CheckedChanged += new System.EventHandler(checkBoxRuthettien_CheckedChanged);
		this.checkBoxClickNpcNopVP.AutoSize = true;
		this.checkBoxClickNpcNopVP.ForeColor = System.Drawing.Color.DarkBlue;
		this.checkBoxClickNpcNopVP.Location = new System.Drawing.Point(3, 316);
		this.checkBoxClickNpcNopVP.Name = "checkBoxClickNpcNopVP";
		this.checkBoxClickNpcNopVP.Size = new System.Drawing.Size(119, 17);
		this.checkBoxClickNpcNopVP.TabIndex = 220;
		this.checkBoxClickNpcNopVP.Text = "3. Có nộp vật phẩm";
		this.checkBoxClickNpcNopVP.UseVisualStyleBackColor = true;
		this.checkBoxClickNpcNopVP.CheckedChanged += new System.EventHandler(checkBoxClickNpcNopVP_CheckedChanged);
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader_0, this.columnHeader_1 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(145, 311);
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(150, 109);
		this.listView1.TabIndex = 221;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		this.columnHeader_0.Text = "Tên vật phẩm nộp";
		this.columnHeader_0.Width = 105;
		this.columnHeader_1.Text = "SL";
		this.columnHeader_1.Width = 25;
		this.comboBoxNop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxNop.DropDownWidth = 200;
		this.comboBoxNop.ForeColor = System.Drawing.Color.Black;
		this.comboBoxNop.FormattingEnabled = true;
		this.comboBoxNop.Location = new System.Drawing.Point(3, 339);
		this.comboBoxNop.Name = "comboBoxNop";
		this.comboBoxNop.Size = new System.Drawing.Size(134, 21);
		this.comboBoxNop.TabIndex = 222;
		this.comboBoxNop.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxNop_MouseDown);
		this.buttonThem.ForeColor = System.Drawing.Color.DarkGreen;
		this.buttonThem.Location = new System.Drawing.Point(82, 366);
		this.buttonThem.Name = "buttonThem";
		this.buttonThem.Size = new System.Drawing.Size(55, 25);
		this.buttonThem.TabIndex = 223;
		this.buttonThem.Text = "Thêm";
		this.buttonThem.UseVisualStyleBackColor = true;
		this.buttonThem.Click += new System.EventHandler(buttonThem_Click);
		this.buttonXoa.Location = new System.Drawing.Point(82, 395);
		this.buttonXoa.Name = "buttonXoa";
		this.buttonXoa.Size = new System.Drawing.Size(55, 25);
		this.buttonXoa.TabIndex = 224;
		this.buttonXoa.Text = "Xóa";
		this.buttonXoa.UseVisualStyleBackColor = true;
		this.buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(3, 365);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(49, 13);
		this.label2.TabIndex = 225;
		this.label2.Text = "Số lượng";
		this.textBoxSoluongNop.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluongNop.Location = new System.Drawing.Point(54, 363);
		this.textBoxSoluongNop.Name = "textBoxSoluongNop";
		this.textBoxSoluongNop.Size = new System.Drawing.Size(22, 20);
		this.textBoxSoluongNop.TabIndex = 226;
		this.textBoxSoluongNop.Text = "1";
		this.checkBoxMuaKTC.AutoSize = true;
		this.checkBoxMuaKTC.ForeColor = System.Drawing.Color.Indigo;
		this.checkBoxMuaKTC.Location = new System.Drawing.Point(3, 265);
		this.checkBoxMuaKTC.Name = "checkBoxMuaKTC";
		this.checkBoxMuaKTC.Size = new System.Drawing.Size(134, 17);
		this.checkBoxMuaKTC.TabIndex = 227;
		this.checkBoxMuaKTC.Text = "2c. Mua ở KTC, tab =>";
		this.checkBoxMuaKTC.UseVisualStyleBackColor = true;
		this.checkBoxMuaKTC.CheckedChanged += new System.EventHandler(checkBoxMuaKTC_CheckedChanged);
		this.comboBoxTabKTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxTabKTC.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTabKTC.FormattingEnabled = true;
		this.comboBoxTabKTC.Location = new System.Drawing.Point(145, 263);
		this.comboBoxTabKTC.Name = "comboBoxTabKTC";
		this.comboBoxTabKTC.Size = new System.Drawing.Size(150, 21);
		this.comboBoxTabKTC.TabIndex = 228;
		this.comboBoxTabKTC.SelectedIndexChanged += new System.EventHandler(comboBoxTabKTC_SelectedIndexChanged);
		this.buttonSuaNopVP.Location = new System.Drawing.Point(17, 395);
		this.buttonSuaNopVP.Name = "buttonSuaNopVP";
		this.buttonSuaNopVP.Size = new System.Drawing.Size(59, 25);
		this.buttonSuaNopVP.TabIndex = 229;
		this.buttonSuaNopVP.Text = "Sửa";
		this.buttonSuaNopVP.UseVisualStyleBackColor = true;
		this.buttonSuaNopVP.Click += new System.EventHandler(buttonSuaNopVP_Click);
		this.checkBoxTach.AutoSize = true;
		this.checkBoxTach.Location = new System.Drawing.Point(132, 426);
		this.checkBoxTach.Name = "checkBoxTach";
		this.checkBoxTach.Size = new System.Drawing.Size(163, 17);
		this.checkBoxTach.TabIndex = 230;
		this.checkBoxTach.Text = "Tách vật phẩm trước khi nộp";
		this.checkBoxTach.UseVisualStyleBackColor = true;
		this.checkBoxTach.CheckedChanged += new System.EventHandler(checkBoxTach_CheckedChanged);
		this.label4.AutoSize = true;
		this.label4.ForeColor = System.Drawing.Color.Indigo;
		this.label4.Location = new System.Drawing.Point(50, 225);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(91, 13);
		this.label4.TabIndex = 231;
		this.label4.Text = "_số lượng mua =>";
		this.checkBoxMuaKhiHet.AutoSize = true;
		this.checkBoxMuaKhiHet.ForeColor = System.Drawing.Color.Indigo;
		this.checkBoxMuaKhiHet.Location = new System.Drawing.Point(3, 289);
		this.checkBoxMuaKhiHet.Name = "checkBoxMuaKhiHet";
		this.checkBoxMuaKhiHet.Size = new System.Drawing.Size(189, 17);
		this.checkBoxMuaKhiHet.TabIndex = 232;
		this.checkBoxMuaKhiHet.Text = "2d. Chỉ mua khi hành trang còn <=";
		this.checkBoxMuaKhiHet.UseVisualStyleBackColor = true;
		this.checkBoxMuaKhiHet.CheckedChanged += new System.EventHandler(checkBoxMuaKhiHet_CheckedChanged);
		this.textBoxMuaKhicon.ForeColor = System.Drawing.Color.Black;
		this.textBoxMuaKhicon.Location = new System.Drawing.Point(229, 287);
		this.textBoxMuaKhicon.Name = "textBoxMuaKhicon";
		this.textBoxMuaKhicon.Size = new System.Drawing.Size(66, 20);
		this.textBoxMuaKhicon.TabIndex = 233;
		this.textBoxMuaKhicon.Text = "1";
		this.textBoxMuaKhicon.TextChanged += new System.EventHandler(textBoxMuaKhicon_TextChanged);
		this.checkBoxCoNhapSL.AutoSize = true;
		this.checkBoxCoNhapSL.ForeColor = System.Drawing.Color.MidnightBlue;
		this.checkBoxCoNhapSL.Location = new System.Drawing.Point(34, 178);
		this.checkBoxCoNhapSL.Name = "checkBoxCoNhapSL";
		this.checkBoxCoNhapSL.Size = new System.Drawing.Size(171, 17);
		this.checkBoxCoNhapSL.TabIndex = 234;
		this.checkBoxCoNhapSL.Text = "Có nhập số lượng sau khi click";
		this.checkBoxCoNhapSL.UseVisualStyleBackColor = true;
		this.checkBoxCoNhapSL.CheckedChanged += new System.EventHandler(checkBoxCoNhapSL_CheckedChanged);
		this.textBoxCoNhapSL.ForeColor = System.Drawing.Color.Black;
		this.textBoxCoNhapSL.Location = new System.Drawing.Point(229, 176);
		this.textBoxCoNhapSL.Name = "textBoxCoNhapSL";
		this.textBoxCoNhapSL.Size = new System.Drawing.Size(66, 20);
		this.textBoxCoNhapSL.TabIndex = 235;
		this.textBoxCoNhapSL.TextChanged += new System.EventHandler(textBoxCoNhapSL_TextChanged);
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(15, 169);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(15, 13);
		this.label5.TabIndex = 236;
		this.label5.Text = "|_";
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(15, 116);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(15, 13);
		this.label6.TabIndex = 237;
		this.label6.Text = "|_";
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(15, 224);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(15, 13);
		this.label7.TabIndex = 238;
		this.label7.Text = "|_";
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(122, 135);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(15, 13);
		this.label9.TabIndex = 240;
		this.label9.Text = "|_";
		this.textBox1.BackColor = System.Drawing.SystemColors.Control;
		this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.textBox1.Font = new System.Drawing.Font("Courier New", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBox1.ForeColor = System.Drawing.Color.SeaGreen;
		this.textBox1.Location = new System.Drawing.Point(145, 135);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(150, 17);
		this.textBox1.TabIndex = 241;
		this.textBox1.Text = ".";
		this.textBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(textBox1_MouseUp);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(294, 525);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.label9);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.comboBoxTabKTC);
		base.Controls.Add(this.textBoxCoNhapSL);
		base.Controls.Add(this.checkBoxCoNhapSL);
		base.Controls.Add(this.textBoxMuaKhicon);
		base.Controls.Add(this.checkBoxMuaKhiHet);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.checkBoxTach);
		base.Controls.Add(this.buttonSuaNopVP);
		base.Controls.Add(this.checkBoxMuaKTC);
		base.Controls.Add(this.textBoxSoluongNop);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.buttonXoa);
		base.Controls.Add(this.buttonThem);
		base.Controls.Add(this.comboBoxNop);
		base.Controls.Add(this.listView1);
		base.Controls.Add(this.checkBoxClickNpcNopVP);
		base.Controls.Add(this.checkBoxRuthettien);
		base.Controls.Add(this.linkLabelMuaPhaohoa);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.comboBoxMuaVP);
		base.Controls.Add(this.textBoxSoluongMua);
		base.Controls.Add(this.checkBoxCoMuaVatpham);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.labelTenac);
		base.Controls.Add(this.buttonDong);
		base.Controls.Add(this.buttonApdungAll);
		base.Controls.Add(this.comboBoxVatpham);
		base.Controls.Add(this.checkBoxDoithoaiTruoc);
		base.Controls.Add(this.checkBoxCosudungVatpham);
		base.Controls.Add(this.textBoxMenuVatpham);
		base.Controls.Add(this.label1);
		this.ForeColor = System.Drawing.Color.Navy;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormClickNPC";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "CLICK NPC";
		base.Load += new System.EventHandler(FormClickNPC_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (0 <= num)
		{
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		}
		int_1 = 0;
		int_2 = 0;
		bool_0 = false;
		bool_2 = false;
		string_0 = null;
	}

	private void FormClickNPC_Load(object sender, EventArgs e)
	{
		timer_0.Enabled = false;
		bool_2 = false;
		textBox1.Text = "+.+.+.+.+.";
		if (int_1 > 0 && int_2 > 0)
		{
			int num = int_1 - base.Width;
			int num2 = int_2;
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
		int num3 = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num3 < 0)
		{
			textBoxMenuVatpham.Enabled = false;
			checkBoxCosudungVatpham.Enabled = false;
			checkBoxDoithoaiTruoc.Enabled = false;
			comboBoxVatpham.Enabled = false;
			checkBoxClickNpcNopVP.Enabled = false;
			checkBoxCoMuaVatpham.Enabled = false;
			checkBoxRuthettien.Enabled = false;
			comboBoxTabKTC.Enabled = false;
			comboBoxMuaVP.Enabled = false;
			comboBoxNop.Enabled = false;
			checkBoxTach.Enabled = false;
			checkBoxMuaKhiHet.Enabled = false;
			textBoxMuaKhicon.Enabled = false;
			checkBoxMuaKTC.Enabled = false;
			textBoxSoluongMua.Enabled = false;
			checkBoxCoNhapSL.Enabled = false;
			textBoxCoNhapSL.Enabled = false;
			method_0(listView1, "Cần phải chọn ac để thiết lập|...");
			labelTenac.Text = "[Bạn chưa chọn ac nào cả ]";
		}
		else
		{
			CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num3];
			labelTenac.Text = "[ " + Class1.smethod_1(characterAccountConfig_.string_22, 1) + "]";
			checkBoxCosudungVatpham.Checked = characterAccountConfig_.int_13[0] > 0;
			checkBoxCoNhapSL.Checked = characterAccountConfig_.int_13[1] > 0;
			textBoxCoNhapSL.Text = characterAccountConfig_.int_13[2].ToString();
			if (characterAccountConfig_.string_1 != null && characterAccountConfig_.string_1 != string.Empty)
			{
				string item = Class1.smethod_1(characterAccountConfig_.string_1, 1);
				comboBoxVatpham.Items.Add(item);
				comboBoxVatpham.Text = item;
			}
			if (characterAccountConfig_.int_14 != null)
			{
				string text = null;
				for (int i = 0; i < characterAccountConfig_.int_14.Length; i++)
				{
					if (text != null)
					{
						text += ",";
					}
					text += characterAccountConfig_.int_14[i];
				}
				textBoxMenuVatpham.Text = text;
			}
			checkBoxDoithoaiTruoc.Checked = characterAccountConfig_.int_15 > 0;
			checkBoxClickNpcNopVP.Checked = characterAccountConfig_.int_16[0] > 0;
			checkBoxTach.Checked = characterAccountConfig_.int_16[1] > 0;
			checkBoxCoMuaVatpham.Checked = characterAccountConfig_.int_17[0] > 0;
			checkBoxRuthettien.Checked = characterAccountConfig_.int_17[1] > 0;
			checkBoxMuaKTC.Checked = characterAccountConfig_.int_17[2] > 0;
			checkBoxMuaKhiHet.Checked = characterAccountConfig_.int_17[3] > 0;
			textBoxMuaKhicon.Text = characterAccountConfig_.int_17[4].ToString();
			if (characterAccountConfig_.gstruct33_1.string_0 != null && characterAccountConfig_.gstruct33_1.string_0 != string.Empty)
			{
				string item2 = Class1.smethod_1(characterAccountConfig_.gstruct33_1.string_0, 1);
				comboBoxMuaVP.Items.Add(item2);
				comboBoxMuaVP.Text = item2;
			}
			textBoxSoluongMua.Text = characterAccountConfig_.gstruct33_1.int_4.ToString();
			string text2 = null;
			struct24_0 = Class89.smethod_1(characterAccountConfig_);
			if (struct24_0 != null)
			{
				for (int j = 0; j < struct24_0.Length; j++)
				{
					string text3 = Class1.smethod_1(struct24_0[j].string_0, 1);
					if (characterAccountConfig_.string_2 == struct24_0[j].string_0)
					{
						text2 = text3;
					}
					comboBoxTabKTC.Items.Add(text3);
				}
				if (text2 == null || text2 == string.Empty)
				{
					num3 = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
					if (0 <= num3)
					{
						Form1.characterAccountConfig_1[num3].string_2 = struct24_0[0].string_0;
					}
					text2 = Class1.smethod_1(struct24_0[0].string_0, 1);
				}
				comboBoxTabKTC.Text = text2;
			}
		}
		bool_2 = true;
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		bool_1 = true;
	}

	private void method_0(ListView listView_0, string string_1)
	{
		if (string_1 == null || string_1 == string.Empty)
		{
			return;
		}
		try
		{
			string[] array = string_1.Split('|');
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

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
			return;
		}
		if (bool_1)
		{
			bool_1 = false;
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (0 <= num && Form1.characterAccountConfig_1[num].gstruct33_0 != null)
			{
				listView1.Items.Clear();
				GStruct33[] gstruct33_ = Form1.characterAccountConfig_1[num].gstruct33_0;
				for (int i = 0; i < gstruct33_.Length; i++)
				{
					method_0(listView1, Class1.smethod_1(gstruct33_[i].string_0, 1) + "|" + gstruct33_[i].int_4);
				}
			}
		}
		if (!buttonApdungAll.Enabled)
		{
			buttonApdungAll.Enabled = true;
		}
	}

	private static int[] smethod_0(string string_1)
	{
		if (!(string_1 == string.Empty) && string_1 != null)
		{
			string[] array = string_1.Split(',', '.', ':', '/', '|', '=', '-', '+', ';');
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = Class11.smethod_11(array[i]);
			}
			return array2;
		}
		return null;
	}

	private void checkBoxCosudungVatpham_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_13[0] = Convert.ToByte(checkBoxCosudungVatpham.Checked);
			}
		}
	}

	private void textBoxMenuVatpham_TextChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_2)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			return;
		}
		string text = textBoxMenuVatpham.Text;
		int[] array = smethod_0(textBoxMenuVatpham.Text);
		Form1.characterAccountConfig_1[num].int_14 = array;
		if (array == null)
		{
			textBoxMenuVatpham.Text = string.Empty;
			textBox1.Text = string.Empty;
			return;
		}
		string text2 = text.Replace(" ", string.Empty);
		bool flag = text != text2;
		text = string.Empty;
		for (int i = 0; i < array.Length; i++)
		{
			text += "+_";
		}
		if (textBox1.Text != text)
		{
			textBox1.Text = text;
		}
		if (flag)
		{
			textBoxMenuVatpham.Text = text2;
		}
	}

	private void comboBoxVatpham_MouseDown(object sender, MouseEventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				method_1(Form1.characterAccountConfig_1[num], comboBoxVatpham);
			}
		}
	}

	private void comboBoxVatpham_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_2 || string_0 == null)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxVatpham.Text;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (text == Class1.smethod_1(string_0[i], 1))
			{
				Form1.characterAccountConfig_1[num].string_1 = string_0[i];
				break;
			}
		}
	}

	private void checkBoxDoithoaiTruoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_15 = Convert.ToByte(checkBoxDoithoaiTruoc.Checked);
			}
		}
	}

	private void buttonApdungAll_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0 || Form1.characterAccountConfig_1 == null || num < 0)
		{
			return;
		}
		buttonApdungAll.Enabled = false;
		for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
		{
			if (i == num)
			{
				continue;
			}
			Form1.characterAccountConfig_1[i].int_13 = null;
			if (Form1.characterAccountConfig_1[num].int_14 != null)
			{
				Form1.characterAccountConfig_1[i].int_13 = new int[Form1.characterAccountConfig_1[num].int_13.Length];
				for (int j = 0; j < Form1.characterAccountConfig_1[num].int_13.Length; j++)
				{
					Form1.characterAccountConfig_1[i].int_13[j] = Form1.characterAccountConfig_1[num].int_13[j];
				}
			}
			Form1.characterAccountConfig_1[i].string_1 = Form1.characterAccountConfig_1[num].string_1;
			Form1.characterAccountConfig_1[i].int_15 = Form1.characterAccountConfig_1[num].int_15;
			Form1.characterAccountConfig_1[i].int_14 = null;
			if (Form1.characterAccountConfig_1[num].int_14 != null)
			{
				Form1.characterAccountConfig_1[i].int_14 = new int[Form1.characterAccountConfig_1[num].int_14.Length];
				for (int k = 0; k < Form1.characterAccountConfig_1[num].int_14.Length; k++)
				{
					Form1.characterAccountConfig_1[i].int_14[k] = Form1.characterAccountConfig_1[num].int_14[k];
				}
			}
			Form1.characterAccountConfig_1[i].int_17 = null;
			if (Form1.characterAccountConfig_1[num].int_17 != null)
			{
				Form1.characterAccountConfig_1[i].int_17 = new int[Form1.characterAccountConfig_1[num].int_17.Length];
				for (int l = 0; l < Form1.characterAccountConfig_1[num].int_17.Length; l++)
				{
					Form1.characterAccountConfig_1[i].int_17[l] = Form1.characterAccountConfig_1[num].int_17[l];
				}
			}
			Form1.characterAccountConfig_1[i].gstruct33_1 = new GStruct33
			{
				string_0 = Form1.characterAccountConfig_1[num].gstruct33_1.string_0,
				int_4 = Form1.characterAccountConfig_1[num].gstruct33_1.int_4
			};
			Form1.characterAccountConfig_1[i].string_2 = Form1.characterAccountConfig_1[num].string_2;
			Form1.characterAccountConfig_1[i].int_16 = null;
			if (Form1.characterAccountConfig_1[num].int_16 != null)
			{
				Form1.characterAccountConfig_1[i].int_16 = new int[Form1.characterAccountConfig_1[num].int_16.Length];
				for (int m = 0; m < Form1.characterAccountConfig_1[i].int_16.Length; m++)
				{
					Form1.characterAccountConfig_1[i].int_16[m] = Form1.characterAccountConfig_1[num].int_16[m];
				}
			}
			Form1.characterAccountConfig_1[i].gstruct33_0 = null;
			if (Form1.characterAccountConfig_1[num].gstruct33_0 != null)
			{
				Form1.characterAccountConfig_1[i].gstruct33_0 = new GStruct33[Form1.characterAccountConfig_1[num].gstruct33_0.Length];
				for (int n = 0; n < Form1.characterAccountConfig_1[num].gstruct33_0.Length; n++)
				{
					ref GStruct33 reference = ref Form1.characterAccountConfig_1[i].gstruct33_0[n];
					reference = new GStruct33
					{
						string_0 = Form1.characterAccountConfig_1[num].gstruct33_0[n].string_0,
						int_4 = Form1.characterAccountConfig_1[num].gstruct33_0[n].int_4
					};
				}
			}
			Class56.smethod_13(Form1.characterAccountConfig_1[i]);
		}
	}

	private void buttonDong_Click(object sender, EventArgs e)
	{
		Close();
	}

	public static void smethod_1()
	{
		if (Form1.characterAccountConfig_1 == null)
		{
			return;
		}
		for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
		{
			if (!Form1.characterAccountConfig_1[i].bool_25)
			{
				continue;
			}
			for (int j = 0; j < 100; j++)
			{
				if (int_9 <= 0)
				{
					break;
				}
				Thread.Sleep(1);
			}
			int_9 = Form1.characterAccountConfig_1[i].int_136;
			new Thread(smethod_2).Start();
		}
	}

	public static void smethod_2()
	{
		int num = int_9;
		int_9 = 0;
		int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, num);
		if (num2 < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num2];
		int int_ = 0;
		byte[] array = new byte[4];
		uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_.int_137);
		uint num4 = Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_.int_137);
		uint num5 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_.int_137);
		uint num6 = num5 + num4 * Class56.memorySignatureScanConfig_15.uint_0;
		uint[] uint_ = new uint[2]
		{
			Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_.int_137),
			Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_.int_137)
		};
		uint uint_2 = characterAccountConfig_.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_.int_137, uint_2, array, 4, ref int_);
		int num7 = BitConverter.ToInt32(array, 0);
		if (num7 <= 1)
		{
			return;
		}
		int num8 = 0;
		uint num9 = 0u;
		long num10 = 0L;
		uint[] array2 = new uint[2];
		for (uint num11 = 1u; num11 < 256; num11++)
		{
			if (num7 <= num8)
			{
				break;
			}
			uint num12 = num5 + num11 * Class56.memorySignatureScanConfig_15.uint_0;
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, num12 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			num8++;
			Class24.ReadProcessMemory(characterAccountConfig_.int_137, num12 + Class56.memorySignatureScanConfig_52.uint_0, array, 4, ref int_);
			uint num13 = BitConverter.ToUInt32(array, 0);
			if (num13 == 3)
			{
				uint[] array3 = new uint[2];
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, array, 4, ref int_);
				array3[0] = BitConverter.ToUInt32(array, 0);
				Class24.ReadProcessMemory(characterAccountConfig_.int_137, num12 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, array, 4, ref int_);
				array3[1] = BitConverter.ToUInt32(array, 0);
				long num14 = Class64.smethod_18(uint_, array3);
				if (num9 == 0 || num14 < num10)
				{
					num10 = num14;
					array2[0] = array3[0];
					array2[1] = array3[1];
					num9 = num11;
				}
			}
		}
		if (num9 == 0)
		{
			return;
		}
		for (int i = 0; i < 10; i++)
		{
			uint_ = new uint[2]
			{
				Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_.int_137),
				Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_.int_137)
			};
			long num15 = Class64.smethod_18(uint_, array2);
			if (num15 <= 11500L)
			{
				break;
			}
			Class75.smethod_61(characterAccountConfig_, array2);
			Thread.Sleep(300);
		}
		array = BitConverter.GetBytes(num9);
		Class24.WriteProcessMemory(characterAccountConfig_.int_137, num6 + Class56.memorySignatureScanConfig_72.uint_0, array, 4, ref int_);
	}

	public static void smethod_3()
	{
		int int_ = int_10;
		int_10 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (num < 0)
				{
					break;
				}
				CharacterAccountConfig characterAccountConfig_ = Form1.characterAccountConfig_1[num];
				if (!flag)
				{
					if (Class75.smethod_3(characterAccountConfig_, Class75.uint_48, 4) > 0)
					{
						break;
					}
					Class75.smethod_2(characterAccountConfig_, Class75.uint_48, 1, 4);
					Class75.smethod_52(characterAccountConfig_, "<color=green><bclr=blue>ClickNPC b¾t ®Çu...");
					flag = true;
				}
				smethod_4(int_);
				Class75.smethod_2(characterAccountConfig_, Class75.uint_48, 0, 4);
				Class75.smethod_52(characterAccountConfig_, "<color=green><bclr=blue>ClickNPC kÕt thóc !");
				break;
			}
			catch
			{
				Thread.Sleep(300);
			}
		}
	}

	public static void smethod_4(int int_11)
	{
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int i = 0;
		int num4 = 0;
		uint[] uint_ = null;
		uint[] array = null;
		int num5 = -1;
		int int_12 = 0;
		byte[] array2 = new byte[4];
		uint num6 = 0u;
		uint[] array3 = null;
		bool flag = true;
		long long_ = 0L;
		GStruct33[] array4 = null;
		while (true)
		{
			IL_0fb4:
			num2--;
			Thread.Sleep(10);
			if (Class11.bool_0)
			{
				break;
			}
			if (num2 <= 0)
			{
				num = Class87.smethod_3(Form1.characterAccountConfig_1, int_11);
				if (num < 0 || !Form1.characterAccountConfig_1[num].bool_25)
				{
					break;
				}
				if (Form1.characterAccountConfig_1[num].int_9 == null)
				{
					Form1.characterAccountConfig_1[num].int_9 = new int[3] { 2, 1, 1 };
				}
				if (Form1.characterAccountConfig_1[num].int_7 == null)
				{
					Form1.characterAccountConfig_1[num].int_7 = new int[2] { 0, 3 };
				}
				characterAccountConfig = Form1.characterAccountConfig_1[num];
				Class75.smethod_2(characterAccountConfig, Class75.uint_49, characterAccountConfig.int_10, 4);
				num2 = 15;
			}
			if (Class75.smethod_3(characterAccountConfig, Class75.uint_48, 4) == 0)
			{
				break;
			}
			int num7 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig.int_137);
			if (num5 >= 0)
			{
				if (num5 != num7)
				{
					break;
				}
			}
			else
			{
				num5 = num7;
			}
			uint num8 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.int_137);
			uint num9 = Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig.int_137);
			uint num10 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig.int_137);
			num6 = num10 + num9 * Class56.memorySignatureScanConfig_15.uint_0;
			int num11 = (int)Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig.int_137);
			int num12 = Class89.smethod_39(characterAccountConfig);
			int num13;
			bool flag2;
			if (num11 != 0 && num12 > 1)
			{
				if (Class89.smethod_12(characterAccountConfig) == 1)
				{
					Thread.Sleep(100);
					continue;
				}
				num13 = Class75.smethod_3(characterAccountConfig, Class75.uint_49, 4);
				if ((flag2 = characterAccountConfig.int_17[0] > 0 && characterAccountConfig.gstruct33_1.int_4 > 0 && characterAccountConfig.gstruct33_1.string_0 != null && characterAccountConfig.gstruct33_1.string_0 != string.Empty) && !flag && characterAccountConfig.int_17[1] > 0)
				{
					if (characterAccountConfig.string_15 != null && characterAccountConfig.string_15 != string.Empty)
					{
						uint num14 = Class11.smethod_12(characterAccountConfig.string_15);
						if (num14 != 0)
						{
							Class75.smethod_117(characterAccountConfig, num14);
							Thread.Sleep(100);
						}
					}
					uint num15 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.int_137) + Class56.memorySignatureScanConfig_12.uint_0 + Class56.memorySignatureScanConfig_75.uint_0;
					long num16 = Class24.smethod_30(num15 + Class56.memorySignatureScanConfig_74.uint_0, characterAccountConfig.int_137);
					if (num16 > 0L)
					{
						Class75.smethod_37(characterAccountConfig, (uint)num16);
					}
					flag = true;
				}
				if (flag2 && characterAccountConfig.int_17[2] > 0 && characterAccountConfig.string_2 != null && characterAccountConfig.string_2 != string.Empty)
				{
					bool flag3 = true;
					if (characterAccountConfig.int_17[3] > 0)
					{
						int num17 = Class85.smethod_31(characterAccountConfig, characterAccountConfig.gstruct33_1.string_0, 3, bool_3: false, bool_4: true);
						flag3 = num17 <= characterAccountConfig.int_17[4];
					}
					if (flag3)
					{
						Class36.smethod_2(characterAccountConfig, characterAccountConfig.string_2, characterAccountConfig.gstruct33_1.string_0, characterAccountConfig.gstruct33_1.int_4);
					}
				}
				array4 = null;
				if (characterAccountConfig.int_16[0] > 0 && characterAccountConfig.int_16[1] > 0 && characterAccountConfig.gstruct33_0 != null)
				{
					array4 = new GStruct33[characterAccountConfig.gstruct33_0.Length];
					for (int j = 0; j < characterAccountConfig.gstruct33_0.Length; j++)
					{
						uint[] array5 = Class85.smethod_33(characterAccountConfig, characterAccountConfig.gstruct33_0[j].string_0, characterAccountConfig.gstruct33_0[j].int_4);
						if (array5 != null)
						{
							ref GStruct33 reference = ref array4[j];
							reference = new GStruct33
							{
								string_0 = characterAccountConfig.gstruct33_0[j].string_0,
								uint_0 = array5[0],
								uint_1 = array5[1],
								uint_2 = array5[2],
								uint_3 = array5[3],
								uint_4 = array5[4],
								uint_5 = array5[5],
								int_4 = (int)array5[8],
								int_5 = (int)array5[9]
							};
						}
					}
				}
				if (characterAccountConfig.int_13[0] > 0)
				{
					if (characterAccountConfig.string_1 == null || characterAccountConfig.string_1 == string.Empty)
					{
						if (Class11.smethod_28(long_) > 15000L)
						{
							Class75.smethod_52(characterAccountConfig, "<color=blue>=> ClickNPC: B¹n ch\u00ada lÊy tªn vËt phÈm cÇn sö dông...");
							long_ = Class11.smethod_27();
						}
						continue;
					}
					if (array3 != null)
					{
						string text = Class85.smethod_8(characterAccountConfig, array3[0], 0u, bool_3: false, characterAccountConfig.string_1.Length + 4);
						if (text != characterAccountConfig.string_1)
						{
							array3 = null;
						}
					}
					if (array3 == null)
					{
						array3 = Class85.smethod_29(characterAccountConfig, characterAccountConfig.string_1);
					}
					if (array3 == null)
					{
						if (Class11.smethod_28(long_) > 15000L)
						{
							Class75.smethod_52(characterAccountConfig, "<color=blue>=> ClickNPC: Kh«ng t×m thÊy vËt phÈm <" + characterAccountConfig.string_1 + ">...");
							long_ = Class11.smethod_27();
						}
						continue;
					}
				}
				if (Form1.int_8 > 0)
				{
					if (characterAccountConfig.string_0 != null && !(characterAccountConfig.string_0 == string.Empty))
					{
						if (num4 > 0)
						{
							string text2 = Class3.smethod_16(characterAccountConfig, num4, ref uint_, characterAccountConfig.string_0.Length + 2);
							if (text2 == characterAccountConfig.string_0)
							{
								goto IL_0650;
							}
						}
						num4 = Class3.smethod_15(characterAccountConfig, characterAccountConfig.string_0, ref uint_);
						if (num4 <= 0)
						{
							if (Class11.smethod_28(long_) > 15000L)
							{
								Class75.smethod_52(characterAccountConfig, "<color=blue>=> ClickNPC: Kh«ng t×m thÊy npc <" + characterAccountConfig.string_0 + ">...");
								long_ = Class11.smethod_27();
							}
							continue;
						}
						goto IL_0650;
					}
					if (Class11.smethod_28(long_) > 15000L)
					{
						Class75.smethod_52(characterAccountConfig, "<color=blue>=> ClickNPC: b¹n ch\u00ada lÊy tªn npc...");
						long_ = Class11.smethod_27();
					}
					continue;
				}
				goto IL_0727;
			}
			num4 = 0;
			array3 = null;
			flag = false;
			continue;
			IL_0a9e:
			int[] array6;
			array6[0] = 1;
			if (Form1.int_8 <= 0 || num4 <= 0)
			{
				num4 = 0;
			}
			else
			{
				Class24.WriteProcessMemory(characterAccountConfig.int_137, num6 + Class56.memorySignatureScanConfig_72.uint_0, BitConverter.GetBytes(num4), 4, ref int_12);
				Thread.Sleep(10);
				if (characterAccountConfig.int_8 > 0)
				{
					i = 0;
					int num18 = 0;
					while (i < 1000 && Class95.smethod_0(characterAccountConfig) < 0)
					{
						i++;
						Thread.Sleep(1);
						if (Class95.Class92.smethod_4(characterAccountConfig))
						{
							Class95.Class92.smethod_5(characterAccountConfig);
							num18 = -1;
						}
					}
					if (num18 == 0 && Class95.Class92.smethod_4(characterAccountConfig))
					{
						Class95.Class92.smethod_5(characterAccountConfig);
					}
					if (0 <= Class95.smethod_0(characterAccountConfig) || Class95.smethod_1(characterAccountConfig) > 0)
					{
						int num19 = num13 - i;
						if (num19 < 10)
						{
							num19 = 10;
						}
						Thread.Sleep(1 + num19);
						for (int k = 0; k < characterAccountConfig.int_9.Length; k++)
						{
							if (characterAccountConfig.int_9[k] > 0)
							{
								Class95.smethod_5(characterAccountConfig, characterAccountConfig.int_9[k] - 1);
								Thread.Sleep(1 + num13);
							}
						}
					}
				}
				i = 0;
				while (int_5 > 0 && int_6 > 0 && i < 1000)
				{
					if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) == 0)
					{
						Thread.Sleep(1);
						i++;
						continue;
					}
					Class47.smethod_5(characterAccountConfig, int_6.ToString(), bool_0: true);
					break;
				}
			}
			goto IL_0919;
			IL_0919:
			if (array6[0] > 0)
			{
				if (array6[1] > 0)
				{
					if (flag2 && characterAccountConfig.int_17[2] <= 0)
					{
						bool flag4 = true;
						if (characterAccountConfig.int_17[3] > 0)
						{
							int num20 = Class85.smethod_31(characterAccountConfig, characterAccountConfig.gstruct33_1.string_0, 3, bool_3: false, bool_4: true);
							flag4 = num20 <= characterAccountConfig.int_17[4];
						}
						if (flag4)
						{
							for (; i < 1000; i++)
							{
								if (Class47.smethod_8(characterAccountConfig))
								{
									break;
								}
								Thread.Sleep(1);
							}
							smethod_5(characterAccountConfig, characterAccountConfig.gstruct33_1.string_0, characterAccountConfig.gstruct33_1.int_4);
						}
					}
					if (characterAccountConfig.int_16[0] > 0 && characterAccountConfig.gstruct33_0 != null && Class47.smethod_8(characterAccountConfig))
					{
						uint num21 = 3u;
						uint num22 = 12u;
						for (int l = 0; l < characterAccountConfig.gstruct33_0.Length; l++)
						{
							string text3 = characterAccountConfig.gstruct33_0[l].string_0;
							int num23 = characterAccountConfig.gstruct33_0[l].int_4;
							int num24 = 0;
							bool flag5 = false;
							if (array4 != null && l < array4.Length && array4[l].uint_0 != 0 && array4[l].string_0 == text3 && array4[l].int_4 <= num23)
							{
								while (!Class11.bool_0 && num24 <= 60)
								{
									uint uint_2 = array4[l].uint_4;
									uint uint_3 = array4[l].uint_5;
									uint[] array7 = Class85.smethod_26(characterAccountConfig, num22, uint_2, uint_3);
									if (array7 == null)
									{
										break;
									}
									uint uint_4 = array4[l].uint_2;
									uint uint_5 = array4[l].uint_3;
									uint num25 = num8 + Class56.memorySignatureScanConfig_97.uint_0;
									uint num26 = num25 + array4[l].uint_0 * 20;
									i = 0;
									while (!Class11.bool_0)
									{
										Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 1, ref int_12);
										int num27 = array2[0];
										if (num27 > 0)
										{
											break;
										}
										if (i % 30 == 0)
										{
											Class75.smethod_46(characterAccountConfig, uint_4, uint_5, num21, uint_4, uint_5, num21);
										}
										if (i > 100)
										{
											break;
										}
										Thread.Sleep(10);
										i++;
									}
									i = 0;
									while (!Class11.bool_0)
									{
										Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 1, ref int_12);
										if (array2[0] == 0)
										{
											break;
										}
										Class24.ReadProcessMemory(characterAccountConfig.int_137, num26 + Class56.memorySignatureScanConfig_99.uint_0 * 4, array2, 4, ref int_12);
										if (BitConverter.ToInt32(array2, 0) == 0)
										{
											break;
										}
										if (i % 30 == 0)
										{
											Class75.smethod_46(characterAccountConfig, array7[0], array7[1], num22, array7[0], array7[1], num22);
										}
										if (i > 100)
										{
											break;
										}
										i++;
										Thread.Sleep(10);
									}
									Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 1, ref int_12);
									if (array2[0] <= 0)
									{
										if (num23 <= 1)
										{
											break;
										}
										int num28 = Class85.smethod_31(characterAccountConfig, text3, (int)num22, bool_3: true, bool_4: true);
										if (num23 <= num28)
										{
											break;
										}
										uint[] array8 = Class85.smethod_33(characterAccountConfig, text3, num23 - num28);
										if (array8 == null)
										{
											break;
										}
										array4[l].uint_0 = array8[0];
										array4[l].uint_1 = array8[1];
										array4[l].uint_2 = array8[2];
										array4[l].uint_3 = array8[3];
										array4[l].int_4 = (int)array8[8];
										array4[l].int_5 = (int)array8[9];
										num24++;
										continue;
									}
									Class75.smethod_46(characterAccountConfig, uint_4, uint_5, num21, uint_4, uint_5, num21);
									for (i = 0; i < 30; i++)
									{
										Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_123.uint_0, array2, 1, ref int_12);
										if (array2[0] == 0)
										{
											break;
										}
										Thread.Sleep(10);
									}
									break;
								}
								flag5 = true;
							}
							if (!flag5)
							{
								Class47.smethod_16(characterAccountConfig, num21, num22, text3, num23, bool_0: true);
							}
						}
						Class75.smethod_110(characterAccountConfig);
						Thread.Sleep(300);
					}
					long long_2 = Class11.smethod_27();
					while (true)
					{
						i = 0;
						while (Class95.Class92.smethod_4(characterAccountConfig) && i < 10)
						{
							Class24.smethod_4(characterAccountConfig.uint_4, 32u);
							Thread.Sleep(10);
							i++;
						}
						if (Class95.smethod_1(characterAccountConfig) > 0)
						{
							Class95.smethod_8(characterAccountConfig, num13);
						}
						if (int_7 <= 0 || Class11.smethod_28(long_2) >= int_8)
						{
							break;
						}
						Thread.Sleep(10);
					}
					if (num3 < 2147483646)
					{
						num3++;
					}
					if (characterAccountConfig.int_7[0] != 0 && num3 >= characterAccountConfig.int_7[1])
					{
						break;
					}
					continue;
				}
				goto IL_075a;
			}
			goto IL_0a9e;
			IL_0650:
			int num29 = 0;
			while (num29 < 30)
			{
				if (Class89.smethod_12(characterAccountConfig) != 1)
				{
					array = new uint[2]
					{
						Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig.int_137),
						Class24.smethod_30(num6 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig.int_137)
					};
					if (Class64.smethod_18(array, uint_) < 11500L)
					{
						break;
					}
					Class75.smethod_61(characterAccountConfig, uint_);
					Thread.Sleep(300);
					num29++;
					continue;
				}
				goto IL_0fb4;
			}
			goto IL_0727;
			IL_075a:
			array6[1] = 1;
			if (characterAccountConfig.int_13[0] > 0 && array3 != null)
			{
				Class75.smethod_43(characterAccountConfig, array3[0], (int)array3[2], (int)array3[3]);
				Thread.Sleep(10);
				if (characterAccountConfig.int_14 != null)
				{
					i = 0;
					int num30 = 0;
					while (i < 1000 && Class95.smethod_0(characterAccountConfig) < 0)
					{
						i++;
						Thread.Sleep(1);
						if (Class95.Class92.smethod_4(characterAccountConfig))
						{
							Class95.Class92.smethod_5(characterAccountConfig);
							num30 = -1;
						}
					}
					if (num30 == 0 && Class95.Class92.smethod_4(characterAccountConfig))
					{
						Class95.Class92.smethod_5(characterAccountConfig);
					}
					if (0 <= Class95.smethod_0(characterAccountConfig) || Class95.smethod_1(characterAccountConfig) > 0)
					{
						int num31 = num13 - i;
						if (num31 < 10)
						{
							num31 = 10;
						}
						Thread.Sleep(1 + num31);
						for (int m = 0; m < characterAccountConfig.int_14.Length; m++)
						{
							if (characterAccountConfig.int_14[m] > 0)
							{
								Class95.smethod_5(characterAccountConfig, characterAccountConfig.int_14[m] - 1);
								Thread.Sleep(1 + num13);
							}
						}
					}
					i = 0;
					if (characterAccountConfig.int_13[1] <= 0)
					{
						if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) != 0)
						{
							Class47.smethod_5(characterAccountConfig, "0", bool_0: true);
						}
					}
					else
					{
						if (characterAccountConfig.int_13[2] <= 0)
						{
							characterAccountConfig.int_13[2] = 0;
						}
						for (; i < 1000; i++)
						{
							if (Class24.smethod_30(characterAccountConfig.uint_7 + Class56.memorySignatureScanConfig_172.uint_0, characterAccountConfig.int_137) == 0)
							{
								Thread.Sleep(1);
								continue;
							}
							Class47.smethod_5(characterAccountConfig, characterAccountConfig.int_13[2].ToString(), bool_0: true);
							break;
						}
					}
				}
			}
			else
			{
				array3 = null;
			}
			goto IL_0919;
			IL_0727:
			int[] array9 = new int[2];
			array6 = array9;
			if (characterAccountConfig.int_15 <= 0)
			{
				goto IL_075a;
			}
			goto IL_0a9e;
		}
	}

	public static void smethod_5(CharacterAccountConfig characterAccountConfig_0, string string_1, int int_11)
	{
		int num = 0;
		int num2 = -1;
		GStruct1[] array = null;
		string text = string_1.Trim().ToUpper();
		int num3 = 0;
		bool flag = false;
		int num4;
		while (true)
		{
			num4 = Class87.smethod_3(Form1.characterAccountConfig_1, characterAccountConfig_0.int_136);
			if (Class11.bool_0 || num4 < 0)
			{
				break;
			}
			characterAccountConfig_0 = Form1.characterAccountConfig_1[num4];
			if (flag)
			{
				if (!characterAccountConfig_0.bool_8)
				{
					break;
				}
			}
			else
			{
				Form1.characterAccountConfig_1[num4].bool_8 = true;
				flag = true;
			}
			int num5 = int_11 - Class85.smethod_32(characterAccountConfig_0, string_1);
			if (num5 <= 0)
			{
				break;
			}
			int num6 = Class85.smethod_25(characterAccountConfig_0);
			if (num6 <= 0)
			{
				if (num > 0)
				{
					break;
				}
				int num7 = 0;
				Class75.smethod_2(characterAccountConfig_0, Class75.uint_21, 3, 4);
				while (!Class11.bool_0 && Class75.smethod_3(characterAccountConfig_0, Class75.uint_21, 4) == 3 && num7 < 300)
				{
					Thread.Sleep(100);
					num7++;
				}
				num = 1;
				continue;
			}
			num = 0;
			if (array == null)
			{
				array = Class19.smethod_1(characterAccountConfig_0);
				if (array == null)
				{
					break;
				}
			}
			if (num2 <= 0)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (text == array[i].string_0.Trim().ToUpper())
					{
						num2 = array[i].int_0;
						break;
					}
				}
				if (num2 < 0)
				{
					break;
				}
			}
			int int_12 = 0;
			string empty = string.Empty;
			uint num8 = Class24.smethod_30(Class56.memorySignatureScanConfig_165.uint_0, characterAccountConfig_0.int_137);
			byte[] array2 = new byte[80];
			byte[] array3 = new byte[4];
			int num9 = Class85.smethod_4(characterAccountConfig_0);
			if (num5 > 60)
			{
				num5 = 60;
			}
			for (int j = 0; j < num5; j++)
			{
				Class75.smethod_41(characterAccountConfig_0, num2);
				Thread.Sleep(8 + Form1.int_118);
				if ((j == 0 || j % 8 != 0) && j + 1 != num5)
				{
					continue;
				}
				int num10 = Class85.smethod_4(characterAccountConfig_0);
				if (num10 != num9)
				{
					num9 = num10;
					num3 = 0;
				}
				else
				{
					num3++;
					if (num3 > 10)
					{
						goto end_IL_0018;
					}
				}
				try
				{
					num4 = Class87.smethod_3(Form1.characterAccountConfig_1, characterAccountConfig_0.int_136);
					if (!Class11.bool_0 && num4 >= 0 && Form1.characterAccountConfig_1[num4].bool_25)
					{
						goto IL_02f3;
					}
				}
				catch
				{
					goto IL_02f3;
				}
				goto end_IL_0018;
				IL_02bd:
				Class55.smethod_0(characterAccountConfig_0);
				if (Class11.smethod_1(empty, "ho¶ng trèng") > 0)
				{
					break;
				}
				if (Class11.smethod_1(empty, "kh«ng ®") > 0)
				{
					int num11 = 0;
					Class75.smethod_2(characterAccountConfig_0, Class75.uint_21, 3, 4);
					while (!Class11.bool_0 && Class75.smethod_3(characterAccountConfig_0, Class75.uint_21, 4) == 3 && num11 < 3000)
					{
						Thread.Sleep(10);
						num11++;
					}
					goto end_IL_0018;
				}
				continue;
				IL_02f3:
				uint num12 = Class24.smethod_30(num8 + Class56.memorySignatureScanConfig_167.uint_0, characterAccountConfig_0.int_137);
				if (num12 == 0)
				{
					continue;
				}
				for (uint num13 = 0u; num13 < 2; num13++)
				{
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num12 + num13 * 4, array3, 4, ref int_12);
					uint num14 = BitConverter.ToUInt32(array3, 0);
					if (num14 == 0)
					{
						continue;
					}
					Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num14, array2, array2.Length, ref int_12);
					empty = Class1.smethod_3(array2);
					if (!(empty != string.Empty))
					{
						continue;
					}
					goto IL_02bd;
				}
			}
			continue;
			end_IL_0018:
			break;
		}
		num4 = Class87.smethod_3(Form1.characterAccountConfig_1, characterAccountConfig_0.int_136);
		if (0 <= num4)
		{
			Form1.characterAccountConfig_1[num4].bool_8 = false;
		}
	}

	private void checkBoxCoMuaVatpham_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_17[0] = Convert.ToByte(checkBoxCoMuaVatpham.Checked);
			}
		}
	}

	private void textBoxSoluongMua_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].gstruct33_1.int_4 = Class11.smethod_11(textBoxSoluongMua.Text);
			}
		}
	}

	private void method_1(CharacterAccountConfig characterAccountConfig_0, ComboBox comboBox_0)
	{
		bool_2 = false;
		string_0 = Class85.smethod_34(characterAccountConfig_0, null, 0);
		comboBox_0.Items.Clear();
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				string item = Class1.smethod_1(string_0[i], 1);
				comboBox_0.Items.Add(item);
			}
		}
		Thread.Sleep(10);
		bool_2 = true;
	}

	private void comboBoxMuaVP_MouseDown(object sender, MouseEventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				method_1(Form1.characterAccountConfig_1[num], comboBoxMuaVP);
			}
		}
	}

	private void comboBoxMuaVP_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_2 || string_0 == null)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxMuaVP.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_0.Length)
			{
				if (text == Class1.smethod_1(string_0[num2], 1))
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		Form1.characterAccountConfig_1[num].gstruct33_1.string_0 = string_0[num2];
	}

	private void linkLabelMuaPhaohoa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "https://youtu.be/qdrw1B2yHFc";
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
		string string_ = "Xem video hướng dẫn tại: " + Class56.string_7 + text;
		FormTip.smethod_0(Form1.string_49, string_, 600000, 250, 80);
	}

	private void checkBoxRuthettien_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_17[1] = Convert.ToByte(checkBoxRuthettien.Checked);
			}
		}
	}

	private void checkBoxClickNpcNopVP_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_16[0] = Convert.ToByte(checkBoxClickNpcNopVP.Checked);
			}
		}
	}

	private void checkBoxMuaKTC_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_17[2] = Convert.ToByte(checkBoxMuaKTC.Checked);
			}
		}
	}

	private void comboBoxTabKTC_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_2 || struct24_0 == null)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTabKTC.Text;
		for (int i = 0; i < struct24_0.Length; i++)
		{
			if (text == Class1.smethod_1(struct24_0[i].string_0, 1))
			{
				Form1.characterAccountConfig_1[num].string_2 = struct24_0[i].string_0;
				break;
			}
		}
	}

	private void comboBoxNop_MouseDown(object sender, MouseEventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				method_1(Form1.characterAccountConfig_1[num], comboBoxNop);
			}
		}
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_2 || string_0 == null)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			return;
		}
		string text = null;
		string text2 = comboBoxNop.Text;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (text2 == Class1.smethod_1(string_0[i], 1))
			{
				text = string_0[i];
				break;
			}
		}
		if (text != null && !(text == string.Empty))
		{
			int num2 = Class11.smethod_11(textBoxSoluongNop.Text);
			method_0(listView1, Class1.smethod_1(text, 1) + "|" + num2);
			if (Form1.characterAccountConfig_1[num].gstruct33_0 != null)
			{
				Array.Resize(ref Form1.characterAccountConfig_1[num].gstruct33_0, Form1.characterAccountConfig_1[num].gstruct33_0.Length + 1);
			}
			else
			{
				Form1.characterAccountConfig_1[num].gstruct33_0 = new GStruct33[1];
			}
			ref GStruct33 reference = ref Form1.characterAccountConfig_1[num].gstruct33_0[Form1.characterAccountConfig_1[num].gstruct33_0.Length - 1];
			reference = new GStruct33
			{
				string_0 = text,
				int_4 = num2
			};
		}
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		if (listView1.SelectedIndices.Count == 0)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			return;
		}
		if (listView1.Items.Count != 0 && Form1.characterAccountConfig_1[num].gstruct33_0 != null && Form1.characterAccountConfig_1[num].gstruct33_0.Length == listView1.Items.Count)
		{
			int num2 = 0;
			int num3 = listView1.SelectedIndices[0];
			for (int i = 0; i < Form1.characterAccountConfig_1[num].gstruct33_0.Length; i++)
			{
				if (i != num3)
				{
					Form1.characterAccountConfig_1[num].gstruct33_0[num2].string_0 = Form1.characterAccountConfig_1[num].gstruct33_0[i].string_0;
					Form1.characterAccountConfig_1[num].gstruct33_0[num2].int_4 = Form1.characterAccountConfig_1[num].gstruct33_0[i].int_4;
					num2++;
				}
			}
			if (num2 == 0)
			{
				listView1.Items.Clear();
				Form1.characterAccountConfig_1[num].gstruct33_0 = null;
			}
			else if (num2 < Form1.characterAccountConfig_1[num].gstruct33_0.Length)
			{
				Array.Resize(ref Form1.characterAccountConfig_1[num].gstruct33_0, num2);
				listView1.Items.RemoveAt(num3);
				if (listView1.Items.Count <= num3 && num3 > 0)
				{
					num3 = listView1.Items.Count - 1;
				}
				listView1.Items[num3].Selected = true;
				listView1.Items[num3].Focused = true;
			}
		}
		else
		{
			listView1.Items.Clear();
			Form1.characterAccountConfig_1[num].gstruct33_0 = null;
		}
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView1.SelectedIndices.Count != 0)
		{
			int index = listView1.SelectedIndices[0];
			string item = listView1.Items[index].SubItems[0].Text;
			comboBoxNop.Items.Clear();
			comboBoxNop.Items.Add(item);
			comboBoxNop.Text = item;
			textBoxSoluongNop.Text = listView1.Items[index].SubItems[1].Text;
		}
	}

	private void buttonSuaNopVP_Click(object sender, EventArgs e)
	{
		if (listView1.SelectedIndices.Count == 0)
		{
			return;
		}
		int num = listView1.SelectedIndices[0];
		int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num2 < 0 || Form1.characterAccountConfig_1[num2].gstruct33_0 == null || Form1.characterAccountConfig_1[num2].gstruct33_0.Length <= num)
		{
			return;
		}
		string text = Class1.smethod_1(Form1.characterAccountConfig_1[num2].gstruct33_0[num].string_0, 1);
		if (text != listView1.Items[num].SubItems[0].Text)
		{
			return;
		}
		int num3 = Class11.smethod_11(textBoxSoluongNop.Text);
		Form1.characterAccountConfig_1[num2].gstruct33_0[num].int_4 = num3;
		listView1.Items[num].SubItems[1].Text = num3.ToString();
		string text2 = null;
		string text3 = comboBoxNop.Text;
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (text3 == Class1.smethod_1(string_0[i], 1))
				{
					text2 = string_0[i];
					break;
				}
			}
		}
		if (text2 != null)
		{
			Form1.characterAccountConfig_1[num2].gstruct33_0[num].string_0 = text2;
			listView1.Items[num].SubItems[0].Text = text3;
		}
	}

	private void checkBoxTach_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_16[1] = Convert.ToByte(checkBoxTach.Checked);
			}
		}
	}

	private void checkBoxMuaKhiHet_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_17[3] = Convert.ToByte(checkBoxMuaKhiHet.Checked);
			}
		}
	}

	private void textBoxMuaKhicon_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_17[4] = Class11.smethod_11(textBoxMuaKhicon.Text);
			}
		}
	}

	private void checkBoxCoNhapSL_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_13[1] = Convert.ToByte(checkBoxCoNhapSL.Checked);
			}
		}
	}

	private void textBoxCoNhapSL_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_2)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Form1.characterAccountConfig_1[num].int_13[2] = Class11.smethod_11(textBoxCoNhapSL.Text);
			}
		}
	}

	private void textBox1_MouseUp(object sender, MouseEventArgs e)
	{
		int selectionStart = textBox1.SelectionStart;
		int length = textBox1.Text.Length;
		if (selectionStart == 0)
		{
			_ = textBox1.Text;
		}
		else if (selectionStart == length)
		{
			_ = textBox1.Text;
		}
		else
		{
			textBox1.Text.Substring(0, selectionStart);
			textBox1.Text.Substring(selectionStart);
		}
		int num = selectionStart / 2;
		int num2 = 1;
		if (selectionStart % 2 != 0)
		{
			num2 = -1;
		}
		int[] array = smethod_0(textBoxMenuVatpham.Text);
		if (array == null)
		{
			textBoxMenuVatpham.Text = string.Empty;
			textBox1.Text = string.Empty;
		}
		else
		{
			if (array.Length <= num)
			{
				return;
			}
			array[num] += num2;
			if (array[num] < 0)
			{
				return;
			}
			string text = string.Empty;
			for (int i = 0; i < array.Length; i++)
			{
				if (text != null && text != string.Empty)
				{
					text += ",";
				}
				text += array[i];
			}
			textBoxMenuVatpham.Text = text;
			textBoxMenuVatpham.Focus();
			textBoxMenuVatpham.SelectionStart = num * 2 + 1;
			textBoxMenuVatpham.SelectionLength = 0;
		}
	}
}
