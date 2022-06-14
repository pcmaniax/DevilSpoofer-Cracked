using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000003 RID: 3
[CompilerGenerated]
[DebuggerDisplay("\\{ description = {description}, title = {title}, color = {color}, footer = {footer} }", Type = "<Anonymous Type>")]
internal sealed class b<c, d, e, f>
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000008 RID: 8 RVA: 0x00002190 File Offset: 0x00000390
	public c description
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000009 RID: 9 RVA: 0x00002198 File Offset: 0x00000398
	public d title
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600000A RID: 10 RVA: 0x000021A0 File Offset: 0x000003A0
	public e color
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600000B RID: 11 RVA: 0x000021A8 File Offset: 0x000003A8
	public f footer
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000021B0 File Offset: 0x000003B0
	[DebuggerHidden]
	public b(c a, d b, e c, f d)
	{
		this.a = a;
		this.b = b;
		this.c = c;
		this.d = d;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000021E4 File Offset: 0x000003E4
	[DebuggerHidden]
	public override bool Equals(object a)
	{
		b<c, d, e, f> b = a as b<c, d, e, f>;
		bool result;
		if (this != b)
		{
			if (b != null)
			{
				if (EqualityComparer<c>.Default.Equals(this.a, b.a))
				{
					if (EqualityComparer<d>.Default.Equals(this.b, b.b))
					{
						if (EqualityComparer<e>.Default.Equals(this.c, b.c))
						{
							result = EqualityComparer<f>.Default.Equals(this.d, b.d);
							goto IL_8A;
						}
					}
				}
			}
			result = false;
			IL_8A:;
		}
		else
		{
			result = true;
		}
		return result;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002280 File Offset: 0x00000480
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (((2130145708 * -1521134295 + EqualityComparer<c>.Default.GetHashCode(this.a)) * -1521134295 + EqualityComparer<d>.Default.GetHashCode(this.b)) * -1521134295 + EqualityComparer<e>.Default.GetHashCode(this.c)) * -1521134295 + EqualityComparer<f>.Default.GetHashCode(this.d);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000022F0 File Offset: 0x000004F0
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = i.a("", 62992);
		object[] array = new object[4];
		int num = 0;
		c c = this.a;
		array[num] = ((c != null) ? c.ToString() : null);
		int num2 = 1;
		d d = this.b;
		array[num2] = ((d != null) ? d.ToString() : null);
		int num3 = 2;
		e e = this.c;
		array[num3] = ((e != null) ? e.ToString() : null);
		int num4 = 3;
		f f = this.d;
		array[num4] = ((f != null) ? f.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000003 RID: 3
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly c a;

	// Token: 0x04000004 RID: 4
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly d b;

	// Token: 0x04000005 RID: 5
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly e c;

	// Token: 0x04000006 RID: 6
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly f d;
}
