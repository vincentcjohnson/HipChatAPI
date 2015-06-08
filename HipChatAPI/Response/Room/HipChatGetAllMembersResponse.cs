using System.Collections.Generic;
using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Response.Room
{
	public class HipChatGetAllMembersResponse
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("items")]
		public List<HipChatItem> Items { get; set; }

		[JsonProperty("startIndex")]
		public int StartIndex { get; set; }

		[JsonProperty("maxResults")]
		public int MaxResults { get; set; }

		[JsonProperty("links")]
		public HipChatLink Links { get; set; }
	}
}
