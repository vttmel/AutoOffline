using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns100;
using ns107;
using ns11;
using ns121;
using ns131;
using ns138;
using ns146;
using ns23;
using ns3;
using ns34;
using ns36;
using ns42;
using ns53;
using ns63;
using ns68;
using ns73;
using ns74;
using ns75;
using ns83;
using ns84;
using ns88;
using ns9;

namespace ns130;

public class FormRauria : Form
{
	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private Label label8;

	private CheckBox checkBoxAcChihuy;

	private CheckBox checkBoxAcChinhNghelenh;

	private Button buttonHelp;

	private CheckBox checkBoxSuado;

	private CheckBox checkBoxDoiPKTheoAccChinh;

	private CheckBox checkBoxTroLaiDiemcu;

	private Label label15;

	private TextBox textBoxKhoangCachlenNgua;

	private NumericUpDown numericUpDownKhongdanhCapnho;

	private CheckBox checkBoxKhongdanhCapnho;

	private Label labelBoqua;

	private CheckBox checkBoxBaoCuusat;

	private CheckBox checkBoxKhongChaybo;

	private CheckBox checkBoxKhongDanhAccCungbang;

	private Button buttonThietlapSuado;

	private CheckBox checkBoxTHP_Smdb;

	private Label labelLienthongGiaithich;

	private CheckBox checkBoxBaoCuusatPhucan;

	private Button buttonCacChucNangDkTuxa;

	private CheckBox checkBoxXuongngua;

	private Button buttonDanhsachMayphu;

	private Label label3;

	private CheckBox checkBoxRoom;

	private CheckBox checkBoxKhoaChatmat;

	private NumericUpDown numericUpDownPassword;

	private CheckBox checkBoxPassword;

	private CheckBox checkBoxKhongdanhBang;

	private CheckBox checkBoxLuonDanhbang;

	private ListView listViewKhongDanh;

	private ColumnHeader columnHeader_0;

	private ListView listViewLuonDanh;

	private ColumnHeader columnHeader_1;

	private CheckBox checkBoxKhongdanhAc;

	private ListView listViewKhongdanhAc;

	private ColumnHeader columnHeader_2;

	private ComboBox comboBoxKhongdanhAc;

	private ComboBox comboBoxKhongDanh;

	private ComboBox comboBoxLuonDanh;

	private CheckBox checkBoxDanhDenchet;

	private TextBox textBoxTiepCan;

	private Label label2;

	private Label labelTiepcan;

	private TextBox textBoxTen;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private GroupBox groupBox1;

	private TabPage tabPageLienMay;

	private ProgressBar progressBar1;

	private RichTextBox richTextBoxStatus;

	private ComboBox comboBoxConnect;

	private GroupBox groupBoxConnect;

	private TextBox textBoxConnectPass;

	private Label label4;

	private Label label6;

	private TextBox textBoxIPConnect;

	private GroupBox groupBoxHientai;

	private Label label1;

	private Label label5;

	private Button buttonRandom;

	private TextBox textBoxPassServer;

	private Button buttonBatdau;

	private Button buttonXoa;

	private Button buttonKetthuc;

	private TabControl tabControlKeoLienmay;

	private TabPage tabPage4;

	private TabPage tabPage5;

	private Label label10;

	private Label label11;

	private TextBox textBoxKytuLenh;

	private Label labelThongbao2;

	private Label labelThongbao1;

	private Button buttonCopy;

	private ComboBox comboBoxTabAddr;

	private CheckBox checkBoxThongbaoTHP;

	private CheckBox checkBoxBaoCsKenhbang;

	private Button buttonXoaLuonDanh;

	private Button buttonKhongDanhBang;

	private Button buttonXoaDanhAc;

	private Button buttonPhimHd1;

	private Button buttonEpPT;

	private Button buttonEpDanhBang;

	private Label label9;

	private CheckBox checkBoxLuongThuyTHP;

	private TextBox textBoxValueDelay;

	private CheckBox checkBoxDelay;

	private TextBox textBoxTienToida;

	private CheckBox checkBoxTienToida;

	private Label labelMatma;

	private CheckBox checkBoxNhapMatma;

	private CheckBox checkBoxTatThongbaoDame;

	private CheckBox checkBoxMouseDrag;

	private CheckBox checkBoxDanhKhongten;

	private Button buttonTatFirewall;

	private TextBox textBox1;

	private Label label13;

	private GroupBox groupBox2;

	private Label label14;

	private NumericUpDown numericUpDown1;

	private Label label16;

	private Button button1;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static string string_0 = null;

	private static int int_1 = 0;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	private int int_6 = -1;

	private CharacterAccountConfig characterAccountConfig_0 = default(CharacterAccountConfig);

	private static string[] string_1 = new string[2] { "Đây là máy chính", "Đây là máy phụ" };

	private static string string_2 = null;

	private bool bool_1 = false;

	private static int int_7 = -1;

	private static int int_8 = 0;

	private static long long_0 = -1L;

	private static string string_3 = string.Empty;

	private static int int_9 = 5000;

	private static int int_10 = 65000;

	private static string[] string_4 = null;

	private static string[] string_5 = null;

	private static string[] string_6 = null;

	private static Random random_0 = new Random();

	private IContainer icontainer_1;

	private static bool bool_2 = false;

