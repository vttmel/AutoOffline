using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns16;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal class Class16
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager("EmbeddedImageResources", typeof(Class16).Assembly);
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal static Bitmap Bitmap_0
	{
		get
		{
			object obj = ResourceManager_0.GetObject("0", cultureInfo_0);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Bitmap_1
	{
		get
		{
			object obj = ResourceManager_0.GetObject("1", cultureInfo_0);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Bitmap_2
	{
		get
		{
			object obj = ResourceManager_0.GetObject("2", cultureInfo_0);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Bitmap_3
	{
		get
		{
			object obj = ResourceManager_0.GetObject("3", cultureInfo_0);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Bitmap_4
	{
		get
		{
			object obj = ResourceManager_0.GetObject("nhapsoluong", cultureInfo_0);
			return (Bitmap)obj;
		}
	}

	internal Class16()
	{
	}
}
