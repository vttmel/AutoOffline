using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using ns1;
using ns11;
using ns146;
using ns23;
using ns53;
using ns63;

namespace ns30;

internal class Class31
{
	[StructLayout(LayoutKind.Sequential)]
	private class Class33
	{
		private int int_0 = 528;

		private byte byte_0 = 0;

		private byte byte_1 = 1;

		private byte byte_2 = 1;

		private byte byte_3 = 0;

		private byte byte_4 = 0;

		private byte byte_5 = 160;

		private byte byte_6 = 236;

		private byte byte_7 = 0;

		private byte byte_8 = 0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		private byte[] byte_9 = new byte[16];
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Class34
	{
		private int int_0;

		private int int_1;

		private int int_2;
	}

	private const int int_0 = 64;

	public static long long_0;

	public static string string_0 = string.Empty;

	public static bool bool_0 = false;

	public static string[] string_1 = null;

	public static string string_2 = string.Empty;

	public static string string_3 = string.Empty;

	public static uint uint_0 = 0u;

	public static int int_1 = Class66.smethod_4("fMultiHd", 0, "0");

	private static char[] char_0 = new char[20]
	{
		'ᓙ', 'ᓙ', 'ᒫ', 'ᓙ', 'ᓍ', 'ᓥ', 'ᓶ', 'ᓰ', 'ᓦ', 'ᓠ',
		'ᓞ', 'ᓩ', 'ᓁ', 'ᓯ', 'ᓦ', 'ᓳ', 'ᓢ', 'ᓸ', 'ᒭ', 'ᓺ'
	};

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateFile(string string_4, uint uint_1, uint uint_2, IntPtr intptr_0, uint uint_3, uint uint_4, IntPtr intptr_1);

	[DllImport("kernel32.dll")]
	private static extern int DeviceIoControl(IntPtr intptr_0, uint uint_1, IntPtr intptr_1, uint uint_2, ref Struct9 struct9_0, uint uint_3, ref uint uint_4, [Out] IntPtr intptr_2);

	[DllImport("kernel32.dll", EntryPoint = "DeviceIoControl")]
	private static extern int DeviceIoControl_1(IntPtr intptr_0, uint uint_1, ref Struct10 struct10_0, uint uint_2, ref Struct13 struct13_0, uint uint_3, ref uint uint_4, [Out] IntPtr intptr_1);

