using Newtonsoft.Json;

namespace HipChatAPI.Model
{
	public class HipChatWebhook
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("links")]
		public HipChatLink Links { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("pattern")]
		public string Pattern { get; set; }

		[JsonProperty("event")]
		public HipChatRoomEvent Event { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }
	}
}
