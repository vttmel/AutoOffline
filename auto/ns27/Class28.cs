using System;
using System.Text;
using System.Threading;
using ns1;
using ns100;
using ns11;
using ns110;
using ns129;
using ns141;
using ns146;
using ns23;
using ns36;
using ns52;
using ns53;
using ns71;
using ns83;
using ns85;
using ns88;

namespace ns27;

internal class Class28
{
	private static uint uint_0 = 260u;

	private static uint uint_1 = 28u;

	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static uint uint_2 = 0u;

	public static long long_0 = 0L;

	public static string string_0 = null;

	public static int int_1 = 0;

	public static void smethod_0()
	{
		if (bool_0)
		{
			return;
		}
		bool_0 = true;
		if (FormDoiMauBang.gstruct2_0.characterAccountConfig_0.int_136 <= 0)
		{
			Class11.string_17 = new string[1] { "FORM:Tuyên chiến: Hãy chọn trước tên ac đổi màu ở phía trên." };
		}
		else if (FormTuyenchien.gstruct31_0 != null)
		{
			if (FormDoiMauBang.int_2 != FormDoiMauBang.gstruct2_0.characterAccountConfig_0.int_136 || FormDoiMauBang.gstruct2_0.int_3 <= 0)
			{
				FormDoiMauBang.gstruct2_0.int_3 = GClass1.smethod_5(FormDoiMauBang.gstruct2_0.characterAccountConfig_0);
				if (FormDoiMauBang.gstruct2_0.int_3 <= 0)
				{
					goto IL_0155;
				}
				FormDoiMauBang.int_2 = FormDoiMauBang.gstruct2_0.characterAccountConfig_0.int_136;
			}
			for (int i = 0; i < FormTuyenchien.gstruct31_0.Length; i++)
			{
				if (FormTuyenchien.gstruct31_0[i].int_0 > 0 && FormTuyenchien.gstruct31_0[i].string_0 != null && FormTuyenchien.gstruct31_0[i].string_0 != string.Empty)
				{
					smethod_2(FormDoiMauBang.gstruct2_0.characterAccountConfig_0, FormTuyenchien.gstruct31_0[i].string_0);
					Thread.Sleep(300);
				}
			}
		}
		else
		{
			Class11.string_17 = new string[1] { "FORM:Tuyên chiến: Hãy chọn tên Bang hội cần tuyên trong nút danh sách." };
		}
		goto IL_0155;
		IL_0155:
		bool_0 = false;
	}

	public static void smethod_1()
	{
		if (bool_0)
		{
			return;
		}
		bool_0 = true;
		if (FormDoiMauBang.gstruct2_0.characterAccountConfig_0.int_136 > 0 && FormTuyenchien.gstruct31_0 != null)
		{
			if (FormDoiMauBang.int_2 != FormDoiMauBang.gstruct2_0.characterAccountConfig_0.int_136 || FormDoiMauBang.gstruct2_0.int_3 <= 0)
			{
				FormDoiMauBang.gstruct2_0.int_3 = GClass1.smethod_5(FormDoiMauBang.gstruct2_0.characterAccountConfig_0);
				if (FormDoiMauBang.gstruct2_0.int_3 <= 0)
				{
					goto IL_0126;
				}
				FormDoiMauBang.int_2 = FormDoiMauBang.gstruct2_0.characterAccountConfig_0.int_136;
			}
			for (int i = 0; i < FormTuyenchien.gstruct31_0.Length; i++)
			{
				if (FormTuyenchien.gstruct31_0[i].int_0 > 0 && FormTuyenchien.gstruct31_0[i].string_0 != null && FormTuyenchien.gstruct31_0[i].string_0 != string.Empty)
				{
					smethod_2(FormDoiMauBang.gstruct2_0.characterAccountConfig_0, FormTuyenchien.gstruct31_0[i].string_0);
					Thread.Sleep(300);
				}
			}
		}
		goto IL_0126;
		IL_0126:
		bool_0 = false;
	}

	public static bool smethod_2(CharacterAccountConfig characterAccountConfig_0, object object_0)
	{
		if (Class75.smethod_18(characterAccountConfig_0, object_0))
		{
			int num = 0;
			while (num < 10)
			{
				num++;
				Thread.Sleep(100);
				if (0 <= Class95.smethod_0(characterAccountConfig_0))
				{
					Class95.smethod_6(characterAccountConfig_0, "X|c");
					break;
				}
			}
			num = 0;
			while (num < 10 && 0 <= Class95.smethod_0(characterAccountConfig_0))
			{
				num++;
				Thread.Sleep(100);
				Class95.smethod_5(characterAccountConfig_0, 0);
			}
			return true;
		}
		return false;
	}

