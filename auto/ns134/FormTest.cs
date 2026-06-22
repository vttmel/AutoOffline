using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns134;

public class FormTest : Form
{
	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static CharacterAccountConfig characterAccountConfig_0 = default(CharacterAccountConfig);

	public static int int_0 = 0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	private IContainer icontainer_0 = null;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private CheckBox checkBoxPhimTat;

	private Button buttonLayToado;

	private TextBox textBoxNPCObjectInfo;

	private TabPage tabPage2;

	private Timer timer_0;

	private TextBox textBoxIndex;

	private Button buttonClear;

	private Button buttonTdSingle;

	private Button buttonCopyDefine;

	private Button buttonCopyNPCObjGannhat;

	private Button buttonLamMap;

	private Button buttonTenNPCgannhat;

	private Button buttonGetIndexInfo;

	private Button buttonGetAllNPCObject;

	private Button buttonXemMaloi;

	private Button buttonDialogGetText;

	private Button buttonTitleMenu;

	private Button buttonGetChanelAllTop;

	private GroupBox groupBox2;

	private Button buttonMoThumuc;

	private Button buttonMaHoa;

	private Button buttonFileMahoa;

	private TextBox textBoxMaHoa2;

	private TextBox textBoxFileMahoa;

	private Label label5;

	private GroupBox groupBox3;

	private TextBox textBoxSum1;

	private Button buttonSum2;

	private Button buttonSum1;

	private TextBox textBoxSum2;

	private Label labelKetQuaSum;

	private TextBox textBoxKetQuaSum2;

	private TextBox textBoxKetQuaSum1;

	private TabPage tabPage3;

	private Label label10;

	private Label label9;

	private Label label8;

	private ComboBox comboBoxFind;

	private Button buttonXoaNhatky;

	private Button buttonStopFind;

	private TextBox textBoxTep;

	private Button buttonBatdau;

	private RichTextBox richTextBoxResult;

	private Button buttonDelete;

	private Button buttonPaste;

	private Button buttonBrowss;

	private Label label7;

	private TextBox textBoxFolder;

	private Label label6;

	private TabPage tabPage4;

	private Button buttonBatdautaoPHLT;

	private Label label12;

	private TextBox textBoxPHLT;

	private Label label11;

	private Button buttonCreateTK;

	private TextBox textBoxCountStart;

	private Button buttonOpenFile;

	private TextBox textBoxFile;

	private Button buttonPaste2;

	private TextBox textBoxThoigianGiancach;

	private Label label13;

	private TextBox textBoxTk;

	private Label label14;

	private Button buttonTenTabKTC;

	private Button buttonSortcutSkill;

	private TabPage tabPage5;

	private Button button6;

	private Button button4;

	private TextBox textBox2;

	private Label label15;

	private Button button9;

	private Button button7;

	private Label label18;

	private TextBox textBox3;

	private Button button3;

	private Button button2;

	private Button button1;

	private Button button8;

	private Label label16;

	private TextBox textBoxpw;

	private Button button5;

	private CheckBox checkBoxDocFile;

	private Button buttonBrowse;

	private Label label17;

	private TextBox textBox1;

	private TextBox textBoxStatus;

	private CheckBox checkBoxKhongDecript;

	private Button buttonAllSkill;

	private CheckBox checkBoxFont;

	private Button buttonLine;

	private TextBox textBoxLine;

	private Button button11;

	public FormTest()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	private void FormTest_Load(object sender, EventArgs e)
	{
		timer_0.Interval = 300;
		timer_0.Enabled = true;
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
	}

	private void checkBoxPhimTat_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void method_0(string string_0, bool bool_2 = true, bool bool_3 = true)
	{
	}

	private void buttonLayToado_Click(object sender, EventArgs e)
	{
	}

	private void buttonClear_Click(object sender, EventArgs e)
	{
	}

	private void buttonCopyDefine_Click(object sender, EventArgs e)
	{
	}

	private void buttonTdSingle_Click(object sender, EventArgs e)
	{
	}

	private void buttonGetIndexInfo_Click(object sender, EventArgs e)
	{
	}

	private void buttonLamMap_Click(object sender, EventArgs e)
	{
	}

	private void buttonCopyNPCObjGannhat_Click(object sender, EventArgs e)
	{
	}

	private void buttonGetAllNPCObject_Click(object sender, EventArgs e)
	{
	}

	private void buttonTenNPCgannhat_Click(object sender, EventArgs e)
	{
	}

	private void buttonXemMaloi_Click(object sender, EventArgs e)
	{
	}

	private void buttonDialogGetText_Click(object sender, EventArgs e)
	{
	}

	private void buttonTitleMenu_Click(object sender, EventArgs e)
	{
	}

	private void buttonGetChanelAllTop_Click(object sender, EventArgs e)
	{
	}

	private void buttonFileMahoa_Click(object sender, EventArgs e)
	{
	}

	private void buttonMoThumuc_Click(object sender, EventArgs e)
	{
	}

	private void buttonMaHoa_Click(object sender, EventArgs e)
	{
	}

	private void buttonSum1_Click(object sender, EventArgs e)
	{
	}

	private void buttonSum2_Click(object sender, EventArgs e)
	{
	}

	private void buttonPaste_Click(object sender, EventArgs e)
	{
	}

	private void buttonDelete_Click(object sender, EventArgs e)
	{
	}

	private void buttonBrowss_Click(object sender, EventArgs e)
	{
	}

	private void buttonBatdau_Click(object sender, EventArgs e)
	{
	}

	private void buttonStopFind_Click(object sender, EventArgs e)
	{
	}

	private void method_1()
	{
	}

	private void buttonXoaNhatky_Click(object sender, EventArgs e)
	{
	}

	private void comboBoxFind_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void buttonCreateTK_Click(object sender, EventArgs e)
	{
	}

	private void buttonBatdautaoPHLT_Click(object sender, EventArgs e)
	{
	}

	private void buttonOpenFile_Click(object sender, EventArgs e)
	{
	}

	private void textBoxFile_TextChanged(object sender, EventArgs e)
	{
	}

	private void buttonPaste2_Click(object sender, EventArgs e)
	{
	}

	private void buttonTenTabKTC_Click(object sender, EventArgs e)
	{
	}

