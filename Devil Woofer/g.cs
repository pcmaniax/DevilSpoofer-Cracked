using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x0200001F RID: 31
[CompilerGenerated]
internal static class g
{
	// Token: 0x06000157 RID: 343 RVA: 0x00019C79 File Offset: 0x00017E79
	private static string a(CultureInfo a)
	{
		if (a == null)
		{
			return "";
		}
		return a.Name;
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00019C8C File Offset: 0x00017E8C
	private static Assembly b(AssemblyName a)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Assembly[] assemblies = currentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			AssemblyName name = assembly.GetName();
			if (string.Equals(name.Name, a.Name, StringComparison.InvariantCultureIgnoreCase))
			{
				if (string.Equals(global::g.a(name.CultureInfo), global::g.a(a.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					return assembly;
				}
			}
		}
		return null;
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00019D18 File Offset: 0x00017F18
	private static void c(Stream a, Stream b)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = a.Read(array, 0, array.Length)) != 0)
		{
			b.Write(array, 0, count);
		}
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00019D4C File Offset: 0x00017F4C
	private static Stream d(string a)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (a.EndsWith(global::i.a("", 59626)))
		{
			using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(a))
			{
				using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
				{
					MemoryStream memoryStream = new MemoryStream();
					global::g.c(deflateStream, memoryStream);
					memoryStream.Position = 0L;
					return memoryStream;
				}
			}
		}
		return executingAssembly.GetManifestResourceStream(a);
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00019DE0 File Offset: 0x00017FE0
	private static Stream e(Dictionary<string, string> a, string b)
	{
		string text;
		if (a.TryGetValue(b, out text))
		{
			return global::g.d(text);
		}
		return null;
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00019E00 File Offset: 0x00018000
	private static byte[] f(Stream a)
	{
		byte[] array = new byte[a.Length];
		a.Read(array, 0, array.Length);
		return array;
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00019E30 File Offset: 0x00018030
	private static Assembly g(Dictionary<string, string> a, Dictionary<string, string> b, AssemblyName c)
	{
		string str = c.Name.ToLowerInvariant();
		if (c.CultureInfo != null && !string.IsNullOrEmpty(c.CultureInfo.Name))
		{
			str = c.CultureInfo.Name + global::i.a("", 62596) + str;
		}
		byte[] rawAssembly;
		using (Stream stream = global::g.e(a, str))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = global::g.f(stream);
		}
		using (Stream stream2 = global::g.e(b, str))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = global::g.f(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00019F10 File Offset: 0x00018110
	public static Assembly h(object a, ResolveEventArgs b)
	{
		object obj = global::g.a;
		lock (obj)
		{
			if (global::g.b.ContainsKey(b.Name))
			{
				return null;
			}
		}
		AssemblyName assemblyName = new AssemblyName(b.Name);
		Assembly assembly = global::g.b(assemblyName);
		if (assembly != null)
		{
			return assembly;
		}
		assembly = global::g.g(global::g.c, global::g.d, assemblyName);
		if (assembly == null)
		{
			object obj2 = global::g.a;
			lock (obj2)
			{
				global::g.b[b.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	// Token: 0x0600015F RID: 351 RVA: 0x0001A008 File Offset: 0x00018208
	// Note: this type is marked as 'beforefieldinit'.
	static g()
	{
		global::g.c.Add(global::i.a("", 62689), global::i.a("", 59989));
		global::g.c.Add(global::i.a("", 59820), global::i.a("", 60189));
		global::g.d.Add(global::i.a("", 59820), global::i.a("", 58067));
		global::g.c.Add(global::i.a("", 63508), global::i.a("", 63428));
		global::g.c.Add(global::i.a("", 59440), global::i.a("", 58333));
		global::g.c.Add(global::i.a("", 59217), global::i.a("", 61684));
		global::g.c.Add(global::i.a("", 63494), global::i.a("", 57409));
		global::g.c.Add(global::i.a("", 57372), global::i.a("", 62840));
		global::g.c.Add(global::i.a("", 60610), global::i.a("", 60012));
		global::g.c.Add(global::i.a("", 60855), global::i.a("", 60630));
		global::g.c.Add(global::i.a("", 57862), global::i.a("", 59456));
	}

	// Token: 0x06000160 RID: 352 RVA: 0x0001A21C File Offset: 0x0001841C
	public static void i()
	{
		if (Interlocked.Exchange(ref global::g.e, 1) == 1)
		{
			return;
		}
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.AssemblyResolve += global::g.h;
	}

	// Token: 0x040000C8 RID: 200
	private static object a = new object();

	// Token: 0x040000C9 RID: 201
	private static Dictionary<string, bool> b = new Dictionary<string, bool>();

	// Token: 0x040000CA RID: 202
	private static Dictionary<string, string> c = new Dictionary<string, string>();

	// Token: 0x040000CB RID: 203
	private static Dictionary<string, string> d = new Dictionary<string, string>();

	// Token: 0x040000CC RID: 204
	private static int e;
}
