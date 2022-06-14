namespace Lean.Forms
{
	// Token: 0x02000009 RID: 9
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x0600009D RID: 157 RVA: 0x0000EF80 File Offset: 0x0000D180
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.e != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.e.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000019 RID: 25
		private global::System.ComponentModel.IContainer e = null;
	}
}
