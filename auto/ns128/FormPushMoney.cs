using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns1;
using ns100;
using ns11;
using ns53;
using ns71;
using ns83;

namespace ns128;

public class FormPushMoney : Form
{
	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private Button buttonClose;

	private TextBox textBox1;

	private Label label1;

	private Button buttonPush;

	private TextBox textBoxTen;

	private Label label2;

	private CheckBox checkBoxTudong;

	private RichTextBox richTextBox1;

	private TextBox textBox2;

	private Label label3;

	private Label label4;

	private Label label5;

	public static int int_0 = 0;

	public static int int_1 = 0;

	private string string_0 = "㑱ᖳᘀ㑬ᘇᖳᘆ㑤ᖳᘆᗸᘅᘉᗸᘅᖳᘇᗸᘆᘇᖳᗵ㐴ᘁᖳᗶᚆᖳᘇᗻ㑖ᖳᗾ㑒ᘇᖳᗻ㑶ᘃᖳᘎᖳᘃᗻ㑸ᖳᘇᘅ㑶ᖳᗀᗑᖳᗸᘉᗸᘁᘇᖳᗀᗑᖳᗿ㑠ᗶᖳᚤ㑦ᖳᘇᗸᘆᘇᖳᗻᘂ㑊ᗶᖳᗶᗿᗼᗶᗾᖳᘁᘃᗶᖳᘐᖳᖳᚤ㑖ᖳᘁᗻ㑀ᘁᖳᘇᗼ㑔ᘁᖳᘀᗼ㑘ᘁᖳᘃᗻ\u1680ᖳᘇᘅᘂᘁᗺᖳᗿ㑚ᘁᗻᖳᗵᙳᗼᖳᘇᙵᘁᖳᘇᗻ㑺ᖿᖳᘆᗴᘈᖳᚤᚆᖳᘇ㒄ᖳᚤ㑬ᘁᗺᖳᗺ㒀ᗼᖳᗿᙽᘁᖳᗵᗴᘁᗺᗁᖳᖝᖝᗟᝃᘈᖳᚐᖳᗶᗻ㑜ᖳᗺ㒀ᗼᖳᘇᗼ㑔ᘁᖳ㑲ᖳᗻᙳᘁᗻᖳᘇᘅᗴᘁᗺᖿᖳᗾᗻᚇᘁᗺᖳᗶᚆᖳᘅᚍᘇᖳᘇᘅᘂᘁᗺᖳᘅᝃ\u1734ᘁᗺᖳᚤ㑖ᖳᗺ㒀ᗼᗁᖳᗠ㑪ᗼᖳᗿ㐺ᘁᖳᗴᘈᘇᘂᖳᗶᗻ㑜ᖳᗺ㒀ᗼᖳᘇ㑤ᗼᖳᚤᗴᖳᗄᖳᘉ㐴ᘁᖳᗿᝃ㑶ᘁᗺᖳᚤ㑖ᖳᘇᘅᙴᘁᗻᖳᗿ㑪ᗼᖳᘆᗸᘉᗸᘅᖳᗺᗴᘀᗸ";