	[DllImport("Iphlpapi.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern int GetAdaptersInfo(IntPtr intptr_0, ref uint uint_1);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeviceIoControl_2([In] IntPtr intptr_0, [In] uint uint_1, [Optional][In] IntPtr intptr_1, [In] uint uint_2, [Optional][Out] IntPtr intptr_2, [In] uint uint_3, out uint uint_4, [Optional][In][Out] IntPtr intptr_3);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "CreateFile", SetLastError = true)]
	internal static extern IntPtr CreateFile_1([In] string string_4, [In] GEnum5 genum5_0, [In] GEnum6 genum6_0, [Optional][In] IntPtr intptr_0, [In] GEnum4 genum4_0, [In] uint uint_1, [Optional][In] IntPtr intptr_1);

	[DllImport("user32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr CallWindowProcW([In] byte[] byte_0, IntPtr intptr_0, int int_2, [In][Out] byte[] byte_1, IntPtr intptr_1);

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool VirtualProtect([In] byte[] byte_0, IntPtr intptr_0, int int_2, out int int_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern bool GetVolumeInformation(string string_4, StringBuilder stringBuilder_0, uint uint_1, out uint uint_2, out uint uint_3, out uint uint_4, StringBuilder stringBuilder_1, uint uint_5);

	public static void smethod_0()
	{
		char[] char_ = new char[7] { 'ᓪ', 'ᒴ', 'ᓢ', 'ᓙ', 'ᓦ', 'ᓕ', 'ᓢ' };
		char[] char_2 = new char[6] { 'ᓅ', 'ᒻ', 'ᒰ', 'ᓤ', 'ᓣ', 'ᓞ' };
		char[] char_3 = new char[6] { 'ᓂ', 'ᓨ', 'ᓢ', 'ᓣ', 'ᓔ', 'ᓜ' };
		int int_ = 0;
		string[] array = new string[3]
		{
			Class11.smethod_0(char_),
			Class11.smethod_0(char_2),
			Class11.smethod_0(char_3)
		};
		for (int i = 0; i < array.Length; i++)
		{
			try
			{
				if (Class24.smethod_0(Class11.smethod_15(array[i]), ref int_) && int_ == 1)
				{
					return;
				}
			}
			catch
			{
			}
		}
		string_3 = string.Empty;
		string_1 = smethod_6(0);
		int num = smethod_5(string_1);
		if (num > 0 && int_1 > 0 && !bool_0)
		{
			byte b = 1;
			while (b < 16)
			{
				string[] array2 = smethod_6(b);
				int num2 = smethod_5(array2);
				if (num2 <= 0 || !bool_0)
				{
					b++;
					continue;
				}
				for (int j = 0; j < string_1.Length; j++)
				{
					if (string_3 != null && string_3 != string.Empty)
					{
						string_3 += "-";
					}
					string_3 += string_1[j];
					string_1[j] = array2[j];
				}
				break;
			}
		}
		string_2 = string.Empty;
		for (int k = 0; k < string_1.Length; k++)
		{
			if (string_2 != null && string_2 != string.Empty)
			{
				string_2 += "-";
			}
			string_2 += string_1[k];
			if (k == string_1.Length - 2)
			{
				uint_0 = Class11.smethod_6(string_1[k]);
			}
		}
	}

	private static GStruct17 smethod_1(byte byte_0)
	{
		char[] char_ = new char[12]
		{
			'ᓑ', 'ᓑ', 'ᒣ', 'ᓑ', 'ᓈ', 'ᓢ', 'ᓖ', 'ᓧ', 'ᓩ', 'ᓫ',
			'ᓨ', 'ᓙ'
		};
		GStruct17 result = new GStruct17
		{
			md = "",
			sr = "",
			fr = "",
			cap = 0u
		};
		try
		{
			Struct9 struct9_ = default(Struct9);
			Struct10 struct10_ = default(Struct10);
			Struct13 struct13_ = default(Struct13);
			IntPtr intPtr = CreateFile(Class11.smethod_0(char_), 0u, 0u, IntPtr.Zero, 1u, 0u, IntPtr.Zero);
			if (intPtr == IntPtr.Zero)
			{
				return result;
			}
			uint uint_ = 0u;
			if (DeviceIoControl(intPtr, 475264u, IntPtr.Zero, 0u, ref struct9_, (uint)Marshal.SizeOf((object)struct9_), ref uint_, IntPtr.Zero) != 0 && (struct9_.uint_0 & 1) != 0)
			{
				struct10_.struct11_0.byte_5 = 160;
				if ((byte_0 & 1) != 0)
				{
					struct10_.struct11_0.byte_5 = 176;
				}
				if ((struct9_.uint_0 & (16 >> (int)byte_0)) == 0L)
				{
					struct10_.struct11_0.byte_6 = 236;
					struct10_.byte_0 = byte_0;
					struct10_.struct11_0.byte_1 = 1;
					struct10_.struct11_0.byte_2 = 1;
					struct10_.uint_0 = 512u;
					if (DeviceIoControl_1(intPtr, 508040u, ref struct10_, (uint)Marshal.SizeOf((object)struct10_), ref struct13_, (uint)Marshal.SizeOf((object)struct13_), ref uint_, IntPtr.Zero) != 0)
					{
						result = smethod_3(struct13_.struct14_0);
					}
				}
			}
			CloseHandle(intPtr);
		}
		catch
		{
		}
		return result;
	}

	private static GStruct17 smethod_2(byte byte_0)
	{
		GStruct17 result = new GStruct17
		{
			md = string.Empty,
			sr = string.Empty,
			fr = string.Empty,
			cap = 0u
		};
		try
		{
			Struct9 struct9_ = default(Struct9);
			Struct10 struct10_ = default(Struct10);
			Struct13 struct13_ = default(Struct13);
			string format = Class11.smethod_0(char_0);
			string string_ = string.Format(format, byte_0);
			IntPtr intPtr = CreateFile(string_, 3221225472u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
			if (intPtr == IntPtr.Zero)
			{
				return result;
			}
			uint uint_ = 0u;
			if (DeviceIoControl(intPtr, 475264u, IntPtr.Zero, 0u, ref struct9_, (uint)Marshal.SizeOf((object)struct9_), ref uint_, IntPtr.Zero) != 0 && (struct9_.uint_0 & 1) != 0)
			{
				struct10_.struct11_0.byte_5 = 160;
				if ((byte_0 & 1) != 0)
				{
					struct10_.struct11_0.byte_5 = 176;
				}
				if ((struct9_.uint_0 & (16 >> (int)byte_0)) == 0L)
				{
					struct10_.struct11_0.byte_6 = 236;
					struct10_.byte_0 = byte_0;
					struct10_.struct11_0.byte_1 = 1;
					struct10_.struct11_0.byte_2 = 1;
					struct10_.uint_0 = 512u;
					if (DeviceIoControl_1(intPtr, 508040u, ref struct10_, (uint)Marshal.SizeOf((object)struct10_), ref struct13_, (uint)Marshal.SizeOf((object)struct13_), ref uint_, IntPtr.Zero) != 0)
					{
						result = smethod_3(struct13_.struct14_0);
					}
				}
			}
			CloseHandle(intPtr);
		}
		catch
		{
		}
		return result;
	}

	private static GStruct17 smethod_3(Struct14 struct14_0)
	{
		GStruct17 result = new GStruct17
		{
			md = "",
			sr = "",
			fr = "",
			cap = 0u
		};
		try
		{
			smethod_4(struct14_0.byte_2);
			result.md = Encoding.ASCII.GetString(struct14_0.byte_2).Trim().Replace(" ", "")
				.ToUpper();
			smethod_4(struct14_0.byte_1);
			result.fr = Encoding.ASCII.GetString(struct14_0.byte_1).Trim().Replace(" ", "")
				.ToUpper();
			smethod_4(struct14_0.byte_0);
			result.sr = Encoding.ASCII.GetString(struct14_0.byte_0).Trim().Replace(" ", "")
				.ToUpper();
			result.cap = struct14_0.uint_1 / 2 / 1024;
		}
		catch
		{
		}
		return result;
	}

	private static void smethod_4(byte[] byte_0)
	{
		int num = 0;
		sbyte b = 0;
		byte b2 = 0;
		while (true)
		{
			b = 0;
			if (num < byte_0.Length)
			{
				b = 1;
			}
			if (b != 0)
			{
				b2 = byte_0[num];
				byte_0[num] = byte_0[num + 1];
				byte_0[num + 1] = b2;
				num += 2;
				continue;
			}
			break;
		}
	}

	private static int smethod_5(string[] string_4)
	{
		int result = 0;
		long num = 0L;
		if (string_4 == null || string_4.Length < 2)
		{
			string_4 = new string[2] { "AUTOVOLAM", "AUTOVOLAM" };
		}
		string environmentVariable = Environment.GetEnvironmentVariable(Class11.smethod_0(Class56.char_0));
		string[] array = new string[2]
		{
			Class56.string_9 + "\\" + Class11.smethod_0(Class11.char_31),
			environmentVariable + "\\" + Class11.smethod_0(Class11.char_31)
		};
		string text = null;
		int int_ = 0;
		int int_2 = Class24.OpenProcess(2035711, bool_0: false, Process.GetCurrentProcess().Id);
		byte[] array2 = new byte[4];
		byte[] array3 = null;
		byte[] array4 = new byte[8];
		string text2 = null;
		uint num2 = 3u;
		Class24.ReadProcessMemory(int_2, Class11.uint_0 + 768, array2, 4, ref int_);
		int num3 = BitConverter.ToInt32(array2, 0);
		if (num3 > 0)
		{
			array3 = new byte[num3];
			Class24.ReadProcessMemory(int_2, Class11.uint_0 + num2 * 256 + 4, array3, num3, ref int_);
			string text3 = Class1.smethod_4(array3);
			string text4 = string.Empty;
			int length = text3.Length;
			for (int i = 0; i < text3.Length; i++)
			{
				char c = text3[i];
				if (c > 'ᎅ')
				{
					c = (char)(c - (5225 + length));
				}
				text4 += c;
			}
			array4 = Encoding.ASCII.GetBytes(text4);
		}
		for (int j = 0; j < array.Length; j++)
		{
			string string_5 = array[j];
			string text5 = Class11.smethod_33(string_5, 1, 1, 1);
			if (text5 != null && text5 != string.Empty)
			{
				text = Class11.smethod_35(text5, string_4[0], array4);
				if (text != null && text != string.Empty)
				{
					string string_6 = array[array.Length - 1 - j];
					Class11.smethod_34(string_6, text5, 1);
					break;
				}
			}
		}
		int num4 = 0;
		if (text != null && !(text == string.Empty))
		{
			string[] array5 = text.Split('|');
			int num5 = array5.Length;
			//GClass1.int_7 = int.Parse(array5[num5 - 1]);
			if (num5 == 9)
			{
				int num6 = num5 - 2;
				string text6 = Class11.smethod_15(array5[num6]);
				string text7 = null;
				if (text6 != string.Empty)
				{
					int length2 = array5[num5 - 1].Length;
					num4 = Class11.smethod_11(text6);
					num4 = num4 - (text.Length - array5[num5 - 2].Length - length2) + 1;
				}
				string[] array6 = new string[num5 - 1];
				array6[0] = Class11.smethod_35(array5[0], string_4[0], array4);
				bool_0 = array6[0].Contains(string_4[0]);
				for (int k = 0; k < array6.Length; k++)
				{
					if (k < array6.Length - 1)
					{
						array6[k + 1] = Class11.smethod_35(array5[k + 1], array6[k], array4);
					}
					if (array6[k] == null || !(array6[k] != string.Empty))
					{
						continue;
					}
					if (k < array6.Length - 2)
					{
						if (text7 != null && text7 != string.Empty)
						{
							text7 += ":";
						}
						text7 += array6[k];
					}
					if (text2 != null && text2 != string.Empty)
					{
						text2 += "\u0001";
					}
					text2 += array6[k];
				}
				num = Class11.smethod_37(array6[6]);
				text7 = text7 + ":" + GClass1.int_7;
				string_0 = smethod_8(text7).ToLower();
				long_0 = Class11.smethod_37(array5[num5 - 1]);
				result = 1;
			}
			else
			{
				bool_0 = false;
			}
		}
		else
		{
			bool_0 = false;
			result = 0;
		}
		if (array4 != null)
		{
			for (int l = 0; l < array4.Length; l++)
			{
				array4[l] = 0;
			}
		}
		num2 = 4u;
		array2 = BitConverter.GetBytes(Convert.ToInt32(Convert.ToByte(bool_0 && num4 > 0) * num4 + Convert.ToByte(!bool_0 || num4 <= 0) * 10));
		Class24.WriteProcessMemory(int_2, Class11.uint_0 + num2 * 256, array2, array2.Length, ref int_);
		array2 = BitConverter.GetBytes(Convert.ToInt32(Convert.ToByte(bool_0 && num4 > 0) * int.MaxValue + Convert.ToByte(!bool_0 || num4 <= 0) * 2));
		Class24.WriteProcessMemory(int_2, Class11.uint_0 + num2 * 256 + 4, array2, array2.Length, ref int_);
		string text8 = num.ToString();
		array2 = BitConverter.GetBytes(text8.Length);
		Class24.WriteProcessMemory(int_2, Class11.uint_0 + num2 * 256 + 8, array2, array2.Length, ref int_);
		array3 = Encoding.ASCII.GetBytes(text8);
		Class24.WriteProcessMemory(int_2, Class11.uint_0 + num2 * 256 + 12, array3, array3.Length, ref int_);
		text2 = Class11.smethod_16(text2);
		if (text2 != null && text2 != string.Empty)
		{
			array2 = BitConverter.GetBytes(text2.Length);
			Class24.WriteProcessMemory(int_2, Class11.uint_0 + num2 * 256 + 32, array2, array2.Length, ref int_);
			array3 = Encoding.ASCII.GetBytes(text2);
			Class24.WriteProcessMemory(int_2, Class11.uint_0 + num2 * 256 + 36, array3, array3.Length, ref int_);
		}
		Class24.smethod_32(int_2);
		return result;
	}

	private static string[] smethod_6(byte byte_0)
	{
		string[] array = new string[6] { "AUTOVOLAM", "BOOTROOM", "00000000", "00000000", "00000000", "00000000" };
		GStruct17 gStruct = default(GStruct17);
		if (Environment.OSVersion.Platform != PlatformID.Win32Windows)
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				gStruct = smethod_2(byte_0);
			}
		}
		else
		{
			gStruct = smethod_1(byte_0);
		}
		if (gStruct.sr == null || gStruct.sr == string.Empty)
		{
			gStruct.sr = smethod_12();
		}
		if (gStruct.md != null && gStruct.md != string.Empty)
		{
			string text = gStruct.md.Replace(" ", string.Empty).ToUpper();
			if (text.Length > 6)
			{
				text = text.Substring(0, 6);
			}
			while (text.Length < 6)
			{
				text += "0";
			}
			array[1] = string.Empty;
			string text2 = text;
			for (int i = 0; i < text2.Length; i++)
			{
				char c = text2[i];
				if (('0' <= c && c <= '9') || ('A' <= c && c <= 'Z'))
				{
					string[] array2;
					(array2 = array)[1] = array2[1] + c;
				}
				else
				{
					string[] array3;
					(array3 = array)[1] = array3[1] + (byte)c;
				}
			}
		}
		string text3 = smethod_9();
		string string_ = (gStruct.fr + gStruct.cap + gStruct.sr + text3).ToUpper();
		string text4 = smethod_8(string_);
		if (text4 != null && text4 != string.Empty)
		{
			int num = 1;
			int num2 = -1;
			for (int j = 0; j < text4.Length; j++)
			{
				if (num2 < 0 || num2 > 10)
				{
					num2 = 0;
					num++;
					if (array.Length <= num)
					{
						break;
					}
					array[num] = string.Empty;
				}
				string[] array5;
				string[] array4 = (array5 = array);
				int num3 = num;
				IntPtr intPtr = (IntPtr)num3;
				array4[num3] = array5[(long)intPtr] + text4[j];
				num2++;
			}
		}
		array[5] = smethod_7();
		return array;
	}

	private static string smethod_7(string string_4 = null)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		StringBuilder stringBuilder2 = new StringBuilder(256);
		char[] char_ = new char[9] { 'ᒺ', 'ᓁ', 'ᒿ', 'ᒷ', 'ᒶ', 'ᓄ', 'ᒻ', 'ᓈ', 'ᒷ' };
		if (string_4 == null)
		{
			string_4 = Environment.GetEnvironmentVariable(Class11.smethod_0(char_));
			if (string_4 == string.Empty || string_4 == null)
			{
				return string.Empty;
			}
			string_4 = string_4[0] + ":\\";
		}
		GetVolumeInformation(string_4, stringBuilder, (uint)(stringBuilder.Capacity - 1), out var uint_, out var _, out var _, stringBuilder2, (uint)(stringBuilder2.Capacity - 1));
		return uint_.ToString();
	}

	public static string smethod_8(string string_4)
	{
		string text = string.Empty;
		if (string_4 != null && string_4 != string.Empty)
		{
			using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_4));
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					text += array[i].ToString("X2");
				}
			}
		}
		while (text.Length < 33)
		{
			text += "0";
		}
		return text;
	}

