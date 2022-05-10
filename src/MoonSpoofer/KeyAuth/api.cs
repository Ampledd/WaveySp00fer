using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000004 RID: 4
	public class api
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000020FC File Offset: 0x000002FC
		public api(string name, string ownerid, string secret, string version)
		{
			bool flag = string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version);
			if (flag)
			{
				api.error("Application not setup correctly.");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000219C File Offset: 0x0000039C
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			bool flag = text2 == "KeyAuth_Invalid";
			if (flag)
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_app_data(response_structure.appinfo);
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
			}
			else
			{
				bool flag2 = response_structure.message == "invalidver";
				if (flag2)
				{
					this.app_data.downloadLink = response_structure.download;
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002340 File Offset: 0x00000540
		public static bool IsDebugRelease
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002354 File Offset: 0x00000554
		public void Checkinit()
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				bool isDebugRelease = api.IsDebugRelease;
				if (isDebugRelease)
				{
					api.error("Not initialized Check if KeyAuthApp.init() does exist");
				}
				else
				{
					api.error("Please initialize first");
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002398 File Offset: 0x00000598
		public void register(string username, string pass, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000250C File Offset: 0x0000070C
		public void login(string username, string pass)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002664 File Offset: 0x00000864
		public void upgrade(string username, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			response_structure.success = false;
			this.load_response_struct(response_structure);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002794 File Offset: 0x00000994
		public void license(string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000028D4 File Offset: 0x00000AD4
		public void check()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("check"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000029B4 File Offset: 0x00000BB4
		public void setvar(string var, string data)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data2 = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002AC8 File Offset: 0x00000CC8
		public string getvar(string var)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
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

		// Token: 0x06000013 RID: 19 RVA: 0x00002BE0 File Offset: 0x00000DE0
		public void ban()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002CC0 File Offset: 0x00000EC0
		public string var(string varid)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
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

		// Token: 0x06000015 RID: 21 RVA: 0x00002DEC File Offset: 0x00000FEC
		public List<api.msg> chatget(string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
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

		// Token: 0x06000016 RID: 22 RVA: 0x00002F04 File Offset: 0x00001104
		public bool chatsend(string msg, string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.enckey, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003030 File Offset: 0x00001230
		public bool checkblack()
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003154 File Offset: 0x00001354
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
			nameValueCollection["body"] = encryption.encrypt(body, this.enckey, text);
			nameValueCollection["conttype"] = encryption.encrypt(conttype, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
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

		// Token: 0x06000019 RID: 25 RVA: 0x000032B8 File Offset: 0x000014B8
		public byte[] download(string fileid)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
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

		// Token: 0x0600001A RID: 26 RVA: 0x000033D4 File Offset: 0x000015D4
		public void log(string message)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			api.req(post_data);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000034C8 File Offset: 0x000016C8
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003548 File Offset: 0x00001748
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000035A0 File Offset: 0x000017A0
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
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
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("Zbyt szybko podejmujesz akcje, zwolnij troche!");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003654 File Offset: 0x00001854
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000036BC File Offset: 0x000018BC
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003736 File Offset: 0x00001936
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x04000004 RID: 4
		public string name;

		// Token: 0x04000005 RID: 5
		public string ownerid;

		// Token: 0x04000006 RID: 6
		public string secret;

		// Token: 0x04000007 RID: 7
		public string version;

		// Token: 0x04000008 RID: 8
		private string sessionid;

		// Token: 0x04000009 RID: 9
		private string enckey;

		// Token: 0x0400000A RID: 10
		private bool initzalized;

		// Token: 0x0400000B RID: 11
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x0400000C RID: 12
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400000D RID: 13
		public api.response_class response = new api.response_class();

		// Token: 0x0400000E RID: 14
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x0200000A RID: 10
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600008C RID: 140 RVA: 0x0000CA72 File Offset: 0x0000AC72
			// (set) Token: 0x0600008D RID: 141 RVA: 0x0000CA7A File Offset: 0x0000AC7A
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600008E RID: 142 RVA: 0x0000CA83 File Offset: 0x0000AC83
			// (set) Token: 0x0600008F RID: 143 RVA: 0x0000CA8B File Offset: 0x0000AC8B
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000090 RID: 144 RVA: 0x0000CA94 File Offset: 0x0000AC94
			// (set) Token: 0x06000091 RID: 145 RVA: 0x0000CA9C File Offset: 0x0000AC9C
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000092 RID: 146 RVA: 0x0000CAA5 File Offset: 0x0000ACA5
			// (set) Token: 0x06000093 RID: 147 RVA: 0x0000CAAD File Offset: 0x0000ACAD
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000094 RID: 148 RVA: 0x0000CAB6 File Offset: 0x0000ACB6
			// (set) Token: 0x06000095 RID: 149 RVA: 0x0000CABE File Offset: 0x0000ACBE
			[DataMember]
			public string message { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000096 RID: 150 RVA: 0x0000CAC7 File Offset: 0x0000ACC7
			// (set) Token: 0x06000097 RID: 151 RVA: 0x0000CACF File Offset: 0x0000ACCF
			[DataMember]
			public string download { get; set; }

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000098 RID: 152 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
			// (set) Token: 0x06000099 RID: 153 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600009A RID: 154 RVA: 0x0000CAE9 File Offset: 0x0000ACE9
			// (set) Token: 0x0600009B RID: 155 RVA: 0x0000CAF1 File Offset: 0x0000ACF1
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600009C RID: 156 RVA: 0x0000CAFA File Offset: 0x0000ACFA
			// (set) Token: 0x0600009D RID: 157 RVA: 0x0000CB02 File Offset: 0x0000AD02
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x0200000B RID: 11
		public class msg
		{
			// Token: 0x1700000E RID: 14
			// (get) Token: 0x0600009F RID: 159 RVA: 0x0000CB14 File Offset: 0x0000AD14
			// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000CB1C File Offset: 0x0000AD1C
			public string message { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000CB25 File Offset: 0x0000AD25
			// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000CB2D File Offset: 0x0000AD2D
			public string author { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000CB36 File Offset: 0x0000AD36
			// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000CB3E File Offset: 0x0000AD3E
			public string timestamp { get; set; }
		}

		// Token: 0x0200000C RID: 12
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000CB50 File Offset: 0x0000AD50
			// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000CB58 File Offset: 0x0000AD58
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000CB61 File Offset: 0x0000AD61
			// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000CB69 File Offset: 0x0000AD69
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060000AA RID: 170 RVA: 0x0000CB72 File Offset: 0x0000AD72
			// (set) Token: 0x060000AB RID: 171 RVA: 0x0000CB7A File Offset: 0x0000AD7A
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060000AC RID: 172 RVA: 0x0000CB83 File Offset: 0x0000AD83
			// (set) Token: 0x060000AD RID: 173 RVA: 0x0000CB8B File Offset: 0x0000AD8B
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000AE RID: 174 RVA: 0x0000CB94 File Offset: 0x0000AD94
			// (set) Token: 0x060000AF RID: 175 RVA: 0x0000CB9C File Offset: 0x0000AD9C
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000CBA5 File Offset: 0x0000ADA5
			// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000CBAD File Offset: 0x0000ADAD
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200000D RID: 13
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000CBBF File Offset: 0x0000ADBF
			// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000CBC7 File Offset: 0x0000ADC7
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
			// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000CBD8 File Offset: 0x0000ADD8
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000CBE1 File Offset: 0x0000ADE1
			// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000CBE9 File Offset: 0x0000ADE9
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000CBF2 File Offset: 0x0000ADF2
			// (set) Token: 0x060000BA RID: 186 RVA: 0x0000CBFA File Offset: 0x0000ADFA
			[DataMember]
			public string version { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000BB RID: 187 RVA: 0x0000CC03 File Offset: 0x0000AE03
			// (set) Token: 0x060000BC RID: 188 RVA: 0x0000CC0B File Offset: 0x0000AE0B
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000BD RID: 189 RVA: 0x0000CC14 File Offset: 0x0000AE14
			// (set) Token: 0x060000BE RID: 190 RVA: 0x0000CC1C File Offset: 0x0000AE1C
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x0200000E RID: 14
		public class app_data_class
		{
			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000CC2E File Offset: 0x0000AE2E
			// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000CC36 File Offset: 0x0000AE36
			public string numUsers { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000CC3F File Offset: 0x0000AE3F
			// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000CC47 File Offset: 0x0000AE47
			public string numOnlineUsers { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000CC50 File Offset: 0x0000AE50
			// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000CC58 File Offset: 0x0000AE58
			public string numKeys { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000CC61 File Offset: 0x0000AE61
			// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000CC69 File Offset: 0x0000AE69
			public string version { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000CC72 File Offset: 0x0000AE72
			// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000CC7A File Offset: 0x0000AE7A
			public string customerPanelLink { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000CA RID: 202 RVA: 0x0000CC83 File Offset: 0x0000AE83
			// (set) Token: 0x060000CB RID: 203 RVA: 0x0000CC8B File Offset: 0x0000AE8B
			public string downloadLink { get; set; }
		}

		// Token: 0x0200000F RID: 15
		public class user_data_class
		{
			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000CD RID: 205 RVA: 0x0000CC9D File Offset: 0x0000AE9D
			// (set) Token: 0x060000CE RID: 206 RVA: 0x0000CCA5 File Offset: 0x0000AEA5
			public string username { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000CF RID: 207 RVA: 0x0000CCAE File Offset: 0x0000AEAE
			// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000CCB6 File Offset: 0x0000AEB6
			public string ip { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000CCBF File Offset: 0x0000AEBF
			// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000CCC7 File Offset: 0x0000AEC7
			public string hwid { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000CCD0 File Offset: 0x0000AED0
			// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000CCD8 File Offset: 0x0000AED8
			public string createdate { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000CCE1 File Offset: 0x0000AEE1
			// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000CCE9 File Offset: 0x0000AEE9
			public string lastlogin { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000CCF2 File Offset: 0x0000AEF2
			// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000CCFA File Offset: 0x0000AEFA
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000010 RID: 16
		public class Data
		{
			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000DA RID: 218 RVA: 0x0000CD0C File Offset: 0x0000AF0C
			// (set) Token: 0x060000DB RID: 219 RVA: 0x0000CD14 File Offset: 0x0000AF14
			public string subscription { get; set; }

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060000DC RID: 220 RVA: 0x0000CD1D File Offset: 0x0000AF1D
			// (set) Token: 0x060000DD RID: 221 RVA: 0x0000CD25 File Offset: 0x0000AF25
			public string expiry { get; set; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060000DE RID: 222 RVA: 0x0000CD2E File Offset: 0x0000AF2E
			// (set) Token: 0x060000DF RID: 223 RVA: 0x0000CD36 File Offset: 0x0000AF36
			public string timeleft { get; set; }
		}

		// Token: 0x02000011 RID: 17
		public class response_class
		{
			// Token: 0x1700002C RID: 44
			// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000CD48 File Offset: 0x0000AF48
			// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000CD50 File Offset: 0x0000AF50
			public bool success { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000CD59 File Offset: 0x0000AF59
			// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000CD61 File Offset: 0x0000AF61
			public string message { get; set; }
		}
	}
}
