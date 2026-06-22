using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ns1;
using ns23;
using ns53;

namespace ns11;

internal class Class11
{
	public static char[] char_0 = new char[5] { 'ᒟ', 'ᒞ', 'ᒜ', 'ᒧ', 'ᒦ' };

	public static char[] char_1 = new char[23]
	{
		'ᒱ', 'ᓱ', 'ᓵ', 'ᓡ', 'ᓮ', 'ᓧ', 'ᓣ', 'ᓡ', 'ᓯ', 'ᒯ',
		'ᓋ', 'ᓙ', 'ᓋ', 'ᓥ', 'ᓯ', 'ᓸ', 'ᓥ', 'ᓐ', 'ᓢ', 'ᒮ',
		'ᓴ', 'ᓸ', 'ᓴ'
	};

	public static char[] char_2 = new char[24]
	{
		'ᒲ', 'ᓲ', 'ᓶ', 'ᓢ', 'ᓯ', 'ᓨ', 'ᓤ', 'ᓢ', 'ᓰ', 'ᒰ',
		'ᓌ', 'ᓚ', 'ᓒ', 'ᓶ', 'ᓢ', 'ᓯ', 'ᓨ', 'ᓤ', 'ᓢ', 'ᓰ',
		'ᒯ', 'ᓵ', 'ᓹ', 'ᓵ'
	};

	public static char[] char_3 = new char[22]
	{
		'ᒰ', 'ᓰ', 'ᓴ', 'ᓠ', 'ᓭ', 'ᓦ', 'ᓢ', 'ᓠ', 'ᓮ', 'ᒮ',
		'ᓊ', 'ᓘ', 'ᓌ', 'ᓠ', 'ᓸ', 'ᓯ', 'ᓧ', 'ᓴ', 'ᒭ', 'ᓳ',
		'ᓷ', 'ᓳ'
	};

	public static int int_0 = 0;

	public static char[] char_4 = new char[7] { 'ᓓ', 'ᓝ', 'ᓔ', 'ᒞ', 'ᓕ', 'ᓨ', 'ᓕ' };

	public static char[] char_5 = new char[7] { 'ᒻ', 'ᓉ', 'ᒻ', 'ᒵ', 'ᒿ', 'ᓈ', 'ᒵ' };

	public static char[] char_6 = new char[8] { 'ᒳ', 'ᓀ', 'ᓀ', 'ᓅ', 'ᓃ', 'ᓀ', 'ᓀ', 'ᒾ' };

	public static char[] char_7 = new char[8] { 'ᒡ', 'ᒡ', 'ᒡ', 'ᒡ', 'ᒡ', 'ᒡ', 'ᒡ', 'ᒡ' };

	public static string string_0 = "ᔋᔲᔾᔻᔾᕁᔌᔿᔸᔽᔺᔍᖺᓯᔱᖅᔽᓯᕽᖴᓯᔽᖄᕈᓻᓯᔰᔳᔶᔰᔼᔴᓯᕽᖆᓯᔺᔷᖲᔰᓯᔲᔷᗇᔲᓯᔽᕷᔽᔶᓯᕃᖦᔼᓯᔰᔲᓯᔲᔷᖬᔽᔷᓻᓯᕃᖚᔿᓯᔺᖤᕃᓻᓯᕃᗈᓯᔲᔷᖈᕈᓯᕁᔰᓯᔺᔷᖰᔸᓯᔷᖚᕄᓯᔳᔾᔰᔽᔷᓽᓽᓽ";

	public static char[] char_8 = new char[88]
	{
		'ᔛ', 'ᓹ', 'ᔎ', 'ᔅ', 'ᔥ', 'ᔲ', 'ᔖ', 'ᔇ', 'ᔫ', 'ᔬ',
		'ᔪ', 'ᔑ', 'ᔄ', 'ᓶ', 'ᔋ', 'ᔦ', 'ᔍ', 'ᔣ', 'ᔺ', 'ᔙ',
		'ᔏ', 'ᔑ', 'ᔲ', 'ᓳ', 'ᓱ', 'ᔹ', 'ᔘ', 'ᔇ', 'ᓲ', 'ᔉ',
		'ᔻ', 'ᔌ', 'ᔮ', 'ᔈ', 'ᔬ', 'ᔓ', 'ᔲ', 'ᔖ', 'ᔵ', 'ᔴ',
		'ᔗ', 'ᔄ', 'ᔷ', 'ᓱ', 'ᔄ', 'ᔌ', 'ᔎ', 'ᓺ', 'ᔆ', 'ᔓ',
		'ᔦ', 'ᔗ', 'ᔊ', 'ᔤ', 'ᔨ', 'ᔥ', 'ᔑ', 'ᔉ', 'ᔎ', 'ᓺ',
		'ᔘ', 'ᔈ', 'ᔋ', 'ᓰ', 'ᔤ', 'ᔑ', 'ᔥ', 'ᓰ', 'ᔴ', 'ᓴ',
		'ᔊ', 'ᔖ', 'ᔰ', 'ᔬ', 'ᔣ', 'ᔳ', 'ᔔ', 'ᓷ', 'ᔻ', 'ᔶ',
		'ᔌ', 'ᔹ', 'ᔚ', 'ᔏ', 'ᔆ', 'ᔒ', 'ᓾ', 'ᓾ'
	};

	public static char[] char_9 = new char[14]
	{
		'ᒨ', 'ᒧ', 'ᒧ', 'ᒨ', 'ᒧ', 'ᒧ', 'ᒨ', 'ᒧ', 'ᒧ', 'ᒨ',
		'ᒧ', 'ᒧ', 'ᒨ', 'ᒧ'
	};

	public static char[] char_10 = new char[13]
	{
		'ᓁ', 'ᓏ', 'ᓁ', 'ᓛ', 'ᓥ', 'ᓮ', 'ᓛ', 'ᒻ', 'ᓮ', 'ᒤ',
		'ᓪ', 'ᓮ', 'ᓪ'
	};

	public static char[] char_11 = new char[33]
	{
		'ᓋ', 'ᓮ', 'ᓱ', 'ᓫ', 'ᓷ', 'ᓯ', 'ᒪ', 'ᖛ', 'ᕭ', 'ᒪ',
		'ᓵ', 'ᓲ', 'ᕽ', 'ᓫ', 'ᒪ', 'ᓭ', 'ᓲ', '㍳', 'ᓭ', 'ᒪ',
		'ᓸ', 'ᖍ', 'ᓸ', 'ᓱ', 'ᒪ', 'ᓾ', 'ᓲ', 'ᓯ', 'ᓹ', 'ᒪ',
		'ᓽ', 'ᓫ', 'ᓿ'
	};

	public static char[] char_12 = new char[4] { 'ᒛ', 'ᓡ', 'ᓥ', 'ᓡ' };

	public static char[] char_13 = new char[7] { 'ᓘ', 'ᓤ', 'ᓤ', 'ᓠ', 'ᒪ', 'ᒟ', 'ᒟ' };

	public static char[] char_14 = new char[12]
	{
		'ᒱ', 'ᓨ', 'ᓥ', 'ᓖ', 'ᓣ', 'ᒕ', 'ᓞ', 'ᓙ', 'ᒲ', 'ᓩ',
		'ᒦ', 'ᒳ'
	};

	public static char[] char_15 = new char[17]
	{
		'ᓎ', 'ᓢ', 'ᕮ', 'ᓨ', 'ᓡ', 'ᒚ', 'ᓮ', 'ᓣ', 'ᓨ', 'ᒚ',
		'ᖋ', 'ᕽ', 'ᓨ', 'ᓡ', 'ᒚ', 'ᓥ', 'ᕷ'
	};

	public static char[] char_16 = new char[34]
	{
		'ᓎ', 'ᓳ', 'ᘻ', 'ᓬ', 'ᒫ', 'ᖜ', 'ᖎ', 'ᓹ', 'ᓲ', 'ᒫ',
		'ᓶ', 'ᖈ', 'ᒫ', 'ᓳ', 'ᓺ', '㍂', 'ᓮ', 'ᒫ', 'ᓳ', '㍊',
		'ᓿ', 'ᒫ', 'ᓳ', '㌬', 'ᓹ', 'ᒫ', 'ᓾ', '㍸', 'ᒫ', 'ᓯ',
		'㍰', 'ᓹ', 'ᓲ', 'ᒹ'
	};

	public static char[] char_17 = new char[18]
	{
		'ᓞ', 'ᓣ', 'ᘫ', 'ᓜ', 'ᒛ', 'ᓦ', 'ᓤ', '㌾', 'ᓨ', 'ᒛ',
		'ᓯ', 'ᓭ', 'ᓜ', 'ᒛ', 'ᖌ', 'ᘫ', '㍞', 'ᓞ'
	};

	public static char[] char_18 = new char[28]
	{
		'ᓙ', 'ᓭ', 'ᕹ', 'ᓳ', 'ᓬ', 'ᒥ', 'ᓹ', 'ᓮ', 'ᓳ', 'ᒥ',
		'ᒭ', 'ᓱ', 'ᓮ', 'ᓨ', 'ᒥ', 'ᓰ', 'ᓭ', 'ᕹ', 'ᓳ', 'ᓬ',
		'ᒥ', 'ᓭ', '㍨', 'ᓵ', 'ᒥ', 'ᓱ', '㍌', 'ᒮ'
	};

