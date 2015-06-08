using System;
using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatCreateRoomRequest
	{
		/// <summary>
		/// NameOrId of the room. 
		/// Valid length range: 1 - 50.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; private set; }

		/// <summary>
		/// The topic for the new room. 
		/// May be null.
		/// </summary>
		[JsonProperty("topic")]
		public string Topic { get; set; }

		/// <summary>
		/// Request associated to CreateRoom resource.
		/// </summary>
		/// <param name="name">NameOrId of the room. Valid length range: 1 - 50.</param>
		public HipChatCreateRoomRequest(string name)
		{
			if (String.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException("name must be non-null and contain non-space characters");
			}
			if (name.Length > 50)
			{
				throw new ArgumentException("NameOrId must not exceed character limit of 50");
			}
			Name = name;
		}

		/// <summary>
		/// Whether or not to enable guest access for this room.
		/// 
		/// Defaults to false.
		/// </summary>
		[JsonProperty("guest_access", NullValueHandling = NullValueHandling.Ignore)]
		public bool? GuestAccessEnabled { get; set; }

		/// <summary>
		/// The id, email address, or mention name (beginning with an '@') of the room's owner. 
		/// Defaults to the current user
		/// </summary>
		[JsonProperty("owner_user_id", NullValueHandling = NullValueHandling.Ignore)]
		public string OwnerUserId { get; set; }


		/// <summary>
		/// Whether the room is available for access by other users or not. 
		/// Valid values: public, private.
		/// Defaults to 'public'.
		/// </summary>
		[JsonProperty("privacy", NullValueHandling = NullValueHandling.Ignore)]
		public HipChatRoomPrivacy? Privacy { get; set; }
	}
}
