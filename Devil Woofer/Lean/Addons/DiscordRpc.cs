using System;
using System.Runtime.InteropServices;

namespace Lean.Addons
{
	// Token: 0x0200000C RID: 12
	public class DiscordRpc
	{
		// Token: 0x060000C2 RID: 194
		[DllImport("runtime.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
		public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		// Token: 0x060000C3 RID: 195
		[DllImport("runtime.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
		public static extern void RunCallbacks();

		// Token: 0x060000C4 RID: 196
		[DllImport("runtime.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
		public static extern void Shutdown();

		// Token: 0x060000C5 RID: 197
		[DllImport("runtime.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
		public static extern void UpdatePresence(ref DiscordRpc.RichPresence presence);

		// Token: 0x060000C6 RID: 198 RVA: 0x00016F9E File Offset: 0x0001519E
		internal static void a(string a, ref object b, bool c, object d)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x060000C9 RID: 201
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DisconnectedCallback(int errorCode, string message);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x060000CD RID: 205
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ErrorCallback(int errorCode, string message);

		// Token: 0x0200000F RID: 15
		public struct EventHandlers
		{
			// Token: 0x04000080 RID: 128
			public DiscordRpc.ReadyCallback readyCallback;

			// Token: 0x04000081 RID: 129
			public DiscordRpc.DisconnectedCallback disconnectedCallback;

			// Token: 0x04000082 RID: 130
			public DiscordRpc.ErrorCallback errorCallback;
		}

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x060000D1 RID: 209
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ReadyCallback();

		// Token: 0x02000011 RID: 17
		[Serializable]
		public struct RichPresence
		{
			// Token: 0x04000083 RID: 131
			public string state;

			// Token: 0x04000084 RID: 132
			public string details;

			// Token: 0x04000085 RID: 133
			public long startTimestamp;

			// Token: 0x04000086 RID: 134
			public long endTimestamp;

			// Token: 0x04000087 RID: 135
			public string largeImageKey;

			// Token: 0x04000088 RID: 136
			public string largeImageText;

			// Token: 0x04000089 RID: 137
			public string smallImageKey;

			// Token: 0x0400008A RID: 138
			public string smallImageText;

			// Token: 0x0400008B RID: 139
			public string partyId;

			// Token: 0x0400008C RID: 140
			public int partySize;

			// Token: 0x0400008D RID: 141
			public int partyMax;

			// Token: 0x0400008E RID: 142
			public string matchSecret;

			// Token: 0x0400008F RID: 143
			public string joinSecret;

			// Token: 0x04000090 RID: 144
			public string spectateSecret;

			// Token: 0x04000091 RID: 145
			public bool instance;
		}
	}
}
