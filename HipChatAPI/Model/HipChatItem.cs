using Newtonsoft.Json;

namespace HipChatAPI.Model
{
	public class HipChatItem
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("links")]
		public HipChatLink Links { get; set; }

		[JsonProperty("from")]
		public HipChatUser From { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("mention_name")]
		public string MentionName { get; set; }
	}
}
