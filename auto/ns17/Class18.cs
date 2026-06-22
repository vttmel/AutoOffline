using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using ns13;
using ns71;

namespace ns17;

internal class Class18 : IDisposable
{
	private readonly ListView listView_0;

	private readonly Func<CharacterAccountConfig?> func_0;

	private readonly Func<CharacterAccountConfig, uint[]> func_1;

	private readonly Func<CharacterAccountConfig, int> func_2;

	private readonly Func<bool> func_3;

	private readonly Action<string> action_0;

	private readonly Func<CharacterAccountConfig, int> func_4;

	private readonly Action action_1;

	private readonly int int_0;

	private System.Threading.Timer timer_0;

	private readonly List<uint[]> list_0 = new List<uint[]>();

	private int int_1;

	private bool bool_0;

	private bool bool_1 = false;

	private bool bool_2 = false;

	private bool bool_3 = false;

	private readonly object object_0 = new object();

	private int int_2 = -1;

	private uint[] uint_0 = null;

	private static readonly int[] int_3 = new int[7] { 323, 324, 325, 379, 380, 381, 382 };

	private const uint uint_1 = 5625u;

	public Class18(ListView listView_1, Func<CharacterAccountConfig?> func_5, Func<CharacterAccountConfig, uint[]> func_6, Func<CharacterAccountConfig, int> func_7 = null, Func<bool> func_8 = null, Action<string> action_2 = null, Func<CharacterAccountConfig, int> func_9 = null, Action action_3 = null, int int_4 = 300)
	{
		listView_0 = listView_1 ?? throw new ArgumentNullException("listViewTrain");
		func_0 = func_5 ?? throw new ArgumentNullException("playerProvider");
		func_1 = func_6 ?? throw new ArgumentNullException("positionProvider");
		func_2 = func_7;
		func_3 = func_8;
		action_0 = action_2;
		func_4 = func_9;
		action_1 = action_3;
		int_0 = int_4;
	}

	public bool method_0()
	{
		list_0.Clear();
		method_5(list_0);
		CharacterAccountConfig? characterAccountConfig = func_0();
		if (!characterAccountConfig.HasValue)
		{
			return false;
		}
		if (list_0.Count == 0)
		{
			Class75.smethod_52(characterAccountConfig.Value, "<bclr=red><color=white>[TBTkeoxe]: Vui lßng lÊy to¹ ®é råi bËt chøc n\u00a8ng.");
			return false;
		}
		uint[] array = func_1(characterAccountConfig.Value);
		if (array != null && array.Length >= 2)
		{
			uint_0 = null;
			bool_2 = false;
			bool_1 = false;
			int_1 = method_4(array);
			bool_0 = smethod_1(int_1, list_0.Count);
			int_2 = int_1;
			lock (object_0)
			{
				if (timer_0 == null)
				{
					timer_0 = new System.Threading.Timer(method_2, null, int_0, int_0);
				}
				else
				{
					timer_0.Change(int_0, int_0);
				}
			}
			return true;
		}
		return false;
	}

	public void method_1()
	{
		lock (object_0)
		{
			timer_0?.Change(-1, -1);
		}
	}

	public void Dispose()
	{
		lock (object_0)
		{
			bool_3 = true;
			timer_0?.Change(-1, -1);
			timer_0?.Dispose();
			timer_0 = null;
		}
	}

