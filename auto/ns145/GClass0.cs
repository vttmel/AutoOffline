using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns100;
using ns109;
using ns126;
using ns134;
using ns142;
using ns23;
using ns29;
using ns43;
using ns71;
using ns77;

namespace ns145;

public class GClass0
{
	private delegate IntPtr Delegate0(int nCode, IntPtr wParam, IntPtr lParam);

	private const int int_0 = 13;

	public static int int_1 = 0;

	public static int int_2 = 0;

	public static int int_3 = 121;

	public static bool bool_0 = false;

	public static IntPtr intptr_0 = IntPtr.Zero;

	private static int int_4 = 0;

	private static bool bool_1 = false;

	private static bool bool_2 = false;

	private static bool bool_3 = false;

	private static bool bool_4 = false;

	private static Delegate0 delegate0_0 = smethod_3;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int int_5, Delegate0 delegate0_1, IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr intptr_1, int int_5, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_0);

	public static void smethod_0()
	{
		intptr_0 = smethod_2(delegate0_0);
	}

	public static void smethod_1()
	{
		UnhookWindowsHookEx(intptr_0);
		bool_1 = false;
		bool_2 = false;
		int_4 = 0;
	}

	private static IntPtr smethod_2(Delegate0 delegate0_1)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, delegate0_1, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private static IntPtr smethod_3(int int_5, IntPtr intptr_1, IntPtr intptr_2)
	{
		try
		{
			return smethod_4(int_5, intptr_1, intptr_2);
		}
		catch
		{
		}
		return IntPtr.Zero;
	}

	private static IntPtr smethod_4(int int_5, IntPtr intptr_1, IntPtr intptr_2)
	{
		if (int_5 < 0)
		{
			int_4 = 0;
		}
		else
		{
			int_4 = Marshal.ReadInt32(intptr_2);
			if (Class24.int_28 != (int)intptr_1)
			{
				if (Class24.int_29 == (int)intptr_1)
				{
					if (int_4 == 32)
					{
						Class46.characterSyncSnapshot_0.int_8 = 0;
					}
					if (int_4 != 162 && int_4 != 163)
					{
						if (int_4 != 164 && int_4 != 165)
						{
							if (int_4 == 160 || int_4 == 161)
							{
								bool_4 = false;
							}
						}
						else
						{
							bool_3 = false;
						}
					}
					else
					{
						bool_1 = false;
					}
					if (int_4 <= 48 || 58 <= int_4)
					{
						bool_2 = false;
					}
					int_4 = 0;
				}
			}
			else
			{
				int_1 = int_4;
				if (int_4 != 32)
				{
					if (48 < int_4 && int_4 < 58 && Class81.characterAccountConfig_0.int_136 > 0)
					{
						smethod_5(int_4);
					}
				}
				else
				{
					Class46.characterSyncSnapshot_0.int_8 = 1;
					bool_2 = true;
				}
				if (int_4 != Class30.int_7 && int_4 != Class30.int_8)
				{
					if (int_4 == Class30.int_9 || int_4 == Class30.int_10)
					{
						Class46.characterSyncSnapshot_0.int_9 = 2;
						Class81.int_2 = 2;
					}
				}
				else
				{
					Class46.characterSyncSnapshot_0.int_9 = 1;
					Class81.int_2 = 1;
				}
				if (int_4 != 162 && int_4 != 163)
				{
					if (int_4 != 164 && int_4 != 165)
					{
						if (int_4 == 160 || int_4 == 161)
						{
							bool_4 = true;
						}
					}
					else
					{
						bool_3 = true;
					}
				}
				else
				{
					bool_1 = true;
				}
			}
			if (Class81.characterAccountConfig_0.int_136 > 0)
			{
				if (bool_1)
				{
					if (int_4 != Class30.int_11)
					{
						if (int_4 == Class30.int_12)
						{
							Class81.int_1 = 2;
						}
						else if (int_4 != Class30.int_13)
						{
							if (int_4 != Class30.int_14)
							{
								if (int_4 != Class30.int_15)
								{
									if (int_4 == Class30.int_16)
									{
										if (bool_3)
										{
											Class81.int_1 = 6;
										}
										else
										{
											Class81.int_1 = 5;
										}
									}
									else if (int_4 != Class30.int_17)
									{
										if (int_4 == Class30.int_18)
										{
											smethod_6();
										}
										else if (int_4 == Class30.int_1)
										{
											Class81.int_1 = 7;
										}
										else if (int_4 != 9)
										{
											if (bool_3)
											{
												if (Form1.int_68 > 0)
												{
													Form1.int_152 = 1;
												}
											}
											else if (bool_4 && FormDame.int_8 > 0)
											{
												FormDame.int_7 = 1 - Convert.ToByte(FormDame.int_7 > 0);
											}
										}
										else
										{
											bool_0 = true;
										}
									}
									else
									{
										Class75.smethod_2(Class81.characterAccountConfig_0, Class75.uint_21, 3, 4);
									}
								}
								else
								{
									Class75.smethod_2(Class81.characterAccountConfig_0, Class75.uint_21, 2, 4);
								}
							}
							else
							{
								Class75.smethod_2(Class81.characterAccountConfig_0, Class75.uint_21, 1, 4);
							}
						}
						else
						{
							Class81.int_1 = 3;
						}
					}
					else
					{
						Class81.int_1 = 1;
					}
					if (bool_2)
					{
						FormTest.int_0 = 32;
					}
				}
				if (bool_2)
				{
					Class75.smethod_2(Class81.characterAccountConfig_0, Class75.uint_21, 0, 4);
					if (Form1.characterAccountConfig_1 != null)
					{
						try
						{
							for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
							{
								Class75.smethod_2(Form1.characterAccountConfig_1[i], Class75.uint_50, 0, 4);
							}
						}
						catch
						{
						}
					}
					if (!FormPhongKy1.bool_1)
					{
						if (FormPhongKy1.bool_2)
						{
							FormPhongKy1.bool_4 = true;
						}
					}
					else
					{
						FormPhongKy1.bool_3 = true;
					}
				}
			}
		}
		int_2 = Class81.int_3;
		Class46.characterSyncSnapshot_0.int_7 = int_4;
		return CallNextHookEx(intptr_0, int_5, intptr_1, intptr_2);
	}

	private static void smethod_5(int int_5)
	{
		int num = int_5 - 49;
		if (num < 0 || num > 8)
		{
			return;
		}
		int int_6 = 0;
		byte[] byte_ = new byte[1] { 1 };
		if (Form1.characterAccountConfig_1 == null)
		{
			return;
		}
		try
		{
			for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
			{
				if (Form1.characterAccountConfig_1[i].bool_25)
				{
					Class24.WriteProcessMemory(Form1.characterAccountConfig_1[i].int_137, Form1.characterAccountConfig_1[i].uint_16 + Class75.uint_45 * 4 + (uint)num, byte_, 1, ref int_6);
				}
			}
		}
		catch
		{
		}
	}

	private static void smethod_6()
	{
		try
		{
			Form1 form = null;
			foreach (Form openForm in Application.OpenForms)
			{
				if (openForm is Form1)
				{
					form = (Form1)openForm;
					break;
				}
			}
			if (form == null || form.comboBoxUuTien == null)
			{
				return;
			}
			string text = form.comboBoxUuTien.Text;
			string text2 = "";
			switch (text)
			{
			case "Khoảng cách":
				text2 = "Ngũ hành";
				if (form.checkBox2 != null && !form.checkBox2.Checked)
				{
					form.checkBox2.Checked = true;
				}
				break;
			case "Ngũ hành":
				text2 = "Môn phái";
				break;
			case "Môn phái":
				text2 = "Khoảng cách";
				break;
			default:
				text2 = "Khoảng cách";
				break;
			}
			form.comboBoxUuTien.Text = text2;
			if (text2 == "Khoảng cách")
			{
				form.buttonUuTien.Text = "Áp dụng";
			}
			else
			{
				form.buttonUuTien.Text = "Ưu tiên";
			}
			smethod_7(text2);
		}
		catch
		{
		}
	}

	private static void smethod_7(string string_0)
	{
		try
		{
			FormUutienNguHanh formUutienNguHanh = null;
			foreach (Form openForm in Application.OpenForms)
			{
				if (openForm is FormUutienNguHanh)
				{
					formUutienNguHanh = (FormUutienNguHanh)openForm;
					break;
				}
			}
			formUutienNguHanh?.method_7(string_0);
		}
		catch
		{
		}
	}
}
