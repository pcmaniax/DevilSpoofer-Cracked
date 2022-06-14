using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace Lean.Resources
{
	// Token: 0x02000013 RID: 19
	public class api
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00016FEC File Offset: 0x000151EC
		public api(string name, string ownerid, string secret, string version)
		{
			bool flag = string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version);
			if (flag)
			{
				api.error(i.a("", 63163));
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000170A8 File Offset: 0x000152A8
		public void init()
		{
			this.b = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 58414)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 61294)));
			nameValueCollection[i.a("", 63226)] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection[i.a("", 60229)] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection[i.a("", 60085)] = encryption.encrypt(this.b, this.secret, text);
			nameValueCollection[i.a("", 63178)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 59823)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 57986)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			bool flag = text2 == i.a("", 58159);
			if (flag)
			{
				MessageBox.Show(i.a("", 58888), i.a("", 63528), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Application.Exit();
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.b(response_structure.appinfo);
				this.a = response_structure.sessionid;
				this.c = true;
			}
			else
			{
				bool flag2 = response_structure.message == i.a("", 61650);
				if (flag2)
				{
					this.app_data.downloadLink = response_structure.download;
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000172F0 File Offset: 0x000154F0
		public static bool IsDebugRelease
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00017304 File Offset: 0x00015504
		public void Checkinit()
		{
			bool flag = !this.c;
			if (flag)
			{
				bool isDebugRelease = api.IsDebugRelease;
				if (isDebugRelease)
				{
					api.error(i.a("", 63115));
				}
				else
				{
					api.error(i.a("", 63115));
				}
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0001736C File Offset: 0x0001556C
		public void register(string username, string pass, string key)
		{
			DateTime d = default(DateTime);
			d = d.AddYears(~-369875616 - 369873594);
			d = d.AddMonths(~(-509412089 + 674952413) - -501535768 + -335995438);
			d = d.AddDays(27.8637037037037);
			if ((DateTime.Now - d).TotalDays > 0.0)
			{
				int num = -(~103263061) + -103263062;
				num = -(~(-0)) / num;
			}
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 60396)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 62097)));
			nameValueCollection[i.a("", 63114)] = encryption.encrypt(username, this.b, text);
			nameValueCollection[i.a("", 59074)] = encryption.encrypt(pass, this.b, text);
			nameValueCollection[i.a("", 58560)] = encryption.encrypt(key, this.b, text);
			nameValueCollection[i.a("", 58970)] = encryption.encrypt(value, this.b, text);
			nameValueCollection[i.a("", 59887)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 60383)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 61675)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 63579)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.c(response_structure.info);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000175F4 File Offset: 0x000157F4
		public void login(string username, string pass)
		{
			DateTime d = default(DateTime);
			d = d.AddYears(~(-870250526 - -594386223) - 275862281);
			d = d.AddMonths(-363549708 - 183203042 ^ -546752745);
			d = d.AddDays(28.7034375);
			if ((d - DateTime.Now).TotalDays < 0.0)
			{
				int num = -661299217 - -661299217 << 6;
				num = ((--363603397 ^ -165880977) + 474939735) / num;
			}
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 61250)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 62973)));
			nameValueCollection[i.a("", 62729)] = encryption.encrypt(username, this.b, text);
			nameValueCollection[i.a("", 58563)] = encryption.encrypt(pass, this.b, text);
			nameValueCollection[i.a("", 62066)] = encryption.encrypt(value, this.b, text);
			nameValueCollection[i.a("", 58884)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 58902)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 57667)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 60974)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.c(response_structure.info);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00017864 File Offset: 0x00015A64
		public void upgrade(string username, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 58025)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 63033)));
			nameValueCollection[i.a("", 61774)] = encryption.encrypt(username, this.b, text);
			nameValueCollection[i.a("", 58615)] = encryption.encrypt(key, this.b, text);
			nameValueCollection[i.a("", 63723)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 60883)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 59569)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 60146)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			response_structure.success = false;
			this.d(response_structure);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00017A00 File Offset: 0x00015C00
		public void license(string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 61807)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 63568)));
			nameValueCollection[i.a("", 61934)] = encryption.encrypt(key, this.b, text);
			nameValueCollection[i.a("", 59017)] = encryption.encrypt(value, this.b, text);
			nameValueCollection[i.a("", 58044)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 58891)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 58277)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 61369)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.c(response_structure.info);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00017BB0 File Offset: 0x00015DB0
		public void check()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 57888)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 58998)));
			nameValueCollection[i.a("", 63429)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 63102)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 57638)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 60986)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00017CE4 File Offset: 0x00015EE4
		public void setvar(string var, string data)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 59228)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 62268)));
			nameValueCollection[i.a("", 63048)] = encryption.encrypt(var, this.b, text);
			nameValueCollection[i.a("", 57461)] = encryption.encrypt(data, this.b, text);
			nameValueCollection[i.a("", 58553)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 60628)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 57879)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 60572)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00017E60 File Offset: 0x00016060
		public string getvar(string var)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 60607)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 63178)));
			nameValueCollection[i.a("", 58786)] = encryption.encrypt(var, this.b, text);
			nameValueCollection[i.a("", 61303)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 63494)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 59956)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 59199)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			bool success = response_structure.success;
			string result;
			if (success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00017FD8 File Offset: 0x000161D8
		public void ban()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 62044)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 62969)));
			nameValueCollection[i.a("", 63480)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 61722)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 60025)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 57368)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0001810C File Offset: 0x0001630C
		public string var(string varid)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 58982)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 62849)));
			nameValueCollection[i.a("", 57938)] = encryption.encrypt(varid, this.b, text);
			nameValueCollection[i.a("", 59071)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 57567)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 60793)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 60383)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			bool success = response_structure.success;
			string result;
			if (success)
			{
				result = response_structure.message;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0001829C File Offset: 0x0001649C
		public List<api.msg> chatget(string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 61707)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 61973)));
			nameValueCollection[i.a("", 62566)] = encryption.encrypt(channelname, this.b, text);
			nameValueCollection[i.a("", 60285)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 63435)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 58484)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 63607)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			bool success = response_structure.success;
			List<api.msg> result;
			if (success)
			{
				result = response_structure.messages;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00018414 File Offset: 0x00016614
		public bool chatsend(string msg, string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 58897)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 58363)));
			nameValueCollection[i.a("", 63393)] = encryption.encrypt(msg, this.b, text);
			nameValueCollection[i.a("", 57438)] = encryption.encrypt(channelname, this.b, text);
			nameValueCollection[i.a("", 62186)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 58130)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 61293)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 58130)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			return response_structure.success;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000185A8 File Offset: 0x000167A8
		public bool checkblack()
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 63184)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 63671)));
			nameValueCollection[i.a("", 61668)] = encryption.encrypt(value, this.b, text);
			nameValueCollection[i.a("", 58462)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 63282)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 62788)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 61963)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			return response_structure.success;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00018734 File Offset: 0x00016934
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 59802)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 61480)));
			nameValueCollection[i.a("", 60620)] = encryption.encrypt(webid, this.b, text);
			nameValueCollection[i.a("", 57621)] = encryption.encrypt(param, this.b, text);
			nameValueCollection[i.a("", 57349)] = encryption.encrypt(body, this.b, text);
			nameValueCollection[i.a("", 63105)] = encryption.encrypt(conttype, this.b, text);
			nameValueCollection[i.a("", 62172)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 61277)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 57609)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 57530)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			bool success = response_structure.success;
			string result;
			if (success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00018914 File Offset: 0x00016B14
		public byte[] download(string fileid)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 60092)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 60109)));
			nameValueCollection[i.a("", 57623)] = encryption.encrypt(fileid, this.b, text);
			nameValueCollection[i.a("", 61900)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 60151)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 60834)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 63486)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			bool success = response_structure.success;
			byte[] result;
			if (success)
			{
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00018A90 File Offset: 0x00016C90
		public void log(string message)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection[i.a("", 62647)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(i.a("", 61892)));
			nameValueCollection[i.a("", 63262)] = encryption.encrypt(Environment.UserName, this.b, text);
			nameValueCollection[i.a("", 57816)] = encryption.encrypt(message, this.b, text);
			nameValueCollection[i.a("", 60913)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection[i.a("", 60421)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection[i.a("", 59165)] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection[i.a("", 58093)] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			api.a(nameValueCollection2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00018BE0 File Offset: 0x00016DE0
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace(i.a("", 58812), "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00018C6C File Offset: 0x00016E6C
		public static void error(string message)
		{
			MessageBox.Show(message, i.a("", 59507), MessageBoxButtons.OK);
			Environment.Exit(0);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00018C94 File Offset: 0x00016E94
		private static string a(NameValueCollection a)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues(i.a("", 61608), a);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					api.error(i.a("", 59376));
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error(i.a("", 60751));
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00018D6C File Offset: 0x00016F6C
		private void b(api.app_data_structure a)
		{
			this.app_data.numUsers = a.numUsers;
			this.app_data.numOnlineUsers = a.numOnlineUsers;
			this.app_data.numKeys = a.numKeys;
			this.app_data.version = a.version;
			this.app_data.customerPanelLink = a.customerPanelLink;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00018DE8 File Offset: 0x00016FE8
		private void c(api.user_data_structure a)
		{
			this.user_data.username = a.username;
			this.user_data.ip = a.ip;
			this.user_data.hwid = a.hwid;
			this.user_data.createdate = a.createdate;
			this.user_data.lastlogin = a.lastlogin;
			this.user_data.subscriptions = a.subscriptions;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00018E74 File Offset: 0x00017074
		public string expirydaysleft()
		{
			this.Checkinit();
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			TimeSpan timeSpan = d - DateTime.Now;
			return Convert.ToString(timeSpan.Days.ToString() + i.a("", 63090) + timeSpan.Hours.ToString() + i.a("", 59098));
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00018EFE File Offset: 0x000170FE
		private void d(api.response_structure a)
		{
			this.response.success = a.success;
			this.response.message = a.message;
		}

		// Token: 0x04000092 RID: 146
		public string name;

		// Token: 0x04000093 RID: 147
		public string ownerid;

		// Token: 0x04000094 RID: 148
		public string secret;

		// Token: 0x04000095 RID: 149
		public string version;

		// Token: 0x04000096 RID: 150
		private string a;

		// Token: 0x04000097 RID: 151
		private string b;

		// Token: 0x04000098 RID: 152
		private bool c;

		// Token: 0x04000099 RID: 153
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x0400009A RID: 154
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400009B RID: 155
		public api.response_class response = new api.response_class();

		// Token: 0x0400009C RID: 156
		private json_wrapper d = new json_wrapper(new api.response_structure());

		// Token: 0x02000014 RID: 20
		[DataContract]
		private class response_structure
		{
			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x00018F2B File Offset: 0x0001712B
			// (set) Token: 0x060000F1 RID: 241 RVA: 0x00018F33 File Offset: 0x00017133
			[DataMember]
			public bool success { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x00018F3C File Offset: 0x0001713C
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x00018F44 File Offset: 0x00017144
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000F4 RID: 244 RVA: 0x00018F50 File Offset: 0x00017150
			// (set) Token: 0x060000F5 RID: 245 RVA: 0x00018FB8 File Offset: 0x000171B8
			[DataMember]
			public string contents
			{
				[CompilerGenerated]
				get
				{
					DateTime d = new DateTime(-(~2021), ~((863472916 >> 1) - 431736465), --268096366 - 268096338);
					if ((DateTime.Now - d).TotalDays > 0.0)
					{
						throw new ArgumentException();
					}
					return this.c;
				}
				[CompilerGenerated]
				set
				{
					DateTime d = new DateTime(~-501152958 - 501150935, -(283790771 + 346410687 + -630201506 >> 3), ~205713126 ^ -205713148);
					if ((DateTime.Now - d).TotalDays > 0.0)
					{
						int num = ~(-(-594989948 + 433910909) + -161079040);
						num = (~(437930075 + 213359273 >> 2) ^ -162822337) / num;
					}
					this.c = value;
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000F6 RID: 246 RVA: 0x00019058 File Offset: 0x00017258
			// (set) Token: 0x060000F7 RID: 247 RVA: 0x00019060 File Offset: 0x00017260
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000F8 RID: 248 RVA: 0x00019069 File Offset: 0x00017269
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x00019071 File Offset: 0x00017271
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000FA RID: 250 RVA: 0x0001907A File Offset: 0x0001727A
			// (set) Token: 0x060000FB RID: 251 RVA: 0x00019082 File Offset: 0x00017282
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000FC RID: 252 RVA: 0x0001908B File Offset: 0x0001728B
			// (set) Token: 0x060000FD RID: 253 RVA: 0x00019093 File Offset: 0x00017293
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000FE RID: 254 RVA: 0x0001909C File Offset: 0x0001729C
			// (set) Token: 0x060000FF RID: 255 RVA: 0x000190A4 File Offset: 0x000172A4
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000100 RID: 256 RVA: 0x000190AD File Offset: 0x000172AD
			// (set) Token: 0x06000101 RID: 257 RVA: 0x000190B5 File Offset: 0x000172B5
			[DataMember]
			public List<api.msg> messages { get; set; }

			// Token: 0x0400009D RID: 157
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool a;

			// Token: 0x0400009E RID: 158
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x0400009F RID: 159
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			// Token: 0x040000A0 RID: 160
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			// Token: 0x040000A1 RID: 161
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			// Token: 0x040000A2 RID: 162
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string f;

			// Token: 0x040000A3 RID: 163
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private api.user_data_structure g;

			// Token: 0x040000A4 RID: 164
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private api.app_data_structure h;

			// Token: 0x040000A5 RID: 165
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<api.msg> i;
		}

		// Token: 0x02000015 RID: 21
		public class msg
		{
			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000103 RID: 259 RVA: 0x000190BE File Offset: 0x000172BE
			// (set) Token: 0x06000104 RID: 260 RVA: 0x000190C6 File Offset: 0x000172C6
			public string message { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000105 RID: 261 RVA: 0x000190CF File Offset: 0x000172CF
			// (set) Token: 0x06000106 RID: 262 RVA: 0x000190D7 File Offset: 0x000172D7
			public string author { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000107 RID: 263 RVA: 0x000190E0 File Offset: 0x000172E0
			// (set) Token: 0x06000108 RID: 264 RVA: 0x0001918C File Offset: 0x0001738C
			public string timestamp
			{
				[CompilerGenerated]
				get
				{
					DateTime d = new DateTime(~1230316575 >> 3 ^ -153789286, (593044043 + -583373998 ^ 43030107) - 33758144, -73606377 - -73606406, ~(-((1212053552 >> 1) + -606026771)), 296770735 + -296770708, ((~(672811924 + 422992140) ^ -83082775) >> 1) - 584158523);
					if ((DateTime.Now - d).TotalDays > 0.0)
					{
						throw new InvalidOperationException();
					}
					return this.c;
				}
				[CompilerGenerated]
				set
				{
					DateTime d = new DateTime(((-413108999 ^ 274808370) - -63179643 ^ -87725706) >> 3, -1131199216 - -504311956 + 626887266, (151116479 ^ 151117311) >> 6);
					if ((DateTime.Now - d).TotalDays > 0.0)
					{
						throw new ArgumentException();
					}
					this.c = value;
				}
			}

			// Token: 0x040000A6 RID: 166
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000A7 RID: 167
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000A8 RID: 168
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;
		}

		// Token: 0x02000016 RID: 22
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600010A RID: 266 RVA: 0x0001920A File Offset: 0x0001740A
			// (set) Token: 0x0600010B RID: 267 RVA: 0x00019212 File Offset: 0x00017412
			[DataMember]
			public string username { get; set; }

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600010C RID: 268 RVA: 0x0001921B File Offset: 0x0001741B
			// (set) Token: 0x0600010D RID: 269 RVA: 0x00019223 File Offset: 0x00017423
			[DataMember]
			public string ip { get; set; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600010E RID: 270 RVA: 0x0001922C File Offset: 0x0001742C
			// (set) Token: 0x0600010F RID: 271 RVA: 0x00019234 File Offset: 0x00017434
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000110 RID: 272 RVA: 0x0001923D File Offset: 0x0001743D
			// (set) Token: 0x06000111 RID: 273 RVA: 0x00019245 File Offset: 0x00017445
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000112 RID: 274 RVA: 0x0001924E File Offset: 0x0001744E
			// (set) Token: 0x06000113 RID: 275 RVA: 0x00019256 File Offset: 0x00017456
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000114 RID: 276 RVA: 0x0001925F File Offset: 0x0001745F
			// (set) Token: 0x06000115 RID: 277 RVA: 0x00019267 File Offset: 0x00017467
			[DataMember]
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x040000A9 RID: 169
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000AA RID: 170
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000AB RID: 171
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			// Token: 0x040000AC RID: 172
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			// Token: 0x040000AD RID: 173
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			// Token: 0x040000AE RID: 174
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<api.Data> f;
		}

		// Token: 0x02000017 RID: 23
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000117 RID: 279 RVA: 0x00019270 File Offset: 0x00017470
			// (set) Token: 0x06000118 RID: 280 RVA: 0x00019278 File Offset: 0x00017478
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000119 RID: 281 RVA: 0x00019284 File Offset: 0x00017484
			// (set) Token: 0x0600011A RID: 282 RVA: 0x000192E8 File Offset: 0x000174E8
			[DataMember]
			public string numOnlineUsers
			{
				[CompilerGenerated]
				get
				{
					DateTime t = new DateTime((1022248190 >> 1) + -511122073, -(-66708364 >> 1) - 33354176, ~-465 >> 4);
					if (t < DateTime.Now)
					{
						throw new Exception();
					}
					return this.b;
				}
				[CompilerGenerated]
				set
				{
					DateTime t = new DateTime(408404395 + -58377112 - 350025261, ~(-507435060 - -263486249) - 243948804, ~(~(~-580635750 - 190961725) + 389673995), ~(92692706 - 402927861 + 310235141), ~169950843 + 169950862, -(-(189369436 - -63225692) + 252595058 >> 1));
					if (t < DateTime.Now)
					{
						throw new ArgumentException();
					}
					this.b = value;
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600011B RID: 283 RVA: 0x00019392 File Offset: 0x00017592
			// (set) Token: 0x0600011C RID: 284 RVA: 0x0001939A File Offset: 0x0001759A
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x0600011D RID: 285 RVA: 0x000193A3 File Offset: 0x000175A3
			// (set) Token: 0x0600011E RID: 286 RVA: 0x000193AB File Offset: 0x000175AB
			[DataMember]
			public string version { get; set; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x0600011F RID: 287 RVA: 0x000193B4 File Offset: 0x000175B4
			// (set) Token: 0x06000120 RID: 288 RVA: 0x000193BC File Offset: 0x000175BC
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000121 RID: 289 RVA: 0x000193C5 File Offset: 0x000175C5
			// (set) Token: 0x06000122 RID: 290 RVA: 0x000193CD File Offset: 0x000175CD
			[DataMember]
			public string downloadLink { get; set; }

			// Token: 0x040000AF RID: 175
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000B0 RID: 176
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000B1 RID: 177
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			// Token: 0x040000B2 RID: 178
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			// Token: 0x040000B3 RID: 179
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			// Token: 0x040000B4 RID: 180
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string f;
		}

		// Token: 0x02000018 RID: 24
		public class app_data_class
		{
			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000124 RID: 292 RVA: 0x000193D6 File Offset: 0x000175D6
			// (set) Token: 0x06000125 RID: 293 RVA: 0x000193E0 File Offset: 0x000175E0
			public string numUsers
			{
				[CompilerGenerated]
				get
				{
					return this.a;
				}
				[CompilerGenerated]
				set
				{
					DateTime d = new DateTime(~(-4046 << 3 >> 4), (595458240 ^ 40806305) + -554916961 >> 7, ~((--127604940 ^ -127605012) >> 5 << 1));
					if ((DateTime.Now - d).TotalDays > 0.0)
					{
						throw new InvalidOperationException();
					}
					this.a = value;
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000126 RID: 294 RVA: 0x00019458 File Offset: 0x00017658
			// (set) Token: 0x06000127 RID: 295 RVA: 0x000194FB File Offset: 0x000176FB
			public string numOnlineUsers
			{
				[CompilerGenerated]
				get
				{
					DateTime t = default(DateTime);
					t = t.AddYears(-(~(--2020)));
					t = t.AddMonths(~(148434799 - 233997293) - 85562173 >> 6);
					t = t.AddDays(28.1525925925926);
					if (t < DateTime.Now)
					{
						int num = -(~-233401727) - -11874552 + 221527174;
						num = ~-2 / num;
					}
					return this.b;
				}
				[CompilerGenerated]
				set
				{
					this.b = value;
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000128 RID: 296 RVA: 0x00019504 File Offset: 0x00017704
			// (set) Token: 0x06000129 RID: 297 RVA: 0x0001950C File Offset: 0x0001770C
			public string numKeys { get; set; }

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x0600012A RID: 298 RVA: 0x00019515 File Offset: 0x00017715
			// (set) Token: 0x0600012B RID: 299 RVA: 0x0001951D File Offset: 0x0001771D
			public string version { get; set; }

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x0600012C RID: 300 RVA: 0x00019526 File Offset: 0x00017726
			// (set) Token: 0x0600012D RID: 301 RVA: 0x0001952E File Offset: 0x0001772E
			public string customerPanelLink { get; set; }

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x0600012E RID: 302 RVA: 0x00019537 File Offset: 0x00017737
			// (set) Token: 0x0600012F RID: 303 RVA: 0x0001953F File Offset: 0x0001773F
			public string downloadLink { get; set; }

			// Token: 0x040000B5 RID: 181
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000B6 RID: 182
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000B7 RID: 183
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			// Token: 0x040000B8 RID: 184
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			// Token: 0x040000B9 RID: 185
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			// Token: 0x040000BA RID: 186
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string f;
		}

		// Token: 0x02000019 RID: 25
		public class user_data_class
		{
			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06000131 RID: 305 RVA: 0x00019548 File Offset: 0x00017748
			// (set) Token: 0x06000132 RID: 306 RVA: 0x00019550 File Offset: 0x00017750
			public string username { get; set; }

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06000133 RID: 307 RVA: 0x00019559 File Offset: 0x00017759
			// (set) Token: 0x06000134 RID: 308 RVA: 0x00019561 File Offset: 0x00017761
			public string ip { get; set; }

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000135 RID: 309 RVA: 0x0001956A File Offset: 0x0001776A
			// (set) Token: 0x06000136 RID: 310 RVA: 0x00019572 File Offset: 0x00017772
			public string hwid { get; set; }

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000137 RID: 311 RVA: 0x0001957B File Offset: 0x0001777B
			// (set) Token: 0x06000138 RID: 312 RVA: 0x00019583 File Offset: 0x00017783
			public string createdate { get; set; }

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x06000139 RID: 313 RVA: 0x0001958C File Offset: 0x0001778C
			// (set) Token: 0x0600013A RID: 314 RVA: 0x00019594 File Offset: 0x00017794
			public string lastlogin { get; set; }

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600013B RID: 315 RVA: 0x0001959D File Offset: 0x0001779D
			// (set) Token: 0x0600013C RID: 316 RVA: 0x000195A5 File Offset: 0x000177A5
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x040000BB RID: 187
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000BC RID: 188
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000BD RID: 189
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			// Token: 0x040000BE RID: 190
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			// Token: 0x040000BF RID: 191
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			// Token: 0x040000C0 RID: 192
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<api.Data> f;
		}

		// Token: 0x0200001A RID: 26
		public class Data
		{
			// Token: 0x17000041 RID: 65
			// (get) Token: 0x0600013E RID: 318 RVA: 0x000195AE File Offset: 0x000177AE
			// (set) Token: 0x0600013F RID: 319 RVA: 0x000195B6 File Offset: 0x000177B6
			public string subscription { get; set; }

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000140 RID: 320 RVA: 0x000195BF File Offset: 0x000177BF
			// (set) Token: 0x06000141 RID: 321 RVA: 0x000195C7 File Offset: 0x000177C7
			public string expiry { get; set; }

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000142 RID: 322 RVA: 0x000195D0 File Offset: 0x000177D0
			// (set) Token: 0x06000143 RID: 323 RVA: 0x000195D8 File Offset: 0x000177D8
			public string timeleft { get; set; }

			// Token: 0x040000C1 RID: 193
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000C2 RID: 194
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000C3 RID: 195
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;
		}

		// Token: 0x0200001B RID: 27
		public class response_class
		{
			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000145 RID: 325 RVA: 0x000195E1 File Offset: 0x000177E1
			// (set) Token: 0x06000146 RID: 326 RVA: 0x000195EC File Offset: 0x000177EC
			public bool success
			{
				[CompilerGenerated]
				get
				{
					return this.a;
				}
				[CompilerGenerated]
				set
				{
					DateTime t = new DateTime((236295988 + -62970959 ^ 15559622) + 441584454 ^ 621534095, -(~662112807) - 662112802, (-242096905 ^ -242096912) << 2);
					if (t < DateTime.Now)
					{
						throw new ArgumentException();
					}
					this.a = value;
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000147 RID: 327 RVA: 0x00019664 File Offset: 0x00017864
			// (set) Token: 0x06000148 RID: 328 RVA: 0x00019717 File Offset: 0x00017917
			public string message
			{
				[CompilerGenerated]
				get
				{
					DateTime d = new DateTime(-(429143595 + -429145617), -(--288188791 + 220653663 - 508842460), ~(-1010629790 ^ -456690114) - -654603641, -24291399 - -24291491 >> 2, (-(-1972912986 ^ 478620585) ^ -581488045) - -583706150 + 686620499, ~(263475874 + -263475959) << 2 >> 3);
					if ((DateTime.Now - d).TotalDays > 0.0)
					{
						throw new Exception();
					}
					return this.b;
				}
				[CompilerGenerated]
				set
				{
					this.b = value;
				}
			}

			// Token: 0x040000C4 RID: 196
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool a;

			// Token: 0x040000C5 RID: 197
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;
		}
	}
}
