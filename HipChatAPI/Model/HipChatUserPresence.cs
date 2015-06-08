using Newtonsoft.Json;

namespace HipChatAPI.Model
{
	public class HipChatUserPresence
	{
		/// <summary>
		/// The status message of the user
		/// </summary>
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
		public string Status { get; set; }

		/// <summary>
		/// The number of seconds this user has been idle
		/// </summary>
		[JsonProperty("idle", NullValueHandling = NullValueHandling.Ignore)]
		public int Idle { get; set; }

		/// <summary>
		/// The status to show for the user
		/// 
		/// Valid values: away, chat, dnd, xa.
		/// </summary>
		[JsonProperty("show")]
		public HipChatUserShow? Show { get; set; }

		/// <summary>
		/// Information about the client connected to HipChat. 
		/// Only shown if the client is currently online.
		/// </summary>
		[JsonProperty("client", NullValueHandling = NullValueHandling.Ignore)]
		public HipChatUserClient Client { get; set; }

		/// <summary>
		/// If the user is currently online or not
		/// </summary>
		[JsonProperty("is_online", NullValueHandling = NullValueHandling.Ignore)]
		public bool IsOnline { get; set; }
	}
}
