using System;
using System.Diagnostics;
using System.Threading;
using ns1;
using ns100;
using ns11;
using ns118;
using ns146;
using ns149;
using ns2;
using ns21;
using ns23;
using ns49;
using ns53;
using ns63;
using ns77;
using ns89;

namespace ns45;

internal class Class48
{
	public static int[] int_0 = null;

	public static int[] int_1 = null;

	public static bool bool_0 = false;

	public static int int_2 = 0;

	public static bool bool_1 = false;

	public static bool bool_2 = false;

	private static int int_3 = 0;

	public const int int_4 = 2;

	private static void smethod_0()
	{
		Process[] processesByName = Process.GetProcessesByName("WerFault");
		if (processesByName != null && processesByName.Length != 0)
		{
			for (int i = 0; i < processesByName.Length; i++)
			{
				Class24.smethod_53(processesByName[i]);
			}
		}
	}

	private static void smethod_1()
	{
		string text = Class66.smethod_7(Class56.string_4, 0);
		if (text == null || text == string.Empty)
		{
			return;
		}
		Class66.smethod_11(Class66.smethod_1(), Class56.string_4, "", "", 0);
		string[] array = text.Split('|');
		bool flag = false;
		for (int i = 0; i < array.Length; i++)
		{
			int num = Class11.smethod_11(array[i]);
			if (num > 0)
			{
				flag = true;
				Class11.smethod_38(ref ThemXoaDanhsach.int_0, num);
			}
		}
		if (flag)
		{
			Form1.string_26 = null;
			Form1.int_138 = 0;
			Form1.bool_26 = true;
		}
	}

	public static void smethod_2()
	{
		while (true)
		{
			if (!Class56.bool_1)
			{
				if (!Class11.bool_0)
				{
					Thread.Sleep(100);
					continue;
				}
				break;
			}
			Class22.smethod_2();
			Class22.smethod_3();
			while (true)
			{
				try
				{
					smethod_3();
					break;
				}
				catch
				{
				}
			}
			break;
		}
	}

