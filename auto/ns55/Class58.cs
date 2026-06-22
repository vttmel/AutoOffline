using System.Threading;
using ns100;
using ns11;
using ns13;
using ns23;
using ns41;
using ns42;
using ns53;
using ns61;
using ns71;
using ns83;
using ns85;

namespace ns55;

internal class Class58
{
	public static int smethod_0(CharacterAccountConfig characterAccountConfig_0, uint[] uint_0 = null)
	{
		int int_ = characterAccountConfig_0.int_136;
		long long_ = 0L;
		while (true)
		{
			Thread.Sleep(300);
			int num = Class87.smethod_3(Form1.characterAccountConfig_1, int_);
			if (Class11.bool_0 || num < 0 || Class24.smethod_52(Form1.characterAccountConfig_1[num].process_0) || !Form1.characterAccountConfig_1[num].bool_25)
			{
				break;
			}
			characterAccountConfig_0 = Form1.characterAccountConfig_1[num];
			uint num2 = Class24.smethod_30(Class56.memorySignatureScanConfig_11.uint_0, characterAccountConfig_0.int_137);
			uint num3 = Class24.smethod_30(num2 + Class56.memorySignatureScanConfig_13.uint_0, characterAccountConfig_0.int_137) * Class56.memorySignatureScanConfig_15.uint_0;
			uint num4 = Class24.smethod_30(Class56.memorySignatureScanConfig_14.uint_0, characterAccountConfig_0.int_137);
			uint num5 = num4 + num3;
			int num6 = (int)Class24.smethod_30(Class56.memorySignatureScanConfig_27.uint_0, characterAccountConfig_0.int_137);
			int num7 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_55.uint_0, characterAccountConfig_0.int_137);
			int num8 = (int)Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_50.uint_0, characterAccountConfig_0.int_137);
			int num9 = Class89.smethod_39(characterAccountConfig_0);
			if (num8 != 0 && num7 != 0 && num7 != 10 && num7 != 21 && num6 != 0 && num9 > 1)
			{
				uint[] array = new uint[2]
				{
					Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
					Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
				};
				if (array[0] == 0 || array[1] == 0)
				{
					continue;
				}
				uint_0 = Class45.smethod_11(array, num6, "DÞch quan");
				if (uint_0 != null)
				{
					long num10 = Class64.smethod_18(array, uint_0);
					if (num10 >= 90000L)
					{
						uint[,] array2 = Class44.smethod_1(num6, array, uint_0, "DÞch quan");
						if (array2 == null)
						{
							if (!Class13.smethod_3(characterAccountConfig_0) || Class11.smethod_28(long_) > 6000L)
							{
								Class13.smethod_1(characterAccountConfig_0, uint_0);
								long_ = Class11.smethod_27();
							}
						}
						else
						{
							Class64.smethod_22(characterAccountConfig_0, array2, array, uint_0, num6);
						}
						continue;
					}
					int num11 = 0;
					while (num10 > 11500L && num11 < 10)
					{
						array = new uint[2]
						{
							Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_58.uint_0, characterAccountConfig_0.int_137),
							Class24.smethod_30(num5 + Class56.memorySignatureScanConfig_57.uint_0 + Class56.memorySignatureScanConfig_59.uint_0, characterAccountConfig_0.int_137)
						};
						if (Class64.smethod_18(array, uint_0) <= 11500L)
						{
							break;
						}
						Class75.smethod_61(characterAccountConfig_0, uint_0);
						Thread.Sleep(300);
						num11++;
					}
					return 1;
				}
				return -2;
			}
			return -1;
		}
		return 0;
	}
}