	public FormRauria()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns130.FormRauria));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_1);
		this.label8 = new System.Windows.Forms.Label();
		this.checkBoxAcChihuy = new System.Windows.Forms.CheckBox();
		this.checkBoxAcChinhNghelenh = new System.Windows.Forms.CheckBox();
		this.buttonHelp = new System.Windows.Forms.Button();
		this.checkBoxSuado = new System.Windows.Forms.CheckBox();
		this.checkBoxDoiPKTheoAccChinh = new System.Windows.Forms.CheckBox();
		this.checkBoxTroLaiDiemcu = new System.Windows.Forms.CheckBox();
		this.label15 = new System.Windows.Forms.Label();
		this.textBoxKhoangCachlenNgua = new System.Windows.Forms.TextBox();
		this.numericUpDownKhongdanhCapnho = new System.Windows.Forms.NumericUpDown();
		this.checkBoxKhongdanhCapnho = new System.Windows.Forms.CheckBox();
		this.labelBoqua = new System.Windows.Forms.Label();
		this.checkBoxBaoCuusat = new System.Windows.Forms.CheckBox();
		this.checkBoxKhongChaybo = new System.Windows.Forms.CheckBox();
		this.checkBoxKhongDanhAccCungbang = new System.Windows.Forms.CheckBox();
		this.buttonThietlapSuado = new System.Windows.Forms.Button();
		this.labelTiepcan = new System.Windows.Forms.Label();
		this.textBoxTiepCan = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.checkBoxDanhDenchet = new System.Windows.Forms.CheckBox();
		this.comboBoxKhongdanhAc = new System.Windows.Forms.ComboBox();
		this.comboBoxKhongDanh = new System.Windows.Forms.ComboBox();
		this.comboBoxLuonDanh = new System.Windows.Forms.ComboBox();
		this.checkBoxXuongngua = new System.Windows.Forms.CheckBox();
		this.checkBoxBaoCuusatPhucan = new System.Windows.Forms.CheckBox();
		this.checkBoxLuonDanhbang = new System.Windows.Forms.CheckBox();
		this.checkBoxKhongdanhAc = new System.Windows.Forms.CheckBox();
		this.labelLienthongGiaithich = new System.Windows.Forms.Label();
		this.listViewKhongdanhAc = new System.Windows.Forms.ListView();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.checkBoxTHP_Smdb = new System.Windows.Forms.CheckBox();
		this.checkBoxKhongdanhBang = new System.Windows.Forms.CheckBox();
		this.listViewKhongDanh = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.listViewLuonDanh = new System.Windows.Forms.ListView();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.textBoxTen = new System.Windows.Forms.TextBox();
		this.numericUpDownPassword = new System.Windows.Forms.NumericUpDown();
		this.checkBoxKhoaChatmat = new System.Windows.Forms.CheckBox();
		this.checkBoxRoom = new System.Windows.Forms.CheckBox();
		this.checkBoxPassword = new System.Windows.Forms.CheckBox();
		this.label3 = new System.Windows.Forms.Label();
		this.buttonDanhsachMayphu = new System.Windows.Forms.Button();
		this.buttonCacChucNangDkTuxa = new System.Windows.Forms.Button();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.buttonEpDanhBang = new System.Windows.Forms.Button();
		this.buttonEpPT = new System.Windows.Forms.Button();
		this.buttonXoaDanhAc = new System.Windows.Forms.Button();
		this.buttonKhongDanhBang = new System.Windows.Forms.Button();
		this.buttonXoaLuonDanh = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.textBoxTienToida = new System.Windows.Forms.TextBox();
		this.textBoxValueDelay = new System.Windows.Forms.TextBox();
		this.checkBoxDanhKhongten = new System.Windows.Forms.CheckBox();
		this.checkBoxMouseDrag = new System.Windows.Forms.CheckBox();
		this.checkBoxTatThongbaoDame = new System.Windows.Forms.CheckBox();
		this.labelMatma = new System.Windows.Forms.Label();
		this.checkBoxNhapMatma = new System.Windows.Forms.CheckBox();
		this.checkBoxTienToida = new System.Windows.Forms.CheckBox();
		this.checkBoxDelay = new System.Windows.Forms.CheckBox();
		this.checkBoxLuongThuyTHP = new System.Windows.Forms.CheckBox();
		this.checkBoxBaoCsKenhbang = new System.Windows.Forms.CheckBox();
		this.checkBoxThongbaoTHP = new System.Windows.Forms.CheckBox();
		this.tabPageLienMay = new System.Windows.Forms.TabPage();
		this.tabControlKeoLienmay = new System.Windows.Forms.TabControl();
		this.tabPage4 = new System.Windows.Forms.TabPage();
		this.button1 = new System.Windows.Forms.Button();
		this.buttonTatFirewall = new System.Windows.Forms.Button();
		this.buttonPhimHd1 = new System.Windows.Forms.Button();
		this.buttonXoa = new System.Windows.Forms.Button();
		this.progressBar1 = new System.Windows.Forms.ProgressBar();
		this.buttonKetthuc = new System.Windows.Forms.Button();
		this.buttonBatdau = new System.Windows.Forms.Button();
		this.groupBoxHientai = new System.Windows.Forms.GroupBox();
		this.buttonCopy = new System.Windows.Forms.Button();
		this.comboBoxTabAddr = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.buttonRandom = new System.Windows.Forms.Button();
		this.textBoxPassServer = new System.Windows.Forms.TextBox();
		this.groupBoxConnect = new System.Windows.Forms.GroupBox();
		this.textBoxConnectPass = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.textBoxIPConnect = new System.Windows.Forms.TextBox();
		this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
		this.comboBoxConnect = new System.Windows.Forms.ComboBox();
		this.tabPage5 = new System.Windows.Forms.TabPage();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.label16 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.label13 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.textBoxKytuLenh = new System.Windows.Forms.TextBox();
		this.labelThongbao2 = new System.Windows.Forms.Label();
		this.labelThongbao1 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownKhongdanhCapnho).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownPassword).BeginInit();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.tabPageLienMay.SuspendLayout();
		this.tabControlKeoLienmay.SuspendLayout();
		this.tabPage4.SuspendLayout();
		this.groupBoxHientai.SuspendLayout();
		this.groupBoxConnect.SuspendLayout();
		this.tabPage5.SuspendLayout();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.label8.ForeColor = System.Drawing.Color.Black;
		this.label8.Location = new System.Drawing.Point(157, 190);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(303, 35);
		this.label8.TabIndex = 267;
		this.label8.Text = "Tất cả ac ở máy phụ đều sẽ tìm theo ac chính ở máy chính. \r\nAc chính máy phụ nên cho theo sau ac chính máy chính";
		this.checkBoxAcChihuy.ForeColor = System.Drawing.Color.DarkGreen;
		this.checkBoxAcChihuy.Location = new System.Drawing.Point(5, 217);
		this.checkBoxAcChihuy.Name = "checkBoxAcChihuy";
		this.checkBoxAcChihuy.Size = new System.Drawing.Size(200, 40);
		this.checkBoxAcChihuy.TabIndex = 264;
		this.checkBoxAcChihuy.Text = "Đây là ac báo vị trí của máy chính (máy này bạn đang điều khiển).";
		this.checkBoxAcChihuy.UseVisualStyleBackColor = true;
		this.checkBoxAcChihuy.CheckedChanged += new System.EventHandler(checkBoxAcChihuy_CheckedChanged);
		this.checkBoxAcChinhNghelenh.AutoSize = true;
		this.checkBoxAcChinhNghelenh.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxAcChinhNghelenh.Location = new System.Drawing.Point(5, 193);
		this.checkBoxAcChinhNghelenh.Name = "checkBoxAcChinhNghelenh";
		this.checkBoxAcChinhNghelenh.Size = new System.Drawing.Size(99, 17);
		this.checkBoxAcChinhNghelenh.TabIndex = 265;
		this.checkBoxAcChinhNghelenh.Text = "Đây là máy phụ";
		this.checkBoxAcChinhNghelenh.UseVisualStyleBackColor = true;
		this.checkBoxAcChinhNghelenh.CheckedChanged += new System.EventHandler(checkBoxAcChinhNghelenh_CheckedChanged);
		this.buttonHelp.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonHelp.Location = new System.Drawing.Point(331, 50);
		this.buttonHelp.Name = "buttonHelp";
		this.buttonHelp.Size = new System.Drawing.Size(126, 44);
		this.buttonHelp.TabIndex = 289;
		this.buttonHelp.Text = "Phim hướng dẫn";
		this.buttonHelp.UseVisualStyleBackColor = true;
		this.buttonHelp.Click += new System.EventHandler(buttonHelp_Click);
		this.checkBoxSuado.AutoSize = true;
		this.checkBoxSuado.ForeColor = System.Drawing.Color.Red;
		this.checkBoxSuado.Location = new System.Drawing.Point(3, 229);
		this.checkBoxSuado.Name = "checkBoxSuado";
		this.checkBoxSuado.Size = new System.Drawing.Size(119, 19);
		this.checkBoxSuado.TabIndex = 290;
		this.checkBoxSuado.Text = "Tự sửa đồ tại chỗ";
		this.checkBoxSuado.UseVisualStyleBackColor = true;
		this.checkBoxSuado.CheckedChanged += new System.EventHandler(checkBoxSuado_CheckedChanged);
		this.checkBoxDoiPKTheoAccChinh.AutoSize = true;
		this.checkBoxDoiPKTheoAccChinh.ForeColor = System.Drawing.Color.Black;
		this.checkBoxDoiPKTheoAccChinh.Location = new System.Drawing.Point(3, 17);
		this.checkBoxDoiPKTheoAccChinh.Name = "checkBoxDoiPKTheoAccChinh";
		this.checkBoxDoiPKTheoAccChinh.Size = new System.Drawing.Size(137, 19);
		this.checkBoxDoiPKTheoAccChinh.TabIndex = 294;
		this.checkBoxDoiPKTheoAccChinh.Text = "Đổi pk theo ac chính";
		this.checkBoxDoiPKTheoAccChinh.UseVisualStyleBackColor = true;
		this.checkBoxDoiPKTheoAccChinh.CheckedChanged += new System.EventHandler(checkBoxDoiPKTheoAccChinh_CheckedChanged);
		this.checkBoxTroLaiDiemcu.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTroLaiDiemcu.Location = new System.Drawing.Point(206, 112);
		this.checkBoxTroLaiDiemcu.Name = "checkBoxTroLaiDiemcu";
		this.checkBoxTroLaiDiemcu.Size = new System.Drawing.Size(186, 41);
		this.checkBoxTroLaiDiemcu.TabIndex = 295;
		this.checkBoxTroLaiDiemcu.Text = "Trở lại điểm cũ (sẽ đi THP nếu không thể đi từ xa phu)";
		this.checkBoxTroLaiDiemcu.UseVisualStyleBackColor = true;
		this.checkBoxTroLaiDiemcu.CheckedChanged += new System.EventHandler(checkBoxTroLaiDiemcu_CheckedChanged);
		this.label15.AutoSize = true;
		this.label15.ForeColor = System.Drawing.Color.Black;
		this.label15.Location = new System.Drawing.Point(207, 49);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(199, 15);
		this.label15.TabIndex = 297;
		this.label15.Text = "Khoảng cách lên ngựa tìm ac chính";
		this.textBoxKhoangCachlenNgua.ForeColor = System.Drawing.Color.Black;
		this.textBoxKhoangCachlenNgua.Location = new System.Drawing.Point(408, 46);
		this.textBoxKhoangCachlenNgua.Name = "textBoxKhoangCachlenNgua";
		this.textBoxKhoangCachlenNgua.Size = new System.Drawing.Size(67, 21);
		this.textBoxKhoangCachlenNgua.TabIndex = 296;
		this.textBoxKhoangCachlenNgua.TextChanged += new System.EventHandler(textBoxKhoangCachlenNgua_TextChanged);
		this.numericUpDownKhongdanhCapnho.ForeColor = System.Drawing.Color.Black;
		this.numericUpDownKhongdanhCapnho.Location = new System.Drawing.Point(138, 181);
		this.numericUpDownKhongdanhCapnho.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.numericUpDownKhongdanhCapnho.Name = "numericUpDownKhongdanhCapnho";
		this.numericUpDownKhongdanhCapnho.Size = new System.Drawing.Size(41, 21);
		this.numericUpDownKhongdanhCapnho.TabIndex = 299;
		this.numericUpDownKhongdanhCapnho.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.numericUpDownKhongdanhCapnho.ValueChanged += new System.EventHandler(numericUpDownKhongdanhCapnho_ValueChanged);
		this.numericUpDownKhongdanhCapnho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(numericUpDownKhongdanhCapnho_KeyPress);
		this.checkBoxKhongdanhCapnho.AutoSize = true;
		this.checkBoxKhongdanhCapnho.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxKhongdanhCapnho.ForeColor = System.Drawing.Color.Black;
		this.checkBoxKhongdanhCapnho.Location = new System.Drawing.Point(3, 182);
		this.checkBoxKhongdanhCapnho.Name = "checkBoxKhongdanhCapnho";
		this.checkBoxKhongdanhCapnho.Size = new System.Drawing.Size(132, 19);
		this.checkBoxKhongdanhCapnho.TabIndex = 298;
		this.checkBoxKhongdanhCapnho.Text = "Không đánh ac cấp";
		this.checkBoxKhongdanhCapnho.UseVisualStyleBackColor = false;
		this.checkBoxKhongdanhCapnho.CheckedChanged += new System.EventHandler(checkBoxKhongdanhCapnho_CheckedChanged);
		this.labelBoqua.AutoSize = true;
		this.labelBoqua.Cursor = System.Windows.Forms.Cursors.Hand;
		this.labelBoqua.ForeColor = System.Drawing.Color.Green;
		this.labelBoqua.Location = new System.Drawing.Point(395, 115);
		this.labelBoqua.Name = "labelBoqua";
		this.labelBoqua.Size = new System.Drawing.Size(62, 15);
		this.labelBoqua.TabIndex = 302;
		this.labelBoqua.Text = "giải thích..";
		this.labelBoqua.Click += new System.EventHandler(labelBoqua_Click);
		this.checkBoxBaoCuusat.AutoSize = true;
		this.checkBoxBaoCuusat.ForeColor = System.Drawing.Color.Black;
		this.checkBoxBaoCuusat.Location = new System.Drawing.Point(4, 57);
		this.checkBoxBaoCuusat.Name = "checkBoxBaoCuusat";
		this.checkBoxBaoCuusat.Size = new System.Drawing.Size(114, 19);
		this.checkBoxBaoCuusat.TabIndex = 303;
		this.checkBoxBaoCuusat.Text = "Báo cừu sát mật";
		this.checkBoxBaoCuusat.UseVisualStyleBackColor = true;
		this.checkBoxBaoCuusat.CheckedChanged += new System.EventHandler(checkBoxBaoCuusat_CheckedChanged);
		this.checkBoxKhongChaybo.AutoSize = true;
		this.checkBoxKhongChaybo.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxKhongChaybo.ForeColor = System.Drawing.Color.Black;
		this.checkBoxKhongChaybo.Location = new System.Drawing.Point(206, 93);
		this.checkBoxKhongChaybo.Name = "checkBoxKhongChaybo";
		this.checkBoxKhongChaybo.Size = new System.Drawing.Size(221, 19);
		this.checkBoxKhongChaybo.TabIndex = 301;
		this.checkBoxKhongChaybo.Text = "Không chạy bộ đến các map quá xa";
		this.checkBoxKhongChaybo.UseVisualStyleBackColor = false;
		this.checkBoxKhongChaybo.CheckedChanged += new System.EventHandler(checkBoxKhongChaybo_CheckedChanged);
		this.checkBoxKhongDanhAccCungbang.AutoSize = true;
		this.checkBoxKhongDanhAccCungbang.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxKhongDanhAccCungbang.ForeColor = System.Drawing.Color.DeepSkyBlue;
		this.checkBoxKhongDanhAccCungbang.Location = new System.Drawing.Point(3, 206);
		this.checkBoxKhongDanhAccCungbang.Name = "checkBoxKhongDanhAccCungbang";
		this.checkBoxKhongDanhAccCungbang.Size = new System.Drawing.Size(154, 19);
		this.checkBoxKhongDanhAccCungbang.TabIndex = 300;
		this.checkBoxKhongDanhAccCungbang.Text = "Không đánh cùng bang";
		this.checkBoxKhongDanhAccCungbang.UseVisualStyleBackColor = false;
		this.checkBoxKhongDanhAccCungbang.CheckedChanged += new System.EventHandler(checkBoxKhongDanhAccCungbang_CheckedChanged);
		this.buttonThietlapSuado.BackColor = System.Drawing.SystemColors.Control;
		this.buttonThietlapSuado.ForeColor = System.Drawing.Color.Black;
		this.buttonThietlapSuado.Location = new System.Drawing.Point(121, 225);
		this.buttonThietlapSuado.Name = "buttonThietlapSuado";
		this.buttonThietlapSuado.Size = new System.Drawing.Size(77, 27);
		this.buttonThietlapSuado.TabIndex = 304;
		this.buttonThietlapSuado.Text = "Thiết lập";
		this.buttonThietlapSuado.UseVisualStyleBackColor = false;
		this.buttonThietlapSuado.Click += new System.EventHandler(buttonThietlapSuado_Click);
		this.labelTiepcan.AutoSize = true;
		this.labelTiepcan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.labelTiepcan.ForeColor = System.Drawing.Color.Green;
		this.labelTiepcan.Location = new System.Drawing.Point(372, 29);
		this.labelTiepcan.Name = "labelTiepcan";
		this.labelTiepcan.Size = new System.Drawing.Size(62, 15);
		this.labelTiepcan.TabIndex = 444;
		this.labelTiepcan.Text = "giải thích..";
		this.labelTiepcan.Click += new System.EventHandler(labelTiepcan_Click);
		this.textBoxTiepCan.ForeColor = System.Drawing.Color.Maroon;
		this.textBoxTiepCan.Location = new System.Drawing.Point(408, 10);
		this.textBoxTiepCan.Name = "textBoxTiepCan";
		this.textBoxTiepCan.Size = new System.Drawing.Size(67, 21);
		this.textBoxTiepCan.TabIndex = 442;
		this.textBoxTiepCan.TextChanged += new System.EventHandler(textBoxTiepCan_TextChanged);
		this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.label2.ForeColor = System.Drawing.Color.Maroon;
		this.label2.Location = new System.Drawing.Point(208, 10);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(188, 33);
		this.label2.TabIndex = 443;
		this.label2.Text = "Khoảng cách tìm ac chính dùng riêng cho các ac đánh tiếp cận <= 180";
		this.checkBoxDanhDenchet.AutoSize = true;
		this.checkBoxDanhDenchet.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxDanhDenchet.ForeColor = System.Drawing.Color.Black;
		this.checkBoxDanhDenchet.Location = new System.Drawing.Point(3, 160);
		this.checkBoxDanhDenchet.Name = "checkBoxDanhDenchet";
		this.checkBoxDanhDenchet.Size = new System.Drawing.Size(106, 19);
		this.checkBoxDanhDenchet.TabIndex = 441;
		this.checkBoxDanhDenchet.Text = "Đánh đến chết";
		this.checkBoxDanhDenchet.UseVisualStyleBackColor = false;
		this.checkBoxDanhDenchet.CheckedChanged += new System.EventHandler(checkBoxDanhDenchet_CheckedChanged);
		this.comboBoxKhongdanhAc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxKhongdanhAc.DropDownWidth = 125;
		this.comboBoxKhongdanhAc.FormattingEnabled = true;
		this.comboBoxKhongdanhAc.Location = new System.Drawing.Point(265, 104);
		this.comboBoxKhongdanhAc.Name = "comboBoxKhongdanhAc";
		this.comboBoxKhongdanhAc.Size = new System.Drawing.Size(88, 23);
		this.comboBoxKhongdanhAc.TabIndex = 433;
		this.comboBoxKhongdanhAc.SelectedIndexChanged += new System.EventHandler(comboBoxKhongdanhAc_SelectedIndexChanged);
		this.comboBoxKhongdanhAc.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxKhongdanhAc_MouseDown);
		this.comboBoxKhongDanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxKhongDanh.FormattingEnabled = true;
		this.comboBoxKhongDanh.Location = new System.Drawing.Point(132, 104);
		this.comboBoxKhongDanh.Name = "comboBoxKhongDanh";
		this.comboBoxKhongDanh.Size = new System.Drawing.Size(92, 23);
		this.comboBoxKhongDanh.TabIndex = 430;
		this.comboBoxKhongDanh.SelectedIndexChanged += new System.EventHandler(comboBoxKhongDanh_SelectedIndexChanged);
		this.comboBoxKhongDanh.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxKhongDanh_MouseDown);
		this.comboBoxLuonDanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxLuonDanh.FormattingEnabled = true;
		this.comboBoxLuonDanh.Location = new System.Drawing.Point(4, 104);
		this.comboBoxLuonDanh.Name = "comboBoxLuonDanh";
		this.comboBoxLuonDanh.Size = new System.Drawing.Size(85, 23);
		this.comboBoxLuonDanh.TabIndex = 427;
		this.comboBoxLuonDanh.SelectedIndexChanged += new System.EventHandler(comboBoxLuonDanh_SelectedIndexChanged);
		this.comboBoxLuonDanh.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxLuonDanh_MouseDown);
		this.checkBoxXuongngua.AutoSize = true;
		this.checkBoxXuongngua.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxXuongngua.ForeColor = System.Drawing.Color.RoyalBlue;
		this.checkBoxXuongngua.Location = new System.Drawing.Point(3, 36);
		this.checkBoxXuongngua.Name = "checkBoxXuongngua";
		this.checkBoxXuongngua.Size = new System.Drawing.Size(185, 19);
		this.checkBoxXuongngua.TabIndex = 331;
		this.checkBoxXuongngua.Text = "Xuống ngựa khi gặp ac chính";
		this.checkBoxXuongngua.UseVisualStyleBackColor = false;
		this.checkBoxXuongngua.CheckedChanged += new System.EventHandler(checkBoxXuongngua_CheckedChanged);
		this.checkBoxBaoCuusatPhucan.AutoSize = true;
		this.checkBoxBaoCuusatPhucan.ForeColor = System.Drawing.Color.Black;
		this.checkBoxBaoCuusatPhucan.Location = new System.Drawing.Point(119, 58);
		this.checkBoxBaoCuusatPhucan.Name = "checkBoxBaoCuusatPhucan";
		this.checkBoxBaoCuusatPhucan.Size = new System.Drawing.Size(71, 19);
		this.checkBoxBaoCuusatPhucan.TabIndex = 330;
		this.checkBoxBaoCuusatPhucan.Text = "Phụ cận";
		this.checkBoxBaoCuusatPhucan.UseVisualStyleBackColor = true;
		this.checkBoxBaoCuusatPhucan.CheckedChanged += new System.EventHandler(checkBoxBaoCuusatPhucan_CheckedChanged);
		this.checkBoxLuonDanhbang.AutoSize = true;
		this.checkBoxLuonDanhbang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f);
		this.checkBoxLuonDanhbang.ForeColor = System.Drawing.Color.Red;
		this.checkBoxLuonDanhbang.Location = new System.Drawing.Point(3, 3);
		this.checkBoxLuonDanhbang.Name = "checkBoxLuonDanhbang";
		this.checkBoxLuonDanhbang.Size = new System.Drawing.Size(136, 19);
		this.checkBoxLuonDanhbang.TabIndex = 412;
		this.checkBoxLuonDanhbang.Text = "Luôn đánh bang hội";
		this.checkBoxLuonDanhbang.UseVisualStyleBackColor = true;
		this.checkBoxLuonDanhbang.CheckedChanged += new System.EventHandler(checkBoxLuonDanhbang_CheckedChanged);
		this.checkBoxKhongdanhAc.AutoSize = true;
		this.checkBoxKhongdanhAc.ForeColor = System.Drawing.Color.Red;
		this.checkBoxKhongdanhAc.Location = new System.Drawing.Point(288, 4);
		this.checkBoxKhongdanhAc.Name = "checkBoxKhongdanhAc";
		this.checkBoxKhongdanhAc.Size = new System.Drawing.Size(109, 19);
		this.checkBoxKhongdanhAc.TabIndex = 426;
		this.checkBoxKhongdanhAc.Text = "Không đánh ac";
		this.checkBoxKhongdanhAc.UseVisualStyleBackColor = true;
		this.checkBoxKhongdanhAc.CheckedChanged += new System.EventHandler(checkBoxKhongdanhAc_CheckedChanged);
		this.labelLienthongGiaithich.AutoSize = true;
		this.labelLienthongGiaithich.Cursor = System.Windows.Forms.Cursors.Hand;
		this.labelLienthongGiaithich.ForeColor = System.Drawing.Color.Green;
		this.labelLienthongGiaithich.Location = new System.Drawing.Point(398, 74);
		this.labelLienthongGiaithich.Name = "labelLienthongGiaithich";
		this.labelLienthongGiaithich.Size = new System.Drawing.Size(62, 15);
		this.labelLienthongGiaithich.TabIndex = 329;
		this.labelLienthongGiaithich.Text = "giải thích..";
		this.labelLienthongGiaithich.Click += new System.EventHandler(labelLienthongGiaithich_Click);
		this.listViewKhongdanhAc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_2 });
		this.listViewKhongdanhAc.FullRowSelect = true;
		this.listViewKhongdanhAc.GridLines = true;
		this.listViewKhongdanhAc.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listViewKhongdanhAc.HideSelection = false;
		this.listViewKhongdanhAc.Location = new System.Drawing.Point(266, 31);
		this.listViewKhongdanhAc.MultiSelect = false;
		this.listViewKhongdanhAc.Name = "listViewKhongdanhAc";
		this.listViewKhongdanhAc.Size = new System.Drawing.Size(121, 65);
		this.listViewKhongdanhAc.TabIndex = 422;
		this.listViewKhongdanhAc.UseCompatibleStateImageBehavior = false;
		this.listViewKhongdanhAc.View = System.Windows.Forms.View.Details;
		this.columnHeader_2.Text = "Không đánh ac";
		this.columnHeader_2.Width = 115;
		this.checkBoxTHP_Smdb.AutoSize = true;
		this.checkBoxTHP_Smdb.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTHP_Smdb.Location = new System.Drawing.Point(206, 72);
		this.checkBoxTHP_Smdb.Name = "checkBoxTHP_Smdb";
		this.checkBoxTHP_Smdb.Size = new System.Drawing.Size(187, 19);
		this.checkBoxTHP_Smdb.TabIndex = 328;
		this.checkBoxTHP_Smdb.Text = "Chạy bộ ở các map liên thông";
		this.checkBoxTHP_Smdb.UseVisualStyleBackColor = true;
		this.checkBoxTHP_Smdb.CheckedChanged += new System.EventHandler(checkBoxTHP_Smdb_CheckedChanged);
		this.checkBoxKhongdanhBang.AutoSize = true;
		this.checkBoxKhongdanhBang.ForeColor = System.Drawing.Color.Red;
		this.checkBoxKhongdanhBang.Location = new System.Drawing.Point(141, 3);
		this.checkBoxKhongdanhBang.Name = "checkBoxKhongdanhBang";
		this.checkBoxKhongdanhBang.Size = new System.Drawing.Size(144, 19);
		this.checkBoxKhongdanhBang.TabIndex = 421;
		this.checkBoxKhongdanhBang.Text = "Không đánh bang hội";
		this.checkBoxKhongdanhBang.UseVisualStyleBackColor = true;
		this.checkBoxKhongdanhBang.CheckedChanged += new System.EventHandler(checkBoxKhongdanhBang_CheckedChanged);
		this.listViewKhongDanh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_0 });
		this.listViewKhongDanh.FullRowSelect = true;
		this.listViewKhongDanh.GridLines = true;
		this.listViewKhongDanh.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listViewKhongDanh.HideSelection = false;
		this.listViewKhongDanh.Location = new System.Drawing.Point(131, 28);
		this.listViewKhongDanh.MultiSelect = false;
		this.listViewKhongDanh.Name = "listViewKhongDanh";
		this.listViewKhongDanh.Size = new System.Drawing.Size(128, 69);
		this.listViewKhongDanh.TabIndex = 417;
		this.listViewKhongDanh.UseCompatibleStateImageBehavior = false;
		this.listViewKhongDanh.View = System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "Không đánh bang";
		this.columnHeader_0.Width = 105;
		this.listViewLuonDanh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_1 });
		this.listViewLuonDanh.FullRowSelect = true;
		this.listViewLuonDanh.GridLines = true;
		this.listViewLuonDanh.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listViewLuonDanh.HideSelection = false;
		this.listViewLuonDanh.Location = new System.Drawing.Point(3, 28);
		this.listViewLuonDanh.MultiSelect = false;
		this.listViewLuonDanh.Name = "listViewLuonDanh";
		this.listViewLuonDanh.Size = new System.Drawing.Size(120, 69);
		this.listViewLuonDanh.TabIndex = 413;
		this.listViewLuonDanh.UseCompatibleStateImageBehavior = false;
		this.listViewLuonDanh.View = System.Windows.Forms.View.Details;
		this.columnHeader_1.Text = "Đánh người bang hội";
		this.columnHeader_1.Width = 112;
		this.textBoxTen.BackColor = System.Drawing.Color.Gainsboro;
		this.textBoxTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxTen.ForeColor = System.Drawing.Color.MidnightBlue;
		this.textBoxTen.Location = new System.Drawing.Point(216, 233);
		this.textBoxTen.Name = "textBoxTen";
		this.textBoxTen.Size = new System.Drawing.Size(173, 13);
		this.textBoxTen.TabIndex = 339;
		this.numericUpDownPassword.ForeColor = System.Drawing.Color.Black;
		this.numericUpDownPassword.Location = new System.Drawing.Point(390, 300);
		this.numericUpDownPassword.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
		this.numericUpDownPassword.Name = "numericUpDownPassword";
		this.numericUpDownPassword.Size = new System.Drawing.Size(62, 20);
		this.numericUpDownPassword.TabIndex = 333;
		this.numericUpDownPassword.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.numericUpDownPassword.ValueChanged += new System.EventHandler(numericUpDownPassword_ValueChanged);
		this.numericUpDownPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(numericUpDownPassword_KeyPress);
		this.checkBoxKhoaChatmat.AutoSize = true;
		this.checkBoxKhoaChatmat.ForeColor = System.Drawing.Color.Black;
		this.checkBoxKhoaChatmat.Location = new System.Drawing.Point(5, 326);
		this.checkBoxKhoaChatmat.Name = "checkBoxKhoaChatmat";
		this.checkBoxKhoaChatmat.Size = new System.Drawing.Size(124, 17);
		this.checkBoxKhoaChatmat.TabIndex = 334;
		this.checkBoxKhoaChatmat.Text = "Tắt tầng số chat mật";
		this.checkBoxKhoaChatmat.UseVisualStyleBackColor = true;
		this.checkBoxKhoaChatmat.CheckedChanged += new System.EventHandler(checkBoxKhoaChatmat_CheckedChanged);
		this.checkBoxRoom.AutoSize = true;
		this.checkBoxRoom.ForeColor = System.Drawing.Color.Black;
		this.checkBoxRoom.Location = new System.Drawing.Point(5, 346);
		this.checkBoxRoom.Name = "checkBoxRoom";
		this.checkBoxRoom.Size = new System.Drawing.Size(138, 17);
		this.checkBoxRoom.TabIndex = 333;
		this.checkBoxRoom.Text = "Có báo trong phòng tán";
		this.checkBoxRoom.UseVisualStyleBackColor = true;
		this.checkBoxRoom.CheckedChanged += new System.EventHandler(checkBoxRoom_CheckedChanged);
		this.checkBoxPassword.AutoSize = true;
		this.checkBoxPassword.ForeColor = System.Drawing.Color.Black;
		this.checkBoxPassword.Location = new System.Drawing.Point(5, 303);
		this.checkBoxPassword.Name = "checkBoxPassword";
		this.checkBoxPassword.Size = new System.Drawing.Size(384, 17);
		this.checkBoxPassword.TabIndex = 335;
		this.checkBoxPassword.Text = "Có sử dụng pass để tránh bị phá rối (máy chính và máy phụ ghi giống nhau)";
		this.checkBoxPassword.UseVisualStyleBackColor = true;
		this.checkBoxPassword.CheckedChanged += new System.EventHandler(checkBoxPassword_CheckedChanged);
		this.label3.ForeColor = System.Drawing.Color.Black;
		this.label3.Location = new System.Drawing.Point(157, 253);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(303, 50);
		this.label3.TabIndex = 332;
		this.label3.Text = "Ép tên ac chính (hoặc tất cả tên ac) ở máy phụ vào nút <danh sách ac máy phụ>, sau đó check vào nút [v] Đây là máy chính... (không nên đem ac chính làm ac thông báo nhé).";
		this.buttonDanhsachMayphu.BackColor = System.Drawing.SystemColors.Control;
		this.buttonDanhsachMayphu.ForeColor = System.Drawing.Color.Black;
		this.buttonDanhsachMayphu.Location = new System.Drawing.Point(5, 257);
		this.buttonDanhsachMayphu.Name = "buttonDanhsachMayphu";
		this.buttonDanhsachMayphu.Size = new System.Drawing.Size(114, 42);
		this.buttonDanhsachMayphu.TabIndex = 321;
		this.buttonDanhsachMayphu.Text = "Danh sách ac máy phụ";
		this.buttonDanhsachMayphu.UseVisualStyleBackColor = false;
		this.buttonDanhsachMayphu.Click += new System.EventHandler(buttonDanhsachMayphu_Click);
		this.buttonCacChucNangDkTuxa.ForeColor = System.Drawing.Color.Black;
		this.buttonCacChucNangDkTuxa.Location = new System.Drawing.Point(5, 399);
		this.buttonCacChucNangDkTuxa.Name = "buttonCacChucNangDkTuxa";
		this.buttonCacChucNangDkTuxa.Size = new System.Drawing.Size(238, 30);
		this.buttonCacChucNangDkTuxa.TabIndex = 290;
		this.buttonCacChucNangDkTuxa.Text = "Các chức năng điều khiển từ xa";
		this.buttonCacChucNangDkTuxa.UseVisualStyleBackColor = true;
		this.buttonCacChucNangDkTuxa.Click += new System.EventHandler(buttonCacChucNangDkTuxa_Click);
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPageLienMay);
		this.tabControl1.Location = new System.Drawing.Point(0, 0);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(497, 460);
		this.tabControl1.TabIndex = 326;
		this.tabPage1.Controls.Add(this.buttonEpDanhBang);
		this.tabPage1.Controls.Add(this.buttonEpPT);
		this.tabPage1.Controls.Add(this.buttonXoaDanhAc);
		this.tabPage1.Controls.Add(this.buttonKhongDanhBang);
		this.tabPage1.Controls.Add(this.comboBoxLuonDanh);
		this.tabPage1.Controls.Add(this.buttonXoaLuonDanh);
		this.tabPage1.Controls.Add(this.groupBox1);
		this.tabPage1.Controls.Add(this.checkBoxLuonDanhbang);
		this.tabPage1.Controls.Add(this.listViewKhongDanh);
		this.tabPage1.Controls.Add(this.checkBoxKhongdanhAc);
		this.tabPage1.Controls.Add(this.listViewLuonDanh);
		this.tabPage1.Controls.Add(this.checkBoxKhongdanhBang);
		this.tabPage1.Controls.Add(this.listViewKhongdanhAc);
		this.tabPage1.Controls.Add(this.comboBoxKhongdanhAc);
		this.tabPage1.Controls.Add(this.comboBoxKhongDanh);
		this.tabPage1.Location = new System.Drawing.Point(4, 24);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(489, 432);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Thiết lập chung";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.buttonEpDanhBang.AllowDrop = true;
		this.buttonEpDanhBang.AutoEllipsis = true;
		this.buttonEpDanhBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.buttonEpDanhBang.Location = new System.Drawing.Point(394, 82);
		this.buttonEpDanhBang.Name = "buttonEpDanhBang";
		this.buttonEpDanhBang.Size = new System.Drawing.Size(88, 46);
		this.buttonEpDanhBang.TabIndex = 467;
		this.buttonEpDanhBang.Text = "Cập nhật vào máy phụ";
		this.buttonEpDanhBang.UseVisualStyleBackColor = true;
		this.buttonEpDanhBang.Click += new System.EventHandler(buttonEpDanhBang_Click);
		this.buttonEpPT.Location = new System.Drawing.Point(393, 30);
		this.buttonEpPT.Name = "buttonEpPT";
		this.buttonEpPT.Size = new System.Drawing.Size(89, 44);
		this.buttonEpPT.TabIndex = 466;
		this.buttonEpPT.Text = "Ép các ac trong PT vào";
		this.buttonEpPT.UseVisualStyleBackColor = true;
		this.buttonEpPT.Click += new System.EventHandler(buttonEpPT_Click);
		this.buttonXoaDanhAc.BackColor = System.Drawing.SystemColors.Control;
		this.buttonXoaDanhAc.ForeColor = System.Drawing.Color.Black;
		this.buttonXoaDanhAc.Location = new System.Drawing.Point(359, 103);
		this.buttonXoaDanhAc.Name = "buttonXoaDanhAc";
		this.buttonXoaDanhAc.Size = new System.Drawing.Size(29, 24);
		this.buttonXoaDanhAc.TabIndex = 465;
		this.buttonXoaDanhAc.Text = "X";
		this.buttonXoaDanhAc.UseVisualStyleBackColor = false;
		this.buttonXoaDanhAc.Click += new System.EventHandler(buttonXoaDanhAc_Click);
		this.buttonKhongDanhBang.BackColor = System.Drawing.SystemColors.Control;
		this.buttonKhongDanhBang.ForeColor = System.Drawing.Color.Black;
		this.buttonKhongDanhBang.Location = new System.Drawing.Point(230, 104);
		this.buttonKhongDanhBang.Name = "buttonKhongDanhBang";
		this.buttonKhongDanhBang.Size = new System.Drawing.Size(29, 24);
		this.buttonKhongDanhBang.TabIndex = 464;
		this.buttonKhongDanhBang.Text = "X";
		this.buttonKhongDanhBang.UseVisualStyleBackColor = false;
		this.buttonKhongDanhBang.Click += new System.EventHandler(buttonKhongDanhBang_Click);
		this.buttonXoaLuonDanh.BackColor = System.Drawing.SystemColors.Control;
		this.buttonXoaLuonDanh.ForeColor = System.Drawing.Color.Black;
		this.buttonXoaLuonDanh.Location = new System.Drawing.Point(95, 103);
		this.buttonXoaLuonDanh.Name = "buttonXoaLuonDanh";
		this.buttonXoaLuonDanh.Size = new System.Drawing.Size(29, 24);
		this.buttonXoaLuonDanh.TabIndex = 463;
		this.buttonXoaLuonDanh.Text = "X";
		this.buttonXoaLuonDanh.UseVisualStyleBackColor = false;
		this.buttonXoaLuonDanh.Click += new System.EventHandler(buttonXoaLuonDanh_Click);
		this.groupBox1.Controls.Add(this.textBoxTienToida);
		this.groupBox1.Controls.Add(this.textBoxValueDelay);
		this.groupBox1.Controls.Add(this.textBoxTiepCan);
		this.groupBox1.Controls.Add(this.textBoxKhoangCachlenNgua);
		this.groupBox1.Controls.Add(this.checkBoxDanhKhongten);
		this.groupBox1.Controls.Add(this.checkBoxMouseDrag);
		this.groupBox1.Controls.Add(this.checkBoxTatThongbaoDame);
		this.groupBox1.Controls.Add(this.labelMatma);
		this.groupBox1.Controls.Add(this.checkBoxNhapMatma);
		this.groupBox1.Controls.Add(this.checkBoxTienToida);
		this.groupBox1.Controls.Add(this.checkBoxDelay);
		this.groupBox1.Controls.Add(this.checkBoxLuongThuyTHP);
		this.groupBox1.Controls.Add(this.checkBoxBaoCsKenhbang);
		this.groupBox1.Controls.Add(this.checkBoxThongbaoTHP);
		this.groupBox1.Controls.Add(this.labelTiepcan);
		this.groupBox1.Controls.Add(this.checkBoxDanhDenchet);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.checkBoxBaoCuusatPhucan);
		this.groupBox1.Controls.Add(this.checkBoxKhongdanhCapnho);
		this.groupBox1.Controls.Add(this.checkBoxSuado);
		this.groupBox1.Controls.Add(this.buttonThietlapSuado);
		this.groupBox1.Controls.Add(this.checkBoxTHP_Smdb);
		this.groupBox1.Controls.Add(this.checkBoxXuongngua);
		this.groupBox1.Controls.Add(this.checkBoxDoiPKTheoAccChinh);
		this.groupBox1.Controls.Add(this.labelBoqua);
		this.groupBox1.Controls.Add(this.labelLienthongGiaithich);
		this.groupBox1.Controls.Add(this.numericUpDownKhongdanhCapnho);
		this.groupBox1.Controls.Add(this.checkBoxKhongDanhAccCungbang);
		this.groupBox1.Controls.Add(this.label15);
		this.groupBox1.Controls.Add(this.checkBoxTroLaiDiemcu);
		this.groupBox1.Controls.Add(this.checkBoxKhongChaybo);
		this.groupBox1.Controls.Add(this.checkBoxBaoCuusat);
		this.groupBox1.Location = new System.Drawing.Point(1, 134);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(481, 297);
		this.groupBox1.TabIndex = 441;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Thiết lập dùng chung cho tất cả ac";
		this.textBoxTienToida.Location = new System.Drawing.Point(408, 270);
		this.textBoxTienToida.Name = "textBoxTienToida";
		this.textBoxTienToida.Size = new System.Drawing.Size(67, 21);
		this.textBoxTienToida.TabIndex = 467;
		this.textBoxTienToida.TextChanged += new System.EventHandler(textBoxTienToida_TextChanged);
		this.textBoxValueDelay.Location = new System.Drawing.Point(414, 237);
		this.textBoxValueDelay.Name = "textBoxValueDelay";
		this.textBoxValueDelay.Size = new System.Drawing.Size(61, 21);
		this.textBoxValueDelay.TabIndex = 465;
		this.textBoxValueDelay.TextChanged += new System.EventHandler(textBoxValueDelay_TextChanged);
		this.checkBoxDanhKhongten.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxDanhKhongten.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxDanhKhongten.Location = new System.Drawing.Point(4, 120);
		this.checkBoxDanhKhongten.Name = "checkBoxDanhKhongten";
		this.checkBoxDanhKhongten.Size = new System.Drawing.Size(184, 35);
		this.checkBoxDanhKhongten.TabIndex = 472;
		this.checkBoxDanhKhongten.Text = "Đánh người không có tên -loạn chiến";
		this.checkBoxDanhKhongten.UseVisualStyleBackColor = false;
		this.checkBoxDanhKhongten.CheckedChanged += new System.EventHandler(checkBoxDanhKhongten_CheckedChanged);
		this.checkBoxMouseDrag.AutoSize = true;
		this.checkBoxMouseDrag.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxMouseDrag.ForeColor = System.Drawing.Color.Black;
		this.checkBoxMouseDrag.Location = new System.Drawing.Point(3, 276);
		this.checkBoxMouseDrag.Name = "checkBoxMouseDrag";
		this.checkBoxMouseDrag.Size = new System.Drawing.Size(186, 19);
		this.checkBoxMouseDrag.TabIndex = 471;
		this.checkBoxMouseDrag.Text = "Bật thông báo \"_mouse drag\"";
		this.checkBoxMouseDrag.UseVisualStyleBackColor = false;
		this.checkBoxMouseDrag.CheckedChanged += new System.EventHandler(checkBoxMouseDrag_CheckedChanged);
		this.checkBoxTatThongbaoDame.AutoSize = true;
		this.checkBoxTatThongbaoDame.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTatThongbaoDame.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTatThongbaoDame.Location = new System.Drawing.Point(3, 255);
		this.checkBoxTatThongbaoDame.Name = "checkBoxTatThongbaoDame";
		this.checkBoxTatThongbaoDame.Size = new System.Drawing.Size(179, 19);
		this.checkBoxTatThongbaoDame.TabIndex = 470;
		this.checkBoxTatThongbaoDame.Text = "Tắt thông báo dame kết hợp";
		this.checkBoxTatThongbaoDame.UseVisualStyleBackColor = false;
		this.checkBoxTatThongbaoDame.CheckedChanged += new System.EventHandler(checkBoxTatThongbaoDame_CheckedChanged);
		this.labelMatma.AutoSize = true;
		this.labelMatma.Cursor = System.Windows.Forms.Cursors.Hand;
		this.labelMatma.ForeColor = System.Drawing.Color.Green;
		this.labelMatma.Location = new System.Drawing.Point(303, 167);
		this.labelMatma.Name = "labelMatma";
		this.labelMatma.Size = new System.Drawing.Size(62, 15);
		this.labelMatma.TabIndex = 469;
		this.labelMatma.Text = "giải thích..";
		this.labelMatma.Click += new System.EventHandler(labelMatma_Click);
		this.checkBoxNhapMatma.ForeColor = System.Drawing.Color.Black;
		this.checkBoxNhapMatma.Location = new System.Drawing.Point(206, 145);
		this.checkBoxNhapMatma.Name = "checkBoxNhapMatma";
		this.checkBoxNhapMatma.Size = new System.Drawing.Size(155, 39);
		this.checkBoxNhapMatma.TabIndex = 468;
		this.checkBoxNhapMatma.Text = "Cần phải nhập mật mã khi đi xa phu";
		this.checkBoxNhapMatma.UseVisualStyleBackColor = true;
		this.checkBoxNhapMatma.CheckedChanged += new System.EventHandler(checkBoxNhapMatma_CheckedChanged);
		this.checkBoxTienToida.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTienToida.Location = new System.Drawing.Point(205, 262);
		this.checkBoxTienToida.Name = "checkBoxTienToida";
		this.checkBoxTienToida.Size = new System.Drawing.Size(164, 34);
		this.checkBoxTienToida.TabIndex = 466;
		this.checkBoxTienToida.Text = "Số tiền rút tối đa (mua thuốc, sửa đồ..) vạn";
		this.checkBoxTienToida.UseVisualStyleBackColor = true;
		this.checkBoxTienToida.CheckedChanged += new System.EventHandler(checkBoxTienToida_CheckedChanged);
		this.checkBoxDelay.ForeColor = System.Drawing.Color.Black;
		this.checkBoxDelay.Location = new System.Drawing.Point(205, 229);
		this.checkBoxDelay.Name = "checkBoxDelay";
		this.checkBoxDelay.Size = new System.Drawing.Size(221, 37);
		this.checkBoxDelay.TabIndex = 464;
		this.checkBoxDelay.Text = "Người dùng tự thiết lập tốc độ click menu xa phu, THP.. (mili giây)";
		this.checkBoxDelay.UseVisualStyleBackColor = true;
		this.checkBoxDelay.CheckedChanged += new System.EventHandler(checkBoxDelay_CheckedChanged);
		this.checkBoxLuongThuyTHP.AutoSize = true;
		this.checkBoxLuongThuyTHP.ForeColor = System.Drawing.Color.Black;
		this.checkBoxLuongThuyTHP.Location = new System.Drawing.Point(206, 187);
		this.checkBoxLuongThuyTHP.Name = "checkBoxLuongThuyTHP";
		this.checkBoxLuongThuyTHP.Size = new System.Drawing.Size(274, 19);
		this.checkBoxLuongThuyTHP.TabIndex = 463;
		this.checkBoxLuongThuyTHP.Text = "Ac phụ sẽ chạy bộ nếu ac chính ở Lưỡng Thủy";
		this.checkBoxLuongThuyTHP.UseVisualStyleBackColor = true;
		this.checkBoxLuongThuyTHP.CheckedChanged += new System.EventHandler(checkBoxLuongThuyTHP_CheckedChanged);
		this.checkBoxBaoCsKenhbang.AutoSize = true;
		this.checkBoxBaoCsKenhbang.ForeColor = System.Drawing.Color.Black;
		this.checkBoxBaoCsKenhbang.Location = new System.Drawing.Point(22, 77);
		this.checkBoxBaoCsKenhbang.Name = "checkBoxBaoCsKenhbang";
		this.checkBoxBaoCsKenhbang.Size = new System.Drawing.Size(151, 19);
		this.checkBoxBaoCsKenhbang.TabIndex = 462;
		this.checkBoxBaoCsKenhbang.Text = "Báo cừu sát kênh bang";
		this.checkBoxBaoCsKenhbang.UseVisualStyleBackColor = true;
		this.checkBoxBaoCsKenhbang.CheckedChanged += new System.EventHandler(checkBoxBaoCsKenhbang_CheckedChanged);
		this.checkBoxThongbaoTHP.AutoSize = true;
		this.checkBoxThongbaoTHP.ForeColor = System.Drawing.Color.Black;
		this.checkBoxThongbaoTHP.Location = new System.Drawing.Point(206, 211);
		this.checkBoxThongbaoTHP.Name = "checkBoxThongbaoTHP";
		this.checkBoxThongbaoTHP.Size = new System.Drawing.Size(274, 19);
		this.checkBoxThongbaoTHP.TabIndex = 461;
		this.checkBoxThongbaoTHP.Text = "Tắt thông báo không đi được THP trong game";
		this.checkBoxThongbaoTHP.UseVisualStyleBackColor = true;
		this.checkBoxThongbaoTHP.CheckedChanged += new System.EventHandler(checkBoxThongbaoTHP_CheckedChanged);
		this.tabPageLienMay.Controls.Add(this.tabControlKeoLienmay);
		this.tabPageLienMay.Controls.Add(this.buttonCacChucNangDkTuxa);
		this.tabPageLienMay.Controls.Add(this.labelThongbao2);
		this.tabPageLienMay.Controls.Add(this.labelThongbao1);
		this.tabPageLienMay.Location = new System.Drawing.Point(4, 24);
		this.tabPageLienMay.Name = "tabPageLienMay";
		this.tabPageLienMay.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageLienMay.Size = new System.Drawing.Size(489, 432);
		this.tabPageLienMay.TabIndex = 1;
		this.tabPageLienMay.Text = "Kéo nhiều máy";
		this.tabPageLienMay.UseVisualStyleBackColor = true;
		this.tabControlKeoLienmay.Controls.Add(this.tabPage4);
		this.tabControlKeoLienmay.Controls.Add(this.tabPage5);
		this.tabControlKeoLienmay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.tabControlKeoLienmay.Location = new System.Drawing.Point(1, 1);
		this.tabControlKeoLienmay.Name = "tabControlKeoLienmay";
		this.tabControlKeoLienmay.SelectedIndex = 0;
		this.tabControlKeoLienmay.Size = new System.Drawing.Size(489, 396);
		this.tabControlKeoLienmay.TabIndex = 0;
		this.tabPage4.Controls.Add(this.button1);
		this.tabPage4.Controls.Add(this.buttonTatFirewall);
		this.tabPage4.Controls.Add(this.buttonPhimHd1);
		this.tabPage4.Controls.Add(this.buttonXoa);
		this.tabPage4.Controls.Add(this.progressBar1);
		this.tabPage4.Controls.Add(this.buttonKetthuc);
		this.tabPage4.Controls.Add(this.buttonBatdau);
		this.tabPage4.Controls.Add(this.groupBoxHientai);
		this.tabPage4.Controls.Add(this.groupBoxConnect);
		this.tabPage4.Controls.Add(this.richTextBoxStatus);
		this.tabPage4.Controls.Add(this.comboBoxConnect);
		this.tabPage4.Location = new System.Drawing.Point(4, 22);
		this.tabPage4.Name = "tabPage4";
		this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage4.Size = new System.Drawing.Size(481, 370);
		this.tabPage4.TabIndex = 0;
		this.tabPage4.Text = "Kiểu 1 (mạng LAN cùng IP)";
		this.tabPage4.UseVisualStyleBackColor = true;
		this.button1.BackColor = System.Drawing.SystemColors.Control;
		this.button1.ForeColor = System.Drawing.Color.MediumBlue;
		this.button1.Location = new System.Drawing.Point(3, 325);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(232, 41);
		this.button1.TabIndex = 484;
		this.button1.Text = "Tắt Firewall (trên Win 8, 10, 11)";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.buttonTatFirewall.BackColor = System.Drawing.SystemColors.Control;
		this.buttonTatFirewall.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonTatFirewall.Location = new System.Drawing.Point(2, 282);
		this.buttonTatFirewall.Name = "buttonTatFirewall";
		this.buttonTatFirewall.Size = new System.Drawing.Size(235, 37);
		this.buttonTatFirewall.TabIndex = 483;
		this.buttonTatFirewall.Text = "Tắt Firewall (trên Win7)";
		this.buttonTatFirewall.UseVisualStyleBackColor = false;
		this.buttonTatFirewall.Click += new System.EventHandler(buttonTatFirewall_Click);
		this.buttonPhimHd1.BackColor = System.Drawing.SystemColors.Control;
		this.buttonPhimHd1.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonPhimHd1.Location = new System.Drawing.Point(243, 306);
		this.buttonPhimHd1.Name = "buttonPhimHd1";
		this.buttonPhimHd1.Size = new System.Drawing.Size(230, 60);
		this.buttonPhimHd1.TabIndex = 479;
		this.buttonPhimHd1.Text = "Phim hướng dẫn kéo mạng LAN";
		this.buttonPhimHd1.UseVisualStyleBackColor = false;
		this.buttonPhimHd1.Click += new System.EventHandler(buttonPhimHd1_Click);
		this.buttonXoa.Location = new System.Drawing.Point(452, 280);
		this.buttonXoa.Name = "buttonXoa";
		this.buttonXoa.Size = new System.Drawing.Size(23, 21);
		this.buttonXoa.TabIndex = 473;
		this.buttonXoa.Text = "X";
		this.buttonXoa.UseVisualStyleBackColor = true;
		this.buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		this.progressBar1.Location = new System.Drawing.Point(243, 282);
		this.progressBar1.Name = "progressBar1";
		this.progressBar1.Size = new System.Drawing.Size(206, 18);
		this.progressBar1.TabIndex = 479;
		this.buttonKetthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f);
		this.buttonKetthuc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
		this.buttonKetthuc.Location = new System.Drawing.Point(112, 237);
		this.buttonKetthuc.Name = "buttonKetthuc";
		this.buttonKetthuc.Size = new System.Drawing.Size(124, 39);
		this.buttonKetthuc.TabIndex = 471;
		this.buttonKetthuc.Text = "Kết thúc";
		this.buttonKetthuc.UseVisualStyleBackColor = true;
		this.buttonKetthuc.Click += new System.EventHandler(buttonKetthuc_Click);
		this.buttonBatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f);
		this.buttonBatdau.ForeColor = System.Drawing.Color.Red;
		this.buttonBatdau.Location = new System.Drawing.Point(2, 237);
		this.buttonBatdau.Name = "buttonBatdau";
		this.buttonBatdau.Size = new System.Drawing.Size(103, 39);
		this.buttonBatdau.TabIndex = 470;
		this.buttonBatdau.Text = "Bắt đầu";
		this.buttonBatdau.UseVisualStyleBackColor = true;
		this.buttonBatdau.Click += new System.EventHandler(buttonBatdau_Click);
		this.groupBoxHientai.Controls.Add(this.buttonCopy);
		this.groupBoxHientai.Controls.Add(this.comboBoxTabAddr);
		this.groupBoxHientai.Controls.Add(this.label1);
		this.groupBoxHientai.Controls.Add(this.label5);
		this.groupBoxHientai.Controls.Add(this.buttonRandom);
		this.groupBoxHientai.Controls.Add(this.textBoxPassServer);
		this.groupBoxHientai.Location = new System.Drawing.Point(1, 2);
		this.groupBoxHientai.Name = "groupBoxHientai";
		this.groupBoxHientai.Size = new System.Drawing.Size(234, 97);
		this.groupBoxHientai.TabIndex = 474;
		this.groupBoxHientai.TabStop = false;
		this.groupBoxHientai.Text = "Thông tin máy đang chạy";
		this.buttonCopy.BackColor = System.Drawing.SystemColors.Control;
		this.buttonCopy.ForeColor = System.Drawing.Color.Black;
		this.buttonCopy.Location = new System.Drawing.Point(178, 30);
		this.buttonCopy.Name = "buttonCopy";
		this.buttonCopy.Size = new System.Drawing.Size(47, 24);
		this.buttonCopy.TabIndex = 482;
		this.buttonCopy.Text = "Copy";
		this.buttonCopy.UseVisualStyleBackColor = false;
		this.buttonCopy.Click += new System.EventHandler(buttonCopy_Click);
		this.comboBoxTabAddr.FormattingEnabled = true;
		this.comboBoxTabAddr.Location = new System.Drawing.Point(50, 30);
		this.comboBoxTabAddr.Name = "comboBoxTabAddr";
		this.comboBoxTabAddr.Size = new System.Drawing.Size(124, 21);
		this.comboBoxTabAddr.TabIndex = 458;
		this.comboBoxTabAddr.SelectedIndexChanged += new System.EventHandler(comboBoxTabAddr_SelectedIndexChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(9, 33);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(32, 13);
		this.label1.TabIndex = 5;
		this.label1.Text = "IP (1)";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(9, 62);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(30, 13);
		this.label5.TabIndex = 6;
		this.label5.Text = "Pass";
		this.buttonRandom.BackColor = System.Drawing.SystemColors.Control;
		this.buttonRandom.ForeColor = System.Drawing.Color.Black;
		this.buttonRandom.Location = new System.Drawing.Point(180, 59);
		this.buttonRandom.Name = "buttonRandom";
		this.buttonRandom.Size = new System.Drawing.Size(47, 24);
		this.buttonRandom.TabIndex = 457;
		this.buttonRandom.Text = "Đổi";
		this.buttonRandom.UseVisualStyleBackColor = false;
		this.buttonRandom.Click += new System.EventHandler(buttonRandom_Click);
		this.textBoxPassServer.Location = new System.Drawing.Point(50, 59);
		this.textBoxPassServer.Name = "textBoxPassServer";
		this.textBoxPassServer.Size = new System.Drawing.Size(124, 20);
		this.textBoxPassServer.TabIndex = 7;
		this.textBoxPassServer.Leave += new System.EventHandler(textBoxPassServer_Leave);
		this.groupBoxConnect.Controls.Add(this.textBoxConnectPass);
		this.groupBoxConnect.Controls.Add(this.label4);
		this.groupBoxConnect.Controls.Add(this.label6);
		this.groupBoxConnect.Controls.Add(this.textBoxIPConnect);
		this.groupBoxConnect.Location = new System.Drawing.Point(1, 106);
		this.groupBoxConnect.Name = "groupBoxConnect";
		this.groupBoxConnect.Size = new System.Drawing.Size(234, 90);
		this.groupBoxConnect.TabIndex = 475;
		this.groupBoxConnect.TabStop = false;
		this.groupBoxConnect.Text = "Máy chính cần kết nối đến";
		this.textBoxConnectPass.Location = new System.Drawing.Point(51, 54);
		this.textBoxConnectPass.Name = "textBoxConnectPass";
		this.textBoxConnectPass.Size = new System.Drawing.Size(173, 20);
		this.textBoxConnectPass.TabIndex = 460;
		this.textBoxConnectPass.TextChanged += new System.EventHandler(textBoxConnectPass_TextChanged);
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(9, 30);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(32, 13);
		this.label4.TabIndex = 458;
		this.label4.Text = "IP (2)";
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(9, 59);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 13);
		this.label6.TabIndex = 459;
		this.label6.Text = "Pass";
		this.textBoxIPConnect.Location = new System.Drawing.Point(51, 28);
		this.textBoxIPConnect.Name = "textBoxIPConnect";
		this.textBoxIPConnect.Size = new System.Drawing.Size(173, 20);
		this.textBoxIPConnect.TabIndex = 7;
		this.textBoxIPConnect.TextChanged += new System.EventHandler(textBoxIPConnect_TextChanged);
		this.richTextBoxStatus.Location = new System.Drawing.Point(243, 7);
		this.richTextBoxStatus.Name = "richTextBoxStatus";
		this.richTextBoxStatus.Size = new System.Drawing.Size(230, 268);
		this.richTextBoxStatus.TabIndex = 476;
		this.richTextBoxStatus.Text = resources.GetString("richTextBoxStatus.Text");
		this.comboBoxConnect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxConnect.FormattingEnabled = true;
		this.comboBoxConnect.Location = new System.Drawing.Point(2, 205);
		this.comboBoxConnect.Name = "comboBoxConnect";
		this.comboBoxConnect.Size = new System.Drawing.Size(233, 21);
		this.comboBoxConnect.TabIndex = 469;
		this.comboBoxConnect.SelectedIndexChanged += new System.EventHandler(comboBoxConnect_SelectedIndexChanged);
		this.tabPage5.Controls.Add(this.groupBox2);
		this.tabPage5.Controls.Add(this.textBox1);
		this.tabPage5.Controls.Add(this.label13);
		this.tabPage5.Controls.Add(this.label11);
		this.tabPage5.Controls.Add(this.textBoxKytuLenh);
		this.tabPage5.Controls.Add(this.numericUpDownPassword);
		this.tabPage5.Controls.Add(this.textBoxTen);
		this.tabPage5.Controls.Add(this.label3);
		this.tabPage5.Controls.Add(this.checkBoxPassword);
		this.tabPage5.Controls.Add(this.checkBoxAcChihuy);
		this.tabPage5.Controls.Add(this.label8);
		this.tabPage5.Controls.Add(this.checkBoxAcChinhNghelenh);
		this.tabPage5.Controls.Add(this.buttonDanhsachMayphu);
		this.tabPage5.Controls.Add(this.checkBoxRoom);
		this.tabPage5.Controls.Add(this.checkBoxKhoaChatmat);
		this.tabPage5.Location = new System.Drawing.Point(4, 22);
		this.tabPage5.Name = "tabPage5";
		this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage5.Size = new System.Drawing.Size(481, 370);
		this.tabPage5.TabIndex = 1;
		this.tabPage5.Text = "Kiểu 2 (chát mật, dành cho các máy không cùng IP )";
		this.tabPage5.UseVisualStyleBackColor = true;
		this.groupBox2.Controls.Add(this.buttonHelp);
		this.groupBox2.Controls.Add(this.label16);
		this.groupBox2.Controls.Add(this.label9);
		this.groupBox2.Controls.Add(this.label10);
		this.groupBox2.Controls.Add(this.label14);
		this.groupBox2.Controls.Add(this.numericUpDown1);
		this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
		this.groupBox2.Location = new System.Drawing.Point(3, 3);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(583, 184);
		this.groupBox2.TabIndex = 350;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Mã hóa tọa độ theo level";
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(322, 29);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(33, 13);
		this.label16.TabIndex = 350;
		this.label16.Text = "Level";
		this.label9.ForeColor = System.Drawing.Color.Black;
		this.label9.Location = new System.Drawing.Point(6, 110);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(352, 52);
		this.label9.TabIndex = 343;
		this.label9.Text = resources.GetString("label9.Text");
		this.label10.ForeColor = System.Drawing.Color.MediumBlue;
		this.label10.Location = new System.Drawing.Point(6, 68);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(305, 27);
		this.label10.TabIndex = 340;
		this.label10.Text = "Lưu ý: Phần <Máy phụ luôn đến tọa độ bên> ở bảng 2 máy chính thì không áp dụng được cho kéo nhiều máy kiểu 2 này";
		this.label14.ForeColor = System.Drawing.Color.Black;
		this.label14.Location = new System.Drawing.Point(6, 22);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(319, 35);
		this.label14.TabIndex = 349;
		this.label14.Text = "Nếu game có chế độ anti báo tọa độ (làm dis game hoặc rớt mạng ac) thì phải đặt level cao lên. Level = 0 là không mã hóa.";
		this.numericUpDown1.ForeColor = System.Drawing.Color.Black;
		this.numericUpDown1.Location = new System.Drawing.Point(370, 24);
		this.numericUpDown1.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
		this.numericUpDown1.Name = "numericUpDown1";
		this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
		this.numericUpDown1.TabIndex = 348;
		this.numericUpDown1.ValueChanged += new System.EventHandler(numericUpDown1_ValueChanged);
		this.textBox1.Location = new System.Drawing.Point(411, 344);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(41, 20);
		this.textBox1.TabIndex = 346;
		this.textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(161, 348);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(248, 13);
		this.label13.TabIndex = 345;
		this.label13.Text = "Tốc độ báo (ms, nếu dễ bị dis game thì để cao lên)";
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(261, 327);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(144, 13);
		this.label11.TabIndex = 342;
		this.label11.Text = "Ký tự ngăn cách câu lệnh =>";
		this.textBoxKytuLenh.Location = new System.Drawing.Point(411, 322);
		this.textBoxKytuLenh.Name = "textBoxKytuLenh";
		this.textBoxKytuLenh.Size = new System.Drawing.Size(41, 20);
		this.textBoxKytuLenh.TabIndex = 341;
		this.textBoxKytuLenh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBoxKytuLenh.TextChanged += new System.EventHandler(textBoxKytuLenh_TextChanged);
		this.labelThongbao2.AutoSize = true;
		this.labelThongbao2.Location = new System.Drawing.Point(218, 106);
		this.labelThongbao2.Name = "labelThongbao2";
		this.labelThongbao2.Size = new System.Drawing.Size(69, 15);
		this.labelThongbao2.TabIndex = 480;
		this.labelThongbao2.Text = "01/01/2019";
		this.labelThongbao2.Visible = false;
		this.labelThongbao1.Location = new System.Drawing.Point(10, 83);
		this.labelThongbao1.Name = "labelThongbao1";
		this.labelThongbao1.Size = new System.Drawing.Size(539, 15);
		this.labelThongbao1.TabIndex = 479;
		this.labelThongbao1.Text = "Chức năng kéo nhiều máy đã bị ad game khóa đến:";
		this.labelThongbao1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.labelThongbao1.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(497, 459);
		base.Controls.Add(this.tabControl1);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormRauria";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "MO RONG";
		base.Load += new System.EventHandler(FormRauria_Load);
		((System.ComponentModel.ISupportInitialize)this.numericUpDownKhongdanhCapnho).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownPassword).EndInit();
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage1.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.tabPageLienMay.ResumeLayout(false);
		this.tabPageLienMay.PerformLayout();
		this.tabControlKeoLienmay.ResumeLayout(false);
		this.tabPage4.ResumeLayout(false);
		this.groupBoxHientai.ResumeLayout(false);
		this.groupBoxHientai.PerformLayout();
		this.groupBoxConnect.ResumeLayout(false);
		this.groupBoxConnect.PerformLayout();
		this.tabPage5.ResumeLayout(false);
		this.tabPage5.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
		base.ResumeLayout(false);
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
		Class66.smethod_11(Class66.smethod_1(), "tabRRControl1", tabControl1.SelectedIndex, "", 0);
		Class66.smethod_11(Class66.smethod_1(), "tabRRControl2", tabControlKeoLienmay.SelectedIndex, "", 0);
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num >= 0)
		{
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		}
	}

	private void FormRauria_Load(object sender, EventArgs e)
	{
		if (GClass1.string_1 == null || GClass1.string_1 != "True")
		{
			tabControl1.Controls.Remove(tabPageLienMay);
		}
		timer_0.Enabled = false;
		if (string_2 == null)
		{
			string_2 = richTextBoxStatus.Text;
		}
		if (int_2 >= 0 && int_3 >= 0)
		{
			int num = int_2 - base.Width;
			int num2 = int_3 + int_5 - base.Height;
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
		if (Class9.string_1.Length <= GClass1.int_1 && GClass1.long_0 == 0L)
		{
			labelThongbao1.Visible = true;
			labelThongbao1.Text = "Đang kích hoạt server...";
			tabPageLienMay.Controls.Remove(tabControlKeoLienmay);
		}
		bool flag = false;
		if (!AuxiliaryMachineManager.bool_1 && Form1.characterAccountConfig_1 == null)
		{
			int num3 = -1;
			if (GClass1.gstruct15_0.bool_0 && GClass1.gstruct15_0.uint_1 != null && GClass1.gstruct16_0 != null)
			{
				for (int i = 0; i < GClass1.gstruct16_0.Length; i++)
				{
					if (GClass1.gstruct16_0[i].long_0 <= GClass1.long_1)
					{
						continue;
					}
					int num4 = 0;
					while (num4 < GClass1.gstruct15_0.uint_1.Length)
					{
						if (GClass1.gstruct16_0[i].uint_0 != GClass1.gstruct15_0.uint_1[num4])
						{
							num4++;
							continue;
						}
						goto IL_01c9;
					}
					continue;
					IL_01c9:
					num3 = i;
					break;
				}
			}
			if (0 <= num3)
			{
				DateTime dateTime = new DateTime(GClass1.gstruct16_0[num3].long_0);
				AuxiliaryMachineManager.int_1 = new int[3] { dateTime.Day, dateTime.Month, dateTime.Year };
				AuxiliaryMachineManager.string_1 = GClass1.gstruct16_0[num3].string_1;
				AuxiliaryMachineManager.bool_2 = GClass1.gstruct16_0[num3].int_0 == 1;
				flag = true;
			}
		}
		if (AuxiliaryMachineManager.bool_1 || flag)
		{
			tabPageLienMay.Controls.Remove(tabControlKeoLienmay);
			labelThongbao1.Visible = true;
			labelThongbao2.Visible = true;
			if (AuxiliaryMachineManager.int_1 != null)
			{
				labelThongbao2.Text = "Ngày " + AuxiliaryMachineManager.int_1[0] + " Tháng " + AuxiliaryMachineManager.int_1[1] + ", " + AuxiliaryMachineManager.int_1[2];
			}
			if (AuxiliaryMachineManager.string_1 != null && AuxiliaryMachineManager.string_1 != string.Empty)
			{
				labelThongbao1.Text = "Chức năng kéo nhiều máy đã bị ad game " + AuxiliaryMachineManager.string_1 + " khóa đến:";
			}
		}
		tabControl1.SelectedIndex = Class66.smethod_4("tabRRControl1", 0, "0");
		tabControlKeoLienmay.SelectedIndex = Class66.smethod_4("tabRRControl2", 0, "0");
		checkBoxBaoCuusat.Checked = Form1.int_18 > 0;
		checkBoxBaoCuusatPhucan.Checked = Form1.int_20 > 0;
		checkBoxBaoCsKenhbang.Checked = Form1.int_19 > 0;
		textBoxKhoangCachlenNgua.Text = Form1.int_108.ToString();
		checkBoxKhongDanhAccCungbang.Checked = Form1.int_110 > 0;
		checkBoxSuado.Checked = Form1.int_61 > 0;
		checkBoxDoiPKTheoAccChinh.Checked = Form1.int_89 > 0;
		checkBoxTroLaiDiemcu.Checked = Form1.int_90 > 0;
		checkBoxKhongdanhCapnho.Checked = Form1.int_92 > 0;
		numericUpDownKhongdanhCapnho.Value = Form1.int_93;
		checkBoxKhongChaybo.Checked = Form1.int_23 > 0;
		checkBoxAcChinhNghelenh.Checked = Form1.int_11 > 0;
		checkBoxDanhKhongten.Checked = Form1.int_123 > 0;
		checkBoxTHP_Smdb.Checked = Form1.int_15 > 0;
		checkBoxXuongngua.Checked = Form1.int_109 > 0;
		checkBoxRoom.Checked = Form1.int_12 > 0;
		checkBoxKhoaChatmat.Checked = Form1.int_13 > 0;
		checkBoxDelay.Checked = Form1.int_75 > 0;
		textBoxValueDelay.Text = Form1.int_76.ToString();
		checkBoxLuongThuyTHP.Checked = Class37.int_0 > 0;
		checkBoxPassword.Checked = Form1.int_53 > 0;
		numericUpDownPassword.Value = Form1.int_54;
		numericUpDown1.Value = Form1.int_55;
		checkBoxDanhDenchet.Checked = Form1.int_56 > 0;
		if (AuxiliaryMachineManager.string_3 == null || AuxiliaryMachineManager.string_3 == string.Empty)
		{
			AuxiliaryMachineManager.string_3 = "|";
		}
		textBoxKytuLenh.Text = AuxiliaryMachineManager.string_3[0].ToString();
		textBox1.Text = AuxiliaryMachineManager.int_2.ToString();
		checkBoxThongbaoTHP.Checked = Form1.int_125 > 0;
		checkBoxTienToida.Checked = Form1.int_67[0] > 0;
		textBoxTienToida.Text = Form1.int_67[1].ToString();
		checkBoxNhapMatma.Checked = Form1.int_91 > 0;
		checkBoxTatThongbaoDame.Checked = Form1.int_126 > 0;
		checkBoxMouseDrag.Checked = Form1.int_127 > 0;
		checkBoxLuonDanhbang.Checked = Class72.int_1 > 0;
		if (AuxiliaryMachineManager.bool_4)
		{
			checkBoxKhongdanhBang.Text = "Khóa bởi adgame";
			checkBoxKhongdanhBang.Enabled = false;
			comboBoxKhongDanh.Enabled = false;
			Class72.int_2 = 0;
		}
		checkBoxKhongdanhBang.Checked = Class72.int_2 > 0;
		checkBoxKhongdanhAc.Checked = Class72.int_3 > 0;
		textBoxTiepCan.Text = Form1.int_57.ToString();
		if (Class72.string_4 != null)
		{
			for (int j = 0; j < Class72.string_4.Length; j++)
			{
				if (Class72.string_4[j] != null)
				{
					method_0(listViewLuonDanh, Class1.smethod_1(Class72.string_4[j], 1));
				}
			}
		}
		if (Class72.string_3 != null)
		{
			for (int k = 0; k < Class72.string_3.Length; k++)
			{
				if (Class72.string_3[k] != null)
				{
					method_0(listViewKhongDanh, Class1.smethod_1(Class72.string_3[k], 1));
				}
			}
		}
		if (Class72.string_5 != null)
		{
			for (int l = 0; l < Class72.string_5.Length; l++)
			{
				if (Class72.string_5[l] != null)
				{
					method_0(listViewKhongdanhAc, Class1.smethod_1(Class72.string_5[l], 1));
				}
			}
		}
		string text = null;
		string[] array = Class77.smethod_0();
		if (array != null)
		{
			if (Class77.string_1 == null || Class77.string_1 == string.Empty)
			{
				Class77.string_1 = array[0];
			}
			for (int m = 0; m < array.Length; m++)
			{
				comboBoxTabAddr.Items.Add(array[m]);
				if (Class77.string_1 == array[m])
				{
					text = Class77.string_1;
				}
			}
		}
		if (text == null && Class77.string_1 != null && Class77.string_1 != string.Empty)
		{
			comboBoxTabAddr.Items.Add(Class77.string_1);
			text = Class77.string_1;
		}
		if (text != null)
		{
			comboBoxTabAddr.Text = text;
		}
		if (Class77.int_2 <= 0)
		{
			Class77.int_2 = random_0.Next(int_9, int_10);
			Class66.smethod_11(Class66.smethod_1(), "PortServer", Class77.int_2, "", 0);
		}
		textBoxPassServer.Text = Class77.int_2.ToString();
		textBoxIPConnect.Text = Class77.string_2;
		textBoxConnectPass.Text = Class77.int_3.ToString();
		for (int n = 0; n < string_1.Length; n++)
		{
			comboBoxConnect.Items.Add(string_1[n]);
		}
		comboBoxConnect.Text = string_1[Class77.int_1];
		groupBoxHientai.Enabled = Class77.int_1 == 0;
		groupBoxConnect.Enabled = Class77.int_1 > 0;
		string text2 = string_2.Replace("|", Class56.string_7);
		if (Class77.string_0 != null && Class77.string_0 != string.Empty)
		{
			text2 = text2 + Class56.string_7 + Class77.string_0;
		}
		richTextBoxStatus.Text = text2;
		int_7 = -1;
		long_0 = Class77.long_0;
		progressBar1.Style = ProgressBarStyle.Continuous;
		timer_0.Interval = 100;
		timer_0.Enabled = true;
		bool_1 = true;
		base.TopMost = true;
	}

	private void method_0(ListView listView_0, string string_7)
	{
		try
		{
			string[] array = new string[1] { string_7 };
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

	public static void smethod_0(ListView listView_0, string string_7, string[] string_8, ref string[] string_9)
	{
		if (string_7 == null || string_7 == string.Empty || string_8 == null)
		{
			return;
		}
		if (string_9 != null)
		{
			for (int i = 0; i < string_9.Length; i++)
			{
				if (string_7 == Class1.smethod_1(string_9[i], 1))
				{
					return;
				}
			}
		}
		for (int j = 0; j < string_8.Length; j++)
		{
			if (string_7 == Class1.smethod_1(string_8[j], 1))
			{
				string_7 = string_8[j];
				break;
			}
		}
		if (string_9 != null)
		{
			string[] array = new string[string_9.Length + 1];
			for (int k = 0; k < string_9.Length; k++)
			{
				array[k] = string_9[k];
			}
			string_9 = new string[array.Length];
			for (int l = 0; l < string_9.Length; l++)
			{
				string_9[l] = array[l];
			}
			string_9[string_9.Length - 1] = string_7;
		}
		else
		{
			string_9 = new string[1] { string_7 };
		}
		try
		{
			string[] array2 = new string[1] { Class1.smethod_1(string_7, 1) };
			ListViewItem value = new ListViewItem(array2[0]);
			listView_0.Items.Add(value);
		}
		catch
		{
		}
	}

	public static void smethod_1(ComboBox comboBox_0, ref string[] string_7)
	{
		string_7 = null;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Class3.smethod_25(Form1.characterAccountConfig_1[i], ref string_7, 1);
			}
		}
		comboBox_0.Items.Clear();
		if (string_7 != null)
		{
			Array.Sort(string_7);
			for (int j = 0; j < string_7.Length; j++)
			{
				comboBox_0.Items.Add(Class1.smethod_1(string_7[j], 1));
			}
		}
	}

	public static void smethod_2(ListView listView_0, ref string[] string_7)
	{
		if (string_7 != null && string_7.Length != 0)
		{
			string empty = string.Empty;
			for (int i = 0; i < listView_0.Items.Count; i++)
			{
				if (listView_0.Items[i].Selected)
				{
					empty = listView_0.Items[i].SubItems[0].Text;
					listView_0.Items.RemoveAt(i);
					break;
				}
			}
			if (empty == null || empty == string.Empty)
			{
				return;
			}
			string[] array = new string[string_7.Length];
			int num = 0;
			for (int j = 0; j < string_7.Length; j++)
			{
				if (empty != Class1.smethod_1(string_7[j], 1))
				{
					array[num] = string_7[j];
					num++;
				}
			}
			if (num == 0)
			{
				string_7 = null;
				return;
			}
			string_7 = new string[num];
			for (int k = 0; k < num; k++)
			{
				string_7[k] = array[k];
			}
		}
		else
		{
			listView_0.Items.Clear();
			string_7 = null;
		}
	}

	public static void smethod_3(RichTextBox richTextBox_0, string string_7, bool bool_3 = false)
	{
		if (string_7 != null && !(string_7 == string.Empty))
		{
			if (richTextBox_0.Text != string.Empty)
			{
				string_7 = Class56.string_7 + string_7;
			}
			int num = Class24.GetScrollPos(richTextBox_0.Handle, 1);
			richTextBox_0.AppendText(string_7);
			if (!bool_3)
			{
				Class24.GetScrollRange(richTextBox_0.Handle, 1, out var _, out var int_2);
				int num2 = (richTextBox_0.ClientSize.Height - SystemInformation.HorizontalScrollBarHeight) / richTextBox_0.Font.Height;
				num = int_2 - num2;
			}
			Class24.SetScrollPos(richTextBox_0.Handle, 1, num, bool_0: true);
			Class24.PostMessageA(richTextBox_0.Handle, 277, 4 + 65536 * num, 0);
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_2 && !AuxiliaryMachineManager.bool_8)
		{
			buttonEpDanhBang.Enabled = true;
			bool_2 = false;
		}
		if (bool_0)
		{
			if (int_1 > 0)
			{
				int_1++;
				if (int_1 > 12)
				{
					checkBoxAcChihuy.Enabled = true;
					int_1 = 0;
				}
			}
			bool flag = Class77.int_0 > 0;
			if (int_7 != Class77.int_0)
			{
				buttonBatdau.Enabled = !flag;
				buttonKetthuc.Enabled = flag;
				comboBoxConnect.Enabled = !flag;
				buttonRandom.Enabled = !flag;
				comboBoxTabAddr.Enabled = !flag;
				int_7 = Class77.int_0;
				textBoxIPConnect.ReadOnly = Class77.int_0 > 0;
				textBoxConnectPass.ReadOnly = Class77.int_0 > 0;
				textBoxPassServer.ReadOnly = Class77.int_0 > 0;
			}
			int_8++;
			if (long_0 != Class77.long_0)
			{
				long_0 = Class77.long_0;
				if (progressBar1.MarqueeAnimationSpeed != 300)
				{
					progressBar1.Style = ProgressBarStyle.Marquee;
					progressBar1.MarqueeAnimationSpeed = 300;
				}
				int_8 = 0;
			}
			else if (int_8 > 10)
			{
				progressBar1.Style = ProgressBarStyle.Continuous;
				progressBar1.MarqueeAnimationSpeed = 0;
			}
			if (Class77.string_0 != null && Class77.string_0 != string.Empty)
			{
				smethod_3(richTextBoxStatus, Class77.string_0);
				Class77.string_0 = null;
			}
			if (int_6 == int_0)
			{
				return;
			}
			bool_1 = false;
			if (int_6 > 0)
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_6);
				if (0 <= num)
				{
					Class56.smethod_13(Form1.characterAccountConfig_1[num]);
				}
			}
			int_6 = int_0;
			int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			flag = 0 <= num2;
			string text = "[chưa chọn ac]";
			if (flag)
			{
				characterAccountConfig_0 = Form1.characterAccountConfig_1[num2];
				text = "[" + Class1.smethod_1(characterAccountConfig_0.string_22, 1) + "]";
				checkBoxAcChihuy.Checked = characterAccountConfig_0.int_2 > 0;
			}
			textBoxTen.Text = text;
			checkBoxAcChihuy.Enabled = flag;
			Thread.Sleep(100);
			bool_1 = true;
		}
		else
		{
			Close();
		}
	}

	private void checkBoxKhongdanhCapnho_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_92 = Convert.ToByte(checkBoxKhongdanhCapnho.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagKhongDanhCapnho", Form1.int_92, "", 0);
		}
	}

	private void numericUpDownKhongdanhCapnho_ValueChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_93 = (int)numericUpDownKhongdanhCapnho.Value;
			Class66.smethod_11(Class66.smethod_1(), "ValueCapBoqua", Form1.int_93, "", 0);
		}
	}

	private void numericUpDownKhongdanhCapnho_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_93 = (int)numericUpDownKhongdanhCapnho.Value;
			Class66.smethod_11(Class66.smethod_1(), "ValueCapBoqua", Form1.int_93, "", 0);
		}
	}

	private void textBoxKhoangCachlenNgua_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_108 = Class11.smethod_11(textBoxKhoangCachlenNgua.Text);
			Class66.smethod_11(Class66.smethod_1(), "KhoangCachLenNguaEx", Form1.int_108, "", 0);
		}
	}

	private void checkBoxDoiPKTheoAccChinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_89 = Convert.ToByte(checkBoxDoiPKTheoAccChinh.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagDoiPKTheoAccChinh", Form1.int_89, "", 0);
		}
	}

	private void checkBoxKhongDanhAccCungbang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_110 = Convert.ToByte(checkBoxKhongDanhAccCungbang.Checked);
			Class66.smethod_11(Class66.smethod_1(), "KhongdanhCungBang", Form1.int_110, "", 0);
		}
	}

	private void checkBoxBaoCuusat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_18 = Convert.ToByte(checkBoxBaoCuusat.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagBaoCuusatMat", Form1.int_18, "", 0);
		}
	}

	private void checkBoxSuado_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_61 = Convert.ToByte(checkBoxSuado.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagSuadoTaichoEx", Form1.int_61, "", 0);
		}
	}

	private void buttonThietlapSuado_Click(object sender, EventArgs e)
	{
		if (FormSuado.int_0 > 0)
		{
			FormSuado.int_0 = 0;
			return;
		}
		try
		{
			FormSuado formSuado = new FormSuado();
			formSuado.Show();
		}
		catch
		{
		}
	}

	private void checkBoxTroLaiDiemcu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_90 = Convert.ToByte(checkBoxTroLaiDiemcu.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagTrolaiDiemcu", Form1.int_90, "", 0);
		}
	}

	private void checkBoxKhongChaybo_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_23 = Convert.ToByte(checkBoxKhongChaybo.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagKhongChaybo", Form1.int_23, "", 0);
		}
	}

	private void labelBoqua_Click(object sender, EventArgs e)
	{
		string text = "Các bản đồ bỏ qua không chạy bộ:|";
		if (Class45.int_0 != null)
		{
			for (int i = 0; i < Class45.int_0.Length; i++)
			{
				string text2 = text;
				text = text2 + (i + 1) + ". " + Class1.smethod_1(Class39.smethod_1(Class45.int_0[i]), 1) + "|";
			}
		}
		FormTip.smethod_0(Form1.string_49, text, 600000, 280, 280);
	}

	private void checkBoxAcChinhNghelenh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_11 = Convert.ToByte(checkBoxAcChinhNghelenh.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagKeo2", Form1.int_11, "", 0);
		}
	}

	private void checkBoxAcChihuy_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num >= 0)
		{
			int num2 = Convert.ToByte(checkBoxAcChihuy.Checked);
			Form1.characterAccountConfig_1[num].int_2 = num2;
			if (num2 > 0)
			{
				Form1.int_11 = 0;
				checkBoxAcChinhNghelenh.Checked = false;
				AuxiliaryMachineManager.int_0 = Form1.characterAccountConfig_1[num].int_136;
				new Thread(AuxiliaryMachineManager.smethod_3).Start();
			}
			else
			{
				int_1 = 1;
				checkBoxAcChihuy.Enabled = false;
			}
		}
	}

	private void buttonHelp_Click(object sender, EventArgs e)
	{
		string newValue = "https://www.facebook.com/share/p/18w1wjUDoF/   /";
		string text = Class11.smethod_72("dVRPaxNBFL/vp3hHlXWh8RZESNPQSmwqtqV6TCZld0kzm252C3uUHoqIYOmpiJg15KBNsBpB3EFymNjvMd/E92Z386/2Mklm3vz+vTfZ2t+pbcJGqQYbTyv7UK3swMsKbJdeQXWrVDaM547bBufmWokP3IamSq44BCqJXZiey89REQ4q67vGPeZ1ImjKmMOJ7HkQ+HLIHWiGkRJnAXCVTEJoOfInYrSV+ISXCbLP7luGsemqpA9dJUbA5BgK0JZxZOoVGkjFsdpV4jUh4OcpB1uJdy4cyV5atJYVt9z6fLOAyA9gW58XjYewrpGY40GdQcdRYgCcpKKNMS7TU5TGHZWMOqmFjiN/4FYgNT/SYvkYgtRDQ8YenCjxlpyOCJE5csQdC6ppAZdfOebxG78uAjF9yJS45LaZFh1pysUi38V9OyNF/BiTbBDXcaiSQQS+EueuhZbKziFrpWox1AGDxyVGpiIMM/lzt0jLeoK3a8ROeRRMeDQPhWnRy4EsqkO6rOb/WaSys15r2dxWybcA1cs+t+ddKVBXSrmorGkrxOxWgmnD73SfgQVy2EZ9h4vCAt9DEN/z2lkAezhNySTIOqCru/WwmM/Isq78ePVkbWbYTVnzyaZ4hnpmmEPPAMf2OKzPcYiFrsZgo4xRgMHs4rYex0Y2q0q8gRMc+TNGIYoLF+jtLPGuPA1rNVGqS99qmCq65YzOtSqitoya7cmeC37dzJ5tLiYzgaqSiSa/hIPSCxPKe2Vcnk3fm4RAw4qdjt3ZL25TIB9x4+YaNdBwQ8Prdk3d5F+BxrowodPCvuB/i7jKlWu9M8cFYH+/0Bgo8T3lp6eUyyIHlvEP").Replace("WEBS", newValue);
		FormTip.smethod_0(Form1.string_49, text, 600000, 440, 300);
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(string_))
		{
			string_ = Class66.smethod_0();
		}
		Class24.smethod_40(string_, "", newValue, 0);
	}

	private void checkBoxTHP_Smdb_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_15 = Convert.ToByte(checkBoxTHP_Smdb.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagLienthongMapAB", Form1.int_15, "", 0);
		}
	}

	private void labelLienthongGiaithich_Click(object sender, EventArgs e)
	{
		string text = "CHẠY BỘ Ở CÁC MAP LIÊN THÔNG:||Map liên thông là 2 bản đồ kề nhau, chỉ cần đi qua 1 cổng là tới liền. Ví dụ map liên thông:||* Sa mạc 1, 2, 3 -> liên thông Sa mạc địa biểu|* La tiêu sơn -> Lưỡng thủy động.|* v.v..||Tại sao phải chạy bộ?||Bởi nếu sử dụng Thần hành phù thì có thể nó lên đầu cổng, khoảng cách đến ac chính có khi lại xa hơn khi chạy bộ qua cổng.||Đó là chưa kể sẽ bị lag (ví dụ cầu thang ở smđb) hoặc bị sai vị trí (ví dụ lưỡng thủy động có 2 động, cần đến động 1 nhưng thần hành phù lại đến động 2)....||Khi không có map liên thông, hoặc chạy bộ không thành công thì auto sẽ xét đến Thần hành phù.|";
		FormTip.smethod_0(Form1.string_49, text, 600000, 380, 320);
	}

	private void checkBoxBaoCuusatPhucan_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_20 = Convert.ToByte(checkBoxBaoCuusatPhucan.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagBaoCuusatPhucan", Form1.int_20, "", 0);
		}
	}

	private void buttonCacChucNangDkTuxa_Click(object sender, EventArgs e)
	{
		string text = "CÁC MỤC MÁY CHÍNH ĐIỀU KHIỂN ĐƯỢC MÁY PHỤ:||1. Tìm ac chính, tìm trong thành|2. Đánh người, quái, ưu tiên boss.|3. Đổi Pk theo ac chính, dame mặc định|4. Đánh Chiến long động: Chọn cổng lên|5. Chiến trường CTC: Thất thành và tam trụ.|6. Đánh Tống Kim: Báo danh, ac chính ac phụ ra khỏi hậu doanh.||7. Phần chuyển thuốc từ hành rương Bang Hội sang Hành trang:|- Máy phụ bạn phải chọn trước tên túi thuốc cần chuyển.|- Máy phụ luôn mặc định là chuyển 5 túi / lần.||8. Web của game (mục cài game): luôn lấy theo máy chính.|9. CTC: mục dùng THP luôn lấy theo máy chính.|10. Đến tọa độ canh boss|12. Danh sách đánh bang hội, không đánh bang hội và không đánh ac.";
		FormTip.smethod_0(Form1.string_49, text, 600000, 420, 230);
	}

	private void checkBoxXuongngua_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_109 = Convert.ToByte(checkBoxXuongngua.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagXuongNguaSansang", Form1.int_109, "", 0);
		}
	}

	private void buttonDanhsachMayphu_Click(object sender, EventArgs e)
	{
		if (AuxiliaryMachineManager.bool_0)
		{
			AuxiliaryMachineManager.bool_0 = false;
			return;
		}
		try
		{
			AuxiliaryMachineManager auxiliaryMachineManager = new AuxiliaryMachineManager();
			auxiliaryMachineManager.int_3 = Cursor.Position.X;
			auxiliaryMachineManager.int_4 = Cursor.Position.Y;
			auxiliaryMachineManager.int_5 = base.Width;
			auxiliaryMachineManager.int_6 = base.Height;
			auxiliaryMachineManager.Show();
		}
		catch
		{
		}
	}

	private void checkBoxRoom_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_12 = Convert.ToByte(checkBoxRoom.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagBaoroom", Form1.int_12, "", 0);
		}
	}

	private void checkBoxKhoaChatmat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_13 = Convert.ToByte(checkBoxKhoaChatmat.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagKhoaChatmat", Form1.int_13, "", 0);
		}
	}

	private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_53 = Convert.ToByte(checkBoxPassword.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagPassKeoNhieumay", Form1.int_53, "", 0);
		}
	}

	private void numericUpDownPassword_ValueChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_54 = (int)numericUpDownPassword.Value;
			Class66.smethod_11(Class66.smethod_1(), "PassKeoNhieumay", Form1.int_54, "", 0);
		}
	}

	private void numericUpDownPassword_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_54 = (int)numericUpDownPassword.Value;
			Class66.smethod_11(Class66.smethod_1(), "PassKeoNhieumay", Form1.int_54, "", 0);
		}
	}

	private void method_1(ListView listView_0, ref string[] string_7)
	{
		if (string_7 != null && string_7.Length != 0)
		{
			string empty = string.Empty;
			for (int i = 0; i < listView_0.Items.Count; i++)
			{
				if (listView_0.Items[i].Selected)
				{
					empty = listView_0.Items[i].SubItems[0].Text;
					listView_0.Items.RemoveAt(i);
					break;
				}
			}
			if (empty == null || empty == string.Empty)
			{
				return;
			}
			string[] array = new string[string_7.Length];
			int num = 0;
			for (int j = 0; j < string_7.Length; j++)
			{
				if (empty != Class1.smethod_1(string_7[j], 1))
				{
					array[num] = string_7[j];
					num++;
				}
			}
			if (num == 0)
			{
				listView_0.Items.Clear();
				string_7 = null;
				return;
			}
			string_7 = new string[num];
			for (int k = 0; k < num; k++)
			{
				string_7[k] = array[k];
			}
		}
		else
		{
			listView_0.Items.Clear();
			string_7 = null;
		}
	}

	private void method_2(ListView listView_0, string string_7, string[] string_8, ref string[] string_9)
	{
		if (string_7 == null || string_7 == string.Empty || string_8 == null)
		{
			return;
		}
		if (string_9 != null)
		{
			for (int i = 0; i < string_9.Length; i++)
			{
				if (string_7 == Class1.smethod_1(string_9[i], 1))
				{
					return;
				}
			}
		}
		for (int j = 0; j < string_8.Length; j++)
		{
			if (string_7 == Class1.smethod_1(string_8[j], 1))
			{
				string_7 = string_8[j];
				break;
			}
		}
		if (string_9 != null)
		{
			string[] array = new string[string_9.Length + 1];
			for (int k = 0; k < string_9.Length; k++)
			{
				array[k] = string_9[k];
			}
			string_9 = new string[array.Length];
			for (int l = 0; l < string_9.Length; l++)
			{
				string_9[l] = array[l];
			}
			string_9[string_9.Length - 1] = string_7;
		}
		else
		{
			string_9 = new string[1] { string_7 };
		}
		method_0(listView_0, Class1.smethod_1(string_7, 1));
	}

	private void comboBoxLuonDanh_MouseDown(object sender, MouseEventArgs e)
	{
		string_4 = null;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Class3.smethod_24(Form1.characterAccountConfig_1[i], ref string_4);
			}
		}
		comboBoxLuonDanh.Items.Clear();
		if (string_4 != null)
		{
			Array.Sort(string_4);
			for (int j = 0; j < string_4.Length; j++)
			{
				comboBoxLuonDanh.Items.Add(Class1.smethod_1(string_4[j], 1));
			}
		}
	}

	private void comboBoxKhongDanh_MouseDown(object sender, MouseEventArgs e)
	{
		string_5 = null;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Class3.smethod_24(Form1.characterAccountConfig_1[i], ref string_5);
			}
		}
		comboBoxKhongDanh.Items.Clear();
		if (string_5 != null)
		{
			Array.Sort(string_5);
			for (int j = 0; j < string_5.Length; j++)
			{
				comboBoxKhongDanh.Items.Add(Class1.smethod_1(string_5[j], 1));
			}
		}
	}

	private void comboBoxKhongdanhAc_MouseDown(object sender, MouseEventArgs e)
	{
		string_6 = null;
		if (Form1.characterAccountConfig_1 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				Class3.smethod_25(Form1.characterAccountConfig_1[i], ref string_6, 1);
			}
		}
		comboBoxKhongdanhAc.Items.Clear();
		if (string_6 != null)
		{
			Array.Sort(string_6);
			for (int j = 0; j < string_6.Length; j++)
			{
				comboBoxKhongdanhAc.Items.Add(Class1.smethod_1(string_6[j], 1));
			}
		}
	}

	private void checkBoxLuonDanhbang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class72.int_1 = Convert.ToByte(checkBoxLuonDanhbang.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagLuonDanhBHO", Class72.int_1, "", 0);
		}
	}

	private void checkBoxKhongdanhBang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class72.int_2 = Convert.ToByte(checkBoxKhongdanhBang.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagKhongDanhBHO", Class72.int_2, "", 0);
		}
	}

	private void checkBoxKhongdanhAc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class72.int_3 = Convert.ToByte(checkBoxKhongdanhAc.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagKhongdanhAc", Class72.int_3, "", 0);
		}
	}

	private void checkBoxDanhDenchet_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_56 = Convert.ToByte(checkBoxDanhDenchet.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagDanhDenchet", Form1.int_56, "", 0);
		}
	}

	private void textBoxTiepCan_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_57 = Class11.smethod_11(textBoxTiepCan.Text);
			Class66.smethod_11(Class66.smethod_1(), "KCAcdanhTiepcan", Form1.int_57, "", 0);
		}
	}

	private void labelTiepcan_Click(object sender, EventArgs e)
	{
		string text = "KHOẢNG CÁCH TÌM AC CHÍNH CỦA AC ĐÁNH TIẾP CẬN||- Ac đánh tiếp cận ở đây là ac sử dụng chiêu đánh có phạm vi hiệu quả <= 180.|- Yêu cầu: Có check vào mục tiếp cận ở Bảng 1 của auto, và ô giá trị tiếp cận ghi 180 trở xuống.|";
		FormTip.smethod_0(Form1.string_49, text, 600000, 380, 140);
	}

	private void buttonRandom_Click(object sender, EventArgs e)
	{
		bool_1 = false;
		Class77.int_2 = random_0.Next(int_9, int_10);
		textBoxPassServer.Text = Class77.int_2.ToString();
		Class66.smethod_11(Class66.smethod_1(), "PortServer", Class77.int_2, "", 0);
		bool_1 = true;
		MessageBox.Show("Lưu ý ở máy phụ phải ghi đúng passowrd là " + Class77.int_2 + " thì mới kết nối được.", Form1.string_49, MessageBoxButtons.OK);
	}

	private void textBoxIPConnect_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class77.string_2 = textBoxIPConnect.Text.Trim();
			Class66.smethod_11(Class66.smethod_1(), "ConnectIP", Class77.string_2, "", 0);
		}
	}

	private void textBoxConnectPass_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class77.int_3 = Class11.smethod_11(textBoxConnectPass.Text.Trim());
			Class66.smethod_11(Class66.smethod_1(), "nPort", Class77.int_3, "", 0);
		}
	}

	private void comboBoxConnect_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_0.Enabled || !bool_1)
		{
			return;
		}
		for (int i = 0; i < string_1.Length; i++)
		{
			if (comboBoxConnect.Text == string_1[i])
			{
				Class77.int_1 = i;
				break;
			}
		}
		groupBoxHientai.Enabled = Class77.int_1 == 0;
		groupBoxConnect.Enabled = Class77.int_1 > 0;
		Class66.smethod_11(Class66.smethod_1(), "KieuConnect", Class77.int_1, "", 0);
	}

	private void buttonBatdau_Click(object sender, EventArgs e)
	{
		if (Class77.int_1 <= 0)
		{
			if (Class77.string_2 == null || Class77.string_2 == string.Empty)
			{
				Class77.string_2 = comboBoxTabAddr.Text;
			}
			if (Class77.int_2 < int_9 || Class77.int_2 > int_10)
			{
				Class77.int_2 = random_0.Next(int_9, int_10);
				Class66.smethod_11(Class66.smethod_1(), "PortServer", Class77.int_2, "", 0);
				textBoxPassServer.Text = Class77.int_2.ToString();
				MessageBox.Show("Password phải là số từ " + int_9 + " -> " + int_10 + ", auto tự động lấy lại password khác là " + Class77.int_2, Form1.string_49, MessageBoxButtons.OK);
			}
			FormCompatibility.smethod_5();
			Thread.Sleep(300);
			Class77.int_0 = 1;
			Class77.class78_0 = new Class78();
			new Thread(Class77.class78_0.method_1).Start();
		}
		else
		{
			if (Class77.int_3 < int_9 || Class77.int_3 > int_10)
			{
				MessageBox.Show("Pasword không hợp lệ, nó phải giống như password ở máy chính.", Form1.string_49, MessageBoxButtons.OK);
				return;
			}
			FormCompatibility.smethod_5();
			Thread.Sleep(300);
			Class77.int_0 = 1;
			Class77.class79_0 = new Class79();
			new Thread(Class77.class79_0.method_1).Start();
		}
		int_7 = -1;
	}

	private void buttonKetthuc_Click(object sender, EventArgs e)
	{
		Form1.int_10 = 0;
		checkBoxAcChinhNghelenh.Checked = false;
		Class77.int_0 = 0;
		try
		{
			if (Class77.int_1 > 0)
			{
				Class77.class79_0.method_2();
			}
			else
			{
				Class77.class78_0.method_2();
			}
		}
		catch
		{
		}
		int_7 = -1;
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		richTextBoxStatus.Text = string.Empty;
	}

	private void textBoxPassServer_Leave(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			int num = Class11.smethod_11(textBoxPassServer.Text);
			if (num < int_9 || num > int_10)
			{
				num = random_0.Next(int_9, int_10);
				textBoxPassServer.Text = num.ToString();
				MessageBox.Show("Password phải là số từ " + int_9 + " -> " + int_10 + ", auto tự động lấy lại password khác là " + num, Form1.string_49, MessageBoxButtons.OK);
			}
			Class77.int_2 = num;
			Class66.smethod_11(Class66.smethod_1(), "PortServer", Class77.int_2, "", 0);
		}
	}

	private void textBoxKytuLenh_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			string text = textBoxKytuLenh.Text;
			if (text == string.Empty)
			{
				text = "|";
			}
			AuxiliaryMachineManager.string_3 = text[0].ToString();
			Class66.smethod_11(Class66.smethod_1(), "SMayphu", AuxiliaryMachineManager.string_3, "", 0);
		}
	}

	private void comboBoxTabAddr_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class77.string_1 = comboBoxTabAddr.Text;
		}
	}

	private void buttonCopy_Click(object sender, EventArgs e)
	{
		try
		{
			Clipboard.SetText(comboBoxTabAddr.Text);
		}
		catch
		{
		}
	}

	private void checkBoxThongbaoTHP_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_125 = Convert.ToByte(checkBoxThongbaoTHP.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fThongbaoTHP", Form1.int_125, "", 0);
		}
	}

	private void checkBoxBaoCsKenhbang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_19 = Convert.ToByte(checkBoxBaoCsKenhbang.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagBaoCuusatBang", Form1.int_19, "", 0);
		}
	}

	private void comboBoxLuonDanh_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_2(listViewLuonDanh, comboBoxLuonDanh.Text, string_4, ref Class72.string_4);
		Class72.smethod_1(Class72.string_4, Class72.string_0);
		Class72.uint_1 = Class72.smethod_2(Class72.string_4);
	}

	private void comboBoxKhongDanh_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_2(listViewKhongDanh, comboBoxKhongDanh.Text, string_5, ref Class72.string_3);
		Class72.smethod_1(Class72.string_3, Class72.string_1);
		Class72.uint_0 = Class72.smethod_2(Class72.string_3);
	}

	private void comboBoxKhongdanhAc_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_2(listViewKhongdanhAc, comboBoxKhongdanhAc.Text, string_6, ref Class72.string_5);
		Class72.smethod_1(Class72.string_5, Class72.string_2);
	}

	private void buttonXoaLuonDanh_Click(object sender, EventArgs e)
	{
		method_1(listViewLuonDanh, ref Class72.string_4);
		Class72.smethod_1(Class72.string_4, Class72.string_0);
		Class72.uint_1 = Class72.smethod_2(Class72.string_4);
	}

	private void buttonKhongDanhBang_Click(object sender, EventArgs e)
	{
		method_1(listViewKhongDanh, ref Class72.string_3);
		Class72.smethod_1(Class72.string_3, Class72.string_1);
		Class72.uint_0 = Class72.smethod_2(Class72.string_3);
	}

	private void buttonXoaDanhAc_Click(object sender, EventArgs e)
	{
		method_1(listViewKhongdanhAc, ref Class72.string_5);
		Class72.smethod_1(Class72.string_5, Class72.string_2);
	}

	private void buttonPhimHd1_Click(object sender, EventArgs e)
	{
		string text = "https://www.facebook.com/share/p/18w1wjUDoF/   /";
		string text2 = "Phim hướng dẫn tại đây: " + text + "||(copy dán vào trình duyệt nếu không mở được)";
		FormTip.smethod_0(Form1.string_49, text2, 600000, 440, 100);
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(string_))
		{
			string_ = Class66.smethod_0();
		}
		Class24.smethod_40(string_, "", text, 0);
	}

	private void buttonEpPT_Click(object sender, EventArgs e)
	{
		if (Form1.characterAccountConfig_1 == null)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
		{
			GStruct61 gStruct = Class88.smethod_5(Form1.characterAccountConfig_1[i]);
			if (gStruct.int_0 <= 0)
			{
				continue;
			}
			for (int j = 0; j < gStruct.int_0; j++)
			{
				bool flag = false;
				if (Class72.string_5 != null)
				{
					for (int k = 0; k < Class72.string_5.Length; k++)
					{
						if (Class72.string_5[k] == gStruct.gstruct60_0[j].string_0)
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					if (num == 0)
					{
						Class72.string_5 = new string[0];
						num = 1;
					}
					Array.Resize(ref Class72.string_5, Class72.string_5.Length + 1);
					Class72.string_5[Class72.string_5.Length - 1] = gStruct.gstruct60_0[j].string_0;
				}
			}
		}
		if (num > 0)
		{
			listViewKhongdanhAc.Items.Clear();
			for (int l = 0; l < Class72.string_5.Length; l++)
			{
				method_0(listViewKhongdanhAc, Class1.smethod_1(Class72.string_5[l], 1));
			}
			Class72.smethod_1(Class72.string_5, Class72.string_2);
		}
	}

	private void buttonEpDanhBang_Click(object sender, EventArgs e)
	{
		if (Form1.int_10 <= 0 && Form1.int_11 <= 0)
		{
			AuxiliaryMachineManager.bool_8 = true;
			bool_2 = true;
			buttonEpDanhBang.Enabled = false;
		}
	}

	private void checkBoxLuongThuyTHP_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Class37.int_0 = Convert.ToByte(checkBoxLuongThuyTHP.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fChayboLThuydong", Class37.int_0, "", 0);
		}
	}

	private void checkBoxDelay_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_75 = Convert.ToByte(checkBoxDelay.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fNguoiChoiTuGiam", Form1.int_75, "", 0);
			Class95.int_0 = -1;
		}
	}

	private void textBoxValueDelay_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_76 = Class11.smethod_11(textBoxValueDelay.Text);
			if (Form1.int_76 < 0)
			{
				Form1.int_76 = 0;
			}
			else if (Form1.int_76 > 1500)
			{
				Form1.int_76 = 1500;
			}
			Class66.smethod_11(Class66.smethod_1(), "vGiamDelay", Form1.int_76, "", 0);
			Class95.int_0 = -1;
		}
	}

	private void checkBoxTienToida_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_67[0] = Convert.ToByte(checkBoxTienToida.Checked);
			Class66.smethod_11(Class66.smethod_1(), "RuttienMax_00", Form1.int_67[0], "", 0);
		}
	}

	private void textBoxTienToida_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_67[1] = Class11.smethod_11(textBoxTienToida.Text);
			if (Form1.int_67[1] < 30)
			{
				Form1.int_67[1] = 30;
			}
			Class66.smethod_11(Class66.smethod_1(), "RuttienMax_01", Form1.int_67[1], "", 0);
		}
	}

	private void checkBoxNhapMatma_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_91 = Convert.ToByte(checkBoxNhapMatma.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fMatmaXaphu", Form1.int_91, "", 0);
		}
	}

	private void labelMatma_Click(object sender, EventArgs e)
	{
		string text = "https://www.facebook.com/share/p/18w1wjUDoF/   /";
		string text2 = "Phim hướng dẫn tại đây: " + text + "||(copy dán vào trình duyệt nếu không mở được)";
		FormTip.smethod_0(Form1.string_49, text2, 600000, 440, 100);
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(string_))
		{
			string_ = Class66.smethod_0();
		}
		Class24.smethod_40(string_, "", text, 0);
	}

	private void checkBoxTatThongbaoDame_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_126 = Convert.ToByte(checkBoxTatThongbaoDame.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fTatBaoDame", Form1.int_126, "", 0);
		}
	}

	private void checkBoxMouseDrag_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_127 = Convert.ToByte(checkBoxMouseDrag.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fBatMouseDrag", Form1.int_127, "", 0);
		}
	}

	private void checkBoxDanhKhongten_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_123 = Convert.ToByte(checkBoxDanhKhongten.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagDanhKhongten", Form1.int_123, "", 0);
		}
	}

	private void buttonTatFirewall_Click(object sender, EventArgs e)
	{
		string text = "https://youtu.be/TRVdeyXbW94";
		string text2 = "Phim hướng dẫn tại đây: " + text + Class56.string_7 + Class56.string_7 + "(copy dán vào trình duyệt nếu không mở được)";
		richTextBoxStatus.Text = text2;
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(string_))
		{
			string_ = Class66.smethod_0();
		}
		Class24.smethod_40(string_, "", text, 0);
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			AuxiliaryMachineManager.int_2 = Class11.smethod_11(textBox1.Text);
			Class66.smethod_11(Class66.smethod_1(), "TocdoBaoToado", AuxiliaryMachineManager.int_2, "", 0);
		}
	}

	private void numericUpDown1_ValueChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled && bool_1)
		{
			Form1.int_55 = (int)numericUpDown1.Value;
			Class66.smethod_11(Class66.smethod_1(), "Mahoatoado", Form1.int_55, "", 0);
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		string text = "https://www.facebook.com/share/p/18w1wjUDoF/   /";
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(string_))
		{
			string_ = Class66.smethod_0();
		}
		Class24.smethod_40(string_, "", text, 0);
	}
}