	public static string smethod_9()
	{
		byte[] byte_ = new byte[8];
		if (!smethod_10(ref byte_))
		{
			return string.Empty;
		}
		return string.Format("{0}{1}", BitConverter.ToUInt32(byte_, 4).ToString("X8"), BitConverter.ToUInt32(byte_, 0).ToString("X8"));
	}

	private static bool smethod_10(ref byte[] byte_0)
	{
		byte[] array = new byte[26]
		{
			85, 137, 229, 87, 139, 125, 16, 106, 1, 88,
			83, 15, 162, 137, 7, 137, 87, 4, 91, 95,
			137, 236, 93, 194, 16, 0
		};
		byte[] array2 = new byte[19]
		{
			83, 72, 199, 192, 1, 0, 0, 0, 15, 162,
			65, 137, 0, 65, 137, 80, 4, 91, 195
		};
		byte[] array3 = ((IntPtr.Size == 8) ? array2 : array);
		IntPtr intptr_ = new IntPtr(array3.Length);
		if (!VirtualProtect(array3, intptr_, 64, out var _))
		{
			Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
		}
		intptr_ = new IntPtr(byte_0.Length);
		try
		{
			return CallWindowProcW(array3, IntPtr.Zero, 0, byte_0, intptr_) != IntPtr.Zero;
		}
		catch
		{
		}
		return false;
	}