	public static char[] char_19 = new char[5] { 'ᒶ', 'ᓁ', 'ᒲ', 'ᒨ', 'ᒎ' };

	public static char[] char_20 = new char[5] { 'ᒎ', 'ᓜ', 'ᓕ', 'ᕎ', 'ᓧ' };

	public static char[] char_21 = new char[4] { 'ᒶ', 'ᒱ', 'ᒧ', 'ᒍ' };

	public static char[] char_22 = new char[68]
	{
		'ᓯ', '㍒', 'ᔚ', 'ᓍ', 'ᔛ', 'ᖧ', 'ᔡ', 'ᓍ', 'ᔈ', 'ᓮ',
		'ᔊ', 'ᓍ', 'ᖾ', '㍰', 'ᓍ', 'ᖖ', 'ᔝ', 'ᓍ', 'ᔡ', 'ᖗ',
		'ᔛ', 'ᓍ', 'ᔎ', 'ᔐ', 'ᓍ', 'ᔣ', 'ᖍ', 'ᔜ', 'ᓍ', 'ᔎ',
		'ᔢ', 'ᔡ', 'ᔜ', 'ᓛ', 'ᓍ', 'ᓯ', '㍒', 'ᔚ', 'ᓍ', 'ᔝ',
		'ᔕ', '㎒', 'ᓍ', 'ᔡ', 'ᔟ', '㎐', 'ᓍ', 'ᖾ', '㍰', 'ᓍ',
		'ᔥ', 'ᔒ', 'ᔚ', 'ᓍ', 'ᔝ', 'ᔕ', 'ᔖ', 'ᔚ', 'ᓍ', 'ᔕ',
		'ᙝ', '㎈', 'ᔛ', 'ᔔ', 'ᓍ', 'ᔑ', '㍘', 'ᔛ'
	};

	public static char[] char_23 = new char[108]
	{
		'ᔦ', 'ᔊ', 'ᔤ', 'ᔗ', 'ᕉ', 'ᔍ', 'ᔽ', 'ᔗ', 'ᔪ', 'ᕌ',
		'ᔟ', 'ᕊ', 'ᔡ', 'ᔿ', 'ᕂ', 'ᔧ', 'ᕉ', 'ᔬ', 'ᕍ', 'ᔻ',
		'ᕊ', 'ᕇ', 'ᔙ', 'ᔋ', 'ᕉ', 'ᔋ', 'ᔗ', 'ᕄ', 'ᔖ', 'ᔡ',
		'ᔞ', 'ᔤ', 'ᔹ', 'ᔈ', 'ᔗ', 'ᔹ', 'ᕊ', 'ᕄ', 'ᕁ', 'ᔛ',
		'ᔦ', 'ᔅ', 'ᕆ', 'ᔞ', 'ᔞ', 'ᔎ', 'ᔟ', 'ᕏ', 'ᔆ', 'ᕇ',
		'ᔫ', 'ᔄ', 'ᔉ', 'ᕅ', 'ᔆ', 'ᔟ', 'ᔍ', 'ᔻ', 'ᕎ', 'ᔎ',
		'ᔾ', 'ᔾ', 'ᔼ', 'ᕇ', 'ᔜ', 'ᕂ', 'ᔛ', 'ᔞ', 'ᕄ', 'ᔨ',
		'ᔮ', 'ᕁ', 'ᔌ', 'ᔷ', 'ᕄ', 'ᕅ', 'ᔅ', 'ᕊ', 'ᔊ', 'ᔯ',
		'ᔜ', 'ᔄ', 'ᔨ', 'ᔭ', 'ᔘ', 'ᔠ', 'ᔈ', 'ᔝ', 'ᔆ', 'ᔙ',
		'ᔛ', 'ᔣ', 'ᔭ', 'ᔫ', 'ᔅ', 'ᕎ', 'ᔭ', 'ᕌ', 'ᔋ', 'ᔿ',
		'ᕋ', 'ᕌ', 'ᔌ', 'ᔻ', 'ᔚ', 'ᔺ', 'ᔪ', 'ᔒ'
	};

	public static string string_1 = "ᒘ";

	public static string string_2 = "ᒖ";

	public static string string_3 = "ᓦ";

	public static string string_4 = "ᒙ";

	public static string string_5 = "ᒗ";

	public static string string_6 = "ᓉ";

	public static string string_7 = "ᒤ";

	public static string string_8 = "ᒒ";

	public static string string_9 = "ᒓ";

	public static string string_10 = "ᒔ";

	public static string string_11 = "ᓅ";

	public static string string_12 = "ᓇ";

	public static string string_13 = "ᒚ";

	public static char[] char_24 = new char[4] { 'ᓘ', 'ᓖ', 'ᓚ', 'ᓦ' };

	public static string string_14 = "ᓔᒿᒽᓼᓕᓴᓷᓗᓗᓝᓪᓔᓜᓜᓷᓔᓕᓎᓼᓽᓔᓸᒾᓓᓕᓞᓴᓐᓊᓊᓆᓆ";

	public static string[] string_15 = new string[2] { "ᓲᒱᒰᓆᓫᓎᓳᓇᒩᒱᓭᓅᓅᓊᒾᒺ", "ᓲᒱᒰᓆᓫᓎᓳᓇᒩᒱᓯᓆᓌᓰᓆᒺ" };

	public static char[] char_25 = new char[2] { 'ᓓ', 'ᒕ' };

	public static char[] char_26 = new char[4] { 'ᓕ', 'ᒗ', 'ᒛ', 'ᒗ' };

	public static char[] char_27 = new char[5] { 'ᒾ', 'ᒶ', 'ᒽ', 'ᓂ', 'ᒽ' };

	public static char[] char_28 = new char[9] { 'ᓇ', 'ᓆ', 'ᒵ', 'ᒚ', 'ᓀ', 'ᒻ', 'ᓅ', 'ᓆ', 'ᒛ' };

	public static char[] char_29 = new char[17]
	{
		'ᓳ', 'ᓳ', 'ᒧ', 'ᓇ', 'ᓇ', 'ᒧ', 'ᓞ', 'ᓞ', 'ᒚ', 'ᓂ',
		'ᓂ', 'ᒴ', 'ᓧ', 'ᓧ', 'ᒴ', 'ᓭ', 'ᓭ'
	};

	public static char[] char_30 = new char[71]
	{
		'ᓾ', 'ᔗ', 'ᕥ', 'ᔩ', 'ᓐ', 'ᔗ', 'ᔙ', 'ᖚ', 'ᓐ', 'ᔓ',
		'ᖡ', 'ᔑ', 'ᓐ', 'ᔝ', 'ᕨ', 'ᔩ', 'ᓐ', 'ᔤ', 'ᖍ', 'ᔞ',
		'ᔘ', 'ᓐ', 'ᔒ', 'ᖎ', 'ᓐ', 'ᔣ', 'ᔑ', 'ᔙ', 'ᓜ', 'ᓐ',
		'ᔘ', 'ᕧ', 'ᔩ', 'ᓐ', 'ᕞ', 'ᔙ', 'ᖂ', 'ᔥ', 'ᓐ', 'ᔓ',
		'ᔘ', 'ᖈ', 'ᔞ', 'ᔘ', 'ᓐ', 'ᔜ', 'ᕩ', 'ᔙ', 'ᓐ', 'ᔝ',
		'ᖝ', 'ᔙ', 'ᓐ', 'ᔣ', 'ᖦ', 'ᓐ', 'ᔔ', 'ᖤ', 'ᔞ', 'ᔗ',
		'ᓐ', 'ᕞ', 'ᕝ', 'ᖞ', 'ᔓ', 'ᓐ', 'ᔑ', 'ᔥ', 'ᔤ', 'ᔟ',
		'ᓞ'
	};

	public static char[] char_31 = new char[11]
	{
		'ᒿ', 'ᓍ', 'ᒿ', 'ᓙ', 'ᓣ', 'ᓬ', 'ᓙ', 'ᒢ', 'ᓨ', 'ᓬ',
		'ᓨ'
	};

	public static char[] char_32 = new char[15]
	{
		'ᓄ', 'ᓁ', 'ᒻ', 'ᓗ', 'ᓃ', 'ᓑ', 'ᓃ', 'ᓝ', 'ᓧ', 'ᓰ',
		'ᓝ', 'ᒦ', 'ᓬ', 'ᓰ', 'ᓬ'
	};

	public static char[] char_33 = new char[80]
	{
		'ᔟ', 'ᔨ', 'ᔫ', 'ᓙ', 'ᓞ', 'ᔚ', 'ᓙ', 'ᔢ', 'ᔧ', 'ᓙ',
		'ᓡ', 'ᔰ', 'ᓥ', 'ᔳ', 'ᓥ', 'ᔲ', 'ᓥ', 'ᔱ', 'ᓥ', 'ᔯ',
		'ᓥ', 'ᔮ', 'ᓥ', 'ᔭ', 'ᓥ', 'ᔬ', 'ᓥ', 'ᔫ', 'ᓥ', 'ᔪ',
		'ᓥ', 'ᔩ', 'ᓥ', 'ᔨ', 'ᓥ', 'ᔧ', 'ᓥ', 'ᔦ', 'ᓥ', 'ᔥ',
		'ᓥ', 'ᔤ', 'ᓥ', 'ᔠ', 'ᓥ', 'ᔢ', 'ᓥ', 'ᔡ', 'ᓥ', 'ᔠ',
		'ᓥ', 'ᔟ', 'ᓥ', 'ᔞ', 'ᓥ', 'ᔝ', 'ᓥ', 'ᔜ', 'ᓢ', 'ᓙ',
		'ᔝ', 'ᔨ', 'ᓙ', 'ᔝ', 'ᔞ', 'ᔥ', 'ᓙ', 'ᓞ', 'ᔚ', 'ᓳ',
		'ᔕ', 'ᓣ', 'ᓧ', 'ᓣ', 'ᓨ', 'ᔬ', 'ᓨ', 'ᔟ', 'ᓨ', 'ᔪ'
	};

