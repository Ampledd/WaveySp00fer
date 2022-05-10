﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000006 RID: 6
	public class json_wrapper
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00003AB8 File Offset: 0x00001CB8
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003AD8 File Offset: 0x00001CD8
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			bool flag = !json_wrapper.is_serializable(type);
			if (flag)
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003B30 File Offset: 0x00001D30
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003B7C File Offset: 0x00001D7C
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x0400000F RID: 15
		private DataContractJsonSerializer serializer;

		// Token: 0x04000010 RID: 16
		private object current_object;
	}
}
