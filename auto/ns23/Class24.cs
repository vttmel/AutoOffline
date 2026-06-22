using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using ns1;
using ns11;
using ns22;
using ns63;

namespace ns23;

internal class Class24
{
	public struct Struct7
	{
		public string string_0;

		public uint uint_0;
	}

	public struct POINT
	{
		public int x;

		public int y;
	}

	public const int int_0 = 2;

	public const int int_1 = 4;

	public const int int_2 = 256;

	public const int int_3 = 257;

	public const int int_4 = 13;

	public const int int_5 = 2;

	public const int int_6 = 1;

	public const int int_7 = 277;

	public const int int_8 = 4;

	private const int int_9 = 4096;

	private const int int_10 = 4100;

	private const int int_11 = 4101;

	private const int int_12 = 4102;

	private const int int_13 = 4139;

	private const int int_14 = 4140;

	private const int int_15 = 4146;

	private const int int_16 = 4171;

	private const uint uint_0 = 1u;

	private const uint uint_1 = 1u;

	private const uint uint_2 = 2u;

	private const uint uint_3 = 8u;

	private const uint uint_4 = 4096u;

	private const uint uint_5 = 8192u;

	private const uint uint_6 = 61440u;

	private const uint uint_7 = 2035711u;

	private const uint uint_8 = 4096u;

	private const uint uint_9 = 32768u;

	private const uint uint_10 = 4u;

	private const int int_17 = 4116;

	private const int int_18 = 16;

	private const int int_19 = 1;

	private const int int_20 = 4;

	private const int int_21 = 2;

	private const int int_22 = 23;

	public static int int_23 = 16;

	public static int int_24 = 0;

	public static int int_25 = 5;

	public static int int_26 = 6;

	public static int int_27 = 9;

	public static int int_28 = 256;

	public static int int_29 = 257;

	public static int int_30 = 39;

	public static int int_31 = 512;

	public static int int_32 = 516;

	public static int int_33 = 517;

	public static int int_34 = 518;

	public static int int_35 = 2;

	public static int int_36 = 513;

	public static int int_37 = 514;

	public static int int_38 = 515;

	public static int int_39 = 1;

	public static int int_40 = Class66.smethod_4("RunAdmin", 0, "1");

	[DllImport("user32.dll")]
	public static extern short VkKeyScan(char char_0);