	public static char[] char_34 = new char[58]
	{
		'ᓰ', 'ᓨ', 'ᓶ', 'ᓶ', 'ᓝ', 'ᓥ', '㍄', 'ᔑ', 'ᓃ', 'ᖴ',
		'ᔄ', 'ᔑ', 'ᔊ', 'ᓃ', 'ᔖ', '㎐', 'ᓃ', 'ᔇ', '㎈', 'ᔑ',
		'ᔊ', 'ᓃ', 'ᔆ', 'ᔕ', 'ᔄ', 'ᔆ', 'ᔎ', 'ᓃ', 'ᔄ', 'ᔘ',
		'ᔗ', 'ᔒ', 'ᓏ', 'ᓃ', 'ᔅ', '㍄', 'ᔑ', 'ᓃ', 'ᔆ', 'ᖃ',
		'ᔌ', 'ᓃ', 'ᔏ', '㍄', 'ᔌ', 'ᓃ', 'ᓺ', 'ᔌ', 'ᔑ', 'ᔇ',
		'ᔒ', 'ᔚ', 'ᔖ', 'ᓃ', 'ᔑ', 'ᔋ', 'ᖌ', 'ᓑ'
	};

	public static char[] char_35 = new char[86]
	{
		'ᔋ', '㎖', 'ᔨ', 'ᓟ', 'ᔪ', 'ᔧ', 'ᖳ', 'ᔭ', 'ᔦ', 'ᓟ',
		'ᔷ', 'ᖠ', 'ᔢ', 'ᓟ', 'ᗐ', '㎊', 'ᔭ', 'ᔧ', 'ᓟ', 'ᗐ',
		'ᙯ', '㎢', 'ᔢ', 'ᓟ', 'ᔯ', 'ᔧ', 'ᔨ', 'ᖩ', 'ᔭ', 'ᓟ',
		'ᔡ', '㍢', 'ᔭ', 'ᓟ', 'ᔠ', 'ᔴ', 'ᔳ', 'ᔮ', 'ᓟ', 'ᗐ',
		'ᔠ', 'ᔭ', 'ᔦ', 'ᓟ', 'ᔲ', '㎬', 'ᓟ', 'ᔣ', '㎤', 'ᔭ',
		'ᔦ', 'ᓟ', 'ᔧ', 'ᔮ', '㍶', 'ᔢ', 'ᓟ', 'ᔠ', 'ᔴ', 'ᔳ',
		'ᔮ', 'ᓟ', 'ᗐ', 'ᖢ', 'ᓟ', 'ᔢ', 'ᖲ', 'ᓟ', 'ᔯ', 'ᔧ',
		'ᔨ', 'ᖩ', 'ᔭ', 'ᓟ', 'ᔡ', '㍢', 'ᔭ', 'ᓟ', 'ᔬ', '㎚',
		'ᔨ', 'ᓟ', 'ᔧ', 'ᙠ', 'ᔭ', 'ᓭ'
	};

	public static char[] char_36 = new char[114]
	{
		'ᔗ', 'ᔾ', 'ᕊ', 'ᕇ', 'ᕊ', 'ᕍ', 'ᔘ', 'ᕒ', 'ᕃ', 'ᕄ',
		'ᕏ', 'ᕀ', 'ᔙ', 'ᔞ', 'ᕃ', 'ᖈ', 'ᔼ', 'ᓻ', 'ᖉ', 'ᖃ',
		'ᕉ', 'ᕂ', 'ᓻ', 'ᕆ', 'ᗘ', 'ᔕ', 'ᓻ', 'ᔗ', 'ᔾ', 'ᕊ',
		'ᕇ', 'ᕊ', 'ᕍ', 'ᔘ', 'ᕔ', 'ᕀ', 'ᕇ', 'ᕇ', 'ᕊ', 'ᕒ',
		'ᔙ', 'ᔞ', 'ᕃ', 'ᖈ', 'ᔼ', 'ᓻ', 'ᖉ', 'ᖃ', 'ᕉ', 'ᕂ',
		'ᓻ', 'ᕆ', 'ᗘ', 'ᓻ', 'ᕎ', 'ᗑ', 'ᓻ', 'ᔿ', 'ᗏ', 'ᕉ',
		'ᕂ', 'ᓻ', 'ᕉ', 'ᖅ', 'ᕉ', 'ᓻ', 'ᕆ', 'ᕃ', 'ᖆ', 'ᕉ',
		'ᕂ', 'ᓻ', 'ᕏ', 'ᕃ', 'ᖮ', 'ᓻ', 'ᔿ', 'ᗊ', 'ᕉ', 'ᕂ',
		'ᓻ', 'ᖉ', 'ᖈ', 'ᗉ', 'ᔾ', 'ᔇ', 'ᓻ', 'ᕇ', 'ᕄ', 'ᖅ',
		'ᕉ', 'ᓻ', 'ᕃ', 'ᖱ', 'ᓻ', 'ᔦ', 'ᕄ', 'ᕈ', 'ᓻ', 'ᔴ',
		'ᖰ', 'ᕉ', 'ᓻ', 'ᖉ', 'ᖮ', 'ᓻ', 'ᖉ', 'ᖃ', 'ᕉ', 'ᕂ',
		'ᓻ', 'ᕆ', 'ᗘ', 'ᔉ'
	};

	public static char[] char_37 = new char[110]
	{
		'ᔓ', 'ᔺ', 'ᕆ', 'ᕃ', 'ᕆ', 'ᕉ', 'ᔔ', 'ᕎ', 'ᔿ', 'ᕀ',
		'ᕋ', 'ᔼ', 'ᔕ', 'ᔚ', 'ᔿ', 'ᖄ', 'ᔸ', 'ᓷ', 'ᖅ', 'ᕿ',
		'ᕅ', 'ᔾ', 'ᓷ', 'ᕂ', 'ᗔ', 'ᔑ', 'ᓷ', 'ᔓ', 'ᔺ', 'ᕆ',
		'ᕃ', 'ᕆ', 'ᕉ', 'ᔔ', 'ᕐ', 'ᔼ', 'ᕃ', 'ᕃ', 'ᕆ', 'ᕎ',
		'ᔕ', 'ᔣ', 'ᔠ', 'ᔚ', 'ᓷ', 'ᖅ', 'ᕿ', 'ᕅ', 'ᔾ', 'ᓷ',
		'ᕂ', 'ᗔ', 'ᓷ', 'ᔺ', 'ᖺ', 'ᓷ', 'ᕄ', 'ᖎ', 'ᓷ', 'ᕏ',
		'ᖏ', 'ᔺ', 'ᓷ', 'ᕋ', 'ᔿ', 'ᗐ', 'ᔺ', 'ᓷ', 'ᕂ', 'ᔿ',
		'ᖂ', 'ᕅ', 'ᔾ', 'ᓷ', 'ᖅ', 'ᗊ', 'ᕅ', 'ᔾ', 'ᔃ', 'ᓷ',
		'ᕃ', 'ᕀ', 'ᖁ', 'ᕅ', 'ᓷ', 'ᔿ', 'ᖭ', 'ᓷ', 'ᔢ', 'ᕀ',
		'ᕄ', 'ᓷ', 'ᔰ', 'ᖬ', 'ᕅ', 'ᓷ', 'ᖅ', 'ᖪ', 'ᓷ', 'ᖅ',
		'ᕀ', 'ᖩ', 'ᕌ', 'ᓷ', 'ᔺ', 'ᔿ', 'ᖯ', 'ᕅ', 'ᔿ', 'ᔅ'
	};

