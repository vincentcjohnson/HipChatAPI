using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatViewRecentRoomHistoryRequest
	{
		[JsonProperty("id_or_name")]
		public string NameOrId { get; set; }

		public HipChatViewRecentRoomHistoryRequest(string nameOrId)
		{
			NameOrId = nameOrId;
		}

		[JsonProperty("max-results", NullValueHandling = NullValueHandling.Ignore)]
		public int MaxResults { get; set; }

		[JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
		public HipChatTimeZone TimeZone { get; set; }

		[JsonProperty("not-before", NullValueHandling = NullValueHandling.Ignore)]
		public string NotBefore { get; set; }
	}
}
