using System;
using System.IO;
using System.Reflection;
using System.Text;
using ns12;

namespace ns10;

internal class Class10
{
	internal static readonly byte[] byte_0;

	internal readonly int int_0;

	static Class10()
	{
		if (byte_0 == null)
		{
			string s = "S2VveGUzNjUuU2lnbg==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			byte_0 = Class12.smethod_3(97L, manifestResourceStream);
		}
	}

	internal static int smethod_0(int int_1)
	{
		return BitConverter.ToInt32(byte_0, int_1);
	}

	internal static long smethod_1(int int_1)
	{
		return BitConverter.ToInt64(byte_0, int_1);
	}

	internal static float smethod_2(int int_1)
	{
		return BitConverter.ToSingle(byte_0, int_1);
	}

	internal static double smethod_3(int int_1)
	{
		return BitConverter.ToDouble(byte_0, int_1);
	}

	internal static void smethod_4(Array array_0, int int_1)
	{
		int num = 0;
		if ((byte_0[int_1] & 0x80) == 0)
		{
			num = byte_0[int_1];
			int_1++;
		}
		else if ((byte_0[int_1] & 0x40) == 0)
		{
			num = (byte_0[int_1] & -129) << 8;
			num |= byte_0[int_1 + 1];
			int_1 += 2;
		}
		else
		{
			num = (byte_0[int_1] & -193) << 24;
			num |= byte_0[int_1 + 1] << 16;
			num |= byte_0[int_1 + 2] << 8;
			num |= byte_0[int_1 + 3];
			int_1 += 4;
		}
		if (num >= 1)
		{
			Buffer.BlockCopy(byte_0, int_1, array_0, 0, num);
		}
	}

	internal static string smethod_5(byte[] byte_1)
	{
		char[] array = new char[byte_1.Length / 2];
		Buffer.BlockCopy(byte_1, 0, array, 0, byte_1.Length);
		return new string(array);
	}
}
