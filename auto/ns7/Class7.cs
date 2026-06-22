using System;
using System.Diagnostics;
using System.Threading;
using ns11;
using ns23;
using ns53;

namespace ns7;

internal class Class7
{
	public static int smethod_0(string string_0, string string_1, ref byte[] byte_0, ref uint[] uint_0, ref uint uint_1, string string_2, ref byte[] byte_1, ref uint[] uint_2, ref uint uint_3, string string_3, ref byte[] byte_2, ref uint[] uint_4, ref uint uint_5, string string_4)
	{
		uint_0 = null;
		uint_2 = null;
		uint_4 = null;
		byte_0 = null;
		byte_1 = null;
		byte_2 = null;
		if (string_2 == null || string_2 == string.Empty)
		{
			string_2 = ".text";
		}
		if (string_3 == null || string_3 == string.Empty)
		{
			string_3 = ".text";
		}
		if (string_4 == null || string_4 == string.Empty)
		{
			string_4 = ".text";
		}
		int[] array = Class24.smethod_24(string_0, string_1);
		if (array == null)
		{
			return -1;
		}
		Process process = null;
		int num = 0;
		long num2 = 0L;
		for (int i = 0; i < array.Length; i++)
		{
			try
			{
				Process processById = Process.GetProcessById(array[i]);
				if (num2 < processById.StartTime.Ticks)
				{
					process = processById;
					num = array[i];
					num2 = processById.StartTime.Ticks;
				}
			}
			catch
			{
			}
		}
		int num5;
		if (process != null && !Class24.smethod_52(process))
		{
			long num3 = 0L;
			uint num4 = 0u;
			num5 = Class24.OpenProcess(2035711, bool_0: false, num);
			int int_ = 0;
			while (!Class11.bool_0)
			{
				try
				{
					num4 = (uint)(int)process.MainModule.EntryPointAddress;
					uint_3 = Class24.smethod_37(num, "engine.dll");
					uint_5 = Class24.smethod_37(num, "lualibdll.dll");
					uint_1 = (uint)(int)process.MainModule.BaseAddress;
					if (uint_1 != 0 && num4 != 0 && uint_3 != 0 && uint_5 != 0)
					{
						break;
					}
				}
				catch
				{
				}
				num3++;
				if (num3 <= 3000L)
				{
					Class24.smethod_45(process);
					Thread.Sleep(1);
					Class24.smethod_43(process);
					continue;
				}
				return -2;
			}
			uint_0 = Class24.smethod_66(num5, uint_1, string_2);
			if (uint_0 == null || uint_0[0] == 0 || uint_0[1] == 0)
			{
				uint[] array2 = Class24.smethod_65(num5, uint_1);
				if (array2 == null || array2[0] == 0 || array2[1] == 0)
				{
					goto IL_0599;
				}
				uint_0 = new uint[2]
				{
					array2[1],
					4096u
				};
			}
			uint_2 = Class24.smethod_66(num5, uint_3, string_3);
			if (uint_2 == null)
			{
				uint[] array3 = Class24.smethod_65(num5, uint_3);
				if (array3 == null || array3[0] == 0 || array3[1] == 0)
				{
					goto IL_0599;
				}
				uint_2 = new uint[2]
				{
					array3[1],
					4096u
				};
			}
			uint_4 = Class24.smethod_66(num5, uint_5, string_4);
			if (uint_4 == null)
			{
				uint[] array4 = Class24.smethod_65(num5, uint_5);
				if (array4 == null || array4[0] == 0 || array4[1] == 0)
				{
					goto IL_0599;
				}
				uint_4 = new uint[2]
				{
					array4[1],
					4096u
				};
			}
			byte_0 = new byte[uint_0[0]];
			if (uint_0[0] < int.MaxValue)
			{
				if (!Class24.ReadProcessMemory(num5, uint_1 + uint_0[1], byte_0, byte_0.Length, ref int_))
				{
					byte_0 = null;
					goto IL_0599;
				}
			}
			else
			{
				num3 = 0L;
				while (num3 < uint_0[0])
				{
					int num6 = int.MaxValue;
					if (num3 + 2147483647L > uint_0[0])
					{
						num6 = (int)(uint_0[1] - num3);
					}
					byte[] array5 = new byte[num6];
					bool flag = Class24.ReadProcessMemory(num5, (uint)(uint_1 + uint_0[1] + num3), array5, num6, ref int_);
					for (int j = 0; j < num6; j++)
					{
						byte_0[j + num3] = array5[j];
					}
					num3 += num6;
					if (flag)
					{
						continue;
					}
					goto IL_0596;
				}
			}
			byte_1 = new byte[uint_2[0]];
			if (uint_2[0] >= int.MaxValue)
			{
				num3 = 0L;
				while (num3 < uint_2[0])
				{
					int num7 = int.MaxValue;
					if (num3 + 2147483647L > uint_2[0])
					{
						num7 = (int)(uint_2[1] - num3);
					}
					byte[] array6 = new byte[num7];
					int int_2 = 0;
					bool flag2 = Class24.ReadProcessMemory(num5, (uint)(uint_3 + uint_2[1] + num3), array6, num7, ref int_2);
					for (int k = 0; k < num7; k++)
					{
						byte_1[k + num3] = array6[k];
					}
					num3 += num7;
					if (flag2)
					{
						continue;
					}
					goto IL_0463;
				}
			}
			else
			{
				int int_3 = 0;
				if (!Class24.ReadProcessMemory(num5, uint_3 + uint_2[1], byte_1, byte_1.Length, ref int_3))
				{
					uint_2 = null;
					byte_1 = null;
				}
			}
			byte_2 = new byte[uint_4[0]];
			if (uint_4[0] >= int.MaxValue)
			{
				num3 = 0L;
				while (num3 < uint_4[0])
				{
					int num8 = int.MaxValue;
					if (num3 + 2147483647L > uint_4[0])
					{
						num8 = (int)(uint_4[1] - num3);
					}
					byte[] array7 = new byte[num8];
					int int_4 = 0;
					bool flag3 = Class24.ReadProcessMemory(num5, (uint)(uint_3 + uint_4[1] + num3), array7, num8, ref int_4);
					for (int l = 0; l < num8; l++)
					{
						byte_2[l + num3] = array7[l];
					}
					num3 += num8;
					if (!flag3)
					{
						uint_4 = null;
						byte_2 = null;
						break;
					}
				}
			}
			else
			{
				int int_5 = 0;
				if (!Class24.ReadProcessMemory(num5, uint_5 + uint_4[1], byte_2, byte_2.Length, ref int_5))
				{
					uint_4 = null;
					byte_2 = null;
				}
			}
			goto IL_0599;
		}
		return -1;
		IL_0463:
		uint_2 = null;
		byte_1 = null;
		goto IL_0599;
		IL_0599:
		bool value = byte_0 != null && byte_1 != null && uint_0 != null && uint_2 != null && uint_0[1] != 0 && uint_2[1] != 0;
		return num5 * Convert.ToByte(value);
		IL_0596:
		byte_0 = null;
		goto IL_0599;
	}

