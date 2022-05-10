using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.Win32;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace KeyAuth
{
	// Token: 0x02000007 RID: 7
	public partial class Main : Form
	{
		// Token: 0x0600002D RID: 45
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002E RID: 46
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600002F RID: 47
		private void Main_Load(object sender, EventArgs e)
		{
			Main.KeyAuthApp.init();
			this.nazwa.Text = "Reversed by ReverseBeam";
			this.dokiedy.Text = "Reversed by ReverseBeam";
			this.createDate.Text = "Reversed by ReverseBeam";
			this.version.Text = "Reversed by ReverseBeam";
		}

		// Token: 0x06000030 RID: 48
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x06000031 RID: 49
		private void subscriptionDaysLabel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000032 RID: 50
		private void expiry_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000033 RID: 51
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This will be introduced in 3.0");
		}

		// Token: 0x06000034 RID: 52
		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000035 RID: 53
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000036 RID: 54
		private void key_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000037 RID: 55
		private void guna2Button5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000038 RID: 56
		private void guna2Button7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000039 RID: 57
		private void guna2Button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003A RID: 58
		private void guna2Button3_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003B RID: 59
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc STARCHARMS_SPOOFER");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
				streamWriter.WriteLine(":folderclean");
				streamWriter.WriteLine("call :getDiscordVersion");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("goto :xboxclean");
				streamWriter.WriteLine(": getDiscordVersion");
				streamWriter.WriteLine("for / d %% a in (' % appdata%\\Discord\\*') do (");
				streamWriter.WriteLine("     set 'varLoc =%%a'");
				streamWriter.WriteLine("   goto :d1");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine(":d1");
				streamWriter.WriteLine("for / f 'delims =\\ tokens=7' %% z in ('echo %varLoc%') do (");
				streamWriter.WriteLine("     set 'discordVersion =%%z'");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine("goto :EOF");
				streamWriter.WriteLine(": xboxclean");
				streamWriter.WriteLine(" cls");
				streamWriter.WriteLine("powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
				streamWriter.WriteLine("sc stop XblAuthManager");
				streamWriter.WriteLine("sc stop XblGameSave");
				streamWriter.WriteLine("sc stop XboxNetApiSvc");
				streamWriter.WriteLine("sc stop XboxGipSvc");
				streamWriter.WriteLine("sc delete XblAuthManager");
				streamWriter.WriteLine("sc delete XblGameSave");
				streamWriter.WriteLine("sc delete XboxNetApiSvc");
				streamWriter.WriteLine("sc delete XboxGipSvc");
				streamWriter.WriteLine("reg delete 'HKLM\\SYSTEM\\CurrentControlSet\\Services\\xbgm' / f");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTask' / disable");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTaskLogon' / disableL");
				streamWriter.WriteLine("reg add 'HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("   echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
				streamWriter.WriteLine("   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s");
				streamWriter.WriteLine("exit");
				streamWriter.WriteLine("goto :eof");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("Unlinked successfully");
		}

		// Token: 0x0600003C RID: 60
		private void guna2Button4_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003D RID: 61
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This will be introduced in 3.0");
		}

		// Token: 0x0600003E RID: 62
		private void guna2Button3_Click_1(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill /f /im Steam.exe /t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc Skidspoofer");
				streamWriter.WriteLine("cls");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("Spoofed successfully");
		}

		// Token: 0x0600003F RID: 63
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000040 RID: 64
		private void hwidlabel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65
		private void createDate_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000042 RID: 66
		private void guna2Button2_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000043 RID: 67
		private void guna2Panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000044 RID: 68
		private void settingsBTN_Click(object sender, EventArgs e)
		{
			this.homeBTN.Checked = false;
			this.settingsBTN.Checked = true;
			this.SPOOFPANEL.Show();
			this.cleanPANEL.Hide();
			this.cleanBTN.Checked = false;
		}

		// Token: 0x06000045 RID: 69
		private void homeBTN_Click(object sender, EventArgs e)
		{
			this.settingsBTN.Checked = false;
			this.homeBTN.Checked = true;
			this.PANELhome.Show();
			this.SPOOFPANEL.Hide();
			this.cleanBTN.Checked = false;
		}

		// Token: 0x06000046 RID: 70
		private void guna2Button7_Click_1(object sender, EventArgs e)
		{
			new Login().Show();
			base.Hide();
		}

		// Token: 0x06000047 RID: 71
		private void guna2Button2_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72
		private void guna2Button2_Click_3(object sender, EventArgs e)
		{
		}

		// Token: 0x06000049 RID: 73
		private void guna2Button6_Click(object sender, EventArgs e)
		{
			Font font = new Font("Arial", 12f);
			Font font2 = new Font("Arial", 12f, FontStyle.Bold);
			if (this.guna2Button6.Text == "SHOW")
			{
				this.guna2Button6.Text = "HIDE";
				this.hwidlabel.Text = "https://discord.gg/g6srCnvxFz";
				this.hwidlabel.Font = font;
				return;
			}
			this.hwidlabel.Text = "HIDDEN";
			this.guna2Button6.Text = "SHOW";
			this.hwidlabel.Font = font2;
		}

		// Token: 0x0600004A RID: 74
		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/qF4XrsA9");
		}

		// Token: 0x0600004B RID: 75
		private void checkbox_Click_1(object sender, EventArgs e)
		{
			if (this.checkbox.FillColor == Color.FromArgb(147, 94, 255))
			{
				this.checkbox.FillColor = Color.FromArgb(9, 9, 10);
				return;
			}
			this.checkbox.FillColor = Color.FromArgb(147, 94, 255);
		}

		// Token: 0x0600004C RID: 76
		private void guna2Button2_Click_4(object sender, EventArgs e)
		{
			if (this.guna2Button2.FillColor == Color.FromArgb(147, 94, 255))
			{
				this.guna2Button2.FillColor = Color.FromArgb(9, 9, 10);
				return;
			}
			this.guna2Button2.FillColor = Color.FromArgb(147, 94, 255);
		}

		// Token: 0x0600004D RID: 77
		private void guna2Button5_Click_1(object sender, EventArgs e)
		{
			if (this.guna2Button5.FillColor == Color.FromArgb(9, 9, 10))
			{
				this.guna2Button5.FillColor = Color.FromArgb(147, 94, 255);
				this.guna2Button9.FillColor = Color.FromArgb(147, 94, 255);
				this.guna2Button8.FillColor = Color.FromArgb(147, 94, 255);
				this.guna2Button2.FillColor = Color.FromArgb(147, 94, 255);
				this.checkbox.FillColor = Color.FromArgb(147, 94, 255);
				return;
			}
			this.guna2Button5.FillColor = Color.FromArgb(9, 9, 10);
			this.guna2Button9.FillColor = Color.FromArgb(9, 9, 10);
			this.guna2Button8.FillColor = Color.FromArgb(9, 9, 10);
			this.guna2Button2.FillColor = Color.FromArgb(9, 9, 10);
			this.checkbox.FillColor = Color.FromArgb(9, 9, 10);
		}

		// Token: 0x0600004E RID: 78
		private void guna2Button9_Click(object sender, EventArgs e)
		{
			if (this.guna2Button9.FillColor == Color.FromArgb(147, 94, 255))
			{
				this.guna2Button9.FillColor = Color.FromArgb(9, 9, 10);
				return;
			}
			this.guna2Button9.FillColor = Color.FromArgb(147, 94, 255);
		}

		// Token: 0x0600004F RID: 79
		private void guna2Button8_Click(object sender, EventArgs e)
		{
			if (this.guna2Button8.FillColor == Color.FromArgb(147, 94, 255))
			{
				this.guna2Button8.FillColor = Color.FromArgb(9, 9, 10);
				return;
			}
			this.guna2Button8.FillColor = Color.FromArgb(147, 94, 255);
		}

		// Token: 0x06000050 RID: 80
		private void guna2Button12_Click(object sender, EventArgs e)
		{
			if (this.guna2Button12.FillColor == Color.FromArgb(9, 9, 10))
			{
				this.guna2Button10.FillColor = Color.FromArgb(147, 94, 255);
				this.guna2Button11.FillColor = Color.FromArgb(147, 94, 255);
				this.guna2Button14.FillColor = Color.FromArgb(147, 94, 255);
				this.guna2Button13.FillColor = Color.FromArgb(147, 94, 255);
				this.guna2Button12.FillColor = Color.FromArgb(147, 94, 255);
				return;
			}
			this.guna2Button10.FillColor = Color.FromArgb(9, 9, 10);
			this.guna2Button11.FillColor = Color.FromArgb(9, 9, 10);
			this.guna2Button14.FillColor = Color.FromArgb(9, 9, 10);
			this.guna2Button13.FillColor = Color.FromArgb(9, 9, 10);
			this.guna2Button12.FillColor = Color.FromArgb(9, 9, 10);
		}

		// Token: 0x06000051 RID: 81
		private void guna2Button10_Click(object sender, EventArgs e)
		{
			if (this.guna2Button10.FillColor == Color.FromArgb(147, 94, 255))
			{
				this.guna2Button10.FillColor = Color.FromArgb(9, 9, 10);
				return;
			}
			this.guna2Button10.FillColor = Color.FromArgb(147, 94, 255);
		}

		// Token: 0x06000052 RID: 82
		private void guna2Button11_Click(object sender, EventArgs e)
		{
			if (this.guna2Button11.FillColor == Color.FromArgb(147, 94, 255))
			{
				this.guna2Button11.FillColor = Color.FromArgb(9, 9, 10);
				return;
			}
			this.guna2Button11.FillColor = Color.FromArgb(147, 94, 255);
		}

		// Token: 0x06000053 RID: 83
		private void guna2Button14_Click(object sender, EventArgs e)
		{
			if (this.guna2Button14.FillColor == Color.FromArgb(147, 94, 255))
			{
				this.guna2Button14.FillColor = Color.FromArgb(9, 9, 10);
				return;
			}
			this.guna2Button14.FillColor = Color.FromArgb(147, 94, 255);
		}

		// Token: 0x06000054 RID: 84
		private void guna2Button13_Click(object sender, EventArgs e)
		{
			if (this.guna2Button13.FillColor == Color.FromArgb(147, 94, 255))
			{
				this.guna2Button13.FillColor = Color.FromArgb(9, 9, 10);
				return;
			}
			this.guna2Button13.FillColor = Color.FromArgb(147, 94, 255);
		}

		// Token: 0x06000055 RID: 85
		private void guna2Panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86
		private void guna2Button15_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Soon | https://discord.gg/qF4XrsA9");
		}

		// Token: 0x06000057 RID: 87
		private void guna2Button16_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Soon | https://discord.gg/qF4XrsA9");
		}

		// Token: 0x06000058 RID: 88
		private void guna2Button17_Click(object sender, EventArgs e)
		{
			this.settingsBTN.Checked = false;
			this.homeBTN.Checked = false;
			this.SPOOFPANEL.Show();
		}

		// Token: 0x06000059 RID: 89
		private void guna2Button17_Click_1(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("rmdir /s /q %LocalAppData%\\FiveM\\FiveM.app\\data");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("Skidspoofer: Cache has been cleared");
		}

		// Token: 0x0600005A RID: 90
		private void guna2Button18_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("echo Wait...");
				streamWriter.WriteLine("rmdir /s /q %LocalAppData%\\FiveM\\FiveM.app\\citizen");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("Skidspoofer: Citizen has been cleared");
		}

		// Token: 0x0600005B RID: 91
		private void guna2Button19_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("rmdir / s / q C:\\Program Files\\Epic Games\\GTAV\\reshade-shaders");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Epic Games\\GTAV\\Dxgi.dll");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Epic Games\\GTAV\\D3d10.dll");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Epic Games\\GTAV\\d3d9.dll");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Epic Games\\GTAV\\d3d8.dll");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Epic Games\\GTAV\\Dxgi.txt");
				streamWriter.WriteLine("rmdir / s / q D:\\Program Files\\Epic Games\\GTAV\\reshade-shaders");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Epic Games\\GTAV\\Dxgi.dll");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Epic Games\\GTAV\\D3d10.dll");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Epic Games\\GTAV\\d3d9.dll");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Epic Games\\GTAV\\d3d8.dll");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Epic Games\\GTAV\\dxgi.log");
				streamWriter.WriteLine("rmdir / s / q C:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\reshade-shaders");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\Dxgi.dll");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\D3d10.dll");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\d3d9.dll");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\d3d8.dll");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\Dxgi.txt");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\Dxgi.dll");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\D3d10.dll");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\d3d9.dll");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\d3d8.dll");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\Dxgi.txt");
				streamWriter.WriteLine("rmdir / s / q C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\reshade-shaders");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\Dxgi.dll");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\D3d10.dll");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\d3d9.dll");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\d3d8.dll");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\Dxgi.txt");
				streamWriter.WriteLine("rmdir / s / q D:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\reshade-shaders");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\Dxgi.dll");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\D3d10.dll");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\d3d9.dll");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\d3d8.dll");
				streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\Dxgi.txt");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\reshade-shaders");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\Dxgi.dll");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\D3d10.dll");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\d3d9.dll");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\d3d8.dll");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\Dxgi.txt");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("Skidspoofer: Reshade has been cleared");
		}

		// Token: 0x0600005C RID: 92
		private void guna2Button22_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("del /s /q %systemdrive%\\Windows\\Temp\\*.*");
				streamWriter.WriteLine("del / s / q % userprofile %\\AppData\\Local\\Temp\\*.* ");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("Skidspoofer: Temp has been cleared");
		}

		// Token: 0x0600005D RID: 93
		private void guna2Button20_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("ipconfig /flushdns");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("Skidspoofer: Dns cache has been cleared");
		}

		// Token: 0x0600005E RID: 94
		private void guna2Button21_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("del /s /q %systemdrive%\\$Recycle.bin\\*.*");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("Skidspoofer: Recycle bin has been cleared");
		}

		// Token: 0x0600005F RID: 95
		private void guna2Button24_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("set tmp2 = C:\\Windows\\Temp\\moonhelper.bat");
				streamWriter.WriteLine("echo @echo off > % tmp2 % ");
				streamWriter.WriteLine("echo title Zyorby Cleaner V2 \\ Background Apps Help >> % tmp2 %");
				streamWriter.WriteLine("echo color 03 >> % tmp2 % ");
				streamWriter.WriteLine("echo mode con:cols = 100 lines = 20 >> % tmp2 %");
				streamWriter.WriteLine("echo echo Hello if you dont know what to do in the backgound apps setting then read this: >> % tmp2 % ");
				streamWriter.WriteLine("echo echo If you want MAX Performance switch the Let apps run in the background settings to OFF >> % tmp2 %");
				streamWriter.WriteLine("echo echo. >> % tmp2 % ");
				streamWriter.WriteLine("echo echo If you want some of the apps running that you see you like leave those On and turn the rest OFF >> % tmp2 %");
				streamWriter.WriteLine("echo echo. >> % tmp2 % ");
				streamWriter.WriteLine("echo echo. >> % tmp2 %");
				streamWriter.WriteLine("echo echo. >> % tmp2 % ");
				streamWriter.WriteLine("echo echo. >> % tmp2 %");
				streamWriter.WriteLine("echo echo Please Close This Window Once You Are Done >> % tmp2 % ");
				streamWriter.WriteLine("echo set / p read = \" >> % tmp2 %");
				streamWriter.WriteLine("start C:\\Windows\\Temp\\zyorbybghelper.bat");
				streamWriter.WriteLine("start ms - settings:privacy - backgroundapps");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("Skidspoofer: Bg Apps has been disabled");
		}

		// Token: 0x06000060 RID: 96
		private void guna2Button23_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("set tmp3 = C:\\Windows\\Temp\\moon2helper.bat");
				streamWriter.WriteLine("echo @echo off > % tmp3 % ");
				streamWriter.WriteLine("echo title Zyorby Cleaner V2 \\ Startup Apps Help >> % tmp3 %");
				streamWriter.WriteLine("echo color 03 >> % tmp3 % ");
				streamWriter.WriteLine("echo mode con:cols = 100 lines = 20 >> % tmp3 %");
				streamWriter.WriteLine("echo echo Hello if you dont know what to do in the startup apps setting then read this: >> % tmp3 % ");
				streamWriter.WriteLine("echo echo. >> % tmp3 %");
				streamWriter.WriteLine("echo echo What most do here is switch all uneccesary apps off on startup >> % tmp3 % ");
				streamWriter.WriteLine("echo echo Like i turn off discord, steam, and all my peripheral apps >> % tmp3 %");
				streamWriter.WriteLine(" echo echo. >> % tmp3 % ");
				streamWriter.WriteLine("echo echo. >> % tmp3 %");
				streamWriter.WriteLine("echo echo. >> % tmp3 %");
				streamWriter.WriteLine("echo echo. >> % tmp3 %");
				streamWriter.WriteLine("echo echo Please Close This Window Once You Are Done >> % tmp3 % ");
				streamWriter.WriteLine("echo set / p read = \" >> % tmp3 %");
				streamWriter.WriteLine("start C:\\Windows\\Temp\\zyorbystartupappshelper.bat");
				streamWriter.WriteLine("start ms - settings:startupapps");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("Skidspoofer: Bg Apps has been disabled");
		}

		// Token: 0x06000061 RID: 97
		private void guna2Button17_Click_2(object sender, EventArgs e)
		{
			this.SPOOFPANEL.Show();
			this.homeBTN.Checked = false;
			this.settingsBTN.Checked = false;
		}

		// Token: 0x06000062 RID: 98
		private void guna2Button17_Click_3(object sender, EventArgs e)
		{
		}

		// Token: 0x06000063 RID: 99
		private void guna2Panel4_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000064 RID: 100
		private void guna2Button17_Click_4(object sender, EventArgs e)
		{
		}

		// Token: 0x06000065 RID: 101
		private void hotandcoldBTN_Click(object sender, EventArgs e)
		{
			Process.Start("https://mega.nz/file/OJgBFSSR#-I7eZ-QLiSyGtM_x4nzMJunJkKME9xqitV4DVL7EL9c");
		}

		// Token: 0x06000066 RID: 102
		private void redcloudsBTN_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.mediafire.com/file/73bawwffq98bp35/SuperCottonCandy-Cheeco#1111.rar/file");
		}

		// Token: 0x06000067 RID: 103
		private void blueskyBTN_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.mediafire.com/file/7kmhpz6bar3e4br/feaR+V3+Visual+Pack.rar/file");
		}

		// Token: 0x06000068 RID: 104
		private void bluelightBTN_Click(object sender, EventArgs e)
		{
			Process.Start("https://megawrzuta.pl/download/7f4178eb578dbfb19218a9800e020b01.html");
		}

		// Token: 0x06000069 RID: 105
		private void nazwa_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006A RID: 106
		private void dokiedy_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006B RID: 107
		private void SPOOFPANEL_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600006C RID: 108
		private void siticoneControlBox3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006D RID: 109
		private void siticoneControlBox4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006E RID: 110
		private void guna2Button16_Click_1(object sender, EventArgs e)
		{
			this.SPOOFPANEL.Show();
			this.cleanPANEL.Show();
			this.settingsBTN.Checked = false;
			this.homeBTN.Checked = false;
			this.cleanBTN.Checked = true;
		}

		// Token: 0x0600006F RID: 111
		private void guna2Button16_Click_2(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\browser");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashometry");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\launcher_skip_mtl2");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\session");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\plugins");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\mods");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\logs");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\crashes");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\adhesive.dll");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("WAVEY: Fivem Cache has been cleared");
		}

		// Token: 0x06000070 RID: 112
		private void guna2Button18_Click_1(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("powercfg - s 8c5e7fda - e8bf - 4a96 - 9a85 - a6e23a8c635c");
				streamWriter.WriteLine("taskkill / f / im GTAVLauncher.exe");
				streamWriter.WriteLine("wmic process where name = FiveM_b2189_GTAProcess.exe CALL setpriority 128");
				streamWriter.WriteLine("taskkill / f / im wmpnetwk.exe.exe");
				streamWriter.WriteLine("taskkill / f / im OneDrive.exe");
				streamWriter.WriteLine("taskkill / f / im speedfan.exe");
				streamWriter.WriteLine("taskkill / f / im TeamWiever_Service.exe");
				streamWriter.WriteLine("taskkill / f / im opera.exe");
				streamWriter.WriteLine("taskkill / f / im java.exed");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("WAVEY: Windows for fivem has been optimized");
		}

		// Token: 0x06000071 RID: 113
		private void guna2Button19_Click_1(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("Append Completion", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("AutoSuggest", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", true).DeleteValue("EnableAutoTray", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("AutoEndTasks", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("HungAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("WaitToKillAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("LowLevelHooksTimeout", false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoLowDiskSpaceChecks", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("LinkResolveIgnoreLinkInfo", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveSearch", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveTrack", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoInternetOpenWith", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("SFIO Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("SFIO Priority", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			MessageBox.Show("Skidspoofer: Windows has been optimized!");
		}

		// Token: 0x06000072 RID: 114
		private void guna2Button20_Click_1(object sender, EventArgs e)
		{
			Process.Start("fivem://connect/" + this.textBox1.Text);
		}

		// Token: 0x040000AE RID: 174
		public static api KeyAuthApp = new api("WaveSp00fer", "EomyF0SC3B", "99344f825df558fa7c03c54c4a5b0992b4df5d18051fde96ec32466e66002ddb", "1.0");
	}
}
