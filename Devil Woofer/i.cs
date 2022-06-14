using System;
using System.IO;
using System.Reflection;

// Token: 0x02000021 RID: 33
internal sealed class i
{
	// Token: 0x06000161 RID: 353 RVA: 0x0001A250 File Offset: 0x00018450
	public static string a(string a, int b)
	{
		DateTime t = new DateTime(~(-707224153 + 707222130), (-794292951 ^ 123248242) - -672099505 >> 1, -428791459 + 428791488, ~((184124840 ^ -184124856) >> 2), (--349279349 ^ 16653697) + -338659825 << 2, ~(-322619355 + 447230712) + 124611374);
		if (DateTime.Now > t)
		{
			throw new Exception();
		}
		return i.b.b.c(a, b);
	}

	// Token: 0x06000162 RID: 354 RVA: 0x0001A2F0 File Offset: 0x000184F0
	public static string b()
	{
		char[] array = "\u0010\u0011\u00125".ToCharArray();
		int num = array.Length;
		while ((num -= ~(-(-1875964169 - -533234038 + -80292970) - 272432368 - 440560853) + 710029913 >> 5) >= (~(~(-(-162461871 - -362616462)) + -86581705) ^ -113572886))
		{
			array[num] = (char)((int)array[num] ^ ~((--1120643982 >> 1) - 22696730 + -537625378));
		}
		return new string(array);
	}

	// Token: 0x02000022 RID: 34
	// (Invoke) Token: 0x06000165 RID: 357
	private delegate string a();

	// Token: 0x02000023 RID: 35
	private sealed class b
	{
		// Token: 0x06000169 RID: 361 RVA: 0x0001A3D0 File Offset: 0x000185D0
		private b()
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(i.b.a());
			if (((manifestResourceStream == null) ? (~(-(-441876232 + -585824743 - -457466881 != 0) != 0) + 445055596 - -125178500) : ((-(~(335937329 != 0) != 0) ^ 451904506) + -590996312 - -340747920)) == 0)
			{
				this.c = new byte[-(((-(-206333215 + -43347423 ^ -556006041) + 244163064 - 583720565 ^ 103483910) >> 3) - -146443739) << 3];
				manifestResourceStream.Read(this.c, -1075332674 + 463135747 - -612196927 << 6, this.c.Length);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0001A4C8 File Offset: 0x000186C8
		public string c(string a, int b)
		{
			int num = a.Length;
			char[] array = a.ToCharArray();
			while ((num -= ~(788715304 + 661035320 >> 5 ^ -434260704) + -308307203 - 217235908 - -67249516) >= 1279416589 - 614434644 + -664981945)
			{
				array[num] = (char)((int)array[num] ^ ((int)this.c[b & ((-(~(~499036218 ^ -231397429) - -389466415) >> 3) - -232018078 ^ 217842805)] | b));
			}
			return new string(array);
		}

		// Token: 0x040000CF RID: 207
		private static readonly i.a a = new i.a(i.b);

		// Token: 0x040000D0 RID: 208
		public static readonly i.b b = new i.b();

		// Token: 0x040000D1 RID: 209
		private byte[] c;
	}
}
