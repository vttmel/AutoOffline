using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns53;
using ns63;
using ns79;
using ns83;

namespace ns120;

public class FormMagic : Form
{
	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private CheckBox checkBoxBuaXongRoidanh;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ComboBox comboBoxChieuthuc;

	private Button buttonThem;

	private Button buttonXoa;

	private ColumnHeader columnHeader_1;

	private Label label1;

	private Button buttonClose;

	private CheckBox checkBoxChiBuff;

	private Label label2;

	private CheckBox checkBoxPhimTat;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static string string_0 = null;

	public static int int_1 = Class66.smethod_4("flagCtrlTab", 0, "1");

	private static CharacterAccountConfig characterAccountConfig_0 = default(CharacterAccountConfig);

	private static GStruct38[] gstruct38_0 = new GStruct38[7]
	{
		new GStruct38
		{
			int_0 = 73,
			string_0 = "Vạn Độc Thực Tâm (Thời gian trúng độc)"
		},
		new GStruct38
		{
			int_0 = 390,
			string_0 = "Đoạn Cân Hủ Cốt (Âm Kháng tất cả)"
		},
		new GStruct38
		{
			int_0 = 356,
			string_0 = "Xuyên Y Phá Giáp (Âm Phòng thủ)"
		},
		new GStruct38
		{
			int_0 = 72,
			string_0 = "Xuyên Tâm Độc Thích (Âm Kháng độc)"
		},
		new GStruct38
		{
			int_0 = 64,
			string_0 = "Băng Lam Huyền Tinh (Âm Kháng băng)"
		},
		new GStruct38
		{
			int_0 = 70,
			string_0 = "Xích Diệm Thực Thiên (Âm Kháng hỏa)"
		},
		new GStruct38
		{
			int_0 = 67,
			string_0 = "Cửu Thiên Cuồng Lôi (Âm Kháng lôi)"
		}
	};

	private static GStruct38[] gstruct38_1 = new GStruct38[6]
	{
		new GStruct38
		{
			int_0 = 391,
			string_0 = "Tâm pháp Nhiếp Hồn Loạn Tâm (Chiến đấu)"
		},
		new GStruct38
		{
			int_0 = 136,
			string_0 = "Hỏa Liên Phần Hoa (Phản đòn)"
		},
		new GStruct38
		{
			int_0 = 137,
			string_0 = "Ảo Ảnh Phi Hồ (Tỉ lệ công kích chính xác)"
		},
		new GStruct38
		{
			int_0 = 140,
			string_0 = "Phi Hồng Vô Tích (Né tránh)"
		},
		new GStruct38
		{
			int_0 = 364,
			string_0 = "Bi Tô Thanh Phong (Thời gian phục hồi)"
		},
		new GStruct38
		{
			int_0 = 143,
			string_0 = "Lịch Ma Đoạt Hồn (Sát thương Vật lý ngoại công)"
		}
	};

	private static GStruct38[] gstruct38_2 = new GStruct38[6]
	{
		new GStruct38
		{
			int_0 = 394,
			string_0 = "Túy Tiên Tá Cốt (Phản đòn, làm chậm, choáng)"
		},
		new GStruct38
		{
			int_0 = 392,
			string_0 = "Thúc Phược Chú (Âm phản đòn tầm xa)"
		},
		new GStruct38
		{
			int_0 = 174,
			string_0 = "Kỷ Bán phù (Âm tốc độ di chuyển)"
		},
		new GStruct38
		{
			int_0 = 393,
			string_0 = "Bắc Minh Đáo Hải (Âm phục hồi Sinh lực, Nội lực)"
		},
		new GStruct38
		{
			int_0 = 175,
			string_0 = "Khi Hàn Ngạo Tuyết (Âm tốc độ đánh)"
		},
		new GStruct38
		{
			int_0 = 90,
			string_0 = "Mê Tung ảo ảnh (Thời gian làm chậm, choáng)"
		}
	};

	private static GStruct38[] gstruct38_3 = null;

	private static int int_2 = 0;

