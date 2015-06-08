using System.Collections.Generic;
using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Response.Room
{
	public class HipChatViewRecentRoomHistoryResponse
	{
		[JsonProperty("items")]
		public List<HipChatMessage> Messages { get; set; }
	}
}
