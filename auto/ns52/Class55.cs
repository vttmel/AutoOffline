using System.Threading;
using ns23;
using ns53;
using ns71;

namespace ns52;

internal class Class55
{
	private static string[] string_0 = new string[2] { "mêi tæ ®éi", "giao dÞch" };

	public static void smethod_0(CharacterAccountConfig characterAccountConfig_0)
	{
		Class75.smethod_52(characterAccountConfig_0, "Xãa Sms...");
		for (int i = 0; i < 10; i++)
		{
			if (smethod_2(characterAccountConfig_0) == string.Empty)
			{
				break;
			}
			Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_56);
			Thread.Sleep(150);
		}
	}

	public static bool smethod_1(CharacterAccountConfig characterAccountConfig_0)
	{
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_165.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_168.uint_0, characterAccountConfig_0.int_137);
		return num2 != 0;
	}

	public static string smethod_2(CharacterAccountConfig characterAccountConfig_0, bool bool_0 = false)
	{
		string text = string.Empty;
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_165.uint_0, characterAccountConfig_0.int_137);
		uint num2 = Class24.smethod_30(num + Class56.memorySignatureScanConfig_167.uint_0, characterAccountConfig_0.int_137);
		if (num2 == 0)
		{
			return text;
		}
		for (uint num3 = 0u; num3 < 10; num3++)
		{
			uint num4 = Class24.smethod_30(num2 + num3 * 4, characterAccountConfig_0.int_137);
			if (num4 == 0)
			{
				continue;
			}
			string text2 = Class24.smethod_28(num4, characterAccountConfig_0.int_137, 78);
			if (text2 == null || text2 == string.Empty)
			{
				continue;
			}
			if (bool_0)
			{
				int num5 = (int)Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_170.uint_0, characterAccountConfig_0.int_137);
				if (num5 <= 0)
				{
					continue;
				}
				text2 = num5 + ";" + text2;
			}
			if (text != string.Empty)
			{
				text += "|";
			}
			text += text2;
		}
		return text;
	}
}
