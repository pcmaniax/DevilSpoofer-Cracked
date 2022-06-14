using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000002 RID: 2
[CompilerGenerated]
[DebuggerDisplay("\\{ username = {username}, embeds = {embeds} }", Type = "<Anonymous Type>")]
internal sealed class a<a, b>
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000002 RID: 2 RVA: 0x00002057 File Offset: 0x00000257
	public a username
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000003 RID: 3 RVA: 0x0000205F File Offset: 0x0000025F
	public b embeds
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002067 File Offset: 0x00000267
	[DebuggerHidden]
	public a(a a, b b)
	{
		this.a = a;
		this.b = b;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002084 File Offset: 0x00000284
	[DebuggerHidden]
	public override bool Equals(object a)
	{
		a<a, b> a2 = a as a<a, b>;
		bool result;
		if (this != a2)
		{
			if (a2 != null)
			{
				if (EqualityComparer<a>.Default.Equals(this.a, a2.a))
				{
					result = EqualityComparer<b>.Default.Equals(this.b, a2.b);
					goto IL_4F;
				}
			}
			result = false;
			IL_4F:;
		}
		else
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000020E3 File Offset: 0x000002E3
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1449738374 * -1521134295 + EqualityComparer<a>.Default.GetHashCode(this.a)) * -1521134295 + EqualityComparer<b>.Default.GetHashCode(this.b);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002118 File Offset: 0x00000318
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = i.a("", 58732);
		object[] array = new object[2];
		int num = 0;
		a a = this.a;
		array[num] = ((a != null) ? a.ToString() : null);
		int num2 = 1;
		b b = this.b;
		array[num2] = ((b != null) ? b.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000001 RID: 1
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly a a;

	// Token: 0x04000002 RID: 2
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly b b;
}
