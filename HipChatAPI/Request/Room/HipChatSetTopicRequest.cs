using HipChatAPI.Utils;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatSetTopicRequest
	{
		/// <summary>
		/// The id or name of the room
		/// 
		/// Valid length range: 1 - 100.
		/// </summary>
		[JsonProperty("id_or_name")]
		public string RoomIdOrName { get; private set; }

		/// <summary>
		/// Request for topic resource
		/// </summary>
		/// <param name="roomIdOrName">ID or Name of Room</param>
		/// <param name="topic">Topic of Room</param>
		public HipChatSetTopicRequest(string roomIdOrName, string topic)
		{
			ArgumentHelper.CheckNullEmptyAndCharLimit(roomIdOrName, "Room ID/Name", HipChatCharLimits.RoomIdOrName);
			ArgumentHelper.CheckNullEmptyAndCharLimit(topic, "Topic", HipChatCharLimits.Topic);
			RoomIdOrName = roomIdOrName;
			Topic = topic;
		}

		/// <summary>
		///  The topic body
		/// 
		/// Valid length range: 0 - 250.
		/// </summary>
		[JsonProperty("topic")]
		public string Topic { get; private set; }
	}
}
