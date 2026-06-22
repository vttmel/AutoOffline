using System;
using ns10;
using ns11;
using ns23;
using ns35;
using ns36;
using ns53;
using ns71;

namespace ns46;

internal class Class49
{
	private struct CharacterStatisticsData
	{
		public int characterCount;

		public int characterLevel;

		public string characterName;
	}

	public CharacterAccountConfig characterAccountConfig_0 = default(CharacterAccountConfig);

	public string string_0 = null;

	private bool method_0(string string_1, ref string string_2)
	{
		if (string_1 == string_2)
		{
			return true;
		}
		string text = "";
		for (int i = 0; i < string_1.Length && string_2.Length > i && string_1[i] == string_2[i]; i++)
		{
			text += string_1[i];
		}
		if (text.Length <= 4)
		{
			return false;
		}
		string_2 = text;
		return true;
	}

	private void method_1(int int_0, string string_1, ref CharacterStatisticsData[] characterStatisticsData_0)
	{
		CharacterStatisticsData characterStatisticsData = new CharacterStatisticsData
		{
			characterLevel = int_0,
			characterCount = 1,
			characterName = string_1
		};
		if (characterStatisticsData_0 != null && characterStatisticsData_0.Length != 0)
		{
			CharacterStatisticsData[] array = new CharacterStatisticsData[characterStatisticsData_0.Length + 1];
			int num = 0;
			while (true)
			{
				if (num < characterStatisticsData_0.Length)
				{
					if (int_0 == characterStatisticsData_0[num].characterLevel && method_0(string_1, ref characterStatisticsData_0[num].characterName))
					{
						break;
					}
					ref CharacterStatisticsData reference = ref array[num];
					reference = characterStatisticsData_0[num];
					num++;
					continue;
				}
				array[array.Length - 1] = characterStatisticsData;
				characterStatisticsData_0 = array;
				return;
			}
			characterStatisticsData_0[num].characterCount++;
		}
		else
		{
			characterStatisticsData_0 = new CharacterStatisticsData[1] { characterStatisticsData };
		}
	}

