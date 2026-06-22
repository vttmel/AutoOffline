using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct Struct10
{
	public uint uint_0;

	public Struct11 struct11_0;

	public byte byte_0;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public byte[] byte_1;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public uint[] uint_1;

	public byte byte_2;
}
