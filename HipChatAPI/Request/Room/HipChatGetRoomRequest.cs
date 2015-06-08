using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatGetRoomRequest
	{
		/// <summary>
		/// The id or name of the room
		/// 
		/// Valid length range: 1 - 100.
		/// </summary>
		[JsonProperty("room_id_or_name")]
		public string NameOrId { get; set; }

		/// <summary>
		/// Request associated to GetRoom resource.
		/// </summary>
		/// <param name="nameOrId"></param>
		public HipChatGetRoomRequest(string nameOrId)
		{
			NameOrId = nameOrId;
		}
	}
}
