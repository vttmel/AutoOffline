using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns138;
using ns3;
using ns53;
using ns83;

namespace ns108;

public class FormCuuSat : Form
{
	private IContainer icontainer_0 = null;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ComboBox comboBoxThemAcc;

	private Button buttonThemAcc;

	private Button buttonXoaAcc;

	private CheckBox checkBoxCuusatTheoDs;

	private Timer timer_0;

	private GroupBox groupBox1;

	private Label label3;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public int int_1 = 0;

	public int int_2 = 0;

	public int int_3;

	public int int_4;

	private bool bool_1 = false;

	private static CharacterAccountConfig characterAccountConfig_0 = default(CharacterAccountConfig);

	private string[] string_0 = null;

	public FormCuuSat()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns108.FormCuuSat));
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader_0 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new System.Windows.Forms.ColumnHeader();
		this.comboBoxThemAcc = new System.Windows.Forms.ComboBox();
		this.buttonThemAcc = new System.Windows.Forms.Button();
		this.buttonXoaAcc = new System.Windows.Forms.Button();
		this.checkBoxCuusatTheoDs = new System.Windows.Forms.CheckBox();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label3 = new System.Windows.Forms.Label();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader_0, this.columnHeader_1 });
		this.listView1.ForeColor = System.Drawing.Color.DarkBlue;
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(8, 19);
		this.listView1.MultiSelect = false;
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(224, 173);
		this.listView1.TabIndex = 2;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "No";
		this.columnHeader_0.Width = 40;
		this.columnHeader_1.Text = "Tên nhân vật";
		this.columnHeader_1.Width = 160;
		this.comboBoxThemAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxThemAcc.DropDownWidth = 120;
		this.comboBoxThemAcc.ForeColor = System.Drawing.Color.DarkBlue;
		this.comboBoxThemAcc.FormattingEnabled = true;
		this.comboBoxThemAcc.Location = new System.Drawing.Point(6, 197);
		this.comboBoxThemAcc.Name = "comboBoxThemAcc";
		this.comboBoxThemAcc.Size = new System.Drawing.Size(126, 21);
		this.comboBoxThemAcc.TabIndex = 63;
		this.comboBoxThemAcc.DropDown += new System.EventHandler(comboBoxThemAcc_DropDown);
		this.buttonThemAcc.ForeColor = System.Drawing.Color.DarkBlue;
		this.buttonThemAcc.Location = new System.Drawing.Point(138, 196);
		this.buttonThemAcc.Name = "buttonThemAcc";
		this.buttonThemAcc.Size = new System.Drawing.Size(50, 23);
		this.buttonThemAcc.TabIndex = 64;
		this.buttonThemAcc.Text = "Thêm";
		this.buttonThemAcc.UseVisualStyleBackColor = true;
		this.buttonThemAcc.Click += new System.EventHandler(buttonThemAcc_Click);
		this.buttonXoaAcc.ForeColor = System.Drawing.Color.DarkBlue;
		this.buttonXoaAcc.Location = new System.Drawing.Point(190, 196);
		this.buttonXoaAcc.Name = "buttonXoaAcc";
		this.buttonXoaAcc.Size = new System.Drawing.Size(42, 23);
		this.buttonXoaAcc.TabIndex = 65;
		this.buttonXoaAcc.Text = "Xóa";
		this.buttonXoaAcc.UseVisualStyleBackColor = true;
		this.buttonXoaAcc.Click += new System.EventHandler(buttonXoaAcc_Click);
		this.checkBoxCuusatTheoDs.AutoSize = true;
		this.checkBoxCuusatTheoDs.BackColor = System.Drawing.SystemColors.Control;
		this.checkBoxCuusatTheoDs.ForeColor = System.Drawing.Color.Red;
		this.checkBoxCuusatTheoDs.Location = new System.Drawing.Point(2, 283);
		this.checkBoxCuusatTheoDs.Name = "checkBoxCuusatTheoDs";
		this.checkBoxCuusatTheoDs.Size = new System.Drawing.Size(228, 17);
		this.checkBoxCuusatTheoDs.TabIndex = 68;
		this.checkBoxCuusatTheoDs.Text = "Cừu sát theo danh sách ở trên (gặp là bụp)";
		this.checkBoxCuusatTheoDs.UseVisualStyleBackColor = false;
		this.checkBoxCuusatTheoDs.CheckedChanged += new System.EventHandler(checkBoxCuusatTheoDs_CheckedChanged);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.groupBox1.Controls.Add(this.listView1);
		this.groupBox1.Controls.Add(this.comboBoxThemAcc);
		this.groupBox1.Controls.Add(this.buttonThemAcc);
		this.groupBox1.Controls.Add(this.buttonXoaAcc);
		this.groupBox1.Location = new System.Drawing.Point(2, 52);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(246, 227);
		this.groupBox1.TabIndex = 73;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Danh sách cừu sát";
		this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.label3.ForeColor = System.Drawing.Color.DarkRed;
		this.label3.Location = new System.Drawing.Point(2, 1);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(246, 45);
		this.label3.TabIndex = 77;
		this.label3.Text = "Lưu ý:  Danh sách cừu sát chỉ nên có trên dưới 5 ac thôi vì nếu càng nhiều thì sẽ làm % cpu tăng cao, dẫn đến lag và diss game.";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(252, 304);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.checkBoxCuusatTheoDs);
		base.Controls.Add(this.groupBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormCuuSat";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "CUU SAT";
		base.Load += new System.EventHandler(FormCuuSat_Load);
		this.groupBox1.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void FormCuuSat_Load(object sender, EventArgs e)
	{
		try
		{
			if (int_1 > 0 && int_2 > 0)
			{
				int num = int_1 - base.Width - 2;
				int num2 = int_2 + int_4 - base.Height;
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
			if (num3 >= 0)
			{
				characterAccountConfig_0 = Form1.characterAccountConfig_1[num3];
				checkBoxCuusatTheoDs.Checked = characterAccountConfig_0.int_120 > 0;
				listView1.Items.Clear();
				if (characterAccountConfig_0.string_18 != null)
				{
					for (int i = 0; i < characterAccountConfig_0.string_18.Length; i++)
					{
						if (characterAccountConfig_0.string_18[i] != null && characterAccountConfig_0.string_18[i] != string.Empty)
						{
							smethod_0(ref listView1, Class1.smethod_1(characterAccountConfig_0.string_18[i], 1));
						}
					}
				}
				string text = Class1.smethod_1(characterAccountConfig_0.string_22, 1);
				Text = "DS CUU SAT CUA [ " + text + " ]";
				groupBox1.Text = "Danh sách cừu sát của (" + text + ")";
				bool_1 = true;
				timer_0.Interval = 300;
				timer_0.Enabled = true;
				base.TopMost = true;
			}
			else
			{
				bool_0 = false;
			}
		}
		catch
		{
		}
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		try
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				Class56.smethod_13(Form1.characterAccountConfig_1[num]);
			}
		}
		catch
		{
		}
		bool_0 = false;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			Close();
		}
	}

	public static void smethod_0(ref ListView listView_0, string string_1)
	{
		if (string_1 != null)
		{
			try
			{
				ListViewItem listViewItem = new ListViewItem((listView_0.Items.Count + 1).ToString());
				ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, string_1);
				listViewItem.SubItems.Add(item);
				listView_0.Items.Add(listViewItem);
			}
			catch
			{
			}
		}
	}

	private int method_0(ListView listView_0)
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

	private void comboBoxThemAcc_DropDown(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			bool_0 = false;
			return;
		}
		bool_1 = false;
		characterAccountConfig_0 = Form1.characterAccountConfig_1[num];
		comboBoxThemAcc.Items.Clear();
		for (int i = 1; i < 256; i++)
		{
			string text = Class3.smethod_22(characterAccountConfig_0, i, 1);
			if (text == string.Empty)
			{
				continue;
			}
			bool flag = true;
			if (comboBoxThemAcc.Items.Count > 0)
			{
				for (int j = 0; j < comboBoxThemAcc.Items.Count; j++)
				{
					if (comboBoxThemAcc.Items[j].ToString() == text)
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				comboBoxThemAcc.Items.Add(Class1.smethod_1(text, 1));
				Class11.smethod_29(ref string_0, text);
			}
		}
		comboBoxThemAcc.Items.Add(string.Empty);
		bool_1 = true;
	}

	private void buttonThemAcc_Click(object sender, EventArgs e)
	{
		if (!bool_1 || string_0 == null || comboBoxThemAcc.Text == "" || Form1.characterAccountConfig_1 == null || Form1.characterAccountConfig_1.Length == 0)
		{
			return;
		}
		if (listView1.Items.Count <= 9)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
			if (num >= 0)
			{
				string text = comboBoxThemAcc.Text;
				if (listView1.Items.Count > 0)
				{
					for (int i = 0; i < listView1.Items.Count; i++)
					{
						if (text == listView1.Items[i].SubItems[1].Text)
						{
							comboBoxThemAcc.Items.Clear();
							comboBoxThemAcc.Text = "";
							return;
						}
					}
				}
				for (int j = 0; j < string_0.Length; j++)
				{
					if (text == Class1.smethod_1(string_0[j], 1))
					{
						Class11.smethod_29(ref Form1.characterAccountConfig_1[num].string_18, string_0[j]);
						smethod_0(ref listView1, text);
						comboBoxThemAcc.Items.Clear();
						comboBoxThemAcc.Text = "";
						break;
					}
				}
				if (listView1.Items.Count > 3)
				{
					buttonThemAcc.Enabled = false;
					comboBoxThemAcc.Enabled = false;
				}
			}
			else
			{
				bool_0 = false;
			}
		}
		else
		{
			FormTip.smethod_0("DANH SACH CHO PHEP", "Nhằm để tránh CPU quá cao gây lag, diss... nên danh sách cừu sát sẽ bị hạn chế ở mức tối đa là 10 acc.||Danh sách đề nghị tốt nhất chỉ nên chứa 1 - 3 acc.", 12000, 280, 110);
		}
	}

	private void buttonXoaAcc_Click(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num < 0)
		{
			bool_0 = false;
			return;
		}
		int num2 = method_0(listView1);
		if (num2 < 0 || num2 > listView1.Items.Count - 1)
		{
			return;
		}
		string text = listView1.Items[num2].SubItems[1].Text;
		if (Form1.characterAccountConfig_1[num].string_18 != null)
		{
			for (int i = 0; i < Form1.characterAccountConfig_1[num].string_18.Length; i++)
			{
				if (text == Class1.smethod_1(Form1.characterAccountConfig_1[num].string_18[i], 1))
				{
					Class11.smethod_30(ref Form1.characterAccountConfig_1[num].string_18, Form1.characterAccountConfig_1[num].string_18[i]);
					break;
				}
			}
		}
		listView1.Items.RemoveAt(num2);
		for (int j = 0; j < listView1.Items.Count; j++)
		{
			listView1.Items[j].SubItems[0].Text = (j + 1).ToString();
		}
		bool enabled = listView1.Items.Count < 4;
		buttonThemAcc.Enabled = enabled;
		comboBoxThemAcc.Enabled = enabled;
	}

	private void checkBoxCuusatTheoDs_CheckedChanged(object sender, EventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_0);
		if (num >= 0)
		{
			Form1.characterAccountConfig_1[num].int_120 = Convert.ToByte(checkBoxCuusatTheoDs.Checked);
		}
		else
		{
			bool_0 = false;
		}
	}
}
