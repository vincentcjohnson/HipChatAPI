using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HipChatAPI.Model
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HipChatMessageFormat
	{
		[JsonProperty("html")]
		Html,

		[JsonProperty("text")]
		Text
	}
}
