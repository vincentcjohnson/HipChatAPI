using Newtonsoft.Json;

namespace HipChatAPI.Model
{
	public class HipChatUser
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("mention_name")]
		public string MentionName { get; set; }

		[JsonProperty("links")]
		public HipChatLink Links { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