	public static bool smethod_1(ref MemorySignatureScanConfig memorySignatureScanConfig_0, string[,] string_0)
	{
		string text = Class11.smethod_6(memorySignatureScanConfig_0.string_0).ToString();
		if (string_0 != null)
		{
			for (int i = 0; i < string_0.GetLength(0); i++)
			{
				if (string_0[i, 0] == text)
				{
					memorySignatureScanConfig_0.uint_0 = Class11.smethod_12(string_0[i, 1]);
					return true;
				}
			}
		}
		return false;
	}

	private static string smethod_2(string[] string_0, string string_1, string string_2 = "", bool bool_0 = true)
	{
		string_1 = "[" + string_1 + "]";
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (Class11.smethod_1(string_0[num], string_1) >= 0)
				{
					break;
				}
				num++;
				continue;
			}
			return string_2;
		}
		string_2 = string_0[num].Replace(string_1, "").Trim();
		if (bool_0)
		{
			string_2.Replace(" ", "");
		}
		return string_2;
	}

	private static bool smethod_3(ref MemorySignatureScanConfig memorySignatureScanConfig_0, MemorySignatureScanConfig[] memorySignatureScanConfig_1)
	{
		if (memorySignatureScanConfig_1 == null)
		{
			return false;
		}
		string text = memorySignatureScanConfig_0.string_0.ToUpper();
		for (int i = 0; i < memorySignatureScanConfig_1.GetLength(0); i++)
		{
			if (memorySignatureScanConfig_1[i].string_0 == text)
			{
				memorySignatureScanConfig_0.int_7 = memorySignatureScanConfig_1[i].int_7;
				memorySignatureScanConfig_0.int_8 = memorySignatureScanConfig_1[i].int_8;
				memorySignatureScanConfig_0.int_0 = memorySignatureScanConfig_1[i].int_0;
				memorySignatureScanConfig_0.int_4 = memorySignatureScanConfig_1[i].int_4;
				memorySignatureScanConfig_0.int_2 = memorySignatureScanConfig_1[i].int_2;
				memorySignatureScanConfig_0.string_1 = memorySignatureScanConfig_1[i].string_1;
				memorySignatureScanConfig_0.int_1 = memorySignatureScanConfig_1[i].int_1;
				memorySignatureScanConfig_0.int_5 = memorySignatureScanConfig_1[i].int_5;
				memorySignatureScanConfig_0.int_3 = memorySignatureScanConfig_1[i].int_3;
				memorySignatureScanConfig_0.string_2 = memorySignatureScanConfig_1[i].string_2;
				return true;
			}
		}
		return false;
	}

	public static long smethod_4(uint uint_0, byte[] byte_0, ref MemorySignatureScanConfig memorySignatureScanConfig_0, long long_0 = 0L, uint uint_1 = 0u, int int_0 = 0, bool bool_0 = false)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		long result = 0L;
		byte[] array = null;
		memorySignatureScanConfig_0.uint_0 = 0u;
		while (true)
		{
			if (long_0 < 0L)
			{
				long_0 = 0L;
			}
			long num5 = long_0;
			if (num != 0)
			{
				if (memorySignatureScanConfig_0.string_2 == null || memorySignatureScanConfig_0.string_2.Length == 0)
				{
					smethod_3(ref memorySignatureScanConfig_0, Class56.memorySignatureScanConfig_0);
				}
				array = Class11.smethod_8(memorySignatureScanConfig_0.string_2);
				num2 = memorySignatureScanConfig_0.int_1;
				num3 = memorySignatureScanConfig_0.int_3;
				num4 = memorySignatureScanConfig_0.int_5;
			}
			else
			{
				if (memorySignatureScanConfig_0.string_1 == null || memorySignatureScanConfig_0.string_1.Length == 0)
				{
					smethod_3(ref memorySignatureScanConfig_0, Class56.memorySignatureScanConfig_0);
				}
				array = Class11.smethod_8(memorySignatureScanConfig_0.string_1);
				num2 = memorySignatureScanConfig_0.int_0;
				num3 = memorySignatureScanConfig_0.int_2;
				num4 = memorySignatureScanConfig_0.int_4;
			}
			memorySignatureScanConfig_0.uint_0 = 0u;
			memorySignatureScanConfig_0.byte_2 = null;
			memorySignatureScanConfig_0.uint_2 = uint_0;
			if (byte_0 == null || array == null)
			{
				break;
			}
			int num6 = array.Length;
			long num7 = byte_0.Length;
			int num8 = 0;
			if (memorySignatureScanConfig_0.int_7 > 0 && uint_1 == 0)
			{
				uint_1 = 4194304u;
			}
			while (true)
			{
				int num9 = 0;
				while (num9 < num6)
				{
					byte b = byte_0[num5 + num9];
					if (array[num9] == 63 || array[num9] == b)
					{
						num9++;
						continue;
					}
					goto IL_0145;
				}
				num8++;
				if (num8 >= num2)
				{
					break;
				}
				goto IL_0145;
				IL_0145:
				num5++;
				if (num5 + num6 < num7)
				{
					continue;
				}
				goto IL_0164;
			}
			if (num4 > 0)
			{
				byte[] array2 = new byte[num4];
				for (int i = 0; i < num4; i++)
				{
					array2[i] = byte_0[num3 + num5 + i];
				}
				if (array2.Length < 4)
				{
					byte[] array3 = new byte[4];
					for (int j = 0; j < array2.Length; j++)
					{
						array3[j] = array2[j];
					}
					array2 = array3;
				}
				memorySignatureScanConfig_0.uint_0 = BitConverter.ToUInt32(array2, 0);
				if (memorySignatureScanConfig_0.int_7 > 0)
				{
					if (memorySignatureScanConfig_0.int_6 > 0 && int_0 > 0)
					{
						memorySignatureScanConfig_0.uint_0 = Class24.smethod_30(memorySignatureScanConfig_0.uint_0, int_0);
					}
					memorySignatureScanConfig_0.uint_0 -= uint_1;
				}
				if (memorySignatureScanConfig_0.int_8 > 0)
				{
					uint num10 = (uint)(num5 + num3 + memorySignatureScanConfig_0.uint_2);
					memorySignatureScanConfig_0.uint_0 += num10 + 4;
				}
			}
			else
			{
				memorySignatureScanConfig_0.uint_0 = (uint)(num3 + num5 + memorySignatureScanConfig_0.uint_2);
				if (memorySignatureScanConfig_0.int_7 > 0 && uint_1 < memorySignatureScanConfig_0.uint_0)
				{
					memorySignatureScanConfig_0.uint_0 -= uint_1;
				}
			}
			if (memorySignatureScanConfig_0.int_12 > 0)
			{
				memorySignatureScanConfig_0.byte_2 = new byte[memorySignatureScanConfig_0.int_12];
				for (int k = 0; k < memorySignatureScanConfig_0.int_12; k++)
				{
					memorySignatureScanConfig_0.byte_2[k] = byte_0[num5 + k + num3 + memorySignatureScanConfig_0.int_11];
				}
			}
			if (memorySignatureScanConfig_0.byte_1 != null && memorySignatureScanConfig_0.byte_1[0] == 0)
			{
				byte b2 = 1;
				for (int l = 0; l < memorySignatureScanConfig_0.byte_1.Length - 1; l++)
				{
					byte b3 = byte_0[num5 + l + num3 + memorySignatureScanConfig_0.int_11];
					if (memorySignatureScanConfig_0.byte_1[l + 1] != 63)
					{
						if (memorySignatureScanConfig_0.byte_1[l + 1] != b3)
						{
							b2 = 0;
							break;
						}
					}
					else
					{
						memorySignatureScanConfig_0.byte_1[l + 1] = b3;
					}
				}
				memorySignatureScanConfig_0.byte_1[0] = b2;
			}
			result = num5;
			break;
			IL_0164:
			if (num != 0)
			{
				break;
			}
			num++;
		}
		if (!bool_0)
		{
			if (Class56.gstruct52_0 == null)
			{
				Class56.gstruct52_0 = new GStruct52[1];
				Class56.gstruct52_0[0].string_1 = "Stt|Name\t\t|flgTruBaseAddr|flgGetCall|FindCount|GetPtr|DeltaSize|ByteSearch|FindCount2|GetPtr2|DeltaSize2|ByteSearch2";
			}
			Array.Resize(ref Class56.gstruct52_0, Class56.gstruct52_0.Length + 1);
			int num11 = memorySignatureScanConfig_0.int_2;
			string text = string.Empty;
			string text2 = string.Empty;
			if (num11 < 0)
			{
				text = "-";
				num11 = Math.Abs(num11);
			}
			text += Class11.smethod_46(num11, 2, bool_1: false);
			num11 = memorySignatureScanConfig_0.int_3;
			if (num11 < 0)
			{
				text2 = "-";
				num11 = Math.Abs(num11);
			}
			text2 += Class11.smethod_46(num11, 2, bool_1: false);
			Class56.gstruct52_0[Class56.gstruct52_0.Length - 1].string_0 = memorySignatureScanConfig_0.string_0;
			Class56.gstruct52_0[Class56.gstruct52_0.Length - 1].uint_0 = memorySignatureScanConfig_0.uint_0;
			Class56.gstruct52_0[Class56.gstruct52_0.Length - 1].string_1 = Class56.gstruct52_0.Length + "|" + memorySignatureScanConfig_0.string_0 + "\t\t|" + Class11.smethod_46(memorySignatureScanConfig_0.int_7, 2, bool_1: false) + "|" + Class11.smethod_46(memorySignatureScanConfig_0.int_8, 2, bool_1: false) + "|" + Class11.smethod_46(memorySignatureScanConfig_0.int_0, 2, bool_1: false) + "|" + Class11.smethod_46(memorySignatureScanConfig_0.int_4, 2, bool_1: false) + "|" + text + "|" + memorySignatureScanConfig_0.string_1 + "|" + Class11.smethod_46(memorySignatureScanConfig_0.int_1, 2, bool_1: false) + "|" + Class11.smethod_46(memorySignatureScanConfig_0.int_5, 2, bool_1: false) + "|" + text2 + "|" + memorySignatureScanConfig_0.string_2;
			return result;
		}
		return result;
	}

	private static string smethod_5(string string_0, int int_0, int int_1, int int_2)
	{
		if (!(string_0 == ""))
		{
			char[] array = string_0.ToCharArray();
			string_0 = "";
			for (int i = 0; i < array.Length; i++)
			{
				int num = i % int_2 + int_1;
				string_0 += (char)((byte)array[i] + int_0 * num);
			}
			return string_0;
		}
		return "";
	}
}
