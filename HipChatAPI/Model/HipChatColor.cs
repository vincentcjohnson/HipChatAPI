using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HipChatAPI.Model
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HipChatColor
	{
		[JsonProperty("yellow")]
		Yellow,
		[JsonProperty("green")]
		Green,
		[JsonProperty("red")]
		Red,
		[JsonProperty("purple")]
		Purple,
		[JsonProperty("gray")]
		Gray,
		[JsonProperty("random")]
		Random
	}
}