	public FormMagic()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns120.FormMagic));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.checkBoxBuaXongRoidanh = new System.Windows.Forms.CheckBox();
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.comboBoxChieuthuc = new System.Windows.Forms.ComboBox();
		this.buttonThem = new System.Windows.Forms.Button();
		this.buttonXoa = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.buttonClose = new System.Windows.Forms.Button();
		this.checkBoxChiBuff = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.checkBoxPhimTat = new System.Windows.Forms.CheckBox();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.checkBoxBuaXongRoidanh.AutoSize = true;
		this.checkBoxBuaXongRoidanh.Location = new System.Drawing.Point(7, 152);
		this.checkBoxBuaXongRoidanh.Name = "checkBoxBuaXongRoidanh";
		this.checkBoxBuaXongRoidanh.Size = new System.Drawing.Size(353, 17);
		this.checkBoxBuaXongRoidanh.TabIndex = 7;
		this.checkBoxBuaXongRoidanh.Text = "Chỉ buff bùa và đánh vào 1 đối tượng gần nhất, không buff diện rộng";
		this.checkBoxBuaXongRoidanh.UseVisualStyleBackColor = true;
		this.checkBoxBuaXongRoidanh.CheckedChanged += new System.EventHandler(checkBoxBuaXongRoidanh_CheckedChanged);
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader_0, this.columnHeader_1 });
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(7, 12);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(365, 110);
		this.listView1.TabIndex = 10;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "Tên chiêu thức";
		this.columnHeader_0.Width = 270;
		this.columnHeader_1.Text = "Cấp";
		this.columnHeader_1.Width = 40;
		this.comboBoxChieuthuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxChieuthuc.DropDownWidth = 250;
		this.comboBoxChieuthuc.FormattingEnabled = true;
		this.comboBoxChieuthuc.Location = new System.Drawing.Point(7, 127);
		this.comboBoxChieuthuc.Name = "comboBoxChieuthuc";
		this.comboBoxChieuthuc.Size = new System.Drawing.Size(218, 21);
		this.comboBoxChieuthuc.TabIndex = 11;
		this.buttonThem.Location = new System.Drawing.Point(231, 126);
		this.buttonThem.Name = "buttonThem";
		this.buttonThem.Size = new System.Drawing.Size(76, 23);
		this.buttonThem.TabIndex = 12;
		this.buttonThem.Text = "Thêm";
		this.buttonThem.UseVisualStyleBackColor = true;
		this.buttonThem.Click += new System.EventHandler(buttonThem_Click);
		this.buttonXoa.Location = new System.Drawing.Point(313, 126);
		this.buttonXoa.Name = "buttonXoa";
		this.buttonXoa.Size = new System.Drawing.Size(59, 23);
		this.buttonXoa.TabIndex = 13;
		this.buttonXoa.Text = "Xóa";
		this.buttonXoa.UseVisualStyleBackColor = true;
		this.buttonXoa.Click += new System.EventHandler(buttonXoa_Click);
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(27, 231);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(235, 27);
		this.label1.TabIndex = 14;
		this.label1.Text = "Lưu ý: Ac buff bùa các bạn không đưa vào danh sách loại trừ nhé";
		this.buttonClose.Location = new System.Drawing.Point(286, 251);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(91, 32);
		this.buttonClose.TabIndex = 15;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.checkBoxChiBuff.AutoSize = true;
		this.checkBoxChiBuff.Location = new System.Drawing.Point(7, 206);
		this.checkBoxChiBuff.Name = "checkBoxChiBuff";
		this.checkBoxChiBuff.Size = new System.Drawing.Size(165, 17);
		this.checkBoxChiBuff.TabIndex = 16;
		this.checkBoxChiBuff.Text = "Chỉ buff bùa chứ không đánh";
		this.checkBoxChiBuff.UseVisualStyleBackColor = true;
		this.checkBoxChiBuff.CheckedChanged += new System.EventHandler(checkBoxChiBuff_CheckedChanged);
		this.label2.ForeColor = System.Drawing.Color.DarkGreen;
		this.label2.Location = new System.Drawing.Point(27, 172);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(345, 27);
		this.label2.TabIndex = 17;
		this.label2.Text = "Buff và đánh vào 1 đối tượng gần nhất chứ không buff đánh vào nhiều đối thủ cùng lúc, do đó tốc độ buff đủ bùa sẽ nhanh hơn.";
		this.checkBoxPhimTat.AutoSize = true;
		this.checkBoxPhimTat.ForeColor = System.Drawing.Color.DarkRed;
		this.checkBoxPhimTat.Location = new System.Drawing.Point(7, 266);
		this.checkBoxPhimTat.Name = "checkBoxPhimTat";
		this.checkBoxPhimTat.Size = new System.Drawing.Size(255, 17);
		this.checkBoxPhimTat.TabIndex = 18;
		this.checkBoxPhimTat.Text = "Sử dụng phím tắt Ctrl + TAB để bật tắt cash bùa";
		this.checkBoxPhimTat.UseVisualStyleBackColor = true;
		this.checkBoxPhimTat.CheckedChanged += new System.EventHandler(checkBoxPhimTat_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(384, 295);
		base.Controls.Add(this.checkBoxPhimTat);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.checkBoxChiBuff);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.buttonXoa);
		base.Controls.Add(this.buttonThem);
		base.Controls.Add(this.comboBoxChieuthuc);
		base.Controls.Add(this.listView1);
		base.Controls.Add(this.checkBoxBuaXongRoidanh);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormMagic";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Magic";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormMagic_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void FormMagic_Load(object sender, EventArgs e)
	{
		int_2 = int_0;
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
		if (num >= 0)
		{
			characterAccountConfig_0 = Form1.characterAccountConfig_1[num];
			checkBoxBuaXongRoidanh.Checked = characterAccountConfig_0.int_5 > 0;
			checkBoxChiBuff.Checked = characterAccountConfig_0.int_6 > 0;
			checkBoxPhimTat.Checked = int_1 > 0;
			if (string_0 == "NGUDOC")
			{
				gstruct38_3 = gstruct38_0;
			}
			else if (string_0 == "THIENNHAN")
			{
				gstruct38_3 = gstruct38_1;
			}
			else if (string_0 == "CONLON")
			{
				gstruct38_3 = gstruct38_2;
			}
			if (gstruct38_3 != null)
			{
				string text = string.Empty;
				for (int i = 0; i < gstruct38_3.Length; i++)
				{
					gstruct38_3[i].int_1 = Class83.smethod_16(characterAccountConfig_0, gstruct38_3[i].int_0);
					if (gstruct38_3[i].int_1 > 0)
					{
						string text2 = gstruct38_3[i].string_0 + " (" + gstruct38_3[i].int_1 + ")";
						comboBoxChieuthuc.Items.Add(text2);
						if (text == string.Empty)
						{
							text = text2;
						}
					}
				}
				comboBoxChieuthuc.Text = text;
				if (characterAccountConfig_0.int_3 != null)
				{
					int num2 = 0;
					for (int j = 0; j < characterAccountConfig_0.int_3.GetLength(0); j++)
					{
						for (int k = 0; k < gstruct38_3.Length; k++)
						{
							if (characterAccountConfig_0.int_3[j, 0] == gstruct38_3[k].int_0 && gstruct38_3[k].int_1 > 0)
							{
								method_0(gstruct38_3[k]);
								num2++;
								break;
							}
						}
						if (num2 > 3)
						{
							break;
						}
					}
					buttonThem.Enabled = num2 < 4;
					buttonXoa.Enabled = num2 > 0;
				}
			}
			timer_0.Interval = 300;
			timer_0.Enabled = true;
			base.TopMost = true;
			base.Top = Cursor.Position.Y - base.Height - 10;
			base.Left = Cursor.Position.X - base.Width - 10;
			base.Text = string_0 + " [" + Class1.smethod_1(characterAccountConfig_0.string_22, 1) + "]";
		}
		else
		{
			int_0 = 0;
			Close();
		}
	}

	private void method_0(GStruct38 gstruct38_4)
	{
		try
		{
			string[] array = new string[2]
			{
				gstruct38_4.string_0,
				gstruct38_4.int_1.ToString()
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

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		bool_0 = false;
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
		if (num >= 0)
		{
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	private void checkBoxBuaXongRoidanh_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num < 0)
			{
				int_0 = 0;
				return;
			}
			Form1.characterAccountConfig_1[num].int_5 = Convert.ToByte(checkBoxBuaXongRoidanh.Checked);
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		}
	}

	private void buttonThem_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
		if (num < 0 || (Form1.characterAccountConfig_1[num].int_3 != null && Form1.characterAccountConfig_1[num].int_3.GetLength(0) > 3))
		{
			return;
		}
		string string_ = comboBoxChieuthuc.Text;
		int num2 = -1;
		for (int i = 0; i < gstruct38_3.Length; i++)
		{
			if (Class11.smethod_1(string_, gstruct38_3[i].string_0) == 0)
			{
				num2 = i;
				break;
			}
		}
		if (num2 < 0 || gstruct38_3[num2].int_1 <= 0)
		{
			return;
		}
		int[] array = null;
		if (Form1.characterAccountConfig_1[num].int_3 != null)
		{
			int length = Form1.characterAccountConfig_1[num].int_3.GetLength(0);
			array = new int[length];
			for (int j = 0; j < length; j++)
			{
				if (Form1.characterAccountConfig_1[num].int_3[j, 0] != gstruct38_3[num2].int_0)
				{
					array[j] = Form1.characterAccountConfig_1[num].int_3[j, 0];
					continue;
				}
				return;
			}
		}
		if (array == null)
		{
			array = new int[1];
		}
		else
		{
			Array.Resize(ref array, array.Length + 1);
		}
		array[array.Length - 1] = gstruct38_3[num2].int_0;
		Form1.characterAccountConfig_1[num].int_3 = new int[array.Length, 2];
		for (int k = 0; k < array.Length; k++)
		{
			Form1.characterAccountConfig_1[num].int_3[k, 0] = array[k];
			Form1.characterAccountConfig_1[num].int_3[k, 1] = Class83.smethod_16(Form1.characterAccountConfig_1[num], array[k]);
		}
		method_0(gstruct38_3[num2]);
		Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		buttonThem.Enabled = Form1.characterAccountConfig_1[num].int_3 == null || Form1.characterAccountConfig_1[num].int_3.GetLength(0) < 4;
		buttonXoa.Enabled = Form1.characterAccountConfig_1[num].int_3 != null && Form1.characterAccountConfig_1[num].int_3.GetLength(0) > 0;
	}

	private void buttonXoa_Click(object sender, EventArgs e)
	{
		int num = -1;
		string text = null;
		for (int i = 0; i < listView1.Items.Count; i++)
		{
			if (listView1.Items[i].Selected)
			{
				text = listView1.Items[i].SubItems[0].Text;
				num = i;
				break;
			}
		}
		if (num < 0 || text == null)
		{
			return;
		}
		listView1.Items.RemoveAt(num);
		if (listView1.Items.Count > 0)
		{
			int num2 = num;
			if (listView1.Items.Count <= num2)
			{
				num2 = listView1.Items.Count - 1;
			}
			listView1.Items[num2].Focused = true;
			listView1.Items[num2].Selected = true;
		}
		int num3 = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
		if (num3 < 0)
		{
			return;
		}
		if (Form1.characterAccountConfig_1[num3].int_3 != null)
		{
			int num4 = -1;
			for (int j = 0; j < gstruct38_3.Length; j++)
			{
				if (Class11.smethod_1(text, gstruct38_3[j].string_0) == 0)
				{
					num4 = gstruct38_3[j].int_0;
					break;
				}
			}
			if (num4 > 0)
			{
				int[,] array = new int[Form1.characterAccountConfig_1[num3].int_3.GetLength(0), 2];
				int num5 = 0;
				for (int k = 0; k < array.GetLength(0); k++)
				{
					if (Form1.characterAccountConfig_1[num3].int_3[k, 0] != num4)
					{
						array[num5, 0] = Form1.characterAccountConfig_1[num3].int_3[k, 0];
						array[num5, 1] = Form1.characterAccountConfig_1[num3].int_3[k, 1];
						num5++;
					}
				}
				if (num5 != 0)
				{
					if (num5 < array.GetLength(0))
					{
						Form1.characterAccountConfig_1[num3].int_3 = new int[num5, 2];
						for (int l = 0; l < num5; l++)
						{
							Form1.characterAccountConfig_1[num3].int_3[l, 0] = array[l, 0];
							Form1.characterAccountConfig_1[num3].int_3[l, 1] = array[l, 1];
						}
					}
				}
				else
				{
					Form1.characterAccountConfig_1[num3].int_3 = null;
				}
			}
		}
		Class56.smethod_13(Form1.characterAccountConfig_1[num3]);
		buttonXoa.Enabled = Form1.characterAccountConfig_1[num3].int_3 != null && Form1.characterAccountConfig_1[num3].int_3.GetLength(0) > 0;
		buttonThem.Enabled = Form1.characterAccountConfig_1[num3].int_3 == null || Form1.characterAccountConfig_1[num3].int_3.GetLength(0) < 4;
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxChiBuff_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num < 0)
			{
				int_0 = 0;
				return;
			}
			Form1.characterAccountConfig_1[num].int_6 = Convert.ToByte(checkBoxChiBuff.Checked);
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		}
	}

	private void checkBoxPhimTat_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int_1 = Convert.ToByte(checkBoxPhimTat.Checked);
			Class66.smethod_11(Class66.smethod_1(), "flagCtrlTab", int_1, "", 0);
		}
	}
}
