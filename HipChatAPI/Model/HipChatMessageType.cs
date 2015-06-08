using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HipChatAPI.Model
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HipChatMessageType
	{
		[EnumMember(Value = "message")]
		Message,

		[EnumMember(Value = "guest_access")]
		GuestAccess,

		[EnumMember(Value = "topic")]
		Topic,

		[EnumMember(Value = "notification")]
		Notification
	}
}
