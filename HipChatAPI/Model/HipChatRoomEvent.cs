using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HipChatAPI.Model
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HipChatRoomEvent
	{
		[JsonProperty("room_message")]
		RoomMessage,

		[JsonProperty("room_notification")]
		RoomNotification,

		[JsonProperty("room_exit")]
		RoomExit,

		[JsonProperty("room_enter")]
		RoomEnter,

		[JsonProperty("room_topic_change")]
		RoomTopicChange
	}
}
