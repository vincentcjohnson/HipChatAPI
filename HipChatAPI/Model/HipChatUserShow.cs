using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HipChatAPI.Model
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HipChatUserShow
	{
		[JsonProperty("away")]
		Away,

		[JsonProperty("chat")]
		Chat,

		[JsonProperty("dnd")]
		DnD,

		[JsonProperty("xa")]
		Xa
	}
}