	private static bool smethod_11(string string_4)
	{
		try
		{
			IntPtr zero = IntPtr.Zero;
			string format = Class11.smethod_0(char_0);
			for (int i = 0; i < 16; i++)
			{
				string string_5 = string.Format(format, i);
				zero = CreateFile_1(string_5, GEnum5.flag_9 | GEnum5.flag_10, GEnum6.flag_1 | GEnum6.flag_2, IntPtr.Zero, GEnum4.const_2, 0u, IntPtr.Zero);
				if ((int)zero > 0)
				{
					string text = smethod_13(zero);
					if (text == null || text.Length == 0)
					{
						text = smethod_14(zero);
					}
					CloseHandle(zero);
					if (string_4 == text)
					{
						return true;
					}
				}
			}
		}
		catch
		{
		}
		return false;
	}

	private static string smethod_12()
	{
		string text = string.Empty;
		try
		{
			IntPtr zero = IntPtr.Zero;
			string format = Class11.smethod_0(char_0);
			for (int i = 0; i < 16; i++)
			{
				string string_ = string.Format(format, i);
				zero = CreateFile_1(string_, GEnum5.flag_9 | GEnum5.flag_10, GEnum6.flag_1 | GEnum6.flag_2, IntPtr.Zero, GEnum4.const_2, 0u, IntPtr.Zero);
				if ((int)zero > 0)
				{
					text = smethod_13(zero);
					if (text == null || text.Length == 0)
					{
						text = smethod_14(zero);
					}
					CloseHandle(zero);
					if (text != null && text.Length > 0)
					{
						break;
					}
				}
			}
		}
		catch
		{
		}
		return text;
	}

