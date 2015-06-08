using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Response.Room
{
	public class HipChatCreateRoomResponse
	{
		/// <summary>
		/// Unique identifier for the created room.
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Links
		/// </summary>
		[JsonProperty("links")]
		public HipChatLink Links { get; set; }
	}
}
