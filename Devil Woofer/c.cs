using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
[CompilerGenerated]
[DebuggerDisplay("\\{ icon_url = {icon_url}, text = {text} }", Type = "<Anonymous Type>")]
internal sealed class c<g, h>
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000010 RID: 16 RVA: 0x000023B8 File Offset: 0x000005B8
	public g icon_url
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000011 RID: 17 RVA: 0x000023C0 File Offset: 0x000005C0
	public h text
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000023C8 File Offset: 0x000005C8
	[DebuggerHidden]
	public c(g a, h b)
	{
		this.a = a;
		this.b = b;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000023E4 File Offset: 0x000005E4
	[DebuggerHidden]
	public override bool Equals(object a)
	{
		c<g, h> c = a as c<g, h>;
		bool result;
		if (this != c)
		{
			if (c != null)
			{
				if (EqualityComparer<g>.Default.Equals(this.a, c.a))
				{
					result = EqualityComparer<h>.Default.Equals(this.b, c.b);
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

	// Token: 0x06000014 RID: 20 RVA: 0x00002443 File Offset: 0x00000643
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1058492782 * -1521134295 + EqualityComparer<g>.Default.GetHashCode(this.a)) * -1521134295 + EqualityComparer<h>.Default.GetHashCode(this.b);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002478 File Offset: 0x00000678
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = i.a("", 63030);
		object[] array = new object[2];
		int num = 0;
		g g = this.a;
		array[num] = ((g != null) ? g.ToString() : null);
		int num2 = 1;
		h h = this.b;
		array[num2] = ((h != null) ? h.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000007 RID: 7
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly g a;

	// Token: 0x04000008 RID: 8
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly h b;
}
