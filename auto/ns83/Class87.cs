using System.Windows.Forms;
using ns1;
using ns11;

namespace ns83;

internal class Class87
{
	public static int smethod_0(ref CharacterAccountConfig[] characterAccountConfig_0, CharacterAccountConfig characterAccountConfig_1)
	{
		if (characterAccountConfig_0 != null && characterAccountConfig_0.Length != 0)
		{
			CharacterAccountConfig[] array = new CharacterAccountConfig[characterAccountConfig_0.Length + 1];
			for (int i = 0; i < characterAccountConfig_0.Length; i++)
			{
				if (characterAccountConfig_1.int_136 != characterAccountConfig_0[i].int_136)
				{
					ref CharacterAccountConfig reference = ref array[i];
					reference = characterAccountConfig_0[i];
					continue;
				}
				characterAccountConfig_0[i] = characterAccountConfig_1;
				return i;
			}
			int num = array.Length - 1;
			array[num] = characterAccountConfig_1;
			characterAccountConfig_0 = array;
			return num;
		}
		characterAccountConfig_0 = new CharacterAccountConfig[1] { characterAccountConfig_1 };
		return 0;
	}

	public static bool smethod_1(ref CharacterAccountConfig[] characterAccountConfig_0, CharacterAccountConfig characterAccountConfig_1)
	{
		if (characterAccountConfig_0 != null && characterAccountConfig_0.Length != 0)
		{
			CharacterAccountConfig[] array = new CharacterAccountConfig[characterAccountConfig_0.Length];
			int num = 0;
			for (int i = 0; i < characterAccountConfig_0.Length; i++)
			{
				if (characterAccountConfig_1.int_136 != characterAccountConfig_0[i].int_136)
				{
					ref CharacterAccountConfig reference = ref array[num];
					reference = characterAccountConfig_0[i];
					num++;
				}
			}
			if (num != 0)
			{
				if (num == characterAccountConfig_0.Length)
				{
					return false;
				}
				CharacterAccountConfig[] array2 = new CharacterAccountConfig[num];
				for (int j = 0; j < num; j++)
				{
					ref CharacterAccountConfig reference2 = ref array2[j];
					reference2 = array[j];
				}
				characterAccountConfig_0 = array2;
				return true;
			}
			characterAccountConfig_0 = null;
			return true;
		}
		characterAccountConfig_0 = null;
		return true;
	}

	public static int smethod_2(ListView listView_0, int int_0, CharacterAccountConfig[] characterAccountConfig_0)
	{
		if (int_0 >= 0 && listView_0.Items.Count > int_0)
		{
			int num = Class11.smethod_11(listView_0.Items[int_0].SubItems[listView_0.Items[int_0].SubItems.Count - 1].Text);
			if (num > 0 && characterAccountConfig_0 != null && characterAccountConfig_0.Length != 0)
			{
				for (int i = 0; i < characterAccountConfig_0.Length; i++)
				{
					if (characterAccountConfig_0[i].int_136 == num)
					{
						return i;
					}
				}
			}
		}
		return -1;
	}

	public static int smethod_3(CharacterAccountConfig[] characterAccountConfig_0, int int_0)
	{
		if (int_0 > 0 && characterAccountConfig_0 != null && characterAccountConfig_0.Length != 0)
		{
			for (int i = 0; i < characterAccountConfig_0.Length; i++)
			{
				if (characterAccountConfig_0[i].int_136 == int_0)
				{
					return i;
				}
			}
		}
		return -1;
	}

	public static int smethod_4(ListView listView_0, MouseEventArgs mouseEventArgs_0, int int_0 = 0)
	{
		try
		{
			ListViewItem itemAt = listView_0.GetItemAt(mouseEventArgs_0.X, mouseEventArgs_0.Y);
			if (itemAt != null)
			{
				string text = itemAt.SubItems[int_0].Text;
				for (int i = 0; i < listView_0.Items.Count; i++)
				{
					string text2 = listView_0.Items[i].SubItems[int_0].Text;
					if (text == text2)
					{
						return i;
					}
				}
			}
		}
		catch
		{
		}
		return -1;
	}

	public static void smethod_5(ListView listView_0, CharacterAccountConfig characterAccountConfig_0)
	{
		string text = Class1.smethod_1(characterAccountConfig_0.string_22, 1) + "|...|...|...|" + characterAccountConfig_0.int_136;
		string[] array = text.Split('|');
		ListViewItem listViewItem = new ListViewItem(array[0]);
		if (array.Length > 1)
		{
			for (int i = 1; i < array.Length; i++)
			{
				ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
				listViewItem.SubItems.Add(item);
			}
		}
		listView_0.Items.Add(listViewItem);
	}

	public static int smethod_6(ListView listView_0, CharacterAccountConfig[] characterAccountConfig_0, int int_0)
	{
		if (int_0 >= 0 && characterAccountConfig_0 != null && int_0 < characterAccountConfig_0.Length)
		{
			string text = characterAccountConfig_0[int_0].int_136.ToString();
			for (int i = 0; i < listView_0.Items.Count; i++)
			{
				if (listView_0.Items[i].SubItems[listView_0.Items[i].SubItems.Count - 1].Text == text)
				{
					return i;
				}
			}
			return -1;
		}
		return -1;
	}

	public static int smethod_7(ListView listView_0, CharacterAccountConfig characterAccountConfig_0)
	{
		string text = characterAccountConfig_0.int_136.ToString();
		int num = 0;
		while (true)
		{
			if (num < listView_0.Items.Count)
			{
				if (listView_0.Items[num].SubItems[listView_0.Items[num].SubItems.Count - 1].Text == text)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public static CharacterAccountConfig smethod_8(ListView listView_0, int int_0, CharacterAccountConfig[] characterAccountConfig_0)
	{
		if (characterAccountConfig_0 != null)
		{
			int num = Class11.smethod_11(listView_0.Items[int_0].SubItems[listView_0.Items[int_0].SubItems.Count - 1].Text);
			for (int i = 0; i < characterAccountConfig_0.Length; i++)
			{
				if (characterAccountConfig_0[i].int_136 == num)
				{
					return characterAccountConfig_0[i];
				}
			}
		}
		return new CharacterAccountConfig
		{
			int_136 = 0,
			string_22 = null
		};
	}

	public static int smethod_9(ListView listView_0, int int_0)
	{
		int index = listView_0.Items[int_0].SubItems.Count - 1;
		return Class11.smethod_11(listView_0.Items[int_0].SubItems[index].Text);
	}

	public static int smethod_10(ListView listView_0, int int_0)
	{
		string text = int_0.ToString();
		int num = 0;
		while (true)
		{
			if (num < listView_0.Items.Count)
			{
				if (listView_0.Items[num].SubItems[listView_0.Items[num].SubItems.Count - 1].Text == text)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}
}