	private static void smethod_3()
	{
		int num = -1;
		int num2 = 0;
		int num3 = 0;
		Process process = null;
		uint num4 = 0u;
		uint num5 = 0u;
		int num6 = 0;
		int num7 = 0;
		string text = string.Empty;
		int num8 = 200;
		long long_ = 0L;
		long long_2 = 0L;
		while (true)
		{
			IL_0038:
			Thread.Sleep(450);
			if (Class11.bool_0)
			{
				break;
			}
			if (!Form1.bool_15 && Class11.smethod_28(long_) > 60000L)
			{
				smethod_0();
				long_ = Class11.smethod_27();
			}
			if (Class11.smethod_28(long_2) > 6000L)
			{
				smethod_1();
				long_2 = Class11.smethod_27();
			}
			Class48.int_2 = -1;
			if (bool_0)
			{
				if (int_0 != null)
				{
					Class2.smethod_0("Login dừng lại bởi người dùng.");
					int_0 = null;
				}
				process = null;
				bool_0 = false;
				Class48.int_2 = 0;
				num = -1;
			}
			if (0 <= num)
			{
				goto IL_03d5;
			}
			if (bool_1 || int_0 == null || int_0.Length == 0)
			{
				continue;
			}
			if (!Form1.bool_15 && (Form1.bool_14 || GClass1.bool_1 || GClass1.string_4 == null || GClass1.string_4 == string.Empty || Form1.int_7 > Form1.int_6))
			{
				int_0 = null;
				continue;
			}
			num = int_0[0];
			int num13;
			if (num >= 0 && FormLogin.gstruct0_0.Length > num)
			{
				GStruct0 gstruct0_ = FormLogin.gstruct0_0[num];
				if (gstruct0_.int_1 > 0 && !Class24.smethod_52(gstruct0_.process_0))
				{
					uint num9 = Class24.smethod_30(Class96.uint_0, gstruct0_.int_2);
					uint num10 = Class24.smethod_30(num9 + Class96.uint_2, gstruct0_.int_2) * Class96.uint_4;
					uint num11 = Class24.smethod_30(Class96.uint_3, gstruct0_.int_2);
					uint num12 = num11 + num10;
					num3 = Class52.smethod_33(gstruct0_);
					if (num3 > 1)
					{
						string text2 = Class24.smethod_28(num12 + Class96.uint_5, gstruct0_.int_2);
						if (text2 != null && text2.Length > 5)
						{
							goto IL_12e3;
						}
					}
					Class24.smethod_48(gstruct0_.int_1);
				}
				if (bool_2 && Class81.int_4 > 0)
				{
					int[] array = Class24.smethod_24(Class56.string_21);
					if (array != null && Class81.int_4 <= array.Length)
					{
						goto IL_12e3;
					}
				}
				string text3 = Class11.smethod_15(FormLogin.gstruct0_0[num].string_1);
				if (text3 != null && !(text3 == string.Empty) && text3[0] <= text3.Length - 1 && FormLogin.gstruct0_0[num].string_0 != null && !(FormLogin.gstruct0_0[num].string_0 == string.Empty))
				{
					text = text3.Substring(1, text3[0]);
					num2 = 0;
					num6 = -1;
					num7 = -1;
					string string_ = FormLogin.gstruct0_0[num].string_2;
					string string_2 = FormLogin.gstruct0_0[num].string_3;
					string text4 = Class1.smethod_1(FormLogin.gstruct0_0[num].string_4, 1);
					if (text4 == string.Empty)
					{
						text4 = FormLogin.gstruct0_0[num].string_0;
					}
					Class2.smethod_0("Đang đăng nhập <" + text4 + "> đợi chút xíu...");
					for (int i = 0; i < FormLogin.string_6.Length; i++)
					{
						string[] array2 = FormLogin.string_6[i].Split('|');
						if (array2[0] != string_)
						{
							continue;
						}
						num7 = i;
						num13 = 1;
						while (num13 < array2.Length)
						{
							if (!(array2[num13] == string_2))
							{
								num13++;
								continue;
							}
							goto IL_03cf;
						}
					}
					Class2.smethod_0("Lỗi dữ liệu không đúng Phân đà và Server, không thể login.");
				}
			}
			goto IL_12e3;
			IL_123f:
			int num14;
			while (!Class11.bool_0 && int_3 > 0 && num14 < 15)
			{
				num14++;
				Thread.Sleep(100);
			}
			int id;
			int_3 = id;
			new Thread(smethod_4).Start();
			goto IL_12e3;
			IL_03cf:
			num6 = num13 - 1;
			goto IL_03d5;
			IL_1287:
			Class48.int_2 = 0;
			num2++;
			if (num2 < 3)
			{
				continue;
			}
			Class2.smethod_0("Không thể login !");
			goto IL_12a4;
			IL_088d:
			int num15 = 0;
			GStruct0 gstruct0_2;
			while (true)
			{
				if (num15 % 3 == 0)
				{
					Class52.smethod_22(gstruct0_2, text);
				}
				num15++;
				Thread.Sleep(100);
				if (num15 > 10 || Class24.smethod_52(gstruct0_2.process_0))
				{
					break;
				}
				string text5 = Class52.smethod_23(gstruct0_2, text.Length + 1);
				if (!(text5 == text))
				{
					continue;
				}
				goto IL_08f2;
			}
			goto IL_1287;
			IL_03d5:
			FormLogin.gstruct0_0[num].int_1 = 0;
			FormLogin.gstruct0_0[num].int_2 = 0;
			FormLogin.gstruct0_0[num].uint_0 = 0u;
			FormLogin.gstruct0_0[num].uint_1 = 0u;
			FormLogin.gstruct0_0[num].uint_2 = 0u;
			FormLogin.gstruct0_0[num].uint_3 = 0u;
			FormLogin.gstruct0_0[num].int_0 = 0;
			num4 = 0u;
			num5 = 0u;
			Process process2 = Class2.smethod_3();
			if (!Class24.smethod_52(process))
			{
				Class24.smethod_53(process);
				Thread.Sleep(100);
			}
			process = process2;
			if (process == null)
			{
				Thread.Sleep(100);
			}
			else
			{
				int num16 = 0;
				int num17 = 0;
				while (true)
				{
					bool flag = false;
					GStruct8[] array3;
					if (num16 == 0)
					{
						array3 = Class24.smethod_62(process.Id, "WIN_CLASS:#32770|CTR_CLASS:Button");
						if (array3 != null && array3.Length != 0 && array3[0].gstruct7_0 != null)
						{
							for (int j = 0; j < array3[0].gstruct7_0.Length; j++)
							{
								if (array3[0].gstruct7_0[j].int_0 == 1)
								{
									Class24.smethod_4(array3[0].gstruct7_0[j].uint_0, 32u);
									Thread.Sleep(300);
									flag = true;
									break;
								}
							}
						}
						num16 = 1;
						if (flag)
						{
							smethod_0();
							continue;
						}
					}
					if (num17 != 0)
					{
						break;
					}
					array3 = Class24.smethod_62(process.Id, "CTR_INSTANCE:1");
					if (array3 != null && array3.Length != 0)
					{
						for (num13 = 0; num13 < array3.Length; num13++)
						{
							if (array3[num13].gstruct7_0 == null)
							{
								continue;
							}
							for (int k = 0; k < array3[num13].gstruct7_0.Length; k++)
							{
								if (array3[num13].gstruct7_0[k].int_0 == 1)
								{
									Class24.smethod_4(array3[num13].gstruct7_0[k].uint_0, 32u);
									Thread.Sleep(300);
									flag = true;
								}
							}
						}
					}
					num17 = 1;
					if (!flag)
					{
						break;
					}
					smethod_0();
				}
				num14 = 0;
				id = process.Id;
				while (num4 == 0)
				{
					try
					{
						num4 = (uint)(int)process.MainModule.BaseAddress;
					}
					catch
					{
					}
					num14++;
					if (num14 <= 10)
					{
						Thread.Sleep(300);
						continue;
					}
					goto IL_1287;
				}
				num5 = 0u;
				GStruct8[] array4 = Class24.smethod_62(id, "WIN_CLASS:" + Class56.string_21);
				if (array4 != null && array4.Length != 0)
				{
					num5 = array4[0].uint_0;
				}
				FormLogin.gstruct0_0[num].int_1 = id;
				FormLogin.gstruct0_0[num].int_2 = Class24.OpenProcess(2035711, bool_0: false, id);
				FormLogin.gstruct0_0[num].process_0 = process;
				FormLogin.gstruct0_0[num].uint_0 = num5;
				FormLogin.gstruct0_0[num].uint_1 = num4;
				if (Class52.smethod_2(ref FormLogin.gstruct0_0[num]) >= 0)
				{
					gstruct0_2 = FormLogin.gstruct0_0[num];
					if (Class52.smethod_15(gstruct0_2))
					{
						Thread.Sleep(100 + num8);
						if (Class52.smethod_16(gstruct0_2))
						{
							Thread.Sleep(100 + num8);
							if (Class52.smethod_17(gstruct0_2, num7))
							{
								Thread.Sleep(200 + num8);
								if (Class52.smethod_18(gstruct0_2, num6))
								{
									Thread.Sleep(200 + num8);
									if (Class52.smethod_19(gstruct0_2))
									{
										if (FormLogin.int_8 > 1000)
										{
											Class2.smethod_0("Chờ " + FormLogin.int_8 / 1000 + " giây trước khi nhập tài khoản...");
										}
										long long_3 = Class11.smethod_27();
										while (!Class11.bool_0)
										{
											Thread.Sleep(100);
											if (bool_0)
											{
												goto IL_0038;
											}
											long num18 = Class11.smethod_28(long_3);
											if (num18 > FormLogin.int_8)
											{
												break;
											}
											Class48.int_2 = (int)(FormLogin.int_8 - num18);
										}
										num15 = 0;
										while (true)
										{
											if (num15 % 3 == 0)
											{
												Class52.smethod_20(gstruct0_2, gstruct0_2.string_0);
											}
											num15++;
											Thread.Sleep(100);
											if (num15 > 80 || Class24.smethod_52(gstruct0_2.process_0))
											{
												break;
											}
											string text6 = Class52.smethod_21(gstruct0_2, gstruct0_2.string_0.Length + 1);
											if (!(text6 == gstruct0_2.string_0))
											{
												continue;
											}
											goto IL_088d;
										}
									}
								}
							}
						}
					}
				}
				else
				{
					FormLogin.gstruct0_0[num].int_1 = 0;
					FormLogin.gstruct0_0[num].process_0 = null;
				}
			}
			goto IL_1287;
			IL_12e3:
			Class11.smethod_39(ref int_0, num);
			if (FormLogin.bool_0)
			{
				Class11.smethod_38(ref int_1, num);
			}
			process = null;
			num = -1;
			continue;
			IL_08f2:
			Thread.Sleep(100);
			string text11;
			if (Class52.smethod_24(gstruct0_2))
			{
				uint num19 = 2699940u;
				uint num20 = 4880u;
				uint num21 = 472u;
				int num22 = 6 + Convert.ToByte(FormLogin.int_4 <= 0) * 14;
				int l = 0;
				string text7 = string.Empty;
				for (; l < num22; l++)
				{
					if (!(text7 == string.Empty))
					{
						break;
					}
					uint num23 = Class24.smethod_30(gstruct0_2.uint_1 + num19, gstruct0_2.int_2);
					text7 = Class24.smethod_28(num23 + num20 + num21, gstruct0_2.int_2);
					Thread.Sleep(100);
				}
				Thread.Sleep(600 + num8);
				if (Class52.smethod_25(gstruct0_2, gstruct0_2.int_4 - 1))
				{
					Thread.Sleep(200 + num8);
					bool flag2 = false;
					if (FormLogin.bool_1 != null && num < FormLogin.bool_1.Length)
					{
						flag2 = FormLogin.bool_1[num];
					}
					if (flag2)
					{
						string string_3 = "TẠO NHÂN VẬT";
						string string_4 = "[" + gstruct0_2.string_0 + "] Đã vào giao diện tạo nhân vật...";
						Class11.smethod_29(ref Class11.string_17, string_4);
						if (FormLogin.bool_0)
						{
							Class11.smethod_29(ref FormLogin.string_0, string_4);
						}
						FormLogin.gstruct0_0[num].string_4 = string_3;
						FormLogin.gstruct0_0[num].int_0 = 1;
						Thread.Sleep(500);
						uint uint_ = gstruct0_2.uint_0;
						Class24.POINT point_ = default(Class24.POINT);
						Class24.GetCursorPos(out point_);
						Class2.smethod_0("Bước 1: Click vào nút Tạo nhân vật tại (200, 560)...");
						Class24.POINT point_2 = new Class24.POINT
						{
							x = 200,
							y = 560
						};
						Class24.ClientToScreen(uint_, ref point_2);
						Class24.SetCursorPos(point_2.x, point_2.y);
						Thread.Sleep(100);
						Class24.mouse_event(2, 0, 0, 0, 0);
						Thread.Sleep(50);
						Class24.mouse_event(4, 0, 0, 0, 0);
						Thread.Sleep(800);
						Class2.smethod_0("Bước 2: Gọi DLL C++ để gửi phím Enter...");
						try
						{
							int num24 = Class24.SendEnterKey(uint_);
							if (num24 == 1)
							{
								Class2.smethod_0("Đã gửi phím Enter thành công qua DLL.");
							}
							else
							{
								Class2.smethod_0("Lỗi gửi phím Enter qua DLL, code: " + num24);
							}
						}
						catch (Exception ex)
						{
							Class2.smethod_0("Lỗi gọi DLL: " + ex.Message);
						}
						Thread.Sleep(800);
						string text8 = "Kim";
						if (FormLogin.string_1 != null && num < FormLogin.string_1.Length)
						{
							text8 = FormLogin.string_1[num];
						}
						if (text8.Trim() == "Kim")
						{
							Class2.smethod_0("Bước 3: Hệ Kim được chọn - Giữ nguyên mặc định, không click.");
						}
						else
						{
							FormLogin.smethod_0(text8, out var int_, out var int_2);
							Class2.smethod_0("Bước 3: Click chọn hệ " + text8 + " tại tọa độ (" + int_ + ", " + int_2 + ")...");
							Class24.POINT point_3 = default(Class24.POINT);
							Class24.GetCursorPos(out point_3);
							Class24.POINT point_4 = new Class24.POINT
							{
								x = int_,
								y = int_2
							};
							Class24.ClientToScreen(uint_, ref point_4);
							Class2.smethod_0("Tọa độ screen: (" + point_4.x + ", " + point_4.y + ")");
							Class24.SetCursorPos(point_4.x, point_4.y);
							Thread.Sleep(150);
							Class2.smethod_0("Đang thực hiện click chuột...");
							Class24.mouse_event(2, 0, 0, 0, 0);
							Thread.Sleep(100);
							Class24.mouse_event(4, 0, 0, 0, 0);
							Thread.Sleep(200);
							Class24.SetCursorPos(point_3.x, point_3.y);
							Class2.smethod_0("Đã click chọn hệ " + text8 + " thành công.");
						}
						if (!string.IsNullOrEmpty(FormLogin.string_2))
						{
							int num25 = num + 1;
							int num26 = FormLogin.smethod_6(FormLogin.string_2);
							Class2.smethod_0("Bước 4: Đọc tên nhân vật từ file (dòng " + num25 + "/" + num26 + ")...");
							if (num25 <= num26)
							{
								string text9 = FormLogin.smethod_1(FormLogin.string_2, num25);
								if (!string.IsNullOrEmpty(text9))
								{
									Class2.smethod_0("Tên nhân vật (dòng " + num25 + "): " + text9);
									Thread.Sleep(300);
									if (FormLogin.smethod_7(uint_, text9))
									{
										Class2.smethod_0("Đã gửi tên nhân vật thành công.");
									}
									else
									{
										Class2.smethod_0("Lỗi gửi tên nhân vật.");
									}
								}
								else
								{
									Class2.smethod_0("Dòng " + num25 + " trống - bỏ qua nhập tên.");
								}
							}
							else
							{
								Class2.smethod_0("File chỉ có " + num26 + " dòng, không đủ cho account " + num25 + " - bỏ qua nhập tên.");
							}
						}
						else
						{
							Class2.smethod_0("Chưa chọn file tên nhân vật - bỏ qua bước nhập tên.");
						}
						Class2.smethod_0("Đã hoàn thành quy trình tạo nhân vật hệ " + text8);
						Thread.Sleep(500);
						if (!string.IsNullOrEmpty(FormLogin.string_2))
						{
							Class2.smethod_0("Bước 5: Gửi Enter để xác nhận tên nhân vật...");
							try
							{
								int num27 = Class24.SendEnterKey(uint_);
								if (num27 == 1)
								{
									Class2.smethod_0("Đã gửi Enter thành công qua DLL.");
								}
								else
								{
									Class2.smethod_0("Lỗi gửi Enter qua DLL, code: " + num27);
								}
							}
							catch (Exception ex2)
							{
								Class2.smethod_0("Lỗi gọi DLL Enter: " + ex2.Message);
							}
							Thread.Sleep(500);
						}
						Class2.smethod_0("Bước 6: Đóng game bằng ProcessKill...");
						Thread.Sleep(3000);
						try
						{
							if (gstruct0_2.process_0 != null && !gstruct0_2.process_0.HasExited)
							{
								gstruct0_2.process_0.Kill();
								Class2.smethod_0("Đã đóng game thành công bằng ProcessKill.");
							}
							else
							{
								Class2.smethod_0("Process đã đóng hoặc không tồn tại.");
							}
						}
						catch (Exception ex3)
						{
							Class2.smethod_0("Lỗi ProcessKill: " + ex3.Message);
							try
							{
								if (gstruct0_2.int_1 > 0)
								{
									Class24.smethod_48(gstruct0_2.int_1);
									Class2.smethod_0("Đã fallback kill process bằng TerminateProcess.");
								}
							}
							catch (Exception ex4)
							{
								Class2.smethod_0("Fallback lỗi: " + ex4.Message);
							}
						}
						Class2.smethod_0("Đã hoàn thành tạo nhân vật hệ " + text8 + " cho: " + gstruct0_2.string_0);
						if (FormLogin.int_9 > 0)
						{
							Class24.ShowWindow(num5, Class24.int_26);
						}
						if (FormLogin.bool_1 != null && num < FormLogin.bool_1.Length)
						{
							FormLogin.bool_1[num] = false;
						}
						num14 = 0;
						goto IL_123f;
					}
					string text10 = string.Empty;
					bool flag3 = false;
					num14 = 0;
					long long_4 = Class11.smethod_27();
					while (true)
					{
						if (Class11.bool_0)
						{
							goto IL_1176;
						}
						if (bool_0)
						{
							break;
						}
						if (num14 % 60 != 0 || Class52.smethod_26(gstruct0_2) || num14 != 0)
						{
							Thread.Sleep(100);
							text11 = Class52.smethod_27(gstruct0_2);
							if (0 > text11.IndexOf("Xin nhËp vµo Tµi") && 0 > text11.IndexOf("KÕt nèi m\u00b8y chñ th") && 0 > text11.IndexOf("HÖ thèng ®ang bËn"))
							{
								if (0 <= text11.IndexOf("Xin h·y n¹p tµi kho¶n") || 0 <= text11.IndexOf("Tµi kho¶n nµy ®· bÞ khãa") || 0 <= text11.IndexOf("Tµi kho¶n nµy hiÖn ®ang") || 0 <= text11.IndexOf("Tµi kho¶n hoÆc MËt khÈu"))
								{
									goto IL_1150;
								}
								num3 = Class52.smethod_33(gstruct0_2);
								if (num3 > 1)
								{
									uint num28 = Class24.smethod_30(Class96.uint_0, gstruct0_2.int_2);
									uint num29 = Class24.smethod_30(num28 + Class96.uint_2, gstruct0_2.int_2) * Class96.uint_4;
									uint num30 = Class24.smethod_30(Class96.uint_3, gstruct0_2.int_2);
									uint num31 = num30 + num29;
									text10 = Class24.smethod_28(num31 + Class96.uint_5, gstruct0_2.int_2);
									if (text10 != null && text10 != string.Empty && text10.Length > 5)
									{
										flag3 = true;
										goto IL_1176;
									}
								}
								long num32 = Class11.smethod_28(long_4);
								if (num32 <= FormLogin.int_7)
								{
									Class48.int_2 = (int)(FormLogin.int_7 - num32);
									num14++;
									continue;
								}
								Class2.smethod_0("Không thể đăng nhập, đang thử lại...");
							}
							else
							{
								Class2.smethod_0(Class1.smethod_1(text11, 1));
							}
						}
						goto IL_1287;
						IL_1176:
						string string_5 = "[" + Class1.smethod_1(text10, 1) + "] Đã đăng nhập...";
						Class11.smethod_29(ref Class11.string_17, string_5);
						if (FormLogin.bool_0)
						{
							Class11.smethod_29(ref FormLogin.string_0, string_5);
						}
						FormLogin.gstruct0_0[num].string_4 = text10;
						FormLogin.gstruct0_0[num].int_0 = 1;
						if (flag3 && FormLogin.gstruct0_0[num].string_5 != text10)
						{
							FormLogin.gstruct0_0[num].string_5 = text10;
							Class22.smethod_1();
						}
						if (FormLogin.int_9 > 0)
						{
							Class24.ShowWindow(num5, Class24.int_26);
						}
						num14 = 0;
						goto IL_123f;
					}
					continue;
				}
			}
			goto IL_1287;
			IL_1150:
			Class2.smethod_0(Class1.smethod_1(text11, 1));
			goto IL_12a4;
			IL_12a4:
			Class24.smethod_53(process);
			if (FormLogin.gstruct0_0 != null && 0 <= num && num < FormLogin.gstruct0_0.Length)
			{
				FormLogin.gstruct0_0[num].int_1 = 0;
				FormLogin.gstruct0_0[num].process_0 = null;
			}
			goto IL_12e3;
		}
	}