	public void method_2()
	{
		Class24.smethod_30(Class56.memorySignatureScanConfig_126.uint_0, characterAccountConfig_0.int_137);
		uint num = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
		int int_ = 0;
		byte[] array = new byte[4];
		uint uint_ = characterAccountConfig_0.uint_7 + Class56.memorySignatureScanConfig_9.uint_0 + Class56.memorySignatureScanConfig_10.uint_0 + 4;
		Class24.ReadProcessMemory(characterAccountConfig_0.int_137, uint_, array, 4, ref int_);
		int num2 = BitConverter.ToInt32(array, 0);
		CharacterStatisticsData[] characterStatisticsData_ = null;
		int[] array2 = new int[6];
		int num3 = 0;
		int num4 = 0;
		for (int i = 1; i < 256; i++)
		{
			if (num2 <= num4)
			{
				break;
			}
			uint num5 = num + (uint)(i * (int)Class56.memorySignatureScanConfig_15.uint_0);
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_16.uint_0, array, 4, ref int_);
			if (array[0] == 0)
			{
				continue;
			}
			num4++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_50.uint_0, array, 4, ref int_);
			if (BitConverter.ToInt32(array, 0) <= 0 || Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_52.uint_0, characterAccountConfig_0.int_137) != 1)
			{
				continue;
			}
			int num6 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_54.uint_0, characterAccountConfig_0.int_137);
			if (num6 > 4)
			{
				num6 = 5;
			}
			num3++;
			array2[num6]++;
			Class24.ReadProcessMemory(characterAccountConfig_0.int_137, num5 + Class56.memorySignatureScanConfig_88.uint_0, array, 4, ref int_);
			uint num7 = BitConverter.ToUInt32(array, 0);
			string text = Class24.smethod_28(num5 + Class56.memorySignatureScanConfig_89.uint_0, characterAccountConfig_0.int_137, 24);
			if (num7 != 0 && text != null && text != string.Empty)
			{
				string text2 = string.Empty;
				for (int j = 0; j < text.Length; j++)
				{
					text2 += text[j];
					if (Class11.smethod_6(text2) == num7)
					{
						text = text2;
						break;
					}
				}
			}
			method_1(num6, text, ref characterStatisticsData_);
		}
		if (characterStatisticsData_ == null)
		{
			return;
		}
		string text3 = "";
		uint[] array3 = Class38.smethod_30(characterAccountConfig_0);
		if (array3 != null)
		{
			object obj = text3;
			text3 = string.Concat(obj, " (", array3[0] / 256, ",", array3[1] / 512, ")");
		}
		string[] array4 = new string[6] { "Tr¾ng", "Vµng ", "TÝm  ", "Xanh ", "§á   ", "Kh\u00b8c " };
		string text4 = null;
		for (int k = 0; k < array2.Length; k++)
		{
			if (array2[k] > 0)
			{
				if (text4 != null)
				{
					text4 += ", ";
				}
				string text5 = "";
				string text6 = "";
				switch (k)
				{
				default:
					text5 = "<color=white>";
					text6 = "";
					break;
				case 0:
					text5 = "<color=white>";
					text6 = "";
					break;
				case 1:
					text5 = "<color=yellow>";
					text6 = "";
					break;
				case 2:
					text5 = "<color=violet>";
					text6 = "";
					break;
				case 3:
					text5 = "<color=green>";
					text6 = "";
					break;
				case 4:
					text5 = "<color=red>";
					text6 = "";
					break;
				case 5:
					text5 = "<color=orange>";
					text6 = "";
					break;
				}
				text4 = text4 + text5 + array4[k].Replace(" ", "") + ":" + array2[k] + text6;
			}
		}
		string[] array5 = new string[characterStatisticsData_.Length];
		if (characterStatisticsData_ != null)
		{
			for (int l = 0; l < characterStatisticsData_.Length; l++)
			{
				string text7 = "";
				string text8 = "";
				switch (characterStatisticsData_[l].characterLevel)
				{
				default:
					text7 = "<color=white>";
					text8 = "";
					break;
				case 0:
					text7 = "<color=white>";
					text8 = "";
					break;
				case 1:
					text7 = "<color=yellow>";
					text8 = "";
					break;
				case 2:
					text7 = "<color=violet>";
					text8 = "";
					break;
				case 3:
					text7 = "<color=green>";
					text8 = "";
					break;
				case 4:
					text7 = "<color=red>";
					text8 = "";
					break;
				case 5:
					text7 = "<color=orange>";
					text8 = "";
					break;
				}
				array5[l] = text7 + array4[characterStatisticsData_[l].characterLevel] + ": " + characterStatisticsData_[l].characterCount + ", " + characterStatisticsData_[l].characterName + text8;
			}
		}
		if (string_0 == null || string_0 == "")
		{
			Class75.smethod_57(characterAccountConfig_0, "ClearMessage()");
			Class75.smethod_52(characterAccountConfig_0, "-------------------------------------------");
			for (int m = 0; m < array5.Length; m++)
			{
				if (array5[m] != null)
				{
					Class75.smethod_52(characterAccountConfig_0, array5[m]);
				}
			}
			Class75.smethod_52(characterAccountConfig_0, "-------------------------------------------");
			Class75.smethod_52(characterAccountConfig_0, "<color=green>Map  : " + Class39.smethod_1(Class39.smethod_0(characterAccountConfig_0)) + text3);
			Class75.smethod_52(characterAccountConfig_0, "<color=yellow>Tæng : " + num3 + "<color=green> (" + text4 + ")");
			Class75.smethod_52(characterAccountConfig_0, "-------------------------------------------");
		}
		string_0 += "|CH_CHATROOM";
		string[] array6 = string_0.Split('|');
		if (array6.Length == 0)
		{
			return;
		}
		string text9 = "<color=cyan>Tæng:" + num3 + "</color> (" + text4 + "). <color=blue>B¶n ®å: " + Class39.smethod_1(Class39.smethod_0(characterAccountConfig_0)) + "</color>" + text3;
		for (int n = 0; n < array6.Length; n++)
		{
			if (array6[n] != "")
			{
				string text10 = "Chat('" + array6[n] + "', '" + text9 + "')";
				Class75.smethod_57(characterAccountConfig_0, text10);
			}
		}
	}

	private static string smethod_0(string string_1)
	{
		byte[,] array = new byte[7, 2];
		Class10.smethod_4(array, 512);
		byte[,] array2 = array;
		for (int i = 0; i < array2.GetLength(0); i++)
		{
			string_1 = string_1.Replace((char)array2[i, 0], (char)array2[i, 1]);
		}
		return string_1;
	}
}