	[DllImport("e.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int SendEnterKey(uint uint_11);

	[DllImport("user32.dll")]
	public static extern void keybd_event(byte byte_0, byte byte_1, int int_41, int int_42);

	[DllImport("user32.dll")]
	public static extern bool GetCursorPos(out POINT point_0);

	[DllImport("user32.dll")]
	public static extern void mouse_event(int int_41, int int_42, int int_43, int int_44, int int_45);

	[DllImport("user32.dll")]
	public static extern bool ClientToScreen(uint uint_11, ref POINT point_0);

	[DllImport("user32.dll")]
	public static extern IntPtr SendMessage(uint uint_11, int int_41, int int_42, int int_43);

	[DllImport("shell32.dll")]
	public static extern bool SHGetSpecialFolderPath(IntPtr intptr_0, [Out] StringBuilder stringBuilder_0, int int_41, bool bool_0);

	[DllImport("kernel32.dll")]
	public static extern int GetUserDefaultLCID();

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetWindowRect(uint uint_11, ref GStruct13 gstruct13_0);

	[DllImport("User32.Dll")]
	public static extern bool ClientToScreen(uint uint_11, ref GStruct12 gstruct12_0);

	[DllImport("user32.dll")]
	public static extern uint SendInput(uint uint_11, [In][MarshalAs(UnmanagedType.LPArray)] GStruct9[] gstruct9_0, int int_41);

	[DllImport("Kernel32.dll")]
	public static extern uint QueryFullProcessImageName(IntPtr intptr_0, uint uint_11, StringBuilder stringBuilder_0, out uint uint_12);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int GetScrollPos(IntPtr intptr_0, int int_41);

	[DllImport("user32.dll")]
	public static extern int SetScrollPos(IntPtr intptr_0, int int_41, int int_42, bool bool_0);

	[DllImport("user32.dll")]
	public static extern bool GetScrollRange(IntPtr intptr_0, int int_41, out int int_42, out int int_43);

	[DllImport("user32.dll")]
	public static extern bool PostMessageA(IntPtr intptr_0, int int_41, int int_42, int int_43);

	[DllImport("User32.Dll")]
	public static extern bool GetCursorPos(ref GStruct12 gstruct12_0);

	[DllImport("kernel32.dll")]
	private static extern uint SuspendThread(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	private static extern int ResumeThread(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenThread(GEnum2 genum2_0, bool bool_0, uint uint_11);

	[DllImport("kernel32.dll")]
	private static extern bool TerminateThread(IntPtr intptr_0, uint uint_11);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtQueryInformationThread(IntPtr intptr_0, int int_41, IntPtr intptr_1, int int_42, IntPtr intptr_2);

	[DllImport("User32.Dll")]
	public static extern long SetCursorPos(int int_41, int int_42);

	[DllImport("kernel32.dll")]
	public static extern bool CreateProcess(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, GEnum3 genum3_0, IntPtr intptr_2, string string_2, ref GStruct3 gstruct3_0, out GStruct4 gstruct4_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr OpenSCManagerW(string string_0, string string_1, uint uint_11);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr OpenService(IntPtr intptr_0, string string_0, uint uint_11);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ControlService(IntPtr intptr_0, int int_41, ref GStruct6 gstruct6_0);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseServiceHandle(IntPtr intptr_0);

	public static bool smethod_0(string string_0, ref int int_41, int int_42 = 1)
	{
		bool result = false;
		GStruct6 gstruct6_ = default(GStruct6);
		IntPtr intPtr = OpenSCManagerW("", null, 983103u);
		if (intPtr != IntPtr.Zero)
		{
			IntPtr intPtr2 = OpenService(intPtr, string_0, 983103u);
			if (intPtr2 != IntPtr.Zero)
			{
				result = ControlService(intPtr2, 1, ref gstruct6_);
				int_41 = gstruct6_.int_1;
				CloseServiceHandle(intPtr2);
			}
			CloseServiceHandle(intPtr);
		}
		return result;
	}

	[DllImport("User32.dll")]
	public static extern int FindWindow(string string_0, string string_1);

	[DllImport("User32.dll")]
	public static extern uint FindWindowEx(uint uint_11, uint uint_12, string string_0, string string_1);

	[DllImport("user32.dll")]
	public static extern uint GetWindowThreadProcessId(uint uint_11, out int int_41);

	[DllImport("user32.dll")]
	public static extern int GetWindowText(uint uint_11, StringBuilder stringBuilder_0, int int_41);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int GetClassName(uint uint_11, StringBuilder stringBuilder_0, int int_41);

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
	public static extern uint GetWindowThreadProcessId_1(uint uint_11, out uint uint_12);

	[DllImport("kernel32.dll")]
	public static extern int OpenProcess(int int_41, bool bool_0, int int_42);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	public static extern uint VirtualAllocEx(int int_41, uint uint_11, uint uint_12, GEnum0 genum0_0, GEnum1 genum1_0);

	[DllImport("kernel32.dll")]
	public static extern bool VirtualFreeEx(int int_41, uint uint_11, uint uint_12, uint uint_13);

	[DllImport("kernel32.dll")]
	public static extern uint CreateRemoteThread(int int_41, IntPtr intptr_0, uint uint_11, uint uint_12, uint uint_13, uint uint_14, out uint uint_15);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint WaitForSingleObject(uint uint_11, uint uint_12);

	public static uint smethod_1(int int_41, uint uint_11 = 512u, GEnum1 genum1_0 = GEnum1.flag_2)
	{
		return VirtualAllocEx(int_41, 0u, uint_11, GEnum0.flag_0 | GEnum0.flag_1, genum1_0);
	}

	public static bool smethod_2(int int_41, uint uint_11)
	{
		return VirtualFreeEx(int_41, uint_11, 0u, 32768u);
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern uint GetProcAddress(uint uint_11, string string_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint GetModuleHandle(string string_0);

	[DllImport("kernel32.dll")]
	public static extern bool ReadProcessMemory(int int_41, uint uint_11, byte[] byte_0, int int_42, ref int int_43);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool WriteProcessMemory(int int_41, uint uint_11, byte[] byte_0, int int_42, ref int int_43);

	[DllImport("kernel32", EntryPoint = "WriteProcessMemory")]
	public static extern bool WriteProcessMemory_1(int int_41, uint uint_11, ref GStruct5 gstruct5_0, int int_42, int int_43 = 0);

	[DllImport("user32.dll")]
	public static extern bool EnableWindow(uint uint_11, bool bool_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWindowEnabled(uint uint_11);

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(uint uint_11, int int_41);

	[DllImport("user32.dll")]
	public static extern IntPtr SetForegroundWindow(uint uint_11);

	[DllImport("user32.dll")]
	public static extern uint GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	public static extern short VkKeyScan(int int_41);

	[DllImport("User32.Dll", EntryPoint = "PostMessageA")]
	public static extern bool PostMessageA_1(uint uint_11, int int_41, uint uint_12, uint uint_13);

	[DllImport("user32.dll")]
	public static extern int SendMessage(uint uint_11, int int_41, int int_42, uint uint_12);

	[DllImport("user32.dll")]
	public static extern int MapVirtualKey(uint uint_11, uint uint_12);

	public static void smethod_3(uint uint_11, uint uint_12)
	{
		PostMessageA_1(uint_11, int_28, uint_12, 0u);
		PostMessageA_1(uint_11, int_29, uint_12, 0u);
	}

	public static void smethod_4(uint uint_11, uint uint_12)
	{
		short uint_13 = VkKeyScan((int)uint_12);
		short num = (short)MapVirtualKey((uint)uint_13, 0u);
		uint num2 = (uint)((num << 16) | 1);
		uint uint_14 = (uint)(num2 | -1073741824L);
		PostMessageA_1(uint_11, int_28, uint_12, num2);
		PostMessageA_1(uint_11, int_29, uint_12, uint_14);
	}

	public static void smethod_5(string string_0)
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.FileName = Class11.smethod_0(Class11.char_4);
		processStartInfo.Arguments = "/c " + string_0;
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static uint smethod_6(int int_41)
	{
		return (uint)(int_41 << 12);
	}

	public static int smethod_7(uint uint_11)
	{
		return SendMessage(uint_11, 4100, 0, 0u);
	}

	public static int smethod_8(int int_41, uint uint_11, string string_0, uint uint_12 = 0u, bool bool_0 = true, bool bool_1 = true)
	{
		if (string_0 != null && !(string_0 == ""))
		{
			int num = SendMessage(uint_11, 4100, 0, 0u);
			if (num > 0)
			{
				string text = Class1.smethod_1(string_0, 1, bool_0: true);
				string text2 = Class1.smethod_1(string_0, 0, bool_0: true);
				for (int i = 0; i < num; i++)
				{
					string text3 = smethod_12(int_41, uint_11, i, 0, uint_12);
					if (string_0 == text3 || text == text3 || text2 == text3)
					{
						return i;
					}
				}
				return -1;
			}
			return -1;
		}
		return -1;
	}

	public static int smethod_9(uint uint_11)
	{
		return SendMessage(uint_11, 4146, 0, 0u);
	}

	public static bool smethod_10(uint uint_11, int int_41)
	{
		int num = SendMessage(uint_11, 4140, int_41, 2u);
		int num2 = 2 & num;
		return num2 > 0;
	}

	public static int smethod_11(uint uint_11, int int_41, bool bool_0 = false)
	{
		int num = (int_41 << 16) | 4;
		if (!bool_0)
		{
			return SendMessage(uint_11, 4116, 0, (uint)num);
		}
		return SendMessage(uint_11, 4116, num, 0u);
	}

	public static string smethod_12(int int_41, uint uint_11, int int_42, int int_43 = 0, uint uint_12 = 0u)
	{
		string result = null;
		bool flag = false;
		try
		{
			int num = Marshal.SizeOf(typeof(GStruct5));
			byte[] array = new byte[256];
			if (uint_12 == 0)
			{
				uint_12 = smethod_1(int_41, (uint)array.Length);
				if (uint_12 == 0)
				{
					return null;
				}
				flag = true;
			}
			GStruct5 gstruct5_ = new GStruct5
			{
				uint_0 = 1u,
				int_0 = int_42,
				int_1 = int_43,
				intptr_0 = (IntPtr)(uint_12 + num),
				int_2 = 50
			};
			if (WriteProcessMemory_1(int_41, uint_12, ref gstruct5_, num))
			{
				SendMessage(uint_11, 4171, 0, uint_12);
				int int_44 = 0;
				if (ReadProcessMemory(int_41, uint_12 + (uint)num, array, 60, ref int_44))
				{
					int num2 = 0;
					for (num2 = 0; num2 < int_44 / 2 && array[num2 * 2] + array[num2 * 2 + 1] != 0; num2++)
					{
					}
					if (num2 > 0)
					{
						result = Encoding.Unicode.GetString(array, 0, num2 * 2);
					}
				}
			}
		}
		catch
		{
		}
		if (flag && uint_12 != 0)
		{
			smethod_2(int_41, uint_12);
		}
		return result;
	}

	public static int smethod_13(int int_41, uint uint_11, int int_42, uint uint_12 = 0u)
	{
		int int_43 = Marshal.SizeOf(typeof(GStruct5));
		byte[] array = new byte[256];
		bool flag = false;
		if (uint_12 == 0)
		{
			uint_12 = smethod_1(int_41, (uint)array.Length);
			if (uint_12 == 0)
			{
				return -1;
			}
			flag = true;
		}
		GStruct5 gstruct5_ = new GStruct5
		{
			uint_0 = 8u,
			uint_1 = 0u,
			uint_2 = 3u
		};
		int result = 0;
		if (WriteProcessMemory_1(int_41, uint_12, ref gstruct5_, int_43))
		{
			result = SendMessage(uint_11, 4139, int_42, uint_12);
		}
		if (flag && uint_12 != 0)
		{
			smethod_2(int_41, uint_12);
		}
		return result;
	}

	public static int smethod_14(int int_41, uint uint_11, int int_42, uint uint_12 = 0u)
	{
		int int_43 = Marshal.SizeOf(typeof(GStruct5));
		byte[] array = new byte[256];
		bool flag = false;
		if (uint_12 == 0)
		{
			uint_12 = smethod_1(int_41, (uint)array.Length);
			if (uint_12 == 0)
			{
				return -1;
			}
			flag = true;
		}
		GStruct5 gstruct5_ = new GStruct5
		{
			uint_0 = 8u,
			uint_1 = 3u,
			uint_2 = 3u
		};
		int result = 0;
		if (WriteProcessMemory_1(int_41, uint_12, ref gstruct5_, int_43))
		{
			result = SendMessage(uint_11, 4139, int_42, uint_12);
		}
		if (flag && uint_12 != 0)
		{
			smethod_2(int_41, uint_12);
		}
		return result;
	}

	public static void smethod_15(int int_41, uint uint_11, int int_42, uint uint_12 = 0u)
	{
		int num = smethod_7(uint_11);
		for (int i = 0; i < num; i++)
		{
			if (smethod_10(uint_11, i))
			{
				smethod_13(int_41, uint_11, i, uint_12);
			}
		}
	}

	public static int smethod_16(int int_41, uint uint_11, int int_42, uint uint_12 = 0u)
	{
		int int_43 = Marshal.SizeOf(typeof(GStruct5));
		byte[] array = new byte[256];
		bool flag = false;
		if (uint_12 == 0)
		{
			uint_12 = smethod_1(int_41, (uint)array.Length);
			if (uint_12 == 0)
			{
				return -1;
			}
			flag = true;
		}
		GStruct5 gstruct5_ = new GStruct5
		{
			uint_0 = 8u,
			uint_1 = smethod_6(2),
			uint_2 = 61440u
		};
		int result = 0;
		if (WriteProcessMemory_1(int_41, uint_12, ref gstruct5_, int_43))
		{
			result = SendMessage(uint_11, 4139, int_42, uint_12);
		}
		if (flag && uint_12 != 0)
		{
			smethod_2(int_41, uint_12);
		}
		return result;
	}

	public static int smethod_17(int int_41, uint uint_11, string string_0, uint uint_12 = 0u, bool bool_0 = true, bool bool_1 = true)
	{
		int num = smethod_8(int_41, uint_11, string_0, uint_12, bool_0, bool_1);
		if (num < 0)
		{
			return -1;
		}
		return smethod_16(int_41, uint_11, num, uint_12);
	}

	public static int smethod_18(int int_41, uint uint_11, int int_42, uint uint_12 = 0u)
	{
		int int_43 = Marshal.SizeOf(typeof(GStruct5));
		byte[] array = new byte[256];
		bool flag = false;
		if (uint_12 == 0)
		{
			uint_12 = smethod_1(int_41, (uint)array.Length);
			if (uint_12 == 0)
			{
				return -1;
			}
			flag = true;
		}
		GStruct5 gstruct5_ = new GStruct5
		{
			uint_0 = 8u,
			uint_1 = smethod_6(1),
			uint_2 = 61440u
		};
		int result = 0;
		if (WriteProcessMemory_1(int_41, uint_12, ref gstruct5_, int_43))
		{
			result = SendMessage(uint_11, 4139, int_42, uint_12);
		}
		if (flag && uint_12 != 0)
		{
			smethod_2(int_41, uint_12);
		}
		return result;
	}

	public static int smethod_19(int int_41, uint uint_11, string string_0, uint uint_12 = 0u, bool bool_0 = true, bool bool_1 = true)
	{
		int num = smethod_8(int_41, uint_11, string_0, uint_12, bool_0, bool_1);
		if (num < 0)
		{
			return -1;
		}
		return smethod_18(int_41, uint_11, num, uint_12);
	}

	private static string smethod_20(string string_0, string string_1, int int_41, char char_0 = ':')
	{
		if (Class11.smethod_1(string_0.ToUpper(), string_1.ToUpper() + ":") >= 0)
		{
			string[] array = string_0.Split(char_0);
			if (array.Length > int_41)
			{
				return array[int_41];
			}
		}
		return null;
	}

	private static void smethod_21(ref GStruct7[] gstruct7_0, uint uint_11, int int_41)
	{
		GStruct7 gStruct = new GStruct7
		{
			uint_0 = uint_11,
			int_0 = int_41
		};
		if (gstruct7_0 == null)
		{
			gstruct7_0 = new GStruct7[1] { gStruct };
			return;
		}
		GStruct7[] array = new GStruct7[gstruct7_0.Length + 1];
		int num = 0;
		while (true)
		{
			if (num < gstruct7_0.Length)
			{
				ref GStruct7 reference = ref array[num];
				reference = gstruct7_0[num];
				if (gstruct7_0[num].uint_0 == uint_11)
				{
					break;
				}
				num++;
				continue;
			}
			array[array.Length - 1] = gStruct;
			gstruct7_0 = array;
			return;
		}
		gstruct7_0[num].int_0 = int_41;
	}

	private static void smethod_22(ref GStruct8[] gstruct8_0, uint uint_11)
	{
		GStruct8 gStruct = new GStruct8
		{
			uint_0 = uint_11,
			gstruct7_0 = null
		};
		if (gstruct8_0 != null)
		{
			GStruct8[] array = new GStruct8[gstruct8_0.Length + 1];
			int num = 0;
			while (true)
			{
				if (num < gstruct8_0.Length)
				{
					ref GStruct8 reference = ref array[num];
					reference = gstruct8_0[num];
					if (gstruct8_0[num].uint_0 != uint_11)
					{
						num++;
						continue;
					}
					break;
				}
				array[array.Length - 1] = gStruct;
				gstruct8_0 = array;
				break;
			}
		}
		else
		{
			gstruct8_0 = new GStruct8[1] { gStruct };
		}
	}

	public static int smethod_23(string string_0, string string_1 = null, int[] int_41 = null, bool bool_0 = false)
	{
		int int_42 = 256;
		StringBuilder stringBuilder = new StringBuilder(256);
		uint num = 0u;
		int num2 = 0;
		if (string_1 == null)
		{
			string_1 = string.Empty;
		}
		if (string_1 != string.Empty)
		{
			string_1 = string_1.ToLower();
		}
		while (true)
		{
			IL_00b3:
			num = FindWindowEx(0u, num, string_0, null);
			if (num != 0)
			{
				if (GetWindowText(num, stringBuilder, int_42) <= 0)
				{
					continue;
				}
				if (string_1 != string.Empty)
				{
					string text = stringBuilder.ToString().ToLower();
					if (!(text == string_1) && (bool_0 || 0 > text.IndexOf(string_1)))
					{
						continue;
					}
				}
				num2 = 0;
				GetWindowThreadProcessId(num, out num2);
				if (int_41 == null)
				{
					break;
				}
				int num3 = 0;
				while (num3 < int_41.Length)
				{
					if (num2 != int_41[num3])
					{
						num3++;
						continue;
					}
					goto IL_00b3;
				}
				break;
			}
			return 0;
		}
		return num2;
	}

	public static int[] smethod_24(string string_0, string string_1 = null, bool bool_0 = false)
	{
		int int_ = 256;
		StringBuilder stringBuilder = new StringBuilder(256);
		uint num = 0u;
		int num2 = 0;
		int[] array = null;
		if (string_1 == null)
		{
			string_1 = string.Empty;
		}
		if (string_1 != string.Empty)
		{
			string_1 = string_1.ToLower();
		}
		while (true)
		{
			num = FindWindowEx(0u, num, string_0, null);
			if (num == 0)
			{
				break;
			}
			if (GetWindowText(num, stringBuilder, int_) <= 0)
			{
				continue;
			}
			if (string_1 != string.Empty)
			{
				string text = stringBuilder.ToString().ToLower();
				if (!(text == string_1) && (bool_0 || 0 > text.IndexOf(string_1)))
				{
					continue;
				}
			}
			num2 = 0;
			GetWindowThreadProcessId(num, out num2);
			if (array != null)
			{
				int num3 = array.Length;
				int num4 = 0;
				while (true)
				{
					if (num4 < num3)
					{
						if (num2 == array[num4])
						{
							break;
						}
						num4++;
						continue;
					}
					Array.Resize(ref array, num3 + 1);
					array[num3] = num2;
					break;
				}
			}
			else
			{
				array = new int[1] { num2 };
			}
		}
		return array;
	}

	public static string smethod_25(int int_41, string string_0, bool bool_0 = true, bool bool_1 = true)
	{
		string_0 = string_0.ToUpper();
		int int_42 = 256;
		uint num = 0u;
		StringBuilder stringBuilder = new StringBuilder(256);
		string text = "";
		while (int_41 > 0 || bool_0)
		{
			num = FindWindowEx(0u, num, null, null);
			if (num == 0)
			{
				break;
			}
			int int_43 = 0;
			GetWindowThreadProcessId(num, out int_43);
			if (int_43 != int_41 && (!bool_0 || string_0 == ""))
			{
				continue;
			}
			int windowText = GetWindowText(num, stringBuilder, int_42);
			if (windowText <= 0)
			{
				continue;
			}
			string text2 = stringBuilder.ToString().ToUpper();
			if (text2 != "" && (string_0 == "" || text2 == string_0 || (!bool_1 && Class11.smethod_1(text2, string_0) >= 0)))
			{
				if (text != "")
				{
					text = ";" + text;
				}
				text = num + text;
			}
		}
		return text;
	}

	public static string smethod_26(byte[] byte_0, int int_41 = 0)
	{
		string text = "";
		if (int_41 <= 0)
		{
			for (int i = 0; i < byte_0.Length && byte_0[i] != 0; i++)
			{
				string text2 = text;
				char c = (char)byte_0[i];
				text = text2 + c;
			}
			return text;
		}
		for (int j = 0; j < byte_0.Length && byte_0[j] != 0; j += 2)
		{
			string text3 = text;
			char c = (char)byte_0[j];
			text = text3 + c;
		}
		return text;
	}

	public static string smethod_27(byte[] byte_0, int int_41, int int_42)
	{
		if (byte_0 != null && byte_0.Length != 0 && int_42 != 0)
		{
			string text = null;
			int num = int_41 + int_42;
			for (int i = int_41; i < num; i++)
			{
				string text2 = text;
				char c = (char)byte_0[i];
				text = text2 + c;
			}
			return text;
		}
		return string.Empty;
	}

	public static string smethod_28(uint uint_11, int int_41, int int_42 = 40)
	{
		byte[] array = null;
		int int_43 = 0;
		while (true)
		{
			array = new byte[int_42];
			if (ReadProcessMemory(int_41, uint_11, array, array.Length, ref int_43) || int_42 <= 0)
			{
				break;
			}
			int_42--;
		}
		int num = Array.IndexOf(array, (byte)0);
		num = ((num >= 0) ? num : array.Length);
		return Encoding.UTF7.GetString(array, 0, num);
	}

	public static string smethod_29(uint uint_11, int int_41, int int_42 = 40)
	{
		if (int_42 > 512)
		{
			int_42 = 512;
		}
		int int_43 = 0;
		byte[] array = new byte[int_42];
		if (!ReadProcessMemory(int_41, uint_11, array, array.Length, ref int_43))
		{
			return string.Empty;
		}
		int num = array.Length;
		for (int i = 0; i < array.Length && array[num - i - 1] <= 0; i++)
		{
			int_42--;
		}
		if (int_42 == 0)
		{
			return string.Empty;
		}
		return Encoding.UTF7.GetString(array, 0, int_42);
	}

	public static uint smethod_30(uint uint_11, int int_41)
	{
		int int_42 = 0;
		byte[] array = new byte[4];
		ReadProcessMemory(int_41, uint_11, array, 4, ref int_42);
		return BitConverter.ToUInt32(array, 0);
	}

	public static bool smethod_31(uint uint_11, int int_41, uint uint_12, int int_42 = 4)
	{
		int int_43 = 0;
		byte[] array = BitConverter.GetBytes(uint_12);
		int int_44 = array.Length;
		if (int_42 > 0)
		{
			byte[] array2 = new byte[int_42];
			for (int i = 0; i < int_42; i++)
			{
				if (i < array.Length)
				{
					array2[i] = array[i];
				}
			}
			array = array2;
			int_44 = int_42;
		}
		else if (uint_12 >> 8 == 0)
		{
			int_44 = 1;
		}
		else if (uint_12 >> 16 == 0)
		{
			int_44 = 2;
		}
		return WriteProcessMemory(int_41, uint_11, array, int_44, ref int_43);
	}

	public static void smethod_32(int int_41)
	{
		try
		{
			CloseHandle((IntPtr)int_41);
		}
		catch
		{
		}
	}

	public static uint smethod_33(string string_0, string string_1, int int_41 = 0)
	{
		if (int_41 == 0)
		{
			int_41 = Process.GetCurrentProcess().Id;
		}
		uint num = smethod_35(int_41, string_0);
		uint procAddress = GetProcAddress(num, string_1);
		if (procAddress != 0)
		{
			return procAddress - num;
		}
		return 0u;
	}

	public static string smethod_34(int int_41, string string_0 = "")
	{
		try
		{
			return Process.GetProcessById(int_41).MainModule.FileName;
		}
		catch
		{
			return string_0;
		}
	}

	public static uint smethod_35(int int_41, string string_0)
	{
		try
		{
			string_0 = string_0.ToUpper();
			ProcessModuleCollection modules = Process.GetProcessById(int_41).Modules;
			int count = modules.Count;
			for (int i = 0; i < count; i++)
			{
				if (modules[count - i - 1].ModuleName.ToUpper() == string_0)
				{
					return (uint)(int)modules[count - i - 1].BaseAddress;
				}
			}
		}
		catch
		{
		}
		return 0u;
	}

	private static void smethod_36(ref Struct7[] struct7_0, string string_0, uint uint_11)
	{
		Struct7 @struct = new Struct7
		{
			uint_0 = uint_11,
			string_0 = string_0
		};
		if (struct7_0 != null && struct7_0.Length != 0)
		{
			Struct7[] array = new Struct7[struct7_0.Length + 1];
			int num = 0;
			while (true)
			{
				if (num < struct7_0.Length)
				{
					if (!(struct7_0[num].string_0 == string_0) || struct7_0[num].uint_0 != uint_11)
					{
						ref Struct7 reference = ref array[num];
						reference = struct7_0[num];
						num++;
						continue;
					}
					break;
				}
				array[array.Length - 1] = @struct;
				struct7_0 = array;
				break;
			}
		}
		else
		{
			struct7_0 = new Struct7[1] { @struct };
		}
	}

	public static uint smethod_37(int int_41, string string_0)
	{
		try
		{
			string_0 = string_0.ToUpper();
			ProcessModuleCollection modules = Process.GetProcessById(int_41).Modules;
			int count = modules.Count;
			for (int i = 0; i < count; i++)
			{
				if (modules[count - i - 1].ModuleName.ToUpper() == string_0)
				{
					return (uint)(int)modules[count - i - 1].BaseAddress;
				}
			}
		}
		catch
		{
		}
		return 0u;
	}

	public static void smethod_38(int int_41, string string_0, ref Struct7[] struct7_0)
	{
		try
		{
			string_0 = string_0.ToUpper();
			ProcessModuleCollection modules = Process.GetProcessById(int_41).Modules;
			int count = modules.Count;
			for (int i = 0; i < count; i++)
			{
				string text = modules[count - i - 1].ModuleName.ToUpper();
				if (Class11.smethod_1(text, string_0) >= 0)
				{
					smethod_36(ref struct7_0, text, (uint)(int)modules[count - i - 1].BaseAddress);
				}
			}
		}
		catch
		{
		}
	}

	public static GStruct4 smethod_39(ref GStruct3 gstruct3_0, string string_0, string string_1 = null, string string_2 = null)
	{
		GStruct4 gstruct4_ = default(GStruct4);
		if (!CreateProcess(string_0, string_2, IntPtr.Zero, IntPtr.Zero, bool_0: false, GEnum3.flag_10, IntPtr.Zero, string_1, ref gstruct3_0, out gstruct4_))
		{
			gstruct4_.uint_0 = 0u;
			gstruct4_.uint_1 = 0u;
			gstruct4_.intptr_0 = IntPtr.Zero;
			gstruct4_.intptr_1 = IntPtr.Zero;
		}
		return gstruct4_;
	}

	public static Process smethod_40(string string_0, string string_1 = "", string string_2 = "", byte byte_0 = 0, bool bool_0 = false, bool bool_1 = false)
	{
		Process process = new Process();
		try
		{
			if (string_2 == null)
			{
				string_2 = string.Empty;
			}
			process.StartInfo.FileName = string_0;
			if (string_1 != "")
			{
				process.StartInfo.WorkingDirectory = string_1;
			}
			process.StartInfo.Arguments = string_2;
			if (bool_0)
			{
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			}
			process.StartInfo.UseShellExecute = bool_1;
			process.Start();
			if (byte_0 > 0)
			{
				process.WaitForInputIdle();
			}
		}
		catch
		{
			process = null;
		}
		return process;
	}

	public static GStruct4 smethod_41(string string_0, string string_1 = null, bool bool_0 = false, string string_2 = null)
	{
		GStruct3 gstruct3_ = default(GStruct3);
		if (bool_0)
		{
			gstruct3_.uint_8 = 1u;
			gstruct3_.short_0 = 0;
		}
		return smethod_39(ref gstruct3_, string_0, string_1, string_2);
	}

	public static void smethod_42(GStruct4 gstruct4_0)
	{
		IntPtr intptr_ = gstruct4_0.intptr_1;
		SuspendThread(intptr_);
	}

	public static void smethod_43(Process process_0)
	{
		try
		{
			if (process_0.ProcessName == null || process_0.ProcessName == "")
			{
				return;
			}
			foreach (ProcessThread thread in process_0.Threads)
			{
				IntPtr intPtr = OpenThread(GEnum2.flag_1, bool_0: false, (uint)thread.Id);
				if (!(intPtr == IntPtr.Zero))
				{
					SuspendThread(intPtr);
					CloseHandle(intPtr);
				}
			}
		}
		catch
		{
		}
	}

	public static void smethod_44(GStruct4 gstruct4_0)
	{
		IntPtr intptr_ = gstruct4_0.intptr_1;
		ResumeThread(intptr_);
	}

	public static void smethod_45(Process process_0)
	{
		try
		{
			if (process_0.ProcessName == null || process_0.ProcessName == "")
			{
				return;
			}
			foreach (ProcessThread thread in process_0.Threads)
			{
				IntPtr intPtr = OpenThread(GEnum2.flag_1, bool_0: false, (uint)thread.Id);
				if (!(intPtr == IntPtr.Zero))
				{
					int num = 0;
					do
					{
						num = ResumeThread(intPtr);
					}
					while (num > 0);
					CloseHandle(intPtr);
				}
			}
		}
		catch
		{
		}
	}

	public static void smethod_46(int int_41)
	{
		smethod_43(Process.GetProcessById(int_41));
	}

	public static void smethod_47(int int_41)
	{
		smethod_45(Process.GetProcessById(int_41));
	}

	public static void smethod_48(int int_41)
	{
		long long_ = Class11.smethod_27();
		while (int_41 > 0 && smethod_51(int_41) && Class11.smethod_28(long_) < 3000L)
		{
			try
			{
				Process processById = Process.GetProcessById(int_41);
				processById.Kill();
			}
			catch
			{
			}
		}
	}

	public static void smethod_49(Process process_0)
	{
		try
		{
			long long_ = Class11.smethod_27();
			while (!smethod_52(process_0) && Class11.smethod_28(long_) < 3000L)
			{
				process_0.Kill();
			}
		}
		catch
		{
		}
	}

	public static void smethod_50(Process process_0)
	{
		try
		{
			process_0.Close();
		}
		catch
		{
		}
	}

	public static bool smethod_51(int int_41)
	{
		Process process = null;
		try
		{
			process = Process.GetProcessById(int_41);
		}
		catch
		{
		}
		return process != null && process.Id > 0;
	}

	public static bool smethod_52(Process process_0)
	{
		try
		{
			return process_0?.HasExited ?? true;
		}
		catch
		{
		}
		return true;
	}

	public static void smethod_53(Process process_0)
	{
		if (process_0 != null)
		{
			try
			{
				process_0.Kill();
			}
			catch
			{
			}
		}
	}

	public static int smethod_54(string string_0)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_0);
			if (processesByName != null && processesByName.Length != 0)
			{
				return processesByName[0].Id;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_55(Process process_0)
	{
		try
		{
			return process_0.Id;
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_56()
	{
		return Process.GetCurrentProcess().Id;
	}

	public static bool smethod_57(ref Process process_0, int int_41)
	{
		try
		{
			process_0 = Process.GetProcessById(int_41);
			return process_0.Id > 0;
		}
		catch
		{
		}
		return false;
	}

	public static uint smethod_58(Process process_0)
	{
		try
		{
			return (uint)(int)process_0.MainModule.BaseAddress;
		}
		catch
		{
		}
		return 0u;
	}

	public static uint smethod_59(int int_41)
	{
		try
		{
			Process processById = Process.GetProcessById(int_41);
			return (uint)(int)processById.MainModule.BaseAddress;
		}
		catch
		{
		}
		return 0u;
	}

	public static string smethod_60(int int_41, bool bool_0)
	{
		try
		{
			Process processById = Process.GetProcessById(int_41);
			if (bool_0)
			{
				return processById.MainModule.FileName;
			}
			return processById.MainModule.ModuleName;
		}
		catch
		{
		}
		return "";
	}

	public static uint[] smethod_61(int int_41, string string_0)
	{
		string[] array = string_0.Split('|');
		uint[] array2 = new uint[array.Length];
		try
		{
			ProcessModuleCollection modules = Process.GetProcessById(int_41).Modules;
			int count = modules.Count;
			for (int i = 0; i < count; i++)
			{
				for (int j = 0; j < array.Length; j++)
				{
					string text = array[j].ToUpper();
					if (modules[count - i - 1].ModuleName.ToUpper() == text)
					{
						array2[j] = (uint)(int)modules[count - i - 1].BaseAddress;
					}
				}
			}
		}
		catch
		{
		}
		return array2;
	}

	public static GStruct8[] smethod_62(int int_41, string string_0, int int_42 = 0)
	{
		GStruct8[] gstruct8_ = null;
		if (string_0 != null && !(string_0 == ""))
		{
			string text = null;
			string text2 = null;
			string text3 = null;
			string text4 = null;
			string[] array = string_0.Split('|');
			for (int i = 0; i < array.Length; i++)
			{
				if (text == null)
				{
					text = smethod_20(array[i], "WIN_TITLE", 1);
				}
				if (text2 == null)
				{
					text2 = smethod_20(array[i], "WIN_CLASS", 1);
				}
				if (text3 == null)
				{
					text3 = smethod_20(array[i], "CTR_CLASS", 1);
				}
				if (text4 == null)
				{
					text4 = smethod_20(array[i], "CTR_INSTANCE", 1);
				}
			}
			int num = -1;
			if (text4 != null)
			{
				num = Class11.smethod_11(text4);
			}
			int int_43 = 256;
			uint num2 = 0u;
			StringBuilder stringBuilder = new StringBuilder(256);
			while (int_41 > 0)
			{
				num2 = FindWindowEx(0u, num2, text2, null);
				if (num2 == 0)
				{
					break;
				}
				int int_44 = 0;
				GetWindowThreadProcessId(num2, out int_44);
				if (int_44 != int_41)
				{
					continue;
				}
				if (text != null && text != "")
				{
					int windowText = GetWindowText(num2, stringBuilder, int_43);
					if (windowText <= 0)
					{
						continue;
					}
					string text5 = stringBuilder.ToString().ToUpper();
					if (text5 == "" || Class11.smethod_1(text5, text.ToUpper()) < 0)
					{
						continue;
					}
				}
				if (text2 != null && text2 != "")
				{
					int className = GetClassName(num2, stringBuilder, int_43);
					if (className <= 0)
					{
						continue;
					}
					string text6 = stringBuilder.ToString().ToUpper();
					if (text6 != text2.ToUpper())
					{
						continue;
					}
				}
				smethod_22(ref gstruct8_, num2);
				uint num3 = 0u;
				int num4 = 0;
				while (true)
				{
					num4++;
					num3 = FindWindowEx(num2, num3, text3, null);
					if (num3 == 0)
					{
						break;
					}
					if (num < 0 || num4 == num)
					{
						smethod_21(ref gstruct8_[gstruct8_.Length - 1].gstruct7_0, num3, num4);
						if (num > 0)
						{
							return gstruct8_;
						}
					}
					if (int_42 > 0)
					{
						Thread.Sleep(int_42);
					}
				}
				if (int_42 > 0)
				{
					Thread.Sleep(int_42);
				}
			}
			return gstruct8_;
		}
		return gstruct8_;
	}

	public static uint[] smethod_63(int int_41, string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		string text = string_0.ToUpper();
		uint num = 0u;
		uint[] array = null;
		int int_42 = 256;
		StringBuilder stringBuilder = new StringBuilder(256);
		while (int_41 > 0)
		{
			num = FindWindowEx(0u, num, text, null);
			if (num == 0)
			{
				break;
			}
			int int_43 = 0;
			GetWindowThreadProcessId(num, out int_43);
			if (int_43 != int_41)
			{
				continue;
			}
			int className = GetClassName(num, stringBuilder, int_42);
			if (className > 0 && !(stringBuilder.ToString().ToUpper() != text))
			{
				if (array != null)
				{
					Array.Resize(ref array, array.Length + 1);
				}
				else
				{
					array = new uint[1];
				}
				array[array.Length - 1] = num;
			}
		}
		return array;
	}

	public static uint[] smethod_64(int int_41, uint uint_11, string string_0, bool bool_0 = false)
	{
		int num = 0;
		uint[] array = null;
		while (!Class11.bool_0 && num < 20)
		{
			array = smethod_66(int_41, uint_11, string_0);
			if (array == null)
			{
				Thread.Sleep(300);
				num++;
				continue;
			}
			return array;
		}
		if (!bool_0)
		{
			Class11.smethod_29(ref Class11.string_17, "RVA không hợp lệ !");
		}
		return null;
	}

	public static uint[] smethod_65(int int_41, uint uint_11, int int_42 = 10)
	{
		uint[] array = new uint[int_42];
		uint num = smethod_30(uint_11 + 60, int_41);
		array[0] = smethod_30(uint_11 + num + 44, int_41);
		for (uint num2 = 1u; num2 < array.Length; num2++)
		{
			array[num2] = smethod_30(uint_11 + num + 256 + (num2 - 1) * 40, int_41);
		}
		return array;
	}

	public static uint[] smethod_66(int int_41, uint uint_11, string string_0 = null)
	{
		if (string_0 == null || string_0 == string.Empty)
		{
			string_0 = ".text";
		}
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		int int_42 = 0;
		byte[] array = new byte[2];
		ReadProcessMemory(int_41, uint_11 + 60, array, 2, ref int_42);
		uint num = (uint)BitConverter.ToInt16(array, 0);
		uint num2 = num;
		int num3 = bytes.Length;
		array = new byte[num3];
		while (true)
		{
			int_42 = 0;
			bool flag;
			if ((flag = ReadProcessMemory(int_41, uint_11 + num, array, num3, ref int_42)) && num <= 4095)
			{
				for (int i = 0; i < num3; i++)
				{
					if (array[i] != bytes[i])
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					break;
				}
				num++;
				continue;
			}
			if (!(string_0 == ".text"))
			{
				return new uint[2];
			}
			num = num2 + 248;
			break;
		}
		num += 8;
		int_42 = 0;
		array = new byte[4];
		ReadProcessMemory(int_41, uint_11 + num, array, 4, ref int_42);
		uint num4 = BitConverter.ToUInt32(array, 0);
		int_42 = 0;
		array = new byte[4];
		ReadProcessMemory(int_41, uint_11 + num + 4, array, 4, ref int_42);
		uint num5 = BitConverter.ToUInt32(array, 0);
		return new uint[2] { num4, num5 };
	}

	public static bool smethod_67(int int_41, string string_0)
	{
		int num = OpenProcess(2035711, bool_0: false, int_41);
		if (num != 0)
		{
			bool flag = false;
			uint num2 = 0u;
			uint procAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			if (procAddress != 0)
			{
				uint num3 = smethod_1(num, (uint)string_0.Length);
				if (num3 != 0)
				{
					byte[] bytes = Encoding.ASCII.GetBytes(string_0);
					int int_42 = 0;
					if (flag = WriteProcessMemory(num, num3, bytes, bytes.Length, ref int_42))
					{
						uint uint_ = 0u;
						num2 = CreateRemoteThread(num, IntPtr.Zero, 0u, procAddress, num3, 0u, out uint_);
					}
				}
			}
			smethod_32(num);
			return flag && num2 != 0;
		}
		return false;
	}

	public static int smethod_68(Process process_0, string string_0)
	{
		int num = 0;
		try
		{
			num = process_0.Id;
		}
		catch
		{
		}
		if (!smethod_52(process_0) && num != 0)
		{
			uint num2 = smethod_35(num, string_0);
			if (num2 == 0)
			{
				return -3;
			}
			int num3 = OpenProcess(2035711, bool_0: true, num);
			if (num3 == 0)
			{
				return -4;
			}
			uint[] array = smethod_66(num3, num2);
			uint num4 = array[0];
			uint num5 = num2 + 4096;
			uint num6 = num5 + num4;
			int num7 = 0;
			for (int i = 0; i < process_0.Threads.Count; i++)
			{
				uint num8 = smethod_70(process_0.Threads[i].Id);
				if (num8 > num5 && num8 < num6)
				{
					bool value = smethod_69((uint)process_0.Threads[i].Id);
					num7 += Convert.ToByte(value);
				}
			}
			smethod_32(num3);
			return num7;
		}
		return -2;
	}

	private static bool smethod_69(uint uint_11)
	{
		IntPtr intPtr = OpenThread(GEnum2.flag_0, bool_0: false, uint_11);
		if (!(intPtr == IntPtr.Zero))
		{
			return TerminateThread(intPtr, 0u);
		}
		return false;
	}

	private static uint smethod_70(int int_41)
	{
		int int_42 = 9;
		IntPtr intPtr = OpenThread(GEnum2.flag_5, bool_0: false, (uint)int_41);
		if (intPtr == IntPtr.Zero)
		{
			return 0u;
		}
		IntPtr intPtr2 = Marshal.AllocHGlobal(IntPtr.Size);
		try
		{
			if (NtQueryInformationThread(intPtr, int_42, intPtr2, IntPtr.Size, IntPtr.Zero) != 0)
			{
				return Convert.ToUInt32(-1);
			}
			return (uint)(int)Marshal.ReadIntPtr(intPtr2);
		}
		finally
		{
			CloseHandle(intPtr);
			Marshal.FreeHGlobal(intPtr2);
		}
	}

	public static void smethod_71(string string_0 = null, bool bool_0 = true)
	{
		try
		{
			if (string_0 == null)
			{
				Process currentProcess = Process.GetCurrentProcess();
				string_0 = currentProcess.MainModule.FileName.ToUpper();
			}
			string string_1 = "Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers";
			string text = "RUNASADMIN";
			string text2 = string.Empty;
			string text3 = Class66.smethod_2(string_1, string_0, 0);
			string text4 = Class66.smethod_2(string_1, string_0, 1);
			if (text3 != text4 && text4 != string.Empty)
			{
				text3 = text4;
			}
			if (text3 != string.Empty && text3 != null)
			{
				string[] array = text3.Split(' ');
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].ToUpper().IndexOf(text) < 0)
					{
						if (text2 != string.Empty)
						{
							text2 += " ";
						}
						text2 += array[i];
					}
				}
			}
			if (bool_0)
			{
				if (text2 != string.Empty)
				{
					text = text + " " + text2;
				}
			}
			else
			{
				text = text2;
			}
			Class66.smethod_11(string_1, string_0, text, "", 0);
			Class66.smethod_11(string_1, string_0, text, "", 1);
		}
		catch
		{
		}
	}

	public static void smethod_72()
	{
		string string_ = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Associations";
		string string_2 = "LowRiskFileTypes";
		Class66.smethod_11(string_, string_2, ".exe;.bat;.cmd;.vbs", "", 0);
		Class66.smethod_11(string_, string_2, ".exe;.bat;.cmd;.vbs", "", 1);
	}

	public static void smethod_73(string string_0, string string_1, string string_2 = null, int int_41 = 1)
	{
		Environment.SpecialFolder folder = Environment.SpecialFolder.DesktopDirectory;
		if (int_41 == 2)
		{
		}
		Interface0 @interface = (Interface0)new Class23();
		@interface.imethod_4("KYKeoxe, http://vltool.blogspot.com");
		@interface.imethod_17(string_1);
		if (string_2 == null)
		{
			string[] array = Class11.smethod_14(string_1);
			string_2 = array[0];
		}
		@interface.imethod_6(string_2);
		IPersistFile persistFile = (IPersistFile)@interface;
		string folderPath = Environment.GetFolderPath(folder);
		persistFile.Save(Path.Combine(folderPath, string_0 + ".lnk"), fRemember: false);
	}

	public static bool smethod_74(string string_0)
	{
		try
		{
			Process processById = Process.GetProcessById(smethod_56());
			smethod_73(string_0, processById.MainModule.FileName);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static string smethod_75()
	{
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			return currentProcess.MainModule.FileName.ToUpper();
		}
		catch
		{
		}
		return null;
	}

	public static void smethod_76(uint uint_11, int int_41)
	{
		short uint_12 = VkKeyScan(int_41);
		short num = (short)MapVirtualKey((uint)uint_12, 0u);
		uint uint_13 = (uint)((num << 16) | 1);
		PostMessageA_1(uint_11, int_28, (uint)int_41, uint_13);
	}

	public static Mutex smethod_77(ref bool bool_0, string string_0)
	{
		bool_0 = false;
		try
		{
			return new Mutex(initiallyOwned: true, string_0, out bool_0);
		}
		catch
		{
		}
		return null;
	}

	public static void smethod_78(Mutex mutex_0)
	{
		try
		{
			mutex_0.ReleaseMutex();
		}
		catch
		{
		}
	}
}