	public static char[] char_38 = new char[112]
	{
		'ᔕ', 'ᔼ', 'ᕈ', 'ᕅ', 'ᕈ', 'ᕋ', 'ᔖ', 'ᕐ', 'ᕁ', 'ᕂ',
		'ᕍ', 'ᔾ', 'ᔗ', 'ᔥ', 'ᗀ', 'ᕂ', 'ᓹ', 'ᕑ', 'ᖑ', 'ᔼ',
		'ᓹ', 'ᕍ', 'ᕁ', 'ᗒ', 'ᔼ', 'ᔓ', 'ᓹ', 'ᔢ', 'ᔩ', 'ᓹ',
		'ᕀ', 'ᔺ', 'ᕆ', 'ᔾ', 'ᓹ', 'ᕄ', 'ᕁ', 'ᖑ', 'ᔼ', 'ᓹ',
		'ᕏ', 'ᗆ', 'ᕂ', 'ᓹ', 'ᔢ', 'ᔩ', 'ᓹ', 'ᖇ', 'ᖐ', 'ᓹ',
		'ᖇ', 'ᖁ', 'ᕇ', 'ᕀ', 'ᓹ', 'ᕄ', 'ᗖ', 'ᓹ', 'ᕍ', 'ᕋ',
		'ᕈ', 'ᕇ', 'ᕀ', 'ᓹ', 'ᕅ', 'ᕂ', 'ᔼ', 'ᓹ', 'ᔻ', 'ᔺ',
		'ᕇ', 'ᕀ', 'ᓹ', 'ᕁ', 'ᗂ', 'ᕂ', 'ᔅ', 'ᓹ', 'ᕁ', 'ᖐ',
		'ᕒ', 'ᓹ', 'ᕅ', 'ᕂ', 'ᖃ', 'ᕇ', 'ᓹ', 'ᕁ', 'ᖯ', 'ᓹ',
		'ᔤ', 'ᕂ', 'ᕆ', 'ᓹ', 'ᔲ', 'ᖮ', 'ᕇ', 'ᓹ', 'ᖇ', 'ᖬ',
		'ᓹ', 'ᖇ', 'ᕂ', 'ᖫ', 'ᕎ', 'ᓹ', 'ᔼ', 'ᕁ', 'ᖱ', 'ᕇ',
		'ᕁ', 'ᔇ'
	};

	public static char[] char_39 = new char[30]
	{
		'ᓃ', 'ᓪ', 'ᓶ', 'ᓳ', 'ᓶ', 'ᓹ', 'ᓄ', 'ᓾ', 'ᓯ', 'ᓰ',
		'ᓻ', 'ᓬ', 'ᓅ', 'ᓈ', 'ᓼ', 'ᓻ', 'ᓶ', 'ᒧ', 'ᔵ', 'ᓨ',
		'ᓵ', 'ᓮ', 'ᒧ', 'ᓪ', 'ᓯ', 'ᕀ', 'ᔀ', 'ᒵ', 'ᒵ', 'ᒵ'
	};

	public static string string_16 = "<color=white>Auto kÝch ho¹t thµnh c«ng, Mäi lçi lÇm vui long nh¾n tin trùc tiÕp zalo An Dzai";

	public static char[] char_40 = new char[40]
	{
		'ᓷ', 'ᔀ', 'ᔃ', 'ᒱ', 'ᒶ', 'ᓲ', 'ᒱ', 'ᓺ', 'ᓿ', 'ᒱ',
		'ᒹ', 'ᓷ', 'ᒽ', 'ᓶ', 'ᒽ', 'ᓵ', 'ᒽ', 'ᓴ', 'ᒺ', 'ᒱ',
		'ᓵ', 'ᔀ', 'ᒱ', 'ᓵ', 'ᓶ', 'ᓽ', 'ᒱ', 'ᒶ', 'ᓲ', 'ᓋ',
		'ᓭ', 'ᒻ', 'ᒿ', 'ᒻ', 'ᓀ', 'ᔄ', 'ᓀ', 'ᓷ', 'ᓀ', 'ᔂ'
	};

	public static char[] char_41 = new char[152]
	{
		'ᔱ', 'ᕆ', 'ᕴ', 'ᕸ', 'ᕎ', 'ᕭ', 'ᕢ', 'ᕱ', 'ᕈ', 'ᕅ',
		'ᕫ', 'ᕰ', 'ᕩ', 'ᕉ', 'ᔴ', 'ᕔ', 'ᕈ', 'ᕻ', 'ᕆ', 'ᕊ',
		'ᕤ', 'ᕗ', 'ᕋ', 'ᔳ', 'ᕈ', 'ᕌ', 'ᕎ', 'ᕤ', 'ᕒ', 'ᔲ',
		'ᕥ', 'ᕪ', 'ᕷ', 'ᕪ', 'ᕨ', 'ᕫ', 'ᕏ', 'ᕕ', 'ᔳ', 'ᕄ',
		'ᕯ', 'ᕶ', 'ᔶ', 'ᕱ', 'ᕮ', 'ᕆ', 'ᕄ', 'ᕅ', 'ᕱ', 'ᔸ',
		'ᕓ', 'ᔵ', 'ᕚ', 'ᕘ', 'ᕉ', 'ᕔ', 'ᕣ', 'ᕬ', 'ᕈ', 'ᕤ',
		'ᕵ', 'ᕪ', 'ᕖ', 'ᔰ', 'ᕪ', 'ᕈ', 'ᕧ', 'ᕬ', 'ᕩ', 'ᕏ',
		'ᕗ', 'ᔶ', 'ᕤ', 'ᕦ', 'ᔸ', 'ᕫ', 'ᕓ', 'ᕘ', 'ᕺ', 'ᕛ',
		'ᕔ', 'ᕈ', 'ᔴ', 'ᕊ', 'ᕋ', 'ᕘ', 'ᕋ', 'ᕋ', 'ᕲ', 'ᕛ',
		'ᔵ', 'ᕺ', 'ᕊ', 'ᔱ', 'ᕸ', 'ᕖ', 'ᕤ', 'ᕻ', 'ᕚ', 'ᔶ',
		'ᕸ', 'ᕂ', 'ᕉ', 'ᕹ', 'ᕗ', 'ᔷ', 'ᕵ', 'ᕳ', 'ᕵ', 'ᕳ',
		'ᕄ', 'ᕴ', 'ᕑ', 'ᔹ', 'ᔰ', 'ᕉ', 'ᕺ', 'ᕒ', 'ᕐ', 'ᕚ',
		'ᕶ', 'ᕅ', 'ᕪ', 'ᕮ', 'ᔰ', 'ᕹ', 'ᕄ', 'ᔶ', 'ᕥ', 'ᕘ',
		'ᕋ', 'ᕗ', 'ᕭ', 'ᕴ', 'ᕬ', 'ᕋ', 'ᕵ', 'ᕤ', 'ᕛ', 'ᕒ',
		'ᕈ', 'ᕰ', 'ᕥ', 'ᔲ', 'ᔲ', 'ᔴ', 'ᔳ', 'ᕐ', 'ᕩ', 'ᕸ',
		'ᔾ', 'ᔾ'
	};

	public static string[] string_17 = null;

	public static bool bool_0 = false;

	public static uint uint_0 = 0u;

	public static uint uint_1 = 0u;

	public static int int_1 = 0;

	public static long long_0 = 0L;

	public static string smethod_0(char[] char_42)
	{
		if (char_42 == null)
		{
			return string.Empty;
		}
		string text = string.Concat(char_42);
		if (char_42[0] > 'ᎇ')
		{
			text = smethod_54(text);
		}
		return text;
	}

	public static int smethod_1(string string_18, object object_0)
	{
		if (string_18 != null && !(string_18 == string.Empty) && object_0 != null)
		{
			string text = object_0.ToString();
			if (!(text == string.Empty))
			{
				int num = string_18.IndexOf(text);
				if (0 <= num)
				{
					return num;
				}
				char[] array = string_18.ToCharArray();
				char[] array2 = text.ToCharArray();
				int num2 = array.Length;
				int num3 = array2.Length;
				for (int i = 0; i < num2; i++)
				{
					if (num2 - i >= num3)
					{
						if (array[i] != array2[0])
						{
							continue;
						}
						if (num3 != 1)
						{
							bool flag = true;
							for (int j = 1; j < num3; j++)
							{
								if (array2[j] != array[i + j])
								{
									flag = false;
									break;
								}
							}
							if (flag)
							{
								return i;
							}
							continue;
						}
						return i;
					}
					return -1;
				}
				return -1;
			}
			return -1;
		}
		return -1;
	}

	public static bool smethod_2(string string_18, string string_19, bool bool_1 = false)
	{
		if (string_18 != null && string_19 != null)
		{
			if (string_18 == string_19)
			{
				return true;
			}
			string text = Class1.smethod_1(string_18, 1).ToUpper();
			string text2 = Class1.smethod_1(string_19, 1).ToUpper();
			if (!(text == text2) && !(text == text2.Replace("*", "")))
			{
				if (bool_1)
				{
					return text == text2 || text == string_19 || string_18 == text2 || text == string_19.ToUpper() || string_18.ToUpper() == text2;
				}
				bool flag = 0 <= smethod_1(string_18, string_19.Replace("*", ""));
				bool flag2 = 0 <= smethod_1(text, text2.Replace("*", ""));
				bool flag3 = 0 <= smethod_1(string_18.ToUpper(), text2.Replace("*", ""));
				bool flag4 = 0 <= smethod_1(text, string_19.ToUpper());
				bool flag5 = 0 <= smethod_1(string_18.ToUpper(), text2);
				return flag || flag2 || flag3 || flag4 || flag5;
			}
			return true;
		}
		return false;
	}

	public static string[] smethod_3(string[] string_18, bool bool_1, bool bool_2 = false)
	{
		if (string_18 != null && string_18.Length != 0)
		{
			for (int i = 0; i < string_18.Length; i++)
			{
				if (string_18[i] != null)
				{
					if (!bool_1)
					{
						string_18[i] = string_18[i].Trim();
					}
					else
					{
						string_18[i] = string_18[i].Replace(" ", string.Empty).Replace("Ù", string.Empty);
					}
					if (bool_2)
					{
						string_18[i] = string_18[i].ToLower();
					}
				}
				else
				{
					string_18[i] = string.Empty;
				}
			}
			return string_18;
		}
		return null;
	}