	private static void smethod_4()
	{
		int num = 0;
		while (!Class11.bool_0 && int_3 > 0 && num < 20)
		{
			Thread.Sleep(100);
			num++;
		}
		if (int_3 > 0)
		{
			Form1.string_26 = null;
			Class11.smethod_38(ref ThemXoaDanhsach.int_0, int_3);
		}
		int_3 = 0;
		Form1.int_138 = 0;
		Form1.bool_26 = true;
	}

	public static string smethod_5()
	{
		int num = 0;
		int[] array = Class24.smethod_24(Class56.string_21);
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				try
				{
					GStruct8[] array2 = Class24.smethod_62(array[i], "WIN_CLASS:Sword3 Class");
					if (array2 == null || array2.Length == 0)
					{
						Class24.smethod_48(array[i]);
						Thread.Sleep(100);
						num++;
					}
				}
				catch
				{
				}
			}
		}
		if (!(Class56.string_19 == string.Empty) && Class56.string_19 != null)
		{
			string processName = Class56.string_19;
			if (Class11.smethod_1(Class56.string_19.ToUpper(), ".EXE") > 0)
			{
				string[] array3 = Class11.smethod_14(Class56.string_19, '.');
				processName = array3[0];
			}
			Process[] processesByName = Process.GetProcessesByName(processName);
			if (processesByName == null || processesByName.Length == 0)
			{
				processesByName = Process.GetProcessesByName(Class56.string_19 + "\u00a0");
				if (processesByName == null || processesByName.Length == 0)
				{
					goto IL_013d;
				}
			}
			for (int j = 0; j < processesByName.Length; j++)
			{
				try
				{
					GStruct8[] array4 = Class24.smethod_62(processesByName[j].Id, "WIN_CLASS:Sword3 Class");
					if (array4 == null || array4.Length == 0)
					{
						Class24.smethod_48(processesByName[j].Id);
						num++;
					}
				}
				catch
				{
				}
			}
		}
		goto IL_013d;
		IL_013d:
		if (num == 0)
		{
			return "Không tìm thấy game hư chạy ngầm nào.";
		}
		return "Đã thoát " + num + " game hư đang chạy ngầm.";
	}
}
