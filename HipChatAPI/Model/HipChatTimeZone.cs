using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HipChatAPI.Model
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HipChatTimeZone
	{
		[JsonProperty("UTC")]
		Utc
	}
}
