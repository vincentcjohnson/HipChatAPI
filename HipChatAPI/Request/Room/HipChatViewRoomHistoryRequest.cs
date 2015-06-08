using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatViewRoomHistoryRequest
	{
		/// <summary>
		/// Name or ID
		/// </summary>
		[JsonProperty("id_or_name")]
		public string NameOrId { get; set; }

		/// <summary>
		/// View Recent Room History Request
		/// </summary>
		/// <param name="roomNameOrId">Room Name</param>
		public HipChatViewRoomHistoryRequest(string roomNameOrId)
		{
			NameOrId = roomNameOrId;
		}

		[JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
		public string Date { get; set; }

		[JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
		public HipChatTimeZone TimeZone { get; set; }

		[JsonProperty("start-index", NullValueHandling = NullValueHandling.Ignore)]
		public int StartIndex { get; set; }

		[JsonProperty("max-results", NullValueHandling = NullValueHandling.Ignore)]
		public int MaxResults { get; set; }
	}
}
