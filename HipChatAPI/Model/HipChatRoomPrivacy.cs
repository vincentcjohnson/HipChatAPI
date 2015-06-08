using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HipChatAPI.Model
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HipChatRoomPrivacy
	{
		[EnumMember(Value = "public")]
		Public,

		[EnumMember(Value = "private")]
		Private
	}
}
