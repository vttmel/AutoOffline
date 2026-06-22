using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct Struct12
{
	public byte byte_0;

	public byte byte_1;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public byte[] byte_2;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public uint[] uint_0;
}