	public FormPushMoney()
	{
		int_0 = 1;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ns128.FormPushMoney));
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.buttonClose = new System.Windows.Forms.Button();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.buttonPush = new System.Windows.Forms.Button();
		this.textBoxTen = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.checkBoxTudong = new System.Windows.Forms.CheckBox();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.buttonClose.Location = new System.Drawing.Point(240, 286);
		this.buttonClose.Name = "buttonClose";
		this.buttonClose.Size = new System.Drawing.Size(70, 30);
		this.buttonClose.TabIndex = 346;
		this.buttonClose.Text = "Đóng";
		this.buttonClose.UseVisualStyleBackColor = true;
		this.buttonClose.Click += new System.EventHandler(buttonClose_Click);
		this.textBox1.Location = new System.Drawing.Point(193, 219);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(77, 20);
		this.textBox1.TabIndex = 353;
		this.textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
		this.label1.Location = new System.Drawing.Point(190, 245);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(63, 13);
		this.label1.TabIndex = 354;
		this.label1.Text = "0 vạn lượng";
		this.buttonPush.Location = new System.Drawing.Point(112, 286);
		this.buttonPush.Name = "buttonPush";
		this.buttonPush.Size = new System.Drawing.Size(113, 30);
		this.buttonPush.TabIndex = 356;
		this.buttonPush.Text = "Gửi tiền";
		this.buttonPush.UseVisualStyleBackColor = true;
		this.buttonPush.Click += new System.EventHandler(buttonPush_Click);
		this.textBoxTen.BackColor = System.Drawing.Color.Gainsboro;
		this.textBoxTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBoxTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxTen.ForeColor = System.Drawing.Color.Maroon;
		this.textBoxTen.Location = new System.Drawing.Point(5, 8);
		this.textBoxTen.Name = "textBoxTen";
		this.textBoxTen.Size = new System.Drawing.Size(306, 13);
		this.textBoxTen.TabIndex = 357;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(55, 222);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(132, 13);
		this.label2.TabIndex = 358;
		this.label2.Text = "Gửi tiền thủ công bằng tay";
		this.checkBoxTudong.AutoSize = true;
		this.checkBoxTudong.Location = new System.Drawing.Point(5, 158);
		this.checkBoxTudong.Name = "checkBoxTudong";
		this.checkBoxTudong.Size = new System.Drawing.Size(208, 17);
		this.checkBoxTudong.TabIndex = 359;
		this.checkBoxTudong.Text = "Tự động gửi lên bang khi hành trang >";
		this.checkBoxTudong.UseVisualStyleBackColor = true;
		this.checkBoxTudong.CheckedChanged += new System.EventHandler(checkBoxTudong_CheckedChanged);
		this.richTextBox1.Location = new System.Drawing.Point(5, 27);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.Size = new System.Drawing.Size(306, 105);
		this.richTextBox1.TabIndex = 361;
		this.richTextBox1.Text = "";
		this.textBox2.Location = new System.Drawing.Point(219, 156);
		this.textBox2.Name = "textBox2";
		this.textBox2.Size = new System.Drawing.Size(51, 20);
		this.textBox2.TabIndex = 362;
		this.textBox2.TextChanged += new System.EventHandler(textBox2_TextChanged);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(276, 159);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(25, 13);
		this.label3.TabIndex = 363;
		this.label3.Text = "vạn";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(276, 222);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(33, 13);
		this.label4.TabIndex = 364;
		this.label4.Text = "lượng";
		this.label5.AutoSize = true;
		this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
		this.label5.Location = new System.Drawing.Point(24, 181);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(236, 13);
		this.label5.TabIndex = 365;
		this.label5.Text = "(cần phải stick vào tên ac để auto đang chạy...)";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(324, 326);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.buttonClose);
		base.Controls.Add(this.checkBoxTudong);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.textBoxTen);
		base.Controls.Add(this.buttonPush);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.textBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.Name = "FormPushMoney";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "GUI TIEN LEN BANG";
		base.TopMost = true;
		base.Load += new System.EventHandler(FormPushMoney_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (0 <= num)
		{
			Class56.smethod_13(Form1.characterAccountConfig_1[num]);
		}
		int_1 = 0;
		int_0 = 0;
	}

	private void FormPushMoney_Load(object sender, EventArgs e)
	{
		base.Top = Cursor.Position.Y - base.Height - 10;
		base.Left = Cursor.Position.X - base.Width - 10;
		int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num < 0)
		{
			textBoxTen.Text = "Chưa chọn ac nào";
		}
		else
		{
			textBoxTen.Text = Class1.smethod_1(Form1.characterAccountConfig_1[num].string_22, 1);
			checkBoxTudong.Checked = Form1.characterAccountConfig_1[num].int_67[0] > 0;
			textBox2.Text = Form1.characterAccountConfig_1[num].int_67[1].ToString();
			int num2 = Form1.characterAccountConfig_1[num].int_67[2];
			textBox1.Text = num2.ToString();
			label1.Text = num2 / 10000 + " vạn " + num2 % 10000 + " lượng";
		}
		richTextBox1.Text = Class11.smethod_54(string_0);
		timer_0.Interval = 300;
		timer_0.Enabled = true;
		base.TopMost = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			Close();
		}
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void checkBoxTudong_CheckedChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
			if (0 <= num)
			{
				Form1.characterAccountConfig_1[num].int_67[0] = Convert.ToByte(checkBoxTudong.Checked);
			}
		}
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
			if (0 <= num)
			{
				Form1.characterAccountConfig_1[num].int_67[1] = Class11.smethod_11(textBox2.Text);
			}
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		if (timer_0.Enabled)
		{
			int num = Class11.smethod_11(textBox1.Text);
			label1.Text = num / 10000 + " vạn " + num % 10000 + " lượng";
			int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
			if (0 <= num2)
			{
				Form1.characterAccountConfig_1[num2].int_67[2] = num;
			}
		}
	}

	private void buttonPush_Click(object sender, EventArgs e)
	{
		int num = Class11.smethod_11(textBox1.Text);
		int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_1);
		if (num2 < 0)
		{
			richTextBox1.Text = "Chưa chọn ac nào. Hãy bấm nút đóng, trên auto bấm chọn tên ac, sau đó bấm lại nút Gửi tiền lên bang.";
		}
		else
		{
			Class75.smethod_73(Form1.characterAccountConfig_1[num2], num);
		}
	}
}
