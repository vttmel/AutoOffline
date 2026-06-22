using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using ns11;
using ns121;
using ns43;
using ns73;

namespace ns74;

internal class Class78
{
	public TcpListener tcpListener_0 = null;

	private void method_0(object object_0)
	{
		TcpClient tcpClient = (TcpClient)object_0;
		NetworkStream stream = tcpClient.GetStream();
		byte[] array = new byte[80];
		string text = null;
		string text2 = null;
		Class77.long_0 = 0L;
		try
		{
			bool flag = false;
			while (!Class11.bool_0 && Class77.int_0 > 0)
			{
				Class77.long_0++;
				Thread.Sleep(120);
				int num = stream.Read(array, 0, array.Length);
				if (num <= 0)
				{
					continue;
				}
				if (array[0] == 1)
				{
					if (!flag)
					{
						string text3 = null;
						if (!AuxiliaryMachineManager.bool_8)
						{
							text3 = Class77.smethod_5();
						}
						else
						{
							if (AuxiliaryMachineManager.long_0 == 0L || text2 == null)
							{
								AuxiliaryMachineManager.long_0 = Class11.smethod_27();
								text2 = "UP:" + AuxiliaryMachineManager.smethod_0();
							}
							if (Class11.smethod_28(AuxiliaryMachineManager.long_0) < AuxiliaryMachineManager.long_1)
							{
								text3 = text2;
							}
							else
							{
								AuxiliaryMachineManager.bool_8 = false;
								AuxiliaryMachineManager.long_0 = 0L;
								text2 = null;
							}
						}
						if (text3 != null && text3 != string.Empty)
						{
							byte[] bytes = Encoding.ASCII.GetBytes(text3);
							stream.Write(bytes, 0, bytes.Length);
						}
					}
					else
					{
						byte[] array2 = new byte[4] { 46, 46, 46, 0 };
						stream.Write(array2, 0, array2.Length);
						Thread.Sleep(180);
					}
					flag = Class46.characterSyncSnapshot_0.int_0 <= 0;
				}
				else
				{
					string text4 = Encoding.ASCII.GetString(array, 0, num);
					if (0 > text4.IndexOf("..."))
					{
						Class77.string_0 = text4;
						continue;
					}
					text = text4;
					Class77.string_0 = Class77.smethod_2() + "\t" + text + "client connect.";
				}
			}
		}
		catch
		{
		}
		try
		{
			if (text != null)
			{
				Class77.string_0 = Class77.smethod_2() + "\t" + text + "client exit.";
			}
			tcpClient.Close();
		}
		catch
		{
		}
	}

	public void method_1()
	{
		if (Class77.string_1 != null && !(Class77.string_1 == string.Empty))
		{
			if (Class77.int_2 <= 0)
			{
				Class77.int_2 = new Random().Next(5000, 20000);
			}
			Class77.string_0 = Class77.smethod_2() + "\tKhởi tạo server...";
			try
			{
				IPAddress localaddr = IPAddress.Parse(Class77.string_1);
				tcpListener_0 = new TcpListener(localaddr, Class77.int_2);
				tcpListener_0.Start();
				Class77.string_0 = Class77.smethod_2() + "\tThành công!";
				while (!Class11.bool_0 && Class77.int_0 > 0)
				{
					TcpClient state = tcpListener_0.AcceptTcpClient();
					ThreadPool.QueueUserWorkItem(method_0, state);
					Thread.Sleep(600);
				}
				Class77.string_0 = Class77.smethod_2() + "\tKết thúc server.";
				method_2();
				return;
			}
			catch
			{
				method_2();
				if (Class77.int_0 > 0)
				{
					Class77.string_0 = Class77.smethod_2() + "\tSever có lỗi, hãy thử đổi password khác...";
					Class77.int_0 = 0;
				}
				return;
			}
		}
		Class77.string_0 = "Chưa thiết lập IP máy chính.";
		method_2();
		Class77.int_0 = 0;
	}

	public void method_2()
	{
		try
		{
			tcpListener_0.Stop();
		}
		catch
		{
		}
	}
}
