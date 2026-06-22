using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;
using ns11;
using ns146;
using ns23;
using ns53;

namespace ns48;

internal class Class51
{
	private enum TcpTableType
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8
	}

	private enum TcpConnectionState
	{
		CLOSED = 1,
		LISTENING = 2,
		SYN_SENT = 3,
		SYN_RCVD = 4,
		ESTABLISHED = 5,
		FIN_WAIT1 = 6,
		FIN_WAIT2 = 7,
		CLOSE_WAIT = 8,
		CLOSING = 9,
		LAST_ACK = 10,
		TIME_WAIT = 11,
		DELETE_TCB = 12,
		NONE = 0
	}

	private struct TcpConnectionInfo
	{
		public TcpConnectionState c6b3f8f0bd286eb5563fde5358cf7b375_0;

		public uint uint_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] byte_0;

		public uint uint_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] byte_1;

		public int int_0;
	}

	private struct TcpTable
	{
		public uint uint_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
		public TcpConnectionInfo[] struct19_0;
	}

	private const int int_0 = 2;

	[DllImport("iphlpapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern uint GetExtendedTcpTable(IntPtr intptr_0, ref int int_1, bool bool_0, int int_2, TcpTableType tcpTableType_0, uint uint_0 = 0u);

	public static TcpConnectionEntry[] smethod_0(int[] int_1 = null)
	{
		TcpConnectionEntry[] array = null;
		try
		{
			int int_2 = 0;
			GetExtendedTcpTable(IntPtr.Zero, ref int_2, bool_0: true, 2, TcpTableType.const_5);
			IntPtr intPtr = Marshal.AllocHGlobal(int_2);
			if (GetExtendedTcpTable(intPtr, ref int_2, bool_0: true, 2, TcpTableType.const_5) != 0)
			{
				return null;
			}
			TcpTable tcpTable = (TcpTable)Marshal.PtrToStructure(intPtr, typeof(TcpTable));
			if (tcpTable.uint_0 == 0)
			{
				return null;
			}
			IntPtr intPtr2 = (IntPtr)((long)intPtr + Marshal.SizeOf((object)tcpTable.uint_0));
			array = ((int_1 != null) ? new TcpConnectionEntry[int_1.Length] : new TcpConnectionEntry[tcpTable.uint_0]);
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < tcpTable.uint_0; i++)
			{
				TcpConnectionInfo tcpConnectionInfo = (TcpConnectionInfo)Marshal.PtrToStructure(intPtr2, typeof(TcpConnectionInfo));
				intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf((object)tcpConnectionInfo));
				if (int_1 != null)
				{
					num = -1;
					for (int j = 0; j < int_1.Length; j++)
					{
						if (int_1[j] == tcpConnectionInfo.int_0)
						{
							num = j;
							break;
						}
					}
					if (num < 0)
					{
						continue;
					}
				}
				if (array.Length <= num2)
				{
					Array.Resize(ref array, num2 + 1);
				}
				array[num2].int_0 = tcpConnectionInfo.int_0;
				array[num2].string_1 = new IPAddress(tcpConnectionInfo.uint_0).ToString();
				array[num2].int_1 = BitConverter.ToUInt16(new byte[2]
				{
					tcpConnectionInfo.byte_0[1],
					tcpConnectionInfo.byte_0[0]
				}, 0);
				string text = new IPAddress(tcpConnectionInfo.uint_1).ToString();
				array[num2].string_2 = text;
				array[num2].int_2 = BitConverter.ToUInt16(new byte[2]
				{
					tcpConnectionInfo.byte_1[1],
					tcpConnectionInfo.byte_1[0]
				}, 0);
				array[num2].string_0 = tcpConnectionInfo.c6b3f8f0bd286eb5563fde5358cf7b375_0.ToString();
				array[num2].uint_0 = Class11.smethod_6(text);
				num2++;
			}
		}
		catch
		{
		}
		return array;
	}

	public static long smethod_1(string string_0)
	{
		if (string_0 != null)
		{
			string[] array = string_0.Split('|');
			int num = 0;
			do
			{
				try
				{
					if (array[num] != null && array[num] != string.Empty)
					{
						Ping ping = new Ping();
						PingReply pingReply = ping.Send(array[num]);
						return pingReply.RoundtripTime;
					}
				}
				catch
				{
				}
				num++;
			}
			while (num < array.Length);
			return 0L;
		}
		return 0L;
	}

	private static string[] smethod_2(int int_1)
	{
		string[] array = null;
		try
		{
			int int_2 = 0;
			GetExtendedTcpTable(IntPtr.Zero, ref int_2, bool_0: true, 2, TcpTableType.const_5);
			IntPtr intPtr = Marshal.AllocHGlobal(int_2);
			if (GetExtendedTcpTable(intPtr, ref int_2, bool_0: true, 2, TcpTableType.const_5) != 0)
			{
				return null;
			}
			TcpTable tcpTable = (TcpTable)Marshal.PtrToStructure(intPtr, typeof(TcpTable));
			if (tcpTable.uint_0 == 0)
			{
				return null;
			}
			IntPtr intPtr2 = (IntPtr)((long)intPtr + Marshal.SizeOf((object)tcpTable.uint_0));
			for (int i = 0; i < tcpTable.uint_0; i++)
			{
				TcpConnectionInfo tcpConnectionInfo = (TcpConnectionInfo)Marshal.PtrToStructure(intPtr2, typeof(TcpConnectionInfo));
				intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf((object)tcpConnectionInfo));
				if (tcpConnectionInfo.int_0 == int_1)
				{
					string text = new IPAddress(tcpConnectionInfo.uint_1).ToString();
					if (array != null)
					{
						Array.Resize(ref array, array.Length + 1);
					}
					else
					{
						array = new string[1];
					}
					array[array.Length - 1] = text;
				}
			}
		}
		catch
		{
		}
		return array;
	}

	public static void smethod_3()
	{
		do
		{
			if (!GClass1.bool_0)
			{
				Thread.Sleep(600);
				continue;
			}
			int int_ = 0;
			byte[] bytes = BitConverter.GetBytes(39321);
			Class24.WriteProcessMemory(Class11.int_1, Class11.uint_1 + Class56.uint_3 * 4, bytes, 4, ref int_);
			break;
		}
		while (!Class11.bool_0);
	}
}
