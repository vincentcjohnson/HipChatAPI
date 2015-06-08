using System.Collections.Generic;
using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Response.Room
{
	public class HipChatViewRoomHistoryResponse
	{
		[JsonProperty("items")]
		public List<HipChatMessage> Messages { get; set; }

		[JsonProperty("links")]
		public HipChatLink Links { get; set; }

		[JsonProperty("maxResults")]
		public int MaxResults { get; set; }

		[JsonProperty("startIndex")]
		public int StartIndex { get; set; }
	}
}