	private static string smethod_13(IntPtr intptr_0)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(32);
		IntPtr intPtr2 = Marshal.AllocHGlobal(24);
		string result = string.Empty;
		uint uint_ = 0u;
		try
		{
			if (DeviceIoControl_2(intptr_0, 475264u, IntPtr.Zero, 0u, intPtr2, 24u, out uint_, IntPtr.Zero) && (Marshal.ReadInt32(intPtr2, 4) & 4) > 0)
			{
				Class33 structure = new Class33();
				intPtr2 = Marshal.ReAllocHGlobal(intPtr2, (IntPtr)528);
				Marshal.StructureToPtr((object)structure, intPtr, true);
				if (DeviceIoControl_2(intptr_0, 508040u, intPtr, 32u, intPtr2, 528u, out uint_, IntPtr.Zero))
				{
					string text = Marshal.PtrToStringAnsi((IntPtr)(intPtr2.ToInt32() + 36), 20);
					if (text.Length != 0)
					{
						char[] array = text.ToCharArray();
						for (int i = 0; i <= array.Length - 2; i += 2)
						{
							char c = array[i];
							array[i] = array[i + 1];
							array[i + 1] = c;
						}
						result = new string(array).Trim();
					}
				}
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
			Marshal.FreeHGlobal(intPtr2);
		}
		return result;
	}

