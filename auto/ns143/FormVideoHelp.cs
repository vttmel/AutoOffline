using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ns100;
using ns11;
using ns138;
using ns146;
using ns23;
using ns63;

namespace ns143;

public class FormVideoHelp : Form
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public static bool bool_0 = false;

	public static string string_0 = "https:// ";

	private string string_1 = null;

	private static string[,] string_2 = new string[14, 2]
	{
		{ "Hướng dẫn chung về cài đặt và sử dụng", "https:// " },
		{ "Hướng dẫn tự tìm Web của game", "https:// " },
		{ "Hướng dẫn bơm thuốc phục hồi (hậu cần)", "https:// " },
		{ "Hướng dẫn nhồi thuốc (hậu cần - nút nhồi thuốc)", "https:// " },
		{ "Phim Kéo xe nhiều máy liên máy (nút mở rộng - bảng 1)", "https:// " },
		{ "Phim đánh chiến trường CTC (thất thành)", "https:// " },
		{ "Phim đánh chiến trường CTC (tam trụ)", "https:// " },
		{ "Hướng dẫn click NPC, lọc kiếm đồ HK + xanh ngon. ăn các Event ...", "https:// " },
		{ "Phim chạy nhím chế tạo huyền tinh", "https:// " },
		{ "Cách Tinh luyện, nâng cấp huyền tinh", "https:// " },
		{ "Chuyển thuốc từ rương bang hội ra hành trang", "https:// " },
		{ "Hướng dẫn sử dụng auto Login (phần phụ trợ)", "https:// " },
		{ "Tống Kim chạy về mua máu khi hết máu", string_0 },
		{ "Hướng dẫn làm trạng thái phi chiến đấu", "https:// " }
	};

	private static string string_3 = "http:// /phimhuongdan.txt";

	private static string[,] string_4 = null;

	private bool bool_1 = false;

	public static string string_5 = Class11.smethod_72("lVRNa9tAEL0b/B/maIPrOFAKNfSQGEIh/QhtSgqlh/VKtRZbK9dexe45lFJCSXMsudgJIaSJSdoUQiVCD+vmf+ifdGYkJcqxOgitNPNm5r03Wl9eN67wobIUmgBW7XEAY7daLr1M4hk4SXyoOzDfvT5P4gMJ0gvAS6KjkO5/DEg7ldARvgu963N8qZL4kwaTRFNVh2cYEmLIBdgr6Co8aUSyFwjYsRd9GCsNSreDMfSU/a4RMv4Et128dpvl0j1YaTfBM6Y/bC4sjEaj+jsh3XYQdOsy8BfaSopB4+GD+43GIl4Uv+EWEkzb0HAUWy6VS0+T6FJiD0m8rT3oegr8JN5TMCzMOkyiK+jZCXSw4wMfWmuvKOpYwiJUfDvBPu0pZvPUeA4Rz9XVWspFG0fXdD/0YWWxwbW28Bzv5HiaWfHDJN7V5dIToo3o8ewvLK6JB8f+xkfphXjf5P4EkYIhU1mDTXvKnRejBljP0AAfwVHDIfdWp4Ef/ddFGasILe1EUefRpUlL91ByzW9QecNiVbyAycQGTwSEfUcYl+tWwSBBGRF9tMmBgvehACPa0CJgCkK2UO0vGkZuG3EFT3I9VVBJ6cnoIO/kaEioY39SApqzRVwbT7EJsbtZn0thk4R7luqi7X7IAuykot642E77udopf2RrwxxK7BeElJmcd0uk2CQ3ZNNzHRamWI3iPherDIiyvEx8go9Yop7TjcOdmZzdghVr2dgZVb6gDvI1wi8hVDaWXuSttNZb1Tosc4ahqD62FBl4s/Q2c6FwHKyLBpoENRiKkJcxRxe03HamvRqMA1oDo2SXY8GQ3tqz+xrVjmYmg8PEaPohX/M03thT/xYq1e72ON8lWyFPNXqJgsWHuTIKY92AO2Je5l+pxNhlNE1d4A5tp+4uOCKd8PlKPiIlOAJLDVESrzBlL+iQiOgwFjfjTP49vnEZpec7xeuu51t4wET8TckkPhLpLqSFUMYf/PgtjcnAU/fyr+GmX55nzVM+eOS/PUxwkuhEs8O8ouDNXD5clTVmxwzQsIXquSUygRn18R3U+j8=");

	private IContainer icontainer_0 = null;

	private System.Windows.Forms.Timer timer_0;

	private CheckBox checkBoxKhongHienthi;

	private Button buttonClose;

	private Label Thongtin;

	private Button buttonHelp;

	private LinkLabel linkLabelLinkWeb;

	private TextBox textBoxLink;

	private TextBox textBoxDienGiai;

	private Button buttonCopy;

	private Button buttonXem;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private IContainer icontainer_1;

	private ColumnHeader columnHeader_2;

	public FormVideoHelp()
	{
		bool_0 = true;
		InitializeComponent();
		base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		bool_1 = string_4 != null;
		if (!bool_1)
		{
			new Thread(method_0).Start();
		}
	}

	public void method_0()
	{
		Uri address = new Uri(string_3);
		WebClient webClient = new WebClient();
		string[] array = null;
		try
		{
			byte[] array2 = webClient.DownloadData(address);
			if (array2 != null)
			{
				string text = Encoding.Unicode.GetString(array2, 0, array2.Length);
				array = text.Split('\r', '\n');
			}
		}
		catch
		{
		}
		webClient.CancelAsync();
		if (array == null)
		{
			return;
		}
		string[] array3 = new string[array.Length];
		string[] array4 = new string[array.Length];
		int num = 0;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null && !(array[i] == string.Empty))
			{
				string[] array5 = array[i].Split('|');
				if (array5.Length == 2)
				{
					array3[num] = array5[0];
					array4[num] = array5[1];
					num++;
				}
			}
		}
		if (num != 0)
		{
			string_4 = new string[num, 2];
			for (int j = 0; j < num; j++)
			{
				string_4[j, 0] = array3[j];
				string_4[j, 1] = array4[j];
			}
			bool_1 = true;
		}
	}

	private void FormVideoHelp_Load(object sender, EventArgs e)
	{
		timer_0.Enabled = false;
		if (int_0 >= 0 && int_1 >= 0)
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
		string_1 = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
		if (!Class11.smethod_17(string_1))
		{
			string_1 = Class66.smethod_0();
		}
		for (int i = 0; i < string_2.GetLength(0); i++)
		{
			method_1(listView1, string_2[i, 0] + "|" + string_2[i, 1]);
			if (i <= 1)
			{
				listView1.Items[i].ForeColor = Color.Blue;
			}
		}
		listView1.Items[0].Selected = true;
		textBoxDienGiai.Text = listView1.Items[0].SubItems[1].Text;
		textBoxLink.Text = listView1.Items[0].SubItems[2].Text;
		timer_0.Interval = 100;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_1 = false;
		bool_0 = false;
	}

	private void method_1(ListView listView_0, string string_6)
	{
		try
		{
			string text = "0";
			if (listView_0.Items != null)
			{
				text = listView_0.Items.Count.ToString();
			}
			string[] array = (text + "|" + string_6).Split('|');
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

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
		else if (bool_1 && string_4 != null)
		{
			bool_1 = false;
			for (int i = 0; i < string_4.GetLength(0); i++)
			{
				method_1(listView1, string_4[i, 0] + "|" + string_4[i, 1]);
			}
		}
	}

	private void checkBoxKhongHienthi_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			Form1.int_14 = Convert.ToByte(checkBoxKhongHienthi.Checked);
			Class66.smethod_11(Class66.smethod_1(), "KhongHienThiVideoHelp", Form1.int_14, "", 0);
			if (Form1.int_14 > 0)
			{
				checkBoxKhongHienthi.Text = "Xem lại thì vào Phụ trợ của auto bấm nút Phim hướng dẫn";
			}
			else
			{
				checkBoxKhongHienthi.Text = "Không hiển thị bảng hướng dẫn này nữa.";
			}
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void buttonHelp_Click(object sender, EventArgs e)
	{
		string text = string_5;
		if (GClass1.string_5 != null && GClass1.string_5 != string.Empty)
		{
			text = text + "|==============================================|LƯU Ý:||" + GClass1.string_5;
		}
		if (Form1.string_10 != null && Form1.string_10 != string.Empty)
		{
			text = text + "|==============================================|PHIÊN BẢN MỚI:||" + Form1.string_10;
		}
		FormTip.smethod_0(Form1.string_49, text, 600000, 450, 540, bool_8: false, Form1.int_52[2], Form1.int_52[3]);
	}

	private void linkLabelLinkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Class24.smethod_40(string_1, "", " ", 0);
	}

	private void listView1_MouseUp(object sender, MouseEventArgs e)
	{
		if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count != 0)
		{
			int index = listView1.SelectedIndices[0];
			textBoxDienGiai.Text = listView1.Items[index].SubItems[1].Text;
			textBoxLink.Text = listView1.Items[index].SubItems[2].Text;
		}
	}

	private void buttonCopy_Click(object sender, EventArgs e)
	{
		if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count != 0)
		{
			try
			{
				Clipboard.SetText(listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text);
			}
			catch
			{
			}
		}
	}

	private void buttonXem_Click(object sender, EventArgs e)
	{
		if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count != 0)
		{
			string text = listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text;
			Class24.smethod_40(string_1, "", text, 0);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns143.FormVideoHelp));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_1);
		this.checkBoxKhongHienthi = new System.Windows.Forms.CheckBox();
		this.buttonClose = new System.Windows.Forms.Button();
		this.Thongtin = new System.Windows.Forms.Label();
		this.buttonHelp = new System.Windows.Forms.Button();
		this.linkLabelLinkWeb = new System.Windows.Forms.LinkLabel();
		this.textBoxLink = new System.Windows.Forms.TextBox();
		this.textBoxDienGiai = new System.Windows.Forms.TextBox();
		this.buttonCopy = new System.Windows.Forms.Button();
		this.buttonXem = new System.Windows.Forms.Button();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new System.Windows.Forms.ColumnHeader();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.checkBoxKhongHienthi.AutoSize = true;
		this.checkBoxKhongHienthi.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxKhongHienthi.Location = new System.Drawing.Point(5, 367);
		this.checkBoxKhongHienthi.Name = "checkBoxKhongHienthi";
		this.checkBoxKhongHienthi.Size = new System.Drawing.Size(216, 17);
		this.checkBoxKhongHienthi.TabIndex = 48;
		this.checkBoxKhongHienthi.Text = "Không hiển thị bảng hướng dẫn này nữa";
		this.checkBoxKhongHienthi.UseVisualStyleBackColor = true;
		this.checkBoxKhongHienthi.CheckedChanged += new System.EventHandler(checkBoxKhongHienthi_CheckedChanged);
		this.buttonClose.Location = new System.Drawing.Point(309, 358);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(79, 26);
		this.buttonClose.TabIndex = 49;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.Thongtin.AutoSize = true;
		this.Thongtin.ForeColor = System.Drawing.Color.Red;
		this.Thongtin.Location = new System.Drawing.Point(16, 541);
		this.Thongtin.Name = "Thongtin";
		this.Thongtin.Size = new System.Drawing.Size(16, 13);
		this.Thongtin.TabIndex = 50;
		this.Thongtin.Text = "...";
		this.buttonHelp.Location = new System.Drawing.Point(272, 3);
		this.buttonHelp.Name = "buttonHelp";
		this.buttonHelp.Size = new System.Drawing.Size(120, 30);
		this.buttonHelp.TabIndex = 52;
		this.buttonHelp.Text = "Các cập nhật mới";
		this.buttonHelp.UseVisualStyleBackColor = true;
		this.buttonHelp.Click += new System.EventHandler(buttonHelp_Click);
		this.linkLabelLinkWeb.AutoSize = true;
		this.linkLabelLinkWeb.Location = new System.Drawing.Point(5, 345);
		this.linkLabelLinkWeb.Name = "linkLabelLinkWeb";
		this.linkLabelLinkWeb.Size = new System.Drawing.Size(74, 13);
		this.linkLabelLinkWeb.TabIndex = 143;
		this.linkLabelLinkWeb.TabStop = true;
		this.linkLabelLinkWeb.Text = " ";
		this.linkLabelLinkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelLinkWeb_LinkClicked);
		this.textBoxLink.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxLink.ForeColor = System.Drawing.Color.MediumBlue;
		this.textBoxLink.Location = new System.Drawing.Point(5, 19);
		this.textBoxLink.Name = "textBoxLink";
		this.textBoxLink.Size = new System.Drawing.Size(261, 13);
		this.textBoxLink.TabIndex = 370;
		this.textBoxDienGiai.BackColor = System.Drawing.SystemColors.Info;
		this.textBoxDienGiai.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxDienGiai.Location = new System.Drawing.Point(5, 3);
		this.textBoxDienGiai.Name = "textBoxDienGiai";
		this.textBoxDienGiai.Size = new System.Drawing.Size(261, 13);
		this.textBoxDienGiai.TabIndex = 369;
		this.buttonCopy.Location = new System.Drawing.Point(272, 326);
		this.buttonCopy.Name = "buttonCopy";
		this.buttonCopy.Size = new System.Drawing.Size(116, 26);
		this.buttonCopy.TabIndex = 367;
		this.buttonCopy.Text = "Copy link phim";
		this.buttonCopy.UseVisualStyleBackColor = true;
		this.buttonCopy.Click += new System.EventHandler(buttonCopy_Click);
		this.buttonXem.Location = new System.Drawing.Point(114, 326);
		this.buttonXem.Name = "buttonXem";
		this.buttonXem.Size = new System.Drawing.Size(152, 26);
		this.buttonXem.TabIndex = 366;
		this.buttonXem.Text = "Xem phim";
		this.buttonXem.UseVisualStyleBackColor = true;
		this.buttonXem.Click += new System.EventHandler(buttonXem_Click);
		this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.columnHeader_0, this.columnHeader_1, this.columnHeader_2 });
		this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(5, 42);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(387, 279);
		this.listView1.TabIndex = 365;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.SelectedIndexChanged += new System.EventHandler(listView1_SelectedIndexChanged);
		this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(listView1_MouseUp);
		this.columnHeader_0.Text = "No";
		this.columnHeader_0.Width = 30;
		this.columnHeader_1.Text = "Diễn giải";
		this.columnHeader_1.Width = 230;
		this.columnHeader_2.Text = "Link phim";
		this.columnHeader_2.Width = 105;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(394, 390);
		base.Controls.Add(this.textBoxLink);
		base.Controls.Add(this.textBoxDienGiai);
		base.Controls.Add(this.buttonCopy);
		base.Controls.Add(this.buttonXem);
		base.Controls.Add(this.listView1);
		base.Controls.Add(this.linkLabelLinkWeb);
		base.Controls.Add(this.buttonHelp);
		base.Controls.Add(this.Thongtin);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.checkBoxKhongHienthi);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormVideoHelp";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "PHIM HUONG DAN";
		base.Load += new System.EventHandler(FormVideoHelp_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void listView1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}
}
