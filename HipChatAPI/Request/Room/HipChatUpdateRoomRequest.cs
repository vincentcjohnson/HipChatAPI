using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatUpdateRoomRequest
	{
		/// <summary>
		/// Name of the room
		/// 
		/// Valid length range: 1 - 50.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Whether the room is available for access by other users or not
		/// Valid values: public, private.
		/// 
		/// Defaults to 'public'.
		/// </summary>
		[JsonProperty("privacy")]
		public HipChatRoomPrivacy Privacy { get; set; }

		/// <summary>
		/// Whether the room should be archived or not.
		/// 
		/// Defaults to false.
		/// </summary>
		[JsonProperty("is_archived")]
		public bool IsArchived { get; set; }

		/// <summary>
		/// Whether or not to enable guest access for this room.
		/// 
		/// Defaults to false.
		/// </summary>
		[JsonProperty("is_guest_accessible")]
		public bool IsGuestAccessbile { get; set; }

		/// <summary>
		/// The new topic for the room.
		/// </summary>
		[JsonProperty("topic")]
		public string Topic { get; set; }

		/// <summary>
		/// The room owner.
		/// </summary>
		[JsonProperty("owner")]
		public HipChatUser Owner { get; set; }
	}
}