	public static bool smethod_4(string string_18, byte[] byte_0)
	{
		try
		{
			FileStream fileStream = new FileStream(string_18, FileMode.Create, FileAccess.Write);
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Close();
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static uint smethod_5(uint[] uint_2, uint[] uint_3)
	{
		if (uint_2 != null && uint_3 != null && uint_2[0] != 0 && uint_2[1] != 0 && uint_3[0] != 0 && uint_3[1] != 0)
		{
			long num = (int)(uint_2[0] - uint_3[0]);
			long num2 = (int)(uint_2[1] - uint_3[1]);
			long num3 = num * num + num2 * num2;
			if (num3 == 0L)
			{
				num3 = 1L;
			}
			return (uint)num3;
		}
		return 0u;
	}

	public static uint smethod_6(string string_18)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			uint num = 0u;
			char[] array = string_18.ToCharArray();
			for (uint num2 = 0u; num2 < array.Length; num2++)
			{
				uint num3 = (byte)array[num2];
				if (num3 > 127)
				{
					num3 = 4294967040u + num3;
				}
				uint num4 = num2 + 1;
				num4 *= num3;
				num4 += num;
				num = 2147483659u;
				num3 = num4 % 2147483659u;
				num4 = num3;
				num4 = (uint)(Math.Abs(num4) * -1L);
				num4 <<= 4;
				num4 -= num3;
				num = num4;
			}
			return num ^ 0x12345678;
		}
		return 0u;
	}

	public static string smethod_7(string string_18)
	{
		if (string_18 != null && !(string_18 == string.Empty) && smethod_17(string_18))
		{
			try
			{
				using MD5 mD = MD5.Create();
				using FileStream inputStream = File.OpenRead(string_18);
				return BitConverter.ToString(mD.ComputeHash(inputStream)).Replace("-", string.Empty).ToLower();
			}
			catch
			{
			}
			return string.Empty;
		}
		return string.Empty;
	}

