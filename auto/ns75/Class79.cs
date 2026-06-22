using System.Net.Sockets;
using System.Text;
using System.Threading;
using ns11;
using ns73;

namespace ns75;

internal class Class79
{
	public TcpClient tcpClient_0 = null;

	public NetworkStream networkStream_0 = null;

	private long long_0 = 0L;

	public void method_0(object object_0)
	{
		try
		{
			NetworkStream networkStream = (NetworkStream)object_0;
			byte[] buffer = new byte[1] { 1 };
			while (!Class11.bool_0 && Class77.int_0 > 0 && 0L <= long_0)
			{
				if (Class11.smethod_28(long_0) > 1000L)
				{
					networkStream.Write(buffer, 0, 1);
					long_0 = Class11.smethod_27();
				}
				Thread.Sleep(300);
			}
		}
		catch
		{
		}
	}

	public void method_1()
	{
		if (Class77.string_2 != null && !(Class77.string_2 == string.Empty))
		{
			if (Class77.string_1 == null || Class77.string_1 == string.Empty)
			{
				Class77.string_1 = "127.0.0.0";
			}
			int num = 256;
			byte[] buffer = new byte[1] { 1 };
			byte[] array = new byte[256];
			byte[] bytes = Encoding.ASCII.GetBytes(Class77.string_1 + "...");
			bool flag = false;
			int num2 = 0;
			while (true)
			{
				Thread.Sleep(600);
				if (Class11.bool_0 || Class77.int_0 <= 0)
				{
					break;
				}
				if (!flag)
				{
					Class77.string_0 = Class77.smethod_2() + "\tChờ kết nối đến " + Class77.string_2 + "...";
					flag = true;
				}
				try
				{
					tcpClient_0 = new TcpClient(Class77.string_2, Class77.int_3);
					networkStream_0 = tcpClient_0.GetStream();
					networkStream_0.Write(bytes, 0, bytes.Length);
					Class77.string_0 = Class77.smethod_2() + "\tKết nối thành công";
					flag = false;
					long_0 = 0L;
					ThreadPool.QueueUserWorkItem(method_0, networkStream_0);
					int num3 = 0;
					do
					{
						num3++;
						Class77.long_0++;
						Thread.Sleep(130);
						if (!Class11.bool_0 && Class77.int_0 > 0)
						{
							long_0 = Class11.smethod_27();
							int num4 = networkStream_0.Read(array, 0, array.Length);
							if (num4 > 0)
							{
								string text = Encoding.ASCII.GetString(array, 0, num4);
								if (text != string.Empty && text != null)
								{
									if (num2 == 0)
									{
										if (text[0] == 'U' && text[1] == 'P')
										{
											array = new byte[2048];
											num2 = 1;
										}
									}
									else
									{
										num2++;
										if (text[0] == '@' || num2 > 300)
										{
											array = new byte[num];
											num2 = 0;
										}
									}
									Class77.smethod_4(text);
								}
								num3 = 0;
							}
							networkStream_0.Write(buffer, 0, 1);
							continue;
						}
						networkStream_0.Close();
						return;
					}
					while (num3 < 60);
				}
				catch
				{
				}
				if (!flag)
				{
					Class77.string_0 = Class77.smethod_2() + "\tGián đoạn.";
				}
				method_2();
				Thread.Sleep(999);
			}
			Class77.string_0 = Class77.smethod_2() + "\tKết thúc.";
			method_2();
		}
		else
		{
			Class77.string_0 = "Chưa thiết lập IP máy phụ.";
			method_2();
		}
	}

	public void method_2()
	{
		try
		{
			networkStream_0.Close();
		}
		catch
		{
		}
		try
		{
			tcpClient_0.Close();
		}
		catch
		{
		}
	}
}
