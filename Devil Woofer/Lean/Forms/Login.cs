using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Timers;
using System.Windows.Forms;
using Lean.Resources;
using Newtonsoft.Json;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace Lean.Forms
{
	// Token: 0x0200000B RID: 11
	public partial class Login : Form
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00013CB3 File Offset: 0x00011EB3
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00013CBB File Offset: 0x00011EBB
		public object JsonConvert { get; private set; }

		// Token: 0x060000A7 RID: 167 RVA: 0x00013CC4 File Offset: 0x00011EC4
		public Login()
		{
			System.Timers.Timer timer = new System.Timers.Timer(50.0);
			timer.AutoReset = true;
			timer.Elapsed += Login.MyMethod;
			timer.Start();
			this.u();
			this.r.Hide();
			this.q.Hide();
			this.u.Hide();
			this.v.Hide();
			this.s.Hide();
			this.t.Hide();
			this.w.Hide();
			this.x.Hide();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00013D9C File Offset: 0x00011F9C
		public static void MyMethod(object sender, ElapsedEventArgs e)
		{
			DateTime t = new DateTime(-107456241 - -298761230 + -191302967, -(-878886650 ^ -312922354) + 650407438, 958533961 + -389632679 - 568901253, ~(-64 >> 3), -281647497 - 196381982 - -478029529, ~-696815616 + -696815605);
			if (t < DateTime.Now)
			{
				int num = (-679546646 - -673432304 >> 1) - -3057171;
				num = (-(239874708 << 2 >> 3) ^ -119937353) / num;
			}
			Login.b();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00013E58 File Offset: 0x00012058
		private void a(object a, EventArgs b)
		{
			DateTime t = new DateTime((-525884732 ^ 124328402) + 405884112, ~-579553386 + -579553379, -133701273 + 133701301);
			if (DateTime.Now > t)
			{
				throw new ArgumentOutOfRangeException();
			}
			Environment.Exit(0);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00013EC0 File Offset: 0x000120C0
		private static void b()
		{
			Process[] processesByName = Process.GetProcessesByName(global::i.a("", 63145));
			bool flag = processesByName.Length == 0;
			if (!flag)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 60400), global::i.a("", 62817))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 62603), global::i.a("", 59172) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName2 = Process.GetProcessesByName(global::i.a("", 59336));
			bool flag2 = processesByName2.Length == 0;
			if (!flag2)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 60400), global::i.a("", 62817))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 62603), global::i.a("", 59172) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName3 = Process.GetProcessesByName(global::i.a("", 58000));
			bool flag3 = processesByName3.Length == 0;
			if (!flag3)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 60400), global::i.a("", 62817))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 62603), global::i.a("", 59172) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName4 = Process.GetProcessesByName(global::i.a("", 58853));
			bool flag4 = processesByName4.Length == 0;
			if (!flag4)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 60400), global::i.a("", 62817))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 62603), global::i.a("", 59172) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName5 = Process.GetProcessesByName(global::i.a("", 62293));
			bool flag5 = processesByName5.Length == 0;
			if (!flag5)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 60400), global::i.a("", 62817))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 62603), global::i.a("", 59172) + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName6 = Process.GetProcessesByName(global::i.a("", 62741));
			bool flag6 = processesByName6.Length == 0;
			if (!flag6)
			{
				Process.Start(new ProcessStartInfo(global::i.a("", 60400), global::i.a("", 62817))
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start(global::i.a("", 62603), global::i.a("", 59172) + Application.ExecutablePath);
				Application.Exit();
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000142A0 File Offset: 0x000124A0
		private void c(object a, EventArgs b)
		{
			Login.b();
			string path = global::i.a("", 57493);
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
				directoryInfo.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
			}
			else
			{
				Directory.CreateDirectory(global::i.a("", 57493));
				DirectoryInfo directoryInfo2 = Directory.CreateDirectory(path);
				directoryInfo2.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
			}
			this.z.Show();
			bool flag2 = File.Exists(global::i.a("", 61129));
			if (flag2)
			{
				string text = File.ReadAllText(global::i.a("", 61129));
				this.n.Text = text;
			}
			bool flag3 = File.Exists(global::i.a("", 58564));
			if (flag3)
			{
				string text2 = File.ReadAllText(global::i.a("", 58564));
				this.y.Text = text2;
			}
			base.Size = new Size(219, 235);
			Login.KeyAuthApp.init();
			bool flag4 = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
			if (flag4)
			{
				bool flag5 = !Login.KeyAuthApp.response.success;
				if (flag5)
				{
					DialogResult dialogResult = MessageBox.Show(global::i.a("", 60839), global::i.a("", 63389), MessageBoxButtons.OKCancel);
					DialogResult dialogResult2 = dialogResult;
					DialogResult dialogResult3 = dialogResult2;
					if (dialogResult3 != DialogResult.OK)
					{
						if (dialogResult3 == DialogResult.Cancel)
						{
							Application.Exit();
						}
					}
					else
					{
						Process.Start(Login.KeyAuthApp.app_data.downloadLink);
						Environment.Exit(0);
					}
				}
			}
			else
			{
				MessageBox.Show(global::i.a("", 62891), global::i.a("", 61095), MessageBoxButtons.OK);
				Application.Exit();
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000144A8 File Offset: 0x000126A8
		private static string d()
		{
			string text = null;
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
			}
			return text;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00014520 File Offset: 0x00012720
		public static void sendWebHook(string Url, string msg, string Username, string Plan)
		{
			global::e.a(Url, new NameValueCollection
			{
				{
					global::i.a("", 60249),
					Username
				},
				{
					global::i.a("", 60367),
					msg
				},
				{
					global::i.a("", 60367),
					Plan
				}
			});
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00014580 File Offset: 0x00012780
		public static void sendWebHookregister(string Url, string msg, string Username, string Plan, string Key)
		{
			global::e.a(Url, new NameValueCollection
			{
				{
					global::i.a("", 59446),
					Username
				},
				{
					global::i.a("", 60752),
					msg
				},
				{
					global::i.a("", 60752),
					Plan
				},
				{
					global::i.a("", 60752),
					Key
				}
			});
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000145F8 File Offset: 0x000127F8
		private void e(object a, EventArgs b)
		{
			try
			{
				Login.KeyAuthApp.login(this.n.Text, this.y.Text);
				bool success = Login.KeyAuthApp.response.success;
				if (success)
				{
					string[] array = new string[]
					{
						this.n.Text
					};
					string path = global::i.a("", 61205);
					string path2 = global::i.a("", 62511);
					bool flag = File.Exists(path2);
					if (flag)
					{
						File.Delete(path2);
					}
					using (StreamWriter streamWriter = new StreamWriter(Path.Combine(path, global::i.a("", 61904))))
					{
						foreach (string value in array)
						{
							streamWriter.WriteLine(value);
						}
					}
					string[] array3 = new string[]
					{
						this.y.Text
					};
					string path3 = global::i.a("", 61205);
					string path4 = global::i.a("", 59108);
					bool flag2 = File.Exists(path4);
					if (flag2)
					{
						File.Delete(path4);
					}
					using (StreamWriter streamWriter2 = new StreamWriter(Path.Combine(path3, global::i.a("", 59010))))
					{
						foreach (string value2 in array3)
						{
							streamWriter2.WriteLine(value2);
						}
					}
					Main main = new Main();
					main.Show();
					base.Hide();
					string path5 = global::i.a("", 63619);
					bool flag3 = !Directory.Exists(path5);
					if (flag3)
					{
						Directory.CreateDirectory(path5);
					}
					bool flag4 = File.Exists(global::i.a("", 60762));
					if (flag4)
					{
					}
				}
				else
				{
					MessageBox.Show(Login.KeyAuthApp.response.message, global::i.a("", 61390), MessageBoxButtons.OK);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00014884 File Offset: 0x00012A84
		private void f(object a, EventArgs b)
		{
			this.z.Hide();
			base.Size = new Size(219, 266);
			this.n.Hide();
			this.o.Hide();
			this.p.Hide();
			this.y.Hide();
			this.m.Hide();
			this.l.Hide();
			this.y.Hide();
			this.r.Show();
			this.q.Show();
			this.u.Show();
			this.v.Show();
			this.s.Show();
			this.t.Show();
			this.w.Show();
			this.x.Show();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000035B2 File Offset: 0x000017B2
		private void g(object a, EventArgs b)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000035B2 File Offset: 0x000017B2
		private void h(object a, EventArgs b)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000035B2 File Offset: 0x000017B2
		private void i(object a, EventArgs b)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000035B2 File Offset: 0x000017B2
		private void j(object a, EventArgs b)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000035B2 File Offset: 0x000017B2
		private void k(object a, EventArgs b)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0001498C File Offset: 0x00012B8C
		private void l(object a, EventArgs b)
		{
			Login.KeyAuthApp.register(this.q.Text, this.v.Text, this.t.Text);
			bool success = Login.KeyAuthApp.response.success;
			if (success)
			{
				string[] array = new string[]
				{
					this.q.Text
				};
				string path = global::i.a("", 61888);
				string path2 = global::i.a("", 59689);
				bool flag = File.Exists(path2);
				if (flag)
				{
					File.Delete(path2);
				}
				using (StreamWriter streamWriter = new StreamWriter(Path.Combine(path, global::i.a("", 59607))))
				{
					foreach (string value in array)
					{
						streamWriter.WriteLine(value);
					}
					File.SetAttributes(global::i.a("", 59689), FileAttributes.Hidden);
				}
				string[] array3 = new string[]
				{
					this.v.Text
				};
				string path3 = global::i.a("", 61888);
				string path4 = global::i.a("", 59030);
				bool flag2 = File.Exists(path4);
				if (flag2)
				{
					File.Delete(path4);
				}
				using (StreamWriter streamWriter2 = new StreamWriter(Path.Combine(path3, global::i.a("", 57623))))
				{
					foreach (string value2 in array3)
					{
						streamWriter2.WriteLine(value2);
					}
					File.SetAttributes(global::i.a("", 59030), FileAttributes.Hidden);
				}
				bool flag3 = Login.KeyAuthApp.user_data.subscriptions[0].subscription == global::i.a("", 60726);
				if (flag3)
				{
				}
				string requestUriString = global::i.a("", 61614);
				WebRequest webRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
				webRequest.ContentType = global::i.a("", 60453);
				webRequest.Method = global::i.a("", 60360);
				using (StreamWriter streamWriter3 = new StreamWriter(webRequest.GetRequestStream()))
				{
					string value3 = Newtonsoft.Json.JsonConvert.SerializeObject(new a<string, b<string, string, string, c<string, string>>[]>(global::i.a("", 57937), new b<string, string, string, c<string, string>>[]
					{
						new b<string, string, string, c<string, string>>(global::i.a("㭃㹵", 58200) + Login.KeyAuthApp.user_data.subscriptions[0].subscription + global::i.a("㿆㫪", 59290) + this.t.Text, this.q.Text + global::i.a("デ㝲", 59578), global::i.a("", 63221), new c<string, string>(global::i.a("", 59298), global::i.a("げ㓳", 59467)))
					}));
					streamWriter3.Write(value3);
				}
				HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
				Main main = new Main();
				main.Show();
				base.Hide();
				MessageBox.Show(global::i.a("", 59300), global::i.a("", 57937), MessageBoxButtons.OK);
			}
			else
			{
				MessageBox.Show(Login.KeyAuthApp.response.message, global::i.a("", 59785), MessageBoxButtons.OK);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00014D7C File Offset: 0x00012F7C
		private void m(object a, EventArgs b)
		{
			this.z.Show();
			base.Size = new Size(219, 235);
			this.n.Hide();
			this.o.Show();
			this.p.Show();
			this.y.Show();
			this.m.Show();
			this.l.Show();
			this.y.Show();
			this.n.Show();
			this.r.Hide();
			this.q.Hide();
			this.u.Hide();
			this.v.Hide();
			this.s.Hide();
			this.t.Hide();
			this.w.Hide();
			this.x.Hide();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000035B2 File Offset: 0x000017B2
		private void n(object a, EventArgs b)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00014E90 File Offset: 0x00013090
		private void o(object a, EventArgs b)
		{
			Process.Start(global::i.a("", 60899));
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000035B2 File Offset: 0x000017B2
		private void p(object a, EventArgs b)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00014EA8 File Offset: 0x000130A8
		private void q(object a, MouseEventArgs b)
		{
			this.b = true;
			this.c = b.Location;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00014EC0 File Offset: 0x000130C0
		private void r(object a, MouseEventArgs b)
		{
			bool flag = this.b;
			if (flag)
			{
				base.Location = new Point(base.Location.X - this.c.X + b.X, base.Location.Y - this.c.Y + b.Y);
				base.Update();
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00014F3B File Offset: 0x0001313B
		private void s(object a, MouseEventArgs b)
		{
			this.b = false;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000035B2 File Offset: 0x000017B2
		private void t(object a, EventArgs b)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00014F94 File Offset: 0x00013194
		private void u()
		{
			this.d = new Container();
			Animation animation = new Animation();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Login));
			this.e = new SiticoneDragControl(this.d);
			this.f = new SiticoneControlBox();
			this.g = new SiticoneControlBox();
			this.h = new SiticoneTransition();
			this.i = new Label();
			this.j = new Label();
			this.m = new SiticoneButton();
			this.l = new SiticoneButton();
			this.n = new SiticoneTextBox();
			this.o = new Label();
			this.p = new Label();
			this.q = new SiticoneTextBox();
			this.r = new Label();
			this.u = new Label();
			this.v = new SiticoneTextBox();
			this.s = new Label();
			this.t = new SiticoneTextBox();
			this.w = new SiticoneButton();
			this.x = new SiticoneButton();
			this.y = new SiticoneTextBox();
			this.z = new SiticoneLabel();
			this.k = new SiticoneShadowForm(this.d);
			this.aa = new System.Windows.Forms.Timer(this.d);
			this.ab = new System.Windows.Forms.Timer(this.d);
			base.SuspendLayout();
			this.e.TargetControl = this;
			this.f.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.f.BorderRadius = 10;
			this.h.SetDecoration(this.f, 0);
			this.f.FillColor = Color.Black;
			this.f.HoveredState.FillColor = Color.FromArgb(232, 17, 35);
			this.f.HoveredState.IconColor = Color.White;
			this.f.HoveredState.Parent = this.f;
			this.f.IconColor = Color.White;
			this.f.Location = new Point(190, 7);
			this.f.Name = global::i.a("", 63070);
			this.f.PressedColor = Color.DarkRed;
			this.f.ShadowDecoration.Parent = this.f;
			this.f.Size = new Size(45, 29);
			this.f.TabIndex = 1;
			this.f.Click += this.a;
			this.g.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.g.BorderRadius = 10;
			this.g.ControlBoxType = 0;
			this.h.SetDecoration(this.g, 0);
			this.g.FillColor = Color.Black;
			this.g.HoveredState.Parent = this.g;
			this.g.IconColor = Color.White;
			this.g.Location = new Point(139, 7);
			this.g.Name = global::i.a("", 62308);
			this.g.PressedColor = Color.DarkRed;
			this.g.ShadowDecoration.Parent = this.g;
			this.g.Size = new Size(45, 29);
			this.g.TabIndex = 2;
			this.g.Click += this.t;
			this.h.AnimationType = 1;
			this.h.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (PointF)componentResourceManager.GetObject(global::i.a("", 57918));
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (PointF)componentResourceManager.GetObject(global::i.a("", 58150));
			animation.MosaicShift = (PointF)componentResourceManager.GetObject(global::i.a("", 59897));
			animation.MosaicSize = 0;
			animation.Padding = new Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (PointF)componentResourceManager.GetObject(global::i.a("", 61112));
			animation.SlideCoeff = (PointF)componentResourceManager.GetObject(global::i.a("", 61172));
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.h.DefaultAnimation = animation;
			this.i.AutoSize = true;
			this.h.SetDecoration(this.i, 0);
			this.i.Font = new Font(global::i.a("", 61343), 10f);
			this.i.ForeColor = Color.White;
			this.i.Location = new Point(-1, 136);
			this.i.Name = global::i.a("", 63471);
			this.i.Size = new Size(0, 19);
			this.i.TabIndex = 22;
			this.j.AutoSize = true;
			this.h.SetDecoration(this.j, 0);
			this.j.Font = new Font(global::i.a("", 58490), 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.j.ForeColor = Color.White;
			this.j.Location = new Point(9, 9);
			this.j.Margin = new Padding(2, 0, 2, 0);
			this.j.Name = global::i.a("", 59584);
			this.j.Size = new Size(98, 19);
			this.j.TabIndex = 27;
			this.j.Text = global::i.a("", 61153);
			this.j.Click += this.p;
			this.m.BorderColor = Color.Red;
			this.m.BorderRadius = 4;
			this.m.BorderThickness = 2;
			this.m.CheckedState.Parent = this.m;
			this.m.CustomImages.Parent = this.m;
			this.h.SetDecoration(this.m, 0);
			this.m.FillColor = Color.Black;
			this.m.Font = new Font(global::i.a("", 60966), 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m.ForeColor = Color.White;
			this.m.HoveredState.Parent = this.m;
			this.m.Location = new Point(36, 178);
			this.m.Name = global::i.a("", 61969);
			this.m.PressedColor = Color.FromArgb(26, 32, 54);
			this.m.ShadowDecoration.Parent = this.m;
			this.m.Size = new Size(72, 32);
			this.m.TabIndex = 36;
			this.m.Text = global::i.a("", 63331);
			this.m.Click += this.e;
			this.l.BorderColor = Color.Red;
			this.l.BorderRadius = 4;
			this.l.BorderThickness = 2;
			this.l.CheckedState.Parent = this.l;
			this.l.CustomImages.Parent = this.l;
			this.h.SetDecoration(this.l, 0);
			this.l.FillColor = Color.Black;
			this.l.Font = new Font(global::i.a("", 60966), 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.l.ForeColor = Color.White;
			this.l.HoveredState.Parent = this.l;
			this.l.Location = new Point(114, 178);
			this.l.Name = global::i.a("", 63542);
			this.l.PressedColor = Color.FromArgb(26, 32, 54);
			this.l.ShadowDecoration.Parent = this.l;
			this.l.Size = new Size(81, 32);
			this.l.TabIndex = 37;
			this.l.Text = global::i.a("", 58699);
			this.l.Click += this.f;
			this.n.BorderColor = Color.White;
			this.n.BorderRadius = 3;
			this.n.Cursor = Cursors.IBeam;
			this.h.SetDecoration(this.n, 0);
			this.n.DefaultText = "";
			this.n.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.n.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.n.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.n.DisabledState.Parent = this.n;
			this.n.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.n.FillColor = Color.Black;
			this.n.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.n.FocusedState.Parent = this.n;
			this.n.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.n.HoveredState.Parent = this.n;
			this.n.Location = new Point(37, 64);
			this.n.Margin = new Padding(4);
			this.n.Name = global::i.a("", 62229);
			this.n.PasswordChar = '\0';
			this.n.PlaceholderText = "";
			this.n.SelectedText = "";
			this.n.ShadowDecoration.Parent = this.n;
			this.n.Size = new Size(159, 37);
			this.n.TabIndex = 39;
			this.n.TextChanged += this.g;
			this.o.AutoSize = true;
			this.h.SetDecoration(this.o, 0);
			this.o.Font = new Font(global::i.a("", 60966), 10f, FontStyle.Bold);
			this.o.ForeColor = Color.Red;
			this.o.Location = new Point(34, 41);
			this.o.Name = global::i.a("", 59255);
			this.o.Size = new Size(78, 19);
			this.o.TabIndex = 38;
			this.o.Text = global::i.a("", 58916);
			this.o.Click += this.h;
			this.p.AutoSize = true;
			this.h.SetDecoration(this.p, 0);
			this.p.Font = new Font(global::i.a("", 60966), 10f, FontStyle.Bold);
			this.p.ForeColor = Color.Red;
			this.p.Location = new Point(32, 105);
			this.p.Name = global::i.a("", 61110);
			this.p.Size = new Size(76, 19);
			this.p.TabIndex = 41;
			this.p.Text = global::i.a("", 61542);
			this.q.BorderColor = Color.White;
			this.q.BorderRadius = 3;
			this.q.Cursor = Cursors.IBeam;
			this.h.SetDecoration(this.q, 0);
			this.q.DefaultText = "";
			this.q.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.q.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.q.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.q.DisabledState.Parent = this.q;
			this.q.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.q.FillColor = Color.Black;
			this.q.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.q.FocusedState.Parent = this.q;
			this.q.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.q.HoveredState.Parent = this.q;
			this.q.Location = new Point(37, 64);
			this.q.Margin = new Padding(4);
			this.q.Name = global::i.a("", 58508);
			this.q.PasswordChar = '\0';
			this.q.PlaceholderText = "";
			this.q.SelectedText = "";
			this.q.ShadowDecoration.Parent = this.q;
			this.q.Size = new Size(159, 37);
			this.q.TabIndex = 43;
			this.r.AutoSize = true;
			this.h.SetDecoration(this.r, 0);
			this.r.Font = new Font(global::i.a("", 60966), 10f, FontStyle.Bold);
			this.r.ForeColor = Color.Red;
			this.r.Location = new Point(34, 41);
			this.r.Name = global::i.a("", 63461);
			this.r.Size = new Size(78, 19);
			this.r.TabIndex = 42;
			this.r.Text = global::i.a("", 58916);
			this.u.AutoSize = true;
			this.h.SetDecoration(this.u, 0);
			this.u.Font = new Font(global::i.a("", 60966), 10f, FontStyle.Bold);
			this.u.ForeColor = Color.Red;
			this.u.Location = new Point(32, 105);
			this.u.Name = global::i.a("", 61647);
			this.u.Size = new Size(76, 19);
			this.u.TabIndex = 45;
			this.u.Text = global::i.a("", 61542);
			this.v.BorderColor = Color.White;
			this.v.BorderRadius = 3;
			this.v.Cursor = Cursors.IBeam;
			this.h.SetDecoration(this.v, 0);
			this.v.DefaultText = "";
			this.v.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.v.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.v.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.v.DisabledState.Parent = this.v;
			this.v.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.v.FillColor = Color.Black;
			this.v.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.v.FocusedState.Parent = this.v;
			this.v.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.v.HoveredState.Parent = this.v;
			this.v.Location = new Point(36, 128);
			this.v.Margin = new Padding(4);
			this.v.Name = global::i.a("", 57575);
			this.v.PasswordChar = '\0';
			this.v.PlaceholderText = "";
			this.v.SelectedText = "";
			this.v.ShadowDecoration.Parent = this.v;
			this.v.Size = new Size(159, 37);
			this.v.TabIndex = 44;
			this.v.UseSystemPasswordChar = true;
			this.s.AutoSize = true;
			this.h.SetDecoration(this.s, 0);
			this.s.Font = new Font(global::i.a("", 60966), 10f, FontStyle.Bold);
			this.s.ForeColor = Color.Red;
			this.s.Location = new Point(33, 169);
			this.s.Name = global::i.a("", 61014);
			this.s.Size = new Size(35, 19);
			this.s.TabIndex = 47;
			this.s.Text = global::i.a("", 62486);
			this.t.BorderColor = Color.White;
			this.t.BorderRadius = 3;
			this.t.Cursor = Cursors.IBeam;
			this.h.SetDecoration(this.t, 0);
			this.t.DefaultText = "";
			this.t.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.t.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.t.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.t.DisabledState.Parent = this.t;
			this.t.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.t.FillColor = Color.Black;
			this.t.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.t.FocusedState.Parent = this.t;
			this.t.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.t.HoveredState.Parent = this.t;
			this.t.Location = new Point(36, 188);
			this.t.Margin = new Padding(4);
			this.t.Name = global::i.a("", 62133);
			this.t.PasswordChar = '\0';
			this.t.PlaceholderText = "";
			this.t.SelectedText = "";
			this.t.ShadowDecoration.Parent = this.t;
			this.t.Size = new Size(159, 37);
			this.t.TabIndex = 46;
			this.t.UseSystemPasswordChar = true;
			this.t.TextChanged += this.n;
			this.w.BorderColor = Color.Red;
			this.w.BorderRadius = 4;
			this.w.BorderThickness = 2;
			this.w.CheckedState.Parent = this.w;
			this.w.CustomImages.Parent = this.w;
			this.h.SetDecoration(this.w, 0);
			this.w.FillColor = Color.Black;
			this.w.Font = new Font(global::i.a("", 60966), 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.w.ForeColor = Color.White;
			this.w.HoveredState.Parent = this.w;
			this.w.Location = new Point(38, 228);
			this.w.Name = global::i.a("", 62929);
			this.w.PressedColor = Color.FromArgb(26, 32, 54);
			this.w.ShadowDecoration.Parent = this.w;
			this.w.Size = new Size(70, 32);
			this.w.TabIndex = 49;
			this.w.Text = global::i.a("", 58699);
			this.w.Click += this.l;
			this.x.BorderColor = Color.Red;
			this.x.BorderRadius = 4;
			this.x.BorderThickness = 2;
			this.x.CheckedState.Parent = this.x;
			this.x.CustomImages.Parent = this.x;
			this.h.SetDecoration(this.x, 0);
			this.x.FillColor = Color.Black;
			this.x.Font = new Font(global::i.a("", 60966), 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.x.ForeColor = Color.White;
			this.x.HoveredState.Parent = this.x;
			this.x.Location = new Point(114, 228);
			this.x.Name = global::i.a("", 62454);
			this.x.PressedColor = Color.FromArgb(26, 32, 54);
			this.x.ShadowDecoration.Parent = this.x;
			this.x.Size = new Size(76, 32);
			this.x.TabIndex = 48;
			this.x.Text = global::i.a("", 63331);
			this.x.Click += this.m;
			this.y.BorderColor = Color.White;
			this.y.BorderRadius = 3;
			this.y.Cursor = Cursors.IBeam;
			this.h.SetDecoration(this.y, 0);
			this.y.DefaultText = "";
			this.y.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.y.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.y.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.y.DisabledState.Parent = this.y;
			this.y.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.y.FillColor = Color.Black;
			this.y.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.y.FocusedState.Parent = this.y;
			this.y.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.y.HoveredState.Parent = this.y;
			this.y.Location = new Point(36, 128);
			this.y.Margin = new Padding(4);
			this.y.Name = global::i.a("", 62669);
			this.y.PasswordChar = '\0';
			this.y.PlaceholderText = "";
			this.y.SelectedText = "";
			this.y.ShadowDecoration.Parent = this.y;
			this.y.Size = new Size(159, 37);
			this.y.TabIndex = 40;
			this.y.UseSystemPasswordChar = true;
			this.y.TextChanged += this.k;
			this.z.BackColor = Color.Transparent;
			this.h.SetDecoration(this.z, 0);
			this.z.Font = new Font(global::i.a("", 58490), 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.z.ForeColor = Color.Red;
			this.z.Location = new Point(50, 215);
			this.z.Margin = new Padding(2);
			this.z.Name = global::i.a("", 59787);
			this.z.Size = new Size(127, 17);
			this.z.TabIndex = 50;
			this.z.Text = global::i.a("", 58109);
			this.z.Click += this.o;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.AutoValidate = AutoValidate.Disable;
			this.BackColor = Color.Black;
			base.ClientSize = new Size(236, 266);
			base.Controls.Add(this.z);
			base.Controls.Add(this.w);
			base.Controls.Add(this.x);
			base.Controls.Add(this.s);
			base.Controls.Add(this.t);
			base.Controls.Add(this.u);
			base.Controls.Add(this.q);
			base.Controls.Add(this.r);
			base.Controls.Add(this.p);
			base.Controls.Add(this.y);
			base.Controls.Add(this.n);
			base.Controls.Add(this.o);
			base.Controls.Add(this.l);
			base.Controls.Add(this.m);
			base.Controls.Add(this.j);
			base.Controls.Add(this.i);
			base.Controls.Add(this.g);
			base.Controls.Add(this.f);
			base.Controls.Add(this.v);
			this.h.SetDecoration(this, 1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject(global::i.a("", 63203));
			base.Name = global::i.a("", 61962);
			base.Opacity = 0.85;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = global::i.a("", 59215);
			base.TransparencyKey = Color.Maroon;
			base.Load += this.c;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00016EB8 File Offset: 0x000150B8
		// Note: this type is marked as 'beforefieldinit'.
		static Login()
		{
			DateTime t = default(DateTime);
			t = t.AddYears(~(-(-277934606 + 277936628)));
			t = t.AddMonths(-632574982 - -632575142 >> 5);
			t = t.AddDays(28.4571875);
			if (t < DateTime.Now)
			{
				int num = ~(-(-713136145 + 713136149 >> 2)) << 5;
				num = ~(-585829291 ^ 585829291) / num;
			}
			Login.KeyAuthApp = new api(global::i.a("", 60350), global::i.a("", 58990), global::i.a("", 62845), global::i.a("", 63617));
		}

		// Token: 0x04000063 RID: 99
		public static api KeyAuthApp;

		// Token: 0x04000064 RID: 100
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object a;

		// Token: 0x04000065 RID: 101
		private bool b;

		// Token: 0x04000066 RID: 102
		private Point c;

		// Token: 0x04000068 RID: 104
		private SiticoneDragControl e;

		// Token: 0x04000069 RID: 105
		private SiticoneControlBox f;

		// Token: 0x0400006A RID: 106
		private SiticoneControlBox g;

		// Token: 0x0400006B RID: 107
		private SiticoneTransition h;

		// Token: 0x0400006C RID: 108
		private Label i;

		// Token: 0x0400006D RID: 109
		private Label j;

		// Token: 0x0400006E RID: 110
		private SiticoneShadowForm k;

		// Token: 0x0400006F RID: 111
		private SiticoneButton l;

		// Token: 0x04000070 RID: 112
		private SiticoneButton m;

		// Token: 0x04000071 RID: 113
		private SiticoneTextBox n;

		// Token: 0x04000072 RID: 114
		private Label o;

		// Token: 0x04000073 RID: 115
		private Label p;

		// Token: 0x04000074 RID: 116
		private SiticoneTextBox q;

		// Token: 0x04000075 RID: 117
		private Label r;

		// Token: 0x04000076 RID: 118
		private Label s;

		// Token: 0x04000077 RID: 119
		private SiticoneTextBox t;

		// Token: 0x04000078 RID: 120
		private Label u;

		// Token: 0x04000079 RID: 121
		private SiticoneTextBox v;

		// Token: 0x0400007A RID: 122
		private SiticoneButton w;

		// Token: 0x0400007B RID: 123
		private SiticoneButton x;

		// Token: 0x0400007C RID: 124
		private SiticoneTextBox y;

		// Token: 0x0400007D RID: 125
		private SiticoneLabel z;

		// Token: 0x0400007E RID: 126
		private System.Windows.Forms.Timer aa;

		// Token: 0x0400007F RID: 127
		private System.Windows.Forms.Timer ab;
	}
}
