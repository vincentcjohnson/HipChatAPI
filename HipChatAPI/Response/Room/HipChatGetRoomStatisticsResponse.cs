using System;
using Newtonsoft.Json;

namespace HipChatAPI.Response.Room
{
	/// <summary>
	/// Response for GetRoomStatistics resource
	/// </summary>
	public class HipChatGetRoomStatisticsResponse
	{
		/// <summary>
		/// The number of messages sent in this room for its entire history.
		/// </summary>
		[JsonProperty("messages_sent")]
		public int MessagesSent { get; set; }

		/// <summary>
		/// Time of last activity (sent message) in the room in UNIX time (UTC). 
		/// 
		/// 
		/// May be null in rare cases when the time is unknown.
		/// </summary>
		[JsonProperty("last_active")]
		public DateTime LastActive { get; set; }
	}
}
