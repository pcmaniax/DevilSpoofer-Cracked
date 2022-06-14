using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LeanDevelopment.Properties
{
	// Token: 0x02000006 RID: 6
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002854 File Offset: 0x00000A54
		public static Settings Default
		{
			get
			{
				return Settings.a;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000286C File Offset: 0x00000A6C
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002898 File Offset: 0x00000A98
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string username
		{
			get
			{
				return (string)this[i.a("", 57861)];
			}
			set
			{
				this[i.a("", 62726)] = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000028B4 File Offset: 0x00000AB4
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000028E0 File Offset: 0x00000AE0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string password
		{
			get
			{
				return (string)this[i.a("", 61243)];
			}
			set
			{
				this[i.a("", 60342)] = value;
			}
		}

		// Token: 0x0400000B RID: 11
		private static Settings a = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
