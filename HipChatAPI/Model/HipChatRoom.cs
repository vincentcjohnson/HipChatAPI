using Newtonsoft.Json;

namespace HipChatAPI.Model
{
	public class HipChatRoom
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("links")]
		public HipChatLink Links { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
