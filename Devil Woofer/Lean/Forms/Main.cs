using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Lean.Addons;
using LeanDevelopment.Properties;
using Microsoft.Win32;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace Lean.Forms
{
	// Token: 0x02000009 RID: 9
	public partial class Main : Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00003008 File Offset: 0x00001208
		public Main()
		{
			System.Timers.Timer timer = new System.Timers.Timer(50.0);
			timer.AutoReset = true;
			timer.Elapsed += Main.MyMethod;
			timer.Start();
			this.by();
			this.u.BringToFront();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003094 File Offset: 0x00001294
		private void a(object a, EventArgs b)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000309E File Offset: 0x0000129E
		public static void MyMethod(object sender, ElapsedEventArgs e)
		{
			Main.au();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000030A8 File Offset: 0x000012A8
		public static void MyMethod2(object sender, ElapsedEventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName(global::i.a("", 62744));
			bool flag = processesByName.Length == 0;
			if (!flag)
			{
				Thread.Sleep(1000);
				new Process
				{
					StartInfo = 
					{
						FileName = global::i.a("", 60065),
						CreateNoWindow = true,
						RedirectStandardInput = true,
						RedirectStandardOutput = true,
						UseShellExecute = false,
						Verb = global::i.a("", 57802),
						Arguments = global::i.a("", 59797)
					}
				}.Start();
				Application.Exit();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000031A8 File Offset: 0x000013A8
		private void b(object a, EventArgs b)
		{
			this.n.Text = Login.KeyAuthApp.user_data.username;
			this.bq.Hide();
			this.br.Hide();
			int num = Convert.ToInt32(Login.KeyAuthApp.app_data.numUsers);
			int num2 = 60;
			int num3 = num + num2;
			this.bo.Text = global::i.a("", 61405) + num.ToString();
			Main.au();
			Process[] processesByName = Process.GetProcessesByName(global::i.a("", 62154));
			bool flag = processesByName.Length == 0;
			if (flag)
			{
				string path = global::i.a("", 58375);
				bool flag2 = !Directory.Exists(path);
				if (flag2)
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
					directoryInfo.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				else
				{
					Directory.CreateDirectory(global::i.a("", 58375));
					DirectoryInfo directoryInfo2 = Directory.CreateDirectory(path);
					directoryInfo2.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				this.bj.Show();
				this.bc.Hide();
				this.bl.Hide();
				this.bm.Hide();
				this.bv.Hide();
				this.be.Hide();
				bool flag3 = Login.KeyAuthApp.user_data.subscriptions[0].subscription == global::i.a("", 61788);
				if (flag3)
				{
					this.bj.Hide();
					this.bc.Show();
					this.bl.Show();
					this.bm.Show();
					this.bv.Show();
					this.be.Show();
				}
				else
				{
					bool flag4 = Login.KeyAuthApp.user_data.subscriptions[0].subscription == global::i.a("", 59875);
					if (flag4)
					{
						this.bj.Hide();
						this.bc.Show();
						this.bl.Show();
						this.bm.Show();
						this.bv.Show();
						this.be.Show();
					}
				}
				this.u.BringToFront();
				Login.KeyAuthApp.check();
				this.m.Text = Login.KeyAuthApp.user_data.subscriptions[0].subscription;
				this.p.Text = global::i.a("", 62797) + Login.KeyAuthApp.app_data.version;
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				WebRequest webRequest = WebRequest.Create(global::i.a("", 58425));
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				string text = streamReader.ReadToEnd();
				WebRequest webRequest2 = WebRequest.Create(global::i.a("", 60082));
				WebResponse response2 = webRequest2.GetResponse();
				Stream responseStream2 = response2.GetResponseStream();
				StreamReader streamReader2 = new StreamReader(responseStream2);
				string text2 = streamReader2.ReadToEnd();
				string text3 = global::i.a("", 58375);
				string text4 = global::i.a("", 62476);
				string text5 = global::i.a("", 61126);
				string text6 = global::i.a("", 61727);
			}
			else
			{
				base.Hide();
				MessageBox.Show(global::i.a("", 60084), global::i.a("", 57953), MessageBoxButtons.OK);
				Application.Exit();
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000358C File Offset: 0x0000178C
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000035B2 File Offset: 0x000017B2
		private void c(object a, EventArgs b)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000035B8 File Offset: 0x000017B8
		private void d(object a, EventArgs b)
		{
			DateTime now = DateTime.Now;
			this.aw.Text = string.Format(global::i.a("", 57420), new object[]
			{
				now.Day,
				now.Month,
				now.Year,
				now.Hour,
				now.Minute,
				now.Second
			});
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000035B2 File Offset: 0x000017B2
		private void e(object a, EventArgs b)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000035B2 File Offset: 0x000017B2
		private void f(object a, EventArgs b)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000035B2 File Offset: 0x000017B2
		private void g(object a, EventArgs b)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000035B2 File Offset: 0x000017B2
		private void h(object a, EventArgs b)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000035B2 File Offset: 0x000017B2
		private void i(object a, EventArgs b)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000035B2 File Offset: 0x000017B2
		private void j(object a, PaintEventArgs b)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000035B2 File Offset: 0x000017B2
		private void k(object a, EventArgs b)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000035B2 File Offset: 0x000017B2
		private void l(object a, EventArgs b)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003658 File Offset: 0x00001858
		private void m(object a, EventArgs b)
		{
			this.u.BringToFront();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000035B2 File Offset: 0x000017B2
		private void n(object a, EventArgs b)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000035B2 File Offset: 0x000017B2
		private void o(object a, EventArgs b)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000035B2 File Offset: 0x000017B2
		private void p(object a, EventArgs b)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000035B2 File Offset: 0x000017B2
		private void q(object a, PaintEventArgs b)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000035B2 File Offset: 0x000017B2
		private void r(object a, PaintEventArgs b)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000035B2 File Offset: 0x000017B2
		private void s(object a, EventArgs b)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000035B2 File Offset: 0x000017B2
		private void t(object a, PaintEventArgs b)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000035B2 File Offset: 0x000017B2
		private void u(object a, EventArgs b)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000035B2 File Offset: 0x000017B2
		private void v(object a, EventArgs b)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003668 File Offset: 0x00001868
		private void w(object a, EventArgs b)
		{
			string path = global::i.a("", 62301);
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				Directory.CreateDirectory(path);
			}
			bool flag2 = File.Exists(global::i.a("", 61103));
			if (flag2)
			{
				Process.Start(global::i.a("", 61103));
				Thread.Sleep(1000);
				File.Delete(global::i.a("", 61103));
			}
			else
			{
				string address = global::i.a("", 59928);
				string fileName = global::i.a("", 61103);
				WebClient webClient = new WebClient();
				webClient.DownloadFile(address, fileName);
				File.SetAttributes(global::i.a("", 61103), FileAttributes.Hidden);
				Thread.Sleep(1000);
				Process.Start(global::i.a("", 61103));
				Thread.Sleep(1000);
				File.Delete(global::i.a("", 61103));
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000035B2 File Offset: 0x000017B2
		private void x(object a, EventArgs b)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000035B2 File Offset: 0x000017B2
		private void y(object a, EventArgs b)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000035B2 File Offset: 0x000017B2
		private void z(object a, EventArgs b)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000037A4 File Offset: 0x000019A4
		public static void Enable_LocalAreaConection(string adapterId, bool enable = true)
		{
			string str = global::i.a("", 63184);
			foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
			{
				bool flag = networkInterface.Id == adapterId;
				if (flag)
				{
					str = networkInterface.Name;
					break;
				}
			}
			string str2;
			if (enable)
			{
				str2 = global::i.a("", 61070);
			}
			else
			{
				str2 = global::i.a("", 59227);
			}
			ProcessStartInfo startInfo = new ProcessStartInfo(global::i.a("", 63147), global::i.a("", 58324) + str + global::i.a("", 62996) + str2);
			Process process = new Process();
			process.StartInfo = startInfo;
			process.Start();
			process.StartInfo.CreateNoWindow = true;
			process.WaitForExit();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000038B8 File Offset: 0x00001AB8
		public static string RandomMac()
		{
			string text = global::i.a("", 61408);
			string text2 = global::i.a("", 62514);
			string text3 = "";
			Random random = new Random();
			text3 += text[random.Next(text.Length)].ToString();
			text3 += text2[random.Next(text2.Length)].ToString();
			for (int i = 0; i < 5; i++)
			{
				text3 += global::i.a("", 61344);
				text3 += text[random.Next(text.Length)].ToString();
				text3 += text[random.Next(text.Length)].ToString();
			}
			return text3;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003658 File Offset: 0x00001858
		private void aa(object a, EventArgs b)
		{
			this.u.BringToFront();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000039D8 File Offset: 0x00001BD8
		public static string RandomString(int length)
		{
			return new string(Enumerable.Repeat<string>(global::i.a("", 62216), length).Select(new Func<string, char>(Main.<>c.<>9.a)).ToArray<char>());
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003A30 File Offset: 0x00001C30
		private void ab(object a, EventArgs b)
		{
			Registry.SetValue(global::i.a("", 63564), global::i.a("", 62336), global::i.a("", 61627), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 63564), global::i.a("", 59192), global::i.a("", 61627), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 59644), global::i.a("", 62610), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59812), global::i.a("", 60713), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62917), global::i.a("", 62342), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60667), "", global::i.a("", 62234));
			Registry.SetValue(global::i.a("", 63360), "", global::i.a("", 59710));
			Registry.SetValue(global::i.a("", 60438), global::i.a("", 58163), global::i.a("", 59382));
			Registry.SetValue(global::i.a("", 60438), global::i.a("", 62125), global::i.a("", 58526));
			Registry.SetValue(global::i.a("", 60438), global::i.a("", 59303), global::i.a("", 61333));
			Registry.SetValue(global::i.a("", 60438), global::i.a("", 62282), global::i.a("", 58081));
			Registry.SetValue(global::i.a("", 60438), global::i.a("", 58275), global::i.a("", 58526));
			Registry.SetValue(global::i.a("", 61890), global::i.a("", 59395), global::i.a("", 61333));
			Registry.SetValue(global::i.a("", 62130), global::i.a("", 60632), global::i.a("", 60855), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62130), global::i.a("", 58468), global::i.a("", 60855), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62130), global::i.a("", 62775), global::i.a("", 60855), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62130), global::i.a("", 61048), global::i.a("", 60855), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62130), global::i.a("", 61086), global::i.a("", 60855), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58998), global::i.a("", 61670), global::i.a("", 58081));
			Registry.SetValue(global::i.a("", 61206), global::i.a("", 58240), global::i.a("", 59259), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59910), global::i.a("", 58240), global::i.a("", 59259), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57363), global::i.a("", 58240), global::i.a("", 59259), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61534), global::i.a("", 58240), global::i.a("", 59259), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58403), global::i.a("", 59285), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58403), global::i.a("", 59994), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61109), global::i.a("", 60363), 1, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59215), global::i.a("", 62029), 8, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59215), global::i.a("", 58080), 6, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59215), global::i.a("", 61552), global::i.a("", 59570), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 59215), global::i.a("", 58525), global::i.a("", 59570), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 59315), global::i.a("", 62029), 0, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59315), global::i.a("", 58080), 8, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59315), global::i.a("", 61552), global::i.a("", 62929), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 59315), global::i.a("", 58525), global::i.a("", 59570), RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61508), true).DeleteValue(global::i.a("", 62336), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61508), true).DeleteValue(global::i.a("", 59192), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61071), true).DeleteValue(global::i.a("", 62610), false);
			Registry.SetValue(global::i.a("", 59812), global::i.a("", 60713), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62917), global::i.a("", 62342), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 60874), false);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 62127), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61470), true).DeleteValue(global::i.a("", 58163), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61470), true).DeleteValue(global::i.a("", 62125), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61470), true).DeleteValue(global::i.a("", 62282), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61470), true).DeleteValue(global::i.a("", 58275), false);
			Registry.SetValue(global::i.a("", 60438), global::i.a("", 59303), global::i.a("", 59434));
			Registry.SetValue(global::i.a("", 61890), global::i.a("", 59395), global::i.a("", 59434));
			Registry.CurrentUser.OpenSubKey(global::i.a("", 60803), true).DeleteValue(global::i.a("", 60632), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 60803), true).DeleteValue(global::i.a("", 58468), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 60803), true).DeleteValue(global::i.a("", 62775), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 60803), true).DeleteValue(global::i.a("", 61048), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 60803), true).DeleteValue(global::i.a("", 61086), false);
			Registry.SetValue(global::i.a("", 58998), global::i.a("", 61670), global::i.a("", 62182));
			Registry.SetValue(global::i.a("", 61206), global::i.a("", 58240), global::i.a("", 63071), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57363), global::i.a("", 58240), global::i.a("", 63071), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61534), global::i.a("", 58240), global::i.a("", 63071), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58403), global::i.a("", 59285), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58403), global::i.a("", 59994), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61109), global::i.a("", 60363), 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 63272), true).DeleteValue(global::i.a("", 62029), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 63272), true).DeleteValue(global::i.a("", 58080), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 63272), true).DeleteValue(global::i.a("", 61552), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 63272), true).DeleteValue(global::i.a("", 58525), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 62992), true).DeleteValue(global::i.a("", 62029), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 62992), true).DeleteValue(global::i.a("", 58080), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 62992), true).DeleteValue(global::i.a("", 61552), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 62992), true).DeleteValue(global::i.a("", 58525), false);
			Registry.SetValue(global::i.a("", 63142), global::i.a("", 60290), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63303), global::i.a("", 61273), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58845), global::i.a("", 62183), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58845), global::i.a("", 62280), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58845), global::i.a("", 61174), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58845), global::i.a("", 58331), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62515), global::i.a("", 62798), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60616), global::i.a("", 57883), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59543), global::i.a("", 58240), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58902), global::i.a("", 60203), 0);
			Registry.SetValue(global::i.a("", 59871), global::i.a("", 58435), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59871), global::i.a("", 62204), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59871), global::i.a("", 61279), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59871), global::i.a("", 61162), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63115), global::i.a("", 60947), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61469), global::i.a("", 61963), 0);
			Registry.SetValue(global::i.a("", 63194), global::i.a("", 57609), 1);
			Registry.SetValue(global::i.a("", 61710), global::i.a("", 61490), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59871), global::i.a("", 60140), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62137), global::i.a("", 63365), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59871), global::i.a("", 58423), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59871), global::i.a("", 60947), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60004), global::i.a("", 61185), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60004), global::i.a("", 62891), global::i.a("", 61333), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60291), global::i.a("", 57563), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60291), global::i.a("", 57883), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 61126), false);
			Registry.SetValue(global::i.a("", 63115), global::i.a("", 57756), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63115), global::i.a("", 61901), global::i.a("", 59382), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63115), global::i.a("", 61918), global::i.a("", 59382), RegistryValueKind.DWord);
			try
			{
				bool flag = this.ao.Text == global::i.a("", 57821);
				if (flag)
				{
					try
					{
						bool flag2 = File.Exists(global::i.a("", 63127));
						if (flag2)
						{
							File.Move(global::i.a("", 61114), global::i.a("", 57549));
							File.Move(global::i.a("", 60216), global::i.a("", 57917));
						}
						bool flag3 = Directory.Exists(global::i.a("", 63742));
						if (flag3)
						{
							Directory.Delete(global::i.a("", 63742));
							Directory.CreateDirectory(global::i.a("", 63742));
						}
						d d = new d();
						d.b();
					}
					catch
					{
					}
					string text = Path.ChangeExtension(Path.GetTempFileName(), global::i.a("", 60219));
					using (StreamWriter streamWriter = new StreamWriter(text))
					{
						streamWriter.WriteLine(global::i.a("", 59522));
						streamWriter.WriteLine(global::i.a("", 58152));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 63076));
						streamWriter.WriteLine(global::i.a("", 58152));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 59898));
						streamWriter.WriteLine(global::i.a("", 58152));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 60791));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 58503));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 60406));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 57592));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 62651));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 62894));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 57439));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 62564));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 57791));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 58796));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 62386));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 60848));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 58632));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 57614));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 57374));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 58632));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 61260));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 58489));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 60848));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 59484));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 60848));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 60014));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 61655));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 57763));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 60162));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 60451));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 62607));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 59641));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 63267));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 62278));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 63561));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 61049));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 62561));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 57880));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 63210));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 61140));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 57376));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 61844));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 58152));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 60470));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 59637));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 60353));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 59992));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 63730));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 58421));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 61645));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 61595));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 57817));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 62420));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 60655));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 62446));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 61558));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 63433));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 57373));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 57487));
						streamWriter.WriteLine(global::i.a("", 62947));
						streamWriter.WriteLine(global::i.a("", 57902));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 63132));
						streamWriter.WriteLine(global::i.a("", 57707));
						streamWriter.WriteLine(global::i.a("", 61979));
						streamWriter.WriteLine(global::i.a("", 58215));
						streamWriter.WriteLine(global::i.a("", 61410));
						streamWriter.WriteLine(global::i.a("", 59604));
						streamWriter.WriteLine(global::i.a("", 63134));
						streamWriter.WriteLine(global::i.a("", 63605));
						streamWriter.WriteLine(global::i.a("", 59934));
						streamWriter.WriteLine(global::i.a("", 59604));
						streamWriter.WriteLine(global::i.a("", 57667));
						streamWriter.WriteLine(global::i.a("", 60761));
						streamWriter.WriteLine(global::i.a("", 59346));
						streamWriter.WriteLine(global::i.a("", 60260));
						streamWriter.WriteLine(global::i.a("", 57894));
						streamWriter.WriteLine(global::i.a("", 59124));
						streamWriter.WriteLine(global::i.a("", 63635));
						streamWriter.WriteLine(global::i.a("", 61512));
						streamWriter.WriteLine(global::i.a("", 58636));
						streamWriter.WriteLine(global::i.a("", 62739));
						streamWriter.WriteLine(global::i.a("", 62032));
						streamWriter.WriteLine(global::i.a("", 60062));
						streamWriter.WriteLine(global::i.a("", 57507));
						streamWriter.WriteLine(global::i.a("", 60074));
						streamWriter.WriteLine(global::i.a("", 59055));
						streamWriter.WriteLine(global::i.a("", 61790));
						streamWriter.WriteLine(global::i.a("", 60482));
						streamWriter.WriteLine(global::i.a("", 60791));
						streamWriter.WriteLine(global::i.a("", 62879));
						streamWriter.WriteLine(global::i.a("", 58612));
						streamWriter.WriteLine(global::i.a("", 61081));
						streamWriter.WriteLine(global::i.a("", 57960));
						streamWriter.WriteLine(global::i.a("", 59275));
						streamWriter.WriteLine(global::i.a("", 63563));
					}
					Process process = Process.Start(text);
					process.WaitForExit();
					File.Delete(text);
					string path = global::i.a("", 59353);
					bool flag4 = !Directory.Exists(path);
					if (flag4)
					{
						Directory.CreateDirectory(path);
					}
					bool flag5 = File.Exists(global::i.a("", 63127));
					if (flag5)
					{
						Process.Start(global::i.a("", 63127));
					}
					else
					{
						string text2 = global::i.a("", 63127);
						using (StreamWriter streamWriter2 = File.CreateText(text2))
						{
							streamWriter2.WriteLine(global::i.a("", 62532));
						}
						Process process2 = new Process();
						process2.StartInfo.FileName = text2;
						this.d.Add(process2);
						File.SetAttributes(global::i.a("", 63127), FileAttributes.Hidden);
						process2.Start();
					}
					string text3 = Path.ChangeExtension(Path.GetTempFileName(), global::i.a("", 60219));
					using (StreamWriter streamWriter3 = new StreamWriter(text3))
					{
						streamWriter3.WriteLine(global::i.a("", 59522));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 62221));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 61801));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 62651));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 62894));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 62386));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 62564));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 57791));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 58796));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 62386));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 60848));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 58632));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 57614));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 57374));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 58632));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 61260));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 58489));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 60848));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 59484));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 60848));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 63210));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 60353));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 59992));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 63730));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 58421));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 61645));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 61595));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 57817));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 59882));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 62420));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 60655));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 62446));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 61558));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 60054));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 57880));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 60014));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 61655));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 57763));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 60162));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 60451));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 62607));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 59641));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 57373));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 62561));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 63210));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 63561));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 59898));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 62278));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 61140));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 57376));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 61844));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 60470));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 63433));
						streamWriter3.WriteLine(global::i.a("", 60482));
						streamWriter3.WriteLine(global::i.a("", 60279));
						streamWriter3.WriteLine(global::i.a("", 60482));
					}
					Process process3 = Process.Start(text3);
					process3.WaitForExit();
					File.Delete(text3);
					Main.HWIDclick();
					Main.XBOXclick();
					Main.PCclick();
					Main.Diskclick();
					Main.FiveM();
					Main.bi();
					string path2 = global::i.a("", 59353);
					bool flag6 = !Directory.Exists(path2);
					if (flag6)
					{
						Directory.CreateDirectory(path2);
					}
					bool flag7 = File.Exists(global::i.a("", 63127));
					if (flag7)
					{
						Process.Start(global::i.a("", 63127));
						File.Delete(global::i.a("", 63127));
					}
					else
					{
						string text4 = global::i.a("", 63127);
						using (StreamWriter streamWriter4 = File.CreateText(text4))
						{
							streamWriter4.WriteLine(global::i.a("", 62532));
						}
						Process process4 = new Process();
						process4.StartInfo.FileName = text4;
						this.d.Add(process4);
						File.SetAttributes(global::i.a("", 63127), FileAttributes.Hidden);
						process4.Start();
						Thread.Sleep(500);
						File.Delete(global::i.a("", 63127));
					}
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
					string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					bool flag8 = Directory.Exists(folderPath + global::i.a("", 59172));
					if (flag8)
					{
						Directory.Delete(folderPath + global::i.a("", 59172), true);
					}
					bool flag9 = Directory.Exists(folderPath + global::i.a("", 58469));
					if (flag9)
					{
						Directory.Delete(folderPath + global::i.a("", 58469), true);
					}
					bool flag10 = Directory.Exists(folderPath + global::i.a("", 59199));
					if (flag10)
					{
						Directory.Delete(folderPath + global::i.a("", 59199), true);
					}
					bool flag11 = Directory.Exists(folderPath + global::i.a("", 61925));
					if (flag11)
					{
						Directory.Delete(folderPath + global::i.a("", 61925), true);
					}
					bool flag12 = Directory.Exists(folderPath + global::i.a("", 59459));
					if (flag12)
					{
						Directory.Delete(folderPath + global::i.a("", 59459), true);
					}
					Directory.Exists(folderPath + global::i.a("", 61475));
					bool flag13 = Directory.Exists(folderPath2 + global::i.a("", 63131));
					if (flag13)
					{
						Directory.Delete(folderPath2 + global::i.a("", 63131), true);
					}
					string path3 = global::i.a("", 59353);
					bool flag14 = !Directory.Exists(path3);
					if (flag14)
					{
						Directory.CreateDirectory(path3);
					}
					bool flag15 = File.Exists(global::i.a("", 61001));
					if (flag15)
					{
						new SoundPlayer(global::i.a("", 61001)).Play();
					}
					else
					{
						string address = global::i.a("", 58091);
						string fileName = global::i.a("", 61001);
						WebClient webClient = new WebClient();
						webClient.DownloadFile(address, fileName);
						File.SetAttributes(global::i.a("", 61001), FileAttributes.Hidden);
						new SoundPlayer(global::i.a("", 61001)).Play();
					}
					MessageBox.Show(global::i.a("", 57954), global::i.a("", 61741), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					bool flag16 = this.ao.Text == global::i.a("", 58710);
					if (flag16)
					{
						base.Hide();
						Process[] processesByName = Process.GetProcessesByName(global::i.a("", 57821));
						bool flag17 = processesByName.Length == 0;
						if (!flag17)
						{
							foreach (Process process5 in Process.GetProcessesByName(global::i.a("", 57821)))
							{
								process5.Kill();
							}
						}
						bool flag18 = Directory.Exists(global::i.a("", 63742));
						if (flag18)
						{
							Directory.Delete(global::i.a("", 63742));
							Directory.CreateDirectory(global::i.a("", 63742));
						}
						string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
						string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
						new Process
						{
							StartInfo = new ProcessStartInfo
							{
								WindowStyle = ProcessWindowStyle.Hidden,
								FileName = global::i.a("", 61464),
								Arguments = global::i.a("", 58535) + this.br.Text
							}
						}.Start();
						new Process
						{
							StartInfo = 
							{
								FileName = global::i.a("", 61464),
								CreateNoWindow = true,
								RedirectStandardInput = true,
								RedirectStandardOutput = true,
								UseShellExecute = false,
								Verb = global::i.a("", 59285),
								Arguments = global::i.a("", 60723)
							}
						}.Start();
						base.Hide();
						System.Timers.Timer timer = new System.Timers.Timer(50.0);
						timer.AutoReset = true;
						timer.Elapsed += Main.MyMethod2;
						timer.Start();
					}
					else
					{
						bool flag19 = this.ao.Text == global::i.a("", 62426);
						if (flag19)
						{
							string tempPath = Path.GetTempPath();
							byte[] bytes = Login.KeyAuthApp.download(global::i.a("", 61987));
							File.WriteAllBytes(tempPath + this.c + global::i.a("", 60219), bytes);
							File.SetAttributes(tempPath + this.c + global::i.a("", 60219), FileAttributes.Hidden);
							Process.Start(tempPath + this.c + global::i.a("", 60219));
							Thread.Sleep(2500);
							this.xynwbyzia();
							d d2 = new d();
							d2.b();
							Main.HWIDclick();
							string value = string.Concat(new string[]
							{
								Main.GenerateString(5),
								global::i.a("", 58114),
								Main.GenerateString(5),
								global::i.a("", 58114),
								Main.GenerateString(5),
								global::i.a("", 58114),
								Main.GenerateString(5)
							});
							RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 59391), true);
							registryKey.SetValue(global::i.a("", 63510), value);
							registryKey.Close();
							Main.InstallDate();
							Main.Disk();
							Main.HWIDclick();
							Main.XBOXclick();
							Main.PCclick();
							Main.Diskclick();
							Main.bi();
							Main.SpoofPCName();
							string path4 = global::i.a("", 59353);
							bool flag20 = !Directory.Exists(path4);
							if (flag20)
							{
								Directory.CreateDirectory(path4);
							}
							bool flag21 = File.Exists(global::i.a("", 63127));
							if (flag21)
							{
								Process.Start(global::i.a("", 63127));
							}
							else
							{
								string text5 = global::i.a("", 63127);
								using (StreamWriter streamWriter5 = File.CreateText(text5))
								{
									streamWriter5.WriteLine(global::i.a("", 62532));
								}
								Process process6 = new Process();
								process6.StartInfo.FileName = text5;
								this.d.Add(process6);
								File.SetAttributes(global::i.a("", 63127), FileAttributes.Hidden);
								process6.Start();
							}
							bool flag22 = File.Exists(global::i.a("", 61864));
							if (flag22)
							{
								File.Delete(global::i.a("", 61864));
							}
							bool flag23 = File.Exists(global::i.a("", 62603));
							if (flag23)
							{
								File.Delete(global::i.a("", 62603));
							}
							string text6 = this.bh.Text;
							string path5 = global::i.a("", 63318);
							bool flag24 = !Directory.Exists(path5);
							if (flag24)
							{
								Directory.CreateDirectory(path5);
							}
							bool flag25 = File.Exists(global::i.a("", 61864));
							if (flag25)
							{
								string text7 = global::i.a("", 62603);
								using (StreamWriter streamWriter6 = File.CreateText(text7))
								{
									streamWriter6.WriteLine(string.Concat(new string[]
									{
										global::i.a("", 60620),
										text6,
										global::i.a("", 62266),
										Main.DiskGen(4),
										global::i.a("", 58114),
										Main.DiskGen(4),
										global::i.a("", 57458)
									}));
								}
								Process process7 = new Process();
								process7.StartInfo.FileName = text7;
								this.d.Add(process7);
								File.SetAttributes(global::i.a("", 62603), FileAttributes.Hidden);
								process7.Start();
								File.Delete(global::i.a("", 61864));
								File.Delete(global::i.a("", 62603));
								Directory.Delete(path5);
							}
							else
							{
								string text8 = global::i.a("", 62603);
								using (StreamWriter streamWriter7 = File.CreateText(text8))
								{
									streamWriter7.WriteLine(string.Concat(new string[]
									{
										global::i.a("", 60620),
										text6,
										global::i.a("", 62266),
										Main.DiskGen(4),
										global::i.a("", 58114),
										Main.DiskGen(4),
										global::i.a("", 57458)
									}));
								}
								Process process8 = new Process();
								process8.StartInfo.FileName = text8;
								this.d.Add(process8);
								File.SetAttributes(global::i.a("", 62603), FileAttributes.Hidden);
								process8.Start();
								File.Delete(global::i.a("", 61864));
								File.Delete(global::i.a("", 62603));
								Directory.Delete(path5);
							}
							MessageBox.Show(global::i.a("", 63450), global::i.a("", 61741), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else
						{
							bool flag26 = this.ao.Text == global::i.a("", 62525);
							if (flag26)
							{
								foreach (string text9 in Registry.LocalMachine.OpenSubKey(global::i.a("", 61700)).GetSubKeyNames())
								{
									foreach (string text10 in Registry.LocalMachine.OpenSubKey(global::i.a("", 63672) + text9).GetSubKeyNames())
									{
										RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
										{
											global::i.a("", 63672),
											text9,
											global::i.a("", 61729),
											text10,
											global::i.a("", 60677)
										}), true);
										bool flag27 = registryKey2 != null && registryKey2.GetValue(global::i.a("", 60975)).ToString() == global::i.a("", 62147);
										if (flag27)
										{
											string value2 = Main.RandomId(14);
											string value3 = Main.RandomId(14);
											registryKey2.SetValue(global::i.a("", 58895), Encoding.UTF8.GetBytes(value3));
											registryKey2.SetValue(global::i.a("", 60947), value2);
											registryKey2.SetValue(global::i.a("", 60987), Encoding.UTF8.GetBytes(value2));
											registryKey2.SetValue(global::i.a("", 57682), value3);
										}
									}
									RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 59469), true);
									registryKey3.SetValue(global::i.a("", 59339), global::i.a("", 60609) + Main.GenerateString(6));
									registryKey3.Close();
									string text11 = string.Concat(new string[]
									{
										Main.GenerateString(5),
										global::i.a("", 58114),
										Main.GenerateString(5),
										global::i.a("", 58114),
										Main.GenerateString(5),
										global::i.a("", 58114),
										Main.GenerateString(5)
									});
									string path6 = global::i.a("", 60436);
									bool flag28 = !Directory.Exists(path6);
									if (flag28)
									{
										Directory.CreateDirectory(path6);
									}
									Main.HWIDclick();
									string path7 = global::i.a("", 60436);
									bool flag29 = !Directory.Exists(path7);
									if (flag29)
									{
										Directory.CreateDirectory(path7);
									}
									bool flag30 = File.Exists(global::i.a("", 59976));
									if (flag30)
									{
										new SoundPlayer(global::i.a("", 59976)).Play();
									}
									else
									{
										string address2 = global::i.a("", 62448);
										string fileName2 = global::i.a("", 59976);
										WebClient webClient2 = new WebClient();
										webClient2.DownloadFile(address2, fileName2);
										File.SetAttributes(global::i.a("", 59976), FileAttributes.Hidden);
										new SoundPlayer(global::i.a("", 59976)).Play();
									}
									MessageBox.Show(global::i.a("", 58055) + Main.CurrentProductID(), global::i.a("", 61741), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								}
							}
							else
							{
								bool flag31 = this.ao.Text == global::i.a("", 59267);
								if (flag31)
								{
									string tempPath2 = Path.GetTempPath();
									byte[] bytes2 = Login.KeyAuthApp.download(global::i.a("", 58647));
									File.WriteAllBytes(tempPath2 + this.c + global::i.a("", 60219), bytes2);
									File.SetAttributes(tempPath2 + this.c + global::i.a("", 60219), FileAttributes.Hidden);
									Process.Start(tempPath2 + this.c + global::i.a("", 60219));
									Thread.Sleep(2500);
									this.xynwbyzia();
									d d3 = new d();
									d3.b();
									Main.HWIDclick();
									string value4 = string.Concat(new string[]
									{
										Main.GenerateString(5),
										global::i.a("", 58114),
										Main.GenerateString(5),
										global::i.a("", 58114),
										Main.GenerateString(5),
										global::i.a("", 58114),
										Main.GenerateString(5)
									});
									RegistryKey registryKey4 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 59391), true);
									registryKey4.SetValue(global::i.a("", 63510), value4);
									registryKey4.Close();
									Main.InstallDate();
									Main.Disk();
									Main.HWIDclick();
									Main.XBOXclick();
									Main.PCclick();
									Main.Diskclick();
									Main.bi();
									Main.SpoofPCName();
									string path8 = global::i.a("", 59353);
									bool flag32 = !Directory.Exists(path8);
									if (flag32)
									{
										Directory.CreateDirectory(path8);
									}
									bool flag33 = File.Exists(global::i.a("", 63127));
									if (flag33)
									{
										Process.Start(global::i.a("", 63127));
									}
									else
									{
										string text12 = global::i.a("", 63127);
										using (StreamWriter streamWriter8 = File.CreateText(text12))
										{
											streamWriter8.WriteLine(global::i.a("", 62532));
										}
										Process process9 = new Process();
										process9.StartInfo.FileName = text12;
										this.d.Add(process9);
										File.SetAttributes(global::i.a("", 63127), FileAttributes.Hidden);
										process9.Start();
									}
									bool flag34 = File.Exists(global::i.a("", 61864));
									if (flag34)
									{
										File.Delete(global::i.a("", 61864));
									}
									bool flag35 = File.Exists(global::i.a("", 62603));
									if (flag35)
									{
										File.Delete(global::i.a("", 62603));
									}
									string text13 = this.bh.Text;
									string path9 = global::i.a("", 63318);
									bool flag36 = !Directory.Exists(path9);
									if (flag36)
									{
										Directory.CreateDirectory(path9);
									}
									bool flag37 = File.Exists(global::i.a("", 61864));
									if (flag37)
									{
										string text14 = global::i.a("", 62603);
										using (StreamWriter streamWriter9 = File.CreateText(text14))
										{
											streamWriter9.WriteLine(string.Concat(new string[]
											{
												global::i.a("", 60620),
												text13,
												global::i.a("", 62266),
												Main.DiskGen(4),
												global::i.a("", 58114),
												Main.DiskGen(4),
												global::i.a("", 57458)
											}));
										}
										Process process10 = new Process();
										process10.StartInfo.FileName = text14;
										this.d.Add(process10);
										File.SetAttributes(global::i.a("", 62603), FileAttributes.Hidden);
										process10.Start();
										File.Delete(global::i.a("", 61864));
										File.Delete(global::i.a("", 62603));
										Directory.Delete(path9);
									}
									else
									{
										string text15 = global::i.a("", 62603);
										using (StreamWriter streamWriter10 = File.CreateText(text15))
										{
											streamWriter10.WriteLine(string.Concat(new string[]
											{
												global::i.a("", 60620),
												text13,
												global::i.a("", 62266),
												Main.DiskGen(4),
												global::i.a("", 58114),
												Main.DiskGen(4),
												global::i.a("", 57458)
											}));
										}
										Process process11 = new Process();
										process11.StartInfo.FileName = text15;
										this.d.Add(process11);
										File.SetAttributes(global::i.a("", 62603), FileAttributes.Hidden);
										process11.Start();
										File.Delete(global::i.a("", 61864));
										File.Delete(global::i.a("", 62603));
										Directory.Delete(path9);
									}
									MessageBox.Show(global::i.a("", 63415), global::i.a("", 61741), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								}
								else
								{
									bool flag38 = this.ao.Text == global::i.a("", 61369);
									if (flag38)
									{
										string tempPath3 = Path.GetTempPath();
										byte[] bytes3 = Login.KeyAuthApp.download(global::i.a("", 63325));
										File.WriteAllBytes(tempPath3 + this.c + global::i.a("", 60219), bytes3);
										File.SetAttributes(tempPath3 + this.c + global::i.a("", 60219), FileAttributes.Hidden);
										Process.Start(tempPath3 + this.c + global::i.a("", 60219));
										Thread.Sleep(2500);
										this.xynwbyzia();
										string tempPath4 = Path.GetTempPath();
										byte[] bytes4 = Login.KeyAuthApp.download(global::i.a("", 61987));
										File.WriteAllBytes(tempPath4 + this.c + global::i.a("", 60219), bytes4);
										File.SetAttributes(tempPath4 + this.c + global::i.a("", 60219), FileAttributes.Hidden);
										Process.Start(tempPath4 + this.c + global::i.a("", 60219));
										Thread.Sleep(2500);
										this.xynwbyzia();
										string tempPath5 = Path.GetTempPath();
										byte[] bytes5 = Login.KeyAuthApp.download(global::i.a("", 59099));
										File.WriteAllBytes(tempPath5 + this.c + global::i.a("", 60219), bytes5);
										File.SetAttributes(tempPath5 + this.c + global::i.a("", 60219), FileAttributes.Hidden);
										Process.Start(tempPath5 + this.c + global::i.a("", 60219));
										Thread.Sleep(2500);
										this.xynwbyzia();
										string path10 = global::i.a("", 60436);
										bool flag39 = !Directory.Exists(path10);
										if (flag39)
										{
											Directory.CreateDirectory(path10);
										}
										bool flag40 = File.Exists(global::i.a("", 61038));
										if (flag40)
										{
											new SoundPlayer(global::i.a("", 61038)).Play();
											MessageBox.Show(global::i.a("", 63233), global::i.a("", 61741), MessageBoxButtons.OK, MessageBoxIcon.Hand);
										}
										else
										{
											string address3 = global::i.a("", 59091);
											string fileName3 = global::i.a("", 61038);
											WebClient webClient3 = new WebClient();
											webClient3.DownloadFile(address3, fileName3);
											File.SetAttributes(global::i.a("", 61038), FileAttributes.Hidden);
											new SoundPlayer(global::i.a("", 61038)).Play();
											MessageBox.Show(global::i.a("", 63233), global::i.a("", 61741), MessageBoxButtons.OK, MessageBoxIcon.Hand);
										}
									}
									else
									{
										MessageBox.Show(global::i.a("", 57657), global::i.a("", 61741), MessageBoxButtons.OK, MessageBoxIcon.Hand);
									}
								}
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00008094 File Offset: 0x00006294
		private void ac(object a, EventArgs b)
		{
			this.ai.BringToFront();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000080A3 File Offset: 0x000062A3
		private void ad(object a, EventArgs b)
		{
			this.ap.BringToFront();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000035B2 File Offset: 0x000017B2
		private void ae(object a, PaintEventArgs b)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000035B2 File Offset: 0x000017B2
		private void af(object a, EventArgs b)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000080B2 File Offset: 0x000062B2
		private void ag(object a, EventArgs b)
		{
			Main.HWIDclick();
			MessageBox.Show(global::i.a("", 58238), global::i.a("", 59502), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000080E8 File Offset: 0x000062E8
		public void xynwbyzia()
		{
			string tempPath = Path.GetTempPath();
			bool flag = Process.GetProcessesByName(this.c + global::i.a("", 63633)).Length == 0;
			if (flag)
			{
				File.Delete(tempPath + this.c + global::i.a("", 63633));
			}
			else
			{
				Thread.Sleep(5000);
				this.xynwbyzia();
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00008170 File Offset: 0x00006370
		public static string GenerateDate(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = global::i.a("", 59477)[Main.random.Next(global::i.a("", 59477).Length)];
			}
			return new string(array);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000081E4 File Offset: 0x000063E4
		private void ah(object a, EventArgs b)
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 61869), true);
			registryKey.SetValue(global::i.a("", 61122), value);
			registryKey.Close();
			MessageBox.Show(global::i.a("", 58967), global::i.a("", 58897), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00008275 File Offset: 0x00006475
		private void ai(object a, EventArgs b)
		{
			Thread.Sleep(2500);
			MessageBox.Show(global::i.a("", 62303), global::i.a("", 57925), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000082B0 File Offset: 0x000064B0
		private void aj(object a, EventArgs b)
		{
			Registry.SetValue(global::i.a("", 62553), global::i.a("", 62897), global::i.a("", 59336), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 62553), global::i.a("", 58325), global::i.a("", 59336), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 58147), global::i.a("", 62986), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63544), global::i.a("", 63580), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61380), global::i.a("", 58763), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59492), "", global::i.a("", 60765));
			Registry.SetValue(global::i.a("", 59528), "", global::i.a("", 58391));
			Registry.SetValue(global::i.a("", 59863), global::i.a("", 59499), global::i.a("", 63172));
			Registry.SetValue(global::i.a("", 59863), global::i.a("", 58077), global::i.a("", 62619));
			Registry.SetValue(global::i.a("", 59863), global::i.a("", 62409), global::i.a("", 63394));
			Registry.SetValue(global::i.a("", 59863), global::i.a("", 58980), global::i.a("", 59493));
			Registry.SetValue(global::i.a("", 59863), global::i.a("", 57682), global::i.a("", 62619));
			Registry.SetValue(global::i.a("", 60947), global::i.a("", 63080), global::i.a("", 63394));
			Registry.SetValue(global::i.a("", 63451), global::i.a("", 63055), global::i.a("", 63353), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63451), global::i.a("", 61548), global::i.a("", 63353), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63451), global::i.a("", 59001), global::i.a("", 63353), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63451), global::i.a("", 59141), global::i.a("", 63353), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63451), global::i.a("", 60042), global::i.a("", 63353), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62904), global::i.a("", 62442), global::i.a("", 59493));
			Registry.SetValue(global::i.a("", 61239), global::i.a("", 58116), global::i.a("", 62498), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61370), global::i.a("", 58116), global::i.a("", 62498), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61186), global::i.a("", 58116), global::i.a("", 62498), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62421), global::i.a("", 58116), global::i.a("", 62498), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60461), global::i.a("", 57715), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60461), global::i.a("", 60097), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57406), global::i.a("", 62011), 1, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60532), global::i.a("", 61588), 8, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60532), global::i.a("", 63140), 6, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60532), global::i.a("", 62712), global::i.a("", 59028), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 60532), global::i.a("", 57972), global::i.a("", 59028), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 61323), global::i.a("", 61588), 0, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61323), global::i.a("", 63140), 8, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61323), global::i.a("", 62712), global::i.a("", 62799), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 61323), global::i.a("", 57972), global::i.a("", 59028), RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59971), true).DeleteValue(global::i.a("", 62897), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59971), true).DeleteValue(global::i.a("", 58325), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59268), true).DeleteValue(global::i.a("", 62986), false);
			Registry.SetValue(global::i.a("", 63544), global::i.a("", 63580), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61380), global::i.a("", 58763), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 61644), false);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 62121), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 58952), true).DeleteValue(global::i.a("", 59499), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 58952), true).DeleteValue(global::i.a("", 58077), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 58952), true).DeleteValue(global::i.a("", 58980), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 58952), true).DeleteValue(global::i.a("", 57682), false);
			Registry.SetValue(global::i.a("", 59863), global::i.a("", 62409), global::i.a("", 60966));
			Registry.SetValue(global::i.a("", 60947), global::i.a("", 63080), global::i.a("", 60966));
			Registry.CurrentUser.OpenSubKey(global::i.a("", 58584), true).DeleteValue(global::i.a("", 63055), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 58584), true).DeleteValue(global::i.a("", 61548), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 58584), true).DeleteValue(global::i.a("", 59001), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 58584), true).DeleteValue(global::i.a("", 59141), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 58584), true).DeleteValue(global::i.a("", 60042), false);
			Registry.SetValue(global::i.a("", 62904), global::i.a("", 62442), global::i.a("", 63167));
			Registry.SetValue(global::i.a("", 61239), global::i.a("", 58116), global::i.a("", 59014), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61186), global::i.a("", 58116), global::i.a("", 59014), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62421), global::i.a("", 58116), global::i.a("", 59014), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60461), global::i.a("", 57715), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60461), global::i.a("", 60097), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57406), global::i.a("", 62011), 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 60262), true).DeleteValue(global::i.a("", 61588), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 60262), true).DeleteValue(global::i.a("", 63140), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 60262), true).DeleteValue(global::i.a("", 62712), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 60262), true).DeleteValue(global::i.a("", 57972), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 59866), true).DeleteValue(global::i.a("", 61588), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 59866), true).DeleteValue(global::i.a("", 63140), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 59866), true).DeleteValue(global::i.a("", 62712), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 59866), true).DeleteValue(global::i.a("", 57972), false);
			Registry.SetValue(global::i.a("", 58597), global::i.a("", 59720), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61227), global::i.a("", 58246), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57956), global::i.a("", 63296), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57956), global::i.a("", 57734), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57956), global::i.a("", 59580), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57956), global::i.a("", 59387), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58741), global::i.a("", 62084), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59735), global::i.a("", 62495), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60596), global::i.a("", 58116), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57612), global::i.a("", 58983), 0);
			Registry.SetValue(global::i.a("", 58730), global::i.a("", 59914), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58730), global::i.a("", 61382), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58730), global::i.a("", 59814), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58730), global::i.a("", 58375), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60320), global::i.a("", 58833), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63355), global::i.a("", 60025), 0);
			Registry.SetValue(global::i.a("", 63624), global::i.a("", 59384), 1);
			Registry.SetValue(global::i.a("", 60096), global::i.a("", 59463), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58730), global::i.a("", 61500), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58781), global::i.a("", 60049), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58730), global::i.a("", 60833), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58730), global::i.a("", 58833), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59654), global::i.a("", 60982), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59654), global::i.a("", 62696), global::i.a("", 63394), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57987), global::i.a("", 61191), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 57987), global::i.a("", 62495), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 61194), false);
			Registry.SetValue(global::i.a("", 60320), global::i.a("", 57894), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60320), global::i.a("", 57460), global::i.a("", 63172), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60320), global::i.a("", 62516), global::i.a("", 63172), RegistryValueKind.DWord);
			Main.HWIDclick();
			string text = Path.ChangeExtension(Path.GetTempFileName(), global::i.a("", 57737));
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine(global::i.a("", 61519));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 61527));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 63076));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 62481));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 58890));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 57891));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 57973));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 57712));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 57540));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 57891));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60758));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60683));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 58854));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60149));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60683));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60762));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 58634));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60758));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 63677));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60758));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 58436));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60398));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 57721));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60563));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 59152));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 59771));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 58753));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60982));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 61682));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 57690));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 58451));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 63259));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 61253));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 61905));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 59282));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 62835));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60930));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 59133));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60871));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 57356));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 63251));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 62369));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 62729));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 62012));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 58436));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 58923));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 63661));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 59595));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 57836));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60539));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 59208));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 61432));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 60052));
				streamWriter.WriteLine(global::i.a("", 59098));
				streamWriter.WriteLine(global::i.a("", 57802));
				streamWriter.WriteLine(global::i.a("", 59098));
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			MessageBox.Show(global::i.a("", 59419), global::i.a("", 57434), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00009F3C File Offset: 0x0000813C
		public static string RandomId(int length)
		{
			string text = global::i.a("", 63450);
			string text2 = "";
			Random random = new Random();
			for (int i = 0; i < length; i++)
			{
				text2 += text[random.Next(text.Length)].ToString();
			}
			return text2;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00009FB4 File Offset: 0x000081B4
		public static void Disk()
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey(global::i.a("", 61713)).GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey(global::i.a("", 60211) + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						global::i.a("", 60211),
						text,
						global::i.a("", 59929),
						text2,
						global::i.a("", 57635)
					}), true);
					bool flag = registryKey != null && registryKey.GetValue(global::i.a("", 62821)).ToString() == global::i.a("", 62120);
					if (flag)
					{
						string value = Main.RandomId(14);
						string value2 = Main.RandomId(14);
						registryKey.SetValue(global::i.a("", 60522), Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue(global::i.a("", 58812), value);
						registryKey.SetValue(global::i.a("", 61262), Encoding.UTF8.GetBytes(value));
						registryKey.SetValue(global::i.a("", 59631), value2);
					}
				}
			}
			foreach (string str in Registry.LocalMachine.OpenSubKey(global::i.a("", 59739)).GetSubKeyNames())
			{
				Registry.LocalMachine.OpenSubKey(global::i.a("", 61084) + str, true).SetValue(global::i.a("", 58812), Main.RandomId(8) + global::i.a("", 62539) + Main.RandomId(8) + global::i.a("", 58694));
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000A230 File Offset: 0x00008430
		private void ak(object a, EventArgs b)
		{
			Main.Disk();
			MessageBox.Show(global::i.a("", 63354), global::i.a("", 62760), MessageBoxButtons.OK);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000A264 File Offset: 0x00008464
		public static string GenerateString(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = global::i.a("", 59785)[Main.random.Next(global::i.a("", 59785).Length)];
			}
			return new string(array);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000A2D8 File Offset: 0x000084D8
		private void al(object a, EventArgs b)
		{
			Thread.Sleep(2500);
			MessageBox.Show(global::i.a("", 59275), global::i.a("", 62723), MessageBoxButtons.OK);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000A314 File Offset: 0x00008514
		public static void SpoofPCName()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 59518), true);
			registryKey.SetValue(global::i.a("", 59187), global::i.a("", 62606) + Main.GenerateString(6));
			registryKey.Close();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000A38C File Offset: 0x0000858C
		private void am(object a, EventArgs b)
		{
			Main.SpoofPCName();
			DialogResult dialogResult = MessageBox.Show(global::i.a("", 57536), global::i.a("", 59280), MessageBoxButtons.YesNo);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 61788), global::i.a("", 59062))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000A420 File Offset: 0x00008620
		private static void an()
		{
			try
			{
				Process process = new Process();
				process.StartInfo.Arguments = global::i.a("", 58742);
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.WaitForExit();
				MessageBox.Show(global::i.a("", 63719));
			}
			catch
			{
				MessageBox.Show(global::i.a("", 63314), global::i.a("", 57753), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000A4EC File Offset: 0x000086EC
		private void ao(object a, EventArgs b)
		{
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				global::i.a("", 60163),
				Main.GenerateString(5),
				global::i.a("", 60163),
				Main.GenerateString(5),
				global::i.a("", 60163),
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 62057), true);
			registryKey.SetValue(global::i.a("", 63506), value);
			registryKey.Close();
			MessageBox.Show(global::i.a("", 60284) + Main.CurrentProductID(), global::i.a("", 57350), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000A5E8 File Offset: 0x000087E8
		public static string CurrentProductID()
		{
			string text = global::i.a("", 58683);
			string text2 = global::i.a("", 58785);
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					bool flag = registryKey2 == null;
					if (flag)
					{
						throw new KeyNotFoundException(string.Format(global::i.a("", 62173), text));
					}
					object value = registryKey2.GetValue(text2);
					bool flag2 = value == null;
					if (flag2)
					{
						throw new IndexOutOfRangeException(string.Format(global::i.a("", 59591), text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000035B2 File Offset: 0x000017B2
		private void ap(object a, EventArgs b)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000035B2 File Offset: 0x000017B2
		private void aq(object a, PaintEventArgs b)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000A6D8 File Offset: 0x000088D8
		private void ar(object a, EventArgs b)
		{
			Process.Start(global::i.a("", 60820));
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000035B2 File Offset: 0x000017B2
		private void @as(object a, EventArgs b)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000A6F0 File Offset: 0x000088F0
		public static void InstallDate()
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 62572), true);
			registryKey.SetValue(global::i.a("", 63125), value);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000A747 File Offset: 0x00008947
		private void at(object a, EventArgs b)
		{
			Main.InstallDate();
			MessageBox.Show(global::i.a("", 62717), global::i.a("", 58232), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000A780 File Offset: 0x00008980
		private static void au()
		{
			Process[] processesByName = Process.GetProcessesByName(global::i.a("", 57743));
			bool flag = processesByName.Length == 0;
			if (!flag)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 58030), global::i.a("", 63443))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 58681), global::i.a("", 60210) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName2 = Process.GetProcessesByName(global::i.a("", 59410));
			bool flag2 = processesByName2.Length == 0;
			if (!flag2)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 58030), global::i.a("", 63443))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 58681), global::i.a("", 60210) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName3 = Process.GetProcessesByName(global::i.a("", 60590));
			bool flag3 = processesByName3.Length == 0;
			if (!flag3)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 58030), global::i.a("", 63443))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 58681), global::i.a("", 60210) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName4 = Process.GetProcessesByName(global::i.a("", 60214));
			bool flag4 = processesByName4.Length == 0;
			if (!flag4)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 58030), global::i.a("", 63443))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 58681), global::i.a("", 60210) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName5 = Process.GetProcessesByName(global::i.a("", 59719));
			bool flag5 = processesByName5.Length == 0;
			if (!flag5)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 58030), global::i.a("", 63443))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 58681), global::i.a("", 60210) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName6 = Process.GetProcessesByName(global::i.a("", 61030));
			bool flag6 = processesByName6.Length == 0;
			if (!flag6)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 58030), global::i.a("", 63443))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 58681), global::i.a("", 60210) + Application.ExecutablePath);
				Application.Exit();
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000AB60 File Offset: 0x00008D60
		private void av(object a, EventArgs b)
		{
			bool flag = File.Exists(global::i.a("", 59348));
			if (flag)
			{
				File.Delete(global::i.a("", 59348));
			}
			bool flag2 = File.Exists(global::i.a("", 58187));
			if (flag2)
			{
				File.Delete(global::i.a("", 58187));
			}
			string text = this.bh.Text;
			string path = global::i.a("", 61273);
			bool flag3 = !Directory.Exists(path);
			if (flag3)
			{
				Directory.CreateDirectory(path);
			}
			bool flag4 = File.Exists(global::i.a("", 59348));
			if (flag4)
			{
				string text2 = global::i.a("", 58187);
				using (StreamWriter streamWriter = File.CreateText(text2))
				{
					streamWriter.WriteLine(string.Concat(new string[]
					{
						global::i.a("", 61744),
						text,
						global::i.a("", 63042),
						Main.DiskGen(4),
						global::i.a("", 60998),
						Main.DiskGen(4),
						global::i.a("", 60212)
					}));
				}
				Process process = new Process();
				process.StartInfo.FileName = text2;
				this.d.Add(process);
				File.SetAttributes(global::i.a("", 58187), FileAttributes.Hidden);
				process.Start();
				MessageBox.Show(global::i.a("", 63583), global::i.a("", 63172), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete(global::i.a("", 59348));
				File.Delete(global::i.a("", 58187));
				Directory.Delete(path);
			}
			else
			{
				Thread.Sleep(500);
				string text3 = global::i.a("", 58187);
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						global::i.a("", 61744),
						text,
						global::i.a("", 63042),
						Main.DiskGen(4),
						global::i.a("", 60998),
						Main.DiskGen(4),
						global::i.a("", 60212)
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.d.Add(process2);
				File.SetAttributes(global::i.a("", 58187), FileAttributes.Hidden);
				process2.Start();
				MessageBox.Show(global::i.a("", 63583), global::i.a("", 63172), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete(global::i.a("", 59348));
				File.Delete(global::i.a("", 58187));
				Directory.Delete(path);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000035B2 File Offset: 0x000017B2
		private void aw(object a, PaintEventArgs b)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000AEE0 File Offset: 0x000090E0
		private void ax(object a, EventArgs b)
		{
			Thread.Sleep(2500);
			MessageBox.Show(global::i.a("", 59286), global::i.a("", 61662), MessageBoxButtons.OK);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000AF1C File Offset: 0x0000911C
		private void ay(object a, EventArgs b)
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey(global::i.a("", 58530)).GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey(global::i.a("", 61147) + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						global::i.a("", 61147),
						text,
						global::i.a("", 62087),
						text2,
						global::i.a("", 61554)
					}), true);
					bool flag = registryKey != null && registryKey.GetValue(global::i.a("", 59110)).ToString() == global::i.a("", 60858);
					if (flag)
					{
						string value = Main.RandomId(14);
						string value2 = Main.RandomId(14);
						registryKey.SetValue(global::i.a("", 59744), Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue(global::i.a("", 60283), value);
						registryKey.SetValue(global::i.a("", 59053), Encoding.UTF8.GetBytes(value));
						registryKey.SetValue(global::i.a("", 59648), value2);
					}
				}
			}
			foreach (string str in Registry.LocalMachine.OpenSubKey(global::i.a("", 61202)).GetSubKeyNames())
			{
				Registry.LocalMachine.OpenSubKey(global::i.a("", 60641) + str, true).SetValue(global::i.a("", 60283), Main.RandomId(8) + global::i.a("", 59944) + Main.RandomId(8) + global::i.a("", 62073));
			}
			MessageBox.Show(global::i.a("", 59635), global::i.a("", 57891), MessageBoxButtons.OK);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000B1BF File Offset: 0x000093BF
		private void az(object a, EventArgs b)
		{
			Main.NetWoof();
			Thread.Sleep(2500);
			MessageBox.Show(global::i.a("", 62652), global::i.a("", 62935), MessageBoxButtons.OK);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000B200 File Offset: 0x00009400
		private void ba(object a, EventArgs b)
		{
			Thread.Sleep(2500);
			Main.NetWoof();
			bool flag = File.Exists(global::i.a("", 62617));
			if (flag)
			{
				File.Delete(global::i.a("", 62617));
			}
			bool flag2 = File.Exists(global::i.a("", 58257));
			if (flag2)
			{
				File.Delete(global::i.a("", 58257));
			}
			string text = this.bh.Text;
			string path = global::i.a("", 60162);
			bool flag3 = !Directory.Exists(path);
			if (flag3)
			{
				Directory.CreateDirectory(path);
			}
			bool flag4 = File.Exists(global::i.a("", 62617));
			if (flag4)
			{
				string text2 = global::i.a("", 58257);
				using (StreamWriter streamWriter = File.CreateText(text2))
				{
					streamWriter.WriteLine(string.Concat(new string[]
					{
						global::i.a("", 61445),
						text,
						global::i.a("", 63377),
						Main.DiskGen(4),
						global::i.a("", 61577),
						Main.DiskGen(4),
						global::i.a("", 58837)
					}));
				}
				Process process = new Process();
				process.StartInfo.FileName = text2;
				this.d.Add(process);
				File.SetAttributes(global::i.a("", 58257), FileAttributes.Hidden);
				process.Start();
				MessageBox.Show(global::i.a("", 62614), global::i.a("", 58189), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete(global::i.a("", 62617));
				File.Delete(global::i.a("", 58257));
				Directory.Delete(path);
			}
			else
			{
				Thread.Sleep(500);
				string text3 = global::i.a("", 58257);
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						global::i.a("", 61445),
						text,
						global::i.a("", 63377),
						Main.DiskGen(4),
						global::i.a("", 61577),
						Main.DiskGen(4),
						global::i.a("", 58837)
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.d.Add(process2);
				File.SetAttributes(global::i.a("", 58257), FileAttributes.Hidden);
				process2.Start();
				File.Delete(global::i.a("", 62617));
				File.Delete(global::i.a("", 58257));
				Directory.Delete(path);
			}
			Main.HWIDclick();
			string path2 = global::i.a("", 63338);
			bool flag5 = !Directory.Exists(path2);
			if (flag5)
			{
				Directory.CreateDirectory(path2);
			}
			bool flag6 = File.Exists(global::i.a("", 58428));
			if (flag6)
			{
				Process.Start(global::i.a("", 58428));
			}
			else
			{
				string text4 = global::i.a("", 58428);
				using (StreamWriter streamWriter3 = File.CreateText(text4))
				{
					streamWriter3.WriteLine(global::i.a("", 57706));
				}
				Process process3 = new Process();
				process3.StartInfo.FileName = text4;
				this.d.Add(process3);
				File.SetAttributes(global::i.a("", 58428), FileAttributes.Hidden);
				process3.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.bi();
			Thread.Sleep(2000);
			MessageBox.Show(global::i.a("", 61204), global::i.a("", 58189), MessageBoxButtons.OK);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000B6B4 File Offset: 0x000098B4
		private void bb(object a, EventArgs b)
		{
			this.ay.BringToFront();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000B6C4 File Offset: 0x000098C4
		private void bc(object a, EventArgs b)
		{
			bool flag = File.Exists(global::i.a("", 60581));
			if (flag)
			{
				File.Delete(global::i.a("", 60581));
			}
			bool flag2 = File.Exists(global::i.a("", 58638));
			if (flag2)
			{
				File.Delete(global::i.a("", 58638));
			}
			MessageBox.Show(global::i.a("", 58947), global::i.a("", 61323), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000B6B4 File Offset: 0x000098B4
		private void bd(object a, EventArgs b)
		{
			this.ay.BringToFront();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000035B2 File Offset: 0x000017B2
		private void be(object a, EventArgs b)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000B769 File Offset: 0x00009969
		private void bf(object a, EventArgs b)
		{
			Thread.Sleep(2500);
			MessageBox.Show(global::i.a("", 59597), global::i.a("", 63069), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000035B2 File Offset: 0x000017B2
		private void bg(object a, EventArgs b)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000035B2 File Offset: 0x000017B2
		private void bh(object a, EventArgs b)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000B7A4 File Offset: 0x000099A4
		public static void NetWoof()
		{
			List<Process> list = new List<Process>();
			string path = global::i.a("", 62619);
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				Directory.CreateDirectory(path);
			}
			bool flag2 = File.Exists(global::i.a("", 62310));
			if (flag2)
			{
				Process.Start(global::i.a("", 62310));
				File.Delete(global::i.a("", 62310));
			}
			else
			{
				string text = global::i.a("", 62310);
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine(global::i.a("", 61341));
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				list.Add(process);
				File.SetAttributes(global::i.a("", 62310), FileAttributes.Hidden);
				process.Start();
				Thread.Sleep(500);
				File.Delete(global::i.a("", 62310));
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000B900 File Offset: 0x00009B00
		public static void HWIDclick()
		{
			string keyName = global::i.a("", 63130);
			string text = (string)Registry.GetValue(keyName, global::i.a("", 61589), global::i.a("", 62645));
			string value = string.Concat(new string[]
			{
				global::i.a("", 61356),
				Main.GenID(5),
				global::i.a("", 62224),
				Main.GenID(5),
				global::i.a("", 62224),
				Main.GenID(4),
				global::i.a("", 62224),
				Main.GenID(9),
				global::i.a("", 60745)
			});
			Registry.SetValue(keyName, global::i.a("", 61984), value);
			Registry.SetValue(keyName, global::i.a("", 61589), value);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000BA20 File Offset: 0x00009C20
		public static void XBOXclick()
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 62162), true);
			registryKey.SetValue(global::i.a("", 59171), value);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000BA78 File Offset: 0x00009C78
		public static void IDclick()
		{
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				global::i.a("", 60817),
				Main.GenerateString(5),
				global::i.a("", 60817),
				Main.GenerateString(5),
				global::i.a("", 60817),
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 62320), true);
			registryKey.SetValue(global::i.a("", 61288), value);
			registryKey.Close();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000BB3C File Offset: 0x00009D3C
		public static void PCclick()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 58679), true);
			registryKey.SetValue(global::i.a("", 60741), global::i.a("", 58750) + Main.GenerateString(6));
			registryKey.Close();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000BBB4 File Offset: 0x00009DB4
		public static void Diskclick()
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey(global::i.a("", 59522)).GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey(global::i.a("", 58759) + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						global::i.a("", 58759),
						text,
						global::i.a("", 59257),
						text2,
						global::i.a("", 61204)
					}), true);
					bool flag = registryKey != null && registryKey.GetValue(global::i.a("", 57925)).ToString() == global::i.a("", 58891);
					if (flag)
					{
						string value = Main.RandomId(14);
						string value2 = Main.RandomId(14);
						registryKey.SetValue(global::i.a("", 59813), Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue(global::i.a("", 62053), value);
						registryKey.SetValue(global::i.a("", 61942), Encoding.UTF8.GetBytes(value));
						registryKey.SetValue(global::i.a("", 62560), value2);
					}
				}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000BD8C File Offset: 0x00009F8C
		public static void FiveM()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			bool flag = Directory.Exists(folderPath + global::i.a("", 62058));
			if (flag)
			{
				Directory.Delete(folderPath + global::i.a("", 62058), true);
			}
			bool flag2 = Directory.Exists(folderPath + global::i.a("", 62033));
			if (flag2)
			{
				Directory.Delete(folderPath + global::i.a("", 62033), true);
			}
			bool flag3 = Directory.Exists(folderPath + global::i.a("", 63117));
			if (flag3)
			{
				Directory.Delete(folderPath + global::i.a("", 63117), true);
			}
			bool flag4 = Directory.Exists(folderPath + global::i.a("", 61570));
			if (flag4)
			{
				Directory.Delete(folderPath + global::i.a("", 61570), true);
			}
			Directory.Exists(folderPath + global::i.a("", 59202));
			bool flag5 = Directory.Exists(folderPath2 + global::i.a("", 60579));
			if (flag5)
			{
				Directory.Delete(folderPath2 + global::i.a("", 60579), true);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000BF1C File Offset: 0x0000A11C
		private static void bi()
		{
			Main.bj(global::i.a("", 62964));
			Thread.Sleep(600);
			Main.bj(global::i.a("", 62824));
			Main.bj(global::i.a("", 62793));
			Main.bj(global::i.a("", 63163));
			File.Delete(global::i.a("", 59116));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		private static void bj(string a)
		{
			Process process = Process.Start(new ProcessStartInfo(global::i.a("", 59978), global::i.a("", 61135) + a)
			{
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardError = true,
				RedirectStandardOutput = true
			});
			process.WaitForExit();
			process.StandardOutput.ReadToEnd();
			process.StandardError.ReadToEnd();
			int exitCode = process.ExitCode;
			process.Close();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000C050 File Offset: 0x0000A250
		private void bk(object a, EventArgs b)
		{
			try
			{
				bool flag = File.Exists(global::i.a("", 63503));
				if (flag)
				{
					File.Move(global::i.a("", 58012), global::i.a("", 63005));
					File.Move(global::i.a("", 61563), global::i.a("", 62023));
				}
				bool flag2 = Directory.Exists(global::i.a("", 62474));
				if (flag2)
				{
					Directory.Delete(global::i.a("", 62474));
					Directory.CreateDirectory(global::i.a("", 62474));
				}
				d d = new d();
				d.b();
			}
			catch
			{
			}
			string text = Path.ChangeExtension(Path.GetTempFileName(), global::i.a("", 59378));
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine(global::i.a("", 59280));
				streamWriter.WriteLine(global::i.a("", 63727));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 63550));
				streamWriter.WriteLine(global::i.a("", 63727));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 60184));
				streamWriter.WriteLine(global::i.a("", 63727));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 58410));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 61124));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 57537));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 63089));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 58432));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 57712));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 59443));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 61200));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 58967));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 60589));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 62589));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 59153));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 59603));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 59835));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 63520));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 59603));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 59657));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 59270));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 59153));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 60560));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 59153));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 57693));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 60350));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 62084));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 58237));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 58696));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 60181));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 58729));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 58363));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 58346));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 59729));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 62863));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 61815));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 61242));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 63375));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 57860));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 60796));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 63304));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 63727));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 57533));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 61443));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 58143));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 60125));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 59447));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 60446));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 62094));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 62611));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 61670));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 60659));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 63302));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 60957));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 57763));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 59994));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 60574));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 63166));
				streamWriter.WriteLine(global::i.a("", 62801));
				streamWriter.WriteLine(global::i.a("", 58892));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 60999));
				streamWriter.WriteLine(global::i.a("", 58245));
				streamWriter.WriteLine(global::i.a("", 62973));
				streamWriter.WriteLine(global::i.a("", 62547));
				streamWriter.WriteLine(global::i.a("", 58722));
				streamWriter.WriteLine(global::i.a("", 59333));
				streamWriter.WriteLine(global::i.a("", 62728));
				streamWriter.WriteLine(global::i.a("", 60985));
				streamWriter.WriteLine(global::i.a("", 60640));
				streamWriter.WriteLine(global::i.a("", 59333));
				streamWriter.WriteLine(global::i.a("", 57347));
				streamWriter.WriteLine(global::i.a("", 58453));
				streamWriter.WriteLine(global::i.a("", 60963));
				streamWriter.WriteLine(global::i.a("", 61817));
				streamWriter.WriteLine(global::i.a("", 58716));
				streamWriter.WriteLine(global::i.a("", 58564));
				streamWriter.WriteLine(global::i.a("", 59013));
				streamWriter.WriteLine(global::i.a("", 60620));
				streamWriter.WriteLine(global::i.a("", 61166));
				streamWriter.WriteLine(global::i.a("", 60827));
				streamWriter.WriteLine(global::i.a("", 57957));
				streamWriter.WriteLine(global::i.a("", 58212));
				streamWriter.WriteLine(global::i.a("", 58636));
				streamWriter.WriteLine(global::i.a("", 60348));
				streamWriter.WriteLine(global::i.a("", 60182));
				streamWriter.WriteLine(global::i.a("", 61075));
				streamWriter.WriteLine(global::i.a("", 62486));
				streamWriter.WriteLine(global::i.a("", 58410));
				streamWriter.WriteLine(global::i.a("", 60585));
				streamWriter.WriteLine(global::i.a("", 62075));
				streamWriter.WriteLine(global::i.a("", 57846));
				streamWriter.WriteLine(global::i.a("", 62123));
				streamWriter.WriteLine(global::i.a("", 61202));
				streamWriter.WriteLine(global::i.a("", 62178));
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			Registry.SetValue(global::i.a("", 63573), global::i.a("", 62311), global::i.a("", 62771), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 63573), global::i.a("", 63163), global::i.a("", 62771), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 59340), global::i.a("", 59096), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59277), global::i.a("", 63050), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62201), global::i.a("", 61418), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59186), "", global::i.a("", 57393));
			Registry.SetValue(global::i.a("", 58603), "", global::i.a("", 62434));
			Registry.SetValue(global::i.a("", 62512), global::i.a("", 62035), global::i.a("", 62757));
			Registry.SetValue(global::i.a("", 62512), global::i.a("", 58201), global::i.a("", 61185));
			Registry.SetValue(global::i.a("", 62512), global::i.a("", 57722), global::i.a("", 62924));
			Registry.SetValue(global::i.a("", 62512), global::i.a("", 61165), global::i.a("", 59988));
			Registry.SetValue(global::i.a("", 62512), global::i.a("", 58825), global::i.a("", 61185));
			Registry.SetValue(global::i.a("", 58481), global::i.a("", 59866), global::i.a("", 62924));
			Registry.SetValue(global::i.a("", 58008), global::i.a("", 63102), global::i.a("", 57604), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58008), global::i.a("", 62507), global::i.a("", 57604), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58008), global::i.a("", 58736), global::i.a("", 57604), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58008), global::i.a("", 62225), global::i.a("", 57604), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58008), global::i.a("", 62131), global::i.a("", 57604), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62644), global::i.a("", 61225), global::i.a("", 59988));
			Registry.SetValue(global::i.a("", 61311), global::i.a("", 59370), global::i.a("", 60881), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61849), global::i.a("", 59370), global::i.a("", 60881), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61789), global::i.a("", 59370), global::i.a("", 60881), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62761), global::i.a("", 59370), global::i.a("", 60881), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61711), global::i.a("", 59643), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61711), global::i.a("", 60562), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63137), global::i.a("", 59688), 1, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58608), global::i.a("", 62583), 8, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58608), global::i.a("", 58751), 6, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58608), global::i.a("", 58462), global::i.a("", 61072), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 58608), global::i.a("", 63075), global::i.a("", 61072), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 61441), global::i.a("", 62583), 0, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61441), global::i.a("", 58751), 8, RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61441), global::i.a("", 58462), global::i.a("", 58743), RegistryValueKind.String);
			Registry.SetValue(global::i.a("", 61441), global::i.a("", 63075), global::i.a("", 61072), RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61857), true).DeleteValue(global::i.a("", 62311), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 61857), true).DeleteValue(global::i.a("", 63163), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 62599), true).DeleteValue(global::i.a("", 59096), false);
			Registry.SetValue(global::i.a("", 59277), global::i.a("", 63050), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62201), global::i.a("", 61418), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 62501), false);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 62082), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57417), true).DeleteValue(global::i.a("", 62035), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57417), true).DeleteValue(global::i.a("", 58201), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57417), true).DeleteValue(global::i.a("", 61165), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 57417), true).DeleteValue(global::i.a("", 58825), false);
			Registry.SetValue(global::i.a("", 62512), global::i.a("", 57722), global::i.a("", 59824));
			Registry.SetValue(global::i.a("", 58481), global::i.a("", 59866), global::i.a("", 59824));
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59938), true).DeleteValue(global::i.a("", 63102), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59938), true).DeleteValue(global::i.a("", 62507), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59938), true).DeleteValue(global::i.a("", 58736), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59938), true).DeleteValue(global::i.a("", 62225), false);
			Registry.CurrentUser.OpenSubKey(global::i.a("", 59938), true).DeleteValue(global::i.a("", 62131), false);
			Registry.SetValue(global::i.a("", 62644), global::i.a("", 61225), global::i.a("", 59558));
			Registry.SetValue(global::i.a("", 61311), global::i.a("", 59370), global::i.a("", 59713), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61789), global::i.a("", 59370), global::i.a("", 59713), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 62761), global::i.a("", 59370), global::i.a("", 59713), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61711), global::i.a("", 59643), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61711), global::i.a("", 60562), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63137), global::i.a("", 59688), 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 61660), true).DeleteValue(global::i.a("", 62583), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 61660), true).DeleteValue(global::i.a("", 58751), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 61660), true).DeleteValue(global::i.a("", 58462), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 61660), true).DeleteValue(global::i.a("", 63075), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 62485), true).DeleteValue(global::i.a("", 62583), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 62485), true).DeleteValue(global::i.a("", 58751), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 62485), true).DeleteValue(global::i.a("", 58462), false);
			Registry.LocalMachine.OpenSubKey(global::i.a("", 62485), true).DeleteValue(global::i.a("", 63075), false);
			Registry.SetValue(global::i.a("", 58161), global::i.a("", 57912), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58536), global::i.a("", 62548), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61735), global::i.a("", 61583), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61735), global::i.a("", 58574), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61735), global::i.a("", 59725), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61735), global::i.a("", 60885), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60539), global::i.a("", 60323), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63719), global::i.a("", 60939), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61032), global::i.a("", 59370), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 63550), global::i.a("", 62259), 0);
			Registry.SetValue(global::i.a("", 59403), global::i.a("", 61319), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59403), global::i.a("", 59641), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59403), global::i.a("", 61715), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59403), global::i.a("", 58154), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60413), global::i.a("", 59956), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 58284), global::i.a("", 62906), 0);
			Registry.SetValue(global::i.a("", 61568), global::i.a("", 61775), 1);
			Registry.SetValue(global::i.a("", 61775), global::i.a("", 61045), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59403), global::i.a("", 62533), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59712), global::i.a("", 59039), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59403), global::i.a("", 59668), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 59403), global::i.a("", 59956), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60796), global::i.a("", 62225), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60796), global::i.a("", 63074), global::i.a("", 62924), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61240), global::i.a("", 61129), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 61240), global::i.a("", 60939), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree(global::i.a("", 59406), false);
			Registry.SetValue(global::i.a("", 60413), global::i.a("", 58873), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60413), global::i.a("", 61805), global::i.a("", 62757), RegistryValueKind.DWord);
			Registry.SetValue(global::i.a("", 60413), global::i.a("", 61994), global::i.a("", 62757), RegistryValueKind.DWord);
			string path = global::i.a("", 63087);
			bool flag3 = !Directory.Exists(path);
			if (flag3)
			{
				Directory.CreateDirectory(path);
			}
			bool flag4 = File.Exists(global::i.a("", 63503));
			if (flag4)
			{
				Process.Start(global::i.a("", 63503));
			}
			else
			{
				string text2 = global::i.a("", 63503);
				using (StreamWriter streamWriter2 = File.CreateText(text2))
				{
					streamWriter2.WriteLine(global::i.a("", 58742));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text2;
				this.d.Add(process2);
				File.SetAttributes(global::i.a("", 63503), FileAttributes.Hidden);
				process2.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.bi();
			Thread.Sleep(2000);
			string path2 = global::i.a("", 62654);
			bool flag5 = !Directory.Exists(path2);
			if (flag5)
			{
				Directory.CreateDirectory(path2);
			}
			bool flag6 = File.Exists(global::i.a("", 58290));
			if (flag6)
			{
				new SoundPlayer(global::i.a("", 58290)).Play();
			}
			else
			{
				string address = global::i.a("", 62387);
				string fileName = global::i.a("", 58290);
				WebClient webClient = new WebClient();
				webClient.DownloadFile(address, fileName);
				File.SetAttributes(global::i.a("", 58290), FileAttributes.Hidden);
				new SoundPlayer(global::i.a("", 58290)).Play();
			}
			MessageBox.Show(global::i.a("", 62684), global::i.a("", 58085), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			File.Delete(global::i.a("", 58290));
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000E460 File Offset: 0x0000C660
		public static void ClickUnban()
		{
			List<Process> list = new List<Process>();
			d d = new d();
			d.b();
			string path = global::i.a("", 59126);
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				Directory.CreateDirectory(path);
			}
			bool flag2 = File.Exists(global::i.a("", 61955));
			if (flag2)
			{
				Process.Start(global::i.a("", 61955));
			}
			else
			{
				string text = global::i.a("", 61955);
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine(global::i.a("", 62977));
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				list.Add(process);
				File.SetAttributes(global::i.a("", 61955), FileAttributes.Hidden);
				process.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.bi();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000E5B8 File Offset: 0x0000C7B8
		public static string GenID(int length)
		{
			string element = global::i.a("", 62864);
			return new string(Enumerable.Repeat<string>(element, length).Select(new Func<string, char>(Main.<>c.<>9.b)).ToArray<char>());
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000E610 File Offset: 0x0000C810
		public static string DiskGen(int length)
		{
			string element = global::i.a("", 63065);
			return new string(Enumerable.Repeat<string>(element, length).Select(new Func<string, char>(Main.<>c.<>9.c)).ToArray<char>());
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000B6B4 File Offset: 0x000098B4
		private void bl(object a, EventArgs b)
		{
			this.ay.BringToFront();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000035B2 File Offset: 0x000017B2
		private void bm(object a, EventArgs b)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000E668 File Offset: 0x0000C868
		private void bn(object a, EventArgs b)
		{
			d d = new d();
			d.b();
			Main.HWIDclick();
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				global::i.a("", 61815),
				Main.GenerateString(5),
				global::i.a("", 61815),
				Main.GenerateString(5),
				global::i.a("", 61815),
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(global::i.a("", 62868), true);
			registryKey.SetValue(global::i.a("", 61188), value);
			registryKey.Close();
			Main.InstallDate();
			Main.Disk();
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.bi();
			Main.SpoofPCName();
			string path = global::i.a("", 60702);
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				Directory.CreateDirectory(path);
			}
			bool flag2 = File.Exists(global::i.a("", 63730));
			if (flag2)
			{
				Process.Start(global::i.a("", 63730));
			}
			else
			{
				string text = global::i.a("", 63730);
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine(global::i.a("", 57418));
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				this.d.Add(process);
				File.SetAttributes(global::i.a("", 63730), FileAttributes.Hidden);
				process.Start();
			}
			bool flag3 = File.Exists(global::i.a("", 60171));
			if (flag3)
			{
				File.Delete(global::i.a("", 60171));
			}
			bool flag4 = File.Exists(global::i.a("", 60296));
			if (flag4)
			{
				File.Delete(global::i.a("", 60296));
			}
			string text2 = this.bh.Text;
			string path2 = global::i.a("", 62322);
			bool flag5 = !Directory.Exists(path2);
			if (flag5)
			{
				Directory.CreateDirectory(path2);
			}
			bool flag6 = File.Exists(global::i.a("", 60171));
			if (flag6)
			{
				string text3 = global::i.a("", 60296);
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						global::i.a("", 57540),
						text2,
						global::i.a("", 61344),
						Main.DiskGen(4),
						global::i.a("", 61815),
						Main.DiskGen(4),
						global::i.a("", 60180)
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.d.Add(process2);
				File.SetAttributes(global::i.a("", 60296), FileAttributes.Hidden);
				process2.Start();
				File.Delete(global::i.a("", 60171));
				File.Delete(global::i.a("", 60296));
				Directory.Delete(path2);
			}
			else
			{
				string text4 = global::i.a("", 60296);
				using (StreamWriter streamWriter3 = File.CreateText(text4))
				{
					streamWriter3.WriteLine(string.Concat(new string[]
					{
						global::i.a("", 57540),
						text2,
						global::i.a("", 61344),
						Main.DiskGen(4),
						global::i.a("", 61815),
						Main.DiskGen(4),
						global::i.a("", 60180)
					}));
				}
				Process process3 = new Process();
				process3.StartInfo.FileName = text4;
				this.d.Add(process3);
				File.SetAttributes(global::i.a("", 60296), FileAttributes.Hidden);
				process3.Start();
				File.Delete(global::i.a("", 60171));
				File.Delete(global::i.a("", 60296));
				Directory.Delete(path2);
			}
			MessageBox.Show(global::i.a("", 62431), global::i.a("", 57977), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000EB9C File Offset: 0x0000CD9C
		private void bo(object a, EventArgs b)
		{
			d d = new d();
			d.b();
			bool flag = File.Exists(global::i.a("", 58467));
			if (flag)
			{
				try
				{
					File.Move(global::i.a("", 58467), global::i.a("", 61541));
					File.Move(global::i.a("", 61187), global::i.a("", 58244));
				}
				catch
				{
				}
			}
			MessageBox.Show(global::i.a("", 60933), global::i.a("", 61207), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000EC70 File Offset: 0x0000CE70
		private void bp(object a, EventArgs b)
		{
			Main.FiveM();
			Main.ClickUnban();
			MessageBox.Show(global::i.a("", 62679), global::i.a("", 61187), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000035B2 File Offset: 0x000017B2
		private void bq(object a, EventArgs b)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000ECAC File Offset: 0x0000CEAC
		private void br(object a, EventArgs b)
		{
			string path = global::i.a("", 57374);
			try
			{
				string text = global::i.a("", 60051);
				string text2 = global::i.a("", 62843);
				bool flag = !Directory.Exists(path);
				if (flag)
				{
					Directory.CreateDirectory(path);
				}
				bool flag2 = File.Exists(text2);
				if (flag2)
				{
					this.s.Image = new Bitmap(text2);
				}
				else
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFile(text, text2);
					this.s.Image = new Bitmap(text);
				}
				string path2 = global::i.a("", 58838);
				File.Delete(path2);
				Thread.Sleep(50);
				this.s.Image = new Bitmap(text2);
				Thread.Sleep(2000);
				DirectoryInfo directoryInfo = new DirectoryInfo(global::i.a("", 60606));
				foreach (FileInfo fileInfo in directoryInfo.GetFiles())
				{
					fileInfo.Delete();
				}
				foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
				{
					directoryInfo2.Delete(true);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000035B2 File Offset: 0x000017B2
		private void bs(object a, EventArgs b)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000035B2 File Offset: 0x000017B2
		private void bt(object a, EventArgs b)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000035B2 File Offset: 0x000017B2
		private void bu(object a, EventArgs b)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000EE20 File Offset: 0x0000D020
		private void bv(object a, EventArgs b)
		{
			bool flag = File.Exists(global::i.a("", 59778));
			if (flag)
			{
				File.Move(global::i.a("", 60685), global::i.a("", 60452));
				File.Move(global::i.a("", 61348), global::i.a("", 62390));
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000EEA4 File Offset: 0x0000D0A4
		private void bw(object a, EventArgs b)
		{
			new Process
			{
				StartInfo = 
				{
					FileName = global::i.a("", 57453),
					CreateNoWindow = true,
					RedirectStandardInput = true,
					RedirectStandardOutput = true,
					UseShellExecute = false,
					Verb = global::i.a("", 63722),
					Arguments = global::i.a("", 61745)
				}
			}.Start();
			MessageBox.Show(global::i.a("", 62800), global::i.a("", 58994), MessageBoxButtons.OK);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000EF67 File Offset: 0x0000D167
		private void bx(object a, EventArgs b)
		{
			Process.Start(global::i.a("", 58379));
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000EFCC File Offset: 0x0000D1CC
		private void by()
		{
			this.e = new Container();
			Animation animation = new Animation();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
			this.f = new SiticoneDragControl(this.e);
			this.g = new SiticoneControlBox();
			this.h = new SiticoneControlBox();
			this.i = new SiticoneTransition();
			this.j = new Label();
			this.k = new Label();
			this.n = new SiticoneLabel();
			this.m = new SiticoneLabel();
			this.p = new SiticoneLabel();
			this.r = new Panel();
			this.s = new PictureBox();
			this.u = new SiticoneShadowPanel();
			this.bk = new SiticoneRoundedButton();
			this.bf = new SiticoneRoundedButton();
			this.ab = new SiticoneRoundedButton();
			this.ac = new SiticoneRoundedButton();
			this.ad = new SiticoneRoundedButton();
			this.ae = new SiticoneRoundedButton();
			this.af = new SiticoneRoundedButton();
			this.ag = new SiticoneRoundedButton();
			this.ah = new SiticoneRoundedButton();
			this.v = new SiticoneLabel();
			this.w = new PictureBox();
			this.x = new Label();
			this.t = new SiticoneLabel();
			this.ai = new SiticoneShadowPanel();
			this.bq = new SiticoneLabel();
			this.br = new SiticoneTextBox();
			this.an = new SiticoneLabel();
			this.am = new SiticoneRoundedButton();
			this.aj = new SiticoneLabel();
			this.ak = new PictureBox();
			this.al = new Label();
			this.ao = new SiticoneComboBox();
			this.ap = new SiticoneShadowPanel();
			this.bo = new SiticoneLabel();
			this.bn = new SiticoneLabel();
			this.bg = new SiticoneLabel();
			this.bh = new SiticoneTextBox();
			this.bd = new SiticoneButton();
			this.aq = new SiticoneLabel();
			this.ar = new PictureBox();
			this.@as = new Label();
			this.at = new Label();
			this.aw = new Label();
			this.ax = new SiticoneLabel();
			this.ay = new SiticoneShadowPanel();
			this.bm = new SiticoneRoundedButton();
			this.bl = new SiticoneRoundedButton();
			this.bj = new SiticoneLabel();
			this.be = new SiticoneRoundedButton();
			this.bv = new SiticoneRoundedButton();
			this.bc = new SiticoneRoundedButton();
			this.az = new SiticoneLabel();
			this.ba = new PictureBox();
			this.bb = new Label();
			this.bp = new SiticoneLabel();
			this.bi = new SiticoneGradientButton();
			this.y = new SiticoneGradientButton();
			this.z = new SiticoneGradientButton();
			this.aa = new SiticoneGradientButton();
			this.bu = new SiticoneLabel();
			this.l = new SiticoneShadowForm(this.e);
			this.o = new System.Windows.Forms.Timer(this.e);
			this.au = new PageSetupDialog();
			this.av = new System.Windows.Forms.Timer(this.e);
			this.bs = new System.Windows.Forms.Timer(this.e);
			this.q = new BindingSource(this.e);
			this.r.SuspendLayout();
			((ISupportInitialize)this.s).BeginInit();
			this.u.SuspendLayout();
			((ISupportInitialize)this.w).BeginInit();
			this.ai.SuspendLayout();
			((ISupportInitialize)this.ak).BeginInit();
			this.ap.SuspendLayout();
			((ISupportInitialize)this.ar).BeginInit();
			this.ay.SuspendLayout();
			((ISupportInitialize)this.ba).BeginInit();
			((ISupportInitialize)this.q).BeginInit();
			base.SuspendLayout();
			this.f.TargetControl = this;
			this.g.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.g.BorderRadius = 10;
			this.i.SetDecoration(this.g, 0);
			this.g.FillColor = Color.Black;
			this.g.HoveredState.FillColor = Color.FromArgb(232, 17, 35);
			this.g.HoveredState.IconColor = Color.White;
			this.g.HoveredState.Parent = this.g;
			this.g.IconColor = Color.White;
			this.g.Location = new Point(613, 4);
			this.g.Name = global::i.a("", 58823);
			this.g.ShadowDecoration.Parent = this.g;
			this.g.Size = new Size(45, 29);
			this.g.TabIndex = 1;
			this.g.Click += this.a;
			this.h.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.h.BorderRadius = 10;
			this.h.ControlBoxType = 0;
			this.i.SetDecoration(this.h, 0);
			this.h.FillColor = Color.Black;
			this.h.HoveredState.Parent = this.h;
			this.h.IconColor = Color.White;
			this.h.Location = new Point(568, 4);
			this.h.Name = global::i.a("", 58421);
			this.h.ShadowDecoration.Parent = this.h;
			this.h.Size = new Size(45, 29);
			this.h.TabIndex = 2;
			this.i.AnimationType = 1;
			this.i.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (PointF)componentResourceManager.GetObject(global::i.a("", 59852));
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (PointF)componentResourceManager.GetObject(global::i.a("", 59058));
			animation.MosaicShift = (PointF)componentResourceManager.GetObject(global::i.a("", 62445));
			animation.MosaicSize = 0;
			animation.Padding = new Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (PointF)componentResourceManager.GetObject(global::i.a("", 62686));
			animation.SlideCoeff = (PointF)componentResourceManager.GetObject(global::i.a("", 57631));
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.i.DefaultAnimation = animation;
			this.j.AutoSize = true;
			this.i.SetDecoration(this.j, 0);
			this.j.Font = new Font(global::i.a("", 58902), 10f);
			this.j.ForeColor = Color.White;
			this.j.Location = new Point(-1, 136);
			this.j.Name = global::i.a("", 57843);
			this.j.Size = new Size(0, 19);
			this.j.TabIndex = 22;
			this.k.AutoSize = true;
			this.i.SetDecoration(this.k, 0);
			this.k.Font = new Font(global::i.a("", 57501), 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.k.ForeColor = Color.White;
			this.k.Location = new Point(14, 7);
			this.k.Margin = new Padding(2, 0, 2, 0);
			this.k.Name = global::i.a("", 62354);
			this.k.Size = new Size(101, 19);
			this.k.TabIndex = 27;
			this.k.Text = global::i.a("", 61234);
			this.n.BackColor = Color.Transparent;
			this.i.SetDecoration(this.n, 0);
			this.n.Font = new Font(global::i.a("", 62698), 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.n.ForeColor = Color.White;
			this.n.Location = new Point(51, 5);
			this.n.Margin = new Padding(2);
			this.n.Name = global::i.a("", 60513);
			this.n.Size = new Size(115, 23);
			this.n.TabIndex = 37;
			this.n.Text = global::i.a("", 60513);
			this.n.Click += this.e;
			this.m.BackColor = Color.Transparent;
			this.i.SetDecoration(this.m, 0);
			this.m.Font = new Font(global::i.a("", 62698), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m.ForeColor = Color.Red;
			this.m.Location = new Point(51, 30);
			this.m.Margin = new Padding(2);
			this.m.Name = global::i.a("", 60413);
			this.m.Size = new Size(95, 15);
			this.m.TabIndex = 39;
			this.m.Text = global::i.a("", 59281);
			this.m.Click += this.h;
			this.p.BackColor = Color.Transparent;
			this.i.SetDecoration(this.p, 0);
			this.p.Font = new Font(global::i.a("", 62698), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p.ForeColor = Color.White;
			this.p.Location = new Point(159, 295);
			this.p.Margin = new Padding(2);
			this.p.Name = global::i.a("", 58865);
			this.p.Size = new Size(63, 15);
			this.p.TabIndex = 51;
			this.p.Text = global::i.a("", 62243);
			this.p.Click += this.u;
			this.r.BackColor = Color.Black;
			this.r.Controls.Add(this.m);
			this.r.Controls.Add(this.n);
			this.r.Controls.Add(this.s);
			this.i.SetDecoration(this.r, 0);
			this.r.Location = new Point(11, 34);
			this.r.Name = global::i.a("", 60732);
			this.r.Size = new Size(175, 53);
			this.r.TabIndex = 59;
			this.r.Paint += this.t;
			this.i.SetDecoration(this.s, 0);
			this.s.Image = Resources.images_1;
			this.s.Location = new Point(3, 3);
			this.s.Name = global::i.a("", 59535);
			this.s.Size = new Size(43, 45);
			this.s.SizeMode = PictureBoxSizeMode.Zoom;
			this.s.TabIndex = 10;
			this.s.TabStop = false;
			this.s.Click += this.bq;
			this.u.BackColor = Color.Transparent;
			this.u.Controls.Add(this.bk);
			this.u.Controls.Add(this.bf);
			this.u.Controls.Add(this.ab);
			this.u.Controls.Add(this.ac);
			this.u.Controls.Add(this.ad);
			this.u.Controls.Add(this.ae);
			this.u.Controls.Add(this.af);
			this.u.Controls.Add(this.ag);
			this.u.Controls.Add(this.ah);
			this.u.Controls.Add(this.v);
			this.u.Controls.Add(this.w);
			this.u.Controls.Add(this.x);
			this.i.SetDecoration(this.u, 0);
			this.u.FillColor = Color.Black;
			this.u.Location = new Point(195, 34);
			this.u.Name = global::i.a("", 63680);
			this.u.ShadowColor = Color.Black;
			this.u.Size = new Size(455, 311);
			this.u.TabIndex = 66;
			this.u.Paint += this.r;
			this.bk.BorderColor = Color.DarkRed;
			this.bk.BorderThickness = 1;
			this.bk.CheckedState.Parent = this.bk;
			this.bk.CustomImages.Parent = this.bk;
			this.i.SetDecoration(this.bk, 0);
			this.bk.FillColor = Color.Black;
			this.bk.Font = new Font(global::i.a("", 62698), 9f);
			this.bk.ForeColor = Color.Red;
			this.bk.HoveredState.Parent = this.bk;
			this.bk.Location = new Point(54, 260);
			this.bk.Name = global::i.a("", 58055);
			this.bk.ShadowDecoration.Parent = this.bk;
			this.bk.Size = new Size(346, 29);
			this.bk.TabIndex = 72;
			this.bk.Text = global::i.a("", 61292);
			this.bk.Click += this.bn;
			this.bf.BorderColor = Color.DarkRed;
			this.bf.BorderThickness = 1;
			this.bf.CheckedState.Parent = this.bf;
			this.bf.CustomImages.Parent = this.bf;
			this.i.SetDecoration(this.bf, 0);
			this.bf.FillColor = Color.Black;
			this.bf.Font = new Font(global::i.a("", 62698), 9f);
			this.bf.ForeColor = Color.Red;
			this.bf.HoveredState.Parent = this.bf;
			this.bf.Location = new Point(277, 210);
			this.bf.Name = global::i.a("", 63335);
			this.bf.ShadowDecoration.Parent = this.bf;
			this.bf.Size = new Size(123, 29);
			this.bf.TabIndex = 71;
			this.bf.Text = global::i.a("", 59061);
			this.bf.Click += this.at;
			this.ab.BorderColor = Color.DarkRed;
			this.ab.BorderThickness = 1;
			this.ab.CheckedState.Parent = this.ab;
			this.ab.CustomImages.Parent = this.ab;
			this.i.SetDecoration(this.ab, 0);
			this.ab.FillColor = Color.Black;
			this.ab.Font = new Font(global::i.a("", 62698), 9f);
			this.ab.ForeColor = Color.Red;
			this.ab.HoveredState.Parent = this.ab;
			this.ab.Location = new Point(54, 124);
			this.ab.Name = global::i.a("", 59039);
			this.ab.ShadowDecoration.Parent = this.ab;
			this.ab.Size = new Size(123, 29);
			this.ab.TabIndex = 70;
			this.ab.Text = global::i.a("", 62440);
			this.ab.Click += this.al;
			this.ac.BorderColor = Color.DarkRed;
			this.ac.BorderThickness = 1;
			this.ac.CheckedState.Parent = this.ac;
			this.ac.CustomImages.Parent = this.ac;
			this.i.SetDecoration(this.ac, 0);
			this.ac.FillColor = Color.Black;
			this.ac.Font = new Font(global::i.a("", 62698), 9f);
			this.ac.ForeColor = Color.Red;
			this.ac.HoveredState.Parent = this.ac;
			this.ac.Location = new Point(277, 169);
			this.ac.Name = global::i.a("", 62318);
			this.ac.ShadowDecoration.Parent = this.ac;
			this.ac.Size = new Size(123, 29);
			this.ac.TabIndex = 68;
			this.ac.Text = global::i.a("", 63133);
			this.ac.Click += this.am;
			this.ad.BorderColor = Color.DarkRed;
			this.ad.BorderThickness = 1;
			this.ad.CheckedState.Parent = this.ad;
			this.ad.CustomImages.Parent = this.ad;
			this.i.SetDecoration(this.ad, 0);
			this.ad.FillColor = Color.Black;
			this.ad.Font = new Font(global::i.a("", 62698), 9f);
			this.ad.ForeColor = Color.Red;
			this.ad.HoveredState.Parent = this.ad;
			this.ad.Location = new Point(277, 124);
			this.ad.Name = global::i.a("", 59978);
			this.ad.ShadowDecoration.Parent = this.ad;
			this.ad.Size = new Size(123, 29);
			this.ad.TabIndex = 67;
			this.ad.Text = global::i.a("", 62738);
			this.ad.Click += this.ao;
			this.ae.BorderColor = Color.DarkRed;
			this.ae.BorderThickness = 1;
			this.ae.CheckedState.Parent = this.ae;
			this.ae.CustomImages.Parent = this.ae;
			this.i.SetDecoration(this.ae, 0);
			this.ae.FillColor = Color.Black;
			this.ae.Font = new Font(global::i.a("", 62698), 9f);
			this.ae.ForeColor = Color.Red;
			this.ae.HoveredState.Parent = this.ae;
			this.ae.Location = new Point(54, 169);
			this.ae.Name = global::i.a("", 61375);
			this.ae.ShadowDecoration.Parent = this.ae;
			this.ae.Size = new Size(123, 29);
			this.ae.TabIndex = 66;
			this.ae.Text = global::i.a("", 63244);
			this.ae.Click += this.ai;
			this.af.BorderColor = Color.DarkRed;
			this.af.BorderThickness = 1;
			this.af.CheckedState.Parent = this.af;
			this.af.CustomImages.Parent = this.af;
			this.i.SetDecoration(this.af, 0);
			this.af.FillColor = Color.Black;
			this.af.Font = new Font(global::i.a("", 62698), 9f);
			this.af.ForeColor = Color.Red;
			this.af.HoveredState.Parent = this.af;
			this.af.Location = new Point(54, 210);
			this.af.Name = global::i.a("", 60052);
			this.af.ShadowDecoration.Parent = this.af;
			this.af.Size = new Size(123, 29);
			this.af.TabIndex = 65;
			this.af.Text = global::i.a("", 61552);
			this.af.Click += this.ak;
			this.ag.BorderColor = Color.DarkRed;
			this.ag.BorderThickness = 1;
			this.ag.CheckedState.Parent = this.ag;
			this.ag.CustomImages.Parent = this.ag;
			this.i.SetDecoration(this.ag, 0);
			this.ag.FillColor = Color.Black;
			this.ag.Font = new Font(global::i.a("", 62698), 9f);
			this.ag.ForeColor = Color.Red;
			this.ag.HoveredState.Parent = this.ag;
			this.ag.Location = new Point(277, 82);
			this.ag.Name = global::i.a("", 60565);
			this.ag.ShadowDecoration.Parent = this.ag;
			this.ag.Size = new Size(123, 29);
			this.ag.TabIndex = 64;
			this.ag.Text = global::i.a("", 59268);
			this.ag.Click += this.aj;
			this.ah.BorderColor = Color.DarkRed;
			this.ah.BorderThickness = 1;
			this.ah.CheckedState.Parent = this.ah;
			this.ah.CustomImages.Parent = this.ah;
			this.i.SetDecoration(this.ah, 0);
			this.ah.FillColor = Color.Black;
			this.ah.Font = new Font(global::i.a("", 62698), 9f);
			this.ah.ForeColor = Color.Red;
			this.ah.HoveredState.Parent = this.ah;
			this.ah.Location = new Point(54, 82);
			this.ah.Name = global::i.a("", 62199);
			this.ah.ShadowDecoration.Parent = this.ah;
			this.ah.Size = new Size(123, 29);
			this.ah.TabIndex = 63;
			this.ah.Text = global::i.a("", 63084);
			this.ah.Click += this.ag;
			this.v.BackColor = Color.Transparent;
			this.i.SetDecoration(this.v, 0);
			this.v.Font = new Font(global::i.a("", 62698), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.v.ForeColor = Color.Red;
			this.v.Location = new Point(68, 34);
			this.v.Margin = new Padding(2);
			this.v.Name = global::i.a("", 61010);
			this.v.Size = new Size(133, 15);
			this.v.TabIndex = 62;
			this.v.Text = global::i.a("", 59399);
			this.i.SetDecoration(this.w, 0);
			this.w.Image = Resources.pngaaa_com_3790696;
			this.w.Location = new Point(11, 10);
			this.w.Name = global::i.a("", 62657);
			this.w.Size = new Size(46, 35);
			this.w.SizeMode = PictureBoxSizeMode.Zoom;
			this.w.TabIndex = 25;
			this.w.TabStop = false;
			this.x.AutoSize = true;
			this.i.SetDecoration(this.x, 0);
			this.x.Font = new Font(global::i.a("", 62754), 18f, FontStyle.Bold);
			this.x.ForeColor = Color.White;
			this.x.Location = new Point(60, 6);
			this.x.Name = global::i.a("", 62760);
			this.x.Size = new Size(107, 32);
			this.x.TabIndex = 9;
			this.x.Text = global::i.a("", 59136);
			this.t.BackColor = Color.Transparent;
			this.i.SetDecoration(this.t, 0);
			this.t.Font = new Font(global::i.a("", 62698), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.t.ForeColor = Color.Red;
			this.t.Location = new Point(63, 34);
			this.t.Margin = new Padding(2);
			this.t.Name = global::i.a("", 60878);
			this.t.Size = new Size(116, 15);
			this.t.TabIndex = 61;
			this.t.Text = global::i.a("", 62376);
			this.ai.BackColor = Color.Black;
			this.ai.Controls.Add(this.bq);
			this.ai.Controls.Add(this.br);
			this.ai.Controls.Add(this.an);
			this.ai.Controls.Add(this.am);
			this.ai.Controls.Add(this.aj);
			this.ai.Controls.Add(this.ak);
			this.ai.Controls.Add(this.al);
			this.ai.Controls.Add(this.ao);
			this.i.SetDecoration(this.ai, 0);
			this.ai.FillColor = Color.Black;
			this.ai.Location = new Point(195, 34);
			this.ai.Name = global::i.a("", 58223);
			this.ai.ShadowColor = Color.Black;
			this.ai.Size = new Size(455, 311);
			this.ai.TabIndex = 71;
			this.ai.Paint += this.ae;
			this.bq.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bq, 0);
			this.bq.Font = new Font(global::i.a("", 62698), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bq.ForeColor = Color.Red;
			this.bq.Location = new Point(155, 181);
			this.bq.Margin = new Padding(2);
			this.bq.Name = global::i.a("", 59459);
			this.bq.Size = new Size(51, 15);
			this.bq.TabIndex = 74;
			this.bq.Text = global::i.a("", 59951);
			this.br.BorderColor = Color.WhiteSmoke;
			this.br.BorderRadius = 3;
			this.br.Cursor = Cursors.IBeam;
			this.i.SetDecoration(this.br, 0);
			this.br.DefaultText = global::i.a("", 59772);
			this.br.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.br.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.br.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.br.DisabledState.Parent = this.br;
			this.br.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.br.FillColor = Color.Black;
			this.br.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.br.FocusedState.Parent = this.br;
			this.br.ForeColor = Color.Red;
			this.br.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.br.HoveredState.Parent = this.br;
			this.br.Location = new Point(211, 178);
			this.br.Margin = new Padding(4);
			this.br.Name = global::i.a("", 57721);
			this.br.PasswordChar = '\0';
			this.br.PlaceholderText = "";
			this.br.SelectedText = "";
			this.br.ShadowDecoration.Parent = this.br;
			this.br.Size = new Size(109, 22);
			this.br.TabIndex = 73;
			this.br.TextAlign = HorizontalAlignment.Center;
			this.an.BackColor = Color.Transparent;
			this.i.SetDecoration(this.an, 0);
			this.an.Font = new Font(global::i.a("", 62698), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.an.ForeColor = Color.White;
			this.an.Location = new Point(143, 115);
			this.an.Margin = new Padding(2);
			this.an.Name = global::i.a("", 57607);
			this.an.Size = new Size(66, 15);
			this.an.TabIndex = 69;
			this.an.Text = global::i.a("", 59148);
			this.am.BorderColor = Color.DarkRed;
			this.am.BorderThickness = 1;
			this.am.CheckedState.Parent = this.am;
			this.am.CustomImages.Parent = this.am;
			this.i.SetDecoration(this.am, 0);
			this.am.FillColor = Color.Black;
			this.am.Font = new Font(global::i.a("", 62698), 9f);
			this.am.ForeColor = Color.Red;
			this.am.HoveredState.Parent = this.am;
			this.am.Location = new Point(127, 212);
			this.am.Name = global::i.a("", 60900);
			this.am.ShadowDecoration.Parent = this.am;
			this.am.Size = new Size(209, 29);
			this.am.TabIndex = 64;
			this.am.Text = global::i.a("", 63408);
			this.am.Click += this.ab;
			this.aj.BackColor = Color.Transparent;
			this.i.SetDecoration(this.aj, 0);
			this.aj.Font = new Font(global::i.a("", 62698), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.aj.ForeColor = Color.Red;
			this.aj.Location = new Point(65, 34);
			this.aj.Margin = new Padding(2);
			this.aj.Name = global::i.a("", 59197);
			this.aj.Size = new Size(76, 15);
			this.aj.TabIndex = 62;
			this.aj.Text = global::i.a("", 59070);
			this.i.SetDecoration(this.ak, 0);
			this.ak.Image = Resources.game;
			this.ak.Location = new Point(11, 10);
			this.ak.Name = global::i.a("", 63548);
			this.ak.Size = new Size(46, 35);
			this.ak.SizeMode = PictureBoxSizeMode.Zoom;
			this.ak.TabIndex = 25;
			this.ak.TabStop = false;
			this.al.AutoSize = true;
			this.i.SetDecoration(this.al, 0);
			this.al.Font = new Font(global::i.a("", 62754), 18f, FontStyle.Bold);
			this.al.ForeColor = Color.White;
			this.al.Location = new Point(60, 6);
			this.al.Name = global::i.a("", 59374);
			this.al.Size = new Size(93, 32);
			this.al.TabIndex = 9;
			this.al.Text = global::i.a("", 61930);
			this.ao.AccessibleDescription = global::i.a("", 63509);
			this.ao.AccessibleName = "";
			this.ao.BackColor = Color.Black;
			this.ao.BorderColor = Color.Black;
			this.i.SetDecoration(this.ao, 0);
			this.ao.DrawMode = DrawMode.OwnerDrawFixed;
			this.ao.DropDownStyle = ComboBoxStyle.DropDownList;
			this.ao.FillColor = Color.Black;
			this.ao.FocusedColor = Color.Black;
			this.ao.Font = new Font(global::i.a("", 62698), 10f);
			this.ao.ForeColor = Color.Red;
			this.ao.FormattingEnabled = true;
			this.ao.HoveredState.BorderColor = Color.FromArgb(26, 32, 54);
			this.ao.HoveredState.FillColor = Color.FromArgb(26, 32, 54);
			this.ao.HoveredState.Parent = this.ao;
			this.ao.ItemHeight = 30;
			this.ao.Items.AddRange(new object[]
			{
				global::i.a("", 57808)
			});
			this.ao.ItemsAppearance.Parent = this.ao;
			this.ao.Location = new Point(136, 130);
			this.ao.Name = global::i.a("", 63639);
			this.ao.ShadowDecoration.Parent = this.ao;
			this.ao.Size = new Size(184, 36);
			this.ao.TabIndex = 68;
			this.ao.Tag = "";
			this.ao.SelectedIndexChanged += this.af;
			this.ap.BackColor = Color.Transparent;
			this.ap.Controls.Add(this.bo);
			this.ap.Controls.Add(this.bn);
			this.ap.Controls.Add(this.bg);
			this.ap.Controls.Add(this.bh);
			this.ap.Controls.Add(this.bd);
			this.ap.Controls.Add(this.aq);
			this.ap.Controls.Add(this.ar);
			this.ap.Controls.Add(this.@as);
			this.ap.Controls.Add(this.p);
			this.i.SetDecoration(this.ap, 0);
			this.ap.FillColor = Color.Black;
			this.ap.ForeColor = Color.Crimson;
			this.ap.Location = new Point(195, 34);
			this.ap.Name = global::i.a("", 62426);
			this.ap.ShadowColor = Color.Black;
			this.ap.Size = new Size(455, 311);
			this.ap.TabIndex = 72;
			this.ap.Paint += this.aq;
			this.bo.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bo, 0);
			this.bo.Font = new Font(global::i.a("", 62698), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bo.ForeColor = Color.White;
			this.bo.Location = new Point(233, 295);
			this.bo.Margin = new Padding(2);
			this.bo.Name = global::i.a("", 57859);
			this.bo.Size = new Size(78, 15);
			this.bo.TabIndex = 76;
			this.bo.Text = global::i.a("", 60953);
			this.bo.Click += this.bs;
			this.bn.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bn, 0);
			this.bn.Font = new Font(global::i.a("", 62698), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bn.ForeColor = Color.Red;
			this.bn.Location = new Point(223, 295);
			this.bn.Margin = new Padding(2);
			this.bn.Name = global::i.a("", 59042);
			this.bn.Size = new Size(7, 15);
			this.bn.TabIndex = 75;
			this.bn.Text = global::i.a("", 62319);
			this.bg.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bg, 0);
			this.bg.Font = new Font(global::i.a("", 62698), 9f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.bg.ForeColor = Color.Red;
			this.bg.Location = new Point(37, 131);
			this.bg.Margin = new Padding(2);
			this.bg.Name = global::i.a("", 58038);
			this.bg.Size = new Size(66, 17);
			this.bg.TabIndex = 73;
			this.bg.Text = global::i.a("", 58003);
			this.bh.BorderColor = Color.WhiteSmoke;
			this.bh.BorderRadius = 3;
			this.bh.Cursor = Cursors.IBeam;
			this.i.SetDecoration(this.bh, 0);
			this.bh.DefaultText = global::i.a("", 60873);
			this.bh.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.bh.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.bh.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.bh.DisabledState.Parent = this.bh;
			this.bh.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.bh.FillColor = Color.Black;
			this.bh.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.bh.FocusedState.Parent = this.bh;
			this.bh.ForeColor = Color.Red;
			this.bh.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.bh.HoveredState.Parent = this.bh;
			this.bh.Location = new Point(107, 126);
			this.bh.Margin = new Padding(4);
			this.bh.Name = global::i.a("", 59294);
			this.bh.PasswordChar = '\0';
			this.bh.PlaceholderText = "";
			this.bh.SelectedText = "";
			this.bh.ShadowDecoration.Parent = this.bh;
			this.bh.Size = new Size(26, 28);
			this.bh.TabIndex = 72;
			this.bh.TextAlign = HorizontalAlignment.Center;
			this.bd.BorderColor = Color.Red;
			this.bd.BorderRadius = 4;
			this.bd.BorderThickness = 2;
			this.bd.CheckedState.Parent = this.bd;
			this.bd.CustomImages.Parent = this.bd;
			this.i.SetDecoration(this.bd, 0);
			this.bd.FillColor = Color.Black;
			this.bd.Font = new Font(global::i.a("", 62754), 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bd.ForeColor = Color.White;
			this.bd.HoveredState.Parent = this.bd;
			this.bd.Location = new Point(30, 77);
			this.bd.Name = global::i.a("", 62460);
			this.bd.PressedColor = Color.FromArgb(26, 32, 54);
			this.bd.ShadowDecoration.Parent = this.bd;
			this.bd.Size = new Size(117, 32);
			this.bd.TabIndex = 71;
			this.bd.Text = global::i.a("", 58659);
			this.bd.Click += this.bc;
			this.aq.BackColor = Color.Transparent;
			this.i.SetDecoration(this.aq, 0);
			this.aq.Font = new Font(global::i.a("", 62698), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.aq.ForeColor = Color.Red;
			this.aq.Location = new Point(65, 34);
			this.aq.Margin = new Padding(2);
			this.aq.Name = global::i.a("", 60790);
			this.aq.Size = new Size(101, 15);
			this.aq.TabIndex = 62;
			this.aq.Text = global::i.a("", 62837);
			this.i.SetDecoration(this.ar, 0);
			this.ar.Image = Resources.kindpng_3933927;
			this.ar.Location = new Point(11, 10);
			this.ar.Name = global::i.a("", 57825);
			this.ar.Size = new Size(46, 35);
			this.ar.SizeMode = PictureBoxSizeMode.Zoom;
			this.ar.TabIndex = 25;
			this.ar.TabStop = false;
			this.@as.AutoSize = true;
			this.i.SetDecoration(this.@as, 0);
			this.@as.Font = new Font(global::i.a("", 62754), 18f, FontStyle.Bold);
			this.@as.ForeColor = Color.White;
			this.@as.Location = new Point(60, 3);
			this.@as.Name = global::i.a("", 63543);
			this.@as.Size = new Size(111, 32);
			this.@as.TabIndex = 9;
			this.@as.Text = global::i.a("", 58304);
			this.at.AutoSize = true;
			this.i.SetDecoration(this.at, 0);
			this.at.Font = new Font(global::i.a("", 57501), 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.at.ForeColor = Color.Red;
			this.at.Location = new Point(116, 7);
			this.at.Margin = new Padding(2, 0, 2, 0);
			this.at.Name = global::i.a("", 59951);
			this.at.Size = new Size(13, 19);
			this.at.TabIndex = 74;
			this.at.Text = global::i.a("", 62319);
			this.aw.AutoSize = true;
			this.i.SetDecoration(this.aw, 0);
			this.aw.Font = new Font(global::i.a("", 57501), 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.aw.ForeColor = Color.White;
			this.aw.Location = new Point(130, 8);
			this.aw.Margin = new Padding(2, 0, 2, 0);
			this.aw.Name = global::i.a("", 58347);
			this.aw.Size = new Size(71, 19);
			this.aw.TabIndex = 75;
			this.aw.Text = global::i.a("", 58357);
			this.ax.BackColor = Color.Transparent;
			this.i.SetDecoration(this.ax, 0);
			this.ax.Font = new Font(global::i.a("", 57501), 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.ax.ForeColor = Color.Red;
			this.ax.Location = new Point(67, 317);
			this.ax.Margin = new Padding(2);
			this.ax.Name = global::i.a("", 59829);
			this.ax.Size = new Size(62, 17);
			this.ax.TabIndex = 40;
			this.ax.Text = global::i.a("", 61050);
			this.ax.Click += this.ar;
			this.ay.BackColor = Color.Transparent;
			this.ay.Controls.Add(this.bm);
			this.ay.Controls.Add(this.bl);
			this.ay.Controls.Add(this.bj);
			this.ay.Controls.Add(this.be);
			this.ay.Controls.Add(this.bv);
			this.ay.Controls.Add(this.bc);
			this.ay.Controls.Add(this.az);
			this.ay.Controls.Add(this.ba);
			this.ay.Controls.Add(this.bb);
			this.i.SetDecoration(this.ay, 0);
			this.ay.FillColor = Color.Black;
			this.ay.Location = new Point(195, 34);
			this.ay.Name = global::i.a("", 59663);
			this.ay.ShadowColor = Color.Black;
			this.ay.Size = new Size(455, 311);
			this.ay.TabIndex = 73;
			this.ay.Paint += this.aw;
			this.bm.BorderColor = Color.DarkRed;
			this.bm.BorderThickness = 1;
			this.bm.CheckedState.Parent = this.bm;
			this.bm.CustomImages.Parent = this.bm;
			this.i.SetDecoration(this.bm, 0);
			this.bm.FillColor = Color.Black;
			this.bm.Font = new Font(global::i.a("", 62698), 9f);
			this.bm.ForeColor = Color.Red;
			this.bm.HoveredState.Parent = this.bm;
			this.bm.Location = new Point(303, 223);
			this.bm.Name = global::i.a("", 58959);
			this.bm.ShadowDecoration.Parent = this.bm;
			this.bm.Size = new Size(123, 29);
			this.bm.TabIndex = 75;
			this.bm.Text = global::i.a("", 61315);
			this.bm.Click += this.bp;
			this.bl.BorderColor = Color.DarkRed;
			this.bl.BorderThickness = 1;
			this.bl.CheckedState.Parent = this.bl;
			this.bl.CustomImages.Parent = this.bl;
			this.i.SetDecoration(this.bl, 0);
			this.bl.FillColor = Color.Black;
			this.bl.Font = new Font(global::i.a("", 62698), 9f);
			this.bl.ForeColor = Color.Red;
			this.bl.HoveredState.Parent = this.bl;
			this.bl.Location = new Point(30, 225);
			this.bl.Name = global::i.a("", 62921);
			this.bl.ShadowDecoration.Parent = this.bl;
			this.bl.Size = new Size(123, 29);
			this.bl.TabIndex = 74;
			this.bl.Text = global::i.a("", 60126);
			this.bl.Click += this.bo;
			this.bj.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bj, 0);
			this.bj.Font = new Font(global::i.a("", 62698), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bj.ForeColor = Color.Red;
			this.bj.Location = new Point(107, 159);
			this.bj.Margin = new Padding(2);
			this.bj.Name = global::i.a("", 62636);
			this.bj.Size = new Size(229, 15);
			this.bj.TabIndex = 73;
			this.bj.Text = global::i.a("", 57405);
			this.be.BorderColor = Color.DarkRed;
			this.be.BorderThickness = 1;
			this.be.CheckedState.Parent = this.be;
			this.be.CustomImages.Parent = this.be;
			this.i.SetDecoration(this.be, 0);
			this.be.FillColor = Color.Black;
			this.be.Font = new Font(global::i.a("", 62698), 9f);
			this.be.ForeColor = Color.Red;
			this.be.HoveredState.Parent = this.be;
			this.be.Location = new Point(25, 271);
			this.be.Name = global::i.a("", 59503);
			this.be.ShadowDecoration.Parent = this.be;
			this.be.Size = new Size(402, 29);
			this.be.TabIndex = 72;
			this.be.Text = global::i.a("", 62763);
			this.be.Click += this.bk;
			this.bv.BorderColor = Color.DarkRed;
			this.bv.BorderThickness = 1;
			this.bv.CheckedState.Parent = this.bv;
			this.bv.CustomImages.Parent = this.bv;
			this.i.SetDecoration(this.bv, 0);
			this.bv.FillColor = Color.Black;
			this.bv.Font = new Font(global::i.a("", 62698), 9f);
			this.bv.ForeColor = Color.Red;
			this.bv.HoveredState.Parent = this.bv;
			this.bv.Location = new Point(303, 80);
			this.bv.Name = global::i.a("", 60743);
			this.bv.ShadowDecoration.Parent = this.bv;
			this.bv.Size = new Size(123, 29);
			this.bv.TabIndex = 71;
			this.bv.Text = global::i.a("", 60952);
			this.bv.Click += this.bf;
			this.bc.BorderColor = Color.DarkRed;
			this.bc.BorderThickness = 1;
			this.bc.CheckedState.Parent = this.bc;
			this.bc.CustomImages.Parent = this.bc;
			this.i.SetDecoration(this.bc, 0);
			this.bc.FillColor = Color.Black;
			this.bc.Font = new Font(global::i.a("", 62698), 9f);
			this.bc.ForeColor = Color.Red;
			this.bc.HoveredState.Parent = this.bc;
			this.bc.Location = new Point(30, 82);
			this.bc.Name = global::i.a("", 62655);
			this.bc.ShadowDecoration.Parent = this.bc;
			this.bc.Size = new Size(123, 29);
			this.bc.TabIndex = 67;
			this.bc.Text = global::i.a("", 59166);
			this.bc.Click += this.ax;
			this.az.BackColor = Color.Transparent;
			this.i.SetDecoration(this.az, 0);
			this.az.Font = new Font(global::i.a("", 62698), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.az.ForeColor = Color.Red;
			this.az.Location = new Point(68, 34);
			this.az.Margin = new Padding(2);
			this.az.Name = global::i.a("", 59357);
			this.az.Size = new Size(186, 15);
			this.az.TabIndex = 62;
			this.az.Text = global::i.a("", 60611);
			this.i.SetDecoration(this.ba, 0);
			this.ba.Image = Resources.pngaaa_com_3790696;
			this.ba.Location = new Point(11, 10);
			this.ba.Name = global::i.a("", 57921);
			this.ba.Size = new Size(46, 35);
			this.ba.SizeMode = PictureBoxSizeMode.Zoom;
			this.ba.TabIndex = 25;
			this.ba.TabStop = false;
			this.bb.AutoSize = true;
			this.i.SetDecoration(this.bb, 0);
			this.bb.Font = new Font(global::i.a("", 62754), 18f, FontStyle.Bold);
			this.bb.ForeColor = Color.White;
			this.bb.Location = new Point(60, 6);
			this.bb.Name = global::i.a("", 60180);
			this.bb.Size = new Size(221, 32);
			this.bb.TabIndex = 9;
			this.bb.Text = global::i.a("", 62838);
			this.bp.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bp, 0);
			this.bp.Font = new Font(global::i.a("", 62698), 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bp.ForeColor = SystemColors.ButtonHighlight;
			this.bp.Location = new Point(663, 319);
			this.bp.Margin = new Padding(2);
			this.bp.Name = global::i.a("", 57734);
			this.bp.Size = new Size(44, 15);
			this.bp.TabIndex = 77;
			this.bp.Text = global::i.a("", 57734);
			this.bi.CheckedState.Parent = this.bi;
			this.bi.CustomImages.Parent = this.bi;
			this.i.SetDecoration(this.bi, 0);
			this.bi.FillColor = Color.Transparent;
			this.bi.FillColor2 = Color.Transparent;
			this.bi.Font = new Font(global::i.a("", 62754), 10f, FontStyle.Bold);
			this.bi.ForeColor = Color.White;
			this.bi.HoveredState.Parent = this.bi;
			this.bi.Image = Resources.PngItem_2354504;
			this.bi.Location = new Point(18, 209);
			this.bi.Name = global::i.a("", 62656);
			this.bi.ShadowDecoration.Parent = this.bi;
			this.bi.Size = new Size(168, 52);
			this.bi.TabIndex = 76;
			this.bi.Text = global::i.a("", 60953);
			this.bi.Click += this.bl;
			this.y.CheckedState.Parent = this.y;
			this.y.CustomImages.Parent = this.y;
			this.i.SetDecoration(this.y, 0);
			this.y.FillColor = Color.Transparent;
			this.y.FillColor2 = Color.Transparent;
			this.y.Font = new Font(global::i.a("", 62754), 10f, FontStyle.Bold);
			this.y.ForeColor = Color.White;
			this.y.HoveredState.Parent = this.y;
			this.y.Image = Resources.game;
			this.y.Location = new Point(18, 151);
			this.y.Name = global::i.a("", 58572);
			this.y.ShadowDecoration.Parent = this.y;
			this.y.Size = new Size(169, 51);
			this.y.TabIndex = 72;
			this.y.Text = global::i.a("", 61930);
			this.y.Click += this.ac;
			this.z.CheckedState.Parent = this.z;
			this.z.CustomImages.Parent = this.z;
			this.i.SetDecoration(this.z, 0);
			this.z.FillColor = Color.Transparent;
			this.z.FillColor2 = Color.Transparent;
			this.z.Font = new Font(global::i.a("", 62754), 10f, FontStyle.Bold);
			this.z.ForeColor = Color.White;
			this.z.HoveredState.Parent = this.z;
			this.z.Image = Resources.pngaaa_com_3790696;
			this.z.Location = new Point(12, 93);
			this.z.Name = global::i.a("", 60552);
			this.z.ShadowDecoration.Parent = this.z;
			this.z.Size = new Size(175, 52);
			this.z.TabIndex = 71;
			this.z.Text = global::i.a("", 59136);
			this.z.Click += this.aa;
			this.aa.CheckedState.Parent = this.aa;
			this.aa.CustomImages.Parent = this.aa;
			this.i.SetDecoration(this.aa, 0);
			this.aa.FillColor = Color.Transparent;
			this.aa.FillColor2 = Color.Transparent;
			this.aa.Font = new Font(global::i.a("", 62754), 10f, FontStyle.Bold);
			this.aa.ForeColor = Color.White;
			this.aa.HoveredState.Parent = this.aa;
			this.aa.Image = Resources.kindpng_3933927;
			this.aa.Location = new Point(11, 271);
			this.aa.Name = global::i.a("", 58422);
			this.aa.ShadowDecoration.Parent = this.aa;
			this.aa.Size = new Size(175, 52);
			this.aa.TabIndex = 70;
			this.aa.Text = global::i.a("", 58304);
			this.aa.Click += this.ad;
			this.bu.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bu, 0);
			this.bu.Font = new Font(global::i.a("", 57501), 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.bu.ForeColor = Color.Purple;
			this.bu.Location = new Point(37, 332);
			this.bu.Margin = new Padding(2);
			this.bu.Name = global::i.a("", 61108);
			this.bu.Size = new Size(120, 17);
			this.bu.TabIndex = 78;
			this.bu.Text = global::i.a("", 61565);
			this.bu.Click += this.bx;
			this.o.Enabled = true;
			this.o.Interval = 1;
			this.o.Tick += this.d;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.AutoValidate = AutoValidate.Disable;
			this.BackColor = Color.Black;
			base.ClientSize = new Size(662, 352);
			base.Controls.Add(this.bu);
			base.Controls.Add(this.bp);
			base.Controls.Add(this.bi);
			base.Controls.Add(this.ax);
			base.Controls.Add(this.aw);
			base.Controls.Add(this.at);
			base.Controls.Add(this.y);
			base.Controls.Add(this.z);
			base.Controls.Add(this.aa);
			base.Controls.Add(this.r);
			base.Controls.Add(this.k);
			base.Controls.Add(this.j);
			base.Controls.Add(this.h);
			base.Controls.Add(this.g);
			base.Controls.Add(this.ai);
			base.Controls.Add(this.ay);
			base.Controls.Add(this.u);
			base.Controls.Add(this.ap);
			this.i.SetDecoration(this, 1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject(global::i.a("", 63659));
			base.Name = global::i.a("", 60399);
			base.Opacity = 0.85;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = global::i.a("", 58062);
			base.TransparencyKey = Color.Maroon;
			base.Load += this.b;
			this.r.ResumeLayout(false);
			this.r.PerformLayout();
			((ISupportInitialize)this.s).EndInit();
			this.u.ResumeLayout(false);
			this.u.PerformLayout();
			((ISupportInitialize)this.w).EndInit();
			this.ai.ResumeLayout(false);
			this.ai.PerformLayout();
			((ISupportInitialize)this.ak).EndInit();
			this.ap.ResumeLayout(false);
			this.ap.PerformLayout();
			((ISupportInitialize)this.ar).EndInit();
			this.ay.ResumeLayout(false);
			this.ay.PerformLayout();
			((ISupportInitialize)this.ba).EndInit();
			((ISupportInitialize)this.q).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000012 RID: 18
		private DiscordRpc.EventHandlers a;

		// Token: 0x04000013 RID: 19
		private DiscordRpc.RichPresence b;

		// Token: 0x04000014 RID: 20
		public static string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		// Token: 0x04000015 RID: 21
		public static string specificFolder = Path.Combine(Main.folder, global::i.a("", 59608));

		// Token: 0x04000016 RID: 22
		public static Random random = new Random();

		// Token: 0x04000017 RID: 23
		private string c = Main.RandomString(5);

		// Token: 0x04000018 RID: 24
		private List<Process> d = new List<Process>();

		// Token: 0x0400001A RID: 26
		private SiticoneDragControl f;

		// Token: 0x0400001B RID: 27
		private SiticoneControlBox g;

		// Token: 0x0400001C RID: 28
		private SiticoneControlBox h;

		// Token: 0x0400001D RID: 29
		private SiticoneTransition i;

		// Token: 0x0400001E RID: 30
		private Label j;

		// Token: 0x0400001F RID: 31
		private Label k;

		// Token: 0x04000020 RID: 32
		private SiticoneShadowForm l;

		// Token: 0x04000021 RID: 33
		private SiticoneLabel m;

		// Token: 0x04000022 RID: 34
		private SiticoneLabel n;

		// Token: 0x04000023 RID: 35
		private System.Windows.Forms.Timer o;

		// Token: 0x04000024 RID: 36
		private SiticoneLabel p;

		// Token: 0x04000025 RID: 37
		private BindingSource q;

		// Token: 0x04000026 RID: 38
		private Panel r;

		// Token: 0x04000027 RID: 39
		private PictureBox s;

		// Token: 0x04000028 RID: 40
		private SiticoneLabel t;

		// Token: 0x04000029 RID: 41
		private SiticoneShadowPanel u;

		// Token: 0x0400002A RID: 42
		private SiticoneLabel v;

		// Token: 0x0400002B RID: 43
		private PictureBox w;

		// Token: 0x0400002C RID: 44
		private Label x;

		// Token: 0x0400002D RID: 45
		private SiticoneGradientButton y;

		// Token: 0x0400002E RID: 46
		private SiticoneGradientButton z;

		// Token: 0x0400002F RID: 47
		private SiticoneGradientButton aa;

		// Token: 0x04000030 RID: 48
		private SiticoneRoundedButton ab;

		// Token: 0x04000031 RID: 49
		private SiticoneRoundedButton ac;

		// Token: 0x04000032 RID: 50
		private SiticoneRoundedButton ad;

		// Token: 0x04000033 RID: 51
		private SiticoneRoundedButton ae;

		// Token: 0x04000034 RID: 52
		private SiticoneRoundedButton af;

		// Token: 0x04000035 RID: 53
		private SiticoneRoundedButton ag;

		// Token: 0x04000036 RID: 54
		private SiticoneRoundedButton ah;

		// Token: 0x04000037 RID: 55
		private SiticoneShadowPanel ai;

		// Token: 0x04000038 RID: 56
		private SiticoneLabel aj;

		// Token: 0x04000039 RID: 57
		private PictureBox ak;

		// Token: 0x0400003A RID: 58
		private Label al;

		// Token: 0x0400003B RID: 59
		private SiticoneRoundedButton am;

		// Token: 0x0400003C RID: 60
		private SiticoneLabel an;

		// Token: 0x0400003D RID: 61
		private SiticoneComboBox ao;

		// Token: 0x0400003E RID: 62
		private SiticoneShadowPanel ap;

		// Token: 0x0400003F RID: 63
		private SiticoneLabel aq;

		// Token: 0x04000040 RID: 64
		private PictureBox ar;

		// Token: 0x04000041 RID: 65
		private Label @as;

		// Token: 0x04000042 RID: 66
		private Label at;

		// Token: 0x04000043 RID: 67
		private PageSetupDialog au;

		// Token: 0x04000044 RID: 68
		private System.Windows.Forms.Timer av;

		// Token: 0x04000045 RID: 69
		private Label aw;

		// Token: 0x04000046 RID: 70
		private SiticoneLabel ax;

		// Token: 0x04000047 RID: 71
		private SiticoneShadowPanel ay;

		// Token: 0x04000048 RID: 72
		private SiticoneLabel az;

		// Token: 0x04000049 RID: 73
		private PictureBox ba;

		// Token: 0x0400004A RID: 74
		private Label bb;

		// Token: 0x0400004B RID: 75
		private SiticoneRoundedButton bc;

		// Token: 0x0400004C RID: 76
		private SiticoneButton bd;

		// Token: 0x0400004D RID: 77
		private SiticoneRoundedButton be;

		// Token: 0x0400004E RID: 78
		private SiticoneRoundedButton bf;

		// Token: 0x0400004F RID: 79
		private SiticoneLabel bg;

		// Token: 0x04000050 RID: 80
		private SiticoneTextBox bh;

		// Token: 0x04000051 RID: 81
		private SiticoneGradientButton bi;

		// Token: 0x04000052 RID: 82
		private SiticoneLabel bj;

		// Token: 0x04000053 RID: 83
		private SiticoneRoundedButton bk;

		// Token: 0x04000054 RID: 84
		private SiticoneRoundedButton bl;

		// Token: 0x04000055 RID: 85
		private SiticoneRoundedButton bm;

		// Token: 0x04000056 RID: 86
		private SiticoneLabel bn;

		// Token: 0x04000057 RID: 87
		private SiticoneLabel bo;

		// Token: 0x04000058 RID: 88
		private SiticoneLabel bp;

		// Token: 0x04000059 RID: 89
		private SiticoneLabel bq;

		// Token: 0x0400005A RID: 90
		private SiticoneTextBox br;

		// Token: 0x0400005B RID: 91
		private System.Windows.Forms.Timer bs;

		// Token: 0x0400005C RID: 92
		private SiticoneButton bt;

		// Token: 0x0400005D RID: 93
		private SiticoneLabel bu;

		// Token: 0x0400005E RID: 94
		private SiticoneRoundedButton bv;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
