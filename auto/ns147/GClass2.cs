using System;
using System.Collections.Generic;
using System.Net;

namespace ns147;

public class GClass2 : WebClient
{
	private class Class71
	{
		private Dictionary<string, string> dictionary_0;

		public string this[Uri uri_0]
		{
			get
			{
				if (dictionary_0.TryGetValue(uri_0.Host, out var value))
				{
					return value;
				}
				return null;
			}
			set
			{
				dictionary_0[uri_0.Host] = value;
			}
		}

		public Class71()
		{
			dictionary_0 = new Dictionary<string, string>();
		}
	}

	private Class71 class71_0;

	public GClass2()
	{
		class71_0 = new Class71();
	}

	protected override WebRequest GetWebRequest(Uri address)
	{
		WebRequest webRequest = base.GetWebRequest(address);
		if (webRequest is HttpWebRequest)
		{
			string text = class71_0[address];
			if (text != null)
			{
				((HttpWebRequest)webRequest).Headers.Set("cookie", text);
			}
		}
		return webRequest;
	}

	protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
	{
		WebResponse webResponse = base.GetWebResponse(request, result);
		string[] values = webResponse.Headers.GetValues("Set-Cookie");
		if (values != null && values.Length != 0)
		{
			string text = "";
			string[] array = values;
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				text += text2;
			}
			class71_0[webResponse.ResponseUri] = text;
		}
		return webResponse;
	}

	protected override WebResponse GetWebResponse(WebRequest request)
	{
		WebResponse webResponse = base.GetWebResponse(request);
		string[] values = webResponse.Headers.GetValues("Set-Cookie");
		if (values != null && values.Length != 0)
		{
			string text = "";
			string[] array = values;
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				text += text2;
			}
			class71_0[webResponse.ResponseUri] = text;
		}
		return webResponse;
	}
}
