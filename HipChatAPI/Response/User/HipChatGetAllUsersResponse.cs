using System.Collections.Generic;
using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Response.User
{
	public class HipChatGetAllUsersResponse
	{
		[JsonProperty("items")]
		public List<HipChatUser> Users { get; set; }

		[JsonProperty("startIndex")]
		public int StartIndex { get; set; }

		[JsonProperty("maxResults")]
		public int MaxResults { get; set; }

		[JsonProperty("links")]
		public HipChatLink Links { get; set; }
	}
}
