using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using ns100;
using ns11;
using ns110;
using ns121;
using ns141;
using ns145;
using ns146;
using ns150;
using ns23;
using ns27;
using ns29;
using ns30;
using ns36;
using ns48;
using ns52;
using ns53;
using ns68;
using ns71;
using ns85;
using ns9;

namespace ns77;

internal class Class81
{
	public static CharacterAccountConfig characterAccountConfig_0 = new CharacterAccountConfig
	{
		int_136 = 0
	};

	public static CharacterAccountConfig characterAccountConfig_1 = new CharacterAccountConfig
	{
		int_136 = 0
	};

	public static int int_0 = 0;

	public static int int_1 = 0;

	public static int int_2 = 0;

	public static int int_3 = 0;

	public static int int_4 = 0;

	public static bool bool_0 = false;

	public static bool bool_1 = false;

	public static long long_0 = 0L;

	public static void smethod_0()
	{
		Process currentProcess = Process.GetCurrentProcess();
		byte[] array = new byte[8];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = 8;
		}
		int int_ = Class24.OpenProcess(2035711, bool_0: false, currentProcess.Id);
		uint num = Class24.smethod_1(int_, 4096u);
		string s = Class11.smethod_54(string.Concat(Class11.char_8));
		string password = ".";
		int num2 = 0;
		int int_2 = 0;
		while (true)
		{
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, array);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
				using MemoryStream stream = new MemoryStream(Convert.FromBase64String(s));
				using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
				using StreamReader streamReader = new StreamReader(stream2);
				byte[] array2 = Convert.FromBase64String(streamReader.ReadToEnd());
				string string_ = Encoding.UTF8.GetString(array2, 0, array2.Length);
				byte[] array3 = Class11.smethod_48(string_, bool_1: false);
				byte[] bytes = BitConverter.GetBytes(array3.Length);
				Class24.WriteProcessMemory(int_, num + 768, bytes, 4, ref int_2);
				Class24.WriteProcessMemory(int_, num + 768 + 4, array3, array3.Length, ref int_2);
			}
			catch
			{
				if (num2 < 3)
				{
					Thread.Sleep(978);
					num2++;
					continue;
				}
			}
			break;
		}
		Class11.uint_1 = Class24.smethod_1(int_);
		Class11.uint_0 = num;
		Class11.int_1 = int_;
		while (true)
		{
			try
			{
				smethod_2();
				break;
			}
			catch
			{
				Thread.Sleep(300);
			}
		}
	}

	private static CharacterAccountConfig smethod_1()
	{
		if (Form1.characterAccountConfig_1 != null)
		{
			int int_ = 0;
			uint foregroundWindow = Class24.GetForegroundWindow();
			Class24.GetWindowThreadProcessId(foregroundWindow, out int_);
			if (int_ > 0)
			{
				if (int_0 == int_ && int_0 == characterAccountConfig_0.int_136)
				{
					return characterAccountConfig_0;
				}
				try
				{
					for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
					{
						if (int_ == Form1.characterAccountConfig_1[i].int_136)
						{
							int_0 = int_;
							return Form1.characterAccountConfig_1[i];
						}
					}
				}
				catch
				{
				}
			}
		}
		int_0 = 0;
		return characterAccountConfig_1;
	}

	public static void smethod_2()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int int_ = 0;
		byte[] array = new byte[2];
		long long_ = Class11.smethod_27();
		Random random = new Random();
		TryNewVersion.int_1 = random.Next(8, 20) * 60 * 1000;
		FormTuyenchien.gstruct31_0 = FormTuyenchien.smethod_0();
		while (true)
		{
			Thread.Sleep(100);
			if (Class11.bool_0)
			{
				break;
			}
			if (!GClass1.bool_0)
			{
				continue;
			}
			num++;
			num5--;
			if (num > 5)
			{
				characterAccountConfig_0 = smethod_1();
				num4++;
				num = 0;
			}
			if (num4 > 100)
			{
				num4 = 0;
				bool flag = true;
				if (Form1.int_122 > 0 && Form1.characterAccountConfig_1 != null)
				{
					for (int i = 0; i < Form1.characterAccountConfig_1.Length; i++)
					{
						int num6 = Class39.smethod_0(Form1.characterAccountConfig_1[i]);
						if ((463 < num6 && num6 < 472) || (479 < num6 && num6 < 496))
						{
							flag = false;
							break;
						}
					}
				}
				if (flag)
				{
					Class72.int_0 = null;
					Class72.gstruct26_0 = null;
				}
				if (Class11.smethod_28(long_) > TryNewVersion.int_1)
				{
					long_ = Class11.smethod_27();
					new Thread(TryNewVersion.smethod_3).Start();
				}
			}
			int num8;
			int num7;
			if (!AuxiliaryMachineManager.bool_1 && Form1.characterAccountConfig_1 != null && GClass1.gstruct16_0 != null && Class11.smethod_28(long_0) > 90000L)
			{
				int[] array2 = new int[Form1.characterAccountConfig_1.Length];
				for (int j = 0; j < Form1.characterAccountConfig_1.Length; j++)
				{
					array2[j] = Form1.characterAccountConfig_1[j].int_136;
				}
				num7 = 0;
				TcpConnectionEntry[] array3 = Class51.smethod_0(array2);
				if (array3 != null)
				{
					for (int k = 0; k < array3.Length; k++)
					{
						num8 = 0;
						while (num8 < GClass1.gstruct16_0.Length)
						{
							bool flag2 = GClass1.gstruct16_0[num8].uint_0 == array3[k].uint_0;
							bool flag3 = GClass1.gstruct16_0[num8].long_0 > GClass1.long_1;
							if ((!flag2 || !flag3) && (Class9.string_1.Length > GClass1.int_1 || (ulong)GClass1.long_0 > 0uL))
							{
								num8++;
								continue;
							}
							goto IL_025d;
						}
					}
				}
				else if (GClass1.gstruct15_0.bool_0 && GClass1.gstruct15_0.uint_1 != null && (!Class31.bool_0 || Class11.long_0 < GClass1.long_1))
				{
					for (num8 = 0; num8 < GClass1.gstruct16_0.Length; num8++)
					{
						if (GClass1.gstruct16_0[num8].long_0 <= GClass1.long_1)
						{
							continue;
						}
						int num9 = 0;
						while (num9 < GClass1.gstruct15_0.uint_1.Length)
						{
							if (GClass1.gstruct16_0[num8].uint_0 != GClass1.gstruct15_0.uint_1[num9])
							{
								num9++;
								continue;
							}
							goto IL_0318;
						}
					}
				}
				goto IL_04a1;
			}
			goto IL_04ab;
			IL_025d:
			num7 = num8;
			goto IL_031c;
			IL_04ab:
			if (AuxiliaryMachineManager.bool_1)
			{
				Form1.int_10 = 0;
				Form1.int_11 = 0;
			}
			if (num5 <= 0 && Class11.int_1 > 0 && Class11.uint_1 != 0)
			{
				string text = Environment.GetEnvironmentVariable(Class11.smethod_0(Class56.char_0)) + "\\" + Class11.smethod_54(string.Concat(Class56.char_1));
				string[] array4 = new string[2] { "ᓕᓜᓠᓡ", "ᓚᓡᓥᓦᓥᒠᓛᓕᓥ" };
				array[0] = 0;
				for (int l = 0; l < array4.Length; l++)
				{
					try
					{
						string text2 = Class11.smethod_33(text + "\\" + Class11.smethod_54(array4[l]), 0, 0, 1);
						if (text2 == null || text2 == string.Empty)
						{
							continue;
						}
						string[] array5 = text2.Split('\r', '\n');
						for (int m = 0; m < array5.Length; m++)
						{
							if (array5[m] == null || array5[m] == string.Empty)
							{
								continue;
							}
							string[] array6 = array5[m].Split(' ', '\t');
							for (int n = 0; n < array6.Length; n++)
							{
								if (array6[n] == null || array6[n] == string.Empty)
								{
									continue;
								}
								uint num10 = Class11.smethod_6(array6[n].ToLower());
								int num11 = 0;
								while (num11 < Class56.uint_6.Length)
								{
									if (num10 != Class56.uint_6[num11])
									{
										num11++;
										continue;
									}
									goto IL_0645;
								}
							}
							continue;
							IL_0645:
							array[0] = 1;
							Class24.WriteProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_2 * 4, array, 1, ref int_);
							break;
						}
						if (array[0] > 0)
						{
							for (int num12 = 0; num12 < array4.Length; num12++)
							{
								Class11.smethod_20(text + "\\" + Class11.smethod_54(array4[num12]));
							}
							break;
						}
					}
					catch
					{
					}
				}
				num5 = 1800;
			}
			if (FormTuyenchien.bool_1 && FormDoiMauBang.gstruct2_0.characterAccountConfig_0.int_136 > 0 && FormTuyenchien.gstruct31_0 != null)
			{
				long num13 = Class11.smethod_28(FormTuyenchien.long_0);
				if (num13 > 840000L)
				{
					FormTuyenchien.long_0 = Class11.smethod_27();
					new Thread(Class28.smethod_1).Start();
				}
			}
			if (characterAccountConfig_0.int_136 > 0)
			{
				if (!bool_0)
				{
					num2--;
					if (Form1.int_69 > 0 && num2 <= 0)
					{
						num2 = 3;
						int_3 = Class89.smethod_3(characterAccountConfig_0);
						if (num3 != characterAccountConfig_0.int_136)
						{
							num3 = characterAccountConfig_0.int_136;
							GClass0.int_2 = int_3;
						}
						if (GClass0.intptr_0 == IntPtr.Zero || int_3 - GClass0.int_2 > 120)
						{
							GClass0.int_2 = int_3;
							bool_0 = true;
							num2 = 12;
						}
					}
				}
				if (int_2 > 0)
				{
					try
					{
						if (Form1.characterAccountConfig_1 != null)
						{
							for (int num14 = 0; num14 < Form1.characterAccountConfig_1.Length; num14++)
							{
								Form1.characterAccountConfig_1[num14].int_76[4] = int_2;
							}
						}
					}
					catch
					{
					}
				}
				if (int_1 != 1)
				{
					if (int_1 == 2)
					{
						Class75.smethod_106(characterAccountConfig_0, 18u);
					}
					else if (int_1 != 3)
					{
						if (int_1 != 5)
						{
							if (int_1 == 6)
							{
								Class75.smethod_2(characterAccountConfig_0, Class75.uint_50, 2, 4);
								try
								{
									if (Form1.characterAccountConfig_1 != null)
									{
										for (int num15 = 0; num15 < Form1.characterAccountConfig_1.Length; num15++)
										{
											if (Form1.characterAccountConfig_1[num15].int_136 != characterAccountConfig_0.int_136)
											{
												Class75.smethod_2(Form1.characterAccountConfig_1[num15], Class75.uint_50, 3, 4);
											}
										}
									}
								}
								catch
								{
								}
							}
							else if (int_1 == 7)
							{
								try
								{
									for (int num16 = 0; num16 < Form1.characterAccountConfig_1.Length; num16++)
									{
										if (Form1.characterAccountConfig_1[num16].bool_25 && Form1.characterAccountConfig_1[num16].int_131[0] > 0)
										{
											Class75.smethod_2(Form1.characterAccountConfig_1[num16], Class75.uint_31, 1, 4);
										}
									}
								}
								catch
								{
								}
							}
						}
						else
						{
							Class75.smethod_2(characterAccountConfig_0, Class75.uint_50, 1, 4);
						}
					}
					else
					{
						Class55.smethod_0(characterAccountConfig_0);
					}
				}
				else
				{
					Class75.smethod_106(characterAccountConfig_0, 34u);
				}
				if (GClass0.int_1 == Class30.int_5 || bool_1)
				{
					if (!bool_1)
					{
						GClass0.int_1 = 0;
					}
					try
					{
						for (int num17 = 0; num17 < Form1.characterAccountConfig_1.Length; num17++)
						{
							if (Form1.characterAccountConfig_1[num17].bool_25)
							{
								Class75.smethod_2(Form1.characterAccountConfig_1[num17], Class75.uint_30, 1, 4);
							}
						}
					}
					catch
					{
					}
				}
			}
			int_1 = 0;
			int_2 = 0;
			bool_1 = false;
			continue;
			IL_04a1:
			long_0 = Class11.smethod_27();
			goto IL_04ab;
			IL_0318:
			num7 = num8;
			goto IL_031c;
			IL_031c:
			AuxiliaryMachineManager.bool_1 = true;
			DateTime dateTime = new DateTime(GClass1.gstruct16_0[num7].long_0);
			AuxiliaryMachineManager.int_1 = new int[3] { dateTime.Day, dateTime.Month, dateTime.Year };
			AuxiliaryMachineManager.string_1 = GClass1.gstruct16_0[num7].string_1;
			AuxiliaryMachineManager.string_2 = GClass1.gstruct16_0[num7].string_2;
			AuxiliaryMachineManager.bool_2 = GClass1.gstruct16_0[num7].int_0 == 1;
			AuxiliaryMachineManager.bool_3 = GClass1.gstruct16_0[num7].int_2 == 1 || GClass1.gstruct16_0[num7].int_2 > 2;
			AuxiliaryMachineManager.bool_4 = GClass1.gstruct16_0[num7].int_2 >= 2;
			AuxiliaryMachineManager.bool_5 = GClass1.gstruct16_0[num7].int_1 > 0;
			AuxiliaryMachineManager.bool_7 = GClass1.gstruct16_0[num7].int_3 > 1;
			AuxiliaryMachineManager.bool_6 = GClass1.gstruct16_0[num7].int_3 > 0;
			Form1.int_10 = 0;
			Form1.int_11 = 0;
			if (GClass1.gstruct16_0[num7].int_0 > 0)
			{
				int_4 = GClass1.gstruct16_0[num7].int_0;
			}
			if (GClass1.gstruct16_0[num7].string_0 == "OF")
			{
				Form1.bool_25 = !Form1.bool_24;
			}
			goto IL_04a1;
		}
	}
}
