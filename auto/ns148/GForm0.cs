using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ns100;
using ns23;
using ns31;
using ns53;
using ns83;

namespace ns148;

public class GForm0 : Form
{
	private string string_0 = "";

	private bool bool_0 = false;

	private PointF? nullable_0 = null;

	private float float_0 = 0f;

	private uint uint_0 = 0u;

	public static int int_0 = 0;

	public static string string_1 = "";

	public float float_1 = 230f;

	private float float_2;

	private float float_3;

	public float float_4 = 1.9f;

	public float float_5 = 1f;

	public float float_6 = 20f;

	public bool bool_1 = false;

	private const float float_7 = 1f;

	private const float float_8 = 1f;

	public float float_9 = 2.08f;

	public float float_10 = 0.92f;

	public float float_11 = -15f;

	private static Image image_0;

	private float float_12 = 0f;

	private float float_13 = 0f;

	private string string_2 = "";

	private Timer timer_0;

	private float float_14 = 0f;

	private float float_15 = 0f;

	private string string_3 = "";

	private Timer timer_1;

	private bool bool_2 = true;

	private bool bool_3 = false;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			createParams.ExStyle |= 524448;
			return createParams;
		}
	}

	public GForm0()
	{
		SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
		base.FormBorderStyle = FormBorderStyle.None;
		base.ShowInTaskbar = false;
		base.TopMost = true;
		BackColor = Color.Magenta;
		base.TransparencyKey = Color.Magenta;
		base.Enabled = false;
		DoubleBuffered = true;
	}

	public void method_0(float float_16, float float_17 = 1f, float float_18 = 1f, float float_19 = 0f)
	{
		if (float_16 > 0f)
		{
			float_1 = float_16;
		}
		float_4 = ((float_17 > 0f) ? float_17 : 1f);
		float_5 = ((float_18 > 0f) ? float_18 : 1f);
		float_6 = Math.Max(0f, float_19);
		Invalidate();
	}

	public void method_1(string string_4)
	{
		if (image_0 != null)
		{
			ImageAnimator.StopAnimate(image_0, method_2);
			image_0.Dispose();
			image_0 = null;
		}
		if (!string.IsNullOrEmpty(string_4) && File.Exists(string_4))
		{
			image_0 = Image.FromFile(string_4);
			ImageAnimator.Animate(image_0, method_2);
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		Invalidate();
	}

	private void method_3(string string_4)
	{
		string_2 = string_4;
		float_12 = 1f;
		float_13 = 0f;
		if (timer_0 == null)
		{
			timer_0 = new Timer();
			timer_0.Interval = 50;
			timer_0.Tick += delegate
			{
				float_12 -= 0.05f;
				float_13 -= 1.5f;
				if (float_12 <= 0f)
				{
					timer_0.Stop();
				}
				Invalidate();
			};
		}
		timer_0.Start();
	}

	private void method_4(string string_4)
	{
		string_3 = string_4;
		float_14 = 1f;
		float_15 = 0f;
		bool_2 = false;
		if (timer_1 == null)
		{
			timer_1 = new Timer();
			timer_1.Interval = 50;
			timer_1.Tick += delegate
			{
				float_14 -= 0.05f;
				float_15 -= 1.5f;
				if (float_14 <= 0f)
				{
					timer_1.Stop();
					bool_2 = true;
				}
				Invalidate();
			};
		}
		timer_1.Start();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		if (!string.IsNullOrEmpty(string_1) && !string.IsNullOrEmpty(string_1) && !string_1.Contains("Không hiện"))
		{
			using Font font = new Font("Tahoma", 14f, FontStyle.Bold);
			CharacterAccountConfig characterAccountConfig_ = default(CharacterAccountConfig);
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, Form1.int_58);
			if (num >= 0)
			{
				characterAccountConfig_ = Form1.characterAccountConfig_1[num];
			}
			string s = Class32.smethod_9(characterAccountConfig_, string_1).ToString();
			Brush brush = new SolidBrush(Color.HotPink);
			e.Graphics.DrawString(s, font, brush, 50f, 100f);
			e.Graphics.MeasureString(s, font);
		}
		if (Form1.bool_7)
		{
			string[] source = new string[5] { "Đánh", "Đánh phép thuật", "Chạy tấn công", "Nhảy tấn công", "Đánh liên tiếp" };
			Color color = (source.Any((string string_4) => string_4.Equals(string_0, StringComparison.OrdinalIgnoreCase)) ? Color.Red : Color.Lime);
			using Pen pen = new Pen(color, 2f);
			float num2 = float_1 * ((float_4 > 0f) ? float_4 : 1f);
			float num3 = float_1 * ((float_5 > 0f) ? float_5 : 1f);
			float num4 = ((float_6 > 0f) ? float_6 : 0f);
			float num5 = Math.Max(1f, num3 - num4 * 0.5f);
			float num6 = float_3 + num4 * 0.5f;
			RectangleF rect = new RectangleF(float_2 - num2, num6 - num5, num2 * 2f, num5 * 2f);
			e.Graphics.DrawEllipse(pen, rect);
		}
		if (image_0 != null && Form1.bool_9)
		{
			ImageAnimator.UpdateFrames(image_0);
			float num7 = 80f;
			if (bool_0)
			{
				num7 = 105f;
			}
			e.Graphics.DrawImage(image_0, float_2 - (float)image_0.Width / 2f, float_3 - (float)image_0.Height - num7, image_0.Width, image_0.Height);
		}
		if (float_12 > 0f)
		{
			using Font font2 = new Font("Arial", 16f, FontStyle.Bold);
			int alpha = Math.Max(0, Math.Min(255, (int)(float_12 * 255f)));
			using Brush brush2 = new SolidBrush(Color.FromArgb(alpha, Color.Red));
			SizeF sizeF = e.Graphics.MeasureString(string_2, font2);
			if (Form1.bool_10)
			{
				e.Graphics.DrawString(string_2, font2, brush2, float_2 - sizeF.Width / 2f, float_3 - 120f + float_13);
			}
		}
		if ((string_0 == "Về dưỡng sức" || string_0 == "Chết") && float_12 <= 0f)
		{
			method_3("Oẳng Rồi");
		}
		if (!nullable_0.HasValue)
		{
			return;
		}
		PointF value = nullable_0.Value;
		float num8 = 10f;
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		if (float_14 > 0f)
		{
			using Font font3 = new Font("Arial", 16f, FontStyle.Bold);
			int alpha2 = Math.Max(0, Math.Min(255, (int)(float_14 * 255f)));
			using Brush brush3 = new SolidBrush(Color.FromArgb(alpha2, Color.Red));
			SizeF sizeF2 = e.Graphics.MeasureString(string_3, font3);
			if (Form1.bool_10)
			{
				e.Graphics.DrawString(string_3, font3, brush3, value.X - sizeF2.Width / 2f, value.Y - 120f + float_15);
			}
		}
		if (float_0 == 0f)
		{
			if (!bool_3)
			{
				method_4("Lụm Lúa");
				bool_3 = true;
			}
			if (bool_2)
			{
				nullable_0 = null;
				bool_3 = false;
			}
		}
		else
		{
			bool_3 = false;
		}
		if (Form1.bool_8)
		{
			using (Pen pen2 = new Pen(Color.Yellow, 2f))
			{
				RectangleF rect2 = new RectangleF(value.X - num8, value.Y - num8, num8 * 2f, num8 * 2f);
				e.Graphics.DrawEllipse(pen2, rect2);
			}
			using (Pen pen3 = new Pen(Color.Red, 2f))
			{
				float num9 = num8 * (float)Math.Sqrt(2.0);
				e.Graphics.DrawLine(pen3, value.X - num9 / 2f, value.Y - num9 / 2f, value.X + num9 / 2f, value.Y + num9 / 2f);
				e.Graphics.DrawLine(pen3, value.X + num9 / 2f, value.Y - num9 / 2f, value.X - num9 / 2f, value.Y + num9 / 2f);
			}
			if (uint_0 == 0 && bool_2)
			{
				nullable_0 = null;
			}
		}
	}

	public void method_5(CharacterAccountConfig characterAccountConfig_0)
	{
		try
		{
			if (characterAccountConfig_0.process_0 == null)
			{
				Hide();
				return;
			}
			if (characterAccountConfig_0.process_0.HasExited)
			{
				Hide();
				return;
			}
			uint uint_ = (uint)(int)characterAccountConfig_0.process_0.MainWindowHandle;
			GStruct13 gstruct13_ = default(GStruct13);
			if (!Class24.GetWindowRect(uint_, ref gstruct13_))
			{
				Hide();
				return;
			}
			int num = Math.Max(100, gstruct13_.int_2 - gstruct13_.int_0);
			int num2 = Math.Max(100, gstruct13_.int_3 - gstruct13_.int_1);
			if (base.Location.X != gstruct13_.int_0 || base.Location.Y != gstruct13_.int_1 || base.Width != num || base.Height != num2)
			{
				base.Location = new Point(gstruct13_.int_0, gstruct13_.int_1);
				base.Size = new Size(num, num2);
			}
			if ((IntPtr)Class24.GetForegroundWindow() == characterAccountConfig_0.process_0.MainWindowHandle)
			{
				Show();
			}
			else
			{
				Hide();
			}
			uint num3 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num4 = Class24.smethod_30(num3 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
			uint num5 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num6 = Class56.memorySignatureScanConfig_15.uint_0;
			uint num7 = num5 + num4 * num6;
			uint num8 = Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137);
			uint num9 = Class24.smethod_30(num7 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137);
			uint num10 = Class24.smethod_30(num7 + 236, characterAccountConfig_0.int_137);
			uint num11 = Class24.smethod_30(num7 + 6008, characterAccountConfig_0.int_137);
			uint_0 = Class24.smethod_30(num7 + 5020, characterAccountConfig_0.int_137);
			Class24.smethod_30(num7 + 4168, characterAccountConfig_0.int_137);
			bool_0 = num11 == 1;
			if (num10 < Class56.string_24.Length)
			{
				string_0 = Class56.string_24[num10];
			}
			else
			{
				string_0 = $"Unknown({num10})";
			}
			float_2 = (float)num * 0.5f;
			float_3 = (float)num2 * 0.5f;
			byte[] array = new byte[4];
			int int_ = 0;
			int num12 = characterAccountConfig_0.int_97;
			if (characterAccountConfig_0.int_98 > 0)
			{
				num12 = characterAccountConfig_0.int_99;
			}
			if (characterAccountConfig_0.int_95 > 0 && characterAccountConfig_0.int_96 > 0)
			{
				num12 = characterAccountConfig_0.int_96;
			}
			if (num12 <= 0)
			{
				num12 = 500;
			}
			long num13 = (long)num12 * (long)num12;
			float num14 = 1f;
			try
			{
				float num15 = (float)Math.Min(num, num2) * 0.45f;
				num14 = ((num12 > 0) ? (num15 / (float)num12) : 1f);
				if (num14 <= 0f || float.IsNaN(num14) || float.IsInfinity(num14))
				{
					num14 = 1f;
				}
			}
			catch
			{
				num14 = 1f;
			}
			float_0 = 0f;
			uint num16 = num5 + uint_0 * num6;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16, array, 4, ref int_);
			int num17 = BitConverter.ToInt32(array, 0);
			if (num17 != 0 && num17 != -1)
			{
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num16 + 4168, array, 4, ref int_);
				float_0 = BitConverter.ToInt32(array, 0);
				if (!(float_0 <= 0f))
				{
					uint num18 = Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137);
					uint num19 = Class24.smethod_30(num16 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137);
					long num20 = (long)num18 - (long)num8;
					long num21 = (long)num19 - (long)num9;
					long num22 = num20 * num20 + num21 * num21;
					if (num22 <= num13 || characterAccountConfig_0.int_95 > 0)
					{
						float num23 = float_2 + (float)num20 * num14;
						float num24 = float_3 + (float)num21 * num14;
						if (!(num23 < -1000f) && !(num24 < -1000f) && !(num23 > (float)(num + 1000)) && !(num24 > (float)(num2 + 1000)))
						{
							nullable_0 = new PointF(num23, num24);
						}
					}
				}
			}
			Invalidate();
		}
		catch (Exception ex)
		{
			Console.WriteLine("[ERROR] Exception in UpdateOverlay: " + ex.Message + "\n" + ex.StackTrace);
		}
	}
}
