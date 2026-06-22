using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns100;

namespace ns151;

internal static class Class105
{
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr LoadLibrary(string string_0);

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		try
		{
			string debugLogPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "debug_log.txt");
			if (File.Exists(debugLogPath))
			{
				try
				{
					File.Delete(debugLogPath);
				}
				catch (Exception ex)
				{
					File.AppendAllText("Error_Log.txt", $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Error: Không thể xóa debug_log.txt khi khởi động. Lỗi: {ex.Message}\n");
				}
			}
			string importDllPath = Path.Combine(Path.GetTempPath(), "import.dll");
			string eDllPath = Path.Combine(Path.GetTempPath(), "e.dll");
			smethod_0("import.dll", "Keoxe365.import.dll", importDllPath, debugLogPath);
			smethod_0("e.dll", "Keoxe365.e.dll", eDllPath, debugLogPath);
			string errorLogPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Error_Log.txt");
			Application.ApplicationExit += delegate
			{
				try
				{
					if (File.Exists(importDllPath))
					{
						File.Delete(importDllPath);
					}
					if (File.Exists(eDllPath))
					{
						File.Delete(eDllPath);
					}
					if (File.Exists(debugLogPath))
					{
						File.Delete(debugLogPath);
					}
					if (File.Exists(errorLogPath))
					{
						File.Delete(errorLogPath);
					}
				}
				catch (Exception)
				{
				}
			};
			Application.Run(new Form1());
		}
		catch (Exception ex2)
		{
			File.AppendAllText("Error_Log.txt", $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Error: {ex2.Message}\n");
		}
	}

	private static void smethod_0(string string_0, string string_1, string string_2, string string_3)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using Stream stream = executingAssembly.GetManifestResourceStream(string_1);
		if (stream == null)
		{
			throw new Exception("Không tìm thấy " + string_0 + " trong tài nguyên (" + string_1 + "). Kiểm tra lại tên tài nguyên hoặc build dự án.");
		}
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		try
		{
			File.WriteAllBytes(string_2, array);
		}
		catch (UnauthorizedAccessException ex)
		{
			throw new Exception("Không thể ghi " + string_0 + " vào " + string_2 + ". Vui lòng chạy ứng dụng với quyền Administrator. Lỗi: " + ex.Message);
		}
		IntPtr intPtr = LoadLibrary(string_2);
		if (intPtr == IntPtr.Zero)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			throw new Exception($"Không thể tải {string_0}. Mã lỗi: {lastWin32Error}");
		}
		if (File.Exists(string_3))
		{
			try
			{
				File.Delete(string_3);
				return;
			}
			catch (Exception ex2)
			{
				File.AppendAllText("Error_Log.txt", $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Error: Không thể xóa debug_log.txt sau khi tải {string_0}. Lỗi: {ex2.Message}\n");
				return;
			}
		}
	}
}