	private void method_2(object object_1)
	{
		if (bool_3)
		{
			return;
		}
		CharacterAccountConfig? characterAccountConfig = func_0();
		if (!characterAccountConfig.HasValue)
		{
			method_1();
			return;
		}
		CharacterAccountConfig value = characterAccountConfig.Value;
		if (list_0.Count == 0)
		{
			Class75.smethod_52(value, "<bclr=red><color=white>[TBTkeoxe]: Vui lßng lÊy to¹ ®é råi bËt chøc n\u00a8ng.");
			action_1?.Invoke();
			method_1();
			return;
		}
		if (func_4 != null)
		{
			int num = func_4(value);
			bool flag = false;
			for (int i = 0; i < int_3.Length; i++)
			{
				if (num == int_3[i])
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				Class75.smethod_52(value, "<bclr=red><color=white>[TBTkeoxe]: Sai maps TK, tù ®éng t¾t Chøc N\u00a8ng");
				action_1?.Invoke();
				method_1();
				return;
			}
		}
		if (func_3 != null)
		{
			if (!func_3())
			{
				if (!bool_1)
				{
					Class75.smethod_52(value, "<bclr=red><color=white>[TBTkeoxe]:<bclr=blue><color=white> §ang chê rêi khái hËu doanh");
					bool_1 = true;
				}
				return;
			}
			if (bool_1)
			{
				bool_1 = false;
				if (list_0.Count > 0)
				{
					uint[] array = func_1(value);
					if (array != null && array.Length >= 2)
					{
						int_1 = method_4(array);
						bool_0 = smethod_1(int_1, list_0.Count);
					}
					else
					{
						int num2 = int_1;
						if (num2 < 0 || num2 >= list_0.Count)
						{
							num2 = (bool_0 ? (list_0.Count - 1) : 0);
						}
						int_1 = num2;
					}
					uint[] array2 = list_0[int_1];
					int_2 = -1;
					Class75.smethod_52(value, "<bclr=red><color=white>[TBTkeoxe]:<bclr=blue><color=white>§ang di chuyÓn ®Õn to¹ ®é: (" + array2[0] + ", " + array2[1] + ")");
				}
			}
		}
		uint[] array3 = null;
		if (func_2 != null)
		{
			int num3 = func_2(value);
			if (num3 <= 0)
			{
				uint_0 = null;
				int_1 = -1;
				bool_0 = false;
				int_2 = -1;
				if (!bool_2)
				{
					bool_2 = true;
				}
				return;
			}
			if (bool_2)
			{
				bool_2 = false;
				array3 = func_1(value);
				if (array3 != null && array3.Length >= 2)
				{
					int_1 = method_4(array3);
					bool_0 = smethod_1(int_1, list_0.Count);
					int_2 = -1;
					uint_0 = null;
					uint[] array4 = list_0[int_1];
					Class75.smethod_52(value, "<bclr=red><color=white>[TBTkeoxe]:<bclr=blue><color=white>§· vµo chiÕn ®Êu, di chuyÓn ®Õn to¹ ®é gÇn nhÊt: (" + array4[0] + ", " + array4[1] + ")");
				}
				else
				{
					int_1 = -1;
					bool_0 = false;
					int_2 = -1;
				}
			}
			else
			{
				array3 = func_1(value);
			}
		}
		if (array3 == null)
		{
			array3 = func_1(value);
		}
		if (array3 != null && array3.Length >= 2)
		{
			if (int_1 < 0 || int_1 >= list_0.Count)
			{
				int_1 = method_4(array3);
				bool_0 = smethod_1(int_1, list_0.Count);
				int_2 = -1;
				uint_0 = null;
			}
			uint[] array5 = list_0[int_1];
			uint num4 = smethod_0(array3, array5);
			if (num4 <= 5625)
			{
				Class75.smethod_52(value, "<bclr=red><color=white>[TBTkeoxe] :<bclr=blue><color=white>§· ®Õn to¹ ®é: (" + array5[0] + ", " + array5[1] + ")");
				method_3();
				array5 = list_0[int_1];
				int_2 = -1;
			}
			if (int_1 != int_2)
			{
				Class75.smethod_52(value, "<bclr=red><color=white>[TBTkeoxe] :<bclr=blue><color=white>Di chuyÓn ®Õn to¹ ®é tiÕp theo: (" + array5[0] + ", " + array5[1] + ")");
				int_2 = int_1;
			}
			Class13.smethod_1(value, array5);
		}
	}

	private void method_3()
	{
		if (bool_0)
		{
			int_1--;
			if (int_1 < 0)
			{
				if (list_0.Count > 1)
				{
					int_1 = 1;
					bool_0 = false;
				}
				else
				{
					int_1 = 0;
				}
			}
			return;
		}
		int_1++;
		if (int_1 >= list_0.Count)
		{
			if (list_0.Count > 1)
			{
				int_1 = list_0.Count - 2;
				bool_0 = true;
			}
			else
			{
				int_1 = 0;
			}
		}
	}

	private static uint smethod_0(uint[] uint_2, uint[] uint_3)
	{
		if (uint_2 != null && uint_3 != null && uint_2.Length >= 2 && uint_3.Length >= 2)
		{
			long num = (long)uint_2[0] - (long)uint_3[0];
			long num2 = (long)uint_2[1] - (long)uint_3[1];
			return (uint)(num * num + num2 * num2);
		}
		return uint.MaxValue;
	}

	private static bool smethod_1(int int_4, int int_5)
	{
		int num = int_5 - 1 - int_4;
		return num < int_4;
	}

	private int method_4(uint[] uint_2)
	{
		uint num = uint.MaxValue;
		int result = 0;
		for (int i = 0; i < list_0.Count; i++)
		{
			uint num2 = smethod_0(uint_2, list_0[i]);
			if (num2 < num)
			{
				num = num2;
				result = i;
			}
		}
		return result;
	}

	private static void smethod_2(ICollection<uint[]> icollection_0, ListView listView_1)
	{
		foreach (ListViewItem item in listView_1.Items)
		{
			if (item != null && item.SubItems != null && item.SubItems.Count >= 2)
			{
				string[] array = item.SubItems[1].Text.Split(',');
				if (array.Length >= 2 && uint.TryParse(array[0], out var result) && uint.TryParse(array[1], out var result2))
				{
					icollection_0.Add(new uint[2] { result, result2 });
				}
			}
		}
	}

	private void method_5(ICollection<uint[]> icollection_0)
	{
		smethod_2(icollection_0, listView_0);
	}
}