	public static int smethod_3(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_86.uint_0 + characterAccountConfig_0.uint_7, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		uint num2 = num + Class56.memorySignatureScanConfig_205.uint_0 + Class56.memorySignatureScanConfig_87.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + uint_0 + 4, array, 4, ref int_);
		return BitConverter.ToInt32(array, 0);
	}

	public static string smethod_4(CharacterAccountConfig characterAccountConfig_0, uint uint_3)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_86.uint_0 + characterAccountConfig_0.uint_7, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		uint num2 = num + Class56.memorySignatureScanConfig_205.uint_0 + Class56.memorySignatureScanConfig_87.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + uint_0, array, 4, ref int_);
		uint num3 = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num3 + uint_3 * 4, array, 4, ref int_);
		uint num4 = BitConverter.ToUInt32(array, 0);
		byte[] array2 = new byte[12];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + uint_1, array2, array2.Length, ref int_);
		return Class1.smethod_3(array2);
	}

	public static string[] smethod_5(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		byte[] array2 = new byte[12];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_86.uint_0 + characterAccountConfig_0.uint_7, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		uint num2 = num + Class56.memorySignatureScanConfig_205.uint_0 + Class56.memorySignatureScanConfig_87.uint_0;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + uint_0 + 4, array, 4, ref int_);
		int num3 = BitConverter.ToInt32(array, 0);
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num2 + uint_0, array, 4, ref int_);
		uint num4 = BitConverter.ToUInt32(array, 0);
		string[] array3 = null;
		uint num5 = 0u;
		do
		{
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + num5 * 4, array, 4, ref int_);
			uint num6 = BitConverter.ToUInt32(array, 0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num6 + uint_1, array2, array2.Length, ref int_);
			string text = Class1.smethod_3(array2);
			if (text == string.Empty)
			{
				break;
			}
			if (array3 != null)
			{
				Array.Resize(ref array3, array3.Length + 1);
			}
			else
			{
				array3 = new string[1];
			}
			array3[array3.Length - 1] = text;
			num5++;
		}
		while (num5 < num3);
		return array3;
	}

	public static void smethod_6()
	{
		int int_ = int_0;
		uint num = Class28.uint_2;
		int int_2 = 0;
		byte[] array = new byte[4];
		byte[] array2 = Class11.smethod_47(string_0, bool_1: false);
		byte[] bytes = BitConverter.GetBytes(long_0);
		int_0 = 0;
		uint uint_ = num + Class75.uint_52 * 4;
		uint uint_2 = num + Class75.uint_52 * 4 + 1;
		uint uint_3 = num + Class75.uint_52 * 4 + 2;
		uint uint_4 = num + Class75.uint_52 * 4 + 12;
		Class24.ReadProcessMemory(int_, uint_, array, 1, ref int_2);
		int num2 = array[0];
		array[0] = (byte)array2.Length;
		Class24.WriteProcessMemory(int_, uint_2, array, 1, ref int_2);
		Class24.WriteProcessMemory(int_, uint_3, bytes, bytes.Length, ref int_2);
		Class24.WriteProcessMemory(int_, uint_4, array2, array2.Length, ref int_2);
		if (num2 > 0)
		{
			return;
		}
		array[0] = 1;
		Class24.WriteProcessMemory(int_, uint_, array, 1, ref int_2);
		Class24.ReadProcessMemory(int_, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_2);
		uint num3 = BitConverter.ToUInt32(array, 0);
		Class24.ReadProcessMemory(int_, num3 + Class56.memorySignatureScanConfig_13.uint_0, array, 4, ref int_2);
		uint num4 = BitConverter.ToUInt32(array, 0);
		uint num5 = num4 * Class56.memorySignatureScanConfig_15.uint_0;
		Class24.ReadProcessMemory(int_, Class56.memorySignatureScanConfig_14.uint_0, array, 4, ref int_2);
		uint num6 = BitConverter.ToUInt32(array, 0);
		uint num7 = num6 + num5;
		Class11.smethod_27();
		int num8 = 0;
		do
		{
			Class24.ReadProcessMemory(int_, uint_3, bytes, bytes.Length, ref int_2);
			long num9 = BitConverter.ToInt64(bytes, 0);
			if (DateTime.Now.Ticks > num9)
			{
				break;
			}
			Class24.ReadProcessMemory(int_, uint_2, array, 1, ref int_2);
			int num10 = array[0];
			if (num10 == 0)
			{
				break;
			}
			if (array2 == null || array2.Length != num10)
			{
				array2 = new byte[num10];
			}
			Class24.ReadProcessMemory(int_, uint_4, array2, num10, ref int_2);
			Class24.WriteProcessMemory(int_, num7 + Class56.memorySignatureScanConfig_251.uint_0, array2, num10, ref int_2);
			Thread.Sleep(80);
			num8++;
		}
		while (num8 < 1000);
		array[0] = 0;
		Class24.WriteProcessMemory(int_, uint_, array, 1, ref int_2);
	}

	public static string smethod_7(CharacterAccountConfig characterAccountConfig_0)
	{
		uint uint_ = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_189.uint_0;
		return Class24.smethod_28(uint_, characterAccountConfig_0.int_137);
	}

	public static byte[] smethod_8(CharacterAccountConfig characterAccountConfig_0, int int_2 = -1)
	{
		uint uint_ = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137) + Class56.memorySignatureScanConfig_189.uint_0;
		if (int_2 <= 0)
		{
			int_2 = 8;
		}
		int int_3 = 0;
		byte[] array = new byte[int_2];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, array.Length, ref int_3);
		return array;
	}

	public static uint smethod_9(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		uint num2 = num + Class56.memorySignatureScanConfig_189.uint_0;
		uint uint_ = num2 + 40;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 4, ref int_);
		return BitConverter.ToUInt32(array, 0);
	}

	public static string smethod_10(CharacterAccountConfig characterAccountConfig_0)
	{
		int int_ = 0;
		byte[] array = new byte[4];
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, Class56.memorySignatureScanConfig_11.uint_0, array, 4, ref int_);
		uint num = BitConverter.ToUInt32(array, 0);
		uint num2 = num + Class56.memorySignatureScanConfig_189.uint_0;
		uint uint_ = num2 + 60;
		return Class24.smethod_28(uint_, characterAccountConfig_0.int_137);
	}

	public static bool smethod_11(CharacterAccountConfig characterAccountConfig_0, uint uint_3)
	{
		if (characterAccountConfig_0.uint_17 != 0 && Class56.memorySignatureScanConfig_196.uint_0 != 0 && characterAccountConfig_0.uint_90 != 0)
		{
			if (!Class24.smethod_31(characterAccountConfig_0.uint_90 + 2, characterAccountConfig_0.int_137, uint_3))
			{
				return false;
			}
			return Class75.smethod_12(characterAccountConfig_0.int_137, characterAccountConfig_0.uint_90);
		}
		return false;
	}

	public static bool smethod_12(CharacterAccountConfig characterAccountConfig_0, string string_1 = null, uint uint_3 = 32769u, uint uint_4 = 4u, uint uint_5 = 0u)
	{
		if (characterAccountConfig_0.uint_94 != 0 && Class56.memorySignatureScanConfig_191.uint_0 != 0)
		{
			if (string_1 != null && string_1 != string.Empty)
			{
				return Class75.smethod_75(characterAccountConfig_0, string_1);
			}
			string_1 = smethod_10(characterAccountConfig_0);
			if (string_1 != null && string_1 != string.Empty)
			{
				return Class75.smethod_75(characterAccountConfig_0, string_1);
			}
			uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			Class24.smethod_30(num + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137);
			uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			int int_ = 0;
			uint num3 = 0u;
			byte[] array = new byte[15];
			while (true)
			{
				num3++;
				if (Class11.bool_0 || num3 > 255)
				{
					break;
				}
				uint num4 = num2 + num3 * Class56.memorySignatureScanConfig_15.uint_0;
				if (Class24.smethod_30(num4 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137) != 1)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_89.uint_0, array, 1, ref int_);
				if (array[0] == 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num4 + Class56.memorySignatureScanConfig_89.uint_0, array, array.Length, ref int_);
				string text = Class1.smethod_3(array);
				int_ = 3;
				int length = text.Length;
				while (int_ < length)
				{
					if (Class39.smethod_2(characterAccountConfig_0).IndexOf("- l·nh") <= 0)
					{
						int_++;
						text = Encoding.UTF7.GetString(array, 0, int_);
						if (Class75.smethod_75(characterAccountConfig_0, text, uint_3, uint_4, uint_5))
						{
							Thread.Sleep(300);
							string text2 = Class89.smethod_22(characterAccountConfig_0);
							if (text2 != null && text2.IndexOf("kh«ng tån t¹i") <= 0)
							{
								Class89.smethod_23(characterAccountConfig_0, "0K..");
								Thread.Sleep(300);
							}
							else
							{
								Class75.smethod_52(characterAccountConfig_0, ".");
							}
							continue;
						}
						return false;
					}
					return true;
				}
			}
			return false;
		}
		return false;
	}

	public static void smethod_13()
	{
		int int_ = int_1;
		int_1 = 0;
		bool flag = false;
		while (true)
		{
			try
			{
				int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
				if (Class11.bool_0 || num < 0 || !Form1.characterAccountConfig_1[num].bool_17)
				{
					if (0 <= num)
					{
						Form1.characterAccountConfig_1[num].bool_49 = false;
					}
					break;
				}
				if (!flag)
				{
					if (Form1.characterAccountConfig_1[num].bool_49)
					{
						break;
					}
					Form1.characterAccountConfig_1[num].bool_49 = true;
					flag = true;
				}
				smethod_14(int_);
			}
			catch
			{
			}
			Thread.Sleep(600);
		}
	}

	private static void smethod_14(int int_2)
	{
		CharacterAccountConfig characterAccountConfig = default(CharacterAccountConfig);
		int num = 0;
		int int_3 = 0;
		byte[] array = new byte[4];
		long long_ = 0L;
		long long_2 = 0L;
		bool flag = false;
		while (true)
		{
			Thread.Sleep(400);
			num--;
			if (Class11.bool_0)
			{
				break;
			}
			if (num <= 0)
			{
				num = 3;
				int num2 = Class87.smethod_3(Form1.characterAccountConfig_1, int_2);
				if (num2 < 0 || !Form1.characterAccountConfig_1[num2].bool_17)
				{
					break;
				}
				characterAccountConfig = Form1.characterAccountConfig_1[num2];
				if (Class11.smethod_28(long_) > 45000L)
				{
					Class75.smethod_52(characterAccountConfig, "<bclr=blue><color=green>Tù ®éng cho phÐp vµo bang khi cã ac xin gia nhËp bang héi.");
					long_ = Class11.smethod_27();
				}
				Class24.ReadProcessMemory(characterAccountConfig.int_137, Class56.memorySignatureScanConfig_165.uint_0, array, 4, ref int_3);
				uint num3 = BitConverter.ToUInt32(array, 0);
				if (num3 == 0)
				{
					continue;
				}
				Class24.ReadProcessMemory(characterAccountConfig.int_137, num3 + Class56.memorySignatureScanConfig_167.uint_0, array, 4, ref int_3);
				uint num4 = BitConverter.ToUInt32(array, 0);
				if (num4 == 0)
				{
					continue;
				}
				string empty = string.Empty;
				for (uint num5 = 0u; num5 < 9; num5++)
				{
					Class24.ReadProcessMemory(characterAccountConfig.int_137, num4 + num5 * 4, array, 4, ref int_3);
					uint num6 = BitConverter.ToUInt32(array, 0);
					if (num6 == 0)
					{
						continue;
					}
					empty = Class24.smethod_28(num6, characterAccountConfig.int_137, 45);
					if (empty == null || empty == string.Empty)
					{
						continue;
					}
					string text = empty.ToLower();
					if (text.IndexOf("p gia nh") <= 0 || text.IndexOf("p bang h") <= 0)
					{
						continue;
					}
					Class75.smethod_52(characterAccountConfig, "<bclr=blue><color=yellow>" + empty);
					Thread.Sleep(300);
					int num7;
					if (FormRaovat.string_0 != null)
					{
						num7 = 0;
						while (num7 < FormRaovat.string_0.Length)
						{
							if (0 > empty.IndexOf(FormRaovat.string_0[num7]))
							{
								num7++;
								continue;
							}
							goto IL_0209;
						}
					}
					Class75.smethod_16(characterAccountConfig, num6, 1);
					Thread.Sleep(1500);
					flag = true;
					continue;
					IL_0209:
					Class75.smethod_50(characterAccountConfig, FormRaovat.string_0[num7], "§i chç kh\u00b8c ch¬i cho tui mÇn viÖc !");
					Thread.Sleep(600);
					flag = true;
					break;
				}
				if (!flag && Class11.smethod_28(long_2) <= 45000L)
				{
					continue;
				}
				for (int i = 0; i < 10; i++)
				{
					if (Class55.smethod_2(characterAccountConfig) == string.Empty)
					{
						break;
					}
					Class75.smethod_12(characterAccountConfig.int_137, characterAccountConfig.uint_56);
					Thread.Sleep(150);
				}
				long_2 = Class11.smethod_27();
				flag = false;
			}
			else
			{
				Thread.Sleep(400);
			}
		}
	}
}