	private void buttonSortcutSkill_Click(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void buttonBrowse_Click(object sender, EventArgs e)
	{
	}

	private void button5_Click(object sender, EventArgs e)
	{
	}

	private void button8_Click(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
	}

	private void button3_Click(object sender, EventArgs e)
	{
	}

	private void button7_Click(object sender, EventArgs e)
	{
	}

	private void button9_Click(object sender, EventArgs e)
	{
	}

	private void button4_Click(object sender, EventArgs e)
	{
	}

	private void button6_Click(object sender, EventArgs e)
	{
	}

	private void buttonAllSkill_Click(object sender, EventArgs e)
	{
	}

	private void checkBoxFont_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void buttonLine_Click(object sender, EventArgs e)
	{
	}

	private void textBoxNPCObjectInfo_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void button11_Click(object sender, EventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns134.FormTest));
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.buttonLine = new System.Windows.Forms.Button();
		this.buttonClear = new System.Windows.Forms.Button();
		this.buttonTdSingle = new System.Windows.Forms.Button();
		this.checkBoxFont = new System.Windows.Forms.CheckBox();
		this.buttonAllSkill = new System.Windows.Forms.Button();
		this.buttonLayToado = new System.Windows.Forms.Button();
		this.buttonSortcutSkill = new System.Windows.Forms.Button();
		this.buttonTenTabKTC = new System.Windows.Forms.Button();
		this.buttonGetChanelAllTop = new System.Windows.Forms.Button();
		this.buttonTitleMenu = new System.Windows.Forms.Button();
		this.buttonDialogGetText = new System.Windows.Forms.Button();
		this.buttonCopyNPCObjGannhat = new System.Windows.Forms.Button();
		this.buttonLamMap = new System.Windows.Forms.Button();
		this.buttonTenNPCgannhat = new System.Windows.Forms.Button();
		this.buttonGetIndexInfo = new System.Windows.Forms.Button();
		this.buttonGetAllNPCObject = new System.Windows.Forms.Button();
		this.buttonCopyDefine = new System.Windows.Forms.Button();
		this.checkBoxPhimTat = new System.Windows.Forms.CheckBox();
		this.textBoxNPCObjectInfo = new System.Windows.Forms.TextBox();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.textBoxKetQuaSum2 = new System.Windows.Forms.TextBox();
		this.textBoxKetQuaSum1 = new System.Windows.Forms.TextBox();
		this.labelKetQuaSum = new System.Windows.Forms.Label();
		this.textBoxSum1 = new System.Windows.Forms.TextBox();
		this.buttonSum2 = new System.Windows.Forms.Button();
		this.buttonSum1 = new System.Windows.Forms.Button();
		this.textBoxSum2 = new System.Windows.Forms.TextBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.buttonMoThumuc = new System.Windows.Forms.Button();
		this.buttonMaHoa = new System.Windows.Forms.Button();
		this.buttonFileMahoa = new System.Windows.Forms.Button();
		this.textBoxMaHoa2 = new System.Windows.Forms.TextBox();
		this.textBoxFileMahoa = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.tabPage3 = new System.Windows.Forms.TabPage();
		this.buttonPaste2 = new System.Windows.Forms.Button();
		this.buttonOpenFile = new System.Windows.Forms.Button();
		this.textBoxFile = new System.Windows.Forms.TextBox();
		this.label10 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.comboBoxFind = new System.Windows.Forms.ComboBox();
		this.buttonXoaNhatky = new System.Windows.Forms.Button();
		this.buttonStopFind = new System.Windows.Forms.Button();
		this.textBoxTep = new System.Windows.Forms.TextBox();
		this.buttonBatdau = new System.Windows.Forms.Button();
		this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
		this.buttonDelete = new System.Windows.Forms.Button();
		this.buttonPaste = new System.Windows.Forms.Button();
		this.buttonBrowss = new System.Windows.Forms.Button();
		this.label7 = new System.Windows.Forms.Label();
		this.textBoxFolder = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.tabPage4 = new System.Windows.Forms.TabPage();
		this.textBoxTk = new System.Windows.Forms.TextBox();
		this.label14 = new System.Windows.Forms.Label();
		this.textBoxThoigianGiancach = new System.Windows.Forms.TextBox();
		this.label13 = new System.Windows.Forms.Label();
		this.buttonBatdautaoPHLT = new System.Windows.Forms.Button();
		this.label12 = new System.Windows.Forms.Label();
		this.textBoxPHLT = new System.Windows.Forms.TextBox();
		this.label11 = new System.Windows.Forms.Label();
		this.buttonCreateTK = new System.Windows.Forms.Button();
		this.textBoxCountStart = new System.Windows.Forms.TextBox();
		this.tabPage5 = new System.Windows.Forms.TabPage();
		this.buttonXemMaloi = new System.Windows.Forms.Button();
		this.checkBoxKhongDecript = new System.Windows.Forms.CheckBox();
		this.textBoxStatus = new System.Windows.Forms.TextBox();
		this.button9 = new System.Windows.Forms.Button();
		this.button7 = new System.Windows.Forms.Button();
		this.label18 = new System.Windows.Forms.Label();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.button3 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.button8 = new System.Windows.Forms.Button();
		this.label16 = new System.Windows.Forms.Label();
		this.textBoxpw = new System.Windows.Forms.TextBox();
		this.button5 = new System.Windows.Forms.Button();
		this.checkBoxDocFile = new System.Windows.Forms.CheckBox();
		this.buttonBrowse = new System.Windows.Forms.Button();
		this.label17 = new System.Windows.Forms.Label();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.button6 = new System.Windows.Forms.Button();
		this.button4 = new System.Windows.Forms.Button();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.label15 = new System.Windows.Forms.Label();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.textBoxIndex = new System.Windows.Forms.TextBox();
		this.textBoxLine = new System.Windows.Forms.TextBox();
		this.button11 = new System.Windows.Forms.Button();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.tabPage2.SuspendLayout();
		this.groupBox3.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.tabPage3.SuspendLayout();
		this.tabPage4.SuspendLayout();
		this.tabPage5.SuspendLayout();
		base.SuspendLayout();
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Controls.Add(this.tabPage3);
		this.tabControl1.Controls.Add(this.tabPage4);
		this.tabControl1.Controls.Add(this.tabPage5);
		this.tabControl1.Location = new System.Drawing.Point(0, 28);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(357, 446);
		this.tabControl1.TabIndex = 0;
		this.tabPage1.Controls.Add(this.buttonLine);
		this.tabPage1.Controls.Add(this.buttonClear);
		this.tabPage1.Controls.Add(this.buttonTdSingle);
		this.tabPage1.Controls.Add(this.checkBoxFont);
		this.tabPage1.Controls.Add(this.buttonAllSkill);
		this.tabPage1.Controls.Add(this.buttonLayToado);
		this.tabPage1.Controls.Add(this.buttonSortcutSkill);
		this.tabPage1.Controls.Add(this.buttonTenTabKTC);
		this.tabPage1.Controls.Add(this.buttonGetChanelAllTop);
		this.tabPage1.Controls.Add(this.buttonTitleMenu);
		this.tabPage1.Controls.Add(this.buttonDialogGetText);
		this.tabPage1.Controls.Add(this.buttonCopyNPCObjGannhat);
		this.tabPage1.Controls.Add(this.buttonLamMap);
		this.tabPage1.Controls.Add(this.buttonTenNPCgannhat);
		this.tabPage1.Controls.Add(this.buttonGetIndexInfo);
		this.tabPage1.Controls.Add(this.buttonGetAllNPCObject);
		this.tabPage1.Controls.Add(this.buttonCopyDefine);
		this.tabPage1.Controls.Add(this.checkBoxPhimTat);
		this.tabPage1.Controls.Add(this.textBoxNPCObjectInfo);
		this.tabPage1.Location = new System.Drawing.Point(4, 22);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(349, 420);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Bảng 1";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.buttonLine.Font = new System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.buttonLine.Location = new System.Drawing.Point(290, 103);
		this.buttonLine.Name = "buttonLine";
		this.buttonLine.Size = new System.Drawing.Size(58, 26);
		this.buttonLine.TabIndex = 63;
		this.buttonLine.Text = "CopyLine";
		this.buttonLine.UseVisualStyleBackColor = true;
		this.buttonLine.Click += new System.EventHandler(buttonLine_Click);
		this.buttonClear.Location = new System.Drawing.Point(233, 0);
		this.buttonClear.Name = "buttonClear";
		this.buttonClear.Size = new System.Drawing.Size(55, 25);
		this.buttonClear.TabIndex = 49;
		this.buttonClear.Text = "<= Clear";
		this.buttonClear.UseVisualStyleBackColor = true;
		this.buttonClear.Click += new System.EventHandler(buttonClear_Click);
		this.buttonTdSingle.Location = new System.Drawing.Point(233, 103);
		this.buttonTdSingle.Name = "buttonTdSingle";
		this.buttonTdSingle.Size = new System.Drawing.Size(55, 26);
		this.buttonTdSingle.TabIndex = 48;
		this.buttonTdSingle.Text = "Copy";
		this.buttonTdSingle.UseVisualStyleBackColor = true;
		this.buttonTdSingle.Click += new System.EventHandler(buttonTdSingle_Click);
		this.checkBoxFont.AutoSize = true;
		this.checkBoxFont.Location = new System.Drawing.Point(290, 3);
		this.checkBoxFont.Name = "checkBoxFont";
		this.checkBoxFont.Size = new System.Drawing.Size(65, 17);
		this.checkBoxFont.TabIndex = 62;
		this.checkBoxFont.Text = ".VnTime";
		this.checkBoxFont.UseVisualStyleBackColor = true;
		this.checkBoxFont.CheckedChanged += new System.EventHandler(checkBoxFont_CheckedChanged);
		this.buttonAllSkill.Location = new System.Drawing.Point(290, 28);
		this.buttonAllSkill.Name = "buttonAllSkill";
		this.buttonAllSkill.Size = new System.Drawing.Size(58, 26);
		this.buttonAllSkill.TabIndex = 61;
		this.buttonAllSkill.Text = "Get Skill";
		this.buttonAllSkill.UseVisualStyleBackColor = true;
		this.buttonAllSkill.Click += new System.EventHandler(buttonAllSkill_Click);
		this.buttonLayToado.Location = new System.Drawing.Point(233, 28);
		this.buttonLayToado.Name = "buttonLayToado";
		this.buttonLayToado.Size = new System.Drawing.Size(55, 26);
		this.buttonLayToado.TabIndex = 45;
		this.buttonLayToado.Text = "Toạ độ\r\n";
		this.buttonLayToado.UseVisualStyleBackColor = true;
		this.buttonLayToado.Click += new System.EventHandler(buttonLayToado_Click);
		this.buttonSortcutSkill.Location = new System.Drawing.Point(96, 369);
		this.buttonSortcutSkill.Name = "buttonSortcutSkill";
		this.buttonSortcutSkill.Size = new System.Drawing.Size(106, 23);
		this.buttonSortcutSkill.TabIndex = 60;
		this.buttonSortcutSkill.Text = "Lấy Sortcut Skill";
		this.buttonSortcutSkill.UseVisualStyleBackColor = true;
		this.buttonSortcutSkill.Click += new System.EventHandler(buttonSortcutSkill_Click);
		this.buttonTenTabKTC.Location = new System.Drawing.Point(0, 368);
		this.buttonTenTabKTC.Name = "buttonTenTabKTC";
		this.buttonTenTabKTC.Size = new System.Drawing.Size(90, 23);
		this.buttonTenTabKTC.TabIndex = 59;
		this.buttonTenTabKTC.Text = "Tên tab  KTC";
		this.buttonTenTabKTC.UseVisualStyleBackColor = true;
		this.buttonTenTabKTC.Click += new System.EventHandler(buttonTenTabKTC_Click);
		this.buttonGetChanelAllTop.Location = new System.Drawing.Point(233, 279);
		this.buttonGetChanelAllTop.Name = "buttonGetChanelAllTop";
		this.buttonGetChanelAllTop.Size = new System.Drawing.Size(115, 26);
		this.buttonGetChanelAllTop.TabIndex = 58;
		this.buttonGetChanelAllTop.Text = "Lấy text ChanelTop";
		this.buttonGetChanelAllTop.UseVisualStyleBackColor = true;
		this.buttonGetChanelAllTop.Click += new System.EventHandler(buttonGetChanelAllTop_Click);
		this.buttonTitleMenu.Location = new System.Drawing.Point(233, 162);
		this.buttonTitleMenu.Name = "buttonTitleMenu";
		this.buttonTitleMenu.Size = new System.Drawing.Size(115, 26);
		this.buttonTitleMenu.TabIndex = 57;
		this.buttonTitleMenu.Text = "Lấy Title Menu_1";
		this.buttonTitleMenu.UseVisualStyleBackColor = true;
		this.buttonTitleMenu.Click += new System.EventHandler(buttonTitleMenu_Click);
		this.buttonDialogGetText.Location = new System.Drawing.Point(233, 251);
		this.buttonDialogGetText.Name = "buttonDialogGetText";
		this.buttonDialogGetText.Size = new System.Drawing.Size(115, 26);
		this.buttonDialogGetText.TabIndex = 56;
		this.buttonDialogGetText.Text = "Lấy dòng text Dialog";
		this.buttonDialogGetText.UseVisualStyleBackColor = true;
		this.buttonDialogGetText.Click += new System.EventHandler(buttonDialogGetText_Click);
		this.buttonCopyNPCObjGannhat.Location = new System.Drawing.Point(233, 396);
		this.buttonCopyNPCObjGannhat.Name = "buttonCopyNPCObjGannhat";
		this.buttonCopyNPCObjGannhat.Size = new System.Drawing.Size(115, 23);
		this.buttonCopyNPCObjGannhat.TabIndex = 55;
		this.buttonCopyNPCObjGannhat.Text = "Copy NPC gần nhất";
		this.buttonCopyNPCObjGannhat.UseVisualStyleBackColor = true;
		this.buttonCopyNPCObjGannhat.Click += new System.EventHandler(buttonCopyNPCObjGannhat_Click);
		this.buttonLamMap.Location = new System.Drawing.Point(96, 396);
		this.buttonLamMap.Name = "buttonLamMap";
		this.buttonLamMap.Size = new System.Drawing.Size(106, 23);
		this.buttonLamMap.TabIndex = 54;
		this.buttonLamMap.Text = "Copy làm Map";
		this.buttonLamMap.UseVisualStyleBackColor = true;
		this.buttonLamMap.Click += new System.EventHandler(buttonLamMap_Click);
		this.buttonTenNPCgannhat.Location = new System.Drawing.Point(233, 371);
		this.buttonTenNPCgannhat.Name = "buttonTenNPCgannhat";
		this.buttonTenNPCgannhat.Size = new System.Drawing.Size(115, 23);
		this.buttonTenNPCgannhat.TabIndex = 53;
		this.buttonTenNPCgannhat.Text = "Tên NPC gần nhất";
		this.buttonTenNPCgannhat.UseVisualStyleBackColor = true;
		this.buttonTenNPCgannhat.Click += new System.EventHandler(buttonTenNPCgannhat_Click);
		this.buttonGetIndexInfo.Location = new System.Drawing.Point(233, 134);
		this.buttonGetIndexInfo.Name = "buttonGetIndexInfo";
		this.buttonGetIndexInfo.Size = new System.Drawing.Size(115, 26);
		this.buttonGetIndexInfo.TabIndex = 51;
		this.buttonGetIndexInfo.Text = "Lấy dòng text Menu";
		this.buttonGetIndexInfo.UseVisualStyleBackColor = true;
		this.buttonGetIndexInfo.Click += new System.EventHandler(buttonGetIndexInfo_Click);
		this.buttonGetAllNPCObject.Location = new System.Drawing.Point(233, 326);
		this.buttonGetAllNPCObject.Name = "buttonGetAllNPCObject";
		this.buttonGetAllNPCObject.Size = new System.Drawing.Size(115, 36);
		this.buttonGetAllNPCObject.TabIndex = 50;
		this.buttonGetAllNPCObject.Text = "Thông tin NPC - Object xung quanh";
		this.buttonGetAllNPCObject.UseVisualStyleBackColor = true;
		this.buttonGetAllNPCObject.Click += new System.EventHandler(buttonGetAllNPCObject_Click);
		this.buttonCopyDefine.Location = new System.Drawing.Point(0, 396);
		this.buttonCopyDefine.Name = "buttonCopyDefine";
		this.buttonCopyDefine.Size = new System.Drawing.Size(90, 23);
		this.buttonCopyDefine.TabIndex = 47;
		this.buttonCopyDefine.Text = "Copy làm Public";
		this.buttonCopyDefine.UseVisualStyleBackColor = true;
		this.buttonCopyDefine.Click += new System.EventHandler(buttonCopyDefine_Click);
		this.checkBoxPhimTat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
		this.checkBoxPhimTat.Location = new System.Drawing.Point(234, 56);
		this.checkBoxPhimTat.Name = "checkBoxPhimTat";
		this.checkBoxPhimTat.Size = new System.Drawing.Size(114, 46);
		this.checkBoxPhimTat.TabIndex = 46;
		this.checkBoxPhimTat.Text = "Phím tắt:\r\n1. ctrl + space\r\n2. shift + space";
		this.checkBoxPhimTat.UseVisualStyleBackColor = false;
		this.checkBoxPhimTat.CheckedChanged += new System.EventHandler(checkBoxPhimTat_CheckedChanged);
		this.textBoxNPCObjectInfo.Location = new System.Drawing.Point(0, 6);
		this.textBoxNPCObjectInfo.Multiline = true;
		this.textBoxNPCObjectInfo.Name = "textBoxNPCObjectInfo";
		this.textBoxNPCObjectInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.textBoxNPCObjectInfo.Size = new System.Drawing.Size(231, 356);
		this.textBoxNPCObjectInfo.TabIndex = 44;
		this.textBoxNPCObjectInfo.WordWrap = false;
		this.textBoxNPCObjectInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(textBoxNPCObjectInfo_MouseDown);
		this.tabPage2.Controls.Add(this.groupBox3);
		this.tabPage2.Controls.Add(this.groupBox2);
		this.tabPage2.Location = new System.Drawing.Point(4, 22);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(323, 420);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "Bảng 2";
		this.tabPage2.UseVisualStyleBackColor = true;
		this.groupBox3.Controls.Add(this.textBoxKetQuaSum2);
		this.groupBox3.Controls.Add(this.textBoxKetQuaSum1);
		this.groupBox3.Controls.Add(this.labelKetQuaSum);
		this.groupBox3.Controls.Add(this.textBoxSum1);
		this.groupBox3.Controls.Add(this.buttonSum2);
		this.groupBox3.Controls.Add(this.buttonSum1);
		this.groupBox3.Controls.Add(this.textBoxSum2);
		this.groupBox3.Location = new System.Drawing.Point(3, 136);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(313, 150);
		this.groupBox3.TabIndex = 61;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Check sum";
		this.textBoxKetQuaSum2.Location = new System.Drawing.Point(6, 92);
		this.textBoxKetQuaSum2.Name = "textBoxKetQuaSum2";
		this.textBoxKetQuaSum2.ReadOnly = true;
		this.textBoxKetQuaSum2.Size = new System.Drawing.Size(224, 20);
		this.textBoxKetQuaSum2.TabIndex = 63;
		this.textBoxKetQuaSum1.Location = new System.Drawing.Point(6, 41);
		this.textBoxKetQuaSum1.Name = "textBoxKetQuaSum1";
		this.textBoxKetQuaSum1.ReadOnly = true;
		this.textBoxKetQuaSum1.Size = new System.Drawing.Size(224, 20);
		this.textBoxKetQuaSum1.TabIndex = 62;
		this.labelKetQuaSum.AutoSize = true;
		this.labelKetQuaSum.Location = new System.Drawing.Point(5, 117);
		this.labelKetQuaSum.Name = "labelKetQuaSum";
		this.labelKetQuaSum.Size = new System.Drawing.Size(59, 13);
		this.labelKetQuaSum.TabIndex = 61;
		this.labelKetQuaSum.Text = "Kết quả: ...";
		this.textBoxSum1.Location = new System.Drawing.Point(6, 19);
		this.textBoxSum1.Name = "textBoxSum1";
		this.textBoxSum1.ReadOnly = true;
		this.textBoxSum1.Size = new System.Drawing.Size(224, 20);
		this.textBoxSum1.TabIndex = 57;
		this.buttonSum2.Location = new System.Drawing.Point(236, 83);
		this.buttonSum2.Name = "buttonSum2";
		this.buttonSum2.Size = new System.Drawing.Size(71, 29);
		this.buttonSum2.TabIndex = 60;
		this.buttonSum2.Text = "File Sum2";
		this.buttonSum2.UseVisualStyleBackColor = true;
		this.buttonSum2.Click += new System.EventHandler(buttonSum2_Click);
		this.buttonSum1.Location = new System.Drawing.Point(237, 29);
		this.buttonSum1.Name = "buttonSum1";
		this.buttonSum1.Size = new System.Drawing.Size(71, 32);
		this.buttonSum1.TabIndex = 58;
		this.buttonSum1.Text = "File Sum1";
		this.buttonSum1.UseVisualStyleBackColor = true;
		this.buttonSum1.Click += new System.EventHandler(buttonSum1_Click);
		this.textBoxSum2.Location = new System.Drawing.Point(6, 70);
		this.textBoxSum2.Name = "textBoxSum2";
		this.textBoxSum2.ReadOnly = true;
		this.textBoxSum2.Size = new System.Drawing.Size(224, 20);
		this.textBoxSum2.TabIndex = 59;
		this.groupBox2.Controls.Add(this.buttonMoThumuc);
		this.groupBox2.Controls.Add(this.buttonMaHoa);
		this.groupBox2.Controls.Add(this.buttonFileMahoa);
		this.groupBox2.Controls.Add(this.textBoxMaHoa2);
		this.groupBox2.Controls.Add(this.textBoxFileMahoa);
		this.groupBox2.Controls.Add(this.label5);
		this.groupBox2.Location = new System.Drawing.Point(3, 3);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(313, 127);
		this.groupBox2.TabIndex = 50;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Mã hóa file";
		this.buttonMoThumuc.Location = new System.Drawing.Point(146, 93);
		this.buttonMoThumuc.Name = "buttonMoThumuc";
		this.buttonMoThumuc.Size = new System.Drawing.Size(84, 23);
		this.buttonMoThumuc.TabIndex = 56;
		this.buttonMoThumuc.Text = "Mở thư mục";
		this.buttonMoThumuc.UseVisualStyleBackColor = true;
		this.buttonMoThumuc.Click += new System.EventHandler(buttonMoThumuc_Click);
		this.buttonMaHoa.Location = new System.Drawing.Point(10, 93);
		this.buttonMaHoa.Name = "buttonMaHoa";
		this.buttonMaHoa.Size = new System.Drawing.Size(130, 23);
		this.buttonMaHoa.TabIndex = 55;
		this.buttonMaHoa.Text = "Mã hóa/Giải mã hóa";
		this.buttonMaHoa.UseVisualStyleBackColor = true;
		this.buttonMaHoa.Click += new System.EventHandler(buttonMaHoa_Click);
		this.buttonFileMahoa.Location = new System.Drawing.Point(236, 38);
		this.buttonFileMahoa.Name = "buttonFileMahoa";
		this.buttonFileMahoa.Size = new System.Drawing.Size(71, 45);
		this.buttonFileMahoa.TabIndex = 54;
		this.buttonFileMahoa.Text = "Tệp mã hóa";
		this.buttonFileMahoa.UseVisualStyleBackColor = true;
		this.buttonFileMahoa.Click += new System.EventHandler(buttonFileMahoa_Click);
		this.textBoxMaHoa2.Location = new System.Drawing.Point(10, 63);
		this.textBoxMaHoa2.Name = "textBoxMaHoa2";
		this.textBoxMaHoa2.ReadOnly = true;
		this.textBoxMaHoa2.Size = new System.Drawing.Size(220, 20);
		this.textBoxMaHoa2.TabIndex = 53;
		this.textBoxFileMahoa.Location = new System.Drawing.Point(10, 40);
		this.textBoxFileMahoa.Name = "textBoxFileMahoa";
		this.textBoxFileMahoa.ReadOnly = true;
		this.textBoxFileMahoa.Size = new System.Drawing.Size(220, 20);
		this.textBoxFileMahoa.TabIndex = 52;
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(7, 16);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(285, 13);
		this.label5.TabIndex = 0;
		this.label5.Text = "Kiểu mã hóa: if (a < 128) => b = a + 128 else => b = a - 128\r\n";
		this.tabPage3.Controls.Add(this.buttonPaste2);
		this.tabPage3.Controls.Add(this.buttonOpenFile);
		this.tabPage3.Controls.Add(this.textBoxFile);
		this.tabPage3.Controls.Add(this.label10);
		this.tabPage3.Controls.Add(this.label9);
		this.tabPage3.Controls.Add(this.label8);
		this.tabPage3.Controls.Add(this.comboBoxFind);
		this.tabPage3.Controls.Add(this.buttonXoaNhatky);
		this.tabPage3.Controls.Add(this.buttonStopFind);
		this.tabPage3.Controls.Add(this.textBoxTep);
		this.tabPage3.Controls.Add(this.buttonBatdau);
		this.tabPage3.Controls.Add(this.richTextBoxResult);
		this.tabPage3.Controls.Add(this.buttonDelete);
		this.tabPage3.Controls.Add(this.buttonPaste);
		this.tabPage3.Controls.Add(this.buttonBrowss);
		this.tabPage3.Controls.Add(this.label7);
		this.tabPage3.Controls.Add(this.textBoxFolder);
		this.tabPage3.Controls.Add(this.label6);
		this.tabPage3.Location = new System.Drawing.Point(4, 22);
		this.tabPage3.Name = "tabPage3";
		this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage3.Size = new System.Drawing.Size(323, 420);
		this.tabPage3.TabIndex = 2;
		this.tabPage3.Text = "Find";
		this.tabPage3.UseVisualStyleBackColor = true;
		this.buttonPaste2.ForeColor = System.Drawing.Color.Black;
		this.buttonPaste2.Location = new System.Drawing.Point(217, 279);
		this.buttonPaste2.Name = "buttonPaste2";
		this.buttonPaste2.Size = new System.Drawing.Size(53, 21);
		this.buttonPaste2.TabIndex = 50;
		this.buttonPaste2.Text = "Paste";
		this.buttonPaste2.UseVisualStyleBackColor = true;
		this.buttonPaste2.Click += new System.EventHandler(buttonPaste2_Click);
		this.buttonOpenFile.ForeColor = System.Drawing.Color.Black;
		this.buttonOpenFile.Location = new System.Drawing.Point(276, 280);
		this.buttonOpenFile.Name = "buttonOpenFile";
		this.buttonOpenFile.Size = new System.Drawing.Size(44, 21);
		this.buttonOpenFile.TabIndex = 49;
		this.buttonOpenFile.Text = "Mở";
		this.buttonOpenFile.UseVisualStyleBackColor = true;
		this.buttonOpenFile.Click += new System.EventHandler(buttonOpenFile_Click);
		this.textBoxFile.Location = new System.Drawing.Point(0, 280);
		this.textBoxFile.Name = "textBoxFile";
		this.textBoxFile.Size = new System.Drawing.Size(214, 20);
		this.textBoxFile.TabIndex = 48;
		this.textBoxFile.TextChanged += new System.EventHandler(textBoxFile_TextChanged);
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(4, 56);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(36, 13);
		this.label10.TabIndex = 47;
		this.label10.Text = "Folder";
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(2, 6);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(47, 13);
		this.label9.TabIndex = 46;
		this.label9.Text = "Find text";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(181, 329);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(0, 13);
		this.label8.TabIndex = 45;
		this.comboBoxFind.FormattingEnabled = true;
		this.comboBoxFind.Location = new System.Drawing.Point(57, 3);
		this.comboBoxFind.Name = "comboBoxFind";
		this.comboBoxFind.Size = new System.Drawing.Size(263, 21);
		this.comboBoxFind.TabIndex = 42;
		this.comboBoxFind.SelectedIndexChanged += new System.EventHandler(comboBoxFind_SelectedIndexChanged);
		this.buttonXoaNhatky.ForeColor = System.Drawing.Color.Black;
		this.buttonXoaNhatky.Location = new System.Drawing.Point(223, 327);
		this.buttonXoaNhatky.Name = "buttonXoaNhatky";
		this.buttonXoaNhatky.Size = new System.Drawing.Size(94, 25);
		this.buttonXoaNhatky.TabIndex = 41;
		this.buttonXoaNhatky.Text = "Xóa nhật ký";
		this.buttonXoaNhatky.UseVisualStyleBackColor = true;
		this.buttonXoaNhatky.Click += new System.EventHandler(buttonXoaNhatky_Click);
		this.buttonStopFind.ForeColor = System.Drawing.Color.Black;
		this.buttonStopFind.Location = new System.Drawing.Point(94, 327);
		this.buttonStopFind.Name = "buttonStopFind";
		this.buttonStopFind.Size = new System.Drawing.Size(81, 25);
		this.buttonStopFind.TabIndex = 40;
		this.buttonStopFind.Text = "Dừng";
		this.buttonStopFind.UseVisualStyleBackColor = true;
		this.buttonStopFind.Click += new System.EventHandler(buttonStopFind_Click);
		this.textBoxTep.BackColor = System.Drawing.Color.Silver;
		this.textBoxTep.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxTep.Location = new System.Drawing.Point(3, 307);
		this.textBoxTep.Name = "textBoxTep";
		this.textBoxTep.Size = new System.Drawing.Size(314, 13);
		this.textBoxTep.TabIndex = 39;
		this.textBoxTep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.buttonBatdau.ForeColor = System.Drawing.Color.Black;
		this.buttonBatdau.Location = new System.Drawing.Point(5, 327);
		this.buttonBatdau.Name = "buttonBatdau";
		this.buttonBatdau.Size = new System.Drawing.Size(83, 25);
		this.buttonBatdau.TabIndex = 37;
		this.buttonBatdau.Text = "Bắt đầu tìm";
		this.buttonBatdau.UseVisualStyleBackColor = true;
		this.buttonBatdau.Click += new System.EventHandler(buttonBatdau_Click);
		this.richTextBoxResult.Location = new System.Drawing.Point(0, 79);
		this.richTextBoxResult.Name = "richTextBoxResult";
		this.richTextBoxResult.Size = new System.Drawing.Size(320, 195);
		this.richTextBoxResult.TabIndex = 36;
		this.richTextBoxResult.Text = "";
		this.richTextBoxResult.WordWrap = false;
		this.buttonDelete.ForeColor = System.Drawing.Color.Black;
		this.buttonDelete.Location = new System.Drawing.Point(151, 28);
		this.buttonDelete.Name = "buttonDelete";
		this.buttonDelete.Size = new System.Drawing.Size(63, 21);
		this.buttonDelete.TabIndex = 35;
		this.buttonDelete.Text = "x";
		this.buttonDelete.UseVisualStyleBackColor = true;
		this.buttonDelete.Click += new System.EventHandler(buttonDelete_Click);
		this.buttonPaste.ForeColor = System.Drawing.Color.Black;
		this.buttonPaste.Location = new System.Drawing.Point(57, 28);
		this.buttonPaste.Name = "buttonPaste";
		this.buttonPaste.Size = new System.Drawing.Size(88, 21);
		this.buttonPaste.TabIndex = 34;
		this.buttonPaste.Text = "Paste";
		this.buttonPaste.UseVisualStyleBackColor = true;
		this.buttonPaste.Click += new System.EventHandler(buttonPaste_Click);
		this.buttonBrowss.ForeColor = System.Drawing.Color.Black;
		this.buttonBrowss.Location = new System.Drawing.Point(276, 52);
		this.buttonBrowss.Name = "buttonBrowss";
		this.buttonBrowss.Size = new System.Drawing.Size(44, 21);
		this.buttonBrowss.TabIndex = 33;
		this.buttonBrowss.Text = "***";
		this.buttonBrowss.UseVisualStyleBackColor = true;
		this.buttonBrowss.Click += new System.EventHandler(buttonBrowss_Click);
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(2, 56);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(0, 13);
		this.label7.TabIndex = 3;
		this.textBoxFolder.Location = new System.Drawing.Point(57, 53);
		this.textBoxFolder.Name = "textBoxFolder";
		this.textBoxFolder.Size = new System.Drawing.Size(213, 20);
		this.textBoxFolder.TabIndex = 2;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(2, 7);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(0, 13);
		this.label6.TabIndex = 0;
		this.tabPage4.Controls.Add(this.textBoxTk);
		this.tabPage4.Controls.Add(this.label14);
		this.tabPage4.Controls.Add(this.textBoxThoigianGiancach);
		this.tabPage4.Controls.Add(this.label13);
		this.tabPage4.Controls.Add(this.buttonBatdautaoPHLT);
		this.tabPage4.Controls.Add(this.label12);
		this.tabPage4.Controls.Add(this.textBoxPHLT);
		this.tabPage4.Controls.Add(this.label11);
		this.tabPage4.Controls.Add(this.buttonCreateTK);
		this.tabPage4.Controls.Add(this.textBoxCountStart);
		this.tabPage4.Location = new System.Drawing.Point(4, 22);
		this.tabPage4.Name = "tabPage4";
		this.tabPage4.Size = new System.Drawing.Size(323, 420);
		this.tabPage4.TabIndex = 0;
		this.tabPage4.Text = "LuaScript";
		this.tabPage4.UseVisualStyleBackColor = true;
		this.textBoxTk.Location = new System.Drawing.Point(89, 25);
		this.textBoxTk.Name = "textBoxTk";
		this.textBoxTk.Size = new System.Drawing.Size(31, 20);
		this.textBoxTk.TabIndex = 52;
		this.textBoxTk.Text = "15";
		this.label14.AutoSize = true;
		this.label14.Location = new System.Drawing.Point(4, 28);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(66, 13);
		this.label14.TabIndex = 51;
		this.label14.Text = "Thời gian (p)";
		this.textBoxThoigianGiancach.Location = new System.Drawing.Point(269, 25);
		this.textBoxThoigianGiancach.Name = "textBoxThoigianGiancach";
		this.textBoxThoigianGiancach.Size = new System.Drawing.Size(51, 20);
		this.textBoxThoigianGiancach.TabIndex = 50;
		this.textBoxThoigianGiancach.Text = "15";
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(126, 28);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(131, 13);
		this.label13.TabIndex = 49;
		this.label13.Text = "Thời gian giãn cách (phút)";
		this.buttonBatdautaoPHLT.ForeColor = System.Drawing.Color.Black;
		this.buttonBatdautaoPHLT.Location = new System.Drawing.Point(57, 129);
		this.buttonBatdautaoPHLT.Name = "buttonBatdautaoPHLT";
		this.buttonBatdautaoPHLT.Size = new System.Drawing.Size(170, 25);
		this.buttonBatdautaoPHLT.TabIndex = 48;
		this.buttonBatdautaoPHLT.Text = "Bắt đầu tạo";
		this.buttonBatdautaoPHLT.UseVisualStyleBackColor = true;
		this.buttonBatdautaoPHLT.Click += new System.EventHandler(buttonBatdautaoPHLT_Click);
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(3, 101);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(247, 26);
		this.label12.TabIndex = 47;
		this.label12.Text = "Tạo script chạy PHLT liên tục, bắt đầu từ số thứ tự\r\n(xen kẻ tống kim)";
		this.textBoxPHLT.Location = new System.Drawing.Point(268, 99);
		this.textBoxPHLT.Name = "textBoxPHLT";
		this.textBoxPHLT.Size = new System.Drawing.Size(51, 20);
		this.textBoxPHLT.TabIndex = 46;
		this.textBoxPHLT.Text = "225";
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(4, 6);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(259, 13);
		this.label11.TabIndex = 45;
		this.label11.Text = "Tạo script chạy tống kim liên tục, bắt đầu từ số thứ tự";
		this.buttonCreateTK.ForeColor = System.Drawing.Color.Black;
		this.buttonCreateTK.Location = new System.Drawing.Point(57, 61);
		this.buttonCreateTK.Name = "buttonCreateTK";
		this.buttonCreateTK.Size = new System.Drawing.Size(170, 25);
		this.buttonCreateTK.TabIndex = 43;
		this.buttonCreateTK.Text = "Tạo script Task TongKim";
		this.buttonCreateTK.UseVisualStyleBackColor = true;
		this.buttonCreateTK.Click += new System.EventHandler(buttonCreateTK_Click);
		this.textBoxCountStart.Location = new System.Drawing.Point(269, 3);
		this.textBoxCountStart.Name = "textBoxCountStart";
		this.textBoxCountStart.Size = new System.Drawing.Size(51, 20);
		this.textBoxCountStart.TabIndex = 44;
		this.textBoxCountStart.Text = "104";
		this.tabPage5.Controls.Add(this.buttonXemMaloi);
		this.tabPage5.Controls.Add(this.checkBoxKhongDecript);
		this.tabPage5.Controls.Add(this.textBoxStatus);
		this.tabPage5.Controls.Add(this.button9);
		this.tabPage5.Controls.Add(this.button7);
		this.tabPage5.Controls.Add(this.label18);
		this.tabPage5.Controls.Add(this.textBox3);
		this.tabPage5.Controls.Add(this.button3);
		this.tabPage5.Controls.Add(this.button2);
		this.tabPage5.Controls.Add(this.button1);
		this.tabPage5.Controls.Add(this.button8);
		this.tabPage5.Controls.Add(this.label16);
		this.tabPage5.Controls.Add(this.textBoxpw);
		this.tabPage5.Controls.Add(this.button5);
		this.tabPage5.Controls.Add(this.checkBoxDocFile);
		this.tabPage5.Controls.Add(this.buttonBrowse);
		this.tabPage5.Controls.Add(this.label17);
		this.tabPage5.Controls.Add(this.textBox1);
		this.tabPage5.Controls.Add(this.button6);
		this.tabPage5.Controls.Add(this.button4);
		this.tabPage5.Controls.Add(this.textBox2);
		this.tabPage5.Controls.Add(this.label15);
		this.tabPage5.Location = new System.Drawing.Point(4, 22);
		this.tabPage5.Name = "tabPage5";
		this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage5.Size = new System.Drawing.Size(323, 420);
		this.tabPage5.TabIndex = 3;
		this.tabPage5.Text = "Data";
		this.tabPage5.UseVisualStyleBackColor = true;
		this.buttonXemMaloi.Location = new System.Drawing.Point(218, 327);
		this.buttonXemMaloi.Name = "buttonXemMaloi";
		this.buttonXemMaloi.Size = new System.Drawing.Size(100, 26);
		this.buttonXemMaloi.TabIndex = 50;
		this.buttonXemMaloi.Text = "Xem mã lỗi game";
		this.buttonXemMaloi.UseVisualStyleBackColor = true;
		this.buttonXemMaloi.Click += new System.EventHandler(buttonXemMaloi_Click);
		this.checkBoxKhongDecript.AutoSize = true;
		this.checkBoxKhongDecript.Location = new System.Drawing.Point(132, 257);
		this.checkBoxKhongDecript.Name = "checkBoxKhongDecript";
		this.checkBoxKhongDecript.Size = new System.Drawing.Size(106, 17);
		this.checkBoxKhongDecript.TabIndex = 396;
		this.checkBoxKhongDecript.Text = "Không Decoding";
		this.checkBoxKhongDecript.UseVisualStyleBackColor = true;
		this.textBoxStatus.Location = new System.Drawing.Point(5, 3);
		this.textBoxStatus.Multiline = true;
		this.textBoxStatus.Name = "textBoxStatus";
		this.textBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.textBoxStatus.Size = new System.Drawing.Size(313, 82);
		this.textBoxStatus.TabIndex = 395;
		this.button9.ForeColor = System.Drawing.Color.Black;
		this.button9.Location = new System.Drawing.Point(211, 200);
		this.button9.Name = "button9";
		this.button9.Size = new System.Drawing.Size(106, 26);
		this.button9.TabIndex = 393;
		this.button9.Text = "So sánh da ta gốc";
		this.button9.UseVisualStyleBackColor = true;
		this.button9.Click += new System.EventHandler(button9_Click);
		this.button7.ForeColor = System.Drawing.Color.Black;
		this.button7.Location = new System.Drawing.Point(130, 200);
		this.button7.Name = "button7";
		this.button7.Size = new System.Drawing.Size(77, 26);
		this.button7.TabIndex = 392;
		this.button7.Text = "Mở thư mục";
		this.button7.UseVisualStyleBackColor = true;
		this.button7.Click += new System.EventHandler(button7_Click);
		this.label18.AutoSize = true;
		this.label18.Location = new System.Drawing.Point(2, 215);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(97, 13);
		this.label18.TabIndex = 391;
		this.label18.Text = "Lưu làm data game";
		this.textBox3.Location = new System.Drawing.Point(5, 231);
		this.textBox3.Name = "textBox3";
		this.textBox3.Size = new System.Drawing.Size(315, 20);
		this.textBox3.TabIndex = 390;
		this.button3.ForeColor = System.Drawing.Color.Black;
		this.button3.Location = new System.Drawing.Point(5, 257);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(120, 26);
		this.button3.TabIndex = 389;
		this.button3.Text = "Lưu file data game";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.button2.ForeColor = System.Drawing.Color.MediumBlue;
		this.button2.Location = new System.Drawing.Point(5, 167);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(75, 38);
		this.button2.TabIndex = 388;
		this.button2.Text = "Cập nhật data game";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.button1.Location = new System.Drawing.Point(5, 91);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(49, 23);
		this.button1.TabIndex = 387;
		this.button1.Text = "Copy";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.button8.ForeColor = System.Drawing.Color.Black;
		this.button8.Location = new System.Drawing.Point(130, 157);
		this.button8.Name = "button8";
		this.button8.Size = new System.Drawing.Size(122, 23);
		this.button8.TabIndex = 385;
		this.button8.Text = "Lưu file input";
		this.button8.UseVisualStyleBackColor = true;
		this.button8.Click += new System.EventHandler(button8_Click);
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(258, 136);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(54, 13);
		this.label16.TabIndex = 384;
		this.label16.Text = "( pas 239)";
		this.textBoxpw.Location = new System.Drawing.Point(261, 152);
		this.textBoxpw.Name = "textBoxpw";
		this.textBoxpw.Size = new System.Drawing.Size(44, 20);
		this.textBoxpw.TabIndex = 383;
		this.button5.ForeColor = System.Drawing.Color.Black;
		this.button5.Location = new System.Drawing.Point(86, 131);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(166, 23);
		this.button5.TabIndex = 382;
		this.button5.Text = "Tạo file dữ liệu input mặc định";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new System.EventHandler(button5_Click);
		this.checkBoxDocFile.AutoSize = true;
		this.checkBoxDocFile.Location = new System.Drawing.Point(65, 112);
		this.checkBoxDocFile.Name = "checkBoxDocFile";
		this.checkBoxDocFile.Size = new System.Drawing.Size(15, 14);
		this.checkBoxDocFile.TabIndex = 381;
		this.checkBoxDocFile.UseVisualStyleBackColor = true;
		this.buttonBrowse.ForeColor = System.Drawing.Color.Black;
		this.buttonBrowse.Location = new System.Drawing.Point(279, 106);
		this.buttonBrowse.Name = "buttonBrowse";
		this.buttonBrowse.Size = new System.Drawing.Size(34, 21);
		this.buttonBrowse.TabIndex = 380;
		this.buttonBrowse.Text = "***";
		this.buttonBrowse.UseVisualStyleBackColor = true;
		this.buttonBrowse.Click += new System.EventHandler(buttonBrowse_Click);
		this.label17.AutoSize = true;
		this.label17.Location = new System.Drawing.Point(65, 91);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(240, 13);
		this.label17.TabIndex = 379;
		this.label17.Text = "File dữ liệu input \"bytes search\" cập nhật nếu có:";
		this.textBox1.Location = new System.Drawing.Point(86, 109);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(190, 20);
		this.textBox1.TabIndex = 378;
		this.button6.ForeColor = System.Drawing.Color.Black;
		this.button6.Location = new System.Drawing.Point(132, 328);
		this.button6.Name = "button6";
		this.button6.Size = new System.Drawing.Size(77, 26);
		this.button6.TabIndex = 373;
		this.button6.Text = "Mở thư mục";
		this.button6.UseVisualStyleBackColor = true;
		this.button6.Click += new System.EventHandler(button6_Click);
		this.button4.ForeColor = System.Drawing.Color.Black;
		this.button4.Location = new System.Drawing.Point(6, 328);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(120, 26);
		this.button4.TabIndex = 372;
		this.button4.Text = "Lưu file bytes search";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.textBox2.Location = new System.Drawing.Point(7, 302);
		this.textBox2.Name = "textBox2";
		this.textBox2.Size = new System.Drawing.Size(311, 20);
		this.textBox2.TabIndex = 371;
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(4, 285);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(283, 13);
		this.label15.TabIndex = 370;
		this.label15.Text = "Lưu file làm dữ liệu search (thao tác sau khi cập nhật data)";
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.textBoxIndex.Location = new System.Drawing.Point(1, 3);
		this.textBoxIndex.Name = "textBoxIndex";
		this.textBoxIndex.Size = new System.Drawing.Size(25, 20);
		this.textBoxIndex.TabIndex = 21;
		this.textBoxIndex.Text = "0";
		this.textBoxLine.Location = new System.Drawing.Point(29, 3);
		this.textBoxLine.Name = "textBoxLine";
		this.textBoxLine.Size = new System.Drawing.Size(283, 20);
		this.textBoxLine.TabIndex = 15;
		this.button11.Location = new System.Drawing.Point(314, 3);
		this.button11.Name = "button11";
		this.button11.Size = new System.Drawing.Size(40, 21);
		this.button11.TabIndex = 64;
		this.button11.Text = "Copy";
		this.button11.UseVisualStyleBackColor = true;
		this.button11.Click += new System.EventHandler(button11_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(354, 473);
		base.Controls.Add(this.button11);
		base.Controls.Add(this.textBoxLine);
		base.Controls.Add(this.tabControl1);
		base.Controls.Add(this.textBoxIndex);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormTest";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "TEST";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormTest_Load);
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage1.PerformLayout();
		this.tabPage2.ResumeLayout(false);
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.tabPage3.ResumeLayout(false);
		this.tabPage3.PerformLayout();
		this.tabPage4.ResumeLayout(false);
		this.tabPage4.PerformLayout();
		this.tabPage5.ResumeLayout(false);
		this.tabPage5.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