	private static string smethod_14(IntPtr intptr_0)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(12);
		IntPtr intPtr2 = Marshal.AllocHGlobal(1024);
		Class34 structure = new Class34();
		string result = string.Empty;
		uint uint_ = 0u;
		try
		{
			Marshal.StructureToPtr((object)structure, intPtr, true);
			if (DeviceIoControl_2(intptr_0, 2954240u, intPtr, 12u, intPtr2, 1024u, out uint_, IntPtr.Zero))
			{
				int num = intPtr2.ToInt32();
				int num2 = Marshal.ReadInt32(intPtr2, 24);
				if (num2 != 0)
				{
					string text = Marshal.PtrToStringAnsi((IntPtr)(num + num2));
					if (text.Length != 0)
					{
						StringBuilder stringBuilder = new StringBuilder();
						for (int i = 0; i < text.Length; i += 4)
						{
							for (int num3 = 1; num3 >= 0; num3--)
							{
								int num4 = 0;
								for (int j = 0; j < 2; j++)
								{
									num4 *= 16;
									num4 = text[i + num3 * 2 + j] switch
									{
										'0' => num4, 
										'1' => num4 + 1, 
										'2' => num4 + 2, 
										'3' => num4 + 3, 
										'5' => num4 + 5, 
										'6' => num4 + 6, 
										'7' => num4 + 7, 
										'8' => num4 + 8, 
										'9' => num4 + 9, 
										_ => num4 + 4, 
									};
								}
								if (num4 > 0)
								{
									stringBuilder.Append((char)num4);
								}
							}
						}
						result = stringBuilder.ToString().Trim();
					}
				}
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
			Marshal.FreeHGlobal(intPtr2);
		}
		return result;
	}
}