	public static byte[] smethod_8(string string_18, bool bool_1 = true)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			string_18 = string_18.Replace(" ", "");
			if (string_18.Length % 2 == 0 && !(string_18 == ""))
			{
				int num = string_18.Length / 2;
				byte[] array = new byte[num];
				for (int i = 0; i < array.Length; i++)
				{
					string text = string_18.Substring(i * 2, 2);
					if (bool_1 && text == "??")
					{
						array[i] = 63;
					}
					else
					{
						array[i] = byte.Parse(text, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
					}
				}
				return array;
			}
			return null;
		}
		return null;
	}

	public static int smethod_9(string string_18)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			int num = 0;
			for (int i = 0; i < string_18.Length; i++)
			{
				if (string_18[i] >= '0' && string_18[i] <= '9')
				{
					if (string_18[i] != '0' || num > 0)
					{
						num++;
					}
					continue;
				}
				return -1;
			}
			if (num > 0)
			{
				num = smethod_11(string_18);
			}
			return num;
		}
		return -1;
	}

	public static int smethod_10(string string_18, bool bool_1 = false, bool bool_2 = false)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			bool flag = false;
			string text = "0";
			for (int i = 0; i < string_18.Length; i++)
			{
				if ('0' <= string_18[i] && string_18[i] <= '9')
				{
					text += string_18[i];
					flag = true;
				}
				else if (flag && !bool_2)
				{
					break;
				}
			}
			return smethod_11(text);
		}
		return 0;
	}

	public static int smethod_11(string string_18)
	{
		int result = 0;
		if (string_18 != null && string_18 != "")
		{
			try
			{
				result = Convert.ToInt32(string_18);
			}
			catch
			{
				result = 0;
			}
		}
		return result;
	}

	public static uint smethod_12(string string_18)
	{
		uint result = 0u;
		if (string_18 != null && string_18 != string.Empty)
		{
			try
			{
				result = Convert.ToUInt32(string_18);
			}
			catch
			{
				result = 0u;
			}
		}
		return result;
	}

	public static void smethod_13(ref string string_18, string string_19, string string_20 = "")
	{
		if (string_20 == "")
		{
			string_20 = Class56.string_7;
		}
		if (string_18 != "")
		{
			string_18 += string_20;
		}
		string_18 += string_19;
	}

	public static string[] smethod_14(string string_18, char char_42 = '\\')
	{
		string[] array = new string[2]
		{
			string.Empty,
			string.Empty
		};
		if (string_18 != null && string_18 != string.Empty)
		{
			string[] array2 = string_18.Split(char_42);
			array[1] = array2[array2.Length - 1];
			for (int i = 0; i < array2.Length - 1; i++)
			{
				string[] array3;
				if (array[0] != string.Empty)
				{
					(array3 = array)[0] = array3[0] + char_42;
				}
				(array3 = array)[0] = array3[0] + array2[i];
			}
		}
		return array;
	}

	public static string smethod_15(string string_18)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			try
			{
				byte[] array = Convert.FromBase64String(string_18);
				return Encoding.UTF8.GetString(array, 0, array.Length);
			}
			catch
			{
			}
			return string.Empty;
		}
		return string.Empty;
	}

	public static string smethod_16(string string_18)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			try
			{
				byte[] bytes = Encoding.UTF8.GetBytes(string_18);
				return Convert.ToBase64String(bytes);
			}
			catch
			{
			}
			return string.Empty;
		}
		return string.Empty;
	}

	public static bool smethod_17(string string_18)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			try
			{
				return File.Exists(string_18);
			}
			catch
			{
			}
			return false;
		}
		return false;
	}

	public static string[] smethod_18(string string_18, string string_19 = "*.*", SearchOption searchOption_0 = SearchOption.AllDirectories)
	{
		try
		{
			return Directory.GetFiles(string_18, string_19, searchOption_0);
		}
		catch
		{
		}
		return null;
	}

	public static bool smethod_19(string string_18, string string_19)
	{
		if (string_18 != null && !(string_18 == string.Empty) && string_19 != null && !(string_19 == string.Empty))
		{
			try
			{
				File.Move(string_18, string_19);
				return true;
			}
			catch
			{
			}
			return false;
		}
		return true;
	}

	public static bool smethod_20(string string_18)
	{
		try
		{
			if (File.Exists(string_18))
			{
				File.Delete(string_18);
			}
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_21(string string_18, FileAttributes fileAttributes_0)
	{
		try
		{
			if (File.Exists(string_18))
			{
				File.SetAttributes(string_18, File.GetAttributes(string_18) | fileAttributes_0);
			}
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static int smethod_22(string string_18, string string_19)
	{
		if (!File.Exists(string_18))
		{
			return -1;
		}
		if (File.Exists(string_19) && !smethod_20(string_19))
		{
			Random random = new Random();
			try
			{
				File.Move(string_19, string_19 + "." + random.Next(10000, int.MaxValue));
			}
			catch
			{
				return -2;
			}
		}
		try
		{
			File.Copy(string_18, string_19, overwrite: true);
			return 1;
		}
		catch
		{
		}
		return -3;
	}

	public static void smethod_23(string string_18)
	{
		if (!File.Exists(string_18))
		{
			try
			{
				Directory.CreateDirectory(string_18);
			}
			catch
			{
			}
		}
	}

	public static string[] smethod_24(string string_18, string string_19 = "*.*", SearchOption searchOption_0 = SearchOption.AllDirectories)
	{
		try
		{
			return Directory.GetDirectories(string_18, string_19, searchOption_0);
		}
		catch
		{
		}
		return null;
	}

	public static bool smethod_25(string string_18)
	{
		try
		{
			if (Directory.Exists(string_18))
			{
				Directory.Delete(string_18, recursive: true);
			}
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static void smethod_26(string string_18)
	{
		string[] array = smethod_18(string_18);
		if (array != null && array.Length != 0)
		{
			for (int i = 0; i < array.Length; i++)
			{
				smethod_20(array[i]);
			}
		}
		array = smethod_24(string_18);
		if (array != null && array.Length != 0)
		{
			int num = array.Length;
			for (int j = 0; j < num; j++)
			{
				smethod_25(array[num - j - 1]);
			}
		}
	}

	public static long smethod_27()
	{
		return DateTime.Now.Ticks;
	}

	public static long smethod_28(long long_1)
	{
		TimeSpan timeSpan = new TimeSpan(DateTime.Now.Ticks - long_1);
		return (long)timeSpan.TotalMilliseconds;
	}

	public static void smethod_29(ref string[] string_18, string string_19)
	{
		if (string_18 == null)
		{
			string_18 = new string[1] { string_19 };
			return;
		}
		try
		{
			string[] array = new string[string_18.Length + 1];
			int num = 0;
			while (true)
			{
				if (num < string_18.Length)
				{
					if (!(string_18[num] == string_19))
					{
						array[num] = string_18[num];
						num++;
						continue;
					}
					break;
				}
				array[array.Length - 1] = string_19;
				string_18 = array;
				break;
			}
		}
		catch
		{
		}
	}

	public static void smethod_30(ref string[] string_18, string string_19, bool bool_1 = false)
	{
		if (string_18 != null && string_18.Length != 0)
		{
			int num = 0;
			bool flag = false;
			for (int i = 0; i < string_18.Length; i++)
			{
				if (!(string_18[i] != string_19) && !flag)
				{
					if (bool_1)
					{
						flag = true;
					}
				}
				else
				{
					string_18[num] = string_18[i];
					num++;
				}
			}
			if (num == 0)
			{
				string_18 = null;
			}
			else if (num < string_18.Length)
			{
				Array.Resize(ref string_18, num);
			}
		}
		else
		{
			string_18 = null;
		}
	}

	public static int smethod_31(string[] string_18, string string_19, bool bool_1 = false)
	{
		if (string_18 != null)
		{
			for (int i = 0; i < string_18.Length; i++)
			{
				if (string_19 == string_18[i] || (!bool_1 && (0 <= smethod_1(string_18[i], string_19) || 0 <= smethod_1(string_19, string_18[i]))))
				{
					return i;
				}
			}
		}
		return -1;
	}

	public static bool smethod_32(string string_18)
	{
		bool result = false;
		try
		{
			FileAttributes attributes = File.GetAttributes(string_18);
			return result = (attributes & FileAttributes.Directory) == FileAttributes.Directory;
		}
		catch
		{
			return result;
		}
	}

	public static string smethod_33(string string_18, int int_2 = 0, int int_3 = 0, byte byte_0 = 1)
	{
		if (string_18 != null && !(string_18 == "") && File.Exists(string_18))
		{
			string text = "";
			try
			{
				text = byte_0 switch
				{
					1 => File.ReadAllText(string_18), 
					2 => File.ReadAllText(string_18, Encoding.ASCII), 
					3 => File.ReadAllText(string_18, Encoding.UTF7), 
					4 => File.ReadAllText(string_18, Encoding.UTF8), 
					5 => File.ReadAllText(string_18, Encoding.UTF32), 
					6 => File.ReadAllText(string_18, Encoding.Unicode), 
					_ => File.ReadAllText(string_18, Encoding.Default), 
				};
				if (int_2 > 0)
				{
					text = text.Replace(" ", "");
				}
				if (int_3 > 0)
				{
					text = text.Replace("\n", "");
				}
			}
			catch
			{
				text = "";
			}
			return text;
		}
		return "";
	}

	public static void smethod_34(string string_18, string string_19, byte byte_0 = 1)
	{
		if (string_18 == null || string_18 == "")
		{
			return;
		}
		if (string_19 == null)
		{
			string_19 = "";
		}
		try
		{
			switch (byte_0)
			{
			default:
				File.WriteAllText(string_18, string_19, Encoding.Default);
				break;
			case 1:
				File.WriteAllText(string_18, string_19);
				break;
			case 2:
				File.WriteAllText(string_18, string_19, Encoding.ASCII);
				break;
			case 3:
				File.WriteAllText(string_18, string_19, Encoding.UTF7);
				break;
			case 4:
				File.WriteAllText(string_18, string_19, Encoding.UTF8);
				break;
			case 5:
				File.WriteAllText(string_18, string_19, Encoding.UTF32);
				break;
			case 6:
				File.WriteAllText(string_18, string_19, Encoding.Unicode);
				break;
			}
		}
		catch
		{
		}
	}

	public static string smethod_35(string string_18, string string_19, byte[] byte_0 = null)
	{
		if (string_18 != null && !(string_18 == ""))
		{
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_19, byte_0);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
				using MemoryStream stream = new MemoryStream(Convert.FromBase64String(string_18));
				using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
				using StreamReader streamReader = new StreamReader(stream2);
				return streamReader.ReadToEnd();
			}
			catch
			{
			}
			return string.Empty;
		}
		return string.Empty;
	}

	public static string smethod_36(string string_18, string string_19, byte[] byte_0)
	{
		string result = string.Empty;
		if (!string.IsNullOrEmpty(string_18) && !string.IsNullOrEmpty(string_19))
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			try
			{
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_19, byte_0);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
				using MemoryStream memoryStream = new MemoryStream();
				using (CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
				{
					using StreamWriter streamWriter = new StreamWriter(stream);
					streamWriter.Write(string_18);
				}
				result = Convert.ToBase64String(memoryStream.ToArray());
			}
			finally
			{
				rijndaelManaged?.Clear();
			}
			return result;
		}
		return result;
	}

	public static long smethod_37(string string_18)
	{
		long result = 0L;
		if (string_18 != null && string_18 != "")
		{
			try
			{
				result = Convert.ToInt64(string_18);
			}
			catch
			{
				result = 0L;
			}
		}
		return result;
	}

	public static void smethod_38(ref int[] int_2, int int_3)
	{
		if (int_2 != null && int_2.Length != 0)
		{
			int[] array = new int[int_2.Length + 1];
			int num = 0;
			while (true)
			{
				if (num < int_2.Length)
				{
					if (int_2[num] != int_3)
					{
						array[num] = int_2[num];
						num++;
						continue;
					}
					break;
				}
				array[array.Length - 1] = int_3;
				int_2 = array;
				break;
			}
		}
		else
		{
			int_2 = new int[1] { int_3 };
		}
	}

	public static void smethod_39(ref int[] int_2, int int_3)
	{
		if (int_2 != null && int_2.Length != 0)
		{
			int num = 0;
			int[] array = new int[int_2.Length];
			for (int i = 0; i < int_2.Length; i++)
			{
				if (int_2[i] != int_3)
				{
					array[num] = int_2[i];
					num++;
				}
			}
			if (num == 0)
			{
				int_2 = null;
			}
			else if (num < int_2.Length)
			{
				int[] array2 = new int[num];
				for (int j = 0; j < num; j++)
				{
					array2[j] = array[j];
				}
				int_2 = array2;
			}
		}
		else
		{
			int_2 = null;
		}
	}

	public static int smethod_40(ref long[,] long_1, int int_2 = 1, int int_3 = 2)
	{
		if (int_2 < 1)
		{
			int_2 = 1;
		}
		if (long_1 == null)
		{
			if (int_3 > 0)
			{
				long_1 = new long[int_2, int_3];
			}
			return int_2;
		}
		int length = long_1.GetLength(0);
		int_3 = long_1.GetLength(1);
		long[,] array = new long[length + int_2, int_3];
		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < int_3; j++)
			{
				array[i, j] = long_1[i, j];
			}
		}
		long_1 = array;
		return length + int_2;
	}

	public static void smethod_41(ref uint[] uint_2, uint uint_3)
	{
		if (uint_2 != null && uint_2.Length != 0)
		{
			uint[] array = new uint[uint_2.Length + 1];
			int num = 0;
			while (true)
			{
				if (num < uint_2.Length)
				{
					if (uint_2[num] != uint_3)
					{
						array[num] = uint_2[num];
						num++;
						continue;
					}
					break;
				}
				array[array.Length - 1] = uint_3;
				uint_2 = array;
				break;
			}
		}
		else
		{
			uint_2 = new uint[1] { uint_3 };
		}
	}

	public static bool smethod_42(ref uint[] uint_2, uint uint_3)
	{
		if (uint_2 != null && uint_2.Length != 0)
		{
			int num = 0;
			uint[] array = new uint[uint_2.Length];
			for (int i = 0; i < uint_2.Length; i++)
			{
				if (uint_2[i] != uint_3)
				{
					array[num] = uint_2[i];
					num++;
				}
			}
			if (num == 0)
			{
				uint_2 = null;
				return true;
			}
			if (num >= uint_2.Length)
			{
				return false;
			}
			uint[] array2 = new uint[num];
			for (int j = 0; j < num; j++)
			{
				array2[j] = array[j];
			}
			uint_2 = array2;
			return true;
		}
		uint_2 = null;
		return false;
	}

	public static int smethod_43(int[] int_2, int int_3)
	{
		if (int_2 != null)
		{
			for (int i = 0; i < int_2.Length; i++)
			{
				if (int_2[i] == int_3)
				{
					return i;
				}
			}
		}
		return -1;
	}

	public static int smethod_44(int[,] int_2, int int_3, int int_4)
	{
		if (int_2 != null)
		{
			for (int i = 0; i < int_2.GetLength(0); i++)
			{
				if (int_2[i, int_4] == int_3)
				{
					return i;
				}
			}
		}
		return -1;
	}

	public static string smethod_45(string string_18)
	{
		string text = "";
		if (string_18 != null)
		{
			for (int i = 0; i < string_18.Length; i++)
			{
				char c = string_18[i];
				text = (((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && (c < '0' || c > '9')) ? (text + (byte)c) : (text + c));
			}
		}
		return text;
	}

	public static string smethod_46(object object_0, int int_2 = 8, bool bool_1 = true, bool bool_2 = false)
	{
		string text = string.Empty;
		if (object_0 == null || object_0.ToString() == "")
		{
			object_0 = "00";
		}
		try
		{
			long num = Convert.ToInt64(object_0);
			if (num >= 0L)
			{
				text = long.Parse(num.ToString()).ToString("x").ToUpper();
			}
			else
			{
				int num2 = 4;
				byte[] bytes = BitConverter.GetBytes(num);
				if (bytes.Length == 8 && (bytes[4] != byte.MaxValue || bytes[5] != byte.MaxValue || bytes[6] != byte.MaxValue || bytes[7] != byte.MaxValue))
				{
					num2 = 8;
				}
				int num3 = bytes.Length;
				byte[] array = new byte[num2];
				for (int i = 0; i < num2; i++)
				{
					int num4 = num2 - i - 1;
					if (num3 <= num4)
					{
						break;
					}
					array[i] = bytes[num4];
				}
				text = BitConverter.ToString(array).Replace("-", string.Empty);
			}
		}
		catch
		{
		}
		while (text.Length < int_2)
		{
			text = "0" + text;
		}
		if (bool_2)
		{
			string text2 = "";
			if (text.Length % 2 != 0)
			{
				text = "0" + text;
			}
			while (text != string.Empty)
			{
				text2 += text.Substring(text.Length - 2, 2);
				text = text.Remove(text.Length - 2);
			}
			return text2;
		}
		if (bool_1)
		{
			text = "0x" + text;
		}
		return text;
	}

	public static byte[] smethod_47(string string_18, bool bool_1 = true)
	{
		if (string_18 != null && !(string_18 == ""))
		{
			int num = string_18.Length;
			if (bool_1)
			{
				num++;
			}
			byte[] array = new byte[num];
			char[] array2 = string_18.ToCharArray();
			for (int i = 0; i < array2.Length; i++)
			{
				array[i] = (byte)array2[i];
			}
			if (bool_1)
			{
				array[num - 1] = 0;
			}
			return array;
		}
		if (!bool_1)
		{
			return null;
		}
		return new byte[1];
	}

	public static byte[] smethod_48(string string_18, bool bool_1 = true)
	{
		if (string_18 != null && !(string_18 == ""))
		{
			int num = string_18.Length;
			if (bool_1)
			{
				num++;
			}
			byte[] array = new byte[num * 2];
			char[] array2 = string_18.ToCharArray();
			for (int i = 0; i < array2.Length; i++)
			{
				int num2 = array2[i];
				array[i * 2] = (byte)(num2 % 256);
				array[i * 2 + 1] = (byte)(num2 / 256);
			}
			return array;
		}
		if (!bool_1)
		{
			return null;
		}
		return new byte[2];
	}

	public static int smethod_49(string string_18, string string_19)
	{
		int num = 0;
		int startIndex = 0;
		while ((startIndex = string_18.IndexOf(string_19, startIndex)) != -1)
		{
			startIndex += string_19.Length;
			num++;
		}
		return num;
	}

	public static long[] smethod_50(string string_18, string string_19 = "*.*")
	{
		long num = 0L;
		long num2 = 0L;
		try
		{
			string[] files = Directory.GetFiles(string_18, string_19);
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(files[i]);
					num2++;
					num += fileInfo.Length;
					File.Delete(files[i]);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return new long[2] { num2, num };
	}

	public static bool smethod_51(string string_18, byte[] byte_0)
	{
		try
		{
			File.WriteAllBytes(string_18, byte_0);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static void smethod_52(string string_18, string string_19, bool bool_1)
	{
		if (string_18 == null || string_18 == string.Empty || !smethod_17(string_18))
		{
			return;
		}
		byte[] array = null;
		try
		{
			array = File.ReadAllBytes(string_18);
		}
		catch
		{
		}
		if (array == null || array.Length < 2)
		{
			return;
		}
		int num = array.Length;
		if (bool_1)
		{
			if (array[num - 2] != 254 || array[num - 1] != byte.MaxValue)
			{
				return;
			}
		}
		else if (array[num - 2] != 0 || array[num - 1] != 0)
		{
			return;
		}
		for (long num2 = 0L; num2 < num - 2; num2++)
		{
			if (array[num2] < 128)
			{
				array[num2] += 128;
			}
			else
			{
				array[num2] -= 128;
			}
		}
		if (!bool_1)
		{
			array[num - 2] = 254;
			array[num - 1] = byte.MaxValue;
		}
		else
		{
			array[num - 2] = 0;
			array[num - 1] = 0;
		}
		try
		{
			File.WriteAllBytes(string_19, array);
		}
		catch
		{
		}
	}

	public static byte[] smethod_53(byte[] byte_0, bool bool_1)
	{
		if (byte_0 != null && byte_0.Length >= 2)
		{
			int num = byte_0.Length;
			if (!bool_1)
			{
				if (byte_0[num - 2] != 0 || byte_0[num - 1] != 0)
				{
					return byte_0;
				}
			}
			else if (byte_0[num - 2] != 254 || byte_0[num - 1] != byte.MaxValue)
			{
				return byte_0;
			}
			for (long num2 = 0L; num2 < num - 2; num2++)
			{
				if (byte_0[num2] >= 128)
				{
					byte_0[num2] -= 128;
				}
				else
				{
					byte_0[num2] += 128;
				}
			}
			if (!bool_1)
			{
				byte_0[num - 2] = 254;
				byte_0[num - 1] = byte.MaxValue;
			}
			else
			{
				byte_0[num - 2] = 0;
				byte_0[num - 1] = 0;
			}
			return byte_0;
		}
		return byte_0;
	}

	public static string smethod_54(string string_18)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			string text = string.Empty;
			int length = string_18.Length;
			for (int i = 0; i < string_18.Length; i++)
			{
				char c = string_18[i];
				if (c > 'ᎇ')
				{
					c = (char)(c - (5225 + length));
				}
				text += c;
			}
			return text;
		}
		return string.Empty;
	}

	public static void smethod_55(ref uint[,] uint_2, uint[] uint_3)
	{
		if (uint_2 != null)
		{
			int length = uint_2.GetLength(0);
			int length2 = uint_2.GetLength(1);
			if (uint_3 == null || uint_3.Length == 0 || length2 != uint_3.Length)
			{
				return;
			}
			uint[,] array = new uint[length + 1, length2];
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length2; j++)
				{
					array[i, j] = uint_2[i, j];
				}
			}
			for (int k = 0; k < length2; k++)
			{
				array[length, k] = uint_3[k];
			}
			length = array.GetLength(0);
			uint_2 = new uint[length, length2];
			for (int l = 0; l < length; l++)
			{
				for (int m = 0; m < length2; m++)
				{
					uint_2[l, m] = array[l, m];
				}
			}
		}
		else
		{
			uint_2 = new uint[1, uint_3.Length];
			for (int n = 0; n < uint_3.Length; n++)
			{
				uint_2[0, n] = uint_3[n];
			}
		}
	}

	public static void smethod_56(ref uint[,] uint_2, uint[] uint_3)
	{
		if (uint_2 != null && uint_2.GetLength(0) != 0)
		{
			if (uint_3 == null || uint_3.Length == 0 || uint_2.GetLength(1) != uint_3.Length)
			{
				return;
			}
			int length = uint_2.GetLength(0);
			int length2 = uint_2.GetLength(1);
			int num = 0;
			uint[,] array = new uint[length, length2];
			for (int i = 0; i < length; i++)
			{
				bool flag = true;
				for (int j = 0; j < length2; j++)
				{
					flag = flag && uint_3[j] == uint_2[i, j];
					array[num, j] = uint_2[i, j];
				}
				if (!flag)
				{
					num++;
				}
			}
			if (num != 0)
			{
				if (num >= length)
				{
					return;
				}
				uint_2 = new uint[num, length2];
				for (int k = 0; k < num; k++)
				{
					for (int l = 0; l < length2; l++)
					{
						uint_2[k, l] = array[k, l];
					}
				}
			}
			else
			{
				uint_2 = null;
			}
		}
		else
		{
			uint_2 = null;
		}
	}

	public static void smethod_57(ref long[,] long_1, long[] long_2)
	{
		try
		{
			if (long_1 == null)
			{
				long_1 = new long[1, long_2.Length];
				for (int i = 0; i < long_2.Length; i++)
				{
					long_1[0, i] = long_2[i];
				}
				return;
			}
			int length = long_1.GetLength(0);
			int length2 = long_1.GetLength(1);
			if (long_2 == null || long_2.Length == 0 || length2 != long_2.Length)
			{
				return;
			}
			long[,] array = new long[length + 1, length2];
			for (int j = 0; j < length; j++)
			{
				for (int k = 0; k < length2; k++)
				{
					array[j, k] = long_1[j, k];
				}
			}
			for (int l = 0; l < length2; l++)
			{
				array[length, l] = long_2[l];
			}
			length = array.GetLength(0);
			long_1 = new long[length, length2];
			for (int m = 0; m < length; m++)
			{
				for (int n = 0; n < length2; n++)
				{
					long_1[m, n] = array[m, n];
				}
			}
		}
		catch
		{
		}
	}

	public static void smethod_58(ref long[,] long_1, long[] long_2)
	{
		try
		{
			if (long_1 != null && long_1.GetLength(0) != 0)
			{
				if (long_2 == null || long_2.Length == 0 || long_1.GetLength(1) != long_2.Length)
				{
					return;
				}
				int length = long_1.GetLength(0);
				int length2 = long_1.GetLength(1);
				int num = 0;
				long[,] array = new long[length, length2];
				for (int i = 0; i < length; i++)
				{
					bool flag = true;
					for (int j = 0; j < length2; j++)
					{
						flag = flag && long_2[j] == long_1[i, j];
						array[num, j] = long_1[i, j];
					}
					if (!flag)
					{
						num++;
					}
				}
				if (num == 0)
				{
					long_1 = null;
				}
				else
				{
					if (num >= length)
					{
						return;
					}
					long_1 = new long[num, length2];
					for (int k = 0; k < num; k++)
					{
						for (int l = 0; l < length2; l++)
						{
							long_1[k, l] = array[k, l];
						}
					}
				}
			}
			else
			{
				long_1 = null;
			}
		}
		catch
		{
		}
	}

	public static int smethod_59(long[,] long_1, long long_2, int int_2 = 0)
	{
		if (long_1 != null)
		{
			for (int i = 0; i < long_1.GetLength(0); i++)
			{
				if (long_2 == long_1[i, int_2])
				{
					return i;
				}
			}
		}
		return -1;
	}

	public static string smethod_60(string string_18)
	{
		if (string_18 != null)
		{
			string_18 = string_18.Replace(" ", string.Empty);
			if (string_18 != string.Empty)
			{
				byte[] array = new byte[string_18.Length / 2];
				try
				{
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = Convert.ToByte(string_18.Substring(i * 2, 2), 16);
					}
					return Encoding.ASCII.GetString(array);
				}
				catch
				{
				}
			}
		}
		return string.Empty;
	}

	public static string smethod_61(object object_0, int int_2, char char_42 = ' ')
	{
		string text = string.Empty;
		if (object_0 != null)
		{
			text = object_0.ToString();
		}
		while (text.Length < int_2)
		{
			text += char_42;
		}
		return text;
	}

	public static void smethod_62(RichTextBox richTextBox_0, string string_18, bool bool_1 = false)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			if (richTextBox_0.Text != string.Empty)
			{
				string_18 = Class56.string_7 + string_18;
			}
			int num = Class24.GetScrollPos(richTextBox_0.Handle, 1);
			richTextBox_0.AppendText(string_18);
			if (!bool_1)
			{
				Class24.GetScrollRange(richTextBox_0.Handle, 1, out var _, out var int_2);
				int num2 = (richTextBox_0.ClientSize.Height - SystemInformation.HorizontalScrollBarHeight) / richTextBox_0.Font.Height;
				num = int_2 - num2;
			}
			Class24.SetScrollPos(richTextBox_0.Handle, 1, num, bool_0: true);
			Class24.PostMessageA(richTextBox_0.Handle, 277, 4 + 65536 * num, 0);
		}
	}

	public static bool smethod_63(uint[] uint_2)
	{
		return uint_2 != null && uint_2.Length > 1 && uint_2[0] != 0 && uint_2[1] != 0;
	}

	public static string smethod_64(string string_18)
	{
		StringBuilder stringBuilder = new StringBuilder();
		byte[] bytes = Encoding.Unicode.GetBytes(string_18);
		byte[] array = bytes;
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	public static string smethod_65(string string_18)
	{
		byte[] array = new byte[string_18.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = Convert.ToByte(string_18.Substring(i * 2, 2), 16);
		}
		return Encoding.Unicode.GetString(array);
	}

	public static int smethod_66(string string_18)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			if (string_18.IndexOf("0x") >= 0)
			{
				string_18 = string_18.Replace("0x", "");
			}
			int num = 0;
			try
			{
				num = int.Parse(string_18.Trim(), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
			}
			catch
			{
				num = 0;
			}
			return num;
		}
		return 0;
	}

	public static string smethod_67(byte[] byte_0, bool bool_1 = true)
	{
		try
		{
			return BitConverter.ToString(byte_0).Replace("-", string.Empty);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static string smethod_68(string string_18, char char_42, char char_43, char char_44)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			string text = string.Empty;
			for (int i = 0; i < string_18.Length; i++)
			{
				text = ((char_42 > string_18[i] || string_18[i] > char_43) ? (text + string_18[i]) : (text + char_44));
			}
			return text;
		}
		return string.Empty;
	}

	public static string smethod_69(int[] int_2, char char_42 = ',')
	{
		string text = string.Empty;
		if (int_2 != null && int_2.Length != 0)
		{
			for (int i = 0; i < int_2.Length; i++)
			{
				if (text != null && text != string.Empty)
				{
					text += char_42;
				}
				text += int_2[i];
			}
		}
		return text;
	}

	public static int[] smethod_70(string string_18, object object_0 = null)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			char[] separator = new char[1] { ',' };
			if (object_0 != null)
			{
				string[] array = typeof(char).ToString().Split('.');
				string value = array[array.Length - 1].ToUpper();
				string text = object_0.GetType().ToString().ToUpper();
				if (0 > text.IndexOf("["))
				{
					if (0 <= text.IndexOf(value))
					{
						string text2 = object_0.ToString();
						if (text2 != string.Empty)
						{
							separator = text2.ToCharArray();
						}
					}
				}
				else
				{
					separator = (char[])object_0;
				}
			}
			string[] array2 = string_18.Split(separator);
			int[] array3 = new int[array2.Length];
			int num = 0;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] != null && array2[i] != string.Empty)
				{
					string_18 = array2[i].Trim();
					if (string_18 != string.Empty)
					{
						array3[num] = smethod_11(array2[i]);
						num++;
					}
				}
			}
			if (num != 0)
			{
				if (num < array3.Length)
				{
					Array.Resize(ref array3, num);
				}
				return array3;
			}
			return null;
		}
		return null;
	}

	public static string smethod_71(string string_18)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			byte[] inArray = null;
			string result = string.Empty;
			try
			{
				using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(string_18)))
				{
					using MemoryStream memoryStream2 = new MemoryStream();
					using (DeflateStream destination = new DeflateStream(memoryStream2, CompressionMode.Compress, leaveOpen: true))
					{
						memoryStream.CopyTo(destination);
					}
					inArray = memoryStream2.ToArray();
				}
				result = Convert.ToBase64String(inArray);
			}
			catch
			{
			}
			return result;
		}
		return string.Empty;
	}

	public static string smethod_72(string string_18)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			byte[] bytes = null;
			string result = string.Empty;
			try
			{
				MemoryStream stream = new MemoryStream(Convert.FromBase64String(string_18));
				using (DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress))
				{
					using MemoryStream memoryStream = new MemoryStream();
					deflateStream.CopyTo(memoryStream);
					bytes = memoryStream.ToArray();
				}
				result = Encoding.UTF8.GetString(bytes);
			}
			catch
			{
			}
			return result;
		}
		return string.Empty;
	}

	public static string smethod_73(string string_18)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			string result = string.Empty;
			try
			{
				byte[] bytes = Encoding.UTF8.GetBytes(string_18);
				MemoryStream memoryStream = new MemoryStream();
				using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true))
				{
					gZipStream.Write(bytes, 0, bytes.Length);
				}
				memoryStream.Position = 0L;
				new MemoryStream();
				byte[] array = new byte[memoryStream.Length];
				memoryStream.Read(array, 0, array.Length);
				byte[] array2 = new byte[array.Length + 4];
				Buffer.BlockCopy(array, 0, array2, 4, array.Length);
				Buffer.BlockCopy(BitConverter.GetBytes(bytes.Length), 0, array2, 0, 4);
				result = Convert.ToBase64String(array2);
			}
			catch
			{
			}
			return result;
		}
		return string.Empty;
	}

	public static string smethod_74(string string_18)
	{
		if (string_18 != null && !(string_18 == string.Empty))
		{
			string result = string.Empty;
			try
			{
				byte[] array = Convert.FromBase64String(string_18);
				using MemoryStream memoryStream = new MemoryStream();
				int num = BitConverter.ToInt32(array, 0);
				memoryStream.Write(array, 4, array.Length - 4);
				byte[] array2 = new byte[num];
				memoryStream.Position = 0L;
				using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					gZipStream.Read(array2, 0, array2.Length);
				}
				result = Encoding.UTF8.GetString(array2);
			}
			catch
			{
			}
			return result;
		}
		return string.Empty;
	}

	public static string smethod_75(string string_18, byte[] byte_0, byte[] byte_1)
	{
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		aes.Key = byte_0;
		aes.IV = byte_1;
		MemoryStream memoryStream = new MemoryStream();
		ICryptoTransform transform = aes.CreateEncryptor();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		byte[] bytes = Encoding.UTF8.GetBytes(string_18);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		byte[] array = memoryStream.ToArray();
		memoryStream.Close();
		cryptoStream.Close();
		return Convert.ToBase64String(array, 0, array.Length);
	}

	public static string smethod_76(string string_18)
	{
		string s = "JXKeoXe";
		SHA256 sHA = SHA256.Create();
		byte[] key = sHA.ComputeHash(Encoding.ASCII.GetBytes(s));
		byte[] bytes = Encoding.ASCII.GetBytes("JXKEOXEUKDKLA5H8");
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		aes.Key = key;
		aes.IV = bytes;
		MemoryStream memoryStream = new MemoryStream();
		ICryptoTransform transform = aes.CreateDecryptor();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		string result = string.Empty;
		try
		{
			byte[] array = Convert.FromBase64String(string_18);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array2 = memoryStream.ToArray();
			result = Encoding.UTF8.GetString(array2, 0, array2.Length);
		}
		finally
		{
			memoryStream.Close();
			cryptoStream.Close();
		}
		return result;
	}

	public static string smethod_77(string string_18, string string_19, byte[] byte_0 = null)
	{
		string result = string.Empty;
		if (!string.IsNullOrEmpty(string_18) && !string.IsNullOrEmpty(string_19))
		{
			if (byte_0 == null)
			{
				return string.Empty;
			}
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			try
			{
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_19, byte_0);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
				using MemoryStream memoryStream = new MemoryStream();
				using (CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
				{
					using StreamWriter streamWriter = new StreamWriter(stream);
					streamWriter.Write(string_18);
				}
				result = Convert.ToBase64String(memoryStream.ToArray());
			}
			finally
			{
				rijndaelManaged?.Clear();
			}
		}
		return result;
	}
}
