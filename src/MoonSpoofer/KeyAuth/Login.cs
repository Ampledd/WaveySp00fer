using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace KeyAuth
{
	// Token: 0x02000008 RID: 8
	public partial class Login : Form
	{
		// Token: 0x06000075 RID: 117 RVA: 0x0000B7CD File Offset: 0x000099CD
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000B7E5 File Offset: 0x000099E5
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000077 RID: 119
		private void timer1_Tick(object sender, EventArgs e)
		{
			Process[] processesByName16 = Process.GetProcessesByName("ida64");
			Process[] processesByName2 = Process.GetProcessesByName("ida32");
			Process[] processesByName3 = Process.GetProcessesByName("ollydbg");
			Process[] processesByName4 = Process.GetProcessesByName("ollydbg64");
			Process[] processesByName5 = Process.GetProcessesByName("loaddll");
			Process[] processesByName6 = Process.GetProcessesByName("httpdebugger");
			Process[] processesByName7 = Process.GetProcessesByName("windowrenamer");
			Process[] processesByName8 = Process.GetProcessesByName("processhacker");
			Process[] processesByName9 = Process.GetProcessesByName("Process Hacker");
			Process[] processesByName10 = Process.GetProcessesByName("ProcessHacker");
			Process[] processesByName11 = Process.GetProcessesByName("HxD");
			Process[] processesByName12 = Process.GetProcessesByName("parsecd");
			Process[] processesByName13 = Process.GetProcessesByName("ida");
			Process[] processesByName14 = Process.GetProcessesByName("dnSpy");
			Process[] processesByName15 = Process.GetProcessesByName("MegaDumper");
			if (processesByName16.Length == 0 && processesByName2.Length == 0 && processesByName3.Length == 0 && processesByName4.Length == 0 && processesByName5.Length == 0 && processesByName6.Length == 0 && processesByName7.Length == 0 && processesByName8.Length == 0 && processesByName9.Length == 0 && processesByName10.Length == 0 && processesByName11.Length == 0 && processesByName13.Length == 0 && processesByName12.Length == 0 && processesByName14.Length == 0)
			{
				int num = processesByName15.Length;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000B914 File Offset: 0x00009B14
		private void Login_Load(object sender, EventArgs e)
		{
			Login.KeyAuthApp.init();
			bool flag = Login.KeyAuthApp.response.message == "invalidver";
			if (flag)
			{
				bool flag2 = !string.IsNullOrEmpty(Login.KeyAuthApp.app_data.downloadLink);
				if (flag2)
				{
					DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
					DialogResult dialogResult2 = dialogResult;
					DialogResult dialogResult3 = dialogResult2;
					if (dialogResult3 != DialogResult.Yes)
					{
						if (dialogResult3 != DialogResult.No)
						{
							MessageBox.Show("Invalid option");
							Environment.Exit(0);
						}
						else
						{
							WebClient webClient = new WebClient();
							string text = Application.ExecutablePath;
							string str = Login.random_string();
							text = text.Replace(".exe", "-" + str + ".exe");
							webClient.DownloadFile(Login.KeyAuthApp.app_data.downloadLink, text);
							Process.Start(text);
							Process.Start(new ProcessStartInfo
							{
								Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
								WindowStyle = ProcessWindowStyle.Hidden,
								CreateNoWindow = true,
								FileName = "cmd.exe"
							});
							Environment.Exit(0);
						}
					}
					else
					{
						Process.Start(Login.KeyAuthApp.app_data.downloadLink);
						Environment.Exit(0);
					}
				}
				MessageBox.Show("Posiadasz star¹ wersjê programu, pobierz now¹ za pomoc¹ komendy !download z kana³u #cmds na discordzie discord.gg/uran");
				Thread.Sleep(2500);
				Environment.Exit(0);
			}
			bool flag3 = !Login.KeyAuthApp.response.success;
			if (flag3)
			{
				MessageBox.Show(Login.KeyAuthApp.response.message);
				Environment.Exit(0);
			}
			Login.KeyAuthApp.check();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000BACC File Offset: 0x00009CCC
		private static string random_string()
		{
			string text = null;
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
			}
			return text;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000BB35 File Offset: 0x00009D35
		private void UpgradeBtn_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000BB38 File Offset: 0x00009D38
		private void LoginBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.login(this.username.Text, this.textBox1.Text);
			bool success = Login.KeyAuthApp.response.success;
			if (success)
			{
				Main main = new Main();
				main.Show();
				base.Hide();
			}
			else
			{
				MessageBox.Show("Username or password is invalid!");
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000BB9F File Offset: 0x00009D9F
		private void RgstrBtn_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000BBA2 File Offset: 0x00009DA2
		private void LicBtn_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000BBA5 File Offset: 0x00009DA5
		private void username_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000BBA8 File Offset: 0x00009DA8
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000BBAC File Offset: 0x00009DAC
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.username.Text, this.textBox1.Text, this.textBox4.Text);
			bool success = Login.KeyAuthApp.response.success;
			if (success)
			{
				Main main = new Main();
				main.Show();
				base.Hide();
			}
			else
			{
				MessageBox.Show("License is invalid!");
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000BC1C File Offset: 0x00009E1C
		private void guna2Button6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000BC1F File Offset: 0x00009E1F
		private void guna2Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000BC22 File Offset: 0x00009E22
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000BC28 File Offset: 0x00009E28
		private void siticoneRoundedButton3_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.username.Text, this.textBox1.Text, this.textBox4.Text);
			bool success = Login.KeyAuthApp.response.success;
			if (success)
			{
				Main main = new Main();
				main.Show();
				base.Hide();
			}
			else
			{
				MessageBox.Show("License is invalid!");
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000BC98 File Offset: 0x00009E98
		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000BC9C File Offset: 0x00009E9C
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.login(this.username.Text, this.textBox1.Text);
			bool success = Login.KeyAuthApp.response.success;
			if (success)
			{
				Main main = new Main();
				main.Show();
				base.Hide();
			}
			else
			{
				MessageBox.Show("Username or password is invalid!");
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000BD08 File Offset: 0x00009F08
		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
			bool flag = this.guna2Button1.BorderThickness == 0;
			if (flag)
			{
				MessageBox.Show("To register please fill in username, password and license (Click the button again)");
				this.guna2Button1.BorderThickness = 1;
			}
			else
			{
				Login.KeyAuthApp.register(this.username.Text, this.textBox1.Text, this.textBox4.Text);
				bool success = Login.KeyAuthApp.response.success;
				if (success)
				{
					Main main = new Main();
					main.Show();
					base.Hide();
				}
				else
				{
					MessageBox.Show("License is invalid!");
				}
			}
			this.guna2Panel1.Show();
		}

		// Token: 0x0400005B RID: 91
		public static api KeyAuthApp = new api("WaveSp00fer", "EomyF0SC3B", "99344f825df558fa7c03c54c4a5b0992b4df5d18051fde96ec32466e66002ddb", "1.0");
	}
}
