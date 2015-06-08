using HipChatAPI.Model;
using HipChatAPI.Utils;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatCreateWebhookRequest
	{
		/// <summary>
		/// The id or name of the room
		/// 
		/// Valid length range: 1 - 100.
		/// </summary>
		[JsonProperty("room_id_or_name")]
		public string RoomIdOrName { get; private set; }

		/// <summary>
		/// Request object for CreateWebhook Resource
		/// </summary>
		/// <param name="roomIdOrName">ID or Name of Room</param>
		/// <param name="url">URL to sent webhook</param>
		/// <param name="roomEvent">Event to list for</param>
		public HipChatCreateWebhookRequest(string roomIdOrName, string url, HipChatRoomEvent roomEvent)
		{
			ArgumentHelper.CheckNullEmptyAndCharLimit(roomIdOrName, "Room ID/Name", HipChatCharLimits.RoomIdOrName);
			RoomIdOrName = roomIdOrName;
			Url = url;
			Event = roomEvent;
		}

		/// <summary>
		/// The URL to send the webhook POST to
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; private set; }

		/// <summary>
		/// The regular expression pattern to match against messages. Only applicable for message events.
		/// </summary>
		[JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
		public string Pattern { get; set; }

		/// <summary>
		///  The event to listen for
		/// 
		/// Valid values: room_message, room_notification, room_exit, room_enter, room_topic_change
		/// </summary>
		[JsonProperty("event")]
		public HipChatRoomEvent Event { get; private set; }

		/// <summary>
		///  The label for this webhook 
		/// </summary>
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
	}
}
